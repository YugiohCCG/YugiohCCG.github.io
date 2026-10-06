#!/usr/bin/env python3
"""Build the audited 500-image Yu-Gi-Oh! Ideogram 4 LoRA dataset.

The script deliberately separates discovery metadata from authoritative review.
YGOPRODeck is used as a convenient candidate index; final rows remain marked
pending until their identity/date/classification is checked against Konami's
official TCG database.
"""

from __future__ import annotations

import argparse
import csv
import hashlib
import json
import re
import time
import unicodedata
from collections import Counter, defaultdict
from concurrent.futures import ThreadPoolExecutor, as_completed
from datetime import date, datetime, timezone
from difflib import SequenceMatcher, get_close_matches
from io import BytesIO
from pathlib import Path
from typing import Iterable
from urllib.parse import urljoin

import requests
from bs4 import BeautifulSoup
from PIL import Image, ImageOps


ROOT = Path(__file__).resolve().parents[1]
PACKAGE = ROOT / "output" / "yugioh_ideogram4_500"
CACHE = PACKAGE / "cache"
DISCOVERY = PACKAGE / "discovery"
IMAGES = PACKAGE / "images"
CAPTIONS = PACKAGE / "captions"
SELECTED = PACKAGE / "selection"
RAW_IMAGES = CACHE / "raw-images"
SOURCE_ROOT = "https://sites.google.com/view/thehungtd/latest-artworks/2024"
API_URL = "https://db.ygoprodeck.com/api/v7/cardinfo.php?misc=yes"
START_DATE = date(2016, 8, 28)
END_DATE = date(2026, 8, 28)
USER_AGENT = "YugiohCCG non-commercial dataset research/1.0"

MONSTER_TYPES = (
    "Spellcaster", "Dragon", "Zombie", "Warrior", "Beast-Warrior", "Beast",
    "Winged Beast", "Fiend", "Fairy", "Insect", "Dinosaur", "Reptile", "Fish",
    "Sea Serpent", "Aqua", "Pyro", "Thunder", "Rock", "Plant", "Machine",
    "Psychic", "Divine-Beast", "Wyrm", "Cyberse", "Illusion",
)

CATEGORY_TARGETS = {"Monster": 300, "Spell": 120, "Trap": 80}
FALLBACK_MONSTER_QUOTAS = {
    "Dinosaur": 4,
    "Reptile": 3,
    "Beast-Warrior": 3,
    "Thunder": 2,
    "Psychic": 2,
    "Wyrm": 1,
    "Cyberse": 1,
}
FALLBACK_SPELL_QUOTAS = {
    "Ritual": 8,
    "Equip": 5,
    "Field": 5,
    "Continuous": 4,
    "Normal": 3,
    "Quick-Play": 2,
}
FALLBACK_TRAP_QUOTAS = {"Counter": 17, "Continuous": 3, "Normal": 3}

# Divine-Beast has no identity whose first TCG release is inside the cutoff.
# Use the clean, unsigned alternate export and document an official in-window
# TCG printing; artwork-debut provenance remains a manual gate.
DIVINE_EXCEPTION = {
    "passcode": 10000000,
    "artwork_id": 10000002,
    "card_name": "Obelisk the Tormentor",
    "qualified_tcg_print_release": "2016-09-02",
    "evidence_url": "https://www.db.yugioh-card.com/yugiohdb/card_search.action?cid=4998&ope=2&request_locale=en",
    "exception_reason": (
        "No Divine-Beast card identity first entered the TCG during the eligibility "
        "window. The official database records an in-window TCG printing on "
        "2016-09-02. The clean unsigned alternate export is included only to satisfy "
        "every-monster-type coverage; its artwork debut remains pending manual proof."
    ),
}

# These source artworks resolve to non-square composites in both the public page
# and cropped API endpoint. Replacements preserve the same category/Monster Type
# and keep stable dataset IDs so cached, already-audited rows cannot drift.
SOURCE_REPLACEMENTS = {
    86304179: 17080584,
    48654267: 67748760,
    2254222: 30012506,
    65155517: 65172015,
    6812770: 15464375,
    34323367: 28776350,
    70417076: 86120752,
    92530005: 97973962,
    7934362: 57294268,
}


def utc_now() -> str:
    return datetime.now(timezone.utc).replace(microsecond=0).isoformat()


def normalized_name(value: str) -> str:
    value = unicodedata.normalize("NFKC", value or "").casefold()
    value = value.replace("☆", "").replace("∀", "a")
    value = value.replace("–", "-").replace("—", "-").replace("’", "'")
    value = re.sub(r"\s+(?:alternate art|alt\.?|\d+(?:st|nd|rd|th))$", "", value)
    return re.sub(r"[^a-z0-9]+", "", value)


def category(card: dict) -> str:
    raw = str(card.get("type") or "")
    if "Monster" in raw:
        return "Monster"
    if "Spell" in raw:
        return "Spell"
    if "Trap" in raw:
        return "Trap"
    return "Other"


def first_tcg_date(card: dict) -> date | None:
    values = card.get("misc_info") or []
    raw = values[0].get("tcg_date") if values else None
    try:
        return date.fromisoformat(raw) if raw else None
    except ValueError:
        return None


def is_tcg(card: dict) -> bool:
    values = card.get("misc_info") or []
    return bool(values and "TCG" in (values[0].get("formats") or []))


def maximum_google_image(url: str) -> str:
    return re.sub(r"=w\d+(?:-h\d+)?$", "=s0", url)


def request(session: requests.Session, url: str, *, timeout: int = 120) -> requests.Response:
    response = session.get(url, timeout=timeout)
    response.raise_for_status()
    return response


def prepare_dirs() -> None:
    for path in (PACKAGE, CACHE, DISCOVERY, SELECTED, RAW_IMAGES, IMAGES, CAPTIONS):
        path.mkdir(parents=True, exist_ok=True)


def fetch_catalog(session: requests.Session, refresh: bool = False) -> list[dict]:
    path = CACHE / "ygoprodeck-cardinfo-misc.json"
    if refresh or not path.exists():
        payload = request(session, API_URL, timeout=240).json()
        path.write_text(json.dumps(payload, ensure_ascii=False), encoding="utf-8")
    return json.loads(path.read_text(encoding="utf-8"))["data"]


def discover_2024_pages(session: requests.Session) -> list[str]:
    soup = BeautifulSoup(request(session, SOURCE_ROOT).text, "html.parser")
    output: list[str] = []
    for anchor in soup.find_all("a", href=True):
        value = urljoin(SOURCE_ROOT, anchor["href"]).split("?", 1)[0].split("#", 1)[0].rstrip("/")
        if not value.startswith(SOURCE_ROOT + "/") or "/rush-duel" in value:
            continue
        if value not in output:
            output.append(value)
    return output


def discover_sources(session: requests.Session, refresh: bool = False) -> list[dict]:
    path = DISCOVERY / "thehungtd-2024-sources.json"
    if path.exists() and not refresh:
        return json.loads(path.read_text(encoding="utf-8"))
    rows: list[dict] = []
    for page in discover_2024_pages(session):
        soup = BeautifulSoup(request(session, page).text, "html.parser")
        for anchor in soup.select('a[href*="drive.google.com/file/d/"]'):
            name = " ".join(anchor.get_text(" ", strip=True).split())
            image = anchor.find_previous("img")
            if not name or image is None or not image.get("src"):
                continue
            drive_match = re.search(r"/file/d/([^/]+)", anchor.get("href", ""))
            rows.append({
                "source_name": name,
                "source_page": page,
                "source_preview_url": image["src"],
                "source_image_url": maximum_google_image(image["src"]),
                "drive_file_id": drive_match.group(1) if drive_match else "",
                "retrieved_at": utc_now(),
            })
        time.sleep(0.10)
    path.write_text(json.dumps(rows, ensure_ascii=False, indent=2) + "\n", encoding="utf-8")
    return rows


def aliases(card: dict) -> Iterable[str]:
    if card.get("name"):
        yield str(card["name"])
    for info in card.get("misc_info") or []:
        if info.get("beta_name"):
            yield str(info["beta_name"])


def unique_tcg_cards(cards: list[dict]) -> list[dict]:
    by_id: dict[int, dict] = {}
    for card in cards:
        if is_tcg(card):
            by_id[int(card["id"])] = card
    return list(by_id.values())


def match_source(source: dict, exact_index: dict[str, list[dict]]) -> tuple[dict | None, str, float]:
    key = normalized_name(source["source_name"])
    exact = exact_index.get(key, [])
    if len(exact) == 1:
        return exact[0], "exact_alias", 1.0
    if len(exact) > 1:
        eligible = [card for card in exact if first_tcg_date(card) and START_DATE <= first_tcg_date(card) <= END_DATE]
        if len(eligible) == 1:
            return eligible[0], "exact_alias_date_disambiguated", 1.0

    close = get_close_matches(key, exact_index.keys(), n=3, cutoff=0.78)
    scored: list[tuple[float, dict]] = []
    seen: set[int] = set()
    for alias_key in close:
        score = SequenceMatcher(None, key, alias_key).ratio()
        for card in exact_index[alias_key]:
            card_id = int(card["id"])
            if card_id not in seen:
                seen.add(card_id)
                scored.append((score, card))
    scored.sort(key=lambda item: item[0], reverse=True)
    best = scored[0] if scored else None
    second = scored[1][0] if len(scored) > 1 else 0.0
    if best and best[0] >= 0.92 and best[0] - second >= 0.025:
        return best[1], "fuzzy_pending_manual", round(best[0], 4)
    return None, "unmatched", round(best[0], 4) if best else 0.0


def build_candidate_manifest(session: requests.Session, refresh: bool = False) -> list[dict]:
    cards = unique_tcg_cards(fetch_catalog(session, refresh=refresh))
    sources = discover_sources(session, refresh=refresh)
    exact_index: dict[str, list[dict]] = defaultdict(list)
    for card in cards:
        for alias in aliases(card):
            exact_index[normalized_name(alias)].append(card)

    rows: list[dict] = []
    for source in sources:
        card, method, confidence = match_source(source, exact_index)
        row = dict(source)
        row.update({"match_method": method, "match_confidence": confidence})
        if card:
            tcg_date = first_tcg_date(card)
            misc = (card.get("misc_info") or [{}])[0]
            row.update({
                "passcode": int(card["id"]),
                "konami_cid": misc.get("konami_id"),
                "card_name": card.get("name"),
                "card_category": category(card),
                "monster_type": card.get("race") if category(card) == "Monster" else "",
                "spell_trap_subtype": card.get("race") if category(card) in {"Spell", "Trap"} else "",
                "archetype": card.get("archetype") or "",
                "initial_tcg_release": tcg_date.isoformat() if tcg_date else "",
                "strict_date_eligible": bool(tcg_date and START_DATE <= tcg_date <= END_DATE),
                "eligibility_basis": "new_card_first_release" if tcg_date and START_DATE <= tcg_date <= END_DATE else "ineligible_or_exception_pending",
                "official_metadata_status": "pending_konami_verification",
                "source_kind": "thehungtd_full_art",
            })
        rows.append(row)

    json_path = DISCOVERY / "candidate-manifest.json"
    csv_path = DISCOVERY / "candidate-manifest.csv"
    json_path.write_text(json.dumps(rows, ensure_ascii=False, indent=2) + "\n", encoding="utf-8")
    keys = sorted({key for row in rows for key in row})
    with csv_path.open("w", encoding="utf-8-sig", newline="") as handle:
        writer = csv.DictWriter(handle, fieldnames=keys)
        writer.writeheader()
        writer.writerows(rows)
    return rows


def write_manifest(rows: list[dict], stem: Path) -> None:
    stem.with_suffix(".json").write_text(
        json.dumps(rows, ensure_ascii=False, indent=2) + "\n", encoding="utf-8"
    )
    keys = sorted({key for row in rows for key in row})
    with stem.with_suffix(".csv").open("w", encoding="utf-8-sig", newline="") as handle:
        writer = csv.DictWriter(handle, fieldnames=keys)
        writer.writeheader()
        writer.writerows(rows)


def fallback_row(card: dict, artwork_id: int | None = None) -> dict:
    tcg_date = first_tcg_date(card)
    misc = (card.get("misc_info") or [{}])[0]
    images = card.get("card_images") or []
    chosen = next(
        (item for item in images if artwork_id and int(item.get("id", -1)) == artwork_id),
        images[0] if images else {},
    )
    art_id = int(chosen.get("id") or card["id"])
    return {
        "source_name": card.get("name"),
        "source_page": "https://db.ygoprodeck.com/api/v7/cardinfo.php?misc=yes",
        "source_preview_url": chosen.get("image_url_cropped") or "",
        "source_image_url": chosen.get("image_url_cropped") or "",
        "drive_file_id": "",
        "retrieved_at": utc_now(),
        "match_method": "api_identity_exact",
        "match_confidence": 1.0,
        "passcode": int(card["id"]),
        "artwork_id": art_id,
        "konami_cid": misc.get("konami_id"),
        "card_name": card.get("name"),
        "card_category": category(card),
        "monster_type": card.get("race") if category(card) == "Monster" else "",
        "spell_trap_subtype": card.get("race") if category(card) in {"Spell", "Trap"} else "",
        "archetype": card.get("archetype") or "",
        "initial_tcg_release": tcg_date.isoformat() if tcg_date else "",
        "strict_date_eligible": bool(tcg_date and START_DATE <= tcg_date <= END_DATE),
        "eligibility_basis": "new_card_first_release",
        "official_metadata_status": "pending_konami_verification",
        "source_kind": "ygoprodeck_cropped_art",
    }


def choose_fallbacks(
    cards: list[dict], primary: list[dict], quotas: dict[tuple[str, str], int]
) -> list[dict]:
    used = {int(row["passcode"]) for row in primary}
    archetypes = Counter(row.get("archetype") or "" for row in primary)
    eligible = [
        card for card in cards
        if is_tcg(card)
        and card.get("card_images")
        and int(card["id"]) not in used
        and first_tcg_date(card)
        and START_DATE <= first_tcg_date(card) <= END_DATE
    ]
    output: list[dict] = []
    for (wanted_category, wanted_class), count in quotas.items():
        pool = [
            card for card in eligible
            if int(card["id"]) not in used
            and category(card) == wanted_category
            and str(card.get("race") or "") == wanted_class
        ]
        pool.sort(key=lambda card: (
            archetypes[card.get("archetype") or ""],
            first_tcg_date(card),
            str(card.get("name") or ""),
            int(card["id"]),
        ))
        if len(pool) < count:
            raise RuntimeError(
                f"Need {count} {wanted_category}/{wanted_class} fallbacks; found {len(pool)}"
            )
        for card in pool[:count]:
            row = fallback_row(card)
            output.append(row)
            used.add(int(card["id"]))
            archetypes[card.get("archetype") or ""] += 1
    return output


def build_selection(cards: list[dict], discovered: list[dict]) -> list[dict]:
    primary = [
        dict(row) for row in discovered
        if row.get("strict_date_eligible")
        and row.get("match_method") in {"exact_alias", "exact_alias_date_disambiguated"}
    ]
    for row in primary:
        row["artwork_id"] = row.get("drive_file_id")

    quotas: dict[tuple[str, str], int] = {}
    quotas.update({("Monster", key): value for key, value in FALLBACK_MONSTER_QUOTAS.items()})
    quotas.update({("Spell", key): value for key, value in FALLBACK_SPELL_QUOTAS.items()})
    quotas.update({("Trap", key): value for key, value in FALLBACK_TRAP_QUOTAS.items()})
    selected = primary + choose_fallbacks(cards, primary, quotas)

    divine = next(card for card in cards if int(card["id"]) == DIVINE_EXCEPTION["passcode"])
    divine_row = fallback_row(divine, DIVINE_EXCEPTION["artwork_id"])
    divine_row.update({
        "strict_date_eligible": False,
        "eligibility_basis": "modern_artwork_exception",
        "qualified_tcg_print_release": DIVINE_EXCEPTION["qualified_tcg_print_release"],
        "exception_reason": DIVINE_EXCEPTION["exception_reason"],
        "exception_evidence_url": DIVINE_EXCEPTION["evidence_url"],
        "official_metadata_status": "official_identity_and_in_window_reprint_verified_artwork_debut_pending",
    })
    selected.append(divine_row)

    selected.sort(key=lambda row: (
        ("Monster", "Spell", "Trap").index(row["card_category"]),
        row.get("monster_type") or row.get("spell_trap_subtype") or "",
        row.get("initial_tcg_release") or "",
        row.get("card_name") or "",
        str(row.get("artwork_id") or ""),
    ))
    for number, row in enumerate(selected, 1):
        row["dataset_id"] = f"ygo4_{number:04d}"
        row["image_file"] = f"images/ygo4_{number:04d}.png"
        row["caption_file"] = f"captions/ygo4_{number:04d}.json"
        row["selection_status"] = "selected_pending_image_and_caption_qa"

    cards_by_id = {int(card["id"]): card for card in cards}
    for index, old_row in enumerate(selected):
        replacement_id = SOURCE_REPLACEMENTS.get(int(old_row["passcode"]))
        if not replacement_id:
            continue
        stable = {
            key: old_row[key]
            for key in ("dataset_id", "image_file", "caption_file", "selection_status")
        }
        new_row = fallback_row(cards_by_id[replacement_id])
        if (
            new_row["card_category"] != old_row["card_category"]
            or new_row["monster_type"] != old_row["monster_type"]
        ):
            raise RuntimeError(f"Replacement changes taxonomy: {old_row} -> {new_row}")
        new_row.update(stable)
        new_row["replacement_reason"] = (
            f"Replaced passcode {old_row['passcode']}: available artwork was non-square composite"
        )
        selected[index] = new_row

    counts = Counter(row["card_category"] for row in selected)
    if len(selected) != 500 or dict(counts) != CATEGORY_TARGETS:
        raise RuntimeError(f"Selection invariant failed: total={len(selected)}, categories={counts}")
    missing = set(MONSTER_TYPES) - {
        row["monster_type"] for row in selected if row["card_category"] == "Monster"
    }
    if missing:
        raise RuntimeError(f"Selection is missing monster types: {sorted(missing)}")
    write_manifest(selected, SELECTED / "selected-manifest")
    return selected


def sha256_bytes(value: bytes) -> str:
    return hashlib.sha256(value).hexdigest()


def difference_hash(image: Image.Image) -> str:
    tiny = image.convert("L").resize((9, 8), Image.Resampling.LANCZOS)
    pixels = list(tiny.getdata())
    bits = 0
    for y_value in range(8):
        for x_value in range(8):
            offset = y_value * 9 + x_value
            bits = (bits << 1) | int(pixels[offset] > pixels[offset + 1])
    return f"{bits:016x}"


def valid_image_payload(value: bytes) -> bool:
    try:
        with Image.open(BytesIO(value)) as opened:
            opened.verify()
        return True
    except Exception:
        return False


def download_bytes(session: requests.Session, row: dict) -> tuple[bytes, str, str]:
    urls: list[tuple[str, str]] = [(row["source_image_url"], row["source_kind"])]
    if row.get("drive_file_id"):
        urls.append((
            "https://drive.usercontent.google.com/download"
            f"?id={row['drive_file_id']}&export=download&authuser=0&confirm=t",
            "thehungtd_drive_original",
        ))
        urls.append((
            f"https://images.ygoprodeck.com/images/cards_cropped/{row['passcode']}.jpg",
            "ygoprodeck_identity_fallback",
        ))
    failures: list[str] = []
    seen: set[str] = set()
    for url, source_kind in urls:
        if url in seen:
            continue
        seen.add(url)
        attempts = 3 if "ygoprodeck.com" in url else 1
        for attempt in range(attempts):
            try:
                response = request(session, url, timeout=75)
                if len(response.content) < 10_000:
                    raise ValueError(f"response too small ({len(response.content)} bytes)")
                if not valid_image_payload(response.content):
                    raise ValueError(
                        f"not a decodable image ({response.headers.get('content-type', 'unknown')})"
                    )
                return response.content, response.url, source_kind
            except (requests.RequestException, ValueError) as exc:
                failures.append(f"{url} attempt {attempt + 1}: {exc}")
                time.sleep(0.5 * (attempt + 1))
    raise RuntimeError("; ".join(failures))


def process_image(original: dict, refresh: bool) -> dict:
    row = dict(original)
    raw_path = RAW_IMAGES / f"{row['dataset_id']}.bin"
    image_path = PACKAGE / row["image_file"]
    session = requests.Session()
    session.headers.update({"User-Agent": USER_AGENT})
    try:
        if refresh or not raw_path.exists() or not valid_image_payload(raw_path.read_bytes()):
            raw, resolved_url, resolved_source_kind = download_bytes(session, row)
            raw_path.write_bytes(raw)
        else:
            raw = raw_path.read_bytes()
            resolved_url = row.get("resolved_source_url") or row["source_image_url"]
            resolved_source_kind = row.get("resolved_source_kind") or row["source_kind"]

        with Image.open(BytesIO(raw)) as opened:
            source = ImageOps.exif_transpose(opened).convert("RGB")
        width, height = source.size
        needs_fallback = min(width, height) < 512 or abs(width - height) > 2
        if needs_fallback and row.get("drive_file_id") \
                and resolved_source_kind != "ygoprodeck_identity_fallback":
            fallback = dict(row)
            fallback["source_image_url"] = (
                "https://images.ygoprodeck.com/images/cards_cropped/"
                f"{row['passcode']}.jpg"
            )
            fallback["source_kind"] = "ygoprodeck_identity_fallback"
            fallback["drive_file_id"] = ""
            raw, resolved_url, resolved_source_kind = download_bytes(session, fallback)
            raw_path.write_bytes(raw)
            with Image.open(BytesIO(raw)) as opened:
                source = ImageOps.exif_transpose(opened).convert("RGB")
            width, height = source.size
        if min(width, height) < 512:
            raise ValueError(f"source is below 512 px: {width}x{height}")
        if abs(width - height) > 2:
            raise ValueError(f"source is not square: {width}x{height}")

        normalized = source.resize((1024, 1024), Image.Resampling.LANCZOS)
        normalized.save(image_path, format="PNG", compress_level=6)
        output_bytes = image_path.read_bytes()
        row.update({
            "resolved_source_url": resolved_url,
            "resolved_source_kind": resolved_source_kind,
            "source_width": width,
            "source_height": height,
            "source_sha256": sha256_bytes(raw),
            "output_width": 1024,
            "output_height": 1024,
            "output_mode": "RGB",
            "output_sha256": sha256_bytes(output_bytes),
            "difference_hash": difference_hash(normalized),
            "image_validation_status": "passed_automated_decode_dimension_checks",
        })
    except Exception as exc:
        row["image_validation_status"] = "failed"
        row["image_validation_error"] = str(exc)
    finally:
        session.close()
    return row


def download_images(session: requests.Session, rows: list[dict], refresh: bool = False) -> list[dict]:
    del session  # each bounded worker owns its connection pool
    results: list[dict] = []
    failures: list[dict] = []
    with ThreadPoolExecutor(max_workers=6) as executor:
        futures = {executor.submit(process_image, row, refresh): row["dataset_id"] for row in rows}
        for index, future in enumerate(as_completed(futures), 1):
            row = future.result()
            results.append(row)
            if row["image_validation_status"] == "failed":
                failures.append(row)
            if index % 25 == 0 or index == len(rows):
                print(f"Images processed: {index}/{len(rows)}; failures: {len(failures)}", flush=True)

    results.sort(key=lambda row: row["dataset_id"])
    completed = [row for row in results if row["image_validation_status"] != "failed"]

    write_manifest(results, SELECTED / "image-manifest")
    if failures:
        (SELECTED / "image-failures.json").write_text(
            json.dumps(failures, ensure_ascii=False, indent=2) + "\n", encoding="utf-8"
        )
        raise RuntimeError(f"{len(failures)} image downloads or validations failed")
    return completed


def report(rows: list[dict]) -> None:
    matched = [row for row in rows if row.get("passcode")]
    eligible = [row for row in matched if row.get("strict_date_eligible")]
    print(f"TheHungTD rows: {len(rows)}")
    print(f"Matched: {len(matched)}; strict-date eligible: {len(eligible)}")
    print("Categories:", dict(Counter(row["card_category"] for row in eligible)))
    monsters = Counter(row["monster_type"] for row in eligible if row["card_category"] == "Monster")
    print("Monster Types:")
    for value in MONSTER_TYPES:
        print(f"  {value}: {monsters[value]}")
    print("Match methods:", dict(Counter(row["match_method"] for row in rows)))


def report_selection(rows: list[dict]) -> None:
    print(f"Selected: {len(rows)}")
    print("Categories:", dict(Counter(row["card_category"] for row in rows)))
    print("Monster Types:")
    monsters = Counter(row["monster_type"] for row in rows if row["card_category"] == "Monster")
    for value in MONSTER_TYPES:
        print(f"  {value}: {monsters[value]}")
    print("Spell subtypes:", dict(Counter(
        row["spell_trap_subtype"] for row in rows if row["card_category"] == "Spell"
    )))
    print("Trap subtypes:", dict(Counter(
        row["spell_trap_subtype"] for row in rows if row["card_category"] == "Trap"
    )))
    print("Sources:", dict(Counter(row["source_kind"] for row in rows)))
    print("Strict-date identities:", sum(bool(row["strict_date_eligible"]) for row in rows))


def main() -> int:
    parser = argparse.ArgumentParser()
    parser.add_argument("command", choices=("catalogue", "select", "download", "report"))
    parser.add_argument("--refresh", action="store_true")
    args = parser.parse_args()
    prepare_dirs()
    session = requests.Session()
    session.headers.update({"User-Agent": USER_AGENT})
    if args.command == "catalogue":
        rows = build_candidate_manifest(session, refresh=args.refresh)
        report(rows)
    elif args.command == "download" and not args.refresh \
            and (SELECTED / "selected-manifest.json").exists():
        selected = json.loads((SELECTED / "selected-manifest.json").read_text(encoding="utf-8"))
        selected = download_images(session, selected, refresh=False)
        report_selection(selected)
    else:
        manifest_path = DISCOVERY / "candidate-manifest.json"
        rows = (
            json.loads(manifest_path.read_text(encoding="utf-8"))
            if manifest_path.exists() and not args.refresh
            else build_candidate_manifest(session, refresh=args.refresh)
        )
        cards = unique_tcg_cards(fetch_catalog(session, refresh=False))
        selected = build_selection(cards, rows)
        if args.command == "download":
            selected = download_images(session, selected, refresh=args.refresh)
        report_selection(selected)
    return 0


if __name__ == "__main__":
    raise SystemExit(main())

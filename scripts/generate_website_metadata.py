#!/usr/bin/env python3
"""Generate browser-facing release and implementation-status metadata."""

from __future__ import annotations

import hashlib
import json
import re
from collections import Counter
from datetime import datetime, timezone
from pathlib import Path


ROOT = Path(__file__).resolve().parents[1]
PUBLIC = ROOT / "public"
OUTPUT = PUBLIC / "data"
CARDS_PATH = ROOT / "src" / "data" / "cards.json"
ARCHETYPE_CATALOG_PATH = ROOT / "src" / "data" / "archetype-catalog.json"
LEDGER_PATH = ROOT / "scripts" / "output" / "ccg_effect_review_ledger.json"
YUGIOH_CARDS_PATH = PUBLIC / "data" / "yugioh-cards.json"
BANLIST_PATH = PUBLIC / "CCG Downloads" / "CCG_Banlist" / "CCG_Banlist.lflist.conf"


def sha256(path: Path) -> str:
    digest = hashlib.sha256()
    with path.open("rb") as handle:
        for block in iter(lambda: handle.read(1024 * 1024), b""):
            digest.update(block)
    return digest.hexdigest()


def artifact(path: Path, label: str, group: str) -> dict[str, object]:
    relative = path.relative_to(PUBLIC).as_posix()
    return {
        "label": label,
        "group": group,
        "path": relative,
        "bytes": path.stat().st_size,
        "sha256": sha256(path),
    }


def build_release_manifest() -> dict[str, object]:
    downloads = PUBLIC / "CCG Downloads"
    files: list[dict[str, object]] = []
    fixed = (
        (downloads / "CCG_Omega_Addon_Setup.exe", "One-click Installer", "installer"),
        (downloads / "CCG_Database" / "CCG_v1.db", "Card Database", "database"),
        (downloads / "CCG_Scripts" / "CCG_Scripts.zip", "Card Scripts", "scripts"),
        (downloads / "CCG_Banlist" / "CCG_Banlist.lflist.conf", "CCG Banlist", "banlist"),
    )
    for path, label, group in fixed:
        if path.is_file():
            files.append(artifact(path, label, group))

    patterns = (
        (downloads, "YGO_Omega_Images_v*.zip", "Card Arts", "arts"),
        (downloads / "YGO_Omega_Images", "YGO_Omega_Pics_v*.zip", "Full Card Images", "pics"),
        (downloads / "YGO_Omega_Images", "YGO_Omega_Holograms_v*.zip", "Holograms", "holograms"),
    )
    for directory, pattern, label, group in patterns:
        for index, path in enumerate(sorted(directory.glob(pattern)), start=1):
            files.append(artifact(path, f"{label} Part {index}", group))

    cards = json.loads(CARDS_PATH.read_text(encoding="utf-8"))
    latest_mtime = max((PUBLIC / str(item["path"])).stat().st_mtime for item in files)
    released = datetime.fromtimestamp(latest_mtime, timezone.utc)
    return {
        "schema_version": 1,
        "version": released.strftime("%Y.%m.%d"),
        "released_at": released.isoformat(),
        "card_count": len(cards),
        "monster_count": sum(card.get("category") == "Monster" for card in cards),
        "files": files,
    }


def build_support_status() -> dict[str, object]:
    ledger = json.loads(LEDGER_PATH.read_text(encoding="utf-8"))
    cards: list[dict[str, object]] = []
    verdicts: Counter[str] = Counter()
    for item in ledger.get("cards", []):
        review = item.get("review") or {}
        verdict = str(review.get("verdict") or "PENDING")
        verdicts[verdict] += 1
        issues = []
        for effect in review.get("effects", []):
            effect_verdict = str(effect.get("verdict") or "")
            if effect_verdict in {"UNSUPPORTED", "MANUAL_RULING", "CUSTOM_GAP"}:
                issues.append(
                    {
                        "verdict": effect_verdict,
                        "clause": effect.get("clause"),
                        "notes": effect.get("notes") or effect.get("lua"),
                    }
                )
        cards.append(
            {
                "passcode": item.get("passcode"),
                "name": item.get("name"),
                "verdict": verdict,
                "review_state": item.get("review_state"),
                "issue_count": len(issues),
                "issues": issues,
            }
        )
    return {
        "schema_version": 1,
        "generated_at": ledger.get("generated_at"),
        "summary": {
            "active_cards": len(cards),
            "verdicts": dict(sorted(verdicts.items())),
            "unresolved_cards": sum(card["issue_count"] > 0 for card in cards),
        },
        "cards": cards,
    }


def build_banlist_cards() -> list[dict[str, object]]:
    custom_cards = json.loads(CARDS_PATH.read_text(encoding="utf-8"))
    yugioh_cards = json.loads(YUGIOH_CARDS_PATH.read_text(encoding="utf-8"))
    by_passcode = {
        int(card["passcode"]): card
        for card in [*yugioh_cards, *custom_cards]
        if card.get("passcode")
    }
    status_fields = {
        "0": {"banned": True, "limited": False, "semiLimited": False},
        "1": {"banned": False, "limited": True, "semiLimited": False},
        "2": {"banned": False, "limited": False, "semiLimited": True},
    }
    cards: list[dict[str, object]] = []
    for line in BANLIST_PATH.read_text(encoding="utf-8").splitlines():
        match = re.match(r"^(\d+)\s+([012])(?:\s+--(.*))?$", line.strip())
        if not match:
            continue
        passcode = int(match.group(1))
        source = by_passcode.get(passcode)
        if source is None:
            raise RuntimeError(f"Banlist passcode {passcode} is missing from the website card catalogs")
        card = dict(source)
        card["legal"] = status_fields[match.group(2)]
        cards.append(card)
    if not cards:
        raise RuntimeError(f"No banlist entries found in {BANLIST_PATH.relative_to(ROOT)}")
    return cards


def write_json(name: str, payload: object) -> None:
    OUTPUT.mkdir(parents=True, exist_ok=True)
    path = OUTPUT / name
    path.write_text(json.dumps(payload, indent=2, ensure_ascii=False) + "\n", encoding="utf-8")
    print(f"wrote {path.relative_to(ROOT)}")


def write_sitemap() -> None:
    cards = json.loads(CARDS_PATH.read_text(encoding="utf-8"))
    static = ["", "releases", "cards", "archetypes", "banlist", "deck-builder", "support", "downloads", "draft"]
    memberships = [item["name"] for item in json.loads(ARCHETYPE_CATALOG_PATH.read_text(encoding="utf-8"))]
    from urllib.parse import quote
    urls = [f"https://yugiohccg.github.io/{path}" for path in static]
    urls.extend(f"https://yugiohccg.github.io/cards/{card['passcode']}" for card in cards if card.get("passcode"))
    urls.extend(f"https://yugiohccg.github.io/archetypes/{quote(name, safe='')}" for name in memberships)
    body = "\n".join(f"  <url><loc>{url}</loc></url>" for url in urls)
    path = PUBLIC / "sitemap.xml"
    path.write_text(f'<?xml version="1.0" encoding="UTF-8"?>\n<urlset xmlns="http://www.sitemaps.org/schemas/sitemap/0.9">\n{body}\n</urlset>\n', encoding="utf-8")
    print(f"wrote {path.relative_to(ROOT)} ({len(urls)} URLs)")


def main() -> int:
    write_json("release-manifest.json", build_release_manifest())
    write_json("support-status.json", build_support_status())
    write_json("banlist-cards.json", build_banlist_cards())
    write_sitemap()
    return 0


if __name__ == "__main__":
    raise SystemExit(main())

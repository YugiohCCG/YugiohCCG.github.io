#!/usr/bin/env python3
"""Verify an Ideogram 4 dataset manifest against Konami's official TCG database.

This is deliberately a separate, read-only verification stage. It never updates the
input manifest and never treats YGOPRODeck data as authoritative. Every downloaded
Konami detail page is cached with a SHA-256 digest so a decision can be audited.

Exit codes:
  0  every selected row passed
  1  one or more rows failed or remain pending
  2  command/input error
"""

from __future__ import annotations

import argparse
import csv
import hashlib
import html
import json
import re
import sys
import time
import unicodedata
import urllib.error
import urllib.request
from dataclasses import dataclass
from datetime import date, datetime, timezone
from pathlib import Path
from typing import Any, Iterable


OFFICIAL_DETAIL_URL = (
    "https://www.db.yugioh-card.com/yugiohdb/"
    "card_search.action?ope=2&cid={cid}&request_locale=en"
)
DEFAULT_START = date(2016, 8, 28)
DEFAULT_END = date(2026, 8, 28)
VALID_CATEGORIES = {"Monster", "Spell", "Trap"}
VALID_MONSTER_TYPES = {
    "Spellcaster", "Dragon", "Zombie", "Warrior", "Beast-Warrior", "Beast",
    "Winged Beast", "Fiend", "Fairy", "Insect", "Dinosaur", "Reptile", "Fish",
    "Sea Serpent", "Aqua", "Pyro", "Thunder", "Rock", "Plant", "Machine",
    "Psychic", "Divine-Beast", "Wyrm", "Cyberse", "Illusion",
}
VALID_SUBTYPES = {
    "Spell": {"Normal", "Continuous", "Equip", "Field", "Quick-Play", "Ritual"},
    "Trap": {"Normal", "Continuous", "Counter"},
}


class VerificationError(RuntimeError):
    """Raised for an input or authoritative-page parsing problem."""


@dataclass(frozen=True)
class OfficialCard:
    cid: int
    name: str | None
    category: str | None
    monster_type: str | None
    spell_trap_subtype: str | None
    set_dates: tuple[str, ...]
    initial_tcg_release: str | None
    detail_url: str
    evidence_file: str
    evidence_sha256: str
    fetched_at: str | None
    parse_warnings: tuple[str, ...]


def normalize_text(value: Any) -> str:
    text = html.unescape(str(value or ""))
    text = unicodedata.normalize("NFKC", text)
    return re.sub(r"\s+", " ", text).strip()


def strip_markup(fragment: str) -> str:
    fragment = re.sub(r"(?is)<script\b.*?</script>|<style\b.*?</style>", " ", fragment)
    return normalize_text(re.sub(r"(?s)<[^>]+>", " ", fragment))


def parse_iso_date(value: str, field: str) -> date:
    try:
        return date.fromisoformat(value)
    except (TypeError, ValueError) as exc:
        raise VerificationError(f"invalid {field} date {value!r}; expected YYYY-MM-DD") from exc


def extract_first(pattern: str, document: str) -> str | None:
    match = re.search(pattern, document, re.IGNORECASE | re.DOTALL)
    return strip_markup(match.group(1)) if match else None


def parse_official_page(
    document: str,
    *,
    cid: int,
    detail_url: str,
    evidence_file: Path,
    evidence_sha256: str,
    fetched_at: str | None,
) -> OfficialCard:
    warnings: list[str] = []

    name = extract_first(
        r'<div\s+id=["\']cardname["\'][^>]*>.*?<h1[^>]*>(.*?)</h1>', document
    )
    if not name:
        warnings.append("official card name not found")

    species_text = extract_first(r'<p\s+class=["\']species["\'][^>]*>(.*?)</p>', document)
    icon_text = extract_first(
        r'<span\s+class=["\']item_box_title["\'][^>]*>\s*Icon\s*</span>\s*'
        r'<span\s+class=["\']item_box_value["\'][^>]*>(.*?)</span>',
        document,
    )

    category: str | None = None
    monster_type: str | None = None
    subtype: str | None = None
    if species_text:
        category = "Monster"
        monster_type = re.split(r"[/／]", species_text, maxsplit=1)[0].strip()
        if monster_type not in VALID_MONSTER_TYPES:
            warnings.append(f"unrecognized official Monster Type: {monster_type!r}")
    elif icon_text:
        icon_match = re.fullmatch(r"(.+?)\s+(Spell|Trap)", icon_text)
        if icon_match:
            subtype = icon_match.group(1).strip()
            category = icon_match.group(2)
            if subtype not in VALID_SUBTYPES[category]:
                warnings.append(f"unrecognized official {category} subtype: {subtype!r}")
        else:
            warnings.append(f"unrecognized official Icon value: {icon_text!r}")
    else:
        warnings.append("official category/taxonomy not found")

    # Dates are limited to the official Sets block. This avoids accidentally treating
    # dates in navigation, related-card results, or scripts as release evidence.
    pack_marker = document.find("<!-- ///CardDetail_packlist")
    pack_end = document.find("<!-- ///CardDetail_relation", pack_marker + 1)
    if pack_marker >= 0:
        pack_html = document[pack_marker : pack_end if pack_end >= 0 else len(document)]
        set_dates = tuple(sorted(set(re.findall(r"\b(?:19|20)\d{2}-\d{2}-\d{2}\b", pack_html))))
    else:
        set_dates = ()
        warnings.append("official Sets block not found")
    initial_release = set_dates[0] if set_dates else None
    if not initial_release:
        warnings.append("no official TCG set date found; date eligibility is pending")

    return OfficialCard(
        cid=cid,
        name=name,
        category=category,
        monster_type=monster_type,
        spell_trap_subtype=subtype,
        set_dates=set_dates,
        initial_tcg_release=initial_release,
        detail_url=detail_url,
        evidence_file=str(evidence_file),
        evidence_sha256=evidence_sha256,
        fetched_at=fetched_at,
        parse_warnings=tuple(warnings),
    )


def fetch_official_page(
    cid: int,
    cache_dir: Path,
    *,
    refresh: bool,
    offline: bool,
    timeout: float,
) -> tuple[str, Path, str, str | None]:
    cache_dir.mkdir(parents=True, exist_ok=True)
    evidence_file = cache_dir / f"cid-{cid}.html"
    metadata_file = cache_dir / f"cid-{cid}.meta.json"
    url = OFFICIAL_DETAIL_URL.format(cid=cid)

    fetched_at: str | None = None
    if evidence_file.exists() and not refresh:
        raw = evidence_file.read_bytes()
        if metadata_file.exists():
            try:
                fetched_at = json.loads(metadata_file.read_text(encoding="utf-8")).get("fetched_at")
            except (OSError, json.JSONDecodeError):
                fetched_at = None
    else:
        if offline:
            raise VerificationError(f"official evidence is not cached for cid {cid}")
        request = urllib.request.Request(
            url,
            headers={
                "User-Agent": "YuGiOh-Ideogram4-Dataset-Audit/1.0 (metadata verification)",
                "Accept-Language": "en",
            },
        )
        last_error: BaseException | None = None
        for attempt in range(3):
            try:
                with urllib.request.urlopen(request, timeout=timeout) as response:
                    raw = response.read()
                break
            except (urllib.error.URLError, TimeoutError, OSError) as exc:
                last_error = exc
                if attempt < 2:
                    time.sleep(1.0 * (attempt + 1))
        else:
            raise VerificationError(
                f"failed to retrieve official page for cid {cid} after 3 attempts: {last_error}"
            ) from last_error
        fetched_at = datetime.now(timezone.utc).isoformat(timespec="seconds")
        evidence_file.write_bytes(raw)
        digest = hashlib.sha256(raw).hexdigest()
        metadata_file.write_text(
            json.dumps(
                {
                    "cid": cid,
                    "url": url,
                    "fetched_at": fetched_at,
                    "sha256": digest,
                    "bytes": len(raw),
                },
                indent=2,
            )
            + "\n",
            encoding="utf-8",
        )

    digest = hashlib.sha256(raw).hexdigest()
    if metadata_file.exists():
        try:
            recorded = json.loads(metadata_file.read_text(encoding="utf-8")).get("sha256")
        except (OSError, json.JSONDecodeError):
            recorded = None
        if recorded and recorded != digest:
            raise VerificationError(f"cached official evidence digest mismatch for cid {cid}")
    return raw.decode("utf-8", errors="replace"), evidence_file, digest, fetched_at


def check(field: str, expected: Any, actual: Any, *, pending_if_none: bool = True) -> dict[str, Any]:
    if actual is None and pending_if_none:
        status = "pending"
    else:
        status = "pass" if normalize_text(expected) == normalize_text(actual) else "fail"
    return {"field": field, "status": status, "expected": expected, "actual": actual}


def verify_record(
    record: dict[str, Any],
    official: OfficialCard,
    *,
    window_start: date,
    window_end: date,
) -> dict[str, Any]:
    checks: list[dict[str, Any]] = []
    checks.append(check("card_name", record.get("card_name"), official.name))
    checks.append(check("card_category", record.get("card_category"), official.category))

    expected_category = normalize_text(record.get("card_category"))
    if expected_category == "Monster":
        checks.append(check("monster_type", record.get("monster_type"), official.monster_type))
    elif expected_category in {"Spell", "Trap"}:
        checks.append(
            check(
                "spell_trap_subtype",
                record.get("spell_trap_subtype"),
                official.spell_trap_subtype,
            )
        )
    else:
        checks.append(
            {
                "field": "manifest_taxonomy",
                "status": "fail",
                "expected": sorted(VALID_CATEGORIES),
                "actual": record.get("card_category"),
            }
        )

    checks.append(
        check(
            "initial_tcg_release",
            record.get("initial_tcg_release"),
            official.initial_tcg_release,
        )
    )

    basis = normalize_text(record.get("eligibility_basis"))
    if basis != "new_card_first_release":
        eligibility = {
            "field": "strict_date_eligibility",
            "status": "pending",
            "expected": "explicitly reviewed artwork-level exception",
            "actual": basis or None,
            "reason": "non-strict eligibility bases are never auto-approved",
        }
    elif official.initial_tcg_release is None:
        eligibility = {
            "field": "strict_date_eligibility",
            "status": "pending",
            "expected": f"{window_start.isoformat()}..{window_end.isoformat()}",
            "actual": None,
            "reason": "official initial TCG release date is unavailable",
        }
    else:
        official_date = parse_iso_date(official.initial_tcg_release, "official release")
        in_window = window_start <= official_date <= window_end
        eligibility = {
            "field": "strict_date_eligibility",
            "status": "pass" if in_window else "fail",
            "expected": f"{window_start.isoformat()}..{window_end.isoformat()}",
            "actual": official.initial_tcg_release,
        }
        claimed_raw = record.get("strict_date_eligible")
        if isinstance(claimed_raw, bool):
            claimed = claimed_raw
        elif normalize_text(claimed_raw).lower() in {"true", "1", "yes"}:
            claimed = True
        elif normalize_text(claimed_raw).lower() in {"false", "0", "no"}:
            claimed = False
        else:
            claimed = None
        checks.append(
            {
                "field": "strict_date_eligible_claim",
                "status": "pending" if claimed is None else ("pass" if claimed == in_window else "fail"),
                "expected": claimed_raw,
                "actual": in_window,
                **({"reason": "manifest eligibility claim is missing or not boolean"} if claimed is None else {}),
            }
        )
    checks.append(eligibility)

    statuses = {entry["status"] for entry in checks}
    if "fail" in statuses:
        overall = "fail"
    elif "pending" in statuses or official.parse_warnings:
        overall = "pending"
    else:
        overall = "pass"

    return {
        "dataset_id": record.get("dataset_id"),
        "konami_cid": official.cid,
        "overall_status": overall,
        "exception_review_required": basis != "new_card_first_release",
        "checks": checks,
        "official": {
            "name": official.name,
            "category": official.category,
            "monster_type": official.monster_type,
            "spell_trap_subtype": official.spell_trap_subtype,
            "initial_tcg_release": official.initial_tcg_release,
            "set_dates": list(official.set_dates),
            "detail_url": official.detail_url,
        },
        "evidence": {
            "html_file": official.evidence_file,
            "sha256": official.evidence_sha256,
            "fetched_at": official.fetched_at,
        },
        "parse_warnings": list(official.parse_warnings),
    }


def load_manifest(path: Path) -> list[dict[str, Any]]:
    try:
        if path.suffix.lower() == ".json":
            payload = json.loads(path.read_text(encoding="utf-8-sig"))
            if not isinstance(payload, list) or not all(isinstance(row, dict) for row in payload):
                raise VerificationError("JSON manifest must be an array of objects")
            return payload
        if path.suffix.lower() == ".csv":
            with path.open("r", encoding="utf-8-sig", newline="") as handle:
                return list(csv.DictReader(handle))
    except (OSError, json.JSONDecodeError, csv.Error) as exc:
        raise VerificationError(f"could not read manifest {path}: {exc}") from exc
    raise VerificationError("manifest must be .json or .csv")


def select_records(records: list[dict[str, Any]], dataset_ids: Iterable[str]) -> list[dict[str, Any]]:
    requested = list(dataset_ids)
    if not requested:
        return records
    by_id = {str(row.get("dataset_id")): row for row in records}
    missing = [dataset_id for dataset_id in requested if dataset_id not in by_id]
    if missing:
        raise VerificationError(f"dataset_id not found: {', '.join(missing)}")
    return [by_id[dataset_id] for dataset_id in requested]


def write_reports(
    report_dir: Path,
    manifest: Path,
    results: list[dict[str, Any]],
    *,
    window_start: date,
    window_end: date,
) -> None:
    report_dir.mkdir(parents=True, exist_ok=True)
    counts = {status: sum(row["overall_status"] == status for row in results) for status in ("pass", "fail", "pending")}
    payload = {
        "schema_version": 1,
        "generated_at": datetime.now(timezone.utc).isoformat(timespec="seconds"),
        "authority": "Konami Yu-Gi-Oh! Neuron TCG Card Database",
        "input_manifest": str(manifest),
        "eligibility_window": {"start": window_start.isoformat(), "end": window_end.isoformat()},
        "summary": {
            "checked": len(results),
            **counts,
            "exception_review_required": sum(
                bool(row.get("exception_review_required")) for row in results
            ),
        },
        "results": results,
    }
    (report_dir / "konami-verification-report.json").write_text(
        json.dumps(payload, indent=2, ensure_ascii=False) + "\n", encoding="utf-8"
    )

    csv_fields = [
        "dataset_id", "konami_cid", "overall_status", "exception_review_required",
        "manifest_name", "official_name",
        "manifest_category", "official_category", "manifest_taxonomy", "official_taxonomy",
        "manifest_initial_tcg_release", "official_initial_tcg_release", "failed_fields",
        "pending_fields", "official_detail_url", "evidence_html", "evidence_sha256",
    ]
    with (report_dir / "konami-verification-report.csv").open(
        "w", encoding="utf-8-sig", newline=""
    ) as handle:
        writer = csv.DictWriter(handle, fieldnames=csv_fields)
        writer.writeheader()
        for result in results:
            checks = {item["field"]: item for item in result["checks"]}
            category = checks.get("card_category", {}).get("expected")
            taxonomy_field = "monster_type" if category == "Monster" else "spell_trap_subtype"
            writer.writerow(
                {
                    "dataset_id": result["dataset_id"],
                    "konami_cid": result["konami_cid"],
                    "overall_status": result["overall_status"],
                    "exception_review_required": result.get("exception_review_required", False),
                    "manifest_name": checks.get("card_name", {}).get("expected"),
                    "official_name": result["official"]["name"],
                    "manifest_category": category,
                    "official_category": result["official"]["category"],
                    "manifest_taxonomy": checks.get(taxonomy_field, {}).get("expected"),
                    "official_taxonomy": checks.get(taxonomy_field, {}).get("actual"),
                    "manifest_initial_tcg_release": checks.get("initial_tcg_release", {}).get("expected"),
                    "official_initial_tcg_release": result["official"]["initial_tcg_release"],
                    "failed_fields": ";".join(c["field"] for c in result["checks"] if c["status"] == "fail"),
                    "pending_fields": ";".join(c["field"] for c in result["checks"] if c["status"] == "pending"),
                    "official_detail_url": result["official"]["detail_url"],
                    "evidence_html": result["evidence"]["html_file"],
                    "evidence_sha256": result["evidence"]["sha256"],
                }
            )


def parse_args(argv: list[str]) -> argparse.Namespace:
    parser = argparse.ArgumentParser(description=__doc__)
    parser.add_argument("manifest", type=Path, help="selected manifest (.json or .csv)")
    parser.add_argument(
        "--report-dir", type=Path,
        default=Path("output/yugioh_ideogram4_500/verification/konami"),
    )
    parser.add_argument(
        "--cache-dir", type=Path,
        default=Path("output/yugioh_ideogram4_500/verification/konami/evidence"),
    )
    parser.add_argument("--dataset-id", action="append", default=[], help="verify only this ID; repeatable")
    parser.add_argument("--start", default=DEFAULT_START.isoformat())
    parser.add_argument("--end", default=DEFAULT_END.isoformat())
    parser.add_argument("--refresh", action="store_true", help="replace cached official pages")
    parser.add_argument("--offline", action="store_true", help="use cached evidence only")
    parser.add_argument("--delay", type=float, default=0.35, help="seconds between uncached requests")
    parser.add_argument("--timeout", type=float, default=30.0)
    return parser.parse_args(argv)


def main(argv: list[str] | None = None) -> int:
    args = parse_args(argv or sys.argv[1:])
    try:
        window_start = parse_iso_date(args.start, "start")
        window_end = parse_iso_date(args.end, "end")
        if window_start > window_end:
            raise VerificationError("start date must not be after end date")
        records = select_records(load_manifest(args.manifest), args.dataset_id)
        if not records:
            raise VerificationError("manifest selection is empty")

        results: list[dict[str, Any]] = []
        for index, record in enumerate(records):
            raw_cid = record.get("konami_cid")
            try:
                cid = int(raw_cid)
                if cid <= 0:
                    raise ValueError
            except (TypeError, ValueError):
                results.append(
                    {
                        "dataset_id": record.get("dataset_id"),
                        "konami_cid": raw_cid,
                        "overall_status": "pending",
                        "exception_review_required": normalize_text(record.get("eligibility_basis")) != "new_card_first_release",
                        "checks": [{"field": "konami_cid", "status": "pending", "expected": "positive integer", "actual": raw_cid}],
                        "official": {"detail_url": None},
                        "evidence": {},
                        "parse_warnings": ["official lookup cannot run without an unambiguous cid"],
                    }
                )
                continue

            evidence_existed = (args.cache_dir / f"cid-{cid}.html").exists() and not args.refresh
            try:
                document, evidence_file, digest, fetched_at = fetch_official_page(
                    cid, args.cache_dir, refresh=args.refresh, offline=args.offline, timeout=args.timeout
                )
                official = parse_official_page(
                    document,
                    cid=cid,
                    detail_url=OFFICIAL_DETAIL_URL.format(cid=cid),
                    evidence_file=evidence_file,
                    evidence_sha256=digest,
                    fetched_at=fetched_at,
                )
                results.append(
                    verify_record(record, official, window_start=window_start, window_end=window_end)
                )
            except VerificationError as exc:
                results.append(
                    {
                        "dataset_id": record.get("dataset_id"),
                        "konami_cid": cid,
                        "overall_status": "pending",
                        "exception_review_required": normalize_text(record.get("eligibility_basis")) != "new_card_first_release",
                        "checks": [{"field": "official_lookup", "status": "pending", "expected": "authoritative evidence", "actual": None}],
                        "official": {"detail_url": OFFICIAL_DETAIL_URL.format(cid=cid)},
                        "evidence": {},
                        "parse_warnings": [str(exc)],
                    }
                )
            if index + 1 < len(records) and not evidence_existed and not args.offline:
                time.sleep(max(0.0, args.delay))

        write_reports(
            args.report_dir,
            args.manifest,
            results,
            window_start=window_start,
            window_end=window_end,
        )
        passed = sum(row["overall_status"] == "pass" for row in results)
        failed = sum(row["overall_status"] == "fail" for row in results)
        pending = sum(row["overall_status"] == "pending" for row in results)
        print(f"Konami verification: checked={len(results)} pass={passed} fail={failed} pending={pending}")
        print(args.report_dir / "konami-verification-report.json")
        return 0 if failed == 0 and pending == 0 else 1
    except VerificationError as exc:
        print(f"error: {exc}", file=sys.stderr)
        return 2


if __name__ == "__main__":
    raise SystemExit(main())

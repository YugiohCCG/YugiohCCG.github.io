#!/usr/bin/env python3
"""Build a hash-pinned, card-by-card CCG effect review ledger.

The hand-maintained review file records semantic conclusions.  This builder
joins those conclusions to every active card, rejects duplicate/unknown IDs,
and automatically reopens a review whenever either printed text or Lua changes.
"""

from __future__ import annotations

import hashlib
import io
import json
import re
import subprocess
import tarfile
from datetime import datetime, timezone
from pathlib import Path


ROOT = Path(__file__).resolve().parents[1]
CARDS_PATH = ROOT / "src" / "data" / "cards.json"
SCRIPTS_DIR = ROOT / "public" / "CCG Downloads" / "CCG_Scripts"
REVIEWS_PATH = ROOT / "scripts" / "ccg_effect_reviews.json"
HISTORICAL_PATH = ROOT / "docs" / "lua-audit-2026-07-20-ultimate-fourth-pass.md"
OUTPUT_PATH = ROOT / "scripts" / "output" / "ccg_effect_review_ledger.json"
BASELINE_COMMIT = "52c2fd32d4519147c39cc9454d8273f568093494"
HISTORICAL_ROW = re.compile(r"^\|\s*(\d+)\s*\|\s*(\d+)\s*\|.*?\|\s*(Pass|Fixed|Needs manual ruling)\s*\|$")


def sha256_bytes(value: bytes) -> str:
    return hashlib.sha256(value).hexdigest()


def normalized_text_bytes(value: bytes) -> bytes:
    return value.replace(b"\r\n", b"\n")


def load_historical() -> dict[int, str]:
    results: dict[int, str] = {}
    for line in HISTORICAL_PATH.read_text(encoding="utf-8").splitlines():
        match = HISTORICAL_ROW.match(line)
        if match:
            results[int(match.group(2))] = match.group(3)
    return results


def git_archive(paths: list[str]) -> dict[str, bytes]:
    result = subprocess.run(
        ["git", "archive", "--format=tar", BASELINE_COMMIT, *paths],
        cwd=ROOT,
        capture_output=True,
        check=False,
    )
    if result.returncode:
        return {}
    files: dict[str, bytes] = {}
    with tarfile.open(fileobj=io.BytesIO(result.stdout), mode="r:") as archive:
        for member in archive.getmembers():
            if member.isfile() and (source := archive.extractfile(member)):
                files[member.name] = source.read()
    return files


def main() -> int:
    cards = json.loads(CARDS_PATH.read_text(encoding="utf-8"))
    review_payload = json.loads(REVIEWS_PATH.read_text(encoding="utf-8"))
    reviews = review_payload.get("reviews", [])
    review_by_id: dict[int, dict] = {}
    errors: list[str] = []
    active_ids = {int(card["passcode"]) for card in cards}

    for review in reviews:
        passcode = int(review["passcode"])
        if passcode in review_by_id:
            errors.append(f"duplicate review: {passcode}")
        elif passcode not in active_ids:
            errors.append(f"review is not an active card: {passcode}")
        review_by_id[passcode] = review

    historical = load_historical()
    baseline_paths = [
        "src/data/cards.json",
        *(f"public/CCG Downloads/CCG_Scripts/c{int(card['passcode'])}.lua" for card in cards),
    ]
    baseline_files = git_archive(baseline_paths)
    baseline_cards_raw = baseline_files.get("src/data/cards.json")
    baseline_cards = {
        int(card["passcode"]): card
        for card in json.loads(baseline_cards_raw.decode("utf-8"))
    } if baseline_cards_raw else {}
    entries: list[dict] = []
    current = inherited = stale = pending = 0
    verdicts: dict[str, int] = {}
    for ordinal, card in enumerate(cards, 1):
        passcode = int(card["passcode"])
        script_path = SCRIPTS_DIR / f"c{passcode}.lua"
        if not script_path.exists():
            errors.append(f"missing script: {passcode} ({card['name']})")
            script_hash = None
        else:
            script_hash = sha256_bytes(script_path.read_bytes())
        text_hash = sha256_bytes(card.get("text", "").encode("utf-8"))
        review = review_by_id.get(passcode)
        state = "pending"
        if review:
            if review.get("script_sha256") == script_hash and review.get("text_sha256") == text_hash:
                state = "current"
                current += 1
                verdict = review.get("verdict", "UNKNOWN")
                verdicts[verdict] = verdicts.get(verdict, 0) + 1
            else:
                state = "stale"
                stale += 1
        else:
            baseline_card = baseline_cards.get(passcode)
            baseline_script = baseline_files.get(f"public/CCG Downloads/CCG_Scripts/c{passcode}.lua")
            historical_verdict = historical.get(passcode)
            if (
                baseline_card
                and baseline_card.get("text", "") == card.get("text", "")
                and normalized_text_bytes(baseline_script) == normalized_text_bytes(script_path.read_bytes())
                and historical_verdict
            ):
                state = "current_inherited"
                current += 1
                inherited += 1
                verdict = {
                    "Pass": "PASS",
                    "Fixed": "FIXED",
                    "Needs manual ruling": "MANUAL_RULING",
                }[historical_verdict]
                verdicts[verdict] = verdicts.get(verdict, 0) + 1
                review = {
                    "verdict": verdict,
                    "provenance": {
                        "baseline_commit": BASELINE_COMMIT,
                        "primary_audit": "docs/ccg-semantic-effect-audit.md",
                        "per_card_result": "docs/lua-audit-2026-07-20-ultimate-fourth-pass.md",
                        "official_structure_report": "docs/ccg-effects-cross-reference-report.md",
                        "note": "Inherited only because printed text and Lua are byte-identical to the audited baseline.",
                    },
                    "effects": [
                        {
                            "clause": "All printed clauses and registered effects",
                            "verdict": verdict,
                            "notes": "See the cited per-effect audit and official Omega structure report; unresolved engine/ruling cases retain MANUAL_RULING status.",
                        }
                    ],
                }
            elif baseline_card or baseline_script:
                state = "stale"
                stale += 1
            else:
                pending += 1
        entries.append(
            {
                "ordinal": ordinal,
                "card_id": card["id"],
                "passcode": passcode,
                "name": card["name"],
                "text_sha256": text_hash,
                "script_sha256": script_hash,
                "review_state": state,
                "historical_verdict": historical.get(passcode),
                "review": review,
            }
        )

    payload = {
        "generated_at": datetime.now(timezone.utc).isoformat(),
        "source": str(REVIEWS_PATH.relative_to(ROOT)).replace("\\", "/"),
        "summary": {
            "active_cards": len(cards),
            "current_reviews": current,
            "inherited_current_reviews": inherited,
            "fresh_current_reviews": current - inherited,
            "stale_reviews": stale,
            "pending_reviews": pending,
            "current_verdicts": verdicts,
            "errors": len(errors),
        },
        "errors": errors,
        "cards": entries,
    }
    OUTPUT_PATH.parent.mkdir(parents=True, exist_ok=True)
    OUTPUT_PATH.write_text(json.dumps(payload, indent=2, ensure_ascii=False) + "\n", encoding="utf-8")
    print(json.dumps(payload["summary"], indent=2))
    return 1 if errors or stale else 0


if __name__ == "__main__":
    raise SystemExit(main())

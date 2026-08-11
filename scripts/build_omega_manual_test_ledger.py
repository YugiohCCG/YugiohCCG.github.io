#!/usr/bin/env python3
"""Build and validate the live Omega test ledger from the 123-card review guide."""

from __future__ import annotations

import argparse
import hashlib
import json
import re
from collections import Counter
from pathlib import Path
from typing import Any


ROOT = Path(__file__).resolve().parents[1]
GUIDE = ROOT / "docs" / "lua-manual-review-guide-2026-07-20.md"
CARDS = ROOT / "src" / "data" / "cards.json"
SCRIPTS = ROOT / "public" / "CCG Downloads" / "CCG_Scripts"
DECK_MANIFEST = ROOT / "scripts" / "output" / "omega_test_decks" / "CCG Test Decks.json"
LEDGER = ROOT / "scripts" / "output" / "omega_manual_test_ledger.json"
STATUS_REPORT = ROOT / "docs" / "ccg-live-test-status.md"
RESOLVED_GUIDE_EXCLUSIONS = {
    224467692: "Scarstech Prologue is a Normal Monster (Omega type 17); flavor text and an empty script are correct.",
    212684822: "Ektelestis requirements, reflected half damage, and Taxis add/send behavior are fully implemented.",
    215984744: "Recollection, Bear Trap/Mortis, and Mine matching resolve through current name/set pools.",
    223512283: "Dysmandr name-series placement resolves through its generated archetype setcode.",
    223558392: "EARTH printed-text searches use the generated official-plus-CCG search pool.",
    223592011: "WIND printed-text searches use the generated official-plus-CCG search pool.",
    224751741: "Fall of Azrynior carries the Taxis setcode in the database, matching official treated-as handling.",
    224774049: "Pot of Gambling declares, rolls, excavates, adds a matching card, and shuffles the remainder.",
    229327103: "FIRE printed-text searches use the generated official-plus-CCG search pool.",
    229786055: "Eldora's destruction provenance and matching-characteristic summon pools are implemented as written.",
    231331942: "Hallo, the Spirit of Tricks is resolved to official TCG ID 54611591.",
    235612490: "Feather Downpour banishes an Arckcestial from the GY as cost and performs the conditional second banish.",
    236721134: "Devotee's send and Set clauses are one semicolon-linked trigger effect.",
    239245471: "Birth of Azrynior carries the Ataxia setcode in the database, matching official treated-as handling.",
    241447408: "Kaboom Papa rejects activation after more than one prior Summon and caps the turn at one Summon.",
    242009896: "Extinction destroys every other matching Effect Monster, then the chosen monster, including when no others exist.",
    243920845: "DARK printed-text searches use the generated official-plus-CCG search pool.",
    244013196: "To Proto Chrono's recovered full text, summon, negate/stat/counter, and banished recovery effects are implemented.",
    244790302: "Stained Avatar dynamically applies a targeted Stain Spell/Trap activation effect.",
    244920555: "LIGHT printed-text searches use the generated official-plus-CCG search pool.",
    245099829: "Azrynior name-series placement resolves through its generated archetype setcode.",
    245400676: "To Proto Archegoni uses a generated name-or-printed-text Spell/Trap pool.",
    250556612: "NiuHao - Zao dynamically applies both banished Sacred Treasure activation effects in sequence.",
    251058567: "WATER printed-text searches use the generated official-plus-CCG search pool.",
    251236672: "Laplace Plesio has separate hard once-per-turn counters and own-Battle-Phase stat duration.",
    254065048: "Polemistis continuously gains the full ATK/DEF amount currently lost by field monsters.",
}

ENTRY_RE = re.compile(
    r"^###\s+(?P<number>\d+)\.\s+(?P<name>.+?)\s+-\s+(?P<id>\d+)\s*$"
    r"(?P<body>.*?)(?=^###\s+\d+\.|^##\s+|\Z)",
    re.MULTILINE | re.DOTALL,
)
WORKSTREAM_RE = re.compile(r"^##\s+(.+?)\s*$", re.MULTILINE)
SOURCE_ORDINAL_RE = re.compile(r"\*\*Source ordinal:\*\*\s*(\d+)")
PROBLEM_RE = re.compile(r"- \*\*Problem/question to solve:\*\*\s*(.+)")
IMPLEMENTATION_RE = re.compile(r"- \*\*Current audited implementation:\*\*\s*(.+)")
ACCEPTANCE_RE = re.compile(r"- \*\*Acceptance condition:\*\*\s*(.+)")
CHECKLIST_RE = re.compile(
    r"- \*\*Manual review checklist:\*\*\s*\n(?P<items>(?:\s+\d+\..+\n?)+)"
)


def sha256(path: Path) -> str:
    return hashlib.sha256(path.read_bytes()).hexdigest()


def workstream_at(source: str, position: int) -> str:
    headings = [(match.start(), match.group(1)) for match in WORKSTREAM_RE.finditer(source)]
    return next((name for start, name in reversed(headings) if start < position), "Unknown")


def parse_guide(source: str) -> list[dict[str, Any]]:
    entries: list[dict[str, Any]] = []
    for match in ENTRY_RE.finditer(source):
        body = match.group("body")
        checklist_match = CHECKLIST_RE.search(body)
        checklist = []
        if checklist_match:
            checklist = [
                re.sub(r"^\s*\d+\.\s*", "", line).strip()
                for line in checklist_match.group("items").splitlines()
                if re.match(r"^\s*\d+\.", line)
            ]
        entries.append(
            {
                "guide_number": int(match.group("number")),
                "card_id": int(match.group("id")),
                "card_name": match.group("name").strip(),
                "source_ordinal": int(SOURCE_ORDINAL_RE.search(body).group(1))
                if SOURCE_ORDINAL_RE.search(body)
                else None,
                "workstream": workstream_at(source, match.start()),
                "problem": PROBLEM_RE.search(body).group(1).strip()
                if PROBLEM_RE.search(body)
                else "",
                "audited_implementation": IMPLEMENTATION_RE.search(body).group(1).strip()
                if IMPLEMENTATION_RE.search(body)
                else "",
                "checklist": checklist,
                "acceptance_condition": ACCEPTANCE_RE.search(body).group(1).strip()
                if ACCEPTANCE_RE.search(body)
                else "",
            }
        )
    return entries


def deck_coverage(path: Path) -> dict[int, list[str]]:
    payload = json.loads(path.read_text(encoding="utf-8"))
    coverage: dict[int, list[str]] = {}
    for deck in payload.get("decks", []):
        deck_name = str(deck.get("archetype") or deck.get("file") or "")
        for section in ("main", "extra", "side"):
            for row in deck.get(section, []):
                coverage.setdefault(int(row["id"]), []).append(deck_name)
    return {card_id: list(dict.fromkeys(names)) for card_id, names in coverage.items()}


def existing_results(path: Path) -> dict[int, dict[str, Any]]:
    if not path.exists():
        return {}
    try:
        payload = json.loads(path.read_text(encoding="utf-8"))
    except json.JSONDecodeError:
        return {}
    return {int(entry["card_id"]): entry for entry in payload.get("tests", [])}


def render_status(ledger: dict[str, Any]) -> str:
    summary = ledger["summary"]
    lines = [
        "# CCG Live Omega Test Status",
        "",
        "This ledger tracks the ruling- and engine-sensitive cards that cannot be certified by syntax, callback, database, or static semantic checks alone.",
        "",
        f"- Historical guide entries resolved statically and excluded: {summary.get('resolved_exclusions', 0)}",
        f"- Total live-test cards: {summary['total']}",
        f"- Passed: {summary.get('passed', 0)}",
        f"- Failed: {summary.get('failed', 0)}",
        f"- Blocked on ruling: {summary.get('blocked', 0)}",
        f"- Pending: {summary.get('pending', 0)}",
        "",
        "A card reaches `passed` only with the adopted ruling, positive and negative boundary cases, interruption case where applicable, and replay/log evidence recorded in the JSON ledger.",
        "",
        "## Execution workflow",
        "",
        "1. Open the named deck from `scripts/output/omega_test_decks` in YGO Omega and create the board state described by the card's checklist in the manual review guide.",
        "2. Run the positive case, negative boundary case, and interruption case where applicable on the pinned Lua script.",
        "3. Save the replay or keep the duel open, then run `python scripts/record_omega_manual_test.py --card <ID> ... --evidence <REPLAY>` or use `--capture-omega-log`. The recorder copies and hashes the evidence and refuses incomplete passes.",
        "4. Use `python scripts/record_omega_manual_test.py --next` for the next pending card. After all cases pass, run `python scripts/build_omega_manual_test_ledger.py --require-complete`.",
        "",
        "Omega's local client API can read duel state/logs and drive a spawned bot, but it cannot create the initial duel or scripted board state. Those setup steps remain interactive.",
        "",
        "## Queue",
        "",
        "| # | Card | Workstream | Status | Test deck |",
        "|---:|---|---|---:|---|",
    ]
    for test in ledger["tests"]:
        decks = ", ".join(test["test_decks"])
        lines.append(
            f"| {test['guide_number']} | {test['card_name']} (`{test['card_id']}`) | "
            f"{test['workstream']} | {test['result']['status']} | {decks} |"
        )
    lines.append("")
    return "\n".join(lines)


def main() -> int:
    parser = argparse.ArgumentParser(description=__doc__)
    parser.add_argument("--check", action="store_true", help="Fail if generated files are stale.")
    parser.add_argument("--require-complete", action="store_true", help="Fail unless every live test has passed.")
    args = parser.parse_args()

    guide_source = GUIDE.read_text(encoding="utf-8")
    historical_entries = parse_guide(guide_source)
    entries = [entry for entry in historical_entries if entry["card_id"] not in RESOLVED_GUIDE_EXCLUSIONS]
    for number, entry in enumerate(entries, 1):
        entry["guide_number"] = number
    cards = json.loads(CARDS.read_text(encoding="utf-8-sig"))
    cards_by_id = {int(card["passcode"]): card for card in cards}
    decks = deck_coverage(DECK_MANIFEST)
    prior = existing_results(LEDGER)
    errors: list[str] = []
    tests: list[dict[str, Any]] = []
    valid_statuses = {"pending", "passed", "failed", "blocked"}

    if len(historical_entries) != 123:
        errors.append(f"historical manual guide contains {len(historical_entries)} card entries, expected 123")
    if len(entries) != 123 - len(RESOLVED_GUIDE_EXCLUSIONS):
        errors.append(f"active manual queue contains {len(entries)} card entries, expected {123 - len(RESOLVED_GUIDE_EXCLUSIONS)}")
    if [entry["guide_number"] for entry in entries] != list(range(1, len(entries) + 1)):
        errors.append("manual guide numbering is not contiguous")

    for entry in entries:
        card_id = entry["card_id"]
        card = cards_by_id.get(card_id)
        script = SCRIPTS / f"c{card_id}.lua"
        if card is None:
            errors.append(f"{card_id}: missing from cards.json")
        elif card["name"].casefold() != entry["card_name"].casefold():
            errors.append(f"{card_id}: guide name {entry['card_name']!r} differs from {card['name']!r}")
        if not script.exists():
            errors.append(f"{card_id}: script missing")
        if card_id not in decks:
            errors.append(f"{card_id}: no generated Omega test deck contains this card")

        old_result = (prior.get(card_id) or {}).get("result") or {}
        status = old_result.get("status", "pending")
        if status not in valid_statuses:
            errors.append(f"{card_id}: invalid live-test status {status!r}")
            status = "pending"
        result = {
            "status": status,
            "tester": old_result.get("tester", ""),
            "tested_at": old_result.get("tested_at", ""),
            "omega_build": old_result.get("omega_build", ""),
            "ruling_adopted": old_result.get("ruling_adopted", ""),
            "positive_case": old_result.get("positive_case", ""),
            "negative_boundary_case": old_result.get("negative_boundary_case", ""),
            "interruption_case": old_result.get("interruption_case", ""),
            "replay_or_log": old_result.get("replay_or_log", ""),
            "evidence_sha256": old_result.get("evidence_sha256", ""),
            "observed_result": old_result.get("observed_result", ""),
            "change_required": old_result.get("change_required", ""),
            "retest_result": old_result.get("retest_result", ""),
            "reviewer": old_result.get("reviewer", ""),
        }
        if status == "passed":
            required = ("tester", "tested_at", "omega_build", "ruling_adopted", "positive_case",
                        "negative_boundary_case", "replay_or_log", "evidence_sha256", "observed_result", "reviewer")
            missing = [field for field in required if not result[field]]
            if missing:
                errors.append(f"{card_id}: passed result is missing evidence fields: {', '.join(missing)}")
        tests.append(
            {
                **entry,
                "script": f"c{card_id}.lua",
                "script_sha256": sha256(script) if script.exists() else None,
                "test_decks": decks.get(card_id, []),
                "result": result,
            }
        )

    statuses = Counter(test["result"]["status"] for test in tests)
    ledger = {
        "schema_version": 1,
        "guide": GUIDE.relative_to(ROOT).as_posix(),
        "guide_sha256": sha256(GUIDE),
        "summary": {
            "historical_guide_total": len(historical_entries),
            "resolved_exclusions": len(RESOLVED_GUIDE_EXCLUSIONS),
            "total": len(tests),
            **dict(sorted(statuses.items())),
            "errors": len(errors),
        },
        "errors": errors,
        "resolved_guide_exclusions": [
            {"card_id": card_id, "reason": reason}
            for card_id, reason in sorted(RESOLVED_GUIDE_EXCLUSIONS.items())
        ],
        "tests": tests,
    }
    rendered_json = json.dumps(ledger, indent=2, ensure_ascii=False) + "\n"
    rendered_markdown = render_status(ledger)
    stale = (
        not LEDGER.exists()
        or LEDGER.read_text(encoding="utf-8") != rendered_json
        or not STATUS_REPORT.exists()
        or STATUS_REPORT.read_text(encoding="utf-8") != rendered_markdown
    )
    if args.check:
        if stale:
            errors.append("live-test ledger or status report is stale")
    else:
        LEDGER.parent.mkdir(parents=True, exist_ok=True)
        LEDGER.write_text(rendered_json, encoding="utf-8")
        STATUS_REPORT.write_text(rendered_markdown, encoding="utf-8")

    print(f"manual_tests={len(tests)}")
    for status in sorted(valid_statuses):
        print(f"{status}={statuses.get(status, 0)}")
    print(f"cards_with_test_decks={sum(bool(test['test_decks']) for test in tests)}")
    print(f"errors={len(errors)}")
    for error in errors[:50]:
        print(f"ERROR {error}")
    if args.require_complete and statuses.get("passed", 0) != len(tests):
        print(f"ERROR live Omega certification is incomplete: {statuses.get('passed', 0)}/{len(tests)} passed")
        return 1
    return 1 if errors else 0


if __name__ == "__main__":
    raise SystemExit(main())

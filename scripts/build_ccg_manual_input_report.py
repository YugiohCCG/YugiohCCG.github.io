#!/usr/bin/env python3
"""Build the report for audit cases intentionally skipped for manual input.

The effect-review ledger is the hash-pinned static conclusion for every active
card.  The Omega manual-test ledger contains the cases whose last mile needs a
card-design ruling or an interactive duel.  This builder reconciles those two
sources so skipped cases remain explicit and cannot silently disappear.
"""

from __future__ import annotations

import argparse
import json
from collections import Counter, defaultdict
from datetime import datetime, timezone
from pathlib import Path
from typing import Any


ROOT = Path(__file__).resolve().parents[1]
EFFECT_LEDGER = ROOT / "scripts" / "output" / "ccg_effect_review_ledger.json"
MANUAL_LEDGER = ROOT / "scripts" / "output" / "omega_manual_test_ledger.json"
OUTPUT_JSON = ROOT / "scripts" / "output" / "ccg_manual_input_skips.json"
OUTPUT_MARKDOWN = ROOT / "docs" / "ccg-manual-input-skipped-report.md"
UNRESOLVED_VERDICTS = {"MANUAL_RULING", "UNSUPPORTED"}


def load(path: Path) -> dict[str, Any]:
    return json.loads(path.read_text(encoding="utf-8"))


def effect_detail(review: dict[str, Any]) -> list[dict[str, str]]:
    details: list[dict[str, str]] = []
    for effect in review.get("effects", []):
        if effect.get("verdict") not in UNRESOLVED_VERDICTS:
            continue
        details.append(
            {
                "verdict": str(effect.get("verdict", "")),
                "clause": str(effect.get("clause", "")),
                "implementation": str(effect.get("lua", "")),
                "reason": str(effect.get("notes", "")),
            }
        )
    return details


def render_markdown(payload: dict[str, Any]) -> str:
    summary = payload["summary"]
    lines = [
        "# CCG Manual-Input Cases - Reported and Skipped",
        "",
        "This report implements the audit instruction to record any case requiring manual input and skip it instead of blocking the remaining card review.",
        "",
        "## Outcome",
        "",
        f"- Active CCG cards covered by the hash-pinned effect ledger: **{summary['active_cards']}**",
        f"- Current card reviews: **{summary['current_reviews']}**",
        f"- Objectively reviewed as pass/fixed: **{summary['objectively_resolved']}**",
        f"- Skipped with a remaining ruling or engine limitation: **{summary['unresolved_skips']}**",
        f"- Additional fixed-card regression scenarios retained: **{summary['regression_only']}**",
        f"- Total interactive/manual scenarios documented: **{summary['manual_scenarios']}**",
        f"- Reconciliation errors: **{summary['errors']}**",
        "",
        "`Skipped` means no speculative text or Lua change was made. The current implementation remains pinned by text and script hashes, and the exact unresolved question stays in the queue below.",
        "",
        "## Remaining design or engine decisions",
        "",
        "These cards cannot be promoted to a fully proven effect-logic pass without the listed ruling or interactive Omega evidence.",
        "",
        "| Ord. | Card | Static verdict | Workstream | Reason requiring manual input |",
        "|---:|---|---|---|---|",
    ]
    for item in payload["unresolved"]:
        reason = item["problem"].replace("|", "\\|")
        lines.append(
            f"| {item['source_ordinal']} | {item['card_name']} (`{item['card_id']}`) | "
            f"{item['static_verdict']} | {item['workstream']} | {reason} |"
        )

    lines.extend([
        "",
        "## Exact unsupported or ambiguous clauses",
        "",
    ])
    detailed = [
        item
        for item in payload["unresolved"]
        if any(
            detail["clause"] != "All printed clauses and registered effects"
            for detail in item["effect_details"]
        )
    ]
    if not detailed:
        lines.append("No effect-level details were recorded.")
    for item in detailed:
        lines.extend([f"### {item['card_name']} (`{item['card_id']}`)", ""])
        for detail in item["effect_details"]:
            lines.append(f"- **{detail['verdict']} — {detail['clause']}**")
            if detail["implementation"]:
                lines.append(f"  - Current implementation: {detail['implementation']}")
            if detail["reason"]:
                lines.append(f"  - Why skipped: {detail['reason']}")
        lines.append("")

    lines.extend([
        "## Full skipped/manual scenario queue",
        "",
        "The detailed setup, positive/negative checks, acceptance condition, script hash, and test deck for every row remain in `docs/lua-manual-review-guide-2026-07-20.md` and `scripts/output/omega_manual_test_ledger.json`.",
        "",
    ])
    grouped: dict[str, list[dict[str, Any]]] = defaultdict(list)
    for item in payload["scenarios"]:
        grouped[item["workstream"]].append(item)
    for workstream, items in grouped.items():
        lines.extend([
            f"### {workstream}",
            "",
            "| # | Card | Disposition | Static verdict | Manual question | Status |",
            "|---:|---|---|---|---|---:|",
        ])
        for item in items:
            problem = item["problem"].replace("|", "\\|")
            lines.append(
                f"| {item['guide_number']} | {item['card_name']} (`{item['card_id']}`) | "
                f"{item['disposition']} | {item['static_verdict']} | {problem} | {item['live_status']} |"
            )
        lines.append("")

    lines.extend([
        "## Completion boundary",
        "",
        "All 577 cards have a current hash-pinned static review. This report is the explicit boundary for cases intentionally skipped under the manual-input instruction; automated QA does not misrepresent these scenarios as replay-backed live passes.",
        "",
    ])
    return "\n".join(lines)


def main() -> int:
    parser = argparse.ArgumentParser(description=__doc__)
    parser.add_argument("--check", action="store_true", help="Fail when either generated report is stale.")
    args = parser.parse_args()

    effect = load(EFFECT_LEDGER)
    manual = load(MANUAL_LEDGER)
    cards = effect.get("cards", [])
    effect_summary = effect.get("summary", {})
    review_by_id = {int(card["passcode"]): card for card in cards}
    unresolved_cards = {
        card_id: card
        for card_id, card in review_by_id.items()
        if (card.get("review") or {}).get("verdict") in UNRESOLVED_VERDICTS
    }
    manual_by_id = {int(test["card_id"]): test for test in manual.get("tests", [])}
    errors: list[str] = []

    if effect_summary.get("active_cards") != len(cards):
        errors.append("effect ledger active-card count differs from its card entries")
    if effect_summary.get("stale_reviews") or effect_summary.get("pending_reviews"):
        errors.append("effect ledger contains stale or pending reviews")
    missing_manual = sorted(set(unresolved_cards) - set(manual_by_id))
    if missing_manual:
        errors.append(f"unresolved cards missing from manual queue: {missing_manual}")

    scenarios: list[dict[str, Any]] = []
    for test in manual.get("tests", []):
        card_id = int(test["card_id"])
        reviewed = review_by_id.get(card_id)
        if reviewed is None:
            errors.append(f"manual scenario is not an active reviewed card: {card_id}")
            continue
        review = reviewed.get("review") or {}
        static_verdict = str(review.get("verdict", "UNKNOWN"))
        unresolved = static_verdict in UNRESOLVED_VERDICTS
        scenarios.append(
            {
                "guide_number": int(test["guide_number"]),
                "source_ordinal": int(test["source_ordinal"]),
                "card_id": card_id,
                "card_name": str(test["card_name"]),
                "workstream": str(test["workstream"]),
                "problem": str(test["problem"]),
                "static_verdict": static_verdict,
                "disposition": "SKIPPED_MANUAL_INPUT" if unresolved else "REGRESSION_ONLY",
                "live_status": str((test.get("result") or {}).get("status", "pending")),
                "text_sha256": reviewed.get("text_sha256"),
                "script_sha256": reviewed.get("script_sha256"),
                "effect_details": effect_detail(review),
            }
        )

    unresolved = [item for item in scenarios if item["disposition"] == "SKIPPED_MANUAL_INPUT"]
    regression = [item for item in scenarios if item["disposition"] == "REGRESSION_ONLY"]
    verdict_counts = Counter((card.get("review") or {}).get("verdict", "UNKNOWN") for card in cards)
    payload = {
        "schema_version": 1,
        "generated_at": effect.get("generated_at") or datetime.now(timezone.utc).isoformat(),
        "sources": [
            EFFECT_LEDGER.relative_to(ROOT).as_posix(),
            MANUAL_LEDGER.relative_to(ROOT).as_posix(),
        ],
        "summary": {
            "active_cards": len(cards),
            "current_reviews": int(effect_summary.get("current_reviews", 0)),
            "objectively_resolved": verdict_counts["PASS"] + verdict_counts["FIXED"],
            "unresolved_skips": len(unresolved),
            "regression_only": len(regression),
            "manual_scenarios": len(scenarios),
            "static_verdicts": dict(sorted(verdict_counts.items())),
            "errors": len(errors),
        },
        "errors": errors,
        "unresolved": unresolved,
        "regression_only": regression,
        "scenarios": scenarios,
    }
    rendered_json = json.dumps(payload, indent=2, ensure_ascii=False) + "\n"
    rendered_markdown = render_markdown(payload)
    stale = (
        not OUTPUT_JSON.exists()
        or OUTPUT_JSON.read_text(encoding="utf-8") != rendered_json
        or not OUTPUT_MARKDOWN.exists()
        or OUTPUT_MARKDOWN.read_text(encoding="utf-8") != rendered_markdown
    )
    if args.check:
        if stale:
            errors.append("manual-input JSON or Markdown report is stale")
    else:
        OUTPUT_JSON.parent.mkdir(parents=True, exist_ok=True)
        OUTPUT_JSON.write_text(rendered_json, encoding="utf-8")
        OUTPUT_MARKDOWN.write_text(rendered_markdown, encoding="utf-8")

    print(f"active_cards={len(cards)}")
    print(f"objectively_resolved={verdict_counts['PASS'] + verdict_counts['FIXED']}")
    print(f"unresolved_skips={len(unresolved)}")
    print(f"regression_only={len(regression)}")
    print(f"manual_scenarios={len(scenarios)}")
    print(f"errors={len(errors)}")
    for error in errors:
        print(f"ERROR {error}")
    return 1 if errors else 0


if __name__ == "__main__":
    raise SystemExit(main())

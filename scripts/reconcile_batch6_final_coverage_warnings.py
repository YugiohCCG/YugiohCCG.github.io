#!/usr/bin/env python3
"""Create reviewed coverage overrides for batch-6 ordinals 413, 417, and 419."""

from __future__ import annotations

import hashlib
import json
from pathlib import Path


ROOT = Path(__file__).resolve().parents[1]
CARDS_PATH = ROOT / "src" / "data" / "cards.json"
SCRIPTS_DIR = ROOT / "public" / "CCG Downloads" / "CCG_Scripts"
AUDIT_DIR = ROOT / "scripts" / "output" / "effect_audit_agents"
SOURCE_PATH = AUDIT_DIR / "batch_6_361_432.json"

OVERRIDES = {
    413: {
        "expected_individual_effects": 4,
        "reason": (
            "The four records separately cover the hand Quick Effect (including its two "
            "alternative activation conditions), the shared Normal/Special Summon search, "
            "the Chain-Link-scaled damage effect, and the distinct once-per-turn limits. "
            "The heuristic double-counts the Special Summon performed by the first effect."
        ),
    },
    417: {
        "expected_individual_effects": 3,
        "reason": (
            "The three records separately cover the send-to-GY-cost destruction effect, "
            "the Chain-Link-3-or-higher self-revival effect, and both distinct once-per-turn "
            "limits. The heuristic double-counts the Special Summon performed by self-revival."
        ),
    },
    419: {
        "expected_individual_effects": 6,
        "reason": (
            "The six records separately cover the Special Summon-only restriction/procedure, "
            "Chain-scoped immunity, the shared Chain-Link-2 activation requirement, the "
            "once-per-Chain ATK effect with its optional Chain-Link-5 destruction follow-up, "
            "the turn-restricted recovery effect, and its once-per-turn limit plus the "
            "unique-control restriction. No printed procedure, follow-up, or limit is omitted."
        ),
    },
}


def sha256(data: bytes) -> str:
    return hashlib.sha256(data).hexdigest()


def main() -> None:
    cards = json.loads(CARDS_PATH.read_text(encoding="utf-8"))
    source = json.loads(SOURCE_PATH.read_text(encoding="utf-8"))
    source_by_ordinal = {int(card["ordinal"]): card for card in source["cards"]}

    for ordinal, coverage_override in OVERRIDES.items():
        card_data = cards[ordinal - 1]
        record = dict(source_by_ordinal[ordinal])
        script_path = SCRIPTS_DIR / f"c{int(card_data['passcode'])}.lua"
        record["text_sha256"] = sha256(str(card_data.get("text") or "").encode("utf-8"))
        record["script_sha256"] = sha256(script_path.read_bytes())
        record["coverage_override"] = coverage_override
        payload = {
            "schema_version": 1,
            "ordinal_start": ordinal,
            "ordinal_end": ordinal,
            "cards": [record],
        }
        output_path = AUDIT_DIR / f"batch_local_{ordinal}_{ordinal}.json"
        output_path.write_text(
            json.dumps(payload, indent=2, ensure_ascii=False) + "\n", encoding="utf-8"
        )


if __name__ == "__main__":
    main()

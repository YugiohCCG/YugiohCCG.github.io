#!/usr/bin/env python3
"""Refresh hash-pinned tail records after an adversarial 556-577 review."""

from __future__ import annotations

import hashlib
import json
from collections import Counter
from pathlib import Path


ROOT = Path(__file__).resolve().parents[1]
CARDS_PATH = ROOT / "src" / "data" / "cards.json"
SCRIPTS = ROOT / "public" / "CCG Downloads" / "CCG_Scripts"
BATCH_DIR = ROOT / "scripts" / "output" / "effect_audit_agents"
ORDINALS = (556, 573, 574, 575, 576, 577)


AUDIT_NOTES = {
    556: (
        "Adversarial review retained one ruling gap, not an engine gap. Omega's "
        "Auxiliary.NegateAnyFilter is explicitly a face-up-card filter and every "
        "official analogue cited for persistent single-card negation resolves only "
        "on a face-up, disableable card. The printed target phrase is broader and "
        "has no authoritative face-down ruling."
    ),
    573: (
        "Adversarial review confirmed that the mass removal, actual operated-group "
        "count, opponent-owned retained group, independent delayed return, and oath "
        "activation limit are all directly executable with official Omega patterns."
    ),
    574: (
        "Adversarial review confirmed the Fusion procedure, data-backed Observer "
        "membership, immunity, protection thresholds, and activation-effect copying. "
        "The hand-limit sentinel was aligned with Omega's Infinite Cards value 100."
    ),
    575: (
        "Adversarial review confirmed all four records, including draw-event quantity, "
        "generic face-down banished targets, different-name counting, and mandatory "
        "draw legality. No engine or ruling limitation remains."
    ),
    576: (
        "Adversarial review confirmed the Synchro procedure, conditional chain limit, "
        "Spell/Trap activation negation sequence, and GY/face-up-banishment Set pool. "
        "No engine or ruling limitation remains."
    ),
    577: (
        "Adversarial review confirmed the exact-two Fusion procedure, revival/disable "
        "with an independent Extra Deck restriction, and on-field activation-location "
        "negation. No engine or ruling limitation remains."
    ),
}


def digest(data: bytes) -> str:
    return hashlib.sha256(data).hexdigest()


def main() -> None:
    cards = json.loads(CARDS_PATH.read_text(encoding="utf-8"))
    for ordinal in ORDINALS:
        path = BATCH_DIR / f"batch_local_{ordinal}_{ordinal}.json"
        payload = json.loads(path.read_text(encoding="utf-8"))
        record = payload["cards"][0]
        card = cards[ordinal - 1]
        passcode = int(card["passcode"])

        record["text_sha256"] = digest(str(card.get("text") or "").encode("utf-8"))
        record["script_sha256"] = digest((SCRIPTS / f"c{passcode}.lua").read_bytes())
        record["audit_note"] = AUDIT_NOTES[ordinal]
        record["adversarial_completion_scope"] = {
            "ordinals": "556-577",
            "re_read": [
                "full printed text",
                "current canonical Lua",
                "Omega utility.lua and constant.lua",
                "official Omega database text",
                "official Omega card scripts",
            ],
            "historical_checklists_used": False,
        }

        if ordinal == 556:
            effect = next(item for item in record["effects"] if int(item["effect_index"]) == 3)
            effect["lua_implementation"] = (
                "The executable implementation uses Omega's Auxiliary.NegateAnyFilter, "
                "whose utility.lua contract is specifically 'negate the effects of a "
                "face-up card', and applies EFFECT_DISABLE/EFFECT_DISABLE_EFFECT only "
                "while the target remains face-up, related, and disableable. This is the "
                "officially supported subset, but it narrows the printed target phrase."
            )
            effect["issue"] = (
                "Ruling/text limitation: 'target 1 card your opponent controls' permits "
                "a face-down Monster or Set Spell/Trap by its written target criteria, "
                "but the text never states what 'negate its effects' must do while that "
                "card is face-down. Omega's official persistent-negation helpers and "
                "analogues only define face-up, disableable targets. Resolution needed: "
                "either errata the target to '1 face-up card your opponent controls' "
                "(the current safe behavior), or provide an authoritative ruling for "
                "face-down targets, after which distg/disop can be changed to that exact "
                "behavior. No unsupported face-down lingering negation was invented."
            )

        if ordinal == 574:
            effect = next(item for item in record["effects"] if int(item["effect_index"]) == 4)
            effect["lua_implementation"] = (
                "A player-targeting EFFECT_HAND_LIMIT applies to the opponent while "
                "their current hand count is at least six and now uses value 100, "
                "matching Omega's canonical Infinite Cards implementation."
            )
            effect["verdict"] = "FIXED"
            effect["issue"] = (
                "Confirmed and corrected: the prior practical sentinel was 99, while "
                "official Omega c94163677.lua implements 'no hand size limit' with "
                "EFFECT_HAND_LIMIT value 100."
            )

        verdicts = {item["verdict"] for item in record["effects"]}
        record["overall_verdict"] = (
            "CUSTOM_GAP" if "CUSTOM_GAP" in verdicts
            else "DEFECT" if "DEFECT" in verdicts
            else "FIXED" if "FIXED" in verdicts
            else "PASS"
        )
        counts = Counter(item["verdict"] for item in record["effects"])
        payload["batch"] = "local-adversarial-completion-tail-556-577"
        payload["summary"] = {
            "cards": 1,
            "effects": len(record["effects"]),
            "pass": counts["PASS"],
            "fixed": counts["FIXED"],
            "defects": counts["DEFECT"],
            "custom_gaps": counts["CUSTOM_GAP"],
        }
        path.write_text(json.dumps(payload, indent=2, ensure_ascii=False) + "\n", encoding="utf-8")
        print(path.relative_to(ROOT))


if __name__ == "__main__":
    main()

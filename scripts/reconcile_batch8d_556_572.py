#!/usr/bin/env python3
"""Generate hash-pinned local reconciliations for audit batch 8d."""

from __future__ import annotations

import hashlib
import json
from collections import Counter
from copy import deepcopy
from pathlib import Path


ROOT = Path(__file__).resolve().parents[1]
CARDS_PATH = ROOT / "src" / "data" / "cards.json"
SCRIPTS = ROOT / "public" / "CCG Downloads" / "CCG_Scripts"
BATCH_DIR = ROOT / "scripts" / "output" / "effect_audit_agents"
SOURCE_PATH = BATCH_DIR / "batch_8d_556_572.json"
ORDINALS = (556, 564, 565, 566, 567, 568, 571)


DECISIONS: dict[tuple[int, int], tuple[str, str, str | None]] = {
    (556, 3): (
        "CUSTOM_GAP",
        "The GY Quick Effect retains Omega's official face-up-card negation model: aux.NegateAnyFilter selects an opponent's face-up negatable on-field card, and resolution registers EFFECT_DISABLE/EFFECT_DISABLE_EFFECT only while that target remains face-up and legally disableable. No broader face-down behavior was invented.",
        "Printed-text/ruling gap preserved: the text says '1 card your opponent controls', but official Omega single-card negate scripts require a face-up/negatable target and expose no legal model for negating the inaccessible effects of an arbitrary face-down card. Resolve by ruling the target must be face-up and updating the printed text, or by supplying an authoritative face-down interaction; until then the safe executable behavior remains face-up only.",
    ),
    (564, 2): (
        "FIXED",
        "The delayed opponent-draw trigger now recognizes custom Eclipse Quick-Play Spells plus both official name matches, Book of Eclipse and Book of Lunar Eclipse, in the GY. Both official IDs are present in AddCodeList/listed_names, and the selected Necrovalley-legal target is returned to hand under the existing HOPT.",
        "Confirmed and corrected: Book of Lunar Eclipse (31834488) was omitted from the explicit official-name pool.",
    ),
    (565, 1): (
        "FIXED",
        "The Normal/Special Summon trigger's Deck filter now accepts Observer cards or an Eclipse Quick-Play Spell from custom set 0xf2f4, Book of Eclipse, or Book of Lunar Eclipse. Both official Eclipse Book IDs are included in AddCodeList/listed_names.",
        "Confirmed and corrected: the Deck send pool omitted Book of Lunar Eclipse (31834488).",
    ),
    (566, 2): (
        "FIXED",
        "The Normal/Special Summon trigger now Sets a custom Eclipse Quick-Play Spell, Book of Eclipse, or Book of Lunar Eclipse from the Deck/GY. The two official IDs are consistently published through AddCodeList/listed_names and accepted by setfilter.",
        "Confirmed and corrected: Book of Lunar Eclipse (31834488) was absent from the Set pool.",
    ),
    (567, 2): (
        "FIXED",
        "After discarding Maya, the Quick Effect now Sets a custom Eclipse Quick-Play Spell, Book of Eclipse, or Book of Lunar Eclipse from the hand and grants EFFECT_QP_ACT_IN_SET_TURN after a successful Set. AddCodeList/listed_names contains both official IDs.",
        "Confirmed and corrected: Book of Lunar Eclipse (31834488) was missing from Maya's hand Set pool.",
    ),
    (568, 2): (
        "FIXED",
        "The optional activation search now recognizes custom Eclipse Quick-Play Spells plus Book of Eclipse and Book of Lunar Eclipse. Both official IDs are included in AddCodeList/listed_names, and a successful two-card add still precedes the opponent's two-card draw.",
        "Confirmed and corrected: Book of Lunar Eclipse (31834488) was omitted from the activation search pool.",
    ),
    (568, 3): (
        "FIXED",
        "The delayed EVENT_SPSUMMON_SUCCESS trigger filters the event group with Card.IsSummonPlayer(1-tp), following official Shining Sarcophagus provenance handling. It can target a legal face-up monster the opponent actually Special Summoned regardless of its post-summon controller, then negates, banishes, and performs the dependent draw.",
        "Confirmed and corrected: the prior filter used post-summon control instead of the player who performed the Special Summon.",
    ),
    (571, 1): (
        "FIXED",
        "Resolution filters the Chain's target group by continued relation, GY location, removal legality, and Necrovalley only; it no longer rechecks IsCanBeEffectTarget. It banishes the legal related group, counts cards that actually reached banishment, inserts the printed 'then' break, and draws that count for the opponent.",
        "Confirmed and corrected: gaining targeting protection after activation no longer makes an already-targeted monster evade the resolving effect.",
    ),
    (571, 2): (
        "FIXED",
        "Every resolving activation now registers the one-shot End Phase operation independently of whether any immediate target was successfully banished. At the End Phase it returns all identifiable face-up banished Monster Cards belonging to the opponent that can legally go to the GY.",
        "Confirmed and corrected: the delayed global return was previously registered only after at least one immediate target reached banishment.",
    ),
}


NOTES = {
    556: "Preserved the safe official face-up negate implementation and documented the unresolved printed-target/ruling gap.",
    564: "Added Book of Lunar Eclipse consistently to Riley's metadata and GY recovery filter.",
    565: "Added Book of Lunar Eclipse consistently to Nora's metadata and Deck send filter.",
    566: "Added Book of Lunar Eclipse consistently to Ella's metadata and Deck/GY Set filter.",
    567: "Added Book of Lunar Eclipse consistently to Maya's metadata and hand Set filter.",
    568: "Added Book of Lunar Eclipse to Observatory and corrected opponent Special Summon provenance.",
    571: "Removed the resolution-time targetability recheck and made the End Phase return registration unconditional.",
}


def digest(data: bytes) -> str:
    return hashlib.sha256(data).hexdigest()


def main() -> None:
    cards = json.loads(CARDS_PATH.read_text(encoding="utf-8"))
    source = json.loads(SOURCE_PATH.read_text(encoding="utf-8"))
    by_ordinal = {int(record["ordinal"]): record for record in source["cards"]}
    for ordinal in ORDINALS:
        record = deepcopy(by_ordinal[ordinal])
        card = cards[ordinal - 1]
        passcode = int(card["passcode"])
        record["text_sha256"] = digest(str(card.get("text") or "").encode("utf-8"))
        record["script_sha256"] = digest((SCRIPTS / f"c{passcode}.lua").read_bytes())
        for effect in record["effects"]:
            decision = DECISIONS.get((ordinal, int(effect["effect_index"])))
            if decision:
                effect["verdict"], effect["lua_implementation"], effect["issue"] = decision
        verdicts = {effect["verdict"] for effect in record["effects"]}
        record["overall_verdict"] = (
            "CUSTOM_GAP" if "CUSTOM_GAP" in verdicts
            else "FIXED" if "FIXED" in verdicts
            else "DEFECT" if "DEFECT" in verdicts
            else "PASS"
        )
        record["audit_note"] = NOTES[ordinal]
        record["coverage_override"] = {
            "expected_individual_effects": len(record["effects"]),
            "reason": record["coverage_override"]["reason"],
        }
        counts = Counter(effect["verdict"] for effect in record["effects"])
        payload = {
            "schema_version": 1,
            "batch": "local-reconciliation-batch8d-556-572",
            "ordinal_start": ordinal,
            "ordinal_end": ordinal,
            "cards": [record],
            "summary": {
                "cards": 1,
                "effects": len(record["effects"]),
                "pass": counts["PASS"],
                "fixed": counts["FIXED"],
                "defects": counts["DEFECT"],
                "custom_gaps": counts["CUSTOM_GAP"],
            },
        }
        output = BATCH_DIR / f"batch_local_{ordinal}_{ordinal}.json"
        output.write_text(json.dumps(payload, indent=2, ensure_ascii=False) + "\n", encoding="utf-8")
        print(output.relative_to(ROOT))


if __name__ == "__main__":
    main()

#!/usr/bin/env python3
"""Write the independently reconciled ordinal 122-144 local audit records."""

from __future__ import annotations

import hashlib
import json
from collections import Counter
from pathlib import Path


ROOT = Path(__file__).resolve().parents[1]
BATCH = ROOT / "scripts" / "output" / "effect_audit_agents" / "batch_2_73_144.json"
OUT = ROOT / "scripts" / "output" / "effect_audit_agents"
CARDS = ROOT / "src" / "data" / "cards.json"
LUA = ROOT / "public" / "CCG Downloads" / "CCG_Scripts"

ORDINALS = (125, 126, 127, 132, 134, 135, 136, 137, 139, 141, 143, 144)

# Each entry replaces the originally reported non-PASS finding after a fresh
# comparison with current source text, current Lua, and official Omega data.
DECISIONS = {
    (125, 3): (
        "FIXED",
        "EVENT_MOVE now catches the material moving from overlay to either the GY or banishment; the condition verifies REASON_COST and that the activating handler is a Stellaer Xyz Monster.",
        "Confirmed and corrected: EVENT_TO_GRAVE missed a detached material redirected to banishment. Official Gagaga Ganbara Knight uses EVENT_MOVE for the same destination-independent wording.",
    ),
    (126, 3): (
        "CUSTOM_GAP",
        "After the selected Deck monster is destroyed, CheckActivateEffect(true,true,true) obtains an effect and directly invokes its target and operation outside the original Standby Phase event.",
        "Unresolved engine/design gap: Omega has no exact official mechanism for identifying and immediately applying an arbitrary monster's specific Standby Phase trigger; cards with multiple effects remain ambiguous.",
    ),
    (127, 3): (
        "PASS",
        "The alternative selects one Main Deck Nephthys monster that is releasable and legal Ritual Material; Main Deck monsters necessarily have a Level, and Ritual-material legality still applies to a monster Tributed for a Ritual Summon.",
        "Rejected: Xyz and Link Monsters cannot be in the Main Deck location named by the effect, and the word Tribute does not override effects that prohibit use as Ritual Material.",
    ),
    (132, 4): (
        "FIXED",
        "At the End Phase, the registered delayed effect now totals GetBaseAttack/GetBaseDefense for every monster the player controls, including face-down monsters, and subtracts that total from LP.",
        "Partly confirmed and corrected: the face-up filter was unprinted. The GetBaseAttack/GetBaseDefense claim was rejected because Omega uses base values for a field monster's current original ATK/DEF, as in Regenesis Lord.",
    ),
    (134, 4): (
        "FIXED",
        "The source text now uses the standard phrase 'ignoring its Summoning conditions', matching IsCanBeSpecialSummoned(...,true,false) and Duel.SpecialSummon(...,true,false).",
        "Confirmed as a literal source-text typo: 'ignoring its card effects' is not a defined summon instruction, while the canonical Lua already implemented the standard official 'ignoring its Summoning conditions' semantics.",
    ),
    (135, 5): (
        "CUSTOM_GAP",
        "The operation increments Card TurnCounter values on cards in accessible locations, which covers conventional card-maintained turn counters but cannot enumerate or advance arbitrary effect-local reset durations.",
        "Unresolved engine/design gap: Omega exposes card turn counters, not a universal collection of every effect's remaining turn duration. The printed phrase 'all effect's turn count' needs a narrower ruling or engine support.",
    ),
    (136, 2): (
        "PASS",
        "The continuous disable checks current ATK/DEF against twice GetBaseAttack/GetBaseDefense, Omega's field-state representation of current original ATK/DEF.",
        "Rejected: official Regenesis Lord uses GetBaseAttack/GetBaseDefense for a face-up field monster's original-stat comparison; GetTextAttack/GetTextDefense instead force database-printed values and ignore effects that change original stats.",
    ),
    (137, 2): (
        "FIXED",
        "EVENT_MOVE now catches the material moving from overlay to the GY or banishment; the condition verifies detachment as the activation cost of a Stellaer Xyz Monster before attaching this card.",
        "Confirmed and corrected: EVENT_TO_GRAVE did not implement the destination-independent detached wording. Official Gagaga Ganbara Knight and Capshell establish EVENT_MOVE or paired destination events for this condition.",
    ),
    (139, 3): (
        "CUSTOM_GAP",
        "The cost offers LP payments in 100-point increments plus LP minus 1, then applies the chosen payment as permanent ATK/DEF gain.",
        "Unresolved engine/UI gap: the printed 'any amount' includes every integer from 1 through LP minus 1, but Omega's AnnounceNumber interface requires an explicit finite option list and no official script exposes an unrestricted integer-entry LP prompt.",
    ),
    (141, 3): (
        "CUSTOM_GAP",
        "Continuous UPDATE_ATTACK and UPDATE_DEFENSE values sum each current face-up monster's deficit from GetBaseAttack/GetBaseDefense.",
        "Unresolved design/engine gap: the printed event-like phrase does not define duration or accumulation, and Omega exposes no official ATK/DEF-loss event from which to record historical losses. The current script models live deficits only.",
    ),
    (143, 2): (
        "FIXED",
        "EVENT_MOVE now catches detachment to the GY or banishment; the condition verifies REASON_COST and a Stellaer Xyz activating handler before Special Summoning from hand.",
        "Confirmed and corrected: EVENT_TO_GRAVE missed redirected detachment. Official Gagaga Ganbara Knight uses EVENT_MOVE for the same printed trigger.",
    ),
    (144, 2): (
        "FIXED",
        "EVENT_MOVE now catches detachment to the GY or banishment; the condition verifies REASON_COST and a Stellaer Xyz activating handler before searching.",
        "Confirmed and corrected: EVENT_TO_GRAVE missed redirected detachment. Official Gagaga Ganbara Knight uses EVENT_MOVE for the same printed trigger.",
    ),
}

COVERAGE = {
    137: "The summon procedure and its resulting Attribute lock are one procedure record; the detached trigger and its leave-field redirect are separately recorded, and the HOPT is included with that activated effect.",
    143: "The summon procedure and its resulting Attribute lock are one procedure record; the detached summon, leave-field redirect, and its HOPT are represented by the remaining records.",
    144: "The summon procedure and its resulting restriction are one procedure record; the detached search and its HOPT are represented by the remaining records.",
}

REFERENCE_OVERRIDES = {
    (127, 3): [
        {
            "script": "c7986397.lua",
            "card_id": 7986397,
            "card_name": "Revendread Evolution",
            "matched_structure": "Official Ritual handling permits a specifically filtered Main Deck monster to be included in the Ritual material group, while ordinary hand/field materials are filtered for Ritual-material legality.",
        },
        {
            "script": "c51124303.lua",
            "card_id": 51124303,
            "card_name": "Nekroz Kaleidoscope",
            "matched_structure": "Official Ritual Spell selection, material assignment, release, Ritual Summon, and CompleteProcedure structure.",
        },
    ],
    (132, 4): [
        {
            "script": "c15443125.lua",
            "card_id": 15443125,
            "card_name": "Spright Starter",
            "matched_structure": "Official LP-loss resolution uses GetBaseAttack for a monster's original ATK and Duel.SetLP to apply the loss.",
        },
        {
            "script": "c94380860.lua",
            "card_id": 94380860,
            "card_name": "Number 103: Ragnazero",
            "matched_structure": "Official current-versus-original stat handling compares a face-up field monster's current ATK with GetBaseAttack.",
        },
        {
            "script": "c12527118.lua",
            "card_id": 12527118,
            "card_name": "Cassimolar",
            "matched_structure": "Official delayed End Phase handling records a later operation involving a monster's original ATK.",
        },
    ],
}


def digest(data: bytes) -> str:
    return hashlib.sha256(data).hexdigest()


def main() -> None:
    source = json.loads(BATCH.read_text(encoding="utf-8"))
    cards = json.loads(CARDS.read_text(encoding="utf-8"))
    records = {int(card["ordinal"]): card for card in source["cards"]}
    for ordinal in ORDINALS:
        record = json.loads(json.dumps(records[ordinal]))
        card = cards[ordinal - 1]
        passcode = int(card["passcode"])
        record["name"] = card["name"]
        record["passcode"] = passcode
        record["text_sha256"] = digest(str(card.get("text") or "").encode("utf-8"))
        record["script_sha256"] = digest((LUA / f"c{passcode}.lua").read_bytes())
        for effect in record["effects"]:
            key = (ordinal, int(effect["effect_index"]))
            if key in DECISIONS:
                verdict, implementation, issue = DECISIONS[key]
                effect["verdict"] = verdict
                effect["lua_implementation"] = implementation
                effect["issue"] = issue
                if ordinal == 134:
                    effect["printed_clause"] = "If your opponent activates a card effect: banish 1 Effect Monster you control; Special Summon 1 To Proto monster from hand or GY, ignoring its Summoning conditions."
            if key in REFERENCE_OVERRIDES:
                effect["official_references"] = REFERENCE_OVERRIDES[key]
        verdicts = {effect["verdict"] for effect in record["effects"]}
        record["overall_verdict"] = (
            "CUSTOM_GAP" if "CUSTOM_GAP" in verdicts
            else "FIXED" if "FIXED" in verdicts
            else "DEFECT" if "DEFECT" in verdicts
            else "PASS"
        )
        if ordinal in COVERAGE:
            record["coverage_override"] = {
                "expected_individual_effects": len(record["effects"]),
                "reason": COVERAGE[ordinal],
            }
        counts = Counter(effect["verdict"].lower() for effect in record["effects"])
        payload = {
            "schema_version": 1,
            "batch": "local-reconciliation-122-144",
            "ordinal_start": ordinal,
            "ordinal_end": ordinal,
            "cards": [record],
            "summary": {
                "cards": 1,
                "effects": len(record["effects"]),
                "pass": counts["pass"],
                "fixed": counts["fixed"],
                "defects": counts["defect"],
                "custom_gaps": counts["custom_gap"],
            },
        }
        path = OUT / f"batch_local_{ordinal}_{ordinal}.json"
        path.write_text(json.dumps(payload, indent=2, ensure_ascii=False) + "\n", encoding="utf-8")


if __name__ == "__main__":
    main()

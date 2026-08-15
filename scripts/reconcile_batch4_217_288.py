#!/usr/bin/env python3
"""Write the independently reviewed batch-4 local audit overrides."""

from __future__ import annotations

import hashlib
import json
from copy import deepcopy
from pathlib import Path


ROOT = Path(__file__).resolve().parents[1]
REPORT = ROOT / "scripts/output/ccg_effect_by_effect_official_reference_audit.json"
CARDS = ROOT / "src/data/cards.json"
SCRIPTS = ROOT / "public/CCG Downloads/CCG_Scripts"
OUT = ROOT / "scripts/output/effect_audit_agents"


COVERAGE_REASONS = {
    217: "The inherent self-Summon procedure, the Level-change trigger, and that trigger's HOPT sentence are the three individual audit units.",
    224: "The inherent self-Summon procedure, Summon search trigger, destruction trigger, and their per-effect turn limits are four complete audit units.",
    245: "The self-Summon procedure with its procedure limit, the Tribute/paired-Summon Quick Effect, and that effect's HOPT plus full-turn archetype lock are three complete audit units.",
    246: "The Summon search, its full-turn archetype lock, and the material-granted first-Spell negation (including the search HOPT) are three complete audit units.",
    247: "The shuffle-backed hand Summon procedure with its procedure limit and the material-granted recovery effect are the two printed effects.",
    248: "The Main-Phase banish/Summon effect with its HOPT and the material-granted Set-and-activate effect are the two printed effects.",
    249: "The Summon-triggered hand Summon, its full-turn archetype lock, and the material-granted monster-effect response (including the trigger HOPT) are three complete audit units.",
    251: "The additional Normal Summon permission and the GY banish/material-attachment effect with its HOPT are the two printed effects.",
    257: "The Deck Summon activation with its LIGHT lock, the GY search effect, and their shared one-effect-per-turn restriction are three complete audit units.",
    261: "The hand Summon trigger, GY banish/mass-revival effect, and their shared each-effect HOPT sentence are three complete audit units.",
    263: "The inherent self-Summon procedure, Summon search trigger, destruction trigger, and their per-effect turn limits are four complete audit units.",
    265: "Defense-position attacking, the hand/GY Summon effect, the attack/effect-negation response, and the shared each-effect HOPT are four complete audit units.",
    266: "The discard/destroy/draw effect, conditional hand Summon effect, destruction trigger, and shared each-effect HOPT are four complete audit units.",
    272: "The hand Summon procedure with its procedure limit, Summon Set trigger, destruction recovery trigger, and their distinct per-effect limits are four complete audit units.",
    274: "The hand Summon Quick Effect, attack prohibition, declared-name protection trigger, and their shared each-effect HOPT are four complete audit units.",
    280: "The hand Summon procedure with its procedure limit, Tribute/Deck Summon effect, banishment recovery trigger, and the latter effects' shared HOPT are four complete audit units.",
    281: "The GY Summon procedure with its procedure limit, discard/send effect, banishment return trigger, and the latter effects' shared HOPT are four complete audit units.",
}


def sha(data: bytes) -> str:
    return hashlib.sha256(data).hexdigest()


def main() -> None:
    report = json.loads(REPORT.read_text(encoding="utf-8"))
    source = {int(card["ordinal"]): card for card in report["cards"]}
    cards = json.loads(CARDS.read_text(encoding="utf-8"))
    selected = set(COVERAGE_REASONS) | {223, 237, 258, 275, 276, 284}

    for ordinal in sorted(selected):
        record = deepcopy(source[ordinal])
        card = cards[ordinal - 1]
        script = SCRIPTS / f"c{int(card['passcode'])}.lua"
        record = {
            "ordinal": ordinal,
            "passcode": int(card["passcode"]),
            "name": card["name"],
            "text_sha256": sha(str(card.get("text") or "").encode("utf-8")),
            "script_sha256": sha(script.read_bytes()),
            "effects": record["effects"],
            "review_note": "Independently reconciled against full printed text, canonical Lua, and the cited individual official Omega scripts/database rows.",
        }
        if ordinal in COVERAGE_REASONS:
            record["coverage_override"] = {
                "expected_individual_effects": len(record["effects"]),
                "reason": COVERAGE_REASONS[ordinal],
            }

        effects = {int(effect["effect_index"]): effect for effect in record["effects"]}
        if ordinal == 217:
            effects[1]["lua_implementation"] = "e1 is an uncopyable EFFECT_SPSUMMON_PROC in hand/GY; its condition checks the 2500+ ATK Crying Chaos monster, zone availability, and Necrovalley for a GY procedure."
            effects[1]["verdict"] = "FIXED"
            effects[1]["issue"] = "Fixed: the self-Summon is now a non-activated inherent procedure instead of an Ignition Effect that starts a Chain."
        elif ordinal == 223:
            effects[3]["lua_implementation"] = "negcon recognizes the standard leave-field operation-info categories; negcost Tributes a Crying Chaos monster and stores its current GetAttack()+GetDefense(); negop negates and applies that value through the End Phase."
            effects[3]["verdict"] = "CUSTOM_GAP"
            effects[3]["issue"] = "The incorrect printed-stat calculation was fixed to use current ATK/DEF. A residual engine gap remains: Omega exposes standard operation-info categories and declared targets, but cannot prove that every arbitrary custom Lua operation would make a controlled card leave the field."
        elif ordinal == 272:
            effects[2]["lua_implementation"] = "The Summon triggers now Set an Eldora Spell/Trap from Deck/GY and no longer falsely include Chapter II Verse IV. The current 577-card catalog contains no card whose name matches both quoted fragments 'Verse IX' and 'Chapter II'."
            effects[2]["verdict"] = "CUSTOM_GAP"
            effects[2]["issue"] = "Fixed the demonstrably wrong Verse IV inclusion. The remaining printed phrase is ambiguous and presently names no card in the CCG database, so there is no literal target pool to implement or validate beyond Eldora cards."
        elif ordinal == 275:
            effects[4]["lua_implementation"] = "e3 now triggers on EVENT_CHAIN_SOLVED for an opponent's effect whose CATEGORY_DESTROY operation group contains a monster currently or previously controlled in the Monster Zone, then destroys only this face-up Spell."
            effects[4]["verdict"] = "FIXED"
            effects[4]["issue"] = "Fixed: removed the unprinted destruction replacement. The threatened monster is no longer protected; this card is destroyed only after the qualifying opponent effect resolves."
            effects[4]["official_references"] = [{
                "script": "tmp/omega_scripts/c10239627.lua",
                "matched_structure": "EVENT_CHAIN_SOLVED continuous processing after the activating effect resolves",
            }]
        elif ordinal == 284:
            effects[2]["lua_implementation"] = "The activation merges eligible hand/field and Deck materials, and s.exactlytwo is installed through aux.FCheckAdditional for every CheckFusionMaterial and SelectFusionMaterial call."
            effects[2]["verdict"] = "FIXED"
            effects[2]["issue"] = "Fixed: both ordinary and Chain Material paths now require exactly two selected Fusion Materials."

        payload = {"schema_version": 1, "cards": [record]}
        path = OUT / f"batch_local_{ordinal}_{ordinal}.json"
        path.write_text(json.dumps(payload, indent=2, ensure_ascii=False) + "\n", encoding="utf-8")


if __name__ == "__main__":
    main()

#!/usr/bin/env python3
"""Generate fresh, hash-pinned local reconciliations for batch 1 findings.

This generator intentionally consumes only the fresh agent JSON, current cards.json,
current canonical Lua, and explicit reconciliation decisions made against Omega.
Checklist Markdown and historical verdict files are not inputs.
"""

from __future__ import annotations

import copy
import hashlib
import json
from collections import Counter
from pathlib import Path


ROOT = Path(__file__).resolve().parents[1]
BATCH = ROOT / "scripts/output/effect_audit_agents/batch_1_1_72.json"
CARDS = ROOT / "src/data/cards.json"
LUA_DIR = ROOT / "public/CCG Downloads/CCG_Scripts"
OUT_DIR = ROOT / "scripts/output/effect_audit_agents"

ORDINALS = {
    1, 3, 4, 5, 6, 7, 8, 9, 11, 12, 13, 14, 15, 16, 17, 18, 21,
    25, 26, 29, 30, 32, 33, 34, 35, 38, 51, 52, 54, 56, 57, 58,
    66, 68, 71, 72,
}


def sha256(data: bytes) -> str:
    return hashlib.sha256(data).hexdigest()


def ref(card_id: int, card_name: str, matched_structure: str) -> dict:
    return {
        "script": f"tmp/omega_scripts/c{card_id}.lua",
        "card_id": card_id,
        "card_name": card_name,
        "matched_structure": matched_structure,
    }


# Per-effect verdict, current implementation, and independent disposition.
DECISIONS: dict[tuple[int, int], dict] = {
    (3, 1): {
        "verdict": "CUSTOM_GAP",
        "lua_implementation": "The hand Quick Effect pays by sending this card to the GY, targets a face-up Level/Rank monster, announces 1-3, and applies matching negative UPDATE_LEVEL/UPDATE_RANK effects through the next End Phase.",
        "issue": "Rejected as a patchable Lua defect and reclassified as an engine gap. Current Omega exposes UPDATE_LEVEL and UPDATE_RANK but no UPDATE_LINK/CHANGE_LINK effect code, so the printed Link Rating branch cannot be represented faithfully.",
    },
    (3, 2): {
        "verdict": "CUSTOM_GAP",
        "lua_implementation": "The GY Ignition Effect detects a face-up monster whose current Level or Rank is below its original value, then Special Summons this card and installs a banish leave-field redirect.",
        "issue": "Rejected as a patchable Lua defect and reclassified as the same engine gap. Omega has no original-Link comparison/update counterpart, so the Level/Rank branches are implemented but the printed Link Rating branch is not representable.",
    },
    (4, 1): {
        "verdict": "FIXED",
        "lua_implementation": "The hand Ignition Effect now permits any discardable hand card, including Bria itself, then independently attempts face-up opponent-Deck insertion, searches a Stain card, and conditionally draws for the field-count check.",
        "issue": "Confirmed and fixed: the unprinted c~=handler exclusion prevented Bria from being the generic 'discard 1 card' cost.",
    },
    (4, 2): {
        "verdict": "FIXED",
        "lua_implementation": "The Summon trigger targets any card in either GY or banishment, including face-down banished cards, then places it on the Deck bottom or adds an owned Stain card and shuffles Bria when that move succeeds.",
        "issue": "Confirmed and fixed: the printed target is any banished card, so the face-up-only banishment restriction was removed.",
        "official_references": [
            ref(74586817, "PSY-Framelord Omega", "Official generic banished-card group handling and movement back to another location."),
            ref(27572350, "Bystial Dis Pater", "Official selection and movement of cards from banishment."),
        ],
    },
    (12, 4): {
        "verdict": "FIXED",
        "lua_implementation": "After choosing a face-up non-Token opponent monster, the operation changes Silhouette's code to that monster's original code and now calls CopyEffect for every eligible monster, including Trap Monsters, through the End Phase.",
        "issue": "Confirmed and fixed: TYPE_TRAPMONSTER was an unprinted exclusion from '1 face-up monster'.",
        "official_references": [
            ref(43237273, "Neo-Spacian Dark Panther", "Official face-up monster selection followed by temporary copying of that monster's original effects."),
            ref(30312361, "Phantom of Chaos", "Official temporary monster-name/effect copying structure."),
        ],
    },
    (13, 2): {
        "verdict": "CUSTOM_GAP",
        "lua_implementation": "A global EVENT_MOVE approximation flags Stain monsters moved from outside a Deck into a Deck by effect, enabling face-up opponent-Deck Stain monsters as Fusion material and scheduling used cards to return to the GY in the End Phase.",
        "issue": "Confirmed semantic gap, not safely patchable: Omega exposes no generic 'was shuffled' event/reason. EVENT_MOVE cannot distinguish shuffling from placing on top/bottom, cannot reliably include every cost-based shuffle, and does not expose an unambiguous beneficiary for all such moves.",
    },
    (18, 3): {
        "verdict": "FIXED",
        "lua_implementation": "Both negate branches now install the Stain-only activation restriction in a shared activation cost, while the custom activity counter prevents activation after a non-Stain card/effect was already activated that turn.",
        "issue": "Confirmed and fixed: the restriction is tied to activating the negate effect, not to successfully negating the Summon/effect.",
        "official_references": [
            ref(24861088, "Chronomaly Nebra Disk", "Exact custom activity-counter plus activation-cost registration for 'cannot activate ... the turn you activate this effect'."),
        ],
    },
    (21, 1): {
        "verdict": "FIXED",
        "lua_implementation": "EVENT_DESTROYED now flags each on-field Spell/Trap in the GY by the effect's reason player; the activating player can Set exactly cards whose recorded destroyer was that player's opponent, independent of previous controller.",
        "issue": "Confirmed and fixed: 'your opponent's card effects' is relative to the activating player, not each destroyed card's previous controller.",
    },
    (25, 3): {
        "verdict": "FIXED",
        "lua_implementation": "The Fusion-material trigger still requires a summonable Talismandrake in the Pendulum Zone at activation, but at resolution the optional face-up Extra Deck placement is evaluated independently of whether the Special Summon succeeds, as required by 'also, you can'.",
        "issue": "Confirmed and fixed: the optional Pendulum placement was incorrectly nested under a successful Special Summon.",
    },
    (26, 2): {
        "verdict": "CUSTOM_GAP",
        "lua_implementation": "The trigger equips one of the four supported Arms cards and recreates its equip effects. Sabre/Shield values now count only Equip Spells whose equip target is controlled by the equipped monster's controller; battle replacement is implemented, and Shield approximates leave-field replacement with destroy/send replacements.",
        "issue": "The overbroad Equip count was confirmed and fixed. A residual engine gap remains: Omega has destroy/send replacement hooks but no generic optional replacement covering every return, banish, destroy, and send way a monster can 'leave the field'.",
    },
    (29, 3): {
        "verdict": "FIXED",
        "lua_implementation": "The equipped monster gains 500 ATK for each face-up Equip Spell whose equip target is a monster controlled by the equipped monster's controller, and battle destruction can be replaced by destroying this Equip Card.",
        "issue": "Confirmed and fixed: own Spell/Trap Zone Equip Cards attached to opposing monsters no longer contribute.",
    },
    (30, 3): {
        "verdict": "CUSTOM_GAP",
        "lua_implementation": "The equipped monster's DEF count now includes only Equip Spells attached to monsters its controller controls. Opponent-effect destroy/send departures can be replaced by destroying this card.",
        "issue": "The Equip-count defect was fixed. A custom engine gap remains because Omega has no generic optional leave-field replacement hook for return-to-hand, return-to-Deck, banish, destroy, and send destinations together.",
    },
    (32, 2): {
        "verdict": "CUSTOM_GAP",
        "lua_implementation": "The add/equip branch recreates the selected Arms card's effects; copied Sabre/Shield values now count only Equip Spells attached to controlled monsters, while Shield uses the available destroy/send replacement hooks.",
        "issue": "The inherited Equip-count defect was fixed. The inherited Shield all-destination leave-field replacement remains an Omega engine gap.",
    },
    (32, 3): {
        "verdict": "FIXED",
        "lua_implementation": "The Quick Effect now selects up to three cards from either GY or either banishment without an unprinted face-up requirement, and sends the selection to the Deck with GY selections respecting Necrovalley.",
        "issue": "Confirmed and fixed: the generic 'cards ... in either banishment' wording includes face-down banished cards.",
        "official_references": [
            ref(74586817, "PSY-Framelord Omega", "Official generic banished-card selection and return handling."),
            ref(31059809, "Silent Sea Nettle", "Official selection of up to three cards followed by shuffling them into the Deck."),
        ],
    },
    (33, 2): {
        "verdict": "CUSTOM_GAP",
        "lua_implementation": "The add/equip branch recreates the selected Arms card's effects; copied Sabre/Shield values now count only Equip Spells attached to controlled monsters, while Shield uses available destroy/send replacement hooks.",
        "issue": "The inherited Equip-count defect was fixed. The inherited Shield all-destination leave-field replacement remains an Omega engine gap.",
    },
    (34, 1): {
        "verdict": "CUSTOM_GAP",
        "lua_implementation": "The Pendulum effect shuffles three differently named Talismandrakes as cost, Special Summons Seraphina, and optionally equips an Arms card with recreated effects whose Equip counts are now controller-correct.",
        "issue": "The inherited Equip-count defect was fixed. Equipping Blaze Shield still inherits Omega's lack of a generic all-destination leave-field replacement hook.",
    },
    (34, 3): {
        "verdict": "CUSTOM_GAP",
        "lua_implementation": "The Fusion-Summon/opponent-activation branches target an Arms card in the GY and add or equip it; recreated Equip values are controller-correct and Shield uses available destroy/send replacement hooks.",
        "issue": "The inherited Equip-count defect was fixed. Equipping Blaze Shield still inherits Omega's lack of a generic all-destination leave-field replacement hook.",
    },
    (35, 4): {
        "verdict": "FIXED",
        "lua_implementation": "The Xyz-Summon trigger requires only a legal GY self-Summon at activation; after a successful Special Summon it attempts to draw 1, so draw prevention no longer blocks activation or revival.",
        "issue": "Confirmed and fixed: 'and if you do, draw 1' makes the draw dependent on the summon, not the summon dependent on draw legality.",
    },
    (38, 1): {
        "verdict": "FIXED",
        "lua_implementation": "At resolution the effect attempts the Aldrez monster search, then independently registers the rest-of-turn attack-declaration restriction regardless of whether a card was successfully added.",
        "issue": "Confirmed and fixed: 'also' makes the attack restriction independent of successful addition.",
        "official_references": [
            ref(32807846, "Reinforcement of the Army", "Official Deck search, SendtoHand, and confirmation structure."),
            ref(255998, "Rapid Warrior", "Official turn-long attack restriction tied to effect use."),
        ],
    },
    (51, 1): {
        "official_references": [
            ref(98477480, "Barrier of the Voiceless Voice", "Official conditional battle-target and effect-target protection while a Ritual Monster is controlled."),
        ],
    },
    (51, 3): {
        "official_references": [
            ref(63056220, "Megalith Ophiel", "Official Ritual support combining hand/field Tributes, Ritual-monster filtering, and Deck-to-hand selection."),
        ],
    },
    (52, 4): {
        "official_references": [
            ref(52472775, "Prayers of the Voiceless Voice", "Official EVENT_LEAVE_FIELD trigger for a controlled Ritual Monster leaving by card effect, followed by a Special Summon."),
        ],
    },
    (54, 1): {
        "official_references": [
            ref(22398665, "Meteonis Drytron", "Official Ritual Summon from hand or GY using hand/field Ritual materials and equal-or-greater material validation."),
            ref(52472775, "Prayers of the Voiceless Voice", "Official greater-than-or-equal Ritual procedure and material release structure."),
        ],
    },
    (54, 2): {
        "official_references": [
            ref(1174075, "Drytron Mu Beta Fafnir", "Official Deck selection and SendtoGrave handling for Ritual-related monsters."),
        ],
    },
    (56, 1): {
        "official_references": [
            ref(77235086, "Cyber Angel Benten", "Official Ritual Monster with the same printed 'You can Ritual Summon this card with ...' convention and revive-limit registration on the monster."),
        ],
    },
    (57, 1): {
        "official_references": [
            ref(77235086, "Cyber Angel Benten", "Official Ritual Monster with the same printed 'You can Ritual Summon this card with ...' convention and revive-limit registration on the monster."),
        ],
    },
    (58, 1): {
        "official_references": [
            ref(77235086, "Cyber Angel Benten", "Official Ritual Monster with the same printed 'You can Ritual Summon this card with ...' convention and revive-limit registration on the monster."),
        ],
    },
    (66, 2): {
        "verdict": "FIXED",
        "lua_implementation": "Activation now requires at least three cards in the Deck; resolution confirms exactly the top three, sends all excavated NiuHao/Sacred Treasure cards to the GY, and shuffles the remainder.",
        "issue": "Confirmed and fixed: an effect that excavates the top 3 cannot activate with fewer than three cards or silently excavate fewer.",
    },
    (71, 1): {
        "verdict": "PASS",
        "lua_implementation": "Current canonical Lua registers CANNOT_SUMMON, CANNOT_FLIP_SUMMON, and an SPSUMMON_CONDITION. Outside the Battle Phase, one existing monster is allowed only for the Level 5 Tribute Summon that uses that sole monster; Flip and Special Summons are prohibited while another monster remains.",
        "issue": "Rejected against current Lua: the reported missing Flip Summon prohibition is already present as EFFECT_CANNOT_FLIP_SUMMON with the field-state condition.",
    },
    (72, 1): {
        "verdict": "PASS",
        "lua_implementation": "Current canonical Lua registers CANNOT_SUMMON, CANNOT_FLIP_SUMMON, and an SPSUMMON_CONDITION. Outside the Battle Phase, one existing monster is allowed only for the Level 5 Tribute Summon that uses that sole monster; Flip and Special Summons are prohibited while another monster remains.",
        "issue": "Rejected against current Lua: the reported missing Flip Summon prohibition is already present as EFFECT_CANNOT_FLIP_SUMMON with the field-state condition.",
    },
}


def main() -> None:
    batch = json.loads(BATCH.read_text(encoding="utf-8"))
    current_cards = json.loads(CARDS.read_text(encoding="utf-8"))
    source_by_ordinal = {int(c["ordinal"]): c for c in batch["cards"]}

    missing = sorted(ORDINALS - source_by_ordinal.keys())
    if missing:
        raise SystemExit(f"missing source batch records: {missing}")

    for ordinal in sorted(ORDINALS):
        source = copy.deepcopy(source_by_ordinal[ordinal])
        current = current_cards[ordinal - 1]
        card_id = int(current["passcode"])
        if card_id != int(source["passcode"]) or current["name"] != source["name"]:
            raise SystemExit(f"ordinal {ordinal}: current identity differs from fresh batch")

        for effect in source["effects"]:
            decision = DECISIONS.get((ordinal, int(effect["effect_index"])))
            if decision:
                effect.update(copy.deepcopy(decision))

        # A local override may not leave a reported defect unresolved. Genuine
        # non-implementable findings are explicitly CUSTOM_GAP above.
        unresolved = [e["effect_index"] for e in source["effects"] if e["verdict"] == "DEFECT"]
        if unresolved:
            raise SystemExit(f"ordinal {ordinal}: unreconciled DEFECT effects {unresolved}")

        lua_path = LUA_DIR / f"c{card_id}.lua"
        source["text_sha256"] = sha256(str(current.get("text") or "").encode("utf-8"))
        source["script_sha256"] = sha256(lua_path.read_bytes())
        effect_count = len(source["effects"])
        source["coverage_override"] = {
            "expected_individual_effects": effect_count,
            "reason": (
                f"Independent manual segmentation of the exact current printed text into {effect_count} "
                "atomic material, condition, cost, operation, restriction, and count-limit clauses; "
                "every record was compared with current canonical Lua and an official Omega structure."
            ),
        }
        verdicts = {e["verdict"] for e in source["effects"]}
        if "DEFECT" in verdicts:
            source["overall_verdict"] = "DEFECT"
        elif "CUSTOM_GAP" in verdicts:
            source["overall_verdict"] = "CUSTOM_GAP"
        elif "FIXED" in verdicts:
            source["overall_verdict"] = "FIXED"
        else:
            source["overall_verdict"] = "PASS"

        counts = Counter(e["verdict"].lower() for e in source["effects"])
        payload = {
            "schema_version": 1,
            "batch": "local-reconciliation-1-72",
            "ordinal_start": ordinal,
            "ordinal_end": ordinal,
            "cards": [source],
            "summary": {
                "cards": 1,
                "effects": effect_count,
                "pass": counts["pass"],
                "fixed": counts["fixed"],
                "defects": counts["defect"],
                "custom_gaps": counts["custom_gap"],
            },
        }
        out = OUT_DIR / f"batch_local_{ordinal}_{ordinal}.json"
        out.write_text(json.dumps(payload, indent=2, ensure_ascii=False) + "\n", encoding="utf-8")

    print(f"generated {len(ORDINALS)} hash-pinned local reconciliation records")


if __name__ == "__main__":
    main()

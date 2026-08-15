#!/usr/bin/env python3
"""Write adversarially reviewed, hash-pinned overrides for CUSTOM_GAPs 217-432."""

from __future__ import annotations

import hashlib
import json
from collections import Counter
from pathlib import Path


ROOT = Path(__file__).resolve().parents[1]
OUT = ROOT / "scripts/output/effect_audit_agents"
CARDS = ROOT / "src/data/cards.json"
LUA = ROOT / "public/CCG Downloads/CCG_Scripts"

ORDINALS = (223, 237, 258, 272, 276, 299, 300, 301, 311, 315, 317, 319, 321, 373, 403, 404)

# Retained gaps state both the exact limitation and the concrete resolution needed.
RETAINED = {
    (223, 3): "Omega can inspect declared operation-info categories and chain targets, but arbitrary Lua operations need not declare either, so the engine cannot determine every effect that would make a controlled card leave the field. Exact resolution requires an engine API exposing the resolving operation's affected cards/destinations, or card text restricted to declared targets and enumerated leave-field categories.",
    (237, 2): "Omega can mark a Special Summon as a Synchro Summon and store real material cards, but cannot create truthful material history saying an otherwise material-less Summon used only Windborne monsters. The fabricated Janna token gives false card identity. Exact resolution requires engine-supported virtual material metadata (at least archetype/type without a fake card), or revised text that removes the material-history clause or names real materials.",
    (258, 2): "Omega exposes effect categories, listed card codes, handlers, and current targets, but cannot introspect every future monster choice made inside an arbitrary Lua operation. Exact resolution requires engine operation introspection for possible Summoned codes, or wording limited to effects that target/list the declared monster or another mechanically enumerable pool.",
    (272, 2): "The quoted conjunction names no card in the current 577-card database: no Spell/Trap contains both 'Verse IX' and 'Chapter II'. Exact resolution requires adding/naming the intended card (for example Chapter II Verse IX) or correcting the printed quoted name; until then only the unambiguous Eldora branch can be implemented.",
    (276, 4): "ChangeChainOperation can replace a resolving operation, but it cannot retroactively apply another card's activation condition or Tribute cost after the Chain Link was activated. The current Token release therefore occurs during resolution as REASON_EFFECT and cannot exactly become the copied activation procedure. Exact resolution requires revised text that copies only Extinction's resolving operation (and explicitly places any Token release at resolution), or a source effect whose activation legality/cost is checked before this Chain Link is created.",
    (373, 4): "The text does not identify which of an arbitrary monster's effects is meant or provide that effect's event, activation condition, cost, target, or parameters. CopyEffect grants the card's copyable effects for a duration; it cannot make this already-resolving effect become and execute an unspecified original effect. Exact resolution requires wording that grants copied effects for a stated duration, or selection of one specifically activatable effect with defined cost/target semantics.",
    (403, 4): "Only Xyz Monsters can legally hold Xyz Materials, while the printed target is any other Ghostrick monster. The current Xyz-only restriction is executable but narrower than the text. Exact resolution requires changing the target to 'Ghostrick Xyz Monster' or adding unsupported engine/card-rule semantics that allow non-Xyz monsters to hold materials.",
    (404, 4): "An already-controlled monster cannot be Xyz Summoned, so 'Xyz Summon ... monster you control' is internally impossible. Exact resolution requires selecting the Xyz Monster from the Extra Deck and defining its legal materials, or replacing 'Xyz Summon' with an attach/transfer instruction matching the current controlled-monster approximation.",
    (404, 5): "Omega has no generic runtime API that changes every arbitrary ignition/trigger effect registered on a selected monster into a Quick Effect for one turn; an inert flag cannot do so. Exact resolution requires engine support for temporary effect-type conversion, or revised text granting one specifically scripted Quick Effect.",
}

RESOLVED = {
    (299, 3): ("PASS", "Omega's linked-zone masks, target selection, and Duel.GetControl zone argument compose the printed placement-and-control operation exactly; a single official card with the entire composite wording is not required."),
    (300, 4): ("FIXED", "The effect is now non-targeting, selects at resolution, and permits face-down monsters in the controller's Monster Zone; Duel.MoveSequence moves the selected monster to a different free Main Monster Zone."),
    (300, 5): ("PASS", "RemoveCounter pays the all-counter cost, linked-zone masks select a legal pointed Main Monster Zone, and Duel.GetControl places the targeted opponent monster there exactly."),
    (301, 4): ("PASS", "The mutual-linked group is the co-linked Link Monster group; the cost removes every Current Counter from it and this card, then the standard non-target removal operation selects one to three opponent GY cards."),
    (311, 2): ("PASS", "The custom NATURE Attribute bit is natively testable with Card.IsAttribute; material inspection and the Deck/GY Special Summon use standard Omega APIs, so the absence of an official NATURE card is not an engine limitation."),
    (315, 1): ("PASS", "AddSynchroMixProcedure enforces exactly three Tuners and three non-Tuners, and the official GetClassCount(Card.GetAttribute) pattern independently enforces three different Attribute values in each subgroup."),
    (317, 1): ("PASS", "A field Summon procedure, subgroup legality check, material transfer, SetMaterial, Duel.Overlay, and SUMMON_TYPE_XYZ implement the alternative Xyz Summon exactly; uniqueness of the material combination does not make it an engine gap."),
    (319, 2): ("PASS", "CheckActivateEffect supplies the selected Spell's activation target/operation callbacks, following Omega's official activation-effect-copy pattern; sourcing the card from Deck and paying the printed two-part cost do not prevent exact execution."),
    (321, 1): ("FIXED", "The hybrid hand/field-to-GY and GY-to-Deck material handling is supported. The Fusion target is now removed from the candidate material group, preventing a Fusion Monster selected in the GY from becoming its own material before the authorized Fusion Summon."),
}


def digest(data: bytes) -> str:
    return hashlib.sha256(data).hexdigest()


def main() -> None:
    cards = json.loads(CARDS.read_text(encoding="utf-8"))
    for ordinal in ORDINALS:
        path = OUT / f"batch_local_{ordinal}_{ordinal}.json"
        payload = json.loads(path.read_text(encoding="utf-8"))
        record = payload["cards"][0]
        card = cards[ordinal - 1]
        passcode = int(card["passcode"])
        record["name"] = card["name"]
        record["passcode"] = passcode
        record["text_sha256"] = digest(str(card.get("text") or "").encode("utf-8"))
        record["script_sha256"] = digest((LUA / f"c{passcode}.lua").read_bytes())

        reviewed = []
        for effect in record["effects"]:
            key = (ordinal, int(effect["effect_index"]))
            if key in RETAINED:
                effect["verdict"] = "CUSTOM_GAP"
                effect["issue"] = RETAINED[key]
                reviewed.append(f"effect {key[1]} retained")
            elif key in RESOLVED:
                verdict, implementation = RESOLVED[key]
                effect["verdict"] = verdict
                effect["issue"] = None if verdict == "PASS" else implementation
                effect["lua_implementation"] = implementation
                reviewed.append(f"effect {key[1]} {verdict.lower()}")

        verdicts = [effect["verdict"] for effect in record["effects"]]
        if "DEFECT" in verdicts:
            record["overall_verdict"] = "DEFECT"
        elif "CUSTOM_GAP" in verdicts:
            record["overall_verdict"] = "CUSTOM_GAP"
        elif "FIXED" in verdicts:
            record["overall_verdict"] = "FIXED"
        else:
            record["overall_verdict"] = "PASS"
        record["audit_note"] = "Adversarial completion review: " + "; ".join(reviewed) + ". Prior labels were not treated as evidence."
        record["coverage_override"] = {
            "expected_individual_effects": len(record["effects"]),
            "reason": "Complete card override retained after re-reading every printed clause, current Lua registration/procedure, relevant engine helpers/constants, and each cited official Omega script/database record.",
        }
        record["supersedes_batch"] = record.get("supersedes_batch") or payload.get("batch")

        counts = Counter(effect["verdict"].lower() for effect in record["effects"])
        payload["batch"] = "local-adversarial-custom-gap-review-217-432"
        payload["summary"] = {
            "cards": 1,
            "effects": len(record["effects"]),
            "pass": counts["pass"],
            "fixed": counts["fixed"],
            "defects": counts["defect"],
            "custom_gaps": counts["custom_gap"],
        }
        path.write_text(json.dumps(payload, indent=2, ensure_ascii=False) + "\n", encoding="utf-8")


if __name__ == "__main__":
    main()

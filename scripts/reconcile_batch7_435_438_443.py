#!/usr/bin/env python3
"""Build the reviewed local overrides for batch-7 ordinals 435, 438, and 443."""

from __future__ import annotations

import hashlib
import json
from pathlib import Path


ROOT = Path(__file__).resolve().parents[1]
CARDS = json.loads((ROOT / "src/data/cards.json").read_text(encoding="utf-8"))
SCRIPTS = ROOT / "public" / "CCG Downloads" / "CCG_Scripts"
SOURCE = ROOT / "scripts/output/effect_audit_agents/batch_7_433_504.json"
OUTPUT = ROOT / "scripts/output/effect_audit_agents/batch_local_435_438_443.json"
ORDINALS = (435, 438, 443)


def sha256(data: bytes) -> str:
    return hashlib.sha256(data).hexdigest()


payload = json.loads(SOURCE.read_text(encoding="utf-8"))
records = {record["ordinal"]: record for record in payload["cards"] if record["ordinal"] in ORDINALS}
if set(records) != set(ORDINALS):
    raise SystemExit(f"missing source records: {set(ORDINALS) - set(records)}")

for ordinal, record in records.items():
    card = CARDS[ordinal - 1]
    if record["passcode"] != card["passcode"] or record["name"] != card["name"]:
        raise SystemExit(f"identity mismatch at ordinal {ordinal}")
    record["text_sha256"] = sha256((card.get("text") or "").encode("utf-8"))
    record["script_sha256"] = sha256((SCRIPTS / f"c{card['passcode']}.lua").read_bytes())

# Gravinity Spherix: the summon replacement and arbitrary-Xyz minimum remain
# separate, precisely bounded engine gaps.
spherix = records[435]
spherix["overall_verdict"] = "CUSTOM_GAP"
effect = spherix["effects"][4]
effect["lua_implementation"] = (
    "After the granted Ignition Effect Special Summons the handler, s.spop gathers Level-equal, "
    "overlay-eligible monsters from the controller's GY and overlays exactly two. Omega's Xyz "
    "helpers receive their material filter and min/max only inside each Extra Deck card's registered "
    "summon-procedure closures; the summoned card exposes no supported API that returns those values."
)
effect["verdict"] = "CUSTOM_GAP"
effect["issue"] = (
    "Omega cannot generically recover an arbitrary Xyz Monster's printed minimum material count or "
    "material predicate after that card has already been Special Summoned to the field. "
    "Card.IsXyzSummonable can test a prospective Extra Deck summon but cannot extract the registered "
    "procedure from this already-summoned card. The current two same-Level attachments are therefore "
    "only an approximation and are not exact for level-free, variable-count, alternate, or non-Level procedures."
)
effect["official_references"] = [
    {
        "script": "c29087919.lua",
        "card_id": 29087919,
        "card_name": "Geargia Change",
        "matched_structure": (
            "Official Omega constrained Xyz-Summon implementation passes a known material Group and "
            "explicit count to Card.IsXyzSummonable, demonstrating that the procedure parameters must "
            "be supplied by the caller rather than queried from an already-summoned Xyz Monster."
        ),
    },
    {
        "script": "c72444406.lua",
        "card_id": 72444406,
        "card_name": "Enigmaster Packbit",
        "matched_structure": (
            "Official Omega precedent for granting a Monster Card in the Spell/Trap Zone an Ignition "
            "Effect that Special Summons it while it is a Continuous Trap."
        ),
    },
]

# Gravinity Axis Matter: fix the concrete MZONE scope and copied counter test,
# while documenting the absent Link mutation and generic selective copier.
axis = records[438]
axis["overall_verdict"] = "CUSTOM_GAP"
effect = axis["effects"][1]
effect["lua_implementation"] = (
    "Field effects apply EFFECT_UPDATE_LEVEL and EFFECT_UPDATE_RANK with value -1 to opponent's "
    "Monster Zone cards whose columns contain a Gravinity monster in the controller's Monster Zone. "
    "No Link Rating effect is registered because Omega defines no update/change-Link constant."
)
effect["verdict"] = "CUSTOM_GAP"
effect["issue"] = (
    "Fixed the concrete scope error: a Gravinity Monster Card in the Spell/Trap Zone no longer counts "
    "as a Gravinity monster for this clause. The Level and Rank reductions are exact. Link Rating "
    "reduction remains unsupported: Omega's constants provide EFFECT_UPDATE_LEVEL/RANK and "
    "EFFECT_CHANGE_LEVEL/RANK, but no EFFECT_UPDATE_LINK, EFFECT_CHANGE_LINK, or equivalent setter."
)
effect["official_references"] = [
    {
        "script": "c83566725.lua",
        "card_id": 83566725,
        "card_name": "The Phantom Knights of Doomed Soleret",
        "matched_structure": (
            "Official Omega uses separate EFFECT_UPDATE_LEVEL and EFFECT_UPDATE_RANK registrations; "
            "there is no corresponding supported Link Rating mutation in the official constants or scripts."
        ),
    }
]
effect = axis["effects"][2]
effect["lua_implementation"] = (
    "The Standby Phase cost reveals a Level 11 Gravinity Synchro and stores its original code. "
    "For the complete current pool, copyop explicitly recreates Nebulix's resolution-addition effect "
    "or Spherix's summon reaction and Monster-Card counter effect until the End Phase. The Spherix "
    "counter condition now requires original Monster Card type."
)
effect["verdict"] = "CUSTOM_GAP"
effect["issue"] = (
    "The hard-coded branches cover both Level 11 Gravinity Synchro Monsters currently present and the "
    "copied Spherix counter test was corrected to exclude non-Monster Cards. The printed effect is still "
    "generic and cannot be implemented generically: Card.CopyEffect copies a card script wholesale, "
    "while Omega exposes no supported iterator/copier that selects only non-activated effects and safely "
    "rebinds arbitrary monster effects to a Field Spell. A future valid reveal requires a new explicit branch."
)
effect["official_references"] = [
    {
        "script": "c11522979.lua",
        "card_id": 11522979,
        "card_name": "Number C69: Heraldry Crest of Horror",
        "matched_structure": (
            "Official Omega generic copying uses Card.CopyEffect by script code and therefore copies the "
            "target script's registered effects as a unit, not only its non-activated effects."
        ),
    },
    {
        "script": "c41371602.lua",
        "card_id": 41371602,
        "card_name": "Stand Up Centur-Ion!",
        "matched_structure": (
            "Official Omega Field Spell precedent for temporary field/trigger effects with location and "
            "phase-scoped registrations."
        ),
    },
]

# Flower Cardian Moonflare: remove the incorrect custom-Tuner route. Omega's
# hook can replace material selection, but one Group member remains one material.
moonflare = records[443]
moonflare["overall_verdict"] = "CUSTOM_GAP"
effect = moonflare["effects"][4]
effect["lua_implementation"] = (
    "No Lua effect is registered for this clause. The former EFFECT_SYNCHRO_MATERIAL_CUSTOM block was "
    "removed because that hook is Omega's custom-Tuner procedure and Duel.SetSynchroMaterial receives "
    "a Group of physical cards; selecting Moonflare alone neither contributes three non-Tuner count slots "
    "nor preserves the required Tuner/non-Tuner procedure."
)
effect["verdict"] = "CUSTOM_GAP"
effect["issue"] = (
    "Omega supports custom Synchro material selection and alternate Synchro Levels, but not material-count "
    "multiplicity for one non-Tuner. Official EFFECT_SYNCHRO_MATERIAL_CUSTOM patterns still validate min/max "
    "using Group:GetCount and pass physical cards to Duel.SetSynchroMaterial. The previous code could expose "
    "an unintended custom-Tuner route while failing to count Moonflare as three non-Tuners, so that incorrect "
    "registration was removed. Exact support requires an engine material-count API or revised card text."
)
effect["official_references"] = [
    {
        "script": "c33541430.lua",
        "card_id": 33541430,
        "card_name": "Flower Cardian Moonflowerviewing",
        "matched_structure": (
            "Official Flower Cardian EFFECT_SYNCHRO_MATERIAL_CUSTOM implementation replaces the full material "
            "selection, counts physical Group members, and supports alternate Synchro Levels, not one card "
            "occupying multiple non-Tuner material-count slots."
        ),
    },
    {
        "script": "c89818984.lua",
        "card_id": 89818984,
        "card_name": "Flower Cardian Willow with Calligrapher",
        "matched_structure": (
            "Official Flower Cardian custom-material precedent uses Duel.SetSynchroMaterial with a physical "
            "Group and changes Synchro Level interpretation rather than material multiplicity."
        ),
    },
]

cards = [records[ordinal] for ordinal in ORDINALS]
counts = {"PASS": 0, "FIXED": 0, "DEFECT": 0, "CUSTOM_GAP": 0}
for record in cards:
    for item in record["effects"]:
        counts[item["verdict"]] += 1

out = {
    "schema_version": 1,
    "batch": "local-batch7-reconciliation",
    "ordinal_start": min(ORDINALS),
    "ordinal_end": max(ORDINALS),
    "cards": cards,
    "summary": {
        "cards": len(cards),
        "effects": sum(len(record["effects"]) for record in cards),
        "pass": counts["PASS"],
        "fixed": counts["FIXED"],
        "defects": counts["DEFECT"],
        "custom_gaps": counts["CUSTOM_GAP"],
    },
}
OUTPUT.write_text(json.dumps(out, indent=2, ensure_ascii=False) + "\n", encoding="utf-8")
print(OUTPUT)
print(json.dumps(out["summary"], indent=2))

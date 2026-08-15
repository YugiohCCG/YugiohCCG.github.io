#!/usr/bin/env python3
"""Write complete adversarially reviewed overrides for CUSTOM_GAP cards 1-216."""

from __future__ import annotations

import hashlib
import json
from collections import Counter
from pathlib import Path


ROOT = Path(__file__).resolve().parents[1]
REPORT = ROOT / "scripts" / "output" / "ccg_effect_by_effect_official_reference_audit.json"
OUT = ROOT / "scripts" / "output" / "effect_audit_agents"
CARDS = ROOT / "src" / "data" / "cards.json"
LUA = ROOT / "public" / "CCG Downloads" / "CCG_Scripts"


GAPS = {
    (3, 1): (
        "Omega exposes EFFECT_UPDATE_LEVEL and EFFECT_UPDATE_RANK but no effect code that changes a Link Rating. The Lua therefore cannot offer or resolve the printed Link Rating branch.",
        "Resolution: either change the card text to 'Level or Rank', or add an engine-supported Link Rating change API and then add the Link branch to c221321849.lua.",
    ),
    (3, 2): (
        "Omega exposes original/current Level and Rank comparisons but no mutable/current Link Rating counterpart. The Lua therefore cannot detect the printed reduced-Link-Rating state.",
        "Resolution: either remove 'Link Rating' from this condition, or add engine APIs for changing and comparing Link Rating and then extend c221321849.lua.",
    ),
    (13, 2): (
        "EVENT_MOVE does not identify whether movement into a Deck was a shuffle, and it cannot reliably cover cost-based or rule-based shuffles. The current REASON_EFFECT tracker is only an approximation.",
        "Resolution: rewrite the condition as 'If your Stain monster was moved into a Deck by a card effect this turn', or add a core shuffle event/reason and use it in c232449539.lua.",
    ),
    (26, 2): (
        "Equipping Blaze Shield 'as if equipped by that card's effect' inherits its optional all-destination leave-field replacement. Omega only provides destroy/send replacement hooks, so return-to-hand, return-to-Deck, and banish departures are not replaced.",
        "Resolution: narrow Blaze Shield to destruction/sending, or add a generic optional leave-field replacement hook and use it in the recreated equip effects in c215034223.lua.",
    ),
    (30, 3): (
        "Omega has optional EFFECT_DESTROY_REPLACE and EFFECT_SEND_REPLACE hooks, but no optional replacement covering every return, banish, destroy, and send way the equipped monster can leave by an opponent's effect.",
        "Resolution: change the text to the supported destinations (for example, 'destroyed or sent to the GY'), or add a generic optional leave-field replacement hook and replace both partial hooks in c255832330.lua.",
    ),
    (32, 2): (
        "The copied Blaze Shield behavior is incomplete for return-to-hand, return-to-Deck, and banish departures because Omega has no generic optional all-destination leave-field replacement hook.",
        "Resolution: narrow Blaze Shield's text, or add a generic optional leave-field replacement hook and use it in c253552927.lua's recreated Shield effects.",
    ),
    (33, 2): (
        "The copied Blaze Shield behavior is incomplete for return-to-hand, return-to-Deck, and banish departures because Omega has no generic optional all-destination leave-field replacement hook.",
        "Resolution: narrow Blaze Shield's text, or add a generic optional leave-field replacement hook and use it in c241706191.lua's recreated Shield effects.",
    ),
    (34, 1): (
        "If this effect equips Blaze Shield, its recreated optional leave-field replacement cannot cover return-to-hand, return-to-Deck, or banish departures with current Omega hooks.",
        "Resolution: narrow Blaze Shield's text, or add a generic optional leave-field replacement hook and use it in c218142234.lua's recreated Shield effects.",
    ),
    (34, 3): (
        "If this effect equips Blaze Shield, its recreated optional leave-field replacement cannot cover return-to-hand, return-to-Deck, or banish departures with current Omega hooks.",
        "Resolution: narrow Blaze Shield's text, or add a generic optional leave-field replacement hook and use it in c218142234.lua's recreated Shield effects.",
    ),
    (56, 2): (
        "The text does not resolve whether each Frute retains one ordinary attack against a non-qualifying monster in addition to attacks on every face-down Defense Position monster. The current first-attack tracker also cannot preserve exact once-each identity if a battled monster changes position and is Set again.",
        "Resolution: issue a ruling for the ordinary-attack interaction and change the text to match it; then replace c213266433.lua's approximation with a ruling-specific attack procedure (or add filtered attack-all bookkeeping to the engine).",
    ),
    (87, 2): (
        "Official Ursarctic Extra Deck monsters use bespoke non-Synchro EFFECT_SPSUMMON_PROC scripts that read card Levels directly and expose no material-side hook for Hextanius to become Level 7/8 and a non-Tuner. Only the CCG procedures that explicitly call Hextanius-aware helpers can honor the text.",
        "Resolution: update every Ursarctic summon procedure that must recognize Hextanius (including official scripts), or revise the text to limit the substitution to named CCG Ursarctic monsters.",
    ),
    (100, 3): (
        "CheckActivateEffect can reproduce activatable Spell/Trap effects, but Omega has no generic API that selects and rebinds an arbitrary monster's Normal/Special Summon trigger, event group, targets, labels, and operation. The Lua manually mirrors only the currently listed Stain monsters.",
        "Resolution: enumerate the supported monster names in the printed text and maintain the manual map, or add a core trigger-copy API and replace the hard-coded branches in c245970073.lua.",
    ),
    (111, 2): (
        "EFFECT_CANNOT_TO_HAND is reason-agnostic, so the current Lua also blocks returning the target as a cost. Master Rule Omega has no EFFECT_CANNOT_TO_HAND_EFFECT equivalent that limits the prohibition to card effects.",
        "Resolution: remove 'by card effect' from the text, or add an effect-only hand-return prohibition to the engine and use it in c229996802.lua.",
    ),
    (113, 2): (
        "EFFECT_CANNOT_TO_HAND and EFFECT_CANNOT_TO_DECK are reason-agnostic, so the current Lua also blocks costs and other non-effect movement during the End Phase. EFFECT_SPIRIT_DONOT_RETURN would cover only the built-in Spirit return and not arbitrary card effects.",
        "Resolution: remove 'by card effect', narrow the text to built-in Spirit returns, or add effect-only hand/Extra-Deck return prohibitions and use them in c221855414.lua.",
    ),
    (116, 3): (
        "Omega's prospective Extra Deck Special Summon restriction callback does not expose the material group. The Lua instead prohibits non-Grand Blue cards from being Fusion, Synchro, Xyz, or Link Material, which does not reject materialless or nonstandard Extra Deck procedures.",
        "Resolution: rewrite the restriction as four material prohibitions matching the Lua, or add a summon-limit API that receives the prospective material group and replace the approximation in c259369909.lua.",
    ),
    (126, 3): (
        "'That destroyed card's Standby Phase-activated effect' does not identify which effect to apply when the monster has multiple Standby Phase triggers. Omega also has no API for invoking one arbitrary trigger outside its event while preserving its event data and targeting semantics.",
        "Resolution: identify the intended effect by exact text/index or restrict the eligible monsters to an enumerated list, then script those operations; otherwise add a core trigger-invocation API.",
    ),
    (135, 5): (
        "Omega stores some Card TurnCounter values but has no enumerable 'turn count' for every active effect or reset duration. The phrase 'all effects' turn count' also does not define which players, cards, locations, counters, or durations are included.",
        "Resolution: define the exact counters/effects and locations to advance, or replace the clause with a supported operation such as Pyro Clock of Destiny's global turn-count advance.",
    ),
    (139, 3): (
        "The finite AnnounceNumber UI accepts an explicit option list and has no unrestricted integer-entry prompt. Enumerating every integer from 1 to LP-1 is not a supported/practical Omega selection, so the Lua currently offers 100-LP increments plus LP-1.",
        "Resolution: change 'any amount' to 'any amount in multiples of 100 (or all but 1 LP)', or add an integer-range prompt to Omega and use it in c217332244.lua.",
    ),
    (141, 3): (
        "Omega has no event reporting historical ATK/DEF loss. The text also omits whether gains accumulate, disappear when the losing monster leaves, or continuously track current deficits; the Lua currently models live deficits from base values.",
        "Resolution: state the duration and whether the gain is event-based or continuously recalculated. Then implement that ruling, adding an ATK/DEF-loss event to the engine if historical loss must be tracked.",
    ),
    (146, 3): (
        "The text targets any two cards you control, but Spell/Trap Cards and many monsters cannot have a Level. Literal resolution is undefined for those legal printed targets; the Lua restricts selection to two face-up monsters with Levels.",
        "Resolution: change the target to '2 face-up monsters you control with Levels' (or specify how non-Level cards behave), then align c225106953.lua to that ruling.",
    ),
    (165, 1): (
        "The printed trigger says 'when ... resolves', but chains cannot be started during another effect's resolution. The Lua necessarily responds at activation and predicts destruction from CATEGORY_DESTROY metadata, which cannot identify effects whose victims/count are chosen only while resolving.",
        "Resolution: rewrite this as 'When your opponent activates a card or effect that would destroy 2 or more monsters you control' and accept category-based prediction, or define a new engine replacement/interception event before destruction resolves.",
    ),
    (167, 1): (
        "Omega has no universal categories for face-up Spell/Trap placement, placing Monster Cards in the Spell & Trap Zone, or every Set from hand/Deck/GY. CATEGORY_LEAVE_GRAVE is overbroad, while custom markers only cover scripts that opt in.",
        "Resolution: narrow the three bullets to engine-detectable categories, require all relevant scripts to publish dedicated placement/Set markers, or add core operation categories and update c222676270.lua to use them.",
    ),
}


FIXED = {
    (209, 1): (
        "Replaced the standard Fusion/contact helpers with a dedicated summon procedure that selects exactly one controlled Bob and one controlled Umi, verifies the freed Extra Deck zone, records both as material, and sends both to the GY for the summon.",
        "The previous helper path rejected Umi because official Fusion helpers require Card.IsCanBeFusionMaterial; the dedicated procedure now implements the printed non-Polymerization summon exactly.",
    )
}

PASS_REVIEWED = {
    (1, 1), (5, 2), (6, 3), (7, 2), (8, 1), (8, 2), (9, 1), (9, 2),
    (11, 3), (12, 1), (14, 1), (15, 2), (16, 4), (17, 2), (68, 4),
    (159, 2), (160, 2), (161, 1), (165, 2), (187, 2), (189, 1),
    (201, 2), (202, 4), (203, 3), (204, 1), (206, 1), (207, 1),
}


def digest(data: bytes) -> str:
    return hashlib.sha256(data).hexdigest()


def main() -> None:
    report = json.loads(REPORT.read_text(encoding="utf-8"))
    cards_data = json.loads(CARDS.read_text(encoding="utf-8"))
    affected = {}
    reviewed = set(GAPS) | set(FIXED) | PASS_REVIEWED
    found_reviewed = set()
    for record in report["cards"]:
        ordinal = int(record["ordinal"])
        if ordinal > 216:
            continue
        keys = {(ordinal, int(effect["effect_index"])) for effect in record["effects"] if (ordinal, int(effect["effect_index"])) in reviewed}
        if keys:
            affected[ordinal] = record
            found_reviewed.update(keys)

    if found_reviewed != reviewed:
        raise SystemExit(f"Missing reviewed effect records: {sorted(reviewed-found_reviewed)}")
    if len(reviewed) != 50 or len(affected) != 45:
        raise SystemExit(f"Expected 50 reviewed effects on 45 cards, found {len(reviewed)} on {len(affected)}")

    for ordinal, source in sorted(affected.items()):
        record = json.loads(json.dumps(source))
        card = cards_data[ordinal - 1]
        passcode = int(card["passcode"])
        record["name"] = card["name"]
        record["passcode"] = passcode
        record["text_sha256"] = digest(str(card.get("text") or "").encode("utf-8"))
        record["script_sha256"] = digest((LUA / f"c{passcode}.lua").read_bytes())

        for effect in record["effects"]:
            key = (ordinal, int(effect["effect_index"]))
            if key not in reviewed:
                continue
            if key in GAPS:
                why, resolution = GAPS[key]
                effect["verdict"] = "CUSTOM_GAP"
                effect["issue"] = f"{why} {resolution}"
                effect["lua_implementation"] = f"{effect['lua_implementation']} Adversarial re-review confirmed this remains non-exact."
            elif key in FIXED:
                implementation, issue = FIXED[key]
                effect["verdict"] = "FIXED"
                effect["lua_implementation"] = implementation
                effect["issue"] = issue
            else:
                effect["verdict"] = "PASS"
                effect["issue"] = None
                effect["lua_implementation"] = (
                    "Adversarial re-review confirmed that the current canonical Lua implements this printed effect "
                    "with supported Omega primitives. A compound effect need not have a single-card official analogue; "
                    "the attached official references validate its individual engine structures."
                )

        verdicts = [effect["verdict"] for effect in record["effects"]]
        if "DEFECT" in verdicts:
            record["overall_verdict"] = "DEFECT"
        elif "CUSTOM_GAP" in verdicts:
            record["overall_verdict"] = "CUSTOM_GAP"
        elif "FIXED" in verdicts:
            record["overall_verdict"] = "FIXED"
        else:
            record["overall_verdict"] = "PASS"
        record["coverage_override"] = {
            "expected_individual_effects": len(record["effects"]),
            "reason": (
                "Complete adversarial effect-by-effect re-review of every former CUSTOM_GAP on this card against "
                "current printed text, canonical Lua, Omega constants/helpers, and official database/scripts; all "
                "other PASS/FIXED records were preserved."
            ),
        }
        record["supersedes_batch"] = source.get("source_batch", source.get("supersedes_batch"))

        counts = Counter(effect["verdict"].lower() for effect in record["effects"])
        payload = {
            "schema_version": 1,
            "batch": "local-custom-gap-adversarial-1-216",
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

    print(f"reviewed_custom_gaps={len(reviewed)} affected_cards={len(affected)}")
    print(f"remaining_custom_gaps={len(GAPS)} fixed={len(FIXED)} reclassified_pass={len(PASS_REVIEWED)}")


if __name__ == "__main__":
    main()

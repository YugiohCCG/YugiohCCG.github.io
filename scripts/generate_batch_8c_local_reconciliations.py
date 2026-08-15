#!/usr/bin/env python3
"""Create complete local overrides for reconciled batch 8c findings."""

from __future__ import annotations

import copy
import hashlib
import json
from collections import Counter
from pathlib import Path


ROOT = Path(__file__).resolve().parents[1]
BATCH_DIR = ROOT / "scripts/output/effect_audit_agents"
SOURCE = BATCH_DIR / "batch_8c_539_555.json"
CARDS = json.loads((ROOT / "src/data/cards.json").read_text(encoding="utf-8"))
CCG = ROOT / "public/CCG Downloads/CCG_Scripts"
ORDINALS = (539, 540, 541, 548, 549, 551)


RECONCILIATIONS = {
    (539, 2): {
        "lua_implementation": (
            "No field effect can expose a scalar counter value as material to every unrelated Ritual Summon procedure. "
            "Counter substitution remains implemented only inside this card's own triggered ritualsummon operation."
        ),
        "verdict": "CUSTOM_GAP",
        "issue": (
            "Retained after reconciliation: Omega's EFFECT_EXTRA_RITUAL_MATERIAL exposes actual cards, not an abstract "
            "Level contribution. The official index contains 11 users of that effect, none counter-based, and the closest "
            "arbitrary-procedure workaround (Emperor Tanuki's Critter Count, c20560620.lua) is itself marked 'not fully "
            "implemented' and monkey-patches shared Ritual helpers. There is no safe card-local way to make Corruption "
            "Counters participate in every current and future Cyberse Ritual procedure."
        ),
    },
    (539, 4): {
        "lua_implementation": (
            "The alternate operation now uses a shared face-up Cyberse filter both for activation legality and resolution, "
            "counts only face-up Cyberse monsters in the controller's Monster Zone, and announces an addable counter amount."
        ),
        "verdict": "FIXED",
        "issue": (
            "Confirmed and corrected: the previous Card.IsRace-only count included face-down monsters. The filter now "
            "requires Card.IsFaceup before testing RACE_CYBERSE."
        ),
    },
    (540, 1): {
        "lua_implementation": (
            "AddLinkProcedure requires 2 or 3 Cyberse monsters for this Link-3 monster, followed by EnableReviveLimit; "
            "the current printed text still supplies no material line against which that choice can be proven."
        ),
        "verdict": "CUSTOM_GAP",
        "issue": (
            "Retained as a genuine source ambiguity: a Link Monster needs a material procedure, but the preserved printed "
            "text omits the material line entirely. No official reference can determine whether the intended requirement "
            "was 2+, exactly 3, Effect Monsters, Cyberse monsters, or an archetype-specific group. The existing 2-3 Cyberse "
            "procedure is playable, but cannot be semantically certified without changing or clarifying printed text."
        ),
    },
    (540, 4): {
        "lua_implementation": (
            "The free-chain counter-removal effect is unchanged, but its per-turn cap now gathers the three exact named "
            "cards from LOCATION_ONFIELD+LOCATION_GRAVE, requires named cards on the field to be face-up, and counts "
            "different codes with GetClassCount."
        ),
        "verdict": "FIXED",
        "issue": (
            "Confirmed and corrected: the old cap omitted face-up named cards in the Spell/Trap Zone and counted face-down "
            "Monster Zone cards. It now covers the full field plus GY while excluding face-down on-field identities."
        ),
    },
    (541, 1): {
        "lua_implementation": (
            "The activation target function now announces and stores the card code at activation, following Akashic "
            "Magician's official CHAININFO_TARGET_PARAM pattern. The delayed opponent-End-Phase operation selects the "
            "declared and other card, randomly chooses their relative top order, calls DisableShuffleCheck, and moves only "
            "those two cards without shuffling the rest of the Deck."
        ),
        "verdict": "FIXED",
        "issue": (
            "Confirmed and corrected: declaration formerly occurred at resolution and Duel.ShuffleDeck reordered the entire "
            "Deck. Declaration is now part of activation and only the chosen pair's order is randomized."
        ),
    },
    (548, 1): {
        "lua_implementation": (
            "The custom greater-or-equal Ritual operation now requires IsAbleToGrave only for Deck monsters explicitly sent "
            "to the GY. Hand/MZONE monsters need Level and ritual-material legality and are released normally, so replacement "
            "effects can redirect those Tributes. Continuous S/T materials still require face-up, archetype/type, and GY legality."
        ),
        "verdict": "FIXED",
        "issue": (
            "Confirmed and corrected: the previous global IsAbleToGrave check rejected legal hand/field Ritual Tributes "
            "under Macro-Cosmos-like redirection. The check is now location-specific to Deck materials."
        ),
    },
    (548, 2): {
        "lua_implementation": (
            "ritop now executes the attempted Ritual operation and then always registers the End-Phase-reset Extra Deck "
            "Special Summon restriction for non-Spellcaster/non-Fairy monsters whenever the card's operation resolves."
        ),
        "verdict": "FIXED",
        "issue": (
            "Confirmed and corrected: the restriction was previously conditional on a successful Ritual Summon, despite "
            "being printed as applying after this card resolves."
        ),
    },
    (549, 3): {
        "lua_implementation": (
            "The delayed EVENT_TO_GRAVE trigger still requires REASON_EFFECT and a Charmelia handler, but now identifies the "
            "causing effect as a monster effect with re:IsActiveType(TYPE_MONSTER) before moving this card face-up from GY."
        ),
        "verdict": "FIXED",
        "issue": (
            "Confirmed and corrected: the old condition inspected the handler's current type after movement/state changes. "
            "It now tests the active type captured for the effect that actually sent this card."
        ),
    },
    (551, 4): {
        "lua_implementation": (
            "The condition now recognizes every opponent monster whose Summon location was the Extra Deck, including a "
            "face-down one, matching Dogmatika Ecclesia. The filter and operation use nocheck=true,nolimit=true to ignore "
            "Summoning Conditions, summon with SUMMON_TYPE_RITUAL, and CompleteProcedure."
        ),
        "verdict": "FIXED",
        "issue": (
            "Confirmed and corrected: the old face-up filter excluded face-down Extra-Deck-Summoned monsters, and "
            "nocheck=false did not implement the explicit 'ignoring its Summoning Conditions' instruction."
        ),
    },
}


def sha256(data: bytes) -> str:
    return hashlib.sha256(data).hexdigest()


def main() -> int:
    source = json.loads(SOURCE.read_text(encoding="utf-8"))
    by_ordinal = {int(card["ordinal"]): card for card in source["cards"]}
    for ordinal in ORDINALS:
        record = copy.deepcopy(by_ordinal[ordinal])
        card = CARDS[ordinal - 1]
        script_path = CCG / f"c{card['passcode']}.lua"
        record["text_sha256"] = sha256(str(card.get("text") or "").encode("utf-8"))
        record["script_sha256"] = sha256(script_path.read_bytes())
        record["supersedes_batch"] = SOURCE.name
        record["reconciliation_note"] = (
            "All batch_8c findings for this card were re-evaluated against current Lua and the cited official Omega "
            "references. Confirmed defects are patched; retained CUSTOM_GAP records explain the remaining engine/source limit."
        )
        for item in record["effects"]:
            update = RECONCILIATIONS.get((ordinal, int(item["effect_index"])))
            if update:
                item.update(update)

        verdicts = Counter(item["verdict"] for item in record["effects"])
        if verdicts["CUSTOM_GAP"]:
            record["overall_verdict"] = "CUSTOM_GAP"
        elif verdicts["FIXED"]:
            record["overall_verdict"] = "FIXED"
        else:
            record["overall_verdict"] = "PASS"
        payload = {
            "schema_version": 1,
            "batch": "batch-8c-local-reconciliation",
            "ordinal_start": ordinal,
            "ordinal_end": ordinal,
            "cards": [record],
            "summary": {
                "cards": 1,
                "effects": len(record["effects"]),
                "pass": verdicts["PASS"],
                "fixed": verdicts["FIXED"],
                "defects": verdicts["DEFECT"],
                "custom_gaps": verdicts["CUSTOM_GAP"],
            },
        }
        output = BATCH_DIR / f"batch_local_{ordinal}_{ordinal}.json"
        output.write_text(json.dumps(payload, ensure_ascii=False, indent=2) + "\n", encoding="utf-8")
        print(f"wrote {output.name}")
    return 0


if __name__ == "__main__":
    raise SystemExit(main())

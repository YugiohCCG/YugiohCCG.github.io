#!/usr/bin/env python3
"""Generate hash-pinned adversarial reconciliations for CUSTOM_GAP cards 444-555."""

from __future__ import annotations

import hashlib
import json
from collections import Counter
from pathlib import Path


ROOT = Path(__file__).resolve().parents[1]
REPORT = ROOT / "scripts" / "output" / "ccg_effect_by_effect_official_reference_audit.json"
CARDS = ROOT / "src" / "data" / "cards.json"
SCRIPTS = ROOT / "public" / "CCG Downloads" / "CCG_Scripts"
OUTPUT = ROOT / "scripts" / "output" / "effect_audit_agents" / "batch_local_adversarial_custom_gaps_444_555.json"
ORDINALS = (444, 447, 448, 449, 454, 458, 459, 464, 537, 539, 540)


def sha256(data: bytes) -> str:
    return hashlib.sha256(data).hexdigest()


def ref(card_id: int, name: str, structure: str) -> dict:
    return {
        "script": f"tmp/omega_scripts/c{card_id}.lua",
        "card_id": card_id,
        "card_name": name,
        "matched_structure": structure,
    }


def effect(card: dict, index: int) -> dict:
    return next(item for item in card["effects"] if int(item["effect_index"]) == index)


def main() -> int:
    report = json.loads(REPORT.read_text(encoding="utf-8"))
    source = {int(card["ordinal"]): card for card in report["cards"]}
    card_data = json.loads(CARDS.read_text(encoding="utf-8"))
    records = []

    for ordinal in ORDINALS:
        record = {
            key: value
            for key, value in source[ordinal].items()
            if key not in {
                "lua_effect_creations", "conservative_printed_clause_floor",
                "heuristic_printed_clause_floor", "source_batch", "_batch_file",
            }
        }
        current = card_data[ordinal - 1]
        script = SCRIPTS / f"c{current['passcode']}.lua"
        record["text_sha256"] = sha256(str(current.get("text") or "").encode("utf-8"))
        record["script_sha256"] = sha256(script.read_bytes())
        record["supersedes_batch"] = source[ordinal].get("source_batch")
        record["reconciliation_note"] = (
            "Adversarial completion audit against current text/Lua, Omega procedure helpers and constants, "
            "official scripts, and the official Omega database. Historical checklist claims were not used."
        )
        records.append(record)

    by_ordinal = {int(record["ordinal"]): record for record in records}

    comet = effect(by_ordinal[444], 1)
    comet.update({
        "lua_implementation": (
            "The hand Quick Effect selects a different Stardust monster in the Deck and moves it with "
            "Duel.SendtoGrave using REASON_COST+REASON_RELEASE, then Special Summons this card from the hand. "
            "REASON_RELEASE preserves the observable Tribute reason even though Deck cards are outside the "
            "ordinary Duel.GetReleaseGroup/IsReleasable zone."
        ),
        "official_references": [
            ref(66646087, "Red Familiar", "Official script selects a monster from the Deck and sends it to the GY as an activation cost."),
            ref(19891131, "Crusadia Krawler", "Official script uses REASON_COST+REASON_RELEASE for a Tribute/release cost and exposes the release reason to later checks."),
        ],
        "verdict": "FIXED",
        "issue": (
            "Confirmed implementation defect fixed: IsReleasable/Duel.Release cannot represent a Deck-zone "
            "Tribute. The supported Deck movement now carries both COST and RELEASE reason bits."
        ),
        "required_resolution": "None; retain the REASON_COST+REASON_RELEASE Deck movement and regression-test release-trigger interactions.",
    })

    station3 = effect(by_ordinal[454], 3)
    station3.update({
        "lua_implementation": (
            "A field continuous EVENT_CHAINING effect now recognizes every current qualifying Galactica "
            "Damage Step monster effect through aux.CCGGalacticaSummonEffects, with a concrete operation-info "
            "group fallback. On consent it saves re:GetOperation(), calls Duel.ChangeChainOperation, runs the "
            "original operation, and appends the destruction inside that same resolving Chain Link. A player "
            "flag counts only accepted additions and caps them at two per turn."
        ),
        "official_references": [
            ref(39552584, "Grapha, Dragon Overlord of Dark World", "Official script changes a currently activating effect through EVENT_CHAINING and Duel.ChangeChainOperation."),
            ref(1082946, "Dark Deal", "Official script retrieves another effect's operation callback with Effect.GetOperation and executes it with the original callback arguments."),
        ],
        "verdict": "FIXED",
        "issue": (
            "The prior EVENT_CHAIN_SOLVED action was a separate post-resolution event and its concrete-group "
            "test missed current non-targeting Galactica summons. The operation is now augmented in-chain and "
            "all current qualifying effects are explicitly registered."
        ),
        "required_resolution": (
            "None for the current CCG pool. Future Damage Step monster effects that Summon a Galactica monster "
            "must register their Effect object in aux.CCGGalacticaSummonEffects unless they publish a concrete "
            "Galactica group through Duel.SetOperationInfo."
        ),
    })
    station4 = effect(by_ordinal[454], 4)
    station4.update({
        "lua_implementation": (
            "The replacement operation first invokes the saved original monster-effect operation, then selects "
            "and destroys exactly 1 destructible card on the field with REASON_EFFECT before that Chain Link finishes."
        ),
        "official_references": [
            ref(39552584, "Grapha, Dragon Overlord of Dark World", "Official Duel.ChangeChainOperation callback establishes same-Chain-Link operation replacement semantics."),
            ref(1082946, "Dark Deal", "Official Effect.GetOperation callback forwarding supports preserving the original operation before the appended action."),
        ],
        "verdict": "FIXED",
        "issue": "The destruction is no longer delayed until EVENT_CHAIN_SOLVED; it is appended after the original operation in the modified Chain Link.",
        "required_resolution": "None.",
    })

    mage = effect(by_ordinal[537], 1)
    mage.update({
        "lua_implementation": (
            "The Pendulum Zone now registers an EFFECT_SPSUMMON_PROC_G procedure with SUMMON_TYPE_RITUAL. "
            "Its condition is available only while the normal Pendulum Summon opportunity is unused and the "
            "other Pendulum Zone holds a Cyberse Pendulum Monster. It selects any legal in-scale Cyberse Ritual "
            "group from hand/face-up Extra Deck, validates every chosen controlled Cyberse material against every "
            "Ritual Monster, releases materials, marks aux.PendulumChecklist as consumed, merges the Ritual group "
            "into the procedure summon group, and completes their summon procedures on success."
        ),
        "official_references": [
            ref(31531170, "Harmonic Oscillation", "Official custom EFFECT_SPSUMMON_PROC_G implements an alternate Pendulum Summon procedure and consumes aux.PendulumChecklist."),
            ref(5088741, "Code Igniter", "Official script validates greater-or-equal Ritual material Levels, releases Ritual Materials, uses SUMMON_TYPE_RITUAL, and completes the procedure."),
            ref(55795155, "Pendulum Evolution", "Official script demonstrates Pendulum opportunity tracking and group summon handling around aux.PendulumChecklist."),
        ],
        "verdict": "FIXED",
        "issue": (
            "The previous independent Ignition Effect did not replace or consume a Pendulum Summon. Omega's "
            "official group summon procedure hook supports the printed replacement, and the Lua now uses it."
        ),
        "required_resolution": "None; runtime-regression-test multi-Ritual selection, Extra Deck zones, and material restrictions.",
    })
    by_ordinal[537]["coverage_override"]["reason"] = (
        "Four independent printed units: the Pendulum-to-Ritual group summon replacement, named Ritual permission, "
        "hand reveal/search effect, and Special-Summon-triggered Ritual effect. The helper completion listener is "
        "part of the first procedure, not a fifth printed effect."
    )

    corruption = effect(by_ordinal[539], 2)
    corruption.update({
        "lua_implementation": (
            "The current Lua can spend counters only inside this card's own triggered Ritual operation. "
            "EFFECT_EXTRA_RITUAL_MATERIAL contributes actual Card objects; it cannot contribute a scalar Level "
            "amount or remove counters for every unrelated Ritual procedure."
        ),
        "verdict": "CUSTOM_GAP",
        "issue": (
            "Genuine engine limitation: Omega has no card-local, generic hook that adds a counter-derived scalar "
            "to all Cyberse Ritual Summon material checks and atomically removes the chosen counters. Monkey-patching "
            "shared Ritual helpers would miss bespoke Ritual scripts and affect unrelated cards globally."
        ),
        "required_resolution": (
            "Add a core/shared Ritual API such as EFFECT_EXTRA_RITUAL_LEVEL whose value callback returns the maximum "
            "counter Level contribution and whose consume callback removes the selected counters, and update every "
            "Ritual procedure path to honor it. Alternatively rewrite the card so counters apply only to this card's "
            "own bullet Ritual Summon, which the current Lua already supports."
        ),
    })

    hexatron = effect(by_ordinal[540], 1)
    hexatron.update({
        "verdict": "CUSTOM_GAP",
        "issue": (
            "Genuine source-text ambiguity: this Link-3 monster has no printed Link Material line. The current "
            "2-3 Cyberse implementation is executable, but text, helpers, official scripts, and DB contain no "
            "evidence that distinguishes it from exactly 3 Cyberse, 2+ Effect Monsters, or an archetype requirement."
        ),
        "required_resolution": (
            "Authoritatively add the intended material line to cards.json/card assets, then make aux.AddLinkProcedure "
            "match it and regenerate this hash-pinned audit. No engine change is required."
        ),
    })

    for ordinal in (447, 448, 449, 458, 459, 464):
        by_ordinal[ordinal]["reconciliation_note"] += (
            " This script's qualifying Damage Step summon Effect object is now registered for Galactican Battle "
            "Station; the printed behavior of this card is otherwise unchanged."
        )

    for record in records:
        verdicts = Counter(item["verdict"] for item in record["effects"])
        if verdicts["DEFECT"]:
            overall = "DEFECT"
        elif verdicts["CUSTOM_GAP"]:
            overall = "CUSTOM_GAP"
        elif verdicts["FIXED"]:
            overall = "FIXED"
        else:
            overall = "PASS"
        record["overall_verdict"] = overall

    totals = Counter(item["verdict"] for record in records for item in record["effects"])
    payload = {
        "schema_version": 1,
        "batch": "local-adversarial-custom-gaps-444-555",
        "ordinal_start": 444,
        "ordinal_end": 555,
        "cards": records,
        "summary": {
            "cards": len(records),
            "effects": sum(len(record["effects"]) for record in records),
            "pass": totals["PASS"],
            "fixed": totals["FIXED"],
            "defects": totals["DEFECT"],
            "custom_gaps": totals["CUSTOM_GAP"],
        },
    }
    OUTPUT.write_text(json.dumps(payload, ensure_ascii=False, indent=2) + "\n", encoding="utf-8")
    return 0


if __name__ == "__main__":
    raise SystemExit(main())

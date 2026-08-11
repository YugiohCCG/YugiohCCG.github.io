#!/usr/bin/env python3
"""Write the independently reconciled local overrides for batch 2 ordinals 73-121."""

from __future__ import annotations

import hashlib
import json
from copy import deepcopy
from pathlib import Path


ROOT = Path(__file__).resolve().parents[1]
CARDS = json.loads((ROOT / "src/data/cards.json").read_text(encoding="utf-8"))
BATCH_DIR = ROOT / "scripts/output/effect_audit_agents"
BATCH = json.loads((BATCH_DIR / "batch_2_73_144.json").read_text(encoding="utf-8"))
SCRIPTS = ROOT / "public/CCG Downloads/CCG_Scripts"
ORDINALS = (79, 80, 87, 100, 103, 104, 110, 111, 113, 115, 116, 120, 121)


def sha256(data: bytes) -> str:
    return hashlib.sha256(data).hexdigest()


def effect(record: dict, index: int) -> dict:
    return next(item for item in record["effects"] if item["effect_index"] == index)


def set_result(
    record: dict,
    index: int,
    verdict: str,
    implementation: str,
    issue: str | None,
) -> None:
    item = effect(record, index)
    item["verdict"] = verdict
    item["lua_implementation"] = implementation
    item["issue"] = issue


def main() -> None:
    source = {item["ordinal"]: item for item in BATCH["cards"]}
    records = {ordinal: deepcopy(source[ordinal]) for ordinal in ORDINALS}

    set_result(
        records[79], 2, "FIXED",
        "The uncopyable single effects now combine the conditional Special Summon prohibition with EFFECT_CANNOT_FLIP_SUMMON, whose condition checks for another controlled monster.",
        "Confirmed and corrected: the Fusion previously prohibited only Special Summons, so a face-down copy could be Flip Summoned while its controller had another monster.",
    )
    set_result(
        records[80], 2, "FIXED",
        "The uncopyable single effects now combine the conditional Special Summon prohibition with EFFECT_CANNOT_FLIP_SUMMON, whose condition checks for another controlled monster.",
        "Confirmed and corrected: the unqualified Summon restriction also prohibits a Flip Summon while another monster is controlled.",
    )
    set_result(
        records[87], 2, "CUSTOM_GAP",
        "The alternate Level/non-Tuner values are consumed by the three CCG Ursarctic procedures that explicitly call Hextanius-aware helpers; the card cannot inject those choices into unrelated official Extra Deck procedures.",
        "Confirmed as an engine/procedure integration gap, not safely patchable in this card alone: official Ursarctic Synchros implement their own EFFECT_SPSUMMON_PROC and expose no card-local hook through which Hextanius can supply two alternate Levels and a non-Tuner role.",
    )
    set_result(
        records[100], 3, "CUSTOM_GAP",
        "The five currently eligible Main Deck Stain summon effects are manually mirrored; no dynamic monster-trigger object is invoked from the sent card.",
        "Confirmed as a custom-engine gap: CheckActivateEffect supports activatable Spell/Trap effects, but there is no official generic API that safely rebinds an arbitrary monster's Normal/Special Summon trigger, targets, metadata, and operation to this Spell's resolution.",
    )
    set_result(
        records[103], 2, "FIXED",
        "The uncopyable single effects now combine the conditional Special Summon prohibition with EFFECT_CANNOT_FLIP_SUMMON, whose condition checks for another controlled monster.",
        "Confirmed and corrected: a face-down copy previously remained Flip Summonable while another monster was controlled.",
    )
    set_result(
        records[103], 4, "FIXED",
        "Before turning the legal face-up monsters face-down, the operation separates their original Attack- and Defense-Position groups. At the End Phase it restores each surviving affected monster to its corresponding original face-up position.",
        "Confirmed and corrected: the prior End Phase operation returned every surviving monster in face-up Defense Position and lost original Attack Position.",
    )
    set_result(
        records[104], 2, "FIXED",
        "The uncopyable single effects now combine the conditional Special Summon prohibition with EFFECT_CANNOT_FLIP_SUMMON, whose condition checks for another controlled monster.",
        "Confirmed and corrected: the unqualified Summon restriction was missing its Flip Summon prohibition.",
    )
    set_result(
        records[110], 4, "PASS",
        "EVENT_TO_GRAVE requires prior Spell/Trap Zone location, REASON_LOST_TARGET, and the previous equip target now being in the hand. This is the official engine representation used by Sword of Kusanagi when an Equip is lost because its Spirit target returned.",
        None,
    )
    set_result(
        records[111], 2, "CUSTOM_GAP",
        "The selected face-up Spirit receives EFFECT_CANNOT_TO_HAND through the End Phase; this enforces the destination but the core prohibition is reason-agnostic.",
        "Confirmed as an engine granularity gap: EFFECT_CANNOT_TO_HAND also prevents returning the card as a cost, while the text says only 'by card effect'. The standard API supplies no reason parameter or effect-only destination-prohibition code that can express the narrower rule exactly.",
    )
    set_result(
        records[113], 2, "CUSTOM_GAP",
        "The Special Summon trigger installs End-Phase-only CANNOT_TO_HAND/CANNOT_TO_DECK effects for other face-up Spirit monsters; those destination effects also apply to costs and non-effect movement.",
        "Confirmed as an engine granularity gap: the standard destination prohibitions cannot be limited to REASON_EFFECT. EFFECT_SPIRIT_DONOT_RETURN covers built-in Spirit returns but would under-implement arbitrary card effects named by this text.",
    )
    set_result(
        records[115], 3, "FIXED",
        "The target is used only as activation information. Resolution now checks the handler, Necrovalley, and zone availability directly, so the self-Special-Summon does not depend on the informational target remaining related or retaining its archetype.",
        "Confirmed and corrected: the previous operation incorrectly aborted if the targeted Grand Blue card left its location or ceased to satisfy the archetype filter.",
    )
    set_result(
        records[116], 3, "CUSTOM_GAP",
        "Four material prohibitions prevent non-Grand-Blue cards from being used as Fusion, Synchro, Xyz, or Link Material for the rest of the turn, but materialless Extra Deck procedures are not represented by those hooks.",
        "Confirmed as an engine/procedure gap: the generic Special Summon restriction callback does not expose a prospective material group. Official Heraldic Beast Gryphon uses additional Xyz-only workaround state and is itself marked not fully implemented; there is no general equivalent covering all Extra Deck summon procedures.",
    )
    set_result(
        records[120], 1, "PASS",
        "The card registers unconditional EFFECT_ADD_CODE for Umi. The official Omega database also stores A Legendary Ocean with alias 0 and its official script contains no add-code effect, so a nonzero datas.alias is not an Omega requirement for this printed identity clause.",
        None,
    )
    set_result(
        records[121], 4, "FIXED",
        "Resolution now attempts the Grand Blue Special Summon independently. Only after that summon succeeds does it recheck the targeted monster and send it to the GY if it remains related and sendable.",
        "Confirmed and corrected: the old pre-resolution target guard incorrectly prevented the first action when only the later 'and if you do' target had disappeared.",
    )

    notes = {
        79: "Confirmed and fixed the missing Flip Summon prohibition.",
        80: "Confirmed and fixed the missing Flip Summon prohibition.",
        87: "Confirmed an unresolved cross-script Ursarctic procedure gap; no unsafe card-local workaround was added.",
        100: "Confirmed the existing dynamic summon-effect-copy limitation; the current five eligible Main Deck effects remain explicitly mirrored.",
        103: "Confirmed and fixed both the missing Flip Summon prohibition and original-position restoration.",
        104: "Confirmed and fixed the missing Flip Summon prohibition.",
        110: "Rejected the requested REASON_DESTROY check: official Sword of Kusanagi uses REASON_LOST_TARGET for this exact Equip-loss event.",
        111: "Confirmed an unresolved reason-filtering limitation in destination prohibitions.",
        113: "Confirmed an unresolved reason-filtering limitation in destination prohibitions.",
        115: "Confirmed and removed an improper resolution dependency on an informational target.",
        116: "Confirmed an unresolved generic materialless Extra Deck summon gap.",
        120: "Rejected the alias finding because the official Omega database uses alias 0 for A Legendary Ocean as well.",
        121: "Confirmed and fixed incorrect conjunction/target resolution ordering.",
    }

    for ordinal, record in records.items():
        card = CARDS[ordinal - 1]
        script_path = SCRIPTS / f"c{card['passcode']}.lua"
        record["text_sha256"] = sha256(str(card.get("text") or "").encode("utf-8"))
        record["script_sha256"] = sha256(script_path.read_bytes())
        verdicts = {item["verdict"] for item in record["effects"]}
        record["overall_verdict"] = (
            "FIXED" if "FIXED" in verdicts else
            "DEFECT" if "DEFECT" in verdicts else
            "CUSTOM_GAP" if "CUSTOM_GAP" in verdicts else
            "PASS"
        )
        record["audit_note"] = notes[ordinal]
        record["coverage_override"] = {
            "expected_individual_effects": len(record["effects"]),
            "reason": "The audit records split this card into its material/procedure, restrictions, activated or continuous operations, and printed count-limit clauses; no printed functional clause is omitted.",
        }
        counts = {key: 0 for key in ("PASS", "FIXED", "DEFECT", "CUSTOM_GAP")}
        for item in record["effects"]:
            counts[item["verdict"]] += 1
        payload = {
            "schema_version": 1,
            "batch": "local-reconciliation-batch2-73-121",
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
        path = BATCH_DIR / f"batch_local_{ordinal}_{ordinal}.json"
        path.write_text(json.dumps(payload, indent=2, ensure_ascii=False) + "\n", encoding="utf-8")
        print(path.relative_to(ROOT))


if __name__ == "__main__":
    main()

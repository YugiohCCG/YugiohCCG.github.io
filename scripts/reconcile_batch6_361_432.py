#!/usr/bin/env python3
"""Generate fresh local reconciliations for the non-PASS findings in batch 6.

The records are rebuilt from the current card text and canonical Lua.  The
batch's effect segmentation and official Omega references are retained, while
every reported finding is replaced by the independently reconciled result.
"""

from __future__ import annotations

import hashlib
import json
from collections import Counter
from pathlib import Path


ROOT = Path(__file__).resolve().parents[1]
BATCH = ROOT / "scripts" / "output" / "effect_audit_agents" / "batch_6_361_432.json"
BATCH7 = ROOT / "scripts" / "output" / "effect_audit_agents" / "batch_7_433_504.json"
OUT = ROOT / "scripts" / "output" / "effect_audit_agents"
CARDS = ROOT / "src" / "data" / "cards.json"
LUA = ROOT / "public" / "CCG Downloads" / "CCG_Scripts"

ORDINALS = (
    362, 373, 374, 383, 384, 394, 395, 396, 399, 401, 402,
    403, 404, 405, 416, 424, 426, 428, 430, 431, 432, 433,
)

# verdict, current implementation, reconciliation rationale
DECISIONS = {
    (362, 1): (
        "PASS",
        "The selected Bauy World is moved face-up to the Field Zone, its activation count and cost are consumed, and custom activation event 4179255 is raised exactly as in Omega's direct-Field-Spell activation scripts.",
        "Rejected: official Generaider Boss Fight, Demise of the Land, and Metaverse do not manually invoke the moved Field Spell's target or operation either. The current Lua follows Omega's exact direct-activation protocol.",
    ),
    (373, 4): (
        "CUSTOM_GAP",
        "After banishing the corresponding Myutant monster, the handler uses CopyEffect with a standard state-change reset, granting that card's copyable effects rather than replacing and executing only this resolving effect.",
        "Unresolved text/engine gap: the printed instruction asks an already-resolving ignition effect to become an arbitrary monster's original effect, but supplies no cost, target, event, or choice of effect. Omega has duration-based full-card copying and activation-effect substitution, but no exact operation for this wording.",
    ),
    (374, 3): (
        "FIXED",
        "After Castle of Dark Illusions is added, it receives EFFECT_ADD_EXTRA_TRIBUTE through the End Phase with LOCATION_HAND as the additional Tribute pool and a releasable-monster filter.",
        "Confirmed and corrected: the hand-Tribute permission was absent. Official Master Peace establishes EFFECT_ADD_EXTRA_TRIBUTE and its target-range/filter structure; the effect is attached only to the searched Castle.",
    ),
    (383, 1): (
        "FIXED",
        "The optional Normal/Special Summon trigger now uses TRIGGER_O, and both target and operation count two counters only when another face-up Skewy monster is controlled.",
        "Confirmed and corrected: face-down monsters cannot satisfy the public archetype condition. The fresh review also corrected the unprinted mandatory trigger type.",
    ),
    (383, 2): (
        "FIXED",
        "The continuous activation lock is enabled only while the controller has a face-up Skewy monster, and applies to opposing monsters carrying Candy Counters.",
        "Confirmed and corrected: the prior Card.IsSetCard-only condition allowed a face-down monster to establish an archetype-qualified condition.",
    ),
    (383, 3): (
        "FIXED",
        "The cloned 300 ATK-loss effect shares the corrected face-up Skewy enabling condition and still applies only to opposing monsters with Candy Counters.",
        "Confirmed and corrected with the shared condition used by the activation lock.",
    ),
    (384, 1): (
        "FIXED",
        "The inherent hand Special Summon procedure now has hard once-per-turn key id while retaining the opponent-more-monsters condition and free Monster Zone check.",
        "Confirmed and corrected: official Dinowrestler Pankratops demonstrates SetCountLimit on this exact inherent summon procedure shape.",
    ),
    (384, 4): (
        "FIXED",
        "The summon procedure, summon-trigger effect, and GY trigger now use distinct hard once-per-turn keys id, id+100, and id+200; event clones still share the one key for the same effect.",
        "Confirmed and corrected: 'each effect' includes the printed summon procedure but does not make separate printed effects share one usage key.",
    ),
    (394, 3): (
        "FIXED",
        "The Spell & Trap Zone branch now requires both original Monster Card type and Zombie Race; the GY/banishment branch remains restricted to face-up-accessible Crewal cards.",
        "Confirmed and corrected: the printed Zombie qualifier applies to the Spell & Trap Zone alternative.",
    ),
    (395, 2): (
        "PASS",
        "At activation, the cost callback performs the pre-semicolon placement action and the target callback then selects the opposing monster; resolution moves that target if it remains related.",
        "Rejected: the exact text places both 'place ... then target ...' after the colon and before the semicolon. They are activation procedures, and Omega encodes non-target activation actions in the cost callback before target selection.",
    ),
    (396, 3): (
        "FIXED",
        "The targeted Zombie is moved face-up from the GY to the Spell & Trap Zone without adding any Spell or Trap type-changing effect.",
        "Confirmed and corrected: unlike adjacent Crewal clauses, this exact clause does not say 'as a Continuous Trap'. Official Crystal Beast placement establishes MoveToField as the placement primitive and adds type only when the text does.",
    ),
    (399, 2): (
        "FIXED",
        "The Set and Ghostrick Special Summon trigger clones no longer carry an unprinted hard once-per-turn; each eligible copy may trigger as written.",
        "Confirmed and corrected: no once-per-turn restriction appears on this effect.",
    ),
    (399, 3): (
        "FIXED",
        "The flip trigger announces Level 1 through 4 and targets any number of face-up Level-bearing Ghostrick monsters without an unprinted hard once-per-turn.",
        "Confirmed and corrected: the printed flip effect has no count limit.",
    ),
    (401, 3): (
        "FIXED",
        "The GY chain trigger Sets this card and grants the leave-field banish redirect without an unprinted hard once-per-turn.",
        "Confirmed and corrected: multiple copies may each respond because the exact clause has no count limit.",
    ),
    (402, 3): (
        "FIXED",
        "The delayed GY trigger can target up to two eligible Ghostrick cards and attach them to a controlled Ghostrick Xyz Monster without an unprinted hard once-per-turn.",
        "Confirmed and corrected: the printed sent-to-GY effect has no count limit.",
    ),
    (403, 4): (
        "CUSTOM_GAP",
        "The implementation restricts the other controlled Ghostrick target to a face-up Xyz Monster, transfers this card's materials, then overlays this card onto it.",
        "Unresolved source/engine gap: Omega only permits Xyz Monsters to hold materials, while the exact text permits any other Ghostrick monster. Bird Sanctuary confirms the attach/transfer structure but explicitly names an Xyz target.",
    ),
    (404, 4): (
        "CUSTOM_GAP",
        "After attaching a Deck card, the implementation chooses an already-controlled Rank 3 or lower Ghostrick Xyz Monster, transfers Oni's materials, and overlays Oni onto it as the closest executable approximation.",
        "Unresolved source-text gap: an already-controlled monster cannot be Xyz Summoned. The instruction is internally impossible as written, so there is no correct Omega Xyz Summon operation to substitute for the approximation.",
    ),
    (404, 5): (
        "CUSTOM_GAP",
        "The selected Xyz Monster is recorded for the turn, but the Lua cannot rewrite all of its arbitrary ignition and trigger registrations into Quick Effects.",
        "Unresolved engine gap: Omega has no generic API that converts every arbitrary effect registered on a selected monster into a Quick Effect for a temporary duration.",
    ),
    (405, 4): (
        "FIXED",
        "The sent-to-GY trigger targets and Sets one eligible Ghostrick card from the GY without an unprinted hard once-per-turn.",
        "Confirmed and corrected: the exact clause contains no count limit.",
    ),
    (416, 1): (
        "FIXED",
        "The Chain Link 3-or-higher condition now treats every controlled monster that is not currently DARK—including a face-down monster—as disqualifying, while separately requiring a face-up Scarstech monster.",
        "Confirmed and corrected: a face-down monster cannot prove the 'only DARK monsters' condition because it has no public/current DARK Attribute.",
    ),
    (424, 5): (
        "FIXED",
        "The Spell & Trap Zone extra-material value now accepts only Gravinity Lapsix or Gravinity Galaxix as the destination Synchro Monster.",
        "Confirmed and corrected: those are the only destination monsters whose exact text grants use of Gravinity Monster Cards from the Spell & Trap Zone.",
    ),
    (426, 5): (
        "FIXED",
        "The extra Synchro material helper now returns true only for destination code Gravinity Lapsix or Gravinity Galaxix.",
        "Confirmed and corrected: Nebulix and Spherix print no Spell & Trap Zone material permission.",
    ),
    (428, 5): (
        "FIXED",
        "The extra Synchro material helper now returns true only for destination code Gravinity Lapsix or Gravinity Galaxix.",
        "Confirmed and corrected: the former archetype-wide predicate silently granted permission to unrelated Gravinity Synchros.",
    ),
    (430, 3): (
        "FIXED",
        "LIGHT- and DARK-material flags now reset with RESET_EVENT+RESETS_STANDARD; the Quick Effect snapshots them into its label before sending Chaos Honest to the GY as cost.",
        "Confirmed and corrected: official material-derived Link effects and flags reset when the Link-Summoned object undergoes a standard state change.",
    ),
    (431, 5): (
        "FIXED",
        "The extra Synchro material helper now permits only Gravinity Lapsix and Gravinity Galaxix as destination monsters.",
        "Confirmed and corrected: the old all-Gravinity-Synchro predicate over-permitted Nebulix and Spherix.",
    ),
    (432, 2): (
        "FIXED",
        "Lapsix's distributed extra-material value now accepts only Lapsix and Galaxix as destination Synchro Monsters, matching the two cards that print this permission.",
        "Confirmed and corrected: EFFECT_EXTRA_SYNCHRO_MATERIAL is evaluated on the material with the destination Synchro card, so the predicate must encode the granting destination text precisely.",
    ),
    (433, 2): (
        "FIXED",
        "Galaxix's Spell & Trap Zone material helper now accepts only Lapsix or Galaxix as the destination Synchro Monster. Registered on Galaxix itself, it allows a Galaxix already in the Spell & Trap Zone to serve as material; the other eligible materials provide the same helper from their own scripts.",
        "Collateral correction required by the batch-6 Gravinity fix: the batch-7 report incorrectly assumed this effect had to be registered on the Extra Deck destination. Omega's EFFECT_EXTRA_SYNCHRO_MATERIAL is registered on each extra-location material and receives the destination Synchro Monster in its value predicate.",
    ),
}

REFERENCE_OVERRIDES = {
    (433, 2): [
        {
            "script": "tmp/omega_scripts/c14507213.lua",
            "card_id": 14507213,
            "card_name": "Synchro Material",
            "matched_structure": "Official Omega registers EFFECT_EXTRA_SYNCHRO_MATERIAL on the additional material card and evaluates a value function against the destination Synchro Monster.",
        },
        {
            "script": "tmp/omega_scripts/c97682931.lua",
            "card_id": 97682931,
            "card_name": "Revolution Synchron",
            "matched_structure": "Official Omega registers an extra-location Synchro material effect on the material itself and restricts eligible destination Synchro Monsters in matval.",
        },
    ],
}

COVERAGE = {
    362: "Four records cover the activation alternative, conditional negate/banish continuation, banished self-Set/redirect trigger, and per-effect HOPT.",
    373: "Five records cover Fusion materials, summon Set trigger, reveal/send/banish operation, copied-effect clause, and per-effect HOPT.",
    374: "Four records cover self-Summon/search, extra Normal Summon, hand-Tribute permission, and the shared named HOPT.",
    383: "Five records cover summon counters, Candy-Counter activation lock, ATK loss, counter-removal choice effect, and per-effect HOPT.",
    384: "Four records cover the hand summon procedure, summon top-card effect, GY counter trigger, and the per-effect HOPT rule.",
    394: "Four records cover activation mill, summon oath, SZONE/GY/banishment summon trigger, and per-effect HOPT.",
    395: "Four records cover Main Phase summon, activation placement/target procedure, opposing placement resolution, and per-effect HOPT.",
    396: "Seven records cover materials, alternate Xyz procedure, GY placement, ATK gain, two targeting protections, opponent-turn summon, and HOPT as segmented in the audit.",
    399: "Four records cover Ghostrick summon/set rule, hand summon trigger, flip Level change, and granted Xyz-material effect.",
    401: "Three records cover position/return effect, required other Ghostrick condition, and GY self-Set/redirect trigger.",
    402: "Three records cover Xyz materials, detach/search ignition effect, and sent-to-GY attach trigger.",
    403: "Four records cover materials, alternate Xyz procedure, Set-card control effect, and self/material transfer effect.",
    404: "Six records cover materials, DEF gain, Deck attach, immediate Xyz instruction, Quick-Effect conversion, and GY ATK-loss trigger.",
    405: "Four records cover materials, detach/Set effect, Quick flip effect, and GY Set trigger.",
    416: "Three records cover Chain-3 self-Summon, Chain-3 Link Summon trigger, and per-effect HOPT.",
    424: "Five records cover hand placement, search choice, column movement choice, per-effect HOPT, and destination-scoped extra-material support.",
    426: "Five records cover hand placement, Deck placement choice, column movement choice, per-effect HOPT, and destination-scoped extra-material support.",
    428: "Five records cover hand placement, Spell/Trap search choice, column movement choice, per-effect HOPT, and destination-scoped extra-material support.",
    430: "Five records cover Link materials, added DARK Attribute, material-dependent sequence, LIGHT branch, and DARK branch.",
    431: "Five records cover hand placement, Deck Set choice, column movement choice, per-effect HOPT, and destination-scoped extra-material support.",
    432: "Five records cover Synchro materials, SZONE material permission, summon recovery choice, trap draw/summon effect, and per-effect HOPT.",
    433: "Six records cover Synchro materials, SZONE material permission, summon Set recovery, same-turn activation, trap draw/summon effect, and per-effect HOPT.",
}


def digest(data: bytes) -> str:
    return hashlib.sha256(data).hexdigest()


def main() -> None:
    source = json.loads(BATCH.read_text(encoding="utf-8"))
    source7 = json.loads(BATCH7.read_text(encoding="utf-8"))
    cards = json.loads(CARDS.read_text(encoding="utf-8"))
    source_records = {
        int(card["ordinal"]): card
        for card in source["cards"] + source7["cards"]
    }

    for ordinal in ORDINALS:
        record = json.loads(json.dumps(source_records[ordinal]))
        card = cards[ordinal - 1]
        passcode = int(card["passcode"])
        record["passcode"] = passcode
        record["name"] = card["name"]
        record["text_sha256"] = digest(str(card.get("text") or "").encode("utf-8"))
        record["script_sha256"] = digest((LUA / f"c{passcode}.lua").read_bytes())

        for effect in record["effects"]:
            key = (ordinal, int(effect["effect_index"]))
            if key in DECISIONS:
                verdict, implementation, issue = DECISIONS[key]
                effect["verdict"] = verdict
                effect["lua_implementation"] = implementation
                effect["issue"] = issue
            if key in REFERENCE_OVERRIDES:
                effect["official_references"] = REFERENCE_OVERRIDES[key]

        verdicts = {effect["verdict"] for effect in record["effects"]}
        record["overall_verdict"] = (
            "CUSTOM_GAP" if "CUSTOM_GAP" in verdicts
            else "FIXED" if "FIXED" in verdicts
            else "DEFECT" if "DEFECT" in verdicts
            else "PASS"
        )
        record["coverage_override"] = {
            "expected_individual_effects": len(record["effects"]),
            "reason": COVERAGE[ordinal],
        }

        counts = Counter(effect["verdict"].lower() for effect in record["effects"])
        payload = {
            "schema_version": 1,
            "batch": "local-reconciliation-batch6-plus-gravinity-collateral",
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

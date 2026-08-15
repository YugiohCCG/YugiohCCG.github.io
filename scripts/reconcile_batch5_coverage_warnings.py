#!/usr/bin/env python3
"""Write reviewed, hash-pinned overrides for batch-5 coverage warnings."""

from __future__ import annotations

import hashlib
import json
from collections import Counter
from pathlib import Path


ROOT = Path(__file__).resolve().parents[1]
BATCH = ROOT / "scripts" / "output" / "effect_audit_agents" / "batch_5_289_360.json"
OUT = ROOT / "scripts" / "output" / "effect_audit_agents"
CARDS = ROOT / "src" / "data" / "cards.json"
LUA = ROOT / "public" / "CCG Downloads" / "CCG_Scripts"

# Each entry was manually compared against the full printed text, current Lua,
# existing effect records, and the cited official Omega scripts/database rows.
# Existing local reconciliations in this range are intentionally not replaced.
COVERAGE_REASONS = {
    289: "The Fusion material procedure is one audit unit. The Main-Phase Quick Effect, banish cost, destruction, dynamic per-turn ceiling, and Glaucus-dependent chain limit are one compound activated effect, fully covered by record 2.",
    290: "The Fusion material procedure and the two activated effects are the three distinct units. Each activated record includes its resolution sequence and its own printed usage limit.",
    291: "The Fusion materials plus Fusion-only Summon condition form one procedure unit, the conditional immunity is one continuous effect, and the damage Quick Effect includes its cost and dynamic usage ceiling.",
    292: "The hand response, self-Summon, conditional opponent banish prohibition, and first HOPT form one compound effect; the field-to-GY search and second HOPT form the other effect.",
    298: "The reveal/two-monster Summon procedure, all-turn Ohmen lock, and first HOPT are one activated effect; the Link-material trigger, Current Counter operation, and second HOPT are the other.",
    306: "The two printed bullets are mutually exclusive branches of one activation effect and are fully covered together. The shared activation HOPT and Thunder-only Summon oath are covered by record 2.",
    308: "The self-Summon trigger includes both source locations, the GY leave-field redirect, and its HOPT. The Normal/Special Summon search and its separate HOPT are the second effect.",
    310: "The Synchro material line is one procedure unit. The revival trigger and the Tribute/negate/Trap-recovery Quick Effect are the two activated units, each including its HOPT.",
    314: "The card/effect-activation and attack-announcement cases are alternate activation events for one Trap effect; destruction, optional follow-up destruction, and the activation HOPT are all represented in record 1.",
    316: "The attack trigger, two simultaneous Special Summons, conditional attack negate, and HOPT are one compound activated effect; Level 1 battle indestructibility is the second effect.",
    320: "The GY Special Summon procedure includes its FIRE Dragon condition and once-per-turn procedure limit. The hand cost/search/HOPT and FIRE Dragon battle protection are the other two distinct effects.",
    326: "The damage trigger includes the self-Summon and turn-long reverse-damage follow-up. The GY banish/target/LP-gain effect is the second unit, and the shared choose-one-effect limit is represented in both records.",
    327: "The hand negate effect includes its send cost, conditional destruction, and HOPT. The field/GY return effect includes its control condition, immediate Normal Summon, and separate HOPT.",
    329: "The Pendulum Attribute change, Pendulum-zone response, hand Set-then-Summon effect, and monster-zone reveal/place/Trap permission effect are the four distinct units; all three activated HOPTs are included.",
    334: "The Fusion materials and on-field name change are covered together as the card's procedure/static identity unit. The salvage, Normal-material ATK gain, and copied Spiral activation are the three activated effects, each with its HOPT.",
    336: "The discard/Deck Summon/LIGHT Spellcaster lock and the Synchro-material recovery/then-discard trigger are the two distinct compound effects, each including its HOPT.",
    337: "The Summon search plus Normal/Special Summon lock is one compound effect; the LIGHT Synchro-material GY recovery is the second, and both records include their HOPTs.",
    338: "The discard-triggered self-Summon, Main-Phase hand Summon/then-discard, and LIGHT Synchro-material Spell/Trap search/then-discard are exactly three effects; their HOPTs are included.",
    339: "The hand Quick Effect includes the discard, self-Summon, LIGHT Spellcaster lock, and HOPT. The GY Quick Effect includes its Xyz-control condition, attachment operation, and separate HOPT.",
    340: "The hand self-Summon condition and HOPT form one effect; the LIGHT Synchro-material revival trigger and its separate HOPT form the other. The heuristic double-counted conditional phrasing.",
    342: "The activation search, discard, LIGHT Spellcaster lock, and activation HOPT form one compound activation effect. The opponent non-LIGHT Summon trigger, Damage Step exclusion, target/revival, and SOPT form the second.",
    348: "The LIGHT-Tuner/non-Tuner/Arckcestial material requirement is one Synchro procedure. The other-Light targeting protection, temporary Level-change trigger, and detached-material send trigger are the three effects; both activated HOPTs are included.",
    349: "The Synchro material requirement, temporary Level-change trigger, Main-Phase revival/then-discard effect, and detached-material random hand send are four units; all three activated HOPTs are represented.",
    351: "The Xyz material requirement, Xyz-Summon search, targeted-Arckcestial GY revival response, and detached-material recovery/then-discard trigger are four units; every activated HOPT is included.",
    355: "The hand banish/search/optional-draw sequence is one effect. The banished-card Quick Summon and its turn-player-dependent optional bullet follow-up are one second effect; both records include their HOPTs.",
    357: "The restricted hand/banishment Summon procedure and the three activated effects are four units. The Main-Phase search, opponent monster-effect response, End-Phase revival, and their respective HOPTs are each fully represented.",
    358: "The Tuner-plus-Bau material line is one Synchro procedure. The Synchro-Summon Deck banish and hand/GY monster-effect negate/destroy response are the two activated effects, each including its HOPT.",
    359: "The named Synchro material requirement plus first-Synchro-Summon condition form one procedure unit. Other-Bau targeting protection, the Special-Summon banish-three/return effect, and the GY/banishment Extra-Deck return/recovery effect are the other three units.",
}


def digest(data: bytes) -> str:
    return hashlib.sha256(data).hexdigest()


def main() -> None:
    source = json.loads(BATCH.read_text(encoding="utf-8"))
    cards = json.loads(CARDS.read_text(encoding="utf-8"))
    records = {int(card["ordinal"]): card for card in source["cards"]}
    for ordinal, reason in COVERAGE_REASONS.items():
        record = json.loads(json.dumps(records[ordinal]))
        card = cards[ordinal - 1]
        passcode = int(card["passcode"])
        record["name"] = card["name"]
        record["passcode"] = passcode
        record["text_sha256"] = digest(str(card.get("text") or "").encode("utf-8"))
        record["script_sha256"] = digest((LUA / f"c{passcode}.lua").read_bytes())
        record["coverage_override"] = {
            "expected_individual_effects": len(record["effects"]),
            "reason": reason,
        }
        counts = Counter(effect["verdict"].lower() for effect in record["effects"])
        payload = {
            "schema_version": 1,
            "batch": "local-batch5-coverage-reconciliation",
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

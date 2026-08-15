#!/usr/bin/env python3
"""Write hash-pinned local records for reviewed batch-3 coverage warnings."""

from __future__ import annotations

import hashlib
import json
from collections import Counter
from pathlib import Path


ROOT = Path(__file__).resolve().parents[1]
BATCH = ROOT / "scripts" / "output" / "effect_audit_agents" / "batch_3_145_216.json"
OUT = ROOT / "scripts" / "output" / "effect_audit_agents"
CARDS = ROOT / "src" / "data" / "cards.json"
LUA = ROOT / "public" / "CCG Downloads" / "CCG_Scripts"

# Ordinals 152-156 and 158 are intentionally absent: their manually reviewed
# overrides live in the source batch. Ordinal 207 is also intentionally absent
# because its confirmed-fix local record must remain authoritative.
COVERAGE_REASONS = {
    161: "The control condition, Tribute/target procedure, mandatory group revival, five-characteristic matching rule, and HOPT all belong to one activated effect and are fully covered by effect record 1.",
    165: "The response that destroys Eldora and negates the resolving destruction effect is one effect; the destroyed-to-GY trigger, its mass destruction, optional Set follow-up, same-turn activation permission, and HOPT are one second effect.",
    167: "The three bullet points are alternative operation classes checked by one discard-to-negate hand effect, and its HOPT belongs to that same effect. Record 1 covers all alternatives and retains the documented detector DEFECT.",
    168: "The three bullet points are alternative operation classes checked by one discard-to-negate-activation hand effect, and the HOPT belongs to that same effect; record 1 covers the complete procedure.",
    169: "The hand-activation permission, negate/conditional-destroy activation, and persistent post-hand-activation Attribute lock are the three distinct audit units; the activation HOPT is covered with those linked activation semantics.",
    171: "The battle-time Spell/Trap activation lock is one continuous effect, while the reveal-or-target and same-Type Special Summon procedure plus HOPT form one activated effect.",
    174: "Hand activation under Umi, the position-changing Trap activation, and the GY banish/equip effect with its HOPT are exactly the three distinct effects.",
    175: "The Main-Phase self-Summon procedure and the on-Summon destruction trigger are the two distinct effects; the shared 'each effect' HOPT sentence is represented in both records.",
    176: "The Main-Phase self-Summon procedure and the on-Summon turn-long battle/effect protection are the two distinct effects; the shared 'each effect' HOPT sentence is represented in both records.",
    177: "The Main-Phase self-Summon procedure and the Tributed control-change trigger are the two distinct effects; the shared 'each effect' HOPT sentence is represented in both records.",
    178: "The discard/send effect and the GY banish/Ritual Summon effect are the two distinct effects; their separate HOPT limits are included in those records.",
    179: "The on-field name-and-type treatment, Normal-Summon two-card search, and opponent-effect leave-field revival/optional Token sequence are the three distinct effects; both activated HOPTs are included.",
    182: "The activation search, destruction replacement, and opponent-caused Orchis leave-field two-card search are the three distinct effects; the 'each effect' limits are included in their records.",
    188: "The Summon-triggered Tribute/shuffle effect and the Link-material destination-triggered Tribute/self-Summon effect are the two distinct effects; each record includes its HOPT.",
    189: "The Link material procedure, Link-Summon revival trigger, and Bear-Trap-enabled destruction Quick Effect are the three distinct units; both activated HOPTs are included and the custom procedure gap remains explicit.",
    190: "The activation search and activation oath limit, the once-per-turn ATK/attack-all ignition effect, and the battle-destruction GY banish trigger with its HOPT are exactly three distinct effects.",
    196: "The alternative Summon-negation/attack-negation activation events are one Trap effect sharing one activation limit, and the delayed GY Set/leave-field redirect is one second effect.",
    198: "The Normal Summon/Set prohibition is one procedure restriction and the opponent-Summon self-Summon/optional search/temporary effect lock plus HOPT is one activated effect.",
    199: "The Normal Summon/Set prohibition is one procedure restriction and the opponent-Summon self-Summon/optional GY recovery plus HOPT is one activated effect.",
    200: "The Normal Summon/Set prohibition is one procedure restriction and the opponent-Summon self-Summon/optional immediate Xyz Summon sequence is one activated effect; the text has no count limit.",
    201: "The Normal Summon/Set prohibition is one procedure restriction and the self-Summon/opponent summon/ATK-zero/conditional negate sequence plus HOPT is one compound activated effect; its existing custom-engine gap remains explicit.",
    202: "The restricted hand Special Summon procedure, alternate Xyz Level treatment, hand shuffle/search effect, and Special-Summon draw/opponent-summon effect are four distinct units; the custom opponent-summon chooser remains explicit.",
    213: "The Synchro-material Deck send and the GY banish/Link Summon procedure are the two distinct effects; both records include the shared choose-one-effect HOPT.",
    214: "The Summon-triggered Deck summon/Zombie lock and the Synchro-material self-revival/leave-field redirect are the two distinct effects; each record includes its separate HOPT.",
    215: "The Summon-triggered hand send/search and the Link-or-Synchro-material Deck-bottom/draw trigger are the two distinct effects; both records include the shared choose-one-effect HOPT.",
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
            "batch": "local-batch3-coverage-reconciliation",
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

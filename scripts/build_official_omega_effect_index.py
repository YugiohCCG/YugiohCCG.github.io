#!/usr/bin/env python3
"""Index official Omega card scripts by concrete effect/API structure."""

from __future__ import annotations

import hashlib
import json
import re
import sqlite3
from collections import Counter, defaultdict
from pathlib import Path


ROOT = Path(__file__).resolve().parents[1]
SCRIPTS = ROOT / "tmp" / "omega_scripts"
DB = Path(r"C:\Program Files (x86)\YGO Omega\YGO Omega_Data\Files\Bundles\db")
OUTPUT = ROOT / "scripts" / "output" / "official_omega_effect_reference_index.json"
CARD_RE = re.compile(r"^c(\d+)\.lua$")
TOKENS = (
    "SetType", "SetCode", "SetProperty", "SetCategory", "SetRange", "SetCountLimit",
    "SetCondition", "SetCost", "SetTarget", "SetOperation", "SetReset", "SetValue",
    "AddFusionProc", "AddXyzProcedure", "AddLinkProcedure", "AddSynchroProcedure",
    "AddRitualProc", "CheckActivateEffect", "SpecialSummon", "FusionSummon",
    "SynchroSummon", "XyzSummon", "LinkSummon", "RitualSummon", "SendtoHand",
    "SendtoGrave", "SendtoDeck", "Remove", "Destroy", "Release", "NegateActivation",
    "NegateEffect", "ChangePosition", "MoveToField", "RegisterFlagEffect",
    "GetActivityCount", "GetCustomActivityCount", "SetTurnCounter", "GetTurnCounter",
)
CONSTANT_RE = re.compile(
    r"\b(?:EFFECT|EVENT|CATEGORY|LOCATION|RESET|PHASE|REASON|SUMMON|TYPE|ATTRIBUTE|RACE)_[A-Z0-9_]+\b"
)


def main() -> int:
    with sqlite3.connect(DB) as db:
        names = {int(card_id): name for card_id, name in db.execute("SELECT id,name FROM texts")}
    cards = []
    inverted: dict[str, list[int]] = defaultdict(list)
    for path in sorted(SCRIPTS.glob("c*.lua")):
        match = CARD_RE.fullmatch(path.name)
        if not match:
            continue
        card_id = int(match.group(1))
        source = path.read_text(encoding="utf-8", errors="replace")
        api_counts = {token: source.count(token) for token in TOKENS if token in source}
        constants = sorted(set(CONSTANT_RE.findall(source)))
        for token in (*api_counts, *constants):
            inverted[token].append(card_id)
        cards.append(
            {
                "card_id": card_id,
                "name": names.get(card_id),
                "script": path.name,
                "script_sha256": hashlib.sha256(path.read_bytes()).hexdigest(),
                "effect_creations": source.count("Effect.CreateEffect"),
                "api_counts": api_counts,
                "constants": constants,
            }
        )
    payload = {
        "schema_version": 1,
        "official_cards_indexed": len(cards),
        "cards": cards,
        "inverted": {key: value for key, value in sorted(inverted.items())},
        "summary": {
            "scripts": len(cards),
            "effect_creations": sum(card["effect_creations"] for card in cards),
            "api_occurrences": dict(sorted(Counter({key: len(value) for key, value in inverted.items()}).items())),
        },
    }
    OUTPUT.parent.mkdir(parents=True, exist_ok=True)
    OUTPUT.write_text(json.dumps(payload, separators=(",", ":"), ensure_ascii=False) + "\n", encoding="utf-8")
    print(f"official_scripts={len(cards)}")
    print(f"effect_creations={payload['summary']['effect_creations']}")
    print(f"index={OUTPUT}")
    return 0


if __name__ == "__main__":
    raise SystemExit(main())

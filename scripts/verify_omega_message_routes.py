#!/usr/bin/env python3
"""Verify every active CCG aux.Stringid route against signed-safe DB carriers."""

from __future__ import annotations

import argparse
import json
from pathlib import Path
import re
import sqlite3
from typing import Any

from sync_omega_ccg_db import (
    MAX_SIGNED_STRING_CARD_ID,
    MESSAGE_CARRIER_TYPE,
    build_message_carrier_map,
)


ROOT = Path(__file__).resolve().parents[1]
DEFAULT_CARDS = ROOT / "src" / "data" / "cards.json"
DEFAULT_SCRIPTS = ROOT / "public" / "CCG Downloads" / "CCG_Scripts"
DEFAULT_DB = ROOT / "public" / "CCG Downloads" / "CCG_Database" / "CCG_v1.db"
DEFAULT_REPORT = ROOT / "scripts" / "output" / "omega_message_route_manifest.json"
DEFAULT_OFFICIAL_DB = Path(
    r"C:\Program Files (x86)\YGO Omega\YGO Omega_Data\Files\Bundles\db"
)

CONSTANT_RE = re.compile(r"^\s*local\s+([A-Za-z_]\w*)\s*=\s*(\d+)\s*$", re.MULTILINE)
STRING_CALL_RE = re.compile(
    r"aux\.Stringid\s*\(\s*([A-Za-z_]\w*|\d+)\s*,\s*(\d+)\s*\)"
)


def main() -> int:
    parser = argparse.ArgumentParser(description=__doc__)
    parser.add_argument("--cards", type=Path, default=DEFAULT_CARDS)
    parser.add_argument("--scripts", type=Path, default=DEFAULT_SCRIPTS)
    parser.add_argument("--db", type=Path, default=DEFAULT_DB)
    parser.add_argument("--official-db", type=Path, default=DEFAULT_OFFICIAL_DB)
    parser.add_argument("--report", type=Path, default=None)
    args = parser.parse_args()

    cards = json.loads(args.cards.read_text(encoding="utf-8-sig"))
    carrier_map = build_message_carrier_map(cards)
    carrier_to_owner = {carrier: owner for owner, carrier in carrier_map.items()}
    errors: list[str] = []
    call_count = 0
    pairs: set[tuple[int, int]] = set()
    cards_with_calls: set[int] = set()
    manifest_cards: list[dict[str, Any]] = []

    if args.official_db.exists():
        official = sqlite3.connect(
            f"file:{args.official_db.resolve().as_posix()}?mode=ro", uri=True
        )
        try:
            official_collisions = [
                (owner_id, carrier_id)
                for owner_id, carrier_id in carrier_map.items()
                if official.execute(
                    "select 1 from datas where id=?", (carrier_id,)
                ).fetchone()
            ]
            for owner_id, carrier_id in official_collisions:
                errors.append(
                    f"carrier {carrier_id} for {owner_id} collides with the official Omega DB"
                )
        finally:
            official.close()

    conn = sqlite3.connect(f"file:{args.db.resolve().as_posix()}?mode=ro", uri=True)
    conn.row_factory = sqlite3.Row
    try:
        for card_id in sorted(carrier_map):
            script_path = args.scripts / f"c{card_id}.lua"
            if not script_path.exists():
                errors.append(f"{card_id}: script missing")
                continue
            text = script_path.read_text(encoding="utf-8")
            constants = {name: int(value) for name, value in CONSTANT_RE.findall(text)}
            card_calls: list[dict[str, int | str]] = []
            for match in STRING_CALL_RE.finditer(text):
                call_count += 1
                base_expr, slot_text = match.groups()
                slot = int(slot_text)
                if base_expr == "id":
                    base_id = card_id
                elif base_expr.isdigit():
                    base_id = int(base_expr)
                else:
                    base_id = constants.get(base_expr, -1)
                if base_id < 0:
                    errors.append(f"{script_path.name}: unresolved Stringid base {base_expr}")
                    continue
                if base_id > MAX_SIGNED_STRING_CARD_ID:
                    errors.append(f"{script_path.name}: unsafe Stringid base {base_id}")
                    continue
                description = base_id * 16 + slot
                if description < 5000 or description > 2**31 - 1:
                    errors.append(f"{script_path.name}: unsafe description key {description}")
                    continue
                owner_id = carrier_to_owner.get(base_id)
                if owner_id is None:
                    errors.append(f"{script_path.name}: {base_id} is not a CCG message carrier")
                    continue
                if not 0 <= slot < 16:
                    errors.append(f"{script_path.name}: invalid string slot {slot}")
                    continue
                column = f"str{slot + 1}"
                source = conn.execute(
                    f"select {column} as value from texts where id=?", (owner_id,)
                ).fetchone()
                carrier = conn.execute(
                    f"""
                    select d.type, t.{column} as value
                    from datas d join texts t using(id)
                    where d.id=?
                    """,
                    (base_id,),
                ).fetchone()
                if source is None or not source["value"]:
                    errors.append(f"{script_path.name}: source {owner_id} {column} is blank")
                    continue
                if carrier is None:
                    errors.append(f"{script_path.name}: carrier {base_id} is missing")
                    continue
                if int(carrier["type"]) != MESSAGE_CARRIER_TYPE:
                    errors.append(f"{script_path.name}: carrier {base_id} is not a hidden Token")
                if carrier["value"] != source["value"]:
                    errors.append(f"{script_path.name}: carrier {base_id} {column} differs from {owner_id}")
                cards_with_calls.add(card_id)
                pairs.add((base_id, slot))
                card_calls.append(
                    {
                        "source_card_id": owner_id,
                        "carrier_id": base_id,
                        "slot": slot,
                        "database_column": column,
                        "description_key": description,
                    }
                )
            manifest_cards.append(
                {
                    "card_id": card_id,
                    "carrier_id": carrier_map[card_id],
                    "script": script_path.name,
                    "string_call_count": len(card_calls),
                    "calls": card_calls,
                }
            )

        carrier_rows = conn.execute(
            "select id from texts where name like 'CCG Strings Placeholder %'"
        ).fetchall()
        if len(carrier_rows) != len(carrier_map):
            errors.append(
                f"carrier row count {len(carrier_rows)} does not match mapping {len(carrier_map)}"
            )
    finally:
        conn.close()

    print(f"active_cards={len(carrier_map)}")
    print(f"cards_with_string_calls={len(cards_with_calls)}")
    print(f"string_call_occurrences={call_count}")
    print(f"unique_carrier_slots={len(pairs)}")
    print(f"errors={len(errors)}")
    for error in errors[:50]:
        print(f"ERROR {error}")
    if args.report is not None:
        args.report.parent.mkdir(parents=True, exist_ok=True)
        args.report.write_text(
            json.dumps(
                {
                    "active_cards": len(carrier_map),
                    "cards_with_string_calls": len(cards_with_calls),
                    "string_call_occurrences": call_count,
                    "unique_carrier_slots": len(pairs),
                    "maximum_description_key": max(
                        (base_id * 16 + slot for base_id, slot in pairs), default=None
                    ),
                    "routed_scripts": [
                        card["script"]
                        for card in manifest_cards
                        if card["string_call_count"]
                    ],
                    "scripts_without_string_calls": [
                        card["script"]
                        for card in manifest_cards
                        if not card["string_call_count"]
                    ],
                    "cards": manifest_cards,
                    "errors": errors,
                },
                indent=2,
            )
            + "\n",
            encoding="utf-8",
        )
        print(f"report={args.report}")
    return 1 if errors else 0


if __name__ == "__main__":
    raise SystemExit(main())

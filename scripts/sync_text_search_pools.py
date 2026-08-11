#!/usr/bin/env python3
"""Generate Lua code pools for effects that search printed card text/name.

Omega does not expose arbitrary printed descriptions to card scripts at duel
runtime. These deterministic tables bridge that engine limitation from the
official Omega database plus the CCG cards.json source of truth.
"""

from __future__ import annotations

import argparse
import json
import re
import sqlite3
from pathlib import Path


ROOT = Path(__file__).resolve().parents[1]
CARDS = ROOT / "src" / "data" / "cards.json"
SCRIPTS = ROOT / "public" / "CCG Downloads" / "CCG_Scripts"
OFFICIAL_DB = Path(r"C:\Program Files (x86)\YGO Omega\YGO Omega_Data\Files\Bundles\db")
SPELL_TRAP = 0x2 | 0x4
PROPHECIES = {
    229327103: "FIRE",
    251058567: "WATER",
    223558392: "EARTH",
    223592011: "WIND",
    244920555: "LIGHT",
    243920845: "DARK",
}
TABLE_RE = re.compile(r"s\.search_codes=\{.*?\}", re.DOTALL)
TO_PROTO_RE = re.compile(r"s\.to_proto_codes=\{.*?\}", re.DOTALL)
MINE_FIELD_RE = re.compile(r"s\.mine_field_codes=\{.*?\}", re.DOTALL)
MORTIS_RE = re.compile(r"s\.mortis_codes=\{.*?\}", re.DOTALL)
HALLO_RE = re.compile(r"s\.hallo_monster_codes=\{.*?\}", re.DOTALL)
HALLO_WEEN_RE = re.compile(r"s\.hallo_ween_monster_codes=\{.*?\}", re.DOTALL)


def clean_text(value: str | None) -> str:
    return re.sub(r"\[[^]]*]", " ", value or "")


def listed(value: str, phrase: str) -> bool:
    return re.search(rf"(?<![A-Za-z0-9]){re.escape(phrase)}(?![A-Za-z0-9])", value, re.I) is not None


def load_pool() -> list[tuple[int, str, str]]:
    rows: dict[int, tuple[str, str]] = {}
    with sqlite3.connect(OFFICIAL_DB) as db:
        for card_id, name, desc in db.execute(
            "SELECT d.id,t.name,t.desc FROM datas d JOIN texts t ON t.id=d.id "
            "WHERE (d.type & ?) != 0",
            (SPELL_TRAP,),
        ):
            rows[int(card_id)] = (name or "", clean_text(desc))
    for card in json.loads(CARDS.read_text(encoding="utf-8")):
        if card.get("category") in {"Spell", "Trap"}:
            rows[int(card["passcode"])] = (card.get("name") or "", card.get("text") or "")
    return [(card_id, name, desc) for card_id, (name, desc) in rows.items()]


def load_named_pool() -> list[tuple[int, str, int]]:
    """Load names and type bits from official Omega plus local CCG cards."""
    rows: dict[int, tuple[str, int]] = {}
    with sqlite3.connect(OFFICIAL_DB) as db:
        for card_id, name, card_type in db.execute(
            "SELECT d.id,t.name,d.type FROM datas d JOIN texts t ON t.id=d.id"
        ):
            rows[int(card_id)] = (name or "", int(card_type))
    for card in json.loads(CARDS.read_text(encoding="utf-8")):
        card_type = {"Monster": 0x1, "Spell": 0x2, "Trap": 0x4}.get(card.get("category"), 0)
        if card.get("icon") == "Field":
            card_type |= 0x80000
        rows[int(card["passcode"])] = (card.get("name") or "", card_type)
    return [(card_id, name, card_type) for card_id, (name, card_type) in rows.items()]


def lua_table(name: str, ids: list[int]) -> str:
    body = "\n".join(f"\t[{card_id}]=true," for card_id in sorted(ids))
    return f"s.{name}={{\n{body}\n}}"


def replace(path: Path, pattern: re.Pattern[str], replacement: str, check: bool) -> bool:
    original = path.read_text(encoding="utf-8")
    updated, count = pattern.subn(replacement, original, count=1)
    if count != 1:
        raise RuntimeError(f"expected one generated table in {path}")
    if updated == original:
        return False
    if check:
        raise RuntimeError(f"stale generated text-search pool: {path.name}")
    path.write_text(updated, encoding="utf-8", newline="\n")
    return True


def main() -> int:
    parser = argparse.ArgumentParser(description=__doc__)
    parser.add_argument("--check", action="store_true")
    args = parser.parse_args()
    pool = load_pool()
    named_pool = load_named_pool()
    changed = 0
    for card_id, attribute in PROPHECIES.items():
        ids = [cid for cid, _name, desc in pool if listed(desc, attribute)]
        changed += replace(SCRIPTS / f"c{card_id}.lua", TABLE_RE, lua_table("search_codes", ids), args.check)
        print(f"{attribute}: {len(ids)} searchable Spell/Trap cards")
    to_proto = [cid for cid, name, desc in pool if listed(name, "To Proto") or listed(desc, "To Proto")]
    changed += replace(
        SCRIPTS / "c245400676.lua", TO_PROTO_RE, lua_table("to_proto_codes", to_proto), args.check
    )
    print(f"To Proto name/text: {len(to_proto)} searchable Spell/Trap cards")
    mine_fields = [
        cid for cid, name, card_type in named_pool
        if listed(name, "Mine") and card_type & 0x2 and card_type & 0x80000
    ]
    for target_id in (241868535, 215984744):
        changed += replace(
            SCRIPTS / f"c{target_id}.lua",
            MINE_FIELD_RE,
            lua_table("mine_field_codes", mine_fields),
            args.check,
        )
    print(f"Mine-named Field Spells: {len(mine_fields)} searchable cards")
    mortis = [cid for cid, name, _card_type in named_pool if listed(name, "Mortis")]
    changed += replace(
        SCRIPTS / "c215984744.lua", MORTIS_RE, lua_table("mortis_codes", mortis), args.check
    )
    print(f"Mortis-named cards: {len(mortis)} searchable cards")
    hallo_monsters = [
        cid for cid, name, card_type in named_pool if card_type & 0x1 and listed(name, "Hallo")
    ]
    changed += replace(
        SCRIPTS / "c250262550.lua", HALLO_RE, lua_table("hallo_monster_codes", hallo_monsters), args.check
    )
    print(f"Hallo-named monsters: {len(hallo_monsters)} searchable cards")
    hallo_ween_monsters = [
        cid for cid, name, card_type in named_pool
        if card_type & 0x1 and (listed(name, "Hallo") or listed(name, "Ween"))
    ]
    changed += replace(
        SCRIPTS / "c255977900.lua",
        HALLO_WEEN_RE,
        lua_table("hallo_ween_monster_codes", hallo_ween_monsters),
        args.check,
    )
    print(f"Hallo/Ween-named monsters: {len(hallo_ween_monsters)} searchable cards")
    print(f"{'verified' if args.check else 'updated'} generated pools; changed={changed}")
    return 0


if __name__ == "__main__":
    raise SystemExit(main())

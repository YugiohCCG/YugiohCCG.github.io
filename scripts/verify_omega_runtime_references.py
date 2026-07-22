#!/usr/bin/env python3
"""Audit custom Lua/card references that can make Omega load another card script."""

from __future__ import annotations

import argparse
import json
from pathlib import Path
import re
import sqlite3

from sync_omega_ccg_db import EXTRA_TOKEN_CARDS


ROOT = Path(__file__).resolve().parents[1]
DEFAULT_CARDS = ROOT / "src" / "data" / "cards.json"
DEFAULT_SCRIPTS = ROOT / "public" / "CCG Downloads" / "CCG_Scripts"
DEFAULT_DB = ROOT / "public" / "CCG Downloads" / "CCG_Database" / "CCG_v1.db"
DEFAULT_OFFICIAL_DB = Path(
    r"C:\Program Files (x86)\YGO Omega\YGO Omega_Data\Files\Bundles\db"
)
DEFAULT_OFFICIAL_SCRIPTS = ROOT / "tmp" / "omega_scripts"

CONSTANT_RE = re.compile(
    r"^\s*local\s+([A-Za-z_]\w*)\s*=\s*(\d+)\s*$", re.MULTILINE
)
CREATE_TOKEN_RE = re.compile(
    r"Duel\.CreateToken\s*\(\s*[^,]+,\s*([^\)]+?)\s*\)"
)
CAN_SUMMON_CODE_RE = re.compile(
    r"Duel\.IsPlayerCanSpecialSummonMonster\s*\(\s*[^,]+,\s*([^,]+?)\s*,"
)
COPY_EFFECT_RE = re.compile(r"(?:\:|\.)CopyEffect\s*\(\s*([^,]+?)\s*,")


def resolve_expression(
    expression: str, card_id: int, constants: dict[str, int]
) -> int | None:
    expression = re.sub(r"\s+", "", expression)
    if expression.isdigit():
        return int(expression)
    if expression == "id":
        return card_id
    match = re.fullmatch(r"id\+(\d+)", expression)
    if match:
        return card_id + int(match.group(1))
    return constants.get(expression)


def row_for_id(
    custom: sqlite3.Connection, official: sqlite3.Connection, card_id: int
) -> tuple[str, sqlite3.Row] | None:
    query = """
        select d.id, d.ot, d.type, t.name
        from datas d left join texts t on d.id=t.id
        where d.id=?
    """
    row = custom.execute(query, (card_id,)).fetchone()
    if row is not None:
        return "custom", row
    row = official.execute(query, (card_id,)).fetchone()
    if row is not None:
        return "official", row
    return None


def main() -> int:
    parser = argparse.ArgumentParser(description=__doc__)
    parser.add_argument("--cards", type=Path, default=DEFAULT_CARDS)
    parser.add_argument("--scripts", type=Path, default=DEFAULT_SCRIPTS)
    parser.add_argument("--db", type=Path, default=DEFAULT_DB)
    parser.add_argument("--official-db", type=Path, default=DEFAULT_OFFICIAL_DB)
    parser.add_argument(
        "--official-scripts", type=Path, default=DEFAULT_OFFICIAL_SCRIPTS
    )
    args = parser.parse_args()

    cards = json.loads(args.cards.read_text(encoding="utf-8-sig"))
    active = {
        int(card["passcode"]): str(card.get("name") or "")
        for card in cards
        if card.get("passcode") is not None
    }
    script_paths = {
        int(match.group(1)): path
        for path in args.scripts.glob("c*.lua")
        if (match := re.fullmatch(r"c(\d+)\.lua", path.name))
    }
    errors: list[str] = []
    orphan_ids = sorted(set(script_paths) - set(active))
    missing_scripts = sorted(set(active) - set(script_paths))
    for card_id in missing_scripts:
        errors.append(f"active card {card_id} ({active[card_id]}) has no Lua script")

    custom = sqlite3.connect(f"file:{args.db.resolve().as_posix()}?mode=ro", uri=True)
    official = sqlite3.connect(
        f"file:{args.official_db.resolve().as_posix()}?mode=ro", uri=True
    )
    custom.row_factory = sqlite3.Row
    official.row_factory = sqlite3.Row
    create_token_calls = 0
    create_token_targets: set[int] = set()
    summon_code_checks = 0
    summon_code_targets: set[int] = set()
    static_copy_targets: set[int] = set()
    dynamic_copy_calls = 0
    try:
        for card_id, name in active.items():
            row = custom.execute(
                "select d.id, t.name from datas d left join texts t on d.id=t.id where d.id=?",
                (card_id,),
            ).fetchone()
            if row is None:
                errors.append(f"active card {card_id} ({name}) has no custom DB row")
            elif not row["name"]:
                errors.append(f"active card {card_id} has no localized DB name")

        for token in EXTRA_TOKEN_CARDS:
            token_id = int(token["id"])
            row = custom.execute(
                "select d.type, t.name from datas d left join texts t on d.id=t.id where d.id=?",
                (token_id,),
            ).fetchone()
            if row is None:
                errors.append(f"managed auxiliary Token {token_id} is missing")
            elif not row["name"]:
                errors.append(f"managed auxiliary Token {token_id} has no name")

        for card_id, path in sorted(script_paths.items()):
            text = path.read_text(encoding="utf-8")
            constants = {name: int(value) for name, value in CONSTANT_RE.findall(text)}
            for match in CREATE_TOKEN_RE.finditer(text):
                create_token_calls += 1
                expression = match.group(1)
                target_id = resolve_expression(expression, card_id, constants)
                if target_id is None:
                    errors.append(
                        f"{path.name}: unresolved Duel.CreateToken ID {expression!r}"
                    )
                    continue
                create_token_targets.add(target_id)
                if row_for_id(custom, official, target_id) is None:
                    errors.append(
                        f"{path.name}: Duel.CreateToken target {target_id} has no DB row"
                    )

            for match in CAN_SUMMON_CODE_RE.finditer(text):
                summon_code_checks += 1
                expression = match.group(1)
                target_id = resolve_expression(expression, card_id, constants)
                if target_id is None:
                    errors.append(
                        f"{path.name}: unresolved IsPlayerCanSpecialSummonMonster ID "
                        f"{expression!r}"
                    )
                    continue
                summon_code_targets.add(target_id)
                if row_for_id(custom, official, target_id) is None:
                    errors.append(
                        f"{path.name}: summon-legality target {target_id} has no DB row"
                    )

            for match in COPY_EFFECT_RE.finditer(text):
                expression = match.group(1)
                target_id = resolve_expression(expression, card_id, constants)
                if target_id is None:
                    dynamic_copy_calls += 1
                    continue
                static_copy_targets.add(target_id)
                source = row_for_id(custom, official, target_id)
                if source is None:
                    errors.append(
                        f"{path.name}: CopyEffect target {target_id} has no DB row"
                    )
                    continue
                source_name, row = source
                if int(row["type"] or 0) & 0x4000:
                    continue
                if source_name == "custom" and target_id not in script_paths:
                    errors.append(
                        f"{path.name}: custom CopyEffect target {target_id} has no Lua script"
                    )
                if source_name == "official" and not any(
                    args.official_scripts.rglob(f"c{target_id}.lua")
                ):
                    errors.append(
                        f"{path.name}: official CopyEffect target {target_id} has no reference script"
                    )
    finally:
        custom.close()
        official.close()

    print(f"active_cards={len(active)}")
    print(f"public_scripts={len(script_paths)}")
    print(f"missing_active_scripts={len(missing_scripts)}")
    print(f"preserved_orphan_scripts={len(orphan_ids)}")
    print(f"create_token_calls={create_token_calls}")
    print(f"create_token_targets={len(create_token_targets)}")
    print(f"summon_code_checks={summon_code_checks}")
    print(f"summon_code_targets={len(summon_code_targets)}")
    print(f"static_copy_effect_targets={len(static_copy_targets)}")
    print(f"dynamic_copy_effect_calls={dynamic_copy_calls}")
    print(f"errors={len(errors)}")
    for error in errors[:50]:
        print(f"ERROR {error}")
    if orphan_ids:
        print("orphan_ids=" + ",".join(str(card_id) for card_id in orphan_ids))
    return 1 if errors else 0


if __name__ == "__main__":
    raise SystemExit(main())

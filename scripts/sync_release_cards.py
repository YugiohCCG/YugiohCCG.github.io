"""Sync legal.tobereleased in cards.json against the shipped Omega CCG database.

Semantics:
  tobereleased=true  -> passcode exists in CCG_v1.db (released to Omega)
  tobereleased=false -> card is website-only until the next Omega DB release
"""
from __future__ import annotations

import argparse
import json
import sqlite3
import sys
from pathlib import Path
from typing import Any

REPO_ROOT = Path(__file__).resolve().parents[1]
DEFAULT_CARDS_PATH = REPO_ROOT / "src" / "data" / "cards.json"
DEFAULT_DB_PATH = REPO_ROOT / "public" / "CCG Downloads" / "CCG_Database" / "CCG_v1.db"


def load_db_passcodes(db_path: Path) -> set[int]:
    if not db_path.exists():
        raise FileNotFoundError(f"Omega DB not found: {db_path}")

    conn = sqlite3.connect(str(db_path.resolve()))
    try:
        return {int(row[0]) for row in conn.execute("select id from datas")}
    finally:
        conn.close()


def ensure_legal(card: dict[str, Any]) -> dict[str, Any]:
    legal = card.get("legal")
    if not isinstance(legal, dict):
        legal = {}
        card["legal"] = legal
    return legal


def sync_release_flags(
    cards_path: Path = DEFAULT_CARDS_PATH,
    db_path: Path = DEFAULT_DB_PATH,
    *,
    mark_all_released: bool = False,
    write: bool = True,
) -> dict[str, int]:
    cards = json.loads(cards_path.read_text(encoding="utf-8"))
    if not isinstance(cards, list):
        raise ValueError(f"Expected a JSON array in {cards_path}")

    db_ids = load_db_passcodes(db_path) if not mark_all_released else set()

    changed = 0
    released_true = 0
    released_false = 0
    missing_passcode = 0

    for card in cards:
        if not isinstance(card, dict):
            continue

        passcode = card.get("passcode")
        if not isinstance(passcode, int):
            missing_passcode += 1
            continue

        if mark_all_released:
            target = True
        else:
            target = passcode in db_ids

        legal = ensure_legal(card)
        previous = legal.get("tobereleased")
        if previous is not target:
            legal["tobereleased"] = target
            changed += 1
        elif "tobereleased" not in legal:
            legal["tobereleased"] = target
            changed += 1

        if target:
            released_true += 1
        else:
            released_false += 1

    if write and changed:
        cards_path.write_text(
            json.dumps(cards, ensure_ascii=False, indent=2) + "\n",
            encoding="utf-8",
        )

    return {
        "cards": len(cards),
        "changed": changed,
        "released_true": released_true,
        "released_false": released_false,
        "missing_passcode": missing_passcode,
        "db_passcodes": len(db_ids),
        "written": int(write and changed > 0),
    }


def main() -> int:
    parser = argparse.ArgumentParser(
        description="Sync legal.tobereleased in cards.json from the Omega CCG database."
    )
    parser.add_argument("--cards", type=Path, default=DEFAULT_CARDS_PATH)
    parser.add_argument("--db", type=Path, default=DEFAULT_DB_PATH)
    parser.add_argument(
        "--mark-released",
        action="store_true",
        help="Force legal.tobereleased=true for every card with a passcode (after Omega release).",
    )
    parser.add_argument(
        "--check",
        action="store_true",
        help="Exit 1 when cards.json would change; do not write.",
    )
    args = parser.parse_args()

    try:
        result = sync_release_flags(
            cards_path=args.cards,
            db_path=args.db,
            mark_all_released=args.mark_released,
            write=not args.check,
        )
    except FileNotFoundError as exc:
        print(f"error: {exc}", file=sys.stderr)
        return 1

    for key, value in result.items():
        print(f"{key}={value}")

    if args.check and result["changed"]:
        print("cards.json is out of sync with the Omega DB release flags", file=sys.stderr)
        return 1

    return 0


if __name__ == "__main__":
    raise SystemExit(main())

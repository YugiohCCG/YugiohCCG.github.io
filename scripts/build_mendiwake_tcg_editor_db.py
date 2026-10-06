from __future__ import annotations

import json
import sqlite3
from pathlib import Path
from typing import Any

from sync_omega_ccg_db import (
    ATTRIBUTE_BITS,
    RACE_BITS,
    TYPE_BITS,
    build_attribute,
    build_def,
    build_level,
    build_race,
    build_type,
)


REPO_ROOT = Path(__file__).resolve().parents[1]
SOURCE_PATH = REPO_ROOT / "output" / "mendiwake_tcg_editor_cards.json"
OUTPUT_PATH = REPO_ROOT / "output" / "Mendiwake_TCG_Editor.cdb"


def create_schema(connection: sqlite3.Connection) -> None:
    connection.executescript(
        """
        DROP TABLE IF EXISTS texts;
        DROP TABLE IF EXISTS datas;
        CREATE TABLE texts(
            id INTEGER PRIMARY KEY,
            name TEXT,
            desc TEXT,
            str1 TEXT, str2 TEXT, str3 TEXT, str4 TEXT,
            str5 TEXT, str6 TEXT, str7 TEXT, str8 TEXT,
            str9 TEXT, str10 TEXT, str11 TEXT, str12 TEXT,
            str13 TEXT, str14 TEXT, str15 TEXT, str16 TEXT
        );
        CREATE TABLE datas(
            id INTEGER PRIMARY KEY DEFAULT 0,
            ot INTEGER DEFAULT 0,
            alias INTEGER DEFAULT 0,
            setcode BLOB,
            type INTEGER DEFAULT 0,
            atk INTEGER DEFAULT 0,
            def INTEGER DEFAULT 0,
            level INTEGER DEFAULT 0,
            race INTEGER DEFAULT 0,
            attribute INTEGER DEFAULT 0,
            category INTEGER DEFAULT 0,
            genre INTEGER DEFAULT 0,
            script BLOB,
            support BLOB
        );
        """
    )


def validate_card(card: dict[str, Any]) -> None:
    required = {"id", "passcode", "name", "category", "text"}
    missing = sorted(required.difference(card))
    if missing:
        raise ValueError(f"{card.get('id', '<unknown>')}: missing {', '.join(missing)}")
    if card["category"] == "Monster":
        race = str((card.get("monsterType") or [""])[0])
        attribute = str(card.get("attribute") or "")
        if race not in RACE_BITS:
            raise ValueError(f"{card['id']}: unsupported race {race!r}")
        if attribute not in ATTRIBUTE_BITS:
            raise ValueError(f"{card['id']}: unsupported attribute {attribute!r}")


def main() -> int:
    payload = json.loads(SOURCE_PATH.read_text(encoding="utf-8"))
    cards = payload["cards"]
    setcode = int(payload["setcode"], 16)
    setcode_blob = setcode.to_bytes(2, "little", signed=False)

    passcodes = [int(card["passcode"]) for card in cards]
    if len(passcodes) != len(set(passcodes)):
        raise ValueError("Duplicate passcodes in Mendiwake source")

    OUTPUT_PATH.parent.mkdir(parents=True, exist_ok=True)
    connection = sqlite3.connect(OUTPUT_PATH)
    try:
        create_schema(connection)
        for card in cards:
            validate_card(card)
            card_id = int(card["passcode"])
            connection.execute(
                """
                INSERT INTO datas(
                    id, ot, alias, setcode, type, atk, def, level,
                    race, attribute, category, genre, script, support
                ) VALUES (?, 0, 0, ?, ?, ?, ?, ?, ?, ?, 0, 0, NULL, NULL)
                """,
                (
                    card_id,
                    setcode_blob,
                    build_type(card),
                    int(card.get("atk") or 0),
                    build_def(card),
                    build_level(card),
                    build_race(card),
                    build_attribute(card),
                ),
            )
            connection.execute(
                """
                INSERT INTO texts(
                    id, name, desc,
                    str1, str2, str3, str4, str5, str6, str7, str8,
                    str9, str10, str11, str12, str13, str14, str15, str16
                ) VALUES (?, ?, ?, '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '')
                """,
                (card_id, card["name"], card["text"]),
            )
        connection.commit()

        data_count = connection.execute("SELECT COUNT(*) FROM datas").fetchone()[0]
        text_count = connection.execute("SELECT COUNT(*) FROM texts").fetchone()[0]
        if data_count != len(cards) or text_count != len(cards):
            raise RuntimeError(
                f"Row-count mismatch: cards={len(cards)}, datas={data_count}, texts={text_count}"
            )

        fusion_type = TYPE_BITS["Monster"] | TYPE_BITS["Fusion"] | TYPE_BITS["Effect"]
        fusion_count = connection.execute(
            "SELECT COUNT(*) FROM datas WHERE (type & ?) = ?", (fusion_type, fusion_type)
        ).fetchone()[0]
        if fusion_count != 1:
            raise RuntimeError(f"Expected 1 Fusion Monster, found {fusion_count}")
    finally:
        connection.close()

    print(f"Built {OUTPUT_PATH}")
    print(f"Cards: {len(cards)}")
    print(f"Setcode: 0x{setcode:04X}")
    print("Images: intentionally omitted")
    return 0


if __name__ == "__main__":
    raise SystemExit(main())

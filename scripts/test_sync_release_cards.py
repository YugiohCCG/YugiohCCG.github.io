"""Tests for sync_release_cards.py."""
from __future__ import annotations

import json
import sqlite3
import tempfile
import unittest
from pathlib import Path

from sync_release_cards import sync_release_flags


class SyncReleaseCardsTest(unittest.TestCase):
    def test_sync_from_db(self) -> None:
        with tempfile.TemporaryDirectory() as tmp:
            root = Path(tmp)
            db_path = root / "CCG_v1.db"
            cards_path = root / "cards.json"

            conn = sqlite3.connect(db_path)
            conn.execute("create table datas (id integer primary key)")
            conn.executemany("insert into datas (id) values (?)", [(101,), (202,)])
            conn.commit()
            conn.close()

            cards_path.write_text(
                json.dumps(
                    [
                        {"passcode": 101, "legal": {"tobereleased": False}},
                        {"passcode": 303, "legal": {"tobereleased": True}},
                    ]
                ),
                encoding="utf-8",
            )

            result = sync_release_flags(cards_path=cards_path, db_path=db_path)
            self.assertEqual(result["released_true"], 1)
            self.assertEqual(result["released_false"], 1)
            self.assertEqual(result["changed"], 2)

            cards = json.loads(cards_path.read_text(encoding="utf-8"))
            self.assertTrue(cards[0]["legal"]["tobereleased"])
            self.assertFalse(cards[1]["legal"]["tobereleased"])

    def test_mark_all_released(self) -> None:
        with tempfile.TemporaryDirectory() as tmp:
            root = Path(tmp)
            db_path = root / "CCG_v1.db"
            cards_path = root / "cards.json"

            conn = sqlite3.connect(db_path)
            conn.execute("create table datas (id integer primary key)")
            conn.commit()
            conn.close()

            cards_path.write_text(
                json.dumps([{"passcode": 999, "legal": {"tobereleased": False}}]),
                encoding="utf-8",
            )

            result = sync_release_flags(
                cards_path=cards_path,
                db_path=db_path,
                mark_all_released=True,
            )
            self.assertEqual(result["released_true"], 1)
            self.assertEqual(result["released_false"], 0)

            cards = json.loads(cards_path.read_text(encoding="utf-8"))
            self.assertTrue(cards[0]["legal"]["tobereleased"])


if __name__ == "__main__":
    unittest.main()

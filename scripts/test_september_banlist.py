"""Read-only consistency checks for the community's September 2026 changes."""
import json
import re
import subprocess
import unittest
from pathlib import Path
from fresh_ccg_baseline import conflict_views

ROOT = Path(__file__).resolve().parents[1]


def read(path):
    return json.loads((ROOT / path).read_text(encoding="utf-8-sig"))


class BanlistUpdateTests(unittest.TestCase):
    def test_all_eleven_changes_match_source_and_website(self):
        changes = read("src/data/banlist-update.json")
        self.assertEqual(changes["effectiveDate"], "2026-09-15")
        self.assertEqual(len(changes["changes"]), 11)
        catalogs = [read(p) for p in ["public/data/yugioh-cards.json", "public/assets/cards.json", "src/data/tcg-cards.json"]]
        displayed = {c["passcode"]: c for c in read("public/data/banlist-cards.json")}
        for item in changes["changes"]:
            code, limit = item["passcode"], item["limit"]
            matches = [c for catalog in catalogs for c in catalog if c.get("passcode") == code]
            self.assertGreaterEqual(len(matches), 1, item["name"])
            for card in matches:
                self.assertEqual(tuple(bool(card["legal"].get(k)) for k in ["banned", "limited", "semiLimited"]), (limit == 0, limit == 1, limit == 2), card["name"])
            self.assertEqual(code in displayed, limit < 3)
            if limit < 3:
                self.assertEqual(displayed[code]["legal"]["banned"], limit == 0)
                self.assertEqual(displayed[code]["legal"]["limited"], limit == 1)

    def test_omega_limits_and_unrelated_entries(self):
        path = "public/CCG Downloads/CCG_Banlist/CCG_Banlist.lflist.conf"
        def rows(text):
            pairs = re.findall(r"^(\d+)\s+([012])\s+--.*$", text, re.M)
            self.assertEqual(len(pairs), len(dict(pairs)))
            return {int(code): int(limit) for code, limit in pairs}
        current_text = (ROOT / path).read_text(encoding="utf-8")
        current = rows(current_text)
        previous = rows(subprocess.check_output(["git", "show", "HEAD:" + path], cwd=ROOT, text=True))
        changes = {c["passcode"]: c["limit"] for c in read("src/data/banlist-update.json")["changes"]}
        for code, limit in changes.items():
            self.assertEqual(current.get(code, 3), limit)
        self.assertEqual({k: v for k, v in current.items() if k not in changes}, {k: v for k, v in previous.items() if k not in changes})
        self.assertIn("# Effective 2026-09-15", current_text)

    def test_custom_source_both_merge_views(self):
        views, _ = conflict_views((ROOT / "src/data/cards.json").read_text(encoding="utf-8"))
        for view in views:
            cards = {c["passcode"]: c for c in view}
            self.assertTrue(cards[224235021]["legal"]["banned"])
            self.assertFalse(cards[222676270]["legal"]["banned"])


if __name__ == "__main__":
    unittest.main()

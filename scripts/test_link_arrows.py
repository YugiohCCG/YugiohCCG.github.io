"""Regression coverage for website Link Arrow spellings in Omega DB rows."""
import unittest

from sync_omega_ccg_db import build_def


class LinkArrowTests(unittest.TestCase):
    def test_new_website_spellings(self):
        card = {
            "name": "Heavy-Armoured Ballista Bahariasaurus",
            "category": "Monster",
            "cardTypes": ["Link", "Effect"],
            "linkArrows": ["up-left", "up-right", "down-left", "down-right"],
        }
        self.assertEqual(build_def(card), 0x145)

    def test_unknown_spelling_fails_visibly(self):
        card = {
            "name": "Broken Link",
            "category": "Monster",
            "cardTypes": ["Link"],
            "linkArrows": ["sideways-ish"],
        }
        with self.assertRaisesRegex(ValueError, "Unknown Link Arrow"):
            build_def(card)


if __name__ == "__main__":
    unittest.main()

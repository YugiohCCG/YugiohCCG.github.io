"""Release regressions for real archetype membership and versioned image paths."""
import sqlite3
import tempfile
import unittest
from pathlib import Path
from PIL import Image
from official_omega_reference import official_database
from sync_omega_ccg_db import OFFICIAL_SHARED_SET_CODES, decode_setcodes
from card_star_detector import detect_star_count
from export_omega_ccg_pics import export_missing_pics
import json

ROOT=Path(__file__).resolve().parents[1]
class ReleaseRegressionTest(unittest.TestCase):
    def test_shared_codes_match_official_cards(self):
        examples={"vylon":56768355,"fiendsmith":60764609,"floowandereeze":18940725,"vanquishsoul":29302858}
        with sqlite3.connect(official_database()) as db:
            for name,code in examples.items():
                with self.subTest(archetype=name):
                    row=db.execute("select setcode from datas where id=?",(code,)).fetchone()
                    self.assertIsNotNone(row)
                    self.assertIn(OFFICIAL_SHARED_SET_CODES[name],decode_setcodes(row[0]))
    def test_versioned_image_export(self):
        with tempfile.TemporaryDirectory() as tmp:
            root=Path(tmp);assets=root/'assets';assets.mkdir()
            Image.new('RGB',(20,30),'red').save(assets/'sample.jpeg')
            cards=root/'cards.json';cards.write_text(json.dumps([{"passcode":123,"image":"/assets/cards/sample.jpeg?v=current"}]))
            exported,skipped=export_missing_pics(cards,assets,root/'Pics',False)
            self.assertEqual((exported,skipped),(1,0));self.assertTrue((root/'Pics/123.jpg').is_file())
    def test_star_does_not_merge_into_gold_background(self):
        self.assertEqual(detect_star_count(ROOT/'public/assets/cards/Crow_of_Crying_Chaos.jpeg'),3)
if __name__=='__main__':unittest.main()

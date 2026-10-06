from __future__ import annotations

import json
import sys
import tempfile
import unittest
from collections import OrderedDict
from pathlib import Path

from PIL import Image

HERE = Path(__file__).resolve().parent
MODULE_DIR = HERE.parent
if str(MODULE_DIR) not in sys.path:
    sys.path.insert(0, str(MODULE_DIR))

from common import DraftNormalizationError, model_string, normalize_draft, parse_json_strict
from validator import validate_caption, validate_image


FIXTURES = HERE / "fixtures"


def row() -> dict[str, str]:
    return {
        "dataset_id": "ygo4_test",
        "card_category": "Monster",
        "monster_type": "Plant",
        "spell_trap_subtype": "",
        "card_name": "Forbidden Identity",
        "source_name": "Forbidden Identity Alternate Art",
        "archetype": "Forbidden Tribe",
        "passcode": "12345678",
        "official_metadata_status": "verified_against_konami",
    }


class CaptionValidationTests(unittest.TestCase):
    def test_valid_fixture_passes(self) -> None:
        raw = (FIXTURES / "valid_caption.json").read_text(encoding="utf-8")
        result, caption = validate_caption(raw, row())
        self.assertEqual([], [item.as_dict() for item in result.errors])
        self.assertIsNotNone(caption)

    def test_invalid_fixture_hits_independent_gates(self) -> None:
        raw = (FIXTURES / "invalid_caption.json").read_text(encoding="utf-8")
        result, _ = validate_caption(raw, row())
        codes = {item.code for item in result.errors}
        self.assertTrue({
            "schema.top_keys",
            "metadata.hld_prefix",
            "caption.name_leak",
            "trigger.count_or_location",
            "bbox.extent",
            "caption.element_word_count",
            "caption.hedging",
        }.issubset(codes), codes)

    def test_duplicate_json_key_is_rejected(self) -> None:
        with self.assertRaises(ValueError):
            parse_json_strict('{"high_level_description":"one","high_level_description":"two"}')

    def test_generic_filler_and_corrupted_creature_phrases_are_rejected(self) -> None:
        caption = json.loads((FIXTURES / "valid_caption.json").read_text(encoding="utf-8"))
        caption["compositional_deconstruction"]["background"] += (
            " The artwork is rendered with fine details, showcasing the distinct characteristics of the subject clearly."
        )
        caption["style_description"]["lighting"] = "Bright creature light surrounds the subject."
        result, _ = validate_caption(json.dumps(caption), row())
        codes = {item.code for item in result.errors}
        self.assertIn("caption.generic_filler", codes)
        self.assertIn("caption.corrupted_phrase", codes)

    def test_normalizer_injects_metadata_trigger_and_explicit_bbox_conversion(self) -> None:
        draft = OrderedDict([
            ("high_level_description", "A green creature floating in a decorated blue field."),
            ("style_description", OrderedDict([
                ("aesthetics", "playful"),
                ("lighting", "soft diffuse light"),
                ("medium", "illustration"),
                ("art_style", "clean outlines and smooth cel shading"),
                ("color_palette", ["#abc", "#FFFFFF"]),
            ])),
            ("compositional_deconstruction", OrderedDict([
                ("background", "A blue dotted field."),
                ("elements", [OrderedDict([
                    ("type", "obj"),
                    ("bbox", [50, 100, 950, 900]),
                    ("desc", "Small pale green creature floating at the center with a rounded body, black oval eyes, pink cheeks, thin limbs, mismatched feet, a blue collar, a silver sword held to one side, and a round reddish shield held to the other side."),
                ])]),
            ])),
        ])
        caption = normalize_draft(draft, row(), bbox_source_format="qwen_xyxy")
        self.assertTrue(caption["high_level_description"].startswith(
            "A Plant-type MONSTER card artwork showing the following scene:"
        ))
        self.assertTrue(caption["style_description"]["art_style"].startswith("hclar52 card illustration"))
        self.assertEqual([100, 50, 900, 950], caption["compositional_deconstruction"]["elements"][0]["bbox"])
        self.assertEqual(["#AABBCC", "#FFFFFF"], caption["style_description"]["color_palette"])
        self.assertEqual(model_string(caption), model_string(parse_json_strict(model_string(caption))))

    def test_normalizer_refuses_reserved_trigger_in_draft(self) -> None:
        draft = json.loads((FIXTURES / "valid_caption.json").read_text(encoding="utf-8"), object_pairs_hook=OrderedDict)
        with self.assertRaises(DraftNormalizationError):
            normalize_draft(draft, row())

    def test_image_validator_checks_mode_and_size(self) -> None:
        with tempfile.TemporaryDirectory() as temporary:
            path = Path(temporary) / "bad.png"
            Image.new("RGBA", (512, 512), (0, 0, 0, 0)).save(path)
            result = validate_image(path, row())
            self.assertEqual({"image.dimensions", "image.mode"}, {item.code for item in result.errors})


if __name__ == "__main__":
    unittest.main()

#!/usr/bin/env python3
"""Replace duplicate prepared artworks while preserving dataset IDs and quotas."""

from __future__ import annotations

import json
from pathlib import Path

from build_ideogram4_yugioh_dataset import (
    PACKAGE,
    SELECTED,
    fallback_row,
    process_image,
    write_manifest,
)


REPLACEMENTS = {
    "ygo4_0195": 92970404,  # Subterror Behemoth Ultramafus — Pyro
    "ygo4_0197": 53303460,  # Impcantation Candoll — Pyro
    "ygo4_0200": 18236002,  # Prank-Kids Lampsies — Pyro
    "ygo4_0203": 816427,    # Neo Flamvell Lady — Pyro
    "ygo4_0205": 46412900,  # Volcanic Emperor — Pyro
    "ygo4_0208": 77832858,  # Thestalos the Shadowfire Monarch — Pyro
    "ygo4_0271": 15180041,  # Silent Swordsman — Warrior
    "ygo4_0342": 17228908,  # Lost World — Field Spell
    "ygo4_0358": 49702428,  # Dark Burning Attack — Normal Spell
    "ygo4_0387": 75190122,  # Dark Burning Magic — Quick-Play Spell
    "ygo4_0392": 84012625,  # Cosmic Flare — Quick-Play Spell
    "ygo4_0425": 48680970,  # Eternal Soul — Continuous Trap
    "ygo4_0428": 69452756,  # Unending Nightmare — Continuous Trap
}


def main() -> int:
    catalog_path = PACKAGE / "cache" / "ygoprodeck-cardinfo-misc.json"
    cards = json.loads(catalog_path.read_text(encoding="utf-8"))["data"]
    cards_by_id = {int(card["id"]): card for card in cards}

    selected_path = SELECTED / "selected-manifest.json"
    image_path = SELECTED / "image-manifest.json"
    selected = json.loads(selected_path.read_text(encoding="utf-8"))
    images = json.loads(image_path.read_text(encoding="utf-8"))
    selected_by_id = {row["dataset_id"]: row for row in selected}
    images_by_id = {row["dataset_id"]: row for row in images}

    for dataset_id, passcode in REPLACEMENTS.items():
        old = images_by_id[dataset_id]
        replacement = fallback_row(cards_by_id[passcode])
        expected_class = old.get("monster_type") or old.get("spell_trap_subtype")
        actual_class = replacement.get("monster_type") or replacement.get("spell_trap_subtype")
        if (replacement["card_category"], actual_class) != (old["card_category"], expected_class):
            raise RuntimeError(f"Taxonomy mismatch for {dataset_id}: {old} -> {replacement}")

        replacement.update({
            "dataset_id": dataset_id,
            "image_file": f"images/{dataset_id}.png",
            "caption_file": f"captions/{dataset_id}.json",
            "selection_status": "selected_pending_image_and_caption_qa",
            "replacement_reason": (
                f"Replaced duplicated passcode {old['passcode']} artwork with a unique "
                f"{replacement['card_category']}/{actual_class} artwork"
            ),
        })
        prepared = process_image(replacement, refresh=True)
        if prepared.get("image_validation_status") == "failed":
            raise RuntimeError(f"Image preparation failed for {dataset_id}: {prepared}")
        selected_by_id[dataset_id] = replacement
        images_by_id[dataset_id] = prepared
        print(f"{dataset_id}: {old['card_name']} -> {prepared['card_name']}")

    selected_out = [selected_by_id[row["dataset_id"]] for row in selected]
    images_out = [images_by_id[row["dataset_id"]] for row in images]
    write_manifest(selected_out, SELECTED / "selected-manifest")
    write_manifest(images_out, SELECTED / "image-manifest")
    return 0


if __name__ == "__main__":
    raise SystemExit(main())

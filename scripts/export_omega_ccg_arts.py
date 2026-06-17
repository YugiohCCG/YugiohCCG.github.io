from __future__ import annotations

import argparse
import json
from pathlib import Path

from PIL import Image


REPO_ROOT = Path(__file__).resolve().parents[1]
DEFAULT_CARDS_PATH = REPO_ROOT / "src" / "data" / "cards.json"
DEFAULT_ARTS_PATH = Path(r"C:\Program Files (x86)\YGO Omega\YGO Omega_Data\Files\Arts")
DEFAULT_SOURCE_ASSETS = REPO_ROOT / "public" / "assets" / "cards"

# Derived from existing working CCG Omega art exports.
ART_X_RATIO = 168 / 1388
ART_Y_RATIO = 372 / 2026
ART_SIDE_RATIO = 1052 / 1388
OUTPUT_SIZE = 624


def crop_card_art(image: Image.Image) -> Image.Image:
    rgb = image.convert("RGB")
    width, height = rgb.size
    left = round(width * ART_X_RATIO)
    top = round(height * ART_Y_RATIO)
    side = round(width * ART_SIDE_RATIO)
    side = min(side, width - left, height - top)
    return rgb.crop((left, top, left + side, top + side)).resize(
        (OUTPUT_SIZE, OUTPUT_SIZE),
        Image.Resampling.LANCZOS,
    )


def export_missing_arts(cards_path: Path, assets_dir: Path, arts_dir: Path, overwrite: bool) -> tuple[int, int]:
    cards = json.loads(cards_path.read_text(encoding="utf-8"))
    arts_dir.mkdir(parents=True, exist_ok=True)

    exported = 0
    skipped = 0

    for card in cards:
        passcode = card.get("passcode")
        if not isinstance(passcode, int):
            skipped += 1
            continue

        output_path = arts_dir / f"{passcode}.jpg"
        if output_path.exists() and not overwrite:
            skipped += 1
            continue

        image_ref = str(card.get("image") or "")
        if not image_ref.startswith("/assets/cards/"):
            skipped += 1
            continue

        source_path = assets_dir / image_ref.split("/assets/cards/", 1)[1]
        if not source_path.exists():
            skipped += 1
            continue

        with Image.open(source_path) as source_image:
            cropped = crop_card_art(source_image)
            cropped.save(output_path, format="JPEG", quality=92, optimize=True)
        exported += 1

    return exported, skipped


def main() -> None:
    parser = argparse.ArgumentParser(description="Export YGO Omega CCG art files from source card renders.")
    parser.add_argument("--cards", type=Path, default=DEFAULT_CARDS_PATH)
    parser.add_argument("--assets", type=Path, default=DEFAULT_SOURCE_ASSETS)
    parser.add_argument("--arts", type=Path, default=DEFAULT_ARTS_PATH)
    parser.add_argument("--overwrite", action="store_true")
    args = parser.parse_args()

    exported, skipped = export_missing_arts(
        cards_path=args.cards,
        assets_dir=args.assets,
        arts_dir=args.arts,
        overwrite=args.overwrite,
    )
    print(f"exported={exported}")
    print(f"skipped={skipped}")


if __name__ == "__main__":
    main()

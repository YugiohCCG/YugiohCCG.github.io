"""Shared CCG card-art crop used by Omega exports and ygocarder re-renders."""
from __future__ import annotations

import argparse
import base64
import io
import sys
from pathlib import Path

from PIL import Image

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


def crop_card_art_bytes(source_path: Path) -> bytes:
    with Image.open(source_path) as source_image:
        cropped = crop_card_art(source_image)
        buffer = io.BytesIO()
        cropped.save(buffer, format="JPEG", quality=92, optimize=True)
        return buffer.getvalue()


def main() -> int:
    parser = argparse.ArgumentParser(description="Crop the artwork region from a CCG card render.")
    parser.add_argument("--input", type=Path, required=True)
    parser.add_argument("--output", type=Path, help="Write cropped JPEG to this path.")
    parser.add_argument("--base64", action="store_true", help="Print base64 JPEG to stdout.")
    args = parser.parse_args()

    if not args.input.exists():
        print(f"error: input not found: {args.input}", file=sys.stderr)
        return 1

    payload = crop_card_art_bytes(args.input)
    if args.output:
        args.output.parent.mkdir(parents=True, exist_ok=True)
        args.output.write_bytes(payload)
    if args.base64 or not args.output:
        sys.stdout.write(base64.b64encode(payload).decode("ascii"))
    return 0


if __name__ == "__main__":
    raise SystemExit(main())

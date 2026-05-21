from __future__ import annotations

import argparse
import json
import re
import sqlite3
import unicodedata
import zipfile
from pathlib import Path

import cv2
import numpy as np
from PIL import Image, ImageEnhance, ImageFilter


REPO_ROOT = Path(__file__).resolve().parents[1]
DEFAULT_CARDS_PATH = REPO_ROOT / "src" / "data" / "cards.json"
DEFAULT_DB_PATH = Path(r"C:\Program Files (x86)\YGO Omega\YGO Omega_Data\Files\Databases\CCG_v1.db")
DEFAULT_HOLOGRAMS_PATH = Path(r"C:\Program Files (x86)\YGO Omega\YGO Omega_Data\Files\Holograms")
DEFAULT_SOURCE_ASSETS = REPO_ROOT / "public" / "assets" / "cards"

# Same art window as the working Omega Arts exporter, resized to Omega's
# hologram convention.
ART_X_RATIO = 168 / 1388
ART_Y_RATIO = 372 / 2026
ART_SIDE_RATIO = 1052 / 1388
OUTPUT_SIZE = 512


def normalize_name(value: str | None) -> str:
    text = unicodedata.normalize("NFKD", value or "")
    text = text.lower()
    text = (
        text.replace("â€™", "'")
        .replace("â€œ", '"')
        .replace("â€", '"')
        .replace("â€”", "-")
        .replace("â€“", "-")
    )
    return re.sub(r"[^a-z0-9]+", "", text)


def load_cards(cards_path: Path) -> dict[str, dict]:
    cards = json.loads(cards_path.read_text(encoding="utf-8"))
    return {normalize_name(str(card.get("name") or "")): card for card in cards}


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


def make_cutout_alpha(art: Image.Image) -> Image.Image:
    rgb = np.array(art.convert("RGB"))
    height, width = rgb.shape[:2]

    mask = np.full((height, width), cv2.GC_PR_BGD, np.uint8)
    margin = max(12, round(min(width, height) * 0.035))
    mask[:margin, :] = cv2.GC_BGD
    mask[-margin:, :] = cv2.GC_BGD
    mask[:, :margin] = cv2.GC_BGD
    mask[:, -margin:] = cv2.GC_BGD

    yy, xx = np.ogrid[:height, :width]
    cx = width / 2
    cy = height / 2
    broad_fg = ((xx - cx) / (width * 0.43)) ** 2 + ((yy - cy) / (height * 0.45)) ** 2 <= 1
    sure_fg = ((xx - cx) / (width * 0.27)) ** 2 + ((yy - cy) / (height * 0.31)) ** 2 <= 1
    mask[broad_fg] = cv2.GC_PR_FGD
    mask[sure_fg] = cv2.GC_FGD

    hsv = cv2.cvtColor(rgb, cv2.COLOR_RGB2HSV)
    gray = cv2.cvtColor(rgb, cv2.COLOR_RGB2GRAY)
    saturated = (hsv[:, :, 1] > 45) & (hsv[:, :, 2] > 105) & (yy > height * 0.18) & (yy < height * 0.88)
    bright = (gray > 190) & (xx > width * 0.12) & (xx < width * 0.88) & (yy > height * 0.10) & (yy < height * 0.88)
    mask[saturated | bright] = cv2.GC_FGD

    bg_model = np.zeros((1, 65), np.float64)
    fg_model = np.zeros((1, 65), np.float64)

    cv2.grabCut(rgb, mask, None, bg_model, fg_model, 8, cv2.GC_INIT_WITH_MASK)
    alpha = np.where(
        (mask == cv2.GC_FGD) | (mask == cv2.GC_PR_FGD),
        255,
        0,
    ).astype(np.uint8)

    kernel = np.ones((7, 7), np.uint8)
    alpha = cv2.morphologyEx(alpha, cv2.MORPH_CLOSE, kernel, iterations=1)
    alpha = cv2.morphologyEx(alpha, cv2.MORPH_OPEN, np.ones((3, 3), np.uint8), iterations=1)

    component_count, labels, stats, _ = cv2.connectedComponentsWithStats(alpha, 8)
    if component_count > 1:
        min_area = width * height * 0.0025
        kept = np.zeros_like(alpha)
        for component in range(1, component_count):
            if stats[component, cv2.CC_STAT_AREA] >= min_area:
                kept[labels == component] = 255
        if kept.any():
            alpha = kept

    opaque_ratio = np.count_nonzero(alpha) / float(width * height)
    if opaque_ratio < 0.05 or opaque_ratio > 0.97:
        alpha = np.full((height, width), 255, dtype=np.uint8)

    return Image.fromarray(alpha, "L").filter(ImageFilter.GaussianBlur(1.0))


def build_hologram(source_image: Image.Image, opaque: bool) -> Image.Image:
    art = crop_card_art(source_image)
    art = ImageEnhance.Color(art).enhance(1.08)
    art = ImageEnhance.Contrast(art).enhance(1.04)
    alpha = Image.new("L", art.size, 255) if opaque else make_cutout_alpha(art)
    hologram = art.convert("RGBA")
    hologram.putalpha(alpha)
    return hologram


def package_outputs(paths: list[Path], zip_path: Path) -> None:
    zip_path.parent.mkdir(parents=True, exist_ok=True)
    with zipfile.ZipFile(zip_path, "w", compression=zipfile.ZIP_DEFLATED) as archive:
        for path in sorted(paths):
            if path.exists():
                archive.write(path, path.name)


def export_holograms(
    cards_path: Path,
    db_path: Path,
    assets_dir: Path,
    holograms_dir: Path,
    overwrite: bool,
    include_spells: bool,
    opaque: bool,
    ids: set[int] | None,
) -> tuple[int, int, list[Path]]:
    source_cards = load_cards(cards_path)
    holograms_dir.mkdir(parents=True, exist_ok=True)

    conn = sqlite3.connect(db_path)
    try:
        rows = conn.execute("select id, name from texts order by id").fetchall()
    finally:
        conn.close()

    exported = 0
    skipped = 0
    touched: list[Path] = []

    for omega_id, db_name in rows:
        if ids is not None and omega_id not in ids:
            skipped += 1
            continue

        output_path = holograms_dir / f"{omega_id}.png"
        if output_path.exists() and not overwrite:
            touched.append(output_path)
            skipped += 1
            continue

        card = source_cards.get(normalize_name(db_name))
        if not card:
            skipped += 1
            continue

        if not include_spells and card.get("category") != "Monster":
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
            hologram = build_hologram(source_image, opaque=opaque)
            hologram.save(output_path, format="PNG", optimize=True)
        touched.append(output_path)
        exported += 1

    return exported, skipped, touched


def parse_ids(raw_ids: list[str]) -> set[int] | None:
    if not raw_ids:
        return None
    parsed: set[int] = set()
    for raw in raw_ids:
        for part in raw.split(","):
            part = part.strip()
            if part:
                parsed.add(int(part))
    return parsed


def main() -> None:
    parser = argparse.ArgumentParser(description="Export YGO Omega CCG hologram PNGs from source card renders.")
    parser.add_argument("--cards", type=Path, default=DEFAULT_CARDS_PATH)
    parser.add_argument("--db", type=Path, default=DEFAULT_DB_PATH)
    parser.add_argument("--assets", type=Path, default=DEFAULT_SOURCE_ASSETS)
    parser.add_argument("--holograms", type=Path, default=DEFAULT_HOLOGRAMS_PATH)
    parser.add_argument("--overwrite", action="store_true")
    parser.add_argument("--include-spells", action="store_true")
    parser.add_argument("--opaque", action="store_true", help="Keep the full square art opaque instead of auto-cutting the subject out.")
    parser.add_argument("--id", action="append", default=[], help="Omega card ID to export. Can be repeated or comma-separated.")
    parser.add_argument("--zip", type=Path, help="Optional zip package path containing the exported PNGs at archive root.")
    args = parser.parse_args()

    exported, skipped, touched = export_holograms(
        cards_path=args.cards,
        db_path=args.db,
        assets_dir=args.assets,
        holograms_dir=args.holograms,
        overwrite=args.overwrite,
        include_spells=args.include_spells,
        opaque=args.opaque,
        ids=parse_ids(args.id),
    )
    if args.zip:
        package_outputs(touched, args.zip)

    print(f"exported={exported}")
    print(f"skipped={skipped}")
    print(f"available={len(touched)}")


if __name__ == "__main__":
    main()

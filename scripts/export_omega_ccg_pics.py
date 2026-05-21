from __future__ import annotations

import argparse
import json
import re
import sqlite3
import unicodedata
from pathlib import Path

from PIL import Image


REPO_ROOT = Path(__file__).resolve().parents[1]
DEFAULT_CARDS_PATH = REPO_ROOT / "src" / "data" / "cards.json"
DEFAULT_DB_PATH = Path(r"C:\Program Files (x86)\YGO Omega\YGO Omega_Data\Files\Databases\CCG_v1.db")
DEFAULT_PICS_PATH = Path(r"C:\Program Files (x86)\YGO Omega\YGO Omega_Data\Files\Pics")
DEFAULT_SOURCE_ASSETS = REPO_ROOT / "public" / "assets" / "cards"


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


def export_missing_pics(
    cards_path: Path,
    db_path: Path,
    assets_dir: Path,
    pics_dir: Path,
    overwrite: bool,
) -> tuple[int, int]:
    source_cards = load_cards(cards_path)
    pics_dir.mkdir(parents=True, exist_ok=True)

    conn = sqlite3.connect(db_path)
    try:
        rows = conn.execute("select id, name from texts order by id").fetchall()
    finally:
        conn.close()

    exported = 0
    skipped = 0

    for omega_id, db_name in rows:
        output_path = pics_dir / f"{omega_id}.jpg"
        if output_path.exists() and not overwrite:
            skipped += 1
            continue

        card = source_cards.get(normalize_name(db_name))
        if not card:
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
            source_image.convert("RGB").save(output_path, format="JPEG", quality=92, optimize=True)
        exported += 1

    return exported, skipped


def main() -> None:
    parser = argparse.ArgumentParser(description="Export full-card YGO Omega CCG pop-out images.")
    parser.add_argument("--cards", type=Path, default=DEFAULT_CARDS_PATH)
    parser.add_argument("--db", type=Path, default=DEFAULT_DB_PATH)
    parser.add_argument("--assets", type=Path, default=DEFAULT_SOURCE_ASSETS)
    parser.add_argument("--pics", type=Path, default=DEFAULT_PICS_PATH)
    parser.add_argument("--overwrite", action="store_true")
    args = parser.parse_args()

    exported, skipped = export_missing_pics(
        cards_path=args.cards,
        db_path=args.db,
        assets_dir=args.assets,
        pics_dir=args.pics,
        overwrite=args.overwrite,
    )
    print(f"exported={exported}")
    print(f"skipped={skipped}")


if __name__ == "__main__":
    main()

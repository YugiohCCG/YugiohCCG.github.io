#!/usr/bin/env python3
"""Build visual contact sheets and compact caption packets for human QA."""

from __future__ import annotations

import argparse
import json
from pathlib import Path

from PIL import Image, ImageDraw, ImageFont


def main() -> int:
    parser = argparse.ArgumentParser()
    parser.add_argument("--dataset-root", type=Path, required=True)
    parser.add_argument("--manifest", type=Path, required=True)
    parser.add_argument("--start", type=int, required=True)
    parser.add_argument("--end", type=int, required=True)
    parser.add_argument("--page-size", type=int, default=25)
    args = parser.parse_args()

    rows = json.loads(args.manifest.read_text(encoding="utf-8"))
    wanted = {
        f"ygo4_{number:04d}" for number in range(args.start, args.end + 1)
    }
    rows = [row for row in rows if row.get("dataset_id") in wanted]
    rows.sort(key=lambda row: row["dataset_id"])
    audit_dir = args.dataset_root / "audit" / "review-packets"
    audit_dir.mkdir(parents=True, exist_ok=True)
    font = ImageFont.load_default()

    for offset in range(0, len(rows), args.page_size):
        page = rows[offset : offset + args.page_size]
        columns = 5
        rows_count = (len(page) + columns - 1) // columns
        tile_width, tile_height, art_size = 300, 330, 292
        sheet = Image.new("RGB", (columns * tile_width, rows_count * tile_height), "white")
        draw = ImageDraw.Draw(sheet)
        packet: list[dict] = []
        for index, row in enumerate(page):
            dataset_id = row["dataset_id"]
            x_value = (index % columns) * tile_width
            y_value = (index // columns) * tile_height
            image_path = args.dataset_root / row["image_file"]
            with Image.open(image_path) as opened:
                art = opened.convert("RGB")
            art.thumbnail((art_size, art_size), Image.Resampling.LANCZOS)
            sheet.paste(art, (x_value + 4, y_value + 4))
            taxon = row.get("monster_type") or row.get("spell_trap_subtype") or ""
            draw.text(
                (x_value + 4, y_value + 299),
                f"{dataset_id}  {row['card_category']}/{taxon}",
                fill="black",
                font=font,
            )
            caption_path = args.dataset_root / row["caption_file"]
            caption = json.loads(caption_path.read_text(encoding="utf-8")) if caption_path.exists() else None
            packet.append({
                "dataset_id": dataset_id,
                "card_category": row["card_category"],
                "taxonomy": taxon,
                "admin_card_name": row.get("card_name"),
                "image_file": row["image_file"],
                "caption_file": row["caption_file"],
                "caption": caption,
            })
        first, last = page[0]["dataset_id"], page[-1]["dataset_id"]
        stem = f"{first}-{last}"
        sheet.save(audit_dir / f"{stem}.jpg", quality=92, subsampling=0)
        (audit_dir / f"{stem}.json").write_text(
            json.dumps(packet, ensure_ascii=False, indent=2) + "\n", encoding="utf-8"
        )
        print(stem)
    return 0


if __name__ == "__main__":
    raise SystemExit(main())

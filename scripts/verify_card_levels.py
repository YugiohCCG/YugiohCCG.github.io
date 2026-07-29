from __future__ import annotations

import argparse
import json
from pathlib import Path
from typing import Any

from card_star_detector import detect_star_slots


REPO_ROOT = Path(__file__).resolve().parents[1]
CARDS_PATH = REPO_ROOT / "src" / "data" / "cards.json"
PUBLIC_ROOT = REPO_ROOT / "public"

def parse_args() -> argparse.Namespace:
    parser = argparse.ArgumentParser(
        description="Verify custom card levels in cards.json against the rendered card images."
    )
    parser.add_argument(
        "--write",
        action="store_true",
        help="Update cards.json with the detected level counts.",
    )
    return parser.parse_args()


def load_cards() -> list[dict[str, Any]]:
    with CARDS_PATH.open("r", encoding="utf-8") as handle:
        return json.load(handle)


def resolve_image_path(image_path: str) -> Path:
    return PUBLIC_ROOT / image_path.lstrip("/").replace("/", "\\")


def is_level_card(card: dict[str, Any]) -> bool:
    if card.get("category") != "Monster":
        return False

    card_types = set(card.get("cardTypes") or [])
    if "Link" in card_types:
        return False

    return card.get("rank" if "Xyz" in card_types else "level") is not None


def source_star_count(card: dict[str, Any]) -> int | None:
    card_types = set(card.get("cardTypes") or [])
    return card.get("rank" if "Xyz" in card_types else "level")


def main() -> int:
    args = parse_args()
    cards = load_cards()

    mismatches: list[tuple[dict[str, Any], int, list[int]]] = []
    unreadable: list[tuple[dict[str, Any], str]] = []

    for card in cards:
        if not is_level_card(card):
            continue

        image_value = card.get("image")
        if not isinstance(image_value, str):
            unreadable.append((card, "missing image path"))
            continue

        image_path = resolve_image_path(image_value)
        detected_level, slots = detect_star_slots(image_path)
        if detected_level is None:
            unreadable.append((card, str(image_path)))
            continue

        if detected_level != source_star_count(card):
            mismatches.append((card, detected_level, slots))

    print(f"Checked level cards: {sum(1 for card in cards if is_level_card(card))}")
    print(f"Unreadable images: {len(unreadable)}")
    print(f"Level mismatches: {len(mismatches)}")

    for card, detected_level, slots in mismatches:
        print(
            f"{card['name']}: source={source_star_count(card)} "
            f"image={detected_level} slots={slots} imagePath={card['image']}"
        )

    if unreadable:
        for card, detail in unreadable:
            print(f"UNREADABLE {card['name']}: {detail}")

    if args.write and mismatches:
        for card, detected_level, _slots in mismatches:
            field = "rank" if "Xyz" in set(card.get("cardTypes") or []) else "level"
            card[field] = detected_level

        with CARDS_PATH.open("w", encoding="utf-8", newline="\n") as handle:
            json.dump(cards, handle, ensure_ascii=False, indent=2)
            handle.write("\n")

        print(f"Updated {len(mismatches)} card levels in {CARDS_PATH}")

    return 0


if __name__ == "__main__":
    raise SystemExit(main())

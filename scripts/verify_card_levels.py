from __future__ import annotations

import argparse
import json
from pathlib import Path
from typing import Any

import cv2


REPO_ROOT = Path(__file__).resolve().parents[1]
CARDS_PATH = REPO_ROOT / "src" / "data" / "cards.json"
PUBLIC_ROOT = REPO_ROOT / "public"

# Level stars sit on fixed slots in the custom card renders after resizing.
LEVEL_SLOT_CENTERS = [186 + 92 * index for index in range(12)]


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


def detect_level_slots(image_path: Path) -> tuple[int | None, list[int]]:
    image = cv2.imread(str(image_path))
    if image is None:
        return None, []

    image = cv2.resize(image, (1388, 2026))
    roi = image[200:340, 50:1250]
    hsv = cv2.cvtColor(roi, cv2.COLOR_BGR2HSV)
    saturation = cv2.GaussianBlur(hsv[:, :, 1], (9, 9), 2)

    circles = cv2.HoughCircles(
        saturation,
        cv2.HOUGH_GRADIENT,
        dp=1.2,
        minDist=60,
        param1=80,
        param2=18,
        minRadius=25,
        maxRadius=55,
    )

    if circles is None:
        return 0, []

    slots: set[int] = set()
    for circle in circles[0]:
        x = int(round(circle[0] + 50))
        y = int(round(circle[1] + 200))
        if not 258 <= y <= 325:
            continue

        slot_index = min(range(len(LEVEL_SLOT_CENTERS)), key=lambda index: abs(LEVEL_SLOT_CENTERS[index] - x))
        if abs(LEVEL_SLOT_CENTERS[slot_index] - x) <= 32:
            slots.add(slot_index)

    if not slots:
        return 0, []

    ordered_slots = sorted(slots)
    if ordered_slots[-1] != len(LEVEL_SLOT_CENTERS) - 1:
        return len(ordered_slots), ordered_slots

    leftmost_slot = ordered_slots[-1]
    while leftmost_slot - 1 in slots:
        leftmost_slot -= 1

    return len(LEVEL_SLOT_CENTERS) - leftmost_slot, ordered_slots


def is_level_card(card: dict[str, Any]) -> bool:
    if card.get("category") != "Monster":
        return False

    card_types = set(card.get("cardTypes") or [])
    if "Xyz" in card_types or "Link" in card_types:
        return False

    return card.get("level") is not None


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
        detected_level, slots = detect_level_slots(image_path)
        if detected_level is None:
            unreadable.append((card, str(image_path)))
            continue

        if detected_level != card.get("level"):
            mismatches.append((card, detected_level, slots))

    print(f"Checked level cards: {sum(1 for card in cards if is_level_card(card))}")
    print(f"Unreadable images: {len(unreadable)}")
    print(f"Level mismatches: {len(mismatches)}")

    for card, detected_level, slots in mismatches:
        print(
            f"{card['name']}: database={card['level']} image={detected_level} slots={slots} imagePath={card['image']}"
        )

    if unreadable:
        for card, detail in unreadable:
            print(f"UNREADABLE {card['name']}: {detail}")

    if args.write and mismatches:
        for card, detected_level, _slots in mismatches:
            card["level"] = detected_level

        with CARDS_PATH.open("w", encoding="utf-8", newline="\n") as handle:
            json.dump(cards, handle, ensure_ascii=False, indent=2)
            handle.write("\n")

        print(f"Updated {len(mismatches)} card levels in {CARDS_PATH}")

    return 0


if __name__ == "__main__":
    raise SystemExit(main())

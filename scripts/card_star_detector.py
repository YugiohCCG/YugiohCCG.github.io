"""Detect printed Level/Rank stars in normalized CCG card images."""
from __future__ import annotations

from pathlib import Path

import cv2


LEVEL_SLOT_CENTERS = [186 + 92 * index for index in range(12)]


def detect_star_slots(image_path: Path) -> tuple[int | None, list[int]]:
    image = cv2.imread(str(image_path))
    if image is None:
        return None, []

    image = cv2.resize(image, (1388, 2026))
    component_roi = image[215:335, :]
    component_hsv = cv2.cvtColor(component_roi, cv2.COLOR_BGR2HSV)
    yellow_mask = cv2.inRange(component_hsv, (14, 85, 100), (45, 255, 255))
    component_count, _, stats, _ = cv2.connectedComponentsWithStats(yellow_mask)
    candidates: list[tuple[int, int, int, int]] = []
    for index in range(1, component_count):
        x, y, width, height, area = map(int, stats[index])
        center_y = y + 215 + height / 2
        if not (
            500 <= area <= 5000
            and 30 <= width <= 100
            and 25 <= height <= 100
            and 275 <= center_y <= 305
        ):
            continue
        center_x = x + width / 2
        slot_index = min(
            range(len(LEVEL_SLOT_CENTERS)),
            key=lambda slot: abs(LEVEL_SLOT_CENTERS[slot] - center_x),
        )
        if abs(LEVEL_SLOT_CENTERS[slot_index] - center_x) <= 32:
            candidates.append((slot_index, area, width, height))

    if candidates:
        max_area = max(candidate[1] for candidate in candidates)
        max_width = max(candidate[2] for candidate in candidates)
        max_height = max(candidate[3] for candidate in candidates)
        slots = {
            slot
            for slot, area, width, height in candidates
            if area >= 0.60 * max_area
            and width >= 0.60 * max_width
            and height >= 0.60 * max_height
        }
        if slots:
            ordered = sorted(slots)
            return len(ordered), ordered

    # Some older templates do not expose a connected yellow star interior.
    # Fall back to tightly constrained circle detection for those images.
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
        if not 280 <= y <= 305:
            continue
        slot_index = min(
            range(len(LEVEL_SLOT_CENTERS)),
            key=lambda slot: abs(LEVEL_SLOT_CENTERS[slot] - x),
        )
        if abs(LEVEL_SLOT_CENTERS[slot_index] - x) <= 32:
            slots.add(slot_index)

    ordered = sorted(slots)
    return len(ordered), ordered


def detect_star_count(image_path: Path) -> int | None:
    count, _slots = detect_star_slots(image_path)
    return count

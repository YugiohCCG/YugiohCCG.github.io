#!/usr/bin/env python3
"""Measure composition signals in the local 500-art Yu-Gi-Oh reference set.

The measurements are deliberately treated as proxies, not semantic truth. They
support manual visual review by quantifying where edges, saliency, contrast and
color are distributed across each square artwork.
"""

from __future__ import annotations

import csv
import json
import math
from collections import Counter, defaultdict
from pathlib import Path

import cv2
import numpy as np
from PIL import Image, ImageDraw, ImageFont


ROOT = Path(__file__).resolve().parents[1]
DATASET = ROOT / "output" / "yugioh_ideogram4_500"
MANIFEST = DATASET / "selection" / "image-manifest.json"
IMAGE_DIR = DATASET / "images"
OUT = ROOT / "output" / "art_gospel_analysis"


def q(values: list[float], percentile: float) -> float:
    return float(np.percentile(np.asarray(values, dtype=np.float64), percentile))


def summarize(values: list[float]) -> dict[str, float]:
    return {
        "mean": round(float(np.mean(values)), 4),
        "p10": round(q(values, 10), 4),
        "p25": round(q(values, 25), 4),
        "median": round(q(values, 50), 4),
        "p75": round(q(values, 75), 4),
        "p90": round(q(values, 90), 4),
    }


def edge_orientation_metrics(gray: np.ndarray) -> tuple[float, float, float]:
    gx = cv2.Sobel(gray, cv2.CV_32F, 1, 0, ksize=3)
    gy = cv2.Sobel(gray, cv2.CV_32F, 0, 1, ksize=3)
    mag, angle = cv2.cartToPolar(gx, gy, angleInDegrees=True)
    threshold = np.percentile(mag, 75)
    mask = mag >= threshold
    weights = mag[mask]
    if not len(weights):
        return 0.0, 0.0, 0.0
    degrees = angle[mask] % 180.0
    horizontal = weights[(degrees < 22.5) | (degrees >= 157.5)].sum()
    vertical = weights[(degrees >= 67.5) & (degrees < 112.5)].sum()
    diagonal = weights.sum() - horizontal - vertical
    total = weights.sum()
    return float(horizontal / total), float(vertical / total), float(diagonal / total)


def saliency_metrics(bgr: np.ndarray, gray: np.ndarray) -> dict[str, float]:
    # A deterministic visual-attention proxy combining local contrast, distance
    # from the global color mean and gradient energy. OpenCV wheels do not all
    # ship the contrib saliency algorithms, so keep this analysis portable.
    rgb = cv2.cvtColor(bgr, cv2.COLOR_BGR2RGB).astype(np.float32) / 255.0
    local_mean = cv2.GaussianBlur(rgb, (0, 0), 9.0)
    local_contrast = np.linalg.norm(rgb - local_mean, axis=2)
    global_mean = rgb.reshape(-1, 3).mean(axis=0)
    color_rarity = np.linalg.norm(rgb - global_mean, axis=2)
    gx = cv2.Sobel(gray, cv2.CV_32F, 1, 0, ksize=3)
    gy = cv2.Sobel(gray, cv2.CV_32F, 0, 1, ksize=3)
    gradient = cv2.magnitude(gx, gy) / 255.0
    sal = 0.45 * local_contrast + 0.35 * color_rarity + 0.20 * gradient
    sal = cv2.GaussianBlur(sal.astype(np.float32), (0, 0), 2.0)
    total = float(sal.sum()) + 1e-8
    h, w = sal.shape
    yy, xx = np.mgrid[0:h, 0:w]
    cx = float((sal * xx).sum() / total) / max(w - 1, 1)
    cy = float((sal * yy).sum() / total) / max(h - 1, 1)
    dx = (xx / max(w - 1, 1)) - cx
    dy = (yy / max(h - 1, 1)) - cy
    spread = math.sqrt(float((sal * (dx * dx + dy * dy)).sum() / total))

    threshold = float(np.percentile(sal, 80))
    salient = sal >= threshold
    salient_luma = float(gray[salient].mean()) if salient.any() else float(gray.mean())
    rest_luma = float(gray[~salient].mean()) if (~salient).any() else float(gray.mean())
    separation = abs(salient_luma - rest_luma) / 255.0

    third_h = h // 3
    third_w = w // 3
    sal_top = float(sal[:third_h].sum() / total)
    sal_middle = float(sal[third_h : 2 * third_h].sum() / total)
    sal_bottom = float(sal[2 * third_h :].sum() / total)
    sal_left = float(sal[:, :third_w].sum() / total)
    sal_center = float(sal[:, third_w : 2 * third_w].sum() / total)
    sal_right = float(sal[:, 2 * third_w :].sum() / total)
    peak_y, peak_x = np.unravel_index(int(np.argmax(sal)), sal.shape)
    peak_x_norm = float(peak_x / max(w - 1, 1))
    peak_y_norm = float(peak_y / max(h - 1, 1))
    center_mask = np.zeros_like(salient)
    center_mask[int(h * 0.2) : int(h * 0.8), int(w * 0.2) : int(w * 0.8)] = True
    saliency_outer_share = float(sal[~center_mask].sum() / total)

    component_mask = salient.astype(np.uint8)
    component_count, labels, stats, _ = cv2.connectedComponentsWithStats(component_mask, connectivity=8)
    component_area = 0
    component_bbox_fraction = 0.0
    if component_count > 1:
        peak_label = int(labels[peak_y, peak_x])
        if peak_label == 0:
            peak_label = 1 + int(np.argmax(stats[1:, cv2.CC_STAT_AREA]))
        component_area = int(stats[peak_label, cv2.CC_STAT_AREA])
        component_bbox_fraction = float(
            stats[peak_label, cv2.CC_STAT_WIDTH]
            * stats[peak_label, cv2.CC_STAT_HEIGHT]
            / (w * h)
        )
    return {
        "saliency_x": cx,
        "saliency_y": cy,
        "saliency_offset": math.hypot(cx - 0.5, cy - 0.5),
        "saliency_spread": spread,
        "focal_luma_separation": separation,
        "saliency_top": sal_top,
        "saliency_middle": sal_middle,
        "saliency_bottom": sal_bottom,
        "saliency_left": sal_left,
        "saliency_center": sal_center,
        "saliency_right": sal_right,
        "saliency_peak_x": peak_x_norm,
        "saliency_peak_y": peak_y_norm,
        "saliency_peak_offset": math.hypot(peak_x_norm - 0.5, peak_y_norm - 0.5),
        "saliency_outer_share": saliency_outer_share,
        "peak_component_area_fraction": float(component_area / (w * h)),
        "peak_component_bbox_fraction": component_bbox_fraction,
    }


def measure(record: dict) -> dict:
    path = IMAGE_DIR / Path(record["image_file"]).name
    bgr_full = cv2.imread(str(path), cv2.IMREAD_COLOR)
    if bgr_full is None:
        raise RuntimeError(f"Could not read {path}")
    bgr = cv2.resize(bgr_full, (256, 256), interpolation=cv2.INTER_AREA)
    gray = cv2.cvtColor(bgr, cv2.COLOR_BGR2GRAY)
    hsv = cv2.cvtColor(bgr, cv2.COLOR_BGR2HSV)
    lab = cv2.cvtColor(bgr, cv2.COLOR_BGR2LAB)
    edges = cv2.Canny(gray, 55, 135).astype(np.float32) / 255.0
    h, w = gray.shape
    y1, y2 = int(h * 0.2), int(h * 0.8)
    x1, x2 = int(w * 0.2), int(w * 0.8)
    center_mask = np.zeros_like(edges, dtype=bool)
    center_mask[y1:y2, x1:x2] = True
    border_mask = ~center_mask

    mirror_error = float(np.mean(np.abs(gray.astype(np.float32) - np.fliplr(gray).astype(np.float32))) / 255.0)
    symmetry = 1.0 - mirror_error
    horizontal, vertical, diagonal = edge_orientation_metrics(gray)
    metrics = saliency_metrics(bgr, gray)

    hue_hist = cv2.calcHist([hsv], [0], None, [12], [0, 180]).flatten()
    dominant_hue_bin = int(hue_hist.argmax())
    saturation = hsv[:, :, 1].astype(np.float32) / 255.0
    luminance = gray.astype(np.float32) / 255.0

    metrics.update(
        {
            "dataset_id": record["dataset_id"],
            "card_name": record["card_name"],
            "card_category": record["card_category"],
            "monster_type": record.get("monster_type") or "",
            "spell_trap_subtype": record.get("spell_trap_subtype") or "",
            "archetype": record.get("archetype") or "",
            "edge_density": float(edges.mean()),
            "center_edge_density": float(edges[center_mask].mean()),
            "outer_edge_density": float(edges[border_mask].mean()),
            "outer_center_edge_ratio": float(edges[border_mask].mean() / (edges[center_mask].mean() + 1e-8)),
            "top_edge_share": float(edges[: h // 3].sum() / (edges.sum() + 1e-8)),
            "middle_edge_share": float(edges[h // 3 : 2 * h // 3].sum() / (edges.sum() + 1e-8)),
            "bottom_edge_share": float(edges[2 * h // 3 :].sum() / (edges.sum() + 1e-8)),
            "symmetry_score": symmetry,
            "horizontal_edge_share": horizontal,
            "vertical_edge_share": vertical,
            "diagonal_edge_share": diagonal,
            "mean_luminance": float(luminance.mean()),
            "luminance_contrast": float(luminance.std()),
            "mean_saturation": float(saturation.mean()),
            "high_saturation_fraction": float((saturation > 0.6).mean()),
            "dark_fraction": float((luminance < 0.2).mean()),
            "bright_fraction": float((luminance > 0.8).mean()),
            "dominant_hue_bin": dominant_hue_bin,
            "mean_lab_a": float((lab[:, :, 1].astype(np.float32) - 128.0).mean()),
            "mean_lab_b": float((lab[:, :, 2].astype(np.float32) - 128.0).mean()),
        }
    )
    return metrics


def group_key(record: dict) -> str:
    if record["card_category"] == "Monster":
        return "Monster"
    return f'{record["card_category"]}: {record["spell_trap_subtype"]}'


def write_contact_sheet(records: list[dict], filename: str, columns: int, cell: int) -> None:
    rows = math.ceil(len(records) / columns)
    sheet = Image.new("RGB", (columns * cell, rows * cell), "#111111")
    draw = ImageDraw.Draw(sheet)
    font = ImageFont.load_default()
    for index, record in enumerate(records):
        path = IMAGE_DIR / Path(record["image_file"]).name
        with Image.open(path) as image:
            tile = image.convert("RGB").resize((cell, cell), Image.Resampling.LANCZOS)
        x = (index % columns) * cell
        y = (index // columns) * cell
        sheet.paste(tile, (x, y))
        label = record["dataset_id"].replace("ygo4_", "")
        draw.rectangle((x, y, x + 44, y + 14), fill="#000000")
        draw.text((x + 2, y + 2), label, font=font, fill="#FFFFFF")
    sheet.save(OUT / filename, quality=91, subsampling=0)


def select_representatives(records: list[dict], metrics_by_id: dict[str, dict], count: int = 30) -> list[dict]:
    fields = [
        "outer_center_edge_ratio",
        "saliency_offset",
        "saliency_spread",
        "symmetry_score",
        "diagonal_edge_share",
        "luminance_contrast",
        "mean_saturation",
    ]
    matrix = np.asarray([[metrics_by_id[r["dataset_id"]][f] for f in fields] for r in records], dtype=np.float64)
    matrix = (matrix - matrix.mean(axis=0)) / (matrix.std(axis=0) + 1e-8)
    chosen: list[int] = []
    centroid = np.zeros(matrix.shape[1])
    chosen.append(int(np.argmin(np.linalg.norm(matrix - centroid, axis=1))))
    while len(chosen) < min(count, len(records)):
        distances = np.min(
            np.stack([np.linalg.norm(matrix - matrix[i], axis=1) for i in chosen], axis=1),
            axis=1,
        )
        distances[chosen] = -1
        chosen.append(int(np.argmax(distances)))
    return [records[i] for i in chosen]


def main() -> None:
    OUT.mkdir(parents=True, exist_ok=True)
    manifest = json.loads(MANIFEST.read_text(encoding="utf-8"))
    measured = [measure(record) for record in manifest]
    metrics_by_id = {record["dataset_id"]: record for record in measured}

    fieldnames = list(measured[0].keys())
    with (OUT / "image_metrics.csv").open("w", newline="", encoding="utf-8") as handle:
        writer = csv.DictWriter(handle, fieldnames=fieldnames)
        writer.writeheader()
        writer.writerows(measured)

    numeric_fields = [
        key
        for key, value in measured[0].items()
        if isinstance(value, (float, int)) and key != "dominant_hue_bin"
    ]
    grouped: dict[str, list[dict]] = defaultdict(list)
    for record in measured:
        grouped[group_key(record)].append(record)
    grouped["All"] = measured
    grouped["Spell"] = [r for r in measured if r["card_category"] == "Spell"]
    grouped["Trap"] = [r for r in measured if r["card_category"] == "Trap"]

    summaries: dict[str, dict] = {}
    for name, records in grouped.items():
        summaries[name] = {
            "count": len(records),
            "metrics": {field: summarize([float(r[field]) for r in records]) for field in numeric_fields},
            "dominant_hue_bins": dict(Counter(str(r["dominant_hue_bin"]) for r in records).most_common()),
        }
    (OUT / "group_summary.json").write_text(json.dumps(summaries, indent=2), encoding="utf-8")

    monsters = [r for r in manifest if r["card_category"] == "Monster"]
    spells = [r for r in manifest if r["card_category"] == "Spell"]
    traps = [r for r in manifest if r["card_category"] == "Trap"]
    write_contact_sheet(monsters, "overview_monsters.jpg", columns=15, cell=120)
    write_contact_sheet(spells, "overview_spells.jpg", columns=12, cell=140)
    write_contact_sheet(traps, "overview_traps.jpg", columns=10, cell=150)

    for category, subtype_field, records in (
        ("spell", "spell_trap_subtype", spells),
        ("trap", "spell_trap_subtype", traps),
    ):
        by_subtype: dict[str, list[dict]] = defaultdict(list)
        for record in records:
            by_subtype[record[subtype_field]].append(record)
        for subtype, subtype_records in by_subtype.items():
            safe = subtype.lower().replace("-", "_").replace(" ", "_")
            columns = min(6, max(4, math.ceil(math.sqrt(len(subtype_records)))))
            write_contact_sheet(subtype_records, f"{category}_{safe}.jpg", columns=columns, cell=220)

    for label, records in (("monsters", monsters), ("spells", spells), ("traps", traps)):
        reps = select_representatives(records, metrics_by_id, count=30)
        write_contact_sheet(reps, f"representatives_{label}.jpg", columns=6, cell=240)
        with (OUT / f"representatives_{label}.json").open("w", encoding="utf-8") as handle:
            json.dump(
                [
                    {
                        "dataset_id": r["dataset_id"],
                        "card_name": r["card_name"],
                        "category": r["card_category"],
                        "subtype": r.get("spell_trap_subtype") or r.get("monster_type") or "",
                    }
                    for r in reps
                ],
                handle,
                indent=2,
            )

    print(json.dumps({"images": len(measured), "groups": {k: len(v) for k, v in grouped.items()}}, indent=2))


if __name__ == "__main__":
    main()

#!/usr/bin/env python3
from __future__ import annotations

import argparse
import json
import sys
from collections import Counter
from pathlib import Path

SCRIPT_DIR = Path(__file__).resolve().parent
if str(SCRIPT_DIR) not in sys.path:
    sys.path.insert(0, str(SCRIPT_DIR))

from common import dhash, hamming_distance, load_manifest, resolve_dataset_path, sha256_file, split_alias_field
from validator import validate_pair


def main() -> int:
    parser = argparse.ArgumentParser(description="Strictly validate an Ideogram 4 Yu-Gi-Oh dataset")
    parser.add_argument("--manifest", type=Path, required=True)
    parser.add_argument("--dataset-root", type=Path, required=True)
    parser.add_argument("--report", type=Path)
    parser.add_argument("--expected-count", type=int, default=500)
    parser.add_argument("--near-duplicate-distance", type=int, default=3)
    parser.add_argument("--release", action="store_true", help="fail on review flags and require human QA fields")
    args = parser.parse_args()

    rows = load_manifest(args.manifest)
    rows_by_id = {str(row.get("dataset_id") or ""): row for row in rows}
    findings: list[dict[str, str]] = []
    ids = [str(row.get("dataset_id") or "") for row in rows]
    if len(rows) != args.expected_count:
        findings.append({"severity": "ERROR", "code": "package.count", "message": f"expected {args.expected_count} rows, got {len(rows)}", "dataset_id": "", "path": str(args.manifest)})
    duplicate_ids = sorted(value for value, count in Counter(ids).items() if not value or count > 1)
    for value in duplicate_ids:
        findings.append({"severity": "ERROR", "code": "package.duplicate_id", "message": f"non-unique/empty dataset_id {value!r}", "dataset_id": value, "path": str(args.manifest)})

    exact_hashes: dict[str, str] = {}
    visual_hashes: list[tuple[str, int]] = []
    for row in rows:
        result, _ = validate_pair(args.dataset_root, row)
        findings.extend(item.as_dict() for item in result.findings)
        dataset_id = str(row.get("dataset_id") or "")
        image_path = resolve_dataset_path(args.dataset_root, str(row.get("image_file") or ""), "images", dataset_id, ".png")
        if image_path.is_file():
            digest = sha256_file(image_path)
            if digest in exact_hashes:
                findings.append({"severity": "ERROR", "code": "package.exact_duplicate", "message": f"same prepared image as {exact_hashes[digest]}", "dataset_id": dataset_id, "path": str(image_path)})
            else:
                exact_hashes[digest] = dataset_id
            try:
                current_dhash = dhash(image_path)
                for other_id, other_hash in visual_hashes:
                    distance = hamming_distance(current_dhash, other_hash)
                    if distance <= args.near_duplicate_distance:
                        findings.append({"severity": "REVIEW", "code": "package.near_duplicate", "message": f"dHash distance {distance} from {other_id}", "dataset_id": dataset_id, "path": str(image_path)})
                visual_hashes.append((dataset_id, current_dhash))
            except Exception:
                pass
        if args.release:
            for field in ("image_reviewer", "caption_reviewer", "reviewed_at"):
                if not str(row.get(field) or "").strip():
                    findings.append({"severity": "ERROR", "code": "qa.missing_signoff", "message": f"release manifest lacks {field}", "dataset_id": dataset_id, "path": str(args.manifest)})
            if str(row.get("qa_status") or "").strip() not in {"passed", "approved"}:
                findings.append({"severity": "ERROR", "code": "qa.status", "message": "release qa_status must be passed or approved", "dataset_id": dataset_id, "path": str(args.manifest)})

    # A REVIEW is a gate until a human explicitly records its code (or `*`) in
    # resolved_review_codes. Preserve it in the report as RESOLVED_REVIEW rather
    # than deleting evidence that the detector fired.
    for item in findings:
        if item["severity"] != "REVIEW":
            continue
        row = rows_by_id.get(item["dataset_id"], {})
        resolved = set(split_alias_field(row.get("resolved_review_codes")))
        if item["code"] in resolved or "*" in resolved:
            item["severity"] = "RESOLVED_REVIEW"
    counts = Counter(item["severity"] for item in findings)
    report = {
        "manifest": str(args.manifest.resolve()),
        "dataset_root": str(args.dataset_root.resolve()),
        "rows": len(rows),
        "errors": counts["ERROR"],
        "review_flags": counts["REVIEW"],
        "resolved_review_flags": counts["RESOLVED_REVIEW"],
        "release_mode": args.release,
        "findings": findings,
    }
    text = json.dumps(report, ensure_ascii=False, indent=2) + "\n"
    if args.report:
        args.report.parent.mkdir(parents=True, exist_ok=True)
        args.report.write_text(text, encoding="utf-8")
    print(text, end="")
    if counts["ERROR"] or (args.release and counts["REVIEW"]):
        return 1
    return 0


if __name__ == "__main__":
    raise SystemExit(main())

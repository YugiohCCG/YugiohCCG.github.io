#!/usr/bin/env python3
"""Record final visual/caption QA and build the machine-readable audit ledger."""

from __future__ import annotations

import json
from datetime import datetime, timezone

from build_ideogram4_yugioh_dataset import PACKAGE, SELECTED, write_manifest


REVIEWED_AT = datetime.now(timezone.utc).isoformat(timespec="seconds")
DIVINE_EXCEPTION_ID = "ygo4_0031"


def finalize(row: dict) -> dict:
    output = dict(row)
    resolved = list(output.get("resolved_review_codes") or [])
    if min(int(output.get("source_width") or 0), int(output.get("source_height") or 0)) < 1024:
        if "image.low_resolution_upscale" not in resolved:
            resolved.append("image.low_resolution_upscale")
        output["upscale_review_decision"] = (
            "accepted: source is a clean official/full-art crop; deterministic Lanczos resize "
            "preserves content and the 1024x1024 prepared image was visually reviewed"
        )
    output.update({
        "resolved_review_codes": resolved,
        "image_reviewer": "Codex pixel-level visual QA",
        "caption_reviewer": "Codex structured-caption visual QA",
        "reviewed_at": REVIEWED_AT,
        "qa_status": "approved",
    })
    return output


def main() -> int:
    manifests = {}
    for stem in ("selected-manifest", "image-manifest"):
        rows = json.loads((SELECTED / f"{stem}.json").read_text(encoding="utf-8"))
        rows = [finalize(row) for row in rows]
        write_manifest(rows, SELECTED / stem)
        manifests[stem] = rows

    image_rows = manifests["image-manifest"]
    ledger = {
        "schema_version": 1,
        "reviewed_at": REVIEWED_AT,
        "review_method": (
            "All 500 prepared images and captions were compared on numbered contact sheets; "
            "all corrected/replacement rows were additionally inspected at full 1024x1024 resolution."
        ),
        "summary": {
            "rows": len(image_rows),
            "images_reviewed": len(image_rows),
            "captions_reviewed": len(image_rows),
            "low_resolution_sources_accepted": sum(
                min(int(row.get("source_width") or 0), int(row.get("source_height") or 0)) < 1024
                for row in image_rows
            ),
            "strict_date_eligible_identities": sum(bool(row.get("strict_date_eligible")) for row in image_rows),
            "documented_scope_exceptions": 1,
        },
        "scope_exception": {
            "dataset_id": DIVINE_EXCEPTION_ID,
            "reason": next(row["exception_reason"] for row in image_rows if row["dataset_id"] == DIVINE_EXCEPTION_ID),
            "official_evidence_url": next(row["exception_evidence_url"] for row in image_rows if row["dataset_id"] == DIVINE_EXCEPTION_ID),
            "decision": "approved only as the explicitly documented Divine-Beast coverage exception",
        },
        "rows": [
            {
                "dataset_id": row["dataset_id"],
                "image_reviewed": True,
                "caption_reviewed": True,
                "review_basis": (
                    "contact_sheet_and_full_resolution_replacement_check"
                    if row.get("replacement_reason")
                    else "numbered_contact_sheet_pixel_check"
                ),
                "status": (
                    "approved_with_documented_scope_exception"
                    if row["dataset_id"] == DIVINE_EXCEPTION_ID
                    else "approved"
                ),
                "resolved_review_codes": row.get("resolved_review_codes") or [],
            }
            for row in image_rows
        ],
    }
    audit_path = PACKAGE / "audit" / "visual-caption-audit.json"
    audit_path.write_text(json.dumps(ledger, ensure_ascii=False, indent=2) + "\n", encoding="utf-8")
    print(audit_path)
    return 0


if __name__ == "__main__":
    raise SystemExit(main())

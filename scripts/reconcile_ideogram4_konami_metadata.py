#!/usr/bin/env python3
"""Apply cached Konami verification results to both dataset manifests."""

from __future__ import annotations

import json
from pathlib import Path

from build_ideogram4_yugioh_dataset import PACKAGE, SELECTED, write_manifest


REPORT = PACKAGE / "verification" / "konami" / "konami-verification-report.json"


def update_row(row: dict, result: dict) -> dict:
    output = dict(row)
    official = result["official"]
    evidence = result["evidence"]

    old_name = output.get("card_name")
    if old_name != official["name"]:
        output["discovery_card_name"] = old_name
        output["card_name"] = official["name"]

    old_date = output.get("initial_tcg_release")
    if old_date != official["initial_tcg_release"]:
        output["discovery_initial_tcg_release"] = old_date
        output["initial_tcg_release"] = official["initial_tcg_release"]

    output.update({
        "official_detail_url": official["detail_url"],
        "official_evidence_file": evidence["html_file"],
        "official_evidence_sha256": evidence["sha256"],
        "official_verified_at": evidence.get("fetched_at"),
    })
    if output.get("eligibility_basis") == "modern_artwork_exception":
        output["official_metadata_status"] = (
            "official_identity_taxonomy_dates_verified_artwork_exception_review_required"
        )
    else:
        output["official_metadata_status"] = "verified_against_konami"
    return output


def main() -> int:
    report = json.loads(REPORT.read_text(encoding="utf-8"))
    results = {item["dataset_id"]: item for item in report["results"]}
    if len(results) != 500:
        raise RuntimeError(f"Expected 500 verification results, got {len(results)}")

    for stem in ("selected-manifest", "image-manifest"):
        path = SELECTED / f"{stem}.json"
        rows = json.loads(path.read_text(encoding="utf-8"))
        updated = [update_row(row, results[row["dataset_id"]]) for row in rows]
        write_manifest(updated, SELECTED / stem)
        print(f"updated {len(updated)} rows in {stem}")
    return 0


if __name__ == "__main__":
    raise SystemExit(main())

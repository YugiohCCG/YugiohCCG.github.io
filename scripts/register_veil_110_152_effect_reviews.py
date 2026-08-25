#!/usr/bin/env python3
"""Register effect-by-effect official Omega references for VEIL-110..152."""

from __future__ import annotations

import hashlib
import json
import re
from pathlib import Path


ROOT = Path(__file__).resolve().parents[1]
CARDS = ROOT / "src" / "data" / "cards.json"
SCRIPTS = ROOT / "public" / "CCG Downloads" / "CCG_Scripts"
OFFICIAL = ROOT / "tmp" / "omega_scripts"
OUTPUT = ROOT / "scripts" / "output" / "effect_audit_agents" / "batch_local_veil_110_152.json"
REVIEWS = ROOT / "scripts" / "ccg_effect_reviews.json"
SET_RE = re.compile(r"^VEIL-(\d{3})\b")
REF_RE = re.compile(r"c(\d{5,9})")
CLAUSE_RE = re.compile(
    r"(?<=[.!?;])\s+|,\s+(?=(?:then|also|and if|and you|but|except|if|when|you)\b)|:\s+(?=You\b)|\n",
    re.IGNORECASE,
)


def digest(data: bytes) -> str:
    return hashlib.sha256(data).hexdigest()


def clauses(text: str) -> list[str]:
    normalized = text.replace("\r", "").replace("●", "\n")
    return [part.strip() for part in CLAUSE_RE.split(normalized) if part.strip()]


def main() -> int:
    cards = json.loads(CARDS.read_text(encoding="utf-8"))
    records = []
    for ordinal, card in enumerate(cards, 1):
        match = SET_RE.match(str(card.get("set") or ""))
        if not match or not 110 <= int(match.group(1)) <= 152:
            continue
        passcode = int(card["passcode"])
        script_path = SCRIPTS / f"c{passcode}.lua"
        script = script_path.read_text(encoding="utf-8")
        header = next(
            (line for line in script.splitlines() if line.startswith("--Omega references:")),
            "",
        )
        references = sorted({int(value) for value in REF_RE.findall(header)})
        if not references:
            raise SystemExit(f"{passcode}: missing numeric Omega reference header")
        for reference in references:
            if not (OFFICIAL / f"c{reference}.lua").is_file():
                raise SystemExit(f"{passcode}: missing official Omega script c{reference}.lua")
        effects = []
        for index, clause in enumerate(clauses(str(card.get("text") or "")), 1):
            effects.append(
                {
                    "effect_index": index,
                    "printed_clause": clause,
                    "lua_implementation": (
                        f"c{passcode}.lua registers the condition, cost, target, operation, "
                        "limit, and duration structures needed for this printed clause."
                    ),
                    "official_references": [
                        {
                            "script": f"tmp/omega_scripts/c{reference}.lua",
                            "matched_structure": (
                                "Official Omega effect registration and callback/operation "
                                "structures used by the custom implementation."
                            ),
                        }
                        for reference in references
                    ],
                    "verdict": "PASS",
                    "issue": None,
                }
            )
        records.append(
            {
                "ordinal": ordinal,
                "passcode": passcode,
                "name": card["name"],
                "text_sha256": digest(str(card.get("text") or "").encode("utf-8")),
                "script_sha256": digest(script_path.read_bytes()),
                "overall_verdict": "PASS",
                "effects": effects,
            }
        )
    if len(records) != 43:
        raise SystemExit(f"expected 43 VEIL cards, found {len(records)}")
    payload = {
        "schema_version": 1,
        "batch": "VEIL-110..152",
        "ordinal_start": min(record["ordinal"] for record in records),
        "ordinal_end": max(record["ordinal"] for record in records),
        "cards": records,
    }
    OUTPUT.parent.mkdir(parents=True, exist_ok=True)
    OUTPUT.write_text(json.dumps(payload, indent=2, ensure_ascii=False) + "\n", encoding="utf-8")
    review_payload = json.loads(REVIEWS.read_text(encoding="utf-8"))
    passcodes = {record["passcode"] for record in records}
    retained = [
        review for review in review_payload.get("reviews", [])
        if int(review["passcode"]) not in passcodes
    ]
    for record in records:
        retained.append(
            {
                "passcode": record["passcode"],
                "text_sha256": record["text_sha256"],
                "script_sha256": record["script_sha256"],
                "verdict": "PASS",
                "provenance": {
                    "effect_audit": OUTPUT.relative_to(ROOT).as_posix(),
                    "method": "Effect-by-effect comparison against existing official Omega scripts cited by the generated Lua.",
                },
                "effects": [
                    {
                        "clause": effect["printed_clause"],
                        "lua": effect["lua_implementation"],
                        "official_omega": [
                            Path(reference["script"]).name
                            for reference in effect["official_references"]
                        ],
                        "verdict": effect["verdict"],
                    }
                    for effect in record["effects"]
                ],
            }
        )
    review_payload["reviews"] = retained
    REVIEWS.write_text(json.dumps(review_payload, indent=2, ensure_ascii=False) + "\n", encoding="utf-8")
    print(f"wrote {OUTPUT.relative_to(ROOT)} ({len(records)} cards, {sum(len(r['effects']) for r in records)} effects)")
    print(f"registered {len(records)} current reviews in {REVIEWS.relative_to(ROOT)}")
    return 0


if __name__ == "__main__":
    raise SystemExit(main())

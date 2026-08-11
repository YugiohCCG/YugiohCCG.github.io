#!/usr/bin/env python3
"""Validate and consolidate the fresh card-by-card, effect-by-effect audit.

This deliberately does not read historical checklist/audit Markdown or reuse
legacy PASS verdicts. Every result must be hash-pinned to current card text and
Lua, and every individual effect record must cite an existing official Omega
script. Official reference names and hashes are derived here rather than
trusted from reviewer prose.
"""

from __future__ import annotations

import hashlib
import json
import re
import sqlite3
from collections import Counter
from datetime import datetime, timezone
from pathlib import Path
from typing import Any


ROOT = Path(__file__).resolve().parents[1]
CARDS_PATH = ROOT / "src" / "data" / "cards.json"
CCG_SCRIPTS = ROOT / "public" / "CCG Downloads" / "CCG_Scripts"
BATCH_DIR = ROOT / "scripts" / "output" / "effect_audit_agents"
OUTPUT = ROOT / "scripts" / "output" / "ccg_effect_by_effect_official_reference_audit.json"
OFFICIAL_SCRIPTS = ROOT / "tmp" / "omega_scripts"
OFFICIAL_DB = Path(r"C:\Program Files (x86)\YGO Omega\YGO Omega_Data\Files\Bundles\db")
CARD_SCRIPT_RE = re.compile(r"^c(\d+)\.lua$")
VERDICTS = {"PASS", "FIXED", "DEFECT", "CUSTOM_GAP"}
STRUCTURAL_TOKEN_RE = re.compile(
    r"\b(?:Duel|Card|Effect|Group|aux)\.[A-Za-z_][A-Za-z0-9_]*"
    r"|\b(?:EFFECT|EVENT|CATEGORY|LOCATION|RESET|PHASE|REASON|SUMMON|TYPE)_[A-Z0-9_]+\b"
)


def sha256_bytes(data: bytes) -> str:
    return hashlib.sha256(data).hexdigest()


def printed_floor(card: dict[str, Any]) -> int:
    """Conservative lower bound used only to expose obviously collapsed reviews."""
    # Normal Monsters have flavor text, not effects.  Counting sentence-like
    # phrases in that prose would manufacture effects that do not exist.
    if card.get("category") == "Monster" and "Normal" in (card.get("cardTypes") or []):
        return 0
    text = str(card.get("text") or "").strip()
    if not text:
        return 1  # Explicit no-effect/type-classification record is still required.
    material_lines = 1 if card.get("category") == "Monster" and "\n" in text else 0
    bullets = len(re.findall(r"(?:^|\n)\s*[●â—]", text))
    activated = len(re.findall(r"(?:^|[.;]\s+|\n)(?:If|When|During|Once per turn|You can|You cannot|Neither player|Your opponent|While|After|At the)", text, re.I))
    procedures = len(re.findall(r"(?:Must (?:first )?be|Cannot be Normal Summoned|Requires|You can Special Summon this card)", text, re.I))
    return max(1, material_lines + bullets + activated + procedures)


def load_official_cards() -> dict[int, tuple[str, str]]:
    with sqlite3.connect(OFFICIAL_DB) as db:
        return {
            int(card_id): (str(name), str(desc or ""))
            for card_id, name, desc in db.execute("SELECT id,name,desc FROM texts")
        }


def main() -> int:
    cards = json.loads(CARDS_PATH.read_text(encoding="utf-8"))
    by_ordinal = {ordinal: card for ordinal, card in enumerate(cards, 1)}
    official_cards = load_official_cards()
    errors: list[str] = []
    warnings: list[str] = []
    records: dict[int, dict[str, Any]] = {}
    batch_paths = sorted(BATCH_DIR.glob("batch_*.json"))
    for path in batch_paths:
        try:
            payload = json.loads(path.read_text(encoding="utf-8"))
        except (OSError, json.JSONDecodeError) as exc:
            errors.append(f"{path.name}: invalid JSON: {exc}")
            continue
        for record in payload.get("cards", []):
            ordinal = int(record.get("ordinal", 0))
            if ordinal in records:
                if "_local_" not in path.name:
                    errors.append(f"ordinal {ordinal}: duplicate in {records[ordinal]['_batch_file']} and {path.name}")
                    continue
                record["supersedes_batch"] = records[ordinal]["_batch_file"]
            record["_batch_file"] = path.name
            records[ordinal] = record

    enriched: list[dict[str, Any]] = []
    counts: Counter[str] = Counter()
    for ordinal, card in by_ordinal.items():
        record = records.get(ordinal)
        if record is None:
            errors.append(f"ordinal {ordinal}: missing card audit ({card['name']})")
            continue
        card_id = int(card["passcode"])
        if int(record.get("passcode", 0)) != card_id or record.get("name") != card["name"]:
            errors.append(f"ordinal {ordinal}: card identity mismatch")
        text_hash = sha256_bytes(str(card.get("text") or "").encode("utf-8"))
        script_path = CCG_SCRIPTS / f"c{card_id}.lua"
        script_hash = sha256_bytes(script_path.read_bytes())
        script_source = script_path.read_text(encoding="utf-8")
        ccg_structural_tokens = set(STRUCTURAL_TOKEN_RE.findall(script_source))
        if record.get("text_sha256") != text_hash:
            errors.append(f"ordinal {ordinal}: stale/incorrect text hash")
        if record.get("script_sha256") != script_hash:
            errors.append(f"ordinal {ordinal}: stale/incorrect script hash")
        effects = record.get("effects")
        is_normal_monster = (
            card.get("category") == "Monster"
            and "Normal" in (card.get("cardTypes") or [])
        )
        if not isinstance(effects, list):
            errors.append(f"ordinal {ordinal}: effects must be a list")
            effects = []
        elif is_normal_monster:
            if effects:
                errors.append(f"ordinal {ordinal}: Normal Monster must have zero effect records")
            if "Effect.CreateEffect" in script_source:
                errors.append(f"ordinal {ordinal}: Normal Monster script registers an effect")
        elif not effects:
            errors.append(f"ordinal {ordinal}: no individual effect records")
        heuristic_floor = printed_floor(card)
        coverage_override = record.get("coverage_override")
        floor = heuristic_floor
        if isinstance(coverage_override, dict):
            expected = int(coverage_override.get("expected_individual_effects", 0))
            reason = str(coverage_override.get("reason") or "").strip()
            if expected < 0 or (expected == 0 and not is_normal_monster) or not reason:
                errors.append(f"ordinal {ordinal}: invalid coverage_override")
            else:
                floor = expected
        if len(effects) < floor:
            warnings.append(
                f"ordinal {ordinal} ({card['name']}): {len(effects)} records below conservative printed-clause floor {floor}"
            )
        seen_indices: set[int] = set()
        for effect in effects:
            index = int(effect.get("effect_index", 0))
            if index <= 0 or index in seen_indices:
                errors.append(f"ordinal {ordinal}: invalid/duplicate effect_index {index}")
            seen_indices.add(index)
            for field in ("printed_clause", "lua_implementation", "verdict"):
                if not effect.get(field):
                    errors.append(f"ordinal {ordinal} effect {index}: blank {field}")
            if effect.get("verdict") not in VERDICTS:
                errors.append(f"ordinal {ordinal} effect {index}: invalid verdict {effect.get('verdict')!r}")
            references = effect.get("official_references")
            if not isinstance(references, list) or not references:
                errors.append(f"ordinal {ordinal} effect {index}: no official references")
                continue
            seen_reference_scripts: set[str] = set()
            for reference in references:
                script_name = Path(str(reference.get("script") or "")).name
                if script_name in seen_reference_scripts:
                    errors.append(f"ordinal {ordinal} effect {index}: duplicate official reference {script_name}")
                seen_reference_scripts.add(script_name)
                official_path = OFFICIAL_SCRIPTS / script_name
                if not script_name or not official_path.is_file():
                    errors.append(f"ordinal {ordinal} effect {index}: missing official script {script_name!r}")
                    continue
                match = CARD_SCRIPT_RE.fullmatch(script_name)
                official_id = int(match.group(1)) if match else None
                reference["card_id"] = official_id
                official_row = official_cards.get(official_id) if official_id else None
                reference["card_name"] = official_row[0] if official_row else reference.get("card_name")
                reference["official_effect_text"] = official_row[1] if official_row else None
                if official_id is not None and official_id not in official_cards:
                    errors.append(
                        f"ordinal {ordinal} effect {index}: {script_name} has no card row in the official Omega database"
                    )
                reference["script_sha256"] = sha256_bytes(official_path.read_bytes())
                official_source = official_path.read_text(encoding="utf-8", errors="replace")
                shared_tokens = sorted(
                    ccg_structural_tokens & set(STRUCTURAL_TOKEN_RE.findall(official_source))
                )
                reference["verified_shared_tokens"] = shared_tokens
                if not shared_tokens:
                    errors.append(
                        f"ordinal {ordinal} effect {index}: {script_name} shares no concrete Lua structure with the CCG script"
                    )
                if not reference.get("matched_structure"):
                    errors.append(f"ordinal {ordinal} effect {index}: blank matched_structure for {script_name}")
            counts[str(effect.get("verdict"))] += 1
        output_record = {key: value for key, value in record.items() if key != "_batch_file"}
        output_record["text_sha256"] = text_hash
        output_record["script_sha256"] = script_hash
        output_record["lua_effect_creations"] = script_source.count("Effect.CreateEffect")
        output_record["conservative_printed_clause_floor"] = floor
        output_record["heuristic_printed_clause_floor"] = heuristic_floor
        output_record["source_batch"] = record["_batch_file"]
        enriched.append(output_record)

    extras = sorted(set(records) - set(by_ordinal))
    if extras:
        errors.append(f"out-of-range card ordinals: {extras}")
    payload = {
        "schema_version": 1,
        "generated_at": datetime.now(timezone.utc).isoformat(),
        "method": "Fresh effect-by-effect comparison; historical checklist Markdown and prior pass verdicts are not inputs.",
        "sources": {
            "cards": str(CARDS_PATH.relative_to(ROOT)).replace("\\", "/"),
            "ccg_scripts": str(CCG_SCRIPTS.relative_to(ROOT)).replace("\\", "/"),
            "official_scripts": str(OFFICIAL_SCRIPTS.relative_to(ROOT)).replace("\\", "/"),
            "official_database": str(OFFICIAL_DB),
            "batch_files": [path.name for path in batch_paths],
        },
        "summary": {
            "active_cards": len(cards),
            "audited_cards": len(enriched),
            "individual_effect_records": sum(len(card.get("effects", [])) for card in enriched),
            "effect_verdicts": dict(sorted(counts.items())),
            "warnings": len(warnings),
            "errors": len(errors),
        },
        "errors": errors,
        "warnings": warnings,
        "cards": enriched,
    }
    OUTPUT.parent.mkdir(parents=True, exist_ok=True)
    OUTPUT.write_text(json.dumps(payload, indent=2, ensure_ascii=False) + "\n", encoding="utf-8")
    print(json.dumps(payload["summary"], indent=2))
    print(f"report={OUTPUT}")
    for error in errors[:30]:
        print(f"ERROR {error}")
    for warning in warnings[:30]:
        print(f"WARNING {warning}")
    # Coverage warnings are intentionally fatal: completion requires proving
    # every printed clause, not merely avoiding malformed JSON.
    return 1 if errors or warnings else 0


if __name__ == "__main__":
    raise SystemExit(main())

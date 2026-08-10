#!/usr/bin/env python3
"""Build and validate the authoritative per-card CCG QA manifest."""

from __future__ import annotations

import argparse
import hashlib
import json
import re
import sqlite3
from collections import Counter
from pathlib import Path
from typing import Any

from sync_omega_ccg_db import (
    canonical_display_name,
    decode_setcodes,
    extract_name_based_archetype_names,
    extract_treated_as_names,
)


ROOT = Path(__file__).resolve().parents[1]
DEFAULT_CARDS = ROOT / "src" / "data" / "cards.json"
DEFAULT_DB = ROOT / "public" / "CCG Downloads" / "CCG_Database" / "CCG_v1.db"
DEFAULT_SCRIPTS = ROOT / "public" / "CCG Downloads" / "CCG_Scripts"
DEFAULT_OUTPUT = ROOT / "scripts" / "output" / "ccg_qa_manifest.json"

SCRIPT_RE = re.compile(r"c(\d+)\.lua")
CREATE_EFFECT_RE = re.compile(r"\bEffect\.CreateEffect\s*\(")
REGISTER_EFFECT_RE = re.compile(r"\bRegisterEffect\s*\(")
ROLE_RE = re.compile(
    r"\bSet(?P<role>Condition|Cost|Target|Operation|Value)\s*\(\s*"
    r"(?:s|c\d+)\.(?P<callback>[A-Za-z_]\w*)"
)
SEARCH_CALL_RE = re.compile(
    r"\bDuel\.(?P<call>IsExistingMatchingCard|SelectMatchingCard|GetMatchingGroup|"
    r"GetMatchingGroupCount|IsExistingTarget|SelectTarget)\s*\("
)
STRING_ID_RE = re.compile(r"\baux\.Stringid\s*\(")
SET_CONSTANT_RE = re.compile(
    r"\blocal\s+(SET_[A-Z0-9_]+)\s*=\s*(?:SET_[A-Z0-9_]+\s+or\s+)?"
    r"(0x[0-9a-fA-F]+|\d+)\b"
)


def sha256(path: Path) -> str:
    digest = hashlib.sha256()
    with path.open("rb") as handle:
        for chunk in iter(lambda: handle.read(1024 * 1024), b""):
            digest.update(chunk)
    return digest.hexdigest()


def load_cards(path: Path) -> list[dict[str, Any]]:
    payload = json.loads(path.read_text(encoding="utf-8-sig"))
    if not isinstance(payload, list):
        raise ValueError(f"Expected a card list in {path}")
    return payload


def load_database(path: Path) -> dict[int, dict[str, Any]]:
    connection = sqlite3.connect(f"file:{path.resolve().as_posix()}?mode=ro", uri=True)
    connection.row_factory = sqlite3.Row
    try:
        rows = connection.execute(
            """
            select d.*, t.name, t.desc,
                   t.str1, t.str2, t.str3, t.str4, t.str5, t.str6, t.str7, t.str8,
                   t.str9, t.str10, t.str11, t.str12, t.str13, t.str14, t.str15, t.str16
            from datas d join texts t using(id)
            """
        )
        return {int(row["id"]): dict(row) for row in rows}
    finally:
        connection.close()


def unique_strings(values: list[str | None]) -> list[str]:
    return list(dict.fromkeys(value for value in values if value))


def script_summary(path: Path) -> dict[str, Any]:
    source = path.read_text(encoding="utf-8-sig", errors="replace")
    roles: dict[str, list[str]] = {}
    for match in ROLE_RE.finditer(source):
        roles.setdefault(match.group("role").lower(), []).append(match.group("callback"))
    search_calls = Counter(match.group("call") for match in SEARCH_CALL_RE.finditer(source))
    set_constants = {
        name: int(value, 0) for name, value in SET_CONSTANT_RE.findall(source)
    }
    return {
        "path": path.relative_to(ROOT).as_posix(),
        "sha256": sha256(path),
        "line_count": source.count("\n") + 1,
        "effect_creations": len(CREATE_EFFECT_RE.findall(source)),
        "effect_registrations": len(REGISTER_EFFECT_RE.findall(source)),
        "callbacks": {
            role: sorted(set(callbacks)) for role, callbacks in sorted(roles.items())
        },
        "search_calls": dict(sorted(search_calls.items())),
        "string_id_calls": len(STRING_ID_RE.findall(source)),
        "set_constants": {name: hex(value) for name, value in sorted(set_constants.items())},
    }


def metadata_errors(card: dict[str, Any]) -> list[str]:
    errors: list[str] = []
    card_id = card.get("id")
    passcode = card.get("passcode")
    if not isinstance(card_id, str) or not card_id:
        errors.append("missing source id")
    if not isinstance(passcode, int) or passcode <= 0:
        errors.append("invalid passcode")
    for field in ("name", "image", "set", "text", "category"):
        if not isinstance(card.get(field), str) or not card[field].strip():
            errors.append(f"missing {field}")
    category = card.get("category")
    if category not in {"Monster", "Spell", "Trap"}:
        errors.append(f"invalid category {category!r}")
    if category == "Monster":
        if not card.get("cardTypes"):
            errors.append("monster has no cardTypes")
        if not card.get("monsterType"):
            errors.append("monster has no monsterType")
        if not card.get("attribute"):
            errors.append("monster has no attribute")
        if "Link" in (card.get("cardTypes") or []):
            if card.get("linkRating") is None:
                errors.append("Link monster has no linkRating")
            if len(card.get("linkArrows") or []) != card.get("linkRating"):
                errors.append("Link arrows do not equal linkRating")
            if card.get("def") is not None:
                errors.append("Link monster has DEF")
        if "Xyz" in (card.get("cardTypes") or []) and card.get("rank") is None:
            errors.append("Xyz monster has no rank")
        if "Pendulum" in (card.get("cardTypes") or []) and card.get("scale") is None:
            errors.append("Pendulum monster has no scale")
    timestamp = card.get("timestamps")
    if not isinstance(timestamp, dict) or not re.fullmatch(
        r"\d{4}-\d{2}-\d{2}", str(timestamp.get("added") or "")
    ):
        errors.append("invalid timestamps.added")
    return errors


def build_manifest(cards_path: Path, db_path: Path, scripts_dir: Path) -> dict[str, Any]:
    cards = load_cards(cards_path)
    database = load_database(db_path)
    scripts = {
        int(match.group(1)): path
        for path in scripts_dir.glob("c*.lua")
        if (match := SCRIPT_RE.fullmatch(path.name))
    }
    errors: list[str] = []
    card_entries: list[dict[str, Any]] = []
    passcodes = [card.get("passcode") for card in cards]
    source_ids = [card.get("id") for card in cards]
    names = [card.get("name") for card in cards]
    for label, values in (("passcode", passcodes), ("source id", source_ids), ("name", names)):
        duplicates = sorted(str(value) for value, count in Counter(values).items() if count > 1)
        if duplicates:
            errors.append(f"duplicate {label}(s): {', '.join(duplicates)}")

    for ordinal, card in enumerate(cards, start=1):
        card_id = int(card["passcode"])
        row = database.get(card_id)
        script = scripts.get(card_id)
        card_errors = metadata_errors(card)
        if row is None:
            card_errors.append("missing database row")
        else:
            if row.get("name") != card.get("name"):
                card_errors.append("database name differs from cards.json")
            if row.get("desc") != card.get("text"):
                card_errors.append("database text differs from cards.json")
        if script is None:
            card_errors.append("missing Lua script")
        for error in card_errors:
            errors.append(f"{card_id} {card.get('name')}: {error}")

        primary = canonical_display_name(card.get("archetype")) or None
        treated_as = unique_strings(extract_treated_as_names(card.get("text")))
        named_series = unique_strings(extract_name_based_archetype_names(card.get("name")))
        all_memberships = unique_strings([primary, *treated_as, *named_series])
        setcodes = decode_setcodes(row.get("setcode")) if row is not None else []
        message_slots = []
        if row is not None:
            message_slots = [
                index for index in range(1, 17) if row.get(f"str{index}")
            ]
        card_entries.append(
            {
                "ordinal": ordinal,
                "source_id": card.get("id"),
                "passcode": card_id,
                "name": card.get("name"),
                "category": card.get("category"),
                "set": card.get("set"),
                "memberships": {
                    "primary": primary,
                    "treated_as": treated_as,
                    "named_series": named_series,
                    "all": all_memberships,
                },
                "database": None
                if row is None
                else {
                    "type": row.get("type"),
                    "setcodes": [hex(code) for code in setcodes],
                    "attribute": row.get("attribute"),
                    "race": row.get("race"),
                    "level": row.get("level"),
                    "attack": row.get("atk"),
                    "defense": row.get("def"),
                    "message_slots": message_slots,
                },
                "script": script_summary(script) if script is not None else None,
                "errors": card_errors,
            }
        )

    active_ids = {int(card["passcode"]) for card in cards}
    compatibility_ids = sorted(set(scripts) - active_ids)
    return {
        "schema_version": 1,
        "inputs": {
            "cards": {
                "path": cards_path.relative_to(ROOT).as_posix(),
                "sha256": sha256(cards_path),
            },
            "database": {
                "path": db_path.relative_to(ROOT).as_posix(),
                "sha256": sha256(db_path),
            },
            "scripts_directory": scripts_dir.relative_to(ROOT).as_posix(),
        },
        "summary": {
            "active_cards": len(cards),
            "scripts": len(scripts),
            "compatibility_scripts": compatibility_ids,
            "database_rows": len(database),
            "primary_archetypes": len(
                {entry["memberships"]["primary"] for entry in card_entries if entry["memberships"]["primary"]}
            ),
            "cards_without_primary_archetype": sum(
                entry["memberships"]["primary"] is None for entry in card_entries
            ),
            "effect_creations": sum(
                entry["script"]["effect_creations"] for entry in card_entries if entry["script"]
            ),
            "effect_registrations": sum(
                entry["script"]["effect_registrations"] for entry in card_entries if entry["script"]
            ),
            "errors": len(errors),
        },
        "errors": errors,
        "cards": card_entries,
    }


def main() -> int:
    parser = argparse.ArgumentParser(description=__doc__)
    parser.add_argument("--cards", type=Path, default=DEFAULT_CARDS)
    parser.add_argument("--db", type=Path, default=DEFAULT_DB)
    parser.add_argument("--scripts", type=Path, default=DEFAULT_SCRIPTS)
    parser.add_argument("--output", type=Path, default=DEFAULT_OUTPUT)
    parser.add_argument("--check", action="store_true", help="Fail if output differs from the current manifest.")
    args = parser.parse_args()

    manifest = build_manifest(args.cards, args.db, args.scripts)
    rendered = json.dumps(manifest, indent=2, ensure_ascii=False) + "\n"
    if args.check:
        if not args.output.exists() or args.output.read_text(encoding="utf-8") != rendered:
            print(f"ERROR manifest is missing or stale: {args.output}")
            return 1
        print(f"manifest is current: {args.output}")
    else:
        args.output.parent.mkdir(parents=True, exist_ok=True)
        args.output.write_text(rendered, encoding="utf-8")
        print(f"wrote {args.output}")
    for key, value in manifest["summary"].items():
        print(f"{key}={value}")
    for error in manifest["errors"][:50]:
        print(f"ERROR {error}")
    return 1 if manifest["errors"] else 0


if __name__ == "__main__":
    raise SystemExit(main())

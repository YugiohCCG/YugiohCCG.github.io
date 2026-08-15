#!/usr/bin/env python3
"""Independent cross-source type/data audit for every active CCG card."""

from __future__ import annotations

import argparse
import json
import re
import sqlite3
import sys
from collections import Counter
from pathlib import Path
from typing import Any


ROOT = Path(__file__).resolve().parents[1]
DEFAULT_SOURCE = ROOT / "src" / "data" / "cards.json"
DEFAULT_PUBLIC = ROOT / "public" / "assets" / "cards.json"
DEFAULT_DB = ROOT / "public" / "CCG Downloads" / "CCG_Database" / "CCG_v1.db"
DEFAULT_INSTALLED_DB = Path(
    r"C:\Program Files (x86)\YGO Omega\YGO Omega_Data\Files\Databases\CCG_v1.db"
)
DEFAULT_SCRIPTS = ROOT / "public" / "CCG Downloads" / "CCG_Scripts"
DEFAULT_OUTPUT = ROOT / "scripts" / "output" / "card_type_data_consistency_audit.json"

TYPE = {
    "Monster": 0x1,
    "Spell": 0x2,
    "Trap": 0x4,
    "Normal": 0x10,
    "Effect": 0x20,
    "Fusion": 0x40,
    "Ritual": 0x80,
    "Spirit": 0x200,
    "Union": 0x400,
    "Gemini": 0x800,
    "Tuner": 0x1000,
    "Synchro": 0x2000,
    "Token": 0x4000,
    "Quick-Play": 0x10000,
    "Continuous": 0x20000,
    "Equip": 0x40000,
    "Field": 0x80000,
    "Counter": 0x100000,
    "Flip": 0x200000,
    "Toon": 0x400000,
    "Xyz": 0x800000,
    "Pendulum": 0x1000000,
    "Special Summon": 0x2000000,
    "Link": 0x4000000,
}
ATTRIBUTE = {
    "EARTH": 0x1,
    "WATER": 0x2,
    "FIRE": 0x4,
    "WIND": 0x8,
    "LIGHT": 0x10,
    "DARK": 0x20,
    "DIVINE": 0x40,
    "NATURE": 0x80,
    "ELECTRIC": 0x100,
    "METAL": 0x200,
    "ICE": 0x400,
}
RACE = {
    "Warrior": 0x1,
    "Spellcaster": 0x2,
    "Fairy": 0x4,
    "Fiend": 0x8,
    "Zombie": 0x10,
    "Machine": 0x20,
    "Aqua": 0x40,
    "Pyro": 0x80,
    "Rock": 0x100,
    "Winged Beast": 0x200,
    "Plant": 0x400,
    "Insect": 0x800,
    "Thunder": 0x1000,
    "Dragon": 0x2000,
    "Beast": 0x4000,
    "Beast-Warrior": 0x8000,
    "Dinosaur": 0x10000,
    "Fish": 0x20000,
    "Sea Serpent": 0x40000,
    "Reptile": 0x80000,
    "Psychic": 0x100000,
    "Divine-Beast": 0x200000,
    "Creator God": 0x400000,
    "Wyrm": 0x800000,
    "Cyberse": 0x1000000,
    "Illusion": 0x2000000,
    "Cyborg": 0x4000000,
    "Magical Knight": 0x8000000,
    "Celestial Warrior": 0x40000000,
    "Galaxy": 0x80000000,
}
ARROW = {
    "BL": 0x1,
    "B": 0x2,
    "BR": 0x4,
    "L": 0x8,
    "Left": 0x8,
    "R": 0x20,
    "Right": 0x20,
    "TL": 0x40,
    "T": 0x80,
    "Top": 0x80,
    "TR": 0x100,
}
MONSTER_SUBTYPES = {
    "Normal", "Effect", "Fusion", "Ritual", "Spirit", "Union", "Gemini",
    "Tuner", "Synchro", "Token", "Flip", "Toon", "Xyz", "Pendulum",
    "Special Summon", "Link",
}
SPELL_ICONS = {"Normal", "Continuous", "Equip", "Field", "Quick-Play", "Ritual"}
TRAP_ICONS = {"Normal", "Continuous", "Counter"}
EXTRA_TYPES = {"Fusion", "Synchro", "Xyz", "Link"}
CREATE_RUNTIME_RE = re.compile(
    r"\b(?:Effect\.CreateEffect|RegisterEffect|Duel\.RegisterEffect|"
    r"aux\.[A-Za-z0-9_]*(?:Procedure|Proc|Limit|CodeList))\s*\("
)
EMPTY_INITIAL_RE = re.compile(
    r"function\s+(?:s|c\d+)\.initial_effect\s*\(\s*c\s*\)\s*end\b", re.S
)


def load_cards(path: Path) -> list[dict[str, Any]]:
    value = json.loads(path.read_text(encoding="utf-8-sig"))
    if not isinstance(value, list):
        raise ValueError(f"{path}: root must be a list")
    return value


def load_rows(path: Path) -> dict[int, dict[str, Any]]:
    connection = sqlite3.connect(f"file:{path.resolve().as_posix()}?mode=ro", uri=True)
    connection.row_factory = sqlite3.Row
    try:
        rows = connection.execute(
            "select d.*, t.name, t.desc from datas d join texts t using(id)"
        )
        return {int(row["id"]): dict(row) for row in rows}
    finally:
        connection.close()


def expected_type(card: dict[str, Any]) -> int:
    category = str(card.get("category"))
    value = TYPE[category]
    if category == "Monster":
        for subtype in card.get("cardTypes") or []:
            value |= TYPE.get(str(subtype), 0)
    else:
        icon = card.get("icon")
        if icon != "Normal":
            value |= TYPE.get(str(icon), 0)
    return value


def expected_level(card: dict[str, Any]) -> int:
    types = set(card.get("cardTypes") or [])
    if card.get("category") != "Monster":
        return 0
    if "Link" in types:
        value = int(card.get("linkRating") or 0)
    elif "Xyz" in types:
        value = int(card.get("rank") or 0)
    else:
        value = int(card.get("level") or 0)
    if "Pendulum" in types:
        scale = int(card.get("scale") or 0)
        value |= scale << 16 | scale << 24
    return value


def expected_def(card: dict[str, Any]) -> int:
    types = set(card.get("cardTypes") or [])
    if card.get("category") != "Monster":
        return 0
    if "Link" not in types:
        return -2 if card.get("def") is None else int(card["def"])
    value = 0
    for arrow in card.get("linkArrows") or []:
        value |= ARROW.get(str(arrow), 0)
    return value


def add(findings: list[dict[str, Any]], kind: str, card: dict[str, Any] | None, detail: str, source: str) -> None:
    findings.append(
        {
            "kind": kind,
            "passcode": None if card is None else card.get("passcode"),
            "name": None if card is None else card.get("name"),
            "source": source,
            "detail": detail,
        }
    )


def audit(args: argparse.Namespace) -> dict[str, Any]:
    source_cards = load_cards(args.source)
    public_cards = load_cards(args.public)
    repo_rows = load_rows(args.database)
    installed_rows = load_rows(args.installed_database) if args.installed_database.is_file() else None
    findings: list[dict[str, Any]] = []

    source_ids = [card.get("passcode") for card in source_cards]
    public_ids = [card.get("passcode") for card in public_cards]
    for label, values in (("source", source_ids), ("public", public_ids)):
        duplicates = [value for value, count in Counter(values).items() if count > 1]
        if duplicates:
            add(findings, "duplicate_passcode", None, repr(sorted(duplicates)), label)
    source_by_id = {int(card["passcode"]): card for card in source_cards if isinstance(card.get("passcode"), int)}
    public_by_id = {int(card["passcode"]): card for card in public_cards if isinstance(card.get("passcode"), int)}
    if set(source_by_id) != set(public_by_id):
        add(
            findings,
            "active_set_mismatch",
            None,
            f"source-only={sorted(set(source_by_id)-set(public_by_id))}; public-only={sorted(set(public_by_id)-set(source_by_id))}",
            "json copies",
        )

    normal_cards: list[dict[str, Any]] = []
    extra_cards: list[dict[str, Any]] = []
    for ordinal, card in enumerate(source_cards, start=1):
        card_id = int(card["passcode"])
        category = card.get("category")
        card_types = card.get("cardTypes")
        types = set(card_types or [])
        prefix = f"ordinal {ordinal}"
        public_card = public_by_id.get(card_id)
        if public_card != card:
            differing = sorted(
                key for key in set(card) | set(public_card or {})
                if card.get(key) != (public_card or {}).get(key)
            )
            add(findings, "json_copy_mismatch", card, f"{prefix}; fields={differing}", "public JSON")

        if category not in {"Monster", "Spell", "Trap"}:
            add(findings, "invalid_category", card, f"{prefix}; {category!r}", "source JSON")
            continue
        if category == "Monster":
            if card.get("icon") is not None:
                add(findings, "monster_icon_mismatch", card, f"{prefix}; icon={card.get('icon')!r}", "source JSON")
            if not isinstance(card_types, list) or not card_types:
                add(findings, "missing_monster_subtype", card, prefix, "source JSON")
            unknown = sorted(types - MONSTER_SUBTYPES)
            if unknown:
                add(findings, "unknown_monster_subtype", card, f"{prefix}; {unknown}", "source JSON")
            if not isinstance(card.get("monsterType"), list) or len(card["monsterType"]) != 1:
                add(findings, "invalid_monster_race", card, f"{prefix}; {card.get('monsterType')!r}", "source JSON")
            if card.get("attribute") not in ATTRIBUTE:
                add(findings, "invalid_attribute", card, f"{prefix}; {card.get('attribute')!r}", "source JSON")
            if ("Normal" in types) == ("Effect" in types):
                add(findings, "normal_effect_classification", card, f"{prefix}; cardTypes={sorted(types)}", "source JSON")
            if "Normal" in types:
                normal_cards.append(card)
            extra = types & EXTRA_TYPES
            if len(extra) > 1:
                add(findings, "multiple_extra_subtypes", card, f"{prefix}; {sorted(extra)}", "source JSON")
            if extra:
                extra_cards.append(card)
            if "Link" in types:
                if card.get("level") is not None or card.get("rank") is not None or card.get("def") is not None:
                    add(findings, "link_field_mismatch", card, f"{prefix}; level/rank/def must be null", "source JSON")
                if not isinstance(card.get("linkRating"), int) or card["linkRating"] <= 0:
                    add(findings, "link_rating_mismatch", card, prefix, "source JSON")
                if len(card.get("linkArrows") or []) != card.get("linkRating"):
                    add(findings, "link_arrow_count_mismatch", card, prefix, "source JSON")
            elif "Xyz" in types:
                if card.get("level") is not None or card.get("linkRating") is not None or card.get("linkArrows") not in (None, []):
                    add(findings, "xyz_field_mismatch", card, f"{prefix}; level/link fields must be null", "source JSON")
                if not isinstance(card.get("rank"), int) or card["rank"] <= 0:
                    add(findings, "xyz_rank_mismatch", card, prefix, "source JSON")
            else:
                if card.get("rank") is not None or card.get("linkRating") is not None or card.get("linkArrows") not in (None, []):
                    add(findings, "level_monster_field_mismatch", card, f"{prefix}; rank/link fields must be null", "source JSON")
                if not isinstance(card.get("level"), int) or card["level"] <= 0:
                    add(findings, "level_mismatch", card, prefix, "source JSON")
            if "Pendulum" in types and not isinstance(card.get("scale"), int):
                add(findings, "pendulum_scale_mismatch", card, prefix, "source JSON")
            if "Pendulum" not in types and card.get("scale") is not None:
                add(findings, "non_pendulum_scale", card, prefix, "source JSON")
        else:
            valid_icons = SPELL_ICONS if category == "Spell" else TRAP_ICONS
            if card.get("icon") not in valid_icons:
                add(findings, "spell_trap_icon_mismatch", card, f"{prefix}; icon={card.get('icon')!r}", "source JSON")
            populated = [
                field for field in ("cardTypes", "monsterType", "attribute", "level", "rank", "linkRating", "linkArrows", "scale", "atk", "def")
                if card.get(field) is not None
            ]
            if populated:
                add(findings, "spell_trap_monster_fields", card, f"{prefix}; {populated}", "source JSON")

        expected = {
            "name": card.get("name"),
            "desc": card.get("text"),
            "type": expected_type(card),
            "level": expected_level(card),
            "attribute": ATTRIBUTE.get(str(card.get("attribute")), 0) if category == "Monster" else 0,
            "race": RACE.get(str((card.get("monsterType") or [""])[0]), 0) if category == "Monster" else 0,
            "atk": (-2 if card.get("atk") is None else int(card["atk"])) if category == "Monster" else 0,
            "def": expected_def(card),
        }
        for label, rows in (("repository DB", repo_rows), ("installed DB", installed_rows)):
            if rows is None:
                continue
            row = rows.get(card_id)
            if row is None:
                add(findings, "missing_database_record", card, prefix, label)
                continue
            changed = {field: {"expected": value, "actual": row.get(field)} for field, value in expected.items() if row.get(field) != value}
            if changed:
                add(findings, "database_divergence", card, f"{prefix}; {changed}", label)

        script = args.scripts / f"c{card_id}.lua"
        if not script.is_file():
            add(findings, "missing_script", card, prefix, "canonical Lua")
        elif "Normal" in types:
            source = script.read_text(encoding="utf-8-sig", errors="replace")
            if not EMPTY_INITIAL_RE.search(source):
                add(findings, "normal_monster_nonempty_initial", card, prefix, "canonical Lua")
            runtime_calls = CREATE_RUNTIME_RE.findall(source)
            if runtime_calls:
                add(findings, "normal_monster_runtime_effect", card, f"{prefix}; runtime registrations={len(runtime_calls)}", "canonical Lua")

    active_ids = set(source_by_id)
    canonical_script_ids = {
        int(match.group(1)) for path in args.scripts.glob("c*.lua")
        if (match := re.fullmatch(r"c(\d+)\.lua", path.name))
    }
    summary = {
        "active_cards": len(source_cards),
        "public_cards": len(public_cards),
        "unique_active_passcodes": len(active_ids),
        "repository_database_rows_total": len(repo_rows),
        "repository_database_active_rows": len(active_ids & set(repo_rows)),
        "installed_database_rows_total": None if installed_rows is None else len(installed_rows),
        "installed_database_active_rows": None if installed_rows is None else len(active_ids & set(installed_rows)),
        "canonical_scripts_total": len(canonical_script_ids),
        "canonical_active_scripts": len(active_ids & canonical_script_ids),
        "canonical_missing_active_scripts": len(active_ids - canonical_script_ids),
        "canonical_non_active_scripts": sorted(canonical_script_ids - active_ids),
        "json_copy_cards_equal": sum(source_by_id.get(card_id) == public_by_id.get(card_id) for card_id in active_ids),
        "database_fields_compared_per_database": len(active_ids) * 8,
        "repository_database_divergent_cards": len({
            item["passcode"] for item in findings
            if item["kind"] == "database_divergence" and item["source"] == "repository DB"
        }),
        "installed_database_divergent_cards": len({
            item["passcode"] for item in findings
            if item["kind"] == "database_divergence" and item["source"] == "installed DB"
        }),
        "categories": dict(sorted(Counter(str(card.get("category")) for card in source_cards).items())),
        "spell_trap_icons": dict(sorted(Counter(
            f"{card.get('category')}:{card.get('icon')}"
            for card in source_cards if card.get("category") in {"Spell", "Trap"}
        ).items())),
        "monster_subtypes": dict(sorted(Counter(
            subtype for card in source_cards if card.get("category") == "Monster"
            for subtype in (card.get("cardTypes") or [])
        ).items())),
        "normal_monsters": len(normal_cards),
        "normal_monsters_without_runtime_findings": len(normal_cards) - sum(
            1 for card in normal_cards
            if any(
                item["passcode"] == card["passcode"] and item["kind"].startswith("normal_monster_")
                for item in findings
            )
        ),
        "extra_deck_monsters": len(extra_cards),
        "extra_deck_subtypes": dict(sorted(Counter(next(iter(set(card.get("cardTypes") or []) & EXTRA_TYPES)) for card in extra_cards).items())),
        "findings": len(findings),
        "finding_kinds": dict(sorted(Counter(item["kind"] for item in findings).items())),
    }
    prologue = source_by_id.get(224467692)
    summary["scarstech_prologue"] = {
        "present": prologue is not None,
        "cardTypes": None if prologue is None else prologue.get("cardTypes"),
        "repository_db_type": repo_rows.get(224467692, {}).get("type"),
        "installed_db_type": None if installed_rows is None else installed_rows.get(224467692, {}).get("type"),
        "runtime_effect_findings": sum(1 for item in findings if item["passcode"] == 224467692 and item["kind"].startswith("normal_monster_")),
    }
    return {
        "inputs": {
            "source": str(args.source),
            "public": str(args.public),
            "database": str(args.database),
            "installed_database": str(args.installed_database),
            "scripts": str(args.scripts),
        },
        "summary": summary,
        "findings": findings,
    }


def main() -> int:
    if hasattr(sys.stdout, "reconfigure"):
        sys.stdout.reconfigure(encoding="utf-8", errors="replace")
    parser = argparse.ArgumentParser(description=__doc__)
    parser.add_argument("--source", type=Path, default=DEFAULT_SOURCE)
    parser.add_argument("--public", type=Path, default=DEFAULT_PUBLIC)
    parser.add_argument("--database", type=Path, default=DEFAULT_DB)
    parser.add_argument("--installed-database", type=Path, default=DEFAULT_INSTALLED_DB)
    parser.add_argument("--scripts", type=Path, default=DEFAULT_SCRIPTS)
    parser.add_argument("--output", type=Path, default=DEFAULT_OUTPUT)
    args = parser.parse_args()
    result = audit(args)
    args.output.parent.mkdir(parents=True, exist_ok=True)
    args.output.write_text(json.dumps(result, indent=2, ensure_ascii=False) + "\n", encoding="utf-8")
    print(json.dumps(result["summary"], indent=2, ensure_ascii=False))
    if result["findings"]:
        print("Findings:")
        for finding in result["findings"]:
            print(f"- {finding['kind']}: {finding['passcode']} {finding['name']} [{finding['source']}] {finding['detail']}")
    print(f"Report: {args.output}")
    return 1 if result["findings"] else 0


if __name__ == "__main__":
    raise SystemExit(main())

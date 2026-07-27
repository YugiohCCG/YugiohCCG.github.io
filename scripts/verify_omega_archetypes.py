from __future__ import annotations

import argparse
import json
import re
import sqlite3
import sys
from collections import defaultdict
from pathlib import Path
from typing import Any

from sync_omega_ccg_db import (
    DEFAULT_CARDS_PATH,
    DEFAULT_OFFICIAL_DB_PATH,
    ADDITIONAL_CARD_SET_CODES,
    OFFICIAL_SHARED_SET_CODES,
    TREATED_AS_RE,
    build_existing_setcode_map,
    canonical_display_name,
    decode_setcodes,
    extract_treated_as_names,
    extract_name_based_archetype_names,
    normalize_name,
)


REPO_ROOT = Path(__file__).resolve().parents[1]
DEFAULT_CCG_DB_PATH = REPO_ROOT / "public" / "CCG Downloads" / "CCG_Database" / "CCG_v1.db"
DEFAULT_SCRIPTS_PATH = REPO_ROOT / "public" / "CCG Downloads" / "CCG_Scripts"

SET_CONSTANT_RE = re.compile(
    r"\blocal\s+(SET_[A-Z0-9_]+)\s*=\s*"
    r"(?:SET_[A-Z0-9_]+\s+or\s+)?(0x[0-9a-fA-F]+|\d+)\b"
)
NUMBER_RE = re.compile(r"\b(?:0x[0-9a-fA-F]+|\d+)\b")
QUOTED_ARCHETYPE_RE = re.compile(r'"([^"]+)"\s+cards?\b', re.IGNORECASE)
SET_FILTER_RE = re.compile(
    r"(?:[A-Za-z0-9_.:]*Is[A-Za-z]*SetCard\s*\(|Card\.Is[A-Za-z]*SetCard\s*,)"
    r"([^)\r\n]{0,300})",
    re.IGNORECASE,
)
SET_IDENTIFIER_RE = re.compile(r"\bSET_[A-Z0-9_]+\b")

# Lua constants occasionally use the short printed stem rather than the full
# cards.json archetype label.
SET_CONSTANT_ALIASES = {
    "phlogiston": "phlogistondragon",
}


def load_cards(path: Path) -> list[dict[str, Any]]:
    payload = json.loads(path.read_text(encoding="utf-8"))
    if isinstance(payload, dict):
        payload = payload.get("cards")
    if not isinstance(payload, list):
        raise ValueError(f"Expected a card list in {path}")
    return payload


def load_rows(path: Path) -> list[sqlite3.Row]:
    conn = sqlite3.connect(f"{path.resolve().as_uri()}?mode=ro", uri=True)
    conn.row_factory = sqlite3.Row
    try:
        return list(
            conn.execute(
                """
                select d.id, d.setcode, t.name
                from datas d
                join texts t on t.id=d.id
                """
            )
        )
    finally:
        conn.close()


def parse_number(token: str) -> int:
    return int(token, 0)


def script_filters_setcode(
    source: str,
    expected: int,
    constants: dict[str, int],
) -> bool:
    for arguments in SET_FILTER_RE.findall(source):
        if any(
            constants.get(identifier) == expected
            for identifier in SET_IDENTIFIER_RE.findall(arguments)
        ):
            return True
        if any(parse_number(token) == expected for token in NUMBER_RE.findall(arguments)):
            return True
    return False


def card_id(card: dict[str, Any]) -> int | None:
    value = card.get("passcode")
    return int(value) if value is not None else None


def main() -> None:
    parser = argparse.ArgumentParser(
        description="Verify CCG archetype interoperability against the official Omega database."
    )
    parser.add_argument("--cards", type=Path, default=DEFAULT_CARDS_PATH)
    parser.add_argument("--ccg-db", type=Path, default=DEFAULT_CCG_DB_PATH)
    parser.add_argument("--official-db", type=Path, default=DEFAULT_OFFICIAL_DB_PATH)
    parser.add_argument("--scripts", type=Path, default=DEFAULT_SCRIPTS_PATH)
    args = parser.parse_args()

    missing = [
        path
        for path in (args.cards, args.ccg_db, args.official_db, args.scripts)
        if not path.exists()
    ]
    if missing:
        raise SystemExit("Missing required archetype audit input(s): " + ", ".join(map(str, missing)))

    cards = load_cards(args.cards)
    ccg_rows = load_rows(args.ccg_db)
    official_rows = load_rows(args.official_db)
    ccg_by_id = {int(row["id"]): row for row in ccg_rows}
    official_codes: dict[int, set[int]] = defaultdict(set)
    for row in official_rows:
        for code in decode_setcodes(row["setcode"]):
            official_codes[code].add(int(row["id"]))

    setcode_map, _used_codes = build_existing_setcode_map(cards, ccg_rows)
    expected_tags: dict[str, int] = dict(setcode_map)
    expected_tags.update(OFFICIAL_SHARED_SET_CODES)

    primary_groups: dict[str, list[dict[str, Any]]] = defaultdict(list)
    tag_members: dict[str, set[int]] = defaultdict(set)
    display_names: dict[str, str] = {}
    for card in cards:
        cid = card_id(card)
        archetype = canonical_display_name(card.get("archetype"))
        if archetype:
            key = normalize_name(archetype)
            primary_groups[key].append(card)
            display_names.setdefault(key, archetype)
            if cid is not None:
                tag_members[key].add(cid)
        for treated_as in extract_treated_as_names(card.get("text")):
            key = normalize_name(treated_as)
            display_names.setdefault(key, treated_as)
            if cid is not None:
                tag_members[key].add(cid)
        for name_based in extract_name_based_archetype_names(card.get("name")):
            key = normalize_name(name_based)
            display_names.setdefault(key, name_based)
            if cid is not None:
                tag_members[key].add(cid)

    errors: list[str] = []
    warnings: list[str] = []

    # Every CCG member of an archetype must carry the same primary setcode.
    for key, group in sorted(primary_groups.items()):
        expected = expected_tags.get(key)
        if expected is None:
            errors.append(f'{display_names[key]}: no setcode could be resolved')
            continue
        for card in group:
            cid = card_id(card)
            row = ccg_by_id.get(cid) if cid is not None else None
            if row is None:
                errors.append(f'{card.get("name")}: card {cid or "?"} is missing from the CCG database')
                continue
            codes = decode_setcodes(row["setcode"])
            if not codes or codes[0] != expected:
                errors.append(
                    f'{row["name"]}: primary {display_names[key]} setcode is '
                    f'{[hex(code) for code in codes] or "missing"}, expected {hex(expected)}'
                )

    # "Always treated as" membership must also be represented in the DB row.
    for card in cards:
        cid = card_id(card)
        row = ccg_by_id.get(cid) if cid is not None else None
        if row is None:
            continue
        codes = decode_setcodes(row["setcode"])
        for treated_as in extract_treated_as_names(card.get("text")):
            key = normalize_name(treated_as)
            expected = expected_tags.get(key)
            if expected is None:
                errors.append(f'{row["name"]}: no setcode resolved for treated-as archetype "{treated_as}"')
            elif expected not in codes:
                errors.append(
                    f'{row["name"]}: treated-as archetype "{treated_as}" is missing {hex(expected)}'
                )
        for name_based in extract_name_based_archetype_names(card.get("name")):
            key = normalize_name(name_based)
            expected = expected_tags.get(key)
            if expected is None:
                errors.append(f'{row["name"]}: no setcode resolved for named series "{name_based}"')
            elif expected not in codes:
                errors.append(
                    f'{row["name"]}: named series "{name_based}" is missing {hex(expected)}'
                )
        for expected in ADDITIONAL_CARD_SET_CODES.get(cid, ()):
            if expected not in codes:
                errors.append(f'{row["name"]}: required additional setcode {hex(expected)} is missing')

    # Shared archetypes must use Omega's official code, and custom-only codes
    # must never collide with any official archetype.
    for key, expected in sorted(OFFICIAL_SHARED_SET_CODES.items()):
        if key in tag_members and expected not in official_codes:
            errors.append(
                f'{display_names.get(key, key)}: official Omega DB has no cards with {hex(expected)}'
            )
    for key, members in sorted(tag_members.items()):
        expected = expected_tags.get(key)
        if (
            expected is not None
            and key not in OFFICIAL_SHARED_SET_CODES
            and expected in official_codes
        ):
            errors.append(
                f'{display_names[key]}: custom setcode {hex(expected)} used by {len(members)} CCG cards collides with '
                f'{len(official_codes[expected])} official Omega cards'
            )

    # Lua SET_* constants must agree with the database. This catches scripts
    # copied from a simulator with a different unofficial setcode table.
    script_count = 0
    for script_path in sorted(args.scripts.glob("c*.lua")):
        script_count += 1
        source = script_path.read_text(encoding="utf-8-sig", errors="replace")
        if "project ignis" in source.lower():
            errors.append(f"{script_path.name}: contains a Project Ignis compatibility path")
        for constant, token in SET_CONSTANT_RE.findall(source):
            key = normalize_name(constant.removeprefix("SET_"))
            key = SET_CONSTANT_ALIASES.get(key, key)
            expected = expected_tags.get(key)
            actual = parse_number(token)
            if expected is not None and actual != expected:
                errors.append(
                    f"{script_path.name}: {constant}={hex(actual)}, expected {hex(expected)}"
                )
            if constant.endswith("_PI"):
                errors.append(f"{script_path.name}: obsolete alternate setcode constant {constant}")
        if "NEMLERIA" in source and re.search(r"\b0x0*192\b", source, re.IGNORECASE):
            errors.append(f"{script_path.name}: Nemleria filter includes official Gold Pride code 0x192")

    # If card text promises support for a known archetype, its script should
    # reference that archetype's setcode rather than a closed card-code list.
    coverage_checks = 0
    for card in cards:
        cid = card_id(card)
        if cid is None:
            continue
        script_path = args.scripts / f"c{cid}.lua"
        if not script_path.exists():
            continue
        source = script_path.read_text(encoding="utf-8-sig", errors="replace")
        constants = {
            name: parse_number(token)
            for name, token in SET_CONSTANT_RE.findall(source)
        }
        effect_text = TREATED_AS_RE.sub("", str(card.get("text") or ""))
        for quoted_name in QUOTED_ARCHETYPE_RE.findall(effect_text):
            key = normalize_name(quoted_name)
            expected = expected_tags.get(key)
            if expected is None:
                continue
            coverage_checks += 1
            if not script_filters_setcode(source, expected, constants):
                errors.append(
                    f'{script_path.name}: text promises "{quoted_name}" support but '
                    f"does not filter with setcode {hex(expected)}"
                )

    if warnings:
        print("Archetype coverage warnings:")
        for warning in warnings:
            print(f"  WARN {warning}")
    if errors:
        print("Archetype verification failed:")
        for error in errors:
            print(f"  ERROR {error}")
        print(
            f"summary cards={len(cards)} scripts={script_count} "
            f"archetypes={len(primary_groups)} errors={len(errors)} warnings={len(warnings)}"
        )
        raise SystemExit(1)

    print(
        f"Archetype verification passed: cards={len(cards)} scripts={script_count} "
        f"archetypes={len(primary_groups)} named_or_treated_series={len(tag_members) - len(primary_groups)} "
        f"shared_official={sum(key in tag_members for key in OFFICIAL_SHARED_SET_CODES)} "
        f"quoted_support_checks={coverage_checks} warnings={len(warnings)}"
    )


if __name__ == "__main__":
    main()

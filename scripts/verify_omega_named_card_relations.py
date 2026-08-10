#!/usr/bin/env python3
"""Audit exact named-card relationships used by Omega's runtime list helpers."""

from __future__ import annotations

import argparse
import json
import re
import sqlite3
import unicodedata
from collections import defaultdict
from pathlib import Path
from typing import Any, Iterable


ROOT = Path(__file__).resolve().parents[1]
DEFAULT_CARDS = ROOT / "src" / "data" / "cards.json"
DEFAULT_SCRIPTS = ROOT / "public" / "CCG Downloads" / "CCG_Scripts"
DEFAULT_CCG_DB = ROOT / "public" / "CCG Downloads" / "CCG_Database" / "CCG_v1.db"
DEFAULT_OFFICIAL_DB = Path(
    r"C:\Program Files (x86)\YGO Omega\YGO Omega_Data\Files\Bundles\db"
)
DEFAULT_OUTPUT = ROOT / "scripts" / "output" / "omega_named_card_relations.json"

CONSTANT_RE = re.compile(
    r"^\s*(?:local\s+)?([A-Za-z_]\w*)\s*=\s*(0x[0-9a-fA-F]+|\d+)\s*$",
    re.MULTILINE,
)
QUOTED_RE = re.compile(r'["\u201c\u201d]([^"\u201c\u201d]+)["\u201c\u201d]')
LISTS_RE = re.compile(
    r"\b(?:lists?|mentions?)\s+[\"\u201c\u201d]([^\"\u201c\u201d]+)[\"\u201c\u201d]",
    re.IGNORECASE,
)
EXACT_NAME_BEHAVIOR_RE = re.compile(
    r"\b(?:this card(?:'s|\u2019s) name\s+(?:becomes|is(?: also)? treated as)|"
    r"this card\s+is(?: also)? treated as|this card\s+is always treated as)\s*"
    r"[\"\u201c\u201d]([^\"\u201c\u201d]+)[\"\u201c\u201d]",
    re.IGNORECASE,
)

REGISTRATION_CALLS = {
    "AddCodeList",
    "AddMaterialCodeList",
    "EnableChangeCode",
    "AddFusionProcMix",
    "AddFusionProcMixRep",
    "AddFusionProcCode2",
    "AddFusionProcCode3",
    "AddFusionProcCode4",
    "AddFusionProcCodeRep",
    "AddFusionProcCodeRep2",
    "AddFusionProcCodeFun",
    "AddFusionProcCodeFunRep",
    "AddFusionProcCode2FunRep",
}
LIST_CONSUMER_CALLS = {"IsCodeListed", "IsCodeOrListed"}
MATERIAL_CONSUMER_CALLS = {"IsMaterialListCode"}
ALL_CALLS = REGISTRATION_CALLS | LIST_CONSUMER_CALLS | MATERIAL_CONSUMER_CALLS


def normalize_name(value: object) -> str:
    text = unicodedata.normalize("NFKC", str(value or ""))
    text = text.translate(str.maketrans({"\u2018": "'", "\u2019": "'"}))
    return re.sub(r"\s+", " ", text).strip().casefold()


def load_cards(path: Path) -> list[dict[str, Any]]:
    payload = json.loads(path.read_text(encoding="utf-8"))
    if isinstance(payload, dict):
        payload = payload.get("cards")
    if not isinstance(payload, list):
        raise ValueError(f"Expected a card list in {path}")
    return payload


def load_database_names(path: Path) -> list[tuple[int, str]]:
    if not path.is_file():
        return []
    connection = sqlite3.connect(f"{path.resolve().as_uri()}?mode=ro", uri=True)
    try:
        return [
            (int(row[0]), str(row[1]))
            for row in connection.execute("select id, name from texts")
            if row[1]
        ]
    finally:
        connection.close()


def load_aliases(path: Path) -> dict[int, int]:
    if not path.is_file():
        return {}
    connection = sqlite3.connect(f"{path.resolve().as_uri()}?mode=ro", uri=True)
    try:
        return {
            int(card_id): int(alias)
            for card_id, alias in connection.execute("select id, alias from datas")
            if alias
        }
    finally:
        connection.close()


def split_arguments(value: str) -> list[str]:
    arguments: list[str] = []
    start = 0
    depth = 0
    quote: str | None = None
    escaped = False
    for index, character in enumerate(value):
        if quote:
            if escaped:
                escaped = False
            elif character == "\\":
                escaped = True
            elif character == quote:
                quote = None
            continue
        if character in "'\"":
            quote = character
        elif character in "([{":
            depth += 1
        elif character in ")]}":
            depth = max(0, depth - 1)
        elif character == "," and depth == 0:
            arguments.append(value[start:index].strip())
            start = index + 1
    arguments.append(value[start:].strip())
    return arguments


def iter_auxiliary_calls(source: str, names: Iterable[str]) -> Iterable[tuple[str, list[str], int]]:
    wanted = "|".join(sorted((re.escape(name) for name in names), key=len, reverse=True))
    pattern = re.compile(rf"\b(?:aux|Auxiliary)\.({wanted})\s*\(")
    for match in pattern.finditer(source):
        depth = 1
        index = match.end()
        quote: str | None = None
        escaped = False
        while index < len(source) and depth:
            character = source[index]
            if quote:
                if escaped:
                    escaped = False
                elif character == "\\":
                    escaped = True
                elif character == quote:
                    quote = None
            elif character in "'\"":
                quote = character
            elif character == "(":
                depth += 1
            elif character == ")":
                depth -= 1
            index += 1
        if depth == 0:
            yield (
                match.group(1),
                split_arguments(source[match.end() : index - 1]),
                source.count("\n", 0, match.start()) + 1,
            )


def resolve_code(expression: str, constants: dict[str, int]) -> int | None:
    token = re.sub(r"\s+", "", expression)
    if token in constants:
        return constants[token]
    if re.fullmatch(r"0x[0-9a-fA-F]+|\d+", token):
        return int(token, 0)
    return None


def inspect_script(source: str, card_id: int) -> dict[str, Any]:
    constants = {name: int(value, 0) for name, value in CONSTANT_RE.findall(source)}
    constants["id"] = card_id
    registered: set[int] = set()
    list_consumers: set[int] = set()
    list_consumer_categories: dict[int, set[str]] = defaultdict(set)
    material_consumers: set[int] = set()
    call_lines: dict[tuple[str, int], int] = {}
    for call_name, arguments, line in iter_auxiliary_calls(source, ALL_CALLS):
        resolved = [resolve_code(argument, constants) for argument in arguments[1:]]
        codes = {code for code in resolved if code is not None}
        if call_name in REGISTRATION_CALLS:
            registered.update(codes)
        elif call_name in LIST_CONSUMER_CALLS:
            list_consumers.update(codes)
            lines = source.splitlines()
            window = "\n".join(lines[max(0, line - 3) : min(len(lines), line + 2)])
            categories: set[str] = set()
            if re.search(r"\bTYPE_MONSTER\b", window):
                categories.add("Monster")
            if re.search(r"\bTYPE_SPELL\b", window):
                categories.add("Spell")
            if re.search(r"\bTYPE_TRAP\b", window):
                categories.add("Trap")
            if not categories:
                categories.update(("Monster", "Spell", "Trap"))
            for code in codes:
                list_consumer_categories[code].update(categories)
        elif call_name in MATERIAL_CONSUMER_CALLS:
            material_consumers.update(codes)
        for code in codes:
            call_lines.setdefault((call_name, code), line)
    return {
        "registered": registered,
        "list_consumers": list_consumers,
        "list_consumer_categories": dict(list_consumer_categories),
        "material_consumers": material_consumers,
        "call_lines": call_lines,
        "has_change_code": bool(
            re.search(r"\bEFFECT_(?:CHANGE|ADD)_CODE\b|\b(?:aux|Auxiliary)\.EnableChangeCode\b", source)
        ),
    }


def main() -> int:
    parser = argparse.ArgumentParser(description=__doc__)
    parser.add_argument("--cards", type=Path, default=DEFAULT_CARDS)
    parser.add_argument("--scripts", type=Path, default=DEFAULT_SCRIPTS)
    parser.add_argument("--ccg-db", type=Path, default=DEFAULT_CCG_DB)
    parser.add_argument("--official-db", type=Path, default=DEFAULT_OFFICIAL_DB)
    parser.add_argument("--output", type=Path, default=DEFAULT_OUTPUT)
    parser.add_argument(
        "--strict",
        action="store_true",
        help="Exit non-zero when any named-card runtime relationship is missing.",
    )
    parser.add_argument(
        "--show-review",
        action="store_true",
        help="Also print latent metadata omissions that have no matching current consumer.",
    )
    args = parser.parse_args()

    cards = load_cards(args.cards)
    custom_by_id = {int(card["passcode"]): card for card in cards if card.get("passcode")}
    names: dict[str, set[int]] = defaultdict(set)
    display_names: dict[int, str] = {}
    for card_id, name in load_database_names(args.official_db):
        names[normalize_name(name)].add(card_id)
        display_names.setdefault(card_id, name)
    for card in cards:
        card_id = int(card["passcode"])
        name = str(card.get("name") or card_id)
        names[normalize_name(name)].add(card_id)
        display_names[card_id] = name

    aliases = load_aliases(args.ccg_db)
    inspections: dict[int, dict[str, Any]] = {}
    sources: dict[int, str] = {}
    for card_id in custom_by_id:
        script_path = args.scripts / f"c{card_id}.lua"
        if not script_path.is_file():
            continue
        source = script_path.read_text(encoding="utf-8-sig", errors="replace")
        sources[card_id] = source
        inspections[card_id] = inspect_script(source, card_id)

    searched_codes = set().union(
        *(inspection["list_consumers"] for inspection in inspections.values())
    ) if inspections else set()
    searched_categories: dict[int, set[str]] = defaultdict(set)
    for inspection in inspections.values():
        for code, categories in inspection["list_consumer_categories"].items():
            searched_categories[code].update(categories)

    findings: list[dict[str, Any]] = []
    relationships_checked = 0
    relationship_keys: set[tuple[int, int]] = set()
    list_contract_keys: set[tuple[int, int]] = set()
    name_behavior_keys: set[tuple[int, int]] = set()

    def resolve_quoted_name(value: str) -> int | None:
        matches = names.get(normalize_name(value), set())
        return next(iter(matches)) if len(matches) == 1 else None

    def add_finding(
        severity: str,
        kind: str,
        card_id: int,
        target_code: int,
        detail: str,
    ) -> None:
        card = custom_by_id[card_id]
        findings.append(
            {
                "severity": severity,
                "kind": kind,
                "card_id": card_id,
                "card_name": card.get("name"),
                "archetype": card.get("archetype"),
                "script": f"c{card_id}.lua",
                "target_code": target_code,
                "target_name": display_names.get(target_code, str(target_code)),
                "detail": detail,
            }
        )

    for card_id, card in custom_by_id.items():
        inspection = inspections.get(card_id)
        if inspection is None:
            continue
        text = str(card.get("text") or "")
        for quoted_name in QUOTED_RE.findall(text):
            target_code = resolve_quoted_name(quoted_name)
            if target_code is None or target_code == card_id:
                continue
            key = (card_id, target_code)
            if key in relationship_keys:
                continue
            relationship_keys.add(key)
            relationships_checked += 1
            if target_code not in inspection["registered"]:
                card_category = str(card.get("category") or "")
                has_current_consumer = card_category in searched_categories.get(target_code, set())
                severity = "error"
                impact = (
                    "A current aux.IsCodeListed/aux.IsCodeOrListed search consumes this code."
                    if has_current_consumer
                    else "The runtime metadata is incomplete even though no matching current consumer was found."
                )
                add_finding(
                    severity,
                    "missing-runtime-code-list",
                    card_id,
                    target_code,
                    f'Printed text names "{quoted_name}", but registration does not add its code. {impact}',
                )

        for quoted_name in LISTS_RE.findall(text):
            target_code = resolve_quoted_name(quoted_name)
            if target_code is None:
                continue
            key = (card_id, target_code)
            if key in list_contract_keys:
                continue
            list_contract_keys.add(key)
            consumers = inspection["list_consumers"] | inspection["material_consumers"]
            if target_code not in consumers:
                add_finding(
                    "error",
                    "printed-list-search-without-runtime-list-filter",
                    card_id,
                    target_code,
                    f'Printed effect searches for cards that list/mention "{quoted_name}", '
                    "but the script does not consume that code through a runtime list helper.",
                )

        for quoted_name in EXACT_NAME_BEHAVIOR_RE.findall(text):
            target_code = resolve_quoted_name(quoted_name)
            if target_code is None:
                continue
            key = (card_id, target_code)
            if key in name_behavior_keys:
                continue
            name_behavior_keys.add(key)
            if not inspection["has_change_code"] and aliases.get(card_id) != target_code:
                add_finding(
                    "error",
                    "printed-name-treatment-without-code-effect",
                    card_id,
                    target_code,
                    f'Printed text changes/treats this card\'s name as "{quoted_name}", '
                    "but no change/add-code effect or matching database alias was found.",
                )

    counts = defaultdict(int)
    kinds = defaultdict(int)
    for finding in findings:
        counts[finding["severity"]] += 1
        kinds[finding["kind"]] += 1
    report = {
        "schema_version": 1,
        "summary": {
            "cards": len(cards),
            "scripts": len(inspections),
            "known_names": len(names),
            "relationships_checked": relationships_checked,
            "runtime_list_codes_consumed": len(searched_codes),
            "errors": counts["error"],
            "review_candidates": counts["review"],
            "findings_by_kind": dict(sorted(kinds.items())),
            "official_database_loaded": args.official_db.is_file(),
        },
        "findings": findings,
    }
    args.output.parent.mkdir(parents=True, exist_ok=True)
    args.output.write_text(json.dumps(report, indent=2) + "\n", encoding="utf-8")

    for key, value in report["summary"].items():
        print(f"{key}={json.dumps(value, sort_keys=True) if isinstance(value, dict) else value}")
    print(f"report={args.output}")
    for finding in findings:
        if finding["severity"] == "review" and not args.show_review:
            continue
        print(
            f'{finding["severity"].upper()} {finding["script"]} '
            f'{finding["kind"]}: {finding["target_name"]} ({finding["target_code"]})'
        )
    return 1 if args.strict and counts["error"] else 0


if __name__ == "__main__":
    raise SystemExit(main())

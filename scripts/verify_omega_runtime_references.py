#!/usr/bin/env python3
"""Audit custom Lua/card references that can make Omega load another card script."""

from __future__ import annotations

import argparse
import json
from pathlib import Path
import re
import sqlite3
import sys

sys.dont_write_bytecode = True

from package_omega_ccg_scripts import COMPATIBILITY_SCRIPT_IDS
from sync_omega_ccg_db import EXTRA_TOKEN_CARDS, decode_setcodes


ROOT = Path(__file__).resolve().parents[1]
DEFAULT_CARDS = ROOT / "src" / "data" / "cards.json"
DEFAULT_SCRIPTS = ROOT / "public" / "CCG Downloads" / "CCG_Scripts"
DEFAULT_DB = ROOT / "public" / "CCG Downloads" / "CCG_Database" / "CCG_v1.db"
DEFAULT_OFFICIAL_DB = Path(
    r"C:\Program Files (x86)\YGO Omega\YGO Omega_Data\Files\Bundles\db"
)
DEFAULT_OFFICIAL_SCRIPTS = ROOT / "tmp" / "omega_scripts"

CONSTANT_RE = re.compile(
    r"^\s*local\s+([A-Za-z_]\w*)\s*=\s*(\d+)\s*$", re.MULTILINE
)
SETCODE_CONSTANT_RE = re.compile(
    r"^\s*local\s+(SET_[A-Z0-9_]+)\s*=\s*"
    r"(0x[0-9a-fA-F]+|\d+)\s*$",
    re.MULTILINE,
)
IS_SETCARD_LITERAL_RE = re.compile(
    r"\bIsSetCard\(\s*(0x[0-9a-fA-F]+|\d+)"
)
CARD_CODE_CONSTANT_RE = re.compile(
    r"^\s*local\s+(CARD_[A-Z0-9_]+)\s*=\s*(\d+)\s*$",
    re.MULTILINE,
)
CARD_CODE_LITERAL_RE = re.compile(
    r"\b(?:IsCode|IsOriginalCodeRule|IsFusionCode)\(\s*(\d+)"
)
CREATE_TOKEN_RE = re.compile(
    r"Duel\.CreateToken\s*\(\s*[^,]+,\s*([^\)]+?)\s*\)"
)
CAN_SUMMON_CODE_RE = re.compile(
    r"Duel\.IsPlayerCanSpecialSummonMonster\s*\(\s*[^,]+,\s*([^,]+?)\s*,"
)
COPY_EFFECT_RE = re.compile(r"(?:\:|\.)CopyEffect\s*\(\s*([^,]+?)\s*,")
LOAD_CARD_SCRIPT_RE = re.compile(r'Duel\.LoadScript\s*\(\s*"c(\d+)\.lua"\s*\)')
OMEGA_HELPER_CALL_RE = re.compile(
    r"\b(?:aux|Auxiliary)\.(AddSynchroProcedure|AddLinkProcedure)"
    r"\(([^\r\n]*)\)"
)
OMEGA_HELPER_MAX_ARGUMENTS = {
    "AddSynchroProcedure": 5,
    "AddLinkProcedure": 5,
}
MODERN_PROCEDURE_NAMESPACE_RE = re.compile(
    r"\b(?:Fusion|Synchro|Xyz|Link|Ritual|Pendulum)\.[A-Za-z_]\w*\s*\("
)
CHAIN_MATERIAL_ASSIGN_RE = re.compile(
    r"\blocal\s+([A-Za-z_]\w*)\s*=\s*Duel\.GetChainMaterial\s*\("
)
DIRECT_LINK_CUSTOM_FILTER_RE = re.compile(
    r"\b(?:aux|Auxiliary)\.AddLinkProcedure\(\s*c\s*,\s*s\.([A-Za-z_]\w*)"
)
MODERN_LINK_GROUP_FILTER_SIGNATURE_RE = re.compile(
    r"^\s*function\s+s\.[A-Za-z_]\w*\s*"
    r"\(\s*g\s*,\s*lc\s*,\s*sumtype\s*,\s*tp\s*\)",
    re.MULTILINE,
)
ZERO_ARGUMENT_LINK_API_RE = re.compile(
    r":(IsLinkSummonable|IsCanBeLinkMaterial)\s*\(\s*\)"
)
CURRENT_CHAIN_PLUS_ONE_RE = re.compile(
    r"Duel\.GetCurrentChain\(\)\s*\+\s*1"
)
RACE_GALAXY_RE = re.compile(r"\bRACE_GALAXY\b")
LOCAL_CCG_RACE_GALAXY_RE = re.compile(
    r"^\s*local\s+RACE_GALAXY\s*=\s*0x80000000\s*$", re.MULTILINE
)
CANNOT_ACTIVATE_VALUE_RE = re.compile(
    r"SetCode\(\s*EFFECT_CANNOT_ACTIVATE\s*\)"
    r"(?:(?!SetCode\().){0,600}?"
    r"SetValue\(\s*(?:"
    r"(?P<named>[A-Za-z_]\w*\.[A-Za-z_]\w*)|"
    r"function\s*\((?P<inline>[^\)]*)\)"
    r")",
    re.DOTALL,
)
SPSUMMON_PROC_CODE_RE = re.compile(
    r"\b([A-Za-z_]\w*):SetCode\(\s*EFFECT_SPSUMMON_PROC\s*\)"
)
OPPONENT_SUMMON_CHOICE_TEXT_RE = re.compile(
    r"your opponent Normal or Special Summons 1 monster", re.IGNORECASE
)
OPPONENT_SUMMON_CHOICE_CODE_RE = re.compile(
    r"Duel\.SelectOption\(\s*(?:1\s*-\s*tp|p)\s*,\s*1151\s*,\s*1152\s*\)"
)
OPTIONAL_IF_SUMMONED_TEXT_RE = re.compile(
    r"If this card is (?:Fusion |Synchro |Xyz |Link |Ritual |"
    r"Normal or Special |Normal |Special )?Summoned[^:]*:\s*You can",
    re.IGNORECASE,
)
EFFECT_REGISTRATION_BLOCK_RE = re.compile(
    r"local\s+(?P<effect>e\d+)\s*=\s*Effect\.CreateEffect\(c\)"
    r"(?P<body>.*?c:RegisterEffect\(\s*(?P=effect)\s*\))",
    re.DOTALL,
)
FUNCTION_BLOCK_RE = re.compile(
    r"^\s*function\s+s\.(?P<name>[A-Za-z_]\w*)\s*\([^\)]*\)"
    r"(?P<body>.*?)(?=^\s*function\s+s\.|\Z)",
    re.MULTILINE | re.DOTALL,
)
OPERATION_CALLBACK_RE = re.compile(
    r"\bSetOperation\(\s*s\.([A-Za-z_]\w*)\s*\)"
)
SPSUMMON_PROC_OPERATION_RE = re.compile(
    r"\b(?P<effect>[A-Za-z_]\w*):SetCode\(\s*EFFECT_SPSUMMON_PROC\s*\)"
    r"(?:(?!RegisterEffect).){0,1200}?"
    r"(?P=effect):SetOperation\(\s*s\.([A-Za-z_]\w*)\s*\)",
    re.DOTALL,
)
ACTIVATION_REVEAL_TEXT_RE = re.compile(
    r"\b(?:reveal|show)\b[^;.!?]*;", re.IGNORECASE
)
ACTIVATION_CHOOSE_TEXT_RE = re.compile(r"\bchoose\b[^;.!?]*;", re.IGNORECASE)
ACTIVATION_TARGET_TEXT_RE = re.compile(
    r"(?:\b(?:you can(?: also)?|then|and)\s+target\b|"
    r"(?:^|[\n.!?●•]\s*)target\b)[^;.!?]*;",
    re.IGNORECASE,
)
ACTIVATION_PLACE_TEXT_RE = re.compile(r"\bplace\b[^;.!?]*;", re.IGNORECASE)
ACTIVATION_ROLL_TEXT_RE = re.compile(
    r"\broll\s+(?:a|one|1)\s+(?:six-sided|6-sided)\s+die\b[^;.!?]*;",
    re.IGNORECASE,
)
ACTIVATION_DECLARE_TEXT_RE = re.compile(
    r"\bdeclare\b[^;.!?]*;", re.IGNORECASE
)


def count_top_level_arguments(arguments: str) -> int:
    if not arguments.strip():
        return 0
    depth = 0
    count = 1
    for character in arguments:
        if character in "([{":
            depth += 1
        elif character in ")]}":
            depth -= 1
        elif character == "," and depth == 0:
            count += 1
    return count


def resolve_expression(
    expression: str, card_id: int, constants: dict[str, int]
) -> int | None:
    expression = re.sub(r"\s+", "", expression)
    if expression.isdigit():
        return int(expression)
    if expression == "id":
        return card_id
    match = re.fullmatch(r"id\+(\d+)", expression)
    if match:
        return card_id + int(match.group(1))
    return constants.get(expression)


def find_raw_spsummon_proc_targets(
    text: str,
) -> list[tuple[str, list[str], str]]:
    """Return raw summon-procedure target callbacks and their bodies.

    Omega's target callback receives the candidate card and optional material
    constraints, but unlike Project Ignis it does not provide a mutable `sg`
    material group. It also expects material selection during the target call
    itself, not behind the normal-effect `chk == 0` gate.
    """

    callbacks: list[tuple[str, list[str], str]] = []
    for code_match in SPSUMMON_PROC_CODE_RE.finditer(text):
        effect_name = code_match.group(1)
        tail = text[code_match.end() : code_match.end() + 4000]
        registration = re.search(
            rf"\b[A-Za-z_]\w*:RegisterEffect\(\s*"
            rf"{re.escape(effect_name)}\s*\)",
            tail,
        )
        segment = tail[: registration.end() if registration else 1500]
        target = re.search(
            rf"\b{re.escape(effect_name)}:SetTarget\(\s*"
            r"s\.([A-Za-z_]\w*)\s*\)",
            segment,
        )
        if not target:
            continue
        callback_name = target.group(1)
        definition = re.search(
            rf"^\s*function\s+s\.{re.escape(callback_name)}\s*"
            r"\(([^\)]*)\)(.*?)(?=^\s*function\s+|\Z)",
            text,
            re.MULTILINE | re.DOTALL,
        )
        if not definition:
            continue
        arguments = [
            argument.strip()
            for argument in definition.group(1).split(",")
            if argument.strip()
        ]
        callbacks.append((callback_name, arguments, definition.group(2)))
    return callbacks


def has_activation_time_code(text: str, pattern: str) -> bool:
    """Return whether a non-operation callback performs an activation action."""

    operation_callbacks = set(OPERATION_CALLBACK_RE.findall(text))
    procedure_operations = set(SPSUMMON_PROC_OPERATION_RE.findall(text))
    procedure_operations = {
        match[1] if isinstance(match, tuple) else match
        for match in procedure_operations
    }
    return any(
        (
            block.group("name") not in operation_callbacks
            or block.group("name") in procedure_operations
        )
        and re.search(pattern, block.group("body"))
        for block in FUNCTION_BLOCK_RE.finditer(text)
    )


def row_for_id(
    custom: sqlite3.Connection, official: sqlite3.Connection, card_id: int
) -> tuple[str, sqlite3.Row] | None:
    query = """
        select d.id, d.ot, d.type, t.name
        from datas d left join texts t on d.id=t.id
        where d.id=?
    """
    row = custom.execute(query, (card_id,)).fetchone()
    if row is not None:
        return "custom", row
    row = official.execute(query, (card_id,)).fetchone()
    if row is not None:
        return "official", row
    return None


def database_setcodes(connection: sqlite3.Connection) -> set[int]:
    codes: set[int] = set()
    for (blob,) in connection.execute(
        "select setcode from datas where setcode is not null"
    ):
        if isinstance(blob, int):
            if blob:
                codes.add(blob)
        else:
            codes.update(decode_setcodes(blob))
    return codes


def main() -> int:
    parser = argparse.ArgumentParser(description=__doc__)
    parser.add_argument("--cards", type=Path, default=DEFAULT_CARDS)
    parser.add_argument("--scripts", type=Path, default=DEFAULT_SCRIPTS)
    parser.add_argument("--db", type=Path, default=DEFAULT_DB)
    parser.add_argument("--official-db", type=Path, default=DEFAULT_OFFICIAL_DB)
    parser.add_argument(
        "--official-scripts", type=Path, default=DEFAULT_OFFICIAL_SCRIPTS
    )
    args = parser.parse_args()

    cards = json.loads(args.cards.read_text(encoding="utf-8-sig"))
    active = {
        int(card["passcode"]): str(card.get("name") or "")
        for card in cards
        if card.get("passcode") is not None
    }
    categories = {
        int(card["passcode"]): str(card.get("category") or "")
        for card in cards
        if card.get("passcode") is not None
    }
    effect_texts = {
        int(card["passcode"]): str(card.get("text") or "")
        for card in cards
        if card.get("passcode") is not None
    }
    script_paths = {
        int(match.group(1)): path
        for path in args.scripts.glob("c*.lua")
        if (match := re.fullmatch(r"c(\d+)\.lua", path.name))
    }
    errors: list[str] = []
    orphan_ids = sorted(set(script_paths) - set(active) - COMPATIBILITY_SCRIPT_IDS)
    missing_scripts = sorted(set(active) - set(script_paths))
    missing_compatibility = sorted(COMPATIBILITY_SCRIPT_IDS - set(script_paths))
    for card_id in missing_scripts:
        errors.append(f"active card {card_id} ({active[card_id]}) has no Lua script")
    for card_id in missing_compatibility:
        errors.append(f"legacy compatibility card {card_id} has no Lua script")

    custom = sqlite3.connect(f"file:{args.db.resolve().as_posix()}?mode=ro", uri=True)
    official = sqlite3.connect(
        f"file:{args.official_db.resolve().as_posix()}?mode=ro", uri=True
    )
    custom.row_factory = sqlite3.Row
    official.row_factory = sqlite3.Row
    create_token_calls = 0
    create_token_targets: set[int] = set()
    summon_code_checks = 0
    summon_code_targets: set[int] = set()
    static_copy_targets: set[int] = set()
    dynamic_copy_calls = 0
    loaded_card_scripts: set[int] = set()
    synchro_procedure_calls = 0
    link_procedure_calls = 0
    chain_material_select_calls = 0
    modern_procedure_namespace_calls = 0
    direct_link_custom_filters = 0
    modern_link_group_filter_signatures = 0
    zero_argument_link_api_calls = 0
    current_chain_plus_one_calls = 0
    galaxy_race_scripts = 0
    cannot_activate_callbacks = 0
    raw_spsummon_proc_targets = 0
    referenced_setcodes: dict[int, list[str]] = {}
    referenced_card_ids: dict[int, list[str]] = {}
    spell_trap_activation_scripts = 0
    quick_effect_scripts = 0
    opponent_summon_choice_scripts = 0
    delayed_optional_summon_triggers = 0
    activation_reveal_scripts = 0
    activation_choose_scripts = 0
    activation_target_scripts = 0
    activation_place_scripts = 0
    activation_roll_scripts = 0
    activation_declare_scripts = 0
    try:
        known_setcodes = database_setcodes(custom) | database_setcodes(official)
        known_card_ids = {
            int(row[0]) for row in custom.execute("select id from datas")
        } | {
            int(row[0]) for row in official.execute("select id from datas")
        }
        known_card_ids.update(COMPATIBILITY_SCRIPT_IDS)
        for card_id, name in active.items():
            row = custom.execute(
                "select d.id, t.name from datas d left join texts t on d.id=t.id where d.id=?",
                (card_id,),
            ).fetchone()
            if row is None:
                errors.append(f"active card {card_id} ({name}) has no custom DB row")
            elif not row["name"]:
                errors.append(f"active card {card_id} has no localized DB name")

        for token in EXTRA_TOKEN_CARDS:
            token_id = int(token["id"])
            row = custom.execute(
                "select d.type, t.name from datas d left join texts t on d.id=t.id where d.id=?",
                (token_id,),
            ).fetchone()
            if row is None:
                errors.append(f"managed auxiliary Token {token_id} is missing")
            elif not row["name"]:
                errors.append(f"managed auxiliary Token {token_id} has no name")

        for card_id, path in sorted(script_paths.items()):
            text = path.read_text(encoding="utf-8")
            if categories.get(card_id) in {"Spell", "Trap"}:
                if "EFFECT_TYPE_ACTIVATE" not in text:
                    errors.append(
                        f"{path.name}: {categories[card_id]} script has no "
                        "EFFECT_TYPE_ACTIVATE registration"
                    )
                else:
                    spell_trap_activation_scripts += 1
            if "(Quick Effect)" in effect_texts.get(card_id, ""):
                if "EFFECT_TYPE_QUICK" not in text:
                    errors.append(
                        f"{path.name}: printed text contains `(Quick Effect)` "
                        "but the script has no EFFECT_TYPE_QUICK registration"
                    )
                else:
                    quick_effect_scripts += 1
            printed_text = effect_texts.get(card_id, "")
            if ACTIVATION_REVEAL_TEXT_RE.search(printed_text):
                activation_reveal_scripts += 1
                if not has_activation_time_code(text, r"\bDuel\.ConfirmCards\s*\("):
                    errors.append(
                        f"{path.name}: printed reveal/show occurs before a "
                        "semicolon, but ConfirmCards only occurs during resolution"
                    )
            if ACTIVATION_CHOOSE_TEXT_RE.search(printed_text):
                activation_choose_scripts += 1
                if not has_activation_time_code(
                    text, r"\bDuel\.(?:SelectMatchingCard|SelectTarget)\s*\("
                ):
                    errors.append(
                        f"{path.name}: printed choice occurs before a semicolon, "
                        "but no card is selected during activation"
                    )
            if ACTIVATION_TARGET_TEXT_RE.search(printed_text):
                activation_target_scripts += 1
                if not has_activation_time_code(
                    text, r"\bDuel\.(?:SelectTarget|SetTargetCard)\s*\("
                ):
                    errors.append(
                        f"{path.name}: printed target occurs before a semicolon, "
                        "but no target is established during activation"
                    )
            if ACTIVATION_PLACE_TEXT_RE.search(printed_text):
                activation_place_scripts += 1
                if not has_activation_time_code(
                    text, r"\bDuel\.(?:MoveToField|SendtoDeck)\s*\("
                ):
                    errors.append(
                        f"{path.name}: printed placement occurs before a semicolon, "
                        "but the card is only moved during resolution"
                    )
            if ACTIVATION_ROLL_TEXT_RE.search(printed_text):
                activation_roll_scripts += 1
                if not has_activation_time_code(text, r"\bDuel\.TossDice\s*\("):
                    errors.append(
                        f"{path.name}: printed die roll occurs before a semicolon, "
                        "but the roll only occurs during resolution"
                    )
            if ACTIVATION_DECLARE_TEXT_RE.search(printed_text):
                activation_declare_scripts += 1
                if not has_activation_time_code(
                    text, r"\bDuel\.Announce(?:Card|Level|Number)\s*\("
                ):
                    errors.append(
                        f"{path.name}: printed declaration occurs before a "
                        "semicolon, but the value is only announced during "
                        "resolution"
                    )
            if OPPONENT_SUMMON_CHOICE_TEXT_RE.search(printed_text):
                opponent_summon_choice_scripts += 1
                if not OPPONENT_SUMMON_CHOICE_CODE_RE.search(text):
                    errors.append(
                        f"{path.name}: printed text lets the opponent choose between "
                        "a Normal or Special Summon, but the script has no opponent "
                        "Duel.SelectOption call using Omega strings 1151/1152"
                    )
            if OPTIONAL_IF_SUMMONED_TEXT_RE.search(printed_text):
                for block in EFFECT_REGISTRATION_BLOCK_RE.finditer(text):
                    body = block.group("body")
                    if (
                        "EFFECT_TYPE_TRIGGER_O" in body
                        and "EVENT_SPSUMMON_SUCCESS" in body
                    ):
                        if "EFFECT_FLAG_DELAY" not in body:
                            errors.append(
                                f"{path.name}: optional `If this card is Summoned` "
                                f"trigger {block.group('effect')} lacks "
                                "EFFECT_FLAG_DELAY and can miss timing"
                            )
                        else:
                            delayed_optional_summon_triggers += 1
            for setcode_name, value in SETCODE_CONSTANT_RE.findall(text):
                setcode = int(value, 0)
                referenced_setcodes.setdefault(setcode, []).append(
                    f"{path.name}:{setcode_name}"
                )
            for value in IS_SETCARD_LITERAL_RE.findall(text):
                setcode = int(value, 0)
                referenced_setcodes.setdefault(setcode, []).append(
                    f"{path.name}:literal"
                )
            for constant_name, value in CARD_CODE_CONSTANT_RE.findall(text):
                referenced_card_ids.setdefault(int(value), []).append(
                    f"{path.name}:{constant_name}"
                )
            for value in CARD_CODE_LITERAL_RE.findall(text):
                referenced_card_ids.setdefault(int(value), []).append(
                    f"{path.name}:literal"
                )
            for target_id in map(int, LOAD_CARD_SCRIPT_RE.findall(text)):
                loaded_card_scripts.add(target_id)
                if target_id not in script_paths:
                    errors.append(
                        f"{path.name}: loaded card script c{target_id}.lua is missing"
                    )
            for match in OMEGA_HELPER_CALL_RE.finditer(text):
                helper_name = match.group(1)
                if helper_name == "AddSynchroProcedure":
                    synchro_procedure_calls += 1
                elif helper_name == "AddLinkProcedure":
                    link_procedure_calls += 1
                argument_count = count_top_level_arguments(match.group(2))
                max_arguments = OMEGA_HELPER_MAX_ARGUMENTS[helper_name]
                if argument_count > max_arguments:
                    errors.append(
                        f"{path.name}: aux.{helper_name} has {argument_count} "
                        f"arguments, but Omega supports at most {max_arguments}"
                    )
            namespace_calls = MODERN_PROCEDURE_NAMESPACE_RE.findall(text)
            modern_procedure_namespace_calls += len(namespace_calls)
            if namespace_calls:
                errors.append(
                    f"{path.name}: uses a modern procedure namespace that is not "
                    "provided by the official Omega helpers"
                )
            for variable_name in CHAIN_MATERIAL_ASSIGN_RE.findall(text):
                select_re = re.compile(rf"\b{re.escape(variable_name)}:Select\s*\(")
                select_calls = len(select_re.findall(text))
                chain_material_select_calls += select_calls
                if select_calls:
                    errors.append(
                        f"{path.name}: calls {variable_name}:Select on Omega's Chain "
                        "Material effect; use Duel.SelectFusionMaterial"
                    )
            for filter_name in DIRECT_LINK_CUSTOM_FILTER_RE.findall(text):
                direct_link_custom_filters += 1
                definition_re = re.compile(
                    rf"^\s*function\s+s\.{re.escape(filter_name)}\s*"
                    r"\(([^\)]*)\)",
                    re.MULTILINE,
                )
                definition = definition_re.search(text)
                if definition and count_top_level_arguments(definition.group(1)) > 1:
                    errors.append(
                        f"{path.name}: direct Omega Link material filter s."
                        f"{filter_name} accepts summon-context arguments that Omega "
                        "does not pass; use a one-card filter or an explicit closure"
                    )
            modern_group_filters = len(
                MODERN_LINK_GROUP_FILTER_SIGNATURE_RE.findall(text)
            )
            modern_link_group_filter_signatures += modern_group_filters
            if modern_group_filters:
                errors.append(
                    f"{path.name}: uses a Project Ignis-style four-argument Link "
                    "group filter; Omega passes (group, link_card, player)"
                )
            zero_argument_link_calls = ZERO_ARGUMENT_LINK_API_RE.findall(text)
            zero_argument_link_api_calls += len(zero_argument_link_calls)
            if zero_argument_link_calls:
                errors.append(
                    f"{path.name}: calls an Omega Link API without its card/group "
                    "argument"
                )
            chain_plus_one_calls = len(CURRENT_CHAIN_PLUS_ONE_RE.findall(text))
            current_chain_plus_one_calls += chain_plus_one_calls
            if chain_plus_one_calls:
                errors.append(
                    f"{path.name}: adds 1 to Duel.GetCurrentChain() directly; "
                    "Omega already includes the resolving card during target "
                    "selection, so use chk-aware counting"
                )
            if RACE_GALAXY_RE.search(text):
                galaxy_race_scripts += 1
                if not LOCAL_CCG_RACE_GALAXY_RE.search(text):
                    errors.append(
                        f"{path.name}: RACE_GALAXY is not pinned to the CCG race "
                        "value 0x80000000; Omega's Rush helper sets it to 0x40000000"
                    )
            for callback in CANNOT_ACTIVATE_VALUE_RE.finditer(text):
                cannot_activate_callbacks += 1
                inline_arguments = callback.group("inline")
                if inline_arguments is not None:
                    argument_count = count_top_level_arguments(inline_arguments)
                else:
                    callback_name = callback.group("named")
                    definition_re = re.compile(
                        rf"^\s*function\s+{re.escape(callback_name)}\s*"
                        r"\(([^\)]*)\)",
                        re.MULTILINE,
                    )
                    definition = definition_re.search(text)
                    if not definition:
                        errors.append(
                            f"{path.name}: cannot resolve {callback_name} used by "
                            "EFFECT_CANNOT_ACTIVATE"
                        )
                        continue
                    argument_count = count_top_level_arguments(definition.group(1))
                if argument_count < 2:
                    errors.append(
                        f"{path.name}: EFFECT_CANNOT_ACTIVATE callback accepts "
                        f"{argument_count} argument(s); Omega passes at least "
                        "(effect, activating_effect)"
                    )
            for callback_name, arguments, body in find_raw_spsummon_proc_targets(
                text
            ):
                raw_spsummon_proc_targets += 1
                if len(arguments) > 10 and arguments[10] == "sg":
                    errors.append(
                        f"{path.name}: raw EFFECT_SPSUMMON_PROC target s."
                        f"{callback_name} expects a Project Ignis material group "
                        "`sg`; Omega does not pass that argument"
                    )
                if (
                    len(arguments) > 9
                    and arguments[8:10] == ["chk", "c"]
                    and re.search(r"\bif\s+chk\s*==\s*0", body)
                ):
                    errors.append(
                        f"{path.name}: raw EFFECT_SPSUMMON_PROC target s."
                        f"{callback_name} gates material selection behind "
                        "`chk == 0`; Omega requires selection during the target call"
                    )
            constants = {name: int(value) for name, value in CONSTANT_RE.findall(text)}
            for match in CREATE_TOKEN_RE.finditer(text):
                create_token_calls += 1
                expression = match.group(1)
                target_id = resolve_expression(expression, card_id, constants)
                if target_id is None:
                    errors.append(
                        f"{path.name}: unresolved Duel.CreateToken ID {expression!r}"
                    )
                    continue
                create_token_targets.add(target_id)
                if row_for_id(custom, official, target_id) is None:
                    errors.append(
                        f"{path.name}: Duel.CreateToken target {target_id} has no DB row"
                    )

            for match in CAN_SUMMON_CODE_RE.finditer(text):
                summon_code_checks += 1
                expression = match.group(1)
                target_id = resolve_expression(expression, card_id, constants)
                if target_id is None:
                    errors.append(
                        f"{path.name}: unresolved IsPlayerCanSpecialSummonMonster ID "
                        f"{expression!r}"
                    )
                    continue
                summon_code_targets.add(target_id)
                if row_for_id(custom, official, target_id) is None:
                    errors.append(
                        f"{path.name}: summon-legality target {target_id} has no DB row"
                    )

            for match in COPY_EFFECT_RE.finditer(text):
                expression = match.group(1)
                target_id = resolve_expression(expression, card_id, constants)
                if target_id is None:
                    dynamic_copy_calls += 1
                    continue
                static_copy_targets.add(target_id)
                source = row_for_id(custom, official, target_id)
                if source is None:
                    errors.append(
                        f"{path.name}: CopyEffect target {target_id} has no DB row"
                    )
                    continue
                source_name, row = source
                if int(row["type"] or 0) & 0x4000:
                    continue
                if source_name == "custom" and target_id not in script_paths:
                    errors.append(
                        f"{path.name}: custom CopyEffect target {target_id} has no Lua script"
                    )
                if source_name == "official" and not any(
                    args.official_scripts.rglob(f"c{target_id}.lua")
                ):
                    errors.append(
                        f"{path.name}: official CopyEffect target {target_id} has no reference script"
                    )
        for setcode, references in sorted(referenced_setcodes.items()):
            if setcode not in known_setcodes:
                errors.append(
                    f"setcode {setcode:#x} used by {', '.join(references[:8])} "
                    "has no card row in either the CCG or official Omega database"
                )
        for referenced_id, references in sorted(referenced_card_ids.items()):
            if referenced_id not in known_card_ids:
                errors.append(
                    f"card ID {referenced_id} used by "
                    f"{', '.join(references[:8])} has no card row in either the "
                    "CCG or official Omega database"
                )
    finally:
        custom.close()
        official.close()

    print(f"active_cards={len(active)}")
    print(f"public_scripts={len(script_paths)}")
    print(f"missing_active_scripts={len(missing_scripts)}")
    print(f"missing_compatibility_scripts={len(missing_compatibility)}")
    print(f"preserved_orphan_scripts={len(orphan_ids)}")
    print(f"loaded_card_scripts={len(loaded_card_scripts)}")
    print(f"synchro_procedure_calls={synchro_procedure_calls}")
    print(f"link_procedure_calls={link_procedure_calls}")
    print(f"modern_procedure_namespace_calls={modern_procedure_namespace_calls}")
    print(f"chain_material_select_calls={chain_material_select_calls}")
    print(f"direct_link_custom_filters={direct_link_custom_filters}")
    print(
        "modern_link_group_filter_signatures="
        f"{modern_link_group_filter_signatures}"
    )
    print(f"zero_argument_link_api_calls={zero_argument_link_api_calls}")
    print(f"current_chain_plus_one_calls={current_chain_plus_one_calls}")
    print(f"galaxy_race_scripts={galaxy_race_scripts}")
    print(f"cannot_activate_callbacks={cannot_activate_callbacks}")
    print(f"raw_spsummon_proc_targets={raw_spsummon_proc_targets}")
    print(f"referenced_setcodes={len(referenced_setcodes)}")
    print(f"referenced_card_ids={len(referenced_card_ids)}")
    print(f"spell_trap_activation_scripts={spell_trap_activation_scripts}")
    print(f"quick_effect_scripts={quick_effect_scripts}")
    print(f"opponent_summon_choice_scripts={opponent_summon_choice_scripts}")
    print(
        "delayed_optional_summon_triggers="
        f"{delayed_optional_summon_triggers}"
    )
    print(f"activation_reveal_scripts={activation_reveal_scripts}")
    print(f"activation_choose_scripts={activation_choose_scripts}")
    print(f"activation_target_scripts={activation_target_scripts}")
    print(f"activation_place_scripts={activation_place_scripts}")
    print(f"activation_roll_scripts={activation_roll_scripts}")
    print(f"activation_declare_scripts={activation_declare_scripts}")
    print(f"create_token_calls={create_token_calls}")
    print(f"create_token_targets={len(create_token_targets)}")
    print(f"summon_code_checks={summon_code_checks}")
    print(f"summon_code_targets={len(summon_code_targets)}")
    print(f"static_copy_effect_targets={len(static_copy_targets)}")
    print(f"dynamic_copy_effect_calls={dynamic_copy_calls}")
    print(f"errors={len(errors)}")
    for error in errors[:50]:
        print(f"ERROR {error}")
    if orphan_ids:
        print("orphan_ids=" + ",".join(str(card_id) for card_id in orphan_ids))
    return 1 if errors else 0


if __name__ == "__main__":
    raise SystemExit(main())

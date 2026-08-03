#!/usr/bin/env python3
"""Run every CCG card's pure callbacks in an Omega-shaped Lua smoke runtime."""

from __future__ import annotations

import argparse
from pathlib import Path
import re
import shutil
import subprocess


ROOT = Path(__file__).resolve().parents[1]
DEFAULT_SCRIPTS = ROOT / "public" / "CCG Downloads" / "CCG_Scripts"
DEFAULT_HARNESS = ROOT / "scripts" / "omega_callback_smoke.lua"
SCRIPT_NAME_RE = re.compile(r"c(\d+)\.lua")
TRAP_ACT_IN_HAND_BLOCK_RE = re.compile(
    r"SetCode\s*\(\s*EFFECT_TRAP_ACT_IN_HAND\s*\)"
    r"(?P<body>.*?)(?=\b(?:c|[A-Za-z_]\w*)\s*:\s*RegisterEffect\s*\()",
    re.DOTALL,
)
INLINE_CONDITION_RE = re.compile(
    r"SetCondition\s*\(\s*function\s*\(([^)]*)\)",
)
NAMED_CONDITION_RE = re.compile(
    r"SetCondition\s*\(\s*(s|c\d+)\.(\w+)\s*\)",
)


def callback_parameters(value: str) -> list[str]:
    return [part.strip() for part in value.split(",") if part.strip()]


def verify_trap_act_in_hand_contract(path: Path) -> list[str]:
    """Omega supplies only the Effect to EFFECT_TRAP_ACT_IN_HAND conditions."""

    source = path.read_text(encoding="utf-8")
    failures: list[str] = []
    for block in TRAP_ACT_IN_HAND_BLOCK_RE.finditer(source):
        body = block.group("body")
        if inline := INLINE_CONDITION_RE.search(body):
            parameters = callback_parameters(inline.group(1))
            if parameters != ["e"]:
                failures.append(
                    "inline EFFECT_TRAP_ACT_IN_HAND condition must accept only e; "
                    f"found ({', '.join(parameters)})"
                )
            continue
        named = NAMED_CONDITION_RE.search(body)
        if not named:
            continue
        namespace, name = named.groups()
        definition = re.search(
            rf"function\s+{re.escape(namespace)}\.{re.escape(name)}\s*\(([^)]*)\)",
            source,
        )
        if definition is None:
            failures.append(
                f"cannot find EFFECT_TRAP_ACT_IN_HAND condition {namespace}.{name}"
            )
            continue
        parameters = callback_parameters(definition.group(1))
        if parameters != ["e"]:
            failures.append(
                f"{namespace}.{name} must accept only e for "
                "EFFECT_TRAP_ACT_IN_HAND; "
                f"found ({', '.join(parameters)})"
            )
    return failures


def main() -> int:
    parser = argparse.ArgumentParser(description=__doc__)
    parser.add_argument("--scripts", type=Path, default=DEFAULT_SCRIPTS)
    parser.add_argument("--harness", type=Path, default=DEFAULT_HARNESS)
    parser.add_argument("--lua", default=None, help="Lua executable (defaults to PATH).")
    args = parser.parse_args()

    lua = args.lua or shutil.which("lua")
    if not lua:
        raise SystemExit("Lua executable not found on PATH")
    if not args.harness.is_file():
        raise SystemExit(f"Omega callback harness is missing: {args.harness}")

    scripts: list[tuple[int, Path]] = []
    for path in args.scripts.glob("c*.lua"):
        match = SCRIPT_NAME_RE.fullmatch(path.name)
        if match:
            scripts.append((int(match.group(1)), path))
    scripts.sort()

    callback_count = 0
    failures: list[str] = []
    for card_id, path in scripts:
        for failure in verify_trap_act_in_hand_contract(path):
            failures.append(f"{path.name}: {failure}")
        result = subprocess.run(
            [lua, str(args.harness), str(path), str(card_id)],
            check=False,
            capture_output=True,
            text=True,
            timeout=10,
        )
        output = "\n".join(
            part.strip() for part in (result.stdout, result.stderr) if part.strip()
        )
        if match := re.search(r"\bcalls=(\d+)\b", output):
            callback_count += int(match.group(1))
        if result.returncode:
            failures.append(f"{path.name}: {output or 'callback smoke failed'}")

    print(f"scripts={len(scripts)}")
    print(f"callbacks={callback_count}")
    print(f"errors={len(failures)}")
    for failure in failures[:50]:
        print(f"ERROR {failure}")
    return 1 if failures else 0


if __name__ == "__main__":
    raise SystemExit(main())

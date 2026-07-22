#!/usr/bin/env python3
"""Route custom-card aux.Stringid calls through signed-safe Omega carriers."""

from __future__ import annotations

import argparse
import json
from pathlib import Path
import re

from sync_omega_ccg_db import build_message_carrier_map


ROOT = Path(__file__).resolve().parents[1]
DEFAULT_CARDS = ROOT / "src" / "data" / "cards.json"
DEFAULT_SCRIPTS = ROOT / "public" / "CCG Downloads" / "CCG_Scripts"

GET_ID_RE = re.compile(
    r"^(?P<indent>\s*)local\s+s\s*,\s*id(?:\s*,\s*[A-Za-z_]\w*)*\s*=\s*GetID\(\)\s*$",
    re.MULTILINE,
)
STRING_ID_RE = re.compile(r"^(?P<indent>\s*)local\s+STRING_ID\s*=\s*[^\r\n]+$", re.MULTILINE)
OWN_STRING_CALL_RE = re.compile(r"aux\.Stringid\s*\(\s*id\s*,")
UNSAFE_OWN_CALL_RE = re.compile(r"aux\.Stringid\s*\(\s*id\s*,")


def rewrite_script(text: str, carrier_id: int) -> str:
    if "aux.Stringid" not in text:
        return text

    text = OWN_STRING_CALL_RE.sub("aux.Stringid(STRING_ID,", text)
    declaration = f"local STRING_ID={carrier_id}"
    if STRING_ID_RE.search(text):
        text = STRING_ID_RE.sub(declaration, text, count=1)
    else:
        match = GET_ID_RE.search(text)
        if match is None:
            raise RuntimeError("Script uses aux.Stringid but has no local s,id=GetID() declaration")
        insert_at = match.end()
        text = text[:insert_at] + "\n" + declaration + text[insert_at:]
    return text


def main() -> int:
    parser = argparse.ArgumentParser(description=__doc__)
    parser.add_argument("--cards", type=Path, default=DEFAULT_CARDS)
    parser.add_argument("--scripts", type=Path, default=DEFAULT_SCRIPTS)
    parser.add_argument("--write", action="store_true", help="Apply rewrites; default is a dry run")
    args = parser.parse_args()

    cards = json.loads(args.cards.read_text(encoding="utf-8-sig"))
    carrier_map = build_message_carrier_map(cards)
    changed = 0
    routed_calls = 0
    missing_scripts: list[int] = []
    unsafe_after: list[str] = []

    for card_id, carrier_id in sorted(carrier_map.items()):
        script_path = args.scripts / f"c{card_id}.lua"
        if not script_path.exists():
            missing_scripts.append(card_id)
            continue
        original = script_path.read_text(encoding="utf-8")
        rewritten = rewrite_script(original, carrier_id)
        routed_calls += len(re.findall(r"aux\.Stringid\s*\(\s*STRING_ID\s*,", rewritten))
        if UNSAFE_OWN_CALL_RE.search(rewritten):
            unsafe_after.append(script_path.name)
        if rewritten != original:
            changed += 1
            if args.write:
                script_path.write_text(rewritten, encoding="utf-8", newline="")

    if unsafe_after:
        raise RuntimeError(f"Unsafe own-card aux.Stringid calls remain: {unsafe_after}")

    mode = "write" if args.write else "dry-run"
    print(f"mode={mode}")
    print(f"cards_mapped={len(carrier_map)}")
    print(f"scripts_changed={changed}")
    print(f"own_card_calls_routed={routed_calls}")
    print(f"cards_without_scripts={len(missing_scripts)}")
    return 0


if __name__ == "__main__":
    raise SystemExit(main())

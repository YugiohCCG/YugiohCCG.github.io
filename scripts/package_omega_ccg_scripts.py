"""Build the installer Lua payload from the active CCG card list.

Only standalone ``c<ID>.lua`` files whose IDs occur in ``cards.json`` are
eligible for the archive.  This deliberately rejects orphan card scripts and
shared helper modules so the installer cannot leak either into Omega's global
Scripts directory.
"""
from __future__ import annotations

import argparse
import json
import re
import zipfile
from pathlib import Path


REPO_ROOT = Path(__file__).resolve().parents[1]
DEFAULT_CARDS_PATH = REPO_ROOT / "src" / "data" / "cards.json"
DEFAULT_SCRIPTS_DIR = REPO_ROOT / "public" / "CCG Downloads" / "CCG_Scripts"
DEFAULT_ZIP_PATH = DEFAULT_SCRIPTS_DIR / "CCG_Scripts.zip"
CARD_SCRIPT_RE = re.compile(r"^c(\d+)\.lua$")


def load_card_ids(cards_path: Path) -> set[int]:
    cards = json.loads(cards_path.read_text(encoding="utf-8"))
    ids: list[int] = []
    for index, card in enumerate(cards):
        passcode = card.get("passcode")
        if passcode is None:
            raise ValueError(f"cards.json entry {index} has no passcode")
        ids.append(int(passcode))
    duplicates = sorted(card_id for card_id in set(ids) if ids.count(card_id) > 1)
    if duplicates:
        raise ValueError(f"duplicate cards.json passcodes: {duplicates}")
    return set(ids)


def collect_scripts(scripts_dir: Path, card_ids: set[int]) -> list[Path]:
    lua_files = sorted(scripts_dir.glob("*.lua"), key=lambda path: path.name)
    by_id: dict[int, Path] = {}
    helpers: list[str] = []
    for path in lua_files:
        match = CARD_SCRIPT_RE.fullmatch(path.name)
        if match is None:
            helpers.append(path.name)
            continue
        by_id[int(match.group(1))] = path

    missing = sorted(card_ids - set(by_id))
    orphaned = sorted(set(by_id) - card_ids)
    errors: list[str] = []
    if missing:
        errors.append("missing active card scripts: " + ", ".join(map(str, missing)))
    if orphaned:
        errors.append("orphan card scripts: " + ", ".join(map(str, orphaned)))
    if helpers:
        errors.append("shared/helper Lua files are not allowed: " + ", ".join(helpers))
    if errors:
        raise ValueError("; ".join(errors))

    return [by_id[card_id] for card_id in sorted(card_ids)]


def build_archive(script_paths: list[Path], zip_path: Path) -> None:
    zip_path.parent.mkdir(parents=True, exist_ok=True)
    temp_path = zip_path.with_suffix(zip_path.suffix + ".tmp")
    try:
        with zipfile.ZipFile(
            temp_path,
            "w",
            compression=zipfile.ZIP_DEFLATED,
            compresslevel=9,
        ) as archive:
            for path in script_paths:
                archive.write(path, arcname=path.name)
        temp_path.replace(zip_path)
    finally:
        temp_path.unlink(missing_ok=True)


def verify_archive(script_paths: list[Path], zip_path: Path) -> None:
    expected_names = [path.name for path in script_paths]
    with zipfile.ZipFile(zip_path, "r") as archive:
        actual_names = archive.namelist()
        if actual_names != expected_names:
            raise ValueError("CCG_Scripts.zip entry list does not match active scripts")
        for path in script_paths:
            if archive.read(path.name) != path.read_bytes():
                raise ValueError(f"CCG_Scripts.zip content mismatch: {path.name}")


def main() -> int:
    parser = argparse.ArgumentParser(
        description="Build a card-only CCG_Scripts.zip for the Omega installer."
    )
    parser.add_argument("--cards", type=Path, default=DEFAULT_CARDS_PATH)
    parser.add_argument("--scripts", type=Path, default=DEFAULT_SCRIPTS_DIR)
    parser.add_argument("--output", type=Path, default=DEFAULT_ZIP_PATH)
    parser.add_argument(
        "--check",
        action="store_true",
        help="Verify the existing archive without rewriting it.",
    )
    args = parser.parse_args()

    try:
        card_ids = load_card_ids(args.cards)
        scripts = collect_scripts(args.scripts, card_ids)
        if not args.check:
            build_archive(scripts, args.output)
        verify_archive(scripts, args.output)
    except (OSError, ValueError, json.JSONDecodeError, zipfile.BadZipFile) as exc:
        raise SystemExit(f"CCG scripts package failed: {exc}") from exc

    action = "verified" if args.check else "wrote"
    print(f"{action} {args.output} ({len(scripts)} standalone CCG card scripts)")
    return 0


if __name__ == "__main__":
    raise SystemExit(main())

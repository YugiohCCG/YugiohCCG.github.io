#!/usr/bin/env python3
"""Register every active CCG card in a matched headless OCGCore duel."""

from __future__ import annotations

import argparse
import os
import shutil
import subprocess
import sys
import tempfile
import zipfile
from pathlib import Path


ROOT = Path(__file__).resolve().parents[1]
NODE_AUDITOR = ROOT / "scripts" / "verify_omega_headless_registration.cjs"
DEFAULT_OUTPUT = ROOT / "scripts" / "output" / "omega_headless_registration_audit.json"
SUPPORT_FILES = ("constant.lua", "utility.lua", "procedure.lua")
REPOSITORY_OMEGA_SCRIPTS = ROOT / "tmp" / "omega_scripts"
OMEGA_SCRIPTS_ZIP_ENV = "CCG_OMEGA_SCRIPTS_ZIP"
OMEGA_SCRIPTS_DIR_ENV = "CCG_OMEGA_SCRIPTS_DIR"


def omega_archive_candidates() -> list[Path]:
    candidates: list[Path] = []
    program_files_x86 = os.environ.get("ProgramFiles(x86)")
    if program_files_x86:
        candidates.append(Path(program_files_x86) / "YGO Omega" / "ygopro-scripts.zip")
    candidates.extend(
        [
            Path(r"C:\Program Files (x86)\YGO Omega\ygopro-scripts.zip"),
            Path(r"C:\Program Files\YGO Omega\ygopro-scripts.zip"),
        ]
    )
    return candidates


def has_support_files(directory: Path) -> bool:
    return directory.is_dir() and all((directory / name).is_file() for name in SUPPORT_FILES)


def extract_support(archive_path: Path, destination: Path) -> None:
    with zipfile.ZipFile(archive_path) as archive:
        by_basename: dict[str, list[str]] = {name: [] for name in SUPPORT_FILES}
        for member in archive.namelist():
            basename = Path(member).name
            if basename in by_basename:
                by_basename[basename].append(member)
        for basename, members in by_basename.items():
            if len(members) != 1:
                raise RuntimeError(
                    f"Omega archive must contain exactly one {basename}; found {len(members)}"
                )
            (destination / basename).write_bytes(archive.read(members[0]))


def copy_support(directory: Path, destination: Path) -> None:
    missing = [name for name in SUPPORT_FILES if not (directory / name).is_file()]
    if missing:
        raise RuntimeError(
            f"Omega scripts directory is missing required support files: {', '.join(missing)}"
        )
    for basename in SUPPORT_FILES:
        shutil.copyfile(directory / basename, destination / basename)


def resolve_support_source(args: argparse.Namespace) -> tuple[str, Path]:
    if args.omega_scripts_zip is not None:
        return "archive", args.omega_scripts_zip.resolve()
    if args.omega_scripts_dir is not None:
        return "directory", args.omega_scripts_dir.resolve()

    environment_archive = os.environ.get(OMEGA_SCRIPTS_ZIP_ENV)
    environment_directory = os.environ.get(OMEGA_SCRIPTS_DIR_ENV)
    if environment_archive and environment_directory:
        raise RuntimeError(
            f"Set only one of {OMEGA_SCRIPTS_ZIP_ENV} and {OMEGA_SCRIPTS_DIR_ENV}"
        )
    if environment_archive:
        return "archive", Path(environment_archive).resolve()
    if environment_directory:
        return "directory", Path(environment_directory).resolve()

    if has_support_files(REPOSITORY_OMEGA_SCRIPTS):
        return "directory", REPOSITORY_OMEGA_SCRIPTS.resolve()
    archive_candidates = omega_archive_candidates()
    archive = next((path for path in archive_candidates if path.is_file()), archive_candidates[0])
    return "archive", archive.resolve()


def main() -> int:
    parser = argparse.ArgumentParser(description=__doc__)
    source = parser.add_mutually_exclusive_group()
    source.add_argument(
        "--omega-scripts-zip",
        type=Path,
        help=f"Path to Omega's ygopro-scripts.zip (or set {OMEGA_SCRIPTS_ZIP_ENV}).",
    )
    source.add_argument(
        "--omega-scripts-dir",
        type=Path,
        help=(
            "Path to extracted official Omega scripts containing constant.lua, utility.lua, "
            f"and procedure.lua (or set {OMEGA_SCRIPTS_DIR_ENV})."
        ),
    )
    parser.add_argument("--output", type=Path, default=DEFAULT_OUTPUT)
    parser.add_argument(
        "--field-probe",
        action="store_true",
        help="Place each card face-up on its natural field zone to exercise field/startup callbacks.",
    )
    args = parser.parse_args()

    try:
        source_kind, source_path = resolve_support_source(args)
    except RuntimeError as exc:
        print(f"ERROR {exc}")
        return 1
    if source_kind == "archive" and not source_path.is_file():
        print(f"ERROR Omega script archive not found: {source_path}")
        return 1
    if source_kind == "directory" and not source_path.is_dir():
        print(f"ERROR Omega scripts directory not found: {source_path}")
        return 1
    if not NODE_AUDITOR.is_file():
        print(f"ERROR Node auditor not found: {NODE_AUDITOR}")
        return 1

    with tempfile.TemporaryDirectory(prefix="ccg-omega-support-") as temporary:
        support_directory = Path(temporary)
        try:
            if source_kind == "archive":
                extract_support(source_path, support_directory)
            else:
                copy_support(source_path, support_directory)
        except (OSError, RuntimeError, zipfile.BadZipFile) as exc:
            print(f"ERROR could not prepare Omega support scripts: {exc}")
            return 1
        command = [
            "node",
            "--no-warnings",
            str(NODE_AUDITOR),
            "--support-dir",
            str(support_directory),
            "--output",
            str(args.output.resolve()),
        ]
        if args.field_probe:
            command.append("--field-probe")
        result = subprocess.run(
            command,
            cwd=ROOT,
            text=True,
            encoding="utf-8",
            errors="replace",
            check=False,
        )
    print(f"omega_scripts_source={source_kind}:{source_path}")
    return result.returncode


if __name__ == "__main__":
    raise SystemExit(main())

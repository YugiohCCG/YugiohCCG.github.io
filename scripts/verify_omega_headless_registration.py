#!/usr/bin/env python3
"""Register every active CCG card in a matched headless OCGCore duel."""

from __future__ import annotations

import argparse
import os
import subprocess
import sys
import tempfile
import zipfile
from pathlib import Path


ROOT = Path(__file__).resolve().parents[1]
NODE_AUDITOR = ROOT / "scripts" / "verify_omega_headless_registration.cjs"
DEFAULT_OUTPUT = ROOT / "scripts" / "output" / "omega_headless_registration_audit.json"
SUPPORT_FILES = ("constant.lua", "utility.lua", "procedure.lua")


def default_omega_archive() -> Path:
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
    return next((path for path in candidates if path.is_file()), candidates[0])


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


def main() -> int:
    parser = argparse.ArgumentParser(description=__doc__)
    parser.add_argument(
        "--omega-scripts-zip",
        type=Path,
        default=default_omega_archive(),
        help="Path to Omega's ygopro-scripts.zip.",
    )
    parser.add_argument("--output", type=Path, default=DEFAULT_OUTPUT)
    parser.add_argument(
        "--field-probe",
        action="store_true",
        help="Place each card face-up on its natural field zone to exercise field/startup callbacks.",
    )
    args = parser.parse_args()

    archive_path = args.omega_scripts_zip.resolve()
    if not archive_path.is_file():
        print(f"ERROR Omega script archive not found: {archive_path}")
        return 1
    if not NODE_AUDITOR.is_file():
        print(f"ERROR Node auditor not found: {NODE_AUDITOR}")
        return 1

    with tempfile.TemporaryDirectory(prefix="ccg-omega-support-") as temporary:
        support_directory = Path(temporary)
        try:
            extract_support(archive_path, support_directory)
        except (OSError, RuntimeError, zipfile.BadZipFile) as exc:
            print(f"ERROR could not extract Omega support scripts: {exc}")
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
    print(f"omega_scripts_zip={archive_path}")
    return result.returncode


if __name__ == "__main__":
    raise SystemExit(main())

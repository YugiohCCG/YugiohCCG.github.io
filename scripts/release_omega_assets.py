"""End-to-end release pipeline for the Omega CCG add-on.

Step 0 (DB sync, unless --skip-db):
  Run `sync_omega_ccg_db.py` against the appropriate CCG_v1.db. The DB target
  follows --use-omega-install just like the image step:

    default            -> public/CCG Downloads/CCG_Database/CCG_v1.db
    --use-omega-install -> C:\\Program Files (x86)\\YGO Omega\\...\\Databases\\CCG_v1.db

  In a publish run (no --export-only), the repo DB is also re-zipped to
  CCG_Database.zip; with --use-omega-install the local DB is first mirrored
  into the repo so the shipped zip stays authoritative.

Then for each image category (Arts / Pics / Holograms):

  1. Run the corresponding `export_omega_ccg_*.py` exporter. Default writes
     per-card files to `tmp/release_staging/`; --use-omega-install writes
     directly into the local Omega install.
  2. Greedily pack the per-card files into <=95 MB ZIP chunks named
     `<base>_v1.zip`, `<base>_v2.zip`, ... directly inside `public/CCG Downloads/`.
     Replaces the manual `zip + scripts/split-images.ps1` flow.
  3. Update the matching part-count constant in
     `scripts/ccg-omega-installer.iss`.

Optional finishing steps (publish run only, never with --export-only):

  --recompile-installer / --iscc <path>
      Run Inno Setup's compiler (ISCC.exe) on scripts/ccg-omega-installer.iss
      and copy the resulting EXE into public/CCG Downloads/ so the part-count
      bumps actually take effect for end users. ISCC is located via --iscc,
      then the INNO_SETUP_PATH / ISCC env vars, then PATH, then the standard
      Inno Setup install dirs.

  --push [--commit-message "<msg>"]
      git add the Omega add-on paths (cards.json, banlist.json,
      public/assets/cards, public/CCG Downloads, scripts/ccg-omega-installer.iss),
      commit them, and push to origin/<current-branch>. Skipped if any earlier
      step failed.

Usage:
  python scripts/release_omega_assets.py [--overwrite] [--use-omega-install]
                                         [--export-only] [--skip-db]
                                         [--skip-images] [--keep-staging]
                                         [--recompile-installer | --iscc <path>]
                                         [--push] [--commit-message "<msg>"]
"""
from __future__ import annotations

import argparse
import json
import os
import re
import shutil
import subprocess
import sys
import zipfile
from collections import OrderedDict
from pathlib import Path

CARDS_JSON_PATH = Path(__file__).resolve().parents[1] / "src" / "data" / "cards.json"

REPO_ROOT = Path(__file__).resolve().parents[1]
SCRIPTS_DIR = REPO_ROOT / "scripts"
PUBLIC_DOWNLOADS = REPO_ROOT / "public" / "CCG Downloads"
INSTALLER_ISS = SCRIPTS_DIR / "ccg-omega-installer.iss"
INSTALLER_BUILD_DIR = SCRIPTS_DIR / "output"  # ISCC writes here per the .iss OutputDir
INSTALLER_BUILD_EXE = INSTALLER_BUILD_DIR / "CCG_Omega_Addon_Setup.exe"
INSTALLER_PUBLISH_EXE = PUBLIC_DOWNLOADS / "CCG_Omega_Addon_Setup.exe"
STAGING_DIR = REPO_ROOT / "tmp" / "release_staging"

OMEGA_INSTALL_ROOT = Path(r"C:\Program Files (x86)\YGO Omega\YGO Omega_Data\Files")
OMEGA_DB_PATH = OMEGA_INSTALL_ROOT / "Databases" / "CCG_v1.db"

REPO_DB_DIR = PUBLIC_DOWNLOADS / "CCG_Database"
REPO_DB_PATH = REPO_DB_DIR / "CCG_v1.db"
REPO_DB_ZIP = REPO_DB_DIR / "CCG_Database.zip"

ISCC_CANDIDATE_PATHS = [
    Path(r"C:\Program Files (x86)\Inno Setup 6\ISCC.exe"),
    Path(r"C:\Program Files\Inno Setup 6\ISCC.exe"),
    Path(r"C:\Program Files (x86)\Inno Setup 5\ISCC.exe"),
    Path(r"C:\Program Files\Inno Setup 5\ISCC.exe"),
]

# Paths that a release run is allowed to git-add. Anything else the user has
# dirty stays out of the auto-commit so unrelated work doesn't get bundled.
GIT_PUBLISH_PATHS = [
    "src/data/cards.json",
    "src/data/banlist.json",
    "public/assets/cards",
    "public/CCG Downloads",
    "scripts/ccg-omega-installer.iss",
]

DEFAULT_PART_BUDGET_BYTES = 95_000_000


# Each entry: exporter script -> {arg name for output dir, staging subdir,
# Omega install subdir, output zip dir, base name, .iss part-count constant}
TASKS = [
    {
        "label": "arts",
        "exporter": "export_omega_ccg_arts.py",
        "exporter_arg": "--arts",
        "staging_subdir": "Arts",
        "omega_subdir": "Arts",
        "zip_output_dir": PUBLIC_DOWNLOADS,
        "zip_base": "YGO_Omega_Images_v",
        "iss_constant": "IMAGE_PART_COUNT",
    },
    {
        "label": "pics",
        "exporter": "export_omega_ccg_pics.py",
        "exporter_arg": "--pics",
        "staging_subdir": "Pics",
        "omega_subdir": "Pics",
        "zip_output_dir": PUBLIC_DOWNLOADS / "YGO_Omega_Images",
        "zip_base": "YGO_Omega_Pics_v",
        "iss_constant": "PICS_PART_COUNT",
    },
    {
        "label": "holograms",
        "exporter": "export_omega_ccg_holograms.py",
        "exporter_arg": "--holograms",
        "staging_subdir": "Holograms",
        "omega_subdir": "Holograms",
        "zip_output_dir": PUBLIC_DOWNLOADS / "YGO_Omega_Images",
        "zip_base": "YGO_Omega_Holograms_v",
        "iss_constant": "HOLOGRAM_PART_COUNT",
    },
]


def run_exporter(task: dict, output_dir: Path, overwrite: bool) -> None:
    cmd: list[str] = [
        sys.executable,
        str(SCRIPTS_DIR / task["exporter"]),
        task["exporter_arg"],
        str(output_dir),
    ]
    if overwrite:
        cmd.append("--overwrite")
    print(f"\n[{task['label']}] running {task['exporter']} -> {output_dir}")
    proc = subprocess.run(cmd, check=False)
    if proc.returncode != 0:
        raise SystemExit(f"{task['exporter']} failed (exit {proc.returncode})")


def remove_existing_parts(output_dir: Path, base: str) -> int:
    pattern = re.compile(rf"^{re.escape(base)}\d+\.zip$")
    removed = 0
    if output_dir.exists():
        for path in output_dir.iterdir():
            if path.is_file() and pattern.match(path.name):
                path.unlink()
                removed += 1
    return removed


def split_into_chunks(source_dir: Path, output_dir: Path, base: str, max_bytes: int) -> int:
    output_dir.mkdir(parents=True, exist_ok=True)
    files = sorted(p for p in source_dir.iterdir() if p.is_file())
    if not files:
        print(f"  no files in {source_dir}; nothing to chunk")
        return 0

    parts: list[list[Path]] = [[]]
    current_size = 0
    for path in files:
        size = path.stat().st_size
        if current_size + size > max_bytes and parts[-1]:
            parts.append([])
            current_size = 0
        parts[-1].append(path)
        current_size += size

    for index, batch in enumerate(parts, start=1):
        zip_path = output_dir / f"{base}{index}.zip"
        with zipfile.ZipFile(zip_path, "w", compression=zipfile.ZIP_DEFLATED) as archive:
            for src in batch:
                archive.write(src, arcname=src.name)
        size_mb = zip_path.stat().st_size / (1024 * 1024)
        print(f"  wrote {zip_path.relative_to(REPO_ROOT)}  ({len(batch)} files, {size_mb:.1f} MB)")
    return len(parts)


def run_db_sync(db_path: Path, full_sync: bool) -> None:
    cmd: list[str] = [
        sys.executable,
        str(SCRIPTS_DIR / "sync_omega_ccg_db.py"),
        "--db",
        str(db_path),
        "--no-backup",
    ]
    if full_sync:
        cmd.append("--full-sync")
    print(f"\n[db] running sync_omega_ccg_db.py -> {db_path}")
    proc = subprocess.run(cmd, check=False)
    if proc.returncode != 0:
        raise SystemExit(f"sync_omega_ccg_db.py failed (exit {proc.returncode})")


def zip_repo_db() -> None:
    REPO_DB_DIR.mkdir(parents=True, exist_ok=True)
    if not REPO_DB_PATH.exists():
        raise SystemExit(f"cannot zip repo DB: {REPO_DB_PATH} does not exist")
    with zipfile.ZipFile(REPO_DB_ZIP, "w", compression=zipfile.ZIP_DEFLATED) as archive:
        archive.write(REPO_DB_PATH, arcname=REPO_DB_PATH.name)
    size_kb = REPO_DB_ZIP.stat().st_size / 1024
    print(f"  wrote {REPO_DB_ZIP.relative_to(REPO_ROOT)}  ({size_kb:.1f} KB)")


def find_iscc(override: Path | None) -> Path | None:
    if override is not None:
        if override.exists():
            return override
        print(f"  [installer] WARN: --iscc path does not exist: {override}")
        return None
    env_value = os.environ.get("INNO_SETUP_PATH") or os.environ.get("ISCC")
    if env_value:
        env_path = Path(env_value)
        if env_path.exists():
            return env_path
    on_path = shutil.which("ISCC") or shutil.which("ISCC.exe")
    if on_path:
        return Path(on_path)
    for candidate in ISCC_CANDIDATE_PATHS:
        if candidate.exists():
            return candidate
    return None


def recompile_installer(iscc_path: Path) -> None:
    print(f"\n[installer] running {iscc_path.name} -> {INSTALLER_ISS.name}")
    INSTALLER_BUILD_DIR.mkdir(parents=True, exist_ok=True)
    proc = subprocess.run(
        [str(iscc_path), str(INSTALLER_ISS)],
        cwd=str(SCRIPTS_DIR),
        check=False,
    )
    if proc.returncode != 0:
        raise SystemExit(f"ISCC failed (exit {proc.returncode})")

    if not INSTALLER_BUILD_EXE.exists():
        raise SystemExit(
            f"ISCC reported success but {INSTALLER_BUILD_EXE} was not produced. "
            f"Check the OutputDir / OutputBaseFilename in {INSTALLER_ISS.name}."
        )

    INSTALLER_PUBLISH_EXE.parent.mkdir(parents=True, exist_ok=True)
    shutil.copy2(INSTALLER_BUILD_EXE, INSTALLER_PUBLISH_EXE)
    size_mb = INSTALLER_PUBLISH_EXE.stat().st_size / (1024 * 1024)
    print(f"  copied {INSTALLER_BUILD_EXE.name} -> {INSTALLER_PUBLISH_EXE.relative_to(REPO_ROOT)}  ({size_mb:.1f} MB)")


def git_run(args: list[str], capture: bool = False) -> subprocess.CompletedProcess:
    return subprocess.run(
        ["git", *args],
        cwd=str(REPO_ROOT),
        check=False,
        capture_output=capture,
        text=True,
    )


def git_publish(commit_message: str) -> bool:
    """Stage GIT_PUBLISH_PATHS, commit, and push. Returns True if anything was pushed."""
    print("\n[git] staging Omega add-on paths...")
    add_proc = git_run(["add", "--", *GIT_PUBLISH_PATHS])
    if add_proc.returncode != 0:
        raise SystemExit(f"git add failed (exit {add_proc.returncode})")

    diff_proc = git_run(["diff", "--cached", "--quiet"])
    if diff_proc.returncode == 0:
        print("  no staged changes; skipping commit and push")
        return False

    status_proc = git_run(["diff", "--cached", "--name-only"], capture=True)
    if status_proc.stdout:
        for line in status_proc.stdout.strip().splitlines():
            print(f"    {line}")

    print(f"\n[git] committing: {commit_message.splitlines()[0]}")
    commit_proc = git_run(["commit", "-m", commit_message])
    if commit_proc.returncode != 0:
        raise SystemExit(f"git commit failed (exit {commit_proc.returncode})")

    branch_proc = git_run(["rev-parse", "--abbrev-ref", "HEAD"], capture=True)
    branch = (branch_proc.stdout or "HEAD").strip()
    print(f"[git] pushing to origin/{branch}...")
    push_proc = git_run(["push", "origin", branch])
    if push_proc.returncode != 0:
        raise SystemExit(f"git push failed (exit {push_proc.returncode})")
    return True


def build_commit_message(
    cards_count: int | None,
    completed: "OrderedDict[str, int]",
    iss_changes: list[tuple[str, int, int]],
    db_zipped: bool,
    installer_recompiled: bool,
    custom_message: str | None,
) -> str:
    if custom_message:
        return custom_message

    pieces: list[str] = []
    if cards_count is not None:
        pieces.append(f"{cards_count} cards in CCG_v1.db")
    if db_zipped:
        pieces.append("refreshed CCG_Database.zip")
    if completed:
        pieces.append(
            "image parts: " + ", ".join(f"{k}={v}" for k, v in completed.items())
        )
    if iss_changes:
        pieces.append(
            "iss bumped: " + ", ".join(f"{n} {old}->{new}" for n, old, new in iss_changes)
        )
    if installer_recompiled:
        pieces.append("recompiled installer EXE")

    summary = "; ".join(pieces) if pieces else "no-op"
    return f"Update Omega CCG add-on assets\n\n{summary}\n"


def update_installer_constant(name: str, value: int) -> tuple[int, int] | None:
    """Update a single .iss constant. Returns (old, new) if changed, None otherwise."""
    if not INSTALLER_ISS.exists():
        print(f"  (no installer .iss found at {INSTALLER_ISS})")
        return None

    text = INSTALLER_ISS.read_text(encoding="utf-8")
    pattern = re.compile(rf"(\b{name}\s*=\s*)(\d+)(\s*;)")
    match = pattern.search(text)
    if not match:
        print(f"  WARN: could not find constant {name} in installer .iss")
        return None
    old_value = int(match.group(2))
    if old_value == value:
        return None
    new_text = pattern.sub(rf"\g<1>{value}\g<3>", text, count=1)
    INSTALLER_ISS.write_text(new_text, encoding="utf-8", newline="\n")
    return (old_value, value)


def main() -> int:
    parser = argparse.ArgumentParser(description="One-shot Omega image release pipeline.")
    parser.add_argument(
        "--overwrite",
        action="store_true",
        help="Force exporters to regenerate every per-card image, even if the file already exists.",
    )
    parser.add_argument(
        "--use-omega-install",
        action="store_true",
        help="Write per-card files to the local Omega install (for in-app testing) instead of the staging dir.",
    )
    parser.add_argument(
        "--max-bytes",
        type=int,
        default=DEFAULT_PART_BUDGET_BYTES,
        help=f"Max uncompressed bytes per zip part (default: {DEFAULT_PART_BUDGET_BYTES:,}).",
    )
    parser.add_argument(
        "--keep-staging",
        action="store_true",
        help="Don't delete the tmp/release_staging directory after building zips.",
    )
    parser.add_argument(
        "--export-only",
        action="store_true",
        help="Run the exporters only. Skip zipping, the .iss update, and staging cleanup. "
        "Combine with --use-omega-install to push fresh assets into your Omega install for "
        "in-game testing without touching the repo.",
    )
    parser.add_argument(
        "--skip-db",
        action="store_true",
        help="Skip the CCG_v1.db sync step (sync_omega_ccg_db.py).",
    )
    parser.add_argument(
        "--skip-images",
        action="store_true",
        help="Skip the image export/zip step (Arts/Pics/Holograms).",
    )
    parser.add_argument(
        "--recompile-installer",
        action="store_true",
        help="After building artifacts, run Inno Setup (ISCC.exe) on "
        "scripts/ccg-omega-installer.iss and copy the resulting EXE into "
        "public/CCG Downloads/CCG_Omega_Addon_Setup.exe.",
    )
    parser.add_argument(
        "--iscc",
        type=Path,
        default=None,
        help="Explicit path to ISCC.exe. Overrides PATH lookup, INNO_SETUP_PATH env var, "
        "and the standard Inno Setup install dirs. Implies --recompile-installer.",
    )
    parser.add_argument(
        "--push",
        action="store_true",
        help="After everything else, git add the Omega add-on paths, commit, and push to origin/<current-branch>.",
    )
    parser.add_argument(
        "--commit-message",
        type=str,
        default=None,
        help="Override the auto-generated commit message used by --push.",
    )
    args = parser.parse_args()

    if args.iscc is not None:
        args.recompile_installer = True
    if args.export_only and (args.recompile_installer or args.push):
        raise SystemExit("--export-only is incompatible with --recompile-installer / --push")

    if args.use_omega_install and not OMEGA_INSTALL_ROOT.exists():
        raise SystemExit(f"--use-omega-install given but {OMEGA_INSTALL_ROOT} does not exist")

    if not args.use_omega_install and not args.skip_images:
        STAGING_DIR.mkdir(parents=True, exist_ok=True)

    completed: "OrderedDict[str, int]" = OrderedDict()
    iss_changes: list[tuple[str, int, int]] = []
    failures: list[tuple[str, str]] = []
    db_synced_to: Path | None = None
    db_zipped = False
    installer_recompiled = False
    cards_count: int | None = None
    try:
        cards_count = len(json.loads(CARDS_JSON_PATH.read_text(encoding="utf-8")))
    except Exception:
        pass

    if not args.skip_db:
        # DB target follows --use-omega-install just like images:
        #   --use-omega-install : sync into the local Omega DB (for in-game testing)
        #   default             : sync directly into the repo's shipped DB copy
        if args.use_omega_install:
            db_target = OMEGA_DB_PATH
        else:
            db_target = REPO_DB_PATH

        if not db_target.exists():
            print(f"  [db] WARN: target DB does not exist: {db_target}")
            print("  [db] skipping DB sync. Either restore the file or pass --skip-db.")
            failures.append(("db", f"missing target DB at {db_target}"))
        else:
            try:
                run_db_sync(db_target, full_sync=True)
                db_synced_to = db_target

                # In a publish run, the repo DB and its zip must be up to date.
                if not args.export_only:
                    if args.use_omega_install and db_target != REPO_DB_PATH:
                        REPO_DB_DIR.mkdir(parents=True, exist_ok=True)
                        shutil.copy2(OMEGA_DB_PATH, REPO_DB_PATH)
                        print(f"  mirrored {OMEGA_DB_PATH.name} -> {REPO_DB_PATH.relative_to(REPO_ROOT)}")
                    zip_repo_db()
                    db_zipped = True
            except SystemExit as exc:
                print(f"  [db] aborted: {exc}")
                failures.append(("db", str(exc)))

    image_tasks = [] if args.skip_images else TASKS
    for task in image_tasks:
        if args.use_omega_install:
            export_dir = OMEGA_INSTALL_ROOT / task["omega_subdir"]
        else:
            export_dir = STAGING_DIR / task["staging_subdir"]

        try:
            run_exporter(task, export_dir, args.overwrite)
        except SystemExit as exc:
            print(f"  [{task['label']}] aborted: {exc}")
            if not args.export_only:
                print(f"  [{task['label']}] keeping previous zips and .iss constant intact.")
            failures.append((task["label"], str(exc)))
            continue

        if args.export_only:
            continue

        removed = remove_existing_parts(task["zip_output_dir"], task["zip_base"])
        if removed:
            print(f"  removed {removed} stale {task['zip_base']}*.zip part(s)")

        count = split_into_chunks(export_dir, task["zip_output_dir"], task["zip_base"], args.max_bytes)
        completed[task["iss_constant"]] = count

        change = update_installer_constant(task["iss_constant"], count)
        if change is not None:
            iss_changes.append((task["iss_constant"], change[0], change[1]))

    if not args.use_omega_install and not args.keep_staging and not args.export_only:
        shutil.rmtree(STAGING_DIR, ignore_errors=True)

    if args.recompile_installer and not args.export_only:
        iscc_path = find_iscc(args.iscc)
        if iscc_path is None:
            print(
                "\n[installer] WARN: could not locate ISCC.exe.\n"
                "  Pass --iscc <path>, set the INNO_SETUP_PATH env var, or install Inno Setup 6.\n"
                "  Skipping recompile; the EXE in public/CCG Downloads/ is now stale."
            )
            failures.append(("installer", "ISCC.exe not found"))
        else:
            try:
                recompile_installer(iscc_path)
                installer_recompiled = True
            except SystemExit as exc:
                print(f"  [installer] aborted: {exc}")
                failures.append(("installer", str(exc)))

    pushed = False
    push_attempted = False
    if args.push and not args.export_only:
        if failures:
            print("\n[git] skipping push because earlier steps failed:")
            for label, message in failures:
                print(f"    [{label}] {message}")
        else:
            push_attempted = True
            try:
                commit_message = build_commit_message(
                    cards_count=cards_count,
                    completed=completed,
                    iss_changes=iss_changes,
                    db_zipped=db_zipped,
                    installer_recompiled=installer_recompiled,
                    custom_message=args.commit_message,
                )
                pushed = git_publish(commit_message)
            except SystemExit as exc:
                print(f"  [git] aborted: {exc}")
                failures.append(("git", str(exc)))

    if args.export_only:
        print("\n--- Export-only run complete ---")
        if db_synced_to is not None:
            print(f"  CCG_v1.db synced -> {db_synced_to}")
        if args.use_omega_install:
            print(f"  Per-card files written to {OMEGA_INSTALL_ROOT}.")
            print("  Launch YGO Omega and verify before running a publish pass.")
        else:
            print(f"  Per-card files staged at {STAGING_DIR}.")
            print("  (Pass --use-omega-install to push them into your Omega install instead.)")
        for label, message in failures:
            print(f"  [{label}] FAILED: {message}")
        return 1 if failures else 0

    print("\n--- Summary ---")
    if db_synced_to is not None:
        print(f"  CCG_v1.db synced -> {db_synced_to}")
    if db_zipped:
        print(f"  CCG_Database.zip refreshed at {REPO_DB_ZIP.relative_to(REPO_ROOT)}")
    for name, count in completed.items():
        print(f"  {name} = {count}")
    if installer_recompiled:
        print(f"  installer EXE refreshed at {INSTALLER_PUBLISH_EXE.relative_to(REPO_ROOT)}")
    if pushed:
        print("  git: committed and pushed to origin")
    elif push_attempted:
        print("  git: nothing to push (no changes after staging)")
    elif args.push:
        print("  git: push skipped due to earlier failures")
    for label, message in failures:
        print(f"  [{label}] FAILED: {message}")

    if iss_changes:
        print("\nUpdated installer .iss constants:")
        for name, old, new in iss_changes:
            print(f"  {name}: {old} -> {new}")
        if not installer_recompiled:
            print(
                "\nIMPORTANT: scripts/ccg-omega-installer.iss has changed. Pass\n"
                "--recompile-installer (or run npm run release:omega:publish) so\n"
                "public/CCG Downloads/CCG_Omega_Addon_Setup.exe picks up the new\n"
                "part counts before you publish."
            )
    elif not installer_recompiled:
        print("\nInstaller .iss constants already match the new part counts.")

    return 1 if failures else 0


if __name__ == "__main__":
    raise SystemExit(main())

# Omega CCG Release Pipeline

This document describes the automated workflow for building and publishing the YGO Omega CCG add-on (database, images, installer). 

## Overview

`src/data/cards.json` is the source of truth for card data. The release pipeline reads it and produces:

| Artifact | Location | Purpose |
| --- | --- | --- |
| `CCG_v1.db` | `public/CCG Downloads/CCG_Database/` | Omega card database |
| `CCG_Database.zip` | same folder | Zipped DB for the installer |
| `YGO_Omega_Images_v{N}.zip` | `public/CCG Downloads/` | Cropped art (624×624 JPEG) |
| `YGO_Omega_Pics_v{N}.zip` | `public/CCG Downloads/YGO_Omega_Images/` | Full card images |
| `YGO_Omega_Holograms_v{N}.zip` | `public/CCG Downloads/YGO_Omega_Images/` | Hologram cutouts (monsters only) |
| `CCG_Omega_Addon_Setup.exe` | `public/CCG Downloads/` | End-user installer |
| `ccg-omega-installer.iss` | `scripts/` | Installer source (part counts, download URLs) |

Per-card files are named by `passcode` from `cards.json` (e.g. `245265629.jpg`).

Current installer part counts (as of the last release run):

- `IMAGE_PART_COUNT = 1`
- `PICS_PART_COUNT = 4`
- `HOLOGRAM_PART_COUNT = 3`

---

## Prerequisites

Install Python dependencies once:

```bash
python -m pip install -r scripts/requirements.txt
```

Requires: `Pillow`, `opencv-python`, `numpy`.

For installer recompilation (build machine only): [Inno Setup 6](https://jrsoftware.org/isdl.php). The orchestrator looks for `ISCC.exe` via `--iscc`, `INNO_SETUP_PATH` / `ISCC` env vars, PATH, or standard install directories.

---

## What Changed (Automation Updates)

### 1. Exporters read `cards.json` directly

These scripts no longer query the local Omega SQLite database:

- `scripts/export_omega_ccg_arts.py`
- `scripts/export_omega_ccg_pics.py`
- `scripts/export_omega_ccg_holograms.py`

They iterate `src/data/cards.json`, use each card's `passcode` as the output filename, and read source renders from `public/assets/cards/`.

### 2. One orchestrator replaces manual steps

`scripts/release_omega_assets.py` handles:

1. **DB sync** — runs `sync_omega_ccg_db.py` against the repo DB (or local Omega DB with `--use-omega-install`), then re-zips `CCG_Database.zip`.
2. **Image export** — runs all three exporters.
3. **Chunking** — packs files into ≤95 MB zip parts (replaces manual `split-images.ps1`).
4. **Installer constants** — updates `IMAGE_PART_COUNT`, `PICS_PART_COUNT`, `HOLOGRAM_PART_COUNT` in `scripts/ccg-omega-installer.iss`.
5. **Installer recompile** (optional) — runs Inno Setup and copies the new EXE into `public/CCG Downloads/`.
6. **Git publish** (optional) — stages, commits, and pushes release artifacts.

### 3. `cards.json` is the source of truth for Omega IDs

- Each card has a `passcode` field (Omega card ID).
- `sync_omega_ccg_db.py` matches cards by `passcode`, not by name.
- `import_upcoming_set.py` allocates passcodes for new cards at import time.
- `genre` is also stored in `cards.json` and synced into the DB.

---

## npm Commands

| Command | What it does |
| --- | --- |
| `npm run test:omega` | Sync DB + render images into **local Omega install only**. No repo changes. Use to verify in-game before publishing. |
| `npm run release:omega` | Sync DB + render images + zip + update `.iss` in the **repo**. Does not recompile EXE or push. |
| `npm run release:omega:stage` | Same as `release:omega`, then **commit + push** repo artifacts. EXE recompile still pending. Use on the editing machine. |
| `npm run release:omega:installer` | **Recompile EXE only** (skip DB/images), then commit + push. Use on the build machine after `git pull`. |
| `npm run release:omega:publish` | Full one-shot: DB + images + recompile EXE + push. Requires Inno Setup on the same machine. |
| `npm run release:omega:with-omega-install` | Like `release:omega`, but also writes DB/images to local Omega install before mirroring to repo. |
| `npm run release:omega:db-only` | Refresh `CCG_v1.db` + `CCG_Database.zip` only. Skips images (~seconds). |
| `npm run release:omega:images-only` | Refresh image zips + `.iss` only. Skips DB. |

### Related (not part of the image/DB pipeline)

| Command | Purpose |
| --- | --- |
| `npm run sync:omega:banlist` | Regenerate `src/data/banlist.json` from `cards.json` |
| `npm run build` | Build the website (`dist/`); bundles `cards.json` for GitHub Pages |

---

## Recommended Workflows

### Two-machine workflow (editing machine + build machine)

**On the editing machine** (where you edit `cards.json` and card images):

```bash
# 1. Edit src/data/cards.json and add renders to public/assets/cards/

# 2. Test locally in YGO Omega
npm run test:omega

# 3. Launch YGO Omega and verify cards look correct.
#    If not, fix cards.json / images and repeat step 2.

# 4. Publish artifacts to the repo (DB + images + .iss; EXE stays stale)
npm run release:omega:stage
```

**On the build machine** (where Inno Setup is installed):

```bash
git pull
npm run release:omega:installer
```

This produces two commits per release: one for assets, one for the recompiled installer EXE.

### Single-machine workflow (Inno Setup installed locally)

```bash
npm run test:omega
# verify in YGO Omega
npm run release:omega:publish
```

---

## Where Files Go

### Test mode (`npm run test:omega`)

Writes only to the local YGO Omega install:

```
C:\Program Files (x86)\YGO Omega\YGO Omega_Data\Files\
  Databases\CCG_v1.db
  Arts\<passcode>.jpg
  Pics\<passcode>.jpg
  Holograms\<passcode>.png
```

### Release mode (`npm run release:omega` / `stage` / `publish`)

Writes to the repo:

```
public/CCG Downloads/
  CCG_Database/
    CCG_v1.db
    CCG_Database.zip
  YGO_Omega_Images_v1.zip          (Arts)
  YGO_Omega_Images/
    YGO_Omega_Pics_v1.zip ... v4.zip
    YGO_Omega_Holograms_v1.zip ... v3.zip
  CCG_Omega_Addon_Setup.exe        (after recompile)
scripts/
  ccg-omega-installer.iss          (part counts updated)
```

Images are staged in `tmp/release_staging/` during the build, then deleted (unless `--keep-staging`).

---

## Direct Python Flags

```bash
python scripts/release_omega_assets.py [options]
```

| Flag | Effect |
| --- | --- |
| `--use-omega-install` | Write DB/images to local Omega install instead of repo/staging |
| `--export-only` | Export only; skip zipping, `.iss` update, recompile, push |
| `--skip-db` | Skip database sync |
| `--skip-images` | Skip image export and zip |
| `--overwrite` | Regenerate all per-card images even if they already exist |
| `--keep-staging` | Don't delete `tmp/release_staging/` after zipping |
| `--max-bytes <n>` | Chunk size budget in bytes (default: 95,000,000) |
| `--recompile-installer` | Run Inno Setup and copy EXE to `public/CCG Downloads/` |
| `--iscc <path>` | Explicit path to `ISCC.exe` (implies `--recompile-installer`) |
| `--push` | Git add, commit, and push release paths |
| `--commit-message "<msg>"` | Override the auto-generated commit message |

`--export-only` cannot be combined with `--recompile-installer` or `--push`.

---

## Git Publish Paths

When `--push` is used, only these paths are staged:

- `src/data/cards.json`
- `src/data/banlist.json`
- `public/assets/cards`
- `public/CCG Downloads`
- `scripts/ccg-omega-installer.iss`

Unrelated local changes are not included in the auto-commit.

Push is skipped if any earlier step fails (e.g. exporter crash, ISCC not found).

---

## Inno Setup (Installer EXE)

The installer users download is **not** hand-edited. It is compiled from a text recipe:

```
scripts/ccg-omega-installer.iss   (source)
        |
        |  ISCC.exe (Inno Setup compiler)
        v
public/CCG Downloads/CCG_Omega_Addon_Setup.exe   (what users run)
```

The `.iss` file tells the installer which zip URLs to download from GitHub Pages and where to extract them in the user's YGO Omega folder. When image part counts change (e.g. `IMAGE_PART_COUNT` 3 → 1), the EXE **must** be recompiled or end users will try to download zip parts that no longer exist.

If Inno Setup is not installed, `release:omega:stage` still works — it updates everything except the EXE. Recompile on a machine that has Inno Setup with `release:omega:installer`.

---

## Adding New Cards (Full Checklist)

1. Add card entry to `src/data/cards.json` (include `passcode`, `genre`, `image` path, etc.).
2. Place the source card render in `public/assets/cards/`.
3. Optionally run `npm run sync:omega:banlist` if banlist fields changed.
4. `npm run test:omega` — verify in YGO Omega.
5. `npm run release:omega:stage` — publish DB + images to repo.
6. On build machine: `git pull` then `npm run release:omega:installer` — refresh EXE.
7. Optionally `npm run build` and deploy the website.

For bulk import from raw card images, use `scripts/import_upcoming_set.py` (Windows only; OCR/CV). It generates draft JSON entries with allocated passcodes.

---

## Manual Steps No Longer Required

- Manually zipping image folders
- Running `scripts/split-images.ps1` by hand
- Copying `CCG_v1.db` into `public/CCG Downloads/CCG_Database/`
- Manually re-zipping `CCG_Database.zip`
- Manually editing `IMAGE_PART_COUNT` / `PICS_PART_COUNT` / `HOLOGRAM_PART_COUNT` in the `.iss` file

These are all handled by `release_omega_assets.py`.

---

## Troubleshooting

| Problem | Likely cause | Fix |
| --- | --- | --- |
| `ISCC.exe not found` | Inno Setup not installed on this machine | Use `release:omega:stage` here, `release:omega:installer` on build machine; or pass `--iscc <path>` |
| `cards.json has N cards without a passcode` | Missing `passcode` on new cards | Add passcodes (or run `import_upcoming_set.py` which allocates them) |
| `ModuleNotFoundError: cv2` | Missing Python deps | `python -m pip install -r scripts/requirements.txt` |
| Installer downloads wrong zip parts | EXE is stale | Recompile with `release:omega:installer` after `.iss` part counts changed |
| Hologram step is slow | OpenCV grabCut per monster (~25+ min for full set) | Use `release:omega:db-only` when only metadata changed |
| `git push` skipped | Earlier step failed | Fix the reported failure, then re-run |

# Omega Custom Card Workflow

This project maintains custom YGO Omega cards for the CCG card pool. The repo is the source of truth for card metadata, distributable database files, and distributable Lua scripts. The installed Omega folder is the local test target.

## Key Paths

- `src/data/cards.json`: source card metadata and effect text.
- `scripts/output/CCG_v1_id_map.json`: generated map from CCG source IDs to Omega passcodes.
- `public/CCG Downloads/CCG_Database/CCG_v1.db`: distributable custom Omega database.
- `public/CCG Downloads/CCG_Database/CCG_Database.zip`: zipped database payload for the installer.
- `public/CCG Downloads/CCG_Banlist/CCG_Banlist.lflist.conf`: distributable CCG banlist.
- `public/CCG Downloads/CCG_Scripts`: distributable custom Lua scripts.
- `public/CCG Downloads/CCG_Scripts/CCG_Scripts.zip`: zipped Lua payload for the installer.
- `public/CCG Downloads/YGO_Omega_Images_v*.zip`: split cropped-art payloads for `YGO Omega_Data\Files\Arts`.
- `public/CCG Downloads/YGO_Omega_Images/YGO_Omega_Pics_v*.zip`: split full-card image payloads for `YGO Omega_Data\Files\Pics`.
- `public/CCG Downloads/YGO_Omega_Images/YGO_Omega_Holograms_v*.zip`: split hologram PNG payloads for `YGO Omega_Data\Files\Holograms`.
- `tmp/omega_scripts`: local copy of official Omega scripts. Treat this as the primary scripting reference.
- `C:\Program Files (x86)\YGO Omega\YGO Omega_Data\Files\Databases\CCG_v1.db`: installed local test database.
- `C:\Program Files (x86)\YGO Omega\YGO Omega_Data\Files\Scripts`: installed local test scripts loaded by Omega.

## Role

When producing or fixing Lua, the job is to turn the intended card text into Omega-compatible behavior, keep the repo and local Omega install synchronized, and verify the result with fast checks before the user tests in Omega.

Priorities:

- Prefer behavior that matches the printed card text.
- Prefer official Omega script patterns from `tmp/omega_scripts` over memory or EDOPro assumptions.
- Keep scripts named by Omega passcode, e.g. `c259017109.lua`.
- Keep string IDs aligned with `str1` through `str16` in the custom DB.
- Preserve existing custom scripts and user edits unless explicitly asked to replace them.
- Treat `public/CCG Downloads` as the release mirror that must reflect the current CCG custom set.

## Lua Authoring Workflow

1. Identify the card in `src/data/cards.json`.
2. Find its Omega passcode in `scripts/output/CCG_v1_id_map.json`.
3. Open the current script, if one exists, from `public/CCG Downloads/CCG_Scripts/c<omega_id>.lua`.
4. Search `tmp/omega_scripts` for official cards with the same mechanics before writing logic.
5. Use the modern Omega style when possible:
   - `local s,id=GetID()`
   - `function s.initial_effect(c)`
   - `aux.Stringid(id,n)` for prompt text
   - count limits tied to `id`, `id+100`, etc. when a card has multiple once-per-turn effects
6. For unusual mechanics, copy the smallest proven official pattern and adapt it conservatively.
7. Write only the custom script and any required prompt text/database update.
8. Parse the Lua for syntax errors before handing it off.
9. Copy the finished script into the installed Omega root script folder for local testing.
10. Rebuild the scripts zip after any release-script change.

## Database Workflow

Run the sync script when `cards.json` metadata changes:

```powershell
python scripts\sync_omega_ccg_db.py --full-sync
```

This updates the installed Omega database by default and refreshes `scripts/output/CCG_v1_id_map.json`. It also makes a backup unless `--no-backup` is supplied.

After a DB sync intended for release, copy the resulting DB into `public/CCG Downloads/CCG_Database/CCG_v1.db` and rebuild `CCG_Database.zip` with `CCG_v1.db` at the archive root.

## Banlist Workflow

The website card data is the CCG banlist source of truth. Regenerate the Omega banlist after changing legality flags in `src/data/cards.json` or `src/data/tcg-cards.json`:

```powershell
npm run sync:omega:banlist
```

Use the check mode to verify the distributable Omega banlist is still aligned:

```powershell
node scripts\sync-omega-ccg-banlist.mjs --check
```

## Validation Checks

Basic Lua syntax parse for the distributable custom scripts:

```powershell
@'
const fs = require('fs');
const path = require('path');
const luaparse = require('./tmp/lua_parser/node_modules/luaparse');
const dir = path.join(process.cwd(), 'public', 'CCG Downloads', 'CCG_Scripts');
const files = fs.readdirSync(dir).filter(f => f.endsWith('.lua')).sort();
let failed = [];
for (const file of files) {
  const code = fs.readFileSync(path.join(dir, file), 'utf8');
  try {
    luaparse.parse(code, { luaVersion: '5.3', comments: false });
  } catch (err) {
    failed.push(`${file}: ${err.message}`);
  }
}
console.log(`parsed=${files.length - failed.length}`);
console.log(`failed=${failed.length}`);
for (const f of failed) console.log(f);
'@ | node -
```

Compare release scripts to installed local test scripts:

```powershell
$public = Get-ChildItem -File 'public\CCG Downloads\CCG_Scripts' -Filter '*.lua' | Select-Object -ExpandProperty Name
$installed = Get-ChildItem -File 'C:\Program Files (x86)\YGO Omega\YGO Omega_Data\Files\Scripts' -Filter '*.lua' | Select-Object -ExpandProperty Name
Compare-Object $public $installed
```

Compare release scripts to the scripts zip:

```powershell
Add-Type -AssemblyName System.IO.Compression.FileSystem
$zip = [IO.Compression.ZipFile]::OpenRead((Resolve-Path 'public\CCG Downloads\CCG_Scripts\CCG_Scripts.zip'))
$zipNames = $zip.Entries | ForEach-Object FullName
$files = Get-ChildItem -File 'public\CCG Downloads\CCG_Scripts' -Filter '*.lua' | ForEach-Object Name
Compare-Object $files $zipNames
$zip.Dispose()
```

## Release Sync Checklist

- `src/data/cards.json` has the intended card text and metadata.
- `scripts/output/CCG_v1_id_map.json` is current.
- `public/CCG Downloads/CCG_Database/CCG_v1.db` matches the installed/tested `CCG_v1.db`.
- `public/CCG Downloads/CCG_Database/CCG_Database.zip` contains the current `CCG_v1.db`.
- `public/CCG Downloads/CCG_Scripts` contains every release Lua script.
- `public/CCG Downloads/CCG_Scripts/CCG_Scripts.zip` contains the same scripts as the folder.
- `public/CCG Downloads/YGO_Omega_Images_v*.zip` contains the current cropped-art JPGs at archive root.
- `public/CCG Downloads/YGO_Omega_Images/YGO_Omega_Pics_v*.zip` contains the current full-card JPGs at archive root.
- `public/CCG Downloads/YGO_Omega_Images/YGO_Omega_Holograms_v*.zip` contains the current hologram PNGs at archive root.
- The installed Omega root `Files\Scripts` folder contains the scripts being tested.
- Lua syntax parse passes.
- User confirms behavior in Omega for non-trivial card effects.

# Card Scripting Handoff - 2026-05-25

This repo is mid-work on custom YGO Omega card scripting. Future chats should treat this file as the pickup point and should not assume the git worktree is clean.

## Current State

- Workspace: `C:\Applications\YugiohCCG.github.io`
- Official Omega script reference: `C:\Applications\YugiohCCG.github.io\tmp\omega_scripts`
- Public custom scripts: `public/CCG Downloads/CCG_Scripts`
- Public DB: `public/CCG Downloads/CCG_Database/CCG_v1.db`
- Local Omega scripts loaded by Omega: `C:\Program Files (x86)\YGO Omega\YGO Omega_Data\Files\Scripts`
- Local Omega DB: `C:\Program Files (x86)\YGO Omega\YGO Omega_Data\Files\Databases\CCG_v1.db`

The user considers `tmp\omega_scripts` the source of truth for best practices. Before scripting a new effect, search there for official cards with similar behavior and copy their structure where possible.

## Custom Card Batch - 2026-06-23 Current

Generated and bug-tested the next 10-card Nautica/Bob batch:

| Card | Source ID | Omega ID | Result | Notes |
| --- | --- | ---: | --- | --- |
| Melody Merheart & the Nautical Coral Reef | CARD-0200 | 228040066 | Pass | Added cannot Normal Summon/Set, opponent Summon-triggered self-summon, and optional Necrovalley-safe GY add. |
| Emma Oceannus & the Nautical Coastlines | CARD-00201 | 214349717 | Pass | Added cannot Normal Summon/Set, opponent Summon-triggered self-summon, and optional immediate "Nautica" Xyz Summon. No OPT was added because source has none. |
| Bobbie Bluefin & the Nautical Nocturnes | CARD-00202 | 259114562 | Needs manual ruling | Implemented the opponent hand summon as a forced Special Summon in Attack Position with ATK 0, then Nautica-only negate. Confirm whether the "Normal or Special Summons" wording requires unsupported forced Normal Summon handling. |
| Scarlet Seareef & the Nautical Creatures | CARD-00203 | 220749574 | Needs manual ruling | Added own Special Summon procedure with Necrovalley-safe GY bottom-deck cost, Xyz Level 1 treatment for Aqua Xyz Summons, hand discard/search, and summon draw/opponent summon. Bug-test fixed the GY cost filter to require both `IsAbleToDeckAsCost()` and Necrovalley legality. Confirm opponent summon wording and bottom-deck "any order" behavior in-engine. |
| Evander Coldwater & the Nautical Abyss | CARD-00204 | 225109525 | Needs manual ruling | Added 2+ Level 1 Aqua Xyz procedure, ATK gain for "Nautica" materials, and detach/return/opponent summon Quick Effect. Confirm opponent "Normal or Special Summons" wording. |
| Nautical Backwashing & Oceanic Waves | CARD-00205 | 223158720 | Needs manual ruling | Added shared once-per-turn Trap activation and GY effect, Necrovalley-safe GY return/recycle, and opponent summon after the return. Confirm opponent "Normal or Special Summons" wording. |
| Melissa Oceanheart & the Nautical Seabed | CARD-00206 | 238711686 | Pass | Added 2+ Level 1 Aqua Xyz procedure, battle/effect destruction protection while carrying a "Nautica" material, and detach 2 to Set a "Nautica" Spell/Trap or add a "Nautica" monster. |
| Exploring the Nautical Waters | CARD-00207 | 248946297 | Needs manual ruling | Added activation HOPT, WATER Special Summon turn lock using `Duel.AddCustomActivityCounter`, search, opponent hand/Deck Special Summon in Attack Position with ATK 0, and Deck-summoned negate. Confirm opponent "Normal or Special Summons" wording. |
| Nautical Adventures & Torrential Seas | CARD-00208 | 218905439 | Needs manual ruling | Added target/return both monsters, opponent hand summon, and GY attach to your WATER Xyz monster with `EFFECT_TO_GRAVE_REDIRECT` so this card is banished when detached. Confirm opponent summon wording and detach redirect in live duel. |
| Bob | CARD-00209 | 259722826 | Pass | Normal Tuner script contains empty `initial_effect`. |

Implementation notes:

- Added standalone public scripts for all 10 cards.
- Added stable DB set-code overrides for custom `Nautica` (`0x08F0`) and `Bob` (`0x92B1`) so DB rows stay stable after fresh syncs.
- Added DB `aux.Stringid` messages for the nine effect scripts; `Bob` does not call `aux.Stringid`.
- The originally requested `src/data/ccg-omega-ids.json` file is not present in this checkout; IDs were confirmed from each card's `passcode` in `src/data/cards.json` and from generated `CCG_v1_id_map.json`.
- Synchronized public scripts, installed Omega root scripts, public/dist script zips, public/installed/dist DBs, DB zips, ID maps, `public/assets/cards.json`, and `dist`.

Official/local references used:

- Cannot Normal Summon/Set and opponent Summon-triggered hand self-summon: local `public/CCG Downloads/CCG_Scripts/c226645052.lua`, official `tmp/omega_scripts/c10755153.lua`, `tmp/omega_scripts/c18319762.lua`.
- Opponent-selected forced Special Summon from hand/Deck and activation-lock pattern comparison: official `tmp/omega_scripts/c100256003.lua`.
- Forced Normal Summon comparison: official `tmp/omega_scripts/c100263009.lua`; no official analog was found for forcing the non-activating opponent to Normal Summon from hand as part of the effect.
- Variable 2+ Xyz procedures and immediate Xyz Summon: official `tmp/omega_scripts/c1174075.lua`, local `public/CCG Downloads/CCG_Scripts/c231825514.lua`, `c250556612.lua`, `c227043533.lua`, `c236551669.lua`.
- Special Summon procedure / `SUMMON_VALUE_SELF`: official `tmp/omega_scripts/c95291684.lua`, `tmp/omega_scripts/c10000040.lua`.
- Xyz Level treatment: official `tmp/omega_scripts/c61496006.lua`, `tmp/omega_scripts/c55697723.lua`.
- Bottom-of-Deck cost/effect patterns: official `tmp/omega_scripts/c60516416.lua`, `tmp/omega_scripts/c61434639.lua`.
- Overlay/attach material and redirect: official `tmp/omega_scripts/c57448410.lua`, `tmp/omega_scripts/fixed-scripts/c39829561.lua`, `tmp/omega_scripts/c100240202.lua`.
- WATER-only Special Summon turn lock/activity counter: official `tmp/omega_scripts/c100245016.lua`, local `public/CCG Downloads/CCG_Scripts/c259264449.lua`, `c259934043.lua`.
- Negate/reset patterns: official `tmp/omega_scripts/c61434639.lua`, `tmp/omega_scripts/c95291684.lua`.

Verification passed:

- Per-card `luac -p` for the 10 in-scope scripts.
- Full `luac -p` for public, installed, and dist custom script folders (`316` scripts each), repeated after the Scarlet filter fix.
- Static scan found no `require`, `dofile`, `loadfile`, or loader/subfile usage in the ten scripts.
- Full `initial_effect` smoke for public, installed, and dist custom script folders (`316` scripts each), repeated after the Scarlet filter fix.
- `python -m py_compile scripts/sync_omega_ccg_db.py`.
- Public and installed DB full sync: `cards_in_source=577`, `updated=577`, `datas_count=586`, `texts_count=586`, `setcode_map_size=90`.
- Public/installed/dist DB row and `aux.Stringid` verification for all 10 IDs.
- Full script hash parity across public scripts, installed Omega scripts, dist scripts, public/dist `CCG_Scripts.zip`, and zip payloads (`316` scripts).
- Public/installed/dist `CCG_v1.db` hash parity (`58f60d2b0b0a84b4f7b589cdc72d152e4e29a408ade150e4ab35697bdf44f5b6`) and public/dist `CCG_Database.zip` payload/hash parity.
- Public/dist artifact parity for `assets/cards.json` and `CCG_v1_id_map.json`.
- `npm run build` passed after final script fix with only the existing Vite large-chunk warning.

Remaining live-duel risks:

- Bobbie, Scarlet, Evander, Nautical Backwashing, Exploring, and Nautical Adventures: confirm whether "your opponent Normal or Special Summons" requires a real forced Normal Summon branch. Current scripts use the official, engine-supported forced opponent Special Summon pattern.
- Scarlet and Nautical Backwashing: confirm Omega's bottom-of-Deck ordering prompt is acceptable for "in any order."
- Nautical Adventures: confirm `EFFECT_TO_GRAVE_REDIRECT` on the attached Trap correctly banishes it when detached as Xyz Material.

## Custom Card Batch - 2026-06-23 Previous

Generated and bug-tested the next 10-card Pedicae/Recollection batch:

| Card | Source ID | Omega ID | Result | Notes |
| --- | --- | ---: | --- | --- |
| Vir Pedicae Mortis - True Nightmare | CARD-00190 | 233103500 | Pass | Added Link Summon material check requiring a `Vir Pedicae Mortis` monster, Link Summon GY revive, and Bear Trap-gated Quick Effect destruction. |
| Entity's Realm - Pedicae Estate | CARD-0191 | 236744343 | Needs manual ruling | Source had no Spell icon, but the text is persistent and references activation, once-per-turn Field behavior, and battle triggers. `cards.json` was corrected to `Field`; confirm intended Field Spell rather than Continuous/Normal. |
| Recollection: Static, Lead, and Nerve | CARD-0192 | 211086520 | Pass | Added Deck search for `Vir Pedicae Mortis` monster, then discard only if the add succeeds. |
| Recollection: a Lesson in Iron | CARD-0193 | 234984156 | Pass | Added LP cost in cost function, target legality, ATK gain, destruction protection, and effect-targeting protection. |
| Recollection: the Mine | CARD-0194 | 231872299 | Pass | Added Field ATK reduction and discard/banish cost into Special Summon plus Kaboom search with "if you do" sequencing. |
| Recollection: Kaboom Papa | CARD-0195 | 241447408 | Fixed | Repeat bug-test widened the required `"Mine" Field Spell` selection to either player's field while keeping `Pedicaes Papa` restricted to your field. Remaining ruling risk: confirm the exact "only conduct 1 Summon this turn" timing after resolution. |
| Teleum Mortis | CARD-0196 | 229875953 | Needs manual ruling | Added Vir-only Equip, ATK gain based on total Bear Trap activations this Duel, and destruction substitute. Confirm whether both players' Bear Trap activations should count. |
| Bear Trap | CARD-0197 | 251699681 | Needs manual ruling | Added Counter Trap Summon/attack negation, duel/turn activation flags for related cards, and GY Set with banish-on-leave. Confirm that "activated" should mean successful operation resolution for ATK/True Nightmare tracking. |
| Securitake Agent | CARD-0198 | 219543855 | Needs manual ruling | Added Link material rule for opponent-owned monsters you control, once-per-turn Link Summon lock, and opponent-GY revive/disable. Confirm whether "1 monster your opponent owns" should also allow opponent-field material like Underworld Goddess. |
| Harmony Pearlwood & the Nautical Deepwaters | CARD-0199 | 226645052 | Needs manual ruling | Added cannot Normal Summon/Set, opponent Summon-triggered self-summon, optional Level 1 Aqua search, shuffle, and searched-card activation lock. Confirm in-engine that `EFFECT_CANNOT_TRIGGER` remains enforced on the revealed card after hand shuffle. |

Implementation notes:

- Added standalone public scripts for all 10 cards.
- Corrected `Entity's Realm - Pedicae Estate` in `src/data/cards.json` from no icon to `Field` so DB type syncs to `TYPE_SPELL+TYPE_FIELD` (`524290`).
- Added DB `aux.Stringid` messages for the nine scripts that use descriptions; `Teleum Mortis` does not call `aux.Stringid`.
- Fixed a message override typo for `Recollection: Kaboom Papa` (`recollectionkaboompapa`).
- Repeat bug-test fixed `Recollection: Kaboom Papa` so the required `"Mine" Field Spell` can be selected from either side of the field, matching the wording where only `Pedicaes Papa` is explicitly "you control".
- Synchronized public scripts, installed Omega root scripts, public/dist script zips, public/installed/dist DBs, DB zips, ID maps, `public/assets/cards.json`, and `dist`.
- The originally requested `src/data/ccg-omega-ids.json` file is not present in this checkout; IDs were confirmed from each card's `passcode` in `src/data/cards.json` and from the generated `CCG_v1_id_map.json`.

Official/local references used:

- Link material group checks: official `tmp/omega_scripts/c100211098.lua`, `tmp/omega_scripts/c101203051.lua`.
- Opponent monster Link material boundary: official `tmp/omega_scripts/c98127546.lua`; current Securitake implementation intentionally does not borrow opponent-field material without a ruling.
- Once-per-turn Link Summon restriction: official `tmp/omega_scripts/c25725326.lua`, `tmp/omega_scripts/c48835607.lua`.
- Summon/attack negate patterns: official `tmp/omega_scripts/c41420027.lua`, `tmp/omega_scripts/c98069388.lua`, `tmp/omega_scripts/fixed-scripts/c16625614.lua`.
- GY Set, leave-field banish, turn-sent checks, and Necrovalley handling: official `tmp/omega_scripts/c27556460.lua`, `tmp/omega_scripts/c13093792.lua`, `tmp/omega_scripts/c1412158.lua`.
- Field ATK reduction, attack-all, and battle-destroyed triggers: official `tmp/omega_scripts/c11390349.lua`, `tmp/omega_scripts/c11443677.lua`, `tmp/omega_scripts/c11012887.lua`, `tmp/omega_scripts/c33438666.lua`, `tmp/omega_scripts/c51345461.lua`.
- Equip limit and destruction substitute: official `tmp/omega_scripts/c65169794.lua`, `tmp/omega_scripts/fixed-scripts/equip/c53241226.lua`.
- Searched/placed card cannot activate/trigger patterns: official `tmp/omega_scripts/c100256015.lua`, `tmp/omega_scripts/c100256003.lua`.
- Cannot Normal Summon/Set and opponent Summon triggers: official `tmp/omega_scripts/c10755153.lua`, `tmp/omega_scripts/c18319762.lua`, `tmp/omega_scripts/c100211001.lua`, `tmp/omega_scripts/c100261051.lua`.
- Summon Limiter/activity-count restriction: official `tmp/omega_scripts/c23516703.lua`, `tmp/omega_scripts/c99789342.lua`.

Verification passed:

- Per-card `luac -p` for the 10 in-scope scripts.
- Full `luac -p` for public, dist, and installed custom script folders (`306` scripts each).
- Static scan found no `require`, `dofile`, `loadfile`, or loader/subfile usage in the ten scripts.
- Full `initial_effect` smoke for public, dist, and installed custom script folders (`306` scripts each).
- `python -m py_compile scripts/sync_omega_ccg_db.py`.
- Public and installed DB full sync: `cards_in_source=577`, `updated=577`, `datas_count=586`, `texts_count=586`.
- Public/installed/dist DB row and `aux.Stringid` verification for all 10 IDs; `Entity's Realm - Pedicae Estate` verified as Field Spell type `524290`.
- Full script hash parity across public scripts, installed Omega scripts, dist scripts, public/dist `CCG_Scripts.zip`, and zip payloads (`306` scripts).
- Public/installed/dist `CCG_v1.db` hash parity and public/dist `CCG_Database.zip` payload/hash parity.
- Public/dist artifact parity for `assets/cards.json` and `CCG_v1_id_map.json`.
- `npm run build` passed with only the existing Vite large-chunk warning.

Remaining live-duel risks:

- `Entity's Realm - Pedicae Estate`: confirm Field Spell classification because the source card originally had no icon.
- `Recollection: Kaboom Papa`: confirm the post-resolution one-Summon cap matches intended turn-history semantics.
- `Teleum Mortis` / `Bear Trap` / `Vir Pedicae Mortis - True Nightmare`: confirm Bear Trap activation counting should use successful operation resolution and count both players for Teleum.
- `Securitake Agent`: confirm whether opponent-owned material should be restricted to cards you can normally use as Link Material, or should use Underworld Goddess-style opponent-field material.
- `Harmony Pearlwood & the Nautical Deepwaters`: confirm the searched-card cannot-trigger restriction survives hand shuffle in Omega.

## Custom Card Batch - 2026-06-23 Previous

Generated and bug-tested the next 10-card batch:

| Card | Source ID | Omega ID | Result | Notes |
| --- | --- | ---: | --- | --- |
| The True Wicked Puppeteer, Orchis | CARD-00180 | 234178973 | Pass | Added field `EFFECT_ADD_CODE`/`EFFECT_ADD_TYPE`, Normal Summon discard/search, opponent-effect leave-field self-revive, and optional Puppet Token summon. |
| Wicked Puppeteer, Orchis | CARD-00181 | 236818346 | Fixed | Added Ritual revive limit, targeting protection, Extra Deck face-down banish cost for 1-2 Puppet Tokens, and Quick Effect temporary control. Repeat bug-test changed both plain "Once per turn" effects from hard ID-coded limits to per-copy `SetCountLimit(1)`. |
| Wicked Puppeteer Tragedy | CARD-00182 | 243306841 | Pass | Added standalone Ritual Spell from hand/GY with hand/field materials and GY banish/send effect. |
| Wicked Puppeteery | CARD-00183 | 219150610 | Pass | Added optional activation search, Extra Deck face-down destruction replacement, and opponent-effect Orchis leave-field search. |
| Divine Phoenix of Nephthys | CARD-0184 | 244959812 | Needs manual ruling | Added hand Quick Effect and delayed own-Standby revival; Deck Ritual Summon uses self-tribute with Level check and needs live duel confirmation. |
| Primite Dragon Citrine | CARD-0185 | 234818744 | Pass | Normal Monster script contains empty `initial_effect`. |
| Pedicaes Papa | CARD-00186 | 241868535 | Pass | Added Bear Trap/Mine search and battle-start Recollection send/ATK gain using exact Recollection IDs. |
| Vir Pedicae Mortis - Entity's Happy Servant | CARD-00187 | 215984744 | Needs manual ruling | Added summon search and protection; "Mortis" search is represented as `Vir Pedicae Mortis` setcode cards excluding exact Recollection IDs. |
| Vir Pedicae Mortis - Fearless Hunter | CARD-00188 | 244778917 | Needs manual ruling | Added summon-triggered Spell/Trap destruction. Omega exposes Xyz-only double-material support and no equivalent Link "counts as 2 materials" effect, so that clause remains unsupported. |
| Vir Pedicae Mortis - the Unhallowed Warden | CARD-00189 | 243144691 | Pass | Added summon Tribute/shuffle and Link-material GY/banished self-summon with Tribute cost. |

Implementation notes:

- Added standalone public scripts for all 10 cards.
- Added `Puppet Token` as helper token ID `234178974` through `EXTRA_TOKEN_CARDS`.
- Added DB `aux.Stringid` messages for the nine effect scripts.
- Added stable DB set-code override for custom `Vir Pedicae Mortis` (`0x39E2`) so scripts and DB rows match after fresh syncs.
- Synchronized public scripts, installed Omega root scripts, public/dist script zips, public/installed/dist DBs, DB zips, ID maps, and `dist`.
- Repeat bug-test on 2026-06-23 fixed `Wicked Puppeteer, Orchis` so its two plain "Once per turn" effects use official per-copy count limits instead of hard once-per-turn IDs.

Official/local references used:

- Delayed own-Standby revival: official `tmp/omega_scripts/c61441708.lua` and `tmp/omega_scripts/c101202084.lua`.
- Opponent-effect leave-field / previous-code checks: official `tmp/omega_scripts/c100211001.lua`, `tmp/omega_scripts/c101203018.lua`, `tmp/omega_scripts/c100263006.lua`.
- Destruction replacement: official `tmp/omega_scripts/c1580833.lua`.
- Extra Deck face-down banish costs: official `tmp/omega_scripts/c71197066.lua`.
- Ritual Summon/material handling: official `tmp/omega_scripts/c101303207.lua`, local `public/CCG Downloads/CCG_Scripts/c257464336.lua`, `c216532402.lua`.
- Temporary control and Wicked Puppeteer style: local `public/CCG Downloads/CCG_Scripts/c233659599.lua`.
- Material triggers: local `public/CCG Downloads/CCG_Scripts/c240299292.lua`.
- Indestructible/protection patterns: local `public/CCG Downloads/CCG_Scripts/c248290754.lua`, `c237917359.lua`.
- Link/double-material limitation check: official `tmp/omega_scripts/c100250202.lua`, `tmp/omega_scripts/c100256017.lua`, `tmp/omega_scripts/procedure.lua`, `tmp/omega_scripts/constant.lua`.

Verification passed:

- Per-card `luac -p` for the 10 in-scope scripts.
- Full `luac -p` for public, dist, and installed custom script folders (`296` scripts each), plus post-build dist syntax.
- Targeted `initial_effect` smoke for the 10 in-scope scripts.
- Full `initial_effect` smoke for public, dist, and installed custom script folders (`296` scripts each).
- Static scan found no `require`, `dofile`, `loadfile`, or loader/subfile usage in the ten scripts.
- `python -m py_compile scripts/sync_omega_ccg_db.py`.
- Public and installed DB full sync: `cards_in_source=577`, `updated=577`, `datas_count=586`, `texts_count=586`.
- DB row/Stringid/id-map verification for all 10 IDs plus Puppet Token in public, dist, and installed DBs.
- Full script hash parity across public scripts, installed Omega scripts, public/dist `CCG_Scripts.zip`, and `dist` (`296` scripts).
- Public/installed/dist `CCG_v1.db` hash parity and public/dist DB/zip/id-map parity.
- `CCG_Database.zip` contains the same `CCG_v1.db` as the public DB.
- `npm run verify:public-cards`.
- `npm run build` passed with only the existing Vite large-chunk warning.
- Post-build public/dist artifact hash parity passed for `assets/cards.json`, script zip, DB, DB zip, and ID map.

Remaining live-duel risks:

- `Divine Phoenix of Nephthys`: confirm Omega accepts the Deck Ritual Summon by Tributing the revived card itself, including the Level check and zone release behavior.
- `Vir Pedicae Mortis - Entity's Happy Servant`: confirm the intended scope of `"Mortis" card`; the script uses `Vir Pedicae Mortis` setcode cards except exact Recollection IDs.
- `Vir Pedicae Mortis - Fearless Hunter`: confirm whether engine support or a custom procedure is desired for "treated as 2 materials" during a Link Summon; current Omega procedures only support the official Xyz double-material effect.

## Custom Card Batch - 2026-06-23 Previous

Generated and bug-tested the prior 10-card batch:

| Card | Source ID | Omega ID | Result | Notes |
| --- | --- | ---: | --- | --- |
| Dominus Sentinel | CARD-0170 | 259290896 | Pass | Existing script rechecked and resynced. |
| Clock of Aldrez | CARD-0171 | 210716547 | Needs manual ruling | Implements the chain-operation rewrite and opponent-field Special Summon; hand "Tribute this card" is represented as send-to-GY cost with `REASON_RELEASE`. |
| Aldrez Grandmaster | CARD-0172 | 246496923 | Needs manual ruling | Implements battle Spell/Trap activation lock and reveal/target Special Summon selection. |
| Phantasm Spiral Resurgence | CARD-0173 | 219047593 | Needs manual ruling | Implements equip, battle halve/negate, and GY add; "including in the GY" needs live duel confirmation. |
| Phantasm Spiral Shrine | CARD-0174 | 237917359 | Pass | Places `Umi`, applies opponent-effect destruction protection, and shuffles/draws from GY. |
| Phantasm Spiral Ensnarement | CARD-0175 | 222875833 | Pass | Mirrors official Phantasm Spiral hand-activation/Normal-monster condition and equips from Deck. |
| Grand Puppet of Wicked Puppeteer | CARD-0176 | 226063408 | Fixed | Shared Wicked Puppeteer self-summon plus summon-triggered destruction; repeat audit added Flip Summon trigger coverage. |
| Knight Puppet of Wicked Puppeteer | CARD-0177 | 259527622 | Fixed | Shared self-summon plus temporary monster destruction protection; repeat audit added Flip Summon trigger coverage. |
| Minion Puppets of Wicked Puppeteer | CARD-0178 | 233659599 | Pass | Shared self-summon plus Tribute-triggered temporary control. |
| Guardian of Wicked Puppeteer | CARD-00179 | 257464336 | Needs manual ruling | Sends Wicked Puppeteer cards and performs custom Ritual Summon of `Wicked Puppeteer, Orchis` from hand/GY. |

Implementation notes:

- Added standalone public scripts for the nine previously missing cards; `Dominus Sentinel` already existed and was included in syntax/smoke/parity verification.
- Added DB `aux.Stringid` messages for the nine new scripts.
- Added stable DB set-code overrides for official `Phantasm Spiral` (`0xfa`) and custom `Wicked Puppeteer` (`0xe0a9`) so scripts and DB rows match after fresh syncs.
- Synchronized public scripts, installed Omega root scripts, public/dist script zips, public/installed/dist DBs, DB zips, ID maps, and `dist`.
- Repeat bug-test on 2026-06-23 fixed `Grand Puppet of Wicked Puppeteer` and `Knight Puppet of Wicked Puppeteer` so their "If this card is Summoned" effects also trigger on Flip Summon, matching official all-summon trigger patterns.

Official/local references used:

- Chain rewrite: `tmp/omega_scripts/c100259009.lua`, `tmp/omega_scripts/fixed-scripts/Genesys/c80453041.lua`, local `public/CCG Downloads/CCG_Scripts/c259522807.lua`.
- Phantasm Spiral hand activation and Normal-monster condition: `tmp/omega_scripts/c61397885.lua`, `tmp/omega_scripts/c97795930.lua`.
- `Umi` movement/protection patterns: `tmp/omega_scripts/c19089195.lua`, local `public/CCG Downloads/CCG_Scripts/c259679619.lua`.
- Equip patterns: `tmp/omega_scripts/c10960419.lua`, `tmp/omega_scripts/fixed-scripts/equip/c57135971.lua`, local `public/CCG Downloads/CCG_Scripts/c259184310.lua`.
- Battle-start disable/negate: `tmp/omega_scripts/c100296003.lua`, local `public/CCG Downloads/CCG_Scripts/c213849997.lua`.
- Ritual Summon/material handling: local `public/CCG Downloads/CCG_Scripts/c216532402.lua`, `c259288669.lua`, `c259241946.lua`.
- Aldrez GY/banishment and chain-limit patterns: local `public/CCG Downloads/CCG_Scripts/c217700538.lua`, `c210923192.lua`.
- Release trigger/control/protection patterns: local `public/CCG Downloads/CCG_Scripts/c259614449.lua`, official `tmp/omega_scripts/c10000030.lua`.

Verification passed:

- Per-card `luac -p` for the 10 in-scope scripts.
- Full `luac -p` for public, dist, and installed custom script folders (`286` scripts each).
- Targeted `initial_effect` smoke for the 10 in-scope scripts.
- Full `initial_effect` smoke for public, dist, and installed custom script folders (`286` scripts each).
- Public/installed/dist DB row and `aux.Stringid` verification for all 10 IDs.
- Full script hash parity across public scripts, installed scripts, dist scripts, public `CCG_Scripts.zip`, and dist `CCG_Scripts.zip`.
- Public/installed/dist DB hash parity; public/dist `CCG_Database.zip` payload parity.
- Public/dist artifact parity for `assets/cards.json`, script zip, DB, DB zip, and ID map.
- `npm run build` passed with only the existing Vite large-chunk warning.

Remaining live-duel risks:

- `Clock of Aldrez`: confirm Omega accepts the custom hand-as-Tribute cost semantics and that the replacement operation's "your opponent controls" perspective matches intended ruling.
- `Aldrez Grandmaster`: confirm the reveal-or-target activation procedure behaves ergonomically in client prompts and that the battle lock spans the intended Damage Step window.
- `Phantasm Spiral Resurgence`: confirm whether Omega can enforce the negation after the battled monster leaves the field for the GY; the static script follows standard on-field disable reset patterns.
- `Guardian of Wicked Puppeteer`: confirm custom Ritual selection from hand/GY with hand/field materials under full-zone and Necrovalley scenarios.

## Problem List Recheck - 2026-06-21

Rechecked `C:\Users\hclar\Downloads\Some Problems.txt` against current `cards.json`, public Lua, public DB, installed Omega DB, and official Omega analogs in `tmp\omega_scripts`.

Implemented fixes:

- `c256287781.lua` - `Rage of Nephthys`: changed the chain-rewrite effect to follow the official `Phantom of Yubel` pattern in `tmp/omega_scripts/fixed-scripts/Genesys/c80453041.lua`. The replacement operation no longer stores the Rage controller on `re`; it checks/selects the original activating player's valid `Nephthys` monster while the other player performs the selection.
- `c211964444.lua` - `Priestess of Nephthys`: added `Duel.ClearOperationInfo(0)` after the copied Standby-effect target setup, matching official/local copied-effect patterns such as `tmp/omega_scripts/c23153227.lua`, `c244790302.lua`, and `c259193076.lua`.

Static pass notes:

- `To Proto Chrono` is still blocked by source text. `cards.json`, public DB, and installed DB all truncate the description after `During`, and the Lua only implements the known summon procedure.
- `To Proto Psychi` still uses 100-LP choice increments plus the maximum payable amount for `pay any amount of LP`; exact 1-LP granularity remains an in-engine/UI ruling issue.
- `Protogenic Astral Cycle` uses `EFFECT_FORCE_MZONE` for the column restriction and the official `IsCanBeSpecialSummoned(..., true, false)` / `Duel.SpecialSummon(..., true, false, ...)` shape for ignoring Summoning conditions.
- `City Within the Grand Blue` has DB `alias=0`, but the Lua applies `EFFECT_ADD_CODE` for `Umi`; Omega exposes `EFFECT_ADD_CODE` and official Umi alias scripts use runtime code-changing effects, so this remains a runtime behavior to confirm rather than a DB sync defect.
- The remaining checklist entries are mostly duel-state UI/ruling confirmations: custom Ritual/Pendulum/Fusion material selection, delayed deck-order behavior, Battle Phase summon restrictions, hand-as-Tribute, filtered attack-all, Link Rating reduction, and opponent-Deck Tribute handling.

Verification from this recheck:

- `luac -p` passed for all `277` public scripts, all `277` installed Omega script files, and all `277` dist scripts.
- `initial_effect` smoke loading passed for the two changed scripts.
- `c211964444.lua` and `c256287781.lua` hash-match across public scripts, installed Omega scripts, dist scripts, and the public/dist `CCG_Scripts.zip` entries.

## Random Sample Lua Audit - 2026-06-21

Audited a deterministic random sample of 30 scripted cards from the 277 public Lua scripts. Full per-card notes are in `docs/random-sample-lua-audit-2026-06-21.md`.

Implemented fixes:

- `c259624110.lua` - `Grayterror, the Grayscale Beast`: added a `ChangeChainOperation` target legality check, using official `Phantom of Yubel`-style chain rewrite patterns and accounting for the tribute cost opening a monster zone.
- `c244790302.lua` - `Stained Avatar`: added the standard `not c:IsReason(REASON_REPLACE)` guard to the destruction replacement filter.

Verification from this sample audit:

- `luac -p` passed for all `277` public scripts, all `277` installed Omega scripts, and all `277` dist scripts.
- `initial_effect` smoke loading passed for all 30 sampled scripts.
- Public and installed DB rows matched for all 30 sampled IDs.
- `c244790302.lua` and `c259624110.lua` hash-match across public scripts, installed Omega scripts, dist scripts, and the public/dist `CCG_Scripts.zip` entries.

## Random Sample Lua Audit - 2026-06-21 Second Sample

Audited a second deterministic random sample of 30 scripted cards, excluding the previous sample. Full per-card notes are in `docs/random-sample-lua-audit-2026-06-21-second.md`.

Implemented fix:

- `c259229055.lua` - `Graydeux, the Eternal Grayscale Entity`: added official `ChangeChainOperation` target clearing plus activation legality for the replacement operation. The effect now follows the official `Phantom of Yubel`-style chain rewrite pattern from `tmp/omega_scripts/fixed-scripts/Genesys/c80453041.lua` and `tmp/omega_scripts/fixed-scripts/c62318994.lua`, and it only selects `Grayscale` Xyz Monsters that can actually receive a monster as material.

Verification from this second sample audit:

- `luac -p` passed for all `277` public scripts, all `277` dist scripts, and all `277` installed Omega scripts.
- `initial_effect` smoke loading passed for all 30 sampled scripts.
- Public, dist, and installed DB rows matched for all 30 sampled IDs.
- All 30 sampled scripts hash-match across public scripts, dist scripts, installed Omega scripts, and public/dist `CCG_Scripts.zip` entries.
- `npm run build` passed with only the existing Vite large-chunk warning.

## Random Sample Lua Audit - 2026-06-22

Audited a third deterministic random sample of 30 scripted cards, excluding both prior random samples. Full per-card notes are in `docs/random-sample-lua-audit-2026-06-22.md`.

Implemented fixes:

- `c259377794.lua` - `Pip, the Domesticated`: added Necrovalley legality to the Battle Phase GY self-shuffle target and operation, matching sibling `Mylo, the Domesticated` (`c259686203.lua`).
- `c259269688.lua` - `Grayscale Awakening: Nullbind`: excluded Tokens from the optional non-LIGHT overlay-material group before `Duel.Overlay`, matching local Grayscale overlay patterns and official token-exclusion examples.
- `c248788543.lua` - `Right Talismandrake Arms - Blaze Sabre`: added `IsCanBeEffectTarget(e)` to the GY equip target filter and rechecked the target at resolution.
- `c255832330.lua` - `Left Talismandrake Arms - Blaze Shield`: added the same GY equip targetability and resolution recheck.
- `c215034223.lua` - `Talismandrake Arms United`: added targetability to the selected Fusion monster for the Deck equip effect and rechecked the target at resolution.
- `c215921734.lua` - `Left Talismandrake Arms - Obsidian Halberd`: added the same GY equip targetability guard while checking the sampled Talismandrake Arms effects.
- `c238136421.lua` - `Left Talismandrake Arms - Suppressor`: added the same GY equip targetability guard while checking the sampled Talismandrake Arms effects.

Official/local references used in this pass:

- Equip target legality: `tmp/omega_scripts/c10613952.lua`.
- Token exclusion before overlay/material handling: `tmp/omega_scripts/c33202303.lua`, local `c259097228.lua`, and local `c259229055.lua`.
- Necrovalley-safe GY self-shuffle: local sibling `c259686203.lua`.

Verification from this third sample audit:

- `luac -p` passed for all `277` public scripts, all `277` dist scripts, and all `277` installed Omega scripts.
- `initial_effect` smoke loading passed for all 30 sampled scripts.
- Public, dist, and installed DB rows matched for all 30 sampled IDs.
- Full script hash parity passed for all `277` scripts across public scripts, dist scripts, installed Omega scripts, public `CCG_Scripts.zip`, and dist `CCG_Scripts.zip`.
- `npm run build` passed with only the existing Vite large-chunk warning.

## Do Not Revert

The worktree contains many modified and untracked generated files from recent card batches. Do not clean, reset, or revert them unless the user explicitly asks.

Expected dirty/generated areas include:

- `src/data/cards.json`
- `src/data/ccg-omega-ids.json` if present (absent in the current checkout)
- `scripts/import_upcoming_set.py`
- `scripts/sync_omega_ccg_db.py`
- `public/CCG Downloads/CCG_Database/*`
- `public/CCG Downloads/CCG_Scripts/*`
- `dist/*`

## Recently Scripted Cards

These cards have Lua scripts and have been through audit/test passes.

| Card | Source ID | Omega ID | Notes |
| --- | --- | ---: | --- |
| Stardrake of Gravitic Coils | CARD-0001 | 245265629 | Xyz Effect Monster |
| Reactor Shocker | CARD-0002 | 241056746 | Quick-Play Spell |
| The Condescender | CARD-0003 | 221321849 | Effect Monster; Link Rating reduction needs in-engine/ruling support |
| Stained Bird Bria | CARD-0004 | 225091736 | Effect Monster |
| Stained Deer Dante | CARD-0005 | 216958556 | Effect Monster |
| Stained Fox Feness | CARD-0006 | 247499445 | Effect Monster |
| Stained Raptor Rollo | CARD-0007 | 224822244 | Effect Monster |
| Stained Solitaire | CARD-0008 | 259475154 | Effect Monster |
| Stargazer of the Stained | CARD-0009 | 218685316 | Effect Monster |
| Stained Scioness Silia | CARD-0010 | 244408495 | Effect Monster |
| Stained Sovereign Silas | CARD-0011 | 221822671 | Effect Monster |
| Stained Silhouette | CARD-0012 | 256608976 | Effect Monster |
| Abstain from Light | CARD-0013 | 232449539 | Normal Spell |
| Shattering Sustained | CARD-0014 | 248453205 | Normal Trap |
| Stained Avatar | CARD-0015 | 244790302 | Fusion Effect Monster |
| Stained Sorceress Silphia | CARD-0016 | 247789143 | Fusion Effect Monster |
| Distained Druid Dragar | CARD-0017 | 247580036 | Fusion Effect Monster |
| Stainless Kaleidragon | CARD-0018 | 217174535 | Fusion Effect Monster |
| Aetherstorm Zenith Wire-Tailed Sypharion | CARD-0019 | 259365935 | Xyz Effect Monster |
| Red-Eyes Booster Dragon | CARD-00500 | 259628203 | Fusion Effect Monster |
| Rush at the Gnome | CARD-00501 | 259755133 | Normal Trap |
| Calcu Leet | CARD-00502 | 259825991 | Effect Monster |
| Digita Leet | CARD-00503 | 259138193 | Effect Monster |
| Virtua Leet | CARD-00504 | 259940722 | Fusion Effect Monster |
| Herald of White Light | CARD-00505 | 259688676 | Synchro Effect Monster |
| Thunder Dragon Behemoth | CARD-00506 | 259352030 | Fusion Effect Monster |
| Aurelion Divine Illumination | CARD-00507 | 259889864 | Effect Monster |
| Lance Luminar Justiciar | CARD-00508 | 259373017 | Tuner Effect Monster |
| Scarstech Draco | CARD-00509 | 259304399 | Effect Monster |
| Scarstech Wyvern | CARD-00510 | 259531370 | Effect Monster |
| Scarstech Invader | CARD-00511 | 259464700 | Effect Monster |
| Ganan, the Scarstech City | CARD-00512 | 259459462 | Link Effect Monster |
| Qerets, the Scarstech Mother Ship | CARD-00513 | 259086544 | Link Effect Monster |
| Adamantios, the Dark Armor | CARD-00514 | 259315827 | Xyz Effect Monster |
| Disciple of Fire | CARD-00515 | 259023461 | Effect Monster |
| Sorceress of Fire | CARD-00516 | 259360287 | Effect Monster |
| Phlogiston's Roar | CARD-00517 | 259366281 | Counter Trap |
| Harpie Cyber Dancer | CARD-00518 | 259794136 | Effect Monster |
| Harpie Lady Sisters - Phoenix Formation | CARD-00519 | 259269774 | Synchro Effect Monster |
| Mirage Formation Dragon | CARD-00520 | 259072169 | Xyz Effect Monster |
| Glitchling Bitron | CARD-00521 | 259247807 | Ritual Effect Monster |
| Glitchling Protron | CARD-00522 | 259156549 | Ritual Effect Monster |
| Glitchling Witch | CARD-00523 | 259678739 | Ritual Pendulum Effect Monster |
| Glitchling Data-Transfert | CARD-00524 | 259961648 | Ritual Spell |
| Glitchling Octron | CARD-00525 | 259927462 | Link Effect Monster |
| Glitchling Digitron | CARD-00526 | 259494236 | Ritual Effect Monster |
| Glitchling Mage | CARD-00527 | 259072906 | Ritual Pendulum Effect Monster |
| Glitchling Leotron | CARD-00528 | 259873115 | Ritual Pendulum Effect Monster |
| Glitchling Corruption | CARD-00529 | 259546637 | Normal Spell that remains on field |
| Glitchling Hexatron | CARD-00530 | 259253032 | Link Effect Monster |
| Charmelia Kiana | CARD-00534 | 259614449 | Effect Monster |
| Charmelia Hanabi | CARD-00535 | 259790247 | Effect Monster |
| Charmelia Elysia | CARD-00536 | 259288669 | Effect Monster |
| Charmelia Robin | CARD-00537 | 259568843 | Effect Monster |
| Charmelia Pray | CARD-00538 | 259241946 | Ritual Spell |
| Charmelia Deal | CARD-00539 | 259758604 | Continuous Spell |
| Charmelia Beast | CARD-00540 | 259226799 | Continuous Trap |
| Magical Girl Explosion | CARD-00541 | 259402105 | Continuous Trap |
| Charmelia Fairy Kyubey | CARD-00542 | 259489283 | Ritual Effect Monster |
| Charmelia Fairy Morningstar | CARD-00543 | 259753109 | Ritual Effect Monster |
| Wyvernal Luna | CARD-00544 | 259599798 | Effect Monster |
| Wyvernal Caudina | CARD-00545 | 259783008 | Effect Monster |
| Wyvernal Myops | CARD-00546 | 259431066 | Effect Monster |
| Wyvernal Crenata | CARD-00547 | 259533644 | Effect Monster |
| Wyvernal Sphinx | CARD-00548 | 259348317 | Effect Monster |
| Wyvernal Lymantria | CARD-00549 | 259763531 | Fusion Effect Monster |
| Wyvernal Megalopyge | CARD-00550 | 259179054 | Fusion Effect Monster |
| Wyvernal Sanctuary | CARD-00551 | 259160760 | Field Spell |
| Wyvernal Gathering | CARD-00552 | 259073666 | Normal Spell |
| Eclipse Observer Aaliyah | CARD-00553 | 259652372 | Effect Monster |
| Eclipse Observer Riley | CARD-00554 | 259926839 | Effect Monster |
| Eclipse Observer Nora | CARD-00555 | 259069729 | Effect Monster |
| Eclipse Observer Ella | CARD-00556 | 259487387 | Effect Monster |
| Eclipse Observer Maya | CARD-00557 | 259058125 | Effect Monster |
| Eclipse Observatory | CARD-00558 | 259721372 | Field Spell |
| Grimoire of Eclipse | CARD-00559 | 259680842 | Quick-Play Spell |
| Encyclopedia of Eclipse | CARD-00560 | 259614765 | Quick-Play Spell |
| Manual of Eclipse | CARD-00561 | 259273851 | Quick-Play Spell |
| Spellbook of Eclipse | CARD-00562 | 259264449 | Quick-Play Spell |
| Tome of Eclipse | CARD-00563 | 259303191 | Quick-Play Spell |
| Eclipse Observer Baleygr | CARD-00564 | 259193076 | Fusion Effect Monster |
| Eclipse Observer Chandra | CARD-00565 | 259126370 | Xyz Effect Monster |
| Eclipse Observer Seara | CARD-00566 | 259612312 | Synchro Effect Monster |
| Ether Mademoiselle | CARD-00567 | 259223502 | Fusion Effect Monster |
| Heart of the Cards | CARD-00531 | 259485374 | Normal Trap |
| The Orcustograph | CARD-00532 | 259576196 | Synchro Effect Monster |
| Galatea-2, the Orcust Divider | CARD-00533 | 259646610 | Link Effect Monster |
| Sacred Treasure - Chunyin | CARD-0060 | 229499914 | Normal Spell |
| Sacred Treasure - Huangjin | CARD-0061 | 246421842 | Normal Spell |
| NiuHao - Bauba | CARD-0062 | 218600459 | Effect Monster |
| NiuHao - Hikam | CARD-0063 | 235789995 | Effect Monster |
| NiuHao - Oro | CARD-0064 | 232232676 | Effect Monster |
| NiuHao - LokaEO | CARD-0065 | 227043533 | Effect Monster |
| NiuHao - Zaoka | CARD-0066 | 215629896 | Effect Monster |
| NiuHao - Koai | CARD-0067 | 231825514 | Xyz Effect Monster |
| NiuHao - Zao | CARD-0068 | 250556612 | Xyz Effect Monster |
| Pip, the Domesticated | CARD-0069 | 259377794 | Effect Monster |
| Tove, the Domesticated | CARD-0070 | 259737127 | Effect Monster |
| Domestica Praerie | CARD-0071 | 259264881 | Effect Monster |
| Domestica Anjelie | CARD-0072 | 259337739 | Effect Monster |
| Domestica Lunalie | CARD-0073 | 259245149 | Effect Monster |
| Domestication | CARD-0074 | 259201342 | Normal Spell |
| Domestic Underworld | CARD-0075 | 259265448 | Continuous Spell |
| Domestica in the Underworld | CARD-0076 | 259668626 | Continuous Spell |
| Domestica in the Wild | CARD-0077 | 259410628 | Continuous Trap |
| Domestica Kyrie | CARD-0078 | 259670933 | Fusion Effect Monster |
| Pip in the Wild | CARD-0079 | 259394179 | Fusion Effect Monster |
| Branching to Guidance | CARD-0090 | 222257685 | Normal Spell |
| Rigel the Thousand-Armed | CARD-0092 | 215853847 | Link Effect Monster |
| Prophecy of Infernos | CARD-0093 | 229327103 | Effect Monster |
| Prophecy of Waterfalls | CARD-0094 | 251058567 | Effect Monster |
| Prophecy of Boulders | CARD-0095 | 223558392 | Effect Monster |
| Prophecy of Storms | CARD-0096 | 223592011 | Effect Monster |
| Prophecy of Rays | CARD-0097 | 244920555 | Effect Monster |
| Prophecy of Shadows | CARD-0098 | 243920845 | Effect Monster |
| Stellaer of the Swamp | CARD-0099 | 259586445 | Xyz Effect Monster |
| Sustained Succubus Saria | CARD-0100 | 219419648 | Fusion Effect Monster |
| A Stainless Story | CARD-0101 | 245970073 | Quick-Play Spell |
| Mylo, the Domesticated | CARD-0102 | 259686203 | Effect Monster |
| Nuwa, the Domesticated | CARD-0103 | 259135917 | Effect Monster |
| Mylo in the Wild | CARD-0104 | 259911246 | Fusion Effect Monster |
| Nuwa in the Wild | CARD-0105 | 259796760 | Fusion Effect Monster |
| ONIBI | CARD-0106 | 217713649 | Spirit Effect Monster |
| ENRA | CARD-0107 | 214371067 | Spirit Effect Monster |
| KOKESHISA | CARD-0108 | 229399508 | Spirit Effect Monster |
| SHISHI | CARD-0109 | 228033609 | Tuner Spirit Effect Monster |
| MURAMASA | CARD-0110 | 247378501 | Spirit Effect Monster |
| KANMURIYAMA | CARD-0111 | 248801935 | Equip Spell |
| TAKAMA NO HARA | CARD-0112 | 229996802 | Normal Spell |
| Rei-Tachi Ga Kita Hi | CARD-0113 | 246393365 | Continuous Spell |
| OTAKEMARU THE ACCUSER | CARD-0114 | 221855414 | Synchro Spirit Effect Monster |
| CHAMPION OF THE GRAND BLUE | CARD-0115 | 259429721 | Effect Monster |
| DIVING DAUGHTERS OF THE GRAND BLUE | CARD-0116 | 259500899 | Effect Monster |
| SERENE MERMAID OF THE GRAND BLUE | CARD-0117 | 259369909 | Effect Monster |
| JELLY LASS OF THE GRAND BLUE | CARD-0118 | 259934756 | Effect Monster |
| JELLY MISS OF THE GRAND BLUE | CARD-0119 | 259273394 | Effect Monster |
| BRILLIANCE OF THE GRAND BLUE | CARD-00120 | 259417461 | Quick-Play Spell |
| CITY WITHIN THE GRAND BLUE | CARD-0121 | 259679619 | Field Spell |
| GRAND BLUE PRINCESS | CARD-0122 | 259177849 | Fusion Effect Monster |
| ORACLE OF THE GRAND BLUE | CARD-0123 | 259578863 | Link Effect Monster |
| GRAND BLUE MATRIARCH | CARD-0124 | 259093260 | Synchro Effect Monster |
| GRAND BLUE PRINCE | CARD-0125 | 259937946 | Fusion Effect Monster |
| Stellaer of the Lightning Runes | CARD-0126 | 259028576 | Effect Monster |
| PRIESTESS OF NEPHTHYS | CARD-0127 | 211964444 | Ritual Effect Monster |
| SACRED FEATHER OF NEPHTHYS | CARD-0128 | 216532402 | Ritual Spell |
| Stellaer of the Frozen | CARD-129 | 259581666 | Xyz Effect Monster |
| RAGE OF NEPHTHYS | CARD-0130 | 256287781 | Continuous Trap |
| TO PROTO OUSIA | CARD-0131 | 240299292 | Effect Monster; creates Protogenic Essence Token |
| TO PROTO ARCHEGONI | CARD-0132 | 245400676 | Link Effect Monster |
| PROTOGENESIS | CARD-0133 | 246524183 | Normal Spell |
| THE BEGINNING | CARD-0134 | 234729347 | Normal Trap |
| PROTOGENIC ASTRAL CYCLE | CARD-0135 | 232706629 | Field Spell |
| TO PROTO CHRONO | CARD-0136 | 244013196 | Effect Monster; source text is truncated after "During" |
| To Proto Taxis | CARD-0137 | 246380598 | Effect Monster |
| Stellaer of the Plants | CARD-0138 | 259219942 | Effect Monster |
| To Proto Ataxia | CARD-0139 | 224225695 | Effect Monster |
| To Proto Psychi | CARD-0140 | 217332244 | Effect Monster |
| TO PROTO EISODOS | CARD-0141 | 241543138 | Link Effect Monster |
| Polemistis gia Ataxia | CARD-0142 | 254065048 | Fusion Effect Monster |
| Ektelestis gia Taxis | CARD-0143 | 212684822 | Fusion Effect Monster |
| Stellaer of the Cold | CARD-0144 | 259057226 | Effect Monster; text locks ICE monsters while DB attribute is WATER |
| Stellaer of the Night | CARD-0145 | 234455260 | Effect Monster |
| Stellaer of the Sea | CARD-0146 | 226903348 | Effect Monster |
| Stellaer of the Gems | CARD-0147 | 225106953 | Effect Monster; Level-change target wording needs ruling |
| Stellaer of the Breeze | CARD-0148 | 230998543 | Effect Monster |
| Stellaer of the Volcanos | CARD-0149 | 230132786 | Effect Monster |
| Pride of the Stellaers | CARD-0150 | 236551669 | Normal Spell |
| A Stellaer Is Reborn | CARD-0151 | 257549955 | Normal Spell; destroy replacement wording needs in-engine confirmation |
| Stellaer's Pain | CARD-0152 | 259214334 | Counter Trap |
| Stellaer of Lighting | CARD-0153 | 259655976 | Xyz Effect Monster |
| Stellaer of the Flames | CARD-0154 | 212184534 | Xyz Effect Monster |
| Stellaer of the Waters | CARD-0155 | 215445495 | Xyz Effect Monster |
| Stellaer of the Air | CARD-0156 | 216505735 | Xyz Effect Monster |
| Stellaer of the Darkness | CARD-0157 | 231400558 | Xyz Effect Monster |
| Stellaer of Purity | CARD-0158 | 214226989 | Xyz Effect Monster; scaling negate cost needs in-engine confirmation |
| Stellaer of the Ground | CARD-0159 | 219905997 | Xyz Effect Monster |
| Birth of Azrynior | CARD-0160 | 239245471 | Normal Spell; creates a LIGHT Protogenic Essence Token, then Fusion Summons Azrynior |
| Fall of Azrynior | CARD-0161 | 224751741 | Normal Spell; creates a DARK Protogenic Essence Token, then Fusion Summons Dysmandr |
| Restoration of Azrynior | CARD-0162 | 236239443 | Continuous Trap |
| Azrynior, the Abundaence of Purity | CARD-0163 | 245099829 | Fusion Effect Monster |
| Dysmandr, the Depraevity of Worlds | CARD-0164 | 223512283 | Fusion Effect Monster |
| Extinction of Dysmandr | CARD-0165 | 242009896 | Continuous Trap |
| Eldora, the Intergalactic Empire | CARD-0166 | 214552846 | Field Spell; source text has `at least 12` matching criteria wording |
| Eldora in Depraevity | CARD-0167 | 229786055 | Quick-Play Spell; source text has `at least 12` and Extinction count-name wording |
| Frozen Girl & Blood Moon | CARD-0168 | 222676270 | Tuner Effect Monster; category coverage needs in-engine confirmation |
| Ghost Doll & Midnight Manor | CARD-0169 | 222782750 | Tuner Effect Monster |
| Dominus Sentinel | CARD-0170 | 259290896 | Normal Trap |

## Latest Scripting Batch

Generated, re-audited, and synchronized the requested Azrynior / Dysmandr / Eldora / hand-trap batch:

- `c239245471.lua` - Birth of Azrynior
- `c224751741.lua` - Fall of Azrynior
- `c236239443.lua` - Restoration of Azrynior
- `c245099829.lua` - Azrynior, the Abundaence of Purity
- `c223512283.lua` - Dysmandr, the Depraevity of Worlds
- `c242009896.lua` - Extinction of Dysmandr
- `c214552846.lua` - Eldora, the Intergalactic Empire
- `c229786055.lua` - Eldora in Depraevity
- `c222676270.lua` - Frozen Girl & Blood Moon
- `c222782750.lua` - Ghost Doll & Midnight Manor

Implementation notes from this pass:

- Re-audited standalone Lua scripts for CARD-0160 through CARD-0169 and confirmed DB `aux.Stringid` message overrides for the ten current scripts.
- Added explicit sync setcodes for `Stellar` (`0x257C`) and `Eldora` (`0x0738`). Existing explicit setcodes for `Stellaer`, `Ataxia`, `Taxis`, and `Dysmandr` remain in place.
- `src/data/ccg-omega-ids.json` is not present in this checkout. IDs were confirmed from `src/data/cards.json` passcodes and `public/CCG Downloads/CCG_Database/CCG_v1_id_map.json`.
- `Birth of Azrynior` follows the official token-then-Fusion shape: Special Summon the LIGHT Token first, apply cannot-be-Link-Material, then manually Fusion Summon `Azrynior` only if a legal printed material pair and Extra Monster Zone slot exist. Its optional GY recovery shuffle now restricts banished Dragon material to face-up cards and uses `aux.NecroValleyFilter` for GY access.
- `Fall of Azrynior` follows the official token-then-Fusion shape: Special Summon the DARK Token first, apply cannot-be-Link-Material, then manually Fusion Summon `Dysmandr` only if a legal printed material pair and Extra Monster Zone slot exist. Its GY recovery cost uses `aux.NecroValleyFilter` for GY access and restricts banished Dragon material to face-up cards.
- `Azrynior` and `Dysmandr` use `aux.AddFusionProcCodeFun` for the Rank/Level 9 LIGHT Dragon plus Protogenic Token requirement, official face-up S/T placement via `Duel.MoveToField`, and End Phase flags for Tributed Token / destroyed monster checks.
- `Restoration of Azrynior` records monsters destroyed by the opponent this turn and requires the targeted monster to have been destroyed by an opponent's card effect. It summons the target plus all matching flagged monsters only when all can fit.
- `Extinction of Dysmandr` and `Eldora in Depraevity` use Tribute-as-cost and select the "choose" monster during operation, then destroy matching Effect Monsters before destroying the chosen monster. `Eldora in Depraevity` shares the `Extinction of Dysmandr` count code to follow its printed count-name text.
- `Eldora, the Intergalactic Empire` follows official chain-negate patterns for an opponent effect that would destroy 2+ monsters you control, destroying itself first and only then negating the effect. Its destroyed-to-GY effect uses official `Duel.SSet` plus `EFFECT_QP_ACT_IN_SET_TURN`; named banishment access requires face-up banished cards.
- `Frozen Girl & Blood Moon` and `Ghost Doll & Midnight Manor` follow Ash Blossom / Ghost Belle category-based "includes this effect" patterns. Frozen Girl checks Set, Equip/placement, and leave-GY operation metadata; Ghost Doll checks both operation-info location bits and preselected groups for banished/Deck locations.

Repeat bug-fix audit notes:

- `Birth of Azrynior`: optional GY add-back shuffle now rejects face-down banished Dragons, matching the face-up banishment access already used by `Fall of Azrynior`.
- `Restoration of Azrynior`: fixed target legality for the Token-release cost opening a Monster Zone. The pre-cost legality check counts the future freed zone with `e:IsCostChecked()` guarding the post-cost target selection, and the target can only be chosen if the full matching revival group currently fits.
- `Restoration of Azrynior`, `Extinction of Dysmandr`, `Eldora, the Intergalactic Empire`, and `Eldora in Depraevity`: matching against Type/Attribute/Level/ATK/DEF now avoids false matches from Level 0, unknown ATK/DEF, and Link Monsters' missing DEF.
- `Azrynior, the Abundaence of Purity` and `Dysmandr, the Depraevity of Worlds`: their face-up placement effects now advertise possible `CATEGORY_LEAVE_GRAVE` movement when the selectable Continuous Spell/Trap can come from the GY.
- Bug-test pass: `Azrynior, the Abundaence of Purity` and `Dysmandr, the Depraevity of Worlds` now re-check `IsRelateToEffect` before their End Phase Token Special Summon operations, so they do not create Tokens if removed before resolution.
- Bug-test pass: `Eldora, the Intergalactic Empire` now follows the official `Starlight Road` destroy-count formula for partially specified operation-info groups (`ct + matching controlled cards - known group size`), while still supporting broad location/count destroy info.
- Bug-test pass: `Frozen Girl & Blood Moon` no longer treats generic `CATEGORY_GRAVE_ACTION` as enough to activate. Its predicate now checks SSet/MSet locations, Equip/monster-placement operation info, and explicit `CATEGORY_LEAVE_GRAVE` operation info.
- Public scripts, installed Omega scripts, public/dist zips, public/installed DBs, and dist artifacts were resynchronized and hash-verified after the repeat fixes.

Official Omega references used in this pass:

- Token creation and cannot-be-Link-Material: local `c240299292.lua`, local `c232706629.lua`, `c101304086.lua`.
- Token creation followed by Fusion Summon and manual Fusion material send/summon: `c87669904.lua`, `c100233201.lua`, `c12381100.lua`.
- Fusion material procedure / `aux.AddFusionProcCodeFun`: `c17749468.lua`, `c100228002.lua`, `procedure.lua`.
- Face-up S/T placement: `c10004783.lua`, `c101203019.lua`, `c100261001.lua`.
- Set from Deck/GY/banishment and activate this turn: `c100259001.lua`, `c10307853.lua`, `c21050476.lua`, `c24425055.lua`, `c27923575.lua`, plus `EFFECT_QP_ACT_IN_SET_TURN` examples `c36429703.lua`, `c50237654.lua`, `c58019984.lua`.
- Release/destroy turn tracking: `c100256007.lua`, `c100256005.lua`, `c29307554.lua`, `c1966438.lua`, `c19048328.lua`.
- Chain negate / disable effect that would destroy cards: `c58120309.lua`, `c12298909.lua`, `c3027001.lua`, `c34365442.lua`, `c92359409.lua`.
- Hand trap category checks: `c14558127.lua` (Ash Blossom) and `c73642296.lua` (Ghost Belle).
- Necrovalley / GY + banishment filters: `c100245019.lua`, `c55965529.lua`, `c41782653.lua`, `c65961304.lua`.

Verification passed:

- Per-card `luac -p` for the 10 in-scope scripts.
- Targeted Lua predicate harness for `Eldora, the Intergalactic Empire` destroy-count prediction and `Frozen Girl & Blood Moon` category detection.
- Full public script folder `luac -p` (`277` scripts).
- Installed custom CCG script `luac -p` for every public script counterpart (`277` scripts).
- Full dist script folder `luac -p` (`277` scripts).
- Targeted `initial_effect` smoke for the 10 in-scope scripts.
- Static scan found no `require`, `dofile`, `loadfile`, or loader/subfile usage in the ten scripts.
- `python -m py_compile scripts/sync_omega_ccg_db.py`.
- Public and installed DB full sync: `cards_in_source=577`, `updated=577`, `datas_count=585`, `texts_count=585`.
- DB row/Stringid/id-map verification for all 10 in public, dist, and installed DBs.
- Full script hash parity across public scripts, installed Omega scripts, public/dist `CCG_Scripts.zip`, and `dist` (`277` scripts).
- Public/installed `CCG_v1.db` hash parity and public/dist DB/zip/id-map parity.
- `CCG_Database.zip` contains the same `CCG_v1.db` as the public DB.
- `npm run verify:public-cards`.
- `npm run build` (passed with the existing Vite large-chunk warning).
- Public/dist `CCG Downloads` artifact hash parity (`294` files).
- `git diff --check` on touched paths produced no whitespace errors; only existing CRLF normalization warnings.

Cards still needing in-engine/ruling confirmation:

- `Birth of Azrynior`: test Token creation plus Fusion Material selection when the Token is required to free the Extra Monster Zone.
- `Fall of Azrynior`: source text says "You can also shuffle ... to activate this effect"; current script treats the shuffle as the activation cost for the GY add-back effect. Confirm this is the intended optional-cost ruling.
- `Fall of Azrynior`: test token creation plus Fusion Material selection when the Token is required to free the Extra Monster Zone.
- `Eldora, the Intergalactic Empire`: source text says "When ... resolves"; current script implements the closest official chainable negate pattern. Confirm timing in-engine.
- `Eldora, the Intergalactic Empire` and `Eldora in Depraevity`: source text says `at least 12 of the same Type, Attribute, Level, ATK or DEF`; scripts implement "at least 1 matching criterion" because 12 criteria is impossible from the listed five. Needs card-text/ruling confirmation.
- `Eldora in Depraevity`: source text names `Extinction of Dysmandr` in its once-per-turn clause; current script shares that count code literally. Confirm if it should instead count under its own name.
- `Frozen Girl & Blood Moon`: no exact official category exists for every "place face-up on the field" case. The script uses official hand-trap category/location checks plus `CATEGORY_SSET`, `CATEGORY_MSET`, `CATEGORY_EQUIP`, and explicit `CATEGORY_LEAVE_GRAVE` operation info; confirm coverage and over/under-trigger cases in-engine.
- `Restoration of Azrynior`: test the delayed destroyed-this-turn tracking with battle destruction, effect destruction, and multi-monster revival UI.

## Previous Scripting Batch - Stellaer Reborn / Stellaer Xyz / Birth

Generated and audited the Stellaer Reborn / Stellaer Xyz / Birth of Azrynior batch:

- `c257549955.lua` - A Stellaer Is Reborn
- `c259214334.lua` - Stellaer's Pain
- `c259655976.lua` - Stellaer of Lighting
- `c212184534.lua` - Stellaer of the Flames
- `c215445495.lua` - Stellaer of the Waters
- `c216505735.lua` - Stellaer of the Air
- `c231400558.lua` - Stellaer of the Darkness
- `c214226989.lua` - Stellaer of Purity
- `c219905997.lua` - Stellaer of the Ground
- `c239245471.lua` - Birth of Azrynior

Implementation notes from this pass:

- Added standalone Lua scripts for CARD-0151 through CARD-0160 and DB `aux.Stringid` message overrides for the ten current scripts.
- `A Stellaer Is Reborn` uses `aux.NecroValleyFilter` for GY revival and the official field destroy-replacement shape from the GY, banishing itself with `REASON_EFFECT+REASON_REPLACE`.
- `Stellaer's Pain` follows official Counter Trap negate sequencing: `Duel.IsChainNegatable(ev)`, `Duel.NegateActivation(ev)`, then destroy only while the activated card still relates to its effect.
- The six Rank 9 Stellaer Xyz monsters reuse the established local Stellaer alternate Xyz Summon pattern: two Level 9 Dragon materials, or one Level 9 Stellaer monster if you control no Xyz Monsters.
- All Stellaer no-material draw effects re-check the Xyz Monster is still related, still has no materials, and is destructible; draw only happens after `Duel.Destroy` succeeds.
- `Stellaer of Lighting`, `Waters`, `Ground`, and `Birth of Azrynior` guard GY access with `aux.NecroValleyFilter`.
- `Stellaer of the Air` and `Stellaer of the Darkness` implement the non-targeting "send 1 monster on the field to the GY" effect by selecting at operation time.
- `Stellaer of Purity` uses `aux.AddXyzProcedureLevelFree` for 3 Rank 9 Dragon Xyz Monsters, transfers overlay groups before overlaying the chosen Xyz Monster, and tracks its increasing negate cost with a turn-reset flag.
- `Birth of Azrynior` creates a Protogenic Essence Token with a single-card `EFFECT_CANNOT_BE_LINK_MATERIAL` restriction, then manually Fusion Summons `Azrynior, the Abundaence of Purity` using the printed material requirements because `c245099829.lua` is not present yet.
- `Birth of Azrynior` only moves to Fusion selection after the Token is successfully Summoned. Its Fusion material check now includes `aux.MustMaterialCheck`, `aux.FCheckAdditional`, `aux.FGoalCheckAdditional`, and `Duel.GetLocationCountFromEx`; `CompleteProcedure()` only runs after `Duel.SpecialSummon` succeeds.
- Repeat bug-fix audit pinned custom Omega setcodes for `Stellaer` (`0x0DE4`), `Ataxia` (`0x7398`), `Taxis` (`0x27E9`), and `Dysmandr` (`0x0A6B`) in `sync_omega_ccg_db.py`; `Birth of Azrynior` now syncs as an `Ataxia` card instead of inheriting the Stellaer code from the existing-row heuristic.

Official Omega references used in this pass:

- Stellaer Xyz alternate Summon / no-material draw: local `c259586445.lua`, local `c259581666.lua`.
- Stellaer GY revival / Necrovalley handling: local `c259028576.lua`.
- Xyz LevelFree / Rank-based Xyz material procedure: `tmp/omega_scripts/procedure.lua`.
- Xyz-over-Xyz material and overlay transfer: `fixed-scripts/Targeting/c43355214.lua`, `c86196216.lua`, `c32044231.lua`, `fixed-scripts/c28346136.lua`, `fixed-scripts/c31086840.lua`, `fixed-scripts/c44698398.lua`, `fixed-scripts/loop/c38044854.lua`.
- Destroy replacement: `c10002346.lua`, `c100211122.lua`, `c101203048.lua`, `fixed-scripts/c71100270.lua`.
- Negate activation and destroy: `c100211050.lua`, `c2339825.lua`.
- Token creation and "cannot be Link Material": local `c240299292.lua`, local `c232706629.lua`, `c101304086.lua`.
- Token creation followed by Fusion Summon: `fixed-scripts/fusion/c87669904.lua`.
- Leave-field because of opponent's card: official `EVENT_LEAVE_FIELD` / `GetReasonPlayer()==1-tp` patterns found in the Omega corpus.

Verification passed:

- Per-card `luac -p` for the 10 in-scope scripts.
- Full public script folder `luac -p` (`267` scripts).
- Full installed Omega script folder `luac -p` (`267` scripts).
- Full dist script folder `luac -p` (`267` scripts).
- Targeted `initial_effect` smoke for the 10 in-scope scripts and full public/installed `initial_effect` smoke (`267` scripts each).
- `python -m py_compile scripts/sync_omega_ccg_db.py`.
- Public and installed DB full sync: `cards_in_source=577`, `updated=577`, `datas_count=585`, `texts_count=585`.
- DB row/Stringid verification for all 10 in both public and installed DBs.
- Full script hash parity across public scripts, installed Omega scripts, `CCG_Scripts.zip`, and `dist` (`267` scripts).
- Public/installed `CCG_v1.db` hash parity and public/dist DB/zip/id-map parity.
- Static scan for forbidden loaders, cost/target/operation placement, `IsRelateToEffect` rechecks, Necrovalley coverage, negate sequencing, and custom Fusion "if you do" sequencing.
- `npm run verify:public-cards`.
- `npm run build` (passed with the existing Vite large-chunk warning).
- Public/dist core artifact hash parity for `assets/cards.json`, scripts zip, DB, DB zip, and ID map.
- `git diff --check` on touched paths produced no whitespace errors; only existing CRLF normalization warnings.

Cards still needing in-engine/ruling confirmation:

- `A Stellaer Is Reborn`: Omega destroy-replacement hooks expose the destruction event but not a clean pre-replacement "would be sent to the GY" destination check. The script replaces on-field Stellaer monster destruction by battle/effect; confirm this matches intended wording.
- `Stellaer of Purity`: the negate cost is interpreted as including the current activation, so the first activation detaches 1 material, second detaches 2, etc. Confirm intended scaling.
- `Stellaer of Purity`: test `aux.AddXyzProcedureLevelFree` UI with exactly 3 Rank 9 Dragon Xyz materials and the overlay transfer effect in-engine.
- `Birth of Azrynior`: `Azrynior, the Abundaence of Purity` has no standalone script yet. `Birth` can perform the printed Fusion Summon directly, but Azrynior's own effects will not operate until `c245099829.lua` is scripted.
- `Birth of Azrynior`: test Token creation plus Fusion Material selection when the Token is required to free the Extra Monster Zone.

## Previous Scripting Batch - To Proto / Stellaer / Pride

Generated and audited the To Proto Eisodos / Polemistis / Ektelestis / Stellaer / Pride batch:

- `c241543138.lua` - TO PROTO EISODOS
- `c254065048.lua` - Polemistis gia Ataxia
- `c212684822.lua` - Ektelestis gia Taxis
- `c259057226.lua` - Stellaer of the Cold
- `c234455260.lua` - Stellaer of the Night
- `c226903348.lua` - Stellaer of the Sea
- `c225106953.lua` - Stellaer of the Gems
- `c230998543.lua` - Stellaer of the Breeze
- `c230132786.lua` - Stellaer of the Volcanos
- `c236551669.lua` - Pride of the Stellaers

Fixes and implementation notes from this pass:

- Added standalone Lua scripts for CARD-0141 through CARD-0150 and DB `aux.Stringid` message overrides for the ten current scripts.
- `TO PROTO EISODOS` uses official Link material structure for 2 Effect Monsters with different names, official token creation with `Duel.SpecialSummonStep`, and "then" sequencing that only continues after both the field target and Deck monster are banished.
- `Polemistis gia Ataxia` and `Ektelestis gia Taxis` use official contact-Fusion / Extra Deck Special Summon patterns: `aux.AddFusionProcFunRep`, `EFFECT_SPSUMMON_CONDITION`, `Duel.GetLocationCountFromEx`, selected release material groups, `c:SetMaterial`, and `Duel.Release(...,REASON_SPSUMMON+REASON_MATERIAL)`.
- `Polemistis gia Ataxia` implements the ATK/DEF gain as a continuous sum of current ATK/DEF loss on face-up monsters, halved. This is the closest static Omega representation because the corpus has no clean event hook for "a monster(s) loses ATK/DEF".
- `Polemistis gia Ataxia` and `Ektelestis gia Taxis` use explicit current passcode tables for searchable `Ataxia`/`Taxis` Spell/Trap cards because these are name/text-treated cards rather than a searchable setcode.
- The six Stellaer hand Special Summon effects follow the prior Stellaer hand-summon pattern and apply the rest-of-turn Attribute summon lock in the summon procedure operation.
- `Stellaer of the Sea` and `Stellaer of the Breeze` guard GY access with `aux.NecroValleyFilter`.
- `Stellaer of the Breeze` uses the official immediate `Duel.XyzSummon(tp,xyz,mg)` pattern with exactly the two monsters Special Summoned by its effect.
- `Stellaer of the Gems` uses Omega's official Level/Rank announcement prompt constant (`HINGMSG_LVRANK`) and `EFFECT_CHANGE_LEVEL`.
- `Pride of the Stellaers` uses three standalone activation effects with separate once-per-turn count codes, one each for Deck search, hand Special Summon, and immediate Xyz Summon.

Official Omega references used in this pass:

- Contact Fusion / Extra Deck Special Summon by releasing materials: `c15291624.lua`, `c100245006.lua`, `c42166000.lua`.
- Link-2 and different-name Link material checks: `c101202084.lua`, `c100256018.lua`, `c101301085.lua`.
- Token creation: `c100211003.lua`, `c101203044.lua`, local `c240299292.lua`, local `c232706629.lua`.
- Battle damage reflection/halving and battle damage recovery: `c100213004.lua`, `c13313278.lua`, `c101301087.lua`, local `c246380598.lua`.
- Return banished Extra Deck monster / redirect patterns: `c100240203.lua`, `c100211123.lua`, `c100250204.lua`, local `c227043533.lua`, local `c221855414.lua`, local `c228033609.lua`, local `c221321849.lua`.
- Attack-all and repeated attack structures: `c100256016.lua`, local `c215853847.lua`, local `c213266433.lua`.
- Level declaration/change patterns: `c16725505.lua`, `c16769305.lua`, `c20579538.lua`, `c22657402.lua`.
- Xyz Summon with a selected material group: local `c231825514.lua`, local `c250556612.lua`, local `c218600459.lua`.
- `Pride of the Stellaers`: multiple activation effects / separate count codes from `c71083002.lua`; Deck search from `c100227043.lua`; hand Special Summon from `c100233006.lua`; immediate Xyz Summon from `fixed-scripts/Targeting/c197042.lua` and `fixed-scripts/beta/c68663427.lua`.

Verification passed:

- Per-card `luac -p` for the 10 in-scope scripts.
- Full public script folder `luac -p` (`257` scripts).
- Full installed Omega script folder `luac -p` (`257` scripts).
- Full dist script folder `luac -p` (`257` scripts).
- Inline `initial_effect` smoke for the 10 in-scope scripts.
- `python -m py_compile scripts/sync_omega_ccg_db.py`.
- Public and installed DB full sync: `cards_in_source=577`, `updated=577`, `datas_count=585`, `texts_count=585`.
- DB row/Stringid verification for all 10 in both public and installed DBs.
- Targeted script hash parity across public scripts, installed Omega scripts, and `CCG_Scripts.zip`.
- Public/installed `CCG_v1.db` hash parity and `CCG_Database.zip` DB hash parity.
- Static best-practice scan for forbidden loaders, cost/target/operation placement, `IsRelateToEffect` rechecks, Necrovalley coverage, and official immediate Xyz pattern.
- `npm run build`.
- Public/dist artifact hash parity for cards JSON, scripts, DB, zips, and ID map.
- `git diff --check` produced no whitespace errors; only existing CRLF normalization warnings.

Cards still needing in-engine/ruling confirmation:

- `To Proto Psychi`: "pay any amount of LP" is represented with Omega number-announcement choices in 100-LP increments plus the maximum payable amount. Confirm whether exact 1-LP granularity is required.
- `Polemistis gia Ataxia`: continuous "if a monster(s) loses ATK/DEF" behavior is implemented as current ATK/DEF loss across face-up monsters. Test layered ATK/DEF modifiers and simultaneous loss cases in-engine.
- `Polemistis gia Ataxia` / `Ektelestis gia Taxis`: `Ataxia`/`Taxis` Spell/Trap lookup uses explicit current passcodes (`Birth of Azrynior`, `Chapter II Verse IV`, `Fall of Azrynior`). Update if future treated-as cards are added.
- `Stellaer of the Cold`: source text says the Special Summon lock is for `ICE` monsters, but the DB row attribute is WATER; the script locks custom `ATTRIBUTE_ICE=0x400`. Confirm intended data/ruling in Omega.
- `Stellaer of the Gems`: text says "target 2 cards you control", but Level changes only apply cleanly to face-up monsters with Levels. The script restricts the targets to face-up Level monsters; confirm wording/ruling.
- `Stellaer of the Breeze`: immediate Xyz Summon with exactly the two Special Summoned monsters should be tested in-engine for Extra Deck selection and material UI.
- `Pride of the Stellaers`: the three "activate one of the following effects" bullets are represented as separate activation choices to preserve each bullet's once-per-turn count; confirm Omega UI behavior and the generic Xyz Summon material prompt in-engine.

## Repeat Deep Audit - Last 20 To Proto / Stellaer Entries

The repeat audit covered the last two 10-card batch entries, CARD-0131 through CARD-0149. `To Proto Psychi` appears in both batch prompts, so this is 20 prompted entries and 19 unique scripts.

Concrete fix from this audit:

- `PROTOGENIC ASTRAL CYCLE` (`c232706629.lua`): changed its continuous zone restriction, token effect, and opponent-chain Quick Effect ranges from `LOCATION_SZONE` to `LOCATION_FZONE`. Official Field Spell scripts use `LOCATION_FZONE`, and `THE BEGINNING` already used that pattern.

Additional audit notes:

- `TO PROTO OUSIA`: token creation and banish-as-cost GY trigger follow official token/cost patterns; the draw only occurs after a monster is successfully added to hand.
- `TO PROTO ARCHEGONI`: `SetSPSummonOnce(id)` matches official once-per-turn Extra Deck summon practice; its search currently covers the current To Proto Spell/Trap pool by setcode.
- `PROTOGENESIS`: "if you do" End Phase LP loss is still only registered after the selected monster is successfully Special Summoned or banished.
- `THE BEGINNING`: Field Spell effects already used `LOCATION_FZONE`; token and target-protection effects passed repeat review.
- `TO PROTO CHRONO`: still only scripts the complete printed Special Summon procedure because source text is truncated after `During`.
- `To Proto Taxis`, `To Proto Ataxia`, and `To Proto Psychi`: self-summon costs, Token tribute costs, target operations, battle/negate effects, and banished-from-field recovery were rechecked.
- `Stellaer of the Plants`, `Stellaer of the Sea`, and `Stellaer of the Breeze`: GY access still uses `aux.NecroValleyFilter`.
- `TO PROTO EISODOS`: the banish-then-summon/return sequence still only continues after both banishes succeed.
- `Polemistis gia Ataxia` and `Ektelestis gia Taxis`: contact Fusion material release, `aux.fuslimit`, Deck add/send choices, and damage/attack-all effects were rechecked against official patterns.
- `Stellaer of the Cold`, `Night`, `Sea`, `Gems`, `Breeze`, and `Volcanos`: hand Special Summon restrictions and detached-from-Xyz triggers were rechecked.

Verification passed after the repeat audit fix:

- Per-card `luac -p` for all 19 unique scripts.
- Full public script folder `luac -p` (`256` scripts).
- Full installed Omega script folder `luac -p` (`256` scripts).
- Full dist script folder `luac -p` (`256` scripts).
- Inline `initial_effect` smoke for all 19 unique scripts.
- DB row/Stringid verification for CARD-0131 through CARD-0149 in both public and installed DBs.
- Public/installed DB hash parity.
- Targeted script hash parity across public scripts, installed Omega scripts, `CCG_Scripts.zip`, and dist scripts.
- Public/dist artifact hash parity for scripts, script zip, cards JSON, DB, and DB zip.
- `python -m py_compile scripts/sync_omega_ccg_db.py`.
- `npm run build`.
- `git diff --check` for touched script/artifact paths.

Remaining manual/in-engine risk list after this repeat audit:

- `TO PROTO CHRONO`: source text remains incomplete after `During`.
- `PROTOGENIC ASTRAL CYCLE`: column locking from a Field Zone card uses Omega's zone-mask API but still needs in-engine UI/ruling confirmation.
- `PROTOGENIC ASTRAL CYCLE`: "ignoring its card effects" is represented with Omega's ignore-Summoning-condition flag; confirm intended ruling.
- `To Proto Psychi`: exact "any amount of LP" granularity may require in-engine or wording ruling.
- `Stellaer of the Plants`: overlay redirect should be duel-tested with multiple Stellaer Xyz costs and Necrovalley active.
- `Polemistis gia Ataxia`: continuous current-loss ATK/DEF gain should be duel-tested with layered modifiers.
- `Polemistis gia Ataxia` / `Ektelestis gia Taxis`: explicit Ataxia/Taxis Spell/Trap passcode tables should be updated when future treated-as cards are added.
- `Stellaer of the Cold`: confirm whether the printed ICE lock or the WATER DB attribute is intended.
- `Stellaer of the Gems`: confirm whether "2 cards you control" should remain restricted to face-up monsters with Levels.
- `Stellaer of the Breeze`: immediate Xyz Summon material-selection UI should be duel-tested.

## Prior Fully Audited To Proto / Stellaer Batch

Generated and audited the To Proto / Stellaer batch:

- `c240299292.lua` - TO PROTO OUSIA
- `c245400676.lua` - TO PROTO ARCHEGONI
- `c246524183.lua` - PROTOGENESIS
- `c234729347.lua` - THE BEGINNING
- `c232706629.lua` - PROTOGENIC ASTRAL CYCLE
- `c244013196.lua` - TO PROTO CHRONO
- `c246380598.lua` - To Proto Taxis
- `c259219942.lua` - Stellaer of the Plants
- `c224225695.lua` - To Proto Ataxia
- `c217332244.lua` - To Proto Psychi

Fixes and implementation notes from this pass:

- Added standalone Lua scripts and DB `aux.Stringid` message overrides for CARD-0131 through CARD-0140.
- Added the `Protogenic Essence Token` helper DB row (`240299293`) using the To Proto set code.
- `TO PROTO OUSIA`, `THE BEGINNING`, and `PROTOGENIC ASTRAL CYCLE` use the official token creation pattern with `Duel.IsPlayerCanSpecialSummonMonster`, `Duel.CreateToken`, and zone rechecks.
- `TO PROTO ARCHEGONI` follows official Link-1 / once-per-Link-Summon structure and keeps discard/banish costs in cost functions; its GY search uses `aux.NecroValleyFilter`.
- `PROTOGENESIS` only registers the End Phase LP-loss effect after the reveal action successfully Special Summons or banishes the selected monster.
- `TO PROTO CHRONO`, `To Proto Taxis`, `To Proto Ataxia`, and `To Proto Psychi` use official "Cannot be Normal Summoned/Set" plus `EFFECT_SPSUMMON_CONDITION` / `EFFECT_SPSUMMON_PROC` patterns with `SUMMON_VALUE_SELF`.
- `Stellaer of the Plants` follows the prior `Stellaer of the Lightning Runes` hand-summon pattern and attaches itself as Xyz material using official `Duel.Overlay` structure; the detach-to-banish handling uses the existing overlay redirect pattern.
- Repeat deep audit of CARD-0121 through CARD-0140: `TO PROTO ARCHEGONI` no longer has unprinted once-per-turn limits on its Link Summon search or protection effects.
- Repeat deep audit of CARD-0121 through CARD-0140: `PROTOGENIC ASTRAL CYCLE` now uses official `GetColumnZone(LOCATION_MZONE,tp)` masking for the column summon restriction instead of a hand-built sequence mask.
- Repeat deep audit of CARD-0121 through CARD-0140: `To Proto Taxis`, `To Proto Ataxia`, and `To Proto Psychi` now require the removed card to be face-up before their "banished from the field" triggers can activate.
- Repeat deep audit of CARD-0121 through CARD-0140: `To Proto Psychi` now applies once-per-turn coverage to its battle-damage LP gain.
- Repeat deep audit of CARD-0121 through CARD-0140: `Stellaer of the Plants` now guards its self-attach from the GY with `aux.NecroValleyFilter`.
- Follow-up data correction: image star counts were checked and Levels were set to `11` for `To Proto Taxis`, `To Proto Ataxia`, and `To Proto Psychi`; `7` for `Polemistis gia Ataxia` and `Ektelestis gia Taxis`; `10` for `Dysmandr, the Depraevity of Worlds` and `Ether Mademoiselle`. Public, installed, zip, and dist DB artifacts were synchronized after the correction.

Official Omega references used in this pass:

- Token creation: `c100211003.lua`, `c101203044.lua`, local `c222257685.lua`.
- Link summon once per turn / Link material: `c100211051.lua`, `c25072579.lua`.
- Must-first Special Summon procedures: `c100212002.lua`, `c18175965.lua`, `c13224603.lua`, `c25920413.lua`, local `c244921711.lua`.
- Overlay attach / detached material: `c101202087.lua`, `c101203047.lua`, `c101203048.lua`, local `c231825514.lua`, local `c250556612.lua`, local `c259028576.lua`.
- Negate/disable and chain operation best practices: `c100245037.lua`, local `c259796760.lua`, `c25072579.lua`.
- Battle damage reflection/halving, LP recovery/loss: `c100213004.lua`, `c13313278.lua`, `c101301087.lua`.
- Column and zone handling: local `c259429721.lua`, `c61665245.lua`.

Verification passed:

- Per-card `luac -p` for the 10 generated scripts.
- Full public and installed script folder `luac -p` (`247` scripts each).
- `initial_effect` smoke for the 10 generated scripts and all public custom scripts (`247` scripts).
- DB name/text/Stringid/token verification for the 10 generated scripts plus `Protogenic Essence Token` in both public and installed DBs.
- Static best-practice scan for forbidden loaders, cost/target/operation separation, expected `IsRelateToEffect` rechecks, and expected Necrovalley coverage.
- Public script hash parity against installed root scripts and `CCG_Scripts.zip` (`247` scripts).
- Public/installed DB hash parity and `CCG_Database.zip` DB hash parity.
- `npm run build`.
- Public/dist `CCG Downloads` artifact hash parity (`269` files).
- Repeat deep audit of CARD-0121 through CARD-0140 passed per-card Lua syntax, full public/installed Lua syntax, full public/installed `initial_effect` smoke, DB/Stringid verification, script/zip/install hash parity, DB zip parity, `npm run build`, and public/dist artifact parity after the fixes above.

Cards still needing in-engine/ruling confirmation:

- `TO PROTO CHRONO`: source text and DB text are truncated after the word `During`; only the complete summon restriction/procedure is scripted.
- `PROTOGENIC ASTRAL CYCLE`: the column summon restriction uses Omega zone-mask enforcement for Effect Monsters; confirm the Main Monster Zone prompt/lock behavior in-engine.
- `PROTOGENIC ASTRAL CYCLE`: "ignoring its card effects" is implemented with Omega's ignore-Summoning-condition Special Summon flag; confirm intended ruling if it should bypass different restrictions.
- `To Proto Psychi`: "pay any amount of LP" uses Omega's number-announcement UI with 100-LP increments plus the maximum payable amount; confirm if exact 1-LP granularity is required.
- `Stellaer of the Plants`: attached-card banish-on-detach uses a targeted overlay redirect effect; test with multiple `Stellaer` Xyz costs and Necrovalley active.

## Prior Fully Audited KANMURIYAMA / Grand Blue / Nephthys Batch

Generated and audited the KANMURIYAMA / Grand Blue / Stellaer / Nephthys batch:

- `c248801935.lua` - KANMURIYAMA (repeat audit only; no code change)
- `c259679619.lua` - CITY WITHIN THE GRAND BLUE
- `c259177849.lua` - GRAND BLUE PRINCESS
- `c259578863.lua` - ORACLE OF THE GRAND BLUE
- `c259093260.lua` - GRAND BLUE MATRIARCH
- `c259937946.lua` - GRAND BLUE PRINCE
- `c259028576.lua` - Stellaer of the Lightning Runes
- `c211964444.lua` - PRIESTESS OF NEPHTHYS
- `c216532402.lua` - SACRED FEATHER OF NEPHTHYS
- `c259581666.lua` - Stellaer of the Frozen
- `c256287781.lua` - RAGE OF NEPHTHYS

This pass first repeat-audited the previous Spirit/Grand Blue batch. No additional code changes were made there; KANMURIYAMA remains an in-engine lost-target test case.

Fixes and implementation notes from this pass:

- Added standalone Lua scripts and DB `aux.Stringid` message overrides for CARD-0121 through CARD-0130.
- `GRAND BLUE PRINCESS`: tightened the target filter so the "send the targeted monster to the GY" target must be a monster that can actually be sent; Fusion material checks now use `IsFusionSetCard`.
- Repeat deep audit: `GRAND BLUE PRINCESS` now restricts "1 card in your banishment" to the activating player's banished cards.
- `ORACLE OF THE GRAND BLUE`: widened the pointed-monster DEF aura to both players' Monster Zones because the text does not say "you control".
- Repeat deep audit: `ORACLE OF THE GRAND BLUE` Link materials now use the official `IsLinkSetCard` material predicate.
- `GRAND BLUE MATRIARCH`: replaced the Link-2-only Synchro material approximation with official-style `EFFECT_SYNCHRO_LEVEL_EX` effects for Link Ratings 1 through 6.
- `GRAND BLUE PRINCE`: enforced "using only monsters in your possession" directly in both Fusion material predicates.
- `SACRED FEATHER OF NEPHTHYS`: guarded Ritual material checks against nil Ritual monsters, allowed the GY effect to destroy a Spell/Trap Zone card to open space before placing the Continuous Trap, and added delayed/Damage Step trigger flags.
- Repeat deep audit: `SACRED FEATHER OF NEPHTHYS` now removes the selected Ritual Monster from the hand/field material pool before checking/selecting materials, following official Ritual procedure behavior.
- `Stellaer of the Frozen`: added `IsCanTurnSet`, `CancelToGrave`, and `EVENT_SSET` handling when setting face-up Spell/Trap targets.
- `RAGE OF NEPHTHYS`: made "becomes 0 by this effect" ignore monsters already at 0 ATK before the reduction and matched official visible-field Nephthys destruction filtering.
- Repeat deep audit: `RAGE OF NEPHTHYS` now checks that the replacement operation has a valid `Nephthys` monster before the cost is paid and clears the original chain targets before `ChangeChainOperation`.

Official Omega references used in this pass:

- Umi / Field Spell alias and activation patterns: `c295517.lua`, `c2819435.lua`, `c11082056.lua`.
- Fusion material helpers and custom possession/material gating: `c100211097.lua`, `c100241001.lua`, local `c259369909.lua`, `c259934756.lua`, `c259273394.lua`.
- Link summon, linked-group, and negate/disable patterns: `c50669347.lua`, `c100245037.lua`, local `c224274662.lua`.
- Link-as-Synchro-material patterns: `c31603289.lua`, `c67098897.lua`, `c93192592.lua`.
- Alternate Xyz Summon patterns: `c16110708.lua`, `c2530830.lua`, `c25853045.lua`, local `c259586445.lua`.
- Nephthys Ritual and Standby-effect patterns: `c23459650.lua`, `c88176533.lua`, `c8454126.lua`, `c25397880.lua`, `c51782995.lua`, `c52904476.lua`, `c98999181.lua`.
- Copied activation/effect application: `c23153227.lua`, `c43331750.lua`, `c70369116.lua`, `c97769122.lua`.
- Destroy-from-Deck, face-up Spell/Trap placement/setting, and equip lost-target handling: `c60482781.lua`, `c10004783.lua`, `c100261001.lua`, `c101303208.lua`, `c35884610.lua`.
- Banishment targeting, Link material, Ritual material, detached-material, and chain operation rewrite: `c100211100.lua`, `c100211123.lua`, `c12421694.lua`, `c1340142.lua`, `procedure.lua`, `c45184165.lua`, `c32696942.lua`, `c25072579.lua`, `c53589300.lua`, `c62318994.lua`, local `c259229055.lua`, `c18168997.lua`, `c41418852.lua`.

Verification passed:

- Per-card `luac -p` for the 11 audited/generated scripts.
- Full public and installed script folder `luac -p` (`237` scripts each).
- `initial_effect` smoke for all public custom scripts (`237` scripts).
- DB name/text/Stringid verification for the 11 audited/generated scripts in both public and installed DBs.
- Static best-practice scan for forbidden loaders, target-operation separation, cost markers, and expected Necrovalley coverage.
- Public script hash parity against installed root scripts and `CCG_Scripts.zip` (`237` scripts).
- Public/installed DB hash parity and `CCG_Database.zip` DB hash parity.
- `npm run build`.
- Public/dist download artifact hash parity (`258` files).

Cards still needing in-engine/ruling confirmation:

- `KANMURIYAMA`: the self-return trigger keys off Omega's `REASON_LOST_TARGET`/previous equip target state when the equipped Spirit returns to the hand.
- `CITY WITHIN THE GRAND BLUE`: the "always treated as Umi" text is implemented with runtime `EFFECT_ADD_CODE` because the DB parser does not assign an alias row.
- `GRAND BLUE MATRIARCH`: the official Link-as-Level effects should be tested in the Synchro Summon UI with Link Ratings other than 2.
- `PRIESTESS OF NEPHTHYS`: "apply that card's effect that activates during the Standby Phase" uses the official copied-effect idiom after destroying the Deck monster, but exact behavior is card-pool/ruling sensitive.
- `SACRED FEATHER OF NEPHTHYS`: Deck-as-Ritual-material and face-up Continuous Trap placement from Deck should be confirmed in Omega, including full Spell/Trap Zone cases and Damage Step destruction triggers.
- `Stellaer of the Lightning Runes`: the detached-from-overlay trigger should be tested with different `Stellaer` Xyz costs and Necrovalley active.
- `Stellaer of the Frozen`: setting face-up Spell/Trap cards should be tested for Continuous, Field, Pendulum, and chain-resolving Spell/Trap cases.
- `RAGE OF NEPHTHYS`: the chain rewrite's quoted pronouns should be confirmed in-engine; current implementation has the Rage controller destroy their own visible/hidden `Nephthys` monster.

## Latest Fully Audited Randoms Batch

The latest deep audit covered the 50-card random batch `CARD-00500` through `CARD-00549` and passed Lua syntax, `initial_effect` smoke, DB/message, script-sync, zip, build, and public/dist artifact checks.

Fix applied in that pass:

- `Glitchling Bitron` (`c259247807.lua`): the Deck send for its Quick Effect now happens in operation, not target. It sends the selected `Glitchling` Spell to the GY by effect, only applies the selected activation-effect branch if the send succeeds, and only offers the Corruption Counter follow-up after the activation-effect path applies.

Official Omega references used in that pass:

- Copied activation / activation-from-other-location: `c41418852.lua`, `c18168997.lua`, `c1050355.lua`, `c11881272.lua`.
- Trap activation from hand and negate/disable patterns: `c10045474.lua`, `c15693423.lua`, `c100259003.lua`, `c100245037.lua`.
- Custom Fusion/Extra Deck summon and zone checks: `c15291624.lua`, `c100245006.lua`, `c42166000.lua`.
- Ritual material and `Duel.ReleaseRitualMaterial` patterns: `c101301084.lua`, `c11398951.lua`.
- Top/bottom Deck and random/order handling: `c18658572.lua`, `c67906797.lua`, `c100263006.lua`, `c10321588.lua`, `c10493654.lua`.

Cards still needing in-engine/ruling confirmation:

- `Glitchling Bitron`: manually applies the current two Glitchling Spell activation branches (`Data-Transfert`, `Corruption`) after a successful Deck-to-GY send. Confirm behavior if future `Glitchling` Spell/Trap activation effects are added.
- `Glitchling` Ritual/Pendulum suite: custom counter-as-Ritual-material, multi-Ritual Pendulum Summon, and Pendulum Summon emulation should be tested in Omega UI.
- `Charmelia` suite: Deck/GY activation of Continuous Spell/Trap cards follows official `MoveToField`/`RaiseEvent` patterns, but the Chain UI and optional activation effects should be tested in-engine.
- `Harpie Phoenix Formation`, `Mirage Formation Dragon`, `Heart of the Cards`, `Aurelion Divine Illumination`, and the `Wyvernal` Fusion helpers use unusual delayed, top/bottom Deck, Extra Deck self-summon, or chain-material flows that need duel-state testing.

## Prior Fully Audited Batch

That prior scripting/audit pass generated these 10 cards, re-audited the prior 10 Guidance/Prophecy/Stellaer/Saria cards, and passed Lua syntax, `initial_effect` smoke, DB/message, script-sync, zip, build, and public/dist artifact checks:

- `c245970073.lua` - A Stainless Story
- `c259686203.lua` - Mylo, the Domesticated
- `c259135917.lua` - Nuwa, the Domesticated
- `c259911246.lua` - Mylo in the Wild
- `c259796760.lua` - Nuwa in the Wild
- `c217713649.lua` - ONIBI
- `c214371067.lua` - ENRA
- `c229399508.lua` - KOKESHISA
- `c228033609.lua` - SHISHI
- `c247378501.lua` - MURAMASA

Last fixes applied in that pass:

- `Branching to Guidance`: moved reveal/selection out of the target function and into operation; GY target now copies live stats/code after resolution rechecks instead of cached labels.
- `Stellaer of the Swamp`: destroy operation now rechecks full target legality at resolution; self-destroy/draw target now checks `Duel.IsPlayerCanDraw`.
- `Sustained Succubus Saria`: attack-trigger operation now stops if no field card can be selected at resolution; optional GY shuffle and ATK-zero prompts now use distinct DB strings.
- Repeat deep audit: `ENRA` and `KOKESHISA` Tribute-trigger operations now recheck that their targets are still face-up Spirit monsters at resolution.
- Repeat deep audit: `KOKESHISA` can only pay its Tribute cost with a Spirit monster that opens a Monster Zone for the immediate Normal Summon.
- Repeat deep audit: `MURAMASA`'s opponent-monster Tribute Summon now follows the official `Duel.CheckTribute`/`Duel.SelectTribute` summon-procedure pattern.
- Added standalone Lua scripts and DB `aux.Stringid` message overrides for CARD-0101 through CARD-0110.
- `A Stainless Story`: implemented explicit copied Summon-effect branches for current non-cost Stain Summon triggers (`Bria`, `Dante`, `Feness`, `Rollo`, `Silas`) and kept the GY draw effect separate with `aux.bfgcost`.
- `Mylo`/`Nuwa`: followed local Domestica summon-restriction/search patterns and used `aux.NecroValleyFilter` for GY self-shuffle effects.
- `Mylo in the Wild`/`Nuwa in the Wild`: followed local `Pip/Tove in the Wild` Fusion patterns; `Mylo` uses a delayed group to restore Set monsters at End Phase, and `Nuwa` follows official disable/ATK-zero patterns.
- `ONIBI`, `ENRA`, `KOKESHISA`, `SHISHI`, `MURAMASA`: followed official Spirit return/cannot-Special-Summon, immediate Normal Summon, release trigger, redirect, Equip, and alternate Tribute Summon patterns.
- Synchronized public scripts, installed root Omega scripts, script zips, public/installed DBs, DB zip, and `dist`.

Cards still needing in-engine/ruling confirmation:

- `A Stainless Story`: copied monster Summon-trigger behavior is nonstandard for a Quick-Play Spell. The script supports current no-cost Stain branches only; confirm whether costed or future Stain Summon triggers should be copyable.
- `Mylo in the Wild`: "face-down Defense Position until the end of this turn" is implemented with a delayed End Phase face-up Defense restoration. Confirm intended flip/position behavior and Flip-trigger interactions.
- `MURAMASA`: opponent-Special-Summoned monster Tribute Summon is implemented with a scoped single-card `EFFECT_SUMMON_PROC`; confirm Omega summon UI and material handling.
- `ONIBI`, `ENRA`, and `KOKESHISA`: immediate Normal Summon chains and hand/field release flows should be confirmed in-engine, especially shared once-per-turn wording on `ENRA` and `KOKESHISA`.
- `Mylo`/`Nuwa`: Battle Phase lingering field effects should be confirmed for Fairy monsters that appear after the GY effect resolves.

## Prior Fully Audited Guidance/Prophecy Batch

The prior per-card audit was run on these 10 cards and passed Lua syntax, `initial_effect` smoke, DB/message, script-sync, zip, build, and public/dist artifact checks:

- `c222257685.lua` - Branching to Guidance
- `c215853847.lua` - Rigel the Thousand-Armed
- `c229327103.lua` - Prophecy of Infernos
- `c251058567.lua` - Prophecy of Waterfalls
- `c223558392.lua` - Prophecy of Boulders
- `c223592011.lua` - Prophecy of Storms
- `c244920555.lua` - Prophecy of Rays
- `c243920845.lua` - Prophecy of Shadows
- `c259586445.lua` - Stellaer of the Swamp
- `c219419648.lua` - Sustained Succubus Saria

Last fixes applied in that batch:

- Added standalone Lua scripts and DB `aux.Stringid` message overrides for all 10 cards.
- Added the `Guidance Token` helper row (`222257686`) for `Branching to Guidance`; the script copies the revealed/targeted monster's Race, Attribute, Level, ATK, DEF, and adds its code to the Token.
- `Rigel the Thousand-Armed`: Link Summon uses the official Link procedure for 2+ Effect Monsters; its activation lock, no-battle-damage clause, attack-all effect, and other-monster attack lock are scripted as continuous/turn effects.
- The six `Prophecy` monsters return a matching Attribute monster Special Summoned from the Extra Deck before Special Summoning themselves, and only continue to the mandatory search after the Special Summon succeeds.
- `Stellaer of the Swamp`: one-material Xyz Summon uses the official `aux.AddXyzProcedure` alternate-material hook; detach/destroy and self-destroy/draw are split into cost/target/operation paths.
- `Sustained Succubus Saria`: Fusion materials, indestructibility, reflected battle damage, Deck/GY/banishment search, and Battle Phase shuffle effect are scripted with `aux.NecroValleyFilter` for GY/banishment access.
- Synchronized public scripts, installed root Omega scripts, script zips, public/installed DBs, DB zip, and `dist`.

Cards still needing in-engine/ruling confirmation:

- `Branching to Guidance`: `EFFECT_ADD_CODE` exists in Omega constants but no exact official token-name-add sample was found; confirm the Token is treated as having the copied name in addition to `Guidance Token`.
- The six `Prophecy` monsters: Omega exposes no official `ListsAttribute` helper in the local corpus, so "lists `ATTRIBUTE` in its text" is represented with explicit CCG passcode tables generated from current `cards.json` text. Confirm whether official non-CCG Spell/Trap text should also be searchable.
- `Prophecy of Boulders`: the current CCG text pool has no Spell/Trap that lists `EARTH`, so the mandatory search gate means this effect cannot legally activate in a CCG-only pool until such a card exists or a generic text-listing helper is available.
- `Rigel the Thousand-Armed`: non-Link materials contribute 0 to the "combined Link Rating" ATK gain because only Link Monsters have a Link Rating; confirm intended handling in-engine.
- `Stellaer of the Swamp`: alternate one-material Xyz Summon follows the official alternate-material procedure, but the summon UI should be confirmed when the player controls no Xyz Monsters.
- `Sustained Succubus Saria`: confirm the reflected battle damage and the optional "make this card's ATK become 0" prompt order in an actual battle.

## Prior Fully Audited Domestica Batch

The prior per-card audit was run on these 11 cards and passed Lua syntax, `initial_effect` smoke, DB/message, script-sync, zip, build, and public/dist artifact checks:

- `c259377794.lua` - Pip, the Domesticated
- `c259737127.lua` - Tove, the Domesticated
- `c259264881.lua` - Domestica Praerie
- `c259337739.lua` - Domestica Anjelie
- `c259245149.lua` - Domestica Lunalie
- `c259201342.lua` - Domestication
- `c259265448.lua` - Domestic Underworld
- `c259668626.lua` - Domestica in the Underworld
- `c259410628.lua` - Domestica in the Wild
- `c259670933.lua` - Domestica Kyrie
- `c259394179.lua` - Pip in the Wild

Last fixes applied in that batch:

- Added standalone Lua scripts and DB `aux.Stringid` message overrides for the ten new Domestica cards; refreshed `Pip, the Domesticated`.
- `Pip, the Domesticated`: search confirmation now only happens after the selected card was actually added to hand.
- `Domestica Lunalie`: GY target now checks target legality and `aux.NecroValleyFilter` at target and resolution.
- `Domestication`: Extra Deck send follows the official non-target Extra Deck send pattern instead of requiring `IsRelateToEffect` on the selected Extra Deck card.
- `Domestic Underworld`: GY shuffle target now respects `aux.NecroValleyFilter`, and both field-trigger operations re-check handler relation.
- `Domestica in the Underworld`: draw/send field-trigger operation now re-checks handler relation.
- `Domestica in the Wild`: Fusion material immunity check now passes the effect object, not the Fusion Monster card; the field operation re-checks handler relation.
- `Domestica Kyrie`: registered the Fusion material rule with `aux.AddFusionProcFunRep` so its custom `CheckFusionMaterial` summon procedure has valid material requirements.
- Extra bug pass: `Domestica Praerie`, `Domestica Anjelie`, and `Domestica Lunalie` now set the official extra-summon value `0x1` on their additional Normal Summon/Set effects.
- Extra bug pass: `Domestica Kyrie` no longer uses undefined `CATEGORY_TOFIELD`; Omega's `constant.lua` has no such category.
- Synchronized public scripts, installed root Omega scripts, script zips, public/installed DBs, DB zip, and `dist`.

Cards still needing in-engine/ruling confirmation:

- `Domestica Praerie`, `Domestica Anjelie`, and `Domestica Lunalie`: the Battle Phase summon restriction and one-monster Tribute Summon exception are implemented with available summon-condition APIs; confirm Tribute Summon UI behavior in Omega.
- `Domestica in the Underworld` and `Domestica in the Wild`: using a card in hand as Tribute for a NATURE Normal Summon is represented with `EFFECT_EXTRA_RELEASE` from `LOCATION_HAND`; no direct official hand-range analog was found in the Omega corpus.
- `Domestica Kyrie`: custom GY-material Extra Deck summon follows official contact/Fusion material selection patterns, but the no-monsters condition and GY-to-Deck material UI should be confirmed in-engine.
- `Domestication`: generic listed Fusion Material handling uses exact material codes plus a specific fallback for `Pip in the Wild`'s generic `"Domestica" Fairy` material. Confirm future generic Beast/Winged Beast Fusions if more are added.

## Prior Fully Audited NiuHao/Sacred Treasure Batch

The prior per-card audit was run on these 10 cards and passed Lua syntax, `initial_effect` smoke, DB/message, script-sync, zip, build, and public/dist artifact checks:

- `c229499914.lua` - Sacred Treasure - Chunyin
- `c246421842.lua` - Sacred Treasure - Huangjin
- `c218600459.lua` - NiuHao - Bauba
- `c235789995.lua` - NiuHao - Hikam
- `c232232676.lua` - NiuHao - Oro
- `c227043533.lua` - NiuHao - LokaEO
- `c215629896.lua` - NiuHao - Zaoka
- `c231825514.lua` - NiuHao - Koai
- `c250556612.lua` - NiuHao - Zao
- `c259377794.lua` - Pip, the Domesticated

Last fixes applied in that batch:

- Added standalone Lua scripts and DB `aux.Stringid` message overrides for all 10 cards.
- `NiuHao - LokaEO`: changed the immediate Xyz Summon operation to the official Omega `Duel.XyzSummon(tp,xyz,mat)` call shape after selecting/checking the material group.
- `NiuHao - Koai`: changed target resolution to the official `Duel.GetChainInfo(0,CHAININFO_TARGET_CARDS):Filter(Card.IsRelateToEffect,nil,e)` pattern instead of the non-corpus `Duel.GetTargetCards(e)` helper.
- Synchronized public scripts, installed root Omega scripts, script zips, public/installed DBs, DB zip, and `dist`.

Cards still needing in-engine/ruling confirmation:

- `NiuHao - Zao`: applies the known Sacred Treasure activation branches directly after banishing two Sacred Treasure Spells, rather than using a generic copied-activation `CheckActivateEffect` target snapshot. Confirm in-engine order prompts and whether the original Spell activation condition must be checked only at activation or again at resolution.
- `Sacred Treasure - Bojin`, `Sacred Treasure - Chunyin`, and `Sacred Treasure - Huangjin`: current "this card and another Sacred Treasure card is banished" trigger requires both cards to be banished in the same event. Confirm if the intended ruling also triggers when another Sacred Treasure was already banished.
- `NiuHao - LokaEO`: immediate Xyz Summon with a variable 2+ material subgroup including itself follows official Xyz group-check patterns, but should be confirmed in-engine for the material-selection UI.

## Prior Fully Audited Frute/Sacred Treasure Batch

The prior per-card audit was run on these 10 cards and passed Lua syntax, `initial_effect` smoke, DB/message, script-sync, zip, build, and public/dist artifact checks:

- `c220916791.lua` - The White Frute
- `c246830897.lua` - Fruteonia
- `c216140411.lua` - Fruteopia
- `c247458749.lua` - Fruteaching
- `c256930605.lua` - Fruteification
- `c236179696.lua` - The Flying Frute
- `c213266433.lua` - The Hanging Frute
- `c248290754.lua` - The Fruteful Moon
- `c213615627.lua` - The Fruted Warrior
- `c236542835.lua` - Sacred Treasure - Bojin

Remaining Frute/Bojin in-engine/ruling confirmations:

- `The Hanging Frute`: "attack all face-down Defense Position monsters" is represented through official-style attack-announce extra attacks plus target restriction; Omega has no exact filtered attack-all primitive.
- `The Hanging Frute`: "for the rest of this turn, monsters you control are unaffected by effects previously activated in this Chain" is implemented for the current Chain using triggering-effect identity. Extending it cleanly to End Phase may overmatch later activations of the same effect object.

## Prior Fully Audited 19-Card Batch

The prior per-card audit was run on these 19 cards and passed Lua syntax, `initial_effect` smoke, DB/message, script-sync, zip, build, and public/dist artifact checks:

- `c245265629.lua` - Stardrake of Gravitic Coils
- `c241056746.lua` - Reactor Shocker
- `c221321849.lua` - The Condescender
- `c225091736.lua` - Stained Bird Bria
- `c216958556.lua` - Stained Deer Dante
- `c247499445.lua` - Stained Fox Feness
- `c224822244.lua` - Stained Raptor Rollo
- `c259475154.lua` - Stained Solitaire
- `c218685316.lua` - Stargazer of the Stained
- `c244408495.lua` - Stained Scioness Silia
- `c221822671.lua` - Stained Sovereign Silas
- `c256608976.lua` - Stained Silhouette
- `c232449539.lua` - Abstain from Light
- `c248453205.lua` - Shattering Sustained
- `c244790302.lua` - Stained Avatar
- `c247789143.lua` - Stained Sorceress Silphia
- `c247580036.lua` - Distained Druid Dragar
- `c217174535.lua` - Stainless Kaleidragon
- `c259365935.lua` - Aetherstorm Zenith Wire-Tailed Sypharion

Last fixes applied in that batch:

- Added standalone Lua scripts and DB `aux.Stringid` message overrides for the ten newer Stain/Stainless cards.
- Synchronized public scripts, installed root Omega scripts, script zips, public/installed DB checks, and `dist`.
- `Stardrake of Gravitic Coils`: added the official `EFFECT_FLAG_CANNOT_DISABLE+EFFECT_FLAG_UNCOPYABLE` summon-procedure property.
- `Reactor Shocker`: bottom-of-Deck follow-up now checks for an actually deckable hand card before prompting.
- `The Condescender`: implemented Level/Rank reduction; Omega's official constants do not expose a Link Rating update effect, so that part still needs manual ruling/in-engine support.
- `Stained Raptor Rollo`: battle effect now re-checks handler relation and uses the official top-of-Deck pattern: `SendtoDeck(...,SEQ_DECKSHUFFLE)`, `ShuffleDeck`, then `MoveSequence(...,SEQ_DECKTOP)`.
- `Stained Sovereign Silas`: GY self-shuffle now respects `aux.NecroValleyFilter(Card.IsAbleToDeck)` at targeting and resolution.
- `Abstain from Light`: the "your Stain monster was shuffled" tracker now flags only the moved card's previous controller, not both players.
- `Stainless Kaleidragon`: negate condition now follows the non-opponent-only card text while preserving the Stain-only activation oath for your own chain links.
- Public and installed DB rows/messages already matched `cards.json`; no DB message edits were needed in the final audit pass.

Cards still needing in-engine/ruling confirmation:

- `The Condescender`: Link Rating reduction is not implemented because there is no normal Omega Link Rating update constant.
- `Shattering Sustained`: Tributing a face-up monster from the opponent's Deck is nonstandard and is represented by sending it to the GY with `REASON_RELEASE`.
- `Distained Druid Dragar`: same nonstandard opponent-Deck Tribute handling as `Shattering Sustained`.

## Verification Already Passed

Latest completed checks:

- All `277` Lua scripts in `public/CCG Downloads/CCG_Scripts` pass `luac -p`.
- All `277` installed custom CCG script counterparts in `C:\Program Files (x86)\YGO Omega\YGO Omega_Data\Files\Scripts` pass `luac -p`.
- All `277` Lua scripts in `dist/CCG Downloads/CCG_Scripts` pass `luac -p`.
- The latest batch covered CARD-0161 through CARD-0170 and those 10 in-scope scripts pass per-card checks for:
  - Lua syntax
  - `initial_effect` smoke loading
  - public DB row
  - installed Omega DB row
  - `src/data/cards.json` name/description match
  - `cards.json` passcode and `CCG_v1_id_map.json` mapping (`src/data/ccg-omega-ids.json` is absent in this checkout)
  - type/setcode/stats metadata
  - `aux.Stringid` message index accuracy
  - script presence in `CCG_Scripts.zip`
  - public script, zip entry, and installed Omega script hash match
  - static effect-pattern checks
- All public script files hash-match `CCG_Scripts.zip`, the installed Omega script folder, and `dist`.
- The audited scripts have no `require`, `dofile`, `loadfile`, or subfile loading patterns.
- Public and installed `CCG_v1.db` files hash-match.
- `CCG_Database.zip` contains the same `CCG_v1.db` as the public DB.
- `public` and `dist` `CCG Downloads` artifacts hash-match.
- `npm run build` passes.

Known non-fatal build warnings:

- Browserslist/caniuse-lite data is old.
- Vite warns that the main chunk is larger than 500 kB after minification.

## Useful Commands

Full Lua syntax check:

```powershell
$failed = @()
$files = Get-ChildItem 'public/CCG Downloads/CCG_Scripts' -Filter '*.lua'
foreach($file in $files){
  luac -p $file.FullName
  if($LASTEXITCODE -ne 0){ $failed += $file.Name }
}
if($failed.Count){
  $failed | ForEach-Object { Write-Host "FAILED $_" }
  exit 1
}
Write-Host "all lua syntax ok:" $files.Count
```

Rebuild script zip after Lua edits:

```powershell
$scriptZip = 'public/CCG Downloads/CCG_Scripts/CCG_Scripts.zip'
if(Test-Path $scriptZip){ Remove-Item -LiteralPath $scriptZip -Force }
Compress-Archive -Path 'public/CCG Downloads/CCG_Scripts/*.lua' -DestinationPath $scriptZip -CompressionLevel Optimal
```

Sync edited scripts to local Omega install:

```powershell
$script = 'public/CCG Downloads/CCG_Scripts/cCARDID.lua'
$omegaScriptDir = 'C:\Program Files (x86)\YGO Omega\YGO Omega_Data\Files\Scripts'
Copy-Item -LiteralPath $script -Destination $omegaScriptDir -Force
```

Production build:

```powershell
npm run build
```

## Scripting Practices To Preserve

- Search `tmp\omega_scripts` first with `rg` for official cards with similar effects.
- Custom scripts must be standalone. Omega loads root `c<ID>.lua` files directly; do not rely on repo-local subfiles or shared helper modules.
- Use official negate patterns:
  - `Duel.NegateActivation(ev)`
  - check `re:GetHandler():IsRelateToEffect(re)` before destroy when appropriate
  - only draw or continue if the required destroy/send actually happened
- For copied activation effects, follow official `CheckActivateEffect(true,true,true)` and `Duel.ClearOperationInfo(0)` patterns.
- For top-of-Deck placement from Deck, use official `Duel.ShuffleDeck(tp)` then `Duel.MoveSequence(tc,SEQ_DECKTOP)`.
- For GY/banishment access that should respect Necrovalley, use `aux.NecroValleyFilter`.
- Always verify `aux.Stringid(id,n)` usage against DB `texts.str(n+1)`.
- Keep public scripts, installed Omega root scripts, zip contents, public DB, installed DB, and `dist` artifacts in sync before reporting completion.

## Good Next-Step Workflow

For the next card batch:

1. Read exact source text from `src/data/cards.json`.
2. Confirm Omega IDs in `src/data/ccg-omega-ids.json` if present; this checkout currently uses `cards.json` passcodes plus `CCG_v1_id_map.json`.
3. Find official analog scripts in `tmp\omega_scripts`.
4. Create/update `public/CCG Downloads/CCG_Scripts/c<ID>.lua`.
5. Run per-file `luac -p`, then all-script syntax.
6. Sync scripts to local Omega install.
7. Rebuild `CCG_Scripts.zip`.
8. Verify DB rows/messages/types/setcodes/stats in both public and installed Omega DBs.
9. Run `npm run build`.
10. Confirm `public` and `dist` artifact hashes match.

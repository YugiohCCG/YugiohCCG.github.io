# Random Sample Lua Audit - 2026-06-22

Scope:

- Sample seed: `ccg-random-audit-2026-06-22`
- Pool: `217` scripted public CCG Lua files after excluding the two prior 30-card random samples.
- Sample size: `30` cards.
- Evidence checked: current `public/assets/cards.json` text, public Lua, public DB row, dist DB row, installed Omega DB row, public/dist/installed script parity, public/dist zip entries, local custom analogs, and official Omega patterns under `tmp/omega_scripts`.

Implemented fixes:

- `c259377794.lua` - `Pip, the Domesticated`: added Necrovalley legality to the Battle Phase GY self-shuffle target and operation. This now matches sibling `Mylo, the Domesticated` (`public/CCG Downloads/CCG_Scripts/c259686203.lua`), which already gates the same GY self-shuffle with `aux.NecroValleyFilter(Card.IsAbleToDeck)`.
- `c259269688.lua` - `Grayscale Awakening: Nullbind`: excluded Tokens from the optional overlay-material group. This follows the local Grayscale overlay material patterns in `c259097228.lua` and `c259229055.lua`, and official token-exclusion/targetability examples such as `tmp/omega_scripts/c33202303.lua`.
- `c248788543.lua` - `Right Talismandrake Arms - Blaze Sabre`: added `IsCanBeEffectTarget(e)` to the GY equip target filter and rechecked that target at resolution.
- `c255832330.lua` - `Left Talismandrake Arms - Blaze Shield`: added the same targetability and resolution recheck to the GY equip effect.
- `c215034223.lua` - `Talismandrake Arms United`: added targetability to the Fusion monster selected for the Deck equip effect and rechecked that target at resolution.

Additional consistency fixes found while checking the sampled Talismandrake Arms effects:

- `c215921734.lua` - `Left Talismandrake Arms - Obsidian Halberd`: added the same GY equip targetability guard.
- `c238136421.lua` - `Left Talismandrake Arms - Suppressor`: added the same GY equip targetability guard.

Official/reference patterns used:

- Equip target legality: `tmp/omega_scripts/c10613952.lua` uses `IsCanBeEffectTarget(e)`, `CheckEquipTarget`, and then `Duel.Equip`.
- Xyz/material token exclusion: `tmp/omega_scripts/c33202303.lua` excludes Tokens while checking targetability; local Grayscale scripts `c259097228.lua` and `c259229055.lua` exclude Tokens before `Duel.Overlay`.
- GY self-shuffle under Necrovalley: sibling `c259686203.lua` uses `aux.NecroValleyFilter(Card.IsAbleToDeck)` in both target and operation.
- Old `SetCountLimit(1,id+EFFECT_COUNT_CODE_OATH)` forms and exact material-reason checks like `r==REASON_FUSION` / `r==REASON_LINK` are common in the official corpus, so those were not treated as bugs by themselves.

Sample results:

| # | ID | Card | Result | Notes and references |
| ---: | ---: | --- | --- | --- |
| 1 | 259377794 | Pip, the Domesticated | Fixed | Battle Phase GY self-shuffle now has the same Necrovalley guard as `Mylo, the Domesticated` (`c259686203.lua`). |
| 2 | 246216813 | The Red Frute | Static pass | Hand/field Tribute-style custom flow and release trigger match the Frute/Stargazer family implementation. |
| 3 | 236179696 | The Flying Frute | Static pass with custom note | Link procedure using face-down WATER material and hand/field Tribute removal is custom but internally consistent. |
| 4 | 259688676 | Herald of White Light | Static pass | Synchro/Ritual level handling, search trigger, and GY negate/destroy effect follow standard official-style shapes. |
| 5 | 259179054 | Wyvernal Megalopyge | Static pass | Shared chain-reset flag prevents both optional same-chain uses; Fusion procedure and wipe operation pass. |
| 6 | 259466138 | Red-Eyes Gearfried the Iron Knight | Static pass | Link Summon lock registration and five-card GY shuffle/draw sequencing pass. |
| 7 | 259911246 | Mylo in the Wild | Static pass with custom note | Temporary face-down-until-End-Phase handling is custom but coherent and isolated. |
| 8 | 229499914 | Sacred Treasure - Chunyin | Static pass | Different-code Deck banish uses `aux.dncheck`; banish trigger and target recovery pass. |
| 9 | 259655976 | Stellaer of Lighting | Static pass | No hard once-per-turn text was present, so lack of count limit on the quick effect is intentional. |
| 10 | 248788543 | Right Talismandrake Arms - Blaze Sabre | Fixed | GY equip target now requires targetability, matching official equip target filters such as `tmp/omega_scripts/c10613952.lua`. |
| 11 | 259614765 | Encyclopedia of Eclipse | Static pass | Old oath count-limit form is official-supported; no script defect found. |
| 12 | 221321849 | The Condescender | Pass with known note | Level/Rank reduction is implemented; Link Rating reduction still needs manual Omega support/ruling. |
| 13 | 218685316 | Stargazer of the Stained | Static pass with custom note | Opponent face-up Deck summon and hand Tribute mechanics remain custom but match local Stained/Frute style. |
| 14 | 259269688 | Grayscale Awakening: Nullbind | Fixed | Non-LIGHT targets added as Xyz material now exclude Tokens before `Duel.Overlay`. |
| 15 | 234729347 | The Beginning | Static pass | Activation/summon restriction and current script shape pass. |
| 16 | 259934756 | Jelly Lass of the Grand Blue | Static pass | Fusion checks and GY revive use Necrovalley filtering. |
| 17 | 214552846 | Eldora, the Intergalactic Empire | Pass with source-text note | Script implements the apparent "at least 12" matching-criterion text; source wording still deserves ruling review. |
| 18 | 255832330 | Left Talismandrake Arms - Blaze Shield | Fixed | GY equip targetability now matches official equip target-filter practice; leave-field replacement remains the existing Omega representation. |
| 19 | 215034223 | Talismandrake Arms United | Fixed | Deck equip target now requires a targetable Fusion monster and rechecks the selected target at resolution. |
| 20 | 254065048 | Polemistis Gia Ataxia | Static pass | Fusion-like summon, continuous stat gain, attack-all, and search/send operation pass. |
| 21 | 235448944 | Pawn of Aldrez | Static pass | Material trigger using `r==REASON_LINK` is consistent with official corpus examples. |
| 22 | 259898110 | Nemleria Dream Creator - Veilleuse | Static pass | Summon/search/return modes and Nemleria locks use official-like count keys and pass. |
| 23 | 246421842 | Sacred Treasure - Huangjin | Static pass | Destroy/remove mode choice and draw trigger pass; GY access uses Necrovalley filtering. |
| 24 | 213615627 | The Fruted Warrior | Static pass with custom note | Tribute-from-hand/field ATK gain is custom but matches the Frute family pattern. |
| 25 | 259273851 | Manual of Eclipse | Static pass | Opponent GY banish/draw and End Phase return of opponent's face-up banished monsters match text. |
| 26 | 215853847 | Rigel the Thousand-Armed | Static pass | Link procedure, protection, activation lock, ATK gain, attack-all, and opponent attack lock pass. |
| 27 | 222257685 | Branching to Guidance | Static pass with note | Token copy effects for name/race/attribute/level/stats are static-clean; name-add behavior should still be watched in-engine. |
| 28 | 259410628 | Domestica in the Wild | Static pass with custom note | Optional hand-as-Tribute and GY Fusion-like summon use the established Domestica custom pattern. |
| 29 | 245935439 | Talismandrake Sear | Static pass | Pendulum Fusion Summon and `r==REASON_FUSION` material trigger match official-style material reason checks. |
| 30 | 259290896 | Dominus Sentinel | Static pass | Trap activation negate/destroy and rest-of-duel activation lock pass. |

Verification:

- `luac -p` passed for all `277` public scripts, all `277` dist scripts, and all `277` installed Omega scripts.
- Lightweight `initial_effect` smoke loading passed for all 30 sampled scripts.
- Public, dist, and installed DB rows matched for all 30 sampled IDs.
- Full script hash parity passed for all `277` scripts across public scripts, dist scripts, installed Omega scripts, public `CCG_Scripts.zip`, and dist `CCG_Scripts.zip`.
- `npm run build` passed. Vite still reports the existing large-chunk warning.

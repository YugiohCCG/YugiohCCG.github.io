# Random Sample Lua Audit - 2026-06-21 Second Sample

Scope:

- Sample seed: `ccg-random-audit-2026-06-21-second`
- Pool: `247` scripted public CCG Lua files after excluding the prior 30-card sample from `docs/random-sample-lua-audit-2026-06-21.md`.
- Evidence checked: current `public/assets/cards.json` text, public Lua, public DB row, installed Omega DB row, public/dist/installed script parity, public/dist zip entries, and official Omega patterns under `tmp/omega_scripts`.

Implemented fix:

- `c259229055.lua` - `Graydeux, the Eternal Grayscale Entity`: added a replacement-effect target legality check and official target clearing before `Duel.ChangeChainOperation`. The replacement now follows the official chain-rewrite shape in `tmp/omega_scripts/fixed-scripts/Genesys/c80453041.lua` and `tmp/omega_scripts/fixed-scripts/c62318994.lua`, and it cannot be activated unless a valid `Grayscale` Xyz Monster and a legal non-Token monster to attach exist. The replacement operation now selects only `Grayscale` Xyz Monsters that can actually receive a monster.

Sample results:

| # | ID | Card | Result | Official/reference patterns checked |
| ---: | ---: | --- | --- | --- |
| 1 | 216532402 | Sacred Feather of Nephthys | Static pass with custom note | Ritual material and face-up S/T placement checked against official ritual-material handling and `Duel.MoveToField` examples such as `fixed-scripts/c26700718.lua`; Deck "Tribute" is represented as custom Ritual material sent to the GY because Deck cards cannot be Tributed normally. |
| 2 | 216620496 | Remembrance of the Melody | Static pass | Shared "only 1 effect" count key and banished S/T targeting pass; GY/banishment access uses `aux.NecroValleyFilter` consistently. |
| 3 | 251058567 | Prophecy of Waterfalls | Static pass | Returning an Extra Deck-summoned WATER monster uses `Duel.GetMZoneCount(tp,c)` and Extra Deck return gating; generated WATER-list search table matches current card text intent. |
| 4 | 256608976 | Stained Silhouette | Static pass with custom note | Face-up opponent Deck insertion remains a custom mechanic using `GLOBALFLAG_DECK_REVERSE_CHECK`; copy-effect shape checked against standard `EFFECT_CHANGE_CODE` / `CopyEffect` patterns. |
| 5 | 222676270 | Frozen Girl & Blood Moon | Static pass with coverage note | Hand-trap category checks compared with official `Ash Blossom` (`tmp/omega_scripts/c14558127.lua`) and `Ghost Belle` (`tmp/omega_scripts/c73642296.lua`); broad `CATEGORY_GRAVE_ACTION` style is official-supported, but exact custom category coverage remains an in-engine behavior to watch. |
| 6 | 210506870 | Talismandrake Heat | Static pass | Pendulum Summon lock uses `EFFECT_CANNOT_SPECIAL_SUMMON`; Fusion Summon flow checked against official fusion spell/procedure examples such as `fixed-scripts/fusion/c48130397.lua`. |
| 7 | 259940722 | Virtua Leet | Static pass with source-text note | Fusion procedure, threshold effects, and once-face-up flagging pass; current generated text is malformed (`/EFFECTI`, `0`, `y:`, `O V`, `5:`), but the script implements the apparent 2/3/4/5-material thresholds coherently. |
| 8 | 228033609 | Shishi | Static pass | Spirit return and no-Special-Summon restriction use `aux.EnableSpiritReturn` / `EFFECT_SPSUMMON_CONDITION`; delayed leave-field redirect shape passes. |
| 9 | 214371067 | Enra | Static pass | Both optional effects intentionally share one count key, matching "You can only use the previous effects ... once per turn"; Spirit summon chaining and battle indestructibility pass. |
| 10 | 259229055 | Graydeux, the Eternal Grayscale Entity | Fixed | Xyz detach cost checked against official `CheckRemoveOverlayCard` / `RemoveOverlayCard` examples such as `fixed-scripts/beta/c101208048.lua`; chain rewrite fixed to match `Genesys/c80453041.lua` and `c62318994.lua`. |
| 11 | 259718504 | Tove in the Wild | Static pass | Contact/Fusion identity, no-other-monster condition, mass S/T return exclusion, and GY return-to-Extra/add/send sequencing pass. |
| 12 | 259245496 | Graydimm, the Grayscale Shadow | Static pass | Detach costs, target legality, empty target clearing, and `ChangeChainOperation` already match the official chain-rewrite pattern used by `Genesys/c80453041.lua` and `c62318994.lua`. |
| 13 | 259072906 | Glitchling Mage | Static pass with custom note | Ritual/Pendulum custom selection, face-up Extra Deck Ritual Summon, and rest-of-turn summon lock pass static checks; because it is highly custom, the multi-Ritual Pendulum effect remains worth in-engine testing. |
| 14 | 259475154 | Stained Solitaire | Static pass with custom note | Face-up opponent Deck insertion follows the local Stain mechanic; search from Deck/GY/banishment uses Necrovalley filtering for GY access. |
| 15 | 226903348 | Stellaer of the Sea | Static pass | Self-Special Summon condition and post-summon WATER prohibition match text; detach trigger from `LOCATION_OVERLAY` and leave-field banish redirect pass. |
| 16 | 235051048 | Ursarctic Octantis | Static pass | Ursarctic replacement markers checked against official `tmp/omega_scripts/c16471775.lua`, `tmp/omega_scripts/c89264428.lua`, and `fixed-scripts/c89771240.lua`; custom sibling scripts `c218837030.lua` and `c245378354.lua` use the same replacement-cost consumption pattern. |
| 17 | 259366281 | Phlogiston's Roar | Static pass | Shared count key correctly enforces "only use 1 effect"; same-turn trap activation uses `EFFECT_TRAP_ACT_IN_SET_TURN`; GY Set redirect-to-banish passes. |
| 18 | 259072169 | Mirage Formation Dragon | Static pass | Extra Deck reveal/special summon, material attach, Set different named Harpie S/T, and detach bounce/destroy modes checked against official overlay and detach patterns. |
| 19 | 259363148 | Gladiator Beast Satyrius | Static pass | Contact Fusion and end-Battle-Phase return match official Gladiator Beast patterns in `fixed-scripts/Gladiator-Beast/c2067935.lua`, `c33652635.lua`, and related scripts. |
| 20 | 217332244 | To Proto Psychi | Static pass | Self Special Summon with `SUMMON_VALUE_SELF`, LP payment options, Token Tribute cost, and banished-from-field recovery pass; exact "any amount of LP" UI remains 100-LP plus maximum-payable granularity. |
| 21 | 259264881 | Domestica Praerie | Static pass | Battle Phase summon exception, additional Normal Summon/Set, self-Tribute search/send sequencing, and Level 5 tribute restriction pass. |
| 22 | 232232676 | Niuhao - Oro | Static pass | GY/banishment chain-location check uses `CHAININFO_TRIGGERING_LOCATION`; delayed next-Standby self-summon uses flag/turn-count tracking. |
| 23 | 259670933 | Domestica Kyrie | Static pass | GY-material Fusion-like Special Summon, no-monster gate, `SetSPSummonOnce`, Field Spell activation from Deck/GY, and "was Tributed this turn" flag pass. |
| 24 | 259069729 | Eclipse Observer Nora | Static pass | Normal/Special summon mill and opponent simultaneous draw trigger pass; Observer card list and set checks match current text intent. |
| 25 | 217700538 | Aldrez Blitz | Static pass | GY/banishment revive target, optional Token summon, and GY Set trigger on Xyz Summon pass; GY access uses Necrovalley filtering. |
| 26 | 259686203 | Mylo, the Domesticated | Static pass | No-monster summon restriction, Fairy search, Battle Phase GY shuffle, and Fairy immunity registration pass. |
| 27 | 259337739 | Domestica Anjelie | Static pass | Same summon-restriction helper as Praerie; Spell/Trap search plus hand send sequencing pass. |
| 28 | 259927462 | Glitchling Octron | Static pass | Link procedure, add up to 2 from GY/banishment/face-up Extra Deck, and Corruption Counter placement pass static checks. |
| 29 | 225091736 | Stained Bird Bria | Static pass with custom note | Face-up opponent Deck shuffle remains custom; bottom-Deck/add choice and self-shuffle after successful resolution pass. |
| 30 | 259943152 | A.I.P Lab | Static pass | Optional activation summon, Beast-effect ATK trigger, and level increase/decrease target operation pass. |

Verification:

- `luac -p` passed for all `277` public scripts, all `277` dist scripts, and all `277` installed Omega scripts.
- Lightweight `initial_effect` smoke loading passed for all 30 sampled scripts.
- Public, dist, and installed DB rows matched for all 30 sampled IDs.
- All 30 sampled scripts hash-match across public scripts, dist scripts, installed Omega scripts, and public/dist `CCG_Scripts.zip` entries.
- `c259229055.lua` hash-match after the fix:
  - public/dist/installed script hash: `9EAB2BF667070059C94AB6413B9A8A6F15D1516E19F7663295AB186147A61E0E`
  - public/dist script zip hash: `4E4F7B9BC914F2D9D1C4435CD559C5A2293901C0D2E85E43BF76931D7556EAA6`
- `npm run build` passed. Vite still reports the existing large-chunk warning.

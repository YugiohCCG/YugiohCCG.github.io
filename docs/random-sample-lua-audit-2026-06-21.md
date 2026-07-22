# Random Sample Lua Audit - 2026-06-21

Scope:

- Sample seed: `ccg-random-audit-2026-06-21`
- Pool: `277` scripted public CCG Lua files matching `src/data/cards.json` passcodes.
- Evidence checked: `cards.json` text, public Lua, public DB row, installed Omega DB row, installed/dist/public script parity, and official Omega patterns under `tmp/omega_scripts/fixed-scripts`.

Implemented fixes:

- `c259624110.lua` - `Grayterror, the Grayscale Beast`: added a target legality check before `Duel.ChangeChainOperation`. The replacement effect now follows the official chain-rewrite shape from `tmp/omega_scripts/fixed-scripts/Genesys/c80453041.lua` / `tmp/omega_scripts/fixed-scripts/c62318994.lua` and cannot be activated unless the replacement Special Summon can plausibly resolve. The check accounts for the tribute cost opening a monster zone.
- `c244790302.lua` - `Stained Avatar`: added `not c:IsReason(REASON_REPLACE)` to the destruction replacement filter, matching official replacement guards in `tmp/omega_scripts/fixed-scripts/26PP/c34041788.lua`, `tmp/omega_scripts/fixed-scripts/fusion/c14088859.lua`, and `tmp/omega_scripts/fixed-scripts/c71100270.lua`.

Sample results:

| # | ID | Card | Result | Official/reference patterns checked |
| ---: | ---: | --- | --- | --- |
| 1 | 259624110 | Grayterror, the Grayscale Beast | Fixed | `ChangeChainOperation` / empty target group from `Genesys/c80453041.lua` and `c62318994.lua`; added activation legality for the mandatory replacement summon. |
| 2 | 259431066 | Wyvernal Myops | Static pass | Self banish cost and temporary negate match `aux.bfgcost` plus `NegateRelatedChain` / `EFFECT_DISABLE_TRAPMONSTER` style from `beta/c101205079.lua`. |
| 3 | 244790302 | Stained Avatar | Fixed | Fusion procedure, copied activation with `Duel.ClearOperationInfo(0)`, and destroy replacement checked against `26PP/c34041788.lua`, `fusion/c14088859.lua`, `c71100270.lua`. |
| 4 | 247789143 | Stained Sorceress Silphia | Static pass with custom note | Temporary banish/return follows `Duel.ReturnToField` patterns from `MasterDuel/c4993187.lua` and `Targeting/c29301450.lua`; face-up opponent Deck insertion remains a custom mechanic using `GLOBALFLAG_DECK_REVERSE_CHECK`. |
| 5 | 245378354 | Ursarctic Mikailus | Static pass | Ursarctic replacement/lock handling checked against `c89771240.lua`; activation-turn Set handling matches `EFFECT_QP_ACT_IN_SET_TURN` / `EFFECT_TRAP_ACT_IN_SET_TURN` patterns. |
| 6 | 259489283 | Charmelia Fairy Kyubey | Static pass | Monster-to-S/T-zone continuous spell handling matches `Targeting/c48452496.lua` and `c26700718.lua`. |
| 7 | 259226799 | Charmelia Beast | Static pass | `EFFECT_INDESTRUCTABLE_COUNT` and targeting protection checked against `fusion/c15543940.lua`, `equip/c39568067.lua`, and `Targeting/c23776077.lua`. |
| 8 | 259429721 | Champion of the Grand Blue | Static pass | Equip target/limit and column destruction checked against equip examples such as `c3897065.lua`, `c4252828.lua`, and `equip/c14466224.lua`. |
| 9 | 259724129 | Graylock, the Sorcerer of Grayscale | Static pass | Xyz/Link material restriction pattern checked against `c101208009.lua` and `mv2pz/c30095833.lua`; GY trigger cost is correctly paid during operation for "discard, and if you do". |
| 10 | 257549955 | A Stellaer Is Reborn | Static pass | GY destruction replacement already had the official `not REASON_REPLACE` guard matching `fusion/c14088859.lua` / `26PP/c34041788.lua`. |
| 11 | 220916791 | The White Frute | Static pass | Tribute cost, search reveal, and face-down Defense summon gates checked against `POS_FACEDOWN_DEFENSE` / `EFFECT_DIVINE_LIGHT` examples such as `c101304020.lua` and `c81237046.lua`. |
| 12 | 218600459 | Niuhao - Bauba | Static pass | Chain-location check matches official `CHAININFO_TRIGGERING_LOCATION` usage in `c30998403.lua`; delayed banished self-summon uses flag/turn-count pattern. |
| 13 | 221822671 | Stained Sovereign Silas | Static pass with custom note | Targeted activation lock uses `EFFECT_CANNOT_ACTIVATE`; face-up opponent Deck insertion remains a custom mechanic. |
| 14 | 224822244 | Stained Raptor Rollo | Static pass with custom note | GY revive to your field and battle trigger pass; face-up opponent Deck insertion/top-deck sequencing remains custom. |
| 15 | 259607933 | Gladiator Beast Sabearius | Static pass | `aux.gbspcon`, `EVENT_PHASE+PHASE_BATTLE`, summon type `100`, and Gladiator flagging checked against `Gladiator-Beast/c2067935.lua` and related Gladiator Beast scripts. |
| 16 | 241056746 | Reactor Shocker | Static pass | Chain response lock uses `Duel.SetChainLimit(aux.FALSE)` like `TCG-Rulings/c76647998.lua` and `fusion/c48130397.lua`; chain-count logic excludes this card by counting prior chain links plus itself. |
| 17 | 248290754 | The Fruteful Moon | Static pass | Set-from-Deck and same-turn activation flags match official `EFFECT_QP_ACT_IN_SET_TURN` / `EFFECT_TRAP_ACT_IN_SET_TURN` usage; face-down position change gates `EFFECT_DIVINE_LIGHT`. |
| 18 | 259097228 | Zero Mother of the A.I.P Ex | Static pass | Detach cost uses official `CheckRemoveOverlayCard` / `RemoveOverlayCard` shape from `Targeting/c23776077.lua`; attach uses `Duel.Overlay` patterns from official Xyz scripts. |
| 19 | 259531370 | Scarstech Wyvern | Static pass | Chain-link response and ATK/DEF boost use current-chain based calculation; no official exact analog found, but event timing and reset shape are standard. |
| 20 | 259652372 | Eclipse Observer Aaliyah | Static pass | `EVENT_DRAW` group-size check and bottom-deck send checked against official `SEQ_DECKBOTTOM` patterns such as `Targeting/c83827392.lua`. |
| 21 | 259721372 | Eclipse Observatory | Static pass | DB setcode already contains both `0xf2f4` and `0xeb17`, so the "always treated" text is data-backed; negate/banish/draw flow matches standard `NegateRelatedChain` pattern. |
| 22 | 236542835 | Sacred Treasure - Bojin | Static pass with ruling note | Simultaneous banish trigger is represented through `EVENT_REMOVE` group checks. This remains a custom same-event wording to confirm in-engine. |
| 23 | 259883971 | Nemleria Big Eepy | Static pass | Face-down banish cost/effect and Extra Deck reveal/opponent selection match Extra Deck face-down handling patterns; no defect found. |
| 24 | 259135917 | Nuwa, the Domesticated | Static pass | Summon restriction and Battle Phase activation lock match standard `EFFECT_CANNOT_SUMMON`, `EFFECT_SPSUMMON_CONDITION`, and `EFFECT_CANNOT_ACTIVATE` structures. |
| 25 | 244920555 | Prophecy of Rays | Static pass | `Duel.GetMZoneCount(tp,c)` for returning an Extra Deck monster checked against official examples; generated LIGHT-list Spell/Trap table exactly matches current `cards.json`. |
| 26 | 219419648 | Sustained Succubus Saria | Static pass | Battle damage reflection, attack-declare trigger, and optional `EFFECT_SET_ATTACK_FINAL` checked against official attack-declare and ATK-final patterns. |
| 27 | 231892575 | Queen of Aldrez | Static pass | Attack-target and effect-target protection use standard `EFFECT_CANNOT_BE_BATTLE_TARGET` / `EFFECT_CANNOT_BE_EFFECT_TARGET` plus `aux.imval1` / `aux.tgoval` patterns. |
| 28 | 259472680 | Nemleria Dream Devourer - Soleil | Static pass | Extra Deck face-down banish cost and rest-of-turn Special Summon lock match official `EFFECT_CANNOT_SPECIAL_SUMMON` patterns. |
| 29 | 259500899 | Diving Daughters of the Grand Blue | Static pass | Self-revive in Defense Position with `EFFECT_LEAVE_FIELD_REDIRECT` checked against `breakeff/c27565379.lua` and related redirect examples. |
| 30 | 259576196 | The Orcustograph | Static pass | Synchro procedure, banished Orcust revive, and GY negate match standard Synchro plus `aux.bfgcost` / negate patterns. |

Verification:

- `luac -p` passed for all `277` public scripts, all `277` dist scripts, and all `277` installed Omega scripts.
- Lightweight `initial_effect` smoke loading passed for all 30 sampled scripts.
- Public and installed DB rows matched for all 30 sampled IDs.
- `c244790302.lua` and `c259624110.lua` hash-match across public scripts, dist scripts, installed Omega scripts, and public/dist `CCG_Scripts.zip`.

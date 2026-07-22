# Ultimate Lua Audit — Independent Cross-Review B of Lane A

Scope: `src/data/cards.json` ordinals 1–172, from `Stardrake of Gravitic Coils` through `Phantasm Spiral Resurgence`. This is an independent review of the current scripts after Lane A's primary pass. All 172 source texts, 172 standalone files, and 728 static `RegisterEffect` call sites were rechecked against official Omega patterns in `tmp/omega_scripts`.

Verdicts describe the current state. **FIXED** means this cross-pass found and patched a new defect. **NEEDS MANUAL RULING** means the implementation is mechanically coherent but the printed text, custom mechanic, card-pool dependency, or engine UI behavior cannot be proven by static testing.

## Per-card verdicts

| Ord. | Omega ID | Card | Scope rechecked | Cross verdict |
|---:|---:|---|---|---|
| 1 | 245265629 | Stardrake of Gravitic Coils | all printed clauses / 5 registrations | PASS |
| 2 | 241056746 | Reactor Shocker | all printed clauses / 1 registrations | PASS |
| 3 | 221321849 | The Condescender | all printed clauses / 5 registrations | NEEDS MANUAL RULING |
| 4 | 225091736 | Stained Bird Bria | all printed clauses / 3 registrations | PASS |
| 5 | 216958556 | Stained Deer Dante | all printed clauses / 3 registrations | PASS |
| 6 | 247499445 | Stained Fox Feness | all printed clauses / 6 registrations | FIXED / NEEDS MANUAL RULING |
| 7 | 224822244 | Stained Raptor Rollo | all printed clauses / 3 registrations | PASS |
| 8 | 259475154 | Stained Solitaire | all printed clauses / 2 registrations | PASS |
| 9 | 218685316 | Stargazer of the Stained | all printed clauses / 2 registrations | PASS |
| 10 | 244408495 | Stained Scioness Silia | all printed clauses / 2 registrations | PASS |
| 11 | 221822671 | Stained Sovereign Silas | all printed clauses / 5 registrations | PASS |
| 12 | 256608976 | Stained Silhouette | all printed clauses / 4 registrations | NEEDS MANUAL RULING |
| 13 | 232449539 | Abstain from Light | all printed clauses / 5 registrations | NEEDS MANUAL RULING |
| 14 | 248453205 | Shattering Sustained | all printed clauses / 3 registrations | NEEDS MANUAL RULING |
| 15 | 244790302 | Stained Avatar | all printed clauses / 3 registrations | NEEDS MANUAL RULING |
| 16 | 247789143 | Stained Sorceress Silphia | all printed clauses / 7 registrations | PASS |
| 17 | 247580036 | Distained Druid Dragar | all printed clauses / 2 registrations | NEEDS MANUAL RULING |
| 18 | 217174535 | Stainless Kaleidragon | all printed clauses / 4 registrations | PASS |
| 19 | 259365935 | Aetherstorm Zenith Wire-Tailed Sypharion | all printed clauses / 6 registrations | PASS |
| 20 | 224274662 | Armored Nova Mecha-Scaled Xyrion | all printed clauses / 9 registrations | PASS |
| 21 | 224049334 | Solemn Rebirth | all printed clauses / 3 registrations | PASS |
| 22 | 230947464 | Talismandrake Spark | all printed clauses / 5 registrations | PASS |
| 23 | 256928871 | Talismandrake Embers | all printed clauses / 7 registrations | PASS |
| 24 | 210506870 | Talismandrake Heat | all printed clauses / 5 registrations | PASS |
| 25 | 245935439 | Talismandrake Sear | all printed clauses / 3 registrations | PASS |
| 26 | 215034223 | Talismandrake Arms United | all printed clauses / 12 registrations | PASS |
| 27 | 238136421 | Left Talismandrake Arms - Blaze Suppressor | all printed clauses / 7 registrations | PASS |
| 28 | 215921734 | Right Talismandrake Arms - Blaze Halberd | all printed clauses / 7 registrations | PASS |
| 29 | 248788543 | Right Talismandrake Arms - Blaze Sabre | all printed clauses / 10 registrations | PASS |
| 30 | 255832330 | Left Talismandrake Arms - Blaze Shield | all printed clauses / 7 registrations | PASS |
| 31 | 227362839 | Talismandrake Pyre | all printed clauses / 2 registrations | PASS |
| 32 | 253552927 | Talismandrake Cremation | all printed clauses / 12 registrations | PASS |
| 33 | 241706191 | Talismandrake Enkindle | all printed clauses / 12 registrations | PASS |
| 34 | 218142234 | Maiden of Talismandrakes Seraphina | all printed clauses / 15 registrations | PASS |
| 35 | 228926678 | Bishop of Aldrez | all printed clauses / 5 registrations | PASS |
| 36 | 235448944 | Pawn of Aldrez | all printed clauses / 4 registrations | PASS |
| 37 | 231892575 | Queen of Aldrez | all printed clauses / 4 registrations | PASS |
| 38 | 233759343 | Aldrez Battery | all printed clauses / 5 registrations | PASS |
| 39 | 217700538 | Aldrez Blitz | all printed clauses / 2 registrations | PASS |
| 40 | 210923192 | Aldrez Opening | all printed clauses / 9 registrations | PASS |
| 41 | 250508903 | Checked in Aldrez | all printed clauses / 2 registrations | PASS |
| 42 | 213849997 | Checkmate in Aldrez | all printed clauses / 5 registrations | FIXED |
| 43 | 238282350 | Knight of Aldrez | all printed clauses / 3 registrations | PASS |
| 44 | 231129918 | Rook of Aldrez | all printed clauses / 3 registrations | PASS |
| 45 | 252210718 | King of Aldrez | all printed clauses / 3 registrations | PASS |
| 46 | 236158052 | The Blue Frute | all printed clauses / 5 registrations | NEEDS MANUAL RULING |
| 47 | 235607781 | The Yellow Frute | all printed clauses / 2 registrations | NEEDS MANUAL RULING |
| 48 | 246216813 | The Red Frute | all printed clauses / 2 registrations | NEEDS MANUAL RULING |
| 49 | 227745087 | The Green Frute | all printed clauses / 3 registrations | NEEDS MANUAL RULING |
| 50 | 220916791 | The White Frute | all printed clauses / 2 registrations | NEEDS MANUAL RULING |
| 51 | 246830897 | Fruteonia | all printed clauses / 5 registrations | NEEDS MANUAL RULING |
| 52 | 216140411 | Fruteopia | all printed clauses / 5 registrations | NEEDS MANUAL RULING |
| 53 | 247458749 | Fruteaching | all printed clauses / 2 registrations | PASS |
| 54 | 256930605 | Fruteification | all printed clauses / 2 registrations | NEEDS MANUAL RULING |
| 55 | 236179696 | The Flying Frute | all printed clauses / 2 registrations | PASS |
| 56 | 213266433 | The Hanging Frute | all printed clauses / 6 registrations | NEEDS MANUAL RULING |
| 57 | 248290754 | The Fruteful Moon | all printed clauses / 5 registrations | NEEDS MANUAL RULING |
| 58 | 213615627 | The Fruted Warrior | all printed clauses / 4 registrations | PASS |
| 59 | 236542835 | Sacred Treasure - Bojin | all printed clauses / 2 registrations | NEEDS MANUAL RULING |
| 60 | 229499914 | Sacred Treasure - Chunyin | all printed clauses / 2 registrations | NEEDS MANUAL RULING |
| 61 | 246421842 | Sacred Treasure - Huangjin | all printed clauses / 2 registrations | NEEDS MANUAL RULING |
| 62 | 218600459 | Niuhao - Bauba | all printed clauses / 5 registrations | PASS |
| 63 | 235789995 | Niuhao - Hikam | all printed clauses / 5 registrations | PASS |
| 64 | 232232676 | Niuhao - Oro | all printed clauses / 5 registrations | PASS |
| 65 | 227043533 | Niuhao - Lokaeo | all printed clauses / 5 registrations | PASS |
| 66 | 215629896 | Niuhao - Zaoka | all printed clauses / 5 registrations | PASS |
| 67 | 231825514 | Niuhao - Koai | all printed clauses / 3 registrations | PASS |
| 68 | 250556612 | Niuhao - Zao | all printed clauses / 3 registrations | NEEDS MANUAL RULING |
| 69 | 259377794 | Pip, the Domesticated | all printed clauses / 6 registrations | NEEDS MANUAL RULING |
| 70 | 259737127 | Tove, the Domesticated | all printed clauses / 6 registrations | NEEDS MANUAL RULING |
| 71 | 259264881 | Domestica Praerie | all printed clauses / 6 registrations | NEEDS MANUAL RULING |
| 72 | 259337739 | Domestica Anjelie | all printed clauses / 6 registrations | NEEDS MANUAL RULING |
| 73 | 259245149 | Domestica Lunalie | all printed clauses / 6 registrations | NEEDS MANUAL RULING |
| 74 | 259201342 | Domestication | all printed clauses / 2 registrations | PASS |
| 75 | 259265448 | Domestic Underworld | all printed clauses / 4 registrations | FIXED |
| 76 | 259668626 | Domestica in the Underworld | all printed clauses / 5 registrations | NEEDS MANUAL RULING |
| 77 | 259410628 | Domestica in the Wild | all printed clauses / 5 registrations | NEEDS MANUAL RULING |
| 78 | 259670933 | Domestica Kyrie | all printed clauses / 5 registrations | NEEDS MANUAL RULING |
| 79 | 259394179 | Pip in the Wild | all printed clauses / 3 registrations | PASS |
| 80 | 259718504 | Tove in the Wild | all printed clauses / 3 registrations | PASS |
| 81 | 216620496 | Remembrance of the Melody | all printed clauses / 2 registrations | PASS |
| 82 | 255277197 | Chaos Fusion | all printed clauses / 3 registrations | PASS |
| 83 | 245378354 | Ursarctic Mikailus | all printed clauses / 6 registrations | PASS |
| 84 | 218837030 | Ursarctic Megailus | all printed clauses / 5 registrations | PASS |
| 85 | 247831166 | Ursarctic Leoship | all printed clauses / 3 registrations | NEEDS MANUAL RULING |
| 86 | 235051048 | Ursarctic Octantis | all printed clauses / 4 registrations | NEEDS MANUAL RULING |
| 87 | 244921711 | Ursarctic Hextanius | all printed clauses / 4 registrations | NEEDS MANUAL RULING |
| 88 | 249093610 | Ursarctic Nordbar | all printed clauses / 5 registrations | NEEDS MANUAL RULING |
| 89 | 228686743 | Carina of the Eldoran System | all printed clauses / 0 registrations | PASS |
| 90 | 222257685 | Branching to Guidance | all printed clauses / 8 registrations | NEEDS MANUAL RULING |
| 91 | 215853847 | Rigel the Thousand-Armed | all printed clauses / 8 registrations | PASS |
| 92 | 229327103 | Prophecy of Infernos | all printed clauses / 1 registrations | NEEDS MANUAL RULING |
| 93 | 251058567 | Prophecy of Waterfalls | all printed clauses / 1 registrations | NEEDS MANUAL RULING |
| 94 | 223558392 | Prophecy of Boulders | all printed clauses / 1 registrations | NEEDS MANUAL RULING |
| 95 | 223592011 | Prophecy of Storms | all printed clauses / 1 registrations | NEEDS MANUAL RULING |
| 96 | 244920555 | Prophecy of Rays | all printed clauses / 1 registrations | NEEDS MANUAL RULING |
| 97 | 243920845 | Prophecy of Shadows | all printed clauses / 1 registrations | NEEDS MANUAL RULING |
| 98 | 259586445 | Stellaer of the Swamp | all printed clauses / 3 registrations | PASS |
| 99 | 219419648 | Sustained Succubus Saria | all printed clauses / 6 registrations | PASS |
| 100 | 245970073 | A Stainless Story | all printed clauses / 4 registrations | FIXED / NEEDS MANUAL RULING |
| 101 | 259686203 | Mylo, the Domesticated | all printed clauses / 6 registrations | NEEDS MANUAL RULING |
| 102 | 259135917 | Nuwa, the Domesticated | all printed clauses / 6 registrations | NEEDS MANUAL RULING |
| 103 | 259911246 | Mylo in the Wild | all printed clauses / 4 registrations | NEEDS MANUAL RULING |
| 104 | 259796760 | Nuwa in the Wild | all printed clauses / 7 registrations | PASS |
| 105 | 217713649 | Onibi | all printed clauses / 2 registrations | NEEDS MANUAL RULING |
| 106 | 214371067 | Enra | all printed clauses / 4 registrations | PASS |
| 107 | 229399508 | Kokeshisa | all printed clauses / 4 registrations | PASS |
| 108 | 228033609 | Shishi | all printed clauses / 4 registrations | PASS |
| 109 | 247378501 | Muramasa | all printed clauses / 4 registrations | NEEDS MANUAL RULING |
| 110 | 248801935 | Kanmuriyama | all printed clauses / 5 registrations | NEEDS MANUAL RULING |
| 111 | 229996802 | Takama No Hara | all printed clauses / 3 registrations | PASS |
| 112 | 246393365 | Rei-Tachi Ga Kita Hi | all printed clauses / 3 registrations | PASS |
| 113 | 221855414 | Otakemaru the Accuser | all printed clauses / 6 registrations | NEEDS MANUAL RULING |
| 114 | 259429721 | Champion of the Grand Blue | all printed clauses / 3 registrations | PASS |
| 115 | 259500899 | Diving Daughters of the Grand Blue | all printed clauses / 4 registrations | PASS |
| 116 | 259369909 | Serene Mermaid of the Grand Blue | all printed clauses / 3 registrations | NEEDS MANUAL RULING |
| 117 | 259934756 | Jelly Lass of the Grand Blue | all printed clauses / 3 registrations | PASS |
| 118 | 259273394 | Jelly Miss of the Grand Blue | all printed clauses / 7 registrations | PASS |
| 119 | 259417461 | Brilliance of the Grand Blue | all printed clauses / 2 registrations | PASS |
| 120 | 259679619 | City Within the Grand Blue | all printed clauses / 3 registrations | NEEDS MANUAL RULING |
| 121 | 259177849 | Grand Blue Princess | all printed clauses / 4 registrations | PASS |
| 122 | 259578863 | Oracle of the Grand Blue | all printed clauses / 6 registrations | PASS |
| 123 | 259093260 | Grand Blue Matriarch | all printed clauses / 3 registrations | NEEDS MANUAL RULING |
| 124 | 259937946 | Grand Blue Prince | all printed clauses / 5 registrations | PASS |
| 125 | 259028576 | Stellaer of the Lightning Runes | all printed clauses / 5 registrations | PASS |
| 126 | 211964444 | Priestess of Nephthys | all printed clauses / 2 registrations | NEEDS MANUAL RULING |
| 127 | 216532402 | Sacred Feather of Nephthys | all printed clauses / 2 registrations | NEEDS MANUAL RULING |
| 128 | 259581666 | Stellaer of the Frozen | all printed clauses / 3 registrations | NEEDS MANUAL RULING |
| 129 | 256287781 | Rage of Nephthys | all printed clauses / 4 registrations | NEEDS MANUAL RULING |
| 130 | 240299292 | To Proto Ousia | all printed clauses / 3 registrations | PASS |
| 131 | 245400676 | To Proto Archegoni | all printed clauses / 4 registrations | NEEDS MANUAL RULING |
| 132 | 246524183 | Protogenesis | all printed clauses / 2 registrations | NEEDS MANUAL RULING |
| 133 | 234729347 | The Beginning | all printed clauses / 5 registrations | FIXED |
| 134 | 232706629 | Protogenic Astral Cycle | all printed clauses / 4 registrations | NEEDS MANUAL RULING |
| 135 | 244013196 | To Proto Chrono | all printed clauses / 4 registrations | NEEDS MANUAL RULING |
| 136 | 246380598 | To Proto Taxis | all printed clauses / 12 registrations | NEEDS MANUAL RULING |
| 137 | 259219942 | Stellaer of the Plants | all printed clauses / 4 registrations | NEEDS MANUAL RULING |
| 138 | 224225695 | To Proto Ataxia | all printed clauses / 12 registrations | PASS |
| 139 | 217332244 | To Proto Psychi | all printed clauses / 9 registrations | NEEDS MANUAL RULING |
| 140 | 241543138 | To Proto Eisodos | all printed clauses / 2 registrations | PASS |
| 141 | 254065048 | Polemistis Gia Ataxia | all printed clauses / 6 registrations | NEEDS MANUAL RULING |
| 142 | 212684822 | Ektelestis Gia Taxis | all printed clauses / 5 registrations | NEEDS MANUAL RULING |
| 143 | 259057226 | Stellaer of the Cold | all printed clauses / 4 registrations | PASS |
| 144 | 234455260 | Stellaer of the Night | all printed clauses / 3 registrations | PASS |
| 145 | 226903348 | Stellaer of the Sea | all printed clauses / 4 registrations | PASS |
| 146 | 225106953 | Stellaer of the Gems | all printed clauses / 4 registrations | PASS |
| 147 | 230998543 | Stellaer of the Breeze | all printed clauses / 3 registrations | NEEDS MANUAL RULING |
| 148 | 230132786 | Stellaer of the Volcanos | all printed clauses / 3 registrations | PASS |
| 149 | 236551669 | Pride of the Stellaers | all printed clauses / 3 registrations | PASS |
| 150 | 257549955 | A Stellaer Is Reborn | all printed clauses / 2 registrations | PASS |
| 151 | 259214334 | Stellaer's Pain | all printed clauses / 1 registrations | PASS |
| 152 | 259655976 | Stellaer of Lighting | all printed clauses / 3 registrations | PASS |
| 153 | 212184534 | Stellaer of the Flames | all printed clauses / 2 registrations | PASS |
| 154 | 215445495 | Stellaer of the Waters | all printed clauses / 2 registrations | PASS |
| 155 | 216505735 | Stellaer of the Air | all printed clauses / 2 registrations | PASS |
| 156 | 231400558 | Stellaer of the Darkness | all printed clauses / 2 registrations | PASS |
| 157 | 214226989 | Stellaer of Purity | all printed clauses / 3 registrations | PASS |
| 158 | 219905997 | Stellaer of the Ground | all printed clauses / 2 registrations | PASS |
| 159 | 239245471 | Birth of Azrynior | all printed clauses / 3 registrations | NEEDS MANUAL RULING |
| 160 | 224751741 | Fall of Azrynior | all printed clauses / 4 registrations | NEEDS MANUAL RULING |
| 161 | 236239443 | Restoration of Azrynior | all printed clauses / 3 registrations | NEEDS MANUAL RULING |
| 162 | 245099829 | Azrynior, the Abundaence of Purity | all printed clauses / 8 registrations | NEEDS MANUAL RULING |
| 163 | 223512283 | Dysmandr, the Depraevity of Worlds | all printed clauses / 9 registrations | NEEDS MANUAL RULING |
| 164 | 242009896 | Extinction of Dysmandr | all printed clauses / 2 registrations | NEEDS MANUAL RULING |
| 165 | 214552846 | Eldora, the Intergalactic Empire | all printed clauses / 5 registrations | FIXED / NEEDS MANUAL RULING |
| 166 | 229786055 | Eldora in Depraevity | all printed clauses / 1 registrations | NEEDS MANUAL RULING |
| 167 | 222676270 | Frozen Girl & Blood Moon | all printed clauses / 1 registrations | NEEDS MANUAL RULING |
| 168 | 222782750 | Ghost Doll & Midnight Manor | all printed clauses / 1 registrations | NEEDS MANUAL RULING |
| 169 | 259290896 | Dominus Sentinel | all printed clauses / 3 registrations | NEEDS MANUAL RULING |
| 170 | 210716547 | Clock of Aldrez | all printed clauses / 6 registrations | NEEDS MANUAL RULING |
| 171 | 246496923 | Aldrez Grandmaster | all printed clauses / 3 registrations | PASS |
| 172 | 219047593 | Phantasm Spiral Resurgence | all printed clauses / 9 registrations | NEEDS MANUAL RULING |

## New defects fixed in this cross-pass

- `c259265448.lua` — Domestic Underworld's printed, mandatory start-of-Battle-Phase effect was an optional `TRIGGER_O`; changed to `TRIGGER_F`.
- `c234729347.lua` — The Beginning's printed, mandatory Level 11 Special Summon trigger was an optional `TRIGGER_O`; changed to `TRIGGER_F`.
- `c214552846.lua` — Eldora's printed, mandatory destroyed-and-sent-to-GY trigger was an optional `TRIGGER_O`; changed to `TRIGGER_F`.
- `c247499445.lua` — Stained Fox Feness could shuffle itself after targeting an unaffected card even though the target was not negated. Added `IsCanBeDisabledByEffect(e,false)` and the official non-disableable negate property before the “and if you do” continuation.
- `c213849997.lua` — Checkmate in Aldrez could execute its optional destruction branch when an unaffected target was not negated. Added the same official negate-resolution gate and properties.
- `c245970073.lua` — A Stainless Story's copied Feness branch had the same false-success path. Added the official negate-resolution gate and property.

## Independent audit checks

- Cost/target/operation role audit: no target or condition mutation findings in ordinals 1–172. The five `REASON_COST` operation findings (ordinals 78, 135, 136, 138, and 139) are Special Summon procedure operations, where Omega performs the procedure payment in the procedure operation.
- Resolution relation audit: targeted cards are rechecked with `IsRelateToEffect`/related official target-group helpers; source-card relation checks were retained only where the source itself must remain available.
- Sequencing audit: every printed `and if you do`, `then`, and `also, after that` sequence was reviewed against the operation's actual return value or operated group. The three negate false-success paths above were the new findings.
- Mandatory/optional audit: every printed mandatory sentence was compared with `TRIGGER_F`/continuous patterns. Three incorrect optional trigger declarations were fixed.
- Count-limit audit: shared “only use 1 effect” IDs use a shared count code; no script-added count limit was found on a card with no printed frequency restriction.
- GY/banishment audit: true GY access uses `aux.NecroValleyFilter` where applicable, and generic banished selection excludes face-down banished cards. Static no-NecroValley hits at ordinals 9, 25, 26, 38, 63, 64, 76, 85, 111, 122, 127, 130, 133, 167, and 169 were individually resolved as costs, previous/summon/chain-location predicates, replacement metadata, or classifiers rather than unprotected GY access.
- Procedure/API audit: every Extra Deck monster has `EnableReviveLimit`; Link/Fusion/Synchro/Xyz/Ritual/custom procedure patterns were compared to official procedures. The Lane A Card/Effect/Duel/Group/aux method inventory contains no API absent from the official Omega corpus.
- Standalone audit: all 172 expected `c<ID>.lua` files exist, match their source passcodes, create their own `GetID` table, and contain no `require`, `dofile`, or shared-module loader.

## Official Omega references used

- Mandatory phase/event triggers: `c71545247.lua` (forced Battle Start), `c10000020.lua` (forced field Special Summon-success), `c101203024.lua` (forced single-card GY trigger).
- Face-up-card negation and resolution immunity: `c100245037.lua`, `c101204077.lua`, `c101208208.lua`.
- Costs and target separation: `c100200290.lua`, `c100211099.lua`, `c100245009.lua`, `c100245038.lua`, `c100245040.lua`.
- Chain limits and negation: `c10019086.lua`, `c100201001.lua`, `c100235002.lua`, `c100245021.lua`, `c100250201.lua`, `c101304084.lua`.
- Face-up banished filters: `c100211003.lua`, `c100211051.lua`, `c100211053.lua`, `c100240201.lua`.
- Deck costs/material access: `c101203013.lua`, `c101203021.lua`, `c101204024.lua`, `c101302209.lua`.
- Overlay and Xyz handling: `c10443957.lua`, `c101203048.lua`, `c16110708.lua`, `c2530830.lua`, `c25853045.lua`.
- Fusion/Link/Ritual procedures: `c100211097.lua`, `c100241001.lua`, `procedure.lua`, `c50669347.lua`, `c100245037.lua`, `c31603289.lua`, `c67098897.lua`, `c93192592.lua`, `c23459650.lua`, `c88176533.lua`, `c8454126.lua`, `c25397880.lua`, `c51782995.lua`, `c52904476.lua`, `c98999181.lua`.
- Copied effects and delayed handling: `c23153227.lua`, `c43331750.lua`, `c70369116.lua`, `c97769122.lua`.
- Placement, Set-turn activation, and lost equip targets: `c10004783.lua`, `c100261001.lua`, `c101303208.lua`, `c35884610.lua`.
- Chain rewriting, stat halving, and Umi aliases: `c25072579.lua`, `c53589300.lua`, `c62318994.lua`, `c32696942.lua`, `c11264180.lua`, `c14258627.lua`, `c2009101.lua`, `c295517.lua`, `c2819435.lua`, `c11082056.lua`.

## Verification results

- Per-card `luac -p`, ordinals 1–172: **172/172 PASS**.
- Full public script-folder `luac -p`: **592/592 PASS**.
- Stubbed script load plus `initial_effect`, ordinals 1–172: **172/172 PASS**; 533 registrations executed during initialization.
- AST role audit (`node tmp/ultimate_ast_audit.cjs`): **PASS** for Lane A after classifying five procedure-operation cost findings; no target mutation, condition mutation, operation target selection, or unresolved target relation defects.
- Inventory/passcode/standalone-loader scan: **PASS**; 172 files present, 0 bad IDs, 0 forbidden loaders, 728 static registration call sites.
- Unsupported Card/Effect/Duel/Group/aux API comparison against `tmp/omega_scripts`: **PASS**, 0 unsupported methods.
- `git diff --check` for all six cross-pass scripts: **PASS**.

## Remaining in-engine risk

Manual-ruling verdicts are concentrated in custom Tribute/Fusion/Synchro/Xyz/face-down-Extra-Deck UIs, copied or hardcoded text-list pools, nonstandard opponent-Deck materials, damage/reflection layering, chain rewriting/classification, multi-card simultaneous Summons, delayed group/position restoration, and contradictory or truncated source wording (notably the literal “12” on the Dysmandr/Eldora cards). These require live Omega duel scenarios; static syntax/load tests cannot prove selection prompts, replacement integrations, timing windows, or interactions with immunity/Necrovalley across the full card pool.


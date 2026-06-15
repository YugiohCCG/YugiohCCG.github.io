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

## Do Not Revert

The worktree contains many modified and untracked generated files from recent card batches. Do not clean, reset, or revert them unless the user explicitly asks.

Expected dirty/generated areas include:

- `src/data/cards.json`
- `src/data/ccg-omega-ids.json`
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

## Latest Scripting Batch

Generated and audited the To Proto Eisodos / Polemistis / Ektelestis / Stellaer batch, and re-audited `To Proto Psychi`:

- `c217332244.lua` - To Proto Psychi (audit only in this pass)
- `c241543138.lua` - TO PROTO EISODOS
- `c254065048.lua` - Polemistis gia Ataxia
- `c212684822.lua` - Ektelestis gia Taxis
- `c259057226.lua` - Stellaer of the Cold
- `c234455260.lua` - Stellaer of the Night
- `c226903348.lua` - Stellaer of the Sea
- `c225106953.lua` - Stellaer of the Gems
- `c230998543.lua` - Stellaer of the Breeze
- `c230132786.lua` - Stellaer of the Volcanos

Fixes and implementation notes from this pass:

- Added standalone Lua scripts for CARD-0141 through CARD-0149 and DB `aux.Stringid` message overrides for the nine new scripts.
- `TO PROTO EISODOS` uses official Link material structure for 2 Effect Monsters with different names, official token creation with `Duel.SpecialSummonStep`, and "then" sequencing that only continues after both the field target and Deck monster are banished.
- `Polemistis gia Ataxia` and `Ektelestis gia Taxis` use official contact-Fusion / Extra Deck Special Summon patterns: `aux.AddFusionProcFunRep`, `EFFECT_SPSUMMON_CONDITION`, `Duel.GetLocationCountFromEx`, selected release material groups, `c:SetMaterial`, and `Duel.Release(...,REASON_SPSUMMON+REASON_MATERIAL)`.
- `Polemistis gia Ataxia` implements the ATK/DEF gain as a continuous sum of current ATK/DEF loss on face-up monsters, halved. This is the closest static Omega representation because the corpus has no clean event hook for "a monster(s) loses ATK/DEF".
- `Polemistis gia Ataxia` and `Ektelestis gia Taxis` use explicit current passcode tables for searchable `Ataxia`/`Taxis` Spell/Trap cards because these are name/text-treated cards rather than a searchable setcode.
- The six Stellaer hand Special Summon effects follow the prior Stellaer hand-summon pattern and apply the rest-of-turn Attribute summon lock in the summon procedure operation.
- `Stellaer of the Sea` and `Stellaer of the Breeze` guard GY access with `aux.NecroValleyFilter`.
- `Stellaer of the Breeze` uses the official immediate `Duel.XyzSummon(tp,xyz,mg)` pattern with exactly the two monsters Special Summoned by its effect.
- `Stellaer of the Gems` uses Omega's official Level/Rank announcement prompt constant (`HINGMSG_LVRANK`) and `EFFECT_CHANGE_LEVEL`.

Official Omega references used in this pass:

- Contact Fusion / Extra Deck Special Summon by releasing materials: `c15291624.lua`, `c100245006.lua`, `c42166000.lua`.
- Link-2 and different-name Link material checks: `c101202084.lua`, `c100256018.lua`, `c101301085.lua`.
- Token creation: `c100211003.lua`, `c101203044.lua`, local `c240299292.lua`, local `c232706629.lua`.
- Battle damage reflection/halving and battle damage recovery: `c100213004.lua`, `c13313278.lua`, `c101301087.lua`, local `c246380598.lua`.
- Return banished Extra Deck monster / redirect patterns: `c100240203.lua`, `c100211123.lua`, `c100250204.lua`, local `c227043533.lua`, local `c221855414.lua`, local `c228033609.lua`, local `c221321849.lua`.
- Attack-all and repeated attack structures: `c100256016.lua`, local `c215853847.lua`, local `c213266433.lua`.
- Level declaration/change patterns: `c16725505.lua`, `c16769305.lua`, `c20579538.lua`, `c22657402.lua`.
- Xyz Summon with a selected material group: local `c231825514.lua`, local `c250556612.lua`, local `c218600459.lua`.

Verification passed:

- Per-card `luac -p` for the 10 in-scope scripts.
- Full public script folder `luac -p` (`256` scripts).
- Full installed Omega script folder `luac -p` (`256` scripts).
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

- All `256` Lua scripts in `public/CCG Downloads/CCG_Scripts` pass `luac -p`.
- All `256` Lua scripts in `C:\Program Files (x86)\YGO Omega\YGO Omega_Data\Files\Scripts` pass `luac -p`.
- All `256` Lua scripts in `dist/CCG Downloads/CCG_Scripts` pass `luac -p`.
- The latest repeat audit covered 20 prompted entries / 19 unique scripts and those in-scope scripts pass per-card checks for:
  - Lua syntax
  - `initial_effect` smoke loading
  - public DB row
  - installed Omega DB row
  - `src/data/cards.json` name/description match
  - `src/data/ccg-omega-ids.json` mapping
  - type/setcode/stats metadata
  - `aux.Stringid` message index accuracy
  - script presence in `CCG_Scripts.zip`
  - public script, zip entry, and installed Omega script hash match
  - static effect-pattern checks
- All public script files hash-match both `CCG_Scripts.zip` and the installed Omega script folder.
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
2. Confirm Omega IDs in `src/data/ccg-omega-ids.json`.
3. Find official analog scripts in `tmp\omega_scripts`.
4. Create/update `public/CCG Downloads/CCG_Scripts/c<ID>.lua`.
5. Run per-file `luac -p`, then all-script syntax.
6. Sync scripts to local Omega install.
7. Rebuild `CCG_Scripts.zip`.
8. Verify DB rows/messages/types/setcodes/stats in both public and installed Omega DBs.
9. Run `npm run build`.
10. Confirm `public` and `dist` artifact hashes match.

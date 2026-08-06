# CCG Semantic Effect Audit - Final Report
## Scope and Methodology
This document contains the final reconciliation of the multi-agent distributed semantic audit covering all active custom CCG cards. Findings have been collected from Primary Auditors (Lanes A, B, and C) and independently assessed by Cross-Reviewers.
The final counts and totals are reconciled across the lanes and reviews.

## Honest Totals (Complete)
- **Cards Fully Reviewed**: 577 (across all batches and lanes)
- See detailed tables below for confirmed correct cards, fixed bugs, and live test cases.


---
## ultimate_audit_lane_a.md Primary Auditor Findings
# Ultimate Lua Audit — Lane A (cards.json ordinals 1–172)

Scope: `CARD-0001` through `CARD-0172` (`Phantasm Spiral Resurgence`), 172 standalone scripts and 728 observed `RegisterEffect` calls (including effects registered dynamically at resolution). Every printed clause was read from `src/data/cards.json`, compared to its Lua cost/target/operation split, and checked against the official Omega corpus in `tmp/omega_scripts`.

Legend: **P** = pass; **F** = fixed in this pass; **R** = mechanically implemented but still needs a live-engine or wording ruling. Slash-separated entries are the individually audited printed effects/procedures.

## Per-card / per-effect ledger

| Ord. | Card (Omega ID) | Individual effects audited | Result |
|---:|---|---|---|
| 1 | Stardrake of Gravitic Coils (245265629) | Special Summon procedure P / summon restriction P / battle and stat effects P | P |
| 2 | Reactor Shocker (241056746) | activated-effect negate F (`NegateEffect`) / bottom-Deck continuation P | F |
| 3 | The Condescender (221321849) | summon procedure P / Level and Rank reduction P / Link Rating reduction unsupported | R |
| 4 | Stained Bird Bria (225091736) | Summon trigger add-or-bottom P / success-gated draw F / generic banishment visibility F | F |
| 5 | Stained Deer Dante (216958556) | Summon destruction P / successful-destroy self shuffle P | P |
| 6 | Stained Fox Feness (247499445) | hand self-Summon procedure P / Summon negate-and-shuffle P | R (printed colon versus procedure UI) |
| 7 | Stained Raptor Rollo (224822244) | Summon revival P / battle top-of-Deck sequence P | P |
| 8 | Stained Solitaire (259475154) | reveal Fusion as cost F / field Stain shuffle as search cost F / banished visibility F | F |
| 9 | Stargazer of the Stained (218685316) | Fusion material handling P / Stain support effect P | P |
| 10 | Stained Scioness Silia (244408495) | Fusion procedure P / pre-semicolon Fusion reveal moved to cost F | F |
| 11 | Stained Sovereign Silas (221822671) | Fusion procedure P / Deck add-or-Set P / GY self-shuffle with Necrovalley P | P |
| 12 | Stained Silhouette (256608976) | Fusion/protection P / copied-effect behavior P | R (nonstandard `CopyEffect`) |
| 13 | Abstain from Light (232449539) | opponent-Deck Fusion materials P / shuffled-card tracker P / delayed return P | R |
| 14 | Shattering Sustained (248453205) | opponent-Deck pseudo-Tribute R / full-zone Tribute legality F / post-cost target legality F | F/R |
| 15 | Stained Avatar (244790302) | destruction replacement P / Fusion trigger P / copied activation P | R (card-pool-sensitive copy) |
| 16 | Stained Sorceress Silphia (247789143) | Fusion effects P / exact 2000 ATK loss and reverse-update guard F / conditional banish F | F |
| 17 | Distained Druid Dragar (247580036) | opponent-Deck pseudo-Tribute R / remaining Fusion effects P | R |
| 18 | Stainless Kaleidragon (217174535) | Fusion effects P / effect-not-activation negation F | F |
| 19 | Aetherstorm Zenith Wire-Tailed Sypharion (259365935) | Synchro procedure P / protection, stat and triggered effects P | P |
| 20 | Armored Nova Mecha-Scaled Xyrion (224274662) | Link procedure P / linked-zone, protection, negate and combat effects P | P |
| 21 | Solemn Rebirth (224049334) | activation timing P / revival P / follow-up restriction P | P |
| 22 | Talismandrake Spark (230947464) | summon restriction P / search and equip interactions P | P |
| 23 | Talismandrake Embers (256928871) | summon, equip and destruction branches P | P |
| 24 | Talismandrake Heat (210506870) | summon/equip effects P / single-range ATK update flag F | F |
| 25 | Talismandrake Sear (245935439) | summon/equip and damage effects P | P |
| 26 | Talismandrake Arms United (215034223) | Fusion procedure P / all equip-derived protections and combat modifiers P | P |
| 27 | Left Talismandrake Arms - Blaze Suppressor (238136421) | equip activation P / limits, stat and disruption effects P | P |
| 28 | Right Talismandrake Arms - Blaze Halberd (215921734) | equip activation P / piercing, attack and equip effects P | P |
| 29 | Right Talismandrake Arms - Blaze Sabre (248788543) | equip activation P / destruction, attack and stat branches P | P |
| 30 | Left Talismandrake Arms - Blaze Shield (255832330) | equip activation P / protection and stat branches P | P |
| 31 | Talismandrake Pyre (227362839) | activation/search P / GY branch P | P |
| 32 | Talismandrake Cremation (253552927) | activation and equip branches P / GY-or-banishment visibility and NV access F | F |
| 33 | Talismandrake Enkindle (241706191) | summon/equip/replacement branches P | P |
| 34 | Maiden of Talismandrakes Seraphina (218142234) | summon and equip suite P / paid destroy-all no longer rechecks activation condition F | F |
| 35 | Bishop of Aldrez (228926678) | summon/procedure and Aldrez effects P | P |
| 36 | Pawn of Aldrez (235448944) | summon and column interactions P | P |
| 37 | Queen of Aldrez (231892575) | summon and Aldrez control effects P | P |
| 38 | Aldrez Battery (233759343) | activation, counters and follow-ups P | P |
| 39 | Aldrez Blitz (217700538) | Token Summon P / helper row `217700539` verified P | P |
| 40 | Aldrez Opening (210923192) | summon response chain limit P / all choice branches P | P |
| 41 | Checked in Aldrez (250508903) | activation and movement effects P | P |
| 42 | Checkmate in Aldrez (213849997) | activation, summon and column effects P | P |
| 43 | Knight of Aldrez (238282350) | summon and material effects P | P |
| 44 | Rook of Aldrez (231129918) | alternate Xyz/material effects P / immune field card excluded from attach F | F |
| 45 | King of Aldrez (252210718) | Xyz and Aldrez control effects P | P |
| 46 | The Blue Frute (236158052) | face-down Extra Deck summon procedure and effects P | R (custom UI) |
| 47 | The Yellow Frute (235607781) | summon procedure and Frute effect P | R (custom UI) |
| 48 | The Red Frute (246216813) | summon procedure and Frute effect P | R (custom UI) |
| 49 | The Green Frute (227745087) | field-Tribute/full-zone cost and summon P | R (custom UI) |
| 50 | The White Frute (220916791) | mandatory Tribute opens MZONE before target check F / summon effect P | F/R |
| 51 | Fruteonia (246830897) | field effects and custom Frute Summon support P | R (face-down Link/Ritual UI) |
| 52 | Fruteopia (216140411) | field effects and custom Frute Summon support P | R (face-down Link/Ritual UI) |
| 53 | Fruteaching (247458749) | activation/search and GY effect P | P |
| 54 | Fruteification (256930605) | activation and summon behavior P | R (custom summon UI) |
| 55 | The Flying Frute (236179696) | Malefic-style summon procedure and effect P | P |
| 56 | The Hanging Frute (213266433) | attack-all approximation P / temporary protection R | R |
| 57 | The Fruteful Moon (248290754) | field and Frute support effects P | R (custom UI) |
| 58 | The Fruted Warrior (213615627) | Fusion and Frute effects P | P |
| 59 | Sacred Treasure - Bojin (236542835) | banish trigger and paired Treasure condition P | R (same-event interpretation) |
| 60 | Sacred Treasure - Chunyin (229499914) | banish trigger P / face-up banished add filter F | F/R |
| 61 | Sacred Treasure - Huangjin (246421842) | banish trigger and paired Treasure condition P | R (same-event interpretation) |
| 62 | Niuhao - Bauba (218600459) | summon and Sacred Treasure branch P | P |
| 63 | Niuhao - Hikam (235789995) | summon and Sacred Treasure branch P | P |
| 64 | Niuhao - Oro (232232676) | summon and Sacred Treasure branch P | P |
| 65 | Niuhao - Lokaeo (227043533) | summon and Sacred Treasure branch P | P |
| 66 | Niuhao - Zaoka (215629896) | summon and Sacred Treasure branch P | P |
| 67 | Niuhao - Koai (231825514) | summon and Treasure interaction P | P |
| 68 | Niuhao - Zao (250556612) | manually applied current Treasure branches P | R (future card-pool sensitivity) |
| 69 | Pip, the Domesticated (259377794) | summon restriction/search/battle shuffle P | R (custom Tribute Summon support) |
| 70 | Tove, the Domesticated (259737127) | summon restriction/draw-send/GY delayed Battle Phase return P | R |
| 71 | Domestica Praerie (259264881) | hand Tribute support/set/search-send P | R (custom Tribute UI) |
| 72 | Domestica Anjelie (259337739) | hand Tribute support/set/search-send P | R (custom Tribute UI) |
| 73 | Domestica Lunalie (259245149) | hand Tribute support/set/GY access P | R (custom Tribute UI) |
| 74 | Domestication (259201342) | reveal/send effect P / GY replacement P | P |
| 75 | Domestic Underworld (259265448) | event target shuffle-search-send P / unrespondable mass revival and delayed send P | P |
| 76 | Domestica in the Underworld (259668626) | extra hand Tribute P / Set protection P / draw-then-send P | R (extra Tribute UI) |
| 77 | Domestica in the Wild (259410628) | extra hand Tribute P / Set-turn activation P / optional Tribute and GY Fusion P | R (Fusion UI) |
| 78 | Domestica Kyrie (259670933) | contact Fusion procedure P / Underworld placement P / Tributed-turn GY effect P | R (custom procedure) |
| 79 | Pip in the Wild (259394179) | summon restriction and board clear P / independent `also` return-search F | F |
| 80 | Tove in the Wild (259718504) | summon restriction and S/T bounce P / independent `also` return-search F | F |
| 81 | Remembrance of the Melody (216620496) | up-to-3 banished S/T return P / GY banish-and-add P / face-up banished filters F | F |
| 82 | Chaos Fusion (255277197) | hand/field plus bounded LIGHT/DARK GY Fusion materials P / delayed GY pair return and face-up targets F | F |
| 83 | Ursarctic Mikailus (245378354) | official-style hand Tribute/replacement summon P / Set-turn activation P / cost-send draw P | P |
| 84 | Ursarctic Megailus (218837030) | hand Tribute/replacement summon P / destruction and draw P | P |
| 85 | Ursarctic Leoship (247831166) | activation search P / hand summon P / replacement marker P | R (custom replacement integration) |
| 86 | Ursarctic Octantis (235051048) | non-Synchro procedure P / replacement Tribute summon P / GY revival P | R (custom Synchro-style procedure) |
| 87 | Ursarctic Hextanius (244921711) | non-Synchro procedure P / Deck summon P / shuffle-draw with hidden banishment excluded F | F/R |
| 88 | Ursarctic Nordbar (249093610) | non-Synchro procedure P / revive/search P / activation negate-destroy P | R (custom procedure) |
| 89 | Carina of the Eldoran System (228686743) | no effects in printed text or script | P |
| 90 | Branching to Guidance (222257685) | hand reveal Token copy P / GY target Token copy P / helper row `222257686` verified | R (copied token identity/stats UI) |
| 91 | Rigel the Thousand-Armed (215853847) | Link procedure P / protection and battle lock P / material-rating ATK and attack-all P | P |
| 92 | Prophecy of Infernos (229327103) | return, summon, then text-list search P | R (hardcoded text-list pool) |
| 93 | Prophecy of Waterfalls (251058567) | return, summon, then text-list search P | R (hardcoded text-list pool) |
| 94 | Prophecy of Boulders (223558392) | return/summon P / current eligible search list empty | R |
| 95 | Prophecy of Storms (223592011) | return, summon, then text-list search P | R (hardcoded text-list pool) |
| 96 | Prophecy of Rays (244920555) | return, summon, then text-list search P | R (hardcoded text-list pool) |
| 97 | Prophecy of Shadows (243920845) | return, summon, then text-list search P | R (hardcoded text-list pool) |
| 98 | Stellaer of the Swamp (259586445) | alternate Xyz P / Main Phase detach-destroy P / Xyz-trigger missing detach cost F / self-destroy draw P | F |
| 99 | Sustained Succubus Saria (219419648) | Fusion/protection/reflection P / search P / attack-event shuffle and optional ATK 0 P | P |
| 100 | A Stainless Story (245970073) | copy pool P / opponent face-up Deck source restored F / copied Bria visibility F / mutual draw P | F/R (copy pool) |
| 101 | Mylo, the Domesticated (259686203) | summon restriction/search P / Battle Phase GY shuffle and Fairy immunity P | R (summon restriction UI) |
| 102 | Nuwa, the Domesticated (259135917) | summon restriction/search P / conditional Battle Phase activation lock P | R (summon restriction UI) |
| 103 | Mylo in the Wild (259911246) | board Set/End return P / independent `also` return-search F | F/R (position restoration ruling) |
| 104 | Nuwa in the Wild (259796760) | mass negate/ATK 0 P / independent `also` return-search F | F |
| 105 | Onibi (217713649) | Spirit return and summon restriction P / optional hand Tribute immediate Normal Summon/search P | R (immediate Normal Summon UI) |
| 106 | Enra (214371067) | Spirit return/restriction P / chained Normal Summons P / Tributed protection P | P |
| 107 | Kokeshisa (229399508) | Tribute-and-Normal-Summon P / optional GY/field bounce P / Tributed targeting protection P | P |
| 108 | Shishi (228033609) | Tribute draw P / leave-field hand redirect P / Spirit return P | P |
| 109 | Muramasa (247378501) | opponent-monster Tribute Summon P / add-or-equip P / Spirit return P | R (alternate Tribute UI) |
| 110 | Kanmuriyama (248801935) | equip legality P / different-Attribute search P / lost-target recovery P / battle bounce P | R (lost-target event state) |
| 111 | Takama No Hara (229996802) | two-card operation discard then different-Level search P / GY protection effect P | P |
| 112 | Rei-Tachi Ga Kita Hi (246393365) | GY targets shuffle then draw P / dynamic Spirit extra attacks P | P |
| 113 | Otakemaru the Accuser (221855414) | Synchro procedure P / End Phase return lock P / target protection P / bounce P / forced return-then-double revival P | R (paired summon UI) |
| 114 | Champion of the Grand Blue (259429721) | GY add-or-revive and conditional self summon P / self revive-equip-column destroy P | P |
| 115 | Diving Daughters of the Grand Blue (259500899) | Deck send P / targeted revival P / effect-target legality F | F |
| 116 | Serene Mermaid of the Grand Blue (259369909) | hand summon P / Fusion Summon P / post-Fusion Extra Deck restriction approximated | R |
| 117 | Jelly Lass of the Grand Blue (259934756) | Umi hand summon P / hand Fusion P / GY targeted revival targetability F | F |
| 118 | Jelly Miss of the Grand Blue (259273394) | summon-then-negate/stat gain P / GY shuffle Fusion P | P |
| 119 | Brilliance of the Grand Blue (259417461) | add-then-send P / GY recovery-then-discard P / actual-hand success gates F | F |
| 120 | City Within the Grand Blue (259679619) | runtime Umi code P / optional activation search P / original-WATER GY aura P | R (runtime alias) |
| 121 | Grand Blue Princess (259177849) | add-or-send P / summon-then-send P / banished-card targetability F / next-turn DEF P | F |
| 122 | Oracle of the Grand Blue (259578863) | Link procedure P / negate no longer depends on source remaining F / linked destroy P / DEF aura P / Set-or-add P | F |
| 123 | Grand Blue Matriarch (259093260) | Link-as-Level Synchro support P / S/T activation negate P / opponent-turn WATER revival P | R (Synchro UI) |
| 124 | Grand Blue Prince (259937946) | possession-only Fusion P / revival-negate P / GY shuffle-then-send P | P |
| 125 | Stellaer of the Lightning Runes (259028576) | alternate summon P / ELECTRIC restriction polarity F / detached revival P | F |
| 126 | Priestess of Nephthys (211964444) | destroy-from-Deck and Standby-effect application P / hand shuffle search P | R (copied Standby effect pool) |
| 127 | Sacred Feather of Nephthys (216532402) | Ritual procedure/Deck material P / GY destroy-then-place P / Conductor ID corrected to official `8454126` F | F/R (Ritual UI) |
| 128 | Stellaer of the Frozen (259581666) | alternate Xyz P / both detach-and-Set branches P / self-destroy draw P | R (face-up S/T Set cases) |
| 129 | Rage of Nephthys (256287781) | ATK-loss/destroy P / cost shuffle and chain rewrite P | R (quoted pronoun ruling) |
| 130 | To Proto Ousia (240299292) | Token summon independent of source relation F / Link-material GY add and actual-hand draw gate F | F |
| 131 | To Proto Archegoni (245400676) | Link once-per-turn procedure P / discard search resolves if source leaves F / protection P | F/R (text-list pool) |
| 132 | Protogenesis (246524183) | reveal then summon-or-banish P / End Phase LP loss P | R (`if you do` timing) |
| 133 | The Beginning (234729347) | Token-based target protection P / hand banish search P / Level 11 summon Token trigger P | P |
| 134 | Protogenic Astral Cycle (232706629) | column zone mask P / Token summon P / banish cost and ignore-condition summon P | R (zone mask / “ignore card effects”) |
| 135 | To Proto Chrono (244013196) | summon restriction and procedure P / source text is truncated | R |
| 136 | To Proto Taxis (246380598) | procedure/aura/reflected half damage P / named Token cost F / true banishment target F | F/R (damage layering) |
| 137 | Stellaer of the Plants (259219942) | alternate summon P / NATURE restriction polarity F / reattach-and-redirect P | F/R (overlay redirect UI) |
| 138 | To Proto Ataxia (224225695) | procedure/aura/stat transfer P / named Token cost F / true banishment target F | F |
| 139 | To Proto Psychi (217332244) | procedure/recovery/stat gain P / named Token cost F / true banishment target F | F/R (100-LP increment UI) |
| 140 | To Proto Eisodos (241543138) | Link procedure and banished Token trigger source-independence F / opponent-turn paired banish and return/summon P | F |
| 141 | Polemistis Gia Ataxia (254065048) | Tribute Fusion procedure P / loss-based stat gain P / attack-all P / hardcoded Ataxia S/T access P | R (continuous-loss interpretation) |
| 142 | Ektelestis Gia Taxis (212684822) | Tribute Fusion procedure P / reflected half damage P / hardcoded Taxis S/T access P | R (damage layering/card pool) |
| 143 | Stellaer of the Cold (259057226) | alternate summon P / ICE restriction polarity F / detached hand summon P | F |
| 144 | Stellaer of the Night (234455260) | alternate summon and DARK Effect exception restriction P / detached search P | P |
| 145 | Stellaer of the Sea (226903348) | alternate summon P / WATER restriction polarity F / detached GY revival P | F |
| 146 | Stellaer of the Gems (225106953) | alternate summon P / EARTH restriction polarity F / two targets now require relation at resolution F | F |
| 147 | Stellaer of the Breeze (230998543) | alternate summon/restriction P / reveal, double summon and optional Xyz P | R (Xyz UI) |
| 148 | Stellaer of the Volcanos (230132786) | alternate summon/restriction P / total-Rank damage P | P |
| 149 | Pride of the Stellaers (236551669) | search option P / hand summon option P / immediate Xyz option P / per-option limits P | P |
| 150 | A Stellaer Is Reborn (257549955) | GY target revival no longer depends on Normal Spell source F / destroy replacement NV access F | F |
| 151 | Stellaer's Pain (259214334) | opponent activation negate-and-destroy P | P |
| 152 | Stellaer of Lighting (259655976) | alternate Xyz P / erroneous unprinted OPT removed F / banished visibility and actual-hand gate F / self-destroy draw P | F |
| 153 | Stellaer of the Flames (212184534) | alternate Xyz P / detach-target-destroy P / self-destroy draw P | P |
| 154 | Stellaer of the Waters (215445495) | alternate Xyz P / detach-target GY add with NV P / self-destroy draw P | P |
| 155 | Stellaer of the Air (216505735) | alternate Xyz P / detach then non-targeting field send P / self-destroy draw P | P |
| 156 | Stellaer of the Darkness (231400558) | alternate Xyz P / detach then non-targeting field send P / self-destroy draw P | P |
| 157 | Stellaer of Purity (214226989) | Xyz procedure P / transfer monster and materials P / escalating negate cost P / self-destroy revival P | P |
| 158 | Stellaer of the Ground (219905997) | alternate Xyz P / opponent-GY target revival with NV P / self-destroy draw P | P |
| 159 | Birth of Azrynior (239245471) | Token-then-Fusion P / optional shuffle and GY recovery P | R (named S/T pool) |
| 160 | Fall of Azrynior (224751741) | Normal Spell Token/Fusion no longer depends on source relation F / GY shuffle cost and recovery P | F/R (named S/T pool) |
| 161 | Restoration of Azrynior (236239443) | destroyed-card tracker P / named Token cost P / pre-cost freed-zone target validation P / mandatory group revival P | R (multi-summon UI) |
| 162 | Azrynior, the Abundaence of Purity (245099829) | Fusion/protection/stat P / place S/T P / global Token-Tribute tracker and End Token P | R (hardcoded S/T pool) |
| 163 | Dysmandr, the Depraevity of Worlds (223512283) | Fusion/protection/stat P / Galaxy race corrected F / source-independent place and End trigger F | F/R (hardcoded S/T pool) |
| 164 | Extinction of Dysmandr (242009896) | named Token cost P / matching mass destruction P / `then` continuation requires successful first destruction F | F/R (`12` source typo) |
| 165 | Eldora, the Intergalactic Empire (214552846) | resolve-time effect negate P / destroyed trigger mass destruction and Set-turn activation P | R (`12` source typo / operation-info inference) |
| 166 | Eldora in Depraevity (229786055) | copied Extinction branch P / `then` continuation success gate F | F/R (source text/name inconsistency) |
| 167 | Frozen Girl & Blood Moon (222676270) | discard cost P / effect-negate P / operation-category classifier P | R (classifier false-positive/negative testing) |
| 168 | Ghost Doll & Midnight Manor (222782750) | discard cost P / activation-negate P / banishment operation classifier P | R (operation-info coverage) |
| 169 | Dominus Sentinel (259290896) | hand activation P / effect-negate then conditional destroy P / permanent Attribute activation oath P | R (custom Attributes) |
| 170 | Clock of Aldrez (210716547) | summon Deck send P / Spell/Trap chain rewrite P / restriction now independent of Special Summon success F | F/R (concurrent chain rewrite state) |
| 171 | Aldrez Grandmaster (246496923) | battle S/T lock P / conditional reveal-or-target summon P / Link/non-Link and banished visibility P | P |
| 172 | Phantasm Spiral Resurgence (219047593) | equip legality P / halve stats P / negation now persists on same card in GY F / battle-destroy GY add P | F/R (phase-only persistent negate live test) |

## Official Omega references used

- Cost/reveal and pre-cost zone legality: `c100200290.lua`, `c100211099.lua`, `c100245009.lua`, `c100245038.lua`, `c100245040.lua`.
- Summon-response chain limits: `c10019086.lua`.
- Face-up banishment access and `IsFaceupEx`: `c100211003.lua`, `c100211051.lua`, `c100211053.lua`, `c100240201.lua`.
- Deck-as-cost patterns: `c101203013.lua`, `c101203021.lua`, `c101204024.lua`, `c101302209.lua`.
- Activation versus effect negation: `c100201001.lua`, `c100235002.lua`, `c100245021.lua`, `c100250201.lua`, `c101304084.lua`.
- Overlay/attach legality and Xyz procedures: `c10443957.lua`, `c101203048.lua`, `c16110708.lua`, `c2530830.lua`, `c25853045.lua`.
- Fusion material and custom Fusion checks: `c100211097.lua`, `c100241001.lua`, `procedure.lua`.
- Link and Link-as-Synchro-level patterns: `c50669347.lua`, `c100245037.lua`, `c31603289.lua`, `c67098897.lua`, `c93192592.lua`.
- Ritual and Nephthys patterns: `c23459650.lua`, `c88176533.lua`, `c8454126.lua`, `c25397880.lua`, `c51782995.lua`, `c52904476.lua`, `c98999181.lua`.
- Copied activation/effect application: `c23153227.lua`, `c43331750.lua`, `c70369116.lua`, `c97769122.lua`.
- Face-up Spell/Trap placement, Set handling and lost equip target: `c10004783.lua`, `c100261001.lua`, `c101303208.lua`, `c35884610.lua`.
- Chain operation rewrite and target clearing: `c25072579.lua`, `c53589300.lua`, `c62318994.lua`, `c32696942.lua`.
- Halving current ATK/DEF: `c11264180.lua`, `c14258627.lua`, `c2009101.lua`.
- Umi runtime-code patterns: `c295517.lua`, `c2819435.lua`, `c11082056.lua`.

## Focused Necrovalley audit

The 13 broad `LOCATION_GRAVE` scan candidates were reviewed manually. None required a Lua change:

- `Stargazer Stained` (`c218685316.lua`), `Arms United` (`c215034223.lua`), `Battery of Aldrez` (`c233759343.lua`), `Takama No Hara` (`c229996802.lua`), `Oracle of the Grand Blue` (`c259578863.lua`), and `Sacred Feather of Nephthys` (`c216532402.lua`) only banish their own handler from the GY as an activation cost through the official, widely used `aux.bfgcost`; Necrovalley filtering is not applied to costs.
- `Sear, the Talisman Drake` (`c245935439.lua`) only tests whether it became Fusion Material in the GY/face-up Extra Deck, then summons from the Pendulum Zone; it does not move a card out of the GY.
- `Hikam` (`c235789995.lua`) and `Oro` (`c232232676.lua`) only inspect an opponent effect's triggering location; their self-banish cost is legal only from the hand or face-up field, and their resolving actions access the Deck/banishment instead of the GY.
- `Domestica Underworld` (`c259668626.lua`) only uses `IsPreviousLocation(LOCATION_GRAVE)` to count monsters that have already returned to the Deck/Extra Deck; it does not move those cards out of the GY.
- `Leoship, Grand Polaris of the Ursarctic` (`c247831166.lua`) exposes a replacement-cost field effect over hand/field/GY. The consuming Ursarctic scripts perform the actual candidate selection and wrap GY candidates with `aux.NecroValleyFilter`; the provider itself does not move the candidate.
- `To Proto Ousia` (`c240299292.lua`) only checks that it reached the GY as Link Material, banishes itself via `aux.bfgcost`, and retrieves from banishment.
- `The Beginning` (`c234729347.lua`) only checks whether a Level 11 monster was Summoned from hand/GY; its effect then creates a Token and does not move the summoned monster from the GY.

## Files changed by lane A

47 Lua files:

`c210506870.lua`, `c210716547.lua`, `c216532402.lua`, `c216620496.lua`, `c217174535.lua`, `c217332244.lua`, `c218142234.lua`, `c219047593.lua`, `c220916791.lua`, `c223512283.lua`, `c224225695.lua`, `c224751741.lua`, `c225091736.lua`, `c225106953.lua`, `c226903348.lua`, `c229499914.lua`, `c229786055.lua`, `c231129918.lua`, `c240299292.lua`, `c241056746.lua`, `c241543138.lua`, `c242009896.lua`, `c244408495.lua`, `c244921711.lua`, `c245400676.lua`, `c245970073.lua`, `c246380598.lua`, `c247789143.lua`, `c248453205.lua`, `c253552927.lua`, `c255277197.lua`, `c257549955.lua`, `c259028576.lua`, `c259057226.lua`, `c259177849.lua`, `c259219942.lua`, `c259394179.lua`, `c259417461.lua`, `c259475154.lua`, `c259500899.lua`, `c259578863.lua`, `c259586445.lua`, `c259655976.lua`, `c259718504.lua`, `c259796760.lua`, `c259911246.lua`, `c259934756.lua`.

This ledger is the only non-Lua lane artifact. Lane A intentionally did not edit DBs, installers, zips, installed Omega files, or `dist`; the root integration pass owns synchronization.

## Verification

- `luac -p` on all 172 lane scripts: **PASS (172/172)**.
- Standalone `initial_effect` smoke harness on all 172 lane scripts: **PASS (172/172)**.
- Public DB `datas`/`texts` presence, exact `cards.json` name/text, and every referenced `aux.Stringid(id,n)`: **PASS (172/172; 0 missing/mismatched messages)**.
- Loader scan (`require`, `dofile`, `loadfile` in card scripts): **PASS (none)**.
- Cost/target separation scan (no movement/payment inside `*tg`; no `SelectTarget` inside `*cost`): **PASS**.
- Hardcoded 7–9 digit ID resolution against all custom passcodes, official Omega scripts, and helper-token rows: **PASS**. `217700539`, `222257686`, and `240299293` are valid DB helper rows; official Conductor of Nephthys is `8454126`.
- `git diff --check` for the 47 changed Lua files: **PASS** (only expected Git LF/CRLF notices).

## Highest-priority live-engine tests

1. All custom Frute face-down Extra Deck/Link/Ritual summon prompts and End Phase restoration.
2. Domestica extra hand Tribute, optional Tribute Fusion, and contact-Fusion selection.
3. Ursarctic replacement costs and non-Synchro Extra Deck procedures.
4. Grand Blue post-Fusion “using Grand Blue monsters as materials” restriction; current engine representation is an approximation.
5. Sacred Feather Deck Ritual material and face-up Continuous Trap placement with full zones.
6. To Proto column zone masks, paired banishment, custom Galaxy race, token-as-material, and 100-LP-increment payment UI.
7. Stellaer Link-as-Level Synchro UI, attached-card detach redirect, face-up S/T Set behavior, and phase-only negation persistence into the GY.
8. Copied activation/Standby effects (`Stained Avatar`, `A Stainless Story`, `Priestess of Nephthys`) as the available card pool changes.
9. Operation-info classifiers on `Frozen Girl & Blood Moon` and `Ghost Doll & Midnight Manor`.
10. Concurrent chain-rewrite cases for `Clock of Aldrez`, plus quoted-pronoun ownership for Rage/Eldora/Dysmandr effects.

## ultimate_audit_lane_b.md Primary Auditor Findings
# Ultimate Omega audit — lane B

Scope: `src/data/cards.json` ordinals **173–390** (zero-based indices 172–389), 218 cards from **Phantasm Spiral Shrine** through **Crewal Sailor**. Every printed clause was compared to its standalone `c<ID>.lua` implementation and the closest official pattern in `tmp/omega_scripts`. No DB, ZIP, installed-Omega, `dist`, source-data, or out-of-lane files were edited in this lane.

## Result

- 218/218 mapped cards have public standalone scripts.
- 685 explicit `RegisterEffect` calls were audited, plus procedure registrations.
- 39 scripts received confirmed fixes.
- Lane syntax: 218/218 pass.
- Full public script-folder syntax: 592/592 pass.
- Lightweight `initial_effect` load/registration smoke: 218/218 pass.
- DB audit: no missing card rows or metadata mismatch in the supplied audit; 165 blank `aux.Stringid` slots across 70 lane cards remain and exact proposed text is listed below for central integration.
- AST re-scan completed: the remaining lane hits are deliberate summon-procedure costs, official replacement-target mutations, or Shaman's explicit copied-target relation lifecycle.

## Confirmed changes

- Cost/target/operation separation: moved Pedicaes Papa's Deck send, Coulomb's hand send, and Phlogiston's Wake LP payment into cost callbacks.
- Success sequencing: Windborne Swiftsurfer/Cloudwing now exclude themselves, require a legal hand shuffle, count only cards actually returned, clean kept groups, and schedule the next-Standby effect only after the shuffle and summon succeed; Last Stand counts only operated cards that reached Deck/Extra.
- Mandatory timing: corrected forced triggers on Knight Puppet, Divine Phoenix, Revenge Division, Armada, Companion Team, all five base Ohmen traversal triggers, Arckcestial Fireball/Meadow, Vazagiel, Dreadful Soul Drain, Hallo Hollow, Candee Hex, and Pumpki-Pal.
- GY/banishment legality: added face-up removed-card gates where needed; added Necrovalley gates to Witch, Chapter, Orb, Absolute Supremacy, and four GY summon procedures.
- Official semantics: True Orchis now checks original-name identity; Chapter tracks only the exact sent Extinction card; Orb marks its discard correctly and checks `IsCanOverlay`; Shaman uses the official copied-activation precheck/resolution flags; Absolute Supremacy filters legal matching GY cards; Coulomb uses exact Link-Rating subgroups; Bael uses official `GetSummonType` leave-field state; Bhodi relies on `Effect.CreateEffect(c)` ownership instead of unsupported `SetOwner`.
- Shared limit: Witch of Crying Chaos now puts both printed effects in the same "only 1 effect per turn" bucket.

Changed public scripts (exact files):

`c216258796.lua`, `c217029078.lua`, `c219826457.lua`, `c220305422.lua`, `c221924008.lua`, `c223750159.lua`, `c224811863.lua`, `c228169392.lua`, `c228386117.lua`, `c228860650.lua`, `c230812008.lua`, `c231331942.lua`, `c232824319.lua`, `c234178973.lua`, `c236616849.lua`, `c236721134.lua`, `c236815197.lua`, `c240104048.lua`, `c240976976.lua`, `c241504188.lua`, `c241868535.lua`, `c241957394.lua`, `c244959812.lua`, `c245354354.lua`, `c247779405.lua`, `c249629457.lua`, `c251191343.lua`, `c252496004.lua`, `c258576611.lua`, `c258590942.lua`, `c259072745.lua`, `c259107906.lua`, `c259174227.lua`, `c259366591.lua`, `c259471193.lua`, `c259527622.lua`, `c259650132.lua`, `c259726853.lua`, `c259881255.lua`.

## Official reference key

The per-card ledger uses these keys. Each key expands to exact files inspected in the official Omega corpus:

- **CORE** — common trigger/cost/target/operation structure: `c11248645.lua`, `c102380.lua`.
- **NV** — Graveyard/banishment and Necrovalley-sensitive movement: `c11248645.lua`, `c11335209.lua`, `c100259006.lua`.
- **NEG** — effect/activation negation and activated-card removal: `c100201001.lua`, `c101208206.lua`, `c14799437.lua`, `c23440231.lua`.
- **COPY** — copied activation/effect forwarding: `c70369116.lua`, `c23153227.lua`, `c43331750.lua`, `c97769122.lua`.
- **FUS** — Fusion material selection and summon completion: `c101304094.lua`, `procedure.lua`.
- **XYZ** — overlay legality/material attachment: `c10443957.lua`, `c101203048.lua`, `c100259006.lua`.
- **SYN** — fixed-material/mixed-material Synchro procedures: `c1980574.lua`, `c16769305.lua`, `procedure.lua`.
- **LINK** — Link material and exact Link-Rating subgroup selection: `c101304087.lua`, `procedure.lua`.
- **TOP** — top-of-Deck group/reveal/operation patterns: `c100213003.lua`, `c10321588.lua`.
- **SETTURN** — setting cards and granting same-turn Quick-Play/Trap activation: `c50237654.lua`, `c58019984.lua`, `c79387392.lua`, `c97462632.lua`.
- **DELAY** — phase scheduling, kept groups, and label objects: `c17132130.lua`, `c42081767.lua`, `c48658295.lua`.
- Original-name comparison additionally used `c10000040.lua` and `c100256003.lua`.
- Replacement effects additionally used `c100250208.lua` and `c12081875.lua`.
- Chain-operation rewriting additionally used `c100259009.lua`, `c101203003.lua`, and `c10131855.lua`.
- Leave-field summon-type state and effect ownership additionally used `c101204079.lua` and the corpus-wide `Effect.CreateEffect(c)` / `Effect.GetOwner()` pattern.
- Official Ghoti mixed Synchro behavior additionally used `c72309040.lua`.

## Focused Necrovalley candidate resolution

- **174 Phantasm Spiral Ensnarement** — GY occurrence is the handler's `aux.bfgcost`; it does not select or resolve an effect on a GY card. Official scripts use the same cost helper, including `c100211099.lua` and `c100256007.lua`.
- **216 Hunter of Crying Chaos** — the GY is counted by a continuous ATK value and the handler banishes itself as cost. No effect moves another GY card; `IsAbleToRemoveAsCost` supplies cost legality. Official direct GY-removal costs include `c1187243.lua` and `c12930501.lua`.
- **231 Windborne Cartographer** — `LOCATION_GRAVE` appears only in the material-trigger condition verifying where the handler arrived. The resolving search acts on the Deck.
- **257 Let's Go, Shining Brigade!** — the only GY movement is the standard `aux.bfgcost`; the search itself acts on the Deck.
- **274 Eridani, Squire of Zephorion Prime** — GY cards are only inspected for name/presence and receive temporary protection; no card leaves the GY.
- **275 The Spires of Zephorion Prime** — the GY range only applies `EFFECT_ADD_CODE`; activation/search/replacement operations use field or Deck cards.
- **279 Aquamarine Plate Montipora** — the handler leaves the GY through `aux.bfgcost`; Fusion material selection begins afterward and uses `Duel.GetFusionMaterial`, not the GY handler.
- **326 Curryboh** — the handler banishes itself as activation cost, then the effect only targets a field monster. This follows the official direct GY-cost idiom; no resolving effect accesses the GY.
- **327 Starry Knight Arc-En-Ciel** — returning the handler is the printed activation cost. The resolution Normal Summons from hand/field; it does not move a GY card by effect. Official cost functions likewise rely on `IsAbleToHandAsCost` and `Duel.SendtoHand(...,REASON_COST)`.
- **333 Gaia the Magnificent Knight** — `LOCATION_GRAVE` only verifies that the Deck-send succeeded before the Deck search; the effect never selects a card out of the GY.

Result: all ten are false positives for missing `aux.NecroValleyFilter`; adding an effect-resolution filter would misclassify costs, presence checks, or destination checks.

## Per-card effect ledger

"All printed clauses" means every individual sentence/bullet/condition/cost/target/follow-up was checked, including passive restrictions and summon procedures. "Registration sites" is a compact trace count, not a substitute for the printed-clause review.

| Ordinal | Omega ID | Card | Effect coverage | Result | Official pattern family |
|---:|---:|---|---|---|---|
| 173 | 237917359 | Phantasm Spiral Shrine | All printed clauses; 3 explicit registration sites | pass | NV |
| 174 | 222875833 | Phantasm Spiral Ensnarement | All printed clauses; 3 explicit registration sites | pass | NV |
| 175 | 226063408 | Grand Puppet of Wicked Puppeteer | All printed clauses; 4 explicit registration sites | pass | NV |
| 176 | 259527622 | Knight Puppet of Wicked Puppeteer | All printed clauses; 4 explicit registration sites | fixed | NV |
| 177 | 233659599 | Minion Puppets of Wicked Puppeteer | All printed clauses; 2 explicit registration sites | pass | NV |
| 178 | 257464336 | Guardian of Wicked Puppeteer | All printed clauses; 2 explicit registration sites | pass | NV |
| 179 | 234178973 | The True Wicked Puppeteer, Orchis | All printed clauses; 4 explicit registration sites | fixed | NV |
| 180 | 236818346 | Wicked Puppeteer, Orchis | All printed clauses; 3 explicit registration sites | pass | NV |
| 181 | 243306841 | Wicked Puppeteer Tragedy | All printed clauses; 2 explicit registration sites | pass | NV |
| 182 | 219150610 | Wicked Puppeteery | All printed clauses; 3 explicit registration sites | pass | NV |
| 183 | 244959812 | Divine Phoenix of Nephthys | All printed clauses; 3 explicit registration sites | fixed | NV, DELAY |
| 184 | 234818744 | Primite Dragon Citrine | All printed clauses; 0 explicit registration sites | pass | CORE |
| 185 | 241868535 | Pedicaes Papa | All printed clauses; 4 explicit registration sites | fixed | NV |
| 186 | 215984744 | Vir Pedicae Mortis - Entity's Happy Servant | All printed clauses; 3 explicit registration sites | pass | NV |
| 187 | 244778917 | Vir Pedicae Mortis - Fearless Hunter | All printed clauses; 2 explicit registration sites | pass | LINK |
| 188 | 243144691 | Vir Pedicae Mortis - the Unhallowed Warden | All printed clauses; 3 explicit registration sites | pass | NV, LINK |
| 189 | 233103500 | Vir Pedicae Mortis - True Nightmare | All printed clauses; 2 explicit registration sites | pass | NV, LINK |
| 190 | 236744343 | Entity's Realm - Pedicae Estate | All printed clauses; 5 explicit registration sites | pass | NV |
| 191 | 211086520 | Recollection: Static, Lead, and Nerve | All printed clauses; 1 explicit registration sites | pass | CORE |
| 192 | 234984156 | Recollection: a Lesson in Iron | All printed clauses; 4 explicit registration sites | pass | CORE |
| 193 | 231872299 | Recollection: the Mine | All printed clauses; 3 explicit registration sites | pass | NV |
| 194 | 241447408 | Recollection: Kaboom Papa | All printed clauses; 1 explicit registration sites | pass | CORE |
| 195 | 229875953 | Teleum Mortis | All printed clauses; 4 explicit registration sites | pass | CORE |
| 196 | 251699681 | Bear Trap | All printed clauses; 6 explicit registration sites | pass | NEG, NV |
| 197 | 219543855 | Securitake Agent | All printed clauses; 4 explicit registration sites | needs manual ruling | NEG, NV, LINK |
| 198 | 226645052 | Harmony Pearlwood & the Nautical Deepwaters | All printed clauses; 5 explicit registration sites | pass | CORE |
| 199 | 228040066 | Melody Merheart & the Nautical Coral Reef | All printed clauses; 4 explicit registration sites | pass | NV |
| 200 | 214349717 | Emma Oceannus & the Nautical Coastlines | All printed clauses; 4 explicit registration sites | pass | XYZ |
| 201 | 259114562 | Bobbie Bluefin & the Nautical Nocturnes | All printed clauses; 8 explicit registration sites | pass | NEG, COPY |
| 202 | 220749574 | Scarlet Seareef & the Nautical Creatures | All printed clauses; 7 explicit registration sites | needs manual ruling | NV, XYZ |
| 203 | 225109525 | Evander Coldwater & the Nautical Abyss | All printed clauses; 3 explicit registration sites | pass | XYZ |
| 204 | 223158720 | Nautical Backwashing & Oceanic Waves | All printed clauses; 3 explicit registration sites | pass | NV, COPY |
| 205 | 238711686 | Melissa Oceanheart & the Nautical Seabed | All printed clauses; 3 explicit registration sites | pass | XYZ |
| 206 | 248946297 | Exploring the Nautical Waters | All printed clauses; 4 explicit registration sites | pass | NEG, COPY |
| 207 | 218905439 | Nautical Adventures & Torrential Seas | All printed clauses; 4 explicit registration sites | pass | NV, XYZ, COPY |
| 208 | 259722826 | Bob | All printed clauses; 0 explicit registration sites | pass | CORE |
| 209 | 259944943 | Bob, but Stronger! | All printed clauses; 4 explicit registration sites | pass | NV |
| 210 | 221047295 | Bookkeeper of Crying Chaos | All printed clauses; 2 explicit registration sites | pass | NV, SYN |
| 211 | 233436485 | Crow of Crying Chaos | All printed clauses; 0 explicit registration sites | pass | CORE |
| 212 | 217118040 | Plague Doctor of Crying Chaos | All printed clauses; 3 explicit registration sites | pass | NV |
| 213 | 218261525 | Scarecrow of Crying Chaos | All printed clauses; 2 explicit registration sites | pass | NV, SYN, LINK |
| 214 | 236017388 | Slug of Crying Chaos | All printed clauses; 4 explicit registration sites | pass | NV, SYN |
| 215 | 240976976 | Witch of Crying Chaos | All printed clauses; 3 explicit registration sites | fixed | NV, SYN |
| 216 | 240511702 | Hunter of Crying Chaos | All printed clauses; 2 explicit registration sites | pass | NV |
| 217 | 252513554 | Guardian of Crying Chaos | All printed clauses; 3 explicit registration sites | pass | NV |
| 218 | 224943273 | Goat of Crying Chaos | All printed clauses; 2 explicit registration sites | pass | NV, LINK |
| 219 | 227610954 | Zenatil, Criminal Bookkeeper of Crying Chaos | All printed clauses; 3 explicit registration sites | pass | NV, SYN, LINK |
| 220 | 239725695 | Zebra of Crying Chaos | All printed clauses; 2 explicit registration sites | pass | NV, SYN |
| 221 | 249018041 | Ram of Crying Chaos | All printed clauses; 3 explicit registration sites | pass | NV, SYN |
| 222 | 220305422 | Natir, the Swords Master of Crying Chaos | All printed clauses; 2 explicit registration sites | fixed | NEG, NV, SYN |
| 223 | 234296128 | Revelation of Crying Chaos | All printed clauses; 2 explicit registration sites | pass | NEG, NV, SYN |
| 224 | 241880822 | Chrono-Saur Raptor | All printed clauses; 4 explicit registration sites | pass | NV |
| 225 | 233499093 | Dragon of Crying Chaos | All printed clauses; 2 explicit registration sites | pass | NEG, NV, SYN |
| 226 | 247779405 | Windborne Swiftsurfer | All printed clauses; 4 explicit registration sites | fixed | SYN, SETTURN, DELAY |
| 227 | 258241424 | Light Within the Crying Chaos | All printed clauses; 2 explicit registration sites | pass | NV |
| 228 | 217029078 | Windborne Cloudwing | All printed clauses; 4 explicit registration sites | fixed | SYN, SETTURN, DELAY |
| 229 | 216294702 | A Throne of Crying Chaos | All printed clauses; 2 explicit registration sites | pass | NV |
| 230 | 255953418 | A World of Crying Chaos | All printed clauses; 3 explicit registration sites | pass | NV, SYN |
| 231 | 221759221 | Windborne Cartographer | All printed clauses; 5 explicit registration sites | pass | NV, SYN, SETTURN, DELAY |
| 232 | 253472430 | A Whisper of Crying Chaos | All printed clauses; 6 explicit registration sites | pass | NEG, NV, SYN |
| 233 | 215068354 | Janna, Windborne Goddess of the Temple | All printed clauses; 4 explicit registration sites | pass | NV, SETTURN, DELAY |
| 234 | 257794541 | Maryam, Windborne Caretaker of the Temple | All printed clauses; 4 explicit registration sites | pass | NV, SETTURN, DELAY |
| 235 | 251571153 | Sunken Temple of the Windborne | All printed clauses; 3 explicit registration sites | pass | DELAY |
| 236 | 231273040 | Windborne Howling Gale | All printed clauses; 1 explicit registration sites | pass | CORE |
| 237 | 256110263 | Windborne Eye of the Storm | All printed clauses; 1 explicit registration sites | needs manual ruling | NV, SYN, DELAY |
| 238 | 238064522 | Windborne Galesong Flock | All printed clauses; 1 explicit registration sites | pass | CORE |
| 239 | 233212369 | Windborne Divine Whirlwind | All printed clauses; 1 explicit registration sites | pass | NV, DELAY |
| 240 | 215006791 | Muntith, Windborne Skydragon of the Shining Sun | All printed clauses; 4 explicit registration sites | pass | NV, SYN, DELAY |
| 241 | 237684285 | Janna, Windborne Goddess of Clement Winds | All printed clauses; 3 explicit registration sites | pass | NV, SYN, DELAY |
| 242 | 224774049 | Pot of Gambling | All printed clauses; 1 explicit registration sites | needs manual ruling | TOP |
| 243 | 255686110 | Iscylla, Windborne Kraken of Sunken Depths | All printed clauses; 8 explicit registration sites | pass | NV, SYN |
| 244 | 215885404 | Pot of Fortune | All printed clauses; 1 explicit registration sites | pass | NV |
| 245 | 243194249 | Shining Brigade - Hope Division | All printed clauses; 4 explicit registration sites | pass | NV |
| 246 | 232038002 | Shining Brigade - Forward Division | All printed clauses; 3 explicit registration sites | pass | NEG, NV |
| 247 | 232100722 | Shining Brigade - Flowering Division | All printed clauses; 2 explicit registration sites | pass | NV |
| 248 | 230812008 | Shining Brigade - Loving Division | All printed clauses; 3 explicit registration sites | fixed | NV |
| 249 | 220124524 | Shining Brigade - Heartbeat Division | All printed clauses; 5 explicit registration sites | pass | NV, XYZ |
| 250 | 255668557 | Shining Brigade - Joyous Division | All printed clauses; 4 explicit registration sites | pass | NV |
| 251 | 243420199 | Shining Brigade - Melody Division | All printed clauses; 2 explicit registration sites | pass | NV, XYZ |
| 252 | 236616849 | Shining Brigade - Revenge Division | All printed clauses; 5 explicit registration sites | fixed | NV, XYZ, DELAY |
| 253 | 223750159 | Shining Brigade Armada | All printed clauses; 4 explicit registration sites | fixed | NEG, NV, XYZ |
| 254 | 244986323 | Shining Brigade Origins | All printed clauses; 6 explicit registration sites | pass | NV, XYZ |
| 255 | 232824319 | Shining Brigade - Companion Team | All printed clauses; 3 explicit registration sites | fixed | CORE |
| 256 | 241504188 | Shining Brigade - Absolute Supremacy | All printed clauses; 2 explicit registration sites | fixed | NEG, NV, DELAY |
| 257 | 238841732 | Let's Go, Shining Brigade! | All printed clauses; 2 explicit registration sites | pass | NV |
| 258 | 226827770 | The One Called Forth | All printed clauses; 1 explicit registration sites | pass | NEG |
| 259 | 215142357 | Shining Brigade - Stand Together! | All printed clauses; 5 explicit registration sites | pass | NV, XYZ |
| 260 | 238976759 | We're the Shining Brigade! | All printed clauses; 2 explicit registration sites | pass | NV, XYZ |
| 261 | 237692523 | Pixie Bot | All printed clauses; 2 explicit registration sites | pass | NV, LINK |
| 262 | 249629457 | Shining Brigade - Last Stand | All printed clauses; 3 explicit registration sites | fixed | NEG, NV, DELAY |
| 263 | 234507067 | Chrono-Saur Brachio | All printed clauses; 3 explicit registration sites | pass | NV |
| 264 | 235637994 | Chrono-Saur Dactylus | All printed clauses; 5 explicit registration sites | pass | NEG, NV |
| 265 | 259235389 | Chrono-Saur Tricera | All printed clauses; 4 explicit registration sites | pass | NEG, NV |
| 266 | 255048812 | Chrono-Saur Stegian | All printed clauses; 3 explicit registration sites | pass | NV |
| 267 | 236898203 | Chrono-Saur Rex | All printed clauses; 2 explicit registration sites | pass | NV |
| 268 | 251236672 | Chrono-Saur Laplace Plesio | All printed clauses; 5 explicit registration sites | pass | CORE |
| 269 | 259226793 | Chrono-Saur Force | All printed clauses; 3 explicit registration sites | pass | NEG |
| 270 | 213530841 | Chrono-Saur Counter | All printed clauses; 3 explicit registration sites | pass | NEG |
| 271 | 253928485 | Aqua Whirlpool | All printed clauses; 1 explicit registration sites | pass | FUS |
| 272 | 259366507 | Aquila, Zephorion's Predictor | All printed clauses; 5 explicit registration sites | pass | NV |
| 273 | 257081514 | Auriga of the Eldoran Empire | All printed clauses; 5 explicit registration sites | pass | NV |
| 274 | 213990492 | Eridani, Squire of Zephorion Prime | All printed clauses; 3 explicit registration sites | pass | NV |
| 275 | 244972185 | The Spires of Zephorion Prime | All printed clauses; 3 explicit registration sites | pass | NV |
| 276 | 241957394 | Chapter Ii Verse Iv | All printed clauses; 1 explicit registration sites | fixed | NV, COPY, DELAY |
| 277 | 212737555 | Aqua Droplet | All printed clauses; 2 explicit registration sites | pass | NV |
| 278 | 238035167 | Aquamarine Moon Aurelia | All printed clauses; 3 explicit registration sites | pass | NV, FUS |
| 279 | 220150285 | Aquamarine Plate Montipora | All printed clauses; 3 explicit registration sites | pass | NV, FUS |
| 280 | 211682274 | Aquamarine Pisaster Giga | All printed clauses; 3 explicit registration sites | pass | NV |
| 281 | 251191343 | Aquamarine Asthenosoma | All printed clauses; 3 explicit registration sites | fixed | NV |
| 282 | 221509060 | Aquamarine Calling | All printed clauses; 1 explicit registration sites | pass | CORE |
| 283 | 259998396 | Treasure of the Cosmic Ocean | All printed clauses; 1 explicit registration sites | pass | CORE |
| 284 | 227035644 | Aqua Fusion | All printed clauses; 2 explicit registration sites | pass | NV, FUS |
| 285 | 255082735 | Aquamarine Bubble Surge | All printed clauses; 2 explicit registration sites | pass | FUS |
| 286 | 250339529 | Aquamarine Planktonites | All printed clauses; 2 explicit registration sites | pass | NV, FUS |
| 287 | 241976572 | Aquamarine Nautilus | All printed clauses; 4 explicit registration sites | pass | NV |
| 288 | 216258796 | Aquamarine Actinia | All printed clauses; 2 explicit registration sites | fixed | NEG, NV |
| 289 | 249746105 | Aquamarine Physalia | All printed clauses; 1 explicit registration sites | pass | NV, FUS |
| 290 | 225161820 | Aquamarine Glaucus | All printed clauses; 4 explicit registration sites | pass | NV, FUS |
| 291 | 259920959 | Aquamarine Reef Hapalochlaena | All printed clauses; 3 explicit registration sites | pass | NV, FUS |
| 292 | 258260221 | Hiding "c" | All printed clauses; 3 explicit registration sites | pass | NV |
| 293 | 259174227 | Farad, the Purple Ohmen | All printed clauses; 2 explicit registration sites | fixed | NV, LINK |
| 294 | 259726853 | Volt, the Green Ohmen | All printed clauses; 2 explicit registration sites | fixed | LINK |
| 295 | 259650132 | Ampere, the Yellow Ohmen | All printed clauses; 3 explicit registration sites | fixed | LINK |
| 296 | 259107906 | Siemens, the Blue Ohmen | All printed clauses; 2 explicit registration sites | fixed | LINK |
| 297 | 259881255 | Coulomb, the White Ohmen | All printed clauses; 3 explicit registration sites | fixed | NV, LINK |
| 298 | 259780273 | Carcel, the Dark Ohmen | All printed clauses; 2 explicit registration sites | needs manual ruling | CORE |
| 299 | 259869259 | Ohmen Surge | All printed clauses; 3 explicit registration sites | needs manual ruling | LINK, COPY |
| 300 | 259405917 | Siemens, the Ohmechanic Conductor | All printed clauses; 4 explicit registration sites | needs manual ruling | NV, LINK |
| 301 | 259350270 | Farad, the Ohmechanic Capacitor | All printed clauses; 4 explicit registration sites | needs manual ruling | NV, LINK |
| 302 | 259519336 | Volt, the Ohmechanic Chocker | All printed clauses; 4 explicit registration sites | needs manual ruling | COPY |
| 303 | 259841490 | Coulomb, the Ohmechanic Charger | All printed clauses; 4 explicit registration sites | needs manual ruling | LINK |
| 304 | 259479044 | Ampere, the Ohmechanic Intensity | All printed clauses; 5 explicit registration sites | needs manual ruling | LINK |
| 305 | 259033429 | Carcel, the Ohmechanic Light | All printed clauses; 4 explicit registration sites | needs manual ruling | NV, LINK, COPY |
| 306 | 259434499 | Ohmen Powerload | All printed clauses; 3 explicit registration sites | needs manual ruling | NEG |
| 307 | 259650969 | Ohmen Beacon | All printed clauses; 3 explicit registration sites | needs manual ruling | NV, LINK |
| 308 | 245452058 | Altergeist Pipesiren | All printed clauses; 4 explicit registration sites | pass | NV |
| 309 | 211873618 | Altergeist Regissae | All printed clauses; 6 explicit registration sites | pass | NEG, NV, LINK |
| 310 | 252552954 | Altergeist Ifritware | All printed clauses; 2 explicit registration sites | pass | NEG, NV, SYN |
| 311 | 259152704 | Dragon Protector of Nature | All printed clauses; 3 explicit registration sites | pass | NV, SYN |
| 312 | 212055290 | Advent of Cosmic Beings | All printed clauses; 1 explicit registration sites | pass | CORE |
| 313 | 259225324 | Transcend the Pendulum | All printed clauses; 2 explicit registration sites | pass | LINK |
| 314 | 250902476 | Striking Mirror Force | All printed clauses; 2 explicit registration sites | pass | CORE |
| 315 | 228464260 | Rising Elemental | All printed clauses; 3 explicit registration sites | pass | NV, SYN |
| 316 | 253152295 | Yummy Kuriboh | All printed clauses; 2 explicit registration sites | pass | NEG, NV |
| 317 | 256207361 | Sealed Glyphs Dragon | All printed clauses; 3 explicit registration sites | pass | XYZ |
| 318 | 236721134 | Devotee of Fire | All printed clauses; 6 explicit registration sites | fixed | NEG, NV |
| 319 | 224811863 | Shaman of Fire | All printed clauses; 3 explicit registration sites | fixed | NV, COPY |
| 320 | 240104048 | Guardian of Fire | All printed clauses; 3 explicit registration sites | fixed | NV |
| 321 | 257239133 | Phlogistic Uprising! | All printed clauses; 3 explicit registration sites | needs manual ruling | NV, FUS |
| 322 | 219714894 | Phlogistic Ignition | All printed clauses; 4 explicit registration sites | pass | NV |
| 323 | 236815197 | Phlogiston's Wake | All printed clauses; 3 explicit registration sites | fixed | NV |
| 324 | 242094473 | Phlogiston Dragon | All printed clauses; 6 explicit registration sites | pass | NV |
| 325 | 230303021 | Phlogistic Scorching Dragon Horde | All printed clauses; 4 explicit registration sites | pass | NV, FUS, COPY |
| 326 | 220538776 | Curryboh | All printed clauses; 2 explicit registration sites | pass | NV |
| 327 | 249805098 | Starry Knight Arc-En-Ciel | All printed clauses; 2 explicit registration sites | pass | NEG, NV |
| 328 | 238241974 | Starry Knight Nebriel | All printed clauses; 3 explicit registration sites | pass | NV |
| 329 | 248760718 | Starry Knight Starry Queen | All printed clauses; 4 explicit registration sites | pass | NV, SETTURN |
| 330 | 221924008 | Chamroshes' Aegis | All printed clauses; 5 explicit registration sites | fixed | NV, SYN |
| 331 | 212413422 | Gaia, the Iron Clad Knight | All printed clauses; 5 explicit registration sites | pass | NV, FUS, DELAY |
| 332 | 238256111 | Cursed Dragon of the Knight | All printed clauses; 3 explicit registration sites | pass | NV |
| 333 | 222476063 | Gaia the Magnificent Knight | All printed clauses; 4 explicit registration sites | pass | NV |
| 334 | 223770816 | Blazing Gaia the Spiral Knight | All printed clauses; 5 explicit registration sites | pass | NV, FUS, COPY |
| 335 | 256469525 | Dynatos, the Challenger | All printed clauses; 5 explicit registration sites | pass | COPY |
| 336 | 259366591 | Arckcestial Crystal Shards | All printed clauses; 2 explicit registration sites | fixed | NV, SYN |
| 337 | 241440521 | Arckcestial Feather | All printed clauses; 3 explicit registration sites | pass | NV, SYN |
| 338 | 245354354 | Arckcestial Fireball | All printed clauses; 3 explicit registration sites | fixed | NV, SYN |
| 339 | 228860650 | Arckcestial Orb | All printed clauses; 2 explicit registration sites | fixed | NV, XYZ |
| 340 | 214511076 | Arckcestial Prism | All printed clauses; 2 explicit registration sites | pass | NV, SYN |
| 341 | 258328859 | Arckcestial Descend | All printed clauses; 3 explicit registration sites | pass | NV |
| 342 | 258590942 | Arckcestial Meadow | All printed clauses; 3 explicit registration sites | fixed | NV |
| 343 | 235051716 | Arckcestial Pillar of Heavens | All printed clauses; 3 explicit registration sites | pass | NV |
| 344 | 228635967 | Rank-Up-Magic Key of Arck Celestial Force | All printed clauses; 2 explicit registration sites | pass | NV, XYZ |
| 345 | 235612490 | Urphiel's Feather Downpour | All printed clauses; 2 explicit registration sites | needs manual ruling | NV |
| 346 | 239235967 | Arckcestial Burning | All printed clauses; 2 explicit registration sites | pass | NV, SYN |
| 347 | 219995840 | Light Illusion of Vazagiel | All printed clauses; 2 explicit registration sites | pass | NV, SYN |
| 348 | 257176166 | Malphiel, Arckcestial of Protection | All printed clauses; 4 explicit registration sites | pass | NV, XYZ, SYN, COPY |
| 349 | 228386117 | Vazagiel, Arckcestial of Secrets | All printed clauses; 4 explicit registration sites | fixed | NV, XYZ, SYN, COPY |
| 350 | 237089049 | Azeriel, Arckcestial of Demise | All printed clauses; 4 explicit registration sites | pass | NV, XYZ, SYN |
| 351 | 251710981 | Ophiel, Arckcestial of Wisdom | All printed clauses; 3 explicit registration sites | pass | NV, XYZ |
| 352 | 231089172 | Sarifiel, Arckcestial of Moonlight | All printed clauses; 2 explicit registration sites | pass | NV, XYZ |
| 353 | 215105971 | Urphiel, the High Arckcestial | All printed clauses; 3 explicit registration sites | pass | NEG, NV, XYZ |
| 354 | 220856437 | Bauy Magician | All printed clauses; 3 explicit registration sites | pass | NV, SYN, LINK |
| 355 | 250047045 | Dreaming Bau | All printed clauses; 2 explicit registration sites | pass | NV, SYN |
| 356 | 219826457 | Ro-Bau | All printed clauses; 6 explicit registration sites | fixed | NV, COPY |
| 357 | 221511784 | Bau | All printed clauses; 4 explicit registration sites | pass | NV, DELAY |
| 358 | 237444604 | Winged Bauy Fenrir | All printed clauses; 2 explicit registration sites | pass | NEG, NV, SYN |
| 359 | 256462992 | Starfury Bauy Dragon | All printed clauses; 3 explicit registration sites | pass | NV, SYN |
| 360 | 228169392 | Bael, Demon Incarnate | All printed clauses; 5 explicit registration sites | fixed | NV, XYZ |
| 361 | 226950506 | Bauy World | All printed clauses; 3 explicit registration sites | pass | NV, LINK |
| 362 | 254215159 | Bauy Spellcasting | All printed clauses; 5 explicit registration sites | pass | NEG, NV, SETTURN |
| 363 | 225358630 | Rai-Bau | All printed clauses; 4 explicit registration sites | pass | NEG, NV, SETTURN |
| 364 | 223366685 | Bauy Emergency Room! | All printed clauses; 4 explicit registration sites | pass | NV |
| 365 | 259072745 | Bhodi, the Corrupted Halloween Tree | All printed clauses; 6 explicit registration sites | fixed | NEG, NV, FUS |
| 366 | 233957828 | Toddler Pumpkien | All printed clauses; 2 explicit registration sites | pass | NV, LINK |
| 367 | 259471193 | Dreadful Soul Drain | All printed clauses; 2 explicit registration sites | fixed | NV |
| 368 | 212822164 | Bray, Shell of the Ghoti | All printed clauses; 2 explicit registration sites | pass | NV |
| 369 | 235352857 | Shekup, Sting of the Ghoti | All printed clauses; 5 explicit registration sites | pass | NV, DELAY |
| 370 | 240575550 | Ghoti from a Deeper Depth Than the Deepest Deep | All printed clauses; 4 explicit registration sites | needs manual ruling | NV, SYN, COPY |
| 371 | 255283389 | Myutant El-51 | All printed clauses; 2 explicit registration sites | pass | NV |
| 372 | 244816828 | Myutant Evolution | All printed clauses; 2 explicit registration sites | pass | NV |
| 373 | 211699737 | Myutant Amalgamate | All printed clauses; 2 explicit registration sites | needs manual ruling | NV, FUS, COPY |
| 374 | 259308265 | Pumpqueen the Queen of Ghosts | All printed clauses; 1 explicit registration sites | needs manual ruling | CORE |
| 375 | 239028111 | Pumprince the Prince of Ghosts | All printed clauses; 4 explicit registration sites | pass | DELAY |
| 376 | 230749983 | Hallo, the Giver of Tricks | All printed clauses; 3 explicit registration sites | pass | NV |
| 377 | 250262550 | Ween, Guidance to Treats | All printed clauses; 4 explicit registration sites | pass | NV |
| 378 | 231331942 | Hallo, the Hollow Trickster | All printed clauses; 3 explicit registration sites | fixed | NV |
| 379 | 224800873 | Hallo-Ween! Basket of Treats | All printed clauses; 2 explicit registration sites | pass | NV |
| 380 | 255977900 | Happy Hallo-Ween! | All printed clauses; 3 explicit registration sites | pass | NV |
| 381 | 215621622 | A Night of Fright on Hallo-Ween! | All printed clauses; 1 explicit registration sites | pass | NV |
| 382 | 221672256 | Skewy! Boo Boo | All printed clauses; 2 explicit registration sites | pass | NEG, NV |
| 383 | 258576611 | Skewy! Candee Hex | All printed clauses; 7 explicit registration sites | fixed | NEG |
| 384 | 252496004 | Skewy! Pumpki-Pal | All printed clauses; 4 explicit registration sites | fixed | NV, TOP |
| 385 | 234592047 | Skewy! Twick-Or-Tweat | All printed clauses; 1 explicit registration sites | pass | CORE |
| 386 | 217632789 | Skewy! Pawty Tyme | All printed clauses; 2 explicit registration sites | pass | NEG, NV |
| 387 | 254375894 | Crewal Cap'n | All printed clauses; 4 explicit registration sites | pass | NV |
| 388 | 237269434 | Crewal Crew | All printed clauses; 4 explicit registration sites | pass | NV |
| 389 | 215730767 | Crewal Helmsman | All printed clauses; 4 explicit registration sites | pass | NV |
| 390 | 250792632 | Crewal Sailor | All printed clauses; 4 explicit registration sites | pass | NV |

## Remaining live-duel/ruling risks

- **Securitake Agent**: opponent-owned material and opponent-GY Link material selection needs real Omega UI validation.
- **Scarlet Seareef & the Nautical Creatures**: the opponent's Normal/Special Summon choice and follow-up timing should be confirmed live.
- **Windborne Eye of the Storm**: the token/proxy technique used to enforce only "Windborne" Synchro material is nonstandard and needs duel validation.
- **Pot of Gambling**: printed text does not state where non-added excavated cards go; the script's Deck return is a ruling assumption.
- **Ohmen traversal suite**: breadth-first co-link traversal, zone masks, movement, counter placement, and multi-monster Extra Deck summons have no single exact official analog; test all five base Ohmen and all Ohmechanic threshold effects live.
- **Devotee of Fire**: source text has a malformed/missing activation clause; the current implementation remains a ruling interpretation.
- **Chapter II Verse IV**: `ChangeChainOperation` rewriting to the sent custom Trap remains card-pool- and target-lifecycle-sensitive.
- **Shaman of Fire**: official copied-activation flags and target relations now match official scripts, but every eligible Phlogiston Spell should be duel-tested.
- **Phlogistic Uprising!**: dynamic Fusion material selection from GY/Extra and post-summon LP handling needs real-engine confirmation.
- **Chamroshes' Aegis**: custom contact Fusion procedure and face-up banished material legality need UI validation.
- **Urphiel's Feather Downpour**: replacement/redirect semantics remain a prior live-test item.
- **Myutant Amalgamate**: `CopyEffect` is an approximation of the custom printed transformation and needs a ruling/live decision.
- **Pumpqueen the Queen of Ghosts**: the Level 4 "Castle of Dark Illusions" extra-Tribute wording is ambiguous.
- **Hallo, the Hollow Trickster**: its named "Hallo, the Spirit of Tricks" dependency is absent from the current mapped card pool.
- **Ghoti from a Deeper Depth Than the Deepest Deep**: custom mixed Synchro/material behavior should be tested against the official Ghoti pattern.

## Proposed blank Stringid messages

These are proposals only; this lane did not edit `scripts/sync_omega_ccg_db.py` or any DB. Each index below is explicit so the root pass can integrate and synchronize centrally.

- `247779405` Windborne Swiftsurfer: [0] "Reveal up to 2 \"Windborne\" Spells"; [1] "Shuffle additional cards from your hand"
- `217029078` Windborne Cloudwing: [0] "Reveal up to 2 \"Windborne\" Spells"; [1] "Shuffle additional cards from your hand"
- `255953418` A World of Crying Chaos: [0] "Add 1 \"Crying Chaos\" monster from your Deck"; [1] "Special Summon"
- `221759221` Windborne Cartographer: [0] "Special Summon"; [1] "Sent to GY as Synchro Material"; [2] "Reveal up to 2 \"Windborne\" Spells"
- `215068354` Janna, Windborne Goddess of the Temple: [0] "Special Summon"; [1] "Send and optional shuffle/set"; [2] "Reveal up to 2 \"Windborne\" Spells"; [3] "Shuffle the sent monster into the Deck and Set its Spell"
- `257794541` Maryam, Windborne Caretaker of the Temple: [0] "Special Summon"; [1] "Add from GY"; [2] "Reveal up to 2 \"Windborne\" Spells"
- `251571153` Sunken Temple of the Windborne: [0] "Add 1 \"Windborne\" card from your Deck"; [1] "Draw"
- `231273040` Windborne Howling Gale: [0] "Special Summon 1 \"Windborne\" monster from your hand"; [1] "Cannot Special Summon non-\"Windborne\" monsters with that Level"
- `256110263` Windborne Eye of the Storm: [0] "Synchro Summon a different \"Windborne\" monster"
- `238064522` Windborne Galesong Flock: [0] "Treat the Token as a Tuner"; [1] "Increase the Token's ATK/DEF"
- `233212369` Windborne Divine Whirlwind: [0] "Special Summon a non-Synchro \"Windborne\" monster"
- `220124524` Shining Brigade - Heartbeat Division: [0] "Special Summon 1 \"Shining Brigade\" from hand"; [1] "Cannot Special Summon from the Extra Deck"; [2] "Banish this card instead"
- `255668557` Shining Brigade - Joyous Division: [0] "Special Summon itself"; [1] "Roll a die and banish cards"
- `243420199` Shining Brigade - Melody Division: [0] "extra summon"; [1] "attach"
- `236616849` Shining Brigade - Revenge Division: [0] "Special Summon"; [1] "attach"; [2] "Double ATK/DEF"
- `223750159` Shining Brigade Armada: [0] "Draw"; [1] "Special Summon"
- `244986323` Shining Brigade Origins: [1] "Attach material"; [2] "Destroy and banish"; [3] "Place in Pendulum Zone"
- `232824319` Shining Brigade - Companion Team: [0] "Special Summon on Attack"
- `241504188` Shining Brigade - Absolute Supremacy: [0] "Negate and banish"
- `238841732` Let's Go, Shining Brigade!: [0] "Special Summon"; [1] "Search"; [2] "Cannot Special Summon except LIGHT monsters"
- `215142357` Shining Brigade - Stand Together!: [0] "Detach and Attach"; [1] "Draw card"
- `238976759` We're the Shining Brigade!: [0] "Apply the optional follow-up"; [1] "Discard and Xyz Summon"; [2] "Optionally attach materials from GY/banished"
- `237692523` Pixie Bot: [0] "Special Summon from hand"; [1] "Banish and Summon Normal Monsters"
- `249629457` Shining Brigade - Last Stand: [0] "Negate effect"; [1] "End Phase Shuffle"
- `234507067` Chrono-Saur Brachio: [0] "Special Summon from hand"; [1] "Search Spell/Trap"; [2] "Revive another on destruction"
- `235637994` Chrono-Saur Dactylus: [0] "Special Summon from hand"; [1] "Destroy cards"; [2] "Revive another on destruction"
- `259235389` Chrono-Saur Tricera: [0] "Special Summon from hand/GY"; [1] "Negate target/attack"; [2] "Negate target/attack"
- `255048812` Chrono-Saur Stegian: [0] "Discard and draw"; [1] "Special Summon from hand"; [2] "Revive another on destruction"; [3] "Destroy 1 card in your hand or field"
- `236898203` Chrono-Saur Rex: [0] "Destroy and Special Summon"; [1] "Special Summon on attack announce"
- `251236672` Chrono-Saur Laplace Plesio: [0] "Add 1 \"Chrono-Saur\" card from your Deck"; [1] "ATK/DEF boost on destruction"; [2] "Destroy card you control after battle"; [3] "Lock"
- `259226793` Chrono-Saur Force: [0] "Destroy a card after negating the activation"; [1] "Draw when destroyed"
- `213530841` Chrono-Saur Counter: [0] "Destroy a card after negating the effect"; [1] "Draw when destroyed"
- `253928485` Aqua Whirlpool: [0] "Opponent cannot Special Summon non-WATER monsters from the hand"
- `259366507` Aquila, Zephorion's Predictor: [0] "Special Summon from hand"; [1] "Set Eldora or Verse IX Chapter II"; [2] "Destroyed effect"; [3] "Add from your GY"; [4] "Add from your Deck"
- `257081514` Auriga of the Eldoran Empire: [0] "Special Summon from hand"; [1] "Draw and bottom deck"; [2] "Destroyed effect"; [3] "Add from your GY"; [4] "Add from your Deck"
- `213990492` Eridani, Squire of Zephorion Prime: [0] "Special Summon from hand"; [1] "Declaration protection on destruction"
- `244972185` The Spires of Zephorion Prime: [0] "Activate \"Eldora, the Intergalactic Empire\""; [1] "Add a monster that lists \"Eldora\""; [2] "Destroy this card instead"
- `241957394` Chapter Ii Verse Iv: [0] "Activate (Rewrite effect)"
- `212737555` Aqua Droplet: [0] "Special Summon from GY"; [1] "Banished draw"
- `238035167` Aquamarine Moon Aurelia: [0] "Special Summon from hand"; [1] "Search Spell/Trap"; [2] "Banish Fusion"
- `220150285` Aquamarine Plate Montipora: [0] "Search monster on Summon"; [1] "Fusion from GY"; [2] "Lock"
- `211682274` Aquamarine Pisaster Giga: [0] "Special Summon from hand"; [1] "Tribute to Special Summon from Deck"; [2] "Add banished to hand"
- `251191343` Aquamarine Asthenosoma: [0] "Special Summon from GY"; [1] "Discard to send to GY"; [2] "Banish return to GY"
- `221509060` Aquamarine Calling: [0] "Lock"
- `259998396` Treasure of the Cosmic Ocean: [0] "Lock"
- `227035644` Aqua Fusion: [1] "Banish from GY to contact fusion"; [2] "Lock"
- `255082735` Aquamarine Bubble Surge: [0] "Continuous effect choice"; [1] "check options"; [2] "check options"
- `250339529` Aquamarine Planktonites: [0] "Special Summon on Summon"; [1] "Fusion Summon during Main Phase"
- `241976572` Aquamarine Nautilus: [0] "Send on Summon"; [1] "Protect from targeting"; [2] "Revive from GY"
- `216258796` Aquamarine Actinia: [0] "Special Summon from GY"; [1] "Negate Quick Effect"
- `249746105` Aquamarine Physalia: [0] "Banish and destroy"
- `225161820` Aquamarine Glaucus: [0] "Banish from GY on Summon"; [1] "ATK reduce Quick Effect"
- `259920959` Aquamarine Reef Hapalochlaena: [0] "Burn damage Quick Effect"
- `258260221` Hiding "c": [0] "Special Summon"; [1] "Search"
- `259174227` Farad, the Purple Ohmen: [0] "BFS and movement"
- `259726853` Volt, the Green Ohmen: [0] "BFS and movement"
- `259650132` Ampere, the Yellow Ohmen: [0] "BFS and movement"; [1] "Search"; [2] "Lock"
- `259107906` Siemens, the Blue Ohmen: [0] "BFS and movement"
- `259881255` Coulomb, the White Ohmen: [0] "BFS and movement"; [1] "Special Summon from Extra Deck"; [2] "Send another \"Ohmen\" card from your hand"
- `259780273` Carcel, the Dark Ohmen: [0] "Special Summon"; [1] "Lock"; [2] "Used as material"
- `259869259` Ohmen Surge: [0] "Control opponent monster on Spell activation"
- `259405917` Siemens, the Ohmechanic Conductor: [0] "GY Special Summon (1+ counters)"; [1] "Move monster (2+ counters)"; [2] "Steal monster (3+ counters)"
- `259350270` Farad, the Ohmechanic Capacitor: [0] "Banish card (1+ counters)"; [1] "Recycle GY/banished (2+ counters)"; [2] "Banish opponent GY (3+ counters)"
- `259519336` Volt, the Ohmechanic Chocker: [0] "Inflict damage (1+ counters)"; [1] "Destroy monster (3+ counters)"
- `259841490` Coulomb, the Ohmechanic Charger: [0] "Move monster (1+ counters)"; [1] "Search Spell/Trap (2+ counters)"; [2] "Link Summon (3+ counters)"
- `259479044` Ampere, the Ohmechanic Intensity: [0] "Search and discard (1+ counters)"; [1] "Place counter on co-linked (2+ counters)"
- `259033429` Carcel, the Ohmechanic Light: [0] "GY Special Summon"; [1] "Destroy opponent's monsters"
- `259434499` Ohmen Powerload: [0] "Negate an opponent's Effect Monster"; [1] "Special Summon an \"Ohmen\" monster from your Deck"; [2] "Remove 2 Current Counters and destroy 1 card"; [3] "Lock"
- `259650969` Ohmen Beacon: [0] "Special Summon a Thunder monster"; [1] "Special Summon from your hand"; [2] "Special Summon an \"Ohmen\" monster from your GY"; [3] "Move monster and place counter"
- `245452058` Altergeist Pipesiren: [0] "Special Summon"; [1] "Search Trap"

## Verification run

- Card/ID/script inventory for ordinals 173–390: **PASS** — 218/218 scripts present; IDs taken from the card manifest/ID map.
- Per-changed-card `luac -p`: **PASS**.
- Lane-wide `luac -p` (218 scripts): **PASS**.
- Full public folder `luac -p`: **PASS**, 592/592.
- Lightweight load + `initial_effect` registration smoke: **PASS**, 218/218.
- `node tmp/ultimate_ast_audit.cjs`: **PASS as audit scan**; 577 cards scanned, 20 broad candidates total, remaining lane candidates manually cleared as documented.
- `tmp/ultimate_db_message_findings.json` verification: **PASS for row/metadata coverage**; **165 blank message slots/70 lane cards remain proposed above**.
- Installed Omega/ZIP/DB/`dist` synchronization, hash parity, and `npm run build`: intentionally deferred to the root integrator because lane agents were instructed not to edit generated mirrors or central DB artifacts.

## ultimate_audit_lane_c.md Primary Auditor Findings
# Ultimate Lua audit — lane C

Scope: exact `cards.json` ordinals 391–577 (187 cards), from Morbydrip the Crewal Whale through Ether Mademoiselle. Each source-text clause and every created Lua effect below was compared with the closest official Omega pattern. Status totals: **99 pass, 79 fixed, 9 need manual ruling**.

Legend: “E1/E2/…” means each separate `Effect.CreateEffect` implementation was independently reviewed, including procedure/protection/helper effects and clones. The reference column lists the primary official-pattern family; additional references used are catalogued after the table.

| Ord. | Card (Omega ID) | Effect-level coverage | Primary official pattern(s) | Result | Note |
|---:|---|---|---|---|---|
| 391 | Morbydrip the Crewal Whale (210628767) | E1/E2/E3/E4 individually checked | c22804644/c101301087; c34124316/c120145032; c10004783/c10632284 | **Pass** | No defect found |
| 392 | Crewal Booty (222654570) | E1/E2/E3 individually checked | c10004783/c10632284 | **Pass** | No defect found |
| 393 | Crewal Meeting (210366076) | E1/E2/E3 individually checked | c10004783/c10632284 | **Pass** | No defect found |
| 394 | Crewal Tide (217645912) | E1/E2/E3 individually checked | c10004783/c10632284 | **Pass** | No defect found |
| 395 | Crewal Attack (219783132) | E1/E2/E3/E4 individually checked | c10004783/c10632284 | **Pass** | No defect found |
| 396 | Crewal Cursed Sea (252249599) | E1/E2/E3/E4/E5/E6 individually checked | procedure.lua + procedure family; c10004783/c10632284 | **Pass** | No defect found |
| 397 | Melville the Crewal Vessel (234599395) | E1/E2/E3/E4 individually checked | procedure.lua + procedure family; c10443957/c101203048; c34124316/c120145032; c10004783/c10632284 | **Pass** | No defect found |
| 398 | Ghostrick Bat (227531376) | E1/E2/E3/E4/E5 individually checked | c10443957/c101203048 | **Pass** | No defect found |
| 399 | Ghostrick Djinn (212052682) | E1/E2/E3/E4/E5/E6 individually checked | procedure.lua/constant.lua + closest family | **Fixed** | Corrected in ultimate pass |
| 400 | Ghostrick Slime (257677549) | E1/E2/E3/E4/E5 individually checked | procedure.lua/constant.lua + closest family | **Pass** | No defect found |
| 401 | Ghostrick Haunt (241540236) | E1/E2/E3 individually checked | procedure.lua/constant.lua + closest family | **Fixed** | Corrected in ultimate pass |
| 402 | Ghostrick Camella (235687149) | E1/E2 individually checked | procedure.lua + procedure family; c10443957/c101203048 | **Fixed** | Corrected in ultimate pass |
| 403 | Ghostrick Cutifer (228472690) | E1/E2 individually checked | procedure.lua + procedure family; c10443957/c101203048; c10004783/c10632284 | **Fixed** | Corrected in ultimate pass |
| 404 | Ghostrick Oni (239335848) | E1/E2/E3/E4 individually checked | procedure.lua + procedure family; c10443957/c101203048 | **Needs manual ruling** | Custom Xyz material transfer/Quick conversion |
| 405 | Ghostrick Pastrygeist (259851064) | E1/E2/E3 individually checked | procedure.lua + procedure family | **Fixed** | Corrected in ultimate pass |
| 406 | Vampire Avenger (259815138) | E1/E2/E3 individually checked | procedure.lua/constant.lua + closest family | **Fixed** | Corrected in ultimate pass |
| 407 | Vampire Lugat (259524916) | E1/E2 individually checked | procedure.lua/constant.lua + closest family | **Pass** | No defect found |
| 408 | Vampire Reptilian (259552732) | E1/E2 individually checked | procedure.lua/constant.lua + closest family | **Needs manual ruling** | Opponent-monster Xyz material/control semantics |
| 409 | Vampire Traveler (259479818) | E1/E2/E3/E4 individually checked | procedure.lua/constant.lua + closest family | **Fixed** | Corrected in ultimate pass |
| 410 | Vampire Estrie (259144144) | E1/E2 individually checked | procedure.lua + procedure family | **Fixed** | Corrected in ultimate pass |
| 411 | Scarstech Prologue (224467692) | No effect: source text checked | procedure.lua/constant.lua + closest family | **Needs manual ruling** | Effect metadata conflicts with flavor-only text |
| 412 | Scarstech Crusader (232104829) | E1/E2/E3/E4 individually checked | procedure.lua/constant.lua + closest family | **Fixed** | Corrected in ultimate pass |
| 413 | Scarstech Dragon (240768497) | E1/E2/E3 individually checked | procedure.lua/constant.lua + closest family | **Pass** | No defect found |
| 414 | Scarstech Swarmer (248884592) | E1/E2/E3/E4 individually checked | procedure.lua/constant.lua + closest family | **Pass** | No defect found |
| 415 | Scarstech Sniper (233502817) | E1/E2 individually checked | procedure.lua/constant.lua + closest family | **Pass** | No defect found |
| 416 | Scarstech Beacon (245837578) | E1/E2 individually checked | procedure.lua/constant.lua + closest family | **Pass** | No defect found |
| 417 | Scarstech Principality (210175845) | E1/E2 individually checked | procedure.lua/constant.lua + closest family | **Fixed** | Corrected in ultimate pass |
| 418 | Scarstech Stagger (253934904) | E1/E2 individually checked | procedure.lua/constant.lua + closest family | **Fixed** | Corrected in ultimate pass |
| 419 | Scarstech Kaiser (239179363) | E1/E2/E3/E4/E5/E6/E7 individually checked | procedure.lua + procedure family | **Fixed** | Corrected in ultimate pass |
| 420 | Scarstech Invasion (244009988) | E1/E2/E3/E4/E5/E6/E7 individually checked | procedure.lua/constant.lua + closest family | **Fixed** | Corrected in ultimate pass |
| 421 | Scarstech Circuit (248891593) | E1/E2/E3/E4/E5/E6 individually checked | procedure.lua/constant.lua + closest family | **Fixed** | Corrected in ultimate pass |
| 422 | Scarstech Deployment (224235021) | E1/E2/E3/E4 individually checked | procedure.lua/constant.lua + closest family | **Pass** | No defect found |
| 423 | Scarstech Blaster (243488958) | E1/E2/E3/E4 individually checked | procedure.lua/constant.lua + closest family | **Pass** | No defect found |
| 424 | Gravinity Orbit (249680945) | E1/E2/E3/E4/E5 individually checked | c34124316/c120145032; c10004783/c10632284 | **Fixed** | Corrected in ultimate pass |
| 425 | Nifal, the Scarstech War Machine (254894701) | E1/E2/E3/E4/E5/E6 individually checked | procedure.lua + procedure family | **Pass** | No defect found |
| 426 | Gravinity Plasma (235538173) | E1/E2/E3/E4/E5 individually checked | c34124316/c120145032; c10004783/c10632284 | **Fixed** | Corrected in ultimate pass |
| 427 | Ratsach, the Scarstech Cruiser (242838495) | E1/E2/E3/E4/E5/E6 individually checked | procedure.lua + procedure family | **Fixed** | Corrected in ultimate pass |
| 428 | Gravinity Pulse (256172827) | E1/E2/E3/E4/E5 individually checked | c34124316/c120145032; c10004783/c10632284 | **Pass** | No defect found |
| 429 | Scarstech Crawler (213611313) | E1/E2/E3/E4 individually checked | procedure.lua + procedure family | **Pass** | No defect found |
| 430 | Chaos Honest (248638801) | E1/E2/E3/E4/E5 individually checked | procedure.lua + procedure family | **Pass** | No defect found |
| 431 | Gravinity Star (215768254) | E1/E2/E3/E4/E5/E6 individually checked | c34124316/c120145032; c10004783/c10632284 | **Fixed** | Corrected in ultimate pass |
| 432 | Gravinity Lapsix (212345347) | E1/E2/E3/E4 individually checked | procedure.lua + procedure family; c10004783/c10632284 | **Fixed** | Corrected in ultimate pass |
| 433 | Gravinity Galaxix (249454272) | E1/E2/E3/E4 individually checked | procedure.lua + procedure family | **Fixed** | Corrected in ultimate pass |
| 434 | Gravinity Nebulix (212429024) | E1/E2/E3/E4 individually checked | procedure.lua + procedure family; c10004783/c10632284 | **Fixed** | Corrected in ultimate pass |
| 435 | Gravinity Spherix (231088629) | E1/E2/E3/E4/E5/E6 individually checked | procedure.lua + procedure family; c10443957/c101203048; c10004783/c10632284 | **Needs manual ruling** | Summon replacement plus minimum GY Xyz material |
| 436 | Gravinity Transfer Call (223505382) | E1/E2/E3 individually checked | c10004783/c10632284 | **Fixed** | Corrected in ultimate pass |
| 437 | Gravinity Gravity Protection (247919552) | E1/E2 individually checked | c10004783/c10632284 | **Fixed** | Corrected in ultimate pass |
| 438 | Gravinity Axis Matter (256831125) | E1/E2/E3/E4 individually checked | c23153227/c43331750/c70369116/c97769122 | **Needs manual ruling** | Copying only non-activated effects |
| 439 | Gravinity Sonic Scream (238184015) | E1/E2/E3 individually checked | c23153227/c43331750/c70369116/c97769122; c100201001/c100235002; c10004783/c10632284 | **Needs manual ruling** | Copied activated-effect semantics |
| 440 | Unbinding the Soul (246900181) | E1 individually checked | procedure.lua/constant.lua + closest family | **Fixed** | Corrected in ultimate pass |
| 441 | Eclipse Summoning (251331463) | E1/E2 individually checked | procedure.lua/constant.lua + closest family | **Pass** | No defect found |
| 442 | Lowkey Lowkey (225260657) | No effect: source text checked | procedure.lua/constant.lua + closest family | **Pass** | No defect found |
| 443 | Flower Cardian Moonflare (248940511) | E1/E2/E3 individually checked | procedure.lua + procedure family; c100201001/c100235002 | **Needs manual ruling** | One card treated as 3 non-Tuners |
| 444 | Stardust Comet (231523659) | E1/E2/E3 individually checked | procedure.lua/constant.lua + closest family | **Needs manual ruling** | Deck Tribute/immediate Synchro/Level timing |
| 445 | Interwire Dimensquid (253128790) | E1/E2/E3/E4 individually checked | procedure.lua/constant.lua + closest family | **Pass** | No defect found |
| 446 | Oracle of the Herald (247298564) | E1/E2/E3/E4 individually checked | procedure.lua/constant.lua + closest family | **Pass** | No defect found |
| 447 | Galacticarina (234179728) | E1/E2/E3 individually checked | procedure.lua/constant.lua + closest family | **Pass** | No defect found |
| 448 | Galacticassiopeia (227335484) | E1/E2/E3 individually checked | procedure.lua/constant.lua + closest family | **Pass** | No defect found |
| 449 | Galacticanes Venatici (229021849) | E1/E2 individually checked | procedure.lua/constant.lua + closest family | **Pass** | No defect found |
| 450 | Galacticanes Auriga (220148485) | No effect: source text checked | procedure.lua/constant.lua + closest family | **Pass** | No defect found |
| 451 | Galataxian Battle Tactics (226902471) | E1/E2/E3/E4 individually checked | procedure.lua/constant.lua + closest family | **Pass** | No defect found |
| 452 | Galataxian Battle Formation (239127930) | E1/E2/E3/E4/E5 individually checked | procedure.lua/constant.lua + closest family | **Fixed** | Corrected in ultimate pass |
| 453 | Galataxian Battle Preparation (210696007) | E1/E2/E3/E4 individually checked | procedure.lua/constant.lua + closest family | **Fixed** | Corrected in ultimate pass |
| 454 | Galactican Battle Station (258934904) | E1/E2/E3/E4/E5 individually checked | procedure.lua/constant.lua + closest family | **Needs manual ruling** | Adds an effect to another resolving effect in Damage Step |
| 455 | Galactican Battle Grounds (250829750) | E1/E2/E3/E4 individually checked | c23153227/c43331750/c70369116/c97769122; c10004783/c10632284 | **Pass** | No defect found |
| 456 | Fusion Intergalactica (245395343) | E1/E2 individually checked | procedure.lua + procedure family | **Fixed** | Corrected in ultimate pass |
| 457 | Attack on Gravity (259307285) | E1/E2/E3 individually checked | c100201001/c100235002 | **Pass** | No defect found |
| 458 | Galactican Jet Dasher (256005703) | E1/E2/E3 individually checked | procedure.lua + procedure family | **Pass** | No defect found |
| 459 | Galactican Jet Drifter (212837324) | E1/E2/E3/E4 individually checked | procedure.lua + procedure family | **Fixed** | Corrected in ultimate pass |
| 460 | Carina, Forgotten of Eldora (259482393) | E1/E2/E3/E4 individually checked | procedure.lua + procedure family | **Pass** | No defect found |
| 461 | Cassiopeia, Forgotten of Eldora (250917339) | E1/E2/E3/E4 individually checked | procedure.lua + procedure family | **Pass** | No defect found |
| 462 | Aeloria in Depraevity (259230000) | E1/E2/E3/E4 individually checked | c23153227/c43331750/c70369116/c97769122; c10004783/c10632284 | **Fixed** | Corrected in ultimate pass |
| 463 | Galactican Machine - No. G2-X38 (253520299) | E1/E2 individually checked | procedure.lua + procedure family | **Pass** | No defect found |
| 464 | Intergalactican Machine - No. R2-D30 (236473882) | E1/E2 individually checked | procedure.lua + procedure family | **Pass** | No defect found |
| 465 | Cassiopeia of the Eldoran System (212377618) | E1 individually checked | procedure.lua/constant.lua + closest family | **Pass** | No defect found |
| 466 | Intergalacticanes Majoris (219002796) | E1/E2/E3/E4/E5/E6 individually checked | procedure.lua + procedure family | **Fixed** | Corrected in ultimate pass |
| 467 | To Protogenis Intergalataxiakos (221827483) | E1/E2/E3/E4/E5/E6/E7 individually checked | procedure.lua + procedure family | **Fixed** | Corrected in ultimate pass |
| 468 | Pray for Your Life! (259924331) | E1/E2 individually checked | procedure.lua/constant.lua + closest family | **Pass** | No defect found |
| 469 | Gladiator Beast Sabearius (259607933) | E1/E2 individually checked | procedure.lua/constant.lua + closest family | **Pass** | No defect found |
| 470 | Gladiator Beast Attrocitar (259395418) | E1/E2 individually checked | procedure.lua/constant.lua + closest family | **Pass** | No defect found |
| 471 | Gladiator Beast Satyrius (259363148) | E1/E2/E3/E4/E5 individually checked | c22804644/c101301087; procedure.lua + procedure family; c34124316/c120145032 | **Pass** | No defect found |
| 472 | Night Night Nemleria (259766646) | E1 individually checked | procedure.lua/constant.lua + closest family | **Pass** | No defect found |
| 473 | Pyjama Party of Happy Nemleria (259605536) | E1/E2/E3/E4 individually checked | procedure.lua/constant.lua + closest family | **Fixed** | Corrected in ultimate pass |
| 474 | Nemleria Big Eepy (259883971) | E1/E2/E3 individually checked | procedure.lua/constant.lua + closest family | **Fixed** | Corrected in ultimate pass |
| 475 | Nemleria's Nightmare (259017109) | E1/E2/E3 individually checked | procedure.lua/constant.lua + closest family | **Pass** | No defect found |
| 476 | Nemleria's Dream Bedroom (259090287) | E1/E2/E3/E4/E5/E6 individually checked | procedure.lua/constant.lua + closest family | **Pass** | No defect found |
| 477 | Nemleria Dream Creator Pyjama (259392825) | E1/E2/E3 individually checked | procedure.lua/constant.lua + closest family | **Pass** | No defect found |
| 478 | Nemleria Dream Devourer - Soleil (259472680) | E1/E2/E3/E4 individually checked | procedure.lua/constant.lua + closest family | **Fixed** | Corrected in ultimate pass |
| 479 | Nemleria Dream Creator - Veilleuse (259898110) | E1/E2/E3/E4 individually checked | procedure.lua/constant.lua + closest family | **Fixed** | Corrected in ultimate pass |
| 480 | Grayling, the Grayscale Imp (259934043) | E1/E2/E3/E4 individually checked | procedure.lua/constant.lua + closest family | **Pass** | No defect found |
| 481 | Graysentry, the Guard of Grayscale (259341133) | E1/E2/E3/E4 individually checked | procedure.lua + procedure family; c10443957/c101203048 | **Fixed** | Corrected in ultimate pass |
| 482 | Grayrover, the Wandering Grayscale (259937399) | E1/E2/E3/E4/E5/E6 individually checked | procedure.lua/constant.lua + closest family | **Pass** | No defect found |
| 483 | Graylock, the Sorcerer of Grayscale (259724129) | E1/E2/E3/E4 individually checked | procedure.lua/constant.lua + closest family | **Fixed** | Corrected in ultimate pass |
| 484 | Grayhex, the Chanter of Grayscale (259688514) | E1/E2/E3/E4 individually checked | procedure.lua/constant.lua + closest family | **Pass** | No defect found |
| 485 | Grayseer, the Grayscale Spy (259632020) | E1/E2/E3 individually checked | procedure.lua + procedure family | **Pass** | No defect found |
| 486 | Grayterror, the Grayscale Beast (259624110) | E1/E2/E3 individually checked | procedure.lua + procedure family; c10443957/c101203048 | **Pass** | No defect found |
| 487 | Graydimm, the Grayscale Shadow (259245496) | E1/E2/E3 individually checked | procedure.lua + procedure family | **Pass** | No defect found |
| 488 | Grayshade, the Phantom of Grayscale (259626409) | E1/E2/E3 individually checked | c22804644/c101301087; procedure.lua + procedure family; c10443957/c101203048 | **Pass** | No defect found |
| 489 | Graydeux, the Eternal Grayscale Entity (259229055) | E1/E2/E3 individually checked | c22804644/c101301087; procedure.lua + procedure family; c10443957/c101203048 | **Fixed** | Corrected in ultimate pass |
| 490 | Grayscale Awakening: Revelation (259923860) | E1/E2/E3/E4 individually checked | procedure.lua/constant.lua + closest family | **Fixed** | Corrected in ultimate pass |
| 491 | Grayscale Awakening: Eclipse (259203522) | E1/E2/E3 individually checked | procedure.lua/constant.lua + closest family | **Pass** | No defect found |
| 492 | Grayscale Awakening: Nullbind (259269688) | E1/E2/E3/E4 individually checked | c10443957/c101203048 | **Fixed** | Corrected in ultimate pass |
| 493 | The Misstakes of the A.I.P Experience (259275822) | No effect: source text checked | procedure.lua/constant.lua + closest family | **Fixed** | Corrected in ultimate pass |
| 494 | A.I.P Ex Larva (259609997) | E1/E2/E3/E4/E5 individually checked | procedure.lua + procedure family | **Pass** | No defect found |
| 495 | A.I.P Ex Shrieker (259664027) | E1/E2/E3/E4 individually checked | procedure.lua/constant.lua + closest family | **Pass** | No defect found |
| 496 | A.I.P Ex Claw (259137697) | E1/E2/E3/E4 individually checked | procedure.lua + procedure family; c10443957/c101203048 | **Fixed** | Corrected in ultimate pass |
| 497 | A.I.P Ex Maw (259522807) | E1/E2/E3 individually checked | procedure.lua + procedure family | **Fixed** | Corrected in ultimate pass |
| 498 | A.I.P Ex Predator (259121126) | E1/E2 individually checked | procedure.lua/constant.lua + closest family | **Fixed** | Corrected in ultimate pass |
| 499 | A.I.P Lab (259943152) | E1/E2/E3/E4/E5 individually checked | procedure.lua/constant.lua + closest family | **Fixed** | Corrected in ultimate pass |
| 500 | Failures of the A.I.P (259883029) | E1/E2 individually checked | c10443957/c101203048 | **Fixed** | Corrected in ultimate pass |
| 501 | A.I.P Ex Assimilation (259630851) | E1/E2/E3 individually checked | procedure.lua/constant.lua + closest family | **Fixed** | Corrected in ultimate pass |
| 502 | A.I.P Ex Hive Mind (259499577) | E1/E2 individually checked | procedure.lua/constant.lua + closest family | **Fixed** | Corrected in ultimate pass |
| 503 | Caller of the A.I.P Ex (259465391) | E1/E2/E3 individually checked | procedure.lua + procedure family; c34124316/c120145032 | **Fixed** | Corrected in ultimate pass |
| 504 | Zero Mother of the A.I.P Ex (259097228) | E1/E2/E3 individually checked | procedure.lua + procedure family; c10443957/c101203048 | **Fixed** | Corrected in ultimate pass |
| 505 | Red-Eyes Gearfried the Iron Knight (259466138) | E1/E2/E3/E4/E5 individually checked | procedure.lua/constant.lua + closest family | **Fixed** | Corrected in ultimate pass |
| 506 | Red-Eyes Moon Dragon (259992800) | E1/E2/E3/E4/E5 individually checked | c10004783/c10632284 | **Fixed** | Corrected in ultimate pass |
| 507 | Red-Eyes Meteor Metal Dragon (259184310) | E1/E2/E3/E4 individually checked | procedure.lua + procedure family; c23153227/c43331750/c70369116/c97769122 | **Fixed** | Corrected in ultimate pass |
| 508 | Red-Eyes Roar (259562343) | E1/E2/E3 individually checked | procedure.lua + procedure family; c23153227/c43331750/c70369116/c97769122 | **Pass** | No defect found |
| 509 | Red-Eyes Turbo Dragon (259114673) | E1/E2 individually checked | procedure.lua + procedure family | **Pass** | No defect found |
| 510 | Red-Eyes Booster Dragon (259628203) | E1/E2/E3/E4 individually checked | c22804644/c101301087; procedure.lua + procedure family | **Fixed** | Corrected in ultimate pass |
| 511 | Rush at the Gnome (259755133) | E1/E2/E3 individually checked | procedure.lua/constant.lua + closest family | **Pass** | No defect found |
| 512 | Calcu Leet (259825991) | E1 individually checked | procedure.lua/constant.lua + closest family | **Pass** | No defect found |
| 513 | Digita Leet (259138193) | E1/E2/E3 individually checked | procedure.lua + procedure family | **Pass** | No defect found |
| 514 | Virtua Leet (259940722) | E1/E2/E3/E4/E5/E6/E7 individually checked | procedure.lua + procedure family | **Fixed** | Corrected in ultimate pass |
| 515 | Herald of White Light (259688676) | E1/E2/E3 individually checked | procedure.lua + procedure family; c100201001/c100235002 | **Fixed** | Corrected in ultimate pass |
| 516 | Thunder Dragon Behemoth (259352030) | E1/E2/E3/E4 individually checked | c22804644/c101301087; procedure.lua + procedure family | **Pass** | No defect found |
| 517 | Aurelion Divine Illumination (259889864) | E1/E2 individually checked | c100201001/c100235002 | **Pass** | No defect found |
| 518 | Lance Luminar Justiciar (259373017) | E1/E2 individually checked | c34124316/c120145032 | **Pass** | No defect found |
| 519 | Scarstech Draco (259304399) | E1/E2 individually checked | procedure.lua/constant.lua + closest family | **Pass** | No defect found |
| 520 | Scarstech Wyvern (259531370) | E1/E2/E3/E4 individually checked | procedure.lua/constant.lua + closest family | **Fixed** | Corrected in ultimate pass |
| 521 | Scarstech Invader (259464700) | E1/E2/E3 individually checked | procedure.lua/constant.lua + closest family | **Pass** | No defect found |
| 522 | Ganan, the Scarstech City (259459462) | E1/E2/E3/E4 individually checked | procedure.lua + procedure family | **Pass** | No defect found |
| 523 | Qerets, the Scarstech Mother Ship (259086544) | E1/E2/E3/E4/E5 individually checked | procedure.lua + procedure family; c100201001/c100235002 | **Pass** | No defect found |
| 524 | Adamantios, the Dark Armor (259315827) | E1/E2/E3/E4 individually checked | procedure.lua + procedure family | **Pass** | No defect found |
| 525 | Disciple of Fire (259023461) | E1/E2/E3/E4/E5 individually checked | procedure.lua/constant.lua + closest family | **Fixed** | Corrected in ultimate pass |
| 526 | Sorceress of Fire (259360287) | E1/E2/E3 individually checked | procedure.lua/constant.lua + closest family | **Pass** | No defect found |
| 527 | Phlogiston's Roar (259366281) | E1/E2/E3/E4 individually checked | c100201001/c100235002 | **Pass** | No defect found |
| 528 | Harpie Cyber Dancer (259794136) | E1/E2/E3 individually checked | procedure.lua/constant.lua + closest family | **Fixed** | Corrected in ultimate pass |
| 529 | Harpie Lady Sisters - Phoenix Formation (259269774) | E1/E2/E3/E4 individually checked | c22804644/c101301087; procedure.lua + procedure family | **Fixed** | Corrected in ultimate pass |
| 530 | Mirage Formation Dragon (259072169) | E1/E2/E3/E4 individually checked | procedure.lua + procedure family; c10443957/c101203048 | **Fixed** | Corrected in ultimate pass |
| 531 | Glitchling Bitron (259247807) | E1/E2/E3/E4/E5 individually checked | procedure.lua/constant.lua + closest family | **Fixed** | Corrected in ultimate pass |
| 532 | Glitchling Protron (259156549) | E1/E2/E3/E4/E5 individually checked | procedure.lua/constant.lua + closest family | **Pass** | No defect found |
| 533 | Glitchling Witch (259678739) | E1/E2/E3/E4/E5/E6 individually checked | procedure.lua/constant.lua + closest family | **Pass** | No defect found |
| 534 | Glitchling Data-Transfert (259961648) | E1/E2/E3/E4 individually checked | procedure.lua/constant.lua + closest family | **Pass** | No defect found |
| 535 | Glitchling Octron (259927462) | E1/E2 individually checked | procedure.lua + procedure family | **Pass** | No defect found |
| 536 | Glitchling Digitron (259494236) | E1/E2/E3/E4/E5 individually checked | c100201001/c100235002 | **Pass** | No defect found |
| 537 | Glitchling Mage (259072906) | E1/E2/E3/E4/E5 individually checked | procedure.lua/constant.lua + closest family | **Pass** | No defect found |
| 538 | Glitchling Leotron (259873115) | E1/E2/E3/E4/E5 individually checked | c100201001/c100235002 | **Pass** | No defect found |
| 539 | Glitchling Corruption (259546637) | E1/E2/E3 individually checked | procedure.lua/constant.lua + closest family | **Fixed** | Corrected in ultimate pass |
| 540 | Glitchling Hexatron (259253032) | E1/E2/E3/E4/E5/E6 individually checked | procedure.lua + procedure family | **Fixed** | Corrected in ultimate pass |
| 541 | Heart of the Cards (259485374) | E1/E2 individually checked | c22804644/c101301087; c34124316/c120145032 | **Fixed** | Corrected in ultimate pass |
| 542 | The Orcustograph (259576196) | E1/E2/E3 individually checked | procedure.lua + procedure family | **Fixed** | Corrected in ultimate pass |
| 543 | Galatea-2, the Orcust Divider (259646610) | E1/E2 individually checked | procedure.lua + procedure family | **Fixed** | Corrected in ultimate pass |
| 544 | Charmelia Kiana (259614449) | E1/E2 individually checked | c10004783/c10632284 | **Pass** | No defect found |
| 545 | Charmelia Hanabi (259790247) | E1/E2 individually checked | c10004783/c10632284 | **Pass** | No defect found |
| 546 | Charmelia Elysia (259288669) | E1/E2 individually checked | procedure.lua + procedure family; c34124316/c120145032 | **Fixed** | Corrected in ultimate pass |
| 547 | Charmelia Robin (259568843) | E1/E2 individually checked | procedure.lua/constant.lua + closest family | **Fixed** | Corrected in ultimate pass |
| 548 | Charmelia Pray (259241946) | E1/E2 individually checked | procedure.lua + procedure family | **Pass** | No defect found |
| 549 | Charmelia Deal (259758604) | E1/E2/E3 individually checked | c10004783/c10632284 | **Pass** | No defect found |
| 550 | Charmelia Beast (259226799) | E1/E2/E3/E4 individually checked | procedure.lua/constant.lua + closest family | **Pass** | No defect found |
| 551 | Magical Girl Explosion (259402105) | E1/E2/E3/E4 individually checked | procedure.lua/constant.lua + closest family | **Pass** | No defect found |
| 552 | Charmelia Fairy Kyubey (259489283) | E1/E2/E3/E4/E5 individually checked | c10004783/c10632284 | **Fixed** | Corrected in ultimate pass |
| 553 | Charmelia Fairy Morningstar (259753109) | E1/E2/E3/E4/E5 individually checked | procedure.lua/constant.lua + closest family | **Fixed** | Corrected in ultimate pass |
| 554 | Wyvernal Luna (259599798) | E1/E2 individually checked | procedure.lua/constant.lua + closest family | **Fixed** | Corrected in ultimate pass |
| 555 | Wyvernal Caudina (259783008) | E1/E2 individually checked | procedure.lua/constant.lua + closest family | **Fixed** | Corrected in ultimate pass |
| 556 | Wyvernal Myops (259431066) | E1/E2/E3/E4 individually checked | procedure.lua/constant.lua + closest family | **Fixed** | Corrected in ultimate pass |
| 557 | Wyvernal Crenata (259533644) | E1/E2/E3 individually checked | procedure.lua + procedure family | **Pass** | No defect found |
| 558 | Wyvernal Sphinx (259348317) | E1/E2 individually checked | procedure.lua + procedure family; c23153227/c43331750/c70369116/c97769122 | **Pass** | No defect found |
| 559 | Wyvernal Lymantria (259763531) | E1/E2/E3 individually checked | procedure.lua + procedure family | **Pass** | No defect found |
| 560 | Wyvernal Megalopyge (259179054) | E1/E2/E3 individually checked | procedure.lua + procedure family | **Pass** | No defect found |
| 561 | Wyvernal Sanctuary (259160760) | E1/E2/E3 individually checked | procedure.lua + procedure family; c23153227/c43331750/c70369116/c97769122 | **Pass** | No defect found |
| 562 | Wyvernal Gathering (259073666) | E1/E2 individually checked | procedure.lua/constant.lua + closest family | **Fixed** | Corrected in ultimate pass |
| 563 | Eclipse Observer Aaliyah (259652372) | E1/E2/E3 individually checked | c34124316/c120145032 | **Pass** | No defect found |
| 564 | Eclipse Observer Riley (259926839) | E1/E2 individually checked | procedure.lua/constant.lua + closest family | **Pass** | No defect found |
| 565 | Eclipse Observer Nora (259069729) | E1/E2 individually checked | procedure.lua/constant.lua + closest family | **Pass** | No defect found |
| 566 | Eclipse Observer Ella (259487387) | E1/E2/E3 individually checked | procedure.lua/constant.lua + closest family | **Pass** | No defect found |
| 567 | Eclipse Observer Maya (259058125) | E1/E2/E3/E4 individually checked | procedure.lua/constant.lua + closest family | **Pass** | No defect found |
| 568 | Eclipse Observatory (259721372) | E1/E2/E3 individually checked | procedure.lua/constant.lua + closest family | **Pass** | No defect found |
| 569 | Grimoire of Eclipse (259680842) | E1 individually checked | procedure.lua + procedure family; c23153227/c43331750/c70369116/c97769122 | **Pass** | No defect found |
| 570 | Encyclopedia of Eclipse (259614765) | E1/E2 individually checked | procedure.lua/constant.lua + closest family | **Pass** | No defect found |
| 571 | Manual of Eclipse (259273851) | E1/E2 individually checked | c22804644/c101301087 | **Fixed** | Corrected in ultimate pass |
| 572 | Spellbook of Eclipse (259264449) | E1/E2 individually checked | c10443957/c101203048 | **Pass** | No defect found |
| 573 | Tome of Eclipse (259303191) | E1/E2 individually checked | c22804644/c101301087 | **Fixed** | Corrected in ultimate pass |
| 574 | Eclipse Observer Baleygr (259193076) | E1/E2/E3/E4 individually checked | procedure.lua + procedure family; c23153227/c43331750/c70369116/c97769122 | **Fixed** | Corrected in ultimate pass |
| 575 | Eclipse Observer Chandra (259126370) | E1/E2/E3 individually checked | procedure.lua + procedure family | **Fixed** | Corrected in ultimate pass |
| 576 | Eclipse Observer Seara (259612312) | E1/E2/E3 individually checked | procedure.lua + procedure family; c100201001/c100235002 | **Pass** | No defect found |
| 577 | Ether Mademoiselle (259223502) | E1/E2/E3/E4 individually checked | procedure.lua + procedure family; c100201001/c100235002 | **Pass** | No defect found |

## Manual-ruling queue

- **Ghostrick Oni (239335848):** the intended transfer of existing materials plus making another monster’s effects Quick for the turn has no exact official analogue; validate Xyz-material/event history.
- **Vampire Reptilian (259552732):** confirm the intended control/material semantics when the targeted opponent monster is used for the immediate Xyz Summon.
- **Scarstech Prologue (224467692):** `cards.json` classifies it as an Effect Monster, but the exact text is flavor prose with no mechanical effect; the standalone empty script is intentional pending metadata/ruling direction.
- **Gravinity Spherix (231088629):** summon replacement into the S/T Zone and selecting the minimum legal GY Xyz-material set require live ruling/UI confirmation.
- **Gravinity Axis Matter (256831125):** “gains the non-activated effects” cannot be mapped one-for-one by Omega’s normal copied-activation helpers.
- **Gravinity Sonic Scream (238184015):** its GY effect becomes another card’s activated effect; validate copied targets/cost state in live chains.
- **Flower Cardian Moonflare (248940511):** treating one Synchro Monster as three non-Tuners is a custom material-count rule without an exact official script.
- **Stardust Comet (231523659):** Tribute-from-Deck cost, immediate Synchro Summon, and post-summon Level change need live timing/UI confirmation.
- **Galactican Battle Station (258934904):** dynamically adding an effect to another resolving monster effect in the Damage Step needs a ruling and live-chain test.

## Material fixes found in this pass

- Replaced unsupported card APIs (`IsMonster/IsSpell/IsTrap/HasLevel/IsOriginalType/IsFusionLevel`) with official Omega forms across all affected lane files.
- Corrected cost/target/operation boundaries for A.I.P Predator, Glitchling Bitron/Hexatron, Harpie Cyber Dancer, and Eclipse Observer Baleygr.
- Added targetability, relation-at-resolution, and Necrovalley handling where movement from GY/banishment required it (including Grayscale Revelation, Orcustograph, Chandra, Gearfried, Meteor Metal Dragon, Galatea-2, Robin, and Gathering).
- Corrected delayed return/end-phase handling, copied activation state, top-five Deck handling, overlay legality/material cleanup, Trap Monster disabling, persistent negation, immediate procedure selection, and “if you do” success gates.
- Added the previously missing standalone no-effect script for The Misstakes of the A.I.P Experience.

## Official Omega references used

- Core APIs and procedures: `tmp/omega_scripts/procedure.lua`, `constant.lua`; API forms in `c82370493.lua`, `c30086349.lua`.
- Xyz attach/transfer/procedure: `c10443957.lua`, `c101203048.lua`, `c100259006.lua`, `c197042.lua`, `c68663427.lua`.
- Copied activations: `c23153227.lua`, `c43331750.lua`, `c70369116.lua`, `c97769122.lua`, `c100261026.lua`, `c10136446.lua`.
- Chain-operation rewrite: `c80453041.lua`, `c62318994.lua`.
- Delayed phase/groups: `c22804644.lua`, `c101301087.lua`.
- Top-of-Deck: `c34124316.lua`, `c120145032.lua`.
- Necrovalley access: `c100245019.lua`.
- Negation: `c100201001.lua`, `c100235002.lua`.
- Trap Monsters and S/T placement: `c10632284.lua`, `c101204071.lua`, `c10004783.lua`.
- Ritual levels: `c34334692.lua`, `c38356857.lua`, `c90307777.lua`, `c18988396.lua`.
- Chain-link state: `c24838456.lua`, `c23530726.lua`, `c81696879.lua`.
- Hand/GY summon procedures: `c100212002.lua`, `c25811989.lua`, `c26746975.lua`, `c48486809.lua`.
- Replacement effects: `c14088859.lua`, `c14001430.lua`.
- Activation from Deck: `c1050355.lua`, `c4179255.lua`.
- Fusion chain/material: `c100233201.lua`, `c27346636.lua`, `c29357956.lua`.
- Set-turn and Extra Link: `c50237654.lua`, `c58019984.lua`, `c100201001.lua`, `c100239201.lua`, `c100256017.lua`, `c16684346.lua`.

## DB/message finding for root integration

Public DB rows and exact name/description text are present for all 187 cards. One referenced message is blank:

- `259680842` Grimoire of Eclipse, `aux.Stringid(id,1)`: **Use 1 Level 8 "Eclipse Observer" monster and 1 Spellcaster monster as Fusion Material?**

This lane intentionally did not edit the central DB synchronizer, installed DB, ZIP, or dist mirrors; root owns the one coordinated sync/build after all lanes finish.

## Verification

- Lane `luac -p`: **PASS, 187/187**.
- Full public-script folder `luac -p`: **PASS, 592/592**.
- Standalone load + `initial_effect` smoke: **PASS, 187/187**.
- Public DB `datas`/`texts` presence and exact `cards.json` name/description: **PASS, 187/187**.
- Referenced `aux.Stringid` slots: **FAIL, 1 blank central message** (Grimoire finding above).
- Public/installed DB SHA-256 parity at audit time: **PASS**.
- Loader scan (`require`, `dofile`, `loadfile`): **PASS, none**.
- Unsupported API scan: **PASS, none**.
- Target/cost one-line mutation scan and manual effect audit: **PASS**.
- `git diff --check` on 85 changed lane scripts: **PASS**.
- Public/installed scripts, ZIPs, dist hashes and `npm run build`: **deferred to root integration** after all agent lanes complete.

## Files changed by lane C

85 Lua files, plus this ledger:

- c212052682.lua
- c241540236.lua
- c235687149.lua
- c228472690.lua
- c239335848.lua
- c259851064.lua
- c259815138.lua
- c259479818.lua
- c259144144.lua
- c232104829.lua
- c210175845.lua
- c253934904.lua
- c239179363.lua
- c244009988.lua
- c248891593.lua
- c249680945.lua
- c235538173.lua
- c242838495.lua
- c215768254.lua
- c212345347.lua
- c249454272.lua
- c212429024.lua
- c231088629.lua
- c223505382.lua
- c247919552.lua
- c256831125.lua
- c238184015.lua
- c246900181.lua
- c248940511.lua
- c231523659.lua
- c239127930.lua
- c210696007.lua
- c245395343.lua
- c212837324.lua
- c259230000.lua
- c219002796.lua
- c221827483.lua
- c259605536.lua
- c259883971.lua
- c259472680.lua
- c259898110.lua
- c259341133.lua
- c259724129.lua
- c259229055.lua
- c259923860.lua
- c259269688.lua
- c259275822.lua
- c259137697.lua
- c259522807.lua
- c259121126.lua
- c259943152.lua
- c259883029.lua
- c259630851.lua
- c259499577.lua
- c259465391.lua
- c259097228.lua
- c259466138.lua
- c259992800.lua
- c259184310.lua
- c259628203.lua
- c259940722.lua
- c259688676.lua
- c259531370.lua
- c259023461.lua
- c259794136.lua
- c259269774.lua
- c259072169.lua
- c259247807.lua
- c259546637.lua
- c259253032.lua
- c259485374.lua
- c259576196.lua
- c259646610.lua
- c259288669.lua
- c259568843.lua
- c259489283.lua
- c259753109.lua
- c259599798.lua
- c259783008.lua
- c259431066.lua
- c259073666.lua
- c259273851.lua
- c259303191.lua
- c259193076.lua
- c259126370.lua
- tmp/ultimate_audit_lane_c.md



## Cross-Reviewer Findings & Disagreement Reconciliation

### Reconciled Data from ultimate_audit_cross_a_reviews_b.md
# Ultimate audit independent cross-review B - ordinals 173-390

Scope: all 218 consecutive `src/data/cards.json` records at ordinals 173-390 were reviewed clause-by-clause against their standalone public Lua scripts and comparable official scripts in `tmp/omega_scripts`. Existing primary-audit patches were preserved. This cross-review did not synchronize public scripts to the installed Omega folder, ZIPs, DBs, or dist; final artifact synchronization belongs to the parent audit.

## Result summary

- Total: 218 cards.
- PASS: 131.
- FIXED: 52.
- MANUAL: 35.
- Final Lua syntax: PASS for 218/218 Lane B scripts and 592/592 public scripts.
- Final strict `initial_effect` smoke: PASS for 218/218 Lane B scripts and 592/592 public scripts.
- Forbidden standalone loaders: none found in the public script corpus.
- A MANUAL verdict means static review cannot prove the custom ruling/engine behavior; it does not mean syntax or initializer loading failed.

## Official Omega references used

- Core effect construction, costs, targets, and resolution checks: `c11248645.lua`, `c102380.lua`.
- Necrovalley-safe GY/banishment access: `c11335209.lua`, `c100259006.lua`.
- Negation: `c100201001.lua`, `c101208206.lua`, `c14799437.lua`, `c23440231.lua`, `c24545464.lua`, `c67865534.lua`, `c82489470.lua`.
- Copied activation/effects: `c70369116.lua`, `c23153227.lua`, `c43331750.lua`, `c97769122.lua`.
- Fusion/material procedures: `c101304094.lua`, `c53315891.lua`, `c100212001.lua`, `c31111109.lua`, `procedure.lua`.
- Xyz: `c10443957.lua`, `c101203048.lua`.
- Synchro/non-Tuner handling: `c1980574.lua`, `c16769305.lua`, `c4891376.lua`, `c40380686.lua`.
- Link: `c101304087.lua`.
- Delayed groups: `c17132130.lua`, `c48658295.lua`.
- Chain/rewritten effects: `c100259009.lua`, `c101203003.lua`, `c10131855.lua`.
- Top-of-Deck: `c50237654.lua`, `c58019984.lua`, `c79387392.lua`, `c97462632.lua`.
- Summon-procedure oath/count handling: `c100212002.lua`, `c100240201.lua`.
- Retroactive activity locks: `c101203005.lua`, `c101301096.lua`.
- Counter costs: `c101304084.lua`, `c101306071.lua`.
- Additional direct behavior references: `c34302287.lua`, `c16684346.lua`, `c100256017.lua`, `c50078320.lua`, `c42081767.lua`, `c101203059.lua`, `c1050355.lua`, `c11881272.lua`, `c100201001.lua`, `c101208206.lua`, `c14799437.lua`, `c23440231.lua`, `c101304094.lua`, `c10443957.lua`, `c1980574.lua`, `c16769305.lua`, `c101304087.lua`, `c100213003.lua`, `c10321588.lua`, `c87769556.lua`.

## Per-card results: ordinals 173-280

| Ord. | Passcode | Card | Verdict | Clauses/effects | Official patterns | Cross-pass result / remaining concern |
|---:|---:|---|---|---:|---|---|
| 173 | 237917359 | Phantasm Spiral Shrine | PASS | 3/3 | CORE, NV, FIELD | Placement, conditional protection, recycle, and draw-success gate map cleanly. |
| 174 | 222875833 | Phantasm Spiral Ensnarement | PASS | 4/3 | CORE, NEG | Hand-activation condition matches the exact Phantasm Spiral official pattern (`c34302287.lua`); negate/destruction sequence is sound. |
| 175 | 226063408 | Grand Puppet of Wicked Puppeteer | PASS | 3/4 | CORE, XYZ | Material/summon restrictions and registered effects map to all clauses. |
| 176 | 259527622 | Knight Puppet of Wicked Puppeteer | PASS | 3/4 | CORE, XYZ | Target legality, relation checks, and HOPT use are sound. |
| 177 | 233659599 | Minion Puppets of Wicked Puppeteer | PASS | 3/2 | CORE, NV | Cost and GY operation are separated and rechecked. |
| 178 | 257464336 | Guardian of Wicked Puppeteer | PASS | 3/2 | CORE, XYZ | Summon/material and protection clauses map cleanly. |
| 179 | 234178973 | The True Wicked Puppeteer, Orchis | PASS | 4/4 | CORE, XYZ, NEG | Xyz procedure, negation, and follow-up success gates follow official structure. |
| 180 | 236818346 | Wicked Puppeteer, Orchis | PASS | 4/3 | CORE, XYZ | Material, search, and restriction handling are complete. |
| 181 | 243306841 | Wicked Puppeteer Tragedy | PASS | 3/2 | CORE, NV | GY access and resolution checks are correct. |
| 182 | 219150610 | Wicked Puppeteery | PASS | 4/3 | CORE, XYZ | Target selection and Xyz-material handling follow official patterns. |
| 183 | 244959812 | Divine Phoenix of Nephthys | PASS | 3/3 | CORE, NV | Destruction-trigger and recursive GY handling are guarded correctly. |
| 184 | 234818744 | Primite Dragon Citrine | PASS | 3/0 | CORE | Normal-monster/rule text is represented without unnecessary registered effects. |
| 185 | 241868535 | Pedicaes Papa | PASS | 3/4 | CORE, NV | Trigger timing, selections, and GY access map cleanly. |
| 186 | 215984744 | Vir Pedicae Mortis - Entity's Happy Servant | MANUAL | 3/3 | CORE, NV | The script's code-based approximation of the printed "Mine" Field Spell/"Recollection" identity needs an authoritative card-pool/ruling confirmation. |
| 187 | 244778917 | Vir Pedicae Mortis - Fearless Hunter | MANUAL | 3/2 | LINK | Printed "treated as 2 materials" for a named Link Summon is not implemented; official generic Link helpers expose no source-monster effect that safely changes material weight. Requires destination-procedure/ruling work. |
| 188 | 243144691 | Vir Pedicae Mortis - the Unhallowed Warden | PASS | 3/3 | CORE, NV | Summon, recovery, and restriction clauses are represented. |
| 189 | 233103500 | Vir Pedicae Mortis - True Nightmare | PASS | 4/2 | CORE, FIRST | First-activation tracking and once-per-turn behavior follow official event tracking. |
| 190 | 236744343 | Entity's Realm - Pedicae Estate | PASS | 5/5 | CORE, NV, FIELD | Field activation, protection, and GY effects map to all clauses. |
| 191 | 211086520 | Recollection: Static, Lead, and Nerve | PASS | 2/1 | CORE | Activation and compound resolution are correctly success-gated. |
| 192 | 234984156 | Recollection: a Lesson in Iron | PASS | 2/4 | CORE | Continuous restrictions/protections require multiple effects and are correctly scoped. |
| 193 | 231872299 | Recollection: the Mine | PASS | 3/3 | CORE, FIELD | Field Spell activation and ongoing effects map cleanly. |
| 194 | 241447408 | Recollection: Kaboom Papa | MANUAL | 3/1 | CORE | "Only conduct 1 Summon this turn" needs a ruling on activation after prior summons and whether summon events or monsters are counted. |
| 195 | 229875953 | Teleum Mortis | PASS | 3/4 | CORE, DELAY | Bear Trap activation flags and both-player counting are now available from actual activation events; the Teleum logic itself is sound. |
| 196 | 251699681 | Bear Trap | FIXED | 3/6 | NEG | Summon destruction now requires successful `NegateSummon`; attack negation no longer incorrectly requires a destructible attacker; activation flags now register on `EVENT_CHAINING`, so negated resolutions still count as activations. |
| 197 | 219543855 | Securitake Agent | MANUAL | 3/4 | CORE, LINK | Script is internally consistent, but the intended scope of opponent-owned Link material (opponent monster you control versus opponent's field) needs a ruling. |
| 198 | 226645052 | Harmony Pearlwood & the Nautical Deepwaters | PASS | 3/5 | CORE, NV | Forced summon and follow-up effects map to the text. |
| 199 | 228040066 | Melody Merheart & the Nautical Coral Reef | PASS | 3/4 | CORE, NV | Costs, targets, and follow-up gates are separated correctly. |
| 200 | 214349717 | Emma Oceannus & the Nautical Coastlines | PASS | 2/4 | CORE, NV | Compound trigger and restrictions are implemented with correct scopes. |
| 201 | 259114562 | Bobbie Bluefin & the Nautical Nocturnes | MANUAL | 3/8 | CORE | When both Normal and Special Summon are legal the script chooses Special Summon without an explicit player choice; confirm intended forced-summon choice semantics. |
| 202 | 220749574 | Scarlet Seareef & the Nautical Creatures | MANUAL | 5/7 | CORE, TOP | Forced summon branch choice and bottom-of-Deck ordering need in-engine/ruling confirmation. |
| 203 | 225109525 | Evander Coldwater & the Nautical Abyss | MANUAL | 3/3 | CORE, NV | Returned monster can become eligible for the subsequent forced summon; confirm that this matches intended sequencing. |
| 204 | 223158720 | Nautical Backwashing & Oceanic Waves | MANUAL | 3/3 | CORE | Forced Normal/Special Summon selection defaults to Special when both are legal; printed choice semantics need confirmation. |
| 205 | 238711686 | Melissa Oceanheart & the Nautical Seabed | PASS | 3/3 | CORE, NV | Trigger, summon, and recovery operations map cleanly. |
| 206 | 248946297 | Exploring the Nautical Waters | MANUAL | 3/4 | CORE, TOP | Forced summon branch and bottom-deck order need an engine/ruling test. |
| 207 | 218905439 | Nautical Adventures & Torrential Seas | MANUAL | 3/4 | CORE, NV | A returned monster may be eligible for the subsequent forced summon; confirm intended pool and branch choice. |
| 208 | 259722826 | Bob | PASS | 2/0 | CORE | Rule/material text requires no registered effect and is represented by the card data/procedure context. |
| 209 | 259944943 | Bob, but Stronger! | MANUAL | 6/4 | FUS | Fixed contact-Fusion material search from `LOCATION_MZONE` to official `LOCATION_ONFIELD`; live test still required to confirm Omega permits the "Umi" Spell to pass Fusion-material legality. |
| 210 | 221047295 | Bookkeeper of Crying Chaos | PASS | 3/2 | CORE, NV | Search/recovery filters and HOPT handling are correct. |
| 211 | 233436485 | Crow of Crying Chaos | PASS | 2/0 | CORE | No independently registered effect is required by the current rule/material text. |
| 212 | 217118040 | Plague Doctor of Crying Chaos | PASS | 3/3 | CORE, NV | Costs, targeting, and relation checks are correctly separated. |
| 213 | 218261525 | Scarecrow of Crying Chaos | PASS | 3/2 | CORE | Trigger and compound resolution correctly check success. |
| 214 | 236017388 | Slug of Crying Chaos | PASS | 3/4 | CORE, NV | Graveyard and field operations use correct legality checks. |
| 215 | 240976976 | Witch of Crying Chaos | PASS | 3/3 | CORE, NV | Search/Set branches and restrictions map cleanly. |
| 216 | 240511702 | Hunter of Crying Chaos | FIXED | 3/2 | CORE, SET | Split the invalid combined add/Set filter: monsters can be added to hand, while Crying Chaos Spells/Traps can only be Set, with branch and SZONE legality checked before selection. |
| 217 | 252513554 | Guardian of Crying Chaos | PASS | 3/3 | CORE, NEG | Protection/negation and target scopes are sound. |
| 218 | 224943273 | Goat of Crying Chaos | PASS | 4/2 | CORE | Summon and follow-up success gates correctly match the text. |
| 219 | 227610954 | Zenatil, Criminal Bookkeeper of Crying Chaos | PASS | 4/3 | CORE, NV | Search, GY access, and restriction effects are complete. |
| 220 | 239725695 | Zebra of Crying Chaos | PASS | 4/2 | CORE | Target and operation filters remain valid at resolution. |
| 221 | 249018041 | Ram of Crying Chaos | PASS | 4/3 | CORE, NV | Cost, recovery, and summon clauses map cleanly. |
| 222 | 220305422 | Natir, the Swords Master of Crying Chaos | PASS | 4/2 | CORE, NEG | Battle/negation sequencing follows official patterns. |
| 223 | 234296128 | Revelation of Crying Chaos | PASS | 4/2 | CORE, TOP | Top-of-Deck access and disposition follow official excavation patterns. |
| 224 | 241880822 | Chrono-Saur Raptor | PASS | 4/4 | CORE | Summon and temporal restrictions are represented and scoped correctly. |
| 225 | 233499093 | Dragon of Crying Chaos | PASS | 4/2 | CORE, NEG | Negation and resolution follow-up are correctly gated. |
| 226 | 247779405 | Windborne Swiftsurfer | PASS | 4/4 | CORE, SYN | Synchro procedure and triggered effects follow official structure. |
| 227 | 258241424 | Light Within the Crying Chaos | PASS | 3/2 | CORE, NV | Targeting and GY handling are correct. |
| 228 | 217029078 | Windborne Cloudwing | PASS | 4/4 | CORE, SYN | Synchro and trigger clauses are complete. |
| 229 | 216294702 | A Throne of Crying Chaos | PASS | 2/2 | CORE, FIELD | Placement/activation and continuous handling are sound. |
| 230 | 255953418 | A World of Crying Chaos | PASS | 3/3 | CORE, FIELD | Field activation, search, and ongoing restrictions map cleanly. |
| 231 | 221759221 | Windborne Cartographer | FIXED | 5/5 | CORE, SYN | Excluded the handler from optional hand cards to shuffle, preventing the cost/operation from shuffling itself instead of completing its Special Summon. |
| 232 | 253472430 | A Whisper of Crying Chaos | PASS | 3/6 | CORE, NV | Continuous and GY effects require multiple registrations and are correctly scoped. |
| 233 | 215068354 | Janna, Windborne Goddess of the Temple | FIXED | 4/4 | CORE, SYN | Excluded the handler from the optional hand-shuffle group so its own Special Summon cannot be invalidated by self-selection. |
| 234 | 257794541 | Maryam, Windborne Caretaker of the Temple | FIXED | 4/4 | CORE, SYN | Excluded the handler from optional hand cards to shuffle, preserving the required Special Summon. |
| 235 | 251571153 | Sunken Temple of the Windborne | PASS | 4/3 | CORE, FIELD | Activation and field-continuous clauses are correctly scoped. |
| 236 | 231273040 | Windborne Howling Gale | PASS | 2/1 | CORE, NEG | Negate/follow-up sequence uses correct target and resolution checks. |
| 237 | 256110263 | Windborne Eye of the Storm | MANUAL | 1/1 | SYN | The script uses a temporary synthetic Token material to emulate "treated as a Synchro Summon using only Windborne"; this bespoke engine workaround needs live validation. |
| 238 | 238064522 | Windborne Galesong Flock | PASS | 1/1 | SYN | Synchro procedure/restriction maps to the printed clause. |
| 239 | 233212369 | Windborne Divine Whirlwind | FIXED | 1/1 | DELAY, SET | Implemented the actual resolution choice: either Set the selected cards immediately or schedule all selected cards for next Standby-Phase recovery; delayed group has a turn guard and correct reset lifetime. |
| 240 | 215006791 | Muntith, Windborne Skydragon of the Shining Sun | PASS | 5/4 | CORE, SYN, NEG | Synchro, negation, and follow-up clauses map cleanly. |
| 241 | 237684285 | Janna, Windborne Goddess of Clement Winds | PASS | 5/3 | CORE, SYN | Procedure and compound triggered effects are correctly gated. |
| 242 | 224774049 | Pot of Gambling | MANUAL | 2/1 | TOP | Printed text does not unambiguously state the default disposition/order for excavated cards; implementation choice requires a ruling. |
| 243 | 255686110 | Iscylla, Windborne Kraken of Sunken Depths | PASS | 6/8 | CORE, SYN, NEG | Multiple protection/trigger registrations cover all clauses with correct scopes. |
| 244 | 215885404 | Pot of Fortune | PASS | 2/1 | TOP | Excavation and selection/disposition follow official top-of-Deck patterns. |
| 245 | 243194249 | Shining Brigade - Hope Division | PASS | 5/4 | CORE, XYZ | Xyz procedure, material operations, and restrictions map cleanly. |
| 246 | 232038002 | Shining Brigade - Forward Division | PASS | 5/3 | CORE, XYZ | Xyz material and compound effect handling follow official patterns. |
| 247 | 232100722 | Shining Brigade - Flowering Division | PASS | 4/2 | CORE, XYZ | Costs, targets, and material checks are sound. |
| 248 | 230812008 | Shining Brigade - Loving Division | FIXED | 4/3 | CORE, XYZ, SET | Added Spell/Trap Zone availability checks at targeting and resolution for the granted material-Set effect. |
| 249 | 220124524 | Shining Brigade - Heartbeat Division | PASS | 5/5 | CORE, XYZ | Procedure, material effects, and restrictions cover the text. |
| 250 | 255668557 | Shining Brigade - Joyous Division | PASS | 4/4 | CORE, XYZ | Material removal and follow-up operations use valid targets and success gates. |
| 251 | 243420199 | Shining Brigade - Melody Division | PASS | 3/2 | CORE, XYZ | Xyz and material-related clauses map cleanly. |
| 252 | 236616849 | Shining Brigade - Revenge Division | PASS | 5/5 | CORE, XYZ, NEG | Negation, material, and destruction sequencing follow official patterns. |
| 253 | 223750159 | Shining Brigade Armada | PASS | 4/4 | CORE, XYZ | Xyz procedure and granted/triggered effects are complete. |
| 254 | 244986323 | Shining Brigade Origins | FIXED | 8/6 | CORE, XYZ | Added the shared HOPT to the destroy/tribute placement effect; overlay selection now requires face-up cards that pass `IsCanOverlay`. |
| 255 | 232824319 | Shining Brigade - Companion Team | PASS | 4/3 | CORE, XYZ | Material and recovery effects map cleanly. |
| 256 | 241504188 | Shining Brigade - Absolute Supremacy | PASS | 4/2 | CORE, NEG | Activation/negation and follow-up clauses are correctly success-gated. |
| 257 | 238841732 | Let's Go, Shining Brigade! | PASS | 4/2 | CORE, XYZ | Summon/material operations check zones and legality at resolution. |
| 258 | 226827770 | The One Called Forth | FIXED | 1/1 | ANN, NEG | `Duel.AnnounceCard` now dynamically excludes names already controlled; cannot-inactivate protection now applies only to summon-category effects instead of unrelated effects that merely mention the name. |
| 259 | 215142357 | Shining Brigade - Stand Together! | FIXED | 4/5 | CORE, XYZ | Protection now includes this card itself; detaching an Xyz material is a true cost, with the chosen Xyz stored and rechecked before attachment from hand/GY. |
| 260 | 238976759 | We're the Shining Brigade! | PASS | 3/2 | CORE, XYZ | Activation and material-placement clauses map cleanly. |
| 261 | 237692523 | Pixie Bot | FIXED | 3/2 | CORE, LINK | Activation now requires a genuinely free Main Monster Zone pointed to by a Link Monster, and the same linked-zone legality is rechecked at resolution. |
| 262 | 249629457 | Shining Brigade - Last Stand | PASS | 3/3 | CORE, XYZ | Costs, target scope, and material follow-up are sound. |
| 263 | 234507067 | Chrono-Saur Brachio | PASS | 4/3 | CORE | Summon and phase-related clauses are represented. |
| 264 | 235637994 | Chrono-Saur Dactylus | FIXED | 4/5 | CORE | Removed an erroneous opponent-turn-only condition; the printed Battle Phase effect is now available in either player's Battle Phase. |
| 265 | 259235389 | Chrono-Saur Tricera | PASS | 5/4 | CORE | Phase timing, restrictions, and operations map cleanly. |
| 266 | 255048812 | Chrono-Saur Stegian | FIXED | 4/3 | CORE | Initial destruction now checks destructibility and includes own Chrono-Saur Spell/Trap cards; optional post-summon destruction only offers destructible hand/field cards. |
| 267 | 236898203 | Chrono-Saur Rex | MANUAL | 4/2 | CORE, DELAY | Fixed prerequisite destruction to own face-up on-field Chrono/Dinosaur cards and scheduled self-destruction for the actual summoning phase (Main Phase 1 or Battle Phase); `EVENT_PHASE+PHASE_MAIN1` lacks an exact official analogue and needs live timing validation. |
| 268 | 251236672 | Chrono-Saur Laplace Plesio | MANUAL | 5/5 | CORE, TURN | Fixed ATK/DEF reset to the next own Battle Phase and limited post-battle selection to destructible own cards; shared "previous effects once per turn" wording remains ruling-sensitive. |
| 269 | 259226793 | Chrono-Saur Force | FIXED | 4/3 | CORE | Optional destroy choice now offers only destructible original-handler/own hand-field cards. |
| 270 | 213530841 | Chrono-Saur Counter | FIXED | 4/3 | CORE, NEG | Optional destroy choice now filters the original handler and own hand/field cards for actual destructibility. |
| 271 | 253928485 | Aqua Whirlpool | PASS | 3/1 | CORE | Activation and compound operation are correctly gated. |
| 272 | 259366507 | Aquila, Zephorion's Predictor | PASS | 5/5 | CORE, NV | Summon, search, and GY effects map cleanly. |
| 273 | 257081514 | Auriga of the Eldoran Empire | PASS | 5/5 | CORE, NV | All summon/trigger/recovery clauses have correct timing and scope. |
| 274 | 213990492 | Eridani, Squire of Zephorion Prime | PASS | 4/3 | CORE, NV | Target and GY access checks are correct. |
| 275 | 244972185 | The Spires of Zephorion Prime | FIXED | 4/3 | CORE, FIELD | Destruction replacement now requires that the destroyed monster's reason player is the opponent, as printed. Field-Spell activation from Deck matches official patterns. |
| 276 | 241957394 | Chapter Ii Verse Iv | MANUAL | 2/1 | CHAIN | Corrected rewritten chain target to the Effect Monster actually chosen and rewrote sequencing to destroy other matching monsters first, then the chosen monster only on success; retroactive Token-tribute/cost semantics still require an Omega duel test. |
| 277 | 212737555 | Aqua Droplet | PASS | 5/2 | CORE | Summon and compound resolution clauses map cleanly. |
| 278 | 238035167 | Aquamarine Moon Aurelia | PASS | 5/3 | CORE, XYZ | Xyz procedure, material effects, and restrictions are sound. |
| 279 | 220150285 | Aquamarine Plate Montipora | PASS | 3/3 | CORE, XYZ | Targeting/material handling maps to all clauses. |
| 280 | 211682274 | Aquamarine Pisaster Giga | PASS | 5/3 | CORE, XYZ | Xyz procedure and compound material effects follow official structure. |

## Per-card results: ordinals 281-390

| Ordinal | Omega ID | Card | Coverage | Verdict | Official family / findings |
|---:|---:|---|---|---|---|
| 281 | 251191343 | Aquamarine Asthenosoma | All printed clauses; 3 explicit registration sites | FIXED | Added the printed once-per-turn oath to the GY summon procedure. |
| 282 | 221509060 | Aquamarine Calling | All printed clauses; 1 explicit registration sites | PASS | Current clauses match the cited CORE pattern family. |
| 283 | 259998396 | Treasure of the Cosmic Ocean | All printed clauses; 1 explicit registration sites | PASS | Current clauses match the cited CORE pattern family. |
| 284 | 227035644 | Aqua Fusion | All printed clauses; 2 explicit registration sites | PASS | Current clauses match the cited NV, FUS pattern family. |
| 285 | 255082735 | Aquamarine Bubble Surge | All printed clauses; 2 explicit registration sites | PASS | Current clauses match the cited FUS pattern family. |
| 286 | 250339529 | Aquamarine Planktonites | All printed clauses; 2 explicit registration sites | PASS | Current clauses match the cited NV, FUS pattern family. |
| 287 | 241976572 | Aquamarine Nautilus | All printed clauses; 4 explicit registration sites | PASS | Current clauses match the cited NV pattern family. |
| 288 | 216258796 | Aquamarine Actinia | All printed clauses; 2 explicit registration sites | FIXED | Added the printed once-per-turn oath to the GY summon procedure. |
| 289 | 249746105 | Aquamarine Physalia | All printed clauses; 1 explicit registration sites | PASS | Current clauses match the cited NV, FUS pattern family. |
| 290 | 225161820 | Aquamarine Glaucus | All printed clauses; 4 explicit registration sites | PASS | Current clauses match the cited NV, FUS pattern family. |
| 291 | 259920959 | Aquamarine Reef Hapalochlaena | All printed clauses; 3 explicit registration sites | PASS | Current clauses match the cited NV, FUS pattern family. |
| 292 | 258260221 | Hiding "c" | All printed clauses; 3 explicit registration sites | PASS | Current clauses match the cited NV pattern family. |
| 293 | 259174227 | Farad, the Purple Ohmen | All printed clauses; 2 explicit registration sites | FIXED | Primary pass fixes rechecked against the current script and official family. |
| 294 | 259726853 | Volt, the Green Ohmen | All printed clauses; 2 explicit registration sites | FIXED | Primary pass fixes rechecked against the current script and official family. |
| 295 | 259650132 | Ampere, the Yellow Ohmen | All printed clauses; 3 explicit registration sites | FIXED | Primary pass fixes rechecked against the current script and official family. |
| 296 | 259107906 | Siemens, the Blue Ohmen | All printed clauses; 2 explicit registration sites | FIXED | Primary pass fixes rechecked against the current script and official family. |
| 297 | 259881255 | Coulomb, the White Ohmen | All printed clauses; 3 explicit registration sites | FIXED | Primary pass fixes rechecked against the current script and official family. |
| 298 | 259780273 | Carcel, the Dark Ohmen | All printed clauses; 2 explicit registration sites | MANUAL | Added the official retroactive Ohmen-only Special Summon activity lock. Custom reveal/two-card summon and traversal behavior still needs duel-engine validation. |
| 299 | 259869259 | Ohmen Surge | All printed clauses; 3 explicit registration sites | MANUAL | Moved the once-per-turn limit to card activation; the continuous control effect is no longer falsely limited. EVENT_ADJUST co-link tracking and forced zone-control movement are custom mechanics. |
| 300 | 259405917 | Siemens, the Ohmechanic Conductor | All printed clauses; 4 explicit registration sites | MANUAL | Prevented the move effect from activating without a free Main Monster Zone. Custom co-link destination movement remains an in-engine UI/ruling risk. |
| 301 | 259350270 | Farad, the Ohmechanic Capacitor | All printed clauses; 4 explicit registration sites | MANUAL | Custom Current Counter traversal/removal across mutually linked cards needs engine validation. |
| 302 | 259519336 | Volt, the Ohmechanic Chocker | All printed clauses; 4 explicit registration sites | MANUAL | Moved all-counter payment to cost and made the destruction correctly non-targeting. Custom counter-threshold continuous/Quick interaction needs live validation after the confirmed fixes. |
| 303 | 259841490 | Coulomb, the Ohmechanic Charger | All printed clauses; 4 explicit registration sites | MANUAL | Prevented the Link-monster move effect from activating without a free Main Monster Zone. Immediate Link Summon and custom zone movement need live Extra Monster Zone validation. |
| 304 | 259479044 | Ampere, the Ohmechanic Intensity | All printed clauses; 5 explicit registration sites | MANUAL | Custom counter placement/protection over co-linked monsters needs live validation. |
| 305 | 259033429 | Carcel, the Ohmechanic Light | All printed clauses; 4 explicit registration sites | MANUAL | Moved mass Current Counter removal out of target and into cost. EVENT_ADJUST co-link transition tracking and mass counter consumption need live validation. |
| 306 | 259434499 | Ohmen Powerload | All printed clauses; 3 explicit registration sites | MANUAL | Added the official retroactive Thunder-only Special Summon activity lock. Custom optional counter removal/destruction branch needs UI validation. |
| 307 | 259650969 | Ohmen Beacon | All printed clauses; 3 explicit registration sites | MANUAL | Prevented the move effect from activating without a free Main Monster Zone. Continuous co-link protection and movement/counter placement need live validation. |
| 308 | 245452058 | Altergeist Pipesiren | All printed clauses; 4 explicit registration sites | PASS | Current clauses match the cited NV pattern family. |
| 309 | 211873618 | Altergeist Regissae | All printed clauses; 6 explicit registration sites | PASS | Current clauses match the cited NEG, NV, LINK pattern family. |
| 310 | 252552954 | Altergeist Ifritware | All printed clauses; 2 explicit registration sites | FIXED | Made the post-negate Altergeist Trap recovery mandatory and required it at activation. |
| 311 | 259152704 | Dragon Protector of Nature | All printed clauses; 3 explicit registration sites | PASS | Current clauses match the cited NV, SYN pattern family. |
| 312 | 212055290 | Advent of Cosmic Beings | All printed clauses; 1 explicit registration sites | PASS | Current clauses match the cited CORE pattern family. |
| 313 | 259225324 | Transcend the Pendulum | All printed clauses; 2 explicit registration sites | FIXED | Made both Pendulum placements mandatory when possible and enforced different-name pair legality. |
| 314 | 250902476 | Striking Mirror Force | All printed clauses; 2 explicit registration sites | PASS | Current clauses match the cited CORE pattern family. |
| 315 | 228464260 | Rising Elemental | All printed clauses; 3 explicit registration sites | PASS | Current clauses match the cited NV, SYN pattern family. |
| 316 | 253152295 | Yummy Kuriboh | All printed clauses; 2 explicit registration sites | PASS | Current clauses match the cited NEG, NV pattern family. |
| 317 | 256207361 | Sealed Glyphs Dragon | All printed clauses; 3 explicit registration sites | PASS | Current clauses match the cited XYZ pattern family. |
| 318 | 236721134 | Devotee of Fire | All printed clauses; 6 explicit registration sites | MANUAL | Source text gives the Set effect no activation condition; current on-summon interpretation needs a ruling. |
| 319 | 224811863 | Shaman of Fire | All printed clauses; 3 explicit registration sites | FIXED | Primary pass fixes rechecked against the current script and official family. |
| 320 | 240104048 | Guardian of Fire | All printed clauses; 3 explicit registration sites | FIXED | Primary pass fixes rechecked against the current script and official family. |
| 321 | 257239133 | Phlogistic Uprising! | All printed clauses; 3 explicit registration sites | MANUAL | Excluded illegal LP payments that would reduce LP below the engine minimum. Fusion Summon from GY/Extra with mixed send/shuffle materials is custom and needs live validation. |
| 322 | 219714894 | Phlogistic Ignition | All printed clauses; 4 explicit registration sites | PASS | Current clauses match the cited NV pattern family. |
| 323 | 236815197 | Phlogiston's Wake | All printed clauses; 3 explicit registration sites | FIXED | Primary pass fixes rechecked against the current script and official family. |
| 324 | 242094473 | Phlogiston Dragon | All printed clauses; 6 explicit registration sites | PASS | Current clauses match the cited NV pattern family. |
| 325 | 230303021 | Phlogistic Scorching Dragon Horde | All printed clauses; 4 explicit registration sites | FIXED | Corrected Fusion materials to 1 Level 8 Phlogiston Dragon + exactly 2 other FIRE monsters; destruction now chooses the exact available count. |
| 326 | 220538776 | Curryboh | All printed clauses; 2 explicit registration sites | PASS | Current clauses match the cited NV pattern family. |
| 327 | 249805098 | Starry Knight Arc-En-Ciel | All printed clauses; 2 explicit registration sites | PASS | Current clauses match the cited NEG, NV pattern family. |
| 328 | 238241974 | Starry Knight Nebriel | All printed clauses; 3 explicit registration sites | FIXED | Added resolution-time Necrovalley recheck to the self-revival. |
| 329 | 248760718 | Starry Knight Starry Queen | All printed clauses; 4 explicit registration sites | PASS | Current clauses match the cited NV, SETTURN pattern family. |
| 330 | 221924008 | Chamroshes' Aegis | All printed clauses; 5 explicit registration sites | MANUAL | Contact-style Extra Deck summon by shuffling three differently named Tuners needs procedure validation. |
| 331 | 212413422 | Gaia, the Iron Clad Knight | All printed clauses; 5 explicit registration sites | PASS | Current clauses match the cited NV, FUS, DELAY pattern family. |
| 332 | 238256111 | Cursed Dragon of the Knight | All printed clauses; 3 explicit registration sites | PASS | Current clauses match the cited NV pattern family. |
| 333 | 222476063 | Gaia the Magnificent Knight | All printed clauses; 4 explicit registration sites | PASS | Current clauses match the cited NV pattern family. |
| 334 | 223770816 | Blazing Gaia the Spiral Knight | All printed clauses; 5 explicit registration sites | PASS | Current clauses match the cited NV, FUS, COPY pattern family. |
| 335 | 256469525 | Dynatos, the Challenger | All printed clauses; 5 explicit registration sites | PASS | Current clauses match the cited COPY pattern family. |
| 336 | 259366591 | Arckcestial Crystal Shards | All printed clauses; 2 explicit registration sites | FIXED | Applied the LIGHT Spellcaster "also" lock independently of summon success. |
| 337 | 241440521 | Arckcestial Feather | All printed clauses; 3 explicit registration sites | FIXED | Applied the Normal/Special Summon "also" lock independently of search success. |
| 338 | 245354354 | Arckcestial Fireball | All printed clauses; 3 explicit registration sites | FIXED | Added Necrovalley legality/recheck to the mandatory discarded-card revival. |
| 339 | 228860650 | Arckcestial Orb | All printed clauses; 2 explicit registration sites | FIXED | Applied the LIGHT Spellcaster "also" lock independently of self-summon success. |
| 340 | 214511076 | Arckcestial Prism | All printed clauses; 2 explicit registration sites | PASS | Current clauses match the cited NV, SYN pattern family. |
| 341 | 258328859 | Arckcestial Descend | All printed clauses; 3 explicit registration sites | FIXED | Applied the LIGHT Spellcaster "also" lock even if the Deck action becomes impossible; added Set/Necrovalley legality. |
| 342 | 258590942 | Arckcestial Meadow | All printed clauses; 3 explicit registration sites | FIXED | Applied the LIGHT Spellcaster "also" lock independently of search/discard success. |
| 343 | 235051716 | Arckcestial Pillar of Heavens | All printed clauses; 3 explicit registration sites | PASS | Current clauses match the cited NV pattern family. |
| 344 | 228635967 | Rank-Up-Magic Key of Arck Celestial Force | All printed clauses; 2 explicit registration sites | PASS | Current clauses match the cited NV, XYZ pattern family. |
| 345 | 235612490 | Urphiel's Feather Downpour | All printed clauses; 2 explicit registration sites | MANUAL | Added activation-time Necrovalley legality to the discarded self-Set trigger. The second field banish wording and discard-to-Set timing remain ruling-sensitive. |
| 346 | 239235967 | Arckcestial Burning | All printed clauses; 2 explicit registration sites | FIXED | Added activation-time Necrovalley legality to the discarded self-Set trigger. |
| 347 | 219995840 | Light Illusion of Vazagiel | All printed clauses; 2 explicit registration sites | FIXED | Added activation-time Necrovalley legality to the discarded self-Set trigger. |
| 348 | 257176166 | Malphiel, Arckcestial of Protection | All printed clauses; 4 explicit registration sites | PASS | Current clauses match the cited NV, XYZ, SYN, COPY pattern family. |
| 349 | 228386117 | Vazagiel, Arckcestial of Secrets | All printed clauses; 4 explicit registration sites | FIXED | Primary pass fixes rechecked against the current script and official family. |
| 350 | 237089049 | Azeriel, Arckcestial of Demise | All printed clauses; 4 explicit registration sites | FIXED | Added resolution-time Necrovalley recheck to the GY self-summon. |
| 351 | 251710981 | Ophiel, Arckcestial of Wisdom | All printed clauses; 3 explicit registration sites | FIXED | Added resolution-time Necrovalley recheck to the GY self-summon. |
| 352 | 231089172 | Sarifiel, Arckcestial of Moonlight | All printed clauses; 2 explicit registration sites | PASS | Current clauses match the cited NV, XYZ pattern family. |
| 353 | 215105971 | Urphiel, the High Arckcestial | All printed clauses; 3 explicit registration sites | MANUAL | Optional destruction replacement and owner-control leave-field trigger need live validation. |
| 354 | 220856437 | Bauy Magician | All printed clauses; 3 explicit registration sites | PASS | Current clauses match the cited NV, SYN, LINK pattern family. |
| 355 | 250047045 | Dreaming Bau | All printed clauses; 2 explicit registration sites | PASS | Current clauses match the cited NV, SYN pattern family. |
| 356 | 219826457 | Ro-Bau | All printed clauses; 6 explicit registration sites | FIXED | Primary pass fixes rechecked against the current script and official family. |
| 357 | 221511784 | Bau | All printed clauses; 4 explicit registration sites | FIXED | Allowed generic facedown field cards as the non-Bau banishment payment and rechecked Necrovalley on revival. |
| 358 | 237444604 | Winged Bauy Fenrir | All printed clauses; 2 explicit registration sites | PASS | Current clauses match the cited NEG, NV, SYN pattern family. |
| 359 | 256462992 | Starfury Bauy Dragon | All printed clauses; 3 explicit registration sites | PASS | Current clauses match the cited NV, SYN pattern family. |
| 360 | 228169392 | Bael, Demon Incarnate | All printed clauses; 5 explicit registration sites | FIXED | Primary pass fixes rechecked against the current script and official family. |
| 361 | 226950506 | Bauy World | All printed clauses; 3 explicit registration sites | PASS | Current clauses match the cited NV, LINK pattern family. |
| 362 | 254215159 | Bauy Spellcasting | All printed clauses; 5 explicit registration sites | PASS | Current clauses match the cited NEG, NV, SETTURN pattern family. |
| 363 | 225358630 | Rai-Bau | All printed clauses; 4 explicit registration sites | PASS | Current clauses match the cited NEG, NV, SETTURN pattern family. |
| 364 | 223366685 | Bauy Emergency Room! | All printed clauses; 4 explicit registration sites | PASS | Current clauses match the cited NV pattern family. |
| 365 | 259072745 | Bhodi, the Corrupted Halloween Tree | All printed clauses; 6 explicit registration sites | FIXED | Primary pass fixes rechecked against the current script and official family. |
| 366 | 233957828 | Toddler Pumpkien | All printed clauses; 2 explicit registration sites | PASS | Current clauses match the cited NV, LINK pattern family. |
| 367 | 259471193 | Dreadful Soul Drain | All printed clauses; 2 explicit registration sites | FIXED | Primary pass fixes rechecked against the current script and official family. |
| 368 | 212822164 | Bray, Shell of the Ghoti | All printed clauses; 2 explicit registration sites | PASS | Current clauses match the cited NV pattern family. |
| 369 | 235352857 | Shekup, Sting of the Ghoti | All printed clauses; 5 explicit registration sites | PASS | Current clauses match the cited NV, DELAY pattern family. |
| 370 | 240575550 | Ghoti from a Deeper Depth Than the Deepest Deep | All printed clauses; 4 explicit registration sites | MANUAL | Custom Synchro material rule allowing a Fish Tuner as non-Tuner needs live validation. |
| 371 | 255283389 | Myutant El-51 | All printed clauses; 2 explicit registration sites | PASS | Current clauses match the cited NV pattern family. |
| 372 | 244816828 | Myutant Evolution | All printed clauses; 2 explicit registration sites | PASS | Current clauses match the cited NV pattern family. |
| 373 | 211699737 | Myutant Amalgamate | All printed clauses; 2 explicit registration sites | MANUAL | "This effect becomes that monster's original effect" is approximated with CopyEffect and needs a ruling. |
| 374 | 259308265 | Pumpqueen the Queen of Ghosts | All printed clauses; 1 explicit registration sites | MANUAL | The extra Normal Summon is implemented, but hand Tributes for Castle of Dark Illusions need a ruling/engine implementation. |
| 375 | 239028111 | Pumprince the Prince of Ghosts | All printed clauses; 4 explicit registration sites | PASS | Current clauses match the cited DELAY pattern family. |
| 376 | 230749983 | Hallo, the Giver of Tricks | All printed clauses; 3 explicit registration sites | PASS | Current clauses match the cited NV pattern family. |
| 377 | 250262550 | Ween, Guidance to Treats | All printed clauses; 4 explicit registration sites | PASS | Current clauses match the cited NV pattern family. |
| 378 | 231331942 | Hallo, the Hollow Trickster | All printed clauses; 3 explicit registration sites | MANUAL | Hallo, the Spirit of Tricks is absent from cards.json/DB, so the first effect cannot fully resolve. |
| 379 | 224800873 | Hallo-Ween! Basket of Treats | All printed clauses; 2 explicit registration sites | PASS | Current clauses match the cited NV pattern family. |
| 380 | 255977900 | Happy Hallo-Ween! | All printed clauses; 3 explicit registration sites | PASS | Current clauses match the cited NV pattern family. |
| 381 | 215621622 | A Night of Fright on Hallo-Ween! | All printed clauses; 1 explicit registration sites | PASS | Current clauses match the cited NV pattern family. |
| 382 | 221672256 | Skewy! Boo Boo | All printed clauses; 2 explicit registration sites | PASS | Current clauses match the cited NEG, NV pattern family. |
| 383 | 258576611 | Skewy! Candee Hex | All printed clauses; 7 explicit registration sites | FIXED | Required the full printed 2 Candy Counters instead of silently falling back to 1. |
| 384 | 252496004 | Skewy! Pumpki-Pal | All printed clauses; 4 explicit registration sites | FIXED | Primary pass fixes rechecked against the current script and official family. |
| 385 | 234592047 | Skewy! Twick-Or-Tweat | All printed clauses; 1 explicit registration sites | PASS | Current clauses match the cited CORE pattern family. |
| 386 | 217632789 | Skewy! Pawty Tyme | All printed clauses; 2 explicit registration sites | FIXED | Allowed the revival follow-up after successful destruction even when the destroyed card is redirected from the GY. |
| 387 | 254375894 | Crewal Cap'n | All printed clauses; 4 explicit registration sites | FIXED | Added resolution-time Necrovalley recheck to the GY self-summon. |
| 388 | 237269434 | Crewal Crew | All printed clauses; 4 explicit registration sites | FIXED | Added resolution-time Necrovalley recheck before the GY self-summon follow-up. |
| 389 | 215730767 | Crewal Helmsman | All printed clauses; 4 explicit registration sites | PASS | Current clauses match the cited NV pattern family. |
| 390 | 250792632 | Crewal Sailor | All printed clauses; 4 explicit registration sites | FIXED | Added target and resolution-time Necrovalley checks to the GY recovery. |

## Lua files changed by this cross-review

- `public/CCG Downloads/CCG_Scripts/c251699681.lua`
- `public/CCG Downloads/CCG_Scripts/c259944943.lua`
- `public/CCG Downloads/CCG_Scripts/c240511702.lua`
- `public/CCG Downloads/CCG_Scripts/c221759221.lua`
- `public/CCG Downloads/CCG_Scripts/c215068354.lua`
- `public/CCG Downloads/CCG_Scripts/c257794541.lua`
- `public/CCG Downloads/CCG_Scripts/c233212369.lua`
- `public/CCG Downloads/CCG_Scripts/c230812008.lua`
- `public/CCG Downloads/CCG_Scripts/c244986323.lua`
- `public/CCG Downloads/CCG_Scripts/c226827770.lua`
- `public/CCG Downloads/CCG_Scripts/c215142357.lua`
- `public/CCG Downloads/CCG_Scripts/c237692523.lua`
- `public/CCG Downloads/CCG_Scripts/c235637994.lua`
- `public/CCG Downloads/CCG_Scripts/c255048812.lua`
- `public/CCG Downloads/CCG_Scripts/c236898203.lua`
- `public/CCG Downloads/CCG_Scripts/c251236672.lua`
- `public/CCG Downloads/CCG_Scripts/c259226793.lua`
- `public/CCG Downloads/CCG_Scripts/c213530841.lua`
- `public/CCG Downloads/CCG_Scripts/c244972185.lua`
- `public/CCG Downloads/CCG_Scripts/c241957394.lua`
- `public/CCG Downloads/CCG_Scripts/c251191343.lua`
- `public/CCG Downloads/CCG_Scripts/c216258796.lua`
- `public/CCG Downloads/CCG_Scripts/c259780273.lua`
- `public/CCG Downloads/CCG_Scripts/c259869259.lua`
- `public/CCG Downloads/CCG_Scripts/c259405917.lua`
- `public/CCG Downloads/CCG_Scripts/c259519336.lua`
- `public/CCG Downloads/CCG_Scripts/c259841490.lua`
- `public/CCG Downloads/CCG_Scripts/c259033429.lua`
- `public/CCG Downloads/CCG_Scripts/c259434499.lua`
- `public/CCG Downloads/CCG_Scripts/c259650969.lua`
- `public/CCG Downloads/CCG_Scripts/c252552954.lua`
- `public/CCG Downloads/CCG_Scripts/c259225324.lua`
- `public/CCG Downloads/CCG_Scripts/c257239133.lua`
- `public/CCG Downloads/CCG_Scripts/c230303021.lua`
- `public/CCG Downloads/CCG_Scripts/c238241974.lua`
- `public/CCG Downloads/CCG_Scripts/c259366591.lua`
- `public/CCG Downloads/CCG_Scripts/c241440521.lua`
- `public/CCG Downloads/CCG_Scripts/c245354354.lua`
- `public/CCG Downloads/CCG_Scripts/c228860650.lua`
- `public/CCG Downloads/CCG_Scripts/c258328859.lua`
- `public/CCG Downloads/CCG_Scripts/c258590942.lua`
- `public/CCG Downloads/CCG_Scripts/c235612490.lua`
- `public/CCG Downloads/CCG_Scripts/c239235967.lua`
- `public/CCG Downloads/CCG_Scripts/c219995840.lua`
- `public/CCG Downloads/CCG_Scripts/c237089049.lua`
- `public/CCG Downloads/CCG_Scripts/c251710981.lua`
- `public/CCG Downloads/CCG_Scripts/c221511784.lua`
- `public/CCG Downloads/CCG_Scripts/c258576611.lua`
- `public/CCG Downloads/CCG_Scripts/c217632789.lua`
- `public/CCG Downloads/CCG_Scripts/c254375894.lua`
- `public/CCG Downloads/CCG_Scripts/c237269434.lua`
- `public/CCG Downloads/CCG_Scripts/c250792632.lua`

## Verification

- `luac -p`, ordinals 173-390: PASS (218/218).
- `luac -p`, full public folder: PASS (592/592).
- Strict `initial_effect` smoke, ordinals 173-390: PASS (218/218; 536 effects created, 1227 callbacks attached, 579 effects registered).
- Strict `initial_effect` smoke, full public folder: PASS (592/592; 1562 effects created, 3479 callbacks attached, 1710 effects registered).
- Static scan for `require`, `dofile`, or `loadfile`: PASS (0 findings).
- DB, installed-Omega, ZIP, dist, and build verification were intentionally not run by this independent review lane; the parent audit owns final synchronization and artifact verification.


### Reconciled Data from ultimate_audit_cross_b_reviews_a.md
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



### Reconciled Data from ultimate_audit_cross_b_reviews_c.md
# Ultimate Lua audit — independent cross-review lane C

Scope: exact cards.json ordinals 391–577 (187 cards), independently rechecked clause-by-clause against current standalone Lua and official Omega patterns. Totals: **88 pass, 89 fixed, 10 need manual ruling**.

Legend: E1/E2/... means every created effect, procedure, helper effect, and clone was checked. Fixed retains primary-lane fixes and includes the cross-fixes named below.

| Ord. | Card (Omega ID) | Effect-level coverage | Primary official pattern(s) | Result | Note |
|---:|---|---|---|---|---|
| 391 | Morbydrip the Crewal Whale (210628767) | E1/E2/E3/E4 individually checked | c22804644/c101301087; c34124316/c120145032; c10004783/c10632284 | **Pass** | No defect found |
| 392 | Crewal Booty (222654570) | E1/E2/E3 individually checked | c10004783/c10632284 | **Pass** | No defect found |
| 393 | Crewal Meeting (210366076) | E1/E2/E3 individually checked | c10004783/c10632284 | **Pass** | No defect found |
| 394 | Crewal Tide (217645912) | E1/E2/E3 individually checked | c10004783/c10632284 | **Pass** | No defect found |
| 395 | Crewal Attack (219783132) | E1/E2/E3/E4 individually checked | c10004783/c10632284 | **Pass** | No defect found |
| 396 | Crewal Cursed Sea (252249599) | E1/E2/E3/E4/E5/E6 individually checked | procedure.lua + procedure family; c10004783/c10632284 | **Pass** | No defect found |
| 397 | Melville the Crewal Vessel (234599395) | E1/E2/E3/E4 individually checked | procedure.lua + procedure family; c10443957/c101203048; c34124316/c120145032; c10004783/c10632284 | **Pass** | No defect found |
| 398 | Ghostrick Bat (227531376) | E1/E2/E3/E4/E5 individually checked | c10443957/c101203048 | **Pass** | No defect found |
| 399 | Ghostrick Djinn (212052682) | E1/E2/E3/E4/E5/E6 individually checked | procedure.lua/constant.lua + closest family | **Fixed** | Corrected in ultimate pass |
| 400 | Ghostrick Slime (257677549) | E1/E2/E3/E4/E5 individually checked | procedure.lua/constant.lua + closest family | **Pass** | No defect found |
| 401 | Ghostrick Haunt (241540236) | E1/E2/E3 individually checked | procedure.lua/constant.lua + closest family | **Fixed** | Corrected in ultimate pass |
| 402 | Ghostrick Camella (235687149) | E1/E2 individually checked | procedure.lua + procedure family; c10443957/c101203048 | **Fixed** | Corrected in ultimate pass |
| 403 | Ghostrick Cutifer (228472690) | E1/E2 individually checked | procedure.lua + procedure family; c10443957/c101203048; c10004783/c10632284 | **Fixed** | Corrected in ultimate pass |
| 404 | Ghostrick Oni (239335848) | E1/E2/E3/E4 individually checked | procedure.lua + procedure family; c10443957/c101203048 | **Needs manual ruling** | Custom Xyz material transfer/Quick conversion |
| 405 | Ghostrick Pastrygeist (259851064) | E1/E2/E3 individually checked | procedure.lua + procedure family | **Fixed** | Corrected in ultimate pass |
| 406 | Vampire Avenger (259815138) | E1/E2/E3 individually checked | procedure.lua/constant.lua + closest family | **Fixed** | Corrected in ultimate pass |
| 407 | Vampire Lugat (259524916) | E1/E2 individually checked | procedure.lua/constant.lua + closest family | **Pass** | No defect found |
| 408 | Vampire Reptilian (259552732) | E1/E2 individually checked | procedure.lua/constant.lua + closest family | **Needs manual ruling** | Opponent-monster Xyz material/control semantics |
| 409 | Vampire Traveler (259479818) | E1/E2/E3/E4 individually checked | procedure.lua/constant.lua + closest family | **Fixed** | Corrected in ultimate pass |
| 410 | Vampire Estrie (259144144) | E1/E2 individually checked | procedure.lua + procedure family | **Fixed** | Corrected in ultimate pass |
| 411 | Scarstech Prologue (224467692) | No effect: source text checked | procedure.lua/constant.lua + closest family | **Needs manual ruling** | Effect metadata conflicts with flavor-only text |
| 412 | Scarstech Crusader (232104829) | E1/E2/E3/E4 individually checked | procedure.lua/constant.lua + closest family | **Fixed** | Corrected in ultimate pass |
| 413 | Scarstech Dragon (240768497) | E1/E2/E3 individually checked | procedure.lua/constant.lua + closest family | **Pass** | No defect found |
| 414 | Scarstech Swarmer (248884592) | E1/E2/E3/E4 individually checked | procedure.lua/constant.lua + closest family | **Pass** | No defect found |
| 415 | Scarstech Sniper (233502817) | E1/E2 individually checked | procedure.lua/constant.lua + closest family | **Pass** | No defect found |
| 416 | Scarstech Beacon (245837578) | E1/E2 individually checked | procedure.lua/constant.lua + closest family | **Pass** | No defect found |
| 417 | Scarstech Principality (210175845) | E1/E2 individually checked | procedure.lua/constant.lua + closest family | **Fixed** | Corrected in ultimate pass |
| 418 | Scarstech Stagger (253934904) | E1/E2 individually checked | procedure.lua/constant.lua + closest family | **Fixed** | Corrected in ultimate pass |
| 419 | Scarstech Kaiser (239179363) | E1/E2/E3/E4/E5/E6/E7 individually checked | procedure.lua + procedure family | **Fixed** | Corrected in ultimate pass |
| 420 | Scarstech Invasion (244009988) | E1/E2/E3/E4/E5/E6/E7 individually checked | procedure.lua/constant.lua + closest family | **Fixed** | Corrected in ultimate pass |
| 421 | Scarstech Circuit (248891593) | E1/E2/E3/E4/E5/E6 individually checked | procedure.lua/constant.lua + closest family | **Fixed** | Corrected in ultimate pass |
| 422 | Scarstech Deployment (224235021) | E1/E2/E3/E4 individually checked | c100212004/c4290468 | **Fixed** | Cross-fix: removed unprinted End Phase expiry |
| 423 | Scarstech Blaster (243488958) | E1/E2/E3/E4 individually checked | procedure.lua/constant.lua + closest family | **Pass** | No defect found |
| 424 | Gravinity Orbit (249680945) | E1/E2/E3/E4/E5 individually checked | c34124316/c120145032; c10004783/c10632284 | **Fixed** | Corrected in ultimate pass |
| 425 | Nifal, the Scarstech War Machine (254894701) | E1/E2/E3/E4/E5/E6 individually checked | c13243124/c100256005 | **Fixed** | Cross-fix: exact ATK loss resolves as effect with reverse-update guard |
| 426 | Gravinity Plasma (235538173) | E1/E2/E3/E4/E5 individually checked | c34124316/c120145032; c10004783/c10632284 | **Fixed** | Corrected in ultimate pass |
| 427 | Ratsach, the Scarstech Cruiser (242838495) | E1/E2/E3/E4/E5/E6 individually checked | c13243124/c100256005 | **Fixed** | Cross-fix: exact ATK loss moved out of cost and rechecked |
| 428 | Gravinity Pulse (256172827) | E1/E2/E3/E4/E5 individually checked | c34124316/c120145032; c10004783/c10632284 | **Pass** | No defect found |
| 429 | Scarstech Crawler (213611313) | E1/E2/E3/E4 individually checked | procedure.lua + procedure family | **Pass** | No defect found |
| 430 | Chaos Honest (248638801) | E1/E2/E3/E4/E5 individually checked | procedure.lua + procedure family | **Pass** | No defect found |
| 431 | Gravinity Star (215768254) | E1/E2/E3/E4/E5/E6 individually checked | c34124316/c120145032; c10004783/c10632284 | **Fixed** | Corrected in ultimate pass |
| 432 | Gravinity Lapsix (212345347) | E1/E2/E3/E4 individually checked | procedure.lua + procedure family; c10004783/c10632284 | **Fixed** | Corrected in ultimate pass |
| 433 | Gravinity Galaxix (249454272) | E1/E2/E3/E4 individually checked | procedure.lua + procedure family | **Fixed** | Corrected in ultimate pass |
| 434 | Gravinity Nebulix (212429024) | E1/E2/E3/E4 individually checked | c16946849/c12421694; c10004783/c10632284 | **Fixed** | Cross-fix: additional action now occurs after the Spell/Trap resolves |
| 435 | Gravinity Spherix (231088629) | E1/E2/E3/E4/E5/E6 individually checked | procedure.lua + procedure family; c10443957/c101203048; c10004783/c10632284 | **Needs manual ruling** | Summon replacement plus minimum GY Xyz material |
| 436 | Gravinity Transfer Call (223505382) | E1/E2/E3 individually checked | c10004783/c10632284 | **Fixed** | Corrected in ultimate pass |
| 437 | Gravinity Gravity Protection (247919552) | E1/E2 individually checked | c10004783/c10632284 | **Fixed** | Corrected in ultimate pass |
| 438 | Gravinity Axis Matter (256831125) | E1/E2/E3/E4 individually checked | c23153227/c43331750/c70369116/c97769122 | **Needs manual ruling** | Copied-effect scope and printed Link Rating reduction are not exact |
| 439 | Gravinity Sonic Scream (238184015) | E1/E2/E3 individually checked | c23153227/c43331750/c70369116/c97769122; c100201001/c100235002; c10004783/c10632284 | **Needs manual ruling** | Copied activated-effect semantics |
| 440 | Unbinding the Soul (246900181) | E1 individually checked | procedure.lua/constant.lua + closest family | **Fixed** | Corrected in ultimate pass |
| 441 | Eclipse Summoning (251331463) | E1/E2 individually checked | procedure.lua/constant.lua + closest family | **Pass** | No defect found |
| 442 | Lowkey Lowkey (225260657) | No effect: source text checked | procedure.lua/constant.lua + closest family | **Pass** | No defect found |
| 443 | Flower Cardian Moonflare (248940511) | E1/E2/E3 individually checked | procedure.lua + procedure family; c100201001/c100235002 | **Needs manual ruling** | One card treated as 3 non-Tuners |
| 444 | Stardust Comet (231523659) | E1/E2/E3 individually checked | procedure.lua/constant.lua + closest family | **Needs manual ruling** | Deck Tribute/immediate Synchro/Level timing |
| 445 | Interwire Dimensquid (253128790) | E1/E2/E3/E4 individually checked | procedure.lua/constant.lua + closest family | **Pass** | No defect found |
| 446 | Oracle of the Herald (247298564) | E1/E2/E3/E4 individually checked | procedure.lua/constant.lua + closest family | **Pass** | No defect found |
| 447 | Galacticarina (234179728) | E1/E2/E3 individually checked | procedure.lua/constant.lua + closest family | **Pass** | No defect found |
| 448 | Galacticassiopeia (227335484) | E1/E2/E3 individually checked | procedure.lua/constant.lua + closest family | **Pass** | No defect found |
| 449 | Galacticanes Venatici (229021849) | E1/E2 individually checked | procedure.lua/constant.lua + closest family | **Pass** | No defect found |
| 450 | Galacticanes Auriga (220148485) | No effect: source text checked | procedure.lua/constant.lua + closest family | **Pass** | No defect found |
| 451 | Galataxian Battle Tactics (226902471) | E1/E2/E3/E4 individually checked | procedure.lua/constant.lua + closest family | **Pass** | No defect found |
| 452 | Galataxian Battle Formation (239127930) | E1/E2/E3/E4/E5 individually checked | procedure.lua/constant.lua + closest family | **Fixed** | Corrected in ultimate pass |
| 453 | Galataxian Battle Preparation (210696007) | E1/E2/E3/E4 individually checked | procedure.lua/constant.lua + closest family | **Fixed** | Corrected in ultimate pass |
| 454 | Galactican Battle Station (258934904) | E1/E2/E3/E4/E5 individually checked | procedure.lua/constant.lua + closest family | **Needs manual ruling** | Adds an effect to another resolving effect in Damage Step |
| 455 | Galactican Battle Grounds (250829750) | E1/E2/E3/E4 individually checked | c23153227/c43331750/c70369116/c97769122; c10004783/c10632284 | **Pass** | No defect found |
| 456 | Fusion Intergalactica (245395343) | E1/E2 individually checked | procedure.lua + procedure family | **Fixed** | Corrected in ultimate pass |
| 457 | Attack on Gravity (259307285) | E1/E2/E3 individually checked | c72930878; c100201001/c100235002 | **Needs manual ruling** | Card-wide hand permission cannot safely distinguish its two activation modes |
| 458 | Galactican Jet Dasher (256005703) | E1/E2/E3 individually checked | c50933533/c86321248; local Galacticarina | **Fixed** | Cross-fix: shared Damage Step guard prevents duplicate OR triggering |
| 459 | Galactican Jet Drifter (212837324) | E1/E2/E3/E4 individually checked | c50933533/c86321248; local Galacticarina | **Fixed** | Cross-fix: shared Damage Step guard prevents duplicate OR triggering |
| 460 | Carina, Forgotten of Eldora (259482393) | E1/E2/E3/E4 individually checked | procedure.lua + procedure family | **Pass** | No defect found |
| 461 | Cassiopeia, Forgotten of Eldora (250917339) | E1/E2/E3/E4 individually checked | procedure.lua + procedure family | **Pass** | No defect found |
| 462 | Aeloria in Depraevity (259230000) | E1/E2/E3/E4 individually checked | c23153227/c43331750/c70369116/c97769122; c10004783/c10632284 | **Fixed** | Corrected in ultimate pass |
| 463 | Galactican Machine - No. G2-X38 (253520299) | E1/E2 individually checked | procedure.lua + procedure family | **Pass** | No defect found |
| 464 | Intergalactican Machine - No. R2-D30 (236473882) | E1/E2 individually checked | procedure.lua + procedure family | **Pass** | No defect found |
| 465 | Cassiopeia of the Eldoran System (212377618) | E1 individually checked | procedure.lua/constant.lua + closest family | **Pass** | No defect found |
| 466 | Intergalacticanes Majoris (219002796) | E1/E2/E3/E4/E5/E6 individually checked | procedure.lua + procedure family | **Fixed** | Corrected in ultimate pass |
| 467 | To Protogenis Intergalataxiakos (221827483) | E1/E2/E3/E4/E5/E6/E7 individually checked | procedure.lua + procedure family | **Fixed** | Corrected in ultimate pass |
| 468 | Pray for Your Life! (259924331) | E1/E2 individually checked | procedure.lua/constant.lua + closest family | **Pass** | No defect found |
| 469 | Gladiator Beast Sabearius (259607933) | E1/E2 individually checked | procedure.lua/constant.lua + closest family | **Pass** | No defect found |
| 470 | Gladiator Beast Attrocitar (259395418) | E1/E2 individually checked | procedure.lua/constant.lua + closest family | **Pass** | No defect found |
| 471 | Gladiator Beast Satyrius (259363148) | E1/E2/E3/E4/E5 individually checked | c22804644/c101301087; procedure.lua + procedure family; c34124316/c120145032 | **Pass** | No defect found |
| 472 | Night Night Nemleria (259766646) | E1 individually checked | procedure.lua/constant.lua + closest family | **Pass** | No defect found |
| 473 | Pyjama Party of Happy Nemleria (259605536) | E1/E2/E3/E4 individually checked | procedure.lua/constant.lua + closest family | **Fixed** | Corrected in ultimate pass |
| 474 | Nemleria Big Eepy (259883971) | E1/E2/E3 individually checked | procedure.lua/constant.lua + closest family | **Fixed** | Corrected in ultimate pass |
| 475 | Nemleria's Nightmare (259017109) | E1/E2/E3 individually checked | procedure.lua/constant.lua + closest family | **Pass** | No defect found |
| 476 | Nemleria's Dream Bedroom (259090287) | E1/E2/E3/E4/E5/E6 individually checked | procedure.lua/constant.lua + closest family | **Pass** | No defect found |
| 477 | Nemleria Dream Creator Pyjama (259392825) | E1/E2/E3 individually checked | procedure.lua/constant.lua + closest family | **Pass** | No defect found |
| 478 | Nemleria Dream Devourer - Soleil (259472680) | E1/E2/E3/E4 individually checked | procedure.lua/constant.lua + closest family | **Fixed** | Corrected in ultimate pass |
| 479 | Nemleria Dream Creator - Veilleuse (259898110) | E1/E2/E3/E4 individually checked | procedure.lua/constant.lua + closest family | **Fixed** | Corrected in ultimate pass |
| 480 | Grayling, the Grayscale Imp (259934043) | E1/E2/E3/E4 individually checked | procedure.lua/constant.lua + closest family | **Pass** | No defect found |
| 481 | Graysentry, the Guard of Grayscale (259341133) | E1/E2/E3/E4 individually checked | procedure.lua + procedure family; c10443957/c101203048 | **Fixed** | Corrected in ultimate pass |
| 482 | Grayrover, the Wandering Grayscale (259937399) | E1/E2/E3/E4/E5/E6 individually checked | procedure.lua/constant.lua + closest family | **Pass** | No defect found |
| 483 | Graylock, the Sorcerer of Grayscale (259724129) | E1/E2/E3/E4 individually checked | procedure.lua/constant.lua + closest family | **Fixed** | Corrected in ultimate pass |
| 484 | Grayhex, the Chanter of Grayscale (259688514) | E1/E2/E3/E4 individually checked | procedure.lua/constant.lua + closest family | **Pass** | No defect found |
| 485 | Grayseer, the Grayscale Spy (259632020) | E1/E2/E3 individually checked | procedure.lua + procedure family | **Pass** | No defect found |
| 486 | Grayterror, the Grayscale Beast (259624110) | E1/E2/E3 individually checked | procedure.lua + procedure family; c10443957/c101203048 | **Pass** | No defect found |
| 487 | Graydimm, the Grayscale Shadow (259245496) | E1/E2/E3 individually checked | procedure.lua + procedure family | **Pass** | No defect found |
| 488 | Grayshade, the Phantom of Grayscale (259626409) | E1/E2/E3 individually checked | c22804644/c101301087; procedure.lua + procedure family; c10443957/c101203048 | **Pass** | No defect found |
| 489 | Graydeux, the Eternal Grayscale Entity (259229055) | E1/E2/E3 individually checked | c22804644/c101301087; procedure.lua + procedure family; c10443957/c101203048 | **Fixed** | Corrected in ultimate pass |
| 490 | Grayscale Awakening: Revelation (259923860) | E1/E2/E3/E4 individually checked | procedure.lua/constant.lua + closest family | **Fixed** | Corrected in ultimate pass |
| 491 | Grayscale Awakening: Eclipse (259203522) | E1/E2/E3 individually checked | procedure.lua/constant.lua + closest family | **Pass** | No defect found |
| 492 | Grayscale Awakening: Nullbind (259269688) | E1/E2/E3/E4 individually checked | c10443957/c101203048 | **Fixed** | Corrected in ultimate pass |
| 493 | The Misstakes of the A.I.P Experience (259275822) | No effect: source text checked | procedure.lua/constant.lua + closest family | **Fixed** | Corrected in ultimate pass |
| 494 | A.I.P Ex Larva (259609997) | E1/E2/E3/E4/E5 individually checked | c64767757; procedure.lua | **Fixed** | Cross-fix: revealed card reshuffles if optional summon does not succeed |
| 495 | A.I.P Ex Shrieker (259664027) | E1/E2/E3/E4 individually checked | c29047353; procedure.lua | **Fixed** | Cross-fix: mandatory summon lock precedes all early exits |
| 496 | A.I.P Ex Claw (259137697) | E1/E2/E3/E4 individually checked | procedure.lua + procedure family; c10443957/c101203048 | **Fixed** | Corrected in ultimate pass |
| 497 | A.I.P Ex Maw (259522807) | E1/E2/E3 individually checked | c53199020/c77297908 | **Fixed** | Cross-fix: rewrite no longer requires a currently destructible Beast |
| 498 | A.I.P Ex Predator (259121126) | E1/E2 individually checked | procedure.lua/constant.lua + closest family | **Fixed** | Corrected in ultimate pass |
| 499 | A.I.P Lab (259943152) | E1/E2/E3/E4/E5 individually checked | procedure.lua/constant.lua + closest family | **Fixed** | Corrected in ultimate pass |
| 500 | Failures of the A.I.P (259883029) | E1/E2 individually checked | c10443957/c101203048 | **Fixed** | Corrected in ultimate pass |
| 501 | A.I.P Ex Assimilation (259630851) | E1/E2/E3 individually checked | procedure.lua/constant.lua + closest family | **Fixed** | Corrected in ultimate pass |
| 502 | A.I.P Ex Hive Mind (259499577) | E1/E2 individually checked | procedure.lua/constant.lua + closest family | **Fixed** | Corrected in ultimate pass |
| 503 | Caller of the A.I.P Ex (259465391) | E1/E2/E3 individually checked | procedure.lua + procedure family; c34124316/c120145032 | **Fixed** | Corrected in ultimate pass |
| 504 | Zero Mother of the A.I.P Ex (259097228) | E1/E2/E3 individually checked | procedure.lua + procedure family; c10443957/c101203048 | **Fixed** | Corrected in ultimate pass |
| 505 | Red-Eyes Gearfried the Iron Knight (259466138) | E1/E2/E3/E4/E5 individually checked | procedure.lua/constant.lua + closest family | **Fixed** | Corrected in ultimate pass |
| 506 | Red-Eyes Moon Dragon (259992800) | E1/E2/E3/E4/E5 individually checked | c10004783/c10632284 | **Fixed** | Corrected in ultimate pass |
| 507 | Red-Eyes Meteor Metal Dragon (259184310) | E1/E2/E3/E4 individually checked | procedure.lua + procedure family; c23153227/c43331750/c70369116/c97769122 | **Fixed** | Corrected in ultimate pass |
| 508 | Red-Eyes Roar (259562343) | E1/E2/E3 individually checked | procedure.lua + procedure family; c23153227/c43331750/c70369116/c97769122 | **Pass** | No defect found |
| 509 | Red-Eyes Turbo Dragon (259114673) | E1/E2 individually checked | procedure.lua + procedure family | **Pass** | No defect found |
| 510 | Red-Eyes Booster Dragon (259628203) | E1/E2/E3/E4 individually checked | c22804644/c101301087; procedure.lua + procedure family | **Fixed** | Corrected in ultimate pass |
| 511 | Rush at the Gnome (259755133) | E1/E2/E3 individually checked | procedure.lua/constant.lua + closest family | **Pass** | No defect found |
| 512 | Calcu Leet (259825991) | E1 individually checked | procedure.lua/constant.lua + closest family | **Pass** | No defect found |
| 513 | Digita Leet (259138193) | E1/E2/E3 individually checked | procedure.lua + procedure family | **Pass** | No defect found |
| 514 | Virtua Leet (259940722) | E1/E2/E3/E4/E5/E6/E7 individually checked | procedure.lua + procedure family | **Fixed** | Corrected in ultimate pass |
| 515 | Herald of White Light (259688676) | E1/E2/E3 individually checked | procedure.lua + procedure family; c100201001/c100235002 | **Fixed** | Corrected in ultimate pass |
| 516 | Thunder Dragon Behemoth (259352030) | E1/E2/E3/E4 individually checked | c22804644/c101301087; procedure.lua + procedure family | **Pass** | No defect found |
| 517 | Aurelion Divine Illumination (259889864) | E1/E2 individually checked | c100201001/c100235002 | **Pass** | No defect found |
| 518 | Lance Luminar Justiciar (259373017) | E1/E2 individually checked | c34124316/c120145032 | **Pass** | No defect found |
| 519 | Scarstech Draco (259304399) | E1/E2 individually checked | procedure.lua/constant.lua + closest family | **Pass** | No defect found |
| 520 | Scarstech Wyvern (259531370) | E1/E2/E3/E4 individually checked | procedure.lua/constant.lua + closest family | **Fixed** | Corrected in ultimate pass |
| 521 | Scarstech Invader (259464700) | E1/E2/E3 individually checked | procedure.lua/constant.lua + closest family | **Pass** | No defect found |
| 522 | Ganan, the Scarstech City (259459462) | E1/E2/E3/E4 individually checked | procedure.lua + procedure family | **Pass** | No defect found |
| 523 | Qerets, the Scarstech Mother Ship (259086544) | E1/E2/E3/E4/E5 individually checked | c13243124/c100256005; c100201001/c100235002 | **Fixed** | Cross-fix: exact ATK loss rejects reverse updates and precedes negate |
| 524 | Adamantios, the Dark Armor (259315827) | E1/E2/E3/E4 individually checked | procedure.lua + procedure family | **Pass** | No defect found |
| 525 | Disciple of Fire (259023461) | E1/E2/E3/E4/E5 individually checked | procedure.lua/constant.lua + closest family | **Fixed** | Corrected in ultimate pass |
| 526 | Sorceress of Fire (259360287) | E1/E2/E3 individually checked | procedure.lua/constant.lua + closest family | **Pass** | No defect found |
| 527 | Phlogiston's Roar (259366281) | E1/E2/E3/E4 individually checked | c100201001/c100235002 | **Pass** | No defect found |
| 528 | Harpie Cyber Dancer (259794136) | E1/E2/E3 individually checked | procedure.lua/constant.lua + closest family | **Fixed** | Corrected in ultimate pass |
| 529 | Harpie Lady Sisters - Phoenix Formation (259269774) | E1/E2/E3/E4 individually checked | c22804644/c101301087; procedure.lua + procedure family | **Fixed** | Corrected in ultimate pass |
| 530 | Mirage Formation Dragon (259072169) | E1/E2/E3/E4 individually checked | procedure.lua + procedure family; c10443957/c101203048 | **Fixed** | Corrected in ultimate pass |
| 531 | Glitchling Bitron (259247807) | E1/E2/E3/E4/E5 individually checked | procedure.lua/constant.lua + closest family | **Fixed** | Corrected in ultimate pass |
| 532 | Glitchling Protron (259156549) | E1/E2/E3/E4/E5 individually checked | procedure.lua/constant.lua + closest family | **Pass** | No defect found |
| 533 | Glitchling Witch (259678739) | E1/E2/E3/E4/E5/E6 individually checked | procedure.lua/constant.lua + closest family | **Pass** | No defect found |
| 534 | Glitchling Data-Transfert (259961648) | E1/E2/E3/E4 individually checked | procedure.lua/constant.lua + closest family | **Pass** | No defect found |
| 535 | Glitchling Octron (259927462) | E1/E2 individually checked | procedure.lua + procedure family | **Pass** | No defect found |
| 536 | Glitchling Digitron (259494236) | E1/E2/E3/E4/E5 individually checked | c100201001/c100235002 | **Pass** | No defect found |
| 537 | Glitchling Mage (259072906) | E1/E2/E3/E4/E5 individually checked | procedure.lua/constant.lua + closest family | **Pass** | No defect found |
| 538 | Glitchling Leotron (259873115) | E1/E2/E3/E4/E5 individually checked | c100201001/c100235002 | **Pass** | No defect found |
| 539 | Glitchling Corruption (259546637) | E1/E2/E3 individually checked | procedure.lua/constant.lua + closest family | **Fixed** | Corrected in ultimate pass |
| 540 | Glitchling Hexatron (259253032) | E1/E2/E3/E4/E5/E6 individually checked | procedure.lua + procedure family | **Fixed** | Corrected in ultimate pass |
| 541 | Heart of the Cards (259485374) | E1/E2 individually checked | c22804644/c101301087; c34124316/c120145032 | **Fixed** | Corrected in ultimate pass |
| 542 | The Orcustograph (259576196) | E1/E2/E3 individually checked | procedure.lua + procedure family | **Fixed** | Corrected in ultimate pass |
| 543 | Galatea-2, the Orcust Divider (259646610) | E1/E2 individually checked | procedure.lua + procedure family | **Fixed** | Corrected in ultimate pass |
| 544 | Charmelia Kiana (259614449) | E1/E2 individually checked | c10004783/c10632284 | **Pass** | No defect found |
| 545 | Charmelia Hanabi (259790247) | E1/E2 individually checked | c10004783/c10632284 | **Pass** | No defect found |
| 546 | Charmelia Elysia (259288669) | E1/E2 individually checked | procedure.lua + procedure family; c34124316/c120145032 | **Fixed** | Corrected in ultimate pass |
| 547 | Charmelia Robin (259568843) | E1/E2 individually checked | procedure.lua/constant.lua + closest family | **Fixed** | Corrected in ultimate pass |
| 548 | Charmelia Pray (259241946) | E1/E2 individually checked | procedure.lua + procedure family | **Pass** | No defect found |
| 549 | Charmelia Deal (259758604) | E1/E2/E3 individually checked | c10004783/c10632284 | **Pass** | No defect found |
| 550 | Charmelia Beast (259226799) | E1/E2/E3/E4 individually checked | procedure.lua/constant.lua + closest family | **Pass** | No defect found |
| 551 | Magical Girl Explosion (259402105) | E1/E2/E3/E4 individually checked | c10443957/c101203048; c100201001/c100235002 | **Fixed** | Cross-fix: and-if-you-do negate/banish has no sequential break |
| 552 | Charmelia Fairy Kyubey (259489283) | E1/E2/E3/E4/E5 individually checked | c10004783/c10632284 | **Fixed** | Corrected in ultimate pass |
| 553 | Charmelia Fairy Morningstar (259753109) | E1/E2/E3/E4/E5 individually checked | procedure.lua/constant.lua + closest family | **Fixed** | Corrected in ultimate pass |
| 554 | Wyvernal Luna (259599798) | E1/E2 individually checked | procedure.lua/constant.lua + closest family | **Fixed** | Corrected in ultimate pass |
| 555 | Wyvernal Caudina (259783008) | E1/E2 individually checked | procedure.lua/constant.lua + closest family | **Fixed** | Corrected in ultimate pass |
| 556 | Wyvernal Myops (259431066) | E1/E2/E3/E4 individually checked | procedure.lua/constant.lua + closest family | **Fixed** | Corrected in ultimate pass |
| 557 | Wyvernal Crenata (259533644) | E1/E2/E3 individually checked | procedure.lua + procedure family | **Pass** | No defect found |
| 558 | Wyvernal Sphinx (259348317) | E1/E2 individually checked | procedure.lua + procedure family; c23153227/c43331750/c70369116/c97769122 | **Pass** | No defect found |
| 559 | Wyvernal Lymantria (259763531) | E1/E2/E3 individually checked | procedure.lua + procedure family | **Pass** | No defect found |
| 560 | Wyvernal Megalopyge (259179054) | E1/E2/E3 individually checked | c100201001/c100235002; procedure.lua | **Fixed** | Cross-fix: and-if-you-do destruction stays in one effect step |
| 561 | Wyvernal Sanctuary (259160760) | E1/E2/E3 individually checked | procedure.lua + procedure family; c23153227/c43331750/c70369116/c97769122 | **Pass** | No defect found |
| 562 | Wyvernal Gathering (259073666) | E1/E2 individually checked | procedure.lua/constant.lua + closest family | **Fixed** | Corrected in ultimate pass |
| 563 | Eclipse Observer Aaliyah (259652372) | E1/E2/E3 individually checked | c34124316/c120145032 | **Pass** | No defect found |
| 564 | Eclipse Observer Riley (259926839) | E1/E2 individually checked | procedure.lua/constant.lua + closest family | **Pass** | No defect found |
| 565 | Eclipse Observer Nora (259069729) | E1/E2 individually checked | procedure.lua/constant.lua + closest family | **Pass** | No defect found |
| 566 | Eclipse Observer Ella (259487387) | E1/E2/E3 individually checked | procedure.lua/constant.lua + closest family | **Pass** | No defect found |
| 567 | Eclipse Observer Maya (259058125) | E1/E2/E3/E4 individually checked | procedure.lua/constant.lua + closest family | **Pass** | No defect found |
| 568 | Eclipse Observatory (259721372) | E1/E2/E3 individually checked | c10443957/c101203048; c41510920/c67688478 | **Fixed** | Cross-fix: negate/banish is continuous, then draw is separated |
| 569 | Grimoire of Eclipse (259680842) | E1 individually checked | procedure.lua + procedure family; c23153227/c43331750/c70369116/c97769122 | **Pass** | No defect found |
| 570 | Encyclopedia of Eclipse (259614765) | E1/E2 individually checked | procedure.lua/constant.lua + closest family | **Pass** | No defect found |
| 571 | Manual of Eclipse (259273851) | E1/E2 individually checked | c22804644/c101301087 | **Fixed** | Corrected in ultimate pass |
| 572 | Spellbook of Eclipse (259264449) | E1/E2 individually checked | c10443957/c101203048 | **Pass** | No defect found |
| 573 | Tome of Eclipse (259303191) | E1/E2 individually checked | c22804644/c101301087 | **Fixed** | Corrected in ultimate pass |
| 574 | Eclipse Observer Baleygr (259193076) | E1/E2/E3/E4 individually checked | procedure.lua + procedure family; c23153227/c43331750/c70369116/c97769122 | **Fixed** | Corrected in ultimate pass |
| 575 | Eclipse Observer Chandra (259126370) | E1/E2/E3 individually checked | procedure.lua + procedure family | **Fixed** | Corrected in ultimate pass |
| 576 | Eclipse Observer Seara (259612312) | E1/E2/E3 individually checked | c41510920/c67688478; c100201001/c100235002 | **Fixed** | Cross-fix: draw occurs after successful negate-and-destroy |
| 577 | Ether Mademoiselle (259223502) | E1/E2/E3/E4 individually checked | procedure.lua + procedure family; c100201001/c100235002 | **Pass** | No defect found |


## Cross-review corrections applied

- c224235021.lua: permanent negate reset.
- c254894701.lua, c242838495.lua, c259086544.lua: exact 3000 ATK loss, reverse-update, and sequence handling.
- c256005703.lua, c212837324.lua: shared Damage Step guard for the printed OR trigger.
- c259609997.lua: reshuffle a revealed card that remains in hand.
- c259664027.lua: mandatory summon lock applies even if the summon cannot proceed.
- c259522807.lua: legal chain-operation rewrite without a current-board prerequisite.
- c212429024.lua: post-resolution additional action.
- c259402105.lua, c259179054.lua, c259721372.lua, c259612312.lua: corrected and-if-you-do versus then boundaries.

## Manual-ruling queue

1. Ghostrick Oni (239335848): custom Xyz material transfer/Quick conversion.
2. Vampire Reptilian (259552732): opponent-monster Xyz material/control semantics.
3. Scarstech Prologue (224467692): effect metadata conflicts with flavor-only text.
4. Gravinity Spherix (231088629): true summon replacement plus minimum GY Xyz material.
5. Gravinity Axis Matter (256831125): copied-effect scope and absent Link Rating reduction.
6. Gravinity Sonic Scream (238184015): copied activated-effect semantics.
7. Flower Cardian Moonflare (248940511): one card treated as three non-Tuners.
8. Stardust Comet (231523659): Deck Tribute/immediate Synchro/Level timing.
9. Galactican Battle Station (258934904): appending an effect to a resolving Damage Step effect.
10. Attack on Gravity (259307285): hand permission must cover only attack declaration, not its second activation mode.

## Official Omega references used

- c100212004.lua, c4290468.lua: negate lifetime.
- c13243124.lua, c100256005.lua: ATK/reverse-update guards.
- c50933533.lua, c86321248.lua: split battle events; shared guard follows audited Galacticarina because no exact official single-OR template exists.
- c64767757.lua: revealed-card reshuffle.
- c29047353.lua: unconditional rest-of-turn summon restriction.
- c53199020.lua, c77297908.lua: chain-operation rewrite.
- c16946849.lua, c12421694.lua: EVENT_CHAIN_SOLVED post-link processing.
- c29047353.lua, c12760674.lua: opponent monster-effect immunity; cleared Zero Mother false positive.
- c72930878.lua: attack-announcement Trap hand activation; exposes Attack on Gravity dual-mode ambiguity.
- c10443957.lua, c101203048.lua: monster negate.
- c41510920.lua, c67688478.lua: negate/destroy then a separate action.
- c10004783.lua, c10632284.lua: move-to-S/T and Continuous Trap conversion.
- procedure.lua, constant.lua, c100201001.lua, c100235002.lua, c23153227.lua, c43331750.lua, c70369116.lua, c97769122.lua: procedure/copy/restriction families.

## Verification

- Patched-file luac -p: **PASS (14/14)**.
- Full lane 391–577 luac -p: **PASS (187/187)**.
- Full public folder luac -p: **PASS (592/592)**.
- Strict initial_effect smoke: **PASS (592/592; 1562 effects, 3479 callbacks, 1710 registrations)**.
- Standalone-loader scan: **PASS (592/592; no require/dofile/loadfile)**.
- Ledger integrity: **PASS (187 unique rows, ordinals 391–577; 88 + 89 + 10 = 187)**.
- git diff --check on the 14 cross-fixed scripts: **PASS**.
- DB/install/ZIP/dist synchronization: deferred to root integration by lane assignment.

## Exact files changed by this cross-review

- public/CCG Downloads/CCG_Scripts/c224235021.lua
- public/CCG Downloads/CCG_Scripts/c254894701.lua
- public/CCG Downloads/CCG_Scripts/c242838495.lua
- public/CCG Downloads/CCG_Scripts/c259086544.lua
- public/CCG Downloads/CCG_Scripts/c256005703.lua
- public/CCG Downloads/CCG_Scripts/c212837324.lua
- public/CCG Downloads/CCG_Scripts/c259609997.lua
- public/CCG Downloads/CCG_Scripts/c259664027.lua
- public/CCG Downloads/CCG_Scripts/c259522807.lua
- public/CCG Downloads/CCG_Scripts/c212429024.lua
- public/CCG Downloads/CCG_Scripts/c259402105.lua
- public/CCG Downloads/CCG_Scripts/c259179054.lua
- public/CCG Downloads/CCG_Scripts/c259721372.lua
- public/CCG Downloads/CCG_Scripts/c259612312.lua
- tmp/ultimate_audit_cross_b_reviews_c.md

## Remaining in-engine risk

Damage Step coalescing, post-resolution timing, hand-activation scoping, summon replacement, and copied-effect ownership require scripted Omega duel scenarios.


### Reconciled Data from ultimate_audit_message_cross_c.md
# Ultimate aux.Stringid Cross-Audit — Central Integration

Date: 2026-07-20

## Result

PASS. The central message generator now explicitly covers every currently referenced `aux.Stringid` index across the 577-card source set.

| Check | Result |
|---|---:|
| Cards in `cards.json` | 577 |
| Cards with referenced `aux.Stringid` slots | 496 |
| Unique referenced slots | 1,186 |
| Referenced slots missing from overrides | 0 |
| Referenced blank strings | 0 |
| Generated placeholder strings | 0 |
| Referenced cards reaching the batch fallback | 0 |
| July batch cards converted to explicit overrides | 106 |
| July batch slots converted to explicit overrides | 259 |
| July batch index/count mismatches | 0 |

The `BATCH_CARD_STRING_COUNTS` compatibility fallback remains in the module, but it is inactive for every currently referenced card/index because every one of the 106 batch cards now has an explicit `CARD_STRING_OVERRIDES` entry. No production DB, installed Omega DB, ZIP, or `dist` artifact was synchronized in this lane.

## Sources and alignment method

- Read every `aux.Stringid(id, n)` call from the standalone scripts under `public/CCG Downloads/CCG_Scripts`.
- Classified each use as an effect description, `SelectYesNo`/`SelectEffectYesNo` prompt, `SelectOption` choice, delayed-effect description, or other UI hint.
- Compared the operation represented by each slot with its enclosing Lua effect and the exact card text in `src/data/cards.json`.
- Used `public/CCG Downloads/CCG_Database/CCG_v1_id_map.json` to restrict the verification to the 577-card source set.
- Confirmed the DB mapping rule (`aux.Stringid(id, 0)` -> `texts.str1`, etc.) by querying a disposable full-sync database.

## July batch conversion

All 259 previously fallback-generated slots were replaced with explicit, call-site-aligned messages. The audit covered every listed card from these groups:

- Bau/Bauy, Halloween/Pumpkien, Ghoti, Myutant, Hallo-Ween, Skewy, and Crewal.
- Ghostrick and Vampire.
- Scarstech and Gravinity.
- Unbinding/Eclipse, Flower Cardian, Stardust, Interwire, and Oracle.
- Galactica/Galataxian/Intergalactican and the Eldora crossover cards.
- `Pray for Your Life!`.

For every one of the 106 cards, referenced indices are contiguous from zero and exactly match the explicit override length. Option slots were worded as choices, Yes/No slots as the action being confirmed, and effect descriptions as the operation actually registered by the Lua effect.

## Confirmed legacy corrections

The legacy blank-message backlog and Grimoire slot were reviewed individually. In addition to filling the backlog, 25 referenced legacy slots needed wording/index correction or material clarity improvement:

| Card | Slot(s) | Corrected semantic use |
|---|---:|---|
| A World of Crying Chaos | 1 | Special Summon the targeted Zombie, not the searched monster |
| Windborne Cartographer | 1 | Add or Set a Windborne Spell after use as Synchro Material |
| Janna, Windborne Goddess of the Temple | 1, 3 | Send a Windborne card; optional second-card shuffle/Set prompt |
| Shining Brigade - Heartbeat Division | 1, 2 | Shining Brigade-only Summon lock; detach and banish opponent Effect Monster |
| Shining Brigade - Melody Division | 0, 1 | Additional Normal Summon/Set; attach a Brigade monster from Deck/GY |
| Shining Brigade - Revenge Division | 1 | Attach a Shining Brigade card from the Deck |
| Shining Brigade Armada | 1 | Special Summon multiple Brigade monsters from GY/banishment |
| Let's Go! Shining Brigade! | 1 | Search a Shining Brigade Spell/Trap |
| We're the Shining Brigade! | 0 | Optional Deck search for a Shining Brigade monster |
| Pixiebot | 1 | Banish a Link Monster from GY, then revive Normal Monsters |
| Aquila, Zephorion's Predictor | 1, 2 | Correct Set target family; correct destroyed-effect recovery description |
| Auriga of the Eldoran Empire | 2 | Correct destroyed-effect recovery description |
| Aquamarine Moon Aurelia | 2 | Fusion Summon by banishing field/GY materials |
| Aquamarine Plate Montipora | 1 | Fusion Summon using hand/field materials |
| Aqua Fusion | 1 | Fusion Summon by shuffling field/GY/banished materials into the Deck |
| Aquamarine Planktonites | 0 | Revive an Aquamarine monster from GY/banishment |
| Hiding "C" | 1 | Search an EARTH Insect with 1500 or less ATK |
| Ampere, the Yellow Ohmen | 1 | Search Ohmen monsters whose total Levels equal the counters |
| Carcel, the Dark Ohmen | 2 | Place counters on an Ohmechanic after use as Link Material |
| Farad, the Ohmechanic Capacitor | 2 | Banish up to 3 cards from the opponent's GY |
| Ampere, the Ohmechanic Intensity | 1 | Place a counter on every co-linked monster |

`Grimoire of Eclipse` index 1 was confirmed as:

> Use 1 Level 8 "Eclipse Observer" monster and 1 Spellcaster monster as Fusion Material?

This matches its `Duel.SelectYesNo` call and the optional additional-material branch.

## Verification

| Command/check | Result |
|---|---|
| `python -m py_compile scripts/sync_omega_ccg_db.py` | PASS |
| Static scan of all mapped Lua scripts and all literal `aux.Stringid(id,n)` references | PASS — 496 cards, 1,186 slots, 0 missing/blank/placeholder/fallback |
| Batch cardinality and contiguous-index scan | PASS — 106 cards, 259 slots, 0 mismatches |
| Disposable copy + `python scripts/sync_omega_ccg_db.py --db <temp.db> --map-out <temp.json> --full-sync --no-backup` | PASS — 577 source rows updated; 587 DB rows retained |
| SQL verification of every referenced `texts.strN` in the disposable synced DB | PASS — 1,186/1,186 populated; 0 placeholders |
| `git diff --check -- scripts/sync_omega_ccg_db.py` | PASS (line-ending warning only) |

The temporary DB and map were removed after verification.

## Files changed in this lane

- `scripts/sync_omega_ccg_db.py`
- `tmp/ultimate_audit_message_cross_c.md`

## Residual risk

Message presence and slot semantics are verified statically and in a fully synced disposable DB. In-engine testing is still useful for UI truncation, when Omega chooses to display descriptions versus confirmation prompts, and localization/rendering of punctuation. No unresolved blank, placeholder, or index-alignment defect remains.


### Reconciled Data from ultimate_cross_b_173_280.md
# Ultimate audit cross-pass B: card ordinals 173-280

Scope: 108 consecutive `src/data/cards.json` records, audited clause-by-clause against the standalone public Lua script and comparable official Omega scripts in `tmp/omega_scripts`. `Clauses/effects` is the number of independently actionable/restrictive text clauses versus registered effects found by the audit; the values need not be equal because one clause may require multiple engine effects, while some material/rule text is implemented by the summon procedure rather than `RegisterEffect`.

Verdicts:

- `PASS`: no confirmed implementation defect in this cross-pass.
- `FIXED`: a confirmed defect was corrected in this cross-pass and the corrected script passed static verification.
- `MANUAL`: the script has either a corrected implementation that still requires an engine/ruling test, or unresolved text whose exact engine semantics cannot be proved statically. `MANUAL` takes priority over `FIXED` in the table.

Official-reference keys used below:

- `CORE`: `c11248645.lua`, `c102380.lua` (effect construction, costs, targets, resolution checks).
- `NV`: `c11335209.lua`, `c100259006.lua` (GY/banishment access and `aux.NecroValleyFilter`).
- `NEG`: `c100201001.lua`, `c101208206.lua`, `c14799437.lua`, `c23440231.lua`; attack/summon-negate specifics also `c24545464.lua`, `c67865534.lua`, `c82489470.lua`.
- `COPY`: `c70369116.lua`, `c23153227.lua`, `c43331750.lua`, `c97769122.lua`.
- `FUS`: `c101304094.lua`; contact-Fusion field-material location specifically `c53315891.lua`.
- `XYZ`: `c10443957.lua`, `c101203048.lua`.
- `SYN`: `c1980574.lua`, `c16769305.lua`.
- `LINK`: `c101304087.lua`, `c16684346.lua`, `c100256017.lua`, and official `procedure.lua` Link helpers.
- `TOP`: `c100213003.lua`, `c10321588.lua`.
- `SET`: `c50237654.lua`, `c58019984.lua`, `c79387392.lua`, `c97462632.lua`.
- `DELAY`: `c17132130.lua`, `c42081767.lua`, `c48658295.lua`.
- `FIELD`: `c1050355.lua`, `c11881272.lua`.
- `ANN`: `c50078320.lua` (dynamic `Duel.AnnounceCard` exclusions).
- `CHAIN`: `c100259009.lua`, `c101203003.lua`, `c10131855.lua` (chain target/operation rewriting).
- `TURN`: `c101203059.lua` (`RESET_SELF_TURN` timing).
- `FIRST`: `c87769556.lua` (first-Spell activation tracking/negation).

| Ord. | Passcode | Card | Verdict | Clauses/effects | Official patterns | Cross-pass result / remaining concern |
|---:|---:|---|---|---:|---|---|
| 173 | 237917359 | Phantasm Spiral Shrine | PASS | 3/3 | CORE, NV, FIELD | Placement, conditional protection, recycle, and draw-success gate map cleanly. |
| 174 | 222875833 | Phantasm Spiral Ensnarement | PASS | 4/3 | CORE, NEG | Hand-activation condition matches the exact Phantasm Spiral official pattern (`c34302287.lua`); negate/destruction sequence is sound. |
| 175 | 226063408 | Grand Puppet of Wicked Puppeteer | PASS | 3/4 | CORE, XYZ | Material/summon restrictions and registered effects map to all clauses. |
| 176 | 259527622 | Knight Puppet of Wicked Puppeteer | PASS | 3/4 | CORE, XYZ | Target legality, relation checks, and HOPT use are sound. |
| 177 | 233659599 | Minion Puppets of Wicked Puppeteer | PASS | 3/2 | CORE, NV | Cost and GY operation are separated and rechecked. |
| 178 | 257464336 | Guardian of Wicked Puppeteer | PASS | 3/2 | CORE, XYZ | Summon/material and protection clauses map cleanly. |
| 179 | 234178973 | The True Wicked Puppeteer, Orchis | PASS | 4/4 | CORE, XYZ, NEG | Xyz procedure, negation, and follow-up success gates follow official structure. |
| 180 | 236818346 | Wicked Puppeteer, Orchis | PASS | 4/3 | CORE, XYZ | Material, search, and restriction handling are complete. |
| 181 | 243306841 | Wicked Puppeteer Tragedy | PASS | 3/2 | CORE, NV | GY access and resolution checks are correct. |
| 182 | 219150610 | Wicked Puppeteery | PASS | 4/3 | CORE, XYZ | Target selection and Xyz-material handling follow official patterns. |
| 183 | 244959812 | Divine Phoenix of Nephthys | PASS | 3/3 | CORE, NV | Destruction-trigger and recursive GY handling are guarded correctly. |
| 184 | 234818744 | Primite Dragon Citrine | PASS | 3/0 | CORE | Normal-monster/rule text is represented without unnecessary registered effects. |
| 185 | 241868535 | Pedicaes Papa | PASS | 3/4 | CORE, NV | Trigger timing, selections, and GY access map cleanly. |
| 186 | 215984744 | Vir Pedicae Mortis - Entity's Happy Servant | MANUAL | 3/3 | CORE, NV | The script's code-based approximation of the printed “Mine” Field Spell/“Recollection” identity needs an authoritative card-pool/ruling confirmation. |
| 187 | 244778917 | Vir Pedicae Mortis - Fearless Hunter | MANUAL | 3/2 | LINK | Printed “treated as 2 materials” for a named Link Summon is not implemented; official generic Link helpers expose no source-monster effect that safely changes material weight. Requires destination-procedure/ruling work. |
| 188 | 243144691 | Vir Pedicae Mortis - the Unhallowed Warden | PASS | 3/3 | CORE, NV | Summon, recovery, and restriction clauses are represented. |
| 189 | 233103500 | Vir Pedicae Mortis - True Nightmare | PASS | 4/2 | CORE, FIRST | First-activation tracking and once-per-turn behavior follow official event tracking. |
| 190 | 236744343 | Entity's Realm - Pedicae Estate | PASS | 5/5 | CORE, NV, FIELD | Field activation, protection, and GY effects map to all clauses. |
| 191 | 211086520 | Recollection: Static, Lead, and Nerve | PASS | 2/1 | CORE | Activation and compound resolution are correctly success-gated. |
| 192 | 234984156 | Recollection: a Lesson in Iron | PASS | 2/4 | CORE | Continuous restrictions/protections require multiple effects and are correctly scoped. |
| 193 | 231872299 | Recollection: the Mine | PASS | 3/3 | CORE, FIELD | Field Spell activation and ongoing effects map cleanly. |
| 194 | 241447408 | Recollection: Kaboom Papa | MANUAL | 3/1 | CORE | “Only conduct 1 Summon this turn” needs a ruling on activation after prior summons and whether summon events or monsters are counted. |
| 195 | 229875953 | Teleum Mortis | PASS | 3/4 | CORE, DELAY | Bear Trap activation flags and both-player counting are now available from actual activation events; the Teleum logic itself is sound. |
| 196 | 251699681 | Bear Trap | FIXED | 3/6 | NEG | Summon destruction now requires successful `NegateSummon`; attack negation no longer incorrectly requires a destructible attacker; activation flags now register on `EVENT_CHAINING`, so negated resolutions still count as activations. |
| 197 | 219543855 | Securitake Agent | MANUAL | 3/4 | CORE, LINK | Script is internally consistent, but the intended scope of opponent-owned Link material (opponent monster you control versus opponent's field) needs a ruling. |
| 198 | 226645052 | Harmony Pearlwood & the Nautical Deepwaters | PASS | 3/5 | CORE, NV | Forced summon and follow-up effects map to the text. |
| 199 | 228040066 | Melody Merheart & the Nautical Coral Reef | PASS | 3/4 | CORE, NV | Costs, targets, and follow-up gates are separated correctly. |
| 200 | 214349717 | Emma Oceannus & the Nautical Coastlines | PASS | 2/4 | CORE, NV | Compound trigger and restrictions are implemented with correct scopes. |
| 201 | 259114562 | Bobbie Bluefin & the Nautical Nocturnes | MANUAL | 3/8 | CORE | When both Normal and Special Summon are legal the script chooses Special Summon without an explicit player choice; confirm intended forced-summon choice semantics. |
| 202 | 220749574 | Scarlet Seareef & the Nautical Creatures | MANUAL | 5/7 | CORE, TOP | Forced summon branch choice and bottom-of-Deck ordering need in-engine/ruling confirmation. |
| 203 | 225109525 | Evander Coldwater & the Nautical Abyss | MANUAL | 3/3 | CORE, NV | Returned monster can become eligible for the subsequent forced summon; confirm that this matches intended sequencing. |
| 204 | 223158720 | Nautical Backwashing & Oceanic Waves | MANUAL | 3/3 | CORE | Forced Normal/Special Summon selection defaults to Special when both are legal; printed choice semantics need confirmation. |
| 205 | 238711686 | Melissa Oceanheart & the Nautical Seabed | PASS | 3/3 | CORE, NV | Trigger, summon, and recovery operations map cleanly. |
| 206 | 248946297 | Exploring the Nautical Waters | MANUAL | 3/4 | CORE, TOP | Forced summon branch and bottom-deck order need an engine/ruling test. |
| 207 | 218905439 | Nautical Adventures & Torrential Seas | MANUAL | 3/4 | CORE, NV | A returned monster may be eligible for the subsequent forced summon; confirm intended pool and branch choice. |
| 208 | 259722826 | Bob | PASS | 2/0 | CORE | Rule/material text requires no registered effect and is represented by the card data/procedure context. |
| 209 | 259944943 | Bob, but Stronger! | MANUAL | 6/4 | FUS | Fixed contact-Fusion material search from `LOCATION_MZONE` to official `LOCATION_ONFIELD`; live test still required to confirm Omega permits the “Umi” Spell to pass Fusion-material legality. |
| 210 | 221047295 | Bookkeeper of Crying Chaos | PASS | 3/2 | CORE, NV | Search/recovery filters and HOPT handling are correct. |
| 211 | 233436485 | Crow of Crying Chaos | PASS | 2/0 | CORE | No independently registered effect is required by the current rule/material text. |
| 212 | 217118040 | Plague Doctor of Crying Chaos | PASS | 3/3 | CORE, NV | Costs, targeting, and relation checks are correctly separated. |
| 213 | 218261525 | Scarecrow of Crying Chaos | PASS | 3/2 | CORE | Trigger and compound resolution correctly check success. |
| 214 | 236017388 | Slug of Crying Chaos | PASS | 3/4 | CORE, NV | Graveyard and field operations use correct legality checks. |
| 215 | 240976976 | Witch of Crying Chaos | PASS | 3/3 | CORE, NV | Search/Set branches and restrictions map cleanly. |
| 216 | 240511702 | Hunter of Crying Chaos | FIXED | 3/2 | CORE, SET | Split the invalid combined add/Set filter: monsters can be added to hand, while Crying Chaos Spells/Traps can only be Set, with branch and SZONE legality checked before selection. |
| 217 | 252513554 | Guardian of Crying Chaos | PASS | 3/3 | CORE, NEG | Protection/negation and target scopes are sound. |
| 218 | 224943273 | Goat of Crying Chaos | PASS | 4/2 | CORE | Summon and follow-up success gates correctly match the text. |
| 219 | 227610954 | Zenatil, Criminal Bookkeeper of Crying Chaos | PASS | 4/3 | CORE, NV | Search, GY access, and restriction effects are complete. |
| 220 | 239725695 | Zebra of Crying Chaos | PASS | 4/2 | CORE | Target and operation filters remain valid at resolution. |
| 221 | 249018041 | Ram of Crying Chaos | PASS | 4/3 | CORE, NV | Cost, recovery, and summon clauses map cleanly. |
| 222 | 220305422 | Natir, the Swords Master of Crying Chaos | PASS | 4/2 | CORE, NEG | Battle/negation sequencing follows official patterns. |
| 223 | 234296128 | Revelation of Crying Chaos | PASS | 4/2 | CORE, TOP | Top-of-Deck access and disposition follow official excavation patterns. |
| 224 | 241880822 | Chrono-Saur Raptor | PASS | 4/4 | CORE | Summon and temporal restrictions are represented and scoped correctly. |
| 225 | 233499093 | Dragon of Crying Chaos | PASS | 4/2 | CORE, NEG | Negation and resolution follow-up are correctly gated. |
| 226 | 247779405 | Windborne Swiftsurfer | PASS | 4/4 | CORE, SYN | Synchro procedure and triggered effects follow official structure. |
| 227 | 258241424 | Light Within the Crying Chaos | PASS | 3/2 | CORE, NV | Targeting and GY handling are correct. |
| 228 | 217029078 | Windborne Cloudwing | PASS | 4/4 | CORE, SYN | Synchro and trigger clauses are complete. |
| 229 | 216294702 | A Throne of Crying Chaos | PASS | 2/2 | CORE, FIELD | Placement/activation and continuous handling are sound. |
| 230 | 255953418 | A World of Crying Chaos | PASS | 3/3 | CORE, FIELD | Field activation, search, and ongoing restrictions map cleanly. |
| 231 | 221759221 | Windborne Cartographer | FIXED | 5/5 | CORE, SYN | Excluded the handler from optional hand cards to shuffle, preventing the cost/operation from shuffling itself instead of completing its Special Summon. |
| 232 | 253472430 | A Whisper of Crying Chaos | PASS | 3/6 | CORE, NV | Continuous and GY effects require multiple registrations and are correctly scoped. |
| 233 | 215068354 | Janna, Windborne Goddess of the Temple | FIXED | 4/4 | CORE, SYN | Excluded the handler from the optional hand-shuffle group so its own Special Summon cannot be invalidated by self-selection. |
| 234 | 257794541 | Maryam, Windborne Caretaker of the Temple | FIXED | 4/4 | CORE, SYN | Excluded the handler from optional hand cards to shuffle, preserving the required Special Summon. |
| 235 | 251571153 | Sunken Temple of the Windborne | PASS | 4/3 | CORE, FIELD | Activation and field-continuous clauses are correctly scoped. |
| 236 | 231273040 | Windborne Howling Gale | PASS | 2/1 | CORE, NEG | Negate/follow-up sequence uses correct target and resolution checks. |
| 237 | 256110263 | Windborne Eye of the Storm | MANUAL | 1/1 | SYN | The script uses a temporary synthetic Token material to emulate “treated as a Synchro Summon using only Windborne”; this bespoke engine workaround needs live validation. |
| 238 | 238064522 | Windborne Galesong Flock | PASS | 1/1 | SYN | Synchro procedure/restriction maps to the printed clause. |
| 239 | 233212369 | Windborne Divine Whirlwind | FIXED | 1/1 | DELAY, SET | Implemented the actual resolution choice: either Set the selected cards immediately or schedule all selected cards for next Standby-Phase recovery; delayed group has a turn guard and correct reset lifetime. |
| 240 | 215006791 | Muntith, Windborne Skydragon of the Shining Sun | PASS | 5/4 | CORE, SYN, NEG | Synchro, negation, and follow-up clauses map cleanly. |
| 241 | 237684285 | Janna, Windborne Goddess of Clement Winds | PASS | 5/3 | CORE, SYN | Procedure and compound triggered effects are correctly gated. |
| 242 | 224774049 | Pot of Gambling | MANUAL | 2/1 | TOP | Printed text does not unambiguously state the default disposition/order for excavated cards; implementation choice requires a ruling. |
| 243 | 255686110 | Iscylla, Windborne Kraken of Sunken Depths | PASS | 6/8 | CORE, SYN, NEG | Multiple protection/trigger registrations cover all clauses with correct scopes. |
| 244 | 215885404 | Pot of Fortune | PASS | 2/1 | TOP | Excavation and selection/disposition follow official top-of-Deck patterns. |
| 245 | 243194249 | Shining Brigade - Hope Division | PASS | 5/4 | CORE, XYZ | Xyz procedure, material operations, and restrictions map cleanly. |
| 246 | 232038002 | Shining Brigade - Forward Division | PASS | 5/3 | CORE, XYZ | Xyz material and compound effect handling follow official patterns. |
| 247 | 232100722 | Shining Brigade - Flowering Division | PASS | 4/2 | CORE, XYZ | Costs, targets, and material checks are sound. |
| 248 | 230812008 | Shining Brigade - Loving Division | FIXED | 4/3 | CORE, XYZ, SET | Added Spell/Trap Zone availability checks at targeting and resolution for the granted material-Set effect. |
| 249 | 220124524 | Shining Brigade - Heartbeat Division | PASS | 5/5 | CORE, XYZ | Procedure, material effects, and restrictions cover the text. |
| 250 | 255668557 | Shining Brigade - Joyous Division | PASS | 4/4 | CORE, XYZ | Material removal and follow-up operations use valid targets and success gates. |
| 251 | 243420199 | Shining Brigade - Melody Division | PASS | 3/2 | CORE, XYZ | Xyz and material-related clauses map cleanly. |
| 252 | 236616849 | Shining Brigade - Revenge Division | PASS | 5/5 | CORE, XYZ, NEG | Negation, material, and destruction sequencing follow official patterns. |
| 253 | 223750159 | Shining Brigade Armada | PASS | 4/4 | CORE, XYZ | Xyz procedure and granted/triggered effects are complete. |
| 254 | 244986323 | Shining Brigade Origins | FIXED | 8/6 | CORE, XYZ | Added the shared HOPT to the destroy/tribute placement effect; overlay selection now requires face-up cards that pass `IsCanOverlay`. |
| 255 | 232824319 | Shining Brigade - Companion Team | PASS | 4/3 | CORE, XYZ | Material and recovery effects map cleanly. |
| 256 | 241504188 | Shining Brigade - Absolute Supremacy | PASS | 4/2 | CORE, NEG | Activation/negation and follow-up clauses are correctly success-gated. |
| 257 | 238841732 | Let's Go, Shining Brigade! | PASS | 4/2 | CORE, XYZ | Summon/material operations check zones and legality at resolution. |
| 258 | 226827770 | The One Called Forth | FIXED | 1/1 | ANN, NEG | `Duel.AnnounceCard` now dynamically excludes names already controlled; cannot-inactivate protection now applies only to summon-category effects instead of unrelated effects that merely mention the name. |
| 259 | 215142357 | Shining Brigade - Stand Together! | FIXED | 4/5 | CORE, XYZ | Protection now includes this card itself; detaching an Xyz material is a true cost, with the chosen Xyz stored and rechecked before attachment from hand/GY. |
| 260 | 238976759 | We're the Shining Brigade! | PASS | 3/2 | CORE, XYZ | Activation and material-placement clauses map cleanly. |
| 261 | 237692523 | Pixie Bot | FIXED | 3/2 | CORE, LINK | Activation now requires a genuinely free Main Monster Zone pointed to by a Link Monster, and the same linked-zone legality is rechecked at resolution. |
| 262 | 249629457 | Shining Brigade - Last Stand | PASS | 3/3 | CORE, XYZ | Costs, target scope, and material follow-up are sound. |
| 263 | 234507067 | Chrono-Saur Brachio | PASS | 4/3 | CORE | Summon and phase-related clauses are represented. |
| 264 | 235637994 | Chrono-Saur Dactylus | FIXED | 4/5 | CORE | Removed an erroneous opponent-turn-only condition; the printed Battle Phase effect is now available in either player's Battle Phase. |
| 265 | 259235389 | Chrono-Saur Tricera | PASS | 5/4 | CORE | Phase timing, restrictions, and operations map cleanly. |
| 266 | 255048812 | Chrono-Saur Stegian | FIXED | 4/3 | CORE | Initial destruction now checks destructibility and includes own Chrono-Saur Spell/Trap cards; optional post-summon destruction only offers destructible hand/field cards. |
| 267 | 236898203 | Chrono-Saur Rex | MANUAL | 4/2 | CORE, DELAY | Fixed prerequisite destruction to own face-up on-field Chrono/Dinosaur cards and scheduled self-destruction for the actual summoning phase (Main Phase 1 or Battle Phase); `EVENT_PHASE+PHASE_MAIN1` lacks an exact official analogue and needs live timing validation. |
| 268 | 251236672 | Chrono-Saur Laplace Plesio | MANUAL | 5/5 | CORE, TURN | Fixed ATK/DEF reset to the next own Battle Phase and limited post-battle selection to destructible own cards; shared “previous effects once per turn” wording remains ruling-sensitive. |
| 269 | 259226793 | Chrono-Saur Force | FIXED | 4/3 | CORE | Optional destroy choice now offers only destructible original-handler/own hand-field cards. |
| 270 | 213530841 | Chrono-Saur Counter | FIXED | 4/3 | CORE, NEG | Optional destroy choice now filters the original handler and own hand/field cards for actual destructibility. |
| 271 | 253928485 | Aqua Whirlpool | PASS | 3/1 | CORE | Activation and compound operation are correctly gated. |
| 272 | 259366507 | Aquila, Zephorion's Predictor | PASS | 5/5 | CORE, NV | Summon, search, and GY effects map cleanly. |
| 273 | 257081514 | Auriga of the Eldoran Empire | PASS | 5/5 | CORE, NV | All summon/trigger/recovery clauses have correct timing and scope. |
| 274 | 213990492 | Eridani, Squire of Zephorion Prime | PASS | 4/3 | CORE, NV | Target and GY access checks are correct. |
| 275 | 244972185 | The Spires of Zephorion Prime | FIXED | 4/3 | CORE, FIELD | Destruction replacement now requires that the destroyed monster's reason player is the opponent, as printed. Field-Spell activation from Deck matches official patterns. |
| 276 | 241957394 | Chapter Ii Verse Iv | MANUAL | 2/1 | CHAIN | Corrected rewritten chain target to the Effect Monster actually chosen and rewrote sequencing to destroy other matching monsters first, then the chosen monster only on success; retroactive Token-tribute/cost semantics still require an Omega duel test. |
| 277 | 212737555 | Aqua Droplet | PASS | 5/2 | CORE | Summon and compound resolution clauses map cleanly. |
| 278 | 238035167 | Aquamarine Moon Aurelia | PASS | 5/3 | CORE, XYZ | Xyz procedure, material effects, and restrictions are sound. |
| 279 | 220150285 | Aquamarine Plate Montipora | PASS | 3/3 | CORE, XYZ | Targeting/material handling maps to all clauses. |
| 280 | 211682274 | Aquamarine Pisaster Giga | PASS | 5/3 | CORE, XYZ | Xyz procedure and compound material effects follow official structure. |

## Files changed in this cross-pass

- `public/CCG Downloads/CCG_Scripts/c251699681.lua`
- `public/CCG Downloads/CCG_Scripts/c259944943.lua`
- `public/CCG Downloads/CCG_Scripts/c240511702.lua`
- `public/CCG Downloads/CCG_Scripts/c221759221.lua`
- `public/CCG Downloads/CCG_Scripts/c215068354.lua`
- `public/CCG Downloads/CCG_Scripts/c257794541.lua`
- `public/CCG Downloads/CCG_Scripts/c233212369.lua`
- `public/CCG Downloads/CCG_Scripts/c230812008.lua`
- `public/CCG Downloads/CCG_Scripts/c244986323.lua`
- `public/CCG Downloads/CCG_Scripts/c226827770.lua`
- `public/CCG Downloads/CCG_Scripts/c215142357.lua`
- `public/CCG Downloads/CCG_Scripts/c237692523.lua`
- `public/CCG Downloads/CCG_Scripts/c235637994.lua`
- `public/CCG Downloads/CCG_Scripts/c255048812.lua`
- `public/CCG Downloads/CCG_Scripts/c236898203.lua`
- `public/CCG Downloads/CCG_Scripts/c251236672.lua`
- `public/CCG Downloads/CCG_Scripts/c259226793.lua`
- `public/CCG Downloads/CCG_Scripts/c213530841.lua`
- `public/CCG Downloads/CCG_Scripts/c244972185.lua`
- `public/CCG Downloads/CCG_Scripts/c241957394.lua`
- `tmp/ultimate_cross_b_173_280.md` (this audit ledger)

No DB, installed-Omega, ZIP, or distribution artifact was synchronized by this lane; the parent audit owns final consolidation and artifact synchronization.


### Reconciled Data from ultimate_cross_b_281_390.md
# Independent Lane B cross-review — ordinals 281–390

Scope: the current standalone scripts for cards.json ordinals **281–390** were checked clause-by-clause against exact card text and official Omega patterns. Existing primary/earlier-review patches were preserved. No DB, ZIP, installed Omega, dist, or source-data artifacts were synchronized.

## Confirmed fixes in this resumed half

c251191343.lua, c216258796.lua, c259780273.lua, c259869259.lua, c259405917.lua, c259519336.lua, c259841490.lua, c259033429.lua, c259434499.lua, c259650969.lua, c252552954.lua, c259225324.lua, c257239133.lua, c230303021.lua, c238241974.lua, c259366591.lua, c241440521.lua, c245354354.lua, c228860650.lua, c258328859.lua, c258590942.lua, c235612490.lua, c239235967.lua, c219995840.lua, c237089049.lua, c251710981.lua, c221511784.lua, c258576611.lua, c217632789.lua, c254375894.lua, c237269434.lua, c250792632.lua

## Official references used

- Summon-procedure oath/count handling: c100212002.lua, c100240201.lua.
- Retroactive Special Summon activity locks: c101203005.lua, c101301096.lua.
- Counter payment in cost callbacks: c101304084.lua, c101306071.lua.
- Fusion repeated-material procedures: c100212001.lua, c31111109.lua, procedure.lua.
- Non-Tuner value validation: c4891376.lua, c40380686.lua.
- Graveyard/Necrovalley movement: c11248645.lua, c11335209.lua, c100259006.lua.
- Negation, copied effects, Xyz/Fusion/Synchro/Link, delayed and set-turn families: c100201001.lua, c101208206.lua, c70369116.lua, c23153227.lua, c10443957.lua, c1980574.lua, c101304087.lua, c17132130.lua, c50237654.lua.

## Per-card ledger

| Ordinal | Omega ID | Card | Coverage | Verdict | Official family / findings |
|---:|---:|---|---|---|---|
| 281 | 251191343 | Aquamarine Asthenosoma | All printed clauses; 3 explicit registration sites | FIXED | Added the printed once-per-turn oath to the GY summon procedure. |
| 282 | 221509060 | Aquamarine Calling | All printed clauses; 1 explicit registration sites | PASS | Current clauses match the cited CORE pattern family. |
| 283 | 259998396 | Treasure of the Cosmic Ocean | All printed clauses; 1 explicit registration sites | PASS | Current clauses match the cited CORE pattern family. |
| 284 | 227035644 | Aqua Fusion | All printed clauses; 2 explicit registration sites | PASS | Current clauses match the cited NV, FUS pattern family. |
| 285 | 255082735 | Aquamarine Bubble Surge | All printed clauses; 2 explicit registration sites | PASS | Current clauses match the cited FUS pattern family. |
| 286 | 250339529 | Aquamarine Planktonites | All printed clauses; 2 explicit registration sites | PASS | Current clauses match the cited NV, FUS pattern family. |
| 287 | 241976572 | Aquamarine Nautilus | All printed clauses; 4 explicit registration sites | PASS | Current clauses match the cited NV pattern family. |
| 288 | 216258796 | Aquamarine Actinia | All printed clauses; 2 explicit registration sites | FIXED | Added the printed once-per-turn oath to the GY summon procedure. |
| 289 | 249746105 | Aquamarine Physalia | All printed clauses; 1 explicit registration sites | PASS | Current clauses match the cited NV, FUS pattern family. |
| 290 | 225161820 | Aquamarine Glaucus | All printed clauses; 4 explicit registration sites | PASS | Current clauses match the cited NV, FUS pattern family. |
| 291 | 259920959 | Aquamarine Reef Hapalochlaena | All printed clauses; 3 explicit registration sites | PASS | Current clauses match the cited NV, FUS pattern family. |
| 292 | 258260221 | Hiding "c" | All printed clauses; 3 explicit registration sites | PASS | Current clauses match the cited NV pattern family. |
| 293 | 259174227 | Farad, the Purple Ohmen | All printed clauses; 2 explicit registration sites | FIXED | Primary pass fixes rechecked against the current script and official family. |
| 294 | 259726853 | Volt, the Green Ohmen | All printed clauses; 2 explicit registration sites | FIXED | Primary pass fixes rechecked against the current script and official family. |
| 295 | 259650132 | Ampere, the Yellow Ohmen | All printed clauses; 3 explicit registration sites | FIXED | Primary pass fixes rechecked against the current script and official family. |
| 296 | 259107906 | Siemens, the Blue Ohmen | All printed clauses; 2 explicit registration sites | FIXED | Primary pass fixes rechecked against the current script and official family. |
| 297 | 259881255 | Coulomb, the White Ohmen | All printed clauses; 3 explicit registration sites | FIXED | Primary pass fixes rechecked against the current script and official family. |
| 298 | 259780273 | Carcel, the Dark Ohmen | All printed clauses; 2 explicit registration sites | MANUAL | Added the official retroactive Ohmen-only Special Summon activity lock. Custom reveal/two-card summon and traversal behavior still needs duel-engine validation. |
| 299 | 259869259 | Ohmen Surge | All printed clauses; 3 explicit registration sites | MANUAL | Moved the once-per-turn limit to card activation; the continuous control effect is no longer falsely limited. EVENT_ADJUST co-link tracking and forced zone-control movement are custom mechanics. |
| 300 | 259405917 | Siemens, the Ohmechanic Conductor | All printed clauses; 4 explicit registration sites | MANUAL | Prevented the move effect from activating without a free Main Monster Zone. Custom co-link destination movement remains an in-engine UI/ruling risk. |
| 301 | 259350270 | Farad, the Ohmechanic Capacitor | All printed clauses; 4 explicit registration sites | MANUAL | Custom Current Counter traversal/removal across mutually linked cards needs engine validation. |
| 302 | 259519336 | Volt, the Ohmechanic Chocker | All printed clauses; 4 explicit registration sites | MANUAL | Moved all-counter payment to cost and made the destruction correctly non-targeting. Custom counter-threshold continuous/Quick interaction needs live validation after the confirmed fixes. |
| 303 | 259841490 | Coulomb, the Ohmechanic Charger | All printed clauses; 4 explicit registration sites | MANUAL | Prevented the Link-monster move effect from activating without a free Main Monster Zone. Immediate Link Summon and custom zone movement need live Extra Monster Zone validation. |
| 304 | 259479044 | Ampere, the Ohmechanic Intensity | All printed clauses; 5 explicit registration sites | MANUAL | Custom counter placement/protection over co-linked monsters needs live validation. |
| 305 | 259033429 | Carcel, the Ohmechanic Light | All printed clauses; 4 explicit registration sites | MANUAL | Moved mass Current Counter removal out of target and into cost. EVENT_ADJUST co-link transition tracking and mass counter consumption need live validation. |
| 306 | 259434499 | Ohmen Powerload | All printed clauses; 3 explicit registration sites | MANUAL | Added the official retroactive Thunder-only Special Summon activity lock. Custom optional counter removal/destruction branch needs UI validation. |
| 307 | 259650969 | Ohmen Beacon | All printed clauses; 3 explicit registration sites | MANUAL | Prevented the move effect from activating without a free Main Monster Zone. Continuous co-link protection and movement/counter placement need live validation. |
| 308 | 245452058 | Altergeist Pipesiren | All printed clauses; 4 explicit registration sites | PASS | Current clauses match the cited NV pattern family. |
| 309 | 211873618 | Altergeist Regissae | All printed clauses; 6 explicit registration sites | PASS | Current clauses match the cited NEG, NV, LINK pattern family. |
| 310 | 252552954 | Altergeist Ifritware | All printed clauses; 2 explicit registration sites | FIXED | Made the post-negate Altergeist Trap recovery mandatory and required it at activation. |
| 311 | 259152704 | Dragon Protector of Nature | All printed clauses; 3 explicit registration sites | PASS | Current clauses match the cited NV, SYN pattern family. |
| 312 | 212055290 | Advent of Cosmic Beings | All printed clauses; 1 explicit registration sites | PASS | Current clauses match the cited CORE pattern family. |
| 313 | 259225324 | Transcend the Pendulum | All printed clauses; 2 explicit registration sites | FIXED | Made both Pendulum placements mandatory when possible and enforced different-name pair legality. |
| 314 | 250902476 | Striking Mirror Force | All printed clauses; 2 explicit registration sites | PASS | Current clauses match the cited CORE pattern family. |
| 315 | 228464260 | Rising Elemental | All printed clauses; 3 explicit registration sites | PASS | Current clauses match the cited NV, SYN pattern family. |
| 316 | 253152295 | Yummy Kuriboh | All printed clauses; 2 explicit registration sites | PASS | Current clauses match the cited NEG, NV pattern family. |
| 317 | 256207361 | Sealed Glyphs Dragon | All printed clauses; 3 explicit registration sites | PASS | Current clauses match the cited XYZ pattern family. |
| 318 | 236721134 | Devotee of Fire | All printed clauses; 6 explicit registration sites | MANUAL | Source text gives the Set effect no activation condition; current on-summon interpretation needs a ruling. |
| 319 | 224811863 | Shaman of Fire | All printed clauses; 3 explicit registration sites | FIXED | Primary pass fixes rechecked against the current script and official family. |
| 320 | 240104048 | Guardian of Fire | All printed clauses; 3 explicit registration sites | FIXED | Primary pass fixes rechecked against the current script and official family. |
| 321 | 257239133 | Phlogistic Uprising! | All printed clauses; 3 explicit registration sites | MANUAL | Excluded illegal LP payments that would reduce LP below the engine minimum. Fusion Summon from GY/Extra with mixed send/shuffle materials is custom and needs live validation. |
| 322 | 219714894 | Phlogistic Ignition | All printed clauses; 4 explicit registration sites | PASS | Current clauses match the cited NV pattern family. |
| 323 | 236815197 | Phlogiston's Wake | All printed clauses; 3 explicit registration sites | FIXED | Primary pass fixes rechecked against the current script and official family. |
| 324 | 242094473 | Phlogiston Dragon | All printed clauses; 6 explicit registration sites | PASS | Current clauses match the cited NV pattern family. |
| 325 | 230303021 | Phlogistic Scorching Dragon Horde | All printed clauses; 4 explicit registration sites | FIXED | Corrected Fusion materials to 1 Level 8 Phlogiston Dragon + exactly 2 other FIRE monsters; destruction now chooses the exact available count. |
| 326 | 220538776 | Curryboh | All printed clauses; 2 explicit registration sites | PASS | Current clauses match the cited NV pattern family. |
| 327 | 249805098 | Starry Knight Arc-En-Ciel | All printed clauses; 2 explicit registration sites | PASS | Current clauses match the cited NEG, NV pattern family. |
| 328 | 238241974 | Starry Knight Nebriel | All printed clauses; 3 explicit registration sites | FIXED | Added resolution-time Necrovalley recheck to the self-revival. |
| 329 | 248760718 | Starry Knight Starry Queen | All printed clauses; 4 explicit registration sites | PASS | Current clauses match the cited NV, SETTURN pattern family. |
| 330 | 221924008 | Chamroshes' Aegis | All printed clauses; 5 explicit registration sites | MANUAL | Contact-style Extra Deck summon by shuffling three differently named Tuners needs procedure validation. |
| 331 | 212413422 | Gaia, the Iron Clad Knight | All printed clauses; 5 explicit registration sites | PASS | Current clauses match the cited NV, FUS, DELAY pattern family. |
| 332 | 238256111 | Cursed Dragon of the Knight | All printed clauses; 3 explicit registration sites | PASS | Current clauses match the cited NV pattern family. |
| 333 | 222476063 | Gaia the Magnificent Knight | All printed clauses; 4 explicit registration sites | PASS | Current clauses match the cited NV pattern family. |
| 334 | 223770816 | Blazing Gaia the Spiral Knight | All printed clauses; 5 explicit registration sites | PASS | Current clauses match the cited NV, FUS, COPY pattern family. |
| 335 | 256469525 | Dynatos, the Challenger | All printed clauses; 5 explicit registration sites | PASS | Current clauses match the cited COPY pattern family. |
| 336 | 259366591 | Arckcestial Crystal Shards | All printed clauses; 2 explicit registration sites | FIXED | Applied the LIGHT Spellcaster “also” lock independently of summon success. |
| 337 | 241440521 | Arckcestial Feather | All printed clauses; 3 explicit registration sites | FIXED | Applied the Normal/Special Summon “also” lock independently of search success. |
| 338 | 245354354 | Arckcestial Fireball | All printed clauses; 3 explicit registration sites | FIXED | Added Necrovalley legality/recheck to the mandatory discarded-card revival. |
| 339 | 228860650 | Arckcestial Orb | All printed clauses; 2 explicit registration sites | FIXED | Applied the LIGHT Spellcaster “also” lock independently of self-summon success. |
| 340 | 214511076 | Arckcestial Prism | All printed clauses; 2 explicit registration sites | PASS | Current clauses match the cited NV, SYN pattern family. |
| 341 | 258328859 | Arckcestial Descend | All printed clauses; 3 explicit registration sites | FIXED | Applied the LIGHT Spellcaster “also” lock even if the Deck action becomes impossible; added Set/Necrovalley legality. |
| 342 | 258590942 | Arckcestial Meadow | All printed clauses; 3 explicit registration sites | FIXED | Applied the LIGHT Spellcaster “also” lock independently of search/discard success. |
| 343 | 235051716 | Arckcestial Pillar of Heavens | All printed clauses; 3 explicit registration sites | PASS | Current clauses match the cited NV pattern family. |
| 344 | 228635967 | Rank-Up-Magic Key of Arck Celestial Force | All printed clauses; 2 explicit registration sites | PASS | Current clauses match the cited NV, XYZ pattern family. |
| 345 | 235612490 | Urphiel's Feather Downpour | All printed clauses; 2 explicit registration sites | MANUAL | Added activation-time Necrovalley legality to the discarded self-Set trigger. The second field banish wording and discard-to-Set timing remain ruling-sensitive. |
| 346 | 239235967 | Arckcestial Burning | All printed clauses; 2 explicit registration sites | FIXED | Added activation-time Necrovalley legality to the discarded self-Set trigger. |
| 347 | 219995840 | Light Illusion of Vazagiel | All printed clauses; 2 explicit registration sites | FIXED | Added activation-time Necrovalley legality to the discarded self-Set trigger. |
| 348 | 257176166 | Malphiel, Arckcestial of Protection | All printed clauses; 4 explicit registration sites | PASS | Current clauses match the cited NV, XYZ, SYN, COPY pattern family. |
| 349 | 228386117 | Vazagiel, Arckcestial of Secrets | All printed clauses; 4 explicit registration sites | FIXED | Primary pass fixes rechecked against the current script and official family. |
| 350 | 237089049 | Azeriel, Arckcestial of Demise | All printed clauses; 4 explicit registration sites | FIXED | Added resolution-time Necrovalley recheck to the GY self-summon. |
| 351 | 251710981 | Ophiel, Arckcestial of Wisdom | All printed clauses; 3 explicit registration sites | FIXED | Added resolution-time Necrovalley recheck to the GY self-summon. |
| 352 | 231089172 | Sarifiel, Arckcestial of Moonlight | All printed clauses; 2 explicit registration sites | PASS | Current clauses match the cited NV, XYZ pattern family. |
| 353 | 215105971 | Urphiel, the High Arckcestial | All printed clauses; 3 explicit registration sites | MANUAL | Optional destruction replacement and owner-control leave-field trigger need live validation. |
| 354 | 220856437 | Bauy Magician | All printed clauses; 3 explicit registration sites | PASS | Current clauses match the cited NV, SYN, LINK pattern family. |
| 355 | 250047045 | Dreaming Bau | All printed clauses; 2 explicit registration sites | PASS | Current clauses match the cited NV, SYN pattern family. |
| 356 | 219826457 | Ro-Bau | All printed clauses; 6 explicit registration sites | FIXED | Primary pass fixes rechecked against the current script and official family. |
| 357 | 221511784 | Bau | All printed clauses; 4 explicit registration sites | FIXED | Allowed generic facedown field cards as the non-Bau banishment payment and rechecked Necrovalley on revival. |
| 358 | 237444604 | Winged Bauy Fenrir | All printed clauses; 2 explicit registration sites | PASS | Current clauses match the cited NEG, NV, SYN pattern family. |
| 359 | 256462992 | Starfury Bauy Dragon | All printed clauses; 3 explicit registration sites | PASS | Current clauses match the cited NV, SYN pattern family. |
| 360 | 228169392 | Bael, Demon Incarnate | All printed clauses; 5 explicit registration sites | FIXED | Primary pass fixes rechecked against the current script and official family. |
| 361 | 226950506 | Bauy World | All printed clauses; 3 explicit registration sites | PASS | Current clauses match the cited NV, LINK pattern family. |
| 362 | 254215159 | Bauy Spellcasting | All printed clauses; 5 explicit registration sites | PASS | Current clauses match the cited NEG, NV, SETTURN pattern family. |
| 363 | 225358630 | Rai-Bau | All printed clauses; 4 explicit registration sites | PASS | Current clauses match the cited NEG, NV, SETTURN pattern family. |
| 364 | 223366685 | Bauy Emergency Room! | All printed clauses; 4 explicit registration sites | PASS | Current clauses match the cited NV pattern family. |
| 365 | 259072745 | Bhodi, the Corrupted Halloween Tree | All printed clauses; 6 explicit registration sites | FIXED | Primary pass fixes rechecked against the current script and official family. |
| 366 | 233957828 | Toddler Pumpkien | All printed clauses; 2 explicit registration sites | PASS | Current clauses match the cited NV, LINK pattern family. |
| 367 | 259471193 | Dreadful Soul Drain | All printed clauses; 2 explicit registration sites | FIXED | Primary pass fixes rechecked against the current script and official family. |
| 368 | 212822164 | Bray, Shell of the Ghoti | All printed clauses; 2 explicit registration sites | PASS | Current clauses match the cited NV pattern family. |
| 369 | 235352857 | Shekup, Sting of the Ghoti | All printed clauses; 5 explicit registration sites | PASS | Current clauses match the cited NV, DELAY pattern family. |
| 370 | 240575550 | Ghoti from a Deeper Depth Than the Deepest Deep | All printed clauses; 4 explicit registration sites | MANUAL | Custom Synchro material rule allowing a Fish Tuner as non-Tuner needs live validation. |
| 371 | 255283389 | Myutant El-51 | All printed clauses; 2 explicit registration sites | PASS | Current clauses match the cited NV pattern family. |
| 372 | 244816828 | Myutant Evolution | All printed clauses; 2 explicit registration sites | PASS | Current clauses match the cited NV pattern family. |
| 373 | 211699737 | Myutant Amalgamate | All printed clauses; 2 explicit registration sites | MANUAL | “This effect becomes that monster’s original effect” is approximated with CopyEffect and needs a ruling. |
| 374 | 259308265 | Pumpqueen the Queen of Ghosts | All printed clauses; 1 explicit registration sites | MANUAL | The extra Normal Summon is implemented, but hand Tributes for Castle of Dark Illusions need a ruling/engine implementation. |
| 375 | 239028111 | Pumprince the Prince of Ghosts | All printed clauses; 4 explicit registration sites | PASS | Current clauses match the cited DELAY pattern family. |
| 376 | 230749983 | Hallo, the Giver of Tricks | All printed clauses; 3 explicit registration sites | PASS | Current clauses match the cited NV pattern family. |
| 377 | 250262550 | Ween, Guidance to Treats | All printed clauses; 4 explicit registration sites | PASS | Current clauses match the cited NV pattern family. |
| 378 | 231331942 | Hallo, the Hollow Trickster | All printed clauses; 3 explicit registration sites | MANUAL | Hallo, the Spirit of Tricks is absent from cards.json/DB, so the first effect cannot fully resolve. |
| 379 | 224800873 | Hallo-Ween! Basket of Treats | All printed clauses; 2 explicit registration sites | PASS | Current clauses match the cited NV pattern family. |
| 380 | 255977900 | Happy Hallo-Ween! | All printed clauses; 3 explicit registration sites | PASS | Current clauses match the cited NV pattern family. |
| 381 | 215621622 | A Night of Fright on Hallo-Ween! | All printed clauses; 1 explicit registration sites | PASS | Current clauses match the cited NV pattern family. |
| 382 | 221672256 | Skewy! Boo Boo | All printed clauses; 2 explicit registration sites | PASS | Current clauses match the cited NEG, NV pattern family. |
| 383 | 258576611 | Skewy! Candee Hex | All printed clauses; 7 explicit registration sites | FIXED | Required the full printed 2 Candy Counters instead of silently falling back to 1. |
| 384 | 252496004 | Skewy! Pumpki-Pal | All printed clauses; 4 explicit registration sites | FIXED | Primary pass fixes rechecked against the current script and official family. |
| 385 | 234592047 | Skewy! Twick-Or-Tweat | All printed clauses; 1 explicit registration sites | PASS | Current clauses match the cited CORE pattern family. |
| 386 | 217632789 | Skewy! Pawty Tyme | All printed clauses; 2 explicit registration sites | FIXED | Allowed the revival follow-up after successful destruction even when the destroyed card is redirected from the GY. |
| 387 | 254375894 | Crewal Cap'n | All printed clauses; 4 explicit registration sites | FIXED | Added resolution-time Necrovalley recheck to the GY self-summon. |
| 388 | 237269434 | Crewal Crew | All printed clauses; 4 explicit registration sites | FIXED | Added resolution-time Necrovalley recheck before the GY self-summon follow-up. |
| 389 | 215730767 | Crewal Helmsman | All printed clauses; 4 explicit registration sites | PASS | Current clauses match the cited NV pattern family. |
| 390 | 250792632 | Crewal Sailor | All printed clauses; 4 explicit registration sites | FIXED | Added target and resolution-time Necrovalley checks to the GY recovery. |

## Resumed-half verification

- luac -p ordinals 281–390: PASS (110/110).
- Further Lane B/full-folder syntax and strict smoke are recorded in the consolidated 173–390 ledger.



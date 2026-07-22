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

# CCG Manual-Input Cases - Reported and Skipped

This report implements the audit instruction to record any case requiring manual input and skip it instead of blocking the remaining card review.

## Outcome

- Active CCG cards covered by the hash-pinned effect ledger: **577**
- Current card reviews: **577**
- Objectively reviewed as pass/fixed: **482**
- Skipped with a remaining ruling or engine limitation: **95**
- Additional fixed-card regression scenarios retained: **2**
- Total interactive/manual scenarios documented: **97**
- Reconciliation errors: **0**

`Skipped` means no speculative text or Lua change was made. The current implementation remains pinned by text and script hashes, and the exact unresolved question stays in the queue below.

## Remaining design or engine decisions

These cards cannot be promoted to a fully proven effect-logic pass without the listed ruling or interactive Omega evidence.

| Ord. | Card | Static verdict | Workstream | Reason requiring manual input |
|---:|---|---|---|---|
| 12 | Stained Silhouette (`256608976`) | MANUAL_RULING | Copied, rewritten, and resolving effects | nonstandard CopyEffect. |
| 129 | Rage of Nephthys (`256287781`) | MANUAL_RULING | Copied, rewritten, and resolving effects | quoted pronoun ruling. |
| 165 | Eldora, the Intergalactic Empire (`214552846`) | MANUAL_RULING | Copied, rewritten, and resolving effects | 12 source typo / operation-info inference. |
| 167 | Frozen Girl & Blood Moon (`222676270`) | MANUAL_RULING | Copied, rewritten, and resolving effects | classifier false-positive/negative testing. |
| 168 | Ghost Doll & Midnight Manor (`222782750`) | MANUAL_RULING | Copied, rewritten, and resolving effects | operation-info coverage. |
| 170 | Clock of Aldrez (`210716547`) | MANUAL_RULING | Copied, rewritten, and resolving effects | concurrent chain rewrite state. |
| 276 | Chapter Ii Verse Iv (`241957394`) | MANUAL_RULING | Copied, rewritten, and resolving effects | Corrected rewritten chain target to the Effect Monster actually chosen and rewrote sequencing to destroy other matching monsters first, then the chosen monster only on success; retroactive Token-tribute/cost semantics still require an Omega duel test. |
| 373 | Myutant Amalgamate (`211699737`) | MANUAL_RULING | Copied, rewritten, and resolving effects | "This effect becomes that monster's original effect" is approximated with CopyEffect and needs a ruling. |
| 438 | Gravinity Axis Matter (`256831125`) | UNSUPPORTED | Copied, rewritten, and resolving effects | Copied-effect scope and printed Link Rating reduction are not exact. |
| 454 | Galactican Battle Station (`258934904`) | MANUAL_RULING | Copied, rewritten, and resolving effects | Adds an effect to another resolving effect in Damage Step. |
| 134 | Protogenic Astral Cycle (`232706629`) | MANUAL_RULING | Co-link, counter, and zone topology | zone mask / "ignore card effects". |
| 298 | Carcel, the Dark Ohmen (`259780273`) | MANUAL_RULING | Co-link, counter, and zone topology | Added the official retroactive Ohmen-only Special Summon activity lock. Custom reveal/two-card summon and traversal behavior still needs duel-engine validation. |
| 299 | Ohmen Surge (`259869259`) | MANUAL_RULING | Co-link, counter, and zone topology | Moved the once-per-turn limit to card activation; the continuous control effect is no longer falsely limited. EVENT_ADJUST co-link tracking and forced zone-control movement are custom mechanics. |
| 300 | Siemens, the Ohmechanic Conductor (`259405917`) | MANUAL_RULING | Co-link, counter, and zone topology | Prevented the move effect from activating without a free Main Monster Zone. Custom co-link destination movement remains an in-engine UI/ruling risk. |
| 301 | Farad, the Ohmechanic Capacitor (`259350270`) | MANUAL_RULING | Co-link, counter, and zone topology | Custom Current Counter traversal/removal across mutually linked cards needs engine validation. |
| 303 | Coulomb, the Ohmechanic Charger (`259841490`) | MANUAL_RULING | Co-link, counter, and zone topology | Prevented the Link-monster move effect from activating without a free Main Monster Zone. Immediate Link Summon and custom zone movement need live Extra Monster Zone validation. |
| 304 | Ampere, the Ohmechanic Intensity (`259479044`) | MANUAL_RULING | Co-link, counter, and zone topology | Custom counter placement/protection over co-linked monsters needs live validation. |
| 305 | Carcel, the Ohmechanic Light (`259033429`) | MANUAL_RULING | Co-link, counter, and zone topology | Moved mass Current Counter removal out of target and into cost. EVENT_ADJUST co-link transition tracking and mass counter consumption need live validation. |
| 307 | Ohmen Beacon (`259650969`) | MANUAL_RULING | Co-link, counter, and zone topology | Prevented the move effect from activating without a free Main Monster Zone. Continuous co-link protection and movement/counter placement need live validation. |
| 136 | To Proto Taxis (`246380598`) | MANUAL_RULING | Damage and stat-layer behavior | damage layering. |
| 139 | To Proto Psychi (`217332244`) | MANUAL_RULING | Damage and stat-layer behavior | 100-LP increment UI. |
| 172 | Phantasm Spiral Resurgence (`219047593`) | MANUAL_RULING | Damage and stat-layer behavior | phase-only persistent negate live test. |
| 13 | Abstain from Light (`232449539`) | MANUAL_RULING | Ownership and opponent-resource use | opponent-Deck Fusion materials; shuffled-card tracker; delayed return [implemented]. |
| 14 | Shattering Sustained (`248453205`) | MANUAL_RULING | Ownership and opponent-resource use | opponent-Deck pseudo-Tribute [manual]; full-zone Tribute legality [fixed]; post-cost target legality [fixed]. |
| 17 | Distained Druid Dragar (`247580036`) | MANUAL_RULING | Ownership and opponent-resource use | opponent-Deck pseudo-Tribute [manual]; remaining Fusion effects [implemented]. |
| 100 | A Stainless Story (`245970073`) | MANUAL_RULING | Ownership and opponent-resource use | copy pool. |
| 109 | Muramasa (`247378501`) | MANUAL_RULING | Ownership and opponent-resource use | alternate Tribute UI. |
| 197 | Securitake Agent (`219543855`) | MANUAL_RULING | Ownership and opponent-resource use | Script is internally consistent, but the intended scope of opponent-owned Link material (opponent monster you control versus opponent's field) needs a ruling. |
| 408 | Vampire Reptilian (`259552732`) | MANUAL_RULING | Ownership and opponent-resource use | Opponent-monster Xyz material/control semantics. |
| 59 | Sacred Treasure - Bojin (`236542835`) | MANUAL_RULING | Timing, delayed state, and reset behavior | same-event interpretation. |
| 61 | Sacred Treasure - Huangjin (`246421842`) | MANUAL_RULING | Timing, delayed state, and reset behavior | same-event interpretation. |
| 70 | Tove, the Domesticated (`259737127`) | MANUAL_RULING | Timing, delayed state, and reset behavior | summon restriction/draw-send/GY delayed Battle Phase return [implemented]. |
| 101 | Mylo, the Domesticated (`259686203`) | MANUAL_RULING | Timing, delayed state, and reset behavior | summon restriction UI. |
| 102 | Nuwa, the Domesticated (`259135917`) | MANUAL_RULING | Timing, delayed state, and reset behavior | summon restriction UI. |
| 103 | Mylo in the Wild (`259911246`) | MANUAL_RULING | Timing, delayed state, and reset behavior | position restoration ruling. |
| 110 | Kanmuriyama (`248801935`) | MANUAL_RULING | Timing, delayed state, and reset behavior | lost-target event state. |
| 113 | Otakemaru the Accuser (`221855414`) | MANUAL_RULING | Timing, delayed state, and reset behavior | paired summon UI. |
| 126 | Priestess of Nephthys (`211964444`) | MANUAL_RULING | Timing, delayed state, and reset behavior | copied Standby effect pool. |
| 132 | Protogenesis (`246524183`) | MANUAL_RULING | Timing, delayed state, and reset behavior | if you do timing. |
| 267 | Chrono-Saur Rex (`236898203`) | MANUAL_RULING | Timing, delayed state, and reset behavior | Fixed prerequisite destruction to own face-up on-field Chrono/Dinosaur cards and scheduled self-destruction for the actual summoning phase (Main Phase 1 or Battle Phase); EVENT_PHASE+PHASE_MAIN1 lacks an exact official analogue and needs live timing validation. |
| 3 | The Condescender (`221321849`) | UNSUPPORTED | Summon, material, and selection UI | summon procedure; Level and Rank reduction; Link Rating reduction unsupported. |
| 46 | The Blue Frute (`236158052`) | MANUAL_RULING | Summon, material, and selection UI | custom UI. |
| 47 | The Yellow Frute (`235607781`) | MANUAL_RULING | Summon, material, and selection UI | custom UI. |
| 48 | The Red Frute (`246216813`) | MANUAL_RULING | Summon, material, and selection UI | custom UI. |
| 49 | The Green Frute (`227745087`) | MANUAL_RULING | Summon, material, and selection UI | custom UI. |
| 50 | The White Frute (`220916791`) | MANUAL_RULING | Summon, material, and selection UI | mandatory Tribute opens MZONE before target check [fixed]; summon effect [implemented]. |
| 51 | Fruteonia (`246830897`) | MANUAL_RULING | Summon, material, and selection UI | face-down Link/Ritual UI. |
| 52 | Fruteopia (`216140411`) | MANUAL_RULING | Summon, material, and selection UI | face-down Link/Ritual UI. |
| 54 | Fruteification (`256930605`) | MANUAL_RULING | Summon, material, and selection UI | custom summon UI. |
| 57 | The Fruteful Moon (`248290754`) | MANUAL_RULING | Summon, material, and selection UI | custom UI. |
| 69 | Pip, the Domesticated (`259377794`) | MANUAL_RULING | Summon, material, and selection UI | custom Tribute Summon support. |
| 71 | Domestica Praerie (`259264881`) | MANUAL_RULING | Summon, material, and selection UI | custom Tribute UI. |
| 72 | Domestica Anjelie (`259337739`) | MANUAL_RULING | Summon, material, and selection UI | custom Tribute UI. |
| 73 | Domestica Lunalie (`259245149`) | MANUAL_RULING | Summon, material, and selection UI | custom Tribute UI. |
| 76 | Domestica in the Underworld (`259668626`) | MANUAL_RULING | Summon, material, and selection UI | extra Tribute UI. |
| 77 | Domestica in the Wild (`259410628`) | MANUAL_RULING | Summon, material, and selection UI | Fusion UI. |
| 78 | Domestica Kyrie (`259670933`) | MANUAL_RULING | Summon, material, and selection UI | custom procedure. |
| 85 | Ursarctic Leoship (`247831166`) | MANUAL_RULING | Summon, material, and selection UI | custom replacement integration. |
| 86 | Ursarctic Octantis (`235051048`) | MANUAL_RULING | Summon, material, and selection UI | custom Synchro-style procedure. |
| 87 | Ursarctic Hextanius (`244921711`) | MANUAL_RULING | Summon, material, and selection UI | non-Synchro procedure; Deck summon; shuffle-draw with hidden banishment excluded [fixed]. |
| 88 | Ursarctic Nordbar (`249093610`) | MANUAL_RULING | Summon, material, and selection UI | custom procedure. |
| 90 | Branching to Guidance (`222257685`) | MANUAL_RULING | Summon, material, and selection UI | copied token identity/stats UI. |
| 105 | Onibi (`217713649`) | MANUAL_RULING | Summon, material, and selection UI | immediate Normal Summon UI. |
| 116 | Serene Mermaid of the Grand Blue (`259369909`) | MANUAL_RULING | Summon, material, and selection UI | hand summon; Fusion Summon; post-Fusion Extra Deck restriction approximated. |
| 123 | Grand Blue Matriarch (`259093260`) | MANUAL_RULING | Summon, material, and selection UI | Synchro UI. |
| 127 | Sacred Feather of Nephthys (`216532402`) | MANUAL_RULING | Summon, material, and selection UI | Ritual UI. |
| 128 | Stellaer of the Frozen (`259581666`) | MANUAL_RULING | Summon, material, and selection UI | face-up S/T Set cases. |
| 137 | Stellaer of the Plants (`259219942`) | MANUAL_RULING | Summon, material, and selection UI | overlay redirect UI. |
| 147 | Stellaer of the Breeze (`230998543`) | MANUAL_RULING | Summon, material, and selection UI | Xyz UI. |
| 161 | Restoration of Azrynior (`236239443`) | MANUAL_RULING | Summon, material, and selection UI | multi-summon UI. |
| 169 | Dominus Sentinel (`259290896`) | MANUAL_RULING | Summon, material, and selection UI | custom Attributes. |
| 187 | Vir Pedicae Mortis - Fearless Hunter (`244778917`) | MANUAL_RULING | Summon, material, and selection UI | Printed "treated as 2 materials" for a named Link Summon is not implemented; official generic Link helpers expose no source-monster effect that safely changes material weight. Requires destination-procedure/ruling work. |
| 201 | Bobbie Bluefin & the Nautical Nocturnes (`259114562`) | MANUAL_RULING | Summon, material, and selection UI | When both Normal and Special Summon are legal the script chooses Special Summon without an explicit player choice; confirm intended forced-summon choice semantics. |
| 202 | Scarlet Seareef & the Nautical Creatures (`220749574`) | MANUAL_RULING | Summon, material, and selection UI | Forced summon branch choice and bottom-of-Deck ordering need in-engine/ruling confirmation. |
| 203 | Evander Coldwater & the Nautical Abyss (`225109525`) | MANUAL_RULING | Summon, material, and selection UI | Returned monster can become eligible for the subsequent forced summon; confirm that this matches intended sequencing. |
| 204 | Nautical Backwashing & Oceanic Waves (`223158720`) | MANUAL_RULING | Summon, material, and selection UI | Forced Normal/Special Summon selection defaults to Special when both are legal; printed choice semantics need confirmation. |
| 206 | Exploring the Nautical Waters (`248946297`) | MANUAL_RULING | Summon, material, and selection UI | Forced summon branch and bottom-deck order need an engine/ruling test. |
| 207 | Nautical Adventures & Torrential Seas (`218905439`) | MANUAL_RULING | Summon, material, and selection UI | A returned monster may be eligible for the subsequent forced summon; confirm intended pool and branch choice. |
| 209 | Bob, but Stronger! (`259944943`) | MANUAL_RULING | Summon, material, and selection UI | Fixed contact-Fusion material search from LOCATION_MZONE to official LOCATION_ONFIELD; live test still required to confirm Omega permits the "Umi" Spell to pass Fusion-material legality. |
| 237 | Windborne Eye of the Storm (`256110263`) | MANUAL_RULING | Summon, material, and selection UI | The script uses a temporary synthetic Token material to emulate "treated as a Synchro Summon using only Windborne"; this bespoke engine workaround needs live validation. |
| 306 | Ohmen Powerload (`259434499`) | MANUAL_RULING | Summon, material, and selection UI | Added the official retroactive Thunder-only Special Summon activity lock. Custom optional counter removal/destruction branch needs UI validation. |
| 321 | Phlogistic Uprising! (`257239133`) | MANUAL_RULING | Summon, material, and selection UI | Excluded illegal LP payments that would reduce LP below the engine minimum. Fusion Summon from GY/Extra with mixed send/shuffle materials is custom and needs live validation. |
| 330 | Chamroshes' Aegis (`221924008`) | MANUAL_RULING | Summon, material, and selection UI | Contact-style Extra Deck summon by shuffling three differently named Tuners needs procedure validation. |
| 370 | Ghoti from a Deeper Depth Than the Deepest Deep (`240575550`) | MANUAL_RULING | Summon, material, and selection UI | Custom Synchro material rule allowing a Fish Tuner as non-Tuner needs live validation. |
| 374 | Pumpqueen the Queen of Ghosts (`259308265`) | MANUAL_RULING | Summon, material, and selection UI | The extra Normal Summon is implemented, but hand Tributes for Castle of Dark Illusions need a ruling/engine implementation. |
| 404 | Ghostrick Oni (`239335848`) | MANUAL_RULING | Summon, material, and selection UI | Custom Xyz material transfer/Quick conversion. |
| 435 | Gravinity Spherix (`231088629`) | MANUAL_RULING | Summon, material, and selection UI | Summon replacement plus minimum GY Xyz material. |
| 56 | The Hanging Frute (`213266433`) | MANUAL_RULING | Other custom engine behavior | attack-all approximation; temporary protection [manual]. |
| 60 | Sacred Treasure - Chunyin (`229499914`) | MANUAL_RULING | Other custom engine behavior | banish trigger; face-up banished add filter [fixed]. |
| 120 | City Within the Grand Blue (`259679619`) | MANUAL_RULING | Other custom engine behavior | runtime alias. |
| 302 | Volt, the Ohmechanic Chocker (`259519336`) | MANUAL_RULING | Other custom engine behavior | Moved all-counter payment to cost and made the destruction correctly non-targeting. Custom counter-threshold continuous/Quick interaction needs live validation after the confirmed fixes. |
| 353 | Urphiel, the High Arckcestial (`215105971`) | MANUAL_RULING | Other custom engine behavior | Optional destruction replacement and owner-control leave-field trigger need live validation. |
| 439 | Gravinity Sonic Scream (`238184015`) | MANUAL_RULING | Other custom engine behavior | Copied activated-effect semantics. |
| 443 | Flower Cardian Moonflare (`248940511`) | MANUAL_RULING | Other custom engine behavior | One card treated as 3 non-Tuners. |
| 457 | Attack on Gravity (`259307285`) | MANUAL_RULING | Other custom engine behavior | Card-wide hand permission cannot safely distinguish its two activation modes. |

## Exact unsupported or ambiguous clauses

### Gravinity Axis Matter (`256831125`)

- **UNSUPPORTED — Reduce the Level, Rank, or Link Rating of opposing monsters sharing a Gravinity column by 1.**
  - Current implementation: EFFECT_UPDATE_LEVEL and EFFECT_UPDATE_RANK cover the first two values; no Link Rating modifier exists in the bundled Omega API/constants.
- **MANUAL_RULING — During the Standby Phase, reveal a Level 11 Gravinity Synchro and gain its non-activated effects for the turn.**
  - Current implementation: The current pool's Nebulix and Spherix non-activated behavior is implemented explicitly with temporary effects.
  - Why skipped: The explicit implementation must be extended if another eligible Level 11 Gravinity Synchro is added.

### Abstain from Light (`232449539`)

- **MANUAL_RULING — If your Stain monster was shuffled into either Deck this turn, face-up Stain monsters in the opponent's Deck may be banished as material and return to the GY in the End Phase.**
  - Current implementation: Tracks effect-driven Stain moves into a Deck, adds only face-up opponent-Deck monsters to the material group, banishes selected materials, and retains exactly that group for the End Phase return.
  - Why skipped: Omega EVENT_MOVE does not expose whether a Deck entry used shuffle versus top/bottom placement, so the trigger discriminator and face-up opponent-Deck material UI still require an engine scenario test.

### The Condescender (`221321849`)

- **UNSUPPORTED — Send from hand and reduce a target's Level, Rank, or Link Rating by 1-3 until the end of the next turn.**
  - Current implementation: Implements EFFECT_UPDATE_LEVEL and EFFECT_UPDATE_RANK only; Link monsters are not legal targets.
  - Why skipped: The bundled Omega constant/API corpus exposes no effect code that changes Link Rating. The printed Link Rating branch cannot be implemented faithfully in this runtime.
- **UNSUPPORTED — Special Summon from the GY while a monster has a reduced Level, Rank, or Link Rating, then banish this card when it leaves.**
  - Current implementation: The reduced-value condition covers Level and Rank, and the summon applies EFFECT_LEAVE_FIELD_REDIRECT; the Link Rating condition is necessarily absent.

## Full skipped/manual scenario queue

The detailed setup, positive/negative checks, acceptance condition, script hash, and test deck for every row remain in `docs/lua-manual-review-guide-2026-07-20.md` and `scripts/output/omega_manual_test_ledger.json`.

### Copied, rewritten, and resolving effects

| # | Card | Disposition | Static verdict | Manual question | Status |
|---:|---|---|---|---|---:|
| 1 | Stained Silhouette (`256608976`) | SKIPPED_MANUAL_INPUT | MANUAL_RULING | nonstandard CopyEffect. | pending |
| 2 | Rage of Nephthys (`256287781`) | SKIPPED_MANUAL_INPUT | MANUAL_RULING | quoted pronoun ruling. | pending |
| 3 | Eldora, the Intergalactic Empire (`214552846`) | SKIPPED_MANUAL_INPUT | MANUAL_RULING | 12 source typo / operation-info inference. | pending |
| 4 | Frozen Girl & Blood Moon (`222676270`) | SKIPPED_MANUAL_INPUT | MANUAL_RULING | classifier false-positive/negative testing. | pending |
| 5 | Ghost Doll & Midnight Manor (`222782750`) | SKIPPED_MANUAL_INPUT | MANUAL_RULING | operation-info coverage. | pending |
| 6 | Clock of Aldrez (`210716547`) | SKIPPED_MANUAL_INPUT | MANUAL_RULING | concurrent chain rewrite state. | pending |
| 7 | Chapter Ii Verse Iv (`241957394`) | SKIPPED_MANUAL_INPUT | MANUAL_RULING | Corrected rewritten chain target to the Effect Monster actually chosen and rewrote sequencing to destroy other matching monsters first, then the chosen monster only on success; retroactive Token-tribute/cost semantics still require an Omega duel test. | pending |
| 8 | Myutant Amalgamate (`211699737`) | SKIPPED_MANUAL_INPUT | MANUAL_RULING | "This effect becomes that monster's original effect" is approximated with CopyEffect and needs a ruling. | pending |
| 9 | Gravinity Axis Matter (`256831125`) | SKIPPED_MANUAL_INPUT | UNSUPPORTED | Copied-effect scope and printed Link Rating reduction are not exact. | pending |
| 10 | Galactican Battle Station (`258934904`) | SKIPPED_MANUAL_INPUT | MANUAL_RULING | Adds an effect to another resolving effect in Damage Step. | pending |

### Co-link, counter, and zone topology

| # | Card | Disposition | Static verdict | Manual question | Status |
|---:|---|---|---|---|---:|
| 11 | Protogenic Astral Cycle (`232706629`) | SKIPPED_MANUAL_INPUT | MANUAL_RULING | zone mask / "ignore card effects". | pending |
| 12 | Carcel, the Dark Ohmen (`259780273`) | SKIPPED_MANUAL_INPUT | MANUAL_RULING | Added the official retroactive Ohmen-only Special Summon activity lock. Custom reveal/two-card summon and traversal behavior still needs duel-engine validation. | pending |
| 13 | Ohmen Surge (`259869259`) | SKIPPED_MANUAL_INPUT | MANUAL_RULING | Moved the once-per-turn limit to card activation; the continuous control effect is no longer falsely limited. EVENT_ADJUST co-link tracking and forced zone-control movement are custom mechanics. | pending |
| 14 | Siemens, the Ohmechanic Conductor (`259405917`) | SKIPPED_MANUAL_INPUT | MANUAL_RULING | Prevented the move effect from activating without a free Main Monster Zone. Custom co-link destination movement remains an in-engine UI/ruling risk. | pending |
| 15 | Farad, the Ohmechanic Capacitor (`259350270`) | SKIPPED_MANUAL_INPUT | MANUAL_RULING | Custom Current Counter traversal/removal across mutually linked cards needs engine validation. | pending |
| 16 | Coulomb, the Ohmechanic Charger (`259841490`) | SKIPPED_MANUAL_INPUT | MANUAL_RULING | Prevented the Link-monster move effect from activating without a free Main Monster Zone. Immediate Link Summon and custom zone movement need live Extra Monster Zone validation. | pending |
| 17 | Ampere, the Ohmechanic Intensity (`259479044`) | SKIPPED_MANUAL_INPUT | MANUAL_RULING | Custom counter placement/protection over co-linked monsters needs live validation. | pending |
| 18 | Carcel, the Ohmechanic Light (`259033429`) | SKIPPED_MANUAL_INPUT | MANUAL_RULING | Moved mass Current Counter removal out of target and into cost. EVENT_ADJUST co-link transition tracking and mass counter consumption need live validation. | pending |
| 19 | Ohmen Beacon (`259650969`) | SKIPPED_MANUAL_INPUT | MANUAL_RULING | Prevented the move effect from activating without a free Main Monster Zone. Continuous co-link protection and movement/counter placement need live validation. | pending |

### Damage and stat-layer behavior

| # | Card | Disposition | Static verdict | Manual question | Status |
|---:|---|---|---|---|---:|
| 20 | To Proto Taxis (`246380598`) | SKIPPED_MANUAL_INPUT | MANUAL_RULING | damage layering. | pending |
| 21 | To Proto Psychi (`217332244`) | SKIPPED_MANUAL_INPUT | MANUAL_RULING | 100-LP increment UI. | pending |
| 22 | Phantasm Spiral Resurgence (`219047593`) | SKIPPED_MANUAL_INPUT | MANUAL_RULING | phase-only persistent negate live test. | pending |

### Ownership and opponent-resource use

| # | Card | Disposition | Static verdict | Manual question | Status |
|---:|---|---|---|---|---:|
| 23 | Abstain from Light (`232449539`) | SKIPPED_MANUAL_INPUT | MANUAL_RULING | opponent-Deck Fusion materials; shuffled-card tracker; delayed return [implemented]. | pending |
| 24 | Shattering Sustained (`248453205`) | SKIPPED_MANUAL_INPUT | MANUAL_RULING | opponent-Deck pseudo-Tribute [manual]; full-zone Tribute legality [fixed]; post-cost target legality [fixed]. | pending |
| 25 | Distained Druid Dragar (`247580036`) | SKIPPED_MANUAL_INPUT | MANUAL_RULING | opponent-Deck pseudo-Tribute [manual]; remaining Fusion effects [implemented]. | pending |
| 26 | A Stainless Story (`245970073`) | SKIPPED_MANUAL_INPUT | MANUAL_RULING | copy pool. | pending |
| 27 | Muramasa (`247378501`) | SKIPPED_MANUAL_INPUT | MANUAL_RULING | alternate Tribute UI. | pending |
| 28 | Securitake Agent (`219543855`) | SKIPPED_MANUAL_INPUT | MANUAL_RULING | Script is internally consistent, but the intended scope of opponent-owned Link material (opponent monster you control versus opponent's field) needs a ruling. | pending |
| 29 | Vampire Reptilian (`259552732`) | SKIPPED_MANUAL_INPUT | MANUAL_RULING | Opponent-monster Xyz material/control semantics. | pending |

### Timing, delayed state, and reset behavior

| # | Card | Disposition | Static verdict | Manual question | Status |
|---:|---|---|---|---|---:|
| 30 | Sacred Treasure - Bojin (`236542835`) | SKIPPED_MANUAL_INPUT | MANUAL_RULING | same-event interpretation. | pending |
| 31 | Sacred Treasure - Huangjin (`246421842`) | SKIPPED_MANUAL_INPUT | MANUAL_RULING | same-event interpretation. | pending |
| 32 | Tove, the Domesticated (`259737127`) | SKIPPED_MANUAL_INPUT | MANUAL_RULING | summon restriction/draw-send/GY delayed Battle Phase return [implemented]. | pending |
| 33 | Mylo, the Domesticated (`259686203`) | SKIPPED_MANUAL_INPUT | MANUAL_RULING | summon restriction UI. | pending |
| 34 | Nuwa, the Domesticated (`259135917`) | SKIPPED_MANUAL_INPUT | MANUAL_RULING | summon restriction UI. | pending |
| 35 | Mylo in the Wild (`259911246`) | SKIPPED_MANUAL_INPUT | MANUAL_RULING | position restoration ruling. | pending |
| 36 | Kanmuriyama (`248801935`) | SKIPPED_MANUAL_INPUT | MANUAL_RULING | lost-target event state. | pending |
| 37 | Otakemaru the Accuser (`221855414`) | SKIPPED_MANUAL_INPUT | MANUAL_RULING | paired summon UI. | pending |
| 38 | Priestess of Nephthys (`211964444`) | SKIPPED_MANUAL_INPUT | MANUAL_RULING | copied Standby effect pool. | pending |
| 39 | Protogenesis (`246524183`) | SKIPPED_MANUAL_INPUT | MANUAL_RULING | if you do timing. | pending |
| 40 | Chrono-Saur Rex (`236898203`) | SKIPPED_MANUAL_INPUT | MANUAL_RULING | Fixed prerequisite destruction to own face-up on-field Chrono/Dinosaur cards and scheduled self-destruction for the actual summoning phase (Main Phase 1 or Battle Phase); EVENT_PHASE+PHASE_MAIN1 lacks an exact official analogue and needs live timing validation. | pending |
| 41 | Stardust Comet (`231523659`) | REGRESSION_ONLY | FIXED | Deck Tribute/immediate Synchro/Level timing. | pending |

### Summon, material, and selection UI

| # | Card | Disposition | Static verdict | Manual question | Status |
|---:|---|---|---|---|---:|
| 42 | The Condescender (`221321849`) | SKIPPED_MANUAL_INPUT | UNSUPPORTED | summon procedure; Level and Rank reduction; Link Rating reduction unsupported. | pending |
| 43 | Stained Fox Feness (`247499445`) | REGRESSION_ONLY | FIXED | printed colon versus procedure UI. | pending |
| 44 | The Blue Frute (`236158052`) | SKIPPED_MANUAL_INPUT | MANUAL_RULING | custom UI. | pending |
| 45 | The Yellow Frute (`235607781`) | SKIPPED_MANUAL_INPUT | MANUAL_RULING | custom UI. | pending |
| 46 | The Red Frute (`246216813`) | SKIPPED_MANUAL_INPUT | MANUAL_RULING | custom UI. | pending |
| 47 | The Green Frute (`227745087`) | SKIPPED_MANUAL_INPUT | MANUAL_RULING | custom UI. | pending |
| 48 | The White Frute (`220916791`) | SKIPPED_MANUAL_INPUT | MANUAL_RULING | mandatory Tribute opens MZONE before target check [fixed]; summon effect [implemented]. | pending |
| 49 | Fruteonia (`246830897`) | SKIPPED_MANUAL_INPUT | MANUAL_RULING | face-down Link/Ritual UI. | pending |
| 50 | Fruteopia (`216140411`) | SKIPPED_MANUAL_INPUT | MANUAL_RULING | face-down Link/Ritual UI. | pending |
| 51 | Fruteification (`256930605`) | SKIPPED_MANUAL_INPUT | MANUAL_RULING | custom summon UI. | pending |
| 52 | The Fruteful Moon (`248290754`) | SKIPPED_MANUAL_INPUT | MANUAL_RULING | custom UI. | pending |
| 53 | Pip, the Domesticated (`259377794`) | SKIPPED_MANUAL_INPUT | MANUAL_RULING | custom Tribute Summon support. | pending |
| 54 | Domestica Praerie (`259264881`) | SKIPPED_MANUAL_INPUT | MANUAL_RULING | custom Tribute UI. | pending |
| 55 | Domestica Anjelie (`259337739`) | SKIPPED_MANUAL_INPUT | MANUAL_RULING | custom Tribute UI. | pending |
| 56 | Domestica Lunalie (`259245149`) | SKIPPED_MANUAL_INPUT | MANUAL_RULING | custom Tribute UI. | pending |
| 57 | Domestica in the Underworld (`259668626`) | SKIPPED_MANUAL_INPUT | MANUAL_RULING | extra Tribute UI. | pending |
| 58 | Domestica in the Wild (`259410628`) | SKIPPED_MANUAL_INPUT | MANUAL_RULING | Fusion UI. | pending |
| 59 | Domestica Kyrie (`259670933`) | SKIPPED_MANUAL_INPUT | MANUAL_RULING | custom procedure. | pending |
| 60 | Ursarctic Leoship (`247831166`) | SKIPPED_MANUAL_INPUT | MANUAL_RULING | custom replacement integration. | pending |
| 61 | Ursarctic Octantis (`235051048`) | SKIPPED_MANUAL_INPUT | MANUAL_RULING | custom Synchro-style procedure. | pending |
| 62 | Ursarctic Hextanius (`244921711`) | SKIPPED_MANUAL_INPUT | MANUAL_RULING | non-Synchro procedure; Deck summon; shuffle-draw with hidden banishment excluded [fixed]. | pending |
| 63 | Ursarctic Nordbar (`249093610`) | SKIPPED_MANUAL_INPUT | MANUAL_RULING | custom procedure. | pending |
| 64 | Branching to Guidance (`222257685`) | SKIPPED_MANUAL_INPUT | MANUAL_RULING | copied token identity/stats UI. | pending |
| 65 | Onibi (`217713649`) | SKIPPED_MANUAL_INPUT | MANUAL_RULING | immediate Normal Summon UI. | pending |
| 66 | Serene Mermaid of the Grand Blue (`259369909`) | SKIPPED_MANUAL_INPUT | MANUAL_RULING | hand summon; Fusion Summon; post-Fusion Extra Deck restriction approximated. | pending |
| 67 | Grand Blue Matriarch (`259093260`) | SKIPPED_MANUAL_INPUT | MANUAL_RULING | Synchro UI. | pending |
| 68 | Sacred Feather of Nephthys (`216532402`) | SKIPPED_MANUAL_INPUT | MANUAL_RULING | Ritual UI. | pending |
| 69 | Stellaer of the Frozen (`259581666`) | SKIPPED_MANUAL_INPUT | MANUAL_RULING | face-up S/T Set cases. | pending |
| 70 | Stellaer of the Plants (`259219942`) | SKIPPED_MANUAL_INPUT | MANUAL_RULING | overlay redirect UI. | pending |
| 71 | Stellaer of the Breeze (`230998543`) | SKIPPED_MANUAL_INPUT | MANUAL_RULING | Xyz UI. | pending |
| 72 | Restoration of Azrynior (`236239443`) | SKIPPED_MANUAL_INPUT | MANUAL_RULING | multi-summon UI. | pending |
| 73 | Dominus Sentinel (`259290896`) | SKIPPED_MANUAL_INPUT | MANUAL_RULING | custom Attributes. | pending |
| 74 | Vir Pedicae Mortis - Fearless Hunter (`244778917`) | SKIPPED_MANUAL_INPUT | MANUAL_RULING | Printed "treated as 2 materials" for a named Link Summon is not implemented; official generic Link helpers expose no source-monster effect that safely changes material weight. Requires destination-procedure/ruling work. | pending |
| 75 | Bobbie Bluefin & the Nautical Nocturnes (`259114562`) | SKIPPED_MANUAL_INPUT | MANUAL_RULING | When both Normal and Special Summon are legal the script chooses Special Summon without an explicit player choice; confirm intended forced-summon choice semantics. | pending |
| 76 | Scarlet Seareef & the Nautical Creatures (`220749574`) | SKIPPED_MANUAL_INPUT | MANUAL_RULING | Forced summon branch choice and bottom-of-Deck ordering need in-engine/ruling confirmation. | pending |
| 77 | Evander Coldwater & the Nautical Abyss (`225109525`) | SKIPPED_MANUAL_INPUT | MANUAL_RULING | Returned monster can become eligible for the subsequent forced summon; confirm that this matches intended sequencing. | pending |
| 78 | Nautical Backwashing & Oceanic Waves (`223158720`) | SKIPPED_MANUAL_INPUT | MANUAL_RULING | Forced Normal/Special Summon selection defaults to Special when both are legal; printed choice semantics need confirmation. | pending |
| 79 | Exploring the Nautical Waters (`248946297`) | SKIPPED_MANUAL_INPUT | MANUAL_RULING | Forced summon branch and bottom-deck order need an engine/ruling test. | pending |
| 80 | Nautical Adventures & Torrential Seas (`218905439`) | SKIPPED_MANUAL_INPUT | MANUAL_RULING | A returned monster may be eligible for the subsequent forced summon; confirm intended pool and branch choice. | pending |
| 81 | Bob, but Stronger! (`259944943`) | SKIPPED_MANUAL_INPUT | MANUAL_RULING | Fixed contact-Fusion material search from LOCATION_MZONE to official LOCATION_ONFIELD; live test still required to confirm Omega permits the "Umi" Spell to pass Fusion-material legality. | pending |
| 82 | Windborne Eye of the Storm (`256110263`) | SKIPPED_MANUAL_INPUT | MANUAL_RULING | The script uses a temporary synthetic Token material to emulate "treated as a Synchro Summon using only Windborne"; this bespoke engine workaround needs live validation. | pending |
| 83 | Ohmen Powerload (`259434499`) | SKIPPED_MANUAL_INPUT | MANUAL_RULING | Added the official retroactive Thunder-only Special Summon activity lock. Custom optional counter removal/destruction branch needs UI validation. | pending |
| 84 | Phlogistic Uprising! (`257239133`) | SKIPPED_MANUAL_INPUT | MANUAL_RULING | Excluded illegal LP payments that would reduce LP below the engine minimum. Fusion Summon from GY/Extra with mixed send/shuffle materials is custom and needs live validation. | pending |
| 85 | Chamroshes' Aegis (`221924008`) | SKIPPED_MANUAL_INPUT | MANUAL_RULING | Contact-style Extra Deck summon by shuffling three differently named Tuners needs procedure validation. | pending |
| 86 | Ghoti from a Deeper Depth Than the Deepest Deep (`240575550`) | SKIPPED_MANUAL_INPUT | MANUAL_RULING | Custom Synchro material rule allowing a Fish Tuner as non-Tuner needs live validation. | pending |
| 87 | Pumpqueen the Queen of Ghosts (`259308265`) | SKIPPED_MANUAL_INPUT | MANUAL_RULING | The extra Normal Summon is implemented, but hand Tributes for Castle of Dark Illusions need a ruling/engine implementation. | pending |
| 88 | Ghostrick Oni (`239335848`) | SKIPPED_MANUAL_INPUT | MANUAL_RULING | Custom Xyz material transfer/Quick conversion. | pending |
| 89 | Gravinity Spherix (`231088629`) | SKIPPED_MANUAL_INPUT | MANUAL_RULING | Summon replacement plus minimum GY Xyz material. | pending |

### Other custom engine behavior

| # | Card | Disposition | Static verdict | Manual question | Status |
|---:|---|---|---|---|---:|
| 90 | The Hanging Frute (`213266433`) | SKIPPED_MANUAL_INPUT | MANUAL_RULING | attack-all approximation; temporary protection [manual]. | pending |
| 91 | Sacred Treasure - Chunyin (`229499914`) | SKIPPED_MANUAL_INPUT | MANUAL_RULING | banish trigger; face-up banished add filter [fixed]. | pending |
| 92 | City Within the Grand Blue (`259679619`) | SKIPPED_MANUAL_INPUT | MANUAL_RULING | runtime alias. | pending |
| 93 | Volt, the Ohmechanic Chocker (`259519336`) | SKIPPED_MANUAL_INPUT | MANUAL_RULING | Moved all-counter payment to cost and made the destruction correctly non-targeting. Custom counter-threshold continuous/Quick interaction needs live validation after the confirmed fixes. | pending |
| 94 | Urphiel, the High Arckcestial (`215105971`) | SKIPPED_MANUAL_INPUT | MANUAL_RULING | Optional destruction replacement and owner-control leave-field trigger need live validation. | pending |
| 95 | Gravinity Sonic Scream (`238184015`) | SKIPPED_MANUAL_INPUT | MANUAL_RULING | Copied activated-effect semantics. | pending |
| 96 | Flower Cardian Moonflare (`248940511`) | SKIPPED_MANUAL_INPUT | MANUAL_RULING | One card treated as 3 non-Tuners. | pending |
| 97 | Attack on Gravity (`259307285`) | SKIPPED_MANUAL_INPUT | MANUAL_RULING | Card-wide hand permission cannot safely distinguish its two activation modes. | pending |

## Completion boundary

All 577 cards have a current hash-pinned static review. This report is the explicit boundary for cases intentionally skipped under the manual-input instruction; automated QA does not misrepresent these scenarios as replay-backed live passes.

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

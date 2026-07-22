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

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


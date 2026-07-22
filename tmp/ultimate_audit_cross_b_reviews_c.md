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

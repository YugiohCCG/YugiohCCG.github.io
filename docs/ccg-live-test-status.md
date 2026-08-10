# CCG Live Omega Test Status

This ledger tracks the ruling- and engine-sensitive cards that cannot be certified by syntax, callback, database, or static semantic checks alone.

- Total live-test cards: 123
- Passed: 0
- Failed: 0
- Blocked on ruling: 0
- Pending: 123

A card reaches `passed` only with the adopted ruling, positive and negative boundary cases, interruption case where applicable, and replay/log evidence recorded in the JSON ledger.

## Execution workflow

1. Open the named deck from `scripts/output/omega_test_decks` in YGO Omega and create the board state described by the card's checklist in the manual review guide.
2. Run the positive case, negative boundary case, and interruption case where applicable on the pinned Lua script.
3. Save the replay or keep the duel open, then run `python scripts/record_omega_manual_test.py --card <ID> ... --evidence <REPLAY>` or use `--capture-omega-log`. The recorder copies and hashes the evidence and refuses incomplete passes.
4. Use `python scripts/record_omega_manual_test.py --next` for the next pending card. After all cases pass, run `python scripts/build_omega_manual_test_ledger.py --require-complete`.

Omega's local client API can read duel state/logs and drive a spawned bot, but it cannot create the initial duel or scripted board state. Those setup steps remain interactive.

## Queue

| # | Card | Workstream | Status | Test deck |
|---:|---|---|---:|---|
| 1 | Stained Avatar (`244790302`) | Card-pool and dependency definitions | pending | Stain |
| 2 | Niuhao - Zao (`250556612`) | Card-pool and dependency definitions | pending | NiuHao |
| 3 | Prophecy of Infernos (`229327103`) | Card-pool and dependency definitions | pending | Prophecy |
| 4 | Prophecy of Waterfalls (`251058567`) | Card-pool and dependency definitions | pending | Prophecy |
| 5 | Prophecy of Boulders (`223558392`) | Card-pool and dependency definitions | pending | Prophecy |
| 6 | Prophecy of Storms (`223592011`) | Card-pool and dependency definitions | pending | Prophecy |
| 7 | Prophecy of Rays (`244920555`) | Card-pool and dependency definitions | pending | Prophecy |
| 8 | Prophecy of Shadows (`243920845`) | Card-pool and dependency definitions | pending | Prophecy |
| 9 | To Proto Archegoni (`245400676`) | Card-pool and dependency definitions | pending | To Proto |
| 10 | Polemistis Gia Ataxia (`254065048`) | Card-pool and dependency definitions | pending | To Proto |
| 11 | Ektelestis Gia Taxis (`212684822`) | Card-pool and dependency definitions | pending | To Proto |
| 12 | Birth of Azrynior (`239245471`) | Card-pool and dependency definitions | pending | Standalone and Non-Engine Lab |
| 13 | Fall of Azrynior (`224751741`) | Card-pool and dependency definitions | pending | Dysmandr |
| 14 | Azrynior, the Abundaence of Purity (`245099829`) | Card-pool and dependency definitions | pending | Stellaer |
| 15 | Dysmandr, the Depraevity of Worlds (`223512283`) | Card-pool and dependency definitions | pending | Dysmandr |
| 16 | Vir Pedicae Mortis - Entity's Happy Servant (`215984744`) | Card-pool and dependency definitions | pending | Vir Pedicae Mortis |
| 17 | Hallo, the Hollow Trickster (`231331942`) | Card-pool and dependency definitions | pending | Hallo-Ween!, Spirit |
| 18 | Stained Silhouette (`256608976`) | Copied, rewritten, and resolving effects | pending | Stain |
| 19 | Rage of Nephthys (`256287781`) | Copied, rewritten, and resolving effects | pending | Nephthys |
| 20 | Eldora, the Intergalactic Empire (`214552846`) | Copied, rewritten, and resolving effects | pending | Dysmandr, Eldora |
| 21 | Frozen Girl & Blood Moon (`222676270`) | Copied, rewritten, and resolving effects | pending | A.I.P, Aldrez, Altergeist, Aquamarine, Arckcestial, Bau, Bob, Charmelia, Chrono-Saur, Crewal, Crying Chaos, Domestica, Dysmandr, Eclipse, Eldora, Frute, Gaia, Galactica, Ghostrick, Ghoti, Gladiator Beast, Glitchling, Grand Blue, Gravinity, Grayscale, Hallo-Ween!, Harpie, Herald, Leet, Myutant, Nautica, Nemleria, Nephthys, NiuHao, Ohmen, Orcust, Phantasm Spiral, Phlogiston Dragon, Pot, Prophecy, Pumpkin, Red-Eyes, Scarstech, Shining Brigade, Skewy!, Spirit, Stain, Starry Knight, Stellaer, Talismandrake, To Proto, Ursarctic, Vampire, Vir Pedicae Mortis, Wicked Puppeteer, Windborne, Wyvernal, Standalone and Non-Engine Lab |
| 22 | Ghost Doll & Midnight Manor (`222782750`) | Copied, rewritten, and resolving effects | pending | A.I.P, Aldrez, Altergeist, Aquamarine, Arckcestial, Bau, Bob, Charmelia, Chrono-Saur, Crewal, Crying Chaos, Domestica, Dysmandr, Eclipse, Eldora, Frute, Gaia, Galactica, Ghostrick, Ghoti, Gladiator Beast, Glitchling, Grand Blue, Gravinity, Grayscale, Hallo-Ween!, Harpie, Herald, Leet, Myutant, Nautica, Nemleria, Nephthys, NiuHao, Ohmen, Orcust, Phantasm Spiral, Phlogiston Dragon, Pot, Prophecy, Pumpkin, Red-Eyes, Scarstech, Shining Brigade, Skewy!, Spirit, Stain, Starry Knight, Stellaer, Talismandrake, To Proto, Ursarctic, Vampire, Vir Pedicae Mortis, Wicked Puppeteer, Windborne, Wyvernal, Standalone and Non-Engine Lab |
| 23 | Clock of Aldrez (`210716547`) | Copied, rewritten, and resolving effects | pending | Aldrez |
| 24 | Chapter Ii Verse Iv (`241957394`) | Copied, rewritten, and resolving effects | pending | Dysmandr |
| 25 | Myutant Amalgamate (`211699737`) | Copied, rewritten, and resolving effects | pending | Myutant |
| 26 | Gravinity Axis Matter (`256831125`) | Copied, rewritten, and resolving effects | pending | Gravinity |
| 27 | Galactican Battle Station (`258934904`) | Copied, rewritten, and resolving effects | pending | Galactica |
| 28 | Protogenic Astral Cycle (`232706629`) | Co-link, counter, and zone topology | pending | To Proto |
| 29 | Carcel, the Dark Ohmen (`259780273`) | Co-link, counter, and zone topology | pending | Ohmen |
| 30 | Ohmen Surge (`259869259`) | Co-link, counter, and zone topology | pending | Ohmen |
| 31 | Siemens, the Ohmechanic Conductor (`259405917`) | Co-link, counter, and zone topology | pending | Ohmen |
| 32 | Farad, the Ohmechanic Capacitor (`259350270`) | Co-link, counter, and zone topology | pending | Ohmen |
| 33 | Coulomb, the Ohmechanic Charger (`259841490`) | Co-link, counter, and zone topology | pending | Ohmen |
| 34 | Ampere, the Ohmechanic Intensity (`259479044`) | Co-link, counter, and zone topology | pending | Ohmen |
| 35 | Carcel, the Ohmechanic Light (`259033429`) | Co-link, counter, and zone topology | pending | Ohmen |
| 36 | Ohmen Beacon (`259650969`) | Co-link, counter, and zone topology | pending | Ohmen |
| 37 | To Proto Chrono (`244013196`) | Source wording and authoritative rulings | pending | To Proto |
| 38 | Extinction of Dysmandr (`242009896`) | Source wording and authoritative rulings | pending | Dysmandr |
| 39 | Eldora in Depraevity (`229786055`) | Source wording and authoritative rulings | pending | Dysmandr, Eldora |
| 40 | Recollection: Kaboom Papa (`241447408`) | Source wording and authoritative rulings | pending | Vir Pedicae Mortis |
| 41 | Pot of Gambling (`224774049`) | Source wording and authoritative rulings | pending | Pot |
| 42 | Chrono-Saur Laplace Plesio (`251236672`) | Source wording and authoritative rulings | pending | Chrono-Saur |
| 43 | Devotee of Fire (`236721134`) | Source wording and authoritative rulings | pending | Phlogiston Dragon |
| 44 | Urphiel's Feather Downpour (`235612490`) | Source wording and authoritative rulings | pending | Arckcestial |
| 45 | Scarstech Prologue (`224467692`) | Source wording and authoritative rulings | pending | Scarstech |
| 46 | To Proto Taxis (`246380598`) | Damage and stat-layer behavior | pending | To Proto |
| 47 | To Proto Psychi (`217332244`) | Damage and stat-layer behavior | pending | To Proto |
| 48 | Phantasm Spiral Resurgence (`219047593`) | Damage and stat-layer behavior | pending | Phantasm Spiral |
| 49 | Abstain from Light (`232449539`) | Ownership and opponent-resource use | pending | Stain |
| 50 | Shattering Sustained (`248453205`) | Ownership and opponent-resource use | pending | Stain |
| 51 | Distained Druid Dragar (`247580036`) | Ownership and opponent-resource use | pending | Stain |
| 52 | A Stainless Story (`245970073`) | Ownership and opponent-resource use | pending | Stain |
| 53 | Muramasa (`247378501`) | Ownership and opponent-resource use | pending | Spirit |
| 54 | Securitake Agent (`219543855`) | Ownership and opponent-resource use | pending | Standalone and Non-Engine Lab |
| 55 | Vampire Reptilian (`259552732`) | Ownership and opponent-resource use | pending | Vampire |
| 56 | Sacred Treasure - Bojin (`236542835`) | Timing, delayed state, and reset behavior | pending | NiuHao |
| 57 | Sacred Treasure - Huangjin (`246421842`) | Timing, delayed state, and reset behavior | pending | NiuHao |
| 58 | Tove, the Domesticated (`259737127`) | Timing, delayed state, and reset behavior | pending | Domestica |
| 59 | Mylo, the Domesticated (`259686203`) | Timing, delayed state, and reset behavior | pending | Domestica |
| 60 | Nuwa, the Domesticated (`259135917`) | Timing, delayed state, and reset behavior | pending | Domestica |
| 61 | Mylo in the Wild (`259911246`) | Timing, delayed state, and reset behavior | pending | Domestica |
| 62 | Kanmuriyama (`248801935`) | Timing, delayed state, and reset behavior | pending | Spirit |
| 63 | Otakemaru the Accuser (`221855414`) | Timing, delayed state, and reset behavior | pending | Spirit |
| 64 | Priestess of Nephthys (`211964444`) | Timing, delayed state, and reset behavior | pending | Nephthys |
| 65 | Protogenesis (`246524183`) | Timing, delayed state, and reset behavior | pending | To Proto |
| 66 | Chrono-Saur Rex (`236898203`) | Timing, delayed state, and reset behavior | pending | Chrono-Saur |
| 67 | Stardust Comet (`231523659`) | Timing, delayed state, and reset behavior | pending | Standalone and Non-Engine Lab |
| 68 | The Condescender (`221321849`) | Summon, material, and selection UI | pending | Standalone and Non-Engine Lab |
| 69 | Stained Fox Feness (`247499445`) | Summon, material, and selection UI | pending | Stain |
| 70 | The Blue Frute (`236158052`) | Summon, material, and selection UI | pending | Frute |
| 71 | The Yellow Frute (`235607781`) | Summon, material, and selection UI | pending | Frute |
| 72 | The Red Frute (`246216813`) | Summon, material, and selection UI | pending | Frute |
| 73 | The Green Frute (`227745087`) | Summon, material, and selection UI | pending | Frute |
| 74 | The White Frute (`220916791`) | Summon, material, and selection UI | pending | Frute |
| 75 | Fruteonia (`246830897`) | Summon, material, and selection UI | pending | Frute |
| 76 | Fruteopia (`216140411`) | Summon, material, and selection UI | pending | Frute |
| 77 | Fruteification (`256930605`) | Summon, material, and selection UI | pending | Frute |
| 78 | The Fruteful Moon (`248290754`) | Summon, material, and selection UI | pending | Frute |
| 79 | Pip, the Domesticated (`259377794`) | Summon, material, and selection UI | pending | Domestica |
| 80 | Domestica Praerie (`259264881`) | Summon, material, and selection UI | pending | Domestica |
| 81 | Domestica Anjelie (`259337739`) | Summon, material, and selection UI | pending | Domestica |
| 82 | Domestica Lunalie (`259245149`) | Summon, material, and selection UI | pending | Domestica |
| 83 | Domestica in the Underworld (`259668626`) | Summon, material, and selection UI | pending | Domestica |
| 84 | Domestica in the Wild (`259410628`) | Summon, material, and selection UI | pending | Domestica |
| 85 | Domestica Kyrie (`259670933`) | Summon, material, and selection UI | pending | Domestica |
| 86 | Ursarctic Leoship (`247831166`) | Summon, material, and selection UI | pending | Ursarctic |
| 87 | Ursarctic Octantis (`235051048`) | Summon, material, and selection UI | pending | Ursarctic |
| 88 | Ursarctic Hextanius (`244921711`) | Summon, material, and selection UI | pending | Ursarctic |
| 89 | Ursarctic Nordbar (`249093610`) | Summon, material, and selection UI | pending | Ursarctic |
| 90 | Branching to Guidance (`222257685`) | Summon, material, and selection UI | pending | A.I.P, Aldrez, Altergeist, Aquamarine, Arckcestial, Bau, Bob, Charmelia, Chrono-Saur, Crewal, Crying Chaos, Domestica, Dysmandr, Eclipse, Eldora, Frute, Gaia, Galactica, Ghostrick, Ghoti, Gladiator Beast, Glitchling, Grand Blue, Gravinity, Grayscale, Hallo-Ween!, Harpie, Herald, Leet, Myutant, Nautica, Nemleria, Nephthys, NiuHao, Ohmen, Orcust, Phantasm Spiral, Phlogiston Dragon, Pot, Prophecy, Pumpkin, Red-Eyes, Scarstech, Shining Brigade, Skewy!, Spirit, Stain, Starry Knight, Stellaer, Talismandrake, To Proto, Ursarctic, Vampire, Vir Pedicae Mortis, Wicked Puppeteer, Windborne, Wyvernal, Standalone and Non-Engine Lab |
| 91 | Onibi (`217713649`) | Summon, material, and selection UI | pending | Spirit |
| 92 | Serene Mermaid of the Grand Blue (`259369909`) | Summon, material, and selection UI | pending | Grand Blue |
| 93 | Grand Blue Matriarch (`259093260`) | Summon, material, and selection UI | pending | Grand Blue |
| 94 | Sacred Feather of Nephthys (`216532402`) | Summon, material, and selection UI | pending | Nephthys |
| 95 | Stellaer of the Frozen (`259581666`) | Summon, material, and selection UI | pending | Stellaer |
| 96 | Stellaer of the Plants (`259219942`) | Summon, material, and selection UI | pending | Stellaer |
| 97 | Stellaer of the Breeze (`230998543`) | Summon, material, and selection UI | pending | Stellaer |
| 98 | Restoration of Azrynior (`236239443`) | Summon, material, and selection UI | pending | Standalone and Non-Engine Lab |
| 99 | Dominus Sentinel (`259290896`) | Summon, material, and selection UI | pending | A.I.P, Aldrez, Altergeist, Aquamarine, Arckcestial, Bau, Bob, Charmelia, Chrono-Saur, Crewal, Crying Chaos, Domestica, Dysmandr, Eclipse, Eldora, Frute, Gaia, Galactica, Ghostrick, Ghoti, Gladiator Beast, Glitchling, Grand Blue, Gravinity, Grayscale, Hallo-Ween!, Harpie, Herald, Leet, Myutant, Nautica, Nemleria, Nephthys, NiuHao, Ohmen, Orcust, Phantasm Spiral, Phlogiston Dragon, Pot, Prophecy, Pumpkin, Red-Eyes, Scarstech, Shining Brigade, Skewy!, Spirit, Stain, Starry Knight, Stellaer, Talismandrake, To Proto, Ursarctic, Vampire, Vir Pedicae Mortis, Wicked Puppeteer, Windborne, Wyvernal, Standalone and Non-Engine Lab |
| 100 | Vir Pedicae Mortis - Fearless Hunter (`244778917`) | Summon, material, and selection UI | pending | Vir Pedicae Mortis |
| 101 | Bobbie Bluefin & the Nautical Nocturnes (`259114562`) | Summon, material, and selection UI | pending | Nautica |
| 102 | Scarlet Seareef & the Nautical Creatures (`220749574`) | Summon, material, and selection UI | pending | Nautica |
| 103 | Evander Coldwater & the Nautical Abyss (`225109525`) | Summon, material, and selection UI | pending | Nautica |
| 104 | Nautical Backwashing & Oceanic Waves (`223158720`) | Summon, material, and selection UI | pending | Nautica |
| 105 | Exploring the Nautical Waters (`248946297`) | Summon, material, and selection UI | pending | Nautica |
| 106 | Nautical Adventures & Torrential Seas (`218905439`) | Summon, material, and selection UI | pending | Nautica |
| 107 | Bob, but Stronger! (`259944943`) | Summon, material, and selection UI | pending | Bob |
| 108 | Windborne Eye of the Storm (`256110263`) | Summon, material, and selection UI | pending | Windborne |
| 109 | Ohmen Powerload (`259434499`) | Summon, material, and selection UI | pending | Ohmen |
| 110 | Phlogistic Uprising! (`257239133`) | Summon, material, and selection UI | pending | Phlogiston Dragon |
| 111 | Chamroshes' Aegis (`221924008`) | Summon, material, and selection UI | pending | Standalone and Non-Engine Lab |
| 112 | Ghoti from a Deeper Depth Than the Deepest Deep (`240575550`) | Summon, material, and selection UI | pending | Ghoti |
| 113 | Pumpqueen the Queen of Ghosts (`259308265`) | Summon, material, and selection UI | pending | Pumpkin |
| 114 | Ghostrick Oni (`239335848`) | Summon, material, and selection UI | pending | Ghostrick |
| 115 | Gravinity Spherix (`231088629`) | Summon, material, and selection UI | pending | Gravinity |
| 116 | The Hanging Frute (`213266433`) | Other custom engine behavior | pending | Frute |
| 117 | Sacred Treasure - Chunyin (`229499914`) | Other custom engine behavior | pending | NiuHao |
| 118 | City Within the Grand Blue (`259679619`) | Other custom engine behavior | pending | Grand Blue |
| 119 | Volt, the Ohmechanic Chocker (`259519336`) | Other custom engine behavior | pending | Ohmen |
| 120 | Urphiel, the High Arckcestial (`215105971`) | Other custom engine behavior | pending | Arckcestial |
| 121 | Gravinity Sonic Scream (`238184015`) | Other custom engine behavior | pending | Gravinity |
| 122 | Flower Cardian Moonflare (`248940511`) | Other custom engine behavior | pending | Standalone and Non-Engine Lab |
| 123 | Attack on Gravity (`259307285`) | Other custom engine behavior | pending | Galactica |

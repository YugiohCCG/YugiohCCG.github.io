# CCG Live Omega Test Status

This ledger tracks the ruling- and engine-sensitive cards that cannot be certified by syntax, callback, database, or static semantic checks alone.

- Historical guide entries resolved statically and excluded: 26
- Total live-test cards: 97
- Passed: 0
- Failed: 0
- Blocked on ruling: 0
- Pending: 97

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
| 1 | Stained Silhouette (`256608976`) | Copied, rewritten, and resolving effects | pending | Stain |
| 2 | Rage of Nephthys (`256287781`) | Copied, rewritten, and resolving effects | pending | Nephthys |
| 3 | Eldora, the Intergalactic Empire (`214552846`) | Copied, rewritten, and resolving effects | pending | Dysmandr, Eldora |
| 4 | Frozen Girl & Blood Moon (`222676270`) | Copied, rewritten, and resolving effects | pending | A.I.P, Aerocat, Aldrez, Altergeist, Aquamarine, Arckcestial, Ashened, Bau, Bob, Charmelia, Chrono-Saur, Crewal, Crying Chaos, Dinomorphia, Domestica, Dysmandr, Eclipse, Eldora, Frute, Gaia, Galactica, Ghostrick, Ghoti, Gladiator Beast, Glitchling, Grand Blue, Gravinity, Grayscale, Hallo-Ween!, Harpie, Herald, Krawler, Leet, Myutant, Nautica, Nemleria, Nephthys, NiuHao, Ohmen, Orcust, Phantasm Spiral, Phlogiston Dragon, Pot, Prophecy, Pumpkin, Pyre, Red-Eyes, Scarstech, Shining Brigade, Skewy!, Spirit, Stain, Starry Knight, Stellaer, Talismandrake, To Proto, Ursarctic, Vampire, Vaylantz, Vir Pedicae Mortis, Wicked Puppeteer, Windborne, World Legacy, Wyvernal, Standalone and Non-Engine Lab |
| 5 | Ghost Doll & Midnight Manor (`222782750`) | Copied, rewritten, and resolving effects | pending | A.I.P, Aerocat, Aldrez, Altergeist, Aquamarine, Arckcestial, Ashened, Bau, Bob, Charmelia, Chrono-Saur, Crewal, Crying Chaos, Dinomorphia, Domestica, Dysmandr, Eclipse, Eldora, Frute, Gaia, Galactica, Ghostrick, Ghoti, Gladiator Beast, Glitchling, Grand Blue, Gravinity, Grayscale, Hallo-Ween!, Harpie, Herald, Krawler, Leet, Myutant, Nautica, Nemleria, Nephthys, NiuHao, Ohmen, Orcust, Phantasm Spiral, Phlogiston Dragon, Pot, Prophecy, Pumpkin, Pyre, Red-Eyes, Scarstech, Shining Brigade, Skewy!, Spirit, Stain, Starry Knight, Stellaer, Talismandrake, To Proto, Ursarctic, Vampire, Vaylantz, Vir Pedicae Mortis, Wicked Puppeteer, Windborne, World Legacy, Wyvernal, Standalone and Non-Engine Lab |
| 6 | Clock of Aldrez (`210716547`) | Copied, rewritten, and resolving effects | pending | Aldrez |
| 7 | Chapter Ii Verse Iv (`241957394`) | Copied, rewritten, and resolving effects | pending | Dysmandr |
| 8 | Myutant Amalgamate (`211699737`) | Copied, rewritten, and resolving effects | pending | Myutant |
| 9 | Gravinity Axis Matter (`256831125`) | Copied, rewritten, and resolving effects | pending | Gravinity |
| 10 | Galactican Battle Station (`258934904`) | Copied, rewritten, and resolving effects | pending | Galactica |
| 11 | Protogenic Astral Cycle (`232706629`) | Co-link, counter, and zone topology | pending | To Proto |
| 12 | Carcel, the Dark Ohmen (`259780273`) | Co-link, counter, and zone topology | pending | Ohmen |
| 13 | Ohmen Surge (`259869259`) | Co-link, counter, and zone topology | pending | Ohmen |
| 14 | Siemens, the Ohmechanic Conductor (`259405917`) | Co-link, counter, and zone topology | pending | Ohmen |
| 15 | Farad, the Ohmechanic Capacitor (`259350270`) | Co-link, counter, and zone topology | pending | Ohmen |
| 16 | Coulomb, the Ohmechanic Charger (`259841490`) | Co-link, counter, and zone topology | pending | Ohmen |
| 17 | Ampere, the Ohmechanic Intensity (`259479044`) | Co-link, counter, and zone topology | pending | Ohmen |
| 18 | Carcel, the Ohmechanic Light (`259033429`) | Co-link, counter, and zone topology | pending | Ohmen |
| 19 | Ohmen Beacon (`259650969`) | Co-link, counter, and zone topology | pending | Ohmen |
| 20 | To Proto Taxis (`246380598`) | Damage and stat-layer behavior | pending | To Proto |
| 21 | To Proto Psychi (`217332244`) | Damage and stat-layer behavior | pending | To Proto |
| 22 | Phantasm Spiral Resurgence (`219047593`) | Damage and stat-layer behavior | pending | Phantasm Spiral |
| 23 | Abstain from Light (`232449539`) | Ownership and opponent-resource use | pending | Stain |
| 24 | Shattering Sustained (`248453205`) | Ownership and opponent-resource use | pending | Stain |
| 25 | Distained Druid Dragar (`247580036`) | Ownership and opponent-resource use | pending | Stain |
| 26 | A Stainless Story (`245970073`) | Ownership and opponent-resource use | pending | Stain |
| 27 | Muramasa (`247378501`) | Ownership and opponent-resource use | pending | Spirit |
| 28 | Securitake Agent (`219543855`) | Ownership and opponent-resource use | pending | Standalone and Non-Engine Lab |
| 29 | Vampire Reptilian (`259552732`) | Ownership and opponent-resource use | pending | Vampire |
| 30 | Sacred Treasure - Bojin (`236542835`) | Timing, delayed state, and reset behavior | pending | NiuHao |
| 31 | Sacred Treasure - Huangjin (`246421842`) | Timing, delayed state, and reset behavior | pending | NiuHao |
| 32 | Tove, the Domesticated (`259737127`) | Timing, delayed state, and reset behavior | pending | Domestica |
| 33 | Mylo, the Domesticated (`259686203`) | Timing, delayed state, and reset behavior | pending | Domestica |
| 34 | Nuwa, the Domesticated (`259135917`) | Timing, delayed state, and reset behavior | pending | Domestica |
| 35 | Mylo in the Wild (`259911246`) | Timing, delayed state, and reset behavior | pending | Domestica |
| 36 | Kanmuriyama (`248801935`) | Timing, delayed state, and reset behavior | pending | Spirit |
| 37 | Otakemaru the Accuser (`221855414`) | Timing, delayed state, and reset behavior | pending | Spirit |
| 38 | Priestess of Nephthys (`211964444`) | Timing, delayed state, and reset behavior | pending | Nephthys |
| 39 | Protogenesis (`246524183`) | Timing, delayed state, and reset behavior | pending | To Proto |
| 40 | Chrono-Saur Rex (`236898203`) | Timing, delayed state, and reset behavior | pending | Chrono-Saur |
| 41 | Stardust Comet (`231523659`) | Timing, delayed state, and reset behavior | pending | Standalone and Non-Engine Lab |
| 42 | The Condescender (`221321849`) | Summon, material, and selection UI | pending | Standalone and Non-Engine Lab |
| 43 | Stained Fox Feness (`247499445`) | Summon, material, and selection UI | pending | Stain |
| 44 | The Blue Frute (`236158052`) | Summon, material, and selection UI | pending | Frute |
| 45 | The Yellow Frute (`235607781`) | Summon, material, and selection UI | pending | Frute |
| 46 | The Red Frute (`246216813`) | Summon, material, and selection UI | pending | Frute |
| 47 | The Green Frute (`227745087`) | Summon, material, and selection UI | pending | Frute |
| 48 | The White Frute (`220916791`) | Summon, material, and selection UI | pending | Frute |
| 49 | Fruteonia (`246830897`) | Summon, material, and selection UI | pending | Frute |
| 50 | Fruteopia (`216140411`) | Summon, material, and selection UI | pending | Frute |
| 51 | Fruteification (`256930605`) | Summon, material, and selection UI | pending | Frute |
| 52 | The Fruteful Moon (`248290754`) | Summon, material, and selection UI | pending | Frute |
| 53 | Pip, the Domesticated (`259377794`) | Summon, material, and selection UI | pending | Domestica |
| 54 | Domestica Praerie (`259264881`) | Summon, material, and selection UI | pending | Domestica |
| 55 | Domestica Anjelie (`259337739`) | Summon, material, and selection UI | pending | Domestica |
| 56 | Domestica Lunalie (`259245149`) | Summon, material, and selection UI | pending | Domestica |
| 57 | Domestica in the Underworld (`259668626`) | Summon, material, and selection UI | pending | Domestica |
| 58 | Domestica in the Wild (`259410628`) | Summon, material, and selection UI | pending | Domestica |
| 59 | Domestica Kyrie (`259670933`) | Summon, material, and selection UI | pending | Domestica |
| 60 | Ursarctic Leoship (`247831166`) | Summon, material, and selection UI | pending | Ursarctic |
| 61 | Ursarctic Octantis (`235051048`) | Summon, material, and selection UI | pending | Ursarctic |
| 62 | Ursarctic Hextanius (`244921711`) | Summon, material, and selection UI | pending | Ursarctic |
| 63 | Ursarctic Nordbar (`249093610`) | Summon, material, and selection UI | pending | Ursarctic |
| 64 | Branching to Guidance (`222257685`) | Summon, material, and selection UI | pending | A.I.P, Aerocat, Aldrez, Altergeist, Aquamarine, Arckcestial, Ashened, Bau, Bob, Charmelia, Chrono-Saur, Crewal, Crying Chaos, Dinomorphia, Domestica, Dysmandr, Eclipse, Eldora, Frute, Gaia, Galactica, Ghostrick, Ghoti, Gladiator Beast, Glitchling, Grand Blue, Gravinity, Grayscale, Hallo-Ween!, Harpie, Herald, Krawler, Leet, Myutant, Nautica, Nemleria, Nephthys, NiuHao, Ohmen, Orcust, Phantasm Spiral, Phlogiston Dragon, Pot, Prophecy, Pumpkin, Pyre, Red-Eyes, Scarstech, Shining Brigade, Skewy!, Spirit, Stain, Starry Knight, Stellaer, Talismandrake, To Proto, Ursarctic, Vampire, Vaylantz, Vir Pedicae Mortis, Wicked Puppeteer, Windborne, World Legacy, Wyvernal, Standalone and Non-Engine Lab |
| 65 | Onibi (`217713649`) | Summon, material, and selection UI | pending | Spirit |
| 66 | Serene Mermaid of the Grand Blue (`259369909`) | Summon, material, and selection UI | pending | Grand Blue |
| 67 | Grand Blue Matriarch (`259093260`) | Summon, material, and selection UI | pending | Grand Blue |
| 68 | Sacred Feather of Nephthys (`216532402`) | Summon, material, and selection UI | pending | Nephthys |
| 69 | Stellaer of the Frozen (`259581666`) | Summon, material, and selection UI | pending | Stellaer |
| 70 | Stellaer of the Plants (`259219942`) | Summon, material, and selection UI | pending | Stellaer |
| 71 | Stellaer of the Breeze (`230998543`) | Summon, material, and selection UI | pending | Stellaer |
| 72 | Restoration of Azrynior (`236239443`) | Summon, material, and selection UI | pending | Standalone and Non-Engine Lab |
| 73 | Dominus Sentinel (`259290896`) | Summon, material, and selection UI | pending | A.I.P, Aerocat, Aldrez, Altergeist, Aquamarine, Arckcestial, Ashened, Bau, Bob, Charmelia, Chrono-Saur, Crewal, Crying Chaos, Dinomorphia, Domestica, Dysmandr, Eclipse, Eldora, Frute, Gaia, Galactica, Ghostrick, Ghoti, Gladiator Beast, Glitchling, Grand Blue, Gravinity, Grayscale, Hallo-Ween!, Harpie, Herald, Krawler, Leet, Myutant, Nautica, Nemleria, Nephthys, NiuHao, Ohmen, Orcust, Phantasm Spiral, Phlogiston Dragon, Pot, Prophecy, Pumpkin, Pyre, Red-Eyes, Scarstech, Shining Brigade, Skewy!, Spirit, Stain, Starry Knight, Stellaer, Talismandrake, To Proto, Ursarctic, Vampire, Vaylantz, Vir Pedicae Mortis, Wicked Puppeteer, Windborne, World Legacy, Wyvernal, Standalone and Non-Engine Lab |
| 74 | Vir Pedicae Mortis - Fearless Hunter (`244778917`) | Summon, material, and selection UI | pending | Vir Pedicae Mortis |
| 75 | Bobbie Bluefin & the Nautical Nocturnes (`259114562`) | Summon, material, and selection UI | pending | Nautica |
| 76 | Scarlet Seareef & the Nautical Creatures (`220749574`) | Summon, material, and selection UI | pending | Nautica |
| 77 | Evander Coldwater & the Nautical Abyss (`225109525`) | Summon, material, and selection UI | pending | Nautica |
| 78 | Nautical Backwashing & Oceanic Waves (`223158720`) | Summon, material, and selection UI | pending | Nautica |
| 79 | Exploring the Nautical Waters (`248946297`) | Summon, material, and selection UI | pending | Nautica |
| 80 | Nautical Adventures & Torrential Seas (`218905439`) | Summon, material, and selection UI | pending | Nautica |
| 81 | Bob, but Stronger! (`259944943`) | Summon, material, and selection UI | pending | Bob |
| 82 | Windborne Eye of the Storm (`256110263`) | Summon, material, and selection UI | pending | Windborne |
| 83 | Ohmen Powerload (`259434499`) | Summon, material, and selection UI | pending | Ohmen |
| 84 | Phlogistic Uprising! (`257239133`) | Summon, material, and selection UI | pending | Phlogiston Dragon |
| 85 | Chamroshes' Aegis (`221924008`) | Summon, material, and selection UI | pending | Standalone and Non-Engine Lab |
| 86 | Ghoti from a Deeper Depth Than the Deepest Deep (`240575550`) | Summon, material, and selection UI | pending | Ghoti |
| 87 | Pumpqueen the Queen of Ghosts (`259308265`) | Summon, material, and selection UI | pending | Pumpkin |
| 88 | Ghostrick Oni (`239335848`) | Summon, material, and selection UI | pending | Ghostrick |
| 89 | Gravinity Spherix (`231088629`) | Summon, material, and selection UI | pending | Gravinity |
| 90 | The Hanging Frute (`213266433`) | Other custom engine behavior | pending | Frute |
| 91 | Sacred Treasure - Chunyin (`229499914`) | Other custom engine behavior | pending | NiuHao |
| 92 | City Within the Grand Blue (`259679619`) | Other custom engine behavior | pending | Grand Blue |
| 93 | Volt, the Ohmechanic Chocker (`259519336`) | Other custom engine behavior | pending | Ohmen |
| 94 | Urphiel, the High Arckcestial (`215105971`) | Other custom engine behavior | pending | Arckcestial |
| 95 | Gravinity Sonic Scream (`238184015`) | Other custom engine behavior | pending | Gravinity |
| 96 | Flower Cardian Moonflare (`248940511`) | Other custom engine behavior | pending | Standalone and Non-Engine Lab |
| 97 | Attack on Gravity (`259307285`) | Other custom engine behavior | pending | Galactica |

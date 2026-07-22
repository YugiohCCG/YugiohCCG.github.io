# Ultimate Omega Lua audit - 2026-07-20

## Outcome

All **577** cards in `src/data/cards.json` were audited clause-by-clause in a primary pass and an independent cross-pass against the official Omega corpus in `tmp/omega_scripts` (**17,532** Lua files). The public folder contains **592** standalone scripts: all 577 active cards plus 15 preserved orphan/prototype scripts.

| Final classification | Cards |
|---|---:|
| Pass | 267 |
| Fixed | 187 |
| Needs manual ruling / in-engine test | 123 |
| **Total** | **577** |

`Needs manual ruling` takes precedence in this table, so some cards in that group also received confirmed fixes. `Fixed` means at least one confirmed defect was corrected and the resulting script passed the static/runtime harness. `Pass` means neither pass found a defect. None of these labels replaces an actual Omega duel test for custom mechanics.

`src/data/ccg-omega-ids.json` is absent in this checkout. IDs were verified from each card's `passcode` and the synchronized 577-row `CCG_v1_id_map.json`.

## Per-card result table

| Ord. | Omega ID | Card | Result |
|---:|---:|---|---|
| 1 | 245265629 | Stardrake of Gravitic Coils | Pass |
| 2 | 241056746 | Reactor Shocker | Fixed |
| 3 | 221321849 | The Condescender | Needs manual ruling |
| 4 | 225091736 | Stained Bird Bria | Fixed |
| 5 | 216958556 | Stained Deer Dante | Pass |
| 6 | 247499445 | Stained Fox Feness | Needs manual ruling |
| 7 | 224822244 | Stained Raptor Rollo | Pass |
| 8 | 259475154 | Stained Solitaire | Fixed |
| 9 | 218685316 | Stargazer of the Stained | Pass |
| 10 | 244408495 | Stained Scioness Silia | Fixed |
| 11 | 221822671 | Stained Sovereign Silas | Pass |
| 12 | 256608976 | Stained Silhouette | Needs manual ruling |
| 13 | 232449539 | Abstain from Light | Needs manual ruling |
| 14 | 248453205 | Shattering Sustained | Needs manual ruling |
| 15 | 244790302 | Stained Avatar | Needs manual ruling |
| 16 | 247789143 | Stained Sorceress Silphia | Fixed |
| 17 | 247580036 | Distained Druid Dragar | Needs manual ruling |
| 18 | 217174535 | Stainless Kaleidragon | Fixed |
| 19 | 259365935 | Aetherstorm Zenith Wire-Tailed Sypharion | Pass |
| 20 | 224274662 | Armored Nova Mecha-Scaled Xyrion | Pass |
| 21 | 224049334 | Solemn Rebirth | Pass |
| 22 | 230947464 | Talismandrake Spark | Pass |
| 23 | 256928871 | Talismandrake Embers | Pass |
| 24 | 210506870 | Talismandrake Heat | Fixed |
| 25 | 245935439 | Talismandrake Sear | Pass |
| 26 | 215034223 | Talismandrake Arms United | Pass |
| 27 | 238136421 | Left Talismandrake Arms - Blaze Suppressor | Pass |
| 28 | 215921734 | Right Talismandrake Arms - Blaze Halberd | Pass |
| 29 | 248788543 | Right Talismandrake Arms - Blaze Sabre | Pass |
| 30 | 255832330 | Left Talismandrake Arms - Blaze Shield | Pass |
| 31 | 227362839 | Talismandrake Pyre | Pass |
| 32 | 253552927 | Talismandrake Cremation | Fixed |
| 33 | 241706191 | Talismandrake Enkindle | Pass |
| 34 | 218142234 | Maiden of Talismandrakes Seraphina | Fixed |
| 35 | 228926678 | Bishop of Aldrez | Pass |
| 36 | 235448944 | Pawn of Aldrez | Pass |
| 37 | 231892575 | Queen of Aldrez | Pass |
| 38 | 233759343 | Aldrez Battery | Pass |
| 39 | 217700538 | Aldrez Blitz | Pass |
| 40 | 210923192 | Aldrez Opening | Pass |
| 41 | 250508903 | Checked in Aldrez | Pass |
| 42 | 213849997 | Checkmate in Aldrez | Fixed |
| 43 | 238282350 | Knight of Aldrez | Pass |
| 44 | 231129918 | Rook of Aldrez | Fixed |
| 45 | 252210718 | King of Aldrez | Pass |
| 46 | 236158052 | The Blue Frute | Needs manual ruling |
| 47 | 235607781 | The Yellow Frute | Needs manual ruling |
| 48 | 246216813 | The Red Frute | Needs manual ruling |
| 49 | 227745087 | The Green Frute | Needs manual ruling |
| 50 | 220916791 | The White Frute | Needs manual ruling |
| 51 | 246830897 | Fruteonia | Needs manual ruling |
| 52 | 216140411 | Fruteopia | Needs manual ruling |
| 53 | 247458749 | Fruteaching | Pass |
| 54 | 256930605 | Fruteification | Needs manual ruling |
| 55 | 236179696 | The Flying Frute | Pass |
| 56 | 213266433 | The Hanging Frute | Needs manual ruling |
| 57 | 248290754 | The Fruteful Moon | Needs manual ruling |
| 58 | 213615627 | The Fruted Warrior | Pass |
| 59 | 236542835 | Sacred Treasure - Bojin | Needs manual ruling |
| 60 | 229499914 | Sacred Treasure - Chunyin | Needs manual ruling |
| 61 | 246421842 | Sacred Treasure - Huangjin | Needs manual ruling |
| 62 | 218600459 | Niuhao - Bauba | Pass |
| 63 | 235789995 | Niuhao - Hikam | Pass |
| 64 | 232232676 | Niuhao - Oro | Pass |
| 65 | 227043533 | Niuhao - Lokaeo | Pass |
| 66 | 215629896 | Niuhao - Zaoka | Pass |
| 67 | 231825514 | Niuhao - Koai | Pass |
| 68 | 250556612 | Niuhao - Zao | Needs manual ruling |
| 69 | 259377794 | Pip, the Domesticated | Needs manual ruling |
| 70 | 259737127 | Tove, the Domesticated | Needs manual ruling |
| 71 | 259264881 | Domestica Praerie | Needs manual ruling |
| 72 | 259337739 | Domestica Anjelie | Needs manual ruling |
| 73 | 259245149 | Domestica Lunalie | Needs manual ruling |
| 74 | 259201342 | Domestication | Pass |
| 75 | 259265448 | Domestic Underworld | Fixed |
| 76 | 259668626 | Domestica in the Underworld | Needs manual ruling |
| 77 | 259410628 | Domestica in the Wild | Needs manual ruling |
| 78 | 259670933 | Domestica Kyrie | Needs manual ruling |
| 79 | 259394179 | Pip in the Wild | Fixed |
| 80 | 259718504 | Tove in the Wild | Fixed |
| 81 | 216620496 | Remembrance of the Melody | Fixed |
| 82 | 255277197 | Chaos Fusion | Fixed |
| 83 | 245378354 | Ursarctic Mikailus | Pass |
| 84 | 218837030 | Ursarctic Megailus | Pass |
| 85 | 247831166 | Ursarctic Leoship | Needs manual ruling |
| 86 | 235051048 | Ursarctic Octantis | Needs manual ruling |
| 87 | 244921711 | Ursarctic Hextanius | Needs manual ruling |
| 88 | 249093610 | Ursarctic Nordbar | Needs manual ruling |
| 89 | 228686743 | Carina of the Eldoran System | Pass |
| 90 | 222257685 | Branching to Guidance | Needs manual ruling |
| 91 | 215853847 | Rigel the Thousand-Armed | Pass |
| 92 | 229327103 | Prophecy of Infernos | Needs manual ruling |
| 93 | 251058567 | Prophecy of Waterfalls | Needs manual ruling |
| 94 | 223558392 | Prophecy of Boulders | Needs manual ruling |
| 95 | 223592011 | Prophecy of Storms | Needs manual ruling |
| 96 | 244920555 | Prophecy of Rays | Needs manual ruling |
| 97 | 243920845 | Prophecy of Shadows | Needs manual ruling |
| 98 | 259586445 | Stellaer of the Swamp | Fixed |
| 99 | 219419648 | Sustained Succubus Saria | Pass |
| 100 | 245970073 | A Stainless Story | Needs manual ruling |
| 101 | 259686203 | Mylo, the Domesticated | Needs manual ruling |
| 102 | 259135917 | Nuwa, the Domesticated | Needs manual ruling |
| 103 | 259911246 | Mylo in the Wild | Needs manual ruling |
| 104 | 259796760 | Nuwa in the Wild | Fixed |
| 105 | 217713649 | Onibi | Needs manual ruling |
| 106 | 214371067 | Enra | Pass |
| 107 | 229399508 | Kokeshisa | Pass |
| 108 | 228033609 | Shishi | Pass |
| 109 | 247378501 | Muramasa | Needs manual ruling |
| 110 | 248801935 | Kanmuriyama | Needs manual ruling |
| 111 | 229996802 | Takama No Hara | Pass |
| 112 | 246393365 | Rei-Tachi Ga Kita Hi | Pass |
| 113 | 221855414 | Otakemaru the Accuser | Needs manual ruling |
| 114 | 259429721 | Champion of the Grand Blue | Pass |
| 115 | 259500899 | Diving Daughters of the Grand Blue | Fixed |
| 116 | 259369909 | Serene Mermaid of the Grand Blue | Needs manual ruling |
| 117 | 259934756 | Jelly Lass of the Grand Blue | Fixed |
| 118 | 259273394 | Jelly Miss of the Grand Blue | Pass |
| 119 | 259417461 | Brilliance of the Grand Blue | Fixed |
| 120 | 259679619 | City Within the Grand Blue | Needs manual ruling |
| 121 | 259177849 | Grand Blue Princess | Fixed |
| 122 | 259578863 | Oracle of the Grand Blue | Fixed |
| 123 | 259093260 | Grand Blue Matriarch | Needs manual ruling |
| 124 | 259937946 | Grand Blue Prince | Pass |
| 125 | 259028576 | Stellaer of the Lightning Runes | Fixed |
| 126 | 211964444 | Priestess of Nephthys | Needs manual ruling |
| 127 | 216532402 | Sacred Feather of Nephthys | Needs manual ruling |
| 128 | 259581666 | Stellaer of the Frozen | Needs manual ruling |
| 129 | 256287781 | Rage of Nephthys | Needs manual ruling |
| 130 | 240299292 | To Proto Ousia | Fixed |
| 131 | 245400676 | To Proto Archegoni | Needs manual ruling |
| 132 | 246524183 | Protogenesis | Needs manual ruling |
| 133 | 234729347 | The Beginning | Fixed |
| 134 | 232706629 | Protogenic Astral Cycle | Needs manual ruling |
| 135 | 244013196 | To Proto Chrono | Needs manual ruling |
| 136 | 246380598 | To Proto Taxis | Needs manual ruling |
| 137 | 259219942 | Stellaer of the Plants | Needs manual ruling |
| 138 | 224225695 | To Proto Ataxia | Fixed |
| 139 | 217332244 | To Proto Psychi | Needs manual ruling |
| 140 | 241543138 | To Proto Eisodos | Fixed |
| 141 | 254065048 | Polemistis Gia Ataxia | Needs manual ruling |
| 142 | 212684822 | Ektelestis Gia Taxis | Needs manual ruling |
| 143 | 259057226 | Stellaer of the Cold | Fixed |
| 144 | 234455260 | Stellaer of the Night | Pass |
| 145 | 226903348 | Stellaer of the Sea | Fixed |
| 146 | 225106953 | Stellaer of the Gems | Fixed |
| 147 | 230998543 | Stellaer of the Breeze | Needs manual ruling |
| 148 | 230132786 | Stellaer of the Volcanos | Pass |
| 149 | 236551669 | Pride of the Stellaers | Pass |
| 150 | 257549955 | A Stellaer Is Reborn | Fixed |
| 151 | 259214334 | Stellaer's Pain | Pass |
| 152 | 259655976 | Stellaer of Lighting | Fixed |
| 153 | 212184534 | Stellaer of the Flames | Pass |
| 154 | 215445495 | Stellaer of the Waters | Pass |
| 155 | 216505735 | Stellaer of the Air | Pass |
| 156 | 231400558 | Stellaer of the Darkness | Pass |
| 157 | 214226989 | Stellaer of Purity | Pass |
| 158 | 219905997 | Stellaer of the Ground | Pass |
| 159 | 239245471 | Birth of Azrynior | Needs manual ruling |
| 160 | 224751741 | Fall of Azrynior | Needs manual ruling |
| 161 | 236239443 | Restoration of Azrynior | Needs manual ruling |
| 162 | 245099829 | Azrynior, the Abundaence of Purity | Needs manual ruling |
| 163 | 223512283 | Dysmandr, the Depraevity of Worlds | Needs manual ruling |
| 164 | 242009896 | Extinction of Dysmandr | Needs manual ruling |
| 165 | 214552846 | Eldora, the Intergalactic Empire | Needs manual ruling |
| 166 | 229786055 | Eldora in Depraevity | Needs manual ruling |
| 167 | 222676270 | Frozen Girl & Blood Moon | Needs manual ruling |
| 168 | 222782750 | Ghost Doll & Midnight Manor | Needs manual ruling |
| 169 | 259290896 | Dominus Sentinel | Needs manual ruling |
| 170 | 210716547 | Clock of Aldrez | Needs manual ruling |
| 171 | 246496923 | Aldrez Grandmaster | Pass |
| 172 | 219047593 | Phantasm Spiral Resurgence | Needs manual ruling |
| 173 | 237917359 | Phantasm Spiral Shrine | Pass |
| 174 | 222875833 | Phantasm Spiral Ensnarement | Pass |
| 175 | 226063408 | Grand Puppet of Wicked Puppeteer | Pass |
| 176 | 259527622 | Knight Puppet of Wicked Puppeteer | Fixed |
| 177 | 233659599 | Minion Puppets of Wicked Puppeteer | Pass |
| 178 | 257464336 | Guardian of Wicked Puppeteer | Pass |
| 179 | 234178973 | The True Wicked Puppeteer, Orchis | Fixed |
| 180 | 236818346 | Wicked Puppeteer, Orchis | Pass |
| 181 | 243306841 | Wicked Puppeteer Tragedy | Pass |
| 182 | 219150610 | Wicked Puppeteery | Pass |
| 183 | 244959812 | Divine Phoenix of Nephthys | Fixed |
| 184 | 234818744 | Primite Dragon Citrine | Pass |
| 185 | 241868535 | Pedicaes Papa | Fixed |
| 186 | 215984744 | Vir Pedicae Mortis - Entity's Happy Servant | Needs manual ruling |
| 187 | 244778917 | Vir Pedicae Mortis - Fearless Hunter | Needs manual ruling |
| 188 | 243144691 | Vir Pedicae Mortis - the Unhallowed Warden | Pass |
| 189 | 233103500 | Vir Pedicae Mortis - True Nightmare | Pass |
| 190 | 236744343 | Entity's Realm - Pedicae Estate | Pass |
| 191 | 211086520 | Recollection: Static, Lead, and Nerve | Pass |
| 192 | 234984156 | Recollection: a Lesson in Iron | Pass |
| 193 | 231872299 | Recollection: the Mine | Pass |
| 194 | 241447408 | Recollection: Kaboom Papa | Needs manual ruling |
| 195 | 229875953 | Teleum Mortis | Pass |
| 196 | 251699681 | Bear Trap | Fixed |
| 197 | 219543855 | Securitake Agent | Needs manual ruling |
| 198 | 226645052 | Harmony Pearlwood & the Nautical Deepwaters | Pass |
| 199 | 228040066 | Melody Merheart & the Nautical Coral Reef | Pass |
| 200 | 214349717 | Emma Oceannus & the Nautical Coastlines | Pass |
| 201 | 259114562 | Bobbie Bluefin & the Nautical Nocturnes | Needs manual ruling |
| 202 | 220749574 | Scarlet Seareef & the Nautical Creatures | Needs manual ruling |
| 203 | 225109525 | Evander Coldwater & the Nautical Abyss | Needs manual ruling |
| 204 | 223158720 | Nautical Backwashing & Oceanic Waves | Needs manual ruling |
| 205 | 238711686 | Melissa Oceanheart & the Nautical Seabed | Pass |
| 206 | 248946297 | Exploring the Nautical Waters | Needs manual ruling |
| 207 | 218905439 | Nautical Adventures & Torrential Seas | Needs manual ruling |
| 208 | 259722826 | Bob | Pass |
| 209 | 259944943 | Bob, but Stronger! | Needs manual ruling |
| 210 | 221047295 | Bookkeeper of Crying Chaos | Pass |
| 211 | 233436485 | Crow of Crying Chaos | Pass |
| 212 | 217118040 | Plague Doctor of Crying Chaos | Pass |
| 213 | 218261525 | Scarecrow of Crying Chaos | Pass |
| 214 | 236017388 | Slug of Crying Chaos | Pass |
| 215 | 240976976 | Witch of Crying Chaos | Fixed |
| 216 | 240511702 | Hunter of Crying Chaos | Fixed |
| 217 | 252513554 | Guardian of Crying Chaos | Pass |
| 218 | 224943273 | Goat of Crying Chaos | Pass |
| 219 | 227610954 | Zenatil, Criminal Bookkeeper of Crying Chaos | Pass |
| 220 | 239725695 | Zebra of Crying Chaos | Pass |
| 221 | 249018041 | Ram of Crying Chaos | Pass |
| 222 | 220305422 | Natir, the Swords Master of Crying Chaos | Fixed |
| 223 | 234296128 | Revelation of Crying Chaos | Pass |
| 224 | 241880822 | Chrono-Saur Raptor | Pass |
| 225 | 233499093 | Dragon of Crying Chaos | Pass |
| 226 | 247779405 | Windborne Swiftsurfer | Fixed |
| 227 | 258241424 | Light Within the Crying Chaos | Pass |
| 228 | 217029078 | Windborne Cloudwing | Fixed |
| 229 | 216294702 | A Throne of Crying Chaos | Pass |
| 230 | 255953418 | A World of Crying Chaos | Pass |
| 231 | 221759221 | Windborne Cartographer | Fixed |
| 232 | 253472430 | A Whisper of Crying Chaos | Pass |
| 233 | 215068354 | Janna, Windborne Goddess of the Temple | Fixed |
| 234 | 257794541 | Maryam, Windborne Caretaker of the Temple | Fixed |
| 235 | 251571153 | Sunken Temple of the Windborne | Pass |
| 236 | 231273040 | Windborne Howling Gale | Pass |
| 237 | 256110263 | Windborne Eye of the Storm | Needs manual ruling |
| 238 | 238064522 | Windborne Galesong Flock | Pass |
| 239 | 233212369 | Windborne Divine Whirlwind | Fixed |
| 240 | 215006791 | Muntith, Windborne Skydragon of the Shining Sun | Pass |
| 241 | 237684285 | Janna, Windborne Goddess of Clement Winds | Pass |
| 242 | 224774049 | Pot of Gambling | Needs manual ruling |
| 243 | 255686110 | Iscylla, Windborne Kraken of Sunken Depths | Pass |
| 244 | 215885404 | Pot of Fortune | Pass |
| 245 | 243194249 | Shining Brigade - Hope Division | Pass |
| 246 | 232038002 | Shining Brigade - Forward Division | Pass |
| 247 | 232100722 | Shining Brigade - Flowering Division | Pass |
| 248 | 230812008 | Shining Brigade - Loving Division | Fixed |
| 249 | 220124524 | Shining Brigade - Heartbeat Division | Pass |
| 250 | 255668557 | Shining Brigade - Joyous Division | Pass |
| 251 | 243420199 | Shining Brigade - Melody Division | Pass |
| 252 | 236616849 | Shining Brigade - Revenge Division | Fixed |
| 253 | 223750159 | Shining Brigade Armada | Fixed |
| 254 | 244986323 | Shining Brigade Origins | Fixed |
| 255 | 232824319 | Shining Brigade - Companion Team | Fixed |
| 256 | 241504188 | Shining Brigade - Absolute Supremacy | Fixed |
| 257 | 238841732 | Let's Go, Shining Brigade! | Pass |
| 258 | 226827770 | The One Called Forth | Fixed |
| 259 | 215142357 | Shining Brigade - Stand Together! | Fixed |
| 260 | 238976759 | We're the Shining Brigade! | Pass |
| 261 | 237692523 | Pixie Bot | Fixed |
| 262 | 249629457 | Shining Brigade - Last Stand | Fixed |
| 263 | 234507067 | Chrono-Saur Brachio | Pass |
| 264 | 235637994 | Chrono-Saur Dactylus | Fixed |
| 265 | 259235389 | Chrono-Saur Tricera | Pass |
| 266 | 255048812 | Chrono-Saur Stegian | Fixed |
| 267 | 236898203 | Chrono-Saur Rex | Needs manual ruling |
| 268 | 251236672 | Chrono-Saur Laplace Plesio | Needs manual ruling |
| 269 | 259226793 | Chrono-Saur Force | Fixed |
| 270 | 213530841 | Chrono-Saur Counter | Fixed |
| 271 | 253928485 | Aqua Whirlpool | Pass |
| 272 | 259366507 | Aquila, Zephorion's Predictor | Pass |
| 273 | 257081514 | Auriga of the Eldoran Empire | Pass |
| 274 | 213990492 | Eridani, Squire of Zephorion Prime | Pass |
| 275 | 244972185 | The Spires of Zephorion Prime | Fixed |
| 276 | 241957394 | Chapter Ii Verse Iv | Needs manual ruling |
| 277 | 212737555 | Aqua Droplet | Pass |
| 278 | 238035167 | Aquamarine Moon Aurelia | Pass |
| 279 | 220150285 | Aquamarine Plate Montipora | Pass |
| 280 | 211682274 | Aquamarine Pisaster Giga | Pass |
| 281 | 251191343 | Aquamarine Asthenosoma | Fixed |
| 282 | 221509060 | Aquamarine Calling | Pass |
| 283 | 259998396 | Treasure of the Cosmic Ocean | Pass |
| 284 | 227035644 | Aqua Fusion | Pass |
| 285 | 255082735 | Aquamarine Bubble Surge | Pass |
| 286 | 250339529 | Aquamarine Planktonites | Pass |
| 287 | 241976572 | Aquamarine Nautilus | Pass |
| 288 | 216258796 | Aquamarine Actinia | Fixed |
| 289 | 249746105 | Aquamarine Physalia | Pass |
| 290 | 225161820 | Aquamarine Glaucus | Pass |
| 291 | 259920959 | Aquamarine Reef Hapalochlaena | Pass |
| 292 | 258260221 | Hiding "c" | Pass |
| 293 | 259174227 | Farad, the Purple Ohmen | Fixed |
| 294 | 259726853 | Volt, the Green Ohmen | Fixed |
| 295 | 259650132 | Ampere, the Yellow Ohmen | Fixed |
| 296 | 259107906 | Siemens, the Blue Ohmen | Fixed |
| 297 | 259881255 | Coulomb, the White Ohmen | Fixed |
| 298 | 259780273 | Carcel, the Dark Ohmen | Needs manual ruling |
| 299 | 259869259 | Ohmen Surge | Needs manual ruling |
| 300 | 259405917 | Siemens, the Ohmechanic Conductor | Needs manual ruling |
| 301 | 259350270 | Farad, the Ohmechanic Capacitor | Needs manual ruling |
| 302 | 259519336 | Volt, the Ohmechanic Chocker | Needs manual ruling |
| 303 | 259841490 | Coulomb, the Ohmechanic Charger | Needs manual ruling |
| 304 | 259479044 | Ampere, the Ohmechanic Intensity | Needs manual ruling |
| 305 | 259033429 | Carcel, the Ohmechanic Light | Needs manual ruling |
| 306 | 259434499 | Ohmen Powerload | Needs manual ruling |
| 307 | 259650969 | Ohmen Beacon | Needs manual ruling |
| 308 | 245452058 | Altergeist Pipesiren | Pass |
| 309 | 211873618 | Altergeist Regissae | Pass |
| 310 | 252552954 | Altergeist Ifritware | Fixed |
| 311 | 259152704 | Dragon Protector of Nature | Pass |
| 312 | 212055290 | Advent of Cosmic Beings | Pass |
| 313 | 259225324 | Transcend the Pendulum | Fixed |
| 314 | 250902476 | Striking Mirror Force | Pass |
| 315 | 228464260 | Rising Elemental | Pass |
| 316 | 253152295 | Yummy Kuriboh | Pass |
| 317 | 256207361 | Sealed Glyphs Dragon | Pass |
| 318 | 236721134 | Devotee of Fire | Needs manual ruling |
| 319 | 224811863 | Shaman of Fire | Fixed |
| 320 | 240104048 | Guardian of Fire | Fixed |
| 321 | 257239133 | Phlogistic Uprising! | Needs manual ruling |
| 322 | 219714894 | Phlogistic Ignition | Pass |
| 323 | 236815197 | Phlogiston's Wake | Fixed |
| 324 | 242094473 | Phlogiston Dragon | Pass |
| 325 | 230303021 | Phlogistic Scorching Dragon Horde | Fixed |
| 326 | 220538776 | Curryboh | Pass |
| 327 | 249805098 | Starry Knight Arc-En-Ciel | Pass |
| 328 | 238241974 | Starry Knight Nebriel | Fixed |
| 329 | 248760718 | Starry Knight Starry Queen | Pass |
| 330 | 221924008 | Chamroshes' Aegis | Needs manual ruling |
| 331 | 212413422 | Gaia, the Iron Clad Knight | Pass |
| 332 | 238256111 | Cursed Dragon of the Knight | Pass |
| 333 | 222476063 | Gaia the Magnificent Knight | Pass |
| 334 | 223770816 | Blazing Gaia the Spiral Knight | Pass |
| 335 | 256469525 | Dynatos, the Challenger | Pass |
| 336 | 259366591 | Arckcestial Crystal Shards | Fixed |
| 337 | 241440521 | Arckcestial Feather | Fixed |
| 338 | 245354354 | Arckcestial Fireball | Fixed |
| 339 | 228860650 | Arckcestial Orb | Fixed |
| 340 | 214511076 | Arckcestial Prism | Pass |
| 341 | 258328859 | Arckcestial Descend | Fixed |
| 342 | 258590942 | Arckcestial Meadow | Fixed |
| 343 | 235051716 | Arckcestial Pillar of Heavens | Pass |
| 344 | 228635967 | Rank-Up-Magic Key of Arck Celestial Force | Pass |
| 345 | 235612490 | Urphiel's Feather Downpour | Needs manual ruling |
| 346 | 239235967 | Arckcestial Burning | Fixed |
| 347 | 219995840 | Light Illusion of Vazagiel | Fixed |
| 348 | 257176166 | Malphiel, Arckcestial of Protection | Pass |
| 349 | 228386117 | Vazagiel, Arckcestial of Secrets | Fixed |
| 350 | 237089049 | Azeriel, Arckcestial of Demise | Fixed |
| 351 | 251710981 | Ophiel, Arckcestial of Wisdom | Fixed |
| 352 | 231089172 | Sarifiel, Arckcestial of Moonlight | Pass |
| 353 | 215105971 | Urphiel, the High Arckcestial | Needs manual ruling |
| 354 | 220856437 | Bauy Magician | Pass |
| 355 | 250047045 | Dreaming Bau | Pass |
| 356 | 219826457 | Ro-Bau | Fixed |
| 357 | 221511784 | Bau | Fixed |
| 358 | 237444604 | Winged Bauy Fenrir | Pass |
| 359 | 256462992 | Starfury Bauy Dragon | Pass |
| 360 | 228169392 | Bael, Demon Incarnate | Fixed |
| 361 | 226950506 | Bauy World | Pass |
| 362 | 254215159 | Bauy Spellcasting | Pass |
| 363 | 225358630 | Rai-Bau | Pass |
| 364 | 223366685 | Bauy Emergency Room! | Pass |
| 365 | 259072745 | Bhodi, the Corrupted Halloween Tree | Fixed |
| 366 | 233957828 | Toddler Pumpkien | Pass |
| 367 | 259471193 | Dreadful Soul Drain | Fixed |
| 368 | 212822164 | Bray, Shell of the Ghoti | Pass |
| 369 | 235352857 | Shekup, Sting of the Ghoti | Pass |
| 370 | 240575550 | Ghoti from a Deeper Depth Than the Deepest Deep | Needs manual ruling |
| 371 | 255283389 | Myutant El-51 | Pass |
| 372 | 244816828 | Myutant Evolution | Pass |
| 373 | 211699737 | Myutant Amalgamate | Needs manual ruling |
| 374 | 259308265 | Pumpqueen the Queen of Ghosts | Needs manual ruling |
| 375 | 239028111 | Pumprince the Prince of Ghosts | Pass |
| 376 | 230749983 | Hallo, the Giver of Tricks | Pass |
| 377 | 250262550 | Ween, Guidance to Treats | Pass |
| 378 | 231331942 | Hallo, the Hollow Trickster | Needs manual ruling |
| 379 | 224800873 | Hallo-Ween! Basket of Treats | Pass |
| 380 | 255977900 | Happy Hallo-Ween! | Pass |
| 381 | 215621622 | A Night of Fright on Hallo-Ween! | Pass |
| 382 | 221672256 | Skewy! Boo Boo | Pass |
| 383 | 258576611 | Skewy! Candee Hex | Fixed |
| 384 | 252496004 | Skewy! Pumpki-Pal | Fixed |
| 385 | 234592047 | Skewy! Twick-Or-Tweat | Pass |
| 386 | 217632789 | Skewy! Pawty Tyme | Fixed |
| 387 | 254375894 | Crewal Cap'n | Fixed |
| 388 | 237269434 | Crewal Crew | Fixed |
| 389 | 215730767 | Crewal Helmsman | Pass |
| 390 | 250792632 | Crewal Sailor | Fixed |
| 391 | 210628767 | Morbydrip the Crewal Whale | Pass |
| 392 | 222654570 | Crewal Booty | Pass |
| 393 | 210366076 | Crewal Meeting | Pass |
| 394 | 217645912 | Crewal Tide | Pass |
| 395 | 219783132 | Crewal Attack | Pass |
| 396 | 252249599 | Crewal Cursed Sea | Pass |
| 397 | 234599395 | Melville the Crewal Vessel | Pass |
| 398 | 227531376 | Ghostrick Bat | Pass |
| 399 | 212052682 | Ghostrick Djinn | Fixed |
| 400 | 257677549 | Ghostrick Slime | Pass |
| 401 | 241540236 | Ghostrick Haunt | Fixed |
| 402 | 235687149 | Ghostrick Camella | Fixed |
| 403 | 228472690 | Ghostrick Cutifer | Fixed |
| 404 | 239335848 | Ghostrick Oni | Needs manual ruling |
| 405 | 259851064 | Ghostrick Pastrygeist | Fixed |
| 406 | 259815138 | Vampire Avenger | Fixed |
| 407 | 259524916 | Vampire Lugat | Pass |
| 408 | 259552732 | Vampire Reptilian | Needs manual ruling |
| 409 | 259479818 | Vampire Traveler | Fixed |
| 410 | 259144144 | Vampire Estrie | Fixed |
| 411 | 224467692 | Scarstech Prologue | Needs manual ruling |
| 412 | 232104829 | Scarstech Crusader | Fixed |
| 413 | 240768497 | Scarstech Dragon | Pass |
| 414 | 248884592 | Scarstech Swarmer | Pass |
| 415 | 233502817 | Scarstech Sniper | Pass |
| 416 | 245837578 | Scarstech Beacon | Pass |
| 417 | 210175845 | Scarstech Principality | Fixed |
| 418 | 253934904 | Scarstech Stagger | Fixed |
| 419 | 239179363 | Scarstech Kaiser | Fixed |
| 420 | 244009988 | Scarstech Invasion | Fixed |
| 421 | 248891593 | Scarstech Circuit | Fixed |
| 422 | 224235021 | Scarstech Deployment | Fixed |
| 423 | 243488958 | Scarstech Blaster | Pass |
| 424 | 249680945 | Gravinity Orbit | Fixed |
| 425 | 254894701 | Nifal, the Scarstech War Machine | Fixed |
| 426 | 235538173 | Gravinity Plasma | Fixed |
| 427 | 242838495 | Ratsach, the Scarstech Cruiser | Fixed |
| 428 | 256172827 | Gravinity Pulse | Pass |
| 429 | 213611313 | Scarstech Crawler | Pass |
| 430 | 248638801 | Chaos Honest | Pass |
| 431 | 215768254 | Gravinity Star | Fixed |
| 432 | 212345347 | Gravinity Lapsix | Fixed |
| 433 | 249454272 | Gravinity Galaxix | Fixed |
| 434 | 212429024 | Gravinity Nebulix | Fixed |
| 435 | 231088629 | Gravinity Spherix | Needs manual ruling |
| 436 | 223505382 | Gravinity Transfer Call | Fixed |
| 437 | 247919552 | Gravinity Gravity Protection | Fixed |
| 438 | 256831125 | Gravinity Axis Matter | Needs manual ruling |
| 439 | 238184015 | Gravinity Sonic Scream | Needs manual ruling |
| 440 | 246900181 | Unbinding the Soul | Fixed |
| 441 | 251331463 | Eclipse Summoning | Pass |
| 442 | 225260657 | Lowkey Lowkey | Pass |
| 443 | 248940511 | Flower Cardian Moonflare | Needs manual ruling |
| 444 | 231523659 | Stardust Comet | Needs manual ruling |
| 445 | 253128790 | Interwire Dimensquid | Pass |
| 446 | 247298564 | Oracle of the Herald | Pass |
| 447 | 234179728 | Galacticarina | Pass |
| 448 | 227335484 | Galacticassiopeia | Pass |
| 449 | 229021849 | Galacticanes Venatici | Pass |
| 450 | 220148485 | Galacticanes Auriga | Pass |
| 451 | 226902471 | Galataxian Battle Tactics | Pass |
| 452 | 239127930 | Galataxian Battle Formation | Fixed |
| 453 | 210696007 | Galataxian Battle Preparation | Fixed |
| 454 | 258934904 | Galactican Battle Station | Needs manual ruling |
| 455 | 250829750 | Galactican Battle Grounds | Pass |
| 456 | 245395343 | Fusion Intergalactica | Fixed |
| 457 | 259307285 | Attack on Gravity | Needs manual ruling |
| 458 | 256005703 | Galactican Jet Dasher | Fixed |
| 459 | 212837324 | Galactican Jet Drifter | Fixed |
| 460 | 259482393 | Carina, Forgotten of Eldora | Pass |
| 461 | 250917339 | Cassiopeia, Forgotten of Eldora | Pass |
| 462 | 259230000 | Aeloria in Depraevity | Fixed |
| 463 | 253520299 | Galactican Machine - No. G2-X38 | Pass |
| 464 | 236473882 | Intergalactican Machine - No. R2-D30 | Pass |
| 465 | 212377618 | Cassiopeia of the Eldoran System | Pass |
| 466 | 219002796 | Intergalacticanes Majoris | Fixed |
| 467 | 221827483 | To Protogenis Intergalataxiakos | Fixed |
| 468 | 259924331 | Pray for Your Life! | Pass |
| 469 | 259607933 | Gladiator Beast Sabearius | Pass |
| 470 | 259395418 | Gladiator Beast Attrocitar | Pass |
| 471 | 259363148 | Gladiator Beast Satyrius | Pass |
| 472 | 259766646 | Night Night Nemleria | Pass |
| 473 | 259605536 | Pyjama Party of Happy Nemleria | Fixed |
| 474 | 259883971 | Nemleria Big Eepy | Fixed |
| 475 | 259017109 | Nemleria's Nightmare | Pass |
| 476 | 259090287 | Nemleria's Dream Bedroom | Pass |
| 477 | 259392825 | Nemleria Dream Creator Pyjama | Pass |
| 478 | 259472680 | Nemleria Dream Devourer - Soleil | Fixed |
| 479 | 259898110 | Nemleria Dream Creator - Veilleuse | Fixed |
| 480 | 259934043 | Grayling, the Grayscale Imp | Pass |
| 481 | 259341133 | Graysentry, the Guard of Grayscale | Fixed |
| 482 | 259937399 | Grayrover, the Wandering Grayscale | Pass |
| 483 | 259724129 | Graylock, the Sorcerer of Grayscale | Fixed |
| 484 | 259688514 | Grayhex, the Chanter of Grayscale | Pass |
| 485 | 259632020 | Grayseer, the Grayscale Spy | Pass |
| 486 | 259624110 | Grayterror, the Grayscale Beast | Pass |
| 487 | 259245496 | Graydimm, the Grayscale Shadow | Pass |
| 488 | 259626409 | Grayshade, the Phantom of Grayscale | Pass |
| 489 | 259229055 | Graydeux, the Eternal Grayscale Entity | Fixed |
| 490 | 259923860 | Grayscale Awakening: Revelation | Fixed |
| 491 | 259203522 | Grayscale Awakening: Eclipse | Pass |
| 492 | 259269688 | Grayscale Awakening: Nullbind | Fixed |
| 493 | 259275822 | The Misstakes of the A.I.P Experience | Fixed |
| 494 | 259609997 | A.I.P Ex Larva | Fixed |
| 495 | 259664027 | A.I.P Ex Shrieker | Fixed |
| 496 | 259137697 | A.I.P Ex Claw | Fixed |
| 497 | 259522807 | A.I.P Ex Maw | Fixed |
| 498 | 259121126 | A.I.P Ex Predator | Fixed |
| 499 | 259943152 | A.I.P Lab | Fixed |
| 500 | 259883029 | Failures of the A.I.P | Fixed |
| 501 | 259630851 | A.I.P Ex Assimilation | Fixed |
| 502 | 259499577 | A.I.P Ex Hive Mind | Fixed |
| 503 | 259465391 | Caller of the A.I.P Ex | Fixed |
| 504 | 259097228 | Zero Mother of the A.I.P Ex | Fixed |
| 505 | 259466138 | Red-Eyes Gearfried the Iron Knight | Fixed |
| 506 | 259992800 | Red-Eyes Moon Dragon | Fixed |
| 507 | 259184310 | Red-Eyes Meteor Metal Dragon | Fixed |
| 508 | 259562343 | Red-Eyes Roar | Pass |
| 509 | 259114673 | Red-Eyes Turbo Dragon | Pass |
| 510 | 259628203 | Red-Eyes Booster Dragon | Fixed |
| 511 | 259755133 | Rush at the Gnome | Pass |
| 512 | 259825991 | Calcu Leet | Pass |
| 513 | 259138193 | Digita Leet | Pass |
| 514 | 259940722 | Virtua Leet | Fixed |
| 515 | 259688676 | Herald of White Light | Fixed |
| 516 | 259352030 | Thunder Dragon Behemoth | Pass |
| 517 | 259889864 | Aurelion Divine Illumination | Pass |
| 518 | 259373017 | Lance Luminar Justiciar | Pass |
| 519 | 259304399 | Scarstech Draco | Pass |
| 520 | 259531370 | Scarstech Wyvern | Fixed |
| 521 | 259464700 | Scarstech Invader | Pass |
| 522 | 259459462 | Ganan, the Scarstech City | Pass |
| 523 | 259086544 | Qerets, the Scarstech Mother Ship | Fixed |
| 524 | 259315827 | Adamantios, the Dark Armor | Pass |
| 525 | 259023461 | Disciple of Fire | Fixed |
| 526 | 259360287 | Sorceress of Fire | Pass |
| 527 | 259366281 | Phlogiston's Roar | Pass |
| 528 | 259794136 | Harpie Cyber Dancer | Fixed |
| 529 | 259269774 | Harpie Lady Sisters - Phoenix Formation | Fixed |
| 530 | 259072169 | Mirage Formation Dragon | Fixed |
| 531 | 259247807 | Glitchling Bitron | Fixed |
| 532 | 259156549 | Glitchling Protron | Pass |
| 533 | 259678739 | Glitchling Witch | Pass |
| 534 | 259961648 | Glitchling Data-Transfert | Pass |
| 535 | 259927462 | Glitchling Octron | Pass |
| 536 | 259494236 | Glitchling Digitron | Pass |
| 537 | 259072906 | Glitchling Mage | Pass |
| 538 | 259873115 | Glitchling Leotron | Pass |
| 539 | 259546637 | Glitchling Corruption | Fixed |
| 540 | 259253032 | Glitchling Hexatron | Fixed |
| 541 | 259485374 | Heart of the Cards | Fixed |
| 542 | 259576196 | The Orcustograph | Fixed |
| 543 | 259646610 | Galatea-2, the Orcust Divider | Fixed |
| 544 | 259614449 | Charmelia Kiana | Pass |
| 545 | 259790247 | Charmelia Hanabi | Pass |
| 546 | 259288669 | Charmelia Elysia | Fixed |
| 547 | 259568843 | Charmelia Robin | Fixed |
| 548 | 259241946 | Charmelia Pray | Pass |
| 549 | 259758604 | Charmelia Deal | Pass |
| 550 | 259226799 | Charmelia Beast | Pass |
| 551 | 259402105 | Magical Girl Explosion | Fixed |
| 552 | 259489283 | Charmelia Fairy Kyubey | Fixed |
| 553 | 259753109 | Charmelia Fairy Morningstar | Fixed |
| 554 | 259599798 | Wyvernal Luna | Fixed |
| 555 | 259783008 | Wyvernal Caudina | Fixed |
| 556 | 259431066 | Wyvernal Myops | Fixed |
| 557 | 259533644 | Wyvernal Crenata | Pass |
| 558 | 259348317 | Wyvernal Sphinx | Pass |
| 559 | 259763531 | Wyvernal Lymantria | Pass |
| 560 | 259179054 | Wyvernal Megalopyge | Fixed |
| 561 | 259160760 | Wyvernal Sanctuary | Pass |
| 562 | 259073666 | Wyvernal Gathering | Fixed |
| 563 | 259652372 | Eclipse Observer Aaliyah | Pass |
| 564 | 259926839 | Eclipse Observer Riley | Pass |
| 565 | 259069729 | Eclipse Observer Nora | Pass |
| 566 | 259487387 | Eclipse Observer Ella | Pass |
| 567 | 259058125 | Eclipse Observer Maya | Pass |
| 568 | 259721372 | Eclipse Observatory | Fixed |
| 569 | 259680842 | Grimoire of Eclipse | Pass |
| 570 | 259614765 | Encyclopedia of Eclipse | Pass |
| 571 | 259273851 | Manual of Eclipse | Fixed |
| 572 | 259264449 | Spellbook of Eclipse | Pass |
| 573 | 259303191 | Tome of Eclipse | Fixed |
| 574 | 259193076 | Eclipse Observer Baleygr | Fixed |
| 575 | 259126370 | Eclipse Observer Chandra | Fixed |
| 576 | 259612312 | Eclipse Observer Seara | Fixed |
| 577 | 259223502 | Ether Mademoiselle | Pass |

## Audit evidence

- Primary Lane A: [`tmp/ultimate_audit_lane_a.md`](../tmp/ultimate_audit_lane_a.md)
- Independent review of Lane A: [`tmp/ultimate_audit_cross_b_reviews_a.md`](../tmp/ultimate_audit_cross_b_reviews_a.md)
- Primary Lane B: [`tmp/ultimate_audit_lane_b.md`](../tmp/ultimate_audit_lane_b.md)
- Independent review of Lane B: [`tmp/ultimate_audit_cross_a_reviews_b.md`](../tmp/ultimate_audit_cross_a_reviews_b.md)
- Primary Lane C: [`tmp/ultimate_audit_lane_c.md`](../tmp/ultimate_audit_lane_c.md)
- Independent review of Lane C: [`tmp/ultimate_audit_cross_b_reviews_c.md`](../tmp/ultimate_audit_cross_b_reviews_c.md)
- Central message audit: [`tmp/ultimate_audit_message_cross_c.md`](../tmp/ultimate_audit_message_cross_c.md)

Across the final public folder, the strict initializer harness observed **1,562 created effects, 3,479 callbacks, and 1,710 direct registrations**. The registration count is lower than the printed-effect/procedure total because clones and procedure helpers register internally.

## Exact Lua delta

Compared with the pre-audit SHA-256 baseline, **253** standalone Lua files changed: 252 existing files plus new normal-monster script `c259275822.lua`; no baseline script was removed. The exact filename set below applies identically to the public folder, installed Omega folder, and `dist` mirror.

<details>
<summary>253 exact c&lt;ID&gt;.lua filenames</summary>

```text
c210175845.lua
c210506870.lua
c210696007.lua
c210716547.lua
c211873618.lua
c212052682.lua
c212345347.lua
c212413422.lua
c212429024.lua
c212837324.lua
c213530841.lua
c213849997.lua
c214552846.lua
c215006791.lua
c215068354.lua
c215142357.lua
c215768254.lua
c216258796.lua
c216532402.lua
c216620496.lua
c217029078.lua
c217174535.lua
c217332244.lua
c217632789.lua
c218142234.lua
c219002796.lua
c219047593.lua
c219826457.lua
c219995840.lua
c220124524.lua
c220305422.lua
c220916791.lua
c221511784.lua
c221759221.lua
c221827483.lua
c221924008.lua
c222476063.lua
c223505382.lua
c223512283.lua
c223750159.lua
c223770816.lua
c224225695.lua
c224235021.lua
c224751741.lua
c224811863.lua
c225091736.lua
c225106953.lua
c226827770.lua
c226903348.lua
c228169392.lua
c228386117.lua
c228472690.lua
c228860650.lua
c229499914.lua
c229786055.lua
c230303021.lua
c230812008.lua
c231088629.lua
c231129918.lua
c231273040.lua
c231331942.lua
c231523659.lua
c232038002.lua
c232100722.lua
c232104829.lua
c232824319.lua
c233212369.lua
c234178973.lua
c234729347.lua
c235538173.lua
c235612490.lua
c235637994.lua
c235687149.lua
c236616849.lua
c236721134.lua
c236815197.lua
c236898203.lua
c237089049.lua
c237269434.lua
c237684285.lua
c237692523.lua
c238064522.lua
c238184015.lua
c238241974.lua
c238256111.lua
c238841732.lua
c239127930.lua
c239179363.lua
c239235967.lua
c239335848.lua
c240104048.lua
c240299292.lua
c240511702.lua
c240976976.lua
c241056746.lua
c241440521.lua
c241504188.lua
c241540236.lua
c241543138.lua
c241868535.lua
c241880822.lua
c241957394.lua
c242009896.lua
c242838495.lua
c243194249.lua
c243420199.lua
c244009988.lua
c244408495.lua
c244921711.lua
c244959812.lua
c244972185.lua
c244986323.lua
c245354354.lua
c245395343.lua
c245400676.lua
c245970073.lua
c246380598.lua
c246900181.lua
c247499445.lua
c247779405.lua
c247789143.lua
c247919552.lua
c248453205.lua
c248891593.lua
c248940511.lua
c249454272.lua
c249629457.lua
c249680945.lua
c250792632.lua
c251191343.lua
c251236672.lua
c251571153.lua
c251699681.lua
c251710981.lua
c252496004.lua
c252552954.lua
c253472430.lua
c253552927.lua
c253934904.lua
c254375894.lua
c254894701.lua
c255048812.lua
c255277197.lua
c255668557.lua
c255686110.lua
c255953418.lua
c256005703.lua
c256110263.lua
c256831125.lua
c257239133.lua
c257549955.lua
c257794541.lua
c258328859.lua
c258576611.lua
c258590942.lua
c259023461.lua
c259028576.lua
c259033429.lua
c259057226.lua
c259072169.lua
c259072745.lua
c259073666.lua
c259086544.lua
c259097228.lua
c259107906.lua
c259121126.lua
c259126370.lua
c259137697.lua
c259144144.lua
c259174227.lua
c259177849.lua
c259179054.lua
c259184310.lua
c259193076.lua
c259219942.lua
c259223502.lua
c259225324.lua
c259226793.lua
c259229055.lua
c259230000.lua
c259247807.lua
c259253032.lua
c259265448.lua
c259269688.lua
c259269774.lua
c259273851.lua
c259275822.lua
c259288669.lua
c259303191.lua
c259341133.lua
c259366591.lua
c259394179.lua
c259402105.lua
c259405917.lua
c259417461.lua
c259431066.lua
c259434499.lua
c259465391.lua
c259466138.lua
c259471193.lua
c259472680.lua
c259475154.lua
c259479818.lua
c259485374.lua
c259489283.lua
c259499577.lua
c259500899.lua
c259519336.lua
c259522807.lua
c259527622.lua
c259531370.lua
c259546637.lua
c259568843.lua
c259576196.lua
c259578863.lua
c259586445.lua
c259599798.lua
c259605536.lua
c259609997.lua
c259612312.lua
c259614765.lua
c259628203.lua
c259630851.lua
c259646610.lua
c259650132.lua
c259650969.lua
c259655976.lua
c259664027.lua
c259688676.lua
c259718504.lua
c259721372.lua
c259724129.lua
c259726853.lua
c259753109.lua
c259780273.lua
c259783008.lua
c259794136.lua
c259796760.lua
c259815138.lua
c259841490.lua
c259851064.lua
c259869259.lua
c259881255.lua
c259883029.lua
c259883971.lua
c259898110.lua
c259911246.lua
c259923860.lua
c259934756.lua
c259940722.lua
c259943152.lua
c259944943.lua
c259992800.lua
```

</details>

Other task files synchronized or generated:

- `scripts/sync_omega_ccg_db.py`
- `public/CCG Downloads/CCG_Database/CCG_v1.db`
- `public/CCG Downloads/CCG_Database/CCG_v1_id_map.json`
- `public/CCG Downloads/CCG_Database/CCG_Database.zip`
- `public/CCG Downloads/CCG_Scripts/CCG_Scripts.zip`
- `scripts/output/CCG_v1_id_map.json`
- `C:/Program Files (x86)/YGO Omega/YGO Omega_Data/Files/Databases/CCG_v1.db`
- The same 253 Lua filenames under `C:/Program Files (x86)/YGO Omega/YGO Omega_Data/Files/Scripts/`
- Matching DB, map, ZIP, and 253 Lua mirrors under `dist/CCG Downloads/`
- Vite build outputs `dist/index.html`, `dist/404.html`, `dist/assets/index-CZTGlE5u.css`, `dist/assets/banlist--mm8nsPh.js`, and `dist/assets/index-C15sgi9k.js`
- This report and the handoff update in `docs/session-handoff-card-scripting.md`
- Verification bytecode `scripts/__pycache__/sync_omega_ccg_db.cpython-310.pyc`

Audit evidence and reproducibility files created under `tmp/`:

```text
ultimate_ast_audit.cjs
ultimate_ast_findings.json
ultimate_audit_baseline_artifacts.json
ultimate_audit_baseline_hashes.json
ultimate_audit_cross_a_reviews_b.md
ultimate_audit_cross_b_reviews_a.md
ultimate_audit_cross_b_reviews_c.md
ultimate_audit_lane_a.md
ultimate_audit_lane_b.md
ultimate_audit_lane_c.md
ultimate_audit_manifest.json
ultimate_audit_message_cross_c.md
ultimate_audit_static_candidates.json
ultimate_count_limit_candidates.json
ultimate_cross_b_173_280.md
ultimate_cross_b_281_390.md
ultimate_db_message_audit.py
ultimate_db_message_findings.json
ultimate_full_smoke.lua
ultimate_message_test.db
ultimate_message_test_map.json
ultimate_target_flag_candidates.json
ultimate_unknown_card_literals.json
```

## Official Omega references used

Exact reference files found in the supplied source-of-truth corpus (**168 unique**):

<details>
<summary>Reference file list</summary>

```text
c10000020.lua
c10000040.lua
c10004783.lua
c10019086.lua
c100200290.lua
c100201001.lua
c100211003.lua
c100211051.lua
c100211053.lua
c100211097.lua
c100211099.lua
c100212001.lua
c100212002.lua
c100212004.lua
c100213003.lua
c100233201.lua
c100235002.lua
c100239201.lua
c100240201.lua
c100241001.lua
c100245009.lua
c100245019.lua
c100245021.lua
c100245037.lua
c100245038.lua
c100245040.lua
c100250201.lua
c100250208.lua
c100256003.lua
c100256005.lua
c100256007.lua
c100256017.lua
c100259006.lua
c100259009.lua
c100261001.lua
c100261026.lua
c101203003.lua
c101203005.lua
c101203013.lua
c101203021.lua
c101203024.lua
c101203048.lua
c101203059.lua
c101204024.lua
c101204071.lua
c101204077.lua
c101204079.lua
c101208206.lua
c101208208.lua
c101301087.lua
c101301096.lua
c101302209.lua
c101303208.lua
c101304084.lua
c101304087.lua
c101304094.lua
c101306071.lua
c10131855.lua
c10136446.lua
c102380.lua
c10321588.lua
c10443957.lua
c1050355.lua
c10632284.lua
c11082056.lua
c11248645.lua
c11264180.lua
c11335209.lua
c1187243.lua
c11881272.lua
c120145032.lua
c12081875.lua
c12421694.lua
c12760674.lua
c12930501.lua
c12977245.lua
c13243124.lua
c14001430.lua
c14088859.lua
c14258627.lua
c14799437.lua
c16003979.lua
c16024176.lua
c16110708.lua
c16684346.lua
c16769305.lua
c16946849.lua
c17132130.lua
c18988396.lua
c19337371.lua
c197042.lua
c1980574.lua
c2009101.lua
c20349913.lua
c2106266.lua
c22804644.lua
c23153227.lua
c23440231.lua
c23459650.lua
c23530726.lua
c24545464.lua
c24838456.lua
c25072579.lua
c2530830.lua
c25397880.lua
c25811989.lua
c25853045.lua
c26746975.lua
c27346636.lua
c2819435.lua
c29047353.lua
c29357956.lua
c295517.lua
c30086349.lua
c31111109.lua
c31603289.lua
c32696942.lua
c34124316.lua
c34302287.lua
c34334692.lua
c35884610.lua
c38356857.lua
c40380686.lua
c41510920.lua
c4179255.lua
c42081767.lua
c4290468.lua
c43331750.lua
c48486809.lua
c48658295.lua
c4891376.lua
c50078320.lua
c50237654.lua
c50669347.lua
c50933533.lua
c51782995.lua
c52904476.lua
c53199020.lua
c53315891.lua
c53589300.lua
c58019984.lua
c62318994.lua
c64767757.lua
c67098897.lua
c67688478.lua
c67865534.lua
c68663427.lua
c70369116.lua
c71545247.lua
c72309040.lua
c72930878.lua
c77297908.lua
c79387392.lua
c80453041.lua
c81696879.lua
c82370493.lua
c82489470.lua
c8454126.lua
c86321248.lua
c87769556.lua
c88176533.lua
c90307777.lua
c93192592.lua
c97462632.lua
c97769122.lua
c98999181.lua
constant.lua
procedure.lua
```

</details>

Notable exact-pattern families included official negate/effect-negate, copied activation, delayed group, Fusion/Xyz/Synchro/Link procedure, top-of-Deck, Trap Monster, chain rewrite, post-resolution, mandatory trigger, reverse ATK update, and Necrovalley-safe access patterns. Official set-code references also anchored Altergeist `0x103`, Flower Cardian `0xE6`, Gaia the Fierce Knight `0xBD`, Galaxy `0x7B`, Gladiator Beast `0x1019`, Harpie `0x64`, Stardust `0xA3`, and Thunder Dragon `0x11C`.

## Verification commands and results

| Command or check | Result |
|---|---|
| Active-card mapping and script presence (`cards.json` passcodes) | PASS - 577/577; 0 missing |
| Per-card `luac -p` over the 577 active scripts | PASS - 577/577 |
| Full-folder `luac -p` over public scripts | PASS - 592/592 |
| Full-folder `luac -p` over installed Omega scripts | PASS - 592/592 |
| Full-folder `luac -p` over `dist` scripts | PASS - 592/592 |
| Strict `initial_effect` smoke, public | PASS - 592/592; 1562/3479/1710 |
| Strict `initial_effect` smoke, installed Omega | PASS - 592/592; 1562/3479/1710 |
| Strict `initial_effect` smoke, `dist` | PASS - 592/592; 1562/3479/1710 |
| Forbidden `require` / `dofile` / `loadfile` scan | PASS - 0 |
| Unsupported Card/Duel/Effect method comparison with official corpus | PASS - 0 custom-only methods/calls |
| AST cost/target/operation heuristic | PASS after review - 19 hits all classified as procedures/replacements/copied-target lifecycle |
| `python -m py_compile scripts/sync_omega_ccg_db.py` | PASS |
| Public full DB sync (`--full-sync --no-backup`) | PASS - 577 updated; 587 data/text rows |
| Current referenced `aux.Stringid` DB audit | PASS - 1184 slots; 0 missing/blank |
| Placeholder and message fallback audit | PASS - 0 placeholders; current referenced fallback use 0 |
| Official/custom set-code audit | PASS - 92 family-card rows checked; 0 mismatches |
| Public to installed content-mismatch sync | PASS - 253 Lua files and DB copied |
| `CCG_Scripts.zip` payload audit | PASS - 592 entries; 0 missing/extra/hash mismatches |
| `CCG_Database.zip` payload audit | PASS - 1 DB entry; payload hash match |
| `npm run build` | PASS - TypeScript and Vite build complete (bundle-size warning only) |
| `npm run verify:public-cards` | PASS |
| Public/installed/dist and ZIP hash parity | PASS |
| `git diff --check` | PASS - exit 0; line-ending warnings only |
| Initial validated-path archive deletion command | BLOCKED before execution by filesystem safety policy; no file changed |
| Non-deleting `Compress-Archive -Force` replacement | PASS |

## Final artifact hashes

| Artifact | SHA-256 |
|---|---|
| Public/dist script ZIP | `0bfe6131bf48618d173e1c118e34c7648289d80f795923ee91c473bfbc478b95` |
| Public/installed/dist DB | `73b864429c3925672ffef433068e1008daa0a57a288f9fbc6b988394d73f0c34` |
| Public/dist DB ZIP | `76875485c69c540e53b472893757a60445dce771b38568fa9da6ffd2de303141` |
| Public/scripts-output/dist ID map | `68920411f680ead4cf47d84a3a9ed64c412eb9ed6c85dd7a89ee8346252f2cf3` |
| Source/public/dist cards JSON | `8ffd2b5ce9312697d815fd1b151c1d91fb12b73a348937bfae51573426a8c2f6` |

## Remaining in-engine risks

The card-by-card ruling questions and duel-test checklists are expanded in [`lua-manual-review-guide-2026-07-20.md`](lua-manual-review-guide-2026-07-20.md).

The 123 `Needs manual ruling` rows are not known syntax/load failures. They are deliberately conservative flags where static code and official analogs cannot establish the intended ruling or Omega UI behavior. Highest-priority duel scenarios:

- Custom face-down Extra Deck and Frute summon UI; opponent-Deck pseudo-Tributes; Link-as-Level/material-weight mechanics.
- Ursarctic/custom Synchro and Ghoti immediate/mixed Synchro procedures; Flower Cardian one-card-as-three-material handling; Stardust Comet Deck Tribute and immediate Synchro.
- Copied activation/effect ownership, chain-operation rewriting, delayed groups, and cards that append or replace a resolving effect.
- Custom Fusion/Ritual/Xyz material selection from Deck, GY, banishment, S/T zones, or opponent-controlled cards.
- Custom summon replacements, Trap Monster conversion, temporary banishment returns, Damage Step OR-event coalescing, and hand-activation permission scope.
- Source-text ambiguities/truncations or metadata conflicts, including Scarstech Prologue and To Proto Chrono.
- UI/localization presentation of the 1,184 populated message slots.

Every active card is therefore present, standalone, compilable, initializer-loadable, database-mapped, message-populated, and synchronized. Full "working as intended" certification for the 123 flagged cards requires the listed scripted Omega duel scenarios and authoritative rulings where the source wording is ambiguous.

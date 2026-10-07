# Public Link-card test boundary

This is a test infrastructure finding, not an Omega production bug. The original public WASM wrapper supplies marker zero for a Link fixture declared with marker 128. The isolated adapter restores marker 128 and its linked-zone mask. Node modules, Omega files and database metadata are unchanged by the adapter.

All 711 scripts were screened: 22 directly call arrow-dependent APIs; 45 roster cards have Link metadata. Helpers and supporting Link cards can create additional indirect dependencies, so this list is a starting point, not complete behavioral coverage.

Release of the Pyre has an adapted actual activation/count regression. Lord of the Pyre has canonical full-script ATK tests: linked Pyro, wrong race, unlinked position, and opponent field. Raw wrapper and no-stat controls fail the positive; broad-race control fails only the wrong-race case. Other protections/triggers, proper Link procedures and native Omega remain open.

| Card | Arrow-dependent lines | Status |
|---|---|---|
| 227610954 Zenatil, Criminal Bookkeeper of Crying Chaos | 60, 68 | OPEN_ARROW_EFFECT_TEST |
| 237692523 Pixie Bot | 63 | OPEN_ARROW_EFFECT_TEST |
| 244168521 Heavy-Armoured Ballista Bahariasaurus | 43 | OPEN_ARROW_EFFECT_TEST |
| 248638801 Chaos Honest | 48 | OPEN_ARROW_EFFECT_TEST |
| 259033429 Carcel, the Ohmechanic Light | 88, 93 | OPEN_ARROW_EFFECT_TEST |
| 259107906 Siemens, the Blue Ohmen | 33, 37, 43, 61, 74, 77, 92, 93, 104 | OPEN_ARROW_EFFECT_TEST |
| 259174227 Farad, the Purple Ohmen | 33, 37, 43, 61, 74, 77, 92, 93, 104 | OPEN_ARROW_EFFECT_TEST |
| 259245496 Graydimm the Grayscale Shadow | 83, 96, 106 | OPEN_ARROW_EFFECT_TEST |
| 259350270 Farad, the Ohmechanic Capacitor | 111 | OPEN_ARROW_EFFECT_TEST |
| 259405917 Siemens, the Ohmechanic Conductor | 89, 92, 142, 146, 169, 173 | OPEN_ARROW_EFFECT_TEST |
| 259479044 Ampere, the Ohmechanic Intensity | 92, 96, 107 | OPEN_ARROW_EFFECT_TEST |
| 259542408 Lord of the Pyre | 15, 19, 20 | FOCUSED_ADAPTED_TEST_EXISTS |
| 259578863 Oracle of the Grand Blue | 80, 98 | OPEN_ARROW_EFFECT_TEST |
| 259624110 Grayterror the Grayscale Beast | 61, 72 | OPEN_ARROW_EFFECT_TEST |
| 259632020 Grayseer the Grayscale Spy | 51 | OPEN_ARROW_EFFECT_TEST |
| 259650132 Ampere, the Yellow Ohmen | 43, 47, 53, 70, 83, 86, 103, 104, 118 | OPEN_ARROW_EFFECT_TEST |
| 259650969 Ohmen Beacon | 91, 131 | OPEN_ARROW_EFFECT_TEST |
| 259726853 Volt, the Green Ohmen | 33, 37, 43, 61, 74, 77, 92, 93, 104 | OPEN_ARROW_EFFECT_TEST |
| 259869259 Ohmen Surge | 37, 51, 66, 70, 94, 98 | OPEN_ARROW_EFFECT_TEST |
| 259881255 Coulomb, the White Ohmen | 49, 66, 79, 82, 97, 98, 109 | OPEN_ARROW_EFFECT_TEST |
| 259883230 Release of the Pyre | 15 | FOCUSED_ADAPTED_TEST_EXISTS |
| 284639726 Terrarumian Venus Flytrap | 45, 76 | OPEN_ARROW_EFFECT_TEST |

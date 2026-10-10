# Current specification and audit freshness

Read-only reconciliation. Historical test data is preserved. Line breaks and literal escaped line breaks are treated as text separators. Missing public DB rows are reported separately from comparisons of existing metadata. No card is certified by this comparison.

```json
{
  "pinned_cards": 711,
  "current_cards": 711,
  "new_passcodes": [],
  "missing_current": 0,
  "changed_printed_effects": 12,
  "changed_specifications": 25,
  "database_text_mismatches": {
    "candidate": 12,
    "public": 91,
    "installed": 0
  },
  "database_metadata_mismatches": {
    "candidate": 14,
    "installed": 0
  },
  "database_missing_rows": {
    "candidate": 0,
    "public": 91,
    "installed": 0
  },
  "database_text_formatting_only": {
    "candidate": 12,
    "public": 0,
    "installed": 12
  },
  "source_install_mismatches": 0,
  "syntax_stale": 0,
  "load_stale": 0,
  "current_spec_initialization_rechecks": {
    "total": 77,
    "passed": 51,
    "compatibility_failures": 26
  }
}
```

## Changed printed effects

| Card | Changes from pinned effect text |
|---|---|
| 213611313 Scarstech Crawler | (added) → use this effect of "Scarstech Crawler" once per chain. You can only |
| 217713649 Onibi | (added) → You can only use this effect of "Onibi" once per turn. |
| 220305422 Natir, the Swords Master of Crying Chaos | If → (removed) |
| 221672256 Skewy! Boo-Boo | return this card to → negate; hand, and if you do, negate that → (removed) |
| 227035644 Aqua Fusion | listed on it its materials → (removed) |
| 237684285 Janna, Windborne Goddess of Clement Winds | effects → effects, except your "Windborne" cards, |
| 255686110 Iscylla, Windborne Kraken of Sunken Depths | card → card(s); (added) → for each card added |
| 259073666 Wyvernal Gathering | (added) → "Wyvernal" or |
| 259152704 Dragon Protector of Nature | NATURE → Plant, Insect or Beast; (added) → monster; NATURE → Plant, Insect or Beast; NATURE → Plant, Insect or Beast |
| 259160760 Wyvernal Sanctuary | (added) → "Wyvernal" or; an → a "Wyvernal" or; (added) → "Wyvernal" or |
| 259348317 Wyvernal Sphinx | an → a "Wyvernal" or |
| 259763531 Wyvernal Lymantria | (added) → "Wyvernal" or; (added) → "Wyvernal" or; also → also, for the rest of this turn,; non-Insect → (removed); Deck for the rest of the turn. → Deck, except "Wyvernal" or Insect monsters.; (added) → "Wyvernal" or |

## Differences requiring review

| Card | Text mismatches | Metadata differs from public | Evidence stale | Installed script differs |
|---|---|---|---|---|
| 213611313 Scarstech Crawler | candidate | — | — | — |
| 217713649 Onibi | candidate | — | — | — |
| 220305422 Natir, the Swords Master of Crying Chaos | candidate | — | — | — |
| 221672256 Skewy! Boo-Boo | candidate | — | — | — |
| 227035644 Aqua Fusion | candidate | — | — | — |
| 237684285 Janna, Windborne Goddess of Clement Winds | candidate | — | — | — |
| 238272434 Terror Skull from Underroot | public | — | — | — |
| 238272435 Blossom Skull from Underroot | public | — | — | — |
| 238272436 Nether Skull from Underroot | public | — | — | — |
| 238272437 Over Skull from Underroot | public | — | — | — |
| 238272438 Terror Blossom from Underroot | public | — | — | — |
| 238272439 Terror Blossom from Overroot | public | — | — | — |
| 238272440 Terror Blossom from Afterroot | public | — | — | — |
| 238273768 Symphonic Warrior Speeaker | public | — | — | — |
| 238273769 Symphonic Warrior DDJ | public | — | — | — |
| 238273770 Symphonic Warrior Disccs | public | — | — | — |
| 238273771 Symphonic Warrior Mettronomo | public | — | — | — |
| 238273772 Symphonic Warrior Mega Staar | public | — | — | — |
| 238274857 Vylon Chevron | public | — | — | — |
| 238274858 Vylon Glome | public | — | — | — |
| 238274859 Vylon Volt | public | — | — | — |
| 238274860 Vylon Torus | public | — | — | — |
| 238274861 Vylon's Aid | public | — | — | — |
| 238274862 Vylon Observatory | public | — | — | — |
| 238274863 Vylon Eta | public | — | — | — |
| 238276248 Scion of Nephthys | public | — | — | — |
| 238276249 Apostle of Nephthys | public | — | — | — |
| 238276250 Incarnation of Nephthys | public | — | — | — |
| 238276251 Brazier of Nephthys | public | — | — | — |
| 238276252 Prayer Of Nephthys | public | — | — | — |
| 238276572 Sylvan Flamushroomo | public | — | — | — |
| 238276573 Sylvan Goleaf | public | — | — | — |
| 238276574 Sylvan Flamioak | public | — | — | — |
| 238276575 Sylvan Greetings | public | — | — | — |
| 238276576 Sylvan Intervention | public | — | — | — |
| 238276577 Sylvan Blast | public | — | — | — |
| 238276578 Sylvan Duchessprout | public | — | — | — |
| 238276579 Gink, the Sylvan High Champion | public | — | — | — |
| 238276580 Azale, the Sylvan High Sovereign | public | — | — | — |
| 239935093 Heart of the Hydra | public | — | — | — |
| 239935094 Winged Snake of the Swamp | public | — | — | — |
| 239935095 Fierce Snake of the Swamp | public | — | — | — |
| 239935096 Sparkling Snake of the Swamp | public | — | — | — |
| 239935097 Three-Headed Snake of the Swamp | public | — | — | — |
| 239935098 Terrifying Hydra | public | — | — | — |
| 239935099 Rage of the Terrifying Dark Swamp | public | — | — | — |
| 239935100 Perseverance of the Hydra's Heart | public | — | — | — |
| 239935101 Terrifying Dark Swamp | public | — | — | — |
| 239935102 Terrifying Fog of the Dark Swamp | public | — | — | — |
| 239937489 Skull Undersea Melanocetus | public | — | — | — |
| 244161756 Lunalophosaur | public | — | — | — |
| 244161941 Vanquish Soul Brawl | public | — | — | — |
| 244162598 Moltenzoic Tristegsaurus | public | — | — | — |
| 244163199 Killamity Goldenrod | public | — | — | — |
| 244163200 Killamity Pine | public | — | — | — |
| 244163201 Killamity Crimson | public | — | — | — |
| 244163202 Killamity Azure | public | — | — | — |
| 244163203 Killamity Ash | public | — | — | — |
| 244163204 Killamity Apparition | public | — | — | — |
| 244163205 Killamity Showdown | public | — | — | — |
| 244163206 Ruby, Killamity Convergence | public | — | — | — |
| 244163508 Machina Megaframe | public | — | — | — |
| 244163509 Machina Trailblazer | public | — | — | — |
| 244165675 Mevalkagna, Eye of Zenith | public | — | — | — |
| 244168521 Heavy-Armoured Ballista Bahariasaurus | public | — | — | — |
| 247755864 Kali Yuga - Vritra | public | — | — | — |
| 247755865 Kali Yuga - Angulimala | public | — | — | — |
| 247755866 Kali Yuga - Sampati | public | — | — | — |
| 247755867 Kali Yuga - Yajna | public | — | — | — |
| 247755868 Kali Yuga - Karkotaka | public | — | — | — |
| 247755869 Kali Yuga - Murugan | public | — | — | — |
| 247755870 Kali Yuga - Mayavada | public | — | — | — |
| 247755871 Kali Yuga - Jarita | public | — | — | — |
| 247755872 Kali Yuga - Dukkha | public | — | — | — |
| 247755873 Kali Yuga - Ahimsaka Justijhn | public | — | — | — |
| 247756271 Kali Yuga - Bheki | public | — | — | — |
| 247756272 Kali Yuga - Jakarta | public | — | — | — |
| 255686110 Iscylla, Windborne Kraken of Sunken Depths | candidate | — | — | — |
| 259033429 Carcel, the Ohmechanic Light | — | candidate | — | — |
| 259072745 Bhodi, the Corrupted Halloween Tree | — | candidate | — | — |
| 259073666 Wyvernal Gathering | candidate | — | — | — |
| 259107906 Siemens, the Blue Ohmen | — | candidate | — | — |
| 259152704 Dragon Protector of Nature | candidate | candidate | — | — |
| 259160760 Wyvernal Sanctuary | candidate | — | — | — |
| 259174227 Farad, the Purple Ohmen | — | candidate | — | — |
| 259348317 Wyvernal Sphinx | candidate | — | — | — |
| 259350270 Farad, the Ohmechanic Capacitor | — | candidate | — | — |
| 259405917 Siemens, the Ohmechanic Conductor | — | candidate | — | — |
| 259479044 Ampere, the Ohmechanic Intensity | — | candidate | — | — |
| 259519336 Volt, the Ohmechanic Chocker | — | candidate | — | — |
| 259650132 Ampere, the Yellow Ohmen | — | candidate | — | — |
| 259726853 Volt, the Green Ohmen | — | candidate | — | — |
| 259763531 Wyvernal Lymantria | candidate | — | — | — |
| 259780273 Carcel, the Dark Ohmen | — | candidate | — | — |
| 259841490 Coulomb, the Ohmechanic Charger | — | candidate | — | — |
| 259881255 Coulomb, the White Ohmen | — | candidate | — | — |
| 284636586 Terrarumian Terrarium | public | — | — | — |
| 284636587 Terrarumian Spores | public | — | — | — |
| 284636588 Terrarumian Misting | public | — | — | — |
| 284636589 "Terrarumian Growth | public | — | — | — |
| 284636661 Aquamarine Seagrass Zostera | public | — | — | — |
| 284636662 Aquamarine Coral Krait | public | — | — | — |
| 284636663 Aquamarine Seafan Gorgonia | public | — | — | — |
| 284636664 Aquamarine Sand Clypeasteria | public | — | — | — |
| 284636665 Aquamarine Aquasanctuary | public | — | — | — |
| 284636666 Aquamarine Bubble Colony | public | — | — | — |
| 284639717 Terrarumian Cushion Moss | public | — | — | — |
| 284639718 Terrarumian Coin Plant | public | — | — | — |
| 284639719 Terrarumian Sword Fern | public | — | — | — |
| 284639720 Terrarumian Nerve Plant | public | — | — | — |
| 284639721 Terrarumian Staghorn Fern | public | — | — | — |
| 284639722 Terrarumian Ivy | public | — | — | — |
| 284639723 Terrarumian Sundew | public | — | — | — |
| 284639724 Terrarumian Trumpet Pitchers | public | — | — | — |
| 284639725 Terrarumian Tillandsia | public | — | — | — |
| 284639726 Terrarumian Venus Flytrap | public | — | — | — |

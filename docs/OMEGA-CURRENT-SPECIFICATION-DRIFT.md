# Current specification and audit freshness

Read-only reconciliation. Historical test data is preserved. Line breaks and literal escaped line breaks are treated as text separators. Missing public DB rows are reported separately from comparisons of existing metadata. No card is certified by this comparison.

```json
{
  "pinned_cards": 711,
  "current_cards": 711,
  "new_passcodes": [],
  "missing_current": 0,
  "changed_printed_effects": 27,
  "changed_specifications": 143,
  "database_text_mismatches": {
    "candidate": 27,
    "public": 0,
    "installed": 0
  },
  "database_metadata_mismatches": {
    "candidate": 47,
    "installed": 0
  },
  "database_missing_rows": {
    "candidate": 0,
    "public": 0,
    "installed": 0
  },
  "database_text_formatting_only": {
    "candidate": 2,
    "public": 24,
    "installed": 24
  },
  "source_install_mismatches": 0,
  "syntax_stale": 0,
  "load_stale": 17,
  "current_spec_initialization_rechecks": {
    "total": 114,
    "passed": 86,
    "compatibility_failures": 28
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
| 248760718 Starry Knight Starry Queen | (added) → Pendulum Effect:; (added) → Monster Effect: |
| 255686110 Iscylla, Windborne Kraken of Sunken Depths | card → card(s); (added) → for each card added |
| 259033429 Carcel, the Ohmenchanic Light | "Ohmechanic" → "Ohmenchanic"; Summoned, → Summoned:; Counter on it. → Counter.; all → its co-linked; co-linked to → on; on this card, → (removed); all monsters you control that are → its; to this card. → monsters.; on → from; (min → (min.; Ohmechanic → Ohmenchanic |
| 259073666 Wyvernal Gathering | (added) → "Wyvernal" or |
| 259107906 Siemens, the Blue Ohmen | all → each; monsters that point → Monster pointing; the → their; Arrows of those monsters, → Arrows,; (added) → until none of; process until all → (removed); card's → (removed); points → is co-linked; Main Monster Zone(s) and no other co-linked monster, → monster without a Current Counter placed by this effect,; 1 of those zones → a Main Monster Zone a Link Monster with a Current Counter placed by this effect points to |
| 259152704 Dragon Protector of Nature | NATURE → Plant, Insect or Beast; (added) → monster; NATURE → Plant, Insect or Beast; NATURE → Plant, Insect or Beast |
| 259160760 Wyvernal Sanctuary | (added) → "Wyvernal" or; an → a "Wyvernal" or; (added) → "Wyvernal" or |
| 259174227 Farad, the Purple Ohmen | all → each; Monsters that point → Monster pointing; the → their; Arrows of those monsters, → Arrows,; (added) → until none of; process until all → (removed); card's → (removed); points → is co-linked; Main Monster Zone(s) and no other co-linked monster, → monster without a Current Counter placed by this effect,; 1 of those zones → a Main Monster Zone a Link Monster with a Current Counter placed by this effect points to; one of those zones. → a Main Monster Zone a Link Monster with a Current Counter placed by this effect points to. |
| 259348317 Wyvernal Sphinx | an → a "Wyvernal" or |
| 259350270 Farad, the Ohmenchanic Capacitor | become → becomes; Counters on it. This card gains → Counters. Gains these; it. 1+: → it: ●1+:; opponents control; → opponent controls;; 2+: → ●2+:; 3+: → ●3+:; effect): → Effect):; Ohmechanic → Ohmenchanic |
| 259405917 Siemens, the Ohmenchanic Conductor | (added) → 2; become → becomes; Counters on it. This card gains → Counters. Gains these; it. 1+: → it: ●1+:; 2+: → ●2+:; Move → You can move; (added) → field to another Main Monster Zone on its; your → a; (added) → you control; 3+: → ●3+:; opponents → opponent; place → take control of; target → target, placing it; your → a; (added) → you control; Ohmechanic → Ohmenchanic |
| 259479044 Ampere, the Ohmenchanic Intensity | become → becomes; Counters on it. This card gains the following → Counters. Gains these; 1+: → ●1+:; 2+: Place → ●2+: During your Main Phase: You can place; (added) → co-linked to; card is co-linked to. 3+: "Ohmechanic" → card. ●3+: "Ohmenchanic"; Ohmechanic → Ohmenchanic |
| 259519336 Volt, the Ohmenchanic Chocker | Counters on it. This card gains the following → Counters. Gains these; 1+: → ●1+:; 2+: "Ohmechanic" → ●2+: "Ohmenchanic"; 3+: → ●3+:; Ohmechanic → Ohmenchanic |
| 259650132 Ampere, the Yellow Ohmen | all → each; Monsters that point → Monster pointing; the → their; Arrows of those monsters, → Arrows,; (added) → until none of; process until all → (removed); card's → (removed); points → is co-linked; Main Monster Zone(s) and no other co-linked monster, → monster without a Current Counter placed by this effect,; 1 of those zones → a Main Monster Zone a Link Monster with a Current Counter placed by this effect points to; you → You; also, → also you cannot Special Summon; you cannot Special Summon monsters, → (removed) |
| 259650969 Ohmen Beacon | "Ohmechanic" → "Ohmenchanic" |
| 259726853 Volt, the Green Ohmen | all → each; monsters that point → Monster pointing; the → their; Arrows of those monsters, → Arrows,; (added) → until none of; process until all → (removed); card's → (removed); points → is co-linked; Main Monster Zone(s) and no other co-linked monster, → monster without a Current Counter placed by this effect,; 1 of those zones → a Main Monster Zone a Link Monster with a Current Counter placed by this effect points to; one of those zones. → a Main Monster Zone a Link Monster with a Current Counter placed by this effect points to. |
| 259763531 Wyvernal Lymantria | (added) → "Wyvernal" or; (added) → "Wyvernal" or; also → also, for the rest of this turn,; non-Insect → (removed); Deck for the rest of the turn. → Deck, except "Wyvernal" or Insect monsters.; (added) → "Wyvernal" or |
| 259780273 Carcel, the Dark Ohmen | monsters → (removed); "Ohmechanic" → "Ohmenchanic" |
| 259841490 Coulomb, the Ohmenchanic Charger | card → card's; become → becomes; Counters on it. This card gains → Counters. Gains these; it. 1+: → it: ●1+: During your Main Phase:; monster → Monster; controls → control; zones, → Zones,; 2+: → ●2+:; you → You; card → (removed); yo → to; 3+: → ●3+:; 1 → an; monster from your Extra Deck using monsters you control as material. → monster.; Ohmechanic → Ohmenchanic |
| 259869259 Ohmen Surge | "Ohmechanic" → "Ohmenchanic" |
| 259881255 Coulomb, the White Ohmen | monster → monsters,; all monsters you control are → only; Monsters, → monsters,; counter → Counter; all → each; Monsters that point → Monster pointing; the → their; Arrows of those monsters, → Arrows,; (added) → until none of; process until all → (removed); monsters → Monsters; card's → (removed); points → is co-linked; Main Monster Zone(s) and no other co-linked monster, → monster without a Current Counter placed by this effect,; 1 of those zones → a Main Monster Zone a Link Monster with a Current Counter placed by this effect points to; During your Main Phase, you → You; equal → equals; of cards → (removed); them. → each. |

## Differences requiring review

| Card | Text mismatches | Metadata differs from public | Evidence stale | Installed script differs |
|---|---|---|---|---|
| 210506870 Talismandrake Heat | — | — | load | — |
| 212055290 Advent of Cosmic Beings | — | candidate | — | — |
| 212684822 Ektelestis gia Taxis | — | candidate | — | — |
| 213611313 Scarstech Crawler | candidate | — | — | — |
| 217713649 Onibi | candidate | — | — | — |
| 220305422 Natir, the Swords Master of Crying Chaos | candidate | — | — | — |
| 221321849 The Condescender | — | candidate | — | — |
| 221672256 Skewy! Boo-Boo | candidate | — | — | — |
| 223558392 Prophecy of Boulders | — | — | load | — |
| 223592011 Prophecy of Storms | — | — | load | — |
| 224274662 Armored Nova Mecha-Scaled Xyrion | — | candidate | — | — |
| 224751741 Fall of Azrynior | — | candidate | — | — |
| 227035644 Aqua Fusion | candidate | — | — | — |
| 229327103 Prophecy of Infernos | — | — | load | — |
| 234818744 Primite Dragon Citrine | — | candidate | — | — |
| 236239443 Restoration of Azrynior | — | candidate | — | — |
| 236551669 Pride of the Stellaers | — | candidate | — | — |
| 237684285 Janna, Windborne Goddess of Clement Winds | candidate | — | — | — |
| 238274857 Vylon Chevron | — | candidate | — | — |
| 238274858 Vylon Glome | — | candidate | — | — |
| 238274859 Vylon Volt | — | candidate | — | — |
| 238274860 Vylon Torus | — | candidate | — | — |
| 238274861 Vylon's Aid | — | candidate | — | — |
| 238274862 Vylon Observatory | — | candidate | — | — |
| 238274863 Vylon Eta | — | candidate | — | — |
| 238276572 Sylvan Flamushroomo | — | — | load | — |
| 238276574 Sylvan Flamioak | — | — | load | — |
| 238276575 Sylvan Greetings | — | — | load | — |
| 238276576 Sylvan Intervention | — | — | load | — |
| 238276577 Sylvan Blast | — | — | load | — |
| 238276578 Sylvan Duchessprout | — | — | load | — |
| 238276579 Gink, the Sylvan High Champion | — | — | load | — |
| 239245471 Birth of Azrynior | — | candidate | — | — |
| 241957394 Chapter II Verse IV | — | candidate | — | — |
| 243920845 Prophecy of Shadows | — | — | load | — |
| 244161941 Vanquish Soul Brawl | — | candidate | — | — |
| 244920555 Prophecy of Rays | — | — | load | — |
| 246393365 Rei-Tachi Ga Kita Hi | — | candidate | — | — |
| 248760718 Starry Knight Starry Queen | candidate | — | — | — |
| 251058567 Prophecy of Waterfalls | — | — | load | — |
| 254065048 Polemistis gia Ataxia | — | candidate | — | — |
| 255686110 Iscylla, Windborne Kraken of Sunken Depths | candidate | — | — | — |
| 256930605 Fruteification | — | — | load | — |
| 259023461 Disciple of Fire | — | candidate | — | — |
| 259033429 Carcel, the Ohmenchanic Light | candidate | candidate | — | — |
| 259072745 Bhodi, the Corrupted Halloween Tree | — | candidate | — | — |
| 259073666 Wyvernal Gathering | candidate | — | — | — |
| 259107906 Siemens, the Blue Ohmen | candidate | candidate | — | — |
| 259152704 Dragon Protector of Nature | candidate | candidate | — | — |
| 259160760 Wyvernal Sanctuary | candidate | — | — | — |
| 259174227 Farad, the Purple Ohmen | candidate | candidate | — | — |
| 259221974 Melantha, Keeper of Lamentations | — | candidate | — | — |
| 259223502 Ether Mademoiselle | — | candidate | — | — |
| 259225324 Transcend the Pendulum | — | candidate | — | — |
| 259290896 Dominus Sentinel | — | candidate | — | — |
| 259315827 Adamantios, the Dark Armor | — | candidate | — | — |
| 259348317 Wyvernal Sphinx | candidate | — | — | — |
| 259350270 Farad, the Ohmenchanic Capacitor | candidate | candidate | — | — |
| 259365935 Aetherstorm Zenith Wire-Tailed Sypharion | — | candidate | — | — |
| 259366281 Phlogiston's Roar! | — | candidate | — | — |
| 259384841 Divinity to Infinity | — | candidate | — | — |
| 259402105 Magical Girl Explosion! | — | candidate | — | — |
| 259405917 Siemens, the Ohmenchanic Conductor | candidate | candidate | — | — |
| 259434499 Ohmen Powerload | — | — | load | — |
| 259479044 Ampere, the Ohmenchanic Intensity | candidate | candidate | — | — |
| 259485374 Heart of the Cards | — | candidate | — | — |
| 259519336 Volt, the Ohmenchanic Chocker | candidate | candidate | — | — |
| 259650132 Ampere, the Yellow Ohmen | candidate | candidate | — | — |
| 259650969 Ohmen Beacon | candidate | — | load | — |
| 259687425 Retaliation Rebound | — | candidate | — | — |
| 259726853 Volt, the Green Ohmen | candidate | candidate | — | — |
| 259755133 Rush at the Gnome | — | candidate | — | — |
| 259763531 Wyvernal Lymantria | candidate | — | — | — |
| 259780273 Carcel, the Dark Ohmen | candidate | candidate | — | — |
| 259841490 Coulomb, the Ohmenchanic Charger | candidate | candidate | — | — |
| 259869259 Ohmen Surge | candidate | — | — | — |
| 259881255 Coulomb, the White Ohmen | candidate | candidate | — | — |

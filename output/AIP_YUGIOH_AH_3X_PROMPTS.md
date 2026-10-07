# A.I.P — Three Yu-Gi-Oh-shaped artwork prompts per card

All prompts use the released Ideogram 4 caption schema. Recommended baseline: main CFG `4.0`, late CFG `3.5`, LoRA `1.0`, prompt generator OFF, square 1 MP. Each version is a separate complete prompt.

## 1. The Misstakes of the A.I.P Experience

*Level 3 DARK Beast Normal Monster*

### A — First Awakening

```json
{
  "high_level_description": "A Beast-type Normal MONSTER card artwork showing the following scene: an unfinished artificial beast climbs from a ruptured specimen basin during the first failed laboratory activation.",
  "style_description": {
    "aesthetics": "uncanny experimental creature art with fragile newborn energy",
    "lighting": "sickly green overhead light with a warm orange glow beneath the specimen fluid",
    "medium": "illustration",
    "art_style": "hclar52 card illustration",
    "color_palette": [
      "#D8D6B2",
      "#26382F",
      "#7D9A66",
      "#D95B32",
      "#98D4C7",
      "#171D1A"
    ]
  },
  "compositional_deconstruction": {
    "background": "A damaged pale-green laboratory surrounds a cracked steel basin, one broken observation window, hanging cables, and low vapor.",
    "elements": [
      {
        "type": "obj",
        "bbox": [
          0,
          0,
          996,
          996
        ],
        "desc": "A small asymmetrical quadrupedal creature pulls itself from green nutrient fluid. Its pale unfinished hide is interrupted by black-green armor patches, one oversized orange eye, thin red vessels, mismatched forelimbs, and a trailing restraint cable; its wet claws scrape the basin as glass falls behind it."
      }
    ]
  }
}
```

### B — Observation Breach

```json
{
  "high_level_description": "A Beast-type Normal MONSTER card artwork showing the following scene: a malformed artificial animal crashes through an observation window as its frightened makers abandon the laboratory.",
  "style_description": {
    "aesthetics": "tense creature-feature fantasy with sudden broken-glass motion",
    "lighting": "cold cyan window light crossed by red emergency reflections and a dim orange eye",
    "medium": "illustration",
    "art_style": "hclar52 card illustration",
    "color_palette": [
      "#18241F",
      "#547263",
      "#9AC8C0",
      "#C53E2E",
      "#E5D7B6",
      "#0D1210"
    ]
  },
  "compositional_deconstruction": {
    "background": "A wide laboratory observation room contains one shattered window, a dark control desk, and two distant fleeing silhouettes.",
    "elements": [
      {
        "type": "obj",
        "bbox": [
          0,
          0,
          996,
          996
        ],
        "desc": "An unfinished black-green beast bursts shoulder-first through the broken window. One foreleg is armored and powerful while the other remains pale and narrow; a single orange eye watches the fleeing figures, red channels glow beneath translucent skin, and a snapped collar trails sparks through the glass."
      }
    ]
  }
}
```

### C — Abandoned Prototype

```json
{
  "high_level_description": "A Beast-type Normal MONSTER card artwork showing the following scene: the first abandoned artificial prototype prowls alone through a powerless research wing after its restraints have failed.",
  "style_description": {
    "aesthetics": "lonely ominous laboratory fantasy with a discoverable origin story",
    "lighting": "a narrow amber maintenance lamp reveals the creature against deep teal-black corridors",
    "medium": "illustration",
    "art_style": "hclar52 card illustration",
    "color_palette": [
      "#101816",
      "#2D4438",
      "#778B67",
      "#DB7B36",
      "#C7C5A7",
      "#07100D"
    ]
  },
  "compositional_deconstruction": {
    "background": "A powerless research corridor recedes through broad shadowed doorways, scattered restraint hoops, and a thin layer of green mist.",
    "elements": [
      {
        "type": "obj",
        "bbox": [
          0,
          0,
          996,
          996
        ],
        "desc": "A lean imperfect beast steps over its discarded harness and follows a blinking amber lamp. Its uneven black-green plates expose pale synthetic tissue, one orange eye is fully developed while the opposite socket remains sealed, and its long tail drags a bundle of severed sensor wires."
      }
    ]
  }
}
```

## 2. A.I.P Ex Larva

*Level 3 DARK Beast Effect Monster*

### A — Specimen-Tray Escape

```json
{
  "high_level_description": "A Beast-type MONSTER card artwork showing the following scene: a small pillbug-like artificial larva scuttles out of a cracked specimen tray across a laboratory workbench.",
  "style_description": {
    "aesthetics": "quick clever creature art with tactile miniature detail",
    "lighting": "cool green bench light with a warm red rim along the shell seams",
    "medium": "illustration",
    "art_style": "hclar52 card illustration",
    "color_palette": [
      "#14231D",
      "#355642",
      "#7EA06B",
      "#D94B2B",
      "#E2D4B7",
      "#8FC9C0"
    ]
  },
  "compositional_deconstruction": {
    "background": "A laboratory bench holds one cracked steel tray, a blurred cabinet bank, a forceps, and a broken vial.",
    "elements": [
      {
        "type": "obj",
        "bbox": [
          0,
          0,
          996,
          996
        ],
        "desc": "A low larval beast bends into a shallow curve as its front feet grip the bench and its rear plates emerge from the tray. Seven overlapping black-green shell plates carry narrow red seams, one recessed orange eye peers forward, and translucent nutrient gel stretches between its hooked feet."
      }
    ]
  }
}
```

### B — Revealed Packmate

```json
{
  "high_level_description": "A Beast-type MONSTER card artwork showing the following scene: an artificial larva cracks open a glowing data capsule and awakens another dormant beast hidden inside it.",
  "style_description": {
    "aesthetics": "playful technological summoning with a sharp moment of discovery",
    "lighting": "white capsule light illuminates green shell plates while orange-red signals pulse outward",
    "medium": "illustration",
    "art_style": "hclar52 card illustration",
    "color_palette": [
      "#10201A",
      "#3F6950",
      "#D8E8D7",
      "#E25B2B",
      "#F4D48C",
      "#2D8D83"
    ]
  },
  "compositional_deconstruction": {
    "background": "A dark specimen archive is reduced to broad drawer shapes, one open capsule cradle, and drifting green vapor.",
    "elements": [
      {
        "type": "obj",
        "bbox": [
          0,
          0,
          996,
          996
        ],
        "desc": "The pillbug larva hooks its forefeet around a translucent capsule as the casing splits. A second tiny beast-shaped shadow rises from orange light within, while the larva's single eye and seven red-seamed plates reflect the same pulse; broken shell halves spin away from the awakening."
      }
    ]
  }
}
```

### C — Trap Conductor

```json
{
  "high_level_description": "A Beast-type MONSTER card artwork showing the following scene: a tiny artificial larva sacrifices its body to activate a dormant containment protocol during a larger beast's attack.",
  "style_description": {
    "aesthetics": "urgent sacrificial fantasy action with compact electrical energy",
    "lighting": "cyan laboratory darkness cut by one red pulse and a white impact flash",
    "medium": "illustration",
    "art_style": "hclar52 card illustration",
    "color_palette": [
      "#0B1512",
      "#274438",
      "#69A092",
      "#C92E28",
      "#F0E4C8",
      "#314D47"
    ]
  },
  "compositional_deconstruction": {
    "background": "A shadowed laboratory floor contains one inactive restraint seal, a broken cable loop, and the legs of a larger beast passing behind.",
    "elements": [
      {
        "type": "obj",
        "bbox": [
          0,
          0,
          996,
          996
        ],
        "desc": "The larva leaps onto the restraint seal as its shell breaks into seven glowing segments. Red current races from those plates through the floor cables, igniting a wide mechanical trap beneath the larger beast while the larva's orange eye remains visible inside the dissolving pulse."
      }
    ]
  }
}
```

## 3. A.I.P Ex Shrieker

*Level 3 DARK Beast Effect Monster*

### A — Containment Scream

```json
{
  "high_level_description": "A Beast-type MONSTER card artwork showing the following scene: a squat black-green artificial beast bursts through a containment wall and unleashes a sonic scream across the laboratory.",
  "style_description": {
    "aesthetics": "violent bio-mechanical monster action with a single directional impact",
    "lighting": "cold cyan backlight contrasts with orange throat light and thin red armor seams",
    "medium": "illustration",
    "art_style": "hclar52 card illustration",
    "color_palette": [
      "#101816",
      "#29372B",
      "#D64725",
      "#F0C88F",
      "#65C5C2",
      "#77815B"
    ]
  },
  "compositional_deconstruction": {
    "background": "A dark green laboratory chamber has one shattered containment wall, broad cracked panels, drifting vapor, and sparse red alarms.",
    "elements": [
      {
        "type": "obj",
        "bbox": [
          0,
          0,
          996,
          996
        ],
        "desc": "A low four-legged predator lunges through the breach with heavy black-green shoulder plates, one orange eye, short hooked claws, and a tall fang-lined mouth. A narrow cone of compressed air tears toward the upper left, carrying several broad glass pieces and bending the vapor along one path."
      }
    ]
  }
}
```

### B — Division Cry

```json
{
  "high_level_description": "A Beast-type MONSTER card artwork showing the following scene: a screaming artificial beast breaks apart into two different black-green predators that spring from the same violent sound wave.",
  "style_description": {
    "aesthetics": "explosive metamorphosis with clearly separated emerging creatures",
    "lighting": "orange throat light divides into two red-cyan trails against a dark green chamber",
    "medium": "illustration",
    "art_style": "hclar52 card illustration",
    "color_palette": [
      "#0D1714",
      "#244238",
      "#C63A2A",
      "#E7B66D",
      "#67BFB5",
      "#D7D2B8"
    ]
  },
  "compositional_deconstruction": {
    "background": "A damaged summoning chamber curves around a central floor rupture, with simple wall ribs and low smoke.",
    "elements": [
      {
        "type": "obj",
        "bbox": [
          0,
          0,
          996,
          996
        ],
        "desc": "The small long-jawed beast arches backward as its black-green body dissolves into a compressed sonic flare. Two distinct beasts emerge from opposite sides of the flare: a lean taloned hunter races left and a heavy jawed predator drives right, each connected to the vanishing Shrieker by one red energy stream."
      }
    ]
  }
}
```

### C — Last Echo

```json
{
  "high_level_description": "A Beast-type MONSTER card artwork showing the following scene: the fading echo of a fallen artificial beast shields its pack from a collapsing laboratory ceiling.",
  "style_description": {
    "aesthetics": "protective supernatural aftermath with restrained spectral motion",
    "lighting": "dim teal ruin light with a translucent orange-red echo surrounding the surviving beasts",
    "medium": "illustration",
    "art_style": "hclar52 card illustration",
    "color_palette": [
      "#0B1412",
      "#304A40",
      "#5F8C80",
      "#D84B2C",
      "#F0C88F",
      "#777963"
    ]
  },
  "compositional_deconstruction": {
    "background": "A collapsed laboratory passage contains two broad falling slabs, thick dust, and the shadowed shapes of surviving artificial beasts.",
    "elements": [
      {
        "type": "obj",
        "bbox": [
          0,
          0,
          996,
          996
        ],
        "desc": "A translucent afterimage of the Shrieker rises from a small broken shell on the floor. Its open jaw releases one curved orange-red vibration that catches the falling slabs above two crouching packmates; the spectral eye remains bright while the rest of its body disperses into the dust."
      }
    ]
  }
}
```

## 4. A.I.P Ex Claw

*Level 6 DARK Beast Effect Monster*

### A — Corridor Ripper

```json
{
  "high_level_description": "A Beast-type MONSTER card artwork showing the following scene: a lean six-limbed artificial hunter tears sideways through a reinforced laboratory corridor with one immense crescent foreclaw.",
  "style_description": {
    "aesthetics": "fast predatory action with aggressive foreshortening",
    "lighting": "hard white light flashes along pale talons above deep green armor and red seams",
    "medium": "illustration",
    "art_style": "hclar52 card illustration",
    "color_palette": [
      "#0E1714",
      "#284137",
      "#BFC7BB",
      "#E5D7B2",
      "#C83D2A",
      "#4F8F87"
    ]
  },
  "compositional_deconstruction": {
    "background": "A reinforced corridor collapses into two broad wall planes and one receding doorway beneath green emergency haze.",
    "elements": [
      {
        "type": "obj",
        "bbox": [
          0,
          0,
          996,
          996
        ],
        "desc": "A narrow black-green hunter twists through the corridor on six limbs. Four long ivory-metal talons on its leading forearm carve a single crescent through the wall, while the smaller rear claw anchors behind its plated torso; one orange eye and swept-back armor fins follow the direction of the strike."
      }
    ]
  }
}
```

### B — Grave Excavator

```json
{
  "high_level_description": "A Beast-type MONSTER card artwork showing the following scene: an artificial clawed hunter rips open a sealed specimen vault and exposes the dormant beast preserved beneath it.",
  "style_description": {
    "aesthetics": "dark archaeological laboratory fantasy with forceful excavation",
    "lighting": "a red-orange glow rises from the opened vault beneath cold overhead cyan light",
    "medium": "illustration",
    "art_style": "hclar52 card illustration",
    "color_palette": [
      "#101714",
      "#34463B",
      "#958A70",
      "#D74729",
      "#E5D0A8",
      "#4AA79A"
    ]
  },
  "compositional_deconstruction": {
    "background": "A ruined specimen archive contains a cracked floor vault, broad stone-metal drawers, and low dust clouds.",
    "elements": [
      {
        "type": "obj",
        "bbox": [
          0,
          0,
          996,
          996
        ],
        "desc": "The six-limbed hunter drives its enormous crescent talons through the vault lid and pulls the metal apart. Beneath the claw, the fossil-like outline of another black-green beast rests in orange fluid; red signal threads travel from the exposed specimen into the hunter's plated arm."
      }
    ]
  }
}
```

### C — Returning Material

```json
{
  "high_level_description": "A Beast-type MONSTER card artwork showing the following scene: a wounded artificial hunter dissolves into orbiting material and restores a colossal black-green creature from a ruined chamber.",
  "style_description": {
    "aesthetics": "dramatic resurrection with controlled circular energy",
    "lighting": "pale green grave light contrasts with a dense orange-red material core",
    "medium": "illustration",
    "art_style": "hclar52 card illustration",
    "color_palette": [
      "#0A1310",
      "#263E34",
      "#688F7C",
      "#D5402C",
      "#F0C990",
      "#B9B9A6"
    ]
  },
  "compositional_deconstruction": {
    "background": "A broken underground chamber opens around one dark crater, fractured machinery, and a distant cyan shaft of light.",
    "elements": [
      {
        "type": "obj",
        "bbox": [
          0,
          0,
          996,
          996
        ],
        "desc": "The six-limbed hunter kneels beside the crater as its body separates into six red-edged armor fragments. Those fragments spiral into the chest of a larger rising black-green beast, and the immense crescent talons become two solid orbiting plates locked against the revived creature's dark body."
      }
    ]
  }
}
```

## 5. A.I.P Ex Maw

*Level 6 DARK Beast Effect Monster*

### A — Floorbreaker

```json
{
  "high_level_description": "A Beast-type MONSTER card artwork showing the following scene: a massive jawed artificial beast erupts through a laboratory floor and bites across the chamber.",
  "style_description": {
    "aesthetics": "heavy destructive monster art with a powerful rising curve",
    "lighting": "dull orange light burns inside the mouth beneath cold green industrial illumination",
    "medium": "illustration",
    "art_style": "hclar52 card illustration",
    "color_palette": [
      "#0B1512",
      "#263B32",
      "#C9432B",
      "#E2C69B",
      "#6F8470",
      "#55AEA2"
    ]
  },
  "compositional_deconstruction": {
    "background": "A pale concrete laboratory is split by one broad floor rupture, a shadowed wall opening, and green vapor.",
    "elements": [
      {
        "type": "obj",
        "bbox": [
          0,
          0,
          996,
          996
        ],
        "desc": "A thick black-green beast rises from the rupture on a muscular curved body with small gripping forelimbs, one recessed orange eye, and a broad side-opening jaw. Uneven ivory teeth close around a torn floor beam as red channels flare between its layered armor plates."
      }
    ]
  }
}
```

### B — Protocol Seeder

```json
{
  "high_level_description": "A Beast-type MONSTER card artwork showing the following scene: a jawed artificial beast plants a living containment trap into the laboratory floor as it emerges.",
  "style_description": {
    "aesthetics": "ominous biological engineering with a clear cause-and-effect event",
    "lighting": "orange mouth light illuminates a crimson seed against muted green shadows",
    "medium": "illustration",
    "art_style": "hclar52 card illustration",
    "color_palette": [
      "#0D1814",
      "#30483B",
      "#9B8465",
      "#D73C2A",
      "#F0D2A1",
      "#4D9B8E"
    ]
  },
  "compositional_deconstruction": {
    "background": "A circular test chamber contains one cracked floor channel, dark observation glass, and a restrained bank of pipes.",
    "elements": [
      {
        "type": "obj",
        "bbox": [
          0,
          0,
          996,
          996
        ],
        "desc": "The jawed beast crouches over the floor and lowers a red-black organic capsule from between its fangs. Root-like signal lines spread from the capsule into a concealed mechanical seal, while the creature's small foreclaws brace against the concrete and its single orange eye watches the device awaken."
      }
    ]
  }
}
```

### C — Selective Ruin

```json
{
  "high_level_description": "A Beast-type MONSTER card artwork showing the following scene: a black-green artificial beast roars as a destructive pulse tears through ordinary animals but passes harmlessly around its own pack.",
  "style_description": {
    "aesthetics": "apocalyptic monster effect art with a readable protected group",
    "lighting": "a white-orange shock front divides dark green allies from gray collapsing enemies",
    "medium": "illustration",
    "art_style": "hclar52 card illustration",
    "color_palette": [
      "#0A1210",
      "#253B32",
      "#667069",
      "#D7422C",
      "#F4D49D",
      "#6AB4A7"
    ]
  },
  "compositional_deconstruction": {
    "background": "A ruined research arena is divided by one diagonal shock front, broken floor plates, and a smoky green wall.",
    "elements": [
      {
        "type": "obj",
        "bbox": [
          0,
          0,
          996,
          996
        ],
        "desc": "The jawed beast opens its broad side jaw and releases a dense orange pulse. Gray altered beasts on one side fragment into ash and armor shards, while three black-green black-green creatures on the other side remain solid inside thin red outlines; the Maw's eye and teeth anchor the source of the destruction."
      }
    ]
  }
}
```

## 6. A.I.P Ex Predator

*Level 9 DARK Beast Effect Monster*

### A — Apex Breach

```json
{
  "high_level_description": "A Beast-type MONSTER card artwork showing the following scene: an enormous armored artificial predator stalks from a burning laboratory breach into cold night rain.",
  "style_description": {
    "aesthetics": "monumental predatory fantasy with controlled weight and menace",
    "lighting": "hot orange laboratory light rims a black-green body against blue-gray rain",
    "medium": "illustration",
    "art_style": "hclar52 card illustration",
    "color_palette": [
      "#0A1110",
      "#203B32",
      "#C6452C",
      "#E08948",
      "#496A78",
      "#B8C4BD"
    ]
  },
  "compositional_deconstruction": {
    "background": "A torn laboratory doorway separates a hot smoky interior from a rain-filled exterior of broad blue-gray structures.",
    "elements": [
      {
        "type": "obj",
        "bbox": [
          0,
          0,
          996,
          996
        ],
        "desc": "A low quadrupedal apex beast steps through the breach with a wedge-shaped skull, two narrow orange eyes, layered dorsal plates, long forearms, and heavy hooked claws. One paw crushes a fallen containment cart while its arched back and trailing tail emerge from the firelit doorway."
      }
    ]
  }
}
```

### B — Sacrificial Emergence

```json
{
  "high_level_description": "A Beast-type MONSTER card artwork showing the following scene: a colossal artificial predator materializes from the collapsing body of a smaller Beast inside a ritual laboratory.",
  "style_description": {
    "aesthetics": "dark predatory summoning with solemn biological transformation",
    "lighting": "deep cyan chamber light surrounds a concentrated red-orange emergence flare",
    "medium": "illustration",
    "art_style": "hclar52 card illustration",
    "color_palette": [
      "#08120F",
      "#244238",
      "#5A7465",
      "#C83328",
      "#E6A25F",
      "#72B9AE"
    ]
  },
  "compositional_deconstruction": {
    "background": "A circular underground laboratory contains one broken summoning cradle, broad wall ribs, and descending smoke.",
    "elements": [
      {
        "type": "obj",
        "bbox": [
          0,
          0,
          996,
          996
        ],
        "desc": "A smaller pale Beast dissolves into red-black particles beneath the descending paws of the Predator. The enormous black-green creature forms from those particles head-first, its orange eyes opening above the vanishing donor while dense armor plates lock across its shoulders and spine."
      }
    ]
  }
}
```

### C — Protocol Hunter

```json
{
  "high_level_description": "A Beast-type MONSTER card artwork showing the following scene: the apex artificial predator activates a hidden laboratory protocol while hunting through an abandoned city research district.",
  "style_description": {
    "aesthetics": "urban monster pursuit with covert technological menace",
    "lighting": "cold moonlight and cyan windows reveal restrained red signals along the creature",
    "medium": "illustration",
    "art_style": "hclar52 card illustration",
    "color_palette": [
      "#091210",
      "#20352E",
      "#3E5960",
      "#C43A2A",
      "#D4B47C",
      "#72AFA7"
    ]
  },
  "compositional_deconstruction": {
    "background": "An abandoned research district consists of a few dark tower shapes, one illuminated service tunnel, rain, and ground fog.",
    "elements": [
      {
        "type": "obj",
        "bbox": [
          0,
          0,
          996,
          996
        ],
        "desc": "The apex predator prowls between ruined buildings as a thin tendril from its foreclaw touches a concealed red seal in the street. The seal unfolds into a black-green trap behind an unaware distant figure, while the beast's low head, two orange eyes, and heavy shoulders remain half hidden by rain."
      }
    ]
  }
}
```

## 7. A.I.P Lab

*Field Spell*

### A — Containment Failure

```json
{
  "high_level_description": "A Field SPELL card artwork showing the following scene: an asymmetrical underground research laboratory suffers simultaneous containment failures as artificial beasts escape into its central work floor.",
  "style_description": {
    "aesthetics": "environmental science-fantasy with layered spatial storytelling",
    "lighting": "sickly green overhead light mixes with red alarms and white containment vapor",
    "medium": "illustration",
    "art_style": "hclar52 card illustration",
    "color_palette": [
      "#111A17",
      "#344C40",
      "#7C9276",
      "#B93629",
      "#D9D3B6",
      "#5AA69C"
    ]
  },
  "compositional_deconstruction": {
    "background": "A deep research floor contains a ruptured central chamber, an observation window, broad machinery banks, and receding service walkways.",
    "elements": [
      {
        "type": "obj",
        "bbox": [
          0,
          0,
          996,
          996
        ],
        "desc": "Green fluid pours from the broken chamber while three differently sized black-green beasts escape along separate paths. A small larva crosses the wet foreground, a clawed hunter climbs a side gantry, and a massive shadow presses through the rear wall as red signal lines awaken beneath the floor."
      }
    ]
  }
}
```

### B — Level Calibration

```json
{
  "high_level_description": "A Field SPELL card artwork showing the following scene: one artificial Beast passes through three linked laboratory rings and rapidly changes from a larva into a towering predator.",
  "style_description": {
    "aesthetics": "transformative laboratory fantasy with three readable stages of growth",
    "lighting": "cyan-white calibration light intensifies into orange-red energy across the chamber",
    "medium": "illustration",
    "art_style": "hclar52 card illustration",
    "color_palette": [
      "#0D1815",
      "#2D4D42",
      "#69B5AA",
      "#D7462C",
      "#F0D6A5",
      "#29352F"
    ]
  },
  "compositional_deconstruction": {
    "background": "A long calibration hall is formed by three large mechanical arches, a dark rear wall, and low green mist.",
    "elements": [
      {
        "type": "obj",
        "bbox": [
          0,
          0,
          996,
          996
        ],
        "desc": "A single black-green creature crosses the arches from left to right in three continuous growth phases: plated larva, lean clawed hunter, and massive quadrupedal predator. The same orange eye and red armor seams identify every stage while energy steps upward between the rings."
      }
    ]
  }
}
```

### C — Pack Overclock

```json
{
  "high_level_description": "A Field SPELL card artwork showing the following scene: the underground laboratory channels a shared power surge through an entire pack of artificial beasts during an emergency.",
  "style_description": {
    "aesthetics": "energetic field-wide enhancement with a coherent network pattern",
    "lighting": "a cyan reactor column sends restrained red-orange pulses through dark green creatures",
    "medium": "illustration",
    "art_style": "hclar52 card illustration",
    "color_palette": [
      "#081310",
      "#1F4035",
      "#49A89A",
      "#D53628",
      "#F0B969",
      "#8B9A82"
    ]
  },
  "compositional_deconstruction": {
    "background": "A circular power chamber surrounds one cyan reactor column, broad floor conduits, and shadowed observation decks.",
    "elements": [
      {
        "type": "obj",
        "bbox": [
          0,
          0,
          996,
          996
        ],
        "desc": "Five different black-green beasts circle the reactor at varied depths as one red pulse travels through the floor and illuminates their armor seams at the same instant. The nearest clawed forelimb digs into the floor while the largest predator raises its head behind the reactor glow."
      }
    ]
  }
}
```

## 8. Failures of the A.I.P

*Normal Trap*

### A — Captured as Material

```json
{
  "high_level_description": "A Normal TRAP card artwork showing the following scene: a hostile monster is compressed into a dark material orb and pulled beneath a waiting black-green Xyz beast.",
  "style_description": {
    "aesthetics": "sudden supernatural capture with a sharp reversal of power",
    "lighting": "violet-black compression light contrasts with orange eyes and cold laboratory green",
    "medium": "illustration",
    "art_style": "hclar52 card illustration",
    "color_palette": [
      "#0A1210",
      "#263D35",
      "#5D3C74",
      "#C53B2B",
      "#E4C58F",
      "#62A89D"
    ]
  },
  "compositional_deconstruction": {
    "background": "A ruined laboratory arena contains one cracked platform, scattered restraints, and a shadowed green wall.",
    "elements": [
      {
        "type": "obj",
        "bbox": [
          0,
          0,
          996,
          996
        ],
        "desc": "A pale armored enemy twists inside a collapsing violet sphere as two black-green tendrils pull it downward. Above the sphere, the underside and claws of a massive black-green Xyz creature descend, surrounded by several dense red-black material orbs that share the captive's reflected outline."
      }
    ]
  }
}
```

### B — Gallery of Failures

```json
{
  "high_level_description": "A Normal TRAP card artwork showing the following scene: rejected artificial prototypes awaken together inside a forgotten laboratory disposal vault.",
  "style_description": {
    "aesthetics": "tragic biological horror with varied malformed creatures",
    "lighting": "weak amber disposal lamps reveal pale bodies beneath intermittent red alarms",
    "medium": "illustration",
    "art_style": "hclar52 card illustration",
    "color_palette": [
      "#101512",
      "#4A5143",
      "#9B9274",
      "#C13A2E",
      "#D8C9A7",
      "#456F67"
    ]
  },
  "compositional_deconstruction": {
    "background": "A deep disposal vault contains broken specimen tanks, a flooded trench, and broad shelves fading into green darkness.",
    "elements": [
      {
        "type": "obj",
        "bbox": [
          0,
          0,
          996,
          996
        ],
        "desc": "Several failed prototypes crawl from shattered tanks: a beast with sealed eyes, a larva with mismatched plates, a jaw without a body, and a pale quadruped dragging cables. One completed black-green organism watches from the upper shadows as red veins begin connecting the discarded creatures."
      }
    ]
  }
}
```

### C — Recycled Error

```json
{
  "high_level_description": "A Normal TRAP card artwork showing the following scene: a discarded artificial specimen is dissolved, returned through the laboratory system, and replaced by a newly awakened subject.",
  "style_description": {
    "aesthetics": "eerie industrial recycling with a circular narrative flow",
    "lighting": "muted green machinery surrounds one bright orange-red transfer pulse",
    "medium": "illustration",
    "art_style": "hclar52 card illustration",
    "color_palette": [
      "#0B1512",
      "#2F493D",
      "#6F806A",
      "#D3412C",
      "#E8C589",
      "#64A69A"
    ]
  },
  "compositional_deconstruction": {
    "background": "A compact processing chamber contains a dark reclamation tank, one transparent return pipe, and a sealed specimen drawer.",
    "elements": [
      {
        "type": "obj",
        "bbox": [
          0,
          0,
          996,
          996
        ],
        "desc": "A malformed shell dissolves inside the reclamation tank and travels as red-black particles through the return pipe. At the opposite end, the specimen drawer opens around one bright orange eye and a small black-green claw, linking disposal and renewed creation in a single machine."
      }
    ]
  }
}
```

## 9. A.I.P Ex Assimilation

*Normal Trap*

### A — Split Transformation

```json
{
  "high_level_description": "A Normal TRAP card artwork showing the following scene: an armored automaton is transformed into an black-green creature along a violent diagonal boundary.",
  "style_description": {
    "aesthetics": "dramatic biomechanical conversion with two clearly connected material states",
    "lighting": "cold white light remains on the machine while orange-red energy burns through the altered half",
    "medium": "illustration",
    "art_style": "hclar52 card illustration",
    "color_palette": [
      "#121819",
      "#B8C2C2",
      "#243C33",
      "#C83A2B",
      "#E89B55",
      "#647B74"
    ]
  },
  "compositional_deconstruction": {
    "background": "A ruined laboratory loading bay appears as broad gray wall shapes, one broken gantry, and low green smoke.",
    "elements": [
      {
        "type": "obj",
        "bbox": [
          0,
          0,
          996,
          996
        ],
        "desc": "One continuous crouching figure is divided by a jagged red conversion front. Its left side retains pale angular armor and a mechanical hand; its right side has become black-green muscle plates, a predatory jaw, one orange eye, and a hooked claw as two thick tendrils tighten around its torso."
      }
    ]
  }
}
```

### B — Stolen Knight

```json
{
  "high_level_description": "A Normal TRAP card artwork showing the following scene: a luminous enemy knight is seized by a black-green neural organism and forced to turn against its former allies.",
  "style_description": {
    "aesthetics": "ominous mind-control fantasy with a readable change of allegiance",
    "lighting": "white-gold knight light is swallowed by dark green shadows and one red-orange eye",
    "medium": "illustration",
    "art_style": "hclar52 card illustration",
    "color_palette": [
      "#0C1412",
      "#2B4137",
      "#D8D8C8",
      "#C63C2D",
      "#E3A35D",
      "#5C7B72"
    ]
  },
  "compositional_deconstruction": {
    "background": "A shattered city courtyard contains two distant pale warriors, broad fallen columns, and green smoke from a laboratory breach.",
    "elements": [
      {
        "type": "obj",
        "bbox": [
          0,
          0,
          996,
          996
        ],
        "desc": "A compact one-eyed organism grips the knight's upper back with four short tendrils. Black-green armor spreads across the knight's silver body as the sword turns toward the distant allies; the helmet visor goes dark except for a new orange eye and thin red seams along the transformed arm."
      }
    ]
  }
}
```

### C — Neural Override

```json
{
  "high_level_description": "A Normal TRAP card artwork showing the following scene: an artificial parasite enters the exposed core of a giant enemy Beast and rewrites its body into black-green biological armor.",
  "style_description": {
    "aesthetics": "large-scale biological takeover with concentrated invasive detail",
    "lighting": "a red core flare illuminates black-green growth against blue-gray storm light",
    "medium": "illustration",
    "art_style": "hclar52 card illustration",
    "color_palette": [
      "#091210",
      "#223B32",
      "#556A72",
      "#D63D2A",
      "#F0B66B",
      "#A4AAA0"
    ]
  },
  "compositional_deconstruction": {
    "background": "A storm-damaged containment yard contains one fallen tower, wet concrete, and a distant laboratory doorway.",
    "elements": [
      {
        "type": "obj",
        "bbox": [
          0,
          0,
          996,
          996
        ],
        "desc": "A giant pale Beast rears as a small black-green parasite enters a cracked chest core. Red channels branch from the wound and lock dark armor plates across one shoulder, jaw, and foreleg; the original blue eye fades while a new orange sensory node opens above it."
      }
    ]
  }
}
```

## 10. A.I.P Ex Hive Mind

*Continuous Trap*

### A — Synchronized Pack

```json
{
  "high_level_description": "A Continuous TRAP card artwork showing the following scene: three different artificial beasts synchronize with a suspended neural organism inside a dark laboratory chamber.",
  "style_description": {
    "aesthetics": "eerie coordinated intelligence with sparse precise connections",
    "lighting": "soft green chamber light is punctuated by four simultaneous orange-red eye flares",
    "medium": "illustration",
    "art_style": "hclar52 card illustration",
    "color_palette": [
      "#08120F",
      "#243C33",
      "#567869",
      "#C6382A",
      "#EDA65D",
      "#66AAA0"
    ]
  },
  "compositional_deconstruction": {
    "background": "A curved chamber wall contains two broad green light panels, a shadowed floor, and faint vapor.",
    "elements": [
      {
        "type": "obj",
        "bbox": [
          0,
          0,
          996,
          996
        ],
        "desc": "A folded black-green neural organism floats above three beasts at different depths: a plated larva, a long-jawed hunter, and a heavy predator. Four thin red filaments connect their foreheads, and every orange eye ignites together as the creatures turn toward the same unseen threat."
      }
    ]
  }
}
```

### B — Memory Reclamation

```json
{
  "high_level_description": "A Continuous TRAP card artwork showing the following scene: the living neural network extracts a dead monster's memory and returns its empty body to a vast biological archive.",
  "style_description": {
    "aesthetics": "surreal technological necromancy with ordered flowing information",
    "lighting": "violet grave light transitions into red signals and a cool cyan archive glow",
    "medium": "illustration",
    "art_style": "hclar52 card illustration",
    "color_palette": [
      "#091310",
      "#253C34",
      "#59446A",
      "#C83A2C",
      "#E4A660",
      "#5AA79D"
    ]
  },
  "compositional_deconstruction": {
    "background": "A subterranean archive contains one circular reclamation pool, broad vertical memory stacks, and green mist.",
    "elements": [
      {
        "type": "obj",
        "bbox": [
          0,
          0,
          996,
          996
        ],
        "desc": "A translucent monster rises from the pool as its memories separate into red luminous symbols and travel into a black-green neural mass. The emptied body sinks through a ring of dark fluid while an orange eye opens inside a distant archive cell, showing the network has stored and reused the pattern."
      }
    ]
  }
}
```

### C — Forced Evolution

```json
{
  "high_level_description": "A Continuous TRAP card artwork showing the following scene: a hive intelligence reorganizes several artificial beasts into the materials for a towering black-green Xyz organism.",
  "style_description": {
    "aesthetics": "ritualized collective evolution with layered creature scale",
    "lighting": "red neural pulses converge beneath a cold cyan column of transformation light",
    "medium": "illustration",
    "art_style": "hclar52 card illustration",
    "color_palette": [
      "#07110E",
      "#203B31",
      "#4F897D",
      "#D43829",
      "#E8B66F",
      "#9D9C84"
    ]
  },
  "compositional_deconstruction": {
    "background": "A wide laboratory pit is surrounded by simple observation tiers, broken rails, and descending green vapor.",
    "elements": [
      {
        "type": "obj",
        "bbox": [
          0,
          0,
          996,
          996
        ],
        "desc": "Three beasts leap into a cyan transformation column as their black-green bodies become dense orbiting material spheres. Above them, the shadow of a crowned many-limbed organism takes shape around one orange eye while the hive node directs every red filament into the forming body."
      }
    ]
  }
}
```

## 11. Caller of the A.I.P Ex

*Rank 6 DARK Beast Xyz Monster*

### A — Ruined-City Broadcast

```json
{
  "high_level_description": "A Beast-type Xyz MONSTER card artwork showing the following scene: a towering artificial caller broadcasts from a collapsed transmitter and summons lesser black-green beasts through a ruined city.",
  "style_description": {
    "aesthetics": "commanding science-fantasy monster art with layered scale",
    "lighting": "cold blue-gray backlight reveals black-green armor while one red pulse crosses the ruins",
    "medium": "illustration",
    "art_style": "hclar52 card illustration",
    "color_palette": [
      "#080F0E",
      "#1D352E",
      "#465E69",
      "#C5362B",
      "#E6A25F",
      "#6FAAA0"
    ]
  },
  "compositional_deconstruction": {
    "background": "A foggy ruined skyline surrounds a collapsed transmitter dish, a broken platform, and several distant red-black apertures.",
    "elements": [
      {
        "type": "obj",
        "bbox": [
          0,
          0,
          996,
          996
        ],
        "desc": "A tall hunched quadrupedal caller grips the transmitter with elongated forelimbs. A broad manta-like sensory hood shelters two narrow orange eyes, layered black-green plates and restrained red channels; three smaller beasts emerge through separate apertures below as one signal travels from the hood into the dish."
      }
    ]
  }
}
```

### B — Tenfold Foresight

```json
{
  "high_level_description": "A Beast-type Xyz MONSTER card artwork showing the following scene: a many-eyed artificial caller examines ten possible futures suspended above two opposing memory wells.",
  "style_description": {
    "aesthetics": "occult information-control fantasy with ordered but unsettling imagery",
    "lighting": "cyan and violet future-images orbit a dark figure lit by orange sensory nodes",
    "medium": "illustration",
    "art_style": "hclar52 card illustration",
    "color_palette": [
      "#080F12",
      "#203A36",
      "#3E6680",
      "#6B4B87",
      "#D13B2E",
      "#E5A95E"
    ]
  },
  "compositional_deconstruction": {
    "background": "A dark prediction chamber contains two circular memory wells, five reflections above each well, and a floor veiled in mist.",
    "elements": [
      {
        "type": "obj",
        "bbox": [
          0,
          0,
          996,
          996
        ],
        "desc": "The hooded caller crouches between the wells and spreads its sensory hood. Ten translucent scene fragments arc overhead in two groups of five while small orange eyes open across the hood; one long claw rearranges the nearest fragment and dense red-black material spheres orbit its chest."
      }
    ]
  }
}
```

### C — Stolen Summoning

```json
{
  "high_level_description": "A Beast-type Xyz MONSTER card artwork showing the following scene: an enemy-owned monster is reshaped into compatible material as the towering hooded caller descends into battle.",
  "style_description": {
    "aesthetics": "predatory summoning ritual with a clear theft and transformation",
    "lighting": "a white enemy aura fractures into orange-red material beneath cold green descent light",
    "medium": "illustration",
    "art_style": "hclar52 card illustration",
    "color_palette": [
      "#09120F",
      "#213B32",
      "#CBD0C3",
      "#C43B2C",
      "#E9A65E",
      "#5A9D93"
    ]
  },
  "compositional_deconstruction": {
    "background": "A broken arena lies beneath a dark laboratory aperture, broad floor cracks, and low green smoke.",
    "elements": [
      {
        "type": "obj",
        "bbox": [
          0,
          0,
          996,
          996
        ],
        "desc": "A pale enemy monster is compressed into a red-black sphere as six glowing bands lock around it. The hooded caller descends above on elongated forelimbs, its manta hood open and orange eyes fixed on the stolen material, while a newly summoned packmate climbs from the enemy's fading shadow."
      }
    ]
  }
}
```

## 12. Zero Mother of the A.I.P Ex

*Rank 9 DARK Beast Xyz Monster*

### A — Mother Emergent

```json
{
  "high_level_description": "A Beast-type Xyz MONSTER card artwork showing the following scene: the colossal mother organism rises from the destroyed central laboratory with her offspring orbiting around her.",
  "style_description": {
    "aesthetics": "monumental maternal bio-horror with immense controlled scale",
    "lighting": "cold cyan light behind the ruin outlines a black-green carapace and one vast orange eye",
    "medium": "illustration",
    "art_style": "hclar52 card illustration",
    "color_palette": [
      "#050C0A",
      "#172F28",
      "#3D6D62",
      "#C93229",
      "#E89A50",
      "#9D9A7E"
    ]
  },
  "compositional_deconstruction": {
    "background": "A vast central laboratory opens into smoke and darkness above a tiny broken gantry and scattered containment towers.",
    "elements": [
      {
        "type": "obj",
        "bbox": [
          0,
          0,
          996,
          996
        ],
        "desc": "An immense asymmetrical cephalopod-beast lifts a heavy black-green hood over one off-center orange eye and a toothed lower maw. Six long tendrils emerge from separate sockets, each guiding a small creature-shaped red-black material orb, while two powerful front limbs crush the ruined facility below."
      }
    ]
  }
}
```

### B — Maternal Collection

```json
{
  "high_level_description": "A Beast-type Xyz MONSTER card artwork showing the following scene: the colossal one-eyed mother organism seizes two enemy monsters and seals them into living material around her body.",
  "style_description": {
    "aesthetics": "overwhelming capture scene with readable tendril paths and colossal weight",
    "lighting": "two bright captive auras collapse into red-black spheres beneath a cyan storm sky",
    "medium": "illustration",
    "art_style": "hclar52 card illustration",
    "color_palette": [
      "#050D0B",
      "#18342B",
      "#56777A",
      "#CF3B2B",
      "#ECA55D",
      "#C3C3AD"
    ]
  },
  "compositional_deconstruction": {
    "background": "A shattered research city forms broad dark blocks below storm clouds, green vapor, and a distant laboratory crater.",
    "elements": [
      {
        "type": "obj",
        "bbox": [
          0,
          0,
          996,
          996
        ],
        "desc": "The mother organism towers above two struggling enemy monsters. One thick tendril wraps a silver warrior and another coils around a blue dragon; both captives compress into separate spheres beside her carapace as four remaining tendrils brace against the city and her orange eye observes the collection."
      }
    ]
  }
}
```

### C — Beast Dominion

```json
{
  "high_level_description": "A Beast-type Xyz MONSTER card artwork showing the following scene: the mother organism rewrites every creature across a battlefield into members of one artificial Beast ecology.",
  "style_description": {
    "aesthetics": "world-altering biological fantasy with a vast spreading transformation",
    "lighting": "an orange-red wave radiates beneath green storm light and black celestial clouds",
    "medium": "illustration",
    "art_style": "hclar52 card illustration",
    "color_palette": [
      "#050C09",
      "#18332A",
      "#456B5F",
      "#C93629",
      "#E9A45B",
      "#7F8977"
    ]
  },
  "compositional_deconstruction": {
    "background": "A wide battlefield of ruins, flooded trenches, and distant towers stretches beneath the hovering mother organism.",
    "elements": [
      {
        "type": "obj",
        "bbox": [
          0,
          0,
          996,
          996
        ],
        "desc": "The mother organism spreads six tendrils as one red biological wave crosses the land. A dragon, warrior, machine, and aquatic creature each acquire black-green armor plates, orange eyes, and Beast-like claws while retaining their original outlines; dense material spheres circle the mother's hood above them."
      }
    ]
  }
}
```

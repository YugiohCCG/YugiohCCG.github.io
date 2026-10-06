# A.I.P — native Ideogram 4 JSON prompts

Paste one complete JSON object into the final Ideogram 4 structured-prompt input or directly into the Ideogram-aware `CLIPTextEncode` prompt field. If using the workflow's natural-language-to-JSON generator, bypass that generator when pasting these completed objects.

## 1. The Misstakes of the A.I.P Experience

```json
{
  "high_level_description": "hclar52 modern Japanese fantasy trading-card illustration of a newly activated black-green artificial beast climbing from a ruptured laboratory specimen basin, framed as an ominous origin event with a large readable silhouette and strong foreground depth.",
  "style_description": {
    "aesthetics": "ominous, energetic, polished, highly readable at thumbnail scale, controlled detail density",
    "art_style": "hclar52 card illustration, modern Japanese monster trading-card artwork, crisp expressive linework, dimensional painted shading",
    "lighting": "sickly green overhead illumination with concentrated red-orange light from the specimen basin and a narrow cyan rim light",
    "medium": "digital fantasy illustration",
    "color_palette": ["#101815", "#193F32", "#80A98D", "#D83B24", "#FF8A31"]
  },
  "compositional_deconstruction": {
    "background": "A restrained pale-green laboratory shell with broad concrete wall panels, a dark grated floor and one shattered observation window; distant architecture is simplified into low-contrast shapes behind thin white vapor.",
    "elements": [
      {
        "type": "obj",
        "bbox": [140, 120, 920, 860],
        "desc": "A small crouching artificial beast climbing from a ruptured steel specimen basin toward the viewer. Glossy black-green synthetic hide forms uneven armor folds around one luminous red-orange eye, four grasping limbs and an unfinished trailing tail; thin red energy channels remain concentrated around its shoulders and face.",
        "color_palette": ["#0C1311", "#173B30", "#B82E23", "#F2732E"]
      },
      {
        "type": "obj",
        "bbox": [710, 0, 1000, 1000],
        "desc": "A broken restraint cable, several large glass fragments and a shallow stream of green nutrient fluid cross the lower foreground, forming a converging path toward the creature and basin rather than a decorative border. Orange sparks remain concentrated beside the broken restraint fitting."
      },
      {
        "type": "obj",
        "bbox": [180, 740, 470, 960],
        "desc": "Two tiny laboratory technicians stand behind the observation window in the far right middle distance, reduced to simple dark silhouettes under a red alarm light and providing scale without becoming secondary focal characters."
      }
    ]
  }
}
```

## 2. A.I.P Ex Larva

```json
{
  "high_level_description": "hclar52 modern Japanese fantasy trading-card illustration of a small pillbug-like A.I.P larva actively escaping a cracked specimen tray, using an oblique tabletop view and oversized foreground tools to create depth around one clean creature silhouette.",
  "style_description": {
    "aesthetics": "uncanny, clever, alert, polished, restrained laboratory detail, thumbnail-readable",
    "art_style": "hclar52 card illustration, modern Japanese monster trading-card artwork, crisp contour drawing with richly painted shell plates",
    "lighting": "cool green laboratory ambience with a warm red rim along the shell seams and one pale monitor reflection",
    "medium": "digital fantasy illustration",
    "color_palette": ["#101A16", "#234D3A", "#7E9B80", "#D13A27", "#F27631"]
  },
  "compositional_deconstruction": {
    "background": "A subdued laboratory workbench against two broad shadowed cabinet shapes and one soft rectangular monitor glow; surfaces remain simple and low contrast with open negative space around the larva.",
    "elements": [
      {
        "type": "obj",
        "bbox": [230, 170, 800, 860],
        "desc": "A low pillbug-like artificial larva bends into a shallow curve while climbing over the edge of a cracked steel tray. Seven overlapping black-green shell plates carry narrow glowing red seams; one recessed red-orange eye and many short hooked feet face the viewer in active motion.",
        "color_palette": ["#101814", "#24503C", "#9D2B24", "#F0782F"]
      },
      {
        "type": "obj",
        "bbox": [390, 90, 900, 910],
        "desc": "A shallow rectangular steel specimen tray sits diagonally beneath the larva, its near corner bent outward and its surface holding a small smear of translucent green nutrient gel. The diagonal tray establishes perspective while remaining secondary to the creature."
      },
      {
        "type": "obj",
        "bbox": [730, 0, 1000, 470],
        "desc": "A large cropped pair of steel forceps and one broken glass vial occupy the lower-left foreground, pointing toward the larva and creating scale without overlapping its eye or front legs."
      }
    ]
  }
}
```

## 3. A.I.P Ex Shrieker

```json
{
  "high_level_description": "hclar52 modern Japanese fantasy trading-card illustration of a squat reptilian A.I.P beast releasing a powerful sonic cry in a damaged laboratory, dominated by an extreme low-angle open-mouth focal point and an asymmetric cone of airborne fragments.",
  "style_description": {
    "aesthetics": "explosive, imposing, grotesque but clean, strongly foreshortened, immediately readable",
    "art_style": "hclar52 card illustration, modern Japanese monster trading-card action artwork, crisp anatomy, dramatic painted impact effects",
    "lighting": "dull orange illumination from deep inside the throat with cyan rim light and muted green room ambience",
    "medium": "digital fantasy illustration",
    "color_palette": ["#0D1713", "#174937", "#A72D25", "#F47B31", "#8CC8C1"]
  },
  "compositional_deconstruction": {
    "background": "A damaged green laboratory shell with one broad cracked wall plane, a dark horizontal pipe bank and a soft cyan emergency lamp; background edges remain sparse behind the creature's head.",
    "elements": [
      {
        "type": "obj",
        "bbox": [60, 120, 970, 960],
        "desc": "A squat reptilian artificial beast twists its head toward the upper-left while releasing a sonic cry. Segmented black-green hide, restrained red channels, one bulging orange eye, powerful forelimbs and an impossibly deep vertical mouth lined with irregular ivory fangs form one complete readable body.",
        "color_palette": ["#0B1511", "#19503B", "#B83427", "#F17A32", "#DCC6A0"]
      },
      {
        "type": "obj",
        "bbox": [20, 0, 850, 690],
        "desc": "An asymmetric cone of compressed air expands from the open mouth toward the upper-left, bending dust into curved directional streaks. Several large translucent glass fragments travel within the cone and are cropped by the top and left edges, without forming a complete circle."
      },
      {
        "type": "obj",
        "bbox": [760, 0, 1000, 1000],
        "desc": "Three pieces of fractured flooring and scattered pale dust cross the bottom foreground beneath the creature's braced claws, anchoring its weight without creating a flat graphic strip."
      }
    ]
  }
}
```

## 4. A.I.P Ex Claw

```json
{
  "high_level_description": "hclar52 modern Japanese fantasy trading-card illustration of a lean six-limbed A.I.P hunter pouncing laterally through a breached corridor, with one enormous crescent foreclaw sweeping through the foreground and a clean diagonal action silhouette.",
  "style_description": {
    "aesthetics": "fast, predatory, sharp, aggressive, uncluttered, thumbnail-readable",
    "art_style": "hclar52 card illustration, modern Japanese monster trading-card action artwork, crisp linework, dimensional painted anatomy and controlled impact marks",
    "lighting": "hard white rim light on the metallic talons with deep green shadows and concentrated red-orange sparks",
    "medium": "digital fantasy illustration",
    "color_palette": ["#0A1411", "#183E31", "#9B2922", "#E5D8BA", "#F27830"]
  },
  "compositional_deconstruction": {
    "background": "A breached gray-green research corridor formed by two broad wall planes and one receding dark doorway; a few loose cables follow the perspective while open negative space surrounds the main claw.",
    "elements": [
      {
        "type": "obj",
        "bbox": [100, 80, 900, 950],
        "desc": "A lean six-limbed hunting beast pounces from upper-right toward lower-left. Overlapping black-green muscle plates, thin red channels, a narrow predatory skull, one red-orange eye and a swept-back armored mane form a lateral silhouette; one forelimb carries four enormous pale metallic crescent talons.",
        "color_palette": ["#0B1512", "#204838", "#B12E25", "#E6D7B8"]
      },
      {
        "type": "obj",
        "bbox": [300, 0, 1000, 580],
        "desc": "The dominant four-taloned foreclaw sweeps across the near left foreground and is cropped by the edge, separated from the second claw by a clean pocket of empty space. Its foreshortened talons remain distinct and do not merge into one shape."
      },
      {
        "type": "obj",
        "bbox": [700, 260, 1000, 940],
        "desc": "A concentrated fan of orange sparks and several angular floor fragments marks the claw's contact path across the lower middle ground, following the diagonal movement instead of forming a horizontal footer."
      }
    ]
  }
}
```

## 5. A.I.P Ex Maw

```json
{
  "high_level_description": "hclar52 modern Japanese fantasy trading-card illustration of a massive serpentine A.I.P beast rising through a fractured laboratory floor, its readable head and upper body following a strong S-curve toward a huge side-opening jaw.",
  "style_description": {
    "aesthetics": "massive, uncanny, forceful, sculptural, clear negative space, concentrated detail",
    "art_style": "hclar52 card illustration, modern Japanese monster trading-card artwork, crisp creature design with dimensional painted scales and debris",
    "lighting": "dull orange biological light inside the mouth with cool pale-green chamber illumination and a narrow white rim",
    "medium": "digital fantasy illustration",
    "color_palette": ["#0B1512", "#194435", "#A82F24", "#F07832", "#DDD0AF"]
  },
  "compositional_deconstruction": {
    "background": "A simple pale concrete laboratory chamber with one broad cracked wall opening, a dark floor plane and distant green vapor; the upper-left remains quiet to preserve the head silhouette.",
    "elements": [
      {
        "type": "obj",
        "bbox": [80, 130, 960, 940],
        "desc": "A complete serpentine artificial beast rises in one muscular S-curve from the lower foreground to the upper-right. Black-green segmented armor, restrained red channels, one recessed orange eye, small gripping forelimbs and a huge side-opening jaw filled with uneven ivory teeth define its head and torso.",
        "color_palette": ["#0C1713", "#1C4B39", "#AB3026", "#ED7530", "#DDC9A7"]
      },
      {
        "type": "obj",
        "bbox": [720, 0, 1000, 1000],
        "desc": "One thick body coil crosses the lower foreground and is cropped at both edges, leading upward toward the head while leaving visible space between the coil, forelimbs and jaw."
      },
      {
        "type": "obj",
        "bbox": [600, 80, 1000, 740],
        "desc": "Two large pieces of fractured flooring and a directional spray of pale dust rise beside the body coil, reinforcing upward movement without surrounding the entire creature with debris."
      }
    ]
  }
}
```

## 6. A.I.P Ex Predator

```json
{
  "high_level_description": "hclar52 modern Japanese fantasy trading-card illustration of an enormous quadrupedal A.I.P apex predator stalking from a hot laboratory breach into cold rain, viewed from ground level with one foreground paw and an off-center watchful head.",
  "style_description": {
    "aesthetics": "imposing, controlled, intelligent, cinematic, high-level boss monster, readable silhouette",
    "art_style": "hclar52 card illustration, modern Japanese monster trading-card boss artwork, crisp armored anatomy with richly painted atmospheric separation",
    "lighting": "orange backlight from the laboratory, cold blue-gray rain light and subtle red glow beneath the armor seams",
    "medium": "digital fantasy illustration",
    "color_palette": ["#09130F", "#173B2F", "#932A24", "#E66D2D", "#819DA5"]
  },
  "compositional_deconstruction": {
    "background": "A broad orange-lit laboratory opening fills the left rear while a blue-gray rain-filled exterior fills the right; architecture is reduced to two large value masses and a wet dark ground plane beneath the creature.",
    "elements": [
      {
        "type": "obj",
        "bbox": [100, 80, 940, 940],
        "desc": "An enormous low quadrupedal beast stalks diagonally out of the breach. Black-green armored hide, restrained red channels, a wedge-shaped skull, two small orange eyes, layered dorsal spines, long forearms, heavy hooked claws and a trailing tail create an unmistakably animal silhouette.",
        "color_palette": ["#09130F", "#1B4032", "#9D2C25", "#E76E2E"]
      },
      {
        "type": "obj",
        "bbox": [630, 570, 1000, 1000],
        "desc": "One planted forepaw dominates the lower-right foreground, partly cropped by two edges and rendered with four clearly separated hooked claws. Rain beads catch the cold rim light across the knuckles."
      },
      {
        "type": "obj",
        "bbox": [540, 100, 760, 320],
        "desc": "A tiny overturned steel containment cart rests near the distant laboratory threshold, providing scale while remaining a simple dark shape against the orange interior light."
      }
    ]
  }
}
```

## 7. A.I.P Lab

```json
{
  "high_level_description": "hclar52 modern Japanese fantasy trading-card Field Spell illustration of an oblique abandoned research laboratory at the instant a central containment system fails, using three strong depth zones and one concentrated environmental incident rather than a posed creature.",
  "style_description": {
    "aesthetics": "ominous, investigative, spacious, cinematic, environmentally narrative, controlled complexity",
    "art_style": "hclar52 card illustration, modern Japanese fantasy trading-card environment artwork, crisp focal machinery with painterly distant architecture",
    "lighting": "sickly green overhead panels, red emergency reflections, cold white vapor and a small orange glow inside the failed chamber",
    "medium": "digital fantasy environment illustration",
    "color_palette": ["#101713", "#254737", "#77947D", "#A52B24", "#E77330"]
  },
  "compositional_deconstruction": {
    "background": "An asymmetrical laboratory shell with a dark grated foreground floor, a pale-green central work area, a deep shadowed rear wall and one wide observation window; distant cabinets are broad rectangles with no readable labels.",
    "elements": [
      {
        "type": "obj",
        "bbox": [180, 390, 790, 810],
        "desc": "An off-center cylindrical containment chamber stands ruptured in the middle distance, its upper ring tilted and its lower seals open. Green nutrient fluid spills onto the grated floor while a concentrated cloud of white vapor exposes a small orange-lit cavity inside."
      },
      {
        "type": "obj",
        "bbox": [90, 20, 850, 470],
        "desc": "Black-green organic growth with faint red veins spreads across the left wall and bends three thick laboratory pipes toward the failed chamber. The growth follows the room perspective and remains integrated with the architecture rather than becoming a second monster portrait."
      },
      {
        "type": "obj",
        "bbox": [700, 0, 1000, 620],
        "desc": "A cropped overturned instrument cart and two wet cable loops occupy the dark lower-left foreground, creating leading lines into the central work area while leaving the containment chamber unobstructed."
      },
      {
        "type": "obj",
        "bbox": [190, 790, 430, 940],
        "desc": "One tiny laboratory technician stands behind the far observation window under a red alarm lamp, reduced to a single dark silhouette that establishes scale."
      }
    ]
  }
}
```

## 8. Failures of the A.I.P

```json
{
  "high_level_description": "hclar52 modern Japanese fantasy trading-card Trap illustration of an unstable pale artificial beast being converted into material energy by a compact A.I.P organism, shown as a clear diagonal event with two separate subjects and one floating destination orb.",
  "style_description": {
    "aesthetics": "unsettling, supernatural, readable, controlled, event-focused, polished",
    "art_style": "hclar52 card illustration, modern Japanese fantasy trading-card Trap artwork, crisp subjects with broad flowing energy shapes",
    "lighting": "soft green alarm ambience with sharp red light at the conversion organism and pale white highlights along the energy boundary",
    "medium": "digital fantasy illustration",
    "color_palette": ["#111814", "#385448", "#C8C7AD", "#A52B25", "#EA7130"]
  },
  "compositional_deconstruction": {
    "background": "A subdued laboratory shell with a cracked gray-green floor, one broad observation window and a soft green alarm panel; the environment stays low contrast behind the diagonal conversion event.",
    "elements": [
      {
        "type": "obj",
        "bbox": [310, 40, 900, 520],
        "desc": "An unstable pale quadrupedal artificial beast braces one foreleg against the floor on the left. Uneven smooth armor, a narrow head and one brightly illuminated amber eye remain clearly readable and spatially separate from the A.I.P organism."
      },
      {
        "type": "obj",
        "bbox": [250, 600, 770, 950],
        "desc": "A compact black-green A.I.P organism hovers on the right with one red central eye, a layered oval body and four short tendrils directed toward the pale beast."
      },
      {
        "type": "obj",
        "bbox": [100, 370, 820, 900],
        "desc": "Four broad ribbon-like streams of dark translucent energy and glowing red nodes travel diagonally from the pale beast toward a dense floating material orb in the upper-right. The streams remain separated and taper along one coherent direction."
      },
      {
        "type": "obj",
        "bbox": [760, 0, 1000, 600],
        "desc": "An open metal restraint ring and several angular floor fragments cross the lower foreground, anchoring the event without forming a border or warning stripe."
      }
    ]
  }
}
```

## 9. A.I.P Ex Assimilation

```json
{
  "high_level_description": "hclar52 modern Japanese fantasy trading-card Trap illustration of one armored automaton undergoing a dramatic A.I.P transformation, preserving image 0036's diagonal crouch, foreground cable arcs and concentrated orange conversion sparks while clarifying the original and transformed halves.",
  "style_description": {
    "aesthetics": "dynamic, powerful, biomechanical, high contrast, asymmetrical, action-focused",
    "art_style": "hclar52 card illustration, modern Japanese fantasy trading-card action artwork, crisp biomechanical anatomy with polished dimensional shading",
    "lighting": "cold white rim light on the original armor with hot red-orange light concentrated at the shoulder and waist transformation boundary",
    "medium": "digital fantasy illustration",
    "color_palette": ["#0A1010", "#202A2B", "#758087", "#A82A23", "#F17B31"]
  },
  "compositional_deconstruction": {
    "background": "A simplified ruined-city shell of broad gray building silhouettes, one pale smoke mass and a dark ground plane; the skyline remains quiet behind the diagonal figure.",
    "elements": [
      {
        "type": "obj",
        "bbox": [90, 100, 960, 930],
        "desc": "One armored automaton crouches diagonally from upper-left to lower-right during transformation. Its left half retains pale angular mechanical armor, an articulated hand and an original helmet; its right half has glossy black-green synthetic muscle, a predatory jaw, one orange eye and thin red energy channels.",
        "color_palette": ["#111717", "#69757A", "#0D1B16", "#9F2922", "#F07830"]
      },
      {
        "type": "obj",
        "bbox": [20, 0, 980, 1000],
        "desc": "Two thick segmented black tendrils follow different large curves around the automaton, one looping behind the shoulders and one crossing the near lower foreground. Both remain separated from the head, hands and transformation boundary."
      },
      {
        "type": "obj",
        "bbox": [300, 300, 900, 790],
        "desc": "Two concentrated bursts of orange conversion sparks appear only at the right shoulder and waist, tracing the boundary between pale mechanical armor and black-green artificial tissue."
      }
    ]
  }
}
```

## 10. A.I.P Ex Hive Mind

```json
{
  "high_level_description": "hclar52 modern Japanese fantasy trading-card Continuous Trap illustration of three different A.I.P beasts synchronizing with a small off-center neural organism, arranged at separate depths with sparse red signal filaments and ample negative space.",
  "style_description": {
    "aesthetics": "eerie, intelligent, coordinated, restrained, diagrammatically clear without resembling a logo",
    "art_style": "hclar52 card illustration, modern Japanese fantasy trading-card artwork, crisp creature silhouettes with subtle organic painting",
    "lighting": "dark green chamber ambience with red-orange eye lights and narrow pale highlights on the signal filaments",
    "medium": "digital fantasy illustration",
    "color_palette": ["#08110E", "#183B2E", "#36634B", "#A92B24", "#F27630"]
  },
  "compositional_deconstruction": {
    "background": "A single curved dark-green chamber wall with two broad vertical light panels, a shadowed floor and faint vapor; the architecture remains sparse between the separated creature silhouettes.",
    "elements": [
      {
        "type": "obj",
        "bbox": [100, 610, 410, 900],
        "desc": "A small folded black-green neural organism floats off-center in the upper-right, carrying one red-orange eye and exactly four short tendrils. Its irregular organic outline avoids circular emblem symmetry."
      },
      {
        "type": "obj",
        "bbox": [610, 30, 980, 390],
        "desc": "A pillbug-like A.I.P larva occupies the near lower-left foreground, showing overlapping black-green shell plates, narrow red seams and one orange eye; part of its shell is cropped by the lower edge."
      },
      {
        "type": "obj",
        "bbox": [310, 120, 760, 550],
        "desc": "A long-jawed A.I.P shrieker appears in the left middle ground in three-quarter profile, with a segmented neck, one orange eye and a partly open vertical mouth."
      },
      {
        "type": "obj",
        "bbox": [420, 610, 820, 960],
        "desc": "A larger armored A.I.P predator recedes on the right, its wedge-shaped head, dorsal plates and two orange eyes emerging from the chamber shadows."
      },
      {
        "type": "obj",
        "bbox": [170, 180, 850, 870],
        "desc": "Three sparse translucent filaments connect the beasts' foreheads to the neural organism. A single red pulse travels along each filament while open dark space remains between all subjects."
      }
    ]
  }
}
```

## 11. Caller of the A.I.P Ex

```json
{
  "high_level_description": "hclar52 modern Japanese fantasy trading-card Xyz monster illustration of a non-human A.I.P caller emerging above a collapsed transmitter and calling three lesser beasts, combining a low-angle arrival with image 0185's restrained rim-lit silhouette.",
  "style_description": {
    "aesthetics": "ominous, commanding, mysterious, monumental, silhouette-led, spatially clear",
    "art_style": "hclar52 card illustration, modern Japanese fantasy trading-card boss artwork, crisp silhouette with selectively revealed internal anatomy",
    "lighting": "pale blue-gray backlight around the sensory hood and limbs with narrow red eye lights and one red signal pulse",
    "medium": "digital fantasy illustration",
    "color_palette": ["#050908", "#111B18", "#384B49", "#A92625", "#C7D5D2"]
  },
  "compositional_deconstruction": {
    "background": "A fog-filled ruined-city shell made from a few broad vertical building silhouettes and a pale circular opening in the clouded sky; most of the upper frame remains dark behind the caller.",
    "elements": [
      {
        "type": "obj",
        "bbox": [50, 80, 900, 900],
        "desc": "A tall hunched quadrupedal caller steps from the upper-left darkness. Elongated forelimbs, a broad manta-like sensory hood, layered black-green synthetic hide, two narrow red eyes and a few restrained red channels form a non-human silhouette with three internal planes revealed by rim light.",
        "color_palette": ["#050908", "#13211C", "#3D5250", "#A92725"]
      },
      {
        "type": "obj",
        "bbox": [690, 190, 1000, 760],
        "desc": "A large collapsed circular transmitter dish occupies the lower foreground, tilted in perspective and cropped by the bottom edge. The caller's nearest long hand grips its upper rim, connecting the creature physically to the foreground."
      },
      {
        "type": "obj",
        "bbox": [430, 650, 790, 980],
        "desc": "Three small distinct A.I.P beasts appear at different distances through uneven red-black apertures in the lower-right city haze, reduced to one larval, one long-jawed and one quadrupedal silhouette."
      },
      {
        "type": "obj",
        "bbox": [350, 280, 870, 760],
        "desc": "One narrow red signal pulse travels diagonally from beneath the caller's sensory hood into the center of the transmitter dish, creating a secondary focal line without forming a geometric poster pattern."
      }
    ]
  }
}
```

## 12. Zero, Mother of the A.I.P Ex

```json
{
  "high_level_description": "hclar52 modern Japanese fantasy trading-card Xyz boss illustration of Zero, an immense asymmetrical cephalopod-beast rising from the central laboratory and gathering creature-shaped energy fragments into material orbs with six clearly separated tendrils.",
  "style_description": {
    "aesthetics": "monumental, maternal, alien, commanding, asymmetrical, boss-monster scale, controlled complexity",
    "art_style": "hclar52 card illustration, modern Japanese fantasy trading-card boss artwork, crisp focal anatomy with richly painted atmospheric scale",
    "lighting": "cold cyan backlight through the chamber opening with concentrated red-orange eye light and subtle red channels beneath the carapace",
    "medium": "digital fantasy illustration",
    "color_palette": ["#07100D", "#142E25", "#28503D", "#A62A24", "#F07831", "#89B8BB"]
  },
  "compositional_deconstruction": {
    "background": "A vast smoke-filled central laboratory chamber with broad ruined wall shapes, a cold cyan opening behind the creature and a dark fractured floor; architecture stays simple to preserve the mother's scale and silhouette.",
    "elements": [
      {
        "type": "obj",
        "bbox": [50, 80, 950, 950],
        "desc": "Zero is an immense asymmetrical cephalopod-beast in three-quarter profile. A heavy black-green maternal carapace frames one off-center red-orange eye, a toothed lower maw, powerful front limbs and six long tendrils emerging from distinct sockets; restrained red channels appear beneath the hood.",
        "color_palette": ["#07100D", "#173427", "#295341", "#A42B25", "#F07831"]
      },
      {
        "type": "obj",
        "bbox": [80, 0, 1000, 1000],
        "desc": "Two of Zero's six tendrils arc through the near foreground and are cropped by opposite edges, while four remain in the middle ground reaching in separate directions. Clear negative-space channels keep every tendril visually distinct and prevent radial symmetry."
      },
      {
        "type": "obj",
        "bbox": [180, 100, 760, 930],
        "desc": "Four small red-black material orbs float at uneven distances around Zero, each receiving one translucent creature-shaped energy fragment drawn along a different tendril. Their asymmetrical placement supports the main body rather than forming a ring."
      },
      {
        "type": "obj",
        "bbox": [780, 20, 1000, 360],
        "desc": "A tiny broken laboratory gantry and several pin-sized distant technician silhouettes occupy the lower-left, lit by the cyan chamber opening and establishing the mother's enormous scale."
      }
    ]
  }
}
```

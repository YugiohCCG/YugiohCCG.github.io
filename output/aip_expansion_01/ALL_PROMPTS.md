# A.I.P expansion 01 — twelve new monsters

Copy one complete JSON block into the direct prompt field with Generate JSON Prompt OFF. These are new artwork concepts, not changes to card effects or existing card data. No images have been generated from this pack yet.

The common design is black-green artificial animal anatomy, narrow red channels, an orange eye, selective ivory structures and pale-green laboratory surroundings. Each monster has one different physical task and silhouette. Backgrounds support that task and extend to the edges.

Keep your current working model, LoRA, resolution and sampler unchanged for the initial comparison. Use the same two seeds for every concept: 751299600367585 and 751299600367586. That makes 24 images. The older A.I.P calibration notes contain unresolved tests, so this pack does not claim a winning sampler, LoRA weight or bbox treatment. Boxes use normalized [top, left, bottom, right] coordinates on a 0–1000 scale.

Review each seed for silhouette readability, coherent anatomy, physical contact, archetype consistency and a continuous illustrated background. Preserve the best image’s exact prompt and settings. Test one revision at a time afterward; do not change sampler and prompt together.

## A.I.P Ex Vaultbreaker

```json
{
  "high_level_description": "A Beast-type MONSTER card artwork showing the following scene: a broad artificial beast levers a containment door out of its frame with its shovel-shaped forehead.",
  "style_description": {
    "aesthetics": "uncanny artificial animal, one dominant readable silhouette and a clear physical action within a continuous full-bleed laboratory scene",
    "lighting": "cool green ambient light with compact cel shadows, restrained cyan edge light and a small warm orange eye accent",
    "medium": "illustration",
    "art_style": "hclar52 card illustration",
    "color_palette": [
      "#172820",
      "#354B39",
      "#82977C",
      "#B93E32",
      "#E0D5B6",
      "#8ECAC6"
    ]
  },
  "compositional_deconstruction": {
    "background": "An oblique containment doorway divides pale laboratory concrete from a dark chamber. The tilted door and a short trail of bolts describe the breach; broad floor shadows continue to the edges.",
    "elements": [
      {
        "type": "obj",
        "bbox": [
          120,
          60,
          970,
          930
        ],
        "desc": "A low six-legged animal with a broad wedge skull, overlapping black-green plates, narrow red seams and one visible orange eye drives its ivory brow beneath a buckling door. Three-quarter side view; braced rear legs and the raised door reveal its leverage, while one huge forefoot crosses the lower edge."
      }
    ]
  }
}
```

## A.I.P Ex Spindle

```json
{
  "high_level_description": "A Beast-type MONSTER card artwork showing the following scene: a long-legged artificial beast stitches a broken containment bridge together while crossing the gap.",
  "style_description": {
    "aesthetics": "uncanny artificial animal, one dominant readable silhouette and a clear physical action within a continuous full-bleed laboratory scene",
    "lighting": "cool green ambient light with compact cel shadows, restrained cyan edge light and a small warm orange eye accent",
    "medium": "illustration",
    "art_style": "hclar52 card illustration",
    "color_palette": [
      "#172820",
      "#354B39",
      "#82977C",
      "#B93E32",
      "#E0D5B6",
      "#8ECAC6"
    ]
  },
  "compositional_deconstruction": {
    "background": "A damaged research catwalk cuts diagonally over a dim teal service shaft. Only two broken railing sections and one distant cyan lamp define the depth, with the shaft painted continuously to every edge.",
    "elements": [
      {
        "type": "obj",
        "bbox": [
          70,
          80,
          940,
          950
        ],
        "desc": "A narrow black-green animal with four extremely long jointed legs and a compact orange-eyed head steps sideways over a gap. Two forelimbs pull three taut red biological filaments between broken railings; its short armored abdomen hangs beneath the crossing, with clean open spaces separating the legs."
      }
    ]
  }
}
```

## A.I.P Ex Bellows

```json
{
  "high_level_description": "A Beast-type MONSTER card artwork showing the following scene: an inflated artificial beast blasts coolant vapor beneath itself to slide away from closing containment shutters.",
  "style_description": {
    "aesthetics": "uncanny artificial animal, one dominant readable silhouette and a clear physical action within a continuous full-bleed laboratory scene",
    "lighting": "cool green ambient light with compact cel shadows, restrained cyan edge light and a small warm orange eye accent",
    "medium": "illustration",
    "art_style": "hclar52 card illustration",
    "color_palette": [
      "#172820",
      "#354B39",
      "#82977C",
      "#B93E32",
      "#E0D5B6",
      "#8ECAC6"
    ]
  },
  "compositional_deconstruction": {
    "background": "One descending steel shutter angles across a pale-green corridor. A wet floor streak and a small displaced maintenance bucket show the direction of escape; distant surfaces form broad quiet shapes.",
    "elements": [
      {
        "type": "obj",
        "bbox": [
          230,
          70,
          920,
          940
        ],
        "desc": "A squat black-green beast has a folded accordion torso, small gripping feet, narrow red seams and an orange eye beneath a heavy brow. In low side view it compresses its belly against the floor, forcing one low plume of pale vapor behind it as its forefeet reach forward."
      }
    ]
  }
}
```

## A.I.P Ex Latchwing

```json
{
  "high_level_description": "A Beast-type MONSTER card artwork showing the following scene: a folded-wing artificial beast swings from a ceiling rail and tears loose a restraint hook.",
  "style_description": {
    "aesthetics": "uncanny artificial animal, one dominant readable silhouette and a clear physical action within a continuous full-bleed laboratory scene",
    "lighting": "cool green ambient light with compact cel shadows, restrained cyan edge light and a small warm orange eye accent",
    "medium": "illustration",
    "art_style": "hclar52 card illustration",
    "color_palette": [
      "#172820",
      "#354B39",
      "#82977C",
      "#B93E32",
      "#E0D5B6",
      "#8ECAC6"
    ]
  },
  "compositional_deconstruction": {
    "background": "A ceiling rail recedes diagonally through a dim green testing hall. One torn hanging restraint and a small amber inspection lamp support the event; shadowed wall planes fill the entire square.",
    "elements": [
      {
        "type": "obj",
        "bbox": [
          70,
          90,
          930,
          940
        ],
        "desc": "A batlike artificial animal with black-green ribbed wing membranes, thin red vessels and an orange eye hangs diagonally from one oversized ivory hook-claw. Its other wing opens into a single broad angular fan. A snapped restraint drops beneath its compact torso while the hooked limb visibly bears its weight."
      }
    ]
  }
}
```

## A.I.P Ex Ballast

```json
{
  "high_level_description": "A Beast-type MONSTER card artwork showing the following scene: a heavy artificial beast rolls its armored shoulder into a sliding laboratory barrier to hold it open.",
  "style_description": {
    "aesthetics": "uncanny artificial animal, one dominant readable silhouette and a clear physical action within a continuous full-bleed laboratory scene",
    "lighting": "cool green ambient light with compact cel shadows, restrained cyan edge light and a small warm orange eye accent",
    "medium": "illustration",
    "art_style": "hclar52 card illustration",
    "color_palette": [
      "#172820",
      "#354B39",
      "#82977C",
      "#B93E32",
      "#E0D5B6",
      "#8ECAC6"
    ]
  },
  "compositional_deconstruction": {
    "background": "A low barrier occupies the upper-right corner above a broad concrete floor. The remaining opening reveals a muted cyan room; a few crushed floor tiles cluster beneath the beast rather than covering the scene.",
    "elements": [
      {
        "type": "obj",
        "bbox": [
          160,
          70,
          960,
          940
        ],
        "desc": "A barrel-bodied black-green animal with overlapping stone-like shell plates, short thick legs, narrow red seams and a small orange eye wedges itself sideways beneath a barrier. Its near shoulder is enormous but the head remains distinct. One rear foot skids through dust as the shell tilts under pressure."
      }
    ]
  }
}
```

## A.I.P Ex Glassrunner

```json
{
  "high_level_description": "A Beast-type MONSTER card artwork showing the following scene: a slender artificial beast races across a tilted observation pane as the glass slips from its frame.",
  "style_description": {
    "aesthetics": "uncanny artificial animal, one dominant readable silhouette and a clear physical action within a continuous full-bleed laboratory scene",
    "lighting": "cool green ambient light with compact cel shadows, restrained cyan edge light and a small warm orange eye accent",
    "medium": "illustration",
    "art_style": "hclar52 card illustration",
    "color_palette": [
      "#172820",
      "#354B39",
      "#82977C",
      "#B93E32",
      "#E0D5B6",
      "#8ECAC6"
    ]
  },
  "compositional_deconstruction": {
    "background": "One tilted observation pane bridges two levels of a pale laboratory. A dark lower chamber is visible beneath it; three large falling shards mark the movement against broad undetailed wall planes.",
    "elements": [
      {
        "type": "obj",
        "bbox": [
          100,
          70,
          890,
          950
        ],
        "desc": "A lean four-legged black-green creature with translucent heel fins, narrow red channels and a long orange-eyed snout runs diagonally along a falling glass pane. Its forelegs stretch toward the far ledge while rear claws still grip the glass. A curved segmented tail counterbalances the leap without encircling the body."
      }
    ]
  }
}
```

## A.I.P Ex Relay

```json
{
  "high_level_description": "A Beast-type MONSTER card artwork showing the following scene: a sensory artificial beast touches a dead laboratory console with its antenna and wakes a single row of lamps.",
  "style_description": {
    "aesthetics": "uncanny artificial animal, one dominant readable silhouette and a clear physical action within a continuous full-bleed laboratory scene",
    "lighting": "cool green ambient light with compact cel shadows, restrained cyan edge light and a small warm orange eye accent",
    "medium": "illustration",
    "art_style": "hclar52 card illustration",
    "color_palette": [
      "#172820",
      "#354B39",
      "#82977C",
      "#B93E32",
      "#E0D5B6",
      "#8ECAC6"
    ]
  },
  "compositional_deconstruction": {
    "background": "A broad dark console slopes away into a green research room. One row of newly lit cyan lamps leads from the contact point into depth; the remaining wall and floor are quiet painted masses.",
    "elements": [
      {
        "type": "obj",
        "bbox": [
          180,
          100,
          950,
          920
        ],
        "desc": "A crouched black-green amphibian-like animal has a flattened skull, one orange eye and two unequal ivory antennae. The longer antenna bends forward to touch a console, producing one small red contact spark. Its ribbed back and four planted webbed feet form a clear low silhouette in three-quarter view."
      }
    ]
  }
}
```

## A.I.P Ex Undertow

```json
{
  "high_level_description": "A Beast-type MONSTER card artwork showing the following scene: an aquatic artificial beast drags a detached containment grate into a flooded research channel.",
  "style_description": {
    "aesthetics": "uncanny artificial animal, one dominant readable silhouette and a clear physical action within a continuous full-bleed laboratory scene",
    "lighting": "cool green ambient light with compact cel shadows, restrained cyan edge light and a small warm orange eye accent",
    "medium": "illustration",
    "art_style": "hclar52 card illustration",
    "color_palette": [
      "#172820",
      "#354B39",
      "#82977C",
      "#B93E32",
      "#E0D5B6",
      "#8ECAC6"
    ]
  },
  "compositional_deconstruction": {
    "background": "An oblique flooded laboratory trench separates a pale concrete ledge from a shadowed pipe bank. A single curling splash gathers around the sinking grate; subdued teal water continues beyond the image edges.",
    "elements": [
      {
        "type": "obj",
        "bbox": [
          100,
          60,
          950,
          940
        ],
        "desc": "An eel-bodied black-green beast with a broad crocodilian head, orange eye and two muscular grasping forelimbs curls diagonally through shallow water. One hand pulls a rectangular grate downward while the other braces on the channel edge. Narrow red seams trace the shoulder plates; its mouth stays closed and readable."
      }
    ]
  }
}
```

## A.I.P Ex Cradle

```json
{
  "high_level_description": "A Beast-type MONSTER card artwork showing the following scene: a protective artificial beast closes its shield-like forelimbs over a cracked incubation vessel during a ceiling collapse.",
  "style_description": {
    "aesthetics": "uncanny artificial animal, one dominant readable silhouette and a clear physical action within a continuous full-bleed laboratory scene",
    "lighting": "cool green ambient light with compact cel shadows, restrained cyan edge light and a small warm orange eye accent",
    "medium": "illustration",
    "art_style": "hclar52 card illustration",
    "color_palette": [
      "#172820",
      "#354B39",
      "#82977C",
      "#B93E32",
      "#E0D5B6",
      "#8ECAC6"
    ]
  },
  "compositional_deconstruction": {
    "background": "A damaged incubation room is reduced to one leaning ceiling panel, a dark cabinet mass and a pale floor. Falling fragments gather above the raised shield, leaving clear space around the creature’s face.",
    "elements": [
      {
        "type": "obj",
        "bbox": [
          150,
          70,
          950,
          940
        ],
        "desc": "A broad-backed black-green animal with an orange eye and narrow red channels crouches in profile. Its two oversized ivory-edged forelimbs overlap above a small broken vessel like a sloping roof. The head peers beneath the near shield, with sturdy rear legs planted visibly behind it and sparse chips striking the armor."
      }
    ]
  }
}
```

## A.I.P Ex Molt

```json
{
  "high_level_description": "A Beast-type MONSTER card artwork showing the following scene: an artificial beast pulls free of its discarded armor while squeezing through a narrow maintenance hatch.",
  "style_description": {
    "aesthetics": "uncanny artificial animal, one dominant readable silhouette and a clear physical action within a continuous full-bleed laboratory scene",
    "lighting": "cool green ambient light with compact cel shadows, restrained cyan edge light and a small warm orange eye accent",
    "medium": "illustration",
    "art_style": "hclar52 card illustration",
    "color_palette": [
      "#172820",
      "#354B39",
      "#82977C",
      "#B93E32",
      "#E0D5B6",
      "#8ECAC6"
    ]
  },
  "compositional_deconstruction": {
    "background": "A low rectangular service hatch opens in a broad green wall. One empty armor husk catches on its metal lip; a cool floor reflection leads toward the emerging forefeet with minimal surrounding machinery.",
    "elements": [
      {
        "type": "obj",
        "bbox": [
          190,
          80,
          960,
          940
        ],
        "desc": "A sinewy black-green quadruped with a bright orange eye pushes its head and forelegs from a small hatch. Pale flexible joints and narrow red channels show beneath fresh plates. One empty split shell remains caught behind its shoulders, clearly hollow and connected to the exit rather than resembling a second creature."
      }
    ]
  }
}
```

## A.I.P Ex Counterweight

```json
{
  "high_level_description": "A Beast-type MONSTER card artwork showing the following scene: a long-tailed artificial beast swings a heavy laboratory lift around by anchoring its tail beneath the platform.",
  "style_description": {
    "aesthetics": "uncanny artificial animal, one dominant readable silhouette and a clear physical action within a continuous full-bleed laboratory scene",
    "lighting": "cool green ambient light with compact cel shadows, restrained cyan edge light and a small warm orange eye accent",
    "medium": "illustration",
    "art_style": "hclar52 card illustration",
    "color_palette": [
      "#172820",
      "#354B39",
      "#82977C",
      "#B93E32",
      "#E0D5B6",
      "#8ECAC6"
    ]
  },
  "compositional_deconstruction": {
    "background": "One suspended maintenance lift tilts within a tall green shaft. A taut support cable and distant landing establish the load and height, while broad cyan shadow planes surround the diagonal animal.",
    "elements": [
      {
        "type": "obj",
        "bbox": [
          70,
          100,
          950,
          940
        ],
        "desc": "A compact black-green climbing animal with four gripping limbs, one orange eye and a thick segmented tail hangs across the corner of a tilted lift. Its tail ends in a heavy ivory club hooked underneath the platform. The arched torso visibly links its planted front claws to the weighted tail."
      }
    ]
  }
}
```

## A.I.P Ex Palisade

```json
{
  "high_level_description": "A Beast-type MONSTER card artwork showing the following scene: a colossal artificial beast rises beneath a laboratory floor and lifts a whole row of containment cells on its armored back.",
  "style_description": {
    "aesthetics": "uncanny artificial animal, one dominant readable silhouette and a clear physical action within a continuous full-bleed laboratory scene",
    "lighting": "cool green ambient light with compact cel shadows, restrained cyan edge light and a small warm orange eye accent",
    "medium": "illustration",
    "art_style": "hclar52 card illustration",
    "color_palette": [
      "#172820",
      "#354B39",
      "#82977C",
      "#B93E32",
      "#E0D5B6",
      "#8ECAC6"
    ]
  },
  "compositional_deconstruction": {
    "background": "A breached underground testing chamber contains one raised floor slab with three tiny empty containment frames for scale. A distant green wall and cool dust form two broad masses, with debris concentrated at the emerging shoulder.",
    "elements": [
      {
        "type": "obj",
        "bbox": [
          80,
          30,
          980,
          960
        ],
        "desc": "A gigantic low quadruped with black-green layered hide, narrow red fissures and a small fierce orange eye emerges in three-quarter view. Five uneven ivory dorsal shields support a tilted slab of laboratory flooring. The near foreleg steps into the foreground, while the head projects clearly beyond the shields and slab."
      }
    ]
  }
}
```

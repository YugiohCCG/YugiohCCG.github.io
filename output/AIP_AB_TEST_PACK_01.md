# A.I.P Artwork A/B Test Pack 01

**Purpose:** Test three composition controls against the `hclar52` LoRA without adding competing style language.

## Locked generation settings

Keep these identical for A and B:

- Model, LoRA file and LoRA weight
- Seed
- Sampler, steps and guidance
- Aspect ratio and output resolution
- Any negative prompt

Run each prompt with the same four seeds. This creates 24 images: 3 tests × 2 variants × 4 seeds.

Do not add phrases such as “Yu-Gi-Oh style,” “anime,” “trading-card artwork,” “digital painting,” “masterpiece” or quality tags. In this test, `hclar52` is the only style instruction.

---

## Test 1 — A.I.P Ex Shrieker

**Variable:** pose direction and focal placement  
**Locked:** creature anatomy, roar, room, debris, lighting and palette  
**Question:** Does an off-centre diagonal action read more like a finished card illustration than a centred frontal presentation?

### 1A — Centred frontal baseline

```json
{
  "high_level_description": "hclar52. A squat reptilian artificial beast stands frontally in the center of a damaged laboratory and releases a powerful sonic cry directly toward the viewer.",
  "compositional_deconstruction": {
    "background": "One broad cracked pale-green wall plane, a dark pipe bank and a soft cyan emergency lamp, rendered as subdued shapes with open space around the head.",
    "elements": [
      {
        "type": "obj",
        "desc": "The complete beast faces forward in a nearly symmetrical braced pose. It has segmented black-green hide, narrow restrained red channels, one orange eye on each side of its head, powerful forelimbs and an impossibly deep vertical mouth lined with irregular ivory fangs. Its open mouth occupies the center of the image."
      },
      {
        "type": "obj",
        "desc": "Compressed air, pale dust and several large translucent glass fragments spread evenly outward from the mouth while broken floor pieces sit beneath both claws."
      }
    ]
  }
}
```

### 1B — Off-centre diagonal challenger

```json
{
  "high_level_description": "hclar52. A squat reptilian artificial beast twists off-center in a damaged laboratory and releases a powerful sonic cry diagonally toward the upper left.",
  "compositional_deconstruction": {
    "background": "One broad cracked pale-green wall plane, a dark pipe bank and a soft cyan emergency lamp, rendered as subdued shapes with open space around the head.",
    "elements": [
      {
        "type": "obj",
        "desc": "The complete beast braces in an asymmetrical three-quarter pose and twists its head toward the upper left. It has segmented black-green hide, narrow restrained red channels, two orange eyes, powerful forelimbs and an impossibly deep vertical mouth lined with irregular ivory fangs. Its open mouth sits left of center."
      },
      {
        "type": "obj",
        "desc": "Compressed air, pale dust and several large translucent glass fragments travel in one diagonal cone from the mouth toward the upper-left edge while broken floor pieces sit beneath the unevenly planted claws."
      }
    ]
  }
}
```

**Predicted winner:** 1B. It should retain the mouth focal point while adding a directional read and unequal negative-space shapes.

---

## Test 2 — A.I.P Ex Larva

**Variable:** foreground scale anchor  
**Locked:** creature anatomy, pose, tray, room, viewpoint, lighting and palette  
**Question:** Does one cropped foreground prop add convincing card-art depth without stealing attention?

### 2A — Unobstructed foreground baseline

```json
{
  "high_level_description": "hclar52. A small pillbug-like artificial larva escapes from a cracked steel specimen tray on a laboratory workbench, seen from an oblique tabletop viewpoint.",
  "compositional_deconstruction": {
    "background": "Two broad shadowed cabinet shapes and one soft rectangular monitor glow form a subdued laboratory background with open space around the larva.",
    "elements": [
      {
        "type": "obj",
        "desc": "The larva bends into a shallow curve while climbing over the near edge of the diagonal tray. Seven overlapping black-green shell plates carry narrow glowing red seams; one recessed orange eye and many short hooked feet face the viewer in active motion."
      },
      {
        "type": "obj",
        "desc": "The lower foreground is an unobstructed continuation of the dim steel workbench. The bent tray corner and a small smear of translucent green nutrient gel remain secondary to the creature."
      }
    ]
  }
}
```

### 2B — Cropped forceps challenger

```json
{
  "high_level_description": "hclar52. A small pillbug-like artificial larva escapes from a cracked steel specimen tray on a laboratory workbench, seen from an oblique tabletop viewpoint.",
  "compositional_deconstruction": {
    "background": "Two broad shadowed cabinet shapes and one soft rectangular monitor glow form a subdued laboratory background with open space around the larva.",
    "elements": [
      {
        "type": "obj",
        "desc": "The larva bends into a shallow curve while climbing over the near edge of the diagonal tray. Seven overlapping black-green shell plates carry narrow glowing red seams; one recessed orange eye and many short hooked feet face the viewer in active motion."
      },
      {
        "type": "obj",
        "desc": "A single oversized pair of steel forceps enters from and is cropped by the lower-left foreground, its two tips pointing toward the larva without overlapping it. The bent tray corner and a small smear of translucent green nutrient gel remain secondary to the creature."
      }
    ]
  }
}
```

**Predicted winner:** 2B, provided the forceps remain visibly separate from the larva. The prop should create near/middle/far depth and immediately communicate the creature's tiny scale.

---

## Test 3 — A.I.P Ex Predator

**Variable:** background information density  
**Locked:** creature anatomy, pose, foreground paw, setting, weather, lighting and palette  
**Question:** Does grouping the laboratory and exterior into broad value masses improve subject separation?

### 3A — Descriptive environment baseline

```json
{
  "high_level_description": "hclar52. An enormous quadrupedal artificial predator stalks diagonally from a damaged laboratory breach into cold rain, viewed from ground level with one planted paw dominating the lower-right foreground.",
  "compositional_deconstruction": {
    "background": "The laboratory contains visible wall seams, pipes, hanging cables, broken observation windows, equipment cabinets, warning lamps, shattered panels and scattered fragments. Outside are rain-streaked industrial structures, puddles and distant towers, all visible around the creature.",
    "elements": [
      {
        "type": "obj",
        "desc": "The enormous low quadrupedal beast stalks diagonally forward. It has black-green armored hide, narrow restrained red channels, a wedge-shaped skull, two small orange eyes, layered dorsal spines, long forearms, four separated hooked claws on each paw and a trailing tail."
      },
      {
        "type": "obj",
        "desc": "One planted forepaw is foreshortened and partly cropped by the lower and right edges. Hot orange laboratory light strikes the beast from behind while cold blue-gray rain gives its head and back a narrow rim light."
      }
    ]
  }
}
```

### 3B — Broad-mass environment challenger

```json
{
  "high_level_description": "hclar52. An enormous quadrupedal artificial predator stalks diagonally from a damaged laboratory breach into cold rain, viewed from ground level with one planted paw dominating the lower-right foreground.",
  "compositional_deconstruction": {
    "background": "The environment is grouped into three quiet value masses: one broad orange laboratory opening behind the beast, one cool blue-gray rain field beside it and one dark wet ground plane below. A distant overturned containment cart is the only small background object, reduced to a simple silhouette.",
    "elements": [
      {
        "type": "obj",
        "desc": "The enormous low quadrupedal beast stalks diagonally forward. It has black-green armored hide, narrow restrained red channels, a wedge-shaped skull, two small orange eyes, layered dorsal spines, long forearms, four separated hooked claws on each paw and a trailing tail."
      },
      {
        "type": "obj",
        "desc": "One planted forepaw is foreshortened and partly cropped by the lower and right edges. Hot orange laboratory light strikes the beast from behind while cold blue-gray rain gives its head and back a narrow rim light."
      }
    ]
  }
}
```

**Predicted winner:** 3B. The two-color environment should frame the dark beast, while the single cart supplies scale without competing texture.

---

## Blind scoring sheet

Hide the A/B labels before choosing. Score every output from 0 to 2 in each category:

| Criterion | 0 | 1 | 2 |
|---|---|---|---|
| Thumbnail read | Confused | Readable after inspection | Immediate subject and action |
| Silhouette | Merged or generic | Mostly clear | Distinct and protected |
| Action | Static or ambiguous | Understandable | One forceful visual verb |
| Focal hierarchy | No focal point | Focal point competes | One dominant accent |
| Depth | Flat | Two readable planes | Strong near/middle/far structure |
| Background | Competes or feels empty | Serviceable | Supports subject and story |
| Anatomy | Broken | Minor errors | Coherent and intentional |
| Card-art character | Poster/concept-art feeling | Plausible | Convincing at card size |

Maximum: **16 points**.

For each matched seed, record:

```text
Test:
Seed:
A score: /16
B score: /16
Winner: A / B / tie
Largest visible difference:
Unexpected model behavior:
Keep, reject or retest the tested rule:
```

## Decision threshold

- Treat a difference of **0–1 points** as a tie.
- Treat **2–3 points** as a weak preference requiring another batch.
- Treat **4+ points** as a meaningful win for that seed.
- Promote a rule only when the same variant wins at least **three of four matched seeds** and improves the intended criterion without materially damaging anatomy or identity.


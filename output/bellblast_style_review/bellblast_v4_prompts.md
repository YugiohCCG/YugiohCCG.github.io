# Bellblast prompt revision — batch 2 review

Untested prompts. Reviewed 55 archive entries: 52 generated artworks and three filter placeholders. Compared with the actual training artwork in C:/Manual Files/New Documents/Yugioh/Models/yugioh_ideogram4_500_release/training, including ygo4_0021, ygo4_0231, ygo4_0268 and ygo4_0283. The dataset contains varied rendering approaches; these prompts target its illustrated humanoid combat subset.

The new oversized rookie results improve weapon scale. Repeated flared muzzle language produces trumpet-like tubes. Emi's proportions become much younger and rounder than Shiori's. Soft cylindrical highlights, bokeh and surrounding smoke arcs repeat across the batch. The classroom loading action frequently merges the shell, gun and desk; the revised quartermaster action is simpler. Keep the enormous scale, shared palette and school identity; emphasize substantial cylindrical launcher geometry, consistent character proportions, costume silhouette and distinct readable roles. These are prompt hypotheses, not demonstrated fixes to the checkpoint.

Paste only an individual JSON object into the structured prompt input. Warrior is a provisional archetype type, not inferred official metadata.

## Rika — Recoil Rookie

```json
{
  "high_level_description": "A Warrior-type MONSTER card artwork showing the following scene: a copper-haired academy girl is lifted off a rooftop by the recoil of a shoulder bazooka larger than herself.",
  "style_description": {
    "aesthetics": "playful fantasy academy combat, exaggerated weapon scale, expressive young adult anime characters with consistent slender proportions and elaborate uniform silhouettes",
    "lighting": "clear directional daylight, broad colored shadow shapes, restrained highlights on skin and sharp highlights along metal edges",
    "medium": "illustration",
    "art_style": "hclar52 card illustration, expressive hand-drawn anime anatomy, fine tapered linework, angular cel shading, selective painted transitions and richly painted backgrounds",
    "color_palette": [
      "#202C48",
      "#B92C3E",
      "#F3E8CE",
      "#D9AE50",
      "#65BCD0",
      "#444A61"
    ]
  },
  "compositional_deconstruction": {
    "background": "A tilted academy rooftop with blue slates, a cream clock tower and turquoise sky. A compact angular blast exits the left edge; scattered slate fragments and a short broken trail of pale exhaust follow the firing direction. The girl's face remains clear above the weapon.",
    "elements": [
      {
        "type": "obj",
        "bbox": [
          90,
          330,
          970,
          970
        ],
        "desc": "A young adult academy girl with pointed copper twin tails and a fierce delighted grin twists sideways in midair, knees tucked behind her. She wears a navy sailor jacket, oversized ivory collar, crimson ribbon, gold star clasp, pleated skirt, opaque tights and reinforced boots. Both gloved hands clutch her bazooka's grips."
      },
      {
        "type": "obj",
        "bbox": [
          200,
          0,
          660,
          1000
        ],
        "desc": "An absurdly enormous crimson shoulder bazooka extends diagonally across the foreground, longer than its wielder is tall and as thick as her torso. Its broad cylindrical bore sits inside a chunky ivory muzzle collar. Stepped armor plates, a navy shoulder cradle, brass fasteners and a gold star crest break up the massive tubular silhouette."
      }
    ]
  }
}
```

## Emi — Arsenal Prefect

```json
{
  "high_level_description": "A Warrior-type MONSTER card artwork showing the following scene: a green-haired academy quartermaster struggles to pull an enormous bazooka through the school on a tiny book trolley.",
  "style_description": {
    "aesthetics": "playful fantasy academy combat, exaggerated weapon scale, expressive young adult anime characters with consistent slender proportions and elaborate uniform silhouettes",
    "lighting": "clear directional daylight, broad colored shadow shapes, restrained highlights on skin and sharp highlights along metal edges",
    "medium": "illustration",
    "art_style": "hclar52 card illustration, expressive hand-drawn anime anatomy, fine tapered linework, angular cel shading, selective painted transitions and richly painted backgrounds",
    "color_palette": [
      "#202C48",
      "#B92C3E",
      "#F3E8CE",
      "#D9AE50",
      "#65BCD0",
      "#444A61"
    ]
  },
  "compositional_deconstruction": {
    "background": "An academy supply room with shelves of books and neatly stacked ammunition cases. The doorway frames pale cyan daylight. A few fallen exercise books mark the trolley's crooked route across the tiled floor. Crisp painted perspective keeps the little wheels, huge weapon and straining figure immediately readable.",
    "elements": [
      {
        "type": "obj",
        "bbox": [
          80,
          520,
          960,
          980
        ],
        "desc": "A young adult academy girl with a neat green bob, round spectacles and a stubborn frown leans forward, pulling a trolley handle with both gloved hands. She wears a navy sailor jacket, oversized ivory collar, crimson ribbon, gold star clasp, pleated skirt, opaque tights and reinforced boots. Her heels dig into the floor."
      },
      {
        "type": "obj",
        "bbox": [
          200,
          0,
          900,
          700
        ],
        "desc": "An absurdly enormous crimson bazooka rests diagonally on a tiny two-wheeled book trolley, dwarfing its frame. The torso-thick cylindrical launcher has a broad ivory muzzle collar, stepped armor plates, navy shoulder cradle, brass fasteners and a gold star crest. Its heavy rear nearly scrapes the floor while one trolley wheel lifts."
      }
    ]
  }
}
```

## Shiori — Corridor Warden

```json
{
  "high_level_description": "A Warrior-type MONSTER card artwork showing the following scene: a stern black-haired academy prefect blocks a staircase with a colossal bazooka held across her body.",
  "style_description": {
    "aesthetics": "playful fantasy academy combat, exaggerated weapon scale, expressive young adult anime characters with consistent slender proportions and elaborate uniform silhouettes",
    "lighting": "clear directional daylight, broad colored shadow shapes, restrained highlights on skin and sharp highlights along metal edges",
    "medium": "illustration",
    "art_style": "hclar52 card illustration, expressive hand-drawn anime anatomy, fine tapered linework, angular cel shading, selective painted transitions and richly painted backgrounds",
    "color_palette": [
      "#202C48",
      "#B92C3E",
      "#F3E8CE",
      "#D9AE50",
      "#65BCD0",
      "#444A61"
    ]
  },
  "compositional_deconstruction": {
    "background": "A broad academy staircase seen from slightly below, with ivory stone steps, navy railings and a large crimson school pennant. The weapon cuts across the ascending stair lines. A small pile of confiscated paper airplanes lies beside her boot, giving the imposing checkpoint a dry comic detail.",
    "elements": [
      {
        "type": "obj",
        "bbox": [
          50,
          300,
          990,
          850
        ],
        "desc": "A young adult academy girl with straight black hair, narrow focused eyes and a severe expression stands squarely on a stair landing. She wears a navy sailor jacket, oversized ivory collar, crimson ribbon, gold star clasp, pleated skirt, opaque tights and reinforced boots. A crimson prefect armband distinguishes her; both hands support her bazooka."
      },
      {
        "type": "obj",
        "bbox": [
          340,
          0,
          740,
          1000
        ],
        "desc": "An absurdly enormous crimson bazooka spans almost the entire staircase, its torso-thick cylindrical body visibly weighing against the prefect's shoulder brace. A deep circular bore faces left in three-quarter view. The broad ivory muzzle collar, stepped armor plates, navy cradle, brass fasteners and gold star crest match the academy's other launchers."
      }
    ]
  }
}
```

## Reina — Salvo Captain

```json
{
  "high_level_description": "A Warrior-type MONSTER card artwork showing the following scene: a silver-haired academy captain pivots with a colossal double-barreled shoulder bazooka as star-shaped energy gathers inside its muzzles.",
  "style_description": {
    "aesthetics": "playful fantasy academy combat, exaggerated weapon scale, expressive young adult anime characters with consistent slender proportions and elaborate uniform silhouettes",
    "lighting": "clear directional daylight, broad colored shadow shapes, restrained highlights on skin and sharp highlights along metal edges",
    "medium": "illustration",
    "art_style": "hclar52 card illustration, expressive hand-drawn anime anatomy, fine tapered linework, angular cel shading, selective painted transitions and richly painted backgrounds",
    "color_palette": [
      "#202C48",
      "#B92C3E",
      "#F3E8CE",
      "#D9AE50",
      "#65BCD0",
      "#444A61"
    ]
  },
  "compositional_deconstruction": {
    "background": "The academy clock tower rises behind an open rooftop, framed by turquoise sky and sharply painted white clouds. Two small golden charging flares illuminate the barrel interiors. A crimson pennant snaps along the opposite diagonal, counterbalancing the immense weapon while leaving the captain's face clearly silhouetted against the sky.",
    "elements": [
      {
        "type": "obj",
        "bbox": [
          40,
          360,
          990,
          980
        ],
        "desc": "A young adult academy captain with swept silver hair and a composed smile pivots toward the viewer, one boot planted forward. She wears a navy sailor jacket, oversized ivory collar, crimson ribbon, gold star clasp, pleated skirt, opaque tights and reinforced boots. Gold shoulder trim and a short crimson cape mark her rank."
      },
      {
        "type": "obj",
        "bbox": [
          180,
          0,
          760,
          940
        ],
        "desc": "An absurdly enormous double-barreled crimson bazooka rests in the captain's shoulder harness, wider than her torso and longer than her height. Two thick parallel launch tubes share one armored housing. Broad ivory muzzle collars, stepped plates, a navy cradle, brass fasteners and a prominent gold star crest unify its monumental silhouette."
      }
    ]
  }
}
```


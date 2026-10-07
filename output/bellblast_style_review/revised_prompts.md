# Bellblast revised structured prompts

Superseded v2 proposals. The user supplied 36 generations from these four prompts, alongside four earlier-prompt results. The v2 results did not achieve the desired style. See [the corrected results review](shared_results_review.md). Retained as an exact record of the inputs, not a recommended production pack.

Paste one JSON object into the existing structured prompt input. Keep your model, seed, sampler, guidance, resolution, LoRA setup and negative conditioning unchanged for the first comparison. The supplied objects already are structured prompts.

## 1. Bellblast Rookie - Rika

Replace the frontal toy-cannon cutout with a readable lateral recoil pose. Repeat a split-star motif through uniform and launcher.

Reference image IDs: ygo4_0021, ygo4_0231, ygo4_0283.

```json
{
  "high_level_description": "A Warrior-type MONSTER card artwork showing the following scene: a copper-haired schoolgirl swings a red shoulder bazooka toward the upper left while bracing one boot against a rooftop parapet.",
  "style_description": {
    "aesthetics": "spirited academy artillery, angular star motifs, a bold diagonal gesture with the face and sailor collar clearly visible",
    "lighting": "clear cool daylight, hard warm reflections on red metal, a small white discharge flash and deep blue shadows beneath the jacket",
    "medium": "illustration",
    "art_style": "hclar52 card illustration",
    "color_palette": [
      "#234F83",
      "#D63B43",
      "#F1EBDA",
      "#263047",
      "#EFBE48"
    ]
  },
  "compositional_deconstruction": {
    "background": "A pale turquoise sky fills the square to every edge behind slanting white clouds and fine golden discharge rays. A blue-gray school parapet crosses the lower right, with chalky dust lifting from the planted boot. Three loose sheets trail sideways through the recoil wake at different depths.",
    "elements": [
      {
        "type": "obj",
        "bbox": [
          80,
          250,
          980,
          970
        ],
        "desc": "A copper-haired schoolgirl with swept pointed twin-tails and a determined sideways smile twists her torso left. Her navy sailor jacket has an ivory angular collar, red split-star neck ribbon and flared cuffs. A pleated skirt, opaque tights, red-trimmed boots and square schoolbag complete the uniform. Both hands brace the shoulder launcher; her forward boot presses against the parapet."
      },
      {
        "type": "obj",
        "bbox": [
          180,
          30,
          550,
          780
        ],
        "desc": "A long red shoulder bazooka angles upward to the left, showing its broad side panel and a narrow oval muzzle. Stepped ivory plates, dark rectangular vents and a gold split-star sight echo the uniform. A schoolbag-style strap loops underneath. The rear rests against her right shoulder while the grips remain below her unobscured face."
      }
    ]
  }
}
```

## 2. Bellblast Quartermaster - Emi

A composed reload identity with a full graphic background, not a detailed music-room diorama or a display of a separate weapon.

Reference image IDs: ygo4_0128, ygo4_0268.

```json
{
  "high_level_description": "A Warrior-type MONSTER card artwork showing the following scene: a bespectacled schoolgirl slides a luminous shell into the open breech of an upright shoulder bazooka beside her unfolded schoolbag.",
  "style_description": {
    "aesthetics": "precise, self-assured academy artillery, elegant vertical silhouette, repeated split-star and cartridge shapes",
    "lighting": "cool mint ambient light with narrow gold metal highlights and localized amber shell light across the gloves",
    "medium": "illustration",
    "art_style": "hclar52 card illustration",
    "color_palette": [
      "#23483F",
      "#DBEAD9",
      "#273047",
      "#D4AB55",
      "#BA4149"
    ]
  },
  "compositional_deconstruction": {
    "background": "An opaque mint and deep-green magical backdrop fills the square. Broad diagonal bands resembling folded notebook corners alternate with thin gold trajectories and tiny diamond sparks. The pale central region separates the dark uniform, while darker green planes continue beyond all four edges.",
    "elements": [
      {
        "type": "obj",
        "bbox": [
          60,
          280,
          980,
          830
        ],
        "desc": "A green-haired schoolgirl with a blunt bob and narrow round spectacles stands with one knee slightly bent. Her navy sailor jacket has an ivory angular collar, red split-star ribbon and white gloves. A pleated skirt, opaque tights and brass-buckled boots complete her uniform. One hand steadies the upright launcher while the other slides a shell into its breech."
      },
      {
        "type": "obj",
        "bbox": [
          90,
          80,
          940,
          480
        ],
        "desc": "A tall forest-green bazooka stands beside the girl with its muzzle pointing upward and the rear braced near her boot. Stepped ivory plating surrounds an open rectangular breech. A gold split-star sight and dark cooling slots repeat the academy equipment motif. One amber-tipped cartridge is halfway inside the side opening."
      },
      {
        "type": "obj",
        "bbox": [
          670,
          640,
          970,
          980
        ],
        "desc": "An unfolded navy schoolbag rests beside the girl, its rigid interior holding three large ivory cartridges in dark fitted sleeves. The flap bears a small gold split-star clasp. One empty sleeve and a loose red carrying strap make the bag read as equipment currently being used."
      }
    ]
  }
}
```

## 3. Bellblast Hall Monitor - Shiori

Make discipline legible through posture, directional blast and matching equipment rather than a huge blank shield hiding the character.

Reference image IDs: ygo4_0268, ygo4_0283, ygo4_0470.

```json
{
  "high_level_description": "A Warrior-type MONSTER card artwork showing the following scene: a dark-haired schoolgirl slides into a defensive stance and fires a shield-braced bazooka sideways across a school corridor.",
  "style_description": {
    "aesthetics": "stern, forceful academy artillery, angular defensive silhouette and a sharply directed burst",
    "lighting": "cold window light with a concentrated yellow-white muzzle flash, blue garment shadows and crimson equipment reflections",
    "medium": "illustration",
    "art_style": "hclar52 card illustration",
    "color_palette": [
      "#263C68",
      "#DDEBF0",
      "#B73249",
      "#E3B74C",
      "#708AA6"
    ]
  },
  "compositional_deconstruction": {
    "background": "A tilted blue school corridor continues to the edges, its broad windows and floor seams converging toward the upper right. White pressure streaks cut horizontally across the space from the weapon. A fan of floor dust follows the sliding boot; distant door shapes remain simple and clearly drawn.",
    "elements": [
      {
        "type": "obj",
        "bbox": [
          70,
          320,
          980,
          960
        ],
        "desc": "A long dark-haired schoolgirl with narrow focused eyes braces in a wide sideways stance. Her navy sailor jacket has an ivory angular collar, red split-star ribbon and crimson armband. A pleated skirt, opaque tights and squared boots complete the uniform. Her torso and stern face remain visible above the launcher, with both hands locked around its grips."
      },
      {
        "type": "obj",
        "bbox": [
          310,
          10,
          720,
          780
        ],
        "desc": "An ivory shoulder bazooka points toward the left edge, its narrow barrel supported by a navy folding shield plate beneath the foregrip. Two angular shield wings resemble a split school ribbon. Red reinforcement bars and a gold star-shaped sight link it to the uniform. A short jagged white flash exits the muzzle."
      }
    ]
  }
}
```

## 4. Bellblast Captain - Reina, Final Bell

Escalate the same uniform-and-launcher design into a boss image. One captain and an asymmetrical pair of long weapons, rather than six repeated tubes around a small central figure.

Reference image IDs: ygo4_0112, ygo4_0231, ygo4_0283.

```json
{
  "high_level_description": "A Warrior-type MONSTER card artwork showing the following scene: a silver-haired schoolgirl captain turns above a school bell tower with two linked bazookas unfolding around her as golden discharge paths sweep across the sky.",
  "style_description": {
    "aesthetics": "commanding academy artillery, sweeping asymmetry, a prominent face framed by long angular weapon silhouettes",
    "lighting": "brilliant gold discharge light against saturated blue sky, crisp ivory armor highlights and deep violet cloth shadows",
    "medium": "illustration",
    "art_style": "hclar52 card illustration",
    "color_palette": [
      "#243D88",
      "#E8ECF2",
      "#CC354D",
      "#F0C353",
      "#563C76"
    ]
  },
  "compositional_deconstruction": {
    "background": "A deep cobalt sky fills the image, crossed by long white cloud streaks and two curved gold discharge paths. A school bell tower rises from the lower left, its bronze bell catching the same gold light as the equipment. Rays and clouds continue beyond the square, with a pale opening behind the captain’s face.",
    "elements": [
      {
        "type": "obj",
        "bbox": [
          80,
          280,
          970,
          910
        ],
        "desc": "A silver-haired schoolgirl captain turns left with an assured expression and one knee raised. Her navy sailor jacket carries an oversized ivory collar, crimson split-star ribbon and narrow gold shoulder trim. A pleated skirt, opaque tights and ivory-cuffed boots preserve the academy uniform. Long ribbon tails stream behind her as both hands control separate launcher grips."
      },
      {
        "type": "obj",
        "bbox": [
          180,
          0,
          690,
          850
        ],
        "desc": "A long ivory and crimson bazooka crosses below the captain’s face toward the left edge, presenting stepped side armor rather than an enlarged circular opening. A split-star gold sight rises above dark cooling slots. Its rear joins a compact navy schoolbag harness through one articulated brass support."
      },
      {
        "type": "obj",
        "bbox": [
          30,
          560,
          800,
          990
        ],
        "desc": "A second matching bazooka unfolds behind the captain’s opposite shoulder, angled upward toward the right. Its smaller visible muzzle and receding ivory panels establish depth. Crimson stabilizer fins open like pointed ribbon ends, while one curved brass arm links the rear chamber to the same compact backpack harness."
      }
    ]
  }
}
```

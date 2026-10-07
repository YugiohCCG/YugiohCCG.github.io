# Bellblast: reference audit and revised art direction

**Superseded dataset diagnosis:** This report inspected an older workspace copy. The user identified the actual release at `C:\Manual Files\New Documents\Yugioh\Models\yugioh_ideogram4_500_release\training`. That release has 500 JSON captions and 500 distinct decoded RGB images; 79 files differ from the old copy. The missing-caption and duplicate findings below do not describe the training release. The v2 prompts have now been tested in the user's 40-image batch and did not achieve the desired style. See [the corrected results review](shared_results_review.md).

Date: 2026-09-06. Scope: the 500 images currently present in `output/yugioh_ideogram4_500/images`, compared visually with the three results attached in the conversation. This is an art-direction audit, not a measurement of model performance.

## What was actually reviewed

- All 500 images were decoded and visually reviewed on 20 contact sheets, 25 images per sheet, at approximately 292 pixels per artwork. This establishes broad composition and design patterns; it does not establish full-resolution fine-detail QA for every image.
- Eight relevant images were additionally inspected individually at 1024 pixels: 0021, 0025, 0112, 0128, 0231, 0268, 0283 and 0470. See [the reference board](relevant_reference_board.jpg).
- The local manifest labels the set as 300 Monsters, 120 Spells and 80 Traps. These are administrative labels, not newly verified card identities. References in this review use dataset IDs to avoid relying on potentially stale name mappings.
- All 500 files decode as 1024 x 1024 RGB. There are 495 unique decoded RGB images and five exact duplicate pairs: 0270/0271, 0357/0358, 0386/0387, 0424/0425 and 0427/0428. Further visually similar pairs exist; this pass does not supply a calibrated near-duplicate count.
- The local `captions` folder contains zero JSON captions. A release checksum is present, but the release archive and actual training captions were not available in the inspected output locations. These findings cannot establish what the trained checkpoint saw.
- The supplied generation screenshots are visually available, but their original files, alpha channels, conditioning and generation settings are not established. A visible checkerboard cannot distinguish a transparency preview, a generated checkerboard, or later background removal.

## The main finding

The outputs already contain some relevant rendering cues: outlined anime faces, flat color regions with shaded volume, exaggerated perspective and a readable character silhouette. Calling every part of them non-Yu-Gi-Oh would be inaccurate. The larger mismatch is the combination of an ordinary uniform, a huge cylindrical toy-like launcher, a repeated suspended pose and a background that contributes little or nothing to the composition.

There is no single drawing recipe across the 500 references. The set includes angular mechanical designs, soft painterly human figures, flat comic mascots, ornamental portraits, quiet environments and dense combat images. The useful target for this archetype is the subset of stylized human combatants with themed clothing and equipment. Averaging the whole set into "polished anime illustration" loses the distinctions that matter.

## Why the earlier prompts led in the wrong direction

| Earlier instruction or result | What the images show | Revision |
| --- | --- | --- |
| Enormous hexagonal muzzle, enlarged foreground barrel | The muzzle is the largest simple high-contrast shape. It hides the torso and turns the character into an accessory to a cannon. | Use a long side-visible bazooka and an oblique opening. Preserve the face, collar, gripping hands and torso gesture. |
| Ordinary navy blazer, sweater and trainers | The school identity is obvious, but it shares little shape language with the weapon. | Make the sailor collar, ribbon, cuffs, bag clasp, weapon fins and sight repeat one angular split-star motif. Keep the costume recognizably a school uniform. |
| Many rings, brass bands, glass chamber and star flash | The smoothly shaded repeated cylinders resemble a colorful toy prop. | Use stepped side plates, a few purposeful vents, a clear shoulder support and an asymmetric sight. Reserve smooth curves for parts that need them. |
| Lifted backwards, one shoe toward the viewer | The same floating forward-facing pose recurs. The enlarged sole and muzzle compete while the hands struggle to explain the load. | Give each student a different job and pose: braced shot, vertical reload, lateral defense and turning captain. |
| Spiral of homework around the character | Papers form a decorative wreath and reinforce the sticker-like outline. | Use a few unequal sheets in a directional wake, or omit them. |
| Subdued distant rooftop, minimal background detail | First result has a cyan halo surrounded by near-black space; two show a checkerboard. The intended school setting is almost absent. | Describe what actually fills the complete background: sky and rays, drawn graphic planes, or a corridor. Background detail can be simple while still being compositionally active. |
| "Crisp expressive anime linework", "polished rendering" and similar repeated style prose | These descriptions are compatible with many anime illustration traditions and do not specify this archetype's design. Their actual effect on this checkpoint is untested. | Keep `art_style` to the established `hclar52 card illustration` baseline for this revision. Use the other fields for concrete visible design. |

These are prompt-design hypotheses supported by the images, not a controlled demonstration of which token caused which output. In particular, the checkerboard should not be blamed on the LoRA or prompt until the raw generation path is known.

## Specific reference evidence

| Image | Visible evidence | Application |
| --- | --- | --- |
| 0021 | A uniform, helmet, equipment, hoses and ribbon reuse their colors and forms; the background flag carries the theme across the square. | Build the outfit and launcher together. An ordinary setting can become a strong graphic shape. |
| 0025 | An oversized mechanical prop and foreshortened figure are successful while the face and raised hand remain legible; the red graphic background reaches the edges. | Large equipment is allowed. It needs an intentional relationship with the figure, not automatic removal. |
| 0112 | A broad side-visible firearm shares colors and angular structure with its wielder. Energy crosses in front of and behind the weapon. | Show the bazooka's characteristic side silhouette and use overlap to join the composition. |
| 0128 | A poised figure has angular hat, collar, bow, boots and staff; an abstract geometric background provides a complete image. | Not every Monster needs a literal narrative incident or a detailed room. A reload portrait can work. |
| 0231 | Hair, sleeves, body twist and weapon follow a coherent gesture; the environment and airborne fragments reinforce it. | A braced or turning schoolgirl can feel energetic without a head-on muzzle or a foot pointed at the camera. |
| 0268 | A largely static figure still has a strong recurring insignia, purposeful garment shape, clear highlights and a complete graphic backdrop. | A confident still pose is valid. The earlier universal "one card = one event" rule was too rigid. |
| 0283 | Broad angular costume shapes, selective outlines and relatively simple shading frame a clear face and gesture. | "More detail" is not the answer. Concentrate design into a few recognizable forms. |
| 0470 | A directional attack connects hands, face, beam, wind and background streaks; the bright effect is cropped by the artwork boundary. | A lateral shot can make the discharge powerful without filling most of the square with the muzzle. |

At full size these references also show varied line weight, sharper shadow shapes on angular forms, and narrow material highlights. The generated examples rely more heavily on long smooth gradients across large rounded gun surfaces. That difference partly follows the chosen geometry. Simply adding "cel shading" will not fix the design, and glossy shading, soft painting, rim light and oversized weapons all occur in the reference set.

## Coverage log for all 500 images

Each row records observations from the corresponding complete 25-image contact sheet; it is not a numerical style classification.

| Range | Observations relevant to the audit |
| --- | --- |
| 0001-0025 | Hooded portrait, watery mascots, comic animal designs and mechanical human figures coexist. Decorative and action backgrounds are both legitimate; 0021 and 0025 provide strong costume-equipment examples. |
| 0026-0050 | Dinosaur and dragon designs mix broad organic curves with angular armor. Several claws and weapons reach the edge; rays and elemental effects support these silhouettes. |
| 0051-0075 | Painterly landscapes, graphic mascots, coiled creatures and ornate bosses vary greatly. Requiring sharp cel shading or an action incident for all images would contradict this sheet. |
| 0076-0100 | Humanlike fairies reuse clothing and accessory shapes; several backgrounds are ornamental. Fiends use stronger dark/light masses and energy. Symmetry exists and is not intrinsically a failure. |
| 0101-0125 | Humanlike combatants, armored monsters and fish demonstrate deliberate focal placement and shaped lighting. 0112 keeps a large weapon readable by showing its side and integrating its effects. |
| 0126-0150 | Witches, knights, skeletal creatures, masks and insect designs use very different rendering. Iconic portrait poses remain convincing through costume motifs and designed backdrops. |
| 0151-0175 | Mechanical subjects use purposeful plate breaks, joints and weapon attachments; toy-like and chibi designs also occur. Those lighter styles are valid but a different target from the requested academy combatants. |
| 0176-0200 | Armored machines contrast with delicate floral figures and elemental warriors. Costume, tools and environment repeat theme-specific shapes. Some neighboring images appear nearly identical. |
| 0201-0225 | Elemental armored figures, serpents and comic creatures mix saturated and subdued treatments. Large silhouette changes distinguish roles more effectively than accumulating tiny fittings. |
| 0226-0250 | Sea creatures and human Spellcasters show ornate silhouettes, close character pairs, environmental action and quiet magical presentation. 0231 demonstrates coherent human motion and weapon use. |
| 0251-0275 | Human costumes range from flowing robes to uniforms. 0268 shows a simple stance with a strong uniform identity and active graphic background; 0270/0271 are an exact repeat. |
| 0276-0300 | Human combatants, machine birds, mythic figures and undead range from icons to cinematic compositions. 0283 has particularly clear angular clothing and expressive gestural framing. |
| 0301-0325 | Continuous Spells include object portraits, scenes, landscapes and elemental processes. They must not all be used as models for how to frame an individual Monster. |
| 0326-0350 | Equipment portraits and interactions transition to Field Spell locations. Architecture can carry the whole composition when the subject is the place; it need not do so for a student Monster. |
| 0351-0375 | Objects, rituals, portraits and combat effects alternate. Directional streaks, hands and environmental overlap make interactions legible; 0357/0358 are exact repeats. |
| 0376-0400 | Magical objects, landscapes, laboratory scenes and attacks show broad scene variety. Powerful effects can be very large when they are the actual subject of the artwork. |
| 0401-0425 | Close human interactions, active attacks, rituals and large-scale scenes vary in subject size. Distance and tiny figures sometimes communicate scale; this should not become a default for the captain. |
| 0426-0450 | Graphic effects, comic scenes and counteractions use very different treatments. Several bright full-background effects demonstrate that background presence does not require realistic scenery. |
| 0451-0475 | Portrait interactions, beams, mechanisms and duels often make the action direction explicit. 0470 is useful for a sideways bazooka shot with face and hands preserved. |
| 0476-0500 | Large energy events, chambers, character pairings and symbolic imagery coexist. Dark backgrounds are valid when shaped and purposeful, not simply a vignette surrounding an isolated subject. |

## Revised direction and deliverables

The new design keeps schoolgirls and shoulder bazookas as the premise. It gives the club an angular ivory sailor collar, navy uniform, crimson split-star ribbon, square schoolbag, and matching split-star launcher hardware. Character roles alter the silhouette and pose without discarding the shared uniform.

The four rewritten prompts are in [revised_prompts.md](revised_prompts.md), the full pack is [bellblast_ideogram4_prompts_v2.json](bellblast_ideogram4_prompts_v2.json), and the individual paste-ready objects are `01_prompt.json` through `04_prompt.json`.

The established schema and key order are retained, with names outside model text, one lowercase trigger occurrence in `art_style`, normalized `[y_min,x_min,y_max,x_max]` boxes, canonical Monster openings and 30-60-word object descriptions. These checks passed; see [prompt_validation.json](prompt_validation.json). Independent large launchers retain separate elements for spatial control; this is allowed by the local specification. Whether one unified figure-and-weapon element would work better remains an experiment, not an established fix.

## How to assess the next result

Start with the revised rookie and keep the generation setup unchanged so prompt changes can be compared. No new negative prompt or guidance recommendation is bundled into this revision. Use the same seed if the current workflow supports it; otherwise compare a small matched batch.

Inspect the raw complete artwork before any optional cutout operation. At thumbnail size, check whether the face and uniform identity read immediately, the weapon shows a recognizable side profile, the hands and shoulder explain its support, the background fills the image purposefully, and effects follow the pose. At full size, check gripping anatomy, plate construction and shadow treatment.

If the raw result is still a cutout or black vignette, first inspect the actual encoded prompt and background-related pipeline steps. If the raw composition improves but rendering remains off target, compare the same simple prompt with and without the actual loaded LoRA while retaining the other settings. Do not infer a training failure from the three screenshots or assume the existing A.I.P workflow is the one used here.

The rewritten prompts have not been rendered or visually validated. This audit establishes a better-supported direction and concrete test inputs; it does not establish that the output now matches the target style.

# Bellblast experiment review and V6 decisions

Reviewed 9 contact sheets covering all 72 entries in the JupyterLab review folder: ComfyUI_00516_ through ComfyUI_00555_ plus 32 labeled B/L/S outputs. There are 64 artwork images and 8 filter placeholders. The labeled batch contains 27 artwork images and 5 placeholders. Placeholders are recorded as unavailable visual results, not assigned an artistic score or an inferred cause.

## Findings that inform the new characters

| Evidence | Assessment | V6 decision |
|---|---|---|
| S08_Reina, both seeds | Strongest pair for immense shoulder-mounted equipment: substantial weapon mass, clear face, diagonal staging and filled scenery. Hands and load-bearing details still need review at full size. | Use shoulder staging for Nao, with a distinct single launcher and signal-officer role. |
| S04_Emi, both seeds | The runaway trolley gives an understandable event and directional movement. One image has a conspicuous outline around the figure; this is not a universal rendering solution. | Give Momo a simple trolley-steering action with one small chemistry feature, rather than a difficult shell-loading interaction. |
| L01-L04, both seeds | All 8 entries contain artworks with complete environmental backgrounds. Faces and metal remain somewhat glossy, but the scene is consistently readable. | Reuse the exact diffuse-daylight wording. This is a useful observed direction, not proof that lighting alone caused the result. |
| B01-B04 | Only 3 of 8 entries provide artwork; the other 5 are placeholders. B02's completed image handles weapon size and trolley contact well. This does not establish that removing boxes is superior. | Retain boxes as explicit composition guidance. Do not declare the no-box variant a winner. |
| S01, S02, S03 and S07 | Seven of these eight entries show conspicuous checkerboard, white cutout areas or letterboxing. S02's second seed has a coherent scene. | Explicitly describe a continuous painted environment reaching all four edges. This is a prompt hypothesis to test. |
| S05_Shiori | First seed duplicates the character at different scales; the second makes her look much younger. | Specify one young adult heroine; avoid using a quiet prop-display composition for this trio. |
| S06_Shiori | Action varies, but some launchers become too thin to convey the intended comic weight. | Keep explicit torso thickness as well as weapon length. |
| ComfyUI_00535_ / 00536_ / 00537_ / 00542_ | Ivory fins, stepped armor and repeated star ornament give the weapon a more deliberate fantasy identity. Some other examples still become symmetric tubes or detached-looking props. | Preserve thick circular bores, shoulder cradles and limited ornamental details. Use different small equipment details for each new role. |

## Comparison limits

The actual metadata summary confirms all 72 entries use Euler and CFG 4. The 32 labeled experiments use the intended two seeds, 751299600367585 and 751299600367586. Earlier unlabeled rendering/weapon examples use different seeds. The 72-entry collection begins partway through the earlier rendering experiments, so it is not a complete matched rendering comparison. The strongest observations concern composition, repeated defects and successful individual pairs; a precise causal ranking of all rendering phrases is not supported.

The official humanoid-combat references previously inspected in the actual training set, including ygo4_0021 and ygo4_0231, show how costume shapes, equipment silhouette, readable anatomy and environmental action work together. The new outputs improve weapon identity, but the common glossy cylindrical highlights, repeated turquoise skies and generic garment treatment still prevent a clean claim that the style target is solved.

## Three new characters

- N01 Nao, Signal Officer: long slate-blue braid, amber eyes, gold headset, huge signal bazooka raised from a clock-tower balcony.
- N02 Momo, Chemistry Quartermaster: dusty-pink bun, green eyes, brass goggles, gigantic alchemical bazooka on a tiny laboratory trolley.
- N03 Aya, Hurdle Gunner: violet ponytail, warm brown skin, athletics pose, torso-thick bazooka carried across a training hurdle.

All use navy sailor jackets, large ivory collars, crimson ribbons, gold star clasps, pleated skirts, opaque tights and reinforced boots. Their launchers share crimson cylinders, ivory muzzle collars, navy armor and brass fittings. Prompts preserve the existing JSON schema and exactly one hclar52 trigger.

Six generation jobs were accepted in the browser, one per character at each of the two seeds. At submission verification: one running and five queued. Output prefix: ComfyUI/output/BellblastV6. Generation uses the prior Quality workflow, the 3500 LoRA at 1.0 on both branches, Euler, CFG 4 and the existing square 2-megapixel resolution selector. No new images had finished when this submission record was written.

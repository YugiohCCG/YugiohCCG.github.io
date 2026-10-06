# Corrected training-data and shared-results review

This supersedes the dataset diagnosis and recommendations in `analysis.md`. The user's actual training release is `C:\Manual Files\New Documents\Yugioh\Models\yugioh_ideogram4_500_release\training`. The supplied results are the 40 PNGs in `C:\Users\hclar\Downloads\Untitled Folder.zip`.

## Correction to the earlier review

The actual release contains 500 PNGs, 500 parseable JSON captions and 500 distinct decoded RGB images. There are no exact decoded RGB duplicates. All images are RGB. A comparison with the old workspace copy found 421 pixel-identical images and 79 different images. The 421 identical images were covered by the previous visual pass; all 79 different release images have now been reviewed on four additional contact sheets. Contact sheets for all 500 release images are also saved under `actual_training`.

The earlier missing-caption and duplicate claims applied only to the stale workspace copy. They must not be used to diagnose this training run. The preceding report is marked superseded, and the v2 pack is marked tested without meeting the style target.

The checkpoint file named in the generations exists in the supplied Models directory. Its safetensors metadata reports step 3500, epoch 7, the model family `ideogram4`, and trigger `hclar52`. The bundled YAML specifies a 1000-step configuration, while the checkpoint metadata and saved samples show later training. The YAML therefore is not sufficient evidence of the complete settings actually used for the step-3500 checkpoint.

## Review of all 40 supplied results

All 40 images were inspected on four contact sheets; 00452, 00460, 00472 and 00482 were additionally inspected individually. Each PNG's embedded prompt graph and UI workflow were extracted for inspection, not executed. Source files were preserved.

| Files | Input group | Visible result |
| --- | --- | --- |
| 00446-00449 | Earlier rookie prompt, four results | Oversized cylindrical muzzle dominates. Three images visibly contain a checkerboard; the fourth uses a heavy dark vignette around a cyan halo. |
| 00450-00457 | v2 rookie, eight results | Face and uniform are more visible, and the backdrop is filled. The weapon often becomes a long plain rectangular box. The pose remains illustrative rather than convincing recoil; 00452 places a flash near the rear and has unclear weapon use. Broad mint background planes and a narrow ledge leave little interaction with the setting. |
| 00458-00465 | v2 quartermaster, eight results | All eight retain the same basic girl/vertical weapon/bag display arrangement. The intended loading gesture is weak or absent. Repeated mint-green diagonal bands look like presentation graphics, and the girl, weapon and bag read as separately arranged objects. |
| 00466-00473 | v2 hall monitor, eight results | Corridor and firing direction are present. The bazooka often becomes a slender rifle-like tube with a ribbon-shaped attachment. The figure is posed across an otherwise empty corridor, with thin white streaks and a small muzzle flash carrying most of the action. |
| 00474-00481 | v2 captain at base CFG 4, eight results | Two large weapons and a silver-haired student are present, but the weapons repeatedly dominate. The bell tower becomes a small isolated prop or short pedestal. Gold arcs decorate the sky without strongly explaining the movement. |
| 00482-00485 | v2 captain at base CFG 6, four results | The same general visual treatment persists. Different seeds prevent a clean causal comparison with CFG 4. The batch does not establish that CFG 6 improves the style. |

The revision corrected some placement problems without achieving the requested artwork style. It also weakened the original bazooka identity by overemphasizing long narrow side profiles and rectangular plates. That tradeoff was a mistake in the art direction, not evidence that the user applied the prompts incorrectly.

## What the embedded workflows establish

- The manually entered strings parse as JSON objects. Their summaries correspond to the prompts supplied in this conversation.
- The switch chooses the manual JSON input, which connects to the positive `CLIPTextEncode` node. The natural-language JSON generation branch is not the selected positive prompt source.
- The configured text encoder is `qwen3vl_8b_fp8_scaled.safetensors` with type `ideogram4`.
- Both conditional and unconditional model branches include `Ideogram4_Yugioh_hclar52_r32_v1_000003500.safetensors` at strength 1.0. The metadata establishes the configured file names and routing; it does not verify runtime weight hashes.
- All outputs are 1456 x 1456 RGB. The image-writing path is `VAEDecode` directly to `SaveImage`. There is no background-removal node on that path. The checkerboards in the original four-result group are baked into the saved RGB pixels, not an alpha-channel preview in these PNGs.
- The sampler selector is Euler. The graph selects the 48-step Quality preset, routes through a simple scheduler and `ExtendIntermediateSigmas`, and applies a sampling shift of 7. The graph has a late `CFGOverride` configured to 3.5; base guider CFG is 4 for 00446-00481 and 6 for 00482-00485.
- These are observations of the saved graph, not recommendations to change sampler settings. No workflow, checkpoint or training-data mutation was made.

There is no evidence here of malformed pasted JSON, a missing trigger, a LoRA omitted from one branch, or a background-removal step causing the observed failure.

## What the real captions change about the diagnosis

All 500 captions include descriptive rendering prose after `hclar52 card illustration`; none uses that phrase alone. The v2 rewrite removed that prose based on an untested assumption that the trigger alone would be sufficient. The result does not justify that assumption. Restoring a relevant training caption's wording is a more grounded baseline, although it does not guarantee style reproduction.

The actual caption for image 0231 describes the girl and oversized war hammer as one coherent object, with one nearly full-image box. Image 0021 similarly keeps its character and held equipment in one object. Image 0112 separately describes its firearm, so there is no universal rule that separate weapon elements are wrong. For the next narrow test, the single-object pattern is useful because the failed quartermaster and captain layouts treat equipment as independent display pieces.

The problem is not solved by forcing all images into a particular line weight or banning gradients. The real captions explicitly describe smooth gradients, airbrushed effects, vector-like contours and painterly backgrounds in different references. The targeted human-action subset combines expressive figures, integrated equipment and environments more successfully than the shared results.

## Evidence beyond the Bellblast prompts

The five saved samples labeled step 3500 were inspected individually. The mechanical centipede scene integrates its subject with broken columns and clouds. The imp scene, however, puts an entire kitchen into an isolated rounded display on white. The ice-knight sample has smooth reflective surfaces and a posed figure against a repeated crystalline halo. These latter tendencies resemble some of the Bellblast failures.

The ice-knight samples labeled steps 250, 1000, 2000 and 4750 were also inspected. They vary in anatomy and details, and early examples contain unwanted lettering. None supplies a controlled proof that switching checkpoints alone will solve the current style mismatch. Their original runtime settings are not fully established by the JPEGs.

This evidence makes the earlier assertion that the issue was mainly prompt composition too strong. Prompt content clearly affects layout, but rendering and scene-integration weaknesses also occur in saved training samples. The current material cannot isolate base-model tendencies, learned style, caption conditioning and inference settings as independent causes. It does not justify a retraining prescription or a promise that more prompt adjectives will fix the images.

## A narrower next comparison

Prepared two native JSON objects:

1. [Exact reference control](reference_control_0231.json): the actual caption for training image 0231, preserved in content, schema and box coordinates. Its reference image remains in the training folder. This is a style and composition control, not a promise of exact image reconstruction.
2. [Schoolgirl adaptation](rookie_reference_adaptation_v3.json): the same basic caption pattern and rendering description, adapted to a schoolgirl and shoulder bazooka in an academy courtyard. The girl and held launcher are a single object. It removes the micro-specified weapon plates, independent prop boxes, decorative background bands and the repeated star hardware. It is an untested candidate, not a replacement production pack.

The first comparison should keep the actual generation setup and seed fixed and change only the positive prompt between the two objects. Do not compare 2048-pixel output or newly chosen CFG values while also changing the prompt. The release image being 1024 pixels does not by itself prove that the current 1456-pixel setting is wrong.

If the reference control itself retains the unwanted generic rendering, further lore and equipment embellishment is not a useful diagnostic. A subsequent identical-prompt, identical-seed LoRA on/off comparison would help measure what the LoRA contributes. If the reference control is convincing but the schoolgirl adaptation drifts, that points toward the adapted concept and conditioning rather than automatically toward training failure. Either result is more informative than another large four-character batch.

Neither comparison has been rendered by the assistant. No new generation, checkpoint changes, training edits or inference-setting changes were performed.

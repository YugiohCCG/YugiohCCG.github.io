# Ideogram 4 Yu-Gi-Oh Dataset Caption and Validation Specification

Status: production specification for the 500-image style-LoRA dataset  
AI Toolkit source audited: `ostris/ai-toolkit` main commit `5497a001cb8752c665f93907a0393fc612116fd5`  
Date audited: 2026-08-28

## 1. Canonical training artifact

Each training image has one same-stem JSON sidecar. The editable sidecar may be
pretty-printed UTF-8 JSON. AI Toolkit minifies valid structured captions before
Ideogram encoding. The validator MUST additionally produce and hash the exact
model string using:

```python
json.dumps(caption, ensure_ascii=False, separators=(",", ":"))
```

Never put `aspect_ratio` in a stored training caption. Never use Markdown fences,
comments, HTML entities, escaped field names, trailing commas, NaN, or Infinity.

## 2. Exact schema and key order

Key order is semantically important for Ideogram 4. Reject unknown keys rather
than preserving them, even though AI Toolkit's normalizer currently preserves
extras at the end.

```json
{
  "high_level_description": "...",
  "style_description": {
    "aesthetics": "...",
    "lighting": "...",
    "medium": "illustration",
    "art_style": "hclar52 card illustration, ...",
    "color_palette": ["#RRGGBB"]
  },
  "compositional_deconstruction": {
    "background": "...",
    "elements": [
      {
        "type": "obj",
        "bbox": [0, 0, 1000, 1000],
        "desc": "..."
      }
    ]
  }
}
```

Required for this dataset, even where Ideogram permits omission:

1. Top level, in order: `high_level_description`, `style_description`,
   `compositional_deconstruction`.
2. `style_description`, in order: `aesthetics`, `lighting`, `medium`,
   `art_style`, `color_palette`.
3. `compositional_deconstruction`, in order: `background`, `elements`.
4. Object element, in order: `type`, optional `bbox`, `desc`, optional
   `color_palette`.
5. Text element, in order: `type`, optional `bbox`, `text`, `desc`, optional
   `color_palette`.

For this artwork-only dataset, `medium` MUST be `illustration` and `art_style`
MUST be present; `photo` MUST be absent. If a candidate is genuinely a 3D render,
painting, photograph, or graphic design rather than an illustration, flag it for
curation instead of silently changing the medium.

Although the official schema allows per-element palettes (maximum five colors),
AI Toolkit's current image-caption prompt deliberately says not to emit them.
For consistency, this dataset omits per-element palettes and uses only the overall
palette.

String constraints:

- `high_level_description`: one sentence preferred, no more than 50 words.
- Each object `desc`: 30-60 words; identity first; no more than 60 words.
- `background`: non-empty, including for abstract/plain backgrounds.
- `elements`: non-empty for these card artworks.
- No empty or whitespace-only strings.
- Preserve literal Unicode; do not store `\uXXXX` escapes in the model string.
- Prose is English. Only a `text` element's literal `text` value may be another
  language.

Palette constraints:

- 1-16 dominant colors, ordered most to least dominant.
- Each is uppercase six-digit `#RRGGBB`.
- No shorthand hex, alpha values, duplicates, invented colors, or more than 16.
- Palette/image agreement is a visual-review gate, not merely a syntax gate.

## 3. Dataset metadata injection

The vision captioner describes visible content. Verified card metadata comes only
from the manifest and is injected after caption generation. Never ask the vision
model to guess card category, Monster Type, Spell/Trap subtype, release date, card
name, or archetype.

Canonical high-level openings:

```text
<A/An> <Monster Type>-type MONSTER card artwork showing the following scene: ...
A <Spell Subtype> SPELL card artwork showing the following scene: ...
A <Trap Subtype> TRAP card artwork showing the following scene: ...
```

Use `An` for Monster Types beginning with a vowel and `A` otherwise. Use the
project's exact controlled vocabulary. Do not infer it from the picture.
Normalize metadata once in the manifest, then inject it deterministically. The
injected opening counts toward the 50-word limit. If subtype control is not wanted
in training, retain subtype in the manifest but remove it consistently from ALL
Spell/Trap captions; never mix both policies within the dataset.

Recommended controlled Spell values: `Normal`, `Continuous`, `Equip`, `Field`,
`Quick-Play`, `Ritual`. Recommended Trap values: `Normal`, `Continuous`,
`Counter`. Monster Type must match the authoritative metadata exactly.

The visible summary after the opening must remain grammatically natural. Do not
prepend tag fragments such as `MONSTER. Plant.`.

## 4. Trigger-word contract

The exact trigger is lowercase ASCII `hclar52`.

- It MUST occur exactly once in every model string.
- It MUST occur in `style_description.art_style`, preferably first:
  `hclar52 card illustration, <observed technique>`.
- It MUST NOT occur in the high-level description, background, element
  descriptions, filenames, or metadata labels used as caption text.
- Use a Unicode-aware, case-sensitive literal count after final serialization.
- Reject zero or multiple occurrences; do not silently repair a final caption.

AI Toolkit behavior makes these rules important. Its generic trigger injection
prepends the trigger to the whole prompt when it cannot find it. Prepending text to
a JSON object makes the prompt cease to be valid structured JSON. Therefore:

```yaml
trigger_word: hclar52
shuffle_tokens: false
token_dropout_rate: 0
caption_dropout_rate: 0
random_triggers: null
```

`hclar52` must already be inside every sidecar before training. Alternatively,
set `trigger_word: null` and keep the trigger in the captions, but do not rely on
automatic insertion. Also prohibit `[name]` and `[trigger]` placeholders in every
caption because AI Toolkit replaces them before encoding.

## 5. No-name and no-leakage policy

Card names are administrative metadata and MUST NOT appear in any training-caption
string. This prevents identity memorization and keeps the style trigger separate
from individual cards.

For each row, construct a deny list containing:

- canonical English card name;
- official localized names available to the project;
- known alternate names/romanizations recorded in the manifest;
- card passcode/set code, archetype label, artist/source filename, source URL,
  watermark credit, and collector identifiers.

Search all caption string leaves (`high_level_description`, every style string,
`background`, object `desc`, text `text`, and text `desc`). Compare both the raw
string and a normalized form made with Unicode NFKC, case-folding, apostrophe/dash
normalization, punctuation-to-space conversion, and whitespace collapse. Use
whole normalized phrases, not unrestricted substring checks, so a short card name
such as `One` does not create false positives. Exact passcodes/set codes can use
case-insensitive token matching.

The captioner instruction should explicitly say not to identify Yu-Gi-Oh cards,
characters, archetypes, or card names, even when recognizable. Describe visible
appearance instead. This overrides AI Toolkit's generic preference to name known
characters. Post-generation deny-list validation remains mandatory.

Reject artwork with legible embedded card names, frames, set codes, watermarks, or
logos. Do not merely omit visible text from the caption: that creates inaccurate
supervision.

## 6. Element and background policy

- One coherent subject is one object element. Anatomy and structural parts stay
  inside its description.
- Held/worn/configured props normally stay in the subject description. A large,
  independently placeable prop may be a separate element when its spatial control
  matters, but use one policy consistently in review.
- Each distinct, independently placeable foreground subject is an element.
- Dense, hard-to-enumerate particles/debris may be described without a bbox or in
  the background when they form the scene shell.
- Ground, floor, sky, clouds, horizon, atmosphere, ambient walls, and distant
  scenery belong in `background`, not elements.
- Do not double-count the same thing in background and elements.
- Do not put camera/render/lighting prose in object descriptions. Put rendering
  technique in `art_style`, lighting in `lighting`, and scene-wide context in
  `background`.
- No lore, abilities, names, Attributes, Levels/Ranks, or unseen anatomy unless it
  is visibly represented.
- Ban hedging and alternative guesses (`possibly`, `maybe`, `appears to be`,
  `or similar`, etc.). Use a less specific but visually certain noun instead.

Text elements are allowed only for genuinely legible text intrinsic to the artwork.
Transcribe exactly, including capitalization, punctuation, Unicode, and line breaks.
Because this dataset uses artwork crops, any card-interface text is an image reject.

## 7. Bounding-box validation

Stored/training bbox order is always:

```text
[y_min, x_min, y_max, x_max]
```

Coordinates are integers normalized independently on both axes to `0..1000`, with
top-left origin. Require:

```text
0 <= y_min < y_max <= 1000
0 <= x_min < x_max <= 1000
```

Do not accept floats, numeric strings, booleans, nulls, reversed boxes, zero-area
boxes, or clamped out-of-range boxes. Automatic clamping conceals caption failures;
send them back for regeneration/review.

AI Toolkit's captioner asks Qwen for `[x1,y1,x2,y2]`, then converts to stored
`[y1,x1,y2,x2]`. Captions produced by the captioner are already converted. Manual
or imported captions must declare `bbox_source_format` in the QA manifest. Never
guess whether to swap coordinates based on their values.

Visual bbox QA:

- tight enough to represent the visible extent, including salient attached parts;
- no clipping of horns, wings, weapons, tails, or shields assigned to that element;
- no excessive empty margin;
- no duplicate/overlapping boxes for anatomical fragments;
- box and description identify the same subject;
- omit a box when extent is diffuse or genuinely ambiguous.

Structural bbox checks can be automated. Tightness and identity require inspection
against the actual image. At least one human visual pass is required for every
caption; a second reviewer should audit all failures and a stratified sample of
passes.

## 8. Image validation

Training images MUST pass all of the following:

- decodes completely without truncation or decoder warnings;
- EXIF orientation applied before resize;
- exactly `1024 x 1024` pixels after preparation;
- opaque sRGB RGB image (no unhandled alpha, CMYK, indexed palette, grayscale, or
  embedded orientation dependency);
- artwork crop only: no card frame, name bar, Attribute, stars, Pendulum scales,
  effect box, passcode, set code, rarity stamp, scan glare, website UI, watermark,
  credit, or artificial border;
- no stretching: crop/resize preserves geometry; square source art should not need
  reframing;
- no exact duplicate SHA-256 and no near duplicate under the chosen perceptual-hash
  threshold;
- no alternate file-format duplicate or repeated artwork under a newer reprint;
- first artwork release falls inside the agreed date window and is evidenced in
  the manifest;
- source provenance, original dimensions, prepared-file SHA-256, and transformation
  history recorded.

Use deterministic high-quality non-generative resampling. If either original axis
is below 1024, mark `upscaled_from_below_1024=true` and require manual sharpness/
artifact review. Never use generative upscaling for version 1 because it invents
style features. Automated blur, entropy, border, OCR, and watermark detectors are
triage signals only, never proof of acceptance.

## 9. Validator severity and gates

`ERROR` blocks packaging/training. `REVIEW` requires a recorded human decision.

Errors include:

- malformed JSON, wrong/missing/extra/out-of-order keys;
- wrong medium branch or style key order;
- trigger count/location failure;
- deny-list/name leakage;
- invalid palette syntax/count;
- invalid bbox structure/order/range/area;
- image/caption stem mismatch;
- missing manifest row or non-unique dataset ID;
- wrong dimensions/mode, decode failure, exact duplicate;
- category/type/subtype mismatch with manifest;
- placeholder tokens or model preamble/fences;
- word-cap violation or empty required prose.

Review flags include:

- low-resolution upscale, unusual compression, blur, suspected watermark/border;
- perceptual near-duplicate;
- palette disagreement;
- questionable visual identity, count, material, pose, or color;
- bbox tightness/ownership issue;
- possible background/element double-counting;
- subtype/date/source evidence not independently verified.

A package is releasable only when all 500 rows have zero errors, zero unresolved
review flags, valid matching image/sidecar pairs, unique hashes/IDs, and signed
caption/image QA fields in the manifest.

## 10. Recommended QA sequence

1. Verify source, artwork debut date, category, type/subtype, and uniqueness.
2. Prepare and hash the 1024-square image.
3. Generate observe-only caption JSON without guessed card metadata.
4. Normalize schema/key order and inject verified metadata plus `hclar52`.
5. Run strict structural, deny-list, image, duplicate, and cross-file validation.
6. Human-review caption content, palette, element ownership, and bboxes against image.
7. Regenerate or manually correct failures; rerun all automated checks.
8. Independently audit a stratified sample spanning every Monster Type, every
   Spell/Trap subtype, release-year bands, and all content/style clusters.
9. Freeze exact files, hashes, validator version, AI Toolkit commit, and report.

Passing a JSON Schema alone is insufficient: it cannot prove that visual claims,
palette values, subject counts, names, or bounding boxes match the image.

## 11. Captioner additional-instructions block

Use this as AI Toolkit's editable `caption_prompt`. It supplements, rather than
replaces, the fixed Ideogram captioner prompt:

```text
This is cropped fantasy trading-card artwork for a style-training dataset. Do not
identify or write any Yu-Gi-Oh card name, character name, archetype, franchise,
artist, set code, passcode, lore, ability, Attribute, Level, Rank, Link Rating, or
other card metadata, even when you recognize it. Describe recognizable subjects
only by their visible appearance and role. Do not guess whether the artwork is a
Monster, Spell, Trap, or any Monster Type; verified metadata will be injected
later. Treat the complete anatomy of one creature as one object element and keep
held or worn equipment in that subject's description unless it is a large,
independently placeable focal object. Describe abstract magical effects precisely
by visible shape, color, placement, and material-like appearance without inferring
an effect or story. Do not transcribe residual card-interface text, watermarks, or
source marks; instead make any such image fail curation. Use medium illustration
and describe only the observed rendering technique. Do not insert the dataset
trigger; it will be injected deterministically after captioning.
```

The postprocessor then inserts verified metadata and exactly one trigger. Keeping
those operations deterministic avoids asking the VLM to learn facts it cannot see.

## 12. Minimum implementation interface

The strict validator should expose two distinct operations:

```text
normalize_draft(image, manifest_row, raw_caption) -> canonical_caption | errors
validate_final(image, manifest_row, canonical_caption) -> errors, review_flags
```

`normalize_draft` may reorder known keys, canonicalize valid hex colors, remove an
input-only `aspect_ratio`, inject verified classification text, and insert the
trigger. It MUST NOT silently correct visual claims, invent missing descriptions,
clamp/swap bboxes, delete names, or turn malformed raw text into an accepted final
caption. Those conditions require regeneration or recorded manual correction.

`validate_final` must be idempotent and non-mutating. Run it once on the pretty
sidecar and again on its minified model string. The parsed objects must be equal,
the minified string must round-trip byte-for-byte, and the recorded SHA-256 must
match. Exit non-zero if any error or unresolved review flag remains.

Record at minimum per row:

```text
dataset_id, image_path, caption_path, card_name_admin_only, card_category,
monster_type, spell_trap_subtype, artwork_debut_date, source_url,
source_image_sha256, prepared_image_sha256, model_caption_sha256,
bbox_source_format, caption_model, caption_model_revision, caption_prompt_revision,
normalizer_version, validator_version, image_reviewer, caption_reviewer,
reviewed_at, qa_status, qa_notes
```

## 13. Source-of-truth notes

- Ideogram's official prompting guide defines stored bboxes as
  `[y_min,x_min,y_max,x_max]`, strict key ordering, overall palette maximum 16,
  element palette maximum 5, compact UTF-8 JSON, and required
  `compositional_deconstruction.background/elements`.
- AI Toolkit's shared `toolkit/ideogram_caption.py` normalizes key order and palette
  syntax but intentionally preserves unexpected keys and does not strictly reject
  every malformed semantic case. A separate strict dataset validator is required.
- AI Toolkit's `Ideogram4Captioner.py` converts Qwen's temporary xyxy output to the
  stored yxyx convention, drops invalid bboxes, saves pretty JSON, and enforces at
  least 3072 generated tokens.
- AI Toolkit's current caption prompt asks for single-line JSON, but the captioner
  saves parsed output pretty-printed; this is safe because the Ideogram model path
  digests/minifies a valid structured caption before encoding.

Primary references:

- https://github.com/ideogram-oss/ideogram4/blob/main/docs/prompting.md
- https://github.com/ideogram-oss/ideogram4/blob/main/src/ideogram4/caption_verifier.py
- https://github.com/ostris/ai-toolkit/blob/main/toolkit/ideogram_caption.py
- https://github.com/ostris/ai-toolkit/blob/main/extensions_built_in/captioner/Ideogram4Captioner.py
- https://github.com/ostris/ai-toolkit/blob/main/extensions_built_in/captioner/prompts/ideogram4_caption_prompt.py
- https://github.com/ostris/ai-toolkit/blob/main/toolkit/dataloader_mixins.py
- https://github.com/ostris/ai-toolkit/blob/main/toolkit/prompt_utils.py

# A.I.P Test 03 — Shrieker Reproduction Control

This is not yet an A/B composition test. It verifies that the current workflow can still reproduce a previously successful result before any more variables are changed.

## Ready-to-load workflow

Drag [`AIP_Test_03_Shrieker_Reproduction_Control.workflow.json`](./AIP_Test_03_Shrieker_Reproduction_Control.workflow.json) directly onto the ComfyUI canvas. It already contains the locked seed, disabled JSON generator, active LoRA on both model branches and the exact prompt below.

After loading, visually confirm that the seed reads `641017252963070` and `Generate JSON Prompt` is OFF before queueing. Do not press a randomize-seed control.

## Exact settings

- **Generate JSON Prompt:** OFF
- **Seed:** `641017252963070`
- **Conditional model:** `ideogram4_fp8_scaled.safetensors`
- **Unconditional model:** `ideogram4_unconditional_fp8_scaled.safetensors`
- **LoRA:** `Ideogram4_Yugioh_hclar52_r32_v1_000003500.safetensors`
- **LoRA strength:** `1.0` on both model branches
- **Preset:** Quality
- **Resolution selector:** 1:1, 2 megapixels (`1456 × 1456` output in the verified run)

Do not add `aspect_ratio`, alter punctuation or change the prompt. Paste this exact JSON with the generator switch OFF:

```json
{
  "high_level_description": "Beast-type MONSTER card illustration. A newly evolved laboratory beast throws back its head and releases a violent scream that ruptures its containment chamber.",
  "style_description": {
    "aesthetics": "frantic, unstable, loud, newly awakened",
    "lighting": "cold green laboratory light with a sharp orange-red glow inside the mouth and eye",
    "medium": "illustration",
    "art_style": "hclar52 card illustration with exaggerated perspective, expressive monster anatomy, concentrated sonic effects and a dominant open-mouth focal point",
    "color_palette": ["#101816", "#29372B", "#D64725", "#E5C19A", "#77815B"]
  },
  "compositional_deconstruction": {
    "background": "Two broad cracked wall sections and the shadow of a broken containment pod frame the creature. Laboratory machinery remains indistinct beneath green-gray vapor.",
    "elements": [
      {
        "type": "obj",
        "bbox": [40, 120, 980, 900],
        "desc": "A heavy seal-like beast rears upward from the lower frame. Its black-green segmented hide carries glowing crimson channels, one bulbous orange eye turns toward the viewer, and its enormous vertical mouth displays uneven pale fangs. Its forelimbs brace against the floor while its head crops near the top."
      },
      {
        "type": "effect",
        "bbox": [0, 20, 1000, 980],
        "desc": "Two broad translucent sound rings burst from the mouth and distort the chamber behind it. Large glass fragments, dust and fluid droplets travel along those rings, passing behind the head and across the foreground forelimbs instead of becoming a uniformly detailed explosion."
      }
    ]
  },
  "negative_prompt": "card frame, border, title, lettering, written sound effects, logo, watermark, detailed laboratory equipment, musical notes, dozens of tiny shards, empty space above the monster, side-profile portrait, ordinary seal, comedic expression, photographic blur, duplicate jaws, extra limbs"
}
```

## Expected result

The output should closely reproduce the known successful image generated from this exact embedded workflow state. Exact pixel identity is ideal; a close compositional match is sufficient if a dependency has introduced nondeterminism.

## Interpretation

- **Close reproduction:** the workflow and LoRA are healthy; resume A/B testing from this rich prompt.
- **Safety block:** something outside the prompt has changed, because this exact prompt, seed and checkpoint previously rendered successfully.
- **Large visual mismatch:** compare loaded model hashes, custom-node versions and sampler graph state before changing prompt wording.

Do not run multiple new seeds until this control passes.

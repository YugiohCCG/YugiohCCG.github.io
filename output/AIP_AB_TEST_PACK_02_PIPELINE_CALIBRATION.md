# A.I.P A/B Test Pack 02 — Pipeline Calibration

This replaces the invalid first Shrieker batch. Do only this calibration before generating the other A.I.P cards.

## Settings to lock

- Use the same LoRA checkpoint and strength for both variants.
- Keep the Quality preset and every sampler setting unchanged.
- Manually enter one seed and reuse that exact seed for A and B.
- Start with seed `643356706812080`, which generated `ComfyUI_00342_.png`.
- Generate one image per prompt initially.

## 2A — Natural language through the prompt generator

Set **Generate JSON Prompt = ON**, then paste only this:

```text
hclar52 MONSTER card illustration. A squat black-green reptilian artificial beast braces low in a damaged pale-green laboratory and releases a sonic cry diagonally toward the upper left. Its long vertical mouth, uneven ivory fangs and one visible orange eye form the focal point. The body is seen in asymmetrical three-quarter view. A few glass fragments follow the cry toward the upper-left edge. The laboratory is reduced to one cracked wall plane, one dark pipe bank and one cyan lamp.
```

Before queuing, confirm that the preview node outputs one JSON object rather than prose or nested JSON.

## 2B — Renderer-ready JSON without the prompt generator

Set **Generate JSON Prompt = OFF**, then paste this complete object:

```json
{
  "aspect_ratio": "1:1",
  "high_level_description": "hclar52 MONSTER card illustration. A squat black-green reptilian artificial beast braces low in a damaged laboratory and releases a sonic cry diagonally toward the upper left.",
  "compositional_deconstruction": {
    "background": "A subdued pale-green laboratory formed by one broad cracked wall plane, one dark pipe bank, one cyan lamp and a dark floor.",
    "elements": [
      {
        "type": "obj",
        "desc": "One complete beast in asymmetrical three-quarter view, with segmented black-green hide, narrow red channels, one clearly visible orange eye, strong unevenly planted forelimbs and a long vertical mouth with irregular ivory fangs. Its head turns toward the upper left. A few large glass fragments travel from the mouth toward the upper-left edge along the same diagonal."
      }
    ]
  }
}
```

## What this test answers

The visual content is deliberately matched. The only variable is the prompt route:

- **2A:** natural language is interpreted by the workflow's prompt-generating language model.
- **2B:** completed JSON bypasses that language model and reaches the Ideogram text encoder directly.

This does **not** yet test centered against diagonal composition.

## Pass conditions

An output passes calibration when:

- it is recognizably an illustration rather than a photograph or 3D product render;
- the creature is asymmetrical and shown in three-quarter view;
- the sonic action travels toward the upper left rather than radiating evenly;
- the environment reads as supporting space rather than a flat studio wall;
- no literal checkerboard, border, card frame or written text appears;
- the image is not safety-blocked.

If only one route passes, use that route for all subsequent tests. If neither passes, the next controlled variable is the LoRA checkpoint/weight—not more prompt detail.

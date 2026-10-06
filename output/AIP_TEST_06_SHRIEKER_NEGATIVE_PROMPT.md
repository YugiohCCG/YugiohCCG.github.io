# A.I.P Test 06 — Negative-Prompt Leakage

## Question

Does the top-level `negative_prompt` field suppress unwanted content, or does its vocabulary leak into the positively encoded structured prompt?

## Why this test matters

The negative field in image 358 contains `dozens of tiny shards`. Image 358 renders dozens of tiny shards throughout the sound-ring area. The ComfyUI graph separately zeroes its negative conditioning, while the entire JSON string—including `negative_prompt`—is sent through the positive text encoder.

This does not prove leakage by itself. A controlled removal test does.

## Existing A control

`ComfyUI_00358_.png` includes the full negative field.

## B challenger

Drag [`AIP_Test_06_Shrieker_No_Negative_Prompt.workflow.json`](./AIP_Test_06_Shrieker_No_Negative_Prompt.workflow.json) onto ComfyUI and queue exactly one image.

The B workflow preserves:

- seed `573928216989127`;
- JSON generator OFF;
- 1-megapixel resolution;
- inset creature box `[120, 170, 920, 830]`;
- full-frame effect box `[0, 20, 1000, 980]`;
- every positive prompt field and character;
- model, LoRA, strength and sampler graph.

The only removed content is:

```json
"negative_prompt": "card frame, border, title, lettering, written sound effects, logo, watermark, detailed laboratory equipment, musical notes, dozens of tiny shards, empty space above the monster, side-profile portrait, ordinary seal, comedic expression, photographic blur, duplicate jaws, extra limbs"
```

## Evaluation priorities

Count or compare:

1. density of tiny shards;
2. frame, border or panel-like shapes;
3. textual or musical symbols;
4. duplicated jaws or limbs;
5. resemblance to an ordinary seal;
6. overall focal hierarchy and background cleanliness.

If removing the field reduces one or more named unwanted concepts without creating a compensating failure, exclude `negative_prompt` from future positive JSON and handle negatives through a genuinely separate conditioning path when supported.

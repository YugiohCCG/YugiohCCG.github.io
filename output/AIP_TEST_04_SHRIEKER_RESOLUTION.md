# A.I.P Test 04 — Shrieker Resolution A/B

## Question

Does the 2-megapixel Ideogram workflow setting improve anatomy, material rendering and effect separation compared with 1 megapixel when every other variable is locked?

## Existing A control

`ComfyUI_00355_.png` already supplies the A result:

- Seed: `573928216989127`
- Generate JSON Prompt: OFF
- Input: rich Shrieker JSON, 1,987 characters
- Resolution selector: 1:1, 1 megapixel
- Output: `1024 × 1024`
- LoRA: `Ideogram4_Yugioh_hclar52_r32_v1_000003500.safetensors`
- LoRA strength: `1.0`
- Preset: Quality

## B challenger

Drag [`AIP_Test_04_Shrieker_Resolution_B_2MP.workflow.json`](./AIP_Test_04_Shrieker_Resolution_B_2MP.workflow.json) onto ComfyUI and queue exactly one image.

The workflow is locked to:

- Seed: `573928216989127`
- Generate JSON Prompt: OFF
- Exact same rich JSON as image 355
- Resolution selector: 1:1, 2 megapixels
- Expected output: approximately `1456 × 1456`
- Same models, LoRA, strength and Quality sampler graph

Do not randomize the seed or edit the prompt.

## Evaluation priorities

Compare B with image 355 for:

1. separation between individual fangs;
2. consistency of the segmented neck and torso;
3. articulation of the two forelimbs;
4. distinction between sound rings, fragments and creature contours;
5. background depth without additional clutter;
6. thumbnail readability after both images are reduced to the same display size.

Higher resolution wins only if it improves structure and rendering while preserving the same visual hierarchy. Extra micro-detail alone is not a win.

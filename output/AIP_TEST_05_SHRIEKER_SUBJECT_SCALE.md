# A.I.P Test 05 — Shrieker Subject Scale

## Question

Can a more inset creature bounding box reduce mouth dominance and reveal more body/environment while preserving the strong illustrated rendering of the direct rich JSON prompt?

## Existing A control

`ComfyUI_00355_.png`:

- Creature box: `[40, 120, 980, 900]`
- Effect box: `[0, 20, 1000, 980]`
- Seed: `573928216989127`
- Generate JSON Prompt: OFF
- Resolution: 1 megapixel

## B challenger

Drag [`AIP_Test_05_Shrieker_Inset_BBox.workflow.json`](./AIP_Test_05_Shrieker_Inset_BBox.workflow.json) onto ComfyUI and queue exactly one image.

Only the creature box changes:

```text
A: [40, 120, 980, 900]
B: [120, 170, 920, 830]
```

The effect box, every descriptive word, seed, model, LoRA, strength, resolution and sampler setting remain identical.

## Predicted effect

B should show more of the forelimbs and coiled torso, create a wider border of environmental space and reduce the mouth's share of the frame. The sound rings may remain large because their separate effect box is deliberately unchanged.

## Win conditions

B wins only if it:

1. reveals meaningfully more coherent body structure;
2. preserves one clearly dominant mouth/eye region;
3. gives the laboratory readable depth around the silhouette;
4. remains immediately readable at thumbnail size;
5. does not create a duplicate creature, detached anatomy or an empty central composition.

This test concerns subject scale only. Do not edit the effect box yet.

# Bellblast V5: 40 prompt experiments

These are untested prompt experiments for the existing Ideogram 4 workflow. They preserve the academy uniforms, crimson/ivory/navy weapons, gold star emblem and comically huge bazookas. Warrior is a provisional archetype card type.

## How to run and return results

1. Paste only the JSON object into the structured prompt input. IDs and titles are administrative labels, not prompt text.
2. Use the same two seeds for every prompt in the first pass. Keep the checkpoint, both LoRA strengths, sampler, scheduler, steps, guidance, resolution and any upscaling unchanged. This gives 80 images and two comparable examples per prompt, not a statistical ranking.
3. A practical starting set of 16 prompts is C01-C04, R11-R14, R21-R24 and B01-B04. Then run R31-R34, W11-W14, W21-W24, L01-L04 and S01-S08.
4. Save results with their prompt ID and seed, for example R11_Rika_seed12345.png. Preserve the embedded ComfyUI workflow/prompt if possible. Do not place the ID inside the generated artwork prompt.
5. Zip the results and share them back. Include workflow/settings if your export strips metadata. The review_template.json is optional; filenames plus embedded settings are enough to begin review.
6. After review, combine the strongest rendering, lighting and weapon treatments into new prompts and check them on fresh seeds. Do not assume individually successful changes will combine successfully.

The previous rookie workflow used the 3500 LoRA checkpoint, strength 1.0 on both model branches and Euler. Those are continuity references, not claimed optimal settings. Use the rest of your existing workflow unchanged for this prompt comparison.

## What each group tests

| Group | Count | Change |
|---|---:|---|
| C01-C04 | 4 | Exact V4 controls, one per character |
| R11-R14 | 4 | art_style only: harder cel-shadow rendering |
| R21-R24 | 4 | art_style only: painted finish and colored outlines |
| R31-R34 | 4 | art_style only: graphic shapes and selective gradients |
| W11-W14 | 4 | Weapon description only: heavy straight cylindrical construction |
| W21-W24 | 4 | Weapon description only: sculpted fantasy fins and braces |
| B01-B04 | 4 | Remove bbox keys only; keep identical prose |
| L01-L04 | 4 | Lighting description only: diffuse daylight |
| S01-S08 | 8 | New scenes; several composition variables change together |

Every four-prompt technique group uses character order Rika, Emi, Shiori, Reina. Compare each experiment against its listed control at the same seed. The bounding-box experiment tests presence versus absence; it does not test resolution. The weapon groups test bundles of construction wording, not individual adjectives. Scene experiments test ideas and readability, not isolated rendering techniques.

## Review criteria

Rate each result from 1 (poor) to 5 (strong): similarity to the selected official humanoid-combat references; archetype consistency; comically huge but recognizable bazooka; clear face and silhouette at card size; readable pose/action; clean anatomy and object connections. Also record a short note on the most obvious failure. Compare all attempted outputs, including failures, rather than selecting only the prettiest seed.

The comparison should use the actual training folder, particularly ygo4_0021, ygo4_0231, ygo4_0268 and ygo4_0283, rather than treating all official Yu-Gi-Oh artwork as one uniform rendering style. A prompt win is provisional until it holds across characters and fresh seeds.

## Prompt index

- **C01 — Rika: V4 control**. Compare with itself as control.
- **C02 — Emi: V4 control**. Compare with itself as control.
- **C03 — Shiori: V4 control**. Compare with itself as control.
- **C04 — Reina: V4 control**. Compare with itself as control.
- **R11 — Rika: Hard cel planes**. Compare with C01.
- **R12 — Emi: Hard cel planes**. Compare with C02.
- **R13 — Shiori: Hard cel planes**. Compare with C03.
- **R14 — Reina: Hard cel planes**. Compare with C04.
- **R21 — Rika: Painted card finish**. Compare with C01.
- **R22 — Emi: Painted card finish**. Compare with C02.
- **R23 — Shiori: Painted card finish**. Compare with C03.
- **R24 — Reina: Painted card finish**. Compare with C04.
- **R31 — Rika: Graphic anime finish**. Compare with C01.
- **R32 — Emi: Graphic anime finish**. Compare with C02.
- **R33 — Shiori: Graphic anime finish**. Compare with C03.
- **R34 — Reina: Graphic anime finish**. Compare with C04.
- **W11 — Rika: Heavy cylindrical construction**. Compare with C01.
- **W12 — Emi: Heavy cylindrical construction**. Compare with C02.
- **W13 — Shiori: Heavy cylindrical construction**. Compare with C03.
- **W14 — Reina: Heavy cylindrical construction**. Compare with C04.
- **W21 — Rika: Sculpted fantasy construction**. Compare with C01.
- **W22 — Emi: Sculpted fantasy construction**. Compare with C02.
- **W23 — Shiori: Sculpted fantasy construction**. Compare with C03.
- **W24 — Reina: Sculpted fantasy construction**. Compare with C04.
- **B01 — Rika: No bounding boxes**. Compare with C01.
- **B02 — Emi: No bounding boxes**. Compare with C02.
- **B03 — Shiori: No bounding boxes**. Compare with C03.
- **B04 — Reina: No bounding boxes**. Compare with C04.
- **L01 — Rika: Diffuse daylight**. Compare with C01.
- **L02 — Emi: Diffuse daylight**. Compare with C02.
- **L03 — Shiori: Diffuse daylight**. Compare with C03.
- **L04 — Reina: Diffuse daylight**. Compare with C04.
- **S01 — Rika: Desk sled**. Compare with C01.
- **S02 — Rika: Overloaded backpack**. Compare with C01.
- **S03 — Emi: Manual versus machinery**. Compare with C02.
- **S04 — Emi: Trolley runaway**. Compare with C02.
- **S05 — Shiori: Silent checkpoint**. Compare with C03.
- **S06 — Shiori: Landing interception**. Compare with C03.
- **S07 — Reina: Captain at assembly**. Compare with C04.
- **S08 — Reina: Storm-facing salute**. Compare with C04.

# Ideogram 4 caption generation and validation

This directory is independent of the selection/image builder. It consumes its
CSV or JSON manifest and prepared images, generates structured captions, and
strictly validates the final package according to
`docs/ideogram4-yugioh-caption-validation-spec.md`.

## Install on RunPod

```bash
python -m venv /workspace/venv
source /workspace/venv/bin/activate
pip install -r scripts/ideogram4_captioning/requirements-runpod.txt
```

For a local Qwen3-VL backend, install the CUDA-matched PyTorch wheel first, then
install current `transformers`, `accelerate`, and `qwen-vl-utils`. An
OpenAI-compatible vLLM/SGLang server usually gives better throughput; point the
OpenAI-compatible config at its `/v1` base URL.

## Generate a pilot

Copy an example config and edit its endpoint/model. Secrets are read only from the
configured environment variable and are never written to reports.

```bash
export VLM_API_KEY=your-key-if-required
python scripts/ideogram4_captioning/caption_dataset.py \
  --manifest output/yugioh_ideogram4_500/selection/image-manifest.json \
  --dataset-root output/yugioh_ideogram4_500 \
  --config scripts/ideogram4_captioning/config.openai-compatible.example.json \
  --output-manifest output/yugioh_ideogram4_500/selection/caption-manifest.json \
  --limit 20
```

On PowerShell, use backticks instead of backslashes for line continuation. The
generator:

1. sends only the artwork and observe-only prompt to the VLM;
2. saves every raw response under `caption_drafts/` for audit;
3. parses unique-key JSON;
4. deterministically injects verified classification metadata and `hclar52`;
5. converts bboxes only when `bbox_response_format` explicitly requests it;
6. writes a final sidecar only when strict caption validation passes;
7. writes an augmented manifest containing the exact compact model-caption hash.

Use `--ids ygo4_0001 ygo4_0002`, `--limit`, and `--workers` for pilots. Existing
valid captions are resumed safely. Use `--overwrite` only when intentionally
recaptioning them.

If a server emits temporary Qwen-style `[x1,y1,x2,y2]` boxes despite the supplied
prompt, set `bbox_response_format` to `qwen_xyxy`. Otherwise leave it at
`stored_yxyx`. Never change that setting midway through a run without recording a
new caption manifest.

## Validate

During production work, errors fail and review flags are reported:

```bash
python scripts/ideogram4_captioning/validate_dataset.py \
  --manifest output/yugioh_ideogram4_500/selection/caption-manifest.json \
  --dataset-root output/yugioh_ideogram4_500 \
  --report output/yugioh_ideogram4_500/validation-report.json \
  --expected-count 500
```

For the frozen release gate, use `--release`. It additionally fails on every
unresolved review flag and requires `image_reviewer`, `caption_reviewer`,
`reviewed_at`, an approved `qa_status`, and resolved official metadata.
Record reviewed detector flags in the row's `resolved_review_codes` field as a
semicolon-separated list or JSON string array. The report retains them as
`RESOLVED_REVIEW`; use `*` only when the reviewer genuinely adjudicated every
flag on that row.

```bash
python scripts/ideogram4_captioning/validate_dataset.py \
  --manifest output/yugioh_ideogram4_500/selection/release-manifest.json \
  --dataset-root output/yugioh_ideogram4_500 \
  --report output/yugioh_ideogram4_500/release-validation-report.json \
  --expected-count 500 --release
```

Automated validation deliberately cannot approve visual truth, palette accuracy,
watermark absence, bbox tightness, subject grouping, or source/date evidence. Those
remain recorded human-review gates.

## Tests

```bash
python -m unittest discover -s scripts/ideogram4_captioning/tests -v
```

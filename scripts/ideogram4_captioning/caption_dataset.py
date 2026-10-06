#!/usr/bin/env python3
from __future__ import annotations

import argparse
import csv
import json
import os
import sys
import threading
from concurrent.futures import ThreadPoolExecutor, as_completed
from pathlib import Path
from typing import Any

import requests
from PIL import Image

SCRIPT_DIR = Path(__file__).resolve().parent
if str(SCRIPT_DIR) not in sys.path:
    sys.path.insert(0, str(SCRIPT_DIR))

from common import (
    DraftNormalizationError,
    extract_json_object,
    image_data_uri,
    load_manifest,
    model_string,
    normalize_draft,
    resolve_dataset_path,
    sha256_bytes,
    write_pretty_json,
)
from validator import validate_caption


class OpenAICompatibleBackend:
    def __init__(self, config: dict[str, Any]) -> None:
        self.endpoint = str(config["endpoint"]).rstrip("/")
        if not self.endpoint.endswith("/chat/completions"):
            self.endpoint += "/chat/completions"
        self.model = str(config["model"])
        self.api_key = os.environ.get(str(config.get("api_key_env") or "OPENAI_API_KEY"), "")
        self.timeout = int(config.get("timeout_seconds", 300))
        self.max_tokens = int(config.get("max_tokens", 4096))
        self.temperature = float(config.get("temperature", 0))
        self.image_detail = str(config.get("image_detail", "high"))
        self.use_json_response_format = bool(config.get("use_json_response_format", True))

    def generate(self, image_path: Path, prompt: str) -> str:
        headers = {"Content-Type": "application/json"}
        if self.api_key:
            headers["Authorization"] = f"Bearer {self.api_key}"
        payload: dict[str, Any] = {
            "model": self.model,
            "messages": [{
                "role": "user",
                "content": [
                    {"type": "text", "text": prompt},
                    {"type": "image_url", "image_url": {"url": image_data_uri(image_path), "detail": self.image_detail}},
                ],
            }],
            "temperature": self.temperature,
            "max_tokens": self.max_tokens,
        }
        if self.use_json_response_format:
            payload["response_format"] = {"type": "json_object"}
        response = requests.post(self.endpoint, headers=headers, json=payload, timeout=self.timeout)
        response.raise_for_status()
        body = response.json()
        content = body["choices"][0]["message"]["content"]
        if isinstance(content, list):
            content = "".join(str(item.get("text") or "") for item in content if isinstance(item, dict))
        if not isinstance(content, str) or not content.strip():
            raise RuntimeError("endpoint returned no textual caption")
        return content.strip()


class LocalTransformersBackend:
    def __init__(self, config: dict[str, Any]) -> None:
        try:
            import torch
            from transformers import AutoModelForImageTextToText, AutoProcessor
        except ImportError as exc:
            raise RuntimeError("local_transformers backend requires torch and transformers") from exc
        self.torch = torch
        self.processor = AutoProcessor.from_pretrained(
            str(config["model"]), trust_remote_code=bool(config.get("trust_remote_code", False))
        )
        model_kwargs: dict[str, Any] = {
            "device_map": config.get("device_map", "auto"),
            "trust_remote_code": bool(config.get("trust_remote_code", False)),
        }
        dtype_name = str(config.get("dtype", "auto"))
        if dtype_name != "auto":
            model_kwargs["torch_dtype"] = getattr(torch, dtype_name)
        attn = config.get("attn_implementation")
        if attn:
            model_kwargs["attn_implementation"] = attn
        self.model = AutoModelForImageTextToText.from_pretrained(str(config["model"]), **model_kwargs)
        self.max_new_tokens = int(config.get("max_tokens", 4096))

    def generate(self, image_path: Path, prompt: str) -> str:
        with Image.open(image_path) as opened:
            image = opened.convert("RGB")
        messages = [{"role": "user", "content": [{"type": "image", "image": image}, {"type": "text", "text": prompt}]}]
        inputs = self.processor.apply_chat_template(
            messages,
            tokenize=True,
            add_generation_prompt=True,
            return_dict=True,
            return_tensors="pt",
        )
        device = next(self.model.parameters()).device
        inputs = inputs.to(device)
        with self.torch.inference_mode():
            generated = self.model.generate(**inputs, max_new_tokens=self.max_new_tokens, do_sample=False)
        trimmed = generated[:, inputs["input_ids"].shape[1] :]
        return self.processor.batch_decode(trimmed, skip_special_tokens=True, clean_up_tokenization_spaces=False)[0].strip()


def load_backend(config: dict[str, Any]):
    backend = str(config.get("backend") or "openai_compatible")
    if backend == "openai_compatible":
        return OpenAICompatibleBackend(config)
    if backend == "local_transformers":
        return LocalTransformersBackend(config)
    raise ValueError(f"unsupported backend {backend!r}")


def write_manifest(path: Path, rows: list[dict[str, Any]]) -> None:
    path.parent.mkdir(parents=True, exist_ok=True)
    if path.suffix.lower() == ".json":
        path.write_text(json.dumps(rows, ensure_ascii=False, indent=2) + "\n", encoding="utf-8")
        return
    fields = sorted({key for row in rows for key in row})
    with path.open("w", encoding="utf-8-sig", newline="") as handle:
        writer = csv.DictWriter(handle, fieldnames=fields)
        writer.writeheader()
        writer.writerows(rows)


def process_row(
    row: dict[str, Any],
    *,
    dataset_root: Path,
    backend,
    prompt: str,
    bbox_source_format: str,
    attempts: int,
    overwrite: bool,
    raw_dir: Path,
    model_name: str,
    prompt_revision: str,
) -> tuple[dict[str, Any], dict[str, Any]]:
    output_row = dict(row)
    dataset_id = str(row.get("dataset_id") or "")
    if not dataset_id:
        return output_row, {"dataset_id": "", "status": "failed", "error": "missing dataset_id"}
    image_path = resolve_dataset_path(dataset_root, str(row.get("image_file") or ""), "images", dataset_id, ".png")
    caption_path = resolve_dataset_path(dataset_root, str(row.get("caption_file") or ""), "captions", dataset_id, ".json")
    if not image_path.is_file():
        return output_row, {"dataset_id": dataset_id, "status": "failed", "error": f"missing image {image_path}"}
    if caption_path.is_file() and not overwrite:
        existing = caption_path.read_text(encoding="utf-8")
        validation, caption = validate_caption(existing, row, caption_path=str(caption_path))
        if not validation.errors and caption is not None:
            output_row["model_caption_sha256"] = sha256_bytes(model_string(caption).encode("utf-8"))
            output_row["bbox_source_format"] = "stored_yxyx"
            return output_row, {"dataset_id": dataset_id, "status": "skipped_valid_existing"}

    errors: list[str] = []
    raw_dir.mkdir(parents=True, exist_ok=True)
    for attempt in range(1, attempts + 1):
        retry_note = "" if attempt == 1 else "\nYour previous attempt failed strict validation. Re-read every constraint and produce a fresh caption; do not mention the prior response."
        try:
            raw = backend.generate(image_path, prompt + retry_note)
            (raw_dir / f"{dataset_id}.attempt-{attempt}.txt").write_text(raw + "\n", encoding="utf-8")
            draft = extract_json_object(raw)
            caption = normalize_draft(draft, row, bbox_source_format=bbox_source_format)
            validation, parsed = validate_caption(model_string(caption), row, caption_path=str(caption_path))
            if validation.errors:
                errors.append(f"attempt {attempt}: " + "; ".join(f"{item.code}: {item.message}" for item in validation.errors))
                continue
            write_pretty_json(caption_path, caption)
            output_row.update({
                "model_caption_sha256": sha256_bytes(model_string(caption).encode("utf-8")),
                "bbox_source_format": "stored_yxyx",
                "caption_model": model_name,
                "caption_prompt_revision": prompt_revision,
                "caption_generation_status": "passed_strict_caption_validation",
            })
            return output_row, {"dataset_id": dataset_id, "status": "generated", "attempt": attempt}
        except Exception as exc:
            errors.append(f"attempt {attempt}: {type(exc).__name__}: {exc}")
    output_row["caption_generation_status"] = "failed"
    return output_row, {"dataset_id": dataset_id, "status": "failed", "error": " | ".join(errors)}


def main() -> int:
    parser = argparse.ArgumentParser(description="Generate strict Ideogram 4 JSON captions")
    parser.add_argument("--manifest", type=Path, required=True)
    parser.add_argument("--dataset-root", type=Path, required=True)
    parser.add_argument("--config", type=Path, required=True)
    parser.add_argument("--output-manifest", type=Path, required=True)
    parser.add_argument("--prompt", type=Path, default=SCRIPT_DIR / "ideogram4_caption_prompt.txt")
    parser.add_argument("--raw-dir", type=Path)
    parser.add_argument("--limit", type=int)
    parser.add_argument("--ids", nargs="*")
    parser.add_argument("--workers", type=int)
    parser.add_argument("--overwrite", action="store_true")
    args = parser.parse_args()

    config = json.loads(args.config.read_text(encoding="utf-8"))
    rows = load_manifest(args.manifest)
    if args.ids:
        wanted = set(args.ids)
        rows = [row for row in rows if str(row.get("dataset_id") or "") in wanted]
    if args.limit is not None:
        rows = rows[: args.limit]
    prompt = args.prompt.read_text(encoding="utf-8").strip()
    prompt_revision = sha256_bytes(prompt.encode("utf-8"))[:16]
    bbox_source_format = str(config.get("bbox_response_format") or "stored_yxyx")
    attempts = int(config.get("attempts", 2))
    backend = load_backend(config)
    workers = args.workers or int(config.get("workers", 4))
    if str(config.get("backend") or "openai_compatible") == "local_transformers":
        workers = 1
    raw_dir = args.raw_dir or args.dataset_root / "caption_drafts"
    model_name = str(config.get("model") or "")
    lock = threading.Lock()
    completed: list[dict[str, Any]] = []
    events: list[dict[str, Any]] = []

    def run(row: dict[str, Any]):
        return process_row(
            row,
            dataset_root=args.dataset_root,
            backend=backend,
            prompt=prompt,
            bbox_source_format=bbox_source_format,
            attempts=attempts,
            overwrite=args.overwrite,
            raw_dir=raw_dir,
            model_name=model_name,
            prompt_revision=prompt_revision,
        )

    with ThreadPoolExecutor(max_workers=workers) as executor:
        futures = {executor.submit(run, row): row for row in rows}
        for index, future in enumerate(as_completed(futures), 1):
            row, event = future.result()
            with lock:
                completed.append(row)
                events.append(event)
                print(f"[{index}/{len(rows)}] {event['dataset_id']}: {event['status']}", flush=True)

    order = {str(row.get("dataset_id") or ""): index for index, row in enumerate(rows)}
    completed.sort(key=lambda row: order.get(str(row.get("dataset_id") or ""), len(order)))
    write_manifest(args.output_manifest, completed)
    log_path = args.output_manifest.with_suffix(".caption-log.json")
    log_path.write_text(json.dumps(events, ensure_ascii=False, indent=2) + "\n", encoding="utf-8")
    failures = [event for event in events if event["status"] == "failed"]
    print(f"Wrote {args.output_manifest}; failures={len(failures)}", flush=True)
    return 1 if failures else 0


if __name__ == "__main__":
    raise SystemExit(main())

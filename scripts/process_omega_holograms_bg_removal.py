"""
Background Removal Processor for YGO Omega Holograms.
Uses state-of-the-art BiRefNet to produce crisp, studio-grade transparent cutouts.
"""

from __future__ import annotations

import json
import os
import shutil
import sys
import time
from datetime import datetime
from pathlib import Path
from PIL import Image
import onnxruntime as ort
import rembg

HOLOGRAMS_DIR = Path(r"C:\Program Files (x86)\YGO Omega\YGO Omega_Data\Files\Holograms")
BACKUP_DIR = HOLOGRAMS_DIR / "_bak_pre_bg_removal_20261011"
PROGRESS_FILE = Path(r"c:\Manual Files\Applications\YugiohCCG.github.io\tmp\hologram_bg_removal_progress.json")
OUTPUT_SIZE = 512


def create_backup():
    BACKUP_DIR.mkdir(parents=True, exist_ok=True)
    all_files = [f for f in HOLOGRAMS_DIR.iterdir() if f.is_file()]
    backed_up = 0
    for f in all_files:
        dest = BACKUP_DIR / f.name
        if not dest.exists():
            shutil.copy2(f, dest)
            backed_up += 1
    print(f"[Backup] {backed_up} new files backed up to {BACKUP_DIR} (Total files: {len(all_files)})")


def load_progress() -> dict:
    if PROGRESS_FILE.exists():
        try:
            return json.loads(PROGRESS_FILE.read_text(encoding="utf-8"))
        except Exception as e:
            print(f"[Progress] Warning: could not load progress file ({e}), starting fresh")
    return {}


def save_progress(progress: dict):
    PROGRESS_FILE.parent.mkdir(parents=True, exist_ok=True)
    tmp = PROGRESS_FILE.with_suffix(".tmp")
    tmp.write_text(json.dumps(progress, indent=2), encoding="utf-8")
    tmp.replace(PROGRESS_FILE)


def init_session() -> rembg.sessions.base.BaseSession:
    opts = ort.SessionOptions()
    opts.intra_op_num_threads = 8
    opts.execution_mode = ort.ExecutionMode.ORT_SEQUENTIAL
    opts.graph_optimization_level = ort.GraphOptimizationLevel.ORT_ENABLE_ALL
    print("[Model] Loading BiRefNet session ('birefnet-general') with 8 threads...")
    t0 = time.time()
    session = rembg.new_session("birefnet-general", session_options=opts)
    print(f"[Model] BiRefNet session initialized in {time.time() - t0:.2f}s")
    return session


def process_holograms(limit: int | None = None):
    create_backup()
    progress = load_progress()
    session = init_session()

    all_pngs = sorted([f for f in HOLOGRAMS_DIR.iterdir() if f.is_file() and f.suffix.lower() == ".png"])
    print(f"[Processor] Found {len(all_pngs)} PNG files in {HOLOGRAMS_DIR}")

    to_process: list[Path] = []
    skipped_already_done: list[Path] = []
    skipped_already_trans: list[Path] = []

    for p in all_pngs:
        # Check if already processed in progress and has transparency
        if p.name in progress and progress[p.name].get("status") == "success":
            with Image.open(p) as img:
                if img.mode in ("RGBA", "LA") and img.convert("RGBA").split()[-1].getextrema()[0] < 255:
                    skipped_already_done.append(p)
                    continue

        # Check if already transparent before processing (e.g. official Omega files)
        with Image.open(p) as img:
            if img.mode in ("RGBA", "LA"):
                min_a, max_a = img.convert("RGBA").split()[-1].getextrema()
                if min_a < 255:
                    skipped_already_trans.append(p)
                    progress[p.name] = {
                        "status": "success",
                        "reason": "already_transparent",
                        "size": list(img.size),
                        "timestamp": datetime.now().isoformat(),
                    }
                    continue

        to_process.append(p)

    print(f"[Processor] {len(skipped_already_done)} already processed and verified")
    print(f"[Processor] {len(skipped_already_trans)} already transparent originally")
    print(f"[Processor] {len(to_process)} images to process")

    if limit is not None:
        to_process = to_process[:limit]
        print(f"[Processor] Limit applied: processing next {len(to_process)} images")

    total = len(to_process)
    times: list[float] = []

    for idx, path in enumerate(to_process, 1):
        t0 = time.time()
        # Read from backup to ensure we have pristine uncompressed source
        src_path = BACKUP_DIR / path.name
        if not src_path.exists():
            src_path = path

        try:
            with Image.open(src_path) as src_img:
                src_rgba = src_img.convert("RGBA")
                
                # Perform AI background removal
                out = rembg.remove(src_rgba, session=session)
                
                # Ensure output dimensions are 512x512
                if out.size != (OUTPUT_SIZE, OUTPUT_SIZE):
                    out = out.resize((OUTPUT_SIZE, OUTPUT_SIZE), Image.Resampling.LANCZOS)
                
                alpha = out.split()[-1]
                min_a, max_a = alpha.getextrema()
                
                # Calculate foreground ratio
                import numpy as np
                arr_a = np.array(alpha)
                fg_ratio = float(np.count_nonzero(arr_a > 128) / (OUTPUT_SIZE * OUTPUT_SIZE))
                trans_ratio = float(np.count_nonzero(arr_a == 0) / (OUTPUT_SIZE * OUTPUT_SIZE))

                # Save atomically
                tmp_dest = path.with_suffix(".tmp.png")
                out.save(tmp_dest, format="PNG", optimize=True)
                
                # Verify temp file
                with Image.open(tmp_dest) as chk:
                    chk.verify()
                
                # Replace original file
                tmp_dest.replace(path)
                
                dt = time.time() - t0
                times.append(dt)
                avg_time = sum(times) / len(times)
                remaining_time = avg_time * (total - idx)
                eta_str = time.strftime("%Hh %Mm %Ss", time.gmtime(remaining_time))

                progress[path.name] = {
                    "status": "success",
                    "fg_ratio": round(fg_ratio, 4),
                    "trans_ratio": round(trans_ratio, 4),
                    "min_alpha": int(min_a),
                    "max_alpha": int(max_a),
                    "process_time_s": round(dt, 2),
                    "timestamp": datetime.now().isoformat(),
                }
                save_progress(progress)

                print(
                    f"[{idx}/{total}] {path.name:15s} "
                    f"fg={fg_ratio:.1%} trans={trans_ratio:.1%} "
                    f"took={dt:.1f}s | avg={avg_time:.1f}s | ETA: {eta_str}",
                    flush=True,
                )

        except Exception as e:
            dt = time.time() - t0
            print(f"[{idx}/{total}] ERROR processing {path.name}: {e}", flush=True)
            progress[path.name] = {
                "status": "error",
                "error": str(e),
                "timestamp": datetime.now().isoformat(),
            }
            save_progress(progress)

    print("\n[Processor] Batch run finished!")


if __name__ == "__main__":
    import argparse
    parser = argparse.ArgumentParser()
    parser.add_argument("--limit", type=int, default=None, help="Limit number of images to process")
    args = parser.parse_args()
    process_holograms(limit=args.limit)

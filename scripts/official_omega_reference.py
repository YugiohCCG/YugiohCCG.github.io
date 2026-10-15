"""Pinned, real Omega database for reproducible offline/CI verification."""
from __future__ import annotations

import gzip
import hashlib
import json
import os
from pathlib import Path
import sqlite3
from contextlib import closing

ROOT = Path(__file__).resolve().parents[1]
SNAPSHOT = ROOT / "scripts" / "data" / "official-omega.db.gz"
METADATA = SNAPSHOT.with_suffix(".json")


def official_database() -> Path:
    override = os.environ.get("OMEGA_OFFICIAL_DB")
    if override:
        path = Path(override)
        validate_database(path)
        return path
    if not SNAPSHOT.is_file() or not METADATA.is_file():
        raise RuntimeError("Pinned official Omega reference is missing; restore scripts/data/official-omega.db.gz and its metadata")
    metadata = json.loads(METADATA.read_text(encoding="utf-8"))
    target = ROOT / "tmp" / "qa-reference" / (metadata["sha256"] + ".db")
    if not target.exists() or hashlib.sha256(target.read_bytes()).hexdigest() != metadata["sha256"]:
        target.parent.mkdir(parents=True, exist_ok=True)
        data = gzip.decompress(SNAPSHOT.read_bytes())
        if hashlib.sha256(data).hexdigest() != metadata["sha256"]:
            raise RuntimeError("Pinned official Omega reference checksum mismatch")
        temp = target.with_suffix(".tmp")
        temp.write_bytes(data)
        temp.replace(target)
    validate_database(target)
    return target


def validate_database(path: Path) -> None:
    if not path.is_file() or path.stat().st_size == 0:
        raise RuntimeError(f"Official Omega database missing or empty: {path}")
    with closing(sqlite3.connect(f"file:{path.resolve().as_posix()}?mode=ro", uri=True)) as db:
        try:
            db.execute("SELECT d.id,d.type,d.setcode,t.name,t.desc FROM datas d JOIN texts t USING(id) LIMIT 1").fetchone()
        except sqlite3.DatabaseError as exc:
            raise RuntimeError(f"Official Omega database has no valid datas/texts schema: {path}") from exc


if __name__ == "__main__":
    print(f"Validated official Omega reference: {official_database()}")

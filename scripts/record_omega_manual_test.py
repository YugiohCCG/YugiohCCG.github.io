#!/usr/bin/env python3
"""Record replay/log evidence for one ruling-sensitive Omega test."""

from __future__ import annotations

import argparse
import datetime as dt
import hashlib
import json
import shutil
import subprocess
import sys
from pathlib import Path
from urllib.request import urlopen


ROOT = Path(__file__).resolve().parents[1]
LEDGER = ROOT / "scripts" / "output" / "omega_manual_test_ledger.json"
EVIDENCE_ROOT = ROOT / "scripts" / "output" / "omega_test_evidence"
BUILDER = ROOT / "scripts" / "build_omega_manual_test_ledger.py"
OMEGA_LOG_URL = "http://localhost:19999/get-duel-log"
REQUIRED_FOR_PASS = (
    "tester",
    "tested_at",
    "omega_build",
    "ruling_adopted",
    "positive_case",
    "negative_boundary_case",
    "replay_or_log",
    "evidence_sha256",
    "observed_result",
    "reviewer",
)


def sha256(path: Path) -> str:
    digest = hashlib.sha256()
    with path.open("rb") as stream:
        for chunk in iter(lambda: stream.read(1024 * 1024), b""):
            digest.update(chunk)
    return digest.hexdigest()


def load_ledger() -> dict:
    if not LEDGER.is_file():
        raise SystemExit(f"Ledger is missing: {LEDGER}")
    return json.loads(LEDGER.read_text(encoding="utf-8"))


def find_test(ledger: dict, card_id: int) -> dict:
    for test in ledger.get("tests", []):
        if int(test.get("card_id", 0)) == card_id:
            return test
    raise SystemExit(f"Card {card_id} is not in the 123-card live-test ledger")


def store_evidence(card_id: int, source: Path | None, capture_log: bool) -> tuple[str, str]:
    timestamp = dt.datetime.now(dt.timezone.utc).strftime("%Y%m%dT%H%M%SZ")
    destination_dir = EVIDENCE_ROOT / str(card_id)
    destination_dir.mkdir(parents=True, exist_ok=True)
    if capture_log:
        try:
            with urlopen(OMEGA_LOG_URL, timeout=10) as response:
                content = response.read()
        except Exception as exc:
            raise SystemExit(f"Could not capture Omega duel log: {exc}") from exc
        destination = destination_dir / f"{timestamp}-duel-log.txt"
        destination.write_bytes(content)
    else:
        assert source is not None
        source = source.expanduser().resolve()
        if not source.is_file():
            raise SystemExit(f"Evidence file does not exist: {source}")
        destination = destination_dir / f"{timestamp}-{source.name}"
        shutil.copy2(source, destination)
    return destination.relative_to(ROOT).as_posix(), sha256(destination)


def main() -> int:
    parser = argparse.ArgumentParser(description=__doc__)
    parser.add_argument("--card", type=int, help="Card passcode to update")
    parser.add_argument("--next", action="store_true", help="Print the next pending test and exit")
    parser.add_argument("--status", choices=("pending", "passed", "failed", "blocked"))
    parser.add_argument("--tester")
    parser.add_argument("--omega-build")
    parser.add_argument("--ruling")
    parser.add_argument("--positive")
    parser.add_argument("--negative")
    parser.add_argument("--interruption")
    parser.add_argument("--observed")
    parser.add_argument("--change-required")
    parser.add_argument("--retest")
    parser.add_argument("--reviewer")
    evidence = parser.add_mutually_exclusive_group()
    evidence.add_argument("--evidence", type=Path, help="Replay or log file to copy and hash")
    evidence.add_argument("--capture-omega-log", action="store_true")
    args = parser.parse_args()

    ledger = load_ledger()
    if args.next:
        test = next(
            (item for item in ledger.get("tests", []) if item.get("result", {}).get("status") == "pending"),
            None,
        )
        if test is None:
            print("pending=0")
            return 0
        print(f"card_id={test['card_id']}")
        print(f"card_name={test['card_name']}")
        print(f"workstream={test['workstream']}")
        print(f"test_decks={', '.join(test.get('test_decks', []))}")
        print(f"problem={test['problem']}")
        return 0
    if args.card is None:
        parser.error("--card is required unless --next is used")

    test = find_test(ledger, args.card)
    result = test["result"]
    updates = {
        "status": args.status,
        "tester": args.tester,
        "omega_build": args.omega_build,
        "ruling_adopted": args.ruling,
        "positive_case": args.positive,
        "negative_boundary_case": args.negative,
        "interruption_case": args.interruption,
        "observed_result": args.observed,
        "change_required": args.change_required,
        "retest_result": args.retest,
        "reviewer": args.reviewer,
    }
    for key, value in updates.items():
        if value is not None:
            result[key] = value
    if args.evidence is not None or args.capture_omega_log:
        evidence_path, evidence_hash = store_evidence(args.card, args.evidence, args.capture_omega_log)
        result["replay_or_log"] = evidence_path
        result["evidence_sha256"] = evidence_hash
    if args.status is not None and not result.get("tested_at"):
        result["tested_at"] = dt.datetime.now(dt.timezone.utc).isoformat(timespec="seconds")

    if result.get("status") == "passed":
        missing = [field for field in REQUIRED_FOR_PASS if not result.get(field)]
        if missing:
            raise SystemExit(f"Cannot mark {args.card} passed; missing: {', '.join(missing)}")

    LEDGER.write_text(json.dumps(ledger, indent=2, ensure_ascii=False) + "\n", encoding="utf-8")
    completed = subprocess.run([sys.executable, str(BUILDER)], cwd=ROOT, check=False)
    if completed.returncode:
        return completed.returncode
    print(f"recorded={args.card}")
    print(f"status={result.get('status', 'pending')}")
    if result.get("replay_or_log"):
        print(f"evidence={result['replay_or_log']}")
        print(f"evidence_sha256={result.get('evidence_sha256', '')}")
    return 0


if __name__ == "__main__":
    raise SystemExit(main())

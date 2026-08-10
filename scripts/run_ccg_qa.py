#!/usr/bin/env python3
"""Run the complete CCG database QA suite and write current reports."""

from __future__ import annotations

import argparse
import datetime as dt
import json
import os
import re
import shutil
import subprocess
import time
from pathlib import Path
from typing import Any


ROOT = Path(__file__).resolve().parents[1]
REPORT_JSON = ROOT / "docs" / "ccg-comprehensive-bug-test-report.json"
REPORT_MARKDOWN = ROOT / "docs" / "ccg-comprehensive-bug-test-report.md"
MANIFEST = ROOT / "scripts" / "output" / "ccg_qa_manifest.json"
SEMANTIC_REPORT = ROOT / "scripts" / "output" / "ccg_lua_semantic_audit.json"
LIVE_TEST_LEDGER = ROOT / "scripts" / "output" / "omega_manual_test_ledger.json"
HEADLESS_REPORT = ROOT / "scripts" / "output" / "omega_headless_registration_audit.json"
FIELD_PROBE_REPORT = ROOT / "scripts" / "output" / "omega_headless_field_probe.json"
NAMED_RELATIONS_REPORT = ROOT / "scripts" / "output" / "omega_named_card_relations.json"
SCRIPTS_DIR = ROOT / "public" / "CCG Downloads" / "CCG_Scripts"
ANSI_RE = re.compile(r"\x1b\[[0-9;]*[A-Za-z]")


def executable(name: str) -> str:
    resolved = shutil.which(name)
    if resolved:
        return resolved
    if os.name == "nt" and (resolved := shutil.which(f"{name}.cmd")):
        return resolved
    if name in {"lua", "luac"} and (resolved := shutil.which(f"{name}5.4")):
        return resolved
    raise RuntimeError(f"Required executable is not available: {name}")


def lua_syntax() -> tuple[int, str]:
    luac = executable("luac")
    scripts = sorted(SCRIPTS_DIR.glob("c*.lua"))
    failures: list[str] = []
    for script in scripts:
        result = subprocess.run(
            [luac, "-p", str(script)],
            cwd=ROOT,
            capture_output=True,
            text=True,
            encoding="utf-8",
            errors="replace",
            check=False,
        )
        if result.returncode:
            failures.append(f"{script.name}: {(result.stderr or result.stdout).strip()}")
    lines = [f"scripts={len(scripts)}", f"errors={len(failures)}", *failures[:50]]
    return (1 if failures else 0), "\n".join(lines)


def run_check(name: str, command: list[str] | None = None, *, special: str | None = None) -> dict[str, Any]:
    started = time.monotonic()
    try:
        if special == "lua_syntax":
            returncode, output = lua_syntax()
        else:
            assert command is not None
            result = subprocess.run(
                command,
                cwd=ROOT,
                capture_output=True,
                text=True,
                encoding="utf-8",
                errors="replace",
                check=False,
                timeout=180,
            )
            returncode = result.returncode
            output = "\n".join(part.strip() for part in (result.stdout, result.stderr) if part.strip())
    except Exception as exc:  # report infrastructure failures alongside test failures
        returncode = 1
        output = f"{type(exc).__name__}: {exc}"
    return {
        "name": name,
        "status": "PASS" if returncode == 0 else "FAIL",
        "returncode": returncode,
        "duration_seconds": round(time.monotonic() - started, 3),
        "output": ANSI_RE.sub("", output),
    }


def load_json(path: Path) -> dict[str, Any] | None:
    try:
        return json.loads(path.read_text(encoding="utf-8"))
    except (OSError, json.JSONDecodeError):
        return None


def compact_artifact(payload: dict[str, Any] | None, *, include: tuple[str, ...] = ()) -> dict[str, Any] | None:
    if payload is None:
        return None
    result = {"summary": payload.get("summary", {}), "errors": payload.get("errors", [])}
    for key in include:
        result[key] = payload.get(key, [])
    return result


def markdown_report(report: dict[str, Any]) -> str:
    manifest = report.get("manifest") or {}
    semantic = report.get("semantic_audit") or {}
    summary = manifest.get("summary") or {}
    semantic_summary = semantic.get("summary") or {}
    live_summary = (report.get("live_test_ledger") or {}).get("summary") or {}
    headless_summary = (report.get("headless_registration") or {}).get("summary") or {}
    field_summary = (report.get("headless_field_probe") or {}).get("summary") or {}
    lines = [
        "# CCG Comprehensive Bug Test Report",
        "",
        f"Generated: {report['generated_at']}",
        "",
        "## Result",
        "",
        f"**Automated {report['status']}** — {report['checks_passed']} of {report['checks_total']} checks passed.",
        "",
        f"**Live-engine certification: {report['live_certification_status']}** — "
        f"{live_summary.get('passed', 0)} of {live_summary.get('total', 0)} ruling-sensitive cards have replay-backed passes.",
        "",
        "## Audited scope",
        "",
        f"- Active cards: {summary.get('active_cards', 'unknown')}",
        f"- Lua scripts: {summary.get('scripts', 'unknown')} (including compatibility scripts: {summary.get('compatibility_scripts', [])})",
        f"- SQLite rows: {summary.get('database_rows', 'unknown')}",
        f"- Primary archetypes: {summary.get('primary_archetypes', 'unknown')}",
        f"- Effect creations indexed: {semantic_summary.get('effect_creations', 'unknown')}",
        f"- Callback functions indexed: {semantic_summary.get('callback_functions', 'unknown')}",
        f"- Search/selection calls indexed: {semantic_summary.get('search_calls', 'unknown')}",
        f"- Open semantic errors: {semantic_summary.get('errors', 'unknown')}",
        f"- Open semantic review candidates: {semantic_summary.get('review_candidates', 'unknown')}",
        f"- Hash-pinned reviewed semantic findings: {semantic_summary.get('accepted_reviewed_findings', 'unknown')}",
        f"- Generated decks covering active cards: {report.get('test_deck_coverage', {}).get('custom_cards_covered', 'unknown')} cards",
        f"- Headless Omega registrations passed: {headless_summary.get('passed', 'unknown')} of {headless_summary.get('cards_tested', 'unknown')}",
        f"- Face-up field startup probes passed: {field_summary.get('passed', 'unknown')} of {field_summary.get('cards_tested', 'unknown')} "
        f"(public-core ABI exclusions: {field_summary.get('infrastructure_excluded', 'unknown')})",
        f"- Pending live Omega scenarios: {live_summary.get('pending', 'unknown')}",
        "",
        "## Verification gates",
        "",
        "| Gate | Status | Seconds |",
        "|---|---:|---:|",
    ]
    for check in report["checks"]:
        lines.append(f"| {check['name']} | {check['status']} | {check['duration_seconds']:.3f} |")
    failed = [check for check in report["checks"] if check["status"] != "PASS"]
    if failed:
        lines.extend(["", "## Failures", ""])
        for check in failed:
            lines.extend([f"### {check['name']}", "", "```text", check["output"][-8000:], "```", ""])
    lines.extend([
        "",
        "## Interpretation",
        "",
        "A pass proves the automated contracts represented by these gates. Hash-pinned reviewed findings are intentional multi-stage search routes and are automatically reopened if their Lua source changes. Bespoke mechanics and ruling-sensitive behavior listed in the semantic audit still require live Omega scenario testing; they are not represented as confirmed defects.",
        "",
    ])
    return "\n".join(lines)


def main() -> int:
    parser = argparse.ArgumentParser(description=__doc__)
    parser.add_argument("--ci", action="store_true", help="Run gates that do not require a local Omega installation.")
    parser.add_argument("--fast", action="store_true", help="Skip release verification and production build.")
    parser.add_argument("--no-report", action="store_true", help="Do not rewrite docs reports.")
    args = parser.parse_args()

    python = executable("python")
    node = executable("node")
    npm = executable("npm")
    checks: list[tuple[str, list[str] | None, str | None]] = [
        ("Authoritative card manifest", [python, "scripts/build_ccg_qa_manifest.py"], None),
        ("Lua compiler syntax", None, "lua_syntax"),
        ("Lua semantic and search-condition audit", [node, "scripts/verify_ccg_lua_semantics.cjs", "--strict-review"], None),
        ("Omega callback smoke", [python, "scripts/verify_omega_callbacks.py"], None),
        ("Message routes", [python, "scripts/verify_omega_message_routes.py"], None),
        ("Script ZIP parity", [python, "scripts/package_omega_ccg_scripts.py", "--check"], None),
        ("Public card data parity", [node, "scripts/sync-public-cards.cjs", "--check"], None),
        ("Omega test-deck coverage", [python, "scripts/build_omega_test_decks.py"], None),
        ("Live-test ledger integrity", [python, "scripts/build_omega_manual_test_ledger.py"], None),
        ("Website filter/search unit tests", [npm, "test"], None),
        ("TypeScript/React lint", [npm, "run", "lint"], None),
    ]
    if not args.ci:
        checks[4:4] = [
            ("Omega runtime references", [python, "scripts/verify_omega_runtime_references.py"], None),
            ("Archetype interoperability", [python, "scripts/verify_omega_archetypes.py"], None),
            ("Named-card runtime relationships", [python, "scripts/verify_omega_named_card_relations.py", "--strict"], None),
            ("Headless Omega registration", [python, "scripts/verify_omega_headless_registration.py"], None),
        ]
    if not args.fast:
        if not args.ci:
            checks.append(("Omega release integrity", [python, "scripts/verify_omega_release.py"], None))
        checks.append(("Production build", [npm, "run", "build"], None))

    results: list[dict[str, Any]] = []
    for name, command, special in checks:
        print(f"[{len(results) + 1}/{len(checks)}] {name}", flush=True)
        result = run_check(name, command, special=special)
        results.append(result)
        print(f"  {result['status']} ({result['duration_seconds']:.3f}s)", flush=True)
        if result["status"] != "PASS":
            print(result["output"][-4000:], flush=True)

    passed = sum(result["status"] == "PASS" for result in results)
    live_ledger = load_json(LIVE_TEST_LEDGER)
    live_summary = (live_ledger or {}).get("summary") or {}
    deck_coverage: dict[str, Any] = {}
    for check in results:
        if check["name"] == "Omega test-deck coverage":
            for line in check["output"].splitlines():
                if "=" in line:
                    key, value = line.split("=", 1)
                    if value.isdigit():
                        deck_coverage[key] = int(value)
    manifest_payload = load_json(MANIFEST)
    semantic_payload = load_json(SEMANTIC_REPORT)
    headless_payload = load_json(HEADLESS_REPORT)
    field_probe_payload = load_json(FIELD_PROBE_REPORT)
    report = {
        "schema_version": 1,
        "generated_at": dt.datetime.now(dt.timezone.utc).isoformat(timespec="seconds"),
        "mode": "ci" if args.ci else ("fast" if args.fast else "full"),
        "status": "PASS" if passed == len(results) else "FAIL",
        "checks_total": len(results),
        "checks_passed": passed,
        "live_certification_status": "COMPLETE"
        if live_summary.get("passed", 0) == live_summary.get("total", -1)
        else "INCOMPLETE",
        "checks": results,
        "artifacts": {
            "card_manifest": MANIFEST.relative_to(ROOT).as_posix(),
            "semantic_audit": SEMANTIC_REPORT.relative_to(ROOT).as_posix(),
            "live_test_ledger": LIVE_TEST_LEDGER.relative_to(ROOT).as_posix(),
            "headless_registration": HEADLESS_REPORT.relative_to(ROOT).as_posix(),
            "headless_field_probe": FIELD_PROBE_REPORT.relative_to(ROOT).as_posix(),
            "named_card_relations": NAMED_RELATIONS_REPORT.relative_to(ROOT).as_posix(),
        },
        "manifest": compact_artifact(manifest_payload),
        "semantic_audit": compact_artifact(
            semantic_payload,
            include=("findings", "accepted_findings", "stale_reviewed_findings"),
        ),
        "test_deck_coverage": deck_coverage,
        "live_test_ledger": compact_artifact(live_ledger),
        "headless_registration": compact_artifact(headless_payload),
        "headless_field_probe": compact_artifact(field_probe_payload),
    }
    if not args.no_report:
        REPORT_JSON.write_text(json.dumps(report, indent=2, ensure_ascii=False) + "\n", encoding="utf-8")
        REPORT_MARKDOWN.write_text(markdown_report(report), encoding="utf-8")
        print(f"report_json={REPORT_JSON}")
        print(f"report_markdown={REPORT_MARKDOWN}")
    print(f"result={report['status']} checks={passed}/{len(results)}")
    return 0 if report["status"] == "PASS" else 1


if __name__ == "__main__":
    raise SystemExit(main())

"""Fresh evidence baseline. Never imports prior audit results or modifies inputs."""
import hashlib
import json
import sqlite3
import subprocess
import sys
from collections import Counter
from pathlib import Path

ROOT = Path(__file__).resolve().parents[1]
OUT = ROOT / "output/fresh-ccg-september"


def digest(data):
    return hashlib.sha256(data).hexdigest()


def conflict_views(text):
    """Read both sides without choosing a merge resolution on disk."""
    views = [[], []]
    side = None
    count = 0
    for line in text.splitlines(keepends=True):
        if line.startswith("<<<<<<< "):
            assert side is None, "Nested conflict"
            side = 0
            count += 1
        elif line.startswith("======="):
            assert side == 0, "Unexpected separator"
            side = 1
        elif line.startswith(">>>>>>> "):
            assert side == 1, "Unexpected conflict end"
            side = None
        elif line.startswith("||||||| "):
            raise ValueError("Diff3 conflicts require explicit review")
        else:
            for i in range(2):
                if side is None or side == i:
                    views[i].append(line)
    assert side is None, "Unterminated conflict"
    return [json.loads("".join(view)) for view in views], count


def main():
    remote = "--remote" in sys.argv
    revision = subprocess.check_output(["git", "rev-parse", "origin/main"], cwd=ROOT, text=True).strip() if remote else None
    raw = subprocess.check_output(["git", "show", f"{revision}:src/data/cards.json"], cwd=ROOT) if remote else (ROOT / "src/data/cards.json").read_bytes()
    views, conflicts = conflict_views(raw.decode("utf-8-sig"))
    # Legality flags and artwork are not effect specifications. Preserve all other
    # fields in the comparison rather than assuming conflicts are harmless.
    def mechanics(card):
        return {k: v for k, v in card.items() if k not in
                {"legal", "image", "timestamps"}}
    left, right = [{c["passcode"]: c for c in view} for view in views]
    duplicates = [dict((k, v) for k, v in Counter(c["passcode"] for c in view).items()
                       if v > 1) for view in views]
    disputed = [code for code in sorted(left.keys() | right.keys())
                if mechanics(left.get(code, {})) != mechanics(right.get(code, {}))]
    dbpath = ROOT / "public/CCG Downloads/CCG_Database/CCG_v1.db"
    with sqlite3.connect(dbpath.as_uri() + "?mode=ro", uri=True) as db:
        database = {code: (name, desc) for code, name, desc in
                    db.execute("select id,name,desc from texts")}
    scripts = ROOT / "public/CCG Downloads/CCG_Scripts"
    references = ROOT / "tmp/omega_scripts"
    reference_hashes = {p.relative_to(references).as_posix(): digest(p.read_bytes())
                        for p in sorted(references.rglob("*.lua"))}
    cards = []
    for code in sorted(left.keys() | right.keys()):
        card = left.get(code, right.get(code))
        path = scripts / f"c{code}.lua"
        entry = database.get(code)
        cards.append({
            "passcode": code, "name": card["name"], "text": card.get("text"),
            "specification": card,
            "source_disputed": code in disputed,
            "script_sha256": digest(path.read_bytes()) if path.exists() else None,
            "database_present": entry is not None,
            "database_name_matches": entry is not None and entry[0] == card["name"],
            "database_text_matches": entry is not None and entry[1] == card.get("text"),
            "database_text": entry[1] if entry else None,
            "effect_verification": "UNTESTED", "scenarios": [], "omega_references": [],
        })
    report = {
        "method": "Fresh specification-led differential duel scenarios; baseline only",
        "prior_results_imported": False,
        "source_revision": revision,
        "source_sha256": digest(raw), "database_sha256": digest(dbpath.read_bytes()),
        "merge_conflicts": conflicts, "duplicate_passcodes": duplicates,
        "mechanically_disputed_passcodes": disputed,
        "omega_reference_files": len(reference_hashes),
        "omega_reference_tree_sha256": digest(json.dumps(reference_hashes, sort_keys=True).encode()),
        "summary": {
            "cards": len(cards), "verified": 0, "untested": len(cards),
            "missing_scripts": sum(c["script_sha256"] is None for c in cards),
            "missing_database_entries": sum(not c["database_present"] for c in cards),
            "database_text_differences": sum(not c["database_text_matches"] for c in cards),
        },
        "cards": cards,
    }
    OUT.mkdir(parents=True, exist_ok=True)
    (OUT / ("baseline-remote.json" if remote else "baseline.json")).write_text(json.dumps(report, indent=2, ensure_ascii=False) + "\n", encoding="utf-8")
    (OUT / "omega-reference-hashes.json").write_text(json.dumps(reference_hashes, indent=2) + "\n", encoding="utf-8")
    print(json.dumps({k: v for k, v in report.items() if k != "cards"}, indent=2))


if __name__ == "__main__":
    main()

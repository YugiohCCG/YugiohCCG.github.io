"""Run focused cases and existing regression gates; keep complete command logs."""
import hashlib
import json
import subprocess
from pathlib import Path

ROOT = Path(__file__).resolve().parents[1]
OUT = ROOT / 'output/fresh-ccg-september/nautica-full-field-tribute-batch'
OUT.mkdir(exist_ok=True)
steps = [
    ('oceanica-focused', ['node', '--no-warnings', 'scripts/fresh_current_oceanica_summon_followup.cjs', '--full-field-tribute']),
    ('return-focused', ['node', '--no-warnings', 'scripts/test_nautica_full_field_tribute.cjs']),
    ('engine-regression', ['python', 'scripts/run_ohmen_engine_regressions.py', 'nautica-tribute-20261115']),
    ('additional-engine-probes', ['node', '--no-warnings', 'scripts/test_ohmen_engine_probes.cjs']),
    ('roster-syntax', ['node', 'scripts/fresh_roster_syntax.cjs']),
    ('installed-init', ['python', 'scripts/fresh_current_installed_init_batch.py']),
    ('ohmen-gate', ['python', 'scripts/fresh_current_ohmen_batch.py']),
    ('repair-ledger', ['python', 'scripts/fresh_repair_ledger.py']),
    ('specification-drift', ['python', 'scripts/fresh_current_spec_drift.py']),
]
runs = []
for name, command in steps:
    try:
        process = subprocess.run(command, cwd=ROOT, capture_output=True, timeout=300)
        output = process.stdout + b'\nSTDERR:\n' + process.stderr
        status = process.returncode
    except subprocess.TimeoutExpired as error:
        output = (error.stdout or b'') + b'\nTIMEOUT\n' + (error.stderr or b'')
        status = 'TIMEOUT'
    log = OUT / (name + '.log')
    log.write_bytes(output)
    runs.append(dict(name=name, command=command, status=status, log=str(log.relative_to(ROOT)),
                     log_sha256=hashlib.sha256(output).hexdigest()))
    (OUT / 'commands.json').write_text(json.dumps(runs, indent=2) + '\n')
    print(f'{name}: {status}; {log.name}', flush=True)

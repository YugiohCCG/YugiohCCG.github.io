"""Read-only source/install comparison for the resumed archetype audit."""
import hashlib
import json
from pathlib import Path

ROOT = Path(__file__).resolve().parents[1]
SOURCE = ROOT / 'public/CCG Downloads/CCG_Scripts'
INSTALLED = Path(r'C:\Program Files (x86)\YGO Omega\YGO Omega_Data\Files\Scripts')
OUT = ROOT / 'output/fresh-ccg-september/resume-baseline-20261115.json'

def digest(path):
    return hashlib.sha256(path.read_bytes()).hexdigest() if path.exists() else None

rows = []
for source in sorted(SOURCE.glob('c*.lua')):
    installed = INSTALLED / source.name
    a, b = digest(source), digest(installed)
    content_match = installed.exists() and source.read_text(encoding='utf-8-sig') == installed.read_text(encoding='utf-8-sig')
    rows.append(dict(file=source.name, source_sha256=a, installed_sha256=b, match=a == b, content_match=content_match))
summary = ROOT / 'scripts/output/ohmen-lua-regressions/resume-baseline-20261115-summary.json'
runs = json.loads(summary.read_text())
report = dict(
    source_count=len(rows), installed_mismatches=sum(not row['match'] for row in rows),
    installed_content_mismatches=sum(not row['content_match'] for row in rows),
    engine_summary=str(summary.relative_to(ROOT)), engine_summary_sha256=digest(summary),
    engine_families=len(runs), engine_failed_families=sum(run['status'] != 0 for run in runs),
    engine_passing_cases=sum(line.startswith('PASS ') for run in runs for line in run['stdout'].splitlines()),
    reported_716_baseline='Not located or verified in this checkout',
    live_omega_duel_verification='Not performed', files=rows)
OUT.write_text(json.dumps(report, indent=2) + '\n', encoding='utf-8')
print(json.dumps({key: value for key, value in report.items() if key != 'files'}, indent=2))

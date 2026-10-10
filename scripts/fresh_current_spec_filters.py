"""Validate bounded current-text filter changes without claiming native execution."""
import hashlib,json,subprocess,shutil
from pathlib import Path
ROOT=Path(__file__).resolve().parents[1];OUT=ROOT/'output/fresh-ccg-september'
def sha(p):return hashlib.sha256(p.read_bytes()).hexdigest()
codes=[259073666,259160760,259348317,259763531,259152704]
deps=[Path(__file__),ROOT/'scripts/fresh_current_spec_filters.lua',ROOT/'tmp/omega_scripts/constant.lua',OUT/'current-spec-CCG_v1.db',Path(shutil.which('lua'))]
deps += [ROOT/f'public/CCG Downloads/CCG_Scripts/c{code}.lua' for code in codes]
before={str(p):sha(p) for p in deps};runs=[]
for control in [None]+['old-insect-'+str(c) for c in codes[:4]]:
 result=subprocess.run(['lua','scripts/fresh_current_spec_filters.lua']+(['--'+control] if control else []),cwd=ROOT,capture_output=True,text=True)
 assert result.returncode==(1 if control else 0),result.stdout+result.stderr
 if control:assert 'stack traceback' in result.stderr
 else:assert result.stdout.strip()=='PASS 356 current-spec filter assertions'
 runs.append({'control':control,'exit_status':result.returncode,'stdout':result.stdout,'stderr':result.stderr})
assert before=={str(p):sha(p) for p in deps}
report={'scope':'Five cards: current printed race/set eligibility deltas only. Production callbacks with mock Card/Duel boundaries. No actual fusion, cost, search, lock enforcement, summon or native Omega proof. Not full audits or additional repairs.','passcodes':codes,'baseline_assertions':356,'dependencies_sha256':before,'runs':runs}
(OUT/'current-spec-filter-validation.json').write_text(json.dumps(report,indent=2)+'\n')
print('356 filter assertions and four independent old-Insect controls verified')

import hashlib,json,subprocess
from pathlib import Path
ROOT=Path(__file__).resolve().parents[1];OUT=ROOT/'output/fresh-ccg-september'
def sha(p):return hashlib.sha256(p.read_bytes()).hexdigest()
paths=[ROOT/'tmp/omega_scripts/c59822133.lua',Path(__file__),ROOT/'scripts/fresh_current_gambling_mixed_rolls.cjs',ROOT/'scripts/fresh_current_card.cjs',ROOT/'public/CCG Downloads/CCG_Scripts/c224774049.lua',OUT/'current-spec-CCG_v1.db']+[ROOT/'tmp/omega_scripts'/n for n in ['constant.lua','utility.lua','procedure.lua']]+list((ROOT/'node_modules/@n1xx1/ocgcore-wasm/dist').glob('*.js'))
before={p.relative_to(ROOT).as_posix():sha(p) for p in paths};runs=[]
for control in [None,'no-add','one-card']:
 result=subprocess.run(['node','--no-warnings','scripts/fresh_current_gambling_mixed_rolls.cjs']+(['--'+control] if control else []),cwd=ROOT,capture_output=True,text=True,timeout=30)
 p=OUT/('current-gambling-mixed-rolls'+('-'+control if control else '')+'.json');data=json.loads(p.read_text())
 if control is None:
  baseline=data['results'];assert sorted(set(r['observedRoll'] for r in baseline))==list(range(1,7));expected=[]
 else:expected=[r['test'] for r in baseline if r['expectedHit']] if control=='no-add' else [r['test'] for r in baseline if r['observedRoll']>1]
 assert result.returncode==(1 if control else 0),result.stdout+result.stderr
 assert [r['test'] for r in data['results'] if r['failure']]==expected
 runs.append({'control':control,'expected_failures':expected,'artifact':p.name,'artifact_sha256':sha(p)})
assert before=={p.relative_to(ROOT).as_posix():sha(p) for p in paths}
(OUT/'current-gambling-mixed-rolls-batch.json').write_text(json.dumps({'scope':data['scope'],'baseline_cases':192,'runtime_dependencies_sha256':before,'runs':runs},indent=2)+'\n')
print('Pot Gambling native mixed192 cases/2 controls verified')

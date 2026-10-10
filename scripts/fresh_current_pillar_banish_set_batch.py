import hashlib,json,subprocess
from pathlib import Path
ROOT=Path(__file__).resolve().parents[1];OUT=ROOT/'output/fresh-ccg-september'
def sha(p):return hashlib.sha256(p.read_bytes()).hexdigest()
paths=[ROOT/'tmp/omega_scripts/c59822133.lua',Path(__file__),ROOT/'scripts/fresh_current_pillar_banish_set.cjs',ROOT/'scripts/fresh_current_card.cjs',ROOT/'public/CCG Downloads/CCG_Scripts/c235051716.lua',OUT/'current-spec-CCG_v1.db']+[ROOT/'tmp/omega_scripts'/n for n in ['constant.lua','utility.lua','procedure.lua']]+list((ROOT/'node_modules/@n1xx1/ocgcore-wasm/dist').glob('*.js'))
assert (ROOT/'public/CCG Downloads/CCG_Scripts/c235051716.lua').read_bytes()==Path(r'C:\Program Files (x86)\YGO Omega\YGO Omega_Data\Files\Scripts\c235051716.lua').read_bytes()
before={p.relative_to(ROOT).as_posix():sha(p) for p in paths};runs=[]
for control in [None,'no-set','ignore-set','ignore-reason']:
 result=subprocess.run(['node','--no-warnings','scripts/fresh_current_pillar_banish_set.cjs']+(['--'+control] if control else []),cwd=ROOT,capture_output=True,text=True,timeout=30)
 p=OUT/('current-pillar-banish-set'+('-'+control if control else '')+'.json');data=json.loads(p.read_text());expected=([{'origin':o} for o in ['hand','grave','field']] if control=='no-set' else [{'origin':'hand','wrongSet':True}] if control=='ignore-set' else [{'origin':'hand','cost':True}]) if control else []
 assert result.returncode==(1 if control else 0),result.stdout+result.stderr
 assert [r['test'] for r in data['results'] if r['failure']]==expected
 runs.append({'control':control,'expected_failures':expected,'artifact':p.name,'artifact_sha256':sha(p)})
assert before=={p.relative_to(ROOT).as_posix():sha(p) for p in paths}
(OUT/'current-pillar-banish-set-batch.json').write_text(json.dumps({'scope':data['scope'],'baseline_cases':5,'runtime_dependencies_sha256':before,'runs':runs},indent=2)+'\n')
print('PillarBanishSet5cases3controls verified')

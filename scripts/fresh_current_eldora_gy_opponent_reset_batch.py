import hashlib,json,subprocess
from pathlib import Path
ROOT=Path.cwd();OUT=ROOT/'output/fresh-ccg-september'
def sha(p):return hashlib.sha256(p.read_bytes()).hexdigest()
paths=[ROOT/'scripts/fresh_current_eldora_gy_opponent_reset.cjs',Path('scripts/fresh_current_eldora_gy_opponent_reset_batch.py').resolve(),ROOT/'scripts/fresh_current_card.cjs',ROOT/'public/CCG Downloads/CCG_Scripts/c229786055.lua',ROOT/'public/CCG Downloads/CCG_Scripts/c214552846.lua',OUT/'current-spec-CCG_v1.db']+[ROOT/'tmp/omega_scripts'/n for n in ['constant.lua','utility.lua','procedure.lua']]+list((ROOT/'node_modules/@n1xx1/ocgcore-wasm/dist').glob('*.js'))
assert (ROOT/'public/CCG Downloads/CCG_Scripts/c214552846.lua').read_bytes()==Path(r'C:\Program Files (x86)\YGO Omega\YGO Omega_Data\Files\Scripts\c214552846.lua').read_bytes()
before={p.relative_to(ROOT).as_posix():sha(p) for p in paths};runs=[]
for control,expected in [(None,[]),('per-copy',[0,1,2]),('no-reset',[0,1,2]),('no-response',[1,2])]:
 r=subprocess.run(['node','--no-warnings','scripts/fresh_current_eldora_gy_opponent_reset.cjs']+(['--'+control] if control else []),capture_output=True,text=True,timeout=30)
 p=OUT/('current-eldora-gy-opponent-reset'+('-'+control if control else '')+'.json');data=json.loads(p.read_text())
 assert r.returncode==(1 if expected else 0),r.stdout+r.stderr
 assert [i for i,v in enumerate(data['results']) if v['failure']]==expected,(control,r.stdout)
 assert all(not v['logs'] for v in data['results'])
 runs.append({'control':control,'expected_failures':expected,'artifact':p.name,'artifact_sha256':sha(p)})
assert before=={p.relative_to(ROOT).as_posix():sha(p) for p in paths}
(OUT/'current-eldora-gy-opponent-reset-batch.json').write_text(json.dumps({'scope':data['scope'],'baseline_cases':3,'runtime_dependencies_sha256':before,'runs':runs},indent=2)+'\n')
print('Eldora native GY opponent turn reset: three cases/three controls verified.')

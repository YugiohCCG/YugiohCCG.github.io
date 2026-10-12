import hashlib,json,subprocess
from pathlib import Path
ROOT=Path(__file__).resolve().parents[1];OUT=ROOT/'output/fresh-ccg-september'
def sha(p):return hashlib.sha256(p.read_bytes()).hexdigest()
paths=[ROOT/'tmp/omega_scripts/c59822133.lua',Path(__file__),ROOT/'scripts/fresh_current_stellaer_reborn_group.cjs',ROOT/'scripts/fresh_current_card.cjs',ROOT/'public/CCG Downloads/CCG_Scripts/c257549955.lua',OUT/'current-spec-CCG_v1.db']+[ROOT/'tmp/omega_scripts'/n for n in ['constant.lua','utility.lua','procedure.lua']]+list((ROOT/'node_modules/@n1xx1/ocgcore-wasm/dist').glob('*.js'))
before={p.relative_to(ROOT).as_posix():sha(p) for p in paths};runs=[]
for control in [None,'no-replacement','ignore-set','ignore-faceup','ignore-controller']:
 result=subprocess.run(['node','--no-warnings','scripts/fresh_current_stellaer_reborn_group.cjs']+(['--'+control] if control else []),cwd=ROOT,capture_output=True,text=True,timeout=30)
 p=OUT/('current-stellaer-reborn-group'+('-'+control if control else '')+'.json');data=json.loads(p.read_text());expected=([{'mode':m,'decline':False} for m in ['both','wrong-set','facedown','opponent']] if control=='no-replacement' else [{'mode':{'ignore-set':'wrong-set','ignore-faceup':'facedown','ignore-controller':'opponent'}[control],'decline':False}] if control else [])
 assert result.returncode==(1 if control else 0),result.stdout+result.stderr
 assert [r['test'] for r in data['results'] if r['failure']]==expected
 runs.append({'control':control,'expected_failures':expected,'artifact':p.name,'artifact_sha256':sha(p)})
assert before=={p.relative_to(ROOT).as_posix():sha(p) for p in paths}
(OUT/'current-stellaer-reborn-group-batch.json').write_text(json.dumps({'scope':data['scope'],'baseline_cases':8,'runtime_dependencies_sha256':before,'runs':runs},indent=2)+'\n')
print('Stellaer Reborn group8cases4controls verified')

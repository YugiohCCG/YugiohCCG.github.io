import hashlib,json,subprocess
from pathlib import Path
ROOT=Path(__file__).resolve().parents[1];OUT=ROOT/'output/fresh-ccg-september'
def sha(p):return hashlib.sha256(p.read_bytes()).hexdigest()
paths=[ROOT/'public/CCG Downloads/CCG_Scripts/c216140411.lua',ROOT/'public/CCG Downloads/CCG_Scripts/c213266433.lua',Path(__file__),ROOT/'scripts/fresh_current_fruteopia_use_reset_group.cjs',ROOT/'scripts/fresh_current_card.cjs',ROOT/'public/CCG Downloads/CCG_Scripts/c256930605.lua',ROOT/'public/CCG Downloads/CCG_Scripts/c231872299.lua',OUT/'current-spec-CCG_v1.db']+[ROOT/'tmp/omega_scripts'/n for n in ['constant.lua','utility.lua','procedure.lua']]+list((ROOT/'node_modules/@n1xx1/ocgcore-wasm/dist').glob('*.js'))
assert (ROOT/'public/CCG Downloads/CCG_Scripts/c216140411.lua').read_bytes()==Path(r'C:\Program Files (x86)\YGO Omega\YGO Omega_Data\Files\Scripts\c216140411.lua').read_bytes()
before={p.relative_to(ROOT).as_posix():sha(p) for p in paths};runs=[]
for control in [None,'per-copy','split-limit','no-response','no-gain']:
 result=subprocess.run(['node','--no-warnings','scripts/fresh_current_fruteopia_use_reset_group.cjs']+(['--'+control] if control else []),cwd=ROOT,capture_output=True,text=True,timeout=30)
 p=OUT/('current-fruteopia-use-reset-group'+('-'+control if control else '')+'.json');data=json.loads(p.read_text());tests=[{},{'activation':True},{'effect':True}];expected=(tests[1:] if control=='no-response' else tests) if control else []
 assert result.returncode==(1 if control else 0),result.stdout+result.stderr
 assert [r['test'] for r in data['results'] if r['failure']]==expected
 assert not any(r['logs'] for r in data['results']),data['results']
 runs.append({'control':control,'expected_failures':expected,'artifact':p.name,'artifact_sha256':sha(p)})
assert before=={p.relative_to(ROOT).as_posix():sha(p) for p in paths}
(OUT/'current-fruteopia-use-reset-group-batch.json').write_text(json.dumps({'scope':data['scope'],'baseline_cases':3,'certification':'Production focused evidence; native Omega and full card OPEN','runtime_dependencies_sha256':before,'runs':runs},indent=2)+'\n')
print('Fruteopia three grouped shared-use/reset cases and four controls verified')

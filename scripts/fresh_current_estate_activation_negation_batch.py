import hashlib,json,subprocess
from pathlib import Path
ROOT=Path(__file__).resolve().parents[1];OUT=ROOT/'output/fresh-ccg-september'
def sha(p):return hashlib.sha256(p.read_bytes()).hexdigest()
paths=[ROOT/'public/CCG Downloads/CCG_Scripts/c236744343.lua',ROOT/'public/CCG Downloads/CCG_Scripts/c251699681.lua',ROOT/'tmp/omega_scripts/c59822133.lua',Path(__file__),ROOT/'scripts/fresh_current_estate_activation_negation.cjs',ROOT/'scripts/fresh_current_card.cjs',ROOT/'public/CCG Downloads/CCG_Scripts/c241868535.lua',OUT/'current-spec-CCG_v1.db']+[ROOT/'tmp/omega_scripts'/n for n in ['constant.lua','utility.lua','procedure.lua']]+list((ROOT/'node_modules/@n1xx1/ocgcore-wasm/dist').glob('*.js'))
assert (ROOT/'public/CCG Downloads/CCG_Scripts/c236744343.lua').read_bytes()==Path(r'C:\Program Files (x86)\YGO Omega\YGO Omega_Data\Files\Scripts\c236744343.lua').read_bytes()
before={p.relative_to(ROOT).as_posix():sha(p) for p in paths};runs=[]
for control in [None,'no-limit','no-response','modern-count']:
 result=subprocess.run(['node','--no-warnings','scripts/fresh_current_estate_activation_negation.cjs']+(['--'+control] if control else []),cwd=ROOT,capture_output=True,text=True,timeout=30)
 p=OUT/('current-estate-activation-negation'+('-'+control if control else '')+'.json');data=json.loads(p.read_text());expected=[{'activation':True}] if control is None else [{'effect':True}] if control=='no-limit' else [{'activation':True},{'effect':True}] if control=='no-response' else []
 assert result.returncode==(0 if control=='modern-count' else 1),result.stdout+result.stderr
 assert [r['test'] for r in data['results'] if r['failure']]==expected
 runs.append({'control':control,'expected_failures':expected,'artifact':p.name,'artifact_sha256':sha(p)})
assert before=={p.relative_to(ROOT).as_posix():sha(p) for p in paths}
(OUT/'current-estate-activation-negation-batch.json').write_text(json.dumps({'scope':data['scope'],'diagnostic_only':True,'baseline_cases':2,'certification':'Diagnostic legacy count compatibility; modern-count adapter not production certification','runtime_dependencies_sha256':before,'runs':runs},indent=2)+'\n')
print('Estate legacy negation mismatch frozen, two controls and bounded modern-count comparison verified')

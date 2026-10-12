import hashlib,json,subprocess
from pathlib import Path
ROOT=Path(__file__).resolve().parents[1];OUT=ROOT/'output/fresh-ccg-september'
def sha(p):return hashlib.sha256(p.read_bytes()).hexdigest()
paths=[ROOT/'public/CCG Downloads/CCG_Scripts/c215984744.lua',ROOT/'public/CCG Downloads/CCG_Scripts/c241868535.lua',ROOT/'public/CCG Downloads/CCG_Scripts/c231872299.lua',Path(__file__),ROOT/'scripts/fresh_current_happy_servant_facedown_diagnostic.cjs',ROOT/'scripts/fresh_current_card.cjs',OUT/'current-spec-CCG_v1.db']+[ROOT/'tmp/omega_scripts'/n for n in ['constant.lua','utility.lua','procedure.lua']]+list((ROOT/'node_modules/@n1xx1/ocgcore-wasm/dist').glob('*.js'))
assert (ROOT/'public/CCG Downloads/CCG_Scripts/c215984744.lua').read_bytes()==Path(r'C:\Program Files (x86)\YGO Omega\YGO Omega_Data\Files\Scripts\c215984744.lua').read_bytes()
before={p.relative_to(ROOT).as_posix():sha(p) for p in paths};runs=[]
for control in [None,'no-protection','force-target']:
 result=subprocess.run(['node','--no-warnings','scripts/fresh_current_happy_servant_facedown_diagnostic.cjs']+(['--'+control] if control else []),cwd=ROOT,capture_output=True,text=True,timeout=30)
 p=OUT/('current-happy-servant-facedown-diagnostic'+('-'+control if control else '')+'.json');data=json.loads(p.read_text());expected=[{}] if control=='no-protection' else [{'targetDown':True}] if control else []
 assert result.returncode==(1 if control else 0),result.stdout+result.stderr
 assert [r['test'] for r in data['results'] if r['failure']]==expected
 runs.append({'control':control,'expected_failures':expected,'artifact':p.name,'artifact_sha256':sha(p)})
assert before=={p.relative_to(ROOT).as_posix():sha(p) for p in paths}
(OUT/'current-happy-servant-facedown-diagnostic-batch.json').write_text(json.dumps({'scope':data['scope'],'diagnostic_only':True,'baseline_cases':2,'certification':'Diagnostic only; facedown rule unresolved','runtime_dependencies_sha256':before,'runs':runs},indent=2)+'\n')
print('HappyServant two facedown behavior diagnostic cases and two controls frozen')

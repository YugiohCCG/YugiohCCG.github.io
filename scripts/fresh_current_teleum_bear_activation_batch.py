import hashlib,json,subprocess
from pathlib import Path
ROOT=Path(__file__).resolve().parents[1];OUT=ROOT/'output/fresh-ccg-september'
def sha(p):return hashlib.sha256(p.read_bytes()).hexdigest()
paths=[ROOT/'public/CCG Downloads/CCG_Scripts/c251699681.lua',ROOT/'tmp/omega_scripts/c59822133.lua',Path(__file__),ROOT/'scripts/fresh_current_teleum_bear_activation.cjs',ROOT/'scripts/fresh_current_card.cjs',ROOT/'public/CCG Downloads/CCG_Scripts/c229875953.lua',OUT/'current-spec-CCG_v1.db']+[ROOT/'tmp/omega_scripts'/n for n in ['constant.lua','utility.lua','procedure.lua']]+list((ROOT/'node_modules/@n1xx1/ocgcore-wasm/dist').glob('*.js'))
assert (ROOT/'public/CCG Downloads/CCG_Scripts/c229875953.lua').read_bytes()==Path(r'C:\Program Files (x86)\YGO Omega\YGO Omega_Data\Files\Scripts\c229875953.lua').read_bytes()
before={p.relative_to(ROOT).as_posix():sha(p) for p in paths};runs=[]
result=subprocess.run(['node','--no-warnings','scripts/fresh_current_teleum_bear_activation.cjs'],cwd=ROOT,capture_output=True,text=True,timeout=30)
p=OUT/'current-teleum-bear-activation.json';data=json.loads(p.read_text());assert result.returncode==1 and len(data['results'])==1 and 'GetReadyChain' in data['results'][0]['failure']
runs.append({'diagnostic_only':True,'artifact':p.name,'artifact_sha256':sha(p),'legacy_api':'Duel.GetReadyChain'})
assert before=={p.relative_to(ROOT).as_posix():sha(p) for p in paths}
(OUT/'current-teleum-bear-activation-batch.json').write_text(json.dumps({'scope':'Actual Bear Trap summon response fails legacy Duel.GetReadyChain before activation; no ATK/history certification','diagnostic_cases':1,'runtime_dependencies_sha256':before,'runs':runs},indent=2)+'\n')
print('Teleum Bear Trap diagnostic frozen')

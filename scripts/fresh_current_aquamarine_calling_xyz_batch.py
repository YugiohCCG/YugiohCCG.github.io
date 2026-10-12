import hashlib,json,subprocess
from pathlib import Path
ROOT=Path(__file__).resolve().parents[1];OUT=ROOT/'output/fresh-ccg-september'
def sha(p):return hashlib.sha256(p.read_bytes()).hexdigest()
paths=[ROOT/'tmp/omega_scripts/c59822133.lua',Path(__file__),ROOT/'scripts/fresh_current_aquamarine_calling_xyz.cjs',ROOT/'scripts/fresh_current_card.cjs',ROOT/'public/CCG Downloads/CCG_Scripts/c221509060.lua',OUT/'current-spec-CCG_v1.db']+[ROOT/'tmp/omega_scripts'/n for n in ['constant.lua','utility.lua','procedure.lua']]+list((ROOT/'node_modules/@n1xx1/ocgcore-wasm/dist').glob('*.js'))
assert (ROOT/'public/CCG Downloads/CCG_Scripts/c221509060.lua').read_bytes()==Path(r'C:\Program Files (x86)\YGO Omega\YGO Omega_Data\Files\Scripts\c221509060.lua').read_bytes()
before={p.relative_to(ROOT).as_posix():sha(p) for p in paths};runs=[]
result=subprocess.run(['node','--no-warnings','scripts/fresh_current_aquamarine_calling_xyz.cjs'],cwd=ROOT,capture_output=True,text=True,timeout=30)
p=OUT/'current-aquamarine-calling-xyz.json';data=json.loads(p.read_text())
assert result.returncode==1
assert len(data['results'])==2 and all('CheckXyzMaterial' in r['failure'] for r in data['results'])
runs.append({'diagnostic_only':True,'expected_legacy_api':'Duel.CheckXyzMaterial','artifact':p.name,'artifact_sha256':sha(p)})
assert before=={p.relative_to(ROOT).as_posix():sha(p) for p in paths}
(OUT/'current-aquamarine-calling-xyz-batch.json').write_text(json.dumps({'scope':'Unadapted installed Xyz procedure diagnostic; both scenarios fail missing legacy Duel.CheckXyzMaterial; no restriction coverage or certification','diagnostic_cases':2,'runtime_dependencies_sha256':before,'runs':runs},indent=2)+'\n')
print('Aquamarine Xyz diagnostic frozen; legacy API failure only')

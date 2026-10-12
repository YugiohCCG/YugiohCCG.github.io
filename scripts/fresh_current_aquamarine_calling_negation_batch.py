import hashlib,json,subprocess
from pathlib import Path
ROOT=Path(__file__).resolve().parents[1];OUT=ROOT/'output/fresh-ccg-september'
def sha(p):return hashlib.sha256(p.read_bytes()).hexdigest()
paths=[ROOT/'tmp/omega_scripts/c59822133.lua',Path(__file__),ROOT/'scripts/fresh_current_aquamarine_calling_negation.cjs',ROOT/'scripts/fresh_current_card.cjs',ROOT/'public/CCG Downloads/CCG_Scripts/c221509060.lua',OUT/'current-spec-CCG_v1.db']+[ROOT/'tmp/omega_scripts'/n for n in ['constant.lua','utility.lua','procedure.lua']]+list((ROOT/'node_modules/@n1xx1/ocgcore-wasm/dist').glob('*.js'))
assert (ROOT/'public/CCG Downloads/CCG_Scripts/c221509060.lua').read_bytes()==Path(r'C:\Program Files (x86)\YGO Omega\YGO Omega_Data\Files\Scripts\c221509060.lua').read_bytes()
before={p.relative_to(ROOT).as_posix():sha(p) for p in paths};runs=[]
cases=[{'activation':True},{},{'activation':True,'reset':True},{'reset':True}]
for probe,control in [(False,None),(True,None),(True,'no-response'),(True,'no-add'),(True,'no-limit')]:
 args=(['--modern-oath-probe'] if probe else [])+(['--'+control] if control else [])
 result=subprocess.run(['node','--no-warnings','scripts/fresh_current_aquamarine_calling_negation.cjs']+args,cwd=ROOT,capture_output=True,text=True,timeout=30)
 p=OUT/('current-aquamarine-calling-negation'+('-modern-oath-probe' if probe else '')+('-'+control if control else '')+'.json');data=json.loads(p.read_text())
 expected=[cases[0],cases[2]] if not probe else {'no-response':cases,'no-add':[cases[0],cases[2],cases[3]],'no-limit':[cases[1],cases[3]]}.get(control,[])
 assert result.returncode==(1 if expected else 0),result.stdout+result.stderr
 assert [r['test'] for r in data['results'] if r['failure']]==expected,(args,result.stdout,result.stderr)
 runs.append({'modern_oath_probe':probe,'control':control,'expected_failures':expected,'artifact':p.name,'artifact_sha256':sha(p)})
assert before=={p.relative_to(ROOT).as_posix():sha(p) for p in paths}
(OUT/'current-aquamarine-calling-negation-batch.json').write_text(json.dumps({'scope':'Legacy production activation-count compatibility diagnostic, explicitly adapted modern OATH probe only; not production/native Omega certification','probe_cases':4,'production_expected_failures':2,'runtime_dependencies_sha256':before,'runs':runs},indent=2)+'\n')
print('Aquamarine negation diagnostic4cases3probeControls verified')

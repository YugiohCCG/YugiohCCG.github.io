import json,hashlib,subprocess
from pathlib import Path
ROOT=Path(__file__).resolve().parents[1];OUT=ROOT/'output/fresh-ccg-september'
sha=lambda p:hashlib.sha256(Path(p).read_bytes()).hexdigest()
paths=[ROOT/'scripts/fresh_current_happy_halloween_counters_repaired.cjs',ROOT/'scripts/fresh_current_happy_halloween_counter_boundary_repaired.cjs',Path(__file__),ROOT/'scripts/fresh_current_card.cjs',OUT/'current-spec-CCG_v1.db']+[ROOT/'public/CCG Downloads/CCG_Scripts'/f'c{code}.lua' for code in [255977900,250262550]]+[ROOT/'tmp/omega_scripts'/n for n in ['constant.lua','utility.lua','procedure.lua']]+list((ROOT/'node_modules/@n1xx1/ocgcore-wasm/dist').glob('*.js'))
before={p.relative_to(ROOT).as_posix():sha(p) for p in paths};runs=[]
for prefix,controls in [('counters',[None,'no-counter','allow-any']),('counter-boundary',[None,'no-counter','no-boundary','original-guard'])]:
 for control in controls:
  fixture='scripts/fresh_current_happy_halloween_'+prefix.replace('-','_')+'_repaired.cjs'
  r=subprocess.run(['node','--no-warnings',fixture]+(['--'+control] if control else []),cwd=ROOT,capture_output=True,text=True,timeout=30)
  p=OUT/('current-happy-halloween-'+prefix+'-repaired'+('-'+control if control else '')+'.json');d=json.loads(p.read_text())
  expected=[{}, {'group':True}] if prefix=='counters' and control=='no-counter' else [{'wrong':True}] if control=='allow-any' else [{'disabled':True},{'facedown':True},{'sourceGY':True}] if control=='no-boundary' else [{}] if control else []
  assert r.returncode==(1 if control else 0),r.stdout+r.stderr
  assert [x['test'] for x in d['results'] if x['failure']]==expected
  assert all(not x['logs'] for x in d['results'])
  runs.append({'prefix':prefix,'control':control,'expected_failures':expected,'artifact':p.name,'artifact_sha256':sha(p)})
assert before=={p.relative_to(ROOT).as_posix():sha(p) for p in paths}
for code in [255977900,250262550]:assert (ROOT/f'public/CCG Downloads/CCG_Scripts/c{code}.lua').read_bytes()==Path(f'C:/Program Files (x86)/YGO Omega/YGO Omega_Data/Files/Scripts/c{code}.lua').read_bytes()
(OUT/'current-happy-halloween-counter-repaired-batch.json').write_text(json.dumps({'baseline_cases':9,'runtime_dependencies_sha256':before,'runs':runs,'certification':'Production focused evidence; activation/cost/revival/limit/nativeOmega/fullcard OPEN'},indent=2)+'\n')
print('Nine repaired counter cases and five control runs verified')

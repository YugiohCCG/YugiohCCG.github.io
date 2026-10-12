import hashlib,json,subprocess
from pathlib import Path
ROOT=Path(__file__).resolve().parents[1];OUT=ROOT/'output/fresh-ccg-september'
def sha(p):return hashlib.sha256(p.read_bytes()).hexdigest()
paths=[ROOT/'public/CCG Downloads/CCG_Scripts/c210366076.lua',ROOT/'public/CCG Downloads/CCG_Scripts/c222654570.lua',ROOT/'tmp/omega_scripts/c59822133.lua',Path(__file__),ROOT/'scripts/fresh_current_frozen_girl_crewal.cjs',ROOT/'scripts/fresh_current_card.cjs',ROOT/'public/CCG Downloads/CCG_Scripts/c222676270.lua',OUT/'current-spec-CCG_v1.db']+[ROOT/'tmp/omega_scripts'/n for n in ['constant.lua','utility.lua','procedure.lua']]+list((ROOT/'node_modules/@n1xx1/ocgcore-wasm/dist').glob('*.js'))
for code in [222676270,210366076,222654570]:assert (ROOT/f'public/CCG Downloads/CCG_Scripts/c{code}.lua').read_bytes()==Path(r'C:\Program Files (x86)\YGO Omega\YGO Omega_Data\Files\Scripts').joinpath(f'c{code}.lua').read_bytes()
before={p.relative_to(ROOT).as_posix():sha(p) for p in paths};runs=[]
for code in [210366076,222654570]:
 for control in [None,'placement-marker-probe']:
  result=subprocess.run(['node','--no-warnings','scripts/fresh_current_frozen_girl_crewal.cjs',f'--recipient={code}']+(['--'+control] if control else []),cwd=ROOT,capture_output=True,text=True,timeout=30)
  p=OUT/(f'current-frozen-girl-crewal-{code}'+('-'+control if control else '')+'.json');data=json.loads(p.read_text());expected=[] if code==210366076 and control else [{}, {'decline':True}]
  assert result.returncode==(1 if expected else 0),result.stdout+result.stderr
  assert [r['test'] for r in data['results'] if r['failure']]==expected
  if code==222654570:assert all('IsFaceupEx' in r['failure'] for r in data['results'] if r['failure'])
  runs.append({'recipient':code,'control':control,'expected_failures':expected,'artifact':p.name,'artifact_sha256':sha(p)})
assert before=={p.relative_to(ROOT).as_posix():sha(p) for p in paths}
(OUT/'current-frozen-girl-crewal-batch.json').write_text(json.dumps({'scope':data['scope'],'baseline_cases':6,'diagnostic_only':True,'production_unchanged':True,'runtime_dependencies_sha256':before,'runs':runs},indent=2)+'\n')
print('Crewal2recipient diagnostic4runs verified;210marker fixes response,222legacyAPI parked')

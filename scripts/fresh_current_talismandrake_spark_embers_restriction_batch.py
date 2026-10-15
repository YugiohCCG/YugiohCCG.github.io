import hashlib,json,subprocess
from pathlib import Path
ROOT=Path.cwd();OUT=ROOT/'output/fresh-ccg-september'
def sha(p):return hashlib.sha256(p.read_bytes()).hexdigest()
for name,code in [('spark',230947464),('embers',256928871)]:
 paths=[Path(__file__).resolve(),ROOT/'scripts/fresh_corrected_card_data_transport.cjs',ROOT/'scripts/fresh_current_card.cjs',OUT/'current-spec-CCG_v1.db',ROOT/'src/data/cards.json',ROOT/'node_modules/@n1xx1/ocgcore-wasm/dist/index-card-data-transport-candidate.mjs']+[ROOT/f'scripts/fresh_current_talismandrake_{name}_pendulum_restriction.cjs']+[ROOT/'public/CCG Downloads/CCG_Scripts'/f'c{code}.lua' for code in [code]]+[ROOT/'tmp/omega_scripts'/name for name in ['constant.lua','utility.lua','procedure.lua']]+list((ROOT/'node_modules/@n1xx1/ocgcore-wasm/dist').glob('*.js'))
 before={p.relative_to(ROOT).as_posix():sha(p) for p in paths};runs=[]
 for flag,expected in [(None,[]),('no-limit',[1,3]),('invert-race',[0,1,2,3])]:
  r=subprocess.run(['node','--no-warnings',f'scripts/fresh_current_talismandrake_{name}_pendulum_restriction.cjs']+(['--'+flag] if flag else []),capture_output=True,text=True,timeout=20)
  p=OUT/(f'current-talismandrake-{name}-pendulum-restriction'+('-'+flag if flag else '')+'.json');d=json.loads(p.read_text())
  assert len(d['results'])==5 and all(not v['logs'] for v in d['results']),r.stdout+r.stderr
  assert [i for i,v in enumerate(d['results']) if v['failure']]==expected,(flag,r.stdout)
  assert r.returncode==(1 if expected else 0)
  runs.append({'flag':flag,'artifact':p.name,'artifact_sha256':sha(p),'expected_failures':expected})
 assert before=={p.relative_to(ROOT).as_posix():sha(p) for p in paths}
 assert (ROOT/f'public/CCG Downloads/CCG_Scripts/c{code}.lua').read_bytes()==(Path(r'C:\Program Files (x86)\YGO Omega\YGO Omega_Data\Files\Scripts')/f'c{code}.lua').read_bytes()
 (OUT/f'current-talismandrake-{name}-pendulum-restriction-batch.json').write_text(json.dumps({'status':'VERIFIED_PARTIAL_PRODUCTION','baseline_cases':5,'runtime_dependencies_sha256':before,'runs':runs,'scope':'Full current production card/canonical metadata/corrected CardData; actual Hand PZone activation and neutral opposite scale2. Native Pyro Pendulum SS from Hand or actual MZONE effect-GY faceupExtra, nonPyro excluded in both, ordinary nonPyro SS unaffected. No LuaAPI adapter. NoLimit2/invertRace4 exactfailures/emptylogs/frozeninputs/installedparity. Other effects/fullcard/nativeOmega OPEN.'},indent=2)+'\n',encoding='utf8')
 print(name+':5 native cases PASS; controls2/4; inputs/parity verified')

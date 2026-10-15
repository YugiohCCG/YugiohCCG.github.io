import hashlib,json,subprocess
from pathlib import Path
ROOT=Path.cwd();OUT=ROOT/'output/fresh-ccg-september'
def sha(p):return hashlib.sha256(p.read_bytes()).hexdigest()
paths=[Path(__file__).resolve(),ROOT/'scripts/fresh_current_tide_revival_use_reset.cjs',ROOT/'scripts/fresh_current_card.cjs',ROOT/'public/CCG Downloads/CCG_Scripts/c217645912.lua',OUT/'current-spec-CCG_v1.db']+[ROOT/'tmp/omega_scripts'/n for n in ['constant.lua','utility.lua','procedure.lua']]+list((ROOT/'node_modules/@n1xx1/ocgcore-wasm/dist').glob('*.js'))
before={p.relative_to(ROOT).as_posix():sha(p) for p in paths};runs=[]
for opponent in [False,True]:
 for control,expected in [(None,[]),('per-copy',[0,2,3]),('no-reset',[0,1,2,3]),('no-response',[2,3])]:
  result=subprocess.run(['node','--no-warnings','scripts/fresh_current_tide_revival_use_reset.cjs','--faceup-compat']+(['--opponent-reset'] if opponent else [])+(['--'+control] if control else []),capture_output=True,text=True,timeout=30)
  p=OUT/('current-tide-revival-use-reset'+('-opponent-reset' if opponent else '')+'-faceup-compat'+('-'+control if control else '')+'.json');data=json.loads(p.read_text(encoding='utf-8'));assert result.returncode==(1 if expected else 0),result.stdout+result.stderr;assert len(data['results'])==4;assert data['adapter'];assert data['resetTurn']==(2 if opponent else 3);assert [i for i,v in enumerate(data['results']) if v['failure']]==expected,(opponent,control,result.stdout);assert all(not v['logs'] for v in data['results'])
  runs.append({'opponent_reset':opponent,'control':control,'expected_failures':expected,'artifact':p.name,'artifact_sha256':sha(p)})
assert before=={p.relative_to(ROOT).as_posix():sha(p) for p in paths}
assert paths[3].read_bytes()==Path(r'C:\Program Files (x86)\YGO Omega\YGO Omega_Data\Files\Scripts\c217645912.lua').read_bytes()
(OUT/'current-tide-revival-shared-reset-diagnostic-batch.json').write_text(json.dumps({'status':'COMPATIBILITY_DIAGNOSTIC_ONLY','adapted_baseline_cases':8,'runtime_dependencies_sha256':before,'runs':runs,'scope':'Two full Tide copies, three actual ownerSZONE summons; successful/activation-negated/effect-negated chosen effect shared across Field replacement, decline preserves use; actual ownturn3 and earliest opponentturn2 reset. Explicit reference-defined IsFaceupEx shim; production unchanged; not nativeOmega or adapter-free/fullcard certification.'},indent=2)+'\n',encoding='utf-8')
print('Tide shared revival8cases/6controlruns verified, including earliest opposing reset. Compatibility diagnostic only.')

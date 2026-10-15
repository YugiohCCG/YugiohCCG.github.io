import hashlib,json,subprocess
from pathlib import Path
ROOT=Path.cwd();OUT=ROOT/'output/fresh-ccg-september'
def sha(p):return hashlib.sha256(p.read_bytes()).hexdigest()
sources=[ROOT/'public/CCG Downloads/CCG_Scripts'/f'c{code}.lua' for code in [259882493,259537607]]
paths=sources+[Path(__file__).resolve(),ROOT/'scripts/fresh_current_vaylantz_pendulum_column.cjs',ROOT/'scripts/fresh_current_card.cjs',ROOT/'src/data/cards.json',OUT/'current-spec-CCG_v1.db']+[ROOT/'tmp/omega_scripts'/n for n in ['constant.lua','utility.lua','procedure.lua']]+list((ROOT/'node_modules/@n1xx1/ocgcore-wasm/dist').glob('*.js'))
before={p.relative_to(ROOT).as_posix():sha(p) for p in paths};runs=[]
for control in [None,'no-response','wrong-column','no-condition']:
 result=subprocess.run(['node','--no-warnings','scripts/fresh_current_vaylantz_pendulum_column.cjs']+(['--'+control] if control else []),capture_output=True,text=True,timeout=30)
 p=OUT/('current-vaylantz-pendulum-column'+('-'+control if control else '')+'.json');d=json.loads(p.read_text());assert len(d['results'])==32 and all(not r['logs'] for r in d['results']),result.stdout+result.stderr
 expected=[]
 for r in d['results']:
  if control=='no-response' and r['scenario'] in ['activation','effect','sourceBanish','lateOccupied'] or control=='wrong-column' and r['scenario'] in ['baseline','lateOccupied'] or control=='no-condition' and r['passcode']==259537607 and r['scenario'] in ['noFusion','wrongSet','wrongType','facedownFusion']:expected.append([r['passcode'],r['side'],r['scenario']])
 actual=[[r['passcode'],r['side'],r['scenario']] for r in d['results'] if r['failure']];assert actual==expected,(control,actual,expected);assert result.returncode==(1 if expected else 0),result.stdout+result.stderr
 runs.append({'control':control,'artifact':p.name,'artifact_sha256':sha(p),'expected_failures':expected})
assert before=={p.relative_to(ROOT).as_posix():sha(p) for p in paths}
installed=Path(r'C:\Program Files (x86)\YGO Omega\YGO Omega_Data\Files\Scripts');assert all(p.read_bytes()==(installed/p.name).read_bytes() for p in sources)
(OUT/'current-vaylantz-pendulum-column-batch.json').write_text(json.dumps({'status':'VERIFIED_PARTIAL_PRODUCTION','baseline_cases':32,'cards':2,'runtime_dependencies_sha256':before,'runs':runs,'scope':'Actual native left/right PZone placements and same-column self summons, initial full-field exclusion, actual CL2 negations/sourcebanishment/late correct-column occupancy, Arktos faceup Vaylantz Fusion condition boundaries. Patrician actual neutral2material Fusion history and CompleteProcedure, not seeded proper-summon status. Production Fusion recipe, alternative move/coin/other monster effects/live Omega/full-card remain open. No API shim; fullsource/install parity; three effective controls16/8/8 failures.'},indent=2)+'\n',encoding='utf-8')
print('Vaylantz32native cases pass;16/8/8 control failures; frozeninputs/installparity')

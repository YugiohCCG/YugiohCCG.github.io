import hashlib,json,subprocess
from pathlib import Path
ROOT=Path.cwd();OUT=ROOT/'output/fresh-ccg-september'
def sha(p):return hashlib.sha256(p.read_bytes()).hexdigest()
sources=[ROOT/'public/CCG Downloads/CCG_Scripts'/f'c{code}.lua' for code in range(284639717,284639725)]
paths=sources+[Path(__file__).resolve(),ROOT/'scripts/fresh_current_terrarumian_pendulum_interruption.cjs',ROOT/'scripts/fresh_current_card.cjs',ROOT/'src/data/cards.json',OUT/'current-spec-CCG_v1.db']+[ROOT/'tmp/omega_scripts'/n for n in ['constant.lua','utility.lua','procedure.lua']]+list((ROOT/'node_modules/@n1xx1/ocgcore-wasm/dist').glob('*.js'))
before={p.relative_to(ROOT).as_posix():sha(p) for p in paths};runs=[]
for control in [None,'no-response','no-summon']:
 args=['node','--no-warnings','scripts/fresh_current_terrarumian_pendulum_interruption.cjs']+(['--'+control] if control else [])
 result=subprocess.run(args,capture_output=True,text=True,timeout=30)
 p=OUT/('current-terrarumian-pendulum-interruption'+('-'+control if control else '')+'.json');d=json.loads(p.read_text())
 assert len(d['results'])==56 and all(not r['logs'] for r in d['results']),result.stdout+result.stderr
 actual=[(r['passcode'],r['scenario']) for r in d['results'] if r['failure']]
 expected=[] if control is None else [(code,scenario) for code in range(284639717,284639725) for scenario in ['baseline','activation','effect','sourceBanish','resourcesBanish','lateFull','lateLock'] if (scenario!='baseline' if control=='no-response' else scenario=='baseline' or code==284639723 and scenario=='lateFull')]
 assert actual==expected,(control,actual,expected);assert result.returncode==(1 if expected else 0),result.stdout+result.stderr
 runs.append({'control':control,'artifact':p.name,'artifact_sha256':sha(p),'expected_failures':expected})
assert before=={p.relative_to(ROOT).as_posix():sha(p) for p in paths}
installed=Path(r'C:\Program Files (x86)\YGO Omega\YGO Omega_Data\Files\Scripts')
assert all(p.read_bytes()==(installed/p.name).read_bytes() for p in sources)
(OUT/'current-terrarumian-pendulum-interruption-batch.json').write_text(json.dumps({'status':'VERIFIED_PARTIAL_PRODUCTION','baseline_cases':56,'cards':8,'runtime_dependencies_sha256':before,'runs':runs,'scope':'Full production primary Pendulum effects, actual native placement/activation and CL2 interruptions;56 cases and2 effective fault controls, empty logs, source/install parity. Current specification metadata. No API shim. Secondary-effects/full-card/live Omega remain open. Ineffective no-relation exploratory control excluded: native field-effect lifecycle alone prevented resolution after source left; no attribution to explicit relation guard.'},indent=2)+'\n',encoding='utf-8')
print('All8Terrarumian primary interruptions:56PASS,48/9expected control failures, emptylogs, frozeninputs/parity')

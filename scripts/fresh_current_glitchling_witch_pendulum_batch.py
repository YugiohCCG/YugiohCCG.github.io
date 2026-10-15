import hashlib,json,subprocess
from pathlib import Path
ROOT=Path.cwd();OUT=ROOT/'output/fresh-ccg-september'
def sha(p):return hashlib.sha256(p.read_bytes()).hexdigest()
source=ROOT/'public/CCG Downloads/CCG_Scripts/c259678739.lua'
paths=[source,Path(__file__).resolve(),ROOT/'scripts/fresh_current_glitchling_witch_pendulum.cjs',ROOT/'scripts/fresh_current_card.cjs',ROOT/'src/data/cards.json',OUT/'current-spec-CCG_v1.db']+[ROOT/'tmp/omega_scripts'/n for n in ['constant.lua','utility.lua','procedure.lua']]+list((ROOT/'node_modules/@n1xx1/ocgcore-wasm/dist').glob('*.js'))
before={p.relative_to(ROOT).as_posix():sha(p) for p in paths};runs=[]
for control,expected in [(None,[]),('no-protection',['opponent','both']),('protect-own',['own','both']),('no-counter',['opponent','both']),('no-probe',['none','opponent','own','both','disabled','removed','counterRemoved'])]:
 result=subprocess.run(['node','--no-warnings','scripts/fresh_current_glitchling_witch_pendulum.cjs']+(['--'+control] if control else []),capture_output=True,text=True,timeout=20)
 p=OUT/('current-glitchling-witch-pendulum'+('-'+control if control else '')+'.json');d=json.loads(p.read_text());assert len(d['results'])==7 and all(not r['logs'] for r in d['results']),result.stdout+result.stderr
 assert [r['scenario'] for r in d['results'] if r['failure']]==expected;assert result.returncode==(1 if expected else 0),result.stdout+result.stderr
 runs.append({'control':control,'artifact':p.name,'artifact_sha256':sha(p),'expected_failures':expected})
assert before=={p.relative_to(ROOT).as_posix():sha(p) for p in paths}
assert source.read_bytes()==Path(r'C:\Program Files (x86)\YGO Omega\YGO Omega_Data\Files\Scripts/c259678739.lua').read_bytes()
(OUT/'current-glitchling-witch-pendulum-batch.json').write_text(json.dumps({'status':'VERIFIED_PARTIAL_PRODUCTION','baseline_cases':7,'native_eligibility_observations':84,'runtime_dependencies_sha256':before,'runs':runs,'scope':'Actual native full Witch hand-to-PZone activation, counters added/removed, disable/sourcebanishment lifecycle. Six native release/material eligibility methods for both players per case. Own countered monsters remain eligible; opposing countered monsters blocked. No actual material summon or full Witch monster-effect/fullcard/live Omega certification. No API shim; four effective fault controls2/2/2/7 expected failures, emptylogs/frozeninputs/sourceinstallparity.'},indent=2)+'\n',encoding='utf-8')
print('Witch7cases/84native eligibility observations PASS;4controls verified; frozeninputs/parity')

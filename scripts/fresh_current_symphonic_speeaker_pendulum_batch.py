import hashlib,json,subprocess
from pathlib import Path
ROOT=Path.cwd();OUT=ROOT/'output/fresh-ccg-september'
def sha(p):return hashlib.sha256(p.read_bytes()).hexdigest()
paths=[Path(__file__).resolve(),ROOT/'scripts/fresh_corrected_card_data_transport.cjs',ROOT/'scripts/fresh_current_card.cjs',OUT/'current-spec-CCG_v1.db',ROOT/'src/data/cards.json',ROOT/'node_modules/@n1xx1/ocgcore-wasm/dist/index-card-data-transport-candidate.mjs']+[ROOT/'scripts/fresh_current_symphonic_speeaker_pendulum.cjs']+[ROOT/'public/CCG Downloads/CCG_Scripts'/f'c{code}.lua' for code in [238273768]]+[ROOT/'tmp/omega_scripts'/name for name in ['constant.lua','utility.lua','procedure.lua']]+list((ROOT/'node_modules/@n1xx1/ocgcore-wasm/dist').glob('*.js'))
before={p.relative_to(ROOT).as_posix():sha(p) for p in paths};runs=[]
for name,count,expected in [('speeaker',7,[]),('speeaker',7,[0,5,6])]:
 r=subprocess.run(['node','--no-warnings',f'scripts/fresh_current_symphonic_{name}_pendulum.cjs']+(['--no-operation'] if expected else []),capture_output=True,text=True,timeout=20);p=OUT/('current-symphonic-'+name+'-pendulum'+('-no-operation' if expected else '')+'.json');d=json.loads(p.read_text());assert len(d['results'])==count and all(not v['logs'] for v in d['results']),r.stdout+r.stderr;assert [i for i,v in enumerate(d['results']) if v['failure']]==expected;assert r.returncode==(1 if expected else 0)
 runs.append({'card':name,'artifact':p.name,'artifact_sha256':sha(p),'expected_failures':expected})
assert before=={p.relative_to(ROOT).as_posix():sha(p) for p in paths}
inst=Path(r'C:\Program Files (x86)\YGO Omega\YGO Omega_Data\Files\Scripts')
for code in [238273768]:assert (ROOT/'public/CCG Downloads/CCG_Scripts'/f'c{code}.lua').read_bytes()==(inst/f'c{code}.lua').read_bytes()
(OUT/'current-symphonic-speeaker-pendulum-batch.json').write_text(json.dumps({'status':'VERIFIED_PARTIAL_PRODUCTION','baseline_cases':7,'runtime_dependencies_sha256':before,'runs':runs,'scope':'Full production Speeaker current-spec metadata/corrected32bitCardData. NativeHandPZoneactivation, actualselfdestructiontofaceupExtra andDeckplacementofdistinctSymphonicPendulum. Seven cases baseline/wrongset/nonPend/samename/noDecktarget/oppositePZoneoccupied/fullMZONE. RealcontinuousSpellblocker/nativephysicalfieldbounds; nontargeting/repeatcheck. Nooperation3fails, emptylogs/parity/frozeninputs. No Lua API shim/nativeOmega/fullcard certification. Other effects/interruptions/reset open.'},indent=2)+'\n',encoding='utf-8');print('Speeaker7PASS; control3failures verified; frozeninputs/parity')

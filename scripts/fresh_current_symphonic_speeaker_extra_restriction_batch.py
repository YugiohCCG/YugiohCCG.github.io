import hashlib,json,subprocess
from pathlib import Path
ROOT=Path.cwd();OUT=ROOT/'output/fresh-ccg-september'
def sha(p):return hashlib.sha256(p.read_bytes()).hexdigest()
paths=[Path(__file__).resolve(),ROOT/'scripts/fresh_corrected_card_data_transport.cjs',ROOT/'scripts/fresh_installed_card.cjs',Path(r'C:\Program Files (x86)\YGO Omega\YGO Omega_Data\Files\Databases\CCG_v1.db'),ROOT/'src/data/cards.json',ROOT/'node_modules/@n1xx1/ocgcore-wasm/dist/index-card-data-transport-candidate.mjs']+[ROOT/'scripts/fresh_current_symphonic_speeaker_extra_restriction.cjs']+[ROOT/'public/CCG Downloads/CCG_Scripts'/f'c{code}.lua' for code in [238273768]]+[ROOT/'tmp/omega_scripts'/name for name in ['constant.lua','utility.lua','procedure.lua']]+list((ROOT/'node_modules/@n1xx1/ocgcore-wasm/dist').glob('*.js'))
before={str(p.resolve()):sha(p) for p in paths};runs=[]
for flag,expected in [(None,[]),('no-lock',[0,2,4,8]),('no-prior',[4]),('wrong-allowance',[1])]:
 r=subprocess.run(['node','--no-warnings','scripts/fresh_current_symphonic_speeaker_extra_restriction.cjs']+(['--'+flag] if flag else []),capture_output=True,text=True,timeout=20)
 p=OUT/('current-symphonic-speeaker-extra-restriction'+('-'+flag if flag else '')+'.json');d=json.loads(p.read_text())
 assert len(d['results'])==9 and all(not v['logs'] for v in d['results']),r.stdout+r.stderr
 assert [i for i,v in enumerate(d['results']) if v['failure']]==expected,(flag,r.stdout)
 assert r.returncode==(1 if expected else 0)
 runs.append({'flag':flag,'artifact':p.name,'artifact_sha256':sha(p),'expected_failures':expected})

assert before=={str(p.resolve()):sha(p) for p in paths}
inst=Path(r'C:\Program Files (x86)\YGO Omega\YGO Omega_Data\Files\Scripts')
for code in [238273768]:assert (ROOT/'public/CCG Downloads/CCG_Scripts'/f'c{code}.lua').read_bytes()==(inst/f'c{code}.lua').read_bytes()
(OUT/'current-symphonic-speeaker-extra-restriction-batch.json').write_text(json.dumps({'status':'VERIFIED_PARTIAL_NATIVE_SECONDARY_EFFECT','baseline_cases':9,'runtime_dependencies_sha256':before,'runs':runs,'scope':'Full Speeaker/installedmetadata/correctedtransport/noLuaAPIadapter. Nine native restriction cases: post-use facedown Fusion and nonWIND Synchro blocked, WIND Synchro and real faceup Extra Pendulum allowed; prior actual Fusion excludes recruitment, prior WIND Synchro/faceupPend allow it. Activation negation refunds OATH restriction, effect negation retains it. Neutral fixed Extra summons establish native origin/type/history; not general production Fusion/Synchro recipe proof. Controls4/1/1 semantic failures. Expiry/liveOmega/fullcard open.'},indent=2)+'\n',encoding='utf-8');print('Speeaker9ExtraRestrictionNATIVEPASS;controls4/1/1verified; frozeninputs/parity')

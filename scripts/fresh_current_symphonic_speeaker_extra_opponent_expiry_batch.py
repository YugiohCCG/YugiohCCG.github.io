import hashlib,json,subprocess
from pathlib import Path
ROOT=Path.cwd();OUT=ROOT/'output/fresh-ccg-september'
def sha(p):return hashlib.sha256(p.read_bytes()).hexdigest()
paths=[Path(__file__).resolve(),ROOT/'scripts/fresh_corrected_card_data_transport.cjs',ROOT/'scripts/fresh_installed_card.cjs',Path(r'C:\Program Files (x86)\YGO Omega\YGO Omega_Data\Files\Databases\CCG_v1.db'),ROOT/'src/data/cards.json',ROOT/'node_modules/@n1xx1/ocgcore-wasm/dist/index-card-data-transport-candidate.mjs']+[ROOT/'scripts/fresh_current_symphonic_speeaker_extra_opponent_expiry.cjs']+[ROOT/'public/CCG Downloads/CCG_Scripts'/f'c{code}.lua' for code in [238273768]]+[ROOT/'tmp/omega_scripts'/name for name in ['constant.lua','utility.lua','procedure.lua']]+list((ROOT/'node_modules/@n1xx1/ocgcore-wasm/dist').glob('*.js'))
before={str(p.resolve()):sha(p) for p in paths};runs=[]
for flag,expected in [(None,[]),('no-lock',[0,1,2]),('no-reset',[0,1,2])]:
 r=subprocess.run(['node','--no-warnings','scripts/fresh_current_symphonic_speeaker_extra_opponent_expiry.cjs']+(['--'+flag] if flag else []),capture_output=True,text=True,timeout=20)
 p=OUT/('current-symphonic-speeaker-extra-opponent-expiry'+('-'+flag if flag else '')+'.json');d=json.loads(p.read_text())
 assert len(d['results'])==3 and all(not v['logs'] for v in d['results']),r.stdout+r.stderr
 assert [i for i,v in enumerate(d['results']) if v['failure']]==expected,(flag,r.stdout)
 assert r.returncode==(1 if expected else 0)
 if flag:assert all(v['turn']==(1 if flag=='no-lock' else 2) for v in d['results'])
 runs.append({'flag':flag,'artifact':p.name,'artifact_sha256':sha(p),'expected_failures':expected})

assert before=={str(p.resolve()):sha(p) for p in paths}
inst=Path(r'C:\Program Files (x86)\YGO Omega\YGO Omega_Data\Files\Scripts')
for code in [238273768]:assert (ROOT/'public/CCG Downloads/CCG_Scripts'/f'c{code}.lua').read_bytes()==(inst/f'c{code}.lua').read_bytes()
(OUT/'current-symphonic-speeaker-extra-opponent-expiry-batch.json').write_text(json.dumps({'status':'VERIFIED_PARTIAL_NATIVE_SECONDARY_EFFECT','baseline_cases':3,'runtime_dependencies_sha256':before,'runs':runs,'scope':'Full Speeaker/installedmetadata/correctedtransport/no Lua API adapter. Successful recruitment/source banish/actual CL2 effect negation retain own1 restriction; natural next opponent turn2 Quick probe permits and actually summons Extra Fusion (native origin move and NEW_TURN0/1 checked). NoLock3turn1/noReset3turn2 semantic failures. Confirms expiry by next opponent turn, not neutral Fusion recipe/liveOmega/fullcard certification.'},indent=2)+'\n',encoding='utf-8');print('Speeaker3OpponentExpiryNATIVEPASS;controls3/3verified; frozeninputs/parity')

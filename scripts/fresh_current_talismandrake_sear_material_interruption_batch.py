import hashlib,json,subprocess
from pathlib import Path
ROOT=Path.cwd();OUT=ROOT/'output/fresh-ccg-september'
def sha(p):return hashlib.sha256(p.read_bytes()).hexdigest()
paths=[Path(__file__).resolve(),ROOT/'scripts/fresh_corrected_card_data_transport.cjs',ROOT/'scripts/fresh_installed_card.cjs',Path(r'C:\Program Files (x86)\YGO Omega\YGO Omega_Data\Files\Databases\CCG_v1.db'),ROOT/'src/data/cards.json',ROOT/'node_modules/@n1xx1/ocgcore-wasm/dist/index-card-data-transport-candidate.mjs']+[ROOT/'scripts/fresh_current_talismandrake_sear_material_interruption.cjs']+[ROOT/'public/CCG Downloads/CCG_Scripts'/f'c{code}.lua' for code in [245935439]]+[ROOT/'tmp/omega_scripts'/name for name in ['constant.lua','utility.lua','procedure.lua']]+list((ROOT/'node_modules/@n1xx1/ocgcore-wasm/dist').glob('*.js'))
paths += list((OUT/'sear-before-pzone-original-type-repair').glob('*.lua'))
before={str(p.resolve()):sha(p) for p in paths};runs=[]
for flag,expected in [(None,[]),('no-response',[1,2,3,4,5,6]),('no-followup-summon',[0,3]),('no-placement',[0,4,5,6])]:
 r=subprocess.run(['node','--no-warnings','scripts/fresh_current_talismandrake_sear_material_interruption.cjs','--material-api-compat']+(['--'+flag] if flag else []),capture_output=True,text=True,timeout=20)
 p=OUT/('current-talismandrake-sear-material-interruption-material-api-compat'+('-'+flag if flag else '')+'.json');d=json.loads(p.read_text())
 assert len(d['results'])==7 and all(not v['logs'] for v in d['results']),r.stdout+r.stderr
 assert [i for i,v in enumerate(d['results']) if v['failure']]==expected,(flag,r.stdout)
 assert r.returncode==(1 if expected else 0)
 runs.append({'flag':flag,'artifact':p.name,'artifact_sha256':sha(p),'expected_failures':expected})

assert before=={str(p.resolve()):sha(p) for p in paths}
inst=Path(r'C:\Program Files (x86)\YGO Omega\YGO Omega_Data\Files\Scripts')
for code in [245935439]:assert (ROOT/'public/CCG Downloads/CCG_Scripts'/f'c{code}.lua').read_bytes()==(inst/f'c{code}.lua').read_bytes()
(OUT/'current-talismandrake-sear-material-interruption-batch.json').write_text(json.dumps({'status':'VERIFIED_PARTIAL_COMPATIBILITY_DIAGNOSTIC','baseline_cases':7,'runtime_dependencies_sha256':before,'runs':runs,'scope':'Seven actual Sear Fusion-material followup interruptions: baseline, CL2 negate activation/effect, source/partner banish, late full field and summon lock. Optional Extra-to-PZone placement remains independent when summon fails; source leaving Extra prevents source placement while partner can summon. Full source and installed metadata; explicit bounded mandatory-material API adapter and neutral Fusion recipe. No liveOmega/fullcard certification.'},indent=2)+'\n',encoding='utf-8');print('Sear7materialinterruptionCOMPATPASS;controls6/2/4verified; frozeninputs/parity')

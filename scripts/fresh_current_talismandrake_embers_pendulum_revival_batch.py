import hashlib,json,subprocess
from pathlib import Path
ROOT=Path.cwd();OUT=ROOT/'output/fresh-ccg-september'
def sha(p):return hashlib.sha256(p.read_bytes()).hexdigest()
paths=[Path(__file__).resolve(),ROOT/'scripts/fresh_corrected_card_data_transport.cjs',ROOT/'scripts/fresh_current_card.cjs',OUT/'current-spec-CCG_v1.db',ROOT/'src/data/cards.json',ROOT/'node_modules/@n1xx1/ocgcore-wasm/dist/index-card-data-transport-candidate.mjs']+[ROOT/'scripts/fresh_current_talismandrake_embers_pendulum_revival.cjs']+[ROOT/'public/CCG Downloads/CCG_Scripts'/f'c{code}.lua' for code in [256928871]]+[ROOT/'tmp/omega_scripts'/name for name in ['constant.lua','utility.lua','procedure.lua']]+list((ROOT/'node_modules/@n1xx1/ocgcore-wasm/dist').glob('*.js'))
paths.append(OUT/'embers-before-extra-redirect-repair/c256928871.lua')
before={p.relative_to(ROOT).as_posix():sha(p) for p in paths};runs=[]
for flag,expected in [(None,[]),('old-source',[0,1]),('no-revive',[0,1,2,3]),('no-redirect',[0,1]),('allow-wrong-set',[4]),('allow-non-fusion',[5])]:
 r=subprocess.run(['node','--no-warnings','scripts/fresh_current_talismandrake_embers_pendulum_revival.cjs']+(['--'+flag] if flag else []),capture_output=True,text=True,timeout=20)
 p=OUT/('current-talismandrake-embers-pendulum-revival'+('-'+flag if flag else '')+'.json');d=json.loads(p.read_text())
 assert len(d['results'])==8 and all(not v['logs'] for v in d['results']),r.stdout+r.stderr
 assert [i for i,v in enumerate(d['results']) if v['failure']]==expected,(flag,r.stdout)
 assert r.returncode==(1 if expected else 0)
 runs.append({'flag':flag,'artifact':p.name,'artifact_sha256':sha(p),'expected_failures':expected})

assert before=={p.relative_to(ROOT).as_posix():sha(p) for p in paths}
inst=Path(r'C:\Program Files (x86)\YGO Omega\YGO Omega_Data\Files\Scripts')
for code in [256928871]:assert (ROOT/'public/CCG Downloads/CCG_Scripts'/f'c{code}.lua').read_bytes()==(inst/f'c{code}.lua').read_bytes()
(OUT/'current-talismandrake-embers-pendulum-revival-batch.json').write_text(json.dumps({'status':'VERIFIED_PARTIAL_PRODUCTION','baseline_cases':8,'runtime_dependencies_sha256':before,'runs':runs,'scope':'FullrepairedEmbers/currentcanonicalmetadata/correctedCardData/noLuaAPIadapter. Actualneutral2materialFusionSS/properCompleteProcedure/GY then actualHANDPZone targetedrevival. Fouractualleaveattempts GY/banish/Hand/Deck allendExtra; wrongarchetype/nonFusion/notproper/full5MZONE excluded. OldLOCATION_EXTRA sourcefailsGY/banish; replacementLOCATION_DECK supportedinlegacyandmoderncore andautomaticallyroutesFusionExtra. Old2/noRevive4/noRedirect2/wrongSet1/nonFusion1exactfailures, emptylogs/frozeninputs/sourceinstallparity. FullproductionFusionrecipe/othermonstereffects/nativeOmega/fullcard OPEN.'},indent=2)+'\n',encoding='utf-8');print('Embers8revivalPASS;old2/controls4/2/1/1verified; frozeninputs/parity')

import hashlib,json,subprocess
from pathlib import Path
ROOT=Path.cwd();OUT=ROOT/'output/fresh-ccg-september'
def sha(p):return hashlib.sha256(p.read_bytes()).hexdigest()
paths=[Path(__file__).resolve(),ROOT/'scripts/fresh_corrected_card_data_transport.cjs',ROOT/'scripts/fresh_current_card.cjs',OUT/'current-spec-CCG_v1.db',ROOT/'src/data/cards.json',ROOT/'node_modules/@n1xx1/ocgcore-wasm/dist/index-card-data-transport-candidate.mjs']+[ROOT/'scripts/fresh_current_symphonic_megastaar_counter_banish.cjs']+[ROOT/'public/CCG Downloads/CCG_Scripts'/f'c{code}.lua' for code in [238273772]]+[ROOT/'tmp/omega_scripts'/name for name in ['constant.lua','utility.lua','procedure.lua']]+list((ROOT/'node_modules/@n1xx1/ocgcore-wasm/dist').glob('*.js'))
paths.append(next(p for p in [ROOT/'public/CCG Downloads/CCG_Scripts/c75304793.lua',ROOT/'tmp/omega_scripts/c75304793.lua'] if p.exists()))
before={p.relative_to(ROOT).as_posix():sha(p) for p in paths};runs=[]
for flag,expected in [(None,[]),('no-banish',[0,1,2,3]),('no-cost',[0,1,2,3]),('no-field-check',[5,6,7])]:
 r=subprocess.run(['node','--no-warnings','scripts/fresh_current_symphonic_megastaar_counter_banish.cjs']+(['--'+flag] if flag else []),capture_output=True,text=True,timeout=20)
 p=OUT/('current-symphonic-megastaar-counter-banish'+('-'+flag if flag else '')+'.json');d=json.loads(p.read_text())
 assert len(d['results'])==9 and all(not v['logs'] for v in d['results']),r.stdout+r.stderr
 assert [i for i,v in enumerate(d['results']) if v['failure']]==expected,(flag,r.stdout)
 assert r.returncode==(1 if expected else 0)
 runs.append({'flag':flag,'artifact':p.name,'artifact_sha256':sha(p),'expected_failures':expected})

assert before=={p.relative_to(ROOT).as_posix():sha(p) for p in paths}
inst=Path(r'C:\Program Files (x86)\YGO Omega\YGO Omega_Data\Files\Scripts')
for code in [238273772]:assert (ROOT/'public/CCG Downloads/CCG_Scripts'/f'c{code}.lua').read_bytes()==(inst/f'c{code}.lua').read_bytes()
(OUT/'current-symphonic-megastaar-counter-banish-batch.json').write_text(json.dumps({'status':'VERIFIED_PARTIAL_COMPATIBILITY_DIAGNOSTIC','baseline_cases':9,'runtime_dependencies_sha256':before,'runs':runs,'scope':'FullMegaStaar andloadedofficialAmplifirescript, currentcanonicalMegaStaar metadata/correctedCardData, actualpropernativeSynchrohistory withboundedlegacySynchroAPI/IsNotTuner adapters. Actualcounters2own+1opponent; remove2banish2field/GY, remove3banish1, separateGYonly/fieldonly. CostnativeREMOVE_COUNTER aftersourceCHAININGbeforeCHAINED, non-targeting/nativeREMOVEDcounts/selection/softonceperturn checked. PZone/noAmplifire/opponentField/facedownField/zeroCounters excluded. NoBanish4/noCost4/noFieldCheck3exactfailures, emptylogs/frozeninputs/parity. Testcompatibilitydiagnostic notnativeOmega/generalrecipe/fullcard; interruptions/sharedreset/remainingeffects open.'},indent=2)+'\n',encoding='utf-8');print('MegaStaar9counterbanishCOMPATPASS;controls4/4/3verified; frozeninputs/parity')

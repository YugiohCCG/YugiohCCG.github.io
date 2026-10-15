import hashlib,json,subprocess
from pathlib import Path
ROOT=Path.cwd();OUT=ROOT/'output/fresh-ccg-september'
def sha(p):return hashlib.sha256(p.read_bytes()).hexdigest()
paths=[Path(__file__).resolve(),ROOT/'scripts/fresh_corrected_card_data_transport.cjs',ROOT/'scripts/fresh_current_card.cjs',OUT/'current-spec-CCG_v1.db',ROOT/'src/data/cards.json',ROOT/'node_modules/@n1xx1/ocgcore-wasm/dist/index-card-data-transport-candidate.mjs']+[ROOT/'scripts/fresh_current_symphonic_megastaar_battle_leave.cjs']+[ROOT/'public/CCG Downloads/CCG_Scripts'/f'c{code}.lua' for code in [238273772]]+[ROOT/'tmp/omega_scripts'/name for name in ['constant.lua','utility.lua','procedure.lua']]+list((ROOT/'node_modules/@n1xx1/ocgcore-wasm/dist').glob('*.js'))
before={p.relative_to(ROOT).as_posix():sha(p) for p in paths};runs=[]
for flag,expected in [(None,[]),('no-placement',[0]),('no-battle-trigger',[0,1])]:
 r=subprocess.run(['node','--no-warnings','scripts/fresh_current_symphonic_megastaar_battle_leave.cjs']+(['--'+flag] if flag else []),capture_output=True,text=True,timeout=20)
 p=OUT/('current-symphonic-megastaar-battle-leave'+('-'+flag if flag else '')+'.json');d=json.loads(p.read_text())
 assert len(d['results'])==4 and all(not v['logs'] for v in d['results']),r.stdout+r.stderr
 assert [i for i,v in enumerate(d['results']) if v['failure']]==expected,(flag,r.stdout)
 assert r.returncode==(1 if expected else 0)
 runs.append({'flag':flag,'artifact':p.name,'artifact_sha256':sha(p),'expected_failures':expected})

assert before=={p.relative_to(ROOT).as_posix():sha(p) for p in paths}
inst=Path(r'C:\Program Files (x86)\YGO Omega\YGO Omega_Data\Files\Scripts')
for code in [238273772]:assert (ROOT/'public/CCG Downloads/CCG_Scripts'/f'c{code}.lua').read_bytes()==(inst/f'c{code}.lua').read_bytes()
(OUT/'current-symphonic-megastaar-battle-leave-batch.json').write_text(json.dumps({'status':'VERIFIED_PARTIAL_COMPATIBILITY_DIAGNOSTIC','baseline_cases':4,'runtime_dependencies_sha256':before,'runs':runs,'scope':'FullMegaStaar/currentcanonicalmetadata/correctedCardData/actualpropernativeSynchrohistory via explicitboundedlegacySynchroAPI+IsNotTuner adapters. NaturalNEW_TURN0/1/0 actualown3 attack versus6000ATKopponent, nativeATTACK/exactbattleDAMAGE/properHINT701. Actualoptional battleleaveprompt followedPZoneplacement, decline/fullPZones retainactualfaceupExtra; versus1000ATK MegaStaar survives/nooffer. Optionalchoicecountchecked so missingtriggercontrolalsofailsdecline. NoPlacement1/noBattleTrigger2exactfailures, emptylogs/frozeninputs/parity. Compatibilitydiagnostic notOmega/generalrecipe/fullcard; banishsoftuse/reset remainsopen.'},indent=2)+'\n',encoding='utf-8');print('MegaStaar4battleleaveCOMPATPASS;controls1/2verified; frozeninputs/parity')

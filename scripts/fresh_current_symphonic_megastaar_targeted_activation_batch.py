import hashlib,json,subprocess
from pathlib import Path
ROOT=Path.cwd();OUT=ROOT/'output/fresh-ccg-september'
def sha(p):return hashlib.sha256(p.read_bytes()).hexdigest()
paths=[Path(__file__).resolve(),ROOT/'scripts/fresh_corrected_card_data_transport.cjs',ROOT/'scripts/fresh_current_card.cjs',OUT/'current-spec-CCG_v1.db',ROOT/'src/data/cards.json',ROOT/'node_modules/@n1xx1/ocgcore-wasm/dist/index-card-data-transport-candidate.mjs']+[ROOT/'scripts/fresh_current_symphonic_megastaar_targeted_activation.cjs']+[ROOT/'public/CCG Downloads/CCG_Scripts'/f'c{code}.lua' for code in [238273772]]+[ROOT/'tmp/omega_scripts'/name for name in ['constant.lua','utility.lua','procedure.lua']]+list((ROOT/'node_modules/@n1xx1/ocgcore-wasm/dist').glob('*.js'))
before={p.relative_to(ROOT).as_posix():sha(p) for p in paths};runs=[]
for flag,expected in [(None,[]),('no-target-protection',[0]),('protect-own',[1]),('no-target-operation',[1])]:
 r=subprocess.run(['node','--no-warnings','scripts/fresh_current_symphonic_megastaar_targeted_activation.cjs']+(['--'+flag] if flag else []),capture_output=True,text=True,timeout=20)
 p=OUT/('current-symphonic-megastaar-targeted-activation'+('-'+flag if flag else '')+'.json');d=json.loads(p.read_text())
 assert len(d['results'])==2 and all(not v['logs'] for v in d['results']),r.stdout+r.stderr
 assert [i for i,v in enumerate(d['results']) if v['failure']]==expected,(flag,r.stdout)
 assert r.returncode==(1 if expected else 0)
 runs.append({'flag':flag,'artifact':p.name,'artifact_sha256':sha(p),'expected_failures':expected})

assert before=={p.relative_to(ROOT).as_posix():sha(p) for p in paths}
inst=Path(r'C:\Program Files (x86)\YGO Omega\YGO Omega_Data\Files\Scripts')
for code in [238273772]:assert (ROOT/'public/CCG Downloads/CCG_Scripts'/f'c{code}.lua').read_bytes()==(inst/f'c{code}.lua').read_bytes()
(OUT/'current-symphonic-megastaar-targeted-activation-batch.json').write_text(json.dumps({'status':'VERIFIED_PARTIAL_COMPATIBILITY_DIAGNOSTIC','baseline_cases':2,'runtime_dependencies_sha256':before,'runs':runs,'scope':'FullMegaStaar/currentcanonicalmetadata/correctedCardData, actualpropernativeSynchrohistory withsameboundedtestonlylegacySynchroAPI/IsNotTuner adapters. ActualnativeIsExistingTarget/SelectTarget Spell availability: opponent chainedQuickPlay has nolegal activation; ownSpell actuallyselectsMegaStaar, nativeBECOME_TARGET, resolvesSendtoGrave intoactualfaceupExtra. Nativefield/PZone/Extra/properhistory outcomeschecked. RemoveProtection1/protectOwn1/noTargetOperation1exactsemanticfailures, emptylogs/frozeninputs/sourceinstallparity. Compatibilitydiagnostic notactualOmega/generalrecipe/fullcard; battleleave andsoftuse/reset stillopen.'},indent=2)+'\n',encoding='utf-8');print('MegaStaar2targetedactivationCOMPATPASS;controls1/1/1verified; frozeninputs/parity')

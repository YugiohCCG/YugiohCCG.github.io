import hashlib,json,subprocess
from pathlib import Path
ROOT=Path.cwd();OUT=ROOT/'output/fresh-ccg-september'
def sha(p):return hashlib.sha256(p.read_bytes()).hexdigest()
paths=[Path(__file__).resolve(),ROOT/'scripts/fresh_corrected_card_data_transport.cjs',ROOT/'scripts/fresh_installed_card.cjs',Path(r'C:\Program Files (x86)\YGO Omega\YGO Omega_Data\Files\Databases\CCG_v1.db'),ROOT/'src/data/cards.json',ROOT/'node_modules/@n1xx1/ocgcore-wasm/dist/index-card-data-transport-candidate.mjs']+[ROOT/'scripts/fresh_current_talismandrake_sear_pendulum_response.cjs']+[ROOT/'public/CCG Downloads/CCG_Scripts'/f'c{code}.lua' for code in [245935439]]+[ROOT/'tmp/omega_scripts'/name for name in ['constant.lua','utility.lua','procedure.lua']]+list((ROOT/'node_modules/@n1xx1/ocgcore-wasm/dist').glob('*.js'))
before={str(p.resolve()):sha(p) for p in paths};runs=[]
for flag,expected in [(None,[]),('no-fusion',[0,1,4]),('no-material',[0,1,4]),('no-complete',[0,1,4]),('allow-own',[2,3]),('no-response',[5,6,7,8,9])]:
 r=subprocess.run(['node','--no-warnings','scripts/fresh_current_talismandrake_sear_pendulum_response.cjs','--material-api-compat']+(['--'+flag] if flag else []),capture_output=True,text=True,timeout=20)
 p=OUT/('current-talismandrake-sear-pendulum-response-material-api-compat'+('-'+flag if flag else '')+'.json');d=json.loads(p.read_text())
 assert len(d['results'])==10 and all(not v['logs'] for v in d['results']),r.stdout+r.stderr
 assert [i for i,v in enumerate(d['results']) if v['failure']]==expected,(flag,r.stdout)
 assert r.returncode==(1 if expected else 0)
 runs.append({'flag':flag,'artifact':p.name,'artifact_sha256':sha(p),'expected_failures':expected})

assert before=={str(p.resolve()):sha(p) for p in paths}
inst=Path(r'C:\Program Files (x86)\YGO Omega\YGO Omega_Data\Files\Scripts')
for code in [245935439]:assert (ROOT/'public/CCG Downloads/CCG_Scripts'/f'c{code}.lua').read_bytes()==(inst/f'c{code}.lua').read_bytes()
(OUT/'current-talismandrake-sear-pendulum-response-batch.json').write_text(json.dumps({'status':'VERIFIED_PARTIAL_COMPATIBILITY_DIAGNOSTIC','baseline_cases':10,'runtime_dependencies_sha256':before,'runs':runs,'scope':'FullSear/actualinstalledmetadata/correctedCardData/actualHANDPZone, sameexplicitboundedmissingmandatorymaterialAPIadapter andneutral2coderecipefunctionfilters. ActualopponentSpell/MonsterCL1 -> SearQuickFusionCL2; ownSpell/Monsterexcluded. Field+PZoneactualmaterials supported. ActualCounterTrapCL3 NegAct/NegEffect/sourceBanish/materialBanish/lateSSlock preventFusion; actualREMOVEDsource/material verified. Success3nativeFusion/actualmaterials/properCHAIN_END701; exactCL2/CL3counts. NoFusion3/noMaterial3/noComplete3/allowOwn2/noResponse5semanticfailures/emptylogs/frozeninputs/parity. Compatibilitydiagnostic notnativeOmega/generalproductionFusionrecipes/fullcard; usage/secondarytrigger open.'},indent=2)+'\n',encoding='utf-8');print('Sear10responseCOMPATPASS;controls3/3/3/2/5verified; frozeninputs/parity')

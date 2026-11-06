import hashlib,json,subprocess
from pathlib import Path
ROOT=Path.cwd();OUT=ROOT/'output/fresh-ccg-september'
def sha(p):return hashlib.sha256(p.read_bytes()).hexdigest()
paths=[Path(__file__).resolve(),ROOT/'scripts/fresh_corrected_card_data_transport.cjs',ROOT/'scripts/fresh_installed_card.cjs',Path(r'C:\Program Files (x86)\YGO Omega\YGO Omega_Data\Files\Databases\CCG_v1.db'),ROOT/'src/data/cards.json',ROOT/'node_modules/@n1xx1/ocgcore-wasm/dist/index-card-data-transport-candidate.mjs']+[ROOT/'scripts/fresh_current_talismandrake_sear_pendulum_use_reset.cjs']+[ROOT/'public/CCG Downloads/CCG_Scripts'/f'c{code}.lua' for code in [245935439]]+[ROOT/'tmp/omega_scripts'/name for name in ['constant.lua','utility.lua','procedure.lua']]+list((ROOT/'node_modules/@n1xx1/ocgcore-wasm/dist').glob('*.js'))
before={str(p.resolve()):sha(p) for p in paths};runs=[]
for flag,expected in [(None,[]),('per-copy',[0,1,2]),('no-reset',[0,1,2]),('split-mode',[0,1,2])]:
 r=subprocess.run(['node','--no-warnings','scripts/fresh_current_talismandrake_sear_pendulum_use_reset.cjs','--material-api-compat']+(['--'+flag] if flag else []),capture_output=True,text=True,timeout=20)
 p=OUT/('current-talismandrake-sear-pendulum-use-reset-material-api-compat'+('-'+flag if flag else '')+'.json');d=json.loads(p.read_text())
 assert len(d['results'])==3 and all(not v['logs'] for v in d['results']),r.stdout+r.stderr
 assert [i for i,v in enumerate(d['results']) if v['failure']]==expected,(flag,r.stdout)
 assert r.returncode==(1 if expected else 0)
 if expected:assert all(v['turn']==(3 if flag=='no-reset' else 1) for v in d['results'])
 runs.append({'flag':flag,'artifact':p.name,'artifact_sha256':sha(p),'expected_failures':expected})

assert before=={str(p.resolve()):sha(p) for p in paths}
inst=Path(r'C:\Program Files (x86)\YGO Omega\YGO Omega_Data\Files\Scripts')
for code in [245935439]:assert (ROOT/'public/CCG Downloads/CCG_Scripts'/f'c{code}.lua').read_bytes()==(inst/f'c{code}.lua').read_bytes()
(OUT/'current-talismandrake-sear-pendulum-use-reset-batch.json').write_text(json.dumps({'status':'VERIFIED_PARTIAL_COMPATIBILITY_DIAGNOSTIC','baseline_cases':3,'runtime_dependencies_sha256':before,'runs':runs,'scope':'FullSear/actualinstalledmetadata/correctedCardData/sameexplicitboundedmissingmandatorymaterialAPIadapter/neutral2coderecipe. ActualtwoHANDPZonecopies0/4 and4fieldmaterialreserves/twoFusionExtra. FirstIGNsuccess/actualCL2NegAct/NegEffect spendsnameduse; othercopyIGN excludedsameown1 despiteusable2or4materials. OwnneutralSpellCL1/opponentQuickPlayCL2 actualactivation checksQuickmodealsospent(notCounterTrap-speed exclusion). NaturalNEW_TURN0/1/0 oppositecopyown3actualFusion;MZONEFusion2baseline/1negated, actualmaterialsGYNORMAL/ExtraPendcounts/reserve/properHINT701 checked. PerCopy3turn1/noReset3turn3/splitModes3turn1exactsemanticfailures,emptylogs/frozeninputs/parity. Compatibilitydiagnostic notOmega/generalFusionrecipes/fullcard; secondarymaterialeffect stillopen.'},indent=2)+'\n',encoding='utf-8');print('Sear3sharedresetCOMPATPASS;controls3/3/3verified; frozeninputs/parity')

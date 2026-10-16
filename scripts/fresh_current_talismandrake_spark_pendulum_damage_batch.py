import hashlib,json,subprocess
from pathlib import Path
ROOT=Path.cwd();OUT=ROOT/'output/fresh-ccg-september'
def sha(p):return hashlib.sha256(p.read_bytes()).hexdigest()
paths=[Path(__file__).resolve(),ROOT/'scripts/fresh_corrected_card_data_transport.cjs',ROOT/'scripts/fresh_current_card.cjs',OUT/'current-spec-CCG_v1.db',ROOT/'src/data/cards.json',ROOT/'node_modules/@n1xx1/ocgcore-wasm/dist/index-card-data-transport-candidate.mjs']+[ROOT/'scripts/fresh_current_talismandrake_spark_pendulum_damage.cjs']+[ROOT/'public/CCG Downloads/CCG_Scripts'/f'c{code}.lua' for code in [230947464]]+[ROOT/'tmp/omega_scripts'/name for name in ['constant.lua','utility.lua','procedure.lua']]+list((ROOT/'node_modules/@n1xx1/ocgcore-wasm/dist').glob('*.js'))
before={p.relative_to(ROOT).as_posix():sha(p) for p in paths};runs=[]
for flag,expected in [(None,[]),('no-damage',[0]),('no-race-filter',[2]),('allow-ordinary',[3]),('allow-opponent',[5])]:
 r=subprocess.run(['node','--no-warnings','scripts/fresh_current_talismandrake_spark_pendulum_damage.cjs','--chaininfo-compat']+(['--'+flag] if flag else []),capture_output=True,text=True,timeout=20)
 p=OUT/('current-talismandrake-spark-pendulum-damage-chaininfo-compat'+('-'+flag if flag else '')+'.json');d=json.loads(p.read_text())
 assert len(d['results'])==6 and all(not v['logs'] for v in d['results']),r.stdout+r.stderr
 assert [i for i,v in enumerate(d['results']) if v['failure']]==expected,(flag,r.stdout)
 assert r.returncode==(1 if expected else 0)
 runs.append({'flag':flag,'artifact':p.name,'artifact_sha256':sha(p),'expected_failures':expected})

r=subprocess.run(['node','--no-warnings','scripts/fresh_current_talismandrake_spark_pendulum_damage.cjs'],capture_output=True,text=True,timeout=20)
p=OUT/'current-talismandrake-spark-pendulum-damage.json';d=json.loads(p.read_text())
assert r.returncode==1 and [i for i,v in enumerate(d['results']) if v['failure']]==[0]
assert 'invalid CHAININFO flag' in d['results'][0]['failure']
assert all(not v['logs'] for v in d['results'][1:])
runs.append({'flag':'unadapted-legacy-constants','artifact':p.name,'artifact_sha256':sha(p),'expected_compatibility_failure':[0]})
assert before=={p.relative_to(ROOT).as_posix():sha(p) for p in paths}
inst=Path(r'C:\Program Files (x86)\YGO Omega\YGO Omega_Data\Files\Scripts')
for code in [230947464]:assert (ROOT/'public/CCG Downloads/CCG_Scripts'/f'c{code}.lua').read_bytes()==(inst/f'c{code}.lua').read_bytes()
(OUT/'current-talismandrake-spark-pendulum-damage-batch.json').write_text(json.dumps({'status':'VERIFIED_PARTIAL_COMPATIBILITY_DIAGNOSTIC','baseline_cases':6,'runtime_dependencies_sha256':before,'runs':runs,'scope':'FullSpark/currentcanonicalmetadata/correctedCardData/actualHandPZone. NeutralSpell setsactual2materialgroup/sendsmaterials/reallySpecialSummons withFusiontype andCompleteProcedure afterward. Exact500nativeDAMAGE andoptionaltrigger onownPyroFusion; decline/nonPyro/ordinarySS/nonFusion/opponentcontroller exclude. ExplicittestonlyCHAININFO_TARGET_PLAYER9/TARGET_PARAM10 modernconstantcompatibility perProjectIgnis; unadaptedlegacyconstants error inpubliccore. NoDamage1/noRace1/allowOrdinary1/allowOpponent1semanticfailures, emptylogs/frozeninputs/parity. Compatibilitydiagnostic notOmega/fullcard; printedFusionrecipe/sharedusage/reset/interruptions open.'},indent=2)+'\n',encoding='utf-8');print('Spark6damageCOMPATPASS;controls1/1/1/1verified; frozeninputs/parity')

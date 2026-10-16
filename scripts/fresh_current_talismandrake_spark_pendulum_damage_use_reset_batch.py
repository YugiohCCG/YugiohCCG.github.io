import hashlib,json,subprocess
from pathlib import Path
ROOT=Path.cwd();OUT=ROOT/'output/fresh-ccg-september'
def sha(p):return hashlib.sha256(p.read_bytes()).hexdigest()
paths=[Path(__file__).resolve(),ROOT/'scripts/fresh_corrected_card_data_transport.cjs',ROOT/'scripts/fresh_current_card.cjs',OUT/'current-spec-CCG_v1.db',ROOT/'src/data/cards.json',ROOT/'node_modules/@n1xx1/ocgcore-wasm/dist/index-card-data-transport-candidate.mjs']+[ROOT/'scripts/fresh_current_talismandrake_spark_pendulum_damage_use_reset.cjs']+[ROOT/'public/CCG Downloads/CCG_Scripts'/f'c{code}.lua' for code in [230947464]]+[ROOT/'tmp/omega_scripts'/name for name in ['constant.lua','utility.lua','procedure.lua']]+list((ROOT/'node_modules/@n1xx1/ocgcore-wasm/dist').glob('*.js'))
before={p.relative_to(ROOT).as_posix():sha(p) for p in paths};runs=[]
for flag,expected in [(None,[]),('per-copy',[0,1,2]),('no-reset',[0,1,2])]:
 r=subprocess.run(['node','--no-warnings','scripts/fresh_current_talismandrake_spark_pendulum_damage_use_reset.cjs','--chaininfo-compat']+(['--'+flag] if flag else []),capture_output=True,text=True,timeout=20)
 p=OUT/('current-talismandrake-spark-pendulum-damage-use-reset-chaininfo-compat'+('-'+flag if flag else '')+'.json');d=json.loads(p.read_text())
 assert len(d['results'])==3 and all(not v['logs'] for v in d['results']),r.stdout+r.stderr
 assert [i for i,v in enumerate(d['results']) if v['failure']]==expected,(flag,r.stdout)
 assert r.returncode==(1 if expected else 0)
 if expected:assert all(v['turn']==(3 if flag=='no-reset' else 1) for v in d['results'])
 runs.append({'flag':flag,'artifact':p.name,'artifact_sha256':sha(p),'expected_failures':expected})

assert before=={p.relative_to(ROOT).as_posix():sha(p) for p in paths}
inst=Path(r'C:\Program Files (x86)\YGO Omega\YGO Omega_Data\Files\Scripts')
for code in [230947464]:assert (ROOT/'public/CCG Downloads/CCG_Scripts'/f'c{code}.lua').read_bytes()==(inst/f'c{code}.lua').read_bytes()
(OUT/'current-talismandrake-spark-pendulum-damage-use-reset-batch.json').write_text(json.dumps({'status':'VERIFIED_PARTIAL_COMPATIBILITY_DIAGNOSTIC','baseline_cases':3,'runtime_dependencies_sha256':before,'runs':runs,'scope':'FullSpark/currentcanonicalmetadata/correctedCardData/twoactualHANDPZonecopies remain. Threeactualneutral2materialFusionSS events: twoown1 thennaturalNEW_TURN0/1/0 own3. Namedsharedoptionaluse1own1 evenafteractualCL2NegAct/NegEffect; own3renewedoffer2total. ExactDAMAGE1000baseline/500negatedfirst, actualFusionMZONEcounts3/nativehistoryHINT3/CL2 andbothPZonecopieschecked. ExplicitCHAININFO_PLAYER9/PARAM10 testonlycompat mapping, notOmega/fullcard certification. PerCopy3turn1/noReset3turn3 exactsemanticfailures, emptylogs/frozeninputs/parity. Othermonstereffects/remainingPend/full711 open.'},indent=2)+'\n',encoding='utf-8');print('Spark3damageuseresetCOMPATPASS;controls3/3verified; frozeninputs/parity')

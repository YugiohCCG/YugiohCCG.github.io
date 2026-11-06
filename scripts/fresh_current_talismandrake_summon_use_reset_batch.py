import hashlib,json,subprocess
from pathlib import Path
ROOT=Path.cwd();OUT=ROOT/'output/fresh-ccg-september'
def sha(p):return hashlib.sha256(p.read_bytes()).hexdigest()
paths=[Path(__file__).resolve(),ROOT/'scripts/fresh_corrected_card_data_transport.cjs',ROOT/'scripts/fresh_installed_card.cjs',Path(r'C:\Program Files (x86)\YGO Omega\YGO Omega_Data\Files\Databases\CCG_v1.db'),ROOT/'src/data/cards.json',ROOT/'node_modules/@n1xx1/ocgcore-wasm/dist/index-card-data-transport-candidate.mjs']+[ROOT/'scripts/fresh_current_talismandrake_summon_use_reset.cjs']+[ROOT/'public/CCG Downloads/CCG_Scripts'/f'c{code}.lua' for code in [230947464,256928871]]+[ROOT/'tmp/omega_scripts'/name for name in ['constant.lua','utility.lua','procedure.lua']]+list((ROOT/'node_modules/@n1xx1/ocgcore-wasm/dist').glob('*.js'))
before={str(p.resolve()):sha(p) for p in paths};runs=[]
for code in [230947464,256928871]:
 for flag,expected in [(None,[]),('per-copy',[0,1,2]),('no-reset',[0,1,2]),('split-summon',[0,1,2]),('no-result',[0,1,2])]:
  if code==256928871 and expected:expected=expected+[3]
  r=subprocess.run(['node','--no-warnings','scripts/fresh_current_talismandrake_summon_use_reset.cjs','--boss='+str(code)]+(['--chaininfo-compat'] if code==256928871 else [])+(['--'+flag] if flag else []),capture_output=True,text=True,timeout=20)
  p=OUT/('current-talismandrake-summon-use-reset-'+str(code)+('-chaininfo-compat' if code==256928871 else '')+('-'+flag if flag else '')+'.json');d=json.loads(p.read_text())
  assert len(d['results'])==(4 if code==256928871 else 3) and all(not v['logs'] for v in d['results']),r.stdout+r.stderr
  assert [i for i,v in enumerate(d['results']) if v['failure']]==expected,(code,flag,r.stdout)
  assert r.returncode==(1 if expected else 0)
  if flag in ['per-copy','no-reset','split-summon']:assert all(v['turn']==(3 if flag=='no-reset' else 1) for v in d['results'])
  runs.append({'code':code,'flag':flag,'artifact':p.name,'artifact_sha256':sha(p),'expected_failures':expected})

assert before=={str(p.resolve()):sha(p) for p in paths}
inst=Path(r'C:\Program Files (x86)\YGO Omega\YGO Omega_Data\Files\Scripts')
for code in [230947464,256928871]:assert (ROOT/'public/CCG Downloads/CCG_Scripts'/f'c{code}.lua').read_bytes()==(inst/f'c{code}.lua').read_bytes()
(OUT/'current-talismandrake-summon-use-reset-batch.json').write_text(json.dumps({'status':'VERIFIED_PARTIAL_NATIVE_SPARK_COMPATIBILITY_EMBERS','baseline_cases':7,'runtime_dependencies_sha256':before,'runs':runs,'scope':'Full Spark3 native/Embers4 compatibility cases: first Normal Summon (additional Embers Flip case), second copy Special Summon same turn, third next own turn. Success/actual CL2 activation/effect negation spend shared named search/draw use; other copies/summon-type clones cannot bypass; next-turn native reset. Exact result/source summon counts and NEW_TURN0/1/0. PerCopy/noReset/splitSummon/noResult controls each Spark3/Embers4 failures. Explicit test-only CHAININFO9/10 mapping for Embers; no Lua adapter Spark. No liveOmega/fullcard certification.'},indent=2)+'\n',encoding='utf-8');print('Spark3native/Embers4compatSummonUseResetPASS;fourcontrols3/4eachverified; frozeninputs/parity')

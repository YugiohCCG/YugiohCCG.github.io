import hashlib,json,subprocess
from pathlib import Path
ROOT=Path.cwd();OUT=ROOT/'output/fresh-ccg-september'
def sha(p):return hashlib.sha256(p.read_bytes()).hexdigest()
paths=[Path(__file__).resolve(),ROOT/'scripts/fresh_corrected_card_data_transport.cjs',ROOT/'scripts/fresh_installed_card.cjs',Path(r'C:\Program Files (x86)\YGO Omega\YGO Omega_Data\Files\Databases\CCG_v1.db'),ROOT/'src/data/cards.json',ROOT/'node_modules/@n1xx1/ocgcore-wasm/dist/index-card-data-transport-candidate.mjs']+[ROOT/'scripts/fresh_current_talismandrake_extra_placement_use_reset.cjs']+[ROOT/'public/CCG Downloads/CCG_Scripts'/f'c{code}.lua' for code in [230947464,256928871]]+[ROOT/'tmp/omega_scripts'/name for name in ['constant.lua','utility.lua','procedure.lua']]+list((ROOT/'node_modules/@n1xx1/ocgcore-wasm/dist').glob('*.js'))
before={str(p.resolve()):sha(p) for p in paths};runs=[]
for code in [230947464,256928871]:
 for flag,expected in [(None,[]),('per-copy',[0,1,2]),('no-reset',[0,1,2]),('no-placement',[0,1,2])]:
  r=subprocess.run(['node','--no-warnings','scripts/fresh_current_talismandrake_extra_placement_use_reset.cjs','--boss='+str(code)]+(['--'+flag] if flag else []),capture_output=True,text=True,timeout=20)
  p=OUT/('current-talismandrake-extra-placement-use-reset-'+str(code)+('-'+flag if flag else '')+'.json');d=json.loads(p.read_text())
  assert len(d['results'])==3 and all(not v['logs'] for v in d['results']),r.stdout+r.stderr
  assert [i for i,v in enumerate(d['results']) if v['failure']]==expected,(code,flag,r.stdout)
  assert r.returncode==(1 if expected else 0)
  if flag in ['per-copy','no-reset']:assert all(v['turn']==(1 if flag=='per-copy' else 3) for v in d['results'])
  runs.append({'code':code,'flag':flag,'artifact':p.name,'artifact_sha256':sha(p),'expected_failures':expected})

assert before=={str(p.resolve()):sha(p) for p in paths}
inst=Path(r'C:\Program Files (x86)\YGO Omega\YGO Omega_Data\Files\Scripts')
for code in [230947464,256928871]:assert (ROOT/'public/CCG Downloads/CCG_Scripts'/f'c{code}.lua').read_bytes()==(inst/f'c{code}.lua').read_bytes()
(OUT/'current-talismandrake-extra-placement-use-reset-batch.json').write_text(json.dumps({'status':'VERIFIED_PARTIAL_NATIVE_SECONDARY_EFFECT','baseline_cases':6,'runtime_dependencies_sha256':before,'runs':runs,'scope':'Full Spark/Embers source actual Extra placement shared named use/reset across copies. Three neutral fixed-two-material Fusion operations, each new source HAND->MZONE->faceupExtra; previous placed source returned Extra to free PZones. Success/actual CL2 negated activation/effect spends named use, second newcopy same turn excluded with space/Extra reserves, third Fusion next own turn activates one of multiple copies. Native NEW_TURN0/1/0, exact Fusion/placement counts. No Lua API adapter. PerCopy3turn1/noReset3turn3/noPlacement3 failures per card. Other monster effects/general Fusion recipes/liveOmega/fullcard open.'},indent=2)+'\n',encoding='utf-8');print('Spark/Embers6ExtraPlacementUseResetNATIVEPASS;eachcontrols3/3/3verified; frozeninputs/parity')

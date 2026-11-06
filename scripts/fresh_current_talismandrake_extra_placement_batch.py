import hashlib,json,subprocess
from pathlib import Path
ROOT=Path.cwd();OUT=ROOT/'output/fresh-ccg-september'
def sha(p):return hashlib.sha256(p.read_bytes()).hexdigest()
paths=[Path(__file__).resolve(),ROOT/'scripts/fresh_corrected_card_data_transport.cjs',ROOT/'scripts/fresh_installed_card.cjs',Path(r'C:\Program Files (x86)\YGO Omega\YGO Omega_Data\Files\Databases\CCG_v1.db'),ROOT/'src/data/cards.json',ROOT/'node_modules/@n1xx1/ocgcore-wasm/dist/index-card-data-transport-candidate.mjs']+[ROOT/'scripts/fresh_current_talismandrake_extra_placement.cjs']+[ROOT/'public/CCG Downloads/CCG_Scripts'/f'c{code}.lua' for code in [230947464,256928871]]+[ROOT/'tmp/omega_scripts'/name for name in ['constant.lua','utility.lua','procedure.lua']]+list((ROOT/'node_modules/@n1xx1/ocgcore-wasm/dist').glob('*.js'))
before={str(p.resolve()):sha(p) for p in paths};runs=[]
for code in [230947464,256928871]:
 for flag,expected in [(None,[]),('no-placement',[0,1]),('allow-attribute',[2]),('allow-race',[3]),('allow-summon-type',[5])]:
  r=subprocess.run(['node','--no-warnings','scripts/fresh_current_talismandrake_extra_placement.cjs','--boss='+str(code)]+(['--'+flag] if flag else []),capture_output=True,text=True,timeout=20)
  p=OUT/('current-talismandrake-extra-placement-'+str(code)+('-'+flag if flag else '')+'.json');d=json.loads(p.read_text())
  assert len(d['results'])==8 and all(not v['logs'] for v in d['results']),r.stdout+r.stderr
  assert [i for i,v in enumerate(d['results']) if v['failure']]==expected,(code,flag,r.stdout)
  assert r.returncode==(1 if expected else 0)
  runs.append({'code':code,'flag':flag,'artifact':p.name,'artifact_sha256':sha(p),'expected_failures':expected})

assert before=={str(p.resolve()):sha(p) for p in paths}
inst=Path(r'C:\Program Files (x86)\YGO Omega\YGO Omega_Data\Files\Scripts')
for code in [230947464,256928871]:assert (ROOT/'public/CCG Downloads/CCG_Scripts'/f'c{code}.lua').read_bytes()==(inst/f'c{code}.lua').read_bytes()
(OUT/'current-talismandrake-extra-placement-batch.json').write_text(json.dumps({'status':'VERIFIED_PARTIAL_NATIVE_SECONDARY_EFFECT','baseline_cases':16,'runtime_dependencies_sha256':before,'runs':runs,'scope':'Spark and Embers full source actual Extra-to-PZone trigger: source summoned then destroyed to faceup Extra, two actual Fusion-materials/reason/Fusion summon/proper completion via neutral fixed recipe operation. Eight cases each: own DARK Pyro Fusion any archetype accepted; wrong race/attribute/nonFusion/nonFusionSummon/opponent/fullPZones excluded. Setup Spell preseed SZONE2 preserves both actual PZones. No Lua API adapter. Focused native eligibility; interruptions/shared reset/liveOmega/fullcard open.'},indent=2)+'\n',encoding='utf-8');print('Spark/Embers16ExtraPlacementNATIVEPASS;eachcontrols2/1/1/1verified; frozeninputs/parity')

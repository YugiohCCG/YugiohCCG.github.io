import hashlib,json,subprocess
from pathlib import Path
ROOT=Path.cwd();OUT=ROOT/'output/fresh-ccg-september';FILES=Path(r'C:\Program Files (x86)\YGO Omega\YGO Omega_Data\Files')
def sha(p):return hashlib.sha256(p.read_bytes()).hexdigest()
plans={'coin_pendulum':(2,[1]),'nerve_pendulum':(3,[1,2]),'ivy_battle_lock':(2,[1]),'sword_fern_replacement':(4,[0,1])}
paths=[Path(__file__).resolve(),ROOT/'scripts/fresh_current_terrarumian_secondary_refresh.cjs',ROOT/'scripts/fresh_installed_card.cjs',ROOT/'scripts/fresh_corrected_card_data_transport.cjs',ROOT/'src/data/cards.json',FILES/'Databases/CCG_v1.db',OUT/'candidate-CCG_v1.db']+[ROOT/'scripts'/('fresh_terrarumian_'+n+'.cjs') for n in plans]+[ROOT/'public/CCG Downloads/CCG_Scripts'/f'c{c}.lua' for c in range(284639717,284639725)]+[ROOT/'tmp/omega_scripts'/n for n in ['constant.lua','utility.lua','procedure.lua']]+list((ROOT/'node_modules/@n1xx1/ocgcore-wasm/dist').glob('*.js'))+[ROOT/'node_modules/@n1xx1/ocgcore-wasm/dist/index-card-data-transport-candidate.mjs']
before={str(p.resolve()):sha(p) for p in paths};runs=[]
for name,(count,expected) in plans.items():
 for control in [None,'no-secondary']:
  r=subprocess.run(['node','--no-warnings','scripts/fresh_current_terrarumian_secondary_refresh.cjs',name]+(['--'+control] if control else []),capture_output=True,text=True,timeout=20)
  p=OUT/('current-terrarumian-'+name.replace('_','-')+('-'+control if control else '')+'.json');d=json.loads(p.read_text());actual=[i for i,v in enumerate(d['results']) if v['failure']]
  assert len(d['results'])==count and actual==(expected if control else []) and all(not v['logs'] for v in d['results']),(name,control,r.stdout+r.stderr,len(d['results']))
  assert r.returncode==bool(actual)
  runs.append({'fixture':name,'control':control,'artifact':p.name,'sha256':sha(p),'expected_failures':actual})
assert before=={str(p.resolve()):sha(p) for p in paths}
assert all((ROOT/'public/CCG Downloads/CCG_Scripts'/f'c{c}.lua').read_bytes()==(FILES/'Scripts'/f'c{c}.lua').read_bytes() for c in range(284639717,284639725))
report={'status':'BOUNDED_NATIVE_SECONDARY_REFRESH','runtime_dependencies_sha256':before,'runs':runs,'scope':'Four reused full-source fixtures with installed production metadata/corrected transport; no Lua API adapter. Coin native ATK reduction under zero/one neutral defense Pendulum; Nerve native DEF boost from own/opponent Terrarumians; Ivy actual opposing battle activation lock with non-archetype boundary; Sword Field Zone destroy/banish replacement accept/decline and own-effect exclusions. Effective disabled-secondary controls. Existing neutral support data; not full-card/live Omega certification. Further dynamic count/category boundaries not inferred.'}
(OUT/'current-terrarumian-secondary-refresh-batch.json').write_text(json.dumps(report,indent=2)+'\n',encoding='utf-8');print('Terrarumian secondary native outcomes/controls refreshed')

import hashlib,json,subprocess
from pathlib import Path
ROOT=Path.cwd();OUT=ROOT/'output/fresh-ccg-september';FILES=Path(r'C:\Program Files (x86)\YGO Omega\YGO Omega_Data\Files')
def sha(p):return hashlib.sha256(p.read_bytes()).hexdigest()
source=ROOT/'public/CCG Downloads/CCG_Scripts/c215853847.lua';assert source.read_bytes()==(FILES/'Scripts'/source.name).read_bytes()
paths=[Path(__file__).resolve(),source,ROOT/'src/data/cards.json',FILES/'Databases/CCG_v1.db',OUT/'candidate-CCG_v1.db']+[ROOT/'scripts'/n for n in ['fresh_current_rigel_interruption.cjs','fresh_current_rigel_material_atk.cjs','fresh_installed_card.cjs','fresh_corrected_card_data_transport.cjs']]+[ROOT/'tmp/omega_scripts'/n for n in ['constant.lua','utility.lua','procedure.lua']]+list((ROOT/'node_modules/@n1xx1/ocgcore-wasm/dist').glob('*.js'))+[ROOT/'node_modules/@n1xx1/ocgcore-wasm/dist/index-card-data-transport-candidate.mjs']
deps={str(p.resolve()):sha(p) for p in paths};runs=[]
for flag,expected in [(None,[]),('no-response',[1,2,3]),('no-use-limit',[0,1,2]),('no-relation',[3])]:
 r=subprocess.run(['node','--no-warnings','scripts/fresh_current_rigel_interruption.cjs']+(['--'+flag] if flag else []),capture_output=True,text=True,timeout=20);p=OUT/('current-rigel-interruption'+('-'+flag if flag else '')+'.json');d=json.loads(p.read_text());assert len(d['results'])==4 and [i for i,v in enumerate(d['results']) if v['failure']]==expected and all(not v['logs'] and v['trace'] for v in d['results']) and r.returncode==bool(expected),r.stdout+r.stderr
 runs.append({'artifact':p.name,'sha256':sha(p),'expected_failures':expected})
assert deps=={str(p.resolve()):sha(p) for p in paths}
(OUT/'current-rigel-interruption-batch.json').write_text(json.dumps({'status':'RIGEL_INTERRUPTION_VERIFIED','runtime_dependencies_sha256':deps,'runs':runs,'scope':'Actual paid fixed Link setup/current installed metadata/corrected transport/no Lua API adapter. CL1 original ignition and actual CL2 negation or source banishment; ATK/ally attack availability/named use consumed. Effective no-response/no-use-limit/no-relation controls. Link monsters cannot be turned facedown. Original general Link procedure/full-card/live Omega remain separate.','production_change':False},indent=2)+'\n')
print('Rigel interruption verified with effective controls')

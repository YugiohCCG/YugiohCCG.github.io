import hashlib,json,subprocess
from pathlib import Path
ROOT=Path.cwd();OUT=ROOT/'output/fresh-ccg-september';FILES=Path(r'C:\Program Files (x86)\YGO Omega\YGO Omega_Data\Files')
def sha(p):return hashlib.sha256(p.read_bytes()).hexdigest()
source=ROOT/'public/CCG Downloads/CCG_Scripts/c233759343.lua';assert source.read_bytes()==(FILES/'Scripts'/source.name).read_bytes()
paths=[Path(__file__).resolve(),source,ROOT/'src/data/cards.json',FILES/'Databases/CCG_v1.db',OUT/'candidate-CCG_v1.db']+[ROOT/'scripts'/n for n in ['fresh_current_aldrez_battery_atk.cjs','fresh_current_recollection_iron_activation.cjs','fresh_installed_card.cjs','fresh_corrected_card_data_transport.cjs']]+[ROOT/'tmp/omega_scripts'/n for n in ['constant.lua','utility.lua','procedure.lua']]+list((ROOT/'node_modules/@n1xx1/ocgcore-wasm/dist').glob('*.js'))+[ROOT/'node_modules/@n1xx1/ocgcore-wasm/dist/index-card-data-transport-candidate.mjs']
deps={str(p.resolve()):sha(p) for p in paths};runs=[]
for flag,expected in [(None,[]),('no-zero',[0,1,2,3,5,7,10]),('no-gain',[0,10]),('no-response',[6,7,8,9]),('short-duration',[10]),('no-reset',[10])]:
 r=subprocess.run(['node','--no-warnings','scripts/fresh_current_aldrez_battery_atk.cjs']+(['--'+flag] if flag else []),capture_output=True,text=True,timeout=20);p=OUT/('current-aldrez-battery-atk'+('-'+flag if flag else '')+'.json');d=json.loads(p.read_text());assert len(d['results'])==12 and [i for i,v in enumerate(d['results']) if v['failure']]==expected and all(not v['logs'] and v['trace'] for v in d['results']) and r.returncode==bool(expected),r.stdout+r.stderr
 runs.append({'artifact':p.name,'sha256':sha(p),'expected_failures':expected})
assert deps=={str(p.resolve()):sha(p) for p in paths}
(OUT/'current-aldrez-battery-atk-batch.json').write_text(json.dumps({'status':'ALDREZ_BATTERY_ATK_VERIFIED','runtime_dependencies_sha256':deps,'runs':runs,'scope':'Full source/current installed metadata/corrected transport/no Lua API adapter. Actual GY banish cost, opponent ATK0 and optional lost ATK gain; decline/no ally/wrong set/facedown/zero ATK boundaries. Effective zero/gain controls. Actual CL2 target/ally banishment or activation/effect negation and no late transfer, effective no-response control. Search/restriction separately verified; Native next own turn retains both ATK changes; actual GY/resummon resets both; immune target prevents reduction/gain. Effective short-duration/no-reset controls; full-card/live Omega open.','production_change':False},indent=2)+'\n')
print('Aldrez Battery ATK verified with effective controls')

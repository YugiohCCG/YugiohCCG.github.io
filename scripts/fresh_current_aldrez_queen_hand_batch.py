import hashlib,json,subprocess
from pathlib import Path
ROOT=Path.cwd();OUT=ROOT/'output/fresh-ccg-september';FILES=Path(r'C:\Program Files (x86)\YGO Omega\YGO Omega_Data\Files')
def sha(p):return hashlib.sha256(p.read_bytes()).hexdigest()
source=ROOT/'public/CCG Downloads/CCG_Scripts/c231892575.lua';assert source.read_bytes()==(FILES/'Scripts'/source.name).read_bytes()
paths=[Path(__file__).resolve(),source,ROOT/'src/data/cards.json',FILES/'Databases/CCG_v1.db',OUT/'candidate-CCG_v1.db']+[ROOT/'scripts'/n for n in ['fresh_current_aldrez_queen_hand.cjs','fresh_current_recollection_iron_activation.cjs','fresh_installed_card.cjs','fresh_corrected_card_data_transport.cjs']]+[ROOT/'tmp/omega_scripts'/n for n in ['constant.lua','utility.lua','procedure.lua']]+list((ROOT/'node_modules/@n1xx1/ocgcore-wasm/dist').glob('*.js'))+[ROOT/'node_modules/@n1xx1/ocgcore-wasm/dist/index-card-data-transport-candidate.mjs']
deps={str(p.resolve()):sha(p) for p in paths};runs=[]
for flag,expected in [(None,[]),('no-summon',[0,4,7,8,9,10]),('no-response',[1,2,3,4,5,6,8,9]),('no-relation',[3]),('per-copy',[7,8,9]),('shared-key',[10]),('recheck-condition',[4])]:
 r=subprocess.run(['node','--no-warnings','scripts/fresh_current_aldrez_queen_hand.cjs']+(['--'+flag] if flag else []),capture_output=True,text=True,timeout=20);p=OUT/('current-aldrez-queen-hand'+('-'+flag if flag else '')+'.json');d=json.loads(p.read_text());assert len(d['results'])==11 and [i for i,v in enumerate(d['results']) if v['failure']]==expected and all(not v['logs'] and v['trace'] for v in d['results']) and r.returncode==bool(expected),r.stdout+r.stderr
 runs.append({'artifact':p.name,'sha256':sha(p),'expected_failures':expected})
assert deps=={str(p.resolve()):sha(p) for p in paths}
(OUT/'current-aldrez-queen-hand-batch.json').write_text(json.dumps({'status':'ALDREZ_QUEEN_HAND_VERIFIED','runtime_dependencies_sha256':deps,'runs':runs,'scope':'Full Queen/current installed metadata/corrected transport/no Lua API adapter. Actual Hand ignition; CL2 effect/activation negation, source banish, late full/summon lock prevent summon. Support banishment after activation permits independent summon. Shared Hand copies consumed after success/either negation; natural later summon/reset and actual independent search. Effective controls. Protection state changes/full-card/live Omega separate.','production_change':False},indent=2)+'\n')
print('Queen Hand effect verified with effective controls')

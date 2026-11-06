import hashlib,json,subprocess
from pathlib import Path
ROOT=Path.cwd();OUT=ROOT/'output/fresh-ccg-september';FILES=Path(r'C:\Program Files (x86)\YGO Omega\YGO Omega_Data\Files')
def sha(p):return hashlib.sha256(p.read_bytes()).hexdigest()
source=ROOT/'public/CCG Downloads/CCG_Scripts/c231892575.lua';assert source.read_bytes()==(FILES/'Scripts'/source.name).read_bytes()
paths=[Path(__file__).resolve(),source,ROOT/'src/data/cards.json',FILES/'Databases/CCG_v1.db',OUT/'candidate-CCG_v1.db']+[ROOT/'scripts'/n for n in ['fresh_current_aldrez_queen_search.cjs','fresh_current_recollection_static_search.cjs','fresh_installed_card.cjs','fresh_corrected_card_data_transport.cjs']]+[ROOT/'tmp/omega_scripts'/n for n in ['constant.lua','utility.lua','procedure.lua']]+list((ROOT/'node_modules/@n1xx1/ocgcore-wasm/dist').glob('*.js'))+[ROOT/'node_modules/@n1xx1/ocgcore-wasm/dist/index-card-data-transport-candidate.mjs']
deps={str(p.resolve()):sha(p) for p in paths};runs=[]
for flag,expected in [(None,[]),('no-search',[0,1,2,6,10,11,12]),('allow-any',[0,1,2,3,4,5,6,7,10,11,12]),('no-response',[6,7,8,9,11,12]),('per-copy',[10,11,12])]:
 r=subprocess.run(['node','--no-warnings','scripts/fresh_current_aldrez_queen_search.cjs']+(['--'+flag] if flag else []),capture_output=True,text=True,timeout=20);p=OUT/('current-aldrez-queen-search'+('-'+flag if flag else '')+'.json');d=json.loads(p.read_text());assert len(d['results'])==13 and [i for i,v in enumerate(d['results']) if v['failure']]==expected and all(not v['logs'] and v['trace'] for v in d['results']) and r.returncode==bool(expected),r.stdout+r.stderr
 runs.append({'artifact':p.name,'sha256':sha(p),'expected_failures':expected})
assert deps=={str(p.resolve()):sha(p) for p in paths}
(OUT/'current-aldrez-queen-search-batch.json').write_text(json.dumps({'status':'ALDREZ_QUEEN_SEARCH_VERIFIED','runtime_dependencies_sha256':deps,'runs':runs,'scope':'Full Queen/current installed metadata/corrected transport/no Lua API adapter. Actual Deck Monster/Spell/Trap search, self-name/wrong set/absent resource excluded. Actual CL2 source banishment preserves independent search; resource banishment/negations prevent it. Effective controls. Two field copies share use after success/either negation, actual different-copy search after natural reset; effective per-copy control. Initial field source/full-card/live Omega separate.','production_change':False},indent=2)+'\n')
print('Queen search verified with effective controls')

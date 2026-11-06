import hashlib,json,subprocess
from pathlib import Path
ROOT=Path.cwd();OUT=ROOT/'output/fresh-ccg-september';FILES=Path(r'C:\Program Files (x86)\YGO Omega\YGO Omega_Data\Files')
def sha(p):return hashlib.sha256(p.read_bytes()).hexdigest()
source=ROOT/'public/CCG Downloads/CCG_Scripts/c228926678.lua';assert source.read_bytes()==(FILES/'Scripts'/source.name).read_bytes()
paths=[Path(__file__).resolve(),source,ROOT/'src/data/cards.json',FILES/'Databases/CCG_v1.db',OUT/'candidate-CCG_v1.db']+[ROOT/'scripts'/n for n in ['fresh_current_aldrez_bishop_search.cjs','fresh_current_recollection_static_search.cjs','fresh_installed_card.cjs','fresh_corrected_card_data_transport.cjs']]+[ROOT/'tmp/omega_scripts'/n for n in ['constant.lua','utility.lua','procedure.lua']]+list((ROOT/'node_modules/@n1xx1/ocgcore-wasm/dist').glob('*.js'))+[ROOT/'node_modules/@n1xx1/ocgcore-wasm/dist/index-card-data-transport-candidate.mjs']
deps={str(p.resolve()):sha(p) for p in paths};runs=[]
for flag,expected in [(None,[]),('no-search',[0,1,2,3,8,10,11,12]),('allow-any',[0,1,2,3,4,5,6,8,9,10,11,12]),('no-response',[8,9,11,12]),('per-copy',[10,11,12])]:
 r=subprocess.run(['node','--no-warnings','scripts/fresh_current_aldrez_bishop_search.cjs']+(['--'+flag] if flag else []),capture_output=True,text=True,timeout=20);p=OUT/('current-aldrez-bishop-search'+('-'+flag if flag else '')+'.json');d=json.loads(p.read_text());assert len(d['results'])==13 and [i for i,v in enumerate(d['results']) if v['failure']]==expected and all(not v['logs'] and v['trace'] for v in d['results']) and r.returncode==bool(expected),r.stdout+r.stderr
 runs.append({'artifact':p.name,'sha256':sha(p),'expected_failures':expected})
assert deps=={str(p.resolve()):sha(p) for p in paths}
(OUT/'current-aldrez-bishop-search-batch.json').write_text(json.dumps({'status':'ALDREZ_BISHOP_SEARCH_VERIFIED','runtime_dependencies_sha256':deps,'runs':runs,'scope':'Full Bishop/current installed metadata/corrected transport/no Lua API adapter. Actual Normal/Special Summon Deck Spell/GY Trap search, wrong set/type/absent resource and decline. CL2 source banishment preserves independent search, resource banishment prevents search. Effective no-search/allow-any/no-response controls. Three actual copies Normal/Special share search use after success/effect or activation negation; fresh third copy actually searches on natural later turn. Effective per-copy control; protection/GY revival separately tested, full-card/live Omega open.','production_change':False},indent=2)+'\n')
print('Bishop search verified with effective controls')

import hashlib,json,subprocess
from pathlib import Path
ROOT=Path.cwd();OUT=ROOT/'output/fresh-ccg-september';FILES=Path(r'C:\Program Files (x86)\YGO Omega\YGO Omega_Data\Files')
def sha(p):return hashlib.sha256(p.read_bytes()).hexdigest()
source=ROOT/'public/CCG Downloads/CCG_Scripts/c233759343.lua';assert source.read_bytes()==(FILES/'Scripts'/source.name).read_bytes()
paths=[Path(__file__).resolve(),source,ROOT/'src/data/cards.json',FILES/'Databases/CCG_v1.db',OUT/'candidate-CCG_v1.db']+[ROOT/'scripts'/n for n in ['fresh_current_aldrez_battery_search.cjs','fresh_current_recollection_iron_activation.cjs','fresh_installed_card.cjs','fresh_corrected_card_data_transport.cjs']]+[ROOT/'tmp/omega_scripts'/n for n in ['constant.lua','utility.lua','procedure.lua']]+list((ROOT/'node_modules/@n1xx1/ocgcore-wasm/dist').glob('*.js'))+[ROOT/'node_modules/@n1xx1/ocgcore-wasm/dist/index-card-data-transport-candidate.mjs']
deps={str(p.resolve()):sha(p) for p in paths};runs=[]
for flag,expected in [(None,[]),('no-search',[0,6]),('no-lock',[0,1,6]),('no-expiry',[0,1]),('no-response',[1,2,3]),('no-limit',[2,6])]:
 r=subprocess.run(['node','--no-warnings','scripts/fresh_current_aldrez_battery_search.cjs']+(['--'+flag] if flag else []),capture_output=True,text=True,timeout=20);p=OUT/('current-aldrez-battery-search'+('-'+flag if flag else '')+'.json');d=json.loads(p.read_text());assert len(d['results'])==7 and [i for i,v in enumerate(d['results']) if v['failure']]==expected and all(not v['logs'] and v['trace'] for v in d['results']) and r.returncode==bool(expected),r.stdout+r.stderr
 runs.append({'artifact':p.name,'sha256':sha(p),'expected_failures':expected})
for modern in [False,True]:
 args=['--check-retry']+(['--modern-count'] if modern else [])
 r=subprocess.run(['node','--no-warnings','scripts/fresh_current_aldrez_battery_search.cjs']+args,capture_output=True,text=True,timeout=20)
 p=OUT/('current-aldrez-battery-search-retry'+('-modern-count' if modern else '')+'.json');d=json.loads(p.read_text());expected=[] if modern else [3]
 assert [i for i,v in enumerate(d['results']) if v['failure']]==expected and all(not v['logs'] for v in d['results']) and r.returncode==bool(expected),r.stdout+r.stderr
 runs.append({'artifact':p.name,'sha256':sha(p),'expected_failures':expected,'diagnostic_only':True,'modern_count_adapter':modern})
assert deps=={str(p.resolve()):sha(p) for p in paths}
(OUT/'current-aldrez-battery-search-batch.json').write_text(json.dumps({'status':'ALDREZ_BATTERY_SEARCH_RESTRICTION_VERIFIED','runtime_dependencies_sha256':deps,'runs':runs,'scope':'Full source/current installed metadata/corrected transport/no Lua API adapter. Actual search and native battle menu on natural turns3/5, Aldrez exemption and restriction expiry. Actual CL2 sole resource removal/effect negation/activation negation, wrong set/type boundaries; effective controls. Search restriction remains when resource removed, absent if effect or activation negated. Effect-negated copy exclusion verified; activation retry fails under legacy OATH/public engine and passes only explicit test modern-count mapping, retained diagnostic. Actual second-copy search on next own turn proves named limit reset; GY interruptions separately verified; full-card/live Omega separate.','production_change':False},indent=2)+'\n')
print('Aldrez Battery search/restriction verified with effective controls')

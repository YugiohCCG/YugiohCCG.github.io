import hashlib,json,subprocess
from pathlib import Path
ROOT=Path.cwd();OUT=ROOT/'output/fresh-ccg-september';FILES=Path(r'C:\Program Files (x86)\YGO Omega\YGO Omega_Data\Files')
def sha(p):return hashlib.sha256(p.read_bytes()).hexdigest()
source=ROOT/'public/CCG Downloads/CCG_Scripts/c252210718.lua';assert source.read_bytes()==(FILES/'Scripts'/source.name).read_bytes()
paths=[Path(__file__).resolve(),source,ROOT/'src/data/cards.json',FILES/'Databases/CCG_v1.db',OUT/'candidate-CCG_v1.db',OUT/'current-king-detach-activation-rule-review.json']+[ROOT/'scripts'/n for n in ['fresh_current_aldrez_king_detach_resource.cjs','fresh_current_aldrez_blitz_xyz_set.cjs','fresh_installed_card.cjs','fresh_corrected_card_data_transport.cjs']]+[ROOT/'tmp/omega_scripts'/n for n in ['constant.lua','utility.lua','procedure.lua']]+list((ROOT/'node_modules/@n1xx1/ocgcore-wasm/dist').glob('*.js'))+[ROOT/'node_modules/@n1xx1/ocgcore-wasm/dist/index-card-data-transport-candidate.mjs']
deps={str(p.resolve()):sha(p) for p in paths};runs=[]
for flag,expected in [(None,[]),('prospective',[0,3]),('no-summon',[1,2,4,5])]:
 r=subprocess.run(['node','--no-warnings','scripts/fresh_current_aldrez_king_detach_resource.cjs']+(['--'+flag] if flag else []),capture_output=True,text=True,timeout=20);p=OUT/('current-aldrez-king-detach-resource'+('-'+flag if flag else '')+'.json');d=json.loads(p.read_text());assert len(d['results'])==6 and [i for i,v in enumerate(d['results']) if v['failure']]==expected and all(not v['logs'] and v['trace'] for v in d['results']) and r.returncode==bool(expected),r.stdout+r.stderr
 runs.append({'artifact':p.name,'sha256':sha(p),'expected_failures':expected})
assert deps=={str(p.resolve()):sha(p) for p in paths}
(OUT/'current-aldrez-king-detach-resource-batch.json').write_text(json.dumps({'status':'ALDREZ_KING_DETACH_ACTIVATION_SELECTION_VERIFIED','runtime_dependencies_sha256':deps,'runs':runs,'scope':'Full original King effects/current installed metadata/corrected transport/no Lua API adapter. Paid fixed native two-Level4-Aldrez source Xyz/proper status/materials, existing Hand/GY activation and actual summon, empty-resource/prohibited negatives. Actual detached material may be selected after another resource permits activation. Konami Emeral11724 primary analogy, rejected prospective candidate recorded separately. General original recipe/other effects/full-card/live Omega separate.','production_change':False},indent=2)+'\n')
print('King activation/post-cost selection verified; prospective candidate rejected')

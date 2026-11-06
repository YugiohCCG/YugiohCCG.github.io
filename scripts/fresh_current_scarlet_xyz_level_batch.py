import hashlib,json,subprocess
from pathlib import Path
ROOT=Path.cwd();OUT=ROOT/'output/fresh-ccg-september';FILES=Path(r'C:\Program Files (x86)\YGO Omega\YGO Omega_Data\Files')
def sha(p):return hashlib.sha256(p.read_bytes()).hexdigest()
source=ROOT/'public/CCG Downloads/CCG_Scripts/c220749574.lua';assert source.read_bytes()==(FILES/'Scripts'/source.name).read_bytes()
paths=[Path(__file__).resolve(),source,ROOT/'src/data/cards.json',FILES/'Databases/CCG_v1.db',OUT/'candidate-CCG_v1.db']+[ROOT/'scripts'/n for n in ['fresh_current_scarlet_xyz_level.cjs','fresh_current_aldrez_knight_xyz_level.cjs','fresh_current_aldrez_blitz_xyz_set.cjs','fresh_installed_card.cjs','fresh_corrected_card_data_transport.cjs']]+[ROOT/'tmp/omega_scripts'/n for n in ['constant.lua','utility.lua','procedure.lua']]+list((ROOT/'node_modules/@n1xx1/ocgcore-wasm/dist').glob('*.js'))+[ROOT/'node_modules/@n1xx1/ocgcore-wasm/dist/index-card-data-transport-candidate.mjs']
deps={str(p.resolve()):sha(p) for p in paths};runs=[]
for flag,expected in [(None,[]),('no-level',[0]),('all-ranks',[1])]:
 r=subprocess.run(['node','--no-warnings','scripts/fresh_current_scarlet_xyz_level.cjs']+(['--'+flag] if flag else []),capture_output=True,text=True,timeout=20);p=OUT/('current-scarlet-xyz-level'+('-'+flag if flag else '')+'.json');d=json.loads(p.read_text());assert len(d['results'])==6 and [i for i,v in enumerate(d['results']) if v['failure']]==expected and all(not v['logs'] and v['trace'] for v in d['results']) and r.returncode==bool(expected),r.stdout+r.stderr
 runs.append({'artifact':p.name,'sha256':sha(p),'expected_failures':expected})
assert deps=={str(p.resolve()):sha(p) for p in paths}
(OUT/'current-scarlet-xyz-level-batch.json').write_text(json.dumps({'status':'SCARLET_XYZ_LEVEL_VERIFIED','runtime_dependencies_sha256':deps,'runs':runs,'scope':'Full Scarlet/current installed metadata/corrected transport/no Lua API adapter. Native IsCanBeXyzMaterial/IsXyzLevel in paid neutral fixed recipe; Aqua Rank1 treatment, non-Aqua/disabled negatives; natural Level7 preserved for Aqua/non-Aqua/disabled. Actual two-card Overlay; effective omitted-level/ignored-race controls. Initially field source, original Hand history, named/general recipient recipes/full-card/live Omega remain separate.','production_change':False},indent=2)+'\n')
print('Scarlet Xyz-level interaction verified with effective controls')

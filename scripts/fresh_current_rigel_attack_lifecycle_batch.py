import hashlib,json,subprocess
from pathlib import Path
ROOT=Path.cwd();OUT=ROOT/'output/fresh-ccg-september';FILES=Path(r'C:\Program Files (x86)\YGO Omega\YGO Omega_Data\Files')
def sha(p):return hashlib.sha256(p.read_bytes()).hexdigest()
source=ROOT/'public/CCG Downloads/CCG_Scripts/c215853847.lua';assert source.read_bytes()==(FILES/'Scripts'/source.name).read_bytes()
paths=[Path(__file__).resolve(),source,ROOT/'src/data/cards.json',FILES/'Databases/CCG_v1.db',OUT/'candidate-CCG_v1.db']+[ROOT/'scripts'/n for n in ['fresh_current_rigel_attack_lifecycle.cjs','fresh_current_rigel_material_atk.cjs','fresh_installed_card.cjs','fresh_corrected_card_data_transport.cjs']]+[ROOT/'tmp/omega_scripts'/n for n in ['constant.lua','utility.lua','procedure.lua']]+list((ROOT/'node_modules/@n1xx1/ocgcore-wasm/dist').glob('*.js'))+[ROOT/'node_modules/@n1xx1/ocgcore-wasm/dist/index-card-data-transport-candidate.mjs']
deps={str(p.resolve()):sha(p) for p in paths};runs=[]
for flag,expected in [(None,[]),('per-copy',[1]),('no-attack-all',[0]),('no-atk-expiry',[0]),('no-all-expiry',[0]),('no-other-lock',[0,1]),('source-dependent-lock',[1])]:
 r=subprocess.run(['node','--no-warnings','scripts/fresh_current_rigel_attack_lifecycle.cjs']+(['--'+flag] if flag else []),capture_output=True,text=True,timeout=20);p=OUT/('current-rigel-attack-lifecycle'+('-'+flag if flag else '')+'.json');d=json.loads(p.read_text());assert len(d['results'])==2 and [i for i,v in enumerate(d['results']) if v['failure']]==expected and all(not v['logs'] and v['trace'] for v in d['results']) and r.returncode==bool(expected),r.stdout+r.stderr
 runs.append({'artifact':p.name,'sha256':sha(p),'expected_failures':expected})
assert deps=={str(p.resolve()):sha(p) for p in paths}
(OUT/'current-rigel-attack-lifecycle-batch.json').write_text(json.dumps({'status':'RIGEL_ATTACK_LIFECYCLE_VERIFIED','runtime_dependencies_sha256':deps,'runs':runs,'scope':'Full Rigel/current installed metadata/corrected transport/no Lua API adapter. Paid fixed native Link procedures, genuine Link2 materials and proper second-copy history. Actual multiple attacks, ATK/attack-all expiry, named other-copy exclusion and natural reset reuse, independent other-monster attack restriction persists after original source leaves. Effective controls. Original general Link helper/full-card/live Omega remain separate.','production_change':False},indent=2)+'\n')
print('Rigel attack lifecycle verified with effective controls')

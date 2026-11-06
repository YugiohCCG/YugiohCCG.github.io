import hashlib,json,subprocess
from pathlib import Path
ROOT=Path.cwd();OUT=ROOT/'output/fresh-ccg-september';FILES=Path(r'C:\Program Files (x86)\YGO Omega\YGO Omega_Data\Files')
def sha(p):return hashlib.sha256(p.read_bytes()).hexdigest()
source=ROOT/'public/CCG Downloads/CCG_Scripts/c259093260.lua';assert source.read_bytes()==(FILES/'Scripts'/source.name).read_bytes()
paths=[Path(__file__).resolve(),source,ROOT/'src/data/cards.json',FILES/'Databases/CCG_v1.db',OUT/'candidate-CCG_v1.db',OUT/'matriarch-damage-step-repair-files.json']+[ROOT/'scripts'/n for n in ['fresh_current_matriarch_battle_revival.cjs','fresh_current_terrarumian_ivy_participants.cjs','fresh_matriarch_damage_step_repair.cjs','fresh_installed_card.cjs','fresh_corrected_card_data_transport.cjs']]+[ROOT/'tmp/omega_scripts'/n for n in ['constant.lua','utility.lua','procedure.lua']]+list((ROOT/'node_modules/@n1xx1/ocgcore-wasm/dist').glob('*.js'))+[ROOT/'node_modules/@n1xx1/ocgcore-wasm/dist/index-card-data-transport-candidate.mjs']
deps={str(p.resolve()):sha(p) for p in paths};runs=[]
for flag,expected in [(None,[]),('old-source',[0]),('no-revive',[0])]:
 r=subprocess.run(['node','--no-warnings','scripts/fresh_current_matriarch_battle_revival.cjs']+(['--'+flag] if flag else []),capture_output=True,text=True,timeout=20);p=OUT/('current-matriarch-battle-revival'+('-'+flag if flag else '')+'.json');d=json.loads(p.read_text());assert len(d['results'])==4 and [i for i,v in enumerate(d['results']) if v['failure']]==expected and all(not v['logs'] and v['trace'] for v in d['results']) and r.returncode==bool(expected),r.stdout+r.stderr
 runs.append({'artifact':p.name,'sha256':sha(p),'expected_failures':expected})
assert deps=={str(p.resolve()):sha(p) for p in paths}
(OUT/'current-matriarch-battle-revival-batch.json').write_text(json.dumps({'status':'MATRIARCH_DAMAGE_STEP_REPAIRED','runtime_dependencies_sha256':deps,'runs':runs,'scope':'Full Matriarch/current installed metadata/corrected transport/no Lua API adapter. Actual opponent-turn WATER battle-to-GY then Defense revival; own turn/wrong Attribute/opponent-owned borrowed WATER negatives. Actual neutral Spell control change establishes borrowed ownership, no seeded borrowed controller assumption. Exact original flag/no-revive failures. Initially field source/general Synchro recipe/proper source history/other effects/full-card/live Omega separate.','production_change':True},indent=2)+'\n')
print('Matriarch Damage Step revival repair verified')

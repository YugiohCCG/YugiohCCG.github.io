import hashlib,json,subprocess
from pathlib import Path
ROOT=Path.cwd();OUT=ROOT/'output/fresh-ccg-september';FILES=Path(r'C:\Program Files (x86)\YGO Omega\YGO Omega_Data\Files')
def sha(p):return hashlib.sha256(p.read_bytes()).hexdigest()
source=ROOT/'public/CCG Downloads/CCG_Scripts/c259265448.lua';assert source.read_bytes()==(FILES/'Scripts'/source.name).read_bytes()
paths=[Path(__file__).resolve(),source,ROOT/'src/data/cards.json',FILES/'Databases/CCG_v1.db',OUT/'candidate-CCG_v1.db',OUT/'underworld-damage-step-repair-files.json']+[ROOT/'scripts'/n for n in ['fresh_current_underworld_damage_step.cjs','fresh_current_terrarumian_ivy_participants.cjs','fresh_underworld_damage_step_repair.cjs','fresh_installed_card.cjs','fresh_corrected_card_data_transport.cjs']]+[ROOT/'tmp/omega_scripts'/n for n in ['constant.lua','utility.lua','procedure.lua']]+list((ROOT/'node_modules/@n1xx1/ocgcore-wasm/dist').glob('*.js'))+[ROOT/'node_modules/@n1xx1/ocgcore-wasm/dist/index-card-data-transport-candidate.mjs']
deps={str(p.resolve()):sha(p) for p in paths};runs=[]
for flag,expected in [(None,[]),('old-source',[0,1]),('no-search',[0,1])]:
 r=subprocess.run(['node','--no-warnings','scripts/fresh_current_underworld_damage_step.cjs']+(['--'+flag] if flag else []),capture_output=True,text=True,timeout=20);p=OUT/('current-underworld-damage-step'+('-'+flag if flag else '')+'.json');d=json.loads(p.read_text());assert len(d['results'])==5 and [i for i,v in enumerate(d['results']) if v['failure']]==expected and all(not v['logs'] and v['trace'] for v in d['results']) and r.returncode==bool(expected),r.stdout+r.stderr
 runs.append({'artifact':p.name,'sha256':sha(p),'expected_failures':expected})
assert deps=={str(p.resolve()):sha(p) for p in paths}
(OUT/'current-underworld-damage-step-batch.json').write_text(json.dumps({'status':'UNDERWORLD_DAMAGE_STEP_REPAIRED','runtime_dependencies_sha256':deps,'runs':runs,'scope':'Full Domestic Underworld/current installed metadata/corrected transport/no Lua API adapter. Actual Field Spell activation, legal battle Flip effect sends Hand Level1 Beast/Winged Beast to GY during Damage Step, actual shuffle/different-name search. Wrong Level/race/field-origin negatives; original flag/no-search failures. Other effects/limits/full-card/live Omega separate.','production_change':True},indent=2)+'\n')
print('Underworld Damage Step shuffle/search repair verified')

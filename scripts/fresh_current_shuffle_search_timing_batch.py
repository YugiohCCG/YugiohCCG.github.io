import hashlib,json,subprocess
from pathlib import Path
ROOT=Path.cwd();OUT=ROOT/'output/fresh-ccg-september';FILES=Path(r'C:\Program Files (x86)\YGO Omega\YGO Omega_Data\Files')
def sha(p):return hashlib.sha256(p.read_bytes()).hexdigest()
paths=[Path(__file__).resolve(),ROOT/'src/data/cards.json',FILES/'Databases/CCG_v1.db',OUT/'candidate-CCG_v1.db',OUT/'shuffle-search-timing-repair-files.json',OUT/'current-underworld-then-rule-review.json']
paths += [ROOT/'scripts'/n for n in ['fresh_current_underworld_search_timing.cjs','fresh_current_underworld_search_branches.cjs','fresh_current_underworld_damage_step.cjs','fresh_current_terrarumian_ivy_participants.cjs','fresh_current_scarlet_search_timing.cjs','fresh_current_altergeist_regissae_negate.cjs','fresh_shuffle_search_timing_repair.cjs','fresh_installed_card.cjs','fresh_corrected_card_data_transport.cjs']]
paths += [ROOT/'tmp/omega_scripts'/n for n in ['constant.lua','utility.lua','procedure.lua']]+list((ROOT/'node_modules/@n1xx1/ocgcore-wasm/dist').glob('*.js'))+[ROOT/'node_modules/@n1xx1/ocgcore-wasm/dist/index-card-data-transport-candidate.mjs']
for code in [259265448,220749574]:
 p=ROOT/'public/CCG Downloads/CCG_Scripts'/f'c{code}.lua';assert p.read_bytes()==(FILES/'Scripts'/p.name).read_bytes();paths += [p,OUT/'shuffle-search-before-timing-repair'/p.name]
deps={str(p.resolve()):sha(p) for p in paths};runs=[]
for code,prefix,count in [(259265448,'underworld',2),(220749574,'scarlet',1)]:
 for flag,expected in [(None,[]),('old-source',[0]),('listener-delay',[])]:
  r=subprocess.run(['node','--no-warnings',f'scripts/fresh_current_{prefix}_search_timing.cjs']+(['--'+flag] if flag else []),capture_output=True,text=True,timeout=20)
  p=OUT/(f'current-{prefix}-search-timing'+('-'+flag if flag else '')+'.json');d=json.loads(p.read_text());assert len(d['results'])==count and [i for i,x in enumerate(d['results']) if x['failure']]==expected and all(not x['logs'] and x['trace'] for x in d['results']) and r.returncode==bool(expected),r.stdout+r.stderr
  runs.append({'passcode':code,'artifact':p.name,'sha256':sha(p),'cases':count,'expected_failures':expected})
assert deps=={str(p.resolve()):sha(p) for p in paths}
(OUT/'current-shuffle-search-timing-batch.json').write_text(json.dumps({'status':'SHUFFLE_SEARCH_TIMING_REPAIRED','runtime_dependencies_sha256':deps,'runs':runs,'scope':'Full current effects/installed metadata/corrected transport/no Lua API adapter. Actual Underworld natural battle Flip Hand event and Scarlet Hand ignition/discard, shuffle then search. Native optional-when TO_DECK listener misses timing after search; delayed listener still offered. Underworld actual CL2 removes only search resource: shuffle-only optional listener remains offered. Exact pre-repair timing failures. Primary then-rule reference retained; narrow711 source scan also found four also-conjunction effects, correctly simultaneous. Original summon/full-card/live Omega remain qualified.','production_change':True},indent=2)+'\n')
print('Underworld/Scarlet sequential shuffle/search timing verified')

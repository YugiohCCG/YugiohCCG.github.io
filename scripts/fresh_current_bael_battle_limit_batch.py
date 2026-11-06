import hashlib,json,subprocess
from pathlib import Path
ROOT=Path.cwd();OUT=ROOT/'output/fresh-ccg-september';FILES=Path(r'C:\Program Files (x86)\YGO Omega\YGO Omega_Data\Files')
def sha(p):return hashlib.sha256(p.read_bytes()).hexdigest()
source=ROOT/'public/CCG Downloads/CCG_Scripts/c228169392.lua';assert source.read_bytes()==(FILES/'Scripts'/source.name).read_bytes()
paths=[Path(__file__).resolve(),source,ROOT/'src/data/cards.json',FILES/'Databases/CCG_v1.db',OUT/'candidate-CCG_v1.db',OUT/'current-king-detach-activation-rule-review.json',OUT/'phase-limit-repair-review/manifest.json']+[ROOT/'scripts'/n for n in ['fresh_current_bael_battle_limit.cjs','fresh_current_aldrez_king_detach_resource.cjs','fresh_current_aldrez_blitz_xyz_set.cjs','fresh_installed_card.cjs','fresh_corrected_card_data_transport.cjs']]+[ROOT/'tmp/omega_scripts'/n for n in ['constant.lua','utility.lua','procedure.lua']]+list((ROOT/'node_modules/@n1xx1/ocgcore-wasm/dist').glob('*.js'))+[ROOT/'node_modules/@n1xx1/ocgcore-wasm/dist/index-card-data-transport-candidate.mjs']
deps={str(p.resolve()):sha(p) for p in paths};runs=[]
for flag,expected in [(None,[]),('old-source',[0,1])]:
 r=subprocess.run(['node','--no-warnings','scripts/fresh_current_bael_battle_limit.cjs']+(['--'+flag] if flag else []),capture_output=True,text=True,timeout=20);p=OUT/('current-bael-battle-limit'+('-'+flag if flag else '')+'.json');d=json.loads(p.read_text());assert len(d['results'])==2 and [i for i,v in enumerate(d['results']) if v['failure']]==expected and all(not v['logs'] and v['trace'] for v in d['results']) and r.returncode==bool(expected),r.stdout+r.stderr
 runs.append({'artifact':p.name,'sha256':sha(p),'expected_failures':expected})
assert deps=={str(p.resolve()):sha(p) for p in paths}
(OUT/'current-bael-battle-limit-batch.json').write_text(json.dumps({'status':'BAEL_BATTLE_PHASE_LIMIT_REPAIRED','runtime_dependencies_sha256':deps,'runs':runs,'scope':'Full current Bael/installed metadata/corrected transport/no Lua API adapter. Paid fixed three-Level1-Tuner Xyz with actual native Overlay history, natural opponent Battle start. Original source pays/activates three times despite printed once per Battle Phase. Test-only cost flag prevents repeated use and resets at Battle end; two native Battle starts on natural turn2 each permit one actual cost/activation. Exact approved source/install repair applied; old-source control fails both scenarios. Full-card/live Omega remain open.','production_change':True},indent=2)+'\n')
print('Bael Battle-phase limit repair verified')

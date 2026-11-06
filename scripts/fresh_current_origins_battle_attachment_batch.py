import hashlib,json,subprocess
from pathlib import Path
ROOT=Path.cwd();OUT=ROOT/'output/fresh-ccg-september';FILES=Path(r'C:\Program Files (x86)\YGO Omega\YGO Omega_Data\Files')
def sha(p):return hashlib.sha256(p.read_bytes()).hexdigest()
source=ROOT/'public/CCG Downloads/CCG_Scripts/c244986323.lua';assert source.read_bytes()==(FILES/'Scripts'/source.name).read_bytes()
paths=[Path(__file__).resolve(),source,ROOT/'src/data/cards.json',FILES/'Databases/CCG_v1.db',OUT/'candidate-CCG_v1.db',OUT/'origins-damage-step-repair-files.json']+[ROOT/'scripts'/n for n in ['fresh_current_origins_battle_attachment.cjs','fresh_current_terrarumian_ivy_participants.cjs','fresh_origins_damage_step_repair.cjs','fresh_installed_card.cjs','fresh_corrected_card_data_transport.cjs']]+[ROOT/'tmp/omega_scripts'/n for n in ['constant.lua','utility.lua','procedure.lua']]+list((ROOT/'node_modules/@n1xx1/ocgcore-wasm/dist').glob('*.js'))+[ROOT/'node_modules/@n1xx1/ocgcore-wasm/dist/index-card-data-transport-candidate.mjs']
deps={str(p.resolve()):sha(p) for p in paths};runs=[]
for mapped,flag,expected in [(False,None,[0]),(True,None,[]),(True,'old-source',[0]),(True,'no-attach',[0])]:
 r=subprocess.run(['node','--no-warnings','scripts/fresh_current_origins_battle_attachment.cjs']+(['--overlay-map'] if mapped else [])+(['--'+flag] if flag else []),capture_output=True,text=True,timeout=20);p=OUT/('current-origins-battle-attachment'+('-overlay-map' if mapped else '')+('-'+flag if flag else '')+'.json');d=json.loads(p.read_text());assert len(d['results'])==2 and [i for i,v in enumerate(d['results']) if v['failure']]==expected and r.returncode==bool(expected),r.stdout+r.stderr
 if mapped:assert all(not v['logs'] for v in d['results'])
 else:assert 'IsCanOverlay' in d['results'][0]['failure'] and d['results'][0]['logs'] and not d['results'][1]['logs']
 runs.append({'artifact':p.name,'sha256':sha(p),'expected_failures':expected,'known_compatibility_failure':not mapped})
assert deps=={str(p.resolve()):sha(p) for p in paths}
(OUT/'current-origins-battle-attachment-batch.json').write_text(json.dumps({'status':'ORIGINS_DAMAGE_STEP_REPAIRED','runtime_dependencies_sha256':deps,'runs':runs,'scope':'Full Origins/current installed metadata/corrected transport. Missing FIELD TO_GRAVE Damage Step permission repaired: native opponent battle victim to GY then actual remaining faceup opposing S/T Overlay. Own victim negative, exact original flag/no-attach failures. Explicit neutral field-only missing IsCanOverlay mapping, unadapted failure separate. Initial field source/general recipe/proper history/full-card/live Omega remain separate.','production_change':True},indent=2)+'\n')
print('Origins Damage Step attachment repair verified')

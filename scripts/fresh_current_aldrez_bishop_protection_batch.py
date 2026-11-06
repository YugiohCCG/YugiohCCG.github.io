import hashlib,json,subprocess
from pathlib import Path
ROOT=Path.cwd();OUT=ROOT/'output/fresh-ccg-september';FILES=Path(r'C:\Program Files (x86)\YGO Omega\YGO Omega_Data\Files')
def sha(p):return hashlib.sha256(p.read_bytes()).hexdigest()
source=ROOT/'public/CCG Downloads/CCG_Scripts/c228926678.lua';assert source.read_bytes()==(FILES/'Scripts'/source.name).read_bytes()
paths=[Path(__file__).resolve(),source,ROOT/'src/data/cards.json',FILES/'Databases/CCG_v1.db',OUT/'candidate-CCG_v1.db']+[ROOT/'scripts'/n for n in ['fresh_current_aldrez_bishop_protection.cjs','fresh_current_terrarumian_ivy_participants.cjs','fresh_installed_card.cjs','fresh_corrected_card_data_transport.cjs']]+[ROOT/'tmp/omega_scripts'/n for n in ['constant.lua','utility.lua','procedure.lua']]+list((ROOT/'node_modules/@n1xx1/ocgcore-wasm/dist').glob('*.js'))+[ROOT/'node_modules/@n1xx1/ocgcore-wasm/dist/index-card-data-transport-candidate.mjs']
deps={str(p.resolve()):sha(p) for p in paths};runs=[]
for flag,expected in [(None,[]),('no-battle-protection',[0,1]),('no-effect-protection',[0,1]),('all-types',[2]),('both-sides',[3])]:
 r=subprocess.run(['node','--no-warnings','scripts/fresh_current_aldrez_bishop_protection.cjs']+(['--'+flag] if flag else []),capture_output=True,text=True,timeout=20);p=OUT/('current-aldrez-bishop-protection'+('-'+flag if flag else '')+'.json');d=json.loads(p.read_text());assert len(d['results'])==7 and [i for i,v in enumerate(d['results']) if v['failure']]==expected and all(not v['logs'] and v['trace'] for v in d['results']) and r.returncode==bool(expected),r.stdout+r.stderr
 runs.append({'artifact':p.name,'sha256':sha(p),'expected_failures':expected})
assert deps=={str(p.resolve()):sha(p) for p in paths}
(OUT/'current-aldrez-bishop-protection-batch.json').write_text(json.dumps({'status':'ALDREZ_BISHOP_PROTECTION_VERIFIED','runtime_dependencies_sha256':deps,'runs':runs,'scope':'Full original Bishop/current installed metadata/corrected transport/no Lua API adapter. Initially field neutral Xyz/Link recipients; actual Spell destruction attempt and native losing battle. Own Xyz/Link survive both; ordinary/opponent/source facedown/absent/leaves excluded, battle damage preserved. Effective isolated no-battle/no-effect/all-types/both-sides controls. Source/recipient summon history, other effects/full-card/live Omega remain separate.','production_change':False},indent=2)+'\n')
print('Bishop protection verified with effective controls')

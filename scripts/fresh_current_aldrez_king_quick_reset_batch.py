import hashlib,json,subprocess
from pathlib import Path
ROOT=Path.cwd();OUT=ROOT/'output/fresh-ccg-september';FILES=Path(r'C:\Program Files (x86)\YGO Omega\YGO Omega_Data\Files')
def sha(p):return hashlib.sha256(p.read_bytes()).hexdigest()
source=ROOT/'public/CCG Downloads/CCG_Scripts/c252210718.lua';assert source.read_bytes()==(FILES/'Scripts'/source.name).read_bytes()
paths=[Path(__file__).resolve(),source,ROOT/'src/data/cards.json',FILES/'Databases/CCG_v1.db',OUT/'candidate-CCG_v1.db',OUT/'current-king-detach-activation-rule-review.json',ROOT/'public/CCG Downloads/CCG_Scripts/c238282350.lua']+[ROOT/'scripts'/n for n in ['fresh_current_aldrez_king_quick_reset.cjs','fresh_current_aldrez_king_detach_resource.cjs','fresh_current_aldrez_blitz_xyz_set.cjs','fresh_installed_card.cjs','fresh_corrected_card_data_transport.cjs']]+[ROOT/'tmp/omega_scripts'/n for n in ['constant.lua','utility.lua','procedure.lua']]+list((ROOT/'node_modules/@n1xx1/ocgcore-wasm/dist').glob('*.js'))+[ROOT/'node_modules/@n1xx1/ocgcore-wasm/dist/index-card-data-transport-candidate.mjs']
p=ROOT/'public/CCG Downloads/CCG_Scripts/c238282350.lua';assert p.read_bytes()==(FILES/'Scripts'/p.name).read_bytes()
deps={str(p.resolve()):sha(p) for p in paths};runs=[]
for flag,expected in [(None,[]),('no-limit',[0,1,2]),('no-later-use',[0,1,2]),('no-summon',[0,1,2]),('no-response',[1,2])]:
 r=subprocess.run(['node','--no-warnings','scripts/fresh_current_aldrez_king_quick_reset.cjs']+(['--'+flag] if flag else []),capture_output=True,text=True,timeout=20);p=OUT/('current-aldrez-king-quick-reset'+('-'+flag if flag else '')+'.json');d=json.loads(p.read_text());assert len(d['results'])==3 and [i for i,v in enumerate(d['results']) if v['failure']]==expected and all(not v['logs'] and v['trace'] for v in d['results']) and r.returncode==bool(expected),r.stdout+r.stderr
 runs.append({'artifact':p.name,'sha256':sha(p),'expected_failures':expected})
assert deps=={str(p.resolve()):sha(p) for p in paths}
(OUT/'current-aldrez-king-quick-reset-batch.json').write_text(json.dumps({'status':'ALDREZ_KING_QUICK_RESET_VERIFIED','runtime_dependencies_sha256':deps,'runs':runs,'scope':'Full current King effects/installed metadata/corrected transport/no Lua API adapter. Paid native fixed two-Level4-Aldrez Xyz, first Hand summon/detach or actual CL2 effect/activation negation, same-copy same-turn exclusion, natural later own turn restores Quick and actual second detach/Hand or GY summon. Effective no-limit/no-later-use/no-summon/no-response controls. Multiple-copy independence, original general recipe/full-card/live Omega remain open.','production_change':False},indent=2)+'\n')
print('King Quick turn reset verified')

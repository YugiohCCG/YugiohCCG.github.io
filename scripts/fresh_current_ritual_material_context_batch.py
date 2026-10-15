import hashlib,json,subprocess
from pathlib import Path
ROOT=Path.cwd();OUT=ROOT/'output/fresh-ccg-september'
def sha(p):return hashlib.sha256(p.read_bytes()).hexdigest()
codes=[259072906,259241946,259288669,244959812]
sources=[ROOT/'public/CCG Downloads/CCG_Scripts'/f'c{c}.lua' for c in codes]
paths=sources+[Path(__file__).resolve(),ROOT/'scripts/fresh_current_ritual_material_context.cjs',ROOT/'scripts/fresh_current_card.cjs',ROOT/'src/data/cards.json',OUT/'current-spec-CCG_v1.db']+[ROOT/'tmp/omega_scripts'/n for n in ['constant.lua','utility.lua','procedure.lua']]+list((ROOT/'node_modules/@n1xx1/ocgcore-wasm/dist').glob('*.js'))+list((OUT/'ritual-context-before-release-guard').glob('*.lua'))
before={p.relative_to(ROOT).as_posix():sha(p) for p in paths};runs=[]
for flag,expected in [(None,[]),('old-source','protected'),('blind-deck-guard','deck')]:
 r=subprocess.run(['node','--no-warnings','scripts/fresh_current_ritual_material_context.cjs']+(['--'+flag] if flag else []),capture_output=True,text=True,timeout=20);p=OUT/('current-ritual-material-context'+('-'+flag if flag else '')+'.json');d=json.loads(p.read_text());assert len(d['results'])==23;assert all(not v['logs'] for v in d['results']),r.stdout+r.stderr
 actual=[i for i,v in enumerate(d['results']) if v['failure']]
 want=[i for i,v in enumerate(d['results']) if v['protectedMaterial'] and v['location'] in (['hand','field'] if expected=='protected' else ['deck'])] if expected else []
 assert actual==want,(flag,actual,want);assert r.returncode==(1 if want else 0)
 runs.append({'flag':flag,'artifact':p.name,'artifact_sha256':sha(p),'expected_failures':want})
assert before=={p.relative_to(ROOT).as_posix():sha(p) for p in paths}
inst=Path(r'C:\Program Files (x86)\YGO Omega\YGO Omega_Data\Files\Scripts');assert all(p.read_bytes()==(inst/p.name).read_bytes() for p in sources)
(OUT/'current-ritual-material-context-batch.json').write_text(json.dumps({'status':'VERIFIED_PARTIAL_PRODUCTION','cards':codes,'family_callback_cases':23,'runtime_dependencies_sha256':before,'runs':runs,'scope':'Four full production native loaded scripts;23bounded callback checks for contextual Tribute eligibility Hand/field vs Deck send, and Nephthys self material. Original7protected failures reproduced; blind Deck guard3fails. Native source/install parity/exactbothbackups/fullfrozeninputs. No actual full Ritual effect/group-Pendulum/liveOmega/fullcard certification; Mage group-Pendulum and other effects remain open.'},indent=2)+'\n',encoding='utf-8');print('4context repairs:23PASS; original7/Deckcontrol3 verified')

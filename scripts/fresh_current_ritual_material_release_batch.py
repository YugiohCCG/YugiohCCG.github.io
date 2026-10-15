import hashlib,json,subprocess
from pathlib import Path
ROOT=Path.cwd();OUT=ROOT/'output/fresh-ccg-september'
def sha(p):return hashlib.sha256(p.read_bytes()).hexdigest()
codes=[243306841,257464336,259247807,259546637,259678739,259873115,259961648]
sources=[ROOT/'public/CCG Downloads/CCG_Scripts'/f'c{c}.lua' for c in codes]
paths=sources+[Path(__file__).resolve(),ROOT/'scripts/fresh_current_ritual_material_family.cjs',ROOT/'scripts/fresh_current_glitchling_leotron_pendulum_ritual.cjs',ROOT/'scripts/fresh_current_card.cjs',ROOT/'src/data/cards.json',OUT/'current-spec-CCG_v1.db']+[ROOT/'tmp/omega_scripts'/n for n in ['constant.lua','utility.lua','procedure.lua']]+list((ROOT/'node_modules/@n1xx1/ocgcore-wasm/dist').glob('*.js'))+list((OUT/'ritual-material-before-release-guard').glob('*.lua'))
before={p.relative_to(ROOT).as_posix():sha(p) for p in paths};runs=[]
for family,flag,expected in [(True,None,[]),(True,'old-source','protected'),(False,None,[]),(False,'old-source',['protected','insufficient','fullHand','lateFull']),(False,'no-response',['activation','effect','sourceBanish','targetBanish','materialBanish','lateFull']),(False,'no-material',['hand','extra','grave','fullField']),(False,'no-complete',['hand','fullField'])]:
 stem='current-ritual-material-family' if family else 'current-glitchling-leotron-pendulum-ritual';script='fresh_current_ritual_material_family.cjs' if family else 'fresh_current_glitchling_leotron_pendulum_ritual.cjs'
 r=subprocess.run(['node','--no-warnings','scripts/'+script]+(['--'+flag] if flag else []),capture_output=True,text=True,timeout=20);p=OUT/(stem+('-'+flag if flag else '')+'.json');d=json.loads(p.read_text());assert len(d['results'])==(28 if family else 15);assert all(not v['logs'] for v in d['results']),r.stdout+r.stderr
 actual=[i for i,v in enumerate(d['results']) if v['failure']] if family else [v['scenario'] for v in d['results'] if v['failure']]
 want=[i for i,v in enumerate(d['results']) if v['protectedMaterial']] if expected=='protected' else expected
 assert actual==want,(flag,actual,want);assert r.returncode==(1 if want else 0)
 runs.append({'family':family,'flag':flag,'artifact':p.name,'artifact_sha256':sha(p),'expected_failures':want})
assert before=={p.relative_to(ROOT).as_posix():sha(p) for p in paths}
inst=Path(r'C:\Program Files (x86)\YGO Omega\YGO Omega_Data\Files\Scripts');assert all(p.read_bytes()==(inst/p.name).read_bytes() for p in sources)
(OUT/'current-ritual-material-release-batch.json').write_text(json.dumps({'status':'VERIFIED_PARTIAL_PRODUCTION','cards':codes,'leotron_cases':15,'family_callback_cases':28,'runtime_dependencies_sha256':before,'runs':runs,'scope':'Seven production filters add contextual native IsReleasableByEffect. Leotron15full primary Pendulum Ritual cases pass; original4failures reproduced; controls6/4/2. Family28native callbacks pass with actual protected/unprotected Hand/field cards; original14protected cases fail. Source/install parity/exact backups. Other effects/Deck-send andMage group contexts/nativeOmega/fullcard remain open.'},indent=2)+'\n',encoding='utf-8');print('7repairs:Leotron15/family28pass;original4/14failures and3controls verified')

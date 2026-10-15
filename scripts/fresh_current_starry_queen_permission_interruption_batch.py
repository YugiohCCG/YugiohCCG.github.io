import hashlib,json,subprocess
from pathlib import Path
ROOT=Path.cwd();OUT=ROOT/'output/fresh-ccg-september'
def sha(p):return hashlib.sha256(p.read_bytes()).hexdigest()
source=ROOT/'public/CCG Downloads/CCG_Scripts/c248760718.lua'
paths=[source,Path(__file__).resolve(),ROOT/'scripts/fresh_current_starry_queen_permission_interruption.cjs',ROOT/'scripts/fresh_current_card.cjs',ROOT/'src/data/cards.json',OUT/'current-spec-CCG_v1.db']+[ROOT/'tmp/omega_scripts'/n for n in ['constant.lua','utility.lua','procedure.lua']]+list((ROOT/'node_modules/@n1xx1/ocgcore-wasm/dist').glob('*.js'))
paths += [ROOT/'scripts/fresh_corrected_card_data_transport.cjs',ROOT/'node_modules/@n1xx1/ocgcore-wasm/dist/index-card-data-transport-candidate.mjs']
before={p.relative_to(ROOT).as_posix():sha(p) for p in paths};runs=[]
for control,expected in [(None,[]),('no-response',['negateActivation','negateEffect','sourceBanish']),('no-permission',['baseline','sourceBanish'])]:
 r=subprocess.run(['node','--no-warnings','scripts/fresh_current_starry_queen_permission_interruption.cjs']+(['--'+control] if control else []),capture_output=True,text=True,timeout=20);p=OUT/('current-starry-queen-permission-interruption'+('-'+control if control else '')+'.json');d=json.loads(p.read_text());assert len(d['results'])==4 and all(not v['logs'] for v in d['results']),r.stdout+r.stderr
 assert [v['scenario'] for v in d['results'] if v['failure']]==expected;assert r.returncode==(1 if expected else 0)
 runs.append({'control':control,'artifact':p.name,'artifact_sha256':sha(p),'expected_failures':expected})
assert before=={p.relative_to(ROOT).as_posix():sha(p) for p in paths}
assert source.read_bytes()==Path(r'C:\Program Files (x86)\YGO Omega\YGO Omega_Data\Files\Scripts/c248760718.lua').read_bytes()
(OUT/'current-starry-queen-permission-interruption-batch.json').write_text(json.dumps({'status':'VERIFIED_COMPATIBILITY_DIAGNOSTIC','baseline_cases':4,'runtime_dependencies_sha256':before,'runs':runs,'scope':'Starry4native permission interruption cases fullsourceactualLIGHTFairyreveal/PZoneMovecostbeforeCHAINED; CounterTrapCL2 negatesactivation/effect orbanishessource. Negationsgrantnopermissionretaincost; sourcebanish grantsoneactualTrapactivation/consumption. ControlsnoResponse3/noPermission2; emptylogs/parity/frozeninputs. Explicit chainattributeconstant22 mapping/correctedCardData compatibilitydiagnosticnotunadaptedOmega/fullcard. Nameduse/resetother effects open.'},indent=2)+'\n',encoding='utf-8');print('Starry4interruption diagnosticPASS;controls3/2verified')

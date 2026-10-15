import hashlib,json,subprocess
from pathlib import Path
ROOT=Path.cwd();OUT=ROOT/'output/fresh-ccg-september'
def sha(p):return hashlib.sha256(p.read_bytes()).hexdigest()
source=ROOT/'public/CCG Downloads/CCG_Scripts/c248760718.lua'
paths=[source,Path(__file__).resolve(),ROOT/'scripts/fresh_current_starry_queen_permission_shared_reset.cjs',ROOT/'scripts/fresh_current_card.cjs',ROOT/'src/data/cards.json',OUT/'current-spec-CCG_v1.db']+[ROOT/'tmp/omega_scripts'/n for n in ['constant.lua','utility.lua','procedure.lua']]+list((ROOT/'node_modules/@n1xx1/ocgcore-wasm/dist').glob('*.js'))
paths += [ROOT/'scripts/fresh_corrected_card_data_transport.cjs',ROOT/'node_modules/@n1xx1/ocgcore-wasm/dist/index-card-data-transport-candidate.mjs']
before={p.relative_to(ROOT).as_posix():sha(p) for p in paths};runs=[]
for control,expected in [(None,[]),('per-copy',['baseline','negateActivation','negateEffect']),('no-reset',['baseline','negateActivation','negateEffect'])]:
 r=subprocess.run(['node','--no-warnings','scripts/fresh_current_starry_queen_permission_shared_reset.cjs']+(['--'+control] if control else []),capture_output=True,text=True,timeout=20);p=OUT/('current-starry-queen-permission-shared-reset'+('-'+control if control else '')+'.json');d=json.loads(p.read_text());assert len(d['results'])==3 and all(not v['logs'] for v in d['results']),r.stdout+r.stderr
 assert [v['scenario'] for v in d['results'] if v['failure']]==expected;assert r.returncode==(1 if expected else 0)
 runs.append({'control':control,'artifact':p.name,'artifact_sha256':sha(p),'expected_failures':expected})
assert before=={p.relative_to(ROOT).as_posix():sha(p) for p in paths}
assert source.read_bytes()==Path(r'C:\Program Files (x86)\YGO Omega\YGO Omega_Data\Files\Scripts/c248760718.lua').read_bytes()
(OUT/'current-starry-queen-permission-shared-reset-batch.json').write_text(json.dumps({'status':'VERIFIED_COMPATIBILITY_DIAGNOSTIC','baseline_cases':3,'runtime_dependencies_sha256':before,'runs':runs,'scope':'Starry3native shared two-copy use/reset cases success/NegAct/NegEffect; cost/reveal/movementbeforeCHAINED retained; own1secondcopyblockedwithfreeoppositePZone. NaturalNEW_TURN0/1/0 thenoldTrapresolution/freshTrapHandSet, secondcopycostactualPZoneMove andnewfreshpermission. CopiesactuallySZONE0/4. ControlsperCopy3/noReset3, emptylogs/parity/frozeninputs. Explicitattributeconstant22/correctedCardData compatibilitydiagnosticnotOmega/fullcard.'},indent=2)+'\n',encoding='utf-8');print('Starry3sharedreset diagnosticPASS;controls3/3verified')

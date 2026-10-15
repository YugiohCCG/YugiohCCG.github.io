import hashlib,json,subprocess
from pathlib import Path
ROOT=Path.cwd();OUT=ROOT/'output/fresh-ccg-september'
def sha(p):return hashlib.sha256(p.read_bytes()).hexdigest()
source=ROOT/'public/CCG Downloads/CCG_Scripts/c248760718.lua'
paths=[source,Path(__file__).resolve(),ROOT/'scripts/fresh_current_starry_queen_permission_expiry.cjs',ROOT/'scripts/fresh_current_card.cjs',ROOT/'src/data/cards.json',OUT/'current-spec-CCG_v1.db']+[ROOT/'tmp/omega_scripts'/n for n in ['constant.lua','utility.lua','procedure.lua']]+list((ROOT/'node_modules/@n1xx1/ocgcore-wasm/dist').glob('*.js'))
paths += [ROOT/'scripts/fresh_corrected_card_data_transport.cjs',ROOT/'node_modules/@n1xx1/ocgcore-wasm/dist/index-card-data-transport-candidate.mjs']
before={p.relative_to(ROOT).as_posix():sha(p) for p in paths};runs=[]
for control,expected in [(None,[]),('no-expiry',['present','removed']),('no-set',['present','removed'])]:
 r=subprocess.run(['node','--no-warnings','scripts/fresh_current_starry_queen_permission_expiry.cjs']+(['--'+control] if control else []),capture_output=True,text=True,timeout=20);p=OUT/('current-starry-queen-permission-expiry'+('-'+control if control else '')+'.json');d=json.loads(p.read_text());assert len(d['results'])==2 and all(not v['logs'] for v in d['results']),r.stdout+r.stderr
 assert [v['scenario'] for v in d['results'] if v['failure']]==expected;assert r.returncode==(1 if expected else 0)
 runs.append({'control':control,'artifact':p.name,'artifact_sha256':sha(p),'expected_failures':expected})
assert before=={p.relative_to(ROOT).as_posix():sha(p) for p in paths}
assert source.read_bytes()==Path(r'C:\Program Files (x86)\YGO Omega\YGO Omega_Data\Files\Scripts/c248760718.lua').read_bytes()
(OUT/'current-starry-queen-permission-expiry-batch.json').write_text(json.dumps({'status':'VERIFIED_COMPATIBILITY_DIAGNOSTIC','baseline_cases':2,'runtime_dependencies_sha256':before,'runs':runs,'scope':'Full source unusedgrant expiresnativeEndPhase; sourcepresent andactualbanishedbeforeEndPhase cases. NativeNEW_TURNplayers0/1, actualown1permission freshTrapavailable unused, nativeQuickeffectSetsnewTrapfromHandonopponent2, realresponsewindowexcludesfreshTrap. ControlsnoExpiry2/noSet2 proveexpiry/freshSetessential. Emptylogs/parity/frozeninputs, explicitattributeconstantmapping22/correctedCardData: compatibilitydiagnosticnotnativeOmega/fullcard. Shareduses/negations remainopen.'},indent=2)+'\n',encoding='utf-8');print('Starry2expiry diagnosticPASS;controls2/2verified')

"""Native combat and mixed-cause protection review; no production edits."""
import hashlib,json,subprocess
from pathlib import Path
ROOT=Path(__file__).resolve().parents[1];OUT=ROOT/'output/fresh-ccg-september';FILES=Path(r'C:\Program Files (x86)\YGO Omega\YGO Omega_Data\Files')
def sha(p):return hashlib.sha256(p.read_bytes()).hexdigest()
paths=[Path(__file__),ROOT/'scripts/fresh_current_kanmuriyama_recovery.cjs',ROOT/'scripts/fresh_installed_card.cjs',ROOT/'scripts/fresh_corrected_card_data_transport.cjs',ROOT/'public/CCG Downloads/CCG_Scripts/c248801935.lua',FILES/'Scripts/c248801935.lua',FILES/'Databases/CCG_v1.db']+[ROOT/'tmp/omega_scripts'/n for n in ['constant.lua','utility.lua','procedure.lua']]+list((ROOT/'node_modules/@n1xx1/ocgcore-wasm/dist').glob('*.js'))+[ROOT/'node_modules/@n1xx1/ocgcore-wasm/dist/index-card-data-transport-candidate.mjs']
before={str(p.resolve()):sha(p) for p in paths};runs=[]
for mode,expected in [('current',[]),('no-recovery',[0,1]),('any-destination',[2,3,4])]:
 subprocess.run(['node','--no-warnings','scripts/fresh_current_kanmuriyama_recovery.cjs',mode],cwd=ROOT,capture_output=True,check=True,timeout=20)
 p=OUT/f'current-kanmuriyama-recovery-{mode}.json';d=json.loads(p.read_text());assert len(d['results'])==5 and [i for i,x in enumerate(d['results']) if x['failure']]==expected and all(not x['logs'] for x in d['results'])
 runs.append({'mode':mode,'file':p.name,'sha256':sha(p),'expected_failures':expected})
assert before=={str(p.resolve()):sha(p) for p in paths}
assert (ROOT/'public/CCG Downloads/CCG_Scripts/c248801935.lua').read_bytes()==(FILES/'Scripts/c248801935.lua').read_bytes()
report={'scope':'Five original native activation/equip/recipient-movement/lost-target destruction/recovery cases: own/opponent returned-to-hand positives;Deck/GY/banishment exclusions. Actual Equip GY transition then hand recovery recorded. Neutral recipient/movement actor,no Lua API mapping. No production changes.','runtime_dependencies_sha256':before,'runs':runs,'related_evidence':[{'file':n,'sha256':sha(OUT/n)} for n in ['current-kanmuriyama-equip-event-review.json','current-equip-controller-review.json']],'remaining_gaps':['Battle bounce clause','Named search use/reset;recovery source departure and negation','Live Omega and full-card certification']}
(OUT/'current-kanmuriyama-recovery-review.json').write_text(json.dumps(report,indent=2)+'\n')
print('Kanmuriyama:5 native recovery cases/2 effective controls;no production changes')

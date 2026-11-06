"""Bounded original search/send and successful-use sharing review; no repairs."""
import hashlib,json,subprocess
from pathlib import Path
ROOT=Path(__file__).resolve().parents[1];OUT=ROOT/'output/fresh-ccg-september';FILES=Path(r'C:\Program Files (x86)\YGO Omega\YGO Omega_Data\Files')
def sha(p):return hashlib.sha256(p.read_bytes()).hexdigest()
paths=[Path(__file__),ROOT/'scripts/fresh_current_wyvernal_search_send.cjs',ROOT/'scripts/fresh_installed_card.cjs',ROOT/'scripts/fresh_corrected_card_data_transport.cjs',ROOT/'public/CCG Downloads/CCG_Scripts/c259073666.lua',FILES/'Scripts/c259073666.lua',FILES/'Databases/CCG_v1.db']+[ROOT/'tmp/omega_scripts'/n for n in ['constant.lua','utility.lua','procedure.lua']]+list((ROOT/'node_modules/@n1xx1/ocgcore-wasm/dist').glob('*.js'))+[ROOT/'node_modules/@n1xx1/ocgcore-wasm/dist/index-card-data-transport-candidate.mjs']
before={str(p.resolve()):sha(p) for p in paths};runs=[]
for mode,expected in [('current',[]),('no-add',[0,1,6,8]),('no-send',[0,1,6,8]),('no-pair-check',[2,3,4,5]),('no-choice-check',[1]),('per-copy',[0,1,8]),('per-effect',[0,1,8])]:
 subprocess.run(['node','--no-warnings','scripts/fresh_current_wyvernal_search_send.cjs',mode],cwd=ROOT,capture_output=True,check=True,timeout=20)
 p=OUT/f'current-wyvernal-search-send-{mode}.json';d=json.loads(p.read_text());assert len(d['results'])==9 and [i for i,x in enumerate(d['results']) if x['failure']]==expected and all(not x['logs'] for x in d['results'])
 runs.append({'mode':mode,'file':p.name,'sha256':sha(p),'expected_failures':expected})
assert before=={str(p.resolve()):sha(p) for p in paths}
assert (ROOT/'public/CCG Downloads/CCG_Scripts/c259073666.lua').read_bytes()==(FILES/'Scripts/c259073666.lua').read_bytes()
report={'scope':'Nine original Normal Spell search/send cases: native paired selection and role assignment, four resource exclusions, actual CL2 source/resource departure, Main/GY successful-use sharing, second-copy sharing and natural next-own-turn actual second operation with unused legal resources. No Lua API mapping or production edit. Neutral Deck identities carry native movement restrictions; no original recipient effect/procedure claim.','runtime_dependencies_sha256':before,'runs':runs,'related_evidence':[{'file':n,'sha256':sha(OUT/n)} for n in ['current-wyvernal-draw-permission-review.json']],'remaining_gaps':['Original GY operation needs supported legacy CHAININFO runtime; mapped history is not unadapted proof','Count-limit handling under activation/effect negation not tested in this batch','Other GY eligibility/interruption/Necrovalley boundaries','Live Omega/full-card certification']}
(OUT/'current-wyvernal-search-send-review.json').write_text(json.dumps(report,indent=2)+'\n')
print('Wyvernal:9 original cases/6 effective controls;source unchanged;no API mapping')

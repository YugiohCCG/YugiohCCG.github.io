"""Native combat and mixed-cause protection review; no production edits."""
import hashlib,json,subprocess
from pathlib import Path
ROOT=Path(__file__).resolve().parents[1];OUT=ROOT/'output/fresh-ccg-september';FILES=Path(r'C:\Program Files (x86)\YGO Omega\YGO Omega_Data\Files')
def sha(p):return hashlib.sha256(p.read_bytes()).hexdigest()
paths=[Path(__file__),ROOT/'scripts/fresh_current_striking_chain_response.cjs',ROOT/'scripts/fresh_installed_card.cjs',ROOT/'scripts/fresh_corrected_card_data_transport.cjs',ROOT/'public/CCG Downloads/CCG_Scripts/c250902476.lua',FILES/'Scripts/c250902476.lua',FILES/'Databases/CCG_v1.db']+[ROOT/'tmp/omega_scripts'/n for n in ['constant.lua','utility.lua','procedure.lua']]+list((ROOT/'node_modules/@n1xx1/ocgcore-wasm/dist').glob('*.js'))+[ROOT/'node_modules/@n1xx1/ocgcore-wasm/dist/index-card-data-transport-candidate.mjs']
before={str(p.resolve()):sha(p) for p in paths};runs=[]
for mode,expected in [('current',[]),('no-destroy',[0,1,2,5]),('no-extra',[1,2]),('own-allowed',[3]),('independent-extra',[4])]:
 subprocess.run(['node','--no-warnings','scripts/fresh_current_striking_chain_response.cjs',mode],cwd=ROOT,capture_output=True,check=True,timeout=20)
 p=OUT/f'current-striking-chain-response-{mode}.json';d=json.loads(p.read_text());assert len(d['results'])==6 and [i for i,x in enumerate(d['results']) if x['failure']]==expected and all(not x['logs'] for x in d['results'])
 runs.append({'mode':mode,'file':p.name,'sha256':sha(p),'expected_failures':expected})
assert before=={str(p.resolve()):sha(p) for p in paths}
assert (ROOT/'public/CCG Downloads/CCG_Scripts/c250902476.lua').read_bytes()==(FILES/'Scripts/c250902476.lua').read_bytes()
report={'scope':'Six native original set-trap chain response cases: opponent monster activation with optional follow-up accepted/declined, Spell activation, own-player exclusion, late CL3 native destruction protection, and no remaining eligible monster. Actor operation still resolves after destruction. Neutral actors; no Lua API mapping. No production changes.','runtime_dependencies_sha256':before,'runs':runs,'related_evidence':[{'file':n,'sha256':sha(OUT/n)} for n in ['current-striking-attack-scope-review.json','current-card-count-truthiness-triage.json']],'remaining_gaps':['GY/banished effect-source activation legality remains unconfirmed; no production restriction added','Source departure and return, negated activation versus effect, shared named activation count/reset','Live Omega and full-card certification']}
(OUT/'current-striking-chain-response-review.json').write_text(json.dumps(report,indent=2)+'\n')
print('Striking Mirror Force:6 native chain cases/4 effective controls;no production changes')

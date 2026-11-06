"""Native combat and mixed-cause protection review; no production edits."""
import hashlib,json,subprocess
from pathlib import Path
ROOT=Path(__file__).resolve().parents[1];OUT=ROOT/'output/fresh-ccg-september';FILES=Path(r'C:\Program Files (x86)\YGO Omega\YGO Omega_Data\Files')
def sha(p):return hashlib.sha256(p.read_bytes()).hexdigest()
paths=[Path(__file__),ROOT/'scripts/fresh_current_copy_effect_expiry.cjs',ROOT/'scripts/fresh_installed_card.cjs',ROOT/'scripts/fresh_corrected_card_data_transport.cjs',ROOT/'public/CCG Downloads/CCG_Scripts/c256469525.lua',FILES/'Scripts/c256469525.lua',ROOT/'public/CCG Downloads/CCG_Scripts/c256608976.lua',FILES/'Scripts/c256608976.lua',FILES/'Databases/CCG_v1.db']+[ROOT/'tmp/omega_scripts'/n for n in ['constant.lua','utility.lua','procedure.lua']]+list((ROOT/'node_modules/@n1xx1/ocgcore-wasm/dist').glob('*.js'))+[ROOT/'node_modules/@n1xx1/ocgcore-wasm/dist/index-card-data-transport-candidate.mjs']
before={str(p.resolve()):sha(p) for p in paths};runs=[]
for mode,expected in [('current',[]),('no-copy',[0,1]),('no-operation',[0,1]),('no-expiry',[1])]:
 subprocess.run(['node','--no-warnings','scripts/fresh_current_copy_effect_expiry.cjs',mode],cwd=ROOT,capture_output=True,check=True,timeout=20)
 p=OUT/f'current-copy-effect-expiry-{mode}.json';d=json.loads(p.read_text());assert len(d['results'])==2 and [i for i,x in enumerate(d['results']) if x['failure']]==expected and all(not x['logs'] for x in d['results'])
 runs.append({'mode':mode,'file':p.name,'sha256':sha(p),'expected_failures':expected})
assert before=={str(p.resolve()):sha(p) for p in paths}
for code in [256469525,256608976]:assert (ROOT/f'public/CCG Downloads/CCG_Scripts/c{code}.lua').read_bytes()==(FILES/f'Scripts/c{code}.lua').read_bytes()
report={'scope':'Two original native copy-effect cases. Dynatos inherent summon and Silhouette reveal/copy branch gain neutral original Effect Monster ignition. Actual card draw,immediate copied local per-turn reuse exclusion and own-turn3 persistence for Dynatos versus End-Phase expiry for Silhouette verified. No API mapping. No production edits.','runtime_dependencies_sha256':before,'runs':runs,'related_evidence':[{'file':n,'sha256':sha(OUT/n)} for n in ['current-copy-token-choice-review.json']],'remaining_gaps':['Arbitrary copied properties/effects,replacement-versus-gain wording semantics','Original named limits,other branches and interruption boundaries','Live Omega and full-card certification']}
(OUT/'current-copy-effect-expiry-review.json').write_text(json.dumps(report,indent=2)+'\n')
print('Copy effects:2 native cases/3 effective controls;no production changes')

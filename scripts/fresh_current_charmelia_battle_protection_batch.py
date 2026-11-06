"""Native combat and mixed-cause protection review; no production edits."""
import hashlib,json,subprocess
from pathlib import Path
ROOT=Path(__file__).resolve().parents[1];OUT=ROOT/'output/fresh-ccg-september';FILES=Path(r'C:\Program Files (x86)\YGO Omega\YGO Omega_Data\Files')
def sha(p):return hashlib.sha256(p.read_bytes()).hexdigest()
paths=[Path(__file__),ROOT/'scripts/fresh_current_charmelia_battle_protection.cjs',ROOT/'scripts/fresh_installed_card.cjs',ROOT/'scripts/fresh_corrected_card_data_transport.cjs',ROOT/'public/CCG Downloads/CCG_Scripts/c259226799.lua',FILES/'Scripts/c259226799.lua',FILES/'Databases/CCG_v1.db']+[ROOT/'tmp/omega_scripts'/n for n in ['constant.lua','utility.lua','procedure.lua']]+list((ROOT/'node_modules/@n1xx1/ocgcore-wasm/dist').glob('*.js'))+[ROOT/'node_modules/@n1xx1/ocgcore-wasm/dist/index-card-data-transport-candidate.mjs']
before={str(p.resolve()):sha(p) for p in paths};runs=[]
for mode,expected in [('current',[]),('no-protection',[0,1,2,3,4]),('unlimited',[0,1,2,4]),('split-limits',[1,2])]:
 subprocess.run(['node','--no-warnings','scripts/fresh_current_charmelia_battle_protection.cjs',mode],cwd=ROOT,capture_output=True,check=True,timeout=20)
 p=OUT/f'current-charmelia-battle-protection-{mode}.json';d=json.loads(p.read_text());assert len(d['results'])==5 and [i for i,x in enumerate(d['results']) if x['failure']]==expected and all(not x['logs'] for x in d['results'])
 runs.append({'mode':mode,'file':p.name,'sha256':sha(p),'expected_failures':expected})
assert before=={str(p.resolve()):sha(p) for p in paths}
assert (ROOT/'public/CCG Downloads/CCG_Scripts/c259226799.lua').read_bytes()==(FILES/'Scripts/c259226799.lua').read_bytes()
report={'scope':'Five original continuous-protection native combat cases: first/second distinct battle recipients, effect-before-battle, battle-before-effect, non-archetype first victim and actual facedown battle flip. One shared allowance across destruction causes verified. Seeded source/neutral combatants; no original recipient procedure claim or Lua API mapping. No production edits.','runtime_dependencies_sha256':before,'runs':runs,'related_evidence':[{'file':n,'sha256':sha(OUT/n)} for n in ['current-charmelia-beast-clause-review.json','current-charmelia-draw-permission-review.json']],'remaining_gaps':['Simultaneous destruction and multiple source-copy behavior','Recovery named cross-copy use/reset, negation and remaining eligibility/interruption boundaries','Original recipient summon procedures/live Omega/full-card certification']}
(OUT/'current-charmelia-battle-protection-review.json').write_text(json.dumps(report,indent=2)+'\n')
print('Charmelia:5 native combat cases/3 effective controls;no production changes')

"""Scoped original protection review; reuse historical recovery without rerunning it."""
import hashlib,importlib.util,json,subprocess
from pathlib import Path
ROOT=Path(__file__).resolve().parents[1];OUT=ROOT/'output/fresh-ccg-september';FILES=Path(r'C:\Program Files (x86)\YGO Omega\YGO Omega_Data\Files')
def sha(p):return hashlib.sha256(p.read_bytes()).hexdigest()
paths=[Path(__file__),ROOT/'scripts/fresh_current_charmelia_beast_protection.cjs',ROOT/'scripts/fresh_installed_card.cjs',ROOT/'scripts/fresh_corrected_card_data_transport.cjs',ROOT/'public/CCG Downloads/CCG_Scripts/c259226799.lua',FILES/'Scripts/c259226799.lua',FILES/'Databases/CCG_v1.db']+[ROOT/'tmp/omega_scripts'/n for n in ['constant.lua','utility.lua','procedure.lua']]+list((ROOT/'node_modules/@n1xx1/ocgcore-wasm/dist').glob('*.js'))+[ROOT/'node_modules/@n1xx1/ocgcore-wasm/dist/index-card-data-transport-candidate.mjs']
before={str(p.resolve()):sha(p) for p in paths};runs=[]
for mode,expected in [('current',[]),('no-target',[2]),('no-destruction',[0,1,3,4,6]),('unlimited',[0,1,3,4,6])]:
 subprocess.run(['node','--no-warnings','scripts/fresh_current_charmelia_beast_protection.cjs',mode],cwd=ROOT,capture_output=True,check=True,timeout=20)
 p=OUT/f'current-charmelia-beast-protection-{mode}.json';d=json.loads(p.read_text());assert len(d['results'])==7 and [i for i,x in enumerate(d['results']) if x['failure']]==expected and all(not x['logs'] for x in d['results'])
 runs.append({'mode':mode,'file':p.name,'sha256':sha(p),'expected_failures':expected})
assert before=={str(p.resolve()):sha(p) for p in paths}
assert (ROOT/'public/CCG Downloads/CCG_Scripts/c259226799.lua').read_bytes()==(FILES/'Scripts/c259226799.lua').read_bytes()
old=OUT/'current-charmelia-beast-recover-batch.json';r=json.loads(old.read_text());spec=importlib.util.spec_from_file_location('ledger',ROOT/'scripts/fresh_repair_ledger.py');ledger=importlib.util.module_from_spec(spec);spec.loader.exec_module(ledger)
for n,h in r['runtime_dependencies_sha256'].items():ledger.verify_dependency(n,h)
for run in r['runs']:
 p=OUT/run['artifact'];assert sha(p)==run['artifact_sha256'];d=json.loads(p.read_text());assert [x['test'] for x in d['results'] if x['failure']]==run['expected_failures'] and d['script_sha256']==sha(ROOT/'public/CCG Downloads/CCG_Scripts/c259226799.lua')
report={'scope':'Seven new original continuous-protection cases, typed neutral recipients/seeded source. Native targeted effect destruction of distinct recipients sharing a first-destruction limit, next-player-turn reset, target boundaries and actual source departure. No Lua API mapping. Existing4 recovery cases reused at exact current source with recorded dependencies/historical reconciliation; no recovery rerun. No production edits.','runtime_dependencies_sha256':before,'runs':runs,'reused_recovery':{'file':old.name,'sha256':sha(old),'baseline_cases':4,'qualification':'Historical transport/metadata scope retained; no current original Ritual procedure or full-card inference.'},'remaining_gaps':['Battle and simultaneous-destruction behavior','Recovery named cross-copy use/reset, interruptions and eligibility','Recovery mandatory-draw activation legality when draw is prohibited: rules/source conclusion not established','Live Omega/full-card certification']}
(OUT/'current-charmelia-beast-clause-review.json').write_text(json.dumps(report,indent=2)+'\n')
print('Charmelia Beast:7 protection cases/3 effective controls;4 historical recovery cases reused;no production changes')

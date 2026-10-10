import hashlib,json
from pathlib import Path
ROOT=Path(__file__).resolve().parents[1];OUT=ROOT/'output/fresh-ccg-september'
def sha(p):return hashlib.sha256(p.read_bytes()).hexdigest()
source=ROOT/'public/CCG Downloads/CCG_Scripts/c238276252.lua';installed=Path(r'C:\Program Files (x86)\YGO Omega\YGO Omega_Data\Files\Scripts\c238276252.lua');assert sha(source)==sha(installed)
names=['current-prayer-spirit-limit-batch.json','current-prayer-delayed-reset-batch.json','current-prayer-search-leave-field-batch.json','current-prayer-search-copies-batch.json','current-prayer-main-copies-batch.json','current-prayer-necrovalley-batch.json','current-prayer-late-spirit-batch.json'];rows=[];cases=controls=0
for name in names:
 p=OUT/name;d=json.loads(p.read_text());assert d['baseline_cases']>0
 for dependency,h in d['runtime_dependencies_sha256'].items():assert sha(ROOT/dependency)==h,(name,dependency)
 for run in d['runs']:
  artifact=OUT/run['artifact'];assert sha(artifact)==run['artifact_sha256']
  data=json.loads(artifact.read_text());assert data['script_sha256']==sha(source)
  assert [r['test'] for r in data['results'] if r['failure']]==run['expected_failures']
  if run['control']:assert run['expected_failures'];controls+=1
  else:assert not run['expected_failures']
 cases+=d['baseline_cases'];rows.append({'batch':name,'sha256':sha(p),'baseline_cases':d['baseline_cases']})
assert cases==25 and controls==12
(OUT/'current-prayer-coverage.json').write_text(json.dumps({'passcode':238276252,'status':'CURRENT_BOUNDED_EVIDENCE_VERIFIED','scope':'Seven frozen suites,25 native fixture scenarios/12 detected controls; counts include multi-turn scenarios, not exhaustive branches. Full-card/native Omega certification remains OPEN.','source_sha256':sha(source),'installed_matches':True,'verifier_sha256':sha(Path(__file__)),'baseline_cases':cases,'controls':controls,'batches':rows,'open':['native Omega','proper initial Ritual/Spirit procedures','actual named recipient effects','activation/effect negation and response interactions','remaining immunity/temporary removal/control-change edge cases','full audit all711 cards']},indent=2)+'\n')
print('Prayer seven suites:25 scenarios/12 controls, current source/install evidence verified')

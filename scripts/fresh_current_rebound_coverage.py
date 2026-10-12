import hashlib,json
from pathlib import Path
ROOT=Path(__file__).resolve().parents[1];OUT=ROOT/'output/fresh-ccg-september'
def sha(p):return hashlib.sha256(p.read_bytes()).hexdigest()
source=ROOT/'public/CCG Downloads/CCG_Scripts/c259687425.lua'
installed=Path(r'C:\Program Files (x86)\YGO Omega\YGO Omega_Data\Files\Scripts\c259687425.lua')
assert sha(source)==sha(installed)
suites=[]
for name in ['count','disable','opponent-turn','normal-summon','special-summon','flip-summon','origin']:
 p=OUT/('current-rebound-'+name+'-batch.json');batch=json.loads(p.read_text())
 for dependency,h in batch['runtime_dependencies_sha256'].items():assert sha(ROOT/dependency)==h
 for run in batch['runs']:
  artifact=OUT/run['artifact'];assert sha(artifact)==run['artifact_sha256']
  data=json.loads(artifact.read_text());assert data['script_sha256']==sha(source)
  assert [r['test'] for r in data['results'] if r['failure']]==run['expected_failures']
 suites.append({'batch':p.name,'sha256':sha(p),'compatibility_adapted':True,'scenarios':batch['baseline_cases'],'controls':sum(r['control'] is not None for r in batch['runs'])})
report={'passcode':259687425,'script_sha256':sha(source),'installed_matches':True,'scenarios':sum(s['scenarios'] for s in suites),'controls':sum(s['controls'] for s in suites),'suites':suites,'full_card_audit':'OPEN','limitations':['Explicit legacy CHAININFO_TRIGGERING_PLAYER=2 adapter','Native Omega execution']}
(OUT/'current-rebound-coverage.json').write_text(json.dumps(report,indent=2)+'\n')
print(json.dumps({k:report[k] for k in ['scenarios','controls','full_card_audit']}))

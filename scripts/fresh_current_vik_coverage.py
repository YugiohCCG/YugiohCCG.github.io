import hashlib,json
from pathlib import Path
ROOT=Path(__file__).resolve().parents[1];OUT=ROOT/'output/fresh-ccg-september'
def sha(p):return hashlib.sha256(p.read_bytes()).hexdigest()
source=ROOT/'public/CCG Downloads/CCG_Scripts/c259113182.lua'
installed=Path(r'C:\Program Files (x86)\YGO Omega\YGO Omega_Data\Files\Scripts\c259113182.lua')
assert sha(source)==sha(installed)
suites=[]
for name in ['normal-search','attach','immunity','relation','attach-limit','special-search']:
 p=OUT/('current-vik-'+name+'-batch.json');batch=json.loads(p.read_text())
 for dependency,h in batch['runtime_dependencies_sha256'].items():assert sha(ROOT/dependency)==h
 for run in batch['runs']:
  artifact=OUT/run['artifact'];assert sha(artifact)==run['artifact_sha256']
  data=json.loads(artifact.read_text());assert data['script_sha256']==sha(source)
  assert [r['test'] for r in data['results'] if r['failure']]==run['expected_failures']
 suites.append({'batch':p.name,'sha256':sha(p),'scenarios':batch['baseline_cases'],'controls':sum(r['control'] is not None for r in batch['runs'])})
report={'passcode':259113182,'script_sha256':sha(source),'installed_matches':True,'scenarios':sum(s['scenarios'] for s in suites),'controls':sum(s['controls'] for s in suites),'suites':suites,'full_card_audit':'OPEN','limitations':['Neutral Xyz host initially field; proper original Xyz materials unproven','Search renewal, late immunity/control/rank/overlay eligibility changes and Necrovalley','Native Omega execution']}
(OUT/'current-vik-coverage.json').write_text(json.dumps(report,indent=2)+'\n')
print(json.dumps({k:report[k] for k in ['scenarios','controls','full_card_audit']}))

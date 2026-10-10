import hashlib,json
from pathlib import Path
ROOT=Path(__file__).resolve().parents[1];OUT=ROOT/'output/fresh-ccg-september'
def sha(p):return hashlib.sha256(p.read_bytes()).hexdigest()
source=ROOT/'public/CCG Downloads/CCG_Scripts/c259669838.lua'
installed=Path(r'C:\Program Files (x86)\YGO Omega\YGO Omega_Data\Files\Scripts\c259669838.lua')
assert sha(source)==sha(installed)
suites=[]
for name in ['shuffle','necrovalley','revival','boost-scope','boost-reset','summon-cap','link','link-revival']:
 p=OUT/('current-plexus-'+name+'-batch.json');batch=json.loads(p.read_text())
 for dependency,h in batch['runtime_dependencies_sha256'].items():assert sha(ROOT/dependency)==h
 for run in batch['runs']:
  artifact=OUT/run['artifact'];assert sha(artifact)==run['artifact_sha256']
  data=json.loads(artifact.read_text());assert data['script_sha256']==sha(source)
  assert [r['test'] for r in data['results'] if r['failure']]==run['expected_failures']
 suites.append({'batch':p.name,'sha256':sha(p),'scenarios':batch['baseline_cases'],'controls':sum(r['control'] is not None for r in batch['runs'])})
report={'passcode':259669838,'script_sha256':sha(source),'installed_matches':True,'scenarios':sum(s['scenarios'] for s in suites),'controls':sum(s['controls'] for s in suites),'suites':suites,'full_card_audit':'OPEN','limitations':['Older isolated effect suites disable original Link; Link suite executes production procedure with explicit bounded legacy aliases/empty mandatory-material group','On-summon fixtures ignore initial limit; separate Link suite covers faceup/facedown neutral Krawler materials','Named Special Summon cap, full-field/Spirit/late changes, Necrovalley activation legality','Native Omega execution']}
(OUT/'current-plexus-coverage.json').write_text(json.dumps(report,indent=2)+'\n')
print(json.dumps({k:report[k] for k in ['scenarios','controls','full_card_audit']}))

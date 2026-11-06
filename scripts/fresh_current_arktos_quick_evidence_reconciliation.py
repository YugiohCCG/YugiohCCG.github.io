import hashlib,json,subprocess
from pathlib import Path
from fresh_repair_ledger import verify_dependency
ROOT=Path.cwd();OUT=ROOT/'output/fresh-ccg-september';FILES=Path(r'C:\Program Files (x86)\YGO Omega\YGO Omega_Data\Files')
def sha(p):return hashlib.sha256(p.read_bytes()).hexdigest()
source=ROOT/'public/CCG Downloads/CCG_Scripts/c259537607.lua';assert source.read_bytes()==(FILES/'Scripts'/source.name).read_bytes();deps=[Path(__file__).resolve(),source,ROOT/'scripts/fresh_current_card.cjs',ROOT/'scripts/fresh_installed_card.cjs',OUT/'current-spec-CCG_v1.db',FILES/'Databases/CCG_v1.db',OUT/'current-spec-name-only-reconciliation.json'];before={str(p.resolve()):sha(p) for p in deps}
r=subprocess.run(['node','--no-warnings','-e',"require('node:assert/strict').deepEqual(require('./scripts/fresh_current_card.cjs').candidateCard(259537607),require('./scripts/fresh_installed_card.cjs').candidateCard(259537607))"],capture_output=True,text=True,timeout=10);assert r.returncode==0,r.stderr
suites=[]
for name in ['quick','quick-immunity','quick-limit','quick-zones']:
 p=OUT/('current-arktos-'+name+'-batch.json');batch=json.loads(p.read_text())
 for relative,h in batch['runtime_dependencies_sha256'].items():verify_dependency(relative,h)
 for run in batch['runs']:
  a=OUT/run['artifact'];assert sha(a)==run['artifact_sha256'];d=json.loads(a.read_text());assert d['script_sha256']==sha(source);assert [v['test'] for v in d['results'] if v['failure']]==run['expected_failures'];assert all(not v['logs'] for v in d['results'])
 suites.append({'artifact':p.name,'sha256':sha(p),'scope':batch['scope'],'baseline_cases':batch['baseline_cases'],'status':'EXACT_SOURCE_AND_DATABASE_RECONCILIATION_VERIFIED'})
assert before=={str(p.resolve()):sha(p) for p in deps}
(OUT/'current-arktos-quick-evidence-reconciliation.json').write_text(json.dumps({'scope':'Read-only evidence reconciliation, no scenario reruns. Four historical Quick suites have exact current source/dependencies except proven name-only snapshot DB reconciliation; actual source metadata reader equals installed reader. Original artifacts unchanged. Source initially field remains an explicit fixture scope; Quick target/operation read field zones, not summon history. Separate actual native source Pendulum history exists in Normal/Special movement batches; no synthetic full-card/live Omega claim.','runtime_dependencies_sha256':before,'suites':suites},indent=2)+'\n',encoding='utf-8');print('Four existing Arktos Quick suites reconciled without rerunning scenarios')

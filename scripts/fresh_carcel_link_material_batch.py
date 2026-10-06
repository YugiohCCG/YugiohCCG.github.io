"""Verify canonical Lord of the Pyre's linked-monster stat behavior."""
import hashlib,json,subprocess,time
from pathlib import Path
ROOT=Path(__file__).resolve().parents[1];OUT=ROOT/'output/fresh-ccg-september'
def sha(p):return hashlib.sha256(p.read_bytes()).hexdigest()
subprocess.check_output(['python','scripts/fresh_public_card_data_adapter.py'],cwd=ROOT,text=True)
harness=ROOT/'scripts/fresh_carcel_link_material.cjs';hh=sha(harness)
source=ROOT/'public/CCG Downloads/CCG_Scripts/c259780273.lua';sh=sha(source)
deps=dict(json.loads((OUT/'pyre-zone-lock-batch.json').read_text(encoding='utf-8'))['runtime_dependencies_sha256'])
def verify():
 assert sha(source)==sh and sha(harness)==hh
 for p,h in deps.items():assert sha(ROOT/p)==h
rows=[]
for adapter,control in [(True,None),(True,'no-material-trigger'),(True,'wrong-counter-total')]:
 verify();start=time.time()
 args=['node','--no-warnings',str(harness),'--source=259780273','--target=259174227']
 if adapter:args+=['--card-data-adapter','--public-link-fixture-adapter']
 if control:args+=['--'+control]
 run=subprocess.run(args,cwd=ROOT,capture_output=True,text=True,timeout=30)
 p=OUT/('carcel-link-material-259780273-259174227'+('-card-data-adapter' if adapter else '')+'-public-link-fixture-adapter'+('-'+control if control else '')+'.json')
 assert p.stat().st_mtime>=start-2
 x=json.loads(p.read_text(encoding='utf-8'));assert x['script_sha256']==sh
 assert [r['test'] for r in x['results']]==[{},{'noRemainingOhmen':True},{'wrongRecipientSet':True}]
 expected=[{}, {'noRemainingOhmen':True}] if control else []
 assert [r['test'] for r in x['results'] if r['failure']]==expected
 assert run.returncode==(1 if expected else 0)
 verify();rows.append({'card_data_adapter':adapter,'control':control,'status':run.returncode,'expected_failures':expected,'artifact':p.name,'artifact_sha256':sha(p)})
(OUT/'carcel-link-material-batch.json').write_text(json.dumps({'scope':'Actual canonical Conductor Link Summon using canonical Carcel/Farad; Carcel optional material trigger targets new Conductor and places counters equal to remaining Ohmen (2 or1 including Conductor). Wrong-recipient-set negative and no-op/count mutations. Explicit missing-public-API adapters: empty must-material set, IsLinkType equals unmodified IsType on these fixtures. Other material reasons, HOPT and native Omega remain open',
 'script_sha256':sh,'harness_sha256':hh,'batch_script_sha256':sha(Path(__file__)),'runtime_dependencies_sha256':deps,'runs':rows},indent=2)+'\n',encoding='utf-8')
print(json.dumps({'baseline_cases':3,'runs':len(rows),'status':'PASS'}))

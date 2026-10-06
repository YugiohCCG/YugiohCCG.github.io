"""Verify canonical Lord of the Pyre's linked-monster stat behavior."""
import hashlib,json,subprocess,time
from pathlib import Path
ROOT=Path(__file__).resolve().parents[1];OUT=ROOT/'output/fresh-ccg-september'
def sha(p):return hashlib.sha256(p.read_bytes()).hexdigest()
subprocess.check_output(['python','scripts/fresh_public_card_data_adapter.py'],cwd=ROOT,text=True)
harness=ROOT/'scripts/fresh_beacon_grave_summon.cjs';hh=sha(harness)
source=ROOT/'public/CCG Downloads/CCG_Scripts/c259650969.lua';sh=sha(source)
deps=dict(json.loads((OUT/'pyre-zone-lock-batch.json').read_text(encoding='utf-8'))['runtime_dependencies_sha256'])
def verify():
 assert sha(source)==sh and sha(harness)==hh
 for p,h in deps.items():assert sha(ROOT/p)==h
rows=[]
for adapter,control in [(True,None),(True,'no-grave-summon'),(True,'any-support-set')]:
 verify();start=time.time()
 args=['node','--no-warnings',str(harness),'--source=259650969','--target=259174227']
 if adapter:args+=['--card-data-adapter']
 if control:args+=['--'+control]
 run=subprocess.run(args,cwd=ROOT,capture_output=True,text=True,timeout=30)
 p=OUT/('beacon-grave-summon-259650969-259174227'+('-card-data-adapter' if adapter else '')+('-'+control if control else '')+'.json')
 assert p.stat().st_mtime>=start-2
 x=json.loads(p.read_text(encoding='utf-8'));assert x['script_sha256']==sh
 assert [r['test'] for r in x['results']]==[{},{'noSupport':True},{'facedownSupport':True},{'wrongSupportSet':True},{'wrongSet':True},{'decline':True}]
 expected=[{}] if control=='no-grave-summon' else [{'wrongSupportSet':True}] if control else []
 assert [r['test'] for r in x['results'] if r['failure']]==expected
 assert run.returncode==(1 if expected else 0)
 verify();rows.append({'card_data_adapter':adapter,'control':control,'status':run.returncode,'expected_failures':expected,'artifact':p.name,'artifact_sha256':sha(p)})
(OUT/'beacon-grave-summon-batch.json').write_text(json.dumps({'scope':'Canonical Beacon actual optional GY revival of canonical Farad with face-up canonical Conductor prerequisite. Absent/face-down/wrong-set support, wrong-set recipient and decline negatives. No-operation/broad-support-set mutations. Initial support placement; proper Link summon, Necrovalley/count/responses/native Omega remain open',
 'script_sha256':sh,'harness_sha256':hh,'batch_script_sha256':sha(Path(__file__)),'runtime_dependencies_sha256':deps,'runs':rows},indent=2)+'\n',encoding='utf-8')
print(json.dumps({'baseline_cases':6,'runs':len(rows),'status':'PASS'}))

"""Verify canonical Lord of the Pyre's linked-monster stat behavior."""
import hashlib,json,subprocess,time
from pathlib import Path
ROOT=Path(__file__).resolve().parents[1];OUT=ROOT/'output/fresh-ccg-september'
def sha(p):return hashlib.sha256(p.read_bytes()).hexdigest()
subprocess.check_output(['python','scripts/fresh_public_card_data_adapter.py'],cwd=ROOT,text=True)
harness=ROOT/'scripts/fresh_beacon_target_protection.cjs';hh=sha(harness)
source=ROOT/'public/CCG Downloads/CCG_Scripts/c259650969.lua';sh=sha(source)
deps=dict(json.loads((OUT/'pyre-zone-lock-batch.json').read_text(encoding='utf-8'))['runtime_dependencies_sha256'])
def verify():
 assert sha(source)==sh and sha(harness)==hh
 for p,h in deps.items():assert sha(ROOT/p)==h
rows=[]
for adapter,control in [(True,None),(True,'no-target-protection'),(True,'ignore-target-counters')]:
 verify();start=time.time()
 args=['node','--no-warnings',str(harness),'--source=259650969','--target=259174227']
 if adapter:args+=['--card-data-adapter']
 if control:args+=['--'+control]
 run=subprocess.run(args,cwd=ROOT,capture_output=True,text=True,timeout=30)
 p=OUT/('beacon-target-protection-259650969-259174227'+('-card-data-adapter' if adapter else '')+('-'+control if control else '')+'.json')
 assert p.stat().st_mtime>=start-2
 x=json.loads(p.read_text(encoding='utf-8'));assert x['script_sha256']==sh
 assert [r['test'] for r in x['results']]==[{},{'noCounter':True},{'noCoLink':True},{'sourceLeaves':True}]
 expected=[{}] if control=='no-target-protection' else [{'noCounter':True}] if control else []
 assert [r['test'] for r in x['results'] if r['failure']]==expected
 assert run.returncode==(1 if expected else 0)
 verify();rows.append({'card_data_adapter':adapter,'control':control,'status':run.returncode,'expected_failures':expected,'artifact':p.name,'artifact_sha256':sha(p)})
(OUT/'beacon-target-protection-batch.json').write_text(json.dumps({'scope':'Canonical Beacon native target eligibility during actual own turn1/opponent turn2 Spell operations, canonical Conductor co-linked with Intensity. Own targeting permitted; opponent blocked only with counter/co-link/active source. No-counter/broken graph/source-leaves negatives, protection/counter mutations. Initial Link placement, actual target selection/HOPT/responses/native Omega remain open',
 'script_sha256':sh,'harness_sha256':hh,'batch_script_sha256':sha(Path(__file__)),'runtime_dependencies_sha256':deps,'runs':rows},indent=2)+'\n',encoding='utf-8')
print(json.dumps({'baseline_cases':4,'runs':len(rows),'status':'PASS'}))

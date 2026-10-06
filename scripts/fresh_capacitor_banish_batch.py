"""Verify canonical Lord of the Pyre's linked-monster stat behavior."""
import hashlib,json,subprocess,time
from pathlib import Path
ROOT=Path(__file__).resolve().parents[1];OUT=ROOT/'output/fresh-ccg-september'
def sha(p):return hashlib.sha256(p.read_bytes()).hexdigest()
subprocess.check_output(['python','scripts/fresh_public_card_data_adapter.py'],cwd=ROOT,text=True)
harness=ROOT/'scripts/fresh_capacitor_banish.cjs';hh=sha(harness)
source=ROOT/'public/CCG Downloads/CCG_Scripts/c259350270.lua';sh=sha(source)
deps=dict(json.loads((OUT/'pyre-zone-lock-batch.json').read_text(encoding='utf-8'))['runtime_dependencies_sha256'])
def verify():
 assert sha(source)==sh and sha(harness)==hh
 for p,h in deps.items():assert sha(ROOT/p)==h
rows=[]
for adapter,control in [(True,None),(True,'no-banish'),(True,'either-controller')]:
 verify();start=time.time()
 args=['node','--no-warnings',str(harness),'--source=259350270','--target=259174227']
 if adapter:args+=['--card-data-adapter']
 if control:args+=['--'+control]
 run=subprocess.run(args,cwd=ROOT,capture_output=True,text=True,timeout=30)
 p=OUT/('capacitor-banish-259350270-259174227'+('-card-data-adapter' if adapter else '')+('-'+control if control else '')+'.json')
 assert p.stat().st_mtime>=start-2
 x=json.loads(p.read_text(encoding='utf-8'));assert x['script_sha256']==sh
 assert [r['test'] for r in x['results']]==[{},{'noCounter':True},{'ownTarget':True},{'facedownTarget':True}]
 expected=[{}, {'facedownTarget':True}] if control=='no-banish' else [{'ownTarget':True}] if control else []
 assert [r['test'] for r in x['results'] if r['failure']]==expected
 assert run.returncode==(1 if expected else 0)
 verify();rows.append({'card_data_adapter':adapter,'control':control,'status':run.returncode,'expected_failures':expected,'artifact':p.name,'artifact_sha256':sha(p)})
(OUT/'capacitor-banish-batch.json').write_text(json.dumps({'scope':'Canonical Capacitor actual one-counter targeted face-up banish of opposing canonical Farad, originally face-up/face-down target; zero-counter and own-target negatives. No-operation/controller-range mutations. Initial source placement and neutral counter Spell. Native Omega, HOPT/timing/target-response cases remain open',
 'script_sha256':sh,'harness_sha256':hh,'batch_script_sha256':sha(Path(__file__)),'runtime_dependencies_sha256':deps,'runs':rows},indent=2)+'\n',encoding='utf-8')
print(json.dumps({'baseline_cases':4,'runs':len(rows),'status':'PASS'}))

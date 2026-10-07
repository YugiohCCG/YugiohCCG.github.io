"""Reproduce the public wrapper boundary and verify Release's once-face-up limit."""
import hashlib,json,subprocess,time
from pathlib import Path
ROOT=Path(__file__).resolve().parents[1];OUT=ROOT/'output/fresh-ccg-september'
def sha(p):return hashlib.sha256(p.read_bytes()).hexdigest()
generator=ROOT/'scripts/fresh_public_card_data_adapter.py'
generated=json.loads(subprocess.check_output(['python',str(generator)],cwd=ROOT,text=True))
harness=ROOT/'scripts/fresh_pyre_zone_lock_count.cjs';hh=sha(harness)
source=ROOT/'public/CCG Downloads/CCG_Scripts/c259883230.lua';sh=sha(source)
adapter=OUT/'public-core-card-data-adapter.mjs'
assert generated['adapter_sha256']==sha(adapter)
deps=dict(json.loads((OUT/'night-fright-batch.json').read_text(encoding='utf-8'))['runtime_dependencies_sha256'])
deps[str(adapter.relative_to(ROOT)).replace('\\','/')]=sha(adapter)
deps[str(generator.relative_to(ROOT)).replace('\\','/')]=sha(generator)
def verify():
 assert sha(source)==sh and sha(harness)==hh
 for p,h in deps.items():assert sha(ROOT/p)==h
rows=[]
for use_adapter,control,probe in [(False,None,True),(True,None,False),(True,'old-lock-limit',False)]:
 verify();start=time.time()
 args=['node','--no-warnings',str(harness),'--source=259883230','--target=259295979']
 if use_adapter:args+=['--card-data-adapter']
 if control:args+=['--'+control]
 if probe:args+=['--probe']
 run=subprocess.run(args,cwd=ROOT,capture_output=True,text=True,timeout=30)
 p=OUT/('pyre-zone-lock-259883230-259295979'+('-card-data-adapter' if use_adapter else '')+('-'+control if control else '')+'.json')
 assert p.stat().st_mtime>=start-2
 x=json.loads(p.read_text(encoding='utf-8'));assert x['script_sha256']==sh and len(x['results'])==1
 r=x['results'][0]
 if not use_adapter:
  assert r['failure']=='Initial Link zone-lock activation'
  assert any('markers=0' in v['message'] and 'zone1=0' in v['message'] for v in r['logs'])
 elif control:assert r['failure'].startswith('Zone lock remains consumed next own turn')
 else:assert r['failure'] is None
 assert run.returncode==(1 if control or not use_adapter else 0)
 verify();rows.append({'card_data_adapter':use_adapter,'control':control,'probe':probe,'status':run.returncode,'failure':r['failure'],'artifact':p.name,'artifact_sha256':sha(p)})
report={'scope':'Actual production Release lock activation/count, neutral Pyre Link metadata and test-only public WASM card-data adapter. Raw wrapper loses Link marker; adapted run consumes limit across own turn 3. Native Omega, target resets, source reset and other effects open.',
        'script_sha256':sh,'harness_sha256':hh,'batch_script_sha256':sha(Path(__file__)),
        'runtime_dependencies_sha256':deps,'adapter_generation':generated,'runs':rows}
(OUT/'pyre-zone-lock-batch.json').write_text(json.dumps(report,indent=2)+'\n',encoding='utf-8')
print(json.dumps({'baseline_cases':1,'runs':len(rows),'status':'PASS','native_omega_verified':False}))

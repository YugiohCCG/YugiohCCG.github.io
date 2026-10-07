"""Verify canonical Lord of the Pyre's linked-monster stat behavior."""
import hashlib,json,subprocess,time
from pathlib import Path
ROOT=Path(__file__).resolve().parents[1];OUT=ROOT/'output/fresh-ccg-september'
def sha(p):return hashlib.sha256(p.read_bytes()).hexdigest()
subprocess.check_output(['python','scripts/fresh_public_card_data_adapter.py'],cwd=ROOT,text=True)
harness=ROOT/'scripts/fresh_ohmen_linked_followup.cjs';hh=sha(harness)
sources={c:ROOT/f'public/CCG Downloads/CCG_Scripts/c{c}.lua' for c in [259174227,259726853]};hashes={c:sha(p) for c,p in sources.items()}
deps=dict(json.loads((OUT/'pyre-zone-lock-batch.json').read_text(encoding='utf-8'))['runtime_dependencies_sha256'])
def verify():
 assert all(sha(p)==hashes[c] for c,p in sources.items()) and sha(harness)==hh
 for p,h in deps.items():assert sha(ROOT/p)==h
rows=[]
for card in sources:
 for adapter,control in [(True,None),(True,'no-followup'),(True,'any-followup-race')]:
  verify();start=time.time()
  args=['node','--no-warnings',str(harness),f'--source={card}','--target=259295979']
  if adapter:args+=['--card-data-adapter']
  if control:args+=['--'+control]
  run=subprocess.run(args,cwd=ROOT,capture_output=True,text=True,timeout=30)
  p=OUT/(f'ohmen-linked-followup-{card}-259295979'+('-card-data-adapter' if adapter else '')+('-'+control if control else '')+'.json')
  assert p.stat().st_mtime>=start-2
  x=json.loads(p.read_text(encoding='utf-8'));assert x['script_sha256']==hashes[card]
  assert [r['test'] for r in x['results']]==[{},{'wrongRace':True},{'wrongLocation':True},{'noLink':True}]
  expected=[{}] if control=='no-followup' else [{'wrongRace':True}] if control else []
  assert [r['test'] for r in x['results'] if r['failure']]==expected
  assert run.returncode==(1 if expected else 0)
  verify();rows.append({'passcode':card,'card_data_adapter':adapter,'control':control,'status':run.returncode,'expected_failures':expected,'artifact':p.name,'artifact_sha256':sha(p)})
(OUT/'ohmen-linked-followup-family-batch.json').write_text(json.dumps({'scope':'Canonical Farad/Volt inherent Special Summon, network movement and Thunder revival/hand summon into remaining linked zone. Neutral Link terminal and Thunder recipient, wrong race/location/no-Link controls and two broken-source variants per card. Multi-Link traversal, counter totals, native Omega and full audit remain open.',
 'source_scripts_sha256':hashes,'harness_sha256':hh,'batch_script_sha256':sha(Path(__file__)),'runtime_dependencies_sha256':deps,'runs':rows},indent=2)+'\n',encoding='utf-8')
print(json.dumps({'baseline_cases':8,'runs':len(rows),'status':'PASS'}))

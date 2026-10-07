"""Verify actual on-field ignition searches and their shared counterexamples."""
import hashlib,json,subprocess,time
from pathlib import Path
ROOT=Path(__file__).resolve().parents[1];OUT=ROOT/'output/fresh-ccg-september'
def sha(p):return hashlib.sha256(p.read_bytes()).hexdigest()
harness=ROOT/'scripts/fresh_field_search_family.cjs';hh=sha(harness)
deps=json.loads((OUT/'night-fright-batch.json').read_text(encoding='utf-8'))['runtime_dependencies_sha256']
db=OUT/'candidate-CCG_v1.db';dh=sha(db)
def verify():
 assert sha(harness)==hh and sha(db)==dh
 for p,h in deps.items():assert sha(ROOT/p)==h
rows=[]
for source,target in [(259883230,259295979),(259253329,259537607)]:
 sp=ROOT/f'public/CCG Downloads/CCG_Scripts/c{source}.lua';tp=ROOT/f'public/CCG Downloads/CCG_Scripts/c{target}.lua';sh=sha(sp);th=sha(tp)
 for control in [None,'no-search','any-search-filter','old-field-condition' if source==259883230 else 'no-destroy']:
  verify();start=time.time();p=OUT/f"field-search-{source}-{target}{'-'+control if control else ''}.json"
  run=subprocess.run(['node','--no-warnings',str(harness),f'--source={source}',f'--target={target}']+(['--'+control] if control else []),cwd=ROOT,capture_output=True,text=True,timeout=30)
  assert p.stat().st_mtime>=start-2
  x=json.loads(p.read_text(encoding='utf-8'));assert x['script_sha256']==sh and x['supporting_script_sha256']==th
  assert [r['test'] for r in x['results']]==[{},{'wrongSet':True},{'wrongField':True},{'facedownField':True},{'opponentField':True}]
  expected=[{}] if control in ['no-search','no-destroy'] else [{'wrongSet':True}] if control=='any-search-filter' else [{'facedownField':True}] if control=='old-field-condition' else []
  assert [r['test'] for r in x['results'] if r['failure']]==expected
  assert run.returncode==(1 if control else 0)
  verify();assert sha(sp)==sh and sha(tp)==th
  rows.append({'source':source,'target':target,'control':control,'source_sha256':sh,'target_sha256':th,'artifact':p.name,'artifact_sha256':sha(p),'expected_failures':expected,'status':run.returncode})
report={'scope':'Full production source/canonical target Lua and metadata. Actual field ignition search, wrong-set/field/face-down/opponent negatives. Vaylantz verifies Pendulum destruction into Extra Deck. Other effects, counts/locks/native Omega open.',
        'harness_sha256':hh,'batch_script_sha256':sha(Path(__file__)),'candidate_database_sha256':dh,'runtime_dependencies_sha256':deps,'runs':rows}
(OUT/'field-search-family-batch.json').write_text(json.dumps(report,indent=2)+'\n',encoding='utf-8')
print(json.dumps({'cards':2,'baseline_cases':10,'runs':len(rows),'status':'PASS'}))

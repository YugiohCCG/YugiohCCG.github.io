"""Diagnostic routing batch. Eligibility queries are not effect verification."""
import json,subprocess,hashlib,time
from pathlib import Path
ROOT=Path(__file__).resolve().parents[1]
OUT=ROOT/'output/fresh-ccg-september'
def sha(p):return hashlib.sha256(p.read_bytes()).hexdigest()
def main():
 review=json.loads((OUT/'restricted-support-review.json').read_text(encoding='utf-8'))
 harness=ROOT/'scripts/fresh_restricted_support_probe.cjs';hh=sha(harness)
 prior=json.loads((OUT/'night-fright-batch.json').read_text(encoding='utf-8'))
 deps=prior['runtime_dependencies_sha256'];db=OUT/'candidate-CCG_v1.db';dh=sha(db)
 def verify():
  assert sha(harness)==hh and sha(db)==dh
  for p,h in deps.items():assert sha(ROOT/p)==h,p
 rows=[]
 for c in review['cards']:
  if c['classification']!='restricted support interaction remains priority':continue
  for t in c['supporting_scripts']:
   source=c['passcode'];target=t['passcode'];p=OUT/f'restricted-probe-{source}-{target}.json'
   sp=ROOT/f'public/CCG Downloads/CCG_Scripts/c{source}.lua';tp=ROOT/f'public/CCG Downloads/CCG_Scripts/c{target}.lua'
   assert sha(sp)==c['script_sha256'] and sha(tp)==t['script_sha256'];verify();start=time.time()
   run=subprocess.run(['node','--no-warnings',str(harness),f'--source={source}',f'--target={target}'],cwd=ROOT,capture_output=True,text=True,timeout=30)
   assert p.stat().st_mtime>=start-2
   x=json.loads(p.read_text(encoding='utf-8'));assert x['script_sha256']==c['script_sha256'];assert x['supporting_script_sha256']==t['script_sha256']
   assert len(x['results']) in [3,4]
   assert run.returncode==(1 if any(r['failure'] for r in x['results']) else 0)
   rs=[]
   for r in x['results']:
    hints=[h for h in r['eligibility_hints'] if h['hint_type']==9]
    if not r['failure']:assert len(hints)==1 and hints[0]['hint'] in ['0','1']
    rs.append({'location':r['test']['source'],'failure':r['failure'],'eligible':None if r['failure'] else hints[0]['hint']=='1'})
   verify();assert sha(sp)==c['script_sha256'] and sha(tp)==t['script_sha256']
   rows.append({'source':source,'target':target,'source_sha256':c['script_sha256'],'target_sha256':t['script_sha256'],'artifact_sha256':sha(p),'results':rs})
 report={'scope':'Diagnostic generic summon-type-zero eligibility with unregistered source-handler effect. Full scripts loaded. Extra Deck cards use Extra/GY/banishment; no actual proper summon before GY/banishment. No actual source activation, cost, summon or procedure. Public engine only. Successful probe execution is not card PASS/fix/completion.', 'harness_sha256':hh,'batch_script_sha256':sha(Path(__file__)),'candidate_database_sha256':dh,'runtime_dependencies_sha256':deps,'runs':rows}
 (OUT/'restricted-support-probe-batch.json').write_text(json.dumps(report,indent=2)+'\n',encoding='utf-8')
 print(json.dumps({'pairs':len(rows),'scenarios':sum(len(r['results']) for r in rows),'blocked':sum(bool(v['failure']) for r in rows for v in r['results']),'eligible':sum(v['eligible'] is True for r in rows for v in r['results'])}))
if __name__=='__main__':main()

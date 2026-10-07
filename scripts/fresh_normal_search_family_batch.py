"""Diagnostic routing batch. Eligibility queries are not effect verification."""
import json,subprocess,hashlib,time
from pathlib import Path
ROOT=Path(__file__).resolve().parents[1]
OUT=ROOT/'output/fresh-ccg-september'
def sha(p):return hashlib.sha256(p.read_bytes()).hexdigest()
def main():
 review=json.loads((OUT/'restricted-support-review.json').read_text(encoding='utf-8'))
 harness=ROOT/'scripts/fresh_normal_search_family.cjs';hh=sha(harness)
 prior=json.loads((OUT/'night-fright-batch.json').read_text(encoding='utf-8'))
 deps=prior['runtime_dependencies_sha256'];db=OUT/'candidate-CCG_v1.db';dh=sha(db)
 def verify():
  assert sha(harness)==hh and sha(db)==dh
  for p,h in deps.items():assert sha(ROOT/p)==h,p
 rows=[]
 for source,target in [(230749983,215621622),(237269434,210366076),(232232676,229499914),(220150285,238035167),(238272434,238272435),(241440521,214511076),(241868535,231872299),(254375894,210366076),(259135917,259337739),(259377794,259337739),(259686203,259337739),(259466138,259562343),(228926678,233759343),(230947464,210506870),(232104829,224235021),(240768497,224235021),(241880822,234507067)]:
  sp=ROOT/f'public/CCG Downloads/CCG_Scripts/c{source}.lua';tp=ROOT/f'public/CCG Downloads/CCG_Scripts/c{target}.lua';sh=sha(sp);th=sha(tp)
  for control in ([None,'no-search'] if source==241868535 else [None,'no-search','any-search-filter']):
   p=OUT/f"normal-search-{source}-{target}{'-'+control if control else ''}.json"
   verify();start=time.time()
   run=subprocess.run(['node','--no-warnings',str(harness),f'--source={source}',f'--target={target}']+(['--'+control] if control else []),cwd=ROOT,capture_output=True,text=True,timeout=30)
   assert p.stat().st_mtime>=start-2
   x=json.loads(p.read_text(encoding='utf-8'));assert x['script_sha256']==sh and x['supporting_script_sha256']==th
   assert [r['test'] for r in x['results']]==([{}, {'decline':True}] if source==241868535 else [{}, {'decline':True},{'wrongSet':True}])
   assert [r['test'] for r in x['results'] if r['failure']]==([{}] if control=='no-search' else [{'wrongSet':True}] if control=='any-search-filter' else [])
   assert run.returncode==(1 if control else 0)
   verify();assert sha(sp)==sh and sha(tp)==th
   rows.append({'source':source,'target':target,'control':control,'source_sha256':sh,'target_sha256':th,'artifact_sha256':sha(p),'results':[{'test':r['test'],'failure':r['failure']} for r in x['results']]})
 report={'scope':'Full production source and canonical target scripts. Actual legal Normal Summon and Deck search accepted/declined. Shared no-search mutation must fail positive only. Other effects, locks/count/filter edges and native Omega open.', 'harness_sha256':hh,'batch_script_sha256':sha(Path(__file__)),'candidate_database_sha256':dh,'runtime_dependencies_sha256':deps,'runs':rows}
 (OUT/'normal-search-family-batch.json').write_text(json.dumps(report,indent=2)+'\n',encoding='utf-8')
 print(json.dumps({'cards':len({r['source'] for r in rows}),'baseline_cases':sum(len(r['results']) for r in rows if not r['control']),'runs':len(rows),'status':'PASS'}))
if __name__=='__main__':main()

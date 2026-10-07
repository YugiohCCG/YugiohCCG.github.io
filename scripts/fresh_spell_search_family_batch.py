"""Diagnostic routing batch. Eligibility queries are not effect verification."""
import json,subprocess,hashlib,time
from pathlib import Path
ROOT=Path(__file__).resolve().parents[1]
OUT=ROOT/'output/fresh-ccg-september'
def sha(p):return hashlib.sha256(p.read_bytes()).hexdigest()
def main():
 review=json.loads((OUT/'restricted-support-review.json').read_text(encoding='utf-8'))
 harness=ROOT/'scripts/fresh_spell_search_family.cjs';hh=sha(harness)
 prior=json.loads((OUT/'night-fright-batch.json').read_text(encoding='utf-8'))
 deps=prior['runtime_dependencies_sha256'];db=OUT/'candidate-CCG_v1.db';dh=sha(db)
 def verify():
  assert sha(harness)==hh and sha(db)==dh
  for p,h in deps.items():assert sha(ROOT/p)==h,p
 rows=[]
 for source,target in [(221509060,220150285),(233759343,228926678),(259391738,259113182),(259417461,259679619),(259679619,259273394),(247831166,218837030),(255953418,240976976),(244816828,255283389),(211086520,215984744),(258590942,214511076),(236744343,215984744),(258241424,240976976),(212055290,224467692),(234592047,221672256),(236551669,225106953),(284636586,284639717),(259758604,259489283)]:
  sp=ROOT/f'public/CCG Downloads/CCG_Scripts/c{source}.lua';tp=ROOT/f'public/CCG Downloads/CCG_Scripts/c{target}.lua';sh=sha(sp);th=sha(tp)
  for control in ([None,'no-search','any-search-filter','no-discard'] if source in [211086520,258590942] else [None,'no-search','any-search-filter']):
   p=OUT/f"spell-search-{source}-{target}{'-'+control if control else ''}.json"
   verify();start=time.time()
   run=subprocess.run(['node','--no-warnings',str(harness),f'--source={source}',f'--target={target}']+(['--'+control] if control else []),cwd=ROOT,capture_output=True,text=True,timeout=30)
   assert p.stat().st_mtime>=start-2
   x=json.loads(p.read_text(encoding='utf-8'));assert x['script_sha256']==sh and x['supporting_script_sha256']==th
   assert [r['test'] for r in x['results']]==[{}, {'wrongRace':True} if source==212055290 else {'wrongSet':True}]
   assert [r['test'] for r in x['results'] if r['failure']]==([{}] if control in ['no-search','no-discard'] else [{'wrongRace':True} if source==212055290 else {'wrongSet':True}] if control=='any-search-filter' else [])
   assert run.returncode==(1 if control else 0)
   verify();assert sha(sp)==sh and sha(tp)==th
   rows.append({'source':source,'target':target,'control':control,'source_sha256':sh,'target_sha256':th,'artifact_sha256':sha(p),'results':[{'test':r['test'],'failure':r['failure']} for r in x['results']]})
 report={'scope':'Full production source and canonical target scripts. Actual Spell activation and Deck search positive/wrong-set. Shared no-search mutation must fail positive only. Other effects, locks/count/filter edges and native Omega open.', 'harness_sha256':hh,'batch_script_sha256':sha(Path(__file__)),'candidate_database_sha256':dh,'runtime_dependencies_sha256':deps,'runs':rows}
 (OUT/'spell-search-family-batch.json').write_text(json.dumps(report,indent=2)+'\n',encoding='utf-8')
 print(json.dumps({'cards':len({r['source'] for r in rows}),'baseline_cases':sum(len(r['results']) for r in rows if not r['control']),'runs':len(rows),'status':'PASS'}))
if __name__=='__main__':main()

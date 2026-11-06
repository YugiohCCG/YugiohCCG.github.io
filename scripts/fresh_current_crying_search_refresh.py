"""Refresh two existing search fixtures; retain historical artifact bytes exactly."""
import hashlib,json,sqlite3,subprocess
from pathlib import Path
ROOT=Path(__file__).resolve().parents[1];OUT=ROOT/'output/fresh-ccg-september';FILES=Path(r'C:\Program Files (x86)\YGO Omega\YGO Omega_Data\Files')
def sha(p):return hashlib.sha256(p.read_bytes()).hexdigest()
old=json.loads((OUT/'spell-search-family-batch.json').read_text());harness=ROOT/'scripts/fresh_spell_search_family.cjs';assert sha(harness)==old['harness_sha256'];a=sqlite3.connect(OUT/'candidate-CCG_v1.db');b=sqlite3.connect(FILES/'Databases/CCG_v1.db')
for code in [258241424,255953418,240976976]:assert a.execute('select * from datas where id=?',(code,)).fetchone()==b.execute('select * from datas where id=?',(code,)).fetchone()
paths=[ROOT/k for k in old['runtime_dependencies_sha256']]+[harness,Path(__file__),ROOT/'scripts/fresh_candidate_card.cjs',OUT/'candidate-CCG_v1.db',FILES/'Databases/CCG_v1.db',ROOT/'src/data/cards.json']+[ROOT/f'public/CCG Downloads/CCG_Scripts/c{code}.lua' for code in [258241424,255953418,240976976]];before={str(p):sha(p) for p in paths};backup=OUT/'crying-search-refresh-historical-artifacts';backup.mkdir(exist_ok=True);runs=[]
for source in [258241424,255953418]:
 assert (ROOT/f'public/CCG Downloads/CCG_Scripts/c{source}.lua').read_bytes()==(FILES/f'Scripts/c{source}.lua').read_bytes()
 for control in [None,'no-search','any-search-filter']:
  filename=f"spell-search-{source}-240976976{'-'+control if control else ''}.json";p=OUT/filename;original=p.read_bytes();saved=backup/filename
  if saved.exists():assert saved.read_bytes()==original
  else:saved.write_bytes(original)
  prior=next(v for v in old['runs'] if v['source']==source and v['target']==240976976 and v['control']==control);assert hashlib.sha256(original).hexdigest()==prior['artifact_sha256']
  try:
   r=subprocess.run(['node','--no-warnings',str(harness),f'--source={source}','--target=240976976']+(['--'+control] if control else []),cwd=ROOT,capture_output=True,text=True,timeout=30);d=json.loads(p.read_text());expected=[] if control is None else [{}] if control=='no-search' else [{'wrongSet':True}];assert [v['test'] for v in d['results'] if v['failure']]==expected,(r.stdout,r.stderr);assert r.returncode==(0 if control is None else 1);assert not any(v['logs'] for v in d['results']);fresh=OUT/f"current-crying-search-refresh-{source}{'-'+control if control else ''}.json";fresh.write_bytes(p.read_bytes());runs.append({'source':source,'control':control,'file':fresh.name,'sha256':sha(fresh),'expected_failures':expected,'historical_file':filename,'historical_sha256':hashlib.sha256(original).hexdigest()})
  finally:p.write_bytes(original)
  assert p.read_bytes()==original
assert before=={str(p):sha(p) for p in paths}
report={'status':'CURRENT_METADATA_SEARCH_EVIDENCE_REFRESHED_NO_REPAIR','finding':'Four original Light/World search cases pass under the existing unchanged harness with current candidate actor/target datas exactly equal to installed datas. Existing no-search and any-filter controls each fail two expected outcomes. Historical output bytes restored and archived exactly after each run.','qualification':'Full original source/target scripts; current candidate/installed actor data equality does not turn the older DB-pin mismatch into a current-provenance pass. Fresh artifacts have new names and exact current dependency pins. Search-only scope: GY effect/World Synchro trigger/other filter boundaries/limits/reset/live Omega remain open; no production changes or broad gates.','historical_candidate_database_sha256':old['candidate_database_sha256'],'current_candidate_database_sha256':sha(OUT/'candidate-CCG_v1.db'),'runs':runs,'runtime_dependencies_sha256':before}
(OUT/'current-crying-search-refresh-review.json').write_text(json.dumps(report,indent=2)+'\n');print(json.dumps({'baseline_cases':4,'runs':len(runs),'historical_artifacts_preserved':True,'production_edits':False}))

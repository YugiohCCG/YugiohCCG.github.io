"""Original-effect delayed group tracking regression and exact repair manifest."""
import hashlib,json,subprocess
from pathlib import Path
ROOT=Path(__file__).resolve().parents[1];OUT=ROOT/'output/fresh-ccg-september';FILES=Path(r'C:\Program Files (x86)\YGO Omega\YGO Omega_Data\Files')
def sha(p):return hashlib.sha256(p.read_bytes()).hexdigest()
def corrected(p,code):
 return subprocess.run(['node','-e',"process.stdout.write(require('./scripts/fresh_destruction_origin_repair.cjs').corrected(require('fs').readFileSync(process.argv[1],'utf8'),Number(process.argv[2])))",str(p),str(code)],cwd=ROOT,capture_output=True,check=True).stdout
def main():
 backup=OUT/'destruction-origin-before-repair';manifest=OUT/'destruction-origin-repair-files.json';items=[]
 if manifest.exists():items=json.loads(manifest.read_text())['files']
 else:
  backup.mkdir(exist_ok=True)
  for code in [224049334,214552846]:
   p=ROOT/f'public/CCG Downloads/CCG_Scripts/c{code}.lua';installed=FILES/'Scripts'/p.name;assert p.read_bytes()==installed.read_bytes()
   for src,dest in [(p,backup/p.name),(installed,backup/('installed-'+p.name))]:
    if dest.exists():assert dest.read_bytes()==src.read_bytes()
    else:dest.write_bytes(src.read_bytes())
   new=corrected(p,code);items.append({'passcode':code,'file':p.name,'backup':backup.name,'before_sha256':sha(p),'after_sha256':hashlib.sha256(new).hexdigest(),'helper':'fresh_destruction_origin_repair.cjs'})
 paths=[ROOT/'scripts'/n for n in ['fresh_current_solemn_rebirth_origin.cjs','fresh_destruction_origin_repair.cjs','fresh_installed_card.cjs','fresh_corrected_card_data_transport.cjs']]+[ROOT/'tmp/omega_scripts'/n for n in ['constant.lua','utility.lua','procedure.lua','c54974237.lua']]+[FILES/'Databases/CCG_v1.db']+[backup/i['file'] for i in items]+list((ROOT/'node_modules/@n1xx1/ocgcore-wasm/dist').glob('*.js'))+[ROOT/'node_modules/@n1xx1/ocgcore-wasm/dist/index-card-data-transport-candidate.mjs']
 pins={str(p.resolve()):sha(p) for p in paths};runs=[]
 for mode,failures in [('candidate',[]),('old',[0,3]),('ignore-player',[2]),('no-outcome',[0,1,3,4]),('no-cost',[0,1])]:
  subprocess.run(['node','--no-warnings','scripts/fresh_current_solemn_rebirth_origin.cjs',mode],cwd=ROOT,capture_output=True,check=True,timeout=20)
  p=OUT/f'current-solemn-rebirth-origin-{mode}.json';d=json.loads(p.read_text());assert len(d['results'])==5 and [i for i,x in enumerate(d['results']) if x['failure']]==failures and all(not x['logs'] for x in d['results'])
  runs.append({'mode':mode,'file':p.name,'sha256':sha(p),'expected_failures':failures})
 assert pins=={str(p.resolve()):sha(p) for p in paths}
 if not manifest.exists():
  for i in items:
   p=ROOT/'public/CCG Downloads/CCG_Scripts'/i['file'];installed=FILES/'Scripts'/p.name;assert sha(p)==sha(installed)==i['before_sha256'];new=corrected(backup/p.name,i['passcode']);assert hashlib.sha256(new).hexdigest()==i['after_sha256'];p.write_bytes(new);installed.write_bytes(new)
  manifest.write_text(json.dumps({'files':items},indent=2)+'\n')
 for i in items:assert sha(ROOT/'public/CCG Downloads/CCG_Scripts'/i['file'])==sha(FILES/'Scripts'/i['file'])==i['after_sha256']
 report={'finding':'Solemn Rebirth tracker and Eldora destroyed-to-GY trigger incorrectly required previous field location although printed clauses do not restrict origin. Both now include hand destruction.','qualification':'Five original-effect/full stock Virus cases: Hand/field positives for both cards and Solemn own-effect exclusion. Actual seeded DARK2500 vanilla Tribute; original Rebirth banishment/Set and Eldora target/matching-monster destruction. Negative seeds an owned Spell under opponent control; no takeover/summon procedure certification. No Lua API mapping. Deck destruction, capacity/Valley/other clauses/full-card/live open. Initial excluded Heavy Storm attempt hit known helper IsRelateToChain incompatibility; not retried or adapted.','runtime_dependencies_sha256':pins,'runs':runs,'manifest':manifest.name,'manifest_sha256':sha(manifest),'helper_sha256':sha(ROOT/'scripts/fresh_destruction_origin_repair.cjs'),'family_scan':'current-destruction-origin-family-scan.json','family_scan_sha256':sha(OUT/'current-destruction-origin-family-scan.json')}
 (OUT/'current-destruction-origin-review.json').write_text(json.dumps(report,indent=2)+'\n');print(json.dumps({'status':'REPAIRED_SOURCE_AND_INSTALLED','cards':2,'cases':5,'old_failures':2}))
if __name__=='__main__':main()

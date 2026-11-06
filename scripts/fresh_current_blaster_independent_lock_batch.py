"""Bounded delayed-return regression and exact source/install repair evidence."""
import hashlib,json,subprocess
from pathlib import Path
ROOT=Path(__file__).resolve().parents[1];OUT=ROOT/'output/fresh-ccg-september'
FILES=Path(r'C:\Program Files (x86)\YGO Omega\YGO Omega_Data\Files')
def sha(p):return hashlib.sha256(p.read_bytes()).hexdigest()
def main():
 source=ROOT/'public/CCG Downloads/CCG_Scripts/c243488958.lua';installed=FILES/'Scripts'/source.name
 backup=OUT/'blaster-independent-lock-before-repair';manifest=OUT/'blaster-independent-lock-repair-files.json'
 if not manifest.exists():
  assert source.read_bytes()==installed.read_bytes()
  backup.mkdir(exist_ok=True)
  for p in [source,installed]:
   dest=backup/(('installed-' if p==installed else '')+p.name)
   if dest.exists():assert dest.read_bytes()==p.read_bytes()
   else:dest.write_bytes(p.read_bytes())
  r=subprocess.run(['node','-e',"process.stdout.write(require('./scripts/fresh_blaster_independent_lock_repair.cjs').corrected(require('fs').readFileSync(process.argv[1],'utf8')))",str(source)],cwd=ROOT,capture_output=True,check=True)
  item={'passcode':243488958,'file':source.name,'backup':backup.name,'before_sha256':sha(source),'after_sha256':hashlib.sha256(r.stdout).hexdigest(),'helper':'fresh_blaster_independent_lock_repair.cjs'}
 else:item=json.loads(manifest.read_text())['files'][0]
 paths=[ROOT/'scripts'/n for n in ['fresh_current_blaster_independent_lock.cjs','fresh_blaster_independent_lock_repair.cjs','fresh_installed_card.cjs','fresh_corrected_card_data_transport.cjs']]+[ROOT/'tmp/omega_scripts'/n for n in ['constant.lua','utility.lua','procedure.lua']]+[FILES/'Databases/CCG_v1.db',backup/source.name]+list((ROOT/'node_modules/@n1xx1/ocgcore-wasm/dist').glob('*.js'))+[ROOT/'node_modules/@n1xx1/ocgcore-wasm/dist/index-card-data-transport-candidate.mjs']
 pins={str(p.resolve()):sha(p) for p in paths};runs=[]
 for mode,failures in [('candidate',[]),('old',[1]),('no-lock',[0,1]),('early-lock',[2,3]),('no-destroy',[0,2])]:
  subprocess.run(['node','--no-warnings','scripts/fresh_current_blaster_independent_lock.cjs',mode],cwd=ROOT,capture_output=True,check=True,timeout=20)
  p=OUT/f'current-blaster-independent-lock-{mode}.json';d=json.loads(p.read_text());assert len(d['results'])==4
  assert [i for i,x in enumerate(d['results']) if x['failure']]==failures and all(not x['logs'] for x in d['results'])
  runs.append({'mode':mode,'file':p.name,'sha256':sha(p),'expected_failures':failures})
 assert pins=={str(p.resolve()):sha(p) for p in paths}
 if not manifest.exists():
  assert sha(source)==sha(installed)==item['before_sha256']
  source.write_bytes(r.stdout);installed.write_bytes(r.stdout)
  manifest.write_text(json.dumps({'files':[item]},indent=2)+'\n')
 assert sha(source)==sha(installed)==item['after_sha256']
 report={'finding':'Scarstech Blaster wrongly required target destruction for the independent Also same-name lock. Lock now applies at Chain Link7+ even when late protection prevents destruction.','qualification':'Four original field-set source cases at actual CL6/CL7, actual late-protection CL7/CL8 response, two distinct same-code field recipients and next-player-turn availability. Unrelated opponent effect stays usable. Neutral actors/recipients,no Lua API mapping. Hand permission,departed target,negation/aliases/full-card/live remain open. Primary conjunction rule applied to custom wording.','runtime_dependencies_sha256':pins,'runs':runs,'manifest':manifest.name,'manifest_sha256':sha(manifest),'helper_sha256':sha(ROOT/'scripts'/item['helper']),'family_scan':'current-destroy-also-family-review.json','family_scan_sha256':sha(OUT/'current-destroy-also-family-review.json')}
 (OUT/'current-blaster-independent-lock-review.json').write_text(json.dumps(report,indent=2)+'\n')
 print(json.dumps({'status':'REPAIRED_SOURCE_AND_INSTALLED','cases':4,'old_missing_independent_lock':1}))
if __name__=='__main__':main()

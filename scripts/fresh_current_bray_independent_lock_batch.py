"""Bounded delayed-return regression and exact source/install repair evidence."""
import hashlib,json,subprocess
from pathlib import Path
ROOT=Path(__file__).resolve().parents[1];OUT=ROOT/'output/fresh-ccg-september'
FILES=Path(r'C:\Program Files (x86)\YGO Omega\YGO Omega_Data\Files')
def sha(p):return hashlib.sha256(p.read_bytes()).hexdigest()
def main():
 source=ROOT/'public/CCG Downloads/CCG_Scripts/c212822164.lua';installed=FILES/'Scripts'/source.name
 backup=OUT/'bray-independent-lock-before-repair';manifest=OUT/'bray-independent-lock-repair-files.json'
 if not manifest.exists():
  assert source.read_bytes()==installed.read_bytes()
  backup.mkdir(exist_ok=True)
  for p in [source,installed]:
   dest=backup/(('installed-' if p==installed else '')+p.name)
   if dest.exists():assert dest.read_bytes()==p.read_bytes()
   else:dest.write_bytes(p.read_bytes())
  r=subprocess.run(['node','-e',"process.stdout.write(require('./scripts/fresh_bray_independent_lock_repair.cjs').corrected(require('fs').readFileSync(process.argv[1],'utf8')))",str(source)],cwd=ROOT,capture_output=True,check=True)
  item={'passcode':212822164,'file':source.name,'backup':backup.name,'before_sha256':sha(source),'after_sha256':hashlib.sha256(r.stdout).hexdigest(),'helper':'fresh_bray_independent_lock_repair.cjs'}
 else:item=json.loads(manifest.read_text())['files'][0]
 paths=[ROOT/'scripts'/n for n in ['fresh_current_bray_independent_lock.cjs','fresh_bray_independent_lock_repair.cjs','fresh_installed_card.cjs','fresh_corrected_card_data_transport.cjs']]+[ROOT/'tmp/omega_scripts'/n for n in ['constant.lua','utility.lua','procedure.lua']]+[FILES/'Databases/CCG_v1.db',backup/source.name]+list((ROOT/'node_modules/@n1xx1/ocgcore-wasm/dist').glob('*.js'))+[ROOT/'node_modules/@n1xx1/ocgcore-wasm/dist/index-card-data-transport-candidate.mjs']
 pins={str(p.resolve()):sha(p) for p in paths};runs=[]
 for mode,failures in [('candidate',[]),('old',[1,2]),('no-lock',[0,1,2]),('no-reset',[0,1,2]),('all-races',[3])]:
  subprocess.run(['node','--no-warnings','scripts/fresh_current_bray_independent_lock.cjs',mode],cwd=ROOT,capture_output=True,check=True,timeout=20)
  p=OUT/f'current-bray-independent-lock-{mode}.json';d=json.loads(p.read_text());assert len(d['results'])==5
  assert [i for i,x in enumerate(d['results']) if x['failure']]==failures and all(not x['logs'] for x in d['results'])
  runs.append({'mode':mode,'file':p.name,'sha256':sha(p),'expected_failures':failures})
 assert pins=={str(p.resolve()):sha(p) for p in paths}
 if not manifest.exists():
  assert sha(source)==sha(installed)==item['before_sha256']
  source.write_bytes(r.stdout);installed.write_bytes(r.stdout)
  manifest.write_text(json.dumps({'files':[item]},indent=2)+'\n')
 assert sha(source)==sha(installed)==item['after_sha256']
 report={'finding':'Bray incorrectly gated independent Also Fish-only summon restriction on first banishment/source relation. Register restriction independently before resolving dependent banishment operations.', 'qualification':'Five original seeded-source native cases:normal banishment,late native banishment prohibition,source departure,Fish exception,effect negation;actual non-Fish/Fish summon availability and own-turn3 reset/results checked. Neutral responders/probes,no API mapping. Original Synchro procedure,protection,named use/other boundaries/live/full-card open. Historical source-departure no-lock expectation superseded,not reused.', 'runtime_dependencies_sha256':pins,'runs':runs,'manifest':manifest.name,'manifest_sha256':sha(manifest),'helper_sha256':sha(ROOT/'scripts'/item['helper']),'family_scan':'current-bray-independent-lock-family-review.json','family_scan_sha256':sha(OUT/'current-bray-independent-lock-family-review.json')}
 (OUT/'current-bray-independent-lock-review.json').write_text(json.dumps(report,indent=2)+'\n')
 print(json.dumps({'status':'REPAIRED_SOURCE_AND_INSTALLED','cases':5,'old_missing_independent_lock':2}))
if __name__=='__main__':main()

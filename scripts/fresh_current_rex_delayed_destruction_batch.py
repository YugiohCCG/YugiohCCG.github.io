"""Bounded delayed-return regression and exact source/install repair evidence."""
import hashlib,json,subprocess
from pathlib import Path
ROOT=Path(__file__).resolve().parents[1];OUT=ROOT/'output/fresh-ccg-september'
FILES=Path(r'C:\Program Files (x86)\YGO Omega\YGO Omega_Data\Files')
def sha(p):return hashlib.sha256(p.read_bytes()).hexdigest()
def main():
 source=ROOT/'public/CCG Downloads/CCG_Scripts/c236898203.lua';installed=FILES/'Scripts'/source.name
 backup=OUT/'rex-delayed-destruction-before-repair';manifest=OUT/'rex-delayed-destruction-repair-files.json'
 if not manifest.exists():
  assert source.read_bytes()==installed.read_bytes()
  backup.mkdir(exist_ok=True)
  for p in [source,installed]:
   dest=backup/(('installed-' if p==installed else '')+p.name)
   if dest.exists():assert dest.read_bytes()==p.read_bytes()
   else:dest.write_bytes(p.read_bytes())
  r=subprocess.run(['node','-e',"process.stdout.write(require('./scripts/fresh_rex_delayed_destruction_repair.cjs').corrected(require('fs').readFileSync(process.argv[1],'utf8')))",str(source)],cwd=ROOT,capture_output=True,check=True)
  item={'passcode':236898203,'file':source.name,'backup':backup.name,'before_sha256':sha(source),'after_sha256':hashlib.sha256(r.stdout).hexdigest(),'helper':'fresh_rex_delayed_destruction_repair.cjs'}
 else:item=json.loads(manifest.read_text())['files'][0]
 paths=[ROOT/'scripts'/n for n in ['fresh_current_rex_delayed_destruction.cjs','fresh_rex_delayed_destruction_repair.cjs','fresh_installed_card.cjs','fresh_corrected_card_data_transport.cjs']]+[ROOT/'tmp/omega_scripts'/n for n in ['constant.lua','utility.lua','procedure.lua']]+[FILES/'Databases/CCG_v1.db',backup/source.name]+list((ROOT/'node_modules/@n1xx1/ocgcore-wasm/dist').glob('*.js'))+[ROOT/'node_modules/@n1xx1/ocgcore-wasm/dist/index-card-data-transport-candidate.mjs']
 pins={str(p.resolve()):sha(p) for p in paths};runs=[]
 for mode,failures in [('candidate',[]),('old',[1,2,3,5,6,7]),('no-tracking',[1,2,3,5,6,7]),('no-destroy',[0,4])]:
  subprocess.run(['node','--no-warnings','scripts/fresh_current_rex_delayed_destruction.cjs',mode],cwd=ROOT,capture_output=True,check=True,timeout=20)
  p=OUT/f'current-rex-delayed-destruction-{mode}.json';d=json.loads(p.read_text());assert len(d['results'])==8
  assert [i for i,x in enumerate(d['results']) if x['failure']]==failures and all(not x['logs'] for x in d['results'])
  runs.append({'mode':mode,'file':p.name,'sha256':sha(p),'expected_failures':failures})
 diagnostics=[]
 for mode in ['old','candidate']:
  subprocess.run(['node','--no-warnings','scripts/fresh_current_rex_delayed_destruction.cjs',mode,'--main1-diagnostic'],cwd=ROOT,capture_output=True,check=True,timeout=20)
  p=OUT/f'current-rex-delayed-destruction-{mode}-main1-diagnostic.json';d=json.loads(p.read_text());assert len(d['results'])==4 and [i for i,x in enumerate(d['results']) if x['failure']]==[0] and all(not x['logs'] for x in d['results']);diagnostics.append({'mode':mode,'file':p.name,'sha256':sha(p),'expected_failures':[0]})
 assert pins=={str(p.resolve()):sha(p) for p in paths}
 if not manifest.exists():
  assert sha(source)==sha(installed)==item['before_sha256']
  source.write_bytes(r.stdout);installed.write_bytes(r.stdout)
  manifest.write_text(json.dumps({'files':[item]},indent=2)+'\n')
 assert sha(source)==sha(installed)==item['after_sha256']
 report={'finding':'Chrono-Saur Rex delayed destruction follows a card through departure-return or face-down reset in both original Battle Phase summon branches.','qualification':'Eight original-effect Battle Phase cases and effective omitted-tracking/destruction controls, native dinosaur destruction/Hand summon and attack-trigger GY summon, current installed metadata. No Lua API mapping. Four Main1 diagnostics retain the same stable-recipient deadline failure before/after; three reset negatives there are not independent tracking proof. Main1 deadline, other clauses/full-card/live remain open.','runtime_dependencies_sha256':pins,'runs':runs,'main1_diagnostics':diagnostics,'manifest':manifest.name,'manifest_sha256':sha(manifest),'helper_sha256':sha(ROOT/'scripts'/item['helper']),'family_followup':{'259307285':'Previously repaired; retain existing evidence.','259911246':'Mylo stored-group position reset is a candidate; original effects not yet tested.','232449539':'Abstain stored banished group candidate; validate actual departure/rebanishment before patch.','259303191':'Tome of Eclipse stored banished group candidate; validate actual departure/rebanishment before patch.','221827483':'Delayed source revival candidate; require actual source history.','241957394':'Already uses resetting flag.','284639718':'Already uses resetting flag.'}}
 (OUT/'current-rex-delayed-destruction-review.json').write_text(json.dumps(report,indent=2)+'\n')
 print(json.dumps({'status':'REPAIRED_SOURCE_AND_INSTALLED','cases':8,'old_tracking_failures':6,'main1_deadline':'OPEN'}))
if __name__=='__main__':main()

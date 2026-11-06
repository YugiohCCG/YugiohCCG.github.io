"""Bounded delayed-return regression and exact source/install repair evidence."""
import hashlib,json,subprocess
from pathlib import Path
ROOT=Path(__file__).resolve().parents[1];OUT=ROOT/'output/fresh-ccg-september'
FILES=Path(r'C:\Program Files (x86)\YGO Omega\YGO Omega_Data\Files')
def sha(p):return hashlib.sha256(p.read_bytes()).hexdigest()
def main():
 source=ROOT/'public/CCG Downloads/CCG_Scripts/c259226799.lua';installed=FILES/'Scripts'/source.name
 backup=OUT/'charmelia-draw-permission-before-repair';manifest=OUT/'charmelia-draw-permission-repair-files.json'
 if not manifest.exists():
  assert source.read_bytes()==installed.read_bytes()
  backup.mkdir(exist_ok=True)
  for p in [source,installed]:
   dest=backup/(('installed-' if p==installed else '')+p.name)
   if dest.exists():assert dest.read_bytes()==p.read_bytes()
   else:dest.write_bytes(p.read_bytes())
  r=subprocess.run(['node','-e',"process.stdout.write(require('./scripts/fresh_charmelia_draw_permission_repair.cjs').corrected(require('fs').readFileSync(process.argv[1],'utf8')))",str(source)],cwd=ROOT,capture_output=True,check=True)
  item={'passcode':259226799,'file':source.name,'backup':backup.name,'before_sha256':sha(source),'after_sha256':hashlib.sha256(r.stdout).hexdigest(),'helper':'fresh_charmelia_draw_permission_repair.cjs'}
 else:item=json.loads(manifest.read_text())['files'][0]
 paths=[ROOT/'scripts'/n for n in ['fresh_current_charmelia_draw_permission.cjs','fresh_charmelia_draw_permission_repair.cjs','fresh_installed_card.cjs','fresh_corrected_card_data_transport.cjs']]+[ROOT/'tmp/omega_scripts'/n for n in ['constant.lua','utility.lua','procedure.lua','c24221739.lua']]+[FILES/'Databases/CCG_v1.db',backup/source.name]+list((ROOT/'node_modules/@n1xx1/ocgcore-wasm/dist').glob('*.js'))+[ROOT/'node_modules/@n1xx1/ocgcore-wasm/dist/index-card-data-transport-candidate.mjs']
 pins={str(p.resolve()):sha(p) for p in paths};runs=[]
 for mode,failures in [('candidate',[]),('old',[1]),('no-zero-exception',[2]),('no-recovery',[0,2,3,4]),('no-draw',[0])]:
  subprocess.run(['node','--no-warnings','scripts/fresh_current_charmelia_draw_permission.cjs',mode],cwd=ROOT,capture_output=True,check=True,timeout=20)
  p=OUT/f'current-charmelia-draw-permission-{mode}.json';d=json.loads(p.read_text());assert len(d['results'])==6
  assert [i for i,x in enumerate(d['results']) if x['failure']]==failures and all(not x['logs'] for x in d['results'])
  runs.append({'mode':mode,'file':p.name,'sha256':sha(p),'expected_failures':failures})
 assert pins=={str(p.resolve()):sha(p) for p in paths}
 if not manifest.exists():
  assert sha(source)==sha(installed)==item['before_sha256']
  source.write_bytes(r.stdout);installed.write_bytes(r.stdout)
  manifest.write_text(json.dumps({'files':[item]},indent=2)+'\n')
 assert sha(source)==sha(installed)==item['after_sha256']
 report={'finding':'Charmelia Beast recovery was offered with a known positive Ritual draw count while Protector of the Sanctuary already prohibited drawing. Target legality now checks permission for positive counts, preserving zero Ritual recovery.','qualification':'Six native original-effect cases/full stock Protector:normal,pre-lock,zero-lock,actual CL2 Protector summon,Ritual departure,source banishment. Seeded typed Ritual,neutral sending/response actors; no Lua API mapping. Original Ritual history,named limits/reset,remaining protection boundaries/full-card/live open. Official FAQ24396 before/after draw-lock distinction applied by analogy to this custom mandatory then-draw clause.','runtime_dependencies_sha256':pins,'runs':runs,'manifest':manifest.name,'manifest_sha256':sha(manifest),'helper_sha256':sha(ROOT/'scripts'/item['helper']),'family_scan':'current-mandatory-then-draw-source-scan.json','family_scan_sha256':sha(OUT/'current-mandatory-then-draw-source-scan.json')}
 (OUT/'current-charmelia-draw-permission-review.json').write_text(json.dumps(report,indent=2)+'\n')
 print(json.dumps({'status':'REPAIRED_SOURCE_AND_INSTALLED','cases':6,'old_forbidden_offer':1}))
if __name__=='__main__':main()

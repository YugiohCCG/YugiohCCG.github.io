"""Bounded delayed-return regression and exact source/install repair evidence."""
import hashlib,json,subprocess
from pathlib import Path
ROOT=Path(__file__).resolve().parents[1];OUT=ROOT/'output/fresh-ccg-september'
FILES=Path(r'C:\Program Files (x86)\YGO Omega\YGO Omega_Data\Files')
def sha(p):return hashlib.sha256(p.read_bytes()).hexdigest()
def main():
 source=ROOT/'public/CCG Downloads/CCG_Scripts/c259073666.lua';installed=FILES/'Scripts'/source.name
 backup=OUT/'wyvernal-draw-permission-before-repair';manifest=OUT/'wyvernal-draw-permission-repair-files.json'
 if not manifest.exists():
  assert source.read_bytes()==installed.read_bytes()
  backup.mkdir(exist_ok=True)
  for p in [source,installed]:
   dest=backup/(('installed-' if p==installed else '')+p.name)
   if dest.exists():assert dest.read_bytes()==p.read_bytes()
   else:dest.write_bytes(p.read_bytes())
  r=subprocess.run(['node','-e',"process.stdout.write(require('./scripts/fresh_wyvernal_draw_permission_repair.cjs').corrected(require('fs').readFileSync(process.argv[1],'utf8')))",str(source)],cwd=ROOT,capture_output=True,check=True)
  item={'passcode':259073666,'file':source.name,'backup':backup.name,'before_sha256':sha(source),'after_sha256':hashlib.sha256(r.stdout).hexdigest(),'helper':'fresh_wyvernal_draw_permission_repair.cjs'}
 else:item=json.loads(manifest.read_text())['files'][0]
 paths=[ROOT/'scripts'/n for n in ['fresh_current_wyvernal_draw_permission.cjs','fresh_wyvernal_draw_permission_repair.cjs','fresh_installed_card.cjs','fresh_corrected_card_data_transport.cjs']]+[ROOT/'tmp/omega_scripts'/n for n in ['constant.lua','utility.lua','procedure.lua','c24221739.lua']]+[FILES/'Databases/CCG_v1.db',backup/source.name]+list((ROOT/'node_modules/@n1xx1/ocgcore-wasm/dist').glob('*.js'))+[ROOT/'node_modules/@n1xx1/ocgcore-wasm/dist/index-card-data-transport-candidate.mjs']
 pins={str(p.resolve()):sha(p) for p in paths};runs=[]
 for mode,failures in [('candidate',[]),('old',[1]),('too-strict',[0]),('no-limit',[1])]:
  subprocess.run(['node','--no-warnings','scripts/fresh_current_wyvernal_draw_permission.cjs',mode],cwd=ROOT,capture_output=True,check=True,timeout=20)
  p=OUT/f'current-wyvernal-draw-permission-{mode}.json';d=json.loads(p.read_text());assert len(d['results'])==5
  assert [i for i,x in enumerate(d['results']) if x['failure']]==failures and all(not x['logs'] for x in d['results'])
  runs.append({'mode':mode,'file':p.name,'sha256':sha(p),'expected_failures':failures})
 assert pins=={str(p.resolve()):sha(p) for p in paths}
 if not manifest.exists():
  assert sha(source)==sha(installed)==item['before_sha256']
  source.write_bytes(r.stdout);installed.write_bytes(r.stdout)
  manifest.write_text(json.dumps({'files':[item]},indent=2)+'\n')
 assert sha(source)==sha(installed)==item['after_sha256']
 report={'finding':'Wyvernal Gathering allowed two-to-four GY targets under an existing draw lock, making the required floor(count/2) draw unavailable. Selection now allows only cardinalities with permitted draw counts, retaining one-card/zero-draw activation.','qualification':'Five native original cost/target-selection cases with full stock Protector; stops at selection and makes no new operation/draw outcome claim. Typed Insect targets, no Lua API mapping. Existing operation uses explicit legacy TARGET_CARDS mapping and is not upgraded. Primary before/after rule applied by analogy; other clauses/full-card/live open.','runtime_dependencies_sha256':pins,'runs':runs,'manifest':manifest.name,'manifest_sha256':sha(manifest),'helper_sha256':sha(ROOT/'scripts'/item['helper']),'family_scan':'current-mandatory-then-draw-source-scan.json','family_scan_sha256':sha(OUT/'current-mandatory-then-draw-source-scan.json')}
 (OUT/'current-wyvernal-draw-permission-review.json').write_text(json.dumps(report,indent=2)+'\n')
 print(json.dumps({'status':'REPAIRED_SOURCE_AND_INSTALLED','cases':5,'old_forbidden_selection':1}))
if __name__=='__main__':main()

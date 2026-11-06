"""Grouped named-support visibility repairs with native old/fault controls."""
import hashlib,json,subprocess
from pathlib import Path
ROOT=Path(__file__).resolve().parents[1];OUT=ROOT/'output/fresh-ccg-september';FILES=Path(r'C:\Program Files (x86)\YGO Omega\YGO Omega_Data\Files')
def sha(p):return hashlib.sha256(p.read_bytes()).hexdigest()
def main():
 backup=OUT/'named-field-visibility-before-repair';manifest=OUT/'named-field-visibility-repair-files.json';items=[];pending=[]
 if not manifest.exists():
  backup.mkdir(exist_ok=True)
  for code in [249746105,259366507,244972185]:
   source=ROOT/f'public/CCG Downloads/CCG_Scripts/c{code}.lua';installed=FILES/'Scripts'/source.name;assert source.read_bytes()==installed.read_bytes();helper='fresh_physalia_faceup_support_repair.cjs' if code==249746105 else 'fresh_eldora_faceup_support_repair.cjs'
   for p in [source,installed]:
    dest=backup/(('installed-' if p==installed else '')+p.name)
    if dest.exists():assert dest.read_bytes()==p.read_bytes()
    else:dest.write_bytes(p.read_bytes())
   r=subprocess.run(['node','-e',"process.stdout.write(require('./scripts/'+process.argv[3]).corrected(require('fs').readFileSync(process.argv[1],'utf8'),Number(process.argv[2])))",str(source),str(code),helper],cwd=ROOT,capture_output=True,check=True);items.append({'passcode':code,'file':source.name,'backup':backup.name,'helper':helper,'before_sha256':sha(source),'after_sha256':hashlib.sha256(r.stdout).hexdigest()});pending.append((source,installed,r.stdout))
 else:items=json.loads(manifest.read_text())['files']
 paths=[Path(__file__)]+[ROOT/'scripts'/n for n in ['fresh_current_physalia_faceup_support.cjs','fresh_current_eldora_faceup_support.cjs','fresh_physalia_faceup_support_repair.cjs','fresh_eldora_faceup_support_repair.cjs','fresh_installed_card.cjs','fresh_corrected_card_data_transport.cjs']]+[backup/i['file'] for i in items]+[ROOT/'public/CCG Downloads/CCG_Scripts'/f'c{c}.lua' for c in [225161820,214552846]]+[FILES/'Databases/CCG_v1.db']+[ROOT/'tmp/omega_scripts'/n for n in ['constant.lua','utility.lua','procedure.lua']]+list((ROOT/'node_modules/@n1xx1/ocgcore-wasm/dist').glob('*.js'))+[ROOT/'node_modules/@n1xx1/ocgcore-wasm/dist/index-card-data-transport-candidate.mjs'];pins={str(p.resolve()):sha(p) for p in paths};runs=[]
 for prefix,cases,modes in [('physalia',5,[('candidate',[]),('old',[1]),('no-limit',[0]),('block-all',[3,4])]),('eldora',6,[('candidate',[]),('old',[1,4]),('no-outcome',[0,3])])]:
  for mode,expected in modes:
   subprocess.run(['node','--no-warnings',f'scripts/fresh_current_{prefix}_faceup_support.cjs',mode],cwd=ROOT,capture_output=True,check=True,timeout=20);p=OUT/f'current-{prefix}-faceup-support-{mode}.json';d=json.loads(p.read_text());assert len(d['results'])==cases and [i for i,x in enumerate(d['results']) if x['failure']]==expected and all(not x['logs'] for x in d['results']);runs.append({'file':p.name,'mode':mode,'cases':cases,'sha256':sha(p),'expected_failures':expected})
 assert pins=={str(p.resolve()):sha(p) for p in paths}
 if not manifest.exists():
  for item,(source,installed,data) in zip(items,pending):assert sha(source)==sha(installed)==item['before_sha256'];source.write_bytes(data);installed.write_bytes(data)
  manifest.write_text(json.dumps({'files':items},indent=2)+'\n')
 for item in items:assert sha(ROOT/'public/CCG Downloads/CCG_Scripts'/item['file'])==sha(FILES/'Scripts'/item['file'])==item['after_sha256']
 report={'finding':'Physalia,Aquila and Spires counted face-down named support for positive control conditions. Require visible support in those predicates.','qualification':'11 original native cases across3 cards. Physalia original banish cost/destruction and CL2 response:faceup/facedown/absent Glaucus,opponent Monster/Trap and own Monster boundaries. Aquila inherent summon and Spires initial search branch availability with faceup/facedown/absent Eldora;actual search on positive case. No Deck Eldora alternative in Spires cases. Original source/support scripts and installed metadata,no API mapping. Other branches,Spires self-added-name timing,recipes/counts/interactions/live/full-card remain open. Primary official named-monster control rule applied by analogy to custom cards.','runtime_dependencies_sha256':pins,'runs':runs,'manifest':manifest.name,'manifest_sha256':sha(manifest),'helpers_sha256':{i['helper']:sha(ROOT/'scripts'/i['helper']) for i in items},'family_scan':'current-named-field-visibility-family-review.json','family_scan_sha256':sha(OUT/'current-named-field-visibility-family-review.json')};(OUT/'current-named-field-visibility-review.json').write_text(json.dumps(report,indent=2)+'\n');print(json.dumps({'status':'REPAIRED_SOURCE_AND_INSTALLED','cards':3,'native_cases':11}))
if __name__=='__main__':main()

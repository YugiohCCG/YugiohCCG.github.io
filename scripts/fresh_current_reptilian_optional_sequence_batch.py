"""Bounded delayed-return regression and exact source/install repair evidence."""
import hashlib,json,subprocess
from pathlib import Path
ROOT=Path(__file__).resolve().parents[1];OUT=ROOT/'output/fresh-ccg-september'
FILES=Path(r'C:\Program Files (x86)\YGO Omega\YGO Omega_Data\Files')
def sha(p):return hashlib.sha256(p.read_bytes()).hexdigest()
def main():
 source=ROOT/'public/CCG Downloads/CCG_Scripts/c259552732.lua';installed=FILES/'Scripts'/source.name
 backup=OUT/'reptilian-optional-sequence-before-repair';manifest=OUT/'reptilian-optional-sequence-repair-files.json'
 if not manifest.exists():
  assert source.read_bytes()==installed.read_bytes()
  backup.mkdir(exist_ok=True)
  for p in [source,installed]:
   dest=backup/(('installed-' if p==installed else '')+p.name)
   if dest.exists():assert dest.read_bytes()==p.read_bytes()
   else:dest.write_bytes(p.read_bytes())
  r=subprocess.run(['node','-e',"process.stdout.write(require('./scripts/fresh_reptilian_optional_sequence_repair.cjs').corrected(require('fs').readFileSync(process.argv[1],'utf8')))",str(source)],cwd=ROOT,capture_output=True,check=True)
  item={'passcode':259552732,'file':source.name,'backup':backup.name,'before_sha256':sha(source),'after_sha256':hashlib.sha256(r.stdout).hexdigest(),'helper':'fresh_reptilian_optional_sequence_repair.cjs'}
 else:item=json.loads(manifest.read_text())['files'][0]
 paths=[ROOT/'scripts'/n for n in ['fresh_current_reptilian_optional_sequence.cjs','fresh_reptilian_optional_sequence_repair.cjs','fresh_installed_card.cjs','fresh_corrected_card_data_transport.cjs']]+[ROOT/'tmp/omega_scripts'/n for n in ['constant.lua','utility.lua','procedure.lua']]+[FILES/'Databases/CCG_v1.db',backup/source.name]+list((ROOT/'node_modules/@n1xx1/ocgcore-wasm/dist').glob('*.js'))+[ROOT/'node_modules/@n1xx1/ocgcore-wasm/dist/index-card-data-transport-candidate.mjs']
 pins={str(p.resolve()):sha(p) for p in paths};runs=[]
 for mode,failures in [('candidate',[]),('old',[1,2]),('faceup-only',[1]),('ignored-choice',[2])]:
  subprocess.run(['node','--no-warnings','scripts/fresh_current_reptilian_optional_sequence.cjs',mode],cwd=ROOT,capture_output=True,check=True,timeout=20)
  p=OUT/f'current-reptilian-optional-sequence-{mode}.json';d=json.loads(p.read_text());assert len(d['results'])==3
  assert [i for i,x in enumerate(d['results']) if x['failure']]==failures and all(not x['logs'] for x in d['results'])
  runs.append({'mode':mode,'file':p.name,'sha256':sha(p),'expected_failures':failures})
 assert pins=={str(p.resolve()):sha(p) for p in paths}
 if not manifest.exists():
  assert sha(source)==sha(installed)==item['before_sha256']
  source.write_bytes(r.stdout);installed.write_bytes(r.stdout)
  manifest.write_text(json.dumps({'files':[item]},indent=2)+'\n')
 assert sha(source)==sha(installed)==item['after_sha256']
 report={'finding':'Vampire Reptilian wrongly required a face-up opposing target for self summon,and performed optional level-change/Xyz continuation without player choice. Allow any opposing monster target and honor refusal before level changes.', 'qualification':'Three original native self-summon cases:faceup/facedown opposing targets and continuation declined with neutral Vampire Link/Xyz support. Levels unchanged on refusal. No eligible Extra Deck Xyz in decline case. Accepted stock original Xyz setup blocked by missing CheckXyzMaterial before initial decision;no API mapping/replacement recipe. Accepted continuation/optional eligibility,named once-per-duel/other interactions/live/full-card open.', 'runtime_dependencies_sha256':pins,'runs':runs,'manifest':manifest.name,'manifest_sha256':sha(manifest),'helper_sha256':sha(ROOT/'scripts'/item['helper']),'family_scan':'current-reptilian-sequence-family-review.json','family_scan_sha256':sha(OUT/'current-reptilian-sequence-family-review.json')}
 (OUT/'current-reptilian-optional-sequence-review.json').write_text(json.dumps(report,indent=2)+'\n')
 print(json.dumps({'status':'REPAIRED_SOURCE_AND_INSTALLED','cases':3,'old_target_or_choice_failures':2}))
if __name__=='__main__':main()

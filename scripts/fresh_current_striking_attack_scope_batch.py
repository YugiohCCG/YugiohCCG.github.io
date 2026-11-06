"""Bounded delayed-return regression and exact source/install repair evidence."""
import hashlib,json,subprocess
from pathlib import Path
ROOT=Path(__file__).resolve().parents[1];OUT=ROOT/'output/fresh-ccg-september'
FILES=Path(r'C:\Program Files (x86)\YGO Omega\YGO Omega_Data\Files')
def sha(p):return hashlib.sha256(p.read_bytes()).hexdigest()
def main():
 source=ROOT/'public/CCG Downloads/CCG_Scripts/c250902476.lua';installed=FILES/'Scripts'/source.name
 backup=OUT/'striking-attack-scope-before-repair';manifest=OUT/'striking-attack-scope-repair-files.json'
 if not manifest.exists():
  assert source.read_bytes()==installed.read_bytes()
  backup.mkdir(exist_ok=True)
  for p in [source,installed]:
   dest=backup/(('installed-' if p==installed else '')+p.name)
   if dest.exists():assert dest.read_bytes()==p.read_bytes()
   else:dest.write_bytes(p.read_bytes())
  r=subprocess.run(['node','-e',"process.stdout.write(require('./scripts/fresh_striking_attack_scope_repair.cjs').corrected(require('fs').readFileSync(process.argv[1],'utf8')))",str(source)],cwd=ROOT,capture_output=True,check=True)
  item={'passcode':250902476,'file':source.name,'backup':backup.name,'before_sha256':sha(source),'after_sha256':hashlib.sha256(r.stdout).hexdigest(),'helper':'fresh_striking_attack_scope_repair.cjs'}
 else:item=json.loads(manifest.read_text())['files'][0]
 paths=[ROOT/'scripts'/n for n in ['fresh_current_striking_attack_scope.cjs','fresh_striking_attack_scope_repair.cjs','fresh_installed_card.cjs','fresh_corrected_card_data_transport.cjs']]+[ROOT/'tmp/omega_scripts'/n for n in ['constant.lua','utility.lua','procedure.lua']]+[FILES/'Databases/CCG_v1.db',backup/source.name]+list((ROOT/'node_modules/@n1xx1/ocgcore-wasm/dist').glob('*.js'))+[ROOT/'node_modules/@n1xx1/ocgcore-wasm/dist/index-card-data-transport-candidate.mjs']
 pins={str(p.resolve()):sha(p) for p in paths};runs=[]
 for mode,failures in [('candidate',[]),('old',[2,3]),('no-destroy',[0,1,2,3]),('no-extra',[1,3])]:
  subprocess.run(['node','--no-warnings','scripts/fresh_current_striking_attack_scope.cjs',mode],cwd=ROOT,capture_output=True,check=True,timeout=20)
  p=OUT/f'current-striking-attack-scope-{mode}.json';d=json.loads(p.read_text());assert len(d['results'])==4
  assert [i for i,x in enumerate(d['results']) if x['failure']]==failures and all(not x['logs'] for x in d['results'])
  runs.append({'mode':mode,'file':p.name,'sha256':sha(p),'expected_failures':failures})
 assert pins=={str(p.resolve()):sha(p) for p in paths}
 if not manifest.exists():
  assert sha(source)==sha(installed)==item['before_sha256']
  source.write_bytes(r.stdout);installed.write_bytes(r.stdout)
  manifest.write_text(json.dumps({'files':[item]},indent=2)+'\n')
 assert sha(source)==sha(installed)==item['after_sha256']
 report={'finding':'Striking Mirror Force incorrectly limited its attack trigger to opponents attacks despite printed any-monster attack wording. Both players attacks now qualify.', 'qualification':'Four original seeded set-trap cases: native own/opponent turn2 attack, attacker destruction and optional second destruction accepted/declined. Neutral combatants; no API mapping. Card/effect branch legality, protection, negation, named activation limit and live/full-card remain open.', 'runtime_dependencies_sha256':pins,'runs':runs,'manifest':manifest.name,'manifest_sha256':sha(manifest),'helper_sha256':sha(ROOT/'scripts'/item['helper']),'family_scan':'current-attack-declaration-family-review.json','family_scan_sha256':sha(OUT/'current-attack-declaration-family-review.json')}
 (OUT/'current-striking-attack-scope-review.json').write_text(json.dumps(report,indent=2)+'\n')
 print(json.dumps({'status':'REPAIRED_SOURCE_AND_INSTALLED','cases':4,'old_own_attack_failures':2}))
if __name__=='__main__':main()

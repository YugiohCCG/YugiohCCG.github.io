import hashlib,json,subprocess
from pathlib import Path
ROOT=Path(__file__).resolve().parents[1];OUT=ROOT/'output/fresh-ccg-september';FILES=Path(r'C:\Program Files (x86)\YGO Omega\YGO Omega_Data\Files')
def sha(p):return hashlib.sha256(p.read_bytes()).hexdigest()
def main():
 backup=OUT/'leet-lab-target-control-before-repair';manifest=OUT/'leet-lab-target-control-repair-files.json';items=[];pending=[]
 if not manifest.exists():
  backup.mkdir(exist_ok=True)
  for code in [259138193,259943152]:
   source=ROOT/f'public/CCG Downloads/CCG_Scripts/c{code}.lua';installed=FILES/'Scripts'/source.name;assert source.read_bytes()==installed.read_bytes()
   for p in [source,installed]:
    dest=backup/(('installed-' if p==installed else '')+p.name)
    if dest.exists():assert dest.read_bytes()==p.read_bytes()
    else:dest.write_bytes(p.read_bytes())
   r=subprocess.run(['node','-e',"process.stdout.write(require('./scripts/fresh_leet_lab_target_control_repair.cjs').corrected(require('fs').readFileSync(process.argv[1],'utf8'),Number(process.argv[2])))",str(source),str(code)],cwd=ROOT,capture_output=True,check=True)
   items.append({'passcode':code,'file':source.name,'backup':backup.name,'before_sha256':sha(source),'after_sha256':hashlib.sha256(r.stdout).hexdigest(),'helper':'fresh_leet_lab_target_control_repair.cjs'});pending.append((source,installed,r.stdout))
 else:items=json.loads(manifest.read_text())['files']
 paths=[Path(__file__),ROOT/'scripts/fresh_current_digita_target_control.cjs',ROOT/'scripts/fresh_current_aip_lab_target_control.cjs',ROOT/'scripts/fresh_leet_lab_target_control_repair.cjs',ROOT/'scripts/fresh_installed_card.cjs',ROOT/'scripts/fresh_corrected_card_data_transport.cjs',FILES/'Databases/CCG_v1.db']+[backup/i['file'] for i in items]+[ROOT/'tmp/omega_scripts'/n for n in ['constant.lua','utility.lua','procedure.lua']]+list((ROOT/'node_modules/@n1xx1/ocgcore-wasm/dist').glob('*.js'))+[ROOT/'node_modules/@n1xx1/ocgcore-wasm/dist/index-card-data-transport-candidate.mjs'];pins={str(p.resolve()):sha(p) for p in paths};runs=[]
 for fixture,cases,modes in [('digita_target_control',3,[('candidate',[]),('old',[1])]),('aip_lab_target_control',2,[('candidate',[]),('old',[1])])]:
  for mode,expected in modes:
   subprocess.run(['node','--no-warnings',f'scripts/fresh_current_{fixture}.cjs',mode],cwd=ROOT,capture_output=True,check=True,timeout=30);p=OUT/f"current-{fixture.replace('_','-')}-{mode}.json";d=json.loads(p.read_text(encoding='utf-8'));assert len(d['results'])==cases and [i for i,x in enumerate(d['results']) if x['failure']]==expected and all(not x['logs'] for x in d['results']);runs.append({'mode':mode,'cases':cases,'file':p.name,'sha256':sha(p),'expected_failures':expected})
 assert pins=={str(p.resolve()):sha(p) for p in paths}
 if not manifest.exists():
  for item,(source,installed,data) in zip(items,pending):
   assert sha(source)==sha(installed)==item['before_sha256'];source.write_bytes(data);installed.write_bytes(data)
  manifest.write_text(json.dumps({'files':items},indent=2)+'\n')
 for item in items:assert sha(ROOT/'public/CCG Downloads/CCG_Scripts'/item['file'])==sha(FILES/'Scripts'/item['file'])==item['after_sha256']
 report={'finding':'Digita Leet and A.I.P Lab now apply banishment or Level change to the same eligible monster after a control change.','qualification':'Five native cases verify original Digita hand summon and positive-stat banishment, zero-stat exclusion and the original Lab Level trigger. Both originals fail after an actual chained control change. Remaining printed clauses and targetability recheck are separate.','runtime_dependencies_sha256':pins,'runs':runs,'manifest':manifest.name,'manifest_sha256':sha(manifest),'helper_sha256':sha(ROOT/'scripts/fresh_leet_lab_target_control_repair.cjs'),'family_scan':'current-rush-target-control-review.json','family_scan_sha256':sha(OUT/'current-rush-target-control-review.json')};(OUT/'current-leet-lab-target-control-review.json').write_text(json.dumps(report,indent=2)+'\n');print(json.dumps({'status':'REPAIRED_SOURCE_AND_INSTALLED','cards':2,'cases':5}))
if __name__=='__main__':main()

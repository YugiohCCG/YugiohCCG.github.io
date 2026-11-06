import hashlib,json,subprocess
from pathlib import Path
ROOT=Path(__file__).resolve().parents[1];OUT=ROOT/'output/fresh-ccg-september';FILES=Path(r'C:\Program Files (x86)\YGO Omega\YGO Omega_Data\Files')
def sha(p):return hashlib.sha256(p.read_bytes()).hexdigest()
def main():
 backup=OUT/'vylon-pair-search-before-repair';manifest=OUT/'vylon-pair-search-repair-files.json';items=[];pending=[]
 if not manifest.exists():
  backup.mkdir(exist_ok=True)
  for code in [238274860]:
   source=ROOT/f'public/CCG Downloads/CCG_Scripts/c{code}.lua';installed=FILES/'Scripts'/source.name;assert source.read_bytes()==installed.read_bytes()
   for p in [source,installed]:
    dest=backup/(('installed-' if p==installed else '')+p.name)
    if dest.exists():assert dest.read_bytes()==p.read_bytes()
    else:dest.write_bytes(p.read_bytes())
   r=subprocess.run(['node','-e',"process.stdout.write(require('./scripts/fresh_vylon_pair_search_repair.cjs').corrected(require('fs').readFileSync(process.argv[1],'utf8'),Number(process.argv[2])))",str(source),str(code)],cwd=ROOT,capture_output=True,check=True)
   items.append({'passcode':code,'file':source.name,'backup':backup.name,'before_sha256':sha(source),'after_sha256':hashlib.sha256(r.stdout).hexdigest(),'helper':'fresh_vylon_pair_search_repair.cjs'});pending.append((source,installed,r.stdout))
 else:items=json.loads(manifest.read_text())['files']
 paths=[Path(__file__),ROOT/'scripts/fresh_current_vylon_pair_search.cjs',ROOT/'scripts/fresh_vylon_pair_search_repair.cjs',ROOT/'scripts/fresh_installed_card.cjs',ROOT/'scripts/fresh_corrected_card_data_transport.cjs',FILES/'Databases/CCG_v1.db']+[backup/i['file'] for i in items]+[ROOT/'tmp/omega_scripts'/n for n in ['constant.lua','utility.lua','procedure.lua']]+list((ROOT/'node_modules/@n1xx1/ocgcore-wasm/dist').glob('*.js'))+[ROOT/'node_modules/@n1xx1/ocgcore-wasm/dist/index-card-data-transport-candidate.mjs'];pins={str(p.resolve()):sha(p) for p in paths};runs=[]
 for fixture,cases,modes in [('vylon_pair_search',3,[('candidate',[]),('old',[1,2])])]:
  for mode,expected in modes:
   subprocess.run(['node','--no-warnings',f'scripts/fresh_current_{fixture}.cjs',mode],cwd=ROOT,capture_output=True,check=True,timeout=30);p=OUT/f"current-{fixture.replace('_','-')}-{mode}.json";d=json.loads(p.read_text(encoding='utf-8'));assert len(d['results'])==cases and [i for i,x in enumerate(d['results']) if x['failure']]==expected and all(not x['logs'] for x in d['results']);runs.append({'mode':mode,'cases':cases,'file':p.name,'sha256':sha(p),'expected_failures':expected})
 assert pins=={str(p.resolve()):sha(p) for p in paths}
 if not manifest.exists():
  for item,(source,installed,data) in zip(items,pending):
   assert sha(source)==sha(installed)==item['before_sha256'];source.write_bytes(data);installed.write_bytes(data)
  manifest.write_text(json.dumps({'files':items},indent=2)+'\n')
 for item in items:assert sha(ROOT/'public/CCG Downloads/CCG_Scripts'/item['file'])==sha(FILES/'Scripts'/item['file'])==item['after_sha256']
 roster=json.loads((ROOT/'src/data/cards.json').read_text(encoding='utf-8'))
 import re
 hits=[c['passcode'] for c in roster if re.search(r'add 1 [^.;]{1,130}? and 1 [^.;]{1,150}?to your hand',c['text'],re.I)]
 assert len(roster)==711 and set(hits)=={234178973,215984744,259253032,259721372,238274860}
 report={'finding':'Vylon Torus requires both search roles at resolution and discards only after both cards reach the hand.','qualification':'Three native cases use the original Special Summon trigger with neutral summon setup. Both roles add and discard. Chained removal of either role causes no partial add. A move replacement during the paired add remains untested.','family_scan':{'scanned':len(roster),'explicit_pair_text_hits':sorted(hits),'qualification':'Four other explicit pairs require both groups before sending. Broader named function Merge and SendtoHand scan found twelve lexical matches. Optional pools and unrelated merges are separate.'},'rules_source':'https://www.yugioh-card.com/eu/play/understanding-card-text/part-7-conjunction-functions/','runtime_dependencies_sha256':pins,'runs':runs,'manifest':manifest.name,'manifest_sha256':sha(manifest),'helper_sha256':sha(ROOT/'scripts/fresh_vylon_pair_search_repair.cjs')};(OUT/'current-vylon-pair-search-review.json').write_text(json.dumps(report,indent=2)+'\n');print(json.dumps({'status':'REPAIRED_SOURCE_AND_INSTALLED','cards':1,'cases':3}))
if __name__=='__main__':main()

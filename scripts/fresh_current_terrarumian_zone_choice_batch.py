import hashlib,json,subprocess
from pathlib import Path
ROOT=Path(__file__).resolve().parents[1];OUT=ROOT/'output/fresh-ccg-september';FILES=Path(r'C:\Program Files (x86)\YGO Omega\YGO Omega_Data\Files')
def sha(p):return hashlib.sha256(p.read_bytes()).hexdigest()
def main():
 backup=OUT/'terrarumian-zone-choice-before-repair';manifest=OUT/'terrarumian-zone-choice-repair-files.json';items=[];pending=[]
 if not manifest.exists():
  backup.mkdir(exist_ok=True)
  for code in range(284639717,284639725):
   source=ROOT/f'public/CCG Downloads/CCG_Scripts/c{code}.lua';installed=FILES/'Scripts'/source.name;assert source.read_bytes()==installed.read_bytes()
   for p in [source,installed]:
    dest=backup/(('installed-' if p==installed else '')+p.name)
    if dest.exists():assert dest.read_bytes()==p.read_bytes()
    else:dest.write_bytes(p.read_bytes())
   r=subprocess.run(['node','-e',"process.stdout.write(require('./scripts/fresh_terrarumian_zone_choice_repair.cjs').corrected(require('fs').readFileSync(process.argv[1],'utf8'),Number(process.argv[2])))",str(source),str(code)],cwd=ROOT,capture_output=True,check=True)
   items.append({'passcode':code,'file':source.name,'backup':backup.name,'before_sha256':sha(source),'after_sha256':hashlib.sha256(r.stdout).hexdigest(),'helper':'fresh_terrarumian_zone_choice_repair.cjs'});pending.append((source,installed,r.stdout))
 else:items=json.loads(manifest.read_text())['files']
 paths=[Path(__file__),ROOT/'scripts/fresh_current_terrarumian_zone_choice.cjs',ROOT/'scripts/fresh_terrarumian_zone_choice_repair.cjs',ROOT/'scripts/fresh_installed_card.cjs',ROOT/'scripts/fresh_corrected_card_data_transport.cjs',FILES/'Databases/CCG_v1.db']+[backup/i['file'] for i in items]+[ROOT/'tmp/omega_scripts'/n for n in ['constant.lua','utility.lua','procedure.lua']]+list((ROOT/'node_modules/@n1xx1/ocgcore-wasm/dist').glob('*.js'))+[ROOT/'node_modules/@n1xx1/ocgcore-wasm/dist/index-card-data-transport-candidate.mjs'];pins={str(p.resolve()):sha(p) for p in paths};runs=[]
 for fixture,cases,modes in [('terrarumian_zone_choice',24,[('candidate',[]),('old',sorted(list(range(1,24,3))+[20]))])]:
  for mode,expected in modes:
   subprocess.run(['node','--no-warnings',f'scripts/fresh_current_{fixture}.cjs',mode],cwd=ROOT,capture_output=True,check=True,timeout=30);p=OUT/f"current-{fixture.replace('_','-')}-{mode}.json";d=json.loads(p.read_text(encoding='utf-8'));assert len(d['results'])==cases and [i for i,x in enumerate(d['results']) if x['failure']]==expected and all(not x['logs'] for x in d['results']);runs.append({'mode':mode,'cases':cases,'file':p.name,'sha256':sha(p),'expected_failures':expected})
 assert pins=={str(p.resolve()):sha(p) for p in paths}
 if not manifest.exists():
  for item,(source,installed,data) in zip(items,pending):
   assert sha(source)==sha(installed)==item['before_sha256'];source.write_bytes(data);installed.write_bytes(data)
  manifest.write_text(json.dumps({'files':items},indent=2)+'\n')
 for item in items:assert sha(ROOT/'public/CCG Downloads/CCG_Scripts'/item['file'])==sha(FILES/'Scripts'/item['file'])==item['after_sha256']
 roster=json.loads((ROOT/'src/data/cards.json').read_text(encoding='utf-8'))
 assert len(roster)==711
 report={'finding':'Eight Terrarumian Pendulum effects prioritize destruction of a card that opens a usable Main Monster Zone when one is available. Late full-zone fallback preserves destruction when no card can open a zone.','qualification':'Twenty-four native original activation cases with neutral resources. Open zones, full Main Monster Zones with eligible Main and Extra Zone monsters, and late full zones without a zone-freeing resource. Nine original cases fail. Other clauses remain open.','family_scan':{'scanned':len(roster),'terrarumian_cards':list(range(284639717,284639725)),'follow_up':'Prospective-capacity scan flags hand-summon effects including 236898203, 238274860, 247755865 and 247755871. Verify their own printed choices separately.'},'rules_source':'https://www.db.yugioh-card.com/yugiohdb/faq_search.action?cid=19398&ope=4&request_locale=ja','runtime_dependencies_sha256':pins,'runs':runs,'manifest':manifest.name,'manifest_sha256':sha(manifest),'helper_sha256':sha(ROOT/'scripts/fresh_terrarumian_zone_choice_repair.cjs')};(OUT/'current-terrarumian-zone-choice-review.json').write_text(json.dumps(report,indent=2)+'\n');print(json.dumps({'status':'REPAIRED_SOURCE_AND_INSTALLED','cards':8,'cases':24}))
if __name__=='__main__':main()

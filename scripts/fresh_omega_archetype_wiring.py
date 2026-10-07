"""Cross-check pinned card primary archetype, installed names, DB membership and simple Lua set constants."""
import hashlib,importlib.util,json,re,sqlite3
from pathlib import Path
ROOT=Path(__file__).resolve().parents[1];OUT=ROOT/'output/fresh-ccg-september';FILES=Path(r'C:\Program Files (x86)\YGO Omega\YGO Omega_Data\Files')
spec=importlib.util.spec_from_file_location('ccg_sync',ROOT/'scripts/sync_omega_ccg_db.py');m=importlib.util.module_from_spec(spec);spec.loader.exec_module(m)
def main():
 names={}
 for line in (FILES/'Bundles/strdata.conf').read_text(encoding='utf-8-sig').splitlines():
  if line.startswith('!setname '):
   _,code,name=line.split(None,2);names.setdefault(m.normalize_name(name),set()).add(int(code,0))
 db=FILES/'Databases/CCG_v1.db';c=sqlite3.connect(db.as_uri()+'?mode=ro',uri=True)
 rows={r[0]:m.decode_setcodes(r[1]) for r in c.execute('select id,setcode from datas')};c.close()
 results=[]
 for card in json.loads((OUT/'baseline-remote.json').read_text(encoding='utf-8'))['cards']:
  primary=card['specification'].get('archetype') or '';key=m.normalize_name(primary);codes=rows[card['passcode']];expected=names.get(key,set())
  if key in m.OMEGA_SET_CODES:expected={m.OMEGA_SET_CODES[key]}
  source=ROOT/'public/CCG Downloads/CCG_Scripts'/('c'+str(card['passcode'])+'.lua');lua=source.read_text(encoding='utf-8-sig')
  own=[]
  for var,value in re.findall(r'local\s+(SET_[A-Z0-9_]+)\s*=\s*(0x[0-9a-fA-F]+|[0-9]+)',lua):
   if m.normalize_name(var[4:])==key:own.append({'name':var,'value':int(value,0)})
  status='UNRESOLVED' if not expected else 'MATCH' if any(code in codes for code in expected) else 'DATABASE_PRIMARY_MISMATCH'
  if key in {'new','existing',''}:status='NO_NAMED_PRIMARY'
  mismatch=[r for r in own if r['value'] not in codes]
  results.append({'passcode':card['passcode'],'name':card['name'],'primary':primary,'expected':sorted(expected),'installed_codes':codes,'primary_status':status,'same_name_lua_constants':own,'constant_mismatches':mismatch,'script_sha256':hashlib.sha256(source.read_bytes()).hexdigest()})
 report={'scope':'All711 pinned primary archetypes against installedDB and search labels, plus simple same-name local SET integer constants. Does not resolve dynamic set effects, other-archetype targets, Lua callback semantics or native Omega search. Search label inference is not independent proof of source membership.','database_sha256':hashlib.sha256(db.read_bytes()).hexdigest(),'summary':{s:sum(r['primary_status']==s for r in results) for s in sorted({r['primary_status'] for r in results})},'simple_own_constants':sum(bool(r['same_name_lua_constants']) for r in results),'constant_mismatches':[r for r in results if r['constant_mismatches']],'results':results}
 (OUT/'omega-archetype-wiring-review.json').write_text(json.dumps(report,indent=2)+'\n')
 print(json.dumps({k:v for k,v in report.items() if k not in {'results','scope','database_sha256'}},indent=2))
 print('Primary findings:',json.dumps([{k:r[k] for k in ['passcode','name','primary','expected','installed_codes']} for r in results if r['primary_status'] in {'UNRESOLVED','DATABASE_PRIMARY_MISMATCH'}],indent=2))
if __name__=='__main__':main()

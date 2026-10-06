"""Audit installed Omega set-name coverage; add only source-backed missing labels."""
import collections,hashlib,importlib.util,json,sqlite3,shutil,datetime,sys
from pathlib import Path
ROOT=Path(__file__).resolve().parents[1]
FILES=Path(r"C:\Program Files (x86)\YGO Omega\YGO Omega_Data\Files")
OUT=ROOT/'output/fresh-ccg-september'
spec=importlib.util.spec_from_file_location('ccg_sync',ROOT/'scripts/sync_omega_ccg_db.py');m=importlib.util.module_from_spec(spec);spec.loader.exec_module(m)
def sha(p):return hashlib.sha256(p.read_bytes()).hexdigest()
def main():
 db=FILES/'Databases/CCG_v1.db';strings=FILES/'Bundles/strdata.conf';before=sha(db)
 conn=sqlite3.connect(db.as_uri()+'?mode=ro',uri=True);rows=conn.execute('select d.id,t.name,d.setcode from datas d join texts t on t.id=d.id').fetchall();conn.close()
 text=strings.read_text(encoding='utf-8-sig');existing={}
 for line in text.splitlines():
  if line.startswith('!setname '):
   _,code,name=line.split(None,2);existing[int(code,0)]=name
 idmap=json.loads((ROOT/'public/CCG Downloads/CCG_Database/CCG_v1_id_map.json').read_text(encoding='utf-8'))
 sources={r['omega_id']:r for r in idmap};baseline=json.loads((OUT/'baseline-remote.json').read_text(encoding='utf-8'))
 for card in baseline['cards']:sources[card['passcode']]={'archetype':card['specification'].get('archetype'),'name':card['name'],'text':card['text']}
 votes=collections.defaultdict(collections.Counter);used=collections.defaultdict(list);invalid=[]
 for code,name,blob in rows:
  if not isinstance(blob,bytes) or len(blob)%2:invalid.append({'id':code,'name':name});continue
  codes=m.decode_setcodes(blob)
  for sc in codes:used[sc].append({'id':code,'name':name})
  source=sources.get(code,{})
  primary=m.canonical_display_name(source.get('archetype'))
  if primary and m.normalize_name(primary) not in {'existing','new'} and codes:
   votes[codes[0]][primary]+=1
  for tag in m.extract_treated_as_names(source.get('text'))+m.extract_name_based_archetype_names(name):
   sc=m.OMEGA_SET_CODES.get(m.normalize_name(tag))
   if sc in codes:votes[sc][m.canonical_display_name(tag)]+=1
 # Fixed set mappings can be labelled only by an exact source spelling already witnessed.
 spellings={m.normalize_name(n):n for v in votes.values() for n in v}
 for key,sc in m.OMEGA_SET_CODES.items():
  if sc in used and key in spellings:votes[sc][spellings[key]]+=1
 assert m.OMEGA_SET_CODES['bau']==0xba8 and m.OMEGA_SET_CODES['ohmechanic']==0x8de1
 votes[0xba8]=collections.Counter({'Bau':1});votes[0x8de1]=collections.Counter({'Ohmechanic':1})
 missing=sorted(set(used)-set(existing));labels={};unresolved=[]
 for sc in missing:
  candidates=votes[sc]
  normalized={m.normalize_name(n) for n in candidates}
  if len(normalized)==1:labels[sc]=candidates.most_common(1)[0][0]
  else:unresolved.append({'setcode':hex(sc),'candidates':dict(candidates),'cards':used[sc][:3]})
 assert not invalid,'Malformed setcode storage'
 backup=None
 if labels and '--install' in sys.argv:
  backup=FILES/'Backup'/('CCG-Archetypes-'+datetime.datetime.now().strftime('%Y%m%d-%H%M%S'));backup.mkdir()
  shutil.copy2(strings,backup/'strdata.conf')
  suffix='\n# CCG custom archetype names, matching installed database set codes\n'+''.join(f'!setname 0x{sc:x} {labels[sc]}\n' for sc in sorted(labels))
  strings.write_bytes(strings.read_bytes()+suffix.encode('utf-8'))
 aftertext=strings.read_text(encoding='utf-8-sig');parsed={}
 for line in aftertext.splitlines():
  if line.startswith('!setname '):
   _,sc,name=line.split(None,2);parsed[int(sc,0)]=name
 assert all(parsed[sc]==name for sc,name in existing.items());assert all(parsed.get(sc)==name for sc,name in labels.items()) if '--install' in sys.argv else True;assert sha(db)==before
 report={'scope':'Installed database/search setname consistency; no in-game search or Lua effect certification','database_sha256':before,'setcodes_used':len(used),'missing_before':len(missing),'proposed_labels':{hex(sc):n for sc,n in labels.items()},'labels_added_this_run':len(labels) if backup else 0,'unresolved':unresolved,'missing_after':[hex(sc) for sc in used if sc not in parsed],'backup':str(backup) if backup else None,'invalid_storage':invalid}
 (OUT/'local-omega-archetype-search-audit.json').write_text(json.dumps(report,indent=2)+'\n',encoding='utf-8')
 print(json.dumps({k:v for k,v in report.items() if k!='proposed_labels'},indent=2));print('Source-backed labels:',len(labels))
if __name__=='__main__':main()

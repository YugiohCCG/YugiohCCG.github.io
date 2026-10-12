"""Read-only current-specification reconciliation; preserve frozen test history."""
import difflib, hashlib, json, re, sqlite3
from pathlib import Path
ROOT=Path(__file__).resolve().parents[1]; OUT=ROOT/'output/fresh-ccg-september'
FILES=Path(r'C:\Program Files (x86)\YGO Omega\YGO Omega_Data\Files')
def sha(p): return hashlib.sha256(p.read_bytes()).hexdigest() if p.is_file() else None
def norm(s): return re.sub(r'\s+',' ',(s or '').replace('\\n','\n').replace('\\r','\r')).strip()
def connect(p): return sqlite3.connect(p.resolve().as_uri()+'?mode=ro',uri=True)
def differences(a,b):
 aa=norm(a).split();bb=norm(b).split()
 return [{'old':' '.join(aa[i:j]),'current':' '.join(bb[k:l])} for op,i,j,k,l in difflib.SequenceMatcher(None,aa,bb).get_opcodes() if op!='equal']
def packed_sets(v):
 if isinstance(v,bytes): return [int.from_bytes(v[i:i+2],'little') for i in range(0,len(v),2) if int.from_bytes(v[i:i+2],'little')]
 result=[];v=(v or 0)&((1<<64)-1)
 while v: result.append(v&65535);v>>=16
 return sorted(result)
def data(c,code):
 row=c.execute('select * from datas where id=?',(code,)).fetchone()
 if row is None:return None
 keys=[r[1] for r in c.execute('pragma table_info(datas)')]
 result=dict(zip(keys,row));result['setcode']=sorted(packed_sets(result['setcode']))
 return result
def text(c,code):
 row=c.execute('select name,desc from texts where id=?',(code,)).fetchone()
 return {'name':row[0],'text':row[1]} if row else None

baseline_path=OUT/'baseline-remote.json';website_path=ROOT/'src/data/cards.json'
baseline=json.loads(baseline_path.read_text(encoding='utf-8'))['cards']
website=json.loads(website_path.read_text(encoding='utf-8'))
current={int(c['passcode']):c for c in website if c.get('passcode')}
assert len(current)==len([c for c in website if c.get('passcode')]),'Duplicate current passcode'
syntax_path=OUT/'current-roster-syntax.json';load_path=OUT/'current-roster-engine-load.json'
syntax={r['passcode']:r for r in json.loads(syntax_path.read_text(encoding='utf-8'))['results']}
load={r['passcode']:r for r in json.loads(load_path.read_text(encoding='utf-8'))['results']}
selected_path=OUT/'current-spec-engine-load-selected.json'
selected=None
if selected_path.exists():
 selected=json.loads(selected_path.read_text(encoding='utf-8'))
 for p,h in {**selected['runtime_dependencies_sha256'],**selected['loaded_script_dependencies_sha256']}.items():
  assert sha(ROOT/p)==h,'Current revalidation dependency changed: '+p
 for row in selected['results']:
  assert sha(ROOT/f"public/CCG Downloads/CCG_Scripts/c{row['passcode']}.lua")==row['script_sha256']
  load[row['passcode']]=row
paths={'candidate':OUT/'candidate-CCG_v1.db','public':ROOT/'public/CCG Downloads/CCG_Database/CCG_v1.db','installed':FILES/'Databases/CCG_v1.db'}
before={str(p):sha(p) for p in [baseline_path,website_path,syntax_path,load_path,*paths.values()]}
if selected:before[str(selected_path)]=sha(selected_path)
connections={name:connect(p) for name,p in paths.items()}
rows=[]
spec_keys=['name','text','category','cardTypes','monsterType','attribute','level','rank','linkRating','linkArrows','scale','atk','def','archetype']
for old in baseline:
 code=old['passcode'];live=current.get(code);source=ROOT/f'public/CCG Downloads/CCG_Scripts/c{code}.lua';source_hash=sha(source)
 delta={}
 if live:
  for key in spec_keys:
   a=old['specification'].get(key);b=live.get(key)
   if (norm(a)!=norm(b) if key in ['name','text'] else a!=b):delta[key]=differences(a,b) if key=='text' else {'old':a,'current':b}
 texts={name:text(c,code) for name,c in connections.items()};datas={name:data(c,code) for name,c in connections.items()}
 row={'passcode':code,'name':live['name'] if live else old['name'],'current_present':live is not None,'specification_delta':delta,
      'script_sha256':source_hash,'installed_script_matches':bool(source_hash and source_hash==sha(FILES/'Scripts'/source.name)),
      'syntax_current':bool(source_hash and syntax.get(code,{}).get('script_sha256')==source_hash),
      'load_current':bool(source_hash and load.get(code,{}).get('script_sha256')==source_hash),
      'database_text_matches_current':{name:bool(live and t and norm(t['text'])==norm(live['text']) and norm(t['name'])==norm(live['name'])) for name,t in texts.items()},
      'database_rows_present':{name:bool(texts[name] is not None and datas[name] is not None) for name in paths},
      'database_metadata_matches_public':{name:None if datas['public'] is None else bool(datas[name] is not None and datas[name]==datas['public']) for name in ['candidate','installed']},
      'database_text_formatting_only':{name:bool(live and t and norm(t['text'])==norm(live['text']) and t['text']!=live['text']) for name,t in texts.items()}}
 if live:
  row['database_text_differences']={name:differences(t['text'] if t else '',live['text']) for name,t in texts.items() if t is None or norm(t['text'])!=norm(live['text'])}
 rows.append(row)
for c in connections.values():c.close()
assert before=={p:sha(Path(p)) for p in before},'Input changed during reconciliation'
summary={'pinned_cards':len(baseline),'current_cards':len(current),'new_passcodes':sorted(set(current)-{c['passcode'] for c in baseline}),
         'missing_current':sum(not r['current_present'] for r in rows),'changed_printed_effects':sum('text' in r['specification_delta'] for r in rows),
         'changed_specifications':sum(bool(r['specification_delta']) for r in rows),
         'database_text_mismatches':{name:sum(not r['database_text_matches_current'][name] for r in rows) for name in paths},
         'database_metadata_mismatches':{name:sum(r['database_metadata_matches_public'][name] is False for r in rows) for name in ['candidate','installed']},
         'database_missing_rows':{name:sum(not r['database_rows_present'][name] for r in rows) for name in paths},
         'database_text_formatting_only':{name:sum(r['database_text_formatting_only'][name] for r in rows) for name in paths},
         'source_install_mismatches':sum(not r['installed_script_matches'] for r in rows),
         'syntax_stale':sum(not r['syntax_current'] for r in rows),'load_stale':sum(not r['load_current'] for r in rows)}
if selected:
 summary['current_spec_initialization_rechecks']={'total':len(selected['results']),
       'passed':sum(r['status']=='first_decision_pass' for r in selected['results']),
       'compatibility_failures':sum(r['status']!='first_decision_pass' for r in selected['results'])}
report={'scope':'All pinned/current roster specifications reconciled read-only against frozen candidate and current public/installed databases. Metadata compared with public DB, not independently reconstructed from website. Hash freshness does not certify effect semantics; no historical evidence or DB modified.',
        'generator_sha256':sha(Path(__file__)),'inputs_sha256':before,'summary':summary,'cards':rows}
(OUT/'current-specification-drift.json').write_text(json.dumps(report,indent=2)+'\n',encoding='utf-8')
lines=['# Current specification and audit freshness','','Read-only reconciliation. Historical test data is preserved. Line breaks and literal escaped line breaks are treated as text separators. Missing public DB rows are reported separately from comparisons of existing metadata. No card is certified by this comparison.','',
       '```json',json.dumps(summary,indent=2),'```','','## Changed printed effects','','| Card | Changes from pinned effect text |','|---|---|']
for r in rows:
 if 'text' in r['specification_delta']:
  changes='; '.join(f"{d['old'] or '(added)'} → {d['current'] or '(removed)'}" for d in r['specification_delta']['text']).replace('|','\\|')
  lines.append(f"| {r['passcode']} {r['name']} | {changes} |")
lines+=['','## Differences requiring review','','| Card | Text mismatches | Metadata differs from public | Evidence stale | Installed script differs |','|---|---|---|---|---|']
for r in rows:
 texts=[n for n,v in r['database_text_matches_current'].items() if not v];metadata=[n for n,v in r['database_metadata_matches_public'].items() if v is False];stale=[n for n in ['syntax','load'] if not r[n+'_current']]
 if texts or metadata or stale or not r['installed_script_matches']:
  lines.append(f"| {r['passcode']} {r['name']} | {', '.join(texts) or '—'} | {', '.join(metadata) or '—'} | {', '.join(stale) or '—'} | {'yes' if not r['installed_script_matches'] else '—'} |")
(ROOT/'docs/OMEGA-CURRENT-SPECIFICATION-DRIFT.md').write_text('\n'.join(lines)+'\n',encoding='utf-8')
print(json.dumps(summary,indent=2))

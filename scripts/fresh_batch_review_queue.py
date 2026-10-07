"""Whole-roster static triage; findings require effect/runtime review."""
import hashlib,json,re,sqlite3,collections
from pathlib import Path
ROOT=Path(__file__).resolve().parents[1]
OUT=ROOT/'output/fresh-ccg-september'
def sha(p):return hashlib.sha256(p.read_bytes()).hexdigest()
def main():
 baseline=json.loads((OUT/'baseline-remote.json').read_text(encoding='utf-8'))
 inventory=json.loads((OUT/'audit-inventory.json').read_text(encoding='utf-8'))
 inv={int(c['passcode']):c for c in inventory['cards']}
 cards={int(c['passcode']):c for c in baseline['cards']}
 scripts={code:ROOT/'public/CCG Downloads/CCG_Scripts'/f'c{code}.lua' for code in cards}
 lua={code:p.read_text(encoding='utf-8') for code,p in scripts.items()}
 db=OUT/'candidate-CCG_v1.db'
 con=sqlite3.connect(db.as_uri()+'?mode=ro',uri=True)
 texts={row[0]:row[1:] for row in con.execute('select id,name,desc from texts')}
 con.close()
 rows=[]
 for code,c in cards.items():
  source=lua[code];digest=sha(scripts[code]);current=inv[code]['script_sha256']==digest
  families=[name for name,pattern in [('search',r'CATEGORY_SEARCH'),('summon',r'Duel\.SpecialSummon'),('cost',r'SetCost\('),('count',r'SetCountLimit\('),('material',r'XMATERIAL|AddXyzProcedure|AddSynchroProcedure|AddFusionProc'),('negation',r'NegateEffect|NegateActivation'),('delayed',r'PHASE_STANDBY|EVENT_PHASE') ] if re.search(pattern,source)]
  refs=sorted({int(n) for n in re.findall(r'(?<![\w])([0-9]{8,9})(?![\w])',source)}&cards.keys()-{code})
  restricted=[{'passcode':n,'name':cards[n]['name'],'script_sha256':sha(scripts[n])} for n in refs if 'EnableReviveLimit' in lua[n] or 'EFFECT_SPSUMMON_CONDITION' in lua[n]]
  findings=[]
  expected=(c['name'],c['text'].replace('\\n','\n'))
  if texts.get(code)!=expected:findings.append('database name/text mismatch after escaped-newline normalization')
  if not current:findings.append('inventory source hash stale')
  if 'Duel.SpecialSummon' in source and restricted and re.search(r'false,\s*false',source):findings.append('review full restricted-support summon interaction; literal references may be unrelated')
  rows.append({'passcode':code,'name':c['name'],'script_sha256':digest,'families':families,'database_name_text_match':texts.get(code)==expected,'escaped_newline_normalized':c['text']!=expected[1],'inventory_current':current,'public_load_status':inv[code]['load_status'] if current else 'STALE','restricted_literal_supports':restricted,'review_findings':findings,'effect_audit':'OPEN'})
 rows.sort(key=lambda r:(not bool(r['review_findings']),r['passcode']))
 report={'scope':'Static whole-roster triage only. Family labels and literal support references are routing hints, not semantic proof. Public load failures are compatibility evidence, not automatically Omega defects. No cards marked complete.', 'total':len(rows),'database_sha256':sha(db),'baseline_sha256':sha(OUT/'baseline-remote.json'),'inventory_sha256':sha(OUT/'audit-inventory.json'),'family_counts':dict(collections.Counter(f for r in rows for f in r['families'])),'finding_counts':dict(collections.Counter(f for r in rows for f in r['review_findings'])),'cards':rows}
 assert len(rows)==711
 (OUT/'batch-review-queue.json').write_text(json.dumps(report,indent=2)+'\n',encoding='utf-8')
 lines=['# Whole-roster Omega review queue','', 'Static triage of all 711 cards; runtime/effect audit remains open.','', '| Card | Review reason |','| --- | --- |']
 for r in rows:
  if r['review_findings']:lines.append(f"| {r['passcode']} {r['name']} | {'; '.join(r['review_findings'])} |")
 (ROOT/'docs/OMEGA-BATCH-REVIEW-QUEUE.md').write_text('\n'.join(lines)+'\n',encoding='utf-8')
 print(json.dumps({k:v for k,v in report.items() if k not in ['cards','scope']},indent=2))
if __name__=='__main__':main()

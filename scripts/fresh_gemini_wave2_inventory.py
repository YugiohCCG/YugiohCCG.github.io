"""Freeze the new report's card sections independently of the older review."""
import hashlib,json,re
from pathlib import Path
ROOT=Path(__file__).resolve().parents[1]
OUT=ROOT/'output/fresh-ccg-september'
REPORT=Path(r'C:\Users\hclar\.gemini\antigravity\brain\2502d83b-69f1-4c3d-88d3-8f14eaacfb7b\CCG_Omega_Card_Effect_Bug_Audit_Report.md')
lines=REPORT.read_text(encoding='utf-8').splitlines()
roster={str(c['passcode']):c for c in json.loads((OUT/'baseline-remote.json').read_text(encoding='utf-8'))['cards']}
starts=[i for i,l in enumerate(lines) if 2698<=i+1<12400 and re.match(r'^#{2,3} (?:Card \d+:|\d+\. (?:Ghostrick|Eclipse|Manual))',l)]
rows=[]
for index,start in enumerate(starts):
 end=starts[index+1] if index+1<len(starts) else 12400
 block=lines[start:end]
 codes=re.findall(r'\b(?:2\d{8})\b','\n'.join(block[:12]))
 code=next((c for c in codes if c in roster),None)
 assert code,(start+1,block[:12])
 prose=[];fenced=False
 for n,l in enumerate(block,start+1):
  if l.startswith('```'):fenced=not fenced;continue
  if not fenced and l.strip():prose.append({'line':n,'text':l})
 source=ROOT/'public/CCG Downloads/CCG_Scripts'/f'c{code}.lua'
 rows.append({'passcode':int(code),'name':roster[code]['name'],'line':start+1,'authoritative_card':roster[code],
              'source_sha256':hashlib.sha256(source.read_bytes()).hexdigest(),'prose':prose,
              'status':'PENDING_CLAIM_LEVEL_FACT_CHECK'})
result={'report_sha256':hashlib.sha256(REPORT.read_bytes()).hexdigest(),'scope':'New Wave 2 source assertions, not verified bugs or completed audits','cards':rows}
(OUT/'gemini-wave2-inventory.json').write_text(json.dumps(result,indent=2,ensure_ascii=True)+'\n',encoding='utf-8')
print(json.dumps({'sections':len(rows),'unique_cards':len({r['passcode'] for r in rows}),'report_sha256':result['report_sha256']}))
for r in rows:
 print(str(r['passcode'])+' '+r['name'])
 for p in r['prose']:
  if re.match(r'^\d+\. ',p['text']) or any(x in p['text'] for x in ['*Defect','*Flaw','*Reason','*Line']):
   print((str(p['line'])+': '+p['text']).encode('ascii','backslashreplace').decode())

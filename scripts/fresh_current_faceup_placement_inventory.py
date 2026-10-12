from pathlib import Path
import re,json,hashlib
root=Path('public/CCG Downloads/CCG_Scripts')
rows=[]
excluded={(219783132,'plcost'):'Placement is paid as cost, not included in resolving effect', (234599395,'excost'):'Placement is paid as cost, not included in resolving effect', (248760718,'pccost'):'Placement is paid as cost, not included in resolving effect', (231088629,'replaceop'):'Continuous replacement; no activated placement chain', (256831125,'nebop'):'Continuous replacement; no activated placement chain', (256831125,'sphreplaceop'):'Continuous replacement; no activated placement chain'}
for p in sorted(root.glob('c*.lua')):
 text=p.read_text(encoding='utf-8-sig'); lines=text.splitlines(); hits=[]
 for i,line in enumerate(lines):
  if 'Duel.MoveToField' not in line: continue
  functions=list(re.finditer(r'function\s+s\.(\w+)\s*\(', '\n'.join(lines[:i+1])))
  fn=functions[-1].group(1) if functions else None
  refs=[{'line':n+1,'text':l.strip()} for n,l in enumerate(lines) if fn and re.search(r'\bs\.'+re.escape(fn)+r'\b',l) and n!=i]
  hits.append({'line':i+1,'function':fn,'call':line.strip(),'context':'\n'.join(lines[max(0,i-5):i+2]),'references':refs,'registration_exclusion':excluded.get((int(p.stem[1:]),fn)), 'review':'OPEN: distinguish effect vs cost/rule replacement, source type/location, and conditional branch before registration'})
 if hits: rows.append({'code':int(p.stem[1:]),'path':p.as_posix(),'sha256':hashlib.sha256(p.read_bytes()).hexdigest(),'placements':hits})
report={'scope':'All current CCG scripts scanned for direct Duel.MoveToField calls; candidate inventory only, no automatic eligibility conclusions or production changes','scripts_scanned':len(list(root.glob('c*.lua'))),'scripts_with_calls':len(rows),'calls':sum(len(r['placements']) for r in rows),'cards':rows}
Path('output/fresh-ccg-september/current-faceup-placement-inventory.json').write_text(json.dumps(report,indent=2)+'\n',encoding='utf-8')
print({k:v for k,v in report.items() if k!='cards'})
for r in rows:
 print(str(r['code'])+': '+', '.join(h['function']+':'+str(h['line']) for h in r['placements']))

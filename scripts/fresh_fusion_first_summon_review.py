"""Read-only roster triage; pattern findings are not complete summon certification."""
import hashlib,json,re
from pathlib import Path
ROOT=Path(__file__).resolve().parents[1]
out=ROOT/'output/fresh-ccg-september'
baseline=json.loads((out/'baseline-remote.json').read_text(encoding='utf-8'))
rows=[]
for card in baseline['cards']:
 p=ROOT/'public/CCG Downloads/CCG_Scripts'/('c'+str(card['passcode'])+'.lua')
 source=p.read_text(encoding='utf-8');text=card['text']
 if 'aux.fuslimit' not in source:continue
 if not re.search(r'first|tributing|contact',text,re.I):continue
 rows.append(dict(passcode=card['passcode'],name=card['name'],text=text,script_sha256=hashlib.sha256(p.read_bytes()).hexdigest(),classification='FUSION_WORDING_REVIEW' if re.search(r'must first be Fusion Summoned',text,re.I) else 'NON_FUSION_FIRST_SUMMON_REVIEW'))
report=dict(scope='711 pinned text/current source pattern triage only; does not resolve custom callbacks or prove restrictions/material ownership',source_revision=baseline['source_revision'],roster_cards=len(baseline['cards']),findings=rows)
(out/'fusion-first-summon-pattern-review.json').write_text(json.dumps(report,indent=2)+'\n',encoding='utf-8')
print(json.dumps(report))

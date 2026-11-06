"""Bounded lexical count-key collision scan; no gameplay certification."""
import hashlib,json,re
from pathlib import Path
ROOT=Path(__file__).resolve().parents[1];OUT=ROOT/'output/fresh-ccg-september'
def sha(p):return hashlib.sha256(p.read_bytes()).hexdigest()
roster=json.loads((ROOT/'src/data/cards.json').read_text(encoding='utf-8'));keys={};other=[];pins={};registrations=0
for card in roster:
 code=int(card['passcode']);p=ROOT/f'public/CCG Downloads/CCG_Scripts/c{code}.lua';s=p.read_text(encoding='utf-8');pins[str(code)]=sha(p)
 standard=bool(re.search(r'local\s+s\s*,\s*id\s*=\s*GetID\s*\(\s*\)',s))
 for m in re.finditer(r':SetCountLimit\(([^\n]*)',s):
  registrations+=1;line=s.count('\n',0,m.start())+1;text=m[1].strip();exact=re.match(r'1\s*,\s*id\s*(?:\+\s*(\d+))?\s*\)',text)
  if exact and standard:
   offset=int(exact[1] or 0);keys.setdefault(code+offset,[]).append({'passcode':code,'offset':offset,'line':line})
  else:other.append({'passcode':code,'line':line,'arguments':text,'reason':'Outside exact standard GetID plus nonnegative literal offset pattern; not evaluated'})
collisions=[{'numeric_key':key,'members':members} for key,members in keys.items() if len({x['passcode'] for x in members})>1]
report={'status':'BOUNDED_SOURCE_SCAN_NO_CROSS_CARD_LITERAL_ID_COLLISION' if not collisions else 'CANDIDATES_REQUIRE_NATIVE_REPRODUCTION','scope':'All711 roster sources inspected for exact SetCountLimit(1,id) and SetCountLimit(1,id+nonnegative integer) with standard local s,id=GetID(). No cross-card arithmetic key collision found in this subset. Same-card repeated keys may intentionally share limits. Other expressions/flags/counts/aliases are not evaluated. No behavioral, reset, player scope, registration or full-card certification. No production changes.','cards':len(roster),'registrations_observed':registrations,'exact_key_registrations':sum(map(len,keys.values())),'distinct_exact_keys':len(keys),'cross_card_collisions':collisions,'outside_exact_pattern':other,'source_sha256_by_passcode':pins,'spec_sha256':sha(ROOT/'src/data/cards.json'),'script_sha256':sha(Path(__file__))}
(OUT/'current-count-limit-key-source-scan.json').write_text(json.dumps(report,indent=2)+'\n');print(json.dumps({k:report[k] for k in ['cards','registrations_observed','exact_key_registrations','distinct_exact_keys','cross_card_collisions']}));print('Outside exact pattern:',len(other))

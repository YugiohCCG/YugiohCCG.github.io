"""Compare quoted specifications; differences are review evidence, not card defects."""
import difflib,hashlib,json,re,sqlite3,unicodedata
from pathlib import Path
ROOT=Path(__file__).resolve().parents[1];OUT=ROOT/'output/fresh-ccg-september'
inventory=json.loads((OUT/'gemini-wave2-inventory.json').read_text(encoding='utf-8'))
db=sqlite3.connect(OUT/'candidate-CCG_v1.db');rows=[]
def words(text):
 text=unicodedata.normalize('NFKC',text).replace('\u2019',"'").replace('\u2018',"'")
 return re.findall(r"[\w']+",text.lower())
for card in inventory['cards']:
 quoted=[]
 for p in card['prose']:
  if any(s in p['text'] for s in ['Identified Bugs','Identified Defects','Defect Analysis','Discrepancies &','Defects &','Bugs Identified']):break
  if p['text'].lstrip().startswith('>'):quoted.append(p)
  if p['line']>card['line']+25:break
 quote=' '.join(p['text'].lstrip(' >*') for p in quoted)
 actual=card['authoritative_card']['text'];data=db.execute('select name,desc from texts where id=?',(card['passcode'],)).fetchone()
 assert data and data[0]==card['name'] and data[1]==actual,'Roster/candidate disagreement'
 a,b=words(actual),words(quote)
 same=a==b
 rows.append({'passcode':card['passcode'],'name':card['name'],'report_line':card['line'],
              'quoted_lines':[p['line'] for p in quoted],'quoted_text':quote,'authoritative_text':actual,
              'database_matches_roster':True,'normalized_text_matches':same,
              'text_similarity':round(difflib.SequenceMatcher(None,a,b,autojunk=False).ratio(),4),
              'status':'TEXT_MATCHES' if same else 'SPECIFICATION_DIFF_REQUIRES_REVIEW'})
result={'report_sha256':inventory['report_sha256'],'inventory_sha256':hashlib.sha256((OUT/'gemini-wave2-inventory.json').read_bytes()).hexdigest(),
        'candidate_database_sha256':hashlib.sha256((OUT/'candidate-CCG_v1.db').read_bytes()).hexdigest(),
        'scope':'All 69 new card sections; word-level specification comparison against pinned roster and current candidate DB, not behavior certification',
        'cards':rows}
(OUT/'gemini-wave2-text-check.json').write_text(json.dumps(result,indent=2,ensure_ascii=True)+'\n',encoding='utf-8')
print(json.dumps({'cards':len(rows),'word_matches':sum(r['normalized_text_matches'] for r in rows)}))
for r in rows:
 print(str(r['passcode'])+' '+r['status']+' '+str(r['text_similarity'])+' '+r['name'])

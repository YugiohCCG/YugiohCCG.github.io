"""Check every literal STRING_ID prompt against the actual candidate database."""
import hashlib,json,re,sqlite3
from pathlib import Path
ROOT=Path(__file__).resolve().parents[1];OUT=ROOT/'output/fresh-ccg-september'
inventory=json.loads((OUT/'gemini-wave2-inventory.json').read_text(encoding='utf-8'));db=sqlite3.connect(OUT/'candidate-CCG_v1.db');rows=[]
for card in inventory['cards']:
 source=ROOT/'public/CCG Downloads/CCG_Scripts'/f"c{card['passcode']}.lua";text=source.read_text(encoding='utf-8')
 m=re.search(r'local\s+STRING_ID\s*=\s*(\d+)',text)
 if not m:continue
 code=int(m.group(1));prompts=[]
 for slot in sorted({int(n) for n in re.findall(r'aux\.Stringid\(STRING_ID,\s*(\d+)\)',text)}):
  assert 0<=slot<16
  value=db.execute(f'select str{slot+1} from texts where id=?',(code,)).fetchone()
  prompts.append({'index':slot,'available':bool(value and value[0]),'text':value[0] if value else None})
 rows.append({'passcode':card['passcode'],'name':card['name'],'carrier':code,'source_sha256':hashlib.sha256(source.read_bytes()).hexdigest(),'prompts':prompts,'all_literal_prompts_available':all(p['available'] for p in prompts)})
result={'report_sha256':inventory['report_sha256'],'candidate_database_sha256':hashlib.sha256((OUT/'candidate-CCG_v1.db').read_bytes()).hexdigest(), 'scope':'Literal STRING_ID prompt presence in candidate DB. Does not certify UI rendering or correctness of dynamic descriptions.', 'cards':rows}
(OUT/'gemini-wave2-carrier-check.json').write_text(json.dumps(result,indent=2)+'\n',encoding='utf-8')
print(json.dumps({'cards_with_carriers':len(rows),'literal_prompts':sum(len(r['prompts']) for r in rows),'cards_missing_prompts':[r for r in rows if not r['all_literal_prompts_available']]}))

"""Read-only roster-wide Fusion pool audit; static findings are review candidates."""
import hashlib,json,re,sqlite3
from pathlib import Path
ROOT=Path(__file__).resolve().parents[1];OUT=ROOT/'output/fresh-ccg-september';SCRIPTS=ROOT/'public/CCG Downloads/CCG_Scripts'
def sha(p):return hashlib.sha256(p.read_bytes()).hexdigest()
db=sqlite3.connect(f'file:{OUT / "current-spec-CCG_v1.db"}?mode=ro',uri=True)
rows=[];roster=json.loads((OUT/'baseline-remote.json').read_text(encoding='utf-8'))['cards'];scripts=[SCRIPTS/f"c{r['passcode']}.lua" for r in roster];assert len(scripts)==711 and all(p.exists() for p in scripts)
for p in scripts:
 body=p.read_text(encoding='utf-8');calls=[]
 for n,line in enumerate(body.splitlines(),1):
  if 'Duel.GetFusionMaterial(' in line:
   calls.append({'line':n,'code':line.strip(),'immediately_filtered':bool(re.search(r'GetFusionMaterial\([^)]*\):Filter\(',line))})
  if 'GetMatchingGroup(nil,' in line and 'LOCATION_DECK' in line:
   calls.append({'line':n,'code':line.strip(),'unfiltered_deck_group':True})
 if calls:
  code=int(p.stem[1:]);name,desc=db.execute('select name,desc from texts where id=?',(code,)).fetchone()
  rows.append({'passcode':code,'name':name,'script_sha256':sha(p),'pool_calls':calls,'review':'OPEN: inspect full target/resolution helper chains and printed wording; raw pool may be filtered downstream'})
report={'scope':'Static scan of all 711 canonical scripts. Absence of textual patterns does not certify material eligibility; downstream helpers/alternative pools must be reviewed. Current data read-only.', 'scripts_scanned':len(scripts),'database_sha256':sha(OUT/'current-spec-CCG_v1.db'),'scanner_sha256':sha(Path(__file__)),'cards_with_pool_calls':len(rows),'raw_standard_pool_cards':[r['passcode'] for r in rows if any(c.get('immediately_filtered') is False for c in r['pool_calls'])],'unfiltered_deck_group_cards':[r['passcode'] for r in rows if any(c.get('unfiltered_deck_group') for c in r['pool_calls'])],'cards':rows}
(OUT/'fusion-pool-inventory.json').write_text(json.dumps(report,indent=2)+'\n')
print(json.dumps({k:v for k,v in report.items() if k not in ['cards','scope','scanner_sha256','database_sha256']}))

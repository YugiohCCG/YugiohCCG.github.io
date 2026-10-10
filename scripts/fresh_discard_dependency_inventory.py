"""Roster-wide static discard dependency review candidates; no automatic defect claims."""
import hashlib,json,re,sqlite3
from pathlib import Path
ROOT=Path(__file__).resolve().parents[1];OUT=ROOT/'output/fresh-ccg-september';SCRIPTS=ROOT/'public/CCG Downloads/CCG_Scripts'
def sha(p):return hashlib.sha256(p.read_bytes()).hexdigest()
roster=json.loads((OUT/'baseline-remote.json').read_text(encoding='utf-8'))['cards'];assert len(roster)==711
with sqlite3.connect(f'file:{OUT / "current-spec-CCG_v1.db"}?mode=ro',uri=True) as db:
 rows=[];discard_cards=[]
 for card in roster:
  code=card['passcode'];p=SCRIPTS/f'c{code}.lua';body=p.read_text(encoding='utf-8')
  if 'DiscardHand' in body or 'IsDiscardable' in body:discard_cards.append(code)
  name,desc=db.execute('select name,desc from texts where id=?',(code,)).fetchone()
  clauses=[t.strip() for t in re.findall(r'[^.\n]*[Dd]iscard[^;\n]*;[^.\n]*',desc) if 'Special Summon' in t and 'hand' in t]
  if not clauses:continue
  calls=[{'line':n,'source':line.strip()} for n,line in enumerate(body.splitlines(),1) if any(w in line for w in ['DiscardHand','IsDiscardable','SetCost','function s.spcost'])]
  rows.append({'passcode':code,'name':name,'script_sha256':sha(p),'printed_clauses':clauses,'source_cost_calls':calls,'status':'OPEN: static co-occurrence only; resolve same-effect cost/recipient locations and effect dependencies before native testing'})
report={'scope':'Read-only711-card current-text/source scan. Textual co-occurrence may span effects; no automatic bugs or completed-card claims. Discarding can create legal GY recipients, so an other-card rule is not universal.','scripts_scanned':711,'discard_source_cards':discard_cards,'printed_candidates':len(rows),'candidate_database_sha256':sha(OUT/'current-spec-CCG_v1.db'),'roster_sha256':sha(OUT/'baseline-remote.json'),'scanner_sha256':sha(Path(__file__)),'cards':rows,'reviewed_notes':{'213611313':'Repaired independent discard/Hand Galaxy recipient; native4-case evidence in current-crawler-hand-summon-batch.json.','259898110':'Source spcost explicitly excludes handler from Nemleria Hand cost at eligibility/selection; source-only review, not native effect certificate.','221047295':'Self discard creates GY card before targeting; do not apply generic other-card exclusion without considering eligibility and printed text.','259790247':'Printed cost requires other Charmelia; native discarded-name dependent Deck/GY recipient selection remains separate audit work.'}}
(OUT/'discard-dependency-inventory.json').write_text(json.dumps(report,indent=2)+'\n')
print(json.dumps({'scripts_scanned':711,'discard_source_cards':len(discard_cards),'printed_candidates':len(rows)}))

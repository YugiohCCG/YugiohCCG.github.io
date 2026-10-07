"""Conservative progress counters; never equate focused scenarios with completed cards."""
import collections,hashlib,json
from pathlib import Path
ROOT=Path(__file__).resolve().parents[1];OUT=ROOT/'output/fresh-ccg-september'
def sha(p):return hashlib.sha256(p.read_bytes()).hexdigest()
def main():
 baseline=json.loads((OUT/'baseline-remote.json').read_text(encoding='utf-8'));inventory=json.loads((OUT/'audit-inventory.json').read_text(encoding='utf-8'));byhash=collections.defaultdict(list)
 for card in baseline['cards']:
  p=ROOT/'public/CCG Downloads/CCG_Scripts'/f"c{card['passcode']}.lua"
  if p.exists():byhash[sha(p)].append(card)
 evidence={};ambiguous=[]
 for p in OUT.glob('*.json'):
  if p.name.startswith('restricted-probe-'):continue # Generic eligibility diagnostics are not focused effect evidence.
  try:x=json.loads(p.read_text(encoding='utf-8'))
  except (ValueError,UnicodeError):continue
  if not isinstance(x,dict) or x.get('control') or x.get('mutation'):continue
  matches=byhash.get(x.get('script_sha256'),[]);rs=x.get('results')
  if not matches or not isinstance(rs,list) or not rs or not all(isinstance(z,dict) and 'failure' in z and z['failure'] is None for z in rs):continue
  if len(matches)!=1:ambiguous.append(p.name);continue
  card=matches[0];evidence.setdefault(card['passcode'],{'name':card['name'],'artifacts':[]})['artifacts'].append({'path':p.name,'sha256':sha(p)})
 repairs=json.loads((OUT/'repair-ledger.json').read_text(encoding='utf-8'))
 for row in repairs['cards']:
  assert row['script_sha256']==sha(ROOT/'public/CCG Downloads/CCG_Scripts'/f"c{row['passcode']}.lua")
  if 'batch' in row:assert row['batch_sha256']==sha(OUT/row['batch'])
  else:assert row['validation_sha256']==sha(OUT/row['validation'])
 summary=inventory['summary'];assert summary['total']==711 and not summary['missing'] and not summary['syntax_stale'] and not summary['load_stale']
 assert all(c['effect_audit'].startswith('OPEN:') for c in inventory['cards'])
 report={'scope':'Counters from current inventory plus conservative discovery of current-source passing focused artifacts. Focused count is a lower bound, not complete effect verification; fixture strength and harness freshness require individual batch review. Identical source hashes excluded to avoid assigning evidence to wrong cards.', 'total':711,'fully_checked':0,'syntax_checked':711,'public_engine_first_decision_pass':summary['first_decision_pass'],'public_engine_load_fail':summary['load_fail'],'focused_evidence_cards_minimum':len(evidence),'initially_missing_scripts':baseline['summary']['missing_scripts'],'scripts_still_missing':summary['missing'],'fixed_cards_total':None,'fixed_cards_minimum':repairs['fixed_cards_minimum'],'repair_ledger_sha256':sha(OUT/'repair-ledger.json'),'fixed_count_note':'Documented repairs reconciled as a confirmed minimum; further historical repairs remain uncounted. Fixed does not mean fully audited.', 'ambiguous_artifacts_excluded':ambiguous,'focused_evidence':evidence,'inventory_sha256':sha(OUT/'audit-inventory.json')}
 (OUT/'progress-counts.json').write_text(json.dumps(report,indent=2)+'\n',encoding='utf-8')
 text=f"# Omega audit progress\n\n- Fully checked: 0/711.\n- Basic syntax checks: 711/711.\n- Public engine load checks passed: {summary['first_decision_pass']}/711; {summary['load_fail']} compatibility failures remain.\n- Current focused test evidence: at least {len(evidence)}/711 cards; partial checks only.\n- Initially missing scripts implemented: {baseline['summary']['missing_scripts']}/{baseline['summary']['missing_scripts']}; none remain missing.\n- Fixed cards: at least {repairs['fixed_cards_minimum']}/711 documented and checked repairs; historical reconciliation continues.\n\nNative Omega verification and full effect audits remain open.\n"
 (ROOT/'docs/OMEGA-AUDIT-PROGRESS.md').write_text(text,encoding='utf-8')
 print(json.dumps({k:v for k,v in report.items() if k not in {'focused_evidence','ambiguous_artifacts_excluded','scope'}},indent=2))
if __name__=='__main__':main()


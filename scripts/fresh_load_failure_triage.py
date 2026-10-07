"""Read-only grouping of current load failures; never converts failures into passes."""
import hashlib,json,re,collections
from pathlib import Path
ROOT=Path(__file__).resolve().parents[1];out=ROOT/'output/fresh-ccg-september'
p=out/'current-roster-engine-load.json';report=json.loads(p.read_text(encoding='utf-8'));groups=collections.defaultdict(list)
for row in report['results']:
 if row['status']=='first_decision_pass':continue
 match=re.search(r"nil value \(field '([^']+)'\)",str(row['error']))
 key=match.group(1) if match else 'UNCLASSIFIED'
 groups[key].append(dict(passcode=row['passcode'],name=row['name'],error=row['error'],script_sha256=row['script_sha256']))
api_path=out/'omega-api-reference-review.json';api=json.loads(api_path.read_text(encoding='utf-8'));by_card={r['passcode']:r for r in api['cards']}
for key,rows in groups.items():
 for row in rows:
  evidence=by_card.get(row['passcode'],{})
  row['api_review_current']=evidence.get('script_sha256')==row['script_sha256']
  row['matching_omega_reference_calls']=[{k:c[k] for k in ['api','reference_file','reference_line','reference_sha256','reference_file_count'] if k in c} for c in evidence.get('calls',[]) if c['api'].split('.')[-1]==key and c.get('reference_file')] if row['api_review_current'] else []
result=dict(api_review_sha256=hashlib.sha256(api_path.read_bytes()).hexdigest(),scope='Current public-engine failures grouped by missing function. Native Omega compatibility unproven; no status changed and no adapters applied.',load_report_sha256=hashlib.sha256(p.read_bytes()).hexdigest(),total_cards=len(report['results']),failure_count=sum(map(len,groups.values())),groups={k:dict(count=len(v),cards=v) for k,v in sorted(groups.items())})
(out/'load-failure-triage.json').write_text(json.dumps(result,indent=2)+'\n',encoding='utf-8')
print(json.dumps(dict(total=result['total_cards'],failures=result['failure_count'],groups={k:len(v) for k,v in groups.items()})))

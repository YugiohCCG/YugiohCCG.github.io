from pathlib import Path
import json,hashlib
ROOT=Path.cwd();OUT=ROOT/'output/fresh-ccg-september';cache={}
def sha(p):
 key=str(p.resolve())
 if key not in cache:cache[key]=hashlib.sha256(p.read_bytes()).hexdigest()
 return cache[key]
cards=[c for c in json.loads((ROOT/'src/data/cards.json').read_text(encoding='utf-8')) if 'Pendulum Effect:' in c.get('text','')]
rows={str(c['passcode']):{'name':c['name'],'current':[],'stale':[]} for c in cards}
for p in OUT.glob('current-*-batch.json'):
 try:d=json.loads(p.read_text());deps=d.get('runtime_dependencies_sha256',{})
 except Exception:continue
 involved=[code for code in rows if any(Path(k).name=='c'+code+'.lua' for k in deps)]
 if not involved:continue
 stale=[k for k,h in deps.items() if not Path(k).exists() or sha(Path(k))!=h]
 for code in involved:rows[code]['stale' if stale else 'current'].append({'artifact':p.name,'status':d.get('status'),'scope':d.get('scope'),'stale_dependencies':stale})
report={'scope':'Dependency freshness discovery only; valid hashes do not establish semantic effect coverage or full audit. Legacy schemas without runtime_dependencies_sha256 excluded. Historical evidence retained, not certified current.','cards':rows}
(OUT/'current-pendulum-evidence-freshness-review.json').write_text(json.dumps(report,indent=2)+'\n')
print('24 Pendulum evidence dependency review saved; current evidence is not full-card coverage')

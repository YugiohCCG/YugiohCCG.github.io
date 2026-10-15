import json,hashlib
from pathlib import Path
R=Path.cwd();O=R/'output/fresh-ccg-september'
def sha(p):return hashlib.sha256(p.read_bytes()).hexdigest()
artifacts=[]
for n in ['negation','interruption','use-reset']:
 f=O/('current-actinia-'+n+'-batch.json');b=json.loads(f.read_text())
 for dep,h in b['runtime_dependencies_sha256'].items():assert sha(R/dep)==h
 for run in b['runs']:
  a=O/run['artifact'];assert sha(a)==run['artifact_sha256'];d=json.loads(a.read_text());assert [i for i,v in enumerate(d['results']) if v['failure']]==run['expected_failures'];assert not any(v['logs'] for v in d['results'])
 artifacts.append({'path':f.name,'sha256':sha(f)})
assert sum(json.loads((O/a['path']).read_text())['baseline_cases'] for a in artifacts)==18
p=O/'progress-counts.json';d=json.loads(p.read_text());assert '216258796' not in d['focused_evidence']
d['focused_evidence']['216258796']={'name':'Aquamarine Actinia','artifacts':artifacts};d['focused_evidence_cards_minimum']+=1;assert d['focused_evidence_cards_minimum']==205
p.write_text(json.dumps(d,indent=2)+'\n',encoding='utf-8')
note='Aquamarine Actinia216258796 verified three native groups/18 cases. Full current initial-MZONE source: actual own ignition CL1/QuickCL2 activation negation+card destruction and real WATER Aqua GY banishcost; absent/wrongset/facedown/opponent partner and absent/wrongrace/wrongattribute cost exclusions. Actual CounterTrapCL3 activation/effect negation retains paidcost; source/partner/original banish and late original indestructibility resolve correctly. Two full copies share named use after success or either native negation: second same-ownturn1 response unavailable, actual next ownturn3 restored. Exact negative controls, empty logs, frozen dependencies and installed parity; no adapters/seeded use/proper Fusion history. Production unchanged. Counts205partial81repair0full. Next actual earliest opponent-turn reset, native Fusion/material and GY revival procedure qualification/history/use/capacity/locks; nativeOmega/fullcard/full711 remains OPEN and goal ACTIVE.'
f=R/'docs/CONTINUE-CCG-AUDIT.md';t=f.read_text(encoding='utf-8').replace('- 204 cards have focused partial evidence;','- 205 cards have focused partial evidence;');start=t.index('## Exact next action:');end=t.index('\n',start);t=t[:start]+'## Exact next action: Actinia revival and Fusion qualification\n\n'+note+'\n'+t[end:];f.write_text(t,encoding='utf-8')
f=R/'docs/CCG-AUDIT-HANDOFF.md';t=f.read_text(encoding='utf-8');i=t.index('\n');f.write_text(t[:i+1]+'\n'+note+'\n'+t[i+1:],encoding='utf-8')
f=Path(r'C:\Users\hclar\Documents\Codex\2026-10-07\c-manual-files-applications-yugiohccg-github\outputs\Current audit snapshot.md')
with f.open('a',encoding='utf-8') as s:s.write('\n\n'+note+'\n')
print(json.dumps({'focused':205,'repairs':81,'full':0,'actinia_cases':18}))

import json,hashlib
from pathlib import Path
R=Path.cwd();O=R/'output/fresh-ccg-september'
def sha(p):return hashlib.sha256(p.read_bytes()).hexdigest()
p=O/'progress-counts.json';d=json.loads(p.read_text())
names=['resolution-repaired','matching-destruction','optional-set','gy-interruption','gy-use-reset','gy-opponent-reset','original-operation','reason-repaired','lifecycle-repaired']
artifacts=[]
for n in names:
 f=O/('current-eldora-'+n+'-batch.json');b=json.loads(f.read_text())
 for dep,h in b['runtime_dependencies_sha256'].items():assert sha(R/dep)==h
 artifacts.append({'path':f.name,'sha256':sha(f)})
assert sum(json.loads((O/a['path']).read_text())['baseline_cases'] for a in artifacts)==53
d['focused_evidence']['214552846']['artifacts']=artifacts
d['repair_ledger_sha256']=sha(O/'repair-ledger.json');d['inventory_sha256']=sha(O/'audit-inventory.json')
p.write_text(json.dumps(d,indent=2)+'\n',encoding='utf-8')
note='Eldora attribution correction VERIFIED in repository and installed Omega Lua. Actual custom continuous source event within native resolution wrapper attributes selfdestruction to Eldora214552846; original fallback operation and destruction retain original reason effect. Repeated decline/effect-negation then acceptance and real Field reentry verified. Nine refreshed production groups/53 passing partial cases; exact negative controls, empty logs, frozen dependencies and source/install parity. Both-copy byte backups eldora-before-self-destruction-attribution-repair. All711 syntax PASS; Ohmen38cases28runs PASS; selected92=64pass28 known legacyAPI failures; installedDB text/meta/parity zero mismatch; historical full-load2stale remains separate. Repair ledger81 CURRENT_EVIDENCE_VERIFIED; focused204, fullyaudited0. Native Omega, complete card integration and same-turn named Quickplay activation remain OPEN. Next consolidate current Eldora coverage and advance first roster card without focused evidence; reuse fixtures and avoid redundant broad checks. Full711 goal remains ACTIVE.'
f=R/'docs/CONTINUE-CCG-AUDIT.md';t=f.read_text(encoding='utf-8');start=t.index('## Exact next action:');end=t.index('\n',start)
t=t[:start]+'## Exact next action: consolidate Eldora and advance uncovered roster\n\n'+note+'\n'+t[end:]
t=t.replace('Latest production repair: Eldora214552846 resolution timing, ninecases/fourcontrols and mandatory gates verified.','Latest production repair: Eldora214552846 resolution timing and native selfdestruction attribution, ninegroups/53cases and mandatory gates verified.')
import re
t=re.sub(r'Repair ledger SHA256: `[^`]+`', 'Repair ledger SHA256: `'+d['repair_ledger_sha256']+'`',t)
f.write_text(t,encoding='utf-8')
f=R/'docs/CCG-AUDIT-HANDOFF.md';t=f.read_text(encoding='utf-8');i=t.index('\n');f.write_text(t[:i+1]+'\n'+note+'\n'+t[i+1:],encoding='utf-8')
f=Path(r'C:\Users\hclar\Documents\Codex\2026-10-07\c-manual-files-applications-yugiohccg-github\outputs\Current audit snapshot.md')
with f.open('a',encoding='utf-8') as stream:stream.write('\n\n'+note+'\n')
(O/'current-eldora-coverage-consolidation.json').write_text(json.dumps({'scope':note,'artifacts':artifacts,'baseline_cases':53,'full_card_audit':'OPEN','native_omega_verified':False},indent=2)+'\n',encoding='utf-8')
print(json.dumps({'focused':204,'repairs':81,'full':0,'eldora_cases':53,'ledger':d['repair_ledger_sha256']}))

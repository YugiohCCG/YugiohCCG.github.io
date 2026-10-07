"""Inventory affected test boundaries without marking a source scan as an effect audit."""
import hashlib,json,re,sqlite3
from pathlib import Path
ROOT=Path(__file__).resolve().parents[1];OUT=ROOT/'output/fresh-ccg-september'
def sha(p):return hashlib.sha256(p.read_bytes()).hexdigest()
roster=json.loads((OUT/'baseline-remote.json').read_text(encoding='utf-8'))['cards']
db=sqlite3.connect(OUT/'candidate-CCG_v1.db');db.row_factory=sqlite3.Row
rows=[];links=[]
for card in roster:
 code=card['passcode'];p=ROOT/f'public/CCG Downloads/CCG_Scripts/c{code}.lua';s=p.read_text(encoding='utf-8')
 metadata=db.execute('select type,def from datas where id=?',(code,)).fetchone();assert metadata
 if metadata['type']&0x4000000:links.append({'passcode':code,'name':card['name'],'database_link_marker':metadata['def']})
 matches=[{'line':n,'methods':re.findall(r'(?:GetLinked\w*|GetMutualLinked\w*|GetLinkMarker|IsLinked)\b',line)} for n,line in enumerate(s.splitlines(),1) if re.search(r'(?:GetLinked\w*|GetMutualLinked\w*|GetLinkMarker|IsLinked)\b',line)]
 if matches:rows.append({'passcode':code,'name':card['name'],'source_sha256':sha(p),'direct_arrow_calls':matches,
                         'status':'FOCUSED_ADAPTED_TEST_EXISTS' if code in [259883230,259542408] else 'OPEN_ARROW_EFFECT_TEST',
                         'full_card_audit':'OPEN','native_omega_verified':False})
db.close()
report={'scope':'All 711 source/metadata records scanned. Direct API inventory and Link-card marker inventory only; not behavior verification. Public ptrSize=4 wrapper offsets lose Link marker/rscale; isolated test adapter is required when exercising these boundaries.',
        'direct_arrow_scripts':rows,'link_cards':links,'candidate_database_sha256':sha(OUT/'candidate-CCG_v1.db'),
        'adapter_generator_sha256':sha(ROOT/'scripts/fresh_public_card_data_adapter.py'),
        'boundary_evidence_sha256':sha(OUT/'pyre-zone-lock-batch.json')}
(OUT/'link-data-impact.json').write_text(json.dumps(report,indent=2)+'\n',encoding='utf-8')
doc=['# Public Link-card test boundary','',
 'This is a test infrastructure finding, not an Omega production bug. The original public WASM wrapper supplies marker zero for a Link fixture declared with marker 128. The isolated adapter restores marker 128 and its linked-zone mask. Node modules, Omega files and database metadata are unchanged by the adapter.','',
 f"All 711 scripts were screened: {len(rows)} directly call arrow-dependent APIs; {len(links)} roster cards have Link metadata. Helpers and supporting Link cards can create additional indirect dependencies, so this list is a starting point, not complete behavioral coverage.",'',
 'Release of the Pyre has an adapted actual activation/count regression. Lord of the Pyre has canonical full-script ATK tests: linked Pyro, wrong race, unlinked position, and opponent field. Raw wrapper and no-stat controls fail the positive; broad-race control fails only the wrong-race case. Other protections/triggers, proper Link procedures and native Omega remain open.','',
 '| Card | Arrow-dependent lines | Status |','|---|---|---|']
for r in rows:doc.append(f"| {r['passcode']} {r['name']} | {', '.join(str(m['line']) for m in r['direct_arrow_calls'])} | {r['status']} |")
(ROOT/'docs/OMEGA-LINK-DATA-TEST-BOUNDARY.md').write_text('\n'.join(doc)+'\n',encoding='utf-8')
print(json.dumps({'roster':711,'direct_arrow_scripts':len(rows),'link_cards':len(links),'new_full_audits':0}))

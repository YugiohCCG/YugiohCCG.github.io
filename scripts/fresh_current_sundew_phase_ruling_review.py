"""Reconcile primary rule notes with existing native evidence; no duel reruns."""
import hashlib,json
from pathlib import Path
from fresh_repair_ledger import verify_dependency,source_hash_matches
ROOT=Path.cwd();OUT=ROOT/'output/fresh-ccg-september';FILES=Path(r'C:\Program Files (x86)\YGO Omega\YGO Omega_Data\Files')
def sha(p):return hashlib.sha256(p.read_bytes()).hexdigest()
source=ROOT/'public/CCG Downloads/CCG_Scripts/c284639723.lua';batchpath=OUT/'current-sundew-end-phase-batch.json';batch=json.loads(batchpath.read_text());assert source.read_bytes()==(FILES/'Scripts'/source.name).read_bytes()
assert 'e3:SetCode(EVENT_PHASE+PHASE_END)' in source.read_text() and 'e3:SetCountLimit(1)' in source.read_text()
for dependency,h in batch['runtime_dependencies_sha256'].items():verify_dependency(dependency,h)
runs=[]
for run in batch['runs']:
 p=OUT/run['artifact'];assert sha(p)==run['sha256'];d=json.loads(p.read_text());assert len(d['results'])==3 and [i for i,v in enumerate(d['results']) if v['failure']]==run['expected_failures'] and all(not v['logs'] and v['trace'] for v in d['results'])
 if run['control'] is None:assert all(v['offers']==1 and v['endOffered'] and v['quick'] for v in d['results']) and [v['responseUsed'] for v in d['results']]==[False,True,True]
 runs.append({'artifact':p.name,'sha256':sha(p),'expected_failures':run['expected_failures']})
paths=[Path(__file__).resolve(),ROOT/'scripts/fresh_repair_ledger.py',ROOT/'src/data/cards.json',source,FILES/'Databases/CCG_v1.db',batchpath]
refs=[{'url':'https://www.db.yugioh-card.com/yugiohdb/faq_search.action?cid=7839&ope=4&request_locale=ja','card':'Genex Neutron','official_supplement_date':'2023-11-24','checked_date':'2026-10-23','original_excerpt':'エンドフェイズに１度のみ発動できます。','paraphrase':'Optional End Phase trigger can activate only once in that End Phase; neither activation negation nor effect negation permits another activation. Printed text has no separate once-per-turn sentence.'},{'url':'https://www.db.yugioh-card.com/yugiohdb/faq_search.action?cid=7737&ope=4&request_locale=ja','card':'Magical Android','official_supplement_date':'2015-02-12','checked_date':'2026-10-23','original_excerpt':'同一のエンドフェイズにて効果が再び発動する事はありません。','paraphrase':'Mandatory End Phase trigger likewise does not activate again within the same End Phase after activation or effect negation. Printed text has no separate once-per-turn sentence.'}]
report={'status':'SUNDEW_PHASE_LIMIT_SUPPORTED_BY_PRIMARY_OFFICIAL_ANALOGIES','runtime_dependencies_sha256':{str(p.resolve()):sha(p) for p in paths},'official_rule_notes':refs,'existing_native_evidence':{'artifact':batchpath.name,'sha256':sha(batchpath),'verified_runs':runs,'scope':batch['scope']},'conclusion':'Retain per-source once-per-phase End Phase trigger limit. Official optional and mandatory phase-trigger notes independently support the existing native success/activation-negation/effect-negation controls. Applied to custom Sundew by analogy; no direct custom-card ruling or live Omega proof. Retained destroyed-Pendulum count alone does not grant a second activation.','previous_reference':{'reference':batch['rule_reference'],'disposition':'Historical unofficial translation kept; Japanese Perfect Rulebook original still not inspected. Primary Konami notes now provide independent ruling provenance, so an untranslated book is no longer the sole support.'},'production_change':False,'full_card_audit':'OPEN','native_omega_verified':False}
(OUT/'current-sundew-phase-ruling-review.json').write_text(json.dumps(report,indent=2,ensure_ascii=False)+'\n',encoding='utf8')
print('Sundew phase limit reconciled with official optional/mandatory phase-trigger notes; no duel reruns')

"""Read-only printed-clause consolidation; no gameplay reruns or certification expansion."""
import hashlib,json
from pathlib import Path
ROOT=Path.cwd();OUT=ROOT/'output/fresh-ccg-september';FILES=Path(r'C:\Program Files (x86)\YGO Omega\YGO Omega_Data\Files')
def sha(p):return hashlib.sha256(p.read_bytes()).hexdigest()
source=ROOT/'public/CCG Downloads/CCG_Scripts/c247789143.lua';installed=FILES/'Scripts/c247789143.lua';assert source.read_bytes()==installed.read_bytes()
card=next(c for c in json.loads((ROOT/'src/data/cards.json').read_text(encoding='utf-8')) if c['passcode']==247789143)
lua=source.read_text(encoding='utf-8');assert 'aux.AddFusionProcFunRep(c,s.ffilter,2,true)' in lua and 'sg:IsExists(Card.IsFusionCode,1,c,c:GetFusionCode())' in lua
assert 'c:SetUniqueOnField(1,0,id)' in lua and 'e1:SetValue(600)' in lua and 'return Duel.GetTurnPlayer()==e:GetHandlerPlayer()' in lua
proofs=[]
for name in ['current-silphia-pair-batch.json','current-silphia-returns-batch.json','current-silphia-chain-uses-batch.json','current-silphia-delayed-deck-batch.json','current-silphia-interruptions-batch.json']:
 p=OUT/name;b=json.loads(p.read_text())
 for dep,h in b['runtime_dependencies_sha256'].items():
  q=Path(dep);q=q if q.is_absolute() else ROOT/q;assert sha(q)==h,(name,str(q))
 for r in b['runs']:
  q=OUT/r['artifact'];assert sha(q)==r['sha256'];d=json.loads(q.read_text());assert [i for i,v in enumerate(d['results']) if v['failure']]==r['expected_failures'] and all(not v['logs'] for v in d['results'])
 proofs.append({'artifact':name,'sha256':sha(p),'scope':b['scope']})
proc=ROOT/'tmp/omega_scripts/procedure.lua';helper=proc.read_text(encoding='utf-8');assert 'val[i](c,fc,subm,mg,sg)' in helper
clauses=[
 {'clause':'Fusion recipe: two differently named Stain monsters','status':'OPEN_ORIGINAL_RECIPE_RUNTIME','evidence':'Source filter plus helper forwarding mg/sg statically reviewed. Delayed suite genuinely pays a fixed two-different-name Stain Fusion, but does not exercise original general recipe selection/substitution/mandatory materials.'},
 {'clause':'Own-turn Stain ATK+600','status':'BOUNDED_NATIVE_PLUS_STATIC','evidence':'Native source ATK2200 on own turn and1600 on opponent turn in Quick/return suites; static own-MZone Stain target predicate and600 value. Other-recipient/disable boundaries not separately certified.'},
 {'clause':'Control only one Silphia','status':'STATIC_NATIVE_REGISTRATION','evidence':'Exact native SetUniqueOnField(1,0,id) registration reviewed; no dedicated two-copy summon/transfer interaction run.'},
 {'clause':'Optional Fusion trigger, next Standby one Stain monster faceup into opponent Deck','status':'DIRECT_SCOPED_NATIVE','evidence':'Delayed suite paid preparation/native next-turn Standby and cross-player faceup Deck move; decline/ordinary/type/set/resource boundaries, source removal, no repeat and effective controls.'},
 {'clause':'Once per Chain opponent activation: gain300','status':'PUBLIC_API_QUALIFIED','evidence':'Unadapted failures preserved. Explicit test-only SetCountLimit(1,0,8) verifies own-turn native300 gain, same-chain exclusion and next-chain reuse after success/effect/activation negation; production legacy constant unchanged.'},
 {'clause':'Lose exactly2000 then temporarily banish field monster and own Stain','status':'REPAIRED_DIRECT_SCOPED_NATIVE','evidence':'Original one-card counterexample, corrected first valid-pair selection, exact ATK loss/two distinct banishments, native CL4 interruption/resource/ATK boundaries and End Phase original-controller returns, effective controls.'}]
report={'passcode':247789143,'name':card['name'],'printed_text':card['text'],'script_sha256':sha(source),'installed_matches':True,'helper_static_review_sha256':sha(proc),'clauses':clauses,'evidence':proofs,'scope':'Existing saved evidence validated read-only against exact current runtime dependencies and outcomes. Static registration, native behavior, fixed preparation and public API mapping kept distinct. No new passing counts.','full_card_audit':'OPEN','live_omega_verified':False,'next':'Original general Fusion runtime/API and static-only uniqueness/other-recipient buff scope remain unproven. Do not replay covered Quick/delayed branches or call neutral paid setup original recipe certification.'}
(OUT/'current-silphia-requirements-review.json').write_text(json.dumps(report,indent=2)+'\n',encoding='utf-8');print('Silphia clauses consolidated; exact current saved dependencies verified; original recipe/static-only scopes remain open')

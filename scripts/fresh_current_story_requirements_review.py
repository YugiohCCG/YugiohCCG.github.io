"""Read-only printed-clause consolidation; no gameplay reruns or certification expansion."""
import hashlib,json
from pathlib import Path
ROOT=Path.cwd();OUT=ROOT/'output/fresh-ccg-september';FILES=Path(r'C:\Program Files (x86)\YGO Omega\YGO Omega_Data\Files')
def sha(p):return hashlib.sha256(p.read_bytes()).hexdigest()
source=ROOT/'public/CCG Downloads/CCG_Scripts/c245970073.lua';installed=FILES/'Scripts/c245970073.lua';assert source.read_bytes()==installed.read_bytes()
card=next(c for c in json.loads((ROOT/'src/data/cards.json').read_text(encoding='utf-8')) if c['passcode']==245970073)
lua=source.read_text(encoding='utf-8');assert 'e1:SetCountLimit(1,id+EFFECT_COUNT_CODE_OATH)' in lua and 'e2:SetCost(aux.bfgcost)' in lua
proofs=[]
for name in ['current-stainless-story-batch.json','current-story-eligibility-batch.json','current-story-draw-batch.json','current-story-activation-uses-batch.json','current-story-interruptions-batch.json']:
 p=OUT/name;b=json.loads(p.read_text())
 for dep,h in b['runtime_dependencies_sha256'].items():
  q=Path(dep);q=q if q.is_absolute() else ROOT/q;assert sha(q)==h,(name,str(q))
 for r in b['runs']:
  q=OUT/r['artifact'];assert sha(q)==r['sha256'];d=json.loads(q.read_text());assert [i for i,v in enumerate(d['results']) if v['failure']]==r['expected_failures'] and all(not v['logs'] for v in d['results'])
 proofs.append({'artifact':name,'sha256':sha(p),'scope':b['scope']})
clauses=[
 {'clause':'Opponent controls more cards; pay own Deck or faceup opposing Deck Stain monster','status':'DIRECT_SCOPED_NATIVE','evidence':'Strict equal/fewer/no-source/opponent-hidden exclusions; native hidden assertions and ReverseInDeck. Own hidden/opposing-owned faceup actual costs; copied-source whitelist static, borrowed-original-owner opposing Deck not specifically tested.'},
 {'clause':'Effect becomes sent monster Normal/Special Summon effect','status':'BEHAVIOR_OBSERVED_IDENTITY_PENDING','evidence':'All five current branches tested, including Bria add/bottom and Silas add/Set. Native Silas CL2 interruptions tested. Current non-Silas sent-source self-shuffle observed but this-card/other-card identity and targeting interpretation not settled; user identity clarification pending.'},
 {'clause':'Banish from GY; each player draws1','status':'DIRECT_SCOPED_NATIVE','evidence':'Actual prior Story Spell resolution plus reserve copy: both separately pay native banish cost and both players really draw twice same turn. Either player cannot draw prevents GY activation; effective cost/draw/feasibility controls.'},
 {'clause':'Activate only1 Story per turn','status':'PUBLIC_API_QUALIFIED','evidence':'Original legacy OATH public failure after activation negation retained. Test-only registration(1,id,1) proves named Hand-copy sharing, activation-negation retry versus effect-negation/success exclusion, real cost retained and natural turn3 reset; GY effects separate.'}]
report={'passcode':245970073,'name':card['name'],'printed_text':card['text'],'script_sha256':sha(source),'installed_matches':True,'clauses':clauses,'evidence':proofs,'scope':'Existing saved evidence validated read-only against exact current runtime dependencies and outcomes. Static registration, native behavior, fixed preparation and public API mapping kept distinct. No new passing counts.','full_card_audit':'OPEN','live_omega_verified':False,'next':'Pending copied this-card identity and targeting interpretation prevent full-card conclusion. Other copied-branch interruptions and opposing Deck borrowed-owner cost scope remain separate. Do not repeat completed Silas/draw/activation suites merely for counts.'}
(OUT/'current-story-requirements-review.json').write_text(json.dumps(report,indent=2)+'\n',encoding='utf-8');print('Story clauses consolidated; exact current saved dependencies verified; identity/API limits retained')

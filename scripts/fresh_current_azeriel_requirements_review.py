"""Read-only printed-clause consolidation; no gameplay reruns or certification expansion."""
import hashlib,json
from fresh_repair_ledger import source_hash_matches
from pathlib import Path
ROOT=Path.cwd();OUT=ROOT/'output/fresh-ccg-september';FILES=Path(r'C:\Program Files (x86)\YGO Omega\YGO Omega_Data\Files')
def sha(p):return hashlib.sha256(p.read_bytes()).hexdigest()
source=ROOT/'public/CCG Downloads/CCG_Scripts/c237089049.lua';installed=FILES/'Scripts/c237089049.lua';assert source.read_bytes()==installed.read_bytes()
card=next(c for c in json.loads((ROOT/'src/data/cards.json').read_text(encoding='utf-8')) if c['passcode']==237089049)
lua=source.read_text(encoding='utf-8');assert all(v in lua for v in ['e1:SetCountLimit(1,id)','e2:SetCountLimit(1,id+1)','e3:SetCountLimit(1,id+2)','e4:SetCountLimit(1,id+3)'])
proofs=[]
for name in ['current-azeriel-visibility-batch.json','current-azeriel-followup-batch.json','current-azeriel-deck-send-batch.json','current-azeriel-search-batch.json','current-azeriel-detached-batch.json','current-deck-monster-type-batch.json','current-azeriel-search-uses-batch.json']:
 p=OUT/name;b=json.loads(p.read_text());reconciled=[]
 for dep,h in b['runtime_dependencies_sha256'].items():
  q=Path(dep);q=q if q.is_absolute() else ROOT/q
  if sha(q)!=h:
   assert source_hash_matches(q,h),(name,str(q));reconciled.append({'path':str(q),'saved_sha256':h,'current_sha256':sha(q),'basis':'Exact source/install before bytes and strict monster-filter repair helper; remaining code unchanged, not a gameplay rerun.'})
 for r in b['runs']:
  q=OUT/r['artifact'];assert sha(q)==r['sha256'];d=json.loads(q.read_text());assert [i for i,v in enumerate(d['results']) if v['failure']]==r['expected_failures'] and all(not v['logs'] for v in d['results'])
 proofs.append({'artifact':name,'sha256':sha(p),'scope':b['scope'],'exact_repair_stage_reconciliation':reconciled})
clauses=[
 {'clause':'Two Level4 Arckcestial including LIGHT Synchro Xyz recipe','status':'OPEN_ORIGINAL_GENERAL_RECIPE','evidence':'Actual paid fixed Xyz preparations use native material groups/overlays/type/proper completion and printed identities. Original level-free recipe/helper runtime and broad material substitutions remain unverified.'},
 {'clause':'Optional Xyz-Summoned send1 Arckcestial monster Deck to GY','status':'REPAIRED_DIRECT_SCOPED_NATIVE','evidence':'Real source Xyz history, original optional send/decline/missing/CL2 negation; new actual Meadow Spell-only/mixed counterexamples repaired with TYPE_MONSTER, old-source/no-send controls.'},
 {'clause':'Detach1 material to add Rank-Up-Magic Spell from Deck','status':'DIRECT_SCOPED_NATIVE','evidence':'Native paid history, actual detach REASON_COST/search/reveal, missing material/candidate/type/set, actual activation/effect negation with cost retained and same-copy named limit.'},
 {'clause':'Own Special Summon Arckcestial Xyz/Synchro: revive GY in Defense then optional RUM recovery','status':'REPAIRED_DIRECT_SCOPED_NATIVE','evidence':'Real paid source/event histories followed by ordinary Special Summon (not fake type/proper-status seeds); faceup/own/set/card-type/mixed boundaries, Defense revival. Optional actual GY-to-Hand/reveal versus decline/missing/CL2 removal/negation. Face-down property filter repaired.'},
 {'clause':'Detached as activated Arckcestial Xyz effect cost: destroy faceup field card','status':'DIRECT_SCOPED_NATIVE','evidence':'Real paid source/carrier Xyz/overlay attachment/native selected detach; cost/effect distinction and archetype negative, faceup-only destruction, CL2 negation/source banish and controls.'},
 {'clause':'Each named effect once per turn','status':'PARTIAL_NATIVE_PLUS_STATIC','evidence':'Four distinct integer named-use keys statically confirmed. Search key now has actual two-copy sharing/exclusion after success/activation/effect negation with resources and natural reset/different-copy payment/search. Other three keys retain static registration evidence, not direct copy/reset gameplay. Do not add three duplicate counter suites solely to mirror identical native registration absent a concrete uncertainty.'}]
report={'passcode':237089049,'name':card['name'],'printed_text':card['text'],'script_sha256':sha(source),'installed_matches':True,'clauses':clauses,'evidence':proofs,'scope':'Existing saved evidence validated read-only against exact current runtime dependencies and outcomes. Static registration, native behavior, fixed preparation and public API mapping kept distinct. No new passing counts.','full_card_audit':'OPEN','live_omega_verified':False,'next':'Original general Xyz recipe remains unverified. Search copy/reset now directly proven; retain static-vs-gameplay distinction for other keys and neutral material/recipe qualifications. Identify a concrete missing behavior before more fixtures. Exact source-stage reconciliation is not rerun evidence.'}
(OUT/'current-azeriel-requirements-review.json').write_text(json.dumps(report,indent=2)+'\n',encoding='utf-8');print('Azeriel clauses consolidated; exact monster-filter repair stage reconciled; search sharing/reset verified; other static and recipe scopes retained')

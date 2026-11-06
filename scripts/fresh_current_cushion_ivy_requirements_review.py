import hashlib,json,re
from pathlib import Path
from fresh_repair_ledger import verify_dependency,source_hash_matches
ROOT=Path.cwd();OUT=ROOT/'output/fresh-ccg-september';FILES=Path(r'C:\Program Files (x86)\YGO Omega\YGO Omega_Data\Files');CODES=[284639717,284639722]
def sha(p):return hashlib.sha256(p.read_bytes()).hexdigest()
spec=ROOT/'src/data/cards.json';roster={c['passcode']:c for c in json.loads(spec.read_text(encoding='utf8'))};inventory=json.loads((OUT/'current-pendulum-requirements-review.json').read_text());cards=[c for c in inventory['cards'] if c['passcode'] in CODES];assert len(cards)==2
sources={c:ROOT/'public/CCG Downloads/CCG_Scripts'/f'c{c}.lua' for c in CODES};paths=[Path(__file__).resolve(),ROOT/'scripts/fresh_repair_ledger.py',ROOT/'scripts/fresh_current_pendulum_requirements_review.py',spec,FILES/'Databases/CCG_v1.db']+list(sources.values());deps={str(p.resolve()):sha(p) for p in paths};verified=set();suites=[]
for code,p in sources.items():
 assert p.read_bytes()==(FILES/'Scripts'/p.name).read_bytes();text=p.read_text();assert re.findall(r'SetCountLimit\(1,([^)]*)\)',text)==['id','id+100'];assert 'aux.EnablePendulumAttribute(c)' in text and 'SetCode(EFFECT_DEFENSE_ATTACK)' in text
 if code==284639717:assert 'Duel.GetFieldGroupCount(tp,LOCATION_MZONE,0)==0' in text and 'not c:IsCode(id)' in text
 else:assert 'c:IsFaceup() and c:IsControler(tp)' in text and 'Duel.GetAttacker()' in text and 'Duel.GetAttackTarget()' in text and 'Duel.SpecialSummonStep' in text and 'EFFECT_DISABLE_EFFECT' in text
for c in cards:
 if not any('current-terrarumian-condition-visibility-batch.json' in clause['evidence'] for clause in c['printed_clause_evidence']['clauses']):c['printed_clause_evidence']['clauses'].append({'clause':'Primary visible-archetype condition and unchanged Cushion generic monster OR comparison','evidence':['current-terrarumian-condition-visibility-batch.json'],'scope':'Native actual Hand-to-PZone and activation menus; seven latest visibility guards, independent Cushion OR condition, original/no-condition controls. No primary-resolution expansion.'})
for c in cards:
 if not any('current-terrarumian-destroy-visibility-batch.json' in clause['evidence'] for clause in c['printed_clause_evidence']['clauses']):c['printed_clause_evidence']['clauses'].append({'clause':'Archetype destruction resource faceup visibility','evidence':['current-terrarumian-destroy-visibility-batch.json'],'scope':'Native actual destruction selection prompt, visible Spell retained and hidden Spell/monster excluded; original-source controls, no expanded resolution or live claim.'})
names=list(dict.fromkeys(name for c in cards for clause in c['printed_clause_evidence']['clauses'] for name in clause['evidence']))
def relevant(row,data,run,code):
 if row.get('passcode',data.get('cardId',run.get('passcode')))==code:return True
 if code==284639722 and run['artifact'].startswith('current-ivy-battle-visibility'):return True
 return run.get('fixture') in ({'cushion_destroyed'} if code==284639717 else {'ivy_destroyed','ivy_battle_lock','ivy_participants'})
for name in names:
 p=OUT/name;batch=json.loads(p.read_text());assert batch['runs'];source_stages={}
 for dependency,h in batch['runtime_dependencies_sha256'].items():
  if (dependency,h) not in verified:verify_dependency(dependency,h);verified.add((dependency,h))
  for code,source in sources.items():
   if Path(dependency).resolve()==source.resolve():
    assert source_hash_matches(source,h);source_stages[code]={'sha256':h,'stage':'exact_current' if sha(source)==h else 'strict_helper_reconstruction'}
 runs=[]
 for run in batch['runs']:
  a=OUT/run['artifact'];assert sha(a)==run.get('sha256',run.get('artifact_sha256'));d=json.loads(a.read_text());results=d.get('results',[d]);assert results and all(not v['logs'] and v['trace'] for v in results)
  if 'expected_failure' in run:assert bool(d['failure'])==run['expected_failure']
  else:
   expected=run['expected_failures']
   if not expected or isinstance(expected[0],int):actual=[i for i,v in enumerate(results) if v['failure']]
   elif isinstance(expected[0],list):actual=[[v['passcode'],v['scenario']] for v in results if v['failure']]
   else:actual=[v['scenario'] for v in results if v['failure']]
   assert actual==expected,(name,a.name,actual,expected)
  covered={str(code):[i for i,v in enumerate(results) if relevant(v,d,run,code)] for code in CODES};covered={code:indices for code,indices in covered.items() if indices}
  if not covered:continue
  if name=='current-terrarumian-defense-attack-batch.json' and not run['expected_failure']:
   battles=[v for v in d['trace'] if v['type']==111];assert battles and battles[-1]['card']['position']==4 and battles[-1]['card']['attack']==900 and battles[-1]['card']['defense']==3000 and battles[-1]['card']['destroyed'] and not battles[-1]['target']['destroyed']
  runs.append({'artifact':a.name,'sha256':sha(a),'relevant_result_indices':covered,'expected_failures':run.get('expected_failures',run.get('expected_failure'))})
 assert runs,(name,'No directly assigned card results')
 suites.append({'artifact':name,'sha256':sha(p),'scope':batch['scope'],'source_stages':source_stages,'verified_runs':runs})
for card in cards:
 for clause in card['printed_clause_evidence']['clauses']:
  for name in clause['evidence']:
   suite=next(v for v in suites if v['artifact']==name);assert any(str(card['passcode']) in r['relevant_result_indices'] for r in suite['verified_runs']),(card['passcode'],name)
assert deps=={str(p.resolve()):sha(p) for p in paths}
report={'status':'CUSHION_IVY_PRINTED_CLAUSE_EVIDENCE_REVIEWED','runtime_dependencies_sha256':deps,'review_method':'Read-only source/specification/installed parity, exact dependency verification with strict production-helper source-stage reconstruction, native result traces and recorded semantic control failures. Existing scenario scopes inspected; no scenario reruns or new production changes.','cards':[{'passcode':c['passcode'],'name':c['name'],'spec_text':roster[c['passcode']]['text'],'clauses':c['printed_clause_evidence']['clauses'],'source_review':'Separate primary/monster named-use keys; generic ignition Main Phase timing. Cushion OR condition/self-name exclusion/search and mandatory placement chain match text. Ivy primary optional revival, shared destruction alternatives/negation, battle participants and repaired faceup visibility match reviewed clauses.','full_card_audit':'OPEN','native_omega_verified':False} for c in cards],'suites':suites,'scope_limits':['Battle suite deliberately overrides ATK900/DEF3000; actual native battle packet verifies these stats and outcome. Historical actualDefense field records printed database DEF, not the override. Initially field source is a stated battle-only setup.','Neutral supports/recipients and field-seeded Extra resource for geometry do not certify original recipient procedures or independent effects.','Ivy visibility follows official archetype-battle ruling analogy recorded in its repair batch; not a direct custom-card FAQ.','No claim about arbitrary interactions/full-card/live Omega certification; do not expand fully_checked/live counters.'],'new_confirmed_source_bugs':[]}
(OUT/'current-cushion-ivy-requirements-review.json').write_text(json.dumps(report,indent=2)+'\n',encoding='utf8');print('Cushion/Ivy printed clauses reconciled with direct scoped native evidence; no scenario reruns')

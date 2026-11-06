import hashlib,json,re
from pathlib import Path
from fresh_repair_ledger import verify_dependency,source_hash_matches
ROOT=Path.cwd();OUT=ROOT/'output/fresh-ccg-september';FILES=Path(r'C:\Program Files (x86)\YGO Omega\YGO Omega_Data\Files');CODES=[259537607,284639718,284639719,284639720,284639724]
def sha(p):return hashlib.sha256(p.read_bytes()).hexdigest()
spec=ROOT/'src/data/cards.json';roster={c['passcode']:c for c in json.loads(spec.read_text(encoding='utf8'))};inventory=json.loads((OUT/'current-pendulum-requirements-review.json').read_text());cards=[c for c in inventory['cards'] if c['passcode'] in CODES];assert len(cards)==5
sources={c:ROOT/'public/CCG Downloads/CCG_Scripts'/f'c{c}.lua' for c in CODES};paths=[Path(__file__).resolve(),ROOT/'scripts/fresh_repair_ledger.py',ROOT/'scripts/fresh_current_pendulum_requirements_review.py',spec,FILES/'Databases/CCG_v1.db']+list(sources.values());deps={str(p.resolve()):sha(p) for p in paths};verified=set();suites=[]
for code,p in sources.items():
 assert p.read_bytes()==(FILES/'Scripts'/p.name).read_bytes();text=p.read_text();assert re.findall(r'SetCountLimit\(1,([^)]*)\)',text)==['id','id+100'];assert 'aux.EnablePendulumAttribute(c)' in text
 if code!=259537607:assert 'SetCode(EFFECT_DEFENSE_ATTACK)' in text and 'return c~=handler and c:IsFaceup() and c:IsSetCard(SET_TERRARUMIAN)' in text
 if code==284639724:assert 'c:IsPreviousPosition(POS_FACEUP)' in text
for c in cards:
 if c['passcode']==284639724 and not any('current-trumpet-battle-flip-batch.json' in clause['evidence'] for clause in c['printed_clause_evidence']['clauses']):c['printed_clause_evidence']['clauses'].append({'clause':'Hand trigger after battle-flipped destruction','evidence':['current-trumpet-battle-flip-batch.json'],'scope':'Native actual battle flip/destruction/Hand summon, faceup baseline and wrong-set/nonPendulum exclusions; missing Damage Step permission repaired, original/no-summon controls.'})
names=list(dict.fromkeys(name for c in cards for clause in c['printed_clause_evidence']['clauses'] for name in clause['evidence']))
def relevant(row,data,run,code):
 if row.get('passcode',data.get('cardId',run.get('passcode')))==code:return True
 fixture=run.get('fixture','');artifact=run['artifact']
 if code==259537607:return 'arktos' in artifact or row.get('passcode',row.get('boss'))==code
 tags={284639718:['coin'],284639719:['sword'],284639720:['nerve'],284639724:['trumpet','target-lock']}[code]
 return any(tag in fixture or tag in artifact for tag in tags)
for name in names:
 p=OUT/name;batch=json.loads(p.read_text());source_stages={}
 if 'suites' in batch:
  for suite in batch['suites']:
   q=OUT/suite['artifact'];assert sha(q)==suite['sha256'];sub=json.loads(q.read_text());
   for dependency,h in sub['runtime_dependencies_sha256'].items():verify_dependency(dependency,h)
  batch['runs']=[dict(run) for suite in batch['suites'] for run in json.loads((OUT/suite['artifact']).read_text())['runs']]
 assert batch['runs']
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
   elif isinstance(expected[0],list):actual=[([v['passcode'],v['side'],v['scenario']] if len(expected[0])==3 else [v['passcode'],v['scenario']]) for v in results if v['failure']]
   elif isinstance(expected[0],dict):actual=[v['test'] for v in results if v['failure']]
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
report={'status':'FIVE_PENDULUM_PRINTED_CLAUSE_EVIDENCE_REVIEWED','runtime_dependencies_sha256':deps,'review_method':'Read-only source/specification/installed parity, exact dependency verification with strict production-helper source-stage reconstruction, native result traces and recorded semantic control failures. Existing scenario scopes inspected; no scenario reruns or new production changes.','cards':[{'passcode':c['passcode'],'name':c['name'],'spec_text':roster[c['passcode']]['text'],'clauses':c['printed_clause_evidence']['clauses'],'source_review':'Separate named keys and clause inventory reviewed against source. Arktos automatic exact-one opposing summon movement and optional Quick movement differ; native Extra geometry and hidden summon cases retained. Coin count/temporary banish/return, Sword replacement and shared event Set, Nerve DEF/Set/destruction, Trumpet protection/Hand destruction-history/Battle Phase shared effect retain individual scopes. Repaired faceup resource/condition/previous-position guards included. No full-card inference.','full_card_audit':'OPEN','native_omega_verified':False} for c in cards],'suites':suites,'scope_limits':['Battle suite deliberately overrides ATK900/DEF3000; actual native battle packet verifies these stats and outcome. Historical actualDefense field records printed database DEF, not the override. Initially field source is a stated battle-only setup.','Neutral supports/recipients and field-seeded Extra resource for geometry do not certify original recipient procedures or independent effects.','Trumpet old hidden-destruction positive is superseded by previous-faceup repair. Actual battle-flip Hand trigger now evidenced separately; Damage Step flag repair and original/no-summon controls retained. Archetype visibility interpretations use recorded official analogies, not direct custom FAQs.','No claim about arbitrary interactions/full-card/live Omega certification; do not expand fully_checked/live counters.'],'new_confirmed_source_bugs':[]}
(OUT/'current-five-pendulum-requirements-review.json').write_text(json.dumps(report,indent=2)+'\n',encoding='utf8');print('Five Pendulum rows reconciled with direct scoped evidence; no scenario reruns')

"""Reconcile existing Crying Chaos clauses/evidence without replaying sound tests."""
import hashlib,importlib.util,json,re,sqlite3
from pathlib import Path
ROOT=Path(__file__).resolve().parents[1];OUT=ROOT/'output/fresh-ccg-september';FILES=Path(r'C:\Program Files (x86)\YGO Omega\YGO Omega_Data\Files')
def sha(p):return hashlib.sha256(p.read_bytes()).hexdigest()
loader=importlib.util.spec_from_file_location('audit_ledger',ROOT/'scripts/fresh_repair_ledger.py');ledger=importlib.util.module_from_spec(loader);loader.loader.exec_module(ledger)
parents={};checked=set();reconciled=set();evidence={};counts=json.loads((OUT/'progress-counts.json').read_text());spec=json.loads((ROOT/'src/data/cards.json').read_text(encoding='utf-8'));roster={c['passcode']:c for c in spec};status=json.loads((OUT/'current-711-card-status.json').read_text());status_by={r['passcode']:r for r in status['cards']}
def check_dep(name,h):
 key=(name,h)
 if key in checked:return
 p=Path(name);p=p if p.is_absolute() else ROOT/p
 if sha(p)!=h:ledger.verify_dependency(name,h);reconciled.add(name)
 checked.add(key)
def check_parent(name,subjects=None):
 if name in parents:return
 p=OUT/name;d=json.loads(p.read_text());assert p.exists();drift=[]
 for dep,h in d.get('runtime_dependencies_sha256',{}).items():check_dep(dep,h)
 if name=='spell-search-family-batch.json':
  assert sha(ROOT/'scripts/fresh_spell_search_family.cjs')==d['harness_sha256']
  if sha(OUT/'candidate-CCG_v1.db')!=d['candidate_database_sha256']:drift.append({'dependency':'candidate-CCG_v1.db','historical_sha256':d['candidate_database_sha256'],'current_sha256':sha(OUT/'candidate-CCG_v1.db'),'conclusion':'Historical DB pin differs; current actor-row equality alone does not prove historical inputs. New scoped search refresh supersedes this gap.'})
 for run in d['runs']:
  if subjects and run.get('source') not in subjects:continue
  if 'artifact' in run:filename=run['artifact'];expected=run['expected_failures']
  else:
   filename=f"spell-search-{run['source']}-{run['target']}{'-'+run['control'] if run['control'] else ''}.json";expected=[{}] if run['control']=='no-search' else [{'wrongSet':True}] if run['control']=='any-search-filter' else []
  p0=OUT/filename;assert sha(p0)==run['artifact_sha256'];x=json.loads(p0.read_text());actual=[i for i,r in enumerate(x['results']) if r['failure']] if expected and all(isinstance(v,int) for v in expected) else [r['test'] for r in x['results'] if r['failure']];assert actual==expected,(name,filename)
 parents[name]={'sha256':sha(p),'scope':d['scope'],'verification':'Stored baseline/control outcomes and source/harness/runtime pins checked. Exact reconciliations accepted only where proved; metadata drift explicitly retained. No fresh engine replay of these historical artifacts.','input_drift':drift,'reviewed_source_subset':sorted(subjects) if subjects else None}
def old_group(key,code,names):
 refs={v['path']:v for v in counts['focused_evidence'][str(code)]['artifacts']};files=[]
 for name in names:
  p=OUT/name;d=json.loads(p.read_text());assert sha(p)==refs[name]['sha256'];assert d['script_sha256']==sha(ROOT/f'public/CCG Downloads/CCG_Scripts/c{code}.lua');assert all(not r['failure'] and not r['logs'] for r in d['results'])
  if name.startswith('spell-search-'):
   parent='spell-search-family-batch.json';check_parent(parent,{258241424,255953418});assert d['supporting_script_sha256']==sha(ROOT/'public/CCG Downloads/CCG_Scripts/c240976976.lua')
  else:parent=name[:-5]+'-batch.json';check_parent(parent)
  files.append({'file':name,'sha256':sha(p),'cases':len(d['results']),'scope':d['scope'],'parent':parent})
 evidence[key]={'passcode':code,'status':'HISTORICAL_SOURCE_MATCHED_WITH_METADATA_DRIFT' if any(parents[v['parent']]['input_drift'] for v in files) else 'PROVENANCE_RECONCILED_PUBLIC_ENGINE_EVIDENCE_REUSED','files':files}
def new_group(key,name):
 p=OUT/name;d=json.loads(p.read_text())
 for dep,h in d['runtime_dependencies_sha256'].items():check_dep(dep,h)
 for run in d['runs']:
  p0=OUT/run['file'];assert sha(p0)==run['sha256'];x=json.loads(p0.read_text());expected=run['expected_failures'];actual=[i for i,r in enumerate(x['results']) if r['failure']] if not expected or all(isinstance(v,int) for v in expected) else [r['test'] for r in x['results'] if r['failure']];assert actual==expected
 evidence[key]={'file':name,'sha256':sha(p),'status':d['status'],'qualification':d['qualification']}
old_group('plague_hand',217118040,['current-plague-doctor-summon.json','current-plague-doctor-summon-limit.json'])
old_group('plague_tuner',217118040,['current-plague-doctor-tuner.json','current-plague-doctor-interruption.json'])
old_group('plague_limits',217118040,['current-plague-doctor-shared-use.json','current-plague-doctor-negated-use.json'])
old_group('guardian_summon',252513554,['current-guardian-crying-summon.json','current-guardian-crying-necrovalley.json'])
old_group('guardian_level',252513554,['current-guardian-crying-level.json','current-guardian-crying-level-boundary.json','current-guardian-crying-level-interruption.json','current-guardian-crying-level-negation.json'])
old_group('guardian_limits',252513554,['current-guardian-crying-level-limit.json','current-guardian-crying-negated-use.json'])
old_group('light_search',258241424,['spell-search-258241424-240976976.json'])
old_group('world_search',255953418,['spell-search-255953418-240976976.json'])
old_group('throne_pair',216294702,['current-throne-summon.json'])
for key,name in [('hunter_choice','current-field-set-boolean-choice-review.json'),('ram_revive','current-ram-redirect-timing-review.json'),('negation_timing','current-crying-negation-damage-window-review.json'),('throne_redirect','current-throne-bottom-redirect-review.json'),('search_refresh','current-crying-search-refresh-review.json'),('light_gy','current-crying-light-grave-review.json'),('light_limits','current-crying-light-limits-review.json'),('world_trigger','current-crying-world-trigger-review.json'),('search_boundaries','current-crying-search-boundaries-review.json'),('throne_limits','current-throne-activation-limits-review.json'),('world_limits','current-world-named-limits-review.json'),('ram_tribute','current-ram-tribute-resource-review.json'),('hunter_attack','current-hunter-attack-scaling-review.json'),('zebra_revival','current-zebra-revival-review.json'),('zebra_damage','current-zebra-material-damage-review.json')]:new_group(key,name)
def c(label,hooks,e=(),gap='Original behavior, interruptions and applicable named-use/reset coverage not reconciled'):
 return {'clause':label,'source_functions':hooks.split(','),'evidence':list(e),'status':('SCOPED_TEST_MAPPED_EVIDENCE' if any('TEST_MAPPED' in evidence.get(k,{}).get('status','') for k in e) else 'SCOPED_PUBLIC_ENGINE_EVIDENCE') if e else 'SOURCE_MAPPED_BEHAVIOR_OPEN','remaining':gap}
config={
221047295:[c('Hand Quick discard/target/revive Level3-or-lower Zombie','spop1'),c('With own high-Level Crying Chaos Synchro, banish self to summon Level3 Zombie from Hand/GY','spcon2,spop2')],
233436485:[c('Normal Monster/flavor text; empty initial_effect and standard metadata','initial_effect',gap='No card-specific effect to execute; standard summon/battle/live checks not certified')],
217118040:[c('Own low-Level Zombie enables original inherent Hand summon','spcon',['plague_hand'],gap='Scoped boundary/shared-success/reset evidence reused; inherent summon-negation boundary/live Omega not certified'),c('With no own Tuner, send Hand card as cost; become Tuner for turn','tuncon,tuncost,tunop',['plague_tuner','plague_limits'],gap='Existing interruption, paid cost, shared use/negation/reset evidence reused; live Omega/full-card certification open')],
218261525:[c('Synchro material sent GY: send Crying Chaos monster Deck to GY','tgcon,tgop'),c('Banish self plus two Zombies to summon Zombie Link2 as Link Summon','spcost,spop',gap='Original payment/Link summon/history/use/reset open; completion source-only exclusion retained separately')],
236017388:[c('Normal/Special Summon: Deck Level3 Zombie Tuner summon then Zombie lock','spop'),c('As Synchro material, revive self then banish on leave','spcon2,spop2',gap='Original material event/revival/redirect and named sharing/reset open; no artificial immediate departure assumed')],
240976976:[c('Normal/Special Summon: Zombie Hand-to-GY cost, search Crying Chaos Spell/Trap','thcost,thop'),c('As Link/Synchro material, bottom self as cost then draw','drcon,drcost,drop')],
240511702:[c('Continuous +400 ATK per own field/GY Zombie','atkval,atkfilter',['hunter_attack'],gap='Eight dynamic position/location/owner/Race/control/Skill Drain cases; seeded source, live Omega remains open'),c('Sent GY: banish self then search monster or Set Spell/Trap','thcost,thop',['hunter_choice'],gap='Eight Hunter cases within24-case family cover Set/Add/capacity/actual cost; named sharing/reset and other response boundaries open')],
252513554:[c('Own high-ATK Crying Chaos support permits inherent Hand/GY summon','spcon',['guardian_summon'],gap='Eligibility, current2500 threshold, Hand/GY and Necrovalley evidence reused; live Omega not certified'),c('On Special Summon, optionally +/-2 Level until End Phase','lvop',['guardian_level','guardian_limits'],gap='Boundary, interruption/negation, expiry/shared-use/reset evidence reused; live Omega/full-card certification open')],
224943273:[c('Link recipe: two low-Level Zombies including Crying Chaos','matfilter,lcheck'),c('On Link Summon search Level3 Crying Chaos Tuner','thcon,thop'),c('Field to GY: summon low-Level Zombie from Hand/GY','spcon,spop')],
227610954:[c('Link recipe includes Zombie Link monster','lcheck'),c('Link Summon with Crying Chaos Link: shuffle3 GY/banished cards','tdcon,tdop'),c('Pointing to Crying Chaos Synchro permits half linked-monster ATK gain','atkcon,atkop')],
239725695:[c('On Synchro Summon target/revive own GY Zombie','spcon,spop',['zebra_revival'],gap='Ten original effect cases/five effective faults; source-helper typed GY summon bypasses original recipe/revival limit, original procedure/use/reset/live remain open'),c('As Synchro material, damage per own field/GY Zombie','damcon,damop',['zebra_damage'],gap='Nine native material/count/resolution cases with explicit target-player9 mapping; unadapted original flag failure retained. Source seeded, original recipe/named use/reset/live remain open')],
249018041:[c('On Synchro Summon revive low-Level GY Zombie, banish on leave','spcon,spop',['ram_revive'],gap='Two original-operation redirect cases; source-helper typed GY setup bypasses source recipe/revival limit; original Synchro procedure/API gap retained'),c('Tribute own monster to destroy selected field card','descost,desop',['ram_tribute'],gap='Seven cost/resource/actual destruction cases, old two failures and four effective faults; original source seeded, use/reset/other responses/live remain open')],
220305422:[c('On Synchro Summon summon Level3 Zombie Tuner Deck/GY','spcon,spop'),c('Quick monster-effect response targeting own field/GY: banished Zombie cost then negate effect','negcon,negcost,negop',['negation_timing'],gap='Two Natir timing cases, original cost/negation; explicit chain-target mapping, original recipe/other response boundaries/use/reset/live open')],
234296128:[c('Synchro Summon using Zombie Synchro: summon low-Level Zombie Deck/GY','spcon,spop'),c('Quick leave-field response: Tribute Crying Chaos, negate and gain combined stats','negcon,negcost,negop',['negation_timing'],gap='Three Revelation timing/payment/ATK cases; seeded source/Catastor attribute mapping; original recipe/other leave-field categories/use/reset/live open')],
233499093:[c('On Synchro Summon return opponent field to Hand','thcon,thop'),c('Quick monster effect negation then shuffle GY Zombie','negcon,negop',['negation_timing'],gap='Four Dragon timing cases and actual shuffle/negation; seeded source/Catastor query mapping; original recipe/use/reset/live open')],
258241424:[c('Activate to search low-Level Crying Chaos monster','thop',['light_search','search_refresh','light_limits','search_boundaries'],gap='Canonical search plus eight filter/movement cases and ten named-use/reset cases verified; live Omega and special timing overrides unverified'),c('Banish self GY; recover or bottom Zombie Tuner from GY/banishment','gyop',['light_gy','light_limits'],gap='Fourteen recovery cases plus ten named-use/reset cases; live Omega/special timing overrides remain open; ordinary same-turn dual-player case inapplicable to own-Main-only actions')],
216294702:[c('Target same-Level face-up banished Zombie pair and summon to own field','target,activate',['throne_pair','throne_limits'],gap='Seven eligibility/ownership plus three sharing/effect-negation/next-own-turn cases, explicit chain-target mapping; activation-negation/OATH and live remain qualified'),c('Revived pair return to each owner Deck bottom on leave','activate',['throne_redirect'],gap='Two mixed-owner immediate/later departure cases with real Mammoth; stop before unrelated damage, chain-target mapping retained; other interruptions/limits/live open')],
255953418:[c('Field activation may search Crying Chaos monster','activate',['world_search','search_refresh','search_boundaries','world_limits'],gap='Canonical search/filter/optional/movement and named sharing/Main-trigger independence verified; search activation-negation/next-turn reset now exercised; player scope/live not fully verified'),c('Own Crying Chaos Synchro Summon: target/revive low-Level Zombie, bottom on leave','spcond,spop',['world_trigger','world_limits'],gap='Twelve effect cases plus nine named-limit cases including source replacement/effect-negation/trigger reset; neutral treated-as-Synchro event, original recipes/history/player scope/live remain open')],
253472430:[c('With Crying Chaos Synchro and Zombie Tuner, immediate Synchro using both','synchrotg,synchroop'),c('With Dragon, banish GY self to take opponent monster for turn, negate and zero stats','ctcon,ctop')]
}
for code,clauses in config.items():
 if 'Synchro' in (roster[code].get('cardTypes') or []):
  recipe=roster[code]['text'].split('\n',1)[0]
  clauses.insert(0,c('Original Synchro recipe: '+recipe,'initial_effect',gap='Original recipe/proper-summon history unverified; applicable legacy-helper/runtime qualifications remain; no substitute recipe or extra failure probe used'))
a=sqlite3.connect(OUT/'current-spec-CCG_v1.db');b=sqlite3.connect(FILES/'Databases/CCG_v1.db');old=sqlite3.connect(OUT/'candidate-CCG_v1.db');rows=[]
for code,clauses in config.items():
 p=ROOT/f'public/CCG Downloads/CCG_Scripts/c{code}.lua';s=p.read_text();assert p.read_bytes()==(FILES/'Scripts'/p.name).read_bytes();hooks=set(re.findall(r'^function s\.(\w+)\(',s,re.M))
 for clause in clauses:assert set(clause['source_functions'])<=hooks,(code,clause['source_functions'],hooks)
 x=a.execute('select * from datas where id=?',(code,)).fetchone();y=b.execute('select * from datas where id=?',(code,)).fetchone();named=[l.strip() for l in s.splitlines() if ':SetCountLimit(' in l];limits='Existing cross-copy/negation/reset evidence reused' if code in [217118040,252513554] else 'Source registrations mapped; behavioral named-use/sharing/negation/reset requirements remain open where printed'
 if code in [258241424,255953418]:assert old.execute('select * from datas where id=?',(code,)).fetchone()==y
 rows.append({'passcode':code,'name':roster[code]['name'],'source_sha256':sha(p),'installed_matches':True,'candidate_metadata_matches_installed_now':x==y,'clauses':clauses,'named_limit_registrations':named,'named_limit_status':limits,'full_card_audit':'OPEN','live_omega_verified':False})
assert len(rows)==19 and {c['passcode'] for c in spec if c.get('archetype')=='Crying Chaos'}==set(config);assert old.execute('select * from datas where id=240976976').fetchone()==b.execute('select * from datas where id=240976976').fetchone()
report={'scope':'All19 Crying Chaos cards have printed-clause/source mappings with explicit scoped evidence and behavioral gaps. Stored sound tests reused by exact source/artifact/parent/runtime verification. Search-family historical candidate-DB drift is retained and superseded only by the separate fresh four-case search review. No entire-card/live certification; current metadata comparison is recorded separately.','spec_sha256':sha(ROOT/'src/data/cards.json'),'review_script_sha256':sha(Path(__file__)),'provenance_checker_sha256':sha(ROOT/'scripts/fresh_repair_ledger.py'),'evidence':evidence,'parent_provenance_reviews':parents,'unique_dependency_pairs_checked':len(checked),'exact_reconciled_dependencies':sorted(reconciled),'cards':rows,'next_priority':['Light ordinary printed search/recovery/named-use/reset has scoped evidence; live Omega remains open, special timing overrides not exhaustive. Ordinary simultaneous dual-player use is not an own-Main-action requirement.','Throne shared activation/effect-negation/next-own-turn reset now has three original-effect cases; activation-negation/OATH needs supported runtime, do not repeat ineffective public flag probes.','World trigger/revival/bottom plus named sharing/replacement/independence/negated-effect/reset scoped; original Synchro recipe/history and revival activation-negation/player scope/live remain.','Hunter ATK scaling now scoped in eight cases; named use/reset/other responses plus remaining material/summon clauses remain. Do not replay completed aura/timing/Set families.']}
(OUT/'current-crying-chaos-clause-map.json').write_text(json.dumps(report,indent=2)+'\n')
print(json.dumps({'cards':len(rows),'clauses':sum(len(r['clauses']) for r in rows),'scoped_evidence_clauses':sum(bool(c['evidence']) for r in rows for c in r['clauses']),'parent_reports_reviewed':len(parents),'dependency_pairs':len(checked),'reconciled_dependencies':sorted(reconciled),'full_cards_promoted':0}))

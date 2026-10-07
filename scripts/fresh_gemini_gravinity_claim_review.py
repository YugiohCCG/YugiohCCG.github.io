"""Source-specific verdicts; supported gaps are not falsely marked installed fixes."""
import hashlib,json
from pathlib import Path
ROOT=Path(__file__).resolve().parents[1];OUT=ROOT/'output/fresh-ccg-september'
inventory=json.loads((OUT/'gemini-wave2-inventory.json').read_text(encoding='utf-8'))
findings=[]
def add(code,line,status,reason):
 card=next(c for c in inventory['cards'] if c['passcode']==code)
 assert hashlib.sha256((ROOT/'public/CCG Downloads/CCG_Scripts'/f'c{code}.lua').read_bytes()).hexdigest()==card['source_sha256']
 findings.append({'passcode':code,'name':card['name'],'report_line':line,'source_sha256':card['source_sha256'],'verdict':status,'reason':reason,'implemented':False,'native_omega_verified':False})
for code,line in [(212345347,2753),(249454272,3688)]:
 add(code,line,'PARTLY_SUPPORTED_SCOPE_GAP','Source registers the permission on the prospective material while it is in SZONE. Calling that intrinsically wrong ignores the engine material-side permission mechanism. However this alone does not grant permission to every Gravinity Monster Card placed there by other effects. A complete destination/material test is required; do not remove all material-side effects as unprinted extras.')
for code,line in [(212345347,2764),(212429024,2917),(249454272,3690)]:
 add(code,line,'SUPPORTED_SOURCE_GAP','Previous SZONE alone is checked without previous controller. Printed your Spell & Trap Zone requires the previous controller distinction; test opponent-controlled SZONE transfer separately.')
for code,line in [(212345347,2769),(249454272,3692)]:
 add(code,line,'PARTLY_SUPPORTED_PREDICATE','IsType(TYPE_TRAP) does not explicitly require Continuous Trap. Requiring both Trap and Continuous type bits is sufficient; strict GetType equality is stronger than the printed requirement if extra type bits can exist. No observed failure supplied.')
for code,line in [(212345347,2774),(249454272,3694),(212429024,2919)]:
 add(code,line,'SUPPORTED_SOURCE_TIMING_GAP','The printed then separates events. Current successful draw->summon or return->draw path has no BreakEffect. Preserve success dependence and optionality when inserting timing separation; full operation cases remain required.')
for code,line in [(212429024,2915),(231088629,3240)]:
 add(code,line,'SUPPORTED_SOURCE_GAP','Cannot-disable-Special-Summon effect is unconditioned although printed protection is only for Synchro Summon. A permitted other inherent summon can expose the wider protection; summons during chain resolution already cannot be negated, so the GY-effect example alone does not prove an exploit.')
for code,line in [(212429024,2921),(238184015,3567)]:
 add(code,line,'SUPPORTED_SOURCE_DIFFERENCE','Type-change effect lacks CANNOT_DISABLE and includes TURN_SET reset, unlike the established family trapification implementation. Verify actual disable/set persistence and intended leave-field reset before applying the family pattern.')
add(212429024,2923,'NEEDS_EVENT_TRACE','EVENT_CHAIN_SOLVED handling lacks a negation guard. The relationship between chain-solved dispatch and activation/effect negation must be tested before declaring every negated resolution triggers this effect.')
for code,line in [(215768254,3064),(235538173,3422),(249680945,3816),(256172827,3964)]:
 add(code,line,'SUPPORTED_SOURCE_GAP','Two bullets of one named once-per-turn effect are registered with distinct id+100/id+200 counters, allowing separate uses. Sharing a counter repairs the restriction; a single modal effect is not inherently required. Transfer Call overriding branch execution must remain supported.')
for code,line in [(215768254,3066),(235538173,3423),(249680945,3817),(256172827,3965)]:
 add(code,line,'SUPPORTED_SELECTION_GAP','SelectDisableField receives zero explicit exclusion mask and only checks CheckLocation after choice. This allows a selection that produces no movement rather than offering only another valid column. Actual selection-mask evidence is still required; MoveSequence legality is not itself bypassed.')
for code,line in [(215768254,3068),(235538173,3424),(249680945,3818),(256172827,3966)]:
 add(code,line,'REJECTED_BLANKET_REMOVAL','Material-side permission is used to implement Lapsix/Galaxix printed SZONE material allowance. Removing it as an unprinted bonus without providing a tested replacement permission mechanism would break an intended mechanic.')
add(215768254,3070,'UI_TIMING_IMPROVEMENT_NOT_PROVEN_DEFECT','Hint timing improves prompts, but its absence is not evidence the legal Main Phase Quick Effect cannot activate.')
add(235538173,3425,'NEEDS_FORBIDDEN_CASE','Deck-to-SZONE target predicate omits IsForbidden. Test the actual prohibition/placement rules and MoveToField behavior rather than certify an illegal play from the omission alone.')
add(238184015,3565,'SUPPORTED_TARGET_PREPARATION_GAP','copytg never delegates original target checks/selection/properties, yet copyop delegates the original operation. It may miss targets or parameters. e:GetHandler itself is not nil: it is Sonic Scream. Monster effect copying needs tested event/handler semantics, not blindly transplanting CheckActivateEffect for Trap activation.')
add(231088629,3229,'REPRODUCED_PUBLIC_ENGINE','Actual neutral Spell Special Summon with full canonical Spherix fails interception; isolated removal of only IsRelateToEffect(e) passes. Diagnostic source/harness hashes and native SPSUMMONED/MOVE trace captured. Initial Spherix placement, neutral recipient and public engine are explicit boundaries.')
add(231088629,3234,'SUPPORTED_SOURCE_GAP','Attachment count is fixed at two. Printed minimum Xyz material count depends on the individual Xyz monster and procedure; hardcoding two does not generally satisfy it. Determine the Omega-supported way to evaluate procedure requirements rather than inventing a GetMinMaterials API.')
add(231088629,3236,'SUPPORTED_SOURCE_GAP','After Special Summon, source automatically overlays two eligible cards without the printed optional choice or then timing break.')
add(231088629,3238,'SUPPORTED_SOURCE_GAP','Opponent shuffle predicate requires face-up although text allows one opponent monster without that qualifier. Need a face-down recipient case and column-mate checks.')
add(256831125,4109,'PARTLY_SUPPORTED_SCOPE_QUESTION','coltg only scans own MZONE. Printed Gravinity monster may differ from Gravinity Monster Card when cards are treated as Continuous Traps. Source metadata/original-type interpretation must be settled before broadening to every archetype Spell/Trap on field. Blind LOCATION_ONFIELD replacement also includes ordinary Gravinity Spells/Traps.')
add(256831125,4111,'NOT_ESTABLISHED_BLANKET_SCOPE','Omission of an explicit on-field phrase does not by itself prove every GY/banished card is protected by a Field Spell. Report supplies no comparable official scope or legal off-field targeting scenario. Do not add hidden information locations blindly.')
add(256831125,4113,'SUPPORTED_SHARED_SOURCE_PATTERN','Copied summon interceptor contains the same relation check reproduced as failing in Spherix. Axis Matter activation/reveal/copy case remains untested; shared pattern is evidence, not a completed copied-effect scenario.')
diagnostic=OUT/'spherix-interception-diagnostic.json';d=json.loads(diagnostic.read_text(encoding='utf-8'))
assert d['source_sha256']==next(c['source_sha256'] for c in inventory['cards'] if c['passcode']==231088629)
assert d['harness_sha256']==hashlib.sha256((ROOT/'scripts/fresh_spherix_summon_interception.cjs').read_bytes()).hexdigest()
for file,h in d['runtime_dependencies_sha256'].items():assert hashlib.sha256((ROOT/file).read_bytes()).hexdigest()==h
assert len(d['results'])==2 and d['results'][0]['failure']=='Newly summoned monster must be placed in S/T Zone' and d['results'][1]['failure'] is None
result={'report_sha256':inventory['report_sha256'],'scope':'All numbered card-specific Group D claims given explicit evidence-scoped verdicts. Not completed card audits or installed fixes.', 'diagnostic_sha256':hashlib.sha256(diagnostic.read_bytes()).hexdigest(),'claims':findings}
(OUT/'gemini-gravinity-claim-review.json').write_text(json.dumps(result,indent=2)+'\n',encoding='utf-8')
lines=['# Gravinity claim-level fact-check','','All 10 cards, all 37 numbered card-specific claims reviewed. Supported source gaps still need repair/regression work; no fixes installed by this review.','', '| Card / report line | Verdict | Reason |','|---|---|---|']
for f in findings:lines.append(f"| {f['passcode']} {f['name']} / {f['report_line']} | {f['verdict']} | {f['reason']} |")
(ROOT/'docs/OMEGA-GEMINI-GRAVINITY-CLAIMS.md').write_text('\n'.join(lines)+'\n',encoding='utf-8')
print(json.dumps({'claims':len(findings),'cards':len({f['passcode'] for f in findings}),'full_card_audits_added':0,'production_changes':0}))

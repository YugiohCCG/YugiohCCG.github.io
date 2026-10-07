"""Publish source-based verdicts without converting heuristic flags into completed audits."""
import collections,hashlib,json,re
from pathlib import Path
ROOT=Path(__file__).resolve().parents[1];OUT=ROOT/'output/fresh-ccg-september'
inventory=json.loads((OUT/'gemini-claim-inventory.json').read_text(encoding='utf-8'))
fixes=json.loads((OUT/'gemini-supported-fixes.json').read_text(encoding='utf-8'))
verdicts={
141:('NOT_ESTABLISHED','Revive-limit status is checked by core paths; absence of a repeated Lua check is not proof of bypass. Native Omega procedure test remains needed. The alleged obsolete IsHasEffect is explicitly used by Omega utility.lua:922.'),
153:('REJECTED','Omega procedure.lua:868-885 permits generic predicate materials only through the predicate. Fusion substitution is added only to numeric named materials. sub=true cannot bypass these generic predicates.'),
158:('IMPLEMENTED','Add Damage Step/calculation flags matching Omega Baronne c84815190:28.'),
256:('IMPLEMENTED','Register the two generic Fusion materials while retaining the required-first contact procedure and summon restriction.'),
258:('REJECTED','Lua 5.3 bitwise syntax is valid for this Omega workspace. The core completes inherent summons itself (operations.cpp:2945); do not add CompleteProcedure before a summon succeeds.'),
261:('IMPLEMENTED','Core cost-to-Deck rejects Extra Deck monsters (card.cpp:3910); use Omega IsAbleToDeckOrExtraAsCost, as official Claudius does.'),
268:('ALREADY_CORRECT','Current s.mzonecheck includes GetSequence()<5. A vacated EMZ does not provide a Main Deck summon zone; actual Deck summon resolution checks MMZ space.'),
415:('IMPLEMENTED','Apply the existing immunity filter to ordinary Fusion materials at activation and resolution. Preserve Chain Material support.'),
422:('REJECTED','Omega FCheckMixGoal already checks GetLocationCountFromEx with the selected material group (procedure.lua:979). No premature standalone zone check occurs at this reported line.'),
567:('REJECTED_BLANKET_CHANGE','Omega official targeting scripts use this helper. Removing it everywhere is not an Omega compatibility fix. The report does not reproduce a Prism-specific legal activation failure.'),
579:('NOT_ESTABLISHED','A clearer equivalent predicate is not a demonstrated behavior fix. Existing focused Prism cases cover field ownership/set restrictions; face-down archetype semantics need a separate engine case.'),
672:('IMPLEMENTED','All five Stellaer alternative-procedure blockers now require face-up Xyz monsters.'),
684:('IMPLEMENTED','All five destruction/draw operations now call BreakEffect after successful destruction and before drawing.'),
693:('REJECTED','IsDestructable(e) is accepted by numerous local Omega official scripts, including c100261050:78 and c101306054:86. This is not invalid Lua syntax.'),
695:('REJECTED_BLANKET_CHANGE','Same unsupported wholesale Necrovalley targeting assertion; keep the Omega helper.'),
697:('IMPLEMENTED','Lighting main-phase recovery is ignition; retain the separate optional Xyz-summon trigger.'),
889:('IMPLEMENTED','Require a nonempty material group for using only Windborne materials. Windwitch Diamond Bell checks nonempty; the cited Melusine does not, so the report overstates agreement between its references.'),
898:('REJECTED_BLANKET_CHANGE','Keep the Omega Necrovalley targeting helper; no demonstrated card-specific failure supplied.'),
1084:('REJECTED','Omega Auxiliary.GetColumn(c,p) explicitly sets p=p or 0 at utility.lua:703. Both cards are compared in the same global perspective; omitting p is supported.'),
1092:('IMPLEMENTED','Translate EMZ sequence 5/6 into columns 1/3, then mirror for ownership before using S/T sequences.'),
1098:('IMPLEMENTED','Declare CATEGORY_DESTROY for the optional placement trigger that can destroy occupying cards.'),
1236:('IMPLEMENTED','Deferred search and Set counts are capped to available cards. Added an actual delayed-search shortage scenario, which passes with the fix.'),
1244:('REJECTED','Omega NecroValleyFilter forwards varargs to the wrapped filter. Passing the different-name code is supported (utility.lua:922).'),
1304:('PARTIALLY_IMPLEMENTED','Add the missing original-owner control check. GetReasonPlayer expresses the card reason directly, but report does not prove rp is inherently wrong for battle/nonactivated reasons.'),
1311:('REJECTED','Local Omega Baronne c84815190:71 uses the same EVENT_CHAINING event group for destruction. An unsupported claim that eg can be an unrelated card does not justify replacement.'),
1363:('NOT_REQUIRED','Existing actual draw cases resolve target-player/parameter correctly without the flag. The report claim that chain info necessarily fails is contradicted by the engine tests.'),
1372:('IMPLEMENTED','Use activating player plus recorded activation location, rather than requiring the handler still on the field after paying costs. Added actual self-cost draw scenario.'),
1421:('IMPLEMENTED','Add DELAY to optional If-flipped trigger.'),
1430:('IMPLEMENTED','Retain a Ghostrick self-Set activation flag through face-down state, following official Omega Ghostrick Witch. Updated actual reflip test and its counterexample.'),
1514:('NOT_REQUIRED_FOR_SHOWN_EVENTS','Battle destruction/damage events occur in their battle windows, not arbitrary CL2+ summon resolution. The cited Gadjiltron Dragon script contains no such battle trigger. No missed-timing case is supplied.'),
1522:('IMPLEMENTED','Player-target flag fixes the opponent attack prohibition. Cited c21142671 is Red Nova in this snapshot, not Cyber Barrier Dragon; verify references rather than trusting their labels.'),
1594:('IMPLEMENTED','Clement Winds shuffles the number of cards actually returned to hand, capped by available eligible hand cards; add sequential timing separation.'),
1600:('REJECTED','Omega utility.lua:922 explicitly supports a nil filter; the resulting predicate checks only Necrovalley.'),
1663:('NOT_REQUIRED_FOR_SHOWN_EVENTS','Battle event timing alone does not demonstrate an optional trigger missing timing. Do not blindly add delay to every optional trigger.'),
1672:('IMPLEMENTED','Battle destruction condition now checks any attacking monster you control and its battle-destroyed opponent.'),
1678:('REJECTED','The mandatory End Phase return must apply to every copy. A shared name count would incorrectly leave additional copies on the field; this is not a discretionary effect use.'),
1746:('CONFIRMED_ENGINE_LIMITATION','Condescender omits Link-rating reduction. Omega constant.lua has no UPDATE_LINK/CHANGE_LINK effect. Gemini drop-in code must not invent an unsupported effect code; native-core support/card design is needed.'),
1754:('NOT_ESTABLISHED','Minimum Level handling belongs to core too. The report supplies no native below-one result. Do not clamp a printed declared reduction solely on this assertion.'),
1829:('REJECTED','Calling a returned Lua closure inline is valid; Omega helper forwards arguments. The proposed convention does not establish a bug.'),
1836:('METADATA_IMPROVEMENT_ONLY','Possible add-to-hand operation information could improve effect-response metadata. Missing optional operation information is not proof the card fails to recover; not copied as a replacement.'),
1925:('REJECTED_BLANKET_CHANGE','Copied Krawler modes use the Omega targeting helper as their official local scripts do; no wholesale removal.'),
1933:('IMPLEMENTED','Explicitly reject face-down banished archetype cards and confirm successfully recovered cards. Report inconsistently says IsSetCard already returns false yet calls missing guard a proven exploit.'),
1941:('REJECTED','Selecting a single allowed position first does not necessarily duplicate a prompt or break the engine. No demonstrated double prompt/crash was supplied.'),
2117:('REJECTED','Report confuses sequence constants: Omega SEQ_DECKTOP=0, SEQ_DECKSHUFFLE=2. Its own proposed 2 equals the current value. Extra Deck destination is determined by card type.'),
2122:('METADATA_IMPROVEMENT_ONLY','No concrete failure or required matching operation category demonstrated for setting from banishment.'),
2169:('REJECTED','Reset includes RESETS_STANDARD plus end-of-turn expiry, appropriate for can activate this turn. Missing optional client hint is not a broken summon/Set effect.'),
2174:('REJECTED','Same numeric sequence error: current SEQ_DECKSHUFFLE already equals 2.'),
2234:('REJECTED','Cloned battle triggers share the same name count limit. Report overlooks that consumed limit and the separate battle-damage/destruction timing windows.'),
2240:('METADATA_IMPROVEMENT_ONLY','Operation info for deck banishment can improve response metadata; absence alone is not evidence of a failed effect.'),
2245:('REJECTED','Same numeric sequence error; the proposed 2 is the current SEQ_DECKSHUFFLE.'),
2287:('IMPLEMENTED_WITH_CORRECTED_RATIONALE','Explicit Link Extra Deck zone check includes the departing handler. Missing check can admit an unavailable summon; report does not prove IsCanBeSpecialSummoned itself checks zones or that activation was always blocked from EMZ.'),
2298:('REJECTED','Both clones already share id+100 count. Adding a separate damage-step flag is not necessary to establish the printed HOPT.'),
2300:('METADATA_IMPROVEMENT_ONLY','Search/summon operation information is useful metadata; absence is not a proven Lua exception or failed effect.'),
2368:('NOT_ESTABLISHED','Core collects events with effect ranges at event time; DELAY does not by itself prove retroactive GY eligibility. Needs LP-payment event fixture before changing condition.'),
2376:('NOT_ESTABLISHED','Verify candidate strings and prompt context first. Report gives no corrected existing string slot; changing an index arbitrarily can worsen Omega prompts.'),
2414:('IMPLEMENTED','Explicit face-up banished-card guard in Aerocat recovery.'),
2419:('REJECTED_BLANKET_CHANGE','Keep the valid Omega Necrovalley helper; no wholesale targeting rewrite.'),
2421:('METADATA_IMPROVEMENT_ONLY','Optional draw operation info may help responses; report does not demonstrate failed drawing. Avoid falsely declaring conditional drawing unconditional.'),
2474:('REJECTED','Core pushes this link before executing target registration (processor.cpp:4096 vs 4251). chk=0 needs +1, chk=1 already includes the link. Gemini proposed +1 at registration would be off by one.'),
2491:('NOT_ESTABLISHED','Printed effect destroys an exact chain-link number, not up to that many. Fewer remaining cards is a ruling question; report cannot change wording to up to without justification.'),
2537:('REJECTED','Existing Priestess engine tests retrieve and execute a registered Standby trigger, including official support. It deliberately skips activation condition and applies target/operation with original handler. Report describes an earlier implementation inaccurately.'),
2608:('REJECTED','The independent also restriction applies when the effect resolves, even if Fusion Summoning becomes impossible. Applying it in resolution before an early return implements that dependency; effect negation prevents operation execution.'),
2615:('REJECTED_BLANKET_CHANGE','Omega registered Fusion material procedure already verifies material-vacated zones. Generic raw IsCanBeSpecialSummoned is not a replacement for inspecting CheckFusionMaterial/helper behavior.'),
2624:('NOT_ESTABLISHED','Different material destinations necessarily use distinct core actions. Report offers no supported atomic multi-destination API or concrete failing scenario; its replacement is not shown atomic either.'),
2630:('IMPLEMENTED','Remove unjustified REASON_EFFECT restriction from Stain return-to-Deck tracking.'),
2973:('REJECTED','Blind replacement would break GY/hand/Deck summons. All 51 master-ledger zone flags are context-screened separately below.'),
2974:('REJECTED','Separate named HOPT, printed per-copy effects, delayed resolution effects, mandatory returns and granted material effects. Sharing id everywhere changes behavior.'),
2975:('REJECTED_BLANKET_CHANGE','Delay depends on event and wording, not simply optional type. Fix the specific optional flip case; phase/battle events need their own timing reasoning.'),
2976:('REJECTED','Contradicts local Omega helper usage; do not wholesale remove targeting guards.'),
2977:('REJECTED_BLANKET_CHANGE','Core inherently completes procedure summons. Missing EnableReviveLimit can be a real issue, but does not validate adding CompleteProcedure to every contact operation.'),
2978:('ADOPTED_WITH_LIMITS','Use shared automated effect tests, mutation controls and source hashes. Public core plus Omega helper tests do not certify the installed native Omega runtime.')}
assert set(verdicts)=={c['line'] for c in inventory['deep_claims']}
for claim in inventory['deep_claims']:
 claim['verdict'],claim['reason']=verdicts[claim['line']]
base={int(c['passcode']):c for c in json.loads((OUT/'baseline-remote.json').read_text(encoding='utf-8'))['cards']}
byfix={c['passcode']:c for c in fixes['changes']}
soft_plain={215105971,215142357,220124524,230812008,232706629,235051716,236744343,245395343,248760718,252210718,255668557,257677549,259226799,259489283,259792415,259844716}
for row in inventory['master_rows']:
 code=row['passcode'];p=ROOT/f'public/CCG Downloads/CCG_Scripts/c{code}.lua'
 source=Path(byfix[code]['backup']).read_text(encoding='utf-8') if code in byfix else p.read_text(encoding='utf-8')
 ls=source.splitlines();numbers=[int(v.strip()) for v in row['claimed_lines'].split(',') if v.strip().isdigit()]
 row['cited_source']=[{'line':n,'text':ls[n-1] if n<=len(ls) else 'OUT OF RANGE'} for n in numbers]
 row['card_text']=base[code]['text'] if code in base else None
 row['category_verdicts']=[]
 for category in row['categories']:
  if category in {'DEFECT','CUSTOM_GAP'}:
   verdict='UNSUBSTANTIATED';reason='No actionable effect, expected behavior or reproducer is specified by this label. Analogue resemblance is not proof; see any separate deep-dive verdict.'
  elif category=='EXTRA_DECK_ZONE_CHECK':
   verdict='REJECTED_AS_FLAGGED';reason='Cited zone check concerns hand/GY/Deck or other non-Extra-Deck summons, which use Main Monster Zones. Card being an Extra Deck monster does not change its GY summon destination.'
   if code==259225324:reason='Hand Pendulum zone count and Extra Deck Pendulum zone count are already checked separately in both target and operation.'
   if code==221855414:reason='Handler returns to Extra Deck, but the monsters subsequently summoned come from the GY; MMZ count is correct.'
  elif category=='SOFT_OPT_DISCREPANCY':
   verdict='REJECTED_AS_FLAGGED';reason=('Cited branch is printed per-copy once per turn, a granted per-copy effect, or mandatory each-copy return; no named HOPT belongs on that branch.' if code in soft_plain else 'Cited SetCountLimit(1) is a generated delayed resolution/cleanup effect. The activation effect has its own named count; delayed effects must not consume/share that activation count again.')
  elif category=='MISSING_NECROVALLEY_FILTER':
   verdict='UNSUBSTANTIATED';reason='Cites line 1 (header), with no affected effect identified. This category also conflicts with the deep-dive demand to remove targeting filters. Needs a concrete GY operation/cost analysis.'
  elif category=='MISSING_TRIGGER_DELAY_FLAG':
   verdict='IMPLEMENTED' if code==212052682 else 'REJECTED_AS_FLAGGED'
   reason='Optional If-flipped effect now delayed.' if code==212052682 else 'Cited branch is phase/battle timing; missing DELAY alone does not establish missed timing at CL2+. No scenario is provided.'
  elif category=='TARGET_RELATION_CHECK':
   verdict='REJECTED_AS_FLAGGED';reason='Cited line already checks tc and tc:IsRelateToEffect(e).'
  else:raise AssertionError(category)
  row['category_verdicts'].append({'category':category,'verdict':verdict,'reason':reason})
 row['status']='CLAIMS_SCREENED_NOT_FULL_CARD_AUDIT'
counts=collections.Counter(c for r in inventory['master_rows'] for c in r['categories'])
inventory['actual_master_category_counts']=dict(counts)
inventory['deep_verdict_counts']=dict(collections.Counter(c['verdict'] for c in inventory['deep_claims']))
inventory['limits']='All assertions screened; unresolved engine/design questions are explicitly not established, and generic ledger labels are unsubstantiated. This is not a full audit of the 266 cards or native Omega certification.'
(OUT/'gemini-claim-review.json').write_text(json.dumps(inventory,indent=2)+'\n',encoding='utf-8')
doc=['# Critical review of Gemini Omega audit','',
 'The report is a source of hypotheses, not a verified defect count. Each numbered deep-dive/roadmap claim and all 266 master rows have a verdict in the machine-readable ledger. **21 cards received targeted source changes; this does not mean 21 fully audited cards.**','',
 '## Report reliability','',
 '- Claims 621 scripts and full coverage, versus the pinned 711-card roster.',
 '- Master table actually tags 51 zone cases, 32 soft-count cases and 1 target-relation case; summary claims 93, 35 and 42 respectively.',
 '- 165 master rows cite only Logic/Structural; their DEFECT/CUSTOM_GAP labels do not identify an actionable claim.',
 '- Several named reference passcodes do not match this Omega snapshot (for example c21142671 is Red Nova).',
 '- Proposed return sequence 2 is already SEQ_DECKSHUFFLE=2; SEQ_DECKTOP=0 in Omega. Those replacements do not fix what the report says.',
 '- Generic Fusion predicate materials cannot be replaced by substitutes simply because sub=true. Omega helper distinguishes predicates from named numeric materials.',
 '- Omega NecroValleyFilter accepts nil and forwards extra filter arguments; GetColumn defaults to player-zero perspective.',
 '- Native Omega gameplay remains unverified. Public engine tests and callback tests have distinct limits.','',
 'Konami confirms face-down Fusion/Synchro/Xyz monsters may use Main Monster Zones under the 2020 rule; Link and face-up Extra Deck Pendulum monsters retain linked-zone restrictions. [Official rules](https://www.yugioh-card.com/japan/howto/masterrule2020/).','',
 'Core source confirms chain registration precedes the target callback, and inherent procedure summoning completes its status. The downloaded reference is comparative evidence, not proof Omega ships that exact build. [Core processor](https://github.com/Fluorohydride/ygopro-core/blob/master/processor.cpp), [summon operations](https://github.com/Fluorohydride/ygopro-core/blob/master/operations.cpp).','',
 '## Individual detailed claims','', '| Report line | Claim | Verdict | Reason |','|---|---|---|---|']
for c in inventory['deep_claims']:
 doc.append(f"| {c['line']} | {c['claim'].replace('|','/')} | {c['verdict']} | {c['reason']} |")
doc+=['','## All master-ledger rows','', '| Card | Report claims | Critical verdict |','|---|---|---|']
for row in inventory['master_rows']:
 reasons='; '.join(v['category']+': '+v['verdict']+' — '+v['reason'] for v in row['category_verdicts'])
 doc.append(f"| {row['passcode']} {row['name']} | {', '.join(row['categories'])} | {reasons} |")
doc+=['','## Implemented changes','']
for c in fixes['changes']:doc.append(f"- **{c['passcode']} {base[c['passcode']]['name']}**: {c['reason']}")
doc+=['','## Validation and remaining limits','',
 'All 711 scripts pass Lua 5.3 syntax. Focused Ghostrick, Janna, Stand Together, Normal/Special summon search and Spell search batches passed with source hashes and counterexamples. The callback regression checks 91 production assertions with mocked engine boundaries; these do not establish native gameplay.',
 'Condescender Link-rating behavior needs engine/design support. LP-payment event timing, some summon-procedure/native edges, exact-number destruction rulings and ambiguous prompt metadata remain not established by the report. Generic historical labels remain unsubstantiated rather than silently counted as fixed.','',
 'Detailed sources, pre-change script excerpts, card text, and per-category verdicts: output/fresh-ccg-september/gemini-claim-review.json. Original source backups and hashes: gemini-supported-fixes.json.']
(ROOT/'docs/OMEGA-GEMINI-CLAIM-REVIEW.md').write_text('\n'.join(doc)+'\n',encoding='utf-8')
print(json.dumps({'claims':len(inventory['deep_claims']),'master_rows':len(inventory['master_rows']),'changed_cards':len(fixes['changes']),'verdicts':inventory['deep_verdict_counts']}))

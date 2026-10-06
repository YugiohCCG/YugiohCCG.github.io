"""Review numbered Group I assertions with explicit scope and uncertainty."""
import hashlib,json,re
from pathlib import Path
ROOT=Path(__file__).resolve().parents[1];OUT=ROOT/'output/fresh-ccg-september'
inventory=json.loads((OUT/'gemini-wave2-inventory.json').read_text(encoding='utf-8'))
verdicts={
10379:('SUPPORTED_PROMPT_ORDER_GAP','Optional destruction prompt precedes checking a nonempty eligible group. This can produce an unnecessary prompt; it is not proof an illegal destruction occurs.'),
10381:('NOT_ESTABLISHED_SELF_DESTRUCTION_BAN','Printed text allows one card in your field and does not exclude itself. Report supplies no authoritative universal prohibition or actual resolving Counter Trap self-destruction failure. Do not remove a printed choice solely on this assertion.'),
10387:('NEEDS_DAMAGE_STEP_CASE','Destruction-by-effect trigger may need Damage Step flags depending on native automatic event allowances. Missing a flag alone does not establish failure, especially the report conflates battle destruction with REASON_EFFECT condition.'),
10389:('REJECTED_CONVENTION_AS_DEFECT','Numeric id+100 is a supported legacy Omega name-shared count convention. Modern table formatting is not required to implement a distinct named effect.'),
10498:('NEEDS_PROHIBITION_PLACEMENT_CASE','Predicate omits IsForbidden. Need actual prohibition and Pendulum placement behavior; syntax-valid omission does not alone prove an illegal placement.'),
10500:('SUPPORTED_RESOLUTION_PREDICATE_GAP','eqop reuses cfilter with e, which includes IsCanBeEffectTarget. Target immunity gained after activation should not invalidate an existing target solely as targeting immunity. Preserve relation, equip eligibility and required recipient type checks.'),
10502:('MIXED_SCOPE_AND_EQUIP_ELIGIBILITY','Four-code list limits supported equip implementations. Printed Arms scope must be compared against all actual cards before expanding. DARK checks may reflect individual Arms equip limitations because text says as if equipped by its effect; do not automatically allow incompatible recipients.'),
10504:('MAINTAINABILITY_NOT_PROVEN_BUG','Duplicated code is a maintainability risk, not proof effects are wrong. Shared equip refactoring must preserve each weapon-specific value, limit and replacement.'),
10631:('SUPPORTED_PENDULUM_COUNT_SCOPE_GAP','Pendulum effect shares id with all named previous monster effects despite having no printed named restriction. Shared monster effect scope and each-versus-shared wording need their own treatment; separating every trigger indiscriminately is not necessarily correct.'),
10633:('SUPPORTED_RESOLUTION_LOCK_PLACEMENT_GAP','Printed also use lock follows the cost separator, but source installs it during LP payment. Negated activation can therefore leave an unintended lock. Actual two-turn duration/reset must also be verified.'),
10635:('METADATA_ONLY','Unconditional equip operation information for optional equip may overstate possible action; it is not evidence optional equip is forced or fails.'),
10870:('NEEDS_PREVIOUS_MONSTER_TYPE_CASE','Non-archetype Dinosaur recognition only covers previous MZONE or HAND. A monster placed in SZONE may currently be a Spell/Trap, so original race alone is not sufficient to declare it a Dinosaur monster. Test actual type/race semantics for equip and Pendulum cards.'),
10871:('PARTLY_SUPPORTED_SUMMON_ORDER_GAP','Source applies disable effects after SpecialSummon finishes rather than before SpecialSummonComplete. Source also omits RESET_TURN_SET value on DISABLE_EFFECT. Actual summoned trigger timing and face-down reset cases are needed to show the behavioral difference.'),
10872:('NEEDS_DAMAGE_STEP_CASE','Actual effect-destruction trigger during Damage Step needed; flag omission is not a reproduced failure.'),
11013:('SUPPORTED_SOURCE_ZONE_GAP','Full MMZ fails unconditional GetLocationCount>0 even if destroying an eligible own MMZ monster frees a zone. Must evaluate a valid destruction choice that actually frees an allowed zone, not just any field card.'),
11015:('SUPPORTED_SOURCE_SELECTION_GAP','Face-up restriction excludes own face-down Chrono-Saur cards despite no printed qualifier. Own card information is known to its controller. Test face-down spell/trap and Dinosaur separately.'),
11016:('SUPPORTED_INSTANCE_TRACKING_GAP','Phase cleanup stores only card object and current MZONE membership, so leaving and returning can be destroyed as the old summoned instance. Add instance/flag tracking only after actual leave-return counterexample.'),
11018:('REJECTED_SYNTAX_ASSERTION','aux.NecroValleyFilter supports nil and returns a callable closure. Invoking it inline with c is valid Lua and supported Omega helper usage.'),
11019:('NOT_ESTABLISHED_MISSING_EXCLUSION','Default free-chain summon Quick Effects are not automatically allowed in Damage Step just because a phase predicate spans Battle Phase. Native activation gate must be tested before claiming an explicit exclusion is mandatory.'),
11147:('REJECTED_REQUIRED_ARGUMENT_ASSERTION','Comparative libcard.cpp:2473 defaults omitted player to core.reason_player. Numerous Omega official scripts call IsAbleToRemove() without tp. Possible wrong-context cases need a specific trace, not a mandatory-argument claim.'),
11149:('NEEDS_COST_MOVEMENT_CASE','The relation is to the original activated effect re. Handler moving as its own cost occurs before the responding chain link; this is not equivalent to moving later in the chain. An actual self-cost activation case is required before removing relation checks.'),
11151:('SUPPORTED_ARCHETYPE_SCOPE_GAP','armseqfilter relies on a four-code equip list despite printed any Talismandrake Arms card. Check roster/set membership and broaden activation prerequisite independently of the weapon application implementation.'),
11152:('MAINTAINABILITY_NOT_PROVEN_BUG','Duplicated equip implementation merits shared helper work only with behavior-preserving checks; length alone is not an engine violation.'),
11294:('SUPPORTED_TARGETING_MISMATCH','Printed negate clause does not target, but script sets CARD_TARGET and selects a target during activation. Resolution-time selection should retain face-up/legal monster and actual negation eligibility without adding targeting restrictions.'),
11296:('SUPPORTED_CONJUNCTION_TIMING_GAP','Source does not separate negation from subsequent stat gain with BreakEffect. Success/immunity and stat-gain dependence must be retained; adding timing alone does not complete the effect.'),
11298:('SUPPORTED_COMPATIBILITY_GAP','Current operation only increments Card turn counters. Omega Pyro Clock c1082946 recognizes flag1082946 and invokes the stored countdown effect operation. These are different tracking systems. Advancing all printed effect turn counts requires appropriate integration; blindly incrementing displayed counters is insufficient.'),
11495:('REJECTED_EVENT_REASON_CONFUSION','EVENT_BE_MATERIAL r is populated with material summon reason such as REASON_FUSION, not necessarily the full card send-reason bitmask. Comparative operations.cpp and Omega c11317977 contradict never-triggers assertion.'),
11500:('SUPPORTED_INDEPENDENT_BRANCH_GAP','Target feasibility requires Pendulum-zone summon option, blocking otherwise legal independent Extra-to-Pendulum placement option. Preserve optional independent also branches and check each destination/recipient properly.'),
11673:('SUPPORTED_RESOLUTION_PREDICATE_GAP','Existing target is rechecked with targeting-eligibility predicate at resolution. Retain relation and current equip compatibility instead of newly applying targeting immunity.'),
11674:('SUPPORTED_REPLACEMENT_FEASIBILITY_GAP','Sabre replacement target lacks weapon destructibility and REASON_REPLACE exclusion. Need actual indestructible-weapon/replacement cases before certification.'),
11675:('NOT_ESTABLISHED_EFFECT_TYPE_EXCLUSIVITY','Source uses a field continuous replacement with SZONE range and explicit equipped-monster filtering. Official equip continuous replacement exists, but that does not prove a correctly filtered field replacement can never work. Actual replacement test required.'),
11840:('SUPPORTED_EXTRA_COUNT_RESTRICTION','After-damage-calculation effect follows the named previous-effects limit but has id+200 count. Printed scope does not include that later effect. Test repeated battles and preserve any earlier effect limits.'),
11842:('REJECTED_SELF_CONTRADICTORY_CLAIM','Source explicitly includes RESET_SELF_TURN. Report quotes that then argues a version without checking player expires on opponent Battle Phase. Existing self-turn reset must be tested; no missing flag established.'),
11985:('SUPPORTED_ARCHETYPE_SCOPE_GAP','Four-code equip prerequisite excludes other legitimate Arms cards if present. Review actual set members; prerequisite broadening is independent of effect-copy support.'),
11986:('REJECTED_API_ASSERTION','PLAYER_ALL appears in Omega official operation information, including c100240203 CATEGORY_REMOVE and c10000090 CATEGORY_TOGRAVE. Comparative SetOperationInfo accepts integer player parameter. Not intrinsically invalid.'),
11987:('MAINTAINABILITY_NOT_PROVEN_BUG','Equip code duplication is not a standalone behavioral defect.'),
12141:('NEEDS_RECIPIENT_ZONE_CASE','Source explicitly asks IsCanBeSpecialSummoned with destination mask0x1f and uses the same mask on actual summon. Plain MMZ count is not the only legality check. Native Pendulum Extra recipient without linked MMZ versus linked MMZ scenario is needed before declaring illegal activation.'),
12146:('SUPPORTED_RESOLUTION_PREDICATE_GAP','Source rechecks targeting eligibility on an already selected equip recipient. Preserve relation and actual Dark Pyro Fusion compatibility while removing only inappropriate targeting recheck.'),
12147:('MIXED_STALE_AND_UNPROVEN','Current Shield reptg/sendt already include IsDestructable(e) and not tc:IsReason(REASON_REPLACE), contrary to report. Both field continuous replacements use SZONE range and equipped recipient filters; effect-type replacement needs behavior evidence, not convention alone.'),
12298:('SUPPORTED_PROMPT_ORDER_GAP','Optional destruction prompt appears before proving any eligible destruction choice. Unnecessary prompt is a UI/flow gap; not itself an illegal destruction.'),
12299:('NOT_ESTABLISHED_SELF_DESTRUCTION_BAN','Printed field-card choice does not exclude source Counter Trap. No demonstrated universal self-destruction ban or infinite loop; draw trigger has a named limit. Actual destruction/trigger case needed.'),
12304:('NEEDS_DAMAGE_STEP_CASE','No actual effect-destruction Damage Step failure supplied; source trigger condition excludes battle-only destruction.'),
12305:('REJECTED_CONVENTION_AS_DEFECT','id+100 is supported Omega legacy count convention; table style alone does not repair a behavior.')}
carriers=json.loads((OUT/'gemini-wave2-carrier-check.json').read_text(encoding='utf-8'));bycarrier={c['passcode']:c for c in carriers['cards']};claims=[]
for card in inventory['cards'][56:69]:
 source=ROOT/'public/CCG Downloads/CCG_Scripts'/f"c{card['passcode']}.lua"
 assert hashlib.sha256(source.read_bytes()).hexdigest()==card['source_sha256']
 for p in card['prose']:
  if re.match(r'^\d+\. ',p['text']) and p['line']<card['line']+65:
   if p['text'].startswith('1. '):
    carrier=bycarrier[card['passcode']];assert carrier['all_literal_prompts_available']
    status,reason='REJECTED_MISSING_CARRIER_ASSERTION',f"Current carrier {carrier['carrier']} and all its literal prompts exist in candidate DB; replacing STRING_ID with id is not an established fix."
   else:status,reason=verdicts[p['line']]
   claims.append({'passcode':card['passcode'],'name':card['name'],'report_line':p['line'],'claim':p['text'],'source_sha256':card['source_sha256'],'verdict':status,'reason':reason,'implemented':False,'native_omega_verified':False})
assert len(claims)==56 and len(verdicts)==43
result={'report_sha256':inventory['report_sha256'],'scope':'All56 numbered Group I finding groups; source-reviewed gaps and unproven runtime cases distinguished. No installed fixes or full audits.', 'claims':claims}
(OUT/'gemini-chrono-talismandrake-claim-review.json').write_text(json.dumps(result,indent=2)+'\n',encoding='utf-8')
lines=['# Chrono-Saur and Talismandrake claim-level fact-check','','56 numbered findings across13 cards. Supported source gaps still need focused regressions and repairs.','','| Card / report line | Verdict | Evidence / limitation |','|---|---|---|']
for f in claims:lines.append(f"| {f['passcode']} {f['name']} / {f['report_line']} | {f['verdict']} | {f['reason']} |")
(ROOT/'docs/OMEGA-GEMINI-CHRONO-TALISMANDRAKE-CLAIMS.md').write_text('\n'.join(lines)+'\n',encoding='utf-8')
print(json.dumps({'claim_groups':56,'cards':13,'production_changes':0}))

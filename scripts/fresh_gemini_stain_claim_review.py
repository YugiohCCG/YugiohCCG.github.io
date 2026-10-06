"""Fact-check all numbered Group G claims without equating omissions with bugs."""
import hashlib,json,re
from pathlib import Path
ROOT=Path(__file__).resolve().parents[1];OUT=ROOT/'output/fresh-ccg-september'
inventory=json.loads((OUT/'gemini-wave2-inventory.json').read_text(encoding='utf-8'))
verdicts={
6718:('PARTLY_SUPPORTED_ACTIVATION_GAP','Handler return eligibility is not checked. Full-effect activation feasibility needs the return clause tested. IsDestructable is a supported Omega predicate, not obsolete solely because another script uses nil.'),
6721:('REJECTED_BLANKET_CHANGE','Omega NecroValleyFilter intentionally excludes affected GY cards and is used in official activation/target checks. The assertion that it must only be used at resolution is not supported.'),
6723:('UI_CONVENTION_NOT_PROVEN_DEFECT','ConfirmCards on an already public card is not by itself an illegal engine operation. HintSelection may improve presentation but no failure was reproduced.'),
6833:('SUPPORTED_NAMED_SUBSTITUTE_GAP','Numeric named Stargazer material is registered with sub=false despite no printed exclusion. This differs from the earlier generic-predicate substitution claims. Test named substitution separately from the two archetype predicates.'),
6835:('MIXED_CLAIMS','OperationInfo-only summon inclusion can miss category-only effects; actual category false positives also need care. Missing a helper name alone does not prove summon timing is wrong. EVENT_CHAINING eg is used by official Omega negate scripts, so claiming it is inherently invalid is false.'),
6839:('PARTLY_SUPPORTED_AVAILABILITY_GAP','Look trigger has no target feasibility check for any information to inspect. Summon event membership/face-down visibility must be tested; Boolean precedence alone does not make a source-self branch incorrect.'),
6984:('REJECTED_ALWAYS_MISSES_ASSERTION','Dedicated EVENT_LEAVE_DECK exists, but comparative core operations.cpp raises EVENT_MOVE for both send-to processing and drawing (4784-4785). Existing previous-location filter can observe departures. Need specific missing events before declaring all draw/mill/banish missed.'),
6986:('REJECTED_LITERAL_TEXT_ASSERTION','Both cited cards contain the quoted phrase inside their own effect text. Printed mentions does not say must have an effect which shuffles itself. A literal phrase list must be audited against actual text, not strengthened to an unprinted condition.'),
7091:('REJECTED_STRUCTURAL_ASSERTION','Silas registers a FIELD PLAYER_TARGET CANNOT_ACTIVATE effect with TargetRange(1,1) and checks the activated effect handler against its host card. Gemini treats it as a single monster CANNOT_ACTIVATE registration; that is not the current implementation. Actual activation tests can still reveal unrelated behavior issues.'),
7093:('REJECTED_BLANKET_CHANGE','Same unsupported demand to remove Omega NecroValleyFilter from activation feasibility checks.'),
7234:('MIXED_CLAIMS','Missing handler-return eligibility is a plausible activation gap. Presence of an Omega Necrovalley target guard is not itself a defect.'),
7237:('NEEDS_BATTLE_TRACE','The source does check IsRelateToBattle after Rollo leaves. Whether the battle relation clears synchronously inside this operation needs an actual attack/return trace. Replacing it with only location/controller checks may accept a changed monster and is not automatically equivalent.'),
7354:('NEEDS_REPLACEMENT_CASE','Replacement constraints need actual destruction/battle/replacement recursion scenarios. Count-code convention alone does not prove a replacement is unusable.'),
7357:('SUPPORTED_TARGET_IDENTITY_GAP','cptg explicitly creates relation on the selected GY card, then clears target cards and delegates copied targeting. cpop incorrectly retrieves that selected source with GetFirstTarget, which can now return a copied target or nothing. Store copied-source identity separately; retain independent copied target state.'),
7496:('NEEDS_SELECTION_METADATA_REVIEW','Story uses an explicit five-code supported effect list. Any claimed missing supported summon effect must be demonstrated from actual roster text; widening to arbitrary Stain monsters without implementing their effects is not a repair.'),
7498:('SUPPORTED_TARGET_PREPARATION_GAP','Story tgtg does not perform any copied targeting while its resolution branches emulate summon effects. Effects whose actual text targets need correct activation-time targets and legal feasibility checks; converting everything to resolution selections is not equivalent.'),
7500:('SUPPORTED_FEASIBILITY_GAP','Cost selection permits supported code without proving its copied summon effect has a legal result. Test empty GYs/absent opponent target and legal alternate source cards; avoid paying cost for an impossible effect.'),
7716:('PARTLY_SUPPORTED_ACTIVATION_GAP','Feness target check does not check its own Deck-return eligibility. Missing return operation information is a metadata difference, not by itself a reproduced failure.'),
7856:('NEEDS_SUMMON_VISIBILITY_CASE','Source predicate omits face-up. Whether a face-down Special Summon can qualify as a non-LIGHT named-archetype summon needs native event/visibility testing rather than assuming IsSetCard hides all information.'),
7858:('SUPPORTED_CONJUNCTION_GAP','Current operation returns entirely if the target is gone or face-down, preventing independent also position-change branch. Separate branches while preserving other-monsters exclusion and legal position filters; actual chained target-loss case remains required.'),
7860:('METADATA_GAP','Position-change operation information is absent. That is a supported metadata omission; no assertion that position change itself cannot work.'),
7956:('REPRODUCED_COUNTEREXAMPLE_TO_CLAIM','SetLabel accepts multiple values in executed public-engine probe; local Omega official scripts also use it. The asserted guaranteed nil second label and fatal comparison is false for the examined API.'),
7960:('SUPPORTED_SELECTION_GAP','Sequential field-monster selection can choose the only own Stain eligible for the second selection, leaving no distinct second monster despite an initially valid pair. First selection must preserve a valid partner or use a constrained subgroup; test minimal valid pair.'),
8148:('NEEDS_LEAVE_FIELD_RESET_TRACE','Reset mask includes leave-field resets. The precise ordering of registered watcher removal versus leave-field dispatch must be tested. Gemini alternative subtraction masks are not certified equivalent redirect behavior.'),
8150:('REJECTED_BLANKET_CHANGE','Omega activation-side Necrovalley helper use is supported; no blanket removal.'),
8298:('REJECTED_ALWAYS_MISSES_ASSERTION','EVENT_MOVE is raised on Deck departures including drawing in comparative core. Dedicated event is available, but current previous-location/controller filter must be assessed with specific events.'),
8300:('NEEDS_LEAVE_FIELD_RESET_TRACE','Same untested watcher-reset ordering claim; isolate actual leave destinations and source disappearance before changing mask.'),
8302:('REJECTED_CONDITION_LOCATION_ASSERTION','Checking opponent field presence inside target chk==0 still prevents voluntary activation without that condition. Requiring SetCondition is a structural convention, not proof current activation is legal when it should not be.'),
8304:('NEEDS_RESOLUTION_POSITION_CASE','copyfilter correctly requires the selected opponent recipient face-up. Source face-down-at-resolution branch is a separate concern. A normally activated on-field Quick Effect already has a face-up source; test chained Set before alleging a false initial activation.'),
8465:('NEEDS_OMEGA_API_SEMANTICS','Public comparison engine lacks IsFaceupEx; this prevents assuming its actual Omega semantics from a different core. If Omega excludes Deck this would block search, but the report provides no executed Omega predicate/Deck-search case. Test native Omega or inspect its exact implementation before declaring complete failure.'),
8468:('REJECTED_LITERAL_TEXT_ASSERTION','Actual Stargazer and Solitaire texts literally contain the phrase. The report adds a must-shuffle-itself requirement absent from printed mentions wording.')}
claims=[]
for card in inventory['cards'][30:43]:
 source=ROOT/'public/CCG Downloads/CCG_Scripts'/f"c{card['passcode']}.lua"
 assert hashlib.sha256(source.read_bytes()).hexdigest()==card['source_sha256']
 for p in card['prose']:
  if re.match(r'^\d+\. ',p['text']) and p['line']<card['line']+65:
   status,reason=verdicts[p['line']]
   claims.append({'passcode':card['passcode'],'name':card['name'],'report_line':p['line'],'claim':p['text'],'source_sha256':card['source_sha256'],'verdict':status,'reason':reason,'implemented':False,'native_omega_verified':False})
assert len(claims)==len(verdicts)==31
result={'report_sha256':inventory['report_sha256'],'scope':'All31 numbered Group G card-specific claim groups reviewed. Compound assertions distinguished in reasons; uncertain runtime/ruling claims explicitly remain unproven. No full card audits or installed fixes.', 'claims':claims}
(OUT/'gemini-stain-claim-review.json').write_text(json.dumps(result,indent=2)+'\n',encoding='utf-8')
lines=['# Stain claim-level fact-check','','31 numbered findings across13 cards. Evidence and pending tests are distinguished; no production changes.','','| Card / report line | Verdict | Evidence / limitation |','|---|---|---|']
for f in claims:lines.append(f"| {f['passcode']} {f['name']} / {f['report_line']} | {f['verdict']} | {f['reason']} |")
(ROOT/'docs/OMEGA-GEMINI-STAIN-CLAIMS.md').write_text('\n'.join(lines)+'\n',encoding='utf-8')
print(json.dumps({'claim_groups':len(claims),'cards':13,'production_changes':0}))

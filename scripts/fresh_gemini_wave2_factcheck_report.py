"""Publish verified evidence and explicit outstanding checks without inflating progress."""
import hashlib,json
from pathlib import Path
ROOT=Path(__file__).resolve().parents[1];OUT=ROOT/'output/fresh-ccg-september'
inventory=json.loads((OUT/'gemini-wave2-inventory.json').read_text(encoding='utf-8'))
texts=json.loads((OUT/'gemini-wave2-text-check.json').read_text(encoding='utf-8'))
syntax=json.loads((OUT/'gemini-report-syntax-check.json').read_text(encoding='utf-8'))
api=json.loads((OUT/'gemini-wave2-api-probe.json').read_text(encoding='utf-8'))
carriers=json.loads((OUT/'gemini-wave2-carrier-check.json').read_text(encoding='utf-8'))
assert inventory['report_sha256']==texts['report_sha256']==syntax['report_sha256']
assert api['status']=='PASS' and api['harness_sha256']==hashlib.sha256((ROOT/'scripts/fresh_gemini_wave2_api_probe.cjs').read_bytes()).hexdigest()
assert carriers['report_sha256']==inventory['report_sha256'] and all(c['all_literal_prompts_available'] for c in carriers['cards'])
for c in inventory['cards']:
 assert c['source_sha256']==hashlib.sha256((ROOT/'public/CCG Downloads/CCG_Scripts'/f"c{c['passcode']}.lua").read_bytes()).hexdigest()
minor=next(c for c in texts['cards'] if c['passcode']==213530841)
assert minor['text_similarity']>.98
major=[c for c in texts['cards'] if not c['normalized_text_matches'] and c['passcode']!=213530841]
assert len(major)==33
lines=['# Gemini report fact-check: verified evidence and outstanding review','',
 'Updated 2026-10-06. This extends the earlier review; it does not claim every new effect assertion has been resolved.',
 '',f"Report snapshot SHA-256: `{inventory['report_sha256']}`.",'',
 'The new report contains exactly 69 distinct card sections in Groups D-I. Thirty-five quoted texts match the roster after word normalization. Thirty-three substantially conflict with the roster and current candidate database. Chrono-Saur Counter is the remaining minor wording difference (Chono-Saur versus Chrono-Saur in the named limit); it was not classified as a different design. An earlier summary incorrectly described this as singular/plural wording.',
 '', '## Findings established in this pass','',
 '- All 10 Stellaer, all 10 Shining Brigade and all 13 Ghostrick/Eclipse sections use substantially different effect text. A replacement implementing those quotes would change the intended cards. This does not prove their current scripts are bug-free.',
 '- The Silphia claim that Effect.SetLabel accepts one integer is contradicted by the executed public-engine initialization probe: SetLabel(17,23) followed by GetLabel returns both. Local Omega c100261007 and c100261026 also use multiple labels. Native Omega execution remains a separate boundary.',
 '- The disputed Lua bitwise expression parses and executes in the same public engine with Omega helpers. It is not a syntax failure in this environment.',
 '- EVENT_BE_MATERIAL event r is not necessarily the full Card.GetReason bitmask. Comparative core operations.cpp:3406-3417 supplies REASON_FUSION directly; Omega c11317977:70 checks r==REASON_FUSION. The claim that the equality always prevents activation is false as a blanket statement.',
 '- Card.ReverseInDeck exists in comparative core libcard.cpp:3349. The inspected Dante helper checks LOCATION_DECK before using it. The summary supplies no reproduced native Omega crash.',
 '- All 69 current scripts have their literal message carriers present: all 184 literal STRING_ID prompt references resolve to nonempty candidate database strings. The Group I blanket assertion that these carrier IDs cause missing strings is contradicted by actual data. Dynamic descriptions and actual UI rendering remain separate checks.',
 f"- Parsed {len(syntax['snippets'])} Lua code fences, including indented fences, without executing them; {sum(s['syntax_pass'] for s in syntax['snippets'])} parse as standalone Lua. Fragment failures do not by themselves establish failures of a complete replacement. Earlier 130-snippet count omitted indented fences.",
 '- Sonic Scream source has a real target-preparation gap: its copy target callback only stores the original effect and the operation is called directly. Missing GetHandler is overstated: the copying effect still has its handler. Repair requires testing the copied monster effects, rather than blindly transplanting a Normal Trap activation checker.',
 '', '## Every new card: specification evidence','',
 '| Passcode / card | Report line | Text result | Intended card type |',
 '|---|---:|---|---|']
bycode={c['passcode']:c for c in inventory['cards']}
for c in texts['cards']:
 spec=bycode[c['passcode']]['authoritative_card']['specification']
 verdict='Matches' if c['normalized_text_matches'] else 'Minor wording difference' if c['passcode']==213530841 else '**Different effects quoted**'
 lines.append(f"| {c['passcode']} {c['name']} | {c['report_line']} | {verdict} | {', '.join(spec.get('cardTypes') or [spec['category']])} |")
lines+=['','## Scope still outstanding','',
 'Group D now has a separate claim-level review covering all 37 numbered findings across all 10 Gravinity cards: see OMEGA-GEMINI-GRAVINITY-CLAIMS.md. The Spherix relation-check failure was reproduced with actual public-engine Special Summon processing and an isolated causal control. Source gaps, disproved blanket assertions and uncertain rulings are distinguished; this does not add completed cards.',
 'Group G also has a separate claim-level review covering all 31 numbered finding groups across all 13 Stain cards: see OMEGA-GEMINI-STAIN-CLAIMS.md. Compound assertions and uncertainty are recorded individually. Runtime-dependent battle, leave-field reset and Omega-only IsFaceupEx claims remain unproven, not automatically accepted.',
 'Group I now has a separate claim-level review covering all 56 numbered finding groups across all 13 Chrono-Saur/Talismandrake cards: see OMEGA-GEMINI-CHRONO-TALISMANDRAKE-CLAIMS.md. All 36 sections without major specification mismatches have source-level dispositions. Supporting runtime/ruling cases and independent technical claims in wrong-specification sections remain outstanding.',
 'The remaining source assertions for the 36 sections without a substantial specification mismatch require claim-by-claim rulings, callback or actual duel evidence. Independent technical assertions in the 33 mismatched sections must also be separated from their false design premises. A text match and valid syntax do not certify a replacement.',
 '', 'No scripts or local Omega files were changed during this evidence pass. These report checks add no completed cards to the 711-card audit ledger.',
 '', 'Evidence: gemini-wave2-inventory.json; gemini-wave2-text-check.json; gemini-report-syntax-check.json; gemini-wave2-api-probe.json; gemini-wave2-carrier-check.json. All are in output/fresh-ccg-september. The prior summary triage remains in OMEGA-GEMINI-WAVE2-REVIEW.md.']
(ROOT/'docs/OMEGA-GEMINI-FACT-CHECK.md').write_text('\n'.join(lines)+'\n',encoding='utf-8')
print(json.dumps({'new_card_sections':69,'substantial_text_mismatches':33,'syntax_snippets':len(syntax['snippets']),'api_probe':'PASS','full_claim_review':'IN_PROGRESS'}))

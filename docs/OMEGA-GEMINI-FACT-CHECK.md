# Gemini report fact-check: verified evidence and outstanding review

Updated 2026-10-06. This extends the earlier review; it does not claim every new effect assertion has been resolved.

Report snapshot SHA-256: `3dd2ba767ed0155d599a5237ff3a21ba7f0d4a3a22a79337a5b61547b41026a3`.

The new report contains exactly 69 distinct card sections in Groups D-I. Thirty-five quoted texts match the roster after word normalization. Thirty-three substantially conflict with the roster and current candidate database. Chrono-Saur Counter is the remaining minor wording difference (Chono-Saur versus Chrono-Saur in the named limit); it was not classified as a different design. An earlier summary incorrectly described this as singular/plural wording.

## Findings established in this pass

- All 10 Stellaer, all 10 Shining Brigade and all 13 Ghostrick/Eclipse sections use substantially different effect text. A replacement implementing those quotes would change the intended cards. This does not prove their current scripts are bug-free.
- The Silphia claim that Effect.SetLabel accepts one integer is contradicted by the executed public-engine initialization probe: SetLabel(17,23) followed by GetLabel returns both. Local Omega c100261007 and c100261026 also use multiple labels. Native Omega execution remains a separate boundary.
- The disputed Lua bitwise expression parses and executes in the same public engine with Omega helpers. It is not a syntax failure in this environment.
- EVENT_BE_MATERIAL event r is not necessarily the full Card.GetReason bitmask. Comparative core operations.cpp:3406-3417 supplies REASON_FUSION directly; Omega c11317977:70 checks r==REASON_FUSION. The claim that the equality always prevents activation is false as a blanket statement.
- Card.ReverseInDeck exists in comparative core libcard.cpp:3349. The inspected Dante helper checks LOCATION_DECK before using it. The summary supplies no reproduced native Omega crash.
- All 69 current scripts have their literal message carriers present: all 184 literal STRING_ID prompt references resolve to nonempty candidate database strings. The Group I blanket assertion that these carrier IDs cause missing strings is contradicted by actual data. Dynamic descriptions and actual UI rendering remain separate checks.
- Parsed 279 Lua code fences, including indented fences, without executing them; 244 parse as standalone Lua. Fragment failures do not by themselves establish failures of a complete replacement. Earlier 130-snippet count omitted indented fences.
- Sonic Scream source has a real target-preparation gap: its copy target callback only stores the original effect and the operation is called directly. Missing GetHandler is overstated: the copying effect still has its handler. Repair requires testing the copied monster effects, rather than blindly transplanting a Normal Trap activation checker.

## Every new card: specification evidence

| Passcode / card | Report line | Text result | Intended card type |
|---|---:|---|---|
| 212345347 Gravinity Lapsix | 2746 | Matches | Synchro, Effect |
| 212429024 Gravinity Nebulix | 2907 | Matches | Synchro, Effect |
| 215768254 Gravinity Star | 3055 | Matches | Tuner, Effect |
| 231088629 Gravinity Spherix | 3220 | Matches | Synchro, Effect |
| 235538173 Gravinity Plasma | 3413 | Matches | Effect |
| 238184015 Gravinity Sonic Scream | 3559 | Matches | Trap |
| 249454272 Gravinity Galaxix | 3681 | Matches | Synchro, Effect |
| 249680945 Gravinity Orbit | 3807 | Matches | Effect |
| 256172827 Gravinity Pulse | 3955 | Matches | Tuner, Effect |
| 256831125 Gravinity Axis Matter | 4103 | Matches | Spell |
| 214226989 Stellaer of Purity | 4450 | **Different effects quoted** | Xyz, Effect |
| 219905997 Stellaer of the Ground | 4569 | **Different effects quoted** | Xyz, Effect |
| 225106953 Stellaer of the Gems | 4689 | **Different effects quoted** | Effect |
| 226903348 Stellaer of the Sea | 4794 | **Different effects quoted** | Effect |
| 230132786 Stellaer of the Volcanos | 4897 | **Different effects quoted** | Effect |
| 230998543 Stellaer of the Breeze | 4991 | **Different effects quoted** | Effect |
| 234455260 Stellaer of the Night | 5088 | **Different effects quoted** | Effect |
| 259028576 Stellaer of the Lightning Runes | 5187 | **Different effects quoted** | Effect |
| 259057226 Stellaer of the Cold | 5313 | **Different effects quoted** | Effect |
| 259219942 Stellaer of the Plants | 5448 | **Different effects quoted** | Effect |
| 220124524 Shining Brigade - Heartbeat Division | 5634 | **Different effects quoted** | Effect |
| 223750159 Shining Brigade Armada | 5757 | **Different effects quoted** | Xyz, Effect |
| 230812008 Shining Brigade - Loving Division | 5855 | **Different effects quoted** | Effect |
| 232824319 Shining Brigade - Companion Team | 5979 | **Different effects quoted** | Link, Effect |
| 236616849 Shining Brigade - Revenge Division | 6076 | **Different effects quoted** | Xyz, Effect |
| 238841732 Let's Go, Shining Brigade! | 6170 | **Different effects quoted** | Spell |
| 241504188 Shining Brigade - Absolute Supremacy | 6266 | **Different effects quoted** | Link, Effect |
| 244986323 Shining Brigade Origins | 6359 | **Different effects quoted** | Xyz, Pendulum, Effect |
| 249629457 Shining Brigade - Last Stand | 6471 | **Different effects quoted** | Trap |
| 255668557 Shining Brigade - Joyous Division | 6580 | **Different effects quoted** | Effect |
| 216958556 Stained Deer Dante | 6711 | Matches | Effect |
| 217174535 Stainless Kaleidragon | 6825 | Matches | Effect, Fusion |
| 218685316 Stargazer of the Stained | 6977 | Matches | Effect |
| 221822671 Stained Sovereign Silas | 7084 | Matches | Effect |
| 224822244 Stained Raptor Rollo | 7227 | Matches | Effect |
| 244790302 Stained Avatar | 7346 | Matches | Effect, Fusion |
| 245970073 A Stainless Story | 7489 | Matches | Spell |
| 247499445 Stained Fox Feness | 7709 | Matches | Effect |
| 247580036 Distained Druid Dragar | 7848 | Matches | Effect, Fusion |
| 247789143 Stained Sorceress Silphia | 7946 | Matches | Effect, Fusion |
| 248453205 Shattering Sustained | 8141 | Matches | Spell |
| 256608976 Stained Silhouette | 8288 | Matches | Effect |
| 259475154 Stained Solitaire | 8458 | Matches | Effect |
| 228472690 Ghostrick Cutifer | 8638 | **Different effects quoted** | Xyz, Effect |
| 235687149 Ghostrick Camella | 8772 | **Different effects quoted** | Xyz, Effect |
| 239335848 Ghostrick Oni | 8884 | **Different effects quoted** | Xyz, Effect |
| 241540236 Ghostrick Haunt | 9046 | **Different effects quoted** | Trap |
| 257677549 Ghostrick Slime | 9183 | **Different effects quoted** | Effect |
| 259058125 Eclipse Observer Maya | 9318 | **Different effects quoted** | Effect |
| 259069729 Eclipse Observer Nora | 9442 | **Different effects quoted** | Effect |
| 259126370 Eclipse Observer Chandra | 9541 | **Different effects quoted** | Xyz, Effect |
| 259273851 Manual of Eclipse | 9707 | **Different effects quoted** | Spell |
| 259487387 Eclipse Observer Ella | 9807 | **Different effects quoted** | Effect |
| 259721372 Eclipse Observatory | 9942 | **Different effects quoted** | Spell |
| 259851064 Ghostrick Pastrygeist | 10088 | **Different effects quoted** | Xyz, Effect |
| 259926839 Eclipse Observer Riley | 10236 | **Different effects quoted** | Effect |
| 213530841 Chrono-Saur Counter | 10369 | Minor wording difference | Trap |
| 215034223 Talismandrake Arms United | 10488 | Matches | Spell |
| 218142234 Maiden of Talismandrakes Seraphina | 10620 | Matches | Effect, Fusion, Pendulum |
| 235637994 Chrono-Saur Dactylus | 10861 | Matches | Effect |
| 236898203 Chrono-Saur Rex | 11004 | Matches | Effect |
| 241706191 Talismandrake Enkindle | 11137 | Matches | Effect, Fusion |
| 244013196 To Proto Chrono | 11285 | Matches | Special Summon, Effect |
| 245935439 Talismandrake Sear | 11485 | Matches | Effect, Pendulum |
| 248788543 Right Talismandrake Arms - Blaze Sabre | 11662 | Matches | Spell |
| 251236672 Chrono-Saur Laplace Plesio | 11831 | Matches | Spell |
| 253552927 Talismandrake Cremation | 11975 | Matches | Effect, Fusion |
| 255832330 Left Talismandrake Arms - Blaze Shield | 12130 | Matches | Trap |
| 259226793 Chrono-Saur Force | 12289 | Matches | Trap |

## Scope still outstanding

Group D now has a separate claim-level review covering all 37 numbered findings across all 10 Gravinity cards: see OMEGA-GEMINI-GRAVINITY-CLAIMS.md. The Spherix relation-check failure was reproduced with actual public-engine Special Summon processing and an isolated causal control. Source gaps, disproved blanket assertions and uncertain rulings are distinguished; this does not add completed cards.
Group G also has a separate claim-level review covering all 31 numbered finding groups across all 13 Stain cards: see OMEGA-GEMINI-STAIN-CLAIMS.md. Compound assertions and uncertainty are recorded individually. Runtime-dependent battle, leave-field reset and Omega-only IsFaceupEx claims remain unproven, not automatically accepted.
Group I now has a separate claim-level review covering all 56 numbered finding groups across all 13 Chrono-Saur/Talismandrake cards: see OMEGA-GEMINI-CHRONO-TALISMANDRAKE-CLAIMS.md. All 36 sections without major specification mismatches have source-level dispositions. Supporting runtime/ruling cases and independent technical claims in wrong-specification sections remain outstanding.
The remaining source assertions for the 36 sections without a substantial specification mismatch require claim-by-claim rulings, callback or actual duel evidence. Independent technical assertions in the 33 mismatched sections must also be separated from their false design premises. A text match and valid syntax do not certify a replacement.

No scripts or local Omega files were changed during this evidence pass. These report checks add no completed cards to the 711-card audit ledger.

Evidence: gemini-wave2-inventory.json; gemini-wave2-text-check.json; gemini-report-syntax-check.json; gemini-wave2-api-probe.json; gemini-wave2-carrier-check.json. All are in output/fresh-ccg-september. The prior summary triage remains in OMEGA-GEMINI-WAVE2-REVIEW.md.

# Difficult card effects: behavioral review

Status: ongoing. The previous keyword-contract report is not proof that all effects implement their printed behavior.

## Verified fixes — 2026-09-28

Aerocat Recon (259391738), GY shuffle effect, and World Legacy Surfacing (259944344), copied Krawler Ranvier recovery: resolution previously filtered targets by eligibility without checking whether they still related to the effect. A target that left its location could incorrectly be moved. Both callbacks now filter `Card.IsRelateToEffect` before their existing eligibility filters. The generator was updated as well.

Reference: `tmp/omega_scripts/c10698416.lua`, `operation`, explicitly filters the chain target group by `Card.IsRelateToEffect`.

Run `node scripts/test_ccg_target_resolution.cjs`. Eight scenarios execute the actual callbacks in the OCGCore Lua VM with explicit card/group fixtures: related target, unrelated target, mixed pair, and unrelated pair for both cards. Before the fixes, six scenarios failed. After the fixes, eight passed. These fixtures verify callback decisions, not full duel timing, target creation, or copied-effect selection.

Disciple of Fire (259023461): selected GY branches now consume their per-turn use during activation, and the discard branch consumes its once-per-GY-stay use at that point. Previously failed or negated resolutions left uses available, and another activation could be queued before resolution. Removed the resolution-time flag guard so reserving the use does not cancel its own resolution. Recovery after Special Summoning is now optional through the existing localized branch prompt.

Run `node scripts/test_ccg_disciple_of_fire.cjs`. Fourteen Lua callback scenarios cover activation reservations, repeated attempts, failed discard, successful discard, independent branches, simulated turn/GY transitions, and accepting/declining recovery. Seven of the initial nine failed before the patch; all fourteen pass afterward. Turn/GY resets are simulated in the fixture; actual engine reset/timing behavior still needs integrated duel tests.

## Open work

Galactican Jet Dasher (256005703), Galactican Jet Drifter (212837324), Galactican Machine - No. G2-X38 (253520299), and Intergalactican Machine - No. R2-D30 (236473882): replaced boolean-expression action selection with explicit branches. Previously, choosing return to Deck and receiving a zero result caused the script to attempt banishment as a fallback, despite the player's choice. Only the selected action now runs; follow-up processing depends on its success.

Run `node scripts/test_ccg_galactica_choice.cjs`. The matrix now includes both choices, both action results, and all four combinations of return/banish legality for each card (64 scenarios). The initial sixteen reproduced four fallback failures in committed scripts. Adding legality scenarios then reproduced 32 failures in the first patched versions. All 64 pass after adding activation eligibility and resolution-time choice checks. `--baseline` reads committed scripts without modifying them. Destination replacement and native battle timing remain unverified.

- Continue reviewing copied effects, custom summons, replacement effects, and turn-wide restrictions with behavioral scenarios. World Legacy Surfacing's other copy branches remain unverified.
- Disciple of Fire: further verify payment event timing, LP tracking across the turn, and native duel activation/reset behavior.
- `src/data/cards.json` contains unresolved merge conflict markers beginning at line 21051 in legality metadata. Full-roster validation and packaging cannot safely run until those conflicts are resolved.
- Release mirrors and ZIPs have not been regenerated for these changes. Do that after the roster issue is resolved and the broader effect review is ready.

No claim of full effect correctness or completed goal is made by this checkpoint.

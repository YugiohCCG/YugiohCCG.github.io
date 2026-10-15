# Ohmen Lua fixes and test results — 16 October 2026

All 15 current Ohmen scripts were checked against the updated card data. Ten scripts required fixes. The corrected copies have been installed in the local website source and YGO Omega Scripts folder. The website script archive was updated too; original files were backed up locally.

## Fixed bugs

- **Siemens Link:** corrected the control-taking destination argument. This also corrects my earlier six-argument change; the zone belongs in argument five.
- **Farad Link:** replaced an unavailable card method so recovery works from the GY and face-up banishment, while excluding facedown banished cards.
- **Coulomb main deck:** fixed an effect that could never pass activation checks before its cost was paid. Enforced simultaneous-summon restrictions and placed counters after the summon completes.
- **Ampere main deck:** saved the search amount when activated so removing Ampere in response does not erase the resolving search.
- **Carcel main deck:** allowed another Carcel as the Deck summon and removed the unintended GY-only restriction on its Link-material trigger.
- **Ampere Link:** applied its printed co-linked protection to either player's eligible monsters.
- **Carcel Link:** doubled current ATK including modifiers; tracked real co-link transitions without replaying missed events after disabling or on the next turn.
- **Beacon:** allowed movement of facedown monsters, as the text permits.
- **Powerload:** used the engine's counter-removal selection and required successful removal before destroying a card.
- **Surge:** made its “If your opponent activates a Spell” effect start a subsequent chain after that Spell resolves, using the delayed Trigger pattern of Kashtira Birth.

## Test results

- **128/128 duel scenarios passed** across 32 fixture families.
- **17/17 additional native-engine probes passed.** Some probes invoke specific callbacks under a neutral resolving test effect; others test actual activation and queued summons.
- **130 callback smoke invocations across 15 scripts passed.**
- **Five negative controls passed:** deliberately disabling control-taking, movement, recovery, dual summoning or optional destruction caused the corresponding test to fail.
- Focused Lua checks passed for branching/cyclic counter networks, blocked recipients, existing counters, destination masks and opponent co-linked counter recipients.
- Repository semantic audit: **0 errors, 0 unresolved findings, 0 stale finding exemptions** across 712 scripts. Two specific reviewed findings document valid dynamic recipient searches; this is a static audit, not proof of every card interaction.

## Coverage by card

| Card | Passcode | Engine coverage |
|---|---|---|
| Farad, the Purple Ohmen | 259174227 | Linked summon and GY follow-up |
| Volt, the Green Ohmen | 259726853 | Linked summon and hand follow-up |
| Ampere, the Yellow Ohmen | 259650132 | Network counters, exact-Level search, source leaving during resolution |
| Siemens, the Blue Ohmen | 259107906 | Linked summon/search |
| Coulomb, the White Ohmen | 259881255 | Linked summon, actual Extra Deck effect activation, costs and simultaneous summon limit |
| Carcel, the Dark Ohmen | 259780273 | Same-name Deck summon, material trigger, prior activity restriction |
| Ohmen Surge | 259869259 | Co-link transitions and 13 delayed Spell-trigger scenarios |
| Siemens, the Ohmenchanic Conductor | 259405917 | Movement, revival, control and zone restrictions |
| Farad, the Ohmenchanic Capacitor | 259350270 | Field banish, GY banish, GY/banishment recovery |
| Volt, the Ohmenchanic Chocker | 259519336 | Thresholds, counter-cost burn and non-targeting destruction |
| Coulomb, the Ohmenchanic Charger | 259841490 | Thresholds, movement/counter and proper Link Summon |
| Ampere, the Ohmenchanic Intensity | 259479044 | Search/discard, counters, battle/effect protection, opposing co-link |
| Carcel, the Ohmenchanic Light | 259033429 | Current ATK doubling, co-link transitions, disabled/re-entry timing, field counter cost/destruction |
| Ohmen Powerload | 259434499 | Deck summon, negation, optional destruction, counters split across cards |
| Ohmen Beacon | 259650969 | Hand/GY summon, movement including facedown monsters, counter placement and target protection |

## Two rulings still pending

These behaviours were preserved instead of choosing new rules:

1. **Ampere, the Yellow Ohmen:** its remembered spread counter total currently expires at the end of the turn. The wording does not clearly specify whether it should remain available on later turns or accumulate.
2. **Ohmen Powerload:** currently enforces the Thunder-only Special Summon restriction for the whole turn, including earlier summons. Confirm whether the intended rule is instead the rest of the turn after activation.

## Reproducing and limits

Use Node 24 and Python 3.11+, install the repository dependencies, then run:

```
python scripts/prepare_ohmen_engine_tests.py --download
python scripts/run_ohmen_engine_regressions.py final
node --no-warnings scripts/test_ohmen_engine_probes.cjs
lua scripts/test_ohmen_requested_revision.lua .
node scripts/verify_ccg_lua_semantics.cjs --strict-review
```

These are headless duel-engine tests, not a live Omega client multiplayer session. The suite reads the current card database and checksum-pinned Omega Lua helpers (commit b98c1247412d006284810253cca3313f5a2a559d). The isolated public WASM wrapper has a corrected card-data transport layout. Narrow fixture shims supply missing public-core Link helper methods where no compulsory materials exist. Production Omega and its runtime files are unchanged. Exotic interactions outside these scenarios remain unverified.

The repository's broader manual effect-review ledger has outstanding reviews; this work does not claim the full repository QA is green.

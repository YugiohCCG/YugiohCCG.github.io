# CCG Comprehensive Bug Test Report

Generated: 2026-08-23T13:00:18+00:00

## Result

**Automated FAIL** — 15 of 18 checks passed.

**Live-engine certification: INCOMPLETE** — 0 of 97 ruling-sensitive cards have replay-backed passes.

## Audited scope

- Active cards: 620
- Lua scripts: 621 (including compatibility scripts: [210678856])
- SQLite rows: 1249
- Primary archetypes: 95
- Effect creations indexed: 2146
- Callback functions indexed: 3866
- Search/selection calls indexed: 2986
- Open semantic errors: 0
- Open semantic review candidates: 0
- Hash-pinned reviewed semantic findings: 14
- Generated decks covering active cards: 620 cards
- Headless Omega registrations passed: 620 of 620
- Face-up field startup probes passed: 575 of 577 (public-core ABI exclusions: 2)
- Pending live Omega scenarios: 97

## Verification gates

| Gate | Status | Seconds |
|---|---:|---:|
| Authoritative card manifest | PASS | 2.063 |
| Lua compiler syntax | PASS | 14.234 |
| Generated printed-text search pools | FAIL | 0.828 |
| Lua semantic and search-condition audit | PASS | 1.672 |
| Omega runtime references | PASS | 1.406 |
| Archetype interoperability | PASS | 1.641 |
| Named-card runtime relationships | PASS | 0.640 |
| Headless Omega registration | PASS | 5.954 |
| Hash-pinned effect review ledger | FAIL | 0.546 |
| Omega callback smoke | PASS | 11.922 |
| Message routes | PASS | 0.875 |
| Script ZIP parity | PASS | 0.344 |
| Public card data parity | PASS | 0.078 |
| Omega test-deck coverage | PASS | 1.172 |
| Live-test ledger integrity | PASS | 0.656 |
| Manual-input skip report | FAIL | 0.250 |
| Website filter/search unit tests | PASS | 4.141 |
| TypeScript/React lint | PASS | 31.953 |

## Failures

### Generated printed-text search pools

```text
Traceback (most recent call last):
  File "C:\Manual Files\Applications\YugiohCCG.github.io\scripts\sync_text_search_pools.py", line 152, in <module>
    raise SystemExit(main())
  File "C:\Manual Files\Applications\YugiohCCG.github.io\scripts\sync_text_search_pools.py", line 105, in main
    changed += replace(SCRIPTS / f"c{card_id}.lua", TABLE_RE, lua_table("search_codes", ids), args.check)
  File "C:\Manual Files\Applications\YugiohCCG.github.io\scripts\sync_text_search_pools.py", line 91, in replace
    raise RuntimeError(f"stale generated text-search pool: {path.name}")
RuntimeError: stale generated text-search pool: c229327103.lua
```

### Hash-pinned effect review ledger

```text
{
  "active_cards": 620,
  "current_reviews": 609,
  "inherited_current_reviews": 0,
  "fresh_current_reviews": 609,
  "stale_reviews": 11,
  "pending_reviews": 0,
  "current_verdicts": {
    "PASS": 461,
    "UNSUPPORTED": 27,
    "FIXED": 113,
    "MANUAL_RULING": 8
  },
  "errors": 0
}
```

### Manual-input skip report

```text
active_cards=620
objectively_resolved=585
unresolved_skips=35
regression_only=79
manual_scenarios=97
errors=1
ERROR effect ledger contains stale or pending reviews
```


## Interpretation

A pass proves the automated contracts represented by these gates. Hash-pinned reviewed findings are intentional multi-stage search routes and are automatically reopened if their Lua source changes. Bespoke mechanics and ruling-sensitive behavior listed in the semantic audit still require live Omega scenario testing; they are not represented as confirmed defects.

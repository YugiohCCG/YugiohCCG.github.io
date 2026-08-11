# CCG Comprehensive Bug Test Report

Generated: 2026-08-11T11:26:43+00:00

## Result

**Automated PASS** — 20 of 20 checks passed.

**Live-engine certification: INCOMPLETE** — 0 of 97 ruling-sensitive cards have replay-backed passes.

## Audited scope

- Active cards: 577
- Lua scripts: 578 (including compatibility scripts: [210678856])
- SQLite rows: 1162
- Primary archetypes: 85
- Effect creations indexed: 1988
- Callback functions indexed: 3617
- Search/selection calls indexed: 2762
- Open semantic errors: 0
- Open semantic review candidates: 0
- Hash-pinned reviewed semantic findings: 14
- Generated decks covering active cards: 577 cards
- Headless Omega registrations passed: 577 of 577
- Face-up field startup probes passed: 575 of 577 (public-core ABI exclusions: 2)
- Pending live Omega scenarios: 97

## Verification gates

| Gate | Status | Seconds |
|---|---:|---:|
| Authoritative card manifest | PASS | 1.094 |
| Lua compiler syntax | PASS | 10.453 |
| Generated printed-text search pools | PASS | 0.765 |
| Lua semantic and search-condition audit | PASS | 1.360 |
| Omega runtime references | PASS | 1.187 |
| Archetype interoperability | PASS | 1.563 |
| Named-card runtime relationships | PASS | 0.547 |
| Headless Omega registration | PASS | 5.593 |
| Hash-pinned effect review ledger | PASS | 0.641 |
| Omega callback smoke | PASS | 11.219 |
| Message routes | PASS | 0.562 |
| Script ZIP parity | PASS | 0.281 |
| Public card data parity | PASS | 0.079 |
| Omega test-deck coverage | PASS | 0.875 |
| Live-test ledger integrity | PASS | 0.546 |
| Manual-input skip report | PASS | 0.204 |
| Website filter/search unit tests | PASS | 3.390 |
| TypeScript/React lint | PASS | 4.438 |
| Omega release integrity | PASS | 26.765 |
| Production build | PASS | 17.188 |

## Interpretation

A pass proves the automated contracts represented by these gates. Hash-pinned reviewed findings are intentional multi-stage search routes and are automatically reopened if their Lua source changes. Bespoke mechanics and ruling-sensitive behavior listed in the semantic audit still require live Omega scenario testing; they are not represented as confirmed defects.

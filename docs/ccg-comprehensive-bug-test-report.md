# CCG Comprehensive Bug Test Report

Generated: 2026-08-14T16:37:33+00:00

## Result

**Automated PASS** — 20 of 20 checks passed.

**Live-engine certification: INCOMPLETE** — 0 of 97 ruling-sensitive cards have replay-backed passes.

## Audited scope

- Active cards: 577
- Lua scripts: 578 (including compatibility scripts: [210678856])
- SQLite rows: 1162
- Primary archetypes: 85
- Effect creations indexed: 1993
- Callback functions indexed: 3619
- Search/selection calls indexed: 2771
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
| Authoritative card manifest | PASS | 0.984 |
| Lua compiler syntax | PASS | 11.703 |
| Generated printed-text search pools | PASS | 1.063 |
| Lua semantic and search-condition audit | PASS | 1.375 |
| Omega runtime references | PASS | 1.093 |
| Archetype interoperability | PASS | 1.516 |
| Named-card runtime relationships | PASS | 0.500 |
| Headless Omega registration | PASS | 5.656 |
| Hash-pinned effect review ledger | PASS | 0.781 |
| Omega callback smoke | PASS | 12.266 |
| Message routes | PASS | 0.594 |
| Script ZIP parity | PASS | 0.312 |
| Public card data parity | PASS | 0.094 |
| Omega test-deck coverage | PASS | 0.891 |
| Live-test ledger integrity | PASS | 0.578 |
| Manual-input skip report | PASS | 0.172 |
| Website filter/search unit tests | PASS | 3.531 |
| TypeScript/React lint | PASS | 5.172 |
| Omega release integrity | PASS | 27.859 |
| Production build | PASS | 17.969 |

## Interpretation

A pass proves the automated contracts represented by these gates. Hash-pinned reviewed findings are intentional multi-stage search routes and are automatically reopened if their Lua source changes. Bespoke mechanics and ruling-sensitive behavior listed in the semantic audit still require live Omega scenario testing; they are not represented as confirmed defects.

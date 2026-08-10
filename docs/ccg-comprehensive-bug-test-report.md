# CCG Comprehensive Bug Test Report

Generated: 2026-08-10T20:48:23+00:00

## Result

**Automated PASS** — 16 of 16 checks passed.

**Live-engine certification: INCOMPLETE** — 0 of 123 ruling-sensitive cards have replay-backed passes.

## Audited scope

- Active cards: 577
- Lua scripts: 578 (including compatibility scripts: [210678856])
- SQLite rows: 1162
- Primary archetypes: 85
- Effect creations indexed: 1985
- Callback functions indexed: 3605
- Search/selection calls indexed: 2769
- Open semantic errors: 0
- Open semantic review candidates: 0
- Hash-pinned reviewed semantic findings: 14
- Generated decks covering active cards: 577 cards
- Headless Omega registrations passed: 577 of 577
- Face-up field startup probes passed: 575 of 577 (public-core ABI exclusions: 2)
- Pending live Omega scenarios: 123

## Verification gates

| Gate | Status | Seconds |
|---|---:|---:|
| Authoritative card manifest | PASS | 1.032 |
| Lua compiler syntax | PASS | 9.000 |
| Lua semantic and search-condition audit | PASS | 1.109 |
| Omega callback smoke | PASS | 9.015 |
| Omega runtime references | PASS | 1.000 |
| Archetype interoperability | PASS | 1.266 |
| Headless Omega registration | PASS | 5.031 |
| Message routes | PASS | 0.625 |
| Script ZIP parity | PASS | 0.313 |
| Public card data parity | PASS | 0.093 |
| Omega test-deck coverage | PASS | 0.719 |
| Live-test ledger integrity | PASS | 0.516 |
| Website filter/search unit tests | PASS | 3.000 |
| TypeScript/React lint | PASS | 4.219 |
| Omega release integrity | PASS | 25.281 |
| Production build | PASS | 16.953 |

## Interpretation

A pass proves the automated contracts represented by these gates. Hash-pinned reviewed findings are intentional multi-stage search routes and are automatically reopened if their Lua source changes. Bespoke mechanics and ruling-sensitive behavior listed in the semantic audit still require live Omega scenario testing; they are not represented as confirmed defects.

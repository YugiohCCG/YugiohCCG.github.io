# CCG Comprehensive Bug Test Report

Generated: 2026-11-17T17:44:43+00:00

## Result

**Automated PASS** — 15 of 15 checks passed.

**Live-engine certification: INCOMPLETE** — 0 of 88 ruling-sensitive cards have replay-backed passes.

## Audited scope

- Active cards: 703
- Lua scripts: 704 (including compatibility scripts: [210678856])
- SQLite rows: 1416
- Primary archetypes: 90
- Effect creations indexed: 2462
- Callback functions indexed: 4426
- Search/selection calls indexed: 3530
- Open semantic errors: 0
- Open semantic review candidates: 0
- Hash-pinned reviewed semantic findings: 21
- Generated decks covering active cards: 703 cards
- Headless Omega registrations passed: 620 of 620
- Face-up field startup probes passed: 575 of 577 (public-core ABI exclusions: 2)
- Pending live Omega scenarios: 88

## Verification gates

| Gate | Status | Seconds |
|---|---:|---:|
| Authoritative card manifest | PASS | 1.703 |
| Lua compiler syntax | PASS | 11.453 |
| Generated printed-text search pools | PASS | 1.719 |
| Lua semantic and search-condition audit | PASS | 1.797 |
| Hash-pinned effect review ledger | PASS | 0.843 |
| Omega callback smoke | PASS | 13.344 |
| Message routes | PASS | 2.235 |
| Script ZIP parity | PASS | 0.406 |
| Public card data parity | PASS | 0.062 |
| Omega test-deck coverage | PASS | 1.203 |
| Live-test ledger integrity | PASS | 0.500 |
| Manual-input skip report | PASS | 0.219 |
| Website filter/search unit tests | PASS | 4.578 |
| TypeScript/React lint | PASS | 6.328 |
| Production build | PASS | 22.079 |

## Interpretation

A pass proves the automated contracts represented by these gates. Hash-pinned reviewed findings are intentional multi-stage search routes and are automatically reopened if their Lua source changes. Bespoke mechanics and ruling-sensitive behavior listed in the semantic audit still require live Omega scenario testing; they are not represented as confirmed defects.

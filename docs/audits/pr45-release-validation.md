# PR45 release validation

The Lua update reopened 322 hash-pinned reviews. Each current script was compared with the exact Git blob matching its previous review. The old records are preserved in `pr45-review-history.json`; source/text hashes and individual delta conclusions are in `pr45-semantic-deltas.json`.

142 scripts have unchanged printed text and identical executable ASTs after narrowly normalizing their own-Hand receipt/reveal guards. The classifier preserves all other expressions, predicates, strings and control flow. Its positive and negative self-tests reject changed costs, recipients, strings, numeric values, follow-up operations and pre-movement conditions. Reproduce with:

```text
node scripts/review_pr45_receipt_deltas.cjs --self-test
node scripts/review_pr45_receipt_deltas.cjs docs/audits/pr45-receipt-input.json
```

The remaining 180 scripts received static semantic delta reviews, including the 11 changed printed texts. Unchanged clauses retain their prior review evidence. This renewal is not a new full gameplay audit and does not certify native Omega behavior.

Existing unresolved classifications remain open. Four additional current records explicitly carry the already documented Nautica limitations: Evander and Adventures prospective-Hand eligibility, Musicale groupless reports when a summon is negated, and Oceanica intermediate-chain follow-up timing. Oni retains its separate wording/ruling and partial effect-conversion limitations. See `docs/CCG-ARCHETYPE-AUDIT-HANDOFF.md` and the individual ledger entries. No gate or pass criterion was relaxed.

Release repairs also pin the official Water Hazard runtime reference, correct the callback smoke mock to use the engine five-value operation-information contract, and refresh the standalone script and database ZIPs and their download hashes.

Validation on the repaired source:

- Complete 15-gate CCG CI suite, including Lua syntax/callbacks, semantic review, database/card parity, archive parity, website tests, lint and production build.
- 1,314 installed-effect fixture cases passed using the documented public-core compatibility adapter.
- All 33 Ohmen engine fixture families passed.
- Additional database prerequisites, parser-call tests, Lua release contracts, Ohmen probes, Floowandereeze/Fiendsmith duel tests, release regressions and archetype checks passed.
- Full Omega download audit passed, including database, scripts, images, installer, checksums and smoke installation.

Replay-backed native Omega certification remains incomplete and is reported separately by the existing live-test ledger.

# QA portability and packaging repairs — 15 October 2026

The PR logs contained infrastructure defects and genuine review-coverage failures. They are distinct.

## Repairs

- Remove the accidental `tmp/omega_scripts` gitlink, which had no `.gitmodules` URL. No fake submodule URL is introduced. Fetch complete history because the effect ledger inspects an earlier commit.
- Supply a compressed, checksum-pinned copy of the real official Omega database. Offline and Linux QA no longer opens a Windows-shaped path and silently creates an empty SQLite file. Read-only schema prechecks reject missing or malformed databases. `OMEGA_OFFICIAL_DB` can explicitly select another valid reference.
- Rebuild the canonical custom database and ID map from the 711 active card records, adding the 91 missing cards; refresh the shipped database ZIP. Compare escaped printed-text newlines using the same normalization as the database exporter.
- Handle luaparse normal, table-sugar and string-sugar calls. Regression checks exercise every form.
- Keep the installer card-only: retain inactive reference scripts under `scripts/reference`, embed the unchanged Sylvan helper in its eight standalone callers, and rebuild the archive. Normalize archive and review-hash line endings consistently across Windows and Linux.
- Correct smoke-harness object types for reason/card effects, Union filters, face-up-placement tracking, victim cards and per-copy state. These are test-double fixes, not claimed live-engine certification.
- Record five inspected, hash-pinned multi-stage search explanations. Keep the strict semantic gate enabled.
- Remove the irregular whitespace in BanList, Cards and Releases.

## Remaining blockers

The effect-review ledger still reports **134 stale reviews and 91 pending cards**. The manual-input report correctly rejects the same incomplete coverage. These are real review-work requirements, not missing SQLite tables or a test runner exception. No hashes were renewed for unreviewed cards, no PASS results were invented, and neither gate was disabled.

The local CI-equivalent run passes the other 13 of 15 gates, including all 712 Lua syntax and callback-smoke checks, card/database parity, generated search pools, strict semantic audit, message routes, script ZIP parity, website tests, lint and production build. Native Lua 5.4 is used in GitHub Actions; local checks used the Lua 5.4 runtime shipped by Lupa through a CLI adapter.

The separate database-precondition regression tests and parser-call regression tests pass. CI runs those before the full suite.

## Official reference provenance

`scripts/data/official-omega.db.gz` is the complete database captured from the local Omega installation, not a minimal fabricated fixture. `official-omega.db.json` records its SHA-256 and byte length. Expansion under `tmp/qa-reference` is ignored by Git. To refresh, capture a consistent official database, compress it, update that metadata, regenerate printed-text pools, and review the resulting changes before publishing. The file contains data only; runtime script dependencies are not supplied through a broken gitlink.

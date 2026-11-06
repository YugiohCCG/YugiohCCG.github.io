# Release readiness ? 2026-11-07

The supplied Vanquish Soul Brawl image is included at `public/assets/cards/Vanquish_Soul_Brawl.png`, and all 703 Art/Pic payloads are present. The complete Omega release audit passes locally, including simulated installation, installer, database/script parity, artwork and artifact checksums. Banlist line endings are pinned to LF so checksums match Linux CI and Windows builds.

The existing 15-check QA suite passes locally. All 33 Ohmen engine fixture families, targeted engine probes, new Floowandereeze/Fiendsmith fixtures, targeted card regressions, and release Lua/asset regression tests pass. Full download verification now runs in CI.

Evenly Matched is unrestricted. Medicurius the Power Patron of Illusions is banned. Ohmenchanic spelling is retained.

Static semantic reviews are not live Omega certification. Known unsupported mechanics and designer ruling questions remain explicitly classified in the review ledger; historical records are retained in `scripts/output/release-review-history.json`.

Publication proceeds after the final GitHub checks pass. The deployed Pages build and live card/download metadata must then be verified.

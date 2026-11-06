# Release readiness ? 2026-11-07

The website update is not published yet. PR #42 must remain unmerged until the missing Vanquish Soul Brawl image is supplied and the complete download audit passes.

- `qa:ccg:ci`: 15/15 checks pass locally, including website tests, lint, production build, database/source parity, all 703 current effect reviews, strict Lua semantic audit, callback and script ZIP checks.
- Ohmen: all 33 engine fixture families and targeted engine probes pass. New Floowandereeze/Fiendsmith activation and effect fixtures pass. Targeted Mevalkagna, Aquasanctuary, Glome, Volt, Terror Skull recovery and Brawl recycle regressions pass.
- Corrected official shared archetype codes, signed-safe prompt carriers, current database and script payload, image URL query handling, printed-star detection and canonical download-part selection.
- Rebuilt installer, database ZIP and image archives. Full download audit passes every check except the absent Brawl source image and its corresponding Art/Pic entries.
- Required source asset: `public/assets/cards/Vanquish_Soul_Brawl.jpeg` (card 244161941). It must be the actual approved card image, not a placeholder.
- Evenly Matched is unrestricted. Medicurius the Power Patron of Illusions is banned. Ohmenchanic spelling is retained.

Static semantic reviews are not live Omega certification. Known unsupported mechanics and designer ruling questions remain explicitly classified in the review ledger; historical records are retained in `scripts/output/release-review-history.json`.

After the image is provided, add its Art/Pic to the retained `tmp/release_staging` exports, rebuild archive parts and installer, regenerate metadata/build, rerun the complete release audit and GitHub CI, then merge PR #42 and verify Pages deployment.

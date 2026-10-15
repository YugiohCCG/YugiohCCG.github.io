# Ohmen card wording and artwork revision — 15 October 2026

All 15 card images use the latest artwork. The editable ygocarder exports, website descriptions, downloadable Omega database and image packages, and local Omega installation share the revised text. Statistics, attributes and Link Arrows retain the existing card data; differing metadata in the supplied historical transcript is not treated as a request to change them.

## Requested changes

- Use **Ohmenchanic** in current names and references.
- Ampere Link 2+: restore Main Phase activation wording.
- Coulomb Link 1+: restore your Main Phase activation wording.
- Volt Link 1+: restore the original your Main Phase restriction lost during shortening.
- Carcel Link: place the calculated counters on both this card and all co-linked monsters, including an opponent's monster if co-linked. Removing the controller restriction can affect gameplay.
- Siemens Link 2+: explicitly move a monster on either player's field to another Main Monster Zone on its own controller's field pointed to by a co-linked monster you control. This does not take control and does not require its starting zone to be pointed to.
- Siemens Link 3+: explicitly take control, placing the target in your pointed-to Main Monster Zone. Correct the engine control-transfer call to pass the destination mask in the zone argument.
- Five main-deck spread effects: end when no affected Link Monster you control is co-linked to a monster without a counter placed by this resolution. Movement and Farad/Volt follow-up Summons use zones pointed to by **any Link Monster that received a counter from this effect**, as confirmed by the designer.

The shared script traverses each recipient once per resolution, distinguishes existing counters from counters placed by this effect, and stops propagation at a monster that cannot receive its counter. Branches and cycles terminate. Movement now uses all successful recipients rather than only depth-based endpoints. This is an intentional destination-rule revision, not merely shorter wording.

## Verification

Focused Lua callback tests cover all five spreading implementations with a branch, cycle, pre-existing counters and blocked counter placement. Siemens tests cover own/opponent destinations, occupied zones, opponent-zone selection orientation and control destination arguments. These are automated callback regressions, not full certification in the Omega client.

Full-resolution comparisons preserve the supplied original effect text alongside the revised text, with word-level changes highlighted and original artwork beside the latest renders.

## Further TCG-only wording audit

Two conservative editorial reductions save 39 characters: Volt Link uses the Fire Cracker damage shorthand; Carcel Link uses the Transcode Talker co-linked-group shorthand. All other current card clauses and all gameplay scripts are unchanged by this audit. See [the per-effect audit](ohmen-tcg-wording-audit-20261015.md) for official TCG references, equivalence checks and rejected shortcuts.


## Designer corrections — 16 October 2026

Coulomb Link 3+ now ends: `immediately after this effect resolves, Link Summon an "Ohmen" monster.` The explicit materials-you-control phrase is omitted. Ampere Link 2+ now begins: `During your Main Phase:`. All other timing, costs, counters and effects are retained.

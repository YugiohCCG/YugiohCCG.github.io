# YGO Omega Lua Audit - 2026-07-19 Second Pass

## Outcome

This pass re-audited the complete public Lua payload against the official YGO Omega corpus in `tmp/omega_scripts`, with special attention to each registered effect's callbacks, legality checks, targeting, timing, costs, operation ordering, summon procedures, and Graveyard movement.

- 481 standalone Lua files were loaded and mechanically audited against 17,470 official Omega Lua files.
- 466 scripts correspond to current cards in `src/data/cards.json` and the custom Omega DB.
- 140 scripts changed relative to the synchronized first-pass baseline: 132 active scripts and 8 mechanically corrected orphan scripts.
- 15 preserved, untracked scripts are orphans: their former cards are absent from `cards.json`, the ID map, and all three custom DB copies. They cannot receive a current text-parity verdict.
- No remaining syntax error, unresolved `s.*` callback, nil registered callback, custom-only official API call, missing targeting flag, or missing Extra Deck procedure/revive-limit issue was found.

This was an extensive static, callback-registration, data-linkage, archive, and build test. It was not a live duel in the Omega engine, so interaction prompts and unusual rulings still need targeted in-engine confirmation.

## Sources and Method

The source of truth for engine-compatible structure was:

- `tmp/omega_scripts/constant.lua`
- `tmp/omega_scripts/utility.lua`
- `tmp/omega_scripts/procedure.lua`
- the 17,467 official card/helper scripts beside them

For active custom cards, the comparison order was card text in `src/data/cards.json`, current Omega ID, Lua implementation, public DB row, installed DB row, then the closest official effect pattern. The second pass also re-used the first-pass per-card findings rather than treating the corpus as unreviewed code.

The strict smoke harness loaded the real official constants and helpers, loaded every custom script, verified every named source callback exists at load time, inspected all registered condition/cost/target/operation references, and invoked callback branches with engine-shaped stubs. It exercised 4,325 registered callbacks. Fifty-two branches stopped on deliberately incomplete mock card/group/event data; none was an unresolved callback, missing global helper, or registration failure.

## Confirmed Fixes

### Structural and missing-effect defects

- `c259934043.lua` (`Grayling, the Grayscale Imp`) was incomplete. It now registers both printed effects, the material restrictions, the LIGHT Fiend Special Summon oath/activity check, effect-resolution discard, and different-name Level 8 search.
- `c259923860.lua` (`Grayscale Awakening: Revelation`) had a missing `end` that nested four callbacks inside another function. All callbacks are now top-level and registered.
- The first-pass duplicate/nested `initial_effect` fixes for `Grayhex`, `Graylock`, and `Grayrover` were revalidated. Every script now exposes exactly one working initializer.

### Official API and summon-procedure compatibility

All custom-only helper/API calls found by the wider scan were replaced with patterns present in the official corpus. This included Synchro, Xyz, Link, and Level-Free Xyz procedure helpers; target-group retrieval; release-group selection; field-Spell activation; chain-operation handling; client hints; archetype-list checks; card predicates; and object iteration.

The final call-name comparison found 224 `Duel`/`Card`/`Group`/`Effect`/`aux` call names in custom scripts, 589 in the official corpus, and zero custom-only names. A targeted regression scan for every invalid symbol corrected in this pass also returned zero hits.

Every Fusion, Synchro, Xyz, and Link card now has either the expected official helper or a deliberate custom summon procedure matching its printed condition. Every Extra Deck and Ritual monster script calls `EnableReviveLimit()`.

### Targeting correctness

Twenty-four effects across 22 scripts selected chain targets without `EFFECT_FLAG_CARD_TARGET`. The flag was added to:

`210506870`, `215629896`, `221321849`, `227043533`, `228386117`, `236179696`, `236815197`, `241957394`, `241976572`, `247458749`, `248290754`, `255082735`, `256930605`, `259203522`, `259350270` (2), `259405917` (2), `259519336`, `259650969`, `259841490`, and `259869259`.

The reverse scan found no effects advertising card targeting without actually selecting a target. Thirteen apparent omissions were manually cleared because they use `SetTargetCard`, copied activation targets, or chain target groups rather than `Duel.SelectTarget`.

### Graveyard legality and Necrovalley

The broadest defect cluster was activation/resolution legality for cards moved from the GY. Filters and operations were corrected across self-revival, target revival, GY costs, banishment, return-to-Deck, return-to-hand, self-Set, and Extra Deck summon-material paths.

Representative corrected scripts include `c220305422`, `c221924008`, `c223750159`, `c224751741`, `c225055909`, `c228464260`, `c230812008`, `c234351716`, `c236616849`, `c239245471`, `c243501716`, `c245452058`, `c249629457`, `c251699681`, `c252513554`, `c255668557`, `c257239133`, `c259350270`, `c259405917`, `c259417461`, `c259650969`, and `c259737127`.

The final named-filter scan leaves only documented false positives: copied effects with no GY movement, count-only checks, optional field activation, or functions transitively wrapped by a Necrovalley-safe caller. The self-movement scan found zero unguarded self-return, self-Set, self-send, or self-Deck operations; its four self-Special-Summon hits are all transitively guarded.

### Trigger timing

Missing `EFFECT_FLAG_DELAY` was added to optional "If" triggers in 21 scripts, including the Grayling/Grayscale, Stained, Nautica, Chrono-Saur, and other affected effects. Optional LP-cost and banishment-event triggers were aligned with official examples.

Incorrect delay flags were removed from three printed "When ... You can" triggers (`c221924008`, `c255668557`, and `c259614449`) so they can miss timing as written. The remaining optional no-delay triggers were individually reviewed as immediate summon, attack, battle, chain, or battled events.

### Cost versus resolving effect

`Grayhex`, `Graylock`, and `Grayrover` incorrectly discarded as an activation cost even though their text says "discard 1 card, and if you do". Their discard now occurs during resolution with `REASON_EFFECT+REASON_DISCARD`; Special Summoning only follows a successful discard. `Graysentry` already discarded during resolution, but now requires and selects an actually discardable card.

All remaining `DiscardHand(...REASON_COST)` uses were checked against their semicolon/cost wording; no further mismatch was confirmed.

### Player and location scope

- `c259434499.lua` (`Ohmen Powerload`) could destroy from the opponent's hand or GY. It now selects one destructible card the opponent controls.
- `c249746105.lua` (`Aquamarine Physalia`) could destroy either player's field card. It now selects only a destructible card the opponent controls.

### Count limits and summon flags

All 34 repeated `SetCountLimit` codes were compared with the printed text. They are intentional shared "only one effect" limits, alternate-event clones, soft once-per-turn effects, or auxiliary delayed effects. No count-limit edit was justified.

Every `EFFECT_SPSUMMON_PROC` effect has the required uncopyable property. The four Normal Monster scripts with empty `initial_effect` functions are valid because their DB rows identify them as Normal Monsters.

## Highest-Risk Card Results

| Omega ID | Card | Second-pass result |
| ---: | --- | --- |
| 259934043 | Grayling, the Grayscale Imp | Fixed missing printed effect suite, oath/activity handling, and search resolution. |
| 259923860 | Grayscale Awakening: Revelation | Fixed nested/missing callbacks caused by a missing `end`. |
| 259688514 | Grayhex, the Chanter of Grayscale | Fixed discard-as-cost and revalidated the single initializer. |
| 259724129 | Graylock, the Sorcerer of Grayscale | Fixed discard-as-cost and revalidated the single initializer. |
| 259937399 | Grayrover, the Wandering Grayscale | Fixed discard-as-cost; revalidated the official Extra Link Material pattern. |
| 259341133 | Graysentry, the Guard of Grayscale | Fixed discardability and delayed GY trigger behavior. |
| 259434499 | Ohmen Powerload | Fixed opponent-control destruction scope and official client-hint form. |
| 249746105 | Aquamarine Physalia | Fixed opponent-control destruction scope and GY cost legality. |

## Verification Evidence

- Lua syntax: public 481/481, installed Omega 481/481, and `dist` 481/481 passed `luac -p`.
- Strict load/registration smoke: 481 scripts, 4,325 callbacks, zero scope failures, zero nil registrations, and zero missing helper fields.
- Structural scan: zero duplicate initializers, zero unresolved named callbacks, and zero callback functions unexpectedly nested at load time.
- API comparison: 224 custom call names, 589 official call names, zero custom-only names.
- Targeting analyzer: zero missing `EFFECT_FLAG_CARD_TARGET` findings after review and fixes.
- Extra Deck procedure audit: zero missing revive limits and zero unexplained missing Fusion/Synchro/Xyz/Link procedures.
- Script mirror parity: zero missing or mismatched custom scripts between public, installed Omega, and `dist`.
- ZIP parity: public and `dist` archives each contain 481 scripts, with zero missing or mismatched payloads; the ZIP files hash-match.
- DB parity: public, installed, and `dist` SHA-256 is `D077D2D242AA7143D4C9F60A56BA226EF32CB78ECC35B508E5A1CD6742A203C1`.
- DB structure: all three copies contain 586 `datas` rows and 586 `texts` rows.
- DB ZIP parity: public and `dist` each contain one DB payload matching the public DB.
- Generated artifacts: source/public/`dist` `cards.json` and public/`dist` ID maps hash-match.
- `npm run build`: passed; only Vite's existing large-chunk advisory remains.

## Preserved Artifact Findings

### Fifteen orphan Lua files

These scripts do not have a current `cards.json`, ID-map, `datas`, or `texts` entry:

`210711859`, `210714859`, `212352495`, `222525492`, `224855909`, `225055909`, `232886050`, `234351716`, `240325495`, `243501716`, `248509042`, `250325492`, `251235492`, `254351716`, `258832942`.

They appear to be removed Arckcestial/Bau prototypes. They were kept because they are untracked user-owned files. Eight received mechanical compatibility corrections before their orphan state was discovered; none is treated as text-verified. A future cleanup should either restore their card/DB definitions or explicitly delete the scripts from public, installed Omega, `dist`, and both ZIP payloads.

### Older blank `aux.Stringid` slots

The accurate cross-card-aware message scan found 180 blank `aux.Stringid` uses across 71 active scripts, including 130 effect descriptions and 50 option/confirmation/client-hint strings. This is pre-existing DB/UI debt rather than a Lua execution failure: effect logic still registers and runs, but some prompts can be blank. It was not auto-filled because inventing 71 cards' user-facing messages is a separate text-authoring change and could encode the wrong ruling.

The newly corrected Grayscale scripts have complete DB messages. Public, installed, and `dist` DBs remain byte-identical.

## Remaining Live-Duel and Ruling Checks

1. Resolve `Devotee of Fire`'s ambiguous second sentence before changing its current two-trigger interpretation.
2. Confirm copied-activation choice/timing for `Shaman of Fire` and `Blazing Gaia the Spiral Knight`.
3. Confirm `Grayrover`'s hand Extra Link Material prompt and material consumption.
4. Confirm `Urphiel's Feather Downpour`'s non-targeting optional second banish sequence.
5. Spot-check the newly corrected Necrovalley activation gates and "discard, and if you do" Grayscale resolutions in a live duel.

## Exact Official Pattern References

- Field Spell activation: `c1050355.lua`, `c11881272.lua`, `c13093792.lua`.
- Necrovalley-safe movement: `c100245019.lua`, `c120205026.lua`, `c120208013.lua`.
- Extra Link Material: `c100201001.lua`, `c100239201.lua`, `c100256017.lua`, `c16684346.lua`.
- Special Summon activity/oath counters: `c100245016.lua` through `c100245023.lua`.
- Optional delayed GY triggers: `c10019086.lua`, `c100211003.lua`, `c100240201.lua`, `c100245023.lua`.
- Copied activation validation and forwarding: `c100261026.lua`, `c10136446.lua`.
- Detachment movement events: `c100256012.lua`, `c101203047.lua`.

## Second-Pass Changed IDs

`210506870`, `211873618`, `212413422`, `214349717`, `215006791`, `215068354`, `215105971`, `215629896`, `216258796`, `216294702`, `219543855`, `219714894`, `219826457`, `220150285`, `220305422`, `220856437`, `221321849`, `221822671`, `221855414`, `221924008`, `222525492`, `223750159`, `223770816`, `224751741`, `224811863`, `224943273`, `225055909`, `226645052`, `227035644`, `227043533`, `227610954`, `228040066`, `228386117`, `228464260`, `228635967`, `228860650`, `230303021`, `230812008`, `231273040`, `232824319`, `232886050`, `233499093`, `234296128`, `234351716`, `234507067`, `235051048`, `235612490`, `235637994`, `236179696`, `236616849`, `236721134`, `236815197`, `237089049`, `237684285`, `238035167`, `238064522`, `238256111`, `239235967`, `239245471`, `240104048`, `241504188`, `241880822`, `241957394`, `241976572`, `242094473`, `243501716`, `244972185`, `244986323`, `245378354`, `245452058`, `247378501`, `247458749`, `248290754`, `248453205`, `248509042`, `248760718`, `249018041`, `249629457`, `249746105`, `250047045`, `250339529`, `251235492`, `251236672`, `251699681`, `251710981`, `252513554`, `252552954`, `253472430`, `254351716`, `255048812`, `255082735`, `255668557`, `255686110`, `256110263`, `256469525`, `256930605`, `257081514`, `257239133`, `257794541`, `258241424`, `259023461`, `259093260`, `259097228`, `259114562`, `259135917`, `259193076`, `259203522`, `259229055`, `259245496`, `259341133`, `259350270`, `259352030`, `259366281`, `259366507`, `259377794`, `259405917`, `259410628`, `259417461`, `259431066`, `259434499`, `259465391`, `259500899`, `259519336`, `259614449`, `259624110`, `259626409`, `259632020`, `259650969`, `259686203`, `259688514`, `259724129`, `259737127`, `259753109`, `259841490`, `259869259`, `259920959`, `259923860`, `259934043`, `259937399`, `259943152`.

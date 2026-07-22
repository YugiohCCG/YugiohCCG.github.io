# YGO Omega Lua Audit - 2026-07-20 Third Pass

## Outcome

This was an independent third-pass audit of the complete custom Lua payload against the current official Omega reference in `tmp/omega_scripts`.

- 481 public Lua files were syntax-tested, registration-smoked, and mechanically scanned against 17,532 official/reference Lua files.
- 466 scripts map to current cards in `src/data/cards.json` and the custom Omega DB. The other 15 remain preserved orphan prototypes with no current card or DB row.
- 13 active scripts received confirmed behavior fixes.
- The public, installed Omega, `dist`, and ZIP script payloads are synchronized after the fixes.
- No syntax failure, missing `initial_effect`, nil registered callback, unresolved named callback, custom-only official API member, or mirror mismatch remains.

This pass was static and harness-based rather than a live Omega duel. Interaction timing and card-pool-sensitive copied effects still merit the live checks listed below.

## Confirmed Fixes

### "Negate that effect" was incorrectly negating the activation

Eight effects used `Duel.NegateActivation(ev)` even though their printed text says to negate the resolving effect. They now use the official effect-negation trio:

- `Duel.IsChainDisablable(ev)` for activation legality;
- `CATEGORY_DISABLE` for effect/category metadata; and
- `Duel.NegateEffect(ev)` during resolution.

Affected cards:

- `c220305422.lua` - Natir, the Swords Master of Crying Chaos
- `c233499093.lua` - Dragon of Crying Chaos
- `c234296128.lua` - Revelation of Crying Chaos
- `c249629457.lua` - Shining Brigade - Last Stand
- `c249805098.lua` - Starry Knight Arc-En-Ciel
- `c252552954.lua` - Altergeist Ifritware
- `c259494236.lua` - Glitchling Digitron
- `c259873115.lua` - Glitchling Leotron

This distinction is functional: effect negation leaves an activation intact, while activation negation can change card placement and once-per-turn/activation handling for Spell/Trap activations.

### Existing effect negators used the wrong chain predicate

Three scripts already called `Duel.NegateEffect(ev)` but checked `Duel.IsChainNegatable(ev)` or did not check effect-negation legality. They could therefore offer an effect that would destroy/pay its cost but fail to negate an undisablable chain link.

- `c213530841.lua` - Chrono-Saur Counter
- `c259235389.lua` - Chrono-Saur Tricera
- `c259366281.lua` - Phlogiston's Roar

Their predicates and operation categories now use `IsChainDisablable`/`CATEGORY_DISABLE`.

### Forced optional follow-up

`c214552846.lua` (`Eldora, the Intergalactic Empire`) always Set `Eldora in Depraevity` after destroying the matching monsters, despite the printed `then you can Set` wording. The Set branch now asks the player before proceeding. The prompt reuses the existing nonblank DB effect string.

### Missing copied Standby Phase effect

`c211964444.lua` (`Priestess of Nephthys`) destroyed the revealed `Nephthys` monster but stopped there. It never applied the selected monster's effect that activates during the Standby Phase.

After a successful destruction, it now uses the official copied-effect idiom: retrieve the destroyed card's activatable effect with `CheckActivateEffect(true,true,true)`, forward its target callback, and run its operation. This restores behavior that an older verified version and the handoff documentation described but the current payload had lost.

## Third-Pass Scan Coverage

The third pass rechecked every active script/card pairing for:

- printed trigger events versus registered summon, movement, battle, chain, phase, material, release, destruction, and banishment events;
- optional `If`/`When` timing and `EFFECT_FLAG_DELAY` behavior;
- effect versus activation negation and matching legality predicates;
- costs versus resolving operations, especially discard/release/destroy wording;
- `and if you do`, `then`, and `then you can` sequencing;
- temporary resets, next-Standby scheduling, leave-field redirects, and delayed returns;
- target flags and target/operation separation;
- own/opponent/either-player field, GY, and banishment scope;
- summon locks, material restrictions, once-per-turn buckets, and Extra Deck procedures;
- direct attack, piercing, attack restrictions, damage prevention, protection, counters, and activation-from-hand clauses;
- Necrovalley-sensitive GY movement; and
- custom `Duel`, `Card`, `Group`, `Effect`, and `aux` members against the official corpus.

Broad candidates were inspected rather than auto-edited. Examples cleared as false positives include material-detachment triggers correctly using `EVENT_TO_GRAVE` plus previous-overlay checks, Spirit End Phase returns implemented by `aux.EnableSpiritReturn`, damage-calculation continuous effects keyed directly to `PHASE_DAMAGE_CAL`, and official copied/continuous negation patterns that do not require a chain-disablable activation check.

The final focused regressions returned:

- zero strict `then you can` clauses without a player-choice API;
- zero activated `Duel.NegateEffect(ev)` effects lacking `Duel.IsChainDisablable(ev)`, excluding the deliberate continuous material effect on `c232038002.lua`;
- zero unresolved registered `s.*` callbacks; and
- zero custom-only official API members.

## Verification Evidence

- Lua syntax: public `481/481`, installed Omega `481/481`, and `dist` `481/481` passed `luac -p`.
- Registration smoke: all 481 scripts exposed `initial_effect`; 1,294 `Effect.CreateEffect` calls and 2,965 condition/cost/target/operation/value callback assignments registered with zero failures.
- Static callback linkage: 3,059 named callback references, zero unresolved definitions.
- API comparison: 224 custom `Duel`/`Card`/`Group`/`Effect`/`aux` members, 589 in the recursive official corpus, zero custom-only members.
- Mirror parity: 481 public scripts, zero installed mismatches, zero `dist` mismatches.
- ZIP parity: 481 entries, zero missing files, zero content mismatches; public and `dist` ZIP hashes match.
- DB parity: public, installed, and `dist` SHA-256 remains `D077D2D242AA7143D4C9F60A56BA226EF32CB78ECC35B508E5A1CD6742A203C1`.
- DB structure: all three DBs remain `586/586` for `datas`/`texts` rows.
- Generated card and ID-map artifacts remain byte-identical between their source/public/`dist` copies.
- `npm run build` passed. Vite emitted only the pre-existing large-chunk advisory.

## Preserved Findings

The third pass did not broaden scope into either existing artifact backlog:

- 15 orphan scripts still have no current `cards.json`, ID-map, or DB record: `210711859`, `210714859`, `212352495`, `222525492`, `224855909`, `225055909`, `232886050`, `234351716`, `240325495`, `243501716`, `248509042`, `250325492`, `251235492`, `254351716`, and `258832942`.
- The prior DB scan's 180 blank `aux.Stringid` uses across 71 active older scripts remain separate UI/message debt. No DB wording was invented in this pass.

## Remaining Live-Duel and Ruling Checks

1. Test `Priestess of Nephthys` with each eligible official/custom Nephthys monster, because `CheckActivateEffect` selection is card-pool sensitive.
2. Confirm the eight corrected effect-negators against Normal, Continuous, Field, Equip, and monster effects to verify activation placement and downstream clauses in Omega.
3. Confirm `Eldora, the Intergalactic Empire` allows declining its Set follow-up after the destruction resolves.
4. Retain the prior checks for `Devotee of Fire`, copied activations, `Grayrover` hand Extra Link Material, `Urphiel's Feather Downpour`, and the second-pass Necrovalley/Grayscale fixes.

## Official Pattern References

- Effect negation and legality: `c100201001.lua`, `c100235002.lua`, `c100245021.lua`, `c100250201.lua`, and `c101304084.lua`.
- Copied effect/activation forwarding: `c23153227.lua`, `c43331750.lua`, `c70369116.lua`, and `c97769122.lua`.
- Existing local correct effect-negation patterns used as cross-checks: `c214552846.lua`, `c222676270.lua`, and `c259290896.lua`.

## Third-Pass Changed IDs

`211964444`, `213530841`, `214552846`, `220305422`, `233499093`, `234296128`, `249629457`, `249805098`, `252552954`, `259235389`, `259366281`, `259494236`, `259873115`.

# CCG Manual-Input Cases - Reported and Skipped

This report implements the audit instruction to record any case requiring manual input and skip it instead of blocking the remaining card review.

## Outcome

- Active CCG cards covered by the hash-pinned effect ledger: **620**
- Current card reviews: **609**
- Objectively reviewed as pass/fixed: **585**
- Skipped with a remaining ruling or engine limitation: **35**
- Additional fixed-card regression scenarios retained: **79**
- Total interactive/manual scenarios documented: **97**
- Reconciliation errors: **1**

`Skipped` means no speculative text or Lua change was made. The current implementation remains pinned by text and script hashes, and the exact unresolved question stays in the queue below.

## Remaining design or engine decisions

These cards cannot be promoted to a fully proven effect-logic pass without the listed ruling or interactive Omega evidence.

| Ord. | Card | Static verdict | Workstream | Reason requiring manual input |
|---:|---|---|---|---|
| 3 | The Condescender (`221321849`) | UNSUPPORTED | Summon, material, and selection UI | summon procedure; Level and Rank reduction; Link Rating reduction unsupported. |
| 13 | Abstain from Light (`232449539`) | MANUAL_RULING | Ownership and opponent-resource use | opponent-Deck Fusion materials; shuffled-card tracker; delayed return [implemented]. |
| 26 | Talismandrake Arms United (`215034223`) | UNSUPPORTED | Fresh official-reference audit (static decision) | Equipping Blaze Shield 'as if equipped by that card's effect' inherits its optional all-destination leave-field replacement. Omega only provides destroy/send replacement hooks, so return-to-hand, return-to-Deck, and banish departures are not replaced. Resolution: narrow Blaze Shield to destruction/sending, or add a generic optional leave-field replacement hook and use it in the recreated equip effects in c215034223.lua. |
| 30 | Left Talismandrake Arms - Blaze Shield (`255832330`) | UNSUPPORTED | Fresh official-reference audit (static decision) | Omega has optional EFFECT_DESTROY_REPLACE and EFFECT_SEND_REPLACE hooks, but no optional replacement covering every return, banish, destroy, and send way the equipped monster can leave by an opponent's effect. Resolution: change the text to the supported destinations (for example, 'destroyed or sent to the GY'), or add a generic optional leave-field replacement hook and replace both partial hooks in c255832330.lua. |
| 32 | Talismandrake Cremation (`253552927`) | UNSUPPORTED | Fresh official-reference audit (static decision) | The copied Blaze Shield behavior is incomplete for return-to-hand, return-to-Deck, and banish departures because Omega has no generic optional all-destination leave-field replacement hook. Resolution: narrow Blaze Shield's text, or add a generic optional leave-field replacement hook and use it in c253552927.lua's recreated Shield effects. |
| 33 | Talismandrake Enkindle (`241706191`) | UNSUPPORTED | Fresh official-reference audit (static decision) | The copied Blaze Shield behavior is incomplete for return-to-hand, return-to-Deck, and banish departures because Omega has no generic optional all-destination leave-field replacement hook. Resolution: narrow Blaze Shield's text, or add a generic optional leave-field replacement hook and use it in c241706191.lua's recreated Shield effects. |
| 34 | Maiden of Talismandrakes Seraphina (`218142234`) | UNSUPPORTED | Fresh official-reference audit (static decision) | If this effect equips Blaze Shield, its recreated optional leave-field replacement cannot cover return-to-hand, return-to-Deck, or banish departures with current Omega hooks. Resolution: narrow Blaze Shield's text, or add a generic optional leave-field replacement hook and use it in c218142234.lua's recreated Shield effects. \| If this effect equips Blaze Shield, its recreated optional leave-field replacement cannot cover return-to-hand, return-to-Deck, or banish departures with current Omega hooks. Resolution: narrow Blaze Shield's text, or add a generic optional leave-field replacement hook and use it in c218142234.lua's recreated Shield effects. |
| 56 | The Hanging Frute (`213266433`) | UNSUPPORTED | Other custom engine behavior | attack-all approximation; temporary protection [manual]. |
| 87 | Ursarctic Hextanius (`244921711`) | UNSUPPORTED | Summon, material, and selection UI | non-Synchro procedure; Deck summon; shuffle-draw with hidden banishment excluded [fixed]. |
| 100 | A Stainless Story (`245970073`) | UNSUPPORTED | Ownership and opponent-resource use | copy pool. |
| 111 | Takama No Hara (`229996802`) | UNSUPPORTED | Fresh official-reference audit (static decision) | EFFECT_CANNOT_TO_HAND is reason-agnostic, so the current Lua also blocks returning the target as a cost. Master Rule Omega has no EFFECT_CANNOT_TO_HAND_EFFECT equivalent that limits the prohibition to card effects. Resolution: remove 'by card effect' from the text, or add an effect-only hand-return prohibition to the engine and use it in c229996802.lua. |
| 113 | Otakemaru the Accuser (`221855414`) | UNSUPPORTED | Timing, delayed state, and reset behavior | paired summon UI. |
| 116 | Serene Mermaid of the Grand Blue (`259369909`) | UNSUPPORTED | Summon, material, and selection UI | hand summon; Fusion Summon; post-Fusion Extra Deck restriction approximated. |
| 126 | Priestess of Nephthys (`211964444`) | MANUAL_RULING | Timing, delayed state, and reset behavior | copied Standby effect pool. |
| 135 | To Proto Chrono (`244013196`) | MANUAL_RULING | Fresh official-reference audit (static decision) | Omega stores some Card TurnCounter values but has no enumerable 'turn count' for every active effect or reset duration. The phrase 'all effects' turn count' also does not define which players, cards, locations, counters, or durations are included. Resolution: define the exact counters/effects and locations to advance, or replace the clause with a supported operation such as Pyro Clock of Destiny's global turn-count advance. |
| 139 | To Proto Psychi (`217332244`) | UNSUPPORTED | Damage and stat-layer behavior | 100-LP increment UI. |
| 141 | Polemistis gia Ataxia (`254065048`) | UNSUPPORTED | Fresh official-reference audit (static decision) | Omega has no event reporting historical ATK/DEF loss. The text also omits whether gains accumulate, disappear when the losing monster leaves, or continuously track current deficits; the Lua currently models live deficits from base values. Resolution: state the duration and whether the gain is event-based or continuously recalculated. Then implement that ruling, adding an ATK/DEF-loss event to the engine if historical loss must be tracked. |
| 146 | Stellaer of the Gems (`225106953`) | MANUAL_RULING | Fresh official-reference audit (static decision) | The text targets any two cards you control, but Spell/Trap Cards and many monsters cannot have a Level. Literal resolution is undefined for those legal printed targets; the Lua restricts selection to two face-up monsters with Levels. Resolution: change the target to '2 face-up monsters you control with Levels' (or specify how non-Level cards behave), then align c225106953.lua to that ruling. |
| 165 | Eldora, the Intergalactic Empire (`214552846`) | UNSUPPORTED | Copied, rewritten, and resolving effects | 12 source typo / operation-info inference. |
| 167 | Frozen Girl & Blood Moon (`222676270`) | UNSUPPORTED | Copied, rewritten, and resolving effects | classifier false-positive/negative testing. |
| 223 | Revelation of Crying Chaos (`234296128`) | UNSUPPORTED | Fresh official-reference audit (static decision) | Omega can inspect declared operation-info categories and chain targets, but arbitrary Lua operations need not declare either, so the engine cannot determine every effect that would make a controlled card leave the field. Exact resolution requires an engine API exposing the resolving operation's affected cards/destinations, or card text restricted to declared targets and enumerated leave-field categories. |
| 237 | Windborne Eye of the Storm (`256110263`) | UNSUPPORTED | Summon, material, and selection UI | The script uses a temporary synthetic Token material to emulate "treated as a Synchro Summon using only Windborne"; this bespoke engine workaround needs live validation. |
| 258 | The One Called Forth (`226827770`) | UNSUPPORTED | Fresh official-reference audit (static decision) | Omega exposes effect categories, listed card codes, handlers, and current targets, but cannot introspect every future monster choice made inside an arbitrary Lua operation. Exact resolution requires engine operation introspection for possible Summoned codes, or wording limited to effects that target/list the declared monster or another mechanically enumerable pool. |
| 272 | Aquila, Zephorion's Predictor (`259366507`) | MANUAL_RULING | Fresh official-reference audit (static decision) | The quoted conjunction names no card in the current 577-card database: no Spell/Trap contains both 'Verse IX' and 'Chapter II'. Exact resolution requires adding/naming the intended card (for example Chapter II Verse IX) or correcting the printed quoted name; until then only the unambiguous Eldora branch can be implemented. |
| 276 | Chapter Ii Verse Iv (`241957394`) | UNSUPPORTED | Copied, rewritten, and resolving effects | Corrected rewritten chain target to the Effect Monster actually chosen and rewrote sequencing to destroy other matching monsters first, then the chosen monster only on success; retroactive Token-tribute/cost semantics still require an Omega duel test. |
| 373 | Myutant Amalgamate (`211699737`) | MANUAL_RULING | Copied, rewritten, and resolving effects | "This effect becomes that monster's original effect" is approximated with CopyEffect and needs a ruling. |
| 403 | Ghostrick Cutifer (`228472690`) | UNSUPPORTED | Fresh official-reference audit (static decision) | Only Xyz Monsters can legally hold Xyz Materials, while the printed target is any other Ghostrick monster. The current Xyz-only restriction is executable but narrower than the text. Exact resolution requires changing the target to 'Ghostrick Xyz Monster' or adding unsupported engine/card-rule semantics that allow non-Xyz monsters to hold materials. |
| 404 | Ghostrick Oni (`239335848`) | UNSUPPORTED | Summon, material, and selection UI | Custom Xyz material transfer/Quick conversion. |
| 434 | Gravinity Nebulix (`212429024`) | UNSUPPORTED | Fresh official-reference audit (static decision) | The Lua waits for EVENT_CHAIN_SOLVED and performs a second operation after the original chain link has resolved. Omega exposes no general API for injecting arbitrary text into another resolving effect, so this is only an approximation of adding the bullet at resolution. |
| 435 | Gravinity Spherix (`231088629`) | UNSUPPORTED | Summon, material, and selection UI | Summon replacement plus minimum GY Xyz material. |
| 438 | Gravinity Axis Matter (`256831125`) | UNSUPPORTED | Copied, rewritten, and resolving effects | Copied-effect scope and printed Link Rating reduction are not exact. |
| 439 | Gravinity Sonic Scream (`238184015`) | UNSUPPORTED | Other custom engine behavior | Copied activated-effect semantics. |
| 539 | Glitchling Corruption (`259546637`) | UNSUPPORTED | Fresh official-reference audit (static decision) | Genuine engine limitation: Omega has no card-local, generic hook that adds a counter-derived scalar to all Cyberse Ritual Summon material checks and atomically removes the chosen counters. Monkey-patching shared Ritual helpers would miss bespoke Ritual scripts and affect unrelated cards globally. |
| 540 | Glitchling Hexatron (`259253032`) | MANUAL_RULING | Fresh official-reference audit (static decision) | Genuine source-text ambiguity: this Link-3 monster has no printed Link Material line. The current 2-3 Cyberse implementation is executable, but text, helpers, official scripts, and DB contain no evidence that distinguishes it from exactly 3 Cyberse, 2+ Effect Monsters, or an archetype requirement. |
| 556 | Wyvernal Myops (`259431066`) | MANUAL_RULING | Fresh official-reference audit (static decision) | Ruling/text limitation: 'target 1 card your opponent controls' permits a face-down Monster or Set Spell/Trap by its written target criteria, but the text never states what 'negate its effects' must do while that card is face-down. Omega's official persistent-negation helpers and analogues only define face-up, disableable targets. Resolution needed: either errata the target to '1 face-up card your opponent controls' (the current safe behavior), or provide an authoritative ruling for face-down targets, after which distg/disop can be changed to that exact behavior. No unsupported face-down lingering negation was invented. |

## Exact unsupported or ambiguous clauses

### The Condescender (`221321849`)

- **UNSUPPORTED — (Quick Effect): You can send this card from your hand to the GY, then target 1 face-up monster on the field; declare a number from 1 to 3, then reduce that monster's Level, Rank, or Link Rating by the declared number until the end of the next turn.**
  - Current implementation: The hand Quick Effect pays by sending this card to the GY, targets a face-up Level/Rank monster, announces 1-3, and applies matching negative UPDATE_LEVEL/UPDATE_RANK effects through the next End Phase. Adversarial re-review confirmed this remains non-exact. Adversarial re-review confirmed this remains non-exact.
  - Why skipped: Omega exposes EFFECT_UPDATE_LEVEL and EFFECT_UPDATE_RANK but no effect code that changes a Link Rating. The Lua therefore cannot offer or resolve the printed Link Rating branch. Resolution: either change the card text to 'Level or Rank', or add an engine-supported Link Rating change API and then add the Link branch to c221321849.lua.
- **UNSUPPORTED — If a monster whose Level, Rank, or Link Rating is lower than its original value is on the field: You can Special Summon this card from your GY, but banish it when it leaves the field.**
  - Current implementation: The GY Ignition Effect detects a face-up monster whose current Level or Rank is below its original value, then Special Summons this card and installs a banish leave-field redirect. Adversarial re-review confirmed this remains non-exact. Adversarial re-review confirmed this remains non-exact.
  - Why skipped: Omega exposes original/current Level and Rank comparisons but no mutable/current Link Rating counterpart. The Lua therefore cannot detect the printed reduced-Link-Rating state. Resolution: either remove 'Link Rating' from this condition, or add engine APIs for changing and comparing Link Rating and then extend c221321849.lua.

### Abstain from Light (`232449539`)

- **MANUAL_RULING — If your "Stain" monster was shuffled into either Deck this turn, you can also banish "Stain" monsters from face-up in your opponent's Deck as material, but return them to the GY during the End Phase.**
  - Current implementation: A global EVENT_MOVE approximation flags Stain monsters moved from outside a Deck into a Deck by effect, enabling face-up opponent-Deck Stain monsters as Fusion material and scheduling used cards to return to the GY in the End Phase. Adversarial re-review confirmed this remains non-exact. Adversarial re-review confirmed this remains non-exact.
  - Why skipped: EVENT_MOVE does not identify whether movement into a Deck was a shuffle, and it cannot reliably cover cost-based or rule-based shuffles. The current REASON_EFFECT tracker is only an approximation. Resolution: rewrite the condition as 'If your Stain monster was moved into a Deck by a card effect this turn', or add a core shuffle event/reason and use it in c232449539.lua.

### Talismandrake Arms United (`215034223`)

- **UNSUPPORTED — If a Pyro Fusion Monster is Special Summoned to your field (except during the Damage Step): You can banish this card from your GY, then target 1 of those monsters; equip 1 "Talismandrake Arms" Spell/Trap from your Deck to it as if it were equipped by that Spell/Trap's effect.**
  - Current implementation: The trigger equips one of the four supported Arms cards and recreates its equip effects. Sabre/Shield values now count only Equip Spells whose equip target is controlled by the equipped monster's controller; battle replacement is implemented, and Shield approximates leave-field replacement with destroy/send replacements. Adversarial re-review confirmed this remains non-exact. Adversarial re-review confirmed this remains non-exact.
  - Why skipped: Equipping Blaze Shield 'as if equipped by that card's effect' inherits its optional all-destination leave-field replacement. Omega only provides destroy/send replacement hooks, so return-to-hand, return-to-Deck, and banish departures are not replaced. Resolution: narrow Blaze Shield to destruction/sending, or add a generic optional leave-field replacement hook and use it in the recreated equip effects in c215034223.lua.

### Left Talismandrake Arms - Blaze Shield (`255832330`)

- **UNSUPPORTED — ● The equipped monster gains 500 DEF for each Equip Spell equipped to a monster you control, also, if it would leave the field by your opponent's card effect, you can destroy this card instead.**
  - Current implementation: The equipped monster's DEF count now includes only Equip Spells attached to monsters its controller controls. Opponent-effect destroy/send departures can be replaced by destroying this card. Adversarial re-review confirmed this remains non-exact. Adversarial re-review confirmed this remains non-exact.
  - Why skipped: Omega has optional EFFECT_DESTROY_REPLACE and EFFECT_SEND_REPLACE hooks, but no optional replacement covering every return, banish, destroy, and send way the equipped monster can leave by an opponent's effect. Resolution: change the text to the supported destinations (for example, 'destroyed or sent to the GY'), or add a generic optional leave-field replacement hook and replace both partial hooks in c255832330.lua.

### Talismandrake Cremation (`253552927`)

- **UNSUPPORTED — If this card is Special Summoned: You can add 1 "Talismandrake Arms" Spell/Trap from your Deck or GY to your hand, or equip it to a DARK Pyro monster you control as if it were equipped by that Spell/Trap's effect.**
  - Current implementation: The add/equip branch recreates the selected Arms card's effects; copied Sabre/Shield values now count only Equip Spells attached to controlled monsters, while Shield uses the available destroy/send replacement hooks. Adversarial re-review confirmed this remains non-exact. Adversarial re-review confirmed this remains non-exact.
  - Why skipped: The copied Blaze Shield behavior is incomplete for return-to-hand, return-to-Deck, and banish departures because Omega has no generic optional all-destination leave-field replacement hook. Resolution: narrow Blaze Shield's text, or add a generic optional leave-field replacement hook and use it in c253552927.lua's recreated Shield effects.

### Talismandrake Enkindle (`241706191`)

- **UNSUPPORTED — If this card is Special Summoned: You can add 1 "Talismandrake Arms" Spell/Trap from your Deck or GY to your hand, or equip it to a DARK Pyro monster you control as if it were equipped by that Spell/Trap's effect.**
  - Current implementation: The add/equip branch recreates the selected Arms card's effects; copied Sabre/Shield values now count only Equip Spells attached to controlled monsters, while Shield uses available destroy/send replacement hooks. Adversarial re-review confirmed this remains non-exact. Adversarial re-review confirmed this remains non-exact.
  - Why skipped: The copied Blaze Shield behavior is incomplete for return-to-hand, return-to-Deck, and banish departures because Omega has no generic optional all-destination leave-field replacement hook. Resolution: narrow Blaze Shield's text, or add a generic optional leave-field replacement hook and use it in c241706191.lua's recreated Shield effects.

### Maiden of Talismandrakes Seraphina (`218142234`)

- **UNSUPPORTED — Pendulum Effect: You can shuffle 3 "Talismandrake" monsters with different names from your face-up Extra Deck, field, and/or GY into the Deck; Special Summon this card from your Pendulum Zone, then you can equip 1 "Talismandrake Arms" Spell/Trap from your GY to this card as if it was equipped by that Spell/Trap's effect.**
  - Current implementation: The Pendulum effect shuffles three differently named Talismandrakes as cost, Special Summons Seraphina, and optionally equips an Arms card with recreated effects whose Equip counts are now controller-correct. Adversarial re-review confirmed this remains non-exact. Adversarial re-review confirmed this remains non-exact.
  - Why skipped: If this effect equips Blaze Shield, its recreated optional leave-field replacement cannot cover return-to-hand, return-to-Deck, or banish departures with current Omega hooks. Resolution: narrow Blaze Shield's text, or add a generic optional leave-field replacement hook and use it in c218142234.lua's recreated Shield effects.
- **UNSUPPORTED — If this card is Fusion Summoned, or if your opponent activates a card or effect: You can target 1 "Talismandrake Arms" Spell/Trap in your GY; add it to your hand or equip it to this card as if it were equipped by that Spell/Trap's effect.**
  - Current implementation: The Fusion-Summon/opponent-activation branches target an Arms card in the GY and add or equip it; recreated Equip values are controller-correct and Shield uses available destroy/send replacement hooks. Adversarial re-review confirmed this remains non-exact. Adversarial re-review confirmed this remains non-exact.
  - Why skipped: If this effect equips Blaze Shield, its recreated optional leave-field replacement cannot cover return-to-hand, return-to-Deck, or banish departures with current Omega hooks. Resolution: narrow Blaze Shield's text, or add a generic optional leave-field replacement hook and use it in c218142234.lua's recreated Shield effects.

### The Hanging Frute (`213266433`)

- **UNSUPPORTED — "Frute" monsters you control can attack all face-down Defense Position monsters your opponent controls, once each.**
  - Current implementation: The Lua directly implements granting every Frute one attack on each face-down Defense monster only using custom location/filter/event handling; that bespoke component remains unmatched. Adversarial re-review confirmed this remains non-exact. Adversarial re-review confirmed this remains non-exact.
  - Why skipped: The text does not resolve whether each Frute retains one ordinary attack against a non-qualifying monster in addition to attacks on every face-down Defense Position monster. The current first-attack tracker also cannot preserve exact once-each identity if a battled monster changes position and is Set again. Resolution: issue a ruling for the ordinary-attack interaction and change the text to match it; then replace c213266433.lua's approximation with a ruling-specific attack procedure (or add filtered attack-all bookkeeping to the engine).

### Ursarctic Hextanius (`244921711`)

- **UNSUPPORTED — For the Special Summon of any Ursarctic Synchro, this card can be Level 7 or 8 and a non-Tuner.**
  - Current implementation: The alternate Level/non-Tuner values are consumed by the three CCG Ursarctic procedures that explicitly call Hextanius-aware helpers; the card cannot inject those choices into unrelated official Extra Deck procedures. Adversarial re-review confirmed this remains non-exact. Adversarial re-review confirmed this remains non-exact.
  - Why skipped: Official Ursarctic Extra Deck monsters use bespoke non-Synchro EFFECT_SPSUMMON_PROC scripts that read card Levels directly and expose no material-side hook for Hextanius to become Level 7/8 and a non-Tuner. Only the CCG procedures that explicitly call Hextanius-aware helpers can honor the text. Resolution: update every Ursarctic summon procedure that must recognize Hextanius (including official scripts), or revise the text to limit the substitution to named CCG Ursarctic monsters.

### A Stainless Story (`245970073`)

- **UNSUPPORTED — This effect becomes that monster’s effect if it is Normal or Special Summoned.**
  - Current implementation: The five currently eligible Main Deck Stain summon effects are manually mirrored; no dynamic monster-trigger object is invoked from the sent card. Adversarial re-review confirmed this remains non-exact. Adversarial re-review confirmed this remains non-exact.
  - Why skipped: CheckActivateEffect can reproduce activatable Spell/Trap effects, but Omega has no generic API that selects and rebinds an arbitrary monster's Normal/Special Summon trigger, event group, targets, labels, and operation. The Lua manually mirrors only the currently listed Stain monsters. Resolution: enumerate the supported monster names in the printed text and maintain the manual map, or add a core trigger-copy API and replace the hard-coded branches in c245970073.lua.

### Takama No Hara (`229996802`)

- **UNSUPPORTED — Banish this from GY, target a Spirit you control; it cannot return to hand by card effect until End Phase.**
  - Current implementation: The selected face-up Spirit receives EFFECT_CANNOT_TO_HAND through the End Phase; this enforces the destination but the core prohibition is reason-agnostic. Adversarial re-review confirmed this remains non-exact. Adversarial re-review confirmed this remains non-exact.
  - Why skipped: EFFECT_CANNOT_TO_HAND is reason-agnostic, so the current Lua also blocks returning the target as a cost. Master Rule Omega has no EFFECT_CANNOT_TO_HAND_EFFECT equivalent that limits the prohibition to card effects. Resolution: remove 'by card effect' from the text, or add an effect-only hand-return prohibition to the engine and use it in c229996802.lua.

### Otakemaru the Accuser (`221855414`)

- **UNSUPPORTED — If Special Summoned: other Spirit monsters cannot return to hand or Extra Deck by card effect during this turn’s End Phase.**
  - Current implementation: The Special Summon trigger installs End-Phase-only CANNOT_TO_HAND/CANNOT_TO_DECK effects for other face-up Spirit monsters; those destination effects also apply to costs and non-effect movement. Adversarial re-review confirmed this remains non-exact. Adversarial re-review confirmed this remains non-exact.
  - Why skipped: EFFECT_CANNOT_TO_HAND and EFFECT_CANNOT_TO_DECK are reason-agnostic, so the current Lua also blocks costs and other non-effect movement during the End Phase. EFFECT_SPIRIT_DONOT_RETURN would cover only the built-in Spirit return and not arbitrary card effects. Resolution: remove 'by card effect', narrow the text to built-in Spirit returns, or add effect-only hand/Extra-Deck return prohibitions and use them in c221855414.lua.

### Serene Mermaid of the Grand Blue (`259369909`)

- **UNSUPPORTED — After the Fusion Summon, for the rest of the turn you may only Special Summon from Extra Deck using Grand Blue monsters as materials.**
  - Current implementation: Four material prohibitions prevent non-Grand-Blue cards from being used as Fusion, Synchro, Xyz, or Link Material for the rest of the turn, but materialless Extra Deck procedures are not represented by those hooks. Adversarial re-review confirmed this remains non-exact. Adversarial re-review confirmed this remains non-exact.
  - Why skipped: Omega's prospective Extra Deck Special Summon restriction callback does not expose the material group. The Lua instead prohibits non-Grand Blue cards from being Fusion, Synchro, Xyz, or Link Material, which does not reject materialless or nonstandard Extra Deck procedures. Resolution: rewrite the restriction as four material prohibitions matching the Lua, or add a summon-limit API that receives the prospective material group and replace the approximation in c259369909.lua.

### Priestess of Nephthys (`211964444`)

- **MANUAL_RULING — Then apply that destroyed card’s Standby Phase-activated effect.**
  - Current implementation: After the selected Deck monster is destroyed, CheckActivateEffect(true,true,true) obtains an effect and directly invokes its target and operation outside the original Standby Phase event. Adversarial re-review confirmed this remains non-exact. Adversarial re-review confirmed this remains non-exact.
  - Why skipped: 'That destroyed card's Standby Phase-activated effect' does not identify which effect to apply when the monster has multiple Standby Phase triggers. Omega also has no API for invoking one arbitrary trigger outside its event while preserving its event data and targeting semantics. Resolution: identify the intended effect by exact text/index or restrict the eligible monsters to an enumerated list, then script those operations; otherwise add a core trigger-invocation API.

### To Proto Chrono (`244013196`)

- **MANUAL_RULING — If the gain occurs, increase all effects’ turn count by 1.**
  - Current implementation: The operation increments Card TurnCounter values on cards in accessible locations, which covers conventional card-maintained turn counters but cannot enumerate or advance arbitrary effect-local reset durations. Adversarial re-review confirmed this remains non-exact. Adversarial re-review confirmed this remains non-exact.
  - Why skipped: Omega stores some Card TurnCounter values but has no enumerable 'turn count' for every active effect or reset duration. The phrase 'all effects' turn count' also does not define which players, cards, locations, counters, or durations are included. Resolution: define the exact counters/effects and locations to advance, or replace the clause with a supported operation such as Pyro Clock of Destiny's global turn-count advance.

### To Proto Psychi (`217332244`)

- **UNSUPPORTED — Quick Effect: Tribute a Token, then pay any amount of LP.**
  - Current implementation: The cost offers LP payments in 100-point increments plus LP minus 1, then applies the chosen payment as permanent ATK/DEF gain. Adversarial re-review confirmed this remains non-exact. Adversarial re-review confirmed this remains non-exact.
  - Why skipped: The finite AnnounceNumber UI accepts an explicit option list and has no unrestricted integer-entry prompt. Enumerating every integer from 1 to LP-1 is not a supported/practical Omega selection, so the Lua currently offers 100-LP increments plus LP-1. Resolution: change 'any amount' to 'any amount in multiples of 100 (or all but 1 LP)', or add an integer-range prompt to Omega and use it in c217332244.lua.

### Polemistis gia Ataxia (`254065048`)

- **UNSUPPORTED — If monster(s) loses ATK/DEF, this card gains ATK/DEF equal to amount lost.**
  - Current implementation: Continuous UPDATE_ATTACK and UPDATE_DEFENSE values sum each current face-up monster's deficit from GetBaseAttack/GetBaseDefense. Adversarial re-review confirmed this remains non-exact. Adversarial re-review confirmed this remains non-exact.
  - Why skipped: Omega has no event reporting historical ATK/DEF loss. The text also omits whether gains accumulate, disappear when the losing monster leaves, or continuously track current deficits; the Lua currently models live deficits from base values. Resolution: state the duration and whether the gain is event-based or continuously recalculated. Then implement that ruling, adding an ATK/DEF-loss event to the engine if historical loss must be tracked.

### Stellaer of the Gems (`225106953`)

- **MANUAL_RULING — If detached from a Stellaer Xyz to activate its effect: target 2 cards you control, declare Level 8-10; they become that Level until end of turn. HOPT.**
  - Current implementation: The detach timing is corrected with GLOBALFLAG_DETACH_EVENT and EVENT_DETACH_MATERIAL. The targeting code still requires two face-up monsters with positive Levels, announces 8-10, and applies temporary EFFECT_CHANGE_LEVEL. Adversarial re-review confirmed this remains non-exact. Adversarial re-review confirmed this remains non-exact.
  - Why skipped: The text targets any two cards you control, but Spell/Trap Cards and many monsters cannot have a Level. Literal resolution is undefined for those legal printed targets; the Lua restricts selection to two face-up monsters with Levels. Resolution: change the target to '2 face-up monsters you control with Levels' (or specify how non-Level cards behave), then align c225106953.lua to that ruling.

### Eldora, the Intergalactic Empire (`214552846`)

- **UNSUPPORTED — When an opponent effect that would destroy two or more monsters you control resolves, destroy this card, then negate that effect.**
  - Current implementation: Field-zone Quick Effect responds at EVENT_CHAINING, infers two-or-more own Monster destruction from chain operation metadata, destroys itself at resolution, then calls NegateEffect if destruction succeeded. Adversarial re-review confirmed this remains non-exact. Adversarial re-review confirmed this remains non-exact.
  - Why skipped: The printed trigger says 'when ... resolves', but chains cannot be started during another effect's resolution. The Lua necessarily responds at activation and predicts destruction from CATEGORY_DESTROY metadata, which cannot identify effects whose victims/count are chosen only while resolving. Resolution: rewrite this as 'When your opponent activates a card or effect that would destroy 2 or more monsters you control' and accept category-based prediction, or define a new engine replacement/interception event before destruction resolves.

### Frozen Girl & Blood Moon (`222676270`)

- **UNSUPPORTED — When an effect includes face-up placement from hand/Deck/GY, placing monsters in SZONE, or Setting from hand/Deck/GY: discard this card; negate that effect. HOPT.**
  - Current implementation: Ash-style hand Quick Effect checks custom CCG Set markers, CATEGORY_SET when available, CATEGORY_EQUIP, or any CATEGORY_LEAVE_GRAVE operation; discards as cost and NegateEffect; HOPT. Adversarial re-review confirmed this remains non-exact. Adversarial re-review confirmed this remains non-exact.
  - Why skipped: Omega has no universal categories for face-up Spell/Trap placement, placing Monster Cards in the Spell & Trap Zone, or every Set from hand/Deck/GY. CATEGORY_LEAVE_GRAVE is overbroad, while custom markers only cover scripts that opt in. Resolution: narrow the three bullets to engine-detectable categories, require all relevant scripts to publish dedicated placement/Set markers, or add core operation categories and update c222676270.lua to use them.

### Revelation of Crying Chaos (`234296128`)

- **UNSUPPORTED — When your opponent activates a card or effect that would make a card you control leave the field (Quick Effect): You can Tribute 1 "Crying Chaos" monster you control; Negate that effect, and if you do, this card gains ATK equal to the Tributed monster's combined ATK and DEF until the end of this turn.**
  - Current implementation: negcon recognizes the standard leave-field operation-info categories; negcost Tributes a Crying Chaos monster and stores its current GetAttack()+GetDefense(); negop negates and applies that value through the End Phase.
  - Why skipped: Omega can inspect declared operation-info categories and chain targets, but arbitrary Lua operations need not declare either, so the engine cannot determine every effect that would make a controlled card leave the field. Exact resolution requires an engine API exposing the resolving operation's affected cards/destinations, or card text restricted to declared targets and enumerated leave-field categories.

### Windborne Eye of the Storm (`256110263`)

- **UNSUPPORTED — Target 1 monster you control; banish it until the End Phase, then, if you added 3 or more "Windborne" cards from your Deck to your hand this turn, and you banished a WIND Synchro Monster by this effect, you can Special Summon 1 "Windborne" Synchro Monster with a different name from your Extra Deck (this is treated as a Synchro Summon using only "Windborne" monsters).**
  - Current implementation: The script checks the global add counter and removed card, Special Summons with SUMMON_TYPE_SYNCHRO, calls CompleteProcedure, and fabricates a one-card material group containing a created Janna token so later material checks see a Windborne card.
  - Why skipped: Omega can mark a Special Summon as a Synchro Summon and store real material cards, but cannot create truthful material history saying an otherwise material-less Summon used only Windborne monsters. The fabricated Janna token gives false card identity. Exact resolution requires engine-supported virtual material metadata (at least archetype/type without a fake card), or revised text that removes the material-history clause or names real materials.

### The One Called Forth (`226827770`)

- **UNSUPPORTED — At the start of your Main Phase 1: Declare the name of 1 monster you do not control; for the rest of this turn, the activation of your cards and effects that include an effect that Summons a monster with that name cannot be negated, also your opponent cannot activate cards or effects when that monster is Summoned.**
  - Current implementation: EFFECT_CANNOT_INACTIVATE and EFFECT_CANNOT_DISEFFECT use efilter, which recognizes summon categories plus handler/listed code or current target cards, and reset at PHASE_END.
  - Why skipped: Omega exposes effect categories, listed card codes, handlers, and current targets, but cannot introspect every future monster choice made inside an arbitrary Lua operation. Exact resolution requires engine operation introspection for possible Summoned codes, or wording limited to effects that target/list the declared monster or another mechanically enumerable pool.

### Aquila, Zephorion's Predictor (`259366507`)

- **MANUAL_RULING — If this card is Summoned: You can Set 1 "Eldora" and/or "Verse IX" "Chapter II" Spell/Trap directly from your Deck or GY.**
  - Current implementation: The Summon triggers now Set an Eldora Spell/Trap from Deck/GY and no longer falsely include Chapter II Verse IV. The current 577-card catalog contains no card whose name matches both quoted fragments 'Verse IX' and 'Chapter II'.
  - Why skipped: The quoted conjunction names no card in the current 577-card database: no Spell/Trap contains both 'Verse IX' and 'Chapter II'. Exact resolution requires adding/naming the intended card (for example Chapter II Verse IX) or correcting the printed quoted name; until then only the unambiguous Eldora branch can be implemented.

### Chapter Ii Verse Iv (`241957394`)

- **UNSUPPORTED — When your opponent activates a card effect: You can show 1 "Dysmandr, the Depraevity of Worlds" in your Extra Deck and choose 1 Effect Monster you control; Send 1 "Extinction of Dysmandr" from your Deck to the GY (but shuffle it into the Deck during the End Phase), and if you do, your opponent's activated card effect becomes the sent card's effect that Tributes a "Protogenic Essence Token" to activate.**
  - Current implementation: After the send, ChangeTargetCard changes the original chain target and ChangeChainOperation installs repop. repop asks the original activating player to release a Token during resolution, snapshots the chosen monster, destroys other matching Effect Monsters, then the chosen one.
  - Why skipped: ChangeChainOperation can replace a resolving operation, but it cannot retroactively apply another card's activation condition or Tribute cost after the Chain Link was activated. The current Token release therefore occurs during resolution as REASON_EFFECT and cannot exactly become the copied activation procedure. Exact resolution requires revised text that copies only Extinction's resolving operation (and explicitly places any Token release at resolution), or a source effect whose activation legality/cost is checked before this Chain Link is created.

### Myutant Amalgamate (`211699737`)

- **MANUAL_RULING — And if you do, this effect becomes that monster's original effect.**
  - Current implementation: After banishing the corresponding Myutant monster, the handler uses CopyEffect with a standard state-change reset, granting that card's copyable effects rather than replacing and executing only this resolving effect.
  - Why skipped: The text does not identify which of an arbitrary monster's effects is meant or provide that effect's event, activation condition, cost, target, or parameters. CopyEffect grants the card's copyable effects for a duration; it cannot make this already-resolving effect become and execute an unspecified original effect. Exact resolution requires wording that grants copied effects for a stated duration, or selection of one specifically activatable effect with defined cost/target semantics.

### Ghostrick Cutifer (`228472690`)

- **UNSUPPORTED — Once per turn: Target 1 other Ghostrick monster you control; attach this card to it as material. Transfer this card's materials to that monster.**
  - Current implementation: The implementation restricts the other controlled Ghostrick target to a face-up Xyz Monster, transfers this card's materials, then overlays this card onto it.
  - Why skipped: Only Xyz Monsters can legally hold Xyz Materials, while the printed target is any other Ghostrick monster. The current Xyz-only restriction is executable but narrower than the text. Exact resolution requires changing the target to 'Ghostrick Xyz Monster' or adding unsupported engine/card-rule semantics that allow non-Xyz monsters to hold materials.

### Ghostrick Oni (`239335848`)

- **MANUAL_RULING — Then immediately after this effect resolves Xyz Summon 1 Rank 3 or lower Ghostrick monster you control using this card as material (transfer this card's materials).**
  - Current implementation: After attaching a Deck card, the implementation chooses an already-controlled Rank 3 or lower Ghostrick Xyz Monster, transfers Oni's materials, and overlays Oni onto it as the closest executable approximation.
  - Why skipped: An already-controlled monster cannot be Xyz Summoned, so 'Xyz Summon ... monster you control' is internally impossible. Exact resolution requires selecting the Xyz Monster from the Extra Deck and defining its legal materials, or replacing 'Xyz Summon' with an attach/transfer instruction matching the current controlled-monster approximation.
- **UNSUPPORTED — Also, it can activate its effects as Quick Effects this turn.**
  - Current implementation: The selected Xyz Monster is recorded for the turn, but the Lua cannot rewrite all of its arbitrary ignition and trigger registrations into Quick Effects.
  - Why skipped: Omega has no generic runtime API that changes every arbitrary ignition/trigger effect registered on a selected monster into a Quick Effect for one turn; an inert flag cannot do so. Exact resolution requires engine support for temporary effect-type conversion, or revised text granting one specifically scripted Quick Effect.

### Gravinity Nebulix (`212429024`)

- **UNSUPPORTED — When a "Gravinity" Spell/Trap effect resolves, you can also add this additional effect to that card's effect at resolution.**
  - Current implementation: c212429024.lua implements this printed clause with 4 registered Effect.CreateEffect blocks overall; the directly relevant current Lua is: aux.AddSynchroProcedure(c,aux.FilterBoolFunction(Card.IsSetCard,SET_GRAVINITY),aux.NonTuner(s.ntfilter),1) | e0:SetType(EFFECT_TYPE_SINGLE) | e0:SetCode(EFFECT_CANNOT_DISABLE_SPSUMMON) | e1:SetType(EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_O) | e1:SetCode(EVENT_SPSUMMON_SUCCESS) | e1:SetCondition(s.tdcon) | e1:SetTarget(s.tdtg)
  - Why skipped: The Lua waits for EVENT_CHAIN_SOLVED and performs a second operation after the original chain link has resolved. Omega exposes no general API for injecting arbitrary text into another resolving effect, so this is only an approximation of adding the bullet at resolution.

### Gravinity Spherix (`231088629`)

- **UNSUPPORTED — If a player would Normal or Special Summon a monster (except from the Spell & Trap Zone), place that monster face-up in its owner's Spell & Trap Zone as a Continuous Trap instead, and if you do, it gains the following effect (even if this card leaves the field).**
  - Current implementation: c231088629.lua implements this printed clause with 6 registered Effect.CreateEffect blocks overall; the directly relevant current Lua is: aux.AddSynchroProcedure(c,aux.FilterBoolFunction(Card.IsSetCard,SET_GRAVINITY),aux.NonTuner(s.ntfilter),1) | e0:SetCode(EFFECT_CHANGE_TYPE) | e0:SetValue(TYPE_TRAP+TYPE_CONTINUOUS) | e1:SetRange(LOCATION_SZONE) | e1:SetCondition(function(te) return te:GetHandler():IsType(TYPE_TRAP) and Duel.IsMainPhase() end) | --This continuous effect was not active before the handler itself was Summoned. | if not tc:IsPreviousLocation(LOCATION_SZONE) and tc:IsLocation(LOCATION_MZONE) and Duel.GetLocationCount(p,LOCATION_SZONE)>0
  - Why skipped: The Lua reacts to EVENT_SUMMON_SUCCESS/EVENT_SPSUMMON_SUCCESS and moves the already-Summoned monster afterward. This cannot reproduce a true summon replacement: summon-success events and summon-triggered effects have already occurred, and a full Spell/Trap Zone prevents the printed replacement.
- **UNSUPPORTED — ● During the Main Phase, if this card is a Continuous Trap: You can Special Summon this card, ignoring its summoning conditions, then, if this card is an Xyz Monster, you can attach the minimum number of monsters that can be used for this card's Xyz Summon from your GY to this card as material.**
  - Current implementation: After the granted Ignition Effect Special Summons the handler, s.spop gathers Level-equal, overlay-eligible monsters from the controller's GY and overlays exactly two. Omega's Xyz helpers receive their material filter and min/max only inside each Extra Deck card's registered summon-procedure closures; the summoned card exposes no supported API that returns those values.
  - Why skipped: Omega cannot generically recover an arbitrary Xyz Monster's printed minimum material count or material predicate after that card has already been Special Summoned to the field. Card.IsXyzSummonable can test a prospective Extra Deck summon but cannot extract the registered procedure from this already-summoned card. The current two same-Level attachments are therefore only an approximation and are not exact for level-free, variable-count, alternate, or non-Level procedures.

### Gravinity Axis Matter (`256831125`)

- **UNSUPPORTED — Reduce the Level/Rank/Link Rating of your opponent's monsters in the same column as a "Gravinity" monster by 1.**
  - Current implementation: Field effects apply EFFECT_UPDATE_LEVEL and EFFECT_UPDATE_RANK with value -1 to opponent's Monster Zone cards whose columns contain a Gravinity monster in the controller's Monster Zone. No Link Rating effect is registered because Omega defines no update/change-Link constant.
  - Why skipped: Fixed the concrete scope error: a Gravinity Monster Card in the Spell/Trap Zone no longer counts as a Gravinity monster for this clause. The Level and Rank reductions are exact. Link Rating reduction remains unsupported: Omega's constants provide EFFECT_UPDATE_LEVEL/RANK and EFFECT_CHANGE_LEVEL/RANK, but no EFFECT_UPDATE_LINK, EFFECT_CHANGE_LINK, or equivalent setter.
- **MANUAL_RULING — During the Standby Phase: You can reveal 1 Level 11 "Gravinity" Synchro Monster in your Extra Deck; for the rest of this turn, this card gains the non-activated effects of the revealed monster.**
  - Current implementation: The Standby Phase cost reveals a Level 11 Gravinity Synchro and stores its original code. For the complete current pool, copyop explicitly recreates Nebulix's resolution-addition effect or Spherix's summon reaction and Monster-Card counter effect until the End Phase. The Spherix counter condition now requires original Monster Card type.
  - Why skipped: The hard-coded branches cover both Level 11 Gravinity Synchro Monsters currently present and the copied Spherix counter test was corrected to exclude non-Monster Cards. The printed effect is still generic and cannot be implemented generically: Card.CopyEffect copies a card script wholesale, while Omega exposes no supported iterator/copier that selects only non-activated effects and safely rebinds arbitrary monster effects to a Field Spell. A future valid reveal requires a new explicit branch.

### Gravinity Sonic Scream (`238184015`)

- **UNSUPPORTED — If you activate the effect of a "Gravinity" Synchro Monster Card: You can banish this card from your GY; this effect becomes that card's activated effect.**
  - Current implementation: c238184015.lua implements this printed clause with 3 registered Effect.CreateEffect blocks overall; the directly relevant current Lua is: e2:SetRange(LOCATION_GRAVE) | and (not rc:IsLocation(LOCATION_GRAVE) or aux.NecroValleyFilter()(rc))
  - Why skipped: The Lua directly invokes the prior Effect operation with mismatched effect/context arguments. Generic effect replacement/copying is engine-sensitive and this does not reproduce target, cost, label, category, or chain metadata for every possible Gravinity Synchro effect.

### Glitchling Corruption (`259546637`)

- **UNSUPPORTED — If you would Ritual Summon a Cyberse Ritual Monster using hand/field Tributes, Corruption Counters from the field can satisfy up to its Level.**
  - Current implementation: The current Lua can spend counters only inside this card's own triggered Ritual operation. EFFECT_EXTRA_RITUAL_MATERIAL contributes actual Card objects; it cannot contribute a scalar Level amount or remove counters for every unrelated Ritual procedure.
  - Why skipped: Genuine engine limitation: Omega has no card-local, generic hook that adds a counter-derived scalar to all Cyberse Ritual Summon material checks and atomically removes the chosen counters. Monkey-patching shared Ritual helpers would miss bespoke Ritual scripts and affect unrelated cards globally.

### Glitchling Hexatron (`259253032`)

- **MANUAL_RULING — Link Summoning procedure (no material line is present in the current printed text).**
  - Current implementation: AddLinkProcedure requires 2 or 3 Cyberse monsters for this Link-3 monster, followed by EnableReviveLimit; the current printed text still supplies no material line against which that choice can be proven.
  - Why skipped: Genuine source-text ambiguity: this Link-3 monster has no printed Link Material line. The current 2-3 Cyberse implementation is executable, but text, helpers, official scripts, and DB contain no evidence that distinguishes it from exactly 3 Cyberse, 2+ Effect Monsters, or an archetype requirement.

### Wyvernal Myops (`259431066`)

- **MANUAL_RULING — If this card is in your GY, and you control a "Wyvernal" Fusion monster (Quick Effect): You can banish this card from your GY and target 1 card your opponent controls; Negate its effects. You can only use this effect of "Wyvernal Myops" once per turn.**
  - Current implementation: The executable implementation uses Omega's Auxiliary.NegateAnyFilter, whose utility.lua contract is specifically 'negate the effects of a face-up card', and applies EFFECT_DISABLE/EFFECT_DISABLE_EFFECT only while the target remains face-up, related, and disableable. This is the officially supported subset, but it narrows the printed target phrase.
  - Why skipped: Ruling/text limitation: 'target 1 card your opponent controls' permits a face-down Monster or Set Spell/Trap by its written target criteria, but the text never states what 'negate its effects' must do while that card is face-down. Omega's official persistent-negation helpers and analogues only define face-up, disableable targets. Resolution needed: either errata the target to '1 face-up card your opponent controls' (the current safe behavior), or provide an authoritative ruling for face-down targets, after which distg/disop can be changed to that exact behavior. No unsupported face-down lingering negation was invented.

## Full skipped/manual scenario queue

The detailed setup, positive/negative checks, acceptance condition, script hash, and test deck for every row remain in `docs/lua-manual-review-guide-2026-07-20.md` and `scripts/output/omega_manual_test_ledger.json`.

### Copied, rewritten, and resolving effects

| # | Card | Disposition | Static verdict | Manual question | Status |
|---:|---|---|---|---|---:|
| 1 | Stained Silhouette (`256608976`) | REGRESSION_ONLY | FIXED | nonstandard CopyEffect. | pending |
| 2 | Rage of Nephthys (`256287781`) | REGRESSION_ONLY | PASS | quoted pronoun ruling. | pending |
| 3 | Eldora, the Intergalactic Empire (`214552846`) | SKIPPED_MANUAL_INPUT | UNSUPPORTED | 12 source typo / operation-info inference. | pending |
| 4 | Frozen Girl & Blood Moon (`222676270`) | SKIPPED_MANUAL_INPUT | UNSUPPORTED | classifier false-positive/negative testing. | pending |
| 5 | Ghost Doll & Midnight Manor (`222782750`) | REGRESSION_ONLY | PASS | operation-info coverage. | pending |
| 6 | Clock of Aldrez (`210716547`) | REGRESSION_ONLY | FIXED | concurrent chain rewrite state. | pending |
| 7 | Chapter Ii Verse Iv (`241957394`) | SKIPPED_MANUAL_INPUT | UNSUPPORTED | Corrected rewritten chain target to the Effect Monster actually chosen and rewrote sequencing to destroy other matching monsters first, then the chosen monster only on success; retroactive Token-tribute/cost semantics still require an Omega duel test. | pending |
| 8 | Myutant Amalgamate (`211699737`) | SKIPPED_MANUAL_INPUT | MANUAL_RULING | "This effect becomes that monster's original effect" is approximated with CopyEffect and needs a ruling. | pending |
| 9 | Gravinity Axis Matter (`256831125`) | SKIPPED_MANUAL_INPUT | UNSUPPORTED | Copied-effect scope and printed Link Rating reduction are not exact. | pending |
| 10 | Galactican Battle Station (`258934904`) | REGRESSION_ONLY | FIXED | Adds an effect to another resolving effect in Damage Step. | pending |

### Co-link, counter, and zone topology

| # | Card | Disposition | Static verdict | Manual question | Status |
|---:|---|---|---|---|---:|
| 11 | Protogenic Astral Cycle (`232706629`) | REGRESSION_ONLY | FIXED | zone mask / "ignore card effects". | pending |
| 12 | Carcel, the Dark Ohmen (`259780273`) | REGRESSION_ONLY | PASS | Added the official retroactive Ohmen-only Special Summon activity lock. Custom reveal/two-card summon and traversal behavior still needs duel-engine validation. | pending |
| 13 | Ohmen Surge (`259869259`) | REGRESSION_ONLY | PASS | Moved the once-per-turn limit to card activation; the continuous control effect is no longer falsely limited. EVENT_ADJUST co-link tracking and forced zone-control movement are custom mechanics. | pending |
| 14 | Siemens, the Ohmechanic Conductor (`259405917`) | REGRESSION_ONLY | FIXED | Prevented the move effect from activating without a free Main Monster Zone. Custom co-link destination movement remains an in-engine UI/ruling risk. | pending |
| 15 | Farad, the Ohmechanic Capacitor (`259350270`) | REGRESSION_ONLY | PASS | Custom Current Counter traversal/removal across mutually linked cards needs engine validation. | pending |
| 16 | Coulomb, the Ohmechanic Charger (`259841490`) | REGRESSION_ONLY | PASS | Prevented the Link-monster move effect from activating without a free Main Monster Zone. Immediate Link Summon and custom zone movement need live Extra Monster Zone validation. | pending |
| 17 | Ampere, the Ohmechanic Intensity (`259479044`) | REGRESSION_ONLY | PASS | Custom counter placement/protection over co-linked monsters needs live validation. | pending |
| 18 | Carcel, the Ohmechanic Light (`259033429`) | REGRESSION_ONLY | PASS | Moved mass Current Counter removal out of target and into cost. EVENT_ADJUST co-link transition tracking and mass counter consumption need live validation. | pending |
| 19 | Ohmen Beacon (`259650969`) | REGRESSION_ONLY | PASS | Prevented the move effect from activating without a free Main Monster Zone. Continuous co-link protection and movement/counter placement need live validation. | pending |

### Damage and stat-layer behavior

| # | Card | Disposition | Static verdict | Manual question | Status |
|---:|---|---|---|---|---:|
| 20 | To Proto Taxis (`246380598`) | REGRESSION_ONLY | PASS | damage layering. | pending |
| 21 | To Proto Psychi (`217332244`) | SKIPPED_MANUAL_INPUT | UNSUPPORTED | 100-LP increment UI. | pending |
| 22 | Phantasm Spiral Resurgence (`219047593`) | REGRESSION_ONLY | PASS | phase-only persistent negate live test. | pending |

### Ownership and opponent-resource use

| # | Card | Disposition | Static verdict | Manual question | Status |
|---:|---|---|---|---|---:|
| 23 | Abstain from Light (`232449539`) | SKIPPED_MANUAL_INPUT | MANUAL_RULING | opponent-Deck Fusion materials; shuffled-card tracker; delayed return [implemented]. | pending |
| 24 | Shattering Sustained (`248453205`) | REGRESSION_ONLY | PASS | opponent-Deck pseudo-Tribute [manual]; full-zone Tribute legality [fixed]; post-cost target legality [fixed]. | pending |
| 25 | Distained Druid Dragar (`247580036`) | REGRESSION_ONLY | PASS | opponent-Deck pseudo-Tribute [manual]; remaining Fusion effects [implemented]. | pending |
| 26 | A Stainless Story (`245970073`) | SKIPPED_MANUAL_INPUT | UNSUPPORTED | copy pool. | pending |
| 27 | Muramasa (`247378501`) | REGRESSION_ONLY | PASS | alternate Tribute UI. | pending |
| 28 | Securitake Agent (`219543855`) | REGRESSION_ONLY | PASS | Script is internally consistent, but the intended scope of opponent-owned Link material (opponent monster you control versus opponent's field) needs a ruling. | pending |
| 29 | Vampire Reptilian (`259552732`) | REGRESSION_ONLY | PASS | Opponent-monster Xyz material/control semantics. | pending |

### Timing, delayed state, and reset behavior

| # | Card | Disposition | Static verdict | Manual question | Status |
|---:|---|---|---|---|---:|
| 30 | Sacred Treasure - Bojin (`236542835`) | REGRESSION_ONLY | PASS | same-event interpretation. | pending |
| 31 | Sacred Treasure - Huangjin (`246421842`) | REGRESSION_ONLY | PASS | same-event interpretation. | pending |
| 32 | Tove, the Domesticated (`259737127`) | REGRESSION_ONLY | PASS | summon restriction/draw-send/GY delayed Battle Phase return [implemented]. | pending |
| 33 | Mylo, the Domesticated (`259686203`) | REGRESSION_ONLY | PASS | summon restriction UI. | pending |
| 34 | Nuwa, the Domesticated (`259135917`) | REGRESSION_ONLY | PASS | summon restriction UI. | pending |
| 35 | Mylo in the Wild (`259911246`) | REGRESSION_ONLY | FIXED | position restoration ruling. | pending |
| 36 | Kanmuriyama (`248801935`) | REGRESSION_ONLY | PASS | lost-target event state. | pending |
| 37 | Otakemaru the Accuser (`221855414`) | SKIPPED_MANUAL_INPUT | UNSUPPORTED | paired summon UI. | pending |
| 38 | Priestess of Nephthys (`211964444`) | SKIPPED_MANUAL_INPUT | MANUAL_RULING | copied Standby effect pool. | pending |
| 39 | Protogenesis (`246524183`) | REGRESSION_ONLY | FIXED | if you do timing. | pending |
| 40 | Chrono-Saur Rex (`236898203`) | REGRESSION_ONLY | PASS | Fixed prerequisite destruction to own face-up on-field Chrono/Dinosaur cards and scheduled self-destruction for the actual summoning phase (Main Phase 1 or Battle Phase); EVENT_PHASE+PHASE_MAIN1 lacks an exact official analogue and needs live timing validation. | pending |
| 41 | Stardust Comet (`231523659`) | REGRESSION_ONLY | FIXED | Deck Tribute/immediate Synchro/Level timing. | pending |

### Summon, material, and selection UI

| # | Card | Disposition | Static verdict | Manual question | Status |
|---:|---|---|---|---|---:|
| 42 | The Condescender (`221321849`) | SKIPPED_MANUAL_INPUT | UNSUPPORTED | summon procedure; Level and Rank reduction; Link Rating reduction unsupported. | pending |
| 43 | Stained Fox Feness (`247499445`) | REGRESSION_ONLY | PASS | printed colon versus procedure UI. | pending |
| 44 | The Blue Frute (`236158052`) | REGRESSION_ONLY | PASS | custom UI. | pending |
| 45 | The Yellow Frute (`235607781`) | REGRESSION_ONLY | PASS | custom UI. | pending |
| 46 | The Red Frute (`246216813`) | REGRESSION_ONLY | PASS | custom UI. | pending |
| 47 | The Green Frute (`227745087`) | REGRESSION_ONLY | PASS | custom UI. | pending |
| 48 | The White Frute (`220916791`) | REGRESSION_ONLY | PASS | mandatory Tribute opens MZONE before target check [fixed]; summon effect [implemented]. | pending |
| 49 | Fruteonia (`246830897`) | REGRESSION_ONLY | PASS | face-down Link/Ritual UI. | pending |
| 50 | Fruteopia (`216140411`) | REGRESSION_ONLY | PASS | face-down Link/Ritual UI. | pending |
| 51 | Fruteification (`256930605`) | REGRESSION_ONLY | PASS | custom summon UI. | pending |
| 52 | The Fruteful Moon (`248290754`) | REGRESSION_ONLY | PASS | custom UI. | pending |
| 53 | Pip, the Domesticated (`259377794`) | REGRESSION_ONLY | PASS | custom Tribute Summon support. | pending |
| 54 | Domestica Praerie (`259264881`) | REGRESSION_ONLY | PASS | custom Tribute UI. | pending |
| 55 | Domestica Anjelie (`259337739`) | REGRESSION_ONLY | PASS | custom Tribute UI. | pending |
| 56 | Domestica Lunalie (`259245149`) | REGRESSION_ONLY | PASS | custom Tribute UI. | pending |
| 57 | Domestica in the Underworld (`259668626`) | REGRESSION_ONLY | PASS | extra Tribute UI. | pending |
| 58 | Domestica in the Wild (`259410628`) | REGRESSION_ONLY | PASS | Fusion UI. | pending |
| 59 | Domestica Kyrie (`259670933`) | REGRESSION_ONLY | PASS | custom procedure. | pending |
| 60 | Ursarctic Leoship (`247831166`) | REGRESSION_ONLY | PASS | custom replacement integration. | pending |
| 61 | Ursarctic Octantis (`235051048`) | REGRESSION_ONLY | PASS | custom Synchro-style procedure. | pending |
| 62 | Ursarctic Hextanius (`244921711`) | SKIPPED_MANUAL_INPUT | UNSUPPORTED | non-Synchro procedure; Deck summon; shuffle-draw with hidden banishment excluded [fixed]. | pending |
| 63 | Ursarctic Nordbar (`249093610`) | REGRESSION_ONLY | PASS | custom procedure. | pending |
| 64 | Branching to Guidance (`222257685`) | REGRESSION_ONLY | PASS | copied token identity/stats UI. | pending |
| 65 | Onibi (`217713649`) | REGRESSION_ONLY | PASS | immediate Normal Summon UI. | pending |
| 66 | Serene Mermaid of the Grand Blue (`259369909`) | SKIPPED_MANUAL_INPUT | UNSUPPORTED | hand summon; Fusion Summon; post-Fusion Extra Deck restriction approximated. | pending |
| 67 | Grand Blue Matriarch (`259093260`) | REGRESSION_ONLY | PASS | Synchro UI. | pending |
| 68 | Sacred Feather of Nephthys (`216532402`) | REGRESSION_ONLY | PASS | Ritual UI. | pending |
| 69 | Stellaer of the Frozen (`259581666`) | REGRESSION_ONLY | PASS | face-up S/T Set cases. | pending |
| 70 | Stellaer of the Plants (`259219942`) | REGRESSION_ONLY | FIXED | overlay redirect UI. | pending |
| 71 | Stellaer of the Breeze (`230998543`) | REGRESSION_ONLY | FIXED | Xyz UI. | pending |
| 72 | Restoration of Azrynior (`236239443`) | REGRESSION_ONLY | PASS | multi-summon UI. | pending |
| 73 | Dominus Sentinel (`259290896`) | REGRESSION_ONLY | PASS | custom Attributes. | pending |
| 74 | Vir Pedicae Mortis - Fearless Hunter (`244778917`) | REGRESSION_ONLY | PASS | Printed "treated as 2 materials" for a named Link Summon is not implemented; official generic Link helpers expose no source-monster effect that safely changes material weight. Requires destination-procedure/ruling work. | pending |
| 75 | Bobbie Bluefin & the Nautical Nocturnes (`259114562`) | REGRESSION_ONLY | PASS | When both Normal and Special Summon are legal the script chooses Special Summon without an explicit player choice; confirm intended forced-summon choice semantics. | pending |
| 76 | Scarlet Seareef & the Nautical Creatures (`220749574`) | REGRESSION_ONLY | PASS | Forced summon branch choice and bottom-of-Deck ordering need in-engine/ruling confirmation. | pending |
| 77 | Evander Coldwater & the Nautical Abyss (`225109525`) | REGRESSION_ONLY | PASS | Returned monster can become eligible for the subsequent forced summon; confirm that this matches intended sequencing. | pending |
| 78 | Nautical Backwashing & Oceanic Waves (`223158720`) | REGRESSION_ONLY | PASS | Forced Normal/Special Summon selection defaults to Special when both are legal; printed choice semantics need confirmation. | pending |
| 79 | Exploring the Nautical Waters (`248946297`) | REGRESSION_ONLY | PASS | Forced summon branch and bottom-deck order need an engine/ruling test. | pending |
| 80 | Nautical Adventures & Torrential Seas (`218905439`) | REGRESSION_ONLY | FIXED | A returned monster may be eligible for the subsequent forced summon; confirm intended pool and branch choice. | pending |
| 81 | Bob, but Stronger! (`259944943`) | REGRESSION_ONLY | FIXED | Fixed contact-Fusion material search from LOCATION_MZONE to official LOCATION_ONFIELD; live test still required to confirm Omega permits the "Umi" Spell to pass Fusion-material legality. | pending |
| 82 | Windborne Eye of the Storm (`256110263`) | SKIPPED_MANUAL_INPUT | UNSUPPORTED | The script uses a temporary synthetic Token material to emulate "treated as a Synchro Summon using only Windborne"; this bespoke engine workaround needs live validation. | pending |
| 83 | Ohmen Powerload (`259434499`) | REGRESSION_ONLY | PASS | Added the official retroactive Thunder-only Special Summon activity lock. Custom optional counter removal/destruction branch needs UI validation. | pending |
| 84 | Phlogistic Uprising! (`257239133`) | REGRESSION_ONLY | FIXED | Excluded illegal LP payments that would reduce LP below the engine minimum. Fusion Summon from GY/Extra with mixed send/shuffle materials is custom and needs live validation. | pending |
| 85 | Chamroshes' Aegis (`221924008`) | REGRESSION_ONLY | PASS | Contact-style Extra Deck summon by shuffling three differently named Tuners needs procedure validation. | pending |
| 86 | Ghoti from a Deeper Depth Than the Deepest Deep (`240575550`) | REGRESSION_ONLY | PASS | Custom Synchro material rule allowing a Fish Tuner as non-Tuner needs live validation. | pending |
| 87 | Pumpqueen the Queen of Ghosts (`259308265`) | REGRESSION_ONLY | FIXED | The extra Normal Summon is implemented, but hand Tributes for Castle of Dark Illusions need a ruling/engine implementation. | pending |
| 88 | Ghostrick Oni (`239335848`) | SKIPPED_MANUAL_INPUT | UNSUPPORTED | Custom Xyz material transfer/Quick conversion. | pending |
| 89 | Gravinity Spherix (`231088629`) | SKIPPED_MANUAL_INPUT | UNSUPPORTED | Summon replacement plus minimum GY Xyz material. | pending |

### Other custom engine behavior

| # | Card | Disposition | Static verdict | Manual question | Status |
|---:|---|---|---|---|---:|
| 90 | The Hanging Frute (`213266433`) | SKIPPED_MANUAL_INPUT | UNSUPPORTED | attack-all approximation; temporary protection [manual]. | pending |
| 91 | Sacred Treasure - Chunyin (`229499914`) | REGRESSION_ONLY | PASS | banish trigger; face-up banished add filter [fixed]. | pending |
| 92 | City Within the Grand Blue (`259679619`) | REGRESSION_ONLY | PASS | runtime alias. | pending |
| 93 | Volt, the Ohmechanic Chocker (`259519336`) | REGRESSION_ONLY | PASS | Moved all-counter payment to cost and made the destruction correctly non-targeting. Custom counter-threshold continuous/Quick interaction needs live validation after the confirmed fixes. | pending |
| 94 | Urphiel, the High Arckcestial (`215105971`) | REGRESSION_ONLY | PASS | Optional destruction replacement and owner-control leave-field trigger need live validation. | pending |
| 95 | Gravinity Sonic Scream (`238184015`) | SKIPPED_MANUAL_INPUT | UNSUPPORTED | Copied activated-effect semantics. | pending |
| 96 | Flower Cardian Moonflare (`248940511`) | REGRESSION_ONLY | PASS | One card treated as 3 non-Tuners. | pending |
| 97 | Attack on Gravity (`259307285`) | REGRESSION_ONLY | PASS | Card-wide hand permission cannot safely distinguish its two activation modes. | pending |

## Completion boundary

All 577 cards have a current hash-pinned static review. This report is the explicit boundary for cases intentionally skipped under the manual-input instruction; automated QA does not misrepresent these scenarios as replay-backed live passes.

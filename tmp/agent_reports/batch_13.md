### Semantic Effect Audit: Batch 13

| Semantic Requirement | Lua Implementation | Issue Type | Path & Line | Description / Proposed Fix |
|---|---|---|---|---|
| ATK becomes 0 without counters | `e1` (`EFFECT_SET_ATTACK`) | Confirmed | `c259350270.lua:11` | Correctly evaluated via `s.atkcon`. |
| 1+: Banish 1 card opponent controls | `e2` (`efftg1`, `effop1`) | Confirmed | `c259350270.lua:19` | Correctly filters `LOCATION_ONFIELD` for `1-tp`. |
| 2+: Add "Ohmen" card from GY/banish | `e3` (`efftg2`, `effop2`) | Confirmed | `c259350270.lua:31` | Correctly uses `LOCATION_GRAVE+LOCATION_REMOVED`. |
| 3+: Remove counters, banish 3 from opp GY | `e4` (`effcost3`, `effop3`) | Confirmed | `c259350270.lua:43` | Non-targeting banish implemented correctly using `SelectMatchingCard`. |
| 1+: Remove counters, inflict 300 each | `e2` (`effcost1`, `effop1`) | Confirmed | `c259519336.lua:20` | Stores counter count in `e:SetLabel` to correctly calculate damage. |
| 2+: "Ohmechanic" monsters gain 500 ATK | `e3` (`EFFECT_UPDATE_ATTACK`) | Confirmed | `c259519336.lua:32` | Targets `SET_OHMECHANIC` globally. |
| 3+: Destroy 1 opponent monster | `e4` (`efftg3`, `effop3`) | Confirmed | `c259519336.lua:42` | Correct non-targeting destruction. |
| 1+: Move 1 Link monster, place counter | `e2` (`effop1`) | Confirmed | `c259841490.lua:19` | Uses `Duel.MoveSequence` and manually adds counter. |
| 2+: Add "Ohmen" Spell/Trap | `e3` (`efftg2`) | Confirmed | `c259841490.lua:29` | Correct `TYPE_SPELL+TYPE_TRAP` filter. |
| 3+: Link Summon from Extra Deck | `e4` (`effop3`) | Confirmed | `c259841490.lua:40` | Resolves via `Duel.LinkSummon`. |
| 1+: Add "Ohmen" monster, discard 1 | `e2` (`effop1`) | Confirmed | `c259479044.lua:20` | Resolves sequentially. |
| 2+: Place counter on co-linked | `e3` (`effop2`) | Confirmed | `c259479044.lua:31` | Uses `GetMutualLinkedGroup()`. |
| 3+: Co-linked indestructible | `e4`, `e5` | Confirmed | `c259479044.lua:41` | Applies to `GetMutualLinkedGroup()`. |
| ATK is doubled with counter | `e2` (`EFFECT_SET_ATTACK_FINAL`) | Ambiguous | `c259033429.lua:23` | Using `EFFECT_SET_ATTACK_FINAL` locks the ATK to exactly 2x Base, overriding other buffs. **Fix:** Use `EFFECT_UPDATE_ATTACK` with `GetBaseAttack()` instead. |
| If becomes co-linked, place counters | `e3` (`EVENT_ADJUST`) | Suspected | `c259033429.lua:86` | Uses a hard OPT flag (`Duel.RegisterFlagEffect`) for an action that has no text limit. **Fix:** Track previous link state instead of restricting to OPT. |
| Remove all counters (min 5), destroy all | `e4` (`descost`) | Confirmed | `c259033429.lua:39` | Cost verifies total count >= 5. |
| Target & negate, remove 2 counters, destroy | `e1` (`activate`) | Suspected | `c259434499.lua:98` | Uses a manual `while loop` with `Select` to remove counters iteratively. **Fix:** Replace with standard `Duel.RemoveCounter(tp, 1, 1, COUNTER_CURRENT, 2, REASON_EFFECT)`. |
| Special Summon 1 "Ohmen" from Deck | `e1` (`activate`) | Confirmed | `c259434499.lua:114` | Resolves correctly based on choice. |
| SP Summon from hand or GY | `e1` (`activate`) | Confirmed | `c259650969.lua:8` | Handles optional branching condition correctly. |
| Co-linked with counter cannot be targeted | `e2` (`tgtg`) | Confirmed | `c259650969.lua:17` | Targets `GetMutualLinkedGroupCount() > 0`. |
| Move monster, place counters | `e3` (`mvop`) | Confirmed | `c259650969.lua:26` | Safe zone reassignment check. |
| SP Summon if "Altergeist" summoned | `e1` (`spcon`) | Confirmed | `c245452058.lua:7` | Correct `EVENT_SPSUMMON_SUCCESS` with `IsSummonPlayer` filter. |
| Add Trap listing "Altergeist" | `e2` (`thfilter`) | Suspected | `c245452058.lua:66` | Uses `aux.IsSetNameMonsterListed(c,SET_ALTERGEIST)`. **Fix:** Standardize to `Card.ListsArchetype(c, SET_ALTERGEIST)`. |
| Tribute to negate 1 face-up card | `e2` (`negcost`, `negop`) | Confirmed | `c211873618.lua:16` | Validates hand and field tribute securely. |
| Sent to GY: Set 1 "Altergeist" Trap | `e3` (`settg`) | Confirmed | `c211873618.lua:29` | Validates `IsSSetable()`. |
| SP Summon 1 Altergeist from GY | `e1` (`sptg`) | Confirmed | `c252552954.lua:8` | Resolves safely in Defense Position. |
| Negate monster effect, add Trap | `e2` (`negtg`) | Suspected | `c252552954.lua:67` | Uses `aux.IsSetNameMonsterListed`. **Fix:** Change to standard `Card.ListsArchetype(c, 0x103)`. |
| SP Summon Level 4 NATURE | `e1` (`sptg`) | Confirmed | `c259152704.lua:8` | Validates attribute 0x80 (Custom CCG mapping). |
| Opponent must attack | `e4` (`atkval`) | Confirmed | `c259152704.lua:29` | `EFFECT_MUST_ATTACK_MONSTER` correctly mapped. |
| Add Galaxy or Celestial Warrior | `e1` (`filter`) | Confirmed | `c212055290.lua:14` | Matches `0x7b` and `0x40000000` (custom race mapping). |
| Destroy S/T, place Pendulum Zones | `e1` (`desop`) | Confirmed | `c259225324.lua:9` | PZone placement avoids targeting perfectly. |
| Immediately Pendulum Summon | `e2` (`penop`) | Live-Test-Only | `c259225324.lua:104` | Forcing manual `Duel.SpecialSummon` inside `SUMMON_TYPE_PENDULUM` requires flawless `aux.PendOperationCheck` linkage for EMZ rules. **Fix:** Ensure internal support routines validate EX zones properly. |
| Trigger on Attack or Chain, Destroy 2 | `e1`, `e2` | Confirmed | `c250902476.lua:4` | Securely branches between `EVENT_CHAINING` and `EVENT_ATTACK_ANNOUNCE`. |
| 3 Tuners + 3 non-Tuners with diff attr | `syncheck` | Confirmed | `c228464260.lua:38` | `GetClassCount(Card.GetAttribute)==6` is fully robust. |
| Immune to matching attribute effects | `e3` (`efilter`) | Confirmed | `c228464260.lua:73` | Checks bitmask correctly against controlled monsters. |
| SP Summon this + 1 Level 1, negate atk | `e1` (`sptg`) | Confirmed | `c253152295.lua:33` | Securely validates `59822133` (Blue-Eyes Spirit restriction). |
| Xyz Summon using opponent's S/T | `e1` (`altcheck`) | Confirmed | `c256207361.lua:42` | Generates a complex subgroup match for opponent's S/T. Uses `Duel.Overlay` safely. |
| Set S/T listing Phlogiston Dragon | `e4` (`setfilter`) | Confirmed | `c236721134.lua:79` | Validates `aux.IsCodeListed(c,242094473)`. |
| Negate S/T activation | `e6` (`negop`) | Confirmed | `c236721134.lua:106` | Chain Negation successfully triggered by release. |
| Copy Spell Card effect | `e2` (`copyop`) | Live-Test-Only | `c224811863.lua:81` | Uses `CheckActivateEffect` and copies target/operation. This mechanism is powerful but highly volatile depending on the complexity of the copied spell. |
| SP Summon from GY | `e1` (`spcon`) | Confirmed | `c240104048.lua:38` | Controlled by generic `EFFECT_SPSUMMON_PROC`. |
| Fusion Summon, send from GY to Deck | `e1` (`fsop`) | Confirmed | `c257239133.lua:55` | Validates `LOCATION_GRAVE` to `SEQ_DECKSHUFFLE` perfectly. |
| Pay LP in multiples of 300 | `e1` (`fsop`) | Confirmed | `c257239133.lua:79` | Implemented via `Duel.AnnounceNumber(tp,table.unpack(options))`. |
| Track LP paid globally, inflict damage | `ge1`, `e1` | Confirmed | `c219714894.lua:31` | `EVENT_PAY_LPCOST` perfectly aggregates LP spending into a reset array `s[tp]`. |
| Pay LP; gain attacks OR force attacks | `e1` (`activate`) | Confirmed | `c236815197.lua:44` | Branch selection properly evaluates both routes into `EFFECT_MUST_ATTACK` and `EFFECT_EXTRA_ATTACK_MONSTER`. |
| Unaffected by lower ATK monsters | `e1` (`efilter`) | Confirmed | `c242094473.lua:54` | Correctly evaluates dynamic ATK differential. |
| Gains 1 additional attack per lower ATK | `e2` (`atkval`) | Suspected | `c242094473.lua:19` | Uses `EFFECT_EXTRA_ATTACK_MONSTER`. This restricts extra attacks to monsters only. **Fix:** Use `EFFECT_EXTRA_ATTACK` if direct attacks are permitted by design. |
| Opp monsters lose ATK/DEF = LP paid | `e3` (`paylpcheckop`) | Confirmed | `c242094473.lua:65` | Utilizes FlagEffect labels to trace live LP costs securely. |
| Destroy cards per 900 LP paid | `e2` (`desop`) | Confirmed | `c230303021.lua:88` | Evaluates `math.floor(lp/900)` properly. |
| Send 3 from Deck/Extra + 1 from Field | `e3` (`hordetg`) | Confirmed | `c230303021.lua:105` | Custom selection cleanly merges the `field_g` array with Deck selections. |

### Semantic Effect Audit Report: Batch 10

I have completed the semantic audit for the provided batch. Below is the per-card clause table and findings.

### Windborne Main Deck Monsters
*(Windborne Swiftsurfer [247779405], Windborne Cloudwing [217029078], Windborne Cartographer [221759221], Janna, Windborne Goddess of the Temple [215068354], Maryam, Windborne Caretaker of the Temple [257794541])*

These cards share the same Special Summon and Standby Phase resolution effect.
**Path:** `public/CCG Downloads/CCG_Scripts/c<passcode>.lua`

| Clause | Requirement | Implementation | Status | Remarks |
|---|---|---|---|---|
| 1 | You can also reveal up to 2 "Windborne" Spells in your hand to activate this effect; | `s.spcost` uses `sg:KeepAlive()` and `e:SetLabelObject(sg)`. | **Confirmed Issue** | Memory leak. If the activation is negated, `s.spop` does not run, and the group is never deleted. **Fix:** Register a `RESET_CHAIN` continuous effect on `EVENT_CHAIN_NEGATED` to call `DeleteGroup()`. |
| 2 | Special Summon this card from your hand by shuffling... | `s.spop` handles the shuffle and summon sequentially. | **Ambiguous** | "by shuffling" usually implies simultaneous resolution, but `SendtoDeck` then `SpecialSummon` is acceptable in EDOPro for this custom phrasing. |
| 3 | during the next Standby Phase, add a "Windborne" card... then Set "Windborne" Quick-Play Spells | `e1:SetCode(EVENT_PHASE+PHASE_STANDBY)` inside `s.spop`. | **Confirmed Issue** | In older scripts (like Swiftsurfer), `SetReset` is hardcoded to `1` or `2` without properly checking `GetCurrentPhase()`. Cartographer checks it correctly. **Fix:** Ensure all use `if Duel.GetCurrentPhase()==PHASE_STANDBY then e1:SetReset(RESET_PHASE+PHASE_STANDBY,2) else e1:SetReset(RESET_PHASE+PHASE_STANDBY) end`. |

---

### A Whisper of Crying Chaos (253472430)
**Path:** `public/CCG Downloads/CCG_Scripts/c253472430.lua`

| Clause | Requirement | Implementation | Status | Remarks |
|---|---|---|---|---|
| 1 | Immediately after this effect resolves, Synchro Summon 1 "Crying Chaos" Synchro Monster from your Extra Deck using those monsters. | `s.synchroop` (Lines 63-86), `s.chkfilter2` (Lines 46-51) | **Confirmed Issue (Critical)** | `chkfilter2` uses `sg:RemoveCard(c)`. If a monster is both a Crying Chaos Synchro and a Zombie Tuner, it will be checked against itself. `RemoveCard` will inadvertently remove the *first* selected material from the group, breaking the loop and preventing the summon. **Fix:** Add `if c==c1 then return false end` in `s.chkfilter2`. |
| 2 | take control of 1 monster your opponent controls until the end of this turn, and if you do... its effects are negated and its ATK/DEF become 0. | `s.ctop` (Lines 93-119). Applies `EFFECT_DISABLE`, `EFFECT_SET_ATTACK_FINAL` etc. | **Safe** | Properly uses `RESET_PHASE+PHASE_END` and applies all necessary stat and effect nullifications. |

---

### Janna, Windborne Goddess of Clement Winds (237684285)
**Path:** `public/CCG Downloads/CCG_Scripts/c237684285.lua`

| Clause | Requirement | Implementation | Status | Remarks |
|---|---|---|---|---|
| 1 | return them to the hand, then shuffle as many cards from your hand into the Deck | `s.rtop` (Lines 57-80) allows selecting 1 to 99 cards to shuffle. | **Ambiguous** | "as many cards" usually implies "all" in PSCT. If "any number" was intended, the text should be updated. Implementation allows partial shuffling. |
| 2 | during the next Standby Phase, add 1 "Windborne" card from your Deck to your hand | `e1:SetReset(RESET_PHASE+PHASE_STANDBY,1)` (Line 72) | **Confirmed Issue** | Unconditional `1` reset. If this trigger effect activates and resolves during the Standby Phase, the delayed effect will expire at the end of the *current* phase without activating. **Fix:** Implement `GetCurrentPhase()` check for reset count. |

---

### Iscylla, Windborne Kraken of Sunken Depths (255686110)
**Path:** `public/CCG Downloads/CCG_Scripts/c255686110.lua`

| Clause | Requirement | Implementation | Status | Remarks |
|---|---|---|---|---|
| 1 | When you add a "Windborne" card to your hand, this card gains 200 ATK/DEF | `s.atkcon` checks `EVENT_TO_HAND` (Lines 52-54) | **Confirmed Issue** | The script triggers on ANY addition, including returning cards from the field to the hand (which does not count as "adding" in YGO). **Fix:** Check `c:IsPreviousLocation(LOCATION_DECK+LOCATION_GRAVE+LOCATION_REMOVED)`. |
| 2 | return it to the Extra Deck when it leaves the field. | `s.spop` uses `LOCATION_DECKBOT` for `EFFECT_LEAVE_FIELD_REDIRECT`. | **Suspected Issue** | Using `LOCATION_DECKBOT` on an Extra Deck monster works mechanically in EDOPro, but `LOCATION_EXTRA` is the standard for redirecting Synchro monsters. |

---

### Shining Brigade - Forward Division (232038002)
**Path:** `public/CCG Downloads/CCG_Scripts/c232038002.lua`

| Clause | Requirement | Implementation | Status | Remarks |
|---|---|---|---|---|
| 1 | A "Shining Brigade" monster that has this card as material gains the following effect. | `s.initial_effect` sets `EFFECT_TYPE_XMATERIAL`. | **Safe** | Successfully transfers the effect to the Synchro/Xyz monster. |
| 2 | Each turn, negate the effect of your opponent's first Spell Card or effect that resolves. | `s.negop` (Lines 66-70) registers a flag effect on the player: `Duel.RegisterFlagEffect(tp,id...)` | **Confirmed Issue** | If two monsters inherit this effect, they share the player flag. Both will trigger on the first spell and resolve simultaneously, wasting one monster's negation. **Fix:** Register the flag on the card (`e:GetHandler()`) and check `Duel.IsChainDisposed(ev)` in the condition. |

---

### Muntith, Windborne Skydragon of the Shining Sun (215006791)
**Path:** `public/CCG Downloads/CCG_Scripts/c215006791.lua`

| Clause | Requirement | Implementation | Status | Remarks |
|---|---|---|---|---|
| 1 | banish all monsters your opponent controls until the End Phase. | `s.rmop` uses `RegisterFlagEffect(id, ...)` on banished cards to return them. | **Safe** | Correctly tracks returned cards using `Group.KeepAlive`. |
| 2 | You can target 1 "Windborne" monster in your GY; add that target to your hand during your next Standby Phase. | `s.thop` uses `tc:RegisterFlagEffect(id, ...)` (Line 109). | **Suspected Issue** | The script reuses the exact same `id` for two different flag effects in the same script. While unlikely to collide mechanically due to location boundaries, it is bad practice and prone to edge-case bugs. **Fix:** Use `id+1` or `id+2` for the second flag effect. |

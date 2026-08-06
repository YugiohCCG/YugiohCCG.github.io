# Semantic Effect Audit Report: Batch 4 (Cards 76 - 101)

An exhaustive, read-only semantic audit of the 25 custom Yu-Gi-Oh! cards defined in `tmp/batch_4.json` has been completed. Below is the per-card clause analysis comparing card texts against their Lua implementations in `public/CCG Downloads/CCG_Scripts/`.

---

## Executive Summary & Critical Bugs

1. **Unplayable / Crash Cards**:
   - **`CARD-0095` (Prophecy of Boulders, Passcode: 223558392)**: `s.search_codes` is initialized as an empty table `{}`. Because of this, `s.thfilter` always returns `false`, causing target checking at `chk==0` to fail unconditionally. **This card cannot be activated or summoned.**
   - **`CARD-0099` (Stellaer of the Swamp, Passcode: 259586445)**: `s.xyzalt` signature has 4 parameters (`c, e, tp, xyzc`) instead of the expected 3 parameters (`c, tp, xyzc`). Calling `AddXyzProcedure` passes `tp` as `e` and `xyzc` as `tp`, causing `Duel.IsExistingMatchingCard` to be invoked with `tp = nil`, resulting in an instant Lua runtime crash during Xyz Summon procedure evaluation.

2. **Severe Logic / Gameplay Bugs**:
   - **`CARD-0076` (Domestica in the Underworld)**: Indestructibility registered during Set operation uses `RESETS_STANDARD` with `EFFECT_FLAG_SET_AVAILABLE`. It never resets when activated/flipped face-up, making the Continuous Spell permanently indestructible on the field instead of only while Set.
   - **`CARD-0078` (Domestica Kyrie)**:
     - `s.actop` moves "Domestic Underworld" (a Field Spell) to `LOCATION_SZONE` instead of `LOCATION_FZONE` / `Duel.ActivateFieldSpell`.
     - `s.regop` registers `EVENT_RELEASE` flag with `RESET_EVENT+RESETS_STANDARD`, which includes `RESET_TOGRAVE`, instantly clearing the flag when entering the GY. The GY Quick Effect can never trigger.
   - **`CARD-0083` & `CARD-0084` (Ursarctic Mikailus & Megailus)**:
     - Mikailus `s.setop` only grants `ACT_IN_SET_TURN` to Quick-Play Spells and Traps, failing to allow Set Continuous/Field Spells to be activated this turn as specified by text.
     - Mikailus and Megailus draw effects check `e:GetHandler():IsRelateToEffect(e)`. If the card leaves the GY/banishment in response to activation, the draw effect is silently swallowed.
   - **`CARD-0093, CARD-0094, CARD-0096, CARD-0097, CARD-0098` (Prophecy Archetype)**:
     - All Prophecy searchers use hardcoded lists of card passcodes in `s.search_codes`.
     - All Prophecy cards enforce `Duel.IsExistingMatchingCard(s.thfilter, tp, LOCATION_DECK, 0, 1, nil)` at `chk==0`, preventing activation if 0 search targets exist in Deck, despite PSCT "and if you do, add..." making the search optional.

---

## Detailed Per-Card Clause Tables

### 1. CARD-0076: Domestica in the Underworld (Passcode: 259668626)
- **Script Path**: `public/CCG Downloads/CCG_Scripts/c259668626.lua`
- **Text**: "This card in your hand can be used as Tribute when you Normal Summon a NATURE Monster. If this card is sent from the hand to the GY: You can Set this card, and if you do, this Set card cannot be destroyed by card effects. If a NATURE Monster(s) returns from your GY to the Deck (max 2): You can draw that many cards, then send that many cards from your hand to the GY. You can only use each effect of \"Domestica in the Underworld\" once per turn."

| Clause / Requirement | Implementation / Callback | Status | Line # | Analysis & Proposed Fix |
| --- | --- | --- | --- | --- |
| Hand Tribute for NATURE monster | `e1`: `EFFECT_EXTRA_RELEASE_SUM` (`s.relval`) | Confirmed Issue | L12-18, L45-47 | `e1` lacks `SetCountLimit(1, id)`, failing to enforce HOPT limit for Tribute effect. **Fix**: Add `e1:SetCountLimit(1, id)`. |
| Trigger Set & Indestructible if sent from hand to GY | `e2`: `EVENT_TO_GRAVE` (`s.setcon`, `s.settg`, `s.setop`) | Confirmed Issue | L56-66 | `e1` (indestructibility) uses `RESETS_STANDARD` with `EFFECT_FLAG_SET_AVAILABLE`, causing it to remain indestructible even after being activated/flipped face-up. **Fix**: Check `c:IsFacedown()` in value/condition or add `RESET_CHANGE_POS`. |
| NATURE monster returns from GY to Deck -> Draw & Send to GY | `e3`: `EVENT_TO_DECK` (`s.drcon`, `s.drtg`, `s.drop`) | Confirmed Issue | L76-92 | `s.drop` aborts completely if `Duel.Draw` draws fewer than `ct` cards (e.g. 1 card drawn when 2 requested). **Fix**: Use actual drawn amount `local drawn=Duel.Draw(tp,ct,REASON_EFFECT)` and send `drawn` cards from hand to GY. |
| HOPT limit on each effect | `e2:SetCountLimit(1, id)`, `e3:SetCountLimit(1, id+100)` | Confirmed Issue | L26, L39 | HOPT is missing for `e1`. |

---

### 2. CARD-0077: Domestica in the Wild (Passcode: 259410628)
- **Script Path**: `public/CCG Downloads/CCG_Scripts/c259410628.lua`
- **Text**: "This card in your hand can be used as Tribute when you Normal Summon a NATURE Monster. If this card is sent from the hand to the GY: You can Set this card, and if you do, this card can be activated this turn. During the Main Phase: You can also Tribute a monster you control to activate this effect; reveal 1 Beast or Winged Beast Fusion Monster in your Extra Deck, then you can Fusion Summon it by shuffling the Fusion Materials from your GY into the Deck. You can only use each effect of \"Domestica in the Wild\" once per turn."

| Clause / Requirement | Implementation / Callback | Status | Line # | Analysis & Proposed Fix |
| --- | --- | --- | --- | --- |
| Hand Tribute for NATURE monster | `e1`: `EFFECT_EXTRA_RELEASE_SUM` | Confirmed Issue | L12-17 | Missing HOPT registration `e1:SetCountLimit(1, id)`. |
| Trigger Set & Activate this turn | `e2`: `EVENT_TO_GRAVE` (`s.setop`) | Pass | L19-29, L55-65 | Correctly sets card and grants `EFFECT_TRAP_ACT_IN_SET_TURN`. |
| Main Phase Fusion Summon from Extra Deck by shuffling GY materials | `e3`: `EFFECT_TYPE_QUICK_O` (`s.fuscost`, `s.fustg`, `s.fusop`) | Confirmed Issue | L86-89, L98, L101 | 1. `s.fustg` does not check if valid materials exist in GY for any Extra Deck monster before allowing activation. **Fix**: Check materials in `fustg`. 2. Line 98 passes `tp\|0x200` to `CheckFusionMaterial` and `SelectFusionMaterial` which corrupts `chkf` parameter. **Fix**: Pass `tp`. |
| HOPT limit on each effect | `e2:SetCountLimit(1, id)`, `e3:SetCountLimit(1, id+100)` | Confirmed Issue | L25, L37 | Missing HOPT limit for `e1`. |

---

### 3. CARD-0078: Domestica Kyrie (Passcode: 259670933)
- **Script Path**: `public/CCG Downloads/CCG_Scripts/c259670933.lua`
- **Text**: "2 \"Domestica\" monsters except \"Domestica Kyrie\"\nMust first be Special Summoned from the Extra Deck by shuffling the Required Materials from your GY into the Deck while you control no monsters (You do not use \"Polymerization\"). You can only Special Summon \"Domestica Kyrie\" once per turn this way. If this card is Special Summoned from the Extra Deck: You can activate 1 \"Domestic Underworld\" from your Deck or GY. During the turn this card in your GY was Tributed (Quick Effect): You can send 1 \"Domestica\" monster from your Deck to the GY. You can only use each effect of \"Domestica Kyrie\" once per turn."

| Clause / Requirement | Implementation / Callback | Status | Line # | Analysis & Proposed Fix |
| --- | --- | --- | --- | --- |
| Special Summon procedure from Extra Deck | `e1`: `EFFECT_SPSUMMON_PROC` (`s.spcon`, `s.sptg`, `s.spop`) | Suspected Issue | L71, L75 | Passes `tp\|0x200` to `CheckFusionMaterial` / `SelectFusionMaterial`. **Fix**: Pass `tp`. |
| Must first be Special Summoned from Extra Deck | `e2`: `EFFECT_SPSUMMON_CONDITION` (`s.splimit`) | Confirmed Issue | L94-96 | `s.splimit` returns `not c:IsLocation(LOCATION_EXTRA)`, which allows non-Extra Deck Special Summons from GY without proper prior summon. **Fix**: Return `false` unless properly summoned. |
| Activate 1 "Domestic Underworld" from Deck or GY | `e3`: `EVENT_SPSUMMON_SUCCESS` (`s.acttg`, `s.actop`) | Confirmed Issue | L114 | Moves "Domestic Underworld" (Field Spell 259265448) to `LOCATION_SZONE` instead of `LOCATION_FZONE` / `Duel.ActivateFieldSpell`. **Fix**: Use `LOCATION_FZONE` or `Duel.ActivateFieldSpell`. |
| Quick Effect in GY during the turn Tributed | `e4`: `EVENT_RELEASE` (`s.regop`) & `e5`: `s.tgcon` | Confirmed Issue | L117-122 | `s.regop` registers flag effect with `RESET_EVENT+RESETS_STANDARD`, which includes `RESET_TOGRAVE`, clearing the flag when entering GY! **Fix**: Exclude `RESET_TOGRAVE` from reset flags. |

---

### 4. CARD-0079: Pip in the Wild (Passcode: 259394179)
- **Script Path**: `public/CCG Downloads/CCG_Scripts/c259394179.lua`
- **Text**: "\"Pip, The Domesticated\" + 1 \"Domestica\" Fairy Monster\nCannot be Summoned while you control a monster. During the Main Phase, if you control no other monster (Quick Effect): You can Tribute this card; send all monsters on the field to the GY. You can only use the previous effect of \"Pip in the Wild\" once per turn. If this card is sent to the GY: Return this card to the Extra Deck, also, add 1 \"Pip, The Domesticated\" from your Deck to your hand, then send it to the GY."

| Clause / Requirement | Implementation / Callback | Status | Line # | Analysis & Proposed Fix |
| --- | --- | --- | --- | --- |
| Materials: "Pip, The Domesticated" + 1 "Domestica" Fairy | `AddFusionProcFun2` | Pass | L7-8 | Properly configured. |
| Cannot be Summoned while you control a monster | `e0`: `EFFECT_SPSUMMON_CONDITION` (`s.splimit`) | Pass | L11-16, L44-46 | Correctly checks control of monsters. |
| Quick Effect: Tribute this card, send all monsters to GY | `e1`: `EFFECT_TYPE_QUICK_O` (`s.tgcon`, `s.cost`, `s.tgtg`, `s.tgop`) | Pass | L18-29, L47-68 | Checks Main Phase, no other monsters, releases as cost, sends all monsters on field to GY. |
| Trigger: Return to Extra Deck, search Pip, send to GY | `e2`: `EVENT_TO_GRAVE` (`s.rettg`, `s.retop`) | Pass | L31-39, L72-95 | Correctly executes returning to Extra Deck and searching Pip then sending to GY. |

---

### 5. CARD-0080: Tove in the Wild (Passcode: 259718504)
- **Script Path**: `public/CCG Downloads/CCG_Scripts/c259718504.lua`
- **Text**: "\"Tove, The Domesticated\" + 1 \"Domestica\" Fairy Monster\nCannot be Summoned while you control a monster. During the Main Phase, if you control no other monster (Quick Effect): You can Tribute this card; return all cards in the Spell/Trap Zone to the hand except \"Domestic Underworld\". You can only use the previous effect of \"Tove in the Wild\" once per turn. If this card is sent to the GY: Return this card to the Extra Deck, also, add 1 \"Tove, The Domesticated\" from your Deck to the hand, then send it to the GY."

| Clause / Requirement | Implementation / Callback | Status | Line # | Analysis & Proposed Fix |
| --- | --- | --- | --- | --- |
| Materials: "Tove, The Domesticated" + 1 "Domestica" Fairy | `AddFusionProcFun2` | Pass | L8-9 | Properly configured. |
| Cannot be Summoned while you control a monster | `e0`: `EFFECT_SPSUMMON_CONDITION` | Pass | L11-17, L45-47 | Correctly enforced. |
| Quick Effect: Tribute, return S/T cards to hand except "Domestic Underworld" | `e1`: `EFFECT_TYPE_QUICK_O` (`s.rthcon`, `s.rthcost`, `s.rthtg`, `s.rthop`) | Pass | L19-30, L48-69 | Filters `LOCATION_SZONE` excluding "Domestic Underworld" (259265448). |
| Trigger: Return to Extra Deck, search Tove, send to GY | `e2`: `EVENT_TO_GRAVE` (`s.rettg`, `s.retop`) | Pass | L32-40, L73-96 | Correctly executed. |

---

### 6. CARD-0081: Remembrance of the Melody (Passcode: 216620496)
- **Script Path**: `public/CCG Downloads/CCG_Scripts/c216620496.lua`
- **Text**: "Target up to 3 Spells/Traps in your banishment, except \"Remembrance of the Melody\"; return them to the GY. If a Spell/Trap(s) in your possession is banished, while this card is in your GY: You can banish this card, then target 1 Spell/Trap in your banishment, except \"Remembrance of the Melody\"; add it to your hand. You can only use 1 \"Remembrance of the Melody\" effect per turn, and only once that turn."

| Clause / Requirement | Implementation / Callback | Status | Line # | Analysis & Proposed Fix |
| --- | --- | --- | --- | --- |
| Target up to 3 banished S/T -> return to GY | `e1`: `EFFECT_TYPE_ACTIVATE` (`s.gytg`, `s.gyop`) | Pass | L6-15, L31-47 | Correctly selects 1-3 banished Spells/Traps and sends to GY. |
| GY Trigger when S/T banished -> Banish self, target 1 banished S/T to hand | `e2`: `EVENT_REMOVE` (`s.thcon`, `s.thcost`, `s.thtg`, `s.thop`) | Pass | L17-29, L48-75 | Correctly checks owner possession, banishes self as cost, targets 1 banished S/T and adds to hand. |
| Shared HOPT across both effects | `e1:SetCountLimit(1, id)`, `e2:SetCountLimit(1, id)` | Pass | L12, L24 | Both effects use `id` as count code, sharing the single usage per turn. |

---

### 7. CARD-0082: Chaos Fusion (Passcode: 255277197)
- **Script Path**: `public/CCG Downloads/CCG_Scripts/c255277197.lua`
- **Text**: "Fusion Summon 1 LIGHT or DARK Fusion Monster from your Extra Deck, by banishing the Fusion Materials from your hand or field, but it cannot attack this turn. If your opponent controls a monster, you can also banish 1 LIGHT and/or 1 DARK monster from your GY when resolving this effect. If this card is in your GY, except the turn it was sent there: You can banish this card from your GY, then target 1 LIGHT and 1 DARK monster in your banishment; return them both to the GY. You can only use each effect of \"Chaos Fusion\" once per turn."

| Clause / Requirement | Implementation / Callback | Status | Line # | Analysis & Proposed Fix |
| --- | --- | --- | --- | --- |
| Fusion Summon LIGHT/DARK by banishing from hand/field (or GY if opponent controls monster) | `e1`: `EFFECT_TYPE_ACTIVATE` (`s.fustg`, `s.fusop`) | Pass | L5-15, L51-101 | Correctly uses `FCheckAdditional` (`s.fcheck`) to restrict GY materials to at most 1 LIGHT and 1 DARK. Applies `EFFECT_CANNOT_ATTACK`. |
| GY Effect: Banish self, return 1 LIGHT and 1 DARK banished monster to GY | `e2`: `EFFECT_TYPE_IGNITION` (`s.retcon`, `s.retcost`, `s.rettg`, `s.retop`) | Confirmed Issue | L129 | `if #g==2` in `retop` causes 0 cards to return to GY if 1 target leaves banishment before resolution. **Fix**: Return remaining valid target (`#g > 0`). |
| Except the turn sent to GY | `s.retcon`: `GetTurnID() ~= Duel.GetTurnCount()` | Pass | L103 | Correctly matches standard `aux.exccon`. |

---

### 8. CARD-0083: Ursarctic Mikailus (Passcode: 245378354)
- **Script Path**: `public/CCG Downloads/CCG_Scripts/c245378354.lua`
- **Text**: "During the Main Phase (Quick Effect): You can Tribute 1 other Level 7 or higher monster from your hand; Special Summon this card from your hand, also, you cannot Special Summon for the rest of this turn, except monsters with a Level. If this card is Special Summoned: You can Set 1 \"Ursarctic\" Spell/Trap from your Deck, and if you do, it can be activated this turn. If this card is sent to the GY or banishment to activate an \"Ursarctic\" effect: You can draw 1 card. You can only use each effect of \"Ursarctic Mikailus\" once per turn."

| Clause / Requirement | Implementation / Callback | Status | Line # | Analysis & Proposed Fix |
| --- | --- | --- | --- | --- |
| Quick Effect: Tribute Lv7+ monster from hand, Special Summon self, restriction | `e1`: `EFFECT_TYPE_QUICK_O` (`s.spcost`, `s.spop`) | Pass | L10-22, L65-103 | Correctly checks Main Phase, applies substitution cost from Leoship/Departure/Big Dipper, registers level restriction. |
| Special Summoned: Set 1 Ursarctic S/T, can be activated this turn | `e2`: `EVENT_SPSUMMON_SUCCESS` (`s.settg`, `s.setop`) | Confirmed Issue | L116-128 | `s.setop` only applies `ACT_IN_SET_TURN` to Quick-Play Spells or Traps, failing to allow Continuous/Field Spells Set by this effect to be activated this turn. **Fix**: Allow activation for all S/T types. |
| Sent to GY/banishment for Ursarctic effect: Draw 1 | `e3`/`e4`: `EVENT_TO_GRAVE` / `EVENT_REMOVE` (`s.drcon`, `s.drop`) | Confirmed Issue | L141 | `s.drop` checks `e:GetHandler():IsRelateToEffect(e)`. If Mikailus leaves GY/banishment before resolution, draw is cancelled. **Fix**: Remove `IsRelateToEffect` check. |

---

### 9. CARD-0084: Ursarctic Megailus (Passcode: 218837030)
- **Script Path**: `public/CCG Downloads/CCG_Scripts/c218837030.lua`
- **Text**: "During the Main Phase (Quick Effect): You can Tribute 1 other Level 7 or higher monster from your hand; Special Summon this card from your hand, also, you cannot Special Summon for the rest of this turn, except monsters with a Level. If this card is Special Summoned: You can target 1 monster your opponent controls; destroy it. If this card is sent to the GY or banishment to activate an \"Ursarctic\" effect: You can draw 1 card. You can only use each effect of \"Ursarctic Megailus\" once per turn."

| Clause / Requirement | Implementation / Callback | Status | Line # | Analysis & Proposed Fix |
| --- | --- | --- | --- | --- |
| Quick Effect: Tribute Lv7+ monster from hand, Special Summon self, restriction | `e1`: `EFFECT_TYPE_QUICK_O` (`s.spcost`, `s.spop`) | Pass | L9-22, L65-103 | Correctly implemented with substitution cost support. |
| Special Summoned: Target & destroy 1 opponent's monster | `e2`: `EVENT_SPSUMMON_SUCCESS` (`s.destg`, `s.desop`) | Pass | L24-33, L104-116 | Correctly targets and destroys opponent's monster. |
| Sent to GY/banishment for Ursarctic effect: Draw 1 | `e3`/`e4`: `EVENT_TO_GRAVE` / `EVENT_REMOVE` (`s.drcon`, `s.drop`) | Confirmed Issue | L128 | `s.drop` checks `e:GetHandler():IsRelateToEffect(e)`. If Megailus leaves GY/banishment before resolution, draw is cancelled. **Fix**: Remove `IsRelateToEffect` check. |

---

### 10. CARD-0085: Ursarctic Leoship (Passcode: 247831166)
- **Script Path**: `public/CCG Downloads/CCG_Scripts/c247831166.lua`
- **Text**: "When this card is activated: You can add 1 \"Ursarctic\" card from your Deck to your hand. During your Main Phase: You can Special Summon 1 \"Ursarctic\" monster from your hand. If your \"Ursarctic\" monster would Tribute a monster(s) to activate its effect, you can banish 1 Level 7 or higher \"Ursarctic\" monster from your hand, field or GY instead. You can only use each effect of \"Ursarctic Leoship\" once per turn."

| Clause / Requirement | Implementation / Callback | Status | Line # | Analysis & Proposed Fix |
| --- | --- | --- | --- | --- |
| On Activation: Search 1 Ursarctic card | `e1`: `EFFECT_TYPE_ACTIVATE` (`s.thop`) | Suspected Issue | L7-14 | `e1` lacks `e1:SetTarget(s.thtg)`, allowing activation when Deck has 0 targets. **Fix**: Add target function checking Deck. |
| Ignition: Special Summon 1 Ursarctic monster from hand | `e2`: `EFFECT_TYPE_IGNITION` (`s.sptg`, `s.spop`) | Pass | L16-25, L50-68 | Correctly checks Main Phase and Special Summons from hand. |
| Replacement effect: Banish Lv7+ Ursarctic monster instead of Tributing | `e3`: `EFFECT_TYPE_FIELD` (`s.repfilter`) | Pass | L27-34, L69-71 | Registers custom flag code `247831166` read by Ursarctic monsters. |

---

### 11. CARD-0086: Ursarctic Octantis (Passcode: 235051048)
- **Script Path**: `public/CCG Downloads/CCG_Scripts/c235051048.lua`
- **Text**: "Cannot be Synchro Summoned. Must be Special Summoned (from your Extra Deck) by sending 2 monsters you control with a Level difference of 1 to the GY (1 Tuner and 1 non-Tuner). You can Tribute 1 Level 8 \"Ursarctic\" monster from your hand or field and this card; Special Summon 1 Level 7 \"Ursarctic\" Synchro Monster from your Extra Deck, ignoring its Summoning conditions. If an \"Ursarctic\" card you control is destroyed by battle or card effect: You can banish this card from your GY; Special Summon 1 \"Ursarctic\" monster from your hand or GY. You can only use this effect of \"Ursarctic Octantis\" once per turn."

| Clause / Requirement | Implementation / Callback | Status | Line # | Analysis & Proposed Fix |
| --- | --- | --- | --- | --- |
| Cannot be Synchro Summoned & Special Summon procedure | `e0`, `e1`: `EFFECT_SPSUMMON_PROC` (`s.sprcon`, `s.sprtg`, `s.sprop`) | Pass | L10-26, L52-105 | Correctly requires 2 monsters with Level difference 1 (1 Tuner + 1 non-Tuner). |
| Tribute Lv8 Ursarctic & self -> Special Summon Lv7 Ursarctic Synchro (ignoring conditions) | `e2`: `EFFECT_TYPE_IGNITION` (`s.upcost`, `s.uptg`, `s.upop`) | Pass | L28-36, L128-155 | Correctly checks materials, substitution, and passes `reset_proc = true` to ignore conditions. |
| GY Trigger on Ursarctic destruction: Banish self, Special Summon Ursarctic from hand/GY | `e3`: `EVENT_DESTROYED` (`s.gyspcon`, `s.gyspcost`, `s.gysptg`, `s.gyspop`) | Pass | L38-50, L156-183 | Correctly checks previous control/location, banishes as cost, and Special Summons from hand/GY. |

---

### 12. CARD-0087: Ursarctic Hextanius (Passcode: 244921711)
- **Script Path**: `public/CCG Downloads/CCG_Scripts/c244921711.lua`
- **Text**: "Cannot be Synchro Summoned. Must be Special Summoned (from your Extra Deck) by sending 2 \"Ursarctic\" monsters you control with a Level difference of 6 to the GY. For the Special Summon of an \"Ursarctic\" Synchro Monster, this card can be treated as level 7 or 8 and can also be treated as a Non-Tuner. You can only use each of the following effects of \"Ursarctic Hextanius\" once per turn. If this card is Special Summoned: You can Special Summon 1 WATER Monster with either 700 ATK or 700 DEF from your Deck. You can banish this card from your GY; shuffle up to 3 other \"Ursarctic\" cards from your GY or banishment into the deck, then draw 1 card."

| Clause / Requirement | Implementation / Callback | Status | Line # | Analysis & Proposed Fix |
| --- | --- | --- | --- | --- |
| Special Summon procedure (Level diff 6) | `e1`: `EFFECT_SPSUMMON_PROC` | Pass | L15-23, L65-92 | Correctly checks 2 Ursarctic monsters with Level diff 6. |
| Rule Clause: Treated as Lv7/8 and Non-Tuner for Ursarctic Synchro | `s.matlevels`, `s.isnontuner` | Suspected Issue | L47-61 | Defined as custom helper functions called by other custom scripts, but no `EFFECT_NONTUNER` registered on `c` itself. |
| Special Summoned: Special Summon 1 WATER monster with 700 ATK/DEF from Deck | `e2`: `EVENT_SPSUMMON_SUCCESS` (`s.dsptg`, `s.dspop`) | Pass | L25-34, L93-109 | Correctly checks WATER monster with ATK 700 or DEF 700. |
| Banish self from GY: Shuffle up to 3 Ursarctic cards, draw 1 | `e3`: `EFFECT_TYPE_IGNITION` (`s.tdcost`, `s.tdtg`, `s.tdop`) | Pass | L36-45, L110-136 | Correctly banishes as cost, shuffles 1-3 cards, and draws 1. |

---

### 13. CARD-0088: Ursarctic Nordbar (Passcode: 249093610)
- **Script Path**: `public/CCG Downloads/CCG_Scripts/c249093610.lua`
- **Text**: "Cannot be Synchro Summoned. Must be Special Summoned (from your Extra Deck) by sending 2 monsters you control with a Level difference of 7 to the GY (1 Level 8 or higher Tuner and 1 non-Tuner Synchro Monster). You can only use each of the following effects of \"Ursarctic Nordbar\" once per turn. If this card is Special Summoned: You can Special Summon 1 \"Ursarctic\" monster from your GY. During your opponent's Standby Phase: You can add 1 \"Ursarctic\" monster from your Deck to your hand. When a card or effect is activated (Quick Effect): You can negate the activation, and if you do, destroy that card."

| Clause / Requirement | Implementation / Callback | Status | Line # | Analysis & Proposed Fix |
| --- | --- | --- | --- | --- |
| Special Summon procedure (Level diff 7, Lv8+ Tuner + Non-Tuner Synchro) | `e1`: `EFFECT_SPSUMMON_PROC` (`s.fselect`) | Pass | L15-23, L85-121 | Correctly checks Lv8+ Tuner and Non-Tuner Synchro with Level diff 7. |
| Special Summoned: Special Summon 1 Ursarctic monster from GY | `e2`: `EVENT_SPSUMMON_SUCCESS` (`s.gysptg`, `s.gyspop`) | Pass | L25-34, L122-137 | Special Summons from GY correctly. |
| Opponent's Standby Phase: Search 1 Ursarctic monster from Deck | `e3`: `EVENT_PHASE+PHASE_STANDBY` (`s.thcon`, `s.thtg`, `s.thop`) | Pass | L36-46, L138-156 | Correctly triggers on opponent's Standby Phase. |
| Quick Effect: Negate activation & destroy | `e4`: `EVENT_CHAINING` (`s.negcon`, `s.negtg`, `s.negop`) | Pass | L48-59, L157-171 | Negates chain activation and destroys card. |

---

### 14. CARD-0089: Carina of the Eldoran System (Passcode: 228686743)
- **Script Path**: `public/CCG Downloads/CCG_Scripts/c228686743.lua`
- **Text**: "(This card is also treated as a \"Galactica\" card.)\nGalactic Coordinates: (l = 62.3°, b = +45.8°, r = 4921 ly).\n\"From the Wellspring of Eldora in the towering spires of Zephorion Prime...\"\n— The Hallowed Scripts of the Ataxia, Verse IX, Line 27"

| Clause / Requirement | Implementation / Callback | Status | Line # | Analysis & Proposed Fix |
| --- | --- | --- | --- | --- |
| Normal Monster text / flavor text | Empty `initial_effect` | Pass | L3-4 | Carina is a Normal Monster (`cardTypes`: ["Normal"]). Empty `initial_effect` is correct. |

---

### 15. CARD-0090: Branching to Guidance (Passcode: 222257685)
- **Script Path**: `public/CCG Downloads/CCG_Scripts/c222257685.lua`
- **Text**: "Reveal 1 monster in your hand that can be Normal Summoned/Set; Special Summon 1 \"Guidance Token\" in Defense Position, with the same Type, Attribute, Level, ATK, and DEF as the revealed monster, also, its name becomes the revealed monster's name in addition to its original name. You can banish this card from your GY, then target 1 monster in your GY that can be Normal Summoned/Set; Special Summon 1 \"Guidance Token\" in Defense Position, with the same Type, Attribute, Level, ATK, and DEF as the targeted monster, also, its name becomes the targeted monster's name in addition to its original name. You can only use 1 \"Branching to Guidance\" effect per turn, and only once that turn."

| Clause / Requirement | Implementation / Callback | Status | Line # | Analysis & Proposed Fix |
| --- | --- | --- | --- | --- |
| Activate: Reveal hand monster -> Special Summon Guidance Token copying stats/name | `e1`: `EFFECT_TYPE_ACTIVATE` (`s.tkcost`, `s.tkop`) | Pass | L8-17, L42-95 | Correctly checks `IsSummonableCard()`, reveals, and applies code/race/attr/level/atk/def to Token. |
| GY Effect: Banish self, target GY monster -> Special Summon Guidance Token copying stats/name | `e2`: `EFFECT_TYPE_IGNITION` (`s.gytg`, `s.gyop`) | Pass | L19-30, L96-112 | Correctly checks GY target and creates token with copied stats. |
| Shared HOPT limit | `e1:SetCountLimit(1, id)`, `e2:SetCountLimit(1, id)` | Pass | L13, L25 | Uses `id` for both effects. Shared HOPT limit works correctly. |

---

### 16. CARD-0092: Rigel the Thousand-Armed (Passcode: 215853847)
- **Script Path**: `public/CCG Downloads/CCG_Scripts/c215853847.lua`
- **Text**: "2+ Effect Monsters\nCannot be destroyed by battle or card effects, also, your opponent takes no damage from battles involving this card. If this card battles, neither player can activate cards or effects until the end of the Damage Step. During your Main Phase: You can activate this effect; for the rest of this turn, this card gains ATK equal to the combined Link Rating of the monsters used to Link Summon this card x1000, also, it can attack all monsters your opponent controls, once each. For the rest of this turn, after this effect resolves, other monsters you control cannot attack (even if this card leaves the field). You can only use this effect of \"Rigel the Thousand-Armed\" once per turn."

| Clause / Requirement | Implementation / Callback | Status | Line # | Analysis & Proposed Fix |
| --- | --- | --- | --- | --- |
| Indestructible by battle & effects, opponent takes no battle damage | `e1`, `e2`, `e3`: `EFFECT_NO_BATTLE_DAMAGE` | Pass | L8-21 | `e3:SetCode(EFFECT_NO_BATTLE_DAMAGE)` correctly prevents opponent taking battle damage. |
| Neither player can activate cards/effects when it battles | `e4`: `EFFECT_CANNOT_ACTIVATE` (`s.actcon`, `s.aclimit`) | Pass | L23-31, L43-49 | Correctly locks activations during battles involving Rigel. |
| Ignition: Gain ATK equal to material Link Rating x1000, attack all monsters, restrict other attackers | `e5`: `EFFECT_TYPE_IGNITION` (`s.atktg`, `s.atkop`) | Suspected Issue | L60 | `c:GetMaterial():GetSum(...)` is evaluated dynamically in `atkop`. If tokens or non-extant cards were used as Link material, `GetMaterial()` can be incomplete or return wrong sum. **Fix**: Store material Link rating sum in flag/label during Link Summon. |

---

### 17. CARD-0093: Prophecy of Infernos (Passcode: 229327103)
- **Script Path**: `public/CCG Downloads/CCG_Scripts/c229327103.lua`
- **Text**: "Target 1 FIRE monster you control that was Special Summoned from the Extra Deck; return that target to the Extra Deck, then Special Summon this card from your hand, and if you do, add 1 Spell/Trap from your Deck to your hand that lists \"FIRE\" in its text. You can only use this effect of \"Prophecy of Infernos\" once per turn."

| Clause / Requirement | Implementation / Callback | Status | Line # | Analysis & Proposed Fix |
| --- | --- | --- | --- | --- |
| Target 1 FIRE Extra Deck monster -> Return to Extra Deck, Special Summon self, search FIRE S/T | `e1`: `EFFECT_TYPE_IGNITION` (`s.sptg`, `s.spop`) | Confirmed Issue | L5-9, L27-34 | `thfilter` hardcodes 3 specific passcodes in `search_codes`. Misses any other S/T listing "FIRE". **Fix**: Dynamically check text / `ListsAttribute(ATTRIBUTE_FIRE)`. |
| Activation Condition Mismatch | `s.sptg` checks search target in Deck at `chk==0` | Confirmed Issue | L40 | `sptg` requires a matching S/T in Deck at `chk==0` to activate, whereas PSCT "and if you do, add..." makes search optional. **Fix**: Do not make search target in Deck mandatory at `chk==0`. |

---

### 18. CARD-0094: Prophecy of Waterfalls (Passcode: 251058567)
- **Script Path**: `public/CCG Downloads/CCG_Scripts/c251058567.lua`
- **Text**: "Target 1 WATER monster you control that was Special Summoned from the Extra Deck; return that target to the Extra Deck, then Special Summon this card from your hand, and if you do, add 1 Spell/Trap from your Deck to your hand that lists \"WATER\" in its text. You can only use this effect of \"Prophecy of Waterfalls\" once per turn."

| Clause / Requirement | Implementation / Callback | Status | Line # | Analysis & Proposed Fix |
| --- | --- | --- | --- | --- |
| Target 1 WATER Extra Deck monster -> Return to Extra Deck, Special Summon self, search WATER S/T | `e1`: `EFFECT_TYPE_IGNITION` (`s.sptg`, `s.spop`) | Confirmed Issue | L5-17, L35-42 | `thfilter` hardcodes 11 specific passcodes. **Fix**: Use dynamic check. |
| Activation Condition Mismatch | `s.sptg` checks search target in Deck at `chk==0` | Confirmed Issue | L48 | Prevents activation if Deck has 0 matching S/Ts. **Fix**: Allow activation even if 0 matching S/Ts in Deck. |

---

### 19. CARD-0095: Prophecy of Boulders (Passcode: 223558392)
- **Script Path**: `public/CCG Downloads/CCG_Scripts/c223558392.lua`
- **Text**: "Target 1 EARTH monster you control that was Special Summoned from the Extra Deck; return that target to the Extra Deck, then Special Summon this card from your hand, and if you do, add 1 Spell/Trap from your Deck to your hand that lists \"EARTH\" in its text. You can only use this effect of \"Prophecy of Boulders\" once per turn."

| Clause / Requirement | Implementation / Callback | Status | Line # | Analysis & Proposed Fix |
| --- | --- | --- | --- | --- |
| Target 1 EARTH Extra Deck monster -> Return to Extra Deck, Special Summon self, search EARTH S/T | `e1`: `EFFECT_TYPE_IGNITION` (`s.sptg`, `s.spop`) | Confirmed Issue | L5, L27 | `s.search_codes={}` IS EMPTY! `thfilter` ALWAYS RETURNS FALSE! `sptg` at `chk==0` ALWAYS RETURNS FALSE! **Card is 100% UNPLAYABLE!** **Fix**: Populate `search_codes` or replace with dynamic text check. |

---

### 20. CARD-0096: Prophecy of Storms (Passcode: 223592011)
- **Script Path**: `public/CCG Downloads/CCG_Scripts/c223592011.lua`
- **Text**: "Target 1 WIND monster you control that was Special Summoned from the Extra Deck; return that target to the Extra Deck, then Special Summon this card from your hand, and if you do, add 1 Spell/Trap from your Deck to your hand that lists \"WIND\" in its text. You can only use this effect of \"Prophecy of Storms\" once per turn."

| Clause / Requirement | Implementation / Callback | Status | Line # | Analysis & Proposed Fix |
| --- | --- | --- | --- | --- |
| Target 1 WIND Extra Deck monster -> Return to Extra Deck, Special Summon self, search WIND S/T | `e1`: `EFFECT_TYPE_IGNITION` (`s.sptg`, `s.spop`) | Confirmed Issue | L5-8, L26-33 | Hardcodes only 2 passcodes in `search_codes`. |
| Activation Condition Mismatch | `s.sptg` checks search target in Deck at `chk==0` | Confirmed Issue | L39 | Requires S/T in Deck at activation time. **Fix**: Make search check non-mandatory at `chk==0`. |

---

### 21. CARD-0097: Prophecy of Rays (Passcode: 244920555)
- **Script Path**: `public/CCG Downloads/CCG_Scripts/c244920555.lua`
- **Text**: "Target 1 LIGHT monster you control that was Special Summoned from the Extra Deck; return that target to the Extra Deck, then Special Summon this card from your hand, and if you do, add 1 Spell/Trap from your Deck to your hand that lists \"LIGHT\" in its text. You can only use this effect of \"Prophecy of Rays\" once per turn."

| Clause / Requirement | Implementation / Callback | Status | Line # | Analysis & Proposed Fix |
| --- | --- | --- | --- | --- |
| Target 1 LIGHT Extra Deck monster -> Return to Extra Deck, Special Summon self, search LIGHT S/T | `e1`: `EFFECT_TYPE_IGNITION` (`s.sptg`, `s.spop`) | Confirmed Issue | L5-19, L37-44 | Hardcodes 13 passcodes in `search_codes`. |
| Activation Condition Mismatch | `s.sptg` checks search target in Deck at `chk==0` | Confirmed Issue | L50 | Requires S/T in Deck at activation time. **Fix**: Do not require S/T target in Deck at `chk==0`. |

---

### 22. CARD-0098: Prophecy of Shadows (Passcode: 243920845)
- **Script Path**: `public/CCG Downloads/CCG_Scripts/c243920845.lua`
- **Text**: "Target 1 DARK monster you control that was Special Summoned from the Extra Deck; return that target to the Extra Deck, then Special Summon this card from your hand, and if you do, add 1 Spell/Trap from your Deck to your hand that lists \"DARK\" in its text. You can only use this effect of \"Prophecy of Shadows\" once per turn."

| Clause / Requirement | Implementation / Callback | Status | Line # | Analysis & Proposed Fix |
| --- | --- | --- | --- | --- |
| Target 1 DARK Extra Deck monster -> Return to Extra Deck, Special Summon self, search DARK S/T | `e1`: `EFFECT_TYPE_IGNITION` (`s.sptg`, `s.spop`) | Confirmed Issue | L5-16, L34-41 | Hardcodes 10 passcodes in `search_codes`. |
| Activation Condition Mismatch | `s.sptg` checks search target in Deck at `chk==0` | Confirmed Issue | L47 | Requires S/T in Deck at activation time. **Fix**: Do not require S/T target in Deck at `chk==0`. |

---

### 23. CARD-0099: Stellaer of the Swamp (Passcode: 259586445)
- **Script Path**: `public/CCG Downloads/CCG_Scripts/c259586445.lua`
- **Text**: "2 Level 9 Dragon monsters\nIf you control no Xyz Monsters, you can also Xyz Summon this card using 1 Level 9 \"Stellaer\" monster you control. During the Main Phase, or, if this card is Xyz Summoned: You can target 1 face-up monster on the field and detach 2 Xyz material from this card; destroy that target. If this card has no Xyz materials: You can destroy this card, then draw 1 card."

| Clause / Requirement | Implementation / Callback | Status | Line # | Analysis & Proposed Fix |
| --- | --- | --- | --- | --- |
| Alternative Xyz Summon procedure using 1 Lv9 Stellaer | `aux.AddXyzProcedure` (`s.xyzalt`) | Confirmed Issue | L50 | Signature mismatch: `s.xyzalt(c, e, tp, xyzc)` receives `e=tp` (number) and `tp=xyzc`, causing `IsExistingMatchingCard` to receive `tp=nil` and **CRASH**! **Fix**: Change signature to `s.xyzalt(c, tp, xyzc)` and pass `c` as exclude parameter in `IsExistingMatchingCard(..., tp, LOCATION_MZONE, 0, 1, c)`. |
| Quick Effect in Main Phase OR Trigger on Xyz Summon: Detach 2, destroy face-up monster | `e1`: `QUICK_O`, `e2`: `SPSUMMON_SUCCESS` | Pass | L11-35, L54-78 | Correctly implements Quick Effect in Main Phase and Trigger on Xyz Summon, detaching 2 materials to destroy target. |
| Ignition: If no Xyz materials, destroy self then draw 1 | `e3`: `EFFECT_TYPE_IGNITION` (`s.drcon`, `s.drtg`, `s.drop`) | Pass | L37-45, L79-94 | Checks `GetOverlayCount()==0`, destroys self, then draws 1. |

---

### 24. CARD-0100: Sustained Succubus Saria (Passcode: 219419648)
- **Script Path**: `public/CCG Downloads/CCG_Scripts/c219419648.lua`
- **Text**: "1 \"Stain\" monster + 1 LIGHT or DARK \"Stain\" monster\nCannot be destroyed by battle or card effects, also your opponent takes any battle damage you would have taken from battles involving this card. You can only use each of the following effects of \"Sustained Succubus Saria\" once per turn. If this card is Fusion Summoned: You can add 1 \"Stain\" card from your Deck, GY, or banishment to your hand. When an attack is declared involving a \"Stain\" monster you control and an opponent's monster: You can shuffle 1 card on the field and up to 1 \"Stain\" card in your GY into the Deck, also you can make this card's ATK become 0."

| Clause / Requirement | Implementation / Callback | Status | Line # | Analysis & Proposed Fix |
| --- | --- | --- | --- | --- |
| Fusion Materials: 1 "Stain" + 1 LIGHT/DARK "Stain" | `AddFusionProcFun2` (`s.fusfilter`) | Pass | L8, L50-52 | Correctly configures Fusion materials. |
| Battle & Effect Indestructibility, Reflect Battle Damage | `e1`, `e2`, `e3`: `EFFECT_REFLECT_BATTLE_DAMAGE` | Pass | L9-24 | Correctly sets battle/effect indestructibility and reflects battle damage to opponent. |
| Fusion Summoned: Add 1 Stain card from Deck/GY/Banishment | `e4`: `EVENT_SPSUMMON_SUCCESS` (`s.thcon`, `s.thtg`, `s.thop`) | Pass | L26-36, L53-71 | Correctly checks Fusion Summon, searches Stain card from Deck, GY, or banishment. |
| Attack declaration involving Stain monster & opponent's monster: Shuffle cards & change ATK to 0 | `e5`: `EVENT_ATTACK_ANNOUNCE` (`s.tdcon`, `s.tdtg`, `s.tdop`) | Pass | L38-48, L72-113 | Correctly checks attack declaration, shuffles 1 field card and optional GY Stain card, then optionally sets ATK to 0. |

---

### 25. CARD-0101: A Stainless Story (Passcode: 245970073)
- **Script Path**: `public/CCG Downloads/CCG_Scripts/c245970073.lua`
- **Text**: "If your opponent controls more cards than you: Send 1 \"Stain\" monster from your Deck or face-up in your opponent's Deck to the GY; this effect becomes the sent monster's effect if it is Normal or Special Summoned. You can banish this card from your GY; each player draws 1 card. You can only activate 1 \"A Stainless Story\" per turn."

| Clause / Requirement | Implementation / Callback | Status | Line # | Analysis & Proposed Fix |
| --- | --- | --- | --- | --- |
| Condition: Opponent controls more cards than you | `s.actcon` | Pass | L43-45 | Correctly checks `GetFieldGroupCount(tp, 0, LOCATION_ONFIELD) > GetFieldGroupCount(tp, LOCATION_ONFIELD, 0)`. |
| Cost: Send 1 Stain monster from Deck or face-up in opponent's Deck | `s.tgcost` (`s.copy_codes`) | Suspected Issue | L46-59 | Uses `GLOBALFLAG_DECK_REVERSE_CHECK` and sends target as cost. Hardcodes `copy_codes` for Bria, Dante, Feness, Rollo, Silas. |
| Effect: Become sent monster's on-summon effect | `s.tgop` (`s.briaop`, `s.danteop`, `s.fenessop`, `s.rolloop`, `s.silasop`) | Suspected Issue | L63-175 | `s.silasop` does not shuffle `sc` back into Deck unlike the other 4 monster handlers. **Fix**: Add `SendtoDeck(sc)` in `silasop` if consistent with Stain archetype design. |
| GY Effect: Banish self, both players draw 1 card | `e2`: `EFFECT_TYPE_IGNITION` (`s.drtg`, `s.drop`) | Pass | L33-41, L176-183 | Correctly banishes self as cost and causes both players to draw 1 card. |
| Activation HOPT limit | `e1:SetCountLimit(1, id+EFFECT_COUNT_CODE_OATH)` | Pass | L26 | Applies `EFFECT_COUNT_CODE_OATH` for 1 activation per turn. |

---

I confirm that I modified no files.

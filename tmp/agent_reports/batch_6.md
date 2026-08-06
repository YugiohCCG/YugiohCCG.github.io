# Semantic Effect Audit Report: Batch 6 (Cards 127 - 151)

I have completed the semantic audit of the 25 custom cards assigned in `batch_6.json`, comparing the intended logic derived from their text to the actual implementations found in `public/CCG Downloads/CCG_Scripts/`. 

Below is the exhaustive clause-by-clause analysis of all findings. 

### Core Systemic Issues Discovered

1. **Reversed Summon Limits:** Multiple `Stellaer` monsters use `EFFECT_CANNOT_SPECIAL_SUMMON` with a target function checking for a specific attribute (e.g., `ATTRIBUTE_NATURE`, `ATTRIBUTE_ICE`) without negating the condition (`not`). This results in the engine *blocking* the intended attribute and *allowing* everything else, directly breaking the intended lock.
2. **Improper Reflected Damage Modification:** Cards like "To Proto Taxis" and "Ektelestis Gia Taxis" attempt to halve the battle damage the opponent takes after reflecting it by using `EFFECT_REFLECT_BATTLE_DAMAGE` alongside `EFFECT_CHANGE_BATTLE_DAMAGE` set to `TargetRange(1,0)`. Because the damage is reflected, the controller takes 0, so halving the controller's damage does nothing, while the opponent takes full damage.
3. **Invalid Trigger Effect Targeting (`CheckActivateEffect`):** "Priestess of Nephthys" uses `CheckActivateEffect` to force the resolution of a monster's delayed Trigger Effect. This function is strictly for primary Spell/Trap activation effects or Pendulum Scale activations, and it will return `nil` for monster Trigger Effects.
4. **Missing Targeting Linkage:** "Sacred Feather of Nephthys" uses `Duel.SelectMatchingCard` to select a Ritual Monster in hand, but checks `rc:IsRelateToEffect(e)` without ever using `Duel.SetTargetCard()` or `e:SetLabelObject()`. The check will always fail, making the card unable to Special Summon.
5. **Printed vs. Base ATK Checks:** Multiple cards use `c:GetTextAttack()` to determine the "original ATK" when evaluating stat discrepancies. PSCT rules dictate that "original ATK" corresponds to `c:GetBaseAttack()`.

---

### Card 127: Priestess of Nephthys (211964444)
`public/CCG Downloads/CCG_Scripts/c211964444.lua`

| Clause | Script Mapping (Line #) | Analysis & Issues | Status |
| :--- | :--- | :--- | :--- |
| **1.** You can Ritual Summon this card with any "Nephthys" Ritual Spell. | `c:EnableReviveLimit()` (L6) | Native implementation for Ritual Monsters. | Confirmed (Correct) |
| **2.** If this card is Special Summoned: You can reveal 1 "Nephthys" monster in your Deck; destroy it, then apply that card's effect that activates during the Standby Phase. | `e1` (L8-18), `s.descost` (L35-42), `s.desop` (L47-62) | **Issue:** The script reveals the card as a cost (L38-41). Upon resolution, it uses `tc:CheckActivateEffect` (L52) to forcefully trigger the effect. For Monster Trigger Effects, this function evaluates to `nil`, effectively bypassing the intended effect application entirely. | **Confirmed Critical** |
| **3.** You can shuffle this card from your hand into the Deck; add 1 "Nephthys" Spell/Trap Card from your Deck or GY to your hand. | `e2` (L20-29), `s.thcost` (L63-67), `s.thop` (L75-81) | The cost correctly returns to the deck natively. The search cleanly targets and adds standard "Nephthys" Spells/Traps. | Confirmed (Correct) |
| **4.** You can only use each effect of "Priestess of Nephthys" once per turn. | `e1:SetCountLimit` (L14), `e2:SetCountLimit` (L25) | Properly registers a unique HOPT using standard `id` and `id+100` offsets. | Confirmed (Correct) |

**Proposed Fix:** In `s.desop`, instead of `CheckActivateEffect`, manually register the Standby Phase trigger or emulate its effects directly if the effect pool is closed. 

### Card 128: Sacred Feather of Nephthys (216532402)
`public/CCG Downloads/CCG_Scripts/c216532402.lua`

| Clause | Script Mapping (Line #) | Analysis & Issues | Status |
| :--- | :--- | :--- | :--- |
| **1.** This card can be used to Ritual Summon... you can Tribute 1 "Nephthys" monster form your Deck instead. | `e1` (L10-17), `s.ritop` (L77-113) | **Issue:** The selected Ritual Monster (`rc`) is checked via `rc:IsRelateToEffect(e)` (L110) but it was never targeted (selected at resolution). The summon permanently fails. **Issue:** Tributing from the Deck (L101) misses `REASON_RELEASE` which breaks "Nephthys" destruction/tribute triggers. | **Confirmed Critical** |
| **2.** If a card is destroyed while you control [specific monsters]: You can banish this card from your GY; destroy 1 card you control, then, place 1 "Nephthys" Continuous Trap from your Deck... | `e2` (L19-31), `s.plcon` (L117-119), `s.plop` (L132-145) | Condition and field location constraints natively align with the mechanics. | Confirmed (Correct) |
| **3.** You can only use the previous effect... once per turn. | `e2:SetCountLimit(1,id)` (L26) | Hard Once Per Turn correctly tied to `e2`. | Confirmed (Correct) |

**Proposed Fix:** Remove the `rc:IsRelateToEffect(e)` check in `s.ritop`. Append `REASON_RELEASE` to the Deck material send reason.

### Card 129: Stellaer of the Frozen (259581666)
`public/CCG Downloads/CCG_Scripts/c259581666.lua`

| Clause | Script Mapping (Line #) | Analysis & Issues | Status |
| :--- | :--- | :--- | :--- |
| **1.** 2 Level 9 Dragon monsters | `aux.AddXyzProcedure` (L8) | Standard Xyz condition format. | Confirmed (Correct) |
| **2.** If you control no Xyz Monsters, you can also Xyz Summon this card using 1 Level 9 "Stellaer" monster you control. | `s.xyzalt` (L45-48) | The alternate procedure accurately validates the `LOCATION_MZONE` absence of `TYPE_XYZ`. | Confirmed (Correct) |
| **3.** During the Main Phase, or, if this card is Xyz Summoned: You can target 1 face-up card on the field and detach 2 materials from this card; Set that target. | `e1` (L10-22), `e2` (L24-29), `s.setop` (L70-82) | Proper clone execution (`e2=e1:Clone()`) linking the Quick Effect and Trigger contexts accurately. | Confirmed (Correct) |
| **4.** If this card has no materials: You can destroy this card, then draw 1 card. | `e3` (L31-39), `s.drcon` (L83-85), `s.drop` (L92-98) | Execution safely respects the `GetOverlayCount()==0` parameter and sequence resolution. | Confirmed (Correct) |

### Card 4: Rage of Nephthys (256287781)
`public/CCG Downloads/CCG_Scripts/c256287781.lua`

| Clause | Script Mapping (Line #) | Analysis & Issues | Status |
| :--- | :--- | :--- | :--- |
| **1.** During your opponent's Main Phase: You can make all monsters your opponent currently controls lose ATK... | `e1` (L12-23), `s.atkop` (L48-72) | Accurately calculates the max ATK value dynamically and registers a debuff. Effectively checks for stat drops to zero prior to wiping the field. | Confirmed (Correct) |
| **2.** During your Main Phase: When your opponent activates a card or effect: You can shuffle 4 "Nephthys" cards from your GY into the Deck; the activated effect becomes... | `e2` (L25-35), `s.chop` (L90-93), `s.repop` (L101-109) | Resolving rewritten effects works perfectly against the opposite perspective utilizing `p=1-tp` filtering. | Confirmed (Correct) |

### Card 5: To Proto Ousia (240299292)
`public/CCG Downloads/CCG_Scripts/c240299292.lua`

| Clause | Script Mapping (Line #) | Analysis & Issues | Status |
| :--- | :--- | :--- | :--- |
| **1.** If this card is Normal or Special Summoned: You can Special Summon 1 "Protogenic Essence Token"... | `e1` (L9-18), `e2` (L19-21), `s.tkop` (L47-52) | Custom Token generator operates cleanly with local ID `240299293` and custom `RACE_GALAXY` constant constraints. | Confirmed (Correct) |
| **2.** If this card is in your GY, because it was used as material for the Link Summon of a "To Proto" monster: You can banish this card... | `e3` (L23-34), `s.thcon` (L53-57), `s.thop` (L66-78) | **Issue (Ambiguous):** `r==REASON_LINK` (L55). The reason flag bitmask for material sends is technically `REASON_MATERIAL+REASON_LINK`. While `r==REASON_LINK` works in legacy scripts, newer standards utilize `r&REASON_LINK==REASON_LINK` or `e:GetHandler():IsReason(REASON_LINK)`. | Suspected Issue |

### Card 6: To Proto Archegoni (245400676)
`public/CCG Downloads/CCG_Scripts/c245400676.lua`

| Clause | Script Mapping (Line #) | Analysis & Issues | Status |
| :--- | :--- | :--- | :--- |
| **1.** You can only Link Summon "To Proto Archegoni" once per turn. | `e0` (L11-17), `s.linkregop` (L53-62) | **Issue:** It tracks the HOPT by applying a global continuous effect natively on `EVENT_SPSUMMON_SUCCESS`. Under OCG rules, if the summon is negated, the player shouldn't be able to retry. This implementation allows retries upon negation. | Suspected Issue |
| **2.** ...add 1 Spell/Trap from your Deck or GY to your hand that lists "To Proto" in its text or name. | `e1` (L19-29), `s.thfilter` (L70-72) | **Issue:** Evaluates `c:IsSetCard(SET_TO_PROTO)` only. This retrieves archetype cards but completely ignores generic cards that list "To Proto" in their text. | **Confirmed** |

**Proposed Fix:** Add `c:ListsArchetype(SET_TO_PROTO)` directly to `s.thfilter` validation logic.

### Card 7: Protogenesis (246524183)
`public/CCG Downloads/CCG_Scripts/c246524183.lua`

| Clause | Script Mapping (Line #) | Analysis & Issues | Status |
| :--- | :--- | :--- | :--- |
| **1.** Reveal 1 "To Proto" monster in your hand or Deck; if it can be Normal Summoned/Set, Special Summon it. Otherwise, banish it. | `e1` (L7-16), `s.revcost` (L27-35), `s.activate` (L45-66) | Uses standard deck manipulation parameters, cleanly evaluating if a card is physically `nsfilter` settable. | Confirmed (Correct) |
| **2.** ...and if you do, during the End Phase you lose LP equal to the total original ATK and DEF of each monster you control. | `s.lpop` (L70-79) | **Issue:** Script evaluates `c:GetTextAttack()` (L74) to pull the original ATK. "Original ATK" mechanically refers to `c:GetBaseAttack()`, which tracks runtime modifications (e.g., Megamorph). `GetTextAttack()` bypasses these rules. | **Confirmed** |

### Card 8: The Beginning (234729347)
`public/CCG Downloads/CCG_Scripts/c234729347.lua`

| Clause | Script Mapping (Line #) | Analysis & Issues | Status |
| :--- | :--- | :--- | :--- |
| **1.** If you Special Summon a Level 11 "To Proto" monster from hand/GY: Special Summon a Token | `e5` (L40-51), `s.tktg` (L93-98) | **Issue:** `e5` is flagged `EFFECT_TYPE_TRIGGER_F` (Mandatory). However, `s.tktg` returns `Duel.GetLocationCount(tp,LOCATION_MZONE)>0` inside the `chk==0` block. Mandatory trigger target blocks *must* return true unconditionally, or the engine errors/skips the chain block silently. | **Confirmed Critical** |

**Proposed Fix:** Replace the location capacity checking inside `chk==0` of `s.tktg` with `return true` unconditionally for mandatory triggers.

### Card 9: Protogenic Astral Cycle (232706629)
`public/CCG Downloads/CCG_Scripts/c232706629.lua`

| Clause | Script Mapping (Line #) | Analysis & Issues | Status |
| :--- | :--- | :--- | :--- |
| **1.** Neither player can Summon Effect Monsters to Main Monster Zones in this card's column. | `e2` (L14-22), `s.zoneval` (L52-55) | **Issue:** Computes the blocked bitmask using `0x1f - blocked`. `0x1f` only covers the 5 Main Monster Zones. The function will implicitly ban the usage of the Extra Monster Zones (`0x60`) for Effect Monsters as it doesn't grant authorization via the bitmask layout. | **Confirmed Critical** |

**Proposed Fix:** Use `return 0x7f - blocked` or `return ~blocked` globally to ensure Extra Monster Zones remain unrestricted.

### Card 10: To Proto Chrono (244013196)
`public/CCG Downloads/CCG_Scripts/c244013196.lua`

| Clause | Script Mapping (Line #) | Analysis & Issues | Status |
| :--- | :--- | :--- | :--- |
| **1.** Missing Effect Clauses. | `s.initial_effect` (L5-33) | **Issue:** Both the JSON text and the Lua script itself end abruptly. The Lua file only contains the summoning procedure. All active effects starting with the truncated text "During" are completely missing from the `.lua` file. | **Confirmed Critical** |

### Card 11 & 17: To Proto Taxis (246380598) / Ektelestis Gia Taxis (212684822)
`public/CCG Downloads/CCG_Scripts/c246380598.lua` / `c212684822.lua`

| Clause | Script Mapping (Line #) | Analysis & Issues | Status |
| :--- | :--- | :--- | :--- |
| **1.** ...your opponent takes half the battle damage you would have taken from battles involving this card. | `e6`, `e7` (`c246380598.lua` L46-59) | **Issue:** Registers `EFFECT_REFLECT_BATTLE_DAMAGE` and `EFFECT_CHANGE_BATTLE_DAMAGE` set to `HALF_DAMAGE` targeting the controller (`1,0`). The reflection correctly diverts damage to the opponent, meaning the controller takes `0`. Halving `0` results in `0`. The opponent then ends up taking the FULL, un-halved battle damage instead of half. | **Confirmed Critical** |
| **2.** Negate the effects of monsters on the field whose ATK/DEF is greater than double its original ATK/DEF (Card 11 Only) | `s.doubled` (`c246380598.lua` L113-118) | **Issue:** Script improperly uses `GetTextAttack()` instead of `GetBaseAttack()`. It will erroneously calculate based on printed paper values rather than current base values. | **Confirmed** |

### Cards 12, 18, 19, 20, 21, 22, 23 (Stellaer Summon Limits)
e.g., `public/CCG Downloads/CCG_Scripts/c259219942.lua`

| Clause | Script Mapping (Line #) | Analysis & Issues | Status |
| :--- | :--- | :--- | :--- |
| **1.** ...you cannot Special Summon monsters for the rest of this turn, except [Attribute] monsters. | `s.splimit` (e.g., L41-43) | **Issue:** Across all 7 of these `Stellaer` variants, the script registers an `EFFECT_CANNOT_SPECIAL_SUMMON` limit where the target function returns `c:IsAttribute(ATTRIBUTE_X)`. Since this function flags what *cannot* be summoned, omitting the `not` keyword actively bans the intended attribute (e.g., Water) while freely allowing all other attributes to be Special Summoned. | **Confirmed Critical** |

**Proposed Fix:** Prepend `not` to the attribute/type evaluations within all `s.splimit` functions across the Stellaer array (e.g., `return not c:IsAttribute(ATTRIBUTE_WATER)`).

### Card 16: Polemistis Gia Ataxia (254065048)
`public/CCG Downloads/CCG_Scripts/c254065048.lua`

| Clause | Script Mapping (Line #) | Analysis & Issues | Status |
| :--- | :--- | :--- | :--- |
| **1.** Gain half the ATK/DEF currently lost by monsters on the field. | `s.atkloss`, `s.atkval` (L98-114) | **Issue:** Utilizes `GetTextAttack()` to dynamically assess the negative variance. Because `GetTextAttack()` ignores base/original modulations applied prior to debuffs, the scaling output will often resolve vastly inaccurately compared to `GetBaseAttack()`. | **Confirmed** |

### Card 24: Pride of the Stellaers (236551669)
`public/CCG Downloads/CCG_Scripts/c236551669.lua`

| Clause | Script Mapping (Line #) | Analysis & Issues | Status |
| :--- | :--- | :--- | :--- |
| **1.** Add... Special Summon... Immediately after this effect resolves, Xyz Summon... | `e1`, `e2`, `e3` (L7-38) | **Issue (Ambiguous):** Registers three totally separate `EFFECT_TYPE_ACTIVATE` sequences in the same spell logic frame. This signals to EDOPRO to display an interactive "Choose 1 of 3" prompt on activation. If the intended text was meant to chain sequentially all at once during a single resolution without prompting, this structure is entirely broken. | Suspected Issue |

I confirm that I modified no files.

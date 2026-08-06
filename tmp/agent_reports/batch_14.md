# Card Audit Report: Batch 14

The audit of the 25 cards from `tmp/batch_14.json` against `public/CCG Downloads/CCG_Scripts/` is complete. 

## Clause-by-Clause Findings Table

| Card Name & Passcode | Clause | Script Logic | Issue Type | Description & Exact Path/Line | Proposed Fix |
|:---|:---|:---|:---|:---|:---|
| **Curryboh** (220538776) | "You can only activate 1 'Curryboh' effect per turn..." | `SetCountLimit(1,id+EFFECT_COUNT_CODE_OATH)` | None | Implemented correctly. | N/A |
| **Starry Knight Arc-En-Ciel** (249805098) | "When a DARK monster's effect is activated..." | `rp~=tp` | Confirmed | Script restricts activation to only opponent's DARK monsters. [c249805098.lua:34] | Remove `rp~=tp` from `negcon`. |
| **Starry Knight Arc-En-Ciel** (249805098) | "When a DARK monster's effect is activated..." | `re:GetHandler():IsAttribute(...)` | Suspected | `GetHandler()` checks current field attribute which fails if a field-changed card leaves as cost. [c249805098.lua:34] | Use `Duel.GetChainInfo(ev, CHAININFO_TRIGGERING_ATTRIBUTE)` |
| **Starry Knight Nebriel** (238241974) | All Clauses | Maps correctly | None | Effects match the exact text. | N/A |
| **Starry Knight Starry Queen** (248760718) | "If a DARK monster activates its effect..." | `re:GetHandler():IsAttribute(...)` | Suspected | Same chain attribute checking issue as Arc-En-Ciel. [c248760718.lua:53] | Use `CHAININFO_TRIGGERING_ATTRIBUTE` |
| **Starry Knight Starry Queen** (248760718) | "...then place this card in your Pendulum Zone;" | `Duel.MoveToField(...)` in cost | Live-Test | Placing in Pendulum zone as cost is unusual and might have edge cases on negation. [c248760718.lua:119] | Test edge cases. |
| **Chamroshes' Aegis** (221924008) | "If Summoned this way, you cannot Special Summon..." | `EFFECT_CANNOT_SPECIAL_SUMMON` in `sprop` | Confirmed | Restriction applies during the summon procedure, affecting the rest of the turn even if the summon is negated. [c221924008.lua:63-70] | Apply restriction dynamically on `EVENT_SPSUMMON_SUCCESS`. |
| **Gaia, the Iron Clad Knight** (212413422) | "...lists a 'Gaia The Fierce Knight' monster as Fusion Material..." | `aux.IsCodeListed(c,63680324)` | Confirmed | Only looks for the specific card text, ignoring "Sky Galloping Gaia" which lists the setcode (0xbd) instead. [c212413422.lua:65] | Replace with `aux.IsMaterialListSetCard(c, 0xbd)` |
| **Cursed Dragon of the Knight** (238256111) | All Clauses | Maps correctly | None | - | N/A |
| **Gaia the Magnificent Knight** (222476063) | "You can reveal...; Special Summon..." | `EFFECT_SPSUMMON_PROC` | Confirmed | Semicolon denotes an activated ignition effect, but script uses an inherent summon procedure that does not start a chain. [c222476063.lua:16-24] | Change to `EFFECT_TYPE_IGNITION`. |
| **Blazing Gaia the Spiral Knight** (223770816) | "this effect becomes that card's activation effect." | `Duel.ClearTargetCard()` in `copytg` | Confirmed | Clears the target Spell/Trap. `tc:IsRelateToChain()` in `copyop` returns false, making effect fizzle. [c223770816.lua:126-136] | Replace `IsRelateToChain()` with `IsRelateToEffect(e)`. |
| **Dynatos, the Challenger** (256469525) | "If Summoned this way, this card's effect becomes..." | `EFFECT_TYPE_TRIGGER_O` | Confirmed | Starts a chain, contradicting the lack of colon/semicolon in the text (which implies an unclassified immediate application). [c256469525.lua:26-32] | Apply effects directly in the `sprop` during summon. |
| **Arckcestial Crystal Shards** (259366591) | "...add it to your hand, then discard 1 card." | `s.syntg` empty hand checks | Ambiguous | Allows targeting Extra Deck monsters (which return to ED) while having 0 hand cards, leading to illegal state to discard. [c259366591.lua:68-75] | Add hand count validation for ED targets. |
| **Arckcestial Feather** (241440521) | All Clauses | Maps correctly | None | - | N/A |
| **Arckcestial Fireball** (245354354) | "Special Summon 1... from hand, then discard 1..." | `sptg2` `chk==0` | Confirmed | Player can activate with exactly 1 card in hand (the summoned monster) leaving them illegally unable to discard. [c245354354.lua:59-64] | Add check: `Duel.GetFieldGroupCount(tp,LOCATION_HAND,0)>1` |
| **Arckcestial Orb** (228860650) | "If this card is in your GY... (Quick Effect):" | `ph==PHASE_MAIN1 or...` | Confirmed | Script incorrectly limits the GY effect to Main Phase. [c228860650.lua:67-71] | Remove phase restriction from `attcon`. |
| **Arckcestial Orb** (228860650) | "...and you control an 'Arckcestial' Xyz Monster" | `Card.IsType(..., TYPE_XYZ)` | Confirmed | `attcon` only checks for ANY Xyz monster, not strictly an "Arckcestial" Xyz monster. [c228860650.lua:70] | Update `attcon` to check `IsSetCard(0x4ac0)`. |
| **Arckcestial Prism** (214511076) | All Clauses | Maps correctly | None | "Only Arckcestial monsters" allows face-downs correctly per rules. | N/A |
| **Arckcestial Descend** (258328859) | All Clauses | Maps correctly | None | - | N/A |
| **Arckcestial Meadow** (258590942) | "When this card is activated: You can add 1..." | `IsExistingMatchingCard` in `target` | Confirmed | Makes the activation of the Field Spell strictly demand a valid search target in deck, violating the optional "You can" clause. [c258590942.lua:35-39] | Set `chk==0 return true` and conditionally prompt for search in `activate`. |
| **Arckcestial Pillar of Heavens** (235051716) | All Clauses | Maps correctly | None | - | N/A |
| **Rank-Up-Magic Key of Arck Celestial Force** (228635967) | All Clauses | Maps correctly | None | - | N/A |
| **Urphiel's Feather Downpour** (235612490) | "(This card is always treated as an "Arckcestial"...)" | Missing in script | Confirmed | The script lacks `EFFECT_ADD_SETCODE` with `SetValue(0x4ac0)`. [c235612490.lua:4-27] | Add `EFFECT_ADD_SETCODE` logic to `initial_effect`. |
| **Arckcestial Burning** (239235967) | All Clauses | Maps correctly | None | - | N/A |
| **Light Illusion of Vazagiel** (219995840) | "(This card is always treated as an "Arckcestial"...)" | Missing in script | Confirmed | The script lacks `EFFECT_ADD_SETCODE` with `SetValue(0x4ac0)`. [c219995840.lua:4-26] | Add `EFFECT_ADD_SETCODE` logic to `initial_effect`. |
| **Malphiel, Arckcestial of Protection** (257176166) | "...detached from an 'Arckcestial' Xyz Monster..." | `EVENT_MOVE` trigger | Live-Test | Uses `EVENT_MOVE` from `LOCATION_OVERLAY`. While functional, test to ensure it perfectly replicates `EVENT_TO_GRAVE` behaviors. [c257176166.lua:34] | N/A |
| **Vazagiel, Arckcestial of Secrets** (228386117) | "Special Summon it, then discard 1 card." | `chk==0` missing hand count | Confirmed | Does not verify the player has a card in hand to discard at activation. [c228386117.lua:73-82] | Add `Duel.GetFieldGroupCount(tp,0,LOCATION_HAND)>0` to `sptg2`. |
| **Azeriel, Arckcestial of Demise** (237089049) | All Clauses | Complete script mismatch | Confirmed | Script implements a completely different card (Level-free Synchro-mixed materials, RUM search on detach, destroy card) than the required text. [c237089049.lua] | Completely rewrite script to match provided text. |

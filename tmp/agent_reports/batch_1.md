# Yu-Gi-Oh! CCG Semantic Effect Audit Report — Batch 1 (Cards 1 to 25)

## Executive Summary
An exhaustive semantic effect audit was performed on the 25 custom cards assigned in `tmp/batch_1.json`. Each card's official English text was parsed into discrete semantic clauses and compared against its implementation in `public/CCG Downloads/CCG_Scripts/c<passcode>.lua` and reference EDOPro scripts in `tmp/omega_scripts/`.

- **Total Cards Audited**: 25
- **Clean / Fully Compliant Implementations**: 18
- **Cards with Confirmed Bugs / Implementation Discrepancies**: 7 (CARD-0002, CARD-0003, CARD-0004, CARD-0005, CARD-0007, CARD-0008, CARD-0010, CARD-0015)

---

## Detailed Card Audits

### CARD-0001: Stardrake of Gravitic Coils
- **Passcode**: `245265629` | **Set**: `TATA-001 Tainted Tails` | **Archetype**: `Stardrake`
- **Type**: Rank 10 DARK Machine Xyz Effect Monster | **ATK**: 0 / **DEF**: 2500
- **Script Path**: `public/CCG Downloads/CCG_Scripts/c245265629.lua`

#### Clause Breakdown & Lua Mapping Table
| # | Card Text Clause | Script Function / Callback | Line Numbers | Status / Issue |
|---|---|---|---|---|
| 1 | Once per turn, if your opponent controls a monster with 3000 or more ATK, and it is the highest ATK on the field, you can Xyz Summon "Stardrake of Gravitic Coils" by using 1 monster you control with the lowest ATK or DEF (your choice, if tied) as material. | `e1:SetCondition`, `s.highatkfilter`, `s.matfilter`, `s.xyzcheck` | L7–18, L48–67 | Compliant |
| 2 | Cannot be used as Xyz or Link Material. | `e2`, `e3` (`EFFECT_CANNOT_BE_XYZ_MATERIAL`, `EFFECT_CANNOT_BE_LINK_MATERIAL`) | L20–28 | Compliant |
| 3 | While this Xyz Summoned card is on the field, your opponent cannot target other monsters for attacks. | `e4`, `s.atkcon`, `s.atlimit` (`EFFECT_CANNOT_SELECT_BATTLE_TARGET`) | L30–37, L68–74 | Compliant |
| 4 | If this card battles an opponent's monster, during damage calculation only, this card’s ATK becomes equal to the ATK of the opponent's battling monster +100. | `e5`, `s.atkvalcon`, `s.atkval` (`EFFECT_SET_ATTACK_FINAL`) | L39–46, L75–83 | Compliant |

- **Audit Findings**:
  - `s.highatkfilter` (L48–53) accurately checks if the opponent controls a monster with ATK ≥ 3000 that has the highest ATK on the field.
  - `s.matfilter` (L54–64) correctly computes `ag` (minimum ATK group) and `dg` (minimum DEF group, excluding Link monsters) to allow selecting any monster that satisfies the lowest ATK or lowest DEF condition.
  - `e4` (L30–37) correctly uses `EFFECT_CANNOT_SELECT_BATTLE_TARGET` with `SetTargetRange(0, LOCATION_MZONE)` and `atlimit` returning `c ~= e:GetHandler()`, mirroring official cards like *Mekk-Knight Crusadia Avramax* (`c21887175.lua`).
  - **Status**: **Clean / Compliant**.

---

### CARD-0002: Reactor Shocker
- **Passcode**: `241056746` | **Set**: `TATA-002 Tainted Tails` | **Archetype**: `Reactor`
- **Type**: Quick-Play Spell Card
- **Script Path**: `public/CCG Downloads/CCG_Scripts/c241056746.lua`

#### Clause Breakdown & Lua Mapping Table
| # | Card Text Clause | Script Function / Callback | Line Numbers | Status / Issue |
|---|---|---|---|---|
| 1 | Neither player can activate cards or effects in response to this card's activation. | `s.target` (`Duel.SetChainLimit(aux.FALSE)`) | L37 | Compliant |
| 2 | When your opponent activates an effect and you have a card effect in the same Chain: You can negate all other activated effects in this Chain... | `s.condition`, `s.activate` | L23–31, L40–49 | Compliant |
| 3 | ...then, if the number of your effects in this Chain is equal to or greater than your opponent’s, draw cards equal to that number... | `s.activate` | L50–52 | **Confirmed Bug** |
| 4 | ...then, if one of your effects is Chain Link 1, place 1 card from your hand on the bottom of your Deck. | `s.activate` | L53–60 | Compliant |
| 5 | You can only use this effect of "Reactor Shocker" once per turn. | `e1:SetCountLimit(1, id)` | L11 | Compliant |

- **Audit Findings**:
  - **Confirmed Bug (L50)**: Line 50 checks `if negated_own > 0 and ownct >= oppct and Duel.IsPlayerCanDraw(tp, ownct) then`. The card text does **not** require any of your effects to have been successfully negated. The requirement is purely "if the number of your effects in this Chain is equal to or greater than your opponent’s". The `negated_own > 0` condition erroneously prevents drawing cards if your effects were unnegatable.
  - **Confirmed Bug (L24–29, L40–46)**: `ownct` is computed by looping through chain links `1` to `ev` (the chain length before `Reactor Shocker`'s activation). Because `Reactor Shocker` itself is a card effect activated by you in this Chain (Chain Link `ev + 1`), `ownct` undercounts your total effects in the chain by 1.
  - **Suspected Issue (L34)**: In `s.target`, `Duel.SetOperationInfo(0, CATEGORY_DISABLE, nil, 1, 0, 0)` is declared, but `CATEGORY_DRAW` and `CATEGORY_TODECK` operation info are missing.
- **Proposed Fix**:
  ```lua
  -- In s.activate:
  local total_own = ownct + 1 -- include Reactor Shocker itself
  if total_own >= oppct and Duel.IsPlayerCanDraw(tp, total_own) then
      Duel.Draw(tp, total_own, REASON_EFFECT)
  end
  ```

---

### CARD-0003: The Condescender
- **Passcode**: `221321849` | **Set**: `TATA-003 Tainted Tails` | **Archetype**: `Condescender`
- **Type**: Level 4 DARK Fiend Effect Monster | **ATK**: 1800 / **DEF**: 1000
- **Script Path**: `public/CCG Downloads/CCG_Scripts/c221321849.lua`

#### Clause Breakdown & Lua Mapping Table
| # | Card Text Clause | Script Function / Callback | Line Numbers | Status / Issue |
|---|---|---|---|---|
| 1 | (Quick Effect): You can send this card from your hand to the GY, then target 1 face-up monster on the field; declare a number from 1 to 3, then reduce that monster's Level, Rank, or Link Rating by the declared number until the end of the next turn. | `e1`, `s.lvcost`, `s.lvtg`, `s.lvop` | L6–17, L30–66 | **Confirmed Bug** |
| 2 | If a monster whose Level, Rank, or Link Rating is lower than its original value is on the field: You can Special Summon this card from your GY, but banish it when it leaves the field. | `e2`, `s.spcon`, `s.sptg`, `s.spop` | L19–28, L67–95 | **Confirmed Bug** |
| 3 | You can only use 1 effect of "The Condescender" per turn and only once that turn. | `e1:SetCountLimit`, `e2:SetCountLimit` | L13, L24 | **Confirmed Bug** |

- **Audit Findings**:
  - **Confirmed Bug (L13, L24)**: Setting `e1:SetCountLimit(1, id)` and `e2:SetCountLimit(1, id)` independently allows activating **both** effects in the same turn. To enforce "You can only use 1 effect of 'The Condescender' per turn", both effects must use `SetCountLimit(1, id + EFFECT_COUNT_CODE_OATH)`.
  - **Confirmed Bug (L35, L46–66, L67–69)**: Link Rating reduction is omitted entirely across `s.lvfilter`, `s.lvop`, and `s.lowfilter`. `s.lvfilter` only checks `c:GetLevel() > 0 or c:GetRank() > 0`, ignoring Link Monsters completely.
  - **Confirmed Bug (L43)**: `Duel.AnnounceNumber(tp, 1, 2, 3)` is invoked inside `s.lvtg` (targeting phase). PSCT specifies "target 1 face-up monster on the field; declare a number from 1 to 3, then reduce...". Number declaration must occur during resolution (`s.lvop`), after the semicolon.
- **Proposed Fix**:
  ```lua
  -- Fix 1: Share count limit code oath
  e1:SetCountLimit(1, id + EFFECT_COUNT_CODE_OATH)
  e2:SetCountLimit(1, id + EFFECT_COUNT_CODE_OATH)
  
  -- Fix 2: Move AnnounceNumber to s.lvop and handle Link Rating reduction / lowfilter for Link Monsters.
  ```

---

### CARD-0004: Stained Bird Bria
- **Passcode**: `225091736` | **Set**: `TATA-004 Tainted Tails` | **Archetype**: `Stain`
- **Type**: Level 2 FIRE Winged Beast Effect Monster | **ATK**: 1000 / **DEF**: 500
- **Script Path**: `public/CCG Downloads/CCG_Scripts/c225091736.lua`

#### Clause Breakdown & Lua Mapping Table
| # | Card Text Clause | Script Function / Callback | Line Numbers | Status / Issue |
|---|---|---|---|---|
| 1 | If this card is in your hand: You can discard 1 card; shuffle this card face-up into your opponent's Deck, also, add 1 "Stain" card from your Deck to your hand, then, if your opponent controls more cards than you, draw 1 card. | `e1`, `s.thcost`, `s.thtg`, `s.thop` | L9–18, L45–73 | Compliant |
| 2 | If this card is Normal or Special Summoned: You can target 1 card in either GY or banishment; place it on the bottom of the Deck, or, if it is your "Stain" card, add it to the hand instead, and if you do, shuffle this card into the Deck. | `e2`, `e3`, `s.bottg`, `s.botop` | L20–32, L85–113 | **Confirmed Bug** |
| 3 | You can only use each effect of "Stained Bird Bria" once per turn. | `e1:SetCountLimit`, `e2:SetCountLimit` | L14, L26 | Compliant |

- **Audit Findings**:
  - **Confirmed Bug (L111)**: In `s.botop` (the operation for Effect 2), line 111 calls `s.faceupoppdeck(c, tp, REASON_EFFECT)`. This shuffles `c` **face-up into your opponent's Deck**. Effect 2 text states: "and if you do, shuffle this card into the Deck" (standard shuffle into controller's Deck face-down). `s.faceupoppdeck` is appropriate for Effect 1, but violates Effect 2 text.
- **Proposed Fix**:
  ```lua
  -- In s.botop line 111:
  if added and c:IsRelateToEffect(e) then
      Duel.SendtoDeck(c, nil, SEQ_DECKSHUFFLE, REASON_EFFECT)
  end
  ```

---

### CARD-0005: Stained Deer Dante
- **Passcode**: `216958556` | **Set**: `TATA-005 Tainted Tails` | **Archetype**: `Stain`
- **Type**: Level 1 EARTH Beast Effect Monster | **ATK**: 600 / **DEF**: 300
- **Script Path**: `public/CCG Downloads/CCG_Scripts/c216958556.lua`

#### Clause Breakdown & Lua Mapping Table
| # | Card Text Clause | Script Function / Callback | Line Numbers | Status / Issue |
|---|---|---|---|---|
| 1 | If this card is Normal or Special Summoned: You can target 1 card your opponent controls; destroy it, and if you do, shuffle this card into the Deck. | `e1`, `e2`, `s.destg`, `s.desop` | L9–21, L41–55 | **Confirmed Bug** |
| 2 | If this card is in your GY: You can show 1 face-up "Stain" card in your opponent's Deck or in your field, and if you do, shuffle this card face-up into your opponent's Deck, also, add 1 "Stain" monster from your Deck to your hand. | `e3`, `s.thtg`, `s.thop` | L23–31, L62–85 | Compliant |
| 3 | You can only use each effect of "Stained Deer Dante" once per turn. | `e1:SetCountLimit`, `e3:SetCountLimit` | L15, L28 | Compliant |

- **Audit Findings**:
  - **Confirmed Bug (L53)**: In `s.desop` (Effect 1 resolution), line 53 calls `s.faceupoppdeck(c, tp, REASON_EFFECT)`. Effect 1 text reads "shuffle this card into the Deck", which means standard face-down shuffle into controller's Deck. It does not state "face-up into your opponent's Deck" for Effect 1.
- **Proposed Fix**:
  ```lua
  -- In s.desop line 53:
  if tc and tc:IsRelateToEffect(e) and Duel.Destroy(tc, REASON_EFFECT) > 0 and c:IsRelateToEffect(e) then
      Duel.SendtoDeck(c, nil, SEQ_DECKSHUFFLE, REASON_EFFECT)
  end
  ```

---

### CARD-0006: Stained Fox Feness
- **Passcode**: `247499445` | **Set**: `TATA-006 Tainted Tails` | **Archetype**: `Stain`
- **Type**: Level 3 WATER Aqua Effect Monster | **ATK**: 400 / **DEF**: 700
- **Script Path**: `public/CCG Downloads/CCG_Scripts/c247499445.lua`

#### Clause Breakdown & Lua Mapping Table
| # | Card Text Clause | Script Function / Callback | Line Numbers | Status / Issue |
|---|---|---|---|---|
| 1 | If your opponent controls more cards than you do: You can Special Summon this card from your hand. | `e1`, `s.spcon` | L9–17, L52–57 | Compliant |
| 2 | If this card is Normal or Special Summoned: You can target 1 other face-up card on the field; negate its effects until the end of this turn, and if you do, shuffle this card into the Deck. | `e2`, `e3`, `s.negtg`, `s.negop` | L19–31, L61–87 | **Confirmed Bug** |
| 3 | You can send 1 Level 4 or lower "Stain" monster from your Deck to the GY; Shuffle this card face-up into your opponent's Deck. | `e4`, `s.tdcost`, `s.tdtg`, `s.tdop` | L33–42, L91–107 | Compliant |
| 4 | You can only use each effect of "Stained Fox Feness" once per turn. | `e1:SetCountLimit`, etc. | L15, L25, L38 | Compliant |

- **Audit Findings**:
  - **Confirmed Bug (L84–86)**: In `s.negop`, `Duel.SendtoDeck(c, nil, SEQ_DECKSHUFFLE, REASON_EFFECT)` runs unconditionally at the end of resolution. Text uses the conjunction "and if you do", meaning `c` must only be shuffled into the Deck if the negation of the target's effects succeeded.
- **Proposed Fix**:
  ```lua
  -- In s.negop:
  if tc:RegisterEffect(e1) and tc:RegisterEffect(e2) and c:IsRelateToEffect(e) then
      Duel.SendtoDeck(c, nil, SEQ_DECKSHUFFLE, REASON_EFFECT)
  end
  ```

---

### CARD-0007: Stained Raptor Rollo
- **Passcode**: `224822244` | **Set**: `TATA-007 Tainted Tails` | **Archetype**: `Stain`
- **Type**: Level 4 WIND Reptile Effect Monster | **ATK**: 1800 / **DEF**: 900
- **Script Path**: `public/CCG Downloads/CCG_Scripts/c224822244.lua`

#### Clause Breakdown & Lua Mapping Table
| # | Card Text Clause | Script Function / Callback | Line Numbers | Status / Issue |
|---|---|---|---|---|
| 1 | If this card is Normal or Special Summoned: You can target 1 "Stain" monster in your GY or 1 monster in your opponent's GY; Special Summon it to your field, and if you do, shuffle this card into the Deck. | `e1`, `e2`, `s.sptg`, `s.spop` | L9–21, L46–63 | Compliant |
| 2 | When an attack is declared involving this card and an opponent's monster: You can shuffle this card face-up into your opponent's Deck, also, after that, place that opponent's monster on top of the Deck. | `e3`, `s.tdcon`, `s.tdop` | L23–32, L64–84 | **Confirmed Bug** |
| 3 | You can only use each effect of "Stained Raptor Rollo" once per turn. | `e1:SetCountLimit`, `e3:SetCountLimit` | L15, L29 | Compliant |

- **Audit Findings**:
  - **Confirmed Bug (L23–32)**: `e3` registration is missing its `SetTarget` call (`e3:SetTarget(...)` was omitted). Because no target function is assigned, the engine cannot verify `chk == 0` requirements prior to activation.
  - **Suspected Issue (L79–81)**: In `tdop`, `Duel.SendtoDeck(tc, nil, SEQ_DECKSHUFFLE, REASON_EFFECT)` is performed, followed by `Duel.ShuffleDeck(p)` and `Duel.MoveSequence(tc, SEQ_DECKTOP)`. Standard EDOPro convention for placing a card on top of the Deck is `Duel.SendtoDeck(tc, nil, SEQ_DECKTOP, REASON_EFFECT)`.
- **Proposed Fix**:
  ```lua
  -- Register SetTarget for e3 and simplify SendtoDeck:
  e3:SetTarget(s.tdtg)
  
  function s.tdtg(e,tp,eg,ep,ev,re,r,rp,chk)
      if chk==0 then return e:GetHandler():IsAbleToDeck() end
      Duel.SetOperationInfo(0,CATEGORY_TODECK,e:GetHandler(),1,0,0)
  end
  ```

---

### CARD-0008: Stained Solitaire
- **Passcode**: `259475154` | **Set**: `TATA-008 Tainted Tails` | **Archetype**: `Stain`
- **Type**: Level 4 DARK Warrior Effect Monster | **ATK**: 1700 / **DEF**: 1600
- **Script Path**: `public/CCG Downloads/CCG_Scripts/c259475154.lua`

#### Clause Breakdown & Lua Mapping Table
| # | Card Text Clause | Script Function / Callback | Line Numbers | Status / Issue |
|---|---|---|---|---|
| 1 | You can reveal 1 "Stain" Fusion Monster in your Extra Deck; shuffle 1 "Stain" monster from your Deck face-up into your opponent's Deck, also, Special Summon this card from your hand. | `e1`, `s.spcost`, `s.sptg`, `s.spop` | L9–18, L46–68 | Compliant |
| 2 | During your Main Phase: You can shuffle 1 "Stain" monster you control that mentions "Shuffle this card face-up into your opponent's Deck" in its text face-up into your opponent's Deck, also, add 1 "Stain" card from your Deck, GY, or banishment to your hand. | `e2`, `s.thcon`, `s.thcost`, `s.thtg`, `s.thop` | L20–30, L72–101 | **Confirmed Bug** |
| 3 | You can only use each effect of "Stained Solitaire" once per turn. | `e1:SetCountLimit`, `e2:SetCountLimit` | L14, L25 | Compliant |

- **Audit Findings**:
  - **Confirmed Bug (L81–86)**: `s.thcost` executes `s.faceupoppdeck(tc, tp, REASON_COST)` during activation as a cost. Text reads "You can shuffle 1 'Stain' monster... face-up into your opponent's Deck, ALSO, add 1...". In PSCT, actions following "You can..." without a semicolon `;` are effect resolution operations, not costs. Shuffling the monster must be performed in `s.thop`.
- **Proposed Fix**: Move `s.faceupoppdeck` from `s.thcost` into `s.thop`.

---

### CARD-0009: Stargazer of the Stained
- **Passcode**: `218685316` | **Set**: `TATA-009 Tainted Tails` | **Archetype**: `Stain`
- **Type**: Level 4 LIGHT Warrior Effect Monster | **ATK**: 1600 / **DEF**: 1600
- **Script Path**: `public/CCG Downloads/CCG_Scripts/c218685316.lua`

#### Clause Breakdown & Lua Mapping Table
| # | Card Text Clause | Script Function / Callback | Line Numbers | Status / Issue |
|---|---|---|---|---|
| 1 | If a card(s) leaves your opponent's Deck, except during the Draw Phase: You can Tribute this card from your hand or field; add 1 "Stain" card from your Deck to your hand. | `e1`, `s.thcon`, `s.thcost`, `s.thtg`, `s.thop` | L9–21, L39–70 | Compliant |
| 2 | If your opponent controls a card: You can banish this card from your GY; Special Summon 1 "Stain" monster that mentions "Shuffle this card face-up into your opponent's Deck" in its text from face-up in your opponent's Deck. | `e2`, `s.spcon`, `s.sptg`, `s.spop` | L23–33, L75–94 | Compliant |
| 3 | You can only use each effect of "Stargazer of the Stained" once per turn. | `e1:SetCountLimit`, `e2:SetCountLimit` | L16, L28 | Compliant |

- **Audit Findings**:
  - `s.leavefilter` and `s.thcon` accurately check if a card left opponent's Deck outside the Draw Phase.
  - `s.thcost` correctly handles Tributing from hand (`SendtoGrave(c, REASON_COST+REASON_RELEASE)`) or field (`Release(c, REASON_COST)`).
  - `s.spfilter` accurately searches `LOCATION_DECK` of opponent (`0, LOCATION_DECK`) for face-up Stain monsters matching `s.mentions`.
  - **Status**: **Clean / Compliant**.

---

### CARD-0010: Stained Scioness Silia
- **Passcode**: `244408495` | **Set**: `TATA-010 Tainted Tails` | **Archetype**: `Stain`
- **Type**: Level 5 LIGHT Fairy Effect Monster | **ATK**: 1600 / **DEF**: 1800
- **Script Path**: `public/CCG Downloads/CCG_Scripts/c244408495.lua`

#### Clause Breakdown & Lua Mapping Table
| # | Card Text Clause | Script Function / Callback | Line Numbers | Status / Issue |
|---|---|---|---|---|
| 1 | During your Main Phase, if this card is in your hand (Quick Effect): You can Fusion Summon 1 "Stain" Fusion Monster from your Extra Deck using "Stain" monsters that mention "Shuffle this card face-up into your opponent's Deck" from your hand or field as material. | `e1`, `s.fuscon`, `s.fuscost`, `s.fustg`, `s.fusop` | L9–20, L37–77 | **Confirmed Bug** |
| 2 | If this card is sent to the GY: You can discard 1 card and send 1 "Stain" card from your Deck to the GY; add it to your hand. | `e2`, `s.thcost`, `s.thtg`, `s.thop` | L22–32, L84–112 | Compliant |
| 3 | You can only use each effect of "Stained Scioness Silia" once per turn. | `e1:SetCountLimit`, `e2:SetCountLimit` | L15, L28 | Compliant |

- **Audit Findings**:
  - **Confirmed Bug (L49–54)**: `s.fuscost` requires revealing 1 "Stain" Fusion Monster from Extra Deck as a cost. This reveal cost does **not** exist in the card text.
- **Proposed Fix**: Remove `e1:SetCost(s.fuscost)` from `e1`.

---

### CARD-0011: Stained Sovereign Silas
- **Passcode**: `221822671` | **Set**: `TATA-011 Tainted Tails` | **Archetype**: `Stain`
- **Type**: Level 6 LIGHT Spellcaster Effect Monster | **ATK**: 2600 / **DEF**: 1600
- **Script Path**: `public/CCG Downloads/CCG_Scripts/c221822671.lua`

#### Clause Breakdown & Lua Mapping Table
| # | Card Text Clause | Script Function / Callback | Line Numbers | Status / Issue |
|---|---|---|---|---|
| 1 | If this card is Normal or Special Summoned: You can add to your hand or Set 1 "Stain" card from your Deck. | `e1`, `e2`, `s.thtg`, `s.thop` | L9–21, L56–71 | Compliant |
| 2 | (Quick Effect): You can target 1 face-up card your opponent controls; while it is face-up on the field, neither player can activate its effects. | `e3`, `s.limtg`, `s.limop`, `s.aclimit` | L23–32, L75–97 | Compliant |
| 3 | If your opponent activates a card or effect, and this card is in your GY: You can shuffle this card face-up into your opponent's Deck, also, Special Summon 1 Level 4 or lower "Stain" monster from your GY. | `e4`, `s.spcon`, `s.sptg`, `s.spop` | L34–44, L98–123 | Compliant |
| 4 | You can only use each effect of "Stained Sovereign Silas" once per turn. | `e1:SetCountLimit`, etc. | L15, L29, L40 | Compliant |

- **Audit Findings**:
  - `s.limop` (L85–97) registers `EFFECT_CANNOT_ACTIVATE` on the targeted card with `RESET_EVENT+RESETS_STANDARD`, perfectly implementing "while it is face-up on the field".
  - **Status**: **Clean / Compliant**.

---

### CARD-0012: Stained Silhouette
- **Passcode**: `256608976` | **Set**: `TATA-012 Tainted Tails` | **Archetype**: `Stain`
- **Type**: Level 8 DARK Illusion Effect Monster | **ATK**: 2600 / **DEF**: 2600
- **Script Path**: `public/CCG Downloads/CCG_Scripts/c256608976.lua`

#### Clause Breakdown & Lua Mapping Table
| # | Card Text Clause | Script Function / Callback | Line Numbers | Status / Issue |
|---|---|---|---|---|
| 1 | If a card(s) leaves your opponent's Deck, except during the Draw Phase: You can Special Summon this card from your hand, but shuffle this card face-up into your opponent's Deck when it leaves the field. | `e1`, `s.selfspcon`, `s.selfsptg`, `s.selfspop`, `s.registerleave` | L9–20, L41–77 | Compliant |
| 2 | If your opponent controls a card (Quick Effect): You can reveal 1 "Stain" card in your hand, then activate 1 of these effects; | `e2`, `s.effcost`, `s.efftg`, `s.effop` | L22–32, L81–137 | Compliant |
| 3 | ● Special Summon 1 Level 4 or lower "Stain" monster from your Deck or GY. | `s.efftg`, `s.effop` (option 1) | L95–120 | Compliant |
| 4 | ● Until the End Phase, this card's name becomes the original name of 1 face-up monster your opponent controls, and it gains that monster's original effects. | `s.efftg`, `s.effop` (option 2) | L121–136 | Compliant |
| 5 | You can only use each effect of "Stained Silhouette" once per turn. | `e1:SetCountLimit`, `e2:SetCountLimit` | L16, L28 | Compliant |

- **Audit Findings**:
  - `s.effop` option 2 correctly applies `EFFECT_CHANGE_CODE` and `CopyEffect` until `RESET_PHASE+PHASE_END`.
  - **Status**: **Clean / Compliant**.

---

### CARD-0013: Abstain from Light
- **Passcode**: `232449539` | **Set**: `TATA-013 Tainted Tails` | **Archetype**: `Stain`
- **Type**: Normal Spell Card
- **Script Path**: `public/CCG Downloads/CCG_Scripts/c232449539.lua`

#### Clause Breakdown & Lua Mapping Table
| # | Card Text Clause | Script Function / Callback | Line Numbers | Status / Issue |
|---|---|---|---|---|
| 1 | Fusion Summon 1 "Stain" Fusion Monster from your Extra Deck using "Stain" monsters from your hand or field as material... | `e1`, `s.fustg`, `s.fusop` | L18–26, L63–132 | Compliant |
| 2 | ...also, for the rest of this turn after this card resolves, you cannot activate "Abstain from Light", or Special Summon monsters from the Extra Deck, except "Stain" monsters. | `fusop` (`EFFECT_CANNOT_SPECIAL_SUMMON`, `EFFECT_CANNOT_ACTIVATE`) | L116–138 | Compliant |
| 3 | If your "Stain" monster was shuffled into either Deck this turn, you can also banish "Stain" monsters from face-up in your opponent's Deck as material, but return them to the GY during the End Phase. | `global_check`, `s.checkop`, `s.getmaterials`, `s.registerreturn`, `s.retop` | L8–16, L28–41, L55–62, L69–88 | Compliant |

- **Audit Findings**:
  - `global_check` tracks when Stain monsters enter `LOCATION_DECK`, setting a flag effect on the player to enable banishing face-up materials from opponent's Deck. `registerreturn` cleanly returns banished materials to the GY during the End Phase.
  - **Status**: **Clean / Compliant**.

---

### CARD-0014: Shattering Sustained
- **Passcode**: `248453205` | **Set**: `TATA-014 Tainted Tails` | **Archetype**: `Stain`
- **Type**: Quick-Play Spell Card
- **Script Path**: `public/CCG Downloads/CCG_Scripts/c248453205.lua`

#### Clause Breakdown & Lua Mapping Table
| # | Card Text Clause | Script Function / Callback | Line Numbers | Status / Issue |
|---|---|---|---|---|
| 1 | Tribute 1 "Stain" monster from your hand, face-up field, or face-up in your opponent's Deck; Special Summon 1 Level 4 or lower "Stain" monster from your hand, Deck, or GY, but shuffle it face-up into your opponent's Deck when it leaves the field, then you can Tribute 1 face-up "Stain" monster in your opponent's Deck. | `e1`, `s.spcost`, `s.sptg`, `s.spop` | L9–18, L57–107 | Compliant |
| 2 | During your End Phase, if this card is in your GY: You can banish 1 "Stain" monster from your GY; Set this card. | `e2`, `s.setcon`, `s.setcost`, `s.settg`, `s.setop` | L20–30, L108–130 | Compliant |
| 3 | You can only use each effect of "Shattering Sustained" once per turn. | `e1:SetCountLimit`, `e2:SetCountLimit` | L14, L25 | Compliant |

- **Audit Findings**:
  - Tributing from face-up opponent's Deck as cost is handled appropriately via `SendtoGrave(tc, REASON_COST+REASON_RELEASE)`.
  - **Status**: **Clean / Compliant**.

---

### CARD-0015: Stained Avatar
- **Passcode**: `244790302` | **Set**: `TATA-015 Tainted Tails` | **Archetype**: `Stain`
- **Type**: Level 6 LIGHT Fairy Fusion Effect Monster | **ATK**: 1600 / **DEF**: 1600
- **Script Path**: `public/CCG Downloads/CCG_Scripts/c244790302.lua`

#### Clause Breakdown & Lua Mapping Table
| # | Card Text Clause | Script Function / Callback | Line Numbers | Status / Issue |
|---|---|---|---|---|
| 1 | 2 "Stain" monsters with different Attributes | `aux.AddFusionProcFunRep` | L10, L45–47 | Compliant |
| 2 | If a card(s) you control would be destroyed by battle or card effect, you can banish 1 face-up "Stain" monster in your opponent's Deck instead. | `e1`, `s.reptg`, `s.repop` (`EFFECT_DESTROY_REPLACE`) | L12–20, L55–70 | Compliant |
| 3 | If this card is Fusion Summoned by the effect of "Abstain from Light": You can destroy 1 other card on the field. | `e2`, `s.descon`, `s.destg`, `s.desop` | L22–32, L71–86 | **Confirmed Bug** |
| 4 | (Quick Effect): You can target 1 "Stain" Spell/Trap in your GY; apply that card's activation effect. | `e3`, `s.cptg`, `s.cpop` | L34–43, L91–111 | Compliant |
| 5 | You can only use each effect of "Stained Avatar" once per turn. | `e1:SetCountLimit`, etc. | L17, L28, L40 | Compliant |

- **Audit Findings**:
  - **Confirmed Bug (L73–74)**: In `s.descon`, line 73 evaluates `local rc = c:GetReasonCard()` and checks `rc:IsCode(232449539)`. Because "Abstain from Light" is a Spell Card, `GetReasonCard()` returns `nil`. To inspect the effect that performed the Fusion Summon, `c:GetReasonEffect()` must be queried.
- **Proposed Fix**:
  ```lua
  function s.descon(e,tp,eg,ep,ev,re,r,rp)
      local c=e:GetHandler()
      local re=c:GetReasonEffect()
      return c:IsSummonType(SUMMON_TYPE_FUSION) and re and re:GetHandler():IsCode(232449539)
  end
  ```

---

### CARD-0016: Stained Sorceress Silphia
- **Passcode**: `247789143` | **Set**: `TATA-016 Tainted Tails` | **Archetype**: `Stain`
- **Type**: Level 8 LIGHT Fairy Fusion Effect Monster | **ATK**: 1600 / **DEF**: 1800
- **Script Path**: `public/CCG Downloads/CCG_Scripts/c247789143.lua`

#### Clause Breakdown & Lua Mapping Table
| # | Card Text Clause | Script Function / Callback | Line Numbers | Status / Issue |
|---|---|---|---|---|
| 1 | 2 "Stain" monsters with different names | `aux.AddFusionProcFunRep` | L9, L45–47 | Compliant |
| 2 | During your turn, "Stain" monsters you control gain 600 ATK. | `e1`, `s.atkcon` | L12–20, L48–50 | Compliant |
| 3 | You can only control 1 "Stained Sorceress Silphia". | `c:SetUniqueOnField(1,0,id)` | L10 | Compliant |
| 4 | If this card is Fusion Summoned: You can activate this effect; shuffle 1 "Stain" monster from your Deck face-up into your opponent's Deck during the Standby Phase of the next turn. | `e2`, `s.tdcon`, `s.tdtg`, `s.tdop`, `s.delayop` | L22–31, L58–87 | Compliant |
| 5 | Once per Chain, when your opponent activates a card or effect (Quick Effect): You can activate 1 of these effects. | `e3`, `s.chaincon`, `s.chaintg`, `s.chainop` | L33–43, L88–171 | Compliant |
| 6 | ● This card gains 300 ATK. | `s.chainop` (option 1) | L140–146 | Compliant |
| 7 | ● This card loses exactly 2000 ATK, and if it does, banish 1 monster on the field and 1 "Stain" monster you control until the End Phase. | `s.chainop` (option 2), `s.registerreturn`, `s.retop` | L147–170 | Compliant |

- **Audit Findings**:
  - `SetUniqueOnField` handles control limit. `s.delayop` properly delays the shuffle to the next Standby Phase. `s.chainop` option 2 handles temporary banishment cleanly with `Duel.ReturnToField`.
  - **Status**: **Clean / Compliant**.

---

### CARD-0017: Distained Druid Dragar
- **Passcode**: `247580036` | **Set**: `TATA-017 Tainted Tails` | **Archetype**: `Stain`
- **Type**: Level 8 LIGHT Beast-Warrior Fusion Effect Monster | **ATK**: 2600 / **DEF**: 2600
- **Script Path**: `public/CCG Downloads/CCG_Scripts/c247580036.lua`

#### Clause Breakdown & Lua Mapping Table
| # | Card Text Clause | Script Function / Callback | Line Numbers | Status / Issue |
|---|---|---|---|---|
| 1 | 1 "Stain" monster + 1 non-LIGHT "Stain" monster | `aux.AddFusionProcFun2` | L9, L28–30 | Compliant |
| 2 | If this card is Special Summoned, or if a non-LIGHT "Stain" monster(s) is Normal or Special Summoned to your field: You can Tribute 1 monster from your field or face-up in your opponent's Deck, then target 1 face-up monster your opponent controls; gain LP equal to that monster's ATK, also, change all other face-up monsters they control to face-down Defense Position. | `e1`, `e2`, `s.trcon`, `s.trcost`, `s.trtg`, `s.trop` | L11–26, L34–77 | Compliant |
| 3 | You can only use this effect of "Distained Druid Dragar" once per turn. | `e1:SetCountLimit(1, id)` | L18 | Compliant |

- **Audit Findings**:
  - `s.trcon` triggers on Special Summon of this card or Normal/Special Summon of non-LIGHT Stain monsters to your field.
  - `s.trcost` handles Tributing from field or face-up in opponent's Deck as activation cost (before the semicolon `;`).
  - **Status**: **Clean / Compliant**.

---

### CARD-0018: Stainless Kaleidragon
- **Passcode**: `217174535` | **Set**: `TATA-018 Tainted Tails` | **Archetype**: `Stain`
- **Type**: Level 11 LIGHT Dragon Fusion Effect Monster | **ATK**: 3200 / **DEF**: 1600
- **Script Path**: `public/CCG Downloads/CCG_Scripts/c217174535.lua`

#### Clause Breakdown & Lua Mapping Table
| # | Card Text Clause | Script Function / Callback | Line Numbers | Status / Issue |
|---|---|---|---|---|
| 1 | "Stargazer of the Stained" + 2 "Stain" monsters | `aux.AddFusionProcMix` | L9, L47–49 | Compliant |
| 2 | When a monster(s) would be Special Summoned, or a card or effect is activated that includes an effect that Special Summons a monster(s) (Quick Effect): You can negate that Summon or effect, and if you do, destroy that card(s). | `e1`, `e2`, `s.sumnegcon`, `s.actnegcon`, etc. | L11–33, L69–101 | Compliant |
| 3 | You cannot activate cards or effects the turn you activate this effect, except "Stain" cards or effects. | `Duel.AddCustomActivityCounter`, `s.applylimit` | L45, L53–68 | Compliant |
| 4 | If this card is Special Summoned, or if another "Stain" monster(s) is Special Summoned to your field: You can look at your opponent's hand and all face-down cards they control. | `e3`, `s.lookcon`, `s.lookop` | L35–44, L105–118 | Compliant |
| 5 | You can only use each effect of "Stainless Kaleidragon" once per turn. | `e1:SetCountLimit`, etc. | L17, L29, L41 | Compliant |

- **Audit Findings**:
  - `AddCustomActivityCounter` combined with `EFFECT_CANNOT_ACTIVATE` properly enforces the whole-turn restriction (both before and after activation).
  - **Status**: **Clean / Compliant**.

---

### CARD-0019: Aetherstorm Zenith Wire-Tailed Sypharion
- **Passcode**: `259365935` | **Set**: `TATA-020 Tainted Tails` | **Archetype**: `Aetherstorm`
- **Type**: Rank 9 LIGHT Dragon Xyz Effect Monster | **ATK**: 3800 / **DEF**: 3400
- **Script Path**: `public/CCG Downloads/CCG_Scripts/c259365935.lua`

#### Clause Breakdown & Lua Mapping Table
| # | Card Text Clause | Script Function / Callback | Line Numbers | Status / Issue |
|---|---|---|---|---|
| 1 | 2+ Level 9 monsters / You can also Xyz Summon this card by using 1 Rank 8 Dragon Xyz Monster you control as material. (Transfer its materials to this card.) | `aux.AddXyzProcedure`, `s.xyzfilter` | L8, L59–61 | Compliant |
| 2 | You cannot Special Summon monsters, except LIGHT or DARK Dragon monsters, the turn you Xyz Summon this card. | `Duel.AddCustomActivityCounter`, `s.xyzlimit`, `s.limop` | L9–23, L57–83 | Compliant |
| 3 | This card cannot be targeted by card effects. | `e2` (`EFFECT_CANNOT_BE_EFFECT_TARGET`) | L25–31 | Compliant |
| 4 | When a card or effect is activated that targets a monster you control (Quick Effect): You can detach 1 material from this card, and target 1 card your opponent controls; destroy that target. | `e3`, `s.descon`, `s.descost`, `s.destg`, `s.desop` | L33–45, L87–107 | Compliant |
| 5 | During the End Phase: You can target 1 Dragon Monster you control; attach that target to this card as material. | `e4`, `s.mattg`, `s.matop` | L47–56, L108–124 | Compliant |
| 6 | You can only use each effect of "Aetherstorm Zenith Wire-Tailed Sypharion" once per turn. | `e3:SetCountLimit`, `e4:SetCountLimit` | L40, L53 | Compliant |

- **Audit Findings**:
  - `s.descon` queries `CHAININFO_TARGET_CARDS` to ensure an activated effect targets a monster controlled by `tp`.
  - **Status**: **Clean / Compliant**.

---

### CARD-0020: Armored Nova Mecha-Scaled Xyrion
- **Passcode**: `224274662` | **Set**: `TATA-019 Tainted Tails` | **Archetype**: `Armored Nova`
- **Type**: Rank 9 LIGHT Dragon Xyz Effect Monster | **ATK**: 3500 / **DEF**: 3000
- **Script Path**: `public/CCG Downloads/CCG_Scripts/c224274662.lua`

#### Clause Breakdown & Lua Mapping Table
| # | Card Text Clause | Script Function / Callback | Line Numbers | Status / Issue |
|---|---|---|---|---|
| 1 | 2+ Level 9 Monsters / You can also Xyz Summon this card by using 1 Rank 8 Dragon Xyz Monster you control as material. (Transfer its materials to this card.) | `aux.AddXyzProcedure`, `s.ovfilter` | L6, L50–52 | Compliant |
| 2 | You cannot Special Summon monsters the turn this card is Xyz Summoned, except LIGHT or DARK Dragon Monsters. | `s.xyzlimit`, `s.regop` | L8–22, L53–75 | Compliant |
| 3 | Once per turn, when a card or effect is activated (Quick Effect): You can detach 1 material from this card; negate the activation. | `e3`, `s.negcon`, `s.negcost`, `s.negtg`, `s.negop` | L24–36, L76–89 | Compliant |
| 4 | During the End Phase, if this Xyz Summoned card has no materials: You can destroy it, and if you do, Special Summon 1 Rank 8 Dragon Xyz Monster from your GY, but negate its effects, also its ATK/DEF become 0. | `e4`, `s.spcon`, `s.sptg`, `s.spop` | L38–48, L90–133 | Compliant |
| 5 | You can only use each effect of "Armored Nova Mecha-Scaled Xyrion" once per turn. | `e3:SetCountLimit`, `e4:SetCountLimit` | L31, L44 | Compliant |

- **Audit Findings**:
  - `s.spop` correctly destroys `c`, Special Summons the target, and registers `EFFECT_DISABLE`, `EFFECT_DISABLE_EFFECT`, `EFFECT_SET_ATTACK_FINAL` (0), and `EFFECT_SET_DEFENSE_FINAL` (0).
  - **Status**: **Clean / Compliant**.

---

### CARD-0021: Solemn Rebirth
- **Passcode**: `224049334` | **Set**: `TATA-021 Tainted Tails` | **Archetype**: `Solemn`
- **Type**: Continuous Trap Card
- **Script Path**: `public/CCG Downloads/CCG_Scripts/c224049334.lua`

#### Clause Breakdown & Lua Mapping Table
| # | Card Text Clause | Script Function / Callback | Line Numbers | Status / Issue |
|---|---|---|---|---|
| 1 | Activation | `e1` | L5–9 | Compliant |
| 2 | You can banish this card from your field or GY; Set all Spell/Trap Cards that were destroyed by your opponent's card effects this turn from your GY to your Spell & Trap Zone. | `e2`, `global_check`, `checkop`, `s.setcost`, `s.settg`, `s.setop` | L11–28, L30–61 | Compliant |

- **Audit Findings**:
  - `checkop` (L30–37) registers a flag effect on destroyed S/T cards. `s.settg` and `s.setop` verify available S/T zones (`ft`) and batch-set matching cards via `Duel.SSet`.
  - **Status**: **Clean / Compliant**.

---

### CARD-0022: Talismandrake Spark
- **Passcode**: `230947464` | **Set**: `TATA-022 Tainted Tails` | **Archetype**: `Talismandrake`
- **Type**: Level 3 DARK Pyro Pendulum Effect Monster | **Scale**: 7 | **ATK**: 1200 / **DEF**: 500
- **Script Path**: `public/CCG Downloads/CCG_Scripts/c230947464.lua`

#### Clause Breakdown & Lua Mapping Table
| # | Card Text Clause | Script Function / Callback | Line Numbers | Status / Issue |
|---|---|---|---|---|
| 1 | Pendulum Effect: You cannot Pendulum Summon monsters, except Pyro Monsters. | `e1`, `s.splimit` | L8–15, L56–58 | Compliant |
| 2 | Pendulum Effect: If you Fusion Summon a Pyro Fusion Monster: You can inflict 500 damage to your opponent. | `e2`, `s.damcon`, `s.damtg`, `s.damop` | L17–28, L59–74 | Compliant |
| 3 | Monster Effect: If this card is Normal or Special Summoned: You can add 1 "Talismandrake" monster from your Deck or face-up Extra Deck to your hand, except "Talismandrake Spark". | `e3`, `e4`, `s.thtg`, `s.thop` | L30–42, L75–90 | Compliant |
| 4 | Monster Effect: If a DARK Pyro Fusion Monster is Fusion Summoned to your field: You can place this card from your face-up Extra Deck in your Pendulum Zone. | `e5`, `s.pzcon`, `s.pztg`, `s.pzop` | L44–54, L91–107 | Compliant |
| 5 | You can only use each effect of "Talismandrake Spark" once per turn. | `SetCountLimit` on `e2`, `e3`, `e5` | L24, L36, L50 | Compliant |

- **Audit Findings**:
  - `s.pzop` correctly moves the card from face-up Extra Deck into the Pendulum Zone using `Duel.MoveToField(c, tp, tp, LOCATION_PZONE, POS_FACEUP, true)`.
  - **Status**: **Clean / Compliant**.

---

### CARD-0023: Talismandrake Embers
- **Passcode**: `256928871` | **Set**: `TATA-024 Tainted Tails` | **Archetype**: `Talismandrake`
- **Type**: Level 4 DARK Pyro Pendulum Effect Monster | **Scale**: 7 | **ATK**: 1600 / **DEF**: 500
- **Script Path**: `public/CCG Downloads/CCG_Scripts/c256928871.lua`

#### Clause Breakdown & Lua Mapping Table
| # | Card Text Clause | Script Function / Callback | Line Numbers | Status / Issue |
|---|---|---|---|---|
| 1 | Pendulum Effect: You cannot Pendulum Summon monsters, except Pyro Monsters. | `e1`, `s.splimit` | L8–15, L58–60 | Compliant |
| 2 | Pendulum Effect: You can target 1 "Talismandrake" Fusion Monster in your GY; Special Summon it, but return it to the Extra Deck when it leaves the field. | `e2`, `s.sptg`, `s.spop` | L17–26, L61–91 | Compliant |
| 3 | Monster Effect: If this card is Summoned while you control another "Talismandrake" monster, except "Talismandrake Embers": You can draw 1 card. | `e3`–`e5`, `s.drcon`, `s.drtg`, `s.drop` | L28–44, L92–107 | Compliant |
| 4 | Monster Effect: If a DARK Pyro Fusion monster is Fusion Summoned to your field: You can place this card from your face-up Extra Deck in your Pendulum Zone. | `e6`, `s.pzcon`, `s.pztg`, `s.pzop` | L46–56, L108–124 | Compliant |
| 5 | You can only use each effect of "Talismandrake Embers" once per turn. | `SetCountLimit` on `e2`, `e3`, `e6` | L23, L34, L52 | Compliant |

- **Audit Findings**:
  - `spop` registers `EFFECT_LEAVE_FIELD_REDIRECT` with value `LOCATION_EXTRA` on the summoned Fusion Monster, accurately returning it to the Extra Deck when leaving the field.
  - **Status**: **Clean / Compliant**.

---

### CARD-0024: Talismandrake Heat
- **Passcode**: `210506870` | **Set**: `TATA-023 Tainted Tails` | **Archetype**: `Talismandrake`
- **Type**: Level 4 DARK Pyro Pendulum Effect Monster | **Scale**: 7 | **ATK**: 1400 / **DEF**: 500
- **Script Path**: `public/CCG Downloads/CCG_Scripts/c210506870.lua`

#### Clause Breakdown & Lua Mapping Table
| # | Card Text Clause | Script Function / Callback | Line Numbers | Status / Issue |
|---|---|---|---|---|
| 1 | Pendulum Effect: You cannot Pendulum Summon monsters, except Pyro Monsters. | `e1`, `s.splimit` | L8–15, L58–60 | Compliant |
| 2 | Pendulum Effect: You can target 1 DARK Pyro Fusion Monster in your GY; return it to the Extra Deck, and if you do, return this card to the hand. | `e2`, `s.rttg`, `s.rtop` | L17–26, L61–80 | Compliant |
| 3 | Monster Effect: Gains 200 ATK for each “Talismandrake” Spell/Trap you control that is equipped to a monster. | `e3`, `s.atkval`, `s.eqfilter` | L28–34, L81–87 | Compliant |
| 4 | Monster Effect: If you control a DARK Pyro monster: You can Special Summon this card from your hand. | `e4`, `s.hspcon`, `s.hsptg`, `s.hspop` | L36–45, L88–103 | Compliant |
| 5 | Monster Effect: During the Main Phase: You can Fusion Summon 1 DARK Pyro Fusion Monster from your Extra Deck, using monsters from your hand or field as material. | `e5`, `s.fustg`, `s.fusop` | L47–56, L104–168 | Compliant |
| 6 | You can only use each effect of "Talismandrake Heat" once per turn. | `SetCountLimit` on `e2`, `e4`, `e5` | L23, L41, L52 | Compliant |

- **Audit Findings**:
  - `s.eqfilter` counts face-up "Talismandrake" Spells/Traps controlled in S/T zone that return non-nil for `GetEquipTarget()`.
  - **Status**: **Clean / Compliant**.

---

### CARD-0025: Talismandrake Sear
- **Passcode**: `245935439` | **Set**: `TATA-025 Tainted Tails` | **Archetype**: `Talismandrake`
- **Type**: Level 5 DARK Pyro Pendulum Effect Monster | **Scale**: 2 | **ATK**: 2000 / **DEF**: 500
- **Script Path**: `public/CCG Downloads/CCG_Scripts/c245935439.lua`

#### Clause Breakdown & Lua Mapping Table
| # | Card Text Clause | Script Function / Callback | Line Numbers | Status / Issue |
|---|---|---|---|---|
| 1 | Pendulum Effect: During your Main Phase, or if your opponent activates a card or effect: You can Fusion Summon 1 "Talismandrake" Fusion Monster from your Extra Deck, using monsters from you control or in your Pendulum Zone as material. | `e1`, `e2`, `s.qfuscon`, `s.fustg`, `s.fusop` | L8–23, L37–104 | Compliant |
| 2 | Monster Effect: If this card is used as material for the Fusion Summon of a "Talismandrake" monster: You can Special Summon 1 "Talismandrake" monster from your Pendulum Zone, also, you can place 1 "Talismandrake" Pendulum Monster from your face-up Extra Deck in your Pendulum Zone. | `e3`, `s.matcon`, `s.pstg`, `s.psop` | L25–35, L105–140 | Compliant |
| 3 | You can only use this effect of "Talismandrake Sear" once per turn. | `SetCountLimit` on `e1`/`e2` & `e3` | L13, L31 | Compliant |

- **Audit Findings**:
  - `s.matcon` checks `r == REASON_FUSION` and `rc:IsSetCard(SET_TALISMANDRAKE)` where `rc = c:GetReasonCard()` (the summoned Fusion Monster). This accurately verifies material usage.
  - **Status**: **Clean / Compliant**.

---

I confirm that I modified no files.

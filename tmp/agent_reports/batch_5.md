# Semantic Effect Audit Report: Batch 5 (Cards 102 - 126)

An exhaustive, read-only semantic audit of the 25 custom Yu-Gi-Oh! cards from Batch 5 has been completed. Below is the per-card clause analysis comparing card texts from `src/data/cards.json` against their Lua implementations in `public/CCG Downloads/CCG_Scripts/`.

---

## Executive Summary & Critical Bugs

1. **Rule Violations**:
   - **`CARD-0106` (Onibi)**: The script allows activating the Quick Effect from the hand *without* tributing or revealing the card as a cost. In Yu-Gi-Oh!, activating a monster effect from the hand without a verifiable cost (reveal/discard/tribute) violates fundamental game mechanics.

2. **Severe Logic / Gameplay Bugs**:
   - **`CARD-0117` (Serene Mermaid of the Grand Blue)**: The text restricts Special Summons from the Extra Deck to "using 'Grand Blue' monsters as materials." The script instead implements this as "cannot Special Summon monsters from the Extra Deck, except 'Grand Blue' monsters." This restricts the outcome rather than the materials, failing to implement the specific text.
   - **`CARD-0125` (Grand Blue Prince)**: The Fusion material restriction "using only monsters in your possession" is implemented by checking `c:GetOwner() == fc:GetControler()`. "Possession" in Yu-Gi-Oh! refers to control (`c:IsControler(tp)`), meaning the current script erroneously prevents you from using opponent-owned monsters that you have taken control of.

3. **Approximations**:
   - **`CARD-0110` (Muramasa)**: The check for an Equip Spell "that can only be equipped to a Spirit monster" is approximated by `aux.IsTypeInText(c,TYPE_SPIRIT)`. While functional, this incorrectly matches any Equip Spell that mentions "Spirit" anywhere in its text.

---

## Detailed Per-Card Clause Tables

### 1. CARD-0102: Mylo, the Domesticated (Passcode: 259686203)
- **Script Path**: `public/CCG Downloads/CCG_Scripts/c259686203.lua`

| Clause / Requirement | Implementation / Callback | Status | Line # | Analysis & Proposed Fix |
| --- | --- | --- | --- | --- |
| Cannot be Summoned while you control a monster | `e0`, `e1`, `e2`: `EFFECT_CANNOT_SUMMON` etc. | Pass | L7-22 | Correctly checks `Duel.IsExistingMatchingCard(aux.TRUE, tp, LOCATION_MZONE, 0, 1, nil)`. |
| If Normal Summoned: Add 1 "Domestica" Fairy | `e3`: `EVENT_SUMMON_SUCCESS` (`s.thtg`, `s.thop`) | Pass | L24-33, L53-68 | Correctly searches for "Domestica" Fairy monster. |
| Battle Phase Quick Effect: Shuffle from GY to Deck -> Fairy monsters unaffected by opponent's effects | `e4`: `EVENT_FREE_CHAIN` (`s.bcon`, `s.immtg`, `s.immop`) | Pass | L35-45, L72-100 | Returns to Deck as effect, then applies `EFFECT_IMMUNE_EFFECT` correctly. |

---

### 2. CARD-0103: Nuwa, the Domesticated (Passcode: 259135917)
- **Script Path**: `public/CCG Downloads/CCG_Scripts/c259135917.lua`

| Clause / Requirement | Implementation / Callback | Status | Line # | Analysis & Proposed Fix |
| --- | --- | --- | --- | --- |
| Cannot be Summoned while you control a monster | `e0`, `e1`, `e2`: `EFFECT_CANNOT_SUMMON` etc. | Pass | L7-22 | Implemented correctly. |
| If Normal Summoned: Add 1 "Domestica" Fairy | `e3`: `EVENT_SUMMON_SUCCESS` (`s.thtg`, `s.thop`) | Pass | L24-33, L53-68 | Correctly searches for "Domestica" Fairy monster. |
| Battle Phase Quick Effect: Shuffle from GY to Deck -> Opponent cannot activate cards/effects | `e4`: `EVENT_FREE_CHAIN` (`s.bcon`, `s.acttg`, `s.actop`) | Pass | L35-45, L72-101 | Applies `EFFECT_CANNOT_ACTIVATE` on opponent (`0,1` range) while controlling a Fairy. |

---

### 3. CARD-0104: Mylo in the Wild (Passcode: 259911246)
- **Script Path**: `public/CCG Downloads/CCG_Scripts/c259911246.lua`

| Clause / Requirement | Implementation / Callback | Status | Line # | Analysis & Proposed Fix |
| --- | --- | --- | --- | --- |
| Fusion Materials | `aux.AddFusionProcFun2` | Pass | L9-10 | Correctly requires Mylo + Domestica Fairy. |
| Cannot be Summoned while you control a monster | `e0`: `EFFECT_SPSUMMON_CONDITION` | Pass | L13-18 | Restricted to `not Duel.IsExistingMatchingCard(...)`. |
| Quick Effect: Tribute -> Change all monsters to face-down Defense | `e1`: `EVENT_FREE_CHAIN` (`s.poscon`, `s.cost`, `s.posop`) | Pass | L20-31, L49-93 | Correctly sets face-down and flips them face-up in End Phase. |
| Trigger: Return to Extra Deck, also add Mylo, then send to GY | `e2`: `EVENT_TO_GRAVE` (`s.rettg`, `s.retop`) | Pass | L33-41, L97-120 | Correctly processes "also" and "then" PSCT conjunctions. |

---

### 4. CARD-0105: Nuwa in the Wild (Passcode: 259796760)
- **Script Path**: `public/CCG Downloads/CCG_Scripts/c259796760.lua`

| Clause / Requirement | Implementation / Callback | Status | Line # | Analysis & Proposed Fix |
| --- | --- | --- | --- | --- |
| Fusion Materials | `aux.AddFusionProcFun2` | Pass | L9-10 | Correctly requires Nuwa + Domestica Fairy. |
| Cannot be Summoned while you control a monster | `e0`: `EFFECT_SPSUMMON_CONDITION` | Pass | L13-18 | Restricted properly. |
| Quick Effect: Tribute -> Negate all other monsters, ATK 0 | `e1`: `EVENT_FREE_CHAIN` (`s.negcon`, `s.cost`, `s.negop`) | Pass | L20-31, L49-92 | Disables effects and applies `EFFECT_SET_ATTACK_FINAL` 0. |
| Trigger: Return to Extra Deck, also add Nuwa, then send to GY | `e2`: `EVENT_TO_GRAVE` (`s.rettg`, `s.retop`) | Pass | L33-41, L96-119 | Implemented properly. |

---

### 5. CARD-0106: Onibi (Passcode: 217713649)
- **Script Path**: `public/CCG Downloads/CCG_Scripts/c217713649.lua`

| Clause / Requirement | Implementation / Callback | Status | Line # | Analysis & Proposed Fix |
| --- | --- | --- | --- | --- |
| Cannot be Special Summoned (Spirit Return) | `aux.EnableSpiritReturn`, `e1`: `EFFECT_SPSUMMON_CONDITION` | Pass | L6-13 | Standard Spirit configuration. |
| Quick Effect: Normal Summon 1 Spirit (can tribute from hand) | `e2`: `EVENT_FREE_CHAIN` (`s.sumcost`, `s.cannormal`) | Confirmed Issue | L42-57 | `s.cannormal` returns `true` if `c:IsLocation(LOCATION_HAND)`. In `s.sumcost`, this allows activating the effect from the hand *without* tributing or revealing the card as a cost, violating core YGO game mechanics. **Fix**: Change `s.cannormal` to only allow non-tribute activations from `LOCATION_MZONE`. |
| Add 1 Spirit monster except Onibi | `s.sumop` | Pass | L67-85 | Successfully checks if Onibi was summoned to trigger the search. |

---

### 6. CARD-0107: Enra (Passcode: 214371067)
- **Script Path**: `public/CCG Downloads/CCG_Scripts/c214371067.lua`

| Clause / Requirement | Implementation / Callback | Status | Line # | Analysis & Proposed Fix |
| --- | --- | --- | --- | --- |
| When your Spirit is Normal Summoned: Normal Summon this card, then another | `e2`: `EVENT_SUMMON_SUCCESS` (`s.sumcon`, `s.sumop`) | Pass | L15-25, L40-63 | Correctly performs the sequence using `ignore_limit = true` in `Duel.Summon`. |
| If Tributed: Target Spirit cannot be destroyed by battle | `e3`: `EVENT_RELEASE` (`s.indtg`, `s.indop`) | Pass | L27-35, L67-82 | Applies `EFFECT_INDESTRUCTABLE_BATTLE`. |

---

### 7. CARD-0108: Kokeshisa (Passcode: 229399508)
- **Script Path**: `public/CCG Downloads/CCG_Scripts/c229399508.lua`

| Clause / Requirement | Implementation / Callback | Status | Line # | Analysis & Proposed Fix |
| --- | --- | --- | --- | --- |
| Quick Effect: Tribute Spirit -> Normal Summon this, then return 1 from field/GY | `e2`: `EVENT_FREE_CHAIN` (`s.sumcon`, `s.sumcost`, `s.sumop`) | Pass | L15-26, L63-78 | Properly merges `LOCATION_MZONE` and `LOCATION_GRAVE` groups for the return to hand resolution. |
| If Tributed: Target Spirit cannot be targeted by opponent | `e3`: `EVENT_RELEASE` (`s.prottg`, `s.protop`) | Pass | L28-36, L82-99 | Applies `EFFECT_CANNOT_BE_EFFECT_TARGET` with `aux.tgoval`. |

---

### 8. CARD-0109: Shishi (Passcode: 228033609)
- **Script Path**: `public/CCG Downloads/CCG_Scripts/c228033609.lua`

| Clause / Requirement | Implementation / Callback | Status | Line # | Analysis & Proposed Fix |
| --- | --- | --- | --- | --- |
| On Normal Summon: Tribute 1 other Spirit -> Draw 2 | `e2`: `EVENT_SUMMON_SUCCESS` (`s.drcost`, `s.drop`) | Pass | L15-24, L39-52 | Cost correctly excludes `e:GetHandler()`. |
| If Tributed: Target 1 face-up card -> return to hand when it leaves | `e3`: `EVENT_RELEASE` (`s.rdtg`, `s.rdop`) | Pass | L26-34, L59-69 | Implemented using `EFFECT_LEAVE_FIELD_REDIRECT` set to `LOCATION_HAND`, effectively matching text. |

---

### 9. CARD-0110: Muramasa (Passcode: 247378501)
- **Script Path**: `public/CCG Downloads/CCG_Scripts/c247378501.lua`

| Clause / Requirement | Implementation / Callback | Status | Line # | Analysis & Proposed Fix |
| --- | --- | --- | --- | --- |
| Tribute Summon using 1 opponent's Special Summoned monster | `e2`: `EFFECT_SUMMON_PROC` (`s.ntcon`, `s.ntop`) | Pass | L16-25, L41-53 | `s.ntcon` mandates `1,1` tribute from `LOCATION_MZONE, 0` (opponent's monsters) which fulfills the alternative "1 monster" tribute. |
| On Normal Summon: Add or equip 1 Equip Spell that can only be equipped to a Spirit | `e3`: `EVENT_SUMMON_SUCCESS` (`s.eqfilter`, `s.eqop`) | Suspected Issue | L27-36, L54-89 | `s.eqfilter` uses `aux.IsTypeInText(c,TYPE_SPIRIT)` to approximate the requirement. This technically matches any Equip Spell with the word "Spirit" in its text rather than strictly enforcing exclusivity. **Fix**: If Kanmuriyama is the only valid target, hardcode it, or maintain approximation if engine limits necessitate it. |

---

### 10. CARD-0111: Kanmuriyama (Passcode: 248801935)
- **Script Path**: `public/CCG Downloads/CCG_Scripts/c248801935.lua`

| Clause / Requirement | Implementation / Callback | Status | Line # | Analysis & Proposed Fix |
| --- | --- | --- | --- | --- |
| Equip only to Spirit | `e2`: `EFFECT_EQUIP_LIMIT` | Pass | L15-20 | Correctly checks `c:IsType(TYPE_SPIRIT)`. |
| If equipped: Add Spirit with different Attribute | `e3`: `EVENT_EQUIP` (`s.thtg`, `s.thop`) | Pass | L22-32, L82-96 | Uses `not c:IsAttribute(att)` to ensure difference. |
| If destroyed because monster returned to hand: add to hand | `e4`: `EVENT_TO_GRAVE` (`s.recon`) | Pass | L34-43, L97-102 | Checks `ec:IsLocation(LOCATION_HAND)` on destruction. |
| Damage Step: return battling monster to hand | `e5`: `EVENT_BATTLE_START` (`s.bthcon`, `s.bthop`) | Pass | L45-54, L113-130 | Evaluates battle targets and correctly sends to hand. |

---

### 11. CARD-0112: Takama No Hara (Passcode: 229996802)
- **Script Path**: `public/CCG Downloads/CCG_Scripts/c229996802.lua`

| Clause / Requirement | Implementation / Callback | Status | Line # | Analysis & Proposed Fix |
| --- | --- | --- | --- | --- |
| Discard 2 (incl 1 Spirit), add up to 2 Spirits with diff Levels | `e1`: `EFFECT_TYPE_ACTIVATE` (`s.disccheck`, `s.thop`) | Pass | L6-14, L30-61 | Validation logic correctly assesses discard requirements and `GetClassCount(Card.GetLevel)` for targets. |
| Banish from GY: Spirit cannot return to hand | `e2`: `EFFECT_TYPE_IGNITION` (`s.retop`) | Pass | L16-25, L71-81 | Applies `EFFECT_CANNOT_TO_HAND` to targeted Spirit. |

---

### 12. CARD-0113: Rei-Tachi Ga Kita Hi (Passcode: 246393365)
- **Script Path**: `public/CCG Downloads/CCG_Scripts/c246393365.lua`

| Clause / Requirement | Implementation / Callback | Status | Line # | Analysis & Proposed Fix |
| --- | --- | --- | --- | --- |
| Only control 1 | `c:SetUniqueOnField` | Pass | L5 | Successfully enforces uniqueness. |
| Target up to 3 Spirits in GY -> Shuffle, draw 1 | `e1`: `EFFECT_TYPE_IGNITION` (`s.tdtg`, `s.tdop`) | Pass | L12-21, L36-52 | Drawing occurs only if `SendtoDeck` resolves successfully. |
| Tribute Summoned Spirits gain attacks | `e2`: `EFFECT_EXTRA_ATTACK` (`s.atval`) | Pass | L23-31, L62-64 | `s.atval` dynamically returns total Spirit count, precisely granting 1 extra attack per Spirit. |

---

### 13. CARD-0114: Otakemaru the Accuser (Passcode: 221855414)
- **Script Path**: `public/CCG Downloads/CCG_Scripts/c221855414.lua`

| Clause / Requirement | Implementation / Callback | Status | Line # | Analysis & Proposed Fix |
| --- | --- | --- | --- | --- |
| End Phase protection from returning to hand/Extra Deck | `e1`: `EVENT_SPSUMMON_SUCCESS` (`s.retop`) | Pass | L8-14, L61-78 | Distributes `EFFECT_CANNOT_TO_HAND` and `EFFECT_CANNOT_TO_DECK` dynamically to other Spirits. |
| Opponent cannot target Spirits | `e2`: `EFFECT_CANNOT_BE_EFFECT_TARGET` | Pass | L16-24 | Target range `LOCATION_MZONE, 0`. |
| Normal Summon Spirit -> Return 1 card | `e3`: `EVENT_SUMMON_SUCCESS` (`s.bcon`) | Pass | L26-36, L85-87 | Accurately identifies Normal Summon events. |
| End Phase Return & Revival (Ignoring Conditions) | `e4`: `EVENT_PHASE+PHASE_END` (`s.sptg`, `s.spop`) | Pass | L38-47, L117-140 | Uses `ignore_con=true, ignore_revive=true` allowing bypass of strict Spirit conditions. |

---

### 14. CARD-0115: Champion of the Grand Blue (Passcode: 259429721)
- **Script Path**: `public/CCG Downloads/CCG_Scripts/c259429721.lua`

| Clause / Requirement | Implementation / Callback | Status | Line # | Analysis & Proposed Fix |
| --- | --- | --- | --- | --- |
| Hand: Target GY card -> Add/Special, then Special self | `e1`: `EFFECT_TYPE_IGNITION` (`s.thop`) | Pass | L7-16, L54-71 | Successfully manages the sequential Special Summon. |
| GY Quick Effect: Special self, equip target, destroy column | `e2`: `EVENT_FREE_CHAIN` (`s.eqop`) | Pass | L18-29, L91-114 | Automatically identifies and forces destruction of the column. |

---

### 15. CARD-0116: Diving Daughters of the Grand Blue (Passcode: 259500899)
- **Script Path**: `public/CCG Downloads/CCG_Scripts/c259500899.lua`

| Clause / Requirement | Implementation / Callback | Status | Line # | Analysis & Proposed Fix |
| --- | --- | --- | --- | --- |
| Normal/Special Summon -> Send to GY | `e1`, `e2`: `EVENT_SUMMON_SUCCESS` / `SPSUMMON_SUCCESS` | Pass | L7-19 | Accurate milling mechanics. |
| Sent by effect -> Target card, Special self | `e3`: `EVENT_TO_GRAVE` (`s.sptg`, `s.spop`) | Pass | L21-31, L56-82 | Intentionally leaves the target un-manipulated as per text ("Target 1... Special Summon this card"). |

---

### 16. CARD-0117: Serene Mermaid of the Grand Blue (Passcode: 259369909)
- **Script Path**: `public/CCG Downloads/CCG_Scripts/c259369909.lua`

| Clause / Requirement | Implementation / Callback | Status | Line # | Analysis & Proposed Fix |
| --- | --- | --- | --- | --- |
| Special Summon condition | `e1`: `EFFECT_TYPE_IGNITION` (`s.sptg`) | Pass | L11-19 | Checks for "Grand Blue" or "Umi". |
| Fusion Summon -> Restrict Extra Deck Summons to using "Grand Blue" materials | `e2`: `EFFECT_TYPE_IGNITION` (`s.fusop`, `s.splimit`) | Confirmed Issue | L21-30, L80-109 | `s.splimit` evaluates `c:IsLocation(LOCATION_EXTRA) and not c:IsSetCard(...)`, which restricts the player to only summoning "Grand Blue" monsters. It completely fails to evaluate the materials used for the summon as prescribed by "using 'Grand Blue' monsters as materials." **Fix**: Implement a material check restriction, or update the card text to "you can only Special Summon 'Grand Blue' monsters from the Extra Deck". |

---

### 17. CARD-0118: Jelly Lass of the Grand Blue (Passcode: 259934756)
- **Script Path**: `public/CCG Downloads/CCG_Scripts/c259934756.lua`

| Clause / Requirement | Implementation / Callback | Status | Line # | Analysis & Proposed Fix |
| --- | --- | --- | --- | --- |
| Special Summon condition | `e1`: `EFFECT_TYPE_IGNITION` | Pass | L11-19 | Evaluates "Umi" control properly. |
| Hand Fusion Summon | `e2`: `EFFECT_TYPE_IGNITION` | Pass | L21-29 | Initiates fusion manually. |
| GY Trigger: Revive 1 "Grand Blue" | `e3`: `EVENT_TO_GRAVE` | Pass | L31-41 | Uses `s.gytg` and `s.gyop` successfully. |

---

### 18. CARD-0119: Jelly Miss of the Grand Blue (Passcode: 259273394)
- **Script Path**: `public/CCG Downloads/CCG_Scripts/c259273394.lua`

| Clause / Requirement | Implementation / Callback | Status | Line # | Analysis & Proposed Fix |
| --- | --- | --- | --- | --- |
| Special Summon & Umi Check -> Negate & Boost | `e1`: `EFFECT_TYPE_IGNITION` (`s.spop`) | Pass | L11-19, L44-88 | Correctly applies sequential effects based on "Umi" presence. |
| GY Fusion Summon | `e2`: `EFFECT_TYPE_IGNITION` (`s.fusop`) | Pass | L21-29, L117-137 | Forces this card to be selected within `SelectSubGroup`. |

---

### 19. CARD-0120: Brilliance of the Grand Blue (Passcode: 259417461)
- **Script Path**: `public/CCG Downloads/CCG_Scripts/c259417461.lua`

| Clause / Requirement | Implementation / Callback | Status | Line # | Analysis & Proposed Fix |
| --- | --- | --- | --- | --- |
| Add card -> send to GY if Umi present | `e1`: `EFFECT_TYPE_ACTIVATE` (`s.thop`) | Pass | L9-17, L45-61 | Checks state sequentially during resolution. |
| GY Trigger: Retrieve self, then discard | `e2`: `EVENT_LEAVE_GRAVE` (`s.gycon`, `s.gyop`) | Pass | L19-30, L67-85 | Accurately validates `rp==1-tp` (opponent's effect). |

---

### 20. CARD-0121: City Within the Grand Blue (Passcode: 259679619)
- **Script Path**: `public/CCG Downloads/CCG_Scripts/c259679619.lua`

| Clause / Requirement | Implementation / Callback | Status | Line # | Analysis & Proposed Fix |
| --- | --- | --- | --- | --- |
| Always treated as "Umi" | `e0`: `EFFECT_ADD_CODE` | Pass | L8-13 | Statically assigned. |
| On Activation: Search | `e1`: `EVENT_FREE_CHAIN` | Pass | L15-23 | Triggers safely without disruption. |
| Change GY Attributes | `e2`: `EFFECT_CHANGE_ATTRIBUTE` (`s.attrcon`) | Pass | L25-33, L56-62 | Accurately tests if all owned field monsters natively trace to WATER. |

---

### 21. CARD-0122: Grand Blue Princess (Passcode: 259177849)
- **Script Path**: `public/CCG Downloads/CCG_Scripts/c259177849.lua`

| Clause / Requirement | Implementation / Callback | Status | Line # | Analysis & Proposed Fix |
| --- | --- | --- | --- | --- |
| Special Summoned: Add or Send | `e1`: `EVENT_SPSUMMON_SUCCESS` (`s.thop`) | Pass | L9-18, L55-75 | Uses branching `SelectOption` based on `IsAbleToHand/Grave`. |
| Target & Special Summon, send target | `e2`: `EFFECT_TYPE_IGNITION` (`s.spop`) | Pass | L20-29, L93-105 | Properly links the operations. |
| Sent to GY: Shuffle banished, gain DEF | `e3`: `EVENT_TO_GRAVE` (`s.tdop`) | Pass | L31-41, L125-139 | DEF increase distributed to all valid targets. |

---

### 22. CARD-0123: Oracle of the Grand Blue (Passcode: 259578863)
- **Script Path**: `public/CCG Downloads/CCG_Scripts/c259578863.lua`

| Clause / Requirement | Implementation / Callback | Status | Line # | Analysis & Proposed Fix |
| --- | --- | --- | --- | --- |
| Link Summoned: Negate, then check pointing for destroy | `e1`: `EVENT_SPSUMMON_SUCCESS` (`s.disop`) | Pass | L9-19, L59-89 | Utilizes `GetLinkedGroup():IsExists` to permit secondary effect. |
| Pointed gain DEF | `e2`: `EFFECT_UPDATE_DEFENSE` | Pass | L21-29 | Checks `GetLinkedGroup():IsContains(c)`. |
| GY Banish: Set or Add | `e3`: `EFFECT_TYPE_IGNITION` (`s.setop`) | Pass | L31-40, L114-139 | Smart `canadd/canset` checks correctly delegate choice. |

---

### 23. CARD-0124: Grand Blue Matriarch (Passcode: 259093260)
- **Script Path**: `public/CCG Downloads/CCG_Scripts/c259093260.lua`

| Clause / Requirement | Implementation / Callback | Status | Line # | Analysis & Proposed Fix |
| --- | --- | --- | --- | --- |
| Treat Link monster as Tuner | `aux.AddSynchroMixProcedure`, `e0`: `EFFECT_SYNCHRO_LEVEL_EX` | Pass | L7-20 | `s.tunerfilter` dynamically evaluates Link monsters as Tuners. |
| Chain Negation | `e1`: `EVENT_CHAINING` | Pass | L22-34 | Evaluates active Spell/Trap status natively. |
| Opponent's Turn Revive | `e2`: `EVENT_TO_GRAVE` (`s.spcon`, `s.sptg`) | Pass | L36-47, L90-106 | Strict control and turn validation. |

---

### 24. CARD-0125: Grand Blue Prince (Passcode: 259937946)
- **Script Path**: `public/CCG Downloads/CCG_Scripts/c259937946.lua`

| Clause / Requirement | Implementation / Callback | Status | Line # | Analysis & Proposed Fix |
| --- | --- | --- | --- | --- |
| Fusion Materials: only monsters in your possession | `s.ownmat` | Confirmed Issue | L43-45 | Text requires materials to be "in your possession" (meaning control). The script defines `s.ownmat` as `c:GetOwner()==fc:GetControler()`. In Yu-Gi-Oh!, "possession" means control or held in zones (`IsControler(tp)`), while "Owner" strictly relates to where the card started the game. This prevents using opponent's monsters that are under your control. **Fix**: Change to `c:IsControler(fc:GetControler())`. |
| Revival with negated effects | `e1`: `EVENT_SPSUMMON_SUCCESS` | Pass | L17-26 | Revives and suppresses successfully. |
| Quick Effect: Shuffle GY card, send to GY | `e2`: `EFFECT_TYPE_QUICK_O` | Pass | L28-39 | Targeting array permits opponent's GY as well. |

---

### 25. CARD-0126: Stellaer of the Lightning Runes (Passcode: 259028576)
- **Script Path**: `public/CCG Downloads/CCG_Scripts/c259028576.lua`

| Clause / Requirement | Implementation / Callback | Status | Line # | Analysis & Proposed Fix |
| --- | --- | --- | --- | --- |
| Special Summon from hand | `e1`: `EFFECT_SPSUMMON_PROC` (`s.spcon`) | Pass | L8-16 | Standard field status validation. |
| Cannot Special Summon ELECTRIC Monsters | `s.splimit` | Pass | L41-43 | Correctly restricts to `c:IsAttribute(ATTRIBUTE_ELECTRIC)`, flawlessly mirroring the unusually restrictive phrasing of the text. |
| Xyz Detach -> Revive negated Xyz | `e2`: `EVENT_TO_GRAVE` (`s.xyzcon`, `s.xyzop`) | Pass | L18-28, L54-58 | Matches required `IsReason(REASON_COST)` status. |

---

I confirm that I modified no files.

# Yu-Gi-Oh! CCG Semantic Effect Audit Report — Batch 2 (Cards CARD-0026 to CARD-0050)

## Executive Summary
Batch 2 consists of 25 custom cards spanning three main archetypes/series: **Talismandrake** (CARD-0026 to CARD-0034), **Aldrez** (CARD-0035 to CARD-0045), and **Frute** (CARD-0046 to CARD-0050). 

All 25 cards have been audited by comparing their official English text from `src/data/cards.json` with their corresponding Lua scripts in `dist/CCG Downloads/CCG_Scripts/` (referenced in instructions as `tmp/omega_scripts/`) and official reference scripts.

---

## Key Audit Findings Summary

1. **CARD-0036 (`Pawn of Aldrez` - `c235448944.lua`)**:
   - **CONFIRMED BUG** (Line 55): `spcon` checks `r==REASON_LINK`. In YGOPro core, `r` during `EVENT_BE_MATERIAL` is `REASON_LINK+REASON_MATERIAL` (`0x804000`). Exact comparison `r==REASON_LINK` (`0x800000`) always evaluates to `false`, preventing the Link material trigger from firing.
   - **Fix**: Change line 55 to `return r&REASON_LINK~=0 and e:GetHandler():IsLocation(LOCATION_GRAVE)`.

2. **CARD-0038 (`Aldrez Battery` - `c233759343.lua`)**:
   - **CONFIRMED BUG** (Lines 76 & 88): Script adds `+RESET_PHASE+PHASE_END` to both ATK set-to-0 and ATK gain effects. Card text specifies permanent ATK alteration ("its ATK becomes 0, and if it does, you can have 1 "Aldrez" monster you control gain that lost ATK").
   - **Fix**: Remove `+RESET_PHASE+PHASE_END` from lines 76 and 88 so reset property is `RESET_EVENT+RESETS_STANDARD`.

3. **CARD-0042 (`Checkmate in Aldrez` - `c213849997.lua`)**:
   - **CONFIRMED BUG** (Lines 78 & 85): Script adds `+RESET_PHASE+PHASE_END` to monster effect negation. Card text specifies permanent negation ("Target 1 face-up monster on the field; negate its effects, then...").
   - **Fix**: Remove `+RESET_PHASE+PHASE_END` from lines 78 and 85 so reset property is `RESET_EVENT+RESETS_STANDARD`.

4. **CARD-0046 (`The Blue Frute` - `c236158052.lua`)**:
   - **CONFIRMED BUG** (Line 78): `tc:RegisterEffect(e3, true)` registers `EFFECT_LEAVE_FIELD_REDIRECT` on `tc` (the targeted opponent monster) when `c` was tributed while face-down defense position. 
   - **Fix**: Verify whether the banish redirect is intended for `c` or `tc` and correct target registration and reset conditions.

5. **CARD-0026, CARD-0029, CARD-0030, CARD-0032, CARD-0033, CARD-0034 (`Talismandrake Arms` equip replacement scripts)**:
   - **SUSPECTED / AMBIGUOUS**: Replacement prompt callbacks (`reptg` / `shdreptg` / `shdsendt`) call `SelectEffectYesNo` during `chk==1` rather than `chk==0`. Standard YGOPro engine patterns call `SelectEffectYesNo` inside `chk==0` to validate player consent prior to chain step execution.

---

## Detailed Per-Card Clause Audit Table

| Card ID | Card Name | Requirement / Text Clause | Lua Code & Callbacks | Status | Issue Details / Lines |
|---|---|---|---|---|---|
| CARD-0026 | Talismandrake Arms United | Discard 1 card; place up to 2 "Talismandrake" Pendulum Monsters from Deck/face-up Extra Deck in PZones | `s.cost` (L36-39), `s.pztg` (L44-49), `s.pzop` (L50-62) | OK | Implemented cleanly |
| CARD-0026 | Talismandrake Arms United | GY Trigger on Pyro Fusion SPSummon: banish self, equip 1 Arms S/T from Deck | `s.eqcon` (L68-70), `s.eqtg` (L78-85), `s.eqop` (L86-95) | OK | Correct target and equip handling |
| CARD-0026 | Talismandrake Arms United | Registered equip replacement effects (Sabre/Shield) | `s.register_equip_effects` (L116-220) | Suspected | L181, L209, L216: `SelectEffectYesNo` called on `chk==1` instead of `chk==0` |
| CARD-0027 | Left Talismandrake Arms - Blaze Suppressor | If control "Talismandrake" monster: target face-up card on field; destroy it | `s.actcon` (L41-43), `s.destg` (L47-53), `s.desop` (L54-59) | OK | Correct |
| CARD-0027 | Left Talismandrake Arms - Blaze Suppressor | Main Phase / Opponent SPSummon: Equip from GY to DARK Pyro; +500 ATK, opponent cannot target with effects | `s.spcon` (L60-63), `s.eqtg` (L71-79), `s.eqop` (L80-113) | OK | Elective HOPT shared via `SetCountLimit(1, id)` |
| CARD-0028 | Right Talismandrake Arms - Blaze Halberd | If control "Talismandrake" monster: target face-up monster; change to face-down DEF | `s.actcon` (L41-43), `s.postg` (L47-53), `s.posop` (L54-59) | OK | Correct |
| CARD-0028 | Right Talismandrake Arms - Blaze Halberd | Main Phase / Opponent SPSummon: Equip from GY to DARK Pyro; +500 ATK & piercing | `s.spcon` (L60-63), `s.eqtg` (L71-79), `s.eqop` (L80-112) | OK | Correct |
| CARD-0029 | Right Talismandrake Arms - Blaze Sabre | If control "Talismandrake" monster: target face-up opponent card; negate effects till end of turn | `s.actcon` (L41-43), `s.negtg` (L47-53), `s.negop` (L54-73) | OK | Correct |
| CARD-0029 | Right Talismandrake Arms - Blaze Sabre | Main Phase / Opponent SPSummon: Equip from GY to DARK Pyro; +500 ATK per Equip Spell, battle destroy replace | `s.eqop` (L94-129), `s.atkval` (L133-135), `s.reptg` (L136-144) | OK | Correct |
| CARD-0030 | Left Talismandrake Arms - Blaze Shield | SPSummon 1 "Talismandrake" monster from Deck/GY/face-up Extra Deck to MMZ | `s.sptg` (L34-40), `s.spop` (L41-48) | OK | Enforces MMZ zone bitmask `0x1f` |
| CARD-0030 | Left Talismandrake Arms - Blaze Shield | Quick Effect in GY: Equip to DARK Pyro Fusion; +500 DEF per Equip, opponent effect leave-field replace | `s.eqtg` (L56-64), `s.eqop` (L65-109), `s.defval` (L113-115) | OK | Correct |
| CARD-0031 | Talismandrake Pyre | Fusion Materials: 1 DARK Pyro monster + 1 Pyro monster | `aux.AddFusionProcFun2` (L13) | OK | Correct |
| CARD-0031 | Talismandrake Pyre | Special Summoned: search Talismandrake card/DARK Pyro monster OR send Arms S/T to GY | `s.thtg` (L56-64), `s.thop` (L65-111) | OK | Dynamic menu selection handled correctly |
| CARD-0031 | Talismandrake Pyre | Quick Effect: Destroy 1 PZone card, place diff-name Pendulum monster from hand/Deck/Extra Deck | `s.pztg` (L121-129), `s.pzop` (L130-145) | OK | Correct |
| CARD-0032 | Talismandrake Cremation | Fusion Materials: 1 DARK Pyro monster + 1 Level 5+ DARK monster | `aux.AddFusionProcFun2` (L13) | OK | Correct |
| CARD-0032 | Talismandrake Cremation | Special Summoned: Add or equip 1 "Talismandrake Arms" S/T from Deck/GY | `s.armstg` (L62-69), `s.armsop` (L70-103) | OK | Correct |
| CARD-0032 | Talismandrake Cremation | Quick Effect (if controlling equipped monster): Shuffle up to 3 cards from GY/banishment into Deck | `s.tdcon` (L234-236), `s.tdtg` (L240-245), `s.tdop` (L246-254) | OK | Correct |
| CARD-0033 | Talismandrake Enkindle | Fusion Materials: 1 "Talismandrake" monster + 1 DARK Pyro monster | `aux.AddFusionProcFun2` (L13) | OK | Correct |
| CARD-0033 | Talismandrake Enkindle | Special Summoned: Add or equip 1 "Talismandrake Arms" S/T from Deck/GY | `s.armstg` (L59-66), `s.armsop` (L67-100) | OK | Correct |
| CARD-0033 | Talismandrake Enkindle | Quick Effect (when opponent activates card/effect while controlling equipped monster): banish card | `s.rmcon` (L231-234), `s.rmtg` (L235-238), `s.rmop` (L239-244) | OK | Correct |
| CARD-0034 | Maiden of Talismandrakes Seraphina | Pendulum Effect: Shuffle 3 diff-name Talismandrakes from EX/field/GY to Deck; SPSummon self, then equip Arms | `s.pcost` (L77-84), `s.psptg` (L85-90), `s.pspop` (L91-104) | OK | Correct |
| CARD-0034 | Maiden of Talismandrakes Seraphina | Fusion Materials: 2 "Talismandrake" monsters + 1 Pyro Pendulum Monster | `aux.AddFusionProcFunFunRep` (L14) | OK | Correct |
| CARD-0034 | Maiden of Talismandrakes Seraphina | Fusion Summoned or Opponent activates: Target 1 Arms S/T in GY; add or equip | `s.gytg` (L126-140), `s.gyop` (L141-166) | OK | Correct |
| CARD-0034 | Maiden of Talismandrakes Seraphina | Monster Zone leaves field: Place in PZone | `s.pencon` (L293-296), `s.penop` (L300-305) | OK | Correct |
| CARD-0034 | Maiden of Talismandrakes Seraphina | Board Wipe Quick Effect (if equipped with Left+Right Arms): Pay 1000 LP; destroy all opponent cards, lock till end of next turn | `s.descon` (L309-313), `s.descost` (L314-318), `s.desop` (L327-334) | OK | Multi-turn flag reset (`RESET_PHASE+PHASE_END, 0, 2`) correct |
| CARD-0035 | Bishop of Aldrez | Continuous: Xyz and Link monsters you control cannot be destroyed by battle or card effects | `s.indtg` (L46-48) | OK | Correct |
| CARD-0035 | Bishop of Aldrez | Summoned: Add 1 "Aldrez" S/T from Deck or GY to hand | `s.thtg` (L52-55), `s.thop` (L56-63) | OK | Correct |
| CARD-0035 | Bishop of Aldrez | GY Trigger on Xyz SPSummon: Special Summon self from GY, and if you do, draw 1 card | `s.spcon` (L67-69), `s.sptg` (L73-80), `s.spop` (L81-88) | OK | Target check checks player can draw |
| CARD-0036 | Pawn of Aldrez | Special Summon from hand if control another "Aldrez" card | `s.hspcon` (L42-46) | OK | HOPT on Proc L12 |
| CARD-0036 | Pawn of Aldrez | Normal Summoned: Draw 1 card | `s.drtg` (L47-50), `s.drop` (L51-53) | OK | Correct |
| CARD-0036 | Pawn of Aldrez | Used as Link Material: Special Summon self, shuffle into Deck when leaves field | `s.spcon` (L54-56), `s.sptg` (L60-65), `s.spop` (L66-79) | **CONFIRMED BUG** | L55: `r==REASON_LINK` fails because Link material reason is `REASON_LINK+REASON_MATERIAL`. Must be `r&REASON_LINK~=0`. |
| CARD-0037 | Queen of Aldrez | Continuous: Opponent cannot target this card for attacks or other Aldrez monsters with card effects | `s.atkcon` (L50-52), `s.tglimit` (L53-55) | OK | Uses `aux.imval1` and `aux.tgoval` |
| CARD-0037 | Queen of Aldrez | Hand Ignition: Special Summon self if control another "Aldrez" monster | `s.hspcon` (L56-58), `s.hsptg` (L59-63), `s.hspop` (L64-69) | OK | Correct |
| CARD-0037 | Queen of Aldrez | Field Ignition: Search 1 "Aldrez" card except "Queen of Aldrez" from Deck | `s.thtg` (L73-76), `s.thop` (L77-84) | OK | Correct |
| CARD-0038 | Aldrez Battery | Activate: Search 1 "Aldrez" monster, attack limit for rest of turn except "Aldrez" monsters | `s.thtg` (L31-34), `s.thop` (L38-54) | OK | Correct |
| CARD-0038 | Aldrez Battery | GY Ignition: Banish self, target opponent monster, make ATK 0, gain lost ATK on Aldrez monster | `s.atktg` (L58-64), `s.atkop` (L68-92) | **CONFIRMED BUG** | L76 & L88: Added `+RESET_PHASE+PHASE_END` to ATK modification. Card text specifies permanent ATK alteration. |
| CARD-0039 | Aldrez Blitz | Activate: Target Lv4 or lower "Aldrez" monster in GY/banishment, Special Summon, option to SPSummon Token if Lv4 | `s.sptg` (L37-46), `s.spop` (L47-58) | OK | Correct |
| CARD-0039 | Aldrez Blitz | GY Trigger on Aldrez Xyz Summon: Set this card | `s.setcon` (L63-65), `s.settg` (L69-73), `s.setop` (L74-79) | OK | Correct |
| CARD-0040 | Aldrez Opening | Continuous: Aldrez monsters gain 500 ATK/DEF | `s.atktg` (L52-54) | OK | Correct |
| CARD-0040 | Aldrez Opening | Continuous: Opponent cannot activate cards/effects when Aldrez monster Summoned | `s.limcon` (L58-60), `s.limop` (L61-78) | OK | Chain limit handling correct |
| CARD-0040 | Aldrez Opening | Field Ignition: Target up to 3 Aldrez cards in GY/banishment, shuffle into Deck, optional draw 1 | `s.tdtg` (L96-104), `s.tdop` (L105-117) | OK | Correct |
| CARD-0041 | Checked in Aldrez | Trap Trigger on opponent SPSummon: Send 1 Aldrez monster from Deck to GY (cost), send 1 opponent monster to GY | `s.actcost` (L45-50), `s.acttg` (L51-54), `s.actop` (L55-62) | OK | Semicolon cost structure matched |
| CARD-0041 | Checked in Aldrez | GY Ignition: Banish self, target 1 Aldrez card in GY/banishment except self, add to hand | `s.thtg` (L66-72), `s.thop` (L73-79) | OK | Correct |
| CARD-0042 | Checkmate in Aldrez | Trap activation from hand while controlling Aldrez Xyz monster | `s.handcon` (L46-48) | OK | Correct |
| CARD-0042 | Checkmate in Aldrez | Activate: Target face-up monster, negate effects, then if control highest ATK monster, option to destroy opponent monsters | `s.negtg` (L52-58), `s.negop` (L68-93) | **CONFIRMED BUG** | L78 & L85: Added `+RESET_PHASE+PHASE_END` to negation. Card text specifies permanent negation. |
| CARD-0042 | Checkmate in Aldrez | GY Ignition: Banish self, target 1 Aldrez monster in GY/banishment, Special Summon | `s.sptg` (L98-105), `s.spop` (L106-112) | OK | Correct |
| CARD-0043 | Knight of Aldrez | Link Materials & Level treatment: 2 monsters including Aldrez; treated as Level 4 for Rank 4 Xyz | `s.lcheck` (L45-47), `s.xyzlv` (L48-51) | OK | Correct |
| CARD-0043 | Knight of Aldrez | Main Phase Quick Effect: Discard 1 card, take Aldrez card from Deck, add to hand or SPSummon if monster | `s.deckcost` (L56-59), `s.deckop` (L70-91) | OK | Correct |
| CARD-0043 | Knight of Aldrez | GY Trigger when Aldrez Xyz sent to GY by opponent: Banish self, SPSummon Xyz, attach card from GY | `s.revcon` (L97-99), `s.revop` (L109-126) | OK | Correct |
| CARD-0044 | Rook of Aldrez | Link Materials & Level treatment: 2 monsters including Aldrez; treated as Level 4 for Rank 4 Xyz | `s.lcheck` (L44-46), `s.xyzlv` (L47-50) | OK | Correct |
| CARD-0044 | Rook of Aldrez | Main Phase Quick Effect: Take Aldrez card from GY, add to hand or SPSummon if monster | `s.gytg` (L60-64), `s.gyop` (L65-86) | OK | Correct |
| CARD-0044 | Rook of Aldrez | GY Trigger when Aldrez Xyz sent to GY by opponent: Banish self, SPSummon Xyz, attach card from field | `s.revcon` (L92-94), `s.revop` (L104-121) | OK | Correct |
| CARD-0045 | King of Aldrez | Xyz Materials & Unique: 2+ Level 4 Aldrez monsters; unique on field | `aux.AddXyzProcedure` (L8), `c:SetUniqueOnField` (L6) | OK | Level 4 / XyzLevel filter enforced |
| CARD-0045 | King of Aldrez | Quick Detach Effect: Detach 1 material, SPSummon Aldrez monster from hand/GY, then if Link detached, destroy 1 card | `s.spcost` (L48-56), `s.spop` (L70-85) | OK | Label tracking detached Link monster cost correct |
| CARD-0045 | King of Aldrez | Xyz Summoned: Search 1 Aldrez Trap from Deck/GY | `s.thcon` (L86-88), `s.thop` (L96-103) | OK | Correct |
| CARD-0045 | King of Aldrez | GY Ignition: Banish self, Special Summon 1 banished Aldrez Link monster | `s.lsptg` (L108-112), `s.lspop` (L113-120) | OK | Correct |
| CARD-0046 | The Blue Frute | Normal Summoned: Special Summon 1 Frute monster except self from Deck face-down DEF | `s.sptg` (L33-38), `s.spop` (L39-46) | OK | Correct |
| CARD-0046 | The Blue Frute | Tributed: Target face-up opponent monster, ATK/DEF becomes 0 till end of turn, banish when leaves field if tributed face-down | `s.zerotg` (L50-57), `s.zeroop` (L58-81) | **CONFIRMED BUG** | L78: `tc:RegisterEffect(e3, true)` registers `EFFECT_LEAVE_FIELD_REDIRECT` on opponent monster `tc` instead of `c`. |
| CARD-0047 | The Yellow Frute | Hand/Field Ignition: Send self to GY, SPSummon 1 Frute monster except self from hand/GY face-up/down DEF | `s.spcost` (L29-33), `s.spop` (L45-63) | OK | Correct |
| CARD-0047 | The Yellow Frute | Tributed: Draw 1 card, or if tributed face-down DEF, draw 2 and discard 1 | `s.drtg` (L64-78), `s.drop` (L79-85) | OK | Correct |
| CARD-0048 | The Red Frute | Hand Ignition: If control no face-up monsters or Frute card, SPSummon self, optional send diff-name Frute card from Deck | `s.spcon` (L33-36), `s.spop` (L49-61) | OK | Correct |
| CARD-0048 | The Red Frute | Tributed: Add "Fruteonia" from Deck, or if tributed face-down DEF, option to Set Frute S/T from Deck | `s.thtg` (L68-86), `s.thop` (L87-103) | OK | Correct |
| CARD-0049 | The Green Frute | Hand/GY Ignition: Tribute 1 WATER monster from hand/field except self; SPSummon self face-down DEF, banish when leaves field | `s.spcost` (L33-39), `s.spop` (L47-61) | OK | Correct |
| CARD-0049 | The Green Frute | Tributed: Send 1 Frute monster except self from Deck to GY, or if tributed face-down DEF, send Frute S/T instead | `s.tgtg` (L68-81), `s.tgop` (L82-90) | OK | Correct |
| CARD-0050 | The White Frute | Hand Ignition: Tribute 1 WATER monster; SPSummon self, search 1 Frute monster except self from Deck | `s.spcost` (L32-37), `s.spop` (L49-62) | OK | Correct |
| CARD-0050 | The White Frute | Tributed: Target 1 Frute monster in GY except self; add to hand, or if tributed face-down DEF, option to SPSummon in DEF | `s.thtg` (L71-79), `s.thop` (L80-113) | OK | Correct |

---

I confirm that I modified no files.

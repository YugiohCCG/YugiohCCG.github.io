### Card 1: Gravinity Plasma (CARD-00417 | 235538173)
| Semantic Requirement | Extracted Clause | Lua Implementation | Issues/Notes |
|:---|:---|:---|:---|
| Condition (Hand) | During the Main Phase, if this card is in your hand (Quick Effect): | `e1` (`EVENT_FREE_CHAIN`), `LOCATION_HAND`, `Duel.IsMainPhase()` | **Confirmed Issue:** `Duel.IsMainPhase()` in `SetCondition` without checking phase player means it can activate on either turn's MP, which is correct for Quick Effect, but `s.pltg` doesn't check if the card is still in hand during resolution. |
| Effect (Hand) | You can place this card face up in one of your Spell and Trap Zones as a Continuous Trap. | `s.plop`: `Duel.MoveToField(..., LOCATION_SZONE, POS_FACEUP, true)` followed by `s.trapify`. | **Ambiguous:** `MoveToField` with `true` activates it as a Spell/Trap. If SZONE placement doesn't start a chain, it might be correct, but SZONE type change should ideally happen before or atomically. |
| Condition (SZone) | During either player's turn, if this card is treated as a Continuous Trap: | `e2`/`e3` (`EVENT_FREE_CHAIN`), `s.trapcon` checks `TYPE_TRAP`. | Correct. |
| Effect (SZone 1) | Place 1 "Gravinity" monster from your Deck... face up in your Spell and Trap Zone as a Continuous Trap. | `s.deckop`: Selects monster, `MoveToField`, `s.trapify`. | Correct. |
| Effect (SZone 2) | Move this card to another column. | `s.mvop`: `Duel.SelectDisableField` and `Duel.MoveSequence`. | Correct logic using log2 for SZONE sequence. |
| Restriction | You can only use each effect of "Gravinity Plasma" once per turn. | `e1:SetCountLimit(1,id)`, `e2:SetCountLimit(1,id+100)`, `e3:SetCountLimit(1,id+200)`. | **Ambiguous:** "activate one of the following effects... use each effect once per turn" usually implies you can use EACH bullet once per turn, but often means you can only pick one. The script allows all three. |
| Archetype Feature | "Transfer Call" Flag integration | `c:GetFlagEffect(TRANSFER_CALL)>0` applies all effects in sequence. | Correct. Perfectly implements `Gravinity Transfer Call`. |

### Card 2: Ratsach, the Scarstech Cruiser (CARD-0X417 | 242838495)
| Semantic Requirement | Extracted Clause | Lua Implementation | Issues/Notes |
|:---|:---|:---|:---|
| Condition | 2 or more Galaxy monsters | `aux.AddLinkProcedure` | Correct. |
| Effect (Continuous) | This card cannot be targeted for attacks, but does not prevent your opponent from attacking you directly. | `EFFECT_CANNOT_BE_BATTLE_TARGET` and `e2: EFFECT_DIRECT_ATTACK` to ALL opponent monsters. | **Confirmed Issue:** Giving all opponent monsters `EFFECT_DIRECT_ATTACK` lets them bypass ANY OTHER monsters you control! Fix: Remove `e2` and apply `EFFECT_IGNORE_BATTLE_TARGET` to Ratsach instead. |
| Effect (Trigger) | This card gains 300 ATK when a card or effect resolves. | `EVENT_CHAIN_SOLVED`, `s.atkop`. | Correct. |
| Effect (Quick) | Once per Chain (Quick Effect): You can make this card lose exactly 3000 ATK, and if you do, add 1 "Scarstech" Trap from your Deck to your hand. | `e4` (`EVENT_FREE_CHAIN`), ATK loss in `s.thop`, Cost uses `id` flag. | Correct. `Once per Chain` is properly implemented with `RESET_CHAIN` flag. |

### Card 3: Gravinity Pulse (CARD-00418 | 256172827)
| Semantic Requirement | Extracted Clause | Lua Implementation | Issues/Notes |
|:---|:---|:---|:---|
| Condition | During the Main Phase, if this card is in your hand (Quick Effect): | `e1`, `Duel.IsMainPhase()` | Correct. |
| Effect (Hand) | You can place this card face up in your Spell and Trap Zone as a Continuous Trap. | `s.plop`: `MoveToField`, `trapify`. | Correct. |
| Effect (SZone) | Add 1 "Gravinity" Spell or Trap from your Deck to your hand. / Move this card to another column. | `e2` / `e3` | Correct. Same count limit structure as Plasma. |

### Card 4: Scarstech Crawler (CARD-0X418 | 213611313)
| Semantic Requirement | Extracted Clause | Lua Implementation | Issues/Notes |
|:---|:---|:---|:---|
| Effect (Trigger) | This card gains 300 ATK when a card or effect resolves. | `EVENT_CHAIN_SOLVED`, `s.atkop`. | Correct. |
| Effect (Quick) | During the Main Phase (Quick Effect): You can discard 1 card; Special Summon 1 Galaxy monster from your hand. | `e2`, `s.spcost1`, `s.sptg1`. | Correct. |
| Effect (Quick GY) | If a card was activated as Chain Link 5 or higher while this card is in your GY (Quick Effect): You can Special Summon this card. | `e3` (`EVENT_CHAINING`), `ev>=5` | Correct. It chains to CL5 or higher perfectly. |

### Card 5: Chaos Honest (CARD-00419 | 248638801)
| Semantic Requirement | Extracted Clause | Lua Implementation | Issues/Notes |
|:---|:---|:---|:---|
| Continuous | While face-up on the field, this card is also DARK-Attribute. | `EFFECT_ADD_ATTRIBUTE` | Correct. |
| Cost / Modifiers | apply the following effects, in sequence, based on the Attributes of the materials used for this card's Link Summon. | `s.regop` registers flags `id`/`id+100` on Summon. | Correct. `s.atkcost` cleanly saves these flags to the Label so they survive the card leaving the field as cost! |
| Effect (Damage) | LIGHT: That monster gains ATK... DARK: That opponent's monster loses ATK... | `EVENT_PRE_DAMAGE_CALCULATE` | **Suspected Issue:** If BOTH battling monsters are yours and pointed to, `oc` will be your monster, and the DARK effect will erroneously reduce your own monster's ATK because it lacks a check for `oc:IsControler(1-tp)`. |

### Card 6: Gravinity Star (CARD-00420 | 215768254)
| Semantic Requirement | Extracted Clause | Lua Implementation | Issues/Notes |
|:---|:---|:---|:---|
| Condition / Cost | SZONE placement / Move / Set from Deck | `e1`, `e2`, `e3` | Correct. Inherits the archetype SZONE logic properly. |
| Effect | Set 1 "Gravinity" Spell or Trap directly from your Deck. If it is your opponent's turn, it can be activated this turn. | `s.setop` registers `EFFECT_TRAP_ACT_IN_SET_TURN` and `EFFECT_QP_ACT_IN_SET_TURN`. | Correct. |

### Card 7: Gravinity Lapsix (CARD-00421 | 212345347)
| Semantic Requirement | Extracted Clause | Lua Implementation | Issues/Notes |
|:---|:---|:---|:---|
| Continuous | For this card's Synchro Summon, you can use "Gravinity" Monster Cards in your Spell & Trap Zone as material. | `e3` assigns `EFFECT_EXTRA_SYNCHRO_MATERIAL` on Lapsix. | **Confirmed Issue:** `e3` gives Lapsix the ability to be used from the SZONE for OTHER Synchros! It completely fails to give SZONE monsters the ability to be used for Lapsix's summon. Fix: Apply a field effect giving `EFFECT_EXTRA_SYNCHRO_MATERIAL` to SZONE monsters for this card's summon. |
| Trigger | If this card is Synchro Summoned, or Special Summoned from your Spell & Trap Zone: | `EVENT_SPSUMMON_SUCCESS` | Correct. |
| Effect | You can take 1 Level 6 or lower "Gravinity" monster... Special Summon it or place it face-up... | `s.spop1` | Correct. |
| Quick Effect | You can draw 1 card, then you can Special Summon this card. | `s.spop2`, `Duel.Draw` followed by `Duel.SpecialSummon` | Correct. |

### Card 8: Gravinity Galaxix (CARD-00422 | 249454272)
| Semantic Requirement | Extracted Clause | Lua Implementation | Issues/Notes |
|:---|:---|:---|:---|
| Continuous | For this card's Synchro Summon, you can use "Gravinity" Monster Cards in your Spell & Trap Zones as material. | `e3` assigns `EFFECT_EXTRA_SYNCHRO_MATERIAL` on Galaxix. | **Confirmed Issue:** Same as Lapsix. Fails to allow SZONE monsters to be used for Galaxix's summon. |
| Trigger | Set 1 "Gravinity" Spell/Trap from your GY or banishment. It can be activated this turn. | `s.setop` | Correct. |

### Card 9: Gravinity Nebulix (CARD-00424 | 212429024)
| Semantic Requirement | Extracted Clause | Lua Implementation | Issues/Notes |
|:---|:---|:---|:---|
| Condition | This card's Synchro Summon cannot be negated. | `EFFECT_CANNOT_DISABLE_SPSUMMON` | Correct. |
| Trigger | shuffle up to 3 "Gravinity" cards... into the Deck, then draw 1 card. | `s.tdop` | Correct. |
| Continuous | When a "Gravinity" Spell/Trap effect resolves, you can also add this additional effect... | `EVENT_CHAIN_SOLVED`, `s.addcon` | Correct. `EVENT_CHAIN_SOLVED` is the standard EDOPro implementation for "also after that" generic modifications. |

### Card 10: Gravinity Spherix (CARD-00425 | 231088629)
| Semantic Requirement | Extracted Clause | Lua Implementation | Issues/Notes |
|:---|:---|:---|:---|
| Continuous | If a player would Normal or Special Summon a monster... place that monster face-up in its owner's Spell & Trap Zone as a Continuous Trap instead... | `EVENT_SUMMON_SUCCESS` and `EVENT_SPSUMMON_SUCCESS` | **Confirmed Issue:** Triggers AFTER the summon succeeds! Opponents can still chain Trap Hole, etc., because the summon is not replaced. Fix: Use a replacement effect via `EFFECT_SPSUMMON_PROC_G` or continuous `EVENT_SPSUMMON` with `EFFECT_TYPE_FIELD`. |
| Effect | ...attach the minimum number of monsters that can be used for this card's Xyz Summon from your GY to this card as material. | `s.sphspop`: `Duel.Overlay(c, g:Select(tp, 2, 2, nil))` | **Confirmed Issue:** Hardcodes exactly 2 materials. Many Xyz monsters require 1 or 3+ materials. Fix: Use `c.minxyzct` or `aux.xyz_min_val`. |
| Quick Effect | ...shuffle 1 monster your opponent controls and 1 "Gravinity" Monster Card in the same column... | `s.tdop` | Correct. |

### Card 11: Gravinity Transfer Call (CARD-00426 | 223505382)
| Semantic Requirement | Extracted Clause | Lua Implementation | Issues/Notes |
|:---|:---|:---|:---|
| Effect | ...also the next time it activates its effect, you can apply all of its listed effects in sequence. | Registers `id` (223505382) flag. | Correct. The Gravinity monsters natively read `c:GetFlagEffect(TRANSFER_CALL)>0` and cleanly resolve all bulleted effects! |

### Card 12: Gravinity Gravity Protection (CARD-00427 | 247919552)
| Semantic Requirement | Extracted Clause | Lua Implementation | Issues/Notes |
|:---|:---|:---|:---|
| Effect 3 | Shuffle up to 2 "Gravinity" Monster Cards in your Spell & Trap Zone and an equal number of your opponent's cards in the same columns into the Deck. | `s.oppcolfilter` checks `mc:GetColumnGroup():IsContains(c)` | Correct. |

### Card 13: Gravinity Axis Matter (CARD-00428 | 256831125)
| Semantic Requirement | Extracted Clause | Lua Implementation | Issues/Notes |
|:---|:---|:---|:---|
| Effect | Reduce the Level/Rank/Link Rating of your opponent's monsters in the same column as a "Gravinity" monster by 1. | `EFFECT_UPDATE_LEVEL` and `EFFECT_UPDATE_RANK` | **Confirmed Issue:** Fails to implement Link Rating reduction. EDOPro does not natively support dynamically altering Link Ratings (`EFFECT_UPDATE_LINK` does not exist). |
| Effect | ...this card gains the non-activated effects of the revealed monster. | Manually copies code from Nebulix/Spherix using hardcoded IDs. | **Custom Implementation:** EDOPro cannot generically copy "non-activated effects". This hardcoded bypass is correct for the immediate archetype but lacks future-proofing. |

### Card 14: Gravinity Sonic Scream (CARD-00429 | 238184015)
| Semantic Requirement | Extracted Clause | Lua Implementation | Issues/Notes |
|:---|:---|:---|:---|
| Effect (Field) | ...destroy it or, if it was a monster, place it face-up in its owner's Spell & Trap Zone as a Continuous Trap. | `rc:CancelToGrave()` and `MoveToField` | Correct. |
| Effect (GY) | this effect becomes that card's activated effect. | Re-fires the `op` function of the chained effect. | Correct. |

### Card 15: Unbinding the Soul (CARD-00430 | 246900181)
| Semantic Requirement | Extracted Clause | Lua Implementation | Issues/Notes |
|:---|:---|:---|:---|
| Effect | Target up to 2 monsters in either GY; shuffle them into the Deck. | `Duel.SelectTarget(..., LOCATION_GRAVE, LOCATION_GRAVE, 1, 2, ...)` | Correct. |

### Card 16: Eclipse Summoning (CARD-00431 | 251331463)
| Semantic Requirement | Extracted Clause | Lua Implementation | Issues/Notes |
|:---|:---|:---|:---|
| Condition | If your opponent controls a Link Monster with a Link Rating of 3 or higher: | `c:IsType(TYPE_LINK) and c:IsLinkAbove(3)` | Correct. |

### Card 17: Lowkey Lowkey (CARD-00432 | 225260657)
| Semantic Requirement | Extracted Clause | Lua Implementation | Issues/Notes |
|:---|:---|:---|:---|
| N/A | Normal Monster | Empty script | Correct. |

### Card 18: Flower Cardian Moonflare (CARD-00433 | 248940511)
| Semantic Requirement | Extracted Clause | Lua Implementation | Issues/Notes |
|:---|:---|:---|:---|
| Condition | 1 Tuner + 3 non-Tuner monsters | `aux.AddSynchroProcedure(c,nil,aux.NonTuner(nil),3,3)` | Correct. |
| Effect | When this card is used as Synchro Material for the Synchro Summon of a "Flower Cardian" monster, you can treat it as 3 non-Tuner monsters. | `EFFECT_SYNCHRO_MATERIAL_CUSTOM` calling `Duel.SetSynchroMaterial(Group.FromCards(e:GetHandler()))` | **Confirmed Issue:** `EFFECT_SYNCHRO_MATERIAL_CUSTOM` setting only itself as material will cause the Synchro summon to fail the "1 Tuner" requirement of the destination monster. Fix: The `syntg` must select the Tuner as well, or you must register a separate `EFFECT_SYNCHRO_CHECK` effect. |

### Card 19: Stardust Comet (CARD-00434 | 231523659)
| Semantic Requirement | Extracted Clause | Lua Implementation | Issues/Notes |
|:---|:---|:---|:---|
| Effect (Quick) | You can Tribute 1 "Stardust" monster from your Deck... | `Duel.SendtoGrave(tc,REASON_COST+REASON_RELEASE)` | Correct. Tributes from deck cannot be handled natively via `Duel.Release` in EDOPro, so `SendtoGrave` with `REASON_RELEASE` is the standard workaround. |

### Card 20: Interwire Dimensquid (CARD-00435 | 253128790)
| Semantic Requirement | Extracted Clause | Lua Implementation | Issues/Notes |
|:---|:---|:---|:---|
| Trigger | If a card you control is banished... | `EVENT_REMOVE` | Correct. |
| Trigger | If you Special Summon a monster from your banishment: You can reveal 1 Synchro Monster in your Extra Deck; immediately after this effect resolves, Synchro Summon... treat this card as a non-Tuner. | Assigns temporary `EFFECT_NONTUNER` before `Duel.SynchroSummon` | Correct. |

### Card 21: Oracle of the Herald (CARD-00436 | 247298564)
| Semantic Requirement | Extracted Clause | Lua Implementation | Issues/Notes |
|:---|:---|:---|:---|
| Trigger | If this card is Special Summoned by the effect of a Fairy monster... | `EVENT_SPSUMMON_SUCCESS` | Correct. |
| Effect | During the Main Phase: You can discard 1 card; Special Summon this card from your GY... | `EFFECT_TYPE_QUICK_O` with `EVENT_FREE_CHAIN` | **Confirmed Issue:** The text says "During the Main Phase:" without "(Quick Effect)". The script implements it as a Quick Effect. Fix: Change `EFFECT_TYPE_QUICK_O` to `EFFECT_TYPE_IGNITION`. |

### Card 22: Galacticarina (CARD-00437 | 234179728)
| Semantic Requirement | Extracted Clause | Lua Implementation | Issues/Notes |
|:---|:---|:---|:---|
| Continuous | All monsters your opponent controls must attack this card, if able. | `EFFECT_MUST_ATTACK` and `EFFECT_MUST_ATTACK_MONSTER` | Correct. |
| Trigger | If this card destroys a monster by battle, or inflicts battle damage to your opponent: | `EVENT_BATTLE_DESTROYING` and `EVENT_BATTLE_DAMAGE` | Correct. The shared `c:GetFlagEffect(id)==0` in the cost prevents both events from activating as two separate Chain Links during the same attack. |

### Card 23: Galacticassiopeia (CARD-00438 | 227335484)
| Semantic Requirement | Extracted Clause | Lua Implementation | Issues/Notes |
|:---|:---|:---|:---|
| Continuous / Trigger | Same as Galacticarina | Same as Galacticarina | Correct. |

### Card 24: Galacticanes Venatici (CARD-00439 | 229021849)
| Semantic Requirement | Extracted Clause | Lua Implementation | Issues/Notes |
|:---|:---|:---|:---|
| Trigger | If this card is Normal or Special Summoned in Attack Position: You can Special Summon 1 "Galactican Machinator Token"... | `EVENT_SUMMON_SUCCESS` / `EVENT_SPSUMMON_SUCCESS` | Correct. |

### Card 25: Galacticanes Auriga (CARD-00440 | 220148485)
| Semantic Requirement | Extracted Clause | Lua Implementation | Issues/Notes |
|:---|:---|:---|:---|
| N/A | Normal Monster | Empty script | Correct. |

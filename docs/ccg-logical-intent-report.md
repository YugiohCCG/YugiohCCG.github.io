# CCG Logical Intent Verification Report

This report uses heuristic mapping to verify that the Lua implementation mathematically fulfills the actions stated in the English card text. If a card says 'destroy', it expects to see 'Duel.Destroy', etc.

- **Total Cards Checked**: 577
- **Cards Passed Logic Test**: 515
- **Cards Flagged (Discrepancies)**: 62
---

## Stardrake of Gravitic Coils (c245265629.lua)
- **MISSING INTENT**: Text mentions `target` but missing expected Lua pattern (e.g. `EFFECT_FLAG_CARD_TARGET`)
- **MISSING INTENT**: Text mentions `damage` but missing expected Lua pattern (e.g. `Duel.Damage`)

## Stargazer of the Stained (c218685316.lua)
- **MISSING INTENT**: Text mentions `banish` but missing expected Lua pattern (e.g. `Duel.Remove`)
- **MISSING INTENT**: Text mentions `draw` but missing expected Lua pattern (e.g. `Duel.Draw`)

## Stained Silhouette (c256608976.lua)
- **MISSING INTENT**: Text mentions `draw` but missing expected Lua pattern (e.g. `Duel.Draw`)

## Talismandrake Arms United (c215034223.lua)
- **MISSING INTENT**: Text mentions `banish` but missing expected Lua pattern (e.g. `Duel.Remove`)
- **MISSING INTENT**: Text mentions `damage` but missing expected Lua pattern (e.g. `Duel.Damage`)

## Left Talismandrake Arms - Blaze Suppressor (c238136421.lua)
- **MISSING INTENT**: Text mentions `damage` but missing expected Lua pattern (e.g. `Duel.Damage`)

## Right Talismandrake Arms - Blaze Halberd (c215921734.lua)
- **MISSING INTENT**: Text mentions `damage` but missing expected Lua pattern (e.g. `Duel.Damage`)

## Right Talismandrake Arms - Blaze Sabre (c248788543.lua)
- **MISSING INTENT**: Text mentions `damage` but missing expected Lua pattern (e.g. `Duel.Damage`)

## Aldrez Battery (c233759343.lua)
- **MISSING INTENT**: Text mentions `banish` but missing expected Lua pattern (e.g. `Duel.Remove`)

## Aldrez Opening (c210923192.lua)
- **MISSING INTENT**: Text mentions `special summon` but missing expected Lua pattern (e.g. `Duel.SpecialSummon`)

## Knight of Aldrez (c238282350.lua)
- **MISSING INTENT**: Text mentions `banish` but missing expected Lua pattern (e.g. `Duel.Remove`)

## Rook of Aldrez (c231129918.lua)
- **MISSING INTENT**: Text mentions `banish` but missing expected Lua pattern (e.g. `Duel.Remove`)

## The Fruted Warrior (c213615627.lua)
- **MISSING INTENT**: Text mentions `damage` but missing expected Lua pattern (e.g. `Duel.Damage`)

## Ursarctic Leoship (c247831166.lua)
- **MISSING INTENT**: Text mentions `banish` but missing expected Lua pattern (e.g. `Duel.Remove`)

## Branching to Guidance (c222257685.lua)
- **MISSING INTENT**: Text mentions `banish` but missing expected Lua pattern (e.g. `Duel.Remove`)

## Rigel the Thousand-Armed (c215853847.lua)
- **MISSING INTENT**: Text mentions `damage` but missing expected Lua pattern (e.g. `Duel.Damage`)

## Sustained Succubus Saria (c219419648.lua)
- **MISSING INTENT**: Text mentions `damage` but missing expected Lua pattern (e.g. `Duel.Damage`)

## Kanmuriyama (c248801935.lua)
- **MISSING INTENT**: Text mentions `damage` but missing expected Lua pattern (e.g. `Duel.Damage`)

## Takama No Hara (c229996802.lua)
- **MISSING INTENT**: Text mentions `banish` but missing expected Lua pattern (e.g. `Duel.Remove`)

## Oracle of the Grand Blue (c259578863.lua)
- **MISSING INTENT**: Text mentions `banish` but missing expected Lua pattern (e.g. `Duel.Remove`)

## Sacred Feather of Nephthys (c216532402.lua)
- **MISSING INTENT**: Text mentions `banish` but missing expected Lua pattern (e.g. `Duel.Remove`)

## To Proto Taxis (c246380598.lua)
- **MISSING INTENT**: Text mentions `damage` but missing expected Lua pattern (e.g. `Duel.Damage`)

## To Proto Psychi (c217332244.lua)
- **MISSING INTENT**: Text mentions `damage` but missing expected Lua pattern (e.g. `Duel.Damage`)

## Ektelestis gia Taxis (c212684822.lua)
- **MISSING INTENT**: Text mentions `damage` but missing expected Lua pattern (e.g. `Duel.Damage`)

## Ghost Doll & Midnight Manor (c222782750.lua)
- **MISSING INTENT**: Text mentions `special summon` but missing expected Lua pattern (e.g. `Duel.SpecialSummon`)

## Aldrez Grandmaster (c246496923.lua)
- **MISSING INTENT**: Text mentions `damage` but missing expected Lua pattern (e.g. `Duel.Damage`)

## Phantasm Spiral Shrine (c237917359.lua)
- **MISSING INTENT**: Text mentions `banish` but missing expected Lua pattern (e.g. `Duel.Remove`)

## Guardian of Wicked Puppeteer (c257464336.lua)
- **MISSING INTENT**: Text mentions `banish` but missing expected Lua pattern (e.g. `Duel.Remove`)

## Wicked Puppeteer Tragedy (c243306841.lua)
- **MISSING INTENT**: Text mentions `banish` but missing expected Lua pattern (e.g. `Duel.Remove`)

## Teleum Mortis (c229875953.lua)
- **MISSING INTENT**: Text mentions `destroy` but missing expected Lua pattern (e.g. `Duel.Destroy`)

## Bear Trap (c251699681.lua)
- **MISSING INTENT**: Text mentions `negate` but missing expected Lua pattern (e.g. `Duel.NegateEffect`)

## Nautical Backwashing & Oceanic Waves (c223158720.lua)
- **MISSING INTENT**: Text mentions `banish` but missing expected Lua pattern (e.g. `Duel.Remove`)

## Bob, but Stronger! (c259944943.lua)
- **MISSING INTENT**: Text mentions `damage` but missing expected Lua pattern (e.g. `Duel.Damage`)

## Bookkeeper of Crying Chaos (c221047295.lua)
- **MISSING INTENT**: Text mentions `banish` but missing expected Lua pattern (e.g. `Duel.Remove`)

## A Whisper of Crying Chaos (c253472430.lua)
- **MISSING INTENT**: Text mentions `banish` but missing expected Lua pattern (e.g. `Duel.Remove`)

## Windborne Eye of the Storm (c256110263.lua)
- **MISSING INTENT**: Text mentions `add.*?to (your |their )?hand` but missing expected Lua pattern (e.g. `Duel.SendtoHand`)

## Windborne Galesong Flock (c238064522.lua)
- **MISSING INTENT**: Text mentions `add.*?to (your |their )?hand` but missing expected Lua pattern (e.g. `Duel.SendtoHand`)

## Iscylla, Windborne Kraken of Sunken Depths (c255686110.lua)
- **MISSING INTENT**: Text mentions `add.*?to (your |their )?hand` but missing expected Lua pattern (e.g. `Duel.SendtoHand`)

## Shining Brigade - Melody Division (c243420199.lua)
- **MISSING INTENT**: Text mentions `banish` but missing expected Lua pattern (e.g. `Duel.Remove`)

## Let's Go, Shining Brigade! (c238841732.lua)
- **MISSING INTENT**: Text mentions `banish` but missing expected Lua pattern (e.g. `Duel.Remove`)

## Chrono-Saur Tricera (c259235389.lua)
- **MISSING INTENT**: Text mentions `damage` but missing expected Lua pattern (e.g. `Duel.Damage`)

## Chrono-Saur Laplace Plesio (c251236672.lua)
- **MISSING INTENT**: Text mentions `damage` but missing expected Lua pattern (e.g. `Duel.Damage`)

## Aquamarine Plate Montipora (c220150285.lua)
- **MISSING INTENT**: Text mentions `banish` but missing expected Lua pattern (e.g. `Duel.Remove`)

## Aquamarine Nautilus (c241976572.lua)
- **MISSING INTENT**: Text mentions `banish` but missing expected Lua pattern (e.g. `Duel.Remove`)

## Hiding "C" (c258260221.lua)
- **MISSING INTENT**: Text mentions `banish` but missing expected Lua pattern (e.g. `Duel.Remove`)

## Yummy Kuriboh (c253152295.lua)
- **MISSING INTENT**: Text mentions `negate` but missing expected Lua pattern (e.g. `Duel.NegateEffect`)

## Curryboh (c220538776.lua)
- **MISSING INTENT**: Text mentions `damage` but missing expected Lua pattern (e.g. `Duel.Damage`)

## Arckcestial Meadow (c258590942.lua)
- **MISSING INTENT**: Text mentions `damage` but missing expected Lua pattern (e.g. `Duel.Damage`)

## Rank-Up-Magic Key of Arck Celestial Force (c228635967.lua)
- **MISSING INTENT**: Text mentions `damage` but missing expected Lua pattern (e.g. `Duel.Damage`)

## Hallo-Ween! Basket of Treats (c224800873.lua)
- **MISSING INTENT**: Text mentions `banish` but missing expected Lua pattern (e.g. `Duel.Remove`)

## Chaos Honest (c248638801.lua)
- **MISSING INTENT**: Text mentions `damage` but missing expected Lua pattern (e.g. `Duel.Damage`)

## Gravinity Sonic Scream (c238184015.lua)
- **MISSING INTENT**: Text mentions `banish` but missing expected Lua pattern (e.g. `Duel.Remove`)

## Galacticarina (c234179728.lua)
- **MISSING INTENT**: Text mentions `damage` but missing expected Lua pattern (e.g. `Duel.Damage`)

## Galacticassiopeia (c227335484.lua)
- **MISSING INTENT**: Text mentions `damage` but missing expected Lua pattern (e.g. `Duel.Damage`)

## Galacticanes Venatici (c229021849.lua)
- **MISSING INTENT**: Text mentions `damage` but missing expected Lua pattern (e.g. `Duel.Damage`)

## Galactican Battle Station (c258934904.lua)
- **MISSING INTENT**: Text mentions `damage` but missing expected Lua pattern (e.g. `Duel.Damage`)

## Galactican Battle Grounds (c250829750.lua)
- **MISSING INTENT**: Text mentions `damage` but missing expected Lua pattern (e.g. `Duel.Damage`)

## Galactican Machine - No. G2-X38 (c253520299.lua)
- **MISSING INTENT**: Text mentions `damage` but missing expected Lua pattern (e.g. `Duel.Damage`)

## Intergalactican Machine - No. R2-D30 (c236473882.lua)
- **MISSING INTENT**: Text mentions `damage` but missing expected Lua pattern (e.g. `Duel.Damage`)

## Intergalacticanes Majoris (c219002796.lua)
- **MISSING INTENT**: Text mentions `damage` but missing expected Lua pattern (e.g. `Duel.Damage`)

## To Protogenis Intergalataxiakos (c221827483.lua)
- **MISSING INTENT**: Text mentions `damage` but missing expected Lua pattern (e.g. `Duel.Damage`)

## Harpie Lady Sisters - Phoenix Formation (c259269774.lua)
- **MISSING INTENT**: Text mentions `damage` but missing expected Lua pattern (e.g. `Duel.Damage`)

## Wyvernal Gathering (c259073666.lua)
- **MISSING INTENT**: Text mentions `banish` but missing expected Lua pattern (e.g. `Duel.Remove`)

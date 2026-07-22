# Manual Omega review guide - 123 cards

Date: 2026-07-20

This guide expands every `Needs manual ruling` result from the ultimate 577-card audit. These are not known syntax or initializer failures: all listed scripts compile, load, have synchronized DB rows/messages, and match the reviewed implementation. They remain open because static analysis cannot prove an unusual Omega UI/procedure, an ambiguous source ruling, a card-pool definition, or a live chain/timing interaction.

## How to use this guide

For each card, resolve the **problem/question**, execute the listed duel checks, and record the ruling and observed engine result. A card can move to `Pass` only when the acceptance condition is met. If the intended ruling differs from the current implementation, update the card text or Lua first, then repeat the full syntax/smoke/artifact checks from the ultimate audit report.

Common test discipline: use distinguishable cards; test legal and illegal activation states; test a full-zone state; remove or immunize targets before resolution; apply Necrovalley for GY access; test face-down banished cards; verify count limits after negation; and confirm every `and if you do`/`then` continuation against success and failure.

## Workstream summary

| Workstream | Cards |
|---|---:|
| Card-pool and dependency definitions | 17 |
| Copied, rewritten, and resolving effects | 10 |
| Co-link, counter, and zone topology | 9 |
| Source wording and authoritative rulings | 9 |
| Damage and stat-layer behavior | 3 |
| Ownership and opponent-resource use | 7 |
| Timing, delayed state, and reset behavior | 12 |
| Summon, material, and selection UI | 48 |
| Other custom engine behavior | 8 |
| **Total** | **123** |

Primary audit evidence: [`lua-audit-2026-07-20-ultimate-fourth-pass.md`](lua-audit-2026-07-20-ultimate-fourth-pass.md). The source `src/data/ccg-omega-ids.json` remains absent, so each Omega ID below is the verified `cards.json` passcode/ID-map value.

## Card-pool and dependency definitions

### 1. Stained Avatar - 244790302

- **Source ordinal:** 15. **Script:** [`c244790302.lua`](<../public/CCG Downloads/CCG_Scripts/c244790302.lua>)
- **Problem/question to solve:** card-pool-sensitive copy.
- **Current audited implementation:** destruction replacement; Fusion trigger; copied activation [implemented]. The file compiles and initializes; the open item is behavioral or interpretive, not a known load failure.
- **Manual review checklist:**
  1. Enumerate the exact currently legal card IDs and confirm that every intended card is included and every unintended card is excluded.
  2. Decide whether the rule should be name-, set-code-, listed-text-, or explicit-ID-based, including how future cards enter the pool.
  3. Test one valid card, one near-name false positive, and a newly added/future placeholder so the implementation does not silently become stale.
  4. Run the relevant GY branch both with and without Necrovalley, including activation legality and a Necrovalley effect appearing before resolution.
  5. Include face-up and face-down banished cards and confirm hidden cards are never selected unless the text explicitly permits them.
- **Acceptance condition:** Record the authoritative interpretation and an Omega replay/log showing the positive case, the closest illegal case, and any listed interruption case. The observed result must match the exact source sequence and leave no broader/narrower legal pool than intended.

<details>
<summary>Exact current source text</summary>

2 "Stain" monsters with different Attributes\nIf a card(s) you control would be destroyed by battle or card effect, you can banish 1 face-up "Stain" monster in your opponent's Deck instead. If this card is Fusion Summoned by the effect of "Abstain from Light": You can destroy 1 other card on the field. (Quick Effect): You can target 1 "Stain" Spell/Trap in your GY; apply that card's activation effect. You can only use each effect of "Stained Avatar" once per turn.

</details>

### 2. Niuhao - Zao - 250556612

- **Source ordinal:** 68. **Script:** [`c250556612.lua`](<../public/CCG Downloads/CCG_Scripts/c250556612.lua>)
- **Problem/question to solve:** future card-pool sensitivity.
- **Current audited implementation:** manually applied current Treasure branches [implemented]. The file compiles and initializes; the open item is behavioral or interpretive, not a known load failure.
- **Manual review checklist:**
  1. Enumerate the exact currently legal card IDs and confirm that every intended card is included and every unintended card is excluded.
  2. Decide whether the rule should be name-, set-code-, listed-text-, or explicit-ID-based, including how future cards enter the pool.
  3. Test one valid card, one near-name false positive, and a newly added/future placeholder so the implementation does not silently become stale.
  4. Run the relevant GY branch both with and without Necrovalley, including activation legality and a Necrovalley effect appearing before resolution.
  5. Include face-up and face-down banished cards and confirm hidden cards are never selected unless the text explicitly permits them.
- **Acceptance condition:** Record the authoritative interpretation and an Omega replay/log showing the positive case, the closest illegal case, and any listed interruption case. The observed result must match the exact source sequence and leave no broader/narrower legal pool than intended.

<details>
<summary>Exact current source text</summary>

2+ Level 1 Winged Beast monsters
Material detached from this card are banished instead. While this card has material, this card cannot be destroyed by card effects. Once per turn (Quick Effect): You can detach 1 material from this card; banish 2 "Sacred Treasure" Spells from your hand or GY, then, immediately after this effect resolves, apply the banished cards activation effects in sequence. You can only use this effect of "NiuHao - Zao" once per turn.

</details>

### 3. Prophecy of Infernos - 229327103

- **Source ordinal:** 92. **Script:** [`c229327103.lua`](<../public/CCG Downloads/CCG_Scripts/c229327103.lua>)
- **Problem/question to solve:** hardcoded text-list pool.
- **Current audited implementation:** return, summon, then text-list search [implemented]. The file compiles and initializes; the open item is behavioral or interpretive, not a known load failure.
- **Manual review checklist:**
  1. Enumerate the exact currently legal card IDs and confirm that every intended card is included and every unintended card is excluded.
  2. Decide whether the rule should be name-, set-code-, listed-text-, or explicit-ID-based, including how future cards enter the pool.
  3. Test one valid card, one near-name false positive, and a newly added/future placeholder so the implementation does not silently become stale.
  4. Include a full-zone case and a case where paying the cost opens a zone; the UI must not reject a legal post-cost state or promise an impossible summon.
  5. Attempt the effect/procedure twice and after a negated activation to confirm the intended card, effect, or oath count limit.
- **Acceptance condition:** Record the authoritative interpretation and an Omega replay/log showing the positive case, the closest illegal case, and any listed interruption case. The observed result must match the exact source sequence and leave no broader/narrower legal pool than intended.

<details>
<summary>Exact current source text</summary>

Target 1 FIRE monster you control that was Special Summoned from the Extra Deck; return that target to the Extra Deck, then Special Summon this card from your hand, and if you do, add 1 Spell/Trap from your Deck to your hand that lists "FIRE" in its text. You can only use this effect of "Prophecy of Infernos" once per turn.

</details>

### 4. Prophecy of Waterfalls - 251058567

- **Source ordinal:** 93. **Script:** [`c251058567.lua`](<../public/CCG Downloads/CCG_Scripts/c251058567.lua>)
- **Problem/question to solve:** hardcoded text-list pool.
- **Current audited implementation:** return, summon, then text-list search [implemented]. The file compiles and initializes; the open item is behavioral or interpretive, not a known load failure.
- **Manual review checklist:**
  1. Enumerate the exact currently legal card IDs and confirm that every intended card is included and every unintended card is excluded.
  2. Decide whether the rule should be name-, set-code-, listed-text-, or explicit-ID-based, including how future cards enter the pool.
  3. Test one valid card, one near-name false positive, and a newly added/future placeholder so the implementation does not silently become stale.
  4. Include a full-zone case and a case where paying the cost opens a zone; the UI must not reject a legal post-cost state or promise an impossible summon.
  5. Attempt the effect/procedure twice and after a negated activation to confirm the intended card, effect, or oath count limit.
- **Acceptance condition:** Record the authoritative interpretation and an Omega replay/log showing the positive case, the closest illegal case, and any listed interruption case. The observed result must match the exact source sequence and leave no broader/narrower legal pool than intended.

<details>
<summary>Exact current source text</summary>

Target 1 WATER monster you control that was Special Summoned from the Extra Deck; return that target to the Extra Deck, then Special Summon this card from your hand, and if you do, add 1 Spell/Trap from your Deck to your hand that lists "WATER" in its text. You can only use this effect of "Prophecy of Waterfalls" once per turn.

</details>

### 5. Prophecy of Boulders - 223558392

- **Source ordinal:** 94. **Script:** [`c223558392.lua`](<../public/CCG Downloads/CCG_Scripts/c223558392.lua>)
- **Problem/question to solve:** return/summon; current eligible search list empty.
- **Current audited implementation:** return/summon; current eligible search list empty. The file compiles and initializes; the open item is behavioral or interpretive, not a known load failure.
- **Manual review checklist:**
  1. Enumerate the exact currently legal card IDs and confirm that every intended card is included and every unintended card is excluded.
  2. Decide whether the rule should be name-, set-code-, listed-text-, or explicit-ID-based, including how future cards enter the pool.
  3. Test one valid card, one near-name false positive, and a newly added/future placeholder so the implementation does not silently become stale.
  4. Include a full-zone case and a case where paying the cost opens a zone; the UI must not reject a legal post-cost state or promise an impossible summon.
  5. Attempt the effect/procedure twice and after a negated activation to confirm the intended card, effect, or oath count limit.
- **Acceptance condition:** Record the authoritative interpretation and an Omega replay/log showing the positive case, the closest illegal case, and any listed interruption case. The observed result must match the exact source sequence and leave no broader/narrower legal pool than intended.

<details>
<summary>Exact current source text</summary>

Target 1 EARTH monster you control that was Special Summoned from the Extra Deck; return that target to the Extra Deck, then Special Summon this card from your hand, and if you do, add 1 Spell/Trap from your Deck to your hand that lists "EARTH" in its text. You can only use this effect of "Prophecy of Boulders" once per turn.

</details>

### 6. Prophecy of Storms - 223592011

- **Source ordinal:** 95. **Script:** [`c223592011.lua`](<../public/CCG Downloads/CCG_Scripts/c223592011.lua>)
- **Problem/question to solve:** hardcoded text-list pool.
- **Current audited implementation:** return, summon, then text-list search [implemented]. The file compiles and initializes; the open item is behavioral or interpretive, not a known load failure.
- **Manual review checklist:**
  1. Enumerate the exact currently legal card IDs and confirm that every intended card is included and every unintended card is excluded.
  2. Decide whether the rule should be name-, set-code-, listed-text-, or explicit-ID-based, including how future cards enter the pool.
  3. Test one valid card, one near-name false positive, and a newly added/future placeholder so the implementation does not silently become stale.
  4. Include a full-zone case and a case where paying the cost opens a zone; the UI must not reject a legal post-cost state or promise an impossible summon.
  5. Attempt the effect/procedure twice and after a negated activation to confirm the intended card, effect, or oath count limit.
- **Acceptance condition:** Record the authoritative interpretation and an Omega replay/log showing the positive case, the closest illegal case, and any listed interruption case. The observed result must match the exact source sequence and leave no broader/narrower legal pool than intended.

<details>
<summary>Exact current source text</summary>

Target 1 WIND monster you control that was Special Summoned from the Extra Deck; return that target to the Extra Deck, then Special Summon this card from your hand, and if you do, add 1 Spell/Trap from your Deck to your hand that lists "WIND" in its text. You can only use this effect of "Prophecy of Storms" once per turn.

</details>

### 7. Prophecy of Rays - 244920555

- **Source ordinal:** 96. **Script:** [`c244920555.lua`](<../public/CCG Downloads/CCG_Scripts/c244920555.lua>)
- **Problem/question to solve:** hardcoded text-list pool.
- **Current audited implementation:** return, summon, then text-list search [implemented]. The file compiles and initializes; the open item is behavioral or interpretive, not a known load failure.
- **Manual review checklist:**
  1. Enumerate the exact currently legal card IDs and confirm that every intended card is included and every unintended card is excluded.
  2. Decide whether the rule should be name-, set-code-, listed-text-, or explicit-ID-based, including how future cards enter the pool.
  3. Test one valid card, one near-name false positive, and a newly added/future placeholder so the implementation does not silently become stale.
  4. Include a full-zone case and a case where paying the cost opens a zone; the UI must not reject a legal post-cost state or promise an impossible summon.
  5. Attempt the effect/procedure twice and after a negated activation to confirm the intended card, effect, or oath count limit.
- **Acceptance condition:** Record the authoritative interpretation and an Omega replay/log showing the positive case, the closest illegal case, and any listed interruption case. The observed result must match the exact source sequence and leave no broader/narrower legal pool than intended.

<details>
<summary>Exact current source text</summary>

Target 1 LIGHT monster you control that was Special Summoned from the Extra Deck; return that target to the Extra Deck, then Special Summon this card from your hand, and if you do, add 1 Spell/Trap from your Deck to your hand that lists "LIGHT" in its text. You can only use this effect of "Prophecy of Rays" once per turn.

</details>

### 8. Prophecy of Shadows - 243920845

- **Source ordinal:** 97. **Script:** [`c243920845.lua`](<../public/CCG Downloads/CCG_Scripts/c243920845.lua>)
- **Problem/question to solve:** hardcoded text-list pool.
- **Current audited implementation:** return, summon, then text-list search [implemented]. The file compiles and initializes; the open item is behavioral or interpretive, not a known load failure.
- **Manual review checklist:**
  1. Enumerate the exact currently legal card IDs and confirm that every intended card is included and every unintended card is excluded.
  2. Decide whether the rule should be name-, set-code-, listed-text-, or explicit-ID-based, including how future cards enter the pool.
  3. Test one valid card, one near-name false positive, and a newly added/future placeholder so the implementation does not silently become stale.
  4. Include a full-zone case and a case where paying the cost opens a zone; the UI must not reject a legal post-cost state or promise an impossible summon.
  5. Attempt the effect/procedure twice and after a negated activation to confirm the intended card, effect, or oath count limit.
- **Acceptance condition:** Record the authoritative interpretation and an Omega replay/log showing the positive case, the closest illegal case, and any listed interruption case. The observed result must match the exact source sequence and leave no broader/narrower legal pool than intended.

<details>
<summary>Exact current source text</summary>

Target 1 DARK monster you control that was Special Summoned from the Extra Deck; return that target to the Extra Deck, then Special Summon this card from your hand, and if you do, add 1 Spell/Trap from your Deck to your hand that lists "DARK" in its text. You can only use this effect of "Prophecy of Shadows" once per turn.

</details>

### 9. To Proto Archegoni - 245400676

- **Source ordinal:** 131. **Script:** [`c245400676.lua`](<../public/CCG Downloads/CCG_Scripts/c245400676.lua>)
- **Problem/question to solve:** text-list pool.
- **Current audited implementation:** Link once-per-turn procedure; discard search resolves if source leaves [fixed]; protection [implemented]. The file compiles and initializes; the open item is behavioral or interpretive, not a known load failure.
- **Manual review checklist:**
  1. Enumerate the exact currently legal card IDs and confirm that every intended card is included and every unintended card is excluded.
  2. Decide whether the rule should be name-, set-code-, listed-text-, or explicit-ID-based, including how future cards enter the pool.
  3. Test one valid card, one near-name false positive, and a newly added/future placeholder so the implementation does not silently become stale.
  4. Run the relevant GY branch both with and without Necrovalley, including activation legality and a Necrovalley effect appearing before resolution.
  5. Include face-up and face-down banished cards and confirm hidden cards are never selected unless the text explicitly permits them.
- **Acceptance condition:** Record the authoritative interpretation and an Omega replay/log showing the positive case, the closest illegal case, and any listed interruption case. The observed result must match the exact source sequence and leave no broader/narrower legal pool than intended.

<details>
<summary>Exact current source text</summary>

1 "Protogenic Essence Token"\nYou can only Link Summon "To Proto Archegoni" once per turn. If this card is Link Summoned: You can discard 1 card; add 1 Spell/Trap from your Deck or GY to your hand that lists "To Proto" in its text or name. (Quick Effect): You can banish this card from your field or GY, then target 1 Galaxy Monster you control; that target cannot be destroyed by battle or your opponent's card effects until the end of this turn.

</details>

### 10. Polemistis Gia Ataxia - 254065048

- **Source ordinal:** 141. **Script:** [`c254065048.lua`](<../public/CCG Downloads/CCG_Scripts/c254065048.lua>)
- **Problem/question to solve:** continuous-loss interpretation.
- **Current audited implementation:** Tribute Fusion procedure; loss-based stat gain; attack-all; hardcoded Ataxia S/T access [implemented]. The file compiles and initializes; the open item is behavioral or interpretive, not a known load failure.
- **Manual review checklist:**
  1. Enumerate the exact currently legal card IDs and confirm that every intended card is included and every unintended card is excluded.
  2. Decide whether the rule should be name-, set-code-, listed-text-, or explicit-ID-based, including how future cards enter the pool.
  3. Test one valid card, one near-name false positive, and a newly added/future placeholder so the implementation does not silently become stale.
  4. Run the relevant GY branch both with and without Necrovalley, including activation legality and a Necrovalley effect appearing before resolution.
  5. Include a full-zone case and a case where paying the cost opens a zone; the UI must not reject a legal post-cost state or promise an impossible summon.
- **Acceptance condition:** Record the authoritative interpretation and an Omega replay/log showing the positive case, the closest illegal case, and any listed interruption case. The observed result must match the exact source sequence and leave no broader/narrower legal pool than intended.

<details>
<summary>Exact current source text</summary>

2 Level 1 or higher "Protogenic Essence Tokens"
Must first be Special Summoned (from your Extra Deck) by Tributing the Required Materials you control while you control "To Proto Ataxia" (You do not use "Polymerization"). If a monster(s) loses ATK/DEF, this card gains half the ATK/DEF. This card can attack all monsters your opponent controls, once each. If this card is Special Summoned from the Extra Deck: You can add to your hand or send to the GY 1 "Ataxia" Spell/Trap from your Deck. You can only use this effect of "Polemistis gia Ataxia" once per turn.

</details>

### 11. Ektelestis Gia Taxis - 212684822

- **Source ordinal:** 142. **Script:** [`c212684822.lua`](<../public/CCG Downloads/CCG_Scripts/c212684822.lua>)
- **Problem/question to solve:** damage layering/card pool.
- **Current audited implementation:** Tribute Fusion procedure; reflected half damage; hardcoded Taxis S/T access [implemented]. The file compiles and initializes; the open item is behavioral or interpretive, not a known load failure.
- **Manual review checklist:**
  1. Enumerate the exact currently legal card IDs and confirm that every intended card is included and every unintended card is excluded.
  2. Decide whether the rule should be name-, set-code-, listed-text-, or explicit-ID-based, including how future cards enter the pool.
  3. Test one valid card, one near-name false positive, and a newly added/future placeholder so the implementation does not silently become stale.
  4. Run the relevant GY branch both with and without Necrovalley, including activation legality and a Necrovalley effect appearing before resolution.
  5. Include a full-zone case and a case where paying the cost opens a zone; the UI must not reject a legal post-cost state or promise an impossible summon.
- **Acceptance condition:** Record the authoritative interpretation and an Omega replay/log showing the positive case, the closest illegal case, and any listed interruption case. The observed result must match the exact source sequence and leave no broader/narrower legal pool than intended.

<details>
<summary>Exact current source text</summary>

2 Level 1 or higher "Protogenic Essence Tokens"
Must first be Special Summoned (from your Extra Deck) by Tributing the Required Materials you control while you control "To Proto Taxis" (You do not use "Polymerization"). Your opponent takes half the battle damage you would have taken from battles involving this card. If this card is Special Summoned from the Extra Deck: You can add to your hand or send to the GY 1 "Taxis" Spell/Trap from your Deck. You can only use this effect of "Ektelestis gia Taxis" once per turn.

</details>

### 12. Birth of Azrynior - 239245471

- **Source ordinal:** 159. **Script:** [`c239245471.lua`](<../public/CCG Downloads/CCG_Scripts/c239245471.lua>)
- **Problem/question to solve:** named S/T pool.
- **Current audited implementation:** Token-then-Fusion; optional shuffle and GY recovery [implemented]. The file compiles and initializes; the open item is behavioral or interpretive, not a known load failure.
- **Manual review checklist:**
  1. Enumerate the exact currently legal card IDs and confirm that every intended card is included and every unintended card is excluded.
  2. Decide whether the rule should be name-, set-code-, listed-text-, or explicit-ID-based, including how future cards enter the pool.
  3. Test one valid card, one near-name false positive, and a newly added/future placeholder so the implementation does not silently become stale.
  4. Run the relevant GY branch both with and without Necrovalley, including activation legality and a Necrovalley effect appearing before resolution.
  5. Include face-up and face-down banished cards and confirm hidden cards are never selected unless the text explicitly permits them.
- **Acceptance condition:** Record the authoritative interpretation and an Omega replay/log showing the positive case, the closest illegal case, and any listed interruption case. The observed result must match the exact source sequence and leave no broader/narrower legal pool than intended.

<details>
<summary>Exact current source text</summary>

(This card is also treated as a "Ataxia" card.)
Special Summon 1 "Protogenic Essence Token" (Galaxy/LIGHT/Level 1/ATK 0/DEF 0), but that Token cannot be used as Link Material, and if you do, Fusion Summon 1 "Azrynior, the Abundaence of Purity" from your Extra Deck by using monsters in your hand and/or field as Fusion Material. If "Azrynior, the Abundaence of Purity" leaves the field because of your opponent's card: You can also shuffle 1 LIGHT or DARK Dragon Monster from your GY or banishment into the Deck; add this card from your GY to your hand. You can only use the previous effect of "Birth of Azrynior" once per turn.

</details>

### 13. Fall of Azrynior - 224751741

- **Source ordinal:** 160. **Script:** [`c224751741.lua`](<../public/CCG Downloads/CCG_Scripts/c224751741.lua>)
- **Problem/question to solve:** named S/T pool.
- **Current audited implementation:** Normal Spell Token/Fusion no longer depends on source relation [fixed]; GY shuffle cost and recovery [implemented]. The file compiles and initializes; the open item is behavioral or interpretive, not a known load failure.
- **Manual review checklist:**
  1. Enumerate the exact currently legal card IDs and confirm that every intended card is included and every unintended card is excluded.
  2. Decide whether the rule should be name-, set-code-, listed-text-, or explicit-ID-based, including how future cards enter the pool.
  3. Test one valid card, one near-name false positive, and a newly added/future placeholder so the implementation does not silently become stale.
  4. Run the relevant GY branch both with and without Necrovalley, including activation legality and a Necrovalley effect appearing before resolution.
  5. Include face-up and face-down banished cards and confirm hidden cards are never selected unless the text explicitly permits them.
- **Acceptance condition:** Record the authoritative interpretation and an Omega replay/log showing the positive case, the closest illegal case, and any listed interruption case. The observed result must match the exact source sequence and leave no broader/narrower legal pool than intended.

<details>
<summary>Exact current source text</summary>

(This card is also treated as a "Taxis" card.)
Special Summon 1 "Protogenic Essence Token" (Galaxy/DARK/Level 1/ATK 0/DEF 0), but that Token cannot be used as Link Material, then Fusion Summon 1 "Dysmandr, the Depraevity of Worlds" from your Extra Deck by using monsters in your hand and/or field as Fusion Material. If "Dysmandr, the Depraevity of Worlds" leaves the field because of your opponent's card: You can also shuffle 1 LIGHT or DARK Dragon Monster from your GY or banishment into the Deck to activate this effect; add this card from your GY to your hand. You can only use the previous effect of "Fall of Azrynior" once per turn.

</details>

### 14. Azrynior, the Abundaence of Purity - 245099829

- **Source ordinal:** 162. **Script:** [`c245099829.lua`](<../public/CCG Downloads/CCG_Scripts/c245099829.lua>)
- **Problem/question to solve:** hardcoded S/T pool.
- **Current audited implementation:** Fusion/protection/stat; place S/T; global Token-Tribute tracker and End Token [implemented]. The file compiles and initializes; the open item is behavioral or interpretive, not a known load failure.
- **Manual review checklist:**
  1. Enumerate the exact currently legal card IDs and confirm that every intended card is included and every unintended card is excluded.
  2. Decide whether the rule should be name-, set-code-, listed-text-, or explicit-ID-based, including how future cards enter the pool.
  3. Test one valid card, one near-name false positive, and a newly added/future placeholder so the implementation does not silently become stale.
  4. Run the relevant GY branch both with and without Necrovalley, including activation legality and a Necrovalley effect appearing before resolution.
  5. Include a full-zone case and a case where paying the cost opens a zone; the UI must not reject a legal post-cost state or promise an impossible summon.
- **Acceptance condition:** Record the authoritative interpretation and an Omega replay/log showing the positive case, the closest illegal case, and any listed interruption case. The observed result must match the exact source sequence and leave no broader/narrower legal pool than intended.

<details>
<summary>Exact current source text</summary>

(This card is always treated as a "Stellaer" card.)
1 Rank/Level 9 LIGHT Dragon Monster + 1 "Protogenic Essence Token"
Cannot be destroyed by card effects, also, this card gains 3000 ATK/DEF. During the Main Phase, or, if this card is Fusion Summoned: You can place 1 "Azrynior" Continuous Spell/Trap from your hand, Deck, or GY, face-up in your Spell & Trap Zone. During the End Phase, if a "Protogenic Essence Token" was Tributed this turn: You can Special Summon 1 "Protogenic Essence Token" (Galaxy/LIGHT/Level 1/ATK 0/DEF 0), but that Token cannot be used as Link Material. You can only use each effect of "Azrynior, the Abundaence of Purity" once per turn.

</details>

### 15. Dysmandr, the Depraevity of Worlds - 223512283

- **Source ordinal:** 163. **Script:** [`c223512283.lua`](<../public/CCG Downloads/CCG_Scripts/c223512283.lua>)
- **Problem/question to solve:** hardcoded S/T pool.
- **Current audited implementation:** Fusion/protection/stat; Galaxy race corrected [fixed]; source-independent place and End trigger [fixed]. The file compiles and initializes; the open item is behavioral or interpretive, not a known load failure.
- **Manual review checklist:**
  1. Enumerate the exact currently legal card IDs and confirm that every intended card is included and every unintended card is excluded.
  2. Decide whether the rule should be name-, set-code-, listed-text-, or explicit-ID-based, including how future cards enter the pool.
  3. Test one valid card, one near-name false positive, and a newly added/future placeholder so the implementation does not silently become stale.
  4. Run the relevant GY branch both with and without Necrovalley, including activation legality and a Necrovalley effect appearing before resolution.
  5. Include a full-zone case and a case where paying the cost opens a zone; the UI must not reject a legal post-cost state or promise an impossible summon.
- **Acceptance condition:** Record the authoritative interpretation and an Omega replay/log showing the positive case, the closest illegal case, and any listed interruption case. The observed result must match the exact source sequence and leave no broader/narrower legal pool than intended.

<details>
<summary>Exact current source text</summary>

(This card is always treated as a "Stellar" card.)
1 Rank/Level 9 LIGHT Dragon Monster + 1 "Protogenic Essence Token"
Cannot be destroyed by battle, also, this card gains 3000 ATK/DEF. During the Main Phase, or, if this card is Fusion Summoned: You can place 1 "Dysmandr" Continuous Spell/Trap from your hand, Deck, or GY, face-up in your Spell & Trap Zone. During the End Phase, if a monster was destroyed this turn: You can Special Summon 1 "Protogenic Essence Token" (Galaxy/DARK/Level 1/ATK 0/DEF 0), but that Token cannot be used as Link Material. You can only use each effect of "Dysmandr, the Depraevity of Worlds" once per turn.

</details>

### 16. Vir Pedicae Mortis - Entity's Happy Servant - 215984744

- **Source ordinal:** 186. **Script:** [`c215984744.lua`](<../public/CCG Downloads/CCG_Scripts/c215984744.lua>)
- **Problem/question to solve:** The script's code-based approximation of the printed "Mine" Field Spell/"Recollection" identity needs an authoritative card-pool/ruling confirmation.
- **Current audited implementation:** The script's code-based approximation of the printed "Mine" Field Spell/"Recollection" identity needs an authoritative card-pool/ruling confirmation. The file compiles and initializes; the open item is behavioral or interpretive, not a known load failure.
- **Manual review checklist:**
  1. Enumerate the exact currently legal card IDs and confirm that every intended card is included and every unintended card is excluded.
  2. Decide whether the rule should be name-, set-code-, listed-text-, or explicit-ID-based, including how future cards enter the pool.
  3. Test one valid card, one near-name false positive, and a newly added/future placeholder so the implementation does not silently become stale.
  4. Run the relevant GY branch both with and without Necrovalley, including activation legality and a Necrovalley effect appearing before resolution.
  5. Include a full-zone case and a case where paying the cost opens a zone; the UI must not reject a legal post-cost state or promise an impossible summon.
- **Acceptance condition:** Record the authoritative interpretation and an Omega replay/log showing the positive case, the closest illegal case, and any listed interruption case. The observed result must match the exact source sequence and leave no broader/narrower legal pool than intended.

<details>
<summary>Exact current source text</summary>

If this card is Normal or Special Summoned: You can discard 1 card or send 1 "Recollection" card you control to the GY; add 1 "Recollection" card and 1 "Bear Trap" or 1 "Mortis" card from your Deck to your hand. You can only use this effect of "Vir Pedicae Mortis - Entity's Happy Servant" once per turn. While you control "Pedicae's Papa", "Recollection" cards and "Mine" Field Spells you control cannot be destroyed by your opponent's card effects.

</details>

### 17. Hallo, the Hollow Trickster - 231331942

- **Source ordinal:** 378. **Script:** [`c231331942.lua`](<../public/CCG Downloads/CCG_Scripts/c231331942.lua>)
- **Problem/question to solve:** Hallo, the Spirit of Tricks is absent from cards.json/DB, so the first effect cannot fully resolve.
- **Current audited implementation:** Hallo, the Spirit of Tricks is absent from cards.json/DB, so the first effect cannot fully resolve. The file compiles and initializes; the open item is behavioral or interpretive, not a known load failure.
- **Manual review checklist:**
  1. Enumerate the exact currently legal card IDs and confirm that every intended card is included and every unintended card is excluded.
  2. Decide whether the rule should be name-, set-code-, listed-text-, or explicit-ID-based, including how future cards enter the pool.
  3. Test one valid card, one near-name false positive, and a newly added/future placeholder so the implementation does not silently become stale.
  4. Run the relevant GY branch both with and without Necrovalley, including activation legality and a Necrovalley effect appearing before resolution.
  5. Include a full-zone case and a case where paying the cost opens a zone; the UI must not reject a legal post-cost state or promise an impossible summon.
- **Acceptance condition:** Record the authoritative interpretation and an Omega replay/log showing the positive case, the closest illegal case, and any listed interruption case. The observed result must match the exact source sequence and leave no broader/narrower legal pool than intended.

<details>
<summary>Exact current source text</summary>

Cannot be Normal Summoned/Set. Must first be Special Summoned by the effect of "A Night of Fright on Hallo-Ween!". If this card is Special Summoned: You can Special Summon 1 "Hallo, the Spirit of Tricks" from your hand or GY, then inflict 500 damage to your opponent for each Fiend monster in your GY. If this card is sent to the GY: Take 500 damage for each Fiend monster in your GY, then add 1 "Hallo-Ween" Spell from your Deck to your hand. You can only use each effect of "Hallo, The Hollow Trickster" once per turn.

</details>

## Copied, rewritten, and resolving effects

### 18. Stained Silhouette - 256608976

- **Source ordinal:** 12. **Script:** [`c256608976.lua`](<../public/CCG Downloads/CCG_Scripts/c256608976.lua>)
- **Problem/question to solve:** nonstandard CopyEffect.
- **Current audited implementation:** Fusion/protection; copied-effect behavior [implemented]. The file compiles and initializes; the open item is behavioral or interpretive, not a known load failure.
- **Manual review checklist:**
  1. Test every currently eligible source effect, including one with a cost, one that targets, and one whose target leaves the expected location before resolution.
  2. Confirm which card/effect owns the copied operation, which count limit applies, and whether the original activation cost and target function must run.
  3. Test negation, immunity, chain-link changes, and source-card removal so the rewritten/copied operation does not resolve with stale targets or the wrong player.
  4. Run the relevant GY branch both with and without Necrovalley, including activation legality and a Necrovalley effect appearing before resolution.
  5. Include a full-zone case and a case where paying the cost opens a zone; the UI must not reject a legal post-cost state or promise an impossible summon.
- **Acceptance condition:** Record the authoritative interpretation and an Omega replay/log showing the positive case, the closest illegal case, and any listed interruption case. The observed result must match the exact source sequence and leave no broader/narrower legal pool than intended.

<details>
<summary>Exact current source text</summary>

If a card(s) leaves your opponent's Deck, except during the Draw Phase: You can Special Summon this card from your hand, but shuffle this card face-up into your opponent's Deck when it leaves the field. If your opponent controls a card (Quick Effect): You can reveal 1 "Stain" card in your hand, then activate 1 of these effects;\n Special Summon 1 Level 4 or lower "Stain" monster from your Deck or GY.\n Until the End Phase, this card's name becomes the original name of 1 face-up monster your opponent controls, and it gains that monster's original effects.\nYou can only use each effect of "Stained Silhouette" once per turn.

</details>

### 19. Rage of Nephthys - 256287781

- **Source ordinal:** 129. **Script:** [`c256287781.lua`](<../public/CCG Downloads/CCG_Scripts/c256287781.lua>)
- **Problem/question to solve:** quoted pronoun ruling.
- **Current audited implementation:** ATK-loss/destroy; cost shuffle and chain rewrite [implemented]. The file compiles and initializes; the open item is behavioral or interpretive, not a known load failure.
- **Manual review checklist:**
  1. Test every currently eligible source effect, including one with a cost, one that targets, and one whose target leaves the expected location before resolution.
  2. Confirm which card/effect owns the copied operation, which count limit applies, and whether the original activation cost and target function must run.
  3. Test negation, immunity, chain-link changes, and source-card removal so the rewritten/copied operation does not resolve with stale targets or the wrong player.
  4. Run the relevant GY branch both with and without Necrovalley, including activation legality and a Necrovalley effect appearing before resolution.
  5. Attempt the effect/procedure twice and after a negated activation to confirm the intended card, effect, or oath count limit.
- **Acceptance condition:** Record the authoritative interpretation and an Omega replay/log showing the positive case, the closest illegal case, and any listed interruption case. The observed result must match the exact source sequence and leave no broader/narrower legal pool than intended.

<details>
<summary>Exact current source text</summary>

During your opponent's Main Phase: You can make all monsters your opponent currently controls lose ATK equal to the ATK of the "Nephthys" monster you control with the highest ATK, then if their ATK becomes 0 by this effect, destroy them. During your Main Phase: When your opponent activates a card or effect: You can shuffle 4 "Nephthys" cards from your GY into the Deck; the activated effect becomes "Your opponent destroys 1 "Nephthys" monster in their hand, Deck, or field". You can only use each effect of "Rage of Nephthys" once per turn.

</details>

### 20. Eldora, the Intergalactic Empire - 214552846

- **Source ordinal:** 165. **Script:** [`c214552846.lua`](<../public/CCG Downloads/CCG_Scripts/c214552846.lua>)
- **Problem/question to solve:** 12 source typo / operation-info inference.
- **Current audited implementation:** resolve-time effect negate; destroyed trigger mass destruction and Set-turn activation [implemented]. The file compiles and initializes; the open item is behavioral or interpretive, not a known load failure.
- **Manual review checklist:**
  1. Test every currently eligible source effect, including one with a cost, one that targets, and one whose target leaves the expected location before resolution.
  2. Confirm which card/effect owns the copied operation, which count limit applies, and whether the original activation cost and target function must run.
  3. Test negation, immunity, chain-link changes, and source-card removal so the rewritten/copied operation does not resolve with stale targets or the wrong player.
  4. Run the relevant GY branch both with and without Necrovalley, including activation legality and a Necrovalley effect appearing before resolution.
  5. Include face-up and face-down banished cards and confirm hidden cards are never selected unless the text explicitly permits them.
- **Acceptance condition:** Record the authoritative interpretation and an Omega replay/log showing the positive case, the closest illegal case, and any listed interruption case. The observed result must match the exact source sequence and leave no broader/narrower legal pool than intended.

<details>
<summary>Exact current source text</summary>

When your opponent's card effect that would destroy two or more monsters you control resolves, you can destroy this card you control, then negate that effect. If this card is destroyed and sent to the GY: Target 1 Effect Monster you control; destroy that monster and all other Effect Monsters you control with at least 12 of the same Type, Attribute, Level, ATK or DEF, except "Dysmandr, the Depraevity of Worlds", then you can Set 1 "Eldora in Depraevity" directly from your Deck, GY, or Banishment, and if you do, it can be activated this turn. You can only use this effect of "Eldora, the Intergalactic Empire" once per turn.

</details>

### 21. Frozen Girl & Blood Moon - 222676270

- **Source ordinal:** 167. **Script:** [`c222676270.lua`](<../public/CCG Downloads/CCG_Scripts/c222676270.lua>)
- **Problem/question to solve:** classifier false-positive/negative testing.
- **Current audited implementation:** discard cost; effect-negate; operation-category classifier [implemented]. The file compiles and initializes; the open item is behavioral or interpretive, not a known load failure.
- **Manual review checklist:**
  1. Test every currently eligible source effect, including one with a cost, one that targets, and one whose target leaves the expected location before resolution.
  2. Confirm which card/effect owns the copied operation, which count limit applies, and whether the original activation cost and target function must run.
  3. Test negation, immunity, chain-link changes, and source-card removal so the rewritten/copied operation does not resolve with stale targets or the wrong player.
  4. Run the relevant GY branch both with and without Necrovalley, including activation legality and a Necrovalley effect appearing before resolution.
  5. Include a full-zone case and a case where paying the cost opens a zone; the UI must not reject a legal post-cost state or promise an impossible summon.
- **Acceptance condition:** Record the authoritative interpretation and an Omega replay/log showing the positive case, the closest illegal case, and any listed interruption case. The observed result must match the exact source sequence and leave no broader/narrower legal pool than intended.

<details>
<summary>Exact current source text</summary>

When a card or effect is activated that includes any of these effects (Quick Effect): You can discard this card; negate that effect.
 Place a Spell/Trap Card(s) from the hand, Deck or GY face-up on the field.
 Place a Monster Card(s) in the Spell & Trap Zone.
 Set a card(s) from the hand, Deck or GY.
You can only use this effect of "Frozen Girl & Blood Moon" once per turn.

</details>

### 22. Ghost Doll & Midnight Manor - 222782750

- **Source ordinal:** 168. **Script:** [`c222782750.lua`](<../public/CCG Downloads/CCG_Scripts/c222782750.lua>)
- **Problem/question to solve:** operation-info coverage.
- **Current audited implementation:** discard cost; activation-negate; banishment operation classifier [implemented]. The file compiles and initializes; the open item is behavioral or interpretive, not a known load failure.
- **Manual review checklist:**
  1. Test every currently eligible source effect, including one with a cost, one that targets, and one whose target leaves the expected location before resolution.
  2. Confirm which card/effect owns the copied operation, which count limit applies, and whether the original activation cost and target function must run.
  3. Test negation, immunity, chain-link changes, and source-card removal so the rewritten/copied operation does not resolve with stale targets or the wrong player.
  4. Include face-up and face-down banished cards and confirm hidden cards are never selected unless the text explicitly permits them.
  5. Include a full-zone case and a case where paying the cost opens a zone; the UI must not reject a legal post-cost state or promise an impossible summon.
- **Acceptance condition:** Record the authoritative interpretation and an Omega replay/log showing the positive case, the closest illegal case, and any listed interruption case. The observed result must match the exact source sequence and leave no broader/narrower legal pool than intended.

<details>
<summary>Exact current source text</summary>

When a card or effect is activated that includes any of these effects (Quick Effect): You can discard this card; negate that activation.
 Add a banished card(s) to the hand, Deck, and/or Extra Deck.
 Special Summon a banished Monster Card(s).
 Banish a card(s) from the Deck.
You can only use this effect of "Ghost Doll & Midnight Manor" once per turn.

</details>

### 23. Clock of Aldrez - 210716547

- **Source ordinal:** 170. **Script:** [`c210716547.lua`](<../public/CCG Downloads/CCG_Scripts/c210716547.lua>)
- **Problem/question to solve:** concurrent chain rewrite state.
- **Current audited implementation:** summon Deck send; Spell/Trap chain rewrite; restriction now independent of Special Summon success [fixed]. The file compiles and initializes; the open item is behavioral or interpretive, not a known load failure.
- **Manual review checklist:**
  1. Test every currently eligible source effect, including one with a cost, one that targets, and one whose target leaves the expected location before resolution.
  2. Confirm which card/effect owns the copied operation, which count limit applies, and whether the original activation cost and target function must run.
  3. Test negation, immunity, chain-link changes, and source-card removal so the rewritten/copied operation does not resolve with stale targets or the wrong player.
  4. Run the relevant GY branch both with and without Necrovalley, including activation legality and a Necrovalley effect appearing before resolution.
  5. Include a full-zone case and a case where paying the cost opens a zone; the UI must not reject a legal post-cost state or promise an impossible summon.
- **Acceptance condition:** Record the authoritative interpretation and an Omega replay/log showing the positive case, the closest illegal case, and any listed interruption case. The observed result must match the exact source sequence and leave no broader/narrower legal pool than intended.

<details>
<summary>Exact current source text</summary>

If this card is Normal or Special Summoned: You can send 1 "Aldrez" card from your Deck to your GY. When your opponent activates a Spell/Trap Card or effect while this card is in your hand or face-up on your field (Quick Effect): You can Tribute this card; the activated effect becomes "Send 1 face-up Xyz Monster your opponent controls to the GY", then Special Summon this card from your GY to your opponent's field (with its effects negated), also, you cannot activate monster effects on the field until the end of this turn, except "Aldrez" monsters. You can only use each effect of "Clock of Aldrez" once per turn.

</details>

### 24. Chapter Ii Verse Iv - 241957394

- **Source ordinal:** 276. **Script:** [`c241957394.lua`](<../public/CCG Downloads/CCG_Scripts/c241957394.lua>)
- **Problem/question to solve:** Corrected rewritten chain target to the Effect Monster actually chosen and rewrote sequencing to destroy other matching monsters first, then the chosen monster only on success; retroactive Token-tribute/cost semantics still require an Omega duel test.
- **Current audited implementation:** Corrected rewritten chain target to the Effect Monster actually chosen and rewrote sequencing to destroy other matching monsters first, then the chosen monster only on success; retroactive Token-tribute/cost semantics still require an Omega duel test. The file compiles and initializes; the open item is behavioral or interpretive, not a known load failure.
- **Manual review checklist:**
  1. Test every currently eligible source effect, including one with a cost, one that targets, and one whose target leaves the expected location before resolution.
  2. Confirm which card/effect owns the copied operation, which count limit applies, and whether the original activation cost and target function must run.
  3. Test negation, immunity, chain-link changes, and source-card removal so the rewritten/copied operation does not resolve with stale targets or the wrong player.
  4. Run the relevant GY branch both with and without Necrovalley, including activation legality and a Necrovalley effect appearing before resolution.
  5. Remove or make the target unaffected before resolution and confirm no dependent action is performed from a stale target.
- **Acceptance condition:** Record the authoritative interpretation and an Omega replay/log showing the positive case, the closest illegal case, and any listed interruption case. The observed result must match the exact source sequence and leave no broader/narrower legal pool than intended.

<details>
<summary>Exact current source text</summary>

(This card is also treated as "The Hallowed Scripts of the Ataxia".)
When your opponent activates a card effect: You can show 1 "Dysmandr, the Depraevity of Worlds" in your Extra Deck and choose 1 Effect Monster you control; Send 1 "Extinction of Dysmandr" from your Deck to the GY (but shuffle it into the Deck during the End Phase), and if you do, your opponent's activated card effect becomes the sent card's effect that Tributes a "Protogenic Essence Token" to activate.

</details>

### 25. Myutant Amalgamate - 211699737

- **Source ordinal:** 373. **Script:** [`c211699737.lua`](<../public/CCG Downloads/CCG_Scripts/c211699737.lua>)
- **Problem/question to solve:** "This effect becomes that monster's original effect" is approximated with CopyEffect and needs a ruling.
- **Current audited implementation:** "This effect becomes that monster's original effect" is approximated with CopyEffect and needs a ruling. The file compiles and initializes; the open item is behavioral or interpretive, not a known load failure.
- **Manual review checklist:**
  1. Test every currently eligible source effect, including one with a cost, one that targets, and one whose target leaves the expected location before resolution.
  2. Confirm which card/effect owns the copied operation, which count limit applies, and whether the original activation cost and target function must run.
  3. Test negation, immunity, chain-link changes, and source-card removal so the rewritten/copied operation does not resolve with stale targets or the wrong player.
  4. Run the relevant GY branch both with and without Necrovalley, including activation legality and a Necrovalley effect appearing before resolution.
  5. Include face-up and face-down banished cards and confirm hidden cards are never selected unless the text explicitly permits them.
- **Acceptance condition:** Record the authoritative interpretation and an Omega replay/log showing the positive case, the closest illegal case, and any listed interruption case. The observed result must match the exact source sequence and leave no broader/narrower legal pool than intended.

<details>
<summary>Exact current source text</summary>

2 "Myutant" monsters. If this card is Fusion Summoned: You can Set 1 "Myutant" Spell/Trap Card from your Deck, GY, or banishment. During your Main Phase: You can reveal 1 "Myutant" card from your Deck; send it to the GY, then banish 1 monster from your Deck based on the revealed card, and if you do, this effect becomes that monster's original effect.  Monster: "Myutant Beast"  Spell: "Myutant Mist"  Trap: "Myutant Arsenal". You can only use each effect of "Myutant Amalgamate" once per turn.

</details>

### 26. Gravinity Axis Matter - 256831125

- **Source ordinal:** 438. **Script:** [`c256831125.lua`](<../public/CCG Downloads/CCG_Scripts/c256831125.lua>)
- **Problem/question to solve:** Copied-effect scope and printed Link Rating reduction are not exact.
- **Current audited implementation:** Copied-effect scope and printed Link Rating reduction are not exact. The file compiles and initializes; the open item is behavioral or interpretive, not a known load failure.
- **Manual review checklist:**
  1. Test every currently eligible source effect, including one with a cost, one that targets, and one whose target leaves the expected location before resolution.
  2. Confirm which card/effect owns the copied operation, which count limit applies, and whether the original activation cost and target function must run.
  3. Test negation, immunity, chain-link changes, and source-card removal so the rewritten/copied operation does not resolve with stale targets or the wrong player.
  4. Attempt the effect/procedure twice and after a negated activation to confirm the intended card, effect, or oath count limit.
  5. Remove or make the target unaffected before resolution and confirm no dependent action is performed from a stale target.
- **Acceptance condition:** Record the authoritative interpretation and an Omega replay/log showing the positive case, the closest illegal case, and any listed interruption case. The observed result must match the exact source sequence and leave no broader/narrower legal pool than intended.

<details>
<summary>Exact current source text</summary>

Your opponent cannot target "Gravinity" Synchro Monster Cards with card effects. Reduce the Level/Rank/Link Rating of your opponent's monsters in the same column as a "Gravinity" monster by 1. During the Standby Phase: You can reveal 1 Level 11 "Gravinity" Synchro Monster in your Extra Deck; for the rest of this turn, this card gains the non-activated effects of the revealed monster. You can only use this effect of "Gravinity Axis Matter" once per turn.

</details>

### 27. Galactican Battle Station - 258934904

- **Source ordinal:** 454. **Script:** [`c258934904.lua`](<../public/CCG Downloads/CCG_Scripts/c258934904.lua>)
- **Problem/question to solve:** Adds an effect to another resolving effect in Damage Step.
- **Current audited implementation:** Adds an effect to another resolving effect in Damage Step. The file compiles and initializes; the open item is behavioral or interpretive, not a known load failure.
- **Manual review checklist:**
  1. Test every currently eligible source effect, including one with a cost, one that targets, and one whose target leaves the expected location before resolution.
  2. Confirm which card/effect owns the copied operation, which count limit applies, and whether the original activation cost and target function must run.
  3. Test negation, immunity, chain-link changes, and source-card removal so the rewritten/copied operation does not resolve with stale targets or the wrong player.
  4. Include a full-zone case and a case where paying the cost opens a zone; the UI must not reject a legal post-cost state or promise an impossible summon.
- **Acceptance condition:** Record the authoritative interpretation and an Omega replay/log showing the positive case, the closest illegal case, and any listed interruption case. The observed result must match the exact source sequence and leave no broader/narrower legal pool than intended.

<details>
<summary>Exact current source text</summary>

Your monsters cannot attack directly, except "Galactica" monsters. "Galactica" monsters you control can attack directly. Up to twice per turn, during the Damage Step, if you activate a monster effect that would Summon a "Galactica" monster, you can add this additional effect to that card's effect at resolution.  Also after that, destroy 1 card on the field.

</details>

## Co-link, counter, and zone topology

### 28. Protogenic Astral Cycle - 232706629

- **Source ordinal:** 134. **Script:** [`c232706629.lua`](<../public/CCG Downloads/CCG_Scripts/c232706629.lua>)
- **Problem/question to solve:** zone mask / "ignore card effects".
- **Current audited implementation:** column zone mask; Token summon; banish cost and ignore-condition summon [implemented]. The file compiles and initializes; the open item is behavioral or interpretive, not a known load failure.
- **Manual review checklist:**
  1. Build the smallest, branching, and cyclic co-link layouts and verify traversal visits each legal monster exactly once.
  2. Repeat with every Main Monster Zone occupied, a destination becoming occupied mid-chain, and counters removed before resolution.
  3. Confirm counter removal occurs in the printed cost window and that movement/protection updates immediately when links or control change.
  4. Run the relevant GY branch both with and without Necrovalley, including activation legality and a Necrovalley effect appearing before resolution.
  5. Include face-up and face-down banished cards and confirm hidden cards are never selected unless the text explicitly permits them.
- **Acceptance condition:** Record the authoritative interpretation and an Omega replay/log showing the positive case, the closest illegal case, and any listed interruption case. The observed result must match the exact source sequence and leave no broader/narrower legal pool than intended.

<details>
<summary>Exact current source text</summary>

Neither player can Summon Effect Monsters to Main Monster Zones in this card's column. Once per turn: You can Special Summon 1 "Protogenic Essence Token" (Galaxy/LIGHT/Level 1/ATK 0/DEF 0). If your opponent activates a card effect: You can Special Summon 1 "To Proto" monster from your hand or GY ignoring its card effects by banishing 1 Effect Monster you control. You can only use the previous effect of "Protogenic Astral Cycle" once per turn.

</details>

### 29. Carcel, the Dark Ohmen - 259780273

- **Source ordinal:** 298. **Script:** [`c259780273.lua`](<../public/CCG Downloads/CCG_Scripts/c259780273.lua>)
- **Problem/question to solve:** Added the official retroactive Ohmen-only Special Summon activity lock. Custom reveal/two-card summon and traversal behavior still needs duel-engine validation.
- **Current audited implementation:** Added the official retroactive Ohmen-only Special Summon activity lock. Custom reveal/two-card summon and traversal behavior still needs duel-engine validation. The file compiles and initializes; the open item is behavioral or interpretive, not a known load failure.
- **Manual review checklist:**
  1. Build the smallest, branching, and cyclic co-link layouts and verify traversal visits each legal monster exactly once.
  2. Repeat with every Main Monster Zone occupied, a destination becoming occupied mid-chain, and counters removed before resolution.
  3. Confirm counter removal occurs in the printed cost window and that movement/protection updates immediately when links or control change.
  4. Include a full-zone case and a case where paying the cost opens a zone; the UI must not reject a legal post-cost state or promise an impossible summon.
  5. Attempt the effect/procedure twice and after a negated activation to confirm the intended card, effect, or oath count limit.
- **Acceptance condition:** Record the authoritative interpretation and an Omega replay/log showing the positive case, the closest illegal case, and any listed interruption case. The observed result must match the exact source sequence and leave no broader/narrower legal pool than intended.

<details>
<summary>Exact current source text</summary>

You can reveal this card in your hand and 1 "Ohmen" monster in your Deck; Special Summon both monsters. You cannot Special Summon monsters the turn you use this effect except "Ohmen" monsters. If this card is used as Link Material: You can target 1 "Ohmechanic" monster you control; place 1 Current Counter on it for each "Ohmen" monster you control. You can only use each effect of "Carcel, the Dark Ohmen" once per turn.

</details>

### 30. Ohmen Surge - 259869259

- **Source ordinal:** 299. **Script:** [`c259869259.lua`](<../public/CCG Downloads/CCG_Scripts/c259869259.lua>)
- **Problem/question to solve:** Moved the once-per-turn limit to card activation; the continuous control effect is no longer falsely limited. EVENT_ADJUST co-link tracking and forced zone-control movement are custom mechanics.
- **Current audited implementation:** Moved the once-per-turn limit to card activation; the continuous control effect is no longer falsely limited. EVENT_ADJUST co-link tracking and forced zone-control movement are custom mechanics. The file compiles and initializes; the open item is behavioral or interpretive, not a known load failure.
- **Manual review checklist:**
  1. Build the smallest, branching, and cyclic co-link layouts and verify traversal visits each legal monster exactly once.
  2. Repeat with every Main Monster Zone occupied, a destination becoming occupied mid-chain, and counters removed before resolution.
  3. Confirm counter removal occurs in the printed cost window and that movement/protection updates immediately when links or control change.
  4. Include a full-zone case and a case where paying the cost opens a zone; the UI must not reject a legal post-cost state or promise an impossible summon.
  5. Attempt the effect/procedure twice and after a negated activation to confirm the intended card, effect, or oath count limit.
- **Acceptance condition:** Record the authoritative interpretation and an Omega replay/log showing the positive case, the closest illegal case, and any listed interruption case. The observed result must match the exact source sequence and leave no broader/narrower legal pool than intended.

<details>
<summary>Exact current source text</summary>

If your monster becomes co-linked, place 1 Current Counter on it. If your opponent activates a Spell Card or effect, and you control an "Ohmechanic" monster: You can target 1 monster your opponents controls; place that target in your zone your co-linked monster points to, and take control of it. You can only activate 1 "Ohmen Surge" per turn

</details>

### 31. Siemens, the Ohmechanic Conductor - 259405917

- **Source ordinal:** 300. **Script:** [`c259405917.lua`](<../public/CCG Downloads/CCG_Scripts/c259405917.lua>)
- **Problem/question to solve:** Prevented the move effect from activating without a free Main Monster Zone. Custom co-link destination movement remains an in-engine UI/ruling risk.
- **Current audited implementation:** Prevented the move effect from activating without a free Main Monster Zone. Custom co-link destination movement remains an in-engine UI/ruling risk. The file compiles and initializes; the open item is behavioral or interpretive, not a known load failure.
- **Manual review checklist:**
  1. Build the smallest, branching, and cyclic co-link layouts and verify traversal visits each legal monster exactly once.
  2. Repeat with every Main Monster Zone occupied, a destination becoming occupied mid-chain, and counters removed before resolution.
  3. Confirm counter removal occurs in the printed cost window and that movement/protection updates immediately when links or control change.
  4. Run the relevant GY branch both with and without Necrovalley, including activation legality and a Necrovalley effect appearing before resolution.
  5. Include a full-zone case and a case where paying the cost opens a zone; the UI must not reject a legal post-cost state or promise an impossible summon.
- **Acceptance condition:** Record the authoritative interpretation and an Omega replay/log showing the positive case, the closest illegal case, and any listed interruption case. The observed result must match the exact source sequence and leave no broader/narrower legal pool than intended.

<details>
<summary>Exact current source text</summary>

"Ohmen" monsters
This card's ATK become 0 while it has no Current Counters on it. This card gains effects based on the number of Current Counters on it.
1+: During your Main Phase: You can Special Summon 1 "Ohmen" monster from your GY.
2+: (Quick Effect): Move 1 monster on the controller's field that your co-linked monster points to.
3+: (Quick Effect): You can remove all Current Counters from this card, then target 1 monster your opponents controls; place that target in your Main Monster Zone your co-linked monster points to.
You can only use each effect of "Siemens, the Ohmechanic Conductor" once per turn.

</details>

### 32. Farad, the Ohmechanic Capacitor - 259350270

- **Source ordinal:** 301. **Script:** [`c259350270.lua`](<../public/CCG Downloads/CCG_Scripts/c259350270.lua>)
- **Problem/question to solve:** Custom Current Counter traversal/removal across mutually linked cards needs engine validation.
- **Current audited implementation:** Custom Current Counter traversal/removal across mutually linked cards needs engine validation. The file compiles and initializes; the open item is behavioral or interpretive, not a known load failure.
- **Manual review checklist:**
  1. Build the smallest, branching, and cyclic co-link layouts and verify traversal visits each legal monster exactly once.
  2. Repeat with every Main Monster Zone occupied, a destination becoming occupied mid-chain, and counters removed before resolution.
  3. Confirm counter removal occurs in the printed cost window and that movement/protection updates immediately when links or control change.
  4. Run the relevant GY branch both with and without Necrovalley, including activation legality and a Necrovalley effect appearing before resolution.
  5. Include face-up and face-down banished cards and confirm hidden cards are never selected unless the text explicitly permits them.
- **Acceptance condition:** Record the authoritative interpretation and an Omega replay/log showing the positive case, the closest illegal case, and any listed interruption case. The observed result must match the exact source sequence and leave no broader/narrower legal pool than intended.

<details>
<summary>Exact current source text</summary>

2 monsters including a Thunder monster
This card's ATK become 0 while it has no Current Counters on it. This card gains effects based on the number of Current Counters on it.
1+: During the Main Phase: You can target 1 card your opponents control; banish it.
2+: During the Main Phase: You can target 1 "Ohmen" card in your GY or banishment; add it to your hand.
3+: (Quick effect): remove all Current Counters on this card and Link Monsters co-linked to it; banish up to 3 cards in your opponent GY.
You can only use each effect of "Farad, the Ohmechanic Capacitor" once per turn.

</details>

### 33. Coulomb, the Ohmechanic Charger - 259841490

- **Source ordinal:** 303. **Script:** [`c259841490.lua`](<../public/CCG Downloads/CCG_Scripts/c259841490.lua>)
- **Problem/question to solve:** Prevented the Link-monster move effect from activating without a free Main Monster Zone. Immediate Link Summon and custom zone movement need live Extra Monster Zone validation.
- **Current audited implementation:** Prevented the Link-monster move effect from activating without a free Main Monster Zone. Immediate Link Summon and custom zone movement need live Extra Monster Zone validation. The file compiles and initializes; the open item is behavioral or interpretive, not a known load failure.
- **Manual review checklist:**
  1. Build the smallest, branching, and cyclic co-link layouts and verify traversal visits each legal monster exactly once.
  2. Repeat with every Main Monster Zone occupied, a destination becoming occupied mid-chain, and counters removed before resolution.
  3. Confirm counter removal occurs in the printed cost window and that movement/protection updates immediately when links or control change.
  4. Include a full-zone case and a case where paying the cost opens a zone; the UI must not reject a legal post-cost state or promise an impossible summon.
  5. Attempt the effect/procedure twice and after a negated activation to confirm the intended card, effect, or oath count limit.
- **Acceptance condition:** Record the authoritative interpretation and an Omega replay/log showing the positive case, the closest illegal case, and any listed interruption case. The observed result must match the exact source sequence and leave no broader/narrower legal pool than intended.

<details>
<summary>Exact current source text</summary>

2 Thunder monsters including an "Ohmen" monster
This card ATK become 0 while it has no Current Counters on it. This card gains effects based on the number of Current Counters on it.
1+: You can move 1 Link monster you controls to another of your Main Monster zones, then place 1 Current Counter on it.
2+: During your Main Phase: you can add 1 "Ohmen" Spell/Trap card from your Deck yo your hand.
3+: During the Main Phase (Quick Effect): You can remove all Current Counters from this card; immediately after this effect resolves, Link Summon 1 "Ohmen" monster from your Extra Deck using monsters you control as material.
You can only use each effect of "Coulomb, the Ohmechanic Charger" once per turn.

</details>

### 34. Ampere, the Ohmechanic Intensity - 259479044

- **Source ordinal:** 304. **Script:** [`c259479044.lua`](<../public/CCG Downloads/CCG_Scripts/c259479044.lua>)
- **Problem/question to solve:** Custom counter placement/protection over co-linked monsters needs live validation.
- **Current audited implementation:** Custom counter placement/protection over co-linked monsters needs live validation. The file compiles and initializes; the open item is behavioral or interpretive, not a known load failure.
- **Manual review checklist:**
  1. Build the smallest, branching, and cyclic co-link layouts and verify traversal visits each legal monster exactly once.
  2. Repeat with every Main Monster Zone occupied, a destination becoming occupied mid-chain, and counters removed before resolution.
  3. Confirm counter removal occurs in the printed cost window and that movement/protection updates immediately when links or control change.
  4. Attempt the effect/procedure twice and after a negated activation to confirm the intended card, effect, or oath count limit.
- **Acceptance condition:** Record the authoritative interpretation and an Omega replay/log showing the positive case, the closest illegal case, and any listed interruption case. The observed result must match the exact source sequence and leave no broader/narrower legal pool than intended.

<details>
<summary>Exact current source text</summary>

2 Thunder monsters including an "Ohmen" monster
This card's ATK become 0 while it has no Current Counters on it. This card gains the following effects based on the number of Current Counters on it:
1+: During your Main Phase: You can add 1 "Ohmen" monster from your Deck to your hand, then discard 1 card.
2+: Place 1 Current Counter on each monster this card is co-linked to.
3+: "Ohmechanic" monsters co-linked to this card cannot be destroyed by battle or card effects.
You can only use each effect of "Ampere, the Ohmechanic Intensity" once per turn.

</details>

### 35. Carcel, the Ohmechanic Light - 259033429

- **Source ordinal:** 305. **Script:** [`c259033429.lua`](<../public/CCG Downloads/CCG_Scripts/c259033429.lua>)
- **Problem/question to solve:** Moved mass Current Counter removal out of target and into cost. EVENT_ADJUST co-link transition tracking and mass counter consumption need live validation.
- **Current audited implementation:** Moved mass Current Counter removal out of target and into cost. EVENT_ADJUST co-link transition tracking and mass counter consumption need live validation. The file compiles and initializes; the open item is behavioral or interpretive, not a known load failure.
- **Manual review checklist:**
  1. Build the smallest, branching, and cyclic co-link layouts and verify traversal visits each legal monster exactly once.
  2. Repeat with every Main Monster Zone occupied, a destination becoming occupied mid-chain, and counters removed before resolution.
  3. Confirm counter removal occurs in the printed cost window and that movement/protection updates immediately when links or control change.
  4. Run the relevant GY branch both with and without Necrovalley, including activation legality and a Necrovalley effect appearing before resolution.
  5. Include a full-zone case and a case where paying the cost opens a zone; the UI must not reject a legal post-cost state or promise an impossible summon.
- **Acceptance condition:** Record the authoritative interpretation and an Omega replay/log showing the positive case, the closest illegal case, and any listed interruption case. The observed result must match the exact source sequence and leave no broader/narrower legal pool than intended.

<details>
<summary>Exact current source text</summary>

3+ monsters including an "Ohmechanic" monster
If this card is Link Summoned, You can Special Summon 1 "Ohmen" monster from your GY. This card's ATK is doubled while it has a Current Counter on it. If this card becomes co-linked, place Current Counters equal to the combined Link Ratings of all monsters co-linked to this card on this card, and all monsters you control that are co-linked to this card. When your opponent activates a card or effect (Quick Effect): You can remove all Current Counters on your field (min 5); destroy all monsters your opponent controls. You can only use each effect of "Carcel, the Ohmechanic Light" once per turn.

</details>

### 36. Ohmen Beacon - 259650969

- **Source ordinal:** 307. **Script:** [`c259650969.lua`](<../public/CCG Downloads/CCG_Scripts/c259650969.lua>)
- **Problem/question to solve:** Prevented the move effect from activating without a free Main Monster Zone. Continuous co-link protection and movement/counter placement need live validation.
- **Current audited implementation:** Prevented the move effect from activating without a free Main Monster Zone. Continuous co-link protection and movement/counter placement need live validation. The file compiles and initializes; the open item is behavioral or interpretive, not a known load failure.
- **Manual review checklist:**
  1. Build the smallest, branching, and cyclic co-link layouts and verify traversal visits each legal monster exactly once.
  2. Repeat with every Main Monster Zone occupied, a destination becoming occupied mid-chain, and counters removed before resolution.
  3. Confirm counter removal occurs in the printed cost window and that movement/protection updates immediately when links or control change.
  4. Run the relevant GY branch both with and without Necrovalley, including activation legality and a Necrovalley effect appearing before resolution.
  5. Include a full-zone case and a case where paying the cost opens a zone; the UI must not reject a legal post-cost state or promise an impossible summon.
- **Acceptance condition:** Record the authoritative interpretation and an Omega replay/log showing the positive case, the closest illegal case, and any listed interruption case. The observed result must match the exact source sequence and leave no broader/narrower legal pool than intended.

<details>
<summary>Exact current source text</summary>

When this card is activated: You can Special Summon 1 Thunder monster from your hand, or, if you control an "Ohmechanic" monster, you can Special Summon 1 "Ohmen" monster from your GY instead. Co-linked monsters you controls with a Current Counter cannot be targeted by your opponent card effect. Once per turn: You can move 1 monster you control to another Main Monster zone, then place 1 Current Counter on all co-linked monsters you control. You can only activate 1 "Ohmen Beacon" per turn.

</details>

## Source wording and authoritative rulings

### 37. To Proto Chrono - 244013196

- **Source ordinal:** 135. **Script:** [`c244013196.lua`](<../public/CCG Downloads/CCG_Scripts/c244013196.lua>)
- **Problem/question to solve:** summon restriction and procedure; source text is truncated.
- **Current audited implementation:** summon restriction and procedure; source text is truncated. The file compiles and initializes; the open item is behavioral or interpretive, not a known load failure.
- **Manual review checklist:**
  1. Obtain a definitive wording/ruling for the ambiguous clause before treating the current interpretation as final.
  2. Write down the intended activation condition, legal card pool, sequence conjunction, and duration in PSCT-like terms.
  3. After that decision, compare the script literally against the clarified text and test both the accepted interpretation and the closest rejected interpretation.
  4. Include face-up and face-down banished cards and confirm hidden cards are never selected unless the text explicitly permits them.
  5. Include a full-zone case and a case where paying the cost opens a zone; the UI must not reject a legal post-cost state or promise an impossible summon.
- **Acceptance condition:** Record the authoritative interpretation and an Omega replay/log showing the positive case, the closest illegal case, and any listed interruption case. The observed result must match the exact source sequence and leave no broader/narrower legal pool than intended.

<details>
<summary>Exact current source text</summary>

Cannot be Normal Summoned/Set. Must first be Special Summoned (from your hand) by banishing 1 "To Proto" monster you control. During

</details>

### 38. Extinction of Dysmandr - 242009896

- **Source ordinal:** 164. **Script:** [`c242009896.lua`](<../public/CCG Downloads/CCG_Scripts/c242009896.lua>)
- **Problem/question to solve:** 12 source typo.
- **Current audited implementation:** named Token cost; matching mass destruction; then continuation requires successful first destruction [fixed]. The file compiles and initializes; the open item is behavioral or interpretive, not a known load failure.
- **Manual review checklist:**
  1. Obtain a definitive wording/ruling for the ambiguous clause before treating the current interpretation as final.
  2. Write down the intended activation condition, legal card pool, sequence conjunction, and duration in PSCT-like terms.
  3. After that decision, compare the script literally against the clarified text and test both the accepted interpretation and the closest rejected interpretation.
  4. Attempt the effect/procedure twice and after a negated activation to confirm the intended card, effect, or oath count limit.
- **Acceptance condition:** Record the authoritative interpretation and an Omega replay/log showing the positive case, the closest illegal case, and any listed interruption case. The observed result must match the exact source sequence and leave no broader/narrower legal pool than intended.

<details>
<summary>Exact current source text</summary>

If you control "Dysmandr, the Depraevity of Worlds": You can Tribute 1 "Protogenic Essence Token", then choose 1 Effect Monster on the field; destroy all other Effect Monsters on the field with at least 1 of the same Type, Attribute, Level, ATK or DEF, except "Dysmandr, the Depraevity of Worlds", then destroy that monster. You can only use this effect of "Extinction of Dysmandr" once per turn.

</details>

### 39. Eldora in Depraevity - 229786055

- **Source ordinal:** 166. **Script:** [`c229786055.lua`](<../public/CCG Downloads/CCG_Scripts/c229786055.lua>)
- **Problem/question to solve:** source text/name inconsistency.
- **Current audited implementation:** copied Extinction branch; then continuation success gate [fixed]. The file compiles and initializes; the open item is behavioral or interpretive, not a known load failure.
- **Manual review checklist:**
  1. Obtain a definitive wording/ruling for the ambiguous clause before treating the current interpretation as final.
  2. Write down the intended activation condition, legal card pool, sequence conjunction, and duration in PSCT-like terms.
  3. After that decision, compare the script literally against the clarified text and test both the accepted interpretation and the closest rejected interpretation.
  4. Attempt the effect/procedure twice and after a negated activation to confirm the intended card, effect, or oath count limit.
- **Acceptance condition:** Record the authoritative interpretation and an Omega replay/log showing the positive case, the closest illegal case, and any listed interruption case. The observed result must match the exact source sequence and leave no broader/narrower legal pool than intended.

<details>
<summary>Exact current source text</summary>

If you control "Dysmandr, the Depraevity of Worlds": You can Tribute 1 "Protogenic Essence Token", then choose 1 Effect Monster on the field; destroy all other Effect Monsters on the field with at least 12 of the same Type, Attribute, Level, ATK or DEF, except "Dysmandr, the Depraevity of Worlds", then destroy that monster. You can only use this effect of "Extinction of Dysmandr" once per turn.

</details>

### 40. Recollection: Kaboom Papa - 241447408

- **Source ordinal:** 194. **Script:** [`c241447408.lua`](<../public/CCG Downloads/CCG_Scripts/c241447408.lua>)
- **Problem/question to solve:** "Only conduct 1 Summon this turn" needs a ruling on activation after prior summons and whether summon events or monsters are counted.
- **Current audited implementation:** "Only conduct 1 Summon this turn" needs a ruling on activation after prior summons and whether summon events or monsters are counted. The file compiles and initializes; the open item is behavioral or interpretive, not a known load failure.
- **Manual review checklist:**
  1. Obtain a definitive wording/ruling for the ambiguous clause before treating the current interpretation as final.
  2. Write down the intended activation condition, legal card pool, sequence conjunction, and duration in PSCT-like terms.
  3. After that decision, compare the script literally against the clarified text and test both the accepted interpretation and the closest rejected interpretation.
  4. Include a full-zone case and a case where paying the cost opens a zone; the UI must not reject a legal post-cost state or promise an impossible summon.
- **Acceptance condition:** Record the authoritative interpretation and an Omega replay/log showing the positive case, the closest illegal case, and any listed interruption case. The observed result must match the exact source sequence and leave no broader/narrower legal pool than intended.

<details>
<summary>Exact current source text</summary>

Destroy 1 "Mine" Field Spell and 1 "Pedicae's Papa" you control, and if you do, destroy all cards on the field. You can only conduct 1 Summon this turn. You can only activate 1 "Recollection: Kaboom Papa" per turn.

</details>

### 41. Pot of Gambling - 224774049

- **Source ordinal:** 242. **Script:** [`c224774049.lua`](<../public/CCG Downloads/CCG_Scripts/c224774049.lua>)
- **Problem/question to solve:** Printed text does not unambiguously state the default disposition/order for excavated cards; implementation choice requires a ruling.
- **Current audited implementation:** Printed text does not unambiguously state the default disposition/order for excavated cards; implementation choice requires a ruling. The file compiles and initializes; the open item is behavioral or interpretive, not a known load failure.
- **Manual review checklist:**
  1. Obtain a definitive wording/ruling for the ambiguous clause before treating the current interpretation as final.
  2. Write down the intended activation condition, legal card pool, sequence conjunction, and duration in PSCT-like terms.
  3. After that decision, compare the script literally against the clarified text and test both the accepted interpretation and the closest rejected interpretation.
  4. Use distinguishable cards to verify exact top/bottom ordering and what happens to every card not added or summoned.
- **Acceptance condition:** Record the authoritative interpretation and an Omega replay/log showing the positive case, the closest illegal case, and any listed interruption case. The observed result must match the exact source sequence and leave no broader/narrower legal pool than intended.

<details>
<summary>Exact current source text</summary>

Declare 1 card name; roll a six-sided die, then excavate cards from the top of your deck equal to the result, then add 1 excavated card with the declared name to your hand. If you did not add any card by this effect, you lose 2000 LP.

</details>

### 42. Chrono-Saur Laplace Plesio - 251236672

- **Source ordinal:** 268. **Script:** [`c251236672.lua`](<../public/CCG Downloads/CCG_Scripts/c251236672.lua>)
- **Problem/question to solve:** Fixed ATK/DEF reset to the next own Battle Phase and limited post-battle selection to destructible own cards; shared "previous effects once per turn" wording remains ruling-sensitive.
- **Current audited implementation:** Fixed ATK/DEF reset to the next own Battle Phase and limited post-battle selection to destructible own cards; shared "previous effects once per turn" wording remains ruling-sensitive. The file compiles and initializes; the open item is behavioral or interpretive, not a known load failure.
- **Manual review checklist:**
  1. Obtain a definitive wording/ruling for the ambiguous clause before treating the current interpretation as final.
  2. Write down the intended activation condition, legal card pool, sequence conjunction, and duration in PSCT-like terms.
  3. After that decision, compare the script literally against the clarified text and test both the accepted interpretation and the closest rejected interpretation.
  4. Include a full-zone case and a case where paying the cost opens a zone; the UI must not reject a legal post-cost state or promise an impossible summon.
  5. Attempt the effect/procedure twice and after a negated activation to confirm the intended card, effect, or oath count limit.
- **Acceptance condition:** Record the authoritative interpretation and an Omega replay/log showing the positive case, the closest illegal case, and any listed interruption case. The observed result must match the exact source sequence and leave no broader/narrower legal pool than intended.

<details>
<summary>Exact current source text</summary>

When this card is activated: You can add 1 "Chrono-Saur" card from your Deck to your hand. For the rest of this turn, you cannot Special Summon monsters, except Dinosaur monsters. If your card is destroyed by battle or card effect: You can make your monsters gain 500 ATK/DEF until the end of your Battle Phase. You can only use the previous effects of "Chrono-Saur Laplace Plesio" once per turn. After damage calculation, if your Dinosaur monster battled an opponent's monster: You can destroy 1 card you control.

</details>

### 43. Devotee of Fire - 236721134

- **Source ordinal:** 318. **Script:** [`c236721134.lua`](<../public/CCG Downloads/CCG_Scripts/c236721134.lua>)
- **Problem/question to solve:** Source text gives the Set effect no activation condition; current on-summon interpretation needs a ruling.
- **Current audited implementation:** Source text gives the Set effect no activation condition; current on-summon interpretation needs a ruling. The file compiles and initializes; the open item is behavioral or interpretive, not a known load failure.
- **Manual review checklist:**
  1. Obtain a definitive wording/ruling for the ambiguous clause before treating the current interpretation as final.
  2. Write down the intended activation condition, legal card pool, sequence conjunction, and duration in PSCT-like terms.
  3. After that decision, compare the script literally against the clarified text and test both the accepted interpretation and the closest rejected interpretation.
  4. Run the relevant GY branch both with and without Necrovalley, including activation legality and a Necrovalley effect appearing before resolution.
  5. Include a full-zone case and a case where paying the cost opens a zone; the UI must not reject a legal post-cost state or promise an impossible summon.
- **Acceptance condition:** Record the authoritative interpretation and an Omega replay/log showing the positive case, the closest illegal case, and any listed interruption case. The observed result must match the exact source sequence and leave no broader/narrower legal pool than intended.

<details>
<summary>Exact current source text</summary>

If you control a FIRE Dragon monster, you can Special Summon this card (from your GY). You can only Special Summon "Devotee of Fire" once per turn this way. You can only use each of the following effects of "Devotee of Fire" once per turn. If this card is Normal or Special Summoned: You can send 1 Dragon monster from your Extra Deck to the GY. Set 1 Spell/Trap that lists "Phlogiston Dragon" in its text directly from your Deck or GY. When your opponent activates a Spell/Trap Card or effect, while you control a "Phlogiston Dragon" (Quick Effect): You can Tribute this card; negate that activation.

</details>

### 44. Urphiel's Feather Downpour - 235612490

- **Source ordinal:** 345. **Script:** [`c235612490.lua`](<../public/CCG Downloads/CCG_Scripts/c235612490.lua>)
- **Problem/question to solve:** Added activation-time Necrovalley legality to the discarded self-Set trigger. The second field banish wording and discard-to-Set timing remain ruling-sensitive.
- **Current audited implementation:** Added activation-time Necrovalley legality to the discarded self-Set trigger. The second field banish wording and discard-to-Set timing remain ruling-sensitive. The file compiles and initializes; the open item is behavioral or interpretive, not a known load failure.
- **Manual review checklist:**
  1. Obtain a definitive wording/ruling for the ambiguous clause before treating the current interpretation as final.
  2. Write down the intended activation condition, legal card pool, sequence conjunction, and duration in PSCT-like terms.
  3. After that decision, compare the script literally against the clarified text and test both the accepted interpretation and the closest rejected interpretation.
  4. Run the relevant GY branch both with and without Necrovalley, including activation legality and a Necrovalley effect appearing before resolution.
  5. Include face-up and face-down banished cards and confirm hidden cards are never selected unless the text explicitly permits them.
- **Acceptance condition:** Record the authoritative interpretation and an Omega replay/log showing the positive case, the closest illegal case, and any listed interruption case. The observed result must match the exact source sequence and leave no broader/narrower legal pool than intended.

<details>
<summary>Exact current source text</summary>

(This card is always treated as an "Arckcestial" card.) Banish 1 "Arckcestial" card from your GY; banish 1 card on the field, then if you control "Urphiel, The High Arckcestial", you can banish an additional card on the field. If this card is discarded to the GY: You can Set this card. You can only use each effect of "Urphiel's Feather Downpour" once per turn.

</details>

### 45. Scarstech Prologue - 224467692

- **Source ordinal:** 411. **Script:** [`c224467692.lua`](<../public/CCG Downloads/CCG_Scripts/c224467692.lua>)
- **Problem/question to solve:** Effect metadata conflicts with flavor-only text.
- **Current audited implementation:** Effect metadata conflicts with flavor-only text. The file compiles and initializes; the open item is behavioral or interpretive, not a known load failure.
- **Manual review checklist:**
  1. Obtain a definitive wording/ruling for the ambiguous clause before treating the current interpretation as final.
  2. Write down the intended activation condition, legal card pool, sequence conjunction, and duration in PSCT-like terms.
  3. After that decision, compare the script literally against the clarified text and test both the accepted interpretation and the closest rejected interpretation.
- **Acceptance condition:** Record the authoritative interpretation and an Omega replay/log showing the positive case, the closest illegal case, and any listed interruption case. The observed result must match the exact source sequence and leave no broader/narrower legal pool than intended.

<details>
<summary>Exact current source text</summary>

There is nothing left. We are powerless. Their numbers stretch beyond sight, and their technology an incomprehensible nightmare surpasses everything we've ever known. With each passing moment, their core pulses with more energy, feeding them, making them stronger, while we wither. Our soldiers, broken and desperate, fight only to delay the inevitable, giving what little time they can to the terrified masses scrambling to hide. But even that is futile. The ships monstrous, unholy abominations are closing in. When they arrive, there will be no resistance, no salvation. This world, everything we loved, will be torn apart and consumed by these soulless machines. The Scarstech will inherit what remains, and all that was once ours will be ash in their wake.

</details>

## Damage and stat-layer behavior

### 46. To Proto Taxis - 246380598

- **Source ordinal:** 136. **Script:** [`c246380598.lua`](<../public/CCG Downloads/CCG_Scripts/c246380598.lua>)
- **Problem/question to solve:** damage layering.
- **Current audited implementation:** procedure/aura/reflected half damage; named Token cost [fixed]; true banishment target [fixed]. The file compiles and initializes; the open item is behavioral or interpretive, not a known load failure.
- **Manual review checklist:**
  1. Test the effect alone, with existing ATK/DEF modifiers, and while damage is prevented, reflected, doubled, or reduced by another effect.
  2. Verify ordering, rounding, reverse updates, reset timing, and behavior when the affected card becomes face-down or leaves the field.
  3. Confirm that any follow-up only occurs when the printed damage/stat change actually succeeds.
  4. Include face-up and face-down banished cards and confirm hidden cards are never selected unless the text explicitly permits them.
  5. Include a full-zone case and a case where paying the cost opens a zone; the UI must not reject a legal post-cost state or promise an impossible summon.
- **Acceptance condition:** Record the authoritative interpretation and an Omega replay/log showing the positive case, the closest illegal case, and any listed interruption case. The observed result must match the exact source sequence and leave no broader/narrower legal pool than intended.

<details>
<summary>Exact current source text</summary>

Cannot be Normal Summoned/Set. Must first be Special Summoned (from your hand) by banishing 1 "To Proto" monster you control. Negate the effects of monsters on the field whose ATK/DEF is greater than double its original ATK/DEF, also your opponent takes half the battle damage you would have taken from battles involving this card. (Quick Effect): You can Tribute 1 "Protogenic Essence Token"; make 1 monster gain ATK/DEF equal to its ATK/DEF. If this card is banished from the field: You can target 1 of your banished "To Proto" monsters with a different name; add it to your hand. You can only use each effect of "To Proto Taxis" once per turn.

</details>

### 47. To Proto Psychi - 217332244

- **Source ordinal:** 139. **Script:** [`c217332244.lua`](<../public/CCG Downloads/CCG_Scripts/c217332244.lua>)
- **Problem/question to solve:** 100-LP increment UI.
- **Current audited implementation:** procedure/recovery/stat gain; named Token cost [fixed]; true banishment target [fixed]. The file compiles and initializes; the open item is behavioral or interpretive, not a known load failure.
- **Manual review checklist:**
  1. Test the effect alone, with existing ATK/DEF modifiers, and while damage is prevented, reflected, doubled, or reduced by another effect.
  2. Verify ordering, rounding, reverse updates, reset timing, and behavior when the affected card becomes face-down or leaves the field.
  3. Confirm that any follow-up only occurs when the printed damage/stat change actually succeeds.
  4. Include face-up and face-down banished cards and confirm hidden cards are never selected unless the text explicitly permits them.
  5. Include a full-zone case and a case where paying the cost opens a zone; the UI must not reject a legal post-cost state or promise an impossible summon.
- **Acceptance condition:** Record the authoritative interpretation and an Omega replay/log showing the positive case, the closest illegal case, and any listed interruption case. The observed result must match the exact source sequence and leave no broader/narrower legal pool than intended.

<details>
<summary>Exact current source text</summary>

Cannot be Normal Summoned/Set. Must first be Special Summoned (from your hand) by banishing 1 "To Proto" monster you control. If this card inflicts battle damage, you gain LP equal to the damage inflicted. (Quick Effect): You can Tribute 1 "Protogenic Essence Token", then pay any amount of LP; this card gains ATK and DEF equal to the LP paid. If this card is banished from the field: You can target 1 of your banished "To Proto" monsters with a different name; add it to your hand. You can only use each effect of the "To Proto Psychi" once per turn.

</details>

### 48. Phantasm Spiral Resurgence - 219047593

- **Source ordinal:** 172. **Script:** [`c219047593.lua`](<../public/CCG Downloads/CCG_Scripts/c219047593.lua>)
- **Problem/question to solve:** phase-only persistent negate live test.
- **Current audited implementation:** equip legality; halve stats; negation now persists on same card in GY [fixed]; battle-destroy GY add [implemented]. The file compiles and initializes; the open item is behavioral or interpretive, not a known load failure.
- **Manual review checklist:**
  1. Test the effect alone, with existing ATK/DEF modifiers, and while damage is prevented, reflected, doubled, or reduced by another effect.
  2. Verify ordering, rounding, reverse updates, reset timing, and behavior when the affected card becomes face-down or leaves the field.
  3. Confirm that any follow-up only occurs when the printed damage/stat change actually succeeds.
  4. Run the relevant GY branch both with and without Necrovalley, including activation legality and a Necrovalley effect appearing before resolution.
- **Acceptance condition:** Record the authoritative interpretation and an Omega replay/log showing the positive case, the closest illegal case, and any listed interruption case. The observed result must match the exact source sequence and leave no broader/narrower legal pool than intended.

<details>
<summary>Exact current source text</summary>

Equip only to a non-Effect monster. If the equipped monster battles your opponent's monster: Halve that monster's ATK and DEF, also, negate its effect until the end of this turn (including in the GY). When the equipped monster destroys an opponent's monster by battle: You can add 1 "Phantasm Spiral" card from your GY to your hand.

</details>

## Ownership and opponent-resource use

### 49. Abstain from Light - 232449539

- **Source ordinal:** 13. **Script:** [`c232449539.lua`](<../public/CCG Downloads/CCG_Scripts/c232449539.lua>)
- **Problem/question to solve:** opponent-Deck Fusion materials; shuffled-card tracker; delayed return [implemented].
- **Current audited implementation:** opponent-Deck Fusion materials; shuffled-card tracker; delayed return [implemented]. The file compiles and initializes; the open item is behavioral or interpretive, not a known load failure.
- **Manual review checklist:**
  1. Decide whether eligibility follows owner, controller, location, or the player whose Deck/GY/field contains the card.
  2. Test original-owner versus current-controller cases, cards changing control mid-chain, and cards becoming unaffected or leaving the required location.
  3. Confirm Omega presents only legal opponent resources and sends each selected card to the correct owner/location with the printed reason.
  4. Run the relevant GY branch both with and without Necrovalley, including activation legality and a Necrovalley effect appearing before resolution.
  5. Include face-up and face-down banished cards and confirm hidden cards are never selected unless the text explicitly permits them.
- **Acceptance condition:** Record the authoritative interpretation and an Omega replay/log showing the positive case, the closest illegal case, and any listed interruption case. The observed result must match the exact source sequence and leave no broader/narrower legal pool than intended.

<details>
<summary>Exact current source text</summary>

Fusion Summon 1 "Stain" Fusion Monster from your Extra Deck using "Stain" monsters from your hand or field as material, also, for the rest of this turn after this card resolves, you cannot activate "Abstain from Light", or Special Summon monsters from the Extra Deck, except "Stain" monsters. If your "Stain" monster was shuffled into either Deck this turn, you can also banish "Stain" monsters from face-up in your opponent's Deck as material, but return them to the GY during the End Phase.

</details>

### 50. Shattering Sustained - 248453205

- **Source ordinal:** 14. **Script:** [`c248453205.lua`](<../public/CCG Downloads/CCG_Scripts/c248453205.lua>)
- **Problem/question to solve:** opponent-Deck pseudo-Tribute [manual]; full-zone Tribute legality [fixed]; post-cost target legality [fixed].
- **Current audited implementation:** opponent-Deck pseudo-Tribute [manual]; full-zone Tribute legality [fixed]; post-cost target legality [fixed]. The file compiles and initializes; the open item is behavioral or interpretive, not a known load failure.
- **Manual review checklist:**
  1. Decide whether eligibility follows owner, controller, location, or the player whose Deck/GY/field contains the card.
  2. Test original-owner versus current-controller cases, cards changing control mid-chain, and cards becoming unaffected or leaving the required location.
  3. Confirm Omega presents only legal opponent resources and sends each selected card to the correct owner/location with the printed reason.
  4. Run the relevant GY branch both with and without Necrovalley, including activation legality and a Necrovalley effect appearing before resolution.
  5. Include face-up and face-down banished cards and confirm hidden cards are never selected unless the text explicitly permits them.
- **Acceptance condition:** Record the authoritative interpretation and an Omega replay/log showing the positive case, the closest illegal case, and any listed interruption case. The observed result must match the exact source sequence and leave no broader/narrower legal pool than intended.

<details>
<summary>Exact current source text</summary>

Tribute 1 "Stain" monster from your hand, face-up field, or face-up in your opponent's Deck; Special Summon 1 Level 4 or lower "Stain" monster from your hand, Deck, or GY, but shuffle it face-up into your opponent's Deck when it leaves the field, then you can Tribute 1 face-up "Stain" monster in your opponent's Deck. During your End Phase, if this card is in your GY: You can banish 1 "Stain" monster from your GY; Set this card. You can only use each effect of "Shattering Sustained" once per turn.

</details>

### 51. Distained Druid Dragar - 247580036

- **Source ordinal:** 17. **Script:** [`c247580036.lua`](<../public/CCG Downloads/CCG_Scripts/c247580036.lua>)
- **Problem/question to solve:** opponent-Deck pseudo-Tribute [manual]; remaining Fusion effects [implemented].
- **Current audited implementation:** opponent-Deck pseudo-Tribute [manual]; remaining Fusion effects [implemented]. The file compiles and initializes; the open item is behavioral or interpretive, not a known load failure.
- **Manual review checklist:**
  1. Decide whether eligibility follows owner, controller, location, or the player whose Deck/GY/field contains the card.
  2. Test original-owner versus current-controller cases, cards changing control mid-chain, and cards becoming unaffected or leaving the required location.
  3. Confirm Omega presents only legal opponent resources and sends each selected card to the correct owner/location with the printed reason.
  4. Include a full-zone case and a case where paying the cost opens a zone; the UI must not reject a legal post-cost state or promise an impossible summon.
  5. Attempt the effect/procedure twice and after a negated activation to confirm the intended card, effect, or oath count limit.
- **Acceptance condition:** Record the authoritative interpretation and an Omega replay/log showing the positive case, the closest illegal case, and any listed interruption case. The observed result must match the exact source sequence and leave no broader/narrower legal pool than intended.

<details>
<summary>Exact current source text</summary>

1 "Stain" monster + 1 non-LIGHT "Stain" monster\nIf this card is Special Summoned, or if a non-LIGHT "Stain" monster(s) is Normal or Special Summoned to your field: You can Tribute 1 monster from your field or face-up in your opponent's Deck, then target 1 face-up monster your opponent controls; gain LP equal to that monster's ATK, also, change all other face-up monsters they control to face-down Defense Position. You can only use this effect of "Distained Druid Dragar" once per turn.

</details>

### 52. A Stainless Story - 245970073

- **Source ordinal:** 100. **Script:** [`c245970073.lua`](<../public/CCG Downloads/CCG_Scripts/c245970073.lua>)
- **Problem/question to solve:** copy pool.
- **Current audited implementation:** copy pool; opponent face-up Deck source restored [fixed]; copied Bria visibility [fixed]; mutual draw [implemented]. The file compiles and initializes; the open item is behavioral or interpretive, not a known load failure.
- **Manual review checklist:**
  1. Decide whether eligibility follows owner, controller, location, or the player whose Deck/GY/field contains the card.
  2. Test original-owner versus current-controller cases, cards changing control mid-chain, and cards becoming unaffected or leaving the required location.
  3. Confirm Omega presents only legal opponent resources and sends each selected card to the correct owner/location with the printed reason.
  4. Run the relevant GY branch both with and without Necrovalley, including activation legality and a Necrovalley effect appearing before resolution.
  5. Include face-up and face-down banished cards and confirm hidden cards are never selected unless the text explicitly permits them.
- **Acceptance condition:** Record the authoritative interpretation and an Omega replay/log showing the positive case, the closest illegal case, and any listed interruption case. The observed result must match the exact source sequence and leave no broader/narrower legal pool than intended.

<details>
<summary>Exact current source text</summary>

If your opponent controls more cards than you: Send 1 "Stain" monster from your Deck or face-up in your opponent's Deck to the GY; this effect becomes the sent monster's effect if it is Normal or Special Summoned. You can banish this card from your GY; each player draws 1 card. You can only activate 1 "A Stainless Story" per turn.

</details>

### 53. Muramasa - 247378501

- **Source ordinal:** 109. **Script:** [`c247378501.lua`](<../public/CCG Downloads/CCG_Scripts/c247378501.lua>)
- **Problem/question to solve:** alternate Tribute UI.
- **Current audited implementation:** opponent-monster Tribute Summon; add-or-equip; Spirit return [implemented]. The file compiles and initializes; the open item is behavioral or interpretive, not a known load failure.
- **Manual review checklist:**
  1. Decide whether eligibility follows owner, controller, location, or the player whose Deck/GY/field contains the card.
  2. Test original-owner versus current-controller cases, cards changing control mid-chain, and cards becoming unaffected or leaving the required location.
  3. Confirm Omega presents only legal opponent resources and sends each selected card to the correct owner/location with the printed reason.
  4. Include a full-zone case and a case where paying the cost opens a zone; the UI must not reject a legal post-cost state or promise an impossible summon.
  5. Attempt the effect/procedure twice and after a negated activation to confirm the intended card, effect, or oath count limit.
- **Acceptance condition:** Record the authoritative interpretation and an Omega replay/log showing the positive case, the closest illegal case, and any listed interruption case. The observed result must match the exact source sequence and leave no broader/narrower legal pool than intended.

<details>
<summary>Exact current source text</summary>

Cannot be Special Summoned. You can also Tribute 1 Special Summoned monster your opponent controls to Tribute Summon this card. If this card is Normal Summoned: You can add to your hand or equip to this card 1 Equip Spell from your Deck that can only be equipped to a Spirit monster. You can only use this effect of "Muramasa" once per turn. During the End Phase, if this card was Normal Summoned or flipped face-up this turn: Return this card to the hand.

</details>

### 54. Securitake Agent - 219543855

- **Source ordinal:** 197. **Script:** [`c219543855.lua`](<../public/CCG Downloads/CCG_Scripts/c219543855.lua>)
- **Problem/question to solve:** Script is internally consistent, but the intended scope of opponent-owned Link material (opponent monster you control versus opponent's field) needs a ruling.
- **Current audited implementation:** Script is internally consistent, but the intended scope of opponent-owned Link material (opponent monster you control versus opponent's field) needs a ruling. The file compiles and initializes; the open item is behavioral or interpretive, not a known load failure.
- **Manual review checklist:**
  1. Decide whether eligibility follows owner, controller, location, or the player whose Deck/GY/field contains the card.
  2. Test original-owner versus current-controller cases, cards changing control mid-chain, and cards becoming unaffected or leaving the required location.
  3. Confirm Omega presents only legal opponent resources and sends each selected card to the correct owner/location with the printed reason.
  4. Run the relevant GY branch both with and without Necrovalley, including activation legality and a Necrovalley effect appearing before resolution.
  5. Include a full-zone case and a case where paying the cost opens a zone; the UI must not reject a legal post-cost state or promise an impossible summon.
- **Acceptance condition:** Record the authoritative interpretation and an Omega replay/log showing the positive case, the closest illegal case, and any listed interruption case. The observed result must match the exact source sequence and leave no broader/narrower legal pool than intended.

<details>
<summary>Exact current source text</summary>

1 monster your opponent owns
You can only Link Summon "Securitake Agent" once per turn. If this card is Link Summoned: You can target 1 monster in your opponent's GY that was sent there this turn; Special Summon it to your field, but negate its effects.

</details>

### 55. Vampire Reptilian - 259552732

- **Source ordinal:** 408. **Script:** [`c259552732.lua`](<../public/CCG Downloads/CCG_Scripts/c259552732.lua>)
- **Problem/question to solve:** Opponent-monster Xyz material/control semantics.
- **Current audited implementation:** Opponent-monster Xyz material/control semantics. The file compiles and initializes; the open item is behavioral or interpretive, not a known load failure.
- **Manual review checklist:**
  1. Decide whether eligibility follows owner, controller, location, or the player whose Deck/GY/field contains the card.
  2. Test original-owner versus current-controller cases, cards changing control mid-chain, and cards becoming unaffected or leaving the required location.
  3. Confirm Omega presents only legal opponent resources and sends each selected card to the correct owner/location with the printed reason.
  4. Include a full-zone case and a case where paying the cost opens a zone; the UI must not reject a legal post-cost state or promise an impossible summon.
  5. Remove or make the target unaffected before resolution and confirm no dependent action is performed from a stale target.
- **Acceptance condition:** Record the authoritative interpretation and an Omega replay/log showing the positive case, the closest illegal case, and any listed interruption case. The observed result must match the exact source sequence and leave no broader/narrower legal pool than intended.

<details>
<summary>Exact current source text</summary>

If this card is in your hand (Quick Effect): You can target 1 monster your opponent controls and pay 500 LP; Special Summon this card, then if you control a "Vampire" Link and Xyz Monster, you can make this card and that monster Level 8, then, immediately after this effect resolves, Xyz Summon a "Vampire" monster using this card and that monster as material. You can only use this effect of "Vampire Reptilian" once per duel.

</details>

## Timing, delayed state, and reset behavior

### 56. Sacred Treasure - Bojin - 236542835

- **Source ordinal:** 59. **Script:** [`c236542835.lua`](<../public/CCG Downloads/CCG_Scripts/c236542835.lua>)
- **Problem/question to solve:** same-event interpretation.
- **Current audited implementation:** banish trigger and paired Treasure condition [implemented]. The file compiles and initializes; the open item is behavioral or interpretive, not a known load failure.
- **Manual review checklist:**
  1. Trigger the clause on Chain Link 1 and later chain links, then repeat when the relevant card leaves, changes control, or changes position before the delayed step.
  2. Test the exact phase/step boundary, missed-timing cases, turn changes, and simultaneous groups with more than one affected card.
  3. Verify labels/groups are cleared at the correct reset and that an "if you do" or "then" continuation occurs only after the required action succeeds.
  4. Include face-up and face-down banished cards and confirm hidden cards are never selected unless the text explicitly permits them.
  5. Include a full-zone case and a case where paying the cost opens a zone; the UI must not reject a legal post-cost state or promise an impossible summon.
- **Acceptance condition:** Record the authoritative interpretation and an Omega replay/log showing the positive case, the closest illegal case, and any listed interruption case. The observed result must match the exact source sequence and leave no broader/narrower legal pool than intended.

<details>
<summary>Exact current source text</summary>

If you control a "NiuHao" monster, apply 1 of these effects.\n Destroy 1 monster on the field.\n Special summon 1 "NiuHao" monster from your hand.\nIf this card and another "Sacred Treasure" card is banished: both players discard 1 card.\nYou can only activate 1 "Sacred Treasure - Bojin" per turn.

</details>

### 57. Sacred Treasure - Huangjin - 246421842

- **Source ordinal:** 61. **Script:** [`c246421842.lua`](<../public/CCG Downloads/CCG_Scripts/c246421842.lua>)
- **Problem/question to solve:** same-event interpretation.
- **Current audited implementation:** banish trigger and paired Treasure condition [implemented]. The file compiles and initializes; the open item is behavioral or interpretive, not a known load failure.
- **Manual review checklist:**
  1. Trigger the clause on Chain Link 1 and later chain links, then repeat when the relevant card leaves, changes control, or changes position before the delayed step.
  2. Test the exact phase/step boundary, missed-timing cases, turn changes, and simultaneous groups with more than one affected card.
  3. Verify labels/groups are cleared at the correct reset and that an "if you do" or "then" continuation occurs only after the required action succeeds.
  4. Run the relevant GY branch both with and without Necrovalley, including activation legality and a Necrovalley effect appearing before resolution.
  5. Include face-up and face-down banished cards and confirm hidden cards are never selected unless the text explicitly permits them.
- **Acceptance condition:** Record the authoritative interpretation and an Omega replay/log showing the positive case, the closest illegal case, and any listed interruption case. The observed result must match the exact source sequence and leave no broader/narrower legal pool than intended.

<details>
<summary>Exact current source text</summary>

If you control a "NiuHao" monster, apply 1 of these effects.\n Destroy 1 Spell/Trap on the field.\n Banish 1 card from either players GY.\nIf this card and another "Sacred Treasure" card is banished: Draw 1 card. You can only activate 1 "Sacred Treasure Huangjin" per turn.

</details>

### 58. Tove, the Domesticated - 259737127

- **Source ordinal:** 70. **Script:** [`c259737127.lua`](<../public/CCG Downloads/CCG_Scripts/c259737127.lua>)
- **Problem/question to solve:** summon restriction/draw-send/GY delayed Battle Phase return [implemented].
- **Current audited implementation:** summon restriction/draw-send/GY delayed Battle Phase return [implemented]. The file compiles and initializes; the open item is behavioral or interpretive, not a known load failure.
- **Manual review checklist:**
  1. Trigger the clause on Chain Link 1 and later chain links, then repeat when the relevant card leaves, changes control, or changes position before the delayed step.
  2. Test the exact phase/step boundary, missed-timing cases, turn changes, and simultaneous groups with more than one affected card.
  3. Verify labels/groups are cleared at the correct reset and that an "if you do" or "then" continuation occurs only after the required action succeeds.
  4. Run the relevant GY branch both with and without Necrovalley, including activation legality and a Necrovalley effect appearing before resolution.
  5. Include a full-zone case and a case where paying the cost opens a zone; the UI must not reject a legal post-cost state or promise an impossible summon.
- **Acceptance condition:** Record the authoritative interpretation and an Omega replay/log showing the positive case, the closest illegal case, and any listed interruption case. The observed result must match the exact source sequence and leave no broader/narrower legal pool than intended.

<details>
<summary>Exact current source text</summary>

This card cannot be Summoned while you control a Monster. If this card is sent from the hand to the GY: You can draw 1 card, then send up to 2 cards from your hand to the GY. During the Battle Phase (Quick Effect): You can shuffle this card from your GY into the Deck, then send 1 Level 1 Beast or Winged Beast Monster from your Deck to the GY but shuffle it into the Deck at the end of that Battle Phase. You can only use each effect of "Tove, the Domesticated" once per turn.

</details>

### 59. Mylo, the Domesticated - 259686203

- **Source ordinal:** 101. **Script:** [`c259686203.lua`](<../public/CCG Downloads/CCG_Scripts/c259686203.lua>)
- **Problem/question to solve:** summon restriction UI.
- **Current audited implementation:** summon restriction/search; Battle Phase GY shuffle and Fairy immunity [implemented]. The file compiles and initializes; the open item is behavioral or interpretive, not a known load failure.
- **Manual review checklist:**
  1. Trigger the clause on Chain Link 1 and later chain links, then repeat when the relevant card leaves, changes control, or changes position before the delayed step.
  2. Test the exact phase/step boundary, missed-timing cases, turn changes, and simultaneous groups with more than one affected card.
  3. Verify labels/groups are cleared at the correct reset and that an "if you do" or "then" continuation occurs only after the required action succeeds.
  4. Run the relevant GY branch both with and without Necrovalley, including activation legality and a Necrovalley effect appearing before resolution.
  5. Include a full-zone case and a case where paying the cost opens a zone; the UI must not reject a legal post-cost state or promise an impossible summon.
- **Acceptance condition:** Record the authoritative interpretation and an Omega replay/log showing the positive case, the closest illegal case, and any listed interruption case. The observed result must match the exact source sequence and leave no broader/narrower legal pool than intended.

<details>
<summary>Exact current source text</summary>

This card cannot be Summoned while you control a monster. If this card is Normal Summoned: You can add 1 "Domestica" Fairy Monster from your Deck to your hand. During the Battle Phase, if you control a Fairy Monster or you control no monsters (Quick Effect): You can shuffle this card from your GY into the Deck, and if you do, Fairy Monsters you control are unaffected by your opponent's card effects until the end of this Battle Phase. You can only use each effect of "Mylo, the Domesticated" once per turn.

</details>

### 60. Nuwa, the Domesticated - 259135917

- **Source ordinal:** 102. **Script:** [`c259135917.lua`](<../public/CCG Downloads/CCG_Scripts/c259135917.lua>)
- **Problem/question to solve:** summon restriction UI.
- **Current audited implementation:** summon restriction/search; conditional Battle Phase activation lock [implemented]. The file compiles and initializes; the open item is behavioral or interpretive, not a known load failure.
- **Manual review checklist:**
  1. Trigger the clause on Chain Link 1 and later chain links, then repeat when the relevant card leaves, changes control, or changes position before the delayed step.
  2. Test the exact phase/step boundary, missed-timing cases, turn changes, and simultaneous groups with more than one affected card.
  3. Verify labels/groups are cleared at the correct reset and that an "if you do" or "then" continuation occurs only after the required action succeeds.
  4. Run the relevant GY branch both with and without Necrovalley, including activation legality and a Necrovalley effect appearing before resolution.
  5. Include a full-zone case and a case where paying the cost opens a zone; the UI must not reject a legal post-cost state or promise an impossible summon.
- **Acceptance condition:** Record the authoritative interpretation and an Omega replay/log showing the positive case, the closest illegal case, and any listed interruption case. The observed result must match the exact source sequence and leave no broader/narrower legal pool than intended.

<details>
<summary>Exact current source text</summary>

This card cannot be Summoned while you control a monster. If this card is Normal Summoned: You can add 1 "Domestica" Fairy Monster from your Deck to your hand. During the Battle Phase, if you control a Fairy Monster, or you control no monsters (Quick Effect): You can shuffle this card from your GY into the Deck, and if you do, while you control a Fairy Monster, your opponent cannot activate cards or effect until the end of this Battle Phase. You can only use each effect of "Nuwa, the Domesticated" once per turn.

</details>

### 61. Mylo in the Wild - 259911246

- **Source ordinal:** 103. **Script:** [`c259911246.lua`](<../public/CCG Downloads/CCG_Scripts/c259911246.lua>)
- **Problem/question to solve:** position restoration ruling.
- **Current audited implementation:** board Set/End return; independent also return-search [fixed]. The file compiles and initializes; the open item is behavioral or interpretive, not a known load failure.
- **Manual review checklist:**
  1. Trigger the clause on Chain Link 1 and later chain links, then repeat when the relevant card leaves, changes control, or changes position before the delayed step.
  2. Test the exact phase/step boundary, missed-timing cases, turn changes, and simultaneous groups with more than one affected card.
  3. Verify labels/groups are cleared at the correct reset and that an "if you do" or "then" continuation occurs only after the required action succeeds.
  4. Run the relevant GY branch both with and without Necrovalley, including activation legality and a Necrovalley effect appearing before resolution.
  5. Include a full-zone case and a case where paying the cost opens a zone; the UI must not reject a legal post-cost state or promise an impossible summon.
- **Acceptance condition:** Record the authoritative interpretation and an Omega replay/log showing the positive case, the closest illegal case, and any listed interruption case. The observed result must match the exact source sequence and leave no broader/narrower legal pool than intended.

<details>
<summary>Exact current source text</summary>

"Mylo, The Domesticated" + 1 "Domestica" Fairy Monster
Cannot be Summoned while you control a monster. During the Main Phase, if you control no other monster (Quick Effect): You can Tribute this card; change all monsters on the field to face-down Defense Position until the end of this turn. You can only use the previous effect of "Mylo in the Wild" once per turn. If this card is sent to the GY: Return this card to the Extra Deck, also, add 1 "Mylo, The Domesticated" from your Deck to your hand, then send it to the GY.

</details>

### 62. Kanmuriyama - 248801935

- **Source ordinal:** 110. **Script:** [`c248801935.lua`](<../public/CCG Downloads/CCG_Scripts/c248801935.lua>)
- **Problem/question to solve:** lost-target event state.
- **Current audited implementation:** equip legality; different-Attribute search; lost-target recovery; battle bounce [implemented]. The file compiles and initializes; the open item is behavioral or interpretive, not a known load failure.
- **Manual review checklist:**
  1. Trigger the clause on Chain Link 1 and later chain links, then repeat when the relevant card leaves, changes control, or changes position before the delayed step.
  2. Test the exact phase/step boundary, missed-timing cases, turn changes, and simultaneous groups with more than one affected card.
  3. Verify labels/groups are cleared at the correct reset and that an "if you do" or "then" continuation occurs only after the required action succeeds.
  4. Run the relevant GY branch both with and without Necrovalley, including activation legality and a Necrovalley effect appearing before resolution.
  5. Attempt the effect/procedure twice and after a negated activation to confirm the intended card, effect, or oath count limit.
- **Acceptance condition:** Record the authoritative interpretation and an Omega replay/log showing the positive case, the closest illegal case, and any listed interruption case. The observed result must match the exact source sequence and leave no broader/narrower legal pool than intended.

<details>
<summary>Exact current source text</summary>

Equip only to a Spirit monster. If this card becomes equipped to a monster: You can add 1 Spirit monster from your Deck to your hand with a different Attribute than the equipped monster. You can only use the previous effect of "Kanmuriyama" once per turn. If this card is destroyed and sent from the field to the GY because the equipped monster returned to the hand: You can add this card to the hand. At the start of the Damage Step, if the equipped monster battles an opponent's monster, you can return that monster to the hand.

</details>

### 63. Otakemaru the Accuser - 221855414

- **Source ordinal:** 113. **Script:** [`c221855414.lua`](<../public/CCG Downloads/CCG_Scripts/c221855414.lua>)
- **Problem/question to solve:** paired summon UI.
- **Current audited implementation:** Synchro procedure; End Phase return lock; target protection; bounce; forced return-then-double revival [implemented]. The file compiles and initializes; the open item is behavioral or interpretive, not a known load failure.
- **Manual review checklist:**
  1. Trigger the clause on Chain Link 1 and later chain links, then repeat when the relevant card leaves, changes control, or changes position before the delayed step.
  2. Test the exact phase/step boundary, missed-timing cases, turn changes, and simultaneous groups with more than one affected card.
  3. Verify labels/groups are cleared at the correct reset and that an "if you do" or "then" continuation occurs only after the required action succeeds.
  4. Run the relevant GY branch both with and without Necrovalley, including activation legality and a Necrovalley effect appearing before resolution.
  5. Include a full-zone case and a case where paying the cost opens a zone; the UI must not reject a legal post-cost state or promise an impossible summon.
- **Acceptance condition:** Record the authoritative interpretation and an Omega replay/log showing the positive case, the closest illegal case, and any listed interruption case. The observed result must match the exact source sequence and leave no broader/narrower legal pool than intended.

<details>
<summary>Exact current source text</summary>

1 Spirit Tuner monster + 1+ non-Tuner monsters
If this card is Special Summoned: You can activate this effect; other Spirit monsters you control cannot return to the hand or Extra Deck by card effect during the End Phase of this turn. Your opponent cannot target Spirit monsters you control with card effects. If a Spirit monster is Normal Summoned: You can target 1 card your opponent controls; return it to the hand. During the End Phase, if this card was Special Summoned this turn: Return it to the Extra Deck, and if you do, Special Summon 2 Spirit monsters from your GY (1 Tuner and 1 non-Tuner) whose total Levels equal 9 ignoring their Summoning conditions.

</details>

### 64. Priestess of Nephthys - 211964444

- **Source ordinal:** 126. **Script:** [`c211964444.lua`](<../public/CCG Downloads/CCG_Scripts/c211964444.lua>)
- **Problem/question to solve:** copied Standby effect pool.
- **Current audited implementation:** destroy-from-Deck and Standby-effect application; hand shuffle search [implemented]. The file compiles and initializes; the open item is behavioral or interpretive, not a known load failure.
- **Manual review checklist:**
  1. Trigger the clause on Chain Link 1 and later chain links, then repeat when the relevant card leaves, changes control, or changes position before the delayed step.
  2. Test the exact phase/step boundary, missed-timing cases, turn changes, and simultaneous groups with more than one affected card.
  3. Verify labels/groups are cleared at the correct reset and that an "if you do" or "then" continuation occurs only after the required action succeeds.
  4. Run the relevant GY branch both with and without Necrovalley, including activation legality and a Necrovalley effect appearing before resolution.
  5. Include a full-zone case and a case where paying the cost opens a zone; the UI must not reject a legal post-cost state or promise an impossible summon.
- **Acceptance condition:** Record the authoritative interpretation and an Omega replay/log showing the positive case, the closest illegal case, and any listed interruption case. The observed result must match the exact source sequence and leave no broader/narrower legal pool than intended.

<details>
<summary>Exact current source text</summary>

You can Ritual Summon this card with any "Nephthys" Ritual Spell. If this card is Special Summoned: You can reveal 1 "Nephthys" monster in your Deck; destroy it, then apply that card's effect that activates during the Standby Phase. You can shuffle this card from your hand into the Deck; add 1 "Nephthys" Spell/Trap Card from your Deck or GY to your hand. You can only use each effect of "Priestess of Nephthys" once per turn.

</details>

### 65. Protogenesis - 246524183

- **Source ordinal:** 132. **Script:** [`c246524183.lua`](<../public/CCG Downloads/CCG_Scripts/c246524183.lua>)
- **Problem/question to solve:** if you do timing.
- **Current audited implementation:** reveal then summon-or-banish; End Phase LP loss [implemented]. The file compiles and initializes; the open item is behavioral or interpretive, not a known load failure.
- **Manual review checklist:**
  1. Trigger the clause on Chain Link 1 and later chain links, then repeat when the relevant card leaves, changes control, or changes position before the delayed step.
  2. Test the exact phase/step boundary, missed-timing cases, turn changes, and simultaneous groups with more than one affected card.
  3. Verify labels/groups are cleared at the correct reset and that an "if you do" or "then" continuation occurs only after the required action succeeds.
  4. Include face-up and face-down banished cards and confirm hidden cards are never selected unless the text explicitly permits them.
  5. Include a full-zone case and a case where paying the cost opens a zone; the UI must not reject a legal post-cost state or promise an impossible summon.
- **Acceptance condition:** Record the authoritative interpretation and an Omega replay/log showing the positive case, the closest illegal case, and any listed interruption case. The observed result must match the exact source sequence and leave no broader/narrower legal pool than intended.

<details>
<summary>Exact current source text</summary>

Reveal 1 "To Proto" monster in your hand or Deck; if it can be Normal Summoned/Set, Special Summon it. Otherwise, banish it. You can only use this effect of "Protogenesis" once per turn, and if you do, during the End Phase you lose LP equal to the total original ATK and DEF of each monster you control.

</details>

### 66. Chrono-Saur Rex - 236898203

- **Source ordinal:** 267. **Script:** [`c236898203.lua`](<../public/CCG Downloads/CCG_Scripts/c236898203.lua>)
- **Problem/question to solve:** Fixed prerequisite destruction to own face-up on-field Chrono/Dinosaur cards and scheduled self-destruction for the actual summoning phase (Main Phase 1 or Battle Phase); EVENT_PHASE+PHASE_MAIN1 lacks an exact official analogue and needs live timing validation.
- **Current audited implementation:** Fixed prerequisite destruction to own face-up on-field Chrono/Dinosaur cards and scheduled self-destruction for the actual summoning phase (Main Phase 1 or Battle Phase); EVENT_PHASE+PHASE_MAIN1 lacks an exact official analogue and needs live timing validation. The file compiles and initializes; the open item is behavioral or interpretive, not a known load failure.
- **Manual review checklist:**
  1. Trigger the clause on Chain Link 1 and later chain links, then repeat when the relevant card leaves, changes control, or changes position before the delayed step.
  2. Test the exact phase/step boundary, missed-timing cases, turn changes, and simultaneous groups with more than one affected card.
  3. Verify labels/groups are cleared at the correct reset and that an "if you do" or "then" continuation occurs only after the required action succeeds.
  4. Run the relevant GY branch both with and without Necrovalley, including activation legality and a Necrovalley effect appearing before resolution.
  5. Include a full-zone case and a case where paying the cost opens a zone; the UI must not reject a legal post-cost state or promise an impossible summon.
- **Acceptance condition:** Record the authoritative interpretation and an Omega replay/log showing the positive case, the closest illegal case, and any listed interruption case. The observed result must match the exact source sequence and leave no broader/narrower legal pool than intended.

<details>
<summary>Exact current source text</summary>

During the Main Phase 1 or Battle Phase (Quick Effect): You can destroy 1 "Chrono-Saur" card or 1 Dinosaur monster you control, and if you do, Special Summon this card from hand. Destroy this card Summoned this way at the end of the Phase it was Summoned. When you declare an attack: You can Special Summon this card from your GY, but destroy this card at the end of the Battle Phase. You can only use each effect of "Chrono-Saur Rex" once per turn.

</details>

### 67. Stardust Comet - 231523659

- **Source ordinal:** 444. **Script:** [`c231523659.lua`](<../public/CCG Downloads/CCG_Scripts/c231523659.lua>)
- **Problem/question to solve:** Deck Tribute/immediate Synchro/Level timing.
- **Current audited implementation:** Deck Tribute/immediate Synchro/Level timing. The file compiles and initializes; the open item is behavioral or interpretive, not a known load failure.
- **Manual review checklist:**
  1. Trigger the clause on Chain Link 1 and later chain links, then repeat when the relevant card leaves, changes control, or changes position before the delayed step.
  2. Test the exact phase/step boundary, missed-timing cases, turn changes, and simultaneous groups with more than one affected card.
  3. Verify labels/groups are cleared at the correct reset and that an "if you do" or "then" continuation occurs only after the required action succeeds.
  4. Include a full-zone case and a case where paying the cost opens a zone; the UI must not reject a legal post-cost state or promise an impossible summon.
  5. Attempt the effect/procedure twice and after a negated activation to confirm the intended card, effect, or oath count limit.
- **Acceptance condition:** Record the authoritative interpretation and an Omega replay/log showing the positive case, the closest illegal case, and any listed interruption case. The observed result must match the exact source sequence and leave no broader/narrower legal pool than intended.

<details>
<summary>Exact current source text</summary>

(Quick Effect): You can Tribute 1 "Stardust" monster from your Deck, except "Stardust Comet"; Special Summon this card from your hand. If you Normal or Special Summon a "Stardust" monster, except "Stardust Comet": You can, immediately after this effect resolves, Synchro Summon 1 "Stardust", "Synchron" or "Warrior" Synchro Monster using monsters you control, and if you do, you can increase or decrease its Level by 1. You can only use each effect of "Stardust Comet" once per turn.

</details>

## Summon, material, and selection UI

### 68. The Condescender - 221321849

- **Source ordinal:** 3. **Script:** [`c221321849.lua`](<../public/CCG Downloads/CCG_Scripts/c221321849.lua>)
- **Problem/question to solve:** summon procedure; Level and Rank reduction; Link Rating reduction unsupported.
- **Current audited implementation:** summon procedure; Level and Rank reduction; Link Rating reduction unsupported. The file compiles and initializes; the open item is behavioral or interpretive, not a known load failure.
- **Manual review checklist:**
  1. Test the minimum, exact, and maximum legal materials/resources, plus one illegal candidate of each nearby type.
  2. Repeat with full Monster Zones, no Extra Monster Zone, Necrovalley where relevant, face-down banished cards, and a candidate leaving before resolution.
  3. Confirm the summon type, material reason, procedure completion, once-per-turn lock, cancel behavior, and future revival legality are all correct.
  4. Run the relevant GY branch both with and without Necrovalley, including activation legality and a Necrovalley effect appearing before resolution.
  5. Include face-up and face-down banished cards and confirm hidden cards are never selected unless the text explicitly permits them.
- **Acceptance condition:** Record the authoritative interpretation and an Omega replay/log showing the positive case, the closest illegal case, and any listed interruption case. The observed result must match the exact source sequence and leave no broader/narrower legal pool than intended.

<details>
<summary>Exact current source text</summary>

(Quick Effect): You can send this card from your hand to the GY, then target 1 face-up monster on the field; declare a number from 1 to 3, then reduce that monster's Level, Rank, or Link Rating by the declared number until the end of the next turn. If a monster whose Level, Rank, or Link Rating is lower than its original value is on the field: You can Special Summon this card from your GY, but banish it when it leaves the field. You can only use 1 effect of "The Condescender" per turn and only once that turn.

</details>

### 69. Stained Fox Feness - 247499445

- **Source ordinal:** 6. **Script:** [`c247499445.lua`](<../public/CCG Downloads/CCG_Scripts/c247499445.lua>)
- **Problem/question to solve:** printed colon versus procedure UI.
- **Current audited implementation:** hand self-Summon procedure; Summon negate-and-shuffle [implemented]. The file compiles and initializes; the open item is behavioral or interpretive, not a known load failure.
- **Manual review checklist:**
  1. Test the minimum, exact, and maximum legal materials/resources, plus one illegal candidate of each nearby type.
  2. Repeat with full Monster Zones, no Extra Monster Zone, Necrovalley where relevant, face-down banished cards, and a candidate leaving before resolution.
  3. Confirm the summon type, material reason, procedure completion, once-per-turn lock, cancel behavior, and future revival legality are all correct.
  4. Run the relevant GY branch both with and without Necrovalley, including activation legality and a Necrovalley effect appearing before resolution.
  5. Include a full-zone case and a case where paying the cost opens a zone; the UI must not reject a legal post-cost state or promise an impossible summon.
- **Acceptance condition:** Record the authoritative interpretation and an Omega replay/log showing the positive case, the closest illegal case, and any listed interruption case. The observed result must match the exact source sequence and leave no broader/narrower legal pool than intended.

<details>
<summary>Exact current source text</summary>

If your opponent controls more cards than you do: You can Special Summon this card from your hand. If this card is Normal or Special Summoned: You can target 1 other face-up card on the field; negate its effects until the end of this turn, and if you do, shuffle this card into the Deck. You can send 1 Level 4 or lower "Stain" monster from your Deck to the GY; Shuffle this card face-up into your opponent's Deck. You can only use each effect of "Stained Fox Feness" once per turn.

</details>

### 70. The Blue Frute - 236158052

- **Source ordinal:** 46. **Script:** [`c236158052.lua`](<../public/CCG Downloads/CCG_Scripts/c236158052.lua>)
- **Problem/question to solve:** custom UI.
- **Current audited implementation:** face-down Extra Deck summon procedure and effects [implemented]. The file compiles and initializes; the open item is behavioral or interpretive, not a known load failure.
- **Manual review checklist:**
  1. Test the minimum, exact, and maximum legal materials/resources, plus one illegal candidate of each nearby type.
  2. Repeat with full Monster Zones, no Extra Monster Zone, Necrovalley where relevant, face-down banished cards, and a candidate leaving before resolution.
  3. Confirm the summon type, material reason, procedure completion, once-per-turn lock, cancel behavior, and future revival legality are all correct.
  4. Include face-up and face-down banished cards and confirm hidden cards are never selected unless the text explicitly permits them.
  5. Include a full-zone case and a case where paying the cost opens a zone; the UI must not reject a legal post-cost state or promise an impossible summon.
- **Acceptance condition:** Record the authoritative interpretation and an Omega replay/log showing the positive case, the closest illegal case, and any listed interruption case. The observed result must match the exact source sequence and leave no broader/narrower legal pool than intended.

<details>
<summary>Exact current source text</summary>

If this card is Normal Summoned: You can Special Summon 1 "Frute" monster from your Deck in face-down Defense Position, except "The Blue Frute". If this card is Tributed: You can target 1 face-up monster your opponent controls; this turn, its ATK/DEF becomes 0, also if this card was Tributed in face-down Defense Position, banish it when it leaves the field. You can only use each effect of "The Blue Frute" once per turn.

</details>

### 71. The Yellow Frute - 235607781

- **Source ordinal:** 47. **Script:** [`c235607781.lua`](<../public/CCG Downloads/CCG_Scripts/c235607781.lua>)
- **Problem/question to solve:** custom UI.
- **Current audited implementation:** summon procedure and Frute effect [implemented]. The file compiles and initializes; the open item is behavioral or interpretive, not a known load failure.
- **Manual review checklist:**
  1. Test the minimum, exact, and maximum legal materials/resources, plus one illegal candidate of each nearby type.
  2. Repeat with full Monster Zones, no Extra Monster Zone, Necrovalley where relevant, face-down banished cards, and a candidate leaving before resolution.
  3. Confirm the summon type, material reason, procedure completion, once-per-turn lock, cancel behavior, and future revival legality are all correct.
  4. Run the relevant GY branch both with and without Necrovalley, including activation legality and a Necrovalley effect appearing before resolution.
  5. Include a full-zone case and a case where paying the cost opens a zone; the UI must not reject a legal post-cost state or promise an impossible summon.
- **Acceptance condition:** Record the authoritative interpretation and an Omega replay/log showing the positive case, the closest illegal case, and any listed interruption case. The observed result must match the exact source sequence and leave no broader/narrower legal pool than intended.

<details>
<summary>Exact current source text</summary>

You can send this card from your hand or face-up field to the GY; Special Summon 1 "Frute" monster from your hand or GY in face-up or face-down Defense Position, except "The Yellow Frute". If this card is Tributed: You can draw 1 card, or, if this card was Tributed in face-down Defense Position, you can draw 2 cards, then discard 1 card. You can only use each effect of "The Yellow Frute" once per turn.

</details>

### 72. The Red Frute - 246216813

- **Source ordinal:** 48. **Script:** [`c246216813.lua`](<../public/CCG Downloads/CCG_Scripts/c246216813.lua>)
- **Problem/question to solve:** custom UI.
- **Current audited implementation:** summon procedure and Frute effect [implemented]. The file compiles and initializes; the open item is behavioral or interpretive, not a known load failure.
- **Manual review checklist:**
  1. Test the minimum, exact, and maximum legal materials/resources, plus one illegal candidate of each nearby type.
  2. Repeat with full Monster Zones, no Extra Monster Zone, Necrovalley where relevant, face-down banished cards, and a candidate leaving before resolution.
  3. Confirm the summon type, material reason, procedure completion, once-per-turn lock, cancel behavior, and future revival legality are all correct.
  4. Run the relevant GY branch both with and without Necrovalley, including activation legality and a Necrovalley effect appearing before resolution.
  5. Include a full-zone case and a case where paying the cost opens a zone; the UI must not reject a legal post-cost state or promise an impossible summon.
- **Acceptance condition:** Record the authoritative interpretation and an Omega replay/log showing the positive case, the closest illegal case, and any listed interruption case. The observed result must match the exact source sequence and leave no broader/narrower legal pool than intended.

<details>
<summary>Exact current source text</summary>

If you control no face-up monsters, or you control a "Frute" card: You can Special Summon this card from your hand, then you can send 1 "Frute" card from your Deck to the GY, with a different name from the cards you control. If this card is Tributed: You can add 1 "Fruteonia" from your Deck to your hand, or, if this card was Tributed in face-down Defense Position, you can Set 1 "Frute" Spell/Trap directly from your Deck instead. You can only use each effect of "The Red Frute" once per turn.

</details>

### 73. The Green Frute - 227745087

- **Source ordinal:** 49. **Script:** [`c227745087.lua`](<../public/CCG Downloads/CCG_Scripts/c227745087.lua>)
- **Problem/question to solve:** custom UI.
- **Current audited implementation:** field-Tribute/full-zone cost and summon [implemented]. The file compiles and initializes; the open item is behavioral or interpretive, not a known load failure.
- **Manual review checklist:**
  1. Test the minimum, exact, and maximum legal materials/resources, plus one illegal candidate of each nearby type.
  2. Repeat with full Monster Zones, no Extra Monster Zone, Necrovalley where relevant, face-down banished cards, and a candidate leaving before resolution.
  3. Confirm the summon type, material reason, procedure completion, once-per-turn lock, cancel behavior, and future revival legality are all correct.
  4. Run the relevant GY branch both with and without Necrovalley, including activation legality and a Necrovalley effect appearing before resolution.
  5. Include face-up and face-down banished cards and confirm hidden cards are never selected unless the text explicitly permits them.
- **Acceptance condition:** Record the authoritative interpretation and an Omega replay/log showing the positive case, the closest illegal case, and any listed interruption case. The observed result must match the exact source sequence and leave no broader/narrower legal pool than intended.

<details>
<summary>Exact current source text</summary>

You can Tribute 1 WATER monster from your hand or field, except "The Green Frute"; Special Summon this card from your hand or GY in face-down Defense Position, but banish it when it leaves the field. If this card is Tributed: You can send 1 "Frute" monster from your Deck to the GY, except "The Green Frute", or, if this card was Tributed in face-down Defense Position, you can send 1 "Frute" Spell/Trap from your Deck to the GY instead. You can only use each effect of "The Green Frute" once per turn.

</details>

### 74. The White Frute - 220916791

- **Source ordinal:** 50. **Script:** [`c220916791.lua`](<../public/CCG Downloads/CCG_Scripts/c220916791.lua>)
- **Problem/question to solve:** mandatory Tribute opens MZONE before target check [fixed]; summon effect [implemented].
- **Current audited implementation:** mandatory Tribute opens MZONE before target check [fixed]; summon effect [implemented]. The file compiles and initializes; the open item is behavioral or interpretive, not a known load failure.
- **Manual review checklist:**
  1. Test the minimum, exact, and maximum legal materials/resources, plus one illegal candidate of each nearby type.
  2. Repeat with full Monster Zones, no Extra Monster Zone, Necrovalley where relevant, face-down banished cards, and a candidate leaving before resolution.
  3. Confirm the summon type, material reason, procedure completion, once-per-turn lock, cancel behavior, and future revival legality are all correct.
  4. Run the relevant GY branch both with and without Necrovalley, including activation legality and a Necrovalley effect appearing before resolution.
  5. Include a full-zone case and a case where paying the cost opens a zone; the UI must not reject a legal post-cost state or promise an impossible summon.
- **Acceptance condition:** Record the authoritative interpretation and an Omega replay/log showing the positive case, the closest illegal case, and any listed interruption case. The observed result must match the exact source sequence and leave no broader/narrower legal pool than intended.

<details>
<summary>Exact current source text</summary>

You can Tribute 1 WATER monster; Special Summon this card from your hand, then add 1 "Frute" monster from your Deck to your hand, except "The White Frute". If this card is Tributed: You can target 1 "Frute" monster in your GY, except "The White Frute"; add it to your hand, or, if this card was Tributed in face-down Defense Position, you can Special Summon it in face-up or face-down Defense Position instead. You can only use each effect of "The White Frute" once per turn.

</details>

### 75. Fruteonia - 246830897

- **Source ordinal:** 51. **Script:** [`c246830897.lua`](<../public/CCG Downloads/CCG_Scripts/c246830897.lua>)
- **Problem/question to solve:** face-down Link/Ritual UI.
- **Current audited implementation:** field effects and custom Frute Summon support [implemented]. The file compiles and initializes; the open item is behavioral or interpretive, not a known load failure.
- **Manual review checklist:**
  1. Test the minimum, exact, and maximum legal materials/resources, plus one illegal candidate of each nearby type.
  2. Repeat with full Monster Zones, no Extra Monster Zone, Necrovalley where relevant, face-down banished cards, and a candidate leaving before resolution.
  3. Confirm the summon type, material reason, procedure completion, once-per-turn lock, cancel behavior, and future revival legality are all correct.
  4. Run the relevant GY branch both with and without Necrovalley, including activation legality and a Necrovalley effect appearing before resolution.
  5. Include face-up and face-down banished cards and confirm hidden cards are never selected unless the text explicitly permits them.
- **Acceptance condition:** Record the authoritative interpretation and an Omega replay/log showing the positive case, the closest illegal case, and any listed interruption case. The observed result must match the exact source sequence and leave no broader/narrower legal pool than intended.

<details>
<summary>Exact current source text</summary>

While you control a WATER Ritual Monster, your opponent cannot target face-down monsters you control with attacks or card effects. You can only use each of the following effects of "Fruteonia" once per turn. You can Tribute 1 WATER monster from your hand or field; add 1 WATER Ritual Monster or 1 "Fruteification" from your Deck, GY, or banishment to your hand. If a monster(s) on the field is Tributed: You can target 1 "Frute" card in your banishment; return it to the GY.

</details>

### 76. Fruteopia - 216140411

- **Source ordinal:** 52. **Script:** [`c216140411.lua`](<../public/CCG Downloads/CCG_Scripts/c216140411.lua>)
- **Problem/question to solve:** face-down Link/Ritual UI.
- **Current audited implementation:** field effects and custom Frute Summon support [implemented]. The file compiles and initializes; the open item is behavioral or interpretive, not a known load failure.
- **Manual review checklist:**
  1. Test the minimum, exact, and maximum legal materials/resources, plus one illegal candidate of each nearby type.
  2. Repeat with full Monster Zones, no Extra Monster Zone, Necrovalley where relevant, face-down banished cards, and a candidate leaving before resolution.
  3. Confirm the summon type, material reason, procedure completion, once-per-turn lock, cancel behavior, and future revival legality are all correct.
  4. Run the relevant GY branch both with and without Necrovalley, including activation legality and a Necrovalley effect appearing before resolution.
  5. Include face-up and face-down banished cards and confirm hidden cards are never selected unless the text explicitly permits them.
- **Acceptance condition:** Record the authoritative interpretation and an Omega replay/log showing the positive case, the closest illegal case, and any listed interruption case. The observed result must match the exact source sequence and leave no broader/narrower legal pool than intended.

<details>
<summary>Exact current source text</summary>

This card's name becomes "Fruteonia" while face-up on the field. You can only use 1 of the following effects of "Fruteopia" per turn, and only once that turn. When this card is activated: You can add 1 "Frute" monster or 1 "Fruteification" from your Deck or banishment to your hand. If a WATER Ritual Monster(s) you control leaves the field by card effect: You can send this card to the GY, and if you do, Special Summon 1 of those monsters. You can banish this card from your GY; all WATER monsters you control gain 400 ATK this turn for each Defense Position monster your opponent controls.

</details>

### 77. Fruteification - 256930605

- **Source ordinal:** 54. **Script:** [`c256930605.lua`](<../public/CCG Downloads/CCG_Scripts/c256930605.lua>)
- **Problem/question to solve:** custom summon UI.
- **Current audited implementation:** activation and summon behavior [implemented]. The file compiles and initializes; the open item is behavioral or interpretive, not a known load failure.
- **Manual review checklist:**
  1. Test the minimum, exact, and maximum legal materials/resources, plus one illegal candidate of each nearby type.
  2. Repeat with full Monster Zones, no Extra Monster Zone, Necrovalley where relevant, face-down banished cards, and a candidate leaving before resolution.
  3. Confirm the summon type, material reason, procedure completion, once-per-turn lock, cancel behavior, and future revival legality are all correct.
  4. Run the relevant GY branch both with and without Necrovalley, including activation legality and a Necrovalley effect appearing before resolution.
  5. Include face-up and face-down banished cards and confirm hidden cards are never selected unless the text explicitly permits them.
- **Acceptance condition:** Record the authoritative interpretation and an Omega replay/log showing the positive case, the closest illegal case, and any listed interruption case. The observed result must match the exact source sequence and leave no broader/narrower legal pool than intended.

<details>
<summary>Exact current source text</summary>

When this card is activated, you can also target 1 non-Ritual "Frute" monster in your GY, but for the rest of this turn, you cannot target a monster to activate this effect of "Fruteification"; Special Summon the targeted monster in face-down Defense Position (if any), also, Ritual Summon 1 WATER Ritual Monster from your hand or GY by Tributing monsters from your hand or field, whose total Levels equal or exceed the Level of the Ritual Monster. You can banish this card from your GY; send 1 WATER Ritual Monster from your Deck to the GY. You can only use this effect of "Fruteification" once per Duel.

</details>

### 78. The Fruteful Moon - 248290754

- **Source ordinal:** 57. **Script:** [`c248290754.lua`](<../public/CCG Downloads/CCG_Scripts/c248290754.lua>)
- **Problem/question to solve:** custom UI.
- **Current audited implementation:** field and Frute support effects [implemented]. The file compiles and initializes; the open item is behavioral or interpretive, not a known load failure.
- **Manual review checklist:**
  1. Test the minimum, exact, and maximum legal materials/resources, plus one illegal candidate of each nearby type.
  2. Repeat with full Monster Zones, no Extra Monster Zone, Necrovalley where relevant, face-down banished cards, and a candidate leaving before resolution.
  3. Confirm the summon type, material reason, procedure completion, once-per-turn lock, cancel behavior, and future revival legality are all correct.
  4. Include a full-zone case and a case where paying the cost opens a zone; the UI must not reject a legal post-cost state or promise an impossible summon.
  5. Attempt the effect/procedure twice and after a negated activation to confirm the intended card, effect, or oath count limit.
- **Acceptance condition:** Record the authoritative interpretation and an Omega replay/log showing the positive case, the closest illegal case, and any listed interruption case. The observed result must match the exact source sequence and leave no broader/narrower legal pool than intended.

<details>
<summary>Exact current source text</summary>

You can Ritual Summon this card with "Fruteification". Your opponent cannot destroy your "Fruteonia" with card effects. You can only use each of the following effects of "The Fruteful Moon" once per turn. If this card is Special Summoned: You can Set 1 "Frute" Spell/Trap directly from your Deck, and if you do. it can be activated this turn. (Quick Effect): You can Tribute 1 other WATER monster from your hand or field, then target 1 face-up monster on the field; change it to face-down Defense Position.

</details>

### 79. Pip, the Domesticated - 259377794

- **Source ordinal:** 69. **Script:** [`c259377794.lua`](<../public/CCG Downloads/CCG_Scripts/c259377794.lua>)
- **Problem/question to solve:** custom Tribute Summon support.
- **Current audited implementation:** summon restriction/search/battle shuffle [implemented]. The file compiles and initializes; the open item is behavioral or interpretive, not a known load failure.
- **Manual review checklist:**
  1. Test the minimum, exact, and maximum legal materials/resources, plus one illegal candidate of each nearby type.
  2. Repeat with full Monster Zones, no Extra Monster Zone, Necrovalley where relevant, face-down banished cards, and a candidate leaving before resolution.
  3. Confirm the summon type, material reason, procedure completion, once-per-turn lock, cancel behavior, and future revival legality are all correct.
  4. Run the relevant GY branch both with and without Necrovalley, including activation legality and a Necrovalley effect appearing before resolution.
  5. Include a full-zone case and a case where paying the cost opens a zone; the UI must not reject a legal post-cost state or promise an impossible summon.
- **Acceptance condition:** Record the authoritative interpretation and an Omega replay/log showing the positive case, the closest illegal case, and any listed interruption case. The observed result must match the exact source sequence and leave no broader/narrower legal pool than intended.

<details>
<summary>Exact current source text</summary>

This card cannot be Summoned while you control a monster. If this card is Normal Summoned: You can add 1 "Domestica" Fairy Monster from your Deck to your hand. During the Battle Phase, if all monsters you control are Fairy Monsters (Quick Effect): You can shuffle this card from your GY into the Deck, and if you do, Fairy Monsters you control gain 550 ATK until the end of that Battle Phase. You can only use each effect of "Pip, the Domesticated" once per turn.

</details>

### 80. Domestica Praerie - 259264881

- **Source ordinal:** 71. **Script:** [`c259264881.lua`](<../public/CCG Downloads/CCG_Scripts/c259264881.lua>)
- **Problem/question to solve:** custom Tribute UI.
- **Current audited implementation:** hand Tribute support/set/search-send [implemented]. The file compiles and initializes; the open item is behavioral or interpretive, not a known load failure.
- **Manual review checklist:**
  1. Test the minimum, exact, and maximum legal materials/resources, plus one illegal candidate of each nearby type.
  2. Repeat with full Monster Zones, no Extra Monster Zone, Necrovalley where relevant, face-down banished cards, and a candidate leaving before resolution.
  3. Confirm the summon type, material reason, procedure completion, once-per-turn lock, cancel behavior, and future revival legality are all correct.
  4. Run the relevant GY branch both with and without Necrovalley, including activation legality and a Necrovalley effect appearing before resolution.
  5. Include a full-zone case and a case where paying the cost opens a zone; the UI must not reject a legal post-cost state or promise an impossible summon.
- **Acceptance condition:** Record the authoritative interpretation and an Omega replay/log showing the positive case, the closest illegal case, and any listed interruption case. The observed result must match the exact source sequence and leave no broader/narrower legal pool than intended.

<details>
<summary>Exact current source text</summary>

Except during the Battle Phase, this card cannot be Summoned while you control a monster, except by Tribute Summon where the required Tribute(s) are the only monster(s) you control. You can Normal Summon/Set this card in addition to your Normal Summon/Set (You can only gain this effect once per turn). You can Tribute this card; add 1 "Domestica" monster from your Deck to your hand, then send 1 card from your hand to the GY. You can only use this effect of "Domestica Praerie" once per turn.

</details>

### 81. Domestica Anjelie - 259337739

- **Source ordinal:** 72. **Script:** [`c259337739.lua`](<../public/CCG Downloads/CCG_Scripts/c259337739.lua>)
- **Problem/question to solve:** custom Tribute UI.
- **Current audited implementation:** hand Tribute support/set/search-send [implemented]. The file compiles and initializes; the open item is behavioral or interpretive, not a known load failure.
- **Manual review checklist:**
  1. Test the minimum, exact, and maximum legal materials/resources, plus one illegal candidate of each nearby type.
  2. Repeat with full Monster Zones, no Extra Monster Zone, Necrovalley where relevant, face-down banished cards, and a candidate leaving before resolution.
  3. Confirm the summon type, material reason, procedure completion, once-per-turn lock, cancel behavior, and future revival legality are all correct.
  4. Run the relevant GY branch both with and without Necrovalley, including activation legality and a Necrovalley effect appearing before resolution.
  5. Include a full-zone case and a case where paying the cost opens a zone; the UI must not reject a legal post-cost state or promise an impossible summon.
- **Acceptance condition:** Record the authoritative interpretation and an Omega replay/log showing the positive case, the closest illegal case, and any listed interruption case. The observed result must match the exact source sequence and leave no broader/narrower legal pool than intended.

<details>
<summary>Exact current source text</summary>

Except during the Battle Phase, this card cannot be Summoned while you control a monster, except by Tribute Summon where the required Tribute(s) are the only monster(s) you control. You can Normal Summon/Set this card in addition to your Normal Summon/Set (You can only gain this effect once per turn). You can Tribute this card; add 1 "Domestica" Spell/Trap from your Deck to your hand, then send 1 card from your hand to the GY. You can only use this effect of "Domestica Anjelie" once per turn.

</details>

### 82. Domestica Lunalie - 259245149

- **Source ordinal:** 73. **Script:** [`c259245149.lua`](<../public/CCG Downloads/CCG_Scripts/c259245149.lua>)
- **Problem/question to solve:** custom Tribute UI.
- **Current audited implementation:** hand Tribute support/set/GY access [implemented]. The file compiles and initializes; the open item is behavioral or interpretive, not a known load failure.
- **Manual review checklist:**
  1. Test the minimum, exact, and maximum legal materials/resources, plus one illegal candidate of each nearby type.
  2. Repeat with full Monster Zones, no Extra Monster Zone, Necrovalley where relevant, face-down banished cards, and a candidate leaving before resolution.
  3. Confirm the summon type, material reason, procedure completion, once-per-turn lock, cancel behavior, and future revival legality are all correct.
  4. Run the relevant GY branch both with and without Necrovalley, including activation legality and a Necrovalley effect appearing before resolution.
  5. Include a full-zone case and a case where paying the cost opens a zone; the UI must not reject a legal post-cost state or promise an impossible summon.
- **Acceptance condition:** Record the authoritative interpretation and an Omega replay/log showing the positive case, the closest illegal case, and any listed interruption case. The observed result must match the exact source sequence and leave no broader/narrower legal pool than intended.

<details>
<summary>Exact current source text</summary>

Except during the Battle Phase, this card cannot be Summoned while you control a monster, except by Tribute Summon where the required Tribute(s) are the only monster(s) you control. You can Normal Summon/Set this card in addition to your Normal Summon/Set (You can only gain this effect once per turn). You can Tribute this card; add 1 "Domestica" card from your GY to your hand, then you can send 1 card from your hand to the GY. You can only use this effect of "Domestica Lunalie" once per turn.

</details>

### 83. Domestica in the Underworld - 259668626

- **Source ordinal:** 76. **Script:** [`c259668626.lua`](<../public/CCG Downloads/CCG_Scripts/c259668626.lua>)
- **Problem/question to solve:** extra Tribute UI.
- **Current audited implementation:** extra hand Tribute; Set protection; draw-then-send [implemented]. The file compiles and initializes; the open item is behavioral or interpretive, not a known load failure.
- **Manual review checklist:**
  1. Test the minimum, exact, and maximum legal materials/resources, plus one illegal candidate of each nearby type.
  2. Repeat with full Monster Zones, no Extra Monster Zone, Necrovalley where relevant, face-down banished cards, and a candidate leaving before resolution.
  3. Confirm the summon type, material reason, procedure completion, once-per-turn lock, cancel behavior, and future revival legality are all correct.
  4. Run the relevant GY branch both with and without Necrovalley, including activation legality and a Necrovalley effect appearing before resolution.
  5. Include a full-zone case and a case where paying the cost opens a zone; the UI must not reject a legal post-cost state or promise an impossible summon.
- **Acceptance condition:** Record the authoritative interpretation and an Omega replay/log showing the positive case, the closest illegal case, and any listed interruption case. The observed result must match the exact source sequence and leave no broader/narrower legal pool than intended.

<details>
<summary>Exact current source text</summary>

This card in your hand can be used as Tribute when you Normal Summon a NATURE Monster. If this card is sent from the hand to the GY: You can Set this card, and if you do, this Set card cannot be destroyed by card effects. If a NATURE Monster(s) returns from your GY to the Deck (max 2): You can draw that many cards, then send that many cards from your hand to the GY. You can only use each effect of "Domestica in the Underworld" once per turn.

</details>

### 84. Domestica in the Wild - 259410628

- **Source ordinal:** 77. **Script:** [`c259410628.lua`](<../public/CCG Downloads/CCG_Scripts/c259410628.lua>)
- **Problem/question to solve:** Fusion UI.
- **Current audited implementation:** extra hand Tribute; Set-turn activation; optional Tribute and GY Fusion [implemented]. The file compiles and initializes; the open item is behavioral or interpretive, not a known load failure.
- **Manual review checklist:**
  1. Test the minimum, exact, and maximum legal materials/resources, plus one illegal candidate of each nearby type.
  2. Repeat with full Monster Zones, no Extra Monster Zone, Necrovalley where relevant, face-down banished cards, and a candidate leaving before resolution.
  3. Confirm the summon type, material reason, procedure completion, once-per-turn lock, cancel behavior, and future revival legality are all correct.
  4. Run the relevant GY branch both with and without Necrovalley, including activation legality and a Necrovalley effect appearing before resolution.
  5. Include a full-zone case and a case where paying the cost opens a zone; the UI must not reject a legal post-cost state or promise an impossible summon.
- **Acceptance condition:** Record the authoritative interpretation and an Omega replay/log showing the positive case, the closest illegal case, and any listed interruption case. The observed result must match the exact source sequence and leave no broader/narrower legal pool than intended.

<details>
<summary>Exact current source text</summary>

This card in your hand can be used as Tribute when you Normal Summon a NATURE Monster. If this card is sent from the hand to the GY: You can Set this card, and if you do, this card can be activated this turn. During the Main Phase: You can also Tribute a monster you control to activate this effect; reveal 1 Beast or Winged Beast Fusion Monster in your Extra Deck, then you can Fusion Summon it by shuffling the Fusion Materials from your GY into the Deck. You can only use each effect of "Domestica in the Wild" once per turn.

</details>

### 85. Domestica Kyrie - 259670933

- **Source ordinal:** 78. **Script:** [`c259670933.lua`](<../public/CCG Downloads/CCG_Scripts/c259670933.lua>)
- **Problem/question to solve:** custom procedure.
- **Current audited implementation:** contact Fusion procedure; Underworld placement; Tributed-turn GY effect [implemented]. The file compiles and initializes; the open item is behavioral or interpretive, not a known load failure.
- **Manual review checklist:**
  1. Test the minimum, exact, and maximum legal materials/resources, plus one illegal candidate of each nearby type.
  2. Repeat with full Monster Zones, no Extra Monster Zone, Necrovalley where relevant, face-down banished cards, and a candidate leaving before resolution.
  3. Confirm the summon type, material reason, procedure completion, once-per-turn lock, cancel behavior, and future revival legality are all correct.
  4. Run the relevant GY branch both with and without Necrovalley, including activation legality and a Necrovalley effect appearing before resolution.
  5. Include a full-zone case and a case where paying the cost opens a zone; the UI must not reject a legal post-cost state or promise an impossible summon.
- **Acceptance condition:** Record the authoritative interpretation and an Omega replay/log showing the positive case, the closest illegal case, and any listed interruption case. The observed result must match the exact source sequence and leave no broader/narrower legal pool than intended.

<details>
<summary>Exact current source text</summary>

2 "Domestica" monsters except "Domestica Kyrie"
Must first be Special Summoned from the Extra Deck by shuffling the Required Materials from your GY into the Deck while you control no monsters (You do not use "Polymerization"). You can only Special Summon "Domestica Kyrie" once per turn this way. If this card is Special Summoned from the Extra Deck: You can activate 1 "Domestic Underworld" from your Deck or GY. During the turn this card in your GY was Tributed (Quick Effect): You can send 1 "Domestica" monster from your Deck to the GY. You can only use each effect of "Domestica Kyrie" once per turn.

</details>

### 86. Ursarctic Leoship - 247831166

- **Source ordinal:** 85. **Script:** [`c247831166.lua`](<../public/CCG Downloads/CCG_Scripts/c247831166.lua>)
- **Problem/question to solve:** custom replacement integration.
- **Current audited implementation:** activation search; hand summon; replacement marker [implemented]. The file compiles and initializes; the open item is behavioral or interpretive, not a known load failure.
- **Manual review checklist:**
  1. Test the minimum, exact, and maximum legal materials/resources, plus one illegal candidate of each nearby type.
  2. Repeat with full Monster Zones, no Extra Monster Zone, Necrovalley where relevant, face-down banished cards, and a candidate leaving before resolution.
  3. Confirm the summon type, material reason, procedure completion, once-per-turn lock, cancel behavior, and future revival legality are all correct.
  4. Run the relevant GY branch both with and without Necrovalley, including activation legality and a Necrovalley effect appearing before resolution.
  5. Include face-up and face-down banished cards and confirm hidden cards are never selected unless the text explicitly permits them.
- **Acceptance condition:** Record the authoritative interpretation and an Omega replay/log showing the positive case, the closest illegal case, and any listed interruption case. The observed result must match the exact source sequence and leave no broader/narrower legal pool than intended.

<details>
<summary>Exact current source text</summary>

When this card is activated: You can add 1 "Ursarctic" card from your Deck to your hand. During your Main Phase: You can Special Summon 1 "Ursarctic" monster from your hand. If your "Ursarctic" monster would Tribute a monster(s) to activate its effect, you can banish 1 Level 7 or higher "Ursarctic" monster from your hand, field or GY instead. You can only use each effect of "Ursarctic Leoship" once per turn.

</details>

### 87. Ursarctic Octantis - 235051048

- **Source ordinal:** 86. **Script:** [`c235051048.lua`](<../public/CCG Downloads/CCG_Scripts/c235051048.lua>)
- **Problem/question to solve:** custom Synchro-style procedure.
- **Current audited implementation:** non-Synchro procedure; replacement Tribute summon; GY revival [implemented]. The file compiles and initializes; the open item is behavioral or interpretive, not a known load failure.
- **Manual review checklist:**
  1. Test the minimum, exact, and maximum legal materials/resources, plus one illegal candidate of each nearby type.
  2. Repeat with full Monster Zones, no Extra Monster Zone, Necrovalley where relevant, face-down banished cards, and a candidate leaving before resolution.
  3. Confirm the summon type, material reason, procedure completion, once-per-turn lock, cancel behavior, and future revival legality are all correct.
  4. Run the relevant GY branch both with and without Necrovalley, including activation legality and a Necrovalley effect appearing before resolution.
  5. Include face-up and face-down banished cards and confirm hidden cards are never selected unless the text explicitly permits them.
- **Acceptance condition:** Record the authoritative interpretation and an Omega replay/log showing the positive case, the closest illegal case, and any listed interruption case. The observed result must match the exact source sequence and leave no broader/narrower legal pool than intended.

<details>
<summary>Exact current source text</summary>

Cannot be Synchro Summoned. Must be Special Summoned (from your Extra Deck) by sending 2 monsters you control with a Level difference of 1 to the GY (1 Tuner and 1 non-Tuner). You can Tribute 1 Level 8 "Ursarctic" monster from your hand or field and this card; Special Summon 1 Level 7 "Ursarctic" Synchro Monster from your Extra Deck, ignoring its Summoning conditions. If an "Ursarctic" card you control is destroyed by battle or card effect: You can banish this card from your GY; Special Summon 1 "Ursarctic" monster from your hand or GY. You can only use this effect of "Ursarctic Octantis" once per turn.

</details>

### 88. Ursarctic Hextanius - 244921711

- **Source ordinal:** 87. **Script:** [`c244921711.lua`](<../public/CCG Downloads/CCG_Scripts/c244921711.lua>)
- **Problem/question to solve:** non-Synchro procedure; Deck summon; shuffle-draw with hidden banishment excluded [fixed].
- **Current audited implementation:** non-Synchro procedure; Deck summon; shuffle-draw with hidden banishment excluded [fixed]. The file compiles and initializes; the open item is behavioral or interpretive, not a known load failure.
- **Manual review checklist:**
  1. Test the minimum, exact, and maximum legal materials/resources, plus one illegal candidate of each nearby type.
  2. Repeat with full Monster Zones, no Extra Monster Zone, Necrovalley where relevant, face-down banished cards, and a candidate leaving before resolution.
  3. Confirm the summon type, material reason, procedure completion, once-per-turn lock, cancel behavior, and future revival legality are all correct.
  4. Run the relevant GY branch both with and without Necrovalley, including activation legality and a Necrovalley effect appearing before resolution.
  5. Include face-up and face-down banished cards and confirm hidden cards are never selected unless the text explicitly permits them.
- **Acceptance condition:** Record the authoritative interpretation and an Omega replay/log showing the positive case, the closest illegal case, and any listed interruption case. The observed result must match the exact source sequence and leave no broader/narrower legal pool than intended.

<details>
<summary>Exact current source text</summary>

Cannot be Synchro Summoned. Must be Special Summoned (from your Extra Deck) by sending 2 "Ursarctic" monsters you control with a Level difference of 6 to the GY. For the Special Summon of an "Ursarctic" Synchro Monster, this card can be treated as level 7 or 8 and can also be treated as a Non-Tuner. You can only use each of the following effects of "Ursarctic Hextanius" once per turn. If this card is Special Summoned: You can Special Summon 1 WATER Monster with either 700 ATK or 700 DEF from your Deck. You can banish this card from your GY; shuffle up to 3 other "Ursarctic" cards from your GY or banishment into the deck, then draw 1 card.

</details>

### 89. Ursarctic Nordbar - 249093610

- **Source ordinal:** 88. **Script:** [`c249093610.lua`](<../public/CCG Downloads/CCG_Scripts/c249093610.lua>)
- **Problem/question to solve:** custom procedure.
- **Current audited implementation:** non-Synchro procedure; revive/search; activation negate-destroy [implemented]. The file compiles and initializes; the open item is behavioral or interpretive, not a known load failure.
- **Manual review checklist:**
  1. Test the minimum, exact, and maximum legal materials/resources, plus one illegal candidate of each nearby type.
  2. Repeat with full Monster Zones, no Extra Monster Zone, Necrovalley where relevant, face-down banished cards, and a candidate leaving before resolution.
  3. Confirm the summon type, material reason, procedure completion, once-per-turn lock, cancel behavior, and future revival legality are all correct.
  4. Run the relevant GY branch both with and without Necrovalley, including activation legality and a Necrovalley effect appearing before resolution.
  5. Include a full-zone case and a case where paying the cost opens a zone; the UI must not reject a legal post-cost state or promise an impossible summon.
- **Acceptance condition:** Record the authoritative interpretation and an Omega replay/log showing the positive case, the closest illegal case, and any listed interruption case. The observed result must match the exact source sequence and leave no broader/narrower legal pool than intended.

<details>
<summary>Exact current source text</summary>

Cannot be Synchro Summoned. Must be Special Summoned (from your Extra Deck) by sending 2 monsters you control with a Level difference of 7 to the GY (1 Level 8 or higher Tuner and 1 non-Tuner Synchro Monster). You can only use each of the following effects of "Ursarctic Nordbar" once per turn. If this card is Special Summoned: You can Special Summon 1 "Ursarctic" monster from your GY. During your opponent's Standby Phase: You can add 1 "Ursarctic" monster from your Deck to your hand. When a card or effect is activated (Quick Effect): You can negate the activation, and if you do, destroy that card.

</details>

### 90. Branching to Guidance - 222257685

- **Source ordinal:** 90. **Script:** [`c222257685.lua`](<../public/CCG Downloads/CCG_Scripts/c222257685.lua>)
- **Problem/question to solve:** copied token identity/stats UI.
- **Current audited implementation:** hand reveal Token copy; GY target Token copy; helper row 222257686 verified. The file compiles and initializes; the open item is behavioral or interpretive, not a known load failure.
- **Manual review checklist:**
  1. Test the minimum, exact, and maximum legal materials/resources, plus one illegal candidate of each nearby type.
  2. Repeat with full Monster Zones, no Extra Monster Zone, Necrovalley where relevant, face-down banished cards, and a candidate leaving before resolution.
  3. Confirm the summon type, material reason, procedure completion, once-per-turn lock, cancel behavior, and future revival legality are all correct.
  4. Run the relevant GY branch both with and without Necrovalley, including activation legality and a Necrovalley effect appearing before resolution.
  5. Include face-up and face-down banished cards and confirm hidden cards are never selected unless the text explicitly permits them.
- **Acceptance condition:** Record the authoritative interpretation and an Omega replay/log showing the positive case, the closest illegal case, and any listed interruption case. The observed result must match the exact source sequence and leave no broader/narrower legal pool than intended.

<details>
<summary>Exact current source text</summary>

Reveal 1 monster in your hand that can be Normal Summoned/Set; Special Summon 1 "Guidance Token" in Defense Position, with the same Type, Attribute, Level, ATK, and DEF as the revealed monster, also, its name becomes the revealed monster's name in addition to its original name. You can banish this card from your GY, then target 1 monster in your GY that can be Normal Summoned/Set; Special Summon 1 "Guidance Token" in Defense Position, with the same Type, Attribute, Level, ATK, and DEF as the targeted monster, also, its name becomes the targeted monster's name in addition to its original name. You can only use 1 "Branching to Guidance" effect per turn, and only once that turn.

</details>

### 91. Onibi - 217713649

- **Source ordinal:** 105. **Script:** [`c217713649.lua`](<../public/CCG Downloads/CCG_Scripts/c217713649.lua>)
- **Problem/question to solve:** immediate Normal Summon UI.
- **Current audited implementation:** Spirit return and summon restriction; optional hand Tribute immediate Normal Summon/search [implemented]. The file compiles and initializes; the open item is behavioral or interpretive, not a known load failure.
- **Manual review checklist:**
  1. Test the minimum, exact, and maximum legal materials/resources, plus one illegal candidate of each nearby type.
  2. Repeat with full Monster Zones, no Extra Monster Zone, Necrovalley where relevant, face-down banished cards, and a candidate leaving before resolution.
  3. Confirm the summon type, material reason, procedure completion, once-per-turn lock, cancel behavior, and future revival legality are all correct.
  4. Include a full-zone case and a case where paying the cost opens a zone; the UI must not reject a legal post-cost state or promise an impossible summon.
  5. Attempt the effect/procedure twice and after a negated activation to confirm the intended card, effect, or oath count limit.
- **Acceptance condition:** Record the authoritative interpretation and an Omega replay/log showing the positive case, the closest illegal case, and any listed interruption case. The observed result must match the exact source sequence and leave no broader/narrower legal pool than intended.

<details>
<summary>Exact current source text</summary>

Cannot be Special Summoned. During the Main Phase (Quick Effect): You can also Tribute this card in your hand to activate this effect; immediately after this effect resolves, Normal Summon 1 Spirit monster, then, if you Normal Summoned "Onibi", you can add 1 Spirit monster from your Deck to your hand except "Onibi". If this card is not Tributed to activate this effect, you can only Normal Summon "Onibi" this way. You can only use the previous effect of "Onibi" once per turn. During the End Phase, if this card was Normal Summoned or flipped face-up this turn: Return this card to the hand.

</details>

### 92. Serene Mermaid of the Grand Blue - 259369909

- **Source ordinal:** 116. **Script:** [`c259369909.lua`](<../public/CCG Downloads/CCG_Scripts/c259369909.lua>)
- **Problem/question to solve:** hand summon; Fusion Summon; post-Fusion Extra Deck restriction approximated.
- **Current audited implementation:** hand summon; Fusion Summon; post-Fusion Extra Deck restriction approximated. The file compiles and initializes; the open item is behavioral or interpretive, not a known load failure.
- **Manual review checklist:**
  1. Test the minimum, exact, and maximum legal materials/resources, plus one illegal candidate of each nearby type.
  2. Repeat with full Monster Zones, no Extra Monster Zone, Necrovalley where relevant, face-down banished cards, and a candidate leaving before resolution.
  3. Confirm the summon type, material reason, procedure completion, once-per-turn lock, cancel behavior, and future revival legality are all correct.
  4. Include a full-zone case and a case where paying the cost opens a zone; the UI must not reject a legal post-cost state or promise an impossible summon.
  5. Attempt the effect/procedure twice and after a negated activation to confirm the intended card, effect, or oath count limit.
- **Acceptance condition:** Record the authoritative interpretation and an Omega replay/log showing the positive case, the closest illegal case, and any listed interruption case. The observed result must match the exact source sequence and leave no broader/narrower legal pool than intended.

<details>
<summary>Exact current source text</summary>

If you control a "Grand Blue" monster or "Umi": You can Special Summon this card from your hand. During the Main Phase: You can Fusion Summon 1 "Grand Blue" Fusion Monster from the Extra Deck, using monsters from your hand or field as Fusion Material, and if you do, for the rest of this turn, you can only Special Summon monsters from the Extra Deck using "Grand Blue" monsters as materials. You can only use each effect of "Serene Mermaid of the Grand Blue" once per turn.

</details>

### 93. Grand Blue Matriarch - 259093260

- **Source ordinal:** 123. **Script:** [`c259093260.lua`](<../public/CCG Downloads/CCG_Scripts/c259093260.lua>)
- **Problem/question to solve:** Synchro UI.
- **Current audited implementation:** Link-as-Level Synchro support; S/T activation negate; opponent-turn WATER revival [implemented]. The file compiles and initializes; the open item is behavioral or interpretive, not a known load failure.
- **Manual review checklist:**
  1. Test the minimum, exact, and maximum legal materials/resources, plus one illegal candidate of each nearby type.
  2. Repeat with full Monster Zones, no Extra Monster Zone, Necrovalley where relevant, face-down banished cards, and a candidate leaving before resolution.
  3. Confirm the summon type, material reason, procedure completion, once-per-turn lock, cancel behavior, and future revival legality are all correct.
  4. Run the relevant GY branch both with and without Necrovalley, including activation legality and a Necrovalley effect appearing before resolution.
  5. Include a full-zone case and a case where paying the cost opens a zone; the UI must not reject a legal post-cost state or promise an impossible summon.
- **Acceptance condition:** Record the authoritative interpretation and an Omega replay/log showing the positive case, the closest illegal case, and any listed interruption case. The observed result must match the exact source sequence and leave no broader/narrower legal pool than intended.

<details>
<summary>Exact current source text</summary>

1 Tuner + 1+ non-Tuner "Grand Blue" monsters\nFor this card's Synchro Summon, you can treat 1 Link monster you control as a Tuner with a Level equal to its Link Rating. When your opponent activates a Spell/Trap Card or effect (Quick Effect): You can Tribute 1 WATER monster you control; negate the activation, and if you do, destroy that card. During your opponent's turn, if a WATER monster you own is sent from your field to the GY: You can target that monster; Special Summon it in Defense Position. You can only use each effect of "Grand Blue Matriarch" once per turn.

</details>

### 94. Sacred Feather of Nephthys - 216532402

- **Source ordinal:** 127. **Script:** [`c216532402.lua`](<../public/CCG Downloads/CCG_Scripts/c216532402.lua>)
- **Problem/question to solve:** Ritual UI.
- **Current audited implementation:** Ritual procedure/Deck material; GY destroy-then-place; Conductor ID corrected to official 8454126 [fixed]. The file compiles and initializes; the open item is behavioral or interpretive, not a known load failure.
- **Manual review checklist:**
  1. Test the minimum, exact, and maximum legal materials/resources, plus one illegal candidate of each nearby type.
  2. Repeat with full Monster Zones, no Extra Monster Zone, Necrovalley where relevant, face-down banished cards, and a candidate leaving before resolution.
  3. Confirm the summon type, material reason, procedure completion, once-per-turn lock, cancel behavior, and future revival legality are all correct.
  4. Run the relevant GY branch both with and without Necrovalley, including activation legality and a Necrovalley effect appearing before resolution.
  5. Include face-up and face-down banished cards and confirm hidden cards are never selected unless the text explicitly permits them.
- **Acceptance condition:** Record the authoritative interpretation and an Omega replay/log showing the positive case, the closest illegal case, and any listed interruption case. The observed result must match the exact source sequence and leave no broader/narrower legal pool than intended.

<details>
<summary>Exact current source text</summary>

This card can be used to Ritual Summon any "Nephthys" Ritual Monster. You must also Tribute "Nephthys" monsters from your hand or field whose total Levels equal or exceed the Level of the Ritual Monster you Ritual Summon, or, if you do not control any monster, you can Tribute 1 "Nephthys" monster form your Deck instead. If a card is destroyed while you control "Conductor of Nephthys", Devotee of Nephthys" or "Priestess of Nephthys": You can banish this card from your GY; destroy 1 card you control, then, place 1 "Nephthys" Continuous Trap from your Deck face-up in your Spell & Trap Zone. You can only use the previous effect of Sacred Feather of Nephthys" once per turn.

</details>

### 95. Stellaer of the Frozen - 259581666

- **Source ordinal:** 128. **Script:** [`c259581666.lua`](<../public/CCG Downloads/CCG_Scripts/c259581666.lua>)
- **Problem/question to solve:** face-up S/T Set cases.
- **Current audited implementation:** alternate Xyz; both detach-and-Set branches; self-destroy draw [implemented]. The file compiles and initializes; the open item is behavioral or interpretive, not a known load failure.
- **Manual review checklist:**
  1. Test the minimum, exact, and maximum legal materials/resources, plus one illegal candidate of each nearby type.
  2. Repeat with full Monster Zones, no Extra Monster Zone, Necrovalley where relevant, face-down banished cards, and a candidate leaving before resolution.
  3. Confirm the summon type, material reason, procedure completion, once-per-turn lock, cancel behavior, and future revival legality are all correct.
  4. Include a full-zone case and a case where paying the cost opens a zone; the UI must not reject a legal post-cost state or promise an impossible summon.
  5. Remove or make the target unaffected before resolution and confirm no dependent action is performed from a stale target.
- **Acceptance condition:** Record the authoritative interpretation and an Omega replay/log showing the positive case, the closest illegal case, and any listed interruption case. The observed result must match the exact source sequence and leave no broader/narrower legal pool than intended.

<details>
<summary>Exact current source text</summary>

2 Level 9 Dragon monsters
If you control no Xyz Monsters, you can also Xyz Summon this card using 1 Level 9 "Stellaer" monster you control. During the Main Phase, or, if this card is Xyz Summoned: You can target 1 face-up card on the field and detach 2 materials from this card; Set that target. If this card has no materials: You can destroy this card, then draw 1 card.

</details>

### 96. Stellaer of the Plants - 259219942

- **Source ordinal:** 137. **Script:** [`c259219942.lua`](<../public/CCG Downloads/CCG_Scripts/c259219942.lua>)
- **Problem/question to solve:** overlay redirect UI.
- **Current audited implementation:** alternate summon; NATURE restriction polarity [fixed]; reattach-and-redirect [implemented]. The file compiles and initializes; the open item is behavioral or interpretive, not a known load failure.
- **Manual review checklist:**
  1. Test the minimum, exact, and maximum legal materials/resources, plus one illegal candidate of each nearby type.
  2. Repeat with full Monster Zones, no Extra Monster Zone, Necrovalley where relevant, face-down banished cards, and a candidate leaving before resolution.
  3. Confirm the summon type, material reason, procedure completion, once-per-turn lock, cancel behavior, and future revival legality are all correct.
  4. Include face-up and face-down banished cards and confirm hidden cards are never selected unless the text explicitly permits them.
  5. Include a full-zone case and a case where paying the cost opens a zone; the UI must not reject a legal post-cost state or promise an impossible summon.
- **Acceptance condition:** Record the authoritative interpretation and an Omega replay/log showing the positive case, the closest illegal case, and any listed interruption case. The observed result must match the exact source sequence and leave no broader/narrower legal pool than intended.

<details>
<summary>Exact current source text</summary>

If you control no monsters, or, if you control a Dragon Xyz monster, you can Special Summon this card from your hand. If you Special Summon this card this way, for the rest of this turn, you cannot Special Summon NATURE Monsters. If this card is detached from a "Stellaer" Xyz Monster to activate its effect: You can target 1 "Stellaer" Xyz monster you control; attach this card to it as material, but banish this card when it is detached. You can only use this effect of "Stellaer of the Plants" once per turn.

</details>

### 97. Stellaer of the Breeze - 230998543

- **Source ordinal:** 147. **Script:** [`c230998543.lua`](<../public/CCG Downloads/CCG_Scripts/c230998543.lua>)
- **Problem/question to solve:** Xyz UI.
- **Current audited implementation:** alternate summon/restriction; reveal, double summon and optional Xyz [implemented]. The file compiles and initializes; the open item is behavioral or interpretive, not a known load failure.
- **Manual review checklist:**
  1. Test the minimum, exact, and maximum legal materials/resources, plus one illegal candidate of each nearby type.
  2. Repeat with full Monster Zones, no Extra Monster Zone, Necrovalley where relevant, face-down banished cards, and a candidate leaving before resolution.
  3. Confirm the summon type, material reason, procedure completion, once-per-turn lock, cancel behavior, and future revival legality are all correct.
  4. Include a full-zone case and a case where paying the cost opens a zone; the UI must not reject a legal post-cost state or promise an impossible summon.
  5. Attempt the effect/procedure twice and after a negated activation to confirm the intended card, effect, or oath count limit.
- **Acceptance condition:** Record the authoritative interpretation and an Omega replay/log showing the positive case, the closest illegal case, and any listed interruption case. The observed result must match the exact source sequence and leave no broader/narrower legal pool than intended.

<details>
<summary>Exact current source text</summary>

If you control no monsters, or, if you control a Dragon Xyz monster, you can Special Summon this card from your hand. If you Special Summon this card this way, for the rest of this turn, you cannot Special Summon WIND Monsters. If this card is detached from a "Stellaer" Xyz Monster to activate its effect: You can reveal 1 "Stellaer" monster in your hand; Special Summon it and this card, then, immediately after this effect resolves, you can Xyz Summon 1 "Stellaer" Xyz Monster from your Extra Deck, using the two Special Summoned monsters. You can only use this effect of "Stellaer of the Breeze" once per turn.

</details>

### 98. Restoration of Azrynior - 236239443

- **Source ordinal:** 161. **Script:** [`c236239443.lua`](<../public/CCG Downloads/CCG_Scripts/c236239443.lua>)
- **Problem/question to solve:** multi-summon UI.
- **Current audited implementation:** destroyed-card tracker; named Token cost; pre-cost freed-zone target validation; mandatory group revival [implemented]. The file compiles and initializes; the open item is behavioral or interpretive, not a known load failure.
- **Manual review checklist:**
  1. Test the minimum, exact, and maximum legal materials/resources, plus one illegal candidate of each nearby type.
  2. Repeat with full Monster Zones, no Extra Monster Zone, Necrovalley where relevant, face-down banished cards, and a candidate leaving before resolution.
  3. Confirm the summon type, material reason, procedure completion, once-per-turn lock, cancel behavior, and future revival legality are all correct.
  4. Run the relevant GY branch both with and without Necrovalley, including activation legality and a Necrovalley effect appearing before resolution.
  5. Include a full-zone case and a case where paying the cost opens a zone; the UI must not reject a legal post-cost state or promise an impossible summon.
- **Acceptance condition:** Record the authoritative interpretation and an Omega replay/log showing the positive case, the closest illegal case, and any listed interruption case. The observed result must match the exact source sequence and leave no broader/narrower legal pool than intended.

<details>
<summary>Exact current source text</summary>

If you control "Azrynior, the Abundaence of Purity": You can Tribute 1 "Protogenic Essence Token", then target 1 monster in your GY that was destroyed by your opponent's card effect(s) this turn; Special Summon it and all other monsters in your GY that were destroyed by your opponent's card(s) this turn that have at least 1 of the same Type, Attribute, Level, ATK or DEF, as that target. You can only use this effect of "Restoration of Azrynior" once that turn.

</details>

### 99. Dominus Sentinel - 259290896

- **Source ordinal:** 169. **Script:** [`c259290896.lua`](<../public/CCG Downloads/CCG_Scripts/c259290896.lua>)
- **Problem/question to solve:** custom Attributes.
- **Current audited implementation:** hand activation; effect-negate then conditional destroy; permanent Attribute activation oath [implemented]. The file compiles and initializes; the open item is behavioral or interpretive, not a known load failure.
- **Manual review checklist:**
  1. Test the minimum, exact, and maximum legal materials/resources, plus one illegal candidate of each nearby type.
  2. Repeat with full Monster Zones, no Extra Monster Zone, Necrovalley where relevant, face-down banished cards, and a candidate leaving before resolution.
  3. Confirm the summon type, material reason, procedure completion, once-per-turn lock, cancel behavior, and future revival legality are all correct.
  4. Run the relevant GY branch both with and without Necrovalley, including activation legality and a Necrovalley effect appearing before resolution.
  5. Attempt the effect/procedure twice and after a negated activation to confirm the intended card, effect, or oath count limit.
- **Acceptance condition:** Record the authoritative interpretation and an Omega replay/log showing the positive case, the closest illegal case, and any listed interruption case. The observed result must match the exact source sequence and leave no broader/narrower legal pool than intended.

<details>
<summary>Exact current source text</summary>

If your opponent controls a card, you can activate this card from your hand. When a card or effect is activated that targets a card(s) you own: Negate that effect, then, if you have a Trap in your GY, destroy that card. If you activated this card from your hand, you cannot activate the effects of NATURE, ELECTRIC, METAL and ICE monsters for the rest of this Duel. You can only activate 1 "Dominus Sentinel" per turn.

</details>

### 100. Vir Pedicae Mortis - Fearless Hunter - 244778917

- **Source ordinal:** 187. **Script:** [`c244778917.lua`](<../public/CCG Downloads/CCG_Scripts/c244778917.lua>)
- **Problem/question to solve:** Printed "treated as 2 materials" for a named Link Summon is not implemented; official generic Link helpers expose no source-monster effect that safely changes material weight. Requires destination-procedure/ruling work.
- **Current audited implementation:** Printed "treated as 2 materials" for a named Link Summon is not implemented; official generic Link helpers expose no source-monster effect that safely changes material weight. Requires destination-procedure/ruling work. The file compiles and initializes; the open item is behavioral or interpretive, not a known load failure.
- **Manual review checklist:**
  1. Test the minimum, exact, and maximum legal materials/resources, plus one illegal candidate of each nearby type.
  2. Repeat with full Monster Zones, no Extra Monster Zone, Necrovalley where relevant, face-down banished cards, and a candidate leaving before resolution.
  3. Confirm the summon type, material reason, procedure completion, once-per-turn lock, cancel behavior, and future revival legality are all correct.
  4. Include a full-zone case and a case where paying the cost opens a zone; the UI must not reject a legal post-cost state or promise an impossible summon.
  5. Attempt the effect/procedure twice and after a negated activation to confirm the intended card, effect, or oath count limit.
- **Acceptance condition:** Record the authoritative interpretation and an Omega replay/log showing the positive case, the closest illegal case, and any listed interruption case. The observed result must match the exact source sequence and leave no broader/narrower legal pool than intended.

<details>
<summary>Exact current source text</summary>

If this card is Normal or Special Summoned: You can target 1 Spell/Trap your opponent controls; destroy it. You can only use this effect of "Vir Pedicae Mortis - Fearless Hunter" once per turn. This card can be treated as 2 materials, when you Link Summon a "Vir Pedicae Mortis" monster.

</details>

### 101. Bobbie Bluefin & the Nautical Nocturnes - 259114562

- **Source ordinal:** 201. **Script:** [`c259114562.lua`](<../public/CCG Downloads/CCG_Scripts/c259114562.lua>)
- **Problem/question to solve:** When both Normal and Special Summon are legal the script chooses Special Summon without an explicit player choice; confirm intended forced-summon choice semantics.
- **Current audited implementation:** When both Normal and Special Summon are legal the script chooses Special Summon without an explicit player choice; confirm intended forced-summon choice semantics. The file compiles and initializes; the open item is behavioral or interpretive, not a known load failure.
- **Manual review checklist:**
  1. Test the minimum, exact, and maximum legal materials/resources, plus one illegal candidate of each nearby type.
  2. Repeat with full Monster Zones, no Extra Monster Zone, Necrovalley where relevant, face-down banished cards, and a candidate leaving before resolution.
  3. Confirm the summon type, material reason, procedure completion, once-per-turn lock, cancel behavior, and future revival legality are all correct.
  4. Include a full-zone case and a case where paying the cost opens a zone; the UI must not reject a legal post-cost state or promise an impossible summon.
  5. Attempt the effect/procedure twice and after a negated activation to confirm the intended card, effect, or oath count limit.
- **Acceptance condition:** Record the authoritative interpretation and an Omega replay/log showing the positive case, the closest illegal case, and any listed interruption case. The observed result must match the exact source sequence and leave no broader/narrower legal pool than intended.

<details>
<summary>Exact current source text</summary>

Cannot be Normal Summoned/Set. If your opponent Normal or Special Summons a monster: You can Special Summon this card from your hand, then, immediately after this effect resolves, your opponent Normal or Special Summons 1 monster from their hand in Attack Position, but its ATK becomes 0, and if you do, if all monsters you control are "Nautica" monsters, negate its effects. You can only use this effect of "Bobbie Bluefin & the Nautical Nocturnes" once per turn.

</details>

### 102. Scarlet Seareef & the Nautical Creatures - 220749574

- **Source ordinal:** 202. **Script:** [`c220749574.lua`](<../public/CCG Downloads/CCG_Scripts/c220749574.lua>)
- **Problem/question to solve:** Forced summon branch choice and bottom-of-Deck ordering need in-engine/ruling confirmation.
- **Current audited implementation:** Forced summon branch choice and bottom-of-Deck ordering need in-engine/ruling confirmation. The file compiles and initializes; the open item is behavioral or interpretive, not a known load failure.
- **Manual review checklist:**
  1. Test the minimum, exact, and maximum legal materials/resources, plus one illegal candidate of each nearby type.
  2. Repeat with full Monster Zones, no Extra Monster Zone, Necrovalley where relevant, face-down banished cards, and a candidate leaving before resolution.
  3. Confirm the summon type, material reason, procedure completion, once-per-turn lock, cancel behavior, and future revival legality are all correct.
  4. Run the relevant GY branch both with and without Necrovalley, including activation legality and a Necrovalley effect appearing before resolution.
  5. Include a full-zone case and a case where paying the cost opens a zone; the UI must not reject a legal post-cost state or promise an impossible summon.
- **Acceptance condition:** Record the authoritative interpretation and an Omega replay/log showing the positive case, the closest illegal case, and any listed interruption case. The observed result must match the exact source sequence and leave no broader/narrower legal pool than intended.

<details>
<summary>Exact current source text</summary>

Cannot be Normal Summoned/Set. Must first be Special Summoned (from your hand) by placing 2 Aqua Monsters from your GY on the bottom of your Deck in any order. You can treat this card as a Level 1 monster when you Xyz Summon an Aqua monster. You can discard 1 card; shuffle this card from your hand into the Deck, then add 1 "Exploring the Nautical Waters" from your Deck to your hand. If this card is Special Summoned: You can draw 1 card, then, immediately after this effect resolves, your opponent Normal or Special Summons 1 monster from their hand in Attack Position, but its ATK becomes 0.

</details>

### 103. Evander Coldwater & the Nautical Abyss - 225109525

- **Source ordinal:** 203. **Script:** [`c225109525.lua`](<../public/CCG Downloads/CCG_Scripts/c225109525.lua>)
- **Problem/question to solve:** Returned monster can become eligible for the subsequent forced summon; confirm that this matches intended sequencing.
- **Current audited implementation:** Returned monster can become eligible for the subsequent forced summon; confirm that this matches intended sequencing. The file compiles and initializes; the open item is behavioral or interpretive, not a known load failure.
- **Manual review checklist:**
  1. Test the minimum, exact, and maximum legal materials/resources, plus one illegal candidate of each nearby type.
  2. Repeat with full Monster Zones, no Extra Monster Zone, Necrovalley where relevant, face-down banished cards, and a candidate leaving before resolution.
  3. Confirm the summon type, material reason, procedure completion, once-per-turn lock, cancel behavior, and future revival legality are all correct.
  4. Include a full-zone case and a case where paying the cost opens a zone; the UI must not reject a legal post-cost state or promise an impossible summon.
  5. Attempt the effect/procedure twice and after a negated activation to confirm the intended card, effect, or oath count limit.
- **Acceptance condition:** Record the authoritative interpretation and an Omega replay/log showing the positive case, the closest illegal case, and any listed interruption case. The observed result must match the exact source sequence and leave no broader/narrower legal pool than intended.

<details>
<summary>Exact current source text</summary>

2+ Level 1 Aqua monsters
Gains 500 ATK for each "Nautica" card attached to it as Xyz Material. Once per turn (Quick Effect): You can detach 1 material from this card, then target 1 monster your opponent controls; return it to the hand, then, immediately after this effect resolves, your opponent Normal or Special Summons 1 monster from their hand in Attack Position, but its ATK becomes 0.

</details>

### 104. Nautical Backwashing & Oceanic Waves - 223158720

- **Source ordinal:** 204. **Script:** [`c223158720.lua`](<../public/CCG Downloads/CCG_Scripts/c223158720.lua>)
- **Problem/question to solve:** Forced Normal/Special Summon selection defaults to Special when both are legal; printed choice semantics need confirmation.
- **Current audited implementation:** Forced Normal/Special Summon selection defaults to Special when both are legal; printed choice semantics need confirmation. The file compiles and initializes; the open item is behavioral or interpretive, not a known load failure.
- **Manual review checklist:**
  1. Test the minimum, exact, and maximum legal materials/resources, plus one illegal candidate of each nearby type.
  2. Repeat with full Monster Zones, no Extra Monster Zone, Necrovalley where relevant, face-down banished cards, and a candidate leaving before resolution.
  3. Confirm the summon type, material reason, procedure completion, once-per-turn lock, cancel behavior, and future revival legality are all correct.
  4. Run the relevant GY branch both with and without Necrovalley, including activation legality and a Necrovalley effect appearing before resolution.
  5. Include face-up and face-down banished cards and confirm hidden cards are never selected unless the text explicitly permits them.
- **Acceptance condition:** Record the authoritative interpretation and an Omega replay/log showing the positive case, the closest illegal case, and any listed interruption case. The observed result must match the exact source sequence and leave no broader/narrower legal pool than intended.

<details>
<summary>Exact current source text</summary>

Target 1 "Nautica" monster in your GY; return that target to the hand, then, immediately after this effect resolves, your opponent Normal or Special Summons 1 monster from their hand in Attack Position, but its ATK becomes 0. You can banish this card from your GY; place 3 Aqua monsters from your GY on the bottom of your Deck in any order, then draw 1 card. You can only use 1 effect of "Nautical Backwashing & Oceanic Waves" per turn and only once that turn.

</details>

### 105. Exploring the Nautical Waters - 248946297

- **Source ordinal:** 206. **Script:** [`c248946297.lua`](<../public/CCG Downloads/CCG_Scripts/c248946297.lua>)
- **Problem/question to solve:** Forced summon branch and bottom-deck order need an engine/ruling test.
- **Current audited implementation:** Forced summon branch and bottom-deck order need an engine/ruling test. The file compiles and initializes; the open item is behavioral or interpretive, not a known load failure.
- **Manual review checklist:**
  1. Test the minimum, exact, and maximum legal materials/resources, plus one illegal candidate of each nearby type.
  2. Repeat with full Monster Zones, no Extra Monster Zone, Necrovalley where relevant, face-down banished cards, and a candidate leaving before resolution.
  3. Confirm the summon type, material reason, procedure completion, once-per-turn lock, cancel behavior, and future revival legality are all correct.
  4. Include a full-zone case and a case where paying the cost opens a zone; the UI must not reject a legal post-cost state or promise an impossible summon.
  5. Use distinguishable cards to verify exact top/bottom ordering and what happens to every card not added or summoned.
- **Acceptance condition:** Record the authoritative interpretation and an Omega replay/log showing the positive case, the closest illegal case, and any listed interruption case. The observed result must match the exact source sequence and leave no broader/narrower legal pool than intended.

<details>
<summary>Exact current source text</summary>

Add 1 "Nautica" monster from your Deck to your hand, then, immediately after this effect resolves, your opponent Normal or Special Summons 1 monster from their hand or Deck in Attack Position, but its ATK becomes 0, then, if that monster was Special Summoned from the Deck this way, negate its effects. You cannot Special Summon monsters the turn you use this effect, except WATER Monsters. You can only activate 1 "Exploring the Nautical Waters" per turn.

</details>

### 106. Nautical Adventures & Torrential Seas - 218905439

- **Source ordinal:** 207. **Script:** [`c218905439.lua`](<../public/CCG Downloads/CCG_Scripts/c218905439.lua>)
- **Problem/question to solve:** A returned monster may be eligible for the subsequent forced summon; confirm intended pool and branch choice.
- **Current audited implementation:** A returned monster may be eligible for the subsequent forced summon; confirm intended pool and branch choice. The file compiles and initializes; the open item is behavioral or interpretive, not a known load failure.
- **Manual review checklist:**
  1. Test the minimum, exact, and maximum legal materials/resources, plus one illegal candidate of each nearby type.
  2. Repeat with full Monster Zones, no Extra Monster Zone, Necrovalley where relevant, face-down banished cards, and a candidate leaving before resolution.
  3. Confirm the summon type, material reason, procedure completion, once-per-turn lock, cancel behavior, and future revival legality are all correct.
  4. Run the relevant GY branch both with and without Necrovalley, including activation legality and a Necrovalley effect appearing before resolution.
  5. Include face-up and face-down banished cards and confirm hidden cards are never selected unless the text explicitly permits them.
- **Acceptance condition:** Record the authoritative interpretation and an Omega replay/log showing the positive case, the closest illegal case, and any listed interruption case. The observed result must match the exact source sequence and leave no broader/narrower legal pool than intended.

<details>
<summary>Exact current source text</summary>

Target 1 "Nautica" monster you control and 1 monster your opponent controls; return those targets to the hand, then, immediately after this effect resolves, your opponent Normal or Special Summons 1 monster from their hand in Attack Position, but its ATK is becomes 0. If your WATER Monster is Xyz Summoned while this card is in the GY: You can attach this card to it as Xyz material, but banish this card when detached. You can only use each effect of "Nautical Adventures & Torrential Seas" once per turn.

</details>

### 107. Bob, but Stronger! - 259944943

- **Source ordinal:** 209. **Script:** [`c259944943.lua`](<../public/CCG Downloads/CCG_Scripts/c259944943.lua>)
- **Problem/question to solve:** Fixed contact-Fusion material search from LOCATION_MZONE to official LOCATION_ONFIELD; live test still required to confirm Omega permits the "Umi" Spell to pass Fusion-material legality.
- **Current audited implementation:** Fixed contact-Fusion material search from LOCATION_MZONE to official LOCATION_ONFIELD; live test still required to confirm Omega permits the "Umi" Spell to pass Fusion-material legality. The file compiles and initializes; the open item is behavioral or interpretive, not a known load failure.
- **Manual review checklist:**
  1. Test the minimum, exact, and maximum legal materials/resources, plus one illegal candidate of each nearby type.
  2. Repeat with full Monster Zones, no Extra Monster Zone, Necrovalley where relevant, face-down banished cards, and a candidate leaving before resolution.
  3. Confirm the summon type, material reason, procedure completion, once-per-turn lock, cancel behavior, and future revival legality are all correct.
  4. Run the relevant GY branch both with and without Necrovalley, including activation legality and a Necrovalley effect appearing before resolution.
  5. Include a full-zone case and a case where paying the cost opens a zone; the UI must not reject a legal post-cost state or promise an impossible summon.
- **Acceptance condition:** Record the authoritative interpretation and an Omega replay/log showing the positive case, the closest illegal case, and any listed interruption case. The observed result must match the exact source sequence and leave no broader/narrower legal pool than intended.

<details>
<summary>Exact current source text</summary>

"Bob" + 1 "Umi"
Must first be Special Summoned (from your Extra Deck) by sending the above cards you control to the GY (You do not use "Polymerization".) You can only control 1 "Bob, but Stronger!". Can attack all monsters your opponent controls, once each. Your "Bob" and monsters that mention it can attack while in face-up Defense Position. If they do, apply their DEF for damage calculation. If this card attacks a Defense Position monster, inflict double piercing battle damage to your opponent.

</details>

### 108. Windborne Eye of the Storm - 256110263

- **Source ordinal:** 237. **Script:** [`c256110263.lua`](<../public/CCG Downloads/CCG_Scripts/c256110263.lua>)
- **Problem/question to solve:** The script uses a temporary synthetic Token material to emulate "treated as a Synchro Summon using only Windborne"; this bespoke engine workaround needs live validation.
- **Current audited implementation:** The script uses a temporary synthetic Token material to emulate "treated as a Synchro Summon using only Windborne"; this bespoke engine workaround needs live validation. The file compiles and initializes; the open item is behavioral or interpretive, not a known load failure.
- **Manual review checklist:**
  1. Test the minimum, exact, and maximum legal materials/resources, plus one illegal candidate of each nearby type.
  2. Repeat with full Monster Zones, no Extra Monster Zone, Necrovalley where relevant, face-down banished cards, and a candidate leaving before resolution.
  3. Confirm the summon type, material reason, procedure completion, once-per-turn lock, cancel behavior, and future revival legality are all correct.
  4. Include face-up and face-down banished cards and confirm hidden cards are never selected unless the text explicitly permits them.
  5. Include a full-zone case and a case where paying the cost opens a zone; the UI must not reject a legal post-cost state or promise an impossible summon.
- **Acceptance condition:** Record the authoritative interpretation and an Omega replay/log showing the positive case, the closest illegal case, and any listed interruption case. The observed result must match the exact source sequence and leave no broader/narrower legal pool than intended.

<details>
<summary>Exact current source text</summary>

Target 1 monster you control; banish it until the End Phase, then, if you added 3 or more "Windborne" cards from your Deck to your hand this turn, and you banished a WIND Synchro Monster by this effect, you can Special Summon 1 "Windborne" Synchro Monster with a different name from your Extra Deck (this is treated as a Synchro Summon using only "Windborne" monsters).

</details>

### 109. Ohmen Powerload - 259434499

- **Source ordinal:** 306. **Script:** [`c259434499.lua`](<../public/CCG Downloads/CCG_Scripts/c259434499.lua>)
- **Problem/question to solve:** Added the official retroactive Thunder-only Special Summon activity lock. Custom optional counter removal/destruction branch needs UI validation.
- **Current audited implementation:** Added the official retroactive Thunder-only Special Summon activity lock. Custom optional counter removal/destruction branch needs UI validation. The file compiles and initializes; the open item is behavioral or interpretive, not a known load failure.
- **Manual review checklist:**
  1. Test the minimum, exact, and maximum legal materials/resources, plus one illegal candidate of each nearby type.
  2. Repeat with full Monster Zones, no Extra Monster Zone, Necrovalley where relevant, face-down banished cards, and a candidate leaving before resolution.
  3. Confirm the summon type, material reason, procedure completion, once-per-turn lock, cancel behavior, and future revival legality are all correct.
  4. Include a full-zone case and a case where paying the cost opens a zone; the UI must not reject a legal post-cost state or promise an impossible summon.
  5. Remove or make the target unaffected before resolution and confirm no dependent action is performed from a stale target.
- **Acceptance condition:** Record the authoritative interpretation and an Omega replay/log showing the positive case, the closest illegal case, and any listed interruption case. The observed result must match the exact source sequence and leave no broader/narrower legal pool than intended.

<details>
<summary>Exact current source text</summary>

Activate 1 of these effects;
 Target 1 Effect Monster your opponent controls; negate its effects, then you can remove 2 Current Counters from the field, and if you do destroy 1 card your opponents controls.
 Special Summon 1 "Ohmen" monster from your Deck.
You can only activate 1 "Ohmen Powerload" per turn, and if you do, you cannot Special Summon monsters, except Thunder monsters.

</details>

### 110. Phlogistic Uprising! - 257239133

- **Source ordinal:** 321. **Script:** [`c257239133.lua`](<../public/CCG Downloads/CCG_Scripts/c257239133.lua>)
- **Problem/question to solve:** Excluded illegal LP payments that would reduce LP below the engine minimum. Fusion Summon from GY/Extra with mixed send/shuffle materials is custom and needs live validation.
- **Current audited implementation:** Excluded illegal LP payments that would reduce LP below the engine minimum. Fusion Summon from GY/Extra with mixed send/shuffle materials is custom and needs live validation. The file compiles and initializes; the open item is behavioral or interpretive, not a known load failure.
- **Manual review checklist:**
  1. Test the minimum, exact, and maximum legal materials/resources, plus one illegal candidate of each nearby type.
  2. Repeat with full Monster Zones, no Extra Monster Zone, Necrovalley where relevant, face-down banished cards, and a candidate leaving before resolution.
  3. Confirm the summon type, material reason, procedure completion, once-per-turn lock, cancel behavior, and future revival legality are all correct.
  4. Run the relevant GY branch both with and without Necrovalley, including activation legality and a Necrovalley effect appearing before resolution.
  5. Include face-up and face-down banished cards and confirm hidden cards are never selected unless the text explicitly permits them.
- **Acceptance condition:** Record the authoritative interpretation and an Omega replay/log showing the positive case, the closest illegal case, and any listed interruption case. The observed result must match the exact source sequence and leave no broader/narrower legal pool than intended.

<details>
<summary>Exact current source text</summary>

Fusion Summon 1 FIRE Dragon monster from your GY or Extra Deck, using monsters from your hand or field as Fusion Material and/or by shuffling the required Fusion Materials into the Deck, from your monsters in the GY, then pay any number of LP in multiples of 300. You can only use the following effect of "Phlogistic Uprising!" once per turn. You can shuffle 1 "Phlogiston Dragon" from your GY into the Deck; Set this card from your GY to your field, but banish it when it leaves the field.

</details>

### 111. Chamroshes' Aegis - 221924008

- **Source ordinal:** 330. **Script:** [`c221924008.lua`](<../public/CCG Downloads/CCG_Scripts/c221924008.lua>)
- **Problem/question to solve:** Contact-style Extra Deck summon by shuffling three differently named Tuners needs procedure validation.
- **Current audited implementation:** Contact-style Extra Deck summon by shuffling three differently named Tuners needs procedure validation. The file compiles and initializes; the open item is behavioral or interpretive, not a known load failure.
- **Manual review checklist:**
  1. Test the minimum, exact, and maximum legal materials/resources, plus one illegal candidate of each nearby type.
  2. Repeat with full Monster Zones, no Extra Monster Zone, Necrovalley where relevant, face-down banished cards, and a candidate leaving before resolution.
  3. Confirm the summon type, material reason, procedure completion, once-per-turn lock, cancel behavior, and future revival legality are all correct.
  4. Run the relevant GY branch both with and without Necrovalley, including activation legality and a Necrovalley effect appearing before resolution.
  5. Include face-up and face-down banished cards and confirm hidden cards are never selected unless the text explicitly permits them.
- **Acceptance condition:** Record the authoritative interpretation and an Omega replay/log showing the positive case, the closest illegal case, and any listed interruption case. The observed result must match the exact source sequence and leave no broader/narrower legal pool than intended.

<details>
<summary>Exact current source text</summary>

3 Level 3 or lower Tuners with different names
Must first be Special Summoned (from your Extra Deck) by shuffling the above cards from your GY or banishment into the Deck. (You do not use "Polymerization".) If Summoned this way, you cannot Special Summon monsters from the Extra Deck for the rest of this turn, except Synchro Monsters. You can only use each of the following effects of "Chamroses' Aegis" once per turn. When this card is Special Summoned: You can Special Summon 1 Level 2 Tuner Synchro Monster from your Extra Deck (but banish it when it leaves the field), also, if that monster would be used as Synchro Material, you can treat it as a non-Tuner. If this card is sent to the GY: You can change the battle position of up to 3 monsters on the field.

</details>

### 112. Ghoti from a Deeper Depth Than the Deepest Deep - 240575550

- **Source ordinal:** 370. **Script:** [`c240575550.lua`](<../public/CCG Downloads/CCG_Scripts/c240575550.lua>)
- **Problem/question to solve:** Custom Synchro material rule allowing a Fish Tuner as non-Tuner needs live validation.
- **Current audited implementation:** Custom Synchro material rule allowing a Fish Tuner as non-Tuner needs live validation. The file compiles and initializes; the open item is behavioral or interpretive, not a known load failure.
- **Manual review checklist:**
  1. Test the minimum, exact, and maximum legal materials/resources, plus one illegal candidate of each nearby type.
  2. Repeat with full Monster Zones, no Extra Monster Zone, Necrovalley where relevant, face-down banished cards, and a candidate leaving before resolution.
  3. Confirm the summon type, material reason, procedure completion, once-per-turn lock, cancel behavior, and future revival legality are all correct.
  4. Run the relevant GY branch both with and without Necrovalley, including activation legality and a Necrovalley effect appearing before resolution.
  5. Include face-up and face-down banished cards and confirm hidden cards are never selected unless the text explicitly permits them.
- **Acceptance condition:** Record the authoritative interpretation and an Omega replay/log showing the positive case, the closest illegal case, and any listed interruption case. The observed result must match the exact source sequence and leave no broader/narrower legal pool than intended.

<details>
<summary>Exact current source text</summary>

1 Fish Tuner + 1 or more non-Tuner monsters
You can treat 1 Fish Tuner you control as a non-Tuner for the Synchro Summon of this card. The original ATK of this card becomes 500 times the number of banished cards. If this card is Synchro Summoned: You can banish as many cards as possible from both GYs. (Quick Effect): You can banish 1 Fish monster from your hand, field or GY; Set 1 "Ghoti" Trap from your Deck or banishment. If you banished a Fish Synchro Monster this turn, it can be activated this turn. You can only use each effect of "Ghoti from a Deeper Depth than the Deepest Deep" once per turn.

</details>

### 113. Pumpqueen the Queen of Ghosts - 259308265

- **Source ordinal:** 374. **Script:** [`c259308265.lua`](<../public/CCG Downloads/CCG_Scripts/c259308265.lua>)
- **Problem/question to solve:** The extra Normal Summon is implemented, but hand Tributes for Castle of Dark Illusions need a ruling/engine implementation.
- **Current audited implementation:** The extra Normal Summon is implemented, but hand Tributes for Castle of Dark Illusions need a ruling/engine implementation. The file compiles and initializes; the open item is behavioral or interpretive, not a known load failure.
- **Manual review checklist:**
  1. Test the minimum, exact, and maximum legal materials/resources, plus one illegal candidate of each nearby type.
  2. Repeat with full Monster Zones, no Extra Monster Zone, Necrovalley where relevant, face-down banished cards, and a candidate leaving before resolution.
  3. Confirm the summon type, material reason, procedure completion, once-per-turn lock, cancel behavior, and future revival legality are all correct.
  4. Include a full-zone case and a case where paying the cost opens a zone; the UI must not reject a legal post-cost state or promise an impossible summon.
  5. Attempt the effect/procedure twice and after a negated activation to confirm the intended card, effect, or oath count limit.
- **Acceptance condition:** Record the authoritative interpretation and an Omega replay/log showing the positive case, the closest illegal case, and any listed interruption case. The observed result must match the exact source sequence and leave no broader/narrower legal pool than intended.

<details>
<summary>Exact current source text</summary>

If you control "Pumpking the King of Ghosts": You can Special Summon this card from your hand, then add 1 "Castle of Dark Illusions" from your Deck to your hand. You can Normal Summon it in addition to your Normal Summon/Set this turn, also you can use monsters from your hand as Tribute for its Normal Summon. You can only use this effect of "Pumpqueen the Queen of Ghosts" once per turn.

</details>

### 114. Ghostrick Oni - 239335848

- **Source ordinal:** 404. **Script:** [`c239335848.lua`](<../public/CCG Downloads/CCG_Scripts/c239335848.lua>)
- **Problem/question to solve:** Custom Xyz material transfer/Quick conversion.
- **Current audited implementation:** Custom Xyz material transfer/Quick conversion. The file compiles and initializes; the open item is behavioral or interpretive, not a known load failure.
- **Manual review checklist:**
  1. Test the minimum, exact, and maximum legal materials/resources, plus one illegal candidate of each nearby type.
  2. Repeat with full Monster Zones, no Extra Monster Zone, Necrovalley where relevant, face-down banished cards, and a candidate leaving before resolution.
  3. Confirm the summon type, material reason, procedure completion, once-per-turn lock, cancel behavior, and future revival legality are all correct.
  4. Run the relevant GY branch both with and without Necrovalley, including activation legality and a Necrovalley effect appearing before resolution.
  5. Include a full-zone case and a case where paying the cost opens a zone; the UI must not reject a legal post-cost state or promise an impossible summon.
- **Acceptance condition:** Record the authoritative interpretation and an Omega replay/log showing the positive case, the closest illegal case, and any listed interruption case. The observed result must match the exact source sequence and leave no broader/narrower legal pool than intended.

<details>
<summary>Exact current source text</summary>

2+ Level 1 monsters, including a "Ghostrick" monster
Gains 200 DEF for each "Ghostrick" card in your GY. During your opponent's turn (Quick Effect): You can attach 1 "Ghostrick" card from your Deck to this card, and if you do, immediately after this effect resolves Xyz Summon 1 Rank 3 or lower "Ghostrick" monster you control using this card as material (transfer this card's materials to that monster), also, it can activate its effects as Quick Effects this turn. If this card is sent to the GY: You can target 1 "Ghostrick" monster you control or in your GY; monsters your opponent controls lose ATK equal to the ATK of that monster.

</details>

### 115. Gravinity Spherix - 231088629

- **Source ordinal:** 435. **Script:** [`c231088629.lua`](<../public/CCG Downloads/CCG_Scripts/c231088629.lua>)
- **Problem/question to solve:** Summon replacement plus minimum GY Xyz material.
- **Current audited implementation:** Summon replacement plus minimum GY Xyz material. The file compiles and initializes; the open item is behavioral or interpretive, not a known load failure.
- **Manual review checklist:**
  1. Test the minimum, exact, and maximum legal materials/resources, plus one illegal candidate of each nearby type.
  2. Repeat with full Monster Zones, no Extra Monster Zone, Necrovalley where relevant, face-down banished cards, and a candidate leaving before resolution.
  3. Confirm the summon type, material reason, procedure completion, once-per-turn lock, cancel behavior, and future revival legality are all correct.
  4. Run the relevant GY branch both with and without Necrovalley, including activation legality and a Necrovalley effect appearing before resolution.
  5. Include a full-zone case and a case where paying the cost opens a zone; the UI must not reject a legal post-cost state or promise an impossible summon.
- **Acceptance condition:** Record the authoritative interpretation and an Omega replay/log showing the positive case, the closest illegal case, and any listed interruption case. The observed result must match the exact source sequence and leave no broader/narrower legal pool than intended.

<details>
<summary>Exact current source text</summary>

1 "Gravinity" Tuner + 1+ Cyberse Synchro Monsters
This card's Synchro Summon cannot be negated. If a player would Normal or Special Summon a monster (except from the Spell & Trap Zone), place that monster face-up in its owner's Spell & Trap Zone as a Continuous Trap instead, and if you do, it gains the following effect (even if this card leaves the field).
 During the Main Phase, if this card is a Continuous Trap: You can Special Summon this card, ignoring its summoning conditions, then, if this card is an Xyz Monster, you can attach the minimum number of monsters that can be used for this card's Xyz Summon from your GY to this card as material.
Each time a Monster Card is Special Summoned from the Spell/Trap Zone, place 1 Gravity Counter on this card (max. 2). (Quick Effect): You can remove 2 Gravity Counters from this card; shuffle 1 monster your opponent controls and 1 "Gravinity" Monster Card in the same column into their owners' Deck/Extra Deck.

</details>

## Other custom engine behavior

### 116. The Hanging Frute - 213266433

- **Source ordinal:** 56. **Script:** [`c213266433.lua`](<../public/CCG Downloads/CCG_Scripts/c213266433.lua>)
- **Problem/question to solve:** attack-all approximation; temporary protection [manual].
- **Current audited implementation:** attack-all approximation; temporary protection [manual]. The file compiles and initializes; the open item is behavioral or interpretive, not a known load failure.
- **Manual review checklist:**
  1. Create one clearly legal state and one boundary-illegal state for every clause named in the audit finding.
  2. Test activation, target selection, resolution after the subject leaves or becomes unaffected, and all printed success-gated follow-ups.
  3. Record whether the discrepancy is an engine limitation, a script defect, or a wording decision; close it only after choosing the intended behavior.
  4. Run the relevant GY branch both with and without Necrovalley, including activation legality and a Necrovalley effect appearing before resolution.
  5. Include a full-zone case and a case where paying the cost opens a zone; the UI must not reject a legal post-cost state or promise an impossible summon.
- **Acceptance condition:** Record the authoritative interpretation and an Omega replay/log showing the positive case, the closest illegal case, and any listed interruption case. The observed result must match the exact source sequence and leave no broader/narrower legal pool than intended.

<details>
<summary>Exact current source text</summary>

You can Ritual Summon this card with "Fruteification". "Frute" monsters you control can attack all face-down Defense Position monsters your opponent controls, once each. You can only use each of the following effects of "The Hanging Frute" once per turn. If this card is Special Summoned: You can Special Summon 1 "Frute" monster from your GY in face-down Defense Position. When your opponent activates a card or effect (Quick Effect): You can Tribute 1 other WATER monster from your hand or field; for the rest of this turn, monsters you control are unaffected by effects previously activated in this Chain, then, if you activated this effect in response to an opponent's monster effect on the field, change it to face-down Defense Position.

</details>

### 117. Sacred Treasure - Chunyin - 229499914

- **Source ordinal:** 60. **Script:** [`c229499914.lua`](<../public/CCG Downloads/CCG_Scripts/c229499914.lua>)
- **Problem/question to solve:** banish trigger; face-up banished add filter [fixed].
- **Current audited implementation:** banish trigger; face-up banished add filter [fixed]. The file compiles and initializes; the open item is behavioral or interpretive, not a known load failure.
- **Manual review checklist:**
  1. Create one clearly legal state and one boundary-illegal state for every clause named in the audit finding.
  2. Test activation, target selection, resolution after the subject leaves or becomes unaffected, and all printed success-gated follow-ups.
  3. Record whether the discrepancy is an engine limitation, a script defect, or a wording decision; close it only after choosing the intended behavior.
  4. Include face-up and face-down banished cards and confirm hidden cards are never selected unless the text explicitly permits them.
- **Acceptance condition:** Record the authoritative interpretation and an Omega replay/log showing the positive case, the closest illegal case, and any listed interruption case. The observed result must match the exact source sequence and leave no broader/narrower legal pool than intended.

<details>
<summary>Exact current source text</summary>

If you control a "NiuHao" monster, apply 1 of these effects.\n Change 1 monster on the field to to face-down Defense Position.\n Banish 2 "NiuHao" monsters with different names from your deck.\nIf this card and another "Sacred Treasure" card is banished: You can add 1 card from your banishment to your hand.\nYou can only activate 1 "Sacred Treasure Chunyin" per turn.

</details>

### 118. City Within the Grand Blue - 259679619

- **Source ordinal:** 120. **Script:** [`c259679619.lua`](<../public/CCG Downloads/CCG_Scripts/c259679619.lua>)
- **Problem/question to solve:** runtime alias.
- **Current audited implementation:** runtime Umi code; optional activation search; original-WATER GY aura [implemented]. The file compiles and initializes; the open item is behavioral or interpretive, not a known load failure.
- **Manual review checklist:**
  1. Create one clearly legal state and one boundary-illegal state for every clause named in the audit finding.
  2. Test activation, target selection, resolution after the subject leaves or becomes unaffected, and all printed success-gated follow-ups.
  3. Record whether the discrepancy is an engine limitation, a script defect, or a wording decision; close it only after choosing the intended behavior.
  4. Run the relevant GY branch both with and without Necrovalley, including activation legality and a Necrovalley effect appearing before resolution.
- **Acceptance condition:** Record the authoritative interpretation and an Omega replay/log showing the positive case, the closest illegal case, and any listed interruption case. The observed result must match the exact source sequence and leave no broader/narrower legal pool than intended.

<details>
<summary>Exact current source text</summary>

(This card is always treated as "Umi".)\nWhen this card is activated: You can add 1 "Grand Blue" monster from your Deck or GY to your hand. If all monsters you control are originally WATER monsters, all monsters in the GYs become WATER monsters. You can only activate 1 "City within the Grand Blue" per turn.

</details>

### 119. Volt, the Ohmechanic Chocker - 259519336

- **Source ordinal:** 302. **Script:** [`c259519336.lua`](<../public/CCG Downloads/CCG_Scripts/c259519336.lua>)
- **Problem/question to solve:** Moved all-counter payment to cost and made the destruction correctly non-targeting. Custom counter-threshold continuous/Quick interaction needs live validation after the confirmed fixes.
- **Current audited implementation:** Moved all-counter payment to cost and made the destruction correctly non-targeting. Custom counter-threshold continuous/Quick interaction needs live validation after the confirmed fixes. The file compiles and initializes; the open item is behavioral or interpretive, not a known load failure.
- **Manual review checklist:**
  1. Create one clearly legal state and one boundary-illegal state for every clause named in the audit finding.
  2. Test activation, target selection, resolution after the subject leaves or becomes unaffected, and all printed success-gated follow-ups.
  3. Record whether the discrepancy is an engine limitation, a script defect, or a wording decision; close it only after choosing the intended behavior.
  4. Attempt the effect/procedure twice and after a negated activation to confirm the intended card, effect, or oath count limit.
  5. Remove or make the target unaffected before resolution and confirm no dependent action is performed from a stale target.
- **Acceptance condition:** Record the authoritative interpretation and an Omega replay/log showing the positive case, the closest illegal case, and any listed interruption case. The observed result must match the exact source sequence and leave no broader/narrower legal pool than intended.

<details>
<summary>Exact current source text</summary>

2 monsters including an "Ohmen" monster
This card's ATK becomes 0 while it has no Current Counters on it. This card gains the following effects based on the number of Current Counters on it:
1+: During your Main Phase: You can remove all Current Counters on this card; inflict 300 damage to your opponent for each.
2+: "Ohmechanic" monsters you control gain 500 ATK.
3+: During the Main Phase (Quick Effect): You can destroy 1 monster your opponent controls.
You can only use each effect of "Volt, the Ohmechanic Chocker" once per turn.

</details>

### 120. Urphiel, the High Arckcestial - 215105971

- **Source ordinal:** 353. **Script:** [`c215105971.lua`](<../public/CCG Downloads/CCG_Scripts/c215105971.lua>)
- **Problem/question to solve:** Optional destruction replacement and owner-control leave-field trigger need live validation.
- **Current audited implementation:** Optional destruction replacement and owner-control leave-field trigger need live validation. The file compiles and initializes; the open item is behavioral or interpretive, not a known load failure.
- **Manual review checklist:**
  1. Create one clearly legal state and one boundary-illegal state for every clause named in the audit finding.
  2. Test activation, target selection, resolution after the subject leaves or becomes unaffected, and all printed success-gated follow-ups.
  3. Record whether the discrepancy is an engine limitation, a script defect, or a wording decision; close it only after choosing the intended behavior.
  4. Run the relevant GY branch both with and without Necrovalley, including activation legality and a Necrovalley effect appearing before resolution.
  5. Include face-up and face-down banished cards and confirm hidden cards are never selected unless the text explicitly permits them.
- **Acceptance condition:** Record the authoritative interpretation and an Omega replay/log showing the positive case, the closest illegal case, and any listed interruption case. The observed result must match the exact source sequence and leave no broader/narrower legal pool than intended.

<details>
<summary>Exact current source text</summary>

2+ Level 8 "Arckcestial" monsters
Once per turn, when a card or effect is activated, while you control another "Arckcestial" monster (Quick Effect): You can detach 1 material from this card and banish 1 "Arckcestial" card from your hand or GY; negate the activation, and if you do, banish that card. If this card would be destroyed by battle or card effect, you can banish 1 "Arckcestial" card from your GY instead. If this face-up Xyz Summoned card in its owner's control leaves the field because of an opponent's card: You can Special Summon up to 2 "Arckcestial" monsters from your GY, except "Urphiel, The High Arckcestial." You can only use this effect of "Urphiel, The High Arckcestial" once per turn.

</details>

### 121. Gravinity Sonic Scream - 238184015

- **Source ordinal:** 439. **Script:** [`c238184015.lua`](<../public/CCG Downloads/CCG_Scripts/c238184015.lua>)
- **Problem/question to solve:** Copied activated-effect semantics.
- **Current audited implementation:** Copied activated-effect semantics. The file compiles and initializes; the open item is behavioral or interpretive, not a known load failure.
- **Manual review checklist:**
  1. Create one clearly legal state and one boundary-illegal state for every clause named in the audit finding.
  2. Test activation, target selection, resolution after the subject leaves or becomes unaffected, and all printed success-gated follow-ups.
  3. Record whether the discrepancy is an engine limitation, a script defect, or a wording decision; close it only after choosing the intended behavior.
  4. Run the relevant GY branch both with and without Necrovalley, including activation legality and a Necrovalley effect appearing before resolution.
  5. Include face-up and face-down banished cards and confirm hidden cards are never selected unless the text explicitly permits them.
- **Acceptance condition:** Record the authoritative interpretation and an Omega replay/log showing the positive case, the closest illegal case, and any listed interruption case. The observed result must match the exact source sequence and leave no broader/narrower legal pool than intended.

<details>
<summary>Exact current source text</summary>

When your opponent activates a card or effect while you control 2 or more "Gravinity" Monster Cards: You can negate the activation, and if you do, destroy it or, if it was a monster, place it face-up in its owner's Spell & Trap Zone as a Continuous Trap. You can only use the previous effect of "Gravinity Sonic Scream" once per turn. If you activate the effect of a "Gravinity" Synchro Monster Card: You can banish this card from your GY; this effect becomes that card's activated effect.

</details>

### 122. Flower Cardian Moonflare - 248940511

- **Source ordinal:** 443. **Script:** [`c248940511.lua`](<../public/CCG Downloads/CCG_Scripts/c248940511.lua>)
- **Problem/question to solve:** One card treated as 3 non-Tuners.
- **Current audited implementation:** One card treated as 3 non-Tuners. The file compiles and initializes; the open item is behavioral or interpretive, not a known load failure.
- **Manual review checklist:**
  1. Create one clearly legal state and one boundary-illegal state for every clause named in the audit finding.
  2. Test activation, target selection, resolution after the subject leaves or becomes unaffected, and all printed success-gated follow-ups.
  3. Record whether the discrepancy is an engine limitation, a script defect, or a wording decision; close it only after choosing the intended behavior.
  4. Run the relevant GY branch both with and without Necrovalley, including activation legality and a Necrovalley effect appearing before resolution.
  5. Include a full-zone case and a case where paying the cost opens a zone; the UI must not reject a legal post-cost state or promise an impossible summon.
- **Acceptance condition:** Record the authoritative interpretation and an Omega replay/log showing the positive case, the closest illegal case, and any listed interruption case. The observed result must match the exact source sequence and leave no broader/narrower legal pool than intended.

<details>
<summary>Exact current source text</summary>

1 Tuner + 3 non-Tuner monsters
If this card is Synchro Summoned: You can target 5 Spell Cards or "Flower Cardian" monsters in your GY; shuffle them into the Deck, then draw 1 card. When your opponent activates a monster effect (Quick Effect): You can negate the activation, and if you do, destroy that card. You can only use this effect of "Flower Cardian Moonflare" once per turn. When this card is used as Synchro Material for the Synchro Summon of a "Flower Cardian" monster, you can treat it as 3 non-Tuner monsters.

</details>

### 123. Attack on Gravity - 259307285

- **Source ordinal:** 457. **Script:** [`c259307285.lua`](<../public/CCG Downloads/CCG_Scripts/c259307285.lua>)
- **Problem/question to solve:** Card-wide hand permission cannot safely distinguish its two activation modes.
- **Current audited implementation:** Card-wide hand permission cannot safely distinguish its two activation modes. The file compiles and initializes; the open item is behavioral or interpretive, not a known load failure.
- **Manual review checklist:**
  1. Create one clearly legal state and one boundary-illegal state for every clause named in the audit finding.
  2. Test activation, target selection, resolution after the subject leaves or becomes unaffected, and all printed success-gated follow-ups.
  3. Record whether the discrepancy is an engine limitation, a script defect, or a wording decision; close it only after choosing the intended behavior.
  4. Include a full-zone case and a case where paying the cost opens a zone; the UI must not reject a legal post-cost state or promise an impossible summon.
- **Acceptance condition:** Record the authoritative interpretation and an Omega replay/log showing the positive case, the closest illegal case, and any listed interruption case. The observed result must match the exact source sequence and leave no broader/narrower legal pool than intended.

<details>
<summary>Exact current source text</summary>

(This card is always treated as a "Galactica" card.) If only your opponent controls a monster and your opponent declares an attack, you can activate this card from your hand. When your opponent declares an attack, OR activates a card or effect during the Battle Phase: Negate the attack or activation, and if you do, destroy that card, and if you do that, you can Special Summon 1 monster from your hand in Attack Position, but return it to the hand at the end of the Battle Phase.

</details>

## Completion record template

For each card, record: tester/date; Omega build; deck/replay; ruling adopted; positive case; negative boundary case; interruption/chain case; expected result; observed result; Lua/text change required; retest result; final reviewer.

When all 123 entries have an accepted ruling and passing replay evidence, rerun the full 577-card audit verification matrix and update the classifications in the ultimate report.

# Ultimate aux.Stringid Cross-Audit — Central Integration

Date: 2026-07-20

## Result

PASS. The central message generator now explicitly covers every currently referenced `aux.Stringid` index across the 577-card source set.

| Check | Result |
|---|---:|
| Cards in `cards.json` | 577 |
| Cards with referenced `aux.Stringid` slots | 496 |
| Unique referenced slots | 1,186 |
| Referenced slots missing from overrides | 0 |
| Referenced blank strings | 0 |
| Generated placeholder strings | 0 |
| Referenced cards reaching the batch fallback | 0 |
| July batch cards converted to explicit overrides | 106 |
| July batch slots converted to explicit overrides | 259 |
| July batch index/count mismatches | 0 |

The `BATCH_CARD_STRING_COUNTS` compatibility fallback remains in the module, but it is inactive for every currently referenced card/index because every one of the 106 batch cards now has an explicit `CARD_STRING_OVERRIDES` entry. No production DB, installed Omega DB, ZIP, or `dist` artifact was synchronized in this lane.

## Sources and alignment method

- Read every `aux.Stringid(id, n)` call from the standalone scripts under `public/CCG Downloads/CCG_Scripts`.
- Classified each use as an effect description, `SelectYesNo`/`SelectEffectYesNo` prompt, `SelectOption` choice, delayed-effect description, or other UI hint.
- Compared the operation represented by each slot with its enclosing Lua effect and the exact card text in `src/data/cards.json`.
- Used `public/CCG Downloads/CCG_Database/CCG_v1_id_map.json` to restrict the verification to the 577-card source set.
- Confirmed the DB mapping rule (`aux.Stringid(id, 0)` -> `texts.str1`, etc.) by querying a disposable full-sync database.

## July batch conversion

All 259 previously fallback-generated slots were replaced with explicit, call-site-aligned messages. The audit covered every listed card from these groups:

- Bau/Bauy, Halloween/Pumpkien, Ghoti, Myutant, Hallo-Ween, Skewy, and Crewal.
- Ghostrick and Vampire.
- Scarstech and Gravinity.
- Unbinding/Eclipse, Flower Cardian, Stardust, Interwire, and Oracle.
- Galactica/Galataxian/Intergalactican and the Eldora crossover cards.
- `Pray for Your Life!`.

For every one of the 106 cards, referenced indices are contiguous from zero and exactly match the explicit override length. Option slots were worded as choices, Yes/No slots as the action being confirmed, and effect descriptions as the operation actually registered by the Lua effect.

## Confirmed legacy corrections

The legacy blank-message backlog and Grimoire slot were reviewed individually. In addition to filling the backlog, 25 referenced legacy slots needed wording/index correction or material clarity improvement:

| Card | Slot(s) | Corrected semantic use |
|---|---:|---|
| A World of Crying Chaos | 1 | Special Summon the targeted Zombie, not the searched monster |
| Windborne Cartographer | 1 | Add or Set a Windborne Spell after use as Synchro Material |
| Janna, Windborne Goddess of the Temple | 1, 3 | Send a Windborne card; optional second-card shuffle/Set prompt |
| Shining Brigade - Heartbeat Division | 1, 2 | Shining Brigade-only Summon lock; detach and banish opponent Effect Monster |
| Shining Brigade - Melody Division | 0, 1 | Additional Normal Summon/Set; attach a Brigade monster from Deck/GY |
| Shining Brigade - Revenge Division | 1 | Attach a Shining Brigade card from the Deck |
| Shining Brigade Armada | 1 | Special Summon multiple Brigade monsters from GY/banishment |
| Let's Go! Shining Brigade! | 1 | Search a Shining Brigade Spell/Trap |
| We're the Shining Brigade! | 0 | Optional Deck search for a Shining Brigade monster |
| Pixiebot | 1 | Banish a Link Monster from GY, then revive Normal Monsters |
| Aquila, Zephorion's Predictor | 1, 2 | Correct Set target family; correct destroyed-effect recovery description |
| Auriga of the Eldoran Empire | 2 | Correct destroyed-effect recovery description |
| Aquamarine Moon Aurelia | 2 | Fusion Summon by banishing field/GY materials |
| Aquamarine Plate Montipora | 1 | Fusion Summon using hand/field materials |
| Aqua Fusion | 1 | Fusion Summon by shuffling field/GY/banished materials into the Deck |
| Aquamarine Planktonites | 0 | Revive an Aquamarine monster from GY/banishment |
| Hiding "C" | 1 | Search an EARTH Insect with 1500 or less ATK |
| Ampere, the Yellow Ohmen | 1 | Search Ohmen monsters whose total Levels equal the counters |
| Carcel, the Dark Ohmen | 2 | Place counters on an Ohmechanic after use as Link Material |
| Farad, the Ohmechanic Capacitor | 2 | Banish up to 3 cards from the opponent's GY |
| Ampere, the Ohmechanic Intensity | 1 | Place a counter on every co-linked monster |

`Grimoire of Eclipse` index 1 was confirmed as:

> Use 1 Level 8 "Eclipse Observer" monster and 1 Spellcaster monster as Fusion Material?

This matches its `Duel.SelectYesNo` call and the optional additional-material branch.

## Verification

| Command/check | Result |
|---|---|
| `python -m py_compile scripts/sync_omega_ccg_db.py` | PASS |
| Static scan of all mapped Lua scripts and all literal `aux.Stringid(id,n)` references | PASS — 496 cards, 1,186 slots, 0 missing/blank/placeholder/fallback |
| Batch cardinality and contiguous-index scan | PASS — 106 cards, 259 slots, 0 mismatches |
| Disposable copy + `python scripts/sync_omega_ccg_db.py --db <temp.db> --map-out <temp.json> --full-sync --no-backup` | PASS — 577 source rows updated; 587 DB rows retained |
| SQL verification of every referenced `texts.strN` in the disposable synced DB | PASS — 1,186/1,186 populated; 0 placeholders |
| `git diff --check -- scripts/sync_omega_ccg_db.py` | PASS (line-ending warning only) |

The temporary DB and map were removed after verification.

## Files changed in this lane

- `scripts/sync_omega_ccg_db.py`
- `tmp/ultimate_audit_message_cross_c.md`

## Residual risk

Message presence and slot semantics are verified statically and in a fully synced disposable DB. In-engine testing is still useful for UI truncation, when Omega chooses to display descriptions versus confirmation prompts, and localization/rendering of punctuation. No unresolved blank, placeholder, or index-alignment defect remains.

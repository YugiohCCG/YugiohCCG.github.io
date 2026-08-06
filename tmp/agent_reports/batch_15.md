### Clause-by-Clause Audit Findings: Batch 15

| Card Name | Passcode | Clause | Issue Type | Findings & Recommendations |
| :--- | :---: | :--- | :--- | :--- |
| **Ophiel, Arckcestial of Wisdom** | 251710981 | All Clauses | None | Script logic aligns with the card text accurately. |
| **Sarifiel, Arckcestial of Moonlight** | 231089172 | All Clauses | None | Xyz procedure, attach from GY/Banishment, and quick detach are implemented correctly. |
| **Urphiel, the High Arckcestial** | 215105971 | All Clauses | None | Xyz procedure, Quick negate, destruction replacement, and float effect are correct. |
| **Bauy Magician** | 220856437 | All Clauses | None | Tuner modification, Special Summon, and Link lock are correctly implemented. |
| **Dreaming Bau** | 250047045 | All Clauses | None | Banish cost and conditional Turn Player effects are correctly handled. |
| **Ro-Bau** | 219826457 | All Clauses | None | ATK scaling and equip interactions are correct. |
| **Bau** | 221511784 | All Clauses | None | Special Summon procedure and End Phase revival are properly mapped. |
| **Winged Bauy Fenrir** | 237444604 | All Clauses | None | Synchro procedure targeting the specific "Bau" card and effect negation are correct. |
| **Starfury Bauy Dragon** | 256462992 | All Clauses | None | Protection, non-targeting return, and Extra Deck recycle effects are sound. |
| **Bael, Demon Incarnate** | 228169392 | All Clauses | None | Banished card scaling accounts for both players, which correctly matches "all banished cards". |
| **Bauy World** | 226950506 | All Clauses | None | Link ATK reduction and ignition effects work correctly. |
| **Bauy Spellcasting** | 254215159 | All Clauses | None | Direct activation of Field Spell and effect negation are correctly implemented. |
| **Rai-Bau** | 225358630 | All Clauses | None | Negation and self-recycle triggers correctly. |
| **Bauy Emergency Room!** | 223366685 | All Clauses | Suspected | **Finding:** The condition checks a flag effect (`Duel.GetFlagEffect`) set in the cost of Bauy World. If Bauy World's activation is negated, the flag remains, falsely treating it as "activated this Duel".<br>**Fix:** Consider registering the flag in a global `EVENT_CHAIN_SOLVED` listener rather than within the Field Spell's activation cost. |
| **Bhodi, the Corrupted Halloween Tree** | 259072745 | *"...Tribute 1 other Fiend monster you control; equip that monster to this card..."* | Confirmed | **Finding:** The `eqop` strictly checks if the tributed monster went to the GY (`tc:IsLocation(LOCATION_GRAVE)`). If a Pendulum monster is tributed or if Macro Cosmos is active, the monster goes to the Extra Deck or is banished, causing the equip to fail. <br>**Fix:** Broaden the location check in `c259072745.lua` to allow equipping from the banished zone. |
| **Toddler Pumpkien** | 233957828 | All Clauses | None | Field check and material trigger correctly pull the original ATK. |
| **Dreadful Soul Drain** | 259471193 | All Clauses | None | Phase restriction and chain limits are correctly established. |
| **Bray, Shell of the Ghoti** | 212822164 | All Clauses | None | Synchro requirements and quick banish logic are fully compliant. |
| **Shekup, Sting of the Ghoti** | 235352857 | All Clauses | None | Standby Phase recursion handles the turn delay logic correctly. |
| **Ghoti from a Deeper Depth...** | 240575550 | All Clauses | None | ATK scaling and trap setting logic correctly reference banished triggers. |
| **Myutant EL-51** | 255283389 | All Clauses | None | Cost extraction and dynamic Special Summon map perfectly to text. |
| **Myutant Evolution** | 244816828 | All Clauses | None | Activation limits and on-banish trigger resolve correctly. |
| **Myutant Amalgamate** | 211699737 | *"...this effect becomes that monster's original effect."* | Ambiguous | **Finding:** The text implies the current Ignition effect resolves as the targeted monster's effect (like *Predaplant Verte Anaconda*). However, the script uses `CopyEffect`, granting the monster the effects continuously. A monster having multiple spell-speed effects makes "this effect becomes" highly ambiguous.<br>**Fix:** Rewrite the card text to match the intended `CopyEffect` implementation (e.g., *"this card's name and original effects become the same as that banished monster's"*). |
| **Pumpqueen the Queen of Ghosts** | 259308265 | *"You can Normal Summon it in addition to your Normal Summon/Set this turn, also you can use monsters from your hand as Tribute for its Normal Summon."* | Confirmed | **Finding:** The script explicitly grants the extra Normal Summon to `Castle of Dark Illusions` (a Spell Card) instead of Pumpqueen. Furthermore, the effect allowing monsters from the hand to be used as Tributes is completely missing from the script. <br>**Fix:** Remove the `EFFECT_EXTRA_SUMMON_COUNT` target for `CASTLE` in `c259308265.lua` and implement an unclassified effect on Pumpqueen that grants the extra summon for itself alongside a custom tribute procedure. |
| **Pumprince the Prince of Ghosts** | 239028111 | All Clauses | None | Pumpkin counter accumulation and field debuff work correctly. |

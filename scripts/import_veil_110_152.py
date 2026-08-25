from __future__ import annotations

import json
import shutil
import zlib
from pathlib import Path


ROOT = Path(__file__).resolve().parents[1]
CARDS_PATH = ROOT / "src" / "data" / "cards.json"
ASSETS_DIR = ROOT / "public" / "assets" / "cards"
SOURCE_DIR = Path(r"C:\Users\hclar\Downloads\New folder (2)")
ADDED = "2026-08-23"


def m(filename, name, archetype, attribute, level, atk, defense, text,
      *, card_types=("Effect",), monster_type="", rank=None,
      link_rating=None, link_arrows=None, scale=None):
    return dict(filename=filename, name=name, archetype=archetype,
                category="Monster", icon=None, cardTypes=list(card_types),
                monsterType=[monster_type], attribute=attribute, level=level,
                rank=rank, linkRating=link_rating, linkArrows=link_arrows,
                scale=scale, atk=atk, defense=defense, text=text)


def st(filename, name, archetype, category, icon, text):
    return dict(filename=filename, name=name, archetype=archetype,
                category=category, icon=icon, cardTypes=None,
                monsterType=None, attribute=None, level=None, rank=None,
                linkRating=None, linkArrows=None, scale=None, atk=None,
                defense=None, text=text)


CARDS = [
    m("The_Intergalataxian.png", "The Intergalataxian", "Galactica", "LIGHT", 7, 1000, 0,
      '(This card is also treated as a "Galactica" card.) You can only use each of the following effects of "The Intergalataxian" once per turn. During the Battle Phase (Quick Effect): You can send 1 "Galactica" Spell from your Deck to the GY; apply that card\'s activation effect, then you can Special Summon this card from your hand. During your opponent\'s Battle Phase, if a monster you control destroys a monster by battle or inflicts battle damage to your opponent: You can end the Battle Phase. During your opponent\'s End Phase: Return this card you control to the hand.', monster_type="Celestial Warrior"),
    st("Divinity_to_Infinity.png", "Divinity to Infinity", "Divinity to Infinity", "Trap", "Normal",
       'Target 1 Spell/Trap in your opponent\'s GY that was not sent there this turn; banish that card, then apply that card\'s activation effect. You can only activate 1 "Divinity to Infinity" per turn. During your turn, you can activate this card from your hand.'),
    m("Yurei_1.png", "Yurei", "Spirit", "EARTH", 2, 1800, 800,
      'Cannot be Special Summoned. When your opponent activates a card or effect that would destroy a card on the field (Quick Effect): You can reveal this card in your hand; Tribute 1 Spirit monster from your hand or field, and if you do, negate that effect. When an attack is declared involving your Spirit monster (Quick Effect): Immediately after this effect resolves, Normal Summon this card, and if you do, that Spirit monster\'s ATK is doubled until the end of this turn. You can only use 1 of the previous effects of "Yurei" per turn, and only once that turn. Once per turn, during the End Phase, if this card was Tributed, Normal Summoned, or flipped face-up this turn: Return it to the hand.', card_types=("Spirit", "Tuner", "Effect"), monster_type="Zombie"),
    m("Hannya_1.png", "Hannya", "Spirit", "DARK", 4, 1800, 800,
      'Cannot be Special Summoned. If 2 or more monsters have been Normal Summoned this turn (Quick Effect): You can Tribute this card from your hand; immediately after this effect resolves, Normal Summon 1 Spirit monster. If a Spirit monster is Tributed while this card is in your GY: You can banish this card from your GY; add 2 Spirit monsters with different Levels and Attributes from your GY to your hand. You can only use each of the previous effects of "Hannya" once per turn. Once per turn, during the End Phase, if this card was Normal Summoned or flipped face-up this turn: Return this card to the hand.', card_types=("Spirit", "Effect"), monster_type="Fiend"),
    m("Abe_no_Seimei_1.png", "Abe no Seimei", "Spirit", "DARK", 6, 2400, 0,
      '1 Spirit Tuner + 1+ non-Tuners If this card is Special Summoned: Your hand size limit becomes 7 until the end of your opponent\'s next turn. Once per turn: You can increase or decrease the Level of 1 other Spirit monster you control by 1, and if you do, this card gains ATK equal to that monster\'s original ATK. During the End Phase, if this card was Special Summoned this turn: Return it to the Extra Deck, and if you do, Special Summon 2 Spirit monsters from your GY (1 Tuner and 1 non-Tuner) whose total Levels equal 6, ignoring their Summoning conditions.', card_types=("Synchro", "Spirit", "Effect"), monster_type="Spellcaster"),
    m("Melantha_Keeper_of_Lamentations_1.png", "Melantha, Keeper of Lamentations", "Melantha", "DARK", 2, 700, 0,
      'Cannot be Normal Summoned/Set. Must be Special Summoned by its own effect. If this card battles a monster, neither can be destroyed by that battle. If your opponent Special Summoned a monster from the Extra Deck this turn, while you control no cards (Quick Effect): You can Special Summon this card from your hand. You can only use the previous effect of "Melantha, Keeper of Lamentations" once per turn. When your opponent would Special Summon a monster(s) from the Extra Deck, they must shuffle 1 card from their hand into the Deck or send that monster(s) to the GY.', card_types=("Special Summon", "Effect"), monster_type="Illusion"),
    st("Nautica_Musicale_1.png", "Nautica Musicale", "Nautica", "Trap", "Continuous",
       'When this card is activated: You can add 1 "Nautica" monster from your Deck or GY to your hand. If you activate an effect that would Special Summon a "Nautica" monster from your hand: You can draw 1 card and your opponent adds 1 monster from their Deck to their hand, then place 1 card from your hand on the bottom of your Deck, also gain 200 LP. Until the end of the next turn, your opponent cannot activate the effects of cards with the same name as that monster. You can only control 1 "Nautica Musicale".'),
    st("Nautica_Oceanica.png", "Nautica Oceanica", "Nautica", "Spell", "Field",
       'Monsters Normal or Special Summoned from the hand in Attack Position cannot activate their effects. If you activate a "Nautica" card effect that would Summon a monster, you can add 1 of these additional effects to that card\'s effect at resolution depending on where it would be Summoned from. ● Your hand: Then, immediately after this effect resolves, your opponent Normal or Special Summons 1 monster from their hand in Attack Position, also it is unaffected by "Nautica Oceanica", but its ATK becomes 0. ● Your opponent\'s hand: Add 1 "Nautica" monster from your Deck or GY to the hand, then place 1 card from your hand on the bottom of your Deck.'),
    m("Raven_the_Lightning_II_Aerocat.png", "Raven the Lightning II Aerocat", "Aerocat", "WIND", 6, 1900, 2200,
      'If this card is in your hand: You can reveal 1 other "Aerocat" card in your hand; Special Summon this card, also you cannot Special Summon monsters from the Extra Deck for the rest of this turn, except Xyz Monsters. During your Main Phase: You can Special Summon 1 "Aerocat" monster from your hand, GY, or that is attached to an Xyz Monster you control. If this card is in your hand or GY (Quick Effect): You can target 1 Rank 6 WIND Xyz Monster you control; attach this card to it as material. You can only use each effect of "Raven the Lightning II Aerocat" once per turn.', monster_type="Beast"),
    m("Glint_the_Blackbird_Aerocat.png", "Glint the Blackbird Aerocat", "Aerocat", "WIND", 6, 2100, 1500,
      'You can discard this card; add 1 "Aerocat" Spell/Trap card from your Deck to your hand. If this card is in your GY: You can target 1 "Aerocat" monster you control; Special Summon this card, but banish it when it leaves the field, and if you do, increase that target\'s ATK by 500. (Quick Effect): You can target 1 Rank 6 WIND Xyz Monster you control; attach this card from your hand or GY to that card as material. You can only use each effect of "Glint the Blackbird Aerocat" once per turn.', monster_type="Beast"),
    m("Vik_the_Chinook_Aerocat.png", "Vik the Chinook Aerocat", "Aerocat", "WIND", 6, 1700, 2200,
      'You can Normal Summon this card without Tributing by revealing 1 "Aerocat" Xyz Monster in your Extra Deck. You can only use each of the following effects of "Vik the Chinook Aerocat" once per turn. If this card is Normal or Special Summoned: You can add 1 "Aerocat" monster from your Deck to your hand. (Quick Effect): You can target 1 Rank 6 WIND Xyz Monster you control; attach this card from your hand or GY to that card as material.', monster_type="Beast"),
    m("Navi_the_NAV_Hawk_Aerocat1.png", "Navi the NAV Hawk Aerocat", "Aerocat", "WIND", None, 2700, 2600,
      '2+ Level 6 Beast monsters If this card is Xyz Summoned: Apply any number of these effects in sequence. ● Detach any number of materials from this card, then shuffle that many cards from any GY(s) into the Deck. ● Attach 1 card from your GY or banishment to this card. When your opponent activates a monster effect, while you control an Xyz Monster with 1 material (Quick Effect): You can negate the activation, and if you do, destroy it. You can only use each effect of "Navi the NAV Hawk Aerocat" once per turn.', card_types=("Xyz", "Effect"), monster_type="Beast", rank=6),
    m("Shade_the_Aigalon_Aerocat.png", "Shade the Aigalon Aerocat", "Aerocat", "WIND", 6, 1000, 2200,
      'All other "Aerocat" monsters you control gain 1000 ATK. You can only use each of the following effects of "Shade the Aigalon Aerocat" once per turn. If this card is in your hand or GY (Quick Effect): You can detach 1 material from a Rank 6 Xyz Monster on the field; Special Summon this card. Once while this card is face-up on the field (Quick Effect): You can target 1 card on the field; attach it to an "Aerocat" Xyz Monster you control as material.', monster_type="Beast"),
    m("Goliath_the_Airship_Aerocat1.png", "Goliath the Airship Aerocat", "Aerocat", "WIND", None, 2200, 2700,
      '2 Level 6 monsters Monsters your opponent controls cannot target monsters you control for attacks, except this one. If this card is Xyz Summoned: You can detach all materials from this card, then apply any number of the following effects. ● Add up to 2 "Aerocat" cards from your Deck to your hand, that have different card types (Monster, Spell, Trap) than each other. ● Attach 1 "Aerocat" card from your GY to a Rank 6 monster you control as Xyz Material. You can only use this effect of "Goliath the Airship Aerocat" once per turn.', card_types=("Xyz", "Effect"), monster_type="Beast", rank=6),
    m("Argalia_the_Gripen_Aerocat.png", "Argalia the Gripen Aerocat", "Aerocat", "WIND", 6, 2000, 2000,
      'If you have an "Aerocat" monster on your field or in your GY, you can Special Summon this card (from your hand). You can only Special Summon "Argalia the Gripen Aerocat" once per turn this way. You can only use each of the following effects of "Argalia the Gripen Aerocat" once per turn. If this card is Normal or Special Summoned: You can target 1 monster your opponent controls; destroy it, then you can attach 1 card from your opponent\'s GY to an Xyz Monster you control as material. (Quick Effect): You can target 1 Rank 6 WIND Xyz Monster you control; attach this card from your hand or GY to that card as material.', monster_type="Beast"),
    st("Aerocat_Lightning_Shot.png", "Aerocat Lightning Shot", "Aerocat", "Trap", "Counter",
       'When your opponent activates a card or effect, while you control a Rank 6 WIND Xyz Monster with 1 material: You can negate the activation, then you can detach 1 material from 1 "Aerocat" Xyz Monster you control, and if you do, shuffle that opponent\'s card into the Deck. You can only activate 1 "Aerocat Lightning Shot" per turn.'),
    st("Aerocat_Recon.png", "Aerocat Recon", "Aerocat", "Spell", "Normal",
       'Add 1 "Aerocat" monster from your Deck or GY to your hand. You can banish this card from your GY, then target up to 3 other "Aerocat" cards in your GY and/or banishment; shuffle them into the Deck, then if you control an Xyz Monster with only 1 material, you can draw 1 card. You can only use each effect of "Aerocat Recon" once per turn.'),
    m("Dinomorphia_Ankylos.png", "Dinomorphia Ankylos", "Dinomorphia", "DARK", 4, 1500, 0,
      'If this card is in your hand or GY (Quick Effect): You can pay half your LP; Special Summon this card. If this card is Normal or Special Summoned: You can Set 1 "Dinomorphia" Trap from your GY or banishment, then, if you have 2000 or less LP, it can be activated this turn. If this card is destroyed: You can banish 1 Trap from your GY; Special Summon 1 Level 4 "Dinomorphia" monster from your GY, except "Dinomorphia Ankylos". You can only use each effect of "Dinomorphia Ankylos" once per turn.', monster_type="Dinosaur"),
    m("Dinomorphia_Triceron2.png", "Dinomorphia Triceron", "Dinomorphia", "DARK", 8, 3000, 1500,
      '1 "Dinomorphia" Fusion monster + 1 "Dinomorphia" monster If you have 2000 or less LP, you can activate "Dinomorphia" Traps the turn they are Set. You can only use each of the following effects of "Dinomorphia Triceron" once per turn. (Quick Effect): You can pay half your LP; destroy 1 other "Dinomorphia" monster you control and 1 card your opponent controls, also, after that, you can shuffle up to 3 "Dinomorphia" Trap Cards from your GY or banishment into the Deck. If this card is destroyed: You can Special Summon 1 Level 6 or lower "Dinomorphia" monster from your GY.', card_types=("Fusion", "Effect"), monster_type="Dinosaur"),
    st("Dinomorphia_Provocation.png", "Dinomorphia Provocation", "Dinomorphia", "Trap", "Normal",
       'Pay half your LP; Set 1 "Dinomorphia" Trap from your Deck, then you can Fusion Summon 1 "Dinomorphia" monster, by using monsters from your hand or field as material. You can banish this card from your GY, then pay half your LP; send 1 "Dinomorphia" card from your Deck to the GY. You can only use each effect of "Dinomorphia Provocation" once per turn.'),
    st("Dinomorphia_Hideout.png", "Dinomorphia Hideout", "Dinomorphia", "Trap", "Continuous",
       'If your opponent controls a card, you can activate this card the turn it is Set. During your turn: You can pay half your LP, then send 1 "Dinomorphia" Normal Trap from your Deck to the GY; this effect becomes that card\'s effect when it is activated, also you cannot Special Summon monsters the turn you use this effect, except "Dinomorphia" monsters. During your turn, you can activate 1 "Dinomorphia" Trap from your hand. You can only use each effect of "Dinomorphia Hideout" once per turn.'),
    m("Krawler_Astrocyte.png", "Krawler Astrocyte", "Krawler", "EARTH", 4, 1200, 1800,
      'FLIP: You can Special Summon 1 Level 2 "Krawler" monster from your Deck in face-down Defense Position, then you can change 1 face-down monster you control to face-up Defense Position, and if you do, change this card to face-down Defense Position. You can discard 1 "Krawler" or "World Legacy" card; Special Summon this card from your hand in face-down Defense Position, then you can change 1 monster you control to face-up Defense Position. If this face-up card in its owner\'s control leaves the field because of an opponent\'s card effect: You can Special Summon 2 "Krawler" monsters with different names from your Deck in face-down Defense Position, except "Krawler Astrocyte". You can only use each effect of "Krawler Astrocyte" once per turn.', card_types=("Flip", "Effect"), monster_type="Insect"),
    m("Krawler_Lamina.png", "Krawler Lamina", "Krawler", "EARTH", 9, 3000, 2500,
      'FLIP: Target 1 card you control and 1 card your opponent controls; return them to the hand. (Quick Effect): You can discard this card; Special Summon 1 "Krawler" monster from your hand, GY, or that is banished, in face-up or face-down Defense Position, except "Krawler Lamina". If a Link Monster is Special Summoned: You can banish this card from your GY; place face-up or Set 1 "World Legacy" Continuous Spell/Trap from your hand or Deck. You can only use each effect of "Krawler Lamina" once per turn.', card_types=("Flip", "Effect"), monster_type="Insect"),
    m("Krawler_Of_The_World_Legacy.png", "Krawler of the World Legacy", "Krawler", "EARTH", 6, 2500, 2000,
      'You can Special Summon this card (from your hand) by Tributing 1 face-down card on the field. You can only Special Summon "Krawler of the World Legacy" once per turn this way. If this card is Special Summoned: You can Special Summon 1 "Krawler" monster from your hand or GY in face-down Defense Position. If this card is sent to the GY as Link material or by the effect of a "Krawler" monster: You can target 1 monster on the field; change it to face-up or face-down Defense Position. You can only use each effect of "Krawler of the World Legacy" once per turn.', monster_type="Insect"),
    m("Krawler_Plexus.png", "Krawler Plexus", "Krawler", "EARTH", None, 300, None,
      '1 "Krawler" monster If this card is Special Summoned: When you activate this effect, you can also discard 1 card; You can Special Summon 1 "Krawler" monster from your banishment or GY in face-down Defense Position, then, if you discarded a card when you activated this effect, you can change 1 face-down Defense Position monster you control to face-up Defense Position. If a "Krawler" monster leaves the field because of an opponent\'s card or effect: You can shuffle this card and 2 other "Krawler" monsters from your GY into your Deck; this turn all "Krawler" monsters gain 300 ATK/DEF. You can only Special Summon "Krawler Plexus" once per turn.', card_types=("Link", "Effect"), monster_type="Insect", link_rating=1, link_arrows=["B"]),
    st("World_Legacy_Surfacing.png", "World Legacy Surfacing", "World Legacy", "Spell", "Quick-Play",
       'Reveal 1 Level 2 or lower "Krawler" monster in your hand or GY, or, if your opponent controls a card, you can reveal it from your Deck instead; this effect becomes that monster\'s FLIP effect when that monster is flipped face-up. You cannot activate other Spell/Trap Cards the turn you activate this effect, except "World Legacy" Spell/Trap Cards. You can banish this card from your GY; add 1 "Krawler" monster and/or 1 "World Legacy" Spell/Trap from your GY or that is banished to your hand, except "World Legacy Surfacing". You can only use each effect of "World Legacy Surfacing" once per turn.'),
    st("World_Legacy_Calamities.png", "World Legacy Calamities", "World Legacy", "Spell", "Continuous",
       'When this card is activated: You can take 1 "World Legacy" Spell/Trap from your Deck, except "World Legacy Calamities", and either add it to your hand or send it to the GY. You cannot activate Spell/Trap Cards the turn you activate this effect, except "World Legacy" Spell/Trap Cards. Once per turn, if a monster(s) is Special Summoned or Set: You can target 1 face-down monster you control; change it to face-up Defense Position, but its effects cannot be activated this turn unless it is a "Krawler" monster. You can only activate 1 "World Legacy Calamities" per turn.'),
    m("Machina_X-Krawler.png", "Machina X-Krawler", "Krawler", "EARTH", None, 3200, None,
      '2+ "Krawler" monsters You can also use face-down "Krawler" monsters you control as material to Link Summon this card. You cannot Special Summon monsters, except "Krawler" monsters. Cannot be targeted by your opponent\'s card effects. When your opponent activates a Spell/Trap Card or effect (Quick Effect): You can banish 2 "Krawler" monsters from your GY; the activated effect becomes "Your opponent sends 1 monster they control to the GY". If this face-up card in its owner\'s control leaves the field because of an opponent\'s card effect, or is destroyed by battle: You can Special Summon 2 "Krawler" Link Monsters from your Extra Deck, except "Machina X-Krawler" (this is treated as a Link Summon). You can only control 1 "Machina X-Krawler". You can only use each effect of "Machina X-Krawler" once per turn.', card_types=("Link", "Effect"), monster_type="Insect", link_rating=4, link_arrows=["TL", "TR", "BL", "BR"]),
    st("Aerocat_Blast_Fist.png", "Aerocat Blast Fist", "Aerocat", "Spell", "Quick-Play",
       'Detach any number of materials from Rank 6 Xyz Monsters you control, and if you do, destroy that many monsters your opponent controls, then you can shuffle cards from your opponent\'s GY into the Deck, up to the number of Xyz Monsters you control with 1 material. You can only activate 1 "Aerocat Blast Fist" per turn.'),
    st("Retaliation_Rebound.png", "Retaliation Rebound", "Retaliation Rebound", "Trap", "Counter",
       'When your opponent activates a card effect that would negate your activated card effect or Summon, and they control more cards than you do: You can negate that activation. During your turn, you can activate this card from your hand.'),
    st("Pot_of_Rage.png", "Pot of Rage", "Pot", "Spell", "Normal",
       'Draw 1 card for every 2 of your cards that were destroyed or banished by your opponent\'s card effects this turn. You can only activate 1 "Pot of Rage" per turn.'),
    st("Pot_of_Longevity.png", "Pot of Longevity", "Pot", "Spell", "Normal",
       'Draw 3 cards instead of 1 for your normal draw during your next Draw Phase, and if you do, skip your next Battle Phase, then, if your opponent controls less cards than you do, place 1 card from your hand on the bottom of your Deck. You can only activate 1 "Pot of Longevity" per turn.'),
    st("Devotee_Of_The_Pyre.png", "Devotee of the Pyre", "Pyre", "Spell", "Normal",
       'Send 1 Pyro monster from your hand or field to the GY; Special Summon 2 "Pyre Tokens" (Pyro/FIRE/Level 1/ATK 0/DEF 0), then, if you control "Lord of the Pyre" you can add 1 "Pyre" Spell card from your Deck to your hand. These Tokens cannot be Tributed or used as Link material, except for the Summon of a Pyro monster. If a Pyro monster(s) you control would be destroyed by battle or card effect, you can banish this card from your GY instead. You can activate 1 "Devotee of the Pyre" per turn.'),
    st("Expulsion_Of_The_Pyre.png", "Expulsion of the Pyre", "Pyre", "Spell", "Normal",
       'Send 1 Pyro monster you control to the GY; Set 1 "Pyre" Spell from your Deck or GY. You can banish this card from your GY, then target 3 "Pyre" Spells or Pyro monsters in your banishment (except "Expulsion of the Pyre"); shuffle them into your Deck, then draw 1 card. You can only use each of the previous effects of "Expulsion of the Pyre" once per turn. If a Pyro monster(s) you control would be destroyed by battle or card effect, you can banish this card from your GY instead.'),
    st("Release_Of_The_Pyre.png", "Release of the Pyre", "Pyre", "Spell", "Continuous",
       'If you control a Pyro monster: You can add 1 "Pyre" Spell from your Deck to your hand. You cannot Special Summon, except Pyro monsters. Once while this card is face-up on the field: You can target 1 "Pyre" Link monster you control in the Extra Monster Zone; while that monster points to an opponent\'s unused Main Monster Zone, your opponent cannot Special Summon monsters to the Extra Monster Zone (even if this card leaves the field). If a "Pyre" monster you control leaves the field because of an opponent\'s card or effect: You can draw 1 card, then send this card you control to the GY. You can only use each effect of "Release of the Pyre" once per turn.'),
    m("Lord_Of_The_Pyre.png", "Lord of the Pyre", "Pyre", "FIRE", None, 1600, None,
      '2 Pyro monsters This card and monster it points to cannot be Tributed or used as Link material, except for the Summon of a Pyro monster. Monsters this card points to cannot attack other Pyro monsters. While this card points to a Pyro monster, it gains 1000 ATK for each monster this card points to, also it cannot be destroyed by battle. If a "Pyre" Spell card is banished: You can target 1 card your opponent controls; destroy it. You can only control 1 "Lord of the Pyre".', card_types=("Link", "Effect"), monster_type="Pyro", link_rating=2, link_arrows=["BL", "BR"]),
    st("Land_Of_The_Pyre.png", "Land of the Pyre", "Pyre", "Spell", "Quick-Play",
       'Target 1 Pyro monster you control and 1 card your opponent controls; destroy the targets. If a Pyro monster(s) you control would be destroyed by battle or card effect, you can banish this card from your GY instead. You can only activate 1 "Land of the Pyre" per turn.'),
    m("Vaylantz_Destroyer_Patrician.png", "Vaylantz Destroyer Patrician", "Vaylantz", "FIRE", 8, 2000, 2700,
      'Pendulum Effect: You can activate 1 of these effects; ● Special Summon this card to your Main Monster Zone in its same column. ● Move 1 monster in your Main Monster Zone to an adjacent (horizontal) Monster Zone. You can only use this effect of "Vaylantz Destroyer Patrician" once per turn. Monster Effect: This face-down card in the Extra Deck must first be either Fusion Summoned, or Special Summoned by Tributing 1 "Vaylantz" monster you control in the same column as another "Vaylantz" card. You can only Special Summon "Vaylantz Destroyer Patrician" from the face-down Extra Deck once per turn. If this card is Special Summoned or moved to another Main Monster Zone: You can toss a coin. ● Heads: Place 1 "Vaylantz" monster from your Deck or face-up Extra Deck in your Pendulum Zone. ● Tails: Set 1 Vaylantz Spell/Trap card from your Deck. You can only use this effect of "Vaylantz Destroyer Patrician" once per turn. If this Special Summoned card you control is destroyed: You can place this card in your Pendulum Zone.', card_types=("Fusion", "Pendulum", "Effect"), monster_type="Machine", scale=11),
    m("Arktos_X_-_Vaylantz_Game_Master.png", "Arktos X - Vaylantz Game Master", "Vaylantz", "EARTH", 10, 2500, 2500,
      'Pendulum Effect: If you control a "Vaylantz" Fusion monster: You can Special Summon this card to your Main Monster Zone in its same column. You can only use this effect of "Arktos X - Vaylantz Game Master" once per turn. Monster Effect: Each time exactly 1 monster is Normal or Special Summoned to your opponent\'s field: Move this card to the adjacent Main Monster Zone closer to that opponent\'s monster. (Quick Effect): You can move 1 monster you control to another of your Main Monster Zones. You can only use this effect of "Arktos X - Vaylantz Game Master" once per turn.', card_types=("Pendulum", "Effect"), monster_type="Fairy", scale=11),
    st("Vaylantz_Duality.png", "Vaylantz Duality", "Vaylantz", "Spell", "Continuous",
       'During your Main Phase: You can destroy 1 Pendulum Monster Card you control, and if you do, add 1 "Vaylantz" card from your Deck to your hand. You can only use this effect of "Vaylantz Duality" per turn. If a card in the Monster Zone moves to another Monster Zone (except during the Damage Step), destroy all cards your opponent controls in that card\'s column.'),
    m("Egg_Of_The_Ashened_Demise.png", "Egg of the Ashened Demise", "Ashened", "DARK", 1, 0, 0,
      'If "Obsidim, the Ashened City" is in the Field Zone, you can Special Summon this card (from your hand). You can only Special Summon "Egg of the Ashened Demise" this way once per turn. If this card is Normal or Special Summoned: You can add 1 card that mentions "Obsidim, the Ashened City" from your Deck to your hand. If a face-up Pyro monster you control is destroyed by battle or an opponent card effect: You can Special Summon this card from your GY. For the rest of this turn after this effect resolves, you cannot Special Summon from the Extra Deck, except Pyro monsters. You can only use each effect of "Egg of the Ashened Demise" once per turn.', monster_type="Pyro"),
    st("Ashened_Face_Off.png", "Ashened Face Off", "Ashened", "Spell", "Continuous",
       'When this card is activated: Add 1 "Ashened" card from your Deck to your hand, you cannot Special Summon the turn you activate this effect, except Pyro monsters. Face-up Special Summoned monsters your opponent controls become Pyro during your opponent\'s turn only. Once per turn, if an "Ashened" monster(s) would be destroyed by battle or card effect, you can banish 1 DARK Pyro monster from your GY instead. You can only activate 1 "Ashened Face Off" per turn.'),
    st("World_Legacy_Crusadia_Counter.png", "World Legacy Crusadia Counter", "World Legacy", "Trap", "Counter",
       'When a Link Monster in the Extra Monster Zone activates its effect: Reveal 1 Link Monster in your Extra Deck with a higher ATK, and if you do, negate that effect, then if the revealed monster had a lower Link Rating destroy that card. You can activate this card from your hand if you control no face-up card. You can banish this card from your GY; Special Summon 1 "World Legacy" monster from your Deck in Defense Position. You cannot activate other Spell/Trap Cards or effects the turn you activate this effect except "World Legacy" and "Crusadia" Spell/Trap Cards. You can only use 1 effect of "World Legacy Crusadia Counter" per turn, and only once that turn.'),
]


def allocate_passcode(source_id: str, used: set[int]) -> int:
    value = 259_000_000 + (zlib.crc32(source_id.encode("utf-8")) % 1_000_000)
    while value in used:
        value = 259_000_000 if value == 259_999_999 else value + 1
    used.add(value)
    return value


def main() -> None:
    existing = json.loads(CARDS_PATH.read_text(encoding="utf-8"))
    if any(c.get("id") == "CARD-00568" for c in existing):
        raise SystemExit("CARD-00568 already exists; refusing to append the batch twice")
    if len(CARDS) != 43:
        raise SystemExit(f"Expected 43 cards, found {len(CARDS)}")
    used = {int(c["passcode"]) for c in existing if isinstance(c.get("passcode"), int)}
    additions = []
    ASSETS_DIR.mkdir(parents=True, exist_ok=True)
    for offset, spec in enumerate(CARDS):
        source_id = f"CARD-{568 + offset:05d}"
        source = SOURCE_DIR / spec["filename"]
        if not source.is_file():
            raise FileNotFoundError(source)
        shutil.copy2(source, ASSETS_DIR / spec["filename"])
        additions.append({
            "id": source_id,
            "passcode": allocate_passcode(source_id, used),
            "name": spec["name"],
            "image": f'/assets/cards/{spec["filename"]}',
            "set": f"VEIL-{110 + offset:03d} Veil of Eternity",
            "archetype": spec["archetype"],
            "category": spec["category"],
            "icon": spec["icon"],
            "cardTypes": spec["cardTypes"],
            "monsterType": spec["monsterType"],
            "attribute": spec["attribute"],
            "level": spec["level"],
            "rank": spec["rank"],
            "linkRating": spec["linkRating"],
            "linkArrows": spec["linkArrows"],
            "scale": spec["scale"],
            "atk": spec["atk"],
            "def": spec["defense"],
            "text": spec["text"],
            "keywords": None,
            "genre": 0,
            "legal": {"semiLimited": False, "limited": False, "banned": False},
            "timestamps": {"added": ADDED},
        })
    CARDS_PATH.write_text(json.dumps(existing + additions, ensure_ascii=False, indent=2) + "\n", encoding="utf-8")
    print(f"Added {len(additions)} cards ({additions[0]['id']}..{additions[-1]['id']})")
    print(f"Sets {additions[0]['set']} .. {additions[-1]['set']}")


if __name__ == "__main__":
    main()

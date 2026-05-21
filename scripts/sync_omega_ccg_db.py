from __future__ import annotations

import argparse
import datetime as dt
import json
import re
import shutil
import sqlite3
import unicodedata
import zlib
from collections import Counter, defaultdict
from pathlib import Path
from typing import Any


REPO_ROOT = Path(__file__).resolve().parents[1]
DEFAULT_CARDS_PATH = REPO_ROOT / "src" / "data" / "cards.json"
DEFAULT_DB_PATH = Path(r"C:\Program Files (x86)\YGO Omega\YGO Omega_Data\Files\Databases\CCG_v1.db")
DEFAULT_OUTPUT_DIR = REPO_ROOT / "scripts" / "output"
DEFAULT_MAP_PATH = DEFAULT_OUTPUT_DIR / "CCG_v1_id_map.json"


TYPE_BITS = {
    "Monster": 0x1,
    "Spell": 0x2,
    "Trap": 0x4,
    "Normal": 0x10,
    "Effect": 0x20,
    "Fusion": 0x40,
    "Ritual": 0x80,
    "Spirit": 0x200,
    "Union": 0x400,
    "Gemini": 0x800,
    "Tuner": 0x1000,
    "Synchro": 0x2000,
    "Token": 0x4000,
    "Quick-Play": 0x10000,
    "Continuous": 0x20000,
    "Equip": 0x40000,
    "Field": 0x80000,
    "Counter": 0x100000,
    "Flip": 0x200000,
    "Toon": 0x400000,
    "Xyz": 0x800000,
    "Pendulum": 0x1000000,
    "Special Summon": 0x2000000,
    "Link": 0x4000000,
}

ATTRIBUTE_BITS = {
    "EARTH": 0x1,
    "WATER": 0x2,
    "FIRE": 0x4,
    "WIND": 0x8,
    "LIGHT": 0x10,
    "DARK": 0x20,
    "DIVINE": 0x40,
    "NATURE": 0x80,
    "ELECTRIC": 0x100,
    "METAL": 0x200,
    "ICE": 0x400,
}

RACE_BITS = {
    "Warrior": 0x1,
    "Spellcaster": 0x2,
    "Fairy": 0x4,
    "Fiend": 0x8,
    "Zombie": 0x10,
    "Machine": 0x20,
    "Aqua": 0x40,
    "Pyro": 0x80,
    "Rock": 0x100,
    "Winged Beast": 0x200,
    "Plant": 0x400,
    "Insect": 0x800,
    "Thunder": 0x1000,
    "Dragon": 0x2000,
    "Beast": 0x4000,
    "Beast-Warrior": 0x8000,
    "Dinosaur": 0x10000,
    "Fish": 0x20000,
    "Sea Serpent": 0x40000,
    "Reptile": 0x80000,
    "Psychic": 0x100000,
    "Divine-Beast": 0x200000,
    "Creator God": 0x400000,
    "Wyrm": 0x800000,
    "Cyberse": 0x1000000,
    "Illusion": 0x2000000,
    "Cyborg": 0x4000000,
    "Magical Knight": 0x8000000,
    "Celestial Warrior": 0x40000000,
    "Galaxy": 0x80000000,
}

LINK_ARROW_BITS = {
    "BL": 0x1,
    "B": 0x2,
    "BR": 0x4,
    "L": 0x8,
    "Left": 0x8,
    "R": 0x20,
    "Right": 0x20,
    "TL": 0x40,
    "T": 0x80,
    "Top": 0x80,
    "TR": 0x100,
}

TREATED_AS_RE = re.compile(
    r"(?:always|also(?:\s+always)?)\s+treated\s+as\s+an?\s+\"([^\"]+)\"\s+card",
    re.IGNORECASE,
)

OMEGA_SET_CODES = {
    "gladiator": 0x19,
    "gladiatorbeast": 0x1019,
    "grayscale": 0x575D,
    "leet": 0xFE88,
    "scarstech": 0x52F8,
    "adamantiosthedarkarmor": 0x920D,
    "phlogistondragon": 0x0F78,
    "phlogisticuprising": 0x6F9E,
    "phlogistonsroar": 0x4376,
    "harpie": 0x079C,
    "thunderdragon": 0x335E,
    "nemleria": 0x191,
    "redeyes": 0x3B,
}

# Rows kept by older Omega DBs but not shipped with the current release assets.
RELEASE_EXCLUDED_LEGACY_IDS = {
    210678856: "Aquamarine Reef Hapalochlena",
    220812388: "Ash Blossom & Joyous Spring",
    239482600: "Pumqueen the Queen of Ghosts",
    242053169: "Bobbie Bluefin & the Nautical Nocrturnes",
    242748764: "Carina, Frogotten of Eldora",
    246320447: "The Forbidden Frute",
    247646578: "Stellaer of the Sky",
    247650478: "The Fruted Path",
    254434619: "Arckcestial Crystal Shard",
}

EXTRA_TOKEN_CARDS = [
    {
        "id": 98090004,
        "name": "Grayscale Token",
        "desc": 'Special Summoned by the effect of "Grayscale Awakening: Revelation".',
        "setcode": OMEGA_SET_CODES["grayscale"],
        "type": TYPE_BITS["Monster"] | TYPE_BITS["Normal"] | TYPE_BITS["Token"],
        "atk": 800,
        "def": 800,
        "level": 4,
        "race": RACE_BITS["Fiend"],
        "attribute": ATTRIBUTE_BITS["LIGHT"],
    },
]

CARD_STRING_OVERRIDES = {
    "nemleriasnightmare": [
        "Special Summon this card as an Effect Monster",
        "Banish 2 Extra Deck cards; destroy 1 opponent card",
    ],
    "nemleriasdreambedroom": [
        'Excavate cards, then Special Summon excavated "Nemleria" monsters',
        'Banish 2 Extra Deck cards; add 1 "Nemleria" card from GY',
        'Special Summon excavated "Nemleria" monsters',
    ],
    "nemleriadreamcreatorpyjama": [
        'Discard 1 "Nemleria"; place "Dreaming Nemleria" in Extra Deck; Special Summon this card',
        'Banish 2 Extra Deck cards; make 1 "Nemleria" card unaffected by earlier Chain effects',
        "Return 1 card your opponent controls to the hand",
    ],
    "nemleriadreamdevourersoleil": [
        "Banish 3 Extra Deck cards; Special Summon this card",
        'Send 1 Level 10 Beast; Special Summon 1 "Nemleria" monster from Deck',
    ],
    "pyjamapartyofhappynemleria": [
        'Banish 2 Extra Deck cards; add 1 "Nemleria" monster',
        "Banish 1 card your opponent controls",
    ],
    "nightnightnemleria": [
        'Place "Dreaming Nemleria" in Extra Deck; Set 1 "Nemleria" Spell/Trap',
    ],
    "rushatthegnome": [
        "Target 1 opponent monster; it cannot be Tributed or used as material this turn",
        "Activate this Trap from your hand while you control no cards",
    ],
    "calculeet": [
        "Target 1 Cyberse; add a Cyberse with matching ATK/DEF, then maybe banish the target",
    ],
    "digitaleet": [
        "Target 1 Cyberse; Special Summon this card, then maybe banish that target",
        "Fusion Summon 1 Cyberse Fusion Monster using this card",
        "Fusion monster gains 1000 ATK/DEF per zero-stat material",
    ],
    "virtualeet": [
        "Banish 1 Cyberse monster from your GY; destroy 1 opponent card",
    ],
    "gladiatorbeastsabearius": [
        'Special Summon 1 Beast "Test" monster from your Deck',
        'Shuffle this card into the Deck; Special Summon 1 "Gladiator Beast" monster',
    ],
    "gladiatorbeastattrocitar": [
        'Shuffle monsters you control; Special Summon "Gladiator Beast" monsters',
        'Shuffle this card into the Deck; Special Summon 1 "Gladiator Beast" monster',
    ],
    "gladiatorbeastsatyrius": [
        'Special Summon 1 Level 4 or lower "Gladiator Beast" monster',
        'Return this card to the Extra Deck; Special Summon 1 "Gladiator Beast" monster',
        'Special Summon "Gladiator Beast Satyrius" by shuffling 2 materials',
    ],
    "graylingthegrayscaleimp": [
        'Main Phase: send 1 "Grayscale" monster from Deck to GY',
        'If sent to GY: discard 1; add 1 Level 8 "Grayscale" monster',
    ],
    "graysentrytheguardofgrayscale": [
        'Main Phase: Special Summon this card from hand',
        'If Special Summoned: immediately Xyz Summon a "Grayscale" Xyz Monster',
        'If a "Grayscale" Link is Summoned: discard 1; Special Summon this from GY',
    ],
    "grayroverthewanderinggrayscale": [
        'Main Phase: Special Summon this card from hand',
        'If Special Summoned: immediately Link Summon a "Grayscale" Link Monster',
        'If a "Grayscale" Xyz is Summoned: discard 1; Special Summon this from GY',
    ],
    "graylockthesorcererofgrayscale": [
        'Main Phase: Special Summon this card from hand',
        'If Special Summoned: Set 1 "Grayscale" Spell/Trap from Deck',
        'If a "Grayscale" monster is Summoned: discard 1; Special Summon this from GY',
    ],
    "grayhexthechanterofgrayscale": [
        'Main Phase: Special Summon this card from hand',
        'If Special Summoned: add or send 1 "Grayscale" card from Deck',
        'Add the selected "Grayscale" card to your hand',
        'Send the selected "Grayscale" card to the GY',
        'If a "Grayscale" monster is Summoned: discard 1; Special Summon this from GY',
    ],
    "grayseerthegrayscalespy": [
        'Main Phase: discard 1; Special Summon 1 non-Link "Grayscale" from Deck/GY',
    ],
    "grayterrorthegrayscalebeast": [
        'Opponent monster effect: Tribute pointed "Grayscale"; rewrite that effect',
        'Then attach 1 monster from either GY to a "Grayscale" Xyz Monster?',
    ],
    "graydimmthegrayscaleshadow": [
        'Detach 1; Special Summon 1 "Grayscale" monster from your GY',
        'Opponent GY/banished effect: detach 1; rewrite that effect',
    ],
    "grayshadethephantomofgrayscale": [
        'Opponent Spell/Trap: detach 1; attach 1 GY Spell to your Xyz',
        'End Phase: detach 2; add 1 "Grayscale" card from your GY',
    ],
    "graydeuxtheeternalgrayscaleentity": [
        'Xyz Summon this using Rank 8 Xyz + Link-4 "Grayscale"',
        'If Xyz Summoned: attach opponent monsters up to your "Grayscale" count',
        'Opponent effect: detach 2; rewrite it to attach a monster',
    ],
    "grayscaleawakeningrevelation": [
        'Reveal 1 "Grayscale" monster; add different "Grayscale" monster, then discard',
        'GY: banish this; Special Summon 1 Grayscale Token',
    ],
    "grayscaleawakeningeclipse": [
        'Discard 1 "Grayscale" monster; draw 1 card',
        'Discard 1 card; Set 1 "Grayscale" Spell/Trap from your GY',
        'Use Eclipse: draw 1 or Set a "Grayscale" Spell/Trap from GY',
    ],
    "grayscaleawakeningnullbind": [
        'Activate: negate opponent monsters up to your Xyz/Link count',
        'GY: banish this; Special Summon 1 "Grayscale" monster negated',
        'Attach negated non-LIGHT monsters to a "Grayscale" Xyz Monster?',
    ],
    "nemleriabigeepy": [
        'Shuffle banished cards; Special Summon "Nemleria" monsters',
        "Banish this card; opponent banishes 3 Extra Deck cards; negate 1 opponent card",
        'Special Summon "Nemleria" monsters',
    ],
    "nemleriadreamcreatorveilleuse": [
        'Discard 1 "Nemleria"; place "Dreaming Nemleria" in Extra Deck; Special Summon this card',
        "Destroy 1 card your opponent controls",
        'Banish 3 Extra Deck cards; add 1 "Nemleria" Spell',
        'Add "Dreaming Nemleria" to your hand',
        'Shuffle "Dreaming Nemleria" into the Deck',
        'Recover "Dreaming Nemleria" from Extra Deck',
    ],
    "aipexlarva": [
        "Special Summon this card from your hand",
        "If Summoned: draw 1, reveal it, then Special Summon it if it is a Beast",
        'Beast monster effect: Tribute this; activate an "A.I.P" Trap this turn',
        "Special Summon the revealed Beast monster?",
    ],
    "aipexshrieker": [
        'Tribute this; Special Summon 2 Level 6 or lower "A.I.P Ex" monsters from Deck',
        'Banish this from GY instead of destroying your "A.I.P Ex" monster',
    ],
    "aipexclaw": [
        "Special Summon this card from your hand",
        "If Summoned: send 1 Beast monster from Deck to GY",
        'Beast monster effect: Tribute this; Special Summon 1 "A.I.P Ex" monster from GY',
        "Attach this card to the Xyz Monster as material?",
    ],
    "aipexmaw": [
        "Special Summon this card from your hand",
        'If Summoned: Set 1 "A.I.P" Trap from Deck',
        'Beast monster effect: Tribute this; rewrite it to destroy non-"A.I.P Ex" Beasts',
    ],
    "aipexpredator": [
        "Tribute 1 Beast monster; Special Summon this card from hand or GY",
        'If Summoned: Set 1 "A.I.P" Spell/Trap from Deck',
    ],
    "aiplab": [
        "Activate: optionally Special Summon 1 Beast monster from hand or GY",
        'Beast monster effect: all "A.I.P Ex" monsters you control gain 300 ATK',
        'If an "A.I.P Ex" monster is Special Summoned: change 1 Beast monster\'s Level by 3',
        "Special Summon 1 Beast monster from hand or GY?",
        "Increase Level by 3",
        "Decrease Level by 3",
    ],
    "failuresoftheaip": [
        'Attach 1 opponent monster to an "A.I.P Ex" Xyz Monster',
        'GY: banish this; shuffle another "A.I.P" Trap into Deck, then draw 1',
    ],
    "aipexassimilation": [
        'Take control of 1 opponent monster; treat it as "A.I.P" and negate it',
        'GY: banish this; shuffle another "A.I.P" Trap into Deck, then draw 1',
    ],
    "aipexhivemind": [
        "Target 1 monster in either GY; shuffle it, then draw or Xyz Summon",
        "Activate this Continuous Trap",
    ],
    "calleroftheaipex": [
        "If Special Summoned: Special Summon 1 Beast from hand or either GY",
        "Main Phase: detach 1; reorder the top 5 cards of both Decks",
    ],
    "zeromotheroftheaipex": [
        "Main Phase: detach 1; attach up to 2 monsters on the field to this card",
    ],
    "redeyesgearfriedtheironknight": [
        'If Summoned: add 1 "Red-Eyes" Spell/Trap, then lock Link Summons',
        'GY: banish this; shuffle 5 other "Red-Eyes" cards, then maybe draw',
        'Draw 1 card because "Red-Eyes Black Dragon" was shuffled?',
    ],
    "redeyesmoondragon": [
        "Equip this card from hand/GY to a monster you control",
        'Equipped: destroy another Dragon/Warrior/Fiend Monster Card; add a "Red-Eyes" monster',
    ],
    "redeyesmeteormetaldragon": [
        'If Summoned: equip 1 "Red-Eyes" monster from hand/GY',
        "Main Phase: Fusion Summon a Dragon/Warrior/Fiend Fusion Monster",
        'Fusion Material: equip this card to a "Red-Eyes" monster',
    ],
    "redeyesroar": [
        'Add 1 "Red-Eyes" monster from Deck to hand',
        'Equip 1 Level 4 or lower "Red-Eyes" monster to a face-up monster',
        "GY: banish this; Fusion Summon a Dragon/Warrior/Fiend Fusion Monster",
    ],
    "redeyesturbodragon": [
        'If Fusion Summoned: add 1 "Red-Eyes" Spell/Trap from Deck',
        "Main Phase: send 1 Equip Card; destroy 1 opponent card",
    ],
    "redeyesboosterdragon": [
        'If Fusion Summoned: add 1 "Red-Eyes" monster during this End Phase',
        'End Phase: add 1 "Red-Eyes" monster from Deck/GY',
        "Main Phase: send 1 Equip Card; negate 1 opponent monster",
    ],
    "heraldofwhitelight": [
        "If sent by card effect: add 1 Ritual Monster or Ritual Spell",
        "GY: banish this and discard Fairy; negate targeting effect",
    ],
    "thunderdragonbehemoth": [
        "Banish Thunder monsters from hand and field; Special Summon this",
        'If Special Summoned: add up to 2 "Thunder Dragon" cards, then discard 1',
        "Banish 1 Thunder from GY instead of destroying this card",
    ],
    "glitchlingbitron": [
        'Special Summon 1 "Bitron" from your hand, Deck, or GY',
        'Send 1 "Glitchling" Spell/Trap; apply its activation effect',
        "Place 1 Corruption Counter on a card on the field?",
    ],
    "glitchlingprotron": [
        'Special Summon 1 "Protron" from your hand, Deck, or GY',
        'Tribute this card; Ritual Summon 1 "Glitchling" Ritual Monster',
        "Place 1 Corruption Counter on a card on the field?",
    ],
    "glitchlingwitch": [
        'Reveal this card and another monster; add 1 "Glitchling" monster',
        'Ritual Summon 1 "Glitchling" Ritual Monster from Deck or Extra Deck',
    ],
    "glitchlingdatatransfert": [
        "Banish this card; Pendulum Summon a Cyberse monster",
    ],
    "glitchlingoctron": [
        'Add up to 2 "Glitchling" cards from GY/banishment/Extra Deck',
        "Banish this card; place Corruption Counters",
    ],
    "glitchlingdigitron": [
        'Special Summon 1 "Digitron" from your hand, Deck, or GY',
        "Tribute 1 Cyberse; negate a hand/GY monster effect",
        "Place 1 Corruption Counter on a card on the field?",
    ],
    "glitchlingmage": [
        "Ritual Summon Cyberse Ritual Monsters using Cyberse monsters you control",
        'Reveal this card and another monster; add 1 "Glitchling" Spell/Trap',
        "Ritual Summon 1 Cyberse Ritual Monster using hand/Deck materials",
    ],
    "glitchlingleotron": [
        'Destroy this card; Ritual Summon 1 "Glitchling" Ritual Monster',
        'Special Summon "Bitron", "Protron", or "Digitron"',
        "Tribute Cyberse monsters; negate a Spell/Trap effect",
        'Special Summon a "Glitchling" monster that mentions it?',
    ],
    "glitchlingcorruption": [
        'Add 1 "Glitchling" card from Deck or face-up Extra Deck?',
        'Ritual Summon 1 "Glitchling" monster from GY or Extra Deck',
        "Place Corruption Counters on this card",
    ],
    "glitchlinghexatron": [
        "Add Cyberse Ritual and Ritual Spell/Cyberse Normal cards",
        "Remove counters; destroy your card; negate and gain ATK",
    ],
    "aureliondivineillumination": [
        "Declare up to 3 names; excavate bottom 3; maybe Special Summon this",
        "Return this card to hand; negate opponent activation",
        "Declare another card name?",
    ],
    "lanceluminarjusticiar": [
        'If opponent Special Summons: Special Summon this, then maybe add "Aurelion"',
        "Opponent Special Summons: draw 1, then bottom 1 hand card",
        'Add "Aurelion Divine Illumination" from Deck to hand?',
    ],
    "scarstechdraco": [
        "CL2+: Special Summon this card from your hand",
        'If Summoned: shuffle up to 5 "Scarstech" cards, then draw 1',
    ],
    "scarstechwyvern": [
        "CL2+: Special Summon this card from your hand",
        'If Summoned: send 1 "Scarstech" monster from Deck to GY',
        'CL2+: "Scarstech" monsters gain 100 ATK/DEF x Chain Link',
    ],
    "scarstechinvader": [
        "CL3+: send this to GY; take control, make DARK/Galaxy",
        'GY: CL5+ or "Scarstech" activation; Special Summon this',
    ],
    "gananthescarstechcity": [
        "When a card/effect resolves: this card gains 300 ATK",
    ],
    "qeretsthescarstechmothership": [
        'When a card/effect resolves: your "Scarstech" monsters gain 300 ATK',
        "Lose exactly 3000 ATK; negate that targeting activation",
    ],
    "adamantiosthedarkarmor": [
        "Detach 1 material; equip 1 Equip Spell from hand, Deck, or GY",
        "Destroy 1 Equip Spell you control instead of this leaving",
    ],
    "discipleoffire": [
        'Reveal this card; add "Phlogistic Uprising!"',
        "GY after LP paid: discard 1; add 1 FIRE monster from GY",
        "GY after LP paid: Special Summon this, then maybe gain LP",
    ],
    "sorceressoffire": [
        'Shuffle up to 2 "Phlogist" Spell/Trap Cards; Special Summon this',
        'Discard this; pay LP; send 1 monster that lists "Phlogiston Dragon"',
    ],
    "phlogistonsroar": [
        "Set-turn permission during your turn",
        'Pay LP; negate opponent monster effect with higher ATK than "Phlogiston Dragon"',
        "GY after LP paid: Set this card, then banish it when it leaves",
    ],
    "harpiecyberdancer": [
        'Return 1 "Harpie Lady" monster; Special Summon this card',
        'Send 1 "Harpie" monster; Normal Summon 1 Winged Beast',
        'If sent from field to GY: Set 1 "Harpie Lady" Spell/Trap',
    ],
    "harpieladysistersphoenixformation": [
        'If Synchro Summoned: destroy cards using "Harpie Lady" GY targets',
        'Tribute this; Special Summon "Harpie Lady" monsters, then bounce cards',
    ],
    "mirageformationdragon": [
        'Reveal this and "Elegant Egotist"; Special Summon this with material',
        'If Special Summoned from Extra Deck: Set "Harpie Lady" Spell/Trap Cards',
        "Detach 1; target 1 card you control and 1 opponent face-up card",
        "Return both targeted cards to the hand",
        "Destroy both targeted cards",
    ],
}


def normalize_name(value: str | None) -> str:
    text = unicodedata.normalize("NFKD", value or "")
    text = text.lower()
    text = (
        text.replace("’", "'")
        .replace("“", '"')
        .replace("”", '"')
        .replace("—", "-")
        .replace("–", "-")
    )
    return re.sub(r"[^a-z0-9]+", "", text)


def canonical_display_name(value: str | None) -> str:
    return str(value or "").strip()


def parse_card_number(card_id: str) -> int | None:
    match = re.fullmatch(r"CARD-(\d+)", card_id)
    if not match:
        return None
    return int(match.group(1))


def decode_setcodes(blob: bytes | None) -> list[int]:
    if not blob:
        return []
    if len(blob) % 2 != 0:
        return []
    codes: list[int] = []
    for i in range(0, len(blob), 2):
        codes.append(int.from_bytes(blob[i : i + 2], "little"))
    return [code for code in codes if code]


def encode_setcodes(codes: list[int]) -> bytes:
    unique: list[int] = []
    seen: set[int] = set()
    for code in codes:
        if code and code not in seen:
            seen.add(code)
            unique.append(code)
    return b"".join(code.to_bytes(2, "little", signed=False) for code in unique)


def infer_spell_trap_icon(card: dict[str, Any]) -> str | None:
    icon = card.get("icon")
    if icon:
        return str(icon)
    card_types = card.get("cardTypes") or []
    if card_types:
        return str(card_types[0])
    return None


def build_type(card: dict[str, Any]) -> int:
    category = str(card.get("category") or "")
    if category == "Monster":
        value = TYPE_BITS["Monster"]
        card_types = {str(x) for x in (card.get("cardTypes") or [])}
        if "Normal" in card_types and "Effect" not in card_types:
            value |= TYPE_BITS["Normal"]
        for bit_name in (
            "Effect",
            "Fusion",
            "Ritual",
            "Spirit",
            "Union",
            "Gemini",
            "Tuner",
            "Synchro",
            "Token",
            "Flip",
            "Toon",
            "Xyz",
            "Pendulum",
            "Link",
        ):
            if bit_name in card_types:
                value |= TYPE_BITS[bit_name]
        return value
    if category == "Spell":
        value = TYPE_BITS["Spell"]
        icon = infer_spell_trap_icon(card)
        if icon and icon != "Normal" and icon in TYPE_BITS:
            value |= TYPE_BITS[icon]
        return value
    if category == "Trap":
        value = TYPE_BITS["Trap"]
        icon = infer_spell_trap_icon(card)
        if icon and icon != "Normal" and icon in TYPE_BITS:
            value |= TYPE_BITS[icon]
        return value
    raise ValueError(f"Unsupported category for {card.get('id')}: {category}")


def build_attribute(card: dict[str, Any]) -> int:
    category = str(card.get("category") or "")
    if category != "Monster":
        return 0
    attr = str(card.get("attribute") or "").strip().upper()
    return ATTRIBUTE_BITS.get(attr, 0)


def build_race(card: dict[str, Any]) -> int:
    category = str(card.get("category") or "")
    if category != "Monster":
        return 0
    monster_types = card.get("monsterType") or []
    if not monster_types:
        return 0
    race_name = str(monster_types[0]).strip()
    if race_name not in RACE_BITS:
        raise ValueError(f"Unsupported monster type for {card.get('id')}: {race_name}")
    return RACE_BITS[race_name]


def build_level(card: dict[str, Any]) -> int:
    category = str(card.get("category") or "")
    if category != "Monster":
        return 0
    card_types = {str(x) for x in (card.get("cardTypes") or [])}
    base = 0
    if "Link" in card_types:
        base = int(card.get("linkRating") or 0)
    elif "Xyz" in card_types:
        base = int(card.get("rank") or 0)
    else:
        base = int(card.get("level") or 0)
    if "Pendulum" in card_types:
        scale = int(card.get("scale") or 0)
        base |= scale << 16
        base |= scale << 24
    return base


def build_def(card: dict[str, Any]) -> int:
    category = str(card.get("category") or "")
    if category != "Monster":
        return 0
    card_types = {str(x) for x in (card.get("cardTypes") or [])}
    if "Link" not in card_types:
        return int(card.get("def") or 0)
    arrows = 0
    for arrow in card.get("linkArrows") or []:
        arrows |= LINK_ARROW_BITS.get(str(arrow), 0)
    return arrows


def infer_primary_ot(_existing_ot: int | None) -> int:
    # Keep CCG cards visible under the CCG deck/card-pool workflow in Omega.
    return 0


def extract_treated_as_names(text: str | None) -> list[str]:
    if not text:
        return []
    seen: set[str] = set()
    names: list[str] = []
    for match in TREATED_AS_RE.finditer(text):
        name = canonical_display_name(match.group(1))
        key = normalize_name(name)
        if key and key not in seen:
            seen.add(key)
            names.append(name)
    return names


def allocate_setcode(name: str, used_codes: set[int]) -> int:
    base = (zlib.crc32(name.encode("utf-8")) % 0xFFFE) + 1
    code = base
    while code in used_codes:
        code += 1
        if code > 0xFFFF:
            code = 1
        if code == base:
            raise RuntimeError("No free setcodes remain")
    used_codes.add(code)
    return code


def allocate_passcode(source_id: str, used_ids: set[int]) -> int:
    base = 259000000 + (zlib.crc32(source_id.encode("utf-8")) % 1000000)
    value = base
    while value in used_ids:
        value += 1
        if value > 259999999:
            value = 259000000
        if value == base:
            raise RuntimeError("No free passcodes remain in the custom range")
    used_ids.add(value)
    return value


def load_cards(cards_path: Path) -> list[dict[str, Any]]:
    return json.loads(cards_path.read_text(encoding="utf-8"))


def load_existing_rows(conn: sqlite3.Connection) -> list[sqlite3.Row]:
    conn.row_factory = sqlite3.Row
    return conn.execute(
        """
        select
            d.id,
            d.ot,
            d.alias,
            d.setcode,
            d.type,
            d.atk,
            d.def,
            d.level,
            d.race,
            d.attribute,
            d.category,
            d.genre,
            d.script,
            d.support,
            t.name,
            t.desc,
            t.str1,
            t.str2,
            t.str3,
            t.str4,
            t.str5,
            t.str6,
            t.str7,
            t.str8,
            t.str9,
            t.str10,
            t.str11,
            t.str12,
            t.str13,
            t.str14,
            t.str15,
            t.str16
        from datas d
        join texts t using(id)
        """
    ).fetchall()


def prune_release_excluded_rows(conn: sqlite3.Connection) -> int:
    ids = tuple(RELEASE_EXCLUDED_LEGACY_IDS)
    placeholders = ", ".join("?" for _ in ids)
    existing_count = conn.execute(
        f"select count(*) from datas where id in ({placeholders})",
        ids,
    ).fetchone()[0]
    conn.execute(f"delete from texts where id in ({placeholders})", ids)
    conn.execute(f"delete from datas where id in ({placeholders})", ids)
    return int(existing_count)


def prune_helper_rows(conn: sqlite3.Connection) -> int:
    ids = tuple(
        int(row[0])
        for row in conn.execute(
            """
            select id
            from texts
            where name like 'CCG %Helper%'
            """
        )
    )
    if not ids:
        return 0

    placeholders = ", ".join("?" for _ in ids)
    conn.execute(f"delete from texts where id in ({placeholders})", ids)
    conn.execute(f"delete from datas where id in ({placeholders})", ids)
    return len(ids)


def build_existing_setcode_map(cards: list[dict[str, Any]], rows: list[sqlite3.Row]) -> tuple[dict[str, int], set[int]]:
    source_by_norm = {normalize_name(canonical_display_name(card.get("name"))): card for card in cards}
    candidates: dict[str, Counter[int]] = defaultdict(Counter)
    used_codes: set[int] = set()
    for row in rows:
        codes = decode_setcodes(row["setcode"])
        used_codes.update(codes)
        card = source_by_norm.get(normalize_name(row["name"]))
        if not card or not codes:
            continue
        tags: list[str] = []
        if card.get("archetype"):
            tags.append(canonical_display_name(card["archetype"]))
        tags.extend(extract_treated_as_names(card.get("text")))
        if not tags:
            continue
        first_tag_key = normalize_name(tags[0])
        candidates[first_tag_key][codes[0]] += 1
        if len(tags) == len(codes):
            for tag, code in zip(tags, codes, strict=False):
                candidates[normalize_name(tag)][code] += 1
    setcode_map: dict[str, int] = dict(OMEGA_SET_CODES)
    for key, counter in candidates.items():
        code, _count = counter.most_common(1)[0]
        setcode_map.setdefault(key, code)
    used_codes.update(OMEGA_SET_CODES.values())
    return setcode_map, used_codes


def build_text_row(card_id: int, card: dict[str, Any]) -> dict[str, Any]:
    row = {
        "id": card_id,
        "name": canonical_display_name(card.get("name")),
        "desc": str(card.get("text") or ""),
    }
    for idx in range(1, 17):
        row[f"str{idx}"] = None
    for idx, value in enumerate(CARD_STRING_OVERRIDES.get(normalize_name(row["name"]), []), start=1):
        row[f"str{idx}"] = value
    return row


def build_data_row(
    card_id: int,
    card: dict[str, Any],
    setcode_map: dict[str, int],
    used_setcodes: set[int],
    existing_row: sqlite3.Row | None,
) -> dict[str, Any]:
    tags: list[str] = []
    archetype = canonical_display_name(card.get("archetype"))
    if archetype:
        tags.append(archetype)
    tags.extend(extract_treated_as_names(card.get("text")))
    setcodes: list[int] = []
    seen_codes: set[int] = set()
    for tag in tags:
        key = normalize_name(tag)
        if not key:
            continue
        if key not in setcode_map:
            setcode_map[key] = allocate_setcode(tag, used_setcodes)
        code = setcode_map[key]
        if code not in seen_codes:
            seen_codes.add(code)
            setcodes.append(code)
    return {
        "id": card_id,
        "ot": infer_primary_ot(existing_row["ot"] if existing_row else None),
        "alias": int(existing_row["alias"]) if existing_row else 0,
        "setcode": encode_setcodes(setcodes),
        "type": build_type(card),
        "atk": int(card.get("atk") or 0),
        "def": build_def(card),
        "level": build_level(card),
        "race": build_race(card),
        "attribute": build_attribute(card),
        "category": int(existing_row["category"]) if existing_row else 0,
        "genre": int(existing_row["genre"]) if existing_row else 0,
        "script": bytes(existing_row["script"]) if existing_row and existing_row["script"] is not None else b"",
        "support": bytes(existing_row["support"]) if existing_row and existing_row["support"] is not None else b"\x00",
    }


def backup_db(db_path: Path) -> Path:
    timestamp = dt.datetime.now().strftime("%Y%m%d_%H%M%S")
    backup_path = db_path.with_suffix(f".bak_{timestamp}{db_path.suffix}")
    shutil.copy2(db_path, backup_path)
    return backup_path


def sync_db(cards_path: Path, db_path: Path, map_path: Path, insert_only: bool) -> dict[str, Any]:
    cards = load_cards(cards_path)
    conn = sqlite3.connect(db_path)
    try:
        rows = load_existing_rows(conn)
        existing_by_norm = {normalize_name(row["name"]): row for row in rows}
        used_ids = {int(row["id"]) for row in rows}
        setcode_map, used_setcodes = build_existing_setcode_map(cards, rows)

        inserted = 0
        updated = 0
        preserved = 0
        unresolved_type_counts: Counter[str] = Counter()
        mapping_output: list[dict[str, Any]] = []

        for card in cards:
            name = canonical_display_name(card.get("name"))
            norm_name = normalize_name(name)
            existing_row = existing_by_norm.get(norm_name)
            if existing_row is not None:
                card_id = int(existing_row["id"])
                action = "preserved"
                if not insert_only:
                    updated += 1
                    action = "updated"
                else:
                    preserved += 1
            else:
                card_id = allocate_passcode(str(card.get("id")), used_ids)
                inserted += 1
                action = "inserted"

            try:
                data_row = build_data_row(card_id, card, setcode_map, used_setcodes, existing_row)
            except ValueError as exc:
                unresolved_type_counts[str(exc)] += 1
                raise

            text_row = build_text_row(card_id, card)
            mapping_output.append(
                {
                    "source_id": str(card.get("id")),
                    "omega_id": card_id,
                    "name": name,
                    "status": action,
                    "set": str(card.get("set") or ""),
                    "archetype": str(card.get("archetype") or ""),
                }
            )

            if existing_row is not None and insert_only:
                continue

            conn.execute(
                """
                insert into datas (
                    id, ot, alias, setcode, type, atk, def, level, race, attribute,
                    category, genre, script, support
                ) values (
                    :id, :ot, :alias, :setcode, :type, :atk, :def, :level, :race, :attribute,
                    :category, :genre, :script, :support
                )
                on conflict(id) do update set
                    ot=excluded.ot,
                    alias=excluded.alias,
                    setcode=excluded.setcode,
                    type=excluded.type,
                    atk=excluded.atk,
                    def=excluded.def,
                    level=excluded.level,
                    race=excluded.race,
                    attribute=excluded.attribute,
                    category=excluded.category,
                    genre=excluded.genre,
                    script=excluded.script,
                    support=excluded.support
                """,
                data_row,
            )
            conn.execute(
                """
                insert into texts (
                    id, name, desc,
                    str1, str2, str3, str4, str5, str6, str7, str8,
                    str9, str10, str11, str12, str13, str14, str15, str16
                ) values (
                    :id, :name, :desc,
                    :str1, :str2, :str3, :str4, :str5, :str6, :str7, :str8,
                    :str9, :str10, :str11, :str12, :str13, :str14, :str15, :str16
                )
                on conflict(id) do update set
                    name=excluded.name,
                    desc=excluded.desc,
                    str1=excluded.str1,
                    str2=excluded.str2,
                    str3=excluded.str3,
                    str4=excluded.str4,
                    str5=excluded.str5,
                    str6=excluded.str6,
                    str7=excluded.str7,
                    str8=excluded.str8,
                    str9=excluded.str9,
                    str10=excluded.str10,
                    str11=excluded.str11,
                    str12=excluded.str12,
                    str13=excluded.str13,
                    str14=excluded.str14,
                    str15=excluded.str15,
                    str16=excluded.str16
                """,
                text_row,
            )

        for token in EXTRA_TOKEN_CARDS:
            conn.execute(
                """
                insert into datas (
                    id, ot, alias, setcode, type, atk, def, level, race, attribute,
                    category, genre, script, support
                ) values (
                    :id, 0, 0, :setcode, :type, :atk, :def, :level, :race, :attribute,
                    0, 0, null, x'00'
                )
                on conflict(id) do update set
                    ot=excluded.ot,
                    alias=excluded.alias,
                    setcode=excluded.setcode,
                    type=excluded.type,
                    atk=excluded.atk,
                    def=excluded.def,
                    level=excluded.level,
                    race=excluded.race,
                    attribute=excluded.attribute,
                    category=excluded.category,
                    genre=excluded.genre,
                    script=excluded.script,
                    support=excluded.support
                """,
                {
                    **token,
                    "setcode": encode_setcodes([int(token["setcode"])]),
                },
            )
            conn.execute(
                """
                insert into texts (
                    id, name, desc,
                    str1, str2, str3, str4, str5, str6, str7, str8,
                    str9, str10, str11, str12, str13, str14, str15, str16
                ) values (
                    :id, :name, :desc,
                    null, null, null, null, null, null, null, null,
                    null, null, null, null, null, null, null, null
                )
                on conflict(id) do update set
                    name=excluded.name,
                    desc=excluded.desc,
                    str1=excluded.str1,
                    str2=excluded.str2,
                    str3=excluded.str3,
                    str4=excluded.str4,
                    str5=excluded.str5,
                    str6=excluded.str6,
                    str7=excluded.str7,
                    str8=excluded.str8,
                    str9=excluded.str9,
                    str10=excluded.str10,
                    str11=excluded.str11,
                    str12=excluded.str12,
                    str13=excluded.str13,
                    str14=excluded.str14,
                    str15=excluded.str15,
                    str16=excluded.str16
                """,
                token,
            )

        pruned_legacy_rows = prune_release_excluded_rows(conn)
        pruned_helper_rows = prune_helper_rows(conn)
        # The CCG database uses one Omega card-pool behavior for all of its rows,
        # including retained legacy rows that are not in the current card source.
        conn.execute("update datas set ot=0 where ot<>0")
        conn.commit()
        if pruned_legacy_rows:
            conn.execute("vacuum")
        map_path.parent.mkdir(parents=True, exist_ok=True)
        map_path.write_text(json.dumps(mapping_output, indent=2), encoding="utf-8")

        final_counts = conn.execute(
            "select (select count(*) from datas), (select count(*) from texts)"
        ).fetchone()
        return {
            "cards_in_source": len(cards),
            "inserted": inserted,
            "updated": updated,
            "preserved": preserved,
            "pruned_legacy_rows": pruned_legacy_rows,
            "pruned_helper_rows": pruned_helper_rows,
            "datas_count": final_counts[0],
            "texts_count": final_counts[1],
            "setcode_map_size": len(setcode_map),
            "mapping_path": str(map_path),
        }
    finally:
        conn.close()


def main() -> None:
    parser = argparse.ArgumentParser(description="Sync cards.json into the Omega CCG_v1 database.")
    parser.add_argument("--cards", type=Path, default=DEFAULT_CARDS_PATH)
    parser.add_argument("--db", type=Path, default=DEFAULT_DB_PATH)
    parser.add_argument("--map-out", type=Path, default=DEFAULT_MAP_PATH)
    parser.add_argument("--no-backup", action="store_true")
    parser.add_argument("--full-sync", action="store_true", help="Update existing matched rows as well as insert missing cards.")
    args = parser.parse_args()

    if not args.cards.exists():
        raise SystemExit(f"cards.json not found: {args.cards}")
    if not args.db.exists():
        raise SystemExit(f"Omega DB not found: {args.db}")

    backup_path = None
    if not args.no_backup:
        backup_path = backup_db(args.db)

    result = sync_db(
        cards_path=args.cards,
        db_path=args.db,
        map_path=args.map_out,
        insert_only=not args.full_sync,
    )

    if backup_path is not None:
        print(f"backup={backup_path}")
    for key, value in result.items():
        print(f"{key}={value}")


if __name__ == "__main__":
    main()

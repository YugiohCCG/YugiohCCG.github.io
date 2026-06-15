from __future__ import annotations

import asyncio
import json
import re
from dataclasses import dataclass
from datetime import datetime
from pathlib import Path
from typing import Any, Callable

import cv2
import numpy as np
from PIL import Image, ImageOps
from winrt.windows.graphics.imaging import BitmapDecoder
from winrt.windows.media.ocr import OcrEngine
from winrt.windows.storage import FileAccessMode, StorageFile


REPO_ROOT = Path(__file__).resolve().parents[1]
CARDS_PATH = REPO_ROOT / "src" / "data" / "cards.json"
ASSETS_DIR = REPO_ROOT / "public" / "assets" / "cards"
OUTPUT_DIR = REPO_ROOT / "scripts" / "output"
PUBLIC_ROOT = REPO_ROOT / "public"

SET_CODE = "VEIL"
SET_NAME = "Veil of Eternity"
ADDED_DATE = "2026-04-26"
RECENT_CUTOFF = datetime(2026, 4, 24, 0, 0, 0).timestamp()

REF_WIDTH = 813
REF_HEIGHT = 1185
LEVEL_SLOT_CENTERS = [186 + 92 * index for index in range(12)]

FULL_BOX = (0, 0, REF_WIDTH, REF_HEIGHT)
TOP_RIGHT_OCR_BOX = (650, 5, 810, 145)
ATTRIBUTE_FEATURE_BOX = (680, 12, 806, 122)
CATEGORY_FEATURE_BOX = (650, 5, 810, 145)
MONSTER_TEXT_BOX = (40, 875, 770, 1085)
SPELL_TRAP_TEXT_BOX = (40, 885, 770, 1115)
SPELL_TRAP_TYPE_BOX = (350, 135, 760, 220)
SPELL_TRAP_ICON_FEATURE_BOX = (660, 140, 755, 220)
STATS_BOX = (500, 1040, 790, 1120)

ATTRIBUTE_ALIASES = {
    "DARK": "DARK",
    "LIGHT": "LIGHT",
    "FIRE": "FIRE",
    "WATER": "WATER",
    "WIND": "WIND",
    "EARTH": "EARTH",
    "DIVINE": "DIVINE",
}

SPECIES_ALIASES = {
    "AQUA": "Aqua",
    "BEAST": "Beast",
    "BEAST WARRIOR": "Beast-Warrior",
    "BEAST-WARRIOR": "Beast-Warrior",
    "CELESTIAL WARRIOR": "Celestial Warrior",
    "CYBERSE": "Cyberse",
    "CYBORG": "Cyborg",
    "DINOSAUR": "Dinosaur",
    "DIVINE BEAST": "Divine-Beast",
    "DIVINE-BEAST": "Divine-Beast",
    "DRAGON": "Dragon",
    "FAIRV": "Fairy",
    "FAIRY": "Fairy",
    "FIEND": "Fiend",
    "FISH": "Fish",
    "GALAXY": "Galaxy",
    "ILLUSION": "Illusion",
    "INSECT": "Insect",
    "MACHINE": "Machine",
    "MAGICAL KNIGHT": "Magical Knight",
    "PLANT": "Plant",
    "PSYCHIC": "Psychic",
    "PYRO": "Pyro",
    "REPTILE": "Reptile",
    "ROCK": "Rock",
    "SEA SERPENT": "Sea Serpent",
    "SEA-SERPENT": "Sea Serpent",
    "SPELLCASTER": "Spellcaster",
    "THUNDER": "Thunder",
    "WARRIOR": "Warrior",
    "WINGED BEAST": "Winged Beast",
    "WINGED-BEAST": "Winged Beast",
    "ZOMBIE": "Zombie",
}

CARD_TYPE_ALIASES = {
    "EFFECT": "Effect",
    "NORMAL": "Normal",
    "FUSION": "Fusion",
    "SYNCHRO": "Synchro",
    "XYZ": "Xyz",
    "XVZ": "Xyz",
    "XZY": "Xyz",
    "LINK": "Link",
    "PENDULUM": "Pendulum",
    "RITUAL": "Ritual",
    "TUNER": "Tuner",
    "FLIP": "Flip",
    "SPIRIT": "Spirit",
    "GEMINI": "Gemini",
    "UNION": "Union",
    "TOON": "Toon",
    "TOKEN": "Token",
}

SPELL_TRAP_ICON_ALIASES = {
    "CONTINUOUS": "Continuous",
    "QUICK PLAY": "Quick-Play",
    "QUICK-PLAY": "Quick-Play",
    "EQUIP": "Equip",
    "FIELD": "Field",
    "RITUAL": "Ritual",
    "COUNTER": "Counter",
    "NORMAL": "Normal",
}

NAME_OVERRIDES = {
    "Adamantios the Dark Armor": "Adamantios, the Dark Armor",
    "Galatea-2 the Orcust Divider": "Galatea-2, the Orcust Divider",
    "Ganan the Scarstech City": "Ganan, the Scarstech City",
    "Graydeux the Eternal Grayscale Entity": "Graydeux, the Eternal Grayscale Entity",
    "Graydimm the Grayscale Shadow": "Graydimm, the Grayscale Shadow",
    "Grayhex the Chanter of Grayscale": "Grayhex, the Chanter of Grayscale",
    "Grayling the Grayscale Imp": "Grayling, the Grayscale Imp",
    "Graylock the Sorcerer of Grayscale": "Graylock, the Sorcerer of Grayscale",
    "Grayrover the Wandering Grayscale": "Grayrover, the Wandering Grayscale",
    "Grayseer the Grayscale Spy": "Grayseer, the Grayscale Spy",
    "Graysentry the Guard of Grayscale": "Graysentry, the Guard of Grayscale",
    "Grayshade the Phantom of Grayscale": "Grayshade, the Phantom of Grayscale",
    "Grayterror the Grayscale Beast": "Grayterror, the Grayscale Beast",
    "Nemlerias Dream Bedroom": "Nemleria's Dream Bedroom",
    "Nemlerias Nightmare": "Nemleria's Nightmare",
    "Phlogistons Roar": "Phlogiston's Roar",
    "Qerets the Scarstech Mother Ship": "Qerets, the Scarstech Mother Ship",
}

SPELL_TRAP_ICON_OVERRIDES = {
    "A.I.P Ex Hive Mind": "Continuous",
    "A.I.P Lab": "Field",
    "Charmelia Pray": "Ritual",
    "Glitchling Data-Transfert": "Ritual",
    "Heart of the Cards": "Normal",
    "Nemleria's Dream Bedroom": "Field",
    "Nemleria's Nightmare": "Continuous",
    "Spellbook of Eclipse": "Quick-Play",
    "Stellaer's Pain": "Counter",
    "Wyvernal Sanctuary": "Field",
}

CARD_TYPE_OVERRIDES = {
    # These use a Pendulum frame/scale, but their printed type line omits the
    # Pendulum subtype.
    "Glitchling Leotron": ["Ritual", "Pendulum", "Effect"],
    "Glitchling Mage": ["Ritual", "Pendulum", "Effect"],
}

LINK_ARROW_OVERRIDES = {
    "Galatea-2, the Orcust Divider": ["TL", "TR", "BR"],
    "Ganan, the Scarstech City": ["T", "L", "R", "BR"],
    "Glitchling Hexatron": ["L", "BL", "B"],
    "Glitchling Octron": ["L", "R"],
    "Grayseer, the Grayscale Spy": ["L", "BR"],
    "Grayterror, the Grayscale Beast": ["L", "R", "BL", "BR"],
    "Qerets, the Scarstech Mother Ship": ["T", "R", "BL", "B", "BR"],
}

SCALE_OVERRIDES = {
    "Glitchling Leotron": 0,
    "Glitchling Mage": 5,
    "Glitchling Witch": 0,
}

ATTRIBUTE_OVERRIDES = {
    # Filled after visual review where the classifier and OCR both miss.
    "Glitchling Leotron": "EARTH",
}

STATS_OVERRIDES = {
    "Qerets, the Scarstech Mother Ship": {"atk": 0, "def": None, "linkRating": 5},
}

ARCHETYPE_OVERRIDES = {
    "A.I.P Ex Assimilation": "A.I.P",
    "A.I.P Ex Claw": "A.I.P",
    "A.I.P Ex Hive Mind": "A.I.P",
    "A.I.P Ex Larva": "A.I.P",
    "A.I.P Ex Maw": "A.I.P",
    "A.I.P Ex Predator": "A.I.P",
    "A.I.P Ex Shrieker": "A.I.P",
    "A.I.P Lab": "A.I.P",
    "Caller of the A.I.P Ex": "A.I.P",
    "Failures of the A.I.P": "A.I.P",
    "The Misstakes of the A.I.P Experience": "A.I.P",
    "Zero Mother of the A.I.P Ex": "A.I.P",
    "Charmelia Beast": "Charmelia",
    "Charmelia Deal": "Charmelia",
    "Charmelia Elysia": "Charmelia",
    "Charmelia Fairy Kyubey": "Charmelia",
    "Charmelia Fairy Morningstar": "Charmelia",
    "Charmelia Hanabi": "Charmelia",
    "Charmelia Kiana": "Charmelia",
    "Charmelia Pray": "Charmelia",
    "Charmelia Robin": "Charmelia",
    "Calcu Leet": "Leet",
    "Digita Leet": "Leet",
    "Eclipse Observatory": "Eclipse",
    "Eclipse Observer Aaliyah": "Eclipse",
    "Eclipse Observer Baleygr": "Eclipse",
    "Eclipse Observer Chandra": "Eclipse",
    "Eclipse Observer Ella": "Eclipse",
    "Eclipse Observer Maya": "Eclipse",
    "Eclipse Observer Nora": "Eclipse",
    "Eclipse Observer Riley": "Eclipse",
    "Eclipse Observer Seara": "Eclipse",
    "Encyclopedia of Eclipse": "Eclipse",
    "Grimoire of Eclipse": "Eclipse",
    "Manual of Eclipse": "Eclipse",
    "Spellbook of Eclipse": "Eclipse",
    "Tome of Eclipse": "Eclipse",
    "Galatea-2, the Orcust Divider": "Orcust",
    "The Orcustograph": "Orcust",
    "Gladiator Beast Attrocitar": "Gladiator Beast",
    "Gladiator Beast Sabearius": "Gladiator Beast",
    "Gladiator Beast Satyrius": "Gladiator Beast",
    "Glitchling Bitron": "Glitchling",
    "Glitchling Corruption": "Glitchling",
    "Glitchling Data-Transfert": "Glitchling",
    "Glitchling Digitron": "Glitchling",
    "Glitchling Hexatron": "Glitchling",
    "Glitchling Leotron": "Glitchling",
    "Glitchling Mage": "Glitchling",
    "Glitchling Octron": "Glitchling",
    "Glitchling Protron": "Glitchling",
    "Glitchling Witch": "Glitchling",
    "Graydeux, the Eternal Grayscale Entity": "Grayscale",
    "Graydimm, the Grayscale Shadow": "Grayscale",
    "Grayhex, the Chanter of Grayscale": "Grayscale",
    "Grayling, the Grayscale Imp": "Grayscale",
    "Graylock, the Sorcerer of Grayscale": "Grayscale",
    "Grayrover, the Wandering Grayscale": "Grayscale",
    "Grayscale Awakening: Eclipse": "Grayscale",
    "Grayscale Awakening: Nullbind": "Grayscale",
    "Grayscale Awakening: Revelation": "Grayscale",
    "Grayseer, the Grayscale Spy": "Grayscale",
    "Graysentry, the Guard of Grayscale": "Grayscale",
    "Grayshade, the Phantom of Grayscale": "Grayscale",
    "Grayterror, the Grayscale Beast": "Grayscale",
    "Harpie Cyber Dancer": "Harpie",
    "Harpie Lady Sisters - Phoenix Formation": "Harpie",
    "Herald of White Light": "Herald",
    "Lance Luminar Justiciar": "Luminar",
    "Nemleria Big Eepy": "Nemleria",
    "Nemleria Dream Creator - Veilleuse": "Nemleria",
    "Nemleria Dream Creator Pyjama": "Nemleria",
    "Nemleria Dream Devourer - Soleil": "Nemleria",
    "Nemleria's Dream Bedroom": "Nemleria",
    "Nemleria's Nightmare": "Nemleria",
    "Night Night Nemleria": "Nemleria",
    "Pyjama Party of Happy Nemleria": "Nemleria",
    "Red-Eyes Booster Dragon": "Red-Eyes",
    "Red-Eyes Gearfried the Iron Knight": "Red-Eyes",
    "Red-Eyes Meteor Metal Dragon": "Red-Eyes",
    "Red-Eyes Moon Dragon": "Red-Eyes",
    "Red-Eyes Roar": "Red-Eyes",
    "Red-Eyes Turbo Dragon": "Red-Eyes",
    "Scarstech Draco": "Scarstech",
    "Scarstech Invader": "Scarstech",
    "Scarstech Wyvern": "Scarstech",
    "Ganan, the Scarstech City": "Scarstech",
    "Qerets, the Scarstech Mother Ship": "Scarstech",
    "Thunder Dragon Behemoth": "Thunder Dragon",
    "Virtua Leet": "Leet",
    "Wyvernal Caudina": "Wyvernal",
    "Wyvernal Crenata": "Wyvernal",
    "Wyvernal Gathering": "Wyvernal",
    "Wyvernal Luna": "Wyvernal",
    "Wyvernal Lymantria": "Wyvernal",
    "Wyvernal Megalopyge": "Wyvernal",
    "Wyvernal Myops": "Wyvernal",
    "Wyvernal Sanctuary": "Wyvernal",
    "Wyvernal Sphinx": "Wyvernal",
}

CATEGORY_KEYWORDS = sorted(CARD_TYPE_ALIASES.keys(), key=len, reverse=True)


@dataclass
class ExtractedCard:
    filename: str
    name: str
    category: str
    icon: str | None
    card_types: list[str] | None
    monster_type: list[str] | None
    attribute: str | None
    level: int | None
    rank: int | None
    link_rating: int | None
    link_arrows: list[str] | None
    scale: int | None
    atk: int | None
    def_: int | None
    text: str | None
    ccg_code: str | None
    raw_full_text: str
    raw_text_box: str
    issues: list[str]


@dataclass
class ImageKNN:
    features: np.ndarray
    labels: list[str]
    k: int = 5

    def predict(self, feature: np.ndarray) -> str | None:
        if self.features.size == 0:
            return None

        deltas = self.features - feature[None, :]
        distances = np.sum(deltas * deltas, axis=1)
        indices = np.argsort(distances)[: self.k]

        scores: dict[str, float] = {}
        for index in indices:
            label = self.labels[int(index)]
            weight = 1.0 / max(float(distances[int(index)]), 1e-9)
            scores[label] = scores.get(label, 0.0) + weight

        if not scores:
            return None

        return max(scores.items(), key=lambda item: item[1])[0]


CATEGORY_MODEL: ImageKNN | None = None
ATTRIBUTE_MODEL: ImageKNN | None = None
SPELL_TRAP_ICON_MODEL: ImageKNN | None = None


async def ocr_path(path: Path) -> str:
    file = await StorageFile.get_file_from_path_async(str(path))
    stream = await file.open_async(FileAccessMode.READ)
    decoder = await BitmapDecoder.create_async(stream)
    bitmap = await decoder.get_software_bitmap_async()
    result = await OcrEngine.try_create_from_user_profile_languages().recognize_async(bitmap)
    return result.text


def scale_box(box: tuple[int, int, int, int], size: tuple[int, int]) -> tuple[int, int, int, int]:
    width, height = size
    x1, y1, x2, y2 = box
    return (
        round(x1 * width / REF_WIDTH),
        round(y1 * height / REF_HEIGHT),
        round(x2 * width / REF_WIDTH),
        round(y2 * height / REF_HEIGHT),
    )


def preprocess_crop(image: Image.Image, box: tuple[int, int, int, int], *, scale: int = 4, threshold: int | None = None) -> Image.Image:
    crop = image.crop(scale_box(box, image.size))
    crop = crop.resize((max(1, crop.width * scale), max(1, crop.height * scale)))
    crop = ImageOps.autocontrast(ImageOps.grayscale(crop))
    if threshold is not None:
        crop = crop.point(lambda value: 255 if value > threshold else 0)
    return crop


def save_temp_crop(source_path: Path, image: Image.Image, box: tuple[int, int, int, int], suffix: str, *, scale: int = 4, threshold: int | None = None) -> Path:
    OUTPUT_DIR.mkdir(parents=True, exist_ok=True)
    temp_path = OUTPUT_DIR / f"{source_path.stem}.{suffix}.png"
    preprocess_crop(image, box, scale=scale, threshold=threshold).save(temp_path)
    return temp_path


def clean_ocr(text: str) -> str:
    text = text.replace("\r", "\n")
    text = re.sub(r"[ \t]+", " ", text)
    text = re.sub(r" ?\n ?", "\n", text)
    text = text.replace("â€™", "'").replace("â€œ", '"').replace("â€", '"')
    return text.strip()


def clean_effect_text(text: str) -> str:
    text = clean_ocr(text)
    text = re.sub(r"^(?:f|l)\s+(?=If\b)", "", text)
    text = re.sub(r"\bI\b", "1", text)
    text = re.sub(r"\bo(?= ATK)", "0", text)
    text = re.sub(r"\bo(?= ATK/DEF)", "0", text)
    text = text.replace("Spell 8 Trap Zone", "Spell & Trap Zone")
    text = text.replace("GYS", "GYs")
    return text.strip()


def resolve_public_image(image_value: str) -> Path | None:
    candidate = PUBLIC_ROOT / image_value.lstrip("/").replace("/", "\\")
    return candidate if candidate.exists() else None


def normalize_filename(filename: str) -> str:
    value = Path(filename).stem
    value = re.sub(r"_[0-9]+$", "", value)
    value = value.replace("__", ": ")
    value = value.replace("_-_", " - ")
    value = value.replace("_", " ")
    value = re.sub(r"\s+", " ", value).strip()
    return value


def title_case_part(part: str) -> str:
    if not part:
        return part
    if part.upper() == "A.I.P":
        return "A.I.P"
    if part.lower() in {"of", "the", "and", "in", "at", "on", "for", "to"}:
        return part.lower()
    if "-" in part:
        return "-".join(title_case_part(token) for token in part.split("-"))
    return part[:1].upper() + part[1:]


def normalize_name(filename: str) -> str:
    raw_name = normalize_filename(filename)
    parts = re.split(r"(\s+)", raw_name)
    name = "".join(token if token.isspace() else title_case_part(token) for token in parts)
    name = name[:1].upper() + name[1:]
    return NAME_OVERRIDES.get(name, name)


def extract_ccg_code(full_text: str) -> str | None:
    match = re.search(r"(YCCG-[A-Z0-9]+)", full_text.upper())
    return match.group(1) if match else None


def feature_from_image(image_path: Path, box: tuple[int, int, int, int], *, size: int = 24) -> np.ndarray:
    image = Image.open(image_path).convert("RGB")
    crop = image.crop(scale_box(box, image.size)).resize((size, size))
    return np.asarray(crop, dtype=np.float32).reshape(-1) / 255.0


def build_knn(cards: list[dict[str, Any]], *, label_getter: Callable[[dict[str, Any]], str | None], box: tuple[int, int, int, int], predicate: Callable[[dict[str, Any]], bool]) -> ImageKNN:
    features: list[np.ndarray] = []
    labels: list[str] = []

    for card in cards:
        if not predicate(card):
            continue
        label = label_getter(card)
        if not label:
            continue
        image_value = card.get("image")
        if not isinstance(image_value, str):
            continue
        image_path = resolve_public_image(image_value)
        if image_path is None:
            continue

        features.append(feature_from_image(image_path, box))
        labels.append(str(label))

    if not features:
        return ImageKNN(np.empty((0, 0), dtype=np.float32), [])

    return ImageKNN(np.stack(features), labels)


def build_models(cards: list[dict[str, Any]]) -> None:
    global CATEGORY_MODEL, ATTRIBUTE_MODEL, SPELL_TRAP_ICON_MODEL

    CATEGORY_MODEL = build_knn(
        cards,
        label_getter=lambda card: str(card.get("category") or ""),
        box=CATEGORY_FEATURE_BOX,
        predicate=lambda card: str(card.get("category") or "") in {"Monster", "Spell", "Trap"},
    )
    ATTRIBUTE_MODEL = build_knn(
        cards,
        label_getter=lambda card: str(card.get("attribute") or ""),
        box=ATTRIBUTE_FEATURE_BOX,
        predicate=lambda card: str(card.get("category") or "") == "Monster" and str(card.get("attribute") or "") in ATTRIBUTE_ALIASES,
    )
    SPELL_TRAP_ICON_MODEL = build_knn(
        cards,
        label_getter=lambda card: str(card.get("icon") or ""),
        box=SPELL_TRAP_ICON_FEATURE_BOX,
        predicate=lambda card: str(card.get("category") or "") in {"Spell", "Trap"} and str(card.get("icon") or "") != "",
    )


def classify_category(image_path: Path) -> str | None:
    if CATEGORY_MODEL is None:
        return None
    return CATEGORY_MODEL.predict(feature_from_image(image_path, CATEGORY_FEATURE_BOX))


def classify_attribute(image_path: Path) -> str | None:
    if ATTRIBUTE_MODEL is None:
        return None
    return ATTRIBUTE_MODEL.predict(feature_from_image(image_path, ATTRIBUTE_FEATURE_BOX))


def classify_spell_trap_icon(image_path: Path) -> str | None:
    if SPELL_TRAP_ICON_MODEL is None:
        return None
    return SPELL_TRAP_ICON_MODEL.predict(feature_from_image(image_path, SPELL_TRAP_ICON_FEATURE_BOX))


def detect_category(image_path: Path, full_text: str, spell_trap_type_text: str, top_right_text: str) -> str:
    classified = classify_category(image_path)
    if classified in {"Monster", "Spell", "Trap"}:
        return classified

    blob = " ".join([full_text.upper(), spell_trap_type_text.upper(), top_right_text.upper()])
    if "TRAP CARD" in blob or re.search(r"\bTRAP\b", blob):
        return "Trap"
    if "SPELL CARD" in blob or re.search(r"\bSPELL\b", blob):
        return "Spell"
    return "Monster"


def parse_spell_trap_icon(image_path: Path, text: str, name: str) -> str:
    if name in SPELL_TRAP_ICON_OVERRIDES:
        return SPELL_TRAP_ICON_OVERRIDES[name]

    classified = classify_spell_trap_icon(image_path)
    if classified:
        return classified

    upper = text.upper()
    for key, value in SPELL_TRAP_ICON_ALIASES.items():
        if key in upper:
            return value
    return "Normal"


def parse_attribute(image_path: Path, text: str, name: str) -> str | None:
    if name in ATTRIBUTE_OVERRIDES:
        return ATTRIBUTE_OVERRIDES[name]

    upper = clean_ocr(text).upper()
    for key, value in ATTRIBUTE_ALIASES.items():
        if key in upper:
            return value

    classified = classify_attribute(image_path)
    if classified in ATTRIBUTE_ALIASES:
        return classified
    return None


def normalize_ocr_token(token: str) -> str:
    token = token.upper()
    token = token.replace("XVZ", "XYZ").replace("XZY", "XYZ")
    token = token.replace("EFFECTI", "EFFECT").replace("EFFECT!", "EFFECT")
    token = token.replace("PENDULUMI", "PENDULUM")
    token = token.replace("SYNCHROI", "SYNCHRO").replace("FUSIONI", "FUSION")
    token = re.sub(r"[^A-Z0-9 /-]", "", token)
    token = re.sub(r"\s+", " ", token).strip(" -/")
    collapsed = token.replace(" ", "")
    if token not in SPECIES_ALIASES and collapsed in SPECIES_ALIASES:
        token = collapsed
    if token not in CARD_TYPE_ALIASES and collapsed in CARD_TYPE_ALIASES:
        token = collapsed
    return token


def parse_type_line(text: str) -> tuple[str | None, list[str] | None, str]:
    text = clean_ocr(text)
    if "[" not in text:
        return None, None, text

    text = text[text.index("[") :]
    if "]" in text:
        raw_line, body = text[1:].split("]", 1)
    else:
        content = text[1:]
        keyword_pattern = "|".join(CATEGORY_KEYWORDS)
        match = re.match(
            rf"([A-Z0-9 /-]+?(?:{keyword_pattern}))(?:[\]I!1]+)?\s*(.*)$",
            content,
            flags=re.IGNORECASE | re.DOTALL,
        )
        if not match:
            return None, None, clean_ocr(text)
        raw_line = match.group(1)
        body = match.group(2)

    tokens = [normalize_ocr_token(token) for token in raw_line.replace(" / ", "/").split("/") if token.strip()]
    if not tokens:
        return None, None, clean_ocr(body)

    species_token = tokens[0]
    species = SPECIES_ALIASES.get(species_token)
    card_types: list[str] = []
    for token in tokens[1:]:
        card_type = CARD_TYPE_ALIASES.get(token)
        if card_type and card_type not in card_types:
            card_types.append(card_type)

    upper_line = raw_line.upper()
    if "EFFECT" in upper_line and "Effect" not in card_types:
        card_types.append("Effect")

    if species and not card_types:
        card_types = ["Normal"]

    return species, card_types or None, clean_effect_text(body)


def clean_stat_token(token: str, *, allow_s: bool = False) -> int | None:
    token = token.replace("O", "0").replace("o", "0").replace("I", "1")
    if allow_s:
        token = token.replace("S", "5")
    token = re.sub(r"[^0-9?]", "", token)
    if not token or token == "?":
        return None
    if token.endswith("2026") and len(token) > 4:
        token = token[:-4]
    if len(token) > 4:
        token = token[:4]
    token = token.lstrip("0") or "0"
    return int(token)


def parse_stats(name: str, card_types: list[str] | None, *texts: str) -> tuple[int | None, int | None, int | None]:
    if name in STATS_OVERRIDES:
        override = STATS_OVERRIDES[name]
        return override.get("atk"), override.get("def"), override.get("linkRating")

    merged = " ".join(texts).upper()
    merged = merged.replace("ATK /", "ATK/").replace("DEF /", "DEF/").replace("LINK -", "LINK-")

    atk_match = re.search(r"ATK/?\s*([0-9OI?]{1,10})", merged)
    def_match = re.search(r"DEF/?\s*([0-9OI?]{1,10})", merged)
    link_match = re.search(r"LINK\s*-\s*([0-9OS])", merged) if card_types and "Link" in card_types else None

    atk = clean_stat_token(atk_match.group(1)) if atk_match else None
    defense = clean_stat_token(def_match.group(1)) if def_match else None
    link_rating = clean_stat_token(link_match.group(1), allow_s=True) if link_match else None

    if card_types and "Link" in card_types:
        defense = None

    return atk, defense, link_rating


def detect_star_count(image_path: Path) -> int | None:
    image = cv2.imread(str(image_path))
    if image is None:
        return None

    image = cv2.resize(image, (1388, 2026))
    roi = image[200:340, 50:1250]
    hsv = cv2.cvtColor(roi, cv2.COLOR_BGR2HSV)
    saturation = cv2.GaussianBlur(hsv[:, :, 1], (9, 9), 2)

    circles = cv2.HoughCircles(
        saturation,
        cv2.HOUGH_GRADIENT,
        dp=1.2,
        minDist=60,
        param1=80,
        param2=18,
        minRadius=25,
        maxRadius=55,
    )

    if circles is None:
        return 0

    slots: set[int] = set()
    for circle in circles[0]:
        x = int(round(circle[0] + 50))
        y = int(round(circle[1] + 200))
        if not 258 <= y <= 325:
            continue
        slot_index = min(range(len(LEVEL_SLOT_CENTERS)), key=lambda index: abs(LEVEL_SLOT_CENTERS[index] - x))
        if abs(LEVEL_SLOT_CENTERS[slot_index] - x) <= 32:
            slots.add(slot_index)

    if not slots:
        return 0

    ordered = sorted(slots)
    if ordered[-1] != len(LEVEL_SLOT_CENTERS) - 1:
        return len(ordered)

    leftmost = ordered[-1]
    while leftmost - 1 in slots:
        leftmost -= 1

    return len(LEVEL_SLOT_CENTERS) - leftmost


def infer_archetype(name: str, effect_text: str | None) -> str | None:
    if name in ARCHETYPE_OVERRIDES:
        return ARCHETYPE_OVERRIDES[name]

    quoted = re.findall(r'"([^"]+)"', effect_text or "")
    if quoted:
        candidate = max(quoted, key=len)
        if len(candidate) >= 3:
            return candidate

    parts = [part for part in name.split() if part.lower() not in {"the", "of", "a", "an"}]
    if len(parts) >= 2:
        return " ".join(parts[:2])
    if parts:
        return parts[0]
    return None


def build_card_payload(index: int, start_id: int, extracted: ExtractedCard) -> dict[str, Any]:
    card_number = index + 1
    return {
        "id": f"CARD-{start_id + index:05d}",
        "name": extracted.name,
        "image": f"/assets/cards/{extracted.filename}",
        "set": f"{SET_CODE}-{card_number:03d} {SET_NAME}",
        "archetype": infer_archetype(extracted.name, extracted.text),
        "category": extracted.category,
        "icon": extracted.icon,
        "cardTypes": extracted.card_types,
        "monsterType": extracted.monster_type,
        "attribute": extracted.attribute,
        "level": extracted.level,
        "rank": extracted.rank,
        "linkRating": extracted.link_rating,
        "linkArrows": extracted.link_arrows,
        "scale": extracted.scale,
        "atk": extracted.atk,
        "def": extracted.def_,
        "text": extracted.text,
        "keywords": None,
        "legal": {
            "semiLimited": False,
            "limited": False,
            "banned": False,
        },
        "timestamps": {
            "added": ADDED_DATE,
        },
    }


async def extract_card(image_path: Path) -> ExtractedCard:
    image = Image.open(image_path)

    full_temp = save_temp_crop(image_path, image, FULL_BOX, "full", scale=1)
    top_right_temp = save_temp_crop(image_path, image, TOP_RIGHT_OCR_BOX, "topright", scale=4, threshold=140)
    spell_trap_type_temp = save_temp_crop(image_path, image, SPELL_TRAP_TYPE_BOX, "st-type", scale=4)
    monster_text_temp = save_temp_crop(image_path, image, MONSTER_TEXT_BOX, "monster-text", scale=4)
    spell_trap_text_temp = save_temp_crop(image_path, image, SPELL_TRAP_TEXT_BOX, "st-text", scale=4)
    stats_temp = save_temp_crop(image_path, image, STATS_BOX, "stats", scale=4)

    try:
        full_text = clean_ocr(await ocr_path(full_temp))
        top_right_text = clean_ocr(await ocr_path(top_right_temp))
        spell_trap_type_text = clean_ocr(await ocr_path(spell_trap_type_temp))
        monster_text = clean_ocr(await ocr_path(monster_text_temp))
        spell_trap_text = clean_ocr(await ocr_path(spell_trap_text_temp))
        stats_text = clean_ocr(await ocr_path(stats_temp))
    finally:
        for temp_path in (full_temp, top_right_temp, spell_trap_type_temp, monster_text_temp, spell_trap_text_temp, stats_temp):
            temp_path.unlink(missing_ok=True)

    category = detect_category(image_path, full_text, spell_trap_type_text, top_right_text)
    name = normalize_name(image_path.name)
    ccg_code = extract_ccg_code(full_text)
    issues: list[str] = []

    icon: str | None = None
    card_types: list[str] | None = None
    monster_type: list[str] | None = None
    attribute: str | None = None
    level: int | None = None
    rank: int | None = None
    link_rating: int | None = None
    link_arrows: list[str] | None = None
    scale: int | None = None
    atk: int | None = None
    defense: int | None = None
    effect_text: str | None = None

    if category == "Monster":
        attribute = parse_attribute(image_path, top_right_text, name)
        if attribute is None:
            issues.append("missing-attribute")

        species, parsed_card_types, body = parse_type_line(monster_text)
        if species:
            monster_type = [species]
        else:
            issues.append("missing-species")

        card_types = CARD_TYPE_OVERRIDES.get(name, parsed_card_types)
        if not card_types:
            issues.append("missing-card-types")
        elif "EFFECT" in monster_text.upper() and "Effect" not in card_types:
            card_types.append("Effect")

        effect_text = clean_effect_text(body) if body else None

        atk, defense, link_rating = parse_stats(name, card_types, stats_text, full_text)
        if atk is None:
            issues.append("missing-atk")
        if card_types and "Link" not in card_types and defense is None:
            issues.append("missing-def")

        if card_types and "Link" in card_types:
            link_arrows = LINK_ARROW_OVERRIDES.get(name)
            if link_arrows is None:
                issues.append("missing-link-arrows")
        else:
            star_count = detect_star_count(image_path)
            if star_count is None:
                issues.append("missing-stars")
            elif card_types and "Xyz" in card_types:
                rank = star_count
            else:
                level = star_count

        if card_types and "Pendulum" in card_types:
            scale = SCALE_OVERRIDES.get(name)
            if scale is None:
                issues.append("missing-scale")
    else:
        icon = parse_spell_trap_icon(image_path, spell_trap_type_text, name)
        effect_text = clean_effect_text(spell_trap_text) if spell_trap_text else None

    if not effect_text:
        issues.append("missing-text")

    return ExtractedCard(
        filename=image_path.name,
        name=name,
        category=category,
        icon=icon,
        card_types=card_types,
        monster_type=monster_type,
        attribute=attribute,
        level=level,
        rank=rank,
        link_rating=link_rating,
        link_arrows=link_arrows,
        scale=scale,
        atk=atk,
        def_=defense,
        text=effect_text,
        ccg_code=ccg_code,
        raw_full_text=full_text,
        raw_text_box=monster_text if category == "Monster" else spell_trap_text,
        issues=issues,
    )


def load_cards() -> list[dict[str, Any]]:
    with CARDS_PATH.open("r", encoding="utf-8") as handle:
        return json.load(handle)


def base_cards(cards: list[dict[str, Any]]) -> list[dict[str, Any]]:
    return [card for card in cards if not str(card.get("set") or "").startswith(f"{SET_CODE}-")]


def next_card_id(cards: list[dict[str, Any]]) -> int:
    max_id = 0
    for card in cards:
        if str(card.get("set") or "").startswith(f"{SET_CODE}-"):
            continue
        match = re.match(r"CARD-(\d+)$", str(card.get("id", "")))
        if match:
            max_id = max(max_id, int(match.group(1)))
    return max_id + 1


def recent_images() -> list[Path]:
    files = [
        path
        for path in ASSETS_DIR.iterdir()
        if path.is_file() and not path.name.startswith("_") and path.stat().st_mtime > RECENT_CUTOFF
    ]
    return sorted(files, key=lambda path: path.stat().st_mtime)


async def main() -> int:
    cards = load_cards()
    build_models(base_cards(cards))

    start_id = next_card_id(cards)
    images = recent_images()
    extracted_cards = [await extract_card(image_path) for image_path in images]
    payload = [build_card_payload(index, start_id, extracted) for index, extracted in enumerate(extracted_cards)]

    OUTPUT_DIR.mkdir(parents=True, exist_ok=True)
    draft_path = OUTPUT_DIR / "upst-draft.json"
    review_path = OUTPUT_DIR / "upst-review.json"

    with draft_path.open("w", encoding="utf-8", newline="\n") as handle:
        json.dump(payload, handle, ensure_ascii=False, indent=2)
        handle.write("\n")

    review_rows = [
        {
            "filename": extracted.filename,
            "name": extracted.name,
            "category": extracted.category,
            "icon": extracted.icon,
            "cardTypes": extracted.card_types,
            "monsterType": extracted.monster_type,
            "attribute": extracted.attribute,
            "level": extracted.level,
            "rank": extracted.rank,
            "linkRating": extracted.link_rating,
            "linkArrows": extracted.link_arrows,
            "scale": extracted.scale,
            "atk": extracted.atk,
            "def": extracted.def_,
            "ccgCode": extracted.ccg_code,
            "issues": extracted.issues,
            "rawFullText": extracted.raw_full_text,
            "rawTextBox": extracted.raw_text_box,
        }
        for extracted in extracted_cards
    ]

    with review_path.open("w", encoding="utf-8", newline="\n") as handle:
        json.dump(review_rows, handle, ensure_ascii=False, indent=2)
        handle.write("\n")

    print(f"Recent images: {len(images)}")
    print(f"Start CARD id: {start_id:05d}")
    print(f"Wrote draft cards to {draft_path}")
    print(f"Wrote review data to {review_path}")
    print("Cards with review issues:")
    for extracted in extracted_cards:
        if extracted.issues:
            print(f"- {extracted.filename}: {', '.join(extracted.issues)}")

    return 0


if __name__ == "__main__":
    raise SystemExit(asyncio.run(main()))

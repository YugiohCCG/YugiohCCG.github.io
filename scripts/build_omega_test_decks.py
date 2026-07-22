#!/usr/bin/env python3
"""Build archetype-by-archetype YGO Omega test decks for the CCG card pool."""

from __future__ import annotations

import argparse
import base64
from collections import Counter, defaultdict
import json
from pathlib import Path
import re
import shutil
import struct
from urllib.parse import quote
from urllib.request import urlopen


ROOT = Path(__file__).resolve().parents[1]
DEFAULT_CARDS = ROOT / "src" / "data" / "cards.json"
DEFAULT_OUTPUT = ROOT / "scripts" / "output" / "omega_test_decks"
DEFAULT_OMEGA_FILES = Path(r"C:\Program Files (x86)\YGO Omega\YGO Omega_Data\Files")
DEFAULT_OMEGA_API = "http://localhost:19999"

EXTRA_TYPES = {"Fusion", "Synchro", "Xyz", "Link"}

# Current official cards are used only as consistency pieces and interaction so
# the small custom engines can still produce legal 40-card test hands.
OFFICIAL_MAIN = [
    (14558127, "Ash Blossom & Joyous Spring", 3),
    (10045474, "Infinite Impermanence", 3),
    (97268402, "Effect Veiler", 2),
    (73642296, "Ghost Belle & Haunted Mansion", 2),
    (27204311, "Nibiru, the Primal Being", 2),
    (24224830, "Called by the Grave", 1),
    (25311006, "Triple Tactics Talent", 2),
    (84211599, "Pot of Prosperity", 1),
    (14087893, "Book of Moon", 2),
    (24299458, "Forbidden Droplet", 2),
    (15693423, "Evenly Matched", 3),
    (14532163, "Lightning Storm", 2),
    (12580477, "Raigeki", 1),
    (83764718, "Monster Reborn", 1),
    (81439173, "Foolish Burial", 1),
    (73628505, "Terraforming", 1),
    (94145021, "Droll & Lock Bird", 2),
    (65681983, "Crossout Designator", 1),
]

# Broadly useful custom interaction. Context-specific custom cards are inserted
# ahead of these when their requirements match an archetype.
CUSTOM_GENERAL = [
    222676270,  # Frozen Girl & Blood Moon
    222782750,  # Ghost Doll & Midnight Manor
    259290896,  # Dominus Sentinel
    259755133,  # Rush at the Gnome
    246900181,  # Unbinding the Soul
    259471193,  # Dreadful Soul Drain
    226827770,  # The One Called Forth
    220538776,  # Curryboh
]

CUSTOM_SIDE = [
    216620496,  # Remembrance of the Melody
    222257685,  # Branching to Guidance
    253128790,  # Interwire Dimensquid
    233957828,  # Toddler Pumpkien
    224049334,  # Solemn Rebirth
    234818744,  # Primite Dragon Citrine
]

GENERIC_EXTRA = [
    215853847,  # Rigel the Thousand-Armed
    248638801,  # Chaos Honest
    256207361,  # Sealed Glyphs Dragon
    259072745,  # Bhodi, the Corrupted Halloween Tree
    221924008,  # Chamroshes' Aegis
    228169392,  # Bael, Demon Incarnate
    224274662,  # Armored Nova Mecha-Scaled Xyrion
    259365935,  # Aetherstorm Zenith Wire-Tailed Sypharion
    254065048,  # Polemistis Gia Ataxia
    212684822,  # Ektelestis Gia Taxis
]


def as_list(value: object) -> list[str]:
    if value is None:
        return []
    if isinstance(value, list):
        return [str(item) for item in value]
    return [str(value)]


def is_extra(card: dict[str, object]) -> bool:
    return bool(EXTRA_TYPES.intersection(as_list(card.get("cardTypes"))))


def card_level(card: dict[str, object]) -> int:
    for field in ("level", "rank", "linkRating"):
        value = card.get(field)
        if isinstance(value, int):
            return value
        if isinstance(value, str) and value.isdigit():
            return int(value)
    return 0


def priority(card: dict[str, object]) -> tuple[int, str]:
    text = str(card.get("text") or "").casefold()
    score = 0
    if "add 1" in text or "from your deck to your hand" in text:
        score += 8
    if "special summon" in text:
        score += 6
    if "normal summon" in text or "if this card is summoned" in text:
        score += 3
    if "negate" in text:
        score += 3
    if card.get("category") == "Monster" and 0 < card_level(card) <= 4:
        score += 3
    if card.get("category") == "Trap":
        score -= 1
    return (-score, str(card.get("name") or ""))


def mentions_archetype(card: dict[str, object], archetype: str) -> bool:
    haystack = " ".join(
        [str(card.get("name") or ""), str(card.get("text") or ""), str(card.get("archetype") or "")]
    )
    pattern = rf"(?<![A-Za-z0-9]){re.escape(archetype)}(?![A-Za-z0-9])"
    return re.search(pattern, haystack, flags=re.IGNORECASE) is not None


def safe_filename(name: str) -> str:
    cleaned = re.sub(r'[<>:"/\\|?*]', "-", name).strip().rstrip(".")
    return re.sub(r"\s+", " ", cleaned)


def add_copies(deck: list[int], counts: Counter[int], card_id: int, amount: int) -> int:
    added = 0
    while added < amount and counts[card_id] < 3:
        deck.append(card_id)
        counts[card_id] += 1
        added += 1
    return added


def contextual_support(engine: list[dict[str, object]]) -> list[int]:
    text = " ".join(str(card.get("text") or "") for card in engine).casefold()
    races = {race for card in engine for race in as_list(card.get("monsterType"))}
    attributes = {str(card.get("attribute") or "") for card in engine}
    types = {ctype for card in engine for ctype in as_list(card.get("cardTypes"))}
    result: list[int] = []
    if "banish" in text:
        result.extend([216620496, 253128790])
    if "Zombie" in races:
        result.append(233957828)
    if "Spirit" in types:
        result.append(246393365)
    if "Normal" in types:
        result.extend([222257685, 234818744])
    if "WATER" in attributes and races.intersection({"Aqua", "Fish", "Sea Serpent"}):
        result.append(259998396)
    if any(
        card.get("attribute") == "DARK"
        and "Spellcaster" in as_list(card.get("monsterType"))
        and card_level(card) == 7
        for card in engine
    ):
        result.append(251331463)
    return list(dict.fromkeys(result))


def generic_extra_candidates(engine_main: list[dict[str, object]], engine_extra: list[dict[str, object]]) -> list[int]:
    effect_monsters = [card for card in engine_main if "Effect" in as_list(card.get("cardTypes"))]
    light_dark_effects = [
        card for card in effect_monsters if card.get("attribute") in {"LIGHT", "DARK"}
    ]
    dark_fiends = [
        card
        for card in engine_main
        if card.get("attribute") == "DARK" and "Fiend" in as_list(card.get("monsterType"))
    ]
    level_sevens = [card for card in engine_main if card_level(card) == 7]
    low_tuners = [
        card
        for card in engine_main
        if "Tuner" in as_list(card.get("cardTypes")) and 0 < card_level(card) <= 3
    ]
    level_one_tuners = [card for card in low_tuners if card_level(card) == 1]
    rank_eight_dragons = [
        card
        for card in engine_extra
        if card.get("rank") == 8 and "Dragon" in as_list(card.get("monsterType"))
    ]
    result: list[int] = []
    if len(effect_monsters) >= 2:
        result.append(215853847)
    if len(light_dark_effects) >= 2:
        result.append(248638801)
    if len(level_sevens) >= 2:
        result.append(256207361)
    if len(dark_fiends) >= 2:
        result.append(259072745)
    if len(low_tuners) >= 3:
        result.append(221924008)
    if len(level_one_tuners) >= 3:
        result.append(228169392)
    if rank_eight_dragons or sum(card_level(card) == 9 for card in engine_main) >= 2:
        result.extend([224274662, 259365935])
    return result


def build_main(
    archetype: str,
    engine_main: list[dict[str, object]],
    related_main: list[dict[str, object]],
    by_id: dict[int, dict[str, object]],
) -> tuple[list[int], dict[int, str]]:
    deck: list[int] = []
    counts: Counter[int] = Counter()
    origin: dict[int, str] = {}
    ranked_engine = sorted(engine_main, key=priority)

    # Every archetype Main Deck card appears at least once. Higher-value starters
    # receive second and third copies until the focused engine reaches 28 cards.
    for card in ranked_engine:
        card_id = int(card["passcode"])
        add_copies(deck, counts, card_id, 1)
        origin[card_id] = "engine"
    for copy_number in (2, 3):
        for card in ranked_engine:
            if len(deck) >= 28:
                break
            card_id = int(card["passcode"])
            if counts[card_id] < copy_number:
                add_copies(deck, counts, card_id, 1)
        if len(deck) >= 28:
            break

    # Cards outside the archetype whose names/text explicitly mention it are the
    # first non-engine additions (for example the untagged Stellaer Spells).
    for copy_number in (1, 2, 3):
        for card in sorted(related_main, key=priority):
            if len(deck) >= 32:
                break
            card_id = int(card["passcode"])
            if counts[card_id] < copy_number:
                add_copies(deck, counts, card_id, 1)
                origin[card_id] = "custom related support"
        if len(deck) >= 32:
            break

    support_ids = contextual_support(engine_main) + CUSTOM_GENERAL
    support_ids = list(dict.fromkeys(card_id for card_id in support_ids if card_id in by_id))
    for copy_number in (1, 2, 3):
        for card_id in support_ids:
            if len(deck) >= 36:
                break
            if counts[card_id] < copy_number:
                add_copies(deck, counts, card_id, 1)
                origin[card_id] = "custom non-engine"
        if len(deck) >= 36:
            break

    for card_id, name, desired in OFFICIAL_MAIN:
        if len(deck) >= 40:
            break
        amount = min(desired, 40 - len(deck))
        if add_copies(deck, counts, card_id, amount):
            origin[card_id] = f"official consistency/interaction ({name})"

    if len(deck) != 40:
        raise RuntimeError(f"Could not build a 40-card Main Deck for {archetype}: got {len(deck)}")
    return deck, origin


def build_extra(
    engine_main: list[dict[str, object]],
    engine_extra: list[dict[str, object]],
    related_extra: list[dict[str, object]],
    by_id: dict[int, dict[str, object]],
) -> tuple[list[int], dict[int, str]]:
    deck: list[int] = []
    counts: Counter[int] = Counter()
    origin: dict[int, str] = {}
    ranked_engine = sorted(engine_extra, key=priority)
    for card in ranked_engine:
        card_id = int(card["passcode"])
        add_copies(deck, counts, card_id, 1)
        origin[card_id] = "engine Extra Deck"
    for copy_number in (2, 3):
        for card in ranked_engine:
            if len(deck) >= 12:
                break
            card_id = int(card["passcode"])
            if counts[card_id] < copy_number:
                add_copies(deck, counts, card_id, 1)
        if len(deck) >= 12:
            break
    for card in sorted(related_extra, key=priority):
        if len(deck) >= 15:
            break
        card_id = int(card["passcode"])
        if add_copies(deck, counts, card_id, 1):
            origin[card_id] = "custom related Extra Deck support"
    for card_id in generic_extra_candidates(engine_main, engine_extra):
        if len(deck) >= 15:
            break
        if card_id in by_id and add_copies(deck, counts, card_id, 1):
            origin[card_id] = "custom generic Extra Deck option"
    return deck, origin


def build_side(main: list[int], by_id: dict[int, dict[str, object]]) -> tuple[list[int], dict[int, str]]:
    deck: list[int] = []
    total_counts: Counter[int] = Counter(main)
    origin: dict[int, str] = {}
    custom_pool = CUSTOM_SIDE + CUSTOM_GENERAL
    for card_id in custom_pool:
        if len(deck) >= 9:
            break
        if card_id in by_id and total_counts[card_id] < 3:
            deck.append(card_id)
            total_counts[card_id] += 1
            origin[card_id] = "custom side-deck test option"
    for card_id, name, _desired in reversed(OFFICIAL_MAIN):
        while len(deck) < 15 and total_counts[card_id] < 3:
            deck.append(card_id)
            total_counts[card_id] += 1
            origin[card_id] = f"official side-deck option ({name})"
        if len(deck) >= 15:
            break
    return deck, origin


def write_ydk(path: Path, archetype: str, main: list[int], extra: list[int], side: list[int]) -> None:
    lines = [
        "#Created by YGO Omega",
        f"#tags=CCG Test,{archetype}",
        "#main",
        *(str(card_id) for card_id in main),
        "#extra",
        *(str(card_id) for card_id in extra),
        "!side",
        *(str(card_id) for card_id in side),
        "",
    ]
    path.write_text("\n".join(lines), encoding="utf-8")


def parse_ydk(path: Path) -> dict[str, list[int]]:
    sections: dict[str, list[int]] = {"Main": [], "Extra": [], "Side": []}
    current: str | None = None
    for raw_line in path.read_text(encoding="utf-8-sig").splitlines():
        line = raw_line.strip()
        if line == "#main":
            current = "Main"
        elif line == "#extra":
            current = "Extra"
        elif line == "!side":
            current = "Side"
        elif line and not line.startswith("#") and current is not None:
            sections[current].append(int(line))
    return sections


def encode_ydke_part(card_ids: list[int]) -> str:
    payload = b"".join(struct.pack("<I", card_id) for card_id in card_ids)
    return base64.b64encode(payload).decode("ascii")


def omega_deck_hash(deck: dict[str, list[int]]) -> str:
    return "ydke://{}!{}!{}!".format(
        encode_ydke_part(deck["Main"]),
        encode_ydke_part(deck["Extra"]),
        encode_ydke_part(deck["Side"]),
    )


def api_json(api_base: str, path: str) -> dict[str, object]:
    with urlopen(f"{api_base.rstrip('/')}{path}", timeout=30) as response:
        return json.loads(response.read().decode("utf-8-sig"))


def register_decks_with_omega(generated_paths: list[Path], api_base: str) -> tuple[int, int]:
    expected = {path.stem: parse_ydk(path) for path in generated_paths}
    before = api_json(api_base, "/deck-list")
    existing = {
        str(deck["DeckName"]): deck
        for deck in before.get("Decks", [])
        if isinstance(deck, dict) and "DeckName" in deck
    }

    added = 0
    unchanged = 0
    for deck_name, sections in expected.items():
        current = existing.get(deck_name)
        if current is not None:
            actual = {key: [int(card_id) for card_id in current.get(key, [])] for key in sections}
            if actual != sections:
                raise RuntimeError(
                    f"Omega already has a different deck named {deck_name!r}; refusing to overwrite it"
                )
            unchanged += 1
            continue

        deck_hash = omega_deck_hash(sections)
        path = f"/add-deck/{quote(deck_name, safe='')}/{quote(deck_hash, safe='')}"
        with urlopen(f"{api_base.rstrip('/')}{path}", timeout=30) as response:
            response.read()
        added += 1

    after = api_json(api_base, "/deck-list")
    installed = {
        str(deck["DeckName"]): deck
        for deck in after.get("Decks", [])
        if isinstance(deck, dict) and "DeckName" in deck
    }
    mismatches: list[str] = []
    for deck_name, sections in expected.items():
        current = installed.get(deck_name)
        if current is None:
            mismatches.append(f"{deck_name}: missing")
            continue
        actual = {key: [int(card_id) for card_id in current.get(key, [])] for key in sections}
        if actual != sections:
            mismatches.append(f"{deck_name}: card lists differ")
    if mismatches:
        raise RuntimeError("Omega deck registration verification failed: " + "; ".join(mismatches))
    return added, unchanged


def display_name(card_id: int, by_id: dict[int, dict[str, object]], official_names: dict[int, str]) -> str:
    card = by_id.get(card_id)
    if card:
        return str(card.get("name") or card_id)
    return official_names.get(card_id, f"Official card {card_id}")


def counted_rows(ids: list[int]) -> list[tuple[int, int]]:
    counts = Counter(ids)
    order = list(dict.fromkeys(ids))
    return [(card_id, counts[card_id]) for card_id in order]


def main() -> int:
    parser = argparse.ArgumentParser(description=__doc__)
    parser.add_argument("--cards", type=Path, default=DEFAULT_CARDS)
    parser.add_argument("--output", type=Path, default=DEFAULT_OUTPUT)
    parser.add_argument("--omega-files", type=Path, default=DEFAULT_OMEGA_FILES)
    parser.add_argument("--min-archetype-size", type=int, default=2)
    parser.add_argument("--install", action="store_true", help="Copy decks into Omega Imports and Exports")
    parser.add_argument(
        "--register-decks",
        action="store_true",
        help="Create the generated decks in Omega's live deck manager through its local API",
    )
    parser.add_argument("--omega-api", default=DEFAULT_OMEGA_API)
    args = parser.parse_args()

    cards = json.loads(args.cards.read_text(encoding="utf-8-sig"))
    cards = [card for card in cards if isinstance(card.get("passcode"), int)]
    by_id = {int(card["passcode"]): card for card in cards}
    groups: dict[str, list[dict[str, object]]] = defaultdict(list)
    for card in cards:
        archetype = str(card.get("archetype") or "").strip()
        if archetype:
            groups[archetype].append(card)

    archetypes = sorted(
        (name for name, group in groups.items() if len(group) >= args.min_archetype_size),
        key=str.casefold,
    )
    args.output.mkdir(parents=True, exist_ok=True)
    official_names = {card_id: name for card_id, name, _count in OFFICIAL_MAIN}
    manifest: dict[str, object] = {"deck_count": len(archetypes) + 1, "decks": []}
    markdown = [
        "# CCG Omega archetype test decks",
        "",
        "Generated from `src/data/cards.json`. Each archetype card is represented at least once; smaller engines are padded with relevant custom cards and confirmed official interaction cards.",
        "",
    ]

    generated_paths: list[Path] = []
    covered_custom_ids: set[int] = set()
    for archetype in archetypes:
        engine = groups[archetype]
        engine_main = [card for card in engine if not is_extra(card)]
        engine_extra = [card for card in engine if is_extra(card)]
        related = [
            card
            for card in cards
            if card not in engine and mentions_archetype(card, archetype)
        ]
        related_main = [card for card in related if not is_extra(card)]
        related_extra = [card for card in related if is_extra(card)]
        main_deck, main_origin = build_main(archetype, engine_main, related_main, by_id)
        extra_deck, extra_origin = build_extra(engine_main, engine_extra, related_extra, by_id)
        side_deck, side_origin = build_side(main_deck, by_id)
        covered_custom_ids.update((set(main_deck) | set(extra_deck) | set(side_deck)).intersection(by_id))
        origins = {**main_origin, **extra_origin, **side_origin}
        filename = f"CCG Test - {safe_filename(archetype)}.ydk"
        output_path = args.output / filename
        write_ydk(output_path, archetype, main_deck, extra_deck, side_deck)
        generated_paths.append(output_path)

        deck_record = {
            "archetype": archetype,
            "file": filename,
            "main": [
                {"id": card_id, "count": count, "name": display_name(card_id, by_id, official_names), "role": origins.get(card_id, "")}
                for card_id, count in counted_rows(main_deck)
            ],
            "extra": [
                {"id": card_id, "count": count, "name": display_name(card_id, by_id, official_names), "role": origins.get(card_id, "")}
                for card_id, count in counted_rows(extra_deck)
            ],
            "side": [
                {"id": card_id, "count": count, "name": display_name(card_id, by_id, official_names), "role": origins.get(card_id, "")}
                for card_id, count in counted_rows(side_deck)
            ],
        }
        cast_decks = manifest["decks"]
        assert isinstance(cast_decks, list)
        cast_decks.append(deck_record)

        markdown.extend([f"## {archetype}", "", f"File: `{filename}`", ""])
        for section_name, ids in (("Main", main_deck), ("Extra", extra_deck), ("Side", side_deck)):
            markdown.append(f"### {section_name} ({len(ids)})")
            markdown.append("")
            if not ids:
                markdown.append("- None")
            else:
                for card_id, count in counted_rows(ids):
                    name = display_name(card_id, by_id, official_names)
                    markdown.append(f"- {count}× {name} (`{card_id}`) — {origins.get(card_id, '')}")
            markdown.append("")

    # Put every remaining singleton and untagged custom card into one laboratory
    # deck rather than creating dozens of mostly-official one-card piles.
    lab_name = "Standalone and Non-Engine Lab"
    uncovered = [card for card_id, card in by_id.items() if card_id not in covered_custom_ids]
    lab_main_cards = sorted((card for card in uncovered if not is_extra(card)), key=priority)
    lab_extra_cards = sorted((card for card in uncovered if is_extra(card)), key=priority)
    lab_main: list[int] = []
    lab_main_counts: Counter[int] = Counter()
    lab_origin: dict[int, str] = {}
    for card in lab_main_cards:
        card_id = int(card["passcode"])
        add_copies(lab_main, lab_main_counts, card_id, 1)
        lab_origin[card_id] = "standalone/custom non-engine coverage"
    for copy_number in (2, 3):
        for card in lab_main_cards:
            if len(lab_main) >= 36:
                break
            card_id = int(card["passcode"])
            if lab_main_counts[card_id] < copy_number:
                add_copies(lab_main, lab_main_counts, card_id, 1)
        if len(lab_main) >= 36:
            break
    for card_id, name, desired in OFFICIAL_MAIN:
        if len(lab_main) >= 40:
            break
        if add_copies(lab_main, lab_main_counts, card_id, min(desired, 40 - len(lab_main))):
            lab_origin[card_id] = f"official consistency/interaction ({name})"

    lab_extra: list[int] = []
    lab_extra_counts: Counter[int] = Counter()
    for card in lab_extra_cards:
        card_id = int(card["passcode"])
        add_copies(lab_extra, lab_extra_counts, card_id, 1)
        lab_origin[card_id] = "standalone/custom Extra Deck coverage"
    for copy_number in (2, 3):
        for card in lab_extra_cards:
            if len(lab_extra) >= 15:
                break
            card_id = int(card["passcode"])
            if lab_extra_counts[card_id] < copy_number:
                add_copies(lab_extra, lab_extra_counts, card_id, 1)
        if len(lab_extra) >= 15:
            break
    lab_side, lab_side_origin = build_side(lab_main, by_id)
    lab_origin.update(lab_side_origin)
    lab_filename = f"CCG Test - {lab_name}.ydk"
    lab_path = args.output / lab_filename
    write_ydk(lab_path, lab_name, lab_main, lab_extra, lab_side)
    generated_paths.append(lab_path)
    covered_custom_ids.update(
        (set(lab_main) | set(lab_extra) | set(lab_side)).intersection(by_id)
    )
    lab_record = {
        "archetype": lab_name,
        "file": lab_filename,
        "main": [
            {"id": card_id, "count": count, "name": display_name(card_id, by_id, official_names), "role": lab_origin.get(card_id, "")}
            for card_id, count in counted_rows(lab_main)
        ],
        "extra": [
            {"id": card_id, "count": count, "name": display_name(card_id, by_id, official_names), "role": lab_origin.get(card_id, "")}
            for card_id, count in counted_rows(lab_extra)
        ],
        "side": [
            {"id": card_id, "count": count, "name": display_name(card_id, by_id, official_names), "role": lab_origin.get(card_id, "")}
            for card_id, count in counted_rows(lab_side)
        ],
    }
    cast_decks = manifest["decks"]
    assert isinstance(cast_decks, list)
    cast_decks.append(lab_record)
    markdown.extend([f"## {lab_name}", "", f"File: `{lab_filename}`", ""])
    for section_name, ids in (("Main", lab_main), ("Extra", lab_extra), ("Side", lab_side)):
        markdown.append(f"### {section_name} ({len(ids)})")
        markdown.append("")
        for card_id, count in counted_rows(ids):
            name = display_name(card_id, by_id, official_names)
            markdown.append(f"- {count}× {name} (`{card_id}`) — {lab_origin.get(card_id, '')}")
        markdown.append("")

    if len(covered_custom_ids) != len(by_id):
        missing_ids = sorted(set(by_id) - covered_custom_ids)
        raise RuntimeError(f"Custom card coverage is incomplete: {missing_ids}")

    manifest_path = args.output / "CCG Test Decks.json"
    manifest_path.write_text(json.dumps(manifest, indent=2, ensure_ascii=False) + "\n", encoding="utf-8")
    readme_path = args.output / "CCG Test Decks.md"
    readme_path.write_text("\n".join(markdown), encoding="utf-8")

    installed: list[str] = []
    if args.install:
        imports_destination = args.omega_files / "Imports"
        imports_destination.mkdir(parents=True, exist_ok=True)
        for source in generated_paths:
            target = imports_destination / source.name
            shutil.copy2(source, target)
            installed.append(str(target))
        shutil.copy2(readme_path, imports_destination / readme_path.name)

        exports_destination = args.omega_files / "Exports" / "CCG Test Decks"
        exports_destination.mkdir(parents=True, exist_ok=True)
        for source in generated_paths:
            target = exports_destination / source.name
            shutil.copy2(source, target)
            installed.append(str(target))
        shutil.copy2(readme_path, exports_destination / readme_path.name)

    api_added = 0
    api_unchanged = 0
    if args.register_decks:
        api_added, api_unchanged = register_decks_with_omega(generated_paths, args.omega_api)

    print(f"archetypes={len(archetypes)}")
    print(f"custom_cards_covered={len(covered_custom_ids)}")
    print(f"decks_generated={len(generated_paths)}")
    print(f"output={args.output}")
    if args.install:
        print(f"omega_files={args.omega_files}")
        print(f"installed_deck_copies={len(installed)}")
    if args.register_decks:
        print(f"omega_api={args.omega_api}")
        print(f"omega_decks_added={api_added}")
        print(f"omega_decks_already_current={api_unchanged}")
    return 0


if __name__ == "__main__":
    raise SystemExit(main())

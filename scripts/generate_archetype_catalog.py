#!/usr/bin/env python3
"""Build consolidated CCG archetypes from labels and printed card relationships."""

from __future__ import annotations

import json
import re
from collections import defaultdict
from pathlib import Path


ROOT = Path(__file__).resolve().parents[1]
CARDS_PATH = ROOT / "src" / "data" / "cards.json"
OUTPUT_PATH = ROOT / "src" / "data" / "archetype-catalog.json"
OUT_OF_SCOPE_ATTRIBUTES = {"ELECTRIC", "METAL", "NATURE"}
QUOTED = re.compile(r'"([^"\n]{1,100})"')
ARCHETYPE_REFERENCE = re.compile(
    r'"([^"\n]{1,60})"\s+(?:cards?|monsters?|Spell(?:/Trap)? Cards?|Trap Cards?)',
    re.IGNORECASE,
)
TREATED_AS = re.compile(
    r'(?:always|also) treated as (?:an? )?"([^"\n]+)" card',
    re.IGNORECASE,
)


def visible(card: dict[str, object]) -> bool:
    if card.get("hidden") is True:
        return False
    return not (
        str(card.get("category") or "").casefold() == "monster"
        and str(card.get("attribute") or "").upper() in OUT_OF_SCOPE_ATTRIBUTES
    )


def monster_score(card: dict[str, object], group_name: str) -> tuple[float, str]:
    name = str(card.get("name") or "")
    folded_name = name.casefold()
    folded_group = group_name.casefold()
    card_types = {str(value) for value in (card.get("cardTypes") or [])}
    score = 0.0
    if folded_name == folded_group:
        score += 100
    elif folded_name.startswith(folded_group):
        score += 60
    elif folded_group in folded_name:
        score += 40
    if str(card.get("archetype") or "").casefold() == folded_group:
        score += 25
    if card_types.intersection({"Fusion", "Synchro", "Xyz", "Link"}):
        score += 15
    score += float(card.get("atk") or 0) / 1000
    score += float(card.get("level") or card.get("rank") or card.get("linkRating") or 0)
    return score, name


def build_catalog(cards: list[dict[str, object]]) -> list[dict[str, object]]:
    cards = [card for card in cards if visible(card)]
    by_name = {str(card.get("name") or "").casefold(): card for card in cards}
    canonical = {
        str(card["archetype"]).casefold(): str(card["archetype"])
        for card in cards
        if card.get("archetype")
    }
    groups: defaultdict[str, dict[int, dict[str, object]]] = defaultdict(dict)

    for card in cards:
        memberships: dict[str, str] = {}

        def add(value: object) -> None:
            if not value:
                return
            candidate = str(value).strip(" .")
            canonical_name = canonical.get(candidate.casefold())
            if canonical_name:
                memberships[canonical_name.casefold()] = canonical_name

        add(card.get("archetype"))
        text = str(card.get("text") or "")

        # A card that explicitly names another CCG card belongs in that card's
        # primary support group. This joins orphan support labels without
        # inventing a new archetype from every quoted phrase.
        for quoted_name in QUOTED.findall(text):
            target = by_name.get(quoted_name.strip().casefold())
            if target is not None and target is not card:
                add(target.get("archetype"))

        for referenced_group in ARCHETYPE_REFERENCE.findall(text):
            add(referenced_group)
        for treated_group in TREATED_AS.findall(text):
            add(treated_group)

        passcode = card.get("passcode")
        if not isinstance(passcode, int):
            continue
        for membership in memberships.values():
            groups[membership][passcode] = card

    catalog: list[dict[str, object]] = []
    for group_name, indexed_cards in groups.items():
        grouped_cards = list(indexed_cards.values())
        monsters = [card for card in grouped_cards if card.get("category") == "Monster"]
        # A single card is a card label, not an archetype. Requiring a monster
        # also guarantees every directory entry has a meaningful key icon.
        if len(grouped_cards) < 2 or not monsters:
            continue
        icon_card = max(monsters, key=lambda card: monster_score(card, group_name))
        catalog.append(
            {
                "name": group_name,
                "cardIds": sorted(int(card["passcode"]) for card in grouped_cards),
                "iconCardId": icon_card["passcode"],
                "iconName": icon_card["name"],
                "iconImage": icon_card["image"],
            }
        )
    return sorted(catalog, key=lambda item: str(item["name"]).casefold())


def main() -> int:
    cards = json.loads(CARDS_PATH.read_text(encoding="utf-8"))
    catalog = build_catalog(cards)
    OUTPUT_PATH.write_text(
        json.dumps(catalog, indent=2, ensure_ascii=False) + "\n",
        encoding="utf-8",
    )
    print(f"wrote {OUTPUT_PATH.relative_to(ROOT)} ({len(catalog)} consolidated archetypes)")
    return 0


if __name__ == "__main__":
    raise SystemExit(main())

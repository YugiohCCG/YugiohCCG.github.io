#!/usr/bin/env python3
"""Cache a compact, deck-builder-ready catalog of all YGOPRODeck cards."""

from __future__ import annotations

import json
import urllib.request
from pathlib import Path


ROOT = Path(__file__).resolve().parents[1]
API_URL = "https://db.ygoprodeck.com/api/v7/cardinfo.php"
OUTPUT_PATH = ROOT / "public" / "data" / "yugioh-cards.json"
TCG_SUBSET_PATH = ROOT / "src" / "data" / "tcg-cards.json"
TCG_IDS_PATH = ROOT / "src" / "data" / "tcg-omega-ids.json"


def category(card_type: str) -> str:
    if "Monster" in card_type or card_type in {"Token", "Skill Card"}:
        return "Monster"
    return "Spell" if "Spell" in card_type else "Trap"


def card_types(card_type: str, card_category: str) -> list[str] | None:
    if card_category != "Monster":
        return None
    lowered = card_type.casefold()
    values = [value for value in (
        "Normal", "Effect", "Fusion", "Synchro", "Xyz", "Link",
        "Pendulum", "Ritual", "Tuner", "Flip", "Spirit", "Gemini",
        "Union", "Toon", "Token",
    ) if value.casefold() in lowered]
    return values or ["Effect"]


def legality(raw: dict[str, object]) -> dict[str, bool]:
    value = str((raw.get("banlist_info") or {}).get("ban_tcg") or "").casefold()
    return {
        "banned": value in {"banned", "forbidden"},
        "limited": value == "limited",
        "semiLimited": value in {"semi-limited", "semi limited"},
    }


def main() -> int:
    request = urllib.request.Request(API_URL, headers={"User-Agent": "YugiohCCG website catalog sync"})
    with urllib.request.urlopen(request, timeout=120) as response:
        source = json.load(response)["data"]

    subset = json.loads(TCG_SUBSET_PATH.read_text(encoding="utf-8"))
    omega_ids = json.loads(TCG_IDS_PATH.read_text(encoding="utf-8"))
    subset_by_passcode = {
        int(omega_ids[item["id"]]): item
        for item in subset
        if item.get("id") in omega_ids
    }
    output = []
    for raw in source:
        passcode = int(raw["id"])
        card_category = category(str(raw.get("type") or ""))
        local = subset_by_passcode.get(passcode)
        banlist = legality(raw)
        if local and local.get("legal"):
            banlist = local["legal"]
        link_markers = raw.get("linkmarkers") or []
        arrow_names = {
            "Top-Left": "TL", "Top": "T", "Top-Right": "TR", "Left": "L",
            "Right": "R", "Bottom-Left": "BL", "Bottom": "B", "Bottom-Right": "BR",
        }
        normalized_type = str(raw.get("type") or "").casefold()
        is_xyz = "xyz" in normalized_type
        is_link = "link" in normalized_type
        output.append(
            {
                "id": f"YGO-{passcode}",
                "passcode": passcode,
                "name": raw.get("name"),
                "image": local.get("image") if local else "",
                "set": None,
                "archetype": raw.get("archetype"),
                "text": raw.get("desc"),
                "keywords": None,
                "category": card_category,
                "icon": raw.get("race") if card_category != "Monster" else None,
                "cardTypes": card_types(str(raw.get("type") or ""), card_category),
                "monsterType": [raw.get("race")] if card_category == "Monster" and raw.get("race") else None,
                "attribute": raw.get("attribute"),
                "level": None if is_xyz or is_link else raw.get("level"),
                "rank": raw.get("level") if is_xyz else None,
                "linkRating": raw.get("linkval") if is_link else None,
                "linkArrows": [arrow_names[value] for value in link_markers if value in arrow_names] or None,
                "scale": raw.get("scale"),
                "atk": raw.get("atk"),
                "def": raw.get("def"),
                "legal": banlist,
            }
        )

    output.sort(key=lambda card: (str(card["name"]).casefold(), int(card["passcode"])))
    OUTPUT_PATH.parent.mkdir(parents=True, exist_ok=True)
    OUTPUT_PATH.write_text(json.dumps(output, separators=(",", ":"), ensure_ascii=False) + "\n", encoding="utf-8")
    print(f"wrote {OUTPUT_PATH.relative_to(ROOT)} ({len(output)} Yu-Gi-Oh! cards)")
    return 0


if __name__ == "__main__":
    raise SystemExit(main())

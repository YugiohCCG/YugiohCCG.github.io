"""Mechanically synchronize the explicit community changes, preserving other limits."""
import json
import re
from pathlib import Path

ROOT = Path(__file__).resolve().parents[1]


def read(name):
    return json.loads((ROOT / name).read_text(encoding="utf-8-sig"))


def write(name, value, compact=False):
    (ROOT / name).write_text(json.dumps(value, ensure_ascii=False,
        indent=None if compact else 2, separators=(",", ":") if compact else None) + "\n", encoding="utf-8")


def norm(name):
    return re.sub(r"[^A-Z0-9]", "", name.upper())


def main():
    update = read("src/data/banlist-update.json")
    changes = {item["passcode"]: item for item in update["changes"]}
    by_name = {norm(item["name"]): item for item in changes.values()}
    catalog = read("public/data/yugioh-cards.json")
    cards = {card["passcode"]: card for card in catalog}
    # Recover the custom record from the already-built public banlist/source mirror.
    public_custom = read("public/assets/cards.json")
    cards.update({c["passcode"]: c for c in public_custom})
    assert all(code in cards for code in changes), "Missing authoritative card identity"
    for code, item in changes.items():
        assert norm(cards[code]["name"]) == norm(item["name"]), (code, cards[code]["name"])

    def amend(card, limit):
        card.setdefault("legal", {}).update(banned=limit == 0, limited=limit == 1, semiLimited=limit == 2)

    subset = read("src/data/tcg-cards.json")
    ids = read("src/data/tcg-omega-ids.json")
    for code, item in changes.items():
        if code == 224235021:
            continue
        matches = [c for c in subset if norm(c["name"]) == norm(item["name"])]
        if not matches:
            card = dict(cards[code])
            card["id"] = "TCG-" + str(code)
            subset.append(card)
            matches = [card]
        for card in matches:
            amend(card, item["limit"])
            card["passcode"] = code
            ids[card["id"]] = str(code)
    for collection in [catalog, public_custom]:
        for card in collection:
            item = changes.get(card.get("passcode"))
            if item:
                amend(card, item["limit"])

    conf = ROOT / "public/CCG Downloads/CCG_Banlist/CCG_Banlist.lflist.conf"
    rows = {}
    for line in conf.read_text(encoding="utf-8").splitlines():
        match = re.fullmatch(r"(\d+)\s+([012])\s+--(.*)", line)
        if match:
            code, limit, name = match.groups()
            assert int(code) not in rows, "Duplicate existing banlist entry"
            rows[int(code)] = (int(limit), name)
    old_rows = dict(rows)
    for code, item in changes.items():
        rows.pop(code, None)
        if item["limit"] < 3:
            rows[code] = (item["limit"], item["name"])
    assert {k: v for k, v in old_rows.items() if k not in changes} == {k: v for k, v in rows.items() if k not in changes}
    lines = ["!CCG Banlist", "# Effective " + update["effectiveDate"]]
    for limit, heading in enumerate(["forbidden", "limited", "semi-limited"]):
        lines.append("#" + heading)
        lines.extend(f"{code} {limit} --{name}" for code, (n, name) in sorted(rows.items(), key=lambda pair: pair[1][1].casefold()) if n == limit)
    # Keep the existing catalog for unchanged restricted cards; add verified metadata
    # for newly restricted ones and remove now-unlimited entries.
    displayed = {int(c["passcode"]): c for c in read("public/data/banlist-cards.json")}
    for code in changes:
        displayed.pop(code, None)
        if code in rows:
            displayed[code] = dict(cards[code])
            amend(displayed[code], rows[code][0])
    assert set(displayed) == set(rows), "Public banlist and Omega list disagree"
    write("src/data/tcg-cards.json", subset)
    write("src/data/tcg-omega-ids.json", ids)
    write("public/data/yugioh-cards.json", catalog, compact=True)
    write("public/assets/cards.json", public_custom)
    write("public/data/banlist-cards.json", list(displayed.values()))
    conf.write_text("\n".join(lines) + "\n", encoding="utf-8")
    print(f"Applied {len(changes)} changes effective {update['effectiveDate']}; preserved {len(old_rows.keys() - changes.keys())} other restrictions")


if __name__ == "__main__":
    main()

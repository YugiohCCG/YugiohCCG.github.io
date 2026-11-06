import json
import os

cards = {c["id"]: c for c in json.load(open("src/data/cards.json", encoding="utf-8"))}

for cid in ["CARD-0114", "CARD-00549", "CARD-00567"]:
    c = cards[cid]
    p = c["passcode"]
    print("=" * 60)
    print(cid, p, c["name"], c.get("cardTypes"))
    print("TEXT:", c.get("text"))
    lua_path = f"public/CCG Downloads/CCG_Scripts/c{p}.lua"
    if os.path.exists(lua_path):
        lines = open(lua_path, encoding="utf-8", errors="replace").readlines()
        for idx, l in enumerate(lines):
            if "GetLocationCount" in l:
                print(f"  Line {idx+1}: {l.strip()}")

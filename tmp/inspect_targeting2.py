import json
import os

cards = {c["id"]: c for c in json.load(open("src/data/cards.json", encoding="utf-8"))}
for cid in ["CARD-0043", "CARD-0044", "CARD-0052", "CARD-0111", "CARD-0173", "CARD-0196", "CARD-00223", "CARD-00224"]:
    c = cards[cid]
    print("=" * 60)
    print(cid, c["name"])
    print("TEXT:", c.get("text"))
    p = c["passcode"]
    lua_path = f"public/CCG Downloads/CCG_Scripts/c{p}.lua"
    if os.path.exists(lua_path):
        lua = open(lua_path, encoding="utf-8", errors="replace").read()
        for l in lua.splitlines():
            if any(k in l for k in ["EFFECT_FLAG_CARD_TARGET", "SelectTarget", "SetTargetCard", "GetFirstTarget"]):
                print("  LUA:", l.strip())

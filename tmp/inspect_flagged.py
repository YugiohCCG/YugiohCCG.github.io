import json
import os

cards = {c.get("passcode"): c for c in json.load(open("src/data/cards.json", encoding="utf-8"))}

ids = [238274861, 238276578, 238272437, 284639724, 284636586, 238273770, 247755865, 247755871, 284639723]

for p in ids:
    c = cards.get(p)
    if not c:
        print(f"Card {p} not found in cards.json!")
        continue
    print("=" * 80)
    print(f"Passcode: {p} | ID: {c.get('id')} | Name: {c.get('name')}")
    print("TEXT:")
    print(c.get("text"))
    print("-" * 40)
    lua_path = f"public/CCG Downloads/CCG_Scripts/c{p}.lua"
    if os.path.exists(lua_path):
        code = open(lua_path, encoding="utf-8", errors="replace").read()
        print(f"LUA CODE ({len(code.splitlines())} lines):")
        # print first 50 lines or relevant parts
        lines = code.splitlines()
        for idx, l in enumerate(lines[:60]):
            print(f"{idx+1:3d}: {l}")
        if len(lines) > 60:
            print(f"... and {len(lines)-60} more lines")
    else:
        print("Lua file not found!")

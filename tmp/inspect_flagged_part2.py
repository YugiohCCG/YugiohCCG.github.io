import json
import os

cards = {c.get("passcode"): c for c in json.load(open("src/data/cards.json", encoding="utf-8"))}

ids = [238274861, 238276578, 238272437, 284639724, 284636586, 238273770]

for p in ids:
    c = cards.get(p)
    print("=" * 80)
    print(f"Passcode: {p} | ID: {c.get('id')} | Name: {c.get('name')}")
    print("TEXT:")
    print(c.get("text"))
    print("-" * 40)
    lua_path = f"public/CCG Downloads/CCG_Scripts/c{p}.lua"
    if os.path.exists(lua_path):
        code = open(lua_path, encoding="utf-8", errors="replace").read()
        lines = code.splitlines()
        for idx, l in enumerate(lines[:45]):
            print(f"{idx+1:3d}: {l}")
        if len(lines) > 45:
            print(f"... and {len(lines)-45} more lines")

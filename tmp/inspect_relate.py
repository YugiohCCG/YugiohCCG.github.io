import json
import os

cards = {c["id"]: c for c in json.load(open("src/data/cards.json", encoding="utf-8"))}
targets = [
    ("CARD-0011", 221822671, "thop"),
    ("CARD-0122", 259177849, "thop"),
    ("CARD-00478", 259626409, "repop"),
    ("CARD-00532", 259576196, "negop"),
    ("CARD-00554", 259926839, "thop")
]

for cid, passcode, func in targets:
    c = cards.get(cid, {})
    lua_path = f"public/CCG Downloads/CCG_Scripts/c{passcode}.lua"
    print("=" * 60)
    print(cid, passcode, c.get("name"))
    print("TEXT:", c.get("text"))
    if os.path.exists(lua_path):
        code = open(lua_path, encoding="utf-8", errors="replace").read()
        idx = code.find(f"function s.{func}")
        if idx != -1:
            end_idx = code.find("end", idx)
            print(f"FUNCTION s.{func}:")
            print(code[idx:end_idx+3])
        else:
            print(f"Function s.{func} not found")

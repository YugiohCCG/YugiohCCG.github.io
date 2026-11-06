import json
import os
import re

ROOT = os.path.abspath(".")
CARDS_PATH = os.path.join(ROOT, "src", "data", "cards.json")
SCRIPTS_PATH = os.path.join(ROOT, "public", "CCG Downloads", "CCG_Scripts")

with open(CARDS_PATH, "r", encoding="utf-8") as f:
    cards = json.load(f)

print(f"Loaded {len(cards)} cards")

pends = [c for c in cards if "Pendulum" in (c.get("cardTypes") or []) or c.get("scale") is not None]
print(f"Pendulum cards count: {len(pends)}")
for p in pends:
    passcode = p.get("passcode")
    lua_file = f"c{passcode}.lua"
    lua_exists = os.path.exists(os.path.join(SCRIPTS_PATH, lua_file))
    print(f"{p.get('id')}\t{passcode}\tScale: {p.get('scale')}\tLua: {lua_exists}\t{p.get('name')}")

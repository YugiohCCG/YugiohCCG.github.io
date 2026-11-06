import json
import os
import re

ROOT = os.path.abspath(".")
CARDS_PATH = os.path.join(ROOT, "src", "data", "cards.json")
SCRIPTS_PATH = os.path.join(ROOT, "public", "CCG Downloads", "CCG_Scripts")

with open(CARDS_PATH, "r", encoding="utf-8") as f:
    cards = {c["id"]: c for c in json.load(f)}

check_ids = [
    "CARD-0043", "CARD-0044", "CARD-0052", "CARD-0111", "CARD-0173",
    "CARD-0196", "CARD-00223", "CARD-00224", "CARD-00258", "CARD-00505",
    "CARD-00513", "CARD-00572", "CARD-00586", "CARD-00593"
]

for cid in check_ids:
    c = cards.get(cid)
    if not c:
        continue
    passcode = c.get("passcode")
    text = c.get("text") or ""
    lua_file = os.path.join(SCRIPTS_PATH, f"c{passcode}.lua")
    lua_code = open(lua_file, "r", encoding="utf-8", errors="replace").read() if os.path.exists(lua_file) else ""
    
    print("=" * 80)
    print(f"{cid} | Passcode: {passcode} | Name: {c.get('name')}")
    print("TEXT:")
    print(text)
    print("-" * 40)
    print("LUA TARGETING EVIDENCE:")
    for line in lua_code.splitlines():
        if any(k in line for k in ["EFFECT_FLAG_CARD_TARGET", "SelectTarget", "SetTargetCard", "GetFirstTarget"]):
            print(" ", line.strip())

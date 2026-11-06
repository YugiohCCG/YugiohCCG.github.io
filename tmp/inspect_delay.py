import json
import os

cards = {c["id"]: c for c in json.load(open("src/data/cards.json", encoding="utf-8"))}

delay_candidates = [
    ("CARD-0132", 245400676),
    ("CARD-0198", 219543855),
    ("CARD-00265", 259366507),
    ("CARD-00266", 257081514),
    ("CARD-00323", 221924008),
    ("CCG-00369", 230749983),
    ("CCG-00370", 250262550),
    ("CCG-00376", 252496004),
    ("CARD-00401", 259479818),
    ("CARD-00473", 259724129),
    ("CARD-00474", 259688514),
    ("CARD-00527", 259072906),
    ("CARD-0685", 247755873)
]

for cid, p in delay_candidates:
    c = cards.get(cid)
    if not c:
        continue
    print("=" * 70)
    print(f"{cid} | {p} | {c.get('name')}")
    print("TEXT:", c.get("text"))
    lua_path = f"public/CCG Downloads/CCG_Scripts/c{p}.lua"
    if os.path.exists(lua_path):
        lines = open(lua_path, encoding="utf-8", errors="replace").readlines()
        for idx, l in enumerate(lines[:60]):
            if any(k in l for k in ["EVENT_SUMMON", "EVENT_SPSUMMON", "EVENT_TO_GRAVE", "EFFECT_FLAG_DELAY", "EFFECT_TYPE_TRIGGER_O", "SetProperty"]):
                print(f"  Line {idx+1:2d}: {l.strip()}")

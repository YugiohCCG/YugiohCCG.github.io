import json

cards = json.load(open("src/data/cards.json", encoding="utf-8"))
banlist = json.load(open("src/data/banlist.json", encoding="utf-8"))

cards_by_name = {c["name"].strip().lower(): c for c in cards}
cards_by_passcode = {c.get("passcode"): c for c in cards if c.get("passcode")}

print("Banlist categories:", list(banlist.keys()))

mismatches = []

for status, section in banlist.items():
    if not isinstance(section, list):
        continue
    expected_banned = (status == "banned" or status == "forbidden")
    expected_limited = (status == "limited")
    expected_semi = (status == "semiLimited" or status == "semi-limited")
    
    for item in section:
        # item can be string name or dict
        name = item if isinstance(item, str) else item.get("name")
        passcode = item.get("passcode") if isinstance(item, dict) else None
        
        c = None
        if passcode and passcode in cards_by_passcode:
            c = cards_by_passcode[passcode]
        elif name and name.strip().lower() in cards_by_name:
            c = cards_by_name[name.strip().lower()]
            
        if not c:
            mismatches.append(f"Card in banlist '{name}' not found in cards.json")
            continue
            
        l = c.get("legal") or {}
        if expected_banned and not l.get("banned"):
            mismatches.append(f"Card '{c['name']}' is in banlist as {status}, but legal.banned is {l.get('banned')}")
        if expected_limited and not l.get("limited"):
            mismatches.append(f"Card '{c['name']}' is in banlist as limited, but legal.limited is {l.get('limited')}")
        if expected_semi and not l.get("semiLimited"):
            mismatches.append(f"Card '{c['name']}' is in banlist as semi-limited, but legal.semiLimited is {l.get('semiLimited')}")

print(f"Total banlist mismatches: {len(mismatches)}")
for m in mismatches[:20]:
    print(" ", m)

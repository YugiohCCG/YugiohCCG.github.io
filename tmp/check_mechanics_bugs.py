import json
import os
import re

ROOT = os.path.abspath(".")
CARDS_PATH = os.path.join(ROOT, "src", "data", "cards.json")
SCRIPTS_PATH = os.path.join(ROOT, "public", "CCG Downloads", "CCG_Scripts")

cards = json.load(open(CARDS_PATH, "r", encoding="utf-8"))

issues = []

for c in cards:
    cid = c.get("id")
    p = c.get("passcode")
    name = c.get("name")
    text = c.get("text") or ""
    cat = c.get("category")
    icon = c.get("icon")
    
    if not p:
        continue
    lua_path = os.path.join(SCRIPTS_PATH, f"c{p}.lua")
    if not os.path.exists(lua_path):
        continue
    lua = open(lua_path, "r", encoding="utf-8", errors="replace").read()

    # 1. Check for SetUniqueOnField without player limitation
    if "SetUniqueOnField" in lua:
        for idx, l in enumerate(lua.splitlines()):
            if "SetUniqueOnField" in l:
                m_u = re.search(r"SetUniqueOnField\s*\(\s*(\d+)\s*,\s*(\d+)", l)
                if m_u:
                    s_code = int(m_u.group(2))
                    if "you can only control 1" in text.lower():
                        if s_code != 0:
                            issues.append({
                                "card_id": cid, "passcode": p, "name": name,
                                "type": "Unique On Field Scope Bug",
                                "severity": "HIGH",
                                "line": idx + 1,
                                "defect": f"Text says 'You can only control 1 {name}', but SetUniqueOnField has controler flag {s_code} (locks both players)",
                                "proposed_change": "Change SetUniqueOnField(1, 1, id) to SetUniqueOnField(1, 0, id)."
                            })

    # 2. Check for Spell/Trap activation without EVENT_FREE_CHAIN
    if cat in ["Spell", "Trap"] and icon in ["Normal", "Quick-Play", "Continuous"]:
        if "EFFECT_TYPE_ACTIVATE" in lua:
            # find the line creating activation effect
            for idx, l in enumerate(lua.splitlines()):
                if "EFFECT_TYPE_ACTIVATE" in l:
                    evar = l.split(":")[0].strip()
                    # extract lines defining evar
                    eblock = "\n".join([line for line in lua.splitlines() if evar in line])
                    if ":SetCode" not in eblock:
                        issues.append({
                            "card_id": cid, "passcode": p, "name": name,
                            "type": "Missing Activation Code",
                            "severity": "CRITICAL",
                            "defect": f"Spell/Trap activate effect {evar} does not set activation event code (missing SetCode(EVENT_FREE_CHAIN))",
                            "proposed_change": f"Add {evar}:SetCode(EVENT_FREE_CHAIN)."
                        })

    # 3. Check for target function without chkc
    if "EFFECT_FLAG_CARD_TARGET" in lua:
        tg_funcs = re.findall(r"function\s+s\.([A-Za-z0-9_]*tg)\s*\(([^)]*)\)", lua)
        for fname, fargs in tg_funcs:
            fn_match = re.search(rf"function\s+s\.{fname}\b.*?\nend\b", lua, re.DOTALL)
            if fn_match:
                fbody = fn_match.group(0)
                if "Duel.SelectTarget" in fbody and "chkc" not in fbody:
                    issues.append({
                        "card_id": cid, "passcode": p, "name": name,
                        "type": "Target Re-check Omission",
                        "severity": "LOW",
                        "function": fname,
                        "defect": f"Target function s.{fname} calls Duel.SelectTarget but does not handle 'chkc' parameter for target validity re-check during chain resolution",
                        "proposed_change": f"Add `if chkc then return ... end` to s.{fname}."
                    })

print(f"Total mechanics issues found: {len(issues)}")
by_t = {}
for i in issues:
    by_t.setdefault(i["type"], []).append(i)
for t, lst in by_t.items():
    print(f"  {t}: {len(lst)}")
    for item in lst[:5]:
        print(f"    {item['card_id']} ({item['passcode']}) {item['name']}: {item['defect']}")

with open("tmp/mechanics_issues.json", "w", encoding="utf-8") as out:
    json.dump(issues, out, indent=2)

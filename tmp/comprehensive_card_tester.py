import json
import os
import re

ROOT = os.path.abspath(".")
CARDS_PATH = os.path.join(ROOT, "src", "data", "cards.json")
SCRIPTS_PATH = os.path.join(ROOT, "public", "CCG Downloads", "CCG_Scripts")

cards = json.load(open(CARDS_PATH, "r", encoding="utf-8"))

bugs = []

for c in cards:
    cid = c.get("id")
    p = c.get("passcode")
    name = c.get("name")
    text = c.get("text") or ""
    card_types = c.get("cardTypes") or []
    cat = c.get("category")
    
    if not p:
        bugs.append({
            "card_id": cid, "passcode": None, "name": name,
            "category": "Missing Data",
            "severity": "CRITICAL",
            "defect": "Card has no passcode assigned in cards.json",
            "proposed_change": "Assign a valid numeric passcode and sync with CCG database."
        })
        continue
        
    lua_path = os.path.join(SCRIPTS_PATH, f"c{p}.lua")
    if not os.path.exists(lua_path):
        bugs.append({
            "card_id": cid, "passcode": p, "name": name,
            "category": "Missing Script",
            "severity": "CRITICAL",
            "defect": f"Lua script c{p}.lua does not exist in CCG_Scripts",
            "proposed_change": f"Create c{p}.lua for {name} implementing card text."
        })
        continue
        
    lua = open(lua_path, "r", encoding="utf-8", errors="replace").read()
    lines = lua.splitlines()

    # Rule 4: Stringid overflow (index >= 16)
    for idx, l in enumerate(lines):
        m = re.search(r"aux\.Stringid\s*\([^,]+,\s*(\d+)\s*\)", l)
        if m:
            s_idx = int(m.group(1))
            if s_idx >= 16:
                bugs.append({
                    "card_id": cid, "passcode": p, "name": name,
                    "category": "Script / UI Defect",
                    "severity": "HIGH",
                    "file": f"c{p}.lua", "line": idx + 1,
                    "defect": f"aux.Stringid index {s_idx} >= 16 overflows Omega 4-bit string index mask",
                    "code_snippet": l.strip(),
                    "proposed_change": f"Use string indices 0-15 only (e.g. aux.Stringid(id, {s_idx % 16}))."
                })

    # Rule 8: Unbound CARD_* constants
    for idx, l in enumerate(lines):
        for m in re.finditer(r"\b(CARD_[A-Z0-9_]+)\b", l):
            cname = m.group(1)
            # check if defined in script
            if not re.search(rf"\b(?:local\s+)?{cname}\s*=", lua):
                bugs.append({
                    "card_id": cid, "passcode": p, "name": name,
                    "category": "Lua Runtime Defect",
                    "severity": "HIGH",
                    "file": f"c{p}.lua", "line": idx + 1,
                    "defect": f"Unbound constant {cname} is used without definition (evaluates to nil in Omega)",
                    "code_snippet": l.strip(),
                    "proposed_change": f"Define local {cname} = <passcode> at the top of c{p}.lua."
                })

    # Rule 23: Extra Deck Special Summon checking GetLocationCount instead of GetLocationCountFromEx
    is_extra = any(t in card_types for t in ["Fusion", "Synchro", "Xyz", "Link"])
    if is_extra:
        # Check contact fusion or self spsummon procedure in script
        for idx, l in enumerate(lines):
            if "Duel.GetLocationCount(tp,LOCATION_MZONE)" in l.replace(" ", "") and (
                "c:IsLocation(LOCATION_EXTRA)" in lua or "s.contact" in l or "EFFECT_SPSUMMON_PROC" in lua
            ):
                # Check if it checks Extra Deck summon legality
                if "LOCATION_EXTRA" in lua and not "GetLocationCountFromEx" in lua:
                    bugs.append({
                        "card_id": cid, "passcode": p, "name": name,
                        "category": "Zone Calculation Bug",
                        "severity": "MEDIUM",
                        "file": f"c{p}.lua", "line": idx + 1,
                        "defect": "Extra Deck monster checks Duel.GetLocationCount instead of Duel.GetLocationCountFromEx",
                        "code_snippet": l.strip(),
                        "proposed_change": "Replace with Duel.GetLocationCountFromEx(tp, tp, nil, c) > 0."
                    })
                    break

    # Rule: Missing NecrovalleyFilter on GY moves/targets
    # If text targets a card in the GY to move to Hand/Field/Deck
    if re.search(r"\btarget\s+(?:\d+|1|2|a|an).*in (?:your|the|either) gy\b", text, re.I):
        if "LOCATION_GRAVE" in lua and "SelectTarget" in lua:
            if not "aux.NecroValleyFilter" in lua and not "NecroValleyFilter" in lua:
                # check if it actually moves or Special Summons
                if any(k in lua for k in ["CATEGORY_SPECIAL_SUMMON", "CATEGORY_TOHAND", "CATEGORY_TODECK", "CATEGORY_REMOVE"]):
                    bugs.append({
                        "card_id": cid, "passcode": p, "name": name,
                        "category": "Ruling / Necrovalley Integrity",
                        "severity": "LOW",
                        "file": f"c{p}.lua",
                        "defect": "Targets card in GY to move without wrapping filter in aux.NecroValleyFilter",
                        "proposed_change": "Wrap target filter or operation selection in aux.NecroValleyFilter."
                    })

    # Rule: Optional "If" trigger missing EFFECT_FLAG_DELAY
    # E.g. "If this card is Normal or Special Summoned: You can" or "If this card is sent to the GY: You can"
    if re.search(r"\bIf this card is (?:Normal|Special|Synchro|Fusion|Xyz|Link)?\s*Summoned: You can\b", text, re.I) or \
       re.search(r"\bIf this card is sent to the GY: You can\b", text, re.I):
        # find effect registered with EVENT_SUMMON_SUCCESS or EVENT_SPSUMMON_SUCCESS or EVENT_TO_GRAVE
        for idx, l in enumerate(lines):
            if re.search(r":SetCode\s*\(\s*EVENT_(?:SUMMON_SUCCESS|SPSUMMON_SUCCESS|TO_GRAVE)\s*\)", l):
                # find the effect variable name e.g. e1
                var_m = re.search(r"(\w+):SetCode", l)
                if var_m:
                    evar = var_m.group(1)
                    # check if evar has SetProperty with EFFECT_FLAG_DELAY
                    e_block = "\n".join([line for line in lines if evar in line])
                    if "EFFECT_FLAG_DELAY" not in e_block:
                        bugs.append({
                            "card_id": cid, "passcode": p, "name": name,
                            "category": "Timing / Missing DELAY Flag",
                            "severity": "HIGH",
                            "file": f"c{p}.lua", "line": idx + 1,
                            "defect": f"Optional 'If...: You can' trigger effect ({evar}) misses EFFECT_FLAG_DELAY (can miss timing in Omega)",
                            "code_snippet": l.strip(),
                            "proposed_change": f"Add {evar}:SetProperty(EFFECT_FLAG_DELAY) (or include it in existing SetProperty)."
                        })

    # Rule: Hard OPT in Text vs Soft OPT in Script
    # Text: "You can only use this effect of [Name] once per turn" or "You can only use each effect... once per turn"
    hard_opt_in_text = bool(re.search(r"only use (?:this|each|\d+) effect.*once per turn", text, re.I))
    # Check if all ignition / trigger effects have SetCountLimit(1, id...)
    if hard_opt_in_text:
        for idx, l in enumerate(lines):
            # matches e1:SetCountLimit(1) or SetCountLimit(1, EFFECT_COUNT_CODE_SINGLE) without id
            soft_m = re.search(r":SetCountLimit\s*\(\s*(\d+)\s*\)", l)
            if soft_m:
                e_line = l.strip()
                # find effect var
                var_m = re.search(r"(\w+):SetCountLimit", l)
                evar = var_m.group(1) if var_m else "e"
                # check if this effect is not an OPT continuous effect or similar
                # check if text only had 1 effect or "each effect"
                if "each effect" in text.lower():
                    bugs.append({
                        "card_id": cid, "passcode": p, "name": name,
                        "category": "OPT Enforcement Defect",
                        "severity": "HIGH",
                        "file": f"c{p}.lua", "line": idx + 1,
                        "defect": f"Card text specifies Hard OPT ('You can only use each effect... once per turn'), but {evar} uses soft limit SetCountLimit(1)",
                        "code_snippet": e_line,
                        "proposed_change": f"Change {e_line} to {evar}:SetCountLimit(1, id)."
                    })

print(f"Total automated bug candidates found: {len(bugs)}")
with open("tmp/comprehensive_bug_scan.json", "w", encoding="utf-8") as out:
    json.dump(bugs, out, indent=2)

print("Saved to tmp/comprehensive_bug_scan.json")

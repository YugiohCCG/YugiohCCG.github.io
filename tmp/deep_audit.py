import json
import os
import re

ROOT = os.path.abspath(".")
CARDS_PATH = os.path.join(ROOT, "src", "data", "cards.json")
SCRIPTS_PATH = os.path.join(ROOT, "public", "CCG Downloads", "CCG_Scripts")

with open(CARDS_PATH, "r", encoding="utf-8") as f:
    cards = json.load(f)

findings = {
    "link_def": [],
    "xyz_level": [],
    "pendulum_issues": [],
    "opt_mismatch": [],
    "target_mismatch": [],
    "relate_to_effect_missing": [],
    "destroy_vs_send": [],
    "missing_lua": [],
    "stat_mismatch": []
}

for c in cards:
    cid = c.get("id")
    name = c.get("name")
    passcode = c.get("passcode")
    text = c.get("text") or ""
    card_types = c.get("cardTypes") or []
    cat = c.get("category")
    
    # 1. Link monster with DEF
    if "Link" in card_types or c.get("linkRating") is not None:
        if c.get("def") is not None:
            findings["link_def"].append({
                "id": cid, "passcode": passcode, "name": name,
                "linkRating": c.get("linkRating"), "def": c.get("def")
            })
            
    # 2. Xyz monster with Level
    if "Xyz" in card_types:
        if c.get("level") is not None:
            findings["xyz_level"].append({
                "id": cid, "passcode": passcode, "name": name,
                "level": c.get("level"), "rank": c.get("rank")
            })

    # 3. Check Lua script
    if not passcode:
        findings["missing_lua"].append({"id": cid, "name": name, "reason": "No passcode"})
        continue
    
    lua_file = os.path.join(SCRIPTS_PATH, f"c{passcode}.lua")
    if not os.path.exists(lua_file):
        findings["missing_lua"].append({"id": cid, "passcode": passcode, "name": name, "reason": "File not found"})
        continue
        
    with open(lua_file, "r", encoding="utf-8", errors="replace") as lf:
        lua_code = lf.read()
        
    # 4. Pendulum checks
    if "Pendulum" in card_types or c.get("scale") is not None:
        has_pend_proc = "Pendulum.AddProcedure" in lua_code or "EnablePendulumAttribute" in lua_code
        has_pzone_loc = "LOCATION_PZONE" in lua_code
        has_pend_desc = "[ Pendulum Effect ]" in text or "[Pendulum Effect]" in text or "Pendulum Effect" in text
        if not has_pend_proc:
            findings["pendulum_issues"].append({"id": cid, "passcode": passcode, "name": name, "issue": "Missing Pendulum.AddProcedure in Lua"})
        if not has_pzone_loc and has_pend_desc:
            findings["pendulum_issues"].append({"id": cid, "passcode": passcode, "name": name, "issue": "Has Pendulum text but no LOCATION_PZONE in Lua"})

    # 5. OPT checks
    # Look for "You can only use this effect of ... once per turn" or "You can only use each effect ... once per turn"
    has_hard_opt_text = bool(re.search(r"only use (?:this|each|\d+) effect.*once per turn", text, re.I))
    has_soft_opt_text = bool(re.search(r"\bOnce per turn:", text, re.I) or re.search(r"\bOnce per turn,", text, re.I))
    
    # In Lua: SetCountLimit(1, id) vs SetCountLimit(1)
    has_hard_opt_lua = bool(re.search(r"SetCountLimit\s*\(\s*\d+\s*,\s*(?:id|CARD_\w+|s\.initial_effect|\d{8,9})", lua_code))
    has_soft_opt_lua = bool(re.search(r"SetCountLimit\s*\(\s*\d+\s*(?:,\s*EFFECT_COUNT_CODE_SINGLE)?\s*\)", lua_code))

    # 6. Target keyword vs EFFECT_FLAG_CARD_TARGET
    # If text explicitly says "target 1" or "target up to" or "then target"
    has_target_text = bool(re.search(r"\btarget\s+(?:\d+|up to|that|those|1|2|3)\b", text, re.I))
    has_target_flag = "EFFECT_FLAG_CARD_TARGET" in lua_code or "Duel.SelectTarget" in lua_code or "Duel.SetTargetCard" in lua_code
    
    if has_target_text and not has_target_flag:
        # Check if it's just 'cannot be targeted' or 'cannot target'
        non_targeting_contexts = bool(re.search(r"(?:cannot|can never)\s+(?:be targeted|target)", text, re.I))
        # Count positive target occurrences
        pos_targets = re.findall(r"\b(?:then|you can)\s+target\b|\btarget\s+(?:\d+|up to|1|2|3)\b", text, re.I)
        if pos_targets:
            findings["target_mismatch"].append({
                "id": cid, "passcode": passcode, "name": name,
                "issue": "Text says target, but script has no EFFECT_FLAG_CARD_TARGET or SelectTarget",
                "sample": pos_targets[:2]
            })
    elif not has_target_text and has_target_flag:
        # Script targets, but does text say target?
        if not re.search(r"\btarget\b", text, re.I):
            findings["target_mismatch"].append({
                "id": cid, "passcode": passcode, "name": name,
                "issue": "Script has EFFECT_FLAG_CARD_TARGET/SelectTarget, but text does not say target (non-targeting)"
            })

    # 7. Relate to effect check on targeted cards
    # If script uses Duel.GetFirstTarget() or SelectTarget, does it check IsRelateToEffect?
    if "Duel.GetFirstTarget" in lua_code or "Duel.GetChainInfo(0,CHAININFO_TARGET_CARDS)" in lua_code:
        # Find operation functions
        ops = re.findall(r"function\s+s\.([A-Za-z0-9_]+op)\b", lua_code)
        for op in ops:
            # extract body of op
            op_match = re.search(rf"function\s+s\.{op}\b.*?\nend", lua_code, re.DOTALL)
            if op_match:
                op_body = op_match.group(0)
                if ("Duel.GetFirstTarget" in op_body or "GetFirst" in op_body) and "IsRelateToEffect" not in op_body:
                    # check if op does actions on tc without IsRelateToEffect
                    if re.search(r"tc\s*:\s*(?:IsFaceup|IsRelateToBattle|GetControl|IsAbleTo|IsLocation)", op_body) and not re.search(r"tc\s*:\s*IsRelateToEffect", op_body):
                        findings["relate_to_effect_missing"].append({
                            "id": cid, "passcode": passcode, "name": name, "function": op
                        })

print(f"Link DEF issues: {len(findings['link_def'])}")
print(f"Xyz Level issues: {len(findings['xyz_level'])}")
print(f"Pendulum issues: {len(findings['pendulum_issues'])}")
print(f"Target mismatches: {len(findings['target_mismatch'])}")
print(f"Missing IsRelateToEffect: {len(findings['relate_to_effect_missing'])}")

with open("tmp/deep_audit_results.json", "w", encoding="utf-8") as out:
    json.dump(findings, out, indent=2)
print("Saved findings to tmp/deep_audit_results.json")

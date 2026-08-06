import os
import json
import re

def verify_intent():
    cards_path = r"C:\Manual Files\Applications\YugiohCCG.github.io\src\data\cards.json"
    scripts_dir = r"C:\Manual Files\Applications\YugiohCCG.github.io\public\CCG Downloads\CCG_Scripts"
    report_path = r"C:\Manual Files\Applications\YugiohCCG.github.io\docs\ccg-logical-intent-report.md"
    
    with open(cards_path, 'r', encoding='utf-8') as f:
        cards = json.load(f)
        
    discrepancies = []
    total_cards = 0
    passed_cards = 0
    
    for card in cards:
        passcode = card.get('passcode')
        if not passcode: continue
        
        text = card.get('text', '').lower()
        if not text: continue
        
        script_path = os.path.join(scripts_dir, f"c{passcode}.lua")
        if not os.path.exists(script_path):
            continue
            
        total_cards += 1
        
        with open(script_path, 'r', encoding='utf-8', errors='ignore') as f:
            script_content = f.read()
            
        expected_patterns = []
        
        # Rule definitions: (Trigger text, list of acceptable Lua patterns)
        rules = [
            (r'\bdestroy\b', ['Duel.Destroy', 'EFFECT_DESTROY_REPLACE', 'REASON_DESTROY', 'EFFECT_INDESTRUCTABLE']),
            (r'\bbanish\b', ['Duel.Remove', 'LOCATION_REMOVED', 'POS_FACEDOWN']),
            (r'\bdraw\b', ['Duel.Draw']),
            (r'\bspecial summon\b', ['Duel.SpecialSummon', 'EFFECT_SPSUMMON_PROC', 'EFFECT_CANNOT_SPECIAL_SUMMON', 'Duel.IsPlayerCanSpecialSummonMonster']),
            (r'\bnegate\b', ['Duel.NegateEffect', 'Duel.NegateActivation', 'EFFECT_DISABLE', 'EFFECT_DISABLE_EFFECT', 'EFFECT_CANNOT_ACTIVATE']),
            (r'\btarget\b', ['EFFECT_FLAG_CARD_TARGET', 'Duel.SelectTarget', 'EFFECT_CANNOT_BE_EFFECT_TARGET']),
            (r'\bdamage\b', ['Duel.Damage', 'EFFECT_AVOID_BATTLE_DAMAGE', 'EFFECT_CHANGE_DAMAGE']),
            (r'\bdiscard\b', ['Duel.SendtoGrave', 'Duel.DiscardHand', 'REASON_DISCARD']),
            (r'\badd.*?to (your |their )?hand\b', ['Duel.SendtoHand'])
        ]
        
        card_discrepancies = []
        
        for rule_text, lua_patterns in rules:
            if re.search(rule_text, text):
                # Text contains the keyword, so the script should contain at least one of the Lua patterns
                found = False
                for pattern in lua_patterns:
                    if pattern in script_content:
                        found = True
                        break
                
                if not found:
                    cleaned_rule = rule_text.replace('\\b', '').strip('()|.*?')
                    card_discrepancies.append(f"Text mentions `{cleaned_rule}` but missing expected Lua pattern (e.g. `{lua_patterns[0]}`)")
                    
        if card_discrepancies:
            discrepancies.append({
                'name': card.get('name'),
                'passcode': passcode,
                'issues': card_discrepancies
            })
        else:
            passed_cards += 1
            
    # Generate report
    lines = [
        "# CCG Logical Intent Verification Report",
        "",
        "This report uses heuristic mapping to verify that the Lua implementation mathematically fulfills the actions stated in the English card text. If a card says 'destroy', it expects to see 'Duel.Destroy', etc.",
        "",
        f"- **Total Cards Checked**: {total_cards}",
        f"- **Cards Passed Logic Test**: {passed_cards}",
        f"- **Cards Flagged (Discrepancies)**: {len(discrepancies)}",
        "---",
        ""
    ]
    
    for d in discrepancies:
        lines.append(f"## {d['name']} (c{d['passcode']}.lua)")
        for issue in d['issues']:
            lines.append(f"- **MISSING INTENT**: {issue}")
        lines.append("")
        
    with open(report_path, 'w', encoding='utf-8') as f:
        f.write('\n'.join(lines))
        
    print(f"Generated report at {report_path}. Found {len(discrepancies)} cards with potential missing logical intent.")

if __name__ == '__main__':
    verify_intent()

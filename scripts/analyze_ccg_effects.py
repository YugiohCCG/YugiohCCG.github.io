import os
import re
import glob
from collections import defaultdict
import time

def extract_effects(file_path):
    with open(file_path, 'r', encoding='utf-8', errors='ignore') as f:
        content = f.read()

    effects = []
    
    # Find all Effect.CreateEffect(c) or Effect.GlobalEffect(c)
    # The variable name could be e1, e2, e, etc.
    # We will just look for e.*:SetType, e.*:SetCode, etc.
    # To be more precise, we can split by Effect.CreateEffect or Effect.GlobalEffect
    
    blocks = re.split(r'Effect\.CreateEffect\(c\)|Effect\.GlobalEffect\(c\)', content)
    for block in blocks[1:]:
        # block contains the code after Effect.CreateEffect(c)
        # We assume the variable is something like e1, e2, etc.
        # But wait, it might be e:SetType
        # Let's just find the first SetType, SetCode, SetProperty, SetRange in this block
        # up to RegisterEffect
        
        register_split = re.split(r'RegisterEffect', block)
        if not register_split:
            continue
        
        effect_code_block = register_split[0]
        
        set_type = re.search(r':SetType\((.*?)\)', effect_code_block)
        set_code = re.search(r':SetCode\((.*?)\)', effect_code_block)
        set_property = re.search(r':SetProperty\((.*?)\)', effect_code_block)
        set_range = re.search(r':SetRange\((.*?)\)', effect_code_block)
        
        type_val = set_type.group(1).strip() if set_type else "NONE"
        code_val = set_code.group(1).strip() if set_code else "NONE"
        prop_val = set_property.group(1).strip() if set_property else "NONE"
        range_val = set_range.group(1).strip() if set_range else "NONE"
        
        # clean up concatenations or comments
        type_val = type_val.split('--')[0].strip()
        code_val = code_val.split('--')[0].strip()
        prop_val = prop_val.split('--')[0].strip()
        range_val = range_val.split('--')[0].strip()

        # Some properties use + or |, normalize them
        def normalize_flags(val):
            if val == "NONE": return val
            flags = [f.strip() for f in re.split(r'\+|\|', val)]
            flags.sort()
            return "+".join(flags)
            
        type_norm = normalize_flags(type_val)
        prop_norm = normalize_flags(prop_val)
        
        signature = f"Type:{type_norm}|Code:{code_val}|Prop:{prop_norm}|Range:{range_val}"
        effects.append(signature)
        
    return effects

def main():
    print("Starting analysis...")
    start_time = time.time()
    
    # 1. Build signature mapping from official scripts
    official_dir = r"C:\Manual Files\Applications\YugiohCCG.github.io\tmp\omega_scripts"
    official_files = glob.glob(os.path.join(official_dir, "**", "*.lua"), recursive=True)
    
    official_signatures = defaultdict(list)
    print(f"Found {len(official_files)} official Lua files. Parsing...")
    
    # Process a subset or all
    count = 0
    for file in official_files:
        try:
            effs = extract_effects(file)
            filename = os.path.basename(file)
            for eff in effs:
                if len(official_signatures[eff]) < 3: # Keep up to 3 examples
                    official_signatures[eff].append(filename)
        except Exception as e:
            pass
        count += 1
        if count % 2000 == 0:
            print(f"Parsed {count}/{len(official_files)} official files...")
            
    print(f"Extracted {len(official_signatures)} unique effect signatures from official scripts in {time.time() - start_time:.2f}s.")
    
    # 2. Analyze CCG scripts
    ccg_dir = r"C:\Manual Files\Applications\YugiohCCG.github.io\public\CCG Downloads\CCG_Scripts"
    ccg_files = glob.glob(os.path.join(ccg_dir, "*.lua"))
    
    print(f"Found {len(ccg_files)} CCG Lua files. Cross-referencing...")
    
    report_lines = []
    report_lines.append("# CCG Lua Effects Cross-Reference Report")
    report_lines.append(f"**Date**: {time.strftime('%Y-%m-%d')}\n")
    report_lines.append("This report cross-references every single effect in CCG Lua scripts against official Yugioh Omega scripts. Effects are matched by their (Type, Code, Property, Range) signature.\n")
    
    total_effects = 0
    passed_effects = 0
    failed_effects = 0
    
    for file in ccg_files:
        effs = extract_effects(file)
        filename = os.path.basename(file)
        report_lines.append(f"## {filename}")
        if not effs:
            report_lines.append("* No effects found using standard `Effect.CreateEffect` pattern.\n")
            continue
            
        for i, eff in enumerate(effs, 1):
            total_effects += 1
            if eff in official_signatures:
                passed_effects += 1
                examples = ", ".join(official_signatures[eff])
                report_lines.append(f"* **Effect {i}**: `PASS` (Matches official pattern found in: {examples})")
                report_lines.append(f"  * Signature: `{eff}`")
            else:
                failed_effects += 1
                report_lines.append(f"* **Effect {i}**: `FAIL` (No official script matches this effect signature)")
                report_lines.append(f"  * Signature: `{eff}`")
        report_lines.append("")
        
    report_lines.insert(3, "## Summary")
    report_lines.insert(4, f"- **Total Cards Analyzed**: {len(ccg_files)}")
    report_lines.insert(5, f"- **Total Effects Cross-Referenced**: {total_effects}")
    report_lines.insert(6, f"- **Effects Passed**: {passed_effects}")
    report_lines.insert(7, f"- **Effects Failed (Anomalous/Custom)**: {failed_effects}")
    report_lines.insert(8, "---\n")
    
    report_path = r"C:\Manual Files\Applications\YugiohCCG.github.io\docs\ccg-effects-cross-reference-report.md"
    with open(report_path, 'w', encoding='utf-8') as f:
        f.write("\n".join(report_lines))
        
    print(f"Done! Report generated at {report_path}")

if __name__ == '__main__':
    main()

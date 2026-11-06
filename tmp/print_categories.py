import json

data = json.load(open("tmp/comprehensive_bug_scan.json"))
by_cat = {}
for b in data:
    cat = b["category"]
    by_cat.setdefault(cat, []).append(b)

for cat, items in by_cat.items():
    print(f"=== {cat} ({len(items)}) ===")
    for item in items:
        line_info = f" (line {item.get('line')})" if item.get('line') else ""
        print(f"  [{item['severity']}] {item['card_id']} ({item['passcode']}) {item['name']}{line_info}: {item['defect']}")

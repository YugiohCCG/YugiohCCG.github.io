import os
import json
import difflib
from pathlib import Path

json_path = Path(r"c:\Applications\YugiohCCG.github.io\src\data\cards.json")
assets_dir = Path(r"c:\Applications\YugiohCCG.github.io\public\assets\cards")
backup_path = json_path.with_suffix('.match_assets2.bak')

assets = [f for f in os.listdir(assets_dir) if os.path.isfile(assets_dir / f)]
assets_lower = [f.lower() for f in assets]

with json_path.open('r', encoding='utf-8') as fh:
    data = json.load(fh)

applied = []
skipped = []
for entry in data:
    img = entry.get('image')
    if not isinstance(img, str):
        continue
    filename = img.rsplit('/',1)[-1]
    if filename in assets:
        continue
    # get suggestions
    matches = difflib.get_close_matches(filename.lower(), assets_lower, n=5, cutoff=0.5)
    if matches:
        candidate = assets[assets_lower.index(matches[0])]
        new_path = f"/assets/cards/{candidate}"
        if new_path != img:
            entry['image'] = new_path
            applied.append((img, new_path))
    else:
        # try normalized containment
        import re
        norm = re.sub(r'[^a-z0-9.]','', filename.lower())
        found = None
        for f in assets:
            if norm in re.sub(r'[^a-z0-9.]','', f.lower()):
                found = f
                break
        if found:
            candidate = found
            new_path = f"/assets/cards/{candidate}"
            entry['image'] = new_path
            applied.append((img, new_path))
        else:
            skipped.append(img)

# backup and write
backup_path.write_text(json.dumps(data, ensure_ascii=False, indent=2), encoding='utf-8')
json_path.write_text(json.dumps(data, ensure_ascii=False, indent=2), encoding='utf-8')

print(f'Applied suggestions: {len(applied)}')
if applied:
    print('\nSample applied:')
    for old, new in applied[:50]:
        print(f'  {old} -> {new}')

print(f'Unresolved (skipped): {len(skipped)}')
for s in skipped:
    print('  ', s)

print('Backup written to', backup_path)

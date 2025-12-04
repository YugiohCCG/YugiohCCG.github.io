import os
import json
from pathlib import Path

json_path = Path(r"c:\Applications\YugiohCCG.github.io\src\data\cards.json")
assets_dir = Path(r"c:\Applications\YugiohCCG.github.io\public\assets\cards")
backup_path = json_path.with_suffix('.match_assets.bak')

if not json_path.exists():
    print('cards.json not found at', json_path)
    raise SystemExit(1)

if not assets_dir.exists():
    print('Assets directory not found at', assets_dir)
    raise SystemExit(2)

assets = [f for f in os.listdir(assets_dir) if os.path.isfile(assets_dir / f)]
# build lookup maps
lower_map = {}
for f in assets:
    lower_map.setdefault(f.lower(), []).append(f)

# also indexes for underscore/hyphen variants
norm_map = {}
for f in assets:
    norm = f.replace('-', '_').lower()
    norm_map.setdefault(norm, []).append(f)
    norm2 = f.replace('_', '-').lower()
    norm_map.setdefault(norm2, []).append(f)

with json_path.open('r', encoding='utf-8') as fh:
    data = json.load(fh)

changed = 0
matched_details = []
unmatched = []

for entry in data:
    img = entry.get('image')
    if not isinstance(img, str):
        continue
    parts = img.rsplit('/', 1)
    if len(parts) == 2:
        prefix, filename = parts
    else:
        prefix = '/assets/cards'
        filename = parts[0]
    # if exact file exists
    if filename in assets:
        continue
    # try exact lower match
    candidates = lower_map.get(filename.lower())
    candidate = None
    if candidates:
        candidate = candidates[0]
    else:
        # try normalized map
        candidate = None
        norm_key = filename.replace('-', '_').lower()
        cand_list = norm_map.get(norm_key)
        if cand_list:
            candidate = cand_list[0]
        else:
            # try replacing underscores/hyphens other way
            norm_key2 = filename.replace('_', '-').lower()
            cand_list2 = norm_map.get(norm_key2)
            if cand_list2:
                candidate = cand_list2[0]
            else:
                # try matching by removing case differences but keep only alnum and dot
                import re
                def normalize(s):
                    return re.sub(r'[^a-z0-9.]', '', s.lower())
                norm_f = normalize(filename)
                found = None
                for f in assets:
                    if normalize(f) == norm_f:
                        found = f
                        break
                if found:
                    candidate = found
    if candidate:
        new_path = f"/assets/cards/{candidate}"
        if new_path != img:
            entry['image'] = new_path
            changed += 1
            matched_details.append((img, new_path))
    else:
        unmatched.append(img)

# backup
backup_path.write_text(json.dumps(data, ensure_ascii=False, indent=2), encoding='utf-8')

# write updated json
json_path.write_text(json.dumps(data, ensure_ascii=False, indent=2), encoding='utf-8')

print(f'Assets scanned: {len(assets)}')
print(f'JSON entries processed: {len(data)}')
print(f'Updated image paths: {changed}')
if matched_details:
    print('\nSample updates:')
    for old, new in matched_details[:20]:
        print(f'  {old} -> {new}')
if unmatched:
    print(f'Unmatched image paths: {len(unmatched)} (showing up to 20)')
    for u in unmatched[:20]:
        print('  ', u)
else:
    print('All image paths matched to files.')

print('Backup written to', backup_path)

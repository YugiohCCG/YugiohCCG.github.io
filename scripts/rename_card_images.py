import json
from pathlib import Path

cards_path = Path(r"c:\Applications\YugiohCCG.github.io\src\data\cards.json")
backup_path = cards_path.with_suffix('.json.bak')

with cards_path.open('r', encoding='utf-8') as f:
    data = json.load(f)

# find start index
start_idx = None
for i, entry in enumerate(data):
    if entry.get('name') == 'SCARSTECH CRUSADER':
        start_idx = i
        break

if start_idx is None:
    print('Start entry "SCARSTECH CRUSADER" not found. No changes made.')
    raise SystemExit(1)

# backup
backup_path.write_text(json.dumps(data, ensure_ascii=False, indent=2), encoding='utf-8')

# function to transform basename: lowercase then capitalize first char

def transform_basename(basename: str) -> str:
    if not basename:
        return basename
    lower = basename.lower()
    return lower[0].upper() + lower[1:]

changed = 0
for entry in data[start_idx:]:
    img = entry.get('image')
    if not isinstance(img, str):
        continue
    # expect path like /assets/cards/NAME.EXT
    parts = img.rsplit('/', 1)
    if len(parts) != 2:
        continue
    prefix, filename = parts
    if '.' not in filename:
        continue
    basename, ext = filename.rsplit('.', 1)
    # transform only if basename is uppercase (heuristic) or contains any uppercase letters
    if any(c.isalpha() and c.isupper() for c in basename):
        new_basename = transform_basename(basename)
        new_filename = f"{new_basename}.{ext.lower()}"
        new_path = f"{prefix}/{new_filename}"
        if new_path != img:
            entry['image'] = new_path
            changed += 1

with cards_path.open('w', encoding='utf-8') as f:
    json.dump(data, f, ensure_ascii=False, indent=2)

print(f'Processed {len(data)-start_idx} entries starting at index {start_idx}.')
print(f'Updated image paths: {changed}')
print(f'Backup written to: {backup_path}')

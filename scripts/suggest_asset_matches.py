import os
import json
import difflib
from pathlib import Path

json_path = Path(r"c:\Applications\YugiohCCG.github.io\src\data\cards.json")
assets_dir = Path(r"c:\Applications\YugiohCCG.github.io\public\assets\cards")

assets = [f for f in os.listdir(assets_dir) if os.path.isfile(assets_dir / f)]
assets_lower = [f.lower() for f in assets]

with json_path.open('r', encoding='utf-8') as fh:
    data = json.load(fh)

unmatched = {}
for entry in data:
    img = entry.get('image')
    if not isinstance(img, str):
        continue
    filename = img.rsplit('/',1)[-1]
    if filename not in assets:
        # find close matches
        matches = difflib.get_close_matches(filename.lower(), assets_lower, n=5, cutoff=0.5)
        # convert back to original-cased names
        matches = [assets[assets_lower.index(m)] for m in matches]
        if matches:
            unmatched[img] = matches
        else:
            # also try normalized alnum compare
            import re
            norm = re.sub(r'[^a-z0-9.]','', filename.lower())
            best = []
            for f in assets:
                if norm in re.sub(r'[^a-z0-9.]','', f.lower()):
                    best.append(f)
            unmatched[img] = best[:5]

print('Unmatched entries with suggestions:')
for k,v in unmatched.items():
    print('\n', k)
    if v:
        for m in v:
            print('   ', m)
    else:
        print('   No suggestions')

print('\nTotal unmatched:', len(unmatched))

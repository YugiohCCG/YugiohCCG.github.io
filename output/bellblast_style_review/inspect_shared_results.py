import collections
import hashlib
import io
import json
import zipfile
import sys
from pathlib import Path
from PIL import Image, ImageDraw, ImageFont

HERE = Path(__file__).resolve().parent / (sys.argv[2] if len(sys.argv) > 2 else 'shared_results')
HERE.mkdir(exist_ok=True)
ARCHIVE = Path(sys.argv[1]) if len(sys.argv) > 1 else Path(r'C:\Users\hclar\Downloads\Untitled Folder.zip')
records = []
with zipfile.ZipFile(ARCHIVE) as z:
    names = sorted(n for n in z.namelist() if n.lower().endswith('.png'))
    for name in names:
        raw = z.read(name)
        path = HERE / Path(name).name
        path.write_bytes(raw)
        with Image.open(io.BytesIO(raw)) as im:
            g = json.loads(im.info.get('prompt', '{}'))
            wf = json.loads(im.info.get('workflow', '{}'))
            rec = {'file': path.name, 'size': list(im.size), 'mode': im.mode, 'nodes': {}}
            for key, node in g.items():
                cls = node['class_type']
                if any(s in cls.lower() for s in ['encode','sampl','guid','noise','decode','vae','clip','lora','switch','resolution','seed']):
                    rec['nodes'][key] = node
            rec['text_inputs'] = {}
            for key, node in g.items():
                s = node.get('inputs',{}).get('value')
                if isinstance(s, str) and 'high_level_description' in s and not s.startswith('[META]'):
                    item = {'repr_start': repr(s[:100]), 'text': s}
                    try:
                        p = json.loads(s)
                        item['json_type'] = type(p).__name__
                        item['summary'] = p.get('high_level_description') if isinstance(p,dict) else None
                    except Exception as e:
                        item['json_error'] = str(e)
                    rec['text_inputs'][key] = item
            (HERE / (path.stem + '.graph.json')).write_text(json.dumps(g,indent=2,ensure_ascii=False),encoding='utf-8')
            (HERE / (path.stem + '.workflow.json')).write_text(json.dumps(wf,indent=2,ensure_ascii=False),encoding='utf-8')
            records.append(rec)
font = ImageFont.truetype('C:/Windows/Fonts/arial.ttf', 21)
for offset in range(0,len(records),10):
    sheet=Image.new('RGB',(1800,780),'#F2F0ED')
    draw=ImageDraw.Draw(sheet)
    for j,r in enumerate(records[offset:offset+10]):
        x,y=(j%5)*360,(j//5)*390
        with Image.open(HERE/r['file']) as im:
            thumb=im.convert('RGB').resize((352,352),Image.Resampling.LANCZOS)
        sheet.paste(thumb,(x+4,y+4))
        draw.text((x+8,y+360),r['file'],font=font,fill='#151B25')
    sheet.save(HERE/f'results_{offset+1:02d}_{min(offset+10,len(records)):02d}.jpg',quality=94)
(HERE/'metadata_audit.json').write_text(json.dumps(records,indent=2,ensure_ascii=False),encoding='utf-8')
for r in records:
    texts = [{k:v for k,v in t.items() if k!='text'} for t in r['text_inputs'].values()]
    print(json.dumps({'file':r['file'],'text_inputs':texts},ensure_ascii=False))
print('LAST GRAPH SETTINGS:')
print(json.dumps(records[-1]['nodes'],indent=2,ensure_ascii=False))

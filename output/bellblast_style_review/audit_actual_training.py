import collections, hashlib, json, struct
from pathlib import Path
from PIL import Image, ImageDraw, ImageFont

ROOT=Path(r'C:\Manual Files\New Documents\Yugioh\Models')
DATA=ROOT/'yugioh_ideogram4_500_release'/'training'
OUT=Path(__file__).resolve().parent/'actual_training'
OUT.mkdir(exist_ok=True)
paths=sorted(DATA.glob('*.png'))
hashes=collections.defaultdict(list)
modes=collections.Counter()
styles=collections.Counter()
elements=collections.Counter()
captions=[]
old=Path(__file__).resolve().parent.parent/'yugioh_ideogram4_500'/'images'
same=[]
different=[]
font=ImageFont.truetype('C:/Windows/Fonts/arial.ttf',16)
for offset in range(0,len(paths),25):
    sheet=Image.new('RGB',(1280,1400),'#FFFFFF')
    draw=ImageDraw.Draw(sheet)
    for j,p in enumerate(paths[offset:offset+25]):
        with Image.open(p) as im:
            im.load()
            modes[im.mode]+=1
            h=hashlib.sha256(im.convert('RGB').tobytes()).hexdigest()
            hashes[h].append(p.stem)
            thumb=im.convert('RGB').resize((250,250),Image.Resampling.LANCZOS)
        if (old/p.name).exists():
            with Image.open(old/p.name) as prior:
                ph=hashlib.sha256(prior.convert('RGB').tobytes()).hexdigest()
            (same if h==ph else different).append(p.stem)
        cp=p.with_suffix('.json')
        cap=json.loads(cp.read_text(encoding='utf-8'))
        captions.append({'id':p.stem,'caption':cap})
        styles[cap.get('style_description',{}).get('art_style','MISSING')]+=1
        elements[len(cap.get('compositional_deconstruction',{}).get('elements',[]))]+=1
        x,y=(j%5)*256,(j//5)*280
        sheet.paste(thumb,(x+3,y+3))
        draw.text((x+5,y+255),p.stem,font=font,fill='black')
    sheet.save(OUT/f'training_{offset+1:03d}_{min(offset+25,len(paths)):03d}.jpg',quality=93)
stats={'training_path':str(DATA),'images':len(paths),'json_captions':len(list(DATA.glob('*.json'))),'image_modes':dict(modes),'unique_rgb_images':len(hashes),'exact_duplicate_groups':[v for v in hashes.values() if len(v)>1],'same_as_old_copy':len(same),'different_from_old_copy':len(different),'different_ids':different,'art_styles':dict(styles),'element_counts':dict(elements)}
(OUT/'audit.json').write_text(json.dumps(stats,indent=2),encoding='utf-8')
(OUT/'captions.json').write_text(json.dumps(captions,indent=2,ensure_ascii=False),encoding='utf-8')
checkpoint=ROOT/'Ideogram 4'/'Ideogram4_Yugioh_hclar52_r32_v1_000003500.safetensors'
with checkpoint.open('rb') as f:
    length=struct.unpack('<Q',f.read(8))[0]
    header=json.loads(f.read(length))
meta=header.get('__metadata__',{})
(OUT/'checkpoint_metadata.json').write_text(json.dumps(meta,indent=2,ensure_ascii=False),encoding='utf-8')
print(json.dumps({k:v for k,v in stats.items() if k not in ['art_styles','different_ids']},indent=2))
print('MOST COMMON ART STYLES:', styles.most_common(8))
print('CHECKPOINT METADATA:',str(meta)[:7000])

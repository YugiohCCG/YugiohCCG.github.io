import json
from pathlib import Path
from PIL import Image,ImageDraw,ImageFont
HERE=Path(__file__).resolve().parent/'actual_training'
DATA=Path(r'C:\Manual Files\New Documents\Yugioh\Models\yugioh_ideogram4_500_release\training')
ids=json.loads((HERE/'audit.json').read_text())['different_ids']
font=ImageFont.truetype('C:/Windows/Fonts/arial.ttf',16)
for offset in range(0,len(ids),25):
    chunk=ids[offset:offset+25]
    sheet=Image.new('RGB',(1280,280*((len(chunk)+4)//5)),'white')
    d=ImageDraw.Draw(sheet)
    for j,id in enumerate(chunk):
        x,y=(j%5)*256,(j//5)*280
        with Image.open(DATA/(id+'.png')) as im:
            sheet.paste(im.convert('RGB').resize((250,250),Image.Resampling.LANCZOS),(x+3,y+3))
        d.text((x+5,y+255),id,font=font,fill='black')
    sheet.save(HERE/f'changed_{offset+1:02d}_{offset+len(chunk):02d}.jpg',quality=94)

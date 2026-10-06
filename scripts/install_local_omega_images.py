"""Install missing local Omega Pics/Arts for the pinned CCG roster."""
import hashlib,io,json,os,subprocess
from concurrent.futures import ThreadPoolExecutor
from pathlib import Path
from PIL import Image
from card_art_crop import crop_card_art
ROOT=Path(__file__).resolve().parents[1]
OUT=ROOT/'output/fresh-ccg-september'
FILES=Path(r'C:\Program Files (x86)\YGO Omega\YGO Omega_Data\Files')
def sha(data):return hashlib.sha256(data).hexdigest()
def main():
 baseline=json.loads((OUT/'baseline-remote.json').read_text(encoding='utf-8'))
 original=json.loads((OUT/'local-omega-missing-images.json').read_text(encoding='utf-8'));original_ids={c['passcode'] for c in original}
 missing=[c for c in baseline['cards'] if c['passcode'] in original_ids or any(not (FILES/folder/f"{c['passcode']}.jpg").exists() for folder in ('Pics','Arts'))]
 def prepare(card):
  code=card['passcode'];image=card['specification']['image'];assert image.startswith('/assets/cards/')
  source=ROOT/'public'/image.lstrip('/');assert source.resolve().is_relative_to((ROOT/'public/assets/cards').resolve())
  if source.exists():data=source.read_bytes();origin=str(source)
  else:
   ref=baseline['source_revision']+':public'+image
   data=subprocess.check_output(['git','show',ref],cwd=ROOT,stderr=subprocess.PIPE);origin=ref
  with Image.open(io.BytesIO(data)) as img:
   full=img.convert('RGB');art=crop_card_art(img);full_size=full.size
   payloads={}
   for folder,picture in [('Pics',full),('Arts',art)]:
    buf=io.BytesIO();picture.save(buf,format='JPEG',quality=92,optimize=True);payloads[folder]=buf.getvalue()
  return card,origin,sha(data),full_size,payloads
 results=[];errors=[]
 def safe_prepare(card):
  try:return prepare(card)
  except Exception as e:return {'passcode':card['passcode'],'name':card['name'],'error':str(e)}
 with ThreadPoolExecutor(max_workers=4) as pool:
  for prepared in pool.map(safe_prepare,missing):
   if isinstance(prepared,dict):errors.append(prepared);continue
   card,origin,source_hash,size,payloads=prepared
   for folder,data in payloads.items():
    dest=FILES/folder/f"{card['passcode']}.jpg"
    created=not dest.exists()
    temp=dest.with_name(dest.name+'.ccg-image-tmp');
    if created:temp.write_bytes(data);os.replace(temp,dest)
    with Image.open(dest) as check:check.verify()
    assert sha(dest.read_bytes())==sha(data)
    results.append({'passcode':card['passcode'],'name':card['name'],'folder':folder,'file':str(dest),'source':origin,'source_sha256':source_hash,'installed_sha256':sha(data),'source_dimensions':size,'created_this_run':created})
   if len(results)%20==0:print('Verified',len(results),'image files',flush=True)
 missing_after=[];invalid=[]
 for card in baseline['cards']:
  for folder in ('Pics','Arts'):
   p=FILES/folder/f"{card['passcode']}.jpg"
   if not p.exists():missing_after.append(str(p));continue
   try:
    with Image.open(p) as check:check.verify()
   except Exception as e:invalid.append({'file':str(p),'error':str(e)})
 report={'scope':'Local full-card Pics and cropped Arts installation; no in-game display certification','source_revision':baseline['source_revision'],'roster_cards':len(baseline['cards']),'cards_verified':len({r['passcode'] for r in results}),'files_verified':len(results),'files_installed_this_run':sum(r['created_this_run'] for r in results),'source_errors':errors,'missing_after':missing_after,'invalid_images':invalid,'results':results}
 (OUT/'local-omega-image-install.json').write_text(json.dumps(report,indent=2)+'\n',encoding='utf-8')
 print(json.dumps({k:v for k,v in report.items() if k!='results'},indent=2));assert not missing_after and not invalid
if __name__=='__main__':main()

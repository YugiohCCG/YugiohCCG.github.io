"""Import supplied Ohmen artwork into native card frames and Omega packages."""
import json, shutil, subprocess, zipfile, sqlite3, hashlib
from pathlib import Path
ROOT = Path(__file__).resolve().parents[1]
SOURCE = Path(r'C:\Manual Files\Yu Gi Oh\CCG Archtypes\Ohmen\Final')
OMEGA = Path(r'C:\Program Files (x86)\YGO Omega\YGO Omega_Data\Files')
OUT = ROOT / 'output/ohmen-art-update-20261014'
OUT.mkdir(parents=True, exist_ok=True)
cards = json.loads((ROOT/'src/data/cards.json').read_text(encoding='utf-8'))
cards = [c for c in cards if 'Ohmen' in c['name'] or 'Ohmechanic' in c['name']]
assert len(cards) == 15
jobs=[]
for c in cards:
    name = 'Siemens, the Ohmechanic' if c['name']=='Siemens, the Ohmechanic Conductor' else c['name']
    source=SOURCE/(name+'.png'); assert source.exists(), source
    target=ROOT/'public'/c['image'].split('?')[0].lstrip('/')
    backup=OUT/'before'/target.relative_to(ROOT)
    backup.parent.mkdir(parents=True,exist_ok=True)
    if not backup.exists(): shutil.copy2(target,backup)
    jobs.append(dict(source=str(source),target=str(target),link='Ohmechanic' in name,id=c['passcode']))
(OUT/'jobs.json').write_text(json.dumps(jobs),encoding='utf-8')
# Deterministic card-frame renderer: the supplied artwork is inserted into the
# original frame, with the Link arrow corners excluded from the drawing region.
ps=r'''
Add-Type -AssemblyName System.Drawing
$jobs = Get-Content -LiteralPath $args[0] -Raw | ConvertFrom-Json
foreach ($job in $jobs) {
  $frame = [System.Drawing.Bitmap]::new($job.target)
  $art = [System.Drawing.Image]::FromFile($job.source)
  $g = [System.Drawing.Graphics]::FromImage($frame)
  $g.InterpolationMode = [System.Drawing.Drawing2D.InterpolationMode]::HighQualityBicubic
  $path = [System.Drawing.Drawing2D.GraphicsPath]::new()
  if ($job.link) {
    $pts = [System.Drawing.Point[]]@([System.Drawing.Point]::new(114,219),[System.Drawing.Point]::new(700,219),[System.Drawing.Point]::new(714,233),[System.Drawing.Point]::new(714,818),[System.Drawing.Point]::new(700,832),[System.Drawing.Point]::new(114,832),[System.Drawing.Point]::new(100,818),[System.Drawing.Point]::new(100,233))
    $path.AddPolygon($pts)
  } else { $path.AddRectangle([System.Drawing.Rectangle]::new(100,219,614,613)) }
  $g.SetClip($path)
  $g.DrawImage($art,[System.Drawing.Rectangle]::new(100,219,614,613))
  $g.Dispose(); $art.Dispose(); $path.Dispose()
  $tmp = $job.target + '.new'
  if ([System.IO.Path]::GetExtension($job.target) -eq '.png') { $frame.Save($tmp,[System.Drawing.Imaging.ImageFormat]::Png) }
  else {
    $codec = [System.Drawing.Imaging.ImageCodecInfo]::GetImageEncoders() | Where-Object MimeType -eq 'image/jpeg'
    $params = [System.Drawing.Imaging.EncoderParameters]::new(1)
    $params.Param[0] = [System.Drawing.Imaging.EncoderParameter]::new([System.Drawing.Imaging.Encoder]::Quality,[long]100)
    $frame.Save($tmp,$codec,$params); $params.Dispose()
  }
  $frame.Dispose()
  Move-Item -LiteralPath $tmp -Destination $job.target -Force
}
'''
(OUT/'render.ps1').write_text(ps,encoding='utf-8')
subprocess.run(['powershell','-NoProfile','-File',str(OUT/'render.ps1'),str(OUT/'jobs.json')],check=True)
from PIL import Image
import sys
sys.path.insert(0,str(ROOT/'scripts'))
from export_omega_ccg_holograms import build_hologram
db=sqlite3.connect(OMEGA/'Databases/CCG_v1.db')
replacements={}
for c,j in zip(cards,jobs):
    ids={int(c['passcode'])} | {r[0] for r in db.execute('select id from texts where name=?',(c['name'],))}
    for code in ids:
        for folder,ext in [('Arts','jpg'),('Pics','jpg'),('Holograms','png')]:
            dest=OMEGA/folder/f'{code}.{ext}'
            backup=OUT/'before/Omega'/folder/dest.name
            backup.parent.mkdir(parents=True,exist_ok=True)
            if dest.exists() and not backup.exists(): shutil.copy2(dest,backup)
            dest.parent.mkdir(parents=True,exist_ok=True)
            with Image.open(j['source'] if folder!='Pics' else j['target']) as im:
                if folder=='Holograms': build_hologram(im).save(dest)
                elif folder=='Arts': im.convert('RGB').resize((624,624),Image.Resampling.LANCZOS).save(dest,quality=95)
                else: im.convert('RGB').save(dest,quality=95)
            replacements[(folder,dest.name)] = dest
db.close()
packages=[]
for archive in (ROOT/'public/CCG Downloads').rglob('*.zip'):
    changed=0
    with zipfile.ZipFile(archive) as z:
        entries=[]
        for item in z.infolist():
            folder = 'Holograms' if 'Hologram' in archive.name else 'Pics' if 'Pics' in archive.name else 'Arts' if 'Arts' in archive.name or archive.name=='YGO_Omega_Images_v1.zip' else None
            parts=item.filename.replace('\\','/').split('/')
            folder=next((p for p in parts if p in ('Arts','Pics','Holograms')),folder)
            replacement=replacements.get((folder,parts[-1]))
            entries.append((item,replacement.read_bytes() if replacement else z.read(item)))
            changed += bool(replacement)
    if changed:
        backup=OUT/'before'/archive.relative_to(ROOT);backup.parent.mkdir(parents=True,exist_ok=True)
        if not backup.exists():shutil.copy2(archive,backup)
        temp=archive.with_suffix('.zip.new')
        with zipfile.ZipFile(temp,'w') as z:
            for item,data in entries:z.writestr(item,data)
        temp.replace(archive)
        packages.append(dict(path=str(archive.relative_to(ROOT)),entries=changed))
(OUT/'manifest.json').write_text(json.dumps({'cards':jobs,'packages':packages,'omegaImages':len(replacements)},indent=2),encoding='utf-8')
print(json.dumps({'cards':len(jobs),'omegaImages':len(replacements),'packages':packages},indent=2))

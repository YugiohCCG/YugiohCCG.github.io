"""Prepare the Pages build while retaining all release archives in the repository."""
from pathlib import Path
import json
import shutil

ROOT=Path(__file__).resolve().parents[1]
MAX_PAGES_BYTES=1_000_000_000

def prepare_pages_payload(dist: Path, manifest: dict) -> tuple[int,int]:
    dist=dist.resolve()
    published={row['path'] for row in manifest['files']}
    external={row['path'] for row in manifest['files'] if row.get('url')}
    removed=0
    for path in (dist/'CCG Downloads').rglob('YGO_Omega_*.zip'):
        relative=path.relative_to(dist).as_posix()
        if relative in external or relative not in published:
            if not path.resolve().is_relative_to(dist):
                raise ValueError('Archive is outside the Pages build')
            path.unlink()
            removed+=1
    shutil.copyfile(dist/'index.html',dist/'404.html')
    size=sum(path.stat().st_size for path in dist.rglob('*') if path.is_file())
    if size>MAX_PAGES_BYTES:
        raise ValueError(f'Pages build exceeds 1 GB: {size} bytes')
    return removed,size

if __name__=='__main__':
    manifest=json.loads((ROOT/'public/data/release-manifest.json').read_text(encoding='utf8'))
    removed,size=prepare_pages_payload(ROOT/'dist',manifest)
    print(f'Pages build: {size:,} bytes; {removed} external or duplicate archives excluded')

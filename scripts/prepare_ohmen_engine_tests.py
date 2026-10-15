"""Prepare checksum-pinned Omega Lua helpers and the isolated WASM transport adapter."""
from pathlib import Path
import argparse,hashlib,json,subprocess,sys,urllib.request
ROOT=Path(__file__).resolve().parents[1]
def main():
 parser=argparse.ArgumentParser(description=__doc__);parser.add_argument('--download',action='store_true');args=parser.parse_args()
 meta=json.loads((ROOT/'scripts/data/ohmen_lua_runtime.json').read_text('utf8'));dest=ROOT/'tmp/ohmen-reference';dest.mkdir(parents=True,exist_ok=True)
 for name,info in meta['files'].items():
  p=dest/name;data=p.read_bytes().replace(b'\r\n',b'\n') if p.exists() else b''
  if hashlib.sha256(data).hexdigest()!=info['sha256_lf']:
   if not args.download:raise SystemExit('Missing or incorrect Lua reference '+name+'; run with --download')
   data=urllib.request.urlopen(urllib.request.Request(info['url'],headers={'User-Agent':'Ohmen Lua regression tests'}),timeout=40).read().replace(b'\r\n',b'\n')
   if hashlib.sha256(data).hexdigest()!=info['sha256_lf']:raise SystemExit('Lua reference checksum mismatch: '+name)
   p.write_bytes(data)
 (ROOT/'output/fresh-ccg-september').mkdir(parents=True,exist_ok=True)
 subprocess.run([sys.executable,str(ROOT/'scripts/fresh_public_card_data_adapter.py')],cwd=ROOT,check=True)
 print('Verified three pinned Omega helpers; generated isolated card-data transport adapter. Production runtime unchanged.')
if __name__=='__main__':main()

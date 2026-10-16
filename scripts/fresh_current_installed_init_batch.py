"""Freeze full-roster initialization against the actual installed metadata."""
import hashlib,json,os,subprocess
from pathlib import Path
ROOT=Path(__file__).resolve().parents[1];OUT=ROOT/'output/fresh-ccg-september'
DB=Path(r'C:\Program Files (x86)\YGO Omega\YGO Omega_Data\Files\Databases\CCG_v1.db')
def sha(p):return hashlib.sha256(p.read_bytes()).hexdigest()
prior=json.loads((OUT/'current-installed-metadata-init.json').read_text())
paths={DB,ROOT/'src/data/cards.json',ROOT/'scripts/fresh_installed_metadata_init.cjs',ROOT/'scripts/fresh_installed_card.cjs',OUT/'baseline-remote.json',Path(__file__).resolve()}|set((ROOT/'public/CCG Downloads/CCG_Scripts').glob('*.lua'))|set((ROOT/'node_modules/@n1xx1/ocgcore-wasm/dist').glob('*.js'))
for row in prior['results']:
 for name in row['loaded_scripts']:
  if name in {'c0.lua','c900019999.lua'}:continue
  p=next((p for p in [ROOT/'public/CCG Downloads/CCG_Scripts'/name,ROOT/'tmp/omega_scripts'/name] if p.is_file()),None)
  assert p,name
  paths.add(p)
before={str(p.resolve()):sha(p) for p in paths};env=os.environ.copy()
for key in ['CCG_LOAD_CODES','CCG_LOAD_LIMIT','CCG_LOAD_OFFSET']:env.pop(key,None)
r=subprocess.run(['node','--no-warnings','scripts/fresh_installed_metadata_init.cjs'],cwd=ROOT,env=env,capture_output=True,text=True,timeout=45)
p=OUT/'current-installed-metadata-init.json';d=json.loads(p.read_text());assert len(d['results'])==711
assert before=={str(p.resolve()):sha(p) for p in paths}
failed=[x for x in d['results'] if x['status']!='first_decision_pass'];old=json.loads((OUT/'current-roster-engine-load.json').read_text())
newids={x['passcode'] for x in failed};oldids={x['passcode'] for x in old['results'] if x['status']!='first_decision_pass'}
assert newids==oldids,(newids-oldids,oldids-newids)
assert r.returncode==1 and len(failed)==128
(OUT/'current-installed-metadata-init-batch.json').write_text(json.dumps({'scope':'All711 current source scripts and actual installed DB, public core initialization/firstdecision only; not effect/nativeOmega/fullcard certification','total':711,'passed':711-len(failed),'failed':len(failed),'same_historical_failure_ids':True,'raw_artifact':p.name,'raw_sha256':sha(p),'dependencies_sha256':before},indent=2)+'\n',encoding='utf8')
print('Current installed metadata:711 checked,583 firstdecision pass,128 same legacy compatibility failures; all inputs unchanged')

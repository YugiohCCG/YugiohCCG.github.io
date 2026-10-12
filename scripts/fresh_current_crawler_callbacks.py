import hashlib,json,subprocess,shutil
from pathlib import Path
ROOT=Path(__file__).resolve().parents[1];OUT=ROOT/'output/fresh-ccg-september'
def sha(p):return hashlib.sha256(p.read_bytes()).hexdigest()
paths=[Path(__file__),ROOT/'scripts/fresh_current_crawler_callbacks.lua',ROOT/'public/CCG Downloads/CCG_Scripts/c213611313.lua',ROOT/'tmp/omega_scripts/constant.lua',Path(shutil.which('lua'))]
before={str(p):sha(p) for p in paths};runs=[]
for control,expected in [(None,None),('no-chain-flag','Legacy chain count flag'),('low-threshold','Exact Chain Link5 threshold')]:
 result=subprocess.run(['lua','scripts/fresh_current_crawler_callbacks.lua']+(['--'+control] if control else []),cwd=ROOT,capture_output=True,text=True)
 assert result.returncode==(1 if control else 0)
 if control:assert expected in result.stderr
 else:assert result.stdout.strip()=='PASS 18 bounded Crawler assertions'
 runs.append({'control':control,'stdout':result.stdout,'stderr':result.stderr})
assert before=={str(p):sha(p) for p in paths}
(OUT/'crawler-callback-validation.json').write_text(json.dumps({'scope':'Mock Effect/Card boundaries; canonical legacy chain registration/threshold and300ATK callback only. Not actual chaining, revival, once-per-chain enforcement or native Omega.','assertions':18,'dependencies_sha256':before,'runs':runs},indent=2)+'\n')
print('18 bounded Crawler assertions and two controls verified')

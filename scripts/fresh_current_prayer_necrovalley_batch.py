import hashlib,json,subprocess
from pathlib import Path
ROOT=Path(__file__).resolve().parents[1];OUT=ROOT/'output/fresh-ccg-september'
def sha(p):return hashlib.sha256(p.read_bytes()).hexdigest()
paths=[Path(__file__),ROOT/'scripts/fresh_current_prayer_necrovalley_main.cjs',ROOT/'scripts/fresh_current_prayer_necrovalley_search.cjs',ROOT/'scripts/fresh_current_card.cjs',ROOT/'public/CCG Downloads/CCG_Scripts/c238276252.lua',OUT/'current-spec-CCG_v1.db']+[ROOT/'tmp/omega_scripts'/n for n in ['constant.lua','utility.lua','procedure.lua','c47355498.lua']]+list((ROOT/'node_modules/@n1xx1/ocgcore-wasm/dist').glob('*.js'))
before={p.relative_to(ROOT).as_posix():sha(p) for p in paths};runs=[]
for profile,control,bad,count in [('main','ignore-valley-filter',{'valleyGrave':True},3),('search','no-valley-banish-ban',{'valley':True},2)]:
 for mutation in [None,control]:
  r=subprocess.run(['node','--no-warnings',f'scripts/fresh_current_prayer_necrovalley_{profile}.cjs']+(['--'+mutation] if mutation else []),cwd=ROOT,capture_output=True,text=True,timeout=30)
  p=OUT/(f'current-prayer-necrovalley-{profile}'+('-'+mutation if mutation else '')+'.json');d=json.loads(p.read_text());expected=[bad] if mutation else []
  assert r.returncode==(1 if mutation else 0),r.stdout+r.stderr
  assert len(d['results'])==count and [x['test'] for x in d['results'] if x['failure']]==expected
  runs.append({'profile':profile,'control':mutation,'expected_failures':expected,'artifact':p.name,'artifact_sha256':sha(p),'scope':d['scope']})
assert before=={p.relative_to(ROOT).as_posix():sha(p) for p in paths}
(OUT/'current-prayer-necrovalley-batch.json').write_text(json.dumps({'scope':'Five canonical full-source Prayer scenarios versus full pinned Necrovalley; no production repair or compatibility adapter. Initial Field Spell/Ritual fixtures; native Omega/late timing/immunity open.','baseline_cases':5,'runtime_dependencies_sha256':before,'runs':runs},indent=2)+'\n')
print('Prayer five native Necrovalley cases and two controls verified')

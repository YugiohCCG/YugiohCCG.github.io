import hashlib,json,subprocess
from pathlib import Path
ROOT=Path.cwd();OUT=ROOT/'output/fresh-ccg-september'
def sha(p):return hashlib.sha256(p.read_bytes()).hexdigest()
paths=[Path(__file__).resolve(),ROOT/'scripts/fresh_current_aldrez_blitz_revival_token.cjs',ROOT/'scripts/fresh_current_card.cjs',ROOT/'public/CCG Downloads/CCG_Scripts/c217700538.lua',OUT/'current-spec-CCG_v1.db']+[ROOT/'tmp/omega_scripts'/n for n in ['constant.lua','utility.lua','procedure.lua']]+list((ROOT/'node_modules/@n1xx1/ocgcore-wasm/dist').glob('*.js'))
before={p.relative_to(ROOT).as_posix():sha(p) for p in paths};runs=[]
for control,expected in [(None,[]),('no-summon',[0,1,2,3,10,11]),('no-token',[0,1]),('ignore-set',[5]),('allow-level5',[4])]:
 result=subprocess.run(['node','--no-warnings','scripts/fresh_current_aldrez_blitz_revival_token.cjs']+(['--'+control] if control else []),capture_output=True,text=True,timeout=30);p=OUT/('current-aldrez-blitz-revival-token'+('-'+control if control else '')+'.json');d=json.loads(p.read_text(encoding='utf-8'));assert result.returncode==(1 if expected else 0),result.stdout+result.stderr;assert len(d['results'])==12;assert [i for i,v in enumerate(d['results']) if v['failure']]==expected,(control,result.stdout);assert d['adapter'] is None and all(not v['logs'] for v in d['results']);runs.append({'control':control,'expected_failures':expected,'artifact':p.name,'artifact_sha256':sha(p)})
assert before=={p.relative_to(ROOT).as_posix():sha(p) for p in paths};assert paths[3].read_bytes()==Path(r'C:\Program Files (x86)\YGO Omega\YGO Omega_Data\Files\Scripts\c217700538.lua').read_bytes()
(OUT/'current-aldrez-blitz-revival-token-batch.json').write_text(json.dumps({'status':'VERIFIED_PARTIAL_PRODUCTION','baseline_cases':12,'runtime_dependencies_sha256':before,'runs':runs,'scope':d['scope']},indent=2)+'\n',encoding='utf-8');print('Aldrez Blitz12cases4controls verified; no adapters, source unchanged.')

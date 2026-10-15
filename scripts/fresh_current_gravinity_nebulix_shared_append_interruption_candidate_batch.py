import hashlib,json,subprocess
from pathlib import Path
ROOT=Path.cwd();OUT=ROOT/'output/fresh-ccg-september'
def sha(p):return hashlib.sha256(p.read_bytes()).hexdigest()
paths=[ROOT/'scripts/fresh_current_gravinity_nebulix_append_candidate.lua',ROOT/'scripts/fresh_current_gravinity_nebulix_shared_append_interruption_candidate.cjs',Path('scripts/fresh_current_gravinity_nebulix_shared_append_interruption_candidate_batch.py').resolve(),ROOT/'scripts/fresh_current_card.cjs',ROOT/'public/CCG Downloads/CCG_Scripts/c212429024.lua',OUT/'current-spec-CCG_v1.db']+[ROOT/'tmp/omega_scripts'/n for n in ['constant.lua','utility.lua','procedure.lua']]+list((ROOT/'node_modules/@n1xx1/ocgcore-wasm/dist').glob('*.js'))
assert (ROOT/'public/CCG Downloads/CCG_Scripts/c212429024.lua').read_bytes()==Path(r'C:\Program Files (x86)\YGO Omega\YGO Omega_Data\Files\Scripts\c212429024.lua').read_bytes()
before={p.relative_to(ROOT).as_posix():sha(p) for p in paths};runs=[]
for control,expected in [(None,[]),('no-append',[2]),('no-original',[0,4]),('no-response',[1,2,3,4])]:
 r=subprocess.run(['node','--no-warnings','scripts/fresh_current_gravinity_nebulix_shared_append_interruption_candidate.cjs']+(['--'+control] if control else []),capture_output=True,text=True,timeout=30)
 p=OUT/('current-gravinity-nebulix-shared-append-interruption-candidate'+('-'+control if control else '')+'.json');data=json.loads(p.read_text())
 assert r.returncode==(1 if expected else 0),r.stdout+r.stderr
 assert [i for i,v in enumerate(data['results']) if v['failure']]==expected,(control,r.stdout)
 assert all(not v['logs'] for v in data['results'])
 runs.append({'control':control,'expected_failures':expected,'artifact':p.name,'artifact_sha256':sha(p)})
assert before=={p.relative_to(ROOT).as_posix():sha(p) for p in paths}
(OUT/'current-gravinity-nebulix-shared-append-interruption-candidate-batch.json').write_text(json.dumps({'scope':data['scope'],'baseline_cases':5,'runtime_dependencies_sha256':before,'runs':runs},indent=2)+'\n')
print('Nebulix addition: five append interruption candidate cases/three controls verified.')

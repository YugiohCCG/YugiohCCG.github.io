"""Bounded current-data Onibi regression with causal controls."""
import hashlib,json,subprocess
from pathlib import Path
ROOT=Path(__file__).resolve().parents[1];OUT=ROOT/'output/fresh-ccg-september'
def sha(p):return hashlib.sha256(p.read_bytes()).hexdigest()
deps=[Path(__file__),ROOT/'scripts/fresh_current_onibi.cjs',ROOT/'scripts/fresh_current_card.cjs',ROOT/'public/CCG Downloads/CCG_Scripts/c217713649.lua',OUT/'current-spec-CCG_v1.db',OUT/'public-core-card-data-adapter.mjs']
deps+=list((ROOT/'node_modules/@n1xx1/ocgcore-wasm/dist').glob('*.js'))
deps+=[ROOT/'tmp/omega_scripts'/n for n in ['constant.lua','utility.lua','procedure.lua']]
before={p.relative_to(ROOT).as_posix():sha(p) for p in deps};runs=[]
for control,expected in [(None,[]),('no-search',[{}, {'declineSearch':True}]),('no-limit',[{}, {'declineSearch':True},{'wrongDeckType':True}]),('no-return',[{}, {'declineSearch':True},{'wrongDeckType':True}])]:
 result=subprocess.run(['node','--no-warnings','scripts/fresh_current_onibi.cjs']+(['--'+control] if control else []),cwd=ROOT,capture_output=True,text=True,timeout=40)
 artifact=OUT/'current-data'/('onibi'+('-'+control if control else '')+'.json');data=json.loads(artifact.read_text())
 assert [r['test'] for r in data['results'] if r['failure']]==expected,result.stdout+result.stderr
 assert result.returncode==(1 if control else 0),result.stdout+result.stderr
 runs.append({'control':control,'expected_failures':expected,'status':result.returncode,'artifact':artifact.relative_to(OUT).as_posix(),'artifact_sha256':sha(artifact)})
assert before=={p.relative_to(ROOT).as_posix():sha(p) for p in deps}
report={'scope':data['scope'],'baseline_cases':4,'runtime_dependencies_sha256':before,'runs':runs}
(OUT/'current-onibi-batch.json').write_text(json.dumps(report,indent=2)+'\n')
(OUT/'current-onibi-baseline.json').write_bytes((OUT/'current-data/onibi.json').read_bytes())
print('Onibi: 4 baseline scenarios; 3 exact causal controls verified')

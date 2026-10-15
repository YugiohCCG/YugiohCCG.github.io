import hashlib,json,subprocess
from pathlib import Path
ROOT=Path.cwd();OUT=ROOT/'output/fresh-ccg-september'
def sha(p):return hashlib.sha256(p.read_bytes()).hexdigest()
paths=[Path(__file__).resolve(),ROOT/'scripts/fresh_current_seraphina_sabre_battle_replacement.cjs',ROOT/'scripts/fresh_current_card.cjs',ROOT/'public/CCG Downloads/CCG_Scripts/c218142234.lua',OUT/'current-spec-CCG_v1.db']+[ROOT/'tmp/omega_scripts'/n for n in ['constant.lua','utility.lua','procedure.lua']]+list((ROOT/'node_modules/@n1xx1/ocgcore-wasm/dist').glob('*.js'))
paths += [ROOT/'public/CCG Downloads/CCG_Scripts'/f'c{code}.lua' for code in [248788543]]
before={p.relative_to(ROOT).as_posix():sha(p) for p in paths};runs=[]
for control,expected in [(None,[]),('no-replacement',[0,1]),('no-replacement-cost',[0])]:
 result=subprocess.run(['node','--no-warnings','scripts/fresh_current_seraphina_sabre_battle_replacement.cjs']+(['--'+control] if control else []),capture_output=True,text=True,timeout=30);p=OUT/('current-seraphina-sabre-battle-replacement'+('-'+control if control else '')+'.json');d=json.loads(p.read_text(encoding='utf-8'));assert result.returncode==(1 if expected else 0),result.stdout+result.stderr;assert len(d['results'])==4;assert [i for i,v in enumerate(d['results']) if v['failure']]==expected,(control,result.stdout);assert d['adapter'] is None and all(not v['logs'] for v in d['results']);runs.append({'control':control,'expected_failures':expected,'artifact':p.name,'artifact_sha256':sha(p)})
assert before=={p.relative_to(ROOT).as_posix():sha(p) for p in paths};assert paths[3].read_bytes()==Path(r'C:\Program Files (x86)\YGO Omega\YGO Omega_Data\Files\Scripts\c218142234.lua').read_bytes()
(OUT/'current-seraphina-sabre-battle-replacement-batch.json').write_text(json.dumps({'status':'VERIFIED_PARTIAL_PRODUCTION','baseline_cases':4,'runtime_dependencies_sha256':before,'runs':runs,'scope':d['scope']},indent=2)+'\n',encoding='utf-8');print('Seraphina4Sabre-replacementcases2controls verified; no adapters, source unchanged.')

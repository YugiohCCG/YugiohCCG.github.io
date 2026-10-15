import hashlib,json,sqlite3,subprocess
from pathlib import Path
ROOT=Path.cwd();OUT=ROOT/'output/fresh-ccg-september'
def sha(p):return hashlib.sha256(p.read_bytes()).hexdigest()
paths=[Path(__file__).resolve(),ROOT/'scripts/fresh_sylvan_goleaf.cjs',ROOT/'scripts/fresh_sylvan_metadata.cjs',ROOT/'public/CCG Downloads/CCG_Scripts/c238276573.lua',ROOT/'public/CCG Downloads/CCG_Scripts/c238276575.lua',ROOT/'public/CCG Downloads/CCG_Scripts/ccg_sylvan.lua',OUT/'candidate-CCG_v1.db',OUT/'current-spec-CCG_v1.db',OUT/'goleaf-before-helper-fallback/c238276573.lua']+[ROOT/'tmp/omega_scripts'/n for n in ['constant.lua','utility.lua','procedure.lua']]+list((ROOT/'node_modules/@n1xx1/ocgcore-wasm/dist').glob('*.js'))
paths.append(OUT/'sylvan-family-before-helper-fallback/c238276575.lua')
paths.append(next(p for p in [ROOT/'public/CCG Downloads/CCG_Scripts/c30241314.lua',ROOT/'tmp/omega_scripts/c30241314.lua'] if p.exists()))
a=sqlite3.connect(paths[6]);b=sqlite3.connect(paths[7])
for code in [238276573,238276575]:assert a.execute('select * from datas where id=?',(code,)).fetchone()==b.execute('select * from datas where id=?',(code,)).fetchone()
a.close();b.close();before={p.relative_to(ROOT).as_posix():sha(p) for p in paths};runs=[]
for missing,old,expected in [(False,False,[]),(True,False,[]),(True,True,[0,1,2,3,4,5,11])]:
 args=['node','--no-warnings','scripts/fresh_sylvan_goleaf.cjs']+(['--missing-helper'] if missing else [])+(['--old-source'] if old else []);result=subprocess.run(args,capture_output=True,text=True,timeout=30);p=OUT/('sylvan-goleaf'+('-missing-helper' if missing else '')+('-old-source' if old else '')+'.json');d=json.loads(p.read_text());assert result.returncode==(1 if expected else 0),result.stdout+result.stderr;assert len(d['results'])==12;assert [i for i,v in enumerate(d['results']) if v['failure']]==expected,(args,result.stdout)
 if old:
  for i in expected:assert "global 'CCGSylvan'" in d['results'][i]['failure'] and ':59:' in d['results'][i]['failure']
 else:assert all(not v['logs'] for v in d['results'])
 runs.append({'missing_helper':missing,'old_source':old,'expected_failures':expected,'artifact':p.name,'artifact_sha256':sha(p)})
assert before=={p.relative_to(ROOT).as_posix():sha(p) for p in paths};assert paths[3].read_bytes()==Path(r'C:\Program Files (x86)\YGO Omega\YGO Omega_Data\Files\Scripts\c238276573.lua').read_bytes();assert paths[5].read_text().strip() in paths[3].read_text()
(OUT/'current-goleaf-helper-fallback-batch.json').write_text(json.dumps({'baseline_cases':12,'successful_loader_modes':2,'status':'VERIFIED_PARTIAL_PRODUCTION','runtime_dependencies_sha256':before,'runs':runs,'scope':'Full Goleaf native twelve existing excavation/level/normal-special topplacement/revival/Macro/Greetings cases with ordinary helper and unavailable non-card helper; old source reproduces exact user screenshot line59nilglobal. Inline exact helper fallback preserves supplied helper. No live Omega rerun/fullcard certification.'},indent=2)+'\n');print('Goleaf12cases pass in2loader modes; old source reproduces exact screenshot; installed parity verified.')

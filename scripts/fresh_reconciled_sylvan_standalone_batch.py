import hashlib,json,subprocess
from pathlib import Path
ROOT=Path(__file__).resolve().parents[1];OUT=ROOT/'output/fresh-ccg-september';DIR=ROOT/'public/CCG Downloads/CCG_Scripts';FILES=Path(r'C:\Program Files (x86)\YGO Omega\YGO Omega_Data\Files')
def sha(p):return hashlib.sha256(p.read_bytes()).hexdigest()
codes=list(range(238276572,238276580));sources=[DIR/f'c{c}.lua' for c in codes]
paths=[Path(__file__).resolve(),ROOT/'scripts/fresh_reconciled_sylvan_goleaf.cjs',ROOT/'scripts/fresh_reconciled_sylvan_family_helper_load.cjs',ROOT/'scripts/fresh_installed_card.cjs',FILES/'Databases/CCG_v1.db',ROOT/'tmp/omega_scripts/c30241314.lua']+sources+[ROOT/'tmp/omega_scripts'/n for n in ['constant.lua','utility.lua','procedure.lua']]+list((ROOT/'node_modules/@n1xx1/ocgcore-wasm/dist').glob('*.js'))
for c in codes:paths.append(OUT/('goleaf-before-helper-fallback' if c==238276573 else 'sylvan-family-before-helper-fallback')/f'c{c}.lua')
for c in codes:paths.append(OUT/'current-state-reconciliation-before-install/Scripts'/f'c{c}.lua')
before={str(p.resolve()):sha(p) for p in paths};runs=[]
for preexisting,old,control,expected in [(False,False,None,[]),(True,False,None,[]),(False,True,None,[0,1,2,3,4,5,11]),(False,False,'no-relation',[10])]:
 args=['node','--no-warnings','scripts/fresh_reconciled_sylvan_goleaf.cjs']+(['--preexisting-helper'] if preexisting else ['--missing-helper'])+(['--old-source'] if old else [])+(['--'+control] if control else [])
 r=subprocess.run(args,cwd=ROOT,capture_output=True,text=True,timeout=30)
 p=OUT/('current-reconciled-sylvan-goleaf'+('-preexisting-helper' if preexisting else '-missing-helper')+('-old-source' if old else '')+('-'+control if control else '')+'.json');d=json.loads(p.read_text());assert len(d['results'])==12
 assert [i for i,x in enumerate(d['results']) if x['failure']]==expected,r.stdout+r.stderr
 assert r.returncode==(1 if expected else 0)
 if old:
  for i in expected:assert "global 'CCGSylvan'" in d['results'][i]['failure'] and ':59:' in d['results'][i]['failure']
 else:assert all(not x['logs'] for x in d['results'])
 runs.append({'family':False,'artifact':p.name,'sha256':sha(p),'expected_failures':expected,'old_source':old})
for preexisting,old,expected in [(False,False,8),(True,False,8),(False,True,0)]:
 args=['node','--no-warnings','scripts/fresh_reconciled_sylvan_family_helper_load.cjs']+(['--preexisting-helper'] if preexisting else ['--missing-helper'])+(['--old-source'] if old else [])
 r=subprocess.run(args,cwd=ROOT,capture_output=True,text=True,timeout=30);p=OUT/('current-reconciled-sylvan-family-helper-load'+('-preexisting-helper' if preexisting else '-missing-helper')+('-old-source' if old else '')+'.json');d=json.loads(p.read_text());assert len(d['results'])==8 and sum(x['pass'] for x in d['results'])==expected,r.stdout+r.stderr
 assert r.returncode==(0 if expected==8 else 1)
 if not old:assert all(not x['logs'] for x in d['results'])
 runs.append({'family':True,'artifact':p.name,'sha256':sha(p),'passed':expected,'old_source':old})
clean=lambda t:'\n'.join(x.strip() for x in t.splitlines() if x.strip())
for source in sources:
 backup=OUT/'current-state-reconciliation-before-install/Scripts'/source.name
 new=source.read_text(encoding='utf8');old=backup.read_text(encoding='utf8')
 assert new.split('local s,id=GetID()',1)[1]==old.split('local s,id=GetID()',1)[1]
 assert clean(new.split('function CCGSylvan.Plant',1)[1].split('local s,id=GetID()',1)[0])==clean(old.split('function CCGSylvan.Plant',1)[1].split('local s,id=GetID()',1)[0])
 assert source.read_bytes()==(FILES/'Scripts'/source.name).read_bytes()
assert before=={str(p.resolve()):sha(p) for p in paths}
(OUT/'current-reconciled-sylvan-standalone-batch.json').write_text(json.dumps({'scope':'Current8 standalone custom Sylvans; fullGoleaf12 actualduel cases in missing/existing helper namespaces with installed metadata; old7 exactscreenshotfailures/noRelation1. All8 loader-only initial_effect explicitly bypassed after fullsource definitions; requiredhelperfunctions andpreservedexistingnamespace sentinel. Old8loadfailures. Cardeffectbodies andhelperfunction bodies equal backedupoldinlineversions. No nativeOmega/fullcard certification; historical11 official overrides no longer current source scope.','cards':codes,'baseline_goleaf_cases':12,'family_loader_cards':8,'runtime_dependencies_sha256':before,'runs':runs},indent=2)+'\n',encoding='utf8')
print('Goleaf12 x2 namespaces PASS; old7/noRelation1; Sylvan8 x2 loading PASS/old8fail; exactbody equivalence/parity/inputs verified')

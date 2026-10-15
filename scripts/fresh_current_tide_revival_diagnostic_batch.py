import hashlib,json,subprocess
from pathlib import Path
ROOT=Path.cwd();OUT=ROOT/'output/fresh-ccg-september'
def sha(p):return hashlib.sha256(p.read_bytes()).hexdigest()
paths=[Path(__file__).resolve(),ROOT/'scripts/fresh_current_tide_zone_revival.cjs',ROOT/'scripts/fresh_current_tide_revival_interruption.cjs',ROOT/'scripts/fresh_current_card.cjs',ROOT/'public/CCG Downloads/CCG_Scripts/c217645912.lua',OUT/'current-spec-CCG_v1.db']+[ROOT/'tmp/omega_scripts'/n for n in ['constant.lua','utility.lua','procedure.lua']]+list((ROOT/'node_modules/@n1xx1/ocgcore-wasm/dist').glob('*.js'))
before={p.relative_to(ROOT).as_posix():sha(p) for p in paths};runs=[]
for stem,name,compat,control,expected in [('zone_revival','zone-revival',False,None,list(range(6))),('zone_revival','zone-revival',True,None,[]),('zone_revival','zone-revival',True,'no-summon',[0,1,2]),('zone_revival','zone-revival',True,'ignore-set',[4]),('zone_revival','zone-revival',True,'ignore-origin',[6]),('revival_interruption','revival-interruption',True,None,[]),('revival_interruption','revival-interruption',True,'no-summon',[0,5]),('revival_interruption','revival-interruption',True,'no-response',[1,2,3,4,5])]:
 result=subprocess.run(['node','--no-warnings',f'scripts/fresh_current_tide_{stem}.cjs']+(['--faceup-compat'] if compat else [])+(['--'+control] if control else []),capture_output=True,text=True,timeout=30)
 p=OUT/('current-tide-'+name+('-faceup-compat' if compat else '')+('-'+control if control else '')+'.json');data=json.loads(p.read_text(encoding='utf-8'));assert result.returncode==(1 if expected else 0),result.stdout+result.stderr;assert [i for i,v in enumerate(data['results']) if v['failure']]==expected,(name,control,result.stdout)
 if compat:assert data['adapter'] and all(not v['logs'] for v in data['results'])
 else:
  assert data['adapter'] is None
  for i,v in enumerate(data['results']):
   if i in expected:assert any(log['type']==0 and "nil value (method 'IsFaceupEx')" in log['message'] for log in v['logs']);assert all(log['type']!=0 or "nil value (method 'IsFaceupEx')" in log['message'] for log in v['logs'])
   else:assert not v['logs']
 runs.append({'group':name,'compatibility_adapter':compat,'control':control,'expected_failures':expected,'artifact':p.name,'artifact_sha256':sha(p)})
assert before=={p.relative_to(ROOT).as_posix():sha(p) for p in paths}
assert paths[4].read_bytes()==Path(r'C:\Program Files (x86)\YGO Omega\YGO Omega_Data\Files\Scripts\c217645912.lua').read_bytes()
(OUT/'current-tide-revival-diagnostic-batch.json').write_text(json.dumps({'status':'COMPATIBILITY_DIAGNOSTIC_ONLY','adapted_baseline_cases':14,'native_unadapted_cases':8,'runtime_dependencies_sha256':before,'adapter_reference':{'url':'https://raw.githubusercontent.com/Fluorohydride/ygopro-core/master/libcard.cpp','function':'scriptlib::card_is_faceup_ex','lines':[2644,2649],'definition':'faceup OR location Hand/GY/Deck'},'runs':runs,'scope':'No source change. Public native engine missing original-engine API IsFaceupEx. Adapter diagnostic verifies native original SZONE summon, choice/decline/qualification/capacity, negation/source banishment/late fill and late resource banishment. Not adapter-free or native Omega/fullcard certification. FacedownRemoved exclusion is jointly protected; allow-down mutation was nondiscriminating and excluded control count.'},indent=2)+'\n',encoding='utf-8')
print('Tide14 compatibility diagnostic cases/5 fault controls verified;8 unadapted cases isolate6 API failures. Production unchanged.')

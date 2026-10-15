import hashlib,json,subprocess
from pathlib import Path
ROOT=Path.cwd();OUT=ROOT/'output/fresh-ccg-september'
def sha(p):return hashlib.sha256(p.read_bytes()).hexdigest()
groups=[('optional_activation','optional-activation',5,[(None,[]),('no-mill',[0]),('old-source',[1,2,3,4])]),('summon_restriction','summon-restriction',6,[(None,[]),('no-lock',[2]),('ignore-history',[0]),('old-source',list(range(6)))]),('optional_use_reset','optional-use-reset',2,[(None,[]),('no-limit',[0]),('no-reset',[0,1]),('old-source',[0,1])]),('optional_negation_reset','optional-negation-reset',2,[(None,[]),('no-limit',[0,1]),('no-reset',[0,1]),('no-response',[0,1]),('old-source',[0,1])])]
paths=[Path(__file__).resolve(),ROOT/'scripts/fresh_current_card.cjs',ROOT/'public/CCG Downloads/CCG_Scripts/c217645912.lua',OUT/'current-spec-CCG_v1.db',OUT/'tide-before-optional-activation-repair/c217645912.lua']+[ROOT/f'scripts/fresh_current_tide_{g[0]}.cjs' for g in groups]+[ROOT/'tmp/omega_scripts'/n for n in ['constant.lua','utility.lua','procedure.lua']]+list((ROOT/'node_modules/@n1xx1/ocgcore-wasm/dist').glob('*.js'))
assert paths[2].read_bytes()==Path(r'C:\Program Files (x86)\YGO Omega\YGO Omega_Data\Files\Scripts\c217645912.lua').read_bytes()
before={p.relative_to(ROOT).as_posix():sha(p) for p in paths};batches=[]
for stem,name,cases,controls in groups:
 runs=[]
 for control,expected in controls:
  result=subprocess.run(['node','--no-warnings',f'scripts/fresh_current_tide_{stem}.cjs']+(['--'+control] if control else []),capture_output=True,text=True,timeout=30)
  p=OUT/('current-tide-'+name+('-'+control if control else '')+'.json');data=json.loads(p.read_text(encoding='utf-8'))
  assert result.returncode==(1 if expected else 0),result.stdout+result.stderr
  assert len(data['results'])==cases
  assert [i for i,v in enumerate(data['results']) if v['failure']]==expected,(name,control,result.stdout)
  assert all(not v['logs'] for v in data['results'])
  runs.append({'control':control,'expected_failures':expected,'artifact':p.name,'artifact_sha256':sha(p)})
 batches.append({'name':name,'baseline_cases':cases,'scope':data['scope'],'runs':runs})
assert before=={p.relative_to(ROOT).as_posix():sha(p) for p in paths}
(OUT/'current-tide-activation-repaired-batch.json').write_text(json.dumps({'baseline_cases':15,'groups':batches,'runtime_dependencies_sha256':before,'scope':'Full production Tide activation optional mill, actual summon history/restriction, shared chosen-use/decline/negation/reset. Second trigger/native Omega/fullcard OPEN.'},indent=2)+'\n',encoding='utf-8')
print('Tide activation repair: four groups/15 cases/12 controls verified.')

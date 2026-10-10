"""Replay prior effect scenarios against current metadata without overwriting history."""
import hashlib,json,re,subprocess
from pathlib import Path
ROOT=Path(__file__).resolve().parents[1];OUT=ROOT/'output/fresh-ccg-september';CURRENT=OUT/'current-data';CURRENT.mkdir(exist_ok=True)
def sha(p):return hashlib.sha256(p.read_bytes()).hexdigest()
recipes=[('beacon-target-protection','beacon_target_protection',259650969,259174227),
 ('beacon-movement-counters','beacon_movement_counters',259650969,259174227),
 ('beacon-hand-summon','beacon_hand_summon',259650969,259174227),
 ('beacon-grave-summon','beacon_grave_summon',259650969,259174227),
 ('ohmen-linked-summon-family','ohmen_linked_summon',None,259295979),
 ('ohmen-linked-search','ohmen_linked_search',259107906,259434499),
 ('ohmen-linked-followup-family','ohmen_linked_followup',None,259295979)]
dependencies=[ROOT/'scripts/fresh_current_card.cjs',OUT/'current-spec-CCG_v1.db',OUT/'public-core-card-data-adapter.mjs',Path(__file__)]
dependencies += list((ROOT/'public/CCG Downloads/CCG_Scripts').glob('*.lua'))
dependencies += [ROOT/'tmp/omega_scripts'/n for n in ['constant.lua','utility.lua','procedure.lua']]
dependencies += list((ROOT/'node_modules/@n1xx1/ocgcore-wasm/dist').glob('*.js'))
for prefix,harness,source,target in recipes:dependencies += [ROOT/'scripts'/('fresh_'+harness+'.cjs'),OUT/(prefix+'-batch.json')]
before={p.relative_to(ROOT).as_posix():sha(p) for p in dependencies};runs=[]
for prefix,harness,source,target in recipes:
 manifest=json.loads((OUT/(prefix+'-batch.json')).read_text(encoding='utf-8'))
 original=ROOT/'scripts'/('fresh_'+harness+'.cjs');derived=ROOT/'scripts'/('fresh_current_'+harness+'.cjs')
 body=original.read_text(encoding='utf-8')
 assert "require('./fresh_candidate_card.cjs')" in body
 body=body.replace("require('./fresh_candidate_card.cjs')","require('./fresh_current_card.cjs')")
 body,count=re.subn(r"fs\.writeFileSync\(path\.join\(ROOT,(['\"])output/fresh-ccg-september/",r"fs.writeFileSync(path.join(ROOT,\1output/fresh-ccg-september/current-data/",body)
 assert count==1,(harness,'Unexpected output routing')
 derived.write_text(body,encoding='utf-8');derived_hash=sha(derived)
 for old in manifest['runs']:
  code=old.get('passcode',source);control=old['control'];artifact=CURRENT/old['artifact']
  if artifact.exists():artifact.unlink()
  command=['node','--no-warnings',str(derived),f'--source={code}',f'--target={target}']
  if old['card_data_adapter']:command+=['--card-data-adapter']
  if control:command+=['--'+control]
  result=subprocess.run(command,cwd=ROOT,capture_output=True,text=True,timeout=30)
  assert result.returncode==old['status'],result.stdout+result.stderr
  data=json.loads(artifact.read_text(encoding='utf-8'))
  actual=[r['test'] for r in data['results'] if r['failure']]
  assert actual==old['expected_failures'],(prefix,code,control,actual,old['expected_failures'])
  assert data['script_sha256']==sha(ROOT/f'public/CCG Downloads/CCG_Scripts/c{code}.lua')
  data['data_profile']='current-spec installed snapshot'
  data['database_snapshot_sha256']=before['output/fresh-ccg-september/current-spec-CCG_v1.db']
  data['original_harness_sha256']=sha(original);data['derived_harness_sha256']=derived_hash
  artifact.write_text(json.dumps(data,indent=2)+'\n',encoding='utf-8')
  assert sha(derived)==derived_hash
  runs.append({'family':prefix,'passcode':code,'control':control,'status':result.returncode,'cases':len(data['results']),
               'expected_failures':actual,'artifact':artifact.relative_to(OUT).as_posix(),'artifact_sha256':sha(artifact),
               'derived_harness':derived.relative_to(ROOT).as_posix(),'derived_harness_sha256':derived_hash})
 print(prefix+': current metadata scenarios/controls verified',flush=True)
assert before=={p:sha(ROOT/p) for p in before},'Input changed during revalidation'
report={'scope':'Replay of prior actual-duel Ohmen/Beacon scenarios with current installed metadata. Original frozen-reader harnesses/results preserved. Existing fixture/procedure/native Omega limitations remain; this does not certify entire cards.',
        'baseline_cases':sum(r['cases'] for r in runs if r['control'] is None),'runs':runs,'runtime_dependencies_sha256':before}
(OUT/'current-ohmen-effects-batch.json').write_text(json.dumps(report,indent=2)+'\n',encoding='utf-8')
print(json.dumps({'baseline_cases':report['baseline_cases'],'runs':len(runs),'status':'PASS'}))

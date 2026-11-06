import hashlib,json,subprocess
from pathlib import Path
ROOT=Path.cwd();OUT=ROOT/'output/fresh-ccg-september'
def sha(p):return hashlib.sha256(p.read_bytes()).hexdigest()
parts=['recycle','interruption','use-reset','restriction'];paths=[Path(__file__).resolve(),ROOT/'scripts/fresh_installed_card.cjs',ROOT/'scripts/fresh_corrected_card_data_transport.cjs',ROOT/'src/data/cards.json',Path(r'C:\Program Files (x86)\YGO Omega\YGO Omega_Data\Files\Databases\CCG_v1.db'),ROOT/'node_modules/@n1xx1/ocgcore-wasm/dist/index-card-data-transport-candidate.mjs']+list((ROOT/'node_modules/@n1xx1/ocgcore-wasm/dist').glob('*.js'))
old={}
for part in parts:
 p=OUT/f'current-talismandrake-heat-pendulum-{part}-batch.json';old[part]=json.loads(p.read_text());paths+=[p,ROOT/('scripts/fresh_reconciled_talismandrake_heat_pendulum_'+part.replace('-','_')+'.cjs')]
 for name in old[part]['runtime_dependencies_sha256']:
  q=Path(name)
  if q.suffix=='.lua':paths.append(q)
paths=list(dict.fromkeys(paths));before={str(p.resolve()):sha(p) for p in paths};runs=[]
for part in parts:
 for run in old[part]['runs']:
  flag=run['control'];script='scripts/fresh_reconciled_talismandrake_heat_pendulum_'+part.replace('-','_')+'.cjs'
  r=subprocess.run(['node','--no-warnings',script]+(['--'+flag] if flag else []),capture_output=True,text=True,timeout=20)
  p=OUT/('current-reconciled-talismandrake-heat-pendulum-'+part+('-'+flag if flag else '')+'.json');d=json.loads(p.read_text())
  assert len(d['results'])==old[part]['baseline_cases'] and all(not v['logs'] for v in d['results']),r.stdout+r.stderr
  assert [i for i,v in enumerate(d['results']) if v['failure']]==run['expected_failures'],(part,flag,r.stdout)
  assert r.returncode==(1 if run['expected_failures'] else 0)
  runs.append({'part':part,'control':flag,'artifact':p.name,'artifact_sha256':sha(p),'expected_failures':run['expected_failures']})
assert before=={str(p.resolve()):sha(p) for p in paths}
for p in paths:
 if p.parent.name=='CCG_Scripts':assert p.read_bytes()==(Path(r'C:\Program Files (x86)\YGO Omega\YGO Omega_Data\Files\Scripts')/p.name).read_bytes()
report={'status':'VERIFIED_PARTIAL_CURRENT_INSTALLED_METADATA','baseline_cases':26,'runs':runs,'runtime_dependencies_sha256':before,'scope':'Four derived Heat Pendulum fixtures refreshed against actual installed metadata/corrected CardData: recycle9/interruption9/shared use reset3/native Pendulum restriction5. Preserve original artifacts, controls and open interpretations. Full current Heat/Pyre scripts. Existing test-only GetChainInfo target-cards8 compatibility rewrite retained where used; no production changes/nativeOmega/fullcard certification.','open_interpretations':{k:v.get('open_interpretation') for k,v in old.items() if v.get('open_interpretation')}}
(OUT/'current-reconciled-talismandrake-heat-pendulum-batch.json').write_text(json.dumps(report,indent=2)+'\n');print('Heat26currentinstalledcases/20runs verified with original controls; frozen inputs/install parity')

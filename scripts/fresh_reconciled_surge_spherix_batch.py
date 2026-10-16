"""Run focused duel regressions and require exact causal-control failure sets."""
import hashlib, json, subprocess
from pathlib import Path
ROOT=Path(__file__).resolve().parents[1]; OUT=ROOT/'output/fresh-ccg-september'
def sha(p): return hashlib.sha256(p.read_bytes()).hexdigest()
dependencies=['tmp/omega_scripts/'+n for n in ['constant.lua','utility.lua','procedure.lua']]
dependencies+=['scripts/fresh_installed_card.cjs',str(Path(r'C:\Program Files (x86)\YGO Omega\YGO Omega_Data\Files\Databases\CCG_v1.db')),'output/fresh-ccg-september/public-core-card-data-adapter.mjs']
dependencies += [p.relative_to(ROOT).as_posix() for p in (ROOT/'node_modules/@n1xx1/ocgcore-wasm/dist').glob('*.js')]
dependencies += [f'public/CCG Downloads/CCG_Scripts/c{c}.lua' for c in [259869259,259174227,259479044,259405917,259033429,231088629]]
before={p:sha(ROOT/p) for p in dependencies}; runs=[]
plans=[(259869259,'fresh_reconciled_surge_colink_transitions.cjs','current-reconciled-surge-colink-transitions-259869259-259174227-card-data-adapter', ['--source=259869259','--target=259174227','--card-data-adapter'],
        [(None,[]),('old-baseline',[{'initiallyCoLinked':True},{'reactivate':True}]),('shared-tracking',[{'multipleCopies':True}]),('old-inactive',[{'disabled':True},{'facedown':True}])]),
       (231088629,'fresh_reconciled_spherix_interception_regression.cjs','current-reconciled-spherix-interception-regression',[],
        [(None,[]),('old-relation',[{}, {'opponentOwner':True},{'sourceSummoned':True},{'normal':True},{'twoRecipients':True},{'revive':True}]),('no-revival',[{'revive':True}]),('no-counter',[{'revive':True}])]),
       (231088629,'fresh_reconciled_spherix_xyz_attachment.cjs','current-reconciled-spherix-xyz-attachment-neutral-overlay-adapter',['--neutral-overlay-adapter'],
        [(None,[]),('forced-attachment',[{'revive':True},{'revive':True,'decline':True}])]),
       (259869259,'fresh_reconciled_surge_control.cjs','current-reconciled-surge-control',[],
        [(None,[]),('no-control',[{}]),('no-relation',[{'targetReturned':True}]),('no-colink-recheck',[{'graphBroken':True}])]),
       (231088629,'fresh_reconciled_spherix_column_shuffle.cjs','current-reconciled-spherix-column-shuffle',[],
        [(None,[]),('old-faceup',[{'facedown':True}]),('no-shuffle',[{}, {'facedown':True},{'trapPartner':True},{'fusionPartner':True},{'targetImmune':True}]),('no-column',[{'wrongSet':True},{'wrongColumn':True},{'spellPartner':True}]),('no-cost',[{}, {'facedown':True},{'trapPartner':True},{'fusionPartner':True},{'targetImmune':True}])])]
for code,harness,prefix,args,controls in plans:
 for control,expected in controls:
  artifact=OUT/(prefix+('-'+control if control else '')+'.json')
  if artifact.exists(): artifact.unlink()
  command=['node','--no-warnings','scripts/'+harness,*args,*(['--'+control] if control else [])]
  result=subprocess.run(command,cwd=ROOT,text=True,capture_output=True)
  assert result.returncode==(1 if expected else 0), result.stdout+result.stderr
  data=json.loads(artifact.read_text(encoding='utf-8'))
  actual=[r['test'] for r in data['results'] if r['failure']]
  assert actual==expected,(control,actual,expected)
  assert data['script_sha256']==sha(ROOT/f'public/CCG Downloads/CCG_Scripts/c{code}.lua')
  assert data['harness_sha256']==sha(ROOT/'scripts'/harness)
  runs.append({'passcode':code,'control':control,'status':result.returncode,'cases':len(data['results']),
               'expected_failures':expected,'artifact':artifact.name,'artifact_sha256':sha(artifact),
               'harness':harness,'harness_sha256':sha(ROOT/'scripts'/harness),'script_sha256':data['script_sha256']})
  print(f'{code} {control or "baseline"}: verified {len(data["results"])} cases',flush=True)
assert before=={p:sha(ROOT/p) for p in dependencies},'Runtime or source changed during tests'
report={'scope':'Surge startup/per-copy/inactive/removal/reactivation/opponent-Spell control and actual delayed-trigger new-chain CL2 interruptions; Spherix interception/type/revival/counters/non-targeting column shuffle plus optional attachment fixtures with explicit neutral eligibility adapter. Exact isolated causal controls. Fixture summon/procedure boundaries remain explicit; no native Omega or full-card certification.',
        'batch_script_sha256':sha(Path(__file__)),'runtime_dependencies_sha256':before,
        'baseline_cases':sum(r['cases'] for r in runs if r['control'] is None),'runs':runs}
(OUT/'current-reconciled-surge-spherix-batch.json').write_text(json.dumps(report,indent=2)+'\n',encoding='utf-8')
print(json.dumps({'baseline_cases':report['baseline_cases'],'runs':len(runs),'status':'PASS'}))

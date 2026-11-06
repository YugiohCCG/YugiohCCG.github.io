import hashlib,json,subprocess
from pathlib import Path
ROOT=Path.cwd();OUT=ROOT/'output/fresh-ccg-september';FILES=Path(r'C:\Program Files (x86)\YGO Omega\YGO Omega_Data\Files')
def sha(p):return hashlib.sha256(p.read_bytes()).hexdigest()
paths=[Path(__file__).resolve()]+[ROOT/'scripts'/n for n in ['fresh_current_mage_monster_targets.cjs','fresh_current_actual_ritual_targets.cjs','fresh_reconciled_glitchling_leotron_pendulum_ritual.cjs','fresh_current_glitchling_mage_counter_group.cjs','fresh_current_glitchling_counter_followup.cjs','fresh_installed_card.cjs','fresh_corrected_card_data_transport.cjs']]+[FILES/'Databases/CCG_v1.db']+[ROOT/'public/CCG Downloads/CCG_Scripts'/f'c{c}.lua' for c in [259678739,259072906,259873115,259546637,259156549,259247807,259494236]]+[ROOT/'tmp/omega_scripts'/n for n in ['constant.lua','utility.lua','procedure.lua']]+list((ROOT/'node_modules/@n1xx1/ocgcore-wasm/dist').glob('*.js'))+[ROOT/'node_modules/@n1xx1/ocgcore-wasm/dist/index-card-data-transport-candidate.mjs']
before={str(p.resolve()):sha(p) for p in paths};runs=[]
for mode in ['witch']:
 for code in [259678739,259072906,259873115,259156549,259247807,259494236]:
  count=4 if code in [259678739,259072906,259873115] else 3
  controls=[(None,[]),('no-material',[0,1,2] if count==4 else [0,1]),('no-complete',[0,1])]
  for control,expected in controls:
   r=subprocess.run(['node','--no-warnings','scripts/fresh_current_mage_monster_targets.cjs',f'--mode={mode}',f'--target={code}']+(['--'+control] if control else []),capture_output=True,text=True,timeout=20)
   p=OUT/(f'current-mage-monster-target-{code}'+('-'+control if control else '')+'.json');d=json.loads(p.read_text());assert len(d['results'])==count and [i for i,v in enumerate(d['results']) if v['failure']]==expected and all(not v['logs'] for v in d['results']),(mode,code,control,r.stdout+r.stderr);assert r.returncode==bool(expected)
   runs.append({'mode':mode,'target_passcode':code,'control':control,'artifact':p.name,'sha256':sha(p),'expected_failures':expected})
assert before=={str(p.resolve()):sha(p) for p in paths}
for code in [259678739,259072906,259873115,259546637,259156549,259247807,259494236]:assert (ROOT/'public/CCG Downloads/CCG_Scripts'/f'c{code}.lua').read_bytes()==(FILES/'Scripts'/f'c{code}.lua').read_bytes()
(OUT/'current-mage-monster-targets-batch.json').write_text(json.dumps({'status':'MAGE_MONSTER_RITUAL_ACTUAL_TARGETS_VERIFIED','runtime_dependencies_sha256':before,'runs':runs,'scope':'Original Mage monster Special-Summon trigger Ritual with full actual Witch/Mage/Leotron/Protron/Bitron/Digitron recipient scripts, installed metadata/corrected transport/no Lua API adapter. Native Hand and Deck materials; Hand targets and genuine faceup Extra targets only for Pendulums; full Main Hand exclusion. Native exact material group/reasons/Ritual type/completion and effective omitted-material/completion controls. Extra recipients were previously properly paid/completed, so no-completion control applies only first Hand summons. Initial source and Extra history neutral fixed paid Ritual preparation; target optional followups declined. This is distinct from Mage Pendulum replacement group procedure. Does not certify recipient followups/independent procedures/full-card/live Omega.'},indent=2)+'\n');print('Mage monster Ritual actual six-target family/payment controls verified')

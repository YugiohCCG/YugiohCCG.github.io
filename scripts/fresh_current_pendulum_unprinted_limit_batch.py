import hashlib,json,re,subprocess
from pathlib import Path
ROOT=Path.cwd();OUT=ROOT/'output/fresh-ccg-september';FILES=Path(r'C:\Program Files (x86)\YGO Omega\YGO Omega_Data\Files')
def sha(p):return hashlib.sha256(p.read_bytes()).hexdigest()
manifest=OUT/'pendulum-unprinted-limit-repair-files.json';items=json.loads(manifest.read_text())['files']
paths=[Path(__file__).resolve(),manifest,ROOT/'src/data/cards.json',ROOT/'scripts/fresh_corrected_card_data_transport.cjs',ROOT/'scripts/fresh_installed_card.cjs',FILES/'Databases/CCG_v1.db',OUT/'current-spec-CCG_v1.db']+[ROOT/'scripts'/n for n in ['fresh_current_seraphina_unlimited_pendulum.cjs','fresh_current_leotron_unlimited_pendulum.cjs','fresh_current_seraphina_pendulum_use_reset.cjs','fresh_reconciled_glitchling_leotron_pendulum_ritual.cjs']]+[ROOT/'tmp/omega_scripts'/n for n in ['constant.lua','utility.lua','procedure.lua']]+list((ROOT/'node_modules/@n1xx1/ocgcore-wasm/dist').glob('*.js'))+[ROOT/'node_modules/@n1xx1/ocgcore-wasm/dist/index-card-data-transport-candidate.mjs']
for v in items:
 paths += [ROOT/'public/CCG Downloads/CCG_Scripts'/v['file'],FILES/'Scripts'/v['file'],OUT/v['backup']/v['file'],OUT/v['backup']/('installed-'+v['file'])]
before={str(p.resolve()):sha(p) for p in paths};runs=[]
for kind in ['seraphina','leotron']:
 for control in [None,'old-source','no-summon' if kind=='seraphina' else 'no-material']:
  r=subprocess.run(['node','--no-warnings',f'scripts/fresh_current_{kind}_unlimited_pendulum.cjs']+(['--'+control] if control else []),capture_output=True,text=True,timeout=20)
  p=OUT/f'current-{kind}-unlimited-pendulum{("-"+control) if control else ""}.json';d=json.loads(p.read_text());expected=[0,1,2] if control else []
  assert r.returncode==bool(control) and len(d['results'])==3 and [i for i,v in enumerate(d['results']) if v['failure']]==expected,(kind,control,r.stdout+r.stderr)
  assert all(not v['logs'] for v in d['results'])
  if not control and kind=='leotron':assert all(len(v['phases'])==2 for v in d['results'])
  runs.append({'kind':kind,'control':control,'artifact':p.name,'sha256':sha(p),'expected_failures':expected})
same_pattern=[]
for c in json.loads((ROOT/'src/data/cards.json').read_text(encoding='utf-8')):
 if 'Pendulum Effect:' not in c.get('text','') or 'once per turn' in c['text'].split('Monster Effect:')[0]:continue
 p=ROOT/'public/CCG Downloads/CCG_Scripts'/f'c{c["passcode"]}.lua';s=p.read_text();blocks=re.findall(r'local (\w+)=Effect.CreateEffect\(c\)(.*?)c:RegisterEffect\(\1\)',s,re.S)
 assert all('SetCountLimit' not in body for _,body in blocks if 'SetRange(LOCATION_PZONE)' in body),c['passcode']
 same_pattern.append({'passcode':c['passcode'],'script_sha256':sha(p),'review':'No count limit on directly registered PZone effects; monster count limits excluded.'})
assert len(same_pattern)==6
for v in items:
 assert (ROOT/'public/CCG Downloads/CCG_Scripts'/v['file']).read_bytes()==(FILES/'Scripts'/v['file']).read_bytes()
assert before=={str(p.resolve()):sha(p) for p in paths}
(OUT/'current-pendulum-unprinted-limit-batch.json').write_text(json.dumps({'status':'UNPRINTED_PENDULUM_LIMITS_REPAIRED','runtime_dependencies_sha256':before,'runs':runs,'same_pattern_review':same_pattern,'superseded_claim':'Seraphina historical current-seraphina-pendulum-use-reset-batch asserted an unsupported Pendulum limit; retained historically, superseded for that clause.','scope':'Printed-text audit found Seraphina and Leotron unprinted named Pendulum limits. Two same-turn full-source activations after success/activation negation/effect negation, paid actual costs/summons, original-source and omitted-operation controls. Native public engine/current installed metadata/corrected transport; no Lua API shim. Seraphina neutral paid Fusion setup and Leotron neutral Ritual targets remain distinct from general recipes and live Omega.'},indent=2)+'\n',encoding='utf-8');print('Seraphina/Leotron unprinted-limit repair and six-card same-pattern review verified')

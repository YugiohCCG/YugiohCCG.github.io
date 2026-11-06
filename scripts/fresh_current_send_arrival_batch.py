import hashlib,json,re,subprocess
from pathlib import Path
ROOT=Path.cwd();OUT=ROOT/'output/fresh-ccg-september';FILES=Path(r'C:\Program Files (x86)\YGO Omega\YGO Omega_Data\Files')
def sha(p):return hashlib.sha256(p.read_bytes()).hexdigest()
manifest=OUT/'send-arrival-repair-files.json';items=json.loads(manifest.read_text())['files'];back=OUT/'send-arrival-before-repair'
reviewed=[211699737,232449539,238272436,259568843,284636661]
paths=[Path(__file__).resolve(),manifest,FILES/'Databases/CCG_v1.db',ROOT/'src/data/cards.json']+[ROOT/'public/CCG Downloads/CCG_Scripts'/f'c{c}.lua' for c in reviewed]+[ROOT/'scripts'/n for n in ['fresh_current_nether_send_redirect.cjs','fresh_current_zostera_send_redirect.cjs','fresh_nether_send_arrival_repair.cjs','fresh_underroot_nether_send.cjs','fresh_current_meadow_events.cjs','fresh_installed_card.cjs','fresh_corrected_card_data_transport.cjs']]+[ROOT/'tmp/omega_scripts'/n for n in ['constant.lua','utility.lua','procedure.lua']]+list((ROOT/'node_modules/@n1xx1/ocgcore-wasm/dist').glob('*.js'))+[ROOT/'node_modules/@n1xx1/ocgcore-wasm/dist/index-card-data-transport-candidate.mjs']
for item in items:
 p=ROOT/'public/CCG Downloads/CCG_Scripts'/item['file'];old=back/p.name;assert sha(p)==item['after_sha256'] and sha(old)==item['before_sha256'] and p.read_bytes()==(FILES/'Scripts'/p.name).read_bytes() and old.read_bytes()==(back/('installed-'+p.name)).read_bytes()
 r=subprocess.run(['node','-e',"process.stdout.write(require('./scripts/fresh_nether_send_arrival_repair.cjs').corrected(require('fs').readFileSync(process.argv[1],'utf8'),Number(process.argv[2])))",str(old),str(item['passcode'])],capture_output=True);assert r.returncode==0 and r.stdout==p.read_bytes();paths += [old,back/('installed-'+p.name)]
matches=[]
for p in (ROOT/'public/CCG Downloads/CCG_Scripts').glob('*.lua'):
 for m in re.finditer(r'function s\.(\w+)\([^\n]*[\s\S]*?(?=\nfunction|\Z)',p.read_text()):
  b=m[0]
  if 'Duel.SendtoGrave(' in b and 'Duel.Remove(' in b and b.index('Duel.SendtoGrave(')<b.rindex('Duel.Remove('):matches.append(int(p.stem[1:]))
assert sorted(matches)==reviewed
deps={str(p.resolve()):sha(p) for p in paths};runs=[]
for fixture,n,no_follow in [('nether',4,[0,3]),('zostera',3,[0])]:
 for flag,expected in [(None,[]),('old-source',[1]),('no-followup',no_follow)]:
  r=subprocess.run(['node','--no-warnings',f'scripts/fresh_current_{fixture}_send_redirect.cjs']+(['--'+flag] if flag else []),capture_output=True,text=True,timeout=20)
  p=OUT/(f'current-{fixture}-send-redirect'+('-'+flag if flag else '')+'.json');d=json.loads(p.read_text());assert len(d['results'])==n and [i for i,v in enumerate(d['results']) if v['failure']]==expected and all(not v['logs'] for v in d['results']),(fixture,flag,r.stdout+r.stderr);assert r.returncode==bool(expected);runs.append({'artifact':p.name,'sha256':sha(p),'cases':n,'expected_failures':expected})
assert deps=={str(p.resolve()):sha(p) for p in paths}
(OUT/'current-send-arrival-batch.json').write_text(json.dumps({'status':'NETHER_AND_ZOSTERA_THEN_BANISH_ARRIVAL_REPAIRED','runtime_dependencies_sha256':deps,'runs':runs,'same_function_send_remove_reviewed':reviewed,'same_pattern_confirmed':[238272436,284636661],'review':'211699737 already requires actual GY arrival; 232449539 sends and banishes separate Fusion material groups; 259568843 mutually exclusive Hand discard/GY banish costs. Nether/Zostera printed then-banish clauses alone lack arrival guard. Other-card review static only.','scope':'Full original sources/current installed metadata/corrected public engine/no Lua API adapter. Original Nether SS-trigger and pre-Set Zostera native Trap Monster activation/summon, actual Deck monster send under native Macro-style field redirect, existing GY card preserved when no actual arrival. Normal send/followup, Nether empty-GY redirect/newly-sent-card banish, Zostera optional decline retained. Actual native destinations and required followup/payment-state assertions; original redirect failures and omitted-followup controls. Exact source/install backups/helper/manifest/parity. Other effects/whole-card/live Omega remain open.'},indent=2)+'\n');print('Nether/Zostera actual GY-arrival repairs verified')

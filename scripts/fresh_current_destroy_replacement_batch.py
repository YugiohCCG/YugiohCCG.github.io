import hashlib,json,re,subprocess
from pathlib import Path
ROOT=Path.cwd();OUT=ROOT/'output/fresh-ccg-september';FILES=Path(r'C:\Program Files (x86)\YGO Omega\YGO Omega_Data\Files')
def sha(p):return hashlib.sha256(p.read_bytes()).hexdigest()
manifest=OUT/'destroy-replacement-repair-files.json';items=json.loads(manifest.read_text())['files'];back=OUT/'destroy-replacement-before-repair'
paths=[Path(__file__).resolve(),manifest,FILES/'Databases/CCG_v1.db']+[ROOT/'scripts'/n for n in ['fresh_current_avatar_replacement.cjs','fresh_current_blaze_replacement.cjs','fresh_avatar_replacement_repair.cjs','fresh_current_meadow_events.cjs','fresh_installed_card.cjs','fresh_corrected_card_data_transport.cjs']]+[ROOT/'tmp/omega_scripts'/n for n in ['constant.lua','utility.lua','procedure.lua']]+list((ROOT/'node_modules/@n1xx1/ocgcore-wasm/dist').glob('*.js'))+[ROOT/'node_modules/@n1xx1/ocgcore-wasm/dist/index-card-data-transport-candidate.mjs',ROOT/'public/CCG Downloads/CCG_Scripts/c218142234.lua',ROOT/'public/CCG Downloads/CCG_Scripts/c255832330.lua']
for item in items:
 p=ROOT/'public/CCG Downloads/CCG_Scripts'/item['file'];old=back/p.name
 assert sha(p)==item['after_sha256'] and sha(old)==item['before_sha256'] and p.read_bytes()==(FILES/'Scripts'/p.name).read_bytes() and old.read_bytes()==(back/('installed-'+p.name)).read_bytes()
 r=subprocess.run(['node','-e',"process.stdout.write(require('./scripts/fresh_avatar_replacement_repair.cjs').corrected(require('fs').readFileSync(process.argv[1],'utf8'),Number(process.argv[2])))",str(old),str(item['passcode'])],capture_output=True);assert r.returncode==0 and r.stdout==p.read_bytes()
 paths +=[p,old,back/('installed-'+p.name)]
before={str(p.resolve()):sha(p) for p in paths};runs=[]
for fixture,flags,n,fail in [('avatar',[],7,[0,1,5,6]),('blaze',[],4,[2,3]),('blaze',['--shield'],4,[])]:
 for old in ([False,True] if not flags else [False]):
  args=['node','--no-warnings',f'scripts/fresh_current_{fixture}_replacement.cjs']+flags+(['--old-source'] if old else []);r=subprocess.run(args,capture_output=True,text=True,timeout=20)
  name='current-avatar-replacement' if fixture=='avatar' else 'current-blaze-'+('255832330' if flags else '248788543')+'-replacement'
  p=OUT/(name+('-old-source' if old else '')+'.json');d=json.loads(p.read_text());expected=fail if old else []
  assert len(d['results'])==n and [i for i,v in enumerate(d['results']) if v['failure']]==expected and all(not v['logs'] for v in d['results']),(args,r.stdout+r.stderr);assert r.returncode==bool(expected)
  runs.append({'artifact':p.name,'sha256':sha(p),'cases':n,'expected_failures':expected})
missing=[]
for p in (ROOT/'public/CCG Downloads/CCG_Scripts').glob('*.lua'):
 s=(back/p.name if (back/p.name).exists() else p).read_text()
 for m in re.finditer(r'(\w+):SetCode\(EFFECT_DESTROY_REPLACE\)',s):
  v=m[1];a=s.rfind('local '+v+'=',0,m.start());b=s.find(':RegisterEffect('+v+')',m.end());seg=s[a:b]
  if a>=0 and b>=0 and 'EFFECT_TYPE_FIELD+EFFECT_TYPE_CONTINUOUS' in seg and v+':SetValue(' not in seg:missing.append(int(p.stem[1:]))
assert sorted(missing)==[244790302,248788543,255832330]
assert before=={str(p.resolve()):sha(p) for p in paths}
(OUT/'current-destroy-replacement-batch.json').write_text(json.dumps({'status':'AVATAR_AND_SABRE_DESTROY_REPLACEMENT_REPAIRED','runtime_dependencies_sha256':before,'runs':runs,'same_pattern_missing_before':sorted(missing),'shield':'Unchanged: original send-replacement fallback passes actual effect destruction/decline and battle exclusions. No failing outcome established.','scope':'Full original sources/native GY equip on field-seeded installed Seraphina/native effect destruction and battle. Avatar opposing Deck payment/visibility/type/set boundaries and opponent-card exclusion; Sabre accept/decline and battle-only scope. Exact helper/backups/parity and original-source failures. Corrected public engine, no Lua API adapter; original Fusion history/full-card/live Omega unverified.'},indent=2)+'\n');print('Replacement repair evidence verified')

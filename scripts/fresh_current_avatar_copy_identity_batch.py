import hashlib,json,re,subprocess
from pathlib import Path
ROOT=Path.cwd();OUT=ROOT/'output/fresh-ccg-september';FILES=Path(r'C:\Program Files (x86)\YGO Omega\YGO Omega_Data\Files')
def sha(p):return hashlib.sha256(p.read_bytes()).hexdigest()
manifest=OUT/'avatar-copy-state-repair-files.json';item=json.loads(manifest.read_text())['files'][0];back=OUT/'avatar-before-copy-state-repair'
paths=[Path(__file__).resolve(),manifest,FILES/'Databases/CCG_v1.db',ROOT/'public/CCG Downloads/CCG_Scripts/c244790302.lua',back/item['file'],back/('installed-'+item['file'])]+[ROOT/'scripts'/n for n in ['fresh_current_avatar_copy_identity.cjs','fresh_avatar_copy_identity_repair.cjs','fresh_current_meadow_events.cjs','fresh_installed_card.cjs','fresh_corrected_card_data_transport.cjs']]+[ROOT/'tmp/omega_scripts'/n for n in ['constant.lua','utility.lua','procedure.lua']]+list((ROOT/'node_modules/@n1xx1/ocgcore-wasm/dist').glob('*.js'))+[ROOT/'node_modules/@n1xx1/ocgcore-wasm/dist/index-card-data-transport-candidate.mjs']
before={str(p.resolve()):sha(p) for p in paths};runs=[]
for control,expected in [(None,[]),('old-source',[0,2,3,4]),('no-copy',[0,1,2,4]),('no-response',[3,4,5])]:
 r=subprocess.run(['node','--no-warnings','scripts/fresh_current_avatar_copy_identity.cjs']+(['--'+control] if control else []),capture_output=True,text=True,timeout=20);p=OUT/('current-avatar-copy-identity'+('-'+control if control else '')+'.json');d=json.loads(p.read_text());assert len(d['results'])==6 and [i for i,v in enumerate(d['results']) if v['failure']]==expected,(control,r.stdout+r.stderr);assert r.returncode==bool(expected)
 for i,v in enumerate(d['results']):
  if v['logs']:assert control=='old-source' and i==2 and all(l['type'] in [0,2] for l in v['logs']) and any('assertion failed!' in l['message'] and 'c900008301.lua' in l['message'] for l in v['logs'])
 runs.append({'control':control,'artifact':p.name,'sha256':sha(p),'expected_failures':expected,'expected_assertion_logs':[2] if control=='old-source' else []})
source=ROOT/'public/CCG Downloads/CCG_Scripts'/item['file'];old=back/item['file'];assert sha(source)==item['after_sha256'] and sha(old)==item['before_sha256'] and source.read_bytes()==(FILES/'Scripts'/source.name).read_bytes() and old.read_bytes()==(back/('installed-'+source.name)).read_bytes()
r=subprocess.run(['node','-e',"process.stdout.write(require('./scripts/fresh_avatar_copy_identity_repair.cjs').corrected(require('fs').readFileSync(process.argv[1],'utf8')))",str(old)],capture_output=True,timeout=10);assert r.returncode==0 and r.stdout==source.read_bytes()
identity=[];label=[]
for p in (ROOT/'public/CCG Downloads/CCG_Scripts').glob('*.lua'):
 b=back/p.name;s=(b if b.exists() else p).read_text(encoding='utf-8')
 if 'CheckActivateEffect' not in s:continue
 if 'te:SetLabel(te:GetLabel())' in s:label.append(int(p.stem[1:]))
 for m in re.finditer(r'function ([\w.]+)\([^\n]*[\s\S]*?(?=\nfunction |\Z)',s):
  if 'Duel.GetFirstTarget()' in m[0] and 'e:GetLabelObject()' in m[0] and 'te:GetOperation()' in m[0]:identity.append(int(p.stem[1:]))
assert identity==label==[244790302];assert before=={str(p.resolve()):sha(p) for p in paths}
(OUT/'current-avatar-copy-identity-batch.json').write_text(json.dumps({'status':'AVATAR_COPIED_SOURCE_AND_TARGET_LABEL_REPAIRED','runtime_dependencies_sha256':before,'runs':runs,'same_pattern_identity':identity,'same_pattern_label':label,'scope':'Full original Avatar/installed metadata/corrected transport/no Lua API adapter. Initially field source Quick selects neutral Stain GY activation effects: non-target500 damage; independent target destruction plus also500 damage; copied target-time label907 and label-object recipient. Actual CL2 copied-source removal cancels application, recipient removal retains independent damage. Original GetFirstTarget guard loses non-target source/confuses copied recipient; original label no-op fails explicit copied metadata assertion. Repaired stored activation-effect handler identifies source independently and target-time label preserved. Exact original/no-copy/no-response controls; expected original metadata assertion logs only case2. Exact source/install backups/helper/manifest/parity; exact source retrieval/no-op-label scans only Avatar, adjacent copy implementations inspected. Field-seeded source/neutral copied Spell/recipient/response; original Fusion recipe/other copy APIs/full-card/live Omega separate.'},indent=2)+'\n');print('Avatar source identity/copied target metadata/native CL2 controls verified')

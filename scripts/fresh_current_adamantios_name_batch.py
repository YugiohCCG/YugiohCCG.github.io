import hashlib,json,re,subprocess
from pathlib import Path
ROOT=Path.cwd();OUT=ROOT/'output/fresh-ccg-september';FILES=Path(r'C:\Program Files (x86)\YGO Omega\YGO Omega_Data\Files')
def sha(p):return hashlib.sha256(p.read_bytes()).hexdigest()
manifest=OUT/'adamantios-name-repair-files.json';item=json.loads(manifest.read_text())['files'][0];back=OUT/'adamantios-before-name-repair';source=ROOT/'public/CCG Downloads/CCG_Scripts'/item['file'];old=back/source.name
assert sha(source)==item['after_sha256'] and sha(old)==item['before_sha256'] and source.read_bytes()==(FILES/'Scripts'/source.name).read_bytes() and old.read_bytes()==(back/('installed-'+source.name)).read_bytes()
r=subprocess.run(['node','-e',"process.stdout.write(require('./scripts/fresh_adamantios_name_repair.cjs').corrected(require('fs').readFileSync(process.argv[1],'utf8')))",str(old)],capture_output=True);assert r.returncode==0 and r.stdout==source.read_bytes()
paths=[Path(__file__).resolve(),manifest,old,back/('installed-'+source.name),source,FILES/'Databases/CCG_v1.db']+[ROOT/'scripts'/n for n in ['fresh_current_adamantios_name.cjs','fresh_adamantios_name_repair.cjs','fresh_current_adamantios_replacement.cjs','fresh_current_meadow_events.cjs','fresh_installed_card.cjs','fresh_corrected_card_data_transport.cjs']]+[ROOT/'tmp/omega_scripts'/n for n in ['constant.lua','utility.lua','procedure.lua']]+list((ROOT/'node_modules/@n1xx1/ocgcore-wasm/dist').glob('*.js'))+[ROOT/'node_modules/@n1xx1/ocgcore-wasm/dist/index-card-data-transport-candidate.mjs']
deps={str(p.resolve()):sha(p) for p in paths};runs=[]
for control,expected in [(None,[]),('old-source',[0,1,2]),('no-payment',[0,2])]:
 r=subprocess.run(['node','--no-warnings','scripts/fresh_current_adamantios_name.cjs']+(['--'+control] if control else []),capture_output=True,text=True,timeout=20)
 p=OUT/('current-adamantios-name'+('-'+control if control else '')+'.json');d=json.loads(p.read_text());assert len(d['results'])==4 and [i for i,v in enumerate(d['results']) if v['failure']]==expected and all(not v['logs'] for v in d['results']),(control,r.stdout+r.stderr);assert r.returncode==bool(expected);runs.append({'artifact':p.name,'sha256':sha(p),'expected_failures':expected})
matches=[]
for p in (ROOT/'public/CCG Downloads/CCG_Scripts').glob('*.lua'):
 s=(back/p.name if (back/p.name).exists() else p).read_text()
 if 'REPLACE' not in s:continue
 for m in re.finditer(r'function s\.[^\n]+[\s\S]*?(?=\nfunction|\Z)',s):
  if 'IsCode(id)' in m[0] and ('IsReason' in m[0] or 'GetDestination' in m[0]):matches.append(int(p.stem[1:]))
assert matches==[259315827] and deps=={str(p.resolve()):sha(p) for p in paths}
(OUT/'current-adamantios-name-batch.json').write_text(json.dumps({'status':'ADAMANTIOS_THIS_CARD_NAME_RESTRICTION_REPAIRED','runtime_dependencies_sha256':deps,'runs':runs,'same_pattern':matches,'scope':'Full source/current installed metadata/corrected transport/no Lua API adapter. Actual native Equip and EFFECT_CHANGE_CODE on one of two field-seeded copies, opponent native GY/banish, valid replacement choice/payment and unaffected-copy exclusion. Original name filter fails all three affected cases; omitted payment controls fail positives. Exact source/install backups/helper/manifest/parity; earlier handler identity repair retained. Scan only Adamantios. Original Xyz history/Quick equip/other effects/full-card/live Omega remain open.'},indent=2)+'\n');print('Adamantios real name-change replacement evidence verified')

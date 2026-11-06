import hashlib,json,re,subprocess
from pathlib import Path
ROOT=Path.cwd();OUT=ROOT/'output/fresh-ccg-september';FILES=Path(r'C:\Program Files (x86)\YGO Omega\YGO Omega_Data\Files')
def sha(p):return hashlib.sha256(p.read_bytes()).hexdigest()
manifest=OUT/'nether-move-visibility-repair-files.json';item=json.loads(manifest.read_text())['files'][0];back=OUT/'nether-before-move-visibility-repair';source=ROOT/'public/CCG Downloads/CCG_Scripts'/item['file'];old=back/source.name
assert sha(source)==item['after_sha256'] and sha(old)==item['before_sha256'] and source.read_bytes()==(FILES/'Scripts'/source.name).read_bytes() and old.read_bytes()==(back/('installed-'+source.name)).read_bytes()
r=subprocess.run(['node','-e',"process.stdout.write(require('./scripts/fresh_nether_move_visibility_repair.cjs').corrected(require('fs').readFileSync(process.argv[1],'utf8')))",str(old)],capture_output=True);assert r.returncode==0 and r.stdout==source.read_bytes()
paths=[Path(__file__).resolve(),manifest,old,back/('installed-'+source.name),source,FILES/'Databases/CCG_v1.db']+[ROOT/'scripts'/n for n in ['fresh_current_nether_move_visibility.cjs','fresh_nether_move_visibility_repair.cjs','fresh_underroot_nether_move.cjs','fresh_installed_card.cjs','fresh_corrected_card_data_transport.cjs']]+[ROOT/'tmp/omega_scripts'/n for n in ['constant.lua','utility.lua','procedure.lua']]+list((ROOT/'node_modules/@n1xx1/ocgcore-wasm/dist').glob('*.js'))+[ROOT/'node_modules/@n1xx1/ocgcore-wasm/dist/index-card-data-transport-candidate.mjs']
deps={str(p.resolve()):sha(p) for p in paths};runs=[]
for flag,expected in [(None,[]),('old-source',[2,3,4]),('no-move',[0,1])]:
 r=subprocess.run(['node','--no-warnings','scripts/fresh_current_nether_move_visibility.cjs']+(['--'+flag] if flag else []),capture_output=True,text=True,timeout=20)
 p=OUT/('current-nether-move-visibility'+('-'+flag if flag else '')+'.json');d=json.loads(p.read_text());assert len(d['results'])==6 and [i for i,v in enumerate(d['results']) if v['failure']]==expected and all(not v['logs'] for v in d['results']),(flag,r.stdout+r.stderr);assert r.returncode==bool(expected);runs.append({'artifact':p.name,'sha256':sha(p),'expected_failures':expected})
matches=[]
for p in (ROOT/'public/CCG Downloads/CCG_Scripts').glob('*.lua'):
 s=(back/p.name if (back/p.name).exists() else p).read_text()
 if 'EVENT_MOVE' not in s and 'EVENT_REMOVE' not in s:continue
 for m in re.finditer(r'function s\.(\w+)\([^\n]*[\s\S]*?(?=\nfunction|\Z)',s):
  b=m[0]
  if 'LOCATION_REMOVED' in b and 'IsType(TYPE_MONSTER)' in b and 'IsFaceup' not in b:matches.append({'passcode':int(p.stem[1:]),'callback':m[1]})
assert matches==[{'passcode':238272436,'callback':'mvfilter'}] and deps=={str(p.resolve()):sha(p) for p in paths}
(OUT/'current-nether-move-visibility-batch.json').write_text(json.dumps({'status':'NETHER_HIDDEN_BANISH_MONSTER_EVENT_REPAIRED','runtime_dependencies_sha256':deps,'runs':runs,'same_pattern_before':matches,'ruling':'https://www.db.yugioh-card.com/yugiohdb/faq_search.action?cid=12655&ope=4&request_locale=ja&sort=2','scope':'Full original Nether/current installed metadata/corrected public engine/no Lua API adapter. Real Deck monster to GY/faceup banishment retains original target movement/self summon; actual face-down banishment cannot identify/target monster, excluded for Hand/GY/banished sources; Deck Spell to GY excluded. Native positions/destinations/offers/summons asserted. Original hidden-event failures and omitted-move controls; exact source/install backups/helper/manifest/parity, earlier shuffle/arrival guards strictly reconciled. Same EVENT_MOVE/REMOVE monster+banishment filter scan only Nether. Analogous official information-based faceup selection rule, not direct custom-card ruling. Source-identity/other effects/full-card/live Omega remain open.'},indent=2)+'\n');print('Nether hidden-banish event repair verified')

import hashlib,json,subprocess
from pathlib import Path
ROOT=Path.cwd();OUT=ROOT/'output/fresh-ccg-september';FILES=Path(r'C:\Program Files (x86)\YGO Omega\YGO Omega_Data\Files')
def sha(p):return hashlib.sha256(p.read_bytes()).hexdigest()
manifest=OUT/'trumpet-damage-step-repair-files.json';item=json.loads(manifest.read_text())['files'][0];source=ROOT/'public/CCG Downloads/CCG_Scripts'/item['file'];back=OUT/item['backup'];old=back/source.name
assert sha(source)==item['after_sha256'] and sha(old)==item['before_sha256'] and source.read_bytes()==(FILES/'Scripts'/source.name).read_bytes() and old.read_bytes()==(back/('installed-'+source.name)).read_bytes()
r=subprocess.run(['node','-e',"process.stdout.write(require('./scripts/'+process.argv[2]).corrected(require('fs').readFileSync(process.argv[1],'utf8')))",str(old),item['helper']],capture_output=True);assert r.returncode==0 and r.stdout==source.read_bytes()
paths=[Path(__file__).resolve(),manifest,source,old,back/('installed-'+source.name),FILES/'Databases/CCG_v1.db',ROOT/'src/data/cards.json']+[ROOT/'scripts'/n for n in ['fresh_current_trumpet_battle_flip.cjs',item['helper'],'fresh_installed_card.cjs','fresh_corrected_card_data_transport.cjs']]+[ROOT/'tmp/omega_scripts'/n for n in ['constant.lua','utility.lua','procedure.lua']]+list((ROOT/'node_modules/@n1xx1/ocgcore-wasm/dist').glob('*.js'))+[ROOT/'node_modules/@n1xx1/ocgcore-wasm/dist/index-card-data-transport-candidate.mjs']+[ROOT/'scripts/fresh_current_terrarumian_ivy_participants.cjs']
deps={str(p.resolve()):sha(p) for p in paths};runs=[]
for flag,expected in [(None,[]),('old-source',[0,1]),('no-summon',[0,1])]:
 r=subprocess.run(['node','--no-warnings','scripts/fresh_current_trumpet_battle_flip.cjs']+(['--'+flag] if flag else []),capture_output=True,text=True,timeout=20);p=OUT/('current-trumpet-battle-flip'+('-'+flag if flag else '')+'.json');d=json.loads(p.read_text());assert [i for i,v in enumerate(d['results']) if v['failure']]==expected and r.returncode==bool(expected),(flag,r.stdout+r.stderr)
 assert len(d['results'])==4
 if flag=='compatibility':assert all(v['logs'] and 'nil value' in v['failure'] for v in d['results'])
 else:assert all(not v['logs'] for v in d['results'])
 runs.append({'artifact':p.name,'sha256':sha(p),'expected_failures':expected,'known_compatibility_failure':flag=='compatibility'})
assert deps=={str(p.resolve()):sha(p) for p in paths}
(OUT/'current-trumpet-battle-flip-batch.json').write_text(json.dumps({'status':'TRUMPET_BATTLE_DAMAGE_STEP_REPAIRED','runtime_dependencies_sha256':deps,'runs':runs,'ruling':'https://www.db.yugioh-card.com/yugiohdb/faq_search.action?cid=12345&ope=4&request_locale=ja','scope':'Full original Trumpet/current installed metadata/corrected public transport/no Lua API adapter. Natural opponent battle destroys own neutral Pendulum defender: initial faceup or actual facedown-to-faceup battle flip, native destruction move to faceup Extra, actual Hand-to-MZone source summon. Wrong-set/nonPendulum excluded. Original missing Damage Step permission and omitted Hand summon each fail both positives. Source starts Hand; initial neutral defender, no recipient recipe/full-card/live Omega claim.'},indent=2)+'\n');print('Trumpet destroyed-visibility repair verified')

import hashlib,json,re,subprocess
from pathlib import Path
ROOT=Path.cwd();OUT=ROOT/'output/fresh-ccg-september';FILES=Path(r'C:\Program Files (x86)\YGO Omega\YGO Omega_Data\Files')
def sha(p):return hashlib.sha256(p.read_bytes()).hexdigest()
manifest=OUT/'shuffle-visibility-repair-files.json';items=json.loads(manifest.read_text())['files'];back=OUT/'shuffle-visibility-before-repair';reviewed=[219419648,238272436,259475154,259640854,259669838]
paths=[Path(__file__).resolve(),manifest,FILES/'Databases/CCG_v1.db',ROOT/'src/data/cards.json']+[ROOT/'public/CCG Downloads/CCG_Scripts'/f'c{c}.lua' for c in reviewed]+[ROOT/'scripts'/n for n in ['fresh_current_nether_shuffle_visibility.cjs','fresh_current_triceron_shuffle_visibility.cjs','fresh_nether_shuffle_visibility_repair.cjs','fresh_underroot_nether_shuffle.cjs','fresh_current_meadow_events.cjs','fresh_installed_card.cjs','fresh_corrected_card_data_transport.cjs']]+[ROOT/'tmp/omega_scripts'/n for n in ['constant.lua','utility.lua','procedure.lua']]+list((ROOT/'node_modules/@n1xx1/ocgcore-wasm/dist').glob('*.js'))+[ROOT/'node_modules/@n1xx1/ocgcore-wasm/dist/index-card-data-transport-candidate.mjs']
for item in items:
 p=ROOT/'public/CCG Downloads/CCG_Scripts'/item['file'];old=back/p.name;assert sha(p)==item['after_sha256'] and sha(old)==item['before_sha256'] and p.read_bytes()==(FILES/'Scripts'/p.name).read_bytes() and old.read_bytes()==(back/('installed-'+p.name)).read_bytes()
 r=subprocess.run(['node','-e',"process.stdout.write(require('./scripts/fresh_nether_shuffle_visibility_repair.cjs').corrected(require('fs').readFileSync(process.argv[1],'utf8'),Number(process.argv[2])))",str(old),str(item['passcode'])],capture_output=True);assert r.returncode==0 and r.stdout==p.read_bytes();paths += [old,back/('installed-'+p.name)]
deps={str(p.resolve()):sha(p) for p in paths};runs=[]
jobs=[]
for official in [False,True]:
 for control,expected in [(None,[]),('old-source',[1]),('no-shuffle',[0,1])]:
  flags=(['--official-traps'] if official else [])+(['--'+control] if control else []);name='current-nether-shuffle-visibility'+('-'+control if control else '')+('-official-traps' if official else '')
  jobs.append(('nether',flags,name,expected,False))
for control,expected in [(None,[]),('old-source',[1]),('no-shuffle',[0,1])]:
 flags=['--mapped-targets']+(['--'+control] if control else []);name='current-triceron-shuffle-visibility'+('-no-shuffle' if control=='no-shuffle' else '')+'-mapped'+('-old-source' if control=='old-source' else '')
 jobs.append(('triceron',flags,name,expected,False))
jobs.append(('triceron',[],'current-triceron-shuffle-visibility-unadapted',[0,1],True))
for fixture,flags,name,expected,compat in jobs:
 r=subprocess.run(['node','--no-warnings',f'scripts/fresh_current_{fixture}_shuffle_visibility.cjs']+flags,capture_output=True,text=True,timeout=20);p=OUT/(name+'.json');d=json.loads(p.read_text());assert len(d['results'])==2 and [i for i,v in enumerate(d['results']) if v['failure']]==expected,(flags,r.stdout+r.stderr);assert r.returncode==bool(expected)
 for v in d['results']:
  if compat:assert any('Passed invalid CHAININFO flag' in x['message'] for x in v['logs']) and all(x['type'] in [0,2] for x in v['logs'])
  else:assert not v['logs']
 runs.append({'artifact':p.name,'sha256':sha(p),'expected_failures':expected,'known_compatibility_failure':compat})
assert deps=={str(p.resolve()):sha(p) for p in paths}
(OUT/'current-shuffle-visibility-batch.json').write_text(json.dumps({'status':'NETHER_TRICERON_FACEDOWN_BANISH_SHUFFLE_REPAIRED','runtime_dependencies_sha256':deps,'runs':runs,'same_pattern_reviewed':reviewed,'same_pattern_confirmed':[238272436,259640854],'review':'Other matching raw filters used only for GY or Deck despite unrelated banishment callers elsewhere in file. Nether rroot/named whitelist and Triceron Dinomorphia Trap shuffle alone use these predicates in GY+banishment. Static other-card review only.','ruling':{'url':'https://www.db.yugioh-card.com/yugiohdb/faq_search.action?cid=12655&ope=4&request_locale=ja&sort=2','inference':'Official analogous information-based banished-monster selection explicitly face-up. Face-down cards lack usable name/archetype/type for these custom-card-specific filters; not a direct official custom-card ruling.'},'scope':'Full original/current installed metadata/corrected public engine. Nether native GY self-banish cost, initially field-seeded Fusion/Synchro type count, GY/faceup archetype and explicit named Trap whitelist resource menus/moves; hidden banishment excluded. Triceron actual Quick LP cost/own+opponent target destruction/Trap shuffle uses explicit TARGET_CARDS8 test mapping; unadapted invalid-flag failures retained separately. Exact source/install backups/helper/manifest/parity, original failures and omitted-shuffle controls. No production constants changed, no original Fusion/Synchro history/full-card/live Omega certification.'},indent=2)+'\n');print('Nether/Triceron shuffle visibility repairs verified; mapped compatibility kept separate')

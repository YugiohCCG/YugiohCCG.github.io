import hashlib,json,re,subprocess
from pathlib import Path
ROOT=Path.cwd();OUT=ROOT/'output/fresh-ccg-september';FILES=Path(r'C:\Program Files (x86)\YGO Omega\YGO Omega_Data\Files')
def sha(p):return hashlib.sha256(p.read_bytes()).hexdigest()
manifest=OUT/'public-reveal-repair-files.json';repairs=json.loads(manifest.read_text());codes=[v['passcode'] for v in repairs['files']];backup=OUT/'glitchling-before-public-reveal-repair'
paths=[Path(__file__).resolve(),ROOT/'scripts/fresh_current_glitchling_monster.cjs',ROOT/'scripts/fresh_installed_card.cjs',ROOT/'scripts/fresh_corrected_card_data_transport.cjs',ROOT/'src/data/cards.json',FILES/'Databases/CCG_v1.db',ROOT/'node_modules/@n1xx1/ocgcore-wasm/dist/index-card-data-transport-candidate.mjs',manifest]+[ROOT/f'public/CCG Downloads/CCG_Scripts/c{c}.lua' for c in codes]+list(backup.glob('*.lua'))+[ROOT/'tmp/omega_scripts'/n for n in ['constant.lua','utility.lua','procedure.lua']]+list((ROOT/'node_modules/@n1xx1/ocgcore-wasm/dist').glob('*.js'))
before={str(p.resolve()):sha(p) for p in paths};runs=[]
plans=[([],None,[],17),([],'old-source',[7,15],17),([],'no-search',[0,6,9],17),([],'no-lock',[0,4,6,9,13],17),([],'no-activity',[3,12],17),(['--reveal-family'],None,[],16),(['--reveal-family'],'old-source',[1,4,7,10,14],16)]
for args,control,expected,count in plans:
 r=subprocess.run(['node','--no-warnings','scripts/fresh_current_glitchling_monster.cjs']+args+(['--'+control] if control else []),capture_output=True,text=True,timeout=20)
 p=OUT/('current-glitchling-monster'+('-reveal-family' if args else '')+('-'+control if control else '')+'.json');d=json.loads(p.read_text());assert len(d['results'])==count,(args,control,r.stdout+r.stderr)
 assert [i for i,v in enumerate(d['results']) if v['failure']]==expected,(args,control,r.stdout+r.stderr)
 assert r.returncode==bool(expected)
 for v in d['results']:
  if v['failure'] and (control=='no-lock' or args and control=='old-source'):assert ('Monster activation oath mismatch' if control=='no-lock' else 'Reveal cost public/private eligibility mismatch') in v['failure']
  else:assert not v['logs']
 runs.append({'args':args,'control':control,'artifact':p.name,'sha256':sha(p),'expected_failures':expected})
assert before=={str(p.resolve()):sha(p) for p in paths}
for v in repairs['files']:
 p=ROOT/'public/CCG Downloads/CCG_Scripts'/v['file'];assert sha(p)==v['after_sha256'];assert p.read_bytes()==(FILES/'Scripts'/p.name).read_bytes();assert sha(backup/p.name)==v['before_sha256'];assert (backup/p.name).read_bytes()==(backup/('installed-'+p.name)).read_bytes()
review=[]
for p in (ROOT/'public/CCG Downloads/CCG_Scripts').glob('*.lua'):
 text=p.read_text(encoding='utf-8');functions=list(re.finditer(r'function s\.(\w+)\(',text));bodies={m.group(1):text[m.start():functions[i+1].start() if i+1<len(functions) else len(text)] for i,m in enumerate(functions)}
 for name in set(re.findall(r':SetCost\(s\.(\w+)\)',text)):
  if 'ConfirmCards' in bodies.get(name,''):review.append({'file':p.name,'cost':name,'source_sha256':sha(p)})
report={'status':'PUBLIC_REVEAL_COST_FAMILY_REPAIRED','runtime_dependencies_sha256':before,'runs':runs,'cards':codes,'scope':'Witch/Mage full-source native searches, actual two-card reveal, source/partner public controls, named shared use, genuine Hand-field-faceup Extra-Hand search path, prior forbidden summon exclusion, allowed categories, effect/activation negation and actual next-turn oath expiry. Five sibling scripts have bounded production cost chk0 calls under native public/private/wrong-set states plus Protogenesis Deck control; not their full effects. No Lua API adapters. Exact backups, current source/install parity. Other Glitchling Ritual/Leotron monster branches and live Omega remain open.','ruling_basis':{'url':'https://www.db.yugioh-card.com/yugiohdb/faq_search.action?fid=20844&ope=5&request_locale=ja','application':'Already-public Hand cards cannot pay a reveal cost. Guards are restricted to reveal-cost selection; generic summon/material filters unchanged.'},'same_pattern_review':{'direct_reveal_costs':review,'notes':'Swept all source SetCost functions containing ConfirmCards and reviewed referenced Hand selectors. Seven confirmed Hand reveal-cost omissions fixed. Extra/Deck demonstrations and non-cost reveals kept distinct. Other guarded costs retained. Reveal-in-target copying effects, including World Legacy Surfacing, remain a separate full-roster review question; no unconfirmed patch applied.'}}
(OUT/'current-glitchling-monster-batch.json').write_text(json.dumps(report,indent=2)+'\n',encoding='utf-8');print('Reveal-cost family repairs/native search checks verified; bounded sibling evidence and parity retained')

import hashlib,json,subprocess
from pathlib import Path
ROOT=Path.cwd();OUT=ROOT/'output/fresh-ccg-september';FILES=Path(r'C:\Program Files (x86)\YGO Omega\YGO Omega_Data\Files')
def sha(p):return hashlib.sha256(p.read_bytes()).hexdigest()
manifest=OUT/'ritual-revival-repair-files.json';items=json.loads(manifest.read_text())['files'];backup=OUT/'ritual-before-revival-limit-repair'
families=[('glitchling-ritual-followup',26,{'no-material':[0,1,2,4,8,9,11,13,14,16,24],'no-complete':[0,2,4,8,9,11,13,16,24],'no-response':[10,12,23,25]}),('ritual-revival-family',27,{'old-source':[0,3,4,7,10,13,16,19,20,23,26],'no-revive':[0,3,4,7,10,13,16,19,20,23,26]}),('glitchling-leotron-monster',16,{'old-source':[0,1,2,3,6],'no-normal':[0,1,2,3,4,5],'no-follow':[0,1,2,3],'no-negate':[8,9,10,15],'no-cost':[8,9,10,15],'no-cap':[8,9,10]})]
paths=[Path(__file__).resolve(),manifest,ROOT/'src/data/cards.json',FILES/'Databases/CCG_v1.db']+[ROOT/'scripts'/('fresh_current_'+name.replace('-','_')+'.cjs') for name,_,_ in families]+[ROOT/'scripts'/n for n in ['fresh_installed_card.cjs','fresh_corrected_card_data_transport.cjs']]+[ROOT/'public/CCG Downloads/CCG_Scripts'/v['file'] for v in items]+list(backup.glob('*.lua'))+[ROOT/'tmp/omega_scripts'/n for n in ['constant.lua','utility.lua','procedure.lua']]+list((ROOT/'node_modules/@n1xx1/ocgcore-wasm/dist').glob('*.js'))+[ROOT/'node_modules/@n1xx1/ocgcore-wasm/dist/index-card-data-transport-candidate.mjs']
before={str(p.resolve()):sha(p) for p in paths};runs=[]
for name,count,controls in families:
 for control,expected in [(None,[])]+list(controls.items()):
  r=subprocess.run(['node','--no-warnings','scripts/fresh_current_'+name.replace('-','_')+'.cjs']+(['--'+control] if control else []),capture_output=True,text=True,timeout=30)
  p=OUT/('current-'+name+('-'+control if control else '')+'.json');d=json.loads(p.read_text());assert len(d['results'])==count and [i for i,v in enumerate(d['results']) if v['failure']]==expected,(name,control,r.stdout+r.stderr)
  assert r.returncode==bool(expected)
  for v in d['results']:
   if not v['failure']:assert not v['logs']
  runs.append({'fixture':name,'control':control,'artifact':p.name,'sha256':sha(p),'expected_failures':expected})
assert before=={str(p.resolve()):sha(p) for p in paths}
for v in items:
 p=ROOT/'public/CCG Downloads/CCG_Scripts'/v['file'];assert sha(p)==v['after_sha256'] and p.read_bytes()==(FILES/'Scripts'/p.name).read_bytes();assert sha(backup/p.name)==v['before_sha256'] and (backup/p.name).read_bytes()==(backup/('installed-'+p.name)).read_bytes()
assert not any('SetValue(aux.ritlimit)' in p.read_text(encoding='utf-8') for p in (ROOT/'public/CCG Downloads/CCG_Scripts').glob('*.lua'))
report={'status':'RITUAL_REVIVAL_FAMILY_REPAIRED','cards':[v['passcode'] for v in items],'runtime_dependencies_sha256':before,'runs':runs,'scope':'Native public engine, full affected scripts, installed metadata, corrected transport; no Lua API adapter. Witch/Mage Ritual followups and Leotron recruitment/negation tested with actual payment, origins and interruptions. Neutral fixed paid Ritual setup; three named normals use neutral metadata. Native revive limit still rejects unprepared Hand/GY. Original-source failures and actual revival controls retained. No general named Ritual Spell, counter supplementation, complete-card or live Omega certification.','same_pattern_review':'All eight source aux.ritlimit restrictions removed; native EnableReviveLimit retained. No remaining matching restriction. Other summon families require individual text review.','ruling_basis':'https://www.yugioh-card.com/en/play/psct/psct-5/'}
(OUT/'current-glitchling-followup-batch.json').write_text(json.dumps(report,indent=2)+'\n',encoding='utf-8');print('Ritual revival fixes and grouped followups verified')

import hashlib,json,subprocess
from pathlib import Path
ROOT=Path.cwd();OUT=ROOT/'output/fresh-ccg-september';FILES=Path(r'C:\Program Files (x86)\YGO Omega\YGO Omega_Data\Files')
def sha(p):return hashlib.sha256(p.read_bytes()).hexdigest()
review=[215034223,218142234,227362839,230947464,238273768,238273772,244986323,245935439,248760718,256928871,259225324,259882493,284636589,284639717,284639718,284639719,215105971,244163204,250556612]
backup=OUT/'pendulum-before-placement-relation-repair'
paths=[Path(__file__).resolve(),ROOT/'scripts/fresh_current_origins_placement.cjs',ROOT/'scripts/fresh_current_origins_monster.cjs',ROOT/'scripts/fresh_installed_card.cjs',ROOT/'scripts/fresh_corrected_card_data_transport.cjs',ROOT/'src/data/cards.json',FILES/'Databases/CCG_v1.db',ROOT/'node_modules/@n1xx1/ocgcore-wasm/dist/index-card-data-transport-candidate.mjs']+[ROOT/f'public/CCG Downloads/CCG_Scripts/c{code}.lua' for code in [244986323,218142234]]+[ROOT/'tmp/omega_scripts'/n for n in ['constant.lua','utility.lua','procedure.lua']]+list((ROOT/'node_modules/@n1xx1/ocgcore-wasm/dist').glob('*.js'))+list(backup.glob('*.lua'))
before={str(p.resolve()):sha(p) for p in paths};runs=[]
plans=[('placement',[],None,[],11),('placement',[],'old-source',[2,3],11),('placement',[],'no-placement',[0,1,7,10],11),('placement',['--card=218142234'],None,[],11),
 ('monster',[],None,[],16),('monster',[],'old-cost',[3],16),('monster',[],'no-detach',[0,1,2,3,7,8,9],16),('monster',[],'no-destroy',[0,1,3,8],16),('monster',[],'no-banish',[0,1,3,8],16),('monster',[],'no-protect',[10,11],16),
 ('monster',['--overlay-compat'],None,[],8),('monster',['--overlay-compat'],'no-attach',[0,1,4,7],8),('monster',['--xyz-compat'],None,[],5),('monster',['--xyz-compat'],'two-material',[2,3,4],5),('monster',['--omega-helper-probe'],None,[0],1),('monster',['--overlay-helper-probe'],None,[0],1)]
for family,args,control,expected,count in plans:
 r=subprocess.run(['node','--no-warnings',f'scripts/fresh_current_origins_{family}.cjs']+args+(['--'+control] if control else []),capture_output=True,text=True,timeout=20)
 suffix='-218142234' if family=='placement' and args else '-xyz-compat' if '--xyz-compat' in args else '-overlay-compat' if '--overlay-compat' in args else '-omega-helper-probe' if '--omega-helper-probe' in args else '-overlay-helper-probe' if '--overlay-helper-probe' in args else ''
 p=OUT/('current-origins-'+family+suffix+('-'+control if control else '')+'.json');d=json.loads(p.read_text(encoding='utf-8'));assert len(d['results'])==count,(family,args,control,r.stdout+r.stderr)
 assert [i for i,v in enumerate(d['results']) if v['failure']]==expected,(family,args,control,r.stdout+r.stderr)
 assert r.returncode==bool(expected)
 probe=any(a.endswith('helper-probe') for a in args)
 if probe:assert ('CheckXyzMaterial' if '--omega-helper-probe' in args else 'IsCanOverlay') in d['results'][0]['failure']
 else:assert all(not v['logs'] for v in d['results'])
 runs.append({'family':family,'args':args,'control':control,'artifact':p.name,'sha256':sha(p),'expected_failures':expected,'compatibility_probe':probe,'lua_api_adapter':any(a.endswith('-compat') for a in args)})
assert before=={str(p.resolve()):sha(p) for p in paths}
source=ROOT/'public/CCG Downloads/CCG_Scripts/c244986323.lua';assert source.read_bytes()==(FILES/'Scripts'/source.name).read_bytes()
assert (backup/source.name).read_bytes()==(backup/('installed-'+source.name)).read_bytes()
assert (backup/('before-empty-gy-'+source.name)).read_bytes()==(backup/('installed-before-empty-gy-'+source.name)).read_bytes()
report={'status':'ORIGINS_TWO_BOUNDED_REPAIRS_VERIFIED','runtime_dependencies_sha256':before,'runs':runs,
 'scope':'Origins self-placement relation and empty-GY activation repaired in source/local Omega. No-adapter native cases verify placement with actual moved-source/negation/zone controls; real detach/destroy/banish (including GY-empty after setup, redirects and GY banish lock), actual opposing Spell/Trap targeting exclusion and allowed own/Monster/wrong-set/wrong-side controls. Attachment Flip/opponent GY and native Xyz3/4 summon plus Special-summon attachment use explicit bounded legacy API adapters, with separate unadapted failure probes. Not general recipes/live Omega/full-card certification; named use/reset and natural Pendulum summon history beyond these cases not certified.',
 'same_pattern_review':{'source_snapshot_sha256':{str(code):sha(ROOT/f'public/CCG Downloads/CCG_Scripts/c{code}.lua') for code in review},'cards':review,'placement':'All self-placement callers reviewed; Origins lacked source relation guard. Seraphina full-source no-adapter family cases pass. Spark/Embers already guard relation/faceup; Mega Staar/Vaylantz guard relation; other calls select a fresh card rather than recover the original handler. Ineffective Extra-to-Extra shuffle was excluded; only actual GY/banish moves prove the bug.', 'cost':'Four detach plus GY banish candidates reviewed. Killamity draw has no GY candidate requirement; NiuHao banishes detached materials instead of GY. Urphiel has a combined detach-and-banish cost, a different timing question not confirmed by Origins regression; unchanged for later full-card audit.'},
 'ruling_basis':{'url':'https://www.db.yugioh-card.com/yugiohdb/faq_search.action?fid=11724&ope=5&request_locale=ja','application':'Inference from official Emeral cost ruling: candidates created by paying detach cost can make a GY-dependent activation legal. Origins now predicts eligible detached cards while preserving redirect/Necrovalley exclusions.'}}
(OUT/'current-origins-batch.json').write_text(json.dumps(report,indent=2)+'\n',encoding='utf-8');print('Origins grouped native/compatibility evidence and original-source failures verified; installed parity confirmed')

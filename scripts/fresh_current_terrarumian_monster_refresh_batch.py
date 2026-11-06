import hashlib,json,subprocess
from pathlib import Path
ROOT=Path.cwd();OUT=ROOT/'output/fresh-ccg-september';FILES=Path(r'C:\Program Files (x86)\YGO Omega\YGO Omega_Data\Files')
def sha(p):return hashlib.sha256(p.read_bytes()).hexdigest()
plans={'cushion_destroyed':(2,[1]),'coin_banish':(2,[0,1]),'sword_fern_set':(3,[0,1,2]),'nerve_destroy':(4,[0,1,2]),'staghorn_destroyed':(5,[0,1,2,3]),'ivy_destroyed':(5,[0,1,2,3]),'trumpet_hand':(3,[0]),'trumpet_battle_chain':(4,[1,2,3])}
paths=[Path(__file__).resolve(),ROOT/'scripts/fresh_current_terrarumian_monster_refresh.cjs',ROOT/'scripts/fresh_installed_card.cjs',ROOT/'scripts/fresh_corrected_card_data_transport.cjs',ROOT/'src/data/cards.json',FILES/'Databases/CCG_v1.db',OUT/'candidate-CCG_v1.db']+[ROOT/'scripts'/('fresh_terrarumian_'+n+'.cjs') for n in plans]+[ROOT/'public/CCG Downloads/CCG_Scripts'/f'c{c}.lua' for c in range(284639717,284639725)]+[ROOT/'tmp/omega_scripts'/n for n in ['constant.lua','utility.lua','procedure.lua']]+list((ROOT/'node_modules/@n1xx1/ocgcore-wasm/dist').glob('*.js'))+[ROOT/'node_modules/@n1xx1/ocgcore-wasm/dist/index-card-data-transport-candidate.mjs']
before={str(p.resolve()):sha(p) for p in paths};runs=[]
for name,(count,expected) in plans.items():
 for control in [None,'no-operation']:
  r=subprocess.run(['node','--no-warnings','scripts/fresh_current_terrarumian_monster_refresh.cjs',name]+(['--'+control] if control else []),capture_output=True,text=True,timeout=20)
  p=OUT/('current-terrarumian-'+name.replace('_','-')+('-'+control if control else '')+'.json');d=json.loads(p.read_text());actual=[i for i,v in enumerate(d['results']) if v['failure']]
  assert len(d['results'])==count and actual==(expected if control else []) and all(not v['logs'] for v in d['results']),(name,control,r.stdout+r.stderr,len(d['results']))
  assert r.returncode==bool(actual)
  runs.append({'fixture':name,'control':control,'artifact':p.name,'sha256':sha(p),'expected_failures':actual})
assert before=={str(p.resolve()):sha(p) for p in paths}
assert all((ROOT/'public/CCG Downloads/CCG_Scripts'/f'c{c}.lua').read_bytes()==(FILES/'Scripts'/f'c{c}.lua').read_bytes() for c in range(284639717,284639725))
report={'status':'BOUNDED_NATIVE_MONSTER_REFRESH','runtime_dependencies_sha256':before,'runs':runs,'scope':'Reused eight historical scenarios with full current production scripts, actual installed metadata and corrected public-engine transport; no Lua API adapter. Native destruction search, Coin GY/temporary Hand banishment and End Phase return, Sword/Nerve normal/special/destroyed triggers, Staghorn Deck/field sending, Ivy revival/negation, Trumpet Hand recruitment and Battle Phase opponent-activation/direct-damage branches with shared count. Controls disable tested operation only. Neutral support cards retain historical metadata. Old candidate DB still read for legacy construction, but all production cardReader returns overridden by installed reader. No direct Extra seeding conclusion relied on. Not interruption/use/reset completion, full-card or live Omega certification. Sundew historical test stamps SUMMON_TYPE_PENDULUM via ordinary SpecialSummon and must be replaced with natural Pendulum procedure evidence before certification.'}
(OUT/'current-terrarumian-monster-refresh-batch.json').write_text(json.dumps(report,indent=2)+'\n',encoding='utf-8');print('Bounded Terrarumian monster evidence refreshed; controls verified')


import hashlib,json,subprocess
from pathlib import Path
ROOT=Path.cwd();OUT=ROOT/'output/fresh-ccg-september'
def sha(p):return hashlib.sha256(p.read_bytes()).hexdigest()
paths=[Path(__file__).resolve(),ROOT/'src/data/cards.json',ROOT/'node_modules/@n1xx1/ocgcore-wasm/dist/index-card-data-transport-candidate.mjs',ROOT/'scripts/fresh_native_two_material_synchro.cjs',ROOT/'scripts/fresh_current_symphonic_ddj_hand_monster.cjs',ROOT/'scripts/fresh_current_symphonic_ddj_flip_lifecycle.cjs',ROOT/'scripts/fresh_installed_card.cjs',ROOT/'scripts/fresh_corrected_card_data_transport.cjs',ROOT/'public/CCG Downloads/CCG_Scripts/c238273769.lua',Path(r'C:\Program Files (x86)\YGO Omega\YGO Omega_Data\Files\Databases\CCG_v1.db')]+[ROOT/'tmp/omega_scripts'/n for n in ['constant.lua','utility.lua','procedure.lua']]+list((ROOT/'node_modules/@n1xx1/ocgcore-wasm/dist').glob('*.js'))
before={str(p.resolve()):sha(p) for p in paths};runs=[]
for fixture,flag,expected in [('hand-monster',None,[]),('hand-monster','no-search',[0,3,4]),('hand-monster','no-hand-summon',[0,4,5]),('hand-monster','synchro-probe',[0,1]),('hand-monster','native-synchro',[]),('hand-monster','native-synchro-no-immediate',[0]),('flip-lifecycle',None,[]),('flip-lifecycle','per-copy',[0]),('flip-lifecycle','no-reset',[0]),('flip-lifecycle','no-expiry',[0])]:
 script='scripts/fresh_current_symphonic_ddj_'+fixture.replace('-','_')+'.cjs'
 r=subprocess.run(['node','--no-warnings',script]+(['--native-synchro','--no-immediate'] if flag=='native-synchro-no-immediate' else ['--'+flag] if flag else []),capture_output=True,text=True,timeout=20)
 p=OUT/('current-symphonic-ddj-'+fixture+('-'+flag if flag else '')+'.json');d=json.loads(p.read_text())
 assert [i for i,v in enumerate(d['results']) if v['failure']]==expected,(fixture,flag,r.stdout+r.stderr)
 assert r.returncode==bool(expected)
 if flag=='synchro-probe':assert all('CheckSynchroMaterial' in v['failure'] for v in d['results'])
 elif flag=='no-expiry':assert 'WIND lock failed to expire' in d['results'][0]['failure']
 else:assert all(not v['logs'] for v in d['results'])
 runs.append({'fixture':fixture,'flag':flag,'artifact':p.name,'sha256':sha(p),'expected_failures':expected,'compatibility_blocker':flag=='synchro-probe'})
assert before=={str(p.resolve()):sha(p) for p in paths}
assert (ROOT/'public/CCG Downloads/CCG_Scripts/c238273769.lua').read_bytes()==Path(r'C:\Program Files (x86)\YGO Omega\YGO Omega_Data\Files\Scripts\c238273769.lua').read_bytes()
(OUT/'current-symphonic-ddj-monster-batch.json').write_text(json.dumps({'status':'PARTIAL_NATIVE_WITH_SYNCHRO_COMPATIBILITY_BLOCKER','runtime_dependencies_sha256':before,'runs':runs,'scope':'Current installed metadata, complete DDJ source, corrected test transport, no Lua API adapter. Hand Quick summon eligibility/full field/named shared use; Normal/Special summon search including self and no candidate. Flip named shared use/reset across actual turns, restriction expiry with real DARK Extra summon. Immediate Synchro accept/decline and Pendulum material redirect now verified with a neutral native fixed two-material recipe; accepted material leaves field before delayed summon-search trigger window, while decline permits search. Unadapted Omega helper still blocked by missing public-engine Duel.CheckSynchroMaterial; no live Omega certification; no production changes.'},indent=2)+'\n')
print('DDJ native fixed-recipe immediate Synchro verified; Omega helper incompatibility remains distinct')

import hashlib,json,subprocess
from pathlib import Path
ROOT=Path.cwd();OUT=ROOT/'output/fresh-ccg-september'
def sha(p):return hashlib.sha256(p.read_bytes()).hexdigest()
paths=[Path(__file__).resolve(),ROOT/'scripts/fresh_corrected_card_data_transport.cjs',ROOT/'scripts/fresh_installed_card.cjs',Path(r'C:\Program Files (x86)\YGO Omega\YGO Omega_Data\Files\Databases\CCG_v1.db'),ROOT/'src/data/cards.json',ROOT/'node_modules/@n1xx1/ocgcore-wasm/dist/index-card-data-transport-candidate.mjs']+[ROOT/'scripts/fresh_current_talismandrake_embers_summon_draw.cjs']+[ROOT/'public/CCG Downloads/CCG_Scripts'/f'c{code}.lua' for code in [256928871]]+[ROOT/'tmp/omega_scripts'/name for name in ['constant.lua','utility.lua','procedure.lua']]+list((ROOT/'node_modules/@n1xx1/ocgcore-wasm/dist').glob('*.js'))
before={str(p.resolve()):sha(p) for p in paths};runs=[]
for flag,expected in [(None,[]),('no-draw',[0,1,2]),('allow-self-name',[4]),('allow-set',[5]),('allow-facedown',[6]),('unadapted',[0,1,2])]:
 r=subprocess.run(['node','--no-warnings','scripts/fresh_current_talismandrake_embers_summon_draw.cjs']+([] if flag=='unadapted' else ['--chaininfo-compat'])+(['--'+flag] if flag and flag!='unadapted' else []),capture_output=True,text=True,timeout=20)
 p=OUT/('current-talismandrake-embers-summon-draw'+('' if flag=='unadapted' else '-chaininfo-compat')+('-'+flag if flag and flag!='unadapted' else '')+'.json');d=json.loads(p.read_text())
 assert len(d['results'])==9,r.stdout+r.stderr
 assert [i for i,v in enumerate(d['results']) if v['failure']]==expected,(flag,r.stdout)
 if flag=='unadapted':assert all(any('invalid CHAININFO' in v['message'] for v in d['results'][i]['logs']) for i in expected)
 else:assert all(not v['logs'] for v in d['results'])
 assert r.returncode==(1 if expected else 0)
 runs.append({'flag':flag,'artifact':p.name,'artifact_sha256':sha(p),'expected_failures':expected})

assert before=={str(p.resolve()):sha(p) for p in paths}
inst=Path(r'C:\Program Files (x86)\YGO Omega\YGO Omega_Data\Files\Scripts')
for code in [256928871]:assert (ROOT/'public/CCG Downloads/CCG_Scripts'/f'c{code}.lua').read_bytes()==(inst/f'c{code}.lua').read_bytes()
(OUT/'current-talismandrake-embers-summon-draw-batch.json').write_text(json.dumps({'status':'VERIFIED_PARTIAL_COMPATIBILITY_DIAGNOSTIC','baseline_cases':9,'runtime_dependencies_sha256':before,'runs':runs,'scope':'Full Embers/actual installed metadata/corrected transport; actual Normal/Special/Flip Summon draw with eligible faceup different-name Talismandrake. Noally/samename/wrongset/facedown/opponent/PZone allies excluded. Explicit test-only CHAININFO target-player=9/param=10 mapping for modern public engine; unadapted all3 positive cases reproduce invalid CHAININFO. Controls noDraw3/allowSelf1/allowSet1/allowFacedown1 exact failures. Native Omega/shared limits/interruptions/fullcard open.'},indent=2)+'\n',encoding='utf-8');print('Embers9SummonDrawCOMPATPASS;controls3/1/1/1 verified; unadapted3compat failures; frozeninputs/parity')

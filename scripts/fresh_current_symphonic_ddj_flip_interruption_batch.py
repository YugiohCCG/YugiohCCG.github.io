import hashlib,json,subprocess
from pathlib import Path
ROOT=Path.cwd();OUT=ROOT/'output/fresh-ccg-september'
def sha(p):return hashlib.sha256(p.read_bytes()).hexdigest()
paths=[Path(__file__).resolve(),ROOT/'scripts/fresh_corrected_card_data_transport.cjs',ROOT/'scripts/fresh_installed_card.cjs',Path(r'C:\Program Files (x86)\YGO Omega\YGO Omega_Data\Files\Databases\CCG_v1.db'),ROOT/'src/data/cards.json',ROOT/'node_modules/@n1xx1/ocgcore-wasm/dist/index-card-data-transport-candidate.mjs']+[ROOT/'scripts/fresh_current_symphonic_ddj_flip_interruption.cjs']+[ROOT/'public/CCG Downloads/CCG_Scripts'/f'c{code}.lua' for code in [238273769]]+[ROOT/'tmp/omega_scripts'/name for name in ['constant.lua','utility.lua','procedure.lua']]+list((ROOT/'node_modules/@n1xx1/ocgcore-wasm/dist').glob('*.js'))
before={str(p.resolve()):sha(p) for p in paths};runs=[]
for flag,expected in [(None,[]),('no-response',list(range(1,8))),('no-summon',[0,3,5]),('no-lock',[0,3,4,5,6,7])]:
 r=subprocess.run(['node','--no-warnings','scripts/fresh_current_symphonic_ddj_flip_interruption.cjs']+(['--'+flag] if flag else []),capture_output=True,text=True,timeout=20)
 p=OUT/('current-symphonic-ddj-flip-interruption'+('-'+flag if flag else '')+'.json');d=json.loads(p.read_text())
 assert len(d['results'])==8 and all(not v['logs'] for v in d['results']),r.stdout+r.stderr
 assert [i for i,v in enumerate(d['results']) if v['failure']]==expected,(flag,r.stdout)
 assert r.returncode==(1 if expected else 0)
 runs.append({'flag':flag,'artifact':p.name,'artifact_sha256':sha(p),'expected_failures':expected})

assert before=={str(p.resolve()):sha(p) for p in paths}
inst=Path(r'C:\Program Files (x86)\YGO Omega\YGO Omega_Data\Files\Scripts')
for code in [238273769]:assert (ROOT/'public/CCG Downloads/CCG_Scripts'/f'c{code}.lua').read_bytes()==(inst/f'c{code}.lua').read_bytes()
(OUT/'current-symphonic-ddj-flip-interruption-batch.json').write_text(json.dumps({'status':'VERIFIED_PARTIAL_NATIVE_SECONDARY_EFFECT','baseline_cases':8,'runtime_dependencies_sha256':before,'runs':runs,'scope':'Full DDJ/installedmetadata/correctedtransport/no Lua API adapter. Eight actual Flip trigger cases baseline/CL2 negate activation/effect/source banish/Deck candidate banish/replacement/late full field/specific recruit lock. Recruit faceDownDEF where legal. WIND Extra lock independently applies on successful resolution even when recruitment fails or source leaves, not after either negation. Native future Extra eligibility/actual WIND SS and negated DARK SS checked (latefull callback only). All player effects scanned to identify relevant WIND lock. Controls7/3/6 exact semantic failures/emptylogs/frozeninputs/parity. Neutral summons not general Extra recipes/liveOmega/fullcard certification.'},indent=2)+'\n',encoding='utf-8');print('DDJ8FlipInterruptionNATIVEPASS;controls7/3/6verified; frozeninputs/parity')

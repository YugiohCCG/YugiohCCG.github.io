import hashlib,json,subprocess
from pathlib import Path
ROOT=Path.cwd();OUT=ROOT/'output/fresh-ccg-september'
def sha(p):return hashlib.sha256(p.read_bytes()).hexdigest()
paths=[Path(__file__).resolve(),ROOT/'scripts/fresh_corrected_card_data_transport.cjs',ROOT/'scripts/fresh_installed_card.cjs',Path(r'C:\Program Files (x86)\YGO Omega\YGO Omega_Data\Files\Databases\CCG_v1.db'),ROOT/'src/data/cards.json',ROOT/'node_modules/@n1xx1/ocgcore-wasm/dist/index-card-data-transport-candidate.mjs']+[ROOT/'scripts/fresh_current_symphonic_speeaker_recruit.cjs']+[ROOT/'public/CCG Downloads/CCG_Scripts'/f'c{code}.lua' for code in [238273768]]+[ROOT/'tmp/omega_scripts'/name for name in ['constant.lua','utility.lua','procedure.lua']]+list((ROOT/'node_modules/@n1xx1/ocgcore-wasm/dist').glob('*.js'))
before={str(p.resolve()):sha(p) for p in paths};runs=[]
for flag,expected in [(None,[]),('no-summon',[0,1,2,3,7]),('allow-set',[4]),('allow-grave',[5]),('no-extra-capacity',[7])]:
 r=subprocess.run(['node','--no-warnings','scripts/fresh_current_symphonic_speeaker_recruit.cjs']+(['--'+flag] if flag else []),capture_output=True,text=True,timeout=20)
 p=OUT/('current-symphonic-speeaker-recruit'+('-'+flag if flag else '')+'.json');d=json.loads(p.read_text())
 assert len(d['results'])==10 and all(not v['logs'] for v in d['results']),r.stdout+r.stderr
 assert [i for i,v in enumerate(d['results']) if v['failure']]==expected,(flag,r.stdout)
 assert r.returncode==(1 if expected else 0)
 runs.append({'flag':flag,'artifact':p.name,'artifact_sha256':sha(p),'expected_failures':expected})

assert before=={str(p.resolve()):sha(p) for p in paths}
inst=Path(r'C:\Program Files (x86)\YGO Omega\YGO Omega_Data\Files\Scripts')
for code in [238273768]:assert (ROOT/'public/CCG Downloads/CCG_Scripts'/f'c{code}.lua').read_bytes()==(inst/f'c{code}.lua').read_bytes()
(OUT/'current-symphonic-speeaker-recruit-batch.json').write_text(json.dumps({'status':'VERIFIED_PARTIAL_NATIVE_SECONDARY_EFFECT','baseline_cases':10,'runtime_dependencies_sha256':before,'runs':runs,'scope':'Full Speeaker/actual installed metadata/corrected transport/no Lua API adapter. Ten native recruitment cases: actual Normal/Special Summon, Hand/Deck/faceup Extra, wrongset/GY/full main Deck/noCandidate/decline. Extra partner enters by actual Hand SS then SendGY redirection; native Extra->MZone move required. Full Main Monster Zones still allow Extra Zone summon. Controls noSS5/allowSet1/allowGY1/noExCapacity1 exact failures. Direct main-deck Pendulum Extra seeding was invalid and corrected before freezing. Recruitment locks/interruption/shared use/liveOmega/fullcard open.'},indent=2)+'\n',encoding='utf-8');print('Speeaker10RecruitNATIVEPASS;controls5/1/1/1verified; frozeninputs/parity')

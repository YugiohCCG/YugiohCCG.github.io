import hashlib,json,subprocess
from pathlib import Path
ROOT=Path.cwd();OUT=ROOT/'output/fresh-ccg-september'
def sha(p):return hashlib.sha256(p.read_bytes()).hexdigest()
paths=[Path(__file__).resolve(),ROOT/'scripts/fresh_corrected_card_data_transport.cjs',ROOT/'scripts/fresh_installed_card.cjs',Path(r'C:\Program Files (x86)\YGO Omega\YGO Omega_Data\Files\Databases\CCG_v1.db'),ROOT/'src/data/cards.json',ROOT/'node_modules/@n1xx1/ocgcore-wasm/dist/index-card-data-transport-candidate.mjs']+[ROOT/'scripts/fresh_current_talismandrake_sear_material_use_reset.cjs']+[ROOT/'public/CCG Downloads/CCG_Scripts'/f'c{code}.lua' for code in [245935439]]+[ROOT/'tmp/omega_scripts'/name for name in ['constant.lua','utility.lua','procedure.lua']]+list((ROOT/'node_modules/@n1xx1/ocgcore-wasm/dist').glob('*.js'))
before={str(p.resolve()):sha(p) for p in paths};runs=[]
for flag,expected in [(None,[]),('per-copy',[0,1,2]),('no-reset',[0,1,2]),('no-followup-summon',[0,1,2])]:
 r=subprocess.run(['node','--no-warnings','scripts/fresh_current_talismandrake_sear_material_use_reset.cjs']+(['--'+flag] if flag else []),capture_output=True,text=True,timeout=20)
 p=OUT/('current-talismandrake-sear-material-use-reset'+('-'+flag if flag else '')+'.json');d=json.loads(p.read_text())
 assert len(d['results'])==3 and all(not v['logs'] for v in d['results']),r.stdout+r.stderr
 assert [i for i,v in enumerate(d['results']) if v['failure']]==expected,(flag,r.stdout)
 assert r.returncode==(1 if expected else 0)
 if flag in ['per-copy','no-reset']:assert all(v['turn']==(3 if flag=='no-reset' else 1) for v in d['results'])
 runs.append({'flag':flag,'artifact':p.name,'artifact_sha256':sha(p),'expected_failures':expected})

assert before=={str(p.resolve()):sha(p) for p in paths}
inst=Path(r'C:\Program Files (x86)\YGO Omega\YGO Omega_Data\Files\Scripts')
for code in [245935439]:assert (ROOT/'public/CCG Downloads/CCG_Scripts'/f'c{code}.lua').read_bytes()==(inst/f'c{code}.lua').read_bytes()
(OUT/'current-talismandrake-sear-material-use-reset-batch.json').write_text(json.dumps({'status':'VERIFIED_PARTIAL_NATIVE_SECONDARY_EFFECT','baseline_cases':3,'runtime_dependencies_sha256':before,'runs':runs,'scope':'Full source actual secondary effect triggered by three neutral fixed two-material Fusion operations using real native material reason, Fusion summon and proper completion, Sear from Hand to GY. Shared use across copies/negated activation/negated effect spend use; natural turn0/1/0 reset. No Lua API adapter. Primary Fusion recipe/general Fusion legality/liveOmega/fullcard remain open.'},indent=2)+'\n',encoding='utf-8');print('Sear3secondarysharedresetNATIVEPASS;controls3/3/3verified; frozeninputs/parity')

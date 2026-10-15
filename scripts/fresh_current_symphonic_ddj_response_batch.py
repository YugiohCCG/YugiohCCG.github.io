import hashlib,json,subprocess
from pathlib import Path
ROOT=Path.cwd();OUT=ROOT/'output/fresh-ccg-september'
def sha(p):return hashlib.sha256(p.read_bytes()).hexdigest()
paths=[Path(__file__).resolve(),ROOT/'scripts/fresh_corrected_card_data_transport.cjs',ROOT/'scripts/fresh_current_card.cjs',OUT/'current-spec-CCG_v1.db',ROOT/'src/data/cards.json',ROOT/'node_modules/@n1xx1/ocgcore-wasm/dist/index-card-data-transport-candidate.mjs']+[ROOT/'scripts/fresh_current_symphonic_ddj_response.cjs']+[ROOT/'public/CCG Downloads/CCG_Scripts'/f'c{code}.lua' for code in [238273769]]+[ROOT/'tmp/omega_scripts'/name for name in ['constant.lua','utility.lua','procedure.lua']]+list((ROOT/'node_modules/@n1xx1/ocgcore-wasm/dist').glob('*.js'))
before={p.relative_to(ROOT).as_posix():sha(p) for p in paths};runs=[]
for flag,expected in [(None,[]),('old-type',[0]),('old-filter',[0])]:
 r=subprocess.run(['node','--no-warnings','scripts/fresh_current_symphonic_ddj_response.cjs']+(['--'+flag] if flag else []),capture_output=True,text=True,timeout=20);p=OUT/('current-symphonic-ddj-response'+('-'+flag if flag else '')+'.json');d=json.loads(p.read_text());assert len(d['results'])==5 and all(not v['logs'] for v in d['results']),r.stdout+r.stderr;assert [i for i,v in enumerate(d['results']) if v['failure']]==expected;assert r.returncode==(1 if expected else 0)
 runs.append({'flag':flag,'artifact':p.name,'artifact_sha256':sha(p),'expected_failures':expected})
assert before=={p.relative_to(ROOT).as_posix():sha(p) for p in paths}
inst=Path(r'C:\Program Files (x86)\YGO Omega\YGO Omega_Data\Files\Scripts')
for code in [238273769]:assert (ROOT/'public/CCG Downloads/CCG_Scripts'/f'c{code}.lua').read_bytes()==(inst/f'c{code}.lua').read_bytes()
(OUT/'current-symphonic-ddj-response-batch.json').write_text(json.dumps({'status':'VERIFIED_PARTIAL_PRODUCTION','baseline_cases':5,'runtime_dependencies_sha256':before,'runs':runs,'scope':'FullDDJ production current-spec metadata/correctedCardData:5native HandPZoneplacements, realSymphonicmonsterIGN responseCL2, sourceHandreturn/partnerPZoneSS; wrongmonsterarchetype/noPartner/wrongPartner/fullMZONE exclude. Oldeventtype/Monster-onlyPZonefilter controls failpositivecase; emptylogs/fullsourceinstallparity/frozeninputs. No LuaAPIshim/nativeOmega/fullcard; responseinterruptions/usereset/other effects open.'},indent=2)+'\n',encoding='utf-8');print('DDJ5responsePASS;controls1/1verified; frozeninputs/parity')

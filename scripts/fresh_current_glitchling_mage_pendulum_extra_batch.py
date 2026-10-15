import hashlib,json,subprocess
from pathlib import Path
ROOT=Path.cwd();OUT=ROOT/'output/fresh-ccg-september'
def sha(p):return hashlib.sha256(p.read_bytes()).hexdigest()
paths=[Path(__file__).resolve(),ROOT/'scripts/fresh_current_glitchling_mage_pendulum_extra.cjs',ROOT/'scripts/fresh_current_card.cjs',ROOT/'public/CCG Downloads/CCG_Scripts/c259072906.lua',ROOT/'src/data/cards.json',OUT/'current-spec-CCG_v1.db']+[ROOT/'tmp/omega_scripts'/n for n in ['constant.lua','utility.lua','procedure.lua']]+list((ROOT/'node_modules/@n1xx1/ocgcore-wasm/dist').glob('*.js'))
paths+=list((OUT/'mage-group-before-material-repair').glob('*.lua'))
paths += [ROOT/'scripts/fresh_corrected_card_data_transport.cjs',ROOT/'node_modules/@n1xx1/ocgcore-wasm/dist/index-card-data-transport-candidate.mjs']
subprocess.run(['node','-e',"require('./scripts/fresh_corrected_card_data_transport.cjs').loadCorrectedTransport().catch(e=>{console.error(e);process.exitCode=1})"],check=True,capture_output=True,text=True,timeout=20)
before={p.relative_to(ROOT).as_posix():sha(p) for p in paths};runs=[]
for flag,expected in [(None,[]),('no-material',['extraOne','extraTwo']),('no-complete',['extraOne','extraTwo']),('no-ex-capacity',['extraTwo'])]:
 r=subprocess.run(['node','--no-warnings','scripts/fresh_current_glitchling_mage_pendulum_extra.cjs']+(['--'+flag] if flag else []),capture_output=True,text=True,timeout=20);p=OUT/('current-glitchling-mage-pendulum-extra'+('-'+flag if flag else '')+'.json');d=json.loads(p.read_text());assert len(d['results'])==4 and all(not v['logs'] for v in d['results']),r.stdout+r.stderr
 assert [v['scenario'] for v in d['results'] if v['failure']]==expected*2;assert r.returncode==(1 if expected else 0)
 runs.append({'flag':flag,'artifact':p.name,'artifact_sha256':sha(p),'expected_failures':expected*2})
assert before=={p.relative_to(ROOT).as_posix():sha(p) for p in paths}
assert paths[3].read_bytes()==Path(r'C:\Program Files (x86)\YGO Omega\YGO Omega_Data\Files\Scripts/c259072906.lua').read_bytes()
(OUT/'current-glitchling-mage-pendulum-extra-batch.json').write_text(json.dumps({'status':'VERIFIED_PARTIAL_PRODUCTION','baseline_cases':4,'runtime_dependencies_sha256':before,'runs':runs,'scope':'Mage full production native procedure bothPZones:4ExtraRitual scenarios with actual Hand-to-PZone destruction producingfaceupExtra history; no proper-status seeding. OneExtraRitualSS/nativefieldmaterialpayment/properstatus; twoeligibleExtra targets tested withonlyoneEMZ capacity, second excluded fromnative selection. CorrectedCardData testtransport/no gameplay APIshim. Controlsnomaterial4/nocomplete4/noexcapacity2 verify. Fullcard/nativeOmega/linked-zone expansions/turnreset/other effects remainopen.'},indent=2)+'\n',encoding='utf-8');print('Mage4ExtraPASS;3controls4/4/2verified; parity/frozeninputs')

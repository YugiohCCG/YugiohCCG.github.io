import hashlib,json,subprocess
from pathlib import Path
ROOT=Path.cwd();OUT=ROOT/'output/fresh-ccg-september';FILES=Path(r'C:\Program Files (x86)\YGO Omega\YGO Omega_Data\Files')
def sha(p):return hashlib.sha256(p.read_bytes()).hexdigest()
paths=[Path(__file__).resolve(),FILES/'Databases/CCG_v1.db',ROOT/'src/data/cards.json',OUT/'candidate-CCG_v1.db']+[ROOT/'scripts'/n for n in ['fresh_current_terrarumian_destroy_visibility.cjs','fresh_terrarumian_cushion_pendulum.cjs','fresh_installed_card.cjs','fresh_corrected_card_data_transport.cjs']]+[ROOT/'tmp/omega_scripts'/n for n in ['constant.lua','utility.lua','procedure.lua']]+list((ROOT/'node_modules/@n1xx1/ocgcore-wasm/dist').glob('*.js'))+[ROOT/'node_modules/@n1xx1/ocgcore-wasm/dist/index-card-data-transport-candidate.mjs']
for code in range(284639717,284639725):
 p=ROOT/'public/CCG Downloads/CCG_Scripts'/f'c{code}.lua';assert p.read_bytes()==(FILES/'Scripts'/p.name).read_bytes();paths.append(p)
deps={str(p.resolve()):sha(p) for p in paths};runs=[]
for candidate in [False,True]:
 r=subprocess.run(['node','--no-warnings','scripts/fresh_current_terrarumian_destroy_visibility.cjs']+(['--candidate'] if candidate else []),capture_output=True,text=True,timeout=20)
 p=OUT/('current-terrarumian-destroy-visibility'+('-candidate' if candidate else '')+'.json');d=json.loads(p.read_text());expected=[] if candidate else [i for i in range(24) if i%3]
 assert len(d['results'])==24 and [i for i,v in enumerate(d['results']) if v['failure']]==expected and all(not v['logs'] for v in d['results']) and r.returncode==bool(expected),r.stdout+r.stderr
 runs.append({'artifact':p.name,'sha256':sha(p),'expected_failures':expected})
assert deps=={str(p.resolve()):sha(p) for p in paths}
(OUT/'current-terrarumian-destroy-visibility-probe.json').write_text(json.dumps({'status':'HIDDEN_DESTRUCTION_RESOURCE_SELECTION_REPRODUCED_CANDIDATE_ONLY','runtime_dependencies_sha256':deps,'runs':runs,'scope':'All eight original sources, installed metadata, native Hand-to-PZone activation and destruction selection prompts. Faceup own archetype condition witness remains a valid resource; opponent monster enables Cushion. Separate faceup Spell allowed, hidden Spell/monster illegally selectable under proposed visibility requirement. Candidate faceup-only destruction filter removes hidden entries in all16 cases. No production changes, no completed resolution/live Omega claim. Activation-menu-only initial experiment was nondiscriminating because witness remains selectable; final assertion inspects actual selection prompt.','ruling_status':'Official Arvata current text explicitly specifies face-up field for characteristic-specific effect destruction; supporting analogy only. Obtain direct archetype destruction FAQ or equivalent before production repair.','reference':'https://www.db.yugioh-card.com/yugiohdb/card_search.action?cid=13245&ope=2&request_locale=en'},indent=2)+'\n')
print('Hidden resource selection reproduced for eight Terrarumians; candidate excludes all hidden entries, production unchanged')

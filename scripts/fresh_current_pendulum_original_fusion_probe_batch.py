import hashlib,json,subprocess
from pathlib import Path
ROOT=Path.cwd();OUT=ROOT/'output/fresh-ccg-september';FILES=Path(r'C:\Program Files (x86)\YGO Omega\YGO Omega_Data\Files')
def sha(p):return hashlib.sha256(p.read_bytes()).hexdigest()
paths=[Path(__file__).resolve(),ROOT/'src/data/cards.json',FILES/'Databases/CCG_v1.db',OUT/'candidate-CCG_v1.db']+[ROOT/'scripts'/n for n in ['fresh_current_pendulum_original_fusion_probe.cjs','fresh_terrarumian_trumpet_hand.cjs','fresh_installed_card.cjs','fresh_corrected_card_data_transport.cjs']]+[ROOT/'tmp/omega_scripts'/n for n in ['constant.lua','utility.lua','procedure.lua']]+list((ROOT/'node_modules/@n1xx1/ocgcore-wasm/dist').glob('*.js'))+[ROOT/'node_modules/@n1xx1/ocgcore-wasm/dist/index-card-data-transport-candidate.mjs']
for code in [218142234,259882493]:
 p=ROOT/'public/CCG Downloads/CCG_Scripts'/f'c{code}.lua';assert p.read_bytes()==(FILES/'Scripts'/p.name).read_bytes();paths.append(p)
deps={str(p.resolve()):sha(p) for p in paths};r=subprocess.run(['node','--no-warnings','scripts/fresh_current_pendulum_original_fusion_probe.cjs'],capture_output=True,text=True,timeout=20);p=OUT/'current-pendulum-original-fusion-probe.json';d=json.loads(p.read_text());assert r.returncode==1 and [v['passcode'] for v in d['results']]==[218142234,259882493]
for v in d['results']:
 assert v['failure'] and v['trace'] and any(x['message']=='FusionRecipeAPIs:IsFusionSetCard=nil;IsFusionType=nil;GetMustMaterial=nil' for x in v['logs'])
 assert ("upvalue 'f'" if v['passcode']==218142234 else 'IsFusionSetCard') in v['failure']
assert deps=={str(p.resolve()):sha(p) for p in paths}
(OUT/'current-pendulum-original-fusion-probe-batch.json').write_text(json.dumps({'status':'ORIGINAL_FUSION_RECIPIENT_API_FAILURES_IDENTIFIED','runtime_dependencies_sha256':deps,'runs':[{'artifact':p.name,'sha256':sha(p),'expected_failures':[0,1]}],'scope':'Diagnostic only: original Seraphina/Patrician source/registered material procedures/current installed metadata/corrected public transport. Neutral Hand groups invoke native CheckFusionMaterial on actual source in face-down Extra. Seraphina original FilterBoolFunction has nil Fusion callback; Patrician direct IsFusionSetCard missing. Native diagnostic confirms Card.IsFusionSetCard/Card.IsFusionType/Duel.GetMustMaterial nil. No Lua adapter/replacement procedure/payment/summon; no production bug or behavioral/full-card/live Omega certification inferred. First encountered failure does not exhaust recipe issues.'},indent=2)+'\n')
print('Original Seraphina/Patrician Fusion API failures recorded distinctly from setup evidence')

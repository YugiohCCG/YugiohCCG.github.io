import hashlib,json,subprocess
from pathlib import Path
ROOT=Path(__file__).resolve().parents[1];OUT=ROOT/'output/fresh-ccg-september'
def sha(p):return hashlib.sha256(p.read_bytes()).hexdigest()
paths=[Path(__file__),ROOT/'scripts/fresh_current_machina_spirit_limit.cjs',ROOT/'scripts/fresh_current_card.cjs',ROOT/'public/CCG Downloads/CCG_Scripts/c259247853.lua',OUT/'current-spec-CCG_v1.db']+[ROOT/'tmp/omega_scripts'/n for n in ['constant.lua','utility.lua','procedure.lua','c59822133.lua']]+list((ROOT/'node_modules/@n1xx1/ocgcore-wasm/dist').glob('*.js'))
before={p.relative_to(ROOT).as_posix():sha(p) for p in paths}
r=subprocess.run(['node','--no-warnings','scripts/fresh_current_machina_spirit_limit.cjs','--debug','--old-spirit-guard'],cwd=ROOT,capture_output=True,text=True,timeout=30)
p=OUT/'current-machina-spirit-limit-old-spirit-guard.json';data=json.loads(p.read_text());assert r.returncode==1
assert data['results'][0]['failure'] and '0 !== 2' in data['results'][0]['failure']
assert any(x['message']=='tp:0/anchor:67108897/markers:0/0/typed:0/2' for x in data['results'][0]['logs'])
assert before=={p.relative_to(ROOT).as_posix():sha(p) for p in paths}
(OUT/'machina-link-zone-review.json').write_text(json.dumps({'status':'UNADAPTED_WRAPPER_ZONE_FAILURE_REPRODUCED','scope':'Diagnostic, not card effect certificate: native Link anchor type correct but zone count0; pair recipients2 eligible. Negative cases cannot prove restriction guards while positive case cannot activate. Old-guard control used solely to reproduce the unadapted zone precondition; production now repaired.','input_anchor_markers':5,'observed_link_markers':0,'observed_zone_count':0,'eligible_recipient_names':2,'dependencies_sha256':before,'artifact':p.name,'artifact_sha256':sha(p)},indent=2)+'\n')
print('Unadapted wrapper zone failure retained; adapted restriction evidence is separate')

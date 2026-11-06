import hashlib,json,subprocess
from pathlib import Path
ROOT=Path.cwd();OUT=ROOT/'output/fresh-ccg-september'
def sha(p):return hashlib.sha256(p.read_bytes()).hexdigest()
deps=json.loads((OUT/'current-destroy-replacement-batch.json').read_text())['runtime_dependencies_sha256'].copy()
for name in ['fresh_current_blaze_replacement_boundaries.cjs','fresh_current_blaze_replacement_boundaries_batch.py']:
 p=ROOT/'scripts'/name;deps[str(p.resolve())]=sha(p)
siblings=[215034223,218142234,241706191,253552927,255832330]
for code in siblings:
 p=ROOT/'public/CCG Downloads/CCG_Scripts'/f'c{code}.lua';deps[str(p.resolve())]=sha(p)
 assert p.read_bytes()==(Path(r'C:\Program Files (x86)\YGO Omega\YGO Omega_Data\Files\Scripts')/p.name).read_bytes()
runs=[]
for args,code,n,expected in [([],248788543,1,[]),(['--shield'],255832330,10,[]),(['--shield','--no-send-replacement'],255832330,10,[0,1,2,3,4,5,8,9])]:
 r=subprocess.run(['node','--no-warnings','scripts/fresh_current_blaze_replacement_boundaries.cjs']+args,capture_output=True,text=True,timeout=20)
 p=OUT/(f'current-blaze-{code}-replacement-boundaries'+('-no-send-replacement' if len(args)>1 else '')+'.json');d=json.loads(p.read_text());assert len(d['results'])==n and [i for i,v in enumerate(d['results']) if v['failure']]==expected and all(not v['logs'] for v in d['results']),(args,r.stdout+r.stderr);assert r.returncode==bool(expected)
 runs.append({'artifact':p.name,'sha256':sha(p),'cases':n,'expected_failures':expected})
assert all(sha(Path(p))==h for p,h in deps.items())
(OUT/'current-blaze-replacement-boundaries-batch.json').write_text(json.dumps({'status':'BOUNDED_NATIVE_COVERAGE_NO_PRODUCTION_CHANGE','runtime_dependencies_sha256':deps,'runs':runs,'same_pattern_send_equipment_callbacks':siblings,'ruling':{'url':'https://www.db.yugioh-card.com/yugiohdb/faq_search.action?fid=10501&ope=5&request_locale=ja','checked':'2026-10-21','finding':'Official analogous equipment replacement applies even when equip and recipient face simultaneous destruction. Shield survival is consistent; initial exclusion expectation rejected. Inference for custom card, not a direct official Shield ruling. No simultaneous-group exclusion added.'},'scope':'Full original GY equip/current installed metadata/corrected public engine/no Lua API adapter. Actual Seraphina field-seeded recipient; native GY/Hand/Deck/faceup and facedown banish protection, decline, own-effect exclusion, simultaneous destruction accept/decline; unrelated own monster still leaves. Sabre battle and Shield effect replacement unavailable with equip indestructible to effects, verified by native failed equip destruction before event. Effective omitted-send replacement control. No new bug demonstrated; shared-source sibling callback review only, not sibling gameplay certification. Original Fusion history/other effects/full-card/live Omega unverified.'},indent=2)+'\n');print('Blaze replacement boundary evidence retained; no production repair')

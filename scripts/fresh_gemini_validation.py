"""Record the bounded validation and installation evidence for the report review."""
import hashlib,json,subprocess
from pathlib import Path
ROOT=Path(__file__).resolve().parents[1];OUT=ROOT/'output/fresh-ccg-september'
def sha(p):return hashlib.sha256(p.read_bytes()).hexdigest()
fixes=json.loads((OUT/'gemini-supported-fixes.json').read_text(encoding='utf-8'))
run=subprocess.run(['lua','scripts/fresh_gemini_callback_regression.lua'],cwd=ROOT,text=True,capture_output=True,check=True)
assert 'PASS 91 production callback assertions' in run.stdout
for c in fixes['changes']:
 p=ROOT/f"public/CCG Downloads/CCG_Scripts/c{c['passcode']}.lua"
 assert sha(p)==c['after_sha256']
 assert sha(Path(c['backup']))==c['before_sha256']
 assert sha(Path(r'C:\Program Files (x86)\YGO Omega\YGO Omega_Data\Files\Scripts')/p.name)==sha(p)
names=['ghostrick-djinn-batch','janna-batch','shining-stand-batch','normal-search-family-batch','special-search-family-batch','spell-search-family-batch']
files={}
for n in names:
 p=OUT/(n+'.json');assert p.exists(),p;files[p.name]=sha(p)
syntax=OUT/'current-roster-syntax.json';d=json.loads(syntax.read_text(encoding='utf-8'))
assert len(d['results'])==711 and all(r['status']=='syntax_pass' for r in d['results'])
certificate={'scope':'21 changed script files: current hashes, backups, installed parity; 91 callback assertions with mocked core boundaries. Existing actual public-engine batches rerun separately. No full-card/native Omega certification.',
 'changed_cards':21,'callback_assertions':91,'callback_harness_sha256':sha(ROOT/'scripts/fresh_gemini_callback_regression.lua'),
 'actual_public_engine_baseline_cases':234,'actual_public_engine_runs_including_counterexamples':244,
 'batch_artifacts':files,'syntax_artifact_sha256':sha(syntax),
 'source_scripts':{str(c['passcode']):c['after_sha256'] for c in fixes['changes']},
 'repair_manifest_sha256':sha(OUT/'gemini-supported-fixes.json'),
 'installed_manifest_sha256':sha(OUT/'local-omega-test-install.json'),
 'installed_manifest_path':str(Path(json.loads((OUT/'local-omega-test-install.json').read_text(encoding='utf-8'))['backup'])/'manifest.json'),
 'native_omega_verified':False}
(OUT/'gemini-validation.json').write_text(json.dumps(certificate,indent=2)+'\n',encoding='utf-8')
print(json.dumps({'changed_cards':21,'callback_assertions':91,'installed_parity':'PASS'}))

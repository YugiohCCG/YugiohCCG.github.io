import hashlib,json,subprocess
from pathlib import Path
ROOT=Path(__file__).resolve().parents[1];OUT=ROOT/'output/fresh-ccg-september'
def sha(p):return hashlib.sha256(p.read_bytes()).hexdigest()
def main():
 manifest=json.loads((OUT/'necrovalley-deck-cost-repair-files.json').read_text())
 paths=[Path(__file__),ROOT/'scripts/fresh_current_necrovalley_deck_cost.cjs',ROOT/'scripts/fresh_necrovalley_deck_cost_repair.cjs',ROOT/'scripts/fresh_corrected_card_data_transport.cjs',ROOT/'scripts/fresh_installed_card.cjs',ROOT/'scripts/fresh_current_seraphina_pendulum_summon.cjs',ROOT/'scripts/fresh_current_card.cjs',OUT/'necrovalley-deck-cost-repair-files.json']+[ROOT/'tmp/omega_scripts'/n for n in ['constant.lua','utility.lua','procedure.lua','c47355498.lua']]+list((ROOT/'node_modules/@n1xx1/ocgcore-wasm/dist').glob('*.js'))
 for item in manifest['files']:
  source=ROOT/'public/CCG Downloads/CCG_Scripts'/item['file'];installed=Path(r'C:\Program Files (x86)\YGO Omega\YGO Omega_Data\Files\Scripts')/item['file']
  assert source.read_bytes()==installed.read_bytes() and sha(source)==item['after_sha256'];paths.append(source)
 before={p.relative_to(ROOT).as_posix():sha(p) for p in paths};runs=[]
 for mode,expected in [('candidate',[]),('prior',[1,4,7,10]),('no-payment',[0,1,2,3,4,5,6,7,9,10,11])]:
  r=subprocess.run(['node','--no-warnings','scripts/fresh_current_necrovalley_deck_cost.cjs']+([] if mode=='candidate' else ['--'+mode]),cwd=ROOT,capture_output=True,text=True,timeout=30)
  p=OUT/f'current-necrovalley-deck-cost-{mode}.json';d=json.loads(p.read_text());assert len(d['results'])==12 and all(not v['logs'] for v in d['results']);assert [i for i,v in enumerate(d['results']) if v['failure']]==expected,(mode,r.stdout);assert r.returncode==(1 if expected else 0)
  runs.append(dict(mode=mode,cases=12,expected_failures=expected,artifact=p.name,sha256=sha(p)))
 regression="const fs=require('fs'),M=require('module'),p=require('path').resolve('scripts/fresh_current_seraphina_pendulum_summon.cjs');process.argv.push('--faceup-compat');const m=new M(p,module);m.filename=p;m.paths=M._nodeModulePaths(require('path').dirname(p));m._compile(fs.readFileSync(p,'utf8').replaceAll('current-seraphina-pendulum-summon','current-necrovalley-seraphina-pendulum-regression'),p)"
 r=subprocess.run(['node','--no-warnings','-e',regression],cwd=ROOT,capture_output=True,text=True,timeout=30);p=OUT/'current-necrovalley-seraphina-pendulum-regression.json';d=json.loads(p.read_text());assert r.returncode==0 and len(d['results'])==7 and all(not v['failure'] and not v['logs'] for v in d['results']),r.stdout+r.stderr
 runs.append(dict(mode='existing-seraphina-regression',cases=7,expected_failures=[],artifact=p.name,sha256=sha(p)))
 assert before=={p.relative_to(ROOT).as_posix():sha(p) for p in paths}
 report=dict(status='NECROVALLEY_DECK_COST_REPAIRED',scope='Exact original cost callbacks with official Necrovalley; Sorceress IsFaceupEx mapping qualified. Existing Seraphina seven-case full Pendulum summon/cost/capacity regression reuses its documented mapped/public recipe qualification. No full-card/native Omega certification.',finding='Removed Necrovalley effect-movement filters only from four non-banish Graveyard-to-Deck costs. Actual Deck/Extra return cost reasons verified; Graveyard effect filters and banish costs unchanged.',runtime_dependencies_sha256=before,runs=runs,passcodes=[v['passcode'] for v in manifest['files']],rules=['https://www.db.yugioh-card.com/yugiohdb/card_search.action?cid=5533&ope=2&request_locale=en','https://www.yugioh-card.com/en/play/psct/psct-3/'])
 (OUT/'current-necrovalley-deck-cost-review.json').write_text(json.dumps(report,indent=2)+'\n');print('Four-card cost batch verified; bounded callback scope retained')
if __name__=='__main__':main()

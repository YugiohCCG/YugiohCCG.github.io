import hashlib,json,subprocess
from pathlib import Path
ROOT=Path.cwd();OUT=ROOT/'output/fresh-ccg-september';FILES=Path(r'C:\Program Files (x86)\YGO Omega\YGO Omega_Data\Files')
def sha(p):return hashlib.sha256(p.read_bytes()).hexdigest()
source=ROOT/'public/CCG Downloads/CCG_Scripts/c238272436.lua';assert source.read_bytes()==(FILES/'Scripts'/source.name).read_bytes()
paths=[Path(__file__).resolve(),source,FILES/'Databases/CCG_v1.db']+[ROOT/'scripts'/n for n in ['fresh_current_nether_source_relation.cjs','fresh_underroot_nether_move.cjs','fresh_installed_card.cjs','fresh_corrected_card_data_transport.cjs']]+[ROOT/'tmp/omega_scripts'/n for n in ['constant.lua','utility.lua','procedure.lua']]+list((ROOT/'node_modules/@n1xx1/ocgcore-wasm/dist').glob('*.js'))+[ROOT/'node_modules/@n1xx1/ocgcore-wasm/dist/index-card-data-transport-candidate.mjs']
deps={str(p.resolve()):sha(p) for p in paths};runs=[]
for flag,expected in [(None,[2,5,8,11,14,17]),('relation-candidate',[2,5,8,11,14,17]),('no-move',list(range(18)))]:
 r=subprocess.run(['node','--no-warnings','scripts/fresh_current_nether_source_relation.cjs']+(['--'+flag] if flag else []),capture_output=True,text=True,timeout=20)
 p=OUT/('current-nether-source-relation'+('-'+flag if flag else '')+'.json');d=json.loads(p.read_text());assert len(d['results'])==18 and [i for i,v in enumerate(d['results']) if v['failure']]==expected and all(not v['logs'] for v in d['results']),(flag,r.stdout+r.stderr);assert r.returncode==1
 if flag!='no-move':
  for v in d['results']:
   n=sum(1 for m in v['trace'] if m.get('card')==238272436 and m.get('to',{}).get('location')==4);assert n==(2 if v['interrupted']=='transit' else 1)
   if v['interrupted']:assert any(m.get('hint')=='701' or m.get('hint')==701 for m in v['trace'])
 runs.append({'artifact':p.name,'sha256':sha(p),'expected_hypothesis_failures':expected})
assert deps=={str(p.resolve()):sha(p) for p in paths}
(OUT/'current-nether-source-relation-probe.json').write_text(json.dumps({'status':'UNRESOLVED_SOURCE_IDENTITY_NO_PRODUCTION_CHANGE','runtime_dependencies_sha256':deps,'runs':runs,'finding':'Native source IsRelateToEffect remains true for these CL2 moves, even via MZone back to GY. Added guard produces exactly same native summons/hypothesis failures as original. Within-range moves pass both variants. Do not install ineffective guard or count this as repaired/passing source-interruption proof.','next_evidence':'Applicable ruling/runtime identity semantics required before production change. Other card clauses can be audited independently.','scope':'Full original/current installed metadata/corrected public engine/no Lua API adapter. Initially Hand/GY/banished source; native Deck monster GY/banish event, independent opposite target movement, real CL2 source moves; exact hypotheses and omitted-target-move control retained. No live Omega/full-card conclusion.'},indent=2)+'\n');print('Nether source-identity candidate ineffective; unresolved probe retained, production unchanged')

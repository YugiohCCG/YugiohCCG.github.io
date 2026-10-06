"""Reconcile documented individual repairs; counts repaired cards, not complete audits."""
import hashlib,json
from pathlib import Path
ROOT=Path(__file__).resolve().parents[1];OUT=ROOT/'output/fresh-ccg-september';FILES=Path(r'C:\Program Files (x86)\YGO Omega\YGO Omega_Data\Files')
def sha(p):return hashlib.sha256(p.read_bytes()).hexdigest()
def main():
 plans=[(215034223,'talismandrake_united','old-cost','Talismandrake Arms United discard-cost source exclusion repair'),(214371067,'enra','old-timing','Enra successful-summon continuation repair and local installation'),(212684822,'ektelestis','old-limit','Ektelestis first-summon restriction repair'),(254065048,'polemistis','old-limit','Polemistis summon repair and reusable roster pattern triage'),(259937946,'grand_blue_prince','old-limit','Grand Blue Prince first-Fusion versus revival repair'),(213266433,'hanging_frute','no-tracking','The Hanging Frute surviving re-set defender once-each repair')]
 roster={c['passcode']:c for c in json.loads((OUT/'baseline-remote.json').read_text(encoding='utf-8'))['cards']};handoff=(ROOT/'docs/CCG-AUDIT-HANDOFF.md').read_text(encoding='utf-8');rows=[]
 database_hash=sha(OUT/'candidate-CCG_v1.db')
 for code,prefix,control,section in plans:
  # Resolve only this card's artifacts; hash matches remain mandatory.
  artifacts={sha(p):p for p in OUT.glob(prefix.replace('_','-')+'*.json')}
  source=ROOT/'public/CCG Downloads/CCG_Scripts'/f'c{code}.lua';batch=OUT/(prefix.replace('_','-')+'-batch.json') if prefix=='talismandrake_united' else OUT/(prefix+'-batch.json');data=json.loads(batch.read_text(encoding='utf-8'));assert data['script_sha256']==sha(source);assert data['candidate_database_sha256']==database_hash;assert section in handoff
  assert sha(FILES/'Scripts'/source.name)==sha(source),'Installed script differs'
  assert any(r['control']==control and r['expected_failures'] and r['status']==1 for r in data['runs']);assert any(r['control'] is None and r['status']==0 for r in data['runs'])
  for run in data['runs']:
   artifact=artifacts[run['artifact_sha256']];result=json.loads(artifact.read_text(encoding='utf-8'));assert result['script_sha256']==sha(source);assert [r['test'] for r in result['results'] if r['failure']]==run['expected_failures']
   harness=ROOT/'scripts'/('fresh_'+prefix+'_'+run['harness']+'.cjs');assert sha(harness)==run['harness_sha256']
  rows.append({'passcode':code,'name':roster[code]['name'],'documented_repair_section':section,'script_sha256':sha(source),'batch':batch.name,'batch_sha256':sha(batch),'regression_control':control,'installed_matches':True,'full_card_audit':'OPEN','native_omega_verified':False})
 assert sha(OUT/'candidate-CCG_v1.db')==database_hash,'Database changed during verification'
 review_path=OUT/'gemini-validation.json'
 if review_path.exists():
  review=json.loads(review_path.read_text(encoding='utf-8'));manifest=OUT/'gemini-supported-fixes.json'
  assert review['repair_manifest_sha256']==sha(manifest)
  assert review['callback_harness_sha256']==sha(ROOT/'scripts/fresh_gemini_callback_regression.lua')
  assert review['callback_assertions']==91 and review['native_omega_verified'] is False
  for repair in json.loads(manifest.read_text(encoding='utf-8'))['changes']:
   code=repair['passcode'];source=ROOT/'public/CCG Downloads/CCG_Scripts'/f'c{code}.lua'
   assert sha(source)==repair['after_sha256']==review['source_scripts'][str(code)]
   assert sha(FILES/'Scripts'/source.name)==sha(source)
   assert not any(r['passcode']==code for r in rows)
   rows.append({'passcode':code,'name':roster[code]['name'],'documented_repair_section':'Gemini claim review',
                'repair':repair['reason'],'script_sha256':sha(source),'validation':'gemini-validation.json',
                'validation_sha256':sha(review_path),'evidence_type':'Source-reviewed repair; callback regression plus existing focused public-engine tests where available',
                'installed_matches':True,'full_card_audit':'OPEN','native_omega_verified':False})
 field_path=OUT/'field-search-family-batch.json'
 if field_path.exists():
  field=json.loads(field_path.read_text(encoding='utf-8'));source=ROOT/'public/CCG Downloads/CCG_Scripts/c259883230.lua'
  assert field['harness_sha256']==sha(ROOT/'scripts/fresh_field_search_family.cjs')
  assert field['batch_script_sha256']==sha(ROOT/'scripts/fresh_field_search_family_batch.py')
  assert field['candidate_database_sha256']==database_hash
  for dependency,h in field['runtime_dependencies_sha256'].items():assert sha(ROOT/dependency)==h
  relevant=[r for r in field['runs'] if r['source']==259883230]
  assert any(r['control']=='old-field-condition' and r['expected_failures']==[{'facedownField':True}] for r in relevant)
  for run in relevant:
   assert run['source_sha256']==sha(source)
   assert run['target_sha256']==sha(ROOT/'public/CCG Downloads/CCG_Scripts'/f"c{run['target']}.lua")
   assert run['artifact_sha256']==sha(OUT/run['artifact'])
   data=json.loads((OUT/run['artifact']).read_text(encoding='utf-8'))
   assert [r['test'] for r in data['results'] if r['failure']]==run['expected_failures']
  assert sha(FILES/'Scripts'/source.name)==sha(source)
  rows.append({'passcode':259883230,'name':roster[259883230]['name'],'documented_repair_section':'Release of the Pyre face-down condition repair',
               'repair':'Pyro monster search condition requires face-up monster.', 'script_sha256':sha(source),
               'batch':field_path.name,'batch_sha256':sha(field_path),'regression_control':'old-field-condition',
               'installed_matches':True,'full_card_audit':'OPEN','native_omega_verified':False})
 zone_path=OUT/'pyre-zone-lock-batch.json'
 if zone_path.exists():
  zone=json.loads(zone_path.read_text(encoding='utf-8'))
  row=next(r for r in rows if r['passcode']==259883230)
  assert zone['script_sha256']==row['script_sha256']
  assert zone['harness_sha256']==sha(ROOT/'scripts/fresh_pyre_zone_lock_count.cjs')
  assert zone['batch_script_sha256']==sha(ROOT/'scripts/fresh_pyre_zone_lock_batch.py')
  for dependency,h in zone['runtime_dependencies_sha256'].items():assert sha(ROOT/dependency)==h
  assert any(r['control']=='old-lock-limit' and r['status']==1 for r in zone['runs'])
  assert any(r['card_data_adapter'] and r['control'] is None and r['status']==0 for r in zone['runs'])
  for run in zone['runs']:assert run['artifact_sha256']==sha(OUT/run['artifact'])
  row['additional_regression']={'batch':zone_path.name,'batch_sha256':sha(zone_path),'scope':zone['scope']}
  row['repair']+=' Zone-lock use also remains consumed while the same card stays face-up.'
 report={'scope':'Documented script repairs with current source/install parity. Public-engine regressions and explicitly bounded callback/shared-effect evidence are distinguished per row. Not full-card or native Omega certification.', 'fixed_cards_minimum':len(rows),'cards':rows}
 (OUT/'repair-ledger.json').write_text(json.dumps(report,indent=2)+'\n',encoding='utf-8');print(json.dumps({'fixed_cards_minimum':len(rows),'status':'CURRENT_EVIDENCE_VERIFIED'}))
if __name__=='__main__':main()

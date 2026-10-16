"""Reconcile documented individual repairs; counts repaired cards, not complete audits."""
import hashlib,json
from pathlib import Path
ROOT=Path(__file__).resolve().parents[1];OUT=ROOT/'output/fresh-ccg-september';FILES=Path(r'C:\Program Files (x86)\YGO Omega\YGO Omega_Data\Files')
def sha(p):return hashlib.sha256(p.read_bytes()).hexdigest()
def verify_dependency(relative,expected):
 p=ROOT/relative
 if sha(p)==expected:return
 assert relative=='output/fresh-ccg-september/current-spec-CCG_v1.db','Unreconciled dependency: '+relative
 reconciliation=json.loads((OUT/'current-spec-name-only-reconciliation.json').read_text())
 assert sha(p)==reconciliation['current_sha256']
 archived=ROOT/reconciliation['archived_path']
 assert sha(archived)==expected==reconciliation['archived_sha256']
 import sqlite3
 with sqlite3.connect(archived.resolve().as_uri()+'?mode=ro',uri=True) as a,sqlite3.connect(p.resolve().as_uri()+'?mode=ro',uri=True) as b:
  assert a.execute('select name,sql from sqlite_master order by name').fetchall()==b.execute('select name,sql from sqlite_master order by name').fetchall()
  for table in ['datas','texts']:
   old={row[0]:row for row in a.execute('select * from '+table)};new={row[0]:row for row in b.execute('select * from '+table)};assert old.keys()==new.keys()
   for code in old:
    if old[code]!=new[code]:assert table=='texts' and code in [284636589,132636589] and old[code][2:]==new[code][2:] and old[code][1]=='"Terrarumian Growth' and new[code][1]=='Terrarumian Growth'

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
   assert repair['after_sha256']==review['source_scripts'][str(code)]
   reconciliation=None
   if sha(source)!=repair['after_sha256']:
    if code==210628767:
     reconciliation=OUT/'morbydrip-source-reconciliation.json';reconciled=json.loads(reconciliation.read_text());assert reconciled['script_sha256']==sha(source);assert reconciled['historical_repair_sha256']==repair['after_sha256'];assert reconciled['current_batch_sha256']==sha(OUT/'current-morbydrip-placement-repaired-batch.json')
     before=(OUT/'morbydrip-before-occupied-column-repair/source-c210628767.lua').read_bytes();after=source.read_bytes();newline=b'\r\n' if b'\r\n' in before else b'\n';assert after.replace(newline+b'\tif Duel.GetFieldCard(p,LOCATION_SZONE,sq) then return false end',b'').replace(b' or Duel.GetLocationCount(tp,LOCATION_MZONE)<=0',b'')==before
    elif code==216258796:
     reconciliation=OUT/'actinia-source-reconciliation.json';reconciled=json.loads(reconciliation.read_text());assert reconciled['script_sha256']==sha(source);assert reconciled['historical_repair_sha256']==repair['after_sha256']
     before=(OUT/'actinia-before-revival-qualification-repair/c216258796.lua').read_bytes();assert hashlib.sha256(before).hexdigest()==repair['after_sha256'];assert source.read_bytes().replace(b'\r\n',b'\n').replace(b'\n\tif not c:IsStatus(STATUS_PROC_COMPLETE) then return false end',b'')==before.replace(b'\r\n',b'\n')
    else:
     assert code==237684285,'Unreviewed historical source change'
     reconciliation=OUT/'janna-source-reconciliation.json'
     reconciled=json.loads(reconciliation.read_text(encoding='utf-8'))
     assert reconciled['script_sha256']==sha(source)
     assert reconciled['historical_repair_sha256']==repair['after_sha256']
     assert reconciled['historical_validation_sha256']==sha(review_path)
     assert reconciled['reconciliation_script_sha256']==sha(ROOT/'scripts/fresh_janna_source_reconcile.py')
     assert reconciled['callback_harness_sha256']==review['callback_harness_sha256']
     assert reconciled['callback_assertions']==99 and reconciled['native_omega_verified'] is False
   else:assert sha(source)==repair['after_sha256']
   assert sha(FILES/'Scripts'/source.name)==sha(source)
   assert not any(r['passcode']==code for r in rows)
   rows.append({'passcode':code,'name':roster[code]['name'],'documented_repair_section':'Gemini claim review',
                'repair':repair['reason'],'script_sha256':sha(source),'validation':'gemini-validation.json',
                'validation_sha256':sha(review_path),'evidence_type':'Source-reviewed repair; callback regression plus existing focused public-engine tests where available',
                'installed_matches':True,'full_card_audit':'OPEN','native_omega_verified':False})
   if reconciliation:
    rows[-1]['source_reconciliation']={'artifact':reconciliation.name,'sha256':sha(reconciliation),'scope':reconciled['scope']}
 field_path=OUT/'field-search-family-batch.json'
 if field_path.exists():
  field=json.loads(field_path.read_text(encoding='utf-8'));source=ROOT/'public/CCG Downloads/CCG_Scripts/c259883230.lua'
  assert field['harness_sha256']==sha(ROOT/'scripts/fresh_field_search_family.cjs')
  assert field['batch_script_sha256']==sha(ROOT/'scripts/fresh_field_search_family_batch.py')
  assert field['candidate_database_sha256']==database_hash
  for dependency,h in field['runtime_dependencies_sha256'].items():verify_dependency(dependency,h)
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
  for dependency,h in zone['runtime_dependencies_sha256'].items():verify_dependency(dependency,h)
  assert any(r['control']=='old-lock-limit' and r['status']==1 for r in zone['runs'])
  assert any(r['card_data_adapter'] and r['control'] is None and r['status']==0 for r in zone['runs'])
  for run in zone['runs']:assert run['artifact_sha256']==sha(OUT/run['artifact'])
  row['additional_regression']={'batch':zone_path.name,'batch_sha256':sha(zone_path),'scope':zone['scope']}
  row['repair']+=' Zone-lock use also remains consumed while the same card stays face-up.'
 focused_path=OUT/'current-reconciled-surge-spherix-batch.json'
 if focused_path.exists():
  focused=json.loads(focused_path.read_text(encoding='utf-8'))
  assert focused['baseline_cases']==41
  assert focused['batch_script_sha256']==sha(ROOT/'scripts/fresh_reconciled_surge_spherix_batch.py')
  for dependency,h in focused['runtime_dependencies_sha256'].items():verify_dependency(dependency,h)
  for code in [259869259,231088629]:
   source=ROOT/f'public/CCG Downloads/CCG_Scripts/c{code}.lua'
   assert sha(FILES/'Scripts'/source.name)==sha(source)
   relevant=[r for r in focused['runs'] if r['passcode']==code]
   assert any(r['control'] is None and r['status']==0 for r in relevant)
   assert any(r['control'] and r['status']==1 and r['expected_failures'] for r in relevant)
   for run in relevant:
    assert run['script_sha256']==sha(source)
    assert run['harness_sha256']==sha(ROOT/'scripts'/run['harness'])
    artifact=OUT/run['artifact'];assert run['artifact_sha256']==sha(artifact)
    data=json.loads(artifact.read_text(encoding='utf-8'))
    assert [r['test'] for r in data['results'] if r['failure']]==run['expected_failures']
   assert not any(r['passcode']==code for r in rows)
   rows.append({'passcode':code,'name':roster[code]['name'],'documented_repair_section':'Surge per-copy tracking and Spherix interception repairs',
                'script_sha256':sha(source),'batch':focused_path.name,'batch_sha256':sha(focused_path),
                'repair':'Independent co-link transition tracking and activation baseline' if code==259869259 else 'Remove invalid relation guard from continuous summon interception; preserve optional XYZ attachment choice; allow face-down opponent monsters for column shuffle. General material count/eligibility remains open.',
                'evidence_type':focused['scope'],'installed_matches':True,'full_card_audit':'OPEN','native_omega_verified':False})
 onibi_path=OUT/'current-onibi-batch.json'
 if onibi_path.exists():
  batch=json.loads(onibi_path.read_text());source=ROOT/'public/CCG Downloads/CCG_Scripts/c217713649.lua'
  for dependency,h in batch['runtime_dependencies_sha256'].items():verify_dependency(dependency,h)
  assert batch['baseline_cases']==4 and len(batch['runs'])==4
  for run in batch['runs']:
   artifact=OUT/run['artifact'];assert sha(artifact)==run['artifact_sha256']
   result=json.loads(artifact.read_text());assert result['script_sha256']==sha(source)
   assert [r['test'] for r in result['results'] if r['failure']]==run['expected_failures']
  assert sha(FILES/'Scripts'/source.name)==sha(source)
  assert not any(r['passcode']==217713649 for r in rows)
  rows.append({'passcode':217713649,'name':roster[217713649]['name'],'repair':'Continue optional Spirit search after the actual successful Normal Summon; clear the selected-card continuation on success or negation.', 'script_sha256':sha(source),'batch':onibi_path.name,'batch_sha256':sha(onibi_path),'evidence_type':batch['scope'],'installed_matches':True,'full_card_audit':'OPEN','native_omega_verified':False})
 aqua_path=OUT/'current-aqua-repair-batch.json'
 if aqua_path.exists():
  batch=json.loads(aqua_path.read_text());source=ROOT/'public/CCG Downloads/CCG_Scripts/c227035644.lua'
  assert batch['script_sha256']==sha(source) and batch['baseline_cases']==5
  additional=batch['additional_regression'];assert sha(OUT/additional['batch'])==additional['sha256']
  current=json.loads((OUT/additional['batch']).read_text())
  for dependency,h in current['runtime_dependencies_sha256'].items():verify_dependency(dependency,h)
  for run in current['runs']:
   artifact=OUT/run['artifact'];assert sha(artifact)==run['artifact_sha256']
   data=json.loads(artifact.read_text());assert [r['test'] for r in data['results'] if r['failure']]==run['expected_failures']
  for dependency,h in batch['runtime_dependencies_sha256'].items():verify_dependency(dependency,h)
  for run in batch['runs']:
   artifact=OUT/run['artifact'];assert sha(artifact)==run['artifact_sha256']
   data=json.loads(artifact.read_text());assert [r['test'] for r in data['results'] if r['failure']]==run['expected_failures']
  assert sha(FILES/'Scripts'/source.name)==sha(source)
  assert not any(r['passcode']==227035644 for r in rows)
  rows.append({'passcode':227035644,'name':roster[227035644]['name'],'repair':'Permit own face-down field Fusion Materials while retaining face-up banished restriction; exclude non-monster, Fusion-ineligible and effect-immune first-effect materials.', 'script_sha256':sha(source),'batch':aqua_path.name,'batch_sha256':sha(aqua_path),'evidence_type':batch['scope'],'installed_matches':True,'full_card_audit':'OPEN','native_omega_verified':False})
 plank_path=OUT/'current-planktonites-fusion-batch.json'
 if plank_path.exists():
  batch=json.loads(plank_path.read_text());source=ROOT/'public/CCG Downloads/CCG_Scripts/c250339529.lua'
  assert batch['baseline_cases']==2
  for dependency,h in batch['runtime_dependencies_sha256'].items():verify_dependency(dependency,h)
  for run in batch['runs']:
   artifact=OUT/run['artifact'];assert sha(artifact)==run['artifact_sha256']
   data=json.loads(artifact.read_text());assert data['script_sha256']==sha(source)
   assert [r['test'] for r in data['results'] if r['failure']]==run['expected_failures']
  assert sha(FILES/'Scripts'/source.name)==sha(source)
  assert not any(r['passcode']==250339529 for r in rows)
  rows.append({'passcode':250339529,'name':roster[250339529]['name'],'repair':'Apply existing immunity filter to normal Fusion material pools at targeting and resolution.', 'script_sha256':sha(source),'batch':plank_path.name,'batch_sha256':sha(plank_path),'evidence_type':batch['scope'],'installed_matches':True,'full_card_audit':'OPEN','native_omega_verified':False})
 provocation_path=OUT/'current-dinomorphia-provocation-fusion-batch.json'
 if provocation_path.exists():
  batch=json.loads(provocation_path.read_text());source=ROOT/'public/CCG Downloads/CCG_Scripts/c259826112.lua'
  assert batch['baseline_cases']==3
  for dependency,h in batch['runtime_dependencies_sha256'].items():verify_dependency(dependency,h)
  for run in batch['runs']:
   artifact=OUT/run['artifact'];assert sha(artifact)==run['artifact_sha256']
   data=json.loads(artifact.read_text());assert data['script_sha256']==sha(source)
   assert [r['test'] for r in data['results'] if r['failure']]==run['expected_failures']
  assert sha(FILES/'Scripts'/source.name)==sha(source)
  assert not any(r['passcode']==259826112 for r in rows)
  rows.append({'passcode':259826112,'name':roster[259826112]['name'],'repair':'Exclude source-immune monsters from optional Fusion material pool after successful Trap Set.', 'script_sha256':sha(source),'batch':provocation_path.name,'batch_sha256':sha(provocation_path),'evidence_type':batch['scope'],'installed_matches':True,'full_card_audit':'OPEN','native_omega_verified':False})
 grimoire_path=OUT/'current-grimoire-fusion-batch.json'
 if grimoire_path.exists():
  batch=json.loads(grimoire_path.read_text());source=ROOT/'public/CCG Downloads/CCG_Scripts/c259680842.lua'
  assert batch['baseline_cases']==5
  for dependency,h in batch['runtime_dependencies_sha256'].items():verify_dependency(dependency,h)
  for run in batch['runs']:
   artifact=OUT/run['artifact'];assert sha(artifact)==run['artifact_sha256']
   data=json.loads(artifact.read_text());assert data['script_sha256']==sha(source)
   assert [r['test'] for r in data['results'] if r['failure']]==run['expected_failures']
  assert sha(FILES/'Scripts'/source.name)==sha(source)
  assert not any(r['passcode']==259680842 for r in rows)
  rows.append({'passcode':259680842,'name':roster[259680842]['name'],'repair':'Apply source immunity filtering to optional Deck Fusion material pool.', 'script_sha256':sha(source),'batch':grimoire_path.name,'batch_sha256':sha(grimoire_path),'evidence_type':batch['scope'],'installed_matches':True,'full_card_audit':'OPEN','native_omega_verified':False})
 crawler_path=OUT/'current-crawler-hand-summon-batch.json'
 if crawler_path.exists():
  batch=json.loads(crawler_path.read_text());source=ROOT/'public/CCG Downloads/CCG_Scripts/c213611313.lua'
  assert batch['baseline_cases']==4
  for dependency,h in batch['runtime_dependencies_sha256'].items():verify_dependency(dependency,h)
  for run in batch['runs']:
   artifact=OUT/run['artifact'];assert sha(artifact)==run['artifact_sha256']
   data=json.loads(artifact.read_text());assert data['script_sha256']==sha(source)
   assert [r['test'] for r in data['results'] if r['failure']]==run['expected_failures']
  assert sha(FILES/'Scripts'/source.name)==sha(source)
  assert not any(r['passcode']==213611313 for r in rows)
  rows.append({'passcode':213611313,'name':roster[213611313]['name'],'repair':'Discard cost must leave a distinct eligible Galaxy monster in Hand.', 'script_sha256':sha(source),'batch':crawler_path.name,'batch_sha256':sha(crawler_path),'evidence_type':batch['scope'],'installed_matches':True,'full_card_audit':'OPEN','native_omega_verified':False})
 hanabi_path=OUT/'current-hanabi-spirit-limit-batch.json'
 if hanabi_path.exists():
  batch=json.loads(hanabi_path.read_text());source=ROOT/'public/CCG Downloads/CCG_Scripts/c259790247.lua'
  assert batch['baseline_cases']==2
  for dependency,h in batch['runtime_dependencies_sha256'].items():verify_dependency(dependency,h)
  for run in batch['runs']:
   artifact=OUT/run['artifact'];assert sha(artifact)==run['artifact_sha256']
   data=json.loads(artifact.read_text());assert data['script_sha256']==sha(source)
   assert [r['test'] for r in data['results'] if r['failure']]==run['expected_failures']
  assert sha(FILES/'Scripts'/source.name)==sha(source)
  assert not any(r['passcode']==259790247 for r in rows)
  rows.append({'passcode':259790247,'name':roster[259790247]['name'],'repair':'Block simultaneous double summon under Blue-Eyes Spirit Dragon at targeting and resolution.', 'script_sha256':sha(source),'batch':hanabi_path.name,'batch_sha256':sha(hanabi_path),'evidence_type':batch['scope'],'installed_matches':True,'full_card_audit':'OPEN','native_omega_verified':False})
 astrocyte_path=OUT/'current-astrocyte-leave-field-batch.json'
 if astrocyte_path.exists():
  batch=json.loads(astrocyte_path.read_text());source=ROOT/'public/CCG Downloads/CCG_Scripts/c259481543.lua'
  assert batch['baseline_cases']==4
  for dependency,h in batch['runtime_dependencies_sha256'].items():verify_dependency(dependency,h)
  for run in batch['runs']:
   artifact=OUT/run['artifact'];assert sha(artifact)==run['artifact_sha256']
   data=json.loads(artifact.read_text());assert data['script_sha256']==sha(source)
   assert [r['test'] for r in data['results'] if r['failure']]==run['expected_failures']
  assert sha(FILES/'Scripts'/source.name)==sha(source)
  assert not any(r['passcode']==259481543 for r in rows)
  rows.append({'passcode':259481543,'name':roster[259481543]['name'],'repair':'Block leave-field simultaneous double summon under Blue-Eyes Spirit Dragon at targeting and resolution.', 'script_sha256':sha(source),'batch':astrocyte_path.name,'batch_sha256':sha(astrocyte_path),'evidence_type':batch['scope'],'installed_matches':True,'full_card_audit':'OPEN','native_omega_verified':False})
 murugan_path=OUT/'current-murugan-spirit-limit-batch.json'
 if murugan_path.exists():
  batch=json.loads(murugan_path.read_text());source=ROOT/'public/CCG Downloads/CCG_Scripts/c247755869.lua'
  assert batch['baseline_cases']==4
  for dependency,h in batch['runtime_dependencies_sha256'].items():verify_dependency(dependency,h)
  for run in batch['runs']:
   artifact=OUT/run['artifact'];assert sha(artifact)==run['artifact_sha256']
   data=json.loads(artifact.read_text());assert data['script_sha256']==sha(source)
   assert [r['test'] for r in data['results'] if r['failure']]==run['expected_failures']
  assert sha(FILES/'Scripts'/source.name)==sha(source)
  assert not any(r['passcode']==247755869 for r in rows)
  rows.append({'passcode':247755869,'name':roster[247755869]['name'],'repair':'Block Hand double summon under Spirit Dragon at targeting/resolution while preserving field single revival.', 'script_sha256':sha(source),'batch':murugan_path.name,'batch_sha256':sha(murugan_path),'evidence_type':batch['scope'],'installed_matches':True,'full_card_audit':'OPEN','native_omega_verified':False})
 carcel_path=OUT/'current-reconciled-carcel-spirit-limit-batch.json'
 if carcel_path.exists():
  batch=json.loads(carcel_path.read_text());source=ROOT/'public/CCG Downloads/CCG_Scripts/c259780273.lua'
  assert batch['baseline_cases']==4
  for dependency,h in batch['runtime_dependencies_sha256'].items():verify_dependency(dependency,h)
  for run in batch['runs']:
   artifact=OUT/run['artifact'];assert sha(artifact)==run['artifact_sha256']
   data=json.loads(artifact.read_text());assert data['script_sha256']==sha(source)
   assert [r['test'] for r in data['results'] if r['failure']]==run['expected_failures']
  assert sha(FILES/'Scripts'/source.name)==sha(source)
  assert not any(r['passcode']==259780273 for r in rows)
  rows.append({'passcode':259780273,'name':roster[259780273]['name'],'repair':'Block mandatory Hand/Deck simultaneous summon under Spirit Dragon at targeting and resolution.', 'script_sha256':sha(source),'batch':carcel_path.name,'batch_sha256':sha(carcel_path),'evidence_type':batch['scope'],'installed_matches':True,'full_card_audit':'OPEN','native_omega_verified':False})
 devotee_path=OUT/'current-devotee-spirit-limit-batch.json'
 if devotee_path.exists():
  batch=json.loads(devotee_path.read_text());source=ROOT/'public/CCG Downloads/CCG_Scripts/c259024242.lua'
  assert batch['baseline_cases']==4
  for dependency,h in batch['runtime_dependencies_sha256'].items():verify_dependency(dependency,h)
  for run in batch['runs']:
   artifact=OUT/run['artifact'];assert sha(artifact)==run['artifact_sha256']
   data=json.loads(artifact.read_text());assert data['script_sha256']==sha(source)
   assert [r['test'] for r in data['results'] if r['failure']]==run['expected_failures']
  assert sha(FILES/'Scripts'/source.name)==sha(source)
  assert not any(r['passcode']==259024242 for r in rows)
  rows.append({'passcode':259024242,'name':roster[259024242]['name'],'repair':'Block mandatory two-token summon under Spirit Dragon at targeting and resolution.', 'script_sha256':sha(source),'batch':devotee_path.name,'batch_sha256':sha(devotee_path),'evidence_type':batch['scope'],'installed_matches':True,'full_card_audit':'OPEN','native_omega_verified':False})
 bedroom_path=OUT/'current-bedroom-spirit-limit-batch.json'
 if bedroom_path.exists():
  batch=json.loads(bedroom_path.read_text());source=ROOT/'public/CCG Downloads/CCG_Scripts/c259090287.lua'
  assert batch['baseline_cases']==3
  for dependency,h in batch['runtime_dependencies_sha256'].items():verify_dependency(dependency,h)
  for run in batch['runs']:
   artifact=OUT/run['artifact'];assert sha(artifact)==run['artifact_sha256']
   data=json.loads(artifact.read_text());assert data['script_sha256']==sha(source)
   assert [r['test'] for r in data['results'] if r['failure']]==run['expected_failures']
  assert sha(FILES/'Scripts'/source.name)==sha(source)
  assert not any(r['passcode']==259090287 for r in rows)
  rows.append({'passcode':259090287,'name':roster[259090287]['name'],'repair':'Use controller from handler in protection condition; cap optional excavation summons to one under Spirit Dragon.', 'script_sha256':sha(source),'batch':bedroom_path.name,'batch_sha256':sha(bedroom_path),'evidence_type':batch['scope'],'installed_matches':True,'full_card_audit':'OPEN','native_omega_verified':False})
 bhodi_path=OUT/'current-bhodi-spirit-limit-batch.json'
 if bhodi_path.exists():
  batch=json.loads(bhodi_path.read_text());source=ROOT/'public/CCG Downloads/CCG_Scripts/c259072745.lua'
  assert batch['baseline_cases']==3
  for dependency,h in batch['runtime_dependencies_sha256'].items():verify_dependency(dependency,h)
  for run in batch['runs']:
   artifact=OUT/run['artifact'];assert sha(artifact)==run['artifact_sha256']
   data=json.loads(artifact.read_text());assert data['script_sha256']==sha(source)
   assert [r['test'] for r in data['results'] if r['failure']]==run['expected_failures']
  assert 'additional_regression' in batch,'Bhodi material Fusion certificate required'
  if 'additional_regression' in batch:
   additional=batch['additional_regression'];assert sha(OUT/additional['batch'])==additional['sha256']
   stronger=json.loads((OUT/additional['batch']).read_text());assert stronger['baseline_cases']==4
   for dependency,h in stronger['runtime_dependencies_sha256'].items():verify_dependency(dependency,h)
   for run in stronger['runs']:
    artifact=OUT/run['artifact'];assert sha(artifact)==run['artifact_sha256']
    data=json.loads(artifact.read_text());assert data['script_sha256']==sha(source)
    assert [r['test'] for r in data['results'] if r['failure']]==run['expected_failures']
  assert sha(FILES/'Scripts'/source.name)==sha(source)
  assert not any(r['passcode']==259072745 for r in rows)
  rows.append({'passcode':259072745,'name':roster[259072745]['name'],'repair':'Cap optional revival group at one under Spirit Dragon. Additional actual canonical material Fusion recipe/regression verified; explicit legacy FaceupEx/sterile mandatory-material adapters; native Omega/general mandatory effects open.', 'script_sha256':sha(source),'batch':bhodi_path.name,'batch_sha256':sha(bhodi_path),'evidence_type':batch['scope'],'installed_matches':True,'full_card_audit':'OPEN','native_omega_verified':False})
 abe_path=OUT/'current-abe-spirit-limit-batch.json'
 if abe_path.exists():
  batch=json.loads(abe_path.read_text());source=ROOT/'public/CCG Downloads/CCG_Scripts/c259635008.lua'
  assert batch['baseline_cases']==3
  for dependency,h in batch['runtime_dependencies_sha256'].items():verify_dependency(dependency,h)
  for run in batch['runs']:
   artifact=OUT/run['artifact'];assert sha(artifact)==run['artifact_sha256']
   data=json.loads(artifact.read_text());assert data['script_sha256']==sha(source)
   assert [r['test'] for r in data['results'] if r['failure']]==run['expected_failures']
  assert sha(FILES/'Scripts'/source.name)==sha(source)
  assert not any(r['passcode']==259635008 for r in rows)
  rows.append({'passcode':259635008,'name':roster[259635008]['name'],'repair':'Preserve mandatory Extra Deck return; block subsequent simultaneous Spirit pair under Spirit Dragon. Explicit unavailable Synchro procedure disabled for initial Special Summon fixture; native Omega open.', 'script_sha256':sha(source),'batch':abe_path.name,'batch_sha256':sha(abe_path),'evidence_type':batch['scope'],'installed_matches':True,'full_card_audit':'OPEN','native_omega_verified':False})
 machina_path=OUT/'current-machina-spirit-limit-batch.json'
 if machina_path.exists():
  batch=json.loads(machina_path.read_text());source=ROOT/'public/CCG Downloads/CCG_Scripts/c259247853.lua'
  assert batch['baseline_cases']==3
  for dependency,h in batch['runtime_dependencies_sha256'].items():verify_dependency(dependency,h)
  for run in batch['runs']:
   artifact=OUT/run['artifact'];assert sha(artifact)==run['artifact_sha256']
   data=json.loads(artifact.read_text());assert data['script_sha256']==sha(source)
   assert [r['test'] for r in data['results'] if r['failure']]==run['expected_failures']
  assert sha(FILES/'Scripts'/source.name)==sha(source)
  assert not any(r['passcode']==259247853 for r in rows)
  rows.append({'passcode':259247853,'name':roster[259247853]['name'],'repair':'Block simultaneous Extra Link pair under Spirit at targeting/resolution; isolated public card-data and bounded group-selection adapters. Initial source/anchor procedures, general selection and native Omega open.', 'script_sha256':sha(source),'batch':machina_path.name,'batch_sha256':sha(machina_path),'evidence_type':batch['scope'],'installed_matches':True,'full_card_audit':'OPEN','native_omega_verified':False})
 eisodos_path=OUT/'current-eisodos-leave-field-batch.json'
 if eisodos_path.exists():
  batch=json.loads(eisodos_path.read_text());source=ROOT/'public/CCG Downloads/CCG_Scripts/c241543138.lua'
  assert batch['baseline_cases']==3
  for dependency,h in batch['runtime_dependencies_sha256'].items():verify_dependency(dependency,h)
  for run in batch['runs']:
   artifact=OUT/run['artifact'];assert sha(artifact)==run['artifact_sha256']
   data=json.loads(artifact.read_text());assert data['script_sha256']==sha(source)
   assert [r['test'] for r in data['results'] if r['failure']]==run['expected_failures']
  assert sha(FILES/'Scripts'/source.name)==sha(source)
  assert not any(r['passcode']==241543138 for r in rows)
  rows.append({'passcode':241543138,'name':roster[241543138]['name'],'repair':'Add Spirit restriction at token targeting/resolution; retain separate IsPlayerCanSpecialSummonCount guard.', 'script_sha256':sha(source),'batch':eisodos_path.name,'batch_sha256':sha(eisodos_path),'evidence_type':batch['scope'],'installed_matches':True,'full_card_audit':'OPEN','native_omega_verified':False})
 breeze_path=OUT/'current-breeze-spirit-limit-batch.json'
 if breeze_path.exists():
  batch=json.loads(breeze_path.read_text());source=ROOT/'public/CCG Downloads/CCG_Scripts/c230998543.lua'
  assert batch['baseline_cases']==3
  for dependency,h in batch['runtime_dependencies_sha256'].items():verify_dependency(dependency,h)
  for run in batch['runs']:
   artifact=OUT/run['artifact'];assert sha(artifact)==run['artifact_sha256']
   data=json.loads(artifact.read_text());assert data['script_sha256']==sha(source)
   assert [r['test'] for r in data['results'] if r['failure']]==run['expected_failures']
  assert sha(FILES/'Scripts'/source.name)==sha(source)
  assert not any(r['passcode']==230998543 for r in rows)
  rows.append({'passcode':230998543,'name':roster[230998543]['name'],'repair':'Add Spirit guard to detached source/Hand pair targeting and resolution; retain count API. Explicit legacy detach-event adapter; original event and native Omega unverified.', 'script_sha256':sha(source),'batch':breeze_path.name,'batch_sha256':sha(breeze_path),'evidence_type':batch['scope'],'installed_matches':True,'full_card_audit':'OPEN','native_omega_verified':False})
 otakemaru_path=OUT/'current-otakemaru-spirit-limit-batch.json'
 if otakemaru_path.exists():
  batch=json.loads(otakemaru_path.read_text());source=ROOT/'public/CCG Downloads/CCG_Scripts/c221855414.lua'
  assert batch['baseline_cases']==5
  for dependency,h in batch['runtime_dependencies_sha256'].items():verify_dependency(dependency,h)
  for run in batch['runs']:
   artifact=OUT/run['artifact'];assert sha(artifact)==run['artifact_sha256']
   data=json.loads(artifact.read_text());assert data['script_sha256']==sha(source)
   assert [r['test'] for r in data['results'] if r['failure']]==run['expected_failures']
  assert sha(FILES/'Scripts'/source.name)==sha(source)
  assert not any(r['passcode']==221855414 for r in rows)
  rows.append({'passcode':221855414,'name':roster[221855414]['name'],'repair':'Limit mandatory End Phase return effect to once per turn; prevents repeated forced activation when return is blocked. Canonical actual return/pair, Spirit, wrong total/roles and blocked return tested. Proper Synchro and native Omega open.', 'script_sha256':sha(source),'batch':otakemaru_path.name,'batch_sha256':sha(otakemaru_path),'evidence_type':batch['scope'],'installed_matches':True,'full_card_audit':'OPEN','native_omega_verified':False})
 volt_path=OUT/'current-volt-union-equip-batch.json'
 if volt_path.exists():
  batch=json.loads(volt_path.read_text());source=ROOT/'public/CCG Downloads/CCG_Scripts/c238274859.lua'
  assert batch['baseline_cases']==7
  for dependency,h in batch['runtime_dependencies_sha256'].items():verify_dependency(dependency,h)
  for run in batch['runs']:
   artifact=OUT/run['artifact'];assert sha(artifact)==run['artifact_sha256']
   data=json.loads(artifact.read_text());assert data['script_sha256']==sha(source)
   assert [r['test'] for r in data['results'] if r['failure']]==run['expected_failures']
  summon_path=OUT/'current-volt-spirit-limit-batch.json'
  summon=json.loads(summon_path.read_text());assert summon['baseline_cases']==7
  for dependency,h in summon['runtime_dependencies_sha256'].items():verify_dependency(dependency,h)
  for run in summon['runs']:
   artifact=OUT/run['artifact'];assert sha(artifact)==run['artifact_sha256']
   data=json.loads(artifact.read_text());assert data['script_sha256']==sha(source)
   assert [r['test'] for r in data['results'] if r['failure']]==run['expected_failures']
  assert sha(FILES/'Scripts'/source.name)==sha(source)
  assert not any(r['passcode']==238274859 for r in rows)
  rows.append({'passcode':238274859,'name':roster[238274859]['name'],'repair':'Apply Necrovalley Union filter at equip targeting, matching resolution. Seven equip cases and removed-filter control; seven Hand pair/LIGHT lock cases with two controls. Proper Union protections, limits/renewal, interruptions and native Omega open.', 'script_sha256':sha(source),'batch':volt_path.name,'batch_sha256':sha(volt_path),'evidence_type':batch['scope'],'installed_matches':True,'full_card_audit':'OPEN','native_omega_verified':False})
 lightning_path=OUT/'current-lightning-shot-followup-batch.json'
 if lightning_path.exists():
  batch=json.loads(lightning_path.read_text());source=ROOT/'public/CCG Downloads/CCG_Scripts/c259446105.lua'
  assert batch['baseline_cases']==3
  for dependency,h in batch['runtime_dependencies_sha256'].items():verify_dependency(dependency,h)
  for run in batch['runs']:
   artifact=OUT/run['artifact'];assert sha(artifact)==run['artifact_sha256']
   data=json.loads(artifact.read_text());assert data['script_sha256']==sha(source)
   assert [r['test'] for r in data['results'] if r['failure']]==run['expected_failures']
  main_batch=json.loads((OUT/'current-lightning-shot-batch.json').read_text());assert main_batch['baseline_cases']==7
  for dependency,h in main_batch['runtime_dependencies_sha256'].items():verify_dependency(dependency,h)
  for run in main_batch['runs']:
   artifact=OUT/run['artifact'];assert sha(artifact)==run['artifact_sha256']
   data=json.loads(artifact.read_text());assert data['script_sha256']==sha(source)
   assert [r['test'] for r in data['results'] if r['failure']]==run['expected_failures']
  assert sha(FILES/'Scripts'/source.name)==sha(source)
  assert not any(r['passcode']==259446105 for r in rows)
  rows.append({'passcode':259446105,'name':roster[259446105]['name'],'repair':'Cancel pending GY movement before shuffling negated activation handler. Actual opposing Spell/Trap activations now reach Deck after effect detach; monster/alternate host regressions retained. Proper Xyz and native Omega open.', 'script_sha256':sha(source),'batch':lightning_path.name,'batch_sha256':sha(lightning_path),'evidence_type':batch['scope'],'installed_matches':True,'full_card_audit':'OPEN','native_omega_verified':False})
 navi_path=OUT/'current-navi-necrovalley-batch.json'
 if navi_path.exists():
  batch=json.loads(navi_path.read_text());source=ROOT/'public/CCG Downloads/CCG_Scripts/c259548744.lua'
  assert batch['baseline_cases']==2
  for dependency,h in batch['runtime_dependencies_sha256'].items():verify_dependency(dependency,h)
  for run in batch['runs']:
   artifact=OUT/run['artifact'];assert sha(artifact)==run['artifact_sha256']
   data=json.loads(artifact.read_text());assert data['script_sha256']==sha(source)
   assert [r['test'] for r in data['results'] if r['failure']]==run['expected_failures']
  for regression_name,cases in [('current-navi-recycle-attach-batch.json',3),('current-navi-negation-batch.json',6)]:
   regression=json.loads((OUT/regression_name).read_text());assert regression['baseline_cases']==cases
   for dependency,h in regression['runtime_dependencies_sha256'].items():verify_dependency(dependency,h)
   for run in regression['runs']:
    artifact=OUT/run['artifact'];assert sha(artifact)==run['artifact_sha256']
    data=json.loads(artifact.read_text());assert data['script_sha256']==sha(source)
    assert [r['test'] for r in data['results'] if r['failure']]==run['expected_failures']
  assert sha(FILES/'Scripts'/source.name)==sha(source)
  assert not any(r['passcode']==259548744 for r in rows)
  rows.append({'passcode':259548744,'name':roster[259548744]['name'],'repair':'Apply Necrovalley filter when counting/selecting GY recycle candidates. Protected cards excluded and no detach if no legal recycle pool. Overlay branch bounded by explicit neutral adapter; proper Xyz/native Omega open.', 'script_sha256':sha(source),'batch':navi_path.name,'batch_sha256':sha(navi_path),'evidence_type':batch['scope'],'installed_matches':True,'full_card_audit':'OPEN','native_omega_verified':False})
 egg_path=OUT/'current-egg-hand-search-batch.json'
 if egg_path.exists():
  batch=json.loads(egg_path.read_text());source=ROOT/'public/CCG Downloads/CCG_Scripts/c259464064.lua'
  assert batch['baseline_cases']==5
  for dependency,h in batch['runtime_dependencies_sha256'].items():verify_dependency(dependency,h)
  for run in batch['runs']:
   artifact=OUT/run['artifact'];assert sha(artifact)==run['artifact_sha256']
   data=json.loads(artifact.read_text());assert data['script_sha256']==sha(source)
   assert [r['test'] for r in data['results'] if r['failure']]==run['expected_failures']
  revival=json.loads((OUT/'current-egg-revival-batch.json').read_text());assert revival['baseline_cases']==4
  for dependency,h in revival['runtime_dependencies_sha256'].items():verify_dependency(dependency,h)
  for run in revival['runs']:
   artifact=OUT/run['artifact'];assert sha(artifact)==run['artifact_sha256']
   data=json.loads(artifact.read_text());assert data['script_sha256']==sha(source)
   assert [r['test'] for r in data['results'] if r['failure']]==run['expected_failures']
  assert sha(FILES/'Scripts'/source.name)==sha(source)
  for prefix,cases in [('battle',3),('extra-lock',2),('normal-search',3)]:
   regression=json.loads((OUT/f'current-egg-{prefix}-batch.json').read_text());assert regression['baseline_cases']==cases
   for dependency,h in regression['runtime_dependencies_sha256'].items():verify_dependency(dependency,h)
   for run in regression['runs']:
    artifact=OUT/run['artifact'];assert sha(artifact)==run['artifact_sha256']
    data=json.loads(artifact.read_text());assert data['script_sha256']==sha(source)
    assert [r['test'] for r in data['results'] if r['failure']]==run['expected_failures']
   assert any(r['control'] and r['expected_failures'] for r in regression['runs'])
  assert not any(r['passcode']==259464064 for r in rows)
  rows.append({'passcode':259464064,'name':roster[259464064]['name'],'repair':'Require faceup Obsidim in either Field Zone for native Hand summon procedure. Allow GY revival trigger during Damage Step after battle destruction. Listed-card search, shared limit, Extra Deck lock/reset and prior GY revival regressions preserved; official field effects/full card/native Omega open.', 'script_sha256':sha(source),'batch':egg_path.name,'batch_sha256':sha(egg_path),'evidence_type':batch['scope'],'installed_matches':True,'full_card_audit':'OPEN','native_omega_verified':False})
 shade_path=OUT/'current-shade-attach-batch.json'
 if shade_path.exists():
  source=ROOT/'public/CCG Downloads/CCG_Scripts/c259615843.lua'
  for prefix,cases in [('attach',3),('attach-safety',2),('aura',6),('summon',5)]:
   batch=json.loads((OUT/f'current-shade-{prefix}-batch.json').read_text());assert batch['baseline_cases']==cases
   for dependency,h in batch['runtime_dependencies_sha256'].items():verify_dependency(dependency,h)
   for run in batch['runs']:
    artifact=OUT/run['artifact'];assert sha(artifact)==run['artifact_sha256']
    data=json.loads(artifact.read_text());assert data['script_sha256']==sha(source)
    assert [r['test'] for r in data['results'] if r['failure']]==run['expected_failures']
  assert sha(FILES/'Scripts'/source.name)==sha(source)
  rows.append({'passcode':259615843,'name':roster[259615843]['name'],'repair':'Use legacy IsCanOverlay attachment eligibility so Spell targets permitted. Bounded neutral compatibility adapter in public runtime; Require distinct Xyz recipient and recheck immunity/overlay eligibility at resolution. General eligibility, multiple-host cases and native Omega remain open.','script_sha256':sha(source),'batch':shade_path.name,'batch_sha256':sha(shade_path),'installed_matches':True,'full_card_audit':'OPEN','native_omega_verified':False})
 plexus_path=OUT/'current-plexus-boost-scope-batch.json'
 if plexus_path.exists():
  source=ROOT/'public/CCG Downloads/CCG_Scripts/c259669838.lua'
  for prefix,cases in [('boost-scope',1),('shuffle',2),('necrovalley',1),('revival',4)]:
   batch=json.loads((OUT/f'current-plexus-{prefix}-batch.json').read_text());assert batch['baseline_cases']==cases
   for dependency,h in batch['runtime_dependencies_sha256'].items():verify_dependency(dependency,h)
   for run in batch['runs']:
    artifact=OUT/run['artifact'];assert sha(artifact)==run['artifact_sha256']
    data=json.loads(artifact.read_text());assert data['script_sha256']==sha(source)
    assert [r['test'] for r in data['results'] if r['failure']]==run['expected_failures']
  assert sha(FILES/'Scripts'/source.name)==sha(source)
  assert not any(r['passcode']==259669838 for r in rows)
  rows.append({'passcode':259669838,'name':roster[259669838]['name'],'repair':'Apply printed all-Krawler300 ATK/DEF boost to both fields. Actual shuffle and on-summon regressions preserved; original Link disabled in public tests, proper Link/native Omega open.','script_sha256':sha(source),'batch':plexus_path.name,'batch_sha256':sha(plexus_path),'installed_matches':True,'full_card_audit':'OPEN','native_omega_verified':False})
 vik_path=OUT/'current-vik-immunity-batch.json'
 if vik_path.exists():
  source=ROOT/'public/CCG Downloads/CCG_Scripts/c259113182.lua'
  for prefix,cases in [('immunity',2),('attach',6),('normal-search',4)]:
   batch=json.loads((OUT/f'current-vik-{prefix}-batch.json').read_text());assert batch['baseline_cases']==cases
   for dependency,h in batch['runtime_dependencies_sha256'].items():verify_dependency(dependency,h)
   for run in batch['runs']:
    artifact=OUT/run['artifact'];assert sha(artifact)==run['artifact_sha256']
    data=json.loads(artifact.read_text());assert data['script_sha256']==sha(source)
    assert [r['test'] for r in data['results'] if r['failure']]==run['expected_failures']
  assert sha(FILES/'Scripts'/source.name)==sha(source)
  assert not any(r['passcode']==259113182 for r in rows)
  rows.append({'passcode':259113182,'name':roster[259113182]['name'],'repair':'Recheck targeted recipient immunity at attachment resolution, matching pinned Overlay Regen reference. Native Hand/GY attachment and Normal Summon search regressions pass; native Omega open.','script_sha256':sha(source),'batch':vik_path.name,'batch_sha256':sha(vik_path),'installed_matches':True,'full_card_audit':'OPEN','native_omega_verified':False})
 calamities_path=OUT/'current-calamities-activation-batch.json'
 if calamities_path.exists():
  source=ROOT/'public/CCG Downloads/CCG_Scripts/c259187643.lua'
  for prefix,cases in [('activation',4),('lock',5),('flip',4),('flip-copies',1),('flip-shared',1)]:
   batch=json.loads((OUT/f'current-calamities-{prefix}-batch.json').read_text());assert batch['baseline_cases']==cases
   for dependency,h in batch['runtime_dependencies_sha256'].items():verify_dependency(dependency,h)
   for run in batch['runs']:
    artifact=OUT/run['artifact'];assert sha(artifact)==run['artifact_sha256']
    data=json.loads(artifact.read_text());assert data['script_sha256']==sha(source)
    assert [r['test'] for r in data['results'] if r['failure']]==run['expected_failures']
  assert sha(FILES/'Scripts'/source.name)==sha(source)
  assert not any(r['passcode']==259187643 for r in rows)
  rows.append({'passcode':259187643,'name':roster[259187643]['name'],'repair':'Separate optional activation take from card activation. Allow decline/empty pool/prior restricted activity without take or lock; accepted take retains history/future restriction with End Phase reset. Use native legacy single-card shared flip limit for independent copies and shared SpecialSummon/Set events. Public tests use explicit modern SINGLE flag mapping. Native Omega open.','script_sha256':sha(source),'batch':calamities_path.name,'batch_sha256':sha(calamities_path),'installed_matches':True,'full_card_audit':'OPEN','native_omega_verified':False})
 melantha_path=OUT/'current-melantha-summon-batch.json'
 if melantha_path.exists():
  source=ROOT/'public/CCG Downloads/CCG_Scripts/c259221974.lua'
  for prefix,cases in [('summon',3),('external',2)]:
   batch=json.loads((OUT/f'current-melantha-{prefix}-batch.json').read_text());assert batch['baseline_cases']==cases
   for dependency,h in batch['runtime_dependencies_sha256'].items():verify_dependency(dependency,h)
   for run in batch['runs']:
    artifact=OUT/run['artifact'];assert sha(artifact)==run['artifact_sha256']
    data=json.loads(artifact.read_text());assert data['script_sha256']==sha(source)
    assert [r['test'] for r in data['results'] if r['failure']]==run['expected_failures']
  assert sha(FILES/'Scripts'/source.name)==sha(source)
  assert not any(r['passcode']==259221974 for r in rows)
  rows.append({'passcode':259221974,'name':roster[259221974]['name'],'repair':'Own effect target/operation explicitly bypass initial procedure restriction; normal/set and external effect Hand/GY prohibitions retained. Taxation/battle/native Omega open.','script_sha256':sha(source),'batch':melantha_path.name,'batch_sha256':sha(melantha_path),'installed_matches':True,'full_card_audit':'OPEN','native_omega_verified':False})
 argalia_path=OUT/'current-argalia-immunity-batch.json'
 if argalia_path.exists():
  source=ROOT/'public/CCG Downloads/CCG_Scripts/c259748623.lua'
  for prefix,cases in [('immunity',2),('attach',6),('destroy',4),('procedure',6),('destroy-immunity',2),('necrovalley',2)]:
   batch=json.loads((OUT/f'current-argalia-{prefix}-batch.json').read_text());assert batch['baseline_cases']==cases
   for dependency,h in batch['runtime_dependencies_sha256'].items():verify_dependency(dependency,h)
   for run in batch['runs']:
    artifact=OUT/run['artifact'];assert sha(artifact)==run['artifact_sha256']
    data=json.loads(artifact.read_text());assert data['script_sha256']==sha(source)
    assert [r['test'] for r in data['results'] if r['failure']]==run['expected_failures']
  assert sha(FILES/'Scripts'/source.name)==sha(source)
  assert not any(r['passcode']==259748623 for r in rows)
  rows.append({'passcode':259748623,'name':roster[259748623]['name'],'repair':'Recheck targeted recipient immunity at Quick attachment resolution. Use IsCanOverlay for optional opponent-GY attachment including Spells; explicit bounded public adapter. Optional attachment rechecks recipient immunity. Apply Necrovalley filter to optional opponent-GY eligibility; protected cards retained and destruction preserved. Native Hand/GY attachment regressions pass; native Omega open.','script_sha256':sha(source),'batch':argalia_path.name,'batch_sha256':sha(argalia_path),'installed_matches':True,'full_card_audit':'OPEN','native_omega_verified':False})
 arktos_path=OUT/'current-arktos-pendulum-batch.json'
 if arktos_path.exists():
  source=ROOT/'public/CCG Downloads/CCG_Scripts/c259537607.lua'
  for prefix,cases in [('pendulum',6),('movement',6),('normal-movement',5),('pendulum-late',2)]:
   batch=json.loads((OUT/f'current-arktos-{prefix}-batch.json').read_text());assert batch['baseline_cases']==cases
   for dependency,h in batch['runtime_dependencies_sha256'].items():verify_dependency(dependency,h)
   for run in batch['runs']:
    artifact=OUT/run['artifact'];assert sha(artifact)==run['artifact_sha256']
    data=json.loads(artifact.read_text());assert data['script_sha256']==sha(source)
    assert [r['test'] for r in data['results'] if r['failure']]==run['expected_failures']
  assert sha(FILES/'Scripts'/source.name)==sha(source)
  assert not any(r['passcode']==259537607 for r in rows)
  rows.append({'passcode':259537607,'name':roster[259537607]['name'],'repair':'Remove extra controller argument from Duel.SpecialSummon so Pendulum same-column zone mask is used, matching pinned Vaylantz reference. Recheck same-column summon eligibility at resolution to preserve Pendulum source when destination becomes blocked. No adapters; proper Fusion support, Quick/limits/native Omega remain open.','script_sha256':sha(source),'batch':arktos_path.name,'batch_sha256':sha(arktos_path),'installed_matches':True,'full_card_audit':'OPEN','native_omega_verified':False})
 gambling_path=OUT/'current-gambling-interruption-batch.json'
 if gambling_path.exists():
  source=ROOT/'public/CCG Downloads/CCG_Scripts/c224774049.lua'
  for prefix,cases in [('outcomes',5),('interruption',2)]:
   batch=json.loads((OUT/f'current-gambling-{prefix}-batch.json').read_text());assert batch['baseline_cases']==cases
   for dependency,h in batch['runtime_dependencies_sha256'].items():verify_dependency(dependency,h)
   for run in batch['runs']:
    artifact=OUT/run['artifact'];assert sha(artifact)==run['artifact_sha256']
    data=json.loads(artifact.read_text());assert data['script_sha256']==sha(source)
    assert [r['test'] for r in data['results'] if r['failure']]==run['expected_failures']
  assert sha(FILES/'Scripts'/source.name)==sha(source)
  assert not any(r['passcode']==224774049 for r in rows)
  rows.append({'passcode':224774049,'name':roster[224774049]['name'],'repair':'Apply printed2000LP loss before empty-at-resolution Deck early return, since no card added. Actual native CL2 empties Deck regression/control; blocked-add and ordinary hit/miss/short/empty-activation preserved. Explicit legacy TARGET_PARAM adapter, native Omega/all die outcomes remain open','script_sha256':sha(source),'batch':gambling_path.name,'batch_sha256':sha(gambling_path),'installed_matches':True,'full_card_audit':'OPEN','native_omega_verified':False})
 nemleria_path=OUT/'current-nemleria-eligibility-batch.json'
 if nemleria_path.exists():
  source=ROOT/'public/CCG Downloads/CCG_Scripts/c259766646.lua'
  batch=json.loads(nemleria_path.read_text());assert batch['baseline_cases']==4
  for dependency,h in batch['runtime_dependencies_sha256'].items():verify_dependency(dependency,h)
  for run in batch['runs']:
   artifact=OUT/run['artifact'];assert sha(artifact)==run['artifact_sha256']
   data=json.loads(artifact.read_text());assert data['script_sha256']==sha(source)
   assert [r['test'] for r in data['results'] if r['failure']]==run['expected_failures']
  assert sha(FILES/'Scripts'/source.name)==sha(source)
  assert not any(r['passcode']==259766646 for r in rows)
  rows.append({'passcode':259766646,'name':roster[259766646]['name'],'repair':'Require Dreaming Nemleria IsAbleToExtra for initial eligibility and resolution selection. Prevent activation when native Deck/Extra prohibition makes first step impossible; preserve Hand/Deck faceup Extra placement and subsequent Nemleria Spell Set. Four native scenarios/two controls; no adapters. Native Omega/full card open.','script_sha256':sha(source),'batch':nemleria_path.name,'batch_sha256':sha(nemleria_path),'installed_matches':True,'full_card_audit':'OPEN','native_omega_verified':False})
 phlogistic_path=OUT/'current-phlogistic-damage-batch.json'
 if phlogistic_path.exists():
  source=ROOT/'public/CCG Downloads/CCG_Scripts/c219714894.lua'
  batch=json.loads(phlogistic_path.read_text());assert batch['baseline_cases']==2
  for dependency,h in batch['runtime_dependencies_sha256'].items():verify_dependency(dependency,h)
  for run in batch['runs']:
   artifact=OUT/run['artifact'];assert sha(artifact)==run['artifact_sha256']
   data=json.loads(artifact.read_text());assert data['script_sha256']==sha(source)
   assert [r['test'] for r in data['results'] if r['failure']]==run['expected_failures']
  assert sha(FILES/'Scripts'/source.name)==sha(source)
  assert not any(r['passcode']==219714894 for r in rows)
  rows.append({'passcode':219714894,'name':roster[219714894]['name'],'repair':'Use actual Duel.Damage return for half-inflicted-damage ATK gain; native2000LPpayment/full1000damage/reduced500damage cases and oldformula/noBoost controls. No adapters; GY setting/countlimits/native Omega/full card open.','script_sha256':sha(source),'batch':phlogistic_path.name,'batch_sha256':sha(phlogistic_path),'installed_matches':True,'full_card_audit':'OPEN','native_omega_verified':False})
 nautica_path=OUT/'current-nautica-optional-search-batch.json'
 if nautica_path.exists():
  source=ROOT/'public/CCG Downloads/CCG_Scripts/c259797813.lua'
  batch=json.loads(nautica_path.read_text());assert batch['baseline_cases']==4
  for dependency,h in batch['runtime_dependencies_sha256'].items():verify_dependency(dependency,h)
  for run in batch['runs']:
   artifact=OUT/run['artifact'];assert sha(artifact)==run['artifact_sha256']
   data=json.loads(artifact.read_text());assert data['script_sha256']==sha(source)
   assert [r['test'] for r in data['results'] if r['failure']]==run['expected_failures']
  assert sha(FILES/'Scripts'/source.name)==sha(source)
  assert not any(r['passcode']==259797813 for r in rows)
  rows.append({'passcode':259797813,'name':roster[259797813]['name'],'repair':'Honor optional activation search with eligibility check and SelectYesNo before Deck/GY monster selection. Four actual accept/decline cases and mandatory/no-add controls. No adapters; chain followup, uniqueness, native Omega and full card remain open.','script_sha256':sha(source),'batch':nautica_path.name,'batch_sha256':sha(nautica_path),'installed_matches':True,'full_card_audit':'OPEN','native_omega_verified':False})
 haunt_path=OUT/'current-ghostrick-haunt-self-set-batch.json'
 if haunt_path.exists():
  source=ROOT/'public/CCG Downloads/CCG_Scripts/c241540236.lua'
  batch=json.loads(haunt_path.read_text());assert batch['baseline_cases']==5
  for dependency,h in batch['runtime_dependencies_sha256'].items():verify_dependency(dependency,h)
  for run in batch['runs']:
   artifact=OUT/run['artifact'];assert sha(artifact)==run['artifact_sha256']
   data=json.loads(artifact.read_text());assert data['script_sha256']==sha(source)
   assert [r['test'] for r in data['results'] if r['failure']]==run['expected_failures']
  assert sha(FILES/'Scripts'/source.name)==sha(source)
  assert not any(r['passcode']==241540236 for r in rows)
  rows.append({'passcode':241540236,'name':roster[241540236]['name'],'repair':'Add EFFECT_FLAG_DELAY to optional Graveyard EVENT_CHAINING trigger so Level1 Ghostrick Hand activation offers selfSet after chain resolution. Five native scenarios and noSet/noRedirect/noDelay/ignoreLevel controls verify actual selfSet and subsequent destruction banishredirect. Position/return five-case regression preserved. No adapters; interruption/other leavefield routes/native Omega/full card remain open','script_sha256':sha(source),'batch':haunt_path.name,'batch_sha256':sha(haunt_path),'installed_matches':True,'full_card_audit':'OPEN','native_omega_verified':False})
 gravinity_path=OUT/'current-gravinity-transfer-recipient-choice-batch.json'
 if gravinity_path.exists():
  batch=json.loads(gravinity_path.read_text());assert batch['baseline_cases']==16 and not batch.get('diagnostic_only')
  for dependency,h in batch['runtime_dependencies_sha256'].items():verify_dependency(dependency,h)
  for code in [215768254,235538173,249680945,256172827]:
   source=ROOT/'public/CCG Downloads/CCG_Scripts'/f'c{code}.lua'
   runs=[r for r in batch['runs'] if r['recipient']==code];assert len(runs)==4
   for run in runs:
    artifact=OUT/run['artifact'];assert sha(artifact)==run['artifact_sha256']
    data=json.loads(artifact.read_text());assert data['recipient_script_sha256']==sha(source)
    assert [r['test'] for r in data['results'] if r['failure']]==run['expected_failures']
   assert sha(FILES/'Scripts'/source.name)==sha(source)
   assert not any(r['passcode']==code for r in rows)
   rows.append({'passcode':code,'name':roster[code]['name'],'repair':'Honor optional TransferCall all-effects permission on primary/movement selected routes. Consume flag once, prompt with additional effect description, preserve primary-before-movement sequence. Four real-recipient accept/decline scenarios and mandatory/no-extra/no-consume controls; native flag/type/destruction assertions. No adapters; permission on negated activation/other recipient effects/native Omega/full card open.','script_sha256':sha(source),'batch':gravinity_path.name,'batch_sha256':sha(gravinity_path),'installed_matches':True,'full_card_audit':'OPEN','native_omega_verified':False})
 melody_path=OUT/'current-melody-division-extra-normal-batch.json'
 if melody_path.exists():
  source=ROOT/'public/CCG Downloads/CCG_Scripts/c243420199.lua'
  for prefix,cases in [('extra-normal',4),('attach',7)]:
   batch=json.loads((OUT/f'current-melody-division-{prefix}-batch.json').read_text());assert batch['baseline_cases']==cases and not batch.get('diagnostic_only')
   for dependency,h in batch['runtime_dependencies_sha256'].items():verify_dependency(dependency,h)
   for run in batch['runs']:
    artifact=OUT/run['artifact'];assert sha(artifact)==run['artifact_sha256']
    data=json.loads(artifact.read_text());assert data['script_sha256']==sha(source)
    assert [r['test'] for r in data['results'] if r['failure']]==run['expected_failures']
  assert sha(FILES/'Scripts'/source.name)==sha(source)
  assert not any(r['passcode']==243420199 for r in rows)
  rows.append({'passcode':243420199,'name':roster[243420199]['name'],'repair':'Use value0 for unrestricted Level2 extra NormalSummon and clone EFFECT_EXTRA_SET_COUNT for printed extra Set. Native four-case summon/set/two-copy shared extra use/wrongset tests and noExtra/oldValue/noSet/ignoreSet controls; seven-case banish-cost attachment regression preserved. No adapters; turn reset/other levels/materialeligibility/nativeOmega/full card open.','script_sha256':sha(source),'batch':melody_path.name,'batch_sha256':sha(melody_path),'installed_matches':True,'full_card_audit':'OPEN','native_omega_verified':False})
 ganan_path=OUT/'current-ganan-direct-battle-batch.json'
 if ganan_path.exists():
  source=ROOT/'public/CCG Downloads/CCG_Scripts/c259459462.lua'
  for prefix,cases in [('direct-battle',3),('chain-damage',2),('unique',3)]:
   batch=json.loads((OUT/f'current-ganan-{prefix}-batch.json').read_text());assert batch['baseline_cases']==cases and not batch.get('diagnostic_only')
   for dependency,h in batch['runtime_dependencies_sha256'].items():verify_dependency(dependency,h)
   for run in batch['runs']:
    artifact=OUT/run['artifact'];assert sha(artifact)==run['artifact_sha256']
    data=json.loads(artifact.read_text());assert data['script_sha256']==sha(source)
    assert [r['test'] for r in data['results'] if r['failure']]==run['expected_failures']
  assert sha(FILES/'Scripts'/source.name)==sha(source)
  assert not any(r['passcode']==259459462 for r in rows)
  rows.append({'passcode':259459462,'name':roster[259459462]['name'],'repair':'Use EFFECT_IGNORE_BATTLE_TARGET so Ganan remains untargetable while lone Ganan permits printed direct attacks. Three actual native battle cases verify1000directdamage below3000ATK/zero at3000 and other defender targeted without Ganan. OldCode/noProtection/noIgnore controls; chainATK/damage2case and uniqueness3case regressions pass. No adapters; proper Link/negatedchains/nativeOmega/full card open','script_sha256':sha(source),'batch':ganan_path.name,'batch_sha256':sha(ganan_path),'installed_matches':True,'full_card_audit':'OPEN','native_omega_verified':False})
 frozen_path=OUT/'current-frozen-girl-transfer-batch.json'
 if frozen_path.exists():
  batch=json.loads(frozen_path.read_text());assert batch['baseline_cases']==3 and not batch.get('diagnostic_only')
  for dependency,h in batch['runtime_dependencies_sha256'].items():verify_dependency(dependency,h)
  for code in [222676270,223505382]:
   source=ROOT/'public/CCG Downloads/CCG_Scripts'/f'c{code}.lua'
   for run in batch['runs']:
    artifact=OUT/run['artifact'];assert sha(artifact)==run['artifact_sha256']
    data=json.loads(artifact.read_text());assert data['script_sha256' if code==222676270 else 'secondary_script_sha256']==sha(source)
    assert [r['test'] for r in data['results'] if r['failure']]==run['expected_failures']
   assert sha(FILES/'Scripts'/source.name)==sha(source)
   assert not any(r['passcode']==code for r in rows)
   rows.append({'passcode':code,'name':roster[code]['name'],'repair':'Register effect-specific faceup placement marker on TransferCall Deckmonster SZONE placement and check it in FrozenGirl response condition. Three native cases: discard/effectnegation, decline allowing actual placement, unrelated damage excluded. Four controls detect missing marker/negation/discard and overly broad registration. Transfer placement4/expiry2/interruption2 and recipient-choice16 regressions refreshed. Other qualifying placements/cost and continuous replacement exclusions/limits/nativeOmega/full card remain OPEN.','script_sha256':sha(source),'batch':frozen_path.name,'batch_sha256':sha(frozen_path),'installed_matches':True,'full_card_audit':'OPEN','native_omega_verified':False})
 swamp_path=OUT/'current-frozen-girl-swamp-batch.json'
 if swamp_path.exists():
  source=ROOT/'public/CCG Downloads/CCG_Scripts/c239935101.lua'
  batch=json.loads(swamp_path.read_text());assert batch['baseline_cases']==3 and not batch.get('diagnostic_only')
  for dependency,h in batch['runtime_dependencies_sha256'].items():verify_dependency(dependency,h)
  for run in batch['runs']:
   artifact=OUT/run['artifact'];assert sha(artifact)==run['artifact_sha256']
   data=json.loads(artifact.read_text());assert data['secondary_script_sha256']==sha(source)
   assert [r['test'] for r in data['results'] if r['failure']]==run['expected_failures']
  assert sha(FILES/'Scripts'/source.name)==sha(source)
  assert not any(r['passcode']==239935101 for r in rows)
  rows.append({'passcode':239935101,'name':roster[239935101]['name'],'repair':'Mark only initial activation WATER Reptile Deckmonster faceup SZONE placement for FrozenGirl response. Native three-case discard/effectnegation, decline with actual placement and unrelated damage exclusion; missing marker/negation/discard and broad marker controls. No adapters; battle/endphase effects, placement eligibility/interruption, nativeOmega/full card OPEN.','script_sha256':sha(source),'batch':swamp_path.name,'batch_sha256':sha(swamp_path),'installed_matches':True,'full_card_audit':'OPEN','native_omega_verified':False})
 meeting_marker_path=OUT/'current-frozen-girl-crewal-210366076-batch.json'
 if meeting_marker_path.exists():
  source=ROOT/'public/CCG Downloads/CCG_Scripts/c210366076.lua'
  for name,cases,secondary in [('current-frozen-girl-crewal-210366076-batch.json',3,True),('current-crewal-meeting-placement-batch.json',12,False),('current-crewal-meeting-recover-batch.json',5,False)]:
   batch=json.loads((OUT/name).read_text());assert batch['baseline_cases']==cases and not batch.get('diagnostic_only')
   for dependency,h in batch['runtime_dependencies_sha256'].items():verify_dependency(dependency,h)
   for run in batch['runs']:
    artifact=OUT/run['artifact'];assert sha(artifact)==run['artifact_sha256']
    data=json.loads(artifact.read_text());assert data['secondary_script_sha256' if secondary else 'script_sha256']==sha(source)
    assert [r['test'] for r in data['results'] if r['failure']]==run['expected_failures']
  assert sha(FILES/'Scripts'/source.name)==sha(source)
  assert not any(r['passcode']==210366076 for r in rows)
  rows.append({'passcode':210366076,'name':roster[210366076]['name'],'repair':'Mark initial activation Zombie Deck/GY/banished placement as faceup ContinuousTrap for FrozenGirl response; recovery ignition unmarked. Native real GYZombie interaction3cases4controls confirms paid ContinuousTrap cost persists after effectnegation. Current placement12cases4controls and recovery5cases2controls preserved. No adapters; other interactions/interruption/nativeOmega/full card OPEN.','script_sha256':sha(source),'batch':meeting_marker_path.name,'batch_sha256':sha(meeting_marker_path),'installed_matches':True,'full_card_audit':'OPEN','native_omega_verified':False})
 bear_path=OUT/'current-teleum-bear-negation-repaired-batch.json'
 if bear_path.exists():
  source=ROOT/'public/CCG Downloads/CCG_Scripts/c251699681.lua'
  for name,cases,key in [('current-teleum-bear-negation-repaired-batch.json',2,'diagnostic_cases'),('current-teleum-bear-attack-repaired-batch.json',2,'baseline_cases'),('current-teleum-bear-history-preservation-repaired-batch.json',4,'baseline_cases')]:
   batch=json.loads((OUT/name).read_text());assert batch[key]==cases
   for dependency,h in batch['runtime_dependencies_sha256'].items():verify_dependency(dependency,h)
   assert source.relative_to(ROOT).as_posix() in batch['runtime_dependencies_sha256']
   for run in batch['runs']:
    artifact=OUT/run['artifact'];assert sha(artifact)==run['artifact_sha256']
    data=json.loads(artifact.read_text());assert [r['test'] for r in data['results'] if r['failure']]==run['expected_failures']
   assert any(r['control'] is None and not r['expected_failures'] for r in batch['runs'])
  assert sha(FILES/'Scripts'/source.name)==sha(source)
  assert not any(r['passcode']==251699681 for r in rows)
  rows.append({'passcode':251699681,'name':roster[251699681]['name'],'repair':'Rollback exactly one permanent and turn activation-history flag for relevant player on EVENT_CHAIN_NEGATED. Actual attack-response activation/effect-negation2cases, attack/persistence2cases and seeded prior/bothplayer history preservation4cases, each with2controls. Official FAQ12712 activation-count distinction applied by inference to custom Trap. Prior counts are seeded, not actual prior activations. No adapters; summon-response legacy GetReadyChain, actual multiple/bothplayer activations, nativeOmega/fullcard OPEN.','script_sha256':sha(source),'batch':bear_path.name,'batch_sha256':sha(bear_path),'installed_matches':True,'full_card_audit':'OPEN','native_omega_verified':False})
 hallo_path=OUT/'current-happy-halloween-counter-repaired-batch.json'
 if hallo_path.exists():
  source=ROOT/'public/CCG Downloads/CCG_Scripts/c255977900.lua';batch=json.loads(hallo_path.read_text());assert batch['baseline_cases']==9
  for dependency,h in batch['runtime_dependencies_sha256'].items():verify_dependency(dependency,h)
  assert sha(FILES/'Scripts'/source.name)==sha(source)
  for run in batch['runs']:
   artifact=OUT/run['artifact'];assert sha(artifact)==run['artifact_sha256'];data=json.loads(artifact.read_text());assert data['script_sha256']==sha(source);assert [r['test'] for r in data['results'] if r['failure']]==run['expected_failures'];assert not data['relation_guard_comparison']
  assert sum(r['control'] is None and not r['expected_failures'] for r in batch['runs'])==2
  assert any(r['control']=='original-guard' and r['expected_failures']==[{}] for r in batch['runs'])
  assert not any(r['passcode']==255977900 for r in rows)
  rows.append({'passcode':255977900,'name':roster[255977900]['name'],'repair':'Remove IsRelateToEffect guard from continuous SpecialSummon counter operation; retain faceup guard. Full Ween actual summon/group event one-counter accrual; wrongmonster/Normal/opponent excluded. Native disabled/facedown/sourceGY boundaries, nine cases/five control runs including original guard. No seeded counters/adapters. Activation/cost/revival/limits/nativeOmega/fullcard OPEN.','script_sha256':sha(source),'batch':hallo_path.name,'batch_sha256':sha(hallo_path),'installed_matches':True,'full_card_audit':'OPEN','native_omega_verified':False})
 faceup_path=OUT/'current-happy-halloween-faceup-repaired-batch.json'
 if faceup_path.exists():
  source=ROOT/'public/CCG Downloads/CCG_Scripts/c255977900.lua';batch=json.loads(faceup_path.read_text());assert batch['baseline_cases']==6
  for dependency,h in batch['runtime_dependencies_sha256'].items():verify_dependency(dependency,h)
  for run in batch['runs']:
   artifact=OUT/run['artifact'];assert sha(artifact)==run['artifact_sha256'];data=json.loads(artifact.read_text());assert data['script_sha256']==sha(source);assert [r['test'] for r in data['results'] if r['failure']]==run['expected_failures'];assert not any(r['logs'] for r in data['results'])
  assert any(r['control']=='original-faceup' and len(r['expected_failures'])==2 for r in batch['runs'])
  row=next(r for r in rows if r['passcode']==255977900);row['repair']+=' Additional repair: require source faceup in ignition spop. Six native reference/facedown/disabled Hand/GY cases and four controls, including original-faceup reproducing both facedown failures; exact-byte backups happy-halloween-before-faceup-repair. Cost preserved. Native engine handles same-chain source departure/re-entry; faceup guard adds missing facedown exclusion.';row['additional_batch']=faceup_path.name;row['additional_batch_sha256']=sha(faceup_path)
 helmsman_path=OUT/'current-helmsman-hand-capacity-repaired-batch.json'
 if helmsman_path.exists():
  source=ROOT/'public/CCG Downloads/CCG_Scripts/c215730767.lua'
  for name,cases in [('current-helmsman-hand-capacity-repaired-batch.json',5),('current-helmsman-hand-summon-batch.json',6),('current-helmsman-hand-locks-batch.json',6),('current-helmsman-hand-negation-batch.json',4)]:
   batch=json.loads((OUT/name).read_text());assert batch['baseline_cases']==cases
   for dependency,h in batch['runtime_dependencies_sha256'].items():verify_dependency(dependency,h)
   for run in batch['runs']:
    artifact=OUT/run['artifact'];assert sha(artifact)==run['artifact_sha256'];data=json.loads(artifact.read_text());assert data['script_sha256']==sha(source);assert [r['test'] for r in data['results'] if r['failure']]==run['expected_failures'];assert not any(r['logs'] for r in data['results'])
  batch=json.loads(helmsman_path.read_text());assert any(r['control']=='original-capacity' and r['expected_failures']==[{'full':True}] for r in batch['runs']);assert sha(FILES/'Scripts'/source.name)==sha(source);assert not any(r['passcode']==215730767 for r in rows)
  rows.append({'passcode':215730767,'name':roster[215730767]['name'],'repair':'Recheck MonsterZone space before Hand selfsummon resolution so CL2 filling all zones preserves Hand source and paidSpellTrapcost. Native five interruption cases/four controls including original-capacity; Handcost6/locks6/negation4 regressions. Exact-byte both-copy backup helmsman-before-hand-capacity-repair. Official FAQ19958 no-space Handresource retention applied by inference. No adapters; Zombie revival/ContinuousTrap selfsummon/shareduse/nativeOmega/fullcard OPEN.','script_sha256':sha(source),'batch':helmsman_path.name,'batch_sha256':sha(helmsman_path),'installed_matches':True,'full_card_audit':'OPEN','native_omega_verified':False})
 frute_path=OUT/'current-fruteification-ritual-repaired-batch.json'
 if frute_path.exists():
  source=ROOT/'public/CCG Downloads/CCG_Scripts/c256930605.lua';batch=json.loads(frute_path.read_text());assert batch['baseline_cases']==5
  for dependency,h in batch['runtime_dependencies_sha256'].items():verify_dependency(dependency,h)
  for run in batch['runs']:
   artifact=OUT/run['artifact'];assert sha(artifact)==run['artifact_sha256'];data=json.loads(artifact.read_text());assert [i for i,r in enumerate(data['results']) if r['failure']]==run['expected_failures'];assert not any(r['logs'] for r in data['results']);assert data['legacy_chaininfo_adapter'] is False
  assert any(r['control']=='original-relation' and r['expected_failures']==[0,1,2,3] for r in batch['runs']);assert any(r['control']=='original-material' and r['expected_failures']==[4] for r in batch['runs']);assert sha(FILES/'Scripts'/source.name)==sha(source);assert not any(r['passcode']==256930605 for r in rows)
  rows.append({'passcode':256930605,'name':roster[256930605]['name'],'repair':'Exclude selected Ritual from its material subgroup; remove unestablished target relation check from matching-card-selected Ritual. Native Hand/GY Ritual, Hand/field real materials, higher level and insufficient-other-material exclusion: five cases/four controls including original-line regressions. Both-copy exact-byte backups fruteification-before-relation-material-repair. Optional revival/current focused integration follow-ups separately diagnostic; all-effects/nativeOmega remain OPEN.','script_sha256':sha(source),'batch':frute_path.name,'batch_sha256':sha(frute_path),'installed_matches':True,'full_card_audit':'OPEN','native_omega_verified':False})
 heat_path=OUT/'current-talismandrake-heat-hand-capacity-repaired-batch.json'
 if heat_path.exists():
  source=ROOT/'public/CCG Downloads/CCG_Scripts/c210506870.lua'
  for name,cases in [('current-talismandrake-heat-hand-capacity-repaired-batch.json',7),('current-talismandrake-heat-hand-summon-batch.json',8)]:
   batch=json.loads((OUT/name).read_text());assert batch['baseline_cases']==cases
   for dependency,h in batch['runtime_dependencies_sha256'].items():verify_dependency(dependency,h)
   for run in batch['runs']:
    artifact=OUT/run['artifact'];assert sha(artifact)==run['artifact_sha256'];data=json.loads(artifact.read_text());assert [i for i,r in enumerate(data['results']) if r['failure']]==run['expected_failures'];assert not any(r['logs'] for r in data['results'])
  batch=json.loads(heat_path.read_text());assert any(r['control']=='original-capacity' and r['expected_failures']==[6] for r in batch['runs']);assert sha(FILES/'Scripts'/source.name)==sha(source);assert not any(r['passcode']==210506870 for r in rows)
  rows.append({'passcode':210506870,'name':roster[210506870]['name'],'repair':'Recheck MZONE space before Hand selfsummon resolution; native CL2 four Deck summons fill five zones and source remains Hand. Seven interruption cases/three controls including original-capacity; eight Hand eligibility cases/three controls. Exact-byte both-copy backups heat-before-hand-capacity-repair. Helmsman precedent/FAQ19958 interpretation applied by inference; Pendulum/equip ATK/Fusion/nativeOmega/fullcard OPEN.','script_sha256':sha(source),'batch':heat_path.name,'batch_sha256':sha(heat_path),'installed_matches':True,'full_card_audit':'OPEN','native_omega_verified':False})
 morby_path=OUT/'current-morbydrip-placement-repaired-batch.json'
 if morby_path.exists():
  source=ROOT/'public/CCG Downloads/CCG_Scripts/c210628767.lua';batch=json.loads(morby_path.read_text());assert batch['baseline_cases']==11
  for dependency,h in batch['runtime_dependencies_sha256'].items():verify_dependency(dependency,h)
  for run in batch['runs']:
   artifact=OUT/run['artifact'];assert sha(artifact)==run['artifact_sha256'];data=json.loads(artifact.read_text());assert data['script_sha256']==sha(source);assert [i for i,r in enumerate(data['results']) if r['failure']]==run['expected_failures'];assert not any(r['logs'] for r in data['results']);assert not data['in_memory_occupied_guard']
  assert any(r['control']=='original-guard' and r['expected_failures']==[6,7,8] for r in batch['runs']);assert sha(FILES/'Scripts'/source.name)==sha(source);assert sum(r['passcode']==210628767 for r in rows)==1
  row=next(r for r in rows if r['passcode']==210628767);row.update({'passcode':210628767,'name':roster[210628767]['name'],'repair':row.get('repair','')+' Additional repair: After destruction attempt, retain monster when required owner SZONE column remains occupied. Prevent generic MoveToField arriving in another column. Eleven native actual full-card Hand SS placement cases/four controls; five columns, destructible/indestructible/both or one-sided occupants, actual borrowed target owner mirrored return and absent target. Native ContinuousTrap type observer, no adapters. Exact-byte both-copy backups morbydrip-before-occupied-column-repair. NormalSummon/interruption/ExtraMonster columns/revival/EndPhase/shareduse/nativeOmega/fullcard OPEN.','script_sha256':sha(source),'batch':morby_path.name,'batch_sha256':sha(morby_path),'installed_matches':True,'full_card_audit':'OPEN','native_omega_verified':False})
 morby_capacity_path=OUT/'current-morbydrip-revival-capacity-repaired-batch.json'
 if morby_capacity_path.exists():
  source=ROOT/'public/CCG Downloads/CCG_Scripts/c210628767.lua';batch=json.loads(morby_capacity_path.read_text());assert batch['baseline_cases']==7
  for dependency,h in batch['runtime_dependencies_sha256'].items():verify_dependency(dependency,h)
  for run in batch['runs']:
   artifact=OUT/run['artifact'];assert sha(artifact)==run['artifact_sha256'];data=json.loads(artifact.read_text());assert data['script_sha256']==sha(source);assert [i for i,r in enumerate(data['results']) if r['failure']]==run['expected_failures'];assert not any(r['logs'] for r in data['results']);assert not data['capacity_guard_comparison']
  assert any(r['control']=='original-capacity' and r['expected_failures']==[6] for r in batch['runs']);row=next(r for r in rows if r['passcode']==210628767);row['repair']+=' Additional revival repair: recheck MZONE capacity before native SS so late full zones retain ContinuousTrap rather than consuming it toGY. Seven cases/fourcontrols including original-capacity; seven earlier Morbydrip batches refreshed/preserved. Both-copy byte backups morbydrip-before-revival-capacity-repair.';row['additional_batch']=morby_capacity_path.name;row['additional_batch_sha256']=sha(morby_capacity_path)
 source=ROOT/'public/CCG Downloads/CCG_Scripts/c212429024.lua'
 nebulix_batches=[]
 for scope in ['copies','regression','repeat','attribution','interruption','opponent','capacity','reentry']:
  p=OUT/f'current-gravinity-nebulix-shared-append-{scope}-production-batch.json'
  if not p.exists():break
  batch=json.loads(p.read_text())
  for dependency,h in batch['runtime_dependencies_sha256'].items():verify_dependency(dependency,h)
  for run in batch['runs']:
   artifact=OUT/run['artifact'];assert sha(artifact)==run['artifact_sha256'];data=json.loads(artifact.read_text());assert [i for i,r in enumerate(data['results']) if r['failure']]==run['expected_failures'];assert not any(r['logs'] for r in data['results'])
  nebulix_batches.append({'path':p.name,'sha256':sha(p),'cases':batch['baseline_cases']})
 if len(nebulix_batches)==8:
  assert sum(b['cases'] for b in nebulix_batches)==34
  assert sha(FILES/'Scripts'/source.name)==sha(source)
  rows.append({'passcode':212429024,'name':'Gravinity Nebulix','repair':'Append each copy additional effect to resolving Spell/Trap operation, preserve original once and original reason effect, respect native negation and source lifecycle. Shared per-link list cleared by global CHAIN_END. Exact-byte backup nebulix-before-resolution-append-repair. Eight production groups/34 cases including old-source attribution/negation controls. Native Synchro/recycle/Omega/fullcard OPEN.','script_sha256':sha(source),'batches':nebulix_batches,'installed_matches':True,'full_card_audit':'OPEN','native_omega_verified':False})
 source=ROOT/'public/CCG Downloads/CCG_Scripts/c214552846.lua'
 eldora_path=OUT/'current-eldora-resolution-repaired-batch.json'
 if eldora_path.exists():
  batch=json.loads(eldora_path.read_text());assert batch['baseline_cases']==9
  for dependency,h in batch['runtime_dependencies_sha256'].items():verify_dependency(dependency,h)
  for run in batch['runs']:
   artifact=OUT/run['artifact'];assert sha(artifact)==run['artifact_sha256'];data=json.loads(artifact.read_text());assert [i for i,r in enumerate(data['results']) if r['failure']]==run['expected_failures'];assert not any(r['logs'] for r in data['results'])
  assert any(r['control']=='old-source' and r['expected_failures']==[0,4,5,6,7,8] for r in batch['runs'])
  assert sha(FILES/'Scripts'/source.name)==sha(source)
  rows.append({'passcode':214552846,'name':'Eldora, the Intergalactic Empire','repair':'Replace premature Quick Chain response with optional resolution wrapper. Preserve original operation if declined or current source/threat cannot qualify; skip destruction when original effect negated, source departed or remaining own threat below two. Actual selfdestroy/negation and late indestructibility. Exact-byte backup eldora-before-resolution-timing-repair; nine native cases/four controls including old-source. GY matching destruction/Set/shared use/nativeOmega/fullcard OPEN.','script_sha256':sha(source),'batch':eldora_path.name,'batch_sha256':sha(eldora_path),'installed_matches':True,'full_card_audit':'OPEN','native_omega_verified':False})
 attribution_batches=[]
 for name,cases in [('current-eldora-reason-repaired-batch.json',1),('current-eldora-lifecycle-repaired-batch.json',3)]:
  p=OUT/name;batch=json.loads(p.read_text());assert batch['baseline_cases']==cases
  for dependency,h in batch['runtime_dependencies_sha256'].items():verify_dependency(dependency,h)
  for run in batch['runs']:
   artifact=OUT/run['artifact'];assert sha(artifact)==run['artifact_sha256'];data=json.loads(artifact.read_text());assert [i for i,r in enumerate(data['results']) if r['failure']]==run['expected_failures'];assert not any(r['logs'] for r in data['results'])
  if cases==1:
   assert any(r['control']=='old-wrapper' and r['expected_failures']==[0] for r in batch['runs'])
   assert any(r['control']=='direct-call' and r['expected_failures']==[0] for r in batch['runs'])
  else:
   assert any(r['control']=='no-resolution' and r['expected_failures']==[0,1,2] for r in batch['runs'])
   assert any(r['control']=='no-reentry' and r['expected_failures']==[2] for r in batch['runs'])
  attribution_batches.append({'path':name,'sha256':sha(p),'cases':cases})
 row=next(r for r in rows if r['passcode']==214552846)
 row['repair']+=' Additional attribution correction: dispatch actual source continuous custom event during resolution wrapper so native self-destruction reason effect is Eldora; preserve original callback/reason, native negation suppression and repeated resolution/reentry. Nine refreshed production groups/53 cases. Exact-byte both-copy backup eldora-before-self-destruction-attribution-repair. Native Omega/fullcard remains OPEN.'
 row['additional_batches']=attribution_batches
 actinia_batches=[]
 for name,cases in [('negation',8),('interruption',7),('use-reset',3),('opponent-reset',3),('qualification-repaired',1),('proper-revival',6),('revival-boundaries',4),('revival-use-reset',1)]:
  p=OUT/f'current-actinia-{name}-batch.json';batch=json.loads(p.read_text());assert batch['baseline_cases']==cases
  for dependency,h in batch['runtime_dependencies_sha256'].items():verify_dependency(dependency,h)
  for run in batch['runs']:
   artifact=OUT/run['artifact'];assert sha(artifact)==run['artifact_sha256'];data=json.loads(artifact.read_text());assert [i for i,r in enumerate(data['results']) if r['failure']]==run['expected_failures'];assert not any(r['logs'] for r in data['results'])
  if name=='qualification-repaired':assert any(r['control']=='old-source' and r['expected_failures']==[0] for r in batch['runs'])
  actinia_batches.append({'path':p.name,'sha256':sha(p),'cases':cases})
 source=ROOT/'public/CCG Downloads/CCG_Scripts/c216258796.lua';assert sha(FILES/'Scripts'/source.name)==sha(source);assert sum(b['cases'] for b in actinia_batches)==33
 row=next(r for r in rows if r['passcode']==216258796)
 row['repair']+=' Additional repair: Require STATUS_PROC_COMPLETE in GY special summon procedure. Actual improper Extra-to-GY source no longer revives; old-source control reproduces offer. Proper history fixture uses real two printed-category materials, native non-bypass Fusion Summon then CompleteProcedure and actual destruction; proper revival/partner/capacity/player lock/NecroValley/shared summon use/reset verified. Eight production groups/33 cases including negation/interruption/named effect use regressions. Exact-byte both-copy backup actinia-before-revival-qualification-repair. Official Konami rulebook proper-summon restriction applied by inference. Source Fusion material-selection is separately blocked by public GetMustMaterial gap; fixture does not certify production recipe. NativeOmega/fullcard OPEN.'
 row['batches']=actinia_batches
 psychi_batches=[]
 source=ROOT/'public/CCG Downloads/CCG_Scripts/c217332244.lua'
 assert source.read_bytes()==(FILES/'Scripts'/source.name).read_bytes()
 backup=OUT/'psychi-before-payment-repair'
 assert (backup/source.name).read_bytes()==(backup/('installed-'+source.name)).read_bytes()
 old=(backup/source.name).read_text();assert 'for i=100,lp-1,100 do' in old and 'HINTMSG_NUMBER' in old
 assert 'while place>=1 do' in source.read_text() and 'HINTMSG_NUMBER' not in source.read_text()
 for name,cases in [('current-psychi-summon-procedure-batch.json',7),('current-psychi-token-payment-repaired-batch.json',13),('current-psychi-proper-history-repaired-batch.json',3)]:
  p=OUT/name;batch=json.loads(p.read_text());assert batch['baseline_cases']==cases
  for dependency,h in batch['runtime_dependencies_sha256'].items():verify_dependency(dependency,h)
  for run in batch['runs']:
   artifact=OUT/run['artifact'];assert sha(artifact)==run['artifact_sha256'];data=json.loads(artifact.read_text());assert [i for i,r in enumerate(data['results']) if r['failure']]==run['expected_failures'];assert not any(r['logs'] for r in data['results'])
  psychi_batches.append({'path':name,'sha256':sha(p)})
 assert not any(r['passcode']==217332244 for r in rows)
 assert (OUT/'psychi-before-proper-history-repair/c217332244.lua').read_bytes()==(OUT/'psychi-before-proper-history-repair/installed-c217332244.lua').read_bytes()
 assert 'e0:SetValue(function(e,se,sp,st) return e:GetHandler():IsStatus(STATUS_PROC_COMPLETE) end)' in source.read_text()
 rows.append({'passcode':217332244,'name':'To Proto Psychi','repair':'Replace100-step LP choices with bounded decimal digit choices permitting every positive integer below current LP; use defined HINT_NUMBER in place of undefined HINTMSG_NUMBER. Actual native Token tribute/payment/exact ATK DEF gain;13 payment cases/three controls and7 summon cases/three controls. Exact repository/installed backups psychi-before-payment-repair. Proper-history correction permits actual native revival after printed Hand procedure while improperGY/externalHand excluded;3cases/fourcontrols, exact backup psy chi-before-proper-history-repair (directory psychi-before-proper-history-repair). Other effects/shared use/nativeOmega/fullcard OPEN.','script_sha256':sha(source),'batches':psychi_batches,'installed_matches':True,'full_card_audit':'OPEN','native_omega_verified':False})
 source=ROOT/'public/CCG Downloads/CCG_Scripts/c217632789.lua'
 assert source.read_bytes()==(FILES/'Scripts'/source.name).read_bytes()
 backup=OUT/'pawty-before-hand-cost-guard';assert (backup/source.name).read_bytes()==(backup/('installed-'+source.name)).read_bytes()
 assert 'if not c:IsStatus(STATUS_ACT_FROM_HAND) then return true end' in (backup/source.name).read_text()
 assert 'c:IsLocation(LOCATION_HAND) or c:IsStatus(STATUS_ACT_FROM_HAND)' in source.read_text()
 p=OUT/'current-pawty-cost-boundaries-repaired-batch.json';batch=json.loads(p.read_text());assert batch['baseline_cases']==5
 for dependency,h in batch['runtime_dependencies_sha256'].items():verify_dependency(dependency,h)
 for run in batch['runs']:
  artifact=OUT/run['artifact'];assert sha(artifact)==run['artifact_sha256'];data=json.loads(artifact.read_text());assert [i for i,v in enumerate(data['results']) if v['failure']]==run['expected_failures']
  if run['control']=='old-source':assert run['expected_failures']==[2,3,4] and all(any('Parameter 1' in log['message'] for log in data['results'][i]['logs']) for i in [2,3,4])
  else:assert all(not v['logs'] for v in data['results'])
 assert not any(v['passcode']==217632789 for v in rows)
 rows.append({'passcode':217632789,'name':'Skewy! Pawty Tyme','repair':'Check current Hand location as well as STATUS_ACT_FROM_HAND before allowing cost bypass, so unavailable-cost Hand activation is excluded before payment rather than nil selection error. Five native cases/four controls incl old-source errors; seven earlier groups refreshed. Exact both-copy backup pawty-before-hand-cost-guard. Activation limit/fullcard/nativeOmega OPEN.','script_sha256':sha(source),'batch':p.name,'batch_sha256':sha(p),'installed_matches':True,'full_card_audit':'OPEN','native_omega_verified':False})
 p=OUT/'current-pawty-activation-reset-repaired-batch.json';batch=json.loads(p.read_text());assert batch['baseline_cases']==3
 for dependency,h in batch['runtime_dependencies_sha256'].items():verify_dependency(dependency,h)
 for run in batch['runs']:
  a=OUT/run['artifact'];assert sha(a)==run['artifact_sha256'];d=json.loads(a.read_text());assert [i for i,v in enumerate(d['results']) if v['failure']]==run['expected_failures'];assert all(not v['logs'] for v in d['results'])
 row=next(v for v in rows if v['passcode']==217632789);row['activation_batch']={'path':p.name,'sha256':sha(p)};row['repair']+=' Portable shared activation flag plus EVENT_CHAIN_NEGATED rollback replaces legacy count encoding; three native cases/fourcontrols and8 earlier groups refreshed, exact both-copy backup pawty-before-portable-activation-repair. Uses Bear Trap-tested APIs; actual Omega duel execution still open.'
 source=ROOT/'public/CCG Downloads/CCG_Scripts/c217645912.lua'
 p=OUT/'current-tide-activation-repaired-batch.json';batch=json.loads(p.read_text());assert batch['baseline_cases']==15
 for dependency,h in batch['runtime_dependencies_sha256'].items():verify_dependency(dependency,h)
 assert len(batch['groups'])==4 and sum(g['baseline_cases'] for g in batch['groups'])==15
 for group in batch['groups']:
  assert any(run['control']=='old-source' and run['expected_failures'] for run in group['runs'])
  for run in group['runs']:
   a=OUT/run['artifact'];assert sha(a)==run['artifact_sha256'];d=json.loads(a.read_text());assert len(d['results'])==group['baseline_cases'];assert [i for i,v in enumerate(d['results']) if v['failure']]==run['expected_failures'];assert all(not v['logs'] for v in d['results'])
 assert source.read_bytes()==(FILES/'Scripts'/source.name).read_bytes()
 backup=OUT/'tide-before-optional-activation-repair';assert (backup/source.name).read_bytes()==(backup/('installed-'+source.name)).read_bytes()
 assert not any(v['passcode']==217645912 for v in rows)
 rows.append({'passcode':217645912,'name':'Crewal Tide','repair':'Permit basic Field activation independently of optional Zombie mill. Choose optional effect at target declaration only with eligible resource, no prior nonCrewal summon and unused named playerflag; restriction applies only to chosen effect. Shared chosen-use persists through activation/effect negation and resets next turn; decline preserves use. Actual native summon history/later summon legality/three full copies/negation/reset, four groups15cases12controls including old-source. Exact both-copy backup tide-before-optional-activation-repair. Second trigger/nativeOmega/fullcard OPEN.','script_sha256':sha(source),'batch':p.name,'batch_sha256':sha(p),'installed_matches':True,'full_card_audit':'OPEN','native_omega_verified':False})
 source=ROOT/'public/CCG Downloads/CCG_Scripts/c218142234.lua'
 p=OUT/'current-seraphina-capacity-repaired-batch.json';batch=json.loads(p.read_text());assert batch['baseline_cases']==7
 for dependency,h in batch['runtime_dependencies_sha256'].items():verify_dependency(dependency,h)
 for run in batch['runs']:
  a=OUT/run['artifact'];assert sha(a)==run['artifact_sha256'];d=json.loads(a.read_text());assert len(d['results'])==7;assert [i for i,v in enumerate(d['results']) if v['failure']]==run['expected_failures'];assert all(not v['logs'] for v in d['results'])
 assert any(run['control']=='old-source' and run['expected_failures']==[5,6] for run in batch['runs'])
 assert any(run['control']=='ignore-capacity' and run['expected_failures']==[4,6] for run in batch['runs'])
 assert source.read_bytes()==(FILES/'Scripts'/source.name).read_bytes()
 backup=OUT/'seraphina-before-capacity-repair';assert (backup/source.name).read_bytes()==(backup/('installed-'+source.name)).read_bytes()
 assert 'aux.dncheck(g) and Duel.GetMZoneCount(tp,g)>0' in source.read_text()
 assert not any(v['passcode']==218142234 for v in rows)
 rows.append({'passcode':218142234,'name':'Maiden of Talismandrakes Seraphina','repair':'Allow Pendulum activation when the shuffle cost frees Monster Zones. Combine distinct-name and projected free-zone checks in cost eligibility and subgroup selection, remove premature target current-capacity guard. Actual neutral printed-category native Fusion history/PZone placement and7cases4controls, including mixed GY/field pool forcing MZONE cost and old-source failures. Exact both-copy backup seraphina-before-capacity-repair. Production Fusion recipe/equip/other effects/nativeOmega/fullcard OPEN.','script_sha256':sha(source),'batch':p.name,'batch_sha256':sha(p),'installed_matches':True,'full_card_audit':'OPEN','native_omega_verified':False})
 source=ROOT/'public/CCG Downloads/CCG_Scripts/c238276573.lua'
 p=OUT/'current-goleaf-helper-fallback-batch.json';batch=json.loads(p.read_text());assert batch['baseline_cases']==12 and batch['successful_loader_modes']==2
 for dependency,h in batch['runtime_dependencies_sha256'].items():verify_dependency(dependency,h)
 for run in batch['runs']:
  a=OUT/run['artifact'];assert sha(a)==run['artifact_sha256'];d=json.loads(a.read_text());assert len(d['results'])==12;assert [i for i,v in enumerate(d['results']) if v['failure']]==run['expected_failures']
  if run['old_source']:
   assert run['expected_failures']==[0,1,2,3,4,5,11]
   for i in run['expected_failures']:assert "global 'CCGSylvan'" in d['results'][i]['failure'] and ':59:' in d['results'][i]['failure']
  else:assert all(not v['logs'] for v in d['results'])
 assert source.read_bytes()==(FILES/'Scripts'/source.name).read_bytes()
 backup=OUT/'goleaf-before-helper-fallback';assert (backup/source.name).read_bytes()==(backup/('installed-'+source.name)).read_bytes()
 assert (ROOT/'public/CCG Downloads/CCG_Scripts/ccg_sylvan.lua').read_text().strip() in source.read_text()
 assert not any(v['passcode']==238276573 for v in rows)
 rows.append({'passcode':238276573,'name':'Sylvan Goleaf','repair':'Provide exact shared Sylvan helper inline when non-card file loading leaves CCGSylvan or its functions unavailable. Reproduces user Omega screenshot exact line59 nilglobal against old source with absent helper; twelve native cases pass both normal/missing-helper modes. Exact both-copy backup goleaf-before-helper-fallback.','script_sha256':sha(source),'batch':p.name,'batch_sha256':sha(p),'installed_matches':True,'full_card_audit':'OPEN','native_omega_verified':False})
 p=OUT/'current-sylvan-family-helper-fallback-batch.json';batch=json.loads(p.read_text())
 for dependency,h in batch['runtime_dependencies_sha256'].items():verify_dependency(dependency,h)
 for run in batch['runs']:
  a=OUT/run['artifact'];assert sha(a)==run['sha256'];d=json.loads(a.read_text());assert len(d['results'])==19 and sum(v['pass'] for v in d['results'])==run['passed']
 roster={v['passcode']:v['name'] for v in json.loads((OUT/'baseline-remote.json').read_text(encoding='utf-8'))['cards']}
 for filename in json.loads((OUT/'sylvan-family-helper-repair-files.json').read_text())['changed']:
  code=int(filename[1:-4]);source=ROOT/'public/CCG Downloads/CCG_Scripts'/filename
  assert source.read_bytes()==(FILES/'Scripts'/filename).read_bytes()
  assert (OUT/'sylvan-family-before-helper-fallback'/filename).exists()
  assert 'if not (CCGSylvan and CCGSylvan.Excavate' in source.read_text(encoding='utf-8')
  if code not in roster:continue
  assert not any(v['passcode']==code for v in rows)
  rows.append({'passcode':code,'name':roster[code],'repair':'Same missing Sylvan helper root cause as Goleaf: exact shared inline fallback, existing helper preserved. Native isolated full-script loading passes normal/missing-helper; original backup fails required-function assertion. Initial registration explicitly bypassed in this loader-only fixture; effect resolution/full-card/native Omega OPEN. Eleven additional official overrides repaired separately outside711 roster.','script_sha256':sha(source),'batch':p.name,'batch_sha256':sha(p),'installed_matches':True,'full_card_audit':'OPEN','native_omega_verified':False})
 p=OUT/'current-ritual-material-release-batch.json';batch=json.loads(p.read_text());assert batch['leotron_cases']==15 and batch['family_callback_cases']==28
 for dependency,h in batch['runtime_dependencies_sha256'].items():verify_dependency(dependency,h)
 for run in batch['runs']:
  a=OUT/run['artifact'];assert sha(a)==run['artifact_sha256'];d=json.loads(a.read_text());assert all(not v['logs'] for v in d['results'])
  actual=[i for i,v in enumerate(d['results']) if v['failure']] if run['family'] else [v['scenario'] for v in d['results'] if v['failure']]
  assert actual==run['expected_failures']
 for code in batch['cards']:
  source=ROOT/'public/CCG Downloads/CCG_Scripts'/f'c{code}.lua';backup=OUT/'ritual-material-before-release-guard'
  assert source.read_bytes()==(FILES/'Scripts'/source.name).read_bytes()
  assert 'c:IsCanBeRitualMaterial(rc) and c:IsReleasableByEffect()' in source.read_text(encoding='utf-8')
  assert (backup/source.name).read_bytes()==(backup/('installed-'+source.name)).read_bytes()
  assert not any(v['passcode']==code for v in rows)
  rows.append({'passcode':code,'name':roster[code],'repair':'Reject non-Tributable Hand/field Ritual materials using native contextual IsReleasableByEffect. Shared7filters verified by28bounded native callbacks and original14protected failures; Leotron15actual primary Pendulum Ritual cases with original4capacity/protection failures and3controls6/4/2. Exact both-copy backup and installed parity. Other effects/Deck-send/Mage group/fullcard/native Omega OPEN.','script_sha256':sha(source),'batch':p.name,'batch_sha256':sha(p),'installed_matches':True,'full_card_audit':'OPEN','native_omega_verified':False})
 p=OUT/'current-ritual-material-context-batch.json';batch=json.loads(p.read_text());assert batch['family_callback_cases']==23
 for dependency,h in batch['runtime_dependencies_sha256'].items():verify_dependency(dependency,h)
 for run in batch['runs']:
  a=OUT/run['artifact'];assert sha(a)==run['artifact_sha256'];d=json.loads(a.read_text());assert len(d['results'])==23 and all(not v['logs'] for v in d['results'])
  assert [i for i,v in enumerate(d['results']) if v['failure']]==run['expected_failures']
 for code in batch['cards']:
  source=ROOT/'public/CCG Downloads/CCG_Scripts'/f'c{code}.lua';backup=OUT/'ritual-context-before-release-guard'
  assert source.read_bytes()==(FILES/'Scripts'/source.name).read_bytes()
  assert (backup/source.name).read_bytes()==(backup/('installed-'+source.name)).read_bytes()
  assert not any(v['passcode']==code for v in rows)
  rows.append({'passcode':code,'name':roster[code],'repair':'Reject protected non-Tributable Hand/field Ritual materials while preserving eligible Deck-send materials; Nephthys self Tribute guarded. Four full native-loaded scripts with23bounded production filter callbacks, original7protected failures and blindDeckguard3failures. Full effects/Mage group Pendulum/nativeOmega/fullcard OPEN.','script_sha256':sha(source),'batch':p.name,'batch_sha256':sha(p),'installed_matches':True,'full_card_audit':'OPEN','native_omega_verified':False})
 p=OUT/'current-glitchling-mage-pendulum-group-batch.json';batch=json.loads(p.read_text());assert batch['baseline_cases']==12
 for dependency,h in batch['runtime_dependencies_sha256'].items():verify_dependency(dependency,h)
 for run in batch['runs']:
  a=OUT/run['artifact'];assert sha(a)==run['artifact_sha256'];d=json.loads(a.read_text());assert len(d['results'])==12 and all(not v['logs'] for v in d['results']);assert [v['scenario'] for v in d['results'] if v['failure']]==run['expected_failures']
 row=next(v for v in rows if v['passcode']==259072906);row['group_pendulum_batch']=p.name;row['group_pendulum_batch_sha256']=sha(p);row['repair']+=' Also reject protected and immune field materials in actual group Pendulum Ritual procedure; pass actual procedure effect to immunity check.12nativecases/original2failures/3controls5each, properstatus/payment/checklist and1/2summons; Extra targets/reset/liveOmega/fullcard OPEN.'
 p=OUT/'current-chain-trigger-delay-batch.json';batch=json.loads(p.read_text());assert batch['family_registration_cases']==10 and batch['starry_compatibility_cases']==9
 for dependency,h in batch['runtime_dependencies_sha256'].items():verify_dependency(dependency,h)
 for run in batch['runs']:
  a=OUT/run['artifact'];assert sha(a)==run['artifact_sha256'];d=json.loads(a.read_text());assert all(not v['logs'] for v in d['results'])
  actual=[i for i,v in enumerate(d['results']) if v['failure']] if run['family'] else [v['scenario'] for v in d['results'] if v['failure']];assert actual==run['expected_failures']
 for item in json.loads((OUT/'chain-trigger-delay-repair-files.json').read_text()):
  code=int(item['file'][1:-4]);source=ROOT/'public/CCG Downloads/CCG_Scripts'/item['file'];backup=OUT/'chain-trigger-before-delay-repair'
  assert source.read_bytes()==(FILES/'Scripts'/source.name).read_bytes();assert (backup/source.name).read_bytes()==(backup/('installed-'+source.name)).read_bytes()
  assert item['variable']+':SetProperty('+item['variable']+':GetProperty()|EFFECT_FLAG_DELAY)' in source.read_text(encoding='utf-8');assert not any(v['passcode']==code for v in rows)
  rows.append({'passcode':code,'name':roster[code],'repair':'Add missing delayed flag to existing EVENT_CHAINING optional trigger; preserves event type/other flags and after-chain timing. Ten bounded native full-source isolated registration accept/decline probes withold10failures; Starry9full effectcompatibility diagnostic cases/old5failures/controls7/1/3/9. Explicit legacy chain attribute constant mapping forStarry; no nativeOmega/fullcard certification. Exactbothbackup/installparity.','script_sha256':sha(source),'batch':p.name,'batch_sha256':sha(p),'installed_matches':True,'full_card_audit':'OPEN','native_omega_verified':False})
 p=OUT/'current-talismandrake-embers-pendulum-revival-batch.json';batch=json.loads(p.read_text());assert batch['baseline_cases']==8
 for dependency,h in batch['runtime_dependencies_sha256'].items():verify_dependency(dependency,h)
 for run in batch['runs']:
  a=OUT/run['artifact'];assert sha(a)==run['artifact_sha256'];d=json.loads(a.read_text());assert len(d['results'])==8 and all(not v['logs'] for v in d['results'])
  assert [i for i,v in enumerate(d['results']) if v['failure']]==run['expected_failures']
 code=256928871;source=ROOT/f'public/CCG Downloads/CCG_Scripts/c{code}.lua';backup=OUT/'embers-before-extra-redirect-repair'
 assert source.read_bytes()==(FILES/'Scripts'/source.name).read_bytes();assert (backup/source.name).read_bytes()==(backup/('installed-'+source.name)).read_bytes()
 assert not any(v['passcode']==code for v in rows)
 rows.append({'passcode':code,'name':roster[code]['name'],'repair':'Pendulum revival leave-field redirect uses supported LOCATION_DECK so Fusion returns to Extra; LOCATION_EXTRA was ignored. Eight actual native cases with original GY/banish failures and four fault controls. Neutral Fusion recipe, other effects and nativeOmega/fullcard OPEN.','script_sha256':sha(source),'batch':p.name,'batch_sha256':sha(p),'installed_matches':True,'full_card_audit':'OPEN','native_omega_verified':False})
 report={'scope':'Documented script repairs with current source/install parity. Public-engine regressions and explicitly bounded callback/shared-effect evidence are distinguished per row. Not full-card or native Omega certification.', 'fixed_cards_minimum':len(rows),'cards':rows}
 (OUT/'repair-ledger.json').write_text(json.dumps(report,indent=2)+'\n',encoding='utf-8');print(json.dumps({'fixed_cards_minimum':len(rows),'status':'CURRENT_EVIDENCE_VERIFIED'}))
if __name__=='__main__':main()

"""Classify the saved textual candidates; no runtime or whole-card inference."""
import hashlib,json,re
from pathlib import Path
ROOT=Path.cwd();OUT=ROOT/'output/fresh-ccg-september';FILES=Path(r'C:\Program Files (x86)\YGO Omega\YGO Omega_Data\Files')
def sha(p):return hashlib.sha256(p.read_bytes()).hexdigest()
recorders={223512283:'ge1',224049334:'ge',235637994:'ge1',236239443:'ge1',247755868:'ge',250917339:'ge',259100752:'ge',259230000:'e3',259482393:'ge'}
triggers={238274862:'e2',238276251:'e2',244162598:'e2',251236672:'e2'}
clones={284639719:('e6','e4'),284639720:('e5','e3')}
roster={c['passcode']:c for c in json.loads((ROOT/'src/data/cards.json').read_text(encoding='utf8'))};rows=[];paths=[Path(__file__).resolve(),ROOT/'src/data/cards.json']
for code in list(recorders)+list(triggers)+list(clones):
 p=ROOT/'public/CCG Downloads/CCG_Scripts'/f'c{code}.lua';s=p.read_text();assert p.read_bytes()==(FILES/'Scripts'/p.name).read_bytes();paths.append(p)
 if code in recorders:
  v=recorders[code];assert f'{v}:SetType(EFFECT_TYPE_FIELD+EFFECT_TYPE_CONTINUOUS)' in s and f'{v}:SetCode(EVENT_DESTROYED)' in s
  status='CONTINUOUS_RECORDER_NOT_OPTIONAL_TRIGGER';finding='The scanned declaration records destruction continuously; missing optional-trigger Damage Step permission is not a defect in this declaration. Recorder semantics/other effects remain separate.'
 elif code in clones:
  v,parent=clones[code];assert f'{v}={parent}:Clone()' in s and f'{parent}:SetType(EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_O)' in s and f'{v}:SetCode(EVENT_DESTROYED)' in s
  status='SINGLE_TRIGGER_CLONE_NOT_FIELD_TRIGGER';finding='Earlier textual scan included a previous unrelated FIELD declaration. Actual destruction clone inherits SINGLE trigger type; no field-trigger flag defect inferred. Printed trigger requires effect destruction, not battle destruction.'
 else:
  v=triggers[code];assert f'{v}:SetType(EFFECT_TYPE_FIELD+EFFECT_TYPE_TRIGGER_O)' in s and f'{v}:SetCode(EVENT_DESTROYED)' in s
  start=s.index(f'local {v}=');end=s.index(f'c:RegisterEffect({v})',start);body=s[start:end];assert ('EFFECT_FLAG_DAMAGE_STEP' in body)==(code in [238276251,251236672,244162598,238274862])
  status='NATIVE_DAMAGE_STEP_BOUNDARY_PENDING';finding={238274862:'Faceup Spell/Trap destruction can occur in Damage Step; establish a legal native event and actual equip outcome before changing this flag. A Trap Monster battle example needs type/ruling confirmation.',238276251:'Archetype destruction includes battle destruction. Reuse native battle harness with active Continuous Spell, valid opposing destruction target and actual outcome.',244162598:'Printed Battle Phase destruction clause includes Damage Step. Clone inherits summon-trigger properties; test actual battle event, targets/destruction and subsequent summons.',251236672:'Printed own-card battle destruction explicitly included. Test natural battle with surviving own monster and actual500ATK/DEF bonus.'}[code]
 if code in [238276251,251236672,244162598,238274862]:
  status='NATIVE_DAMAGE_STEP_REPAIR_VERIFIED';finding='Confirmed missing Damage Step permission repaired in source/local Omega; corresponding native battle batch records actual outcomes/original and omitted-operation controls. Tristegsaurus/Observatory require explicit test-only target-info mappings, unadapted failure kept separate. Other clauses/full-card/live Omega remain open.'
 rows.append({'passcode':code,'name':roster[code]['name'],'source_sha256':sha(p),'printed_text':roster[code]['text'],'status':status,'finding':finding,'production_change':False,'full_card_audit':'OPEN','native_omega_verified':False})
report={'scope':'Source/specification/installed parity review of fifteen saved textual candidates only. Nine continuous recorders and two SINGLE clones are false positives for this specific missing FIELD-trigger flag pattern. Four optional FIELD triggers now have native-confirmed repairs; recorded setup and compatibility limits remain; no production bugs or full-card completion inferred from static absence. No duel reruns.','runtime_dependencies_sha256':{str(p.resolve()):sha(p) for p in paths},'cards':rows,'next_native_priority':[],'confirmed_repair_evidence':{'artifact':'current-field-destroy-damage-step-batch.json','sha256':sha(OUT/'current-field-destroy-damage-step-batch.json'),'tristegsaurus_artifact':'current-tristegsaurus-damage-step-batch.json','tristegsaurus_sha256':sha(OUT/'current-tristegsaurus-damage-step-batch.json'),'observatory_artifact':'current-observatory-damage-step-batch.json','observatory_sha256':sha(OUT/'current-observatory-damage-step-batch.json')}}
(OUT/'current-destroyed-damage-step-review.json').write_text(json.dumps(report,indent=2)+'\n',encoding='utf8')
print('Destruction scan classified: recorders/clones separated; four native-confirmed repairs, scoped limitations retained')

"""Apply the remaining source-supported findings without copying report replacements."""
import hashlib,json
from pathlib import Path
ROOT=Path(__file__).resolve().parents[1]; OUT=ROOT/'output/fresh-ccg-september'
ledger=json.loads((OUT/'gemini-supported-fixes.json').read_text(encoding='utf-8'))
backup=Path(ledger['changes'][0]['backup']).parent
def edit(code,old,new,count,reason):
 p=ROOT/f'public/CCG Downloads/CCG_Scripts/c{code}.lua'; before=p.read_bytes();text=before.decode('utf-8')
 assert text.count(old)==count,(code,text.count(old)); (backup/p.name).write_bytes(before)
 p.write_text(text.replace(old,new),encoding='utf-8',newline='')
 ledger['changes'].append({'passcode':code,'reason':reason,'before_sha256':hashlib.sha256(before).hexdigest(),
                          'after_sha256':hashlib.sha256(p.read_bytes()).hexdigest(),'backup':str(backup/p.name)})
edit(220150285,'local m=Duel.GetFusionMaterial(tp)','local m=Duel.GetFusionMaterial(tp):Filter(s.ffilter1,nil,e)',2,
     'Fusion by this effect excludes monsters immune to it at both activation and resolution; preserve existing Omega Fusion/Chain Material procedures.')
edit(236473882,'and c:IsCanBeSpecialSummoned(e,0,tp,false,false) end',
     'and c:IsCanBeSpecialSummoned(e,0,tp,false,false) and Duel.GetLocationCountFromEx(tp,tp,e:GetHandler(),c)>0 end',1,
     'Link summon eligibility includes available Extra Deck zones accounting for the handler leaving.')
edit(232449539,'and not c:IsPreviousLocation(LOCATION_DECK) and c:IsReason(REASON_EFFECT)',
     'and not c:IsPreviousLocation(LOCATION_DECK)',1,
     'Stain return-to-Deck tracking accepts costs as well as effects, as printed.')
edit(259363148,'c:EnableReviveLimit()',
     'c:EnableReviveLimit()\n\taux.AddFusionProcMix(c,false,true,s.matfilter,s.matfilter)',1,
     'Register two generic Gladiator Beast/Test Fusion materials for material inspection; retain its own required-first contact procedure.')
# Janna was changed separately after its shortage case reproduced the defect.
code=215068354;p=ROOT/f'public/CCG Downloads/CCG_Scripts/c{code}.lua'
installed=Path(r'C:\Program Files (x86)\YGO Omega\YGO Omega_Data\Files\Scripts')/p.name
before=installed.read_bytes();assert b'if #g>=ct1 then' in before and b'if #sg2>=ct2 then' in before
(backup/p.name).write_bytes(before)
ledger['changes'].append({'passcode':code,'reason':'Deferred search/Set resolves for as many available cards as the stored counts permit.',
                         'before_sha256':hashlib.sha256(before).hexdigest(),'after_sha256':hashlib.sha256(p.read_bytes()).hexdigest(),
                         'backup':str(backup/p.name)})
(OUT/'gemini-supported-fixes.json').write_text(json.dumps(ledger,indent=2)+'\n',encoding='utf-8')
print(json.dumps({'changed_cards':len(ledger['changes'])}))

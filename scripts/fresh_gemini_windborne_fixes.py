"""Require actual archetype materials and preserve the number returned for Clement Winds."""
import hashlib,json
from pathlib import Path
ROOT=Path(__file__).resolve().parents[1];OUT=ROOT/'output/fresh-ccg-september'
ledger=json.loads((OUT/'gemini-supported-fixes.json').read_text(encoding='utf-8'));backup=Path(ledger['changes'][0]['backup']).parent
for code in [215006791,237684285]:
 p=ROOT/f'public/CCG Downloads/CCG_Scripts/c{code}.lua'; before=p.read_bytes();s=before.decode('utf-8')
 old='return c:IsSummonType(SUMMON_TYPE_SYNCHRO) and c:GetMaterial():FilterCount'
 assert s.count(old)==1
 s=s.replace(old,'return c:IsSummonType(SUMMON_TYPE_SYNCHRO) and #c:GetMaterial()>0 and c:GetMaterial():FilterCount')
 if code==237684285:
  old='if og:FilterCount(Card.IsLocation,nil,LOCATION_HAND)>0 then\n\t\t\tDuel.Hint(HINT_SELECTMSG,tp,HINTMSG_TODECK)\n\t\t\tlocal sg=Duel.SelectMatchingCard(tp,Card.IsAbleToDeck,tp,LOCATION_HAND,0,1,99,nil)'
  assert s.count(old)==1
  s=s.replace(old,'local returned=og:FilterCount(Card.IsLocation,nil,LOCATION_HAND)\n\t\tlocal available=Duel.GetMatchingGroupCount(Card.IsAbleToDeck,tp,LOCATION_HAND,0,nil)\n\t\tlocal ct=math.min(returned,available)\n\t\tif ct>0 then\n\t\t\tDuel.BreakEffect()\n\t\t\tDuel.Hint(HINT_SELECTMSG,tp,HINTMSG_TODECK)\n\t\t\tlocal sg=Duel.SelectMatchingCard(tp,Card.IsAbleToDeck,tp,LOCATION_HAND,0,ct,ct,nil)')
 (backup/p.name).write_bytes(before);p.write_text(s,encoding='utf-8',newline='')
 ledger['changes'].append({'passcode':code,'reason':'Require nonempty Windborne Synchro materials.'+(' Shuffle as many hand cards as successfully returned targets, with sequential timing.' if code==237684285 else ''),
                          'before_sha256':hashlib.sha256(before).hexdigest(),'after_sha256':hashlib.sha256(p.read_bytes()).hexdigest(),'backup':str(backup/p.name)})
(OUT/'gemini-supported-fixes.json').write_text(json.dumps(ledger,indent=2)+'\n',encoding='utf-8')
print(json.dumps({'changed_cards':len(ledger['changes'])}))

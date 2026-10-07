"""Apply individually reviewed Omega fixes, preserving originals and exact diffs."""
import hashlib, json
from datetime import datetime
from pathlib import Path
ROOT=Path(__file__).resolve().parents[1]
OUT=ROOT/'output/fresh-ccg-september'
backup=OUT/('gemini-review-backup-'+datetime.now().strftime('%Y%m%d-%H%M%S'))
backup.mkdir()
changes=[]
def edit(code, replacements, reason):
    p=ROOT/f'public/CCG Downloads/CCG_Scripts/c{code}.lua'
    before=p.read_bytes(); text=before.decode('utf-8')
    for old,new,count in replacements:
        assert text.count(old)==count,(code,old,text.count(old),count)
        text=text.replace(old,new)
    after=text.encode('utf-8')
    (backup/p.name).write_bytes(before)
    p.write_bytes(after)
    changes.append({'passcode':code,'reason':reason,'before_sha256':hashlib.sha256(before).hexdigest(),
                    'after_sha256':hashlib.sha256(after).hexdigest(),'backup':str(backup/p.name)})
for code in [212184534,215445495,216505735,231400558,259655976]:
    edit(code,[('return c:IsType(TYPE_XYZ)','return c:IsFaceup() and c:IsType(TYPE_XYZ)',1),
               ('if Duel.Destroy(c,REASON_EFFECT)>0 then\n\t\tDuel.Draw','if Duel.Destroy(c,REASON_EFFECT)>0 then\n\t\tDuel.BreakEffect()\n\t\tDuel.Draw',1)] +
         ([('e1:SetType(EFFECT_TYPE_QUICK_O)','e1:SetType(EFFECT_TYPE_IGNITION)',1)] if code==259655976 else []),
         'Ignore face-down Xyz monsters for alternative procedure; separate then-draw timing. Lighting main-phase branch is ignition.')
edit(212052682,[('e5:SetProperty(EFFECT_FLAG_CARD_TARGET)','e5:SetProperty(EFFECT_FLAG_CARD_TARGET+EFFECT_FLAG_DELAY)',1),
               ('if chk==0 then return e:GetHandler():IsCanTurnSet() end end',
                'local c=e:GetHandler()\n\tif chk==0 then return c:IsCanTurnSet() and c:GetFlagEffect(id)==0 end\n\tc:RegisterFlagEffect(id,RESET_EVENT+RESETS_STANDARD-RESET_TURN_SET+RESET_PHASE+PHASE_END,0,1)\nend',1)],
     'Delayed optional flip trigger and Ghostrick self-Set flag retained through face-down state, following Omega Ghostrick Witch.')
edit(210628767,[('e1:SetType(EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_O)',
                'e1:SetCategory(CATEGORY_DESTROY)\n\te1:SetType(EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_O)',1),
               ('local sq=c:GetControler()==p and seq or 4-seq',
                'local col=seq\n\tif c:IsLocation(LOCATION_MZONE) and seq>=5 then col=seq==5 and 1 or 3 end\n\tlocal sq=c:GetControler()==p and col or 4-col',1)],
     'Map EMZ sequences 5/6 to physical columns 1/3 before moving to owner Spell/Trap Zone; declare destruction category.')
edit(215142357,[('and rc:IsControler(tp) and rc:IsLocation(LOCATION_MZONE)\n\t\tand re:GetActivateLocation()==LOCATION_MZONE',
                'and re:GetActivateLocation()==LOCATION_MZONE',1)],
     'Draw checks the monster effect activation location and activating player, so paying a self-tribute cost does not suppress it.')
edit(215105971,[('and rp==1-tp and c:GetPreviousControler()==tp',
                'and c:GetReasonPlayer()==1-tp and c:GetPreviousControler()==tp and c:GetOwner()==tp',1)],
     'Leaves-field condition also requires original owner control; use card reason player.')
edit(219002796,[('e2:SetTargetRange(0,1)',
                'e2:SetProperty(EFFECT_FLAG_PLAYER_TARGET) e2:SetTargetRange(0,1)',1)],
     'Opponent attack prohibition targets the player, rather than LOCATION_DECK.')
edit(259792415,[('function s.bpcon(e,tp,eg,ep,ev,re,r,rp) local bc=e:GetHandler():GetBattleTarget(); return Duel.GetTurnPlayer()==1-tp and bc~=nil and eg:IsContains(bc) end',
                'function s.bpcon(e,tp,eg,ep,ev,re,r,rp) return Duel.GetTurnPlayer()==1-tp and eg:IsExists(function(c) return c:IsControler(tp) and c:GetBattleTarget()~=nil and c:GetBattleTarget():IsStatus(STATUS_BATTLE_DESTROYED) end,1,nil) end',1)],
     'Opponent-turn battle destruction can be caused by any monster you control, not just the handler.')
edit(259391738,[('return c~=e:GetHandler() and c:IsSetCard(SET_AEROCAT)',
                'return c~=e:GetHandler() and (not c:IsLocation(LOCATION_REMOVED) or c:IsFaceup()) and c:IsSetCard(SET_AEROCAT)',1)],
     'Exclude face-down banished cards from archetype recovery.')
edit(259944344,[('function s.thf(c) return (c:IsSetCard',
                'function s.thf(c) return (not c:IsLocation(LOCATION_REMOVED) or c:IsFaceup()) and (c:IsSetCard',1),
               ('end Duel.SendtoHand(sg,nil,REASON_EFFECT) end',
                'end if Duel.SendtoHand(sg,nil,REASON_EFFECT)>0 then Duel.ConfirmCards(1-tp,sg) end end',1)],
     'Exclude face-down banished archetype cards and reveal recovered cards to opponent.')
edit(216258796,[('e2:SetCode(EVENT_CHAINING)',
                'e2:SetCode(EVENT_CHAINING)\n\te2:SetProperty(EFFECT_FLAG_DAMAGE_STEP+EFFECT_FLAG_DAMAGE_CAL)',1)],
     'Activation negation remains available during Damage Step/calculation, matching Omega Baronne.')
(OUT/'gemini-supported-fixes.json').write_text(json.dumps({'scope':'Individually reviewed changes; test results are tracked separately; not full card certification.',
                                                        'changes':changes},indent=2)+'\n',encoding='utf-8')
print(json.dumps({'changed_cards':len(changes),'backup':str(backup)}))

--Symphonic Warrior Speeaker
--Omega references: c12525049 and c43210483; full-turn Extra Deck activity restriction.
local s,id=GetID()
local SET_SYMPHONIC=0x1066
local MSG_ID=132273768
function s.initial_effect(c)
 aux.EnablePendulumAttribute(c)
 local e1=Effect.CreateEffect(c)
 e1:SetDescription(aux.Stringid(MSG_ID,0))
 e1:SetCategory(CATEGORY_DESTROY)
 e1:SetType(EFFECT_TYPE_IGNITION)
 e1:SetRange(LOCATION_PZONE)
 e1:SetCountLimit(1,id)
 e1:SetTarget(s.ptg)
 e1:SetOperation(s.pop)
 c:RegisterEffect(e1)
 local e2=Effect.CreateEffect(c)
 e2:SetDescription(aux.Stringid(MSG_ID,1))
 e2:SetCategory(CATEGORY_SPECIAL_SUMMON)
 e2:SetType(EFFECT_TYPE_IGNITION)
 e2:SetRange(LOCATION_HAND)
 e2:SetProperty(EFFECT_FLAG_CARD_TARGET)
 e2:SetCountLimit(1,id+100)
 e2:SetTarget(s.handtg)
 e2:SetOperation(s.handop)
 c:RegisterEffect(e2)
 local e3=Effect.CreateEffect(c)
 e3:SetDescription(aux.Stringid(MSG_ID,2))
 e3:SetCategory(CATEGORY_SPECIAL_SUMMON)
 e3:SetType(EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_O)
 e3:SetProperty(EFFECT_FLAG_DELAY)
 e3:SetCode(EVENT_SUMMON_SUCCESS)
 e3:SetCountLimit(1,id+200)
 e3:SetCost(s.lockcost)
 e3:SetTarget(s.sptg)
 e3:SetOperation(s.spop)
 c:RegisterEffect(e3)
 local e4=e3:Clone()
 e4:SetCode(EVENT_SPSUMMON_SUCCESS)
 c:RegisterEffect(e4)
 Duel.AddCustomActivityCounter(id,ACTIVITY_SPSUMMON,s.activityfilter)
end
function s.pfilter(c)
 return c:IsSetCard(SET_SYMPHONIC) and c:IsType(TYPE_PENDULUM)
  and not c:IsCode(id) and not c:IsForbidden()
end
function s.ptg(e,tp,eg,ep,ev,re,r,rp,chk)
 if chk==0 then return e:GetHandler():IsDestructable()
  and Duel.IsExistingMatchingCard(s.pfilter,tp,LOCATION_DECK,0,1,nil) end
 Duel.SetOperationInfo(0,CATEGORY_DESTROY,e:GetHandler(),1,tp,LOCATION_PZONE)
end
function s.pop(e,tp)
 local c=e:GetHandler()
 if not c:IsRelateToEffect(e) or Duel.Destroy(c,REASON_EFFECT)==0 then return end
 if not Duel.CheckLocation(tp,LOCATION_PZONE,0) and not Duel.CheckLocation(tp,LOCATION_PZONE,1) then return end
 Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_TOFIELD)
 local tc=Duel.SelectMatchingCard(tp,s.pfilter,tp,LOCATION_DECK,0,1,1,nil):GetFirst()
 if tc then Duel.MoveToField(tc,tp,tp,LOCATION_PZONE,POS_FACEUP,true) end
end
function s.leveltarget(c)
 return c:IsFaceup() and c:IsSetCard(SET_SYMPHONIC) and c:GetLevel()>0
end
function s.handtg(e,tp,eg,ep,ev,re,r,rp,chk,chkc)
 if chkc then return chkc:IsControler(tp) and chkc:IsLocation(LOCATION_MZONE) and s.leveltarget(chkc) end
 if chk==0 then return Duel.GetLocationCount(tp,LOCATION_MZONE)>0
  and e:GetHandler():IsCanBeSpecialSummoned(e,0,tp,false,false)
  and Duel.IsExistingTarget(s.leveltarget,tp,LOCATION_MZONE,0,1,nil) end
 Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_TARGET)
 Duel.SelectTarget(tp,s.leveltarget,tp,LOCATION_MZONE,0,1,1,nil)
 Duel.SetOperationInfo(0,CATEGORY_SPECIAL_SUMMON,e:GetHandler(),1,tp,LOCATION_HAND)
end
function s.handop(e,tp)
 local tc=Duel.GetFirstTarget()
 if not tc or not tc:IsRelateToEffect(e) or not tc:IsFaceup() or tc:IsImmuneToEffect(e) then return end
 local lv=Effect.CreateEffect(e:GetHandler())
 lv:SetType(EFFECT_TYPE_SINGLE)
 lv:SetCode(EFFECT_UPDATE_LEVEL)
 lv:SetValue(1)
 lv:SetReset(RESET_EVENT+RESETS_STANDARD)
 tc:RegisterEffect(lv)
 local c=e:GetHandler()
 if c:IsRelateToEffect(e) and Duel.GetLocationCount(tp,LOCATION_MZONE)>0 then
  Duel.SpecialSummon(c,0,tp,tp,false,false,POS_FACEUP)
 end
end
function s.activityfilter(c)
 return not c:IsSummonLocation(LOCATION_EXTRA) or c:IsPreviousPosition(POS_FACEUP)
  or c:IsType(TYPE_SYNCHRO) and c:IsAttribute(ATTRIBUTE_WIND)
end
function s.locktarget(e,c)
 return c:IsLocation(LOCATION_EXTRA) and c:IsFacedown()
  and not (c:IsType(TYPE_SYNCHRO) and c:IsAttribute(ATTRIBUTE_WIND))
end
function s.lockcost(e,tp,eg,ep,ev,re,r,rp,chk)
 if chk==0 then return Duel.GetCustomActivityCount(id,tp,ACTIVITY_SPSUMMON)==0 end
 local lock=Effect.CreateEffect(e:GetHandler())
 lock:SetType(EFFECT_TYPE_FIELD)
 lock:SetProperty(EFFECT_FLAG_PLAYER_TARGET+EFFECT_FLAG_OATH)
 lock:SetCode(EFFECT_CANNOT_SPECIAL_SUMMON)
 lock:SetTargetRange(1,0)
 lock:SetTarget(s.locktarget)
 lock:SetReset(RESET_PHASE+PHASE_END)
 Duel.RegisterEffect(lock,tp)
end
function s.spfilter(c,e,tp)
 return c:IsSetCard(SET_SYMPHONIC) and (not c:IsLocation(LOCATION_EXTRA) or c:IsFaceup())
  and c:IsCanBeSpecialSummoned(e,0,tp,false,false)
  and (not c:IsLocation(LOCATION_EXTRA) and Duel.GetLocationCount(tp,LOCATION_MZONE)>0
   or c:IsLocation(LOCATION_EXTRA) and Duel.GetLocationCountFromEx(tp,tp,nil,c)>0)
end
function s.sptg(e,tp,eg,ep,ev,re,r,rp,chk)
 if chk==0 then return Duel.IsExistingMatchingCard(s.spfilter,tp,LOCATION_HAND+LOCATION_DECK+LOCATION_EXTRA,0,1,nil,e,tp) end
 Duel.SetOperationInfo(0,CATEGORY_SPECIAL_SUMMON,nil,1,tp,LOCATION_HAND+LOCATION_DECK+LOCATION_EXTRA)
end
function s.spop(e,tp)
 Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_SPSUMMON)
 local tc=Duel.SelectMatchingCard(tp,s.spfilter,tp,LOCATION_HAND+LOCATION_DECK+LOCATION_EXTRA,0,1,1,nil,e,tp):GetFirst()
 if tc then Duel.SpecialSummon(tc,0,tp,tp,false,false,POS_FACEUP) end
end

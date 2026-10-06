--Terrarumian Coin Plant
--Omega references: c248760718 (Pendulum Zone effects), c100245005 (random hand selection),
-- c215006791 (temporary banishment and End Phase return).
local s,id=GetID()
local SET_TERRARUMIAN=0xA122
local MSG_ID=132639718
function s.initial_effect(c)
 aux.EnablePendulumAttribute(c)
 local e1=Effect.CreateEffect(c)
 e1:SetType(EFFECT_TYPE_FIELD)
 e1:SetCode(EFFECT_UPDATE_ATTACK)
 e1:SetRange(LOCATION_PZONE)
 e1:SetTargetRange(0,LOCATION_MZONE)
 e1:SetValue(s.atkval)
 c:RegisterEffect(e1)
 local e2=Effect.CreateEffect(c)
 e2:SetDescription(aux.Stringid(MSG_ID,0))
 e2:SetCategory(CATEGORY_DESTROY+CATEGORY_SPECIAL_SUMMON)
 e2:SetType(EFFECT_TYPE_IGNITION)
 e2:SetRange(LOCATION_PZONE)
 e2:SetCountLimit(1,id)
 e2:SetCondition(s.pcon)
 e2:SetTarget(s.ptg)
 e2:SetOperation(s.pop)
 c:RegisterEffect(e2)
 local e3=Effect.CreateEffect(c)
 e3:SetDescription(aux.Stringid(MSG_ID,1))
 e3:SetCategory(CATEGORY_REMOVE)
 e3:SetType(EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_O)
 e3:SetProperty(EFFECT_FLAG_DELAY)
 e3:SetCode(EVENT_DESTROYED)
 e3:SetCountLimit(1,id+100)
 e3:SetCondition(s.rmcon)
 e3:SetTarget(s.rmtg)
 e3:SetOperation(s.rmop)
 c:RegisterEffect(e3)
 local e4=Effect.CreateEffect(c)
 e4:SetType(EFFECT_TYPE_SINGLE)
 e4:SetCode(EFFECT_DEFENSE_ATTACK)
 e4:SetValue(0)
 c:RegisterEffect(e4)
end
function s.deffilter(c)
 return c:IsFaceup() and c:IsDefensePos() and c:IsSetCard(SET_TERRARUMIAN)
  and c:IsType(TYPE_PENDULUM)
end
function s.atkval(e,c)
 return -300*Duel.GetMatchingGroupCount(s.deffilter,e:GetHandlerPlayer(),LOCATION_MZONE,LOCATION_MZONE,nil)
end
function s.ownmonster(c)
 return c:IsSetCard(SET_TERRARUMIAN)
end
function s.pcon(e,tp)
 return Duel.IsExistingMatchingCard(s.ownmonster,tp,LOCATION_MZONE,0,1,nil)
end
function s.destroyfilter(c,handler)
 return c~=handler and c:IsSetCard(SET_TERRARUMIAN) and c:IsDestructable()
end
function s.deckfilter(c)
 return c:IsSetCard(SET_TERRARUMIAN) and c:IsType(TYPE_MONSTER)
  and c:IsType(TYPE_PENDULUM) and not c:IsCode(id) and not c:IsForbidden()
end
function s.zonefilter(c,handler)
 return c:IsLocation(LOCATION_MZONE) and s.destroyfilter(c,handler)
end
function s.ptg(e,tp,eg,ep,ev,re,r,rp,chk)
 local c=e:GetHandler()
 if chk==0 then return (Duel.GetLocationCount(tp,LOCATION_MZONE)>0
   or Duel.IsExistingMatchingCard(s.zonefilter,tp,LOCATION_MZONE,0,1,c,c))
  and c:IsCanBeSpecialSummoned(e,0,tp,false,false)
  and Duel.IsExistingMatchingCard(s.destroyfilter,tp,LOCATION_ONFIELD,0,1,c,c)
  and (Duel.CheckLocation(tp,LOCATION_PZONE,0) or Duel.CheckLocation(tp,LOCATION_PZONE,1)
   or c:IsLocation(LOCATION_PZONE))
  and Duel.IsExistingMatchingCard(s.deckfilter,tp,LOCATION_DECK,0,1,nil) end
 Duel.SetOperationInfo(0,CATEGORY_DESTROY,nil,1,tp,LOCATION_ONFIELD)
 Duel.SetOperationInfo(0,CATEGORY_SPECIAL_SUMMON,c,1,tp,LOCATION_PZONE)
end
function s.pop(e,tp)
 local c=e:GetHandler()
 if not c:IsRelateToEffect(e)
  or not Duel.IsExistingMatchingCard(s.destroyfilter,tp,LOCATION_ONFIELD,0,1,c,c) then return end
 Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_DESTROY)
 local g=Duel.SelectMatchingCard(tp,s.destroyfilter,tp,LOCATION_ONFIELD,0,1,1,c,c)
 if #g==0 or Duel.Destroy(g,REASON_EFFECT)==0 then return end
 if not c:IsRelateToEffect(e) or Duel.GetLocationCount(tp,LOCATION_MZONE)<=0
  or Duel.SpecialSummon(c,0,tp,tp,false,false,POS_FACEUP)==0 then return end
 if not (Duel.CheckLocation(tp,LOCATION_PZONE,0) or Duel.CheckLocation(tp,LOCATION_PZONE,1)) then return end
 Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_TOFIELD)
 local pg=Duel.SelectMatchingCard(tp,s.deckfilter,tp,LOCATION_DECK,0,1,1,nil)
 local pc=pg:GetFirst()
 if pc then Duel.MoveToField(pc,tp,tp,LOCATION_PZONE,POS_FACEUP,true) end
end
function s.rmcon(e)
 return e:GetHandler():IsReason(REASON_EFFECT)
end
function s.gyfilter(c)
 return c:IsAbleToRemove()
end
function s.handok(tp)
 return Duel.GetMatchingGroupCount(s.deffilter,tp,LOCATION_MZONE,0,nil)>=2
  and Duel.GetFieldGroupCount(tp,0,LOCATION_HAND)>0
end
function s.rmtg(e,tp,eg,ep,ev,re,r,rp,chk)
 if chk==0 then return Duel.IsExistingMatchingCard(s.gyfilter,tp,0,LOCATION_GRAVE,1,nil)
  or s.handok(tp) end
 Duel.SetOperationInfo(0,CATEGORY_REMOVE,nil,1,1-tp,LOCATION_GRAVE+LOCATION_HAND)
end
function s.rmop(e,tp)
 local gyok=Duel.IsExistingMatchingCard(s.gyfilter,tp,0,LOCATION_GRAVE,1,nil)
 local handok=s.handok(tp)
 if not gyok and not handok then return end
 local fromhand=handok and (not gyok or Duel.SelectYesNo(tp,aux.Stringid(MSG_ID,2)))
 if fromhand then
  local hg=Duel.GetFieldGroup(tp,0,LOCATION_HAND)
  local tc=hg:RandomSelect(tp,1):GetFirst()
  if not tc or Duel.Remove(tc,POS_FACEUP,REASON_EFFECT+REASON_TEMPORARY)==0 then return end
  if not tc:IsLocation(LOCATION_REMOVED) then return end
  tc:RegisterFlagEffect(id,RESET_EVENT+RESETS_STANDARD+RESET_PHASE+PHASE_END,0,1)
  local e1=Effect.CreateEffect(e:GetHandler())
  e1:SetType(EFFECT_TYPE_FIELD+EFFECT_TYPE_CONTINUOUS)
  e1:SetCode(EVENT_PHASE+PHASE_END)
  e1:SetReset(RESET_PHASE+PHASE_END)
  e1:SetLabelObject(tc)
  e1:SetCountLimit(1)
  e1:SetOperation(s.retop)
  Duel.RegisterEffect(e1,tp)
 else
  Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_REMOVE)
  local g=Duel.SelectMatchingCard(tp,s.gyfilter,tp,0,LOCATION_GRAVE,1,1,nil)
  if #g>0 then Duel.Remove(g,POS_FACEUP,REASON_EFFECT) end
 end
end
function s.retop(e,tp)
 local tc=e:GetLabelObject()
 if tc and tc:IsLocation(LOCATION_REMOVED) and tc:GetFlagEffect(id)>0 then
  Duel.SendtoHand(tc,1-tp,REASON_EFFECT)
 end
end

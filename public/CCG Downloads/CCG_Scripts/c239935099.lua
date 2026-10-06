--Rage of the Terrifying Dark Swamp
local s,id=GetID()
local SWAMP=239935101
local MSG_ID=133935099
function s.initial_effect(c)
 aux.AddCodeList(c,SWAMP)
 local e1=Effect.CreateEffect(c)
 e1:SetDescription(aux.Stringid(MSG_ID,0))
 e1:SetCategory(CATEGORY_DESTROY)
 e1:SetType(EFFECT_TYPE_ACTIVATE)
 e1:SetCode(EVENT_FREE_CHAIN)
 e1:SetCountLimit(1,id+EFFECT_COUNT_CODE_OATH)
 e1:SetCondition(s.condition)
 e1:SetTarget(s.target)
 e1:SetOperation(s.operation)
 c:RegisterEffect(e1)
 local e2=Effect.CreateEffect(c)
 e2:SetType(EFFECT_TYPE_FIELD+EFFECT_TYPE_CONTINUOUS)
 e2:SetCode(EFFECT_DESTROY_REPLACE)
 e2:SetRange(LOCATION_GRAVE)
 e2:SetTarget(s.reptg)
 e2:SetValue(s.repval)
 e2:SetOperation(s.repop)
 c:RegisterEffect(e2)
 local e3=e2:Clone()
 e3:SetCode(EFFECT_SEND_REPLACE)
 e3:SetTarget(s.remtg)
 e3:SetValue(s.remval)
 c:RegisterEffect(e3)
end
s.listed_names={SWAMP}
function s.condition()
 local phase=Duel.GetCurrentPhase()
 return phase==PHASE_MAIN1 or phase==PHASE_MAIN2 or phase==PHASE_BATTLE
end
function s.filter(c)
 return c:IsType(TYPE_MONSTER) and c:IsAttribute(ATTRIBUTE_WATER)
  and c:IsRace(RACE_REPTILE) and c:IsDestructable()
end
function s.target(e,tp,eg,ep,ev,re,r,rp,chk)
 if chk==0 then return Duel.IsExistingMatchingCard(s.filter,tp,LOCATION_HAND+LOCATION_MZONE+LOCATION_DECK,0,1,nil) end
 Duel.SetOperationInfo(0,CATEGORY_DESTROY,nil,1,tp,LOCATION_HAND+LOCATION_MZONE+LOCATION_DECK)
end
function s.operation(e,tp)
 Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_DESTROY)
 local g=Duel.SelectMatchingCard(tp,s.filter,tp,LOCATION_HAND+LOCATION_MZONE+LOCATION_DECK,0,1,1,nil)
 local tc=g:GetFirst()
 if not tc then return end
 local follow=tc:IsLocation(LOCATION_HAND+LOCATION_ONFIELD)
 if Duel.Destroy(tc,REASON_EFFECT)==0 or not follow then return end
 if Duel.IsExistingMatchingCard(Card.IsDestructable,tp,LOCATION_ONFIELD,LOCATION_ONFIELD,1,nil)
  and Duel.SelectYesNo(tp,aux.Stringid(MSG_ID,1)) then
  Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_DESTROY)
  local dg=Duel.SelectMatchingCard(tp,Card.IsDestructable,tp,LOCATION_ONFIELD,LOCATION_ONFIELD,1,1,nil)
  if #dg>0 then Duel.Destroy(dg,REASON_EFFECT) end
 end
end
function s.repfilter(c,tp)
 return c:IsControler(tp) and c:IsLocation(LOCATION_ONFIELD) and c:IsCode(SWAMP)
  and c:IsReason(REASON_EFFECT) and not c:IsReason(REASON_REPLACE)
end
function s.reptg(e,tp,eg,ep,ev,re,r,rp,chk)
 if chk==0 then return e:GetHandler():IsAbleToRemove() and eg:IsExists(s.repfilter,1,nil,tp) end
 return Duel.SelectEffectYesNo(tp,e:GetHandler(),aux.Stringid(MSG_ID,2))
end
function s.repval(e,c)
 return s.repfilter(c,e:GetHandlerPlayer())
end
function s.remfilter(c,tp)
 return s.repfilter(c,tp) and c:GetDestination()==LOCATION_REMOVED
end
function s.remtg(e,tp,eg,ep,ev,re,r,rp,chk)
 if chk==0 then return e:GetHandler():IsAbleToRemove() and eg:IsExists(s.remfilter,1,nil,tp) end
 return Duel.SelectEffectYesNo(tp,e:GetHandler(),aux.Stringid(MSG_ID,2))
end
function s.remval(e,c)
 return s.remfilter(c,e:GetHandlerPlayer())
end
function s.repop(e)
 Duel.Remove(e:GetHandler(),POS_FACEUP,REASON_EFFECT+REASON_REPLACE)
end

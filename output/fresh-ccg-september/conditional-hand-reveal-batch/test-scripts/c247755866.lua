--Kali Yuga - Sampati
local s,id=GetID()
local SET_KALI_YUGA=0xa121
local MSG_ID=133755866
function s.initial_effect(c)
 aux.AddSynchroProcedure(c,aux.FilterBoolFunction(Card.IsAttribute,ATTRIBUTE_FIRE),aux.FilterBoolFunction(Card.IsSetCard,SET_KALI_YUGA),1,1)
 c:EnableReviveLimit()
 c:SetUniqueOnField(1,0,id)
 local e1=Effect.CreateEffect(c)
 e1:SetDescription(aux.Stringid(MSG_ID,0))
 e1:SetCategory(CATEGORY_NEGATE+CATEGORY_DESTROY)
 e1:SetType(EFFECT_TYPE_QUICK_O)
 e1:SetCode(EVENT_CHAINING)
 e1:SetRange(LOCATION_MZONE)
 e1:SetCountLimit(1)
 e1:SetCondition(s.negcon)
 e1:SetCost(s.negcost)
 e1:SetTarget(s.negtg)
 e1:SetOperation(s.negop)
 c:RegisterEffect(e1)
 local e2=Effect.CreateEffect(c)
 e2:SetDescription(aux.Stringid(MSG_ID,1))
 e2:SetCategory(CATEGORY_SPECIAL_SUMMON)
 e2:SetType(EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_O)
 e2:SetProperty(EFFECT_FLAG_DELAY)
 e2:SetCode(EVENT_TO_GRAVE)
 e2:SetCountLimit(1,id)
 e2:SetCondition(s.revcon)
 e2:SetTarget(s.revtg)
 e2:SetOperation(s.revop)
 c:RegisterEffect(e2)
end
s.listed_series={SET_KALI_YUGA}
function s.negcon(e,tp,eg,ep,ev,re,r,rp)
 return rp~=tp and re:IsActiveType(TYPE_MONSTER) and Duel.IsChainNegatable(ev)
end
function s.negcost(e,tp,eg,ep,ev,re,r,rp,chk)
 if chk==0 then return Duel.CheckLPCost(tp,1000) end
 Duel.PayLPCost(tp,1000)
end
function s.negtg(e,tp,eg,ep,ev,re,r,rp,chk)
 if chk==0 then return Duel.IsExistingMatchingCard(Card.IsDestructable,tp,LOCATION_HAND+LOCATION_ONFIELD,LOCATION_ONFIELD,1,e:GetHandler()) end
 Duel.SetOperationInfo(0,CATEGORY_NEGATE,eg,1,0,0)
end
function s.negop(e,tp,eg,ep,ev)
 if not Duel.NegateActivation(ev) then return end
 Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_DESTROY)
 local g=Duel.SelectMatchingCard(tp,Card.IsDestructable,tp,LOCATION_HAND+LOCATION_ONFIELD,LOCATION_ONFIELD,1,1,e:GetHandler())
 if #g>0 then Duel.Destroy(g,REASON_EFFECT) end
end
function s.revcon(e,tp,eg,ep,ev,re)
 local c=e:GetHandler()
 return c:IsReason(REASON_DESTROY) and c:IsReason(REASON_EFFECT) and re and re:GetHandler():IsSetCard(SET_KALI_YUGA)
end
function s.revtg(e,tp,eg,ep,ev,re,r,rp,chk)
 if chk==0 then return Duel.GetLocationCount(tp,LOCATION_MZONE)>0
  and e:GetHandler():IsCanBeSpecialSummoned(e,0,tp,false,false) end
 Duel.SetOperationInfo(0,CATEGORY_SPECIAL_SUMMON,e:GetHandler(),1,0,0)
end
function s.revop(e,tp)
 local c=e:GetHandler()
 if not c:IsRelateToEffect(e) or Duel.GetLocationCount(tp,LOCATION_MZONE)<=0
  or Duel.SpecialSummon(c,0,tp,tp,false,false,POS_FACEUP)==0 then return end
 local e1=Effect.CreateEffect(c)
 e1:SetType(EFFECT_TYPE_SINGLE)
 e1:SetProperty(EFFECT_FLAG_CANNOT_DISABLE)
 e1:SetCode(EFFECT_LEAVE_FIELD_REDIRECT)
 e1:SetValue(LOCATION_REMOVED)
 e1:SetReset(RESET_EVENT+RESETS_REDIRECT)
 c:RegisterEffect(e1,true)
end

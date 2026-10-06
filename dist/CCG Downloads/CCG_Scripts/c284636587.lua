--Terrarumian Spores
--Omega references: c225358630 (GY Set and leave-field redirect),
-- c39915560 (activation negation and opponent-card destruction).
local s,id=GetID()
local SET_TERRARUMIAN=0xA122
local MSG_ID=132636587
function s.initial_effect(c)
 local e1=Effect.CreateEffect(c)
 e1:SetDescription(aux.Stringid(MSG_ID,0))
 e1:SetCategory(CATEGORY_NEGATE+CATEGORY_DESTROY)
 e1:SetType(EFFECT_TYPE_ACTIVATE)
 e1:SetCode(EVENT_CHAINING)
 e1:SetCountLimit(1,id+EFFECT_COUNT_CODE_OATH)
 e1:SetCondition(s.negcon)
 e1:SetTarget(s.negtg)
 e1:SetOperation(s.negop)
 c:RegisterEffect(e1)
 local e2=Effect.CreateEffect(c)
 e2:SetDescription(aux.Stringid(MSG_ID,1))
 e2:SetCategory(CATEGORY_SSET)
 e2:SetType(EFFECT_TYPE_IGNITION)
 e2:SetRange(LOCATION_GRAVE)
 e2:SetCountLimit(1,id+100)
 e2:SetCost(s.setcost)
 e2:SetTarget(s.settg)
 e2:SetOperation(s.setop)
 c:RegisterEffect(e2)
end
function s.pendulumfilter(c)
 return c:IsFaceup() and c:IsSetCard(SET_TERRARUMIAN) and c:IsType(TYPE_PENDULUM)
end
function s.negcon(e,tp,eg,ep,ev,re,r,rp)
 return Duel.IsChainNegatable(ev)
  and Duel.IsExistingMatchingCard(s.pendulumfilter,tp,LOCATION_MZONE,0,1,nil)
  and (re:IsActiveType(TYPE_MONSTER)
   or re:IsHasType(EFFECT_TYPE_ACTIVATE) and re:IsActiveType(TYPE_SPELL+TYPE_TRAP))
end
function s.negtg(e,tp,eg,ep,ev,re,r,rp,chk)
 if chk==0 then return true end
 Duel.SetOperationInfo(0,CATEGORY_NEGATE,eg,1,0,0)
 if re:GetHandler():IsRelateToEffect(re) then
  Duel.SetOperationInfo(0,CATEGORY_DESTROY,eg,1,0,0)
 end
end
function s.ownfilter(c)
 return c:IsSetCard(SET_TERRARUMIAN) and c:IsDestructable()
end
function s.negop(e,tp,eg,ep,ev,re,r,rp)
 if not Duel.NegateActivation(ev) then return end
 local rc=re:GetHandler()
 if not rc:IsRelateToEffect(re) or Duel.Destroy(rc,REASON_EFFECT)==0 then return end
 if Duel.IsExistingMatchingCard(s.ownfilter,tp,LOCATION_ONFIELD,0,1,nil)
  and Duel.SelectYesNo(tp,aux.Stringid(MSG_ID,2)) then
  Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_DESTROY)
  local g=Duel.SelectMatchingCard(tp,s.ownfilter,tp,LOCATION_ONFIELD,0,1,1,nil)
  if #g>0 then Duel.Destroy(g,REASON_EFFECT) end
 end
end
function s.tributefilter(c)
 return c:IsSetCard(SET_TERRARUMIAN) and c:IsReleasable()
end
function s.setcost(e,tp,eg,ep,ev,re,r,rp,chk)
 if chk==0 then return Duel.IsExistingMatchingCard(s.tributefilter,tp,LOCATION_MZONE,0,1,nil) end
 Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_RELEASE)
 local g=Duel.SelectMatchingCard(tp,s.tributefilter,tp,LOCATION_MZONE,0,1,1,nil)
 Duel.Release(g,REASON_COST)
end
function s.settg(e,tp,eg,ep,ev,re,r,rp,chk)
 if chk==0 then return Duel.GetLocationCount(tp,LOCATION_SZONE)>0
  and e:GetHandler():IsSSetable() end
 Duel.SetOperationInfo(0,CATEGORY_SSET,e:GetHandler(),1,tp,LOCATION_GRAVE)
end
function s.setop(e,tp)
 local c=e:GetHandler()
 if not c:IsRelateToEffect(e) or Duel.GetLocationCount(tp,LOCATION_SZONE)<=0 then return end
 if Duel.SSet(tp,c)==0 then return end
 local redirect=Effect.CreateEffect(c)
 redirect:SetType(EFFECT_TYPE_SINGLE)
 redirect:SetCode(EFFECT_LEAVE_FIELD_REDIRECT)
 redirect:SetProperty(EFFECT_FLAG_CANNOT_DISABLE)
 redirect:SetReset(RESET_EVENT+RESETS_REDIRECT)
 redirect:SetValue(LOCATION_REMOVED)
 c:RegisterEffect(redirect)
end

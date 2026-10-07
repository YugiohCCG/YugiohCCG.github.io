--Skull Undersea Melanocetus
local s,id=GetID()
local MSG_ID=133937489
function s.initial_effect(c)
 c:EnableReviveLimit()
 aux.AddLinkProcedure(c,aux.FilterBoolFunction(Card.IsRace,RACE_FISH),2)
 local e1=Effect.CreateEffect(c)
 e1:SetType(EFFECT_TYPE_SINGLE+EFFECT_TYPE_CONTINUOUS)
 e1:SetCode(EVENT_SPSUMMON_SUCCESS)
 e1:SetOperation(s.materialop)
 c:RegisterEffect(e1)
 local e2=Effect.CreateEffect(c)
 e2:SetDescription(aux.Stringid(MSG_ID,0))
 e2:SetCategory(CATEGORY_DRAW+CATEGORY_REMOVE)
 e2:SetType(EFFECT_TYPE_QUICK_O)
 e2:SetCode(EVENT_FREE_CHAIN)
 e2:SetRange(LOCATION_MZONE)
 e2:SetCountLimit(1,id)
 e2:SetCost(s.drawcost)
 e2:SetTarget(s.drawtg)
 e2:SetOperation(s.drawop)
 c:RegisterEffect(e2)
 local e3=Effect.CreateEffect(c)
 e3:SetDescription(aux.Stringid(MSG_ID,2))
 e3:SetCategory(CATEGORY_SPECIAL_SUMMON+CATEGORY_REMOVE)
 e3:SetType(EFFECT_TYPE_QUICK_O)
 e3:SetCode(EVENT_FREE_CHAIN)
 e3:SetRange(LOCATION_REMOVED)
 e3:SetCountLimit(1,id)
 e3:SetCost(s.revivecost)
 e3:SetTarget(s.revivetg)
 e3:SetOperation(s.reviveop)
 c:RegisterEffect(e3)
end
function s.materialop(e)
 local c=e:GetHandler()
 local e1=Effect.CreateEffect(c)
 e1:SetType(EFFECT_TYPE_SINGLE)
 e1:SetCode(EFFECT_CANNOT_BE_FUSION_MATERIAL)
 e1:SetProperty(EFFECT_FLAG_CANNOT_DISABLE+EFFECT_FLAG_UNCOPYABLE)
 e1:SetValue(1)
 e1:SetReset(RESET_EVENT+RESETS_STANDARD+RESET_PHASE+PHASE_END)
 c:RegisterEffect(e1)
 local e2=e1:Clone()
 e2:SetCode(EFFECT_CANNOT_BE_LINK_MATERIAL)
 c:RegisterEffect(e2)
end
function s.fishcost(c)
 return c:IsType(TYPE_MONSTER) and c:IsRace(RACE_FISH) and c:IsAbleToRemoveAsCost()
end
function s.drawcost(e,tp,eg,ep,ev,re,r,rp,chk)
 if chk==0 then return Duel.IsExistingMatchingCard(s.fishcost,tp,LOCATION_HAND+LOCATION_MZONE+LOCATION_GRAVE,0,1,nil) end
 Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_REMOVE)
 local tc=Duel.SelectMatchingCard(tp,s.fishcost,tp,LOCATION_HAND+LOCATION_MZONE+LOCATION_GRAVE,0,1,1,nil):GetFirst()
 e:SetLabel(tc:IsLocation(LOCATION_MZONE) and 1 or 0)
 Duel.Remove(tc,POS_FACEUP,REASON_COST)
end
function s.drawtg(e,tp,eg,ep,ev,re,r,rp,chk)
 if chk==0 then return Duel.IsPlayerCanDraw(tp,1) end
 Duel.SetOperationInfo(0,CATEGORY_DRAW,nil,0,tp,1)
end
function s.removefilter(c)
 return c:IsAbleToRemove()
end
function s.drawop(e,tp)
 if Duel.Draw(tp,1,REASON_EFFECT)>0 and e:GetLabel()==1
  and Duel.IsExistingMatchingCard(s.removefilter,tp,0,LOCATION_ONFIELD,1,nil)
  and Duel.SelectYesNo(tp,aux.Stringid(MSG_ID,1)) then
  Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_REMOVE)
  local g=Duel.SelectMatchingCard(tp,s.removefilter,tp,0,LOCATION_ONFIELD,1,1,nil)
  if #g>0 then Duel.Remove(g,POS_FACEUP,REASON_EFFECT) end
 end
end
function s.tributefilter(c,tp)
 return c:IsType(TYPE_MONSTER) and c:IsRace(RACE_FISH) and c:IsReleasable()
  and Duel.GetMZoneCount(tp,c)>0
end
function s.revivecost(e,tp,eg,ep,ev,re,r,rp,chk)
 if chk==0 then return Duel.IsExistingMatchingCard(s.tributefilter,tp,LOCATION_HAND+LOCATION_MZONE,0,1,nil,tp) end
 Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_RELEASE)
 local g=Duel.SelectMatchingCard(tp,s.tributefilter,tp,LOCATION_HAND+LOCATION_MZONE,0,1,1,nil,tp)
 Duel.Release(g,REASON_COST)
end
function s.revivetg(e,tp,eg,ep,ev,re,r,rp,chk)
 local c=e:GetHandler()
 if chk==0 then return c:IsFaceup() and c:IsCanBeSpecialSummoned(e,0,tp,false,false)
  and Duel.IsExistingMatchingCard(s.removefilter,tp,0,LOCATION_GRAVE,1,nil) end
 Duel.SetOperationInfo(0,CATEGORY_SPECIAL_SUMMON,c,1,tp,LOCATION_REMOVED)
 Duel.SetOperationInfo(0,CATEGORY_REMOVE,nil,1,1-tp,LOCATION_GRAVE)
end
function s.reviveop(e,tp)
 local c=e:GetHandler()
 if c:IsRelateToEffect(e) and Duel.GetLocationCount(tp,LOCATION_MZONE)>0
  and Duel.SpecialSummon(c,0,tp,tp,false,false,POS_FACEUP)>0 then
  Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_REMOVE)
  local g=Duel.SelectMatchingCard(tp,s.removefilter,tp,0,LOCATION_GRAVE,1,1,nil)
  if #g>0 then Duel.Remove(g,POS_FACEUP,REASON_EFFECT) end
 end
end

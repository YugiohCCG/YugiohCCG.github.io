--Sylvan Intervention
Duel.LoadScript("ccg_sylvan.lua")
local s,id=GetID()
function s.initial_effect(c)
 local e1=Effect.CreateEffect(c)
 e1:SetCategory(CATEGORY_TODECK+CATEGORY_SPECIAL_SUMMON)
 e1:SetType(EFFECT_TYPE_ACTIVATE)
 e1:SetCode(EVENT_FREE_CHAIN)
 e1:SetProperty(EFFECT_FLAG_CARD_TARGET)
 e1:SetCountLimit(1,id)
 e1:SetCost(s.cost)
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
end
s.listed_series={0x90}
function s.cost(e,tp,eg,ep,ev,re,r,rp,chk)
 if chk==0 then return e:GetHandler():IsAbleToGraveAsCost() end
 Duel.SendtoGrave(e:GetHandler(),REASON_COST)
end
function s.filter(c,e,tp)
 return c:IsSetCard(0x90) and c:IsType(TYPE_MONSTER)
  and (c:IsAbleToDeck() or c:IsCanBeSpecialSummoned(e,0,tp,false,false))
end
function s.choice(c,g,e,tp)
 return c:IsCanBeSpecialSummoned(e,0,tp,false,false)
  and g:FilterCount(Card.IsAbleToDeck,c)>=2
end
function s.groupcheck(g,e,tp)
 return g:IsExists(s.choice,1,nil,g,e,tp)
end
function s.target(e,tp,eg,ep,ev,re,r,rp,chk,chkc)
 if chkc then return chkc:IsControler(tp) and chkc:IsLocation(LOCATION_GRAVE) and s.filter(chkc,e,tp) end
 local g=Duel.GetMatchingGroup(aux.NecroValleyFilter(s.filter),tp,LOCATION_GRAVE,0,nil,e,tp)
 if chk==0 then return Duel.GetLocationCount(tp,LOCATION_MZONE)>0
  and g:CheckSubGroup(s.groupcheck,3,3,e,tp) end
 Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_TARGET)
 local tg=g:SelectSubGroup(tp,s.groupcheck,false,3,3,e,tp)
 Duel.SetTargetCard(tg)
 Duel.SetOperationInfo(0,CATEGORY_TODECK,tg,2,tp,LOCATION_GRAVE)
 Duel.SetOperationInfo(0,CATEGORY_SPECIAL_SUMMON,tg,1,tp,LOCATION_GRAVE)
end
function s.operation(e,tp)
 local g=Duel.GetChainInfo(0,CHAININFO_TARGET_CARDS):Filter(aux.NecroValleyFilter(Card.IsRelateToEffect),nil,e)
 if #g<2 then return end
 --Two surviving targets can be returned even when the third has left the GY.
 if #g==2 then
  if g:FilterCount(Card.IsAbleToDeck,nil)==2
   and Duel.SendtoDeck(g,nil,SEQ_DECKTOP,REASON_EFFECT)==2 then
   Duel.SortDecktop(tp,tp,2)
  end
  return
 end
 --The Deck return still resolves when a chained effect prevents the later Summon.
 local choices=g:Filter(function(c) return g:FilterCount(Card.IsAbleToDeck,c)>=2 end,nil)
 if #choices==0 then return end
 Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_SPSUMMON)
 local sc=choices:Select(tp,1,1,nil):GetFirst()
 g:RemoveCard(sc)
 if Duel.SendtoDeck(g,nil,SEQ_DECKTOP,REASON_EFFECT)~=2 then return end
 Duel.SortDecktop(tp,tp,2)
 Duel.BreakEffect()
 if sc:IsRelateToEffect(e) and Duel.GetLocationCount(tp,LOCATION_MZONE)>0
  and sc:IsCanBeSpecialSummoned(e,0,tp,false,false) then
  Duel.SpecialSummon(sc,0,tp,tp,false,false,POS_FACEUP)
 end
end
function s.repfilter(c,tp)
 return c:IsControler(tp) and c:IsLocation(LOCATION_MZONE) and c:IsRace(RACE_PLANT)
  and c:IsReason(REASON_EFFECT) and not c:IsReason(REASON_REPLACE)
end
function s.reptg(e,tp,eg,ep,ev,re,r,rp,chk)
 local c=e:GetHandler()
 if chk==0 then return c:IsAbleToRemove() and eg:IsExists(s.repfilter,1,nil,tp) end
 return Duel.SelectEffectYesNo(tp,c,96)
end
function s.repval(e,c)
 return s.repfilter(c,e:GetHandlerPlayer())
end
function s.repop(e,tp)
 Duel.Remove(e:GetHandler(),POS_FACEUP,REASON_EFFECT+REASON_REPLACE)
end

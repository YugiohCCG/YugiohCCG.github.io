--Vylon's Aid
--Omega references: c10971759 (target and negate 2 GY summons), c5929801 (summon restriction).
local s,id=GetID()
local MSG_ID=132274861
local SET_VYLON=0x30
function s.initial_effect(c)
 local e1=Effect.CreateEffect(c)
 e1:SetDescription(aux.Stringid(MSG_ID,0))
 e1:SetCategory(CATEGORY_SPECIAL_SUMMON+CATEGORY_DISABLE)
 e1:SetType(EFFECT_TYPE_ACTIVATE)
 e1:SetCode(EVENT_FREE_CHAIN)
 e1:SetProperty(EFFECT_FLAG_CARD_TARGET)
 e1:SetCountLimit(1,id+EFFECT_COUNT_CODE_OATH)
 e1:SetTarget(s.sptg)
 e1:SetOperation(s.spop)
 c:RegisterEffect(e1)
 local e2=Effect.CreateEffect(c)
 e2:SetDescription(aux.Stringid(MSG_ID,1))
 e2:SetCategory(CATEGORY_TOHAND+CATEGORY_SEARCH)
 e2:SetType(EFFECT_TYPE_IGNITION)
 e2:SetRange(LOCATION_GRAVE)
 e2:SetCountLimit(1,id+100)
 e2:SetCost(s.thcost)
 e2:SetTarget(s.thtg)
 e2:SetOperation(s.thop)
 c:RegisterEffect(e2)
end
function s.spfilter(c,e,tp)
 return c:IsAttribute(ATTRIBUTE_LIGHT) and c:IsType(TYPE_MONSTER)
  and c:IsCanBeSpecialSummoned(e,0,tp,false,false)
end
function s.sptg(e,tp,eg,ep,ev,re,r,rp,chk,chkc)
 if chkc then return chkc:IsLocation(LOCATION_GRAVE) and chkc:IsControler(tp) and s.spfilter(chkc,e,tp) end
 if chk==0 then return Duel.GetLocationCount(tp,LOCATION_MZONE)>1
  and not Duel.IsPlayerAffectedByEffect(tp,59822133)
  and Duel.IsExistingTarget(aux.NecroValleyFilter(s.spfilter),tp,LOCATION_GRAVE,0,2,nil,e,tp) end
 Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_SPSUMMON)
 local g=Duel.SelectTarget(tp,aux.NecroValleyFilter(s.spfilter),tp,LOCATION_GRAVE,0,2,2,nil,e,tp)
 Duel.SetOperationInfo(0,CATEGORY_SPECIAL_SUMMON,g,2,0,0)
end
function s.splimit(e,c)
 return not c:IsAttribute(ATTRIBUTE_LIGHT)
end
function s.spop(e,tp)
 local g=Duel.GetChainInfo(0,CHAININFO_TARGET_CARDS):Filter(Card.IsRelateToEffect,nil,e)
  :Filter(aux.NecroValleyFilter(s.spfilter),nil,e,tp)
 if Duel.GetLocationCount(tp,LOCATION_MZONE)<#g or (#g>1 and Duel.IsPlayerAffectedByEffect(tp,59822133)) then return end
 local count=0
 for tc in aux.Next(g) do
  if Duel.SpecialSummonStep(tc,0,tp,tp,false,false,POS_FACEUP) then
   count=count+1
   local neg=Effect.CreateEffect(e:GetHandler())
   neg:SetType(EFFECT_TYPE_SINGLE)
   neg:SetCode(EFFECT_DISABLE)
   neg:SetReset(RESET_EVENT+RESETS_STANDARD)
   tc:RegisterEffect(neg,true)
   local neg2=neg:Clone()
   neg2:SetCode(EFFECT_DISABLE_EFFECT)
   neg2:SetValue(RESET_TURN_SET)
   tc:RegisterEffect(neg2,true)
  end
 end
 if count==0 then return end
 Duel.SpecialSummonComplete()
 local lock=Effect.CreateEffect(e:GetHandler())
 lock:SetType(EFFECT_TYPE_FIELD)
 lock:SetCode(EFFECT_CANNOT_SPECIAL_SUMMON)
 lock:SetProperty(EFFECT_FLAG_PLAYER_TARGET)
 lock:SetTargetRange(1,0)
 lock:SetTarget(s.splimit)
 lock:SetReset(RESET_PHASE+PHASE_END)
 Duel.RegisterEffect(lock,tp)
end
function s.costfilter(c)
 return c:IsSetCard(SET_VYLON) and c:IsType(TYPE_SYNCHRO) and c:IsAbleToRemoveAsCost()
end
function s.thcost(e,tp,eg,ep,ev,re,r,rp,chk)
 local c=e:GetHandler()
 if chk==0 then return c:IsAbleToRemoveAsCost()
  and Duel.IsExistingMatchingCard(s.costfilter,tp,LOCATION_GRAVE,0,1,c) end
 Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_REMOVE)
 local g=Duel.SelectMatchingCard(tp,s.costfilter,tp,LOCATION_GRAVE,0,1,1,c)
 g:AddCard(c)
 Duel.Remove(g,POS_FACEUP,REASON_COST)
end
function s.thfilter(c)
 return c:IsType(TYPE_EQUIP) and c:IsType(TYPE_SPELL) and c:IsAbleToHand()
end
function s.thtg(e,tp,eg,ep,ev,re,r,rp,chk)
 if chk==0 then return Duel.IsExistingMatchingCard(s.thfilter,tp,LOCATION_DECK,0,1,nil) end
 Duel.SetOperationInfo(0,CATEGORY_TOHAND,nil,1,tp,LOCATION_DECK)
end
function s.thop(e,tp)
 Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_ATOHAND)
 local g=Duel.SelectMatchingCard(tp,s.thfilter,tp,LOCATION_DECK,0,1,1,nil)
 if #g>0 then Duel.SendtoHand(g,nil,REASON_EFFECT) Duel.ConfirmCards(1-tp,g) end
end

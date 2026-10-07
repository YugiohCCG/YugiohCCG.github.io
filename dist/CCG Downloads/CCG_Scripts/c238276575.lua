--Sylvan Greetings
Duel.LoadScript("ccg_sylvan.lua")
local s,id=GetID()
local MSG_ID=132276575
function s.initial_effect(c)
 local e1=Effect.CreateEffect(c)
 e1:SetDescription(aux.Stringid(MSG_ID,0))
 e1:SetCategory(CATEGORY_DECKDES+CATEGORY_TOHAND)
 e1:SetType(EFFECT_TYPE_ACTIVATE)
 e1:SetCode(EVENT_FREE_CHAIN)
 e1:SetCountLimit(1,id)
 e1:SetTarget(s.target)
 e1:SetOperation(s.operation)
 c:RegisterEffect(e1)
 local e2=Effect.CreateEffect(c)
 e2:SetDescription(aux.Stringid(MSG_ID,2))
 e2:SetCategory(CATEGORY_SPECIAL_SUMMON)
 e2:SetType(EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_O)
 e2:SetCode(EVENT_TO_GRAVE)
 e2:SetProperty(EFFECT_FLAG_DELAY)
 e2:SetCondition(s.spcon)
 e2:SetTarget(s.sptg)
 e2:SetOperation(s.spop)
 c:RegisterEffect(e2)
end
s.listed_series={0x90}
function s.target(e,tp,eg,ep,ev,re,r,rp,chk)
 if chk==0 then return Duel.IsPlayerCanDiscardDeck(tp,5) end
 Duel.SetOperationInfo(0,CATEGORY_TOHAND,nil,2,tp,LOCATION_DECK)
end
function s.operation(e,tp)
 if Duel.IsPlayerCanDiscardDeck(tp,5) then CCGSylvan.Excavate(e,tp,5,2) end
 local lock=Effect.CreateEffect(e:GetHandler())
 lock:SetType(EFFECT_TYPE_FIELD)
 lock:SetCode(EFFECT_CANNOT_SPECIAL_SUMMON)
 lock:SetProperty(EFFECT_FLAG_PLAYER_TARGET)
 lock:SetTargetRange(1,0)
 lock:SetTarget(function(e,c) return not c:IsRace(RACE_PLANT) end)
 lock:SetReset(RESET_PHASE+PHASE_END)
 Duel.RegisterEffect(lock,tp)
end
function s.spcon(e,tp,eg,ep,ev,re)
 return e:GetHandler():IsReason(REASON_EFFECT) and re and re:GetHandler():IsSetCard(0x90)
end
function s.spfilter(c,e,tp)
 return c:IsSetCard(0x90) and c:IsType(TYPE_MONSTER) and c:IsCanBeSpecialSummoned(e,0,tp,false,false)
end
function s.sptg(e,tp,eg,ep,ev,re,r,rp,chk)
 if chk==0 then return Duel.GetLocationCount(tp,LOCATION_MZONE)>0
  and Duel.IsExistingMatchingCard(aux.NecroValleyFilter(s.spfilter),tp,LOCATION_HAND+LOCATION_GRAVE,0,1,nil,e,tp) end
 Duel.SetOperationInfo(0,CATEGORY_SPECIAL_SUMMON,nil,1,tp,LOCATION_HAND+LOCATION_GRAVE)
end
function s.spop(e,tp)
 if Duel.GetLocationCount(tp,LOCATION_MZONE)<=0 then return end
 Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_SPSUMMON)
 local g=Duel.SelectMatchingCard(tp,aux.NecroValleyFilter(s.spfilter),tp,LOCATION_HAND+LOCATION_GRAVE,0,1,1,nil,e,tp)
 if #g>0 then Duel.SpecialSummon(g,0,tp,tp,false,false,POS_FACEUP) end
end

--Killamity Crimson
local s,id=GetID()
local SET_KILLAMITY=0xa120
local MSG_ID=132163201
function s.initial_effect(c)
 local e1=Effect.CreateEffect(c)
 e1:SetDescription(aux.Stringid(MSG_ID,0))
 e1:SetCategory(CATEGORY_SPECIAL_SUMMON)
 e1:SetType(EFFECT_TYPE_IGNITION)
 e1:SetRange(LOCATION_HAND)
 e1:SetCountLimit(1,id)
 e1:SetCondition(s.spcon)
 e1:SetCost(s.spcost)
 e1:SetTarget(s.sptg)
 e1:SetOperation(s.spop)
 c:RegisterEffect(e1)
 local e2=Effect.CreateEffect(c)
 e2:SetDescription(aux.Stringid(MSG_ID,1))
 e2:SetCategory(CATEGORY_TOHAND+CATEGORY_SEARCH)
 e2:SetType(EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_O)
 e2:SetProperty(EFFECT_FLAG_DELAY)
 e2:SetCode(EVENT_SPSUMMON_SUCCESS)
 e2:SetCountLimit(1,id+100)
 e2:SetTarget(s.addtg)
 e2:SetOperation(s.addop)
 c:RegisterEffect(e2)
 local e3=Effect.CreateEffect(c)
 e3:SetType(EFFECT_TYPE_XMATERIAL)
 e3:SetCode(EFFECT_PIERCE)
 e3:SetCondition(function(e) return e:GetHandler():IsType(TYPE_XYZ) and e:GetHandler():GetRank()==12 end)
 c:RegisterEffect(e3)
end
s.listed_series={SET_KILLAMITY}
function s.twelve(c)
 return c:IsFaceup() and ((c:IsType(TYPE_XYZ) and c:GetRank()==12) or (not c:IsType(TYPE_XYZ) and c:GetLevel()==12))
end
function s.spcon(e,tp)
 return Duel.GetFieldGroupCount(tp,LOCATION_MZONE,0)==0 or Duel.IsExistingMatchingCard(s.twelve,tp,LOCATION_MZONE,0,1,nil)
end
function s.revealfilter(c)
 return c:IsType(TYPE_XYZ) and c:GetRank()==12
end
function s.spcost(e,tp,eg,ep,ev,re,r,rp,chk)
 if chk==0 then return Duel.IsExistingMatchingCard(s.revealfilter,tp,LOCATION_EXTRA,0,1,nil) end
 Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_CONFIRM)
 local g=Duel.SelectMatchingCard(tp,s.revealfilter,tp,LOCATION_EXTRA,0,1,1,nil)
 Duel.ConfirmCards(1-tp,g)
end
function s.sptg(e,tp,eg,ep,ev,re,r,rp,chk)
 if chk==0 then return Duel.GetLocationCount(tp,LOCATION_MZONE)>0 and e:GetHandler():IsCanBeSpecialSummoned(e,0,tp,false,false) end
 Duel.SetOperationInfo(0,CATEGORY_SPECIAL_SUMMON,e:GetHandler(),1,tp,LOCATION_HAND)

end
function s.spop(e,tp)
 local lock=Effect.CreateEffect(e:GetHandler())
 lock:SetType(EFFECT_TYPE_FIELD)
 lock:SetProperty(EFFECT_FLAG_PLAYER_TARGET)
 lock:SetCode(EFFECT_CANNOT_SPECIAL_SUMMON)
 lock:SetTargetRange(1,0)
 lock:SetTarget(function(e,c) return c:IsLocation(LOCATION_EXTRA) and not (c:IsType(TYPE_XYZ) and c:GetRank()==12) end)
 lock:SetReset(RESET_PHASE+PHASE_END)
 Duel.RegisterEffect(lock,tp)
 local c=e:GetHandler()
 if c:IsRelateToEffect(e) and Duel.GetLocationCount(tp,LOCATION_MZONE)>0 then Duel.SpecialSummon(c,0,tp,tp,false,false,POS_FACEUP) end
end
function s.addfilter(c)
 return c:IsType(TYPE_MONSTER) and c:IsSetCard(SET_KILLAMITY) and not c:IsCode(id) and c:IsAbleToHand()
end
function s.addtg(e,tp,eg,ep,ev,re,r,rp,chk)
 if chk==0 then return Duel.IsExistingMatchingCard(s.addfilter,tp,LOCATION_DECK,0,1,nil) end
 Duel.SetOperationInfo(0,CATEGORY_TOHAND,nil,1,tp,LOCATION_DECK)
end
function s.addop(e,tp)
 Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_ATOHAND)
 local g=Duel.SelectMatchingCard(tp,s.addfilter,tp,LOCATION_DECK,0,1,1,nil)
 if #g>0 and Duel.SendtoHand(g,nil,REASON_EFFECT)>0 then Duel.ConfirmCards(1-tp,g) end
end

--Killamity Azure
local s,id=GetID()
local MSG_ID=132163202
function s.initial_effect(c)
 local e1=Effect.CreateEffect(c)
 e1:SetDescription(aux.Stringid(MSG_ID,0))
 e1:SetCategory(CATEGORY_SPECIAL_SUMMON)
 e1:SetType(EFFECT_TYPE_IGNITION)
 e1:SetRange(LOCATION_GRAVE)
 e1:SetCountLimit(1,id)
 e1:SetCost(s.cost)
 e1:SetTarget(s.target)
 e1:SetOperation(s.operation)
 c:RegisterEffect(e1)
 local e2=Effect.CreateEffect(c)
 e2:SetDescription(aux.Stringid(MSG_ID,1))
 e2:SetCategory(CATEGORY_TOHAND)
 e2:SetType(EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_O)
 e2:SetProperty(EFFECT_FLAG_DELAY)
 e2:SetCode(EVENT_SPSUMMON_SUCCESS)
 e2:SetCountLimit(1,id+100)
 e2:SetTarget(s.bouncetg)
 e2:SetOperation(s.bounceop)
 c:RegisterEffect(e2)
 local e3=Effect.CreateEffect(c)
 e3:SetDescription(aux.Stringid(MSG_ID,2))
 e3:SetType(EFFECT_TYPE_XMATERIAL+EFFECT_TYPE_FIELD+EFFECT_TYPE_CONTINUOUS)
 e3:SetCode(EFFECT_DESTROY_REPLACE)
 e3:SetCountLimit(2)
 e3:SetCondition(function(e) return e:GetHandler():IsType(TYPE_XYZ) and e:GetHandler():GetRank()==12 end)
 e3:SetTarget(s.reptg)
 e3:SetValue(s.repval)
 e3:SetOperation(s.repop)
 c:RegisterEffect(e3)
end
s.listed_series={0xa120}
function s.cost(e,tp,eg,ep,ev,re,r,rp,chk)
 if chk==0 then return Duel.IsExistingMatchingCard(Card.IsDiscardable,tp,LOCATION_HAND,0,1,nil) end
 Duel.DiscardHand(tp,Card.IsDiscardable,1,1,REASON_COST+REASON_DISCARD)
end
function s.target(e,tp,eg,ep,ev,re,r,rp,chk)
 if chk==0 then return Duel.GetLocationCount(tp,LOCATION_MZONE)>0 and e:GetHandler():IsCanBeSpecialSummoned(e,0,tp,false,false) end
 Duel.SetOperationInfo(0,CATEGORY_SPECIAL_SUMMON,e:GetHandler(),1,tp,LOCATION_GRAVE)
end
function s.operation(e,tp)
 local c=e:GetHandler()
 if c:IsRelateToEffect(e) and Duel.GetLocationCount(tp,LOCATION_MZONE)>0 then Duel.SpecialSummon(c,0,tp,tp,false,false,POS_FACEUP) end
end
function s.bouncefilter(c)
 return c:IsType(TYPE_MONSTER) and c:IsAbleToHand()
end
function s.bouncetg(e,tp,eg,ep,ev,re,r,rp,chk)
 if chk==0 then return Duel.IsExistingMatchingCard(s.bouncefilter,tp,0,LOCATION_MZONE,1,nil) end
 Duel.SetOperationInfo(0,CATEGORY_TOHAND,nil,1,1-tp,LOCATION_MZONE)
end
function s.bounceop(e,tp)
 Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_RTOHAND)
 local g=Duel.SelectMatchingCard(tp,s.bouncefilter,tp,0,LOCATION_MZONE,1,1,nil)
 if #g>0 then Duel.SendtoHand(g,nil,REASON_EFFECT) end
end
function s.repfilter(c,tp)
 return c:IsFaceup() and c:IsControler(tp) and c:IsLocation(LOCATION_MZONE)
  and ((c:IsType(TYPE_XYZ) and c:GetRank()==12) or (not c:IsType(TYPE_XYZ) and c:GetLevel()==12))
  and c:IsReason(REASON_BATTLE+REASON_EFFECT) and not c:IsReason(REASON_REPLACE)
end
function s.reptg(e,tp,eg,ep,ev,re,r,rp,chk)
 if chk==0 then return e:GetHandler():CheckRemoveOverlayCard(tp,1,REASON_EFFECT) and eg:IsExists(s.repfilter,1,nil,tp) end
 return Duel.SelectEffectYesNo(tp,e:GetHandler(),aux.Stringid(MSG_ID,2))
end
function s.repval(e,c)
 return s.repfilter(c,e:GetHandlerPlayer())
end
function s.repop(e,tp)
 e:GetHandler():RemoveOverlayCard(tp,1,1,REASON_EFFECT+REASON_REPLACE)
end

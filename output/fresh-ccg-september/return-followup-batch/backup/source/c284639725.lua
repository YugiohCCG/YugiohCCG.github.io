--Terrarumian Tillandsia
local s,id=GetID()
local SET_TERRARUMIAN=0xa122
local MSG_ID=132639725
function s.initial_effect(c)
 aux.AddLinkProcedure(c,s.matfilter,2,2)
 c:EnableReviveLimit()
 local e1=Effect.CreateEffect(c)
 e1:SetDescription(aux.Stringid(MSG_ID,0))
 e1:SetCategory(CATEGORY_TOHAND+CATEGORY_SEARCH+CATEGORY_DESTROY)
 e1:SetType(EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_O)
 e1:SetCode(EVENT_SPSUMMON_SUCCESS)
 e1:SetProperty(EFFECT_FLAG_DELAY)
 e1:SetCountLimit(1,id)
 e1:SetCondition(s.thcon)
 e1:SetTarget(s.thtg)
 e1:SetOperation(s.thop)
 c:RegisterEffect(e1)
 local e2=Effect.CreateEffect(c)
 e2:SetDescription(aux.Stringid(MSG_ID,2))
 e2:SetCategory(CATEGORY_SPECIAL_SUMMON)
 e2:SetType(EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_O)
 e2:SetCode(EVENT_TO_GRAVE)
 e2:SetProperty(EFFECT_FLAG_DELAY)
 e2:SetCountLimit(1,id+100)
 e2:SetCondition(s.spcon)
 e2:SetTarget(s.sptg)
 e2:SetOperation(s.spop)
 c:RegisterEffect(e2)
end
s.listed_series={SET_TERRARUMIAN}
function s.matfilter(c)
 return c:IsSetCard(SET_TERRARUMIAN) and c:IsType(TYPE_PENDULUM)
end
function s.thcon(e)
 return e:GetHandler():IsSummonType(SUMMON_TYPE_LINK)
end
function s.thfilter(c)
 return c:IsSetCard(SET_TERRARUMIAN) and c:IsAbleToHand()
end
function s.thtg(e,tp,eg,ep,ev,re,r,rp,chk)
 if chk==0 then return Duel.IsExistingMatchingCard(s.thfilter,tp,LOCATION_DECK,0,1,nil) end
 Duel.SetOperationInfo(0,CATEGORY_TOHAND,nil,1,tp,LOCATION_DECK)
end
function s.desfilter(c)
 return not c:IsCode(id) and c:IsDestructable()
end
function s.thop(e,tp)
 Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_ATOHAND)
 local g=Duel.SelectMatchingCard(tp,s.thfilter,tp,LOCATION_DECK,0,1,1,nil)
 if #g==0 or Duel.SendtoHand(g,nil,REASON_EFFECT)==0 then return end
 Duel.ConfirmCards(1-tp,g)
 local choices=Duel.GetMatchingGroup(s.desfilter,tp,LOCATION_ONFIELD,0,nil)
 if #choices>0 and Duel.SelectYesNo(tp,aux.Stringid(MSG_ID,1)) then
  Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_DESTROY)
  Duel.Destroy(choices:Select(tp,1,1,nil),REASON_EFFECT)
 end
end
function s.spcon(e)
 local c=e:GetHandler()
 return c:IsReason(REASON_DESTROY) and c:IsReason(REASON_EFFECT)
end
function s.sptg(e,tp,eg,ep,ev,re,r,rp,chk)
 if chk==0 then return Duel.GetLocationCount(tp,LOCATION_MZONE)>0
  and e:GetHandler():IsCanBeSpecialSummoned(e,0,tp,false,false) end
 Duel.SetOperationInfo(0,CATEGORY_SPECIAL_SUMMON,e:GetHandler(),1,0,0)
end
function s.spop(e,tp)
 local c=e:GetHandler()
 if c:IsRelateToEffect(e) and Duel.GetLocationCount(tp,LOCATION_MZONE)>0 then
  Duel.SpecialSummon(c,0,tp,tp,false,false,POS_FACEUP)
 end
end

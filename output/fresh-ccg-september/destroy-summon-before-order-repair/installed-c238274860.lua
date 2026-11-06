--Vylon Torus
--Omega references: c41431329 (LIGHT Synchro material trigger), c45674286 (Normal/Special trigger).
local s,id=GetID()
local SET_VYLON=0x30
local MSG_ID=132274860
function s.initial_effect(c)
 local e1=Effect.CreateEffect(c)
 e1:SetDescription(aux.Stringid(MSG_ID,0))
 e1:SetCategory(CATEGORY_DESTROY+CATEGORY_SPECIAL_SUMMON)
 e1:SetType(EFFECT_TYPE_IGNITION)
 e1:SetRange(LOCATION_HAND)
 e1:SetCountLimit(1,id)
 e1:SetTarget(s.sptg)
 e1:SetOperation(s.spop)
 c:RegisterEffect(e1)
 local e2=Effect.CreateEffect(c)
 e2:SetDescription(aux.Stringid(MSG_ID,1))
 e2:SetCategory(CATEGORY_TOHAND+CATEGORY_SEARCH)
 e2:SetType(EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_O)
 e2:SetProperty(EFFECT_FLAG_DELAY)
 e2:SetCode(EVENT_SUMMON_SUCCESS)
 e2:SetCountLimit(1,id+100)
 e2:SetTarget(s.thtg)
 e2:SetOperation(s.thop)
 c:RegisterEffect(e2)
 local e3=e2:Clone()
 e3:SetCode(EVENT_SPSUMMON_SUCCESS)
 c:RegisterEffect(e3)
 local e4=Effect.CreateEffect(c)
 e4:SetDescription(aux.Stringid(MSG_ID,2))
 e4:SetCategory(CATEGORY_SPECIAL_SUMMON)
 e4:SetType(EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_O)
 e4:SetProperty(EFFECT_FLAG_DELAY)
 e4:SetCode(EVENT_BE_MATERIAL)
 e4:SetCountLimit(1,id+200)
 e4:SetCondition(s.matcon)
 e4:SetTarget(s.mattg)
 e4:SetOperation(s.matop)
 c:RegisterEffect(e4)
end
function s.desfilter(c)
 return c:IsSetCard(SET_VYLON) and c:IsDestructable()
end
function s.sptg(e,tp,eg,ep,ev,re,r,rp,chk)
 local c=e:GetHandler()
 if chk==0 then return Duel.GetLocationCount(tp,LOCATION_MZONE)>0
  and c:IsCanBeSpecialSummoned(e,0,tp,false,false)
  and Duel.IsExistingMatchingCard(s.desfilter,tp,LOCATION_HAND+LOCATION_ONFIELD,0,1,c) end
 Duel.SetOperationInfo(0,CATEGORY_DESTROY,nil,1,tp,LOCATION_HAND+LOCATION_ONFIELD)
 Duel.SetOperationInfo(0,CATEGORY_SPECIAL_SUMMON,c,1,0,0)
end
function s.spop(e,tp)
 local c=e:GetHandler()
 if not c:IsRelateToEffect(e) or Duel.GetLocationCount(tp,LOCATION_MZONE)<=0 then return end
 Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_DESTROY)
 local g=Duel.SelectMatchingCard(tp,s.desfilter,tp,LOCATION_HAND+LOCATION_ONFIELD,0,1,1,c)
 if #g>0 and Duel.Destroy(g,REASON_EFFECT)>0 and c:IsRelateToEffect(e) then
  Duel.SpecialSummon(c,0,tp,tp,false,false,POS_FACEUP)
 end
end
function s.monfilter(c)
 return c:IsSetCard(SET_VYLON) and c:IsType(TYPE_MONSTER) and c:IsAbleToHand()
end
function s.spellfilter(c)
 return c:IsSetCard(SET_VYLON) and c:IsType(TYPE_SPELL) and c:IsAbleToHand()
end
function s.thtg(e,tp,eg,ep,ev,re,r,rp,chk)
 if chk==0 then return Duel.IsExistingMatchingCard(s.monfilter,tp,LOCATION_DECK,0,1,nil)
  and Duel.IsExistingMatchingCard(s.spellfilter,tp,LOCATION_DECK,0,1,nil) end
 Duel.SetOperationInfo(0,CATEGORY_TOHAND,nil,2,tp,LOCATION_DECK)
end
function s.thop(e,tp)
 local g=Group.CreateGroup()
 if Duel.IsExistingMatchingCard(s.monfilter,tp,LOCATION_DECK,0,1,nil) then
  Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_ATOHAND)
  g:Merge(Duel.SelectMatchingCard(tp,s.monfilter,tp,LOCATION_DECK,0,1,1,nil))
 end
 if Duel.IsExistingMatchingCard(s.spellfilter,tp,LOCATION_DECK,0,1,nil) then
  Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_ATOHAND)
  g:Merge(Duel.SelectMatchingCard(tp,s.spellfilter,tp,LOCATION_DECK,0,1,1,nil))
 end
 if #g>0 and Duel.SendtoHand(g,nil,REASON_EFFECT)>0 then
  Duel.ConfirmCards(1-tp,g)
  if #g==2 then Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_DISCARD); Duel.DiscardHand(tp,aux.TRUE,1,1,REASON_EFFECT+REASON_DISCARD) end
 end
end
function s.matcon(e,tp,eg,ep,ev,re,r,rp)
 local c=e:GetHandler()
 return c:IsLocation(LOCATION_GRAVE) and r==REASON_SYNCHRO
  and c:GetReasonCard() and c:GetReasonCard():IsAttribute(ATTRIBUTE_LIGHT)
end
function s.matfilter(c,e,tp)
 return c:IsSetCard(SET_VYLON) and c:IsType(TYPE_MONSTER)
  and c:IsCanBeSpecialSummoned(e,0,tp,false,false)
end
function s.mattg(e,tp,eg,ep,ev,re,r,rp,chk)
 if chk==0 then return Duel.GetLocationCount(tp,LOCATION_MZONE)>0
  and Duel.IsExistingMatchingCard(aux.NecroValleyFilter(s.matfilter),tp,LOCATION_HAND+LOCATION_GRAVE,0,1,nil,e,tp) end
 Duel.SetOperationInfo(0,CATEGORY_SPECIAL_SUMMON,nil,1,tp,LOCATION_HAND+LOCATION_GRAVE)
end
function s.matop(e,tp)
 if Duel.GetLocationCount(tp,LOCATION_MZONE)<=0 then return end
 Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_SPSUMMON)
 local g=Duel.SelectMatchingCard(tp,aux.NecroValleyFilter(s.matfilter),tp,LOCATION_HAND+LOCATION_GRAVE,0,1,1,nil,e,tp)
 if #g>0 then Duel.SpecialSummon(g:GetFirst(),0,tp,tp,false,false,POS_FACEUP) end
end

--Kali Yuga - Angulimala
local s,id=GetID()
local SET_KALI_YUGA=0xa121
local MSG_ID=133755865
function s.initial_effect(c)
 local e1=Effect.CreateEffect(c)
 e1:SetDescription(aux.Stringid(MSG_ID,0))
 e1:SetCategory(CATEGORY_DESTROY+CATEGORY_SPECIAL_SUMMON)
 e1:SetType(EFFECT_TYPE_IGNITION)
 e1:SetRange(LOCATION_HAND+LOCATION_GRAVE)
 e1:SetCountLimit(1,id)
 e1:SetTarget(s.sstg)
 e1:SetOperation(s.ssop)
 c:RegisterEffect(e1)
 local e2=e1:Clone()
 e2:SetType(EFFECT_TYPE_FIELD+EFFECT_TYPE_TRIGGER_O)
 e2:SetCode(EVENT_PHASE+PHASE_BATTLE_START)
 c:RegisterEffect(e2)
 local e3=Effect.CreateEffect(c)
 e3:SetDescription(aux.Stringid(MSG_ID,1))
 e3:SetCategory(CATEGORY_TOHAND+CATEGORY_SEARCH+CATEGORY_TOGRAVE)
 e3:SetType(EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_O)
 e3:SetProperty(EFFECT_FLAG_DELAY)
 e3:SetCode(EVENT_SUMMON_SUCCESS)
 e3:SetCountLimit(1,id+100)
 e3:SetTarget(s.taketg)
 e3:SetOperation(s.takeop)
 c:RegisterEffect(e3)
 local e4=e3:Clone()
 e4:SetCode(EVENT_SPSUMMON_SUCCESS)
 c:RegisterEffect(e4)
end
s.listed_series={SET_KALI_YUGA}
function s.desfilter(c,tp)
 return c:IsSetCard(SET_KALI_YUGA) and c:IsDestructable()
  and (Duel.GetLocationCount(tp,LOCATION_MZONE)>0 or c:IsLocation(LOCATION_MZONE))
end
function s.sstg(e,tp,eg,ep,ev,re,r,rp,chk)
 local c=e:GetHandler()
 if chk==0 then return c:IsCanBeSpecialSummoned(e,0,tp,false,false)
  and Duel.IsExistingMatchingCard(s.desfilter,tp,LOCATION_HAND+LOCATION_ONFIELD,0,1,c,tp) end
 Duel.SetOperationInfo(0,CATEGORY_DESTROY,nil,1,tp,LOCATION_HAND+LOCATION_ONFIELD)
 Duel.SetOperationInfo(0,CATEGORY_SPECIAL_SUMMON,c,1,0,0)
end
function s.stfilter(c)
 return c:IsType(TYPE_SPELL+TYPE_TRAP) and c:IsDestructable()
end
function s.ssop(e,tp)
 local c=e:GetHandler()
 if not c:IsRelateToEffect(e) then return end
 Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_DESTROY)
 local g=Duel.SelectMatchingCard(tp,s.desfilter,tp,LOCATION_HAND+LOCATION_ONFIELD,0,1,1,c,tp)
 if #g==0 or Duel.Destroy(g,REASON_EFFECT)==0 or Duel.GetLocationCount(tp,LOCATION_MZONE)<=0 then return end
 if Duel.SpecialSummon(c,0,tp,tp,false,false,POS_FACEUP)==0 then return end
 if Duel.IsExistingMatchingCard(s.stfilter,tp,0,LOCATION_ONFIELD,1,nil)
  and Duel.SelectYesNo(tp,aux.Stringid(MSG_ID,2)) then
  Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_DESTROY)
  local dg=Duel.SelectMatchingCard(tp,s.stfilter,tp,0,LOCATION_ONFIELD,1,1,nil)
  if #dg>0 then Duel.Destroy(dg,REASON_EFFECT) end
 end
end
function s.takefilter(c)
 return c:IsSetCard(SET_KALI_YUGA) and (c:IsAbleToHand() or c:IsAbleToGrave())
end
function s.taketg(e,tp,eg,ep,ev,re,r,rp,chk)
 if chk==0 then return Duel.IsExistingMatchingCard(s.takefilter,tp,LOCATION_DECK,0,1,nil) end
end
function s.takeop(e,tp)
 Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_SELECT)
 local g=Duel.SelectMatchingCard(tp,s.takefilter,tp,LOCATION_DECK,0,1,1,nil)
 if #g==0 then return end
 local tc=g:GetFirst()
 local option=0
 if tc:IsAbleToHand() and tc:IsAbleToGrave() then
  option=Duel.SelectOption(tp,aux.Stringid(MSG_ID,3),aux.Stringid(MSG_ID,4))
 elseif tc:IsAbleToGrave() then option=1 end
 if option==0 then
  if Duel.SendtoHand(g,nil,REASON_EFFECT)>0 then Duel.ConfirmCards(1-tp,g) end
 else Duel.SendtoGrave(g,REASON_EFFECT) end
end

--Kali Yuga - Dukkha
local s,id=GetID()
local SET_KALI_YUGA=0xa121
local MSG_ID=133755872
function s.initial_effect(c)
 local e1=Effect.CreateEffect(c)
 e1:SetDescription(aux.Stringid(MSG_ID,0))
 e1:SetCategory(CATEGORY_TOHAND+CATEGORY_SEARCH)
 e1:SetType(EFFECT_TYPE_ACTIVATE)
 e1:SetCode(EVENT_FREE_CHAIN)
 e1:SetCountLimit(1,id)
 e1:SetTarget(s.addtg)
 e1:SetOperation(s.addop)
 c:RegisterEffect(e1)
 local a=Effect.CreateEffect(c)
 a:SetType(EFFECT_TYPE_FIELD)
 a:SetCode(EFFECT_UPDATE_ATTACK)
 a:SetRange(LOCATION_FZONE)
 a:SetTargetRange(LOCATION_MZONE,0)
 a:SetTarget(function(e,c) return c:IsAttribute(ATTRIBUTE_FIRE) end)
 a:SetValue(300)
 c:RegisterEffect(a)
 local d=a:Clone()
 d:SetCode(EFFECT_UPDATE_DEFENSE)
 d:SetValue(100)
 c:RegisterEffect(d)
 local e2=Effect.CreateEffect(c)
 e2:SetDescription(aux.Stringid(MSG_ID,1))
 e2:SetCategory(CATEGORY_SPECIAL_SUMMON+CATEGORY_DESTROY)
 e2:SetType(EFFECT_TYPE_IGNITION)
 e2:SetRange(LOCATION_FZONE)
 e2:SetCountLimit(1,id+100)
 e2:SetTarget(s.sstg)
 e2:SetOperation(s.ssop)
 c:RegisterEffect(e2)
end
s.listed_series={SET_KALI_YUGA}
function s.addfilter(c)
 return c:IsSetCard(SET_KALI_YUGA) and c:IsType(TYPE_MONSTER) and c:IsAbleToHand()
end
function s.addtg(e,tp,eg,ep,ev,re,r,rp,chk)
 if chk==0 then return true end
 if Duel.IsExistingMatchingCard(s.addfilter,tp,LOCATION_DECK,0,1,nil)
  and Duel.SelectYesNo(tp,aux.Stringid(MSG_ID,0)) then
  e:SetLabel(1)
  Duel.SetOperationInfo(0,CATEGORY_TOHAND,nil,1,tp,LOCATION_DECK)
 else e:SetLabel(0) end
end
function s.addop(e,tp)
 if e:GetLabel()==0 or not e:GetHandler():IsRelateToEffect(e) then return end
 Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_ATOHAND)
 local g=Duel.SelectMatchingCard(tp,s.addfilter,tp,LOCATION_DECK,0,1,1,nil)
 if #g>0 and Duel.SendtoHand(g,nil,REASON_EFFECT)>0 then Duel.ConfirmCards(1-tp,g) end
end
function s.ssfilter(c,e,tp)
 return c:IsSetCard(SET_KALI_YUGA) and c:IsType(TYPE_MONSTER) and c:IsCanBeSpecialSummoned(e,0,tp,false,false)
end
function s.sstg(e,tp,eg,ep,ev,re,r,rp,chk)
 if chk==0 then return Duel.GetLocationCount(tp,LOCATION_MZONE)>0
  and Duel.IsExistingMatchingCard(aux.NecroValleyFilter(s.ssfilter),tp,LOCATION_HAND+LOCATION_GRAVE,0,1,nil,e,tp)
  and (Duel.CheckLPCost(tp,2000) or Duel.IsExistingMatchingCard(Card.IsDestructable,tp,LOCATION_HAND+LOCATION_ONFIELD,0,1,nil)) end
 Duel.SetOperationInfo(0,CATEGORY_SPECIAL_SUMMON,nil,1,tp,LOCATION_HAND+LOCATION_GRAVE)
end
function s.ssop(e,tp)
 local c=e:GetHandler()
 if not c:IsRelateToEffect(e) or Duel.GetLocationCount(tp,LOCATION_MZONE)<=0 then return end
 Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_SPSUMMON)
 local g=Duel.SelectMatchingCard(tp,aux.NecroValleyFilter(s.ssfilter),tp,LOCATION_HAND+LOCATION_GRAVE,0,1,1,nil,e,tp)
 if #g==0 or Duel.SpecialSummon(g,0,tp,tp,false,false,POS_FACEUP)==0 then return end
 local destroy=Duel.IsExistingMatchingCard(Card.IsDestructable,tp,LOCATION_HAND+LOCATION_ONFIELD,0,1,nil)
 local pay=Duel.CheckLPCost(tp,2000)
 if not destroy and not pay then return end
 local option=0
 if destroy and pay then option=Duel.SelectOption(tp,aux.Stringid(MSG_ID,2),aux.Stringid(MSG_ID,3))
 elseif pay then option=1 end
 if option==1 then Duel.PayLPCost(tp,2000)
 else
  Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_DESTROY)
  local dg=Duel.SelectMatchingCard(tp,Card.IsDestructable,tp,LOCATION_HAND+LOCATION_ONFIELD,0,1,1,nil)
  if #dg>0 then Duel.Destroy(dg,REASON_EFFECT) end
 end
end

--Kali Yuga - Jarita
local s,id=GetID()
local SET_KALI_YUGA=0xa121
local MSG_ID=133755871
function s.initial_effect(c)
 aux.AddXyzProcedure(c,aux.FilterBoolFunction(Card.IsSetCard,SET_KALI_YUGA),4,2)
 c:EnableReviveLimit()
 c:SetUniqueOnField(1,0,id)
 local e1=Effect.CreateEffect(c)
 e1:SetDescription(aux.Stringid(MSG_ID,0))
 e1:SetType(EFFECT_TYPE_IGNITION)
 e1:SetRange(LOCATION_MZONE)
 e1:SetCountLimit(1,id)
 e1:SetCost(s.placecost)
 e1:SetTarget(s.placetg)
 e1:SetOperation(s.placeop)
 c:RegisterEffect(e1)
 local e2=Effect.CreateEffect(c)
 e2:SetDescription(aux.Stringid(MSG_ID,1))
 e2:SetCategory(CATEGORY_DESTROY+CATEGORY_SPECIAL_SUMMON)
 e2:SetType(EFFECT_TYPE_IGNITION)
 e2:SetRange(LOCATION_GRAVE)
 e2:SetCountLimit(1,id+100)
 e2:SetTarget(s.revtg)
 e2:SetOperation(s.revop)
 c:RegisterEffect(e2)
end
s.listed_series={SET_KALI_YUGA}
function s.placecost(e,tp,eg,ep,ev,re,r,rp,chk)
 if chk==0 then return e:GetHandler():CheckRemoveOverlayCard(tp,1,REASON_COST) end
 e:GetHandler():RemoveOverlayCard(tp,1,1,REASON_COST)
end
function s.placefilter(c)
 return c:IsSetCard(SET_KALI_YUGA) and c:IsType(TYPE_SPELL+TYPE_TRAP)
  and c:IsType(TYPE_CONTINUOUS) and not c:IsForbidden()
end
function s.placetg(e,tp,eg,ep,ev,re,r,rp,chk)
 if chk==0 then return Duel.GetLocationCount(tp,LOCATION_SZONE)>0
  and Duel.IsExistingMatchingCard(s.placefilter,tp,LOCATION_DECK,0,1,nil) end
end
function s.placeop(e,tp)
 if Duel.GetLocationCount(tp,LOCATION_SZONE)<=0 then return end
 Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_TOFIELD)
 local g=Duel.SelectMatchingCard(tp,s.placefilter,tp,LOCATION_DECK,0,1,1,nil)
 if #g>0 then Duel.MoveToField(g:GetFirst(),tp,tp,LOCATION_SZONE,POS_FACEUP,true) end
end
function s.destroyfilter(c,tp)
 return c:IsDestructable() and (c:IsSetCard(SET_KALI_YUGA) or c:IsType(TYPE_SPELL+TYPE_TRAP))
  and (Duel.GetLocationCount(tp,LOCATION_MZONE)>0 or c:IsLocation(LOCATION_MZONE))
end
function s.revtg(e,tp,eg,ep,ev,re,r,rp,chk)
 if chk==0 then return e:GetHandler():IsCanBeSpecialSummoned(e,0,tp,false,false)
  and Duel.IsExistingMatchingCard(s.destroyfilter,tp,LOCATION_ONFIELD,0,1,nil,tp) end
 Duel.SetOperationInfo(0,CATEGORY_DESTROY,nil,1,tp,LOCATION_ONFIELD)
 Duel.SetOperationInfo(0,CATEGORY_SPECIAL_SUMMON,e:GetHandler(),1,tp,LOCATION_GRAVE)
end
function s.revop(e,tp)
 local c=e:GetHandler()
 if not c:IsRelateToEffect(e) then return end
 Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_DESTROY)
 local g=Duel.SelectMatchingCard(tp,s.destroyfilter,tp,LOCATION_ONFIELD,0,1,1,nil,tp)
 if #g==0 or Duel.Destroy(g,REASON_EFFECT)==0 or not c:IsRelateToEffect(e)
  or Duel.GetLocationCount(tp,LOCATION_MZONE)<=0
  or Duel.SpecialSummon(c,0,tp,tp,false,false,POS_FACEUP)==0 then return end
 local redirect=Effect.CreateEffect(c)
 redirect:SetType(EFFECT_TYPE_SINGLE)
 redirect:SetProperty(EFFECT_FLAG_CANNOT_DISABLE)
 redirect:SetCode(EFFECT_LEAVE_FIELD_REDIRECT)
 redirect:SetValue(LOCATION_REMOVED)
 redirect:SetReset(RESET_EVENT+RESETS_REDIRECT)
 c:RegisterEffect(redirect,true)
 if Duel.IsExistingMatchingCard(s.ovfilter,tp,0,LOCATION_ONFIELD,1,nil,e)
  and Duel.SelectYesNo(tp,aux.Stringid(MSG_ID,2)) then
  Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_XMATERIAL)
  local og=Duel.SelectMatchingCard(tp,s.ovfilter,tp,0,LOCATION_ONFIELD,1,1,nil,e)
  if #og>0 then Duel.Overlay(c,og) end
 end
end
function s.ovfilter(c,e)
 return c:IsType(TYPE_SPELL+TYPE_TRAP) and not c:IsImmuneToEffect(e)
end

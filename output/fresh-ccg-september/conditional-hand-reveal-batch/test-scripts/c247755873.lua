--Kali Yuga - Ahimsaka Justijhn
local s,id=GetID()
local SET_KALI_YUGA=0xa121
local MSG_ID=133755873
function s.initial_effect(c)
 if not s.global_check then
  s.global_check=true
  local ge=Effect.CreateEffect(c)
  ge:SetType(EFFECT_TYPE_FIELD+EFFECT_TYPE_CONTINUOUS)
  ge:SetCode(EVENT_SPSUMMON_SUCCESS)
  ge:SetOperation(s.record)
  Duel.RegisterEffect(ge,0)
 end
 aux.AddXyzProcedure(c,aux.FilterBoolFunction(Card.IsAttribute,ATTRIBUTE_FIRE),8,2,s.altfilter,aux.Stringid(MSG_ID,0),nil,s.altop)
 c:EnableReviveLimit()
 c:SetUniqueOnField(1,0,id)
 local e1=Effect.CreateEffect(c)
 e1:SetDescription(aux.Stringid(MSG_ID,1))
 e1:SetCategory(CATEGORY_DRAW+CATEGORY_RECOVER)
 e1:SetType(EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_O)
 e1:SetProperty(EFFECT_FLAG_DELAY)
 e1:SetCode(EVENT_SPSUMMON_SUCCESS)
 e1:SetTarget(s.drawtg)
 e1:SetOperation(s.drawop)
 c:RegisterEffect(e1)
 local e2=Effect.CreateEffect(c)
 e2:SetDescription(aux.Stringid(MSG_ID,2))
 e2:SetCategory(CATEGORY_SPECIAL_SUMMON+CATEGORY_TODECK)
 e2:SetType(EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_O)
 e2:SetProperty(EFFECT_FLAG_DELAY)
 e2:SetCode(EVENT_TO_GRAVE)
 e2:SetCountLimit(1,id)
 e2:SetCondition(s.revcon)
 e2:SetTarget(s.revtg)
 e2:SetOperation(s.revop)
 c:RegisterEffect(e2)
end
s.listed_series={SET_KALI_YUGA}
function s.record(e,tp,eg)
 for c in aux.Next(eg) do
  if c:IsType(TYPE_XYZ) and c:IsAttribute(ATTRIBUTE_FIRE)
   and c:IsPreviousLocation(LOCATION_GRAVE+LOCATION_REMOVED) then
   c:RegisterFlagEffect(id,RESET_EVENT+RESETS_STANDARD+RESET_PHASE+PHASE_END,0,1)
  end
 end
end
function s.altfilter(c,e,tp)
 return c:IsFaceup() and c:IsType(TYPE_XYZ) and c:IsAttribute(ATTRIBUTE_FIRE)
  and c:GetFlagEffect(id)>0
end
function s.altop(e,tp,chk)
 if chk==0 then return Duel.GetFlagEffect(tp,id+100)==0 end
 Duel.RegisterFlagEffect(tp,id+100,RESET_PHASE+PHASE_END,0,1)
end
function s.drawtg(e,tp,eg,ep,ev,re,r,rp,chk)
 if chk==0 then return Duel.IsPlayerCanDraw(tp,1) end
 Duel.SetOperationInfo(0,CATEGORY_DRAW,nil,0,tp,1)
 Duel.SetOperationInfo(0,CATEGORY_RECOVER,nil,0,tp,1000)
end
function s.drawop(e,tp)
 if Duel.Draw(tp,1,REASON_EFFECT)>0 then Duel.Recover(tp,1000,REASON_EFFECT) end
end
function s.revcon(e,tp,eg,ep,ev,re)
 local c=e:GetHandler()
 return c:IsReason(REASON_DESTROY) and c:IsReason(REASON_EFFECT)
  and re and re:GetHandler():IsSetCard(SET_KALI_YUGA)
end
function s.revtg(e,tp,eg,ep,ev,re,r,rp,chk)
 if chk==0 then return Duel.GetLocationCount(tp,LOCATION_MZONE)>0
  and e:GetHandler():IsCanBeSpecialSummoned(e,0,tp,false,false) end
 Duel.SetOperationInfo(0,CATEGORY_SPECIAL_SUMMON,e:GetHandler(),1,tp,LOCATION_GRAVE)
end
function s.shufflefilter(c)
 return c:IsType(TYPE_MONSTER) and c:IsAttribute(ATTRIBUTE_FIRE) and c:GetLevel()>0
  and c:IsAbleToDeck() and (not c:IsLocation(LOCATION_REMOVED) or c:IsFaceup())
end
function s.revop(e,tp)
 local c=e:GetHandler()
 if not c:IsRelateToEffect(e) or Duel.GetLocationCount(tp,LOCATION_MZONE)<=0
  or Duel.SpecialSummon(c,0,tp,tp,false,false,POS_FACEUP)==0 then return end
 local redirect=Effect.CreateEffect(c)
 redirect:SetType(EFFECT_TYPE_SINGLE)
 redirect:SetProperty(EFFECT_FLAG_CANNOT_DISABLE)
 redirect:SetCode(EFFECT_LEAVE_FIELD_REDIRECT)
 redirect:SetValue(LOCATION_REMOVED)
 redirect:SetReset(RESET_EVENT+RESETS_REDIRECT)
 c:RegisterEffect(redirect,true)
 if Duel.IsExistingMatchingCard(aux.NecroValleyFilter(s.shufflefilter),tp,LOCATION_GRAVE+LOCATION_REMOVED,0,1,nil)
  and Duel.SelectYesNo(tp,aux.Stringid(MSG_ID,3)) then
  Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_TODECK)
  local g=Duel.SelectMatchingCard(tp,aux.NecroValleyFilter(s.shufflefilter),tp,LOCATION_GRAVE+LOCATION_REMOVED,0,1,1,nil)
  if #g>0 then Duel.SendtoDeck(g,nil,SEQ_DECKSHUFFLE,REASON_EFFECT) end
 end
end

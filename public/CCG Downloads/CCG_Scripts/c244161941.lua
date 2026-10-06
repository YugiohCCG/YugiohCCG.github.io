--Vanquish Soul Brawl
--Omega references: c54562327 (reveal and End Phase return), c53330789 (VS Attributes and delayed return).
local s,id=GetID()
local SET_VS=0x195
local MSG_ID=132161941
function s.initial_effect(c)
 local e1=Effect.CreateEffect(c)
 e1:SetDescription(aux.Stringid(MSG_ID,0))
 e1:SetCategory(CATEGORY_SPECIAL_SUMMON)
 e1:SetType(EFFECT_TYPE_ACTIVATE)
 e1:SetCode(EVENT_FREE_CHAIN)
 e1:SetCountLimit(1,id+EFFECT_COUNT_CODE_OATH)
 e1:SetCost(s.spcost)
 e1:SetTarget(s.sptg)
 e1:SetOperation(s.spop)
 c:RegisterEffect(e1)
 local e2=Effect.CreateEffect(c)
 e2:SetDescription(aux.Stringid(MSG_ID,1))
 e2:SetCategory(CATEGORY_TODECK)
 e2:SetType(EFFECT_TYPE_FIELD+EFFECT_TYPE_TRIGGER_O)
 e2:SetProperty(EFFECT_FLAG_DELAY)
 e2:SetCode(EVENT_LEAVE_FIELD)
 e2:SetRange(LOCATION_GRAVE)
 e2:SetCountLimit(1,id+100)
 e2:SetCondition(s.tdcon)
 e2:SetTarget(s.tdtg)
 e2:SetOperation(s.tdop)
 c:RegisterEffect(e2)
end
function s.spfilter(c,e,tp,attr)
 return c:IsSetCard(SET_VS) and c:IsType(TYPE_MONSTER)
  and not c:IsAttribute(attr) and c:IsCanBeSpecialSummoned(e,0,tp,false,false)
end
function s.revealfilter(c,e,tp)
 return c:IsType(TYPE_MONSTER) and not c:IsPublic()
  and Duel.IsExistingMatchingCard(aux.NecroValleyFilter(s.spfilter),tp,LOCATION_HAND+LOCATION_GRAVE,0,1,c,e,tp,c:GetAttribute())
end
function s.spcost(e,tp,eg,ep,ev,re,r,rp,chk)
 if chk==0 then return Duel.GetLocationCount(tp,LOCATION_MZONE)>0
  and Duel.IsExistingMatchingCard(s.revealfilter,tp,LOCATION_HAND,0,1,nil,e,tp) end
 Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_CONFIRM)
 local g=Duel.SelectMatchingCard(tp,s.revealfilter,tp,LOCATION_HAND,0,1,1,nil,e,tp)
 local rc=g:GetFirst()
 e:SetLabel(rc:GetAttribute())
 Duel.ConfirmCards(1-tp,g)
 Duel.ShuffleHand(tp)
end
function s.sptg(e,tp,eg,ep,ev,re,r,rp,chk)
 if chk==0 then return true end
 Duel.SetOperationInfo(0,CATEGORY_SPECIAL_SUMMON,nil,1,tp,LOCATION_HAND+LOCATION_GRAVE)
end
function s.spop(e,tp,eg,ep,ev,re,r,rp)
 if Duel.GetLocationCount(tp,LOCATION_MZONE)<=0 then return end
 Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_SPSUMMON)
 local g=Duel.SelectMatchingCard(tp,aux.NecroValleyFilter(s.spfilter),tp,LOCATION_HAND+LOCATION_GRAVE,0,1,1,nil,e,tp,e:GetLabel())
 local sc=g:GetFirst()
 if not sc or Duel.SpecialSummon(sc,0,tp,tp,false,false,POS_FACEUP)==0 then return end
 local fid=sc:GetFieldID()
 sc:RegisterFlagEffect(id,RESET_EVENT+RESETS_STANDARD,0,1,fid)
 local ret=Effect.CreateEffect(e:GetHandler())
 ret:SetType(EFFECT_TYPE_FIELD+EFFECT_TYPE_CONTINUOUS)
 ret:SetCode(EVENT_PHASE+PHASE_END)
 ret:SetCountLimit(1)
 ret:SetProperty(EFFECT_FLAG_IGNORE_IMMUNE)
 ret:SetLabel(fid)
 ret:SetLabelObject(sc)
 ret:SetCondition(s.retcon)
 ret:SetOperation(s.retop)
 Duel.RegisterEffect(ret,tp)
end
function s.retcon(e)
 local sc=e:GetLabelObject()
 if sc:GetFlagEffectLabel(id)~=e:GetLabel() then e:Reset() return false end
 return true
end
function s.retop(e)
 Duel.SendtoHand(e:GetLabelObject(),nil,REASON_EFFECT)
end
function s.leftfilter(c,tp)
 local re=c:GetReasonEffect()
 return c:IsPreviousControler(1-tp) and c:IsPreviousLocation(LOCATION_MZONE)
  and c:IsReason(REASON_EFFECT) and re and re:GetHandlerPlayer()==tp
  and re:GetHandler():IsSetCard(SET_VS)
end
function s.tdcon(e,tp,eg)
 return eg:IsExists(s.leftfilter,1,nil,tp)
end
function s.otherfilter(c)
 return c:IsSetCard(SET_VS) and c:IsAbleToDeck()
end
function s.tdtg(e,tp,eg,ep,ev,re,r,rp,chk)
 local c=e:GetHandler()
 if chk==0 then return c:IsAbleToDeck()
  and Duel.IsExistingMatchingCard(s.otherfilter,tp,LOCATION_GRAVE,0,2,c) end
 Duel.SetOperationInfo(0,CATEGORY_TODECK,nil,3,tp,LOCATION_GRAVE)
end
function s.tdop(e,tp)
 local c=e:GetHandler()
 if not c:IsRelateToEffect(e) or not c:IsAbleToDeck()
  or not Duel.IsExistingMatchingCard(s.otherfilter,tp,LOCATION_GRAVE,0,2,c) then return end
 Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_TODECK)
 local g=Duel.SelectMatchingCard(tp,s.otherfilter,tp,LOCATION_GRAVE,0,2,2,c)
 g:AddCard(c)
 for _=1,3 do
  Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_TODECK)
  local sg=g:Select(tp,1,1,nil)
  local tc=sg:GetFirst()
  g:RemoveCard(tc)
  Duel.SendtoDeck(tc,nil,SEQ_DECKBOTTOM,REASON_EFFECT)
 end
end

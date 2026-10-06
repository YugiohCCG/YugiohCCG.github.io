--Brazier of Nephthys
local s,id=GetID()
local SET_NEPHTHYS=0x11f
local MSG_ID=132276251
function s.initial_effect(c)
 local e1=Effect.CreateEffect(c)
 e1:SetDescription(aux.Stringid(MSG_ID,0))
 e1:SetCategory(CATEGORY_DESTROY+CATEGORY_TOHAND+CATEGORY_SEARCH)
 e1:SetType(EFFECT_TYPE_ACTIVATE)
 e1:SetCode(EVENT_FREE_CHAIN)
 e1:SetCountLimit(1,id+EFFECT_COUNT_CODE_OATH)
 e1:SetTarget(s.acttg)
 e1:SetOperation(s.actop)
 c:RegisterEffect(e1)
 local e2=Effect.CreateEffect(c)
 e2:SetDescription(aux.Stringid(MSG_ID,1))
 e2:SetCategory(CATEGORY_DESTROY)
 e2:SetType(EFFECT_TYPE_FIELD+EFFECT_TYPE_TRIGGER_O)
 e2:SetCode(EVENT_DESTROYED)
 e2:SetRange(LOCATION_SZONE)
 e2:SetProperty(EFFECT_FLAG_DELAY+EFFECT_FLAG_CARD_TARGET)
 e2:SetCountLimit(1)
 e2:SetCondition(s.descon)
 e2:SetTarget(s.destg)
 e2:SetOperation(s.desop)
 c:RegisterEffect(e2)
end
function s.low(c)
 return c:IsSetCard(SET_NEPHTHYS) and c:IsType(TYPE_MONSTER) and c:GetLevel()>0 and c:GetLevel()<=2 and c:IsAbleToHand()
end
function s.high(c)
 return c:IsSetCard(SET_NEPHTHYS) and c:IsType(TYPE_MONSTER) and c:GetLevel()>=8 and c:IsAbleToHand()
end
function s.destroyable(c)
 return c:IsDestructable()
end
function s.futureGY(c)
 return c:IsAbleToGrave() and not c:IsType(TYPE_TOKEN)
  and not (c:IsLocation(LOCATION_ONFIELD) and c:IsType(TYPE_PENDULUM))
end
function s.activationvictim(c,tp)
 return c:IsDestructable()
  and (Duel.IsExistingMatchingCard(s.low,tp,LOCATION_DECK+LOCATION_GRAVE,0,1,nil) or s.futureGY(c) and s.low(c))
  and (Duel.IsExistingMatchingCard(s.high,tp,LOCATION_DECK+LOCATION_GRAVE,0,1,nil) or s.futureGY(c) and s.high(c))
end
function s.acttg(e,tp,eg,ep,ev,re,r,rp,chk)
 if chk==0 then return true end
 e:SetLabel(0)
 if not Duel.IsExistingMatchingCard(s.activationvictim,tp,LOCATION_HAND+LOCATION_ONFIELD,0,1,e:GetHandler(),tp)
  or not Duel.SelectYesNo(tp,aux.Stringid(MSG_ID,0)) then return end
 e:SetLabel(1)
 Duel.SetOperationInfo(0,CATEGORY_DESTROY,nil,1,tp,LOCATION_HAND+LOCATION_ONFIELD)
 Duel.SetOperationInfo(0,CATEGORY_TOHAND,nil,2,tp,LOCATION_DECK+LOCATION_GRAVE)
end
function s.actop(e,tp)
 local c=e:GetHandler()
 if e:GetLabel()==0 or not c:IsRelateToEffect(e) or not c:IsFaceup() then return end
 Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_DESTROY)
 local g=Duel.SelectMatchingCard(tp,s.destroyable,tp,LOCATION_HAND+LOCATION_ONFIELD,0,1,1,c)
 if #g==0 or Duel.Destroy(g,REASON_EFFECT)==0 then return end
 if not Duel.IsExistingMatchingCard(aux.NecroValleyFilter(s.low),tp,LOCATION_DECK+LOCATION_GRAVE,0,1,nil)
  or not Duel.IsExistingMatchingCard(aux.NecroValleyFilter(s.high),tp,LOCATION_DECK+LOCATION_GRAVE,0,1,nil) then return end
 Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_ATOHAND)
 local low=Duel.SelectMatchingCard(tp,aux.NecroValleyFilter(s.low),tp,LOCATION_DECK+LOCATION_GRAVE,0,1,1,nil)
 local high=Duel.SelectMatchingCard(tp,aux.NecroValleyFilter(s.high),tp,LOCATION_DECK+LOCATION_GRAVE,0,1,1,nil)
 low:Merge(high)
 if #low==2 then Duel.SendtoHand(low,nil,REASON_EFFECT) Duel.ConfirmCards(1-tp,low) end
end
function s.descon(e,tp,eg)
 return eg:IsExists(Card.IsSetCard,1,nil,SET_NEPHTHYS)
end
function s.destg(e,tp,eg,ep,ev,re,r,rp,chk,chkc)
 if chkc then return chkc:IsControler(1-tp) and chkc:IsOnField() and chkc:IsDestructable() end
 if chk==0 then return Duel.IsExistingTarget(s.destroyable,tp,0,LOCATION_ONFIELD,1,nil) end
 Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_DESTROY)
 local g=Duel.SelectTarget(tp,s.destroyable,tp,0,LOCATION_ONFIELD,1,1,nil)
 Duel.SetOperationInfo(0,CATEGORY_DESTROY,g,1,1-tp,LOCATION_ONFIELD)
end
function s.desop(e,tp)
 local c=e:GetHandler()
 local tc=Duel.GetFirstTarget()
 if c:IsRelateToEffect(e) and c:IsFaceup() and tc and tc:IsRelateToEffect(e) then Duel.Destroy(tc,REASON_EFFECT) end
end

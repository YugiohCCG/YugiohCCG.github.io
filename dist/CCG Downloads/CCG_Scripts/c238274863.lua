--Vylon Eta
--Omega references: c48370501 (LIGHT Synchro procedure), c75886890 (GY equip), c41431329 (Equip search).
local s,id=GetID()
local MSG_ID=132274863
function s.initial_effect(c)
 aux.AddSynchroProcedure(c,aux.FilterBoolFunction(Card.IsAttribute,ATTRIBUTE_LIGHT),aux.NonTuner(Card.IsAttribute,ATTRIBUTE_LIGHT),1)
 c:EnableReviveLimit()
 local e1=Effect.CreateEffect(c)
 e1:SetDescription(aux.Stringid(MSG_ID,0))
 e1:SetCategory(CATEGORY_TOHAND+CATEGORY_SEARCH)
 e1:SetType(EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_O)
 e1:SetProperty(EFFECT_FLAG_DELAY)
 e1:SetCode(EVENT_SPSUMMON_SUCCESS)
 e1:SetCountLimit(1,id)
 e1:SetCondition(s.thcon)
 e1:SetTarget(s.thtg)
 e1:SetOperation(s.thop)
 c:RegisterEffect(e1)
 local e2=Effect.CreateEffect(c)
 e2:SetDescription(aux.Stringid(MSG_ID,1))
 e2:SetCategory(CATEGORY_EQUIP)
 e2:SetType(EFFECT_TYPE_IGNITION)
 e2:SetProperty(EFFECT_FLAG_CARD_TARGET)
 e2:SetRange(LOCATION_GRAVE)
 e2:SetCountLimit(1,id+100)
 e2:SetTarget(s.eqtg)
 e2:SetOperation(s.eqop)
 c:RegisterEffect(e2)
 local e3=Effect.CreateEffect(c)
 e3:SetDescription(aux.Stringid(MSG_ID,2))
 e3:SetType(EFFECT_TYPE_EQUIP+EFFECT_TYPE_CONTINUOUS)
 e3:SetCode(EFFECT_DESTROY_REPLACE)
 e3:SetCountLimit(1,id+200)
 e3:SetTarget(s.reptg)
 e3:SetOperation(s.repop)
 c:RegisterEffect(e3)
end
function s.thcon(e)
 return e:GetHandler():IsSummonType(SUMMON_TYPE_SYNCHRO)
end
function s.thfilter(c)
 return c:IsSetCard(0x30) and c:IsType(TYPE_SPELL) and c:IsType(TYPE_EQUIP) and c:IsAbleToHand()
end
function s.thtg(e,tp,eg,ep,ev,re,r,rp,chk)
 if chk==0 then return Duel.IsExistingMatchingCard(aux.NecroValleyFilter(s.thfilter),tp,LOCATION_DECK+LOCATION_GRAVE,0,1,nil) end
 Duel.SetOperationInfo(0,CATEGORY_TOHAND,nil,1,tp,LOCATION_DECK+LOCATION_GRAVE)
end
function s.thop(e,tp)
 Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_ATOHAND)
 local g=Duel.SelectMatchingCard(tp,aux.NecroValleyFilter(s.thfilter),tp,LOCATION_DECK+LOCATION_GRAVE,0,1,1,nil)
 if #g>0 then Duel.SendtoHand(g,nil,REASON_EFFECT) Duel.ConfirmCards(1-tp,g) end
end
function s.eqfilter(c)
 return c:IsFaceup() and c:IsSetCard(0x30) and c:IsType(TYPE_SYNCHRO)
end
function s.eqtg(e,tp,eg,ep,ev,re,r,rp,chk,chkc)
 if chkc then return chkc:IsLocation(LOCATION_MZONE) and chkc:IsControler(tp) and s.eqfilter(chkc) end
 if chk==0 then return Duel.GetLocationCount(tp,LOCATION_SZONE)>0
  and Duel.IsExistingTarget(s.eqfilter,tp,LOCATION_MZONE,0,1,nil) end
 Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_EQUIP)
 local g=Duel.SelectTarget(tp,s.eqfilter,tp,LOCATION_MZONE,0,1,1,nil)
 Duel.SetOperationInfo(0,CATEGORY_EQUIP,g,1,0,0)
end
function s.eqop(e,tp)
 local c=e:GetHandler()
 local tc=Duel.GetFirstTarget()
 if not c:IsRelateToEffect(e) or not tc or not tc:IsRelateToEffect(e) or not tc:IsFaceup()
  or Duel.GetLocationCount(tp,LOCATION_SZONE)<=0 then return end
 if Duel.Equip(tp,c,tc) then
  local e1=Effect.CreateEffect(c)
  e1:SetType(EFFECT_TYPE_SINGLE)
  e1:SetCode(EFFECT_EQUIP_LIMIT)
  e1:SetProperty(EFFECT_FLAG_CANNOT_DISABLE)
  e1:SetLabelObject(tc)
  e1:SetValue(function(e,mc) return mc==e:GetLabelObject() end)
  e1:SetReset(RESET_EVENT+RESETS_STANDARD)
  c:RegisterEffect(e1)
 end
end
function s.reptg(e,tp,eg,ep,ev,re,r,rp,chk)
 local c=e:GetHandler()
 local tc=c:GetEquipTarget()
 if chk==0 then return tc and eg:IsContains(tc) and not tc:IsReason(REASON_REPLACE)
  and c:IsDestructable() and not c:IsStatus(STATUS_DESTROY_CONFIRMED) end
 return Duel.SelectYesNo(tp,aux.Stringid(MSG_ID,2))
end
function s.repop(e,tp)
 Duel.Destroy(e:GetHandler(),REASON_EFFECT+REASON_REPLACE)
end

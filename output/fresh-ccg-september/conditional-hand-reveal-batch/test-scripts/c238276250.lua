--Incarnation of Nephthys
local s,id=GetID()
local SET_NEPHTHYS=0x11f
local MSG_ID=132276250
function s.initial_effect(c)
 local e1=Effect.CreateEffect(c)
 e1:SetDescription(aux.Stringid(MSG_ID,0))
 e1:SetCategory(CATEGORY_DESTROY+CATEGORY_SPECIAL_SUMMON)
 e1:SetType(EFFECT_TYPE_FIELD+EFFECT_TYPE_TRIGGER_O)
 e1:SetCode(EVENT_RELEASE)
 e1:SetRange(LOCATION_HAND)
 e1:SetProperty(EFFECT_FLAG_DELAY+EFFECT_FLAG_DAMAGE_STEP)
 e1:SetCountLimit(1,id)
 e1:SetCost(s.copycost)
 e1:SetTarget(s.copytg)
 e1:SetOperation(s.copyop)
 c:RegisterEffect(e1)
 local e2=e1:Clone()
 e2:SetCode(EVENT_DESTROYED)
 c:RegisterEffect(e2)
 local e3=Effect.CreateEffect(c)
 e3:SetDescription(aux.Stringid(MSG_ID,1))
 e3:SetCategory(CATEGORY_DESTROY)
 e3:SetType(EFFECT_TYPE_FIELD+EFFECT_TYPE_TRIGGER_O)
 e3:SetCode(EVENT_SPSUMMON_SUCCESS)
 e3:SetRange(LOCATION_GRAVE)
 e3:SetProperty(EFFECT_FLAG_DELAY)
 e3:SetCountLimit(1,id+100)
 e3:SetCondition(s.summoncon)
 e3:SetCost(aux.bfgcost)
 e3:SetTarget(s.destg)
 e3:SetOperation(s.desop)
 c:RegisterEffect(e3)
 local e4=Effect.CreateEffect(c)
 e4:SetType(EFFECT_TYPE_SINGLE+EFFECT_TYPE_CONTINUOUS)
 e4:SetProperty(EFFECT_FLAG_CANNOT_DISABLE)
 e4:SetCode(EVENT_TO_GRAVE)
 e4:SetOperation(s.delayreg)
 c:RegisterEffect(e4)
 local e5=Effect.CreateEffect(c)
 e5:SetDescription(aux.Stringid(MSG_ID,2))
 e5:SetCategory(CATEGORY_TODECK)
 e5:SetType(EFFECT_TYPE_FIELD+EFFECT_TYPE_TRIGGER_O)
 e5:SetCode(EVENT_PHASE+PHASE_STANDBY)
 e5:SetRange(LOCATION_GRAVE)
 e5:SetProperty(EFFECT_FLAG_CARD_TARGET)
 e5:SetCountLimit(1,id+200)
 e5:SetLabelObject(e4)
 e5:SetCondition(s.delaycon)
 e5:SetTarget(s.shuffletg)
 e5:SetOperation(s.shuffleop)
 c:RegisterEffect(e5)
end
function s.ritualhand(c)
 return c:IsSetCard(SET_NEPHTHYS) and c:IsType(TYPE_MONSTER) and c:IsType(TYPE_RITUAL) and not c:IsPublic()
end
function s.spellfilter(tc,e,tp,eg,ep,ev,re,r,rp)
 if not tc:IsSetCard(SET_NEPHTHYS) or not tc:IsType(TYPE_SPELL) or not tc:IsType(TYPE_RITUAL)
  or not tc:IsAbleToGraveAsCost() then return false end
 local ac=tc:GetActivateEffect()
 if not ac or not ac:GetOperation() then return false end
 --The handler will be destroyed before the copied Ritual; it cannot be its material.
 local block=Effect.CreateEffect(e:GetHandler())
 block:SetType(EFFECT_TYPE_SINGLE)
 block:SetCode(EFFECT_UNRELEASABLE_NONSUM)
 block:SetValue(1)
 e:GetHandler():RegisterEffect(block)
 local target=ac:GetTarget()
 local legal=not target or target(e,tp,eg,ep,ev,re,r,rp,0)
 block:Reset()
 return legal
end
function s.copycost(e,tp,eg,ep,ev,re,r,rp,chk)
 local c=e:GetHandler()
 if chk==0 then return not c:IsPublic() and c:IsDestructable()
  and Duel.IsExistingMatchingCard(s.ritualhand,tp,LOCATION_HAND,0,1,c)
  and Duel.IsExistingMatchingCard(s.spellfilter,tp,LOCATION_HAND+LOCATION_DECK,0,1,nil,e,tp,eg,ep,ev,re,r,rp) end
 Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_CONFIRM)
 local g=Duel.SelectMatchingCard(tp,s.ritualhand,tp,LOCATION_HAND,0,1,1,c)
 g:AddCard(c)
 Duel.ConfirmCards(1-tp,g)
 Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_TOGRAVE)
 local tc=Duel.SelectMatchingCard(tp,s.spellfilter,tp,LOCATION_HAND+LOCATION_DECK,0,1,1,nil,e,tp,eg,ep,ev,re,r,rp):GetFirst()
 e:SetLabelObject(tc:GetActivateEffect())
 Duel.SendtoGrave(tc,REASON_COST)
end
function s.copytg(e,tp,eg,ep,ev,re,r,rp,chk)
 if chk==0 then return true end
 Duel.SetOperationInfo(0,CATEGORY_DESTROY,e:GetHandler(),1,tp,LOCATION_HAND)
 Duel.SetOperationInfo(0,CATEGORY_SPECIAL_SUMMON,nil,1,tp,LOCATION_HAND)
end
function s.copyop(e,tp,eg,ep,ev,re,r,rp)
 local c=e:GetHandler()
 local ac=e:GetLabelObject()
 if not c:IsRelateToEffect(e) or not c:IsLocation(LOCATION_HAND) or Duel.Destroy(c,REASON_EFFECT)==0 then return end
 local operation=ac and ac:GetOperation()
 if operation then operation(e,tp,eg,ep,ev,re,r,rp) end
end
function s.tributecount(c)
 if not c:IsSetCard(SET_NEPHTHYS) or not c:IsType(TYPE_RITUAL) or not c:IsSummonType(SUMMON_TYPE_RITUAL) then return 0 end
 return c:GetMaterial():FilterCount(Card.IsReason,nil,REASON_RELEASE)
end
function s.summoncon(e,tp,eg)
 return eg:IsExists(function(c) return s.tributecount(c)>0 end,1,nil)
end
function s.enemy(c)
 return c:IsDestructable()
end
function s.destg(e,tp,eg,ep,ev,re,r,rp,chk)
 local ct=0
 for tc in aux.Next(eg) do ct=math.max(ct,s.tributecount(tc)) end
 if chk==0 then return ct>0 and Duel.IsExistingMatchingCard(s.enemy,tp,0,LOCATION_ONFIELD,1,nil) end
 e:SetLabel(ct)
 Duel.SetOperationInfo(0,CATEGORY_DESTROY,nil,ct,1-tp,LOCATION_ONFIELD)
end
function s.desop(e,tp)
 Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_DESTROY)
 local g=Duel.SelectMatchingCard(tp,s.enemy,tp,0,LOCATION_ONFIELD,1,e:GetLabel(),nil)
 if #g>0 then Duel.Destroy(g,REASON_EFFECT) end
end
function s.delayreg(e,tp)
 local c=e:GetHandler()
 if not c:IsReason(REASON_DESTROY) or not c:IsReason(REASON_EFFECT) then return end
 local ownStandby=Duel.GetTurnPlayer()==tp and Duel.GetCurrentPhase()==PHASE_STANDBY
 e:SetLabel(ownStandby and Duel.GetTurnCount() or 0)
 c:RegisterFlagEffect(id,RESET_EVENT+RESETS_STANDARD+RESET_PHASE+PHASE_STANDBY+RESET_SELF_TURN,0,ownStandby and 2 or 1)
end
function s.delaycon(e,tp)
 return tp==Duel.GetTurnPlayer() and e:GetLabelObject():GetLabel()~=Duel.GetTurnCount() and e:GetHandler():GetFlagEffect(id)>0
end
function s.recycle(c)
 return c:IsSetCard(SET_NEPHTHYS) and c:IsType(TYPE_MONSTER) and c:IsAbleToDeck()
end
function s.shuffletg(e,tp,eg,ep,ev,re,r,rp,chk,chkc)
 if chkc then return chkc:IsControler(tp) and chkc:IsLocation(LOCATION_GRAVE) and s.recycle(chkc) end
 if chk==0 then return Duel.IsExistingTarget(aux.NecroValleyFilter(s.recycle),tp,LOCATION_GRAVE,0,2,nil) end
 e:GetHandler():ResetFlagEffect(id)
 Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_TODECK)
 local g=Duel.SelectTarget(tp,aux.NecroValleyFilter(s.recycle),tp,LOCATION_GRAVE,0,2,2,nil)
 Duel.SetOperationInfo(0,CATEGORY_TODECK,g,2,tp,LOCATION_GRAVE)
end
function s.shuffleop(e,tp)
 local g=Duel.GetChainInfo(0,CHAININFO_TARGET_CARDS):Filter(Card.IsRelateToEffect,nil,e)
 if #g>0 then Duel.SendtoDeck(g,nil,SEQ_DECKSHUFFLE,REASON_EFFECT) end
end

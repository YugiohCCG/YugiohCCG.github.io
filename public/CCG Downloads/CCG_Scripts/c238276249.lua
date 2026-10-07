--Apostle of Nephthys
--Delayed destruction timing follows Omega c25397880.
local s,id=GetID()
local SET_NEPHTHYS=0x11f
local MSG_ID=132276249
function s.initial_effect(c)
 local e1=Effect.CreateEffect(c)
 e1:SetDescription(aux.Stringid(MSG_ID,0))
 e1:SetCategory(CATEGORY_DESTROY+CATEGORY_SPECIAL_SUMMON+CATEGORY_TOHAND+CATEGORY_SEARCH)
 e1:SetType(EFFECT_TYPE_QUICK_O)
 e1:SetCode(EVENT_FREE_CHAIN)
 e1:SetRange(LOCATION_HAND)
 e1:SetCountLimit(1,id)
 e1:SetCost(s.revealcost)
 e1:SetTarget(s.handtg)
 e1:SetOperation(s.handop)
 c:RegisterEffect(e1)
 local e2=Effect.CreateEffect(c)
 e2:SetDescription(aux.Stringid(MSG_ID,1))
 e2:SetCategory(CATEGORY_DESTROY)
 e2:SetType(EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_O)
 e2:SetProperty(EFFECT_FLAG_DELAY)
 e2:SetCode(EVENT_SUMMON_SUCCESS)
 e2:SetCountLimit(1,id+100)
 e2:SetTarget(s.searchtg)
 e2:SetOperation(s.searchop)
 c:RegisterEffect(e2)
 local e3=e2:Clone()
 e3:SetCode(EVENT_SPSUMMON_SUCCESS)
 c:RegisterEffect(e3)
 local e4=Effect.CreateEffect(c)
 e4:SetType(EFFECT_TYPE_SINGLE+EFFECT_TYPE_CONTINUOUS)
 e4:SetProperty(EFFECT_FLAG_CANNOT_DISABLE)
 e4:SetCode(EVENT_TO_GRAVE)
 e4:SetOperation(s.delayreg)
 c:RegisterEffect(e4)
 local e5=Effect.CreateEffect(c)
 e5:SetDescription(aux.Stringid(MSG_ID,2))
 e5:SetCategory(CATEGORY_SPECIAL_SUMMON)
 e5:SetType(EFFECT_TYPE_FIELD+EFFECT_TYPE_TRIGGER_O)
 e5:SetCode(EVENT_PHASE+PHASE_STANDBY)
 e5:SetRange(LOCATION_GRAVE)
 e5:SetCountLimit(1,id+200)
 e5:SetLabelObject(e4)
 e5:SetCondition(s.delaycon)
 e5:SetTarget(s.recovertg)
 e5:SetOperation(s.recoverop)
 c:RegisterEffect(e5)
end
function s.revealcost(e,tp,eg,ep,ev,re,r,rp,chk)
 if chk==0 then return not e:GetHandler():IsPublic() end
 Duel.ConfirmCards(1-tp,e:GetHandler())
end
function s.destroyfilter(c)
 return c:IsDestructable()
end
function s.handtg(e,tp,eg,ep,ev,re,r,rp,chk)
 if chk==0 then return Duel.GetLocationCount(tp,LOCATION_MZONE)>0
  and e:GetHandler():IsCanBeSpecialSummoned(e,0,tp,false,false)
  and Duel.IsExistingMatchingCard(s.destroyfilter,tp,LOCATION_HAND,0,1,e:GetHandler()) end
 Duel.SetOperationInfo(0,CATEGORY_DESTROY,nil,1,tp,LOCATION_HAND)
 Duel.SetOperationInfo(0,CATEGORY_SPECIAL_SUMMON,e:GetHandler(),1,tp,LOCATION_HAND)
end
function s.spellfilter(c)
 return c:IsSetCard(SET_NEPHTHYS) and c:IsType(TYPE_SPELL) and c:IsAbleToHand()
end
function s.handop(e,tp)
 Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_DESTROY)
 local tc=Duel.SelectMatchingCard(tp,s.destroyfilter,tp,LOCATION_HAND,0,1,1,e:GetHandler()):GetFirst()
 if not tc then return end
 local nephthys=tc:IsSetCard(SET_NEPHTHYS)
 if Duel.Destroy(tc,REASON_EFFECT)==0 then return end
 --Keep the physical card reference across moves; other copies remain free to activate.
 local lock=Effect.CreateEffect(e:GetHandler())
 lock:SetType(EFFECT_TYPE_FIELD)
 lock:SetCode(EFFECT_CANNOT_ACTIVATE)
 lock:SetProperty(EFFECT_FLAG_PLAYER_TARGET)
 lock:SetTargetRange(1,1)
 lock:SetValue(function(e,re) return re:GetHandler()==tc end)
 lock:SetReset(RESET_PHASE+PHASE_END)
 Duel.RegisterEffect(lock,tp)
 local c=e:GetHandler()
 if not c:IsRelateToEffect(e) or not c:IsLocation(LOCATION_HAND)
  or Duel.SpecialSummon(c,0,tp,tp,false,false,POS_FACEUP)==0 then return end
 if nephthys and Duel.IsExistingMatchingCard(aux.NecroValleyFilter(s.spellfilter),tp,LOCATION_DECK+LOCATION_GRAVE,0,1,nil)
  and Duel.SelectYesNo(tp,aux.Stringid(MSG_ID,3)) then
  Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_ATOHAND)
  local g=Duel.SelectMatchingCard(tp,aux.NecroValleyFilter(s.spellfilter),tp,LOCATION_DECK+LOCATION_GRAVE,0,1,1,nil)
  if #g>0 then Duel.SendtoHand(g,nil,REASON_EFFECT) Duel.ConfirmCards(1-tp,g) end
 end
end
function s.enemyfilter(c)
 return c:IsType(TYPE_MONSTER) and c:IsDestructable()
end
function s.searchtg(e,tp,eg,ep,ev,re,r,rp,chk)
 if chk==0 then return Duel.IsExistingMatchingCard(s.enemyfilter,tp,0,LOCATION_MZONE,1,nil) end
 Duel.SetOperationInfo(0,CATEGORY_DESTROY,nil,1,1-tp,LOCATION_MZONE)
end
function s.searchop(e,tp)
 Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_DESTROY)
 local g=Duel.SelectMatchingCard(tp,s.enemyfilter,tp,0,LOCATION_MZONE,1,1,nil)
 if #g>0 then Duel.Destroy(g,REASON_EFFECT) end
end
function s.delayreg(e,tp,eg,ep,ev,re,r)
 local c=e:GetHandler()
 if not c:IsReason(REASON_DESTROY) or not c:IsReason(REASON_EFFECT) then return end
 local ownStandby=Duel.GetTurnPlayer()==tp and Duel.GetCurrentPhase()==PHASE_STANDBY
 e:SetLabel(ownStandby and Duel.GetTurnCount() or 0)
 c:RegisterFlagEffect(id,RESET_EVENT+RESETS_STANDARD+RESET_PHASE+PHASE_STANDBY+RESET_SELF_TURN,0,ownStandby and 2 or 1)
end
function s.delaycon(e,tp)
 return tp==Duel.GetTurnPlayer() and e:GetLabelObject():GetLabel()~=Duel.GetTurnCount() and e:GetHandler():GetFlagEffect(id)>0
end
function s.recovertg(e,tp,eg,ep,ev,re,r,rp,chk)
 local c=e:GetHandler()
 if chk==0 then return Duel.GetLocationCount(tp,LOCATION_MZONE)>0 and c:IsCanBeSpecialSummoned(e,0,tp,false,false) end
 c:ResetFlagEffect(id)
 Duel.SetOperationInfo(0,CATEGORY_SPECIAL_SUMMON,c,1,tp,LOCATION_GRAVE)
end
function s.recoverop(e,tp)
 local c=e:GetHandler()
 if c:IsRelateToEffect(e) then Duel.SpecialSummon(c,0,tp,tp,false,false,POS_FACEUP) end
end

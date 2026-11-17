--Heart of the Hydra
local s,id=GetID()
local SWAMP=239935101
local SET_HYDRA=0xa124
local SET_DARK_SWAMP=0xa123
local MSG_ID=133935093
function s.initial_effect(c)
 c:SetUniqueOnField(1,0,id)
 aux.AddCodeList(c,SWAMP)
 Duel.AddCustomActivityCounter(id,ACTIVITY_SPSUMMON,s.waterreptile)
 local e1=Effect.CreateEffect(c)
 e1:SetDescription(aux.Stringid(MSG_ID,0))
 e1:SetCategory(CATEGORY_TOGRAVE)
 e1:SetType(EFFECT_TYPE_IGNITION)
 e1:SetRange(LOCATION_HAND+LOCATION_ONFIELD+LOCATION_GRAVE)
 e1:SetCountLimit(1,id)
 e1:SetCost(s.placecost)
 e1:SetTarget(s.placetg)
 e1:SetOperation(s.placeop)
 c:RegisterEffect(e1)
 local e2=Effect.CreateEffect(c)
 e2:SetType(EFFECT_TYPE_SINGLE)
 e2:SetCode(EFFECT_INDESTRUCTABLE_EFFECT)
 e2:SetRange(LOCATION_SZONE)
 e2:SetProperty(EFFECT_FLAG_SINGLE_RANGE)
 e2:SetCondition(s.protectcon)
 e2:SetValue(function(e,re,rp) return rp~=e:GetHandlerPlayer() end)
 c:RegisterEffect(e2)
 local e3=Effect.CreateEffect(c)
 e3:SetType(EFFECT_TYPE_FIELD+EFFECT_TYPE_CONTINUOUS)
 e3:SetCode(EFFECT_SEND_REPLACE)
 e3:SetRange(LOCATION_SZONE)
 e3:SetCondition(s.spellcon)
 e3:SetTarget(s.deckreptg)
 e3:SetValue(s.deckrepval)
 c:RegisterEffect(e3)
 local e4=Effect.CreateEffect(c)
 e4:SetDescription(aux.Stringid(MSG_ID,1))
 e4:SetCategory(CATEGORY_TOHAND+CATEGORY_SEARCH)
 e4:SetType(EFFECT_TYPE_IGNITION)
 e4:SetRange(LOCATION_SZONE)
 e4:SetCountLimit(1)
 e4:SetCondition(s.spellcon)
 e4:SetTarget(s.addtg)
 e4:SetOperation(s.addop)
 c:RegisterEffect(e4)
end
s.listed_names={SWAMP}
s.listed_series={SET_HYDRA,SET_DARK_SWAMP}
function s.waterreptile(c)
 return c:IsAttribute(ATTRIBUTE_WATER) and c:IsRace(RACE_REPTILE)
end
function s.placecost(e,tp,eg,ep,ev,re,r,rp,chk)
 if chk==0 then return Duel.GetCustomActivityCount(id,tp,ACTIVITY_SPSUMMON)==0 end
 local lock=Effect.CreateEffect(e:GetHandler())
 lock:SetType(EFFECT_TYPE_FIELD)
 lock:SetProperty(EFFECT_FLAG_PLAYER_TARGET+EFFECT_FLAG_OATH)
 lock:SetCode(EFFECT_CANNOT_SPECIAL_SUMMON)
 lock:SetTargetRange(1,0)
 lock:SetTarget(function(e,c) return not s.waterreptile(c) end)
 lock:SetReset(RESET_PHASE+PHASE_END)
 Duel.RegisterEffect(lock,tp)
end
function s.sendfilter(c)
 return c:IsType(TYPE_MONSTER) and s.waterreptile(c) and not c:IsCode(id) and c:IsAbleToGrave()
end
function s.placetg(e,tp,eg,ep,ev,re,r,rp,chk)
 local c=e:GetHandler()
 local owner=c:GetOwner()
 if chk==0 then return not c:IsForbidden()
  and (Duel.GetLocationCount(owner,LOCATION_SZONE)>0 or (c:IsControler(owner) and c:IsLocation(LOCATION_SZONE) and c:GetSequence()<5))
  and Duel.IsExistingMatchingCard(s.sendfilter,tp,LOCATION_DECK,0,1,nil) end
 e:SetLabel(c:IsLocation(LOCATION_GRAVE) and 1 or 0)
 Duel.SetOperationInfo(0,CATEGORY_TOGRAVE,nil,1,tp,LOCATION_DECK)
end
function s.placeop(e,tp)
 local c=e:GetHandler()
 if not c:IsRelateToEffect(e) then return end
 Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_TOGRAVE)
 local g=Duel.SelectMatchingCard(tp,s.sendfilter,tp,LOCATION_DECK,0,1,1,nil)
 if #g==0 or Duel.SendtoGrave(g,REASON_EFFECT)==0 then return end
 local owner=c:GetOwner()
 local there=c:IsControler(owner) and c:IsLocation(LOCATION_SZONE) and c:GetSequence()<5 and c:IsFaceup()
 if not there and (Duel.GetLocationCount(owner,LOCATION_SZONE)<=0
  or not Duel.MoveToField(c,tp,owner,LOCATION_SZONE,POS_FACEUP,true)) then return end
 local change=Effect.CreateEffect(c)
 change:SetType(EFFECT_TYPE_SINGLE)
 change:SetCode(EFFECT_CHANGE_TYPE)
 change:SetProperty(EFFECT_FLAG_CANNOT_DISABLE)
 change:SetValue(TYPE_SPELL+TYPE_CONTINUOUS)
 change:SetReset(RESET_EVENT+RESETS_STANDARD-RESET_TURN_SET)
 c:RegisterEffect(change)
 if e:GetLabel()==1 then
  local redirect=Effect.CreateEffect(c)
  redirect:SetType(EFFECT_TYPE_SINGLE)
  redirect:SetProperty(EFFECT_FLAG_CANNOT_DISABLE)
  redirect:SetCode(EFFECT_LEAVE_FIELD_REDIRECT)
  redirect:SetValue(LOCATION_REMOVED)
  redirect:SetReset(RESET_EVENT+RESETS_REDIRECT)
  c:RegisterEffect(redirect,true)
 end
end
function s.spellcon(e)
 local c=e:GetHandler()
 return c:IsFaceup() and c:IsType(TYPE_SPELL) and c:IsType(TYPE_CONTINUOUS)
end
function s.protectcon(e)
 return s.spellcon(e) and Duel.IsExistingMatchingCard(function(c) return c:IsFaceup() and c:IsCode(SWAMP) end,e:GetHandlerPlayer(),LOCATION_ONFIELD,0,1,nil)
end
function s.deckrepfilter(c,tp)
 return c:IsFaceup() and c:IsControler(tp) and c:IsLocation(LOCATION_MZONE) and c:IsSetCard(SET_HYDRA)
  and c:GetDestination()==LOCATION_DECK and c:IsReason(REASON_EFFECT) and not c:IsReason(REASON_REPLACE)
end
function s.deckreptg(e,tp,eg,ep,ev,re,r,rp,chk)
 if chk==0 then return eg:IsExists(s.deckrepfilter,1,nil,tp) end
 return true
end
function s.deckrepval(e,c)
 return s.deckrepfilter(c,e:GetHandlerPlayer())
end
function s.addfilter(c)
 return c:IsType(TYPE_SPELL+TYPE_TRAP) and c:IsSetCard(SET_DARK_SWAMP) and c:IsAbleToHand()
end
function s.addtg(e,tp,eg,ep,ev,re,r,rp,chk)
 if chk==0 then return Duel.IsExistingMatchingCard(s.addfilter,tp,LOCATION_DECK,0,1,nil) end
 Duel.SetOperationInfo(0,CATEGORY_TOHAND,nil,1,tp,LOCATION_DECK)
end
function s.addop(e,tp)
 if not e:GetHandler():IsRelateToEffect(e) or not s.spellcon(e) then return end
 Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_ATOHAND)
 local g=Duel.SelectMatchingCard(tp,s.addfilter,tp,LOCATION_DECK,0,1,1,nil)
 if #g>0 and Duel.SendtoHand(g,nil,REASON_EFFECT)>0 then Duel.ConfirmCards(1-tp,g) end
end

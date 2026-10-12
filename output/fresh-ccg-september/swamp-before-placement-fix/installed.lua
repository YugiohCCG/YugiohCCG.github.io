--Terrifying Dark Swamp
local s,id=GetID()
local SET_HYDRA=0xa124
local MSG_ID=133935101
function s.initial_effect(c)
 local e1=Effect.CreateEffect(c)
 e1:SetDescription(aux.Stringid(MSG_ID,0))
 e1:SetType(EFFECT_TYPE_ACTIVATE)
 e1:SetCode(EVENT_FREE_CHAIN)
 e1:SetCountLimit(1,id)
 e1:SetTarget(s.placetg)
 e1:SetOperation(s.placeop)
 c:RegisterEffect(e1)
 local e2=Effect.CreateEffect(c)
 e2:SetDescription(aux.Stringid(MSG_ID,1))
 e2:SetCategory(CATEGORY_DESTROY)
 e2:SetType(EFFECT_TYPE_FIELD+EFFECT_TYPE_TRIGGER_O)
 e2:SetCode(EVENT_BATTLE_START)
 e2:SetRange(LOCATION_FZONE)
 e2:SetCountLimit(1,id+100)
 e2:SetCondition(s.battlecon)
 e2:SetTarget(s.battletg)
 e2:SetOperation(s.battleop)
 c:RegisterEffect(e2)
 local e3=Effect.CreateEffect(c)
 e3:SetDescription(aux.Stringid(MSG_ID,3))
 e3:SetCategory(CATEGORY_TODECK)
 e3:SetType(EFFECT_TYPE_FIELD+EFFECT_TYPE_TRIGGER_O)
 e3:SetCode(EVENT_PHASE+PHASE_END)
 e3:SetRange(LOCATION_FZONE)
 e3:SetCountLimit(1,id+200)
 e3:SetCondition(function(e,tp) return Duel.GetTurnPlayer()~=tp end)
 e3:SetTarget(s.shuffletg)
 e3:SetOperation(s.shuffleop)
 c:RegisterEffect(e3)
end
s.listed_series={SET_HYDRA}
function s.placefilter(c)
 return c:IsType(TYPE_MONSTER) and c:IsAttribute(ATTRIBUTE_WATER)
  and c:IsRace(RACE_REPTILE) and not c:IsForbidden()
end
function s.placetg(e,tp,eg,ep,ev,re,r,rp,chk)
 if chk==0 then return Duel.GetLocationCount(tp,LOCATION_SZONE)>0
  and Duel.IsExistingMatchingCard(s.placefilter,tp,LOCATION_DECK,0,1,nil) end
end
function s.placeop(e,tp)
 local c=e:GetHandler()
 if not c:IsRelateToEffect(e) or Duel.GetLocationCount(tp,LOCATION_SZONE)<=0 then return end
 Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_TOFIELD)
 local g=Duel.SelectMatchingCard(tp,s.placefilter,tp,LOCATION_DECK,0,1,1,nil)
 local tc=g:GetFirst()
 if not tc or not Duel.MoveToField(tc,tp,tp,LOCATION_SZONE,POS_FACEUP,true) then return end
 local change=Effect.CreateEffect(c)
 change:SetType(EFFECT_TYPE_SINGLE)
 change:SetCode(EFFECT_CHANGE_TYPE)
 change:SetProperty(EFFECT_FLAG_CANNOT_DISABLE)
 change:SetValue(TYPE_SPELL+TYPE_CONTINUOUS)
 change:SetReset(RESET_EVENT+RESETS_STANDARD-RESET_TURN_SET)
 tc:RegisterEffect(change)
end
function s.hydra(c)
 return c and c:IsFaceup() and c:IsSetCard(SET_HYDRA)
end
function s.battlecon()
 return s.hydra(Duel.GetAttacker()) or s.hydra(Duel.GetAttackTarget())
end
function s.battletg(e,tp,eg,ep,ev,re,r,rp,chk)
 if chk==0 then return (s.hydra(Duel.GetAttacker()) and Duel.GetAttacker():IsDestructable())
  or (s.hydra(Duel.GetAttackTarget()) and Duel.GetAttackTarget():IsDestructable()) end
end
function s.battleop(e,tp)
 local c=e:GetHandler()
 if not c:IsRelateToEffect(e) then return end
 local a,b=Duel.GetAttacker(),Duel.GetAttackTarget()
 local g=Group.CreateGroup()
 if s.hydra(a) and a:IsDestructable() then g:AddCard(a) end
 if s.hydra(b) and b:IsDestructable() then g:AddCard(b) end
 if #g==0 then return end
 Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_DESTROY)
 local tc=g:Select(tp,1,1,nil):GetFirst()
 local other=tc==a and b or a
 if Duel.Destroy(tc,REASON_EFFECT)==0 or not other or not other:IsControler(1-tp)
  or not other:IsLocation(LOCATION_MZONE) or not other:IsFaceup()
  or not Duel.SelectYesNo(tp,aux.Stringid(MSG_ID,2)) then return end
 local zero=Effect.CreateEffect(c)
 zero:SetType(EFFECT_TYPE_SINGLE)
 zero:SetCode(EFFECT_SET_ATTACK_FINAL)
 zero:SetValue(0)
 zero:SetReset(RESET_EVENT+RESETS_STANDARD)
 other:RegisterEffect(zero)
 local def=zero:Clone()
 def:SetCode(EFFECT_SET_DEFENSE_FINAL)
 other:RegisterEffect(def)
end
function s.shufflefilter(c)
 return c:IsFaceup() and c:IsType(TYPE_MONSTER) and c:IsAttribute(ATTRIBUTE_WATER)
  and c:IsRace(RACE_REPTILE) and c:IsAbleToDeck()
end
function s.shuffletg(e,tp,eg,ep,ev,re,r,rp,chk)
 if chk==0 then return Duel.IsExistingMatchingCard(s.shufflefilter,tp,LOCATION_REMOVED,0,1,nil) end
 Duel.SetOperationInfo(0,CATEGORY_TODECK,nil,1,tp,LOCATION_REMOVED)
end
function s.shuffleop(e,tp)
 if not e:GetHandler():IsRelateToEffect(e) then return end
 Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_TODECK)
 local g=Duel.SelectMatchingCard(tp,s.shufflefilter,tp,LOCATION_REMOVED,0,1,2,nil)
 if #g>0 then Duel.SendtoDeck(g,nil,SEQ_DECKSHUFFLE,REASON_EFFECT) end
end

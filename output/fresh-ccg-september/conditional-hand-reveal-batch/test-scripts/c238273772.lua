--Symphonic Warrior Mega Staar
local s,id=GetID()
local MSG_ID=132273772
local COUNTER_SYMPHONIC=0x35
function s.initial_effect(c)
 aux.EnablePendulumAttribute(c,false)
 c:EnableReviveLimit()
 aux.AddSynchroProcedure(c,aux.FilterBoolFunction(Card.IsAttribute,ATTRIBUTE_WIND),aux.NonTuner(s.nonTuner),1)
 local e1=Effect.CreateEffect(c)
 e1:SetDescription(aux.Stringid(MSG_ID,0))
 e1:SetCategory(CATEGORY_SPECIAL_SUMMON)
 e1:SetType(EFFECT_TYPE_IGNITION)
 e1:SetRange(LOCATION_PZONE)
 e1:SetCost(s.pcost)
 e1:SetTarget(s.ptg)
 e1:SetOperation(s.pop)
 c:RegisterEffect(e1)
 local e2=Effect.CreateEffect(c)
 e2:SetType(EFFECT_TYPE_FIELD)
 e2:SetCode(EFFECT_UPDATE_ATTACK)
 e2:SetRange(LOCATION_PZONE)
 e2:SetTargetRange(0,LOCATION_MZONE)
 e2:SetValue(s.pvalue)
 c:RegisterEffect(e2)
 local e3=e2:Clone()
 e3:SetCode(EFFECT_UPDATE_DEFENSE)
 c:RegisterEffect(e3)
 local e4=Effect.CreateEffect(c)
 e4:SetType(EFFECT_TYPE_SINGLE)
 e4:SetProperty(EFFECT_FLAG_SINGLE_RANGE)
 e4:SetCode(EFFECT_CANNOT_BE_EFFECT_TARGET)
 e4:SetRange(LOCATION_MZONE)
 e4:SetValue(aux.tgoval)
 c:RegisterEffect(e4)
 local e5=e4:Clone()
 e5:SetCode(EFFECT_INDESTRUCTABLE_EFFECT)
 e5:SetValue(function(e,re,rp) return rp~=e:GetHandlerPlayer() end)
 c:RegisterEffect(e5)
 local e6=e2:Clone()
 e6:SetRange(LOCATION_MZONE)
 e6:SetValue(s.mvalue)
 c:RegisterEffect(e6)
 local e7=e6:Clone()
 e7:SetCode(EFFECT_UPDATE_DEFENSE)
 c:RegisterEffect(e7)
 local e8=Effect.CreateEffect(c)
 e8:SetDescription(aux.Stringid(MSG_ID,1))
 e8:SetCategory(CATEGORY_REMOVE)
 e8:SetType(EFFECT_TYPE_QUICK_O)
 e8:SetCode(EVENT_FREE_CHAIN)
 e8:SetRange(LOCATION_MZONE)
 e8:SetCountLimit(1)
 e8:SetCondition(s.banishcon)
 e8:SetCost(s.banishcost)
 e8:SetTarget(s.banishtg)
 e8:SetOperation(s.banishop)
 c:RegisterEffect(e8)
 local e9=Effect.CreateEffect(c)
 e9:SetDescription(aux.Stringid(MSG_ID,2))
 e9:SetType(EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_O)
 e9:SetCode(EVENT_LEAVE_FIELD)
 e9:SetProperty(EFFECT_FLAG_DELAY)
 e9:SetCondition(s.leavecon)
 e9:SetTarget(s.leavetg)
 e9:SetOperation(s.leaveop)
 c:RegisterEffect(e9)
end
function s.nonTuner(c)
 return c:IsAttribute(ATTRIBUTE_WIND) and c:IsType(TYPE_PENDULUM) and c:IsType(TYPE_SYNCHRO)
end
function s.tributefilter(c)
 return c:IsFaceup() and c:IsAttribute(ATTRIBUTE_WIND) and c:IsRace(RACE_MACHINE)
  and c:IsType(TYPE_SYNCHRO) and c:IsReleasable()
end
function s.pcost(e,tp,eg,ep,ev,re,r,rp,chk)
 if chk==0 then return Duel.IsExistingMatchingCard(s.tributefilter,tp,LOCATION_MZONE,0,1,nil) end
 Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_RELEASE)
 local g=Duel.SelectMatchingCard(tp,s.tributefilter,tp,LOCATION_MZONE,0,1,1,nil)
 Duel.Release(g,REASON_COST)
end
function s.ptg(e,tp,eg,ep,ev,re,r,rp,chk)
 if chk==0 then return e:GetHandler():IsCanBeSpecialSummoned(e,0,tp,false,false)
  and Duel.IsExistingMatchingCard(s.spacefilter,tp,LOCATION_MZONE,0,1,nil,tp) end
 Duel.SetOperationInfo(0,CATEGORY_SPECIAL_SUMMON,e:GetHandler(),1,tp,LOCATION_PZONE)
end
function s.spacefilter(c,tp)
 return s.tributefilter(c) and Duel.GetMZoneCount(tp,c)>0
end
function s.pop(e,tp)
 local c=e:GetHandler()
 if c:IsRelateToEffect(e) and c:IsLocation(LOCATION_PZONE) then Duel.SpecialSummon(c,0,tp,tp,false,false,POS_FACEUP) end
end
function s.pvalue(e)
 return -300*Duel.GetCounter(e:GetHandlerPlayer(),1,1,COUNTER_SYMPHONIC)
end
function s.mvalue(e)
 return -200*Duel.GetCounter(e:GetHandlerPlayer(),1,1,COUNTER_SYMPHONIC)
end
function s.banishcon(e,tp)
 return Duel.IsExistingMatchingCard(function(c) return c:IsFaceup() and c:IsCode(75304793) end,tp,LOCATION_FZONE,0,1,nil)
end
function s.banishcost(e,tp,eg,ep,ev,re,r,rp,chk)
 if chk==0 then return Duel.IsCanRemoveCounter(tp,1,1,COUNTER_SYMPHONIC,1,REASON_COST) end
 local choices={}
 local ct=Duel.GetCounter(tp,1,1,COUNTER_SYMPHONIC)
 for i=1,ct do
  if Duel.IsCanRemoveCounter(tp,1,1,COUNTER_SYMPHONIC,i,REASON_COST) then choices[#choices+1]=i end
 end
 local removed=Duel.AnnounceNumber(tp,table.unpack(choices))
 e:SetLabel(removed)
 Duel.RemoveCounter(tp,1,1,COUNTER_SYMPHONIC,removed,REASON_COST)
end
function s.banishtg(e,tp,eg,ep,ev,re,r,rp,chk)
 if chk==0 then return Duel.IsExistingMatchingCard(Card.IsAbleToRemove,tp,0,LOCATION_ONFIELD+LOCATION_GRAVE,1,nil) end
 Duel.SetOperationInfo(0,CATEGORY_REMOVE,nil,1,1-tp,LOCATION_ONFIELD+LOCATION_GRAVE)
end
function s.banishop(e,tp)
 Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_REMOVE)
 local g=Duel.SelectMatchingCard(tp,Card.IsAbleToRemove,tp,0,LOCATION_ONFIELD+LOCATION_GRAVE,1,e:GetLabel(),nil)
 if #g>0 then Duel.Remove(g,POS_FACEUP,REASON_EFFECT) end
end
function s.leavecon(e,tp)
 local c=e:GetHandler()
 return c:IsPreviousLocation(LOCATION_MZONE) and c:IsPreviousControler(tp)
  and (c:IsReason(REASON_BATTLE) or c:IsReason(REASON_EFFECT) and c:GetReasonPlayer()==1-tp)
end
function s.leavetg(e,tp,eg,ep,ev,re,r,rp,chk)
 if chk==0 then return not e:GetHandler():IsForbidden()
  and (Duel.CheckLocation(tp,LOCATION_PZONE,0) or Duel.CheckLocation(tp,LOCATION_PZONE,1)) end
end
function s.leaveop(e,tp)
 local c=e:GetHandler()
 if c:IsRelateToEffect(e) and not c:IsForbidden()
  and (Duel.CheckLocation(tp,LOCATION_PZONE,0) or Duel.CheckLocation(tp,LOCATION_PZONE,1)) then
  Duel.MoveToField(c,tp,tp,LOCATION_PZONE,POS_FACEUP,true)
 end
end

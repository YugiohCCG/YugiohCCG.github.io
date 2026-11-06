--Symphonic Warrior Disccs
--Counter mentions are derived from the pinned roster and local official card text.
local s,id=GetID()
local SET_SYMPHONIC=0x1066
local MSG_ID=132273770
local COUNTER_SYMPHONIC=0x35
function s.initial_effect(c)
 aux.EnablePendulumAttribute(c)
 local e1=Effect.CreateEffect(c)
 e1:SetDescription(aux.Stringid(MSG_ID,0))
 e1:SetCategory(CATEGORY_SPECIAL_SUMMON)
 e1:SetType(EFFECT_TYPE_IGNITION)
 e1:SetRange(LOCATION_PZONE)
 e1:SetCountLimit(1,id)
 e1:SetCost(s.pcost)
 e1:SetTarget(s.ptg)
 e1:SetOperation(s.pop)
 c:RegisterEffect(e1)
 local e2=Effect.CreateEffect(c)
 e2:SetDescription(aux.Stringid(MSG_ID,1))
 e2:SetCategory(CATEGORY_TOHAND+CATEGORY_SEARCH)
 e2:SetType(EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_O)
 e2:SetCode(EVENT_SUMMON_SUCCESS)
 e2:SetProperty(EFFECT_FLAG_DELAY)
 e2:SetCountLimit(1,id+100)
 e2:SetCondition(s.chaincon)
 e2:SetCost(s.searchcost)
 e2:SetTarget(s.searchtg)
 e2:SetOperation(s.searchop)
 c:RegisterEffect(e2)
 local e3=e2:Clone()
 e3:SetCode(EVENT_SPSUMMON_SUCCESS)
 c:RegisterEffect(e3)
 local e4=Effect.CreateEffect(c)
 e4:SetDescription(aux.Stringid(MSG_ID,2))
 e4:SetCategory(CATEGORY_SPECIAL_SUMMON)
 e4:SetType(EFFECT_TYPE_IGNITION)
 e4:SetRange(LOCATION_MZONE)
 e4:SetCountLimit(1,id+200)
 e4:SetCondition(s.chaincon)
 e4:SetCost(s.returncost)
 e4:SetTarget(s.recruittg)
 e4:SetOperation(s.recruitop)
 c:RegisterEffect(e4)
 local e5=Effect.CreateEffect(c)
 e5:SetDescription(aux.Stringid(MSG_ID,3))
 e5:SetCategory(CATEGORY_SPECIAL_SUMMON)
 e5:SetType(EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_O)
 e5:SetCode(EVENT_MOVE)
 e5:SetProperty(EFFECT_FLAG_DELAY)
 e5:SetCountLimit(1,id+300)
 e5:SetCondition(s.materialcon)
 e5:SetCost(s.countercost)
 e5:SetTarget(s.materialtg)
 e5:SetOperation(s.materialop)
 c:RegisterEffect(e5)
 Duel.AddCustomActivityCounter(id,ACTIVITY_SPSUMMON,s.activityfilter)
end
function s.chaincon(e,tp)
 return Duel.GetFlagEffect(tp,id+400)==0
end
function s.markchain(tp)
 Duel.RegisterFlagEffect(tp,id+400,RESET_CHAIN,0,1)
end
function s.returnfilter(c)
 return c:IsAbleToHandAsCost()
end
function s.pcostfilter(c,tp)
 return s.returnfilter(c) and Duel.GetMZoneCount(tp,c)>0
end
function s.pcost(e,tp,eg,ep,ev,re,r,rp,chk)
 if chk==0 then return Duel.IsExistingMatchingCard(s.pcostfilter,tp,LOCATION_ONFIELD,0,1,e:GetHandler(),tp) end
 Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_RTOHAND)
 local g=Duel.SelectMatchingCard(tp,s.pcostfilter,tp,LOCATION_ONFIELD,0,1,1,e:GetHandler(),tp)
 Duel.SendtoHand(g,nil,REASON_COST)
end
function s.ptg(e,tp,eg,ep,ev,re,r,rp,chk)
 if chk==0 then return Duel.IsExistingMatchingCard(s.pcostfilter,tp,LOCATION_ONFIELD,0,1,e:GetHandler(),tp)
  and e:GetHandler():IsCanBeSpecialSummoned(e,0,tp,false,false) end
 Duel.SetOperationInfo(0,CATEGORY_SPECIAL_SUMMON,e:GetHandler(),1,tp,LOCATION_PZONE)
end
function s.pop(e,tp)
 local c=e:GetHandler()
 if c:IsRelateToEffect(e) and c:IsLocation(LOCATION_PZONE) then Duel.SpecialSummon(c,0,tp,tp,false,false,POS_FACEUP) end
end
function s.activityfilter(c)
 return not c:IsSummonLocation(LOCATION_EXTRA) or c:IsPreviousPosition(POS_FACEUP)
  or c:IsType(TYPE_SYNCHRO) and c:IsAttribute(ATTRIBUTE_WIND)
end
function s.searchcost(e,tp,eg,ep,ev,re,r,rp,chk)
 if chk==0 then return s.chaincon(e,tp) and Duel.GetCustomActivityCount(id,tp,ACTIVITY_SPSUMMON)==0 end
 s.markchain(tp)
 local lock=Effect.CreateEffect(e:GetHandler())
 lock:SetType(EFFECT_TYPE_FIELD)
 lock:SetProperty(EFFECT_FLAG_PLAYER_TARGET+EFFECT_FLAG_OATH)
 lock:SetCode(EFFECT_CANNOT_SPECIAL_SUMMON)
 lock:SetTargetRange(1,0)
 lock:SetTarget(function(e,c) return c:IsLocation(LOCATION_EXTRA) and c:IsFacedown()
  and not (c:IsType(TYPE_SYNCHRO) and c:IsAttribute(ATTRIBUTE_WIND)) end)
 lock:SetReset(RESET_PHASE+PHASE_END)
 Duel.RegisterEffect(lock,tp)
end
function s.searchfilter(c)
 return not c:IsCode(id) and c:IsAbleToHand()
  and (c:IsSetCard(SET_SYMPHONIC) and c:IsType(TYPE_MONSTER) or c:IsCode(82735249,75304793,5399521,238273772))
end
function s.searchtg(e,tp,eg,ep,ev,re,r,rp,chk)
 if chk==0 then return Duel.IsExistingMatchingCard(s.searchfilter,tp,LOCATION_DECK,0,1,nil) end
 Duel.SetOperationInfo(0,CATEGORY_TOHAND,nil,1,tp,LOCATION_DECK)
end
function s.searchop(e,tp)
 Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_ATOHAND)
 local g=Duel.SelectMatchingCard(tp,s.searchfilter,tp,LOCATION_DECK,0,1,1,nil)
 if #g>0 then Duel.SendtoHand(g,nil,REASON_EFFECT) Duel.ConfirmCards(1-tp,g) end
end
function s.spfilter(c,e,tp)
 return c:IsSetCard(SET_SYMPHONIC) and c:IsType(TYPE_MONSTER)
  and (not c:IsLocation(LOCATION_EXTRA) or c:IsFaceup())
  and c:IsCanBeSpecialSummoned(e,0,tp,false,false)
  and (c:IsLocation(LOCATION_EXTRA) and Duel.GetLocationCountFromEx(tp,tp,nil,c)>0
   or not c:IsLocation(LOCATION_EXTRA) and Duel.GetLocationCount(tp,LOCATION_MZONE)>0)
end
function s.returncost(e,tp,eg,ep,ev,re,r,rp,chk)
 local c=e:GetHandler()
 if chk==0 then return s.chaincon(e,tp) and c:IsAbleToHandAsCost() end
 s.markchain(tp)
 Duel.SendtoHand(c,nil,REASON_COST)
end
function s.recruittg(e,tp,eg,ep,ev,re,r,rp,chk)
 if chk==0 then
  local c=e:GetHandler()
  --Returning this monster frees a main zone; the returned card can be chosen from hand.
  return Duel.GetMZoneCount(tp,c)>0 and (not c:IsForbidden()
   and Duel.IsPlayerCanSpecialSummonMonster(tp,id,SET_SYMPHONIC,TYPE_MONSTER+TYPE_EFFECT+TYPE_TUNER+TYPE_PENDULUM,300,200,1,RACE_MACHINE,ATTRIBUTE_WIND)
   or Duel.IsExistingMatchingCard(s.precruitfilter,tp,LOCATION_HAND+LOCATION_GRAVE+LOCATION_EXTRA,0,1,nil,e,tp,c))
 end
 Duel.SetOperationInfo(0,CATEGORY_SPECIAL_SUMMON,nil,1,tp,LOCATION_HAND+LOCATION_GRAVE+LOCATION_EXTRA)
end
function s.precruitfilter(c,e,tp,released)
 return c:IsSetCard(SET_SYMPHONIC) and c:IsType(TYPE_MONSTER)
  and (not c:IsLocation(LOCATION_EXTRA) or c:IsFaceup())
  and c:IsCanBeSpecialSummoned(e,0,tp,false,false)
  and (c:IsLocation(LOCATION_EXTRA) and Duel.GetLocationCountFromEx(tp,tp,released,c)>0
   or not c:IsLocation(LOCATION_EXTRA) and Duel.GetMZoneCount(tp,released)>0)
end
function s.recruitop(e,tp)
 Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_SPSUMMON)
 local tc=Duel.SelectMatchingCard(tp,s.spfilter,tp,LOCATION_HAND+LOCATION_GRAVE+LOCATION_EXTRA,0,1,1,nil,e,tp):GetFirst()
 if tc then Duel.SpecialSummon(tc,0,tp,tp,false,false,POS_FACEUP) end
end
function s.materialcon(e,tp)
 local c=e:GetHandler()
 return s.chaincon(e,tp) and c:IsLocation(LOCATION_EXTRA) and c:IsFaceup()
  and c:IsPreviousLocation(LOCATION_MZONE) and c:IsReason(REASON_MATERIAL) and c:IsReason(REASON_SYNCHRO)
end
function s.countercost(e,tp,eg,ep,ev,re,r,rp,chk)
 if chk==0 then return s.chaincon(e,tp) and Duel.IsCanRemoveCounter(tp,1,1,COUNTER_SYMPHONIC,3,REASON_COST) end
 s.markchain(tp)
 Duel.RemoveCounter(tp,1,1,COUNTER_SYMPHONIC,3,REASON_COST)
end
function s.materialtg(e,tp,eg,ep,ev,re,r,rp,chk)
 if chk==0 then return Duel.IsExistingMatchingCard(s.spfilter,tp,LOCATION_HAND+LOCATION_GRAVE,0,1,nil,e,tp) end
 Duel.SetOperationInfo(0,CATEGORY_SPECIAL_SUMMON,nil,1,tp,LOCATION_HAND+LOCATION_GRAVE)
end
function s.materialop(e,tp)
 Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_SPSUMMON)
 local tc=Duel.SelectMatchingCard(tp,s.spfilter,tp,LOCATION_HAND+LOCATION_GRAVE,0,1,1,nil,e,tp):GetFirst()
 if tc then Duel.SpecialSummon(tc,0,tp,tp,false,false,POS_FACEUP) end
end

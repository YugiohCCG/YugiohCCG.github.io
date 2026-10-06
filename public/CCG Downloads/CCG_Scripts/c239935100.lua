--Perseverance of the Hydra's Heart
local s,id=GetID()
local SWAMP=239935101
local MSG_ID=133935100
function s.initial_effect(c)
 aux.AddCodeList(c,SWAMP)
 Duel.AddCustomActivityCounter(id,ACTIVITY_SPSUMMON,s.waterreptile)
 local e1=Effect.CreateEffect(c)
 e1:SetDescription(aux.Stringid(MSG_ID,0))
 e1:SetCategory(CATEGORY_SPECIAL_SUMMON+CATEGORY_DESTROY)
 e1:SetType(EFFECT_TYPE_ACTIVATE)
 e1:SetCode(EVENT_FREE_CHAIN)
 e1:SetCountLimit(1,id+EFFECT_COUNT_CODE_OATH)
 e1:SetCost(s.cost)
 e1:SetTarget(s.target)
 e1:SetOperation(s.operation)
 c:RegisterEffect(e1)
 local e2=Effect.CreateEffect(c)
 e2:SetDescription(aux.Stringid(MSG_ID,3))
 e2:SetType(EFFECT_TYPE_FIELD+EFFECT_TYPE_CONTINUOUS)
 e2:SetCode(EFFECT_SEND_REPLACE)
 e2:SetRange(LOCATION_GRAVE)
 e2:SetCondition(s.repcon)
 e2:SetTarget(s.reptg)
 e2:SetValue(s.repval)
 e2:SetOperation(s.repop)
 c:RegisterEffect(e2)
end
s.listed_names={SWAMP}
s.listed_series={0xa123}
function s.waterreptile(c)
 return c:IsAttribute(ATTRIBUTE_WATER) and c:IsRace(RACE_REPTILE)
end
function s.cost(e,tp,eg,ep,ev,re,r,rp,chk)
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
function s.destroyfilter(c)
 return c:IsFaceup() and (c:GetOriginalType()&TYPE_MONSTER)~=0 and s.waterreptile(c) and c:IsDestructable()
end
function s.takefilter(c,e,tp)
 return c:IsType(TYPE_MONSTER) and s.waterreptile(c)
  and (not c:IsLocation(LOCATION_REMOVED) or c:IsFaceup())
  and ((Duel.GetLocationCount(tp,LOCATION_MZONE)>0 and c:IsCanBeSpecialSummoned(e,0,tp,false,false))
   or (Duel.GetLocationCount(tp,LOCATION_SZONE)>0 and not c:IsForbidden()))
end
function s.target(e,tp,eg,ep,ev,re,r,rp,chk)
 if chk==0 then return Duel.IsExistingMatchingCard(aux.NecroValleyFilter(s.takefilter),tp,LOCATION_GRAVE+LOCATION_REMOVED,0,1,nil,e,tp) end
 Duel.SetOperationInfo(0,CATEGORY_SPECIAL_SUMMON,nil,1,tp,LOCATION_GRAVE+LOCATION_REMOVED)
 Duel.SetOperationInfo(0,CATEGORY_DESTROY,nil,1,tp,LOCATION_ONFIELD)
end
function s.operation(e,tp)
 Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_SELECT)
 local g=Duel.SelectMatchingCard(tp,aux.NecroValleyFilter(s.takefilter),tp,LOCATION_GRAVE+LOCATION_REMOVED,0,1,1,nil,e,tp)
 local tc=g:GetFirst()
 if not tc then return end
 local summon=Duel.GetLocationCount(tp,LOCATION_MZONE)>0 and tc:IsCanBeSpecialSummoned(e,0,tp,false,false)
 local place=Duel.GetLocationCount(tp,LOCATION_SZONE)>0 and not tc:IsForbidden()
 local option=0
 if summon and place then option=Duel.SelectOption(tp,aux.Stringid(MSG_ID,1),aux.Stringid(MSG_ID,2)) elseif place then option=1 end
 local success=false
 if option==0 then success=Duel.SpecialSummon(tc,0,tp,tp,false,false,POS_FACEUP)>0
 elseif Duel.MoveToField(tc,tp,tp,LOCATION_SZONE,POS_FACEUP,true) then
  local change=Effect.CreateEffect(e:GetHandler())
  change:SetType(EFFECT_TYPE_SINGLE)
  change:SetCode(EFFECT_CHANGE_TYPE)
  change:SetProperty(EFFECT_FLAG_CANNOT_DISABLE)
  change:SetValue(TYPE_SPELL+TYPE_CONTINUOUS)
  change:SetReset(RESET_EVENT+RESETS_STANDARD-RESET_TURN_SET)
  tc:RegisterEffect(change)
  success=true
 end
 if not success then return end
 Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_DESTROY)
 local dg=Duel.SelectMatchingCard(tp,s.destroyfilter,tp,LOCATION_ONFIELD,0,1,1,nil)
 if #dg>0 then Duel.Destroy(dg,REASON_EFFECT) end
end
function s.repcon(e)
 return Duel.IsExistingMatchingCard(function(c) return c:IsFaceup() and c:IsCode(SWAMP) end,e:GetHandlerPlayer(),LOCATION_ONFIELD,0,1,nil)
end
function s.repfilter(c,tp)
 return c:IsControler(tp) and c:IsLocation(LOCATION_ONFIELD) and c:IsFaceup() and (c:GetOriginalType()&TYPE_MONSTER)~=0 and s.waterreptile(c)
  and c:GetDestination()==LOCATION_REMOVED and c:IsReason(REASON_EFFECT) and not c:IsReason(REASON_REPLACE)
end
function s.reptg(e,tp,eg,ep,ev,re,r,rp,chk)
 if chk==0 then return e:GetHandler():IsAbleToRemove() and eg:IsExists(s.repfilter,1,nil,tp) end
 return Duel.SelectEffectYesNo(tp,e:GetHandler(),aux.Stringid(MSG_ID,3))
end
function s.repval(e,c)
 return s.repfilter(c,e:GetHandlerPlayer())
end
function s.repop(e)
 Duel.Remove(e:GetHandler(),POS_FACEUP,REASON_EFFECT+REASON_REPLACE)
end

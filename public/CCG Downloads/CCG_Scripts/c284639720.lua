--Terrarumian Nerve Plant
--Omega references: c248760718 (Pendulum effects), c17775525 (Defense Position attack).
local s,id=GetID()
local SET_TERRARUMIAN=0xA122
local MSG_ID=132639720
function s.initial_effect(c)
 aux.EnablePendulumAttribute(c)
 local e1=Effect.CreateEffect(c)
 e1:SetType(EFFECT_TYPE_FIELD)
 e1:SetCode(EFFECT_UPDATE_DEFENSE)
 e1:SetRange(LOCATION_PZONE)
 e1:SetTargetRange(LOCATION_MZONE,0)
 e1:SetTarget(s.deftg)
 e1:SetValue(s.defval)
 c:RegisterEffect(e1)
 local e2=Effect.CreateEffect(c)
 e2:SetDescription(aux.Stringid(MSG_ID,0))
 e2:SetCategory(CATEGORY_DESTROY+CATEGORY_SPECIAL_SUMMON)
 e2:SetType(EFFECT_TYPE_IGNITION)
 e2:SetRange(LOCATION_PZONE)
 e2:SetCountLimit(1,id)
 e2:SetCondition(s.pcon)
 e2:SetTarget(s.ptg)
 e2:SetOperation(s.pop)
 c:RegisterEffect(e2)
 local e3=Effect.CreateEffect(c)
 e3:SetDescription(aux.Stringid(MSG_ID,1))
 e3:SetCategory(CATEGORY_DESTROY)
 e3:SetType(EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_O)
 e3:SetProperty(EFFECT_FLAG_DELAY)
 e3:SetCode(EVENT_SUMMON_SUCCESS)
 e3:SetCountLimit(1,id+100)
 e3:SetTarget(s.destg)
 e3:SetOperation(s.desop)
 c:RegisterEffect(e3)
 local e4=e3:Clone()
 e4:SetCode(EVENT_SPSUMMON_SUCCESS)
 c:RegisterEffect(e4)
 local e5=e3:Clone()
 e5:SetCode(EVENT_DESTROYED)
 e5:SetCondition(s.descon)
 c:RegisterEffect(e5)
 local e6=Effect.CreateEffect(c)
 e6:SetType(EFFECT_TYPE_SINGLE)
 e6:SetCode(EFFECT_DEFENSE_ATTACK)
 e6:SetValue(0)
 c:RegisterEffect(e6)
end
function s.deftg(e,c)
 return c:IsFaceup() and c:IsSetCard(SET_TERRARUMIAN) and c:IsType(TYPE_PENDULUM)
end
function s.countfilter(c)
 return c:IsSetCard(SET_TERRARUMIAN)
end
function s.defval(e,c)
 return 300*Duel.GetMatchingGroupCount(s.countfilter,e:GetHandlerPlayer(),LOCATION_MZONE,LOCATION_MZONE,nil)
end
function s.ownmonster(c)
 return c:IsSetCard(SET_TERRARUMIAN)
end
function s.pcon(e,tp)
 return Duel.IsExistingMatchingCard(s.ownmonster,tp,LOCATION_MZONE,0,1,nil)
end
function s.destroyfilter(c,handler)
 return c~=handler and c:IsSetCard(SET_TERRARUMIAN) and c:IsDestructable()
end
function s.zonefilter(c,handler)
 return c:IsLocation(LOCATION_MZONE) and s.destroyfilter(c,handler)
end
function s.ptg(e,tp,eg,ep,ev,re,r,rp,chk)
 local c=e:GetHandler()
 if chk==0 then return (Duel.GetLocationCount(tp,LOCATION_MZONE)>0
   or Duel.IsExistingMatchingCard(s.zonefilter,tp,LOCATION_MZONE,0,1,c,c))
  and c:IsCanBeSpecialSummoned(e,0,tp,false,false)
  and Duel.IsExistingMatchingCard(s.destroyfilter,tp,LOCATION_ONFIELD,0,1,c,c) end
 Duel.SetOperationInfo(0,CATEGORY_DESTROY,nil,1,tp,LOCATION_ONFIELD)
 Duel.SetOperationInfo(0,CATEGORY_SPECIAL_SUMMON,c,1,tp,LOCATION_PZONE)
end
function s.setfilter(c)
 return c:IsSetCard(SET_TERRARUMIAN) and c:IsType(TYPE_SPELL+TYPE_TRAP)
  and c:IsSSetable()
end
function s.pop(e,tp)
 local c=e:GetHandler()
 if not c:IsRelateToEffect(e)
  or not Duel.IsExistingMatchingCard(s.destroyfilter,tp,LOCATION_ONFIELD,0,1,c,c) then return end
 Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_DESTROY)
 local g=Duel.SelectMatchingCard(tp,s.destroyfilter,tp,LOCATION_ONFIELD,0,1,1,c,c)
 if #g==0 or Duel.Destroy(g,REASON_EFFECT)==0 then return end
 if not c:IsRelateToEffect(e) or Duel.GetLocationCount(tp,LOCATION_MZONE)<=0
  or Duel.SpecialSummon(c,0,tp,tp,false,false,POS_FACEUP)==0 then return end
 if Duel.GetLocationCount(tp,LOCATION_SZONE)<=0
  or not Duel.IsExistingMatchingCard(aux.NecroValleyFilter(s.setfilter),tp,LOCATION_GRAVE,0,1,nil)
  or not Duel.SelectYesNo(tp,aux.Stringid(MSG_ID,2)) then return end
 Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_SET)
 local sg=Duel.SelectMatchingCard(tp,aux.NecroValleyFilter(s.setfilter),tp,LOCATION_GRAVE,0,1,1,nil)
 local sc=sg:GetFirst()
 if sc then Duel.SSet(tp,sc) end
end
function s.descon(e)
 return e:GetHandler():IsReason(REASON_EFFECT)
end
function s.desfilter(c)
 return c:IsType(TYPE_SPELL+TYPE_TRAP) and c:IsDestructable()
end
function s.destg(e,tp,eg,ep,ev,re,r,rp,chk)
 if chk==0 then return Duel.IsExistingMatchingCard(s.desfilter,tp,LOCATION_ONFIELD,LOCATION_ONFIELD,1,nil) end
 Duel.SetOperationInfo(0,CATEGORY_DESTROY,nil,1,0,LOCATION_ONFIELD)
end
function s.desop(e,tp)
 if not Duel.IsExistingMatchingCard(s.desfilter,tp,LOCATION_ONFIELD,LOCATION_ONFIELD,1,nil) then return end
 Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_DESTROY)
 local g=Duel.SelectMatchingCard(tp,s.desfilter,tp,LOCATION_ONFIELD,LOCATION_ONFIELD,1,1,nil)
 if #g>0 then Duel.Destroy(g,REASON_EFFECT) end
end

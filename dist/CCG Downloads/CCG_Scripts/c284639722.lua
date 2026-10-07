--Terrarumian Ivy
--Omega references: c215853847 (battle activation lock), c223750159 (Summon with effects negated).
local s,id=GetID()
local SET_TERRARUMIAN=0xA122
local MSG_ID=132639722
function s.initial_effect(c)
 aux.EnablePendulumAttribute(c)
 local e1=Effect.CreateEffect(c)
 e1:SetType(EFFECT_TYPE_FIELD)
 e1:SetProperty(EFFECT_FLAG_PLAYER_TARGET)
 e1:SetCode(EFFECT_CANNOT_ACTIVATE)
 e1:SetRange(LOCATION_PZONE)
 e1:SetTargetRange(0,1)
 e1:SetCondition(s.actcon)
 e1:SetValue(s.aclimit)
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
 e3:SetType(EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_O)
 e3:SetProperty(EFFECT_FLAG_DELAY+EFFECT_FLAG_CARD_TARGET)
 e3:SetCode(EVENT_DESTROYED)
 e3:SetCountLimit(1,id+100)
 e3:SetCondition(s.descon)
 e3:SetTarget(s.destg)
 e3:SetOperation(s.desop)
 c:RegisterEffect(e3)
 local e4=Effect.CreateEffect(c)
 e4:SetType(EFFECT_TYPE_SINGLE)
 e4:SetCode(EFFECT_DEFENSE_ATTACK)
 e4:SetValue(0)
 c:RegisterEffect(e4)
end
function s.battlefilter(c,tp)
 return c and c:IsControler(tp) and c:IsSetCard(SET_TERRARUMIAN)
end
function s.actcon(e,tp)
 local p=e:GetHandlerPlayer()
 return s.battlefilter(Duel.GetAttacker(),p)
  or s.battlefilter(Duel.GetAttackTarget(),p)
end
function s.aclimit(e,re,tp)
 return true
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
function s.gyfilter(c,e,tp)
 return c:IsSetCard(SET_TERRARUMIAN) and c:IsType(TYPE_PENDULUM)
  and not c:IsCode(id) and c:IsCanBeSpecialSummoned(e,0,tp,false,false)
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
 if Duel.GetLocationCount(tp,LOCATION_MZONE)<=0
  or not Duel.IsExistingMatchingCard(aux.NecroValleyFilter(s.gyfilter),tp,LOCATION_GRAVE,0,1,nil,e,tp)
  or not Duel.SelectYesNo(tp,aux.Stringid(MSG_ID,2)) then return end
 Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_SPSUMMON)
 local sg=Duel.SelectMatchingCard(tp,aux.NecroValleyFilter(s.gyfilter),tp,LOCATION_GRAVE,0,1,1,nil,e,tp)
 local sc=sg:GetFirst()
 if sc then Duel.SpecialSummon(sc,0,tp,tp,false,false,POS_FACEUP) end
end
function s.descon(e)
 return e:GetHandler():IsReason(REASON_EFFECT)
end
function s.revivefilter(c,e,tp)
 return c:IsSetCard(SET_TERRARUMIAN) and c:IsType(TYPE_MONSTER)
  and not c:IsCode(id) and c:IsCanBeSpecialSummoned(e,0,tp,false,false)
end
function s.oppfilter(c)
 return c:IsFaceup() and c:IsSummonType(SUMMON_TYPE_SPECIAL)
end
function s.destg(e,tp,eg,ep,ev,re,r,rp,chk)
 local ownok=Duel.GetLocationCount(tp,LOCATION_MZONE)>0
  and Duel.IsExistingTarget(aux.NecroValleyFilter(s.revivefilter),tp,LOCATION_GRAVE,0,1,nil,e,tp)
 local oppok=Duel.IsExistingTarget(s.oppfilter,tp,0,LOCATION_MZONE,1,nil)
 if chk==0 then return ownok or oppok end
 local option
 if ownok and oppok then option=Duel.SelectOption(tp,aux.Stringid(MSG_ID,3),aux.Stringid(MSG_ID,4))
 elseif ownok then option=0 else option=1 end
 e:SetLabel(option)
 Duel.Hint(HINT_SELECTMSG,tp,option==0 and HINTMSG_SPSUMMON or HINTMSG_FACEUP)
 if option==0 then
  Duel.SelectTarget(tp,aux.NecroValleyFilter(s.revivefilter),tp,LOCATION_GRAVE,0,1,1,nil,e,tp)
  Duel.SetOperationInfo(0,CATEGORY_SPECIAL_SUMMON,nil,1,tp,LOCATION_GRAVE)
 else
  Duel.SelectTarget(tp,s.oppfilter,tp,0,LOCATION_MZONE,1,1,nil)
  Duel.SetOperationInfo(0,CATEGORY_DISABLE,nil,1,1-tp,LOCATION_MZONE)
 end
end
function s.negate(c,source)
 local disable=Effect.CreateEffect(source)
 disable:SetType(EFFECT_TYPE_SINGLE)
 disable:SetProperty(EFFECT_FLAG_CANNOT_DISABLE)
 disable:SetCode(EFFECT_DISABLE)
 disable:SetReset(RESET_EVENT+RESETS_STANDARD)
 c:RegisterEffect(disable)
 local disable_effect=disable:Clone()
 disable_effect:SetCode(EFFECT_DISABLE_EFFECT)
 disable_effect:SetValue(RESET_TURN_SET)
 c:RegisterEffect(disable_effect)
end
function s.desop(e,tp)
 local tc=Duel.GetFirstTarget()
 if not tc or not tc:IsRelateToEffect(e) then return end
 if e:GetLabel()==0 then
  if Duel.GetLocationCount(tp,LOCATION_MZONE)<=0 or not s.revivefilter(tc,e,tp) then return end
  if Duel.SpecialSummonStep(tc,0,tp,tp,false,false,POS_FACEUP) then
   s.negate(tc,e:GetHandler())
  end
  Duel.SpecialSummonComplete()
 else
  if not tc:IsFaceup() or not s.oppfilter(tc) then return end
  Duel.NegateRelatedChain(tc,RESET_TURN_SET)
  s.negate(tc,e:GetHandler())
 end
end

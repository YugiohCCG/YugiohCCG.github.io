--Terrarumian Trumpet Pitchers
--Omega references: c221855414 (field targeting protection), c248760718 (Pendulum effects).
local s,id=GetID()
local SET_TERRARUMIAN=0xA122
local MSG_ID=132639724
function s.initial_effect(c)
 aux.EnablePendulumAttribute(c)
 local e1=Effect.CreateEffect(c)
 e1:SetType(EFFECT_TYPE_FIELD)
 e1:SetCode(EFFECT_CANNOT_BE_EFFECT_TARGET)
 e1:SetRange(LOCATION_PZONE)
 e1:SetTargetRange(LOCATION_MZONE,0)
 e1:SetTarget(s.tgtg)
 e1:SetValue(aux.tgoval)
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
 e3:SetCategory(CATEGORY_SPECIAL_SUMMON)
 e3:SetType(EFFECT_TYPE_FIELD+EFFECT_TYPE_TRIGGER_O)
 e3:SetProperty(EFFECT_FLAG_DELAY)
 e3:SetCode(EVENT_DESTROYED)
 e3:SetRange(LOCATION_HAND)
 e3:SetCondition(s.spcon)
 e3:SetTarget(s.sptg)
 e3:SetOperation(s.spop)
 c:RegisterEffect(e3)
 local e4=Effect.CreateEffect(c)
 e4:SetDescription(aux.Stringid(MSG_ID,2))
 e4:SetCategory(CATEGORY_DESTROY+CATEGORY_RECOVER)
 e4:SetType(EFFECT_TYPE_FIELD+EFFECT_TYPE_TRIGGER_O)
 e4:SetProperty(EFFECT_FLAG_DELAY)
 e4:SetCode(EVENT_BATTLE_DAMAGE)
 e4:SetRange(LOCATION_MZONE)
 e4:SetCountLimit(1,id+100)
 e4:SetCondition(s.damcon)
 e4:SetTarget(s.destg)
 e4:SetOperation(s.desop)
 c:RegisterEffect(e4)
 local e5=e4:Clone()
 e5:SetCode(EVENT_CHAINING)
 e5:SetCondition(s.chaincon)
 c:RegisterEffect(e5)
 local e6=Effect.CreateEffect(c)
 e6:SetType(EFFECT_TYPE_SINGLE)
 e6:SetCode(EFFECT_DEFENSE_ATTACK)
 e6:SetValue(0)
 c:RegisterEffect(e6)
end
function s.tgtg(e,c)
 return c:IsFaceup() and c:IsSetCard(SET_TERRARUMIAN)
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
  and c:IsCanBeSpecialSummoned(e,0,tp,false,false,POS_FACEUP_DEFENSE)
  and Duel.IsExistingMatchingCard(s.destroyfilter,tp,LOCATION_ONFIELD,0,1,c,c) end
 Duel.SetOperationInfo(0,CATEGORY_DESTROY,nil,1,tp,LOCATION_ONFIELD)
 Duel.SetOperationInfo(0,CATEGORY_SPECIAL_SUMMON,c,1,tp,LOCATION_PZONE)
end
function s.exfilter(c,e,tp)
 return c:IsFaceup() and c:IsSetCard(SET_TERRARUMIAN) and c:IsType(TYPE_PENDULUM)
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
  or Duel.SpecialSummon(c,0,tp,tp,false,false,POS_FACEUP_DEFENSE)==0 then return end
 if Duel.GetLocationCountFromEx(tp)<=0
  or not Duel.IsExistingMatchingCard(s.exfilter,tp,LOCATION_EXTRA,0,1,nil,e,tp)
  or not Duel.SelectYesNo(tp,aux.Stringid(MSG_ID,3)) then return end
 Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_SPSUMMON)
 local sg=Duel.SelectMatchingCard(tp,s.exfilter,tp,LOCATION_EXTRA,0,1,1,nil,e,tp)
 local sc=sg:GetFirst()
 if sc then Duel.SpecialSummon(sc,0,tp,tp,false,false,POS_FACEUP) end
end
function s.spcheck(c,tp)
 return c:IsSetCard(SET_TERRARUMIAN) and c:IsType(TYPE_PENDULUM)
  and c:IsPreviousControler(tp)
end
function s.spcon(e,tp,eg)
 return eg:IsExists(s.spcheck,1,nil,tp)
end
function s.sptg(e,tp,eg,ep,ev,re,r,rp,chk)
 local c=e:GetHandler()
 if chk==0 then return Duel.GetLocationCount(tp,LOCATION_MZONE)>0
  and c:IsCanBeSpecialSummoned(e,0,tp,false,false) end
 Duel.SetOperationInfo(0,CATEGORY_SPECIAL_SUMMON,c,1,tp,LOCATION_HAND)
end
function s.spop(e,tp)
 local c=e:GetHandler()
 if c:IsRelateToEffect(e) and Duel.GetLocationCount(tp,LOCATION_MZONE)>0 then
  Duel.SpecialSummon(c,0,tp,tp,false,false,POS_FACEUP)
 end
end
function s.damcon(e,tp,eg,ep)
 local a=Duel.GetAttacker()
 return ep==1-tp and a and a:IsControler(tp) and a:IsSetCard(SET_TERRARUMIAN)
  and a:IsType(TYPE_PENDULUM) and Duel.GetAttackTarget()==nil
end
function s.chaincon(e,tp,eg,ep,ev,re,r,rp)
 return rp==1-tp and Duel.IsBattlePhase()
end
function s.desfilter(c)
 return c:IsType(TYPE_MONSTER) and c:IsDestructable()
end
function s.destg(e,tp,eg,ep,ev,re,r,rp,chk)
 if chk==0 then return Duel.IsExistingMatchingCard(s.desfilter,tp,0,LOCATION_MZONE,1,nil) end
 Duel.SetOperationInfo(0,CATEGORY_DESTROY,nil,1,1-tp,LOCATION_MZONE)
end
function s.desop(e,tp)
 if not Duel.IsExistingMatchingCard(s.desfilter,tp,0,LOCATION_MZONE,1,nil) then return end
 Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_DESTROY)
 local g=Duel.SelectMatchingCard(tp,s.desfilter,tp,0,LOCATION_MZONE,1,1,nil)
 local tc=g:GetFirst()
 if not tc then return end
 local value=math.max(0,tc:GetBaseDefense())
 if Duel.Destroy(g,REASON_EFFECT)>0 then Duel.Recover(tp,value,REASON_EFFECT) end
end

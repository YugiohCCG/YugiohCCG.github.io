--Terrarumian Sword Fern
--Omega references: c215034223 (destruction/send replacement), c248760718 (Pendulum effects).
local s,id=GetID()
local SET_TERRARUMIAN=0xA122
local MSG_ID=132639719
function s.initial_effect(c)
 aux.EnablePendulumAttribute(c)
 local e1=Effect.CreateEffect(c)
 e1:SetType(EFFECT_TYPE_FIELD+EFFECT_TYPE_CONTINUOUS)
 e1:SetCode(EFFECT_DESTROY_REPLACE)
 e1:SetRange(LOCATION_PZONE)
 e1:SetTarget(s.reptg)
 e1:SetValue(s.repval)
 e1:SetOperation(s.repop)
 c:RegisterEffect(e1)
 local e2=e1:Clone()
 e2:SetCode(EFFECT_SEND_REPLACE)
 e2:SetTarget(s.bantg)
 e2:SetValue(s.repval)
 c:RegisterEffect(e2)
 local e3=Effect.CreateEffect(c)
 e3:SetDescription(aux.Stringid(MSG_ID,0))
 e3:SetCategory(CATEGORY_DESTROY+CATEGORY_SPECIAL_SUMMON)
 e3:SetType(EFFECT_TYPE_IGNITION)
 e3:SetRange(LOCATION_PZONE)
 e3:SetCountLimit(1,id)
 e3:SetCondition(s.pcon)
 e3:SetTarget(s.ptg)
 e3:SetOperation(s.pop)
 c:RegisterEffect(e3)
 local e4=Effect.CreateEffect(c)
 e4:SetDescription(aux.Stringid(MSG_ID,1))
 e4:SetCategory(CATEGORY_SEARCH)
 e4:SetType(EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_O)
 e4:SetProperty(EFFECT_FLAG_DELAY)
 e4:SetCode(EVENT_SUMMON_SUCCESS)
 e4:SetCountLimit(1,id+100)
 e4:SetTarget(s.sttg)
 e4:SetOperation(s.stop)
 c:RegisterEffect(e4)
 local e5=e4:Clone()
 e5:SetCode(EVENT_SPSUMMON_SUCCESS)
 c:RegisterEffect(e5)
 local e6=e4:Clone()
 e6:SetCode(EVENT_DESTROYED)
 e6:SetCondition(s.descon)
 c:RegisterEffect(e6)
 local e7=Effect.CreateEffect(c)
 e7:SetType(EFFECT_TYPE_SINGLE)
 e7:SetCode(EFFECT_DEFENSE_ATTACK)
 e7:SetValue(0)
 c:RegisterEffect(e7)
end
function s.repfilter(c,tp)
 return c:IsControler(tp) and c==Duel.GetFieldCard(tp,LOCATION_FZONE,0) and c:IsReason(REASON_EFFECT)
  and c:GetReasonPlayer()==1-tp and not c:IsReason(REASON_REPLACE)
end
function s.reptg(e,tp,eg,ep,ev,re,r,rp,chk)
 local c=e:GetHandler()
 if chk==0 then return c:IsDestructable(e) and not c:IsStatus(STATUS_DESTROY_CONFIRMED)
  and eg:IsExists(s.repfilter,1,nil,tp) end
 return Duel.SelectEffectYesNo(tp,c,96)
end
function s.banfilter(c,tp)
 return s.repfilter(c,tp) and c:GetDestination()==LOCATION_REMOVED
end
function s.bantg(e,tp,eg,ep,ev,re,r,rp,chk)
 local c=e:GetHandler()
 if chk==0 then return c:IsDestructable(e) and not c:IsStatus(STATUS_DESTROY_CONFIRMED)
  and eg:IsExists(s.banfilter,1,nil,tp) end
 return Duel.SelectEffectYesNo(tp,c,96)
end
function s.repval(e,c)
 if e:GetCode()==EFFECT_SEND_REPLACE then
  return s.banfilter(c,e:GetHandlerPlayer())
 end
 return s.repfilter(c,e:GetHandlerPlayer())
end
function s.repop(e,tp)
 Duel.Destroy(e:GetHandler(),REASON_EFFECT+REASON_REPLACE)
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
function s.deckfilter(c)
 return c:IsSetCard(SET_TERRARUMIAN) and c:IsType(TYPE_MONSTER)
  and c:IsType(TYPE_PENDULUM) and not c:IsCode(id) and not c:IsForbidden()
end
function s.zonefilter(c,handler)
 return c:IsLocation(LOCATION_MZONE) and s.destroyfilter(c,handler)
end
function s.ptg(e,tp,eg,ep,ev,re,r,rp,chk)
 local c=e:GetHandler()
 if chk==0 then return (Duel.GetLocationCount(tp,LOCATION_MZONE)>0
   or Duel.IsExistingMatchingCard(s.zonefilter,tp,LOCATION_MZONE,0,1,c,c))
  and c:IsCanBeSpecialSummoned(e,0,tp,false,false)
  and Duel.IsExistingMatchingCard(s.destroyfilter,tp,LOCATION_ONFIELD,0,1,c,c)
  and (Duel.CheckLocation(tp,LOCATION_PZONE,0) or Duel.CheckLocation(tp,LOCATION_PZONE,1)
   or c:IsLocation(LOCATION_PZONE))
  and Duel.IsExistingMatchingCard(s.deckfilter,tp,LOCATION_DECK,0,1,nil) end
 Duel.SetOperationInfo(0,CATEGORY_DESTROY,nil,1,tp,LOCATION_ONFIELD)
 Duel.SetOperationInfo(0,CATEGORY_SPECIAL_SUMMON,c,1,tp,LOCATION_PZONE)
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
 if not (Duel.CheckLocation(tp,LOCATION_PZONE,0) or Duel.CheckLocation(tp,LOCATION_PZONE,1)) then return end
 Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_TOFIELD)
 local pg=Duel.SelectMatchingCard(tp,s.deckfilter,tp,LOCATION_DECK,0,1,1,nil)
 local pc=pg:GetFirst()
 if pc then Duel.MoveToField(pc,tp,tp,LOCATION_PZONE,POS_FACEUP,true) end
end
function s.descon(e)
 return e:GetHandler():IsReason(REASON_EFFECT)
end
function s.stfilter(c)
 return c:IsSetCard(SET_TERRARUMIAN) and c:IsType(TYPE_SPELL+TYPE_TRAP)
  and c:IsSSetable()
end
function s.sttg(e,tp,eg,ep,ev,re,r,rp,chk)
 if chk==0 then return Duel.GetLocationCount(tp,LOCATION_SZONE)>0
  and Duel.IsExistingMatchingCard(s.stfilter,tp,LOCATION_DECK,0,1,nil) end
 Duel.SetOperationInfo(0,CATEGORY_SEARCH,nil,1,tp,LOCATION_DECK)
end
function s.stop(e,tp)
 if Duel.GetLocationCount(tp,LOCATION_SZONE)<=0
  or not Duel.IsExistingMatchingCard(s.stfilter,tp,LOCATION_DECK,0,1,nil) then return end
 Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_SET)
 local g=Duel.SelectMatchingCard(tp,s.stfilter,tp,LOCATION_DECK,0,1,1,nil)
 local tc=g:GetFirst()
 if tc then Duel.SSet(tp,tc) end
end

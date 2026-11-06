--Terrarumian Growth
--Omega references: c215034223 (place a Pendulum monster from Deck),
-- c225358630 (Set a Spell/Trap from the GY).
local s,id=GetID()
local SET_TERRARUMIAN=0xA122
local MSG_ID=132636589
function s.initial_effect(c)
 local e1=Effect.CreateEffect(c)
 e1:SetDescription(aux.Stringid(MSG_ID,0))
 e1:SetCategory(CATEGORY_DESTROY)
 e1:SetType(EFFECT_TYPE_ACTIVATE)
 e1:SetCode(EVENT_FREE_CHAIN)
 e1:SetCountLimit(1,id+EFFECT_COUNT_CODE_OATH)
 e1:SetCondition(s.maincon)
 e1:SetTarget(s.placetg)
 e1:SetOperation(s.placeop)
 c:RegisterEffect(e1)
 local e2=Effect.CreateEffect(c)
 e2:SetDescription(aux.Stringid(MSG_ID,1))
 e2:SetCategory(CATEGORY_REMOVE+CATEGORY_SSET)
 e2:SetType(EFFECT_TYPE_IGNITION)
 e2:SetProperty(EFFECT_FLAG_CARD_TARGET)
 e2:SetRange(LOCATION_GRAVE)
 e2:SetCountLimit(1,id+EFFECT_COUNT_CODE_OATH)
 e2:SetCost(s.setcost)
 e2:SetTarget(s.settg)
 e2:SetOperation(s.setop)
 c:RegisterEffect(e2)
end
function s.maincon(e,tp)
 local ph=Duel.GetCurrentPhase()
 return ph==PHASE_MAIN1 or ph==PHASE_MAIN2
end
function s.destroyfilter(c)
 return c:IsSetCard(SET_TERRARUMIAN) and not c:IsCode(id) and c:IsDestructable()
end
function s.pendulumfilter(c)
 return c:IsSetCard(SET_TERRARUMIAN) and c:IsType(TYPE_MONSTER)
  and c:IsType(TYPE_PENDULUM)
  and not c:IsForbidden()
end
function s.haszone(tp)
 return Duel.CheckLocation(tp,LOCATION_PZONE,0) or Duel.CheckLocation(tp,LOCATION_PZONE,1)
end
function s.placetg(e,tp,eg,ep,ev,re,r,rp,chk)
 if chk==0 then return s.haszone(tp)
  and Duel.IsExistingMatchingCard(s.destroyfilter,tp,LOCATION_HAND+LOCATION_ONFIELD,0,1,nil)
  and Duel.IsExistingMatchingCard(s.pendulumfilter,tp,LOCATION_DECK,0,1,nil) end
 Duel.SetOperationInfo(0,CATEGORY_DESTROY,nil,1,tp,LOCATION_HAND+LOCATION_ONFIELD)
end
function s.placeop(e,tp)
 if not Duel.IsExistingMatchingCard(s.destroyfilter,tp,LOCATION_HAND+LOCATION_ONFIELD,0,1,nil) then return end
 Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_DESTROY)
 local g=Duel.SelectMatchingCard(tp,s.destroyfilter,tp,LOCATION_HAND+LOCATION_ONFIELD,0,1,1,nil)
 if #g==0 or Duel.Destroy(g,REASON_EFFECT)==0 or not s.haszone(tp) then return end
 Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_TOFIELD)
 local pg=Duel.SelectMatchingCard(tp,s.pendulumfilter,tp,LOCATION_DECK,0,1,1,nil)
 local pc=pg:GetFirst()
 if pc then Duel.MoveToField(pc,tp,tp,LOCATION_PZONE,POS_FACEUP,true) end
end
function s.setcost(e,tp,eg,ep,ev,re,r,rp,chk)
 local c=e:GetHandler()
 if chk==0 then return c:IsAbleToRemoveAsCost() end
 Duel.Remove(c,POS_FACEUP,REASON_COST)
end
function s.setfilter(c)
 return c:IsSetCard(SET_TERRARUMIAN) and c:IsType(TYPE_SPELL+TYPE_TRAP)
  and not c:IsCode(id) and c:IsSSetable()
end
function s.settg(e,tp,eg,ep,ev,re,r,rp,chk,chkc)
 if chkc then return chkc:IsControler(tp) and chkc:IsLocation(LOCATION_GRAVE)
  and s.setfilter(chkc) end
 if chk==0 then return Duel.GetLocationCount(tp,LOCATION_SZONE)>0
  and Duel.IsExistingTarget(aux.NecroValleyFilter(s.setfilter),tp,LOCATION_GRAVE,0,1,nil) end
 Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_SET)
 local g=Duel.SelectTarget(tp,aux.NecroValleyFilter(s.setfilter),tp,LOCATION_GRAVE,0,1,1,nil)
 Duel.SetOperationInfo(0,CATEGORY_SSET,g,1,tp,LOCATION_GRAVE)
end
function s.setop(e,tp)
 if Duel.GetLocationCount(tp,LOCATION_SZONE)<=0 then return end
 local tc=Duel.GetFirstTarget()
 if tc and tc:IsRelateToEffect(e) and aux.NecroValleyFilter(s.setfilter)(tc) then
  Duel.SSet(tp,tc)
 end
end

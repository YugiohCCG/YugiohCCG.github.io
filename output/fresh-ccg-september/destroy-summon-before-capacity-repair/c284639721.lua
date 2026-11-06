--Terrarumian Staghorn Fern
--Omega references: c232038002 (EVENT_CHAIN_SOLVING/NegateEffect), c248760718 (Pendulum effects).
local s,id=GetID()
local SET_TERRARUMIAN=0xA122
local MSG_ID=132639721
function s.initial_effect(c)
 aux.EnablePendulumAttribute(c)
 local e1=Effect.CreateEffect(c)
 e1:SetDescription(aux.Stringid(MSG_ID,0))
 e1:SetType(EFFECT_TYPE_FIELD+EFFECT_TYPE_CONTINUOUS)
 e1:SetCode(EVENT_CHAIN_SOLVING)
 e1:SetRange(LOCATION_PZONE)
 e1:SetCondition(s.negcon)
 e1:SetOperation(s.negop)
 c:RegisterEffect(e1)
 local e2=Effect.CreateEffect(c)
 e2:SetDescription(aux.Stringid(MSG_ID,1))
 e2:SetCategory(CATEGORY_DESTROY+CATEGORY_SPECIAL_SUMMON)
 e2:SetType(EFFECT_TYPE_IGNITION)
 e2:SetRange(LOCATION_PZONE)
 e2:SetCountLimit(1,id+100)
 e2:SetCondition(s.pcon)
 e2:SetTarget(s.ptg)
 e2:SetOperation(s.pop)
 c:RegisterEffect(e2)
 local e3=Effect.CreateEffect(c)
 e3:SetDescription(aux.Stringid(MSG_ID,2))
 e3:SetCategory(CATEGORY_TOGRAVE)
 e3:SetType(EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_O)
 e3:SetProperty(EFFECT_FLAG_DELAY)
 e3:SetCode(EVENT_DESTROYED)
 e3:SetCountLimit(1,id+200)
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
function s.negcon(e,tp,eg,ep,ev,re,r,rp)
 if ev<2 or rp==tp or Duel.GetFlagEffect(tp,id)>0
  or not e:GetHandler():IsDestructable() or not Duel.IsChainDisablable(ev) then return false end
 local pe=Duel.GetChainInfo(ev-1,CHAININFO_TRIGGERING_EFFECT)
 local pp=Duel.GetChainInfo(ev-1,CHAININFO_TRIGGERING_PLAYER)
 return pp==tp and pe and pe:GetHandler():IsSetCard(SET_TERRARUMIAN)
end
function s.negop(e,tp,eg,ep,ev,re,r,rp)
 local c=e:GetHandler()
 if not c:IsFaceup() or not c:IsLocation(LOCATION_PZONE)
  or not Duel.SelectEffectYesNo(tp,c,aux.Stringid(MSG_ID,0)) then return end
 if Duel.NegateEffect(ev) then
  Duel.RegisterFlagEffect(tp,id,RESET_PHASE+PHASE_END,0,1)
  Duel.Destroy(c,REASON_EFFECT)
 end
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
function s.handfilter(c,e,tp)
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
  or not Duel.IsExistingMatchingCard(s.handfilter,tp,LOCATION_HAND,0,1,nil,e,tp)
  or not Duel.SelectYesNo(tp,aux.Stringid(MSG_ID,3)) then return end
 Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_SPSUMMON)
 local hg=Duel.SelectMatchingCard(tp,s.handfilter,tp,LOCATION_HAND,0,1,1,nil,e,tp)
 local hc=hg:GetFirst()
 if hc then Duel.SpecialSummon(hc,0,tp,tp,false,false,POS_FACEUP) end
end
function s.descon(e)
 return e:GetHandler():IsReason(REASON_EFFECT)
end
function s.deckfilter(c)
 return c:IsSetCard(SET_TERRARUMIAN) and c:IsType(TYPE_MONSTER)
  and not c:IsCode(id) and c:IsAbleToGrave()
end
function s.oppfilter(c)
 return c:IsLevelBelow(6) and c:IsAbleToGrave()
end
function s.destg(e,tp,eg,ep,ev,re,r,rp,chk)
 local deckok=Duel.IsExistingMatchingCard(s.deckfilter,tp,LOCATION_DECK,0,1,nil)
 local oppok=Duel.IsExistingTarget(s.oppfilter,tp,0,LOCATION_MZONE,1,nil)
 if chk==0 then return deckok or oppok end
 local option
 if deckok and oppok then option=Duel.SelectOption(tp,aux.Stringid(MSG_ID,4),aux.Stringid(MSG_ID,5))
 elseif deckok then option=0 else option=1 end
 e:SetLabel(option)
 if option==1 then
  e:SetProperty(EFFECT_FLAG_CARD_TARGET+EFFECT_FLAG_DELAY)
  Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_TOGRAVE)
  Duel.SelectTarget(tp,s.oppfilter,tp,0,LOCATION_MZONE,1,1,nil)
 else
  e:SetProperty(EFFECT_FLAG_DELAY)
 end
 Duel.SetOperationInfo(0,CATEGORY_TOGRAVE,nil,1,option==0 and tp or 1-tp,option==0 and LOCATION_DECK or LOCATION_MZONE)
end
function s.desop(e,tp)
 if e:GetLabel()==1 then
  local tc=Duel.GetFirstTarget()
  if tc and tc:IsRelateToEffect(e) and s.oppfilter(tc) then
   Duel.SendtoGrave(tc,REASON_EFFECT)
  end
 else
  if not Duel.IsExistingMatchingCard(s.deckfilter,tp,LOCATION_DECK,0,1,nil) then return end
  Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_TOGRAVE)
  local g=Duel.SelectMatchingCard(tp,s.deckfilter,tp,LOCATION_DECK,0,1,1,nil)
  if #g>0 then Duel.SendtoGrave(g,REASON_EFFECT) end
 end
end

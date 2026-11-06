--Terrarumian Sundew
--Omega references: c248760718 (Pendulum effects), c223750159 (Special Summon Step).
local s,id=GetID()
local SET_TERRARUMIAN=0xA122
local MSG_ID=132639723
function s.initial_effect(c)
 aux.EnablePendulumAttribute(c)
 local e1=Effect.CreateEffect(c)
 e1:SetDescription(aux.Stringid(MSG_ID,0))
 e1:SetCategory(CATEGORY_DESTROY+CATEGORY_SPECIAL_SUMMON+CATEGORY_TOHAND)
 e1:SetType(EFFECT_TYPE_IGNITION)
 e1:SetRange(LOCATION_PZONE)
 e1:SetCountLimit(1,id)
 e1:SetCondition(s.pcon)
 e1:SetTarget(s.ptg)
 e1:SetOperation(s.pop)
 c:RegisterEffect(e1)
 local e2=Effect.CreateEffect(c)
 e2:SetDescription(aux.Stringid(MSG_ID,1))
 e2:SetCategory(CATEGORY_SPECIAL_SUMMON+CATEGORY_DESTROY)
 e2:SetType(EFFECT_TYPE_QUICK_O)
 e2:SetCode(EVENT_CHAINING)
 e2:SetRange(LOCATION_MZONE)
 e2:SetCondition(s.qcon)
 e2:SetTarget(s.qtg)
 e2:SetOperation(s.qop)
 c:RegisterEffect(e2)
 local e3=Effect.CreateEffect(c)
 e3:SetDescription(aux.Stringid(MSG_ID,2))
 e3:SetCategory(CATEGORY_TODECK)
 e3:SetType(EFFECT_TYPE_FIELD+EFFECT_TYPE_TRIGGER_O)
 e3:SetCode(EVENT_PHASE+PHASE_END)
 e3:SetRange(LOCATION_MZONE)
 e3:SetCountLimit(1)
 e3:SetTarget(s.tdtg)
 e3:SetOperation(s.tdop)
 c:RegisterEffect(e3)
 local e4=Effect.CreateEffect(c)
 e4:SetType(EFFECT_TYPE_SINGLE)
 e4:SetCode(EFFECT_DEFENSE_ATTACK)
 e4:SetValue(0)
 c:RegisterEffect(e4)
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
function s.exfilter(c)
 return c:IsFaceup() and c:IsSetCard(SET_TERRARUMIAN) and c:IsType(TYPE_PENDULUM)
  and not c:IsCode(id) and c:IsAbleToHand()
end
function s.record(c,ct)
 for i=1,ct do
  c:RegisterFlagEffect(id,RESET_EVENT+RESETS_STANDARD+RESET_PHASE+PHASE_END,0,1)
 end
end
function s.pendcount(g)
 return g:FilterCount(Card.IsType,nil,TYPE_PENDULUM)
end
function s.pop(e,tp)
 local c=e:GetHandler()
 if not c:IsRelateToEffect(e)
  or not Duel.IsExistingMatchingCard(s.destroyfilter,tp,LOCATION_ONFIELD,0,1,c,c) then return end
 local g
 if Duel.GetLocationCount(tp,LOCATION_MZONE)<=0 then
  Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_DESTROY)
  g=Duel.SelectMatchingCard(tp,s.destroyfilter,tp,LOCATION_MZONE,0,1,1,c,c)
  local more=Duel.GetMatchingGroup(s.destroyfilter,tp,LOCATION_ONFIELD,0,g:GetFirst(),c)
  if #more>0 and Duel.SelectYesNo(tp,aux.Stringid(MSG_ID,3)) then
   Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_DESTROY)
   g:Merge(more:Select(tp,1,1,nil))
  end
 else
  Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_DESTROY)
  g=Duel.SelectMatchingCard(tp,s.destroyfilter,tp,LOCATION_ONFIELD,0,1,2,c,c)
 end
 if not g or #g==0 or Duel.Destroy(g,REASON_EFFECT)==0 then return end
 local n=s.pendcount(Duel.GetOperatedGroup())
 if not c:IsRelateToEffect(e) or Duel.GetLocationCount(tp,LOCATION_MZONE)<=0
  or Duel.SpecialSummon(c,0,tp,tp,false,false,POS_FACEUP_DEFENSE)==0 then return end
 if n>0 then s.record(c,n) end
 if not Duel.IsExistingMatchingCard(s.exfilter,tp,LOCATION_EXTRA,0,1,nil)
  or not Duel.SelectYesNo(tp,aux.Stringid(MSG_ID,4)) then return end
 Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_ATOHAND)
 local sg=Duel.SelectMatchingCard(tp,s.exfilter,tp,LOCATION_EXTRA,0,1,1,nil)
 if #sg>0 and Duel.SendtoHand(sg,nil,REASON_EFFECT)>0 then Duel.ConfirmCards(1-tp,sg) end
end
function s.qcon(e,tp,eg,ep,ev,re,r,rp)
 local c=e:GetHandler()
 return rp==1-tp and c:IsFaceup() and c:IsDefensePos()
  and c:IsSummonType(SUMMON_TYPE_PENDULUM)
end
function s.deckfilter(c,e,tp)
 return c:IsSetCard(SET_TERRARUMIAN) and c:IsType(TYPE_PENDULUM)
  and c:IsCanBeSpecialSummoned(e,0,tp,false,false,POS_FACEUP_DEFENSE)
end
function s.qtg(e,tp,eg,ep,ev,re,r,rp,chk)
 if chk==0 then return Duel.GetLocationCount(tp,LOCATION_MZONE)>0
  and Duel.IsExistingMatchingCard(s.deckfilter,tp,LOCATION_DECK,0,1,nil,e,tp) end
 Duel.SetOperationInfo(0,CATEGORY_SPECIAL_SUMMON,nil,1,tp,LOCATION_DECK)
 Duel.SetOperationInfo(0,CATEGORY_DESTROY,nil,1,tp,LOCATION_ONFIELD)
end
function s.qop(e,tp)
 if Duel.GetLocationCount(tp,LOCATION_MZONE)<=0
  or not Duel.IsExistingMatchingCard(s.deckfilter,tp,LOCATION_DECK,0,1,nil,e,tp) then return end
 Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_SPSUMMON)
 local sg=Duel.SelectMatchingCard(tp,s.deckfilter,tp,LOCATION_DECK,0,1,1,nil,e,tp)
 local sc=sg:GetFirst()
 if not sc or Duel.SpecialSummon(sc,0,tp,tp,false,false,POS_FACEUP_DEFENSE)==0 then return end
 if not Duel.IsExistingMatchingCard(Card.IsDestructable,tp,LOCATION_ONFIELD,0,1,nil) then return end
 Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_DESTROY)
 local dg=Duel.SelectMatchingCard(tp,Card.IsDestructable,tp,LOCATION_ONFIELD,0,1,1,nil)
 local dc=dg:GetFirst()
 if dc and Duel.Destroy(dg,REASON_EFFECT)>0 and dc:IsType(TYPE_PENDULUM)
  and e:GetHandler():IsLocation(LOCATION_MZONE) then
  s.record(e:GetHandler(),1)
 end
end
function s.tdfilter(c)
 return c:IsFaceup() and c:IsType(TYPE_MONSTER) and c:IsAbleToDeck()
end
function s.tdtg(e,tp,eg,ep,ev,re,r,rp,chk)
 local ct=e:GetHandler():GetFlagEffect(id)
 if chk==0 then return ct>0 and Duel.GetMatchingGroupCount(s.tdfilter,tp,LOCATION_EXTRA,0,nil)>=ct end
 Duel.SetOperationInfo(0,CATEGORY_TODECK,nil,ct,tp,LOCATION_EXTRA)
end
function s.tdop(e,tp)
 local ct=e:GetHandler():GetFlagEffect(id)
 if ct<=0 or Duel.GetMatchingGroupCount(s.tdfilter,tp,LOCATION_EXTRA,0,nil)<ct then return end
 Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_TODECK)
 local g=Duel.SelectMatchingCard(tp,s.tdfilter,tp,LOCATION_EXTRA,0,ct,ct,nil)
 if #g==ct then Duel.SendtoDeck(g,nil,SEQ_DECKSHUFFLE,REASON_EFFECT) end
end

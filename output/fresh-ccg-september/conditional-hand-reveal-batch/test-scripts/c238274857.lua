--Vylon Chevron
--Omega references: c17315396 (turn-wide Extra Deck restriction), c75886890 (GY equip), c100245039 (quick Synchro Summon).
local s,id=GetID()
local SET_VYLON=0x30
local MSG_ID=132274857
function s.initial_effect(c)
 Duel.AddCustomActivityCounter(id,ACTIVITY_SPSUMMON,s.counterfilter)
 local e1=Effect.CreateEffect(c)
 e1:SetDescription(aux.Stringid(MSG_ID,0))
 e1:SetCategory(CATEGORY_TOGRAVE+CATEGORY_SPECIAL_SUMMON)
 e1:SetType(EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_O)
 e1:SetProperty(EFFECT_FLAG_DELAY)
 e1:SetCode(EVENT_SUMMON_SUCCESS)
 e1:SetCountLimit(1,id)
 e1:SetCost(s.spcost)
 e1:SetTarget(s.sptg)
 e1:SetOperation(s.spop)
 c:RegisterEffect(e1)
 local e2=e1:Clone()
 e2:SetCode(EVENT_SPSUMMON_SUCCESS)
 c:RegisterEffect(e2)
 local e3=Effect.CreateEffect(c)
 e3:SetDescription(aux.Stringid(MSG_ID,1))
 e3:SetCategory(CATEGORY_SPECIAL_SUMMON)
 e3:SetType(EFFECT_TYPE_QUICK_O)
 e3:SetCode(EVENT_FREE_CHAIN)
 e3:SetRange(LOCATION_MZONE)
 e3:SetCountLimit(1,id+100)
 e3:SetCondition(s.syncon)
 e3:SetTarget(s.syntg)
 e3:SetOperation(s.synop)
 c:RegisterEffect(e3)
 local e4=Effect.CreateEffect(c)
 e4:SetDescription(aux.Stringid(MSG_ID,2))
 e4:SetCategory(CATEGORY_EQUIP)
 e4:SetType(EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_O)
 e4:SetProperty(EFFECT_FLAG_DELAY+EFFECT_FLAG_CARD_TARGET)
 e4:SetCode(EVENT_TO_GRAVE)
 e4:SetCountLimit(1,id+200)
 e4:SetCondition(s.eqcon)
 e4:SetCost(s.eqcost)
 e4:SetTarget(s.eqtg)
 e4:SetOperation(s.eqop)
 c:RegisterEffect(e4)
end
function s.counterfilter(c)
 return not c:IsSummonLocation(LOCATION_EXTRA)
  or (c:IsType(TYPE_SYNCHRO) and c:IsAttribute(ATTRIBUTE_LIGHT))
end
function s.splimit(e,c)
 return c:IsSummonLocation(LOCATION_EXTRA)
  and not (c:IsType(TYPE_SYNCHRO) and c:IsAttribute(ATTRIBUTE_LIGHT))
end
function s.costfilter(c)
 return c:IsSetCard(SET_VYLON) and c:IsAbleToGraveAsCost()
end
function s.spcost(e,tp,eg,ep,ev,re,r,rp,chk)
 if chk==0 then return Duel.GetCustomActivityCount(id,tp,ACTIVITY_SPSUMMON)==0
  and Duel.IsExistingMatchingCard(s.costfilter,tp,LOCATION_HAND+LOCATION_ONFIELD,0,1,nil) end
 local lock=Effect.CreateEffect(e:GetHandler())
 lock:SetType(EFFECT_TYPE_FIELD)
 lock:SetCode(EFFECT_CANNOT_SPECIAL_SUMMON)
 lock:SetProperty(EFFECT_FLAG_PLAYER_TARGET+EFFECT_FLAG_OATH)
 lock:SetTargetRange(1,0)
 lock:SetTarget(s.splimit)
 lock:SetReset(RESET_PHASE+PHASE_END)
 Duel.RegisterEffect(lock,tp)
 Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_TOGRAVE)
 local g=Duel.SelectMatchingCard(tp,s.costfilter,tp,LOCATION_HAND+LOCATION_ONFIELD,0,1,1,nil)
 Duel.SendtoGrave(g,REASON_COST)
end
function s.spfilter(c,e,tp)
 return c:IsSetCard(SET_VYLON) and c:IsType(TYPE_MONSTER)
  and c:IsLevelBelow(4) and not c:IsCode(id)
  and c:IsCanBeSpecialSummoned(e,0,tp,false,false)
end
function s.sptg(e,tp,eg,ep,ev,re,r,rp,chk)
 if chk==0 then return Duel.GetLocationCount(tp,LOCATION_MZONE)>0
  and Duel.IsExistingMatchingCard(s.spfilter,tp,LOCATION_DECK,0,1,nil,e,tp) end
 Duel.SetOperationInfo(0,CATEGORY_SPECIAL_SUMMON,nil,1,tp,LOCATION_DECK)
end
function s.spop(e,tp)
 if Duel.GetLocationCount(tp,LOCATION_MZONE)<=0 then return end
 Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_SPSUMMON)
 local g=Duel.SelectMatchingCard(tp,s.spfilter,tp,LOCATION_DECK,0,1,1,nil,e,tp)
 if #g>0 then Duel.SpecialSummon(g:GetFirst(),0,tp,tp,false,false,POS_FACEUP) end
end
function s.syncon(e,tp)
 return Duel.IsMainPhase()
end
function s.synfilter(c,tuner)
 return c:IsAttribute(ATTRIBUTE_LIGHT) and c:IsType(TYPE_SYNCHRO)
  and c:IsSynchroSummonable(tuner)
end
function s.syntg(e,tp,eg,ep,ev,re,r,rp,chk)
 local c=e:GetHandler()
 if chk==0 then return c:IsFaceup()
  and Duel.IsExistingMatchingCard(s.synfilter,tp,LOCATION_EXTRA,0,1,nil,c) end
end
function s.synop(e,tp)
 local c=e:GetHandler()
 if not c:IsRelateToEffect(e) or not c:IsFaceup() then return end
 Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_SPSUMMON)
 local g=Duel.SelectMatchingCard(tp,s.synfilter,tp,LOCATION_EXTRA,0,1,1,nil,c)
 local sc=g:GetFirst()
 if sc then Duel.SynchroSummon(tp,sc,c) end
end
function s.eqcon(e)
 return e:GetHandler():IsPreviousLocation(LOCATION_ONFIELD)
end
function s.eqcost(e,tp,eg,ep,ev,re,r,rp,chk)
 if chk==0 then return Duel.CheckLPCost(tp,500) end
 Duel.PayLPCost(tp,500)
end
function s.eqfilter(c)
 return c:IsFaceup() and c:IsType(TYPE_MONSTER)
end
function s.eqtg(e,tp,eg,ep,ev,re,r,rp,chk,chkc)
 if chkc then return chkc:IsLocation(LOCATION_MZONE) and chkc:IsControler(tp) and s.eqfilter(chkc) end
 if chk==0 then return Duel.GetLocationCount(tp,LOCATION_SZONE)>0
  and Duel.IsExistingTarget(s.eqfilter,tp,LOCATION_MZONE,0,1,nil) end
 Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_EQUIP)
 local g=Duel.SelectTarget(tp,s.eqfilter,tp,LOCATION_MZONE,0,1,1,nil)
 Duel.SetOperationInfo(0,CATEGORY_EQUIP,g,1,0,0)
end
function s.eqop(e,tp)
 local c=e:GetHandler()
 local tc=Duel.GetFirstTarget()
 if not c:IsRelateToEffect(e) or not tc or not tc:IsRelateToEffect(e)
  or not tc:IsFaceup() or Duel.GetLocationCount(tp,LOCATION_SZONE)<=0 then return end
 if Duel.Equip(tp,c,tc) then
  local limit=Effect.CreateEffect(c)
  limit:SetType(EFFECT_TYPE_SINGLE)
  limit:SetCode(EFFECT_EQUIP_LIMIT)
  limit:SetProperty(EFFECT_FLAG_CANNOT_DISABLE)
  limit:SetLabelObject(tc)
  limit:SetValue(function(e,mc) return mc==e:GetLabelObject() end)
  limit:SetReset(RESET_EVENT+RESETS_STANDARD)
  c:RegisterEffect(limit)
 end
end

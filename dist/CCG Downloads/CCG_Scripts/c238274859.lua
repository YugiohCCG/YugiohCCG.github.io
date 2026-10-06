--Vylon Volt
--Omega references: c10971759 (group Special Summon), utility.lua UnionEquipFilter/SetUnionState.
local s,id=GetID()
local SET_VYLON=0x30
local MSG_ID=132274859
function s.initial_effect(c)
 local e1=Effect.CreateEffect(c)
 e1:SetDescription(aux.Stringid(MSG_ID,0))
 e1:SetCategory(CATEGORY_SPECIAL_SUMMON)
 e1:SetType(EFFECT_TYPE_IGNITION)
 e1:SetRange(LOCATION_HAND)
 e1:SetCountLimit(1,id)
 e1:SetCost(s.spcost)
 e1:SetTarget(s.sptg)
 e1:SetOperation(s.spop)
 c:RegisterEffect(e1)
 local e2=Effect.CreateEffect(c)
 e2:SetDescription(aux.Stringid(MSG_ID,1))
 e2:SetCategory(CATEGORY_EQUIP)
 e2:SetType(EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_O)
 e2:SetProperty(EFFECT_FLAG_CARD_TARGET+EFFECT_FLAG_DELAY)
 e2:SetCode(EVENT_SUMMON_SUCCESS)
 e2:SetCountLimit(1,id+100)
 e2:SetTarget(s.eqtg)
 e2:SetOperation(s.eqop)
 c:RegisterEffect(e2)
 local e3=e2:Clone()
 e3:SetCode(EVENT_SPSUMMON_SUCCESS)
 c:RegisterEffect(e3)
end
function s.handfilter(c,e,tp)
 return c:IsSetCard(SET_VYLON) and c:IsType(TYPE_MONSTER)
  and c:IsCanBeSpecialSummoned(e,0,tp,false,false)
end
function s.spcost(e,tp,eg,ep,ev,re,r,rp,chk)
 local c=e:GetHandler()
 if chk==0 then return Duel.IsExistingMatchingCard(s.handfilter,tp,LOCATION_HAND,0,1,c,e,tp) end
 Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_CONFIRM)
 local g=Duel.SelectMatchingCard(tp,s.handfilter,tp,LOCATION_HAND,0,1,1,c,e,tp)
 local tc=g:GetFirst()
 Duel.ConfirmCards(1-tp,g)
 e:SetLabelObject(tc)
 tc:CreateEffectRelation(e)
end
function s.sptg(e,tp,eg,ep,ev,re,r,rp,chk)
 if chk==0 then return Duel.GetLocationCount(tp,LOCATION_MZONE)>1
  and not Duel.IsPlayerAffectedByEffect(tp,59822133)
  and e:GetHandler():IsCanBeSpecialSummoned(e,0,tp,false,false) end
 Duel.SetOperationInfo(0,CATEGORY_SPECIAL_SUMMON,nil,2,tp,LOCATION_HAND)
end
function s.splimit(e,c)
 return not c:IsAttribute(ATTRIBUTE_LIGHT)
end
function s.spop(e,tp)
 local c=e:GetHandler()
 local tc=e:GetLabelObject()
 if not c:IsRelateToEffect(e) or not tc or not tc:IsRelateToEffect(e)
  or not c:IsLocation(LOCATION_HAND) or not tc:IsLocation(LOCATION_HAND)
  or Duel.GetLocationCount(tp,LOCATION_MZONE)<2 or Duel.IsPlayerAffectedByEffect(tp,59822133)
  or not c:IsCanBeSpecialSummoned(e,0,tp,false,false)
  or not tc:IsCanBeSpecialSummoned(e,0,tp,false,false) then return end
 if not Duel.SpecialSummonStep(c,0,tp,tp,false,false,POS_FACEUP) then return end
 if not Duel.SpecialSummonStep(tc,0,tp,tp,false,false,POS_FACEUP) then
  Duel.SpecialSummonComplete()
  return
 end
 Duel.SpecialSummonComplete()
 local lock=Effect.CreateEffect(c)
 lock:SetType(EFFECT_TYPE_FIELD)
 lock:SetCode(EFFECT_CANNOT_SPECIAL_SUMMON)
 lock:SetProperty(EFFECT_FLAG_PLAYER_TARGET)
 lock:SetTargetRange(1,0)
 lock:SetTarget(s.splimit)
 lock:SetReset(RESET_PHASE+PHASE_END)
 Duel.RegisterEffect(lock,tp)
end
function s.unionfilter(c,tc)
 return c:IsSetCard(SET_VYLON) and c:IsType(TYPE_UNION) and c:IsType(TYPE_MONSTER)
  and aux.CheckUnionEquip(c,tc)
end
function s.eqtarget(c,e,tp)
 return c~=e:GetHandler() and c:IsFaceup() and c:IsSetCard(SET_VYLON)
  and Duel.GetLocationCount(tp,LOCATION_SZONE)>0
  and Duel.IsExistingMatchingCard(s.unionfilter,tp,LOCATION_DECK+LOCATION_GRAVE,0,1,nil,c)
end
function s.eqtg(e,tp,eg,ep,ev,re,r,rp,chk,chkc)
 if chkc then return chkc:IsLocation(LOCATION_MZONE) and chkc:IsControler(tp) and s.eqtarget(chkc,e,tp) end
 if chk==0 then return Duel.IsExistingTarget(s.eqtarget,tp,LOCATION_MZONE,0,1,nil,e,tp) end
 Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_EQUIP)
 local g=Duel.SelectTarget(tp,s.eqtarget,tp,LOCATION_MZONE,0,1,1,nil,e,tp)
 Duel.SetOperationInfo(0,CATEGORY_EQUIP,g,1,0,0)
end
function s.eqop(e,tp)
 local tc=Duel.GetFirstTarget()
 if not tc or not tc:IsRelateToEffect(e) or not tc:IsFaceup()
  or Duel.GetLocationCount(tp,LOCATION_SZONE)<=0 then return end
 Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_EQUIP)
 local g=Duel.SelectMatchingCard(tp,aux.NecroValleyFilter(s.unionfilter),tp,LOCATION_DECK+LOCATION_GRAVE,0,1,1,nil,tc)
 local uc=g:GetFirst()
 if uc and Duel.Equip(tp,uc,tc) then aux.SetUnionState(uc) end
end

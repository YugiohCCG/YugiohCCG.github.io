--Aquamarine Coral Krait
--Omega references: c39915560 (opponent-caused leave-field trigger),
-- and the repository's Aquamarine Fusion procedures.
local s,id=GetID()
local SET_AQUAMARINE=0x0f3c
local MSG_ID=132636662
function s.initial_effect(c)
 c:EnableReviveLimit()
 aux.AddFusionProcFunFun(c,s.fusionmat,s.watermat,2,true)
 local e1=Effect.CreateEffect(c)
 e1:SetDescription(aux.Stringid(MSG_ID,0))
 e1:SetCategory(CATEGORY_TOGRAVE)
 e1:SetType(EFFECT_TYPE_QUICK_O)
 e1:SetCode(EVENT_FREE_CHAIN)
 e1:SetRange(LOCATION_MZONE)
 e1:SetProperty(EFFECT_FLAG_CARD_TARGET)
 e1:SetCondition(s.sendcon)
 e1:SetCost(s.sendcost)
 e1:SetTarget(s.sendtg)
 e1:SetOperation(s.sendop)
 c:RegisterEffect(e1)
 local e2=Effect.CreateEffect(c)
 e2:SetDescription(aux.Stringid(MSG_ID,1))
 e2:SetCategory(CATEGORY_SPECIAL_SUMMON+CATEGORY_FUSION_SUMMON)
 e2:SetType(EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_O)
 e2:SetProperty(EFFECT_FLAG_DELAY)
 e2:SetCode(EVENT_LEAVE_FIELD)
 e2:SetCondition(s.leavecon)
 e2:SetTarget(s.leavetg)
 e2:SetOperation(s.leaveop)
 c:RegisterEffect(e2)
end
function s.fusionmat(c,fc)
 return c:IsType(TYPE_FUSION) and c:IsSetCard(SET_AQUAMARINE)
  and c:IsLevelAbove(7)
end
function s.watermat(c)
 return c:IsAttribute(ATTRIBUTE_WATER)
end
function s.otherfilter(c,handler)
 return c~=handler and c:IsFaceup() and c:IsType(TYPE_FUSION)
  and c:IsSetCard(SET_AQUAMARINE) and c:IsLevelAbove(8)
end
function s.sendcon(e,tp)
 local c=e:GetHandler()
 return Duel.GetFlagEffect(tp,id)<Duel.GetMatchingGroupCount(s.otherfilter,tp,LOCATION_MZONE,0,nil,c)
end
function s.sendcost(e,tp,eg,ep,ev,re,r,rp,chk)
 if chk==0 then return true end
 Duel.RegisterFlagEffect(tp,id,RESET_PHASE+PHASE_END,0,1)
end
function s.sendfilter(c)
 return c:IsFaceup() and c:IsAbleToGrave()
end
function s.sendtg(e,tp,eg,ep,ev,re,r,rp,chk,chkc)
 if chkc then return chkc:IsOnField() and s.sendfilter(chkc) end
 if chk==0 then return Duel.IsExistingTarget(s.sendfilter,tp,LOCATION_ONFIELD,LOCATION_ONFIELD,1,nil) end
 Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_TOGRAVE)
 local g=Duel.SelectTarget(tp,s.sendfilter,tp,LOCATION_ONFIELD,LOCATION_ONFIELD,1,1,nil)
 Duel.SetOperationInfo(0,CATEGORY_TOGRAVE,g,1,0,0)
end
function s.sendop(e,tp)
 local tc=Duel.GetFirstTarget()
 if tc and tc:IsRelateToEffect(e) and tc:IsFaceup() then
  Duel.SendtoGrave(tc,REASON_EFFECT)
 end
end
function s.nonwater(c)
 return c:IsFaceup() and not c:IsAttribute(ATTRIBUTE_WATER)
end
function s.leavecon(e,tp,eg,ep,ev,re,r,rp)
 local c=e:GetHandler()
 return c:IsSummonType(SUMMON_TYPE_FUSION)
  and c:IsPreviousControler(tp) and c:IsPreviousLocation(LOCATION_MZONE)
  and rp==1-tp
  and Duel.IsExistingMatchingCard(s.nonwater,tp,0,LOCATION_MZONE,1,nil)
end
function s.exfilter(c,e,tp)
 return c:IsType(TYPE_FUSION) and c:IsSetCard(SET_AQUAMARINE)
  and Duel.GetLocationCountFromEx(tp,tp,nil,c)>0
  and c:IsCanBeSpecialSummoned(e,SUMMON_TYPE_FUSION,tp,true,true)
end
function s.leavetg(e,tp,eg,ep,ev,re,r,rp,chk)
 if chk==0 then return Duel.IsExistingMatchingCard(s.exfilter,tp,LOCATION_EXTRA,0,1,nil,e,tp) end
 Duel.SetOperationInfo(0,CATEGORY_SPECIAL_SUMMON,nil,1,tp,LOCATION_EXTRA)
end
function s.leaveop(e,tp)
 if not Duel.IsExistingMatchingCard(s.exfilter,tp,LOCATION_EXTRA,0,1,nil,e,tp) then return end
 Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_SPSUMMON)
 local g=Duel.SelectMatchingCard(tp,s.exfilter,tp,LOCATION_EXTRA,0,1,1,nil,e,tp)
 local fc=g:GetFirst()
 if fc and Duel.SpecialSummon(fc,SUMMON_TYPE_FUSION,tp,tp,true,true,POS_FACEUP)>0 then
  fc:CompleteProcedure()
 end
end

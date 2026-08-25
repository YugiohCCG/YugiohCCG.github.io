--Dinomorphia Ankylos
--Omega references: Dinomorphia Therizia (c92133240), Dinomorphia Diplos (c38628859)
local s,id=GetID(); local SET_DINOMORPHIA=0x173; local MSG_ID=133754412
function s.initial_effect(c)
 local e1=Effect.CreateEffect(c); e1:SetDescription(aux.Stringid(MSG_ID,0)); e1:SetCategory(CATEGORY_SPECIAL_SUMMON); e1:SetType(EFFECT_TYPE_QUICK_O); e1:SetCode(EVENT_FREE_CHAIN); e1:SetRange(LOCATION_HAND+LOCATION_GRAVE); e1:SetCountLimit(1,id); e1:SetCost(s.lpcost); e1:SetTarget(s.selftg); e1:SetOperation(s.selfop); c:RegisterEffect(e1)
 local e2=Effect.CreateEffect(c); e2:SetDescription(aux.Stringid(MSG_ID,1)); e2:SetCategory(CATEGORY_LEAVE_GRAVE); e2:SetType(EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_O); e2:SetCode(EVENT_SUMMON_SUCCESS); e2:SetProperty(EFFECT_FLAG_DELAY); e2:SetCountLimit(1,id+100); e2:SetTarget(s.settg); e2:SetOperation(s.setop); c:RegisterEffect(e2); local e3=e2:Clone(); e3:SetCode(EVENT_SPSUMMON_SUCCESS); c:RegisterEffect(e3)
 local e4=Effect.CreateEffect(c); e4:SetDescription(aux.Stringid(MSG_ID,2)); e4:SetCategory(CATEGORY_SPECIAL_SUMMON); e4:SetType(EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_O); e4:SetCode(EVENT_DESTROYED); e4:SetProperty(EFFECT_FLAG_DELAY); e4:SetCountLimit(1,id+200); e4:SetCost(s.spcost); e4:SetTarget(s.sptg); e4:SetOperation(s.spop); c:RegisterEffect(e4)
end
function s.lpcost(e,tp,eg,ep,ev,re,r,rp,chk) if chk==0 then return true end Duel.PayLPCost(tp,math.floor(Duel.GetLP(tp)/2)) end
function s.selftg(e,tp,eg,ep,ev,re,r,rp,chk) if chk==0 then return Duel.GetLocationCount(tp,LOCATION_MZONE)>0 and e:GetHandler():IsCanBeSpecialSummoned(e,0,tp,false,false) end Duel.SetOperationInfo(0,CATEGORY_SPECIAL_SUMMON,e:GetHandler(),1,0,0) end
function s.selfop(e,tp) local c=e:GetHandler(); if c:IsRelateToEffect(e) then Duel.SpecialSummon(c,0,tp,tp,false,false,POS_FACEUP) end end
function s.tf(c) return c:IsSetCard(SET_DINOMORPHIA) and c:IsTrap() and c:IsSSetable() end
function s.settg(e,tp,eg,ep,ev,re,r,rp,chk) if chk==0 then return Duel.IsExistingMatchingCard(aux.NecroValleyFilter(s.tf),tp,LOCATION_GRAVE+LOCATION_REMOVED,0,1,nil) end end
function s.setop(e,tp) Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_SET); local g=Duel.SelectMatchingCard(tp,aux.NecroValleyFilter(s.tf),tp,LOCATION_GRAVE+LOCATION_REMOVED,0,1,1,nil); local tc=g:GetFirst(); if tc and Duel.SSet(tp,tc)>0 and Duel.GetLP(tp)<=2000 then local ex=Effect.CreateEffect(e:GetHandler()); ex:SetType(EFFECT_TYPE_SINGLE); ex:SetCode(EFFECT_TRAP_ACT_IN_SET_TURN); ex:SetProperty(EFFECT_FLAG_SET_AVAILABLE); ex:SetReset(RESET_EVENT+RESETS_STANDARD); tc:RegisterEffect(ex) end end
function s.bf(c) return c:IsTrap() and c:IsAbleToRemoveAsCost() end
function s.spcost(e,tp,eg,ep,ev,re,r,rp,chk) if chk==0 then return Duel.IsExistingMatchingCard(s.bf,tp,LOCATION_GRAVE,0,1,nil) end Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_REMOVE); local g=Duel.SelectMatchingCard(tp,s.bf,tp,LOCATION_GRAVE,0,1,1,nil); Duel.Remove(g,POS_FACEUP,REASON_COST) end
function s.spf(c,e,tp) return c:IsSetCard(SET_DINOMORPHIA) and c:IsLevel(4) and not c:IsCode(id) and c:IsCanBeSpecialSummoned(e,0,tp,false,false) end
function s.sptg(e,tp,eg,ep,ev,re,r,rp,chk) if chk==0 then return Duel.GetLocationCount(tp,LOCATION_MZONE)>0 and Duel.IsExistingMatchingCard(aux.NecroValleyFilter(s.spf),tp,LOCATION_GRAVE,0,1,nil,e,tp) end Duel.SetOperationInfo(0,CATEGORY_SPECIAL_SUMMON,nil,1,tp,LOCATION_GRAVE) end
function s.spop(e,tp) if Duel.GetLocationCount(tp,LOCATION_MZONE)<=0 then return end Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_SPSUMMON); local g=Duel.SelectMatchingCard(tp,aux.NecroValleyFilter(s.spf),tp,LOCATION_GRAVE,0,1,1,nil,e,tp); Duel.SpecialSummon(g,0,tp,tp,false,false,POS_FACEUP) end

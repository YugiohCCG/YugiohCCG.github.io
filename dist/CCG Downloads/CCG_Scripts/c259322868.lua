--Krawler of the World Legacy
--Omega references: Subterror Behemoth Fiendess (c74937659), Krawler Glial (c51205763)
local s,id=GetID(); local SET_KRAWLER=0x104; local MSG_ID=133322868
function s.initial_effect(c)
 local e0=Effect.CreateEffect(c); e0:SetDescription(aux.Stringid(MSG_ID,0)); e0:SetType(EFFECT_TYPE_FIELD); e0:SetCode(EFFECT_SPSUMMON_PROC); e0:SetProperty(EFFECT_FLAG_UNCOPYABLE); e0:SetRange(LOCATION_HAND); e0:SetCountLimit(1,id+EFFECT_COUNT_CODE_OATH); e0:SetCondition(s.spcon); e0:SetTarget(s.sptg0); e0:SetOperation(s.spop0); c:RegisterEffect(e0)
 local e1=Effect.CreateEffect(c); e1:SetDescription(aux.Stringid(MSG_ID,1)); e1:SetCategory(CATEGORY_SPECIAL_SUMMON); e1:SetType(EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_O); e1:SetCode(EVENT_SPSUMMON_SUCCESS); e1:SetProperty(EFFECT_FLAG_DELAY); e1:SetCountLimit(1,id); e1:SetTarget(s.sptg); e1:SetOperation(s.spop); c:RegisterEffect(e1)
 local e2=Effect.CreateEffect(c); e2:SetDescription(aux.Stringid(MSG_ID,2)); e2:SetCategory(CATEGORY_POSITION); e2:SetType(EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_O); e2:SetCode(EVENT_TO_GRAVE); e2:SetProperty(EFFECT_FLAG_CARD_TARGET+EFFECT_FLAG_DELAY); e2:SetCountLimit(1,id+100); e2:SetCondition(s.poscon); e2:SetTarget(s.postg); e2:SetOperation(s.posop); c:RegisterEffect(e2)
end
function s.rel(c,tp) return c:IsFacedown() and c:IsReleasable() and Duel.GetMZoneCount(tp,c)>0 end
function s.spcon(e,c) if c==nil then return true end local tp=c:GetControler(); return Duel.IsExistingMatchingCard(s.rel,tp,LOCATION_MZONE,LOCATION_MZONE,1,nil,tp) end
function s.sptg0(e,tp,eg,ep,ev,re,r,rp,c) Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_RELEASE); local g=Duel.SelectMatchingCard(tp,s.rel,tp,LOCATION_MZONE,LOCATION_MZONE,1,1,nil,tp); if #g==0 then return false end e:SetLabelObject(g:GetFirst()); return true end
function s.spop0(e,tp) Duel.Release(e:GetLabelObject(),REASON_COST) end
function s.kf(c,e,tp) return c:IsSetCard(SET_KRAWLER) and c:IsCanBeSpecialSummoned(e,0,tp,false,false,POS_FACEDOWN_DEFENSE) end
function s.sptg(e,tp,eg,ep,ev,re,r,rp,chk) if chk==0 then return Duel.GetLocationCount(tp,LOCATION_MZONE)>0 and Duel.IsExistingMatchingCard(aux.NecroValleyFilter(s.kf),tp,LOCATION_HAND+LOCATION_GRAVE,0,1,nil,e,tp) end Duel.SetOperationInfo(0,CATEGORY_SPECIAL_SUMMON,nil,1,tp,LOCATION_HAND+LOCATION_GRAVE) end
function s.spop(e,tp) if Duel.GetLocationCount(tp,LOCATION_MZONE)<=0 then return end Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_SPSUMMON); local g=Duel.SelectMatchingCard(tp,aux.NecroValleyFilter(s.kf),tp,LOCATION_HAND+LOCATION_GRAVE,0,1,1,nil,e,tp); if Duel.SpecialSummon(g,0,tp,tp,false,false,POS_FACEDOWN_DEFENSE)>0 then Duel.ConfirmCards(1-tp,g) end end
function s.poscon(e,tp,eg,ep,ev,re,r,rp) local c=e:GetHandler(); local rc=c:GetReasonCard(); return c:IsReason(REASON_LINK) or c:IsReason(REASON_EFFECT) and rc and rc:IsSetCard(SET_KRAWLER) end
function s.pf(c) return c:IsCanChangePosition() end
function s.postg(e,tp,eg,ep,ev,re,r,rp,chk,chkc) if chkc then return chkc:IsLocation(LOCATION_MZONE) and s.pf(chkc) end if chk==0 then return Duel.IsExistingTarget(s.pf,tp,LOCATION_MZONE,LOCATION_MZONE,1,nil) end Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_POSCHANGE); Duel.SelectTarget(tp,s.pf,tp,LOCATION_MZONE,LOCATION_MZONE,1,1,nil) end
function s.posop(e,tp) local tc=Duel.GetFirstTarget(); if not tc:IsRelateToEffect(e) then return end if tc:IsFacedown() then Duel.ChangePosition(tc,POS_FACEUP_DEFENSE) elseif tc:IsCanTurnSet() then Duel.ChangePosition(tc,POS_FACEDOWN_DEFENSE) end end

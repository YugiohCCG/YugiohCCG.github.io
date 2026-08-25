--Arktos X - Vaylantz Game Master
--Omega references: Vaylantz Genesis Grand Duke (c76075139), Vaylantz Voltage Viscount (c41802073)
local s,id=GetID(); local MSG_ID=133537607; local SET_VAYLANTZ=0x17d
function s.initial_effect(c)
 aux.EnablePendulumAttribute(c)
 local e1=Effect.CreateEffect(c); e1:SetDescription(aux.Stringid(MSG_ID,0)); e1:SetCategory(CATEGORY_SPECIAL_SUMMON); e1:SetType(EFFECT_TYPE_IGNITION); e1:SetRange(LOCATION_PZONE); e1:SetCountLimit(1,id); e1:SetCondition(s.pcon); e1:SetTarget(s.ptg); e1:SetOperation(s.pop); c:RegisterEffect(e1)
 local e2=Effect.CreateEffect(c); e2:SetType(EFFECT_TYPE_FIELD+EFFECT_TYPE_TRIGGER_F); e2:SetCode(EVENT_SUMMON_SUCCESS); e2:SetRange(LOCATION_MZONE); e2:SetCondition(s.mvcon); e2:SetOperation(s.mvop); c:RegisterEffect(e2); local e3=e2:Clone(); e3:SetCode(EVENT_SPSUMMON_SUCCESS); c:RegisterEffect(e3)
 local e4=Effect.CreateEffect(c); e4:SetDescription(aux.Stringid(MSG_ID,1)); e4:SetType(EFFECT_TYPE_QUICK_O); e4:SetCode(EVENT_FREE_CHAIN); e4:SetRange(LOCATION_MZONE); e4:SetCountLimit(1,id+100); e4:SetTarget(s.qtg); e4:SetOperation(s.qop); c:RegisterEffect(e4)
end
function s.pcon(e,tp) return Duel.IsExistingMatchingCard(function(c) return c:IsFaceup() and c:IsSetCard(SET_VAYLANTZ) and c:IsType(TYPE_FUSION) end,tp,LOCATION_MZONE,0,1,nil) end
function s.ptg(e,tp,eg,ep,ev,re,r,rp,chk) local c=e:GetHandler(); if chk==0 then return c:IsCanBeSpecialSummoned(e,0,tp,false,false,POS_FACEUP,tp,1<<c:GetSequence()) end Duel.SetOperationInfo(0,CATEGORY_SPECIAL_SUMMON,c,1,0,0) end
function s.pop(e,tp) local c=e:GetHandler(); if c:IsRelateToEffect(e) then Duel.SpecialSummon(c,0,tp,tp,false,false,POS_FACEUP,tp,1<<c:GetSequence()) end end
function s.mvcon(e,tp,eg) return #eg==1 and eg:GetFirst():IsControler(1-tp) and eg:GetFirst():IsLocation(LOCATION_MZONE) and e:GetHandler():GetSequence()<5 end
function s.mvop(e,tp,eg) local c=e:GetHandler(); local oc=eg:GetFirst(); if not c:IsFaceup() or not oc:IsFaceup() then return end local cs=c:GetSequence(); local os=4-oc:GetSequence(); local ns=cs; if os<cs and cs>0 then ns=cs-1 elseif os>cs and cs<4 then ns=cs+1 end if ns~=cs and Duel.CheckLocation(tp,LOCATION_MZONE,ns) then Duel.MoveSequence(c,ns) end end
function s.mf(c) local tp=c:GetControler(); for i=0,4 do if i~=c:GetSequence() and Duel.CheckLocation(tp,LOCATION_MZONE,i) then return true end end return false end
function s.qtg(e,tp,eg,ep,ev,re,r,rp,chk) if chk==0 then return Duel.IsExistingMatchingCard(s.mf,tp,LOCATION_MZONE,0,1,nil) end end
function s.qop(e,tp) Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_FACEUP); local tc=Duel.SelectMatchingCard(tp,s.mf,tp,LOCATION_MZONE,0,1,1,nil):GetFirst(); if not tc then return end local flag=0; for i=0,4 do if i~=tc:GetSequence() and Duel.CheckLocation(tp,LOCATION_MZONE,i) then flag=flag|(1<<i) end end Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_TOZONE); local z=Duel.SelectDisableField(tp,1,LOCATION_MZONE,0,~flag); Duel.MoveSequence(tc,math.log(z,2)) end

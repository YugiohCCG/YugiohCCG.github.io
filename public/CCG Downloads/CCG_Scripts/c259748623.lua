--Argalia the Gripen Aerocat
--Omega references: Salamangreat Spinny (c52277807), Overlay Regen (c27068117)
local s,id=GetID(); local SET_AEROCAT=0x3de1; local STRING_ID=133748623
function s.initial_effect(c)
 local e0=Effect.CreateEffect(c); e0:SetDescription(aux.Stringid(STRING_ID,0)); e0:SetType(EFFECT_TYPE_FIELD); e0:SetCode(EFFECT_SPSUMMON_PROC); e0:SetProperty(EFFECT_FLAG_UNCOPYABLE); e0:SetRange(LOCATION_HAND); e0:SetCountLimit(1,id+EFFECT_COUNT_CODE_OATH); e0:SetCondition(s.spcon); c:RegisterEffect(e0)
 local e1=Effect.CreateEffect(c); e1:SetDescription(aux.Stringid(STRING_ID,1)); e1:SetCategory(CATEGORY_DESTROY); e1:SetType(EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_O); e1:SetCode(EVENT_SUMMON_SUCCESS); e1:SetProperty(EFFECT_FLAG_CARD_TARGET+EFFECT_FLAG_DELAY); e1:SetCountLimit(1,id); e1:SetTarget(s.destg); e1:SetOperation(s.desop); c:RegisterEffect(e1); local e2=e1:Clone(); e2:SetCode(EVENT_SPSUMMON_SUCCESS); c:RegisterEffect(e2)
 local e3=Effect.CreateEffect(c); e3:SetDescription(aux.Stringid(STRING_ID,2)); e3:SetType(EFFECT_TYPE_QUICK_O); e3:SetCode(EVENT_FREE_CHAIN); e3:SetRange(LOCATION_HAND+LOCATION_GRAVE); e3:SetProperty(EFFECT_FLAG_CARD_TARGET); e3:SetCountLimit(1,id+100); e3:SetTarget(s.ovtg); e3:SetOperation(s.ovop); c:RegisterEffect(e3)
end
function s.spcon(e,c) if c==nil then return true end return Duel.GetLocationCount(c:GetControler(),LOCATION_MZONE)>0 and Duel.IsExistingMatchingCard(function(x) return x:IsSetCard(SET_AEROCAT) and x:IsType(TYPE_MONSTER) end,c:GetControler(),LOCATION_MZONE+LOCATION_GRAVE,0,1,nil) end
function s.df(c) return c:IsMonster() and c:IsDestructable() end
function s.destg(e,tp,eg,ep,ev,re,r,rp,chk,chkc) if chkc then return chkc:IsControler(1-tp) and chkc:IsLocation(LOCATION_MZONE) and s.df(chkc) end if chk==0 then return Duel.IsExistingTarget(s.df,tp,0,LOCATION_MZONE,1,nil) end Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_DESTROY); local g=Duel.SelectTarget(tp,s.df,tp,0,LOCATION_MZONE,1,1,nil); Duel.SetOperationInfo(0,CATEGORY_DESTROY,g,1,0,0) end
function s.xyz(c) return c:IsFaceup() and c:IsType(TYPE_XYZ) end
function s.oppgy(c) return c:IsCanBeXyzMaterial() end
function s.desop(e,tp) local tc=Duel.GetFirstTarget(); if tc and tc:IsRelateToEffect(e) and Duel.Destroy(tc,REASON_EFFECT)>0 and Duel.IsExistingMatchingCard(s.xyz,tp,LOCATION_MZONE,0,1,nil) and Duel.IsExistingMatchingCard(s.oppgy,tp,0,LOCATION_GRAVE,1,nil) and Duel.SelectYesNo(tp,aux.Stringid(STRING_ID,3)) then Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_XMATERIAL); local og=Duel.SelectMatchingCard(tp,s.oppgy,tp,0,LOCATION_GRAVE,1,1,nil); local x=Duel.SelectMatchingCard(tp,s.xyz,tp,LOCATION_MZONE,0,1,1,nil):GetFirst(); Duel.Overlay(x,og) end end
function s.r6(c) return c:IsFaceup() and c:IsType(TYPE_XYZ) and c:IsRank(6) and c:IsAttribute(ATTRIBUTE_WIND) end
function s.ovtg(e,tp,eg,ep,ev,re,r,rp,chk,chkc) if chkc then return chkc:IsControler(tp) and chkc:IsLocation(LOCATION_MZONE) and s.r6(chkc) end if chk==0 then return Duel.IsExistingTarget(s.r6,tp,LOCATION_MZONE,0,1,nil) end Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_XMATERIAL); Duel.SelectTarget(tp,s.r6,tp,LOCATION_MZONE,0,1,1,nil) end
function s.ovop(e) local c=e:GetHandler(); local tc=Duel.GetFirstTarget(); if c:IsRelateToEffect(e) and tc:IsRelateToEffect(e) then Duel.Overlay(tc,Group.FromCards(c)) end end

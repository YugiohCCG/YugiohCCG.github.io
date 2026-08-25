--Vik the Chinook Aerocat
--Omega references: K9-04 Noroi (c47960073), Overlay Regen (c27068117)
local s,id=GetID(); local STRING_ID=133113182; local SET_AEROCAT=0x3de1
function s.initial_effect(c)
 local e0=Effect.CreateEffect(c); e0:SetDescription(aux.Stringid(STRING_ID,0)); e0:SetType(EFFECT_TYPE_SINGLE); e0:SetCode(EFFECT_SUMMON_PROC); e0:SetProperty(EFFECT_FLAG_CANNOT_DISABLE+EFFECT_FLAG_UNCOPYABLE); e0:SetCondition(s.ntcon); e0:SetOperation(s.ntop); e0:SetValue(SUMMON_TYPE_NORMAL+1); c:RegisterEffect(e0)
 local e1=Effect.CreateEffect(c); e1:SetDescription(aux.Stringid(STRING_ID,1)); e1:SetCategory(CATEGORY_TOHAND+CATEGORY_SEARCH); e1:SetType(EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_O); e1:SetCode(EVENT_SUMMON_SUCCESS); e1:SetProperty(EFFECT_FLAG_DELAY); e1:SetCountLimit(1,id); e1:SetTarget(s.thtg); e1:SetOperation(s.thop); c:RegisterEffect(e1); local e2=e1:Clone(); e2:SetCode(EVENT_SPSUMMON_SUCCESS); c:RegisterEffect(e2)
 local e3=Effect.CreateEffect(c); e3:SetDescription(aux.Stringid(STRING_ID,2)); e3:SetType(EFFECT_TYPE_QUICK_O); e3:SetCode(EVENT_FREE_CHAIN); e3:SetRange(LOCATION_HAND+LOCATION_GRAVE); e3:SetProperty(EFFECT_FLAG_CARD_TARGET); e3:SetCountLimit(1,id+100); e3:SetTarget(s.ovtg); e3:SetOperation(s.ovop); c:RegisterEffect(e3)
end
function s.exf(c) return c:IsSetCard(SET_AEROCAT) and c:IsType(TYPE_XYZ) and not c:IsPublic() end
function s.ntcon(e,c,minc) if c==nil then return true end return minc==0 and Duel.GetLocationCount(c:GetControler(),LOCATION_MZONE)>0 and Duel.IsExistingMatchingCard(s.exf,c:GetControler(),LOCATION_EXTRA,0,1,nil) end
function s.ntop(e,tp) Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_CONFIRM); local g=Duel.SelectMatchingCard(tp,s.exf,tp,LOCATION_EXTRA,0,1,1,nil); Duel.ConfirmCards(1-tp,g) end
function s.thf(c) return c:IsSetCard(SET_AEROCAT) and c:IsType(TYPE_MONSTER) and c:IsAbleToHand() end
function s.thtg(e,tp,eg,ep,ev,re,r,rp,chk) if chk==0 then return Duel.IsExistingMatchingCard(s.thf,tp,LOCATION_DECK,0,1,nil) end Duel.SetOperationInfo(0,CATEGORY_TOHAND,nil,1,tp,LOCATION_DECK) end
function s.thop(e,tp) Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_ATOHAND); local g=Duel.SelectMatchingCard(tp,s.thf,tp,LOCATION_DECK,0,1,1,nil); if #g>0 then Duel.SendtoHand(g,nil,REASON_EFFECT); Duel.ConfirmCards(1-tp,g) end end
function s.xyz(c) return c:IsFaceup() and c:IsType(TYPE_XYZ) and c:IsRank(6) and c:IsAttribute(ATTRIBUTE_WIND) end
function s.ovtg(e,tp,eg,ep,ev,re,r,rp,chk,chkc) if chkc then return chkc:IsControler(tp) and chkc:IsLocation(LOCATION_MZONE) and s.xyz(chkc) end if chk==0 then return Duel.IsExistingTarget(s.xyz,tp,LOCATION_MZONE,0,1,nil) end Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_XMATERIAL); Duel.SelectTarget(tp,s.xyz,tp,LOCATION_MZONE,0,1,1,nil) end
function s.ovop(e) local c=e:GetHandler(); local tc=Duel.GetFirstTarget(); if c:IsRelateToEffect(e) and tc:IsRelateToEffect(e) then Duel.Overlay(tc,Group.FromCards(c)) end end

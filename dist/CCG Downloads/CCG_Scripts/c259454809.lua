--Raven the Lightning II Aerocat
--Omega references: Danger! Bigfoot! (c43316238), Overlay Regen (c27068117)
local s,id=GetID(); local STRING_ID=133454809; local SET_AEROCAT=0x3de1
function s.initial_effect(c)
 local e1=Effect.CreateEffect(c); e1:SetDescription(aux.Stringid(STRING_ID,0)); e1:SetCategory(CATEGORY_SPECIAL_SUMMON); e1:SetType(EFFECT_TYPE_IGNITION); e1:SetRange(LOCATION_HAND); e1:SetCountLimit(1,id); e1:SetCost(s.hcost); e1:SetTarget(s.selftg); e1:SetOperation(s.selfop); c:RegisterEffect(e1)
 local e2=Effect.CreateEffect(c); e2:SetDescription(aux.Stringid(STRING_ID,1)); e2:SetCategory(CATEGORY_SPECIAL_SUMMON); e2:SetType(EFFECT_TYPE_IGNITION); e2:SetRange(LOCATION_MZONE); e2:SetCountLimit(1,id+100); e2:SetTarget(s.sptg); e2:SetOperation(s.spop); c:RegisterEffect(e2)
 local e3=Effect.CreateEffect(c); e3:SetDescription(aux.Stringid(STRING_ID,2)); e3:SetType(EFFECT_TYPE_QUICK_O); e3:SetCode(EVENT_FREE_CHAIN); e3:SetRange(LOCATION_HAND+LOCATION_GRAVE); e3:SetProperty(EFFECT_FLAG_CARD_TARGET); e3:SetCountLimit(1,id+200); e3:SetTarget(s.ovtg); e3:SetOperation(s.ovop); c:RegisterEffect(e3)
end
function s.aero(c) return c:IsSetCard(SET_AEROCAT) end
function s.hcost(e,tp,eg,ep,ev,re,r,rp,chk) if chk==0 then return Duel.IsExistingMatchingCard(s.aero,tp,LOCATION_HAND,0,1,e:GetHandler()) end Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_CONFIRM); local g=Duel.SelectMatchingCard(tp,s.aero,tp,LOCATION_HAND,0,1,1,e:GetHandler()); Duel.ConfirmCards(1-tp,g) end
function s.selftg(e,tp,eg,ep,ev,re,r,rp,chk) if chk==0 then return Duel.GetLocationCount(tp,LOCATION_MZONE)>0 and e:GetHandler():IsCanBeSpecialSummoned(e,0,tp,false,false) end Duel.SetOperationInfo(0,CATEGORY_SPECIAL_SUMMON,e:GetHandler(),1,0,0) end
function s.selfop(e,tp) local c=e:GetHandler(); if c:IsRelateToEffect(e) then Duel.SpecialSummon(c,0,tp,tp,false,false,POS_FACEUP) end local ex=Effect.CreateEffect(c); ex:SetType(EFFECT_TYPE_FIELD); ex:SetCode(EFFECT_CANNOT_SPECIAL_SUMMON); ex:SetProperty(EFFECT_FLAG_PLAYER_TARGET); ex:SetTargetRange(1,0); ex:SetTarget(function(e,c) return c:IsLocation(LOCATION_EXTRA) and not c:IsType(TYPE_XYZ) end); ex:SetReset(RESET_PHASE+PHASE_END); Duel.RegisterEffect(ex,tp) end
function s.spf(c,e,tp) return c:IsSetCard(SET_AEROCAT) and c:IsType(TYPE_MONSTER) and c:IsCanBeSpecialSummoned(e,0,tp,false,false) end
function s.spgroup(tp,e) return Duel.GetMatchingGroup(s.spf,tp,LOCATION_HAND+LOCATION_GRAVE+LOCATION_OVERLAY,0,nil,e,tp) end
function s.sptg(e,tp,eg,ep,ev,re,r,rp,chk) if chk==0 then return Duel.GetLocationCount(tp,LOCATION_MZONE)>0 and #s.spgroup(tp,e)>0 end Duel.SetOperationInfo(0,CATEGORY_SPECIAL_SUMMON,nil,1,tp,LOCATION_HAND+LOCATION_GRAVE+LOCATION_OVERLAY) end
function s.spop(e,tp) if Duel.GetLocationCount(tp,LOCATION_MZONE)<=0 then return end local g=s.spgroup(tp,e); if #g==0 then return end Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_SPSUMMON); local tc=g:Select(tp,1,1,nil):GetFirst(); Duel.SpecialSummon(tc,0,tp,tp,false,false,POS_FACEUP) end
function s.xyz(c) return c:IsFaceup() and c:IsType(TYPE_XYZ) and c:IsRank(6) and c:IsAttribute(ATTRIBUTE_WIND) end
function s.ovtg(e,tp,eg,ep,ev,re,r,rp,chk,chkc) if chkc then return chkc:IsControler(tp) and chkc:IsLocation(LOCATION_MZONE) and s.xyz(chkc) end if chk==0 then return Duel.IsExistingTarget(s.xyz,tp,LOCATION_MZONE,0,1,nil) end Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_XMATERIAL); Duel.SelectTarget(tp,s.xyz,tp,LOCATION_MZONE,0,1,1,nil) end
function s.ovop(e) local c=e:GetHandler(); local tc=Duel.GetFirstTarget(); if c:IsRelateToEffect(e) and tc:IsRelateToEffect(e) then Duel.Overlay(tc,Group.FromCards(c)) end end

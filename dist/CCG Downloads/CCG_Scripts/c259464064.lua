--Egg of the Ashened Demise
--Omega references: Priestess of the Ashened City (c67660909), Salamangreat Gazelle (c26889158)
local s,id=GetID(); local SET_ASHENED=0x1ad; local OBSIDIM=3055018
function s.initial_effect(c)
 aux.AddCodeList(c,3055018)
 local e0=Effect.CreateEffect(c); e0:SetType(EFFECT_TYPE_FIELD); e0:SetCode(EFFECT_SPSUMMON_PROC); e0:SetProperty(EFFECT_FLAG_UNCOPYABLE); e0:SetRange(LOCATION_HAND); e0:SetCountLimit(1,id+EFFECT_COUNT_CODE_OATH); e0:SetCondition(function(e,c) if c==nil then return true end return Duel.IsExistingMatchingCard(Card.IsCode,c:GetControler(),LOCATION_FZONE,LOCATION_FZONE,1,nil,OBSIDIM) end); c:RegisterEffect(e0)
 local e1=Effect.CreateEffect(c); e1:SetCategory(CATEGORY_TOHAND+CATEGORY_SEARCH); e1:SetType(EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_O); e1:SetCode(EVENT_SUMMON_SUCCESS); e1:SetProperty(EFFECT_FLAG_DELAY); e1:SetCountLimit(1,id); e1:SetTarget(s.thtg); e1:SetOperation(s.thop); c:RegisterEffect(e1); local e2=e1:Clone(); e2:SetCode(EVENT_SPSUMMON_SUCCESS); c:RegisterEffect(e2)
 local e3=Effect.CreateEffect(c); e3:SetCategory(CATEGORY_SPECIAL_SUMMON); e3:SetType(EFFECT_TYPE_FIELD+EFFECT_TYPE_TRIGGER_O); e3:SetCode(EVENT_DESTROYED); e3:SetRange(LOCATION_GRAVE); e3:SetProperty(EFFECT_FLAG_DELAY); e3:SetCountLimit(1,id+100); e3:SetCondition(s.spcon); e3:SetTarget(s.sptg); e3:SetOperation(s.spop); c:RegisterEffect(e3)
end
s.listed_names={3055018}
function s.thf(c) return aux.IsCodeListed(c,3055018) and c:IsAbleToHand() end
function s.thtg(e,tp,eg,ep,ev,re,r,rp,chk) if chk==0 then return Duel.IsExistingMatchingCard(s.thf,tp,LOCATION_DECK,0,1,nil) end Duel.SetOperationInfo(0,CATEGORY_TOHAND,nil,1,tp,LOCATION_DECK) end
function s.thop(e,tp) Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_ATOHAND); local g=Duel.SelectMatchingCard(tp,s.thf,tp,LOCATION_DECK,0,1,1,nil); if #g>0 then Duel.SendtoHand(g,nil,REASON_EFFECT); Duel.ConfirmCards(1-tp,g) end end
function s.spcon(e,tp,eg) return eg:IsExists(function(c,tp) return c:IsPreviousControler(tp) and c:IsPreviousLocation(LOCATION_MZONE) and c:IsPreviousPosition(POS_FACEUP) and c:GetPreviousRaceOnField()&RACE_PYRO~=0 and (c:IsReason(REASON_BATTLE) or c:IsReason(REASON_EFFECT) and c:GetReasonPlayer()==1-tp) end,1,nil,tp) end
function s.sptg(e,tp,eg,ep,ev,re,r,rp,chk) if chk==0 then return Duel.GetLocationCount(tp,LOCATION_MZONE)>0 and e:GetHandler():IsCanBeSpecialSummoned(e,0,tp,false,false) end Duel.SetOperationInfo(0,CATEGORY_SPECIAL_SUMMON,e:GetHandler(),1,0,0) end
function s.spop(e,tp) local c=e:GetHandler(); if Duel.GetLocationCount(tp,LOCATION_MZONE)>0 and c:IsRelateToEffect(e) and Duel.SpecialSummon(c,0,tp,tp,false,false,POS_FACEUP)>0 then local ex=Effect.CreateEffect(c); ex:SetType(EFFECT_TYPE_FIELD); ex:SetCode(EFFECT_CANNOT_SPECIAL_SUMMON); ex:SetProperty(EFFECT_FLAG_PLAYER_TARGET); ex:SetTargetRange(1,0); ex:SetTarget(function(e,c) return c:IsLocation(LOCATION_EXTRA) and not c:IsRace(RACE_PYRO) end); ex:SetReset(RESET_PHASE+PHASE_END); Duel.RegisterEffect(ex,tp) end end

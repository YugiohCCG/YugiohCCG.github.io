--Aquamarine Aquasanctuary
--Omega references: c101203067 (attack-target protection), c35550352 (Field Spell structure).
local s,id=GetID()
local SET_AQUAMARINE=0x0f3c
local MSG_ID=132636665
function s.initial_effect(c)
 local e1=Effect.CreateEffect(c)
 e1:SetDescription(aux.Stringid(MSG_ID,0))
 e1:SetCategory(CATEGORY_SEARCH+CATEGORY_TOHAND+CATEGORY_HANDES)
 e1:SetType(EFFECT_TYPE_ACTIVATE)
 e1:SetCode(EVENT_FREE_CHAIN)
 e1:SetCountLimit(1,id+EFFECT_COUNT_CODE_OATH)
 e1:SetOperation(s.actop)
 c:RegisterEffect(e1)
 local e2=Effect.CreateEffect(c)
 e2:SetType(EFFECT_TYPE_FIELD)
 e2:SetCode(EFFECT_CANNOT_DIRECT_ATTACK)
 e2:SetRange(LOCATION_FZONE)
 e2:SetTargetRange(0,LOCATION_MZONE)
 e2:SetCondition(s.protcon)
 c:RegisterEffect(e2)
 local e3=e2:Clone()
 e3:SetCode(EFFECT_CANNOT_SELECT_BATTLE_TARGET)
 e3:SetValue(s.atklimit)
 c:RegisterEffect(e3)
 local e4=Effect.CreateEffect(c)
 e4:SetDescription(aux.Stringid(MSG_ID,1))
 e4:SetCategory(CATEGORY_SPECIAL_SUMMON)
 e4:SetType(EFFECT_TYPE_FIELD+EFFECT_TYPE_TRIGGER_O)
 e4:SetProperty(EFFECT_FLAG_DELAY+EFFECT_FLAG_CARD_TARGET)
 e4:SetCode(EVENT_SPSUMMON_SUCCESS)
 e4:SetRange(LOCATION_FZONE)
 e4:SetCountLimit(1,id+100)
 e4:SetCondition(s.spcon)
 e4:SetTarget(s.sptg)
 e4:SetOperation(s.spop)
 c:RegisterEffect(e4)
end
function s.searchfilter(c)
 return c:IsSetCard(SET_AQUAMARINE) and not c:IsCode(id) and c:IsAbleToHand()
end
function s.actop(e,tp)
 if not Duel.IsExistingMatchingCard(s.searchfilter,tp,LOCATION_DECK,0,1,nil)
  or not Duel.SelectYesNo(tp,aux.Stringid(MSG_ID,2)) then return end
 Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_ATOHAND)
 local g=Duel.SelectMatchingCard(tp,s.searchfilter,tp,LOCATION_DECK,0,1,1,nil)
 if #g==0 or Duel.SendtoHand(g,nil,REASON_EFFECT)==0 then return end
 Duel.ConfirmCards(1-tp,g)
 if Duel.IsExistingMatchingCard(Card.IsDiscardable,tp,LOCATION_HAND,0,1,nil) then
  Duel.DiscardHand(tp,Card.IsDiscardable,1,1,REASON_EFFECT+REASON_DISCARD)
 end
end
function s.highfusion(c)
 return c:IsFaceup() and c:IsSetCard(SET_AQUAMARINE)
  and c:IsType(TYPE_FUSION) and c:IsLevelAbove(7)
end
function s.protcon(e)
 return Duel.IsExistingMatchingCard(s.highfusion,e:GetHandlerPlayer(),LOCATION_MZONE,0,1,nil)
end
function s.atklimit(e,c)
 return not s.highfusion(c)
end
function s.fusionsummoned(c,tp)
 return c:IsFaceup() and c:IsControler(tp) and c:IsSetCard(SET_AQUAMARINE)
  and c:IsType(TYPE_FUSION) and c:IsSummonType(SUMMON_TYPE_FUSION)
end
function s.spcon(e,tp,eg)
 local ph=Duel.GetCurrentPhase()
 return ph~=PHASE_DAMAGE and ph~=PHASE_DAMAGE_CAL
  and eg:IsExists(s.fusionsummoned,1,nil,tp)
end
function s.spfilter(c,e,tp)
 return c:IsSetCard(SET_AQUAMARINE) and c:IsType(TYPE_MONSTER)
  and c:IsCanBeSpecialSummoned(e,0,tp,false,false)
end
function s.sptg(e,tp,eg,ep,ev,re,r,rp,chk,chkc)
 if chkc then return chkc:IsLocation(LOCATION_GRAVE) and chkc:IsControler(tp)
  and s.spfilter(chkc,e,tp) end
 if chk==0 then return Duel.GetLocationCount(tp,LOCATION_MZONE)>0
  and Duel.IsExistingTarget(aux.NecroValleyFilter(s.spfilter),tp,LOCATION_GRAVE,0,1,nil,e,tp) end
 Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_SPSUMMON)
 local g=Duel.SelectTarget(tp,aux.NecroValleyFilter(s.spfilter),tp,LOCATION_GRAVE,0,1,1,nil,e,tp)
 Duel.SetOperationInfo(0,CATEGORY_SPECIAL_SUMMON,g,1,tp,LOCATION_GRAVE)
end
function s.spop(e,tp)
 local tc=Duel.GetFirstTarget()
 if tc and tc:IsRelateToEffect(e) and s.spfilter(tc,e,tp)
  and Duel.GetLocationCount(tp,LOCATION_MZONE)>0 then
  Duel.SpecialSummon(tc,0,tp,tp,false,false,POS_FACEUP)
 end
end

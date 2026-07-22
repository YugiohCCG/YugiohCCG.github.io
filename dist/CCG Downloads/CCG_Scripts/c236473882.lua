local s,id=GetID()
local STRING_ID=132473882
local SET_GALACTICA=0x9c9
local FUSION_INTERGALACTICA=245395343
function s.initial_effect(c)
	aux.AddLinkProcedure(c,aux.FilterBoolFunction(Card.IsType,TYPE_EFFECT),2,3,s.lcheck) c:EnableReviveLimit()
	local e1=Effect.CreateEffect(c) e1:SetDescription(aux.Stringid(STRING_ID,0)) e1:SetCategory(CATEGORY_TOHAND) e1:SetType(EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_O) e1:SetCode(EVENT_SPSUMMON_SUCCESS) e1:SetProperty(EFFECT_FLAG_DELAY) e1:SetCountLimit(1,id) e1:SetCondition(function(e) return e:GetHandler():IsSummonType(SUMMON_TYPE_LINK) end) e1:SetTarget(s.thtg) e1:SetOperation(s.thop) c:RegisterEffect(e1)
	local e2=Effect.CreateEffect(c) e2:SetDescription(aux.Stringid(STRING_ID,1)) e2:SetCategory(CATEGORY_TODECK+CATEGORY_REMOVE+CATEGORY_SPECIAL_SUMMON) e2:SetType(EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_O) e2:SetCode(EVENT_BATTLE_DESTROYING) e2:SetCondition(aux.bdocon) e2:SetCountLimit(1,id+100) e2:SetTarget(s.sptg) e2:SetOperation(s.spop) c:RegisterEffect(e2)
	local e3=e2:Clone() e3:SetCode(EVENT_BATTLE_DAMAGE) e3:SetCondition(function(e,tp,eg,ep) return ep==1-tp end) c:RegisterEffect(e3)
end
function s.lcheck(g) return g:IsExists(Card.IsSetCard,1,nil,SET_GALACTICA) end
function s.thfilter(c) return c:IsCode(FUSION_INTERGALACTICA) and c:IsAbleToHand() end
function s.thtg(e,tp,eg,ep,ev,re,r,rp,chk) if chk==0 then return Duel.IsExistingMatchingCard(aux.NecroValleyFilter(s.thfilter),tp,LOCATION_DECK+LOCATION_GRAVE,0,1,nil) end end
function s.thop(e,tp) Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_ATOHAND) local tc=Duel.SelectMatchingCard(tp,aux.NecroValleyFilter(s.thfilter),tp,LOCATION_DECK+LOCATION_GRAVE,0,1,1,nil):GetFirst() if tc and Duel.SendtoHand(tc,nil,REASON_EFFECT)>0 then Duel.ConfirmCards(1-tp,tc) end end
function s.spfilter(c,e,tp) return c:IsSetCard(SET_GALACTICA) and c:IsType(TYPE_LINK) and c:IsLink(2) and c:IsCanBeSpecialSummoned(e,0,tp,false,false) end
function s.sptg(e,tp,eg,ep,ev,re,r,rp,chk) if chk==0 then return Duel.IsExistingMatchingCard(s.spfilter,tp,LOCATION_EXTRA,0,1,nil,e,tp) end end
function s.spop(e,tp) local c=e:GetHandler() if not c:IsRelateToEffect(e) then return end local op=Duel.SelectOption(tp,aux.Stringid(STRING_ID,2),aux.Stringid(STRING_ID,3)) local ok=op==0 and Duel.SendtoDeck(c,nil,SEQ_DECKSHUFFLE,REASON_EFFECT)>0 or Duel.Remove(c,POS_FACEUP,REASON_EFFECT)>0 if ok then Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_SPSUMMON) local sc=Duel.SelectMatchingCard(tp,s.spfilter,tp,LOCATION_EXTRA,0,1,1,nil,e,tp):GetFirst() if sc then Duel.SpecialSummon(sc,0,tp,tp,false,false,POS_FACEUP) end end end

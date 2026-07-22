local s,id=GetID()
local STRING_ID=133520299
local SET_GALACTICA=0x9c9
local FUSION_INTERGALACTICA=245395343
function s.initial_effect(c)
	aux.AddLinkProcedure(c,aux.FilterBoolFunction(Card.IsType,TYPE_EFFECT),2,2,s.lcheck) c:EnableReviveLimit()
	local e1=Effect.CreateEffect(c) e1:SetDescription(aux.Stringid(STRING_ID,0)) e1:SetCategory(CATEGORY_TOHAND+CATEGORY_SEARCH) e1:SetType(EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_O) e1:SetCode(EVENT_SPSUMMON_SUCCESS) e1:SetProperty(EFFECT_FLAG_DELAY) e1:SetCondition(function(e) return e:GetHandler():IsSummonType(SUMMON_TYPE_LINK) end) e1:SetTarget(s.thtg) e1:SetOperation(s.thop) c:RegisterEffect(e1)
	local e2=Effect.CreateEffect(c) e2:SetDescription(aux.Stringid(STRING_ID,1)) e2:SetCategory(CATEGORY_TODECK+CATEGORY_REMOVE) e2:SetType(EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_O) e2:SetCode(EVENT_BATTLE_DESTROYING) e2:SetCondition(aux.bdocon) e2:SetCountLimit(1,id) e2:SetTarget(s.rmtg) e2:SetOperation(s.rmop) c:RegisterEffect(e2)
	local e3=e2:Clone() e3:SetCode(EVENT_BATTLE_DAMAGE) e3:SetCondition(function(e,tp,eg,ep) return ep==1-tp end) c:RegisterEffect(e3)
end
function s.lcheck(g) return g:IsExists(function(c) return c:IsSetCard(SET_GALACTICA) and c:IsLevel(2) end,1,nil) end
function s.thfilter(c) return c:IsCode(FUSION_INTERGALACTICA) and c:IsAbleToHand() end
function s.thtg(e,tp,eg,ep,ev,re,r,rp,chk) if chk==0 then return Duel.IsExistingMatchingCard(aux.NecroValleyFilter(s.thfilter),tp,LOCATION_DECK+LOCATION_GRAVE,0,1,nil) end Duel.SetOperationInfo(0,CATEGORY_TOHAND,nil,1,tp,LOCATION_DECK+LOCATION_GRAVE) end
function s.thop(e,tp) Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_ATOHAND) local tc=Duel.SelectMatchingCard(tp,aux.NecroValleyFilter(s.thfilter),tp,LOCATION_DECK+LOCATION_GRAVE,0,1,1,nil):GetFirst() if tc and Duel.SendtoHand(tc,nil,REASON_EFFECT)>0 then Duel.ConfirmCards(1-tp,tc) end end
function s.rmfilter(c) return c:IsSetCard(SET_GALACTICA) and c:IsAbleToRemove() end
function s.rmtg(e,tp,eg,ep,ev,re,r,rp,chk) if chk==0 then return Duel.IsExistingMatchingCard(s.rmfilter,tp,LOCATION_DECK,0,1,nil) end end
function s.rmop(e,tp) local c=e:GetHandler() if not c:IsRelateToEffect(e) then return end local op=Duel.SelectOption(tp,aux.Stringid(STRING_ID,2),aux.Stringid(STRING_ID,3)) local ok=op==0 and Duel.SendtoDeck(c,nil,SEQ_DECKSHUFFLE,REASON_EFFECT)>0 or Duel.Remove(c,POS_FACEUP,REASON_EFFECT)>0 if ok then Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_REMOVE) local tc=Duel.SelectMatchingCard(tp,s.rmfilter,tp,LOCATION_DECK,0,1,1,nil):GetFirst() if tc then Duel.Remove(tc,POS_FACEUP,REASON_EFFECT) end end end

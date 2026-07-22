local s,id=GetID()
local STRING_ID=132592047
local SET_SKEWY=0xac74
local COUNTER_CANDY=0x1c2
function s.initial_effect(c)
	local e1=Effect.CreateEffect(c)
	e1:SetDescription(aux.Stringid(STRING_ID,0))
	e1:SetCategory(CATEGORY_TOHAND+CATEGORY_SEARCH+CATEGORY_SPECIAL_SUMMON)
	e1:SetType(EFFECT_TYPE_ACTIVATE)
	e1:SetCode(EVENT_FREE_CHAIN)
	e1:SetCountLimit(1,id+EFFECT_COUNT_CODE_OATH)
	e1:SetTarget(s.target)
	e1:SetOperation(s.activate)
	c:RegisterEffect(e1)
end
function s.thfilter(c)
	return c:IsSetCard(SET_SKEWY) and c:IsType(TYPE_MONSTER) and c:IsAbleToHand()
end
function s.counterfilter(c)
	return c:IsFaceup() and c:GetCounter(COUNTER_CANDY)>0
end
function s.skewyfilter(c)
	return c:IsFaceup() and c:IsSetCard(SET_SKEWY)
end
function s.spfilter(c,e,tp,deckok)
	return c:IsSetCard(SET_SKEWY) and c:IsType(TYPE_MONSTER)
		and (c:IsLocation(LOCATION_HAND) or deckok) and c:IsCanBeSpecialSummoned(e,0,tp,false,false)
end
function s.target(e,tp,eg,ep,ev,re,r,rp,chk)
	local deckok=Duel.IsExistingMatchingCard(s.counterfilter,tp,0,LOCATION_MZONE,1,nil)
		and Duel.IsExistingMatchingCard(s.skewyfilter,tp,LOCATION_MZONE,0,1,nil)
	local b1=Duel.IsExistingMatchingCard(s.thfilter,tp,LOCATION_DECK,0,1,nil)
	local b2=Duel.GetLocationCount(tp,LOCATION_MZONE)>0
		and Duel.IsExistingMatchingCard(s.spfilter,tp,LOCATION_HAND+LOCATION_DECK,0,1,nil,e,tp,deckok)
	if chk==0 then return b1 or b2 end
	local op
	if b1 and b2 then op=Duel.SelectOption(tp,aux.Stringid(STRING_ID,1),aux.Stringid(STRING_ID,2)) elseif b1 then op=0 else op=1 end
	e:SetLabel(op,deckok and 1 or 0)
	if op==0 then Duel.SetOperationInfo(0,CATEGORY_TOHAND,nil,1,tp,LOCATION_DECK)
	else Duel.SetOperationInfo(0,CATEGORY_SPECIAL_SUMMON,nil,1,tp,LOCATION_HAND+LOCATION_DECK) end
end
function s.activate(e,tp,eg,ep,ev,re,r,rp)
	local op,dk=e:GetLabel()
	if op==0 then
		Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_ATOHAND)
		local tc=Duel.SelectMatchingCard(tp,s.thfilter,tp,LOCATION_DECK,0,1,1,nil):GetFirst()
		if tc and Duel.SendtoHand(tc,nil,REASON_EFFECT)>0 then Duel.ConfirmCards(1-tp,tc) end
		return
	end
	if Duel.GetLocationCount(tp,LOCATION_MZONE)<=0 then return end
	local deckok=dk==1 and Duel.IsExistingMatchingCard(s.counterfilter,tp,0,LOCATION_MZONE,1,nil)
		and Duel.IsExistingMatchingCard(s.skewyfilter,tp,LOCATION_MZONE,0,1,nil)
	Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_SPSUMMON)
	local tc=Duel.SelectMatchingCard(tp,s.spfilter,tp,LOCATION_HAND+LOCATION_DECK,0,1,1,nil,e,tp,deckok):GetFirst()
	if tc then Duel.SpecialSummon(tc,0,tp,tp,false,false,POS_FACEUP) end
end

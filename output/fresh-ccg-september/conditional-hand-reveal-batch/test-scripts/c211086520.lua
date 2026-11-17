--Recollection: Static, Lead, and Nerve
local s,id=GetID()
local STRING_ID=133086520
local SET_VIR_PEDICAE_MORTIS=0x39e2
function s.initial_effect(c)
	--Add 1 "Vir Pedicae Mortis" monster, then discard 1 card
	local e1=Effect.CreateEffect(c)
	e1:SetDescription(aux.Stringid(STRING_ID,0))
	e1:SetCategory(CATEGORY_TOHAND+CATEGORY_SEARCH+CATEGORY_HANDES)
	e1:SetType(EFFECT_TYPE_ACTIVATE)
	e1:SetCode(EVENT_FREE_CHAIN)
	if Duel.GetReadyChain then
		e1:SetCountLimit(1,id+EFFECT_COUNT_CODE_OATH)
	else
		e1:SetCountLimit(1,id,1) -- EFFECT_COUNT_CODE_OATH in modern cores
	end
	e1:SetTarget(s.thtg)
	e1:SetOperation(s.thop)
	c:RegisterEffect(e1)
end
s.listed_series={SET_VIR_PEDICAE_MORTIS}
function s.thfilter(c)
	return c:IsSetCard(SET_VIR_PEDICAE_MORTIS) and c:IsType(TYPE_MONSTER) and c:IsAbleToHand()
end
function s.thtg(e,tp,eg,ep,ev,re,r,rp,chk)
	if chk==0 then return Duel.IsExistingMatchingCard(s.thfilter,tp,LOCATION_DECK,0,1,nil) end
	Duel.SetOperationInfo(0,CATEGORY_TOHAND,nil,1,tp,LOCATION_DECK)
	Duel.SetOperationInfo(0,CATEGORY_HANDES,nil,0,tp,1)
end
function s.thop(e,tp,eg,ep,ev,re,r,rp)
	Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_ATOHAND)
	local g=Duel.SelectMatchingCard(tp,s.thfilter,tp,LOCATION_DECK,0,1,1,nil)
	local tc=g:GetFirst()
	if tc and Duel.SendtoHand(tc,nil,REASON_EFFECT)>0
		and tc:IsLocation(LOCATION_HAND) and tc:IsControler(tp) then
		Duel.ConfirmCards(1-tp,tc)
		Duel.ShuffleHand(tp)
		Duel.BreakEffect()
		Duel.DiscardHand(tp,s.effectdiscard,1,1,REASON_EFFECT+REASON_DISCARD)
	end
end

function s.effectdiscard(c)
	return c:IsDiscardable(REASON_EFFECT)
end

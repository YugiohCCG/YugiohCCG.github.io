--Charmelia Fairy Morningstar
local s,id=GetID()
local STRING_ID=133753109
local SET_CHARMELIA=0x12b1
function s.initial_effect(c)
	if c.SetUniqueOnField then
		c:SetUniqueOnField(1,0,id)
	end
	c:EnableReviveLimit()
	--Ritual Summon limit
	local e0=Effect.CreateEffect(c)
	e0:SetType(EFFECT_TYPE_SINGLE)
	e0:SetProperty(EFFECT_FLAG_CANNOT_DISABLE+EFFECT_FLAG_UNCOPYABLE)
	e0:SetCode(EFFECT_SPSUMMON_CONDITION)
	e0:SetValue(aux.ritlimit)
	c:RegisterEffect(e0)
	--Send a Continuous Spell/Trap to negate and destroy opponent's cards
	local e1=Effect.CreateEffect(c)
	e1:SetDescription(aux.Stringid(STRING_ID,0))
	e1:SetCategory(CATEGORY_DISABLE+CATEGORY_DESTROY)
	e1:SetType(EFFECT_TYPE_QUICK_O)
	e1:SetCode(EVENT_FREE_CHAIN)
	e1:SetProperty(EFFECT_FLAG_CARD_TARGET)
	e1:SetRange(LOCATION_MZONE)
	e1:SetHintTiming(0,TIMINGS_CHECK_MONSTER)
	e1:SetCountLimit(1,id)
	e1:SetCost(s.negcost)
	e1:SetTarget(s.negtg)
	e1:SetOperation(s.negop)
	c:RegisterEffect(e1)
	--If sent to the GY: add up to 2 "Charmelia" cards
	local e2=Effect.CreateEffect(c)
	e2:SetDescription(aux.Stringid(STRING_ID,1))
	e2:SetCategory(CATEGORY_TOHAND)
	e2:SetType(EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_O)
	e2:SetCode(EVENT_TO_GRAVE)
	e2:SetProperty(EFFECT_FLAG_DELAY+EFFECT_FLAG_CARD_TARGET)
	e2:SetCountLimit(1,id+100)
	e2:SetTarget(s.thtg)
	e2:SetOperation(s.thop)
	c:RegisterEffect(e2)
end
s.listed_series={SET_CHARMELIA}
function s.costfilter(c)
	return c:IsType(TYPE_CONTINUOUS) and c:IsType(TYPE_SPELL+TYPE_TRAP)
		and c:IsAbleToGraveAsCost() and (c:IsLocation(LOCATION_HAND) or c:IsFaceup())
end
function s.negcost(e,tp,eg,ep,ev,re,r,rp,chk)
	if chk==0 then return Duel.IsExistingMatchingCard(s.costfilter,tp,LOCATION_HAND+LOCATION_ONFIELD,0,1,nil) end
	Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_TOGRAVE)
	local tc=Duel.SelectMatchingCard(tp,s.costfilter,tp,LOCATION_HAND+LOCATION_ONFIELD,0,1,1,nil):GetFirst()
	local ismonster=tc:GetOriginalType()&TYPE_MONSTER~=0 or tc:IsType(TYPE_MONSTER)
	if Duel.SendtoGrave(tc,REASON_COST)>0 and ismonster and tc:IsLocation(LOCATION_GRAVE) then
		local e1=Effect.CreateEffect(e:GetHandler())
		e1:SetType(EFFECT_TYPE_SINGLE)
		e1:SetProperty(EFFECT_FLAG_CANNOT_DISABLE)
		e1:SetCode(EFFECT_CANNOT_TRIGGER)
		e1:SetReset(RESET_EVENT+RESETS_STANDARD+RESET_PHASE+PHASE_END)
		tc:RegisterEffect(e1)
	end
end
function s.negfilter(c,e)
	return aux.NegateAnyFilter(c) and c:IsCanBeEffectTarget(e)
end
function s.negtg(e,tp,eg,ep,ev,re,r,rp,chk,chkc)
	if chkc then return chkc:IsOnField() and chkc:IsControler(1-tp) and s.negfilter(chkc,e) end
	if chk==0 then return Duel.IsExistingTarget(s.negfilter,tp,0,LOCATION_ONFIELD,1,nil,e) end
	Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_TARGET)
	local g=Duel.SelectTarget(tp,s.negfilter,tp,0,LOCATION_ONFIELD,1,2,nil,e)
	Duel.SetOperationInfo(0,CATEGORY_DISABLE,g,#g,0,0)
	Duel.SetOperationInfo(0,CATEGORY_DESTROY,g,#g,0,0)
end
function s.negate_card(tc,c)
	Duel.NegateRelatedChain(tc,RESET_TURN_SET)
	local e1=Effect.CreateEffect(c)
	e1:SetType(EFFECT_TYPE_SINGLE)
	e1:SetCode(EFFECT_DISABLE)
	e1:SetReset(RESET_EVENT+RESETS_STANDARD)
	tc:RegisterEffect(e1)
	local e2=e1:Clone()
	e2:SetCode(EFFECT_DISABLE_EFFECT)
	e2:SetValue(RESET_TURN_SET)
	tc:RegisterEffect(e2)
	if tc:IsType(TYPE_TRAPMONSTER) then
		local e3=e1:Clone()
		e3:SetCode(EFFECT_DISABLE_TRAPMONSTER)
		tc:RegisterEffect(e3)
	end
end
function s.negop(e,tp,eg,ep,ev,re,r,rp)
	local g=Duel.GetChainInfo(0,CHAININFO_TARGET_CARDS):Filter(Card.IsRelateToEffect,nil,e)
	if #g==0 then return end
	local dg=Group.CreateGroup()
	for tc in aux.Next(g) do
		if tc:IsControler(1-tp) and tc:IsFaceup() and tc:IsCanBeDisabledByEffect(e,false) then
			s.negate_card(tc,e:GetHandler())
			dg:AddCard(tc)
		end
	end
	if #dg==0 then return end
	Duel.BreakEffect()
	Duel.Destroy(dg,REASON_EFFECT)
end
function s.thfilter(c,e)
	return c:IsSetCard(SET_CHARMELIA) and c:IsAbleToHand()
		and (not c:IsLocation(LOCATION_REMOVED) or c:IsFaceup())
		and (not e or c:IsCanBeEffectTarget(e))
end
function s.thtg(e,tp,eg,ep,ev,re,r,rp,chk,chkc)
	if chkc then return chkc:IsControler(tp) and chkc:IsLocation(LOCATION_GRAVE+LOCATION_REMOVED)
		and aux.NecroValleyFilter(s.thfilter)(chkc,e) end
	if chk==0 then return Duel.IsExistingTarget(aux.NecroValleyFilter(s.thfilter),tp,
		LOCATION_GRAVE+LOCATION_REMOVED,0,1,nil,e) end
	Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_ATOHAND)
	local g=Duel.SelectTarget(tp,aux.NecroValleyFilter(s.thfilter),tp,
		LOCATION_GRAVE+LOCATION_REMOVED,0,1,2,nil,e)
	Duel.SetOperationInfo(0,CATEGORY_TOHAND,g,#g,0,0)
end
function s.thop(e,tp,eg,ep,ev,re,r,rp)
	local g=Duel.GetChainInfo(0,CHAININFO_TARGET_CARDS)
	if not g then return end
	g=g:Filter(Card.IsRelateToEffect,nil,e)
	g=g:Filter(aux.NecroValleyFilter(s.thfilter),nil,nil)
	if #g>0 then
		Duel.SendtoHand(g,nil,REASON_EFFECT)
		Duel.ConfirmCards(1-tp,g)
	end
end

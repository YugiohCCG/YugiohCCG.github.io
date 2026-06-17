--Reactor Shocker
local s,id=GetID()
function s.initial_effect(c)
	--Activate
	local e1=Effect.CreateEffect(c)
	e1:SetDescription(aux.Stringid(id,0))
	e1:SetCategory(CATEGORY_NEGATE+CATEGORY_DRAW+CATEGORY_TODECK)
	e1:SetType(EFFECT_TYPE_ACTIVATE)
	e1:SetCode(EVENT_CHAINING)
	e1:SetCountLimit(1,id,EFFECT_COUNT_CODE_OATH)
	e1:SetCondition(s.condition)
	e1:SetTarget(s.target)
	e1:SetOperation(s.activate)
	c:RegisterEffect(e1)
end
function s.negatable(ev)
	for i=1,ev do
		if Duel.IsChainNegatable(i) then return true end
	end
	return false
end
function s.hasownchain(tp,ev)
	for i=1,ev-1 do
		local p=Duel.GetChainInfo(i,CHAININFO_TRIGGERING_PLAYER)
		if p==tp then return true end
	end
	return false
end
function s.condition(e,tp,eg,ep,ev,re,r,rp)
	return rp==1-tp and ev>1 and s.hasownchain(tp,ev) and s.negatable(ev)
end
function s.target(e,tp,eg,ep,ev,re,r,rp,chk)
	if chk==0 then return true end
	Duel.SetOperationInfo(0,CATEGORY_NEGATE,nil,1,0,0)
	if Duel.IsPlayerCanDraw(tp,1) then
		Duel.SetOperationInfo(0,CATEGORY_DRAW,nil,0,tp,1)
	end
	Duel.SetChainLimit(aux.FALSE)
end
function s.activate(e,tp,eg,ep,ev,re,r,rp)
	local ownct=1
	local oppct=0
	for i=1,ev do
		local te,p=Duel.GetChainInfo(i,CHAININFO_TRIGGERING_EFFECT,CHAININFO_TRIGGERING_PLAYER)
		if te then
			if p==tp then ownct=ownct+1 else oppct=oppct+1 end
		end
		if Duel.IsChainNegatable(i) then
			Duel.NegateActivation(i)
		end
	end
	if ownct>=oppct and ownct>0 and Duel.IsPlayerCanDraw(tp,ownct) then
		Duel.Draw(tp,ownct,REASON_EFFECT)
	end
	local te,p=Duel.GetChainInfo(1,CHAININFO_TRIGGERING_EFFECT,CHAININFO_TRIGGERING_PLAYER)
	if te and p==tp and Duel.IsExistingMatchingCard(Card.IsAbleToDeck,tp,LOCATION_HAND,0,1,nil) then
		Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_TODECK)
		local g=Duel.SelectMatchingCard(tp,Card.IsAbleToDeck,tp,LOCATION_HAND,0,1,1,nil)
		if #g>0 then
			Duel.SendtoDeck(g,nil,SEQ_DECKBOTTOM,REASON_EFFECT)
		end
	end
end

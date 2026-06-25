--Reactor Shocker
local s,id=GetID()
function s.initial_effect(c)
	--Activate
	local e1=Effect.CreateEffect(c)
	e1:SetDescription(aux.Stringid(id,0))
	e1:SetCategory(CATEGORY_NEGATE+CATEGORY_DRAW+CATEGORY_TODECK)
	e1:SetType(EFFECT_TYPE_ACTIVATE)
	e1:SetCode(EVENT_CHAINING)
	e1:SetCountLimit(1,id+EFFECT_COUNT_CODE_OATH)
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
function s.condition(e,tp,eg,ep,ev,re,r,rp)
	local ownct=0
	local oppct=0
	for i=1,ev do
		local p=Duel.GetChainInfo(i,CHAININFO_TRIGGERING_PLAYER)
		if p==tp then ownct=ownct+1 else oppct=oppct+1 end
	end
	return rp==1-tp and ev>1 and oppct>ownct and s.negatable(ev)
end
function s.target(e,tp,eg,ep,ev,re,r,rp,chk)
	if chk==0 then return true end
	Duel.SetOperationInfo(0,CATEGORY_NEGATE,nil,1,0,0)
	--We don't know exact number to draw here if some cannot be negated, but we can set a max
	--Just drawing is optional here if it depends on negation, but drawing is mandatory if negated
	Duel.SetChainLimit(aux.FALSE)
end
function s.activate(e,tp,eg,ep,ev,re,r,rp)
	local negated_own=0
	for i=1,ev do
		if Duel.NegateActivation(i) then
			local p=Duel.GetChainInfo(i,CHAININFO_TRIGGERING_PLAYER)
			if p==tp then negated_own=negated_own+1 end
		end
	end
	if negated_own>0 and Duel.IsPlayerCanDraw(tp,negated_own) then
		Duel.Draw(tp,negated_own,REASON_EFFECT)
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

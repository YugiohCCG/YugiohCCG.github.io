--Ghost Doll & Midnight Manor
local s,id=GetID()
local STRING_ID=132782750
function s.initial_effect(c)
	--Discard this card; negate the activation
	local e1=Effect.CreateEffect(c)
	e1:SetDescription(aux.Stringid(STRING_ID,0))
	e1:SetCategory(CATEGORY_NEGATE)
	e1:SetType(EFFECT_TYPE_QUICK_O)
	e1:SetCode(EVENT_CHAINING)
	e1:SetRange(LOCATION_HAND)
	e1:SetCountLimit(1,id)
	e1:SetCondition(s.negcon)
	e1:SetCost(s.negcost)
	e1:SetTarget(s.negtg)
	e1:SetOperation(s.negop)
	c:RegisterEffect(e1)
end
function s.loccheck(ev,cat,loc)
	local ex,g,ct,p,l=Duel.GetOperationInfo(ev,cat)
	return ex and ((l and l&loc~=0) or (g and g:IsExists(Card.IsLocation,1,nil,loc)))
end
function s.sploccheck(ev,loc)
	local ex,g,ct,p,l=Duel.GetOperationInfo(ev,CATEGORY_SPECIAL_SUMMON)
	return ex and ((l and l&loc~=0) or (g and g:IsExists(s.spfilter,1,nil,loc)))
end
function s.spfilter(c,loc)
	return c:IsLocation(loc) and c:IsType(TYPE_MONSTER)
end
function s.negcon(e,tp,eg,ep,ev,re,r,rp)
	return Duel.IsChainNegatable(ev)
		and (s.loccheck(ev,CATEGORY_TOHAND,LOCATION_REMOVED)
			or s.loccheck(ev,CATEGORY_TODECK,LOCATION_REMOVED)
			or s.loccheck(ev,CATEGORY_TOEXTRA,LOCATION_REMOVED)
			or s.sploccheck(ev,LOCATION_REMOVED)
			or s.loccheck(ev,CATEGORY_REMOVE,LOCATION_DECK))
end
function s.negcost(e,tp,eg,ep,ev,re,r,rp,chk)
	local c=e:GetHandler()
	if chk==0 then return c:IsDiscardable() end
	Duel.SendtoGrave(c,REASON_COST+REASON_DISCARD)
end
function s.negtg(e,tp,eg,ep,ev,re,r,rp,chk)
	if chk==0 then return true end
	Duel.SetOperationInfo(0,CATEGORY_NEGATE,eg,1,0,0)
end
function s.negop(e,tp,eg,ep,ev,re,r,rp)
	Duel.NegateActivation(ev)
end

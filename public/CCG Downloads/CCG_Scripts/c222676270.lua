--Frozen Girl & Blood Moon
local s,id=GetID()
function s.initial_effect(c)
	--Discard this card; negate that effect
	local e1=Effect.CreateEffect(c)
	e1:SetDescription(aux.Stringid(id,0))
	e1:SetCategory(CATEGORY_DISABLE)
	e1:SetType(EFFECT_TYPE_QUICK_O)
	e1:SetCode(EVENT_CHAINING)
	e1:SetRange(LOCATION_HAND)
	e1:SetCountLimit(1,id)
	e1:SetCondition(s.discon)
	e1:SetCost(s.discost)
	e1:SetTarget(s.distg)
	e1:SetOperation(s.disop)
	c:RegisterEffect(e1)
end
function s.loccheck(ev,cat,loc)
	local ex,g,ct,p,l=Duel.GetOperationInfo(ev,cat)
	return ex and ((l and l&loc~=0) or (g and g:IsExists(Card.IsLocation,1,nil,loc)))
end
function s.eqfilter(c)
	return c:IsType(TYPE_MONSTER)
		or (c:IsType(TYPE_SPELL+TYPE_TRAP) and c:IsLocation(LOCATION_HAND+LOCATION_DECK+LOCATION_GRAVE))
end
function s.eqcheck(ev)
	local ex,g,ct,p,l=Duel.GetOperationInfo(ev,CATEGORY_EQUIP)
	return ex and ((l and l&(LOCATION_HAND+LOCATION_DECK+LOCATION_GRAVE)~=0)
		or (g and g:IsExists(s.eqfilter,1,nil)))
end
function s.discon(e,tp,eg,ep,ev,re,r,rp)
	if not Duel.IsChainDisablable(ev) then return false end
	return s.loccheck(ev,CATEGORY_SSET,LOCATION_HAND+LOCATION_DECK+LOCATION_GRAVE)
		or s.loccheck(ev,CATEGORY_MSET,LOCATION_HAND+LOCATION_DECK+LOCATION_GRAVE)
		or re:IsHasCategory(CATEGORY_SSET) or re:IsHasCategory(CATEGORY_MSET)
		or s.eqcheck(ev) or s.loccheck(ev,CATEGORY_LEAVE_GRAVE,LOCATION_GRAVE)
end
function s.discost(e,tp,eg,ep,ev,re,r,rp,chk)
	local c=e:GetHandler()
	if chk==0 then return c:IsDiscardable() end
	Duel.SendtoGrave(c,REASON_COST+REASON_DISCARD)
end
function s.distg(e,tp,eg,ep,ev,re,r,rp,chk)
	if chk==0 then return true end
	Duel.SetOperationInfo(0,CATEGORY_DISABLE,eg,1,0,0)
end
function s.disop(e,tp,eg,ep,ev,re,r,rp)
	Duel.NegateEffect(ev)
end

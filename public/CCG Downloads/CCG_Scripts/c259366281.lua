--Phlogiston's Roar
local s,id=GetID()
local CARD_PHLOGISTON_DRAGON=242094473
local CARD_PHLOGISTIC_HORDE=230303021
function s.initial_effect(c)
	aux.AddCodeList(c,CARD_PHLOGISTON_DRAGON)
	--Activate the turn it was Set during your turn
	local e0=Effect.CreateEffect(c)
	e0:SetDescription(aux.Stringid(id,0))
	e0:SetType(EFFECT_TYPE_SINGLE)
	e0:SetCode(EFFECT_TRAP_ACT_IN_SET_TURN)
	e0:SetProperty(EFFECT_FLAG_SET_AVAILABLE+EFFECT_FLAG_CANNOT_DISABLE+EFFECT_FLAG_UNCOPYABLE)
	e0:SetCondition(s.actcon)
	c:RegisterEffect(e0)
	--Negate an opponent's monster effect
	local e1=Effect.CreateEffect(c)
	e1:SetDescription(aux.Stringid(id,1))
	e1:SetCategory(CATEGORY_NEGATE)
	e1:SetType(EFFECT_TYPE_ACTIVATE)
	e1:SetCode(EVENT_CHAINING)
	e1:SetCountLimit(1,id)
	e1:SetCondition(s.negcon)
	e1:SetCost(s.negcost)
	e1:SetTarget(s.negtg)
	e1:SetOperation(s.negop)
	c:RegisterEffect(e1)
	--Set this card from the GY
	local e2=Effect.CreateEffect(c)
	e2:SetDescription(aux.Stringid(id,2))
	e2:SetCategory(CATEGORY_SSET)
	e2:SetType(EFFECT_TYPE_FIELD+EFFECT_TYPE_TRIGGER_O)
	e2:SetCode(EVENT_PAY_LPCOST)
	e2:SetRange(LOCATION_GRAVE)
	e2:SetCountLimit(1,id)
	e2:SetCondition(s.setcon)
	e2:SetTarget(s.settg)
	e2:SetOperation(s.setop)
	c:RegisterEffect(e2)
end
function s.actcon(e)
	local c=e:GetHandler()
	return c:IsStatus(STATUS_SET_TURN) and c:IsLocation(LOCATION_ONFIELD) and Duel.GetTurnPlayer()==c:GetControler()
end
function s.phloglower(c,atk)
	return c:IsFaceup() and c:IsCode(CARD_PHLOGISTON_DRAGON,CARD_PHLOGISTIC_HORDE) and c:GetAttack()<atk
end
function s.negcon(e,tp,eg,ep,ev,re,r,rp)
	local rc=re:GetHandler()
	return rp==1-tp and re:IsActiveType(TYPE_MONSTER) and Duel.IsChainNegatable(ev)
		and rc and rc:GetAttack()>0
		and Duel.IsExistingMatchingCard(s.phloglower,tp,LOCATION_MZONE,0,1,nil,rc:GetAttack())
end
function s.lpoptions(tp)
	local t={}
	local lp=Duel.GetLP(tp)
	for v=300,lp-1,300 do
		if Duel.CheckLPCost(tp,v) then
			table.insert(t,v)
		end
	end
	return t
end
function s.negcost(e,tp,eg,ep,ev,re,r,rp,chk)
	local opts=s.lpoptions(tp)
	if chk==0 then return #opts>0 end
	local val=Duel.AnnounceNumber(tp,table.unpack(opts))
	Duel.PayLPCost(tp,val)
end
function s.negtg(e,tp,eg,ep,ev,re,r,rp,chk)
	if chk==0 then return true end
	Duel.SetOperationInfo(0,CATEGORY_NEGATE,eg,1,0,0)
end
function s.negop(e,tp,eg,ep,ev,re,r,rp)
	Duel.NegateEffect(ev)
end
function s.setcon(e,tp,eg,ep,ev,re,r,rp)
	return ep==tp
end
function s.settg(e,tp,eg,ep,ev,re,r,rp,chk)
	local c=e:GetHandler()
	if chk==0 then return Duel.GetLocationCount(tp,LOCATION_SZONE)>0 and c:IsSSetable()
		and aux.NecroValleyFilter(aux.TRUE)(c) end
	Duel.SetOperationInfo(0,CATEGORY_SSET,c,1,tp,LOCATION_GRAVE)
end
function s.setop(e,tp,eg,ep,ev,re,r,rp)
	local c=e:GetHandler()
	if Duel.GetLocationCount(tp,LOCATION_SZONE)<=0 or not c:IsRelateToEffect(e) then return end
	if Duel.SSet(tp,c)>0 then
		local e1=Effect.CreateEffect(c)
		e1:SetType(EFFECT_TYPE_SINGLE)
		e1:SetCode(EFFECT_LEAVE_FIELD_REDIRECT)
		e1:SetProperty(EFFECT_FLAG_CANNOT_DISABLE)
		e1:SetReset(RESET_EVENT+RESETS_REDIRECT)
		e1:SetValue(LOCATION_REMOVED)
		c:RegisterEffect(e1,true)
	end
end

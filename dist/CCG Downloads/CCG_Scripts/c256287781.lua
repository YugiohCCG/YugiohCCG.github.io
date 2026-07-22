--RAGE OF NEPHTHYS
local s,id=GetID()
local STRING_ID=132287781
local SET_NEPHTHYS=0x11f
function s.initial_effect(c)
	--Activate
	local e0=Effect.CreateEffect(c)
	e0:SetType(EFFECT_TYPE_ACTIVATE)
	e0:SetCode(EVENT_FREE_CHAIN)
	c:RegisterEffect(e0)
	--During your opponent's Main Phase: reduce ATK and destroy monsters at 0 ATK
	local e1=Effect.CreateEffect(c)
	e1:SetDescription(aux.Stringid(STRING_ID,0))
	e1:SetCategory(CATEGORY_ATKCHANGE+CATEGORY_DESTROY)
	e1:SetType(EFFECT_TYPE_QUICK_O)
	e1:SetCode(EVENT_FREE_CHAIN)
	e1:SetRange(LOCATION_SZONE)
	e1:SetHintTiming(0,TIMING_MAIN_END)
	e1:SetCountLimit(1,id)
	e1:SetCondition(s.atkcon)
	e1:SetTarget(s.atktg)
	e1:SetOperation(s.atkop)
	c:RegisterEffect(e1)
	--Rewrite an opponent's activated effect
	local e2=Effect.CreateEffect(c)
	e2:SetDescription(aux.Stringid(STRING_ID,1))
	e2:SetType(EFFECT_TYPE_QUICK_O)
	e2:SetCode(EVENT_CHAINING)
	e2:SetRange(LOCATION_SZONE)
	e2:SetCountLimit(1,id+100)
	e2:SetCondition(s.chcon)
	e2:SetCost(s.chcost)
	e2:SetTarget(s.chtg)
	e2:SetOperation(s.chop)
	c:RegisterEffect(e2)
end
s.listed_series={SET_NEPHTHYS}
function s.atkcon(e,tp,eg,ep,ev,re,r,rp)
	return Duel.GetTurnPlayer()==1-tp and Duel.IsMainPhase()
end
function s.nfilter(c)
	return c:IsFaceup() and c:IsSetCard(SET_NEPHTHYS) and c:IsType(TYPE_MONSTER)
end
function s.atktg(e,tp,eg,ep,ev,re,r,rp,chk)
	if chk==0 then return Duel.IsExistingMatchingCard(s.nfilter,tp,LOCATION_MZONE,0,1,nil)
		and Duel.IsExistingMatchingCard(Card.IsFaceup,tp,0,LOCATION_MZONE,1,nil) end
end
function s.atkop(e,tp,eg,ep,ev,re,r,rp)
	local g=Duel.GetMatchingGroup(s.nfilter,tp,LOCATION_MZONE,0,nil)
	if #g==0 then return end
	local val=g:GetMaxGroup(Card.GetAttack):GetFirst():GetAttack()
	if val<=0 then return end
	local og=Duel.GetMatchingGroup(Card.IsFaceup,tp,0,LOCATION_MZONE,nil)
	if #og==0 then return end
	local dg=Group.CreateGroup()
	for tc in aux.Next(og) do
		local preatk=tc:GetAttack()
		local e1=Effect.CreateEffect(e:GetHandler())
		e1:SetType(EFFECT_TYPE_SINGLE)
		e1:SetCode(EFFECT_UPDATE_ATTACK)
		e1:SetValue(-val)
		e1:SetReset(RESET_EVENT+RESETS_STANDARD)
		tc:RegisterEffect(e1)
		if preatk>0 and tc:IsFaceup() and tc:GetAttack()==0 and tc:IsDestructable() then
			dg:AddCard(tc)
		end
	end
	if #dg>0 then
		Duel.BreakEffect()
		Duel.Destroy(dg,REASON_EFFECT)
	end
end
function s.chcon(e,tp,eg,ep,ev,re,r,rp)
	return Duel.GetTurnPlayer()==tp and Duel.IsMainPhase() and rp==1-tp
end
function s.costfilter(c)
	return c:IsSetCard(SET_NEPHTHYS) and c:IsAbleToDeckAsCost()
end
function s.costcheck(g)
	return #g==4
end
function s.chcost(e,tp,eg,ep,ev,re,r,rp,chk)
	local g=Duel.GetMatchingGroup(aux.NecroValleyFilter(s.costfilter),tp,LOCATION_GRAVE,0,nil)
	if chk==0 then return g:CheckSubGroup(s.costcheck,4,4) end
	Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_TODECK)
	local sg=g:SelectSubGroup(tp,s.costcheck,false,4,4)
	if not sg then return end
	Duel.SendtoDeck(sg,nil,SEQ_DECKSHUFFLE,REASON_COST)
end
function s.chop(e,tp,eg,ep,ev,re,r,rp)
	Duel.ChangeTargetCard(ev,Group.CreateGroup())
	Duel.ChangeChainOperation(ev,s.repop)
end
function s.desfilter(c)
	return c:IsSetCard(SET_NEPHTHYS) and c:IsType(TYPE_MONSTER)
		and (c:IsFaceup() or not c:IsOnField()) and c:IsDestructable()
end
function s.chtg(e,tp,eg,ep,ev,re,r,rp,chk)
	if chk==0 then return Duel.IsExistingMatchingCard(s.desfilter,tp,LOCATION_HAND+LOCATION_DECK+LOCATION_ONFIELD,0,1,nil) end
end
function s.repop(e,tp,eg,ep,ev,re,r,rp)
	local p=1-tp
	if not Duel.IsExistingMatchingCard(s.desfilter,p,LOCATION_HAND+LOCATION_DECK+LOCATION_ONFIELD,0,1,nil) then return end
	Duel.Hint(HINT_SELECTMSG,p,HINTMSG_DESTROY)
	local sg=Duel.SelectMatchingCard(p,s.desfilter,p,LOCATION_HAND+LOCATION_DECK+LOCATION_ONFIELD,0,1,1,nil)
	if #sg>0 then
		Duel.Destroy(sg,REASON_EFFECT)
	end
end

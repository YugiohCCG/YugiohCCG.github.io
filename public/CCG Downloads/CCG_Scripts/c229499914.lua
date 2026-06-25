--Sacred Treasure - Chunyin
local s,id=GetID()
local SET_NIUHAO=0xb69
local SACRED_TREASURE_CODES={
	[236542835]=true,
	[229499914]=true,
	[246421842]=true,
}
function s.initial_effect(c)
	--Activate 1 effect
	local e1=Effect.CreateEffect(c)
	e1:SetDescription(aux.Stringid(id,0))
	e1:SetCategory(CATEGORY_POSITION+CATEGORY_REMOVE)
	e1:SetType(EFFECT_TYPE_ACTIVATE)
	e1:SetCode(EVENT_FREE_CHAIN)
	e1:SetCountLimit(1,id+EFFECT_COUNT_CODE_OATH)
	e1:SetCondition(s.condition)
	e1:SetTarget(s.target)
	e1:SetOperation(s.activate)
	c:RegisterEffect(e1)
	--If this card and another "Sacred Treasure" card is banished
	local e2=Effect.CreateEffect(c)
	e2:SetDescription(aux.Stringid(id,3))
	e2:SetCategory(CATEGORY_TOHAND)
	e2:SetType(EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_O)
	e2:SetCode(EVENT_REMOVE)
	e2:SetProperty(EFFECT_FLAG_DELAY+EFFECT_FLAG_CARD_TARGET)
	e2:SetCondition(s.thcon)
	e2:SetTarget(s.thtg)
	e2:SetOperation(s.thop)
	c:RegisterEffect(e2)
end
function s.niufilter(c)
	return c:IsFaceup() and c:IsSetCard(SET_NIUHAO) and c:IsType(TYPE_MONSTER)
end
function s.condition(e,tp,eg,ep,ev,re,r,rp)
	return Duel.IsExistingMatchingCard(s.niufilter,tp,LOCATION_MZONE,0,1,nil)
end
function s.posfilter(c)
	return c:IsFaceup() and c:IsCanTurnSet()
		and not Duel.IsPlayerAffectedByEffect(c:GetControler(),EFFECT_DIVINE_LIGHT)
end
function s.rmfilter(c)
	return c:IsSetCard(SET_NIUHAO) and c:IsType(TYPE_MONSTER) and c:IsAbleToRemove()
end
function s.target(e,tp,eg,ep,ev,re,r,rp,chk)
	local b1=Duel.IsExistingMatchingCard(s.posfilter,tp,LOCATION_MZONE,LOCATION_MZONE,1,nil)
	local g=Duel.GetMatchingGroup(s.rmfilter,tp,LOCATION_DECK,0,nil)
	local b2=g:GetClassCount(Card.GetCode)>=2
	if chk==0 then return b1 or b2 end
	if b1 and b2 then
		e:SetLabel(Duel.SelectOption(tp,aux.Stringid(id,1),aux.Stringid(id,2)))
	elseif b2 then
		e:SetLabel(1)
	else
		e:SetLabel(0)
	end
	if e:GetLabel()==0 then
		Duel.SetOperationInfo(0,CATEGORY_POSITION,nil,1,0,LOCATION_MZONE)
	else
		Duel.SetOperationInfo(0,CATEGORY_REMOVE,nil,2,tp,LOCATION_DECK)
	end
end
function s.activate(e,tp,eg,ep,ev,re,r,rp)
	if not e:GetHandler():IsRelateToEffect(e) then return end
	if e:GetLabel()==0 then
		if not Duel.IsExistingMatchingCard(s.posfilter,tp,LOCATION_MZONE,LOCATION_MZONE,1,nil) then return end
		Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_POSCHANGE)
		local tc=Duel.SelectMatchingCard(tp,s.posfilter,tp,LOCATION_MZONE,LOCATION_MZONE,1,1,nil):GetFirst()
		if tc then
			Duel.ChangePosition(tc,POS_FACEDOWN_DEFENSE)
		end
	else
		local g=Duel.GetMatchingGroup(s.rmfilter,tp,LOCATION_DECK,0,nil)
		if g:GetClassCount(Card.GetCode)<2 then return end
		Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_REMOVE)
		aux.GCheckAdditional=aux.dncheck
		local sg=g:SelectSubGroup(tp,aux.TRUE,false,2,2)
		aux.GCheckAdditional=nil
		if sg and #sg==2 then
			Duel.Remove(sg,POS_FACEUP,REASON_EFFECT)
		end
	end
end
function s.stfilter(c)
	return c:IsFaceup() and SACRED_TREASURE_CODES[c:GetCode()]
end
function s.thcon(e,tp,eg,ep,ev,re,r,rp)
	return eg:IsContains(e:GetHandler()) and eg:IsExists(s.stfilter,1,e:GetHandler())
end
function s.thfilter(c)
	return c:IsAbleToHand()
end
function s.thtg(e,tp,eg,ep,ev,re,r,rp,chk,chkc)
	if chkc then return chkc:IsControler(tp) and chkc:IsLocation(LOCATION_REMOVED) and s.thfilter(chkc) end
	if chk==0 then return Duel.IsExistingTarget(s.thfilter,tp,LOCATION_REMOVED,0,1,nil) end
	Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_ATOHAND)
	local g=Duel.SelectTarget(tp,s.thfilter,tp,LOCATION_REMOVED,0,1,1,nil)
	Duel.SetOperationInfo(0,CATEGORY_TOHAND,g,1,0,0)
end
function s.thop(e,tp,eg,ep,ev,re,r,rp)
	local tc=Duel.GetFirstTarget()
	if tc and tc:IsRelateToEffect(e) and s.thfilter(tc) then
		Duel.SendtoHand(tc,nil,REASON_EFFECT)
	end
end

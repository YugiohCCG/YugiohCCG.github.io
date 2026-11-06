--The Spires of Zephorion Prime
local s,id=GetID()
local STRING_ID=132972185
local SET_ELDORA=0x0738
local CARD_ELDORA_FIELD=214552846
function s.initial_effect(c)
	aux.AddCodeList(c,214552846)
	--Treated as Eldora card
	--Activate
	local e1=Effect.CreateEffect(c)
	e1:SetCategory(CATEGORY_TOHAND+CATEGORY_SEARCH)
	e1:SetType(EFFECT_TYPE_ACTIVATE)
	e1:SetCode(EVENT_FREE_CHAIN)
	e1:SetTarget(s.target)
	e1:SetOperation(s.activate)
	c:RegisterEffect(e1)
	--Treated as Eldora, the Intergalactic Empire
	local e2=Effect.CreateEffect(c)
	e2:SetType(EFFECT_TYPE_SINGLE)
	e2:SetCode(EFFECT_ADD_CODE)
	e2:SetProperty(EFFECT_FLAG_SINGLE_RANGE)
	e2:SetRange(LOCATION_ONFIELD+LOCATION_GRAVE)
	e2:SetValue(CARD_ELDORA_FIELD)
	c:RegisterEffect(e2)
	--Destroy this card after an opponent's effect that would destroy your monster resolves
	local e3=Effect.CreateEffect(c)
	e3:SetType(EFFECT_TYPE_FIELD+EFFECT_TYPE_TRIGGER_O)
	e3:SetCode(EVENT_CHAIN_SOLVED)
	e3:SetRange(LOCATION_SZONE)
	e3:SetCondition(s.descon)
	e3:SetOperation(s.desop)
	c:RegisterEffect(e3)
end
s.listed_series={SET_ELDORA}
s.listed_names={CARD_ELDORA_FIELD}

function s.fieldfilter(c,tp)
	return c:IsCode(CARD_ELDORA_FIELD) and c:GetActivateEffect() and c:GetActivateEffect():IsActivatable(tp,true,true)
end
function s.listfilter(c)
	return c:IsType(TYPE_MONSTER) and c:IsAbleToHand() and aux.IsCodeListed(c,CARD_ELDORA_FIELD)
end
function s.target(e,tp,eg,ep,ev,re,r,rp,chk)
	local b1=Duel.IsExistingMatchingCard(s.fieldfilter,tp,LOCATION_DECK,0,1,nil,tp)
	local b2=Duel.IsExistingMatchingCard(aux.FilterBoolFunction(Card.IsCode,CARD_ELDORA_FIELD),tp,LOCATION_ONFIELD,0,1,nil)
		and Duel.IsExistingMatchingCard(s.listfilter,tp,LOCATION_DECK,0,1,nil)
	if chk==0 then return b1 or b2 end
end
function s.activate(e,tp,eg,ep,ev,re,r,rp)
	if not e:GetHandler():IsRelateToEffect(e) then return end
	local b1=Duel.IsExistingMatchingCard(s.fieldfilter,tp,LOCATION_DECK,0,1,nil,tp)
	local b2=Duel.IsExistingMatchingCard(aux.FilterBoolFunction(Card.IsCode,CARD_ELDORA_FIELD),tp,LOCATION_ONFIELD,0,1,nil)
		and Duel.IsExistingMatchingCard(s.listfilter,tp,LOCATION_DECK,0,1,nil)
	local op=0
	if b1 and b2 then
		op=Duel.SelectOption(tp,aux.Stringid(STRING_ID,0),aux.Stringid(STRING_ID,1))
	elseif b1 then
		op=Duel.SelectOption(tp,aux.Stringid(STRING_ID,0))
	elseif b2 then
		op=Duel.SelectOption(tp,aux.Stringid(STRING_ID,1))+1
	else
		return
	end
	if op==0 then
		Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_TOFIELD)
		local tc=Duel.SelectMatchingCard(tp,s.fieldfilter,tp,LOCATION_DECK,0,1,1,nil,tp):GetFirst()
		if tc then
			local fc=Duel.GetFieldCard(tp,LOCATION_FZONE,0)
			if fc then
				Duel.SendtoGrave(fc,REASON_RULE)
				Duel.BreakEffect()
			end
			Duel.MoveToField(tc,tp,tp,LOCATION_FZONE,POS_FACEUP,true)
			local te=tc:GetActivateEffect()
			te:UseCountLimit(tp,1,true)
			local tep=tc:GetControler()
			local cost=te:GetCost()
			if cost then cost(te,tep,eg,ep,ev,re,r,rp,1) end
			Duel.RaiseEvent(tc,4179255,te,0,tp,tp,Duel.GetCurrentChain())
		end
	else
		Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_ATOHAND)
		local g=Duel.SelectMatchingCard(tp,s.listfilter,tp,LOCATION_DECK,0,1,1,nil)
		if #g>0 then
			Duel.SendtoHand(g,nil,REASON_EFFECT)
			Duel.ConfirmCards(1-tp,g)
		end
	end
end
function s.desfilter(c,tp)
	return (c:IsControler(tp) and c:IsLocation(LOCATION_MZONE))
		or (c:IsPreviousControler(tp) and c:IsPreviousLocation(LOCATION_MZONE))
end
function s.descon(e,tp,eg,ep,ev,re,r,rp)
	if rp==tp then return false end
	local ex,g=Duel.GetOperationInfo(ev,CATEGORY_DESTROY)
	return ex and g and g:IsExists(s.desfilter,1,nil,tp)
end
function s.desop(e,tp,eg,ep,ev,re,r,rp)
	local c=e:GetHandler()
	if c:IsRelateToEffect(e) then
		Duel.Destroy(c,REASON_EFFECT)
	end
end

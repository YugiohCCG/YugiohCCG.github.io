--Talismandrake Pyre
local s,id=GetID()
local SET_TALISMANDRAKE=0xb47
local CARD_ARMS_UNITED=215034223
local CARD_SUPPRESSOR=238136421
local CARD_HALBERD=215921734
local CARD_SABRE=248788543
local CARD_SHIELD=255832330
function s.initial_effect(c)
	c:EnableReviveLimit()
	aux.AddFusionProcFun2(c,s.darkpyro,s.pyro,true)
	--Add or send 1 card from the Deck
	local e1=Effect.CreateEffect(c)
	e1:SetDescription(aux.Stringid(id,0))
	e1:SetCategory(CATEGORY_TOHAND+CATEGORY_SEARCH+CATEGORY_TOGRAVE)
	e1:SetType(EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_O)
	e1:SetProperty(EFFECT_FLAG_DELAY)
	e1:SetCode(EVENT_SPSUMMON_SUCCESS)
	e1:SetCountLimit(1,id+EFFECT_COUNT_CODE_OATH)
	e1:SetTarget(s.thtg)
	e1:SetOperation(s.thop)
	c:RegisterEffect(e1)
	--Destroy a Pendulum Zone card, then place another
	local e2=Effect.CreateEffect(c)
	e2:SetDescription(aux.Stringid(id,1))
	e2:SetCategory(CATEGORY_DESTROY)
	e2:SetType(EFFECT_TYPE_QUICK_O)
	e2:SetCode(EVENT_FREE_CHAIN)
	e2:SetProperty(EFFECT_FLAG_CARD_TARGET)
	e2:SetRange(LOCATION_MZONE)
	e2:SetCountLimit(1,id+100+EFFECT_COUNT_CODE_OATH)
	e2:SetTarget(s.pztg)
	e2:SetOperation(s.pzop)
	c:RegisterEffect(e2)
end
function s.darkpyro(c)
	return c:IsRace(RACE_PYRO) and c:IsFusionAttribute(ATTRIBUTE_DARK)
end
function s.pyro(c)
	return c:IsRace(RACE_PYRO)
end
function s.thfilter(c)
	return c:IsSetCard(SET_TALISMANDRAKE) and c:IsAbleToHand()
end
function s.darkpyrothfilter(c)
	return c:IsType(TYPE_MONSTER) and c:IsRace(RACE_PYRO) and c:IsAttribute(ATTRIBUTE_DARK) and c:IsAbleToHand()
end
function s.armsfilter(c)
	return c:IsSetCard(SET_TALISMANDRAKE) and c:IsType(TYPE_SPELL+TYPE_TRAP)
		and c:IsCode(CARD_ARMS_UNITED,CARD_SUPPRESSOR,CARD_HALBERD,CARD_SABRE,CARD_SHIELD)
end
function s.tgfilter(c)
	return s.armsfilter(c) and c:IsAbleToGrave()
end
function s.thtg(e,tp,eg,ep,ev,re,r,rp,chk)
	if chk==0 then
		return Duel.IsExistingMatchingCard(s.thfilter,tp,LOCATION_DECK,0,1,nil)
			or Duel.IsExistingMatchingCard(s.darkpyrothfilter,tp,LOCATION_DECK,0,1,nil)
			or Duel.IsExistingMatchingCard(s.tgfilter,tp,LOCATION_DECK,0,1,nil)
	end
	Duel.SetOperationInfo(0,CATEGORY_TOHAND,nil,1,tp,LOCATION_DECK)
	Duel.SetOperationInfo(0,CATEGORY_TOGRAVE,nil,1,tp,LOCATION_DECK)
end
function s.thop(e,tp,eg,ep,ev,re,r,rp)
	local opts={}
	local ops={}
	if Duel.IsExistingMatchingCard(s.thfilter,tp,LOCATION_DECK,0,1,nil) then
		table.insert(opts,aux.Stringid(id,2))
		table.insert(ops,1)
	end
	if Duel.IsExistingMatchingCard(s.darkpyrothfilter,tp,LOCATION_DECK,0,1,nil) then
		table.insert(opts,aux.Stringid(id,3))
		table.insert(ops,2)
	end
	if Duel.IsExistingMatchingCard(s.tgfilter,tp,LOCATION_DECK,0,1,nil) then
		table.insert(opts,aux.Stringid(id,4))
		table.insert(ops,3)
	end
	if #ops==0 then return end
	local sel=1
	if #opts==1 then
		Duel.SelectOption(tp,opts[1])
	elseif #opts==2 then
		sel=Duel.SelectOption(tp,opts[1],opts[2])+1
	else
		sel=Duel.SelectOption(tp,opts[1],opts[2],opts[3])+1
	end
	local op=ops[sel]
	if op==1 then
		Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_ATOHAND)
		local g=Duel.SelectMatchingCard(tp,s.thfilter,tp,LOCATION_DECK,0,1,1,nil)
		if #g>0 then
			Duel.SendtoHand(g,nil,REASON_EFFECT)
			Duel.ConfirmCards(1-tp,g)
		end
	elseif op==2 then
		Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_ATOHAND)
		local g=Duel.SelectMatchingCard(tp,s.darkpyrothfilter,tp,LOCATION_DECK,0,1,1,nil)
		if #g>0 then
			Duel.SendtoHand(g,nil,REASON_EFFECT)
			Duel.ConfirmCards(1-tp,g)
		end
	else
		Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_TOGRAVE)
		local g=Duel.SelectMatchingCard(tp,s.tgfilter,tp,LOCATION_DECK,0,1,1,nil)
		if #g>0 then
			Duel.SendtoGrave(g,REASON_EFFECT)
		end
	end
end
function s.pzdesfilter(c,tp)
	return c:IsSetCard(SET_TALISMANDRAKE) and c:IsDestructable()
		and Duel.IsExistingMatchingCard(s.pzplacefilter,tp,LOCATION_HAND+LOCATION_DECK+LOCATION_EXTRA,0,1,nil,c:GetCode())
end
function s.pzplacefilter(c,code)
	return c:IsSetCard(SET_TALISMANDRAKE) and c:IsType(TYPE_PENDULUM) and c:IsType(TYPE_MONSTER)
		and not c:IsCode(code) and (c:IsLocation(LOCATION_HAND+LOCATION_DECK) or c:IsFaceup())
		and not c:IsForbidden()
end
function s.pztg(e,tp,eg,ep,ev,re,r,rp,chk,chkc)
	if chkc then return chkc:IsControler(tp) and chkc:IsLocation(LOCATION_PZONE) and s.pzdesfilter(chkc,tp) end
	if chk==0 then
		return Duel.IsExistingTarget(s.pzdesfilter,tp,LOCATION_PZONE,0,1,nil,tp)
	end
	Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_DESTROY)
	local g=Duel.SelectTarget(tp,s.pzdesfilter,tp,LOCATION_PZONE,0,1,1,nil,tp)
	Duel.SetOperationInfo(0,CATEGORY_DESTROY,g,1,0,0)
end
function s.pzop(e,tp,eg,ep,ev,re,r,rp)
	local tc=Duel.GetFirstTarget()
	if not (tc and tc:IsRelateToEffect(e)) then return end
	local code=tc:GetCode()
	if Duel.Destroy(tc,REASON_EFFECT)>0
		and (Duel.CheckLocation(tp,LOCATION_PZONE,0) or Duel.CheckLocation(tp,LOCATION_PZONE,1))
		and Duel.IsExistingMatchingCard(s.pzplacefilter,tp,LOCATION_HAND+LOCATION_DECK+LOCATION_EXTRA,0,1,nil,code) then
		Duel.BreakEffect()
		Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_TOFIELD)
		local g=Duel.SelectMatchingCard(tp,s.pzplacefilter,tp,LOCATION_HAND+LOCATION_DECK+LOCATION_EXTRA,0,1,1,nil,code)
		local pc=g:GetFirst()
		if pc then
			Duel.MoveToField(pc,tp,tp,LOCATION_PZONE,POS_FACEUP,true)
		end
	end
end

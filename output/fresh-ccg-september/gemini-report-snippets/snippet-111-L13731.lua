--Aquamarine Bubble Surge
local s,id=GetID()
local SET_AQUAMARINE=0xf3c

function s.initial_effect(c)
	--Activate
	local e1=Effect.CreateEffect(c)
	e1:SetType(EFFECT_TYPE_ACTIVATE)
	e1:SetCode(EVENT_FREE_CHAIN)
	e1:SetHintTiming(0,TIMINGS_CHECK_MONSTER+TIMING_MAIN_END)
	c:RegisterEffect(e1)
	--Continuous effect choice
	local e2=Effect.CreateEffect(c)
	e2:SetDescription(aux.Stringid(id,0))
	e2:SetType(EFFECT_TYPE_QUICK_O)
	e2:SetCode(EVENT_FREE_CHAIN)
	e2:SetProperty(EFFECT_FLAG_CARD_TARGET)
	e2:SetRange(LOCATION_SZONE)
	e2:SetCountLimit(1,id)
	e2:SetHintTiming(0,TIMINGS_CHECK_MONSTER+TIMING_MAIN_END)
	e2:SetCondition(s.con)
	e2:SetTarget(s.tg)
	e2:SetOperation(s.op)
	c:RegisterEffect(e2)
end
s.listed_series={SET_AQUAMARINE}

function s.con(e,tp,eg,ep,ev,re,r,rp)
	return Duel.IsMainPhase()
end
function s.ctfilter(c)
	return c:IsFaceup() and c:IsAttribute(ATTRIBUTE_WATER) and c:IsType(TYPE_FUSION)
end
function s.stfilter(c)
	return c:IsType(TYPE_SPELL+TYPE_TRAP)
end
function s.tg(e,tp,eg,ep,ev,re,r,rp,chk,chkc)
	local g=Duel.GetMatchingGroup(s.ctfilter,tp,LOCATION_MZONE,0,nil)
	local ct=g:GetClassCount(Card.GetCode)
	if chkc then
		local op=e:GetLabel()
		if op==1 then
			return chkc:IsLocation(LOCATION_ONFIELD) and chkc:IsControler(1-tp) and s.stfilter(chkc)
		elseif op==2 then
			return chkc:IsLocation(LOCATION_MZONE) and chkc:IsControler(1-tp) and chkc:IsAbleToHand()
		end
		return false
	end
	local b1=ct>0 and Duel.IsExistingTarget(s.stfilter,tp,0,LOCATION_ONFIELD,1,nil)
	local b2=ct>0 and Duel.IsExistingTarget(Card.IsAbleToHand,tp,0,LOCATION_MZONE,1,nil)
	if chk==0 then return b1 or b2 end
	local op=aux.SelectFromOptions(tp,
		{b1,aux.Stringid(id,1),1},
		{b2,aux.Stringid(id,2),2})
	e:SetLabel(op)
	if op==1 then
		e:SetCategory(CATEGORY_DESTROY)
		Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_DESTROY)
		local tg=Duel.SelectTarget(tp,s.stfilter,tp,0,LOCATION_ONFIELD,1,ct,nil)
		Duel.SetOperationInfo(0,CATEGORY_DESTROY,tg,#tg,0,0)
	elseif op==2 then
		e:SetCategory(CATEGORY_TOHAND)
		Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_RTOHAND)
		local tg=Duel.SelectTarget(tp,Card.IsAbleToHand,tp,0,LOCATION_MZONE,1,ct,nil)
		Duel.SetOperationInfo(0,CATEGORY_TOHAND,tg,#tg,0,0)
	end
end
function s.op(e,tp,eg,ep,ev,re,r,rp)
	if not e:GetHandler():IsRelateToEffect(e) then return end
	local op=e:GetLabel()
	local tg=Duel.GetChainInfo(0,CHAININFO_TARGET_CARDS):Filter(Card.IsRelateToEffect,nil,e)
	if #tg==0 then return end
	if op==1 then
		Duel.Destroy(tg,REASON_EFFECT)
	elseif op==2 then
		Duel.SendtoHand(tg,nil,REASON_EFFECT)
	end
end

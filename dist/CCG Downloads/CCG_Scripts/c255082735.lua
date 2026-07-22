--Aquamarine Bubble Surge
local s,id=GetID()
local STRING_ID=133082735
local SET_AQUAMARINE=0xf3c
function s.initial_effect(c)
	--Activate
	local e1=Effect.CreateEffect(c)
	e1:SetType(EFFECT_TYPE_ACTIVATE)
	e1:SetCode(EVENT_FREE_CHAIN)
	c:RegisterEffect(e1)
	--Continuous effect choice
	local e2=Effect.CreateEffect(c)
	e2:SetDescription(aux.Stringid(STRING_ID,0))
	e2:SetType(EFFECT_TYPE_QUICK_O)
	e2:SetCode(EVENT_FREE_CHAIN)
	e2:SetProperty(EFFECT_FLAG_CARD_TARGET)
	e2:SetRange(LOCATION_SZONE)
	e2:SetCountLimit(1,id)
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
function s.tg(e,tp,eg,ep,ev,re,r,rp,chk,chkc)
	local g=Duel.GetMatchingGroup(s.ctfilter,tp,LOCATION_MZONE,0,nil)
	local ct=g:GetClassCount(Card.GetCode)
	if chkc then
		local op=e:GetLabel()
		if op==0 then
			return chkc:IsLocation(LOCATION_SZONE) and chkc:IsControler(1-tp)
		else
			return chkc:IsLocation(LOCATION_MZONE) and chkc:IsControler(1-tp) and chkc:IsAbleToHand()
		end
	end
	if chk==0 then return ct>0 and (Duel.IsExistingMatchingCard(nil,tp,0,LOCATION_SZONE,1,nil)
		or Duel.IsExistingMatchingCard(Card.IsAbleToHand,tp,0,LOCATION_MZONE,1,nil)) end
	-- check options
	local b1=Duel.IsExistingMatchingCard(nil,tp,0,LOCATION_SZONE,1,nil)
	local b2=Duel.IsExistingMatchingCard(Card.IsAbleToHand,tp,0,LOCATION_MZONE,1,nil)
	local op=0
	if b1 and b2 then
		op=Duel.SelectOption(tp,aux.Stringid(STRING_ID,1),aux.Stringid(STRING_ID,2))
	elseif b1 then
		op=Duel.SelectOption(tp,aux.Stringid(STRING_ID,1))
	else
		op=Duel.SelectOption(tp,aux.Stringid(STRING_ID,2))+1
	end
	e:SetLabel(op)
	if op==0 then
		e:SetCategory(CATEGORY_DESTROY)
		Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_DESTROY)
		local tg=Duel.SelectTarget(tp,nil,tp,0,LOCATION_SZONE,1,ct,nil)
		Duel.SetOperationInfo(0,CATEGORY_DESTROY,tg,#tg,0,0)
	else
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
	if op==0 then
		Duel.Destroy(tg,REASON_EFFECT)
	else
		Duel.SendtoHand(tg,nil,REASON_EFFECT)
	end
end

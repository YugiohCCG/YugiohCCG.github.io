--TAKAMA NO HARA
local s,id=GetID()
local STRING_ID=133996802
function s.initial_effect(c)
	--Discard 2 cards including a Spirit monster, then add up to 2 Spirit monsters with different Levels
	local e1=Effect.CreateEffect(c)
	e1:SetDescription(aux.Stringid(STRING_ID,0))
	e1:SetCategory(CATEGORY_HANDES+CATEGORY_TOHAND+CATEGORY_SEARCH)
	e1:SetType(EFFECT_TYPE_ACTIVATE)
	e1:SetCode(EVENT_FREE_CHAIN)
	e1:SetCountLimit(1,id)
	e1:SetTarget(s.thtg)
	e1:SetOperation(s.thop)
	c:RegisterEffect(e1)
	--Banish this card from the GY; keep 1 Spirit monster from returning to the hand by card effect
	local e2=Effect.CreateEffect(c)
	e2:SetDescription(aux.Stringid(STRING_ID,1))
	e2:SetType(EFFECT_TYPE_IGNITION)
	e2:SetProperty(EFFECT_FLAG_CARD_TARGET)
	e2:SetRange(LOCATION_GRAVE)
	e2:SetCountLimit(1,id+100)
	e2:SetCost(aux.bfgcost)
	e2:SetTarget(s.rettg)
	e2:SetOperation(s.retop)
	c:RegisterEffect(e2)
end
function s.discfilter(c)
	return c:IsDiscardable()
end
function s.disccheck(g)
	return #g==2 and g:IsExists(Card.IsType,1,nil,TYPE_SPIRIT)
end
function s.thfilter(c)
	return c:IsType(TYPE_SPIRIT) and c:IsType(TYPE_MONSTER) and c:IsAbleToHand()
end
function s.lvcheck(g)
	return g:GetClassCount(Card.GetLevel)==#g
end
function s.thtg(e,tp,eg,ep,ev,re,r,rp,chk)
	local hg=Duel.GetMatchingGroup(s.discfilter,tp,LOCATION_HAND,0,nil)
	if chk==0 then return hg:CheckSubGroup(s.disccheck,2,2)
		and Duel.IsExistingMatchingCard(s.thfilter,tp,LOCATION_DECK,0,1,nil) end
	Duel.SetOperationInfo(0,CATEGORY_HANDES,nil,0,tp,2)
	Duel.SetOperationInfo(0,CATEGORY_TOHAND,nil,1,tp,LOCATION_DECK)
end
function s.thop(e,tp,eg,ep,ev,re,r,rp)
	local hg=Duel.GetMatchingGroup(s.discfilter,tp,LOCATION_HAND,0,nil)
	if not hg:CheckSubGroup(s.disccheck,2,2) then return end
	Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_DISCARD)
	local dg=hg:SelectSubGroup(tp,s.disccheck,false,2,2)
	if not dg or #dg~=2 then return end
	if Duel.SendtoGrave(dg,REASON_EFFECT+REASON_DISCARD)~=2 then return end
	local g=Duel.GetMatchingGroup(s.thfilter,tp,LOCATION_DECK,0,nil)
	if #g==0 then return end
	Duel.BreakEffect()
	Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_ATOHAND)
	local sg=g:SelectSubGroup(tp,s.lvcheck,false,1,2)
	if sg and #sg>0 and Duel.SendtoHand(sg,nil,REASON_EFFECT)>0 then
		Duel.ConfirmCards(1-tp,sg)
	end
end
function s.retfilter(c)
	return c:IsFaceup() and c:IsType(TYPE_SPIRIT)
end
function s.rettg(e,tp,eg,ep,ev,re,r,rp,chk,chkc)
	if chkc then return chkc:IsControler(tp) and chkc:IsLocation(LOCATION_MZONE) and s.retfilter(chkc) end
	if chk==0 then return Duel.IsExistingTarget(s.retfilter,tp,LOCATION_MZONE,0,1,nil) end
	Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_TARGET)
	Duel.SelectTarget(tp,s.retfilter,tp,LOCATION_MZONE,0,1,1,nil)
end
function s.retop(e,tp,eg,ep,ev,re,r,rp)
	local tc=Duel.GetFirstTarget()
	if not (tc and tc:IsRelateToEffect(e) and tc:IsFaceup()) then return end
	local e1=Effect.CreateEffect(e:GetHandler())
	e1:SetType(EFFECT_TYPE_SINGLE)
	e1:SetProperty(EFFECT_FLAG_CANNOT_DISABLE)
	e1:SetCode(EFFECT_CANNOT_TO_HAND)
	e1:SetValue(1)
	e1:SetReset(RESET_EVENT+RESETS_STANDARD+RESET_PHASE+PHASE_END)
	tc:RegisterEffect(e1)
end

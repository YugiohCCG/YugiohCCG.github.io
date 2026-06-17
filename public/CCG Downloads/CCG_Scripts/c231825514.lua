--NiuHao - Koai
local s,id=GetID()
local SET_NIUHAO=0xb69
local SACRED_TREASURE_CODES={
	[236542835]=true,
	[229499914]=true,
	[246421842]=true,
}
function s.initial_effect(c)
	--Xyz Summon
	aux.AddXyzProcedure(c,aux.FilterBoolFunction(Card.IsRace,RACE_WINDBEAST),1,2,nil,nil,99)
	c:EnableReviveLimit()
	--Materials detached from this card are banished instead
	local e1=Effect.CreateEffect(c)
	e1:SetType(EFFECT_TYPE_FIELD)
	e1:SetCode(EFFECT_TO_GRAVE_REDIRECT)
	e1:SetProperty(EFFECT_FLAG_IGNORE_IMMUNE)
	e1:SetRange(LOCATION_MZONE)
	e1:SetTargetRange(LOCATION_OVERLAY,LOCATION_OVERLAY)
	e1:SetTarget(s.rmtg)
	e1:SetValue(LOCATION_REMOVED)
	c:RegisterEffect(e1)
	--Cannot be targeted by opponent's card effects while it has material
	local e2=Effect.CreateEffect(c)
	e2:SetType(EFFECT_TYPE_SINGLE)
	e2:SetProperty(EFFECT_FLAG_SINGLE_RANGE)
	e2:SetCode(EFFECT_CANNOT_BE_EFFECT_TARGET)
	e2:SetRange(LOCATION_MZONE)
	e2:SetCondition(s.matcon)
	e2:SetValue(aux.tgoval)
	c:RegisterEffect(e2)
	--Detach 1 material; shuffle up to 2 "NiuHao" monsters, then banish "Sacred Treasure" Spells
	local e3=Effect.CreateEffect(c)
	e3:SetDescription(aux.Stringid(id,0))
	e3:SetCategory(CATEGORY_TODECK+CATEGORY_REMOVE)
	e3:SetType(EFFECT_TYPE_QUICK_O)
	e3:SetCode(EVENT_FREE_CHAIN)
	e3:SetRange(LOCATION_MZONE)
	e3:SetHintTiming(0,TIMINGS_CHECK_MONSTER+TIMING_END_PHASE)
	e3:SetProperty(EFFECT_FLAG_CARD_TARGET)
	e3:SetCountLimit(1,id)
	e3:SetCost(s.cost)
	e3:SetTarget(s.target)
	e3:SetOperation(s.operation)
	c:RegisterEffect(e3)
end
function s.rmtg(e,c)
	return c:GetOverlayTarget()==e:GetHandler()
end
function s.matcon(e)
	return e:GetHandler():GetOverlayCount()>0
end
function s.cost(e,tp,eg,ep,ev,re,r,rp,chk)
	local c=e:GetHandler()
	if chk==0 then return c:CheckRemoveOverlayCard(tp,1,REASON_COST) end
	c:RemoveOverlayCard(tp,1,1,REASON_COST)
end
function s.tdfilter(c)
	return c:IsFaceup() and c:IsSetCard(SET_NIUHAO) and c:IsType(TYPE_MONSTER) and c:IsAbleToDeck()
end
function s.rmfilter(c)
	return SACRED_TREASURE_CODES[c:GetCode()] and c:IsType(TYPE_SPELL) and c:IsAbleToRemove()
end
function s.target(e,tp,eg,ep,ev,re,r,rp,chk,chkc)
	if chkc then return chkc:IsControler(tp) and chkc:IsLocation(LOCATION_REMOVED) and s.tdfilter(chkc) end
	if chk==0 then return Duel.IsExistingTarget(s.tdfilter,tp,LOCATION_REMOVED,0,1,nil) end
	Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_TODECK)
	local g=Duel.SelectTarget(tp,s.tdfilter,tp,LOCATION_REMOVED,0,1,2,nil)
	Duel.SetOperationInfo(0,CATEGORY_TODECK,g,#g,0,0)
	Duel.SetOperationInfo(0,CATEGORY_REMOVE,nil,#g,tp,LOCATION_DECK)
end
function s.operation(e,tp,eg,ep,ev,re,r,rp)
	local g=Duel.GetChainInfo(0,CHAININFO_TARGET_CARDS):Filter(Card.IsRelateToEffect,nil,e)
	g=g:Filter(s.tdfilter,nil)
	if #g==0 then return end
	Duel.SendtoDeck(g,nil,SEQ_DECKSHUFFLE,REASON_EFFECT)
	local og=Duel.GetOperatedGroup()
	local ct=og:FilterCount(s.tdctfilter,nil)
	if ct<=0 then return end
	if not Duel.IsExistingMatchingCard(s.rmfilter,tp,LOCATION_DECK,0,1,nil) then return end
	if not Duel.SelectYesNo(tp,aux.Stringid(id,1)) then return end
	Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_REMOVE)
	local rg=Duel.SelectMatchingCard(tp,s.rmfilter,tp,LOCATION_DECK,0,1,ct,nil)
	if #rg>0 then
		Duel.Remove(rg,POS_FACEUP,REASON_EFFECT)
	end
end
function s.tdctfilter(c)
	return c:IsLocation(LOCATION_DECK+LOCATION_EXTRA)
end

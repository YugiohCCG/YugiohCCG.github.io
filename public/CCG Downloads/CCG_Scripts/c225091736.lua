--Stained Bird Bria
local s,id=GetID()
local SET_STAIN=0xbc5
s.listed_series={SET_STAIN}
function s.initial_effect(c)
	Duel.EnableGlobalFlag(GLOBALFLAG_DECK_REVERSE_CHECK)
	--Shuffle this card into the opponent's Deck and add 1 "Stain" card
	local e1=Effect.CreateEffect(c)
	e1:SetDescription(aux.Stringid(id,0))
	e1:SetCategory(CATEGORY_TODECK+CATEGORY_SEARCH+CATEGORY_TOHAND+CATEGORY_DRAW)
	e1:SetType(EFFECT_TYPE_IGNITION)
	e1:SetRange(LOCATION_HAND)
	e1:SetCountLimit(1,id+EFFECT_COUNT_CODE_OATH)
	e1:SetCost(s.thcost)
	e1:SetTarget(s.thtg)
	e1:SetOperation(s.thop)
	c:RegisterEffect(e1)
	--Place 1 card from the GY/banishment on the bottom of the Deck or add it
	local e2=Effect.CreateEffect(c)
	e2:SetDescription(aux.Stringid(id,1))
	e2:SetCategory(CATEGORY_TODECK+CATEGORY_TOHAND)
	e2:SetType(EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_O)
	e2:SetCode(EVENT_SUMMON_SUCCESS)
	e2:SetProperty(EFFECT_FLAG_DELAY+EFFECT_FLAG_CARD_TARGET)
	e2:SetCountLimit(1,id+100+EFFECT_COUNT_CODE_OATH)
	e2:SetTarget(s.bottg)
	e2:SetOperation(s.botop)
	c:RegisterEffect(e2)
	local e3=e2:Clone()
	e3:SetCode(EVENT_SPSUMMON_SUCCESS)
	c:RegisterEffect(e3)
end
function s.faceupoppdeck(c,tp,reason)
	if Duel.SendtoDeck(c,1-tp,SEQ_DECKSHUFFLE,reason)~=0 and c:IsLocation(LOCATION_DECK) then
		Duel.ShuffleDeck(1-tp)
		c:ReverseInDeck()
		return true
	end
	return false
end
function s.costfilter(c,ec)
	return c~=ec and c:IsDiscardable()
end
function s.thcost(e,tp,eg,ep,ev,re,r,rp,chk)
	if chk==0 then return Duel.IsExistingMatchingCard(s.costfilter,tp,LOCATION_HAND,0,1,nil,e:GetHandler()) end
	Duel.DiscardHand(tp,s.costfilter,1,1,REASON_COST+REASON_DISCARD,nil,e:GetHandler())
end
function s.thfilter(c)
	return c:IsSetCard(SET_STAIN) and c:IsAbleToHand()
end
function s.thtg(e,tp,eg,ep,ev,re,r,rp,chk)
	local c=e:GetHandler()
	if chk==0 then return c:IsAbleToDeck() and Duel.IsExistingMatchingCard(s.thfilter,tp,LOCATION_DECK,0,1,nil) end
	Duel.SetOperationInfo(0,CATEGORY_TODECK,c,1,1-tp,LOCATION_HAND)
	Duel.SetOperationInfo(0,CATEGORY_TOHAND,nil,1,tp,LOCATION_DECK)
end
function s.thop(e,tp,eg,ep,ev,re,r,rp)
	local c=e:GetHandler()
	if not (c:IsRelateToEffect(e) and c:IsLocation(LOCATION_HAND)) then return end
	if not s.faceupoppdeck(c,tp,REASON_EFFECT) then return end
	Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_ATOHAND)
	local g=Duel.SelectMatchingCard(tp,s.thfilter,tp,LOCATION_DECK,0,1,1,nil)
	if #g>0 then
		Duel.SendtoHand(g,nil,REASON_EFFECT)
		Duel.ConfirmCards(1-tp,g)
		if Duel.GetFieldGroupCount(tp,0,LOCATION_ONFIELD)>Duel.GetFieldGroupCount(tp,LOCATION_ONFIELD,0)
			and Duel.IsPlayerCanDraw(tp,1) then
			Duel.Draw(tp,1,REASON_EFFECT)
		end
	end
end
function s.ownstain(c,tp)
	return c:IsControler(tp) and c:IsSetCard(SET_STAIN) and c:IsAbleToHand()
end
function s.botfilter(c,tp)
	if c:IsLocation(LOCATION_GRAVE) then
		return (c:IsAbleToDeck() and aux.NecroValleyFilter(Card.IsAbleToDeck)(c))
			or (s.ownstain(c,tp) and aux.NecroValleyFilter(Card.IsAbleToHand)(c))
	end
	return c:IsAbleToDeck() or s.ownstain(c,tp)
end
function s.bottg(e,tp,eg,ep,ev,re,r,rp,chk,chkc)
	if chkc then return chkc:IsLocation(LOCATION_GRAVE+LOCATION_REMOVED) and s.botfilter(chkc,tp) end
	if chk==0 then return Duel.IsExistingTarget(s.botfilter,tp,LOCATION_GRAVE+LOCATION_REMOVED,LOCATION_GRAVE+LOCATION_REMOVED,1,nil,tp) end
	Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_TARGET)
	local g=Duel.SelectTarget(tp,s.botfilter,tp,LOCATION_GRAVE+LOCATION_REMOVED,LOCATION_GRAVE+LOCATION_REMOVED,1,1,nil,tp)
	Duel.SetOperationInfo(0,CATEGORY_TODECK,g,1,0,0)
	Duel.SetOperationInfo(0,CATEGORY_TODECK,e:GetHandler(),1,0,0)
end
function s.botop(e,tp,eg,ep,ev,re,r,rp)
	local c=e:GetHandler()
	local tc=Duel.GetFirstTarget()
	if not (tc and tc:IsRelateToEffect(e)) then return end
	local added=false
	if s.ownstain(tc,tp) and Duel.SelectOption(tp,aux.Stringid(id,2),aux.Stringid(id,3))==1 then
		if tc:IsLocation(LOCATION_GRAVE) and not aux.NecroValleyFilter(Card.IsAbleToHand)(tc) then return end
		if Duel.SendtoHand(tc,nil,REASON_EFFECT)>0 then
			Duel.ConfirmCards(1-tp,tc)
			added=true
		end
	else
		if tc:IsLocation(LOCATION_GRAVE) and not aux.NecroValleyFilter(Card.IsAbleToDeck)(tc) then return end
		if Duel.SendtoDeck(tc,nil,SEQ_DECKBOTTOM,REASON_EFFECT)>0 then
			added=true
		end
	end
	if added and c:IsRelateToEffect(e) then
		s.faceupoppdeck(c,tp,REASON_EFFECT)
	end
end

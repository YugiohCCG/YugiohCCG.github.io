--Eclipse Observer Chandra
local s,id=GetID()
local STRING_ID=133126370
local SET_ECLIPSE=0xf2f4
function s.initial_effect(c)
	c:EnableReviveLimit()
	aux.AddXyzProcedure(c,aux.FilterBoolFunction(Card.IsRace,RACE_SPELLCASTER),8,2)
	--If your opponent draws 2 or more cards, excavate and add 2 cards
	local e1=Effect.CreateEffect(c)
	e1:SetDescription(aux.Stringid(STRING_ID,0))
	e1:SetCategory(CATEGORY_TOHAND+CATEGORY_SEARCH)
	e1:SetType(EFFECT_TYPE_FIELD+EFFECT_TYPE_TRIGGER_O)
	e1:SetCode(EVENT_DRAW)
	e1:SetRange(LOCATION_MZONE)
	e1:SetProperty(EFFECT_FLAG_DELAY)
	e1:SetCountLimit(1,id)
	e1:SetCondition(s.thcon)
	e1:SetCost(s.thcost)
	e1:SetTarget(s.thtg)
	e1:SetOperation(s.thop)
	c:RegisterEffect(e1)
	--Shuffle up to 3 banished cards into the Deck
	local e2=Effect.CreateEffect(c)
	e2:SetDescription(aux.Stringid(STRING_ID,1))
	e2:SetCategory(CATEGORY_TODECK)
	e2:SetType(EFFECT_TYPE_IGNITION)
	e2:SetProperty(EFFECT_FLAG_CARD_TARGET)
	e2:SetRange(LOCATION_MZONE)
	e2:SetCountLimit(1,id+100)
	e2:SetTarget(s.tdtg)
	e2:SetOperation(s.tdop)
	c:RegisterEffect(e2)
	--If sent to the GY, send opponent's cards to the GY
	local e3=Effect.CreateEffect(c)
	e3:SetDescription(aux.Stringid(STRING_ID,2))
	e3:SetCategory(CATEGORY_TOGRAVE+CATEGORY_DRAW)
	e3:SetType(EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_O)
	e3:SetCode(EVENT_TO_GRAVE)
	e3:SetProperty(EFFECT_FLAG_DELAY)
	e3:SetCountLimit(1,id+200)
	e3:SetTarget(s.gytg)
	e3:SetOperation(s.gyop)
	c:RegisterEffect(e3)
end
s.listed_series={SET_ECLIPSE}
function s.thcon(e,tp,eg,ep,ev,re,r,rp)
	e:SetLabel(#eg)
	return ep==1-tp and #eg>=2
end
function s.thcost(e,tp,eg,ep,ev,re,r,rp,chk)
	if chk==0 then return e:GetHandler():CheckRemoveOverlayCard(tp,1,REASON_COST) end
	e:GetHandler():RemoveOverlayCard(tp,1,1,REASON_COST)
end
function s.thtg(e,tp,eg,ep,ev,re,r,rp,chk)
	local ct=e:GetLabel()
	if chk==0 then return Duel.GetFieldGroupCount(tp,LOCATION_DECK,0)>=ct end
	Duel.SetOperationInfo(0,CATEGORY_TOHAND,nil,2,tp,LOCATION_DECK)
end
function s.thop(e,tp,eg,ep,ev,re,r,rp)
	local ct=e:GetLabel()
	if Duel.GetFieldGroupCount(tp,LOCATION_DECK,0)<ct then return end
	Duel.ConfirmDecktop(tp,ct)
	local g=Duel.GetDecktopGroup(tp,ct)
	if #g<2 then return end
	Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_ATOHAND)
	local sg=g:Select(tp,2,2,nil)
	Duel.DisableShuffleCheck()
	Duel.SendtoHand(sg,nil,REASON_EFFECT)
	Duel.ConfirmCards(1-tp,sg)
	Duel.ShuffleDeck(tp)
end
function s.tdfilter(c,e)
	return c:IsFaceup() and c:IsAbleToDeck() and c:IsCanBeEffectTarget(e)
end
function s.tdtg(e,tp,eg,ep,ev,re,r,rp,chk,chkc)
	if chkc then return chkc:IsControler(tp) and chkc:IsLocation(LOCATION_REMOVED)
		and aux.NecroValleyFilter(s.tdfilter)(chkc,e) end
	if chk==0 then return Duel.IsExistingTarget(aux.NecroValleyFilter(s.tdfilter),tp,LOCATION_REMOVED,0,1,nil,e) end
	Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_TODECK)
	local g=Duel.SelectTarget(tp,aux.NecroValleyFilter(s.tdfilter),tp,LOCATION_REMOVED,0,1,3,nil,e)
	Duel.SetOperationInfo(0,CATEGORY_TODECK,g,#g,0,0)
end
function s.tdop(e,tp,eg,ep,ev,re,r,rp)
	local g=Duel.GetChainInfo(0,CHAININFO_TARGET_CARDS):Filter(Card.IsRelateToEffect,nil,e)
	g=g:Filter(aux.NecroValleyFilter(s.tdfilter),nil,e)
	if #g>0 then
		Duel.SendtoDeck(g,nil,SEQ_DECKSHUFFLE,REASON_EFFECT)
	end
end
function s.qpfilter(c)
	return c:IsSetCard(SET_ECLIPSE) and c:IsType(TYPE_QUICKPLAY)
end
function s.gyct(tp)
	local g=Duel.GetMatchingGroup(s.qpfilter,tp,LOCATION_GRAVE,0,nil)
	local codes={}
	local ct=0
	for tc in aux.Next(g) do
		local code=tc:GetCode()
		if not codes[code] then
			codes[code]=true
			ct=ct+1
		end
	end
	return ct
end
function s.maxdraw(tp,ct)
	for i=ct,1,-1 do
		if Duel.IsPlayerCanDraw(1-tp,i) then return i end
	end
	return 0
end
function s.gyfilter(c)
	return c:IsAbleToGrave()
end
function s.gytg(e,tp,eg,ep,ev,re,r,rp,chk)
	local ct=s.maxdraw(tp,math.min(s.gyct(tp),Duel.GetMatchingGroupCount(s.gyfilter,tp,0,LOCATION_ONFIELD,nil)))
	if chk==0 then return ct>0 end
	Duel.SetOperationInfo(0,CATEGORY_TOGRAVE,nil,ct,1-tp,LOCATION_ONFIELD)
	Duel.SetOperationInfo(0,CATEGORY_DRAW,nil,0,1-tp,ct)
end
function s.gyop(e,tp,eg,ep,ev,re,r,rp)
	local max=s.maxdraw(tp,math.min(s.gyct(tp),Duel.GetMatchingGroupCount(s.gyfilter,tp,0,LOCATION_ONFIELD,nil)))
	if max<=0 then return end
	Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_TOGRAVE)
	local g=Duel.SelectMatchingCard(tp,s.gyfilter,tp,0,LOCATION_ONFIELD,1,max,nil)
	local ct=Duel.SendtoGrave(g,REASON_EFFECT)
	if ct>0 then
		Duel.Draw(1-tp,ct,REASON_EFFECT)
	end
end

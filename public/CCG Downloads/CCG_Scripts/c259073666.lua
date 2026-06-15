--Wyvernal Gathering
local s,id=GetID()
local SET_WYVERNAL=0x4714
function s.initial_effect(c)
	--Add 1 "Wyvernal" monster from Deck and send another to GY
	local e1=Effect.CreateEffect(c)
	e1:SetDescription(aux.Stringid(id,0))
	e1:SetCategory(CATEGORY_TOHAND+CATEGORY_SEARCH+CATEGORY_TOGRAVE)
	e1:SetType(EFFECT_TYPE_ACTIVATE)
	e1:SetCode(EVENT_FREE_CHAIN)
	e1:SetCountLimit(1,id+EFFECT_COUNT_CODE_OATH)
	e1:SetTarget(s.target)
	e1:SetOperation(s.activate)
	c:RegisterEffect(e1)
	--GY: banish this card; shuffle Insect monsters into Deck, then draw
	local e2=Effect.CreateEffect(c)
	e2:SetDescription(aux.Stringid(id,1))
	e2:SetCategory(CATEGORY_TODECK+CATEGORY_DRAW)
	e2:SetType(EFFECT_TYPE_IGNITION)
	e2:SetRange(LOCATION_GRAVE)
	e2:SetProperty(EFFECT_FLAG_CARD_TARGET)
	e2:SetCountLimit(1,id+EFFECT_COUNT_CODE_OATH)
	e2:SetCost(aux.bfgcost)
	e2:SetTarget(s.tdtg)
	e2:SetOperation(s.tdop)
	c:RegisterEffect(e2)
end
s.listed_series={SET_WYVERNAL}
function s.takefilter(c)
	return c:IsSetCard(SET_WYVERNAL) and c:IsType(TYPE_MONSTER)
		and (c:IsAbleToHand() or c:IsAbleToGrave())
end
function s.paircheck(g)
	return g:IsExists(Card.IsAbleToHand,1,nil) and g:IsExists(Card.IsAbleToGrave,1,nil)
end
function s.target(e,tp,eg,ep,ev,re,r,rp,chk)
	local g=Duel.GetMatchingGroup(s.takefilter,tp,LOCATION_DECK,0,nil)
	if chk==0 then return g:CheckSubGroup(s.paircheck,2,2) end
	Duel.SetOperationInfo(0,CATEGORY_TOHAND,nil,1,tp,LOCATION_DECK)
	Duel.SetOperationInfo(0,CATEGORY_TOGRAVE,nil,1,tp,LOCATION_DECK)
end
function s.handchoice(c,g)
	local og=g:Clone()
	og:RemoveCard(c)
	return c:IsAbleToHand() and og:IsExists(Card.IsAbleToGrave,1,nil)
end
function s.activate(e,tp,eg,ep,ev,re,r,rp)
	local g=Duel.GetMatchingGroup(s.takefilter,tp,LOCATION_DECK,0,nil)
	if not g:CheckSubGroup(s.paircheck,2,2) then return end
	Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_CONFIRM)
	local sg=g:SelectSubGroup(tp,s.paircheck,false,2,2)
	if not sg or #sg~=2 then return end
	Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_ATOHAND)
	local hg=sg:FilterSelect(tp,s.handchoice,1,1,nil,sg)
	local gg=sg:Clone()
	gg:Sub(hg)
	if #hg>0 then
		Duel.SendtoHand(hg,nil,REASON_EFFECT)
		Duel.ConfirmCards(1-tp,hg)
	end
	if #gg>0 then Duel.SendtoGrave(gg,REASON_EFFECT) end
end
function s.tdfilter(c,e)
	return c:IsRace(RACE_INSECT) and c:IsType(TYPE_MONSTER) and c:IsAbleToDeck()
		and c:IsCanBeEffectTarget(e)
end
function s.tdtg(e,tp,eg,ep,ev,re,r,rp,chk,chkc)
	if chkc then return chkc:IsControler(tp) and chkc:IsLocation(LOCATION_GRAVE)
		and s.tdfilter(chkc,e) end
	if chk==0 then return Duel.IsExistingTarget(aux.NecroValleyFilter(s.tdfilter),tp,LOCATION_GRAVE,0,1,nil,e) end
	Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_TODECK)
	local g=Duel.SelectTarget(tp,aux.NecroValleyFilter(s.tdfilter),tp,LOCATION_GRAVE,0,1,4,nil,e)
	Duel.SetOperationInfo(0,CATEGORY_TODECK,g,#g,tp,LOCATION_GRAVE)
	Duel.SetOperationInfo(0,CATEGORY_DRAW,nil,0,tp,math.floor(#g/2))
end
function s.tdop(e,tp,eg,ep,ev,re,r,rp)
	local g=Duel.GetChainInfo(0,CHAININFO_TARGET_CARDS)
	if not g then return end
	local tg=g:Filter(Card.IsRelateToEffect,nil,e)
	tg=tg:Filter(aux.NecroValleyFilter(),nil)
	if #tg==0 then return end
	if Duel.SendtoDeck(tg,nil,SEQ_DECKSHUFFLE,REASON_EFFECT)==0 then return end
	local og=Duel.GetOperatedGroup()
	local ct=og:FilterCount(Card.IsLocation,nil,LOCATION_DECK+LOCATION_EXTRA)
	if ct>=2 and Duel.IsPlayerCanDraw(tp,math.floor(ct/2)) then
		Duel.BreakEffect()
		Duel.Draw(tp,math.floor(ct/2),REASON_EFFECT)
	end
end

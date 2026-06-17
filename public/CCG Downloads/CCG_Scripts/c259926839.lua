--Eclipse Observer Riley
local s,id=GetID()
local SET_ECLIPSE=0xf2f4
local SET_ECLIPSE_OBSERVER=0xeb17
local CARD_OBSERVATORY=259721372
local OBSERVER_MONSTERS={
	[259652372]=true,
	[259926839]=true,
	[259069729]=true,
	[259487387]=true,
	[259058125]=true,
	[259193076]=true,
	[259126370]=true,
	[259612312]=true,
}
function s.initial_effect(c)
	--Take 1 "Eclipse Observer" card from the Deck
	local e1=Effect.CreateEffect(c)
	e1:SetDescription(aux.Stringid(id,0))
	e1:SetCategory(CATEGORY_TOHAND+CATEGORY_SEARCH+CATEGORY_SPECIAL_SUMMON+CATEGORY_DRAW)
	e1:SetType(EFFECT_TYPE_IGNITION)
	e1:SetRange(LOCATION_MZONE)
	e1:SetCountLimit(1,id)
	e1:SetTarget(s.thtg)
	e1:SetOperation(s.thop)
	c:RegisterEffect(e1)
	--If your opponent draws 2 or more cards, add 1 "Eclipse" Quick-Play Spell from your GY
	local e2=Effect.CreateEffect(c)
	e2:SetDescription(aux.Stringid(id,1))
	e2:SetCategory(CATEGORY_TOHAND)
	e2:SetType(EFFECT_TYPE_FIELD+EFFECT_TYPE_TRIGGER_O)
	e2:SetCode(EVENT_DRAW)
	e2:SetRange(LOCATION_MZONE)
	e2:SetProperty(EFFECT_FLAG_DELAY+EFFECT_FLAG_CARD_TARGET)
	e2:SetCountLimit(1,id+100)
	e2:SetCondition(s.retcon)
	e2:SetTarget(s.rettg)
	e2:SetOperation(s.retop)
	c:RegisterEffect(e2)
end
s.listed_series={SET_ECLIPSE,SET_ECLIPSE_OBSERVER}
function s.isobservermonster(c)
	return c:IsType(TYPE_MONSTER) and (OBSERVER_MONSTERS[c:GetCode()] or c:IsSetCard(SET_ECLIPSE_OBSERVER))
end
function s.isobservercard(c)
	return s.isobservermonster(c) or c:IsSetCard(SET_ECLIPSE_OBSERVER) or c:IsCode(CARD_OBSERVATORY)
end
function s.summonable(c,e,tp)
	return c:IsType(TYPE_MONSTER) and c:IsLevelBelow(4)
		and Duel.GetLocationCount(tp,LOCATION_MZONE)>0
		and Duel.IsPlayerCanDraw(1-tp,2)
		and c:IsCanBeSpecialSummoned(e,0,tp,false,false)
end
function s.deckfilter(c,e,tp)
	return s.isobservercard(c) and (c:IsAbleToHand() or s.summonable(c,e,tp))
end
function s.thtg(e,tp,eg,ep,ev,re,r,rp,chk)
	if chk==0 then return Duel.IsExistingMatchingCard(s.deckfilter,tp,LOCATION_DECK,0,1,nil,e,tp) end
	Duel.SetOperationInfo(0,CATEGORY_TOHAND,nil,1,tp,LOCATION_DECK)
	Duel.SetOperationInfo(0,CATEGORY_SPECIAL_SUMMON,nil,1,tp,LOCATION_DECK)
	Duel.SetOperationInfo(0,CATEGORY_DRAW,nil,0,1-tp,2)
end
function s.thop(e,tp,eg,ep,ev,re,r,rp)
	Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_ATOHAND)
	local tc=Duel.SelectMatchingCard(tp,s.deckfilter,tp,LOCATION_DECK,0,1,1,nil,e,tp):GetFirst()
	if not tc then return end
	local sp=s.summonable(tc,e,tp)
	local add=tc:IsAbleToHand()
	local op=1
	if sp and add then
		op=Duel.SelectOption(tp,aux.Stringid(id,2),aux.Stringid(id,3))+1
	elseif sp then
		op=2
	end
	if op==2 then
		if Duel.SpecialSummon(tc,0,tp,tp,false,false,POS_FACEUP)>0 then
			Duel.Draw(1-tp,2,REASON_EFFECT)
		end
	else
		Duel.SendtoHand(tc,nil,REASON_EFFECT)
		Duel.ConfirmCards(1-tp,tc)
	end
end
function s.retcon(e,tp,eg,ep,ev,re,r,rp)
	return ep==1-tp and #eg>=2 and not (re and re:GetHandler():IsCode(id))
end
function s.qpfilter(c,e)
	return c:IsSetCard(SET_ECLIPSE) and c:IsType(TYPE_QUICKPLAY)
		and c:IsAbleToHand() and c:IsCanBeEffectTarget(e)
end
function s.rettg(e,tp,eg,ep,ev,re,r,rp,chk,chkc)
	if chkc then return chkc:IsControler(tp) and chkc:IsLocation(LOCATION_GRAVE) and aux.NecroValleyFilter(s.qpfilter)(chkc,e) end
	if chk==0 then return Duel.IsExistingTarget(aux.NecroValleyFilter(s.qpfilter),tp,LOCATION_GRAVE,0,1,nil,e) end
	Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_ATOHAND)
	local g=Duel.SelectTarget(tp,aux.NecroValleyFilter(s.qpfilter),tp,LOCATION_GRAVE,0,1,1,nil,e)
	Duel.SetOperationInfo(0,CATEGORY_TOHAND,g,1,0,0)
end
function s.retop(e,tp,eg,ep,ev,re,r,rp)
	local tc=Duel.GetFirstTarget()
	if tc and tc:IsRelateToEffect(e) and aux.NecroValleyFilter(s.qpfilter)(tc,e) then
		Duel.SendtoHand(tc,nil,REASON_EFFECT)
		Duel.ConfirmCards(1-tp,tc)
	end
end

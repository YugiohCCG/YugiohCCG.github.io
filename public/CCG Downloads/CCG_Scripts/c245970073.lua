--A Stainless Story
local s,id=GetID()
local SET_STAIN=0xbc5
local CARD_BRIA=225091736
local CARD_DANTE=216958556
local CARD_FENESS=247499445
local CARD_ROLLO=224822244
local CARD_SILAS=221822671
s.listed_series={SET_STAIN}
s.copy_codes={
	[CARD_BRIA]=true,
	[CARD_DANTE]=true,
	[CARD_FENESS]=true,
	[CARD_ROLLO]=true,
	[CARD_SILAS]=true,
}
function s.initial_effect(c)
	Duel.EnableGlobalFlag(GLOBALFLAG_DECK_REVERSE_CHECK)
	--Send 1 "Stain" monster; apply its Summon effect
	local e1=Effect.CreateEffect(c)
	e1:SetDescription(aux.Stringid(id,0))
	e1:SetCategory(CATEGORY_TOGRAVE)
	e1:SetType(EFFECT_TYPE_ACTIVATE)
	e1:SetCode(EVENT_FREE_CHAIN)
	e1:SetCountLimit(1,id+EFFECT_COUNT_CODE_OATH)
	e1:SetCondition(s.actcon)
	e1:SetTarget(s.tgtg)
	e1:SetOperation(s.tgop)
	c:RegisterEffect(e1)
	--Banish this card; each player draws 1 card
	local e2=Effect.CreateEffect(c)
	e2:SetDescription(aux.Stringid(id,1))
	e2:SetCategory(CATEGORY_DRAW)
	e2:SetType(EFFECT_TYPE_IGNITION)
	e2:SetRange(LOCATION_GRAVE)
	e2:SetCost(aux.bfgcost)
	e2:SetTarget(s.drtg)
	e2:SetOperation(s.drop)
	c:RegisterEffect(e2)
end
function s.actcon(e,tp,eg,ep,ev,re,r,rp)
	return Duel.GetFieldGroupCount(tp,0,LOCATION_ONFIELD)>Duel.GetFieldGroupCount(tp,LOCATION_ONFIELD,0)
end
function s.sendfilter(c,tp)
	return c:IsSetCard(SET_STAIN) and c:IsType(TYPE_MONSTER) and c:IsAbleToGrave()
		and s.copy_codes[c:GetCode()]
end
function s.tgtg(e,tp,eg,ep,ev,re,r,rp,chk)
	if chk==0 then return Duel.IsExistingMatchingCard(s.sendfilter,tp,LOCATION_DECK,0,1,nil,tp) end
	Duel.SetOperationInfo(0,CATEGORY_TOGRAVE,nil,1,tp,LOCATION_DECK)
end
function s.tgop(e,tp,eg,ep,ev,re,r,rp)
	if not Duel.IsExistingMatchingCard(s.sendfilter,tp,LOCATION_DECK,0,1,nil,tp) then return end
	Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_TOGRAVE)
	local tc=Duel.SelectMatchingCard(tp,s.sendfilter,tp,LOCATION_DECK,0,1,1,nil,tp):GetFirst()
	if not tc then return end
	local code=tc:GetCode()
	if Duel.SendtoGrave(tc,REASON_EFFECT)==0 or not tc:IsLocation(LOCATION_GRAVE) then return end
	if code==CARD_BRIA then
		s.briaop(e,tp,tc)
	elseif code==CARD_DANTE then
		s.danteop(e,tp,tc)
	elseif code==CARD_FENESS then
		s.fenessop(e,tp,tc)
	elseif code==CARD_ROLLO then
		s.rolloop(e,tp,tc)
	elseif code==CARD_SILAS then
		s.silasop(e,tp)
	end
end
function s.ownstain(c,tp)
	return c:IsControler(tp) and c:IsSetCard(SET_STAIN) and c:IsAbleToHand()
end
function s.briafilter(c,tp)
	if c:IsLocation(LOCATION_GRAVE) then
		return (c:IsAbleToDeck() and aux.NecroValleyFilter(Card.IsAbleToDeck)(c))
			or (s.ownstain(c,tp) and aux.NecroValleyFilter(Card.IsAbleToHand)(c))
	end
	return c:IsAbleToDeck() or s.ownstain(c,tp)
end
function s.briaop(e,tp,sc)
	if not Duel.IsExistingMatchingCard(s.briafilter,tp,LOCATION_GRAVE+LOCATION_REMOVED,LOCATION_GRAVE+LOCATION_REMOVED,1,nil,tp) then return end
	Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_OPERATECARD)
	local tc=Duel.SelectMatchingCard(tp,s.briafilter,tp,LOCATION_GRAVE+LOCATION_REMOVED,LOCATION_GRAVE+LOCATION_REMOVED,1,1,nil,tp):GetFirst()
	if not tc then return end
	local done=false
	if s.ownstain(tc,tp) and Duel.SelectOption(tp,aux.Stringid(id,2),aux.Stringid(id,3))==0 then
		if tc:IsLocation(LOCATION_GRAVE) and not aux.NecroValleyFilter(Card.IsAbleToHand)(tc) then return end
		if Duel.SendtoHand(tc,nil,REASON_EFFECT)>0 then
			Duel.ConfirmCards(1-tp,tc)
			done=true
		end
	else
		if tc:IsLocation(LOCATION_GRAVE) and not aux.NecroValleyFilter(Card.IsAbleToDeck)(tc) then return end
		done=Duel.SendtoDeck(tc,nil,SEQ_DECKBOTTOM,REASON_EFFECT)>0
	end
	if done and sc:IsLocation(LOCATION_GRAVE) and aux.NecroValleyFilter(Card.IsAbleToDeck)(sc) then
		Duel.SendtoDeck(sc,nil,SEQ_DECKSHUFFLE,REASON_EFFECT)
	end
end
function s.dantefilter(c)
	return c:IsDestructable()
end
function s.danteop(e,tp,sc)
	if not Duel.IsExistingMatchingCard(s.dantefilter,tp,0,LOCATION_ONFIELD,1,nil) then return end
	Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_DESTROY)
	local tc=Duel.SelectMatchingCard(tp,s.dantefilter,tp,0,LOCATION_ONFIELD,1,1,nil):GetFirst()
	if tc and Duel.Destroy(tc,REASON_EFFECT)>0 and sc:IsLocation(LOCATION_GRAVE)
		and aux.NecroValleyFilter(Card.IsAbleToDeck)(sc) then
		Duel.SendtoDeck(sc,nil,SEQ_DECKSHUFFLE,REASON_EFFECT)
	end
end
function s.fenessfilter(c)
	return c:IsFaceup() and aux.NegateAnyFilter(c)
end
function s.fenessop(e,tp,sc)
	if not Duel.IsExistingMatchingCard(s.fenessfilter,tp,LOCATION_ONFIELD,LOCATION_ONFIELD,1,nil) then return end
	Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_FACEUP)
	local tc=Duel.SelectMatchingCard(tp,s.fenessfilter,tp,LOCATION_ONFIELD,LOCATION_ONFIELD,1,1,nil):GetFirst()
	if not (tc and tc:IsFaceup() and aux.NegateAnyFilter(tc)) then return end
	Duel.NegateRelatedChain(tc,RESET_TURN_SET)
	local e1=Effect.CreateEffect(e:GetHandler())
	e1:SetType(EFFECT_TYPE_SINGLE)
	e1:SetCode(EFFECT_DISABLE)
	e1:SetReset(RESET_EVENT+RESETS_STANDARD+RESET_PHASE+PHASE_END)
	tc:RegisterEffect(e1)
	local e2=e1:Clone()
	e2:SetCode(EFFECT_DISABLE_EFFECT)
	tc:RegisterEffect(e2)
	if sc:IsLocation(LOCATION_GRAVE) and aux.NecroValleyFilter(Card.IsAbleToDeck)(sc) then
		Duel.SendtoDeck(sc,nil,SEQ_DECKSHUFFLE,REASON_EFFECT)
	end
end
function s.rollofilter(c,e,tp)
	return ((c:IsControler(tp) and c:IsSetCard(SET_STAIN)) or c:IsControler(1-tp))
		and c:IsType(TYPE_MONSTER) and c:IsCanBeSpecialSummoned(e,0,tp,false,false,POS_FACEUP,tp)
end
function s.rolloop(e,tp,sc)
	if Duel.GetLocationCount(tp,LOCATION_MZONE)<=0 then return end
	if not Duel.IsExistingMatchingCard(aux.NecroValleyFilter(s.rollofilter),tp,LOCATION_GRAVE,LOCATION_GRAVE,1,nil,e,tp) then return end
	Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_SPSUMMON)
	local tc=Duel.SelectMatchingCard(tp,aux.NecroValleyFilter(s.rollofilter),tp,LOCATION_GRAVE,LOCATION_GRAVE,1,1,nil,e,tp):GetFirst()
	if tc and Duel.SpecialSummon(tc,0,tp,tp,false,false,POS_FACEUP)>0
		and sc:IsLocation(LOCATION_GRAVE) and aux.NecroValleyFilter(Card.IsAbleToDeck)(sc) then
		Duel.SendtoDeck(sc,nil,SEQ_DECKSHUFFLE,REASON_EFFECT)
	end
end
function s.silasfilter(c,tp)
	return c:IsSetCard(SET_STAIN) and (c:IsAbleToHand()
		or (c:IsSSetable() and Duel.GetLocationCount(tp,LOCATION_SZONE)>0))
end
function s.silasop(e,tp)
	if not Duel.IsExistingMatchingCard(s.silasfilter,tp,LOCATION_DECK,0,1,nil,tp) then return end
	Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_OPERATECARD)
	local tc=Duel.SelectMatchingCard(tp,s.silasfilter,tp,LOCATION_DECK,0,1,1,nil,tp):GetFirst()
	if not tc then return end
	if tc:IsAbleToHand() and (not (tc:IsSSetable() and Duel.GetLocationCount(tp,LOCATION_SZONE)>0)
		or Duel.SelectOption(tp,aux.Stringid(id,2),aux.Stringid(id,4))==0) then
		if Duel.SendtoHand(tc,nil,REASON_EFFECT)>0 then
			Duel.ConfirmCards(1-tp,tc)
		end
	elseif tc:IsSSetable() and Duel.GetLocationCount(tp,LOCATION_SZONE)>0 then
		Duel.SSet(tp,tc)
	end
end
function s.drtg(e,tp,eg,ep,ev,re,r,rp,chk)
	if chk==0 then return Duel.IsPlayerCanDraw(tp,1) and Duel.IsPlayerCanDraw(1-tp,1) end
	Duel.SetOperationInfo(0,CATEGORY_DRAW,nil,0,PLAYER_ALL,1)
end
function s.drop(e,tp,eg,ep,ev,re,r,rp)
	Duel.Draw(tp,1,REASON_EFFECT)
	Duel.Draw(1-tp,1,REASON_EFFECT)
end

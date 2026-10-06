--A Stainless Story
local s,id=GetID()
local STRING_ID=133970073
local SET_STAIN=0xbc5
local CARD_BRIA=225091736
local CARD_DANTE=216958556
local CARD_FENESS=247499445
local CARD_ROLLO=224822244
local CARD_SILAS=221822671
s.listed_series={SET_STAIN}
function s.initial_effect(c)
	Duel.EnableGlobalFlag(GLOBALFLAG_DECK_REVERSE_CHECK)
	--Send 1 "Stain" monster; apply its Summon effect
	local e1=Effect.CreateEffect(c)
	e1:SetDescription(aux.Stringid(STRING_ID,0))
	e1:SetType(EFFECT_TYPE_ACTIVATE)
	e1:SetCode(EVENT_FREE_CHAIN)
	e1:SetCountLimit(1,id+EFFECT_COUNT_CODE_OATH)
	e1:SetCondition(s.actcon)
	e1:SetCost(s.tgcost)
	e1:SetTarget(s.tgtg)
	e1:SetOperation(s.tgop)
	c:RegisterEffect(e1)
	--Banish this card; each player draws 1 card
	local e2=Effect.CreateEffect(c)
	e2:SetDescription(aux.Stringid(STRING_ID,1))
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
function s.can_apply(c,tp)
	local code=c:GetCode()
	if code==CARD_BRIA then
		return Duel.IsExistingMatchingCard(nil,tp,LOCATION_GRAVE+LOCATION_REMOVED,LOCATION_GRAVE+LOCATION_REMOVED,1,c)
	elseif code==CARD_DANTE then
		return Duel.IsExistingMatchingCard(nil,tp,0,LOCATION_ONFIELD,1,nil)
	elseif code==CARD_FENESS then
		return Duel.IsExistingMatchingCard(Card.IsFaceup,tp,LOCATION_ONFIELD,LOCATION_ONFIELD,1,nil)
	elseif code==CARD_ROLLO then
		return Duel.GetLocationCount(tp,LOCATION_MZONE)>0
			and Duel.IsExistingMatchingCard(Card.IsCanBeSpecialSummoned,tp,LOCATION_GRAVE,LOCATION_GRAVE,1,c,e,0,tp,false,false)
	elseif code==CARD_SILAS then
		return Duel.IsExistingMatchingCard(s.silasfilter,tp,LOCATION_DECK,0,1,nil,tp)
	end
	return false
end
function s.sendfilter(c,tp)
	return (c:IsControler(tp) or c:IsFaceup()) and c:IsSetCard(SET_STAIN)
		and c:IsType(TYPE_MONSTER) and c:IsAbleToGrave() and s.can_apply(c,tp)
end
function s.tgcost(e,tp,eg,ep,ev,re,r,rp,chk)
	if chk==0 then return Duel.IsExistingMatchingCard(s.sendfilter,tp,LOCATION_DECK,LOCATION_DECK,1,nil,tp) end
	Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_TOGRAVE)
	local tc=Duel.SelectMatchingCard(tp,s.sendfilter,tp,LOCATION_DECK,LOCATION_DECK,1,1,nil,tp):GetFirst()
	if not tc then return end
	e:SetLabel(tc:GetCode())
	e:SetLabelObject(tc)
	Duel.SendtoGrave(tc,REASON_COST)
end
function s.tgtg(e,tp,eg,ep,ev,re,r,rp,chk,chkc)
	local code=e:GetLabel()
	if chk==0 then return true end
	if code==CARD_DANTE then
		e:SetCategory(CATEGORY_DESTROY+CATEGORY_TODECK)
		e:SetProperty(EFFECT_FLAG_CARD_TARGET)
		Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_DESTROY)
		local g=Duel.SelectTarget(tp,nil,tp,0,LOCATION_ONFIELD,1,1,nil)
		Duel.SetOperationInfo(0,CATEGORY_DESTROY,g,1,0,0)
	elseif code==CARD_FENESS then
		e:SetCategory(CATEGORY_DISABLE+CATEGORY_TODECK)
		e:SetProperty(EFFECT_FLAG_CARD_TARGET)
		Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_FACEUP)
		local g=Duel.SelectTarget(tp,Card.IsFaceup,tp,LOCATION_ONFIELD,LOCATION_ONFIELD,1,1,e:GetHandler())
		Duel.SetOperationInfo(0,CATEGORY_DISABLE,g,1,0,0)
	elseif code==CARD_ROLLO then
		e:SetCategory(CATEGORY_SPECIAL_SUMMON+CATEGORY_TODECK)
		e:SetProperty(EFFECT_FLAG_CARD_TARGET)
		Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_SPSUMMON)
		local g=Duel.SelectTarget(tp,nil,tp,LOCATION_GRAVE,LOCATION_GRAVE,1,1,nil)
		Duel.SetOperationInfo(0,CATEGORY_SPECIAL_SUMMON,g,1,0,0)
	elseif code==CARD_SILAS then
		e:SetCategory(CATEGORY_SEARCH+CATEGORY_TOHAND)
		e:SetProperty(0)
		Duel.SetOperationInfo(0,CATEGORY_TOHAND,nil,1,tp,LOCATION_DECK)
	end
end
function s.tgop(e,tp,eg,ep,ev,re,r,rp)
	local tc=e:GetLabelObject()
	local code=e:GetLabel()
	if not tc then return end
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
	if c:IsLocation(LOCATION_REMOVED) and not c:IsFaceup() then return false end
	return c:IsAbleToDeck() or s.ownstain(c,tp)
end
function s.briaop(e,tp,sc)
	if not Duel.IsExistingMatchingCard(s.briafilter,tp,LOCATION_GRAVE+LOCATION_REMOVED,LOCATION_GRAVE+LOCATION_REMOVED,1,nil,tp) then return end
	Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_OPERATECARD)
	local tc=Duel.SelectMatchingCard(tp,s.briafilter,tp,LOCATION_GRAVE+LOCATION_REMOVED,LOCATION_GRAVE+LOCATION_REMOVED,1,1,nil,tp):GetFirst()
	if not tc then return end
	local done=false
	if s.ownstain(tc,tp) and Duel.SelectOption(tp,aux.Stringid(STRING_ID,2),aux.Stringid(STRING_ID,3))==0 then
		if aux.NecroValleyFilter()(tc) and Duel.SendtoHand(tc,nil,REASON_EFFECT)>0 then
			Duel.ConfirmCards(1-tp,tc)
			done=true
		end
	else
		if aux.NecroValleyFilter()(tc) then
			done=Duel.SendtoDeck(tc,nil,SEQ_DECKBOTTOM,REASON_EFFECT)>0
		end
	end
	if done and sc:IsLocation(LOCATION_GRAVE) and aux.NecroValleyFilter()(sc) then
		Duel.SendtoDeck(sc,nil,SEQ_DECKSHUFFLE,REASON_EFFECT)
	end
end
function s.danteop(e,tp,sc)
	local tc=Duel.GetFirstTarget()
	if tc and tc:IsRelateToEffect(e) and Duel.Destroy(tc,REASON_EFFECT)>0
		and sc:IsLocation(LOCATION_GRAVE) and aux.NecroValleyFilter()(sc) then
		Duel.SendtoDeck(sc,nil,SEQ_DECKSHUFFLE,REASON_EFFECT)
	end
end
function s.fenessop(e,tp,sc)
	local tc=Duel.GetFirstTarget()
	if not (tc and tc:IsRelateToEffect(e) and tc:IsFaceup()) then return end
	Duel.NegateRelatedChain(tc,RESET_TURN_SET)
	local e1=Effect.CreateEffect(e:GetHandler())
	e1:SetType(EFFECT_TYPE_SINGLE)
	e1:SetProperty(EFFECT_FLAG_CANNOT_DISABLE)
	e1:SetCode(EFFECT_DISABLE)
	e1:SetReset(RESET_EVENT+RESETS_STANDARD+RESET_PHASE+PHASE_END)
	tc:RegisterEffect(e1)
	local e2=e1:Clone()
	e2:SetCode(EFFECT_DISABLE_EFFECT)
	tc:RegisterEffect(e2)
	if sc:IsLocation(LOCATION_GRAVE) and aux.NecroValleyFilter()(sc) then
		Duel.SendtoDeck(sc,nil,SEQ_DECKSHUFFLE,REASON_EFFECT)
	end
end
function s.rolloop(e,tp,sc)
	local tc=Duel.GetFirstTarget()
	if Duel.GetLocationCount(tp,LOCATION_MZONE)<=0 then return end
	if tc and tc:IsRelateToEffect(e) and aux.NecroValleyFilter()(tc)
		and Duel.SpecialSummon(tc,0,tp,tp,false,false,POS_FACEUP)>0
		and sc:IsLocation(LOCATION_GRAVE) and aux.NecroValleyFilter()(sc) then
		Duel.SendtoDeck(sc,nil,SEQ_DECKSHUFFLE,REASON_EFFECT)
	end
end
function s.silasfilter(c,tp)
	return c:IsSetCard(SET_STAIN) and (c:IsAbleToHand()
		or (c:IsSSetable() and Duel.GetLocationCount(tp,LOCATION_SZONE)>0))
end
function s.silasop(e,tp)
	Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_OPERATECARD)
	local tc=Duel.SelectMatchingCard(tp,s.silasfilter,tp,LOCATION_DECK,0,1,1,nil,tp):GetFirst()
	if not tc then return end
	local can_hand=tc:IsAbleToHand()
	local can_set=tc:IsSSetable() and Duel.GetLocationCount(tp,LOCATION_SZONE)>0
	if can_hand and (not can_set or Duel.SelectOption(tp,aux.Stringid(STRING_ID,2),aux.Stringid(STRING_ID,4))==0) then
		Duel.SendtoHand(tc,nil,REASON_EFFECT)
		Duel.ConfirmCards(1-tp,tc)
	elseif can_set then
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

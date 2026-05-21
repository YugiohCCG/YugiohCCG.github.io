--Sorceress of Fire
local s,id=GetID()
local SET_PHLOGISTON=0x0f78
local SET_PHLOGISTIC_UPRISING=0x6f9e
local SET_PHLOGISTON_ROAR=0x4376
local CARD_PHLOGISTON_DRAGON=242094473
local CARD_PHLOGISTIC_HORDE=230303021
function s.initial_effect(c)
	aux.AddCodeList(c,CARD_PHLOGISTON_DRAGON)
	--Shuffle "Phlogist" Spell/Trap Cards, then Special Summon this card
	local e1=Effect.CreateEffect(c)
	e1:SetDescription(aux.Stringid(id,0))
	e1:SetCategory(CATEGORY_TODECK+CATEGORY_SPECIAL_SUMMON)
	e1:SetType(EFFECT_TYPE_IGNITION)
	e1:SetRange(LOCATION_HAND+LOCATION_GRAVE)
	e1:SetTarget(s.sptg)
	e1:SetOperation(s.spop)
	c:RegisterEffect(e1)
	--Discard this card; pay LP; send 1 monster that lists "Phlogiston Dragon"
	local e2=Effect.CreateEffect(c)
	e2:SetDescription(aux.Stringid(id,1))
	e2:SetCategory(CATEGORY_TOGRAVE)
	e2:SetType(EFFECT_TYPE_QUICK_O)
	e2:SetCode(EVENT_FREE_CHAIN)
	e2:SetRange(LOCATION_HAND)
	e2:SetCountLimit(1,id)
	e2:SetCost(s.tgcost)
	e2:SetTarget(s.tgtg)
	e2:SetOperation(s.tgop)
	c:RegisterEffect(e2)
end
function s.phlogst(c)
	return c:IsType(TYPE_SPELL+TYPE_TRAP)
		and (c:IsSetCard(SET_PHLOGISTON) or c:IsSetCard(SET_PHLOGISTIC_UPRISING) or c:IsSetCard(SET_PHLOGISTON_ROAR))
end
function s.tdfilter(c)
	return c:IsFaceupEx() and s.phlogst(c) and c:IsAbleToDeck()
end
function s.sptg(e,tp,eg,ep,ev,re,r,rp,chk)
	local c=e:GetHandler()
	if chk==0 then return Duel.GetLocationCount(tp,LOCATION_MZONE)>0
		and c:IsCanBeSpecialSummoned(e,0,tp,false,false)
		and (not c:IsLocation(LOCATION_GRAVE) or aux.NecroValleyFilter(aux.TRUE)(c))
		and Duel.IsExistingMatchingCard(aux.NecroValleyFilter(s.tdfilter),tp,LOCATION_GRAVE+LOCATION_REMOVED,0,1,nil) end
	Duel.SetOperationInfo(0,CATEGORY_TODECK,nil,1,tp,LOCATION_GRAVE+LOCATION_REMOVED)
	Duel.SetOperationInfo(0,CATEGORY_SPECIAL_SUMMON,c,1,tp,c:GetLocation())
end
function s.spop(e,tp,eg,ep,ev,re,r,rp)
	local c=e:GetHandler()
	Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_TODECK)
	local g=Duel.SelectMatchingCard(tp,aux.NecroValleyFilter(s.tdfilter),tp,LOCATION_GRAVE+LOCATION_REMOVED,0,1,2,nil)
	if #g==0 or Duel.SendtoDeck(g,nil,SEQ_DECKSHUFFLE,REASON_EFFECT)==0 then return end
	if Duel.GetLocationCount(tp,LOCATION_MZONE)>0 and c:IsRelateToEffect(e) then
		Duel.SpecialSummon(c,0,tp,tp,false,false,POS_FACEUP)
	end
end
function s.lpoptions(tp)
	local t={}
	local lp=Duel.GetLP(tp)
	for v=300,lp-1,300 do
		if Duel.CheckLPCost(tp,v) then
			table.insert(t,v)
		end
	end
	return t
end
function s.tgcost(e,tp,eg,ep,ev,re,r,rp,chk)
	local opts=s.lpoptions(tp)
	if chk==0 then return #opts>0 and e:GetHandler():IsDiscardable() end
	Duel.SendtoGrave(e:GetHandler(),REASON_COST+REASON_DISCARD)
	local val=Duel.AnnounceNumber(tp,table.unpack(opts))
	Duel.PayLPCost(tp,val)
end
function s.gyfilter(c)
	return c:IsType(TYPE_MONSTER) and c:IsAbleToGrave()
		and (c:IsCode(CARD_PHLOGISTON_DRAGON,CARD_PHLOGISTIC_HORDE) or aux.IsCodeListed(c,CARD_PHLOGISTON_DRAGON))
end
function s.tgtg(e,tp,eg,ep,ev,re,r,rp,chk)
	if chk==0 then return Duel.IsExistingMatchingCard(s.gyfilter,tp,LOCATION_DECK,0,1,nil) end
	Duel.SetOperationInfo(0,CATEGORY_TOGRAVE,nil,1,tp,LOCATION_DECK)
end
function s.tgop(e,tp,eg,ep,ev,re,r,rp)
	Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_TOGRAVE)
	local g=Duel.SelectMatchingCard(tp,s.gyfilter,tp,LOCATION_DECK,0,1,1,nil)
	if #g>0 then
		Duel.SendtoGrave(g,REASON_EFFECT)
	end
	local e1=Effect.CreateEffect(e:GetHandler())
	e1:SetType(EFFECT_TYPE_FIELD)
	e1:SetProperty(EFFECT_FLAG_PLAYER_TARGET)
	e1:SetCode(EFFECT_CANNOT_SPECIAL_SUMMON)
	e1:SetTargetRange(1,0)
	e1:SetTarget(s.splimit)
	e1:SetReset(RESET_PHASE+PHASE_END)
	Duel.RegisterEffect(e1,tp)
end
function s.splimit(e,c)
	return not c:IsAttribute(ATTRIBUTE_FIRE)
end

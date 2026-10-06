--Talismandrake Cremation
--Cleaned and audited replacement script for YGO Omega
local s,id=GetID()
local SET_TALISMANDRAKE_ARMS=0x452f
function s.initial_effect(c)
	c:EnableReviveLimit()
	aux.AddFusionProcFun2(c,s.darkpyro,s.lv5dark,true)
	--On Special Summon: Add or equip 1 "Talismandrake Arms" Spell/Trap from Deck or GY
	local e1=Effect.CreateEffect(c)
	e1:SetDescription(aux.Stringid(id,0))
	e1:SetCategory(CATEGORY_TOHAND+CATEGORY_SEARCH+CATEGORY_EQUIP)
	e1:SetType(EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_O)
	e1:SetProperty(EFFECT_FLAG_DELAY)
	e1:SetCode(EVENT_SPSUMMON_SUCCESS)
	e1:SetCountLimit(1,id)
	e1:SetTarget(s.armstg)
	e1:SetOperation(s.armsop)
	c:RegisterEffect(e1)
	--Quick Effect: Shuffle up to 3 cards from either player's GY or banishment into Deck
	local e2=Effect.CreateEffect(c)
	e2:SetDescription(aux.Stringid(id,1))
	e2:SetCategory(CATEGORY_TODECK)
	e2:SetType(EFFECT_TYPE_QUICK_O)
	e2:SetCode(EVENT_FREE_CHAIN)
	e2:SetRange(LOCATION_MZONE)
	e2:SetHintTiming(0,TIMINGS_CHECK_MONSTER+TIMING_END_PHASE)
	e2:SetCountLimit(1,{id,1})
	e2:SetCondition(s.tdcon)
	e2:SetTarget(s.tdtg)
	e2:SetOperation(s.tdop)
	c:RegisterEffect(e2)
end
s.listed_series={SET_TALISMANDRAKE_ARMS}

function s.darkpyro(c)
	return c:IsRace(RACE_PYRO) and c:IsFusionAttribute(ATTRIBUTE_DARK)
end
function s.lv5dark(c)
	return c:IsFusionAttribute(ATTRIBUTE_DARK) and c:IsLevelAbove(5)
end
function s.armsfilter(c)
	return c:IsSetCard(SET_TALISMANDRAKE_ARMS) and c:IsType(TYPE_SPELL+TYPE_TRAP) and not c:IsForbidden()
end
function s.thfilter(c)
	return s.armsfilter(c) and c:IsAbleToHand()
end
function s.eqmonster(c)
	return c:IsFaceup() and c:IsRace(RACE_PYRO) and c:IsAttribute(ATTRIBUTE_DARK)
end
function s.armstg(e,tp,eg,ep,ev,re,r,rp,chk)
	local b1=Duel.IsExistingMatchingCard(aux.NecroValleyFilter(s.thfilter),tp,LOCATION_DECK+LOCATION_GRAVE,0,1,nil)
	local b2=Duel.GetLocationCount(tp,LOCATION_SZONE)>0
		and Duel.IsExistingMatchingCard(aux.NecroValleyFilter(s.armsfilter),tp,LOCATION_DECK+LOCATION_GRAVE,0,1,nil)
		and Duel.IsExistingMatchingCard(s.eqmonster,tp,LOCATION_MZONE,0,1,nil)
	if chk==0 then return b1 or b2 end
	Duel.SetPossibleOperationInfo(0,CATEGORY_TOHAND,nil,1,tp,LOCATION_DECK+LOCATION_GRAVE)
	Duel.SetPossibleOperationInfo(0,CATEGORY_EQUIP,nil,1,tp,LOCATION_DECK+LOCATION_GRAVE)
end
function s.armsop(e,tp,eg,ep,ev,re,r,rp)
	local b1=Duel.IsExistingMatchingCard(aux.NecroValleyFilter(s.thfilter),tp,LOCATION_DECK+LOCATION_GRAVE,0,1,nil)
	local b2=Duel.GetLocationCount(tp,LOCATION_SZONE)>0
		and Duel.IsExistingMatchingCard(aux.NecroValleyFilter(s.armsfilter),tp,LOCATION_DECK+LOCATION_GRAVE,0,1,nil)
		and Duel.IsExistingMatchingCard(s.eqmonster,tp,LOCATION_MZONE,0,1,nil)
	if not (b1 or b2) then return end
	local op=0
	if b1 and b2 then
		op=Duel.SelectOption(tp,aux.Stringid(id,2),aux.Stringid(id,3))
	elseif b1 then
		op=0
	else
		op=1
	end
	if op==0 then
		Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_ATOHAND)
		local g=Duel.SelectMatchingCard(tp,aux.NecroValleyFilter(s.thfilter),tp,LOCATION_DECK+LOCATION_GRAVE,0,1,1,nil)
		if #g>0 then
			Duel.SendtoHand(g,nil,REASON_EFFECT)
			Duel.ConfirmCards(1-tp,g)
		end
	else
		if Duel.GetLocationCount(tp,LOCATION_SZONE)<=0 then return end
		Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_EQUIP)
		local eg=Duel.SelectMatchingCard(tp,aux.NecroValleyFilter(s.armsfilter),tp,LOCATION_DECK+LOCATION_GRAVE,0,1,1,nil)
		local ec=eg:GetFirst()
		if not ec then return end
		Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_FACEUP)
		local mg=Duel.SelectMatchingCard(tp,s.eqmonster,tp,LOCATION_MZONE,0,1,1,nil)
		local tc=mg:GetFirst()
		if tc and Duel.Equip(tp,ec,tc) then
			local e1=Effect.CreateEffect(e:GetHandler())
			e1:SetType(EFFECT_TYPE_SINGLE)
			e1:SetCode(EFFECT_CHANGE_TYPE)
			e1:SetProperty(EFFECT_FLAG_CANNOT_DISABLE)
			e1:SetValue(TYPE_SPELL+TYPE_EQUIP)
			e1:SetReset(RESET_EVENT+RESETS_STANDARD)
			ec:RegisterEffect(e1)
			local e2=Effect.CreateEffect(e:GetHandler())
			e2:SetType(EFFECT_TYPE_SINGLE)
			e2:SetCode(EFFECT_EQUIP_LIMIT)
			e2:SetProperty(EFFECT_FLAG_CANNOT_DISABLE)
			e2:SetValue(function(e,c) return c==tc end)
			e2:SetReset(RESET_EVENT+RESETS_STANDARD)
			ec:RegisterEffect(e2)
		end
	end
end
function s.armseqfilter(c,tp)
	local tc=c:GetEquipTarget()
	return c:IsFaceup() and c:IsSetCard(SET_TALISMANDRAKE_ARMS) and tc and tc:IsControler(tp) and tc:IsLocation(LOCATION_MZONE)
end
function s.tdcon(e,tp,eg,ep,ev,re,r,rp)
	return Duel.IsExistingMatchingCard(s.armseqfilter,tp,LOCATION_SZONE,0,1,nil,tp)
end
function s.tdfilter(c)
	return (c:IsLocation(LOCATION_GRAVE) or c:IsFaceup()) and c:IsAbleToDeck()
end
function s.tdtg(e,tp,eg,ep,ev,re,r,rp,chk)
	if chk==0 then
		return Duel.IsExistingMatchingCard(aux.NecroValleyFilter(s.tdfilter),tp,LOCATION_GRAVE+LOCATION_REMOVED,LOCATION_GRAVE+LOCATION_REMOVED,1,nil)
	end
	Duel.SetOperationInfo(0,CATEGORY_TODECK,nil,1,0,LOCATION_GRAVE+LOCATION_REMOVED)
end
function s.tdop(e,tp,eg,ep,ev,re,r,rp)
	local g=Duel.GetMatchingGroup(aux.NecroValleyFilter(s.tdfilter),tp,LOCATION_GRAVE+LOCATION_REMOVED,LOCATION_GRAVE+LOCATION_REMOVED,nil)
	if #g==0 then return end
	Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_TODECK)
	local sg=g:Select(tp,1,math.min(3,#g),nil)
	if #sg>0 then
		Duel.SendtoDeck(sg,nil,SEQ_DECKSHUFFLE,REASON_EFFECT)
	end
end

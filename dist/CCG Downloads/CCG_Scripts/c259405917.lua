-- Siemens, the Ohmechanic Conductor
local s,id=GetID()
local STRING_ID=133405917
local COUNTER_CURRENT = 0x18f0
local SET_OHMEN = 0x8de0
function s.initial_effect(c)
	-- Link Summon
	c:EnableReviveLimit()
	aux.AddLinkProcedure(c,aux.FilterBoolFunction(Card.IsSetCard,SET_OHMEN),2,2)
	-- ATK 0 without counters
	local e1=Effect.CreateEffect(c)
	e1:SetType(EFFECT_TYPE_SINGLE)
	e1:SetProperty(EFFECT_FLAG_SINGLE_RANGE)
	e1:SetRange(LOCATION_MZONE)
	e1:SetCode(EFFECT_SET_ATTACK)
	e1:SetCondition(s.atkcon)
	e1:SetValue(0)
	c:RegisterEffect(e1)
	-- GY Special Summon (1+ counters)
	local e2=Effect.CreateEffect(c)
	e2:SetDescription(aux.Stringid(STRING_ID,0))
	e2:SetCategory(CATEGORY_SPECIAL_SUMMON)
	e2:SetType(EFFECT_TYPE_IGNITION)
	e2:SetRange(LOCATION_MZONE)
	e2:SetCountLimit(1,id)
	e2:SetCondition(s.effcon1)
	e2:SetTarget(s.efftg1)
	e2:SetOperation(s.effop1)
	c:RegisterEffect(e2)
	-- Move monster (2+ counters)
	local e3=Effect.CreateEffect(c)
	e3:SetDescription(aux.Stringid(STRING_ID,1))
	e3:SetType(EFFECT_TYPE_QUICK_O)
	e3:SetCode(EVENT_FREE_CHAIN)
	e3:SetProperty(EFFECT_FLAG_CARD_TARGET)
	e3:SetRange(LOCATION_MZONE)
	e3:SetCountLimit(1,id+100)
	e3:SetCondition(s.effcon2)
	e3:SetTarget(s.efftg2)
	e3:SetOperation(s.effop2)
	c:RegisterEffect(e3)
	-- Steal monster (3+ counters)
	local e4=Effect.CreateEffect(c)
	e4:SetDescription(aux.Stringid(STRING_ID,2))
	e4:SetCategory(CATEGORY_CONTROL)
	e4:SetType(EFFECT_TYPE_QUICK_O)
	e4:SetProperty(EFFECT_FLAG_CARD_TARGET)
	e4:SetCode(EVENT_FREE_CHAIN)
	e4:SetRange(LOCATION_MZONE)
	e4:SetCountLimit(1,id+200)
	e4:SetCondition(s.effcon3)
	e4:SetCost(s.effcost3)
	e4:SetTarget(s.efftg3)
	e4:SetOperation(s.effop3)
	c:RegisterEffect(e4)
end
s.listed_series={SET_OHMEN}

function s.atkcon(e)
	return e:GetHandler():GetCounter(COUNTER_CURRENT) == 0
end

function s.effcon1(e,tp,eg,ep,ev,re,r,rp)
	return e:GetHandler():GetCounter(COUNTER_CURRENT) >= 1
end
function s.spfilter(tc,e,tp)
	return tc:IsSetCard(SET_OHMEN) and aux.NecroValleyFilter()(tc)
		and tc:IsCanBeSpecialSummoned(e,0,tp,false,false)
end
function s.efftg1(e,tp,eg,ep,ev,re,r,rp,chk)
	if chk==0 then return Duel.GetLocationCount(tp,LOCATION_MZONE)>0
		and Duel.IsExistingMatchingCard(s.spfilter,tp,LOCATION_GRAVE,0,1,nil,e,tp) end
	Duel.SetOperationInfo(0,CATEGORY_SPECIAL_SUMMON,nil,1,tp,LOCATION_GRAVE)
end
function s.effop1(e,tp,eg,ep,ev,re,r,rp)
	if Duel.GetLocationCount(tp,LOCATION_MZONE)<=0 then return end
	Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_SPSUMMON)
	local g=Duel.SelectMatchingCard(tp,s.spfilter,tp,LOCATION_GRAVE,0,1,1,nil,e,tp)
	if #g>0 then
		Duel.SpecialSummon(g,0,tp,tp,false,false,POS_FACEUP)
	end
end

function s.effcon2(e,tp,eg,ep,ev,re,r,rp)
	return e:GetHandler():GetCounter(COUNTER_CURRENT) >= 2
end
function s.movefilter(tc,tp)
	if not tc:IsControler(tp) or not tc:IsFaceup() then return false end
	local colinked = Duel.GetMatchingGroup(function(c)
		return c:IsFaceup() and c:GetMutualLinkedGroupCount() > 0
	end, tp, LOCATION_MZONE, 0, nil)
	for c in aux.Next(colinked) do
		if c:GetLinkedGroup():IsContains(tc) then return true end
	end
	return false
end
function s.hasfreemzone(tp)
	for i=0,4 do
		if Duel.CheckLocation(tp,LOCATION_MZONE,i) then return true end
	end
	return false
end
function s.efftg2(e,tp,eg,ep,ev,re,r,rp,chk,chkc)
	if chkc then return chkc:IsLocation(LOCATION_MZONE) and s.movefilter(chkc,tp) end
	if chk==0 then return s.hasfreemzone(tp)
		and Duel.IsExistingTarget(s.movefilter,tp,LOCATION_MZONE,0,1,nil,tp) end
	Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_TARGET)
	Duel.SelectTarget(tp,s.movefilter,tp,LOCATION_MZONE,0,1,1,nil,tp)
end
function s.effop2(e,tp,eg,ep,ev,re,r,rp)
	local tc=Duel.GetFirstTarget()
	if not tc or not tc:IsRelateToEffect(e) or tc:IsControler(1-tp) then return end
	local free_zones = 0
	for i=0,4 do
		if Duel.CheckLocation(tp,LOCATION_MZONE,i) then
			free_zones = bit.bor(free_zones, bit.lshift(1, i))
		end
	end
	if free_zones == 0 then return end
	local disable_mask = bit.bxor(free_zones, 0xff)
	Duel.Hint(HINT_SELECTMSG, tp, HINTMSG_TOZONE)
	local s_field = Duel.SelectDisableField(tp, 1, LOCATION_MZONE, 0, disable_mask)
	local nseq = 0
	if s_field == 1 then nseq = 0
	elseif s_field == 2 then nseq = 1
	elseif s_field == 4 then nseq = 2
	elseif s_field == 8 then nseq = 3
	else nseq = 4 end
	Duel.MoveSequence(tc, nseq)
end

function s.effcon3(e,tp,eg,ep,ev,re,r,rp)
	return e:GetHandler():GetCounter(COUNTER_CURRENT) >= 3
end
function s.effcost3(e,tp,eg,ep,ev,re,r,rp,chk)
	local c=e:GetHandler()
	if chk==0 then return c:GetCounter(COUNTER_CURRENT) > 0 end
	c:RemoveCounter(tp,COUNTER_CURRENT,c:GetCounter(COUNTER_CURRENT),REASON_COST)
end
function s.efftg3(e,tp,eg,ep,ev,re,r,rp,chk,chkc)
	if chkc then return chkc:IsLocation(LOCATION_MZONE) and chkc:IsControler(1-tp) and chkc:IsControlerCanBeChanged() end
	
	local colinked = Duel.GetMatchingGroup(function(tc)
		return tc:IsFaceup() and tc:GetMutualLinkedGroupCount() > 0
	end, tp, LOCATION_MZONE, 0, nil)
	local allowed_mask = 0
	for tc in aux.Next(colinked) do
		allowed_mask = bit.bor(allowed_mask, tc:GetLinkedZone(tp))
	end
	allowed_mask = bit.band(allowed_mask, 0x1f)
	local occupied_zones = 0
	for i=0,4 do
		if not Duel.CheckLocation(tp,LOCATION_MZONE,i) then
			occupied_zones = bit.bor(occupied_zones, bit.lshift(1, i))
		end
	end
	local free_zones = bit.band(allowed_mask, bit.bnot(occupied_zones))
	
	if chk==0 then return free_zones ~= 0
		and Duel.IsExistingTarget(Card.IsControlerCanBeChanged, tp, 0, LOCATION_MZONE, 1, nil) end
	
	Duel.Hint(HINT_SELECTMSG, tp, HINTMSG_CONTROL)
	local g=Duel.SelectTarget(tp, Card.IsControlerCanBeChanged, tp, 0, LOCATION_MZONE, 1, 1, nil)
	Duel.SetOperationInfo(0, CATEGORY_CONTROL, g, 1, 0, 0)
end
function s.effop3(e,tp,eg,ep,ev,re,r,rp)
	local tc=Duel.GetFirstTarget()
	if not tc or not tc:IsRelateToEffect(e) or not tc:IsControlerCanBeChanged() then return end
	
	local colinked = Duel.GetMatchingGroup(function(tc)
		return tc:IsFaceup() and tc:GetMutualLinkedGroupCount() > 0
	end, tp, LOCATION_MZONE, 0, nil)
	local allowed_mask = 0
	for tc in aux.Next(colinked) do
		allowed_mask = bit.bor(allowed_mask, tc:GetLinkedZone(tp))
	end
	allowed_mask = bit.band(allowed_mask, 0x1f)
	local occupied_zones = 0
	for i=0,4 do
		if not Duel.CheckLocation(tp,LOCATION_MZONE,i) then
			occupied_zones = bit.bor(occupied_zones, bit.lshift(1, i))
		end
	end
	local free_zones = bit.band(allowed_mask, bit.bnot(occupied_zones))
	if free_zones == 0 then return end
	
	local disable_mask = bit.bxor(free_zones, 0xff)
	Duel.Hint(HINT_SELECTMSG, tp, HINTMSG_TOZONE)
	local s_field = Duel.SelectDisableField(tp, 1, LOCATION_MZONE, 0, disable_mask)
	
	Duel.GetControl(tc, tp, 0, 0, s_field)
end

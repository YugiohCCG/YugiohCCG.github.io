-- Ohmen Beacon
local s,id=GetID()
local COUNTER_CURRENT = 0x18f0
local SET_OHMEN = 0x8de0
local SET_OHMECHANIC = 0x8de1
function s.initial_effect(c)
	-- Activate
	local e1=Effect.CreateEffect(c)
	e1:SetCategory(CATEGORY_SPECIAL_SUMMON)
	e1:SetType(EFFECT_TYPE_ACTIVATE)
	e1:SetCode(EVENT_FREE_CHAIN)
	e1:SetCountLimit(1,id+EFFECT_COUNT_LIMIT_OATH)
	e1:SetTarget(s.target)
	e1:SetOperation(s.activate)
	c:RegisterEffect(e1)
	-- Target protection
	local e2=Effect.CreateEffect(c)
	e2:SetType(EFFECT_TYPE_FIELD)
	e2:SetCode(EFFECT_CANNOT_BE_EFFECT_TARGET)
	e2:SetRange(LOCATION_SZONE)
	e2:SetTargetRange(LOCATION_MZONE,0)
	e2:SetTarget(s.tgtg)
	e2:SetValue(aux.tgovval)
	c:RegisterEffect(e2)
	-- Move monster and place counter
	local e3=Effect.CreateEffect(c)
	e3:SetDescription(aux.Stringid(id,3))
	e3:SetType(EFFECT_TYPE_IGNITION)
	e3:SetRange(LOCATION_SZONE)
	e3:SetCountLimit(1)
	e3:SetTarget(s.mvtg)
	e3:SetOperation(s.mvop)
	c:RegisterEffect(e3)
end
s.listed_series={SET_OHMEN, SET_OHMECHANIC}

function s.spfilter1(tc,e,tp)
	return tc:IsRace(RACE_THUNDER) and tc:IsCanBeSpecialSummoned(e,0,tp,false,false)
end
function s.spfilter2(tc,e,tp)
	return tc:IsSetCard(SET_OHMEN) and tc:IsCanBeSpecialSummoned(e,0,tp,false,false)
end
function s.target(e,tp,eg,ep,ev,re,r,rp,chk)
	local b1=Duel.GetLocationCount(tp,LOCATION_MZONE)>0
		and Duel.IsExistingMatchingCard(s.spfilter1,tp,LOCATION_HAND,0,1,nil,e,tp)
	local b2=Duel.GetLocationCount(tp,LOCATION_MZONE)>0
		and Duel.IsExistingMatchingCard(function(tc) return tc:IsFaceup() and tc:IsSetCard(SET_OHMECHANIC) end,tp,LOCATION_MZONE,0,1,nil)
		and Duel.IsExistingMatchingCard(s.spfilter2,tp,LOCATION_GRAVE,0,1,nil,e,tp)
	
	if chk==0 then return true end
	Duel.SetOperationInfo(0,CATEGORY_SPECIAL_SUMMON,nil,0,tp,LOCATION_HAND+LOCATION_GRAVE)
end
function s.activate(e,tp,eg,ep,ev,re,r,rp)
	if not e:GetHandler():IsRelateToEffect(e) then return end
	local b1=Duel.GetLocationCount(tp,LOCATION_MZONE)>0
		and Duel.IsExistingMatchingCard(s.spfilter1,tp,LOCATION_HAND,0,1,nil,e,tp)
	local b2=Duel.GetLocationCount(tp,LOCATION_MZONE)>0
		and Duel.IsExistingMatchingCard(function(tc) return tc:IsFaceup() and tc:IsSetCard(SET_OHMECHANIC) end,tp,LOCATION_MZONE,0,1,nil)
		and Duel.IsExistingMatchingCard(s.spfilter2,tp,LOCATION_GRAVE,0,1,nil,e,tp)
	
	if not (b1 or b2) then return end
	if not Duel.SelectYesNo(tp,aux.Stringid(id,0)) then return end
	
	local op=0
	if b1 and b2 then
		op=Duel.SelectOption(tp,aux.Stringid(id,1),aux.Stringid(id,2))
	elseif b1 then
		op=Duel.SelectOption(tp,aux.Stringid(id,1))
	else
		op=Duel.SelectOption(tp,aux.Stringid(id,2))+1
	end
	
	if op==0 then
		Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_SPSUMMON)
		local g=Duel.SelectMatchingCard(tp,s.spfilter1,tp,LOCATION_HAND,0,1,1,nil,e,tp)
		if #g>0 then
			Duel.SpecialSummon(g,0,tp,tp,false,false,POS_FACEUP)
		end
	else
		Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_SPSUMMON)
		local g=Duel.SelectMatchingCard(tp,s.spfilter2,tp,LOCATION_GRAVE,0,1,1,nil,e,tp)
		if #g>0 then
			Duel.SpecialSummon(g,0,tp,tp,false,false,POS_FACEUP)
		end
	end
end

function s.tgtg(e,tc)
	return tc:IsFaceup() and tc:GetMutualLinkedGroupCount() > 0 and tc:GetCounter(COUNTER_CURRENT) > 0
end

function s.mvfilter(tc,tp)
	if not tc:IsFaceup() or not tc:IsControler(tp) then return false end
	return Duel.IsExistingMatchingCard(nil,tp,LOCATION_MZONE,0,1,tc) or Duel.GetLocationCount(tp,LOCATION_MZONE) > 0
end
function s.mvtg(e,tp,eg,ep,ev,re,r,rp,chk,chkc)
	if chkc then return chkc:IsLocation(LOCATION_MZONE) and chkc:IsControler(tp) and s.mvfilter(chkc,tp) end
	if chk==0 then return Duel.IsExistingTarget(s.mvfilter,tp,LOCATION_MZONE,0,1,nil,tp) end
	Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_TARGET)
	Duel.SelectTarget(tp,s.mvfilter,tp,LOCATION_MZONE,0,1,1,nil,tp)
end
function s.mvop(e,tp,eg,ep,ev,re,r,rp)
	if not e:GetHandler():IsRelateToEffect(e) then return end
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
	
	if Duel.MoveSequence(tc, nseq) then
		local g=Duel.GetMatchingGroup(function(mc)
			return mc:IsFaceup() and mc:GetMutualLinkedGroupCount() > 0
		end, tp, LOCATION_MZONE, 0, nil)
		for mc in aux.Next(g) do
			mc:AddCounter(COUNTER_CURRENT, 1)
		end
	end
end

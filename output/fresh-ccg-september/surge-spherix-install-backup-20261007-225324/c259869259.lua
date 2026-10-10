-- Ohmen Surge
local s,id=GetID()
local STRING_ID=133869259
local COUNTER_CURRENT = 0x18f0
local SET_OHMECHANIC = 0x8de1
function s.initial_effect(c)
	-- Activate SZone
	local e0=Effect.CreateEffect(c)
	e0:SetType(EFFECT_TYPE_ACTIVATE)
	e0:SetCode(EVENT_FREE_CHAIN)
	e0:SetCountLimit(1,id+EFFECT_COUNT_CODE_OATH)
	c:RegisterEffect(e0)
	-- Continuous co-link counter placement
	local e1=Effect.CreateEffect(c)
	e1:SetType(EFFECT_TYPE_FIELD+EFFECT_TYPE_CONTINUOUS)
	e1:SetCode(EVENT_ADJUST)
	e1:SetRange(LOCATION_SZONE)
	e1:SetOperation(s.adjustop)
	c:RegisterEffect(e1)
	-- Control opponent monster on Spell activation
	local e2=Effect.CreateEffect(c)
	e2:SetDescription(aux.Stringid(STRING_ID,0))
	e2:SetCategory(CATEGORY_CONTROL)
	e2:SetType(EFFECT_TYPE_QUICK_O)
	e2:SetProperty(EFFECT_FLAG_CARD_TARGET)
	e2:SetCode(EVENT_CHAINING)
	e2:SetRange(LOCATION_SZONE)
	e2:SetCondition(s.control_con)
	e2:SetTarget(s.control_tg)
	e2:SetOperation(s.control_op)
	c:RegisterEffect(e2)
end
s.listed_series={SET_OHMECHANIC}

function s.adjustop(e,tp,eg,ep,ev,re,r,rp)
	local g = Duel.GetMatchingGroup(function(tc)
		return tc:IsFaceup() and tc:IsControler(tp) and tc:GetMutualLinkedGroupCount() > 0
	end, tp, LOCATION_MZONE, 0, nil)
	
	for tc in aux.Next(g) do
		if tc:GetFlagEffect(id) == 0 then
			tc:RegisterFlagEffect(id, RESET_EVENT+RESETS_STANDARD, 0, 1)
			tc:AddCounter(COUNTER_CURRENT, 1)
		end
	end
	
	local all_g = Duel.GetMatchingGroup(function(tc)
		return tc:GetFlagEffect(id) > 0
	end, tp, LOCATION_MZONE, 0, nil)
	for tc in aux.Next(all_g) do
		if tc:GetMutualLinkedGroupCount() == 0 then
			tc:ResetFlagEffect(id)
		end
	end
end

function s.control_con(e,tp,eg,ep,ev,re,r,rp)
	return rp==1-tp and re:IsActiveType(TYPE_SPELL)
		and Duel.IsExistingMatchingCard(function(tc) return tc:IsFaceup() and tc:IsSetCard(SET_OHMECHANIC) end, tp, LOCATION_MZONE, 0, 1, nil)
end

function s.control_tg(e,tp,eg,ep,ev,re,r,rp,chk,chkc)
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
	for i = 0, 4 do
		if not Duel.CheckLocation(tp, LOCATION_MZONE, i) then
			occupied_zones = bit.bor(occupied_zones, bit.lshift(1, i))
		end
	end
	local free_zones = bit.band(allowed_mask, bit.bnot(occupied_zones))
	
	if chk==0 then return free_zones ~= 0
		and Duel.IsExistingTarget(Card.IsControlerCanBeChanged, tp, 0, LOCATION_MZONE, 1, nil) end
	
	Duel.Hint(HINT_SELECTMSG, tp, HINTMSG_CONTROL)
	local g = Duel.SelectTarget(tp, Card.IsControlerCanBeChanged, tp, 0, LOCATION_MZONE, 1, 1, nil)
	Duel.SetOperationInfo(0, CATEGORY_CONTROL, g, 1, 0, 0)
end

function s.control_op(e,tp,eg,ep,ev,re,r,rp)
	local tc = Duel.GetFirstTarget()
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
	for i = 0, 4 do
		if not Duel.CheckLocation(tp, LOCATION_MZONE, i) then
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

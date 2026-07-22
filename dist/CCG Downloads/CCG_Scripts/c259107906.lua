-- Siemens, the Blue Ohmen
local s,id=GetID()
local STRING_ID=133107906
local COUNTER_CURRENT = 0x18f0
function s.initial_effect(c)
	-- Special Summon procedure
	local e1=Effect.CreateEffect(c)
	e1:SetType(EFFECT_TYPE_FIELD)
	e1:SetCode(EFFECT_SPSUMMON_PROC)
	e1:SetProperty(EFFECT_FLAG_UNCOPYABLE+EFFECT_FLAG_SPSUM_PARAM)
	e1:SetRange(LOCATION_HAND)
	e1:SetTargetRange(POS_FACEUP,0)
	e1:SetCondition(s.spcon1)
	e1:SetValue(s.spval1)
	c:RegisterEffect(e1)
	-- BFS and movement
	local e2=Effect.CreateEffect(c)
	e2:SetDescription(aux.Stringid(STRING_ID,0))
	e2:SetCategory(CATEGORY_TOHAND+CATEGORY_SEARCH)
	e2:SetType(EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_F)
	e2:SetCode(EVENT_SPSUMMON_SUCCESS)
	e2:SetProperty(EFFECT_FLAG_DELAY)
	e2:SetCountLimit(1,id)
	e2:SetCondition(s.bfscon)
	e2:SetTarget(s.bfstg)
	e2:SetOperation(s.bfsop)
	c:RegisterEffect(e2)
end

function s.spcon1(e,c)
	if c==nil then return true end
	local tp=c:GetControler()
	local zone=Duel.GetLinkedZone(tp)
	return Duel.GetLocationCount(tp,LOCATION_MZONE,tp,LOCATION_REASON_TOFIELD,zone)>0
end
function s.spval1(e,c)
	return 0,Duel.GetLinkedZone(c:GetControler())
end

function s.bfscon(e,tp,eg,ep,ev,re,r,rp)
	local c=e:GetHandler()
	return Duel.IsExistingMatchingCard(function(tc)
		return tc:IsType(TYPE_LINK) and tc:GetLinkedGroup():IsContains(c)
	end, tp, LOCATION_MZONE, LOCATION_MZONE, 1, nil)
end
function s.bfstg(e,tp,eg,ep,ev,re,r,rp,chk)
	if chk==0 then return true end
	Duel.SetOperationInfo(0,CATEGORY_TOHAND,nil,1,tp,LOCATION_DECK)
end

function s.bfsop(e,tp,eg,ep,ev,re,r,rp)
	local c=e:GetHandler()
	if not c:IsRelateToEffect(e) then return end
	
	local visited = Group.CreateGroup()
	local queue = {}
	
	local g = Duel.GetMatchingGroup(function(tc)
		return tc:IsControler(tp) and tc:IsType(TYPE_LINK) and tc:GetLinkedGroup():IsContains(c)
	end, tp, LOCATION_MZONE, 0, nil)
	
	for tc in aux.Next(g) do
		visited:AddCard(tc)
		table.insert(queue, tc)
	end
	
	local head = 1
	while head <= #queue do
		local curr = queue[head]
		head = head + 1
		local lg = curr:GetLinkedGroup()
		for tc in aux.Next(lg) do
			if tc:IsControler(tp) and tc:IsType(TYPE_LINK) and not visited:IsContains(tc) then
				if tc:GetLinkedGroup():IsContains(curr) then
					visited:AddCard(tc)
					table.insert(queue, tc)
				end
			end
		end
	end
	
	if #visited == 0 then return end
	
	for tc in aux.Next(visited) do
		tc:AddCounter(COUNTER_CURRENT, 1)
	end
	
	local allowed_mask = 0
	for tc in aux.Next(visited) do
		allowed_mask = bit.bor(allowed_mask, tc:GetLinkedZone(tp))
	end
	allowed_mask = bit.band(allowed_mask, 0x1f)
	
	local occupied_zones = 0
	for i = 0, 4 do
		if not Duel.CheckLocation(tp, LOCATION_MZONE, i) then
			occupied_zones = bit.bor(occupied_zones, bit.lshift(1, i))
		end
	end
	
	local move_mask = bit.band(allowed_mask, bit.bnot(occupied_zones))
	if move_mask ~= 0 then
		local disable_mask = bit.bxor(move_mask, 0xff)
		Duel.Hint(HINT_SELECTMSG, tp, HINTMSG_TOZONE)
		local s_field = Duel.SelectDisableField(tp, 1, LOCATION_MZONE, 0, disable_mask)
		local nseq = 0
		if s_field == 1 then nseq = 0
		elseif s_field == 2 then nseq = 1
		elseif s_field == 4 then nseq = 2
		elseif s_field == 8 then nseq = 3
		else nseq = 4 end
		
		if Duel.MoveSequence(c, nseq) then
			s.additional_op(e, tp)
		end
	end
end

function s.thfilter(tc)
	return tc:IsSetCard(0x8de0) and tc:IsType(TYPE_SPELL+TYPE_TRAP) and tc:IsAbleToHand()
end
function s.additional_op(e,tp)
	if Duel.IsExistingMatchingCard(s.thfilter,tp,LOCATION_DECK,0,1,nil) then
		Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_ATOHAND)
		local sg=Duel.SelectMatchingCard(tp,s.thfilter,tp,LOCATION_DECK,0,1,1,nil)
		if #sg>0 then
			Duel.SendtoHand(sg,nil,REASON_EFFECT)
			Duel.ConfirmCards(1-tp,sg)
		end
	end
end

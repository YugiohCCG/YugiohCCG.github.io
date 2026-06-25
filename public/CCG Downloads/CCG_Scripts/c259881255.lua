-- Coulomb, the White Ohmen
local s,id=GetID()
local COUNTER_CURRENT = 0x18f0
function s.initial_effect(c)
	-- Special Summon procedure
	local e1=Effect.CreateEffect(c)
	e1:SetType(EFFECT_TYPE_FIELD)
	e1:SetCode(EFFECT_SPSUMMON_PROC)
	e1:SetProperty(EFFECT_FLAG_UNCOPYABLE)
	e1:SetRange(LOCATION_HAND)
	e1:SetCondition(s.spcon1)
	c:RegisterEffect(e1)
	-- BFS and movement
	local e2=Effect.CreateEffect(c)
	e2:SetDescription(aux.Stringid(id,0))
	e2:SetType(EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_O)
	e2:SetCode(EVENT_SPSUMMON_SUCCESS)
	e2:SetProperty(EFFECT_FLAG_DELAY)
	e2:SetCountLimit(1,id)
	e2:SetCondition(s.bfscon)
	e2:SetTarget(s.bfstg)
	e2:SetOperation(s.bfsop)
	c:RegisterEffect(e2)
	-- Special Summon from Extra Deck
	local e3=Effect.CreateEffect(c)
	e3:SetDescription(aux.Stringid(id,1))
	e3:SetCategory(CATEGORY_SPECIAL_SUMMON)
	e3:SetType(EFFECT_TYPE_IGNITION)
	e3:SetRange(LOCATION_MZONE)
	e3:SetCountLimit(1,id+100)
	e3:SetTarget(s.extg)
	e3:SetOperation(s.exop)
	c:RegisterEffect(e3)
end

function s.spcon1(e,c)
	if c==nil then return true end
	local tp=c:GetControler()
	local g = Duel.GetFieldGroup(tp, LOCATION_MZONE, 0)
	return Duel.GetLocationCount(tp, LOCATION_MZONE) > 0
		and (#g == 0 or g:FilterCount(Card.IsRace, nil, RACE_THUNDER) == #g)
end

function s.bfscon(e,tp,eg,ep,ev,re,r,rp)
	local c=e:GetHandler()
	return Duel.IsExistingMatchingCard(function(tc)
		return tc:IsType(TYPE_LINK) and tc:GetLinkedGroup():IsContains(c)
	end, tp, LOCATION_MZONE, LOCATION_MZONE, 1, nil)
end
function s.bfstg(e,tp,eg,ep,ev,re,r,rp,chk)
	if chk==0 then return true end
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
		
		Duel.MoveSequence(c, nseq)
	end
end

function s.exfilter(tc,e,tp)
	return tc:IsSetCard(0x8de0) and tc:IsType(TYPE_LINK) and tc:IsCanBeSpecialSummoned(e,0,tp,false,false)
end
function s.check_extra_subset(ex, selected, limit, ft)
	if #selected > 0 and ft >= #selected then
		local total_link = 0
		for tc in aux.Next(selected) do
			total_link = total_link + tc:GetLink()
		end
		if total_link <= limit then return true end
	end
	if #selected >= ft then return false end
	for tc in aux.Next(ex) do
		if not selected:IsContains(tc) then
			selected:AddCard(tc)
			if s.check_extra_subset(ex, selected, limit, ft) then
				selected:RemoveCard(tc)
				return true
			end
			selected:RemoveCard(tc)
		end
	end
	return false
end

function s.extg(e,tp,eg,ep,ev,re,r,rp,chk)
	if chk==0 then
		local hand = Duel.GetMatchingGroup(function(tc) return tc:IsSetCard(0x8de0) and tc:IsAbleToGrave() end, tp, LOCATION_HAND, 0, nil)
		local ex = Duel.GetMatchingGroup(s.exfilter, tp, LOCATION_EXTRA, 0, nil, e, tp)
		local ft = Duel.GetLocationCountFromEx(tp)
		return #hand > 0 and #ex > 0 and s.check_extra_subset(ex, Group.CreateGroup(), #hand, ft)
	end
	
	local hand = Duel.GetMatchingGroup(function(tc) return tc:IsSetCard(0x8de0) and tc:IsAbleToGrave() end, tp, LOCATION_HAND, 0, nil)
	local ex = Duel.GetMatchingGroup(s.exfilter, tp, LOCATION_EXTRA, 0, nil, e, tp)
	local ft = Duel.GetLocationCountFromEx(tp)
	
	local sg = Group.CreateGroup()
	while #sg < #hand do
		local cancel = #sg > 0 and s.check_extra_subset(ex, Group.CreateGroup(), #sg, ft)
		local available = hand:Filter(function(tc) return not sg:IsContains(tc) end, nil)
		if #available == 0 then break end
		local valid_add = available:Filter(function(tc)
			sg:AddCard(tc)
			local ok = s.check_extra_subset(ex, Group.CreateGroup(), #sg, ft)
			sg:RemoveCard(tc)
			return ok
		end, nil)
		if #valid_add == 0 then break end
		
		if cancel then
			if not Duel.SelectYesNo(tp, aux.Stringid(id, 2)) then
				break
			end
		end
		Duel.Hint(HINT_SELECTMSG, tp, HINTMSG_TOGRAVE)
		local tc = valid_add:Select(tp, 1, 1, nil):GetFirst()
		if not tc then break end
		sg:AddCard(tc)
	end
	Duel.SendtoGrave(sg, REASON_EFFECT)
	e:SetLabel(#sg)
	Duel.SetOperationInfo(0, CATEGORY_SPECIAL_SUMMON, nil, 1, tp, LOCATION_EXTRA)
end

function s.check_extra_subset_exact(ex, selected, target_link, ft)
	local current_link = 0
	for tc in aux.Next(selected) do
		current_link = current_link + tc:GetLink()
	end
	if target_link == 0 then return #selected <= ft end
	if #selected >= ft then return false end
	for tc in aux.Next(ex) do
		if not selected:IsContains(tc) then
			selected:AddCard(tc)
			if s.check_extra_subset_exact(ex, selected, target_link - tc:GetLink(), ft) then
				selected:RemoveCard(tc)
				return true
			end
			selected:RemoveCard(tc)
		end
	end
	return false
end

function s.exop(e,tp,eg,ep,ev,re,r,rp)
	local count = e:GetLabel()
	if count <= 0 then return end
	local ex = Duel.GetMatchingGroup(s.exfilter, tp, LOCATION_EXTRA, 0, nil, e, tp)
	local ft = Duel.GetLocationCountFromEx(tp)
	local selected = Group.CreateGroup()
	
	while count > 0 do
		local filter = function(tc)
			if tc:GetLink() > count then return false end
			if selected:IsContains(tc) then return false end
			selected:AddCard(tc)
			local ok = s.check_extra_subset_exact(ex, selected, count - tc:GetLink(), ft)
			selected:RemoveCard(tc)
			return ok
		end
		local available = ex:Filter(filter, nil)
		if #available == 0 then break end
		Duel.Hint(HINT_SELECTMSG, tp, HINTMSG_SPSUMMON)
		local tc = available:Select(tp, 1, 1, nil):GetFirst()
		if not tc then break end
		selected:AddCard(tc)
		count = count - tc:GetLink()
	end
	
	if #selected > 0 then
		for tc in aux.Next(selected) do
			if Duel.SpecialSummonStep(tc, 0, tp, tp, false, false, POS_FACEUP) then
				tc:AddCounter(COUNTER_CURRENT, 1)
			end
		end
		Duel.SpecialSummonComplete()
	end
end

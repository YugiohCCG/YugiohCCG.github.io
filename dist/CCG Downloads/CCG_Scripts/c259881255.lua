-- Coulomb, the White Ohmen
local s,id=GetID()
local STRING_ID=133881255
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
	e2:SetDescription(aux.Stringid(STRING_ID,0))
	e2:SetType(EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_F)
	e2:SetCode(EVENT_SPSUMMON_SUCCESS)
	e2:SetProperty(EFFECT_FLAG_DELAY)
	e2:SetCountLimit(1,id)
	e2:SetCondition(s.bfscon)
	e2:SetTarget(s.bfstg)
	e2:SetOperation(s.bfsop)
	c:RegisterEffect(e2)
	-- Special Summon from Extra Deck
	local e3=Effect.CreateEffect(c)
	e3:SetDescription(aux.Stringid(STRING_ID,1))
	e3:SetCategory(CATEGORY_SPECIAL_SUMMON)
	e3:SetType(EFFECT_TYPE_IGNITION)
	e3:SetRange(LOCATION_MZONE)
	e3:SetCountLimit(1,id+100)
	e3:SetCost(s.excost)
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
function s.excheck(g,ct,ft)
	return #g<=ft and g:GetSum(Card.GetLink)==ct
end
function s.handcheck(g,e,tp)
	local ex=Duel.GetMatchingGroup(s.exfilter,tp,LOCATION_EXTRA,0,nil,e,tp)
	local ft=Duel.GetLocationCountFromEx(tp)
	return ft>0 and ex:CheckSubGroup(s.excheck,1,math.min(#ex,ft),#g,ft)
end
function s.excostfilter(c)
	return c:IsSetCard(0x8de0) and c:IsAbleToGraveAsCost()
end
function s.excost(e,tp,eg,ep,ev,re,r,rp,chk)
	local hg=Duel.GetMatchingGroup(s.excostfilter,tp,LOCATION_HAND,0,nil)
	if chk==0 then return hg:CheckSubGroup(s.handcheck,1,#hg,e,tp) end
	Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_TOGRAVE)
	local sg=hg:SelectSubGroup(tp,s.handcheck,false,1,#hg,e,tp)
	Duel.SendtoGrave(sg,REASON_COST)
	e:SetLabel(Duel.GetOperatedGroup():FilterCount(Card.IsLocation,nil,LOCATION_GRAVE))
end
function s.extg(e,tp,eg,ep,ev,re,r,rp,chk)
	local ct=e:GetLabel()
	local ex=Duel.GetMatchingGroup(s.exfilter,tp,LOCATION_EXTRA,0,nil,e,tp)
	local ft=Duel.GetLocationCountFromEx(tp)
	if chk==0 then return ct>0 and ft>0
		and ex:CheckSubGroup(s.excheck,1,math.min(#ex,ft),ct,ft) end
	Duel.SetOperationInfo(0,CATEGORY_SPECIAL_SUMMON,nil,1,tp,LOCATION_EXTRA)
end

function s.exop(e,tp,eg,ep,ev,re,r,rp)
	local ct=e:GetLabel()
	if ct<=0 then return end
	local ex=Duel.GetMatchingGroup(s.exfilter,tp,LOCATION_EXTRA,0,nil,e,tp)
	local ft=Duel.GetLocationCountFromEx(tp)
	if ft<=0 or not ex:CheckSubGroup(s.excheck,1,math.min(#ex,ft),ct,ft) then return end
	Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_SPSUMMON)
	local sg=ex:SelectSubGroup(tp,s.excheck,false,1,math.min(#ex,ft),ct,ft)
	if sg then
		for tc in aux.Next(sg) do
			if Duel.SpecialSummonStep(tc, 0, tp, tp, false, false, POS_FACEUP) then
				tc:AddCounter(COUNTER_CURRENT, 1)
			end
		end
		Duel.SpecialSummonComplete()
	end
end

--Zero Mother of the A.I.P Ex
local s,id=GetID()
local SET_AIP=0xa979
local STRING_ID=id
local XYZ_INFINITE_MATS=(Xyz and Xyz.InfiniteMats) or 99
function s.initial_effect(c)
	c:EnableReviveLimit()
	if c.SetUniqueOnField then
		c:SetUniqueOnField(1,0,id)
	end
	--2+ Level 9 monsters
	if Xyz and Xyz.AddProcedure then
		Xyz.AddProcedure(c,nil,9,2,nil,nil,XYZ_INFINITE_MATS)
	elseif aux.AddXyzProcedure then
		aux.AddXyzProcedure(c,nil,9,2,nil,nil,99)
	end
	--Unaffected by Beast monster effects your opponent controls
	local e1=Effect.CreateEffect(c)
	e1:SetType(EFFECT_TYPE_SINGLE)
	e1:SetCode(EFFECT_IMMUNE_EFFECT)
	e1:SetValue(s.immval)
	c:RegisterEffect(e1)
	--Matching original monster Types become Beast
	local e2=Effect.CreateEffect(c)
	e2:SetType(EFFECT_TYPE_FIELD)
	e2:SetCode(EFFECT_CHANGE_RACE)
	e2:SetRange(LOCATION_MZONE)
	e2:SetTargetRange(LOCATION_MZONE+LOCATION_GRAVE+LOCATION_REMOVED,LOCATION_MZONE+LOCATION_GRAVE+LOCATION_REMOVED)
	e2:SetTarget(s.racetg)
	e2:SetValue(RACE_BEAST)
	c:RegisterEffect(e2)
	--Detach 1; attach up to 2 monsters on the field to this card
	local e3=Effect.CreateEffect(c)
	e3:SetDescription(aux.Stringid(STRING_ID,0))
	e3:SetCategory(CATEGORY_LEAVE_GRAVE)
	e3:SetType(EFFECT_TYPE_QUICK_O)
	e3:SetCode(EVENT_FREE_CHAIN)
	e3:SetRange(LOCATION_MZONE)
	e3:SetCountLimit(1,id)
	e3:SetCondition(s.maincon)
	e3:SetCost(s.detachcost)
	e3:SetTarget(s.attachtg)
	e3:SetOperation(s.attachop)
	c:RegisterEffect(e3)
end
s.listed_series={SET_AIP}
function s.immval(e,re)
	local rc=re:GetHandler()
	return rc and rc:IsType(TYPE_MONSTER) and rc:IsRace(RACE_BEAST)
		and rc:IsControler(1-e:GetHandlerPlayer())
end
function s.matmatch(e,c)
	local og=e:GetHandler():GetOverlayGroup()
	local race=c:GetOriginalRace()
	for mc in aux.Next(og) do
		if (race&mc:GetOriginalRace())~=0 then
			return true
		end
	end
	return false
end
function s.racetg(e,c)
	local loc=c:GetLocation()
	return c:IsType(TYPE_MONSTER) and (loc==LOCATION_GRAVE or c:IsFaceup()) and s.matmatch(e,c)
end
function s.maincon(e,tp,eg,ep,ev,re,r,rp)
	local ph=Duel.GetCurrentPhase()
	return ph==PHASE_MAIN1 or ph==PHASE_MAIN2
end
function s.detachcost(e,tp,eg,ep,ev,re,r,rp,chk)
	if chk==0 then return e:GetHandler():CheckRemoveOverlayCard(tp,1,REASON_COST) end
	e:GetHandler():RemoveOverlayCard(tp,1,1,REASON_COST)
end
function s.attachfilter(c)
	return c:IsType(TYPE_MONSTER) and not c:IsType(TYPE_TOKEN)
end
function s.attachtg(e,tp,eg,ep,ev,re,r,rp,chk)
	if chk==0 then return Duel.IsExistingMatchingCard(s.attachfilter,tp,LOCATION_MZONE,LOCATION_MZONE,1,e:GetHandler()) end
end
function s.attachop(e,tp,eg,ep,ev,re,r,rp)
	local c=e:GetHandler()
	if not c:IsRelateToEffect(e) then return end
	local g=Duel.GetMatchingGroup(s.attachfilter,tp,LOCATION_MZONE,LOCATION_MZONE,c)
	if #g==0 then return end
	Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_XMATERIAL)
	local sg=g:Select(tp,1,math.min(2,#g),nil)
	if #sg>0 then
		Duel.Overlay(c,sg)
	end
end

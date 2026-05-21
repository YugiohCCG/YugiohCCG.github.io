--Caller of the A.I.P Ex
local s,id=GetID()
local SET_AIP=0xa979
local STRING_ID=id
local XYZ_INFINITE_MATS=(Xyz and Xyz.InfiniteMats) or 99
local EFFECT_FLAG_SET_AVAILABLE=EFFECT_FLAG_SET_AVAILABLE or 0
function s.initial_effect(c)
	c:EnableReviveLimit()
	--2+ Level 6 monsters
	if Xyz and Xyz.AddProcedure then
		Xyz.AddProcedure(c,nil,6,2,nil,nil,XYZ_INFINITE_MATS)
	elseif aux.AddXyzProcedure then
		aux.AddXyzProcedure(c,nil,6,2,nil,nil,99)
	end
	--Opponent-owned monsters can be used as Level 6 for this Xyz Summon
	if EFFECT_XYZ_LEVEL then
		local e0=Effect.CreateEffect(c)
		e0:SetType(EFFECT_TYPE_FIELD)
		e0:SetCode(EFFECT_XYZ_LEVEL)
		e0:SetProperty(EFFECT_FLAG_SET_AVAILABLE)
		e0:SetRange(LOCATION_EXTRA)
		e0:SetTargetRange(LOCATION_MZONE,0)
		e0:SetTarget(s.xyzlvtg)
		e0:SetValue(s.xyzlv)
		c:RegisterEffect(e0)
	end
	--Special Summon 1 Beast monster from hand or either GY
	local e1=Effect.CreateEffect(c)
	e1:SetDescription(aux.Stringid(STRING_ID,0))
	e1:SetCategory(CATEGORY_SPECIAL_SUMMON)
	e1:SetType(EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_O)
	e1:SetProperty(EFFECT_FLAG_DELAY)
	e1:SetCode(EVENT_SPSUMMON_SUCCESS)
	e1:SetCountLimit(1,id)
	e1:SetTarget(s.sptg)
	e1:SetOperation(s.spop)
	c:RegisterEffect(e1)
	--Detach 1; look at and reorder the top 5 cards of both Decks
	local e2=Effect.CreateEffect(c)
	e2:SetDescription(aux.Stringid(STRING_ID,1))
	e2:SetType(EFFECT_TYPE_QUICK_O)
	e2:SetCode(EVENT_FREE_CHAIN)
	e2:SetRange(LOCATION_MZONE)
	e2:SetCountLimit(1,id+100)
	e2:SetCondition(s.maincon)
	e2:SetCost(s.detachcost)
	e2:SetOperation(s.sortop)
	c:RegisterEffect(e2)
end
s.listed_series={SET_AIP}
function s.owner(c)
	if c.GetOwner then return c:GetOwner() end
	return c:GetControler()
end
function s.xyzlvtg(e,c)
	return c:IsType(TYPE_MONSTER) and s.owner(c)~=e:GetHandlerPlayer()
end
function s.xyzlv(e,c,rc)
	if rc==e:GetHandler() then return 6 end
	return c:GetLevel()
end
function s.spfilter(c,e,tp)
	return c:IsRace(RACE_BEAST) and c:IsCanBeSpecialSummoned(e,0,tp,false,false)
end
function s.sptg(e,tp,eg,ep,ev,re,r,rp,chk)
	if chk==0 then return Duel.GetLocationCount(tp,LOCATION_MZONE)>0
		and Duel.IsExistingMatchingCard(aux.NecroValleyFilter(s.spfilter),tp,LOCATION_HAND+LOCATION_GRAVE,LOCATION_GRAVE,1,nil,e,tp) end
	Duel.SetOperationInfo(0,CATEGORY_SPECIAL_SUMMON,nil,1,tp,LOCATION_HAND+LOCATION_GRAVE)
end
function s.spop(e,tp,eg,ep,ev,re,r,rp)
	if Duel.GetLocationCount(tp,LOCATION_MZONE)<=0 then return end
	Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_SPSUMMON)
	local g=Duel.SelectMatchingCard(tp,aux.NecroValleyFilter(s.spfilter),tp,LOCATION_HAND+LOCATION_GRAVE,LOCATION_GRAVE,1,1,nil,e,tp)
	local tc=g:GetFirst()
	if tc then
		Duel.SpecialSummon(tc,0,tp,tp,false,false,POS_FACEUP)
	end
end
function s.maincon(e,tp,eg,ep,ev,re,r,rp)
	local ph=Duel.GetCurrentPhase()
	return ph==PHASE_MAIN1 or ph==PHASE_MAIN2
end
function s.detachcost(e,tp,eg,ep,ev,re,r,rp,chk)
	if chk==0 then return e:GetHandler():CheckRemoveOverlayCard(tp,1,REASON_COST) end
	e:GetHandler():RemoveOverlayCard(tp,1,1,REASON_COST)
end
function s.sortone(tp,p)
	local ct=math.min(5,Duel.GetFieldGroupCount(p,LOCATION_DECK,0))
	if ct<=0 then return end
	Duel.ConfirmDecktop(tp,p,ct)
	Duel.SortDecktop(tp,p,ct)
end
function s.sortop(e,tp,eg,ep,ev,re,r,rp)
	s.sortone(tp,tp)
	s.sortone(tp,1-tp)
end

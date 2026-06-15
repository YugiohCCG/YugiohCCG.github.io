local s,id=GetID()
local SET_GRAYSCALE=SET_GRAYSCALE or 0x575d
local ZONES_MMZ=ZONES_MMZ or 0x1f
local STRING_ID=id
function s.initial_effect(c)
	c:EnableReviveLimit()
	--Xyz Summon procedure
	if Xyz and Xyz.AddProcedure then
		Xyz.AddProcedure(c,nil,8,2,nil,nil,2,nil,nil,s.xyzcheck)
	elseif aux.AddXyzProcedure then
		aux.AddXyzProcedure(c,nil,8,2,nil,nil,2,nil,nil,s.xyzcheck)
	end
	--Cannot be used as Link Material, except for a "Grayscale" monster
	local e0=Effect.CreateEffect(c)
	e0:SetType(EFFECT_TYPE_SINGLE)
	e0:SetProperty(EFFECT_FLAG_CANNOT_DISABLE+EFFECT_FLAG_UNCOPYABLE)
	e0:SetCode(EFFECT_CANNOT_BE_LINK_MATERIAL)
	e0:SetValue(s.linklimit)
	c:RegisterEffect(e0)
	--Detach 1 material; Special Summon 1 "Grayscale" monster from your GY
	local e1=Effect.CreateEffect(c)
	e1:SetDescription(aux.Stringid(STRING_ID,0))
	e1:SetCategory(CATEGORY_SPECIAL_SUMMON)
	e1:SetType(EFFECT_TYPE_IGNITION)
	e1:SetRange(LOCATION_MZONE)
	e1:SetCountLimit(1,id)
	e1:SetCost(s.detach1)
	e1:SetTarget(s.sptg)
	e1:SetOperation(s.spop)
	c:RegisterEffect(e1)
	--Detach 1 material; change that GY/banishment effect
	local e2=Effect.CreateEffect(c)
	e2:SetDescription(aux.Stringid(STRING_ID,1))
	e2:SetType(EFFECT_TYPE_QUICK_O)
	e2:SetCode(EVENT_CHAINING)
	e2:SetRange(LOCATION_MZONE)
	e2:SetCountLimit(1,id+100)
	e2:SetCondition(s.chcon)
	e2:SetCost(s.detach1)
	e2:SetTarget(s.chtg)
	e2:SetOperation(s.chop)
	c:RegisterEffect(e2)
end
s.listed_series={SET_GRAYSCALE}
function s.lightfiendmat(c)
	return c:IsAttribute(ATTRIBUTE_LIGHT) and c:IsRace(RACE_FIEND)
end
function s.xyzcheck(g,tp,xyz)
	return g:IsExists(s.lightfiendmat,1,nil)
end
function s.linklimit(e,c)
	return c and not c:IsSetCard(SET_GRAYSCALE)
end
function s.detach1(e,tp,eg,ep,ev,re,r,rp,chk)
	if chk==0 then return e:GetHandler():CheckRemoveOverlayCard(tp,1,REASON_COST) end
	e:GetHandler():RemoveOverlayCard(tp,1,1,REASON_COST)
end
function s.spfilter(c,e,tp,zone)
	if not (c:IsSetCard(SET_GRAYSCALE) and c:IsType(TYPE_MONSTER)) then return false end
	if zone then
		return c:IsCanBeSpecialSummoned(e,0,tp,false,false,POS_FACEUP,tp,zone)
	end
	return c:IsCanBeSpecialSummoned(e,0,tp,false,false)
end
function s.sptg(e,tp,eg,ep,ev,re,r,rp,chk)
	if chk==0 then return Duel.GetLocationCount(tp,LOCATION_MZONE)>0
		and Duel.IsExistingMatchingCard(aux.NecroValleyFilter(s.spfilter),tp,LOCATION_GRAVE,0,1,nil,e,tp) end
	Duel.SetOperationInfo(0,CATEGORY_SPECIAL_SUMMON,nil,1,tp,LOCATION_GRAVE)
end
function s.spop(e,tp,eg,ep,ev,re,r,rp)
	if Duel.GetLocationCount(tp,LOCATION_MZONE)<=0 then return end
	Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_SPSUMMON)
	local g=Duel.SelectMatchingCard(tp,aux.NecroValleyFilter(s.spfilter),tp,LOCATION_GRAVE,0,1,1,nil,e,tp)
	local tc=g:GetFirst()
	if tc then
		Duel.SpecialSummon(tc,0,tp,tp,false,false,POS_FACEUP)
	end
end
function s.chcon(e,tp,eg,ep,ev,re,r,rp)
	local loc=re:GetActivateLocation()
	return rp==1-tp and (loc==LOCATION_GRAVE or loc==LOCATION_REMOVED)
end
function s.repfilter(c,p,e)
	local zone=c:GetLinkedZone(p)&ZONES_MMZ
	return s.linkfilter(c,p,e)
		and Duel.IsExistingMatchingCard(aux.NecroValleyFilter(s.spfilter),p,LOCATION_GRAVE,0,1,nil,e,p,zone)
end
function s.chtg(e,tp,eg,ep,ev,re,r,rp,chk)
	local p=1-tp
	if chk==0 then return Duel.IsExistingMatchingCard(s.repfilter,p,LOCATION_MZONE,0,1,nil,p,e) end
end
function s.chop(e,tp,eg,ep,ev,re,r,rp)
	Duel.ChangeTargetCard(ev,Group.CreateGroup())
	Duel.ChangeChainOperation(ev,s.repop)
end
function s.linkfilter(c,p,e)
	local zone=c:GetLinkedZone(p)&ZONES_MMZ
	return c:IsFaceup() and c:IsSetCard(SET_GRAYSCALE) and c:IsType(TYPE_LINK)
		and zone~=0 and Duel.GetLocationCount(p,LOCATION_MZONE,p,LOCATION_REASON_TOFIELD,zone)>0
end
function s.repop(e,tp,eg,ep,ev,re,r,rp)
	local p=1-tp
	if not Duel.IsExistingMatchingCard(s.repfilter,p,LOCATION_MZONE,0,1,nil,p,e) then return end
	Duel.Hint(HINT_SELECTMSG,p,HINTMSG_FACEUP)
	local lc=Duel.SelectMatchingCard(p,s.repfilter,p,LOCATION_MZONE,0,1,1,nil,p,e):GetFirst()
	if not lc then return end
	local zone=lc:GetLinkedZone(p)&ZONES_MMZ
	if zone==0 then return end
	if not Duel.IsExistingMatchingCard(aux.NecroValleyFilter(s.spfilter),p,LOCATION_GRAVE,0,1,nil,e,p,zone) then return end
	Duel.Hint(HINT_SELECTMSG,p,HINTMSG_SPSUMMON)
	local g=Duel.SelectMatchingCard(p,aux.NecroValleyFilter(s.spfilter),p,LOCATION_GRAVE,0,1,1,nil,e,p,zone)
	local tc=g:GetFirst()
	if tc then
		Duel.SpecialSummon(tc,0,p,p,false,false,POS_FACEUP,zone)
	end
end

local s,id=GetID()
local SET_GRAYSCALE=SET_GRAYSCALE or 0x575d
local STRING_ID=id
function s.initial_effect(c)
	c:EnableReviveLimit()
	--Link Summon procedure
	if Link and Link.AddProcedure then
		Link.AddProcedure(c,s.matfilter,2,4,s.lcheck)
	elseif aux.AddLinkProcedure then
		aux.AddLinkProcedure(c,s.matfilter,2,4,s.lcheck)
	end
	--Cannot be used as Link Material, except for a "Grayscale" monster
	local e0=Effect.CreateEffect(c)
	e0:SetType(EFFECT_TYPE_SINGLE)
	e0:SetProperty(EFFECT_FLAG_CANNOT_DISABLE+EFFECT_FLAG_UNCOPYABLE)
	e0:SetCode(EFFECT_CANNOT_BE_LINK_MATERIAL)
	e0:SetValue(s.linklimit)
	c:RegisterEffect(e0)
	--All "Grayscale" monsters you control gain 800 ATK
	local e1=Effect.CreateEffect(c)
	e1:SetType(EFFECT_TYPE_FIELD)
	e1:SetCode(EFFECT_UPDATE_ATTACK)
	e1:SetRange(LOCATION_MZONE)
	e1:SetTargetRange(LOCATION_MZONE,0)
	e1:SetTarget(s.atktg)
	e1:SetValue(800)
	c:RegisterEffect(e1)
	--Tribute a pointed "Grayscale" monster; change that monster effect
	local e2=Effect.CreateEffect(c)
	e2:SetDescription(aux.Stringid(STRING_ID,0))
	e2:SetType(EFFECT_TYPE_QUICK_O)
	e2:SetCode(EVENT_CHAINING)
	e2:SetRange(LOCATION_MZONE)
	e2:SetCountLimit(1,id)
	e2:SetCondition(s.chcon)
	e2:SetCost(s.chcost)
	e2:SetOperation(s.chop)
	c:RegisterEffect(e2)
end
s.listed_series={SET_GRAYSCALE}
function s.matfilter(c,lc,sumtype,tp)
	return c:IsAttribute(ATTRIBUTE_LIGHT) and c:IsRace(RACE_FIEND)
end
function s.graymat(c)
	return c:IsSetCard(SET_GRAYSCALE)
end
function s.lcheck(g,lc,sumtype,tp)
	return g:IsExists(s.graymat,1,nil)
end
function s.linklimit(e,c)
	return c and not c:IsSetCard(SET_GRAYSCALE)
end
function s.atktg(e,c)
	return c:IsFaceup() and c:IsSetCard(SET_GRAYSCALE)
end
function s.chcon(e,tp,eg,ep,ev,re,r,rp)
	return rp==1-tp and re:IsActiveType(TYPE_MONSTER)
end
function s.relfilter(c,lg)
	return c:IsFaceup() and c:IsSetCard(SET_GRAYSCALE) and c:IsReleasable()
		and lg:IsContains(c)
end
function s.chcost(e,tp,eg,ep,ev,re,r,rp,chk)
	local lg=e:GetHandler():GetLinkedGroup()
	if chk==0 then return Duel.IsExistingMatchingCard(s.relfilter,tp,LOCATION_MZONE,0,1,nil,lg) end
	Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_RELEASE)
	local g=Duel.SelectMatchingCard(tp,s.relfilter,tp,LOCATION_MZONE,0,1,1,nil,lg)
	Duel.Release(g,REASON_COST)
end
function s.chop(e,tp,eg,ep,ev,re,r,rp)
	Duel.ChangeTargetCard(ev,Group.CreateGroup())
	Duel.ChangeChainOperation(ev,s.repop)
end
function s.spfilter(c,e,tp)
	return c:IsSetCard(SET_GRAYSCALE) and c:IsType(TYPE_MONSTER)
		and c:IsCanBeSpecialSummoned(e,0,tp,false,false)
end
function s.xyzfilter(c)
	return c:IsFaceup() and c:IsSetCard(SET_GRAYSCALE) and c:IsType(TYPE_XYZ)
end
function s.gymatfilter(c)
	return c:IsType(TYPE_MONSTER)
end
function s.repop(e,tp,eg,ep,ev,re,r,rp)
	local p=1-tp
	if Duel.GetLocationCount(p,LOCATION_MZONE)>0
		and Duel.IsExistingMatchingCard(aux.NecroValleyFilter(s.spfilter),p,LOCATION_HAND+LOCATION_GRAVE,0,1,nil,e,p) then
		Duel.Hint(HINT_SELECTMSG,p,HINTMSG_SPSUMMON)
		local sg=Duel.SelectMatchingCard(p,aux.NecroValleyFilter(s.spfilter),p,LOCATION_HAND+LOCATION_GRAVE,0,1,1,nil,e,p)
		local sc=sg:GetFirst()
		if sc then
			Duel.SpecialSummon(sc,0,p,p,false,false,POS_FACEUP)
		end
	end
	if Duel.IsExistingMatchingCard(s.xyzfilter,p,LOCATION_MZONE,0,1,nil)
		and Duel.IsExistingMatchingCard(aux.NecroValleyFilter(s.gymatfilter),p,LOCATION_GRAVE,LOCATION_GRAVE,1,nil)
		and Duel.SelectYesNo(p,aux.Stringid(STRING_ID,1)) then
		Duel.Hint(HINT_SELECTMSG,p,HINTMSG_XMATERIAL)
		local mg=Duel.SelectMatchingCard(p,aux.NecroValleyFilter(s.gymatfilter),p,LOCATION_GRAVE,LOCATION_GRAVE,1,1,nil)
		Duel.Hint(HINT_SELECTMSG,p,HINTMSG_FACEUP)
		local xc=Duel.SelectMatchingCard(p,s.xyzfilter,p,LOCATION_MZONE,0,1,1,nil):GetFirst()
		if xc and #mg>0 then
			Duel.Overlay(xc,mg)
		end
	end
end

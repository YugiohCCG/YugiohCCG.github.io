local s,id=GetID()
local SET_GRAYSCALE=SET_GRAYSCALE or 0x575d
local STRING_ID=id
function s.initial_effect(c)
	c:EnableReviveLimit()
	--Link Summon procedure
	if Link and Link.AddProcedure then
		Link.AddProcedure(c,s.matfilter,2,2,s.lcheck)
	elseif aux.AddLinkProcedure then
		aux.AddLinkProcedure(c,s.matfilter,2,2,s.lcheck)
	end
	--Cannot be used as Link Material, except for a "Grayscale" monster
	local e0=Effect.CreateEffect(c)
	e0:SetType(EFFECT_TYPE_SINGLE)
	e0:SetProperty(EFFECT_FLAG_CANNOT_DISABLE+EFFECT_FLAG_UNCOPYABLE)
	e0:SetCode(EFFECT_CANNOT_BE_LINK_MATERIAL)
	e0:SetValue(s.linklimit)
	c:RegisterEffect(e0)
	--Monsters this card points to are unaffected by your opponent's card effects
	local e1=Effect.CreateEffect(c)
	e1:SetType(EFFECT_TYPE_FIELD)
	e1:SetCode(EFFECT_IMMUNE_EFFECT)
	e1:SetRange(LOCATION_MZONE)
	e1:SetTargetRange(LOCATION_MZONE,LOCATION_MZONE)
	e1:SetTarget(s.immtg)
	e1:SetValue(s.immval)
	c:RegisterEffect(e1)
	--Discard 1 card; Special Summon 1 non-Link "Grayscale" monster
	local e2=Effect.CreateEffect(c)
	e2:SetDescription(aux.Stringid(STRING_ID,0))
	e2:SetCategory(CATEGORY_SPECIAL_SUMMON)
	e2:SetType(EFFECT_TYPE_QUICK_O)
	e2:SetCode(EVENT_FREE_CHAIN)
	e2:SetRange(LOCATION_MZONE)
	e2:SetCountLimit(1,id)
	e2:SetCondition(s.maincon)
	e2:SetTarget(s.sptg)
	e2:SetOperation(s.spop)
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
function s.immtg(e,c)
	return e:GetHandler():GetLinkedGroup():IsContains(c)
end
function s.immval(e,re)
	return re:GetOwnerPlayer()~=e:GetHandlerPlayer()
end
function s.maincon(e,tp,eg,ep,ev,re,r,rp)
	local ph=Duel.GetCurrentPhase()
	return ph==PHASE_MAIN1 or ph==PHASE_MAIN2
end
function s.spfilter(c,e,tp)
	return c:IsSetCard(SET_GRAYSCALE) and c:IsType(TYPE_MONSTER) and not c:IsType(TYPE_LINK)
		and c:IsCanBeSpecialSummoned(e,0,tp,false,false)
end
function s.sptg(e,tp,eg,ep,ev,re,r,rp,chk)
	if chk==0 then return Duel.GetFieldGroupCount(tp,LOCATION_HAND,0)>0
		and Duel.GetLocationCount(tp,LOCATION_MZONE)>0
		and Duel.IsExistingMatchingCard(aux.NecroValleyFilter(s.spfilter),tp,LOCATION_DECK+LOCATION_GRAVE,0,1,nil,e,tp) end
	Duel.SetOperationInfo(0,CATEGORY_SPECIAL_SUMMON,nil,1,tp,LOCATION_DECK+LOCATION_GRAVE)
end
function s.spop(e,tp,eg,ep,ev,re,r,rp)
	if Duel.GetLocationCount(tp,LOCATION_MZONE)<=0 then return end
	if Duel.DiscardHand(tp,aux.TRUE,1,1,REASON_EFFECT+REASON_DISCARD)<=0 then return end
	Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_SPSUMMON)
	local g=Duel.SelectMatchingCard(tp,aux.NecroValleyFilter(s.spfilter),tp,LOCATION_DECK+LOCATION_GRAVE,0,1,1,nil,e,tp)
	local tc=g:GetFirst()
	if tc then
		Duel.SpecialSummon(tc,0,tp,tp,false,false,POS_FACEUP)
	end
end

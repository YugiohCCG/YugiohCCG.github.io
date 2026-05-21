local s,id=GetID()
local SET_NEMLERIA_OMEGA=0x191
local SET_NEMLERIA_PI=0x192
local CARD_DREAMING_NEMLERIA=CARD_DREAMING_NEMLERIA or 70155677
local STRING_ID=id
local NEMLERIA_ST={
	[18458255]=true,
	[33499794]=true,
	[44843954]=true,
	[57296396]=true,
	[259017109]=true,
	[259090287]=true,
	[259605536]=true,
	[259766646]=true,
	[259883971]=true,
}
function s.initial_effect(c)
	--Activate
	local e1=Effect.CreateEffect(c)
	e1:SetDescription(aux.Stringid(STRING_ID,0))
	e1:SetCategory(CATEGORY_TOEXTRA)
	e1:SetType(EFFECT_TYPE_ACTIVATE)
	e1:SetCode(EVENT_FREE_CHAIN)
	e1:SetCountLimit(1,id)
	e1:SetTarget(s.target)
	e1:SetOperation(s.activate)
	c:RegisterEffect(e1)
end
s.listed_names={CARD_DREAMING_NEMLERIA}
s.listed_series={SET_NEMLERIA_OMEGA,SET_NEMLERIA_PI}
function s.exfilter(c)
	return c:IsCode(CARD_DREAMING_NEMLERIA) and not c:IsForbidden()
end
function s.setfilter(c)
	return (c:IsSetCard(SET_NEMLERIA_OMEGA) or c:IsSetCard(SET_NEMLERIA_PI) or NEMLERIA_ST[c:GetCode()])
		and (c:IsType(TYPE_SPELL) or c:IsType(TYPE_TRAP)) and c:IsSSetable()
end
function s.target(e,tp,eg,ep,ev,re,r,rp,chk)
	if chk==0 then
		return Duel.IsExistingMatchingCard(s.exfilter,tp,LOCATION_HAND|LOCATION_DECK,0,1,nil)
			and Duel.GetLocationCount(tp,LOCATION_SZONE)>0
			and Duel.IsExistingMatchingCard(aux.NecroValleyFilter(s.setfilter),tp,LOCATION_DECK|LOCATION_GRAVE,0,1,nil)
	end
	Duel.SetOperationInfo(0,CATEGORY_TOEXTRA,nil,1,tp,LOCATION_HAND|LOCATION_DECK)
end
function s.activate(e,tp,eg,ep,ev,re,r,rp)
	Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_TOEXTRA)
	local tg=Duel.SelectMatchingCard(tp,s.exfilter,tp,LOCATION_HAND|LOCATION_DECK,0,1,1,nil)
	local tc=tg:GetFirst()
	if not tc then return end
	Duel.SendtoExtraP(tg,tp,REASON_EFFECT)
	if not tc:IsLocation(LOCATION_EXTRA) then return end
	if Duel.GetLocationCount(tp,LOCATION_SZONE)<=0 then return end
	local g=Duel.GetMatchingGroup(aux.NecroValleyFilter(s.setfilter),tp,LOCATION_DECK|LOCATION_GRAVE,0,nil)
	if #g==0 then return end
	Duel.BreakEffect()
	Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_SET)
	local sg=g:Select(tp,1,1,nil)
	if #sg>0 then
		Duel.SSet(tp,sg)
	end
end

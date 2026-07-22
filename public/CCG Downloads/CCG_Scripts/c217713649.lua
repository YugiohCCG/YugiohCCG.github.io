--ONIBI
local s,id=GetID()
local STRING_ID=133713649
function s.initial_effect(c)
	--Spirit return
	aux.EnableSpiritReturn(c,EVENT_SUMMON_SUCCESS,EVENT_FLIP)
	--Cannot be Special Summoned
	local e1=Effect.CreateEffect(c)
	e1:SetType(EFFECT_TYPE_SINGLE)
	e1:SetProperty(EFFECT_FLAG_CANNOT_DISABLE+EFFECT_FLAG_UNCOPYABLE)
	e1:SetCode(EFFECT_SPSUMMON_CONDITION)
	e1:SetValue(aux.FALSE)
	c:RegisterEffect(e1)
	--Normal Summon 1 Spirit monster
	local e2=Effect.CreateEffect(c)
	e2:SetDescription(aux.Stringid(STRING_ID,0))
	e2:SetCategory(CATEGORY_SUMMON+CATEGORY_RELEASE+CATEGORY_TOHAND+CATEGORY_SEARCH)
	e2:SetType(EFFECT_TYPE_QUICK_O)
	e2:SetCode(EVENT_FREE_CHAIN)
	e2:SetRange(LOCATION_HAND+LOCATION_MZONE)
	e2:SetCountLimit(1,id)
	e2:SetCondition(s.sumcon)
	e2:SetCost(s.sumcost)
	e2:SetTarget(s.sumtg)
	e2:SetOperation(s.sumop)
	c:RegisterEffect(e2)
end
function s.sumcon(e,tp,eg,ep,ev,re,r,rp)
	return Duel.IsMainPhase()
end
function s.spiritfilter(c)
	return c:IsType(TYPE_SPIRIT) and c:IsSummonable(true,nil)
end
function s.onibifilter(c)
	return c:IsCode(id) and c:IsSummonable(true,nil)
end
function s.canrelease(e,tp)
	local c=e:GetHandler()
	return c:IsLocation(LOCATION_HAND) and c:IsReleasable()
		and Duel.IsExistingMatchingCard(s.spiritfilter,tp,LOCATION_HAND,0,1,c)
end
function s.cannormal(e,tp)
	local c=e:GetHandler()
	if c:IsLocation(LOCATION_HAND) and c:IsSummonable(true,nil) then return true end
	return Duel.IsExistingMatchingCard(s.onibifilter,tp,LOCATION_HAND,0,1,c)
end
function s.sumcost(e,tp,eg,ep,ev,re,r,rp,chk)
	if chk==0 then return s.canrelease(e,tp) or s.cannormal(e,tp) end
	local rel=s.canrelease(e,tp)
	local norm=s.cannormal(e,tp)
	if rel and (not norm or Duel.SelectYesNo(tp,aux.Stringid(STRING_ID,1))) then
		Duel.Release(e:GetHandler(),REASON_COST)
		e:SetLabel(1)
	else
		e:SetLabel(0)
	end
end
function s.sumtg(e,tp,eg,ep,ev,re,r,rp,chk)
	if chk==0 then
		return s.canrelease(e,tp) or s.cannormal(e,tp)
	end
	Duel.SetOperationInfo(0,CATEGORY_SUMMON,nil,1,0,0)
end
function s.thfilter(c)
	return c:IsType(TYPE_SPIRIT) and not c:IsCode(id) and c:IsAbleToHand()
end
function s.sumop(e,tp,eg,ep,ev,re,r,rp)
	local f=s.onibifilter
	if e:GetLabel()==1 then f=s.spiritfilter end
	if not Duel.IsExistingMatchingCard(f,tp,LOCATION_HAND,0,1,nil) then return end
	Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_SUMMON)
	local tc=Duel.SelectMatchingCard(tp,f,tp,LOCATION_HAND,0,1,1,nil):GetFirst()
	if not tc then return end
	Duel.Summon(tp,tc,true,nil)
	if tc:IsCode(id) and tc:IsLocation(LOCATION_MZONE)
		and Duel.IsExistingMatchingCard(s.thfilter,tp,LOCATION_DECK,0,1,nil)
		and Duel.SelectYesNo(tp,aux.Stringid(STRING_ID,2)) then
		Duel.BreakEffect()
		Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_ATOHAND)
		local g=Duel.SelectMatchingCard(tp,s.thfilter,tp,LOCATION_DECK,0,1,1,nil)
		if #g>0 and Duel.SendtoHand(g,nil,REASON_EFFECT)>0 then
			Duel.ConfirmCards(1-tp,g)
		end
	end
end

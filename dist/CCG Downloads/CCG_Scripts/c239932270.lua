local s,id=GetID()
local STRING_ID=133932270
local SET_FLOO=0x16d
function s.initial_effect(c)
	local e=Effect.CreateEffect(c)
	e:SetDescription(aux.Stringid(STRING_ID,0))
	e:SetType(EFFECT_TYPE_ACTIVATE)
	e:SetCode(EVENT_FREE_CHAIN)
	e:SetCountLimit(1,id)
	e:SetTarget(s.target)
	e:SetOperation(s.operation)
	c:RegisterEffect(e)
	local e2=Effect.CreateEffect(c)
	e2:SetDescription(aux.Stringid(STRING_ID,1))
	e2:SetCategory(CATEGORY_TOHAND)
	e2:SetType(EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_O)
	e2:SetCode(EVENT_REMOVE)
	e2:SetProperty(EFFECT_FLAG_DELAY)
	e2:SetCountLimit(1,id+100)
	e2:SetCost(s.retcost)
	e2:SetTarget(s.rettg)
	e2:SetOperation(s.retop)
	c:RegisterEffect(e2)
end
function s.placefilter(c,e,tp)
	return c:IsSetCard(SET_FLOO) and c:IsType(TYPE_SPELL)
		and (c:IsType(TYPE_FIELD) or c:IsType(TYPE_CONTINUOUS) and Duel.GetLocationCount(tp,LOCATION_SZONE)>0)
		and not c:IsForbidden()
end
function s.own(c,e)
	return c:IsFaceup() and c:IsRace(RACE_WINDBEAST) and c:IsSummonType(SUMMON_TYPE_NORMAL)
		and s.removable(c,e)
end
function s.removable(c,e)
	return c:IsAbleToRemove() and not c:IsImmuneToEffect(e)
end
function s.tribute(c)
	return c:IsFaceup() and c:IsRace(RACE_WINDBEAST) and c:IsSummonType(SUMMON_TYPE_ADVANCE)
end
function s.options(e,tp)
	local place=Duel.IsExistingMatchingCard(aux.NecroValleyFilter(s.placefilter),tp,LOCATION_DECK+LOCATION_GRAVE,0,1,nil,e,tp)
	local banish=Duel.IsExistingMatchingCard(s.own,tp,LOCATION_MZONE,0,1,nil,e)
		and Duel.IsExistingMatchingCard(s.removable,tp,0,LOCATION_MZONE,1,nil,e)
	return place,banish
end
function s.target(e,tp,eg,ep,ev,re,r,rp,chk)
	local place,banish=s.options(e,tp)
	if chk==0 then return place or banish end
	local options,modes={},{}
	if place then options[#options+1]=aux.Stringid(STRING_ID,2) modes[#modes+1]=1 end
	if banish then options[#options+1]=aux.Stringid(STRING_ID,3) modes[#modes+1]=2 end
	if place and banish and Duel.IsExistingMatchingCard(s.tribute,tp,LOCATION_MZONE,0,1,nil) then
		options[#options+1]=aux.Stringid(STRING_ID,4)
		modes[#modes+1]=3
	end
	e:SetLabel(modes[#modes==1 and 1 or Duel.SelectOption(tp,table.unpack(options))+1])
end
function s.operation(e,tp)
	local mode=e:GetLabel()
	if mode&1~=0 then
		Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_TOFIELD)
		local tc=Duel.SelectMatchingCard(tp,aux.NecroValleyFilter(s.placefilter),tp,LOCATION_DECK+LOCATION_GRAVE,0,1,1,nil,e,tp):GetFirst()
		if tc then
			local loc=tc:IsType(TYPE_FIELD) and LOCATION_FZONE or LOCATION_SZONE
			if loc==LOCATION_FZONE then
				local current=Duel.GetFieldCard(tp,LOCATION_FZONE,0)
				if current then Duel.SendtoGrave(current,REASON_RULE) end
			end
			Duel.MoveToField(tc,tp,tp,loc,POS_FACEUP,true)
		end
	end
	if mode==3 then Duel.BreakEffect() end
	if mode&2~=0 and Duel.IsExistingMatchingCard(s.own,tp,LOCATION_MZONE,0,1,nil,e)
		and Duel.IsExistingMatchingCard(s.removable,tp,0,LOCATION_MZONE,1,nil,e) then
		Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_REMOVE)
		local g=Duel.SelectMatchingCard(tp,s.own,tp,LOCATION_MZONE,0,1,1,nil,e)
		Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_REMOVE)
		g:Merge(Duel.SelectMatchingCard(tp,s.removable,tp,0,LOCATION_MZONE,1,1,nil,e))
		Duel.Remove(g,POS_FACEUP,REASON_EFFECT)
	end
end
function s.retcost(e,tp,eg,ep,ev,re,r,rp,chk)
	if chk==0 then return Duel.IsExistingMatchingCard(Card.IsAbleToRemoveAsCost,tp,LOCATION_HAND,0,1,nil) end
	Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_REMOVE)
	local g=Duel.SelectMatchingCard(tp,Card.IsAbleToRemoveAsCost,tp,LOCATION_HAND,0,1,1,nil)
	Duel.Remove(g,POS_FACEUP,REASON_COST)
end
function s.rettg(e,tp,eg,ep,ev,re,r,rp,chk)
	if chk==0 then return e:GetHandler():IsAbleToHand() end
	Duel.SetOperationInfo(0,CATEGORY_TOHAND,e:GetHandler(),1,tp,LOCATION_REMOVED)
end
function s.retop(e,tp)
	local c=e:GetHandler()
	if c:IsRelateToEffect(e) then Duel.SendtoHand(c,nil,REASON_EFFECT) end
end

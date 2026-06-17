--The Flying Frute
local s,id=GetID()
local SET_FRUTE=0x813
function s.initial_effect(c)
	--Link Summon using face-down monsters you control
	local e0=aux.AddLinkProcedure(c,s.matfilter,2,2)
	e0:SetProperty(EFFECT_FLAG_CANNOT_DISABLE+EFFECT_FLAG_UNCOPYABLE+EFFECT_FLAG_SET_AVAILABLE)
	c:EnableReviveLimit()
	--If Link Summoned: send or Set 1 "Frute" card
	local e1=Effect.CreateEffect(c)
	e1:SetDescription(aux.Stringid(id,0))
	e1:SetCategory(CATEGORY_TOGRAVE+CATEGORY_SSET)
	e1:SetType(EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_O)
	e1:SetCode(EVENT_SPSUMMON_SUCCESS)
	e1:SetProperty(EFFECT_FLAG_DELAY)
	e1:SetCountLimit(1,id)
	e1:SetCondition(s.sumcon)
	e1:SetTarget(s.sstg)
	e1:SetOperation(s.ssop)
	c:RegisterEffect(e1)
	--Tribute 1 other WATER monster; banish 1 card in either GY
	local e2=Effect.CreateEffect(c)
	e2:SetDescription(aux.Stringid(id,1))
	e2:SetCategory(CATEGORY_RELEASE+CATEGORY_REMOVE)
	e2:SetType(EFFECT_TYPE_QUICK_O)
	e2:SetCode(EVENT_FREE_CHAIN)
	e2:SetRange(LOCATION_MZONE)
	e2:SetHintTiming(0,TIMINGS_CHECK_MONSTER+TIMING_END_PHASE)
	e2:SetCountLimit(1,id+100)
	e2:SetCost(s.rmcost)
	e2:SetTarget(s.rmtg)
	e2:SetOperation(s.rmop)
	c:RegisterEffect(e2)
end
function s.matfilter(c,lc,sumtype,tp)
	return c:IsAttribute(ATTRIBUTE_WATER)
end
function s.sumcon(e,tp,eg,ep,ev,re,r,rp)
	return e:GetHandler():IsSummonType(SUMMON_TYPE_LINK)
end
function s.tgfilter(c)
	return c:IsSetCard(SET_FRUTE) and c:IsAbleToGrave()
end
function s.setfilter(c)
	return c:IsSetCard(SET_FRUTE) and c:IsType(TYPE_SPELL+TYPE_TRAP) and c:IsSSetable()
		and (not c:IsLocation(LOCATION_REMOVED) or c:IsFaceup())
end
function s.sstg(e,tp,eg,ep,ev,re,r,rp,chk)
	local b1=Duel.IsExistingMatchingCard(s.tgfilter,tp,LOCATION_DECK,0,1,nil)
	local b2=Duel.GetLocationCount(tp,LOCATION_SZONE)>0
		and Duel.IsExistingMatchingCard(aux.NecroValleyFilter(s.setfilter),tp,LOCATION_GRAVE+LOCATION_REMOVED,0,1,nil)
	if chk==0 then return b1 or b2 end
	if b1 and b2 then
		e:SetLabel(Duel.SelectOption(tp,aux.Stringid(id,2),aux.Stringid(id,3)))
	elseif b2 then
		e:SetLabel(1)
	else
		e:SetLabel(0)
	end
	if e:GetLabel()==0 then
		Duel.SetOperationInfo(0,CATEGORY_TOGRAVE,nil,1,tp,LOCATION_DECK)
	else
		Duel.SetOperationInfo(0,CATEGORY_SSET,nil,1,tp,LOCATION_GRAVE+LOCATION_REMOVED)
	end
end
function s.ssop(e,tp,eg,ep,ev,re,r,rp)
	if e:GetLabel()==0 then
		if not Duel.IsExistingMatchingCard(s.tgfilter,tp,LOCATION_DECK,0,1,nil) then return end
		Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_TOGRAVE)
		local tc=Duel.SelectMatchingCard(tp,s.tgfilter,tp,LOCATION_DECK,0,1,1,nil):GetFirst()
		if tc then
			Duel.SendtoGrave(tc,REASON_EFFECT)
		end
	else
		if Duel.GetLocationCount(tp,LOCATION_SZONE)<=0 then return end
		if not Duel.IsExistingMatchingCard(aux.NecroValleyFilter(s.setfilter),tp,LOCATION_GRAVE+LOCATION_REMOVED,0,1,nil) then return end
		Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_SET)
		local tc=Duel.SelectMatchingCard(tp,aux.NecroValleyFilter(s.setfilter),tp,LOCATION_GRAVE+LOCATION_REMOVED,0,1,1,nil):GetFirst()
		if tc then
			Duel.SSet(tp,tc)
		end
	end
end
function s.rlfilter(c,sc)
	return c:IsAttribute(ATTRIBUTE_WATER) and c:IsReleasable() and c~=sc
end
function s.rmcost(e,tp,eg,ep,ev,re,r,rp,chk)
	local c=e:GetHandler()
	if chk==0 then return Duel.IsExistingMatchingCard(s.rlfilter,tp,LOCATION_HAND+LOCATION_MZONE,0,1,c,c) end
	Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_RELEASE)
	local g=Duel.SelectMatchingCard(tp,s.rlfilter,tp,LOCATION_HAND+LOCATION_MZONE,0,1,1,c,c)
	Duel.Release(g,REASON_COST)
end
function s.rmfilter(c)
	return c:IsAbleToRemove()
end
function s.rmtg(e,tp,eg,ep,ev,re,r,rp,chk,chkc)
	if chkc then return chkc:IsLocation(LOCATION_GRAVE) and aux.NecroValleyFilter(s.rmfilter)(chkc) end
	if chk==0 then return Duel.IsExistingTarget(aux.NecroValleyFilter(s.rmfilter),tp,LOCATION_GRAVE,LOCATION_GRAVE,1,nil) end
	Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_REMOVE)
	local g=Duel.SelectTarget(tp,aux.NecroValleyFilter(s.rmfilter),tp,LOCATION_GRAVE,LOCATION_GRAVE,1,1,nil)
	Duel.SetOperationInfo(0,CATEGORY_REMOVE,g,1,0,0)
end
function s.rmop(e,tp,eg,ep,ev,re,r,rp)
	local tc=Duel.GetFirstTarget()
	if tc and tc:IsRelateToEffect(e) and aux.NecroValleyFilter(s.rmfilter)(tc) then
		Duel.Remove(tc,POS_FACEUP,REASON_EFFECT)
	end
end

local s,id=GetID()
local SET_NEMLERIA_OMEGA=0x191
local SET_NEMLERIA_PI=0x192
local STRING_ID=id
function s.initial_effect(c)
	--Activate
	local e1=Effect.CreateEffect(c)
	e1:SetDescription(aux.Stringid(STRING_ID,0))
	e1:SetCategory(CATEGORY_TODECK+CATEGORY_SPECIAL_SUMMON)
	e1:SetType(EFFECT_TYPE_ACTIVATE)
	e1:SetCode(EVENT_FREE_CHAIN)
	e1:SetCountLimit(1,98091004)
	e1:SetTarget(s.target)
	e1:SetOperation(s.activate)
	c:RegisterEffect(e1)
	--negate
	local e2=Effect.CreateEffect(c)
	e2:SetDescription(aux.Stringid(STRING_ID,1))
	e2:SetCategory(CATEGORY_DISABLE)
	e2:SetType(EFFECT_TYPE_IGNITION)
	e2:SetRange(LOCATION_GRAVE)
	e2:SetCountLimit(1,98091005)
	e2:SetCost(s.negcost)
	e2:SetTarget(s.negtg)
	e2:SetOperation(s.negop)
	c:RegisterEffect(e2)
end
function s.tdfilter(c)
	return c:IsAbleToDeck()
end
function s.target(e,tp,eg,ep,ev,re,r,rp,chk)
	if chk==0 then return Duel.IsExistingMatchingCard(s.tdfilter,tp,LOCATION_REMOVED,LOCATION_REMOVED,1,nil) end
	Duel.SetOperationInfo(0,CATEGORY_TODECK,nil,1,PLAYER_ALL,LOCATION_REMOVED)
end
function s.spfilter(c,e,tp)
	return (c:IsSetCard(SET_NEMLERIA_OMEGA) or c:IsSetCard(SET_NEMLERIA_PI))
		and c:IsType(TYPE_MONSTER) and c:IsCanBeSpecialSummoned(e,0,tp,false,false)
end
function s.activate(e,tp,eg,ep,ev,re,r,rp)
	local g=Duel.GetMatchingGroup(s.tdfilter,tp,LOCATION_REMOVED,LOCATION_REMOVED,nil)
	if #g==0 then return end
	local ct=Duel.SendtoDeck(g,nil,SEQ_DECKSHUFFLE,REASON_EFFECT)
	ct=ct or #g
	local maxct=math.min(math.floor(ct/10),Duel.GetLocationCount(tp,LOCATION_MZONE))
	if Duel.IsPlayerAffectedByEffect(tp,59822133) then maxct=math.min(maxct,1) end
	if maxct<=0 then return end
	local sg=Duel.GetMatchingGroup(aux.NecroValleyFilter(s.spfilter),tp,LOCATION_HAND+LOCATION_GRAVE,0,nil,e,tp)
	if #sg==0 or not Duel.SelectYesNo(tp,aux.Stringid(STRING_ID,2)) then return end
	Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_SPSUMMON)
	local tg=sg:Select(tp,1,math.min(maxct,#sg),nil)
	if #tg>0 then
		Duel.SpecialSummon(tg,0,tp,tp,false,false,POS_FACEUP)
	end
end
function s.negcost(e,tp,eg,ep,ev,re,r,rp,chk)
	local c=e:GetHandler()
	if chk==0 then return c:IsAbleToRemoveAsCost(POS_FACEDOWN) end
	Duel.Remove(c,POS_FACEDOWN,REASON_COST)
end
function s.exfilter(c,tp)
	return c:IsFacedown() and c:IsAbleToRemove(tp,POS_FACEDOWN) and not c:IsCode(70155677)
end
function s.negfilter(c)
	return c:IsFaceup() and c:IsOnField()
end
function s.negtg(e,tp,eg,ep,ev,re,r,rp,chk)
	if chk==0 then
		return Duel.IsExistingMatchingCard(s.exfilter,tp,LOCATION_EXTRA,0,3,nil,tp)
			and Duel.IsExistingMatchingCard(s.negfilter,tp,0,LOCATION_ONFIELD,1,nil)
	end
	Duel.SetOperationInfo(0,CATEGORY_DISABLE,nil,1,0,LOCATION_ONFIELD)
end
function s.negop(e,tp,eg,ep,ev,re,r,rp)
	local g=Duel.GetFieldGroup(tp,LOCATION_EXTRA,0)
	if #g==0 then return end
	Duel.ConfirmCards(1-tp,g)
	local rg=g:Filter(s.exfilter,nil,tp)
	if #rg<3 then return end
	Duel.Hint(HINT_SELECTMSG,1-tp,HINTMSG_REMOVE)
	local sg=rg:Select(1-tp,3,3,nil)
	if Duel.Remove(sg,POS_FACEDOWN,REASON_EFFECT)~=3 then return end
	if not Duel.IsExistingMatchingCard(s.negfilter,tp,0,LOCATION_ONFIELD,1,nil) then return end
	Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_FACEUP)
	local tc=Duel.SelectMatchingCard(tp,s.negfilter,tp,0,LOCATION_ONFIELD,1,1,nil):GetFirst()
	if not tc or not tc:IsFaceup() then return end
	local c=e:GetHandler()
	local e1=Effect.CreateEffect(c)
	e1:SetType(EFFECT_TYPE_SINGLE)
	e1:SetCode(EFFECT_DISABLE)
	e1:SetReset(RESET_EVENT+RESETS_STANDARD+RESET_PHASE+PHASE_END)
	tc:RegisterEffect(e1)
	if tc:IsType(TYPE_MONSTER) then
		local e2=e1:Clone()
		e2:SetCode(EFFECT_DISABLE_EFFECT)
		if RESET_TURN_SET then
			e2:SetValue(RESET_TURN_SET)
		end
		tc:RegisterEffect(e2)
		if EFFECT_DISABLE_TRAPMONSTER and tc:IsType(TYPE_TRAPMONSTER) then
			local e3=e1:Clone()
			e3:SetCode(EFFECT_DISABLE_TRAPMONSTER)
			tc:RegisterEffect(e3)
		end
	end
end

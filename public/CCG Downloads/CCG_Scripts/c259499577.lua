--A.I.P Ex Hive Mind
local s,id=GetID()
local SET_AIP=0xa979
local STRING_ID=id
local CALLER=259465391
local ZERO_MOTHER=259097228
function s.initial_effect(c)
	--Activate
	local e0=Effect.CreateEffect(c)
	e0:SetDescription(aux.Stringid(STRING_ID,1))
	e0:SetType(EFFECT_TYPE_ACTIVATE)
	e0:SetCode(EVENT_FREE_CHAIN)
	c:RegisterEffect(e0)
	--Shuffle 1 monster from either GY, then draw or Xyz Summon
	local e1=Effect.CreateEffect(c)
	e1:SetDescription(aux.Stringid(STRING_ID,0))
	e1:SetCategory(CATEGORY_TODECK+CATEGORY_DRAW+CATEGORY_SPECIAL_SUMMON)
	e1:SetType(EFFECT_TYPE_QUICK_O)
	e1:SetProperty(EFFECT_FLAG_CARD_TARGET)
	e1:SetCode(EVENT_FREE_CHAIN)
	e1:SetRange(LOCATION_SZONE)
	e1:SetCountLimit(1,id)
	e1:SetTarget(s.tg)
	e1:SetOperation(s.op)
	c:RegisterEffect(e1)
end
s.listed_series={SET_AIP}
function s.owner(c)
	if c.GetOwner then return c:GetOwner() end
	return c:GetControler()
end
function s.tgfilter(c,tp)
	if not (c:IsType(TYPE_MONSTER) and c:IsAbleToDeck()) then return false end
	if s.owner(c)==tp then
		return Duel.IsPlayerCanDraw(tp,1)
	end
	local mg=s.xyzmatgroup(tp)
	return Duel.IsExistingMatchingCard(s.xyzfilter,tp,LOCATION_EXTRA,0,1,nil,mg)
end
function s.tg(e,tp,eg,ep,ev,re,r,rp,chk,chkc)
	if chkc then return chkc:IsLocation(LOCATION_GRAVE) and aux.NecroValleyFilter(s.tgfilter)(chkc,tp) end
	if chk==0 then return Duel.IsExistingTarget(aux.NecroValleyFilter(s.tgfilter),tp,LOCATION_GRAVE,LOCATION_GRAVE,1,nil,tp) end
	Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_TODECK)
	local g=Duel.SelectTarget(tp,aux.NecroValleyFilter(s.tgfilter),tp,LOCATION_GRAVE,LOCATION_GRAVE,1,1,nil,tp)
	Duel.SetOperationInfo(0,CATEGORY_TODECK,g,1,0,0)
	local tc=g:GetFirst()
	if tc and s.owner(tc)==tp then
		Duel.SetOperationInfo(0,CATEGORY_DRAW,nil,0,tp,1)
	else
		Duel.SetOperationInfo(0,CATEGORY_SPECIAL_SUMMON,nil,1,tp,LOCATION_EXTRA)
	end
end
function s.xyzmatfilter(c)
	return c:IsFaceup() and c:IsType(TYPE_MONSTER)
end
function s.xyzmatgroup(tp)
	return Duel.GetMatchingGroup(s.xyzmatfilter,tp,LOCATION_MZONE,0,nil)
end
function s.xyzfilter(c,mg)
	return c:IsSetCard(SET_AIP) and c:IsType(TYPE_XYZ)
		and c:IsCode(CALLER,ZERO_MOTHER) and c:IsXyzSummonable(mg)
end
function s.op(e,tp,eg,ep,ev,re,r,rp)
	local tc=Duel.GetFirstTarget()
	if not (tc and tc:IsRelateToEffect(e) and aux.NecroValleyFilter()(tc) and tc:IsAbleToDeck()) then return end
	local owner=s.owner(tc)
	if Duel.SendtoDeck(tc,nil,SEQ_DECKSHUFFLE,REASON_EFFECT)==0 then return end
	if owner==tp then
		if Duel.IsPlayerCanDraw(tp,1) then
			Duel.Draw(tp,1,REASON_EFFECT)
		end
	else
		local mg=s.xyzmatgroup(tp)
		if not Duel.IsExistingMatchingCard(s.xyzfilter,tp,LOCATION_EXTRA,0,1,nil,mg) then return end
		Duel.BreakEffect()
		Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_SPSUMMON)
		local xc=Duel.SelectMatchingCard(tp,s.xyzfilter,tp,LOCATION_EXTRA,0,1,1,nil,mg):GetFirst()
		if xc then
			Duel.XyzSummon(tp,xc,mg)
		end
	end
end

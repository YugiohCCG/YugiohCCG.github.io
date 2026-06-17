--NiuHao - Zao
local s,id=GetID()
local SET_NIUHAO=0xb69
local CARD_BOJIN=236542835
local CARD_CHUNYIN=229499914
local CARD_HUANGJIN=246421842
local SACRED_TREASURE_CODES={
	[CARD_BOJIN]=true,
	[CARD_CHUNYIN]=true,
	[CARD_HUANGJIN]=true,
}
function s.initial_effect(c)
	--Xyz Summon
	aux.AddXyzProcedure(c,aux.FilterBoolFunction(Card.IsRace,RACE_WINDBEAST),1,2,nil,nil,99)
	c:EnableReviveLimit()
	--Materials detached from this card are banished instead
	local e1=Effect.CreateEffect(c)
	e1:SetType(EFFECT_TYPE_FIELD)
	e1:SetCode(EFFECT_TO_GRAVE_REDIRECT)
	e1:SetProperty(EFFECT_FLAG_IGNORE_IMMUNE)
	e1:SetRange(LOCATION_MZONE)
	e1:SetTargetRange(LOCATION_OVERLAY,LOCATION_OVERLAY)
	e1:SetTarget(s.rmtg)
	e1:SetValue(LOCATION_REMOVED)
	c:RegisterEffect(e1)
	--Cannot be destroyed by card effects while it has material
	local e2=Effect.CreateEffect(c)
	e2:SetType(EFFECT_TYPE_SINGLE)
	e2:SetProperty(EFFECT_FLAG_SINGLE_RANGE)
	e2:SetCode(EFFECT_INDESTRUCTABLE_EFFECT)
	e2:SetRange(LOCATION_MZONE)
	e2:SetCondition(s.matcon)
	e2:SetValue(1)
	c:RegisterEffect(e2)
	--Detach 1 material; banish 2 "Sacred Treasure" Spells and apply their activation effects
	local e3=Effect.CreateEffect(c)
	e3:SetDescription(aux.Stringid(id,0))
	e3:SetCategory(CATEGORY_REMOVE+CATEGORY_DESTROY+CATEGORY_SPECIAL_SUMMON+CATEGORY_POSITION+CATEGORY_DRAW)
	e3:SetType(EFFECT_TYPE_QUICK_O)
	e3:SetCode(EVENT_FREE_CHAIN)
	e3:SetRange(LOCATION_MZONE)
	e3:SetHintTiming(0,TIMINGS_CHECK_MONSTER+TIMING_END_PHASE)
	e3:SetCountLimit(1,id)
	e3:SetCost(s.cost)
	e3:SetTarget(s.target)
	e3:SetOperation(s.operation)
	c:RegisterEffect(e3)
end
function s.rmtg(e,c)
	return c:GetOverlayTarget()==e:GetHandler()
end
function s.matcon(e)
	return e:GetHandler():GetOverlayCount()>0
end
function s.cost(e,tp,eg,ep,ev,re,r,rp,chk)
	local c=e:GetHandler()
	if chk==0 then return c:CheckRemoveOverlayCard(tp,1,REASON_COST) end
	c:RemoveOverlayCard(tp,1,1,REASON_COST)
end
function s.rmfilter(c)
	return SACRED_TREASURE_CODES[c:GetCode()] and c:IsType(TYPE_SPELL) and c:IsAbleToRemove()
		and (not c:IsLocation(LOCATION_GRAVE) or aux.NecroValleyFilter()(c))
end
function s.target(e,tp,eg,ep,ev,re,r,rp,chk)
	if chk==0 then return Duel.IsExistingMatchingCard(s.rmfilter,tp,LOCATION_HAND+LOCATION_GRAVE,0,2,nil) end
	Duel.SetOperationInfo(0,CATEGORY_REMOVE,nil,2,tp,LOCATION_HAND+LOCATION_GRAVE)
end
function s.operation(e,tp,eg,ep,ev,re,r,rp)
	if not Duel.IsExistingMatchingCard(s.rmfilter,tp,LOCATION_HAND+LOCATION_GRAVE,0,2,nil) then return end
	Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_REMOVE)
	local rg=Duel.SelectMatchingCard(tp,s.rmfilter,tp,LOCATION_HAND+LOCATION_GRAVE,0,2,2,nil)
	if #rg<2 or Duel.Remove(rg,POS_FACEUP,REASON_EFFECT)<2 then return end
	local og=Duel.GetOperatedGroup():Filter(Card.IsLocation,nil,LOCATION_REMOVED)
	while #og>0 do
		Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_FACEUP)
		local tc=og:Select(tp,1,1,nil):GetFirst()
		og:RemoveCard(tc)
		if tc then
			s.applyeffect(e,tp,tc)
		end
	end
end
function s.niufilter(c)
	return c:IsFaceup() and c:IsSetCard(SET_NIUHAO) and c:IsType(TYPE_MONSTER)
end
function s.canapply(tp)
	return Duel.IsExistingMatchingCard(s.niufilter,tp,LOCATION_MZONE,0,1,nil)
end
function s.applyeffect(e,tp,tc)
	if not (tc:IsFaceup() and SACRED_TREASURE_CODES[tc:GetCode()] and s.canapply(tp)) then return end
	local code=tc:GetCode()
	if code==CARD_BOJIN then
		s.applybojin(e,tp)
	elseif code==CARD_CHUNYIN then
		s.applychunyin(e,tp)
	elseif code==CARD_HUANGJIN then
		s.applyhuangjin(e,tp)
	end
end
function s.bojindesfilter(c,e)
	return c:IsType(TYPE_MONSTER) and c:IsDestructable(e)
end
function s.bojinspfilter(c,e,tp)
	return c:IsSetCard(SET_NIUHAO) and c:IsType(TYPE_MONSTER)
		and c:IsCanBeSpecialSummoned(e,0,tp,false,false)
end
function s.applybojin(e,tp)
	local b1=Duel.IsExistingMatchingCard(s.bojindesfilter,tp,LOCATION_MZONE,LOCATION_MZONE,1,nil,e)
	local b2=Duel.GetLocationCount(tp,LOCATION_MZONE)>0
		and Duel.IsExistingMatchingCard(s.bojinspfilter,tp,LOCATION_HAND,0,1,nil,e,tp)
	if not (b1 or b2) then return end
	local op=0
	if b1 and b2 then
		op=Duel.SelectOption(tp,aux.Stringid(CARD_BOJIN,1),aux.Stringid(CARD_BOJIN,2))
	elseif b2 then
		op=1
	end
	if op==0 then
		Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_DESTROY)
		local tc=Duel.SelectMatchingCard(tp,s.bojindesfilter,tp,LOCATION_MZONE,LOCATION_MZONE,1,1,nil,e):GetFirst()
		if tc then Duel.Destroy(tc,REASON_EFFECT) end
	else
		Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_SPSUMMON)
		local tc=Duel.SelectMatchingCard(tp,s.bojinspfilter,tp,LOCATION_HAND,0,1,1,nil,e,tp):GetFirst()
		if tc then Duel.SpecialSummon(tc,0,tp,tp,false,false,POS_FACEUP) end
	end
end
function s.posfilter(c)
	return c:IsFaceup() and c:IsCanTurnSet()
		and not Duel.IsPlayerAffectedByEffect(c:GetControler(),EFFECT_DIVINE_LIGHT)
end
function s.chunrmfilter(c)
	return c:IsSetCard(SET_NIUHAO) and c:IsType(TYPE_MONSTER) and c:IsAbleToRemove()
end
function s.applychunyin(e,tp)
	local b1=Duel.IsExistingMatchingCard(s.posfilter,tp,LOCATION_MZONE,LOCATION_MZONE,1,nil)
	local g=Duel.GetMatchingGroup(s.chunrmfilter,tp,LOCATION_DECK,0,nil)
	local b2=g:GetClassCount(Card.GetCode)>=2
	if not (b1 or b2) then return end
	local op=0
	if b1 and b2 then
		op=Duel.SelectOption(tp,aux.Stringid(CARD_CHUNYIN,1),aux.Stringid(CARD_CHUNYIN,2))
	elseif b2 then
		op=1
	end
	if op==0 then
		Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_POSCHANGE)
		local tc=Duel.SelectMatchingCard(tp,s.posfilter,tp,LOCATION_MZONE,LOCATION_MZONE,1,1,nil):GetFirst()
		if tc then Duel.ChangePosition(tc,POS_FACEDOWN_DEFENSE) end
	else
		Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_REMOVE)
		aux.GCheckAdditional=aux.dncheck
		local sg=g:SelectSubGroup(tp,aux.TRUE,false,2,2)
		aux.GCheckAdditional=nil
		if sg and #sg==2 then Duel.Remove(sg,POS_FACEUP,REASON_EFFECT) end
	end
end
function s.huangdesfilter(c,e)
	return c:IsType(TYPE_SPELL+TYPE_TRAP) and c:IsDestructable(e)
end
function s.gyrmfilter(c)
	return c:IsAbleToRemove()
end
function s.applyhuangjin(e,tp)
	local b1=Duel.IsExistingMatchingCard(s.huangdesfilter,tp,LOCATION_ONFIELD,LOCATION_ONFIELD,1,nil,e)
	local b2=Duel.IsExistingMatchingCard(aux.NecroValleyFilter(s.gyrmfilter),tp,LOCATION_GRAVE,LOCATION_GRAVE,1,nil)
	if not (b1 or b2) then return end
	local op=0
	if b1 and b2 then
		op=Duel.SelectOption(tp,aux.Stringid(CARD_HUANGJIN,1),aux.Stringid(CARD_HUANGJIN,2))
	elseif b2 then
		op=1
	end
	if op==0 then
		Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_DESTROY)
		local tc=Duel.SelectMatchingCard(tp,s.huangdesfilter,tp,LOCATION_ONFIELD,LOCATION_ONFIELD,1,1,nil,e):GetFirst()
		if tc then Duel.Destroy(tc,REASON_EFFECT) end
	else
		Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_REMOVE)
		local tc=Duel.SelectMatchingCard(tp,aux.NecroValleyFilter(s.gyrmfilter),tp,LOCATION_GRAVE,LOCATION_GRAVE,1,1,nil):GetFirst()
		if tc then Duel.Remove(tc,POS_FACEUP,REASON_EFFECT) end
	end
end

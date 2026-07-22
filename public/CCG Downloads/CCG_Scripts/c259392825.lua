local s,id=GetID()
local SET_NEMLERIA_OMEGA=0x191
local SET_NEMLERIA_PI=0x192
local CARD_DREAMING_NEMLERIA=CARD_DREAMING_NEMLERIA or 70155677
local STRING_ID=133392825
local TIMINGS_CHECK_MONSTER=TIMINGS_CHECK_MONSTER or 0
local RESET_CHAIN_COMPAT=RESET_CHAIN or (RESET_PHASE+PHASE_END)
function s.initial_effect(c)
	--special summon
	local e1=Effect.CreateEffect(c)
	e1:SetDescription(aux.Stringid(STRING_ID,0))
	e1:SetCategory(CATEGORY_SPECIAL_SUMMON)
	e1:SetType(EFFECT_TYPE_QUICK_O)
	e1:SetCode(EVENT_FREE_CHAIN)
	e1:SetRange(LOCATION_HAND)
	e1:SetHintTiming(0,TIMINGS_CHECK_MONSTER+TIMING_END_PHASE)
	e1:SetCountLimit(1,id)
	e1:SetCost(s.spcost)
	e1:SetTarget(s.sptg)
	e1:SetOperation(s.spop)
	c:RegisterEffect(e1)
	--protect
	local e2=Effect.CreateEffect(c)
	e2:SetDescription(aux.Stringid(STRING_ID,1))
	e2:SetType(EFFECT_TYPE_QUICK_O)
	e2:SetCode(EVENT_FREE_CHAIN)
	e2:SetProperty(EFFECT_FLAG_CARD_TARGET)
	e2:SetRange(LOCATION_MZONE)
	e2:SetHintTiming(0,TIMINGS_CHECK_MONSTER+TIMING_END_PHASE)
	e2:SetCountLimit(3)
	e2:SetCondition(s.immcon)
	e2:SetCost(s.immcost)
	e2:SetTarget(s.immtg)
	e2:SetOperation(s.immop)
	c:RegisterEffect(e2)
end
function s.costfilter(c)
	return (c:IsSetCard(SET_NEMLERIA_OMEGA) or c:IsSetCard(SET_NEMLERIA_PI)) and c:IsDiscardable()
end
function s.spcost(e,tp,eg,ep,ev,re,r,rp,chk)
	local c=e:GetHandler()
	if chk==0 then return Duel.IsExistingMatchingCard(s.costfilter,tp,LOCATION_HAND,0,1,c) end
	Duel.DiscardHand(tp,s.costfilter,1,1,REASON_COST+REASON_DISCARD,c)
end
function s.tefilter(c)
	return c:IsCode(CARD_DREAMING_NEMLERIA) and not c:IsForbidden()
end
function s.bouncefilter(c,tp)
	if c:IsType(TYPE_TOKEN) then return false end
	local otype=c:GetOriginalType()
	return c:IsControler(1-tp) and c:IsOnField()
		and (otype&(TYPE_FUSION+TYPE_SYNCHRO+TYPE_XYZ+TYPE_LINK))==0
		and c:IsAbleToHand()
end
function s.sptg(e,tp,eg,ep,ev,re,r,rp,chk)
	local c=e:GetHandler()
	if chk==0 then
		return Duel.GetLocationCount(tp,LOCATION_MZONE)>0
			and Duel.IsExistingMatchingCard(s.tefilter,tp,LOCATION_DECK,0,1,nil)
			and c:IsCanBeSpecialSummoned(e,0,tp,false,false)
	end
	Duel.SetOperationInfo(0,CATEGORY_TOEXTRA,nil,1,tp,LOCATION_DECK)
	Duel.SetOperationInfo(0,CATEGORY_SPECIAL_SUMMON,c,1,0,0)
end
function s.spop(e,tp,eg,ep,ev,re,r,rp)
	local c=e:GetHandler()
	Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_TODECK)
	local g=Duel.SelectMatchingCard(tp,s.tefilter,tp,LOCATION_DECK,0,1,1,nil)
	local tc=g:GetFirst()
	if not tc then return end
	Duel.SendtoExtraP(g,tp,REASON_EFFECT)
	if not tc:IsLocation(LOCATION_EXTRA) then return end
	if Duel.GetLocationCount(tp,LOCATION_MZONE)<=0 or not c:IsRelateToEffect(e) then return end
	if Duel.SpecialSummon(c,0,tp,tp,false,false,POS_FACEUP)==0 then return end
	if Duel.IsExistingMatchingCard(s.bouncefilter,tp,0,LOCATION_ONFIELD,1,nil,tp)
		and Duel.SelectYesNo(tp,aux.Stringid(STRING_ID,2)) then
		Duel.BreakEffect()
		Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_RTOHAND)
		local rg=Duel.SelectMatchingCard(tp,s.bouncefilter,tp,0,LOCATION_ONFIELD,1,1,nil,tp)
		if #rg>0 then
			Duel.SendtoHand(rg,nil,REASON_EFFECT)
		end
	end
end
function s.dreamfilter(c)
	return c:IsFaceup() and c:IsCode(CARD_DREAMING_NEMLERIA)
end
function s.immcon(e,tp,eg,ep,ev,re,r,rp)
	return Duel.IsExistingMatchingCard(s.dreamfilter,tp,LOCATION_EXTRA,0,1,nil)
end
function s.exfilter(c)
	return c:IsFacedown() and c:IsAbleToRemoveAsCost(POS_FACEDOWN) and not c:IsCode(CARD_DREAMING_NEMLERIA)
end
function s.immcost(e,tp,eg,ep,ev,re,r,rp,chk)
	local g=Duel.GetMatchingGroup(s.exfilter,tp,LOCATION_EXTRA,0,nil)
	if chk==0 then return #g>=2 end
	Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_REMOVE)
	local rg=g:Select(tp,2,2,nil)
	Duel.Remove(rg,POS_FACEDOWN,REASON_COST)
end
function s.tgfilter(c,e,tp)
	return c:IsControler(tp) and c:IsOnField() and c~=e:GetHandler()
		and (c:IsSetCard(SET_NEMLERIA_OMEGA) or c:IsSetCard(SET_NEMLERIA_PI)) and c:IsCanBeEffectTarget(e)
end
function s.immtg(e,tp,eg,ep,ev,re,r,rp,chk,chkc)
	if chkc then return s.tgfilter(chkc,e,tp) end
	if chk==0 then return Duel.IsExistingTarget(s.tgfilter,tp,LOCATION_ONFIELD,0,1,nil,e,tp) end
	Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_TARGET)
	Duel.SelectTarget(tp,s.tgfilter,tp,LOCATION_ONFIELD,0,1,1,nil,e,tp)
end
function s.immval(e,re)
	for i=1,e:GetLabel() do
		local te=Duel.GetChainInfo(i,CHAININFO_TRIGGERING_EFFECT)
		if te==re then return true end
	end
	return false
end
function s.immop(e,tp,eg,ep,ev,re,r,rp)
	local tc=Duel.GetFirstTarget()
	if not (tc and tc:IsRelateToEffect(e) and s.tgfilter(tc,e,tp)) then return end
	local e1=Effect.CreateEffect(e:GetHandler())
	e1:SetType(EFFECT_TYPE_SINGLE)
	e1:SetCode(EFFECT_IMMUNE_EFFECT)
	e1:SetValue(s.immval)
	e1:SetLabel(math.max(Duel.GetCurrentChain()-1,0))
	e1:SetReset(RESET_EVENT+RESETS_STANDARD+RESET_CHAIN_COMPAT)
	tc:RegisterEffect(e1)
end

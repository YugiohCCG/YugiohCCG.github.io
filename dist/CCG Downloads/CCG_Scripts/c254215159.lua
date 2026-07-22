local s,id=GetID()
local STRING_ID=132215159
local SET_BAU=0xba8
local BAUY_WORLD=226950506
local BAU=221511784
function s.initial_effect(c)
	local e1=Effect.CreateEffect(c)
	e1:SetDescription(aux.Stringid(STRING_ID,0))
	e1:SetCategory(CATEGORY_SPECIAL_SUMMON+CATEGORY_DISABLE+CATEGORY_REMOVE)
	e1:SetType(EFFECT_TYPE_ACTIVATE)
	e1:SetCode(EVENT_FREE_CHAIN)
	e1:SetCountLimit(1,id)
	e1:SetTarget(s.target)
	e1:SetOperation(s.activate)
	c:RegisterEffect(e1)
	local e2=Effect.CreateEffect(c)
	e2:SetDescription(aux.Stringid(STRING_ID,1))
	e2:SetCategory(CATEGORY_LEAVE_GRAVE)
	e2:SetType(EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_O)
	e2:SetProperty(EFFECT_FLAG_DELAY)
	e2:SetCode(EVENT_REMOVE)
	e2:SetCountLimit(1,id+100)
	e2:SetTarget(s.settg)
	e2:SetOperation(s.setop)
	c:RegisterEffect(e2)
end
function s.fldfilter(c,tp)
	return c:IsCode(BAUY_WORLD) and c:IsFaceup() and c:GetActivateEffect()
		and c:GetActivateEffect():IsActivatable(tp,true,true)
end
function s.spfilter(c,e,tp)
	return c:IsSetCard(SET_BAU) and c:IsType(TYPE_TUNER) and (c:IsFaceup() or c:IsLocation(LOCATION_DECK))
		and c:IsCanBeSpecialSummoned(e,0,tp,false,false)
end
function s.worldfilter(c)
	return c:IsFaceup() and c:IsCode(BAUY_WORLD)
end
function s.baufilter(c)
	return c:IsFaceup() and c:IsCode(BAU)
end
function s.target(e,tp,eg,ep,ev,re,r,rp,chk)
	local b1=Duel.IsExistingMatchingCard(s.fldfilter,tp,LOCATION_DECK+LOCATION_REMOVED,0,1,nil,tp)
	local b2=Duel.IsExistingMatchingCard(s.worldfilter,tp,LOCATION_FZONE,0,1,nil)
		and Duel.GetLocationCount(tp,LOCATION_MZONE)>0
		and Duel.IsExistingMatchingCard(s.spfilter,tp,LOCATION_DECK+LOCATION_REMOVED,0,1,nil,e,tp)
	if chk==0 then return b1 or b2 end
	local op
	if b1 and b2 then op=Duel.SelectOption(tp,aux.Stringid(STRING_ID,2),aux.Stringid(STRING_ID,3)) elseif b1 then op=0 else op=1 end
	e:SetLabel(op)
	if op==1 then Duel.SetOperationInfo(0,CATEGORY_SPECIAL_SUMMON,nil,1,tp,LOCATION_DECK+LOCATION_REMOVED) end
end
function s.disablefilter(c)
	return c:IsFaceup() and aux.NegateAnyFilter(c)
end
function s.activatefield(e,tp,eg,ep,ev,re,r,rp)
	Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_TOFIELD)
	local tc=Duel.SelectMatchingCard(tp,s.fldfilter,tp,LOCATION_DECK+LOCATION_REMOVED,0,1,1,nil,tp):GetFirst()
	if not tc then return false end
	local fc=Duel.GetFieldCard(tp,LOCATION_FZONE,0)
	if fc then Duel.SendtoGrave(fc,REASON_RULE); Duel.BreakEffect() end
	if not Duel.MoveToField(tc,tp,tp,LOCATION_FZONE,POS_FACEUP,true) then return false end
	local te=tc:GetActivateEffect()
	te:UseCountLimit(tp,1,true)
	local cost=te:GetCost()
	if cost then cost(te,tp,eg,ep,ev,re,r,rp,1) end
	Duel.RaiseEvent(tc,4179255,te,0,tp,tp,Duel.GetCurrentChain())
	return true
end
function s.activate(e,tp,eg,ep,ev,re,r,rp)
	local ok=false
	if e:GetLabel()==0 then
		ok=s.activatefield(e,tp,eg,ep,ev,re,r,rp)
	elseif Duel.GetLocationCount(tp,LOCATION_MZONE)>0 then
		Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_SPSUMMON)
		local tc=Duel.SelectMatchingCard(tp,s.spfilter,tp,LOCATION_DECK+LOCATION_REMOVED,0,1,1,nil,e,tp):GetFirst()
		ok=tc and Duel.SpecialSummon(tc,0,tp,tp,false,false,POS_FACEUP)>0
	end
	if not ok or not Duel.IsExistingMatchingCard(s.baufilter,tp,LOCATION_ONFIELD,0,1,nil)
		or not Duel.IsExistingMatchingCard(s.disablefilter,tp,LOCATION_ONFIELD,LOCATION_ONFIELD,1,nil)
		or not Duel.SelectYesNo(tp,aux.Stringid(STRING_ID,4)) then return end
	Duel.BreakEffect()
	Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_DISABLE)
	local tc=Duel.SelectMatchingCard(tp,s.disablefilter,tp,LOCATION_ONFIELD,LOCATION_ONFIELD,1,1,nil):GetFirst()
	if not tc then return end
	Duel.NegateRelatedChain(tc,RESET_TURN_SET)
	local e1=Effect.CreateEffect(e:GetHandler())
	e1:SetType(EFFECT_TYPE_SINGLE)
	e1:SetCode(EFFECT_DISABLE)
	e1:SetReset(RESET_EVENT+RESETS_STANDARD)
	tc:RegisterEffect(e1)
	local e2=e1:Clone()
	e2:SetCode(EFFECT_DISABLE_EFFECT)
	e2:SetValue(RESET_TURN_SET)
	tc:RegisterEffect(e2)
	if tc:IsRelateToEffect(e) and tc:IsDisabled() then Duel.Remove(tc,POS_FACEUP,REASON_EFFECT) end
end
function s.settg(e,tp,eg,ep,ev,re,r,rp,chk)
	if chk==0 then return Duel.GetLocationCount(tp,LOCATION_SZONE)>0 and e:GetHandler():IsSSetable() end
end
function s.setop(e,tp,eg,ep,ev,re,r,rp)
	local c=e:GetHandler()
	if c:IsRelateToEffect(e) and Duel.GetLocationCount(tp,LOCATION_SZONE)>0 and Duel.SSet(tp,c)>0 then
		local e1=Effect.CreateEffect(c)
		e1:SetType(EFFECT_TYPE_SINGLE)
		e1:SetCode(EFFECT_LEAVE_FIELD_REDIRECT)
		e1:SetProperty(EFFECT_FLAG_CANNOT_DISABLE)
		e1:SetValue(LOCATION_DECKSHF)
		e1:SetReset(RESET_EVENT+RESETS_REDIRECT)
		c:RegisterEffect(e1,true)
	end
end

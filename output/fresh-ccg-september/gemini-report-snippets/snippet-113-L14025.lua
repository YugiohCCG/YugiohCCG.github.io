--Scarstech Deployment
local s,id=GetID()
local SET_SCARSTECH=0x52f8
function s.initial_effect(c)
	--Activate
	local e1=Effect.CreateEffect(c)
	e1:SetDescription(aux.Stringid(id,0))
	e1:SetCategory(CATEGORY_DISABLE)
	e1:SetType(EFFECT_TYPE_ACTIVATE)
	e1:SetCode(EVENT_FREE_CHAIN)
	e1:SetHintTiming(0,TIMINGS_CHECK_MONSTER+TIMING_END_PHASE)
	e1:SetCountLimit(1,id+EFFECT_COUNT_CODE_OATH)
	e1:SetTarget(s.target)
	e1:SetOperation(s.activate)
	c:RegisterEffect(e1)
	--Act in hand
	local e2=Effect.CreateEffect(c)
	e2:SetType(EFFECT_TYPE_SINGLE)
	e2:SetCode(EFFECT_TRAP_ACT_IN_HAND)
	e2:SetCondition(s.handcon)
	c:RegisterEffect(e2)
	if not s.global_check then
		s.global_check=true
		local ge1=Effect.CreateEffect(c)
		ge1:SetType(EFFECT_TYPE_FIELD+EFFECT_TYPE_CONTINUOUS)
		ge1:SetCode(EVENT_CHAINING)
		ge1:SetOperation(s.checkop1)
		Duel.RegisterEffect(ge1,0)
	end
end
s.listed_series={SET_SCARSTECH}
function s.linkfilter(c)
	return c:IsFaceup() and c:IsSetCard(SET_SCARSTECH) and c:IsType(TYPE_LINK)
end
function s.checkop1(e,tp,eg,ep,ev,re,r,rp)
	if ev>=3 then
		for p=0,1 do
			if Duel.IsTurnPlayer(1-p) and Duel.IsExistingMatchingCard(s.linkfilter,p,LOCATION_MZONE,0,1,nil) then
				Duel.RegisterFlagEffect(p,id,RESET_PHASE+PHASE_END,0,1)
			end
		end
	end
end
function s.handcon(e)
	local tp=e:GetHandlerPlayer()
	return Duel.IsTurnPlayer(1-tp) and Duel.GetFlagEffect(tp,id)>0
end
function s.target(e,tp,eg,ep,ev,re,r,rp,chk)
	if chk==0 then return Duel.IsExistingMatchingCard(aux.NegateAnyFilter,tp,0,LOCATION_ONFIELD,1,nil) end
	local ct=Duel.GetCurrentChain()
	e:SetLabel(ct)
	local g=Duel.GetMatchingGroup(aux.NegateAnyFilter,tp,0,LOCATION_ONFIELD,nil)
	Duel.SetOperationInfo(0,CATEGORY_DISABLE,g,1,0,0)
end
function s.activate(e,tp,eg,ep,ev,re,r,rp)
	local ct=e:GetLabel()
	if ct<=0 then return end
	local g=Duel.GetMatchingGroup(aux.NegateAnyFilter,tp,0,LOCATION_ONFIELD,nil)
	if #g==0 then return end
	Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_DISABLE)
	local sg=g:Select(tp,1,ct,nil)
	Duel.HintSelection(sg)
	local c=e:GetHandler()
	for tc in aux.Next(sg) do
		if tc:IsCanBeDisabledByEffect(e,false) then
			Duel.NegateRelatedChain(tc,RESET_TURN_SET)
			local e1=Effect.CreateEffect(c)
			e1:SetType(EFFECT_TYPE_SINGLE)
			e1:SetProperty(EFFECT_FLAG_CANNOT_DISABLE)
			e1:SetCode(EFFECT_DISABLE)
			e1:SetReset(RESET_EVENT+RESETS_STANDARD)
			tc:RegisterEffect(e1)
			local e2=e1:Clone()
			e2:SetCode(EFFECT_DISABLE_EFFECT)
			e2:SetValue(RESET_TURN_SET)
			tc:RegisterEffect(e2)
			if tc:IsType(TYPE_TRAPMONSTER) then
				local e3=e1:Clone()
				e3:SetCode(EFFECT_DISABLE_TRAPMONSTER)
				tc:RegisterEffect(e3)
			end
		end
	end
end

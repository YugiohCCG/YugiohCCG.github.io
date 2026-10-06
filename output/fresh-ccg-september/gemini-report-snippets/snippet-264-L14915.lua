--Scarstech Invasion
local s,id=GetID()
local SET_SCARSTECH=0x52f8
function s.initial_effect(c)
	c:SetUniqueOnField(1,0,id)
	--Activate
	local e1=Effect.CreateEffect(c)
	e1:SetType(EFFECT_TYPE_ACTIVATE)
	e1:SetCode(EVENT_FREE_CHAIN)
	e1:SetHintTiming(0,TIMINGS_CHECK_MONSTER+TIMING_MAIN_END)
	c:RegisterEffect(e1)
	--Main effect
	local e2=Effect.CreateEffect(c)
	e2:SetDescription(aux.Stringid(id,0))
	e2:SetCategory(CATEGORY_SPECIAL_SUMMON)
	e2:SetType(EFFECT_TYPE_QUICK_O)
	e2:SetCode(EVENT_FREE_CHAIN)
	e2:SetRange(LOCATION_SZONE)
	e2:SetHintTiming(0,TIMINGS_CHECK_MONSTER+TIMING_MAIN_END)
	e2:SetCountLimit(1)
	e2:SetCondition(s.maincon)
	e2:SetCost(s.cost)
	e2:SetTarget(s.target)
	e2:SetOperation(s.activate)
	c:RegisterEffect(e2)
	--Act in hand
	local e3=Effect.CreateEffect(c)
	e3:SetType(EFFECT_TYPE_SINGLE)
	e3:SetCode(EFFECT_TRAP_ACT_IN_HAND)
	e3:SetCondition(s.actcon)
	c:RegisterEffect(e3)
	--Act turn Set
	local e4=Effect.CreateEffect(c)
	e4:SetType(EFFECT_TYPE_SINGLE)
	e4:SetCode(EFFECT_TRAP_ACT_IN_SET_TURN)
	e4:SetProperty(EFFECT_FLAG_SET_AVAILABLE)
	e4:SetCondition(s.actcon)
	c:RegisterEffect(e4)
	if not s.global_check then
		s.global_check=true
		local ge=Effect.CreateEffect(c)
		ge:SetType(EFFECT_TYPE_FIELD+EFFECT_TYPE_CONTINUOUS)
		ge:SetCode(EVENT_CHAINING)
		ge:SetOperation(s.chainop)
		Duel.RegisterEffect(ge,0)
	end
end
s.listed_series={SET_SCARSTECH}
function s.chainop(e,tp,eg,ep,ev,re,r,rp)
	if ev>=3 then
		Duel.RegisterFlagEffect(0,id,RESET_PHASE+PHASE_END,0,1)
		Duel.RegisterFlagEffect(1,id,RESET_PHASE+PHASE_END,0,1)
	end
end
function s.actcon(e)
	return Duel.GetFlagEffect(e:GetHandlerPlayer(),id)>0
end
function s.linkfilter(c)
	return c:IsFaceup() and c:IsSetCard(SET_SCARSTECH) and c:IsType(TYPE_LINK)
end
function s.maincon(e,tp)
	return Duel.IsMainPhase() and Duel.IsExistingMatchingCard(s.linkfilter,tp,LOCATION_MZONE,0,1,nil)
end
function s.spfilter(c,e,tp)
	return c:IsSetCard(SET_SCARSTECH) and c:IsType(TYPE_MONSTER) and c:IsCanBeSpecialSummoned(e,0,tp,false,false)
end
function s.sumcheck(g,e,tp,lv)
	return g:GetClassCount(Card.GetCode)==#g and g:GetSum(Card.GetLevel)==lv
end
function s.relfilter(c,e,tp)
	if not (c:IsFaceup() and c:IsSetCard(SET_SCARSTECH) and c:IsType(TYPE_MONSTER)
		and not c:IsType(TYPE_LINK) and c:IsHasLevel() and c:IsReleasable()) then return false end
	local g=Duel.GetMatchingGroup(s.spfilter,tp,LOCATION_DECK,0,nil,e,tp)
	local ft=Duel.GetLocationCount(tp,LOCATION_MZONE)
	if c:IsLocation(LOCATION_MZONE) then ft=ft+1 end
	return ft>0 and g:CheckSubGroup(s.sumcheck,1,ft,e,tp,c:GetLevel())
end
function s.cost(e,tp,eg,ep,ev,re,r,rp,chk)
	if chk==0 then return Duel.IsExistingMatchingCard(s.relfilter,tp,LOCATION_MZONE,0,1,nil,e,tp) end
	Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_RELEASE)
	local c=Duel.SelectMatchingCard(tp,s.relfilter,tp,LOCATION_MZONE,0,1,1,nil,e,tp):GetFirst()
	e:SetLabel(c:GetLevel())
	Duel.Release(c,REASON_COST)
end
function s.target(e,tp,eg,ep,ev,re,r,rp,chk)
	if chk==0 then return true end
	Duel.SetOperationInfo(0,CATEGORY_SPECIAL_SUMMON,nil,1,tp,LOCATION_DECK)
end
function s.splimit(e,c)
	return not c:IsSetCard(SET_SCARSTECH)
end
function s.activate(e,tp,eg,ep,ev,re,r,rp)
	local ft=Duel.GetLocationCount(tp,LOCATION_MZONE)
	local g=Duel.GetMatchingGroup(s.spfilter,tp,LOCATION_DECK,0,nil,e,tp)
	local lv=e:GetLabel()
	if ft>0 and #g>0 and g:CheckSubGroup(s.sumcheck,1,ft,e,tp,lv) then
		Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_SPSUMMON)
		local sg=g:SelectSubGroup(tp,s.sumcheck,false,1,ft,e,tp,lv)
		if sg and Duel.SpecialSummon(sg,0,tp,tp,false,false,POS_FACEUP)>0 then
			for tc in aux.Next(sg) do
				local e1=Effect.CreateEffect(e:GetHandler())
				e1:SetType(EFFECT_TYPE_SINGLE)
				e1:SetProperty(EFFECT_FLAG_CANNOT_DISABLE)
				e1:SetCode(EFFECT_LEAVE_FIELD_REDIRECT)
				e1:SetReset(RESET_EVENT+RESETS_REDIRECT)
				e1:SetValue(LOCATION_REMOVED)
				tc:RegisterEffect(e1,true)
			end
		end
	end
	local e2=Effect.CreateEffect(e:GetHandler())
	e2:SetDescription(aux.Stringid(id,1))
	e2:SetType(EFFECT_TYPE_FIELD)
	e2:SetProperty(EFFECT_FLAG_PLAYER_TARGET+EFFECT_FLAG_CLIENT_HINT)
	e2:SetCode(EFFECT_CANNOT_SPECIAL_SUMMON)
	e2:SetTargetRange(1,0)
	e2:SetTarget(s.splimit)
	e2:SetReset(RESET_PHASE+PHASE_END,2)
	Duel.RegisterEffect(e2,tp)
end

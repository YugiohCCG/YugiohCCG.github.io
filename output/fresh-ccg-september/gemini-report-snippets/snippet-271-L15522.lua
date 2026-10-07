--Nifal, the Scarstech War Machine
local s,id=GetID()
local SET_SCARSTECH=0x52f8
function s.initial_effect(c)
	--Link Summon
	aux.AddLinkProcedure(c,nil,2,4,s.lcheck)
	c:EnableReviveLimit()
	c:SetUniqueOnField(1,0,id)
	--Cannot be targeted for attacks, but does not prevent direct attacks
	local e1=Effect.CreateEffect(c)
	e1:SetType(EFFECT_TYPE_SINGLE)
	e1:SetProperty(EFFECT_FLAG_SINGLE_RANGE)
	e1:SetRange(LOCATION_MZONE)
	e1:SetCode(EFFECT_IGNORE_BATTLE_TARGET)
	e1:SetValue(1)
	c:RegisterEffect(e1)
	--Gains 300 ATK when a card or effect resolves
	local e2=Effect.CreateEffect(c)
	e2:SetType(EFFECT_TYPE_FIELD+EFFECT_TYPE_CONTINUOUS)
	e2:SetCode(EVENT_CHAIN_SOLVED)
	e2:SetRange(LOCATION_MZONE)
	e2:SetOperation(s.atkop)
	c:RegisterEffect(e2)
	--Once per Chain: lose 3000 ATK, destroy cards in chosen zone and adjacent zones
	local e3=Effect.CreateEffect(c)
	e3:SetDescription(aux.Stringid(id,0))
	e3:SetCategory(CATEGORY_ATKCHANGE+CATEGORY_DESTROY)
	e3:SetType(EFFECT_TYPE_QUICK_O)
	e3:SetCode(EVENT_FREE_CHAIN)
	e3:SetRange(LOCATION_MZONE)
	e3:SetHintTiming(0,TIMINGS_CHECK_MONSTER+TIMING_MAIN_END)
	e3:SetCountLimit(1,EFFECT_COUNT_CODE_CHAIN)
	e3:SetTarget(s.target)
	e3:SetOperation(s.activate)
	c:RegisterEffect(e3)
end
s.listed_series={SET_SCARSTECH}
function s.lcheck(g)
	return g:IsExists(Card.IsSetCard,1,nil,SET_SCARSTECH)
end
function s.atkop(e,tp,eg,ep,ev,re,r,rp)
	local c=e:GetHandler()
	if c:IsFaceup() and c:IsLocation(LOCATION_MZONE) then
		local e1=Effect.CreateEffect(c)
		e1:SetType(EFFECT_TYPE_SINGLE)
		e1:SetCode(EFFECT_UPDATE_ATTACK)
		e1:SetValue(300)
		e1:SetReset(RESET_EVENT+RESETS_STANDARD)
		c:RegisterEffect(e1)
	end
end
function s.target(e,tp,eg,ep,ev,re,r,rp,chk)
	local c=e:GetHandler()
	if chk==0 then return c:IsFaceup() and c:IsAttackAbove(3000)
		and Duel.IsExistingMatchingCard(nil,tp,0,LOCATION_ONFIELD,1,nil) end
	local dg=Duel.GetMatchingGroup(nil,tp,0,LOCATION_ONFIELD,nil)
	Duel.SetOperationInfo(0,CATEGORY_DESTROY,dg,1,0,0)
end
function s.activate(e,tp,eg,ep,ev,re,r,rp)
	local c=e:GetHandler()
	if not c:IsRelateToEffect(e) or not c:IsFaceup() or c:GetAttack()<3000 then return end
	local e1=Effect.CreateEffect(c)
	e1:SetType(EFFECT_TYPE_SINGLE)
	e1:SetCode(EFFECT_UPDATE_ATTACK)
	e1:SetValue(-3000)
	e1:SetReset(RESET_EVENT+RESETS_STANDARD)
	c:RegisterEffect(e1)
	if c:IsHasEffect(EFFECT_REVERSE_UPDATE) then return end
	Duel.BreakEffect()
	Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_TOZONE)
	local zone=Duel.SelectDisableField(tp,1,0,LOCATION_MZONE+LOCATION_SZONE,0)
	local opp_zone=zone>>16
	local is_szone=(opp_zone>=0x100)
	local raw_seq=is_szone and (opp_zone>>8) or opp_zone
	local seq=0
	for i=0,6 do
		if raw_seq==(1<<i) then
			seq=i
			break
		end
	end
	local g=Duel.GetMatchingGroup(s.adjfilter,tp,0,LOCATION_ONFIELD,nil,seq,is_szone)
	if #g>0 then
		Duel.Destroy(g,REASON_EFFECT)
	end
end
function s.adjfilter(c,seq,is_szone)
	local cseq=c:GetSequence()
	local cloc=c:GetLocation()
	if is_szone then
		if cloc==LOCATION_SZONE then
			return cseq<=4 and math.abs(cseq-seq)<=1
		elseif cloc==LOCATION_MZONE then
			return cseq==seq
		end
	else
		if seq<=4 then
			if cloc==LOCATION_MZONE then
				if cseq<=4 then
					return math.abs(cseq-seq)<=1
				elseif cseq>=5 then
					return (seq==1 and cseq==5) or (seq==3 and cseq==6)
				end
			elseif cloc==LOCATION_SZONE then
				return cseq==seq
			end
		elseif seq==5 then
			return (cloc==LOCATION_MZONE and (cseq==1 or cseq==5))
		elseif seq==6 then
			return (cloc==LOCATION_MZONE and (cseq==3 or cseq==6))
		end
	end
	return false
end

local s,id=GetID()
local STRING_ID=133472430
function s.initial_effect(c)
	--Synchro Summon
	local e1=Effect.CreateEffect(c)
	e1:SetCategory(CATEGORY_SPECIAL_SUMMON)
	e1:SetType(EFFECT_TYPE_ACTIVATE)
	e1:SetCode(EVENT_FREE_CHAIN)
	e1:SetHintTiming(0,TIMINGS_CHECK_MONSTER+TIMING_MAIN_END)
	e1:SetCountLimit(1,id)
	e1:SetTarget(s.synchrotg)
	e1:SetOperation(s.synchroop)
	c:RegisterEffect(e1)
	--Take control
	local e2=Effect.CreateEffect(c)
	e2:SetDescription(aux.Stringid(STRING_ID,0))
	e2:SetCategory(CATEGORY_CONTROL)
	e2:SetType(EFFECT_TYPE_QUICK_O)
	e2:SetCode(EVENT_FREE_CHAIN)
	e2:SetRange(LOCATION_GRAVE)
	e2:SetHintTiming(0,TIMINGS_CHECK_MONSTER+TIMING_MAIN_END)
	e2:SetCountLimit(1,{id,1})
	e2:SetCondition(s.ctcon)
	e2:SetCost(aux.bfgcost)
	e2:SetTarget(s.cttg)
	e2:SetOperation(s.ctop)
	c:RegisterEffect(e2)
end
s.listed_names={233499093}
s.listed_series={0x6f4}
function s.matfilter1(c)
	return c:IsFaceup() and c:IsSetCard(0x6f4) and c:IsType(TYPE_SYNCHRO)
end
function s.matfilter2(c)
	return c:IsFaceup() and c:IsRace(RACE_ZOMBIE) and c:IsType(TYPE_TUNER)
end
function s.synfilter(c,mg)
	return c:IsSetCard(0x6f4) and c:IsType(TYPE_SYNCHRO) and c:IsSynchroSummonable(nil,mg)
end
function s.chkfilter(c,tp,g2,sg)
	sg:AddCard(c)
	local res=g2:IsExists(s.chkfilter2,1,nil,tp,c,sg)
	sg:RemoveCard(c)
	return res
end
function s.chkfilter2(c,tp,c1,sg)
	sg:AddCard(c)
	local res=Duel.IsExistingMatchingCard(s.synfilter,tp,LOCATION_EXTRA,0,1,nil,sg)
	sg:RemoveCard(c)
	return res
end
function s.synchrotg(e,tp,eg,ep,ev,re,r,rp,chk)
	if chk==0 then
		local mg=Duel.GetMatchingGroup(Card.IsFaceup,tp,LOCATION_MZONE,0,nil)
		local g1=mg:Filter(s.matfilter1,nil)
		local g2=mg:Filter(s.matfilter2,nil)
		if #g1==0 or #g2==0 then return false end
		local sg=Group.CreateGroup()
		return g1:IsExists(s.chkfilter,1,nil,tp,g2,sg)
	end
	Duel.SetOperationInfo(0,CATEGORY_SPECIAL_SUMMON,nil,1,tp,LOCATION_EXTRA)
end
function s.synchroop(e,tp,eg,ep,ev,re,r,rp)
	local mg=Duel.GetMatchingGroup(Card.IsFaceup,tp,LOCATION_MZONE,0,nil)
	local g1=mg:Filter(s.matfilter1,nil)
	local g2=mg:Filter(s.matfilter2,nil)
	if #g1==0 or #g2==0 then return end
	
	local sg=Group.CreateGroup()
	Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_SMATERIAL)
	local c1=g1:FilterSelect(tp,s.chkfilter,1,1,nil,tp,g2,sg):GetFirst()
	if not c1 then return end
	sg:AddCard(c1)
	
	Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_SMATERIAL)
	local c2=g2:FilterSelect(tp,s.chkfilter2,1,1,nil,tp,c1,sg):GetFirst()
	if not c2 then return end
	sg:AddCard(c2)
	
	local exg=Duel.GetMatchingGroup(s.synfilter,tp,LOCATION_EXTRA,0,nil,sg)
	if #exg>0 then
		Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_SPSUMMON)
		local tg=exg:Select(tp,1,1,nil)
		Duel.SynchroSummon(tp,tg:GetFirst(),nil,sg)
	end
end
function s.ctcon(e,tp,eg,ep,ev,re,r,rp)
	return Duel.IsExistingMatchingCard(aux.AND(Card.IsFaceup,Card.IsCode),tp,LOCATION_MZONE,0,1,nil,233499093)
end
function s.cttg(e,tp,eg,ep,ev,re,r,rp,chk)
	if chk==0 then return Duel.IsExistingMatchingCard(Card.IsControlerCanBeChanged,tp,0,LOCATION_MZONE,1,nil) end
end
function s.ctop(e,tp,eg,ep,ev,re,r,rp)
	Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_CONTROL)
	local g=Duel.SelectMatchingCard(tp,Card.IsControlerCanBeChanged,tp,0,LOCATION_MZONE,1,1,nil)
	local tc=g:GetFirst()
	if tc and Duel.GetControl(tc,tp,PHASE_END,1) then
		local c=e:GetHandler()
		local e1=Effect.CreateEffect(c)
		e1:SetType(EFFECT_TYPE_SINGLE)
		e1:SetCode(EFFECT_DISABLE)
		e1:SetReset(RESET_EVENT+RESETS_STANDARD+RESET_PHASE+PHASE_END)
		tc:RegisterEffect(e1)
		local e2=Effect.CreateEffect(c)
		e2:SetType(EFFECT_TYPE_SINGLE)
		e2:SetCode(EFFECT_DISABLE_EFFECT)
		e2:SetReset(RESET_EVENT+RESETS_STANDARD+RESET_PHASE+PHASE_END)
		tc:RegisterEffect(e2)
		local e3=Effect.CreateEffect(c)
		e3:SetType(EFFECT_TYPE_SINGLE)
		e3:SetCode(EFFECT_SET_ATTACK_FINAL)
		e3:SetValue(0)
		e3:SetReset(RESET_EVENT+RESETS_STANDARD+RESET_PHASE+PHASE_END)
		tc:RegisterEffect(e3)
		local e4=e3:Clone()
		e4:SetCode(EFFECT_SET_DEFENSE_FINAL)
		tc:RegisterEffect(e4)
	end
end

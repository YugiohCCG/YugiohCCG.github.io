local s,id=GetID()
local SET_GLITCHLING=0x9894
local COUNTER_CORRUPTION=0x1994
local CARD_BITRON=36211150
local CARD_PROTRON=24154052
local CARD_DIGITRON=32295838
local CARD_CORRUPTION=259546637
local CARD_GLITCHLING_BITRON=259247807
local CARD_GLITCHLING_PROTRON=259156549
local CARD_GLITCHLING_DIGITRON=259494236
local CARD_GLITCHLING_HEXATRON=259253032
function s.initial_effect(c)
	c:EnableReviveLimit()
	aux.EnablePendulumAttribute(c)
	--Special Summon limit
	local e0=Effect.CreateEffect(c)
	e0:SetType(EFFECT_TYPE_SINGLE)
	e0:SetProperty(EFFECT_FLAG_CANNOT_DISABLE+EFFECT_FLAG_UNCOPYABLE)
	e0:SetCode(EFFECT_SPSUMMON_CONDITION)
	e0:SetValue(aux.ritlimit)
	c:RegisterEffect(e0)
	--Pendulum Effect: destroy this card, then Ritual Summon
	local e1=Effect.CreateEffect(c)
	e1:SetDescription(aux.Stringid(id,0))
	e1:SetCategory(CATEGORY_DESTROY+CATEGORY_SPECIAL_SUMMON)
	e1:SetType(EFFECT_TYPE_IGNITION)
	e1:SetRange(LOCATION_PZONE)
	e1:SetCountLimit(1,id+200)
	e1:SetTarget(s.pzrittg)
	e1:SetOperation(s.pzritop)
	c:RegisterEffect(e1)
	--If Ritual Summoned
	local e2=Effect.CreateEffect(c)
	e2:SetDescription(aux.Stringid(id,1))
	e2:SetCategory(CATEGORY_SPECIAL_SUMMON)
	e2:SetType(EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_O)
	e2:SetCode(EVENT_SPSUMMON_SUCCESS)
	e2:SetProperty(EFFECT_FLAG_DELAY)
	e2:SetCountLimit(1,id)
	e2:SetCondition(s.spcon)
	e2:SetTarget(s.sptg)
	e2:SetOperation(s.spop)
	c:RegisterEffect(e2)
	--Negate a Spell/Trap Card or effect
	local e3=Effect.CreateEffect(c)
	e3:SetDescription(aux.Stringid(id,2))
	e3:SetCategory(CATEGORY_NEGATE+CATEGORY_DESTROY)
	e3:SetType(EFFECT_TYPE_QUICK_O)
	e3:SetCode(EVENT_CHAINING)
	e3:SetRange(LOCATION_MZONE)
	e3:SetCountLimit(1,id+100)
	e3:SetCondition(s.negcon)
	e3:SetCost(s.negcost)
	e3:SetTarget(s.negtg)
	e3:SetOperation(s.negop)
	c:RegisterEffect(e3)
end
s.listed_series={SET_GLITCHLING}
s.listed_names={CARD_BITRON,CARD_PROTRON,CARD_DIGITRON}
s.counter_add_list={COUNTER_CORRUPTION}
function s.splimit(e,c)
	return not (c:IsLocation(LOCATION_EXTRA)
		or c:IsSetCard(SET_GLITCHLING)
		or (c:IsRace(RACE_CYBERSE) and (c:IsType(TYPE_RITUAL) or c:IsType(TYPE_NORMAL))))
end
function s.register_lock(e,tp)
	local e1=Effect.CreateEffect(e:GetHandler())
	e1:SetType(EFFECT_TYPE_FIELD)
	e1:SetProperty(EFFECT_FLAG_PLAYER_TARGET+EFFECT_FLAG_OATH)
	e1:SetCode(EFFECT_CANNOT_SPECIAL_SUMMON)
	e1:SetTargetRange(1,0)
	e1:SetTarget(s.splimit)
	e1:SetReset(RESET_PHASE+PHASE_END)
	Duel.RegisterEffect(e1,tp)
end
function s.matfilter(c,rc)
	return c:GetLevel()>0 and c:IsCanBeRitualMaterial(rc)
end
function s.corruptionfilter(c)
	return c:IsFaceup() and c:IsCode(CARD_CORRUPTION)
end
function s.countercap(tp,lv)
	if not Duel.IsExistingMatchingCard(s.corruptionfilter,tp,LOCATION_SZONE,0,1,nil) then return 0 end
	return math.min(lv,Duel.GetCounter(tp,1,1,COUNTER_CORRUPTION))
end
function s.matcheck(g,lv,ct)
	return g:GetSum(Card.GetLevel)+ct>=lv
end
function s.hasfieldmat(c)
	return c:IsLocation(LOCATION_MZONE)
end
function s.matgroup(tp,rc)
	local mg=Duel.GetMatchingGroup(s.matfilter,tp,LOCATION_HAND+LOCATION_MZONE,0,nil,rc)
	mg:RemoveCard(rc)
	return mg
end
function s.zonecheck(tp,rc,mat)
	if rc:IsLocation(LOCATION_EXTRA) then
		return Duel.GetLocationCountFromEx(tp,tp,mat,rc)>0
	end
	return Duel.GetMZoneCount(tp,mat)>0
end
function s.pzritfilter(c,e,tp)
	if c:IsCode(id) then return false end
	if c:IsLocation(LOCATION_EXTRA) and not c:IsFaceup() then return false end
	if not (c:IsSetCard(SET_GLITCHLING) and c:IsType(TYPE_RITUAL)
		and c:IsCanBeSpecialSummoned(e,SUMMON_TYPE_RITUAL,tp,false,true)) then return false end
	local lv=c:GetLevel()
	if lv<=0 then return false end
	local mg=s.matgroup(tp,c)
	if #mg==0 then return false end
	if Duel.GetLocationCount(tp,LOCATION_MZONE)<=0 and not mg:IsExists(s.hasfieldmat,1,nil) then return false end
	return mg:CheckSubGroup(s.matcheck,1,#mg,lv,s.countercap(tp,lv))
end
function s.pzrittg(e,tp,eg,ep,ev,re,r,rp,chk)
	local c=e:GetHandler()
	if chk==0 then return c:IsDestructable()
		and Duel.IsExistingMatchingCard(aux.NecroValleyFilter(s.pzritfilter),tp,LOCATION_HAND+LOCATION_GRAVE+LOCATION_EXTRA,0,1,nil,e,tp) end
	Duel.SetOperationInfo(0,CATEGORY_DESTROY,c,1,0,0)
	Duel.SetOperationInfo(0,CATEGORY_SPECIAL_SUMMON,nil,1,tp,LOCATION_HAND+LOCATION_GRAVE+LOCATION_EXTRA)
end
function s.pzritop(e,tp,eg,ep,ev,re,r,rp)
	local c=e:GetHandler()
	if Duel.Destroy(c,REASON_EFFECT)==0 then return end
	Duel.BreakEffect()
	s.ritualsummon(e,tp,LOCATION_HAND+LOCATION_GRAVE+LOCATION_EXTRA,s.pzritfilter)
end
function s.ritualsummon(e,tp,loc,filter)
	::cancel::
	Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_SPSUMMON)
	local tg=Duel.SelectMatchingCard(tp,aux.NecroValleyFilter(filter),tp,loc,0,1,1,nil,e,tp)
	local rc=tg:GetFirst()
	if not rc then return end
	local lv=rc:GetLevel()
	local mg=s.matgroup(tp,rc)
	Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_RELEASE)
	local mat=mg:SelectSubGroup(tp,s.matcheck,true,1,#mg,lv,s.countercap(tp,lv))
	if not mat then goto cancel end
	if not s.zonecheck(tp,rc,mat) then goto cancel end
	local deficit=lv-mat:GetSum(Card.GetLevel)
	if deficit<0 then deficit=0 end
	if deficit>0 then
		Duel.RemoveCounter(tp,1,1,COUNTER_CORRUPTION,deficit,REASON_EFFECT+REASON_MATERIAL+REASON_RITUAL)
	end
	rc:SetMaterial(mat)
	Duel.ReleaseRitualMaterial(mat)
	Duel.BreakEffect()
	if Duel.SpecialSummon(rc,SUMMON_TYPE_RITUAL,tp,tp,false,true,POS_FACEUP)>0 then
		rc:CompleteProcedure()
	end
end
function s.spcon(e,tp,eg,ep,ev,re,r,rp)
	return e:GetHandler():IsSummonType(SUMMON_TYPE_RITUAL)
end
function s.normalfilter(c,e,tp)
	return c:IsCode(CARD_BITRON,CARD_PROTRON,CARD_DIGITRON) and c:IsCanBeSpecialSummoned(e,0,tp,false,false)
end
function s.sptg(e,tp,eg,ep,ev,re,r,rp,chk)
	if chk==0 then return Duel.GetLocationCount(tp,LOCATION_MZONE)>0
		and Duel.IsExistingMatchingCard(aux.NecroValleyFilter(s.normalfilter),tp,LOCATION_HAND+LOCATION_DECK+LOCATION_GRAVE,0,1,nil,e,tp) end
	s.register_lock(e,tp)
	Duel.SetOperationInfo(0,CATEGORY_SPECIAL_SUMMON,nil,1,tp,LOCATION_HAND+LOCATION_DECK+LOCATION_GRAVE)
end
function s.mentions(c,code)
	if code==CARD_BITRON then
		return c:IsCode(CARD_GLITCHLING_BITRON,id,CARD_GLITCHLING_HEXATRON)
	elseif code==CARD_PROTRON then
		return c:IsCode(CARD_GLITCHLING_PROTRON,id,CARD_GLITCHLING_HEXATRON)
	elseif code==CARD_DIGITRON then
		return c:IsCode(CARD_GLITCHLING_DIGITRON,id,CARD_GLITCHLING_HEXATRON)
	end
	return false
end
function s.followfilter(c,e,tp,code)
	return c:IsSetCard(SET_GLITCHLING) and c:IsType(TYPE_MONSTER) and s.mentions(c,code)
		and (not c:IsLocation(LOCATION_EXTRA) or c:IsFaceup())
		and c:IsCanBeSpecialSummoned(e,0,tp,false,false)
end
function s.spop(e,tp,eg,ep,ev,re,r,rp)
	if Duel.GetLocationCount(tp,LOCATION_MZONE)<=0 then return end
	Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_SPSUMMON)
	local g=Duel.SelectMatchingCard(tp,aux.NecroValleyFilter(s.normalfilter),tp,LOCATION_HAND+LOCATION_DECK+LOCATION_GRAVE,0,1,1,nil,e,tp)
	local tc=g:GetFirst()
	if tc and Duel.SpecialSummon(tc,0,tp,tp,false,false,POS_FACEUP)>0 then
		local code=tc:GetCode()
		if Duel.IsExistingMatchingCard(aux.NecroValleyFilter(s.followfilter),tp,LOCATION_GRAVE+LOCATION_EXTRA,0,1,nil,e,tp,code)
			and Duel.SelectYesNo(tp,aux.Stringid(id,3)) then
			Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_SPSUMMON)
			local sg=Duel.SelectMatchingCard(tp,aux.NecroValleyFilter(s.followfilter),tp,LOCATION_GRAVE+LOCATION_EXTRA,0,1,1,nil,e,tp,code)
			local sc=sg:GetFirst()
			if sc then
				if sc:IsLocation(LOCATION_EXTRA) and Duel.GetLocationCountFromEx(tp,tp,nil,sc)<=0 then return end
				if not sc:IsLocation(LOCATION_EXTRA) and Duel.GetLocationCount(tp,LOCATION_MZONE)<=0 then return end
				Duel.SpecialSummon(sc,0,tp,tp,false,false,POS_FACEUP)
			end
		end
	end
end
function s.negcon(e,tp,eg,ep,ev,re,r,rp)
	return ep==1-tp and re:IsActiveType(TYPE_SPELL+TYPE_TRAP) and Duel.IsChainNegatable(ev)
end
function s.cfilter(c,handler)
	return c~=handler and c:IsRace(RACE_CYBERSE) and (c:IsType(TYPE_RITUAL) or c:IsType(TYPE_NORMAL)) and c:IsReleasable()
end
function s.negcost(e,tp,eg,ep,ev,re,r,rp,chk)
	local c=e:GetHandler()
	if chk==0 then return Duel.CheckReleaseGroup(tp,s.cfilter,1,nil,c) end
	Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_RELEASE)
	local g=Duel.SelectReleaseGroup(tp,s.cfilter,1,99,nil,c)
	e:SetLabel(#g)
	Duel.Release(g,REASON_COST)
end
function s.negtg(e,tp,eg,ep,ev,re,r,rp,chk)
	if chk==0 then return true end
	s.register_lock(e,tp)
	Duel.SetOperationInfo(0,CATEGORY_NEGATE,eg,1,0,0)
end
function s.negop(e,tp,eg,ep,ev,re,r,rp)
	local ct=e:GetLabel()
	if Duel.NegateActivation(ev) and ct>0 then
		local g=Duel.GetMatchingGroup(Card.IsDestructable,tp,0,LOCATION_SZONE,nil)
		if #g>0 then
			Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_DESTROY)
			local dg=g:Select(tp,1,math.min(ct,#g),nil)
			Duel.Destroy(dg,REASON_EFFECT)
		end
	end
end

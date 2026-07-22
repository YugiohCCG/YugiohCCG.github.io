local s,id=GetID()
local STRING_ID=133961648
local SET_GLITCHLING=0x9894
local COUNTER_CORRUPTION=0x1994
local CARD_BITRON=36211150
local CARD_PROTRON=24154052
local CARD_DIGITRON=32295838
local CARD_GLITCHLING_WITCH=259678739
local CARD_GLITCHLING_MAGE=259072906
function s.initial_effect(c)
	--Ritual Summon
	local e1=Effect.CreateEffect(c)
	e1:SetCategory(CATEGORY_SPECIAL_SUMMON)
	e1:SetType(EFFECT_TYPE_ACTIVATE)
	e1:SetCode(EVENT_FREE_CHAIN)
	e1:SetTarget(s.rittg)
	e1:SetOperation(s.ritop)
	c:RegisterEffect(e1)
	--Pendulum Summon
	local e2=Effect.CreateEffect(c)
	e2:SetDescription(aux.Stringid(STRING_ID,0))
	e2:SetCategory(CATEGORY_SPECIAL_SUMMON)
	e2:SetType(EFFECT_TYPE_FIELD+EFFECT_TYPE_TRIGGER_O)
	e2:SetCode(EVENT_SPSUMMON_SUCCESS)
	e2:SetProperty(EFFECT_FLAG_DELAY)
	e2:SetRange(LOCATION_GRAVE)
	e2:SetCountLimit(1,id)
	e2:SetCondition(s.pencon)
	e2:SetCost(aux.bfgcost)
	e2:SetTarget(s.pentg)
	e2:SetOperation(s.penop)
	c:RegisterEffect(e2)
end
s.listed_series={SET_GLITCHLING}
s.listed_names={CARD_BITRON,CARD_PROTRON,CARD_DIGITRON,CARD_GLITCHLING_WITCH,CARD_GLITCHLING_MAGE}
s.counter_add_list={COUNTER_CORRUPTION}
function s.normalfilter(c)
	return c:IsFaceup() and c:IsCode(CARD_BITRON,CARD_PROTRON,CARD_DIGITRON)
end
function s.ritloc(tp)
	local loc=LOCATION_HAND
	if Duel.IsExistingMatchingCard(s.normalfilter,tp,LOCATION_MZONE,0,1,nil) then
		loc=loc+LOCATION_GRAVE+LOCATION_EXTRA
	end
	return loc
end
function s.matfilter(c,rc)
	return c:GetLevel()>0 and c:IsCanBeRitualMaterial(rc)
end
function s.corruptionfilter(c)
	return c:IsFaceup() and c:IsCode(259546637)
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
function s.ritfilter(c,e,tp)
	if c:IsLocation(LOCATION_EXTRA) and not c:IsFaceup() then return false end
	if not (c:IsRace(RACE_CYBERSE) and c:IsType(TYPE_RITUAL)
		and c:IsCanBeSpecialSummoned(e,SUMMON_TYPE_RITUAL,tp,false,true)) then return false end
	local lv=c:GetLevel()
	if lv<=0 then return false end
	local mg=s.matgroup(tp,c)
	if #mg==0 then return false end
	if Duel.GetLocationCount(tp,LOCATION_MZONE)<=0 and not mg:IsExists(s.hasfieldmat,1,nil) then return false end
	return mg:CheckSubGroup(s.matcheck,1,#mg,lv,s.countercap(tp,lv))
end
function s.rittg(e,tp,eg,ep,ev,re,r,rp,chk)
	if chk==0 then return Duel.IsExistingMatchingCard(aux.NecroValleyFilter(s.ritfilter),tp,s.ritloc(tp),0,1,nil,e,tp) end
	Duel.SetOperationInfo(0,CATEGORY_SPECIAL_SUMMON,nil,1,tp,s.ritloc(tp))
end
function s.ritop(e,tp,eg,ep,ev,re,r,rp)
	s.ritualsummon(e,tp,s.ritloc(tp),s.ritfilter)
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
function s.exfilter(c,tp)
	return c:IsSummonPlayer(1-tp) and c:IsSummonLocation(LOCATION_EXTRA)
end
function s.pzfilter(c)
	return c:IsFaceup() and c:IsCode(CARD_GLITCHLING_WITCH,CARD_GLITCHLING_MAGE)
end
function s.pencon(e,tp,eg,ep,ev,re,r,rp)
	return eg:IsExists(s.exfilter,1,nil,tp)
		and Duel.IsExistingMatchingCard(s.pzfilter,tp,LOCATION_PZONE,0,1,nil)
end
function s.penfilter(c,e,tp,lscale,rscale,eset)
	return c:IsRace(RACE_CYBERSE) and aux.PConditionFilter(c,e,tp,lscale,rscale,eset)
end
function s.pentg(e,tp,eg,ep,ev,re,r,rp,chk)
	if chk==0 then
		local lpz=Duel.GetFieldCard(tp,LOCATION_PZONE,0)
		local rpz=Duel.GetFieldCard(tp,LOCATION_PZONE,1)
		if not (lpz and rpz) then return false end
		local loc=0
		if Duel.GetLocationCount(tp,LOCATION_MZONE)>0 then loc=loc+LOCATION_HAND end
		if Duel.GetLocationCountFromEx(tp,tp,nil,TYPE_PENDULUM)>0 then loc=loc+LOCATION_EXTRA end
		if loc==0 then return false end
		local e1=Effect.CreateEffect(e:GetHandler())
		e1:SetType(EFFECT_TYPE_FIELD)
		e1:SetCode(EFFECT_EXTRA_PENDULUM_SUMMON)
		e1:SetProperty(EFFECT_FLAG_PLAYER_TARGET)
		e1:SetTargetRange(1,0)
		e1:SetValue(aux.TRUE)
		e1:SetReset(RESET_PHASE+PHASE_END)
		Duel.RegisterEffect(e1,tp)
		local eset={e1}
		local lscale=lpz:GetLeftScale()
		local rscale=rpz:GetRightScale()
		if lscale>rscale then lscale,rscale=rscale,lscale end
		local g=Duel.GetFieldGroup(tp,loc,0)
		local res=g:IsExists(s.penfilter,1,nil,e,tp,lscale,rscale,eset)
		e1:Reset()
		return res
	end
	Duel.SetOperationInfo(0,CATEGORY_SPECIAL_SUMMON,nil,1,tp,LOCATION_HAND+LOCATION_EXTRA)
end
function s.penop(e,tp,eg,ep,ev,re,r,rp)
	local lpz=Duel.GetFieldCard(tp,LOCATION_PZONE,0)
	local rpz=Duel.GetFieldCard(tp,LOCATION_PZONE,1)
	if not (lpz and rpz) then return end
	local e1=Effect.CreateEffect(e:GetHandler())
	e1:SetType(EFFECT_TYPE_FIELD)
	e1:SetCode(EFFECT_EXTRA_PENDULUM_SUMMON)
	e1:SetProperty(EFFECT_FLAG_PLAYER_TARGET)
	e1:SetTargetRange(1,0)
	e1:SetValue(aux.TRUE)
	e1:SetReset(RESET_PHASE+PHASE_END)
	Duel.RegisterEffect(e1,tp)
	local eset={e1}
	local lscale=lpz:GetLeftScale()
	local rscale=rpz:GetRightScale()
	if lscale>rscale then lscale,rscale=rscale,lscale end
	local loc=0
	local ft1=Duel.GetLocationCount(tp,LOCATION_MZONE)
	local ft2=Duel.GetLocationCountFromEx(tp,tp,nil,TYPE_PENDULUM)
	local ft=Duel.GetUsableMZoneCount(tp)
	local ect=c29724053 and Duel.IsPlayerAffectedByEffect(tp,29724053) and c29724053[tp]
	if ect and ect<ft2 then ft2=ect end
	if Duel.IsPlayerAffectedByEffect(tp,59822133) then
		if ft1>0 then ft1=1 end
		if ft2>0 then ft2=1 end
		ft=1
	end
	if ft1>0 then loc=loc+LOCATION_HAND end
	if ft2>0 then loc=loc+LOCATION_EXTRA end
	local tg=Duel.GetMatchingGroup(s.penfilter,tp,loc,0,nil,e,tp,lscale,rscale,eset)
	tg=tg:Filter(aux.PConditionExtraFilterSpecific,nil,e,tp,lscale,rscale,e1)
	if #tg==0 then e1:Reset() return end
	Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_SPSUMMON)
	aux.GCheckAdditional=aux.PendOperationCheck(ft1,ft2,ft)
	local g=tg:SelectSubGroup(tp,aux.TRUE,false,1,math.min(#tg,ft))
	aux.GCheckAdditional=nil
	if not g then e1:Reset() return end
	local sg=Group.CreateGroup()
	sg:Merge(g)
	Duel.HintSelection(Group.FromCards(lpz))
	Duel.HintSelection(Group.FromCards(rpz))
	Duel.RaiseEvent(sg,EVENT_SPSUMMON_SUCCESS_G_P,e,REASON_EFFECT,tp,tp,0)
	Duel.SpecialSummon(sg,SUMMON_TYPE_PENDULUM,tp,tp,true,true,POS_FACEUP)
	e1:Reset()
end

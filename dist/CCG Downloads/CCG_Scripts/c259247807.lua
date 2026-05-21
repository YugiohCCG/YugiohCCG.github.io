local s,id=GetID()
local SET_GLITCHLING=0x9894
local COUNTER_CORRUPTION=0x1994
local CARD_BITRON=36211150
local CARD_PROTRON=24154052
local CARD_DIGITRON=32295838
local CARD_DATA_TRANSFERT=259961648
local CARD_CORRUPTION=259546637
function s.initial_effect(c)
	c:EnableReviveLimit()
	--Special Summon limit
	local e0=Effect.CreateEffect(c)
	e0:SetType(EFFECT_TYPE_SINGLE)
	e0:SetProperty(EFFECT_FLAG_CANNOT_DISABLE+EFFECT_FLAG_UNCOPYABLE)
	e0:SetCode(EFFECT_SPSUMMON_CONDITION)
	e0:SetValue(aux.ritlimit)
	c:RegisterEffect(e0)
	--ATK/DEF down
	local e1=Effect.CreateEffect(c)
	e1:SetType(EFFECT_TYPE_FIELD)
	e1:SetCode(EFFECT_UPDATE_ATTACK)
	e1:SetRange(LOCATION_MZONE)
	e1:SetTargetRange(0,LOCATION_MZONE)
	e1:SetValue(s.atkval)
	c:RegisterEffect(e1)
	local e2=e1:Clone()
	e2:SetCode(EFFECT_UPDATE_DEFENSE)
	c:RegisterEffect(e2)
	--If Ritual Summoned: Special Summon "Bitron"
	local e3=Effect.CreateEffect(c)
	e3:SetDescription(aux.Stringid(id,0))
	e3:SetCategory(CATEGORY_SPECIAL_SUMMON)
	e3:SetType(EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_O)
	e3:SetCode(EVENT_SPSUMMON_SUCCESS)
	e3:SetProperty(EFFECT_FLAG_DELAY)
	e3:SetCountLimit(1,id)
	e3:SetCondition(s.spcon)
	e3:SetTarget(s.sptg)
	e3:SetOperation(s.spop)
	c:RegisterEffect(e3)
	--Send a "Glitchling" Spell/Trap and apply its activation effect
	local e4=Effect.CreateEffect(c)
	e4:SetDescription(aux.Stringid(id,1))
	e4:SetCategory(CATEGORY_TOGRAVE+CATEGORY_SPECIAL_SUMMON+CATEGORY_TOHAND+CATEGORY_COUNTER)
	e4:SetType(EFFECT_TYPE_QUICK_O)
	e4:SetCode(EVENT_FREE_CHAIN)
	e4:SetRange(LOCATION_HAND+LOCATION_MZONE)
	e4:SetHintTiming(0,TIMING_MAIN_END)
	e4:SetCountLimit(1,id+100)
	e4:SetCondition(s.sendcon)
	e4:SetCost(s.sendcost)
	e4:SetTarget(s.sendtg)
	e4:SetOperation(s.sendop)
	c:RegisterEffect(e4)
end
s.listed_series={SET_GLITCHLING}
s.listed_names={CARD_BITRON,CARD_DATA_TRANSFERT,CARD_CORRUPTION}
s.counter_add_list={COUNTER_CORRUPTION}
function s.atkval(e,c)
	return c:GetCounter(COUNTER_CORRUPTION)*-200
end
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
function s.spcon(e,tp,eg,ep,ev,re,r,rp)
	return e:GetHandler():IsSummonType(SUMMON_TYPE_RITUAL)
end
function s.bitronfilter(c,e,tp)
	return c:IsCode(CARD_BITRON) and c:IsCanBeSpecialSummoned(e,0,tp,false,false)
end
function s.sptg(e,tp,eg,ep,ev,re,r,rp,chk)
	if chk==0 then return Duel.GetLocationCount(tp,LOCATION_MZONE)>0
		and Duel.IsExistingMatchingCard(aux.NecroValleyFilter(s.bitronfilter),tp,LOCATION_HAND+LOCATION_DECK+LOCATION_GRAVE,0,1,nil,e,tp) end
	s.register_lock(e,tp)
	Duel.SetOperationInfo(0,CATEGORY_SPECIAL_SUMMON,nil,1,tp,LOCATION_HAND+LOCATION_DECK+LOCATION_GRAVE)
end
function s.spop(e,tp,eg,ep,ev,re,r,rp)
	if Duel.GetLocationCount(tp,LOCATION_MZONE)<=0 then return end
	Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_SPSUMMON)
	local g=Duel.SelectMatchingCard(tp,aux.NecroValleyFilter(s.bitronfilter),tp,LOCATION_HAND+LOCATION_DECK+LOCATION_GRAVE,0,1,1,nil,e,tp)
	if #g>0 then
		Duel.SpecialSummon(g,0,tp,tp,false,false,POS_FACEUP)
	end
end
function s.sendcon(e,tp,eg,ep,ev,re,r,rp)
	local ph=Duel.GetCurrentPhase()
	return ph==PHASE_MAIN1 or ph==PHASE_MAIN2
end
function s.sendcost(e,tp,eg,ep,ev,re,r,rp,chk)
	if chk==0 then return Duel.IsExistingMatchingCard(Card.IsDiscardable,tp,LOCATION_HAND,0,1,nil) end
	Duel.DiscardHand(tp,Card.IsDiscardable,1,1,REASON_COST+REASON_DISCARD,nil)
end
function s.stfilter(c)
	return c:IsSetCard(SET_GLITCHLING) and c:IsType(TYPE_SPELL+TYPE_TRAP) and c:IsAbleToGrave()
end
function s.sendtg(e,tp,eg,ep,ev,re,r,rp,chk)
	if chk==0 then return Duel.IsExistingMatchingCard(s.stfilter,tp,LOCATION_DECK,0,1,nil) end
	s.register_lock(e,tp)
	Duel.SetOperationInfo(0,CATEGORY_TOGRAVE,nil,1,tp,LOCATION_DECK)
end
function s.sendop(e,tp,eg,ep,ev,re,r,rp)
	Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_TOGRAVE)
	local g=Duel.SelectMatchingCard(tp,s.stfilter,tp,LOCATION_DECK,0,1,1,nil)
	local tc=g:GetFirst()
	if not tc or Duel.SendtoGrave(tc,REASON_EFFECT)==0 or not tc:IsLocation(LOCATION_GRAVE) then return end
	if tc:IsCode(CARD_DATA_TRANSFERT) then
		Duel.BreakEffect()
		s.dataop(e,tp)
	elseif tc:IsCode(CARD_CORRUPTION) then
		Duel.BreakEffect()
		s.corruptionop(e,tp)
	end
	if Duel.IsExistingMatchingCard(Card.IsCanAddCounter,tp,LOCATION_ONFIELD,LOCATION_ONFIELD,1,nil,COUNTER_CORRUPTION,1)
		and Duel.SelectYesNo(tp,aux.Stringid(id,2)) then
		Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_FACEUP)
		local cg=Duel.SelectMatchingCard(tp,Card.IsCanAddCounter,tp,LOCATION_ONFIELD,LOCATION_ONFIELD,1,1,nil,COUNTER_CORRUPTION,1)
		local cc=cg:GetFirst()
		if cc then cc:AddCounter(COUNTER_CORRUPTION,1) end
	end
end
function s.corruptionthfilter(c)
	return c:IsSetCard(SET_GLITCHLING) and not c:IsCode(CARD_CORRUPTION) and c:IsAbleToHand()
		and (not c:IsLocation(LOCATION_EXTRA) or c:IsFaceup())
end
function s.corruptionop(e,tp)
	if Duel.IsExistingMatchingCard(s.corruptionthfilter,tp,LOCATION_DECK+LOCATION_EXTRA,0,1,nil) then
		Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_ATOHAND)
		local g=Duel.SelectMatchingCard(tp,s.corruptionthfilter,tp,LOCATION_DECK+LOCATION_EXTRA,0,1,1,nil)
		if #g>0 then
			Duel.SendtoHand(g,nil,REASON_EFFECT)
			Duel.ConfirmCards(1-tp,g)
		end
	end
end
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
function s.dataop(e,tp)
	if not Duel.IsExistingMatchingCard(aux.NecroValleyFilter(s.ritfilter),tp,s.ritloc(tp),0,1,nil,e,tp) then return end
	::cancel::
	Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_SPSUMMON)
	local tg=Duel.SelectMatchingCard(tp,aux.NecroValleyFilter(s.ritfilter),tp,s.ritloc(tp),0,1,1,nil,e,tp)
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

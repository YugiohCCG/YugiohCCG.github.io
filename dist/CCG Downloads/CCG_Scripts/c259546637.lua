local s,id=GetID()
local STRING_ID=133546637
local SET_GLITCHLING=0x9894
local COUNTER_CORRUPTION=0x1994
function s.initial_effect(c)
	c:EnableCounterPermit(COUNTER_CORRUPTION,LOCATION_SZONE)
	--Remain on the field
	local e0=Effect.CreateEffect(c)
	e0:SetType(EFFECT_TYPE_SINGLE)
	e0:SetProperty(EFFECT_FLAG_CANNOT_DISABLE+EFFECT_FLAG_UNCOPYABLE)
	e0:SetCode(EFFECT_REMAIN_FIELD)
	c:RegisterEffect(e0)
	--Activate
	local e1=Effect.CreateEffect(c)
	e1:SetCategory(CATEGORY_TOHAND+CATEGORY_SEARCH)
	e1:SetType(EFFECT_TYPE_ACTIVATE)
	e1:SetCode(EVENT_FREE_CHAIN)
	e1:SetCountLimit(1,id+EFFECT_COUNT_CODE_OATH)
	e1:SetTarget(s.acttg)
	e1:SetOperation(s.actop)
	c:RegisterEffect(e1)
	--If a Cyberse Ritual Monster is Tributed
	local e2=Effect.CreateEffect(c)
	e2:SetDescription(aux.Stringid(STRING_ID,1))
	e2:SetCategory(CATEGORY_SPECIAL_SUMMON+CATEGORY_COUNTER)
	e2:SetType(EFFECT_TYPE_FIELD+EFFECT_TYPE_TRIGGER_O)
	e2:SetCode(EVENT_RELEASE)
	e2:SetProperty(EFFECT_FLAG_DELAY)
	e2:SetRange(LOCATION_SZONE)
	e2:SetCountLimit(1,id+100)
	e2:SetCondition(s.relcon)
	e2:SetTarget(s.trigtg)
	e2:SetOperation(s.trigop)
	c:RegisterEffect(e2)
	--If a Cyberse Ritual Monster is used as Link Material
	local e3=e2:Clone()
	e3:SetCode(EVENT_BE_MATERIAL)
	e3:SetCondition(s.matcon)
	c:RegisterEffect(e3)
end
s.listed_series={SET_GLITCHLING}
s.counter_add_list={COUNTER_CORRUPTION}
function s.thfilter(c)
	return c:IsSetCard(SET_GLITCHLING) and not c:IsCode(id) and c:IsAbleToHand()
		and (not c:IsLocation(LOCATION_EXTRA) or c:IsFaceup())
end
function s.acttg(e,tp,eg,ep,ev,re,r,rp,chk)
	if chk==0 then return true end
	if Duel.IsExistingMatchingCard(s.thfilter,tp,LOCATION_DECK+LOCATION_EXTRA,0,1,nil) then
		Duel.SetOperationInfo(0,CATEGORY_TOHAND,nil,1,tp,LOCATION_DECK+LOCATION_EXTRA)
	end
end
function s.actop(e,tp,eg,ep,ev,re,r,rp)
	if Duel.IsExistingMatchingCard(s.thfilter,tp,LOCATION_DECK+LOCATION_EXTRA,0,1,nil)
		and Duel.SelectYesNo(tp,aux.Stringid(STRING_ID,0)) then
		Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_ATOHAND)
		local g=Duel.SelectMatchingCard(tp,s.thfilter,tp,LOCATION_DECK+LOCATION_EXTRA,0,1,1,nil)
		if #g>0 then
			Duel.SendtoHand(g,nil,REASON_EFFECT)
			Duel.ConfirmCards(1-tp,g)
		end
	end
end
function s.trigfilter(c)
	return c:IsRace(RACE_CYBERSE) and c:IsType(TYPE_RITUAL)
end
function s.relcon(e,tp,eg,ep,ev,re,r,rp)
	return eg:IsExists(s.trigfilter,1,nil)
end
function s.matcon(e,tp,eg,ep,ev,re,r,rp)
	return eg:IsExists(s.linkmatfilter,1,nil)
end
function s.linkmatfilter(c)
	return s.trigfilter(c) and c:IsReason(REASON_LINK)
end
function s.matfilter(c,rc)
	return c:GetLevel()>0 and c:IsCanBeRitualMaterial(rc)
end
function s.countercap(tp,lv)
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
	if not (c:IsSetCard(SET_GLITCHLING) and c:IsType(TYPE_RITUAL)
		and c:IsCanBeSpecialSummoned(e,SUMMON_TYPE_RITUAL,tp,false,true)) then return false end
	local lv=c:GetLevel()
	if lv<=0 then return false end
	local mg=s.matgroup(tp,c)
	if #mg==0 then return false end
	if Duel.GetLocationCount(tp,LOCATION_MZONE)<=0 and not mg:IsExists(s.hasfieldmat,1,nil) then return false end
	return mg:CheckSubGroup(s.matcheck,1,#mg,lv,s.countercap(tp,lv))
end
function s.canritual(e,tp)
	return Duel.IsExistingMatchingCard(aux.NecroValleyFilter(s.ritfilter),tp,LOCATION_GRAVE+LOCATION_EXTRA,0,1,nil,e,tp)
end
function s.cancounter(e,tp)
	local c=e:GetHandler()
	return c:IsRelateToEffect(e) and c:IsFaceup() and c:IsCanAddCounter(COUNTER_CORRUPTION,1)
		and Duel.IsExistingMatchingCard(Card.IsRace,tp,LOCATION_MZONE,0,1,nil,RACE_CYBERSE)
end
function s.trigtg(e,tp,eg,ep,ev,re,r,rp,chk)
	if chk==0 then return s.canritual(e,tp) or s.cancounter(e,tp) end
end
function s.trigop(e,tp,eg,ep,ev,re,r,rp)
	local b1=s.canritual(e,tp)
	local b2=s.cancounter(e,tp)
	if not (b1 or b2) then return end
	local op=0
	if b1 and b2 then
		op=Duel.SelectOption(tp,aux.Stringid(STRING_ID,1),aux.Stringid(STRING_ID,2))
	elseif b2 then
		op=1
	end
	if op==0 then
		s.ritualsummon(e,tp)
	else
		local c=e:GetHandler()
		local ct=Duel.GetMatchingGroupCount(Card.IsRace,tp,LOCATION_MZONE,0,nil,RACE_CYBERSE)
		if ct>0 and c:IsRelateToEffect(e) and c:IsFaceup() and c:IsCanAddCounter(COUNTER_CORRUPTION,1) then
			local opts={}
			for i=1,ct do
				if c:IsCanAddCounter(COUNTER_CORRUPTION,i) then opts[#opts+1]=i end
			end
			if #opts>0 then c:AddCounter(COUNTER_CORRUPTION,Duel.AnnounceNumber(tp,table.unpack(opts))) end
		end
	end
end
function s.ritualsummon(e,tp)
	::cancel::
	Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_SPSUMMON)
	local tg=Duel.SelectMatchingCard(tp,aux.NecroValleyFilter(s.ritfilter),tp,LOCATION_GRAVE+LOCATION_EXTRA,0,1,1,nil,e,tp)
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

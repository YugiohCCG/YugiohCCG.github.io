--Charmelia Pray
local s,id=GetID()
local STRING_ID=133241946
local SET_CHARMELIA=0x12b1
function s.initial_effect(c)
	--Activate and Ritual Summon
	local e1=Effect.CreateEffect(c)
	e1:SetDescription(aux.Stringid(STRING_ID,0))
	e1:SetCategory(CATEGORY_SPECIAL_SUMMON+CATEGORY_TOGRAVE)
	e1:SetType(EFFECT_TYPE_ACTIVATE)
	e1:SetCode(EVENT_FREE_CHAIN)
	e1:SetCountLimit(1,id+EFFECT_COUNT_CODE_OATH)
	e1:SetTarget(s.rittg)
	e1:SetOperation(s.ritop)
	c:RegisterEffect(e1)
end
s.listed_series={SET_CHARMELIA}
function s.charmritual(c,e,tp)
	return c:IsSetCard(SET_CHARMELIA) and c:IsType(TYPE_RITUAL)
		and c:IsCanBeSpecialSummoned(e,SUMMON_TYPE_RITUAL,tp,false,true)
end
function s.monmatfilter(c,rc)
	return c:IsType(TYPE_MONSTER) and c:GetLevel()>0 and c:IsAbleToGrave()
		and c:IsCanBeRitualMaterial(rc)
end
function s.stmatfilter(c)
	return c:IsFaceup() and c:IsSetCard(SET_CHARMELIA) and c:IsType(TYPE_CONTINUOUS)
		and c:IsType(TYPE_SPELL+TYPE_TRAP) and c:IsAbleToGrave()
end
function s.materialvalue(c)
	if c:IsLocation(LOCATION_SZONE) then return 4 end
	if c:IsType(TYPE_MONSTER) then return c:GetLevel() end
	return 4
end
function s.materialzone(tp,mat)
	local fm=mat:Filter(Card.IsLocation,nil,LOCATION_MZONE)
	return Duel.GetMZoneCount(tp,fm)>0
end
function s.materialcheck(g,lv,tp)
	return g:GetSum(s.materialvalue)>=lv and s.materialzone(tp,g)
end
function s.materialgroup(tp,rc)
	local mg=Duel.GetMatchingGroup(s.monmatfilter,tp,LOCATION_HAND+LOCATION_MZONE+LOCATION_DECK,0,rc,rc)
	mg:RemoveCard(rc)
	local sg=Duel.GetMatchingGroup(s.stmatfilter,tp,LOCATION_SZONE,0,nil)
	mg:Merge(sg)
	return mg
end
function s.canritual(c,e,tp)
	if not s.charmritual(c,e,tp) then return false end
	local mg=s.materialgroup(tp,c)
	return #mg>0 and mg:CheckSubGroup(s.materialcheck,1,#mg,c:GetLevel(),tp)
end
function s.rittg(e,tp,eg,ep,ev,re,r,rp,chk)
	if chk==0 then return Duel.IsExistingMatchingCard(aux.NecroValleyFilter(s.canritual),tp,
		LOCATION_HAND+LOCATION_GRAVE,0,1,nil,e,tp) end
	Duel.SetOperationInfo(0,CATEGORY_SPECIAL_SUMMON,nil,1,tp,LOCATION_HAND+LOCATION_GRAVE)
	Duel.SetOperationInfo(0,CATEGORY_TOGRAVE,nil,1,tp,LOCATION_DECK+LOCATION_ONFIELD)
end
function s.ismonmat(c)
	return c:IsType(TYPE_MONSTER) and c:IsLocation(LOCATION_HAND+LOCATION_MZONE+LOCATION_DECK)
end
function s.ritualsummon(e,tp)
	::cancel::
	Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_SPSUMMON)
	local rc=Duel.SelectMatchingCard(tp,aux.NecroValleyFilter(s.canritual),tp,
		LOCATION_HAND+LOCATION_GRAVE,0,1,1,nil,e,tp):GetFirst()
	if not rc then return end
	local mg=s.materialgroup(tp,rc)
	Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_RELEASE)
	local mat=mg:SelectSubGroup(tp,s.materialcheck,true,1,#mg,rc:GetLevel(),tp)
	if not mat then goto cancel end
	local monmat=mat:Filter(s.ismonmat,nil)
	local stmat=mat:Filter(Card.IsLocation,nil,LOCATION_SZONE)
	local handfieldmat=monmat:Filter(Card.IsLocation,nil,LOCATION_HAND+LOCATION_MZONE)
	local deckmat=monmat:Filter(Card.IsLocation,nil,LOCATION_DECK)
	rc:SetMaterial(monmat)
	if #handfieldmat>0 then Duel.ReleaseRitualMaterial(handfieldmat) end
	if #deckmat>0 then Duel.SendtoGrave(deckmat,REASON_EFFECT+REASON_MATERIAL+REASON_RITUAL) end
	if #stmat>0 then Duel.SendtoGrave(stmat,REASON_EFFECT+REASON_MATERIAL+REASON_RITUAL) end
	Duel.BreakEffect()
	if Duel.SpecialSummon(rc,SUMMON_TYPE_RITUAL,tp,tp,false,true,POS_FACEUP)>0 then
		rc:CompleteProcedure()
		return true
	end
	return false
end
function s.exlimit(e,c)
	return c:IsLocation(LOCATION_EXTRA) and not c:IsRace(RACE_SPELLCASTER+RACE_FAIRY)
end
function s.register_lock(e,tp)
	local e1=Effect.CreateEffect(e:GetHandler())
	e1:SetType(EFFECT_TYPE_FIELD)
	e1:SetProperty(EFFECT_FLAG_PLAYER_TARGET)
	e1:SetCode(EFFECT_CANNOT_SPECIAL_SUMMON)
	e1:SetTargetRange(1,0)
	e1:SetTarget(s.exlimit)
	e1:SetReset(RESET_PHASE+PHASE_END)
	Duel.RegisterEffect(e1,tp)
end
function s.ritop(e,tp,eg,ep,ev,re,r,rp)
	if s.ritualsummon(e,tp) then
		s.register_lock(e,tp)
	end
end

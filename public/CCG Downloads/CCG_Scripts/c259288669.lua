--Charmelia Elysia
local s,id=GetID()
local SET_CHARMELIA=0x12b1
function s.initial_effect(c)
	--Discard this card to Ritual Summon
	local e1=Effect.CreateEffect(c)
	e1:SetDescription(aux.Stringid(id,0))
	e1:SetCategory(CATEGORY_SPECIAL_SUMMON+CATEGORY_TOGRAVE)
	e1:SetType(EFFECT_TYPE_QUICK_O)
	e1:SetCode(EVENT_FREE_CHAIN)
	e1:SetRange(LOCATION_HAND)
	e1:SetHintTiming(0,TIMINGS_CHECK_MONSTER)
	e1:SetCountLimit(1,id)
	e1:SetCondition(s.ritcon)
	e1:SetCost(s.ritcost)
	e1:SetTarget(s.rittg)
	e1:SetOperation(s.ritop)
	c:RegisterEffect(e1)
	--If Tributed for a Ritual Summon: return this card, then Special Summon
	local e2=Effect.CreateEffect(c)
	e2:SetDescription(aux.Stringid(id,1))
	e2:SetCategory(CATEGORY_TODECK+CATEGORY_SPECIAL_SUMMON)
	e2:SetType(EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_O)
	e2:SetCode(EVENT_RELEASE)
	e2:SetProperty(EFFECT_FLAG_DELAY)
	e2:SetCountLimit(1,id+100)
	e2:SetCondition(s.spcon)
	e2:SetTarget(s.sptg)
	e2:SetOperation(s.spop)
	c:RegisterEffect(e2)
end
s.listed_series={SET_CHARMELIA}
function s.ritcon(e,tp,eg,ep,ev,re,r,rp)
	local ph=Duel.GetCurrentPhase()
	return ph==PHASE_MAIN1 or ph==PHASE_MAIN2
end
function s.ritcost(e,tp,eg,ep,ev,re,r,rp,chk)
	if chk==0 then return e:GetHandler():IsDiscardable() end
	Duel.SendtoGrave(e:GetHandler(),REASON_COST+REASON_DISCARD)
end
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
	if chk==0 then return Duel.IsExistingMatchingCard(s.canritual,tp,LOCATION_HAND,0,1,nil,e,tp) end
	Duel.SetOperationInfo(0,CATEGORY_SPECIAL_SUMMON,nil,1,tp,LOCATION_HAND)
	Duel.SetOperationInfo(0,CATEGORY_TOGRAVE,nil,1,tp,LOCATION_DECK+LOCATION_ONFIELD)
end
function s.ismonmat(c)
	return c:IsType(TYPE_MONSTER) and c:IsLocation(LOCATION_HAND+LOCATION_MZONE+LOCATION_DECK)
end
function s.ritop(e,tp,eg,ep,ev,re,r,rp)
	::cancel::
	Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_SPSUMMON)
	local rc=Duel.SelectMatchingCard(tp,s.canritual,tp,LOCATION_HAND,0,1,1,nil,e,tp):GetFirst()
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
	if #stmat>0 then Duel.SendtoGrave(stmat,REASON_EFFECT+REASON_RITUAL) end
	Duel.BreakEffect()
	if Duel.SpecialSummon(rc,SUMMON_TYPE_RITUAL,tp,tp,false,true,POS_FACEUP)>0 then
		rc:CompleteProcedure()
	end
end
function s.spcon(e,tp,eg,ep,ev,re,r,rp)
	return e:GetHandler():IsReason(REASON_RITUAL)
end
function s.spfilter(c,e,tp)
	return c:IsSetCard(SET_CHARMELIA) and c:IsType(TYPE_MONSTER)
		and c:IsCanBeSpecialSummoned(e,0,tp,false,false)
end
function s.sptg(e,tp,eg,ep,ev,re,r,rp,chk)
	local c=e:GetHandler()
	if chk==0 then return c:IsAbleToDeck() and aux.NecroValleyFilter()(c)
		and Duel.GetLocationCount(tp,LOCATION_MZONE)>0
		and Duel.IsExistingMatchingCard(aux.NecroValleyFilter(s.spfilter),tp,
			LOCATION_HAND+LOCATION_GRAVE,0,1,nil,e,tp) end
	Duel.SetOperationInfo(0,CATEGORY_TODECK,c,1,0,0)
	Duel.SetOperationInfo(0,CATEGORY_SPECIAL_SUMMON,nil,1,tp,LOCATION_HAND+LOCATION_GRAVE)
end
function s.spop(e,tp,eg,ep,ev,re,r,rp)
	local c=e:GetHandler()
	if not aux.NecroValleyFilter()(c) then return end
	if Duel.SendtoDeck(c,nil,SEQ_DECKBOTTOM,REASON_EFFECT)==0 or not c:IsLocation(LOCATION_DECK) then return end
	if Duel.GetLocationCount(tp,LOCATION_MZONE)<=0 then return end
	Duel.BreakEffect()
	Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_SPSUMMON)
	local tc=Duel.SelectMatchingCard(tp,aux.NecroValleyFilter(s.spfilter),tp,
		LOCATION_HAND+LOCATION_GRAVE,0,1,1,nil,e,tp):GetFirst()
	if tc then
		Duel.SpecialSummon(tc,0,tp,tp,false,false,POS_FACEUP)
	end
end

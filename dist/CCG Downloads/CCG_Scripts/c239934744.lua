local s,id=GetID()
local STRING_ID=133934744
local SET_FIENDSMITH=0x1b0
local ENGRAVER=60764609
function s.initial_effect(c)
	Duel.AddCustomActivityCounter(id,ACTIVITY_SPSUMMON,s.lightfiend)
	if not s.global_check then
		s.global_check=true
		local ge=Effect.CreateEffect(c)
		ge:SetType(EFFECT_TYPE_FIELD+EFFECT_TYPE_CONTINUOUS)
		ge:SetCode(EVENT_LEAVE_GRAVE)
		ge:SetOperation(s.track)
		Duel.RegisterEffect(ge,0)
	end
	local e=Effect.CreateEffect(c)
	e:SetDescription(aux.Stringid(STRING_ID,0))
	e:SetType(EFFECT_TYPE_ACTIVATE)
	e:SetCode(EVENT_FREE_CHAIN)
	e:SetCountLimit(1,id)
	e:SetCost(s.lockcost)
	e:SetTarget(s.sptg)
	e:SetOperation(s.spop)
	c:RegisterEffect(e)
	local e2=Effect.CreateEffect(c)
	e2:SetDescription(aux.Stringid(STRING_ID,1))
	e2:SetType(EFFECT_TYPE_IGNITION)
	e2:SetRange(LOCATION_GRAVE)
	e2:SetCountLimit(1,id+100)
	e2:SetCondition(function(e,tp) return Duel.GetFlagEffect(tp,id)>0 end)
	e2:SetCost(s.setcost)
	e2:SetTarget(s.settg)
	e2:SetOperation(s.setop)
	c:RegisterEffect(e2)
end
function s.lightfiend(c)
	return c:IsAttribute(ATTRIBUTE_LIGHT) and c:IsRace(RACE_FIEND)
end
function s.track(e,tp,eg)
	if eg:IsExists(s.lightfiend,1,nil) then
		for p=0,1 do Duel.RegisterFlagEffect(p,id,RESET_PHASE+PHASE_END,0,1) end
	end
end
function s.lockcost(e,tp,eg,ep,ev,re,r,rp,chk)
	if chk==0 then return Duel.GetCustomActivityCount(id,tp,ACTIVITY_SPSUMMON)==0 end
	local lock=Effect.CreateEffect(e:GetHandler())
	lock:SetType(EFFECT_TYPE_FIELD)
	lock:SetProperty(EFFECT_FLAG_PLAYER_TARGET+EFFECT_FLAG_OATH)
	lock:SetCode(EFFECT_CANNOT_SPECIAL_SUMMON)
	lock:SetTargetRange(1,0)
	lock:SetTarget(function(_,c) return not s.lightfiend(c) end)
	lock:SetReset(RESET_PHASE+PHASE_END)
	Duel.RegisterEffect(lock,tp)
end
function s.spfilter(c,e,tp)
	return c:IsCode(ENGRAVER) and c:IsCanBeSpecialSummoned(e,0,tp,false,false)
end
function s.sptg(e,tp,eg,ep,ev,re,r,rp,chk)
	if chk==0 then return Duel.GetLocationCount(tp,LOCATION_MZONE)>0
		and Duel.IsExistingMatchingCard(s.spfilter,tp,LOCATION_HAND+LOCATION_DECK,0,1,nil,e,tp) end
	Duel.SetOperationInfo(0,CATEGORY_SPECIAL_SUMMON,nil,1,tp,LOCATION_HAND+LOCATION_DECK)
end
function s.lkfilter(c,mc,mg)
	return c:IsSetCard(SET_FIENDSMITH) and c:IsType(TYPE_LINK) and s.lightfiend(c)
		and c:IsLinkSummonable(mg,mc)
end
function s.engraver(c,tp,mg)
	return c:IsFaceup() and c:IsCode(ENGRAVER)
		and Duel.IsExistingMatchingCard(s.lkfilter,tp,LOCATION_EXTRA,0,1,nil,c,mg)
end
function s.spop(e,tp)
	if Duel.GetLocationCount(tp,LOCATION_MZONE)<=0 then return end
	Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_SPSUMMON)
	local tc=Duel.SelectMatchingCard(tp,s.spfilter,tp,LOCATION_HAND+LOCATION_DECK,0,1,1,nil,e,tp):GetFirst()
	if not tc or Duel.SpecialSummon(tc,0,tp,tp,false,false,POS_FACEUP)==0 then return end
	local mg=Duel.GetMatchingGroup(Card.IsFaceup,tp,LOCATION_MZONE,0,nil)
	if not mg:IsExists(s.engraver,1,nil,tp,mg)
		or not Duel.SelectYesNo(tp,aux.Stringid(STRING_ID,2)) then return end
	Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_LMATERIAL)
	local mc=Duel.SelectMatchingCard(tp,s.engraver,tp,LOCATION_MZONE,0,1,1,nil,tp,mg):GetFirst()
	if not mc then return end
	Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_SPSUMMON)
	local lc=Duel.SelectMatchingCard(tp,s.lkfilter,tp,LOCATION_EXTRA,0,1,1,nil,mc,mg):GetFirst()
	if lc then Duel.LinkSummon(tp,lc,mg,mc) end
end
function s.setcost(e,tp,eg,ep,ev,re,r,rp,chk)
	local c=e:GetHandler()
	if chk==0 then return c:IsAbleToRemoveAsCost() and s.lockcost(e,tp,eg,ep,ev,re,r,rp,0) end
	s.lockcost(e,tp,eg,ep,ev,re,r,rp,1)
	Duel.Remove(c,POS_FACEUP,REASON_COST)
end
function s.setfilter(c)
	return c:IsSetCard(SET_FIENDSMITH) and c:IsType(TYPE_TRAP) and c:IsSSetable()
		and (not c:IsLocation(LOCATION_REMOVED) or c:IsFaceup())
end
function s.settg(e,tp,eg,ep,ev,re,r,rp,chk)
	if chk==0 then return Duel.GetLocationCount(tp,LOCATION_SZONE)>0
		and Duel.IsExistingMatchingCard(s.setfilter,tp,LOCATION_DECK+LOCATION_REMOVED,0,1,nil) end
end
function s.setop(e,tp)
	if Duel.GetLocationCount(tp,LOCATION_SZONE)<=0 then return end
	Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_SET)
	local g=Duel.SelectMatchingCard(tp,s.setfilter,tp,LOCATION_DECK+LOCATION_REMOVED,0,1,1,nil)
	if #g>0 then Duel.SSet(tp,g) end
end

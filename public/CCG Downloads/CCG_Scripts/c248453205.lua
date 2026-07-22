--Shattering Sustained
local s,id=GetID()
local STRING_ID=132453205
local SET_STAIN=0xbc5
s.listed_series={SET_STAIN}
function s.initial_effect(c)
	Duel.EnableGlobalFlag(GLOBALFLAG_DECK_REVERSE_CHECK)
	--Tribute 1 "Stain" monster, then Special Summon
	local e1=Effect.CreateEffect(c)
	e1:SetDescription(aux.Stringid(STRING_ID,0))
	e1:SetCategory(CATEGORY_SPECIAL_SUMMON)
	e1:SetType(EFFECT_TYPE_ACTIVATE)
	e1:SetCode(EVENT_FREE_CHAIN)
	e1:SetCountLimit(1,id+EFFECT_COUNT_CODE_OATH)
	e1:SetCost(s.spcost)
	e1:SetTarget(s.sptg)
	e1:SetOperation(s.spop)
	c:RegisterEffect(e1)
	--Set this card
	local e2=Effect.CreateEffect(c)
	e2:SetDescription(aux.Stringid(STRING_ID,1))
	e2:SetType(EFFECT_TYPE_FIELD+EFFECT_TYPE_TRIGGER_O)
	e2:SetCode(EVENT_PHASE+PHASE_END)
	e2:SetRange(LOCATION_GRAVE)
	e2:SetCountLimit(1,id+100+EFFECT_COUNT_CODE_OATH)
	e2:SetCondition(s.setcon)
	e2:SetCost(s.setcost)
	e2:SetTarget(s.settg)
	e2:SetOperation(s.setop)
	c:RegisterEffect(e2)
end
function s.faceupoppdeck(c,tp,reason)
	if Duel.SendtoDeck(c,1-tp,SEQ_DECKSHUFFLE,reason)==0 then return false end
	if not c:IsLocation(LOCATION_DECK) then return false end
	Duel.ShuffleDeck(1-tp)
	c:ReverseInDeck()
	return true
end
function s.leaveop(e,tp,eg,ep,ev,re,r,rp)
	local c=e:GetHandler()
	local p=e:GetLabel()
	if c:IsLocation(LOCATION_DECK) and c:IsControler(1-p) then return end
	if c:IsAbleToDeck() then
		s.faceupoppdeck(c,p,REASON_EFFECT)
	end
end
function s.registerleave(c,tp)
	local e1=Effect.CreateEffect(c)
	e1:SetType(EFFECT_TYPE_SINGLE+EFFECT_TYPE_CONTINUOUS)
	e1:SetProperty(EFFECT_FLAG_CANNOT_DISABLE)
	e1:SetCode(EVENT_LEAVE_FIELD)
	e1:SetLabel(tp)
	e1:SetOperation(s.leaveop)
	e1:SetReset(RESET_EVENT+RESETS_STANDARD)
	c:RegisterEffect(e1,true)
end
function s.costfilter(c,tp,needzone)
	if needzone and not (c:IsLocation(LOCATION_MZONE) and c:IsControler(tp)) then return false end
	return c:IsSetCard(SET_STAIN) and c:IsType(TYPE_MONSTER) and (c:IsLocation(LOCATION_HAND) and c:IsAbleToGraveAsCost()
		or c:IsLocation(LOCATION_MZONE) and c:IsFaceup() and c:IsReleasable()
		or c:IsLocation(LOCATION_DECK) and c:IsFaceup() and c:IsAbleToGraveAsCost())
end
function s.spcost(e,tp,eg,ep,ev,re,r,rp,chk)
	local needzone=Duel.GetLocationCount(tp,LOCATION_MZONE)<=0
	local g=Duel.GetMatchingGroup(s.costfilter,tp,LOCATION_HAND+LOCATION_MZONE,LOCATION_DECK,nil,tp,needzone)
	if chk==0 then return #g>0 end
	Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_RELEASE)
	local tc=g:Select(tp,1,1,nil):GetFirst()
	if tc:IsLocation(LOCATION_MZONE) then
		Duel.Release(tc,REASON_COST)
	else
		Duel.SendtoGrave(tc,REASON_COST+REASON_RELEASE)
	end
end
function s.spfilter(c,e,tp)
	return c:IsSetCard(SET_STAIN) and c:IsLevelBelow(4) and c:IsCanBeSpecialSummoned(e,0,tp,false,false)
end
function s.sptg(e,tp,eg,ep,ev,re,r,rp,chk)
	if chk==0 then return (Duel.GetLocationCount(tp,LOCATION_MZONE)>0
			or not e:IsCostChecked() and Duel.IsExistingMatchingCard(Card.IsReleasable,tp,LOCATION_MZONE,0,1,nil))
		and (Duel.IsExistingMatchingCard(s.spfilter,tp,LOCATION_HAND+LOCATION_DECK,0,1,nil,e,tp)
			or Duel.IsExistingMatchingCard(aux.NecroValleyFilter(s.spfilter),tp,LOCATION_GRAVE,0,1,nil,e,tp)) end
	Duel.SetOperationInfo(0,CATEGORY_SPECIAL_SUMMON,nil,1,tp,LOCATION_HAND+LOCATION_DECK+LOCATION_GRAVE)
end
function s.relfilter(c)
	return c:IsFaceup() and c:IsSetCard(SET_STAIN) and c:IsType(TYPE_MONSTER) and c:IsAbleToGrave()
end
function s.spop(e,tp,eg,ep,ev,re,r,rp)
	if Duel.GetLocationCount(tp,LOCATION_MZONE)<=0 then return end
	local g1=Duel.GetMatchingGroup(s.spfilter,tp,LOCATION_HAND+LOCATION_DECK,0,nil,e,tp)
	local g2=Duel.GetMatchingGroup(aux.NecroValleyFilter(s.spfilter),tp,LOCATION_GRAVE,0,nil,e,tp)
	g1:Merge(g2)
	if #g1==0 then return end
	Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_SPSUMMON)
	local sg=g1:Select(tp,1,1,nil)
	local tc=sg:GetFirst()
	if tc and Duel.SpecialSummon(tc,0,tp,tp,false,false,POS_FACEUP)~=0 then
		s.registerleave(tc,tp)
		local rg=Duel.GetMatchingGroup(s.relfilter,tp,0,LOCATION_DECK,nil)
		if #rg>0 and Duel.SelectYesNo(tp,aux.Stringid(STRING_ID,2)) then
			Duel.BreakEffect()
			Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_RELEASE)
			local rel=rg:Select(tp,1,1,nil)
			Duel.SendtoGrave(rel,REASON_EFFECT+REASON_RELEASE)
		end
	end
end
function s.setcon(e,tp,eg,ep,ev,re,r,rp)
	return Duel.GetTurnPlayer()==tp
end
function s.setcfilter(c)
	return c:IsSetCard(SET_STAIN) and c:IsType(TYPE_MONSTER) and c:IsAbleToRemoveAsCost()
		and aux.NecroValleyFilter()(c)
end
function s.setcost(e,tp,eg,ep,ev,re,r,rp,chk)
	if chk==0 then return Duel.IsExistingMatchingCard(s.setcfilter,tp,LOCATION_GRAVE,0,1,nil) end
	Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_REMOVE)
	local g=Duel.SelectMatchingCard(tp,s.setcfilter,tp,LOCATION_GRAVE,0,1,1,nil)
	Duel.Remove(g,POS_FACEUP,REASON_COST)
end
function s.settg(e,tp,eg,ep,ev,re,r,rp,chk)
	local c=e:GetHandler()
	if chk==0 then return c:IsSSetable() and aux.NecroValleyFilter(Card.IsSSetable)(c) end
end
function s.setop(e,tp,eg,ep,ev,re,r,rp)
	local c=e:GetHandler()
	if c:IsRelateToEffect(e) and aux.NecroValleyFilter(Card.IsSSetable)(c) then
		Duel.SSet(tp,c)
	end
end

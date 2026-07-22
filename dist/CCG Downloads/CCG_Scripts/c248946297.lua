--Exploring the Nautical Waters
local s,id=GetID()
local STRING_ID=132946297
local SET_NAUTICA=0x08f0
function s.initial_effect(c)
	if Duel.AddCustomActivityCounter then
		Duel.AddCustomActivityCounter(id,ACTIVITY_SPSUMMON,s.waterfilter)
	end
	--Add 1 "Nautica" monster, then your opponent Special Summons from their hand or Deck
	local e1=Effect.CreateEffect(c)
	e1:SetDescription(aux.Stringid(STRING_ID,0))
	e1:SetCategory(CATEGORY_TOHAND+CATEGORY_SEARCH+CATEGORY_SUMMON+CATEGORY_SPECIAL_SUMMON)
	e1:SetType(EFFECT_TYPE_ACTIVATE)
	e1:SetCode(EVENT_FREE_CHAIN)
	e1:SetCountLimit(1,id+EFFECT_COUNT_CODE_OATH)
	e1:SetCost(s.cost)
	e1:SetTarget(s.thtg)
	e1:SetOperation(s.thop)
	c:RegisterEffect(e1)
end
s.listed_series={SET_NAUTICA}
function s.waterfilter(c)
	return c:IsAttribute(ATTRIBUTE_WATER)
end
function s.splockcheck(tp)
	return Duel.GetCustomActivityCount(id,tp,ACTIVITY_SPSUMMON)==0
end
function s.splimit(e,c)
	return not c:IsAttribute(ATTRIBUTE_WATER)
end
function s.waterlock(e,tp)
	local e1=Effect.CreateEffect(e:GetHandler())
	e1:SetType(EFFECT_TYPE_FIELD)
	e1:SetProperty(EFFECT_FLAG_PLAYER_TARGET+EFFECT_FLAG_OATH)
	e1:SetCode(EFFECT_CANNOT_SPECIAL_SUMMON)
	e1:SetTargetRange(1,0)
	e1:SetTarget(s.splimit)
	e1:SetReset(RESET_PHASE+PHASE_END)
	Duel.RegisterEffect(e1,tp)
end
function s.cost(e,tp,eg,ep,ev,re,r,rp,chk)
	if chk==0 then return s.splockcheck(tp) end
	s.waterlock(e,tp)
end
function s.thfilter(c)
	return c:IsSetCard(SET_NAUTICA) and c:IsType(TYPE_MONSTER) and c:IsAbleToHand()
end
function s.oppfilter(c,e,p)
	return c:IsType(TYPE_MONSTER) and c:IsCanBeSpecialSummoned(e,0,p,false,false,POS_FACEUP_ATTACK,p)
end
function s.oppnsfilter(c)
	return c:IsType(TYPE_MONSTER) and c:IsSummonable(true,nil)
end
function s.canoppsummon(e,tp)
	local p=1-tp
	return (Duel.GetLocationCount(p,LOCATION_MZONE)>0 and Duel.IsPlayerCanSpecialSummon(p)
			and Duel.IsExistingMatchingCard(s.oppfilter,p,LOCATION_HAND+LOCATION_DECK,0,1,nil,e,p))
		or (Duel.IsPlayerCanSummon(p)
			and Duel.IsExistingMatchingCard(s.oppnsfilter,p,LOCATION_HAND,0,1,nil))
end
function s.atkzero(e,c)
	local e1=Effect.CreateEffect(e:GetHandler())
	e1:SetType(EFFECT_TYPE_SINGLE)
	e1:SetCode(EFFECT_SET_ATTACK_FINAL)
	e1:SetValue(0)
	e1:SetReset(RESET_EVENT+RESETS_STANDARD)
	c:RegisterEffect(e1)
end
function s.negate(e,c)
	if not (c and c:IsFaceup() and c:IsLocation(LOCATION_MZONE)) then return end
	Duel.NegateRelatedChain(c,RESET_TURN_SET)
	local e1=Effect.CreateEffect(e:GetHandler())
	e1:SetType(EFFECT_TYPE_SINGLE)
	e1:SetCode(EFFECT_DISABLE)
	e1:SetReset(RESET_EVENT+RESETS_STANDARD)
	c:RegisterEffect(e1)
	local e2=e1:Clone()
	e2:SetCode(EFFECT_DISABLE_EFFECT)
	e2:SetValue(RESET_TURN_SET)
	c:RegisterEffect(e2)
end
function s.oppsummon(e,tp)
	local p=1-tp
	if not s.canoppsummon(e,tp) then return false,nil,false end
	local cansp=Duel.GetLocationCount(p,LOCATION_MZONE)>0 and Duel.IsPlayerCanSpecialSummon(p)
		and Duel.IsExistingMatchingCard(s.oppfilter,p,LOCATION_HAND+LOCATION_DECK,0,1,nil,e,p)
	local canns=Duel.IsPlayerCanSummon(p)
		and Duel.IsExistingMatchingCard(s.oppnsfilter,p,LOCATION_HAND,0,1,nil)
	local tc=nil
	local fromdeck=false
	if cansp then
		Duel.Hint(HINT_SELECTMSG,p,HINTMSG_SPSUMMON)
		tc=Duel.SelectMatchingCard(p,s.oppfilter,p,LOCATION_HAND+LOCATION_DECK,0,1,1,nil,e,p):GetFirst()
		if not tc then return false,nil,false end
		fromdeck=tc:IsLocation(LOCATION_DECK)
		if not (Duel.SpecialSummon(tc,0,p,p,false,false,POS_FACEUP_ATTACK)>0) then
			tc=nil
		end
	elseif canns then
		Duel.Hint(HINT_SELECTMSG,p,HINTMSG_SUMMON)
		tc=Duel.SelectMatchingCard(p,s.oppnsfilter,p,LOCATION_HAND,0,1,1,nil):GetFirst()
		if tc then
			Duel.Summon(p,tc,true,nil)
		end
	end
	if tc and tc:IsFaceup() and tc:IsLocation(LOCATION_MZONE) then
		s.atkzero(e,tc)
		return true,tc,fromdeck
	end
	return false,nil,false
end
function s.thtg(e,tp,eg,ep,ev,re,r,rp,chk)
	if chk==0 then return Duel.IsExistingMatchingCard(s.thfilter,tp,LOCATION_DECK,0,1,nil)
		and s.canoppsummon(e,tp) end
	Duel.SetOperationInfo(0,CATEGORY_TOHAND,nil,1,tp,LOCATION_DECK)
	Duel.SetOperationInfo(0,CATEGORY_SUMMON,nil,1,1-tp,LOCATION_HAND)
	Duel.SetOperationInfo(0,CATEGORY_SPECIAL_SUMMON,nil,1,1-tp,LOCATION_HAND+LOCATION_DECK)
end
function s.thop(e,tp,eg,ep,ev,re,r,rp)
	if not Duel.IsExistingMatchingCard(s.thfilter,tp,LOCATION_DECK,0,1,nil) then return end
	Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_ATOHAND)
	local g=Duel.SelectMatchingCard(tp,s.thfilter,tp,LOCATION_DECK,0,1,1,nil)
	if #g==0 or Duel.SendtoHand(g,nil,REASON_EFFECT)==0 then return end
	Duel.ConfirmCards(1-tp,g)
	Duel.BreakEffect()
	local ok,tc,fromdeck=s.oppsummon(e,tp)
	if ok and fromdeck then
		s.negate(e,tc)
	end
end

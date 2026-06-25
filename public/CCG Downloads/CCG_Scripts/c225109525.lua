--Evander Coldwater & the Nautical Abyss
local s,id=GetID()
local SET_NAUTICA=0x08f0
function s.initial_effect(c)
	aux.AddXyzProcedure(c,aux.FilterBoolFunction(Card.IsRace,RACE_AQUA),1,2,nil,nil,99)
	c:EnableReviveLimit()
	--Gains 500 ATK for each "Nautica" material
	local e1=Effect.CreateEffect(c)
	e1:SetType(EFFECT_TYPE_SINGLE)
	e1:SetCode(EFFECT_UPDATE_ATTACK)
	e1:SetProperty(EFFECT_FLAG_SINGLE_RANGE)
	e1:SetRange(LOCATION_MZONE)
	e1:SetValue(s.atkval)
	c:RegisterEffect(e1)
	--Detach 1 material; return 1 opponent's monster to the hand
	local e2=Effect.CreateEffect(c)
	e2:SetDescription(aux.Stringid(id,0))
	e2:SetCategory(CATEGORY_TOHAND+CATEGORY_SPECIAL_SUMMON)
	e2:SetType(EFFECT_TYPE_QUICK_O)
	e2:SetCode(EVENT_FREE_CHAIN)
	e2:SetProperty(EFFECT_FLAG_CARD_TARGET)
	e2:SetRange(LOCATION_MZONE)
	e2:SetCountLimit(1)
	e2:SetHintTiming(0,TIMINGS_CHECK_MONSTER+TIMING_END_PHASE)
	e2:SetCost(s.rtcost)
	e2:SetTarget(s.rttg)
	e2:SetOperation(s.rtop)
	c:RegisterEffect(e2)
end
s.listed_series={SET_NAUTICA}
function s.atkval(e,c)
	return c:GetOverlayGroup():FilterCount(Card.IsSetCard,nil,SET_NAUTICA)*500
end
function s.oppfilter(c,e,p)
	return c:IsType(TYPE_MONSTER) and c:IsCanBeSpecialSummoned(e,0,p,false,false,POS_FACEUP_ATTACK,p)
end
function s.canoppsummon(e,tp)
	local p=1-tp
	return Duel.GetLocationCount(p,LOCATION_MZONE)>0 and Duel.IsPlayerCanSpecialSummon(p)
		and Duel.IsExistingMatchingCard(s.oppfilter,p,LOCATION_HAND,0,1,nil,e,p)
end
function s.atkzero(e,c)
	local e1=Effect.CreateEffect(e:GetHandler())
	e1:SetType(EFFECT_TYPE_SINGLE)
	e1:SetCode(EFFECT_SET_ATTACK_FINAL)
	e1:SetValue(0)
	e1:SetReset(RESET_EVENT+RESETS_STANDARD)
	c:RegisterEffect(e1)
end
function s.oppsummon(e,tp)
	local p=1-tp
	if not s.canoppsummon(e,tp) then return end
	Duel.Hint(HINT_SELECTMSG,p,HINTMSG_SPSUMMON)
	local tc=Duel.SelectMatchingCard(p,s.oppfilter,p,LOCATION_HAND,0,1,1,nil,e,p):GetFirst()
	if tc and Duel.SpecialSummon(tc,0,p,p,false,false,POS_FACEUP_ATTACK)>0 then
		s.atkzero(e,tc)
	end
end
function s.rtcost(e,tp,eg,ep,ev,re,r,rp,chk)
	local c=e:GetHandler()
	if chk==0 then return c:CheckRemoveOverlayCard(tp,1,REASON_COST) end
	c:RemoveOverlayCard(tp,1,1,REASON_COST)
end
function s.rtfilter(c)
	return c:IsAbleToHand()
end
function s.rttg(e,tp,eg,ep,ev,re,r,rp,chk,chkc)
	if chkc then return chkc:IsLocation(LOCATION_MZONE) and chkc:IsControler(1-tp) and s.rtfilter(chkc) end
	if chk==0 then return Duel.IsExistingTarget(s.rtfilter,tp,0,LOCATION_MZONE,1,nil)
		and s.canoppsummon(e,tp) end
	Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_RTOHAND)
	local g=Duel.SelectTarget(tp,s.rtfilter,tp,0,LOCATION_MZONE,1,1,nil)
	Duel.SetOperationInfo(0,CATEGORY_TOHAND,g,1,0,0)
	Duel.SetOperationInfo(0,CATEGORY_SPECIAL_SUMMON,nil,1,1-tp,LOCATION_HAND)
end
function s.rtop(e,tp,eg,ep,ev,re,r,rp)
	local tc=Duel.GetFirstTarget()
	if not (tc and tc:IsRelateToEffect(e) and s.rtfilter(tc)) then return end
	if Duel.SendtoHand(tc,nil,REASON_EFFECT)>0 then
		Duel.BreakEffect()
		s.oppsummon(e,tp)
	end
end

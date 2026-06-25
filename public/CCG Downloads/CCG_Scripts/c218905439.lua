--Nautical Adventures & Torrential Seas
local s,id=GetID()
local SET_NAUTICA=0x08f0
function s.initial_effect(c)
	--Return 1 "Nautica" monster you control and 1 opponent's monster to the hand
	local e1=Effect.CreateEffect(c)
	e1:SetDescription(aux.Stringid(id,0))
	e1:SetCategory(CATEGORY_TOHAND+CATEGORY_SPECIAL_SUMMON)
	e1:SetType(EFFECT_TYPE_ACTIVATE)
	e1:SetCode(EVENT_FREE_CHAIN)
	e1:SetProperty(EFFECT_FLAG_CARD_TARGET)
	e1:SetHintTiming(0,TIMINGS_CHECK_MONSTER+TIMING_END_PHASE)
	e1:SetCountLimit(1,id+EFFECT_COUNT_CODE_OATH)
	e1:SetTarget(s.rttg)
	e1:SetOperation(s.rtop)
	c:RegisterEffect(e1)
	--Attach this card to a WATER Xyz Monster
	local e2=Effect.CreateEffect(c)
	e2:SetDescription(aux.Stringid(id,1))
	e2:SetType(EFFECT_TYPE_FIELD+EFFECT_TYPE_TRIGGER_O)
	e2:SetCode(EVENT_SPSUMMON_SUCCESS)
	e2:SetProperty(EFFECT_FLAG_DELAY+EFFECT_FLAG_CARD_TARGET)
	e2:SetRange(LOCATION_GRAVE)
	e2:SetCountLimit(1,id+100+EFFECT_COUNT_CODE_OATH)
	e2:SetCondition(s.matcon)
	e2:SetTarget(s.mattg)
	e2:SetOperation(s.matop)
	c:RegisterEffect(e2)
end
s.listed_series={SET_NAUTICA}
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
function s.rtfilter1(c)
	return c:IsSetCard(SET_NAUTICA) and c:IsType(TYPE_MONSTER) and c:IsAbleToHand()
end
function s.rtfilter2(c)
	return c:IsAbleToHand()
end
function s.rttg(e,tp,eg,ep,ev,re,r,rp,chk,chkc)
	if chkc then return false end
	if chk==0 then return Duel.IsExistingTarget(s.rtfilter1,tp,LOCATION_MZONE,0,1,nil)
		and Duel.IsExistingTarget(s.rtfilter2,tp,0,LOCATION_MZONE,1,nil)
		and Duel.GetLocationCount(1-tp,LOCATION_MZONE)>0 and Duel.IsPlayerCanSpecialSummon(1-tp) end
	Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_RTOHAND)
	local g1=Duel.SelectTarget(tp,s.rtfilter1,tp,LOCATION_MZONE,0,1,1,nil)
	Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_RTOHAND)
	local g2=Duel.SelectTarget(tp,s.rtfilter2,tp,0,LOCATION_MZONE,1,1,nil)
	g1:Merge(g2)
	Duel.SetOperationInfo(0,CATEGORY_TOHAND,g1,2,0,0)
	Duel.SetOperationInfo(0,CATEGORY_SPECIAL_SUMMON,nil,1,1-tp,LOCATION_HAND)
end
function s.rtop(e,tp,eg,ep,ev,re,r,rp)
	local g=Duel.GetTargetCards(e):Filter(Card.IsRelateToEffect,nil,e)
	if #g~=2 then return end
	if Duel.SendtoHand(g,nil,REASON_EFFECT)==2 then
		Duel.BreakEffect()
		s.oppsummon(e,tp)
	end
end
function s.matfilter(c,tp)
	return c:IsFaceup() and c:IsControler(tp) and c:IsAttribute(ATTRIBUTE_WATER)
		and c:IsType(TYPE_XYZ) and c:IsSummonType(SUMMON_TYPE_XYZ)
end
function s.matcon(e,tp,eg,ep,ev,re,r,rp)
	return eg:IsExists(s.matfilter,1,nil,tp)
end
function s.mattg(e,tp,eg,ep,ev,re,r,rp,chk,chkc)
	if chkc then return chkc:IsLocation(LOCATION_MZONE) and s.matfilter(chkc,tp) end
	local c=e:GetHandler()
	if chk==0 then return c:IsCanOverlay() and aux.NecroValleyFilter()(c)
		and eg:IsExists(s.matfilter,1,nil,tp) end
	Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_TARGET)
	local g=eg:Filter(s.matfilter,nil,tp)
	local tg=g:Select(tp,1,1,nil)
	Duel.SetTargetCard(tg)
end
function s.matop(e,tp,eg,ep,ev,re,r,rp)
	local c=e:GetHandler()
	local tc=Duel.GetFirstTarget()
	if not (c:IsRelateToEffect(e) and aux.NecroValleyFilter()(c) and c:IsCanOverlay()
		and tc and tc:IsRelateToEffect(e) and tc:IsFaceup() and not tc:IsImmuneToEffect(e)) then return end
	Duel.Overlay(tc,Group.FromCards(c))
	local e1=Effect.CreateEffect(tc)
	e1:SetType(EFFECT_TYPE_SINGLE)
	e1:SetCode(EFFECT_TO_GRAVE_REDIRECT)
	e1:SetProperty(EFFECT_FLAG_CANNOT_DISABLE)
	e1:SetValue(LOCATION_REMOVED)
	e1:SetReset(RESET_EVENT+RESETS_REDIRECT)
	c:RegisterEffect(e1,true)
end

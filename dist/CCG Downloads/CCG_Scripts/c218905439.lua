--Nautical Adventures & Torrential Seas
local s,id=GetID()
local STRING_ID=132905439
local SET_NAUTICA=0x08f0
function s.initial_effect(c)
	--Return 1 "Nautica" monster you control and 1 opponent's monster to the hand
	local e1=Effect.CreateEffect(c)
	e1:SetDescription(aux.Stringid(STRING_ID,0))
	e1:SetCategory(CATEGORY_TOHAND+CATEGORY_SUMMON+CATEGORY_SPECIAL_SUMMON)
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
	e2:SetDescription(aux.Stringid(STRING_ID,1))
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
function s.oppnsfilter(c)
	return c:IsType(TYPE_MONSTER) and c:IsSummonable(true,nil)
end
function s.canoppsummon(e,tp,rg)
	local p=1-tp
	local ft=rg and Duel.GetMZoneCount(p,rg,tp) or Duel.GetLocationCount(p,LOCATION_MZONE)
	return (ft>0 and Duel.IsPlayerCanSpecialSummon(p)
			and Duel.IsExistingMatchingCard(s.oppfilter,p,LOCATION_HAND,0,1,nil,e,p))
		or (ft>0 and Duel.IsPlayerCanSummon(p)
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
function s.oppsummon(e,tp)
	local p=1-tp
	if not s.canoppsummon(e,tp) then return end
	local cansp=Duel.GetLocationCount(p,LOCATION_MZONE)>0 and Duel.IsPlayerCanSpecialSummon(p)
		and Duel.IsExistingMatchingCard(s.oppfilter,p,LOCATION_HAND,0,1,nil,e,p)
	local canns=Duel.IsPlayerCanSummon(p)
		and Duel.IsExistingMatchingCard(s.oppnsfilter,p,LOCATION_HAND,0,1,nil)
	local tc=nil
	if cansp then
		Duel.Hint(HINT_SELECTMSG,p,HINTMSG_SPSUMMON)
		tc=Duel.SelectMatchingCard(p,s.oppfilter,p,LOCATION_HAND,0,1,1,nil,e,p):GetFirst()
		if not (tc and Duel.SpecialSummon(tc,0,p,p,false,false,POS_FACEUP_ATTACK)>0) then
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
	end
end
function s.rtfilter1(c)
	return c:IsSetCard(SET_NAUTICA) and c:IsType(TYPE_MONSTER) and c:IsAbleToHand()
end
function s.rtfilter2(c,e,tp)
	return c:IsAbleToHand() and s.canoppsummon(e,tp,Group.FromCards(c))
end
function s.rttg(e,tp,eg,ep,ev,re,r,rp,chk,chkc)
	if chkc then return false end
	if chk==0 then return Duel.IsExistingTarget(s.rtfilter1,tp,LOCATION_MZONE,0,1,nil)
		and Duel.IsExistingTarget(s.rtfilter2,tp,0,LOCATION_MZONE,1,nil,e,tp) end
	Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_RTOHAND)
	local g1=Duel.SelectTarget(tp,s.rtfilter1,tp,LOCATION_MZONE,0,1,1,nil)
	Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_RTOHAND)
	local g2=Duel.SelectTarget(tp,s.rtfilter2,tp,0,LOCATION_MZONE,1,1,nil,e,tp)
	g1:Merge(g2)
	Duel.SetOperationInfo(0,CATEGORY_TOHAND,g1,2,0,0)
	Duel.SetOperationInfo(0,CATEGORY_SUMMON,nil,1,1-tp,LOCATION_HAND)
	Duel.SetOperationInfo(0,CATEGORY_SPECIAL_SUMMON,nil,1,1-tp,LOCATION_HAND)
end
function s.rtop(e,tp,eg,ep,ev,re,r,rp)
	local g=Duel.GetChainInfo(0,CHAININFO_TARGET_CARDS):Filter(Card.IsRelateToEffect,nil,e)
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
function s.rmtg(e,c)
	return c==e:GetLabelObject() and c:GetOverlayTarget()==e:GetHandler()
end
function s.matop(e,tp,eg,ep,ev,re,r,rp)
	local c=e:GetHandler()
	local tc=Duel.GetFirstTarget()
	if not (c:IsRelateToEffect(e) and aux.NecroValleyFilter()(c) and c:IsCanOverlay()
		and tc and tc:IsRelateToEffect(e) and tc:IsFaceup() and not tc:IsImmuneToEffect(e)) then return end
	Duel.Overlay(tc,Group.FromCards(c))
	local e1=Effect.CreateEffect(tc)
	e1:SetType(EFFECT_TYPE_FIELD)
	e1:SetCode(EFFECT_TO_GRAVE_REDIRECT)
	e1:SetProperty(EFFECT_FLAG_IGNORE_IMMUNE)
	e1:SetRange(LOCATION_MZONE)
	e1:SetTargetRange(LOCATION_OVERLAY,LOCATION_OVERLAY)
	e1:SetTarget(s.rmtg)
	e1:SetValue(LOCATION_REMOVED)
	e1:SetLabelObject(c)
	e1:SetReset(RESET_EVENT+RESETS_STANDARD)
	tc:RegisterEffect(e1,true)
end

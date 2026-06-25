--TO PROTO EISODOS
local s,id=GetID()
local SET_TO_PROTO=0xe80d
local TOKEN_PROTOGENIC=240299293
local RACE_GALAXY=0x80000000
function s.initial_effect(c)
	c:EnableReviveLimit()
	--Link Summon
	aux.AddLinkProcedure(c,aux.FilterBoolFunction(Card.IsType,TYPE_EFFECT),2,2,s.lcheck)
	--If banished from the field: Special Summon 2 "Protogenic Essence Tokens"
	local e1=Effect.CreateEffect(c)
	e1:SetDescription(aux.Stringid(id,0))
	e1:SetCategory(CATEGORY_SPECIAL_SUMMON+CATEGORY_TOKEN)
	e1:SetType(EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_O)
	e1:SetCode(EVENT_REMOVE)
	e1:SetProperty(EFFECT_FLAG_DELAY)
	e1:SetCountLimit(1,id)
	e1:SetCondition(s.tkcon)
	e1:SetTarget(s.tktg)
	e1:SetOperation(s.tkop)
	c:RegisterEffect(e1)
	--During your opponent's turn: banish a monster you control and 1 "To Proto" monster from your Deck
	local e2=Effect.CreateEffect(c)
	e2:SetDescription(aux.Stringid(id,1))
	e2:SetCategory(CATEGORY_REMOVE+CATEGORY_SPECIAL_SUMMON+CATEGORY_TODECK)
	e2:SetType(EFFECT_TYPE_QUICK_O)
	e2:SetCode(EVENT_FREE_CHAIN)
	e2:SetRange(LOCATION_REMOVED)
	e2:SetProperty(EFFECT_FLAG_CARD_TARGET)
	e2:SetHintTiming(0,TIMINGS_CHECK_MONSTER+TIMING_MAIN_END)
	e2:SetCountLimit(1,id+100)
	e2:SetCondition(s.rmcon)
	e2:SetTarget(s.rmtg)
	e2:SetOperation(s.rmop)
	c:RegisterEffect(e2)
end
s.listed_series={SET_TO_PROTO}
s.listed_names={TOKEN_PROTOGENIC}
function s.lcheck(g,lc,sumtype,tp)
	return g:GetClassCount(Card.GetCode)==#g
end
function s.tkcon(e,tp,eg,ep,ev,re,r,rp)
	return e:GetHandler():IsFaceup() and e:GetHandler():IsPreviousControler(tp)
		and e:GetHandler():IsPreviousLocation(LOCATION_ONFIELD)
end
function s.tktg(e,tp,eg,ep,ev,re,r,rp,chk)
	if chk==0 then return Duel.GetLocationCount(tp,LOCATION_MZONE)>=2
		and Duel.IsPlayerCanSpecialSummonCount(tp,2)
		and Duel.IsPlayerCanSpecialSummonMonster(tp,TOKEN_PROTOGENIC,SET_TO_PROTO,TYPES_TOKEN_MONSTER,0,0,1,RACE_GALAXY,ATTRIBUTE_LIGHT) end
	Duel.SetOperationInfo(0,CATEGORY_TOKEN,nil,2,0,0)
	Duel.SetOperationInfo(0,CATEGORY_SPECIAL_SUMMON,nil,2,tp,0)
end
function s.tkop(e,tp,eg,ep,ev,re,r,rp)
	local c=e:GetHandler()
	if not (c:IsRelateToEffect(e) and c:IsFaceup()) then return end
	if Duel.GetLocationCount(tp,LOCATION_MZONE)<2 or not Duel.IsPlayerCanSpecialSummonCount(tp,2) then return end
	if not Duel.IsPlayerCanSpecialSummonMonster(tp,TOKEN_PROTOGENIC,SET_TO_PROTO,TYPES_TOKEN_MONSTER,0,0,1,RACE_GALAXY,ATTRIBUTE_LIGHT) then return end
	local token1=Duel.CreateToken(tp,TOKEN_PROTOGENIC)
	local token2=Duel.CreateToken(tp,TOKEN_PROTOGENIC)
	Duel.SpecialSummonStep(token1,0,tp,tp,false,false,POS_FACEUP)
	Duel.SpecialSummonStep(token2,0,tp,tp,false,false,POS_FACEUP)
	Duel.SpecialSummonComplete()
end
function s.rmcon(e,tp,eg,ep,ev,re,r,rp)
	return Duel.IsTurnPlayer(1-tp) and e:GetHandler():IsFaceup()
end
function s.tgfilter(c)
	return c:IsFaceup() and c:IsType(TYPE_EFFECT) and c:IsAbleToRemove()
end
function s.dkfilter(c)
	return c:IsSetCard(SET_TO_PROTO) and c:IsType(TYPE_MONSTER) and c:IsAbleToRemove()
end
function s.rmtg(e,tp,eg,ep,ev,re,r,rp,chk,chkc)
	local c=e:GetHandler()
	if chkc then return chkc:IsControler(tp) and chkc:IsLocation(LOCATION_MZONE) and s.tgfilter(chkc) end
	if chk==0 then return c:IsFaceup() and (c:IsCanBeSpecialSummoned(e,0,tp,false,false) or c:IsAbleToExtra())
		and Duel.IsExistingTarget(s.tgfilter,tp,LOCATION_MZONE,0,1,nil)
		and Duel.IsExistingMatchingCard(s.dkfilter,tp,LOCATION_DECK,0,1,nil) end
	Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_REMOVE)
	local g=Duel.SelectTarget(tp,s.tgfilter,tp,LOCATION_MZONE,0,1,1,nil)
	Duel.SetOperationInfo(0,CATEGORY_REMOVE,g,1,0,0)
	Duel.SetOperationInfo(0,CATEGORY_REMOVE,nil,1,tp,LOCATION_DECK)
	Duel.SetOperationInfo(0,CATEGORY_SPECIAL_SUMMON,c,1,tp,LOCATION_REMOVED)
	Duel.SetOperationInfo(0,CATEGORY_TODECK,c,1,tp,LOCATION_REMOVED)
end
function s.rmop(e,tp,eg,ep,ev,re,r,rp)
	local c=e:GetHandler()
	local tc=Duel.GetFirstTarget()
	if not (c:IsRelateToEffect(e) and c:IsFaceup() and tc and tc:IsRelateToEffect(e) and s.tgfilter(tc)) then return end
	if not Duel.IsExistingMatchingCard(s.dkfilter,tp,LOCATION_DECK,0,1,nil) then return end
	Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_REMOVE)
	local dg=Duel.SelectMatchingCard(tp,s.dkfilter,tp,LOCATION_DECK,0,1,1,nil)
	local rg=Group.FromCards(tc)
	rg:Merge(dg)
	if Duel.Remove(rg,POS_FACEUP,REASON_EFFECT)<2 then return end
	if not (c:IsRelateToEffect(e) and c:IsLocation(LOCATION_REMOVED) and c:IsFaceup()) then return end
	local b1=Duel.GetLocationCount(tp,LOCATION_MZONE)>0 and c:IsCanBeSpecialSummoned(e,0,tp,false,false)
	local b2=c:IsAbleToExtra()
	if not (b1 or b2) then return end
	local op=0
	if b1 and b2 then
		op=Duel.SelectOption(tp,aux.Stringid(id,2),aux.Stringid(id,3))
	elseif b2 then
		op=1
	end
	if op==0 then
		Duel.SpecialSummon(c,0,tp,tp,false,false,POS_FACEUP)
	else
		Duel.SendtoDeck(c,nil,SEQ_DECKSHUFFLE,REASON_EFFECT)
	end
end

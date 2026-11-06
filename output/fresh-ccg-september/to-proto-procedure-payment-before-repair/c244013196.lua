--TO PROTO CHRONO
local s,id=GetID()
local STRING_ID=132013196
local SET_TO_PROTO=0xe80d
local TOKEN_PROTOGENIC=240299293
function s.initial_effect(c)
	c:EnableReviveLimit()
	--Must first be Special Summoned by its own procedure
	local e0=Effect.CreateEffect(c)
	e0:SetType(EFFECT_TYPE_SINGLE)
	e0:SetProperty(EFFECT_FLAG_CANNOT_DISABLE+EFFECT_FLAG_UNCOPYABLE)
	e0:SetCode(EFFECT_SPSUMMON_CONDITION)
	c:RegisterEffect(e0)
	--Cannot be Normal Summoned/Set
	local e1=Effect.CreateEffect(c)
	e1:SetType(EFFECT_TYPE_SINGLE)
	e1:SetCode(EFFECT_CANNOT_SUMMON)
	c:RegisterEffect(e1)
	local e2=e1:Clone()
	e2:SetCode(EFFECT_CANNOT_MSET)
	c:RegisterEffect(e2)
	--Must first be Special Summoned from the hand by banishing 1 "To Proto" monster you control
	local e3=Effect.CreateEffect(c)
	e3:SetDescription(aux.Stringid(STRING_ID,0))
	e3:SetType(EFFECT_TYPE_FIELD)
	e3:SetCode(EFFECT_SPSUMMON_PROC)
	e3:SetProperty(EFFECT_FLAG_UNCOPYABLE)
	e3:SetRange(LOCATION_HAND)
	e3:SetCondition(s.spcon)
	e3:SetTarget(s.sptg)
	e3:SetOperation(s.spop)
	e3:SetValue(SUMMON_VALUE_SELF)
	c:RegisterEffect(e3)
	--Tribute a Token; negate a monster, gain its stats, and advance turn counters
	local e4=Effect.CreateEffect(c)
	e4:SetDescription(aux.Stringid(STRING_ID,1))
	e4:SetCategory(CATEGORY_DISABLE+CATEGORY_ATKCHANGE+CATEGORY_DEFCHANGE)
	e4:SetType(EFFECT_TYPE_QUICK_O)
	e4:SetCode(EVENT_FREE_CHAIN)
	e4:SetRange(LOCATION_MZONE)
	e4:SetProperty(EFFECT_FLAG_CARD_TARGET)
	e4:SetHintTiming(0,TIMINGS_CHECK_MONSTER+TIMING_MAIN_END)
	e4:SetCountLimit(1,id)
	e4:SetCondition(function() return Duel.IsMainPhase() end)
	e4:SetCost(s.negcost)
	e4:SetTarget(s.negtg)
	e4:SetOperation(s.negop)
	c:RegisterEffect(e4)
	--If banished from the field: recover a differently named "To Proto" monster
	local e5=Effect.CreateEffect(c)
	e5:SetDescription(aux.Stringid(STRING_ID,2))
	e5:SetCategory(CATEGORY_TOHAND)
	e5:SetType(EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_O)
	e5:SetCode(EVENT_REMOVE)
	e5:SetProperty(EFFECT_FLAG_DELAY+EFFECT_FLAG_CARD_TARGET)
	e5:SetCountLimit(1,id+100)
	e5:SetCondition(s.thcon)
	e5:SetTarget(s.thtg)
	e5:SetOperation(s.thop)
	c:RegisterEffect(e5)
end
s.listed_series={SET_TO_PROTO}
s.listed_names={TOKEN_PROTOGENIC}
function s.spfilter(c,tp)
	return c:IsFaceup() and c:IsSetCard(SET_TO_PROTO) and c:IsType(TYPE_MONSTER)
		and c:IsAbleToRemoveAsCost() and Duel.GetMZoneCount(tp,c)>0
end
function s.spcon(e,c)
	if c==nil then return true end
	local tp=c:GetControler()
	return Duel.IsExistingMatchingCard(s.spfilter,tp,LOCATION_MZONE,0,1,c,tp)
end
function s.sptg(e,tp,eg,ep,ev,re,r,rp,chk,c)
	Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_REMOVE)
	local g=Duel.SelectMatchingCard(tp,s.spfilter,tp,LOCATION_MZONE,0,1,1,c,tp)
	if #g>0 then
		g:KeepAlive()
		e:SetLabelObject(g)
		return true
	end
	return false
end
function s.spop(e,tp,eg,ep,ev,re,r,rp,c)
	local g=e:GetLabelObject()
	if not g then return end
	Duel.Remove(g,POS_FACEUP,REASON_COST)
	g:DeleteGroup()
end
function s.tkfilter(c)
	return c:IsCode(TOKEN_PROTOGENIC) and c:IsReleasable()
end
function s.negcost(e,tp,eg,ep,ev,re,r,rp,chk)
	if chk==0 then return Duel.CheckReleaseGroup(tp,s.tkfilter,1,nil) end
	Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_RELEASE)
	local g=Duel.SelectReleaseGroup(tp,s.tkfilter,1,1,nil)
	Duel.Release(g,REASON_COST)
end
function s.negfilter(c,e)
	return c:IsFaceup() and c:IsType(TYPE_MONSTER) and c:IsCanBeEffectTarget(e)
end
function s.negtg(e,tp,eg,ep,ev,re,r,rp,chk,chkc)
	if chkc then return chkc:IsLocation(LOCATION_MZONE) and s.negfilter(chkc,e) end
	if chk==0 then return Duel.IsExistingTarget(s.negfilter,tp,LOCATION_MZONE,LOCATION_MZONE,1,nil,e) end
	Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_NEGATE)
	Duel.SelectTarget(tp,s.negfilter,tp,LOCATION_MZONE,LOCATION_MZONE,1,1,nil,e)
end
function s.counterfilter(c)
	return c:GetTurnCounter()>0
end
function s.negop(e,tp,eg,ep,ev,re,r,rp)
	local c=e:GetHandler()
	local tc=Duel.GetFirstTarget()
	if not (c:IsRelateToEffect(e) and tc and tc:IsRelateToEffect(e) and tc:IsFaceup()) then return end
	local atk=math.max(0,tc:GetAttack())
	local def=math.max(0,tc:GetDefense())
	local e1=Effect.CreateEffect(c)
	e1:SetType(EFFECT_TYPE_SINGLE)
	e1:SetCode(EFFECT_DISABLE)
	e1:SetReset(RESET_EVENT+RESETS_STANDARD)
	tc:RegisterEffect(e1)
	local e2=e1:Clone()
	e2:SetCode(EFFECT_DISABLE_EFFECT)
	e2:SetValue(RESET_TURN_SET)
	tc:RegisterEffect(e2)
	local e3=Effect.CreateEffect(c)
	e3:SetType(EFFECT_TYPE_SINGLE)
	e3:SetCode(EFFECT_UPDATE_ATTACK)
	e3:SetValue(atk)
	e3:SetReset(RESET_EVENT+RESETS_STANDARD)
	c:RegisterEffect(e3)
	local e4=e3:Clone()
	e4:SetCode(EFFECT_UPDATE_DEFENSE)
	e4:SetValue(def)
	c:RegisterEffect(e4)
	local locations=LOCATION_HAND+LOCATION_DECK+LOCATION_EXTRA+LOCATION_MZONE+LOCATION_SZONE+LOCATION_GRAVE+LOCATION_REMOVED
	local g=Duel.GetMatchingGroup(s.counterfilter,tp,locations,locations,nil)
	for cc in aux.Next(g) do cc:SetTurnCounter(cc:GetTurnCounter()+1) end
end
function s.thcon(e)
	return e:GetHandler():IsPreviousLocation(LOCATION_ONFIELD)
end
function s.thfilter(c)
	return c:IsFaceup() and c:IsSetCard(SET_TO_PROTO) and c:IsType(TYPE_MONSTER)
		and not c:IsCode(id) and c:IsAbleToHand()
end
function s.thtg(e,tp,eg,ep,ev,re,r,rp,chk,chkc)
	if chkc then return chkc:IsLocation(LOCATION_REMOVED) and s.thfilter(chkc) end
	if chk==0 then return Duel.IsExistingTarget(s.thfilter,tp,LOCATION_REMOVED,0,1,nil) end
	Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_ATOHAND)
	local g=Duel.SelectTarget(tp,s.thfilter,tp,LOCATION_REMOVED,0,1,1,nil)
	Duel.SetOperationInfo(0,CATEGORY_TOHAND,g,1,0,0)
end
function s.thop(e,tp,eg,ep,ev,re,r,rp)
	local tc=Duel.GetFirstTarget()
	if tc and tc:IsRelateToEffect(e) and Duel.SendtoHand(tc,nil,REASON_EFFECT)>0 then
		Duel.ConfirmCards(1-tp,tc)
	end
end

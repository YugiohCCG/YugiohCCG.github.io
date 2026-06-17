--Wyvernal Megalopyge
local s,id=GetID()
local SET_WYVERNAL=0x4714
function s.initial_effect(c)
	--Fusion Summon procedure
	aux.AddFusionProcFunRep(c,s.matfilter,3,true)
	c:EnableReviveLimit()
	--Cannot be destroyed by card effects
	local e1=Effect.CreateEffect(c)
	e1:SetType(EFFECT_TYPE_SINGLE)
	e1:SetCode(EFFECT_INDESTRUCTABLE_EFFECT)
	e1:SetValue(1)
	c:RegisterEffect(e1)
	--Cannot be targeted by the opponent's card effects
	local e2=e1:Clone()
	e2:SetCode(EFFECT_CANNOT_BE_EFFECT_TARGET)
	e2:SetValue(aux.tgoval)
	c:RegisterEffect(e2)
	--If Fusion Summoned: add 1 "Wyvernal" card, then maybe destroy 1 other card
	local e3=Effect.CreateEffect(c)
	e3:SetDescription(aux.Stringid(id,0))
	e3:SetCategory(CATEGORY_TOHAND+CATEGORY_DESTROY)
	e3:SetType(EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_O)
	e3:SetCode(EVENT_SPSUMMON_SUCCESS)
	e3:SetProperty(EFFECT_FLAG_DELAY)
	e3:SetCountLimit(1,id)
	e3:SetCondition(s.thcon)
	e3:SetTarget(s.thtg)
	e3:SetOperation(s.thop)
	c:RegisterEffect(e3)
	--Main Phase Quick Effect: destroy 1 WIND Insect, then all opponent monsters
	local e4=Effect.CreateEffect(c)
	e4:SetDescription(aux.Stringid(id,1))
	e4:SetCategory(CATEGORY_DESTROY)
	e4:SetType(EFFECT_TYPE_QUICK_O)
	e4:SetCode(EVENT_FREE_CHAIN)
	e4:SetRange(LOCATION_MZONE)
	e4:SetHintTiming(0,TIMINGS_CHECK_MONSTER+TIMING_MAIN_END)
	e4:SetCountLimit(1,id+100)
	e4:SetCondition(s.descon)
	e4:SetTarget(s.destg)
	e4:SetOperation(s.desop)
	c:RegisterEffect(e4)
end
s.listed_series={SET_WYVERNAL}
function s.matfilter(c)
	return c:IsFusionAttribute(ATTRIBUTE_WIND) and c:IsRace(RACE_INSECT)
end
function s.thcon(e,tp,eg,ep,ev,re,r,rp)
	return e:GetHandler():IsSummonType(SUMMON_TYPE_FUSION)
end
function s.thfilter(c)
	return c:IsFaceupEx() and c:IsSetCard(SET_WYVERNAL) and c:IsAbleToHand()
end
function s.thtg(e,tp,eg,ep,ev,re,r,rp,chk)
	if chk==0 then return Duel.GetFlagEffect(tp,id)==0
		and Duel.IsExistingMatchingCard(aux.NecroValleyFilter(s.thfilter),tp,LOCATION_GRAVE+LOCATION_REMOVED,0,1,nil) end
	Duel.RegisterFlagEffect(tp,id,RESET_CHAIN,EFFECT_FLAG_OATH,1)
	Duel.SetOperationInfo(0,CATEGORY_TOHAND,nil,1,tp,LOCATION_GRAVE+LOCATION_REMOVED)
end
function s.desfilter(c,sc)
	return c~=sc and c:IsOnField() and c:IsDestructable()
end
function s.thop(e,tp,eg,ep,ev,re,r,rp)
	Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_ATOHAND)
	local g=Duel.SelectMatchingCard(tp,aux.NecroValleyFilter(s.thfilter),tp,LOCATION_GRAVE+LOCATION_REMOVED,0,1,1,nil)
	if #g==0 or Duel.SendtoHand(g,nil,REASON_EFFECT)==0 then return end
	Duel.ConfirmCards(1-tp,g)
	local c=e:GetHandler()
	if not Duel.IsExistingMatchingCard(s.desfilter,tp,LOCATION_ONFIELD,LOCATION_ONFIELD,1,nil,c) then return end
	if not Duel.SelectYesNo(tp,aux.Stringid(id,0)) then return end
	Duel.BreakEffect()
	Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_DESTROY)
	local dg=Duel.SelectMatchingCard(tp,s.desfilter,tp,LOCATION_ONFIELD,LOCATION_ONFIELD,1,1,nil,c)
	if #dg>0 then Duel.Destroy(dg,REASON_EFFECT) end
end
function s.descon(e,tp,eg,ep,ev,re,r,rp)
	return Duel.IsMainPhase()
end
function s.selffilter(c)
	return c:IsFaceup() and c:IsAttribute(ATTRIBUTE_WIND) and c:IsRace(RACE_INSECT)
		and c:IsType(TYPE_MONSTER) and c:IsDestructable()
end
function s.destg(e,tp,eg,ep,ev,re,r,rp,chk)
	if chk==0 then return Duel.GetFlagEffect(tp,id)==0
		and Duel.IsExistingMatchingCard(s.selffilter,tp,LOCATION_MZONE,0,1,nil) end
	Duel.RegisterFlagEffect(tp,id,RESET_CHAIN,EFFECT_FLAG_OATH,1)
	Duel.SetOperationInfo(0,CATEGORY_DESTROY,nil,1,tp,LOCATION_MZONE)
	local g=Duel.GetMatchingGroup(Card.IsDestructable,tp,0,LOCATION_MZONE,nil)
	Duel.SetOperationInfo(0,CATEGORY_DESTROY,g,#g,1-tp,LOCATION_MZONE)
end
function s.desop(e,tp,eg,ep,ev,re,r,rp)
	Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_DESTROY)
	local g=Duel.SelectMatchingCard(tp,s.selffilter,tp,LOCATION_MZONE,0,1,1,nil)
	if #g==0 or Duel.Destroy(g,REASON_EFFECT)==0 then return end
	Duel.BreakEffect()
	local og=Duel.GetMatchingGroup(Card.IsDestructable,tp,0,LOCATION_MZONE,nil)
	if #og>0 then Duel.Destroy(og,REASON_EFFECT) end
end

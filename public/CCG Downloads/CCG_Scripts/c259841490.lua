-- Coulomb, the Ohmechanic Charger
local s,id=GetID()
local COUNTER_CURRENT = 0x18f0
local SET_OHMEN = 0x8de0
function s.initial_effect(c)
	-- Link Summon
	c:EnableReviveLimit()
	aux.AddLinkProcedure(c,nil,2,2,s.lcheck)
	-- ATK 0 without counters
	local e1=Effect.CreateEffect(c)
	e1:SetType(EFFECT_TYPE_SINGLE)
	e1:SetProperty(EFFECT_FLAG_SINGLE_RANGE)
	e1:SetRange(LOCATION_MZONE)
	e1:SetCode(EFFECT_SET_ATTACK)
	e1:SetCondition(s.atkcon)
	e1:SetValue(0)
	c:RegisterEffect(e1)
	-- Move monster (1+ counters)
	local e2=Effect.CreateEffect(c)
	e2:SetDescription(aux.Stringid(id,0))
	e2:SetType(EFFECT_TYPE_IGNITION)
	e2:SetRange(LOCATION_MZONE)
	e2:SetCountLimit(1,id)
	e2:SetCondition(s.effcon1)
	e2:SetTarget(s.efftg1)
	e2:SetOperation(s.effop1)
	c:RegisterEffect(e2)
	-- Search Spell/Trap (2+ counters)
	local e3=Effect.CreateEffect(c)
	e3:SetDescription(aux.Stringid(id,1))
	e3:SetCategory(CATEGORY_TOHAND+CATEGORY_SEARCH)
	e3:SetType(EFFECT_TYPE_IGNITION)
	e3:SetRange(LOCATION_MZONE)
	e3:SetCountLimit(1,id+100)
	e3:SetCondition(s.effcon2)
	e3:SetTarget(s.efftg2)
	e3:SetOperation(s.effop2)
	c:RegisterEffect(e3)
	-- Link Summon (3+ counters)
	local e4=Effect.CreateEffect(c)
	e4:SetDescription(aux.Stringid(id,2))
	e4:SetCategory(CATEGORY_SPECIAL_SUMMON)
	e4:SetType(EFFECT_TYPE_QUICK_O)
	e4:SetCode(EVENT_FREE_CHAIN)
	e4:SetRange(LOCATION_MZONE)
	e4:SetCountLimit(1,id+200)
	e4:SetCondition(s.effcon3)
	e4:SetCost(s.effcost3)
	e4:SetTarget(s.efftg3)
	e4:SetOperation(s.effop3)
	c:RegisterEffect(e4)
end
s.listed_series={SET_OHMEN}

function s.lcheck(g,lc,sumtype,tp)
	return g:IsExists(Card.IsSetCard,1,nil,SET_OHMEN,lc,sumtype,tp) and g:FilterCount(Card.IsRace,nil,RACE_THUNDER)==#g
end

function s.atkcon(e)
	return e:GetHandler():GetCounter(COUNTER_CURRENT) == 0
end

function s.effcon1(e,tp,eg,ep,ev,re,r,rp)
	return e:GetHandler():GetCounter(COUNTER_CURRENT) >= 1 and Duel.IsMainPhase()
end
function s.movefilter(tc,tp)
	if not tc:IsFaceup() or not tc:IsType(TYPE_LINK) or not tc:IsControler(tp) then return false end
	return Duel.IsExistingMatchingCard(nil,tp,LOCATION_MZONE,0,1,tc) or Duel.GetLocationCount(tp,LOCATION_MZONE) > 0
end
function s.efftg1(e,tp,eg,ep,ev,re,r,rp,chk,chkc)
	if chkc then return chkc:IsLocation(LOCATION_MZONE) and s.movefilter(chkc,tp) end
	if chk==0 then return Duel.IsExistingTarget(s.movefilter,tp,LOCATION_MZONE,0,1,nil,tp) end
	Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_TARGET)
	Duel.SelectTarget(tp,s.movefilter,tp,LOCATION_MZONE,0,1,1,nil,tp)
end
function s.effop1(e,tp,eg,ep,ev,re,r,rp)
	local tc=Duel.GetFirstTarget()
	if not tc or not tc:IsRelateToEffect(e) or tc:IsControler(1-tp) then return end
	local free_zones = 0
	for i=0,4 do
		if Duel.CheckLocation(tp,LOCATION_MZONE,i) then
			free_zones = bit.bor(free_zones, bit.lshift(1, i))
		end
	end
	if free_zones == 0 then return end
	local disable_mask = bit.bxor(free_zones, 0xff)
	Duel.Hint(HINT_SELECTMSG, tp, HINTMSG_TOZONE)
	local s_field = Duel.SelectDisableField(tp, 1, LOCATION_MZONE, 0, disable_mask)
	local nseq = 0
	if s_field == 1 then nseq = 0
	elseif s_field == 2 then nseq = 1
	elseif s_field == 4 then nseq = 2
	elseif s_field == 8 then nseq = 3
	else nseq = 4 end
	if Duel.MoveSequence(tc, nseq) then
		tc:AddCounter(COUNTER_CURRENT, 1)
	end
end

function s.effcon2(e,tp,eg,ep,ev,re,r,rp)
	return e:GetHandler():GetCounter(COUNTER_CURRENT) >= 2 and Duel.IsMainPhase()
end
function s.thfilter(tc)
	return tc:IsSetCard(SET_OHMEN) and tc:IsType(TYPE_SPELL+TYPE_TRAP) and tc:IsAbleToHand()
end
function s.efftg2(e,tp,eg,ep,ev,re,r,rp,chk)
	if chk==0 then return Duel.IsExistingMatchingCard(s.thfilter,tp,LOCATION_DECK,0,1,nil) end
	Duel.SetOperationInfo(0,CATEGORY_TOHAND,nil,1,tp,LOCATION_DECK)
end
function s.effop2(e,tp,eg,ep,ev,re,r,rp)
	Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_ATOHAND)
	local g=Duel.SelectMatchingCard(tp,s.thfilter,tp,LOCATION_DECK,0,1,1,nil)
	if #g>0 then
		Duel.SendtoHand(g,nil,REASON_EFFECT)
		Duel.ConfirmCards(1-tp,g)
	end
end

function s.effcon3(e,tp,eg,ep,ev,re,r,rp)
	return e:GetHandler():GetCounter(COUNTER_CURRENT) >= 3 and Duel.IsMainPhase()
end
function s.effcost3(e,tp,eg,ep,ev,re,r,rp,chk)
	local c=e:GetHandler()
	if chk==0 then return c:GetCounter(COUNTER_CURRENT) > 0 end
	c:RemoveCounter(tp,COUNTER_CURRENT,c:GetCounter(COUNTER_CURRENT),REASON_COST)
end
function s.lkfilter(tc,e,tp)
	return tc:IsSetCard(SET_OHMEN) and tc:IsType(TYPE_LINK) and tc:IsLinkSummonable(nil)
end
function s.efftg3(e,tp,eg,ep,ev,re,r,rp,chk)
	if chk==0 then return Duel.IsExistingMatchingCard(s.lkfilter,tp,LOCATION_EXTRA,0,1,nil) end
	Duel.SetOperationInfo(0,CATEGORY_SPECIAL_SUMMON,nil,1,tp,LOCATION_EXTRA)
end
function s.effop3(e,tp,eg,ep,ev,re,r,rp)
	Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_SPSUMMON)
	local g=Duel.SelectMatchingCard(tp,s.lkfilter,tp,LOCATION_EXTRA,0,1,1,nil)
	local tc=g:GetFirst()
	if tc then
		Duel.LinkSummon(tp,tc,nil)
	end
end

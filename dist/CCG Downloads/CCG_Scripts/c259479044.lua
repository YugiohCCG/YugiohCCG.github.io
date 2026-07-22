-- Ampere, the Ohmechanic Intensity
local s,id=GetID()
local STRING_ID=133479044
local COUNTER_CURRENT = 0x18f0
local SET_OHMEN = 0x8de0
local SET_OHMECHANIC = 0x8de1
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
	-- Search and discard (1+ counters)
	local e2=Effect.CreateEffect(c)
	e2:SetDescription(aux.Stringid(STRING_ID,0))
	e2:SetCategory(CATEGORY_TOHAND+CATEGORY_SEARCH+CATEGORY_HANDES)
	e2:SetType(EFFECT_TYPE_IGNITION)
	e2:SetRange(LOCATION_MZONE)
	e2:SetCountLimit(1,id)
	e2:SetCondition(s.effcon1)
	e2:SetTarget(s.efftg1)
	e2:SetOperation(s.effop1)
	c:RegisterEffect(e2)
	-- Place counter on co-linked (2+ counters)
	local e3=Effect.CreateEffect(c)
	e3:SetDescription(aux.Stringid(STRING_ID,1))
	e3:SetType(EFFECT_TYPE_IGNITION)
	e3:SetRange(LOCATION_MZONE)
	e3:SetCountLimit(1,id+100)
	e3:SetCondition(s.effcon2)
	e3:SetTarget(s.efftg2)
	e3:SetOperation(s.effop2)
	c:RegisterEffect(e3)
	-- Protection (3+ counters)
	local e4=Effect.CreateEffect(c)
	e4:SetType(EFFECT_TYPE_FIELD)
	e4:SetCode(EFFECT_INDESTRUCTABLE_BATTLE)
	e4:SetRange(LOCATION_MZONE)
	e4:SetTargetRange(LOCATION_MZONE,0)
	e4:SetCondition(s.effcon3)
	e4:SetTarget(s.indtg)
	e4:SetValue(1)
	c:RegisterEffect(e4)
	local e5=e4:Clone()
	e5:SetCode(EFFECT_INDESTRUCTABLE_EFFECT)
	c:RegisterEffect(e5)
end
s.listed_series={SET_OHMEN, SET_OHMECHANIC}

function s.lcheck(g,lc,sumtype,tp)
	return g:IsExists(Card.IsSetCard,1,nil,SET_OHMEN,lc,sumtype,tp) and g:FilterCount(Card.IsRace,nil,RACE_THUNDER)==#g
end

function s.atkcon(e)
	return e:GetHandler():GetCounter(COUNTER_CURRENT) == 0
end

function s.effcon1(e,tp,eg,ep,ev,re,r,rp)
	return e:GetHandler():GetCounter(COUNTER_CURRENT) >= 1 and Duel.IsMainPhase()
end
function s.thfilter(tc)
	return tc:IsSetCard(SET_OHMEN) and tc:IsType(TYPE_MONSTER) and tc:IsAbleToHand()
end
function s.efftg1(e,tp,eg,ep,ev,re,r,rp,chk)
	if chk==0 then return Duel.IsExistingMatchingCard(s.thfilter,tp,LOCATION_DECK,0,1,nil) end
	Duel.SetOperationInfo(0,CATEGORY_TOHAND,nil,1,tp,LOCATION_DECK)
	Duel.SetOperationInfo(0,CATEGORY_HANDES,nil,0,tp,1)
end
function s.effop1(e,tp,eg,ep,ev,re,r,rp)
	Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_ATOHAND)
	local g=Duel.SelectMatchingCard(tp,s.thfilter,tp,LOCATION_DECK,0,1,1,nil)
	if #g>0 and Duel.SendtoHand(g,nil,REASON_EFFECT)>0 then
		Duel.ConfirmCards(1-tp,g)
		Duel.ShuffleHand(tp)
		Duel.BreakEffect()
		Duel.DiscardHand(tp,nil,1,1,REASON_EFFECT+REASON_DISCARD)
	end
end

function s.effcon2(e,tp,eg,ep,ev,re,r,rp)
	return e:GetHandler():GetCounter(COUNTER_CURRENT) >= 2 and Duel.IsMainPhase()
end
function s.efftg2(e,tp,eg,ep,ev,re,r,rp,chk)
	local c=e:GetHandler()
	if chk==0 then return c:GetMutualLinkedGroupCount() > 0 end
end
function s.effop2(e,tp,eg,ep,ev,re,r,rp)
	local c=e:GetHandler()
	local g=c:GetMutualLinkedGroup()
	for tc in aux.Next(g) do
		tc:AddCounter(COUNTER_CURRENT,1)
	end
end

function s.effcon3(e)
	return e:GetHandler():GetCounter(COUNTER_CURRENT) >= 3
end
function s.indtg(e,tc)
	local c=e:GetHandler()
	return tc:IsSetCard(SET_OHMECHANIC) and c:GetMutualLinkedGroup():IsContains(tc)
end

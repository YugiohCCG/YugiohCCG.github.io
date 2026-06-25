-- Farad, the Ohmechanic Capacitor
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
	-- Banish card (1+ counters)
	local e2=Effect.CreateEffect(c)
	e2:SetDescription(aux.Stringid(id,0))
	e2:SetCategory(CATEGORY_REMOVE)
	e2:SetType(EFFECT_TYPE_IGNITION)
	e2:SetRange(LOCATION_MZONE)
	e2:SetCountLimit(1,id)
	e2:SetCondition(s.effcon1)
	e2:SetTarget(s.efftg1)
	e2:SetOperation(s.effop1)
	c:RegisterEffect(e2)
	-- Recycle GY/banished (2+ counters)
	local e3=Effect.CreateEffect(c)
	e3:SetDescription(aux.Stringid(id,1))
	e3:SetCategory(CATEGORY_TOHAND)
	e3:SetType(EFFECT_TYPE_IGNITION)
	e3:SetRange(LOCATION_MZONE)
	e3:SetCountLimit(1,id+100)
	e3:SetCondition(s.effcon2)
	e3:SetTarget(s.efftg2)
	e3:SetOperation(s.effop2)
	c:RegisterEffect(e3)
	-- Banish opponent GY (3+ counters)
	local e4=Effect.CreateEffect(c)
	e4:SetDescription(aux.Stringid(id,2))
	e4:SetCategory(CATEGORY_REMOVE)
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
	return g:IsExists(Card.IsRace,1,nil,RACE_THUNDER,lc,sumtype,tp)
end

function s.atkcon(e)
	return e:GetHandler():GetCounter(COUNTER_CURRENT) == 0
end

function s.effcon1(e,tp,eg,ep,ev,re,r,rp)
	return e:GetHandler():GetCounter(COUNTER_CURRENT) >= 1 and Duel.IsMainPhase()
end
function s.efftg1(e,tp,eg,ep,ev,re,r,rp,chk,chkc)
	if chkc then return chkc:IsOnField() and chkc:IsControler(1-tp) and chkc:IsAbleToRemove() end
	if chk==0 then return Duel.IsExistingTarget(Card.IsAbleToRemove,tp,0,LOCATION_ONFIELD,1,nil) end
	Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_REMOVE)
	local g=Duel.SelectTarget(tp,Card.IsAbleToRemove,tp,0,LOCATION_ONFIELD,1,1,nil)
	Duel.SetOperationInfo(0,CATEGORY_REMOVE,g,1,0,0)
end
function s.effop1(e,tp,eg,ep,ev,re,r,rp)
	local tc=Duel.GetFirstTarget()
	if tc and tc:IsRelateToEffect(e) then
		Duel.Remove(tc,POS_FACEUP,REASON_EFFECT)
	end
end

function s.effcon2(e,tp,eg,ep,ev,re,r,rp)
	return e:GetHandler():GetCounter(COUNTER_CURRENT) >= 2 and Duel.IsMainPhase()
end
function s.thfilter(tc)
	return tc:IsSetCard(SET_OHMEN) and tc:IsFaceupEx() and tc:IsAbleToHand()
end
function s.efftg2(e,tp,eg,ep,ev,re,r,rp,chk,chkc)
	if chkc then return chkc:IsLocation(LOCATION_GRAVE+LOCATION_REMOVED) and chkc:IsControler(tp) and s.thfilter(chkc) end
	if chk==0 then return Duel.IsExistingTarget(s.thfilter,tp,LOCATION_GRAVE+LOCATION_REMOVED,0,1,nil) end
	Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_ATOHAND)
	local g=Duel.SelectTarget(tp,s.thfilter,tp,LOCATION_GRAVE+LOCATION_REMOVED,0,1,1,nil)
	Duel.SetOperationInfo(0,CATEGORY_TOHAND,g,1,0,0)
end
function s.effop2(e,tp,eg,ep,ev,re,r,rp)
	local tc=Duel.GetFirstTarget()
	if tc and tc:IsRelateToEffect(e) then
		Duel.SendtoHand(tc,nil,REASON_EFFECT)
		Duel.ConfirmCards(1-tp,tc)
	end
end

function s.effcon3(e,tp,eg,ep,ev,re,r,rp)
	return e:GetHandler():GetCounter(COUNTER_CURRENT) >= 3
end
function s.effcost3(e,tp,eg,ep,ev,re,r,rp,chk)
	local c=e:GetHandler()
	local g=c:GetMutualLinkedGroup()
	g:AddCard(c)
	if chk==0 then return c:GetCounter(COUNTER_CURRENT) > 0 end
	for tc in aux.Next(g) do
		local ct=tc:GetCounter(COUNTER_CURRENT)
		if ct > 0 then
			tc:RemoveCounter(tp,COUNTER_CURRENT,ct,REASON_COST)
		end
	end
end
function s.efftg3(e,tp,eg,ep,ev,re,r,rp,chk)
	if chk==0 then return Duel.IsExistingMatchingCard(Card.IsAbleToRemove,tp,0,LOCATION_GRAVE,1,nil) end
	Duel.SetOperationInfo(0,CATEGORY_REMOVE,nil,1,1-tp,LOCATION_GRAVE)
end
function s.effop3(e,tp,eg,ep,ev,re,r,rp)
	Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_REMOVE)
	local g=Duel.SelectMatchingCard(tp,Card.IsAbleToRemove,tp,0,LOCATION_GRAVE,1,3,nil)
	if #g>0 then
		Duel.Remove(g,POS_FACEUP,REASON_EFFECT)
	end
end

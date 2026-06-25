-- Volt, the Ohmechanic Chocker
local s,id=GetID()
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
	-- Inflict damage (1+ counters)
	local e2=Effect.CreateEffect(c)
	e2:SetDescription(aux.Stringid(id,0))
	e2:SetCategory(CATEGORY_DAMAGE)
	e2:SetType(EFFECT_TYPE_IGNITION)
	e2:SetRange(LOCATION_MZONE)
	e2:SetCountLimit(1,id)
	e2:SetCondition(s.effcon1)
	e2:SetTarget(s.efftg1)
	e2:SetOperation(s.effop1)
	c:RegisterEffect(e2)
	-- ATK Boost (2+ counters)
	local e3=Effect.CreateEffect(c)
	e3:SetType(EFFECT_TYPE_FIELD)
	e3:SetCode(EFFECT_UPDATE_ATTACK)
	e3:SetRange(LOCATION_MZONE)
	e3:SetTargetRange(LOCATION_MZONE,0)
	e3:SetCondition(s.effcon2)
	e3:SetTarget(aux.TargetBoolFunction(Card.IsSetCard,SET_OHMECHANIC))
	e3:SetValue(500)
	c:RegisterEffect(e3)
	-- Destroy monster (3+ counters)
	local e4=Effect.CreateEffect(c)
	e4:SetDescription(aux.Stringid(id,1))
	e4:SetCategory(CATEGORY_DESTROY)
	e4:SetType(EFFECT_TYPE_QUICK_O)
	e4:SetCode(EVENT_FREE_CHAIN)
	e4:SetRange(LOCATION_MZONE)
	e4:SetCountLimit(1,id+200)
	e4:SetCondition(s.effcon3)
	e4:SetTarget(s.efftg3)
	e4:SetOperation(s.effop3)
	c:RegisterEffect(e4)
end
s.listed_series={SET_OHMEN, SET_OHMECHANIC}

function s.lcheck(g,lc,sumtype,tp)
	return g:IsExists(Card.IsSetCard,1,nil,SET_OHMEN,lc,sumtype,tp)
end

function s.atkcon(e)
	return e:GetHandler():GetCounter(COUNTER_CURRENT) == 0
end

function s.effcon1(e,tp,eg,ep,ev,re,r,rp)
	return e:GetHandler():GetCounter(COUNTER_CURRENT) >= 1 and Duel.IsMainPhase()
end
function s.efftg1(e,tp,eg,ep,ev,re,r,rp,chk)
	if chk==0 then return e:GetHandler():GetCounter(COUNTER_CURRENT) > 0 end
	local ct=e:GetHandler():GetCounter(COUNTER_CURRENT)
	Duel.SetOperationInfo(0,CATEGORY_DAMAGE,nil,0,1-tp,ct*300)
end
function s.effop1(e,tp,eg,ep,ev,re,r,rp)
	local c=e:GetHandler()
	if c:IsFaceup() and c:IsRelateToEffect(e) then
		local ct=c:GetCounter(COUNTER_CURRENT)
		if ct > 0 and c:RemoveCounter(tp,COUNTER_CURRENT,ct,REASON_EFFECT) then
			Duel.Damage(1-tp,ct*300,REASON_EFFECT)
		end
	end
end

function s.effcon2(e)
	return e:GetHandler():GetCounter(COUNTER_CURRENT) >= 2
end

function s.effcon3(e,tp,eg,ep,ev,re,r,rp)
	return e:GetHandler():GetCounter(COUNTER_CURRENT) >= 3 and Duel.IsMainPhase()
end
function s.efftg3(e,tp,eg,ep,ev,re,r,rp,chk,chkc)
	if chkc then return chkc:IsLocation(LOCATION_MZONE) and chkc:IsControler(1-tp) end
	if chk==0 then return Duel.IsExistingTarget(nil,tp,0,LOCATION_MZONE,1,nil) end
	Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_DESTROY)
	local g=Duel.SelectTarget(tp,nil,tp,0,LOCATION_MZONE,1,1,nil)
	Duel.SetOperationInfo(0,CATEGORY_DESTROY,g,1,0,0)
end
function s.effop3(e,tp,eg,ep,ev,re,r,rp)
	local tc=Duel.GetFirstTarget()
	if tc and tc:IsRelateToEffect(e) then
		Duel.Destroy(tc,REASON_EFFECT)
	end
end

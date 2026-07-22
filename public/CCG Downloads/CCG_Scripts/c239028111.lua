local s,id=GetID()
local STRING_ID=133028111
local COUNTER_PUMPKIN=0x2f
local PUMPRINCESS=17601919
function s.initial_effect(c)
	c:EnableCounterPermit(COUNTER_PUMPKIN)
	local e1=Effect.CreateEffect(c)
	e1:SetDescription(aux.Stringid(STRING_ID,0))
	e1:SetCategory(CATEGORY_COUNTER)
	e1:SetType(EFFECT_TYPE_IGNITION)
	e1:SetRange(LOCATION_MZONE)
	e1:SetCountLimit(1)
	e1:SetCondition(s.ctcon)
	e1:SetTarget(s.cttg)
	e1:SetOperation(s.ctop)
	c:RegisterEffect(e1)
	local e2=Effect.CreateEffect(c)
	e2:SetDescription(aux.Stringid(STRING_ID,1))
	e2:SetCategory(CATEGORY_COUNTER)
	e2:SetType(EFFECT_TYPE_FIELD+EFFECT_TYPE_TRIGGER_F)
	e2:SetCode(EVENT_PHASE+PHASE_STANDBY)
	e2:SetRange(LOCATION_MZONE)
	e2:SetCountLimit(1)
	e2:SetTarget(s.sttg)
	e2:SetOperation(s.stop)
	c:RegisterEffect(e2)
	local e3=Effect.CreateEffect(c)
	e3:SetType(EFFECT_TYPE_FIELD)
	e3:SetCode(EFFECT_UPDATE_ATTACK)
	e3:SetRange(LOCATION_MZONE)
	e3:SetTargetRange(0,LOCATION_MZONE)
	e3:SetValue(s.atkval)
	c:RegisterEffect(e3)
	local e4=e3:Clone()
	e4:SetCode(EFFECT_UPDATE_DEFENSE)
	c:RegisterEffect(e4)
end
function s.ctcon(e,tp)
	return Duel.IsExistingMatchingCard(function(c) return c:IsFaceup() and c:IsCode(PUMPRINCESS) end,tp,LOCATION_ONFIELD,0,1,nil)
end
function s.cttg(e,tp,eg,ep,ev,re,r,rp,chk)
	if chk==0 then return e:GetHandler():IsCanAddCounter(COUNTER_PUMPKIN,3) end
	Duel.SetOperationInfo(0,CATEGORY_COUNTER,e:GetHandler(),3,0,COUNTER_PUMPKIN)
end
function s.ctop(e,tp,eg,ep,ev,re,r,rp)
	local c=e:GetHandler()
	if c:IsRelateToEffect(e) then c:AddCounter(COUNTER_PUMPKIN,3) end
end
function s.sttg(e,tp,eg,ep,ev,re,r,rp,chk)
	if chk==0 then return e:GetHandler():IsCanAddCounter(COUNTER_PUMPKIN,1) end
	Duel.SetOperationInfo(0,CATEGORY_COUNTER,e:GetHandler(),1,0,COUNTER_PUMPKIN)
end
function s.stop(e,tp,eg,ep,ev,re,r,rp)
	local c=e:GetHandler()
	if c:IsRelateToEffect(e) then c:AddCounter(COUNTER_PUMPKIN,1) end
end
function s.atkval()
	return -Duel.GetCounter(0,1,1,COUNTER_PUMPKIN)*100
end

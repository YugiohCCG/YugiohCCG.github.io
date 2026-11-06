--Rigel the Thousand-Armed
local s,id=GetID()
local STRING_ID=133853847
function s.initial_effect(c)
	c:EnableReviveLimit()
	aux.AddLinkProcedure(c,aux.FilterBoolFunction(Card.IsLinkType,TYPE_EFFECT),2)
	--Cannot be destroyed by battle
	local e1=Effect.CreateEffect(c)
	e1:SetType(EFFECT_TYPE_SINGLE)
	e1:SetCode(EFFECT_INDESTRUCTABLE_BATTLE)
	e1:SetValue(1)
	c:RegisterEffect(e1)
	--Cannot be destroyed by card effects
	local e2=e1:Clone()
	e2:SetCode(EFFECT_INDESTRUCTABLE_EFFECT)
	c:RegisterEffect(e2)
	--Your opponent takes no battle damage from battles involving this card
	local e3=Effect.CreateEffect(c)
	e3:SetType(EFFECT_TYPE_SINGLE)
	e3:SetCode(EFFECT_NO_BATTLE_DAMAGE)
	c:RegisterEffect(e3)
	--If this card battles, neither player can activate cards or effects
	local e4=Effect.CreateEffect(c)
	e4:SetType(EFFECT_TYPE_FIELD)
	e4:SetProperty(EFFECT_FLAG_PLAYER_TARGET)
	e4:SetCode(EFFECT_CANNOT_ACTIVATE)
	e4:SetRange(LOCATION_MZONE)
	e4:SetTargetRange(1,1)
	e4:SetCondition(s.actcon)
	e4:SetValue(s.aclimit)
	c:RegisterEffect(e4)
	--Gain ATK and attack all monsters
	local e5=Effect.CreateEffect(c)
	e5:SetDescription(aux.Stringid(STRING_ID,0))
	e5:SetCategory(CATEGORY_ATKCHANGE)
	e5:SetType(EFFECT_TYPE_IGNITION)
	e5:SetRange(LOCATION_MZONE)
	e5:SetCountLimit(1,id)
	e5:SetTarget(s.atktg)
	e5:SetOperation(s.atkop)
	c:RegisterEffect(e5)
end
function s.actcon(e)
	local c=e:GetHandler()
	return Duel.GetAttacker()==c or Duel.GetAttackTarget()==c
end
function s.aclimit(e,re,tp)
	return true
end
function s.linksum(c)
	if c:IsType(TYPE_LINK) then return c:GetLink() end
	return 1
end
function s.atktg(e,tp,eg,ep,ev,re,r,rp,chk)
	if chk==0 then return e:GetHandler():IsFaceup() end
end
function s.atkop(e,tp,eg,ep,ev,re,r,rp)
	local c=e:GetHandler()
	if not (c:IsRelateToEffect(e) and c:IsFaceup()) then return end
	local val=c:GetMaterial():GetSum(s.linksum)*1000
	local e1=Effect.CreateEffect(c)
	e1:SetType(EFFECT_TYPE_SINGLE)
	e1:SetCode(EFFECT_UPDATE_ATTACK)
	e1:SetValue(val)
	e1:SetReset(RESET_EVENT+RESETS_STANDARD+RESET_PHASE+PHASE_END)
	c:RegisterEffect(e1)
	local e2=Effect.CreateEffect(c)
	e2:SetType(EFFECT_TYPE_SINGLE)
	e2:SetCode(EFFECT_ATTACK_ALL)
	e2:SetValue(1)
	e2:SetReset(RESET_EVENT+RESETS_STANDARD+RESET_PHASE+PHASE_END)
	c:RegisterEffect(e2)
	local e3=Effect.CreateEffect(c)
	e3:SetType(EFFECT_TYPE_FIELD)
	e3:SetCode(EFFECT_CANNOT_ATTACK)
	e3:SetTargetRange(LOCATION_MZONE,0)
	e3:SetLabelObject(c)
	e3:SetTarget(s.atklimit)
	e3:SetReset(RESET_PHASE+PHASE_END)
	Duel.RegisterEffect(e3,tp)
end
function s.atklimit(e,c)
	return c~=e:GetLabelObject()
end

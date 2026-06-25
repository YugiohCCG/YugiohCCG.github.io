--Aquamarine Reef Hapalochlaena
local s,id=GetID()
local SET_AQUAMARINE=0xf3c
function s.initial_effect(c)
	--Fusion Material
	c:EnableReviveLimit()
	aux.AddFusionProcMixN(c,true,true,function(c) return c:IsSetCard(SET_AQUAMARINE) and c:IsType(TYPE_FUSION) and c:IsLevelAbove(7) end,2)
	--Must be Fusion Summoned
	local e1=Effect.CreateEffect(c)
	e1:SetType(EFFECT_TYPE_SINGLE)
	e1:SetProperty(EFFECT_FLAG_CANNOT_DISABLE+EFFECT_FLAG_UNCOPYABLE)
	e1:SetCode(EFFECT_SPSUMMON_CONDITION)
	e1:SetValue(aux.fuslimit)
	c:RegisterEffect(e1)
	--Unaffected by other card effects
	local e2=Effect.CreateEffect(c)
	e2:SetType(EFFECT_TYPE_SINGLE)
	e2:SetCode(EFFECT_IMMUNE_EFFECT)
	e2:SetProperty(EFFECT_FLAG_SINGLE_RANGE)
	e2:SetRange(LOCATION_MZONE)
	e2:SetCondition(s.uncon)
	e2:SetValue(s.efilter)
	c:RegisterEffect(e2)
	--Burn damage Quick Effect
	local e3=Effect.CreateEffect(c)
	e3:SetDescription(aux.Stringid(id,0))
	e3:SetCategory(CATEGORY_DAMAGE)
	e3:SetType(EFFECT_TYPE_QUICK_O)
	e3:SetCode(EVENT_FREE_CHAIN)
	e3:SetRange(LOCATION_MZONE)
	e3:SetHintTiming(0,TIMINGS_CHECK_MONSTER+TIMING_END_PHASE)
	e3:SetCondition(s.dmgcon)
	e3:SetCost(s.dmgcost)
	e3:SetTarget(s.dmgtg)
	e3:SetOperation(s.dmgop)
	c:RegisterEffect(e3)
end
s.listed_series={SET_AQUAMARINE}

function s.uncon(e)
	local tp=e:GetHandlerPlayer()
	return Duel.IsExistingMatchingCard(Card.IsCode,tp,LOCATION_GRAVE,0,1,nil,225161820) -- Glaucus
		or Duel.IsExistingMatchingCard(Card.IsCode,tp,LOCATION_GRAVE,0,1,nil,249746105) -- Physalia
end
function s.efilter(e,te)
	return te:GetOwner()~=e:GetOwner()
end
function s.dmgcon(e,tp,eg,ep,ev,re,r,rp)
	return Duel.IsMainPhase()
end
function s.filter8plus(c,code)
	return c:IsFaceup() and c:IsSetCard(SET_AQUAMARINE) and c:IsLevelAbove(8) and not c:IsCode(code)
end
function s.get_max_uses(tp)
	return Duel.GetMatchingGroupCount(s.filter8plus,tp,LOCATION_MZONE,0,nil,id)
end
function s.costfilter(c)
	return c:IsSetCard(SET_AQUAMARINE) and c:IsType(TYPE_FUSION) and c:IsAbleToRemoveAsCost()
end
function s.dmgcost(e,tp,eg,ep,ev,re,r,rp,chk)
	local max_uses = s.get_max_uses(tp)
	if chk==0 then return max_uses>0 and Duel.GetFlagEffect(tp,id)<max_uses
		and Duel.IsExistingMatchingCard(s.costfilter,tp,LOCATION_GRAVE,0,1,nil) end
	Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_REMOVE)
	local g=Duel.SelectMatchingCard(tp,s.costfilter,tp,LOCATION_GRAVE,0,1,1,nil)
	Duel.Remove(g,POS_FACEUP,REASON_COST)
	Duel.RegisterFlagEffect(tp,id,RESET_PHASE+PHASE_END,0,1)
end
function s.dmgtg(e,tp,eg,ep,ev,re,r,rp,chk)
	if chk==0 then return true end
	Duel.SetTargetPlayer(1-tp)
	Duel.SetTargetParam(1000)
	Duel.SetOperationInfo(0,CATEGORY_DAMAGE,nil,0,1-tp,1000)
end
function s.dmgop(e,tp,eg,ep,ev,re,r,rp)
	local p,d=Duel.GetChainInfo(0,CHAININFO_TARGET_PLAYER,CHAININFO_TARGET_PARAM)
	Duel.Damage(p,d,REASON_EFFECT)
end

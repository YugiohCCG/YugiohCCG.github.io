--Aquamarine Physalia
local s,id=GetID()
local SET_AQUAMARINE=0xf3c
function s.initial_effect(c)
	--Fusion Material
	c:EnableReviveLimit()
	aux.AddFusionProcMix(c,true,true,function(c) return c:IsSetCard(SET_AQUAMARINE) and c:IsType(TYPE_FUSION) end,function(c) return c:IsSetCard(SET_AQUAMARINE) end)
	--Banish and destroy
	local e1=Effect.CreateEffect(c)
	e1:SetDescription(aux.Stringid(id,0))
	e1:SetCategory(CATEGORY_DESTROY)
	e1:SetType(EFFECT_TYPE_QUICK_O)
	e1:SetCode(EVENT_FREE_CHAIN)
	e1:SetRange(LOCATION_MZONE)
	e1:SetHintTiming(0,TIMINGS_CHECK_MONSTER+TIMING_END_PHASE)
	e1:SetCondition(s.descon)
	e1:SetCost(s.descost)
	e1:SetTarget(s.destg)
	e1:SetOperation(s.desop)
	c:RegisterEffect(e1)
end
s.listed_series={SET_AQUAMARINE}

function s.descon(e,tp,eg,ep,ev,re,r,rp)
	return Duel.IsMainPhase()
end
function s.costfilter(c)
	return c:IsSetCard(SET_AQUAMARINE) and c:IsAbleToRemoveAsCost()
end
function s.filter7plus(c,code)
	return c:IsFaceup() and c:IsSetCard(SET_AQUAMARINE) and c:IsLevelAbove(7) and not c:IsCode(code)
end
function s.get_max_uses(tp)
	return Duel.GetMatchingGroupCount(s.filter7plus,tp,LOCATION_MZONE,0,nil,id)
end
function s.descost(e,tp,eg,ep,ev,re,r,rp,chk)
	local max_uses = s.get_max_uses(tp)
	if chk==0 then return max_uses>0 and Duel.GetFlagEffect(tp,id)<max_uses
		and Duel.IsExistingMatchingCard(s.costfilter,tp,LOCATION_GRAVE,0,1,nil) end
	Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_REMOVE)
	local g=Duel.SelectMatchingCard(tp,s.costfilter,tp,LOCATION_GRAVE,0,1,1,nil)
	Duel.Remove(g,POS_FACEUP,REASON_COST)
	Duel.RegisterFlagEffect(tp,id,RESET_PHASE+PHASE_END,0,1)
end
function s.destg(e,tp,eg,ep,ev,re,r,rp,chk)
	if chk==0 then return Duel.IsExistingMatchingCard(nil,tp,LOCATION_ONFIELD,LOCATION_ONFIELD,1,nil) end
	Duel.SetOperationInfo(0,CATEGORY_DESTROY,nil,1,0,0)
	if Duel.IsExistingMatchingCard(Card.IsCode,tp,LOCATION_MZONE,0,1,nil,225161820) then -- Glaucus
		Duel.SetChainLimit(s.chainlimit)
	end
end
function s.chainlimit(re,rp,tp)
	return tp==rp or not re:IsActiveType(TYPE_MONSTER)
end
function s.desop(e,tp,eg,ep,ev,re,r,rp)
	Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_DESTROY)
	local g=Duel.SelectMatchingCard(tp,nil,tp,LOCATION_ONFIELD,LOCATION_ONFIELD,1,1,nil)
	if #g>0 then
		Duel.Destroy(g,REASON_EFFECT)
	end
end

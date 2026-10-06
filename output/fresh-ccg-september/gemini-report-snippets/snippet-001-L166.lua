--Aquamarine Actinia
local s,id=GetID()
local STRING_ID=132258796
local SET_AQUAMARINE=0xf3c
function s.initial_effect(c)
	--Fusion Material: sub=false, insf=true
	c:EnableReviveLimit()
	aux.AddFusionProcMix(c,false,true,s.matfilter1,s.matfilter2)
	--Special Summon from GY (unclassified procedure, requires proper summon)
	local e1=Effect.CreateEffect(c)
	e1:SetDescription(aux.Stringid(STRING_ID,0))
	e1:SetType(EFFECT_TYPE_FIELD)
	e1:SetCode(EFFECT_SPSUMMON_PROC)
	e1:SetProperty(EFFECT_FLAG_UNCOPYABLE)
	e1:SetRange(LOCATION_GRAVE)
	e1:SetCountLimit(1,id+EFFECT_COUNT_CODE_OATH)
	e1:SetCondition(s.spcon1)
	c:RegisterEffect(e1)
	--Negate Quick Effect
	local e2=Effect.CreateEffect(c)
	e2:SetDescription(aux.Stringid(STRING_ID,1))
	e2:SetCategory(CATEGORY_NEGATE+CATEGORY_DESTROY)
	e2:SetType(EFFECT_TYPE_QUICK_O)
	e2:SetCode(EVENT_CHAINING)
	e2:SetProperty(EFFECT_FLAG_DAMAGE_STEP+EFFECT_FLAG_DAMAGE_CAL)
	e2:SetRange(LOCATION_MZONE)
	e2:SetCountLimit(1,id)
	e2:SetCondition(s.negcon)
	e2:SetCost(s.negcost)
	e2:SetTarget(s.negtg)
	e2:SetOperation(s.negop)
	c:RegisterEffect(e2)
end
s.listed_series={SET_AQUAMARINE}

function s.matfilter1(c)
	return c:IsSetCard(SET_AQUAMARINE) and c:IsLevelAbove(7)
end
function s.matfilter2(c)
	return c:IsAttribute(ATTRIBUTE_WATER) and c:IsRace(RACE_AQUA)
end
function s.spcon1(e,c)
	if c==nil then return true end
	local tp=c:GetControler()
	return Duel.GetLocationCount(tp,LOCATION_MZONE)>0
		and c:IsStatus(STATUS_PROC_COMPLETE)
		and not Duel.IsPlayerAffectedByEffect(tp,EFFECT_NECRO_VALLEY)
		and Duel.IsExistingMatchingCard(function(tc) return tc:IsFaceup() and tc:IsAttribute(ATTRIBUTE_WATER) and tc:IsRace(RACE_AQUA) end,tp,LOCATION_MZONE,0,1,nil)
end
function s.negcon(e,tp,eg,ep,ev,re,r,rp)
	return not e:GetHandler():IsStatus(STATUS_BATTLE_DESTROYED)
		and Duel.IsChainNegatable(ev)
		and Duel.IsExistingMatchingCard(function(c) return c:IsFaceup() and c:IsSetCard(SET_AQUAMARINE) and c~=e:GetHandler() end,tp,LOCATION_MZONE,0,1,nil)
end
function s.costfilter(c)
	return c:IsAttribute(ATTRIBUTE_WATER) and c:IsRace(RACE_AQUA) and c:IsAbleToRemoveAsCost()
		and aux.NecroValleyFilter()(c)
end
function s.negcost(e,tp,eg,ep,ev,re,r,rp,chk)
	if chk==0 then return Duel.IsExistingMatchingCard(s.costfilter,tp,LOCATION_GRAVE,0,1,nil) end
	Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_REMOVE)
	local g=Duel.SelectMatchingCard(tp,s.costfilter,tp,LOCATION_GRAVE,0,1,1,nil)
	Duel.Remove(g,POS_FACEUP,REASON_COST)
end
function s.negtg(e,tp,eg,ep,ev,re,r,rp,chk)
	if chk==0 then return true end
	Duel.SetOperationInfo(0,CATEGORY_NEGATE,eg,1,0,0)
	if re:GetHandler():IsDestructable() and re:GetHandler():IsRelateToEffect(re) then
		Duel.SetOperationInfo(0,CATEGORY_DESTROY,eg,1,0,0)
	end
end
function s.negop(e,tp,eg,ep,ev,re,r,rp)
	if Duel.NegateActivation(ev) and re:GetHandler():IsRelateToEffect(re) then
		Duel.Destroy(eg,REASON_EFFECT)
	end
end

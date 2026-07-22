-- Rising Elemental
local s,id=GetID()
local STRING_ID=132464260
function s.initial_effect(c)
	-- synchro summon
	c:EnableReviveLimit()
	aux.AddSynchroMixProcedure(c,aux.Tuner(nil),aux.Tuner(nil),aux.Tuner(nil),aux.NonTuner(nil),3,3,s.syncheck)
	-- add attributes
	local e1=Effect.CreateEffect(c)
	e1:SetType(EFFECT_TYPE_SINGLE)
	e1:SetProperty(EFFECT_FLAG_SINGLE_RANGE)
	e1:SetRange(LOCATION_MZONE)
	e1:SetCode(EFFECT_ADD_ATTRIBUTE)
	e1:SetValue(ATTRIBUTE_WIND+ATTRIBUTE_WATER+ATTRIBUTE_FIRE+ATTRIBUTE_EARTH+ATTRIBUTE_DARK)
	c:RegisterEffect(e1)
	-- gain effect if 6 attributes
	local e2=Effect.CreateEffect(c)
	e2:SetDescription(aux.Stringid(STRING_ID,0))
	e2:SetCategory(CATEGORY_REMOVE)
	e2:SetType(EFFECT_TYPE_QUICK_O)
	e2:SetCode(EVENT_FREE_CHAIN)
	e2:SetRange(LOCATION_MZONE)
	e2:SetCountLimit(1)
	e2:SetCondition(s.excon)
	e2:SetCost(s.excost)
	e2:SetTarget(s.extg)
	e2:SetOperation(s.exop)
	c:RegisterEffect(e2)
	-- immune
	local e3=Effect.CreateEffect(c)
	e3:SetType(EFFECT_TYPE_SINGLE)
	e3:SetCode(EFFECT_IMMUNE_EFFECT)
	e3:SetProperty(EFFECT_FLAG_SINGLE_RANGE)
	e3:SetRange(LOCATION_MZONE)
	e3:SetValue(s.efilter)
	c:RegisterEffect(e3)
end
function s.syncheck(g,sc,tp)
	local tuners=g:Filter(Card.IsType,nil,TYPE_TUNER)
	local nontuners=g:Filter(function(c) return not c:IsType(TYPE_TUNER) end)
	if #tuners~=3 or #nontuners~=3 then return false end
	local t_attrs=tuners:GetClassCount(Card.GetAttribute)
	local n_attrs=nontuners:GetClassCount(Card.GetAttribute)
	return t_attrs==3 and n_attrs==3
end
function s.excon(e,tp,eg,ep,ev,re,r,rp)
	local c=e:GetHandler()
	if not c:IsSummonType(SUMMON_TYPE_SYNCHRO) then return false end
	local mg=c:GetMaterial()
	return mg and mg:GetClassCount(Card.GetAttribute)==6
end
function s.excost(e,tp,eg,ep,ev,re,r,rp,chk)
	if chk==0 then return Duel.IsExistingMatchingCard(aux.NecroValleyFilter(Card.IsAbleToRemoveAsCost),tp,LOCATION_GRAVE,0,1,nil) end
	Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_REMOVE)
	local g=Duel.SelectMatchingCard(tp,aux.NecroValleyFilter(Card.IsAbleToRemoveAsCost),tp,LOCATION_GRAVE,0,1,1,nil)
	e:SetLabel(g:GetFirst():GetAttribute())
	Duel.Remove(g,POS_FACEUP,REASON_COST)
end
function s.rmfilter(c,attr)
	return c:IsAttribute(attr) and c:IsAbleToRemove()
end
function s.extg(e,tp,eg,ep,ev,re,r,rp,chk)
	if chk==0 then return true end
	Duel.SetOperationInfo(0,CATEGORY_REMOVE,nil,1,1-tp,LOCATION_MZONE+LOCATION_GRAVE)
end
function s.exop(e,tp,eg,ep,ev,re,r,rp)
	local attr=e:GetLabel()
	local g=Duel.GetMatchingGroup(aux.NecroValleyFilter(s.rmfilter),tp,0,LOCATION_MZONE+LOCATION_GRAVE,nil,attr)
	if #g>0 then
		Duel.Remove(g,POS_FACEUP,REASON_EFFECT)
	end
end
function s.efilter(e,re)
	local c=e:GetHandler()
	local tp=e:GetHandlerPlayer()
	if not re:IsActiveType(TYPE_MONSTER) or re:GetOwnerPlayer()==tp then return false end
	local rc=re:GetHandler()
	if not rc then return false end
	local attr=rc:GetAttribute()
	local g=Duel.GetMatchingGroup(Card.IsFaceup,tp,LOCATION_MZONE,0,c)
	return g:IsExists(Card.IsAttribute,1,nil,attr)
end

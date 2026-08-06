local s,id=GetID()
local STRING_ID=132934904
local SET_GALACTICA=0x9c9
function s.initial_effect(c)
	local e0=Effect.CreateEffect(c) e0:SetType(EFFECT_TYPE_ACTIVATE) e0:SetCode(EVENT_FREE_CHAIN) c:RegisterEffect(e0)
	local e1=Effect.CreateEffect(c) e1:SetType(EFFECT_TYPE_SINGLE) e1:SetCode(EFFECT_REMAIN_FIELD) c:RegisterEffect(e1)
	local e2=Effect.CreateEffect(c) e2:SetType(EFFECT_TYPE_FIELD) e2:SetCode(EFFECT_CANNOT_DIRECT_ATTACK) e2:SetRange(LOCATION_FZONE) e2:SetTargetRange(LOCATION_MZONE,0) e2:SetTarget(function(e,tc) return not tc:IsSetCard(SET_GALACTICA) end) c:RegisterEffect(e2)
	local e3=Effect.CreateEffect(c) e3:SetType(EFFECT_TYPE_FIELD) e3:SetCode(EFFECT_DIRECT_ATTACK) e3:SetRange(LOCATION_FZONE) e3:SetTargetRange(LOCATION_MZONE,0) e3:SetTarget(function(e,tc) return tc:IsSetCard(SET_GALACTICA) end) c:RegisterEffect(e3)
	local e4=Effect.CreateEffect(c) e4:SetDescription(aux.Stringid(STRING_ID,0)) e4:SetCategory(CATEGORY_DESTROY) e4:SetType(EFFECT_TYPE_FIELD+EFFECT_TYPE_CONTINUOUS) e4:SetCode(EVENT_CHAIN_SOLVED) e4:SetRange(LOCATION_FZONE) e4:SetCountLimit(2,id) e4:SetCondition(s.descon) e4:SetOperation(s.desop) c:RegisterEffect(e4)
end
function s.descon(e,tp,eg,ep,ev,re,r,rp)
	local ph=Duel.GetCurrentPhase()
	if rp~=tp or (ph~=PHASE_DAMAGE and ph~=PHASE_DAMAGE_CAL)
		or not re:IsActiveType(TYPE_MONSTER) or not re:IsHasCategory(CATEGORY_SPECIAL_SUMMON) then return false end
	local ex,g=Duel.GetOperationInfo(ev,CATEGORY_SPECIAL_SUMMON)
	return ex and g and g:IsExists(Card.IsSetCard,1,nil,SET_GALACTICA)
end
function s.desop(e,tp) local g=Duel.GetMatchingGroup(Card.IsDestructable,tp,LOCATION_ONFIELD,LOCATION_ONFIELD,nil) if #g>0 and Duel.SelectYesNo(tp,aux.Stringid(STRING_ID,1)) then Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_DESTROY) local tc=g:Select(tp,1,1,nil):GetFirst() Duel.Destroy(tc,REASON_EFFECT) end end

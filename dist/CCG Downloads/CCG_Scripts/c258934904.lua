local s,id=GetID()
local STRING_ID=132934904
local SET_GALACTICA=0x9c9
function s.initial_effect(c)
	local e0=Effect.CreateEffect(c) e0:SetType(EFFECT_TYPE_ACTIVATE) e0:SetCode(EVENT_FREE_CHAIN) c:RegisterEffect(e0)
	local e1=Effect.CreateEffect(c) e1:SetType(EFFECT_TYPE_SINGLE) e1:SetCode(EFFECT_REMAIN_FIELD) c:RegisterEffect(e1)
	local e2=Effect.CreateEffect(c) e2:SetType(EFFECT_TYPE_FIELD) e2:SetCode(EFFECT_CANNOT_DIRECT_ATTACK) e2:SetRange(LOCATION_FZONE) e2:SetTargetRange(LOCATION_MZONE,0) e2:SetTarget(function(e,tc) return not tc:IsSetCard(SET_GALACTICA) end) c:RegisterEffect(e2)
	local e3=Effect.CreateEffect(c) e3:SetType(EFFECT_TYPE_FIELD) e3:SetCode(EFFECT_DIRECT_ATTACK) e3:SetRange(LOCATION_FZONE) e3:SetTargetRange(LOCATION_MZONE,0) e3:SetTarget(function(e,tc) return tc:IsSetCard(SET_GALACTICA) end) c:RegisterEffect(e3)
	local e4=Effect.CreateEffect(c) e4:SetDescription(aux.Stringid(STRING_ID,0)) e4:SetCategory(CATEGORY_DESTROY) e4:SetType(EFFECT_TYPE_FIELD+EFFECT_TYPE_CONTINUOUS) e4:SetCode(EVENT_CHAINING) e4:SetRange(LOCATION_FZONE) e4:SetCondition(s.descon) e4:SetOperation(s.desop) c:RegisterEffect(e4)
end
function s.descon(e,tp,eg,ep,ev,re,r,rp)
	local ph=Duel.GetCurrentPhase()
	if Duel.GetFlagEffect(tp,id)>=2 or rp~=tp or (ph~=PHASE_DAMAGE and ph~=PHASE_DAMAGE_CAL)
		or not re:IsActiveType(TYPE_MONSTER) or not re:IsHasCategory(CATEGORY_SPECIAL_SUMMON) then return false end
	if type(aux.CCGGalacticaSummonEffects)=="table" and aux.CCGGalacticaSummonEffects[re] then return true end
	local ex,g=Duel.GetOperationInfo(ev,CATEGORY_SPECIAL_SUMMON)
	return ex and g and g:IsExists(Card.IsSetCard,1,nil,SET_GALACTICA)
end
function s.desop(e,tp,eg,ep,ev,re,r,rp)
	if not Duel.SelectYesNo(tp,aux.Stringid(STRING_ID,1)) then return end
	local original_operation=re:GetOperation()
	Duel.RegisterFlagEffect(tp,id,RESET_PHASE+PHASE_END,0,1)
	Duel.ChangeChainOperation(ev,function(ce,ctp,ceg,cep,cev,cre,cr,crp)
		if original_operation then original_operation(ce,ctp,ceg,cep,cev,cre,cr,crp) end
		local g=Duel.GetMatchingGroup(Card.IsDestructable,ctp,LOCATION_ONFIELD,LOCATION_ONFIELD,nil)
		if #g==0 then return end
		Duel.Hint(HINT_SELECTMSG,ctp,HINTMSG_DESTROY)
		local tc=g:Select(ctp,1,1,nil):GetFirst()
		if tc then Duel.Destroy(tc,REASON_EFFECT) end
	end)
end

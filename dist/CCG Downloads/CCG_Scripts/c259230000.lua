local s,id=GetID()
local STRING_ID=133230000
local SET_ELDORA=0x738
local ELDORA=214552846
local STATION=258934904
function s.initial_effect(c)
	local e0=Effect.CreateEffect(c) e0:SetType(EFFECT_TYPE_SINGLE) e0:SetCode(EFFECT_ADD_SETCODE) e0:SetValue(SET_ELDORA) c:RegisterEffect(e0)
	local e1=Effect.CreateEffect(c) e1:SetDescription(aux.Stringid(STRING_ID,0)) e1:SetCategory(CATEGORY_SPECIAL_SUMMON) e1:SetType(EFFECT_TYPE_ACTIVATE) e1:SetCode(EVENT_FREE_CHAIN) e1:SetProperty(EFFECT_FLAG_CARD_TARGET) e1:SetTarget(s.target) e1:SetOperation(s.activate) c:RegisterEffect(e1)
	local e2=Effect.CreateEffect(c) e2:SetDescription(aux.Stringid(STRING_ID,1)) e2:SetCategory(CATEGORY_RELEASE) e2:SetType(EFFECT_TYPE_QUICK_O) e2:SetCode(EVENT_FREE_CHAIN) e2:SetRange(LOCATION_MZONE) e2:SetHintTiming(0,TIMINGS_CHECK_MONSTER+TIMING_END_PHASE) e2:SetCondition(s.stcon) e2:SetCost(s.stcost) e2:SetTarget(s.sttg) e2:SetOperation(s.stop) c:RegisterEffect(e2)
	local e3=Effect.CreateEffect(c) e3:SetType(EFFECT_TYPE_FIELD+EFFECT_TYPE_CONTINUOUS) e3:SetCode(EVENT_DESTROYED) e3:SetRange(LOCATION_MZONE) e3:SetOperation(s.regop) c:RegisterEffect(e3)
end
function s.tgfilter(c,e,tp)
	return c:IsFaceup() and c:IsType(TYPE_EFFECT) and c:IsType(TYPE_MONSTER)
		and not c:IsType(TYPE_XYZ+TYPE_LINK) and c:IsCanBeEffectTarget(e)
		and Duel.IsPlayerCanSpecialSummonMonster(tp,id,SET_ELDORA,TYPES_EFFECT_TRAP_MONSTER,
			c:GetAttack(),c:GetDefense(),c:GetLevel(),c:GetRace(),c:GetAttribute())
end
function s.target(e,tp,eg,ep,ev,re,r,rp,chk,chkc) if chkc then return chkc:IsControler(tp) and chkc:IsLocation(LOCATION_MZONE) and s.tgfilter(chkc,e,tp) end if chk==0 then return Duel.GetLocationCount(tp,LOCATION_MZONE)>0 and Duel.IsExistingTarget(s.tgfilter,tp,LOCATION_MZONE,0,1,nil,e,tp) and Duel.IsExistingMatchingCard(s.actfilter,tp,LOCATION_DECK,0,1,nil,tp,ELDORA) end Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_TARGET) Duel.SelectTarget(tp,s.tgfilter,tp,LOCATION_MZONE,0,1,1,nil,e,tp) end
function s.actfilter(c,tp,code)
	local te=c:GetActivateEffect()
	return c:IsCode(code) and not c:IsForbidden() and te and te:IsActivatable(tp,true,true)
end
function s.activate_card(e,tp,code,loc,eg,ep,ev,re,r,rp)
	local filter=loc&LOCATION_GRAVE~=0 and aux.NecroValleyFilter(s.actfilter) or s.actfilter
	local tc=Duel.SelectMatchingCard(tp,filter,tp,loc,0,1,1,nil,tp,code):GetFirst() if not tc then return false end local te=tc:GetActivateEffect() if not te or not te:IsActivatable(tp,true,true) then return false end
	local zone=tc:IsType(TYPE_FIELD) and LOCATION_FZONE or LOCATION_SZONE
	if zone==LOCATION_FZONE then
		local fc=Duel.GetFieldCard(tp,LOCATION_FZONE,0)
		if fc then Duel.SendtoGrave(fc,REASON_RULE) Duel.BreakEffect() end
	end
	if Duel.MoveToField(tc,tp,tp,zone,POS_FACEUP,true) then
		te:UseCountLimit(tp,1,true)
		local cost=te:GetCost()
		if cost then cost(te,tp,eg,ep,ev,re,r,rp,1) end
		Duel.RaiseEvent(tc,4179255,te,0,tp,tp,Duel.GetCurrentChain())
		return true
	end
	return false
end
function s.activate(e,tp,eg,ep,ev,re,r,rp)
	local tc=Duel.GetFirstTarget() local c=e:GetHandler() if not tc or not tc:IsRelateToEffect(e) or not c:IsRelateToEffect(e) or not s.activate_card(e,tp,ELDORA,LOCATION_DECK,eg,ep,ev,re,r,rp) or not c:IsRelateToEffect(e) or not tc:IsRelateToEffect(e) then return end
	local typ=tc:GetRace() local att=tc:GetAttribute() local lv=tc:GetLevel() local atk=tc:GetAttack() local def=tc:GetDefense()
	if not tc:IsFaceup() or not Duel.IsPlayerCanSpecialSummonMonster(tp,id,SET_ELDORA,TYPES_EFFECT_TRAP_MONSTER,atk,def,lv,typ,att) then return end
	c:AddMonsterAttribute(TYPE_EFFECT+TYPE_TRAP,att,typ,lv,atk,def)
	if Duel.SpecialSummon(c,SUMMON_VALUE_SELF,tp,tp,true,false,POS_FACEUP)>0 then
		local te=Effect.CreateEffect(c) te:SetType(EFFECT_TYPE_SINGLE) te:SetCode(EFFECT_INDESTRUCTABLE_EFFECT) te:SetValue(1) te:SetReset(RESET_EVENT+RESETS_STANDARD) c:RegisterEffect(te,true)
	end
end
function s.regop(e,tp,eg)
	if eg:IsExists(function(c,p) return c:IsCode(ELDORA) and c:IsPreviousControler(p) and c:IsReason(REASON_EFFECT) and c:GetReasonPlayer()==1-p end,1,nil,tp) then
		e:GetHandler():RegisterFlagEffect(id,RESET_EVENT+RESETS_STANDARD+RESET_PHASE+PHASE_END,0,1)
	end
end
function s.stcon(e) return e:GetHandler():GetFlagEffect(id)>0 end
function s.stcost(e,tp,eg,ep,ev,re,r,rp,chk) if chk==0 then return e:GetHandler():IsReleasable() end Duel.Release(e:GetHandler(),REASON_COST) end
function s.stfilter(c,tp) return s.actfilter(c,tp,STATION) end
function s.sttg(e,tp,eg,ep,ev,re,r,rp,chk) if chk==0 then return Duel.IsExistingMatchingCard(aux.NecroValleyFilter(s.stfilter),tp,LOCATION_HAND+LOCATION_DECK+LOCATION_GRAVE,0,1,nil,tp) end end
function s.stop(e,tp,eg,ep,ev,re,r,rp) s.activate_card(e,tp,STATION,LOCATION_HAND+LOCATION_DECK+LOCATION_GRAVE,eg,ep,ev,re,r,rp) end

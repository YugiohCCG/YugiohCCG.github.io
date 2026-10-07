-- Gravinity Galaxix
local s,id=GetID()
local STRING_ID=133454272
local SET_GRAVINITY=0x760

function s.initial_effect(c)
	-- Synchro Summon
	aux.AddSynchroProcedure(c,nil,aux.NonTuner(nil),1,1)
	c:EnableReviveLimit()

	-- Extra Synchro Material from SZONE for this card's Synchro Summon
	local e0=Effect.CreateEffect(c)
	e0:SetType(EFFECT_TYPE_FIELD)
	e0:SetProperty(EFFECT_FLAG_CANNOT_DISABLE+EFFECT_FLAG_UNCOPYABLE+EFFECT_FLAG_IGNORE_IMMUNE)
	e0:SetCode(EFFECT_EXTRA_SYNCHRO_MATERIAL)
	e0:SetRange(LOCATION_EXTRA+LOCATION_SZONE)
	e0:SetTargetRange(LOCATION_SZONE,0)
	e0:SetTarget(s.matszfilter)
	e0:SetValue(s.matval)
	c:RegisterEffect(e0)

	-- On Synchro Summon or Special Summon from SZONE: Set 1 Gravinity Spell/Trap from GY/banishment
	local e1=Effect.CreateEffect(c)
	e1:SetDescription(aux.Stringid(STRING_ID,0))
	e1:SetCategory(CATEGORY_LEAVE_GRAVE)
	if type(aux.CCGSetEffects)~="table" then aux.CCGSetEffects={} end aux.CCGSetEffects[e1]=true
	e1:SetType(EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_O)
	e1:SetCode(EVENT_SPSUMMON_SUCCESS)
	e1:SetProperty(EFFECT_FLAG_DELAY)
	e1:SetCountLimit(1,id)
	e1:SetCondition(s.setcon)
	e1:SetTarget(s.settg)
	e1:SetOperation(s.setop)
	c:RegisterEffect(e1)

	-- While Continuous Trap: Draw 1, then optionally Special Summon self
	local e2=Effect.CreateEffect(c)
	e2:SetDescription(aux.Stringid(STRING_ID,1))
	e2:SetCategory(CATEGORY_DRAW+CATEGORY_SPECIAL_SUMMON)
	e2:SetType(EFFECT_TYPE_QUICK_O)
	e2:SetCode(EVENT_FREE_CHAIN)
	e2:SetRange(LOCATION_SZONE)
	e2:SetHintTiming(0,TIMINGS_CHECK_MONSTER+TIMING_END_PHASE)
	e2:SetCountLimit(1,id+100)
	e2:SetCondition(s.trapcon)
	e2:SetTarget(s.sptg)
	e2:SetOperation(s.spop)
	c:RegisterEffect(e2)
end

function s.matszfilter(e,c)
	return c:IsSetCard(SET_GRAVINITY) and (c:GetOriginalType()&TYPE_MONSTER)~=0
end
function s.matval(e,sc)
	return sc==e:GetHandler()
end

function s.setcon(e,tp,eg,ep,ev,re,r,rp)
	local c=e:GetHandler()
	return c:IsSummonType(SUMMON_TYPE_SYNCHRO) or (c:IsPreviousLocation(LOCATION_SZONE) and c:GetPreviousControler()==tp)
end
function s.setfilter(c)
	return c:IsFaceupEx() and c:IsSetCard(SET_GRAVINITY) and c:IsType(TYPE_SPELL+TYPE_TRAP) and c:IsSSetable()
end
function s.settg(e,tp,eg,ep,ev,re,r,rp,chk)
	if chk==0 then return Duel.GetLocationCount(tp,LOCATION_SZONE)>0
		and Duel.IsExistingMatchingCard(aux.NecroValleyFilter(s.setfilter),tp,LOCATION_GRAVE+LOCATION_REMOVED,0,1,nil) end
	Duel.SetPossibleOperationInfo(0,CATEGORY_LEAVE_GRAVE,nil,1,tp,LOCATION_GRAVE)
end
function s.setop(e,tp)
	if Duel.GetLocationCount(tp,LOCATION_SZONE)<=0 then return end
	Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_SET)
	local tc=Duel.SelectMatchingCard(tp,aux.NecroValleyFilter(s.setfilter),tp,LOCATION_GRAVE+LOCATION_REMOVED,0,1,1,nil):GetFirst()
	if tc and Duel.SSet(tp,tc)>0 and (tc:IsType(TYPE_TRAP) or tc:IsType(TYPE_QUICKPLAY)) then
		local e1=Effect.CreateEffect(e:GetHandler())
		e1:SetType(EFFECT_TYPE_SINGLE)
		e1:SetProperty(EFFECT_FLAG_SET_AVAILABLE)
		e1:SetCode(tc:IsType(TYPE_TRAP) and EFFECT_TRAP_ACT_IN_SET_TURN or EFFECT_QP_ACT_IN_SET_TURN)
		e1:SetReset(RESET_EVENT+RESETS_STANDARD+RESET_PHASE+PHASE_END)
		tc:RegisterEffect(e1)
	end
end

function s.trapcon(e)
	return e:GetHandler():GetType()==TYPE_TRAP+TYPE_CONTINUOUS
end
function s.sptg(e,tp,eg,ep,ev,re,r,rp,chk)
	local c=e:GetHandler()
	if chk==0 then return Duel.IsPlayerCanDraw(tp,1) end
	Duel.SetOperationInfo(0,CATEGORY_DRAW,nil,0,tp,1)
	Duel.SetPossibleOperationInfo(0,CATEGORY_SPECIAL_SUMMON,c,1,tp,LOCATION_SZONE)
end
function s.spop(e,tp)
	local c=e:GetHandler()
	if Duel.Draw(tp,1,REASON_EFFECT)>0 and c:IsRelateToEffect(e) and Duel.GetLocationCount(tp,LOCATION_MZONE)>0
		and c:IsCanBeSpecialSummoned(e,0,tp,false,false) and Duel.SelectYesNo(tp,aux.Stringid(STRING_ID,2)) then
		Duel.BreakEffect()
		Duel.SpecialSummon(c,0,tp,tp,false,false,POS_FACEUP)
	end
end

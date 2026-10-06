-- Gravinity Star
local s,id=GetID()
local STRING_ID=133768254
local SET_GRAVINITY=0x760
local TRANSFER_CALL=223505382

function s.initial_effect(c)
	-- Hand Quick Effect: Place in SZONE as Continuous Trap
	local e1=Effect.CreateEffect(c)
	e1:SetDescription(aux.Stringid(STRING_ID,0))
	e1:SetType(EFFECT_TYPE_QUICK_O)
	e1:SetCode(EVENT_FREE_CHAIN)
	e1:SetRange(LOCATION_HAND)
	e1:SetHintTiming(0,TIMINGS_CHECK_MONSTER+TIMING_MAIN_END)
	e1:SetCountLimit(1,id)
	e1:SetCondition(function() return Duel.IsMainPhase() end)
	e1:SetTarget(s.pltg)
	e1:SetOperation(s.plop)
	c:RegisterEffect(e1)

	-- Treated as Continuous Trap Quick Effect: Activate 1 of the bullet options
	local e2=Effect.CreateEffect(c)
	e2:SetDescription(aux.Stringid(STRING_ID,1))
	if type(aux.CCGSetEffects)~="table" then aux.CCGSetEffects={} end aux.CCGSetEffects[e2]=true
	e2:SetType(EFFECT_TYPE_QUICK_O)
	e2:SetCode(EVENT_FREE_CHAIN)
	e2:SetRange(LOCATION_SZONE)
	e2:SetHintTiming(0,TIMINGS_CHECK_MONSTER+TIMING_END_PHASE)
	e2:SetCountLimit(1,id+100)
	e2:SetCondition(s.trapcon)
	e2:SetTarget(s.efftg)
	e2:SetOperation(s.effop)
	c:RegisterEffect(e2)
end

function s.trapify(c,hc)
	local e1=Effect.CreateEffect(hc)
	e1:SetType(EFFECT_TYPE_SINGLE)
	e1:SetCode(EFFECT_CHANGE_TYPE)
	e1:SetProperty(EFFECT_FLAG_CANNOT_DISABLE)
	e1:SetValue(TYPE_TRAP+TYPE_CONTINUOUS)
	e1:SetReset(RESET_EVENT+RESETS_STANDARD-RESET_TURN_SET)
	c:RegisterEffect(e1)
end

function s.pltg(e,tp,eg,ep,ev,re,r,rp,chk)
	if chk==0 then return Duel.GetLocationCount(tp,LOCATION_SZONE)>0 and not e:GetHandler():IsForbidden() end
end
function s.plop(e,tp)
	local c=e:GetHandler()
	if c:IsRelateToEffect(e) and Duel.MoveToField(c,tp,tp,LOCATION_SZONE,POS_FACEUP,true) then
		s.trapify(c,c)
	end
end

function s.trapcon(e)
	return e:GetHandler():GetType()==TYPE_TRAP+TYPE_CONTINUOUS
end
function s.setfilter(c)
	return c:IsSetCard(SET_GRAVINITY) and c:IsType(TYPE_SPELL+TYPE_TRAP) and c:IsSSetable()
end
function s.get_move_flag(c,tp)
	local seq=c:GetSequence()
	if seq>4 then return 0 end
	local flag=0
	for i=0,4 do
		if i~=seq and Duel.CheckLocation(tp,LOCATION_SZONE,i) then
			flag=flag|(1<<(i+8))
		end
	end
	return flag
end

function s.efftg(e,tp,eg,ep,ev,re,r,rp,chk)
	local c=e:GetHandler()
	local all=c:GetFlagEffect(TRANSFER_CALL)>0
	local b1=Duel.GetLocationCount(tp,LOCATION_SZONE)>0 and Duel.IsExistingMatchingCard(s.setfilter,tp,LOCATION_DECK,0,1,nil)
	local b2=s.get_move_flag(c,tp)>0
	if chk==0 then return b1 or b2 end
	local op=0
	if all and b1 and b2 then
		op=3
	elseif b1 and b2 then
		op=Duel.SelectEffect(tp,{b1,aux.Stringid(STRING_ID,1)},{b2,aux.Stringid(STRING_ID,2)})
	elseif b1 then
		op=1
	else
		op=2
	end
	e:SetLabel(op)
	if op==1 or op==3 then
		Duel.SetOperationInfo(0,CATEGORY_LEAVE_DECK,nil,1,tp,LOCATION_DECK)
	end
end

function s.doset(c,tp)
	if Duel.GetLocationCount(tp,LOCATION_SZONE)<=0 then return end
	Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_SET)
	local tc=Duel.SelectMatchingCard(tp,s.setfilter,tp,LOCATION_DECK,0,1,1,nil):GetFirst()
	if tc and Duel.SSet(tp,tc)>0 and Duel.IsTurnPlayer(1-tp) and (tc:IsType(TYPE_TRAP) or tc:IsType(TYPE_QUICKPLAY)) then
		local e1=Effect.CreateEffect(c)
		e1:SetType(EFFECT_TYPE_SINGLE)
		e1:SetCode(tc:IsType(TYPE_TRAP) and EFFECT_TRAP_ACT_IN_SET_TURN or EFFECT_QP_ACT_IN_SET_TURN)
		e1:SetProperty(EFFECT_FLAG_SET_AVAILABLE)
		e1:SetReset(RESET_EVENT+RESETS_STANDARD+RESET_PHASE+PHASE_END)
		tc:RegisterEffect(e1)
	end
end

function s.domove(c,tp)
	if not (c:IsLocation(LOCATION_SZONE) and c:IsControler(tp)) then return end
	local flag=s.get_move_flag(c,tp)
	if flag==0 then return end
	Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_TOZONE)
	local s=Duel.SelectField(tp,1,LOCATION_SZONE,0,~flag)
	local nseq=math.floor(math.log(s,2)+0.5)-8
	if nseq>=0 and nseq<=4 then
		Duel.MoveSequence(c,nseq)
	end
end

function s.effop(e,tp)
	local c=e:GetHandler()
	local op=e:GetLabel()
	local all=c:GetFlagEffect(TRANSFER_CALL)>0
	if all then c:ResetFlagEffect(TRANSFER_CALL) end
	if op==1 then
		s.doset(c,tp)
	elseif op==2 then
		s.domove(c,tp)
	elseif op==3 or all then
		s.doset(c,tp)
		s.domove(c,tp)
	end
end

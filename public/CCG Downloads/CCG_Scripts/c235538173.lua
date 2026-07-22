local s,id=GetID()
local STRING_ID=133538173
local SET_GRAVINITY=0x760
local TRANSFER_CALL=223505382
function s.initial_effect(c)
	local e1=Effect.CreateEffect(c)
	e1:SetDescription(aux.Stringid(STRING_ID,0))
	e1:SetType(EFFECT_TYPE_QUICK_O)
	e1:SetCode(EVENT_FREE_CHAIN)
	e1:SetRange(LOCATION_HAND)
	e1:SetCountLimit(1,id)
	e1:SetCondition(function() return Duel.IsMainPhase() end)
	e1:SetTarget(s.pltg)
	e1:SetOperation(s.plop)
	c:RegisterEffect(e1)
	local e2=Effect.CreateEffect(c)
	e2:SetDescription(aux.Stringid(STRING_ID,1))
	e2:SetType(EFFECT_TYPE_QUICK_O)
	e2:SetCode(EVENT_FREE_CHAIN)
	e2:SetRange(LOCATION_SZONE)
	e2:SetCountLimit(1,id+100)
	e2:SetCondition(s.trapcon)
	e2:SetTarget(s.decktg)
	e2:SetOperation(s.deckop)
	c:RegisterEffect(e2)
	local e3=Effect.CreateEffect(c)
	e3:SetDescription(aux.Stringid(STRING_ID,2))
	e3:SetType(EFFECT_TYPE_QUICK_O)
	e3:SetCode(EVENT_FREE_CHAIN)
	e3:SetRange(LOCATION_SZONE)
	e3:SetCountLimit(1,id+200)
	e3:SetCondition(s.mvcon)
	e3:SetOperation(s.mvop)
	c:RegisterEffect(e3)
	local e4=Effect.CreateEffect(c)
	e4:SetType(EFFECT_TYPE_SINGLE)
	e4:SetProperty(EFFECT_FLAG_SINGLE_RANGE)
	e4:SetCode(EFFECT_EXTRA_SYNCHRO_MATERIAL)
	e4:SetRange(LOCATION_SZONE)
	e4:SetValue(s.matval)
	c:RegisterEffect(e4)
end
function s.trapify(c)
	local e1=Effect.CreateEffect(c)
	e1:SetType(EFFECT_TYPE_SINGLE)
	e1:SetCode(EFFECT_CHANGE_TYPE)
	e1:SetValue(TYPE_TRAP+TYPE_CONTINUOUS)
	e1:SetReset(RESET_EVENT+RESETS_STANDARD)
	c:RegisterEffect(e1)
end
function s.pltg(e,tp,eg,ep,ev,re,r,rp,chk) if chk==0 then return Duel.GetLocationCount(tp,LOCATION_SZONE)>0 end end
function s.plop(e,tp)
	local c=e:GetHandler()
	if c:IsRelateToEffect(e) and Duel.MoveToField(c,tp,tp,LOCATION_SZONE,POS_FACEUP,true) then s.trapify(c) end
end
function s.trapcon(e) return e:GetHandler():IsType(TYPE_TRAP) end
function s.deckfilter(c) return c:IsSetCard(SET_GRAVINITY) and c:IsType(TYPE_MONSTER) and not c:IsCode(id) end
function s.decktg(e,tp,eg,ep,ev,re,r,rp,chk)
	if chk==0 then return Duel.GetLocationCount(tp,LOCATION_SZONE)>0 and Duel.IsExistingMatchingCard(s.deckfilter,tp,LOCATION_DECK,0,1,nil) end
end
function s.deckop(e,tp)
	local c=e:GetHandler()
	local all=c:GetFlagEffect(TRANSFER_CALL)>0
	if all then c:ResetFlagEffect(TRANSFER_CALL) end
	if Duel.GetLocationCount(tp,LOCATION_SZONE)<=0 then return end
	Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_TOFIELD)
	local tc=Duel.SelectMatchingCard(tp,s.deckfilter,tp,LOCATION_DECK,0,1,1,nil):GetFirst()
	if tc and Duel.MoveToField(tc,tp,tp,LOCATION_SZONE,POS_FACEUP,true) then s.trapify(tc) end
	if all then s.domove(c,tp) end
end
function s.mvcon(e,tp) return e:GetHandler():IsType(TYPE_TRAP) and e:GetHandler():GetSequence()<5 and Duel.GetLocationCount(tp,LOCATION_SZONE)>0 end
function s.domove(c,tp)
	if not c:IsLocation(LOCATION_SZONE) or not c:IsControler(tp) then return end
	Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_TOZONE)
	local fd=Duel.SelectDisableField(tp,1,LOCATION_SZONE,0,0)
	local seq=math.floor(math.log(fd,2)+0.5)-8
	if seq>=0 and seq<=4 and Duel.CheckLocation(tp,LOCATION_SZONE,seq) then Duel.MoveSequence(c,seq) end
end
function s.mvop(e,tp)
	local c=e:GetHandler()
	if c:GetFlagEffect(TRANSFER_CALL)>0 then c:ResetFlagEffect(TRANSFER_CALL) s.deckop(e,tp) end
	s.domove(c,tp)
end
function s.matval(e,sc) return sc:IsSetCard(SET_GRAVINITY) and sc:IsType(TYPE_SYNCHRO) end

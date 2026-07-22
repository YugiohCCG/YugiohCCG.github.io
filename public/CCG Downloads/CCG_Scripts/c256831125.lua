local s,id=GetID()
local STRING_ID=132831125
local SET_GRAVINITY=0x760
function s.initial_effect(c)
	local e0=Effect.CreateEffect(c)
	e0:SetType(EFFECT_TYPE_ACTIVATE)
	e0:SetCode(EVENT_FREE_CHAIN)
	c:RegisterEffect(e0)
	local e1=Effect.CreateEffect(c)
	e1:SetType(EFFECT_TYPE_FIELD)
	e1:SetCode(EFFECT_CANNOT_BE_EFFECT_TARGET)
	e1:SetRange(LOCATION_SZONE)
	e1:SetTargetRange(LOCATION_ONFIELD,0)
	e1:SetTarget(s.prottg)
	e1:SetValue(aux.tgoval)
	c:RegisterEffect(e1)
	local e2=Effect.CreateEffect(c)
	e2:SetType(EFFECT_TYPE_FIELD)
	e2:SetCode(EFFECT_UPDATE_LEVEL)
	e2:SetRange(LOCATION_SZONE)
	e2:SetTargetRange(0,LOCATION_MZONE)
	e2:SetTarget(s.coltg)
	e2:SetValue(-1)
	c:RegisterEffect(e2)
	local e3=e2:Clone()
	e3:SetCode(EFFECT_UPDATE_RANK)
	c:RegisterEffect(e3)
	local e5=Effect.CreateEffect(c)
	e5:SetDescription(aux.Stringid(STRING_ID,0))
	e5:SetType(EFFECT_TYPE_FIELD+EFFECT_TYPE_TRIGGER_O)
	e5:SetCode(EVENT_PHASE+PHASE_STANDBY)
	e5:SetRange(LOCATION_SZONE)
	e5:SetCountLimit(1,id)
	e5:SetTarget(s.copytg)
	e5:SetOperation(s.copyop)
	c:RegisterEffect(e5)
end
function s.prottg(e,c) return c:IsSetCard(SET_GRAVINITY) and (c:GetOriginalType()&TYPE_SYNCHRO)~=0 end
function s.coltg(e,c)
	return Duel.IsExistingMatchingCard(function(gc,oc) return gc:IsSetCard(SET_GRAVINITY) and (gc:GetOriginalType()&TYPE_MONSTER)~=0 and oc:GetColumnGroup():IsContains(gc) end,e:GetHandlerPlayer(),LOCATION_ONFIELD,0,1,nil,c)
end
function s.copyfilter(c) return c:IsSetCard(SET_GRAVINITY) and c:IsType(TYPE_SYNCHRO) and c:IsLevel(11) end
function s.copytg(e,tp,eg,ep,ev,re,r,rp,chk)
	if chk==0 then return Duel.IsExistingMatchingCard(s.copyfilter,tp,LOCATION_EXTRA,0,1,nil) end
end
function s.copyop(e,tp)
	Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_CONFIRM)
	local tc=Duel.SelectMatchingCard(tp,s.copyfilter,tp,LOCATION_EXTRA,0,1,1,nil):GetFirst()
	local c=e:GetHandler()
	if tc then
		Duel.ConfirmCards(1-tp,tc)
		c:CopyEffect(tc:GetOriginalCode(),RESET_EVENT+RESETS_STANDARD+RESET_PHASE+PHASE_END,1)
	end
end

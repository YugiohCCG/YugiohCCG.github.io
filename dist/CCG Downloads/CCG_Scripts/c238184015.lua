local s,id=GetID()
local STRING_ID=132184015
local SET_GRAVINITY=0x760
function s.initial_effect(c)
	local e1=Effect.CreateEffect(c)
	e1:SetDescription(aux.Stringid(STRING_ID,0))
	e1:SetCategory(CATEGORY_NEGATE+CATEGORY_DESTROY)
	e1:SetType(EFFECT_TYPE_ACTIVATE)
	e1:SetCode(EVENT_CHAINING)
	e1:SetCountLimit(1,id)
	e1:SetCondition(s.negcon)
	e1:SetTarget(s.negtg)
	e1:SetOperation(s.negop)
	c:RegisterEffect(e1)
	local e2=Effect.CreateEffect(c)
	e2:SetDescription(aux.Stringid(STRING_ID,1))
	e2:SetType(EFFECT_TYPE_FIELD+EFFECT_TYPE_TRIGGER_O)
	e2:SetCode(EVENT_CHAINING)
	e2:SetRange(LOCATION_GRAVE)
	e2:SetCondition(s.copycon)
	e2:SetCost(aux.bfgcost)
	e2:SetTarget(s.copytg)
	e2:SetOperation(s.copyop)
	c:RegisterEffect(e2)
end
function s.gravfilter(c) return c:IsFaceup() and c:IsSetCard(SET_GRAVINITY) and (c:GetOriginalType()&TYPE_MONSTER)~=0 end
function s.negcon(e,tp,eg,ep,ev,re,r,rp)
	return rp==1-tp and Duel.IsChainNegatable(ev) and Duel.GetMatchingGroupCount(s.gravfilter,tp,LOCATION_ONFIELD,0,nil)>=2
end
function s.negtg(e,tp,eg,ep,ev,re,r,rp,chk)
	if chk==0 then return true end
	Duel.SetOperationInfo(0,CATEGORY_NEGATE,eg,1,0,0)
end
function s.trapify(c)
	local e1=Effect.CreateEffect(c)
	e1:SetType(EFFECT_TYPE_SINGLE)
	e1:SetCode(EFFECT_CHANGE_TYPE)
	e1:SetValue(TYPE_TRAP+TYPE_CONTINUOUS)
	e1:SetReset(RESET_EVENT+RESETS_STANDARD)
	c:RegisterEffect(e1)
end
function s.negop(e,tp,eg,ep,ev,re,r,rp)
	local rc=re:GetHandler()
	if not Duel.NegateActivation(ev) or not rc:IsRelateToEffect(re) then return end
	local p=rc:GetOwner()
	local canplace=(rc:GetOriginalType()&TYPE_MONSTER)~=0 and Duel.GetLocationCount(p,LOCATION_SZONE)>0
		and (not rc:IsLocation(LOCATION_GRAVE) or aux.NecroValleyFilter()(rc))
	local op=canplace and Duel.SelectOption(tp,aux.Stringid(STRING_ID,2),aux.Stringid(STRING_ID,3)) or 0
	if op==0 then Duel.Destroy(rc,REASON_EFFECT)
	else
		rc:CancelToGrave()
		if Duel.MoveToField(rc,tp,p,LOCATION_SZONE,POS_FACEUP,true) then s.trapify(rc) end
	end
end
function s.copycon(e,tp,eg,ep,ev,re,r,rp)
	local rc=re:GetHandler()
	return rp==tp and rc:IsSetCard(SET_GRAVINITY) and (rc:GetOriginalType()&TYPE_SYNCHRO)~=0 and re:IsActivated()
end
function s.copytg(e,tp,eg,ep,ev,re,r,rp,chk)
	if chk==0 then return re:GetOperation()~=nil end
	e:SetLabelObject(re)
end
function s.copyop(e,tp,eg,ep,ev,re,r,rp)
	local te=e:GetLabelObject()
	local op=te and te:GetOperation()
	if op then op(te,tp,eg,ep,ev,re,r,rp) end
end

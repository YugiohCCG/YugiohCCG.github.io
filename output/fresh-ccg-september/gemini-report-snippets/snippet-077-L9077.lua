--Ghostrick Haunt
local s,id=GetID()
local STRING_ID=133540236
local SET_GHOSTRICK=0x8d
function s.initial_effect(c)
	--Activate
	local e0=Effect.CreateEffect(c)
	e0:SetType(EFFECT_TYPE_ACTIVATE)
	e0:SetCode(EVENT_FREE_CHAIN)
	c:RegisterEffect(e0)
	--Change 1 monster position, then return 1 monster to hand
	local e1=Effect.CreateEffect(c)
	e1:SetDescription(aux.Stringid(STRING_ID,0))
	e1:SetCategory(CATEGORY_POSITION+CATEGORY_TOHAND)
	e1:SetType(EFFECT_TYPE_QUICK_O)
	e1:SetCode(EVENT_FREE_CHAIN)
	e1:SetRange(LOCATION_SZONE)
	e1:SetCountLimit(1)
	e1:SetCondition(s.poscon)
	e1:SetTarget(s.postg)
	e1:SetOperation(s.posop)
	c:RegisterEffect(e1)
	--Set from GY when Level 1 Ghostrick activates in hand
	local e2=Effect.CreateEffect(c)
	e2:SetDescription(aux.Stringid(STRING_ID,1))
	e2:SetCategory(CATEGORY_LEAVE_GRAVE)
	e2:SetType(EFFECT_TYPE_FIELD+EFFECT_TYPE_TRIGGER_O)
	e2:SetCode(EVENT_CHAINING)
	e2:SetRange(LOCATION_GRAVE)
	e2:SetCondition(s.setcon)
	e2:SetTarget(s.settg)
	e2:SetOperation(s.setop)
	c:RegisterEffect(e2)
end
function s.cfilter(c,ec)
	return c:IsFaceup() and c:IsSetCard(SET_GHOSTRICK) and c~=ec
end
function s.poscon(e,tp)
	return Duel.IsExistingMatchingCard(s.cfilter,tp,LOCATION_ONFIELD,0,1,nil,e:GetHandler())
end
function s.posfilter(c)
	return (c:IsPosition(POS_ATTACK) and c:IsCanChangePosition())
		or (c:IsPosition(POS_FACEDOWN_DEFENSE) and c:IsCanChangePosition())
		or (c:IsPosition(POS_FACEUP_DEFENSE) and c:IsCanTurnSet())
end
function s.postg(e,tp,eg,ep,ev,re,r,rp,chk)
	if chk==0 then return s.poscon(e,tp) and Duel.IsExistingMatchingCard(s.posfilter,tp,LOCATION_MZONE,0,1,nil) end
	Duel.SetOperationInfo(0,CATEGORY_POSITION,nil,1,tp,LOCATION_MZONE)
end
function s.posop(e,tp,eg,ep,ev,re,r,rp)
	if not s.poscon(e,tp) then return end
	Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_POSCHANGE)
	local tc=Duel.SelectMatchingCard(tp,s.posfilter,tp,LOCATION_MZONE,0,1,1,nil):GetFirst()
	if not tc then return end
	local pos=0
	if tc:IsPosition(POS_FACEDOWN_DEFENSE) then
		pos=POS_FACEUP_DEFENSE
	elseif tc:IsPosition(POS_FACEUP_DEFENSE) then
		pos=POS_FACEDOWN_DEFENSE
	else
		local can_set=tc:IsCanTurnSet()
		local can_faceup=tc:IsCanChangePosition()
		if can_set and can_faceup then
			pos=Duel.SelectPosition(tp,tc,POS_FACEUP_DEFENSE+POS_FACEDOWN_DEFENSE)
		elseif can_set then
			pos=POS_FACEDOWN_DEFENSE
		else
			pos=POS_FACEUP_DEFENSE
		end
	end
	if Duel.ChangePosition(tc,pos)>0 and Duel.IsExistingMatchingCard(Card.IsAbleToHand,tp,LOCATION_MZONE,LOCATION_MZONE,1,nil)
		and Duel.SelectYesNo(tp,aux.Stringid(STRING_ID,2)) then
		Duel.BreakEffect()
		Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_RTOHAND)
		local rc=Duel.SelectMatchingCard(tp,Card.IsAbleToHand,tp,LOCATION_MZONE,LOCATION_MZONE,1,1,nil):GetFirst()
		if rc then Duel.SendtoHand(rc,nil,REASON_EFFECT) end
	end
end
function s.setcon(e,tp,eg,ep,ev,re,r,rp)
	local rc=re:GetHandler()
	return rp==tp and re:GetActivateLocation()==LOCATION_HAND and rc:IsType(TYPE_MONSTER) and rc:IsSetCard(SET_GHOSTRICK) and rc:IsLevel(1)
end
function s.settg(e,tp,eg,ep,ev,re,r,rp,chk)
	local c=e:GetHandler()
	if chk==0 then return Duel.GetLocationCount(tp,LOCATION_SZONE)>0 and c:IsSSetable() end
	Duel.SetOperationInfo(0,CATEGORY_LEAVE_GRAVE,c,1,tp,LOCATION_GRAVE)
end
function s.setop(e,tp,eg,ep,ev,re,r,rp)
	local c=e:GetHandler()
	if c:IsRelateToEffect(e) and Duel.GetLocationCount(tp,LOCATION_SZONE)>0 and c:IsSSetable() and Duel.SSet(tp,c)>0 then
		local e1=Effect.CreateEffect(c)
		e1:SetType(EFFECT_TYPE_SINGLE)
		e1:SetProperty(EFFECT_FLAG_CANNOT_DISABLE)
		e1:SetCode(EFFECT_LEAVE_FIELD_REDIRECT)
		e1:SetReset(RESET_EVENT+RESETS_REDIRECT)
		e1:SetValue(LOCATION_REMOVED)
		c:RegisterEffect(e1,true)
	end
end


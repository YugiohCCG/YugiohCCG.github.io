--Charmelia Beast
local s,id=GetID()
local SET_CHARMELIA=0x12b1
function s.initial_effect(c)
	--Activate
	local e1=Effect.CreateEffect(c)
	e1:SetType(EFFECT_TYPE_ACTIVATE)
	e1:SetCode(EVENT_FREE_CHAIN)
	c:RegisterEffect(e1)
	--Your "Charmelia" monsters cannot be targeted while you control a Ritual Monster
	local e2=Effect.CreateEffect(c)
	e2:SetType(EFFECT_TYPE_FIELD)
	e2:SetCode(EFFECT_CANNOT_BE_EFFECT_TARGET)
	e2:SetRange(LOCATION_SZONE)
	e2:SetTargetRange(LOCATION_MZONE,0)
	e2:SetCondition(s.tgcon)
	e2:SetTarget(s.charmfilter)
	e2:SetValue(aux.tgoval)
	c:RegisterEffect(e2)
	--The first "Charmelia" monster destruction each turn is prevented
	local e3=Effect.CreateEffect(c)
	e3:SetType(EFFECT_TYPE_FIELD)
	e3:SetCode(EFFECT_INDESTRUCTABLE_COUNT)
	e3:SetRange(LOCATION_SZONE)
	e3:SetTargetRange(LOCATION_MZONE,0)
	e3:SetTarget(s.charmfilter)
	e3:SetCountLimit(1)
	e3:SetValue(s.indval)
	c:RegisterEffect(e3)
	--If sent by a "Charmelia" card effect: add this card, then draw
	local e4=Effect.CreateEffect(c)
	e4:SetDescription(aux.Stringid(id,0))
	e4:SetCategory(CATEGORY_TOHAND+CATEGORY_DRAW)
	e4:SetType(EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_O)
	e4:SetCode(EVENT_TO_GRAVE)
	e4:SetProperty(EFFECT_FLAG_DELAY)
	e4:SetCountLimit(1,id)
	e4:SetCondition(s.thcon)
	e4:SetTarget(s.thtg)
	e4:SetOperation(s.thop)
	c:RegisterEffect(e4)
end
s.listed_series={SET_CHARMELIA}
function s.ritfilter(c)
	return c:IsFaceup() and c:IsSetCard(SET_CHARMELIA) and c:IsType(TYPE_RITUAL)
end
function s.tgcon(e)
	return Duel.IsExistingMatchingCard(s.ritfilter,e:GetHandlerPlayer(),LOCATION_MZONE,0,1,nil)
end
function s.charmfilter(e,c)
	return c:IsFaceup() and c:IsSetCard(SET_CHARMELIA)
end
function s.indval(e,re,r,rp)
	return bit.band(r,REASON_BATTLE+REASON_EFFECT)~=0
end
function s.thcon(e,tp,eg,ep,ev,re,r,rp)
	return e:GetHandler():IsReason(REASON_EFFECT) and re and re:GetHandler():IsSetCard(SET_CHARMELIA)
end
function s.drawcount(tp)
	return Duel.GetMatchingGroupCount(s.ritfilter,tp,LOCATION_MZONE,0,nil)
end
function s.thtg(e,tp,eg,ep,ev,re,r,rp,chk)
	local c=e:GetHandler()
	if chk==0 then return c:IsAbleToHand() and aux.NecroValleyFilter()(c) end
	Duel.SetOperationInfo(0,CATEGORY_TOHAND,c,1,tp,LOCATION_GRAVE)
	local ct=s.drawcount(tp)
	if ct>0 then
		Duel.SetOperationInfo(0,CATEGORY_DRAW,nil,0,tp,ct)
	end
end
function s.thop(e,tp,eg,ep,ev,re,r,rp)
	local c=e:GetHandler()
	if c:IsRelateToEffect(e) and aux.NecroValleyFilter()(c)
		and Duel.SendtoHand(c,nil,REASON_EFFECT)>0 then
		local ct=s.drawcount(tp)
		if ct>0 then
			Duel.BreakEffect()
			Duel.Draw(tp,ct,REASON_EFFECT)
		end
	end
end

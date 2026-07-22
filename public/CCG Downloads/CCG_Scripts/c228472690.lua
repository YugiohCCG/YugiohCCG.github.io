local s,id=GetID()
local STRING_ID=132472690
local SET_GHOSTRICK=0x8d
function s.initial_effect(c)
	aux.AddXyzProcedure(c,nil,4,2,s.ovfilter,aux.Stringid(STRING_ID,0),99,s.xyzop)
	c:EnableReviveLimit()
	local e1=Effect.CreateEffect(c)
	e1:SetDescription(aux.Stringid(STRING_ID,1))
	e1:SetCategory(CATEGORY_CONTROL+CATEGORY_POSITION)
	e1:SetType(EFFECT_TYPE_IGNITION)
	e1:SetRange(LOCATION_MZONE)
	e1:SetProperty(EFFECT_FLAG_CARD_TARGET)
	e1:SetCountLimit(1,id)
	e1:SetCost(s.setcost)
	e1:SetTarget(s.settg)
	e1:SetOperation(s.setop)
	c:RegisterEffect(e1)
	local e2=Effect.CreateEffect(c)
	e2:SetDescription(aux.Stringid(STRING_ID,2))
	e2:SetType(EFFECT_TYPE_IGNITION)
	e2:SetRange(LOCATION_MZONE)
	e2:SetProperty(EFFECT_FLAG_CARD_TARGET)
	e2:SetCountLimit(1,id+100)
	e2:SetTarget(s.attachtg)
	e2:SetOperation(s.attachop)
	c:RegisterEffect(e2)
end
function s.ovfilter(c)
	return c:IsFaceup() and c:IsSetCard(SET_GHOSTRICK) and c:IsType(TYPE_XYZ) and c:IsRankBelow(3)
end
function s.xyzop(e,tp,chk)
	if chk==0 then return Duel.GetFlagEffect(tp,id)==0 end
	Duel.RegisterFlagEffect(tp,id,RESET_PHASE+PHASE_END,EFFECT_FLAG_OATH,1)
end
function s.setcost(e,tp,eg,ep,ev,re,r,rp,chk)
	if chk==0 then return e:GetHandler():CheckRemoveOverlayCard(tp,1,REASON_COST) end
	e:GetHandler():RemoveOverlayCard(tp,1,1,REASON_COST)
end
function s.setfilter(c,tp)
	return c:IsFacedown() and not c:IsForbidden()
		and Duel.GetLocationCount(tp,(c:GetOriginalType()&TYPE_MONSTER)~=0 and LOCATION_MZONE or LOCATION_SZONE)>0
end
function s.settg(e,tp,eg,ep,ev,re,r,rp,chk,chkc)
	if chkc then return chkc:IsControler(1-tp) and chkc:IsOnField() and s.setfilter(chkc,tp) end
	if chk==0 then return Duel.IsExistingTarget(s.setfilter,tp,0,LOCATION_ONFIELD,1,nil,tp) end
	Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_SET)
	Duel.SelectTarget(tp,s.setfilter,tp,0,LOCATION_ONFIELD,1,1,nil,tp)
end
function s.setop(e,tp,eg,ep,ev,re,r,rp)
	local tc=Duel.GetFirstTarget()
	if not tc or not tc:IsRelateToEffect(e) or not tc:IsFacedown() then return end
	local ismonster=(tc:GetOriginalType()&TYPE_MONSTER)~=0
	local loc=ismonster and LOCATION_MZONE or LOCATION_SZONE
	if Duel.GetLocationCount(tp,loc)<=0 then return end
	local pos=ismonster and POS_FACEDOWN_DEFENSE or POS_FACEDOWN
	if Duel.MoveToField(tc,tp,tp,loc,pos,true) and ismonster then tc:SetStatus(STATUS_SET_TURN,false) end
end
function s.attachfilter(c,xc)
	return c~=xc and c:IsFaceup() and c:IsSetCard(SET_GHOSTRICK) and c:IsType(TYPE_XYZ)
end
function s.attachtg(e,tp,eg,ep,ev,re,r,rp,chk,chkc)
	local c=e:GetHandler()
	if chkc then return chkc:IsControler(tp) and chkc:IsLocation(LOCATION_MZONE) and s.attachfilter(chkc,c) end
	if chk==0 then return c:IsCanOverlay() and Duel.IsExistingTarget(s.attachfilter,tp,LOCATION_MZONE,0,1,c,c) end
	Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_XMATERIAL)
	Duel.SelectTarget(tp,s.attachfilter,tp,LOCATION_MZONE,0,1,1,c,c)
end
function s.attachop(e,tp,eg,ep,ev,re,r,rp)
	local c=e:GetHandler()
	local tc=Duel.GetFirstTarget()
	if not c:IsRelateToEffect(e) or not c:IsCanOverlay() or not tc or not tc:IsRelateToEffect(e)
		or tc:IsImmuneToEffect(e) then return end
	local og=c:GetOverlayGroup()
	if #og>0 then Duel.Overlay(tc,og) end
	Duel.Overlay(tc,c)
end

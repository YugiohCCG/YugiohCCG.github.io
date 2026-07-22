local s,id=GetID()
local STRING_ID=133335848
local SET_GHOSTRICK=0x8d
function s.initial_effect(c)
	aux.AddXyzProcedureLevelFree(c,s.mfilter,s.xyzcheck,2,99)
	c:EnableReviveLimit()
	local e1=Effect.CreateEffect(c)
	e1:SetType(EFFECT_TYPE_SINGLE)
	e1:SetCode(EFFECT_UPDATE_DEFENSE)
	e1:SetProperty(EFFECT_FLAG_SINGLE_RANGE)
	e1:SetRange(LOCATION_MZONE)
	e1:SetValue(s.defval)
	c:RegisterEffect(e1)
	local e2=Effect.CreateEffect(c)
	e2:SetDescription(aux.Stringid(STRING_ID,0))
	e2:SetType(EFFECT_TYPE_QUICK_O)
	e2:SetCode(EVENT_FREE_CHAIN)
	e2:SetRange(LOCATION_MZONE)
	e2:SetHintTiming(0,TIMINGS_CHECK_MONSTER+TIMING_END_PHASE)
	e2:SetCondition(function(e,tp) return Duel.IsTurnPlayer(1-tp) end)
	e2:SetTarget(s.ovtg)
	e2:SetOperation(s.ovop)
	c:RegisterEffect(e2)
	local e3=Effect.CreateEffect(c)
	e3:SetDescription(aux.Stringid(STRING_ID,1))
	e3:SetCategory(CATEGORY_ATKCHANGE)
	e3:SetType(EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_O)
	e3:SetCode(EVENT_TO_GRAVE)
	e3:SetProperty(EFFECT_FLAG_DELAY+EFFECT_FLAG_CARD_TARGET)
	e3:SetTarget(s.atktg)
	e3:SetOperation(s.atkop)
	c:RegisterEffect(e3)
end
function s.mfilter(c) return c:IsLevel(1) end
function s.xyzcheck(g) return g:IsExists(Card.IsSetCard,1,nil,SET_GHOSTRICK) end
function s.defval(e,c)
	return Duel.GetMatchingGroupCount(Card.IsSetCard,c:GetControler(),LOCATION_GRAVE,0,nil,SET_GHOSTRICK)*200
end
function s.deckfilter(c) return c:IsSetCard(SET_GHOSTRICK) and c:IsCanOverlay() end
function s.nextfilter(c,xc)
	return c~=xc and c:IsFaceup() and c:IsSetCard(SET_GHOSTRICK) and c:IsType(TYPE_XYZ) and c:IsRankBelow(3)
end
function s.ovtg(e,tp,eg,ep,ev,re,r,rp,chk)
	if chk==0 then return Duel.IsExistingMatchingCard(s.deckfilter,tp,LOCATION_DECK,0,1,nil)
		and Duel.IsExistingMatchingCard(s.nextfilter,tp,LOCATION_MZONE,0,1,e:GetHandler(),e:GetHandler()) end
end
function s.ovop(e,tp,eg,ep,ev,re,r,rp)
	local c=e:GetHandler()
	if not c:IsRelateToEffect(e) then return end
	Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_XMATERIAL)
	local mc=Duel.SelectMatchingCard(tp,s.deckfilter,tp,LOCATION_DECK,0,1,1,nil):GetFirst()
	if not mc then return end
	Duel.Overlay(c,mc)
	if not mc:IsLocation(LOCATION_OVERLAY) then return end
	Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_TARGET)
	local xc=Duel.SelectMatchingCard(tp,s.nextfilter,tp,LOCATION_MZONE,0,1,1,c,c):GetFirst()
	if not xc then return end
	local og=c:GetOverlayGroup()
	if #og>0 then Duel.Overlay(xc,og) end
	Duel.Overlay(xc,c)
	-- The source text asks to make all of the selected Xyz Monster's effects Quick Effects.
	-- Omega has no generic API to convert arbitrary ignition/trigger effects at runtime.
	Duel.RegisterFlagEffect(tp,id+200,RESET_PHASE+PHASE_END,0,1,xc:GetFieldID())
end
function s.atkfilter(c) return c:IsSetCard(SET_GHOSTRICK) and c:IsType(TYPE_MONSTER) and c:GetTextAttack()>=0 end
function s.atktg(e,tp,eg,ep,ev,re,r,rp,chk,chkc)
	if chkc then return chkc:IsControler(tp) and chkc:IsLocation(LOCATION_MZONE+LOCATION_GRAVE) and s.atkfilter(chkc) end
	if chk==0 then return Duel.IsExistingTarget(aux.NecroValleyFilter(s.atkfilter),tp,LOCATION_MZONE+LOCATION_GRAVE,0,1,nil) end
	Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_TARGET)
	Duel.SelectTarget(tp,aux.NecroValleyFilter(s.atkfilter),tp,LOCATION_MZONE+LOCATION_GRAVE,0,1,1,nil)
end
function s.atkop(e,tp,eg,ep,ev,re,r,rp)
	local tc=Duel.GetFirstTarget()
	if not tc or not tc:IsRelateToEffect(e) or not aux.NecroValleyFilter(s.atkfilter)(tc) then return end
	local val=math.max(0,tc:GetTextAttack())
	local g=Duel.GetMatchingGroup(Card.IsFaceup,tp,0,LOCATION_MZONE,nil)
	for oc in aux.Next(g) do
		local e1=Effect.CreateEffect(e:GetHandler())
		e1:SetType(EFFECT_TYPE_SINGLE)
		e1:SetCode(EFFECT_UPDATE_ATTACK)
		e1:SetValue(-val)
		e1:SetReset(RESET_EVENT+RESETS_STANDARD)
		oc:RegisterEffect(e1)
	end
end

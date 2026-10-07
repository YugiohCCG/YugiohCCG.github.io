--Ghostrick Camella
local s,id=GetID()
local STRING_ID=133687149
local SET_GHOSTRICK=0x8d
function s.initial_effect(c)
	aux.AddXyzProcedureLevelFree(c,s.mfilter,s.xyzcheck,2,2)
	c:EnableReviveLimit()
	--Search 1 Ghostrick monster
	local e1=Effect.CreateEffect(c)
	e1:SetDescription(aux.Stringid(STRING_ID,0))
	e1:SetCategory(CATEGORY_TOHAND+CATEGORY_SEARCH)
	e1:SetType(EFFECT_TYPE_IGNITION)
	e1:SetRange(LOCATION_MZONE)
	e1:SetCountLimit(1)
	e1:SetCost(s.thcost)
	e1:SetTarget(s.thtg)
	e1:SetOperation(s.thop)
	c:RegisterEffect(e1)
	--Attach up to 2 from GY/banished to a Ghostrick Xyz monster
	local e2=Effect.CreateEffect(c)
	e2:SetDescription(aux.Stringid(STRING_ID,1))
	e2:SetCategory(CATEGORY_LEAVE_GRAVE)
	e2:SetType(EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_O)
	e2:SetCode(EVENT_TO_GRAVE)
	e2:SetProperty(EFFECT_FLAG_DELAY+EFFECT_FLAG_CARD_TARGET)
	e2:SetTarget(s.ovtg)
	e2:SetOperation(s.ovop)
	c:RegisterEffect(e2)
end
function s.mfilter(c) return c:IsLevel(2) end
function s.xyzcheck(g) return g:IsExists(Card.IsSetCard,1,nil,SET_GHOSTRICK) end
function s.thcost(e,tp,eg,ep,ev,re,r,rp,chk)
	if chk==0 then return e:GetHandler():CheckRemoveOverlayCard(tp,1,REASON_COST) end
	e:GetHandler():RemoveOverlayCard(tp,1,1,REASON_COST)
end
function s.thfilter(c) return c:IsSetCard(SET_GHOSTRICK) and c:IsType(TYPE_MONSTER) and c:IsAbleToHand() end
function s.thtg(e,tp,eg,ep,ev,re,r,rp,chk)
	if chk==0 then return Duel.IsExistingMatchingCard(s.thfilter,tp,LOCATION_DECK,0,1,nil) end
	Duel.SetOperationInfo(0,CATEGORY_TOHAND,nil,1,tp,LOCATION_DECK)
end
function s.thop(e,tp,eg,ep,ev,re,r,rp)
	Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_ATOHAND)
	local tc=Duel.SelectMatchingCard(tp,s.thfilter,tp,LOCATION_DECK,0,1,1,nil):GetFirst()
	if tc and Duel.SendtoHand(tc,nil,REASON_EFFECT)>0 then Duel.ConfirmCards(1-tp,tc) end
end
function s.ovfilter(c)
	return c:IsFaceupEx() and not c:IsCode(id) and c:IsSetCard(SET_GHOSTRICK) and c:IsCanOverlay()
end
function s.xyzfilter(c) return c:IsFaceup() and c:IsSetCard(SET_GHOSTRICK) and c:IsType(TYPE_XYZ) end
function s.ovtg(e,tp,eg,ep,ev,re,r,rp,chk,chkc)
	if chkc then return chkc:IsControler(tp) and chkc:IsLocation(LOCATION_GRAVE+LOCATION_REMOVED) and s.ovfilter(chkc) end
	if chk==0 then return Duel.IsExistingTarget(aux.NecroValleyFilter(s.ovfilter),tp,LOCATION_GRAVE+LOCATION_REMOVED,0,1,nil)
		and Duel.IsExistingMatchingCard(s.xyzfilter,tp,LOCATION_MZONE,0,1,nil) end
	Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_XMATERIAL)
	local g=Duel.SelectTarget(tp,aux.NecroValleyFilter(s.ovfilter),tp,LOCATION_GRAVE+LOCATION_REMOVED,0,1,2,nil)
	Duel.SetOperationInfo(0,CATEGORY_LEAVE_GRAVE,g,#g,0,0)
end
function s.ovop(e,tp,eg,ep,ev,re,r,rp)
	local g=Duel.GetTargetCards(e):Filter(s.ovfilter,nil)
	if #g==0 then return end
	Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_TARGET)
	local xc=Duel.SelectMatchingCard(tp,s.xyzfilter,tp,LOCATION_MZONE,0,1,1,nil):GetFirst()
	if not xc or xc:IsImmuneToEffect(e) then return end
	Duel.Overlay(xc,g)
end


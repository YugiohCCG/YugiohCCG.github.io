--BRILLIANCE OF THE GRAND BLUE
local s,id=GetID()
local SET_GRAND_BLUE=0x67ee
local CARD_UMI=22702055
local CARD_CITY_GRAND_BLUE=259679619
function s.initial_effect(c)
	--Add 1 "Grand Blue" card, then optionally send 1 "Grand Blue" card to the GY if you control "Umi"
	local e1=Effect.CreateEffect(c)
	e1:SetDescription(aux.Stringid(id,0))
	e1:SetCategory(CATEGORY_TOHAND+CATEGORY_SEARCH+CATEGORY_TOGRAVE)
	e1:SetType(EFFECT_TYPE_ACTIVATE)
	e1:SetCode(EVENT_FREE_CHAIN)
	e1:SetCountLimit(1,id)
	e1:SetTarget(s.thtg)
	e1:SetOperation(s.thop)
	c:RegisterEffect(e1)
	--If a "Grand Blue" monster leaves your GY by an opponent's card effect: add this card to your hand
	local e2=Effect.CreateEffect(c)
	e2:SetDescription(aux.Stringid(id,1))
	e2:SetCategory(CATEGORY_TOHAND+CATEGORY_HANDES)
	e2:SetType(EFFECT_TYPE_FIELD+EFFECT_TYPE_TRIGGER_O)
	e2:SetCode(EVENT_LEAVE_GRAVE)
	e2:SetRange(LOCATION_GRAVE)
	e2:SetProperty(EFFECT_FLAG_DELAY)
	e2:SetCountLimit(1,id+100)
	e2:SetCondition(s.gycon)
	e2:SetTarget(s.gytg)
	e2:SetOperation(s.gyop)
	c:RegisterEffect(e2)
end
function s.thfilter(c)
	return c:IsSetCard(SET_GRAND_BLUE) and c:IsAbleToHand()
end
function s.tgfilter(c)
	return c:IsSetCard(SET_GRAND_BLUE) and c:IsAbleToGrave()
end
function s.umifilter(c)
	return c:IsFaceup() and (c:IsCode(CARD_UMI) or c:IsCode(CARD_CITY_GRAND_BLUE))
end
function s.thtg(e,tp,eg,ep,ev,re,r,rp,chk)
	if chk==0 then return Duel.IsExistingMatchingCard(s.thfilter,tp,LOCATION_DECK,0,1,nil) end
	Duel.SetOperationInfo(0,CATEGORY_TOHAND,nil,1,tp,LOCATION_DECK)
end
function s.thop(e,tp,eg,ep,ev,re,r,rp)
	Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_ATOHAND)
	local g=Duel.SelectMatchingCard(tp,s.thfilter,tp,LOCATION_DECK,0,1,1,nil)
	if #g==0 or Duel.SendtoHand(g,nil,REASON_EFFECT)==0 then return end
	Duel.ConfirmCards(1-tp,g)
	if Duel.IsExistingMatchingCard(s.umifilter,tp,LOCATION_ONFIELD,0,1,nil)
		and Duel.IsExistingMatchingCard(s.tgfilter,tp,LOCATION_HAND+LOCATION_DECK,0,1,nil)
		and Duel.SelectYesNo(tp,aux.Stringid(id,2)) then
		Duel.BreakEffect()
		Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_TOGRAVE)
		local sg=Duel.SelectMatchingCard(tp,s.tgfilter,tp,LOCATION_HAND+LOCATION_DECK,0,1,1,nil)
		if #sg>0 then
			Duel.SendtoGrave(sg,REASON_EFFECT)
		end
	end
end
function s.leavefilter(c,tp)
	return c:IsPreviousControler(tp) and c:IsPreviousLocation(LOCATION_GRAVE)
		and c:IsType(TYPE_MONSTER) and c:IsSetCard(SET_GRAND_BLUE)
		and c:IsReason(REASON_EFFECT)
end
function s.gycon(e,tp,eg,ep,ev,re,r,rp)
	return rp==1-tp and eg:IsExists(s.leavefilter,1,nil,tp)
end
function s.gytg(e,tp,eg,ep,ev,re,r,rp,chk)
	local c=e:GetHandler()
	if chk==0 then return aux.NecroValleyFilter()(c) and c:IsAbleToHand() end
	Duel.SetOperationInfo(0,CATEGORY_TOHAND,c,1,0,0)
end
function s.gyop(e,tp,eg,ep,ev,re,r,rp)
	local c=e:GetHandler()
	if not (c:IsRelateToEffect(e) and aux.NecroValleyFilter()(c)) then return end
	if Duel.SendtoHand(c,nil,REASON_EFFECT)==0 then return end
	Duel.ConfirmCards(1-tp,c)
	if Duel.IsExistingMatchingCard(Card.IsDiscardable,tp,LOCATION_HAND,0,1,nil)
		and Duel.SelectYesNo(tp,aux.Stringid(id,3)) then
		Duel.BreakEffect()
		Duel.DiscardHand(tp,Card.IsDiscardable,1,1,REASON_EFFECT+REASON_DISCARD)
	end
end

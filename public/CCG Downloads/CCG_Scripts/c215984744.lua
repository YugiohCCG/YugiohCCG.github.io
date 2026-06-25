--Vir Pedicae Mortis - Entity's Happy Servant
local s,id=GetID()
local SET_VIR_PEDICAE_MORTIS=0x39e2
local CARD_PEDICAES_PAPA=241868535
local CARD_BEAR_TRAP=251699681
local CARD_RECOLLECTION_STATIC=211086520
local CARD_RECOLLECTION_IRON=234984156
local CARD_RECOLLECTION_MINE=231872299
local CARD_RECOLLECTION_KABOOM=241447408
function s.initial_effect(c)
	--If Normal or Special Summoned: add 1 "Recollection" and 1 "Bear Trap" or "Mortis" card
	local e1=Effect.CreateEffect(c)
	e1:SetDescription(aux.Stringid(id,0))
	e1:SetCategory(CATEGORY_TOHAND+CATEGORY_SEARCH)
	e1:SetType(EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_O)
	e1:SetCode(EVENT_SUMMON_SUCCESS)
	e1:SetProperty(EFFECT_FLAG_DELAY)
	e1:SetCountLimit(1,id)
	e1:SetCost(s.thcost)
	e1:SetTarget(s.thtg)
	e1:SetOperation(s.thop)
	c:RegisterEffect(e1)
	local e2=e1:Clone()
	e2:SetCode(EVENT_SPSUMMON_SUCCESS)
	c:RegisterEffect(e2)
	--Protect "Recollection" cards and "Mine" Field Spells
	local e3=Effect.CreateEffect(c)
	e3:SetType(EFFECT_TYPE_FIELD)
	e3:SetCode(EFFECT_INDESTRUCTABLE_EFFECT)
	e3:SetRange(LOCATION_MZONE)
	e3:SetTargetRange(LOCATION_ONFIELD,0)
	e3:SetCondition(s.indcon)
	e3:SetTarget(s.indtg)
	e3:SetValue(s.indval)
	c:RegisterEffect(e3)
end
s.listed_series={SET_VIR_PEDICAE_MORTIS}
s.listed_names={CARD_PEDICAES_PAPA,CARD_BEAR_TRAP,CARD_RECOLLECTION_STATIC,CARD_RECOLLECTION_IRON,CARD_RECOLLECTION_MINE,CARD_RECOLLECTION_KABOOM}
function s.isrecollection(c)
	return c:IsCode(CARD_RECOLLECTION_STATIC,CARD_RECOLLECTION_IRON,CARD_RECOLLECTION_MINE,CARD_RECOLLECTION_KABOOM)
end
function s.reccontrol(c)
	return s.isrecollection(c) and c:IsAbleToGraveAsCost()
end
function s.thcost(e,tp,eg,ep,ev,re,r,rp,chk)
	local b1=Duel.IsExistingMatchingCard(Card.IsDiscardable,tp,LOCATION_HAND,0,1,nil)
	local b2=Duel.IsExistingMatchingCard(s.reccontrol,tp,LOCATION_ONFIELD,0,1,nil)
	if chk==0 then return b1 or b2 end
	local op=0
	if b1 and b2 then
		op=Duel.SelectOption(tp,aux.Stringid(id,1),aux.Stringid(id,2))
	elseif b2 then
		Duel.SelectOption(tp,aux.Stringid(id,2))
		op=1
	else
		Duel.SelectOption(tp,aux.Stringid(id,1))
	end
	if op==0 then
		Duel.DiscardHand(tp,Card.IsDiscardable,1,1,REASON_COST+REASON_DISCARD)
	else
		Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_TOGRAVE)
		local g=Duel.SelectMatchingCard(tp,s.reccontrol,tp,LOCATION_ONFIELD,0,1,1,nil)
		Duel.SendtoGrave(g,REASON_COST)
	end
end
function s.recfilter(c)
	return s.isrecollection(c) and c:IsAbleToHand()
end
function s.secondfilter(c)
	return (c:IsCode(CARD_BEAR_TRAP) or (c:IsSetCard(SET_VIR_PEDICAE_MORTIS) and not s.isrecollection(c))) and c:IsAbleToHand()
end
function s.thtg(e,tp,eg,ep,ev,re,r,rp,chk)
	if chk==0 then return Duel.IsExistingMatchingCard(s.recfilter,tp,LOCATION_DECK,0,1,nil)
		and Duel.IsExistingMatchingCard(s.secondfilter,tp,LOCATION_DECK,0,1,nil) end
	Duel.SetOperationInfo(0,CATEGORY_TOHAND,nil,2,tp,LOCATION_DECK)
end
function s.thop(e,tp,eg,ep,ev,re,r,rp)
	Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_ATOHAND)
	local g1=Duel.SelectMatchingCard(tp,s.recfilter,tp,LOCATION_DECK,0,1,1,nil)
	if #g1==0 then return end
	Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_ATOHAND)
	local g2=Duel.SelectMatchingCard(tp,s.secondfilter,tp,LOCATION_DECK,0,1,1,nil)
	if #g2==0 then return end
	g1:Merge(g2)
	if Duel.SendtoHand(g1,nil,REASON_EFFECT)>0 then
		Duel.ConfirmCards(1-tp,g1)
	end
end
function s.papafilter(c)
	return c:IsFaceup() and c:IsCode(CARD_PEDICAES_PAPA)
end
function s.indcon(e)
	local tp=e:GetHandlerPlayer()
	return Duel.IsExistingMatchingCard(s.papafilter,tp,LOCATION_MZONE,0,1,nil)
end
function s.indtg(e,c)
	return c:IsFaceup() and (s.isrecollection(c) or (c:IsCode(CARD_RECOLLECTION_MINE) and c:IsType(TYPE_FIELD)))
end
function s.indval(e,re,rp)
	return rp==1-e:GetHandlerPlayer()
end

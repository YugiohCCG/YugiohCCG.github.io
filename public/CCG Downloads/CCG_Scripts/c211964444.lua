--PRIESTESS OF NEPHTHYS
local s,id=GetID()
local SET_NEPHTHYS=0x11f
function s.initial_effect(c)
	c:EnableReviveLimit()
	--If Special Summoned: destroy 1 "Nephthys" monster from your Deck
	local e1=Effect.CreateEffect(c)
	e1:SetDescription(aux.Stringid(id,0))
	e1:SetCategory(CATEGORY_DESTROY)
	e1:SetType(EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_O)
	e1:SetProperty(EFFECT_FLAG_DELAY)
	e1:SetCode(EVENT_SPSUMMON_SUCCESS)
	e1:SetCountLimit(1,id)
	e1:SetTarget(s.destg)
	e1:SetOperation(s.desop)
	c:RegisterEffect(e1)
	--Shuffle this card from the hand into the Deck; add 1 "Nephthys" Spell/Trap
	local e2=Effect.CreateEffect(c)
	e2:SetDescription(aux.Stringid(id,1))
	e2:SetCategory(CATEGORY_TODECK+CATEGORY_TOHAND+CATEGORY_SEARCH)
	e2:SetType(EFFECT_TYPE_IGNITION)
	e2:SetRange(LOCATION_HAND)
	e2:SetCountLimit(1,id+100)
	e2:SetCost(s.thcost)
	e2:SetTarget(s.thtg)
	e2:SetOperation(s.thop)
	c:RegisterEffect(e2)
end
s.listed_series={SET_NEPHTHYS}
function s.desfilter(c,e)
	return c:IsSetCard(SET_NEPHTHYS) and c:IsType(TYPE_MONSTER) and c:IsDestructable(e)
end
function s.destg(e,tp,eg,ep,ev,re,r,rp,chk)
	if chk==0 then return Duel.IsExistingMatchingCard(s.desfilter,tp,LOCATION_DECK,0,1,nil,e) end
	Duel.SetOperationInfo(0,CATEGORY_DESTROY,nil,1,tp,LOCATION_DECK)
end
function s.desop(e,tp,eg,ep,ev,re,r,rp)
	if not Duel.IsExistingMatchingCard(s.desfilter,tp,LOCATION_DECK,0,1,nil,e) then return end
	Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_CONFIRM)
	local tc=Duel.SelectMatchingCard(tp,s.desfilter,tp,LOCATION_DECK,0,1,1,nil,e):GetFirst()
	if not tc then return end
	Duel.ConfirmCards(1-tp,tc)
	if Duel.Destroy(tc,REASON_EFFECT,LOCATION_GRAVE)==0 then return end
	Duel.BreakEffect()
	local te,ceg,cep,cev,cre,cr,crp=tc:CheckActivateEffect(true,true,true)
	if not te then return end
	local tg=te:GetTarget()
	local op=te:GetOperation()
	if tg then
		tg(te,tp,ceg,cep,cev,cre,cr,crp,1)
	end
	if op then
		op(te,tp,ceg,cep,cev,cre,cr,crp)
	end
end
function s.thcost(e,tp,eg,ep,ev,re,r,rp,chk)
	local c=e:GetHandler()
	if chk==0 then return c:IsAbleToDeckAsCost() end
	Duel.SendtoDeck(c,nil,SEQ_DECKSHUFFLE,REASON_COST)
end
function s.thfilter(c)
	return c:IsSetCard(SET_NEPHTHYS) and c:IsType(TYPE_SPELL+TYPE_TRAP) and c:IsAbleToHand()
end
function s.thtg(e,tp,eg,ep,ev,re,r,rp,chk)
	if chk==0 then return Duel.IsExistingMatchingCard(aux.NecroValleyFilter(s.thfilter),tp,LOCATION_DECK+LOCATION_GRAVE,0,1,nil) end
	Duel.SetOperationInfo(0,CATEGORY_TOHAND,nil,1,tp,LOCATION_DECK+LOCATION_GRAVE)
end
function s.thop(e,tp,eg,ep,ev,re,r,rp)
	Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_ATOHAND)
	local g=Duel.SelectMatchingCard(tp,aux.NecroValleyFilter(s.thfilter),tp,LOCATION_DECK+LOCATION_GRAVE,0,1,1,nil)
	if #g>0 and Duel.SendtoHand(g,nil,REASON_EFFECT)>0 then
		Duel.ConfirmCards(1-tp,g)
	end
end

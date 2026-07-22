--Charmelia Deal
local s,id=GetID()
local STRING_ID=133758604
local SET_CHARMELIA=0x12b1
local CARD_CHARMELIA_PRAY=259241946
function s.initial_effect(c)
	--Activate and add a "Charmelia" Ritual Monster and/or Ritual Spell
	local e1=Effect.CreateEffect(c)
	e1:SetDescription(aux.Stringid(STRING_ID,0))
	e1:SetCategory(CATEGORY_TOHAND+CATEGORY_SEARCH)
	e1:SetType(EFFECT_TYPE_ACTIVATE)
	e1:SetCode(EVENT_FREE_CHAIN)
	e1:SetCountLimit(1,id)
	e1:SetTarget(s.thtg)
	e1:SetOperation(s.thop)
	c:RegisterEffect(e1)
	--"Charmelia" monsters gain ATK/DEF
	local e2=Effect.CreateEffect(c)
	e2:SetType(EFFECT_TYPE_FIELD)
	e2:SetCode(EFFECT_UPDATE_ATTACK)
	e2:SetRange(LOCATION_SZONE)
	e2:SetTargetRange(LOCATION_MZONE,0)
	e2:SetTarget(s.statfilter)
	e2:SetValue(400)
	c:RegisterEffect(e2)
	local e3=e2:Clone()
	e3:SetCode(EFFECT_UPDATE_DEFENSE)
	c:RegisterEffect(e3)
	--If sent to the GY by a "Charmelia" monster effect: place this card
	local e4=Effect.CreateEffect(c)
	e4:SetDescription(aux.Stringid(STRING_ID,1))
	e4:SetCategory(CATEGORY_LEAVE_GRAVE)
	e4:SetType(EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_O)
	e4:SetCode(EVENT_TO_GRAVE)
	e4:SetProperty(EFFECT_FLAG_DELAY)
	e4:SetCountLimit(1,id+100)
	e4:SetCondition(s.plcon)
	e4:SetTarget(s.pltg)
	e4:SetOperation(s.plop)
	c:RegisterEffect(e4)
end
s.listed_series={SET_CHARMELIA}
s.listed_names={CARD_CHARMELIA_PRAY}
function s.ritmonster(c)
	return c:IsSetCard(SET_CHARMELIA) and c:IsType(TYPE_MONSTER) and c:IsType(TYPE_RITUAL)
		and c:IsAbleToHand()
end
function s.ritspell(c)
	return c:IsSetCard(SET_CHARMELIA) and c:IsType(TYPE_SPELL) and c:IsAbleToHand()
		and (c:IsType(TYPE_RITUAL) or c:IsCode(CARD_CHARMELIA_PRAY))
end
function s.thfilter(c)
	return s.ritmonster(c) or s.ritspell(c)
end
function s.thcheck(g)
	return g:FilterCount(s.ritmonster,nil)<=1 and g:FilterCount(s.ritspell,nil)<=1
end
function s.thtg(e,tp,eg,ep,ev,re,r,rp,chk)
	if chk==0 then return Duel.IsExistingMatchingCard(s.thfilter,tp,LOCATION_DECK,0,1,nil) end
	Duel.SetOperationInfo(0,CATEGORY_TOHAND,nil,1,tp,LOCATION_DECK)
end
function s.thop(e,tp,eg,ep,ev,re,r,rp)
	local g=Duel.GetMatchingGroup(s.thfilter,tp,LOCATION_DECK,0,nil)
	if #g==0 then return end
	Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_ATOHAND)
	local sg=g:SelectSubGroup(tp,s.thcheck,false,1,math.min(2,#g))
	if sg and #sg>0 then
		Duel.SendtoHand(sg,nil,REASON_EFFECT)
		Duel.ConfirmCards(1-tp,sg)
	end
end
function s.statfilter(e,c)
	return c:IsFaceup() and c:IsSetCard(SET_CHARMELIA)
end
function s.plcon(e,tp,eg,ep,ev,re,r,rp)
	return e:GetHandler():IsReason(REASON_EFFECT) and re
		and re:GetHandler():IsSetCard(SET_CHARMELIA) and re:GetHandler():IsType(TYPE_MONSTER)
end
function s.pltg(e,tp,eg,ep,ev,re,r,rp,chk)
	local c=e:GetHandler()
	if chk==0 then return Duel.GetLocationCount(tp,LOCATION_SZONE)>0
		and aux.NecroValleyFilter()(c) end
	Duel.SetOperationInfo(0,CATEGORY_LEAVE_GRAVE,c,1,tp,LOCATION_GRAVE)
end
function s.plop(e,tp,eg,ep,ev,re,r,rp)
	local c=e:GetHandler()
	if Duel.GetLocationCount(tp,LOCATION_SZONE)>0 and c:IsRelateToEffect(e)
		and aux.NecroValleyFilter()(c) then
		Duel.MoveToField(c,tp,tp,LOCATION_SZONE,POS_FACEUP,true)
	end
end

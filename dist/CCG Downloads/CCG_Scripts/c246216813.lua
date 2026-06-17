--The Red Frute
local s,id=GetID()
local SET_FRUTE=0x813
local CARD_FRUTEONIA=246830897
function s.initial_effect(c)
	--Special Summon this card
	local e1=Effect.CreateEffect(c)
	e1:SetDescription(aux.Stringid(id,0))
	e1:SetCategory(CATEGORY_SPECIAL_SUMMON+CATEGORY_TOGRAVE)
	e1:SetType(EFFECT_TYPE_IGNITION)
	e1:SetRange(LOCATION_HAND)
	e1:SetCountLimit(1,id)
	e1:SetCondition(s.spcon)
	e1:SetTarget(s.sptg)
	e1:SetOperation(s.spop)
	c:RegisterEffect(e1)
	--If Tributed: add "Fruteonia" or Set 1 "Frute" Spell/Trap
	local e2=Effect.CreateEffect(c)
	e2:SetDescription(aux.Stringid(id,1))
	e2:SetCategory(CATEGORY_TOHAND+CATEGORY_SEARCH+CATEGORY_SSET)
	e2:SetType(EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_O)
	e2:SetCode(EVENT_RELEASE)
	e2:SetProperty(EFFECT_FLAG_DELAY)
	e2:SetCountLimit(1,id+100)
	e2:SetTarget(s.thtg)
	e2:SetOperation(s.thop)
	c:RegisterEffect(e2)
end
function s.ctrlfilter(c)
	return c:IsFaceup() and c:IsSetCard(SET_FRUTE)
end
function s.spcon(e,tp,eg,ep,ev,re,r,rp)
	return not Duel.IsExistingMatchingCard(Card.IsFaceup,tp,LOCATION_MZONE,0,1,nil)
		or Duel.IsExistingMatchingCard(s.ctrlfilter,tp,LOCATION_ONFIELD,0,1,nil)
end
function s.tgfilter(c,tp)
	if not (c:IsSetCard(SET_FRUTE) and c:IsAbleToGrave()) then return false end
	local g=Duel.GetFieldGroup(tp,LOCATION_ONFIELD,0)
	return not g:IsExists(Card.IsCode,1,nil,c:GetCode())
end
function s.sptg(e,tp,eg,ep,ev,re,r,rp,chk)
	local c=e:GetHandler()
	if chk==0 then return Duel.GetLocationCount(tp,LOCATION_MZONE)>0
		and c:IsCanBeSpecialSummoned(e,0,tp,false,false) end
	Duel.SetOperationInfo(0,CATEGORY_SPECIAL_SUMMON,c,1,0,0)
	Duel.SetOperationInfo(0,CATEGORY_TOGRAVE,nil,1,tp,LOCATION_DECK)
end
function s.spop(e,tp,eg,ep,ev,re,r,rp)
	local c=e:GetHandler()
	if c:IsRelateToEffect(e) and Duel.SpecialSummon(c,0,tp,tp,false,false,POS_FACEUP)>0
		and Duel.IsExistingMatchingCard(s.tgfilter,tp,LOCATION_DECK,0,1,nil,tp)
		and Duel.SelectYesNo(tp,aux.Stringid(id,0)) then
		Duel.BreakEffect()
		Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_TOGRAVE)
		local g=Duel.SelectMatchingCard(tp,s.tgfilter,tp,LOCATION_DECK,0,1,1,nil,tp)
		if #g>0 then
			Duel.SendtoGrave(g,REASON_EFFECT)
		end
	end
end
function s.addfilter(c)
	return c:IsCode(CARD_FRUTEONIA) and c:IsAbleToHand()
end
function s.setfilter(c)
	return c:IsSetCard(SET_FRUTE) and c:IsType(TYPE_SPELL+TYPE_TRAP) and c:IsSSetable()
end
function s.thtg(e,tp,eg,ep,ev,re,r,rp,chk)
	local fd=e:GetHandler():IsPreviousPosition(POS_FACEDOWN_DEFENSE)
	local b1=Duel.IsExistingMatchingCard(s.addfilter,tp,LOCATION_DECK,0,1,nil)
	local b2=fd and Duel.GetLocationCount(tp,LOCATION_SZONE)>0
		and Duel.IsExistingMatchingCard(s.setfilter,tp,LOCATION_DECK,0,1,nil)
	if chk==0 then return b1 or b2 end
	if b1 and b2 then
		e:SetLabel(Duel.SelectOption(tp,aux.Stringid(id,2),aux.Stringid(id,3)))
	elseif b2 then
		e:SetLabel(1)
	else
		e:SetLabel(0)
	end
	if e:GetLabel()==0 then
		Duel.SetOperationInfo(0,CATEGORY_TOHAND,nil,1,tp,LOCATION_DECK)
	else
		Duel.SetOperationInfo(0,CATEGORY_SSET,nil,1,tp,LOCATION_DECK)
	end
end
function s.thop(e,tp,eg,ep,ev,re,r,rp)
	if e:GetLabel()==0 then
		Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_ATOHAND)
		local tc=Duel.SelectMatchingCard(tp,s.addfilter,tp,LOCATION_DECK,0,1,1,nil):GetFirst()
		if tc then
			Duel.SendtoHand(tc,nil,REASON_EFFECT)
			Duel.ConfirmCards(1-tp,tc)
		end
	else
		if Duel.GetLocationCount(tp,LOCATION_SZONE)<=0 then return end
		Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_SET)
		local tc=Duel.SelectMatchingCard(tp,s.setfilter,tp,LOCATION_DECK,0,1,1,nil):GetFirst()
		if tc then
			Duel.SSet(tp,tc)
		end
	end
end

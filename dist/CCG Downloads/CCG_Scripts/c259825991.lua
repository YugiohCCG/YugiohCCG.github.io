--Calcu Leet
local s,id=GetID()
local SET_LEET=0xfe88
local STRING_ID=id
function s.initial_effect(c)
	--Target a Cyberse monster; add a Cyberse monster with matching ATK/DEF, then maybe banish the target
	local e1=Effect.CreateEffect(c)
	e1:SetDescription(aux.Stringid(STRING_ID,0))
	e1:SetCategory(CATEGORY_TOHAND+CATEGORY_SEARCH+CATEGORY_REMOVE)
	e1:SetType(EFFECT_TYPE_IGNITION)
	e1:SetRange(LOCATION_MZONE)
	e1:SetProperty(EFFECT_FLAG_CARD_TARGET)
	e1:SetCountLimit(1,id)
	e1:SetTarget(s.thtg)
	e1:SetOperation(s.thop)
	c:RegisterEffect(e1)
end
s.listed_series={SET_LEET}
function s.defvalue(c)
	if c:IsType(TYPE_LINK) then return -2 end
	return c:GetDefense()
end
function s.haspositiveatkdef(c)
	return c:GetAttack()>0 or (not c:IsType(TYPE_LINK) and c:GetDefense()>0)
end
function s.tgfilter(c,e,tp)
	if not (c:IsFaceup() and c:IsRace(RACE_CYBERSE) and c:IsCanBeEffectTarget(e)) then return false end
	return Duel.IsExistingMatchingCard(s.thfilter,tp,LOCATION_DECK,0,1,nil,c:GetCode(),c:GetAttack(),s.defvalue(c))
end
function s.thfilter(c,code,atk,def)
	return c:IsRace(RACE_CYBERSE) and c:IsAbleToHand() and not c:IsCode(code)
		and c:GetAttack()==atk and s.defvalue(c)==def
end
function s.thtg(e,tp,eg,ep,ev,re,r,rp,chk,chkc)
	if chkc then return chkc:IsControler(tp) and chkc:IsLocation(LOCATION_MZONE) and s.tgfilter(chkc,e,tp) end
	if chk==0 then return Duel.IsExistingTarget(s.tgfilter,tp,LOCATION_MZONE,0,1,nil,e,tp) end
	Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_TARGET)
	local g=Duel.SelectTarget(tp,s.tgfilter,tp,LOCATION_MZONE,0,1,1,nil,e,tp)
	Duel.SetOperationInfo(0,CATEGORY_TOHAND,nil,1,tp,LOCATION_DECK)
	Duel.SetOperationInfo(0,CATEGORY_REMOVE,g,1,tp,LOCATION_MZONE)
end
function s.thop(e,tp,eg,ep,ev,re,r,rp)
	local tc=Duel.GetFirstTarget()
	if not (tc and tc:IsRelateToEffect(e) and tc:IsControler(tp)
		and tc:IsLocation(LOCATION_MZONE) and tc:IsFaceup()) then return end
	local code=tc:GetCode()
	local atk=tc:GetAttack()
	local def=s.defvalue(tc)
	Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_ATOHAND)
	local g=Duel.SelectMatchingCard(tp,s.thfilter,tp,LOCATION_DECK,0,1,1,nil,code,atk,def)
	local sc=g:GetFirst()
	if not sc then return end
	local should_banish=s.haspositiveatkdef(sc)
	Duel.SendtoHand(sc,nil,REASON_EFFECT)
	if sc:IsLocation(LOCATION_HAND) then
		Duel.ConfirmCards(1-tp,sc)
		if should_banish and tc:IsRelateToEffect(e) and tc:IsControler(tp)
			and tc:IsLocation(LOCATION_MZONE) and tc:IsAbleToRemove() then
			Duel.BreakEffect()
			Duel.Remove(tc,POS_FACEUP,REASON_EFFECT)
		end
	end
end

--Remembrance of the Melody
local s,id=GetID()
function s.initial_effect(c)
	--Return up to 3 banished Spells/Traps to the GY
	local e1=Effect.CreateEffect(c)
	e1:SetDescription(aux.Stringid(id,0))
	e1:SetCategory(CATEGORY_TOGRAVE)
	e1:SetType(EFFECT_TYPE_ACTIVATE)
	e1:SetCode(EVENT_FREE_CHAIN)
	e1:SetProperty(EFFECT_FLAG_CARD_TARGET)
	e1:SetCountLimit(1,id)
	e1:SetTarget(s.gytg)
	e1:SetOperation(s.gyop)
	c:RegisterEffect(e1)
	--If a Spell/Trap in your possession is banished: banish this card; add 1 banished Spell/Trap
	local e2=Effect.CreateEffect(c)
	e2:SetDescription(aux.Stringid(id,1))
	e2:SetCategory(CATEGORY_REMOVE+CATEGORY_TOHAND)
	e2:SetType(EFFECT_TYPE_FIELD+EFFECT_TYPE_TRIGGER_O)
	e2:SetCode(EVENT_REMOVE)
	e2:SetRange(LOCATION_GRAVE)
	e2:SetProperty(EFFECT_FLAG_DELAY+EFFECT_FLAG_CARD_TARGET)
	e2:SetCountLimit(1,id)
	e2:SetCondition(s.thcon)
	e2:SetCost(s.thcost)
	e2:SetTarget(s.thtg)
	e2:SetOperation(s.thop)
	c:RegisterEffect(e2)
end
function s.gyfilter(c,e)
	return c:IsType(TYPE_SPELL+TYPE_TRAP) and not c:IsCode(id) and c:IsAbleToGrave() and c:IsCanBeEffectTarget(e)
end
function s.gytg(e,tp,eg,ep,ev,re,r,rp,chk,chkc)
	if chkc then return chkc:IsLocation(LOCATION_REMOVED) and chkc:IsControler(tp) and s.gyfilter(chkc,e) end
	if chk==0 then return Duel.IsExistingTarget(aux.NecroValleyFilter(s.gyfilter),tp,LOCATION_REMOVED,0,1,nil,e) end
	Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_TOGRAVE)
	local g=Duel.SelectTarget(tp,aux.NecroValleyFilter(s.gyfilter),tp,LOCATION_REMOVED,0,1,3,nil,e)
	Duel.SetOperationInfo(0,CATEGORY_TOGRAVE,g,#g,0,0)
end
function s.gyop(e,tp,eg,ep,ev,re,r,rp)
	local g=Duel.GetChainInfo(0,CHAININFO_TARGET_CARDS):Filter(Card.IsRelateToEffect,nil,e)
	if #g>0 and not aux.NecroValleyNegateCheck(g) then
		Duel.SendtoGrave(g,REASON_EFFECT)
	end
end
function s.rmfilter(c,tp)
	return c:IsType(TYPE_SPELL+TYPE_TRAP) and c:GetOwner()==tp
end
function s.thcon(e,tp,eg,ep,ev,re,r,rp)
	return eg:IsExists(s.rmfilter,1,nil,tp)
end
function s.thcost(e,tp,eg,ep,ev,re,r,rp,chk)
	local c=e:GetHandler()
	if chk==0 then return c:IsAbleToRemoveAsCost() end
	Duel.Remove(c,POS_FACEUP,REASON_COST)
end
function s.thfilter(c,e)
	return c:IsType(TYPE_SPELL+TYPE_TRAP) and not c:IsCode(id) and c:IsAbleToHand() and c:IsCanBeEffectTarget(e)
end
function s.thtg(e,tp,eg,ep,ev,re,r,rp,chk,chkc)
	if chkc then return chkc:IsLocation(LOCATION_REMOVED) and chkc:IsControler(tp) and s.thfilter(chkc,e) end
	if chk==0 then return Duel.IsExistingTarget(aux.NecroValleyFilter(s.thfilter),tp,LOCATION_REMOVED,0,1,nil,e) end
	Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_ATOHAND)
	local g=Duel.SelectTarget(tp,aux.NecroValleyFilter(s.thfilter),tp,LOCATION_REMOVED,0,1,1,nil,e)
	Duel.SetOperationInfo(0,CATEGORY_TOHAND,g,1,0,0)
end
function s.thop(e,tp,eg,ep,ev,re,r,rp)
	local tc=Duel.GetFirstTarget()
	if tc and tc:IsRelateToEffect(e) and not aux.NecroValleyNegateCheck(tc) then
		Duel.SendtoHand(tc,nil,REASON_EFFECT)
	end
end

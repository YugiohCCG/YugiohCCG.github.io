--Galatea-2, the Orcust Divider
local s,id=GetID()
local STRING_ID=133646610
local SET_ORCUST=0x11b
local CARD_ORCUSTRATED_BABEL=90351981
function s.initial_effect(c)
	c:EnableReviveLimit()
	aux.AddLinkProcedure(c,aux.FilterBoolFunction(Card.IsLinkType,TYPE_EFFECT),2,3,s.lcheck)
	--"Orcustrated Babel" is unaffected by your opponent's activated effects
	local e1=Effect.CreateEffect(c)
	e1:SetType(EFFECT_TYPE_FIELD)
	e1:SetCode(EFFECT_IMMUNE_EFFECT)
	e1:SetRange(LOCATION_MZONE)
	e1:SetTargetRange(LOCATION_ONFIELD,0)
	e1:SetCondition(s.immcon)
	e1:SetTarget(s.immtg)
	e1:SetValue(s.immval)
	c:RegisterEffect(e1)
	--Return 1 banished "Orcust" card to the GY
	local e2=Effect.CreateEffect(c)
	e2:SetDescription(aux.Stringid(STRING_ID,0))
	e2:SetCategory(CATEGORY_TOGRAVE)
	e2:SetType(EFFECT_TYPE_IGNITION)
	e2:SetRange(LOCATION_MZONE)
	e2:SetProperty(EFFECT_FLAG_CARD_TARGET)
	e2:SetCountLimit(1,id)
	e2:SetTarget(s.tgtg)
	e2:SetOperation(s.tgop)
	c:RegisterEffect(e2)
end
s.listed_series={SET_ORCUST}
function s.lcheck(g,lc,sumtype,tp)
	return g:IsExists(Card.IsLinkSetCard,1,nil,SET_ORCUST)
end
function s.immcon(e)
	return e:GetHandler():IsLinkState()
end
function s.immtg(e,c)
	return c:IsFaceup() and c:IsCode(CARD_ORCUSTRATED_BABEL)
end
function s.immval(e,te)
	return te:GetOwnerPlayer()==1-e:GetHandlerPlayer() and te:IsActivated()
end
function s.tgfilter(c,e)
	return c:IsFaceup() and c:IsSetCard(SET_ORCUST) and c:IsAbleToGrave()
		and c:IsCanBeEffectTarget(e)
end
function s.tgtg(e,tp,eg,ep,ev,re,r,rp,chk,chkc)
	if chkc then return chkc:IsControler(tp) and chkc:IsLocation(LOCATION_REMOVED)
		and aux.NecroValleyFilter(s.tgfilter)(chkc,e) end
	if chk==0 then return Duel.IsExistingTarget(aux.NecroValleyFilter(s.tgfilter),tp,LOCATION_REMOVED,0,1,nil,e) end
	Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_TOGRAVE)
	local g=Duel.SelectTarget(tp,aux.NecroValleyFilter(s.tgfilter),tp,LOCATION_REMOVED,0,1,1,nil,e)
	Duel.SetOperationInfo(0,CATEGORY_TOGRAVE,g,1,0,0)
end
function s.tgop(e,tp,eg,ep,ev,re,r,rp)
	local tc=Duel.GetFirstTarget()
	if tc and tc:IsRelateToEffect(e) and aux.NecroValleyFilter(s.tgfilter)(tc,e) then
		Duel.SendtoGrave(tc,REASON_EFFECT+REASON_RETURN)
	end
end

--Manual of Eclipse
local s,id=GetID()
function s.initial_effect(c)
	--Banish up to 5 monsters from your opponent's GY
	local e1=Effect.CreateEffect(c)
	e1:SetDescription(aux.Stringid(id,0))
	e1:SetCategory(CATEGORY_REMOVE+CATEGORY_DRAW+CATEGORY_TOGRAVE)
	e1:SetType(EFFECT_TYPE_ACTIVATE)
	e1:SetCode(EVENT_FREE_CHAIN)
	e1:SetProperty(EFFECT_FLAG_CARD_TARGET)
	e1:SetCountLimit(1,id+EFFECT_COUNT_CODE_OATH)
	e1:SetTarget(s.target)
	e1:SetOperation(s.activate)
	c:RegisterEffect(e1)
end
function s.rmfilter(c,e)
	return c:IsType(TYPE_MONSTER) and c:IsAbleToRemove() and c:IsCanBeEffectTarget(e)
end
function s.maxdraw(tp)
	for i=5,1,-1 do
		if Duel.IsPlayerCanDraw(1-tp,i) then
			return i
		end
	end
	return 0
end
function s.target(e,tp,eg,ep,ev,re,r,rp,chk,chkc)
	local maxct=s.maxdraw(tp)
	if chkc then return chkc:IsControler(1-tp) and chkc:IsLocation(LOCATION_GRAVE) and aux.NecroValleyFilter(s.rmfilter)(chkc,e) end
	if chk==0 then return maxct>0
		and Duel.IsExistingTarget(aux.NecroValleyFilter(s.rmfilter),tp,0,LOCATION_GRAVE,1,nil,e) end
	Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_REMOVE)
	local g=Duel.SelectTarget(tp,aux.NecroValleyFilter(s.rmfilter),tp,0,LOCATION_GRAVE,1,maxct,nil,e)
	Duel.SetOperationInfo(0,CATEGORY_REMOVE,g,#g,0,0)
	Duel.SetOperationInfo(0,CATEGORY_DRAW,nil,0,1-tp,#g)
end
function s.retfilter(c)
	return c:IsFaceup() and c:IsType(TYPE_MONSTER) and c:IsAbleToGrave()
end
function s.activate(e,tp,eg,ep,ev,re,r,rp)
	local g=Duel.GetChainInfo(0,CHAININFO_TARGET_CARDS):Filter(Card.IsRelateToEffect,nil,e)
	g=g:Filter(aux.NecroValleyFilter(s.rmfilter),nil,e)
	if #g==0 then return end
	Duel.Remove(g,POS_FACEUP,REASON_EFFECT)
	local rg=Duel.GetOperatedGroup():Filter(Card.IsLocation,nil,LOCATION_REMOVED)
	local ct=#rg
	if ct==0 then return end
	Duel.Draw(1-tp,ct,REASON_EFFECT)
	local e1=Effect.CreateEffect(e:GetHandler())
	e1:SetType(EFFECT_TYPE_FIELD+EFFECT_TYPE_CONTINUOUS)
	e1:SetCode(EVENT_PHASE+PHASE_END)
	e1:SetCountLimit(1)
	e1:SetReset(RESET_PHASE+PHASE_END)
	e1:SetOperation(s.retop)
	Duel.RegisterEffect(e1,tp)
end
function s.retop(e,tp,eg,ep,ev,re,r,rp)
	local g=Duel.GetMatchingGroup(s.retfilter,tp,0,LOCATION_REMOVED,nil)
	if #g>0 then
		Duel.SendtoGrave(g,REASON_EFFECT+REASON_RETURN)
	end
end

--Tome of Eclipse
local s,id=GetID()
function s.initial_effect(c)
	--Banish all other Spell/Trap Cards on the field
	local e1=Effect.CreateEffect(c)
	e1:SetDescription(aux.Stringid(id,0))
	e1:SetCategory(CATEGORY_REMOVE+CATEGORY_DRAW+CATEGORY_TOGRAVE)
	e1:SetType(EFFECT_TYPE_ACTIVATE)
	e1:SetCode(EVENT_FREE_CHAIN)
	e1:SetCountLimit(1,id+EFFECT_COUNT_CODE_OATH)
	e1:SetTarget(s.target)
	e1:SetOperation(s.activate)
	c:RegisterEffect(e1)
end
function s.rmfilter(c,ec)
	return c~=ec and c:IsType(TYPE_SPELL+TYPE_TRAP) and c:IsAbleToRemove()
end
function s.target(e,tp,eg,ep,ev,re,r,rp,chk)
	local g=Duel.GetMatchingGroup(s.rmfilter,tp,LOCATION_ONFIELD,LOCATION_ONFIELD,nil,e:GetHandler())
	if chk==0 then return #g>0 and Duel.IsPlayerCanDraw(1-tp,#g) end
	Duel.SetOperationInfo(0,CATEGORY_REMOVE,g,#g,0,0)
	Duel.SetOperationInfo(0,CATEGORY_DRAW,nil,0,1-tp,#g)
end
function s.retfilter(c)
	return c:IsLocation(LOCATION_REMOVED) and c:IsFaceup() and c:IsAbleToGrave()
end
function s.oppcard(c,tp)
	return c:GetOwner()==1-tp
end
function s.activate(e,tp,eg,ep,ev,re,r,rp)
	local g=Duel.GetMatchingGroup(s.rmfilter,tp,LOCATION_ONFIELD,LOCATION_ONFIELD,nil,e:GetHandler())
	if #g==0 or Duel.Remove(g,POS_FACEUP,REASON_EFFECT)==0 then return end
	local rg=Duel.GetOperatedGroup():Filter(Card.IsLocation,nil,LOCATION_REMOVED)
	rg=rg-rg:Filter(Card.IsReason,nil,REASON_REDIRECT)
	local ct=#rg
	if ct==0 then return end
	local og=rg:Filter(s.oppcard,nil,tp)
	if #og>0 then
		og:KeepAlive()
		local e1=Effect.CreateEffect(e:GetHandler())
		e1:SetType(EFFECT_TYPE_FIELD+EFFECT_TYPE_CONTINUOUS)
		e1:SetCode(EVENT_PHASE+PHASE_END)
		e1:SetCountLimit(1)
		e1:SetReset(RESET_PHASE+PHASE_END)
		e1:SetLabelObject(og)
		e1:SetOperation(s.retop)
		Duel.RegisterEffect(e1,tp)
	end
	Duel.Draw(1-tp,ct,REASON_EFFECT)
end
function s.retop(e,tp,eg,ep,ev,re,r,rp)
	local g=e:GetLabelObject()
	if not g then return end
	local sg=g:Filter(s.retfilter,nil)
	if #sg>0 then
		Duel.SendtoGrave(sg,REASON_EFFECT+REASON_RETURN)
	end
	g:DeleteGroup()
end

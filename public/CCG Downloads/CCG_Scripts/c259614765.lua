--Encyclopedia of Eclipse
local s,id=GetID()
function s.initial_effect(c)
	--Negate the effects of all face-up monsters, then your opponent draws
	local e1=Effect.CreateEffect(c)
	e1:SetDescription(aux.Stringid(id,0))
	e1:SetCategory(CATEGORY_DISABLE+CATEGORY_DRAW)
	e1:SetType(EFFECT_TYPE_ACTIVATE)
	e1:SetCode(EVENT_FREE_CHAIN)
	e1:SetCountLimit(1,id+EFFECT_COUNT_CODE_OATH)
	e1:SetTarget(s.target)
	e1:SetOperation(s.activate)
	c:RegisterEffect(e1)
end
function s.filter(c)
	return c:IsFaceup() and c:IsType(TYPE_MONSTER)
end
function s.target(e,tp,eg,ep,ev,re,r,rp,chk)
	local ct=Duel.GetMatchingGroupCount(s.filter,tp,0,LOCATION_MZONE,nil)
	if chk==0 then return Duel.IsExistingMatchingCard(aux.NegateMonsterFilter,tp,LOCATION_MZONE,LOCATION_MZONE,1,nil)
		and (ct==0 or Duel.IsPlayerCanDraw(1-tp,ct)) end
	Duel.SetOperationInfo(0,CATEGORY_DISABLE,nil,1,PLAYER_ALL,LOCATION_MZONE)
	if ct>0 then
		Duel.SetOperationInfo(0,CATEGORY_DRAW,nil,0,1-tp,ct)
	end
end
function s.negate(tc,c)
	Duel.NegateRelatedChain(tc,RESET_TURN_SET)
	local e1=Effect.CreateEffect(c)
	e1:SetType(EFFECT_TYPE_SINGLE)
	e1:SetCode(EFFECT_DISABLE)
	e1:SetReset(RESET_EVENT+RESETS_STANDARD+RESET_PHASE+PHASE_END)
	tc:RegisterEffect(e1)
	local e2=e1:Clone()
	e2:SetCode(EFFECT_DISABLE_EFFECT)
	e2:SetValue(RESET_TURN_SET)
	tc:RegisterEffect(e2)
	if tc:IsType(TYPE_TRAPMONSTER) then
		local e3=e1:Clone()
		e3:SetCode(EFFECT_DISABLE_TRAPMONSTER)
		tc:RegisterEffect(e3)
	end
end
function s.activate(e,tp,eg,ep,ev,re,r,rp)
	local g=Duel.GetMatchingGroup(s.filter,tp,LOCATION_MZONE,LOCATION_MZONE,nil)
	for tc in aux.Next(g) do
		if tc:IsCanBeDisabledByEffect(e,false) then
			s.negate(tc,e:GetHandler())
		end
	end
	local ct=Duel.GetMatchingGroupCount(s.filter,tp,0,LOCATION_MZONE,nil)
	if ct>0 then
		Duel.Draw(1-tp,ct,REASON_EFFECT)
	end
end

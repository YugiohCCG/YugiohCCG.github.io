--Eldora, the Intergalactic Empire
local s,id=GetID()
local CARD_DYSMANDR=223512283
local CARD_ELDORA_DEPRAEVITY=229786055
function s.initial_effect(c)
	--Activate
	local e0=Effect.CreateEffect(c)
	e0:SetType(EFFECT_TYPE_ACTIVATE)
	e0:SetCode(EVENT_FREE_CHAIN)
	c:RegisterEffect(e0)
	--Destroy this card; negate an effect that would destroy 2+ monsters you control
	local e1=Effect.CreateEffect(c)
	e1:SetDescription(aux.Stringid(id,0))
	e1:SetCategory(CATEGORY_DISABLE+CATEGORY_DESTROY)
	e1:SetType(EFFECT_TYPE_QUICK_O)
	e1:SetCode(EVENT_CHAINING)
	e1:SetRange(LOCATION_FZONE)
	e1:SetCondition(s.negcon)
	e1:SetTarget(s.negtg)
	e1:SetOperation(s.negop)
	c:RegisterEffect(e1)
	--If destroyed and sent to the GY
	local e2=Effect.CreateEffect(c)
	e2:SetDescription(aux.Stringid(id,1))
	e2:SetCategory(CATEGORY_DESTROY+CATEGORY_SSET)
	e2:SetType(EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_O)
	e2:SetProperty(EFFECT_FLAG_DELAY+EFFECT_FLAG_CARD_TARGET)
	e2:SetCode(EVENT_TO_GRAVE)
	e2:SetCountLimit(1,id)
	e2:SetCondition(s.setcon)
	e2:SetTarget(s.settg)
	e2:SetOperation(s.setop)
	c:RegisterEffect(e2)
end
s.listed_names={CARD_DYSMANDR,CARD_ELDORA_DEPRAEVITY}
function s.desfilter(c,tp)
	return c:IsControler(tp) and c:IsLocation(LOCATION_MZONE) and c:IsType(TYPE_MONSTER)
end
function s.willdestroy(ev,tp)
	local ex,g,ct,p,loc=Duel.GetOperationInfo(ev,CATEGORY_DESTROY)
	if not ex then return false end
	if g then
		if ct and ct>0 then
			return ct+g:FilterCount(s.desfilter,nil,tp)-g:GetCount()>=2
		end
		return g:FilterCount(s.desfilter,nil,tp)>=2
	end
	return ct and ct>=2 and (p==tp or p==PLAYER_ALL) and loc and loc&LOCATION_MZONE~=0
		and Duel.GetMatchingGroupCount(Card.IsType,tp,LOCATION_MZONE,0,nil,TYPE_MONSTER)>=2
end
function s.negcon(e,tp,eg,ep,ev,re,r,rp)
	return rp==1-tp and Duel.IsChainDisablable(ev) and s.willdestroy(ev,tp)
end
function s.negtg(e,tp,eg,ep,ev,re,r,rp,chk)
	local c=e:GetHandler()
	if chk==0 then return c:IsDestructable(e) end
	Duel.SetOperationInfo(0,CATEGORY_DESTROY,c,1,0,0)
	Duel.SetOperationInfo(0,CATEGORY_DISABLE,eg,1,0,0)
end
function s.negop(e,tp,eg,ep,ev,re,r,rp)
	local c=e:GetHandler()
	if c:IsRelateToEffect(e) and Duel.Destroy(c,REASON_EFFECT)>0 then
		Duel.NegateEffect(ev)
	end
end
function s.setcon(e,tp,eg,ep,ev,re,r,rp)
	local c=e:GetHandler()
	return c:IsReason(REASON_DESTROY) and c:IsPreviousLocation(LOCATION_ONFIELD)
end
function s.tgfilter(c)
	return c:IsFaceup() and c:IsType(TYPE_EFFECT) and c:IsDestructable()
end
function s.setfilter(c)
	return c:IsCode(CARD_ELDORA_DEPRAEVITY) and c:IsSSetable()
		and (not c:IsLocation(LOCATION_REMOVED) or c:IsFaceup())
		and (not c:IsLocation(LOCATION_GRAVE) or aux.NecroValleyFilter()(c))
end
function s.match(c,tc)
	return c:IsRace(tc:GetRace()) or c:IsAttribute(tc:GetAttribute())
		or (c:GetLevel()>0 and tc:GetLevel()>0 and c:IsLevel(tc:GetLevel()))
		or (c:GetAttack()>=0 and tc:GetAttack()>=0 and c:GetAttack()==tc:GetAttack())
		or (not c:IsType(TYPE_LINK) and not tc:IsType(TYPE_LINK)
			and c:GetDefense()>=0 and tc:GetDefense()>=0 and c:GetDefense()==tc:GetDefense())
end
function s.dgfilter(c,tc)
	return c~=tc and c:IsFaceup() and c:IsType(TYPE_EFFECT) and not c:IsCode(CARD_DYSMANDR)
		and s.match(c,tc) and c:IsDestructable()
end
function s.settg(e,tp,eg,ep,ev,re,r,rp,chk,chkc)
	if chkc then return chkc:IsControler(tp) and chkc:IsLocation(LOCATION_MZONE) and s.tgfilter(chkc) end
	if chk==0 then return Duel.IsExistingTarget(s.tgfilter,tp,LOCATION_MZONE,0,1,nil) end
	Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_DESTROY)
	local g=Duel.SelectTarget(tp,s.tgfilter,tp,LOCATION_MZONE,0,1,1,nil)
	local tc=g:GetFirst()
	local dg=Duel.GetMatchingGroup(s.dgfilter,tp,LOCATION_MZONE,0,tc,tc)
	dg:AddCard(tc)
	Duel.SetOperationInfo(0,CATEGORY_DESTROY,dg,#dg,0,0)
	if Duel.IsExistingMatchingCard(s.setfilter,tp,LOCATION_DECK+LOCATION_GRAVE+LOCATION_REMOVED,0,1,nil) then
		Duel.SetOperationInfo(0,CATEGORY_SSET,nil,1,tp,LOCATION_DECK+LOCATION_GRAVE+LOCATION_REMOVED)
	end
	if Duel.IsExistingMatchingCard(s.setfilter,tp,LOCATION_GRAVE,0,1,nil) then
		Duel.SetOperationInfo(0,CATEGORY_LEAVE_GRAVE,nil,1,tp,LOCATION_GRAVE)
	end
end
function s.setop(e,tp,eg,ep,ev,re,r,rp)
	local tc=Duel.GetFirstTarget()
	if not (tc and tc:IsRelateToEffect(e) and s.tgfilter(tc)) then return end
	local dg=Duel.GetMatchingGroup(s.dgfilter,tp,LOCATION_MZONE,0,tc,tc)
	dg:AddCard(tc)
	if Duel.Destroy(dg,REASON_EFFECT)==0 then return end
	if not Duel.IsExistingMatchingCard(s.setfilter,tp,LOCATION_DECK+LOCATION_GRAVE+LOCATION_REMOVED,0,1,nil) then return end
	Duel.BreakEffect()
	Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_SET)
	local sc=Duel.SelectMatchingCard(tp,s.setfilter,tp,LOCATION_DECK+LOCATION_GRAVE+LOCATION_REMOVED,0,1,1,nil):GetFirst()
	if sc and Duel.SSet(tp,sc)>0 then
		if sc:IsType(TYPE_QUICKPLAY) then
			local e1=Effect.CreateEffect(e:GetHandler())
			e1:SetType(EFFECT_TYPE_SINGLE)
			e1:SetProperty(EFFECT_FLAG_SET_AVAILABLE)
			e1:SetCode(EFFECT_QP_ACT_IN_SET_TURN)
			e1:SetReset(RESET_EVENT+RESETS_STANDARD+RESET_PHASE+PHASE_END)
			sc:RegisterEffect(e1)
		end
		if sc:IsType(TYPE_TRAP) then
			local e1=Effect.CreateEffect(e:GetHandler())
			e1:SetType(EFFECT_TYPE_SINGLE)
			e1:SetProperty(EFFECT_FLAG_SET_AVAILABLE)
			e1:SetCode(EFFECT_TRAP_ACT_IN_SET_TURN)
			e1:SetReset(RESET_EVENT+RESETS_STANDARD+RESET_PHASE+PHASE_END)
			sc:RegisterEffect(e1)
		end
	end
end

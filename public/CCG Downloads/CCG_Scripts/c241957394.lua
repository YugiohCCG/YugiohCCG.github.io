--Chapter II Verse IV
local s,id=GetID()
local CARD_DYSMANDR=223512283
local CARD_EXTINCTION=242009896
function s.initial_effect(c)
	--Treated as The Hallowed Scripts of the Ataxia
	--Activate (Rewrite effect)
	local e1=Effect.CreateEffect(c)
	e1:SetDescription(aux.Stringid(id,0))
	e1:SetType(EFFECT_TYPE_ACTIVATE)
	e1:SetCode(EVENT_CHAINING)
	e1:SetCountLimit(1,id+EFFECT_COUNT_LIMIT_OATH)
	e1:SetCondition(s.condition)
	e1:SetCost(s.cost)
	e1:SetTarget(s.target)
	e1:SetOperation(s.activate)
	c:RegisterEffect(e1)
end
s.listed_names={CARD_DYSMANDR,CARD_EXTINCTION}

function s.condition(e,tp,eg,ep,ev,re,r,rp)
	return rp==1-tp and Duel.IsChainNegatable(ev)
end
function s.cost(e,tp,eg,ep,ev,re,r,rp,chk)
	if chk==0 then return Duel.IsExistingMatchingCard(Card.IsCode,tp,LOCATION_EXTRA,0,1,nil,CARD_DYSMANDR) end
	Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_CONFIRM)
	local g=Duel.SelectMatchingCard(tp,Card.IsCode,tp,LOCATION_EXTRA,0,1,1,nil,CARD_DYSMANDR)
	Duel.ConfirmCards(1-tp,g)
end
function s.target(e,tp,eg,ep,ev,re,r,rp,chk,chkc)
	if chkc then return chkc:IsControler(tp) and chkc:IsLocation(LOCATION_MZONE) and chkc:IsType(TYPE_EFFECT) end
	if chk==0 then return Duel.IsExistingTarget(Card.IsType,tp,LOCATION_MZONE,0,1,nil,TYPE_EFFECT)
		and Duel.IsExistingMatchingCard(Card.IsCode,tp,LOCATION_DECK,0,1,nil,CARD_EXTINCTION) end
	Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_TARGET)
	Duel.SelectTarget(tp,Card.IsType,tp,LOCATION_MZONE,0,1,1,nil,TYPE_EFFECT)
end
function s.activate(e,tp,eg,ep,ev,re,r,rp)
	local tc=Duel.GetFirstTarget()
	if not tc or not tc:IsRelateToEffect(e) then return end
	Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_TOGRAVE)
	local g=Duel.SelectMatchingCard(tp,Card.IsCode,tp,LOCATION_DECK,0,1,1,nil,CARD_EXTINCTION)
	if #g>0 and Duel.SendtoGrave(g,REASON_EFFECT)>0 then
		-- Register End Phase shuffle
		local e1=Effect.CreateEffect(e:GetHandler())
		e1:SetType(EFFECT_TYPE_FIELD+EFFECT_TYPE_CONTINUOUS)
		e1:SetCode(EVENT_PHASE+PHASE_END)
		e1:SetCountLimit(1)
		e1:SetReset(RESET_PHASE+PHASE_END)
		e1:SetOperation(s.shufop)
		Duel.RegisterEffect(e1,tp)
		
		-- Change chain operation
		Duel.ChangeTargetCard(ev,Group.CreateGroup())
		Duel.ChangeChainOperation(ev,s.repop)
	end
end
function s.shufop(e,tp,eg,ep,ev,re,r,rp)
	local g=Duel.GetMatchingGroup(Card.IsCode,tp,LOCATION_GRAVE,0,nil,CARD_EXTINCTION)
	if #g>0 then
		Duel.SendtoDeck(g,nil,SEQ_DECKSHUFFLE,REASON_EFFECT)
	end
end
function s.repop(e,tp,eg,ep,ev,re,r,rp)
	-- tp is original activating player (opponent of Chapter II controller)
	local tg=Duel.GetMatchingGroup(Card.IsCode,tp,LOCATION_MZONE,0,nil,240299293) -- Protogenic Essence Token
	if #tg>0 and Duel.Release(tg:Select(tp,1,1,nil),REASON_EFFECT)>0 then
		local g=Duel.GetMatchingGroup(Card.IsType,tp,LOCATION_MZONE,LOCATION_MZONE,nil,TYPE_EFFECT)
		if #g==0 then return end
		Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_DESTROY)
		local sg=g:Select(tp,1,1,nil)
		local tc=sg:GetFirst()
		if tc then
			Duel.HintSelection(sg)
			local race=tc:GetRace()
			local attr=tc:GetAttribute()
			local lv=tc:GetLevel()
			local atk=tc:GetAttack()
			local df=tc:GetDefense()
			
			local function desfilter(c,otc)
				if c:IsCode(CARD_DYSMANDR) or not c:IsType(TYPE_EFFECT) or c==otc then return false end
				return c:IsRace(race) or c:IsAttribute(attr) or (c:GetLevel()>0 and c:GetLevel()==lv)
					or (c:GetAttack()>=0 and c:GetAttack()==atk) or (c:GetDefense()>=0 and c:GetDefense()==df)
			end
			
			local dg=Duel.GetMatchingGroup(desfilter,tp,LOCATION_MZONE,LOCATION_MZONE,nil,tc)
			dg:AddCard(tc)
			Duel.Destroy(dg,REASON_EFFECT)
		end
	end
end

--Chapter II Verse IV
local s,id=GetID()
local STRING_ID=133957394
local CARD_DYSMANDR=223512283
local CARD_EXTINCTION=242009896
function s.initial_effect(c)
	--Treated as The Hallowed Scripts of the Ataxia
	--Activate (Rewrite effect)
	local e1=Effect.CreateEffect(c)
	e1:SetDescription(aux.Stringid(STRING_ID,0))
	e1:SetType(EFFECT_TYPE_ACTIVATE)
	e1:SetCode(EVENT_CHAINING)
	e1:SetProperty(EFFECT_FLAG_CARD_TARGET)
	e1:SetCountLimit(1,id+EFFECT_COUNT_CODE_OATH)
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
	local gc=g:GetFirst()
	if gc and Duel.SendtoGrave(gc,REASON_EFFECT)>0 and gc:IsLocation(LOCATION_GRAVE) then
		gc:RegisterFlagEffect(id,RESET_EVENT+RESETS_STANDARD+RESET_PHASE+PHASE_END,0,1)
		-- Register End Phase shuffle
		local e1=Effect.CreateEffect(e:GetHandler())
		e1:SetType(EFFECT_TYPE_FIELD+EFFECT_TYPE_CONTINUOUS)
		e1:SetCode(EVENT_PHASE+PHASE_END)
		e1:SetCountLimit(1)
		e1:SetReset(RESET_PHASE+PHASE_END)
		e1:SetLabelObject(gc)
		e1:SetOperation(s.shufop)
		Duel.RegisterEffect(e1,tp)
		
		-- Change chain operation
		Duel.ChangeTargetCard(ev,Group.FromCards(tc))
		Duel.ChangeChainOperation(ev,s.repop)
	end
end
function s.shufop(e,tp,eg,ep,ev,re,r,rp)
	local tc=e:GetLabelObject()
	if tc and tc:IsLocation(LOCATION_GRAVE) and tc:IsCode(CARD_EXTINCTION)
		and tc:GetFlagEffect(id)>0 and aux.NecroValleyFilter()(tc) then
		Duel.SendtoDeck(tc,nil,SEQ_DECKSHUFFLE,REASON_EFFECT)
	end
end
function s.repop(e,tp,eg,ep,ev,re,r,rp)
	-- tp is original activating player (opponent of Chapter II controller)
	local tg=Duel.GetMatchingGroup(Card.IsCode,tp,LOCATION_MZONE,0,nil,240299293) -- Protogenic Essence Token
	if #tg==0 then return end
	Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_RELEASE)
	if Duel.Release(tg:Select(tp,1,1,nil),REASON_EFFECT)>0 then
		local tc=Duel.GetFirstTarget()
		if tc and tc:IsRelateToEffect(e) and tc:IsFaceup() and tc:IsType(TYPE_EFFECT) then
			local race=tc:GetRace()
			local attr=tc:GetAttribute()
			local lv=tc:GetLevel()
			local atk=tc:GetAttack()
			local df=tc:GetDefense()
			
			local function desfilter(c,otc)
				if c:IsCode(CARD_DYSMANDR) or not c:IsFaceup() or not c:IsType(TYPE_EFFECT) or c==otc then return false end
				return c:IsRace(race) or c:IsAttribute(attr) or (c:GetLevel()>0 and c:GetLevel()==lv)
					or (c:GetAttack()>=0 and c:GetAttack()==atk)
					or (not c:IsType(TYPE_LINK) and not otc:IsType(TYPE_LINK)
						and c:GetDefense()>=0 and c:GetDefense()==df)
			end
			
			local dg=Duel.GetMatchingGroup(desfilter,tp,LOCATION_MZONE,LOCATION_MZONE,nil,tc)
			if #dg>0 and Duel.Destroy(dg,REASON_EFFECT)>0 then
				Duel.BreakEffect()
				if tc:IsRelateToEffect(e) and tc:IsOnField() then
					Duel.Destroy(tc,REASON_EFFECT)
				end
			end
		end
	end
end

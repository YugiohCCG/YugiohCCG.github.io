local s,id=GetID()
local STRING_ID=133068354
function s.initial_effect(c)
	--Special Summon
	local e1=Effect.CreateEffect(c)
	e1:SetDescription(aux.Stringid(STRING_ID,0))
	e1:SetCategory(CATEGORY_SPECIAL_SUMMON+CATEGORY_TODECK)
	e1:SetType(EFFECT_TYPE_IGNITION)
	e1:SetRange(LOCATION_HAND)
	e1:SetCountLimit(1,id)
	e1:SetCost(s.spcost)
	e1:SetTarget(s.sptg)
	e1:SetOperation(s.spop)
	c:RegisterEffect(e1)
	--Send and optional shuffle/set
	local e2=Effect.CreateEffect(c)
	e2:SetDescription(aux.Stringid(STRING_ID,1))
	e2:SetCategory(CATEGORY_TOGRAVE+CATEGORY_TODECK)
	e2:SetType(EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_O)
	e2:SetCode(EVENT_SUMMON_SUCCESS)
	e2:SetProperty(EFFECT_FLAG_DELAY)
	e2:SetCountLimit(1,{id,1})
	e2:SetTarget(s.tgtg)
	e2:SetOperation(s.tgop)
	c:RegisterEffect(e2)
	local e3=e2:Clone()
	e3:SetCode(EVENT_SPSUMMON_SUCCESS)
	c:RegisterEffect(e3)
end
s.listed_series={0x21fc}
function s.revfilter(c)
	return c:IsSetCard(0x21fc) and c:IsType(TYPE_SPELL) and not c:IsPublic()
end
function s.spcost(e,tp,eg,ep,ev,re,r,rp,chk)
	local c=e:GetHandler()
	if chk==0 then return true end
	local g=Duel.GetMatchingGroup(s.revfilter,tp,LOCATION_HAND,0,c)
	if #g>0 and Duel.SelectYesNo(tp,aux.Stringid(STRING_ID,2)) then
		Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_CONFIRM)
		local sg=g:Select(tp,1,2,nil)
		Duel.ConfirmCards(1-tp,sg)
		Duel.ShuffleHand(tp)
		e:SetLabel(#sg)
		sg:KeepAlive()
		e:SetLabelObject(sg)
	else
		e:SetLabel(0)
		e:SetLabelObject(nil)
	end
end
function s.sptg(e,tp,eg,ep,ev,re,r,rp,chk)
	local c=e:GetHandler()
	if chk==0 then return Duel.GetLocationCount(tp,LOCATION_MZONE)>0
		and c:IsCanBeSpecialSummoned(e,0,tp,false,false) 
		and Duel.IsExistingMatchingCard(Card.IsAbleToDeck,tp,LOCATION_HAND,0,1,c) end
	Duel.SetOperationInfo(0,CATEGORY_SPECIAL_SUMMON,c,1,0,0)
	Duel.SetOperationInfo(0,CATEGORY_TODECK,nil,1,tp,LOCATION_HAND)
end
function s.spop(e,tp,eg,ep,ev,re,r,rp)
	local c=e:GetHandler()
	if not c:IsRelateToEffect(e) then return end
	local rev_g=e:GetLabelObject()
	local rev_ct=e:GetLabel()
	
	local to_deck=Group.CreateGroup()
	if rev_g and #rev_g>0 then
		to_deck:Merge(rev_g:Filter(Card.IsLocation,nil,LOCATION_HAND))
	end
	local max_add = 2 - #to_deck
	if max_add > 0 then
		local hg=Duel.GetMatchingGroup(Card.IsAbleToDeck,tp,LOCATION_HAND,0,c)
		hg:Sub(to_deck)
		if #hg>0 then
			local select_min = (#to_deck == 0) and 1 or 0
			Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_TODECK)
			local extra=hg:Select(tp,select_min,max_add,nil)
			to_deck:Merge(extra)
		end
	end
	if #to_deck==0 then return end
	if Duel.SendtoDeck(to_deck,nil,SEQ_DECKSHUFFLE,REASON_EFFECT)>0 then
		local ct=to_deck:FilterCount(Card.IsLocation,nil,LOCATION_DECK+LOCATION_EXTRA)
		if ct>0 and Duel.SpecialSummon(c,0,tp,tp,false,false,POS_FACEUP)>0 then
			local e1=Effect.CreateEffect(c)
			e1:SetType(EFFECT_TYPE_FIELD+EFFECT_TYPE_CONTINUOUS)
			e1:SetProperty(EFFECT_FLAG_IGNORE_IMMUNE)
			e1:SetCode(EVENT_PHASE+PHASE_STANDBY)
			e1:SetCountLimit(1)
			e1:SetLabel(ct | (rev_ct<<16))
			e1:SetCondition(s.thcon)
			e1:SetOperation(s.thop)
			if Duel.GetCurrentPhase()==PHASE_STANDBY then
				e1:SetReset(RESET_PHASE+PHASE_STANDBY,2)
			else
				e1:SetReset(RESET_PHASE+PHASE_STANDBY)
			end
			Duel.RegisterEffect(e1,tp)
		end
	end
end
function s.thcon(e,tp,eg,ep,ev,re,r,rp)
	return true
end
function s.addfilter(c)
	return c:IsSetCard(0x21fc) and not c:IsCode(id) and c:IsAbleToHand()
end
function s.setfilter(c)
	return c:IsSetCard(0x21fc) and c:IsType(TYPE_QUICKPLAY) and c:IsSSetable()
end
function s.thop(e,tp,eg,ep,ev,re,r,rp)
	local lbl=e:GetLabel()
	local ct1 = lbl & 0xffff
	local ct2 = lbl >> 16
	Duel.Hint(HINT_CARD,0,id)
	local g=Duel.GetMatchingGroup(s.addfilter,tp,LOCATION_DECK,0,nil)
	if #g>=ct1 then
		Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_ATOHAND)
		local sg=g:Select(tp,ct1,ct1,nil)
		if Duel.SendtoHand(sg,nil,REASON_EFFECT)>0 then
			Duel.ConfirmCards(1-tp,sg)
			if ct2>0 then
				local sg2=Duel.GetMatchingGroup(s.setfilter,tp,LOCATION_DECK,0,nil)
				if #sg2>=ct2 then
					Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_SET)
					local setg=sg2:Select(tp,ct2,ct2,nil)
					if #setg>0 then
						Duel.SSet(tp,setg)
						for tc in aux.Next(setg) do
							local e1=Effect.CreateEffect(e:GetOwner())
							e1:SetType(EFFECT_TYPE_SINGLE)
							e1:SetCode(EFFECT_QP_ACT_IN_SET_TURN)
							e1:SetProperty(EFFECT_FLAG_SET_AVAILABLE)
							e1:SetReset(RESET_EVENT+RESETS_STANDARD)
							tc:RegisterEffect(e1)
						end
					end
				end
			end
		end
	end
end
function s.tgfilter(c)
	return c:IsSetCard(0x21fc) and c:IsAbleToGrave()
end
function s.tgtg(e,tp,eg,ep,ev,re,r,rp,chk)
	if chk==0 then return Duel.IsExistingMatchingCard(s.tgfilter,tp,LOCATION_DECK,0,1,nil) end
	Duel.SetOperationInfo(0,CATEGORY_TOGRAVE,nil,1,tp,LOCATION_DECK)
end
function s.tdsetfilter(c,code)
	if not (c:IsSetCard(0x21fc) and not c:IsCode(code)) then return false end
	if c:IsAbleToDeck() then return true end
	if c:IsType(TYPE_SPELL+TYPE_TRAP) and c:IsSSetable() then return true end
	return false
end
function s.tgop(e,tp,eg,ep,ev,re,r,rp)
	Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_TOGRAVE)
	local g=Duel.SelectMatchingCard(tp,s.tgfilter,tp,LOCATION_DECK,0,1,1,nil)
	if #g>0 and Duel.SendtoGrave(g,REASON_EFFECT)>0 and g:GetFirst():IsLocation(LOCATION_GRAVE) then
		local code=g:GetFirst():GetCode()
		local mg=Duel.GetMatchingGroup(aux.NecroValleyFilter(s.tdsetfilter),tp,LOCATION_GRAVE,0,nil,code)
		if #mg>0 and Duel.SelectYesNo(tp,aux.Stringid(STRING_ID,3)) then
			Duel.BreakEffect()
			Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_OPERATECARD)
			local sg=mg:Select(tp,1,1,nil)
			local tc=sg:GetFirst()
			local b1=tc:IsAbleToDeck()
			local b2=tc:IsType(TYPE_SPELL+TYPE_TRAP) and tc:IsSSetable()
			local op=0
			if b1 and b2 then
				op=Duel.SelectOption(tp,1156,1153)
			elseif b1 then
				op=0
			else
				op=1
			end
			if op==0 then
				Duel.SendtoDeck(tc,nil,SEQ_DECKSHUFFLE,REASON_EFFECT)
			else
				Duel.SSet(tp,tc)
			end
		end
	end
end

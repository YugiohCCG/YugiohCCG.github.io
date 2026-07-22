local s,id=GetID()
local STRING_ID=133759221
function s.initial_effect(c)
	--Treat as non-Tuner
	local e1=Effect.CreateEffect(c)
	e1:SetType(EFFECT_TYPE_SINGLE)
	e1:SetProperty(EFFECT_FLAG_SINGLE_RANGE)
	e1:SetRange(LOCATION_MZONE)
	e1:SetCode(EFFECT_NONTUNER)
	e1:SetValue(s.synnontuner)
	c:RegisterEffect(e1)
	--Synchro Level
	local e2=Effect.CreateEffect(c)
	e2:SetType(EFFECT_TYPE_SINGLE)
	e2:SetCode(EFFECT_SYNCHRO_LEVEL)
	e2:SetProperty(EFFECT_FLAG_SINGLE_RANGE)
	e2:SetRange(LOCATION_MZONE)
	e2:SetValue(s.slevel)
	c:RegisterEffect(e2)
	--Special Summon
	local e3=Effect.CreateEffect(c)
	e3:SetDescription(aux.Stringid(STRING_ID,0))
	e3:SetCategory(CATEGORY_SPECIAL_SUMMON+CATEGORY_TODECK)
	e3:SetType(EFFECT_TYPE_IGNITION)
	e3:SetRange(LOCATION_HAND)
	e3:SetCountLimit(1,id)
	e3:SetCost(s.spcost)
	e3:SetTarget(s.sptg)
	e3:SetOperation(s.spop)
	c:RegisterEffect(e3)
	--Sent to GY as Synchro Material
	local e4=Effect.CreateEffect(c)
	e4:SetDescription(aux.Stringid(STRING_ID,1))
	e4:SetCategory(CATEGORY_TOHAND+CATEGORY_SEARCH)
	e4:SetType(EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_O)
	e4:SetCode(EVENT_BE_MATERIAL)
	e4:SetProperty(EFFECT_FLAG_DELAY)
	e4:SetCountLimit(1,{id,1})
	e4:SetCondition(s.sycon)
	e4:SetTarget(s.sytg)
	e4:SetOperation(s.syop)
	c:RegisterEffect(e4)
end
s.listed_series={0x21fc}
function s.synnontuner(e,c)
	return c:IsSetCard(0x21fc)
end
function s.slevel(e,c)
	local lvl=e:GetHandler():GetLevel()
	if c:IsSetCard(0x21fc) then
		return 6*65536+lvl
	else return lvl end
end
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
	if #to_deck==0 then
		if rev_g then rev_g:DeleteGroup() end
		return
	end
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
	if rev_g then rev_g:DeleteGroup() end
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
function s.sycon(e,tp,eg,ep,ev,re,r,rp)
	return e:GetHandler():IsLocation(LOCATION_GRAVE) and r==REASON_SYNCHRO
end
function s.syfilter(c)
	return c:IsSetCard(0x21fc) and c:IsType(TYPE_SPELL) and (c:IsAbleToHand() or c:IsSSetable())
end
function s.sytg(e,tp,eg,ep,ev,re,r,rp,chk)
	if chk==0 then return Duel.IsExistingMatchingCard(s.syfilter,tp,LOCATION_DECK,0,1,nil) end
end
function s.syop(e,tp,eg,ep,ev,re,r,rp)
	Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_OPERATECARD)
	local g=Duel.SelectMatchingCard(tp,s.syfilter,tp,LOCATION_DECK,0,1,1,nil)
	local tc=g:GetFirst()
	if tc then
		if tc:IsAbleToHand() and (not tc:IsSSetable() or Duel.SelectOption(tp,1190,1153)==0) then
			Duel.SendtoHand(tc,nil,REASON_EFFECT)
			Duel.ConfirmCards(1-tp,tc)
		else
			Duel.SSet(tp,tc)
		end
	end
end

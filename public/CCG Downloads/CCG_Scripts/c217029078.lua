local s,id=GetID()
function s.initial_effect(c)
	local e1=Effect.CreateEffect(c)
	e1:SetCategory(CATEGORY_SPECIAL_SUMMON+CATEGORY_TODECK)
	e1:SetType(EFFECT_TYPE_IGNITION)
	e1:SetRange(LOCATION_HAND)
	e1:SetCountLimit(1,id)
	e1:SetCost(s.spcost)
	e1:SetTarget(s.sptg)
	e1:SetOperation(s.spop)
	c:RegisterEffect(e1)
	local e2=Effect.CreateEffect(c)
	e2:SetCategory(CATEGORY_SPECIAL_SUMMON)
	e2:SetType(EFFECT_TYPE_QUICK_O)
	e2:SetCode(EVENT_CHAINING)
	e2:SetRange(LOCATION_MZONE)
	e2:SetCountLimit(1,id+1)
	e2:SetCondition(s.syncon)
	e2:SetTarget(s.syntg)
	e2:SetOperation(s.synop)
	c:RegisterEffect(e2)
end
function s.revfilter(c)
	return c:IsSetCard(0x6f5) and c:IsType(TYPE_SPELL) and not c:IsPublic()
end
function s.spcost(e,tp,eg,ep,ev,re,r,rp,chk)
	if chk==0 then return true end
	local g=Duel.GetMatchingGroup(s.revfilter,tp,LOCATION_HAND,0,nil)
	if #g>0 and Duel.SelectYesNo(tp,aux.Stringid(id,0)) then
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
	if chk==0 then return Duel.GetLocationCount(tp,LOCATION_MZONE)>0
		and e:GetHandler():IsCanBeSpecialSummoned(e,0,tp,false,false) end
	Duel.SetOperationInfo(0,CATEGORY_SPECIAL_SUMMON,e:GetHandler(),1,0,0)
	Duel.SetOperationInfo(0,CATEGORY_TODECK,nil,0,tp,LOCATION_HAND)
end
function s.spop(e,tp,eg,ep,ev,re,r,rp)
	local c=e:GetHandler()
	if not c:IsRelateToEffect(e) then return end
	local rev_g=e:GetLabelObject()
	local rev_ct=e:GetLabel()
	local min=rev_ct
	local g=Group.CreateGroup()
	if rev_g and min>0 then
		g:Merge(rev_g)
	end
	if min<2 and Duel.IsExistingMatchingCard(Card.IsAbleToDeck,tp,LOCATION_HAND,0,1,g) then
		if min==0 or Duel.SelectYesNo(tp,aux.Stringid(id,1)) then
			local max_add=2-min
			Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_TODECK)
			local ext=Duel.SelectMatchingCard(tp,Card.IsAbleToDeck,tp,LOCATION_HAND,0,min==0 and 1 or 0,max_add,g)
			g:Merge(ext)
		end
	end
	local shuf_ct=#g
	if shuf_ct>0 then
		Duel.SendtoDeck(g,nil,SEQ_DECKSHUFFLE,REASON_EFFECT)
	end
	if Duel.SpecialSummon(c,0,tp,tp,false,false,POS_FACEUP)>0 and shuf_ct>0 then
		local e1=Effect.CreateEffect(c)
		e1:SetType(EFFECT_TYPE_FIELD+EFFECT_TYPE_CONTINUOUS)
		e1:SetCode(EVENT_PHASE+PHASE_STANDBY)
		e1:SetCountLimit(1)
		e1:SetLabel(shuf_ct+(rev_ct*10))
		e1:SetCondition(s.thcon)
		e1:SetOperation(s.thop)
		if Duel.GetCurrentPhase()==PHASE_STANDBY then
			e1:SetReset(RESET_PHASE+PHASE_STANDBY,2)
		else
			e1:SetReset(RESET_PHASE+PHASE_STANDBY,1)
		end
		Duel.RegisterEffect(e1,tp)
	end
end
function s.thcon(e,tp,eg,ep,ev,re,r,rp)
	return Duel.GetTurnPlayer()==tp or Duel.GetTurnPlayer()==1-tp
end
function s.thfilter(c,id)
	return c:IsSetCard(0x6f5) and not c:IsCode(id) and c:IsAbleToHand()
end
function s.setfilter(c)
	return c:IsSetCard(0x6f5) and c:IsType(TYPE_QUICKPLAY) and c:IsSSetable()
end
function s.thop(e,tp,eg,ep,ev,re,r,rp)
	local label=e:GetLabel()
	local shuf_ct=label%10
	local rev_ct=math.floor(label/10)
	Duel.Hint(HINT_CARD,0,id)
	local g=Duel.GetMatchingGroup(s.thfilter,tp,LOCATION_DECK,0,nil,id)
	if #g>=shuf_ct then
		Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_ATOHAND)
		local sg=g:Select(tp,shuf_ct,shuf_ct,nil)
		if Duel.SendtoHand(sg,nil,REASON_EFFECT)>0 then
			Duel.ConfirmCards(1-tp,sg)
			if rev_ct>0 then
				local setg=Duel.GetMatchingGroup(s.setfilter,tp,LOCATION_DECK,0,nil)
				if #setg>=rev_ct then
					Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_SET)
					local ssg=setg:Select(tp,rev_ct,rev_ct,nil)
					Duel.SSet(tp,ssg)
					for tc in aux.Next(ssg) do
						local e1=Effect.CreateEffect(e:GetHandler())
						e1:SetType(EFFECT_TYPE_SINGLE)
						e1:SetProperty(EFFECT_FLAG_SET_AVAILABLE)
						e1:SetCode(EFFECT_TRAP_ACT_IN_SET_TURN)
						e1:SetReset(RESET_EVENT+RESETS_STANDARD)
						tc:RegisterEffect(e1)
						local e2=e1:Clone()
						e2:SetCode(EFFECT_QP_ACT_IN_SET_TURN)
						tc:RegisterEffect(e2)
					end
				end
			end
		end
	end
end
function s.syncon(e,tp,eg,ep,ev,re,r,rp)
	return rp==1-tp and re:IsActiveType(TYPE_SPELL+TYPE_TRAP)
end
function s.synfilter(c,e,tp,mc)
	return c:IsAttribute(ATTRIBUTE_WIND) and c:IsType(TYPE_SYNCHRO) and c:IsSynchroSummonable(nil,mc)
end
function s.syntg(e,tp,eg,ep,ev,re,r,rp,chk)
	if chk==0 then return Duel.IsExistingMatchingCard(s.synfilter,tp,LOCATION_EXTRA,0,1,nil,e,tp,e:GetHandler()) end
	Duel.SetOperationInfo(0,CATEGORY_SPECIAL_SUMMON,nil,1,tp,LOCATION_EXTRA)
end
function s.synop(e,tp,eg,ep,ev,re,r,rp)
	local c=e:GetHandler()
	if c:IsControler(1-tp) or not c:IsRelateToEffect(e) or c:IsFacedown() then return end
	local g=Duel.GetMatchingGroup(s.synfilter,tp,LOCATION_EXTRA,0,nil,e,tp,c)
	if #g>0 then
		Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_SPSUMMON)
		local tc=g:Select(tp,1,1,nil):GetFirst()
		Duel.SynchroSummon(tp,tc,c)
	end
end

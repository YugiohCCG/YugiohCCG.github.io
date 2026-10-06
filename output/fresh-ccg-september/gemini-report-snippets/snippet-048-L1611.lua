-- c237684285.lua (Janna, Windborne Goddess of Clement Winds)
function s.rtop(e,tp,eg,ep,ev,re,r,rp)
	local tg=Duel.GetTargetCards(e)
	if #tg>0 and Duel.SendtoHand(tg,nil,REASON_EFFECT)>0 then
		local og=Duel.GetOperatedGroup():Filter(Card.IsLocation,nil,LOCATION_HAND)
		local count=#og
		if count>0 then
			local hg=Duel.GetMatchingGroup(Card.IsAbleToDeck,tp,LOCATION_HAND,0,nil)
			if #hg>=count then
				Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_TODECK)
				local sg=hg:Select(tp,count,count,nil)
				local ct=Duel.SendtoDeck(sg,nil,SEQ_DECKSHUFFLE,REASON_EFFECT)
				if ct>0 then
					local c=e:GetHandler()
					local e1=Effect.CreateEffect(c)
					e1:SetType(EFFECT_TYPE_FIELD+EFFECT_TYPE_CONTINUOUS)
					e1:SetCode(EVENT_PHASE+PHASE_STANDBY)
					e1:SetCountLimit(1)
					if Duel.GetCurrentPhase()==PHASE_STANDBY then
						e1:SetReset(RESET_PHASE+PHASE_STANDBY,2)
					else
						e1:SetReset(RESET_PHASE+PHASE_STANDBY)
					end
					e1:SetLabel(ct)
					e1:SetOperation(s.drawop)
					Duel.RegisterEffect(e1,tp)
				end
			end
		end
	end
end

function s.thfilter1(c)
	return c:IsSetCard(0x21fc) and c:IsType(TYPE_SPELL) and c:IsAbleToHand()
end
function s.thtg(e,tp,eg,ep,ev,re,r,rp,chk,chkc)
	if chkc then return chkc:IsLocation(LOCATION_GRAVE) and chkc:IsControler(tp) and s.thfilter1(chkc) end
	if chk==0 then return Duel.IsExistingTarget(aux.NecroValleyFilter(s.thfilter1),tp,LOCATION_GRAVE,0,1,nil) end
	Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_ATOHAND)
	local g=Duel.SelectTarget(tp,aux.NecroValleyFilter(s.thfilter1),tp,LOCATION_GRAVE,0,1,1,nil)
end

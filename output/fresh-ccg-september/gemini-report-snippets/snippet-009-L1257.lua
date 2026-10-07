-- Standby Phase delayed operation in c215068354.lua
function s.thop(e,tp,eg,ep,ev,re,r,rp)
	local lbl=e:GetLabel()
	local ct1 = lbl & 0xffff
	local ct2 = lbl >> 16
	Duel.Hint(HINT_CARD,0,id)
	local g=Duel.GetMatchingGroup(s.addfilter,tp,LOCATION_DECK,0,nil)
	if #g>0 and ct1>0 then
		local count=math.min(#g,ct1)
		Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_ATOHAND)
		local sg=g:Select(tp,count,count,nil)
		if Duel.SendtoHand(sg,nil,REASON_EFFECT)>0 then
			Duel.ConfirmCards(1-tp,sg)
			if ct2>0 then
				local sg2=Duel.GetMatchingGroup(s.setfilter,tp,LOCATION_DECK,0,nil)
				if #sg2>0 then
					local set_count=math.min(#sg2,ct2)
					Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_SET)
					local setg=sg2:Select(tp,set_count,set_count,nil)
					if #setg>0 then
						Duel.SSet(tp,setg)
						for tc in aux.Next(setg) do
							local e1=Effect.CreateEffect(e:GetHandler())
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

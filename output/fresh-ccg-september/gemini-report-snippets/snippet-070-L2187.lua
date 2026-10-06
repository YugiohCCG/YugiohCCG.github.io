-- Replacement snippet for c212837324.lua lines 27 & 32:
function s.setop(e,tp)
	if Duel.GetLocationCount(tp,LOCATION_SZONE)<=0 then return end
	Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_SET)
	local tc=Duel.SelectMatchingCard(tp,s.setfilter,tp,LOCATION_REMOVED,0,1,1,nil):GetFirst()
	if tc and Duel.SSet(tp,tc)>0 then
		if tc:IsType(TYPE_TRAP) or tc:IsType(TYPE_QUICKPLAY) then
			local te=Effect.CreateEffect(e:GetHandler())
			te:SetDescription(aux.Stringid(STRING_ID,3))
			te:SetType(EFFECT_TYPE_SINGLE)
			te:SetProperty(EFFECT_FLAG_SET_AVAILABLE)
			te:SetCode(tc:IsType(TYPE_TRAP) and EFFECT_TRAP_ACT_IN_SET_TURN or EFFECT_QP_ACT_IN_SET_TURN)
			te:SetReset(RESET_EVENT+RESETS_STANDARD)
			tc:RegisterEffect(te)
		end
	end
end
function s.spop(e,tp)
	local c=e:GetHandler()
	if not c:IsRelateToEffect(e) then return end
	local op=s.leavechoice(c,tp)
	if op<0 then return end
	local ok
	if op==0 then
		ok=Duel.SendtoDeck(c,nil,2,REASON_EFFECT)>0
	else
		ok=Duel.Remove(c,POS_FACEUP,REASON_EFFECT)>0
	end
	if not ok or Duel.GetLocationCount(tp,LOCATION_MZONE)<=0 then return end
	Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_SPSUMMON)
	local sc=Duel.SelectMatchingCard(tp,aux.NecroValleyFilter(s.spfilter),tp,LOCATION_DECK+LOCATION_GRAVE,0,1,1,nil,e,tp):GetFirst()
	if sc then
		Duel.SpecialSummon(sc,0,tp,tp,false,false,POS_FACEUP_ATTACK)
	end
end

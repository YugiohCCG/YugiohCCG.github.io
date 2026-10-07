-- Replacement snippet for c256005703.lua lines 27 & 35:
function s.settg(e,tp,eg,ep,ev,re,r,rp,chk)
	if chk==0 then return Duel.GetLocationCount(tp,LOCATION_SZONE)>0
		and Duel.IsExistingMatchingCard(s.setfilter,tp,LOCATION_REMOVED,0,1,nil) end
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
	if not ok then return end
	Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_SPSUMMON)
	local sc=Duel.SelectMatchingCard(tp,s.spfilter,tp,LOCATION_EXTRA,0,1,1,nil,e,tp,nil):GetFirst()
	if sc then Duel.SpecialSummon(sc,0,tp,tp,false,false,POS_FACEUP) end
end

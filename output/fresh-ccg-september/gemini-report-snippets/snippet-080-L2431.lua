-- Replacement snippet for c259391738.lua:
function s.rdf(c,e)
	return c~=e:GetHandler() and c:IsSetCard(SET_AEROCAT) and (c:IsFaceup() or c:IsLocation(LOCATION_GRAVE)) and c:IsAbleToDeck()
end

function s.tdtg(e,tp,eg,ep,ev,re,r,rp,chk,chkc)
	if chkc then return chkc:IsLocation(LOCATION_GRAVE+LOCATION_REMOVED) and chkc:IsControler(tp) and s.rdf(chkc,e) end
	if chk==0 then return Duel.IsExistingTarget(s.rdf,tp,LOCATION_GRAVE+LOCATION_REMOVED,0,1,nil,e) end
	Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_TODECK)
	local g=Duel.SelectTarget(tp,s.rdf,tp,LOCATION_GRAVE+LOCATION_REMOVED,0,1,3,nil,e)
	Duel.SetOperationInfo(0,CATEGORY_TODECK,g,#g,0,0)
	Duel.SetPossibleOperationInfo(0,CATEGORY_DRAW,nil,0,tp,1)
end

function s.tdop(e,tp)
	local tg=Duel.GetChainInfo(0,CHAININFO_TARGET_CARDS)
	if not tg then return end
	local g=tg:Filter(Card.IsRelateToEffect,nil,e):Filter(s.rdf,nil,e):Filter(aux.NecroValleyFilter(Card.IsAbleToDeck),nil)
	if #g>0 and Duel.SendtoDeck(g,nil,SEQ_DECKSHUFFLE,REASON_EFFECT)>0 then
		local og=Duel.GetOperatedGroup()
		if og:IsExists(Card.IsLocation,1,nil,LOCATION_DECK+LOCATION_EXTRA)
			and Duel.IsExistingMatchingCard(s.one,tp,LOCATION_MZONE,0,1,nil)
			and Duel.IsPlayerCanDraw(tp,1)
			and Duel.SelectYesNo(tp,aux.Stringid(MSG_ID,2)) then
			Duel.BreakEffect()
			Duel.Draw(tp,1,REASON_EFFECT)
		end
	end
end

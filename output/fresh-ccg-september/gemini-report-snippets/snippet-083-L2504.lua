-- Replacement snippet for c210175845.lua destg and desop:
function s.destg(e,tp,eg,ep,ev,re,r,rp,chk)
	local ct=Duel.GetCurrentChain()+1
	if chk==0 then
		return Duel.GetMatchingGroupCount(Card.IsDestructable,tp,0,LOCATION_ONFIELD,nil)>=ct
	end
	e:SetLabel(ct)
	Duel.SetOperationInfo(0,CATEGORY_DESTROY,nil,ct,1-tp,LOCATION_ONFIELD)
end

function s.desop(e,tp)
	local ct=e:GetLabel()
	local g=Duel.GetMatchingGroup(Card.IsDestructable,tp,0,LOCATION_ONFIELD,nil)
	if #g<ct then return end
	Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_DESTROY)
	local sg=g:Select(tp,ct,ct,nil)
	Duel.Destroy(sg,REASON_EFFECT)
end

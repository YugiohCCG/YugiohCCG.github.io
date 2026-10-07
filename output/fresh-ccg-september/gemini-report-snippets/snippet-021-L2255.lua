-- Replacement snippet for c253520299.lua:
function s.btcost(e,tp,eg,ep,ev,re,r,rp,chk)
	local c=e:GetHandler()
	if chk==0 then return c:GetFlagEffect(id)==0 end
	c:RegisterFlagEffect(id,RESET_PHASE+PHASE_DAMAGE,0,1)
end
-- in s.initial_effect:
e2:SetCost(s.btcost)
-- in s.rmtg:
function s.rmtg(e,tp,eg,ep,ev,re,r,rp,chk)
	if chk==0 then return (e:GetHandler():IsAbleToDeck() or e:GetHandler():IsAbleToRemove())
		and Duel.IsExistingMatchingCard(s.rmfilter,tp,LOCATION_DECK,0,1,nil) end
	Duel.SetOperationInfo(0,CATEGORY_REMOVE,nil,1,tp,LOCATION_DECK)
end
-- in s.rmop:
if op==0 then
	ok=Duel.SendtoDeck(c,nil,2,REASON_EFFECT)>0
else
	ok=Duel.Remove(c,POS_FACEUP,REASON_EFFECT)>0
end

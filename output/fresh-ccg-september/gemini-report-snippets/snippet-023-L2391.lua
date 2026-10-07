-- Replacement snippet for c259023461.lua:
function s.paycon(e,tp,eg,ep,ev,re,r,rp)
	-- Must be in the GY when the payment occurred
	return ep==tp and e:GetHandler():IsPreviousLocation(LOCATION_GRAVE)
end

-- in s.payop:
local val=math.floor(s[tp]/2)
if val>0 and Duel.SelectYesNo(tp,aux.Stringid(STRING_ID,3)) then -- String ID 3 for LP recovery
	Duel.Recover(tp,val,REASON_EFFECT)
end

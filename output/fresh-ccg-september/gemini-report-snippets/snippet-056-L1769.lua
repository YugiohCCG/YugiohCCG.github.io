-- c221321849.lua (The Condescender)
function s.lvfilter(c)
	return c:IsFaceup() and (c:IsHasLevel() or c:IsType(TYPE_XYZ) or c:IsType(TYPE_LINK))
end
function s.lvtg(e,tp,eg,ep,ev,re,r,rp,chk,chkc)
	if chkc then return chkc:IsLocation(LOCATION_MZONE) and s.lvfilter(chkc) end
	if chk==0 then return Duel.IsExistingTarget(s.lvfilter,tp,LOCATION_MZONE,LOCATION_MZONE,1,nil) end
	Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_FACEUP)
	Duel.SelectTarget(tp,s.lvfilter,tp,LOCATION_MZONE,LOCATION_MZONE,1,1,nil)
end
function s.lvop(e,tp,eg,ep,ev,re,r,rp)
	local tc=Duel.GetFirstTarget()
	if not (tc and tc:IsRelateToEffect(e) and tc:IsFaceup()) then return end
	local n=Duel.AnnounceNumber(tp,1,2,3)
	local c=e:GetHandler()
	if tc:IsHasLevel() then
		local val=math.max(1,tc:GetLevel()-n)-tc:GetLevel()
		local e1=Effect.CreateEffect(c)
		e1:SetType(EFFECT_TYPE_SINGLE)
		e1:SetCode(EFFECT_UPDATE_LEVEL)
		e1:SetValue(val)
		e1:SetReset(RESET_EVENT+RESETS_STANDARD+RESET_PHASE+PHASE_END,2)
		tc:RegisterEffect(e1)
	elseif tc:IsType(TYPE_XYZ) then
		local val=math.max(1,tc:GetRank()-n)-tc:GetRank()
		local e2=Effect.CreateEffect(c)
		e2:SetType(EFFECT_TYPE_SINGLE)
		e2:SetCode(EFFECT_UPDATE_RANK)
		e2:SetValue(val)
		e2:SetReset(RESET_EVENT+RESETS_STANDARD+RESET_PHASE+PHASE_END,2)
		tc:RegisterEffect(e2)
	elseif tc:IsType(TYPE_LINK) then
		local val=math.max(1,tc:GetLink()-n)
		local e3=Effect.CreateEffect(c)
		e3:SetType(EFFECT_TYPE_SINGLE)
		e3:SetCode(EFFECT_SET_LINK)
		e3:SetValue(val)
		e3:SetReset(RESET_EVENT+RESETS_STANDARD+RESET_PHASE+PHASE_END,2)
		tc:RegisterEffect(e3)
	end
end

function s.lowfilter(c)
	if not c:IsFaceup() then return false end
	if c:IsHasLevel() and c:GetLevel()<c:GetOriginalLevel() then return true end
	if c:IsType(TYPE_XYZ) and c:GetRank()<c:GetOriginalRank() then return true end
	if c:IsType(TYPE_LINK) and c:GetLink()<c:GetOriginalLink() then return true end
	return false
end

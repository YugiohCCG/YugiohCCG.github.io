function s.emzfilter(c)
	return c:GetSequence()>=5
end
function s.ovfilter(c)
	local tp=c:GetControler()
	return c:IsFaceup() and c:IsAttribute(ATTRIBUTE_LIGHT) -- or c:IsRace(RACE_ROCK), etc.
		and not Duel.IsExistingMatchingCard(s.emzfilter,tp,LOCATION_MZONE,0,1,nil)
end

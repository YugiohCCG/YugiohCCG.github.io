-- Replacement for c211964444.lua lines 52-65 (supporting the Nephthys Standby effects):
function s.desop(e,tp,eg,ep,ev,re,r,rp)
	local tc=e:GetLabelObject()
	if not (tc and tc:IsRelateToEffect(e) and tc:IsLocation(LOCATION_DECK) and s.desfilter(tc,e)) then return end
	if Duel.Destroy(tc,REASON_EFFECT,LOCATION_GRAVE)==0 then return end
	Duel.BreakEffect()
	local code=tc:GetCode()
	-- Apply the Standby Phase effect directly according to official card implementations
	if code==98999181 then -- Disciple of Nephthys: add 1 Nephthys Spell/Trap from Deck to hand
		Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_ATOHAND)
		local g=Duel.SelectMatchingCard(tp,function(c) return c:IsSetCard(SET_NEPHTHYS) and c:IsType(TYPE_SPELL+TYPE_TRAP) and c:IsAbleToHand() end,tp,LOCATION_DECK,0,1,1,nil)
		if #g>0 then
			Duel.SendtoHand(g,nil,REASON_EFFECT)
			Duel.ConfirmCards(1-tp,g)
		end
	elseif code==51782995 then -- Defender of Nephthys: destroy 1 Nephthys monster in Deck
		Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_DESTROY)
		local g=Duel.SelectMatchingCard(tp,function(c) return c:IsSetCard(SET_NEPHTHYS) and c:IsType(TYPE_MONSTER) and not c:IsCode(51782995) end,tp,LOCATION_DECK,0,1,1,nil)
		if #g>0 then Duel.Destroy(g,REASON_EFFECT) end
	elseif code==25397880 then -- Chronicler of Nephthys: add 1 Nephthys card from GY to hand
		Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_ATOHAND)
		local g=Duel.SelectMatchingCard(tp,aux.NecroValleyFilter(function(c) return c:IsSetCard(SET_NEPHTHYS) and not c:IsCode(25397880) and c:IsAbleToHand() end),tp,LOCATION_GRAVE,0,1,1,nil)
		if #g>0 then
			Duel.SendtoHand(g,nil,REASON_EFFECT)
			Duel.ConfirmCards(1-tp,g)
		end
	elseif code==52904476 or code==61441708 or code==24175232 then -- Matriarch / Sacred Phoenix / Cerulean: Special Summon from GY
		if Duel.GetLocationCount(tp,LOCATION_MZONE)>0 and tc:IsCanBeSpecialSummoned(e,0,tp,false,false) then
			Duel.SpecialSummon(tc,0,tp,tp,false,false,POS_FACEUP)
		end
	end
end

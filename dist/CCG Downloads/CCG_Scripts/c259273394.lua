--JELLY MISS OF THE GRAND BLUE
local s,id=GetID()
local STRING_ID=133273394
local SET_GRAND_BLUE=0x67ee
local CARD_UMI=22702055
local CARD_CITY_GRAND_BLUE=259679619
local CARD_GRAND_BLUE_PRINCESS=259177849
local CARD_GRAND_BLUE_PRINCE=259937946
function s.initial_effect(c)
	--Special Summon this card, then if you control "Umi", negate a card and gain ATK/DEF
	local e1=Effect.CreateEffect(c)
	e1:SetDescription(aux.Stringid(STRING_ID,0))
	e1:SetCategory(CATEGORY_SPECIAL_SUMMON+CATEGORY_DISABLE+CATEGORY_ATKCHANGE+CATEGORY_DEFCHANGE)
	e1:SetType(EFFECT_TYPE_IGNITION)
	e1:SetRange(LOCATION_HAND)
	e1:SetCountLimit(1,id)
	e1:SetTarget(s.sptg)
	e1:SetOperation(s.spop)
	c:RegisterEffect(e1)
	--Fusion Summon by shuffling materials from the GY into the Deck, including this card
	local e2=Effect.CreateEffect(c)
	e2:SetDescription(aux.Stringid(STRING_ID,2))
	e2:SetCategory(CATEGORY_TODECK+CATEGORY_SPECIAL_SUMMON+CATEGORY_FUSION_SUMMON)
	e2:SetType(EFFECT_TYPE_IGNITION)
	e2:SetRange(LOCATION_GRAVE)
	e2:SetCountLimit(1,id+100)
	e2:SetTarget(s.fustg)
	e2:SetOperation(s.fusop)
	c:RegisterEffect(e2)
end
function s.gbmonster(c)
	return c:IsFaceup() and c:IsSetCard(SET_GRAND_BLUE) and c:IsType(TYPE_MONSTER)
end
function s.umifilter(c)
	return c:IsFaceup() and (c:IsCode(CARD_UMI) or c:IsCode(CARD_CITY_GRAND_BLUE))
end
function s.sptg(e,tp,eg,ep,ev,re,r,rp,chk)
	local c=e:GetHandler()
	if chk==0 then return Duel.GetLocationCount(tp,LOCATION_MZONE)>0
		and c:IsCanBeSpecialSummoned(e,0,tp,false,false)
		and Duel.IsExistingMatchingCard(s.gbmonster,tp,LOCATION_MZONE,0,1,nil) end
	Duel.SetOperationInfo(0,CATEGORY_SPECIAL_SUMMON,c,1,0,0)
end
function s.spop(e,tp,eg,ep,ev,re,r,rp)
	local c=e:GetHandler()
	if not (c:IsRelateToEffect(e) and Duel.GetLocationCount(tp,LOCATION_MZONE)>0) then return end
	if Duel.SpecialSummon(c,0,tp,tp,false,false,POS_FACEUP)==0 then return end
	if Duel.IsExistingMatchingCard(s.umifilter,tp,LOCATION_ONFIELD,0,1,nil)
		and Duel.IsExistingMatchingCard(aux.NegateAnyFilter,tp,0,LOCATION_ONFIELD,1,nil)
		and Duel.SelectYesNo(tp,aux.Stringid(STRING_ID,1)) then
		Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_DISABLE)
		local tc=Duel.SelectMatchingCard(tp,aux.NegateAnyFilter,tp,0,LOCATION_ONFIELD,1,1,nil):GetFirst()
		if tc and tc:IsFaceup() and tc:IsCanBeDisabledByEffect(e,false) then
			Duel.NegateRelatedChain(tc,RESET_TURN_SET)
			local e1=Effect.CreateEffect(c)
			e1:SetType(EFFECT_TYPE_SINGLE)
			e1:SetProperty(EFFECT_FLAG_CANNOT_DISABLE)
			e1:SetCode(EFFECT_DISABLE)
			e1:SetReset(RESET_EVENT+RESETS_STANDARD+RESET_PHASE+PHASE_END)
			tc:RegisterEffect(e1)
			local e2=Effect.CreateEffect(c)
			e2:SetType(EFFECT_TYPE_SINGLE)
			e2:SetProperty(EFFECT_FLAG_CANNOT_DISABLE)
			e2:SetCode(EFFECT_DISABLE_EFFECT)
			e2:SetValue(RESET_TURN_SET)
			e2:SetReset(RESET_EVENT+RESETS_STANDARD+RESET_PHASE+PHASE_END)
			tc:RegisterEffect(e2)
			if tc:IsType(TYPE_TRAPMONSTER) then
				local e3=Effect.CreateEffect(c)
				e3:SetType(EFFECT_TYPE_SINGLE)
				e3:SetProperty(EFFECT_FLAG_CANNOT_DISABLE)
				e3:SetCode(EFFECT_DISABLE_TRAPMONSTER)
				e3:SetReset(RESET_EVENT+RESETS_STANDARD+RESET_PHASE+PHASE_END)
				tc:RegisterEffect(e3)
			end
			local e4=Effect.CreateEffect(c)
			e4:SetType(EFFECT_TYPE_SINGLE)
			e4:SetProperty(EFFECT_FLAG_CANNOT_DISABLE)
			e4:SetCode(EFFECT_UPDATE_ATTACK)
			e4:SetValue(800)
			e4:SetReset(RESET_EVENT+RESETS_STANDARD)
			c:RegisterEffect(e4)
			local e5=e4:Clone()
			e5:SetCode(EFFECT_UPDATE_DEFENSE)
			c:RegisterEffect(e5)
		end
	end
end
function s.matfilter(c,e)
	return c:IsSetCard(SET_GRAND_BLUE) and c:IsType(TYPE_MONSTER) and c:IsCanBeFusionMaterial()
		and c:IsAbleToDeck() and not c:IsImmuneToEffect(e)
end
function s.princesscheck(g,sc,tp,fc)
	return #g==2 and g:IsContains(sc) and g:FilterCount(Card.IsSetCard,nil,SET_GRAND_BLUE)==2
		and Duel.GetLocationCountFromEx(tp,tp,g,fc)>0
end
function s.princecheck(g,sc,tp,fc)
	return #g==2 and g:IsContains(sc) and g:IsExists(Card.IsCode,1,nil,CARD_GRAND_BLUE_PRINCESS)
		and g:IsExists(Card.IsSetCard,1,nil,SET_GRAND_BLUE)
		and Duel.GetLocationCountFromEx(tp,tp,g,fc)>0
end
function s.fusfilter(c,e,tp,mg,sc)
	if not (c:IsType(TYPE_FUSION) and c:IsSetCard(SET_GRAND_BLUE)
		and c:IsCanBeSpecialSummoned(e,SUMMON_TYPE_FUSION,tp,false,false)) then return false end
	if c:IsCode(CARD_GRAND_BLUE_PRINCESS) then return mg:CheckSubGroup(s.princesscheck,2,2,sc,tp,c) end
	if c:IsCode(CARD_GRAND_BLUE_PRINCE) then return mg:CheckSubGroup(s.princecheck,2,2,sc,tp,c) end
	return false
end
function s.fustg(e,tp,eg,ep,ev,re,r,rp,chk)
	local c=e:GetHandler()
	local mg=Duel.GetMatchingGroup(aux.NecroValleyFilter(s.matfilter),tp,LOCATION_GRAVE,0,nil,e)
	if chk==0 then return aux.NecroValleyFilter(s.matfilter)(c,e)
		and Duel.IsExistingMatchingCard(s.fusfilter,tp,LOCATION_EXTRA,0,1,nil,e,tp,mg,c) end
	Duel.SetOperationInfo(0,CATEGORY_TODECK,nil,2,tp,LOCATION_GRAVE)
	Duel.SetOperationInfo(0,CATEGORY_SPECIAL_SUMMON,nil,1,tp,LOCATION_EXTRA)
end
function s.fusop(e,tp,eg,ep,ev,re,r,rp)
	local c=e:GetHandler()
	if not (c:IsRelateToEffect(e) and aux.NecroValleyFilter(s.matfilter)(c,e)) then return end
	local mg=Duel.GetMatchingGroup(aux.NecroValleyFilter(s.matfilter),tp,LOCATION_GRAVE,0,nil,e)
	local sg=Duel.GetMatchingGroup(s.fusfilter,tp,LOCATION_EXTRA,0,nil,e,tp,mg,c)
	if #sg==0 then return end
	Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_SPSUMMON)
	local fc=sg:Select(tp,1,1,nil):GetFirst()
	if not fc then return end
	local check=fc:IsCode(CARD_GRAND_BLUE_PRINCESS) and s.princesscheck or s.princecheck
	Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_FMATERIAL)
	local mat=mg:SelectSubGroup(tp,check,false,2,2,c,tp,fc)
	if not mat or #mat~=2 then return end
	fc:SetMaterial(mat)
	Duel.HintSelection(mat)
	if Duel.SendtoDeck(mat,nil,SEQ_DECKSHUFFLE,REASON_EFFECT+REASON_MATERIAL+REASON_FUSION)~=2 then return end
	Duel.BreakEffect()
	if Duel.SpecialSummon(fc,SUMMON_TYPE_FUSION,tp,tp,false,false,POS_FACEUP)>0 then
		fc:CompleteProcedure()
	end
end

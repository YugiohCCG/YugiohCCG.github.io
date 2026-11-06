--The White Frute
local s,id=GetID()
local STRING_ID=132916791
local SET_FRUTE=0x813
function s.initial_effect(c)
	--Tribute 1 WATER monster; Special Summon this card, then add 1 "Frute" monster
	local e1=Effect.CreateEffect(c)
	e1:SetDescription(aux.Stringid(STRING_ID,0))
	e1:SetCategory(CATEGORY_RELEASE+CATEGORY_SPECIAL_SUMMON+CATEGORY_TOHAND+CATEGORY_SEARCH)
	e1:SetType(EFFECT_TYPE_IGNITION)
	e1:SetRange(LOCATION_HAND)
	e1:SetCountLimit(1,id)
	e1:SetCost(s.spcost)
	e1:SetTarget(s.sptg)
	e1:SetOperation(s.spop)
	c:RegisterEffect(e1)
	--If Tributed: add or Special Summon 1 "Frute" monster from the GY
	local e2=Effect.CreateEffect(c)
	e2:SetDescription(aux.Stringid(STRING_ID,1))
	e2:SetCategory(CATEGORY_TOHAND+CATEGORY_SPECIAL_SUMMON)
	e2:SetType(EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_O)
	e2:SetCode(EVENT_RELEASE)
	e2:SetProperty(EFFECT_FLAG_DELAY+EFFECT_FLAG_CARD_TARGET)
	e2:SetCountLimit(1,id+100)
	e2:SetTarget(s.thtg)
	e2:SetOperation(s.thop)
	c:RegisterEffect(e2)
end
function s.rlfilter(c)
	return c:IsAttribute(ATTRIBUTE_WATER) and c:IsReleasable()
end
function s.spcost(e,tp,eg,ep,ev,re,r,rp,chk)
	if chk==0 then return Duel.CheckReleaseGroup(tp,s.rlfilter,1,nil) end
	Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_RELEASE)
	local g=Duel.SelectReleaseGroup(tp,s.rlfilter,1,1,nil)
	Duel.Release(g,REASON_COST)
end
function s.addfilter(c)
	return c:IsSetCard(SET_FRUTE) and c:IsType(TYPE_MONSTER) and not c:IsCode(id) and c:IsAbleToHand()
end
function s.sptg(e,tp,eg,ep,ev,re,r,rp,chk)
	local c=e:GetHandler()
	if chk==0 then return (Duel.GetLocationCount(tp,LOCATION_MZONE)>0 or not e:IsCostChecked())
		and c:IsCanBeSpecialSummoned(e,0,tp,false,false)
		and Duel.IsExistingMatchingCard(s.addfilter,tp,LOCATION_DECK,0,1,nil) end
	Duel.SetOperationInfo(0,CATEGORY_SPECIAL_SUMMON,c,1,0,0)
	Duel.SetOperationInfo(0,CATEGORY_TOHAND,nil,1,tp,LOCATION_DECK)
end
function s.spop(e,tp,eg,ep,ev,re,r,rp)
	local c=e:GetHandler()
	if Duel.GetLocationCount(tp,LOCATION_MZONE)<=0 then return end
	if c:IsRelateToEffect(e) and Duel.SpecialSummon(c,0,tp,tp,false,false,POS_FACEUP)>0
		and Duel.IsExistingMatchingCard(s.addfilter,tp,LOCATION_DECK,0,1,nil) then
		Duel.BreakEffect()
		Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_ATOHAND)
		local tc=Duel.SelectMatchingCard(tp,s.addfilter,tp,LOCATION_DECK,0,1,1,nil):GetFirst()
		if tc then
			Duel.SendtoHand(tc,nil,REASON_EFFECT)
			Duel.ConfirmCards(1-tp,tc)
		end
	end
end
function s.gyfilter(c,e,tp,fd)
	return c:IsSetCard(SET_FRUTE) and c:IsType(TYPE_MONSTER) and not c:IsCode(id)
		and c:IsCanBeEffectTarget(e) and aux.NecroValleyFilter()(c)
		and (c:IsAbleToHand()
			or (fd and (c:IsCanBeSpecialSummoned(e,0,tp,false,false,POS_FACEUP_DEFENSE)
				or (not Duel.IsPlayerAffectedByEffect(tp,EFFECT_DIVINE_LIGHT)
					and c:IsCanBeSpecialSummoned(e,0,tp,false,false,POS_FACEDOWN_DEFENSE)))))
end
function s.thtg(e,tp,eg,ep,ev,re,r,rp,chk,chkc)
	local fd=e:GetHandler():IsPreviousPosition(POS_FACEDOWN_DEFENSE)
	if chkc then return chkc:IsLocation(LOCATION_GRAVE) and s.gyfilter(chkc,e,tp,fd) end
	if chk==0 then return Duel.IsExistingTarget(s.gyfilter,tp,LOCATION_GRAVE,0,1,nil,e,tp,fd) end
	Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_TARGET)
	local g=Duel.SelectTarget(tp,s.gyfilter,tp,LOCATION_GRAVE,0,1,1,nil,e,tp,fd)
	Duel.SetOperationInfo(0,CATEGORY_TOHAND,g,1,0,0)
	Duel.SetOperationInfo(0,CATEGORY_SPECIAL_SUMMON,g,1,0,0)
end
function s.thop(e,tp,eg,ep,ev,re,r,rp)
	local tc=Duel.GetFirstTarget()
	if not (tc and tc:IsRelateToEffect(e) and aux.NecroValleyFilter()(tc)) then return end
	local fd=e:GetHandler():IsPreviousPosition(POS_FACEDOWN_DEFENSE)
	local b1=tc:IsAbleToHand()
	local b2=fd and Duel.GetLocationCount(tp,LOCATION_MZONE)>0
		and tc:IsCanBeSpecialSummoned(e,0,tp,false,false,POS_FACEUP_DEFENSE)
	local b3=fd and Duel.GetLocationCount(tp,LOCATION_MZONE)>0
		and not Duel.IsPlayerAffectedByEffect(tp,EFFECT_DIVINE_LIGHT)
		and tc:IsCanBeSpecialSummoned(e,0,tp,false,false,POS_FACEDOWN_DEFENSE)
	if not (b1 or b2 or b3) then return end
	local op=0
	if b1 and (b2 or b3) then
		local opts={aux.Stringid(STRING_ID,2)}
		if b2 then table.insert(opts,aux.Stringid(STRING_ID,3)) end
		if b3 then table.insert(opts,aux.Stringid(STRING_ID,4)) end
		local sel=Duel.SelectOption(tp,table.unpack(opts))+1
		local label=opts[sel]
		if label==aux.Stringid(STRING_ID,3) then op=1
		elseif label==aux.Stringid(STRING_ID,4) then op=2 end
	elseif b2 and b3 then
		op=Duel.SelectOption(tp,aux.Stringid(STRING_ID,3),aux.Stringid(STRING_ID,4))+1
	elseif b2 or b3 then
		op=b2 and 1 or 2
	end
	if op==0 then
		Duel.SendtoHand(tc,nil,REASON_EFFECT)
		Duel.ConfirmCards(1-tp,tc)
	elseif op==1 then
		Duel.SpecialSummon(tc,0,tp,tp,false,false,POS_FACEUP_DEFENSE)
	else
		Duel.SpecialSummon(tc,0,tp,tp,false,false,POS_FACEDOWN_DEFENSE)
	end
end

--The Green Frute
local s,id=GetID()
local SET_FRUTE=0x813
function s.initial_effect(c)
	--Tribute 1 WATER monster; Special Summon this card face-down
	local e1=Effect.CreateEffect(c)
	e1:SetDescription(aux.Stringid(id,0))
	e1:SetCategory(CATEGORY_RELEASE+CATEGORY_SPECIAL_SUMMON)
	e1:SetType(EFFECT_TYPE_IGNITION)
	e1:SetRange(LOCATION_HAND+LOCATION_GRAVE)
	e1:SetCountLimit(1,id)
	e1:SetCost(s.spcost)
	e1:SetTarget(s.sptg)
	e1:SetOperation(s.spop)
	c:RegisterEffect(e1)
	--If Tributed: send 1 "Frute" card to the GY
	local e2=Effect.CreateEffect(c)
	e2:SetDescription(aux.Stringid(id,1))
	e2:SetCategory(CATEGORY_TOGRAVE)
	e2:SetType(EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_O)
	e2:SetCode(EVENT_RELEASE)
	e2:SetProperty(EFFECT_FLAG_DELAY)
	e2:SetCountLimit(1,id+100)
	e2:SetTarget(s.tgtg)
	e2:SetOperation(s.tgop)
	c:RegisterEffect(e2)
end
function s.rlfilter(c,needzone)
	return c:IsAttribute(ATTRIBUTE_WATER) and not c:IsCode(id) and c:IsReleasable()
		and (not needzone or c:IsLocation(LOCATION_MZONE))
end
function s.spcost(e,tp,eg,ep,ev,re,r,rp,chk)
	local needzone=Duel.GetLocationCount(tp,LOCATION_MZONE)<=0
	if chk==0 then return Duel.IsExistingMatchingCard(s.rlfilter,tp,LOCATION_HAND+LOCATION_MZONE,0,1,e:GetHandler(),needzone) end
	Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_RELEASE)
	local g=Duel.SelectMatchingCard(tp,s.rlfilter,tp,LOCATION_HAND+LOCATION_MZONE,0,1,1,e:GetHandler(),needzone)
	Duel.Release(g,REASON_COST)
end
function s.sptg(e,tp,eg,ep,ev,re,r,rp,chk)
	local c=e:GetHandler()
	if chk==0 then return not Duel.IsPlayerAffectedByEffect(tp,EFFECT_DIVINE_LIGHT)
		and c:IsCanBeSpecialSummoned(e,0,tp,false,false,POS_FACEDOWN_DEFENSE)
		and (not c:IsLocation(LOCATION_GRAVE) or aux.NecroValleyFilter()(c)) end
	Duel.SetOperationInfo(0,CATEGORY_SPECIAL_SUMMON,c,1,0,0)
end
function s.spop(e,tp,eg,ep,ev,re,r,rp)
	local c=e:GetHandler()
	if Duel.IsPlayerAffectedByEffect(tp,EFFECT_DIVINE_LIGHT) or Duel.GetLocationCount(tp,LOCATION_MZONE)<=0 then return end
	if c:IsRelateToEffect(e) and (not c:IsLocation(LOCATION_GRAVE) or aux.NecroValleyFilter()(c))
		and Duel.SpecialSummonStep(c,0,tp,tp,false,false,POS_FACEDOWN_DEFENSE) then
			local e1=Effect.CreateEffect(c)
			e1:SetType(EFFECT_TYPE_SINGLE)
			e1:SetCode(EFFECT_LEAVE_FIELD_REDIRECT)
			e1:SetProperty(EFFECT_FLAG_CANNOT_DISABLE)
			e1:SetReset(RESET_EVENT+RESETS_REDIRECT)
			e1:SetValue(LOCATION_REMOVED)
			c:RegisterEffect(e1,true)
			Duel.SpecialSummonComplete()
	end
end
function s.mfilter(c)
	return c:IsSetCard(SET_FRUTE) and c:IsType(TYPE_MONSTER) and not c:IsCode(id) and c:IsAbleToGrave()
end
function s.stfilter(c)
	return c:IsSetCard(SET_FRUTE) and c:IsType(TYPE_SPELL+TYPE_TRAP) and c:IsAbleToGrave()
end
function s.tgtg(e,tp,eg,ep,ev,re,r,rp,chk)
	local fd=e:GetHandler():IsPreviousPosition(POS_FACEDOWN_DEFENSE)
	local b1=Duel.IsExistingMatchingCard(s.mfilter,tp,LOCATION_DECK,0,1,nil)
	local b2=fd and Duel.IsExistingMatchingCard(s.stfilter,tp,LOCATION_DECK,0,1,nil)
	if chk==0 then return b1 or b2 end
	if b1 and b2 then
		e:SetLabel(Duel.SelectOption(tp,aux.Stringid(id,2),aux.Stringid(id,3)))
	elseif b2 then
		e:SetLabel(1)
	else
		e:SetLabel(0)
	end
	Duel.SetOperationInfo(0,CATEGORY_TOGRAVE,nil,1,tp,LOCATION_DECK)
end
function s.tgop(e,tp,eg,ep,ev,re,r,rp)
	local f=s.mfilter
	if e:GetLabel()==1 then f=s.stfilter end
	Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_TOGRAVE)
	local g=Duel.SelectMatchingCard(tp,f,tp,LOCATION_DECK,0,1,1,nil)
	if #g>0 then
		Duel.SendtoGrave(g,REASON_EFFECT)
	end
end

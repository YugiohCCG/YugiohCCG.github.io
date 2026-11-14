local s,id=GetID()
local STRING_ID=133934743
local SET_FIENDSMITH=0x1b0
function s.initial_effect(c)
	local e=Effect.CreateEffect(c)
	e:SetDescription(aux.Stringid(STRING_ID,0))
	e:SetType(EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_F)
	e:SetCode(EVENT_SUMMON_SUCCESS)
	e:SetProperty(EFFECT_FLAG_DELAY)
	e:SetCountLimit(1,id)
	e:SetTarget(s.sendtg)
	e:SetOperation(s.sendop)
	c:RegisterEffect(e)
	local e2=e:Clone()
	e2:SetCode(EVENT_SPSUMMON_SUCCESS)
	c:RegisterEffect(e2)
	local e3=Effect.CreateEffect(c)
	e3:SetDescription(aux.Stringid(STRING_ID,1))
	e3:SetType(EFFECT_TYPE_QUICK_O)
	e3:SetCode(EVENT_FREE_CHAIN)
	e3:SetRange(LOCATION_HAND+LOCATION_GRAVE)
	e3:SetProperty(EFFECT_FLAG_CARD_TARGET)
	e3:SetCountLimit(1,id+100)
	e3:SetCondition(function(e,tp) return Duel.GetTurnPlayer()~=tp end)
	e3:SetTarget(s.sptg)
	e3:SetOperation(s.spop)
	c:RegisterEffect(e3)
end
function s.sendfilter(c)
	return c:IsSetCard(SET_FIENDSMITH) and c:IsType(TYPE_MONSTER) and c:IsAbleToGrave()
end
function s.sendtg(e,tp,eg,ep,ev,re,r,rp,chk)
	if chk==0 then return Duel.IsExistingMatchingCard(s.sendfilter,tp,LOCATION_EXTRA,0,1,nil) end
	Duel.SetOperationInfo(0,CATEGORY_TOGRAVE,nil,1,tp,LOCATION_EXTRA)
end
function s.sendop(e,tp)
	Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_TOGRAVE)
	local c=Duel.SelectMatchingCard(tp,s.sendfilter,tp,LOCATION_EXTRA,0,1,1,nil):GetFirst()
	if not c or Duel.SendtoGrave(c,REASON_EFFECT)==0 or not c:IsLocation(LOCATION_GRAVE) then return end
	local filter=aux.NecroValleyFilter(Card.IsAbleToHand)
	if not Duel.IsExistingMatchingCard(filter,tp,0,LOCATION_ONFIELD+LOCATION_GRAVE,1,nil)
		or not Duel.SelectYesNo(tp,aux.Stringid(STRING_ID,2)) then return end
	Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_RTOHAND)
	local g=Duel.SelectMatchingCard(tp,filter,tp,0,LOCATION_ONFIELD+LOCATION_GRAVE,1,1,nil)
	Duel.SendtoHand(g,nil,REASON_EFFECT)
end
function s.spfilter(c,e,tp)
	return c:IsFaceup() and c:GetOriginalType()&TYPE_MONSTER~=0
		and c:GetOriginalAttribute()&ATTRIBUTE_LIGHT~=0 and c:GetOriginalRace()&RACE_FIEND~=0
		and c:IsCanBeSpecialSummoned(e,0,tp,false,false)
end
function s.sptg(e,tp,eg,ep,ev,re,r,rp,chk,chkc)
	if chkc then return chkc:IsControler(tp) and chkc:IsLocation(LOCATION_SZONE) and s.spfilter(chkc,e,tp) end
	if chk==0 then return Duel.GetLocationCount(tp,LOCATION_MZONE)>0
		and Duel.IsExistingTarget(s.spfilter,tp,LOCATION_SZONE,0,1,nil,e,tp) end
	Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_SPSUMMON)
	local g=Duel.SelectTarget(tp,s.spfilter,tp,LOCATION_SZONE,0,1,1,nil,e,tp)
	Duel.SetOperationInfo(0,CATEGORY_SPECIAL_SUMMON,g,1,tp,LOCATION_SZONE)
end
function s.spop(e,tp)
	local tc=Duel.GetFirstTarget()
	local c=e:GetHandler()
	if tc and tc:IsRelateToEffect(e) and tc:IsLocation(LOCATION_SZONE) and s.spfilter(tc,e,tp)
		and Duel.SpecialSummon(tc,0,tp,tp,false,false,POS_FACEUP)>0
		and c:IsLocation(LOCATION_HAND) and c:IsRelateToEffect(e) then
		Duel.BreakEffect()
		Duel.SendtoGrave(c,REASON_EFFECT)
	end
end

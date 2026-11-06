--PROTOGENESIS
local s,id=GetID()
local STRING_ID=132524183
local SET_TO_PROTO=0xe80d
function s.initial_effect(c)
	--Reveal 1 "To Proto" monster; Special Summon or banish it
	local e1=Effect.CreateEffect(c)
	e1:SetDescription(aux.Stringid(STRING_ID,0))
	e1:SetCategory(CATEGORY_SPECIAL_SUMMON+CATEGORY_REMOVE)
	e1:SetType(EFFECT_TYPE_ACTIVATE)
	e1:SetCode(EVENT_FREE_CHAIN)
	e1:SetCountLimit(1,id)
	e1:SetCost(s.revcost)
	e1:SetTarget(s.target)
	e1:SetOperation(s.activate)
	c:RegisterEffect(e1)
end
s.listed_series={SET_TO_PROTO}
function s.nsfilter(c)
	return c:IsSummonableCard() or c:IsMSetable(true,nil)
end
function s.filter(c,e,tp)
	return c:IsSetCard(SET_TO_PROTO) and c:IsType(TYPE_MONSTER)
		and ((s.nsfilter(c) and Duel.GetLocationCount(tp,LOCATION_MZONE)>0 and c:IsCanBeSpecialSummoned(e,0,tp,false,false))
			or (not s.nsfilter(c) and c:IsAbleToRemove()))
end
function s.revcost(e,tp,eg,ep,ev,re,r,rp,chk)
	if chk==0 then return Duel.IsExistingMatchingCard(s.filter,tp,LOCATION_HAND+LOCATION_DECK,0,1,nil,e,tp) end
	Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_CONFIRM)
	local tc=Duel.SelectMatchingCard(tp,s.filter,tp,LOCATION_HAND+LOCATION_DECK,0,1,1,nil,e,tp):GetFirst()
	Duel.ConfirmCards(1-tp,tc)
	if tc:IsLocation(LOCATION_HAND) then Duel.ShuffleHand(tp) end
	tc:CreateEffectRelation(e)
	e:SetLabelObject(tc)
end
function s.target(e,tp,eg,ep,ev,re,r,rp,chk)
	if chk==0 then return true end
	local tc=e:GetLabelObject()
	if s.nsfilter(tc) then
		Duel.SetOperationInfo(0,CATEGORY_SPECIAL_SUMMON,tc,1,tp,tc:GetLocation())
	else
		Duel.SetOperationInfo(0,CATEGORY_REMOVE,tc,1,tp,tc:GetLocation())
	end
end
function s.activate(e,tp,eg,ep,ev,re,r,rp)
	local tc=e:GetLabelObject()
	if not (tc and tc:IsRelateToEffect(e) and tc:IsLocation(LOCATION_HAND+LOCATION_DECK)) then return end
	local ok=false
	if s.nsfilter(tc) then
		Duel.Hint(HINT_CARD,0,id)
		ok=Duel.GetLocationCount(tp,LOCATION_MZONE)>0 and tc:IsCanBeSpecialSummoned(e,0,tp,false,false)
			and Duel.SpecialSummon(tc,0,tp,tp,false,false,POS_FACEUP)>0
	else
		Duel.Hint(HINT_CARD,0,id)
		ok=tc:IsAbleToRemove() and Duel.Remove(tc,POS_FACEUP,REASON_EFFECT)>0
	end
	if ok then
		local e1=Effect.CreateEffect(e:GetHandler())
		e1:SetType(EFFECT_TYPE_FIELD+EFFECT_TYPE_CONTINUOUS)
		e1:SetCode(EVENT_PHASE+PHASE_END)
		e1:SetCountLimit(1)
		e1:SetOperation(s.lpop)
		e1:SetReset(RESET_PHASE+PHASE_END)
		Duel.RegisterEffect(e1,tp)
	end
end
function s.lpfilter(c)
	return c:IsType(TYPE_MONSTER)
end
function s.lpop(e,tp,eg,ep,ev,re,r,rp)
	local g=Duel.GetMatchingGroup(s.lpfilter,tp,LOCATION_MZONE,0,nil)
	local val=0
	for tc in aux.Next(g) do
		val=val+math.max(0,tc:GetBaseAttack())+math.max(0,tc:GetBaseDefense())
	end
	if val>0 then
		Duel.SetLP(tp,math.max(0,Duel.GetLP(tp)-val))
	end
end

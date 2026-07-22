--Domestication
local s,id=GetID()
local STRING_ID=133201342
local SET_DOMESTICA=0xe302
local CARD_PIP_WILD=259394179
function s.initial_effect(c)
	--Reveal a Fusion Monster and 1 listed material, then send that Fusion Monster to the GY
	local e1=Effect.CreateEffect(c)
	e1:SetDescription(aux.Stringid(STRING_ID,0))
	e1:SetCategory(CATEGORY_TOGRAVE)
	e1:SetType(EFFECT_TYPE_ACTIVATE)
	e1:SetCode(EVENT_FREE_CHAIN)
	e1:SetCountLimit(1,id+EFFECT_COUNT_CODE_OATH)
	e1:SetTarget(s.target)
	e1:SetOperation(s.activate)
	c:RegisterEffect(e1)
	--Shuffle this card into the Deck instead
	local e2=Effect.CreateEffect(c)
	e2:SetDescription(aux.Stringid(STRING_ID,1))
	e2:SetType(EFFECT_TYPE_FIELD+EFFECT_TYPE_CONTINUOUS)
	e2:SetCode(EFFECT_SEND_REPLACE)
	e2:SetRange(LOCATION_GRAVE)
	e2:SetTarget(s.reptg)
	e2:SetValue(s.repval)
	e2:SetOperation(s.repop)
	c:RegisterEffect(e2)
end
function s.matfilter(c,fc)
	return c:IsType(TYPE_MONSTER) and (aux.IsMaterialListCode(fc,c:GetCode())
		or fc:IsCode(CARD_PIP_WILD) and c:IsSetCard(SET_DOMESTICA) and c:IsRace(RACE_FAIRY))
end
function s.exfilter(c,tp)
	return c:IsType(TYPE_FUSION) and c:IsRace(RACE_BEAST+RACE_WINDBEAST) and c:IsAbleToGrave()
		and Duel.IsExistingMatchingCard(s.matfilter,tp,LOCATION_DECK,0,1,nil,c)
end
function s.target(e,tp,eg,ep,ev,re,r,rp,chk)
	if chk==0 then return Duel.IsExistingMatchingCard(s.exfilter,tp,LOCATION_EXTRA,0,1,nil,tp) end
	Duel.SetOperationInfo(0,CATEGORY_TOGRAVE,nil,1,tp,LOCATION_EXTRA)
end
function s.activate(e,tp,eg,ep,ev,re,r,rp)
	if not e:GetHandler():IsRelateToEffect(e) then return end
	if not Duel.IsExistingMatchingCard(s.exfilter,tp,LOCATION_EXTRA,0,1,nil,tp) then return end
	Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_CONFIRM)
	local fc=Duel.SelectMatchingCard(tp,s.exfilter,tp,LOCATION_EXTRA,0,1,1,nil,tp):GetFirst()
	if not fc then return end
	Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_CONFIRM)
	local mc=Duel.SelectMatchingCard(tp,s.matfilter,tp,LOCATION_DECK,0,1,1,nil,fc):GetFirst()
	if not mc then return end
	local rg=Group.FromCards(fc,mc)
	Duel.ConfirmCards(1-tp,rg)
	Duel.ShuffleDeck(tp)
	Duel.SendtoGrave(fc,REASON_EFFECT)
end
function s.repfilter(c,tp)
	return c:IsControler(tp) and c:IsLocation(LOCATION_HAND) and c:GetDestination()==LOCATION_GRAVE
end
function s.reptg(e,tp,eg,ep,ev,re,r,rp,chk)
	local c=e:GetHandler()
	if chk==0 then return (r&REASON_EFFECT)~=0 and aux.NecroValleyFilter(Card.IsAbleToDeck)(c)
		and eg:IsExists(s.repfilter,1,nil,tp) end
	if Duel.SelectEffectYesNo(tp,c,aux.Stringid(STRING_ID,1)) then
		local g=eg:Filter(s.repfilter,nil,tp)
		local tc=g:GetFirst()
		if #g>1 then
			Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_TODECK)
			tc=g:Select(tp,1,1,nil):GetFirst()
		end
		e:SetLabelObject(tc)
		return true
	end
	return false
end
function s.repval(e,c)
	return c==e:GetLabelObject()
end
function s.repop(e,tp,eg,ep,ev,re,r,rp)
	local c=e:GetHandler()
	if aux.NecroValleyFilter(Card.IsAbleToDeck)(c) then
		Duel.SendtoDeck(c,nil,SEQ_DECKSHUFFLE,REASON_EFFECT+REASON_REPLACE)
	end
end

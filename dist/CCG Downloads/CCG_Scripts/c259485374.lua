--Heart of the Cards
local s,id=GetID()
function s.initial_effect(c)
	--Declare 1 card name
	local e1=Effect.CreateEffect(c)
	e1:SetDescription(aux.Stringid(id,0))
	e1:SetType(EFFECT_TYPE_ACTIVATE)
	e1:SetCode(EVENT_FREE_CHAIN)
	e1:SetCountLimit(1,id+EFFECT_COUNT_CODE_OATH)
	e1:SetOperation(s.activate)
	c:RegisterEffect(e1)
end
function s.activate(e,tp,eg,ep,ev,re,r,rp)
	Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_CODE)
	local code=Duel.AnnounceCard(tp)
	local e1=Effect.CreateEffect(e:GetHandler())
	e1:SetType(EFFECT_TYPE_FIELD+EFFECT_TYPE_CONTINUOUS)
	e1:SetCode(EVENT_PHASE+PHASE_END)
	e1:SetCountLimit(1)
	e1:SetLabel(code)
	e1:SetCondition(s.epcon)
	e1:SetOperation(s.epop)
	e1:SetReset(RESET_PHASE+PHASE_END,2)
	Duel.RegisterEffect(e1,tp)
end
function s.epcon(e,tp,eg,ep,ev,re,r,rp)
	return Duel.GetTurnPlayer()==1-tp
end
function s.namefilter(c,code)
	return c:IsCode(code) and c:IsAbleToDeck()
end
function s.otherfilter(c,tc)
	return c~=tc and c:IsAbleToDeck()
end
function s.epop(e,tp,eg,ep,ev,re,r,rp)
	local code=e:GetLabel()
	if not Duel.IsExistingMatchingCard(s.namefilter,tp,LOCATION_DECK,0,1,nil,code) then return end
	Duel.Hint(HINT_SELECTMSG,1-tp,HINTMSG_CONFIRM)
	local tc=Duel.SelectMatchingCard(1-tp,s.namefilter,tp,LOCATION_DECK,0,1,1,nil,code):GetFirst()
	if not tc or not Duel.IsExistingMatchingCard(s.otherfilter,tp,LOCATION_DECK,0,1,nil,tc) then return end
	Duel.Hint(HINT_SELECTMSG,1-tp,HINTMSG_CONFIRM)
	local oc=Duel.SelectMatchingCard(1-tp,s.otherfilter,tp,LOCATION_DECK,0,1,1,nil,tc):GetFirst()
	if not oc then return end
	local g=Group.FromCards(tc,oc)
	Duel.ConfirmCards(1-tp,g)
	local top=g:RandomSelect(1-tp,1)
	local rest=(g-top):GetFirst()
	local topc=top:GetFirst()
	Duel.ShuffleDeck(tp)
	Duel.MoveSequence(rest,SEQ_DECKTOP)
	Duel.MoveSequence(topc,SEQ_DECKTOP)
end

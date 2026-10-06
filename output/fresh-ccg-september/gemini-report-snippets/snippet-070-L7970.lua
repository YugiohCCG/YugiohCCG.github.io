--Stained Sorceress Silphia
local s,id=GetID()
local STRING_ID=133789143
local SET_STAIN=0xbc5
s.listed_series={SET_STAIN}
function s.initial_effect(c)
	Duel.EnableGlobalFlag(GLOBALFLAG_DECK_REVERSE_CHECK)
	c:EnableReviveLimit()
	aux.AddFusionProcFunRep(c,s.ffilter,2,true)
	c:SetUniqueOnField(1,0,id)
	--"Stain" monsters gain ATK during your turn
	local e1=Effect.CreateEffect(c)
	e1:SetType(EFFECT_TYPE_FIELD)
	e1:SetCode(EFFECT_UPDATE_ATTACK)
	e1:SetRange(LOCATION_MZONE)
	e1:SetTargetRange(LOCATION_MZONE,0)
	e1:SetCondition(s.atkcon)
	e1:SetTarget(aux.TargetBoolFunction(Card.IsSetCard,SET_STAIN))
	e1:SetValue(600)
	c:RegisterEffect(e1)
	--Shuffle 1 "Stain" monster into opponent's Deck next Standby Phase
	local e2=Effect.CreateEffect(c)
	e2:SetDescription(aux.Stringid(STRING_ID,0))
	e2:SetCategory(CATEGORY_TODECK)
	e2:SetType(EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_O)
	e2:SetCode(EVENT_SPSUMMON_SUCCESS)
	e2:SetProperty(EFFECT_FLAG_DELAY)
	e2:SetCondition(s.tdcon)
	e2:SetTarget(s.tdtg)
	e2:SetOperation(s.tdop)
	c:RegisterEffect(e2)
	--Once per Chain, when your opponent activates a card or effect
	local e3=Effect.CreateEffect(c)
	e3:SetDescription(aux.Stringid(STRING_ID,1))
	e3:SetCategory(CATEGORY_ATKCHANGE)
	e3:SetType(EFFECT_TYPE_QUICK_O)
	e3:SetCode(EVENT_CHAINING)
	e3:SetRange(LOCATION_MZONE)
	e3:SetCountLimit(1,EFFECT_COUNT_CODE_CHAIN)
	e3:SetCondition(s.chaincon)
	e3:SetTarget(s.chaintg)
	e3:SetOperation(s.chainop)
	c:RegisterEffect(e3)
end
function s.ffilter(c,fc,sub,mg,sg)
	return c:IsFusionSetCard(SET_STAIN) and (not sg or not sg:IsExists(Card.IsFusionCode,1,c,c:GetFusionCode()))
end
function s.atkcon(e)
	return Duel.GetTurnPlayer()==e:GetHandlerPlayer()
end
function s.faceupoppdeck(c,tp,reason)
	if Duel.SendtoDeck(c,1-tp,SEQ_DECKSHUFFLE,reason)==0 then return false end
	if not c:IsLocation(LOCATION_DECK) then return false end
	Duel.ShuffleDeck(1-tp)
	c:ReverseInDeck()
	return true
end
function s.tdcon(e,tp,eg,ep,ev,re,r,rp)
	return e:GetHandler():IsSummonType(SUMMON_TYPE_FUSION)
end
function s.tdtg(e,tp,eg,ep,ev,re,r,rp,chk)
	if chk==0 then return true end
	Duel.SetOperationInfo(0,CATEGORY_TODECK,nil,1,tp,LOCATION_DECK)
end
function s.tdop(e,tp,eg,ep,ev,re,r,rp)
	local e1=Effect.CreateEffect(e:GetHandler())
	e1:SetType(EFFECT_TYPE_FIELD+EFFECT_TYPE_CONTINUOUS)
	e1:SetCode(EVENT_PHASE+PHASE_STANDBY)
	e1:SetCountLimit(1)
	e1:SetLabel(Duel.GetTurnCount())
	e1:SetOperation(s.delayop)
	e1:SetReset(RESET_PHASE+PHASE_STANDBY,2)
	Duel.RegisterEffect(e1,tp)
end
function s.delayfilter(c)
	return c:IsSetCard(SET_STAIN) and c:IsType(TYPE_MONSTER) and c:IsAbleToDeck()
end
function s.delayop(e,tp,eg,ep,ev,re,r,rp)
	if Duel.GetTurnCount()==e:GetLabel() then return end
	e:Reset()
	Duel.Hint(HINT_CARD,0,id)
	Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_TODECK)
	local g=Duel.SelectMatchingCard(tp,s.delayfilter,tp,LOCATION_DECK,0,1,1,nil)
	local tc=g:GetFirst()
	if tc then s.faceupoppdeck(tc,tp,REASON_EFFECT) end
end
function s.chaincon(e,tp,eg,ep,ev,re,r,rp)
	return rp==1-tp
end
function s.banfilter(c)
	return c:IsType(TYPE_MONSTER) and c:IsAbleToRemove()
end
function s.stainfilter(c)
	return c:IsSetCard(SET_STAIN) and c:IsType(TYPE_MONSTER) and c:IsAbleToRemove()
end
function s.banchk(sg,e,tp)
	return #sg==2 and sg:IsExists(Card.IsControler,1,nil,tp) and sg:IsExists(s.stainfilter,1,nil)
end
function s.chaintg(e,tp,eg,ep,ev,re,r,rp,chk)
	local c=e:GetHandler()
	local b1=c:IsFaceup()
	local mg=Duel.GetMatchingGroup(s.banfilter,tp,LOCATION_MZONE,LOCATION_MZONE,nil)
	local b2=c:IsFaceup() and c:GetAttack()>=2000 and not c:IsHasEffect(EFFECT_REVERSE_UPDATE)
		and mg:CheckSubGroup(s.banchk,2,2,e,tp)
	if chk==0 then return b1 or b2 end
	local op=aux.SelectFromOptions(tp,
		{b1,aux.Stringid(STRING_ID,1),1},
		{b2,aux.Stringid(STRING_ID,2),2})
	e:SetLabel(op)
	if op==1 then
		e:SetCategory(CATEGORY_ATKCHANGE)
	elseif op==2 then
		e:SetCategory(CATEGORY_ATKCHANGE+CATEGORY_REMOVE)
		Duel.SetOperationInfo(0,CATEGORY_REMOVE,nil,2,PLAYER_ALL,LOCATION_MZONE)
	end
end
function s.retop(e,tp,eg,ep,ev,re,r,rp)
	local g=e:GetLabelObject()
	if g then
		local sg=g:Filter(Card.IsLocation,nil,LOCATION_REMOVED)
		for tc in aux.Next(sg) do
			Duel.ReturnToField(tc)
		end
		g:DeleteGroup()
	end
end
function s.registerreturn(e,tp,g)
	g:KeepAlive()
	local e1=Effect.CreateEffect(e:GetHandler())
	e1:SetType(EFFECT_TYPE_FIELD+EFFECT_TYPE_CONTINUOUS)
	e1:SetCode(EVENT_PHASE+PHASE_END)
	e1:SetCountLimit(1)
	e1:SetLabelObject(g)
	e1:SetOperation(s.retop)
	e1:SetReset(RESET_PHASE+PHASE_END)
	Duel.RegisterEffect(e1,tp)
end
function s.chainop(e,tp,eg,ep,ev,re,r,rp)
	local c=e:GetHandler()
	if not (c:IsRelateToEffect(e) and c:IsFaceup()) then return end
	if e:GetLabel()==1 then
		local e1=Effect.CreateEffect(c)
		e1:SetType(EFFECT_TYPE_SINGLE)
		e1:SetCode(EFFECT_UPDATE_ATTACK)
		e1:SetValue(300)
		e1:SetReset(RESET_EVENT+RESETS_STANDARD)
		c:RegisterEffect(e1)
	else
		if c:GetAttack()<2000 or c:IsHasEffect(EFFECT_REVERSE_UPDATE) then return end
		local atk=c:GetAttack()
		local e1=Effect.CreateEffect(c)
		e1:SetType(EFFECT_TYPE_SINGLE)
		e1:SetCode(EFFECT_UPDATE_ATTACK)
		e1:SetValue(-2000)
		e1:SetReset(RESET_EVENT+RESETS_STANDARD)
		c:RegisterEffect(e1)
		if not (c:IsRelateToEffect(e) and c:IsFaceup() and c:GetAttack()==atk-2000) then return end
		local mg=Duel.GetMatchingGroup(s.banfilter,tp,LOCATION_MZONE,LOCATION_MZONE,nil)
		if not mg:CheckSubGroup(s.banchk,2,2,e,tp) then return end
		Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_REMOVE)
		local sg=mg:SelectSubGroup(tp,s.banchk,false,2,2,e,tp)
		if sg and Duel.Remove(sg,POS_FACEUP,REASON_EFFECT+REASON_TEMPORARY)~=0 then
			s.registerreturn(e,tp,sg)
		end
	end
end

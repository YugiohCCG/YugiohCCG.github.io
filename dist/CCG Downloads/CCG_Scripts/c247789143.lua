--Stained Sorceress Silphia
local s,id=GetID()
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
	e2:SetDescription(aux.Stringid(id,0))
	e2:SetCategory(CATEGORY_TODECK)
	e2:SetType(EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_O)
	e2:SetCode(EVENT_SPSUMMON_SUCCESS)
	e2:SetProperty(EFFECT_FLAG_DELAY)
	e2:SetCountLimit(1,id,EFFECT_COUNT_CODE_OATH)
	e2:SetCondition(s.tdcon)
	e2:SetTarget(s.tdtg)
	e2:SetOperation(s.tdop)
	c:RegisterEffect(e2)
	--Once per Chain, when your opponent activates a card or effect
	local e3=Effect.CreateEffect(c)
	e3:SetDescription(aux.Stringid(id,1))
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
	e1:SetLabel(tp,Duel.GetTurnCount()+1)
	e1:SetOperation(s.delayop)
	e1:SetReset(RESET_PHASE+PHASE_STANDBY,2)
	Duel.RegisterEffect(e1,tp)
end
function s.delayfilter(c)
	return c:IsSetCard(SET_STAIN) and c:IsType(TYPE_MONSTER) and c:IsAbleToDeck()
end
function s.delayop(e,tp,eg,ep,ev,re,r,rp)
	local p,turn=e:GetLabel()
	if Duel.GetTurnCount()<turn then return end
	e:Reset()
	if not Duel.IsExistingMatchingCard(s.delayfilter,p,LOCATION_DECK,0,1,nil) then return end
	Duel.Hint(HINT_SELECTMSG,p,HINTMSG_TODECK)
	local g=Duel.SelectMatchingCard(p,s.delayfilter,p,LOCATION_DECK,0,1,1,nil)
	local tc=g:GetFirst()
	if tc then s.faceupoppdeck(tc,p,REASON_EFFECT) end
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
function s.banpairfilter(c,tp)
	return s.banfilter(c) and Duel.IsExistingMatchingCard(function(sc,tc) return sc~=tc and s.stainfilter(sc) end,tp,LOCATION_MZONE,0,1,nil,c)
end
function s.chaintg(e,tp,eg,ep,ev,re,r,rp,chk)
	local c=e:GetHandler()
	local b1=c:IsFaceup()
	local b2=c:IsFaceup() and c:GetAttack()>=2000
		and Duel.IsExistingMatchingCard(s.banpairfilter,tp,LOCATION_MZONE,LOCATION_MZONE,1,nil,tp)
	if chk==0 then return b1 or b2 end
	local op=aux.SelectFromOptions(tp,
		{b1,aux.Stringid(id,1),1},
		{b2,aux.Stringid(id,2),2})
	e:SetLabel(op)
	if op==1 then
		e:SetCategory(CATEGORY_ATKCHANGE)
	elseif op==2 then
		e:SetCategory(CATEGORY_ATKCHANGE+CATEGORY_REMOVE+CATEGORY_SPECIAL_SUMMON)
		Duel.SetOperationInfo(0,CATEGORY_REMOVE,nil,2,PLAYER_ALL,LOCATION_MZONE)
	end
end
function s.retop(e,tp,eg,ep,ev,re,r,rp)
	local g=e:GetLabelObject()
	if g then
		for tc in aux.Next(g) do
			if tc:IsLocation(LOCATION_REMOVED) then Duel.ReturnToField(tc) end
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
		if c:GetAttack()<2000 then return end
		local e1=Effect.CreateEffect(c)
		e1:SetType(EFFECT_TYPE_SINGLE)
		e1:SetCode(EFFECT_UPDATE_ATTACK)
		e1:SetValue(-2000)
		e1:SetReset(RESET_EVENT+RESETS_STANDARD)
		c:RegisterEffect(e1)
		if not (c:IsRelateToEffect(e) and c:IsFaceup()) then return end
		local g1=Duel.GetMatchingGroup(s.banfilter,tp,LOCATION_MZONE,LOCATION_MZONE,nil)
		local g2=Duel.GetMatchingGroup(s.stainfilter,tp,LOCATION_MZONE,0,nil)
		if #g1==0 or #g2==0 then return end
		Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_REMOVE)
		local sg1=g1:Select(tp,1,1,nil)
		Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_REMOVE)
		local sg2=g2:Select(tp,1,1,sg1:GetFirst())
		sg1:Merge(sg2)
		if Duel.Remove(sg1,POS_FACEUP,REASON_EFFECT+REASON_TEMPORARY)~=0 then
			s.registerreturn(e,tp,sg1)
		else
			sg1:DeleteGroup()
		end
	end
end

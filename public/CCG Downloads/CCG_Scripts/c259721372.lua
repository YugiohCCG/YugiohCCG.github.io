--Eclipse Observatory
local s,id=GetID()
local STRING_ID=133721372
local SET_ECLIPSE=0xf2f4
local SET_ECLIPSE_OBSERVER=0xeb17
local OBSERVER_MONSTERS={
	[259652372]=true,
	[259926839]=true,
	[259069729]=true,
	[259487387]=true,
	[259058125]=true,
	[259193076]=true,
	[259126370]=true,
	[259612312]=true,
}
function s.initial_effect(c)
	--Activate
	local e1=Effect.CreateEffect(c)
	e1:SetDescription(aux.Stringid(STRING_ID,0))
	e1:SetCategory(CATEGORY_TOHAND+CATEGORY_SEARCH+CATEGORY_DRAW)
	e1:SetType(EFFECT_TYPE_ACTIVATE)
	e1:SetCode(EVENT_FREE_CHAIN)
	e1:SetCountLimit(1,id+EFFECT_COUNT_CODE_OATH)
	e1:SetTarget(s.acttg)
	e1:SetOperation(s.actop)
	c:RegisterEffect(e1)
	--Negate and banish 1 monster your opponent Special Summoned
	local e2=Effect.CreateEffect(c)
	e2:SetDescription(aux.Stringid(STRING_ID,1))
	e2:SetCategory(CATEGORY_DISABLE+CATEGORY_REMOVE+CATEGORY_DRAW)
	e2:SetType(EFFECT_TYPE_FIELD+EFFECT_TYPE_TRIGGER_O)
	e2:SetCode(EVENT_SPSUMMON_SUCCESS)
	e2:SetRange(LOCATION_FZONE)
	e2:SetProperty(EFFECT_FLAG_DELAY+EFFECT_FLAG_CARD_TARGET)
	e2:SetCountLimit(1,id)
	e2:SetCondition(s.negcon)
	e2:SetTarget(s.negtg)
	e2:SetOperation(s.negop)
	c:RegisterEffect(e2)
end
s.listed_series={SET_ECLIPSE,SET_ECLIPSE_OBSERVER}
function s.isobservermonster(c)
	return c:IsType(TYPE_MONSTER) and (OBSERVER_MONSTERS[c:GetCode()] or c:IsSetCard(SET_ECLIPSE_OBSERVER))
end
function s.thfilter1(c)
	return s.isobservermonster(c) and c:IsAbleToHand()
end
function s.thfilter2(c)
	return c:IsSetCard(SET_ECLIPSE) and c:IsType(TYPE_QUICKPLAY) and c:IsAbleToHand()
end
function s.acttg(e,tp,eg,ep,ev,re,r,rp,chk)
	if chk==0 then return true end
	if Duel.IsPlayerCanDraw(1-tp,2)
		and Duel.IsExistingMatchingCard(s.thfilter1,tp,LOCATION_DECK,0,1,nil)
		and Duel.IsExistingMatchingCard(s.thfilter2,tp,LOCATION_DECK,0,1,nil) then
		Duel.SetOperationInfo(0,CATEGORY_TOHAND,nil,2,tp,LOCATION_DECK)
		Duel.SetOperationInfo(0,CATEGORY_DRAW,nil,0,1-tp,2)
	end
end
function s.actop(e,tp,eg,ep,ev,re,r,rp)
	if not (Duel.IsPlayerCanDraw(1-tp,2)
		and Duel.IsExistingMatchingCard(s.thfilter1,tp,LOCATION_DECK,0,1,nil)
		and Duel.IsExistingMatchingCard(s.thfilter2,tp,LOCATION_DECK,0,1,nil))
		or not Duel.SelectYesNo(tp,aux.Stringid(STRING_ID,0)) then return end
	Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_ATOHAND)
	local g1=Duel.SelectMatchingCard(tp,s.thfilter1,tp,LOCATION_DECK,0,1,1,nil)
	Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_ATOHAND)
	local g2=Duel.SelectMatchingCard(tp,s.thfilter2,tp,LOCATION_DECK,0,1,1,nil)
	g1:Merge(g2)
	if #g1==2 and Duel.SendtoHand(g1,nil,REASON_EFFECT)==2 then
		Duel.ConfirmCards(1-tp,g1)
		Duel.Draw(1-tp,2,REASON_EFFECT)
	end
end
function s.negfilter(c,e,tp)
	return c:IsControler(1-tp) and c:IsLocation(LOCATION_MZONE) and c:IsCanBeEffectTarget(e)
		and c:IsAbleToRemove() and aux.NegateMonsterFilter(c)
end
function s.negcon(e,tp,eg,ep,ev,re,r,rp)
	return Duel.IsPlayerCanDraw(1-tp,2) and eg:IsExists(s.negfilter,1,nil,e,tp)
end
function s.negtg(e,tp,eg,ep,ev,re,r,rp,chk,chkc)
	if chkc then return eg:IsContains(chkc) and s.negfilter(chkc,e,tp) end
	if chk==0 then return eg:IsExists(s.negfilter,1,nil,e,tp) end
	Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_DISABLE)
	local g=eg:Filter(s.negfilter,nil,e,tp)
	local tc=g:Select(tp,1,1,nil):GetFirst()
	Duel.SetTargetCard(tc)
	Duel.SetOperationInfo(0,CATEGORY_DISABLE,tc,1,0,0)
	Duel.SetOperationInfo(0,CATEGORY_REMOVE,tc,1,0,0)
	Duel.SetOperationInfo(0,CATEGORY_DRAW,nil,0,1-tp,2)
end
function s.negop(e,tp,eg,ep,ev,re,r,rp)
	local tc=Duel.GetFirstTarget()
	if not (tc and tc:IsRelateToEffect(e) and tc:IsControler(1-tp)
		and tc:IsLocation(LOCATION_MZONE) and tc:IsFaceup()
		and tc:IsAbleToRemove() and tc:IsCanBeDisabledByEffect(e,false)) then return end
	Duel.NegateRelatedChain(tc,RESET_TURN_SET)
	local e1=Effect.CreateEffect(e:GetHandler())
	e1:SetType(EFFECT_TYPE_SINGLE)
	e1:SetProperty(EFFECT_FLAG_CANNOT_DISABLE)
	e1:SetCode(EFFECT_DISABLE)
	e1:SetReset(RESET_EVENT+RESETS_STANDARD)
	tc:RegisterEffect(e1)
	local e2=e1:Clone()
	e2:SetCode(EFFECT_DISABLE_EFFECT)
	e2:SetValue(RESET_TURN_SET)
	tc:RegisterEffect(e2)
	if tc:IsType(TYPE_TRAPMONSTER) then
		local e3=e1:Clone()
		e3:SetCode(EFFECT_DISABLE_TRAPMONSTER)
		tc:RegisterEffect(e3)
	end
	if Duel.Remove(tc,POS_FACEUP,REASON_EFFECT)>0 then
		Duel.BreakEffect()
		Duel.Draw(1-tp,2,REASON_EFFECT)
	end
end

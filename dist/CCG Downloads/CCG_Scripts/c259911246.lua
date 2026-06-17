--Mylo in the Wild
local s,id=GetID()
local SET_DOMESTICA=0xe302
local CARD_MYLO=259686203
s.listed_names={CARD_MYLO}
s.listed_series={SET_DOMESTICA}
function s.initial_effect(c)
	aux.AddMaterialCodeList(c,CARD_MYLO)
	aux.AddFusionProcFun2(c,aux.FilterBoolFunction(Card.IsFusionCode,CARD_MYLO),s.domfairy,true)
	c:EnableReviveLimit()
	--Cannot be Summoned while you control a monster
	local e0=Effect.CreateEffect(c)
	e0:SetType(EFFECT_TYPE_SINGLE)
	e0:SetProperty(EFFECT_FLAG_CANNOT_DISABLE+EFFECT_FLAG_UNCOPYABLE)
	e0:SetCode(EFFECT_SPSUMMON_CONDITION)
	e0:SetValue(s.splimit)
	c:RegisterEffect(e0)
	--Tribute this card; Set all monsters
	local e1=Effect.CreateEffect(c)
	e1:SetDescription(aux.Stringid(id,0))
	e1:SetCategory(CATEGORY_RELEASE+CATEGORY_POSITION)
	e1:SetType(EFFECT_TYPE_QUICK_O)
	e1:SetCode(EVENT_FREE_CHAIN)
	e1:SetRange(LOCATION_MZONE)
	e1:SetCountLimit(1,id)
	e1:SetCondition(s.poscon)
	e1:SetCost(s.cost)
	e1:SetTarget(s.postg)
	e1:SetOperation(s.posop)
	c:RegisterEffect(e1)
	--If sent to the GY: return this card to the Extra Deck, then add "Mylo, the Domesticated"
	local e2=Effect.CreateEffect(c)
	e2:SetDescription(aux.Stringid(id,1))
	e2:SetCategory(CATEGORY_TODECK+CATEGORY_TOHAND+CATEGORY_TOGRAVE)
	e2:SetType(EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_F)
	e2:SetCode(EVENT_TO_GRAVE)
	e2:SetProperty(EFFECT_FLAG_DELAY)
	e2:SetTarget(s.rettg)
	e2:SetOperation(s.retop)
	c:RegisterEffect(e2)
end
function s.domfairy(c)
	return c:IsFusionSetCard(SET_DOMESTICA) and c:IsRace(RACE_FAIRY)
end
function s.splimit(e,se,sp,st,pos,tp)
	return not Duel.IsExistingMatchingCard(aux.TRUE,sp,LOCATION_MZONE,0,1,nil)
end
function s.poscon(e,tp,eg,ep,ev,re,r,rp)
	return Duel.IsMainPhase() and not Duel.IsExistingMatchingCard(aux.TRUE,tp,LOCATION_MZONE,0,1,e:GetHandler())
end
function s.cost(e,tp,eg,ep,ev,re,r,rp,chk)
	local c=e:GetHandler()
	if chk==0 then return c:IsReleasable() end
	Duel.Release(c,REASON_COST)
end
function s.posfilter(c)
	return c:IsFaceup() and c:IsCanTurnSet()
end
function s.postg(e,tp,eg,ep,ev,re,r,rp,chk)
	if chk==0 then return Duel.IsExistingMatchingCard(s.posfilter,tp,LOCATION_MZONE,LOCATION_MZONE,1,e:GetHandler()) end
	local g=Duel.GetMatchingGroup(s.posfilter,tp,LOCATION_MZONE,LOCATION_MZONE,e:GetHandler())
	Duel.SetOperationInfo(0,CATEGORY_POSITION,g,#g,0,0)
end
function s.retfilter(c)
	return c:IsLocation(LOCATION_MZONE) and c:IsFacedown()
end
function s.endop(e,tp,eg,ep,ev,re,r,rp)
	local g=e:GetLabelObject()
	if g then
		local sg=g:Filter(s.retfilter,nil)
		if #sg>0 then
			Duel.ChangePosition(sg,POS_FACEUP_DEFENSE)
		end
		g:DeleteGroup()
	end
	e:Reset()
end
function s.posop(e,tp,eg,ep,ev,re,r,rp)
	local g=Duel.GetMatchingGroup(s.posfilter,tp,LOCATION_MZONE,LOCATION_MZONE,nil)
	if #g==0 or Duel.ChangePosition(g,POS_FACEDOWN_DEFENSE)==0 then return end
	local og=Duel.GetOperatedGroup()
	if #og==0 then return end
	og:KeepAlive()
	local e1=Effect.CreateEffect(e:GetHandler())
	e1:SetType(EFFECT_TYPE_FIELD+EFFECT_TYPE_CONTINUOUS)
	e1:SetCode(EVENT_PHASE+PHASE_END)
	e1:SetCountLimit(1)
	e1:SetLabelObject(og)
	e1:SetOperation(s.endop)
	e1:SetReset(RESET_PHASE+PHASE_END)
	Duel.RegisterEffect(e1,tp)
end
function s.mylofilter(c)
	return c:IsCode(CARD_MYLO) and c:IsAbleToHand()
end
function s.rettg(e,tp,eg,ep,ev,re,r,rp,chk)
	local c=e:GetHandler()
	if chk==0 then return c:IsAbleToExtra() end
	Duel.SetOperationInfo(0,CATEGORY_TODECK,c,1,0,0)
	Duel.SetOperationInfo(0,CATEGORY_TOHAND,nil,1,tp,LOCATION_DECK)
	Duel.SetOperationInfo(0,CATEGORY_TOGRAVE,nil,1,tp,LOCATION_HAND)
end
function s.retop(e,tp,eg,ep,ev,re,r,rp)
	local c=e:GetHandler()
	if not (c:IsRelateToEffect(e) and Duel.SendtoDeck(c,nil,SEQ_DECKSHUFFLE,REASON_EFFECT)>0 and c:IsLocation(LOCATION_EXTRA)) then return end
	if not Duel.IsExistingMatchingCard(s.mylofilter,tp,LOCATION_DECK,0,1,nil) then return end
	Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_ATOHAND)
	local tc=Duel.SelectMatchingCard(tp,s.mylofilter,tp,LOCATION_DECK,0,1,1,nil):GetFirst()
	if tc and Duel.SendtoHand(tc,nil,REASON_EFFECT)>0 and tc:IsLocation(LOCATION_HAND) then
		Duel.ConfirmCards(1-tp,tc)
		Duel.BreakEffect()
		if tc:IsAbleToGrave() then
			Duel.SendtoGrave(tc,REASON_EFFECT)
		end
	end
end

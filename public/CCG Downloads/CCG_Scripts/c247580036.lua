--Distained Druid Dragar
local s,id=GetID()
local STRING_ID=133580036
local SET_STAIN=0xbc5
s.listed_series={SET_STAIN}
function s.initial_effect(c)
	Duel.EnableGlobalFlag(GLOBALFLAG_DECK_REVERSE_CHECK)
	c:EnableReviveLimit()
	aux.AddFusionProcFun2(c,aux.FilterBoolFunction(Card.IsFusionSetCard,SET_STAIN),s.ffilter,true)
	--Tribute, gain LP, and Set opponent monsters
	local e1=Effect.CreateEffect(c)
	e1:SetDescription(aux.Stringid(STRING_ID,0))
	e1:SetCategory(CATEGORY_RECOVER+CATEGORY_POSITION)
	e1:SetType(EFFECT_TYPE_FIELD+EFFECT_TYPE_TRIGGER_O)
	e1:SetCode(EVENT_SPSUMMON_SUCCESS)
	e1:SetRange(LOCATION_MZONE)
	e1:SetProperty(EFFECT_FLAG_CARD_TARGET+EFFECT_FLAG_DELAY)
	e1:SetCountLimit(1,id+EFFECT_COUNT_CODE_OATH)
	e1:SetCondition(s.trcon)
	e1:SetCost(s.trcost)
	e1:SetTarget(s.trtg)
	e1:SetOperation(s.trop)
	c:RegisterEffect(e1)
	local e2=e1:Clone()
	e2:SetCode(EVENT_SUMMON_SUCCESS)
	c:RegisterEffect(e2)
end
function s.ffilter(c)
	return c:IsFusionSetCard(SET_STAIN) and not c:IsFusionAttribute(ATTRIBUTE_LIGHT)
end
function s.cfilter(c,tp,sc)
	return c==sc or c:IsControler(tp) and c:IsSetCard(SET_STAIN) and c:IsType(TYPE_MONSTER) and not c:IsAttribute(ATTRIBUTE_LIGHT)
end
function s.trcon(e,tp,eg,ep,ev,re,r,rp)
	return eg:IsExists(s.cfilter,1,nil,tp,e:GetHandler())
end
function s.costfilter(c)
	return c:IsType(TYPE_MONSTER) and (c:IsLocation(LOCATION_MZONE) and c:IsControler(c:GetControler()) and c:IsReleasable()
		or c:IsLocation(LOCATION_DECK) and c:IsFaceup() and c:IsAbleToGraveAsCost())
end
function s.trcost(e,tp,eg,ep,ev,re,r,rp,chk)
	local g1=Duel.GetMatchingGroup(Card.IsReleasable,tp,LOCATION_MZONE,0,nil)
	local g2=Duel.GetMatchingGroup(function(c) return c:IsFaceup() and c:IsType(TYPE_MONSTER) and c:IsAbleToGraveAsCost() end,tp,0,LOCATION_DECK,nil)
	g1:Merge(g2)
	if chk==0 then return #g1>0 end
	Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_RELEASE)
	local tc=g1:Select(tp,1,1,nil):GetFirst()
	if tc:IsLocation(LOCATION_MZONE) then
		Duel.Release(tc,REASON_COST)
	else
		Duel.SendtoGrave(tc,REASON_COST+REASON_RELEASE)
	end
end
function s.tgfilter(c)
	return c:IsFaceup() and c:IsType(TYPE_MONSTER)
end
function s.posfilter(c,tc)
	return c~=tc and c:IsFaceup() and c:IsCanTurnSet()
end
function s.trtg(e,tp,eg,ep,ev,re,r,rp,chk,chkc)
	if chkc then return chkc:IsControler(1-tp) and chkc:IsLocation(LOCATION_MZONE) and s.tgfilter(chkc) end
	if chk==0 then return Duel.IsExistingTarget(s.tgfilter,tp,0,LOCATION_MZONE,1,nil) end
	Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_FACEUP)
	local g=Duel.SelectTarget(tp,s.tgfilter,tp,0,LOCATION_MZONE,1,1,nil)
	local tc=g:GetFirst()
	Duel.SetOperationInfo(0,CATEGORY_RECOVER,nil,0,tp,math.max(tc:GetAttack(),0))
end
function s.trop(e,tp,eg,ep,ev,re,r,rp)
	local tc=Duel.GetFirstTarget()
	if not (tc and tc:IsRelateToEffect(e) and tc:IsFaceup()) then return end
	local atk=math.max(tc:GetAttack(),0)
	if atk>0 then Duel.Recover(tp,atk,REASON_EFFECT) end
	local g=Duel.GetMatchingGroup(s.posfilter,tp,0,LOCATION_MZONE,tc,tc)
	if #g>0 then
		Duel.ChangePosition(g,POS_FACEDOWN_DEFENSE)
	end
end

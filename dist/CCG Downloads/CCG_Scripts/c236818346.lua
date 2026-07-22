--Wicked Puppeteer, Orchis
local s,id=GetID()
local STRING_ID=132818346
local SET_WICKED_PUPPETEER=0xe0a9
local CARD_TRAGEDY=243306841
local TOKEN_PUPPET=234178974
function s.initial_effect(c)
	c:EnableReviveLimit()
	--Cannot be targeted while you control another monster
	local e1=Effect.CreateEffect(c)
	e1:SetType(EFFECT_TYPE_SINGLE)
	e1:SetProperty(EFFECT_FLAG_SINGLE_RANGE)
	e1:SetCode(EFFECT_CANNOT_BE_EFFECT_TARGET)
	e1:SetRange(LOCATION_MZONE)
	e1:SetCondition(s.tgcon)
	e1:SetValue(s.tgval)
	c:RegisterEffect(e1)
	--Banish 3 or 6 cards from the Extra Deck; Special Summon Tokens
	local e2=Effect.CreateEffect(c)
	e2:SetDescription(aux.Stringid(STRING_ID,0))
	e2:SetCategory(CATEGORY_SPECIAL_SUMMON+CATEGORY_TOKEN)
	e2:SetType(EFFECT_TYPE_IGNITION)
	e2:SetRange(LOCATION_MZONE)
	e2:SetCountLimit(1)
	e2:SetCost(s.tkcost)
	e2:SetTarget(s.tktg)
	e2:SetOperation(s.tkop)
	c:RegisterEffect(e2)
	--Tribute 1 monster; take control of 1 opponent's monster
	local e3=Effect.CreateEffect(c)
	e3:SetDescription(aux.Stringid(STRING_ID,1))
	e3:SetCategory(CATEGORY_CONTROL+CATEGORY_RELEASE)
	e3:SetType(EFFECT_TYPE_QUICK_O)
	e3:SetCode(EVENT_FREE_CHAIN)
	e3:SetRange(LOCATION_MZONE)
	e3:SetProperty(EFFECT_FLAG_CARD_TARGET)
	e3:SetCountLimit(1)
	e3:SetCost(s.ctcost)
	e3:SetTarget(s.cttg)
	e3:SetOperation(s.ctop)
	c:RegisterEffect(e3)
end
s.listed_series={SET_WICKED_PUPPETEER}
s.listed_names={CARD_TRAGEDY,TOKEN_PUPPET}
function s.tgcon(e)
	local c=e:GetHandler()
	local tp=c:GetControler()
	return Duel.IsExistingMatchingCard(aux.TRUE,tp,LOCATION_MZONE,0,1,c)
end
function s.tgval(e,re,rp)
	return rp==1-e:GetHandlerPlayer()
end
function s.cantoken(tp,ct)
	return Duel.GetLocationCount(tp,LOCATION_MZONE)>=ct
		and Duel.IsPlayerCanSpecialSummonMonster(tp,TOKEN_PUPPET,SET_WICKED_PUPPETEER,TYPES_TOKEN_MONSTER,1500,200,4,RACE_WARRIOR,ATTRIBUTE_DARK,POS_FACEUP_DEFENSE)
end
function s.canpay(tp,ct)
	return Duel.IsExistingMatchingCard(Card.IsAbleToRemoveAsCost,tp,LOCATION_EXTRA,0,ct,nil,POS_FACEDOWN)
		and s.cantoken(tp,ct//3)
end
function s.tkcost(e,tp,eg,ep,ev,re,r,rp,chk)
	local b3=s.canpay(tp,3)
	local b6=s.canpay(tp,6)
	if chk==0 then return b3 or b6 end
	local ct=3
	if b3 and b6 then
		ct=Duel.SelectOption(tp,aux.Stringid(STRING_ID,2),aux.Stringid(STRING_ID,3))==0 and 3 or 6
	elseif b6 then
		Duel.SelectOption(tp,aux.Stringid(STRING_ID,3))
		ct=6
	else
		Duel.SelectOption(tp,aux.Stringid(STRING_ID,2))
	end
	Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_REMOVE)
	local g=Duel.SelectMatchingCard(tp,Card.IsAbleToRemoveAsCost,tp,LOCATION_EXTRA,0,ct,ct,nil,POS_FACEDOWN)
	Duel.Remove(g,POS_FACEDOWN,REASON_COST)
	e:SetLabel(ct//3)
end
function s.tktg(e,tp,eg,ep,ev,re,r,rp,chk)
	if chk==0 then return s.canpay(tp,3) or s.canpay(tp,6) end
	local ct=e:GetLabel()
	Duel.SetOperationInfo(0,CATEGORY_TOKEN,nil,ct,tp,0)
	Duel.SetOperationInfo(0,CATEGORY_SPECIAL_SUMMON,nil,ct,tp,0)
end
function s.tkop(e,tp,eg,ep,ev,re,r,rp)
	local ct=math.min(e:GetLabel(),Duel.GetLocationCount(tp,LOCATION_MZONE))
	if ct<=0 or not s.cantoken(tp,1) then return end
	for i=1,ct do
		local token=Duel.CreateToken(tp,TOKEN_PUPPET)
		Duel.SpecialSummonStep(token,0,tp,tp,false,false,POS_FACEUP_DEFENSE)
	end
	Duel.SpecialSummonComplete()
end
function s.ctcost(e,tp,eg,ep,ev,re,r,rp,chk)
	if chk==0 then return Duel.CheckReleaseGroup(tp,Card.IsReleasable,1,nil) end
	Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_RELEASE)
	local g=Duel.SelectReleaseGroup(tp,Card.IsReleasable,1,1,nil)
	Duel.Release(g,REASON_COST)
end
function s.ctfilter(c)
	return c:IsControlerCanBeChanged()
end
function s.ctzone(tp)
	return Duel.GetLocationCount(tp,LOCATION_MZONE)>0
		or Duel.IsExistingMatchingCard(Card.IsReleasable,tp,LOCATION_MZONE,0,1,nil)
end
function s.cttg(e,tp,eg,ep,ev,re,r,rp,chk,chkc)
	if chkc then return chkc:IsControler(1-tp) and chkc:IsLocation(LOCATION_MZONE) and s.ctfilter(chkc) end
	if chk==0 then return s.ctzone(tp)
		and Duel.IsExistingTarget(s.ctfilter,tp,0,LOCATION_MZONE,1,nil) end
	Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_CONTROL)
	local g=Duel.SelectTarget(tp,s.ctfilter,tp,0,LOCATION_MZONE,1,1,nil)
	Duel.SetOperationInfo(0,CATEGORY_CONTROL,g,1,0,0)
end
function s.ctop(e,tp,eg,ep,ev,re,r,rp)
	local tc=Duel.GetFirstTarget()
	if tc and tc:IsRelateToEffect(e) and tc:IsControler(1-tp) and Duel.GetLocationCount(tp,LOCATION_MZONE)>0 then
		Duel.GetControl(tc,tp,PHASE_END,1)
	end
end

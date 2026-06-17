--Rei-Tachi Ga Kita Hi
local s,id=GetID()
function s.initial_effect(c)
	c:SetUniqueOnField(1,0,id)
	--Activate
	local e0=Effect.CreateEffect(c)
	e0:SetType(EFFECT_TYPE_ACTIVATE)
	e0:SetCode(EVENT_FREE_CHAIN)
	c:RegisterEffect(e0)
	--Shuffle up to 3 Spirit monsters from your GY into the Deck, then draw 1 card
	local e1=Effect.CreateEffect(c)
	e1:SetDescription(aux.Stringid(id,0))
	e1:SetCategory(CATEGORY_TODECK+CATEGORY_DRAW)
	e1:SetType(EFFECT_TYPE_IGNITION)
	e1:SetProperty(EFFECT_FLAG_CARD_TARGET)
	e1:SetRange(LOCATION_SZONE)
	e1:SetCountLimit(1)
	e1:SetTarget(s.tdtg)
	e1:SetOperation(s.tdop)
	c:RegisterEffect(e1)
	--Tribute Summoned Spirit monsters gain additional attacks
	local e2=Effect.CreateEffect(c)
	e2:SetType(EFFECT_TYPE_FIELD)
	e2:SetCode(EFFECT_EXTRA_ATTACK)
	e2:SetRange(LOCATION_SZONE)
	e2:SetTargetRange(LOCATION_MZONE,0)
	e2:SetCondition(s.atcon)
	e2:SetTarget(s.attg)
	e2:SetValue(s.atval)
	c:RegisterEffect(e2)
end
function s.tdfilter(c)
	return c:IsType(TYPE_SPIRIT) and c:IsType(TYPE_MONSTER) and c:IsAbleToDeck()
end
function s.tdtg(e,tp,eg,ep,ev,re,r,rp,chk,chkc)
	if chkc then return chkc:IsControler(tp) and chkc:IsLocation(LOCATION_GRAVE) and aux.NecroValleyFilter(s.tdfilter)(chkc) end
	if chk==0 then return Duel.IsPlayerCanDraw(tp,1)
		and Duel.IsExistingTarget(aux.NecroValleyFilter(s.tdfilter),tp,LOCATION_GRAVE,0,1,nil) end
	Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_TODECK)
	local g=Duel.SelectTarget(tp,aux.NecroValleyFilter(s.tdfilter),tp,LOCATION_GRAVE,0,1,3,nil)
	Duel.SetOperationInfo(0,CATEGORY_TODECK,g,#g,0,0)
	Duel.SetOperationInfo(0,CATEGORY_DRAW,nil,0,tp,1)
end
function s.tdop(e,tp,eg,ep,ev,re,r,rp)
	local g=Duel.GetTargetsRelateToChain():Filter(aux.NecroValleyFilter(s.tdfilter),nil)
	if #g>0 and Duel.SendtoDeck(g,nil,SEQ_DECKSHUFFLE,REASON_EFFECT)>0 then
		Duel.ShuffleDeck(tp)
		Duel.BreakEffect()
		Duel.Draw(tp,1,REASON_EFFECT)
	end
end
function s.atcon(e)
	return Duel.IsBattlePhase()
end
function s.attg(e,c)
	return c:IsFaceup() and c:IsType(TYPE_SPIRIT) and c:IsSummonType(SUMMON_TYPE_TRIBUTE)
end
function s.spiritfilter(c)
	return c:IsFaceup() and c:IsType(TYPE_SPIRIT)
end
function s.atval(e,c)
	return Duel.GetMatchingGroupCount(s.spiritfilter,c:GetControler(),LOCATION_MZONE,0,nil)
end

local s,id=GetID()
local STRING_ID=132940511
local SET_CARDIAN=0xe6
function s.initial_effect(c)
	aux.AddSynchroProcedure(c,nil,1,1,aux.NonTuner(nil),3,3)
	c:EnableReviveLimit()
	local e1=Effect.CreateEffect(c)
	e1:SetDescription(aux.Stringid(STRING_ID,0))
	e1:SetCategory(CATEGORY_TODECK+CATEGORY_DRAW)
	e1:SetType(EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_O)
	e1:SetCode(EVENT_SPSUMMON_SUCCESS)
	e1:SetProperty(EFFECT_FLAG_CARD_TARGET)
	e1:SetCondition(function(e) return e:GetHandler():IsSummonType(SUMMON_TYPE_SYNCHRO) end)
	e1:SetTarget(s.tdtg)
	e1:SetOperation(s.tdop)
	c:RegisterEffect(e1)
	local e2=Effect.CreateEffect(c)
	e2:SetDescription(aux.Stringid(STRING_ID,1))
	e2:SetCategory(CATEGORY_NEGATE+CATEGORY_DESTROY)
	e2:SetType(EFFECT_TYPE_QUICK_O)
	e2:SetCode(EVENT_CHAINING)
	e2:SetRange(LOCATION_MZONE)
	e2:SetCountLimit(1,id)
	e2:SetCondition(s.negcon)
	e2:SetTarget(s.negtg)
	e2:SetOperation(s.negop)
	c:RegisterEffect(e2)
	local e3=Effect.CreateEffect(c)
	e3:SetType(EFFECT_TYPE_SINGLE)
	e3:SetProperty(EFFECT_FLAG_SINGLE_RANGE)
	e3:SetRange(LOCATION_MZONE)
	e3:SetCode(EFFECT_SYNCHRO_MATERIAL_CUSTOM)
	e3:SetTarget(s.syntg)
	e3:SetValue(1)
	e3:SetOperation(s.synop)
	c:RegisterEffect(e3)
end
function s.tdfilter(c) return (c:IsType(TYPE_SPELL) or c:IsSetCard(SET_CARDIAN)) and c:IsAbleToDeck() end
function s.tdtg(e,tp,eg,ep,ev,re,r,rp,chk,chkc)
	if chkc then return chkc:IsControler(tp) and chkc:IsLocation(LOCATION_GRAVE) and aux.NecroValleyFilter(s.tdfilter)(chkc) end
	if chk==0 then return Duel.GetMatchingGroupCount(aux.NecroValleyFilter(s.tdfilter),tp,LOCATION_GRAVE,0,nil)>=5 and Duel.IsPlayerCanDraw(tp,1) end
	Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_TODECK)
	local g=Duel.SelectTarget(tp,aux.NecroValleyFilter(s.tdfilter),tp,LOCATION_GRAVE,0,5,5,nil)
	Duel.SetOperationInfo(0,CATEGORY_TODECK,g,5,0,0)
end
function s.tdop(e,tp)
	local g=Duel.GetChainInfo(0,CHAININFO_TARGET_CARDS):Filter(function(c,te) return c:IsRelateToEffect(te) and aux.NecroValleyFilter(s.tdfilter)(c) end,nil,e)
	if #g==5 and Duel.SendtoDeck(g,nil,SEQ_DECKSHUFFLE,REASON_EFFECT)==5 then Duel.Draw(tp,1,REASON_EFFECT) end
end
function s.negcon(e,tp,eg,ep,ev,re,r,rp) return rp==1-tp and re:IsActiveType(TYPE_MONSTER) and Duel.IsChainNegatable(ev) end
function s.negtg(e,tp,eg,ep,ev,re,r,rp,chk)
	if chk==0 then return true end
	Duel.SetOperationInfo(0,CATEGORY_NEGATE,eg,1,0,0)
end
function s.negop(e,tp,eg,ep,ev,re,r,rp)
	if Duel.NegateActivation(ev) and re:GetHandler():IsRelateToEffect(re) then Duel.Destroy(re:GetHandler(),REASON_EFFECT) end
end
function s.synfilter(c,syncard,tuner,f) return c:IsFaceupEx() and c:IsCanBeSynchroMaterial(syncard,tuner) and (not f or f(c,syncard)) end
function s.syntg(e,syncard,f,min,max)
	return syncard:IsSetCard(SET_CARDIAN)
end
function s.synop(e,tp,eg,ep,ev,re,r,rp,syncard,f,min,max)
	Duel.SetSynchroMaterial(Group.FromCards(e:GetHandler()))
end

local s,id=GetID()
local STRING_ID=133088629
local SET_GRAVINITY=0x760
local COUNTER_GRAVITY=0x1290
function s.initial_effect(c)
	aux.AddSynchroProcedure(c,aux.FilterBoolFunction(Card.IsSetCard,SET_GRAVINITY),1,1,aux.NonTuner(function(tc) return tc:IsRace(RACE_CYBERSE) and tc:IsType(TYPE_SYNCHRO) end),1,99)
	c:EnableReviveLimit()
	c:EnableCounterPermit(COUNTER_GRAVITY)
	local e0=Effect.CreateEffect(c)
	e0:SetType(EFFECT_TYPE_SINGLE)
	e0:SetProperty(EFFECT_FLAG_CANNOT_DISABLE+EFFECT_FLAG_UNCOPYABLE)
	e0:SetCode(EFFECT_CANNOT_DISABLE_SPSUMMON)
	c:RegisterEffect(e0)
	local e1=Effect.CreateEffect(c)
	e1:SetType(EFFECT_TYPE_FIELD+EFFECT_TYPE_CONTINUOUS)
	e1:SetCode(EVENT_SUMMON_SUCCESS)
	e1:SetRange(LOCATION_MZONE)
	e1:SetOperation(s.replaceop)
	c:RegisterEffect(e1)
	local e2=e1:Clone()
	e2:SetCode(EVENT_SPSUMMON_SUCCESS)
	c:RegisterEffect(e2)
	local e3=Effect.CreateEffect(c)
	e3:SetType(EFFECT_TYPE_FIELD+EFFECT_TYPE_CONTINUOUS)
	e3:SetCode(EVENT_SPSUMMON_SUCCESS)
	e3:SetRange(LOCATION_MZONE)
	e3:SetCondition(s.ctcon)
	e3:SetOperation(s.ctop)
	c:RegisterEffect(e3)
	local e4=Effect.CreateEffect(c)
	e4:SetDescription(aux.Stringid(STRING_ID,0))
	e4:SetCategory(CATEGORY_TODECK)
	e4:SetType(EFFECT_TYPE_QUICK_O)
	e4:SetCode(EVENT_FREE_CHAIN)
	e4:SetRange(LOCATION_MZONE)
	e4:SetProperty(EFFECT_FLAG_CARD_TARGET)
	e4:SetCost(s.tdcost)
	e4:SetTarget(s.tdtg)
	e4:SetOperation(s.tdop)
	c:RegisterEffect(e4)
end
function s.trapify(c)
	local e0=Effect.CreateEffect(c)
	e0:SetType(EFFECT_TYPE_SINGLE)
	e0:SetCode(EFFECT_CHANGE_TYPE)
	e0:SetValue(TYPE_TRAP+TYPE_CONTINUOUS)
	e0:SetReset(RESET_EVENT+RESETS_STANDARD)
	c:RegisterEffect(e0)
	local e1=Effect.CreateEffect(c)
	e1:SetDescription(aux.Stringid(STRING_ID,1))
	e1:SetCategory(CATEGORY_SPECIAL_SUMMON)
	e1:SetType(EFFECT_TYPE_IGNITION)
	e1:SetRange(LOCATION_SZONE)
	e1:SetCondition(function(te) return te:GetHandler():IsType(TYPE_TRAP) and Duel.IsMainPhase() end)
	e1:SetTarget(s.sptg)
	e1:SetOperation(s.spop)
	c:RegisterEffect(e1)
end
function s.replaceop(e,tp,eg)
	for tc in aux.Next(eg) do
		local p=tc:GetOwner()
		if not tc:IsPreviousLocation(LOCATION_SZONE) and tc:IsLocation(LOCATION_MZONE) and Duel.GetLocationCount(p,LOCATION_SZONE)>0
			and tc:IsRelateToEffect(e) and Duel.MoveToField(tc,tp,p,LOCATION_SZONE,POS_FACEUP,true) then s.trapify(tc) end
	end
end
function s.sptg(e,tp,eg,ep,ev,re,r,rp,chk)
	local c=e:GetHandler()
	if chk==0 then return Duel.GetLocationCount(tp,LOCATION_MZONE)>0 and c:IsCanBeSpecialSummoned(e,0,tp,true,false) end
	Duel.SetOperationInfo(0,CATEGORY_SPECIAL_SUMMON,c,1,tp,LOCATION_SZONE)
end
function s.xyzmat(c,xc) return c:IsType(TYPE_MONSTER) and c:IsLevel(xc:GetRank()) and c:IsCanOverlay() end
function s.spop(e,tp)
	local c=e:GetHandler()
	if not c:IsRelateToEffect(e) or Duel.SpecialSummon(c,0,tp,tp,true,false,POS_FACEUP)==0 or not c:IsType(TYPE_XYZ) then return end
	local g=Duel.GetMatchingGroup(aux.NecroValleyFilter(s.xyzmat),tp,LOCATION_GRAVE,0,nil,c)
	if #g>=2 then
		Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_XMATERIAL)
		Duel.Overlay(c,g:Select(tp,2,2,nil))
	end
end
function s.ctcon(e,tp,eg) return eg:IsExists(Card.IsPreviousLocation,1,nil,LOCATION_SZONE) and e:GetHandler():GetCounter(COUNTER_GRAVITY)<2 end
function s.ctop(e) e:GetHandler():AddCounter(COUNTER_GRAVITY,1) end
function s.tdcost(e,tp,eg,ep,ev,re,r,rp,chk)
	if chk==0 then return e:GetHandler():IsCanRemoveCounter(tp,COUNTER_GRAVITY,2,REASON_COST) end
	e:GetHandler():RemoveCounter(tp,COUNTER_GRAVITY,2,REASON_COST)
end
function s.oppfilter(c) return c:IsFaceup() and c:IsType(TYPE_MONSTER) and c:IsAbleToDeck() end
function s.ownfilter(c,oc) return c:IsSetCard(SET_GRAVINITY) and (c:GetOriginalType()&TYPE_MONSTER)~=0 and c:IsAbleToDeck() and oc:GetColumnGroup():IsContains(c) end
function s.tdtg(e,tp,eg,ep,ev,re,r,rp,chk,chkc)
	if chkc then return chkc:IsOnField() and chkc:IsAbleToDeck() end
	if chk==0 then return Duel.IsExistingTarget(function(c,p) return s.oppfilter(c) and Duel.IsExistingTarget(s.ownfilter,p,LOCATION_ONFIELD,0,1,nil,c) end,tp,0,LOCATION_MZONE,1,nil,tp) end
	Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_TODECK)
	local oc=Duel.SelectTarget(tp,function(c,p) return s.oppfilter(c) and Duel.IsExistingTarget(s.ownfilter,p,LOCATION_ONFIELD,0,1,nil,c) end,tp,0,LOCATION_MZONE,1,1,nil,tp):GetFirst()
	Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_TODECK)
	local gc=Duel.SelectTarget(tp,s.ownfilter,tp,LOCATION_ONFIELD,0,1,1,nil,oc):GetFirst()
	Duel.SetOperationInfo(0,CATEGORY_TODECK,Group.FromCards(oc,gc),2,0,0)
end
function s.tdop(e,tp)
	local g=Duel.GetChainInfo(0,CHAININFO_TARGET_CARDS):Filter(Card.IsRelateToEffect,nil,e)
	if #g==2 then Duel.SendtoDeck(g,nil,SEQ_DECKSHUFFLE,REASON_EFFECT) end
end

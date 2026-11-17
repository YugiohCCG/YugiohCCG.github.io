local s,id=GetID()
local SET_GLADIATOR=SET_GLADIATOR or 0x19
local SET_GLADIATOR_BEAST=SET_GLADIATOR_BEAST or 0x1019
local STRING_ID=133395418
function s.initial_effect(c)
	--Shuffle monsters you control; Special Summon "Gladiator Beast" monsters
	local e1=Effect.CreateEffect(c)
	e1:SetDescription(aux.Stringid(STRING_ID,0))
	e1:SetCategory(CATEGORY_TODECK+CATEGORY_SPECIAL_SUMMON)
	e1:SetType(EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_O)
	e1:SetProperty(EFFECT_FLAG_DELAY+EFFECT_FLAG_CARD_TARGET)
	e1:SetCode(EVENT_SPSUMMON_SUCCESS)
	e1:SetCountLimit(1,id)
	e1:SetCondition(s.gbspcon)
	e1:SetTarget(s.masssptg)
	e1:SetOperation(s.massspop)
	c:RegisterEffect(e1)
	--Shuffle this card into the Deck; Special Summon 1 "Gladiator Beast" monster
	local e2=Effect.CreateEffect(c)
	e2:SetDescription(aux.Stringid(STRING_ID,1))
	e2:SetCategory(CATEGORY_SPECIAL_SUMMON)
	e2:SetType(EFFECT_TYPE_FIELD+EFFECT_TYPE_TRIGGER_O)
	e2:SetCode(EVENT_PHASE+PHASE_BATTLE)
	e2:SetRange(LOCATION_MZONE)
	e2:SetCondition(s.battlecon)
	e2:SetCost(s.tdcost)
	e2:SetTarget(s.gbsptg)
	e2:SetOperation(s.gbspop)
	c:RegisterEffect(e2)
end
s.listed_series={SET_GLADIATOR,SET_GLADIATOR_BEAST}
function s.isgb(c)
	return c:IsType(TYPE_MONSTER) and (c:IsSetCard(SET_GLADIATOR_BEAST) or c:IsSetCard(SET_GLADIATOR))
end
function s.gbspcon(e,tp,eg,ep,ev,re,r,rp)
	if aux.gbspcon then
		return aux.gbspcon(e,tp,eg,ep,ev,re,r,rp)
	end
	local c=e:GetHandler()
	return c:GetFlagEffect(c:GetOriginalCode())>0
end
function s.tdfilter(c,e)
	return c:IsFaceup() and c:IsType(TYPE_MONSTER) and c:IsAbleToDeck()
		and c:IsCanBeEffectTarget(e)
end
function s.massspfilter(c,e,tp)
	return s.isgb(c) and not c:IsCode(id) and c:IsCanBeSpecialSummoned(e,100,tp,false,false)
end
function s.relfilter(c,e)
	return c:IsRelateToEffect(e) and c:IsControler(e:GetHandlerPlayer())
		and c:IsLocation(LOCATION_MZONE) and s.tdfilter(c,e)
end
function s.masssptg(e,tp,eg,ep,ev,re,r,rp,chk,chkc)
	local tg=Duel.GetMatchingGroup(s.tdfilter,tp,LOCATION_MZONE,0,nil,e)
	local dg=Duel.GetMatchingGroup(s.massspfilter,tp,LOCATION_DECK,0,nil,e,tp)
	local max=math.min(#tg,#dg)
	if Duel.IsPlayerAffectedByEffect(tp,59822133) then max=math.min(max,1) end
	if chkc then return chkc:IsLocation(LOCATION_MZONE) and chkc:IsControler(tp) and s.tdfilter(chkc,e) end
	if chk==0 then return max>0 end
	Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_TODECK)
	local g=Duel.SelectTarget(tp,s.tdfilter,tp,LOCATION_MZONE,0,1,max,nil,e)
	Duel.SetOperationInfo(0,CATEGORY_TODECK,g,#g,tp,LOCATION_MZONE)
	Duel.SetOperationInfo(0,CATEGORY_SPECIAL_SUMMON,nil,#g,tp,LOCATION_DECK)
end
function s.massspop(e,tp,eg,ep,ev,re,r,rp)
	local g=Duel.GetChainInfo(0,CHAININFO_TARGET_CARDS)
	if not g then return end
	g=g:Filter(s.relfilter,nil,e)
	if #g==0 then return end
	local ct=Duel.SendtoDeck(g,nil,SEQ_DECKSHUFFLE,REASON_EFFECT)
	ct=ct or #g
	local ft=Duel.GetLocationCount(tp,LOCATION_MZONE)
	if Duel.IsPlayerAffectedByEffect(tp,59822133) then ct=math.min(ct,1) end
	ct=math.min(ct,ft)
	if ct<=0 then return end
	local sg=Duel.GetMatchingGroup(s.massspfilter,tp,LOCATION_DECK,0,nil,e,tp)
	if #sg<ct then return end
	Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_SPSUMMON)
	local spg=sg:Select(tp,ct,ct,nil)
	local tc=spg:GetFirst()
	while tc do
		Duel.SpecialSummonStep(tc,100,tp,tp,false,false,POS_FACEUP)
		tc:RegisterFlagEffect(tc:GetOriginalCode(),RESET_EVENT+RESETS_STANDARD,0,0)
		tc=spg:GetNext()
	end
	Duel.SpecialSummonComplete()
end
function s.battlecon(e,tp,eg,ep,ev,re,r,rp)
	return e:GetHandler():GetBattledGroupCount()>0
end
function s.tdcost(e,tp,eg,ep,ev,re,r,rp,chk)
	local c=e:GetHandler()
	if chk==0 then return c:IsAbleToDeckAsCost() end
	Duel.SendtoDeck(c,nil,SEQ_DECKSHUFFLE,REASON_COST)
end
function s.gbfilter(c,e,tp)
	return s.isgb(c) and not c:IsCode(id) and c:IsCanBeSpecialSummoned(e,100,tp,false,false)
end
function s.mzonecheck(tp,c)
	return Duel.GetLocationCount(tp,LOCATION_MZONE)>0
		or (c and c:IsLocation(LOCATION_MZONE) and c:GetSequence()<5)
end
function s.gbsptg(e,tp,eg,ep,ev,re,r,rp,chk)
	if chk==0 then return s.mzonecheck(tp,e:GetHandler())
		and Duel.IsExistingMatchingCard(s.gbfilter,tp,LOCATION_DECK,0,1,nil,e,tp) end
	Duel.SetOperationInfo(0,CATEGORY_SPECIAL_SUMMON,nil,1,tp,LOCATION_DECK)
end
function s.gbspop(e,tp,eg,ep,ev,re,r,rp)
	if Duel.GetLocationCount(tp,LOCATION_MZONE)<=0 then return end
	Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_SPSUMMON)
	local tc=Duel.SelectMatchingCard(tp,s.gbfilter,tp,LOCATION_DECK,0,1,1,nil,e,tp):GetFirst()
	if tc and Duel.SpecialSummon(tc,100,tp,tp,false,false,POS_FACEUP)>0 then
		tc:RegisterFlagEffect(tc:GetOriginalCode(),RESET_EVENT+RESETS_STANDARD,0,0)
	end
end

local s,id=GetID()
local SET_GLADIATOR=SET_GLADIATOR or 0x19
local SET_GLADIATOR_BEAST=SET_GLADIATOR_BEAST or 0x1019
local STRING_ID=id
local TEST_MONSTERS={
	[3030892]=true,
	[62076252]=true,
	[66863374]=true,
	[92373006]=true,
}
function s.initial_effect(c)
	--Special Summon 1 Beast "Test" monster from your Deck
	local e1=Effect.CreateEffect(c)
	e1:SetDescription(aux.Stringid(STRING_ID,0))
	e1:SetCategory(CATEGORY_SPECIAL_SUMMON)
	e1:SetType(EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_O)
	e1:SetProperty(EFFECT_FLAG_DELAY)
	e1:SetCode(EVENT_SUMMON_SUCCESS)
	e1:SetCountLimit(1,id)
	e1:SetTarget(s.testsptg)
	e1:SetOperation(s.testspop)
	c:RegisterEffect(e1)
	local e2=e1:Clone()
	e2:SetCode(EVENT_SPSUMMON_SUCCESS)
	e2:SetCondition(s.gbspcon)
	c:RegisterEffect(e2)
	--Shuffle this card into the Deck; Special Summon 1 "Gladiator Beast" monster
	local e3=Effect.CreateEffect(c)
	e3:SetDescription(aux.Stringid(STRING_ID,1))
	e3:SetCategory(CATEGORY_SPECIAL_SUMMON)
	e3:SetType(EFFECT_TYPE_FIELD+EFFECT_TYPE_TRIGGER_O)
	e3:SetCode(EVENT_PHASE+PHASE_BATTLE)
	e3:SetRange(LOCATION_MZONE)
	e3:SetCondition(s.battlecon)
	e3:SetCost(s.tdcost)
	e3:SetTarget(s.gbsptg)
	e3:SetOperation(s.gbspop)
	c:RegisterEffect(e3)
end
s.listed_series={SET_GLADIATOR,SET_GLADIATOR_BEAST}
s.listed_names={3030892,62076252,66863374,92373006}
function s.isgb(c)
	return c:IsType(TYPE_MONSTER) and (c:IsSetCard(SET_GLADIATOR_BEAST) or c:IsSetCard(SET_GLADIATOR))
end
function s.istest(c)
	return TEST_MONSTERS[c:GetCode()] or TEST_MONSTERS[c:GetOriginalCode()]
end
function s.gbspcon(e,tp,eg,ep,ev,re,r,rp)
	if aux.gbspcon then
		return aux.gbspcon(e,tp,eg,ep,ev,re,r,rp)
	end
	local c=e:GetHandler()
	return c:GetFlagEffect(c:GetOriginalCode())>0
end
function s.testfilter(c,e,tp)
	return c:IsType(TYPE_MONSTER) and c:IsRace(RACE_BEAST) and s.istest(c)
		and c:IsCanBeSpecialSummoned(e,0,tp,false,false)
end
function s.testsptg(e,tp,eg,ep,ev,re,r,rp,chk)
	if chk==0 then return Duel.GetLocationCount(tp,LOCATION_MZONE)>0
		and Duel.IsExistingMatchingCard(s.testfilter,tp,LOCATION_DECK,0,1,nil,e,tp) end
	Duel.SetOperationInfo(0,CATEGORY_SPECIAL_SUMMON,nil,1,tp,LOCATION_DECK)
end
function s.testspop(e,tp,eg,ep,ev,re,r,rp)
	if Duel.GetLocationCount(tp,LOCATION_MZONE)<=0 then return end
	Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_SPSUMMON)
	local tc=Duel.SelectMatchingCard(tp,s.testfilter,tp,LOCATION_DECK,0,1,1,nil,e,tp):GetFirst()
	if tc then
		Duel.SpecialSummon(tc,0,tp,tp,false,false,POS_FACEUP)
	end
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

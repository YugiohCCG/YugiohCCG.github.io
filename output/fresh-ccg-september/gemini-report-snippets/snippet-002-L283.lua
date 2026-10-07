--Gladiator Beast Satyrius
local s,id=GetID()
local SET_GLADIATOR=0x19
local SET_GLADIATOR_BEAST=0x1019
local STRING_ID=133363148
local TEST_MONSTERS={
	[3030892]=true,
	[62076252]=true,
	[66863374]=true,
	[92373006]=true,
}
function s.initial_effect(c)
	--Fusion Material
	c:EnableReviveLimit()
	aux.AddFusionProcFunRep(c,s.matfilter,2,true)
	--Contact Fusion procedure (from hand and/or field into Deck or Extra Deck)
	aux.AddContactFusionProcedure(c,s.cfilter,LOCATION_HAND+LOCATION_MZONE,0,aux.ContactFusionSendToDeck(c)):SetValue(SUMMON_VALUE_SELF)
	--Must first be Special Summoned by its own procedure
	local e0=Effect.CreateEffect(c)
	e0:SetType(EFFECT_TYPE_SINGLE)
	e0:SetProperty(EFFECT_FLAG_CANNOT_DISABLE+EFFECT_FLAG_UNCOPYABLE)
	e0:SetCode(EFFECT_SPSUMMON_CONDITION)
	e0:SetValue(s.splimit)
	c:RegisterEffect(e0)
	--Special Summon 1 Level 4 or lower "Gladiator Beast" monster from Deck
	local e1=Effect.CreateEffect(c)
	e1:SetDescription(aux.Stringid(STRING_ID,0))
	e1:SetCategory(CATEGORY_SPECIAL_SUMMON)
	e1:SetType(EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_O)
	e1:SetProperty(EFFECT_FLAG_DELAY)
	e1:SetCode(EVENT_SPSUMMON_SUCCESS)
	e1:SetCountLimit(1,id)
	e1:SetTarget(s.decksptg)
	e1:SetOperation(s.deckspop)
	c:RegisterEffect(e1)
	--"Gladiator Beast" monsters you control gain 300 ATK
	local e2=Effect.CreateEffect(c)
	e2:SetType(EFFECT_TYPE_FIELD)
	e2:SetCode(EFFECT_UPDATE_ATTACK)
	e2:SetRange(LOCATION_MZONE)
	e2:SetTargetRange(LOCATION_MZONE,0)
	e2:SetTarget(aux.TargetBoolFunction(s.isgb))
	e2:SetValue(300)
	c:RegisterEffect(e2)
	--Return this card to Extra Deck; Special Summon 1 "Gladiator Beast" from Deck
	local e3=Effect.CreateEffect(c)
	e3:SetDescription(aux.Stringid(STRING_ID,1))
	e3:SetCategory(CATEGORY_SPECIAL_SUMMON)
	e3:SetType(EFFECT_TYPE_FIELD+EFFECT_TYPE_TRIGGER_O)
	e3:SetCode(EVENT_PHASE+PHASE_BATTLE)
	e3:SetRange(LOCATION_MZONE)
	e3:SetCondition(s.battlecon)
	e3:SetCost(s.extracost)
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
	return c:IsType(TYPE_MONSTER) and (TEST_MONSTERS[c:GetCode()] or TEST_MONSTERS[c:GetOriginalCode()])
end
function s.matfilter(c,fc,sumtype,tp)
	return s.isgb(c) or s.istest(c)
end
function s.cfilter(c)
	return s.matfilter(c) and c:IsAbleToDeckOrExtraAsCost()
end
function s.splimit(e,se,sp,st)
	return not e:GetHandler():IsLocation(LOCATION_EXTRA)
end
function s.deckspfilter(c,e,tp)
	return s.isgb(c) and c:IsLevelBelow(4) and c:IsCanBeSpecialSummoned(e,0,tp,false,false)
end
function s.decksptg(e,tp,eg,ep,ev,re,r,rp,chk)
	if chk==0 then return Duel.GetLocationCount(tp,LOCATION_MZONE)>0
		and Duel.IsExistingMatchingCard(s.deckspfilter,tp,LOCATION_DECK,0,1,nil,e,tp) end
	Duel.SetOperationInfo(0,CATEGORY_SPECIAL_SUMMON,nil,1,tp,LOCATION_DECK)
end
function s.deckspop(e,tp,eg,ep,ev,re,r,rp)
	if Duel.GetLocationCount(tp,LOCATION_MZONE)<=0 then return end
	Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_SPSUMMON)
	local tc=Duel.SelectMatchingCard(tp,s.deckspfilter,tp,LOCATION_DECK,0,1,1,nil,e,tp):GetFirst()
	if tc and Duel.SpecialSummon(tc,0,tp,tp,false,false,POS_FACEUP)>0 then
		tc:RegisterFlagEffect(tc:GetOriginalCode(),RESET_EVENT+RESETS_STANDARD+RESET_DISABLE,0,0)
	end
end
function s.battlecon(e,tp,eg,ep,ev,re,r,rp)
	return e:GetHandler():GetBattledGroupCount()>0
end
function s.extracost(e,tp,eg,ep,ev,re,r,rp,chk)
	local c=e:GetHandler()
	if chk==0 then return c:IsAbleToExtraAsCost() end
	Duel.SendtoDeck(c,nil,SEQ_DECKTOP,REASON_COST)
end
function s.gbfilter(c,e,tp)
	return s.isgb(c) and c:IsCanBeSpecialSummoned(e,0,tp,false,false)
end
function s.gbsptg(e,tp,eg,ep,ev,re,r,rp,chk)
	local c=e:GetHandler()
	if chk==0 then
		local ft=Duel.GetLocationCount(tp,LOCATION_MZONE)
		if c:GetSequence()<5 then ft=ft+1 end
		return ft>0 and Duel.IsExistingMatchingCard(s.gbfilter,tp,LOCATION_DECK,0,1,nil,e,tp)
	end
	Duel.SetOperationInfo(0,CATEGORY_SPECIAL_SUMMON,nil,1,tp,LOCATION_DECK)
end
function s.gbspop(e,tp,eg,ep,ev,re,r,rp)
	if Duel.GetLocationCount(tp,LOCATION_MZONE)<=0 then return end
	Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_SPSUMMON)
	local tc=Duel.SelectMatchingCard(tp,s.gbfilter,tp,LOCATION_DECK,0,1,1,nil,e,tp):GetFirst()
	if tc and Duel.SpecialSummon(tc,0,tp,tp,false,false,POS_FACEUP)>0 then
		tc:RegisterFlagEffect(tc:GetOriginalCode(),RESET_EVENT+RESETS_STANDARD+RESET_DISABLE,0,0)
	end
end
